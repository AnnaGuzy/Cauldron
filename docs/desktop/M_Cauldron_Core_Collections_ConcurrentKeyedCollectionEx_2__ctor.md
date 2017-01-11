# ConcurrentKeyedCollectionEx(*TKey*, *TItem*) Constructor (Func(*TItem*, *TKey*))
 _**\[This is preliminary documentation and is subject to change.\]**_

Initializes a new instance of the <a href="T_Cauldron_Core_Collections_ConcurrentKeyedCollectionEx_2">ConcurrentKeyedCollectionEx(TKey, TItem)</a> class that uses the default equality comparer.

**Namespace:**&nbsp;<a href="N_Cauldron_Core_Collections">Cauldron.Core.Collections</a><br />**Assembly:**&nbsp;Cauldron.Core (in Cauldron.Core.dll) Version: 1.0.0.5 (1.0.0.5)

## Syntax

**C#**<br />
``` C#
public ConcurrentKeyedCollectionEx(
	Func<TItem, TKey> keySelector
)
```


#### Parameters
&nbsp;<dl><dt>keySelector</dt><dd>Type: System.Func(<a href="T_Cauldron_Core_Collections_ConcurrentKeyedCollectionEx_2">*TItem*</a>, <a href="T_Cauldron_Core_Collections_ConcurrentKeyedCollectionEx_2">*TKey*</a>)<br />A function to extract a key from each element.</dd></dl>

## See Also


#### Reference
<a href="T_Cauldron_Core_Collections_ConcurrentKeyedCollectionEx_2">ConcurrentKeyedCollectionEx(TKey, TItem) Class</a><br /><a href="Overload_Cauldron_Core_Collections_ConcurrentKeyedCollectionEx_2__ctor">ConcurrentKeyedCollectionEx(TKey, TItem) Overload</a><br /><a href="N_Cauldron_Core_Collections">Cauldron.Core.Collections Namespace</a><br />