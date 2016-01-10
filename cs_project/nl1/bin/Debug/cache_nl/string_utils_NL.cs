using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class string_utils_NL {

public static Imm NL_is_integer(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Dictionary<String, Imm> __function_map;
//line 10
___nl__1 = new ImmString("").clone();
//line 10
___nl__1 = new ImmString(___nl__0.toString() + ___nl__1.toString()).clone();
//line 11
___nl__2 = string_NL.NL_length(___nl__1).clone();

//line 12
___nl__3 = new ImmDouble(0).clone();
//line 12
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__1.toString().Equals(___nl__3.toString())).clone();
//line 12
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 12
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 12
___nl__4 = c_rt_lib_NL.NL_get_true().clone();
//line 12
___nl__0 = null;
//line 12
___nl__1 = null;
//line 12
___nl__2 = null;
//line 12
___nl__3 = null;
//line 12
if(true) return ___nl__4;
//line 12
___nl__4 = null;
//line 12
if (true) {goto label_2;}
//line 12
label_2:
//line 12
___nl__3 = null;
//line 13
___nl__3 = new ImmDouble(0).clone();
//line 14
___nl__4 = new ImmDouble(0).clone();
//line 14
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__2.getValue().ToString())) ==((Double.Parse(___nl__4.getValue().ToString())))  ).clone();
//line 14
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 14
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_4;}}
//line 14
___nl__5 = c_rt_lib_NL.NL_get_false().clone();
//line 14
___nl__0 = null;
//line 14
___nl__1 = null;
//line 14
___nl__2 = null;
//line 14
___nl__3 = null;
//line 14
___nl__4 = null;
//line 14
if(true) return ___nl__5;
//line 14
___nl__5 = null;
//line 14
if (true) {goto label_4;}
//line 14
label_4:
//line 14
___nl__4 = null;
//line 15
___nl__5 = new ImmDouble(1).clone();
//line 15
___nl__4 = string_NL.NL_substr(___nl__1,___nl__3,___nl__5).clone();

//line 15
___nl__5 = null;
//line 15
___nl__5 = new ImmString("-").clone();
//line 15
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__4.toString().Equals(___nl__5.toString())).clone();
//line 15
___nl__5 = null;
//line 15
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 15
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_6;}}
//line 15
___nl__5 = new ImmDouble(1).clone();
//line 15
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 15
___nl__5 = null;
//line 15
if (true) {goto label_6;}
//line 15
label_6:
//line 15
___nl__4 = null;
//line 16
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString())) ==((Double.Parse(___nl__2.getValue().ToString())))  ).clone();
//line 16
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_9;}}
//line 16
___nl__5 = new ImmDouble(1).clone();
//line 16
___nl__4 = string_NL.NL_substr(___nl__1,___nl__3,___nl__5).clone();

//line 16
___nl__5 = null;
//line 16
___nl__5 = new ImmDouble(0).clone();
//line 16
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__4.toString().Equals(___nl__5.toString())).clone();
//line 16
___nl__5 = null;
//line 16
label_9:
//line 16
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 16
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_8;}}
//line 16
___nl__5 = c_rt_lib_NL.NL_get_false().clone();
//line 16
___nl__0 = null;
//line 16
___nl__1 = null;
//line 16
___nl__2 = null;
//line 16
___nl__3 = null;
//line 16
___nl__4 = null;
//line 16
if(true) return ___nl__5;
//line 16
___nl__5 = null;
//line 16
if (true) {goto label_8;}
//line 16
label_8:
//line 16
___nl__4 = null;
//line 17
___nl__3 = ___nl__3.clone();
//line 17
label_11:
//line 17
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))<(Double.Parse(___nl__2.getValue().ToString())) ).clone();
//line 17
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 17
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_10;}}
//line 18
___nl__7 = new ImmDouble(1).clone();
//line 18
___nl__6 = string_NL.NL_substr(___nl__1,___nl__3,___nl__7).clone();

//line 18
___nl__7 = null;
//line 18
___nl__5 = string_NL.NL_is_digit(___nl__6).clone();

