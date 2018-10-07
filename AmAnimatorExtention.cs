using System;   
using UnityEngine;   

namespace am
{

public static class AmAnimatorExtention
{
    
    public static bool IsStateTagMatch(this AnimatorStateInfo src, string state){	
	return (src.tagHash == Animator.StringToHash(state)) ? true : false;
    }
    
}
}

/*
 * Local variables:
 * compile-command: "make -C../"
 * End:
 */

