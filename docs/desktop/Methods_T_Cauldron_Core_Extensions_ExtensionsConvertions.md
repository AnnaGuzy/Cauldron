# ExtensionsConvertions Methods
 _**\[This is preliminary documentation and is subject to change.\]**_

The <a href="T_Cauldron_Core_Extensions_ExtensionsConvertions">ExtensionsConvertions</a> type exposes the following members.


## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_As__1">As(T)</a></td><td>
Performs a cast between compatible reference types. If a convertion is not possible then null is returned.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_AsReadOnly__2">AsReadOnly(TKey, TValue)</a></td><td>
Converts a IDictionary(TKey, TValue) to a ReadOnlyDictionary(TKey, TValue).</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_Convert_2">Convert(String, Type)</a></td><td>
Converts a string to the type defined by *targetType*</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_Convert">Convert(Byte[], Encodings, Encodings)</a></td><td>
Converts a string represented by a byte array from a encoding to another encoding</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_Convert_1">Convert(String, Encodings, Encodings)</a></td><td>
Converts a string from a encoding to another encoding</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_Convert_3">Convert(String, Type, NumberFormatInfo)</a></td><td>
Converts a string to the type defined by *targetType*</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_Convert__1">Convert(T)(String)</a></td><td>
Converts a string to the type defined by *T*</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_Convert__1_1">Convert(T)(String, NumberFormatInfo)</a></td><td>
Converts a string to the type defined by *T*</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ConvertEscapeSequences">ConvertEscapeSequences</a></td><td>
Converts the readable escaped chars in a string to its equivalent char. This includes simple-escape-sequences such as \' \" \\ \0 \a \b \f \n \r \t \v</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ConvertToBytes">ConvertToBytes</a></td><td>
Converts a string from a encoding to another encoding</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToArray">ToArray</a></td><td>
Converts a IEnumerable to an array</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToBase64String">ToBase64String</a></td><td>
Converts a string to its equivalent string representation that is encoded with base-64 digits.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToBool">ToBool</a></td><td>
Converts a string to bool. 

 This will first try to compare the string to "true" and then to "false". If both fails then it will use TryParse(String, Boolean) to parse the string to bool. If that also fails then the string will be compared to "1".</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToByte">ToByte</a></td><td>
