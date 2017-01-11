# ExtensionsFileIO.ReadTextAsync Method (FileInfo)
 _**\[This is preliminary documentation and is subject to change.\]**_

Reads the contents of the specified file and returns text.

**Namespace:**&nbsp;<a href="N_Cauldron_Core_Extensions">Cauldron.Core.Extensions</a><br />**Assembly:**&nbsp;Cauldron.Core (in Cauldron.Core.dll) Version: 1.0.0.5 (1.0.0.5)

## Syntax

**C#**<br />
``` C#
public static Task<string> ReadTextAsync(
	this FileInfo file
)
```


#### Parameters
&nbsp;<dl><dt>file</dt><dd>Type: System.IO.FileInfo<br />The file to read.</dd></dl>

#### Return Value
Type: Task(String)<br />When this method completes successfully, it returns the contents of the file as a text string.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type FileInfo. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="http://msdn.microsoft.com/en-us/library/bb384936.aspx">Extension Methods (Visual Basic)</a> or <a href="http://msdn.microsoft.com/en-us/library/bb383977.aspx">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Cauldron_Core_Extensions_ExtensionsFileIO">ExtensionsFileIO Class</a><br /><a href="Overload_Cauldron_Core_Extensions_ExtensionsFileIO_ReadTextAsync">ReadTextAsync Overload</a><br /><a href="N_Cauldron_Core_Extensions">Cauldron.Core.Extensions Namespace</a><br />