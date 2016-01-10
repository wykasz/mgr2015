using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class generator_js_NL {

public static Imm NL_generate(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
Imm ___nl__9 = null;
Dictionary<String, Imm> __function_map;
//line 15
___nl__1 = new ImmString("").clone();
//line 16
___nl__2 = ((ImmHash)___nl__0).getHashValue()["functions"].clone();
//line 16
___nl__4 = new ImmDouble(0).clone();
//line 16
___nl__5 = new ImmDouble(1).clone();
//line 16
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__2).clone();

//line 16
label_3:
//line 16
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) ).clone();
//line 16
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_1;}}
//line 16
___nl__3 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()].clone();
//line 16
___nl__9 = ((ImmHash)___nl__0).getHashValue()["module_name"].clone();
//line 16
___nl__8 = generator_js_NL.NL_print_function_or_singleton_priv(___nl__3,___nl__9).clone();

//line 16
___nl__9 = null;
//line 16
___nl__1 = new ImmString(___nl__1.toString() + ___nl__8.toString()).clone();
//line 16
___nl__8 = null;
//line 16
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 16
if (true) {goto label_3;}
//line 16
label_1:
//line 16
___nl__2 = null;
//line 16
___nl__3 = null;
//line 16
___nl__4 = null;
//line 16
___nl__5 = null;
//line 16
___nl__6 = null;
//line 16
___nl__7 = null;
//line 17
___nl__0 = null;
//line 17
if(true) return ___nl__1;
//line 17
___nl__1 = null;
//line 17
___nl__0 = null;
//line 17
if(true) return null;
}

private static Imm NL_get_function_name_priv(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Dictionary<String, Imm> __function_map;
//line 21
___nl__2 = ((ImmHash)___nl__0).getHashValue()["access"].clone();
//line 21
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("pub")).clone();
//line 21
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 23
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("priv")).clone();
//line 23
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 23
___nl__3 = new ImmString("NOMATCHALERT").clone();
//line 23
___nl__3 = new ImmArray(new Imm[] {___nl__3,___nl__2,}).clone();
//line 23
c_rt_lib_NL.NL_die();
//line 21
label_2:
//line 22
___nl__4 = generator_js_NL.NL_escape_mod_fun_name_priv(___nl__1).clone();

//line 22
___nl__5 = new ImmDouble(0).clone();
//line 22
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 22
___nl__5 = null;
//line 22
___nl__6 = ((ImmHash)___nl__0).getHashValue()["name"].clone();
//line 22
___nl__5 = generator_js_NL.NL_escape_mod_fun_name_priv(___nl__6).clone();

//line 22
___nl__6 = null;
//line 22
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 22
___nl__5 = null;
//line 22
___nl__0 = null;
//line 22
___nl__1 = null;
//line 22
___nl__2 = null;
//line 22
___nl__3 = null;
//line 22
if(true) return ___nl__4;
//line 22
___nl__4 = null;
//line 23
if (true) {goto label_1;}
//line 23
label_3:
//line 24
___nl__4 = generator_js_NL.NL_escape_mod_fun_name_priv(___nl__1).clone();

//line 24
___nl__5 = new ImmString("_priv0").clone();
//line 24
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 24
___nl__5 = null;
//line 24
___nl__6 = ((ImmHash)___nl__0).getHashValue()["name"].clone();
//line 24
___nl__5 = generator_js_NL.NL_escape_mod_fun_name_priv(___nl__6).clone();

//line 24
___nl__6 = null;
//line 24
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 24
___nl__5 = null;
//line 24
___nl__0 = null;
//line 24
___nl__1 = null;
//line 24
___nl__2 = null;
//line 24
___nl__3 = null;
//line 24
if(true) return ___nl__4;
//line 24
___nl__4 = null;
//line 25
if (true) {goto label_1;}
//line 25
label_1:
//line 25
___nl__2 = null;
//line 25
___nl__3 = null;
//line 25
___nl__0 = null;
//line 25
___nl__1 = null;
//line 25
if(true) return null;
}

private static Imm NL_escape_mod_fun_name_priv(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 29
___nl__2 = new ImmDouble(0).clone();
//line 29
___nl__3 = new ImmString("00").clone();
//line 29
___nl__1 = string_NL.NL_replace(___nl__0,___nl__2,___nl__3).clone();

//line 29
___nl__3 = null;
//line 29
___nl__2 = null;
//line 29
___nl__0 = null;
//line 29
if(true) return ___nl__1;
//line 29
___nl__1 = null;
//line 29
___nl__0 = null;
//line 29
if(true) return null;
}

private static Imm NL_escape_string_priv(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 33
___nl__2 = new ImmString("\\").clone();
//line 33
___nl__3 = new ImmString("\\\\").clone();
//line 33
___nl__1 = string_NL.NL_replace(___nl__0,___nl__2,___nl__3).clone();

//line 33
___nl__3 = null;
//line 33
___nl__2 = null;
//line 33
___nl__0 = ___nl__1.clone();
//line 33
___nl__1 = null;
//line 34
___nl__2 = new ImmString("\"").clone();
//line 34
___nl__3 = new ImmString("\\\"").clone();
//line 34
___nl__1 = string_NL.NL_replace(___nl__0,___nl__2,___nl__3).clone();

//line 34
___nl__3 = null;
//line 34
___nl__2 = null;
//line 34
___nl__0 = ___nl__1.clone();
//line 34
___nl__1 = null;
//line 35
___nl__3 = new ImmDouble(13).clone();
//line 35
___nl__2 = string_NL.NL_chr(___nl__3).clone();

//line 35
___nl__3 = null;
//line 35
___nl__3 = string_NL.NL_lf().clone();

//line 35
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 35
___nl__3 = null;
//line 35
___nl__3 = new ImmString("\\r\\n").clone();
//line 35
___nl__1 = string_NL.NL_replace(___nl__0,___nl__2,___nl__3).clone();

//line 35
___nl__3 = null;
//line 35
___nl__2 = null;
//line 35
___nl__0 = ___nl__1.clone();
//line 35
___nl__1 = null;
//line 36
___nl__2 = string_NL.NL_lf().clone();

//line 36
___nl__3 = new ImmString("\\n").clone();
//line 36
___nl__1 = string_NL.NL_replace(___nl__0,___nl__2,___nl__3).clone();

//line 36
___nl__3 = null;
//line 36
___nl__2 = null;
//line 36
___nl__0 = null;
//line 36
if(true) return ___nl__1;
//line 36
___nl__1 = null;
//line 36
___nl__0 = null;
//line 36
if(true) return null;
}

private static Imm NL_is_singleton_use_function_priv(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
Imm ___nl__9 = null;
Imm ___nl__10 = null;
Imm ___nl__11 = null;
Imm ___nl__12 = null;
Imm ___nl__13 = null;
Dictionary<String, Imm> __function_map;
//line 39
___nl__2 = ((ImmHash)___nl__0).getHashValue()["args_type"].clone();
//line 39
___nl__1 = array_NL.NL_len(___nl__2).clone();

//line 39
___nl__2 = null;
//line 39
___nl__2 = new ImmDouble(0).clone();
//line 39
___nl__1 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__1.getValue().ToString()))>(Double.Parse(___nl__2.getValue().ToString())) ).clone();
//line 39
___nl__2 = null;
//line 39
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1)).clone();
//line 39
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_2;}}
//line 39
___nl__2 = c_rt_lib_NL.NL_get_false().clone();
//line 39
___nl__0 = null;
//line 39
___nl__1 = null;
//line 39
if(true) return ___nl__2;
//line 39
___nl__2 = null;
//line 39
if (true) {goto label_2;}
//line 39
label_2:
//line 39
___nl__1 = null;
//line 40
___nl__1 = ((ImmHash)___nl__0).getHashValue()["annotation"].clone();
//line 40
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("math")).clone();
//line 40
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1)).clone();
//line 40
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_4;}}
//line 40
___nl__2 = c_rt_lib_NL.NL_get_true().clone();
//line 40
___nl__0 = null;
//line 40
___nl__1 = null;
//line 40
if(true) return ___nl__2;
//line 40
___nl__2 = null;
//line 40
if (true) {goto label_4;}
//line 40
label_4:
//line 40
___nl__1 = null;
//line 41
___nl__1 = c_rt_lib_NL.NL_get_false().clone();
//line 43
___nl__3 = ((ImmHash)___nl__0).getHashValue()["commands"].clone();
//line 43
___nl__5 = new ImmDouble(0).clone();
//line 43
___nl__6 = new ImmDouble(1).clone();
//line 43
___nl__7 = c_rt_lib_NL.NL_array_len(___nl__3).clone();

