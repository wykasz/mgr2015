using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class enum_NL {

public static Imm NL_eq(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 10
___nl__2 = ov_NL.NL_has_value(___nl__0).clone();

//line 10
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_3;}}
//line 10
___nl__2 = ov_NL.NL_has_value(___nl__1).clone();

//line 10
label_3:
//line 10
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 10
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 10
___nl__3 = new ImmArray(new Imm[0]).clone();
//line 10
c_rt_lib_NL.NL_die();
//line 10
if (true) {goto label_2;}
//line 10
label_2:
//line 10
___nl__2 = null;
//line 10
___nl__3 = null;
//line 11
___nl__2 = ov_NL.NL_get_element(___nl__0).clone();

//line 11
___nl__3 = ov_NL.NL_get_element(___nl__1).clone();

//line 11
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 11
___nl__3 = null;
//line 11
___nl__0 = null;
//line 11
___nl__1 = null;
//line 11
if(true) return ___nl__2;
//line 11
___nl__2 = null;
//line 11
___nl__0 = null;
//line 11
___nl__1 = null;
//line 11
if(true) return null;
}

}
}