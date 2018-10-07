using UnityEngine;   
using UnityEngine.UI;   
using System;
using System.Linq;
using System.Collections; 
using System.Collections.Generic; 

namespace am
{

public static class AmLinqExtention
{
  
    // http://dottips.seesaa.net/article/158950599.html
    // 非ジェネリック辞書をジェネリック辞書に変換する拡張メソッド。
    public static Dictionary<TKey, TValue> AsDictionary<TKey, TValue>( 
	this IDictionary dic, 
	Func<DictionaryEntry, TKey> keySelector, 
	Func<DictionaryEntry, TValue> valueSelector ){	
	return dic
	    //.Cast<DictionaryEntry>()
	    .AsEnumerable()
	    .ToDictionary( keySelector, valueSelector );
    }
    
    // 非ジェネリックな辞書を LINQ で使えるデータソースに変換する
    // 拡張メソッド。
    public static IEnumerable<DictionaryEntry> AsEnumerable( 
	this IDictionary dic )
    {
	
	foreach( DictionaryEntry entry in dic ){
	    yield return entry;
	}
    }
    
    // http://stackoverflow.com/questions/5899171/is-there-anyway-to-handy-convert-a-dictionary-to-string
    public static string ToDebugString<TKey, TValue> (this IDictionary<TKey, TValue> dictionary)
    {	
	return "{" + string.Join(",", dictionary.Select(kv => kv.Key.ToString() + "=" + kv.Value.ToString()).ToArray()) + "}";
    }
    

    
}
}

/*
 * Local variables:
 * compile-command: "make -C../"
 * End:
 */
