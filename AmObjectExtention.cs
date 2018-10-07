using System;   
using UnityEngine;   

namespace Am
{

public static class AmObjectExtention
{
    
    public static bool GetBool(this object src){	
	return Convert.ToBoolean(src);
    }
    public static int GetInt(this object src){	
	return Convert.ToInt32(src);
    }
    public static string GetString(this object src){	
	return Convert.ToString(src);
    }
    
}
}

/*
 * Local variables:
 * compile-command: "make"
 * End:
 */
