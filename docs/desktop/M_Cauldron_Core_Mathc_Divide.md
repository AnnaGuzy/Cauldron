# Mathc.Divide Method 
 _**\[This is preliminary documentation and is subject to change.\]**_

Divides *a* with *b*

 If *a* and *b* are null then null is returned. If *a* is null then 0 is returned. If *b* is null then *a* is returned; 

 Tries to cast primitiv Type and use the / operator. If the Type is unknown then reflection is used to determin the operator.

**Namespace:**&nbsp;<a href="N_Cauldron_Core">Cauldron.Core</a><br />**Assembly:**&nbsp;Cauldron.Core (in Cauldron.Core.dll) Version: 1.0.0.5 (1.0.0.5)

## Syntax

**C#**<br />
``` C#
public static Object Divide(
	Object a,
	Object b
)
```


#### Parameters
&nbsp;<dl><dt>a</dt><dd>Type: System.Object<br />The dividend</dd><dt>b</dt><dd>Type: System.Object<br />The divisor</dd></dl>

#### Return Value
Type: Object<br />Returns the quotient of the division

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td>ArgumentException</td><td>Operator cannot be applied</td></tr></table>

## See Also


#### Reference
<a href="T_Cauldron_Core_Mathc">Mathc Class</a><br /><a href="N_Cauldron_Core">Cauldron.Core Namespace</a><br />