//line 18
___nl__6 = null;
//line 18
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 18
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 18
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_14;}}
//line 18
___nl__6 = c_rt_lib_NL.NL_get_false().clone();
//line 18
___nl__0 = null;
//line 18
___nl__1 = null;
//line 18
___nl__2 = null;
//line 18
___nl__3 = null;
//line 18
___nl__4 = null;
//line 18
___nl__5 = null;
//line 18
if(true) return ___nl__6;
//line 18
___nl__6 = null;
//line 18
if (true) {goto label_14;}
//line 18
label_14:
//line 18
___nl__5 = null;
//line 18
___nl__5 = new ImmDouble(1).clone();
//line 18
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 18
___nl__5 = null;
//line 19
if (true) {goto label_11;}
//line 19
label_10:
//line 19
___nl__4 = null;
//line 20
___nl__4 = c_rt_lib_NL.NL_get_true().clone();
//line 20
___nl__0 = null;
//line 20
___nl__1 = null;
//line 20
___nl__2 = null;
//line 20
___nl__3 = null;
//line 20
if(true) return ___nl__4;
//line 20
___nl__4 = null;
//line 20
___nl__1 = null;
//line 20
___nl__2 = null;
//line 20
___nl__3 = null;
//line 20
___nl__0 = null;
//line 20
if(true) return null;
}

public static Imm NL_is_float(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Dictionary<String, Imm> __function_map;
//line 24
___nl__1 = new ImmString("").clone();
//line 24
___nl__1 = new ImmString(___nl__0.toString() + ___nl__1.toString()).clone();
//line 25
___nl__2 = string_NL.NL_length(___nl__1).clone();

//line 26
___nl__3 = new ImmDouble(3).clone();
//line 26
___nl__3 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__2.getValue().ToString()))<(Double.Parse(___nl__3.getValue().ToString())) ).clone();
//line 26
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 26
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 26
___nl__4 = c_rt_lib_NL.NL_get_false().clone();
//line 26
___nl__0 = null;
//line 26
___nl__1 = null;
//line 26
___nl__2 = null;
//line 26
___nl__3 = null;
//line 26
if(true) return ___nl__4;
//line 26
___nl__4 = null;
//line 26
if (true) {goto label_2;}
//line 26
label_2:
//line 26
___nl__3 = null;
//line 27
___nl__3 = new ImmDouble(0).clone();
//line 28
___nl__5 = new ImmDouble(1).clone();
//line 28
___nl__4 = string_NL.NL_substr(___nl__1,___nl__3,___nl__5).clone();

//line 28
___nl__5 = null;
//line 28
___nl__5 = new ImmString("-").clone();
//line 28
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__4.toString().Equals(___nl__5.toString())).clone();
//line 28
___nl__5 = null;
//line 28
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 28
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_4;}}
//line 28
___nl__5 = new ImmDouble(1).clone();
//line 28
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 28
___nl__5 = null;
//line 28
if (true) {goto label_4;}
//line 28
label_4:
//line 28
___nl__4 = null;
//line 29
___nl__3 = ___nl__3.clone();
//line 29
label_6:
//line 29
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))<(Double.Parse(___nl__2.getValue().ToString())) ).clone();
//line 29
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 29
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_5;}}
//line 30
___nl__7 = new ImmDouble(1).clone();
//line 30
___nl__6 = string_NL.NL_substr(___nl__1,___nl__3,___nl__7).clone();

//line 30
___nl__7 = null;
//line 30
___nl__5 = string_NL.NL_is_digit(___nl__6).clone();