//line 43
label_7:
//line 43
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) ).clone();
//line 43
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_5;}}
//line 43
___nl__4 = (___nl__3 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()].clone();
//line 44
___nl__9 = ((ImmHash)___nl__4).getHashValue()["cmd"].clone();
//line 45
___nl__10 = ___nl__9.clone();
//line 45
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__10, new ImmString("call")).clone();
//line 45
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 45
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_9;}}
//line 46
___nl__11 = ___nl__9.clone();
//line 46
___nl__11 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("call")).clone();
//line 47
___nl__12 = ((ImmHash)___nl__11).getHashValue()["fun_name"].clone();
//line 47
___nl__13 = new ImmString("sigleton_do_not_use_without_approval").clone();
//line 47
___nl__12 = c_rt_lib_NL.NL_native_to_nl(___nl__12.toString().Equals(___nl__13.toString())).clone();
//line 47
___nl__13 = null;
//line 47
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 47
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 47
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_11;}}
//line 47
___nl__9 = null;
//line 47
___nl__10 = null;
//line 47
___nl__11 = null;
//line 47
___nl__12 = null;
//line 47
if (true) {goto label_6;}
//line 47
if (true) {goto label_11;}
//line 47
label_11:
//line 47
___nl__12 = null;
//line 48
___nl__12 = ((ImmHash)___nl__11).getHashValue()["mod"].clone();
//line 48
___nl__13 = new ImmString("singleton").clone();
//line 48
___nl__12 = c_rt_lib_NL.NL_native_to_nl(___nl__12.toString().Equals(___nl__13.toString())).clone();
//line 48
___nl__13 = null;
//line 48
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 48
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 48
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_13;}}
//line 48
___nl__9 = null;
//line 48
___nl__10 = null;
//line 48
___nl__11 = null;
//line 48
___nl__12 = null;
//line 48
if (true) {goto label_6;}
//line 48
if (true) {goto label_13;}
//line 48
label_13:
//line 48
___nl__12 = null;
//line 49
___nl__12 = c_rt_lib_NL.NL_get_true().clone();
//line 49
___nl__1 = ___nl__12.clone();
//line 49
___nl__12 = null;
//line 50
___nl__12 = ((ImmHash)___nl__11).getHashValue()["dest"].clone();
//line 50
___nl__2 = ___nl__12.clone();
//line 50
___nl__12 = null;
//line 50
___nl__11 = null;
//line 51
if (true) {goto label_8;}
//line 51
label_9:
//line 51
___nl__10 = ___nl__9.clone();
//line 51
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__10, new ImmString("return")).clone();
//line 51
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 51
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_14;}}
//line 52
___nl__11 = ___nl__1.clone();
//line 52
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 52
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 52
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_16;}}
//line 52
___nl__12 = c_rt_lib_NL.NL_get_false().clone();
//line 52
___nl__0 = null;
//line 52
___nl__1 = null;
//line 52
___nl__2 = null;
//line 52
___nl__3 = null;
//line 52
___nl__4 = null;
//line 52
___nl__5 = null;
//line 52
___nl__6 = null;
//line 52
___nl__7 = null;
//line 52
___nl__8 = null;
//line 52
___nl__9 = null;
//line 52
___nl__10 = null;
//line 52
___nl__11 = null;
//line 52
if(true) return ___nl__12;
//line 52
___nl__12 = null;
//line 52
if (true) {goto label_16;}
//line 52
label_16:
//line 52
___nl__11 = null;
//line 53
___nl__11 = ___nl__9.clone();
//line 53
___nl__11 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("return")).clone();
//line 54
___nl__12 = ___nl__11.clone();
//line 54
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__12, new ImmString("val")).clone();
//line 54
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 54
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 54
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_18;}}
//line 54
___nl__13 = c_rt_lib_NL.NL_get_false().clone();
//line 54
___nl__0 = null;
//line 54
___nl__1 = null;
//line 54
___nl__2 = null;
//line 54
___nl__3 = null;
//line 54
___nl__4 = null;
//line 54
___nl__5 = null;
//line 54
___nl__6 = null;
//line 54
___nl__7 = null;
//line 54
___nl__8 = null;
//line 54
___nl__9 = null;
//line 54
___nl__10 = null;
//line 54
___nl__11 = null;
//line 54
___nl__12 = null;
//line 54
if(true) return ___nl__13;
//line 54
___nl__13 = null;
//line 54
if (true) {goto label_18;}
//line 54
label_18:
//line 54
___nl__12 = null;
//line 55
___nl__12 = ___nl__11.clone();
//line 55
___nl__12 = c_rt_lib_NL.NL_ov_as(___nl__12, new ImmString("val")).clone();
//line 55
___nl__12 = c_rt_lib_NL.NL_native_to_nl(___nl__12.toString().Equals(___nl__2.toString())).clone();
//line 55
___nl__0 = null;
//line 55
___nl__1 = null;
//line 55
___nl__2 = null;
//line 55
___nl__3 = null;
//line 55
___nl__4 = null;
//line 55
___nl__5 = null;
//line 55
___nl__6 = null;
//line 55
___nl__7 = null;
//line 55
___nl__8 = null;
//line 55
___nl__9 = null;
//line 55
___nl__10 = null;
//line 55
___nl__11 = null;
//line 55
if(true) return ___nl__12;
//line 55
___nl__12 = null;
//line 55
___nl__11 = null;
//line 56
if (true) {goto label_8;}
//line 56
label_14:
//line 56
___nl__10 = ___nl__9.clone();
//line 56
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__10, new ImmString("prt_lbl")).clone();
//line 56
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 56
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_19;}}
//line 57
if (true) {goto label_8;}
//line 57
label_19:
//line 57
___nl__10 = ___nl__9.clone();
//line 57
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__10, new ImmString("clear")).clone();
//line 57
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 57
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_20;}}
//line 58
if (true) {goto label_8;}
//line 58
label_20:
//line 59
___nl__11 = ___nl__1.clone();
//line 59
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 59
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_22;}}
//line 59
___nl__12 = c_rt_lib_NL.NL_get_false().clone();
//line 59
___nl__0 = null;
//line 59
___nl__1 = null;
//line 59
___nl__2 = null;
//line 59
___nl__3 = null;
//line 59
___nl__4 = null;
//line 59
___nl__5 = null;
//line 59
___nl__6 = null;
//line 59
___nl__7 = null;
//line 59
___nl__8 = null;
//line 59
___nl__9 = null;
//line 59
___nl__10 = null;
//line 59
___nl__11 = null;
//line 59
if(true) return ___nl__12;
//line 59
___nl__12 = null;
//line 59
if (true) {goto label_22;}
//line 59
label_22:
//line 59
___nl__11 = null;
//line 60
if (true) {goto label_8;}
//line 60
label_8:
//line 60
___nl__10 = null;
//line 60
___nl__9 = null;
//line 60
label_6:
//line 61
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString()))).clone();
//line 61
if (true) {goto label_7;}
//line 61
label_5:
//line 61
___nl__3 = null;
//line 61
___nl__4 = null;
//line 61
___nl__5 = null;
//line 61
___nl__6 = null;
//line 61
___nl__7 = null;
//line 61
___nl__8 = null;
//line 62
___nl__3 = c_rt_lib_NL.NL_get_false().clone();
//line 62
___nl__0 = null;
//line 62
___nl__1 = null;
//line 62
___nl__2 = null;
//line 62
if(true) return ___nl__3;
//line 62
___nl__3 = null;
//line 62
___nl__1 = null;
//line 62
___nl__2 = null;
//line 62
___nl__0 = null;
//line 62
if(true) return null;
}

private static Imm NL_print_function_or_singleton_priv(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
Imm ___nl__9 = null;
Dictionary<String, Imm> __function_map;
//line 67
___nl__2 = generator_js_NL.NL_is_singleton_use_function_priv(___nl__0).clone();

//line 67
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 67
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 68
___nl__3 = generator_js_NL.NL_get_function_name_priv(___nl__0,___nl__1).clone();

//line 69
___nl__4 = ___nl__0.clone();
//line 70
___nl__5 = new ImmString("SINGLETON__").clone();
//line 70
___nl__6 = ((ImmHash)___nl__0).getHashValue()["name"].clone();
//line 70
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 70
___nl__6 = null;
//line 70
___nl__6 = ___nl__5.clone();
//line 70
((ImmHash)___nl__4).set("name", ___nl__6);
//line 70
___nl__5 = null;
//line 70
___nl__6 = null;
//line 71
___nl__5 = generator_js_NL.NL_get_function_name_priv(___nl__4,___nl__1).clone();

//line 72
___nl__6 = new ImmString("value__singleton__").clone();
//line 72
___nl__6 = new ImmString(___nl__6.toString() + ___nl__5.toString()).clone();
//line 74
___nl__7 = generator_js_NL.NL_print_function_priv(___nl__4,___nl__1).clone();

//line 76
___nl__8 = new ImmString("var ").clone();
//line 76
___nl__8 = new ImmString(___nl__8.toString() + ___nl__6.toString()).clone();
//line 76
___nl__9 = new ImmString(";\nfunction ").clone();
//line 76
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 76
___nl__9 = null;
//line 76
___nl__8 = new ImmString(___nl__8.toString() + ___nl__3.toString()).clone();
//line 76
___nl__9 = new ImmString("(){\n	if (").clone();
//line 76
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 76
___nl__9 = null;
//line 76
___nl__8 = new ImmString(___nl__8.toString() + ___nl__6.toString()).clone();
//line 76
___nl__9 = new ImmString(" === undefined) {\n		").clone();
//line 76
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 76
___nl__9 = null;
//line 76
___nl__8 = new ImmString(___nl__8.toString() + ___nl__6.toString()).clone();
//line 76
___nl__9 = new ImmString(" = ").clone();
//line 76
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 76
___nl__9 = null;
//line 76
___nl__8 = new ImmString(___nl__8.toString() + ___nl__5.toString()).clone();
//line 76
___nl__9 = new ImmString("();\n	}\n	return ").clone();
//line 76
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 76
___nl__9 = null;
//line 76
___nl__8 = new ImmString(___nl__8.toString() + ___nl__6.toString()).clone();
//line 76
___nl__9 = new ImmString(";\n}").clone();
//line 76
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 76
___nl__9 = null;
//line 76
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 76
___nl__8 = null;
//line 83
___nl__0 = null;
//line 83
___nl__1 = null;
//line 83
___nl__2 = null;
//line 83
___nl__3 = null;
//line 83
___nl__4 = null;
//line 83
___nl__5 = null;
//line 83
___nl__6 = null;
//line 83
if(true) return ___nl__7;
//line 83
___nl__3 = null;
//line 83
___nl__4 = null;
//line 83
___nl__5 = null;
//line 83
___nl__6 = null;
//line 83
___nl__7 = null;
//line 84
if (true) {goto label_1;}
//line 84
label_2:
//line 85
___nl__3 = generator_js_NL.NL_print_function_priv(___nl__0,___nl__1).clone();

//line 85
___nl__0 = null;
//line 85
___nl__1 = null;
//line 85
___nl__2 = null;
//line 85
if(true) return ___nl__3;
//line 85
___nl__3 = null;
//line 86
if (true) {goto label_1;}
//line 86
label_1:
//line 86
___nl__2 = null;
//line 86
___nl__0 = null;
//line 86
___nl__1 = null;
//line 86
if(true) return null;
}

private static Imm NL_print_function_priv(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
Imm ___nl__9 = null;
Imm ___nl__10 = null;
Dictionary<String, Imm> __function_map;
//line 90
___nl__2 = string_NL.NL_lf().clone();

//line 90
___nl__3 = new ImmString("function ").clone();
//line 90
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 90
___nl__3 = null;
//line 91
___nl__3 = generator_js_NL.NL_get_function_name_priv(___nl__0,___nl__1).clone();

//line 91
___nl__4 = new ImmString("(").clone();
//line 91
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 91
___nl__4 = null;
//line 91
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 91
___nl__3 = null;
//line 92
___nl__4 = ((ImmHash)___nl__0).getHashValue()["args_type"].clone();
//line 92
___nl__3 = array_NL.NL_len(___nl__4).clone();

//line 92
___nl__4 = null;
//line 92
___nl__4 = new ImmDouble(0).clone();
//line 92
___nl__5 = new ImmDouble(1).clone();
//line 92
label_3:
//line 92
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__3.getValue().ToString())) ).clone();
//line 92
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_1;}}
//line 93
___nl__7 = new ImmDouble(0).clone();
//line 93
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString())) ==((Double.Parse(___nl__7.getValue().ToString())))  ).clone();
//line 93
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 93
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 93
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_5;}}
//line 93
___nl__8 = new ImmString(", ").clone();
//line 93
___nl__2 = new ImmString(___nl__2.toString() + ___nl__8.toString()).clone();
//line 93
___nl__8 = null;
//line 93
if (true) {goto label_5;}
//line 93
label_5:
//line 93
___nl__7 = null;
//line 94
___nl__7 = new ImmString("___arg__").clone();
//line 94
___nl__7 = new ImmString(___nl__7.toString() + ___nl__4.toString()).clone();
//line 94
___nl__2 = new ImmString(___nl__2.toString() + ___nl__7.toString()).clone();
//line 94
___nl__7 = null;
//line 95
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 95
if (true) {goto label_3;}
//line 95
label_1:
//line 95
___nl__3 = null;
//line 95
___nl__4 = null;
//line 95
___nl__5 = null;
//line 95
___nl__6 = null;
//line 96
___nl__3 = new ImmString(") {").clone();
//line 96
___nl__4 = string_NL.NL_lf().clone();

