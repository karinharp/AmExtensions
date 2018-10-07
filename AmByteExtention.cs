using System;   
using UnityEngine;   

namespace am
{

public static class AmByteExtention
{
    
    public static void Memcpy(this byte[] dst, byte dst){	
	fixed(byte *dst = &dstBuf.data[dstBuf.position]){
	    fixed(byte *src = &srcBuf.data[srcBuf.position])
	    {		
		for (int idx = 0; idx < size; ++idx){
		    dst[idx] = src[idx];
		}
	    }
	}
    }
    
}
}

/*
 * Local variables:
 * compile-command: "make -C../"
 * End:
 */