Converts the value to a byte If convertion fails the value will always be 0</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToBytes">ToBytes(Double)</a></td><td>
Converts the value to a byte array</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToBytes_1">ToBytes(Int32)</a></td><td>
Converts the value to a byte array</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToBytes_2">ToBytes(Int64)</a></td><td>
Converts the value to a byte array</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToBytes_3">ToBytes(Single)</a></td><td>
Converts the value to a byte array</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToBytes_4">ToBytes(UInt32)</a></td><td>
Converts the value to a byte array</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToBytesAsync">ToBytesAsync</a></td><td>
Converts a Stream to Byte array. If the stream is not seekable, then this will use ReadToEndAsync() to get the stream.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToChar">ToChar</a></td><td>
Converts the value to a char If convertion fails the value will always be '\0'</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToDecimal">ToDecimal(String)</a></td><td>
Tries to convert a String to an Decimal</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToDecimal_1">ToDecimal(String, NumberFormatInfo)</a></td><td>
Tries to convert a String to an Decimal</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToDecimalUS">ToDecimalUS</a></td><td>
Tries to convert a String to an Decimal using the en-US number format</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToDouble">ToDouble(String)</a></td><td>
Converts the string representation of a number in a specified culture-specific format to its double-precision floating-point number equivalent. if the string content is "nan" then a NaN is returned.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToDouble_1">ToDouble(String, NumberFormatInfo)</a></td><td>
Converts the string representation of a number in a specified culture-specific format to its double-precision floating-point number equivalent. if the string content is "nan" then a NaN is returned.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToDoubleUS">ToDoubleUS</a></td><td>
Converts the string representation of a number in the en-US format to its double-precision floating-point number equivalent. if the string content is "nan" then a NaN is returned.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToFloat">ToFloat(String)</a></td><td>
Converts the string representation of a number in a specified style and culture-specific format to its single-precision floating-point number equivalent. if the string content is "nan" then a NaN is returned.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToFloat_1">ToFloat(String, NumberFormatInfo)</a></td><td>
Converts the string representation of a number in a specified style and culture-specific format to its single-precision floating-point number equivalent. if the string content is "nan" then a NaN is returned.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToFloatUS">ToFloatUS</a></td><td>
Converts the string representation of a number in a the en-US format format to its single-precision floating-point number equivalent. if the string content is "nan" then a NaN is returned.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToInteger">ToInteger(Byte[])</a></td><td>
Returns a 32-bit signed integer converted from four bytes at a specified position in a byte array.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToInteger_1">ToInteger(String)</a></td><td>
Tries to convert a String to an Int32</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToInteger_2">ToInteger(String, NumberFormatInfo)</a></td><td>
Tries to convert a String to an Int32</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToIntegerUS">ToIntegerUS</a></td><td>
Tries to convert a String to an Int32 using the en-US number format</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToKeyedCollection__2">ToKeyedCollection(TKey, TSource)</a></td><td>
Creates a KeyedCollection(TKey, TItem) from an IEnumerable(T) according to a specified key selector function.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToLong">ToLong(Byte[])</a></td><td>
Returns a long converted from eight bytes.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToLong_1">ToLong(Object)</a></td><td>
Tries to convert a Object to an Int64</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToLong_2">ToLong(String)</a></td><td>
Tries to convert a String to an Int64</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToLong_3">ToLong(String, NumberFormatInfo)</a></td><td>
Tries to convert a String to an Int64</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToLongUS">ToLongUS</a></td><td>
Tries to convert a String to an Int64 using the en-US number format</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToShort">ToShort(String)</a></td><td>
Tries to convert a String to an Int16</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToShort_1">ToShort(String, NumberFormatInfo)</a></td><td>
Tries to convert a String to an Int16</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToShortUS">ToShortUS</a></td><td>
Tries to convert a String to an Int16 using the en-US number format</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToString_1">ToString(String, Object[])</a></td><td>
Replaces the format item in a specified string with the string representation of a corresponding object in a specified array. This also takes into account that *source* can be an inline text for the TextBlock. CurrentCulture is used as IFormatProvider</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToString">ToString(String, IFormatProvider, Object[])</a></td><td>
Replaces the format item in a specified string with the string representation of a corresponding object in a specified array. This also takes into account that *source* can be an inline text for the TextBlock</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToUInteger">ToUInteger(String)</a></td><td>
Tries to convert a String to an UInt32</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToUInteger_1">ToUInteger(String, NumberFormatInfo)</a></td><td>
Tries to convert a String to an UInt32</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToUIntegerUS">ToUIntegerUS</a></td><td>
Tries to convert a String to an UInt32 using the en-US number format</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToULong">ToULong(String)</a></td><td>
Tries to convert a String to an UInt64</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToULong_1">ToULong(String, NumberFormatInfo)</a></td><td>
Tries to convert a String to an UInt64</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToULongUS">ToULongUS</a></td><td>
Tries to convert a String to an UInt64 using the en-US number format</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToUshort">ToUshort(Byte[])</a></td><td>
Returns a 16-bit signed integer converted from four bytes at a specified position in a byte array.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToUshort_1">ToUshort(String)</a></td><td>
Tries to convert a String to an UInt16</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToUshort_2">ToUshort(String, NumberFormatInfo)</a></td><td>
Tries to convert a String to an UInt16</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToUShort">ToUShort(String)</a></td><td>
Tries to convert a String to an UInt16</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToUShort_1">ToUShort(String, NumberFormatInfo)</a></td><td>
Tries to convert a String to an UInt16</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToUshortUS">ToUshortUS</a></td><td>
Tries to convert a String to an UInt16 using the en-US number format</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Cauldron_Core_Extensions_ExtensionsConvertions_ToUShortUS">ToUShortUS</a></td><td>
Tries to convert a String to an UInt16 using the en-US number format</td></tr></table>&nbsp;
<a href="#extensionsconvertions-methods">Back to Top</a>

## See Also


#### Reference
<a href="T_Cauldron_Core_Extensions_ExtensionsConvertions">ExtensionsConvertions Class</a><br /><a href="N_Cauldron_Core_Extensions">Cauldron.Core.Extensions Namespace</a><br />