//line 30
___nl__6 = null;
//line 30
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 30
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 30
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_9;}}
//line 30
___nl__5 = null;
//line 30
if (true) {goto label_5;}
//line 30
if (true) {goto label_9;}
//line 30
label_9:
//line 30
___nl__5 = null;
//line 30
___nl__5 = new ImmDouble(1).clone();
//line 30
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 30
___nl__5 = null;
//line 31
if (true) {goto label_6;}
//line 31
label_5:
//line 31
___nl__4 = null;
//line 32
___nl__4 = new ImmDouble(1).clone();
//line 32
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))<(Double.Parse(___nl__4.getValue().ToString())) ).clone();
//line 32
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_12;}}
//line 32
___nl__4 = new ImmDouble(2).clone();
//line 32
___nl__4 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString()))).clone();
//line 32
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>(Double.Parse(___nl__2.getValue().ToString())) ).clone();
//line 32
label_12:
//line 32
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 32
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_11;}}
//line 32
___nl__5 = c_rt_lib_NL.NL_get_false().clone();
//line 32
___nl__0 = null;
//line 32
___nl__1 = null;
//line 32
___nl__2 = null;
//line 32
___nl__3 = null;
//line 32
___nl__4 = null;
//line 32
if(true) return ___nl__5;
//line 32
___nl__5 = null;
//line 32
if (true) {goto label_11;}
//line 32
label_11:
//line 32
___nl__4 = null;
//line 33
___nl__5 = new ImmDouble(1).clone();
//line 33
___nl__4 = string_NL.NL_substr(___nl__1,___nl__3,___nl__5).clone();

//line 33
___nl__5 = null;
//line 33
___nl__5 = new ImmString(".").clone();
//line 33
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__4.toString().Equals(___nl__5.toString())).clone();
//line 33
___nl__5 = null;
//line 33
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 33
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 33
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_14;}}
//line 33
___nl__5 = c_rt_lib_NL.NL_get_false().clone();
//line 33
___nl__0 = null;
//line 33
___nl__1 = null;
//line 33
___nl__2 = null;
//line 33
___nl__3 = null;
//line 33
___nl__4 = null;
//line 33
if(true) return ___nl__5;
//line 33
___nl__5 = null;
//line 33
if (true) {goto label_14;}
//line 33
label_14:
//line 33
___nl__4 = null;
//line 34
___nl__4 = new ImmDouble(1).clone();
//line 34
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString()))).clone();
//line 34
___nl__4 = null;
//line 34
label_16:
//line 34
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))<(Double.Parse(___nl__2.getValue().ToString())) ).clone();
//line 34
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 34
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_15;}}
//line 35
___nl__7 = new ImmDouble(1).clone();
//line 35
___nl__6 = string_NL.NL_substr(___nl__1,___nl__3,___nl__7).clone();

//line 35
___nl__7 = null;
//line 35
___nl__5 = string_NL.NL_is_digit(___nl__6).clone();

//line 35
___nl__6 = null;
//line 35
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 35
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 35
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_19;}}
//line 35
___nl__6 = c_rt_lib_NL.NL_get_false().clone();
//line 35
___nl__0 = null;
//line 35
___nl__1 = null;
//line 35
___nl__2 = null;
//line 35
___nl__3 = null;
//line 35
___nl__4 = null;
//line 35
___nl__5 = null;
//line 35
if(true) return ___nl__6;
//line 35
___nl__6 = null;
//line 35
if (true) {goto label_19;}
//line 35
label_19:
//line 35
___nl__5 = null;
//line 35
___nl__5 = new ImmDouble(1).clone();
//line 35
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 35
___nl__5 = null;
//line 36
if (true) {goto label_16;}
//line 36
label_15:
//line 36
___nl__4 = null;
//line 37
___nl__4 = c_rt_lib_NL.NL_get_true().clone();
//line 37
___nl__0 = null;
//line 37
___nl__1 = null;
//line 37
___nl__2 = null;
//line 37
___nl__3 = null;
//line 37
if(true) return ___nl__4;
//line 37
___nl__4 = null;
//line 37
___nl__1 = null;
//line 37
___nl__2 = null;
//line 37
___nl__3 = null;
//line 37
___nl__0 = null;
//line 37
if(true) return null;
}

public static Imm NL_is_number(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 41
___nl__1 = new ImmString("").clone();
//line 41
___nl__1 = new ImmString(___nl__0.toString() + ___nl__1.toString()).clone();
//line 42
___nl__2 = string_utils_NL.NL_is_integer(___nl__1).clone();

//line 42
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_1;}}
//line 42
___nl__2 = string_utils_NL.NL_is_float(___nl__1).clone();

//line 42
label_1:
//line 42
___nl__0 = null;
//line 42
___nl__1 = null;
//line 42
if(true) return ___nl__2;
//line 42
___nl__2 = null;
//line 42
___nl__1 = null;
//line 42
___nl__0 = null;
//line 42
if(true) return null;
}

}
}