//line 96
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 96
___nl__4 = null;
//line 96
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 96
___nl__3 = null;
//line 97
___nl__4 = ((ImmHash)___nl__0).getHashValue()["args_type"].clone();
//line 97
___nl__3 = array_NL.NL_len(___nl__4).clone();

//line 97
___nl__4 = null;
//line 97
___nl__4 = new ImmDouble(0).clone();
//line 97
___nl__5 = new ImmDouble(1).clone();
//line 97
label_8:
//line 97
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__3.getValue().ToString())) ).clone();
//line 97
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_6;}}
//line 98
___nl__7 = ((ImmHash)___nl__0).getHashValue()["args_type"].clone();
//line 98
___nl__7 = (___nl__7 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()].clone();
//line 98
___nl__8 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("val")).clone();
//line 98
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_10;}}
//line 100
___nl__8 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("ref")).clone();
//line 100
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_11;}}
//line 100
___nl__8 = new ImmString("NOMATCHALERT").clone();
//line 100
___nl__8 = new ImmArray(new Imm[] {___nl__8,___nl__7,}).clone();
//line 100
c_rt_lib_NL.NL_die();
//line 98
label_10:
//line 99
___nl__9 = new ImmString("var ___nl__").clone();
//line 99
___nl__9 = new ImmString(___nl__9.toString() + ___nl__4.toString()).clone();
//line 99
___nl__10 = new ImmString(" = new ImRef(___arg__").clone();
//line 99
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 99
___nl__10 = null;
//line 99
___nl__9 = new ImmString(___nl__9.toString() + ___nl__4.toString()).clone();
//line 99
___nl__10 = new ImmString(".value);").clone();
//line 99
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 99
___nl__10 = null;
//line 99
___nl__2 = new ImmString(___nl__2.toString() + ___nl__9.toString()).clone();
//line 99
___nl__9 = null;
//line 100
if (true) {goto label_9;}
//line 100
label_11:
//line 101
___nl__9 = new ImmString("var ___nl__").clone();
//line 101
___nl__9 = new ImmString(___nl__9.toString() + ___nl__4.toString()).clone();
//line 101
___nl__10 = new ImmString(" = ___arg__").clone();
//line 101
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 101
___nl__10 = null;
//line 101
___nl__9 = new ImmString(___nl__9.toString() + ___nl__4.toString()).clone();
//line 101
___nl__10 = new ImmString(";").clone();
//line 101
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 101
___nl__10 = null;
//line 101
___nl__2 = new ImmString(___nl__2.toString() + ___nl__9.toString()).clone();
//line 101
___nl__9 = null;
//line 102
if (true) {goto label_9;}
//line 102
label_9:
//line 102
___nl__7 = null;
//line 102
___nl__8 = null;
//line 103
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 103
if (true) {goto label_8;}
//line 103
label_6:
//line 103
___nl__3 = null;
//line 103
___nl__4 = null;
//line 103
___nl__5 = null;
//line 103
___nl__6 = null;
//line 104
___nl__3 = string_NL.NL_lf().clone();

//line 104
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 104
___nl__3 = null;
//line 105
___nl__4 = ((ImmHash)___nl__0).getHashValue()["args_type"].clone();
//line 105
___nl__3 = array_NL.NL_len(___nl__4).clone();

//line 105
___nl__4 = null;
//line 105
label_13:
//line 105
___nl__4 = ((ImmHash)___nl__0).getHashValue()["reg_size"].clone();
//line 105
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))<(Double.Parse(___nl__4.getValue().ToString())) ).clone();
//line 105
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 105
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_12;}}
//line 106
___nl__5 = new ImmString("var ___nl__").clone();
//line 106
___nl__5 = new ImmString(___nl__5.toString() + ___nl__3.toString()).clone();
//line 106
___nl__6 = new ImmString(" = new ImRef(null);").clone();
//line 106
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 106
___nl__6 = null;
//line 106
___nl__6 = string_NL.NL_lf().clone();

//line 106
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 106
___nl__6 = null;
//line 106
___nl__2 = new ImmString(___nl__2.toString() + ___nl__5.toString()).clone();
//line 106
___nl__5 = null;
//line 106
___nl__5 = new ImmDouble(1).clone();
//line 106
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 106
___nl__5 = null;
//line 107
if (true) {goto label_13;}
//line 107
label_12:
//line 107
___nl__3 = null;
//line 107
___nl__4 = null;
//line 108
___nl__3 = new ImmString("var label = null; while (1) { switch (label) { default: ").clone();
//line 108
___nl__4 = string_NL.NL_lf().clone();

//line 108
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 108
___nl__4 = null;
//line 108
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 108
___nl__3 = null;
//line 109
___nl__3 = ((ImmHash)___nl__0).getHashValue()["commands"].clone();
//line 109
___nl__5 = new ImmDouble(0).clone();
//line 109
___nl__6 = new ImmDouble(1).clone();
//line 109
___nl__7 = c_rt_lib_NL.NL_array_len(___nl__3).clone();

//line 109
label_17:
//line 109
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) ).clone();
//line 109
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_15;}}
//line 109
___nl__4 = (___nl__3 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()].clone();
//line 109
___nl__9 = generator_js_NL.NL_print_command_priv(___nl__1,___nl__4).clone();

//line 109
___nl__2 = new ImmString(___nl__2.toString() + ___nl__9.toString()).clone();
//line 109
___nl__9 = null;
//line 109
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString()))).clone();
//line 109
if (true) {goto label_17;}
//line 109
label_15:
//line 109
___nl__3 = null;
//line 109
___nl__4 = null;
//line 109
___nl__5 = null;
//line 109
___nl__6 = null;
//line 109
___nl__7 = null;
//line 109
___nl__8 = null;
//line 110
___nl__3 = new ImmString("}}}").clone();
//line 110
___nl__3 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 110
___nl__4 = string_NL.NL_lf().clone();

//line 110
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 110
___nl__4 = null;
//line 110
___nl__0 = null;
//line 110
___nl__1 = null;
//line 110
___nl__2 = null;
//line 110
if(true) return ___nl__3;
//line 110
___nl__3 = null;
//line 110
___nl__2 = null;
//line 110
___nl__0 = null;
//line 110
___nl__1 = null;
//line 110
if(true) return null;
}

private static Imm NL_print_command_priv(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
Imm ___nl__9 = null;
Imm ___nl__10 = null;
Dictionary<String, Imm> __function_map;
//line 115
___nl__3 = ((ImmHash)___nl__1).getHashValue()["cmd"].clone();
//line 115
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("arr_decl")).clone();
//line 115
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 117
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("hash_decl")).clone();
//line 117
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_3;}}
//line 119
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("call")).clone();
//line 119
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_4;}}
//line 121
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("func")).clone();
//line 121
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_5;}}
//line 123
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("una_op")).clone();
//line 123
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_6;}}
//line 125
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("bin_op")).clone();
//line 125
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_7;}}
//line 127
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("ov_is")).clone();
//line 127
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_8;}}
//line 129
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("ov_as")).clone();
//line 129
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_9;}}
//line 131
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("return")).clone();
//line 131
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_10;}}
//line 133
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("die")).clone();
//line 133
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_11;}}
//line 135
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("move")).clone();
//line 135
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_12;}}
//line 137
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("load_const")).clone();
//line 137
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_13;}}
//line 139
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("get_frm_idx")).clone();
//line 139
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_14;}}
//line 141
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("set_at_idx")).clone();
//line 141
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_15;}}
//line 144
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("get_val")).clone();
//line 144
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_16;}}
//line 146
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("set_val")).clone();
//line 146
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_17;}}
//line 149
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("ov_mk")).clone();
//line 149
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_18;}}
//line 151
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("prt_lbl")).clone();
//line 151
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_19;}}
//line 153
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("if_goto")).clone();
//line 153
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_20;}}
//line 155
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("goto")).clone();
//line 155
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_21;}}
//line 157
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("clear")).clone();
//line 157
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_22;}}
//line 157
___nl__4 = new ImmString("NOMATCHALERT").clone();
//line 157
___nl__4 = new ImmArray(new Imm[] {___nl__4,___nl__3,}).clone();
//line 157
c_rt_lib_NL.NL_die();
//line 115
label_2:
//line 115
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("arr_decl")).clone();
//line 116
___nl__7 = ((ImmHash)___nl__5).getHashValue()["dest"].clone();
//line 116
___nl__6 = generator_js_NL.NL_print_register_to_assign_priv(___nl__7).clone();

//line 116
___nl__7 = null;
//line 116
___nl__8 = ((ImmHash)___nl__5).getHashValue()["src"].clone();
//line 116
___nl__7 = generator_js_NL.NL_print_arr_priv(___nl__8).clone();

//line 116
___nl__8 = null;
//line 116
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 116
___nl__7 = null;
//line 116
___nl__7 = new ImmString(";").clone();
//line 116
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 116
___nl__7 = null;
//line 116
___nl__2 = ___nl__6.clone();
//line 116
___nl__6 = null;
//line 116
___nl__5 = null;
//line 117
if (true) {goto label_1;}
//line 117
label_3:
//line 117
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("hash_decl")).clone();
//line 118
___nl__7 = ((ImmHash)___nl__5).getHashValue()["dest"].clone();
//line 118
___nl__6 = generator_js_NL.NL_print_register_to_assign_priv(___nl__7).clone();

//line 118
___nl__7 = null;
//line 118
___nl__8 = ((ImmHash)___nl__5).getHashValue()["src"].clone();
//line 118
___nl__7 = generator_js_NL.NL_print_hash_priv(___nl__8).clone();

//line 118
___nl__8 = null;
//line 118
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 118
___nl__7 = null;
//line 118
___nl__7 = new ImmString(";").clone();
//line 118
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 118
___nl__7 = null;
//line 118
___nl__2 = ___nl__6.clone();
//line 118
___nl__6 = null;
//line 118
___nl__5 = null;
//line 119
if (true) {goto label_1;}
//line 119
label_4:
//line 119
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("call")).clone();
//line 120
___nl__7 = ((ImmHash)___nl__5).getHashValue()["dest"].clone();
//line 120
___nl__6 = generator_js_NL.NL_print_register_to_assign_priv(___nl__7).clone();

