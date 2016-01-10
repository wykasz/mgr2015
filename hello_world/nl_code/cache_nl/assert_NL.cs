using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class assert_NL {

public static Imm NL_section(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 6
___nl__1 = string_NL.NL_lf().clone();

//line 6
___nl__2 = string_NL.NL_lf().clone();

//line 6
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 6
___nl__2 = null;
//line 6
___nl__2 = new ImmString("Section: ").clone();
//line 6
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 6
___nl__2 = null;
//line 6
___nl__1 = new ImmString(___nl__1.toString() + ___nl__0.toString()).clone();
//line 6
___nl__2 = string_NL.NL_lf().clone();

//line 6
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 6
___nl__2 = null;
//line 6
nl_NL.NL_print(___nl__1);

//line 6
___nl__1 = null;
//line 6
___nl__0 = null;
//line 6
if(true) return null;
}

public static Imm NL_assert(Imm ___arg__0, Imm ___arg__1, Imm ___arg__2, Imm ___arg__3) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);Imm ___nl__2 = null;c_rt_lib_NL.NL_copy(ref ___nl__2, ___arg__2);Imm ___nl__3 = null;c_rt_lib_NL.NL_copy(ref ___nl__3, ___arg__3);
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
Imm ___nl__9 = null;
Dictionary<String, Imm> __function_map;
//line 10
___nl__4 = dfile_NL.NL_ssave(___nl__1).clone();

//line 11
___nl__5 = dfile_NL.NL_ssave(___nl__2).clone();

//line 12
___nl__6 = c_rt_lib_NL.NL_native_to_nl(___nl__4.toString().Equals(___nl__5.toString())).clone();
//line 13
___nl__7 = ___nl__6.clone();
//line 13
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 13
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_4;}}
//line 13
___nl__7 = ___nl__3.clone();
//line 13
label_4:
//line 13
___nl__8 = null;
//line 13
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_3;}}
//line 13
___nl__7 = ___nl__6.clone();
//line 13
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_5;}}
//line 13
___nl__7 = ___nl__3.clone();
//line 13
label_5:
//line 13
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 13
label_3:
//line 13
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 13
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_2;}}
//line 14
___nl__8 = new ImmString(" OK ").clone();
//line 14
___nl__8 = new ImmString(___nl__0.toString() + ___nl__8.toString()).clone();
//line 14
___nl__9 = string_NL.NL_lf().clone();

//line 14
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 14
___nl__9 = null;
//line 14
nl_NL.NL_print(___nl__8);

//line 14
___nl__8 = null;
//line 15
if (true) {goto label_1;}
//line 15
label_2:
//line 16
___nl__8 = new ImmString(" ERR ").clone();
//line 16
___nl__8 = new ImmString(___nl__0.toString() + ___nl__8.toString()).clone();
//line 16
___nl__9 = string_NL.NL_lf().clone();

//line 16
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 16
___nl__9 = null;
//line 16
nl_NL.NL_print(___nl__8);

//line 16
___nl__8 = null;
//line 17
if (true) {goto label_1;}
//line 17
label_1:
//line 17
___nl__7 = null;
//line 17
___nl__4 = null;
//line 17
___nl__5 = null;
//line 17
___nl__6 = null;
//line 17
___nl__0 = null;
//line 17
___nl__1 = null;
//line 17
___nl__2 = null;
//line 17
___nl__3 = null;
//line 17
if(true) return null;
}

}
}