using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class func_NL {

public static Imm NL_exec(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);
Imm ___nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 9
___nl__2 = c_std_lib_NL.NL_exec(___nl__0,ref ___nl__1).clone();

//line 9
___nl__0 = null;
//line 9
___nl__1 = null;
//line 9
if(true) return ___nl__2;
//line 9
___nl__2 = null;
//line 9
___nl__0 = null;
//line 9
___nl__1 = null;
//line 9
if(true) return null;
}

public static Imm NL_exec_ref(Imm ___arg__0, ref Imm ___arg__1) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);Imm ___nl__1 = ___arg__1;
Imm ___nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 13
___nl__2 = c_std_lib_NL.NL_exec(___nl__0,ref ___nl__1).clone();

//line 13
___nl__0 = null;
//line 13
___arg__1 = ___nl__1;if(true) return ___nl__2;
//line 13
___nl__2 = null;
//line 13
___nl__0 = null;
//line 13
___arg__1 = ___nl__1;if(true) return null;
}

}
}