//line 120
___nl__7 = null;
//line 120
___nl__8 = ((ImmHash)___nl__5).getHashValue()["mod"].clone();
//line 120
___nl__9 = ((ImmHash)___nl__5).getHashValue()["fun_name"].clone();
//line 120
___nl__10 = ((ImmHash)___nl__5).getHashValue()["args"].clone();
//line 120
___nl__7 = generator_js_NL.NL_print_call_priv(___nl__0,___nl__8,___nl__9,___nl__10).clone();

//line 120
___nl__10 = null;
//line 120
___nl__9 = null;
//line 120
___nl__8 = null;
//line 120
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 120
___nl__7 = null;
//line 120
___nl__2 = ___nl__6.clone();
//line 120
___nl__6 = null;
//line 120
___nl__5 = null;
//line 121
if (true) {goto label_1;}
//line 121
label_5:
//line 121
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("func")).clone();
//line 122
___nl__7 = ((ImmHash)___nl__5).getHashValue()["dest"].clone();
//line 122
___nl__6 = generator_js_NL.NL_print_register_to_assign_priv(___nl__7).clone();

//line 122
___nl__7 = null;
//line 122
___nl__9 = ((ImmHash)___nl__5).getHashValue()["module"].clone();
//line 122
___nl__10 = ((ImmHash)___nl__5).getHashValue()["name"].clone();
//line 122
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",___nl__9);
__function_map.Add("name",___nl__10);
___nl__8 = new ImmHash(__function_map).clone();
//line 122
___nl__9 = null;
//line 122
___nl__10 = null;
//line 122
___nl__7 = generator_js_NL.NL_print_const_hash_priv(___nl__8).clone();

//line 122
___nl__8 = null;
//line 122
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 122
___nl__7 = null;
//line 122
___nl__7 = new ImmString(";").clone();
//line 122
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 122
___nl__7 = null;
//line 122
___nl__2 = ___nl__6.clone();
//line 122
___nl__6 = null;
//line 122
___nl__5 = null;
//line 123
if (true) {goto label_1;}
//line 123
label_6:
//line 123
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("una_op")).clone();
//line 124
___nl__6 = generator_js_NL.NL_print_una_op_priv(___nl__5).clone();

//line 124
___nl__2 = ___nl__6.clone();
//line 124
___nl__6 = null;
//line 124
___nl__5 = null;
//line 125
if (true) {goto label_1;}
//line 125
label_7:
//line 125
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("bin_op")).clone();
//line 126
___nl__6 = generator_js_NL.NL_print_bin_op_priv(___nl__5).clone();

//line 126
___nl__2 = ___nl__6.clone();
//line 126
___nl__6 = null;
//line 126
___nl__5 = null;
//line 127
if (true) {goto label_1;}
//line 127
label_8:
//line 127
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("ov_is")).clone();
//line 128
___nl__7 = ((ImmHash)___nl__5).getHashValue()["dest"].clone();
//line 128
___nl__6 = generator_js_NL.NL_print_register_to_assign_priv(___nl__7).clone();

//line 128
___nl__7 = null;
//line 128
___nl__7 = new ImmString("c_rt_lib0ov_is(").clone();
//line 128
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 128
___nl__7 = null;
//line 128
___nl__8 = ((ImmHash)___nl__5).getHashValue()["src"].clone();
//line 128
___nl__7 = generator_js_NL.NL_print_register_priv(___nl__8).clone();

//line 128
___nl__8 = null;
//line 128
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 128
___nl__7 = null;
//line 128
___nl__7 = new ImmString(", new ImRef(\"").clone();
//line 128
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 128
___nl__7 = null;
//line 128
___nl__8 = ((ImmHash)___nl__5).getHashValue()["type"].clone();
//line 128
___nl__7 = generator_js_NL.NL_escape_string_priv(___nl__8).clone();

//line 128
___nl__8 = null;
//line 128
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 128
___nl__7 = null;
//line 128
___nl__7 = new ImmString("\"));").clone();
//line 128
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 128
___nl__7 = null;
//line 128
___nl__2 = ___nl__6.clone();
//line 128
___nl__6 = null;
//line 128
___nl__5 = null;
//line 129
if (true) {goto label_1;}
//line 129
label_9:
//line 129
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("ov_as")).clone();
//line 130
___nl__7 = ((ImmHash)___nl__5).getHashValue()["dest"].clone();
//line 130
___nl__6 = generator_js_NL.NL_print_register_to_assign_priv(___nl__7).clone();

//line 130
___nl__7 = null;
//line 130
___nl__7 = new ImmString("c_rt_lib0ov_as(").clone();
//line 130
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 130
___nl__7 = null;
//line 130
___nl__8 = ((ImmHash)___nl__5).getHashValue()["src"].clone();
//line 130
___nl__7 = generator_js_NL.NL_print_register_priv(___nl__8).clone();

//line 130
___nl__8 = null;
//line 130
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 130
___nl__7 = null;
//line 130
___nl__7 = new ImmString(", new ImRef(\"").clone();
//line 130
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 130
___nl__7 = null;
//line 130
___nl__8 = ((ImmHash)___nl__5).getHashValue()["type"].clone();
//line 130
___nl__7 = generator_js_NL.NL_escape_string_priv(___nl__8).clone();

//line 130
___nl__8 = null;
//line 130
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 130
___nl__7 = null;
//line 130
___nl__7 = new ImmString("\"));").clone();
//line 130
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 130
___nl__7 = null;
//line 130
___nl__2 = ___nl__6.clone();
//line 130
___nl__6 = null;
//line 130
___nl__5 = null;
//line 131
if (true) {goto label_1;}
//line 131
label_10:
//line 131
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("return")).clone();
//line 132
___nl__6 = generator_js_NL.NL_print_return_priv(___nl__5).clone();

//line 132
___nl__2 = ___nl__6.clone();
//line 132
___nl__6 = null;
//line 132
___nl__5 = null;
//line 133
if (true) {goto label_1;}
//line 133
label_11:
//line 133
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("die")).clone();
//line 134
___nl__6 = new ImmString("nl_die();").clone();
//line 134
___nl__2 = ___nl__6.clone();
//line 134
___nl__6 = null;
//line 134
___nl__5 = null;
//line 135
if (true) {goto label_1;}
//line 135
label_12:
//line 135
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("move")).clone();
//line 136
___nl__7 = ((ImmHash)___nl__5).getHashValue()["dest"].clone();
//line 136
___nl__6 = generator_js_NL.NL_print_register_to_assign_priv(___nl__7).clone();

//line 136
___nl__7 = null;
//line 136
___nl__8 = ((ImmHash)___nl__5).getHashValue()["src"].clone();
//line 136
___nl__7 = generator_js_NL.NL_print_register_value_priv(___nl__8).clone();

//line 136
___nl__8 = null;
//line 136
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 136
___nl__7 = null;
//line 136
___nl__7 = new ImmString(";").clone();
//line 136
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 136
___nl__7 = null;
//line 136
___nl__2 = ___nl__6.clone();
//line 136
___nl__6 = null;
//line 136
___nl__5 = null;
//line 137
if (true) {goto label_1;}
//line 137
label_13:
//line 137
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("load_const")).clone();
//line 138
___nl__7 = ((ImmHash)___nl__5).getHashValue()["dest"].clone();
//line 138
___nl__6 = generator_js_NL.NL_print_register_to_assign_priv(___nl__7).clone();

//line 138
___nl__7 = null;
//line 138
___nl__8 = ((ImmHash)___nl__5).getHashValue()["val"].clone();
//line 138
___nl__7 = generator_js_NL.NL_print_const_value_priv(___nl__8).clone();

//line 138
___nl__8 = null;
//line 138
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 138
___nl__7 = null;
//line 138
___nl__7 = new ImmString(";").clone();
//line 138
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 138
___nl__7 = null;
//line 138
___nl__2 = ___nl__6.clone();
//line 138
___nl__6 = null;
//line 138
___nl__5 = null;
//line 139
if (true) {goto label_1;}
//line 139
label_14:
//line 139
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("get_frm_idx")).clone();
//line 140
___nl__7 = ((ImmHash)___nl__5).getHashValue()["dest"].clone();
//line 140
___nl__6 = generator_js_NL.NL_print_register_to_assign_priv(___nl__7).clone();

//line 140
___nl__7 = null;
//line 140
___nl__8 = ((ImmHash)___nl__5).getHashValue()["src"].clone();
//line 140
___nl__7 = generator_js_NL.NL_print_register_value_priv(___nl__8).clone();

//line 140
___nl__8 = null;
//line 140
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 140
___nl__7 = null;
//line 140
___nl__7 = new ImmString("[Math.floor(").clone();
//line 140
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 140
___nl__7 = null;
//line 140
___nl__8 = ((ImmHash)___nl__5).getHashValue()["idx"].clone();
//line 140
___nl__7 = generator_js_NL.NL_print_register_value_priv(___nl__8).clone();

//line 140
___nl__8 = null;
//line 140
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 140
___nl__7 = null;
//line 140
___nl__7 = new ImmString(")];").clone();
//line 140
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 140
___nl__7 = null;
//line 140
___nl__2 = ___nl__6.clone();
//line 140
___nl__6 = null;
//line 140
___nl__5 = null;
//line 141
if (true) {goto label_1;}
//line 141
label_15:
//line 141
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("set_at_idx")).clone();
//line 142
___nl__7 = ((ImmHash)___nl__5).getHashValue()["src"].clone();
//line 142
___nl__6 = generator_js_NL.NL_print_register_to_assign_priv(___nl__7).clone();

//line 142
___nl__7 = null;
//line 142
___nl__8 = ((ImmHash)___nl__5).getHashValue()["src"].clone();
//line 142
___nl__7 = generator_js_NL.NL_print_register_value_priv(___nl__8).clone();

//line 142
___nl__8 = null;
//line 142
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 142
___nl__7 = null;
//line 142
___nl__7 = new ImmString(".slice();").clone();
//line 142
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 142
___nl__7 = null;
//line 142
___nl__2 = ___nl__6.clone();
//line 142
___nl__6 = null;
//line 143
___nl__7 = ((ImmHash)___nl__5).getHashValue()["src"].clone();
//line 143
___nl__6 = generator_js_NL.NL_print_register_value_priv(___nl__7).clone();

//line 143
___nl__7 = null;
//line 143
___nl__7 = new ImmString("[Math.floor(").clone();
//line 143
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 143
___nl__7 = null;
//line 143
___nl__8 = ((ImmHash)___nl__5).getHashValue()["idx"].clone();
//line 143
___nl__7 = generator_js_NL.NL_print_register_value_priv(___nl__8).clone();

//line 143
___nl__8 = null;
//line 143
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 143
___nl__7 = null;
//line 143
___nl__7 = new ImmString(")] = ").clone();
//line 143
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 143
___nl__7 = null;
//line 143
___nl__8 = ((ImmHash)___nl__5).getHashValue()["val"].clone();
//line 143
___nl__7 = generator_js_NL.NL_print_register_value_priv(___nl__8).clone();

