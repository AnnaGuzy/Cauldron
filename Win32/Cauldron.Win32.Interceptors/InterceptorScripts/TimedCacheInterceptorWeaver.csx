﻿#r "System.Security"

using System;
using System.Text;
using Cauldron.Interception.Cecilator;
using Cauldron.Interception.Fody;
using Cauldron.Interception.Fody.HelperTypes;
using System.Security.Cryptography;
using System.Linq;
using Cauldron.Interception.Cecilator.Coders;

public static class TimedCacheInterceptorWeaver
{
    public const string Name = "TimedCache Interceptor";
    public const int Priority = 50;

    [Display("TimedCache Interceptor")]
    public static void ImplementTimedCache(Builder builder)
    {
        if (!__TimedCacheAttribute.IsReferenced)
            return;

        var timedCacheAttribute = __TimedCacheAttribute.Instance;
        var methods = builder.FindMethodsByAttribute(__TimedCacheAttribute.Type.Fullname);

        if (!methods.Any())
            return;

        var task = __Task.Instance;
        var task_1 = __Task_1.Instance;

        foreach (var method in methods)
        {
            builder.Log(LogTypes.Info, $"Implementing TimedCache in method {method.Method.Name}");

            if (method.Method.ReturnType.Fullname == "System.Void")
            {
                builder.Log(LogTypes.Warning, method.Method, "TimedCacheAttribute does not support void return types");
                continue;
            }

            var keyName = "<>timedcache_key";
            var timecacheVarName = "<>timedcache";

            if (method.AsyncMethod == null && method.Method.ReturnType.Inherits(__Task.Type.Fullname))
                builder.Log(LogTypes.Error, method.Method, $"- TimedCacheAttribute for method {method.Method.Name} will not be implemented. Methods that returns 'Task' without async are not supported.");
            else if (method.AsyncMethod == null)
                method.Method.NewCoder()
                    .Context(context =>
                    {
                        var timedCache = context.AssociatedMethod.GetOrCreateVariable(method.Attribute.Type, timecacheVarName);
                        var key = context.AssociatedMethod.GetOrCreateVariable(timedCacheAttribute.CreateKey.ReturnType, keyName);
                        var returnVariable = context.GetOrCreateReturnVariable();

                        context.SetValue(timedCache, x => x.NewObj(method));

                        // Create a cache key
                        context.SetValue(key, x => x.Call(timedCacheAttribute.CreateKey, GetHash(method.Method.Fullname), context.GetParametersArray()));

                        // check
                        context.If(x => x.Load(timedCache).Call(timedCacheAttribute.HasCache, key).Is(true), then =>
                              {
                                  return then.Load(timedCache).Call(timedCacheAttribute.GetCache, key).As(method.Method.ReturnType)
                                      .Return();
                              });

                        context.SetValue(returnVariable, x => x.OriginalBody(true));

                        // Set the cache
                        context.Load(timedCache).Call(timedCacheAttribute.SetCache, key, returnVariable);

                        return context.Load(returnVariable).Return();
                    })
                    .Replace();
            else if (method.AsyncMethod != null)
            {
                method.Method.NewCoder()
                    .Context(context =>
                    {
                        var taskReturnType = method.Method.ReturnType.GetGenericArgument(0);
                        var timedCache = context.AssociatedMethod.GetOrCreateVariable(method.Attribute.Type, timecacheVarName);
                        var cacheKey = context.AssociatedMethod.GetOrCreateVariable(timedCacheAttribute.CreateKey.ReturnType, keyName);

                        context.SetValue(cacheKey, x => x.Call(timedCacheAttribute.CreateKey, GetHash(method.Method.Fullname), context.GetParametersArray()));
                        context.SetValue(timedCache, x => x.NewObj(method));
                        context.If(x => x.Load(timedCache).Call(timedCacheAttribute.HasCache, cacheKey).Is(true), then =>
                              {
                                  return then.Call(task_1.FromResult.MakeGeneric(taskReturnType), x => x.Load(timedCache).Call(timedCacheAttribute.GetCache, cacheKey).As(taskReturnType))
                                     .Return();
                              });

                        return context;
                    }).Insert(InsertionPosition.Beginning);

                var position = method.Method.AsyncMethodHelper.GetAsyncTaskMethodBuilderStart();
                method.Method.NewCoder()
                    .Context(context =>
                    {
                        var key = context.AssociatedMethod.GetOrCreateVariable(timedCacheAttribute.CreateKey.ReturnType, keyName);
                        var timedCache = context.AssociatedMethod.GetOrCreateVariable(method.Attribute.Type, timecacheVarName);
                        var taskReturnType = method.Method.ReturnType.GetGenericArgument(0);
                        var asyncTaskMethodBuilder = builder
                            .GetType("System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1")
                            .MakeGeneric(taskReturnType);
                        var resultVariable = context.AssociatedMethod.Variables.FirstOrDefault(x => x.Type == asyncTaskMethodBuilder);
                        var asyncTaskMethodBuilderTask = asyncTaskMethodBuilder
                            .GetMethod("get_Task")
                            .MakeGeneric(taskReturnType);

                        return context
                            .Load(timedCache)
                            .Call(timedCacheAttribute.SetCache, x => key, x =>
                                x.Load(resultVariable)
                                    .Call(asyncTaskMethodBuilderTask)
                                    .Call(task_1.GetResult.MakeGeneric(taskReturnType)))
                            .End;
                    }).Insert(InsertionAction.After, position);
            }

            method.Attribute.Remove();
        }
    }

    private static string GetHash(this string target)
    {
        using (var md5 = new MD5CryptoServiceProvider())
            return BitConverter.ToString(md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(target))).Replace("-", "");
    }
}