//line 143
___nl__8 = null;
//line 143
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 143
___nl__7 = null;
//line 143
___nl__7 = new ImmString(";").clone();
//line 143
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 143
___nl__7 = null;
//line 143
___nl__2 = new ImmString(___nl__2.toString() + ___nl__6.toString()).clone();
//line 143
___nl__6 = null;
//line 143
___nl__5 = null;
//line 144
if (true) {goto label_1;}
//line 144
label_16:
//line 144
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("get_val")).clone();
//line 145
___nl__7 = ((ImmHash)___nl__5).getHashValue()["dest"].clone();
//line 145
___nl__6 = generator_js_NL.NL_print_register_to_assign_priv(___nl__7).clone();

//line 145
___nl__7 = null;
//line 145
___nl__8 = ((ImmHash)___nl__5).getHashValue()["src"].clone();
//line 145
___nl__7 = generator_js_NL.NL_print_register_value_priv(___nl__8).clone();

//line 145
___nl__8 = null;
//line 145
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 145
___nl__7 = null;
//line 145
___nl__7 = new ImmString("[\"").clone();
//line 145
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 145
___nl__7 = null;
//line 145
___nl__8 = ((ImmHash)___nl__5).getHashValue()["key"].clone();
//line 145
___nl__7 = generator_js_NL.NL_escape_string_priv(___nl__8).clone();

//line 145
___nl__8 = null;
//line 145
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 145
___nl__7 = null;
//line 145
___nl__7 = new ImmString("\"];").clone();
//line 145
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 145
___nl__7 = null;
//line 145
___nl__2 = ___nl__6.clone();
//line 145
___nl__6 = null;
//line 145
___nl__5 = null;
//line 146
if (true) {goto label_1;}
//line 146
label_17:
//line 146
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("set_val")).clone();
//line 147
___nl__7 = ((ImmHash)___nl__5).getHashValue()["src"].clone();
//line 147
___nl__6 = generator_js_NL.NL_print_register_to_assign_priv(___nl__7).clone();

//line 147
___nl__7 = null;
//line 147
___nl__7 = new ImmString("c_rt_lib0clone(").clone();
//line 147
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 147
___nl__7 = null;
//line 147
___nl__8 = ((ImmHash)___nl__5).getHashValue()["src"].clone();
//line 147
___nl__7 = generator_js_NL.NL_print_register_value_priv(___nl__8).clone();

//line 147
___nl__8 = null;
//line 147
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 147
___nl__7 = null;
//line 147
___nl__7 = new ImmString(");").clone();
//line 147
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 147
___nl__7 = null;
//line 147
___nl__2 = ___nl__6.clone();
//line 147
___nl__6 = null;
//line 148
___nl__7 = ((ImmHash)___nl__5).getHashValue()["src"].clone();
//line 148
___nl__6 = generator_js_NL.NL_print_register_value_priv(___nl__7).clone();

//line 148
___nl__7 = null;
//line 148
___nl__7 = new ImmString("[\"").clone();
//line 148
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 148
___nl__7 = null;
//line 148
___nl__8 = ((ImmHash)___nl__5).getHashValue()["key"].clone();
//line 148
___nl__7 = generator_js_NL.NL_escape_string_priv(___nl__8).clone();

//line 148
___nl__8 = null;
//line 148
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 148
___nl__7 = null;
//line 148
___nl__7 = new ImmString("\"] = ").clone();
//line 148
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 148
___nl__7 = null;
//line 148
___nl__8 = ((ImmHash)___nl__5).getHashValue()["val"].clone();
//line 148
___nl__7 = generator_js_NL.NL_print_register_value_priv(___nl__8).clone();

//line 148
___nl__8 = null;
//line 148
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 148
___nl__7 = null;
//line 148
___nl__7 = new ImmString(";").clone();
//line 148
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 148
___nl__7 = null;
//line 148
___nl__2 = new ImmString(___nl__2.toString() + ___nl__6.toString()).clone();
//line 148
___nl__6 = null;
//line 148
___nl__5 = null;
//line 149
if (true) {goto label_1;}
//line 149
label_18:
//line 149
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("ov_mk")).clone();
//line 150
___nl__6 = generator_js_NL.NL_print_ov_mk_priv(___nl__5).clone();

//line 150
___nl__2 = ___nl__6.clone();
//line 150
___nl__6 = null;
//line 150
___nl__5 = null;
//line 151
if (true) {goto label_1;}
//line 151
label_19:
//line 151
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("prt_lbl")).clone();
//line 152
___nl__6 = new ImmString("case \"").clone();
//line 152
___nl__6 = new ImmString(___nl__6.toString() + ___nl__5.toString()).clone();
//line 152
___nl__7 = new ImmString("\":").clone();
//line 152
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 152
___nl__7 = null;
//line 152
___nl__2 = ___nl__6.clone();
//line 152
___nl__6 = null;
//line 152
___nl__5 = null;
//line 153
if (true) {goto label_1;}
//line 153
label_20:
//line 153
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("if_goto")).clone();
//line 154
___nl__6 = new ImmString("if (c_rt_lib0check_true_native(").clone();
//line 154
___nl__8 = ((ImmHash)___nl__5).getHashValue()["src"].clone();
//line 154
___nl__7 = generator_js_NL.NL_print_register_priv(___nl__8).clone();

//line 154
___nl__8 = null;
//line 154
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 154
___nl__7 = null;
//line 154
___nl__7 = new ImmString(")) {").clone();
//line 154
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 154
___nl__7 = null;
//line 154
___nl__8 = ((ImmHash)___nl__5).getHashValue()["dest"].clone();
//line 154
___nl__7 = generator_js_NL.NL_print_goto_priv(___nl__8).clone();

//line 154
___nl__8 = null;
//line 154
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 154
___nl__7 = null;
//line 154
___nl__7 = new ImmString("}").clone();
//line 154
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 154
___nl__7 = null;
//line 154
___nl__2 = ___nl__6.clone();
//line 154
___nl__6 = null;
//line 154
___nl__5 = null;
//line 155
if (true) {goto label_1;}
//line 155
label_21:
//line 155
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("goto")).clone();
//line 156
___nl__6 = generator_js_NL.NL_print_goto_priv(___nl__5).clone();

//line 156
___nl__2 = ___nl__6.clone();
//line 156
___nl__6 = null;
//line 156
___nl__5 = null;
//line 157
if (true) {goto label_1;}
//line 157
label_22:
//line 157
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("clear")).clone();
//line 158
___nl__6 = generator_js_NL.NL_print_register_to_assign_priv(___nl__5).clone();

//line 158
___nl__7 = new ImmString("null").clone();
//line 158
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 158
___nl__7 = null;
//line 158
___nl__2 = ___nl__6.clone();
//line 158
___nl__6 = null;
//line 158
___nl__5 = null;
//line 159
if (true) {goto label_1;}
//line 159
label_1:
//line 159
___nl__3 = null;
//line 159
___nl__4 = null;
//line 160
___nl__3 = new ImmString("//line ").clone();
//line 160
___nl__4 = ((ImmHash)___nl__1).getHashValue()["debug"].clone();
//line 160
___nl__4 = ((ImmHash)___nl__4).getHashValue()["nast_debug"].clone();
//line 160
___nl__4 = ((ImmHash)___nl__4).getHashValue()["begin"].clone();
//line 160
___nl__4 = ((ImmHash)___nl__4).getHashValue()["line"].clone();
//line 160
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 160
___nl__4 = null;
//line 160
___nl__4 = string_NL.NL_lf().clone();

//line 160
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 160
___nl__4 = null;
//line 160
___nl__3 = new ImmString(___nl__3.toString() + ___nl__2.toString()).clone();
//line 160
___nl__4 = string_NL.NL_lf().clone();

//line 160
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 160
___nl__4 = null;
//line 160
___nl__0 = null;
//line 160
___nl__1 = null;
//line 160
___nl__2 = null;
//line 160
if(true) return ___nl__3;
//line 160
___nl__3 = null;
//line 160
___nl__2 = null;
//line 160
___nl__0 = null;
//line 160
___nl__1 = null;
//line 160
if(true) return null;
}

private static Imm NL_print_arr_priv(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
Dictionary<String, Imm> __function_map;
//line 164
___nl__1 = new ImmString("[").clone();
//line 165
___nl__3 = new ImmDouble(0).clone();
//line 165
___nl__4 = new ImmDouble(1).clone();
//line 165
___nl__5 = c_rt_lib_NL.NL_array_len(___nl__0).clone();

//line 165
label_3:
//line 165
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))>=(Double.Parse(___nl__5.getValue().ToString())) ).clone();
//line 165
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_1;}}
//line 165
___nl__2 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__3).getDoubleValue()].clone();
//line 165
___nl__7 = generator_js_NL.NL_print_register_value_priv(___nl__2).clone();

//line 165
___nl__8 = new ImmString(",").clone();
//line 165
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 165
___nl__8 = null;
//line 165
___nl__1 = new ImmString(___nl__1.toString() + ___nl__7.toString()).clone();
//line 165
___nl__7 = null;
//line 165
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString()))).clone();
//line 165
if (true) {goto label_3;}
//line 165
label_1:
//line 165
___nl__2 = null;
//line 165
___nl__3 = null;
//line 165
___nl__4 = null;
//line 165
___nl__5 = null;
//line 165
___nl__6 = null;
//line 166
___nl__2 = new ImmString("]").clone();
//line 166
___nl__2 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 166
___nl__0 = null;
//line 166
___nl__1 = null;
//line 166
if(true) return ___nl__2;
//line 166
___nl__2 = null;
//line 166
___nl__1 = null;
//line 166
___nl__0 = null;
//line 166
if(true) return null;
}

private static Imm NL_print_bin_op_priv(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Dictionary<String, Imm> __function_map;
//line 170
___nl__2 = ((ImmHash)___nl__0).getHashValue()["dest"].clone();
//line 170
___nl__1 = generator_js_NL.NL_print_register_to_assign_priv(___nl__2).clone();

//line 170
___nl__2 = null;
//line 171
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 171
___nl__3 = new ImmString(">=").clone();
//line 171
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 171
___nl__3 = null;
//line 171
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_7;}}
//line 171
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 171
___nl__3 = new ImmString("<=").clone();
//line 171
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 171
___nl__3 = null;
//line 171
label_7:
//line 171
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_6;}}
//line 171
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 171
___nl__3 = new ImmString("<").clone();
//line 171
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 171
___nl__3 = null;
//line 171
label_6:
//line 171
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_5;}}
//line 171
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 171
___nl__3 = new ImmString(">").clone();
//line 171
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 171
___nl__3 = null;
//line 171
label_5:
//line 171
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_4;}}
//line 171
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 171
___nl__3 = new ImmString("==").clone();
//line 171
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 171
___nl__3 = null;
//line 171
label_4:
//line 171
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_3;}}
//line 171
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 171
___nl__3 = new ImmString("!=").clone();
//line 171
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 171
___nl__3 = null;
//line 171
label_3:
//line 171
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 171
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 173
___nl__3 = new ImmString("c_rt_lib0native_to_nl(parseFloat(").clone();
//line 173
___nl__3 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 173
___nl__5 = ((ImmHash)___nl__0).getHashValue()["left"].clone();
//line 173
___nl__4 = generator_js_NL.NL_print_register_value_priv(___nl__5).clone();

//line 173
___nl__5 = null;
//line 173
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 173
___nl__4 = null;
//line 173
___nl__4 = new ImmString(") ").clone();
//line 173
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 173
___nl__4 = null;
//line 173
___nl__4 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 173
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 173
___nl__4 = null;
//line 173
___nl__4 = new ImmString(" parseFloat(").clone();
//line 173
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 173
___nl__4 = null;
//line 173
___nl__5 = ((ImmHash)___nl__0).getHashValue()["right"].clone();
//line 173
___nl__4 = generator_js_NL.NL_print_register_value_priv(___nl__5).clone();

//line 173
___nl__5 = null;
//line 173
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 173
___nl__4 = null;
//line 173
___nl__4 = new ImmString("));").clone();
//line 173
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 173
___nl__4 = null;
//line 173
___nl__0 = null;
//line 173
___nl__1 = null;
//line 173
___nl__2 = null;
//line 173
if(true) return ___nl__3;
//line 173
___nl__3 = null;
//line 174
if (true) {goto label_1;}
//line 174
label_2:
//line 174
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 174
___nl__3 = new ImmString("eq").clone();
//line 174
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 174
___nl__3 = null;
//line 174
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_9;}}
//line 174
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 174
___nl__3 = new ImmString("ne").clone();
//line 174
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 174
___nl__3 = null;
//line 174
label_9:
//line 174
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 174
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_8;}}
//line 175
___nl__3 = new ImmString("c_rt_lib0native_to_nl(").clone();
//line 175
___nl__5 = ((ImmHash)___nl__0).getHashValue()["left"].clone();
//line 175
___nl__4 = generator_js_NL.NL_print_register_value_priv(___nl__5).clone();

//line 175
___nl__5 = null;
//line 175
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 175
___nl__4 = null;
//line 175
___nl__4 = new ImmString(".toString()").clone();
//line 175
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 175
___nl__4 = null;
//line 175
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 175
___nl__3 = null;
//line 176
___nl__3 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 176
___nl__4 = new ImmString("eq").clone();
//line 176
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__4.toString())).clone();
//line 176
___nl__4 = null;
//line 176
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 176
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_11;}}
//line 177
___nl__4 = new ImmString(" == ").clone();
//line 177
___nl__1 = new ImmString(___nl__1.toString() + ___nl__4.toString()).clone();
//line 177
___nl__4 = null;
//line 178
if (true) {goto label_10;}
//line 178
label_11:
//line 179
___nl__4 = new ImmString(" != ").clone();
//line 179
___nl__1 = new ImmString(___nl__1.toString() + ___nl__4.toString()).clone();
//line 179
___nl__4 = null;
//line 180
if (true) {goto label_10;}
//line 180
label_10:
//line 180
___nl__3 = null;
//line 181
___nl__4 = ((ImmHash)___nl__0).getHashValue()["right"].clone();
//line 181
___nl__3 = generator_js_NL.NL_print_register_value_priv(___nl__4).clone();

//line 181
___nl__4 = null;
//line 181
___nl__3 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 181
___nl__4 = new ImmString(".toString());").clone();
//line 181
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 181
___nl__4 = null;
//line 181
___nl__0 = null;
//line 181
___nl__1 = null;
//line 181
___nl__2 = null;
//line 181
if(true) return ___nl__3;
//line 181
___nl__3 = null;
//line 182
if (true) {goto label_1;}
//line 182
label_8:
//line 182
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 182
___nl__3 = new ImmString(".").clone();
//line 182
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 182
___nl__3 = null;
//line 182
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 182
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_12;}}
//line 183
___nl__4 = ((ImmHash)___nl__0).getHashValue()["left"].clone();
//line 183
___nl__3 = generator_js_NL.NL_print_register_value_priv(___nl__4).clone();

//line 183
___nl__4 = null;
//line 183
___nl__3 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 183
___nl__4 = new ImmString(".toString() + ").clone();
//line 183
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 183
___nl__4 = null;
//line 183
___nl__5 = ((ImmHash)___nl__0).getHashValue()["right"].clone();
//line 183
___nl__4 = generator_js_NL.NL_print_register_value_priv(___nl__5).clone();

//line 183
___nl__5 = null;
//line 183
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 183
___nl__4 = null;
//line 183
___nl__4 = new ImmString(".toString();").clone();
//line 183
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 183
___nl__4 = null;
//line 183
___nl__0 = null;
//line 183
___nl__1 = null;
//line 183
___nl__2 = null;
//line 183
if(true) return ___nl__3;
//line 183
___nl__3 = null;
//line 184
if (true) {goto label_1;}
//line 184
label_12:
//line 185
___nl__3 = new ImmString("parseFloat(").clone();
//line 185
___nl__3 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 185
___nl__5 = ((ImmHash)___nl__0).getHashValue()["left"].clone();
//line 185
___nl__4 = generator_js_NL.NL_print_register_value_priv(___nl__5).clone();

//line 185
___nl__5 = null;
//line 185
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 185
___nl__4 = null;
//line 185
___nl__4 = new ImmString(") ").clone();
//line 185
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 185
___nl__4 = null;
//line 185
___nl__4 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 185
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 185
___nl__4 = null;
//line 185
___nl__4 = new ImmString(" parseFloat(").clone();
//line 185
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 185
___nl__4 = null;
//line 185
___nl__5 = ((ImmHash)___nl__0).getHashValue()["right"].clone();
//line 185
___nl__4 = generator_js_NL.NL_print_register_value_priv(___nl__5).clone();

//line 185
___nl__5 = null;
//line 185
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 185
___nl__4 = null;
//line 185
___nl__4 = new ImmString(");").clone();
//line 185
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 185
___nl__4 = null;
//line 185
___nl__0 = null;
//line 185
___nl__1 = null;
//line 185
___nl__2 = null;
//line 185
if(true) return ___nl__3;
//line 185
___nl__3 = null;
//line 186
if (true) {goto label_1;}
//line 186
label_1:
//line 186
___nl__2 = null;
//line 186
___nl__1 = null;
//line 186
___nl__0 = null;
//line 186
if(true) return null;
}

private static Imm NL_print_call_priv(Imm ___arg__0, Imm ___arg__1, Imm ___arg__2, Imm ___arg__3) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);Imm ___nl__2 = null;c_rt_lib_NL.NL_copy(ref ___nl__2, ___arg__2);Imm ___nl__3 = null;c_rt_lib_NL.NL_copy(ref ___nl__3, ___arg__3);
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
Imm ___nl__9 = null;
Imm ___nl__10 = null;
Imm ___nl__11 = null;
Imm ___nl__12 = null;
Imm ___nl__13 = null;
Dictionary<String, Imm> __function_map;
//line 190
___nl__4 = new ImmString("").clone();
//line 190
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__1.toString().Equals(___nl__4.toString())).clone();
//line 190
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 190
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 190
___nl__5 = new ImmString("_priv").clone();
//line 190
___nl__5 = new ImmString(___nl__0.toString() + ___nl__5.toString()).clone();
//line 190
___nl__1 = ___nl__5.clone();
//line 190
___nl__5 = null;
//line 190
if (true) {goto label_2;}
//line 190
label_2:
//line 190
___nl__4 = null;
//line 191
___nl__4 = generator_js_NL.NL_escape_mod_fun_name_priv(___nl__1).clone();

//line 191
___nl__5 = new ImmDouble(0).clone();
//line 191
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 191
___nl__5 = null;
//line 191
___nl__5 = generator_js_NL.NL_escape_mod_fun_name_priv(___nl__2).clone();

//line 191
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 191
___nl__5 = null;
//line 191
___nl__5 = new ImmString("(").clone();
//line 191
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 191
___nl__5 = null;
//line 192
___nl__5 = new ImmDouble(0).clone();
//line 193
___nl__7 = new ImmDouble(0).clone();
//line 193
___nl__8 = new ImmDouble(1).clone();
//line 193
___nl__9 = c_rt_lib_NL.NL_array_len(___nl__3).clone();

//line 193
label_5:
//line 193
___nl__10 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))>=(Double.Parse(___nl__9.getValue().ToString())) ).clone();
//line 193
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_3;}}
//line 193
___nl__6 = (___nl__3 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()].clone();
//line 194
___nl__11 = new ImmDouble(0).clone();
//line 194
___nl__11 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString())) ==((Double.Parse(___nl__11.getValue().ToString())))  ).clone();
//line 194
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 194
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 194
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_7;}}
//line 194
___nl__12 = new ImmString(",").clone();
//line 194
___nl__4 = new ImmString(___nl__4.toString() + ___nl__12.toString()).clone();
//line 194
___nl__12 = null;
//line 194
if (true) {goto label_7;}
//line 194
label_7:
//line 194
___nl__11 = null;
//line 195
___nl__11 = new ImmDouble(1).clone();
//line 195
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__11.getValue().ToString()))).clone();
//line 195
___nl__11 = null;
//line 196
___nl__11 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("ref")).clone();
//line 196
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_9;}}
//line 198
___nl__11 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("val")).clone();
//line 198
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_10;}}
//line 198
___nl__11 = new ImmString("NOMATCHALERT").clone();
//line 198
___nl__11 = new ImmArray(new Imm[] {___nl__11,___nl__6,}).clone();
//line 198
c_rt_lib_NL.NL_die();
//line 196
label_9:
//line 196
___nl__12 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("ref")).clone();
//line 197
___nl__13 = generator_js_NL.NL_print_register_priv(___nl__12).clone();

//line 197
___nl__4 = new ImmString(___nl__4.toString() + ___nl__13.toString()).clone();
//line 197
___nl__13 = null;
//line 197
___nl__12 = null;
//line 198
if (true) {goto label_8;}
//line 198
label_10:
//line 198
___nl__12 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("val")).clone();
//line 199
___nl__13 = generator_js_NL.NL_print_register_priv(___nl__12).clone();

//line 199
___nl__4 = new ImmString(___nl__4.toString() + ___nl__13.toString()).clone();
//line 199
___nl__13 = null;
//line 199
___nl__12 = null;
//line 200
if (true) {goto label_8;}
//line 200
label_8:
//line 200
___nl__11 = null;
//line 201
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString()))).clone();
//line 201
if (true) {goto label_5;}
//line 201
label_3:
//line 201
___nl__6 = null;
//line 201
___nl__7 = null;
//line 201
___nl__8 = null;
//line 201
___nl__9 = null;
//line 201
___nl__10 = null;
//line 202
___nl__6 = new ImmString(");").clone();
//line 202
___nl__6 = new ImmString(___nl__4.toString() + ___nl__6.toString()).clone();
//line 202
___nl__0 = null;
//line 202
___nl__1 = null;
//line 202
___nl__2 = null;
//line 202
___nl__3 = null;
//line 202
___nl__4 = null;
//line 202
___nl__5 = null;
//line 202
if(true) return ___nl__6;
//line 202
___nl__6 = null;
//line 202
___nl__4 = null;
//line 202
___nl__5 = null;
//line 202
___nl__0 = null;
//line 202
___nl__1 = null;
//line 202
___nl__2 = null;
//line 202
___nl__3 = null;
//line 202
if(true) return null;
}

private static Imm NL_print_const_arr_priv(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
Dictionary<String, Imm> __function_map;
//line 206
___nl__1 = new ImmString("[").clone();
//line 207
___nl__3 = new ImmDouble(0).clone();
//line 207
___nl__4 = new ImmDouble(1).clone();
//line 207
___nl__5 = c_rt_lib_NL.NL_array_len(___nl__0).clone();

//line 207
label_3:
//line 207
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))>=(Double.Parse(___nl__5.getValue().ToString())) ).clone();
//line 207
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_1;}}
//line 207
___nl__2 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__3).getDoubleValue()].clone();
//line 207
___nl__7 = generator_js_NL.NL_print_const_value_priv(___nl__2).clone();

//line 207
___nl__8 = new ImmString(",").clone();
//line 207
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 207
___nl__8 = null;
//line 207
___nl__1 = new ImmString(___nl__1.toString() + ___nl__7.toString()).clone();
//line 207
___nl__7 = null;
//line 207
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString()))).clone();
//line 207
if (true) {goto label_3;}
//line 207
label_1:
//line 207
___nl__2 = null;
//line 207
___nl__3 = null;
//line 207
___nl__4 = null;
//line 207
___nl__5 = null;
//line 207
___nl__6 = null;
//line 208
___nl__2 = new ImmString("]").clone();
//line 208
___nl__2 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 208
___nl__0 = null;
//line 208
___nl__1 = null;
//line 208
if(true) return ___nl__2;
//line 208
___nl__2 = null;
//line 208
___nl__1 = null;
//line 208
___nl__0 = null;
//line 208
if(true) return null;
}

private static Imm NL_print_const_hash_priv(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Dictionary<String, Imm> __function_map;
//line 212
___nl__1 = new ImmString("{").clone();
//line 213
___nl__4 = c_rt_lib_NL.NL_init_iter(___nl__0).clone();

//line 213
label_3:
//line 213
___nl__2 = c_rt_lib_NL.NL_is_end_hash(___nl__4).clone();

//line 213
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_1;}}
//line 213
___nl__2 = c_rt_lib_NL.NL_get_key_iter(___nl__4).clone();

//line 213
___nl__3 = c_rt_lib_NL.NL_hash_get_value(___nl__0,___nl__2).clone();

//line 213
___nl__5 = new ImmString("\"").clone();
//line 213
___nl__6 = generator_js_NL.NL_escape_string_priv(___nl__2).clone();

//line 213
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 213
___nl__6 = null;
//line 213
___nl__6 = new ImmString("\":").clone();
//line 213
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 213
___nl__6 = null;
//line 213
___nl__6 = generator_js_NL.NL_print_const_value_priv(___nl__3).clone();

//line 213
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 213
___nl__6 = null;
//line 213
___nl__6 = new ImmString(",").clone();
//line 213
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 213
___nl__6 = null;
//line 213
___nl__1 = new ImmString(___nl__1.toString() + ___nl__5.toString()).clone();
//line 213
___nl__5 = null;
//line 213
___nl__4 = c_rt_lib_NL.NL_next_iter(___nl__4).clone();

//line 213
if (true) {goto label_3;}
//line 213
label_1:
//line 213
___nl__2 = null;
//line 213
___nl__3 = null;
//line 213
___nl__4 = null;
//line 214
___nl__2 = new ImmString("}").clone();
//line 214
___nl__2 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 214
___nl__0 = null;
//line 214
___nl__1 = null;
//line 214
if(true) return ___nl__2;
//line 214
___nl__2 = null;
//line 214
___nl__1 = null;
//line 214
___nl__0 = null;
//line 214
if(true) return null;
}

private static Imm NL_print_const_ov_priv(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Dictionary<String, Imm> __function_map;
//line 218
___nl__1 = new ImmString("").clone();
//line 219
___nl__2 = ov_NL.NL_has_value(___nl__0).clone();

//line 219
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 219
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 220
___nl__3 = new ImmString("new OV(\"").clone();
//line 220
___nl__5 = ov_NL.NL_get_element(___nl__0).clone();

//line 220
___nl__4 = generator_js_NL.NL_escape_string_priv(___nl__5).clone();

//line 220
___nl__5 = null;
//line 220
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 220
___nl__4 = null;
//line 220
___nl__4 = new ImmString("\", ").clone();
//line 220
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 220
___nl__4 = null;
//line 220
___nl__5 = ov_NL.NL_get_value(___nl__0).clone();

//line 220
___nl__4 = generator_js_NL.NL_print_const_value_priv(___nl__5).clone();

//line 220
___nl__5 = null;
//line 220
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 220
___nl__4 = null;
//line 220
___nl__4 = new ImmString(")").clone();
//line 220
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 220
___nl__4 = null;
//line 220
___nl__1 = ___nl__3.clone();
//line 220
___nl__3 = null;
//line 221
if (true) {goto label_1;}
//line 221
label_2:
//line 222
___nl__3 = new ImmString("new OV(\"").clone();
//line 222
___nl__5 = ov_NL.NL_get_element(___nl__0).clone();

//line 222
___nl__4 = generator_js_NL.NL_escape_string_priv(___nl__5).clone();

//line 222
___nl__5 = null;
//line 222
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 222
___nl__4 = null;
//line 222
___nl__4 = new ImmString("\", null)").clone();
//line 222
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 222
___nl__4 = null;
//line 222
___nl__1 = ___nl__3.clone();
//line 222
___nl__3 = null;
//line 223
if (true) {goto label_1;}
//line 223
label_1:
//line 223
___nl__2 = null;
//line 224
___nl__0 = null;
//line 224
if(true) return ___nl__1;
//line 224
___nl__1 = null;
//line 224
___nl__0 = null;
//line 224
if(true) return null;
}

private static Imm NL_print_const_value_priv(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 228
___nl__1 = nl_NL.NL_is_sim(___nl__0).clone();

//line 228
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1)).clone();
//line 228
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_4;}}
//line 228
___nl__4 = new ImmString("").clone();
//line 228
___nl__4 = new ImmString(___nl__0.toString() + ___nl__4.toString()).clone();
//line 228
___nl__1 = string_utils_NL.NL_is_integer(___nl__4).clone();

//line 228
___nl__4 = null;
//line 228
label_4:
//line 228
___nl__3 = null;
//line 228
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1)).clone();
//line 228
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_3;}}
//line 228
___nl__1 = new ImmDouble(0).clone();
//line 228
___nl__1 = new ImmDouble((Double.Parse(___nl__1.getValue().ToString()))+(Double.Parse(___nl__0.getValue().ToString()))).clone();
//line 228
___nl__1 = c_rt_lib_NL.NL_native_to_nl(___nl__1.toString().Equals(___nl__0.toString())).clone();
//line 228
label_3:
//line 228
___nl__2 = null;
//line 228
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1)).clone();
//line 228
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_2;}}
//line 229
___nl__1 = null;
//line 229
if(true) return ___nl__0;
//line 230
if (true) {goto label_1;}
//line 230
label_2:
//line 230
___nl__1 = nl_NL.NL_is_sim(___nl__0).clone();

//line 230
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1)).clone();
//line 230
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_5;}}
//line 231
___nl__2 = new ImmString("\"").clone();
//line 231
___nl__3 = generator_js_NL.NL_escape_string_priv(___nl__0).clone();

//line 231
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 231
___nl__3 = null;
//line 231
___nl__3 = new ImmString("\"").clone();
//line 231
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 231
___nl__3 = null;
//line 231
___nl__0 = null;
//line 231
___nl__1 = null;
//line 231
if(true) return ___nl__2;
//line 231
___nl__2 = null;
//line 232
if (true) {goto label_1;}
//line 232
label_5:
//line 232
___nl__1 = nl_NL.NL_is_array(___nl__0).clone();

//line 232
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1)).clone();
//line 232
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_6;}}
//line 233
___nl__2 = generator_js_NL.NL_print_const_arr_priv(___nl__0).clone();

//line 233
___nl__0 = null;
//line 233
___nl__1 = null;
//line 233
if(true) return ___nl__2;
//line 233
___nl__2 = null;
//line 234
if (true) {goto label_1;}
//line 234
label_6:
//line 234
___nl__1 = nl_NL.NL_is_hash(___nl__0).clone();

//line 234
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1)).clone();
//line 234
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_7;}}
//line 235
___nl__2 = generator_js_NL.NL_print_const_hash_priv(___nl__0).clone();

//line 235
___nl__0 = null;
//line 235
___nl__1 = null;
//line 235
if(true) return ___nl__2;
//line 235
___nl__2 = null;
//line 236
if (true) {goto label_1;}
//line 236
label_7:
//line 236
___nl__1 = nl_NL.NL_is_variant(___nl__0).clone();

//line 236
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1)).clone();
//line 236
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_8;}}
//line 237
___nl__2 = generator_js_NL.NL_print_const_ov_priv(___nl__0).clone();

//line 237
___nl__0 = null;
//line 237
___nl__1 = null;
//line 237
if(true) return ___nl__2;
//line 237
___nl__2 = null;
//line 238
if (true) {goto label_1;}
//line 238
label_8:
//line 239
___nl__2 = new ImmArray(new Imm[0]).clone();
//line 239
c_rt_lib_NL.NL_die();
//line 239
___nl__2 = null;
//line 240
if (true) {goto label_1;}
//line 240
label_1:
//line 240
___nl__1 = null;
//line 240
___nl__0 = null;
//line 240
if(true) return null;
}

private static Imm NL_print_goto_priv(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 244
___nl__1 = new ImmString("label = \"").clone();
//line 244
___nl__1 = new ImmString(___nl__1.toString() + ___nl__0.toString()).clone();
//line 244
___nl__2 = new ImmString("\"; continue;").clone();
//line 244
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 244
___nl__2 = null;
//line 244
___nl__0 = null;
//line 244
if(true) return ___nl__1;
//line 244
___nl__1 = null;
//line 244
___nl__0 = null;
//line 244
if(true) return null;
}

private static Imm NL_print_hash_priv(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
Imm ___nl__9 = null;
Dictionary<String, Imm> __function_map;
//line 248
___nl__1 = new ImmString("{").clone();
//line 249
___nl__3 = new ImmDouble(0).clone();
//line 249
___nl__4 = new ImmDouble(1).clone();
//line 249
___nl__5 = c_rt_lib_NL.NL_array_len(___nl__0).clone();

//line 249
label_3:
//line 249
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))>=(Double.Parse(___nl__5.getValue().ToString())) ).clone();
//line 249
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_1;}}
//line 249
___nl__2 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__3).getDoubleValue()].clone();
//line 249
___nl__7 = new ImmString("\"").clone();
//line 249
___nl__9 = ((ImmHash)___nl__2).getHashValue()["key"].clone();
//line 249
___nl__8 = generator_js_NL.NL_escape_string_priv(___nl__9).clone();

//line 249
___nl__9 = null;
//line 249
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 249
___nl__8 = null;
//line 249
___nl__8 = new ImmString("\":").clone();
//line 249
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 249
___nl__8 = null;
//line 249
___nl__9 = ((ImmHash)___nl__2).getHashValue()["val"].clone();
//line 249
___nl__8 = generator_js_NL.NL_print_register_value_priv(___nl__9).clone();

//line 249
___nl__9 = null;
//line 249
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 249
___nl__8 = null;
//line 249
___nl__8 = new ImmString(",").clone();
//line 249
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 249
___nl__8 = null;
//line 249
___nl__1 = new ImmString(___nl__1.toString() + ___nl__7.toString()).clone();
//line 249
___nl__7 = null;
//line 249
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString()))).clone();
//line 249
if (true) {goto label_3;}
//line 249
label_1:
//line 249
___nl__2 = null;
//line 249
___nl__3 = null;
//line 249
___nl__4 = null;
//line 249
___nl__5 = null;
//line 249
___nl__6 = null;
//line 250
___nl__2 = new ImmString("}").clone();
//line 250
___nl__2 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 250
___nl__0 = null;
//line 250
___nl__1 = null;
//line 250
if(true) return ___nl__2;
//line 250
___nl__2 = null;
//line 250
___nl__1 = null;
//line 250
___nl__0 = null;
//line 250
if(true) return null;
}

private static Imm NL_print_ov_mk_priv(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Dictionary<String, Imm> __function_map;
//line 254
___nl__2 = ((ImmHash)___nl__0).getHashValue()["dest"].clone();
//line 254
___nl__1 = generator_js_NL.NL_print_register_to_assign_priv(___nl__2).clone();

//line 254
___nl__2 = null;
//line 255
___nl__2 = ((ImmHash)___nl__0).getHashValue()["src"].clone();
//line 255
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("arg")).clone();
//line 255
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 257
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("emp")).clone();
//line 257
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 257
___nl__3 = new ImmString("NOMATCHALERT").clone();
//line 257
___nl__3 = new ImmArray(new Imm[] {___nl__3,___nl__2,}).clone();
//line 257
c_rt_lib_NL.NL_die();
//line 255
label_2:
//line 255
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("arg")).clone();
//line 256
___nl__5 = new ImmString("c_rt_lib0ov_mk_arg(\"").clone();
//line 256
___nl__5 = new ImmString(___nl__1.toString() + ___nl__5.toString()).clone();
//line 256
___nl__7 = ((ImmHash)___nl__0).getHashValue()["name"].clone();
//line 256
___nl__6 = generator_js_NL.NL_escape_string_priv(___nl__7).clone();

//line 256
___nl__7 = null;
//line 256
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 256
___nl__6 = null;
//line 256
___nl__6 = new ImmString("\", ").clone();
//line 256
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 256
___nl__6 = null;
//line 256
___nl__6 = generator_js_NL.NL_print_register_priv(___nl__4).clone();

//line 256
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 256
___nl__6 = null;
//line 256
___nl__6 = new ImmString(");").clone();
//line 256
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 256
___nl__6 = null;
//line 256
___nl__0 = null;
//line 256
___nl__1 = null;
//line 256
___nl__2 = null;
//line 256
___nl__3 = null;
//line 256
___nl__4 = null;
//line 256
if(true) return ___nl__5;
//line 256
___nl__5 = null;
//line 256
___nl__4 = null;
//line 257
if (true) {goto label_1;}
//line 257
label_3:
//line 258
___nl__4 = new ImmString("c_rt_lib0ov_mk_none(\"").clone();
//line 258
___nl__4 = new ImmString(___nl__1.toString() + ___nl__4.toString()).clone();
//line 258
___nl__6 = ((ImmHash)___nl__0).getHashValue()["name"].clone();
//line 258
___nl__5 = generator_js_NL.NL_escape_string_priv(___nl__6).clone();

//line 258
___nl__6 = null;
//line 258
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 258
___nl__5 = null;
//line 258
___nl__5 = new ImmString("\");").clone();
//line 258
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 258
___nl__5 = null;
//line 258
___nl__0 = null;
//line 258
___nl__1 = null;
//line 258
___nl__2 = null;
//line 258
___nl__3 = null;
//line 258
if(true) return ___nl__4;
//line 258
___nl__4 = null;
//line 259
if (true) {goto label_1;}
//line 259
label_1:
//line 259
___nl__2 = null;
//line 259
___nl__3 = null;
//line 259
___nl__1 = null;
//line 259
___nl__0 = null;
//line 259
if(true) return null;
}

private static Imm NL_print_register_priv(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 263
___nl__1 = new ImmString("___nl__").clone();
//line 263
___nl__1 = new ImmString(___nl__1.toString() + ___nl__0.toString()).clone();
//line 263
___nl__0 = null;
//line 263
if(true) return ___nl__1;
//line 263
___nl__1 = null;
//line 263
___nl__0 = null;
//line 263
if(true) return null;
}

private static Imm NL_print_register_value_priv(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 267
___nl__1 = generator_js_NL.NL_print_register_priv(___nl__0).clone();

//line 267
___nl__2 = new ImmString(".value").clone();
//line 267
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 267
___nl__2 = null;
//line 267
___nl__0 = null;
//line 267
if(true) return ___nl__1;
//line 267
___nl__1 = null;
//line 267
___nl__0 = null;
//line 267
if(true) return null;
}

private static Imm NL_print_register_to_assign_priv(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 271
___nl__1 = new ImmString("").clone();
//line 271
___nl__1 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__1.toString())).clone();
//line 271
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1)).clone();
//line 271
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_2;}}
//line 271
___nl__2 = new ImmString("").clone();
//line 271
___nl__0 = null;
//line 271
___nl__1 = null;
//line 271
if(true) return ___nl__2;
//line 271
___nl__2 = null;
//line 271
if (true) {goto label_2;}
//line 271
label_2:
//line 271
___nl__1 = null;
//line 272
___nl__1 = generator_js_NL.NL_print_register_value_priv(___nl__0).clone();

//line 272
___nl__2 = new ImmString(" = ").clone();
//line 272
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 272
___nl__2 = null;
//line 272
___nl__0 = null;
//line 272
if(true) return ___nl__1;
//line 272
___nl__1 = null;
//line 272
___nl__0 = null;
//line 272
if(true) return null;
}

private static Imm NL_print_return_priv(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 276
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("val")).clone();
//line 276
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_2;}}
//line 278
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("emp")).clone();
//line 278
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_3;}}
//line 278
___nl__1 = new ImmString("NOMATCHALERT").clone();
//line 278
___nl__1 = new ImmArray(new Imm[] {___nl__1,___nl__0,}).clone();
//line 278
c_rt_lib_NL.NL_die();
//line 276
label_2:
//line 276
___nl__2 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("val")).clone();
//line 277
___nl__3 = new ImmString("return ").clone();
//line 277
___nl__4 = generator_js_NL.NL_print_register_value_priv(___nl__2).clone();

//line 277
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 277
___nl__4 = null;
//line 277
___nl__4 = new ImmString(";").clone();
//line 277
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 277
___nl__4 = null;
//line 277
___nl__0 = null;
//line 277
___nl__1 = null;
//line 277
___nl__2 = null;
//line 277
if(true) return ___nl__3;
//line 277
___nl__3 = null;
//line 277
___nl__2 = null;
//line 278
if (true) {goto label_1;}
//line 278
label_3:
//line 279
___nl__2 = new ImmString("return null;").clone();
//line 279
___nl__0 = null;
//line 279
___nl__1 = null;
//line 279
if(true) return ___nl__2;
//line 279
___nl__2 = null;
//line 280
if (true) {goto label_1;}
//line 280
label_1:
//line 280
___nl__1 = null;
//line 280
___nl__0 = null;
//line 280
if(true) return null;
}

private static Imm NL_print_una_op_priv(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Dictionary<String, Imm> __function_map;
//line 284
___nl__2 = ((ImmHash)___nl__0).getHashValue()["dest"].clone();
//line 284
___nl__1 = generator_js_NL.NL_print_register_to_assign_priv(___nl__2).clone();

//line 284
___nl__2 = null;
//line 285
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 285
___nl__3 = new ImmString("!").clone();
//line 285
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 285
___nl__3 = null;
//line 285
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 285
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 286
___nl__3 = new ImmString("c_rt_lib0native_to_nl(!c_rt_lib0check_true_native(").clone();
//line 286
___nl__3 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 286
___nl__5 = ((ImmHash)___nl__0).getHashValue()["src"].clone();
//line 286
___nl__4 = generator_js_NL.NL_print_register_priv(___nl__5).clone();

//line 286
___nl__5 = null;
//line 286
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 286
___nl__4 = null;
//line 286
___nl__4 = new ImmString("));").clone();
//line 286
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 286
___nl__4 = null;
//line 286
___nl__0 = null;
//line 286
___nl__1 = null;
//line 286
___nl__2 = null;
//line 286
if(true) return ___nl__3;
//line 286
___nl__3 = null;
//line 287
if (true) {goto label_1;}
//line 287
label_2:
//line 288
___nl__3 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 288
___nl__3 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 288
___nl__5 = ((ImmHash)___nl__0).getHashValue()["src"].clone();
//line 288
___nl__4 = generator_js_NL.NL_print_register_value_priv(___nl__5).clone();

//line 288
___nl__5 = null;
//line 288
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 288
___nl__4 = null;
//line 288
___nl__4 = new ImmString(";").clone();
//line 288
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 288
___nl__4 = null;
//line 288
___nl__0 = null;
//line 288
___nl__1 = null;
//line 288
___nl__2 = null;
//line 288
if(true) return ___nl__3;
//line 288
___nl__3 = null;
//line 289
if (true) {goto label_1;}
//line 289
label_1:
//line 289
___nl__2 = null;
//line 289
___nl__1 = null;
//line 289
___nl__0 = null;
//line 289
if(true) return null;
}

}
}