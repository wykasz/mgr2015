using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class type_checker_NL {

private static Imm NL_type_to_ptd_priv(Imm ___arg__0, ImmRef ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
ImmRef ___ref______nl__6 = null;
ImmRef ___ref______nl__7 = null;
Dictionary<String, Imm> __function_map;
//line 21
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("type")).clone();
//line 21
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 28
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("none")).clone();
//line 28
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_3;}}
//line 28
___nl__2 = new ImmString("NOMATCHALERT").clone();
//line 28
___nl__2 = new ImmArray(new Imm[] {___nl__2,___nl__0,}).clone();
//line 28
c_rt_lib_NL.NL_die();
//line 21
label_2:
//line 21
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("type")).clone();
//line 22
___nl__4 = ptd_parser_NL.NL_try_value_to_ptd(___nl__3).clone();

//line 22
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("err")).clone();
//line 22
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_5;}}
//line 25
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("ok")).clone();
//line 25
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_6;}}
//line 25
___nl__5 = new ImmString("NOMATCHALERT").clone();
//line 25
___nl__5 = new ImmArray(new Imm[] {___nl__5,___nl__4,}).clone();
//line 25
c_rt_lib_NL.NL_die();
//line 22
label_5:
//line 22
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("err")).clone();
//line 23
___ref______nl__1 = new ImmRef(___nl__1);
type_checker_NL.NL_add_error_priv(___ref______nl__1,___nl__6);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 24
___nl__7 = tct_NL.NL_tct_im().clone();

//line 24
___nl__0 = null;
//line 24
___nl__2 = null;
//line 24
___nl__3 = null;
//line 24
___nl__4 = null;
//line 24
___nl__5 = null;
//line 24
___nl__6 = null;
//line 24
___arg__1.setValue(___nl__1);if(true) return ___nl__7;
//line 24
___nl__7 = null;
//line 24
___nl__6 = null;
//line 25
if (true) {goto label_4;}
//line 25
label_6:
//line 25
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("ok")).clone();
//line 26
___nl__0 = null;
//line 26
___nl__2 = null;
//line 26
___nl__3 = null;
//line 26
___nl__4 = null;
//line 26
___nl__5 = null;
//line 26
___arg__1.setValue(___nl__1);if(true) return ___nl__6;
//line 26
___nl__6 = null;
//line 27
if (true) {goto label_4;}
//line 27
label_4:
//line 27
___nl__4 = null;
//line 27
___nl__5 = null;
//line 27
___nl__3 = null;
//line 28
if (true) {goto label_1;}
//line 28
label_3:
//line 29
___nl__3 = tct_NL.NL_tct_im().clone();

//line 29
___nl__0 = null;
//line 29
___nl__2 = null;
//line 29
___arg__1.setValue(___nl__1);if(true) return ___nl__3;
//line 29
___nl__3 = null;
//line 30
if (true) {goto label_1;}
//line 30
label_1:
//line 30
___nl__2 = null;
//line 30
___nl__0 = null;
//line 30
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_get_fun_def_key_priv(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 34
___nl__1 = ((ImmHash)___nl__0).getHashValue()["access"].clone();
//line 34
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("pub")).clone();
//line 34
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 36
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("priv")).clone();
//line 36
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_3;}}
//line 36
___nl__2 = new ImmString("NOMATCHALERT").clone();
//line 36
___nl__2 = new ImmArray(new Imm[] {___nl__2,___nl__1,}).clone();
//line 36
c_rt_lib_NL.NL_die();
//line 34
label_2:
//line 35
___nl__3 = ((ImmHash)___nl__0).getHashValue()["name"].clone();
//line 35
___nl__0 = null;
//line 35
___nl__1 = null;
//line 35
___nl__2 = null;
//line 35
if(true) return ___nl__3;
//line 35
___nl__3 = null;
//line 36
if (true) {goto label_1;}
//line 36
label_3:
//line 37
___nl__3 = new ImmString("priv::").clone();
//line 37
___nl__4 = ((ImmHash)___nl__0).getHashValue()["name"].clone();
//line 37
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 37
___nl__4 = null;
//line 37
___nl__0 = null;
//line 37
___nl__1 = null;
//line 37
___nl__2 = null;
//line 37
if(true) return ___nl__3;
//line 37
___nl__3 = null;
//line 38
if (true) {goto label_1;}
//line 38
label_1:
//line 38
___nl__1 = null;
//line 38
___nl__2 = null;
//line 38
___nl__0 = null;
//line 38
if(true) return null;
}

private static Imm NL_get_fun_key_priv(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 42
___nl__2 = new ImmString("").clone();
//line 43
___nl__3 = new ImmString("").clone();
//line 43
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__1.toString().Equals(___nl__3.toString())).clone();
//line 43
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 43
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 43
___nl__4 = new ImmString("priv::").clone();
//line 43
___nl__2 = new ImmString(___nl__2.toString() + ___nl__4.toString()).clone();
//line 43
___nl__4 = null;
//line 43
if (true) {goto label_2;}
//line 43
label_2:
//line 43
___nl__3 = null;
//line 44
___nl__3 = new ImmString(___nl__2.toString() + ___nl__0.toString()).clone();
//line 44
___nl__0 = null;
//line 44
___nl__1 = null;
//line 44
___nl__2 = null;
//line 44
if(true) return ___nl__3;
//line 44
___nl__3 = null;
//line 44
___nl__2 = null;
//line 44
___nl__0 = null;
//line 44
___nl__1 = null;
//line 44
if(true) return null;
}

private static Imm NL_return_type_to_tct_priv(Imm ___arg__0, ImmRef ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
ImmRef ___ref______nl__6 = null;
ImmRef ___ref______nl__7 = null;
ImmRef ___ref______nl__8 = null;
Dictionary<String, Imm> __function_map;
//line 47
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("type")).clone();
//line 47
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 55
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("none")).clone();
//line 55
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_3;}}
//line 55
___nl__2 = new ImmString("NOMATCHALERT").clone();
//line 55
___nl__2 = new ImmArray(new Imm[] {___nl__2,___nl__0,}).clone();
//line 55
c_rt_lib_NL.NL_die();
//line 47
label_2:
//line 47
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("type")).clone();
//line 48
___nl__5 = new ImmString("fun_val").clone();
//line 48
___nl__4 = ov_NL.NL_is(___nl__3,___nl__5).clone();

//line 48
___nl__5 = null;
//line 48
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 48
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_5;}}
//line 49
___nl__5 = ___nl__3.clone();
//line 49
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("fun_val")).clone();
//line 50
___nl__6 = ((ImmHash)___nl__5).getHashValue()["module"].clone();
//line 50
___nl__8 = new ImmString("ptd").clone();
//line 50
___nl__6 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__8.toString())).clone();
//line 50
___nl__8 = null;
//line 50
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 50
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_8;}}
//line 50
___nl__6 = ((ImmHash)___nl__5).getHashValue()["name"].clone();
//line 50
___nl__8 = new ImmString("void").clone();
//line 50
___nl__6 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__8.toString())).clone();
//line 50
___nl__8 = null;
//line 50
label_8:
//line 50
___nl__7 = null;
//line 50
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 50
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_7;}}
//line 51
___nl__7 = tct_NL.NL_tct_void().clone();

//line 51
___nl__0 = null;
//line 51
___nl__2 = null;
//line 51
___nl__3 = null;
//line 51
___nl__4 = null;
//line 51
___nl__5 = null;
//line 51
___nl__6 = null;
//line 51
___arg__1.setValue(___nl__1);if(true) return ___nl__7;
//line 51
___nl__7 = null;
//line 52
if (true) {goto label_7;}
//line 52
label_7:
//line 52
___nl__6 = null;
//line 52
___nl__5 = null;
//line 53
if (true) {goto label_5;}
//line 53
label_5:
//line 53
___nl__4 = null;
//line 54
___ref______nl__1 = new ImmRef(___nl__1);
___nl__4 = type_checker_NL.NL_type_to_ptd_priv(___nl__0,___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 54
___nl__0 = null;
//line 54
___nl__2 = null;
//line 54
___nl__3 = null;
//line 54
___arg__1.setValue(___nl__1);if(true) return ___nl__4;
//line 54
___nl__4 = null;
//line 54
___nl__3 = null;
//line 55
if (true) {goto label_1;}
//line 55
label_3:
//line 56
___nl__3 = tct_NL.NL_tct_im().clone();

//line 56
___nl__0 = null;
//line 56
___nl__2 = null;
//line 56
___arg__1.setValue(___nl__1);if(true) return ___nl__3;
//line 56
___nl__3 = null;
//line 57
if (true) {goto label_1;}
//line 57
label_1:
//line 57
___nl__2 = null;
//line 57
___nl__0 = null;
//line 57
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_check_types_imported_priv(Imm ___arg__0, ImmRef ___arg__1, ImmRef ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();Imm ___nl__2 = ___arg__2.getValue().clone();
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
Imm ___nl__9 = null;
Imm ___nl__10 = null;
Imm ___nl__11 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
ImmRef ___ref______nl__6 = null;
ImmRef ___ref______nl__7 = null;
ImmRef ___ref______nl__8 = null;
ImmRef ___ref______nl__9 = null;
ImmRef ___ref______nl__10 = null;
ImmRef ___ref______nl__11 = null;
Dictionary<String, Imm> __function_map;
//line 61
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_im")).clone();
//line 61
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 62
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_arr")).clone();
//line 62
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 64
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_hash")).clone();
//line 64
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_4;}}
//line 66
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_rec")).clone();
//line 66
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_5;}}
//line 70
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_ref")).clone();
//line 70
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_6;}}
//line 79
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_void")).clone();
//line 79
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_7;}}
//line 80
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_sim")).clone();
//line 80
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_8;}}
//line 81
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_var")).clone();
//line 81
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_9;}}
//line 88
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_empty")).clone();
//line 88
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_10;}}
//line 88
___nl__3 = new ImmString("NOMATCHALERT").clone();
//line 88
___nl__3 = new ImmArray(new Imm[] {___nl__3,___nl__0,}).clone();
//line 88
c_rt_lib_NL.NL_die();
//line 61
label_2:
//line 62
if (true) {goto label_1;}
//line 62
label_3:
//line 62
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("tct_arr")).clone();
//line 63
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
type_checker_NL.NL_check_types_imported_priv(___nl__4,___ref______nl__1,___ref______nl__2);
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 63
___nl__4 = null;
//line 64
if (true) {goto label_1;}
//line 64
label_4:
//line 64
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("tct_hash")).clone();
//line 65
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
type_checker_NL.NL_check_types_imported_priv(___nl__4,___ref______nl__1,___ref______nl__2);
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 65
___nl__4 = null;
//line 66
if (true) {goto label_1;}
//line 66
label_5:
//line 66
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("tct_rec")).clone();
//line 67
___nl__7 = c_rt_lib_NL.NL_init_iter(___nl__4).clone();

//line 67
label_13:
//line 67
___nl__5 = c_rt_lib_NL.NL_is_end_hash(___nl__7).clone();

//line 67
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_11;}}
//line 67
___nl__5 = c_rt_lib_NL.NL_get_key_iter(___nl__7).clone();

//line 67
___nl__6 = c_rt_lib_NL.NL_hash_get_value(___nl__4,___nl__5).clone();

//line 68
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
type_checker_NL.NL_check_types_imported_priv(___nl__6,___ref______nl__1,___ref______nl__2);
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 69
___nl__7 = c_rt_lib_NL.NL_next_iter(___nl__7).clone();

//line 69
if (true) {goto label_13;}
//line 69
label_11:
//line 69
___nl__5 = null;
//line 69
___nl__6 = null;
//line 69
___nl__7 = null;
//line 69
___nl__4 = null;
//line 70
if (true) {goto label_1;}
//line 70
label_6:
//line 70
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("tct_ref")).clone();
//line 71
___nl__6 = new ImmString("::").clone();
//line 71
___nl__5 = string_NL.NL_index2(___nl__4,___nl__6).clone();

//line 71
___nl__6 = null;
//line 72
___nl__6 = new ImmDouble(0).clone();
//line 72
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) ).clone();
//line 72
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 72
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_15;}}
//line 73
___nl__8 = new ImmDouble(0).clone();
//line 73
___nl__7 = string_NL.NL_substr(___nl__4,___nl__8,___nl__5).clone();

//line 73
___nl__8 = null;
//line 74
___nl__9 = new ImmDouble(2).clone();
//line 74
___nl__9 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__9.getValue().ToString()))).clone();
//line 74
___nl__10 = string_NL.NL_length(___nl__4).clone();

//line 74
___nl__10 = new ImmDouble((Double.Parse(___nl__10.getValue().ToString()))-(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 74
___nl__11 = new ImmDouble(2).clone();
//line 74
___nl__10 = new ImmDouble((Double.Parse(___nl__10.getValue().ToString()))-(Double.Parse(___nl__11.getValue().ToString()))).clone();
//line 74
___nl__11 = null;
//line 74
___nl__8 = string_NL.NL_substr(___nl__4,___nl__9,___nl__10).clone();

//line 74
___nl__10 = null;
//line 74
___nl__9 = null;
//line 75
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
type_checker_NL.NL_check_function_exists_priv(___nl__7,___nl__8,___ref______nl__1,___ref______nl__2);
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 75
___nl__7 = null;
//line 75
___nl__8 = null;
//line 76
if (true) {goto label_14;}
//line 76
label_15:
//line 77
___nl__7 = new ImmString("wrong type name '").clone();
//line 77
___nl__7 = new ImmString(___nl__7.toString() + ___nl__4.toString()).clone();
//line 77
___nl__8 = new ImmString("' ").clone();
//line 77
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 77
___nl__8 = null;
//line 77
___ref______nl__2 = new ImmRef(___nl__2);
type_checker_NL.NL_add_error_priv(___ref______nl__2,___nl__7);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 77
___nl__7 = null;
//line 78
if (true) {goto label_14;}
//line 78
label_14:
//line 78
___nl__6 = null;
//line 78
___nl__5 = null;
//line 78
___nl__4 = null;
//line 79
if (true) {goto label_1;}
//line 79
label_7:
//line 80
if (true) {goto label_1;}
//line 80
label_8:
//line 81
if (true) {goto label_1;}
//line 81
label_9:
//line 81
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("tct_var")).clone();
//line 82
___nl__7 = c_rt_lib_NL.NL_init_iter(___nl__4).clone();

//line 82
label_18:
//line 82
___nl__5 = c_rt_lib_NL.NL_is_end_hash(___nl__7).clone();

//line 82
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_16;}}
//line 82
___nl__5 = c_rt_lib_NL.NL_get_key_iter(___nl__7).clone();

//line 82
___nl__6 = c_rt_lib_NL.NL_hash_get_value(___nl__4,___nl__5).clone();

//line 83
___nl__8 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("no_param")).clone();
//line 83
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_20;}}
//line 84
___nl__8 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("with_param")).clone();
//line 84
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_21;}}
//line 84
___nl__8 = new ImmString("NOMATCHALERT").clone();
//line 84
___nl__8 = new ImmArray(new Imm[] {___nl__8,___nl__6,}).clone();
//line 84
c_rt_lib_NL.NL_die();
//line 83
label_20:
//line 84
if (true) {goto label_19;}
//line 84
label_21:
//line 84
___nl__9 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("with_param")).clone();
//line 85
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
type_checker_NL.NL_check_types_imported_priv(___nl__9,___ref______nl__1,___ref______nl__2);
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 85
___nl__9 = null;
//line 86
if (true) {goto label_19;}
//line 86
label_19:
//line 86
___nl__8 = null;
//line 87
___nl__7 = c_rt_lib_NL.NL_next_iter(___nl__7).clone();

//line 87
if (true) {goto label_18;}
//line 87
label_16:
//line 87
___nl__5 = null;
//line 87
___nl__6 = null;
//line 87
___nl__7 = null;
//line 87
___nl__4 = null;
//line 88
if (true) {goto label_1;}
//line 88
label_10:
//line 89
if (true) {goto label_1;}
//line 89
label_1:
//line 89
___nl__3 = null;
//line 89
___nl__0 = null;
//line 89
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return null;
}

private static Imm NL_prepare_def_fun_priv(Imm ___arg__0, ImmRef ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();
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
Imm ___nl__14 = null;
Imm ___nl__15 = null;
Imm ___nl__16 = null;
Imm ___nl__17 = null;
Imm ___nl__18 = null;
Imm ___nl__19 = null;
Imm ___nl__20 = null;
Imm ___nl__21 = null;
Imm ___nl__22 = null;
Imm ___nl__23 = null;
Imm ___nl__24 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
ImmRef ___ref______nl__6 = null;
ImmRef ___ref______nl__7 = null;
ImmRef ___ref______nl__8 = null;
ImmRef ___ref______nl__9 = null;
ImmRef ___ref______nl__10 = null;
ImmRef ___ref______nl__11 = null;
ImmRef ___ref______nl__12 = null;
ImmRef ___ref______nl__13 = null;
ImmRef ___ref______nl__14 = null;
ImmRef ___ref______nl__15 = null;
ImmRef ___ref______nl__16 = null;
ImmRef ___ref______nl__17 = null;
ImmRef ___ref______nl__18 = null;
ImmRef ___ref______nl__19 = null;
ImmRef ___ref______nl__20 = null;
ImmRef ___ref______nl__21 = null;
ImmRef ___ref______nl__22 = null;
ImmRef ___ref______nl__23 = null;
ImmRef ___ref______nl__24 = null;
Dictionary<String, Imm> __function_map;
//line 92
__function_map = new Dictionary<String, Imm>();
___nl__2 = new ImmHash(__function_map).clone();
//line 93
___nl__5 = c_rt_lib_NL.NL_init_iter(___nl__0).clone();

//line 93
label_3:
//line 93
___nl__3 = c_rt_lib_NL.NL_is_end_hash(___nl__5).clone();

//line 93
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_1;}}
//line 93
___nl__3 = c_rt_lib_NL.NL_get_key_iter(___nl__5).clone();

//line 93
___nl__4 = c_rt_lib_NL.NL_hash_get_value(___nl__0,___nl__3).clone();

//line 94
___nl__6 = new ImmDouble(1).clone();
//line 94
___nl__6 = new ImmDouble(-((ImmDouble)___nl__6).getDoubleValue()).clone();
//line 94
___nl__7 = ___nl__6.clone();
//line 94
((ImmHash)___nl__1).set("current_line", ___nl__7);
//line 94
___nl__6 = null;
//line 94
___nl__7 = null;
//line 95
___nl__6 = ___nl__3.clone();
//line 95
((ImmHash)___nl__1).set("module", ___nl__6);
//line 95
___nl__6 = null;
//line 96
__function_map = new Dictionary<String, Imm>();
___nl__6 = new ImmHash(__function_map).clone();
//line 97
___nl__7 = ((ImmHash)___nl__4).getHashValue()["fun_def"].clone();
//line 97
___nl__9 = new ImmDouble(0).clone();
//line 97
___nl__10 = new ImmDouble(1).clone();
//line 97
___nl__11 = c_rt_lib_NL.NL_array_len(___nl__7).clone();

//line 97
label_6:
//line 97
___nl__12 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__9.getValue().ToString()))>=(Double.Parse(___nl__11.getValue().ToString())) ).clone();
//line 97
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_4;}}
//line 97
___nl__8 = (___nl__7 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()].clone();
//line 98
___nl__13 = new ImmArray(new Imm[0]).clone();
//line 99
___nl__14 = ((ImmHash)___nl__8).getHashValue()["args"].clone();
//line 99
___nl__16 = new ImmDouble(0).clone();
//line 99
___nl__17 = new ImmDouble(1).clone();
//line 99
___nl__18 = c_rt_lib_NL.NL_array_len(___nl__14).clone();

//line 99
label_9:
//line 99
___nl__19 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__16.getValue().ToString()))>=(Double.Parse(___nl__18.getValue().ToString())) ).clone();
//line 99
if (c_rt_lib_NL.NL_check_true_native(___nl__19)) {if (true) {goto label_7;}}
//line 99
___nl__15 = (___nl__14 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__16).getDoubleValue()].clone();
//line 100
___nl__21 = ((ImmHash)___nl__15).getHashValue()["name"].clone();
//line 100
___nl__22 = ((ImmHash)___nl__15).getHashValue()["mod"].clone();
//line 100
___nl__24 = ((ImmHash)___nl__15).getHashValue()["type"].clone();
//line 100
___ref______nl__1 = new ImmRef(___nl__1);
___nl__23 = type_checker_NL.NL_type_to_ptd_priv(___nl__24,___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 100
___nl__24 = null;
//line 100
__function_map = new Dictionary<String, Imm>();
__function_map.Add("name",___nl__21);
__function_map.Add("mod",___nl__22);
__function_map.Add("type",___nl__23);
___nl__20 = new ImmHash(__function_map).clone();
//line 100
___nl__21 = null;
//line 100
___nl__22 = null;
//line 100
___nl__23 = null;
//line 100
___ref______nl__13 = new ImmRef(___nl__13);
array_NL.NL_push(___ref______nl__13,___nl__20);
___nl__13 = ___ref______nl__13.getValue().clone();

//line 100
___nl__20 = null;
//line 105
___nl__16 = new ImmDouble((Double.Parse(___nl__16.getValue().ToString()))+(Double.Parse(___nl__17.getValue().ToString()))).clone();
//line 105
if (true) {goto label_9;}
//line 105
label_7:
//line 105
___nl__14 = null;
//line 105
___nl__15 = null;
//line 105
___nl__16 = null;
//line 105
___nl__17 = null;
//line 105
___nl__18 = null;
//line 105
___nl__19 = null;
//line 106
___nl__15 = ((ImmHash)___nl__8).getHashValue()["cmd"].clone();
//line 106
___nl__16 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("no")).clone();
//line 106
___nl__17 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("no")).clone();
//line 106
___nl__18 = ((ImmHash)___nl__8).getHashValue()["name"].clone();
//line 106
___nl__19 = ((ImmHash)___nl__8).getHashValue()["access"].clone();
//line 106
___nl__21 = ((ImmHash)___nl__8).getHashValue()["ret_type"].clone();
//line 106
___ref______nl__1 = new ImmRef(___nl__1);
___nl__20 = type_checker_NL.NL_return_type_to_tct_priv(___nl__21,___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 106
___nl__21 = null;
//line 106
__function_map = new Dictionary<String, Imm>();
__function_map.Add("cmd",___nl__15);
__function_map.Add("is_type",___nl__16);
__function_map.Add("ref_types",___nl__17);
__function_map.Add("name",___nl__18);
__function_map.Add("module",___nl__3);
__function_map.Add("access",___nl__19);
__function_map.Add("args",___nl__13);
__function_map.Add("ret_type",___nl__20);
___nl__14 = new ImmHash(__function_map).clone();
//line 106
___nl__15 = null;
//line 106
___nl__16 = null;
//line 106
___nl__17 = null;
//line 106
___nl__18 = null;
//line 106
___nl__19 = null;
//line 106
___nl__20 = null;
//line 116
___nl__15 = type_checker_NL.NL_get_fun_def_key_priv(___nl__14).clone();

//line 117
___nl__16 = hash_NL.NL_has_key(___nl__6,___nl__15).clone();

//line 117
___nl__16 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__16)).clone();
//line 117
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_11;}}
//line 117
___nl__17 = new ImmString("redefine function: ").clone();
//line 117
___nl__17 = new ImmString(___nl__17.toString() + ___nl__15.toString()).clone();
//line 117
___ref______nl__1 = new ImmRef(___nl__1);
type_checker_NL.NL_add_error_priv(___ref______nl__1,___nl__17);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 117
___nl__17 = null;
//line 117
if (true) {goto label_11;}
//line 117
label_11:
//line 117
___nl__16 = null;
//line 118
___ref______nl__6 = new ImmRef(___nl__6);
hash_NL.NL_set_value(___ref______nl__6,___nl__15,___nl__14);
___nl__6 = ___ref______nl__6.getValue().clone();

//line 118
___nl__13 = null;
//line 118
___nl__14 = null;
//line 118
___nl__15 = null;
//line 119
___nl__9 = new ImmDouble((Double.Parse(___nl__9.getValue().ToString()))+(Double.Parse(___nl__10.getValue().ToString()))).clone();
//line 119
if (true) {goto label_6;}
//line 119
label_4:
//line 119
___nl__7 = null;
//line 119
___nl__8 = null;
//line 119
___nl__9 = null;
//line 119
___nl__10 = null;
//line 119
___nl__11 = null;
//line 119
___nl__12 = null;
//line 120
___ref______nl__2 = new ImmRef(___nl__2);
hash_NL.NL_set_value(___ref______nl__2,___nl__3,___nl__6);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 120
___nl__6 = null;
//line 121
___nl__5 = c_rt_lib_NL.NL_next_iter(___nl__5).clone();

//line 121
if (true) {goto label_3;}
//line 121
label_1:
//line 121
___nl__3 = null;
//line 121
___nl__4 = null;
//line 121
___nl__5 = null;
//line 122
___nl__0 = null;
//line 122
___arg__1.setValue(___nl__1);if(true) return ___nl__2;
//line 122
___nl__2 = null;
//line 122
___nl__0 = null;
//line 122
___arg__1.setValue(___nl__1);if(true) return null;
}

public static Imm NL_check(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();
Imm ___nl__2 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 125
___nl__2 = type_checker_NL.NL_check_modules(___nl__0,___nl__1).clone();

//line 125
___nl__0 = null;
//line 125
___nl__1 = null;
//line 125
if(true) return ___nl__2;
//line 125
___nl__2 = null;
//line 125
___nl__0 = null;
//line 125
___nl__1 = null;
//line 125
if(true) return null;
}

public static Imm NL_check_modules(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
Imm ___nl__9 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
ImmRef ___ref______nl__6 = null;
ImmRef ___ref______nl__7 = null;
ImmRef ___ref______nl__8 = null;
ImmRef ___ref______nl__9 = null;
Dictionary<String, Imm> __function_map;
//line 129
___nl__3 = new ImmArray(new Imm[0]).clone();
//line 129
___nl__4 = new ImmArray(new Imm[0]).clone();
//line 129
___nl__5 = new ImmDouble(1).clone();
//line 129
___nl__5 = new ImmDouble(-((ImmDouble)___nl__5).getDoubleValue()).clone();
//line 129
___nl__6 = new ImmString("").clone();
//line 129
__function_map = new Dictionary<String, Imm>();
__function_map.Add("errors",___nl__3);
__function_map.Add("warnings",___nl__4);
__function_map.Add("current_line",___nl__5);
__function_map.Add("module",___nl__6);
___nl__2 = new ImmHash(__function_map).clone();
//line 129
___nl__3 = null;
//line 129
___nl__4 = null;
//line 129
___nl__5 = null;
//line 129
___nl__6 = null;
//line 130
___ref______nl__2 = new ImmRef(___nl__2);
___nl__3 = type_checker_NL.NL_prepare_def_fun_priv(___nl__1,___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 131
___nl__5 = new ImmArray(new Imm[0]).clone();
//line 131
___nl__6 = new ImmArray(new Imm[0]).clone();
//line 131
__function_map = new Dictionary<String, Imm>();
__function_map.Add("delete",___nl__5);
__function_map.Add("create",___nl__6);
___nl__4 = new ImmHash(__function_map).clone();
//line 131
___nl__5 = null;
//line 131
___nl__6 = null;
//line 132
___nl__7 = c_rt_lib_NL.NL_init_iter(___nl__0).clone();

//line 132
label_3:
//line 132
___nl__5 = c_rt_lib_NL.NL_is_end_hash(___nl__7).clone();

//line 132
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_1;}}
//line 132
___nl__5 = c_rt_lib_NL.NL_get_key_iter(___nl__7).clone();

//line 132
___nl__6 = c_rt_lib_NL.NL_hash_get_value(___nl__0,___nl__5).clone();

//line 133
___nl__8 = new ImmDouble(1).clone();
//line 133
___nl__8 = new ImmDouble(-((ImmDouble)___nl__8).getDoubleValue()).clone();
//line 133
___nl__9 = ___nl__8.clone();
//line 133
((ImmHash)___nl__2).set("current_line", ___nl__9);
//line 133
___nl__8 = null;
//line 133
___nl__9 = null;
//line 134
___nl__8 = ___nl__5.clone();
//line 134
((ImmHash)___nl__2).set("module", ___nl__8);
//line 134
___nl__8 = null;
//line 135
___ref______nl__3 = new ImmRef(___nl__3);
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__4 = new ImmRef(___nl__4);
type_checker_NL.NL_check_module_priv(___nl__6,___ref______nl__3,___ref______nl__2,___ref______nl__4);
___nl__3 = ___ref______nl__3.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__4 = ___ref______nl__4.getValue().clone();

//line 136
___nl__7 = c_rt_lib_NL.NL_next_iter(___nl__7).clone();

//line 136
if (true) {goto label_3;}
//line 136
label_1:
//line 136
___nl__5 = null;
//line 136
___nl__6 = null;
//line 136
___nl__7 = null;
//line 137
___nl__6 = ((ImmHash)___nl__2).getHashValue()["errors"].clone();
//line 137
___nl__7 = ((ImmHash)___nl__2).getHashValue()["warnings"].clone();
//line 137
__function_map = new Dictionary<String, Imm>();
__function_map.Add("errors",___nl__6);
__function_map.Add("deref",___nl__4);
__function_map.Add("warnings",___nl__7);
___nl__5 = new ImmHash(__function_map).clone();
//line 137
___nl__6 = null;
//line 137
___nl__7 = null;
//line 137
___nl__0 = null;
//line 137
___nl__1 = null;
//line 137
___nl__2 = null;
//line 137
___nl__3 = null;
//line 137
___nl__4 = null;
//line 137
if(true) return ___nl__5;
//line 137
___nl__5 = null;
//line 137
___nl__2 = null;
//line 137
___nl__3 = null;
//line 137
___nl__4 = null;
//line 137
___nl__0 = null;
//line 137
___nl__1 = null;
//line 137
if(true) return null;
}

private static Imm NL_check_module_priv(Imm ___arg__0, ImmRef ___arg__1, ImmRef ___arg__2, ImmRef ___arg__3) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();Imm ___nl__2 = ___arg__2.getValue().clone();Imm ___nl__3 = ___arg__3.getValue().clone();
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
Imm ___nl__14 = null;
Imm ___nl__15 = null;
Imm ___nl__16 = null;
Imm ___nl__17 = null;
Imm ___nl__18 = null;
Imm ___nl__19 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
ImmRef ___ref______nl__6 = null;
ImmRef ___ref______nl__7 = null;
ImmRef ___ref______nl__8 = null;
ImmRef ___ref______nl__9 = null;
ImmRef ___ref______nl__10 = null;
ImmRef ___ref______nl__11 = null;
ImmRef ___ref______nl__12 = null;
ImmRef ___ref______nl__13 = null;
ImmRef ___ref______nl__14 = null;
ImmRef ___ref______nl__15 = null;
ImmRef ___ref______nl__16 = null;
ImmRef ___ref______nl__17 = null;
ImmRef ___ref______nl__18 = null;
ImmRef ___ref______nl__19 = null;
Dictionary<String, Imm> __function_map;
//line 142
___nl__6 = ((ImmHash)___nl__0).getHashValue()["name"].clone();
//line 142
__function_map = new Dictionary<String, Imm>();
___nl__8 = new ImmHash(__function_map).clone();
//line 142
___nl__9 = c_rt_lib_NL.NL_get_false().clone();
//line 142
__function_map = new Dictionary<String, Imm>();
__function_map.Add("vars",___nl__8);
__function_map.Add("is",___nl__9);
___nl__7 = new ImmHash(__function_map).clone();
//line 142
___nl__8 = null;
//line 142
___nl__9 = null;
//line 142
___nl__8 = tct_NL.NL_tct_empty().clone();

//line 142
__function_map = new Dictionary<String, Imm>();
__function_map.Add("deref",___nl__3);
__function_map.Add("current_module",___nl__6);
__function_map.Add("breaks",___nl__7);
__function_map.Add("ret_type",___nl__8);
___nl__5 = new ImmHash(__function_map).clone();
//line 142
___nl__6 = null;
//line 142
___nl__7 = null;
//line 142
___nl__8 = null;
//line 142
__function_map = new Dictionary<String, Imm>();
___nl__6 = new ImmHash(__function_map).clone();
//line 142
__function_map = new Dictionary<String, Imm>();
__function_map.Add("env",___nl__5);
__function_map.Add("imports",___nl__6);
__function_map.Add("funs",___nl__1);
___nl__4 = new ImmHash(__function_map).clone();
//line 142
___nl__5 = null;
//line 142
___nl__6 = null;
//line 143
___nl__5 = ((ImmHash)___nl__0).getHashValue()["import"].clone();
//line 143
___nl__7 = new ImmDouble(0).clone();
//line 143
___nl__8 = new ImmDouble(1).clone();
//line 143
___nl__9 = c_rt_lib_NL.NL_array_len(___nl__5).clone();

//line 143
label_3:
//line 143
___nl__10 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))>=(Double.Parse(___nl__9.getValue().ToString())) ).clone();
//line 143
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_1;}}
//line 143
___nl__6 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()].clone();
//line 144
___nl__11 = new ImmString("imports").clone();
//line 144
___nl__11 = c_rt_lib_NL.NL_get_ref_hash(___nl__4,___nl__11).clone();

//line 144
___nl__12 = ((ImmHash)___nl__6).getHashValue()["name"].clone();
//line 144
___nl__13 = c_rt_lib_NL.NL_get_true().clone();
//line 144
___ref______nl__11 = new ImmRef(___nl__11);
hash_NL.NL_set_value(___ref______nl__11,___nl__12,___nl__13);
___nl__11 = ___ref______nl__11.getValue().clone();

//line 144
___nl__13 = null;
//line 144
___nl__12 = null;
//line 144
___nl__12 = new ImmString("imports").clone();
//line 144
___ref______nl__4 = new ImmRef(___nl__4);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__4,___nl__12,___nl__11);
___nl__4 = ___ref______nl__4.getValue().clone();

//line 144
___nl__12 = null;
//line 144
___nl__11 = null;
//line 145
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString()))).clone();
//line 145
if (true) {goto label_3;}
//line 145
label_1:
//line 145
___nl__5 = null;
//line 145
___nl__6 = null;
//line 145
___nl__7 = null;
//line 145
___nl__8 = null;
//line 145
___nl__9 = null;
//line 145
___nl__10 = null;
//line 146
___nl__5 = new ImmString("imports").clone();
//line 146
___nl__5 = c_rt_lib_NL.NL_get_ref_hash(___nl__4,___nl__5).clone();

//line 146
___nl__6 = ((ImmHash)___nl__0).getHashValue()["name"].clone();
//line 146
___nl__7 = c_rt_lib_NL.NL_get_true().clone();
//line 146
___ref______nl__5 = new ImmRef(___nl__5);
hash_NL.NL_set_value(___ref______nl__5,___nl__6,___nl__7);
___nl__5 = ___ref______nl__5.getValue().clone();

//line 146
___nl__7 = null;
//line 146
___nl__6 = null;
//line 146
___nl__6 = new ImmString("imports").clone();
//line 146
___ref______nl__4 = new ImmRef(___nl__4);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__4,___nl__6,___nl__5);
___nl__4 = ___ref______nl__4.getValue().clone();

//line 146
___nl__6 = null;
//line 146
___nl__5 = null;
//line 147
___nl__5 = ((ImmHash)___nl__0).getHashValue()["fun_def"].clone();
//line 147
___nl__7 = new ImmDouble(0).clone();
//line 147
___nl__8 = new ImmDouble(1).clone();
//line 147
___nl__9 = c_rt_lib_NL.NL_array_len(___nl__5).clone();

//line 147
label_6:
//line 147
___nl__10 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))>=(Double.Parse(___nl__9.getValue().ToString())) ).clone();
//line 147
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_4;}}
//line 147
___nl__6 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()].clone();
//line 148
__function_map = new Dictionary<String, Imm>();
___nl__11 = new ImmHash(__function_map).clone();
//line 149
___nl__12 = ((ImmHash)___nl__6).getHashValue()["args"].clone();
//line 149
___nl__14 = new ImmDouble(0).clone();
//line 149
___nl__15 = new ImmDouble(1).clone();
//line 149
___nl__16 = c_rt_lib_NL.NL_array_len(___nl__12).clone();

//line 149
label_9:
//line 149
___nl__17 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__14.getValue().ToString()))>=(Double.Parse(___nl__16.getValue().ToString())) ).clone();
//line 149
if (c_rt_lib_NL.NL_check_true_native(___nl__17)) {if (true) {goto label_7;}}
//line 149
___nl__13 = (___nl__12 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__14).getDoubleValue()].clone();
//line 150
___nl__19 = ((ImmHash)___nl__13).getHashValue()["type"].clone();
//line 150
___ref______nl__2 = new ImmRef(___nl__2);
___nl__18 = type_checker_NL.NL_type_to_ptd_priv(___nl__19,___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 150
___nl__19 = null;
//line 151
___ref______nl__4 = new ImmRef(___nl__4);
___ref______nl__2 = new ImmRef(___nl__2);
type_checker_NL.NL_check_types_imported_priv(___nl__18,___ref______nl__4,___ref______nl__2);
___nl__4 = ___ref______nl__4.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 152
___nl__19 = ((ImmHash)___nl__13).getHashValue()["name"].clone();
//line 152
___ref______nl__11 = new ImmRef(___nl__11);
type_checker_NL.NL_add_var_decl_to_vars_priv(___nl__18,___nl__19,___ref______nl__11);
___nl__11 = ___ref______nl__11.getValue().clone();

//line 152
___nl__19 = null;
//line 152
___nl__18 = null;
//line 153
___nl__14 = new ImmDouble((Double.Parse(___nl__14.getValue().ToString()))+(Double.Parse(___nl__15.getValue().ToString()))).clone();
//line 153
if (true) {goto label_9;}
//line 153
label_7:
//line 153
___nl__12 = null;
//line 153
___nl__13 = null;
//line 153
___nl__14 = null;
//line 153
___nl__15 = null;
//line 153
___nl__16 = null;
//line 153
___nl__17 = null;
//line 154
___nl__13 = ((ImmHash)___nl__6).getHashValue()["ret_type"].clone();
//line 154
___ref______nl__2 = new ImmRef(___nl__2);
___nl__12 = type_checker_NL.NL_return_type_to_tct_priv(___nl__13,___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 154
___nl__13 = null;
//line 154
___nl__13 = new ImmString("env").clone();
//line 154
___nl__13 = c_rt_lib_NL.NL_get_ref_hash(___nl__4,___nl__13).clone();

//line 154
___nl__14 = ___nl__12.clone();
//line 154
((ImmHash)___nl__13).set("ret_type", ___nl__14);
//line 154
___nl__15 = new ImmString("env").clone();
//line 154
___ref______nl__4 = new ImmRef(___nl__4);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__4,___nl__15,___nl__13);
___nl__4 = ___ref______nl__4.getValue().clone();

//line 154
___nl__15 = null;
//line 154
___nl__12 = null;
//line 154
___nl__13 = null;
//line 154
___nl__14 = null;
//line 155
___nl__12 = ((ImmHash)___nl__4).getHashValue()["env"].clone();
//line 155
___nl__12 = ((ImmHash)___nl__12).getHashValue()["ret_type"].clone();
//line 155
___ref______nl__4 = new ImmRef(___nl__4);
___ref______nl__2 = new ImmRef(___nl__2);
type_checker_NL.NL_check_types_imported_priv(___nl__12,___ref______nl__4,___ref______nl__2);
___nl__4 = ___ref______nl__4.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 155
___nl__12 = null;
//line 156
___nl__12 = ((ImmHash)___nl__6).getHashValue()["cmd"].clone();
//line 156
___ref______nl__4 = new ImmRef(___nl__4);
___ref______nl__11 = new ImmRef(___nl__11);
___ref______nl__2 = new ImmRef(___nl__2);
type_checker_NL.NL_check_cmd_priv(___nl__12,___ref______nl__4,___ref______nl__11,___ref______nl__2);
___nl__4 = ___ref______nl__4.getValue().clone();
___nl__11 = ___ref______nl__11.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 156
___nl__12 = null;
//line 156
___nl__11 = null;
//line 157
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString()))).clone();
//line 157
if (true) {goto label_6;}
//line 157
label_4:
//line 157
___nl__5 = null;
//line 157
___nl__6 = null;
//line 157
___nl__7 = null;
//line 157
___nl__8 = null;
//line 157
___nl__9 = null;
//line 157
___nl__10 = null;
//line 158
___nl__5 = ((ImmHash)___nl__4).getHashValue()["funs"].clone();
//line 158
___nl__1 = ___nl__5.clone();
//line 158
___nl__5 = null;
//line 159
___nl__5 = ((ImmHash)___nl__4).getHashValue()["env"].clone();
//line 159
___nl__5 = ((ImmHash)___nl__5).getHashValue()["deref"].clone();
//line 159
___nl__3 = ___nl__5.clone();
//line 159
___nl__5 = null;
//line 159
___nl__4 = null;
//line 159
___nl__0 = null;
//line 159
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return null;
}

private static Imm NL_join_vars_priv(ImmRef ___arg__0, Imm ___arg__1, ImmRef ___arg__2, ImmRef ___arg__3) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.getValue().clone();Imm ___nl__3 = ___arg__3.getValue().clone();
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
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
ImmRef ___ref______nl__6 = null;
ImmRef ___ref______nl__7 = null;
ImmRef ___ref______nl__8 = null;
ImmRef ___ref______nl__9 = null;
ImmRef ___ref______nl__10 = null;
ImmRef ___ref______nl__11 = null;
ImmRef ___ref______nl__12 = null;
ImmRef ___ref______nl__13 = null;
Dictionary<String, Imm> __function_map;
//line 163
___nl__5 = new ImmString("__END").clone();
//line 163
___nl__4 = hash_NL.NL_has_key(___nl__1,___nl__5).clone();

//line 163
___nl__5 = null;
//line 163
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 163
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 163
___nl__1 = null;
//line 163
___nl__4 = null;
//line 163
___arg__0.setValue(___nl__0);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return null;
//line 163
if (true) {goto label_2;}
//line 163
label_2:
//line 163
___nl__4 = null;
//line 164
___nl__5 = new ImmString("__END").clone();
//line 164
___nl__4 = hash_NL.NL_has_key(___nl__0,___nl__5).clone();

//line 164
___nl__5 = null;
//line 164
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 164
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_4;}}
//line 165
___nl__0 = ___nl__1.clone();
//line 166
___nl__1 = null;
//line 166
___nl__4 = null;
//line 166
___arg__0.setValue(___nl__0);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return null;
//line 167
if (true) {goto label_4;}
//line 167
label_4:
//line 167
___nl__4 = null;
//line 168
___nl__6 = c_rt_lib_NL.NL_init_iter(___nl__0).clone();

//line 168
label_7:
//line 168
___nl__4 = c_rt_lib_NL.NL_is_end_hash(___nl__6).clone();

//line 168
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_5;}}
//line 168
___nl__4 = c_rt_lib_NL.NL_get_key_iter(___nl__6).clone();

//line 168
___nl__5 = c_rt_lib_NL.NL_hash_get_value(___nl__0,___nl__4).clone();

//line 169
___nl__7 = ((ImmHash)___nl__5).getHashValue()["overwrited"].clone();
//line 169
___nl__8 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("yes")).clone();
//line 169
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_9;}}
//line 176
___nl__8 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("no")).clone();
//line 176
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_10;}}
//line 176
___nl__8 = new ImmString("NOMATCHALERT").clone();
//line 176
___nl__8 = new ImmArray(new Imm[] {___nl__8,___nl__7,}).clone();
//line 176
c_rt_lib_NL.NL_die();
//line 169
label_9:
//line 170
___nl__9 = ((ImmHash)___nl__5).getHashValue()["type"].clone();
//line 171
___nl__10 = hash_NL.NL_get_value(___nl__1,___nl__4).clone();

//line 171
___nl__10 = ((ImmHash)___nl__10).getHashValue()["type"].clone();
//line 172
___nl__12 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("yes")).clone();
//line 172
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__13 = ptd_system_NL.NL_cross_type(___nl__9,___nl__10,___ref______nl__2,___ref______nl__3).clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 172
__function_map = new Dictionary<String, Imm>();
__function_map.Add("overwrited",___nl__12);
__function_map.Add("type",___nl__13);
___nl__11 = new ImmHash(__function_map).clone();
//line 172
___nl__12 = null;
//line 172
___nl__13 = null;
//line 172
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__4,___nl__11);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 172
___nl__11 = null;
//line 172
___nl__9 = null;
//line 172
___nl__10 = null;
//line 176
if (true) {goto label_8;}
//line 176
label_10:
//line 177
if (true) {goto label_8;}
//line 177
label_8:
//line 177
___nl__7 = null;
//line 177
___nl__8 = null;
//line 178
___nl__6 = c_rt_lib_NL.NL_next_iter(___nl__6).clone();

//line 178
if (true) {goto label_7;}
//line 178
label_5:
//line 178
___nl__4 = null;
//line 178
___nl__5 = null;
//line 178
___nl__6 = null;
//line 178
___nl__1 = null;
//line 178
___arg__0.setValue(___nl__0);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return null;
}

private static Imm NL_set_end_function_priv(ImmRef ___arg__0) {
Imm ___nl__0 = ___arg__0.getValue().clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 181
___nl__1 = new ImmString("__END").clone();
//line 181
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("yes")).clone();
//line 181
___nl__4 = tct_NL.NL_tct_empty().clone();

//line 181
__function_map = new Dictionary<String, Imm>();
__function_map.Add("overwrited",___nl__3);
__function_map.Add("type",___nl__4);
___nl__2 = new ImmHash(__function_map).clone();
//line 181
___nl__3 = null;
//line 181
___nl__4 = null;
//line 181
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 181
___nl__2 = null;
//line 181
___nl__1 = null;
//line 181
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_check_cmd_priv(Imm ___arg__0, ImmRef ___arg__1, ImmRef ___arg__2, ImmRef ___arg__3) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();Imm ___nl__2 = ___arg__2.getValue().clone();Imm ___nl__3 = ___arg__3.getValue().clone();
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
Imm ___nl__14 = null;
Imm ___nl__15 = null;
Imm ___nl__16 = null;
Imm ___nl__17 = null;
Imm ___nl__18 = null;
Imm ___nl__19 = null;
Imm ___nl__20 = null;
Imm ___nl__21 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
ImmRef ___ref______nl__6 = null;
ImmRef ___ref______nl__7 = null;
ImmRef ___ref______nl__8 = null;
ImmRef ___ref______nl__9 = null;
ImmRef ___ref______nl__10 = null;
ImmRef ___ref______nl__11 = null;
ImmRef ___ref______nl__12 = null;
ImmRef ___ref______nl__13 = null;
ImmRef ___ref______nl__14 = null;
ImmRef ___ref______nl__15 = null;
ImmRef ___ref______nl__16 = null;
ImmRef ___ref______nl__17 = null;
ImmRef ___ref______nl__18 = null;
ImmRef ___ref______nl__19 = null;
ImmRef ___ref______nl__20 = null;
ImmRef ___ref______nl__21 = null;
Dictionary<String, Imm> __function_map;
//line 186
___nl__4 = ((ImmHash)___nl__0).getHashValue()["debug"].clone();
//line 186
___nl__4 = ((ImmHash)___nl__4).getHashValue()["begin"].clone();
//line 186
___nl__4 = ((ImmHash)___nl__4).getHashValue()["line"].clone();
//line 186
___nl__5 = ___nl__4.clone();
//line 186
((ImmHash)___nl__3).set("current_line", ___nl__5);
//line 186
___nl__4 = null;
//line 186
___nl__5 = null;
//line 187
__function_map = new Dictionary<String, Imm>();
___nl__4 = new ImmHash(__function_map).clone();
//line 188
___nl__5 = ___nl__2.clone();
//line 189
___nl__6 = ((ImmHash)___nl__0).getHashValue()["cmd"].clone();
//line 189
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("if")).clone();
//line 189
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_2;}}
//line 208
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("for")).clone();
//line 208
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_3;}}
//line 225
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("fora")).clone();
//line 225
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_4;}}
//line 227
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("forh")).clone();
//line 227
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_5;}}
//line 229
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("loop")).clone();
//line 229
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_6;}}
//line 231
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("rep")).clone();
//line 231
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_7;}}
//line 233
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("while")).clone();
//line 233
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_8;}}
//line 235
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("if_mod")).clone();
//line 235
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_9;}}
//line 243
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("unless_mod")).clone();
//line 243
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_10;}}
//line 251
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("break")).clone();
//line 251
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_11;}}
//line 259
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("continue")).clone();
//line 259
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_12;}}
//line 267
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("match")).clone();
//line 267
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_13;}}
//line 269
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("value")).clone();
//line 269
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_14;}}
//line 271
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("return")).clone();
//line 271
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_15;}}
//line 284
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("block")).clone();
//line 284
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_16;}}
//line 290
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("die")).clone();
//line 290
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_17;}}
//line 295
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("var_decl")).clone();
//line 295
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_18;}}
//line 297
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("try")).clone();
//line 297
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_19;}}
//line 302
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("ensure")).clone();
//line 302
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_20;}}
//line 304
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("nop")).clone();
//line 304
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_21;}}
//line 304
___nl__7 = new ImmString("NOMATCHALERT").clone();
//line 304
___nl__7 = new ImmArray(new Imm[] {___nl__7,___nl__6,}).clone();
//line 304
c_rt_lib_NL.NL_die();
//line 189
label_2:
//line 189
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("if")).clone();
//line 190
___nl__10 = ((ImmHash)___nl__8).getHashValue()["cond"].clone();
//line 190
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__5 = new ImmRef(___nl__5);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__9 = type_checker_NL.NL_check_val_priv(___nl__10,___ref______nl__1,___ref______nl__5,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 190
___nl__10 = null;
//line 191
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__10 = ptd_system_NL.NL_is_condition_type(___nl__9,___ref______nl__1,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 191
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 191
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 191
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_23;}}
//line 191
___nl__11 = new ImmString("if argument should be sim or boolean instead of ").clone();
//line 191
___nl__13 = ((ImmHash)___nl__9).getHashValue()["type"].clone();
//line 191
___nl__12 = type_checker_NL.NL_get_print_tct_type_name_priv(___nl__13).clone();

//line 191
___nl__13 = null;
//line 191
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString()).clone();
//line 191
___nl__12 = null;
//line 191
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__11);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 191
___nl__11 = null;
//line 191
if (true) {goto label_23;}
//line 191
label_23:
//line 191
___nl__10 = null;
//line 194
___nl__10 = ___nl__5.clone();
//line 195
___nl__11 = ((ImmHash)___nl__8).getHashValue()["if"].clone();
//line 195
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__10 = new ImmRef(___nl__10);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_check_cmd_priv(___nl__11,___ref______nl__1,___ref______nl__10,___ref______nl__3);
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__10 = ___ref______nl__10.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 195
___nl__11 = null;
//line 196
___nl__11 = ((ImmHash)___nl__8).getHashValue()["elsif"].clone();
//line 196
___nl__13 = new ImmDouble(0).clone();
//line 196
___nl__14 = new ImmDouble(1).clone();
//line 196
___nl__15 = c_rt_lib_NL.NL_array_len(___nl__11).clone();

//line 196
label_26:
//line 196
___nl__16 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__13.getValue().ToString()))>=(Double.Parse(___nl__15.getValue().ToString())) ).clone();
//line 196
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_24;}}
//line 196
___nl__12 = (___nl__11 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__13).getDoubleValue()].clone();
//line 197
___nl__17 = ((ImmHash)___nl__12).getHashValue()["cmd"].clone();
//line 197
___nl__17 = ((ImmHash)___nl__17).getHashValue()["debug"].clone();
//line 197
___nl__17 = ((ImmHash)___nl__17).getHashValue()["begin"].clone();
//line 197
___nl__17 = ((ImmHash)___nl__17).getHashValue()["line"].clone();
//line 197
___nl__18 = ___nl__17.clone();
//line 197
((ImmHash)___nl__3).set("current_line", ___nl__18);
//line 197
___nl__17 = null;
//line 197
___nl__18 = null;
//line 198
___nl__18 = ((ImmHash)___nl__12).getHashValue()["cond"].clone();
//line 198
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__5 = new ImmRef(___nl__5);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__17 = type_checker_NL.NL_check_val_priv(___nl__18,___ref______nl__1,___ref______nl__5,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 198
___nl__18 = null;
//line 199
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__18 = ptd_system_NL.NL_is_condition_type(___nl__17,___ref______nl__1,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 199
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 199
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 199
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_28;}}
//line 199
___nl__19 = new ImmString("elsif condition should be sim or boolean instead of ").clone();
//line 199
___nl__21 = ((ImmHash)___nl__17).getHashValue()["type"].clone();
//line 199
___nl__20 = type_checker_NL.NL_get_print_tct_type_name_priv(___nl__21).clone();

//line 199
___nl__21 = null;
//line 199
___nl__19 = new ImmString(___nl__19.toString() + ___nl__20.toString()).clone();
//line 199
___nl__20 = null;
//line 199
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__19);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 199
___nl__19 = null;
//line 199
if (true) {goto label_28;}
//line 199
label_28:
//line 199
___nl__18 = null;
//line 202
___nl__18 = ___nl__5.clone();
//line 203
___nl__19 = ((ImmHash)___nl__12).getHashValue()["cmd"].clone();
//line 203
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__18 = new ImmRef(___nl__18);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_check_cmd_priv(___nl__19,___ref______nl__1,___ref______nl__18,___ref______nl__3);
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__18 = ___ref______nl__18.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 203
___nl__19 = null;
//line 204
___ref______nl__10 = new ImmRef(___nl__10);
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_join_vars_priv(___ref______nl__10,___nl__18,___ref______nl__1,___ref______nl__3);
___nl__10 = ___ref______nl__10.getValue().clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 204
___nl__17 = null;
//line 204
___nl__18 = null;
//line 205
___nl__13 = new ImmDouble((Double.Parse(___nl__13.getValue().ToString()))+(Double.Parse(___nl__14.getValue().ToString()))).clone();
//line 205
if (true) {goto label_26;}
//line 205
label_24:
//line 205
___nl__11 = null;
//line 205
___nl__12 = null;
//line 205
___nl__13 = null;
//line 205
___nl__14 = null;
//line 205
___nl__15 = null;
//line 205
___nl__16 = null;
//line 206
___nl__11 = ((ImmHash)___nl__8).getHashValue()["else"].clone();
//line 206
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__5 = new ImmRef(___nl__5);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_check_cmd_priv(___nl__11,___ref______nl__1,___ref______nl__5,___ref______nl__3);
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 206
___nl__11 = null;
//line 207
___ref______nl__5 = new ImmRef(___nl__5);
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_join_vars_priv(___ref______nl__5,___nl__10,___ref______nl__1,___ref______nl__3);
___nl__5 = ___ref______nl__5.getValue().clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 207
___nl__9 = null;
//line 207
___nl__10 = null;
//line 207
___nl__8 = null;
//line 208
if (true) {goto label_1;}
//line 208
label_3:
//line 208
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("for")).clone();
//line 209
___nl__9 = ((ImmHash)___nl__8).getHashValue()["start"].clone();
//line 209
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__9, new ImmString("value")).clone();
//line 209
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_30;}}
//line 211
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__9, new ImmString("var_decl")).clone();
//line 211
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_31;}}
//line 211
___nl__10 = new ImmString("NOMATCHALERT").clone();
//line 211
___nl__10 = new ImmArray(new Imm[] {___nl__10,___nl__9,}).clone();
//line 211
c_rt_lib_NL.NL_die();
//line 209
label_30:
//line 209
___nl__11 = c_rt_lib_NL.NL_ov_as(___nl__9, new ImmString("value")).clone();
//line 210
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__5 = new ImmRef(___nl__5);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_check_val_priv(___nl__11,___ref______nl__1,___ref______nl__5,___ref______nl__3);
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 210
___nl__11 = null;
//line 211
if (true) {goto label_29;}
//line 211
label_31:
//line 211
___nl__11 = c_rt_lib_NL.NL_ov_as(___nl__9, new ImmString("var_decl")).clone();
//line 212
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__5 = new ImmRef(___nl__5);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__12 = type_checker_NL.NL_check_var_decl_priv(___nl__11,___ref______nl__1,___ref______nl__5,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 212
___nl__13 = ((ImmHash)___nl__11).getHashValue()["name"].clone();
//line 212
___ref______nl__5 = new ImmRef(___nl__5);
type_checker_NL.NL_add_var_to_vars_priv(___nl__12,___nl__13,___ref______nl__5);
___nl__5 = ___ref______nl__5.getValue().clone();

//line 212
___nl__13 = null;
//line 212
___nl__12 = null;
//line 212
___nl__11 = null;
//line 213
if (true) {goto label_29;}
//line 213
label_29:
//line 213
___nl__9 = null;
//line 213
___nl__10 = null;
//line 214
___nl__9 = ___nl__5.clone();
//line 215
___nl__10 = ((ImmHash)___nl__8).getHashValue()["cond"].clone();
//line 215
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__10, new ImmString("nop")).clone();
//line 215
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 215
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 215
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_33;}}
//line 216
___nl__12 = ((ImmHash)___nl__8).getHashValue()["cond"].clone();
//line 216
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__9 = new ImmRef(___nl__9);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__11 = type_checker_NL.NL_check_val_priv(___nl__12,___ref______nl__1,___ref______nl__9,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__9 = ___ref______nl__9.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 216
___nl__12 = null;
//line 217
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__12 = ptd_system_NL.NL_is_condition_type(___nl__11,___ref______nl__1,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 217
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 217
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 217
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_35;}}
//line 217
___nl__13 = new ImmString("for condition should be sim or boolean instead of ").clone();
//line 217
___nl__15 = ((ImmHash)___nl__11).getHashValue()["type"].clone();
//line 217
___nl__14 = type_checker_NL.NL_get_print_tct_type_name_priv(___nl__15).clone();

//line 217
___nl__15 = null;
//line 217
___nl__13 = new ImmString(___nl__13.toString() + ___nl__14.toString()).clone();
//line 217
___nl__14 = null;
//line 217
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__13);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 217
___nl__13 = null;
//line 217
if (true) {goto label_35;}
//line 217
label_35:
//line 217
___nl__12 = null;
//line 220
___ref______nl__9 = new ImmRef(___nl__9);
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_join_vars_priv(___ref______nl__9,___nl__5,___ref______nl__1,___ref______nl__3);
___nl__9 = ___ref______nl__9.getValue().clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 220
___nl__11 = null;
//line 221
if (true) {goto label_33;}
//line 221
label_33:
//line 221
___nl__10 = null;
//line 222
___nl__10 = ((ImmHash)___nl__8).getHashValue()["cmd"].clone();
//line 222
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__9 = new ImmRef(___nl__9);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_break_continue_block_priv(___nl__10,___ref______nl__1,___ref______nl__9,___ref______nl__3);
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__9 = ___ref______nl__9.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 222
___nl__10 = null;
//line 223
___nl__10 = ((ImmHash)___nl__8).getHashValue()["iter"].clone();
//line 223
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__9 = new ImmRef(___nl__9);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_check_val_priv(___nl__10,___ref______nl__1,___ref______nl__9,___ref______nl__3);
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__9 = ___ref______nl__9.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 223
___nl__10 = null;
//line 224
___ref______nl__5 = new ImmRef(___nl__5);
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_join_vars_priv(___ref______nl__5,___nl__9,___ref______nl__1,___ref______nl__3);
___nl__5 = ___ref______nl__5.getValue().clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 224
___nl__9 = null;
//line 224
___nl__8 = null;
//line 225
if (true) {goto label_1;}
//line 225
label_4:
//line 225
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("fora")).clone();
//line 226
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__5 = new ImmRef(___nl__5);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_check_fora_priv(___nl__8,___ref______nl__1,___ref______nl__5,___ref______nl__3);
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 226
___nl__8 = null;
//line 227
if (true) {goto label_1;}
//line 227
label_5:
//line 227
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("forh")).clone();
//line 228
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__5 = new ImmRef(___nl__5);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_check_forh_priv(___nl__8,___ref______nl__1,___ref______nl__5,___ref______nl__3);
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 228
___nl__8 = null;
//line 229
if (true) {goto label_1;}
//line 229
label_6:
//line 229
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("loop")).clone();
//line 230
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__5 = new ImmRef(___nl__5);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_break_continue_block_priv(___nl__8,___ref______nl__1,___ref______nl__5,___ref______nl__3);
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 230
___nl__8 = null;
//line 231
if (true) {goto label_1;}
//line 231
label_7:
//line 231
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("rep")).clone();
//line 232
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__5 = new ImmRef(___nl__5);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_check_rep_priv(___nl__8,___ref______nl__1,___ref______nl__5,___ref______nl__3);
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 232
___nl__8 = null;
//line 233
if (true) {goto label_1;}
//line 233
label_8:
//line 233
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("while")).clone();
//line 234
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__5 = new ImmRef(___nl__5);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_check_while_priv(___nl__8,___ref______nl__1,___ref______nl__5,___ref______nl__3);
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 234
___nl__8 = null;
//line 235
if (true) {goto label_1;}
//line 235
label_9:
//line 235
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("if_mod")).clone();
//line 236
___nl__10 = ((ImmHash)___nl__8).getHashValue()["cond"].clone();
//line 236
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__5 = new ImmRef(___nl__5);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__9 = type_checker_NL.NL_check_val_priv(___nl__10,___ref______nl__1,___ref______nl__5,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 236
___nl__10 = null;
//line 237
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__10 = ptd_system_NL.NL_is_condition_type(___nl__9,___ref______nl__1,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 237
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 237
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 237
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_37;}}
//line 237
___nl__11 = new ImmString("if argument should be sim or boolean type instead of ").clone();
//line 237
___nl__13 = ((ImmHash)___nl__9).getHashValue()["type"].clone();
//line 237
___nl__12 = type_checker_NL.NL_get_print_tct_type_name_priv(___nl__13).clone();

//line 237
___nl__13 = null;
//line 237
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString()).clone();
//line 237
___nl__12 = null;
//line 237
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__11);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 237
___nl__11 = null;
//line 237
if (true) {goto label_37;}
//line 237
label_37:
//line 237
___nl__10 = null;
//line 240
___nl__10 = ___nl__5.clone();
//line 241
___nl__11 = ((ImmHash)___nl__8).getHashValue()["cmd"].clone();
//line 241
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__10 = new ImmRef(___nl__10);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_check_cmd_priv(___nl__11,___ref______nl__1,___ref______nl__10,___ref______nl__3);
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__10 = ___ref______nl__10.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 241
___nl__11 = null;
//line 242
___ref______nl__5 = new ImmRef(___nl__5);
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_join_vars_priv(___ref______nl__5,___nl__10,___ref______nl__1,___ref______nl__3);
___nl__5 = ___ref______nl__5.getValue().clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 242
___nl__9 = null;
//line 242
___nl__10 = null;
//line 242
___nl__8 = null;
//line 243
if (true) {goto label_1;}
//line 243
label_10:
//line 243
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("unless_mod")).clone();
//line 244
___nl__10 = ((ImmHash)___nl__8).getHashValue()["cond"].clone();
//line 244
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__5 = new ImmRef(___nl__5);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__9 = type_checker_NL.NL_check_val_priv(___nl__10,___ref______nl__1,___ref______nl__5,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 244
___nl__10 = null;
//line 245
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__10 = ptd_system_NL.NL_is_condition_type(___nl__9,___ref______nl__1,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 245
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 245
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 245
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_39;}}
//line 245
___nl__11 = new ImmString("unless argument should be sim or boolean type instead of ").clone();
//line 245
___nl__13 = ((ImmHash)___nl__9).getHashValue()["type"].clone();
//line 245
___nl__12 = type_checker_NL.NL_get_print_tct_type_name_priv(___nl__13).clone();

//line 245
___nl__13 = null;
//line 245
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString()).clone();
//line 245
___nl__12 = null;
//line 245
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__11);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 245
___nl__11 = null;
//line 245
if (true) {goto label_39;}
//line 245
label_39:
//line 245
___nl__10 = null;
//line 248
___nl__10 = ___nl__5.clone();
//line 249
___nl__11 = ((ImmHash)___nl__8).getHashValue()["cmd"].clone();
//line 249
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__10 = new ImmRef(___nl__10);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_check_cmd_priv(___nl__11,___ref______nl__1,___ref______nl__10,___ref______nl__3);
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__10 = ___ref______nl__10.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 249
___nl__11 = null;
//line 250
___ref______nl__5 = new ImmRef(___nl__5);
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_join_vars_priv(___ref______nl__5,___nl__10,___ref______nl__1,___ref______nl__3);
___nl__5 = ___ref______nl__5.getValue().clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 250
___nl__9 = null;
//line 250
___nl__10 = null;
//line 250
___nl__8 = null;
//line 251
if (true) {goto label_1;}
//line 251
label_11:
//line 252
___nl__8 = ((ImmHash)___nl__1).getHashValue()["env"].clone();
//line 252
___nl__8 = ((ImmHash)___nl__8).getHashValue()["breaks"].clone();
//line 252
___nl__8 = ((ImmHash)___nl__8).getHashValue()["is"].clone();
//line 252
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 252
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 252
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_41;}}
//line 253
___nl__9 = new ImmString("command break can be used only in cyclic block").clone();
//line 253
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__9);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 253
___nl__9 = null;
//line 254
if (true) {goto label_40;}
//line 254
label_41:
//line 255
___nl__9 = ((ImmHash)___nl__1).getHashValue()["env"].clone();
//line 255
___nl__9 = ((ImmHash)___nl__9).getHashValue()["breaks"].clone();
//line 255
___nl__9 = ((ImmHash)___nl__9).getHashValue()["vars"].clone();
//line 256
___ref______nl__9 = new ImmRef(___nl__9);
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_join_vars_priv(___ref______nl__9,___nl__5,___ref______nl__1,___ref______nl__3);
___nl__9 = ___ref______nl__9.getValue().clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 257
___nl__10 = new ImmString("env").clone();
//line 257
___nl__10 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__10).clone();

//line 257
___nl__11 = new ImmString("breaks").clone();
//line 257
___nl__11 = c_rt_lib_NL.NL_get_ref_hash(___nl__10,___nl__11).clone();

//line 257
___nl__12 = ___nl__9.clone();
//line 257
((ImmHash)___nl__11).set("vars", ___nl__12);
//line 257
___nl__13 = new ImmString("breaks").clone();
//line 257
___ref______nl__10 = new ImmRef(___nl__10);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__10,___nl__13,___nl__11);
___nl__10 = ___ref______nl__10.getValue().clone();

//line 257
___nl__13 = new ImmString("env").clone();
//line 257
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__13,___nl__10);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 257
___nl__13 = null;
//line 257
___nl__10 = null;
//line 257
___nl__11 = null;
//line 257
___nl__12 = null;
//line 257
___nl__9 = null;
//line 258
if (true) {goto label_40;}
//line 258
label_40:
//line 258
___nl__8 = null;
//line 259
if (true) {goto label_1;}
//line 259
label_12:
//line 260
___nl__8 = ((ImmHash)___nl__1).getHashValue()["env"].clone();
//line 260
___nl__8 = ((ImmHash)___nl__8).getHashValue()["breaks"].clone();
//line 260
___nl__8 = ((ImmHash)___nl__8).getHashValue()["is"].clone();
//line 260
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 260
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 260
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_43;}}
//line 261
___nl__9 = new ImmString("command continue can be used only in cyclic block").clone();
//line 261
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__9);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 261
___nl__9 = null;
//line 262
if (true) {goto label_42;}
//line 262
label_43:
//line 263
___nl__9 = ((ImmHash)___nl__1).getHashValue()["env"].clone();
//line 263
___nl__9 = ((ImmHash)___nl__9).getHashValue()["breaks"].clone();
//line 263
___nl__9 = ((ImmHash)___nl__9).getHashValue()["vars"].clone();
//line 264
___ref______nl__9 = new ImmRef(___nl__9);
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_join_vars_priv(___ref______nl__9,___nl__5,___ref______nl__1,___ref______nl__3);
___nl__9 = ___ref______nl__9.getValue().clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 265
___nl__10 = new ImmString("env").clone();
//line 265
___nl__10 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__10).clone();

//line 265
___nl__11 = new ImmString("breaks").clone();
//line 265
___nl__11 = c_rt_lib_NL.NL_get_ref_hash(___nl__10,___nl__11).clone();

//line 265
___nl__12 = ___nl__9.clone();
//line 265
((ImmHash)___nl__11).set("vars", ___nl__12);
//line 265
___nl__13 = new ImmString("breaks").clone();
//line 265
___ref______nl__10 = new ImmRef(___nl__10);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__10,___nl__13,___nl__11);
___nl__10 = ___ref______nl__10.getValue().clone();

//line 265
___nl__13 = new ImmString("env").clone();
//line 265
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__13,___nl__10);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 265
___nl__13 = null;
//line 265
___nl__10 = null;
//line 265
___nl__11 = null;
//line 265
___nl__12 = null;
//line 265
___nl__9 = null;
//line 266
if (true) {goto label_42;}
//line 266
label_42:
//line 266
___nl__8 = null;
//line 267
if (true) {goto label_1;}
//line 267
label_13:
//line 267
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("match")).clone();
//line 268
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__5 = new ImmRef(___nl__5);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_check_match_priv(___nl__8,___ref______nl__1,___ref______nl__5,___ref______nl__3);
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 268
___nl__8 = null;
//line 269
if (true) {goto label_1;}
//line 269
label_14:
//line 269
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("value")).clone();
//line 270
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__5 = new ImmRef(___nl__5);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_check_val_priv(___nl__8,___ref______nl__1,___ref______nl__5,___ref______nl__3);
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 270
___nl__8 = null;
//line 271
if (true) {goto label_1;}
//line 271
label_15:
//line 271
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("return")).clone();
//line 272
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__5 = new ImmRef(___nl__5);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__9 = type_checker_NL.NL_check_val_priv(___nl__8,___ref______nl__1,___ref______nl__5,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 273
___nl__12 = ((ImmHash)___nl__1).getHashValue()["env"].clone();
//line 273
___nl__12 = ((ImmHash)___nl__12).getHashValue()["ret_type"].clone();
//line 273
___nl__13 = new ImmString("tct_void").clone();
//line 273
___nl__10 = ov_NL.NL_is(___nl__12,___nl__13).clone();

//line 273
___nl__13 = null;
//line 273
___nl__12 = null;
//line 273
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 273
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_46;}}
//line 273
___nl__12 = ((ImmHash)___nl__9).getHashValue()["type"].clone();
//line 273
___nl__13 = new ImmString("tct_empty").clone();
//line 273
___nl__10 = ov_NL.NL_is(___nl__12,___nl__13).clone();

//line 273
___nl__13 = null;
//line 273
___nl__12 = null;
//line 273
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 273
label_46:
//line 273
___nl__11 = null;
//line 273
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 273
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_45;}}
//line 274
___nl__11 = new ImmString("can't return value in void function").clone();
//line 274
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__11);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 274
___nl__11 = null;
//line 275
if (true) {goto label_50;}
//line 275
label_45:
//line 275
___nl__13 = ((ImmHash)___nl__1).getHashValue()["env"].clone();
//line 275
___nl__13 = ((ImmHash)___nl__13).getHashValue()["ret_type"].clone();
//line 275
___nl__14 = new ImmString("tct_void").clone();
//line 275
___nl__10 = ov_NL.NL_is(___nl__13,___nl__14).clone();

//line 275
___nl__14 = null;
//line 275
___nl__13 = null;
//line 275
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 275
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 275
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_49;}}
//line 275
___nl__13 = ((ImmHash)___nl__1).getHashValue()["env"].clone();
//line 275
___nl__13 = ((ImmHash)___nl__13).getHashValue()["ret_type"].clone();
//line 275
___nl__14 = new ImmString("tct_im").clone();
//line 275
___nl__10 = ov_NL.NL_is(___nl__13,___nl__14).clone();

//line 275
___nl__14 = null;
//line 275
___nl__13 = null;
//line 275
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 275
label_49:
//line 275
___nl__12 = null;
//line 275
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 275
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_48;}}
//line 275
___nl__12 = ((ImmHash)___nl__9).getHashValue()["type"].clone();
//line 275
___nl__13 = new ImmString("tct_empty").clone();
//line 275
___nl__10 = ov_NL.NL_is(___nl__12,___nl__13).clone();

//line 275
___nl__13 = null;
//line 275
___nl__12 = null;
//line 275
label_48:
//line 275
___nl__11 = null;
//line 275
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 275
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_47;}}
//line 276
___nl__11 = new ImmString("must be returned value in non void function").clone();
//line 276
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__11);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 276
___nl__11 = null;
//line 277
if (true) {goto label_50;}
//line 277
label_47:
//line 277
___nl__12 = ((ImmHash)___nl__1).getHashValue()["env"].clone();
//line 277
___nl__12 = ((ImmHash)___nl__12).getHashValue()["ret_type"].clone();
//line 277
___nl__13 = new ImmString("tct_void").clone();
//line 277
___nl__10 = ov_NL.NL_is(___nl__12,___nl__13).clone();

//line 277
___nl__13 = null;
//line 277
___nl__12 = null;
//line 277
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 277
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 277
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_51;}}
//line 277
___nl__12 = ((ImmHash)___nl__9).getHashValue()["type"].clone();
//line 277
___nl__13 = new ImmString("tct_empty").clone();
//line 277
___nl__10 = ov_NL.NL_is(___nl__12,___nl__13).clone();

//line 277
___nl__13 = null;
//line 277
___nl__12 = null;
//line 277
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 277
label_51:
//line 277
___nl__11 = null;
//line 277
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 277
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_50;}}
//line 278
___nl__12 = ((ImmHash)___nl__1).getHashValue()["env"].clone();
//line 278
___nl__12 = ((ImmHash)___nl__12).getHashValue()["ret_type"].clone();
//line 278
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__11 = ptd_system_NL.NL_check_assignment(___nl__12,___nl__9,___ref______nl__1,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 278
___nl__12 = null;
//line 279
___nl__13 = new ImmString("err").clone();
//line 279
___nl__12 = ov_NL.NL_is(___nl__11,___nl__13).clone();

//line 279
___nl__13 = null;
//line 279
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 279
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_53;}}
//line 280
___nl__13 = new ImmString("the return value have the wrong type: ").clone();
//line 280
___nl__14 = type_checker_NL.NL_get_print_check_info_priv(___nl__11).clone();

//line 280
___nl__13 = new ImmString(___nl__13.toString() + ___nl__14.toString()).clone();
//line 280
___nl__14 = null;
//line 280
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__13);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 280
___nl__13 = null;
//line 281
if (true) {goto label_53;}
//line 281
label_53:
//line 281
___nl__12 = null;
//line 281
___nl__11 = null;
//line 282
if (true) {goto label_50;}
//line 282
label_50:
//line 282
___nl__10 = null;
//line 283
___ref______nl__5 = new ImmRef(___nl__5);
type_checker_NL.NL_set_end_function_priv(___ref______nl__5);
___nl__5 = ___ref______nl__5.getValue().clone();

//line 283
___nl__9 = null;
//line 283
___nl__8 = null;
//line 284
if (true) {goto label_1;}
//line 284
label_16:
//line 284
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("block")).clone();
//line 285
___nl__10 = new ImmDouble(0).clone();
//line 285
___nl__11 = new ImmDouble(1).clone();
//line 285
___nl__12 = c_rt_lib_NL.NL_array_len(___nl__8).clone();

//line 285
label_56:
//line 285
___nl__13 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__10.getValue().ToString()))>=(Double.Parse(___nl__12.getValue().ToString())) ).clone();
//line 285
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_54;}}
//line 285
___nl__9 = (___nl__8 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()].clone();
//line 286
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__5 = new ImmRef(___nl__5);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__14 = type_checker_NL.NL_check_cmd_priv(___nl__9,___ref______nl__1,___ref______nl__5,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 286
___nl__17 = c_rt_lib_NL.NL_init_iter(___nl__14).clone();

//line 286
label_59:
//line 286
___nl__15 = c_rt_lib_NL.NL_is_end_hash(___nl__17).clone();

//line 286
if (c_rt_lib_NL.NL_check_true_native(___nl__15)) {if (true) {goto label_57;}}
//line 286
___nl__15 = c_rt_lib_NL.NL_get_key_iter(___nl__17).clone();

//line 286
___nl__16 = c_rt_lib_NL.NL_hash_get_value(___nl__14,___nl__15).clone();

//line 287
___ref______nl__5 = new ImmRef(___nl__5);
type_checker_NL.NL_add_var_to_vars_priv(___nl__16,___nl__15,___ref______nl__5);
___nl__5 = ___ref______nl__5.getValue().clone();

//line 288
___nl__17 = c_rt_lib_NL.NL_next_iter(___nl__17).clone();

//line 288
if (true) {goto label_59;}
//line 288
label_57:
//line 288
___nl__14 = null;
//line 288
___nl__15 = null;
//line 288
___nl__16 = null;
//line 288
___nl__17 = null;
//line 289
___nl__10 = new ImmDouble((Double.Parse(___nl__10.getValue().ToString()))+(Double.Parse(___nl__11.getValue().ToString()))).clone();
//line 289
if (true) {goto label_56;}
//line 289
label_54:
//line 289
___nl__9 = null;
//line 289
___nl__10 = null;
//line 289
___nl__11 = null;
//line 289
___nl__12 = null;
//line 289
___nl__13 = null;
//line 289
___nl__8 = null;
//line 290
if (true) {goto label_1;}
//line 290
label_17:
//line 290
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("die")).clone();
//line 291
___nl__10 = new ImmDouble(0).clone();
//line 291
___nl__11 = new ImmDouble(1).clone();
//line 291
___nl__12 = c_rt_lib_NL.NL_array_len(___nl__8).clone();

//line 291
label_62:
//line 291
___nl__13 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__10.getValue().ToString()))>=(Double.Parse(___nl__12.getValue().ToString())) ).clone();
//line 291
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_60;}}
//line 291
___nl__9 = (___nl__8 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()].clone();
//line 292
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__5 = new ImmRef(___nl__5);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_check_val_priv(___nl__9,___ref______nl__1,___ref______nl__5,___ref______nl__3);
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 293
___nl__10 = new ImmDouble((Double.Parse(___nl__10.getValue().ToString()))+(Double.Parse(___nl__11.getValue().ToString()))).clone();
//line 293
if (true) {goto label_62;}
//line 293
label_60:
//line 293
___nl__9 = null;
//line 293
___nl__10 = null;
//line 293
___nl__11 = null;
//line 293
___nl__12 = null;
//line 293
___nl__13 = null;
//line 294
___ref______nl__5 = new ImmRef(___nl__5);
type_checker_NL.NL_set_end_function_priv(___ref______nl__5);
___nl__5 = ___ref______nl__5.getValue().clone();

//line 294
___nl__8 = null;
//line 295
if (true) {goto label_1;}
//line 295
label_18:
//line 295
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("var_decl")).clone();
//line 296
___nl__9 = ((ImmHash)___nl__8).getHashValue()["name"].clone();
//line 296
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__5 = new ImmRef(___nl__5);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__10 = type_checker_NL.NL_check_var_decl_priv(___nl__8,___ref______nl__1,___ref______nl__5,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 296
___ref______nl__4 = new ImmRef(___nl__4);
hash_NL.NL_set_value(___ref______nl__4,___nl__9,___nl__10);
___nl__4 = ___ref______nl__4.getValue().clone();

//line 296
___nl__10 = null;
//line 296
___nl__9 = null;
//line 296
___nl__8 = null;
//line 297
if (true) {goto label_1;}
//line 297
label_19:
//line 297
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("try")).clone();
//line 298
___nl__10 = ((ImmHash)___nl__1).getHashValue()["env"].clone();
//line 298
___nl__10 = ((ImmHash)___nl__10).getHashValue()["ret_type"].clone();
//line 298
___nl__11 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("speculation")).clone();
//line 298
__function_map = new Dictionary<String, Imm>();
__function_map.Add("type",___nl__10);
__function_map.Add("src",___nl__11);
___nl__9 = new ImmHash(__function_map).clone();
//line 298
___nl__10 = null;
//line 298
___nl__11 = null;
//line 299
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__10 = ptd_system_NL.NL_is_try_ensure_type(___nl__9,___ref______nl__1,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 299
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 299
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 299
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_64;}}
//line 299
___nl__11 = new ImmString("function in which is used 'try' must return variant: ok, err ").clone();
//line 299
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__11);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 299
___nl__11 = null;
//line 299
if (true) {goto label_64;}
//line 299
label_64:
//line 299
___nl__10 = null;
//line 301
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__5 = new ImmRef(___nl__5);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__10 = type_checker_NL.NL_check_try_ensure_priv(___nl__8,___ref______nl__1,___ref______nl__5,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 301
___nl__4 = ___nl__10.clone();
//line 301
___nl__10 = null;
//line 301
___nl__9 = null;
//line 301
___nl__8 = null;
//line 302
if (true) {goto label_1;}
//line 302
label_20:
//line 302
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("ensure")).clone();
//line 303
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__5 = new ImmRef(___nl__5);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__9 = type_checker_NL.NL_check_try_ensure_priv(___nl__8,___ref______nl__1,___ref______nl__5,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 303
___nl__4 = ___nl__9.clone();
//line 303
___nl__9 = null;
//line 303
___nl__8 = null;
//line 304
if (true) {goto label_1;}
//line 304
label_21:
//line 305
if (true) {goto label_1;}
//line 305
label_1:
//line 305
___nl__6 = null;
//line 305
___nl__7 = null;
//line 306
___nl__8 = c_rt_lib_NL.NL_init_iter(___nl__2).clone();

//line 306
label_67:
//line 306
___nl__6 = c_rt_lib_NL.NL_is_end_hash(___nl__8).clone();

//line 306
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_65;}}
//line 306
___nl__6 = c_rt_lib_NL.NL_get_key_iter(___nl__8).clone();

//line 306
___nl__7 = c_rt_lib_NL.NL_hash_get_value(___nl__2,___nl__6).clone();

//line 307
___nl__9 = hash_NL.NL_get_value(___nl__5,___nl__6).clone();

//line 307
___ref______nl__2 = new ImmRef(___nl__2);
hash_NL.NL_set_value(___ref______nl__2,___nl__6,___nl__9);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 307
___nl__9 = null;
//line 308
___nl__8 = c_rt_lib_NL.NL_next_iter(___nl__8).clone();

//line 308
if (true) {goto label_67;}
//line 308
label_65:
//line 308
___nl__6 = null;
//line 308
___nl__7 = null;
//line 308
___nl__8 = null;
//line 309
___nl__7 = new ImmString("__END").clone();
//line 309
___nl__6 = hash_NL.NL_has_key(___nl__5,___nl__7).clone();

//line 309
___nl__7 = null;
//line 309
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 309
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_69;}}
//line 310
___nl__7 = new ImmString("__END").clone();
//line 310
___nl__9 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("yes")).clone();
//line 310
___nl__10 = tct_NL.NL_tct_empty().clone();

//line 310
__function_map = new Dictionary<String, Imm>();
__function_map.Add("overwrited",___nl__9);
__function_map.Add("type",___nl__10);
___nl__8 = new ImmHash(__function_map).clone();
//line 310
___nl__9 = null;
//line 310
___nl__10 = null;
//line 310
___ref______nl__2 = new ImmRef(___nl__2);
hash_NL.NL_set_value(___ref______nl__2,___nl__7,___nl__8);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 310
___nl__8 = null;
//line 310
___nl__7 = null;
//line 311
if (true) {goto label_69;}
//line 311
label_69:
//line 311
___nl__6 = null;
//line 312
___nl__0 = null;
//line 312
___nl__5 = null;
//line 312
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__4;
//line 312
___nl__4 = null;
//line 312
___nl__5 = null;
//line 312
___nl__0 = null;
//line 312
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return null;
}

private static Imm NL_break_continue_block_priv(Imm ___arg__0, ImmRef ___arg__1, ImmRef ___arg__2, ImmRef ___arg__3) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();Imm ___nl__2 = ___arg__2.getValue().clone();Imm ___nl__3 = ___arg__3.getValue().clone();
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
ImmRef ___ref______nl__6 = null;
ImmRef ___ref______nl__7 = null;
ImmRef ___ref______nl__8 = null;
Dictionary<String, Imm> __function_map;
//line 316
___nl__4 = ((ImmHash)___nl__1).getHashValue()["env"].clone();
//line 316
___nl__4 = ((ImmHash)___nl__4).getHashValue()["breaks"].clone();
//line 317
___nl__6 = c_rt_lib_NL.NL_get_true().clone();
//line 317
__function_map = new Dictionary<String, Imm>();
__function_map.Add("is",___nl__6);
__function_map.Add("vars",___nl__2);
___nl__5 = new ImmHash(__function_map).clone();
//line 317
___nl__6 = null;
//line 317
___nl__6 = new ImmString("env").clone();
//line 317
___nl__6 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__6).clone();

//line 317
___nl__7 = ___nl__5.clone();
//line 317
((ImmHash)___nl__6).set("breaks", ___nl__7);
//line 317
___nl__8 = new ImmString("env").clone();
//line 317
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__8,___nl__6);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 317
___nl__8 = null;
//line 317
___nl__5 = null;
//line 317
___nl__6 = null;
//line 317
___nl__7 = null;
//line 318
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_check_cmd_priv(___nl__0,___ref______nl__1,___ref______nl__2,___ref______nl__3);
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 319
___nl__5 = ((ImmHash)___nl__1).getHashValue()["env"].clone();
//line 319
___nl__5 = ((ImmHash)___nl__5).getHashValue()["breaks"].clone();
//line 319
___nl__5 = ((ImmHash)___nl__5).getHashValue()["vars"].clone();
//line 319
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_join_vars_priv(___ref______nl__2,___nl__5,___ref______nl__1,___ref______nl__3);
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 319
___nl__5 = null;
//line 320
___nl__5 = new ImmString("env").clone();
//line 320
___nl__5 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__5).clone();

//line 320
___nl__6 = ___nl__4.clone();
//line 320
((ImmHash)___nl__5).set("breaks", ___nl__6);
//line 320
___nl__7 = new ImmString("env").clone();
//line 320
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__7,___nl__5);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 320
___nl__7 = null;
//line 320
___nl__5 = null;
//line 320
___nl__6 = null;
//line 320
___nl__4 = null;
//line 320
___nl__0 = null;
//line 320
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return null;
}

private static Imm NL_check_try_ensure_priv(Imm ___arg__0, ImmRef ___arg__1, ImmRef ___arg__2, ImmRef ___arg__3) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();Imm ___nl__2 = ___arg__2.getValue().clone();Imm ___nl__3 = ___arg__3.getValue().clone();
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
Imm ___nl__9 = null;
Imm ___nl__10 = null;
Imm ___nl__11 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
ImmRef ___ref______nl__6 = null;
ImmRef ___ref______nl__7 = null;
ImmRef ___ref______nl__8 = null;
ImmRef ___ref______nl__9 = null;
ImmRef ___ref______nl__10 = null;
ImmRef ___ref______nl__11 = null;
Dictionary<String, Imm> __function_map;
//line 324
__function_map = new Dictionary<String, Imm>();
___nl__4 = new ImmHash(__function_map).clone();
//line 325
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("decl")).clone();
//line 325
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_2;}}
//line 327
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("lval")).clone();
//line 327
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_3;}}
//line 335
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("expr")).clone();
//line 335
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_4;}}
//line 335
___nl__5 = new ImmString("NOMATCHALERT").clone();
//line 335
___nl__5 = new ImmArray(new Imm[] {___nl__5,___nl__0,}).clone();
//line 335
c_rt_lib_NL.NL_die();
//line 325
label_2:
//line 325
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("decl")).clone();
//line 326
___nl__7 = ((ImmHash)___nl__6).getHashValue()["name"].clone();
//line 326
___nl__9 = c_rt_lib_NL.NL_get_true().clone();
//line 326
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__8 = type_checker_NL.NL_check_var_decl_try_priv(___nl__6,___nl__9,___ref______nl__1,___ref______nl__2,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 326
___nl__9 = null;
//line 326
___ref______nl__4 = new ImmRef(___nl__4);
hash_NL.NL_set_value(___ref______nl__4,___nl__7,___nl__8);
___nl__4 = ___ref______nl__4.getValue().clone();

//line 326
___nl__8 = null;
//line 326
___nl__7 = null;
//line 326
___nl__6 = null;
//line 327
if (true) {goto label_1;}
//line 327
label_3:
//line 327
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("lval")).clone();
//line 328
___nl__8 = ((ImmHash)___nl__6).getHashValue()["right"].clone();
//line 328
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__7 = type_checker_NL.NL_check_val_priv(___nl__8,___ref______nl__1,___ref______nl__2,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 328
___nl__8 = null;
//line 329
___nl__9 = ((ImmHash)___nl__3).getHashValue()["errors"].clone();
//line 329
___nl__8 = array_NL.NL_len(___nl__9).clone();

//line 329
___nl__9 = null;
//line 330
___nl__10 = ((ImmHash)___nl__6).getHashValue()["left"].clone();
//line 330
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__9 = type_checker_NL.NL_get_type_left_site_equation_priv(___nl__10,___ref______nl__1,___ref______nl__2,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 330
___nl__10 = null;
//line 331
___nl__11 = ((ImmHash)___nl__3).getHashValue()["errors"].clone();
//line 331
___nl__10 = array_NL.NL_len(___nl__11).clone();

//line 331
___nl__11 = null;
//line 331
___nl__10 = new ImmDouble((Double.Parse(___nl__10.getValue().ToString()))-(Double.Parse(___nl__8.getValue().ToString()))).clone();
//line 331
___nl__8 = ___nl__10.clone();
//line 331
___nl__10 = null;
//line 332
___nl__10 = new ImmDouble(0).clone();
//line 332
___nl__10 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString()))>(Double.Parse(___nl__10.getValue().ToString())) ).clone();
//line 332
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 332
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_6;}}
//line 332
___nl__0 = null;
//line 332
___nl__5 = null;
//line 332
___nl__6 = null;
//line 332
___nl__7 = null;
//line 332
___nl__8 = null;
//line 332
___nl__9 = null;
//line 332
___nl__10 = null;
//line 332
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__4;
//line 332
if (true) {goto label_6;}
//line 332
label_6:
//line 332
___nl__10 = null;
//line 333
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__10 = ptd_system_NL.NL_get_try_ensure_ok_type(___nl__7,___ref______nl__1,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 333
___nl__11 = ___nl__10.clone();
//line 333
((ImmHash)___nl__7).set("type", ___nl__11);
//line 333
___nl__10 = null;
//line 333
___nl__11 = null;
//line 334
___nl__10 = ((ImmHash)___nl__6).getHashValue()["left"].clone();
//line 334
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_set_type_to_lval_priv(___nl__10,___nl__9,___nl__7,___ref______nl__1,___ref______nl__2,___ref______nl__3);
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 334
___nl__10 = null;
//line 334
___nl__7 = null;
//line 334
___nl__8 = null;
//line 334
___nl__9 = null;
//line 334
___nl__6 = null;
//line 335
if (true) {goto label_1;}
//line 335
label_4:
//line 335
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("expr")).clone();
//line 336
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__7 = type_checker_NL.NL_check_val_priv(___nl__6,___ref______nl__1,___ref______nl__2,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 337
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
ptd_system_NL.NL_get_try_ensure_ok_type(___nl__7,___ref______nl__1,___ref______nl__3);
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 337
___nl__7 = null;
//line 337
___nl__6 = null;
//line 338
if (true) {goto label_1;}
//line 338
label_1:
//line 338
___nl__5 = null;
//line 339
___nl__0 = null;
//line 339
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__4;
//line 339
___nl__4 = null;
//line 339
___nl__0 = null;
//line 339
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return null;
}

private static Imm NL_check_forh_priv(Imm ___arg__0, ImmRef ___arg__1, ImmRef ___arg__2, ImmRef ___arg__3) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();Imm ___nl__2 = ___arg__2.getValue().clone();Imm ___nl__3 = ___arg__3.getValue().clone();
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
Imm ___nl__9 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
ImmRef ___ref______nl__6 = null;
ImmRef ___ref______nl__7 = null;
ImmRef ___ref______nl__8 = null;
ImmRef ___ref______nl__9 = null;
Dictionary<String, Imm> __function_map;
//line 344
___nl__6 = ((ImmHash)___nl__0).getHashValue()["hash"].clone();
//line 344
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__5 = type_checker_NL.NL_check_val_priv(___nl__6,___ref______nl__1,___ref______nl__2,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 344
___nl__6 = null;
//line 344
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__4 = ptd_system_NL.NL_can_delete(___nl__5,___ref______nl__1,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 344
___nl__5 = null;
//line 345
___nl__7 = tct_NL.NL_tct_im().clone();

//line 345
___nl__6 = tct_NL.NL_tct_hash(___nl__7).clone();

//line 345
___nl__7 = null;
//line 345
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__5 = ptd_system_NL.NL_is_accepted(___nl__4,___nl__6,___ref______nl__1,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 345
___nl__6 = null;
//line 345
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 345
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_2;}}
//line 346
if (true) {goto label_1;}
//line 346
label_2:
//line 346
__function_map = new Dictionary<String, Imm>();
___nl__7 = new ImmHash(__function_map).clone();
//line 346
___nl__6 = tct_NL.NL_tct_rec(___nl__7).clone();

//line 346
___nl__7 = null;
//line 346
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__5 = ptd_system_NL.NL_is_accepted(___nl__4,___nl__6,___ref______nl__1,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 346
___nl__6 = null;
//line 346
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 346
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_3;}}
//line 347
___nl__6 = type_checker_NL.NL_is_known_priv(___nl__4).clone();

//line 347
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 347
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_5;}}
//line 347
___nl__7 = new ImmString("forh argument should be a hash not rec").clone();
//line 347
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__7);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 347
___nl__7 = null;
//line 347
if (true) {goto label_5;}
//line 347
label_5:
//line 347
___nl__6 = null;
//line 348
if (true) {goto label_1;}
//line 348
label_3:
//line 349
___nl__6 = new ImmString("forh argument should be a hash type instead of ").clone();
//line 349
___nl__8 = ((ImmHash)___nl__4).getHashValue()["type"].clone();
//line 349
___nl__7 = type_checker_NL.NL_get_print_tct_type_name_priv(___nl__8).clone();

//line 349
___nl__8 = null;
//line 349
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 349
___nl__7 = null;
//line 349
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__6);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 349
___nl__6 = null;
//line 350
if (true) {goto label_1;}
//line 350
label_1:
//line 350
___nl__5 = null;
//line 352
___nl__6 = ((ImmHash)___nl__4).getHashValue()["type"].clone();
//line 352
___nl__7 = new ImmString("tct_hash").clone();
//line 352
___nl__5 = ov_NL.NL_is(___nl__6,___nl__7).clone();

//line 352
___nl__7 = null;
//line 352
___nl__6 = null;
//line 352
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_7;}}
//line 352
___nl__5 = tct_NL.NL_tct_im().clone();

//line 352
if (true) {goto label_6;}
//line 352
label_7:
//line 352
___nl__5 = ((ImmHash)___nl__4).getHashValue()["type"].clone();
//line 352
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("tct_hash")).clone();
//line 352
label_6:
//line 352
___nl__6 = ___nl__5.clone();
//line 352
((ImmHash)___nl__4).set("type", ___nl__6);
//line 352
___nl__5 = null;
//line 352
___nl__6 = null;
//line 355
___nl__5 = ___nl__2.clone();
//line 356
___nl__6 = ((ImmHash)___nl__0).getHashValue()["key"].clone();
//line 356
___nl__8 = tct_NL.NL_tct_sim().clone();

//line 356
___nl__9 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("speculation")).clone();
//line 356
__function_map = new Dictionary<String, Imm>();
__function_map.Add("type",___nl__8);
__function_map.Add("src",___nl__9);
___nl__7 = new ImmHash(__function_map).clone();
//line 356
___nl__8 = null;
//line 356
___nl__9 = null;
//line 356
___ref______nl__5 = new ImmRef(___nl__5);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_var_decl_with_type_and_check_priv(___nl__6,___nl__7,___ref______nl__5,___ref______nl__3);
___nl__5 = ___ref______nl__5.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 356
___nl__7 = null;
//line 356
___nl__6 = null;
//line 357
___nl__6 = ((ImmHash)___nl__0).getHashValue()["val"].clone();
//line 357
___ref______nl__5 = new ImmRef(___nl__5);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_var_decl_with_type_and_check_priv(___nl__6,___nl__4,___ref______nl__5,___ref______nl__3);
___nl__5 = ___ref______nl__5.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 357
___nl__6 = null;
//line 358
___nl__6 = ((ImmHash)___nl__0).getHashValue()["cmd"].clone();
//line 358
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__5 = new ImmRef(___nl__5);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_break_continue_block_priv(___nl__6,___ref______nl__1,___ref______nl__5,___ref______nl__3);
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 358
___nl__6 = null;
//line 359
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_join_vars_priv(___ref______nl__2,___nl__5,___ref______nl__1,___ref______nl__3);
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 359
___nl__4 = null;
//line 359
___nl__5 = null;
//line 359
___nl__0 = null;
//line 359
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return null;
}

private static Imm NL_check_fora_priv(Imm ___arg__0, ImmRef ___arg__1, ImmRef ___arg__2, ImmRef ___arg__3) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();Imm ___nl__2 = ___arg__2.getValue().clone();Imm ___nl__3 = ___arg__3.getValue().clone();
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
ImmRef ___ref______nl__6 = null;
ImmRef ___ref______nl__7 = null;
ImmRef ___ref______nl__8 = null;
Dictionary<String, Imm> __function_map;
//line 364
___nl__6 = ((ImmHash)___nl__0).getHashValue()["array"].clone();
//line 364
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__5 = type_checker_NL.NL_check_val_priv(___nl__6,___ref______nl__1,___ref______nl__2,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 364
___nl__6 = null;
//line 364
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__4 = ptd_system_NL.NL_can_delete(___nl__5,___ref______nl__1,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 364
___nl__5 = null;
//line 366
___nl__7 = tct_NL.NL_tct_im().clone();

//line 366
___nl__6 = tct_NL.NL_tct_arr(___nl__7).clone();

//line 366
___nl__7 = null;
//line 366
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__5 = ptd_system_NL.NL_is_accepted(___nl__4,___nl__6,___ref______nl__1,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 366
___nl__6 = null;
//line 366
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 366
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 366
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_2;}}
//line 366
___nl__6 = new ImmString("fora argument should be an array instead of ").clone();
//line 366
___nl__8 = ((ImmHash)___nl__4).getHashValue()["type"].clone();
//line 366
___nl__7 = type_checker_NL.NL_get_print_tct_type_name_priv(___nl__8).clone();

//line 366
___nl__8 = null;
//line 366
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 366
___nl__7 = null;
//line 366
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__6);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 366
___nl__6 = null;
//line 366
if (true) {goto label_2;}
//line 366
label_2:
//line 366
___nl__5 = null;
//line 369
___nl__6 = ((ImmHash)___nl__4).getHashValue()["type"].clone();
//line 369
___nl__7 = new ImmString("tct_arr").clone();
//line 369
___nl__5 = ov_NL.NL_is(___nl__6,___nl__7).clone();

//line 369
___nl__7 = null;
//line 369
___nl__6 = null;
//line 369
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_4;}}
//line 369
___nl__5 = tct_NL.NL_tct_im().clone();

//line 369
if (true) {goto label_3;}
//line 369
label_4:
//line 369
___nl__5 = ((ImmHash)___nl__4).getHashValue()["type"].clone();
//line 369
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("tct_arr")).clone();
//line 369
label_3:
//line 369
___nl__6 = ___nl__5.clone();
//line 369
((ImmHash)___nl__4).set("type", ___nl__6);
//line 369
___nl__5 = null;
//line 369
___nl__6 = null;
//line 372
___nl__5 = ___nl__2.clone();
//line 373
___nl__6 = ((ImmHash)___nl__0).getHashValue()["iter"].clone();
//line 373
___ref______nl__5 = new ImmRef(___nl__5);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_var_decl_with_type_and_check_priv(___nl__6,___nl__4,___ref______nl__5,___ref______nl__3);
___nl__5 = ___ref______nl__5.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 373
___nl__6 = null;
//line 374
___nl__6 = ((ImmHash)___nl__0).getHashValue()["cmd"].clone();
//line 374
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__5 = new ImmRef(___nl__5);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_break_continue_block_priv(___nl__6,___ref______nl__1,___ref______nl__5,___ref______nl__3);
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 374
___nl__6 = null;
//line 375
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_join_vars_priv(___ref______nl__2,___nl__5,___ref______nl__1,___ref______nl__3);
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 375
___nl__4 = null;
//line 375
___nl__5 = null;
//line 375
___nl__0 = null;
//line 375
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return null;
}

private static Imm NL_check_while_priv(Imm ___arg__0, ImmRef ___arg__1, ImmRef ___arg__2, ImmRef ___arg__3) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();Imm ___nl__2 = ___arg__2.getValue().clone();Imm ___nl__3 = ___arg__3.getValue().clone();
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
ImmRef ___ref______nl__6 = null;
ImmRef ___ref______nl__7 = null;
ImmRef ___ref______nl__8 = null;
Dictionary<String, Imm> __function_map;
//line 380
___nl__5 = ((ImmHash)___nl__0).getHashValue()["cond"].clone();
//line 380
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__4 = type_checker_NL.NL_check_val_priv(___nl__5,___ref______nl__1,___ref______nl__2,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 380
___nl__5 = null;
//line 381
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__5 = ptd_system_NL.NL_is_condition_type(___nl__4,___ref______nl__1,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 381
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 381
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 381
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_2;}}
//line 381
___nl__6 = new ImmString("while argument should be sim or boolean type insteand of ").clone();
//line 381
___nl__8 = ((ImmHash)___nl__4).getHashValue()["type"].clone();
//line 381
___nl__7 = type_checker_NL.NL_get_print_tct_type_name_priv(___nl__8).clone();

//line 381
___nl__8 = null;
//line 381
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 381
___nl__7 = null;
//line 381
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__6);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 381
___nl__6 = null;
//line 381
if (true) {goto label_2;}
//line 381
label_2:
//line 381
___nl__5 = null;
//line 384
___nl__5 = ___nl__2.clone();
//line 385
___nl__6 = ((ImmHash)___nl__0).getHashValue()["cmd"].clone();
//line 385
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__5 = new ImmRef(___nl__5);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_break_continue_block_priv(___nl__6,___ref______nl__1,___ref______nl__5,___ref______nl__3);
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 385
___nl__6 = null;
//line 386
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_join_vars_priv(___ref______nl__2,___nl__5,___ref______nl__1,___ref______nl__3);
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 386
___nl__4 = null;
//line 386
___nl__5 = null;
//line 386
___nl__0 = null;
//line 386
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return null;
}

private static Imm NL_check_rep_priv(Imm ___arg__0, ImmRef ___arg__1, ImmRef ___arg__2, ImmRef ___arg__3) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();Imm ___nl__2 = ___arg__2.getValue().clone();Imm ___nl__3 = ___arg__3.getValue().clone();
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
Imm ___nl__9 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
ImmRef ___ref______nl__6 = null;
ImmRef ___ref______nl__7 = null;
ImmRef ___ref______nl__8 = null;
ImmRef ___ref______nl__9 = null;
Dictionary<String, Imm> __function_map;
//line 391
___nl__5 = ((ImmHash)___nl__0).getHashValue()["count"].clone();
//line 391
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__4 = type_checker_NL.NL_check_val_priv(___nl__5,___ref______nl__1,___ref______nl__2,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 391
___nl__5 = null;
//line 392
___nl__6 = tct_NL.NL_tct_sim().clone();

//line 392
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__5 = ptd_system_NL.NL_is_accepted(___nl__4,___nl__6,___ref______nl__1,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 392
___nl__6 = null;
//line 392
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 392
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 392
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_2;}}
//line 392
___nl__6 = new ImmString("rep argument should be a number instead of ").clone();
//line 392
___nl__8 = ((ImmHash)___nl__4).getHashValue()["type"].clone();
//line 392
___nl__7 = type_checker_NL.NL_get_print_tct_type_name_priv(___nl__8).clone();

//line 392
___nl__8 = null;
//line 392
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 392
___nl__7 = null;
//line 392
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__6);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 392
___nl__6 = null;
//line 392
if (true) {goto label_2;}
//line 392
label_2:
//line 392
___nl__5 = null;
//line 395
___nl__5 = ___nl__2.clone();
//line 396
___nl__6 = ((ImmHash)___nl__0).getHashValue()["iter"].clone();
//line 396
___nl__8 = tct_NL.NL_tct_sim().clone();

//line 396
___nl__9 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("speculation")).clone();
//line 396
__function_map = new Dictionary<String, Imm>();
__function_map.Add("type",___nl__8);
__function_map.Add("src",___nl__9);
___nl__7 = new ImmHash(__function_map).clone();
//line 396
___nl__8 = null;
//line 396
___nl__9 = null;
//line 396
___ref______nl__5 = new ImmRef(___nl__5);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_var_decl_with_type_and_check_priv(___nl__6,___nl__7,___ref______nl__5,___ref______nl__3);
___nl__5 = ___ref______nl__5.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 396
___nl__7 = null;
//line 396
___nl__6 = null;
//line 397
___nl__6 = ((ImmHash)___nl__0).getHashValue()["cmd"].clone();
//line 397
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__5 = new ImmRef(___nl__5);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_break_continue_block_priv(___nl__6,___ref______nl__1,___ref______nl__5,___ref______nl__3);
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 397
___nl__6 = null;
//line 398
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_join_vars_priv(___ref______nl__2,___nl__5,___ref______nl__1,___ref______nl__3);
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 398
___nl__4 = null;
//line 398
___nl__5 = null;
//line 398
___nl__0 = null;
//line 398
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return null;
}

private static Imm NL_check_match_priv(Imm ___arg__0, ImmRef ___arg__1, ImmRef ___arg__2, ImmRef ___arg__3) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();Imm ___nl__2 = ___arg__2.getValue().clone();Imm ___nl__3 = ___arg__3.getValue().clone();
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
Imm ___nl__14 = null;
Imm ___nl__15 = null;
Imm ___nl__16 = null;
Imm ___nl__17 = null;
Imm ___nl__18 = null;
Imm ___nl__19 = null;
Imm ___nl__20 = null;
Imm ___nl__21 = null;
Imm ___nl__22 = null;
Imm ___nl__23 = null;
Imm ___nl__24 = null;
Imm ___nl__25 = null;
Imm ___nl__26 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
ImmRef ___ref______nl__6 = null;
ImmRef ___ref______nl__7 = null;
ImmRef ___ref______nl__8 = null;
ImmRef ___ref______nl__9 = null;
ImmRef ___ref______nl__10 = null;
ImmRef ___ref______nl__11 = null;
ImmRef ___ref______nl__12 = null;
ImmRef ___ref______nl__13 = null;
ImmRef ___ref______nl__14 = null;
ImmRef ___ref______nl__15 = null;
ImmRef ___ref______nl__16 = null;
ImmRef ___ref______nl__17 = null;
ImmRef ___ref______nl__18 = null;
ImmRef ___ref______nl__19 = null;
ImmRef ___ref______nl__20 = null;
ImmRef ___ref______nl__21 = null;
ImmRef ___ref______nl__22 = null;
ImmRef ___ref______nl__23 = null;
ImmRef ___ref______nl__24 = null;
ImmRef ___ref______nl__25 = null;
ImmRef ___ref______nl__26 = null;
Dictionary<String, Imm> __function_map;
//line 403
___nl__6 = ((ImmHash)___nl__0).getHashValue()["val"].clone();
//line 403
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__5 = type_checker_NL.NL_check_val_priv(___nl__6,___ref______nl__1,___ref______nl__2,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 403
___nl__6 = null;
//line 403
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__4 = ptd_system_NL.NL_can_delete(___nl__5,___ref______nl__1,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 403
___nl__5 = null;
//line 405
___nl__5 = ((ImmHash)___nl__0).getHashValue()["branch_list"].clone();
//line 406
___nl__6 = c_rt_lib_NL.NL_get_false().clone();
//line 407
__function_map = new Dictionary<String, Imm>();
___nl__7 = new ImmHash(__function_map).clone();
//line 408
__function_map = new Dictionary<String, Imm>();
___nl__8 = new ImmHash(__function_map).clone();
//line 409
__function_map = new Dictionary<String, Imm>();
___nl__11 = new ImmHash(__function_map).clone();
//line 409
___nl__10 = tct_NL.NL_tct_var(___nl__11).clone();

//line 409
___nl__11 = null;
//line 409
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__9 = ptd_system_NL.NL_is_accepted(___nl__4,___nl__10,___ref______nl__1,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 409
___nl__10 = null;
//line 409
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 409
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 409
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_2;}}
//line 410
___nl__10 = new ImmString("wrong type used as match argument: ").clone();
//line 410
___nl__12 = ((ImmHash)___nl__4).getHashValue()["type"].clone();
//line 410
___nl__11 = type_checker_NL.NL_get_print_tct_type_name_priv(___nl__12).clone();

//line 410
___nl__12 = null;
//line 410
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString()).clone();
//line 410
___nl__11 = null;
//line 410
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__10);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 410
___nl__10 = null;
//line 411
if (true) {goto label_2;}
//line 411
label_2:
//line 411
___nl__9 = null;
//line 412
___nl__10 = ((ImmHash)___nl__4).getHashValue()["type"].clone();
//line 412
___nl__11 = new ImmString("tct_var").clone();
//line 412
___nl__9 = ov_NL.NL_is(___nl__10,___nl__11).clone();

//line 412
___nl__11 = null;
//line 412
___nl__10 = null;
//line 412
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 412
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_4;}}
//line 413
___nl__10 = ((ImmHash)___nl__4).getHashValue()["type"].clone();
//line 413
___nl__10 = c_rt_lib_NL.NL_ov_as(___nl__10, new ImmString("tct_var")).clone();
//line 413
___nl__8 = ___nl__10.clone();
//line 413
___nl__10 = null;
//line 414
__function_map = new Dictionary<String, Imm>();
___nl__10 = new ImmHash(__function_map).clone();
//line 415
___nl__12 = new ImmDouble(0).clone();
//line 415
___nl__13 = new ImmDouble(1).clone();
//line 415
___nl__14 = c_rt_lib_NL.NL_array_len(___nl__5).clone();

//line 415
label_7:
//line 415
___nl__15 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__12.getValue().ToString()))>=(Double.Parse(___nl__14.getValue().ToString())) ).clone();
//line 415
if (c_rt_lib_NL.NL_check_true_native(___nl__15)) {if (true) {goto label_5;}}
//line 415
___nl__11 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__12).getDoubleValue()].clone();
//line 416
___nl__16 = ((ImmHash)___nl__11).getHashValue()["variant"].clone();
//line 416
___nl__16 = ((ImmHash)___nl__16).getHashValue()["name"].clone();
//line 417
___nl__17 = hash_NL.NL_has_key(___nl__8,___nl__16).clone();

//line 417
___nl__17 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__17)).clone();
//line 417
___nl__17 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__17)).clone();
//line 417
if (c_rt_lib_NL.NL_check_true_native(___nl__17)) {if (true) {goto label_9;}}
//line 418
___nl__18 = type_checker_NL.NL_is_known_priv(___nl__4).clone();

//line 418
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 418
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_11;}}
//line 418
___nl__19 = new ImmString("variant definition `:").clone();
//line 418
___nl__19 = new ImmString(___nl__19.toString() + ___nl__16.toString()).clone();
//line 418
___nl__20 = new ImmString("' does not exist").clone();
//line 418
___nl__19 = new ImmString(___nl__19.toString() + ___nl__20.toString()).clone();
//line 418
___nl__20 = null;
//line 418
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__19);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 418
___nl__19 = null;
//line 418
if (true) {goto label_11;}
//line 418
label_11:
//line 418
___nl__18 = null;
//line 420
___nl__16 = null;
//line 420
___nl__17 = null;
//line 420
if (true) {goto label_6;}
//line 421
if (true) {goto label_9;}
//line 421
label_9:
//line 421
___nl__17 = null;
//line 423
___nl__17 = c_rt_lib_NL.NL_get_true().clone();
//line 423
___ref______nl__10 = new ImmRef(___nl__10);
hash_NL.NL_set_value(___ref______nl__10,___nl__16,___nl__17);
___nl__10 = ___ref______nl__10.getValue().clone();

//line 423
___nl__17 = null;
//line 424
___nl__17 = hash_NL.NL_get_value(___nl__8,___nl__16).clone();

//line 424
___nl__18 = c_rt_lib_NL.NL_ov_is(___nl__17, new ImmString("with_param")).clone();
//line 424
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_13;}}
//line 426
___nl__18 = c_rt_lib_NL.NL_ov_is(___nl__17, new ImmString("no_param")).clone();
//line 426
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_14;}}
//line 426
___nl__18 = new ImmString("NOMATCHALERT").clone();
//line 426
___nl__18 = new ImmArray(new Imm[] {___nl__18,___nl__17,}).clone();
//line 426
c_rt_lib_NL.NL_die();
//line 424
label_13:
//line 424
___nl__19 = c_rt_lib_NL.NL_ov_as(___nl__17, new ImmString("with_param")).clone();
//line 425
___ref______nl__7 = new ImmRef(___nl__7);
hash_NL.NL_set_value(___ref______nl__7,___nl__16,___nl__19);
___nl__7 = ___ref______nl__7.getValue().clone();

//line 425
___nl__19 = null;
//line 426
if (true) {goto label_12;}
//line 426
label_14:
//line 427
if (true) {goto label_12;}
//line 427
label_12:
//line 427
___nl__17 = null;
//line 427
___nl__18 = null;
//line 427
___nl__16 = null;
//line 427
label_6:
//line 428
___nl__12 = new ImmDouble((Double.Parse(___nl__12.getValue().ToString()))+(Double.Parse(___nl__13.getValue().ToString()))).clone();
//line 428
if (true) {goto label_7;}
//line 428
label_5:
//line 428
___nl__11 = null;
//line 428
___nl__12 = null;
//line 428
___nl__13 = null;
//line 428
___nl__14 = null;
//line 428
___nl__15 = null;
//line 429
___nl__13 = c_rt_lib_NL.NL_init_iter(___nl__8).clone();

//line 429
label_17:
//line 429
___nl__11 = c_rt_lib_NL.NL_is_end_hash(___nl__13).clone();

//line 429
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_15;}}
//line 429
___nl__11 = c_rt_lib_NL.NL_get_key_iter(___nl__13).clone();

//line 429
___nl__12 = c_rt_lib_NL.NL_hash_get_value(___nl__8,___nl__11).clone();

//line 430
___nl__14 = hash_NL.NL_has_key(___nl__10,___nl__11).clone();

//line 430
___nl__14 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__14)).clone();
//line 430
___nl__14 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__14)).clone();
//line 430
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_19;}}
//line 431
___nl__15 = new ImmString("unchecked match variants: ").clone();
//line 431
___nl__15 = new ImmString(___nl__15.toString() + ___nl__11.toString()).clone();
//line 431
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__15);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 431
___nl__15 = null;
//line 432
if (true) {goto label_19;}
//line 432
label_19:
//line 432
___nl__14 = null;
//line 433
___nl__13 = c_rt_lib_NL.NL_next_iter(___nl__13).clone();

//line 433
if (true) {goto label_17;}
//line 433
label_15:
//line 433
___nl__11 = null;
//line 433
___nl__12 = null;
//line 433
___nl__13 = null;
//line 434
___nl__11 = c_rt_lib_NL.NL_get_true().clone();
//line 434
___nl__6 = ___nl__11.clone();
//line 434
___nl__11 = null;
//line 434
___nl__10 = null;
//line 435
if (true) {goto label_4;}
//line 435
label_4:
//line 435
___nl__9 = null;
//line 436
___nl__9 = ___nl__2.clone();
//line 437
___nl__10 = c_rt_lib_NL.NL_get_true().clone();
//line 438
__function_map = new Dictionary<String, Imm>();
___nl__11 = new ImmHash(__function_map).clone();
//line 439
___nl__13 = new ImmDouble(0).clone();
//line 439
___nl__14 = new ImmDouble(1).clone();
//line 439
___nl__15 = c_rt_lib_NL.NL_array_len(___nl__5).clone();

//line 439
label_22:
//line 439
___nl__16 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__13.getValue().ToString()))>=(Double.Parse(___nl__15.getValue().ToString())) ).clone();
//line 439
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_20;}}
//line 439
___nl__12 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__13).getDoubleValue()].clone();
//line 440
___nl__17 = ___nl__2.clone();
//line 441
___nl__18 = ((ImmHash)___nl__12).getHashValue()["variant"].clone();
//line 441
___nl__18 = ((ImmHash)___nl__18).getHashValue()["name"].clone();
//line 442
___nl__19 = hash_NL.NL_has_key(___nl__11,___nl__18).clone();

//line 442
___nl__19 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__19)).clone();
//line 442
if (c_rt_lib_NL.NL_check_true_native(___nl__19)) {if (true) {goto label_24;}}
//line 442
___nl__20 = new ImmString("repeated the case name in match: ").clone();
//line 442
___nl__20 = new ImmString(___nl__20.toString() + ___nl__18.toString()).clone();
//line 442
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__20);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 442
___nl__20 = null;
//line 442
if (true) {goto label_24;}
//line 442
label_24:
//line 442
___nl__19 = null;
//line 444
___nl__19 = new ImmDouble(1).clone();
//line 444
___ref______nl__11 = new ImmRef(___nl__11);
hash_NL.NL_set_value(___ref______nl__11,___nl__18,___nl__19);
___nl__11 = ___ref______nl__11.getValue().clone();

//line 444
___nl__19 = null;
//line 445
___nl__19 = ((ImmHash)___nl__12).getHashValue()["variant"].clone();
//line 445
___nl__19 = ((ImmHash)___nl__19).getHashValue()["value"].clone();
//line 445
___nl__20 = c_rt_lib_NL.NL_ov_is(___nl__19, new ImmString("value")).clone();
//line 445
if (c_rt_lib_NL.NL_check_true_native(___nl__20)) {if (true) {goto label_26;}}
//line 461
___nl__20 = c_rt_lib_NL.NL_ov_is(___nl__19, new ImmString("none")).clone();
//line 461
if (c_rt_lib_NL.NL_check_true_native(___nl__20)) {if (true) {goto label_27;}}
//line 461
___nl__20 = new ImmString("NOMATCHALERT").clone();
//line 461
___nl__20 = new ImmArray(new Imm[] {___nl__20,___nl__19,}).clone();
//line 461
c_rt_lib_NL.NL_die();
//line 445
label_26:
//line 445
___nl__21 = c_rt_lib_NL.NL_ov_as(___nl__19, new ImmString("value")).clone();
//line 446
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__17 = new ImmRef(___nl__17);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_check_var_decl_priv(___nl__21,___ref______nl__1,___ref______nl__17,___ref______nl__3);
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__17 = ___ref______nl__17.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 448
___nl__23 = ___nl__6.clone();
//line 448
___nl__23 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__23)).clone();
//line 448
if (c_rt_lib_NL.NL_check_true_native(___nl__23)) {if (true) {goto label_29;}}
//line 449
___nl__24 = hash_NL.NL_has_key(___nl__8,___nl__18).clone();

//line 449
___nl__24 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__24)).clone();
//line 449
___nl__24 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__24)).clone();
//line 449
if (c_rt_lib_NL.NL_check_true_native(___nl__24)) {if (true) {goto label_31;}}
//line 449
___nl__17 = null;
//line 449
___nl__18 = null;
//line 449
___nl__19 = null;
//line 449
___nl__20 = null;
//line 449
___nl__21 = null;
//line 449
___nl__22 = null;
//line 449
___nl__23 = null;
//line 449
___nl__24 = null;
//line 449
if (true) {goto label_21;}
//line 449
if (true) {goto label_31;}
//line 449
label_31:
//line 449
___nl__24 = null;
//line 450
___nl__24 = hash_NL.NL_has_key(___nl__7,___nl__18).clone();

//line 450
___nl__24 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__24)).clone();
//line 450
___nl__24 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__24)).clone();
//line 450
if (c_rt_lib_NL.NL_check_true_native(___nl__24)) {if (true) {goto label_33;}}
//line 451
___nl__25 = new ImmString("variant `:").clone();
//line 451
___nl__25 = new ImmString(___nl__25.toString() + ___nl__18.toString()).clone();
//line 451
___nl__26 = new ImmString("' should has no param").clone();
//line 451
___nl__25 = new ImmString(___nl__25.toString() + ___nl__26.toString()).clone();
//line 451
___nl__26 = null;
//line 451
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__25);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 451
___nl__25 = null;
//line 452
___nl__17 = null;
//line 452
___nl__18 = null;
//line 452
___nl__19 = null;
//line 452
___nl__20 = null;
//line 452
___nl__21 = null;
//line 452
___nl__22 = null;
//line 452
___nl__23 = null;
//line 452
___nl__24 = null;
//line 452
if (true) {goto label_21;}
//line 453
if (true) {goto label_33;}
//line 453
label_33:
//line 453
___nl__24 = null;
//line 455
___nl__24 = hash_NL.NL_get_value(___nl__7,___nl__18).clone();

//line 455
___nl__22 = ___nl__24.clone();
//line 455
___nl__24 = null;
//line 456
if (true) {goto label_28;}
//line 456
label_29:
//line 457
___nl__24 = tct_NL.NL_tct_im().clone();

//line 457
___nl__22 = ___nl__24.clone();
//line 457
___nl__24 = null;
//line 458
if (true) {goto label_28;}
//line 458
label_28:
//line 458
___nl__23 = null;
//line 460
___nl__23 = ((ImmHash)___nl__21).getHashValue()["name"].clone();
//line 460
___ref______nl__17 = new ImmRef(___nl__17);
type_checker_NL.NL_add_var_decl_to_vars_priv(___nl__22,___nl__23,___ref______nl__17);
___nl__17 = ___ref______nl__17.getValue().clone();

//line 460
___nl__23 = null;
//line 460
___nl__22 = null;
//line 460
___nl__21 = null;
//line 461
if (true) {goto label_25;}
//line 461
label_27:
//line 462
___nl__21 = hash_NL.NL_has_key(___nl__7,___nl__18).clone();

//line 462
___nl__21 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__21)).clone();
//line 462
if (c_rt_lib_NL.NL_check_true_native(___nl__21)) {if (true) {goto label_35;}}
//line 463
___nl__22 = new ImmString("variant `:").clone();
//line 463
___nl__22 = new ImmString(___nl__22.toString() + ___nl__18.toString()).clone();
//line 463
___nl__23 = new ImmString(" should has param").clone();
//line 463
___nl__22 = new ImmString(___nl__22.toString() + ___nl__23.toString()).clone();
//line 463
___nl__23 = null;
//line 463
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__22);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 463
___nl__22 = null;
//line 464
if (true) {goto label_35;}
//line 464
label_35:
//line 464
___nl__21 = null;
//line 466
if (true) {goto label_25;}
//line 466
label_25:
//line 466
___nl__19 = null;
//line 466
___nl__20 = null;
//line 467
___nl__19 = ((ImmHash)___nl__12).getHashValue()["cmd"].clone();
//line 467
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__17 = new ImmRef(___nl__17);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_check_cmd_priv(___nl__19,___ref______nl__1,___ref______nl__17,___ref______nl__3);
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__17 = ___ref______nl__17.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 467
___nl__19 = null;
//line 468
___nl__19 = ((ImmHash)___nl__12).getHashValue()["variant"].clone();
//line 468
___nl__19 = ((ImmHash)___nl__19).getHashValue()["value"].clone();
//line 468
___nl__20 = c_rt_lib_NL.NL_ov_is(___nl__19, new ImmString("value")).clone();
//line 468
if (c_rt_lib_NL.NL_check_true_native(___nl__20)) {if (true) {goto label_37;}}
//line 470
___nl__20 = c_rt_lib_NL.NL_ov_is(___nl__19, new ImmString("none")).clone();
//line 470
if (c_rt_lib_NL.NL_check_true_native(___nl__20)) {if (true) {goto label_38;}}
//line 470
___nl__20 = new ImmString("NOMATCHALERT").clone();
//line 470
___nl__20 = new ImmArray(new Imm[] {___nl__20,___nl__19,}).clone();
//line 470
c_rt_lib_NL.NL_die();
//line 468
label_37:
//line 468
___nl__21 = c_rt_lib_NL.NL_ov_as(___nl__19, new ImmString("value")).clone();
//line 469
___nl__23 = ((ImmHash)___nl__21).getHashValue()["name"].clone();
//line 469
___nl__22 = hash_NL.NL_has_key(___nl__9,___nl__23).clone();

//line 469
___nl__23 = null;
//line 469
___nl__22 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__22)).clone();
//line 469
___nl__22 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__22)).clone();
//line 469
if (c_rt_lib_NL.NL_check_true_native(___nl__22)) {if (true) {goto label_40;}}
//line 469
___nl__23 = ((ImmHash)___nl__21).getHashValue()["name"].clone();
//line 469
___ref______nl__17 = new ImmRef(___nl__17);
hash_NL.NL_delete(___ref______nl__17,___nl__23);
___nl__17 = ___ref______nl__17.getValue().clone();

//line 469
___nl__23 = null;
//line 469
if (true) {goto label_40;}
//line 469
label_40:
//line 469
___nl__22 = null;
//line 469
___nl__21 = null;
//line 470
if (true) {goto label_36;}
//line 470
label_38:
//line 471
if (true) {goto label_36;}
//line 471
label_36:
//line 471
___nl__19 = null;
//line 471
___nl__20 = null;
//line 472
___nl__19 = ___nl__10.clone();
//line 472
___nl__19 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__19)).clone();
//line 472
if (c_rt_lib_NL.NL_check_true_native(___nl__19)) {if (true) {goto label_42;}}
//line 473
___nl__9 = ___nl__17.clone();
//line 474
if (true) {goto label_41;}
//line 474
label_42:
//line 475
___ref______nl__9 = new ImmRef(___nl__9);
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_join_vars_priv(___ref______nl__9,___nl__17,___ref______nl__1,___ref______nl__3);
___nl__9 = ___ref______nl__9.getValue().clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 476
if (true) {goto label_41;}
//line 476
label_41:
//line 476
___nl__19 = null;
//line 478
___nl__19 = c_rt_lib_NL.NL_get_false().clone();
//line 478
___nl__10 = ___nl__19.clone();
//line 478
___nl__19 = null;
//line 478
___nl__17 = null;
//line 478
___nl__18 = null;
//line 478
label_21:
//line 479
___nl__13 = new ImmDouble((Double.Parse(___nl__13.getValue().ToString()))+(Double.Parse(___nl__14.getValue().ToString()))).clone();
//line 479
if (true) {goto label_22;}
//line 479
label_20:
//line 479
___nl__12 = null;
//line 479
___nl__13 = null;
//line 479
___nl__14 = null;
//line 479
___nl__15 = null;
//line 479
___nl__16 = null;
//line 480
___nl__2 = ___nl__9.clone();
//line 480
___nl__4 = null;
//line 480
___nl__5 = null;
//line 480
___nl__6 = null;
//line 480
___nl__7 = null;
//line 480
___nl__8 = null;
//line 480
___nl__9 = null;
//line 480
___nl__10 = null;
//line 480
___nl__11 = null;
//line 480
___nl__0 = null;
//line 480
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return null;
}

private static Imm NL_check_val_priv(Imm ___arg__0, ImmRef ___arg__1, ImmRef ___arg__2, ImmRef ___arg__3) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();Imm ___nl__2 = ___arg__2.getValue().clone();Imm ___nl__3 = ___arg__3.getValue().clone();
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
Imm ___nl__14 = null;
Imm ___nl__15 = null;
Imm ___nl__16 = null;
Imm ___nl__17 = null;
Imm ___nl__18 = null;
Imm ___nl__19 = null;
Imm ___nl__20 = null;
Imm ___nl__21 = null;
Imm ___nl__22 = null;
Imm ___nl__23 = null;
Imm ___nl__24 = null;
Imm ___nl__25 = null;
Imm ___nl__26 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
ImmRef ___ref______nl__6 = null;
ImmRef ___ref______nl__7 = null;
ImmRef ___ref______nl__8 = null;
ImmRef ___ref______nl__9 = null;
ImmRef ___ref______nl__10 = null;
ImmRef ___ref______nl__11 = null;
ImmRef ___ref______nl__12 = null;
ImmRef ___ref______nl__13 = null;
ImmRef ___ref______nl__14 = null;
ImmRef ___ref______nl__15 = null;
ImmRef ___ref______nl__16 = null;
ImmRef ___ref______nl__17 = null;
ImmRef ___ref______nl__18 = null;
ImmRef ___ref______nl__19 = null;
ImmRef ___ref______nl__20 = null;
ImmRef ___ref______nl__21 = null;
ImmRef ___ref______nl__22 = null;
ImmRef ___ref______nl__23 = null;
ImmRef ___ref______nl__24 = null;
ImmRef ___ref______nl__25 = null;
ImmRef ___ref______nl__26 = null;
Dictionary<String, Imm> __function_map;
//line 485
___nl__5 = tct_NL.NL_tct_im().clone();

//line 485
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("speculation")).clone();
//line 485
__function_map = new Dictionary<String, Imm>();
__function_map.Add("type",___nl__5);
__function_map.Add("src",___nl__6);
___nl__4 = new ImmHash(__function_map).clone();
//line 485
___nl__5 = null;
//line 485
___nl__6 = null;
//line 486
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("ternary_op")).clone();
//line 486
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_2;}}
//line 502
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("hash_key")).clone();
//line 502
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_3;}}
//line 504
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("nop")).clone();
//line 504
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_4;}}
//line 506
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("parenthesis")).clone();
//line 506
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_5;}}
//line 508
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("variant")).clone();
//line 508
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_6;}}
//line 523
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("const")).clone();
//line 523
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_7;}}
//line 525
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("arr_decl")).clone();
//line 525
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_8;}}
//line 545
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("hash_decl")).clone();
//line 545
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_9;}}
//line 561
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("var")).clone();
//line 561
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_10;}}
//line 572
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("bin_op")).clone();
//line 572
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_11;}}
//line 574
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("var_op")).clone();
//line 574
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_12;}}
//line 605
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("unary_op")).clone();
//line 605
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_13;}}
//line 625
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("fun_label")).clone();
//line 625
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_14;}}
//line 628
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("fun_val")).clone();
//line 628
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_15;}}
//line 685
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("string")).clone();
//line 685
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_16;}}
//line 687
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("post_inc")).clone();
//line 687
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_17;}}
//line 693
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("post_dec")).clone();
//line 693
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_18;}}
//line 693
___nl__5 = new ImmString("NOMATCHALERT").clone();
//line 693
___nl__5 = new ImmArray(new Imm[] {___nl__5,___nl__0,}).clone();
//line 693
c_rt_lib_NL.NL_die();
//line 486
label_2:
//line 486
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("ternary_op")).clone();
//line 487
___nl__8 = ((ImmHash)___nl__6).getHashValue()["fst"].clone();
//line 487
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__7 = type_checker_NL.NL_check_val_priv(___nl__8,___ref______nl__1,___ref______nl__2,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 487
___nl__8 = null;
//line 488
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__8 = ptd_system_NL.NL_is_condition_type(___nl__7,___ref______nl__1,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 488
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 488
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 488
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_20;}}
//line 488
___nl__9 = new ImmString("ternary op first argument should be sim or boolean type instead of ").clone();
//line 488
___nl__11 = ((ImmHash)___nl__7).getHashValue()["type"].clone();
//line 488
___nl__10 = type_checker_NL.NL_get_print_tct_type_name_priv(___nl__11).clone();

//line 488
___nl__11 = null;
//line 488
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 488
___nl__10 = null;
//line 488
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__9);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 488
___nl__9 = null;
//line 488
if (true) {goto label_20;}
//line 488
label_20:
//line 488
___nl__8 = null;
//line 491
___nl__9 = ((ImmHash)___nl__6).getHashValue()["snd"].clone();
//line 491
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__8 = type_checker_NL.NL_check_val_priv(___nl__9,___ref______nl__1,___ref______nl__2,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 491
___nl__9 = null;
//line 491
___nl__8 = ((ImmHash)___nl__8).getHashValue()["type"].clone();
//line 492
___nl__10 = new ImmString("tct_void").clone();
//line 492
___nl__9 = ov_NL.NL_is(___nl__8,___nl__10).clone();

//line 492
___nl__10 = null;
//line 492
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 492
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_22;}}
//line 493
___nl__10 = ___nl__8.clone();
//line 493
((ImmHash)___nl__4).set("type", ___nl__10);
//line 493
___nl__10 = null;
//line 494
if (true) {goto label_21;}
//line 494
label_22:
//line 495
___nl__11 = ((ImmHash)___nl__6).getHashValue()["thrd"].clone();
//line 495
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__10 = type_checker_NL.NL_check_val_priv(___nl__11,___ref______nl__1,___ref______nl__2,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 495
___nl__11 = null;
//line 495
___nl__10 = ((ImmHash)___nl__10).getHashValue()["type"].clone();
//line 496
___nl__12 = new ImmString("tct_void").clone();
//line 496
___nl__11 = ov_NL.NL_is(___nl__10,___nl__12).clone();

//line 496
___nl__12 = null;
//line 496
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 496
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_24;}}
//line 497
___nl__12 = ___nl__10.clone();
//line 497
((ImmHash)___nl__4).set("type", ___nl__12);
//line 497
___nl__12 = null;
//line 498
if (true) {goto label_23;}
//line 498
label_24:
//line 499
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__12 = ptd_system_NL.NL_cross_type(___nl__8,___nl__10,___ref______nl__1,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 499
___nl__13 = ___nl__12.clone();
//line 499
((ImmHash)___nl__4).set("type", ___nl__13);
//line 499
___nl__12 = null;
//line 499
___nl__13 = null;
//line 500
if (true) {goto label_23;}
//line 500
label_23:
//line 500
___nl__11 = null;
//line 500
___nl__10 = null;
//line 501
if (true) {goto label_21;}
//line 501
label_21:
//line 501
___nl__9 = null;
//line 501
___nl__7 = null;
//line 501
___nl__8 = null;
//line 501
___nl__6 = null;
//line 502
if (true) {goto label_1;}
//line 502
label_3:
//line 502
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("hash_key")).clone();
//line 503
___nl__7 = tct_NL.NL_tct_sim().clone();

//line 503
___nl__8 = ___nl__7.clone();
//line 503
((ImmHash)___nl__4).set("type", ___nl__8);
//line 503
___nl__7 = null;
//line 503
___nl__8 = null;
//line 503
___nl__6 = null;
//line 504
if (true) {goto label_1;}
//line 504
label_4:
//line 505
___nl__6 = tct_NL.NL_tct_empty().clone();

//line 505
___nl__7 = ___nl__6.clone();
//line 505
((ImmHash)___nl__4).set("type", ___nl__7);
//line 505
___nl__6 = null;
//line 505
___nl__7 = null;
//line 506
if (true) {goto label_1;}
//line 506
label_5:
//line 506
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("parenthesis")).clone();
//line 507
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__7 = type_checker_NL.NL_check_val_priv(___nl__6,___ref______nl__1,___ref______nl__2,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 507
___nl__0 = null;
//line 507
___nl__4 = null;
//line 507
___nl__5 = null;
//line 507
___nl__6 = null;
//line 507
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__7;
//line 507
___nl__7 = null;
//line 507
___nl__6 = null;
//line 508
if (true) {goto label_1;}
//line 508
label_6:
//line 508
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("variant")).clone();
//line 509
___nl__7 = ((ImmHash)___nl__6).getHashValue()["name"].clone();
//line 509
___nl__8 = new ImmString("TRUE").clone();
//line 509
___nl__7 = c_rt_lib_NL.NL_native_to_nl(___nl__7.toString().Equals(___nl__8.toString())).clone();
//line 509
___nl__8 = null;
//line 509
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_27;}}
//line 509
___nl__7 = ((ImmHash)___nl__6).getHashValue()["name"].clone();
//line 509
___nl__8 = new ImmString("FALSE").clone();
//line 509
___nl__7 = c_rt_lib_NL.NL_native_to_nl(___nl__7.toString().Equals(___nl__8.toString())).clone();
//line 509
___nl__8 = null;
//line 509
label_27:
//line 509
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 509
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_26;}}
//line 510
___nl__8 = tct_NL.NL_tct_bool().clone();

//line 510
___nl__9 = ___nl__8.clone();
//line 510
((ImmHash)___nl__4).set("type", ___nl__9);
//line 510
___nl__8 = null;
//line 510
___nl__9 = null;
//line 511
___nl__0 = null;
//line 511
___nl__5 = null;
//line 511
___nl__6 = null;
//line 511
___nl__7 = null;
//line 511
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__4;
//line 512
if (true) {goto label_26;}
//line 512
label_26:
//line 512
___nl__7 = null;
//line 514
__function_map = new Dictionary<String, Imm>();
___nl__7 = new ImmHash(__function_map).clone();
//line 515
___nl__9 = ((ImmHash)___nl__6).getHashValue()["var"].clone();
//line 515
___nl__10 = new ImmString("nop").clone();
//line 515
___nl__8 = ov_NL.NL_is(___nl__9,___nl__10).clone();

//line 515
___nl__10 = null;
//line 515
___nl__9 = null;
//line 515
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 515
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_29;}}
//line 516
___nl__9 = ((ImmHash)___nl__6).getHashValue()["name"].clone();
//line 516
___nl__10 = tct_NL.NL_tct_none().clone();

//line 516
___ref______nl__7 = new ImmRef(___nl__7);
hash_NL.NL_set_value(___ref______nl__7,___nl__9,___nl__10);
___nl__7 = ___ref______nl__7.getValue().clone();

//line 516
___nl__10 = null;
//line 516
___nl__9 = null;
//line 517
if (true) {goto label_28;}
//line 517
label_29:
//line 518
___nl__10 = ((ImmHash)___nl__6).getHashValue()["var"].clone();
//line 518
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__9 = type_checker_NL.NL_check_val_priv(___nl__10,___ref______nl__1,___ref______nl__2,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 518
___nl__10 = null;
//line 519
___nl__10 = ((ImmHash)___nl__6).getHashValue()["name"].clone();
//line 519
___nl__11 = ((ImmHash)___nl__9).getHashValue()["type"].clone();
//line 519
___ref______nl__7 = new ImmRef(___nl__7);
hash_NL.NL_set_value(___ref______nl__7,___nl__10,___nl__11);
___nl__7 = ___ref______nl__7.getValue().clone();

//line 519
___nl__11 = null;
//line 519
___nl__10 = null;
//line 520
___nl__10 = ((ImmHash)___nl__9).getHashValue()["src"].clone();
//line 520
___nl__11 = ___nl__10.clone();
//line 520
((ImmHash)___nl__4).set("src", ___nl__11);
//line 520
___nl__10 = null;
//line 520
___nl__11 = null;
//line 520
___nl__9 = null;
//line 521
if (true) {goto label_28;}
//line 521
label_28:
//line 521
___nl__8 = null;
//line 522
___nl__8 = tct_NL.NL_tct_var(___nl__7).clone();

//line 522
___nl__9 = ___nl__8.clone();
//line 522
((ImmHash)___nl__4).set("type", ___nl__9);
//line 522
___nl__8 = null;
//line 522
___nl__9 = null;
//line 522
___nl__7 = null;
//line 522
___nl__6 = null;
//line 523
if (true) {goto label_1;}
//line 523
label_7:
//line 523
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("const")).clone();
//line 524
___nl__7 = tct_NL.NL_tct_sim().clone();

//line 524
___nl__8 = ___nl__7.clone();
//line 524
((ImmHash)___nl__4).set("type", ___nl__8);
//line 524
___nl__7 = null;
//line 524
___nl__8 = null;
//line 524
___nl__6 = null;
//line 525
if (true) {goto label_1;}
//line 525
label_8:
//line 525
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("arr_decl")).clone();
//line 526
___nl__7 = array_NL.NL_len(___nl__6).clone();

//line 526
___nl__8 = new ImmDouble(0).clone();
//line 526
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString())) ==((Double.Parse(___nl__8.getValue().ToString())))  ).clone();
//line 526
___nl__8 = null;
//line 526
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 526
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_31;}}
//line 527
___nl__9 = tct_NL.NL_tct_empty().clone();

//line 527
___nl__8 = tct_NL.NL_tct_arr(___nl__9).clone();

//line 527
___nl__9 = null;
//line 527
___nl__9 = ___nl__8.clone();
//line 527
((ImmHash)___nl__4).set("type", ___nl__9);
//line 527
___nl__8 = null;
//line 527
___nl__9 = null;
//line 528
___nl__0 = null;
//line 528
___nl__5 = null;
//line 528
___nl__6 = null;
//line 528
___nl__7 = null;
//line 528
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__4;
//line 529
if (true) {goto label_31;}
//line 529
label_31:
//line 529
___nl__7 = null;
//line 530
___nl__7 = new ImmArray(new Imm[0]).clone();
//line 531
___nl__8 = c_rt_lib_NL.NL_get_false().clone();
//line 532
___nl__10 = new ImmDouble(0).clone();
//line 532
___nl__11 = new ImmDouble(1).clone();
//line 532
___nl__12 = c_rt_lib_NL.NL_array_len(___nl__6).clone();

//line 532
label_34:
//line 532
___nl__13 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__10.getValue().ToString()))>=(Double.Parse(___nl__12.getValue().ToString())) ).clone();
//line 532
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_32;}}
//line 532
___nl__9 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()].clone();
//line 533
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__14 = type_checker_NL.NL_check_val_priv(___nl__9,___ref______nl__1,___ref______nl__2,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 534
___ref______nl__7 = new ImmRef(___nl__7);
array_NL.NL_push(___ref______nl__7,___nl__14);
___nl__7 = ___ref______nl__7.getValue().clone();

//line 535
___nl__15 = type_checker_NL.NL_is_known_priv(___nl__14).clone();

//line 535
___nl__15 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__15)).clone();
//line 535
___nl__15 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__15)).clone();
//line 535
if (c_rt_lib_NL.NL_check_true_native(___nl__15)) {if (true) {goto label_36;}}
//line 535
___nl__16 = c_rt_lib_NL.NL_get_true().clone();
//line 535
___nl__8 = ___nl__16.clone();
//line 535
___nl__16 = null;
//line 535
if (true) {goto label_36;}
//line 535
label_36:
//line 535
___nl__15 = null;
//line 535
___nl__14 = null;
//line 536
___nl__10 = new ImmDouble((Double.Parse(___nl__10.getValue().ToString()))+(Double.Parse(___nl__11.getValue().ToString()))).clone();
//line 536
if (true) {goto label_34;}
//line 536
label_32:
//line 536
___nl__9 = null;
//line 536
___nl__10 = null;
//line 536
___nl__11 = null;
//line 536
___nl__12 = null;
//line 536
___nl__13 = null;
//line 537
___nl__10 = new ImmDouble(0).clone();
//line 537
___nl__9 = (___nl__7 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()].clone();
//line 537
___nl__10 = null;
//line 537
___nl__9 = ((ImmHash)___nl__9).getHashValue()["type"].clone();
//line 538
___nl__10 = ___nl__8.clone();
//line 538
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 538
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_38;}}
//line 538
___nl__11 = tct_NL.NL_tct_im().clone();

//line 538
___nl__13 = new ImmDouble(0).clone();
//line 538
___nl__12 = (___nl__7 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__13).getDoubleValue()].clone();
//line 538
___nl__13 = null;
//line 538
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
ptd_system_NL.NL_check_assignment(___nl__11,___nl__12,___ref______nl__1,___ref______nl__3);
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 538
___nl__12 = null;
//line 538
___nl__11 = null;
//line 538
if (true) {goto label_38;}
//line 538
label_38:
//line 538
___nl__10 = null;
//line 539
___nl__10 = new ImmDouble(1).clone();
//line 539
label_40:
//line 539
___nl__11 = array_NL.NL_len(___nl__7).clone();

//line 539
___nl__11 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__10.getValue().ToString()))<(Double.Parse(___nl__11.getValue().ToString())) ).clone();
//line 539
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 539
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_39;}}
//line 540
___nl__13 = (___nl__7 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()].clone();
//line 540
___nl__13 = ((ImmHash)___nl__13).getHashValue()["type"].clone();
//line 540
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__12 = ptd_system_NL.NL_cross_type(___nl__9,___nl__13,___ref______nl__1,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 540
___nl__13 = null;
//line 540
___nl__9 = ___nl__12.clone();
//line 540
___nl__12 = null;
//line 541
___nl__12 = ___nl__8.clone();
//line 541
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 541
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_43;}}
//line 541
___nl__13 = tct_NL.NL_tct_im().clone();

//line 541
___nl__14 = (___nl__7 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()].clone();
//line 541
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
ptd_system_NL.NL_check_assignment(___nl__13,___nl__14,___ref______nl__1,___ref______nl__3);
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 541
___nl__14 = null;
//line 541
___nl__13 = null;
//line 541
if (true) {goto label_43;}
//line 541
label_43:
//line 541
___nl__12 = null;
//line 541
___nl__12 = new ImmDouble(1).clone();
//line 541
___nl__10 = new ImmDouble((Double.Parse(___nl__10.getValue().ToString()))+(Double.Parse(___nl__12.getValue().ToString()))).clone();
//line 541
___nl__12 = null;
//line 542
if (true) {goto label_40;}
//line 542
label_39:
//line 542
___nl__10 = null;
//line 542
___nl__11 = null;
//line 543
___nl__10 = ___nl__8.clone();
//line 543
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 543
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 543
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_45;}}
//line 543
___nl__11 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("known")).clone();
//line 543
___nl__12 = ___nl__11.clone();
//line 543
((ImmHash)___nl__4).set("src", ___nl__12);
//line 543
___nl__11 = null;
//line 543
___nl__12 = null;
//line 543
if (true) {goto label_45;}
//line 543
label_45:
//line 543
___nl__10 = null;
//line 544
___nl__10 = tct_NL.NL_tct_arr(___nl__9).clone();

//line 544
___nl__11 = ___nl__10.clone();
//line 544
((ImmHash)___nl__4).set("type", ___nl__11);
//line 544
___nl__10 = null;
//line 544
___nl__11 = null;
//line 544
___nl__7 = null;
//line 544
___nl__8 = null;
//line 544
___nl__9 = null;
//line 544
___nl__6 = null;
//line 545
if (true) {goto label_1;}
//line 545
label_9:
//line 545
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("hash_decl")).clone();
//line 546
__function_map = new Dictionary<String, Imm>();
___nl__7 = new ImmHash(__function_map).clone();
//line 547
___nl__8 = c_rt_lib_NL.NL_get_false().clone();
//line 548
___nl__10 = new ImmDouble(0).clone();
//line 548
___nl__11 = new ImmDouble(1).clone();
//line 548
___nl__12 = c_rt_lib_NL.NL_array_len(___nl__6).clone();

//line 548
label_48:
//line 548
___nl__13 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__10.getValue().ToString()))>=(Double.Parse(___nl__12.getValue().ToString())) ).clone();
//line 548
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_46;}}
//line 548
___nl__9 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()].clone();
//line 549
___nl__15 = ((ImmHash)___nl__9).getHashValue()["key"].clone();
//line 549
___nl__16 = new ImmString("hash_key").clone();
//line 549
___nl__14 = ov_NL.NL_as(___nl__15,___nl__16).clone();

//line 549
___nl__16 = null;
//line 549
___nl__15 = null;
//line 550
___nl__16 = ((ImmHash)___nl__9).getHashValue()["val"].clone();
//line 550
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__15 = type_checker_NL.NL_check_val_priv(___nl__16,___ref______nl__1,___ref______nl__2,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 550
___nl__16 = null;
//line 551
___ref______nl__7 = new ImmRef(___nl__7);
hash_NL.NL_set_value(___ref______nl__7,___nl__14,___nl__15);
___nl__7 = ___ref______nl__7.getValue().clone();

//line 552
___nl__16 = type_checker_NL.NL_is_known_priv(___nl__15).clone();

//line 552
___nl__16 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__16)).clone();
//line 552
___nl__16 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__16)).clone();
//line 552
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_50;}}
//line 552
___nl__17 = c_rt_lib_NL.NL_get_true().clone();
//line 552
___nl__8 = ___nl__17.clone();
//line 552
___nl__17 = null;
//line 552
if (true) {goto label_50;}
//line 552
label_50:
//line 552
___nl__16 = null;
//line 552
___nl__14 = null;
//line 552
___nl__15 = null;
//line 553
___nl__10 = new ImmDouble((Double.Parse(___nl__10.getValue().ToString()))+(Double.Parse(___nl__11.getValue().ToString()))).clone();
//line 553
if (true) {goto label_48;}
//line 553
label_46:
//line 553
___nl__9 = null;
//line 553
___nl__10 = null;
//line 553
___nl__11 = null;
//line 553
___nl__12 = null;
//line 553
___nl__13 = null;
//line 554
__function_map = new Dictionary<String, Imm>();
___nl__9 = new ImmHash(__function_map).clone();
//line 555
___nl__12 = c_rt_lib_NL.NL_init_iter(___nl__7).clone();

//line 555
label_53:
//line 555
___nl__10 = c_rt_lib_NL.NL_is_end_hash(___nl__12).clone();

//line 555
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_51;}}
//line 555
___nl__10 = c_rt_lib_NL.NL_get_key_iter(___nl__12).clone();

//line 555
___nl__11 = c_rt_lib_NL.NL_hash_get_value(___nl__7,___nl__10).clone();

//line 556
___nl__13 = ___nl__8.clone();
//line 556
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13)).clone();
//line 556
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_55;}}
//line 556
___nl__14 = tct_NL.NL_tct_im().clone();

//line 556
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
ptd_system_NL.NL_check_assignment(___nl__14,___nl__11,___ref______nl__1,___ref______nl__3);
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 556
___nl__14 = null;
//line 556
if (true) {goto label_55;}
//line 556
label_55:
//line 556
___nl__13 = null;
//line 557
___nl__13 = ((ImmHash)___nl__11).getHashValue()["type"].clone();
//line 557
___ref______nl__9 = new ImmRef(___nl__9);
hash_NL.NL_set_value(___ref______nl__9,___nl__10,___nl__13);
___nl__9 = ___ref______nl__9.getValue().clone();

//line 557
___nl__13 = null;
//line 558
___nl__12 = c_rt_lib_NL.NL_next_iter(___nl__12).clone();

//line 558
if (true) {goto label_53;}
//line 558
label_51:
//line 558
___nl__10 = null;
//line 558
___nl__11 = null;
//line 558
___nl__12 = null;
//line 559
___nl__10 = ___nl__8.clone();
//line 559
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 559
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 559
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_57;}}
//line 559
___nl__11 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("knownhash")).clone();
//line 559
___nl__12 = ___nl__11.clone();
//line 559
((ImmHash)___nl__4).set("src", ___nl__12);
//line 559
___nl__11 = null;
//line 559
___nl__12 = null;
//line 559
if (true) {goto label_57;}
//line 559
label_57:
//line 559
___nl__10 = null;
//line 560
___nl__10 = tct_NL.NL_tct_rec(___nl__9).clone();

//line 560
___nl__11 = ___nl__10.clone();
//line 560
((ImmHash)___nl__4).set("type", ___nl__11);
//line 560
___nl__10 = null;
//line 560
___nl__11 = null;
//line 560
___nl__7 = null;
//line 560
___nl__8 = null;
//line 560
___nl__9 = null;
//line 560
___nl__6 = null;
//line 561
if (true) {goto label_1;}
//line 561
label_10:
//line 561
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("var")).clone();
//line 562
___nl__7 = hash_NL.NL_has_key(___nl__2,___nl__6).clone();

//line 562
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 562
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 562
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_59;}}
//line 563
___nl__8 = new ImmString("variable `").clone();
//line 563
___nl__8 = new ImmString(___nl__8.toString() + ___nl__6.toString()).clone();
//line 563
___nl__9 = new ImmString("' does not exist").clone();
//line 563
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 563
___nl__9 = null;
//line 563
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__8);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 563
___nl__8 = null;
//line 564
___nl__0 = null;
//line 564
___nl__5 = null;
//line 564
___nl__6 = null;
//line 564
___nl__7 = null;
//line 564
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__4;
//line 565
if (true) {goto label_59;}
//line 565
label_59:
//line 565
___nl__7 = null;
//line 566
___nl__7 = hash_NL.NL_get_value(___nl__2,___nl__6).clone();

//line 567
___nl__8 = ((ImmHash)___nl__7).getHashValue()["overwrited"].clone();
//line 567
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("yes")).clone();
//line 567
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_61;}}
//line 569
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("no")).clone();
//line 569
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_62;}}
//line 569
___nl__9 = new ImmString("NOMATCHALERT").clone();
//line 569
___nl__9 = new ImmArray(new Imm[] {___nl__9,___nl__8,}).clone();
//line 569
c_rt_lib_NL.NL_die();
//line 567
label_61:
//line 568
___nl__11 = ((ImmHash)___nl__7).getHashValue()["type"].clone();
//line 568
___nl__12 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("speculation")).clone();
//line 568
__function_map = new Dictionary<String, Imm>();
__function_map.Add("type",___nl__11);
__function_map.Add("src",___nl__12);
___nl__10 = new ImmHash(__function_map).clone();
//line 568
___nl__11 = null;
//line 568
___nl__12 = null;
//line 568
___nl__0 = null;
//line 568
___nl__4 = null;
//line 568
___nl__5 = null;
//line 568
___nl__6 = null;
//line 568
___nl__7 = null;
//line 568
___nl__8 = null;
//line 568
___nl__9 = null;
//line 568
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__10;
//line 568
___nl__10 = null;
//line 569
if (true) {goto label_60;}
//line 569
label_62:
//line 570
___nl__11 = ((ImmHash)___nl__7).getHashValue()["type"].clone();
//line 570
___nl__12 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("known")).clone();
//line 570
__function_map = new Dictionary<String, Imm>();
__function_map.Add("type",___nl__11);
__function_map.Add("src",___nl__12);
___nl__10 = new ImmHash(__function_map).clone();
//line 570
___nl__11 = null;
//line 570
___nl__12 = null;
//line 570
___nl__0 = null;
//line 570
___nl__4 = null;
//line 570
___nl__5 = null;
//line 570
___nl__6 = null;
//line 570
___nl__7 = null;
//line 570
___nl__8 = null;
//line 570
___nl__9 = null;
//line 570
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__10;
//line 570
___nl__10 = null;
//line 571
if (true) {goto label_60;}
//line 571
label_60:
//line 571
___nl__8 = null;
//line 571
___nl__9 = null;
//line 571
___nl__7 = null;
//line 571
___nl__6 = null;
//line 572
if (true) {goto label_1;}
//line 572
label_11:
//line 572
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("bin_op")).clone();
//line 573
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__7 = type_checker_NL.NL_get_type_from_bin_op_and_check_priv(___nl__6,___ref______nl__1,___ref______nl__2,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 573
___nl__0 = null;
//line 573
___nl__4 = null;
//line 573
___nl__5 = null;
//line 573
___nl__6 = null;
//line 573
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__7;
//line 573
___nl__7 = null;
//line 573
___nl__6 = null;
//line 574
if (true) {goto label_1;}
//line 574
label_12:
//line 574
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("var_op")).clone();
//line 575
___nl__9 = ((ImmHash)___nl__6).getHashValue()["left"].clone();
//line 575
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__8 = type_checker_NL.NL_check_val_priv(___nl__9,___ref______nl__1,___ref______nl__2,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 575
___nl__9 = null;
//line 575
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__7 = ptd_system_NL.NL_can_delete(___nl__8,___ref______nl__1,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 575
___nl__8 = null;
//line 578
___nl__9 = ((ImmHash)___nl__6).getHashValue()["op"].clone();
//line 578
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__9, new ImmString("ov_is")).clone();
//line 578
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_64;}}
//line 580
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__9, new ImmString("ov_as")).clone();
//line 580
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_65;}}
//line 580
___nl__10 = new ImmString("NOMATCHALERT").clone();
//line 580
___nl__10 = new ImmArray(new Imm[] {___nl__10,___nl__9,}).clone();
//line 580
c_rt_lib_NL.NL_die();
//line 578
label_64:
//line 579
___nl__12 = tct_NL.NL_tct_bool().clone();

//line 579
___nl__13 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("speculation")).clone();
//line 579
__function_map = new Dictionary<String, Imm>();
__function_map.Add("type",___nl__12);
__function_map.Add("src",___nl__13);
___nl__11 = new ImmHash(__function_map).clone();
//line 579
___nl__12 = null;
//line 579
___nl__13 = null;
//line 579
___nl__8 = ___nl__11.clone();
//line 579
___nl__11 = null;
//line 580
if (true) {goto label_63;}
//line 580
label_65:
//line 581
___nl__12 = tct_NL.NL_tct_im().clone();

//line 581
___nl__13 = ((ImmHash)___nl__7).getHashValue()["src"].clone();
//line 581
__function_map = new Dictionary<String, Imm>();
__function_map.Add("type",___nl__12);
__function_map.Add("src",___nl__13);
___nl__11 = new ImmHash(__function_map).clone();
//line 581
___nl__12 = null;
//line 581
___nl__13 = null;
//line 581
___nl__8 = ___nl__11.clone();
//line 581
___nl__11 = null;
//line 582
if (true) {goto label_63;}
//line 582
label_63:
//line 582
___nl__9 = null;
//line 582
___nl__10 = null;
//line 583
__function_map = new Dictionary<String, Imm>();
___nl__11 = new ImmHash(__function_map).clone();
//line 583
___nl__10 = tct_NL.NL_tct_var(___nl__11).clone();

//line 583
___nl__11 = null;
//line 583
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__9 = ptd_system_NL.NL_is_accepted(___nl__7,___nl__10,___ref______nl__1,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 583
___nl__10 = null;
//line 583
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 583
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_67;}}
//line 584
___nl__11 = ((ImmHash)___nl__7).getHashValue()["type"].clone();
//line 584
___nl__12 = new ImmString("tct_var").clone();
//line 584
___nl__10 = ov_NL.NL_is(___nl__11,___nl__12).clone();

//line 584
___nl__12 = null;
//line 584
___nl__11 = null;
//line 584
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 584
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 584
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_69;}}
//line 584
___nl__0 = null;
//line 584
___nl__4 = null;
//line 584
___nl__5 = null;
//line 584
___nl__6 = null;
//line 584
___nl__7 = null;
//line 584
___nl__9 = null;
//line 584
___nl__10 = null;
//line 584
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__8;
//line 584
if (true) {goto label_69;}
//line 584
label_69:
//line 584
___nl__10 = null;
//line 585
___nl__10 = ((ImmHash)___nl__7).getHashValue()["type"].clone();
//line 585
___nl__10 = c_rt_lib_NL.NL_ov_as(___nl__10, new ImmString("tct_var")).clone();
//line 586
___nl__12 = ((ImmHash)___nl__6).getHashValue()["case"].clone();
//line 586
___nl__11 = hash_NL.NL_has_key(___nl__10,___nl__12).clone();

//line 586
___nl__12 = null;
//line 586
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 586
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 586
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_71;}}
//line 587
___nl__12 = new ImmString("case ").clone();
//line 587
___nl__13 = ((ImmHash)___nl__6).getHashValue()["case"].clone();
//line 587
___nl__12 = new ImmString(___nl__12.toString() + ___nl__13.toString()).clone();
//line 587
___nl__13 = null;
//line 587
___nl__13 = new ImmString(" don't exists is: ").clone();
//line 587
___nl__12 = new ImmString(___nl__12.toString() + ___nl__13.toString()).clone();
//line 587
___nl__13 = null;
//line 587
___nl__14 = ((ImmHash)___nl__7).getHashValue()["type"].clone();
//line 587
___nl__13 = type_checker_NL.NL_get_print_tct_type_name_priv(___nl__14).clone();

//line 587
___nl__14 = null;
//line 587
___nl__12 = new ImmString(___nl__12.toString() + ___nl__13.toString()).clone();
//line 587
___nl__13 = null;
//line 587
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__12);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 587
___nl__12 = null;
//line 588
___nl__0 = null;
//line 588
___nl__4 = null;
//line 588
___nl__5 = null;
//line 588
___nl__6 = null;
//line 588
___nl__7 = null;
//line 588
___nl__9 = null;
//line 588
___nl__10 = null;
//line 588
___nl__11 = null;
//line 588
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__8;
//line 589
if (true) {goto label_71;}
//line 589
label_71:
//line 589
___nl__11 = null;
//line 590
___nl__11 = ((ImmHash)___nl__6).getHashValue()["op"].clone();
//line 590
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("ov_is")).clone();
//line 590
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_73;}}
//line 591
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("ov_as")).clone();
//line 591
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_74;}}
//line 591
___nl__12 = new ImmString("NOMATCHALERT").clone();
//line 591
___nl__12 = new ImmArray(new Imm[] {___nl__12,___nl__11,}).clone();
//line 591
c_rt_lib_NL.NL_die();
//line 590
label_73:
//line 591
if (true) {goto label_72;}
//line 591
label_74:
//line 592
___nl__14 = ((ImmHash)___nl__6).getHashValue()["case"].clone();
//line 592
___nl__13 = hash_NL.NL_get_value(___nl__10,___nl__14).clone();

//line 592
___nl__14 = null;
//line 593
___nl__14 = c_rt_lib_NL.NL_ov_is(___nl__13, new ImmString("with_param")).clone();
//line 593
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_76;}}
//line 595
___nl__14 = c_rt_lib_NL.NL_ov_is(___nl__13, new ImmString("no_param")).clone();
//line 595
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_77;}}
//line 595
___nl__14 = new ImmString("NOMATCHALERT").clone();
//line 595
___nl__14 = new ImmArray(new Imm[] {___nl__14,___nl__13,}).clone();
//line 595
c_rt_lib_NL.NL_die();
//line 593
label_76:
//line 593
___nl__15 = c_rt_lib_NL.NL_ov_as(___nl__13, new ImmString("with_param")).clone();
//line 594
___nl__16 = ___nl__15.clone();
//line 594
((ImmHash)___nl__8).set("type", ___nl__16);
//line 594
___nl__16 = null;
//line 594
___nl__15 = null;
//line 595
if (true) {goto label_75;}
//line 595
label_77:
//line 596
___nl__15 = new ImmString("case ").clone();
//line 596
___nl__16 = ((ImmHash)___nl__6).getHashValue()["case"].clone();
//line 596
___nl__15 = new ImmString(___nl__15.toString() + ___nl__16.toString()).clone();
//line 596
___nl__16 = null;
//line 596
___nl__16 = new ImmString(" don't have value: ").clone();
//line 596
___nl__15 = new ImmString(___nl__15.toString() + ___nl__16.toString()).clone();
//line 596
___nl__16 = null;
//line 596
___nl__17 = ((ImmHash)___nl__7).getHashValue()["type"].clone();
//line 596
___nl__16 = type_checker_NL.NL_get_print_tct_type_name_priv(___nl__17).clone();

//line 596
___nl__17 = null;
//line 596
___nl__15 = new ImmString(___nl__15.toString() + ___nl__16.toString()).clone();
//line 596
___nl__16 = null;
//line 596
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__15);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 596
___nl__15 = null;
//line 597
if (true) {goto label_75;}
//line 597
label_75:
//line 597
___nl__14 = null;
//line 597
___nl__13 = null;
//line 598
if (true) {goto label_72;}
//line 598
label_72:
//line 598
___nl__11 = null;
//line 598
___nl__12 = null;
//line 599
___nl__0 = null;
//line 599
___nl__4 = null;
//line 599
___nl__5 = null;
//line 599
___nl__6 = null;
//line 599
___nl__7 = null;
//line 599
___nl__9 = null;
//line 599
___nl__10 = null;
//line 599
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__8;
//line 599
___nl__10 = null;
//line 600
if (true) {goto label_66;}
//line 600
label_67:
//line 601
___nl__10 = new ImmString("binary operator 'as/is' can be applied only to variant: ").clone();
//line 601
___nl__12 = ((ImmHash)___nl__7).getHashValue()["type"].clone();
//line 601
___nl__11 = type_checker_NL.NL_get_print_tct_type_name_priv(___nl__12).clone();

//line 601
___nl__12 = null;
//line 601
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString()).clone();
//line 601
___nl__11 = null;
//line 601
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__10);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 601
___nl__10 = null;
//line 603
___nl__0 = null;
//line 603
___nl__4 = null;
//line 603
___nl__5 = null;
//line 603
___nl__6 = null;
//line 603
___nl__7 = null;
//line 603
___nl__9 = null;
//line 603
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__8;
//line 604
if (true) {goto label_66;}
//line 604
label_66:
//line 604
___nl__9 = null;
//line 604
___nl__7 = null;
//line 604
___nl__8 = null;
//line 604
___nl__6 = null;
//line 605
if (true) {goto label_1;}
//line 605
label_13:
//line 605
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("unary_op")).clone();
//line 606
___nl__8 = ((ImmHash)___nl__6).getHashValue()["val"].clone();
//line 606
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__7 = type_checker_NL.NL_check_val_priv(___nl__8,___ref______nl__1,___ref______nl__2,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 606
___nl__8 = null;
//line 607
___nl__8 = ((ImmHash)___nl__6).getHashValue()["op"].clone();
//line 607
___nl__9 = new ImmString("!").clone();
//line 607
___nl__8 = c_rt_lib_NL.NL_native_to_nl(___nl__8.toString().Equals(___nl__9.toString())).clone();
//line 607
___nl__9 = null;
//line 607
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 607
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_79;}}
//line 608
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__9 = ptd_system_NL.NL_is_condition_type(___nl__7,___ref______nl__1,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 608
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 608
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 608
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_81;}}
//line 609
___nl__10 = new ImmString("incorrect type of argument operator '!' : ").clone();
//line 609
___nl__12 = ((ImmHash)___nl__7).getHashValue()["type"].clone();
//line 609
___nl__11 = type_checker_NL.NL_get_print_tct_type_name_priv(___nl__12).clone();

//line 609
___nl__12 = null;
//line 609
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString()).clone();
//line 609
___nl__11 = null;
//line 609
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__10);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 609
___nl__10 = null;
//line 610
if (true) {goto label_81;}
//line 610
label_81:
//line 610
___nl__9 = null;
//line 611
___nl__9 = tct_NL.NL_tct_bool().clone();

//line 611
___nl__10 = ___nl__9.clone();
//line 611
((ImmHash)___nl__4).set("type", ___nl__10);
//line 611
___nl__9 = null;
//line 611
___nl__10 = null;
//line 612
___nl__0 = null;
//line 612
___nl__5 = null;
//line 612
___nl__6 = null;
//line 612
___nl__7 = null;
//line 612
___nl__8 = null;
//line 612
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__4;
//line 613
if (true) {goto label_78;}
//line 613
label_79:
//line 613
___nl__8 = ((ImmHash)___nl__6).getHashValue()["op"].clone();
//line 613
___nl__9 = new ImmString("@").clone();
//line 613
___nl__8 = c_rt_lib_NL.NL_native_to_nl(___nl__8.toString().Equals(___nl__9.toString())).clone();
//line 613
___nl__9 = null;
//line 613
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 613
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_82;}}
//line 614
___nl__10 = tct_NL.NL_tct_sim().clone();

//line 614
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__9 = ptd_system_NL.NL_is_accepted(___nl__7,___nl__10,___ref______nl__1,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 614
___nl__10 = null;
//line 614
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 614
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 614
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_84;}}
//line 615
___nl__10 = new ImmString("incorrect type of argument operator '").clone();
//line 615
___nl__11 = ((ImmHash)___nl__6).getHashValue()["op"].clone();
//line 615
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString()).clone();
//line 615
___nl__11 = null;
//line 615
___nl__11 = new ImmString("' : ").clone();
//line 615
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString()).clone();
//line 615
___nl__11 = null;
//line 615
___nl__12 = ((ImmHash)___nl__7).getHashValue()["type"].clone();
//line 615
___nl__11 = type_checker_NL.NL_get_print_tct_type_name_priv(___nl__12).clone();

//line 615
___nl__12 = null;
//line 615
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString()).clone();
//line 615
___nl__11 = null;
//line 615
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__10);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 615
___nl__10 = null;
//line 616
if (true) {goto label_84;}
//line 616
label_84:
//line 616
___nl__9 = null;
//line 617
___nl__11 = tct_NL.NL_tct_sim().clone();

//line 617
__function_map = new Dictionary<String, Imm>();
__function_map.Add("ref",___nl__11);
___nl__10 = new ImmHash(__function_map).clone();
//line 617
___nl__11 = null;
//line 617
___nl__9 = tct_NL.NL_tct_var(___nl__10).clone();

//line 617
___nl__10 = null;
//line 617
___nl__10 = ___nl__9.clone();
//line 617
((ImmHash)___nl__4).set("type", ___nl__10);
//line 617
___nl__9 = null;
//line 617
___nl__10 = null;
//line 618
___nl__0 = null;
//line 618
___nl__5 = null;
//line 618
___nl__6 = null;
//line 618
___nl__7 = null;
//line 618
___nl__8 = null;
//line 618
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__4;
//line 619
if (true) {goto label_78;}
//line 619
label_82:
//line 620
___nl__10 = tct_NL.NL_tct_sim().clone();

//line 620
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__9 = ptd_system_NL.NL_is_accepted(___nl__7,___nl__10,___ref______nl__1,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 620
___nl__10 = null;
//line 620
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 620
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 620
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_86;}}
//line 621
___nl__10 = new ImmString("incorrect type of argument operator '").clone();
//line 621
___nl__11 = ((ImmHash)___nl__6).getHashValue()["op"].clone();
//line 621
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString()).clone();
//line 621
___nl__11 = null;
//line 621
___nl__11 = new ImmString("' : ").clone();
//line 621
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString()).clone();
//line 621
___nl__11 = null;
//line 621
___nl__12 = ((ImmHash)___nl__7).getHashValue()["type"].clone();
//line 621
___nl__11 = type_checker_NL.NL_get_print_tct_type_name_priv(___nl__12).clone();

//line 621
___nl__12 = null;
//line 621
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString()).clone();
//line 621
___nl__11 = null;
//line 621
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__10);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 621
___nl__10 = null;
//line 622
if (true) {goto label_86;}
//line 622
label_86:
//line 622
___nl__9 = null;
//line 623
if (true) {goto label_78;}
//line 623
label_78:
//line 623
___nl__8 = null;
//line 624
___nl__8 = tct_NL.NL_tct_sim().clone();

//line 624
___nl__9 = ___nl__8.clone();
//line 624
((ImmHash)___nl__4).set("type", ___nl__9);
//line 624
___nl__8 = null;
//line 624
___nl__9 = null;
//line 624
___nl__7 = null;
//line 624
___nl__6 = null;
//line 625
if (true) {goto label_1;}
//line 625
label_14:
//line 625
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("fun_label")).clone();
//line 626
___nl__7 = ((ImmHash)___nl__6).getHashValue()["module"].clone();
//line 626
___nl__8 = ((ImmHash)___nl__6).getHashValue()["name"].clone();
//line 626
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_check_function_exists_priv(___nl__7,___nl__8,___ref______nl__1,___ref______nl__3);
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 626
___nl__8 = null;
//line 626
___nl__7 = null;
//line 627
___nl__7 = tct_NL.NL_tct_sim().clone();

//line 627
___nl__8 = ___nl__7.clone();
//line 627
((ImmHash)___nl__4).set("type", ___nl__8);
//line 627
___nl__7 = null;
//line 627
___nl__8 = null;
//line 627
___nl__6 = null;
//line 628
if (true) {goto label_1;}
//line 628
label_15:
//line 628
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("fun_val")).clone();
//line 629
___nl__7 = new ImmArray(new Imm[0]).clone();
//line 630
___nl__8 = ((ImmHash)___nl__6).getHashValue()["args"].clone();
//line 630
___nl__10 = new ImmDouble(0).clone();
//line 630
___nl__11 = new ImmDouble(1).clone();
//line 630
___nl__12 = c_rt_lib_NL.NL_array_len(___nl__8).clone();

//line 630
label_89:
//line 630
___nl__13 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__10.getValue().ToString()))>=(Double.Parse(___nl__12.getValue().ToString())) ).clone();
//line 630
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_87;}}
//line 630
___nl__9 = (___nl__8 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()].clone();
//line 631
___nl__15 = ((ImmHash)___nl__9).getHashValue()["val"].clone();
//line 631
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__14 = type_checker_NL.NL_check_val_priv(___nl__15,___ref______nl__1,___ref______nl__2,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 631
___nl__15 = null;
//line 631
___ref______nl__7 = new ImmRef(___nl__7);
array_NL.NL_push(___ref______nl__7,___nl__14);
___nl__7 = ___ref______nl__7.getValue().clone();

//line 631
___nl__14 = null;
//line 632
___nl__10 = new ImmDouble((Double.Parse(___nl__10.getValue().ToString()))+(Double.Parse(___nl__11.getValue().ToString()))).clone();
//line 632
if (true) {goto label_89;}
//line 632
label_87:
//line 632
___nl__8 = null;
//line 632
___nl__9 = null;
//line 632
___nl__10 = null;
//line 632
___nl__11 = null;
//line 632
___nl__12 = null;
//line 632
___nl__13 = null;
//line 633
___nl__9 = ((ImmHash)___nl__6).getHashValue()["module"].clone();
//line 633
___nl__10 = ((ImmHash)___nl__6).getHashValue()["name"].clone();
//line 633
___nl__8 = type_checker_NL.NL_get_special_function_def_priv(___nl__9,___nl__10).clone();

//line 633
___nl__10 = null;
//line 633
___nl__9 = null;
//line 634
___nl__9 = c_rt_lib_NL.NL_get_false().clone();
//line 635
___nl__10 = ((ImmHash)___nl__8).getHashValue()["access"].clone();
//line 635
___nl__11 = c_rt_lib_NL.NL_ov_is(___nl__10, new ImmString("pub")).clone();
//line 635
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_91;}}
//line 641
___nl__11 = c_rt_lib_NL.NL_ov_is(___nl__10, new ImmString("priv")).clone();
//line 641
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_92;}}
//line 641
___nl__11 = new ImmString("NOMATCHALERT").clone();
//line 641
___nl__11 = new ImmArray(new Imm[] {___nl__11,___nl__10,}).clone();
//line 641
c_rt_lib_NL.NL_die();
//line 635
label_91:
//line 636
___nl__12 = c_rt_lib_NL.NL_get_true().clone();
//line 636
___nl__9 = ___nl__12.clone();
//line 636
___nl__12 = null;
//line 637
___nl__13 = ((ImmHash)___nl__1).getHashValue()["imports"].clone();
//line 637
___nl__14 = ((ImmHash)___nl__6).getHashValue()["module"].clone();
//line 637
___nl__12 = hash_NL.NL_has_key(___nl__13,___nl__14).clone();

//line 637
___nl__14 = null;
//line 637
___nl__13 = null;
//line 637
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 637
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 637
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_94;}}
//line 638
___nl__13 = new ImmString("module '").clone();
//line 638
___nl__14 = ((ImmHash)___nl__6).getHashValue()["module"].clone();
//line 638
___nl__13 = new ImmString(___nl__13.toString() + ___nl__14.toString()).clone();
//line 638
___nl__14 = null;
//line 638
___nl__14 = new ImmString("' not imported").clone();
//line 638
___nl__13 = new ImmString(___nl__13.toString() + ___nl__14.toString()).clone();
//line 638
___nl__14 = null;
//line 638
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__13);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 638
___nl__13 = null;
//line 639
___nl__13 = new ImmString("imports").clone();
//line 639
___nl__13 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__13).clone();

//line 639
___nl__14 = ((ImmHash)___nl__6).getHashValue()["module"].clone();
//line 639
___nl__15 = c_rt_lib_NL.NL_get_false().clone();
//line 639
___ref______nl__13 = new ImmRef(___nl__13);
hash_NL.NL_set_value(___ref______nl__13,___nl__14,___nl__15);
___nl__13 = ___ref______nl__13.getValue().clone();

//line 639
___nl__15 = null;
//line 639
___nl__14 = null;
//line 639
___nl__14 = new ImmString("imports").clone();
//line 639
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__14,___nl__13);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 639
___nl__14 = null;
//line 639
___nl__13 = null;
//line 640
if (true) {goto label_94;}
//line 640
label_94:
//line 640
___nl__12 = null;
//line 641
if (true) {goto label_90;}
//line 641
label_92:
//line 642
___nl__13 = ((ImmHash)___nl__6).getHashValue()["module"].clone();
//line 642
___nl__14 = ((ImmHash)___nl__6).getHashValue()["name"].clone();
//line 642
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__12 = type_checker_NL.NL_check_function_exists_priv(___nl__13,___nl__14,___ref______nl__1,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 642
___nl__14 = null;
//line 642
___nl__13 = null;
//line 642
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 642
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 642
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_96;}}
//line 642
___nl__0 = null;
//line 642
___nl__5 = null;
//line 642
___nl__6 = null;
//line 642
___nl__7 = null;
//line 642
___nl__8 = null;
//line 642
___nl__9 = null;
//line 642
___nl__10 = null;
//line 642
___nl__11 = null;
//line 642
___nl__12 = null;
//line 642
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__4;
//line 642
if (true) {goto label_96;}
//line 642
label_96:
//line 642
___nl__12 = null;
//line 643
___nl__13 = ((ImmHash)___nl__6).getHashValue()["module"].clone();
//line 643
___nl__14 = ((ImmHash)___nl__6).getHashValue()["name"].clone();
//line 643
___nl__12 = type_checker_NL.NL_get_function_def_priv(___nl__13,___nl__14,___nl__1).clone();

//line 643
___nl__14 = null;
//line 643
___nl__13 = null;
//line 643
___nl__8 = ___nl__12.clone();
//line 643
___nl__12 = null;
//line 644
if (true) {goto label_90;}
//line 644
label_90:
//line 644
___nl__10 = null;
//line 644
___nl__11 = null;
//line 645
___nl__11 = ((ImmHash)___nl__6).getHashValue()["args"].clone();
//line 645
___nl__10 = array_NL.NL_len(___nl__11).clone();

//line 645
___nl__11 = null;
//line 645
___nl__12 = ((ImmHash)___nl__8).getHashValue()["args"].clone();
//line 645
___nl__11 = array_NL.NL_len(___nl__12).clone();

//line 645
___nl__12 = null;
//line 645
___nl__10 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__10.getValue().ToString())) !=((Double.Parse(___nl__11.getValue().ToString())))  ).clone();
//line 645
___nl__11 = null;
//line 645
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 645
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_98;}}
//line 646
___nl__11 = new ImmString("wrong number ").clone();
//line 646
___nl__13 = ((ImmHash)___nl__6).getHashValue()["args"].clone();
//line 646
___nl__12 = array_NL.NL_len(___nl__13).clone();

//line 646
___nl__13 = null;
//line 646
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString()).clone();
//line 646
___nl__12 = null;
//line 646
___nl__12 = new ImmString(" of function arguments : ").clone();
//line 646
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString()).clone();
//line 646
___nl__12 = null;
//line 646
___nl__13 = ((ImmHash)___nl__6).getHashValue()["module"].clone();
//line 646
___nl__14 = ((ImmHash)___nl__6).getHashValue()["name"].clone();
//line 646
___nl__12 = type_checker_NL.NL_get_function_name_priv(___nl__13,___nl__14).clone();

//line 646
___nl__14 = null;
//line 646
___nl__13 = null;
//line 646
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString()).clone();
//line 646
___nl__12 = null;
//line 646
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__11);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 646
___nl__11 = null;
//line 648
___nl__0 = null;
//line 648
___nl__5 = null;
//line 648
___nl__6 = null;
//line 648
___nl__7 = null;
//line 648
___nl__8 = null;
//line 648
___nl__9 = null;
//line 648
___nl__10 = null;
//line 648
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__4;
//line 649
if (true) {goto label_98;}
//line 649
label_98:
//line 649
___nl__10 = null;
//line 650
__function_map = new Dictionary<String, Imm>();
___nl__10 = new ImmHash(__function_map).clone();
//line 651
___nl__12 = ((ImmHash)___nl__6).getHashValue()["args"].clone();
//line 651
___nl__11 = array_NL.NL_len(___nl__12).clone();

//line 651
___nl__12 = null;
//line 651
___nl__12 = new ImmDouble(0).clone();
//line 651
___nl__13 = new ImmDouble(1).clone();
//line 651
label_101:
//line 651
___nl__14 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__12.getValue().ToString()))>=(Double.Parse(___nl__11.getValue().ToString())) ).clone();
//line 651
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_99;}}
//line 652
___nl__15 = ((ImmHash)___nl__6).getHashValue()["args"].clone();
//line 652
___nl__15 = (___nl__15 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__12).getDoubleValue()].clone();
//line 653
___nl__16 = ((ImmHash)___nl__8).getHashValue()["args"].clone();
//line 653
___nl__16 = (___nl__16 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__12).getDoubleValue()].clone();
//line 654
___nl__18 = ((ImmHash)___nl__16).getHashValue()["mod"].clone();
//line 654
___nl__19 = ((ImmHash)___nl__15).getHashValue()["mod"].clone();
//line 654
___nl__17 = enum_NL.NL_eq(___nl__18,___nl__19).clone();

//line 654
___nl__19 = null;
//line 654
___nl__18 = null;
//line 654
if (c_rt_lib_NL.NL_check_true_native(___nl__17)) {if (true) {goto label_104;}}
//line 654
___nl__19 = ((ImmHash)___nl__16).getHashValue()["mod"].clone();
//line 654
___nl__20 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("fun")).clone();
//line 654
___nl__17 = enum_NL.NL_eq(___nl__19,___nl__20).clone();

//line 654
___nl__20 = null;
//line 654
___nl__19 = null;
//line 654
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__17)).clone();
//line 654
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_105;}}
//line 654
___nl__19 = ((ImmHash)___nl__15).getHashValue()["mod"].clone();
//line 654
___nl__20 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 654
___nl__17 = enum_NL.NL_eq(___nl__19,___nl__20).clone();

//line 654
___nl__20 = null;
//line 654
___nl__19 = null;
//line 654
label_105:
//line 654
___nl__18 = null;
//line 654
label_104:
//line 654
___nl__17 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__17)).clone();
//line 654
___nl__17 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__17)).clone();
//line 654
if (c_rt_lib_NL.NL_check_true_native(___nl__17)) {if (true) {goto label_103;}}
//line 654
___nl__18 = new ImmString("arg no. ").clone();
//line 654
___nl__19 = new ImmDouble(1).clone();
//line 654
___nl__19 = new ImmDouble((Double.Parse(___nl__12.getValue().ToString()))+(Double.Parse(___nl__19.getValue().ToString()))).clone();
//line 654
___nl__18 = new ImmString(___nl__18.toString() + ___nl__19.toString()).clone();
//line 654
___nl__19 = null;
//line 654
___nl__19 = new ImmString(" '").clone();
//line 654
___nl__18 = new ImmString(___nl__18.toString() + ___nl__19.toString()).clone();
//line 654
___nl__19 = null;
//line 654
___nl__19 = ((ImmHash)___nl__16).getHashValue()["name"].clone();
//line 654
___nl__18 = new ImmString(___nl__18.toString() + ___nl__19.toString()).clone();
//line 654
___nl__19 = null;
//line 654
___nl__19 = new ImmString("' ref mismatched with function prototype").clone();
//line 654
___nl__18 = new ImmString(___nl__18.toString() + ___nl__19.toString()).clone();
//line 654
___nl__19 = null;
//line 654
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__18);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 654
___nl__18 = null;
//line 654
if (true) {goto label_103;}
//line 654
label_103:
//line 654
___nl__17 = null;
//line 660
___nl__18 = ___nl__9.clone();
//line 660
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 660
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_107;}}
//line 661
___nl__19 = (___nl__7 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__12).getDoubleValue()].clone();
//line 662
___nl__20 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("speculation")).clone();
//line 662
___nl__21 = ___nl__20.clone();
//line 662
((ImmHash)___nl__19).set("src", ___nl__21);
//line 662
___nl__20 = null;
//line 662
___nl__21 = null;
//line 663
___nl__21 = ((ImmHash)___nl__16).getHashValue()["type"].clone();
//line 663
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__20 = ptd_system_NL.NL_is_accepted_info(___nl__19,___nl__21,___ref______nl__1,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 663
___nl__21 = null;
//line 663
___nl__17 = ___nl__20.clone();
//line 663
___nl__20 = null;
//line 663
___nl__19 = null;
//line 664
if (true) {goto label_106;}
//line 664
label_107:
//line 665
___nl__20 = ((ImmHash)___nl__16).getHashValue()["mod"].clone();
//line 665
___nl__21 = new ImmString("ref").clone();
//line 665
___nl__19 = ov_NL.NL_is(___nl__20,___nl__21).clone();

//line 665
___nl__21 = null;
//line 665
___nl__20 = null;
//line 665
___nl__19 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__19)).clone();
//line 665
if (c_rt_lib_NL.NL_check_true_native(___nl__19)) {if (true) {goto label_109;}}
//line 666
___nl__21 = ((ImmHash)___nl__3).getHashValue()["errors"].clone();
//line 666
___nl__20 = array_NL.NL_len(___nl__21).clone();

//line 666
___nl__21 = null;
//line 667
___nl__22 = ((ImmHash)___nl__15).getHashValue()["val"].clone();
//line 667
___ref______nl__3 = new ImmRef(___nl__3);
___nl__21 = type_checker_NL.NL_rec_get_var_from_lval_priv(___nl__22,___ref______nl__3).clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 667
___nl__22 = null;
//line 668
___nl__23 = ((ImmHash)___nl__3).getHashValue()["errors"].clone();
//line 668
___nl__22 = array_NL.NL_len(___nl__23).clone();

//line 668
___nl__23 = null;
//line 668
___nl__22 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__20.getValue().ToString())) ==((Double.Parse(___nl__22.getValue().ToString())))  ).clone();
//line 668
___nl__22 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__22)).clone();
//line 668
if (c_rt_lib_NL.NL_check_true_native(___nl__22)) {if (true) {goto label_111;}}
//line 669
___nl__25 = new ImmDouble(0).clone();
//line 669
___nl__24 = (___nl__21 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__25).getDoubleValue()].clone();
//line 669
___nl__25 = null;
//line 669
___nl__25 = new ImmString("var").clone();
//line 669
___nl__23 = ov_NL.NL_as(___nl__24,___nl__25).clone();

//line 669
___nl__25 = null;
//line 669
___nl__24 = null;
//line 670
___nl__24 = hash_NL.NL_has_key(___nl__10,___nl__23).clone();

//line 670
___nl__24 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__24)).clone();
//line 670
if (c_rt_lib_NL.NL_check_true_native(___nl__24)) {if (true) {goto label_113;}}
//line 671
___nl__25 = new ImmString("many ref-arguments come from the same variable: ").clone();
//line 671
___nl__25 = new ImmString(___nl__25.toString() + ___nl__23.toString()).clone();
//line 671
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_warning_priv(___ref______nl__3,___nl__25);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 671
___nl__25 = null;
//line 672
if (true) {goto label_113;}
//line 672
label_113:
//line 672
___nl__24 = null;
//line 673
___nl__24 = new ImmDouble(0).clone();
//line 673
___ref______nl__10 = new ImmRef(___nl__10);
hash_NL.NL_set_value(___ref______nl__10,___nl__23,___nl__24);
___nl__10 = ___ref______nl__10.getValue().clone();

//line 673
___nl__24 = null;
//line 674
___nl__24 = ((ImmHash)___nl__15).getHashValue()["val"].clone();
//line 674
___nl__25 = (___nl__7 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__12).getDoubleValue()].clone();
//line 674
___nl__26 = (___nl__7 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__12).getDoubleValue()].clone();
//line 674
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_set_type_to_lval_priv(___nl__24,___nl__25,___nl__26,___ref______nl__1,___ref______nl__2,___ref______nl__3);
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 674
___nl__26 = null;
//line 674
___nl__25 = null;
//line 674
___nl__24 = null;
//line 674
___nl__23 = null;
//line 675
if (true) {goto label_111;}
//line 675
label_111:
//line 675
___nl__22 = null;
//line 675
___nl__20 = null;
//line 675
___nl__21 = null;
//line 676
if (true) {goto label_109;}
//line 676
label_109:
//line 676
___nl__19 = null;
//line 677
___nl__20 = ((ImmHash)___nl__16).getHashValue()["type"].clone();
//line 677
___nl__21 = (___nl__7 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__12).getDoubleValue()].clone();
//line 677
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__19 = ptd_system_NL.NL_check_assignment(___nl__20,___nl__21,___ref______nl__1,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 677
___nl__21 = null;
//line 677
___nl__20 = null;
//line 677
___nl__17 = ___nl__19.clone();
//line 677
___nl__19 = null;
//line 678
if (true) {goto label_106;}
//line 678
label_106:
//line 678
___nl__18 = null;
//line 679
___nl__19 = new ImmString("err").clone();
//line 679
___nl__18 = ov_NL.NL_is(___nl__17,___nl__19).clone();

//line 679
___nl__19 = null;
//line 679
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 679
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_115;}}
//line 680
___nl__19 = new ImmString("In function call: ").clone();
//line 680
___nl__21 = ((ImmHash)___nl__6).getHashValue()["module"].clone();
//line 680
___nl__22 = ((ImmHash)___nl__6).getHashValue()["name"].clone();
//line 680
___nl__20 = type_checker_NL.NL_get_function_name_priv(___nl__21,___nl__22).clone();

//line 680
___nl__22 = null;
//line 680
___nl__21 = null;
//line 680
___nl__19 = new ImmString(___nl__19.toString() + ___nl__20.toString()).clone();
//line 680
___nl__20 = null;
//line 680
___nl__20 = new ImmString(" argument no.").clone();
//line 680
___nl__19 = new ImmString(___nl__19.toString() + ___nl__20.toString()).clone();
//line 680
___nl__20 = null;
//line 680
___nl__20 = new ImmDouble(1).clone();
//line 680
___nl__20 = new ImmDouble((Double.Parse(___nl__12.getValue().ToString()))+(Double.Parse(___nl__20.getValue().ToString()))).clone();
//line 680
___nl__19 = new ImmString(___nl__19.toString() + ___nl__20.toString()).clone();
//line 680
___nl__20 = null;
//line 680
___nl__20 = new ImmString(" '").clone();
//line 680
___nl__19 = new ImmString(___nl__19.toString() + ___nl__20.toString()).clone();
//line 680
___nl__20 = null;
//line 680
___nl__20 = ((ImmHash)___nl__16).getHashValue()["name"].clone();
//line 680
___nl__19 = new ImmString(___nl__19.toString() + ___nl__20.toString()).clone();
//line 680
___nl__20 = null;
//line 680
___nl__20 = new ImmString("' has invalid type: ").clone();
//line 680
___nl__19 = new ImmString(___nl__19.toString() + ___nl__20.toString()).clone();
//line 680
___nl__20 = null;
//line 680
___nl__20 = type_checker_NL.NL_get_print_check_info_priv(___nl__17).clone();

//line 680
___nl__19 = new ImmString(___nl__19.toString() + ___nl__20.toString()).clone();
//line 680
___nl__20 = null;
//line 680
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__19);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 680
___nl__19 = null;
//line 682
if (true) {goto label_115;}
//line 682
label_115:
//line 682
___nl__18 = null;
//line 682
___nl__15 = null;
//line 682
___nl__16 = null;
//line 682
___nl__17 = null;
//line 683
___nl__12 = new ImmDouble((Double.Parse(___nl__12.getValue().ToString()))+(Double.Parse(___nl__13.getValue().ToString()))).clone();
//line 683
if (true) {goto label_101;}
//line 683
label_99:
//line 683
___nl__11 = null;
//line 683
___nl__12 = null;
//line 683
___nl__13 = null;
//line 683
___nl__14 = null;
//line 684
___nl__13 = ((ImmHash)___nl__8).getHashValue()["ret_type"].clone();
//line 684
___nl__14 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("known")).clone();
//line 684
__function_map = new Dictionary<String, Imm>();
__function_map.Add("type",___nl__13);
__function_map.Add("src",___nl__14);
___nl__12 = new ImmHash(__function_map).clone();
//line 684
___nl__13 = null;
//line 684
___nl__14 = null;
//line 684
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__11 = type_checker_NL.NL_check_special_function_priv(___nl__12,___nl__6,___nl__7,___ref______nl__1,___ref______nl__2,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 684
___nl__12 = null;
//line 684
___nl__4 = ___nl__11.clone();
//line 684
___nl__11 = null;
//line 684
___nl__7 = null;
//line 684
___nl__8 = null;
//line 684
___nl__9 = null;
//line 684
___nl__10 = null;
//line 684
___nl__6 = null;
//line 685
if (true) {goto label_1;}
//line 685
label_16:
//line 685
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("string")).clone();
//line 686
___nl__7 = tct_NL.NL_tct_sim().clone();

//line 686
___nl__8 = ___nl__7.clone();
//line 686
((ImmHash)___nl__4).set("type", ___nl__8);
//line 686
___nl__7 = null;
//line 686
___nl__8 = null;
//line 686
___nl__6 = null;
//line 687
if (true) {goto label_1;}
//line 687
label_17:
//line 687
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("post_inc")).clone();
//line 688
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__7 = type_checker_NL.NL_check_val_priv(___nl__6,___ref______nl__1,___ref______nl__2,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 689
___nl__9 = tct_NL.NL_tct_sim().clone();

//line 689
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__8 = ptd_system_NL.NL_is_accepted(___nl__7,___nl__9,___ref______nl__1,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 689
___nl__9 = null;
//line 689
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 689
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 689
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_117;}}
//line 690
___nl__9 = new ImmString("wrong type in post increment : ").clone();
//line 690
___nl__11 = ((ImmHash)___nl__7).getHashValue()["type"].clone();
//line 690
___nl__10 = type_checker_NL.NL_get_print_tct_type_name_priv(___nl__11).clone();

//line 690
___nl__11 = null;
//line 690
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 690
___nl__10 = null;
//line 690
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__9);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 690
___nl__9 = null;
//line 691
if (true) {goto label_117;}
//line 691
label_117:
//line 691
___nl__8 = null;
//line 692
___nl__8 = tct_NL.NL_tct_sim().clone();

//line 692
___nl__9 = ___nl__8.clone();
//line 692
((ImmHash)___nl__4).set("type", ___nl__9);
//line 692
___nl__8 = null;
//line 692
___nl__9 = null;
//line 692
___nl__7 = null;
//line 692
___nl__6 = null;
//line 693
if (true) {goto label_1;}
//line 693
label_18:
//line 693
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("post_dec")).clone();
//line 694
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__7 = type_checker_NL.NL_check_val_priv(___nl__6,___ref______nl__1,___ref______nl__2,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 695
___nl__9 = tct_NL.NL_tct_sim().clone();

//line 695
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__8 = ptd_system_NL.NL_is_accepted(___nl__7,___nl__9,___ref______nl__1,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 695
___nl__9 = null;
//line 695
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 695
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 695
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_119;}}
//line 696
___nl__9 = new ImmString("wrong type in post decrement : ").clone();
//line 696
___nl__11 = ((ImmHash)___nl__7).getHashValue()["type"].clone();
//line 696
___nl__10 = type_checker_NL.NL_get_print_tct_type_name_priv(___nl__11).clone();

//line 696
___nl__11 = null;
//line 696
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 696
___nl__10 = null;
//line 696
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__9);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 696
___nl__9 = null;
//line 697
if (true) {goto label_119;}
//line 697
label_119:
//line 697
___nl__8 = null;
//line 698
___nl__8 = tct_NL.NL_tct_sim().clone();

//line 698
___nl__9 = ___nl__8.clone();
//line 698
((ImmHash)___nl__4).set("type", ___nl__9);
//line 698
___nl__8 = null;
//line 698
___nl__9 = null;
//line 698
___nl__7 = null;
//line 698
___nl__6 = null;
//line 699
if (true) {goto label_1;}
//line 699
label_1:
//line 699
___nl__5 = null;
//line 700
___nl__0 = null;
//line 700
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__4;
//line 700
___nl__4 = null;
//line 700
___nl__0 = null;
//line 700
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return null;
}

private static Imm NL_SINGLETON_get_special_functions_priv() {

Imm ___nl__0 = null;
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
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
ImmRef ___ref______nl__6 = null;
ImmRef ___ref______nl__7 = null;
ImmRef ___ref______nl__8 = null;
ImmRef ___ref______nl__9 = null;
ImmRef ___ref______nl__10 = null;
Dictionary<String, Imm> __function_map;
//line 704
__function_map = new Dictionary<String, Imm>();
___nl__0 = new ImmHash(__function_map).clone();
//line 705
___nl__1 = new ImmString("ptd::ensure").clone();
//line 705
___nl__3 = tct_NL.NL_tct_im().clone();

//line 705
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 705
___nl__7 = tct_NL.NL_tct_im().clone();

//line 705
___nl__8 = new ImmString("").clone();
//line 705
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__6);
__function_map.Add("type",___nl__7);
__function_map.Add("name",___nl__8);
___nl__5 = new ImmHash(__function_map).clone();
//line 705
___nl__6 = null;
//line 705
___nl__7 = null;
//line 705
___nl__8 = null;
//line 705
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 705
___nl__8 = tct_NL.NL_tct_im().clone();

//line 705
___nl__9 = new ImmString("").clone();
//line 705
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__7);
__function_map.Add("type",___nl__8);
__function_map.Add("name",___nl__9);
___nl__6 = new ImmHash(__function_map).clone();
//line 705
___nl__7 = null;
//line 705
___nl__8 = null;
//line 705
___nl__9 = null;
//line 705
___nl__4 = new ImmArray(new Imm[] {___nl__5,___nl__6,}).clone();
//line 705
___nl__5 = null;
//line 705
___nl__6 = null;
//line 705
__function_map = new Dictionary<String, Imm>();
__function_map.Add("r",___nl__3);
__function_map.Add("a",___nl__4);
___nl__2 = new ImmHash(__function_map).clone();
//line 705
___nl__3 = null;
//line 705
___nl__4 = null;
//line 705
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 705
___nl__2 = null;
//line 705
___nl__1 = null;
//line 708
___nl__1 = new ImmString("ptd::ensure_only_static_do_not_touch_without_permission").clone();
//line 708
___nl__3 = tct_NL.NL_tct_im().clone();

//line 708
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 708
___nl__7 = tct_NL.NL_tct_im().clone();

//line 708
___nl__8 = new ImmString("").clone();
//line 708
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__6);
__function_map.Add("type",___nl__7);
__function_map.Add("name",___nl__8);
___nl__5 = new ImmHash(__function_map).clone();
//line 708
___nl__6 = null;
//line 708
___nl__7 = null;
//line 708
___nl__8 = null;
//line 708
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 708
___nl__8 = tct_NL.NL_tct_im().clone();

//line 708
___nl__9 = new ImmString("").clone();
//line 708
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__7);
__function_map.Add("type",___nl__8);
__function_map.Add("name",___nl__9);
___nl__6 = new ImmHash(__function_map).clone();
//line 708
___nl__7 = null;
//line 708
___nl__8 = null;
//line 708
___nl__9 = null;
//line 708
___nl__4 = new ImmArray(new Imm[] {___nl__5,___nl__6,}).clone();
//line 708
___nl__5 = null;
//line 708
___nl__6 = null;
//line 708
__function_map = new Dictionary<String, Imm>();
__function_map.Add("r",___nl__3);
__function_map.Add("a",___nl__4);
___nl__2 = new ImmHash(__function_map).clone();
//line 708
___nl__3 = null;
//line 708
___nl__4 = null;
//line 708
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 708
___nl__2 = null;
//line 708
___nl__1 = null;
//line 712
___nl__1 = new ImmString("array::push").clone();
//line 712
___nl__3 = tct_NL.NL_tct_void().clone();

//line 712
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("ref")).clone();
//line 712
___nl__8 = tct_NL.NL_tct_im().clone();

//line 712
___nl__7 = tct_NL.NL_tct_arr(___nl__8).clone();

//line 712
___nl__8 = null;
//line 712
___nl__8 = new ImmString("").clone();
//line 712
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__6);
__function_map.Add("type",___nl__7);
__function_map.Add("name",___nl__8);
___nl__5 = new ImmHash(__function_map).clone();
//line 712
___nl__6 = null;
//line 712
___nl__7 = null;
//line 712
___nl__8 = null;
//line 712
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 712
___nl__8 = tct_NL.NL_tct_im().clone();

//line 712
___nl__9 = new ImmString("").clone();
//line 712
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__7);
__function_map.Add("type",___nl__8);
__function_map.Add("name",___nl__9);
___nl__6 = new ImmHash(__function_map).clone();
//line 712
___nl__7 = null;
//line 712
___nl__8 = null;
//line 712
___nl__9 = null;
//line 712
___nl__4 = new ImmArray(new Imm[] {___nl__5,___nl__6,}).clone();
//line 712
___nl__5 = null;
//line 712
___nl__6 = null;
//line 712
__function_map = new Dictionary<String, Imm>();
__function_map.Add("r",___nl__3);
__function_map.Add("a",___nl__4);
___nl__2 = new ImmHash(__function_map).clone();
//line 712
___nl__3 = null;
//line 712
___nl__4 = null;
//line 712
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 712
___nl__2 = null;
//line 712
___nl__1 = null;
//line 715
___nl__1 = new ImmString("array::subarray").clone();
//line 715
___nl__3 = tct_NL.NL_tct_im().clone();

//line 715
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 715
___nl__8 = tct_NL.NL_tct_im().clone();

//line 715
___nl__7 = tct_NL.NL_tct_arr(___nl__8).clone();

//line 715
___nl__8 = null;
//line 715
___nl__8 = new ImmString("").clone();
//line 715
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__6);
__function_map.Add("type",___nl__7);
__function_map.Add("name",___nl__8);
___nl__5 = new ImmHash(__function_map).clone();
//line 715
___nl__6 = null;
//line 715
___nl__7 = null;
//line 715
___nl__8 = null;
//line 715
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 715
___nl__8 = tct_NL.NL_tct_sim().clone();

//line 715
___nl__9 = new ImmString("").clone();
//line 715
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__7);
__function_map.Add("type",___nl__8);
__function_map.Add("name",___nl__9);
___nl__6 = new ImmHash(__function_map).clone();
//line 715
___nl__7 = null;
//line 715
___nl__8 = null;
//line 715
___nl__9 = null;
//line 715
___nl__8 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 715
___nl__9 = tct_NL.NL_tct_sim().clone();

//line 715
___nl__10 = new ImmString("").clone();
//line 715
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__8);
__function_map.Add("type",___nl__9);
__function_map.Add("name",___nl__10);
___nl__7 = new ImmHash(__function_map).clone();
//line 715
___nl__8 = null;
//line 715
___nl__9 = null;
//line 715
___nl__10 = null;
//line 715
___nl__4 = new ImmArray(new Imm[] {___nl__5,___nl__6,___nl__7,}).clone();
//line 715
___nl__5 = null;
//line 715
___nl__6 = null;
//line 715
___nl__7 = null;
//line 715
__function_map = new Dictionary<String, Imm>();
__function_map.Add("r",___nl__3);
__function_map.Add("a",___nl__4);
___nl__2 = new ImmHash(__function_map).clone();
//line 715
___nl__3 = null;
//line 715
___nl__4 = null;
//line 715
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 715
___nl__2 = null;
//line 715
___nl__1 = null;
//line 720
___nl__1 = new ImmString("array::join").clone();
//line 720
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 720
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 720
___nl__7 = tct_NL.NL_tct_sim().clone();

//line 720
___nl__8 = new ImmString("").clone();
//line 720
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__6);
__function_map.Add("type",___nl__7);
__function_map.Add("name",___nl__8);
___nl__5 = new ImmHash(__function_map).clone();
//line 720
___nl__6 = null;
//line 720
___nl__7 = null;
//line 720
___nl__8 = null;
//line 720
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 720
___nl__9 = tct_NL.NL_tct_sim().clone();

//line 720
___nl__8 = tct_NL.NL_tct_arr(___nl__9).clone();

//line 720
___nl__9 = null;
//line 720
___nl__9 = new ImmString("").clone();
//line 720
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__7);
__function_map.Add("type",___nl__8);
__function_map.Add("name",___nl__9);
___nl__6 = new ImmHash(__function_map).clone();
//line 720
___nl__7 = null;
//line 720
___nl__8 = null;
//line 720
___nl__9 = null;
//line 720
___nl__4 = new ImmArray(new Imm[] {___nl__5,___nl__6,}).clone();
//line 720
___nl__5 = null;
//line 720
___nl__6 = null;
//line 720
__function_map = new Dictionary<String, Imm>();
__function_map.Add("r",___nl__3);
__function_map.Add("a",___nl__4);
___nl__2 = new ImmHash(__function_map).clone();
//line 720
___nl__3 = null;
//line 720
___nl__4 = null;
//line 720
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 720
___nl__2 = null;
//line 720
___nl__1 = null;
//line 724
___nl__1 = new ImmString("array::append").clone();
//line 724
___nl__3 = tct_NL.NL_tct_void().clone();

//line 724
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("ref")).clone();
//line 724
___nl__8 = tct_NL.NL_tct_im().clone();

//line 724
___nl__7 = tct_NL.NL_tct_arr(___nl__8).clone();

//line 724
___nl__8 = null;
//line 724
___nl__8 = new ImmString("").clone();
//line 724
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__6);
__function_map.Add("type",___nl__7);
__function_map.Add("name",___nl__8);
___nl__5 = new ImmHash(__function_map).clone();
//line 724
___nl__6 = null;
//line 724
___nl__7 = null;
//line 724
___nl__8 = null;
//line 724
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 724
___nl__9 = tct_NL.NL_tct_im().clone();

//line 724
___nl__8 = tct_NL.NL_tct_arr(___nl__9).clone();

//line 724
___nl__9 = null;
//line 724
___nl__9 = new ImmString("").clone();
//line 724
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__7);
__function_map.Add("type",___nl__8);
__function_map.Add("name",___nl__9);
___nl__6 = new ImmHash(__function_map).clone();
//line 724
___nl__7 = null;
//line 724
___nl__8 = null;
//line 724
___nl__9 = null;
//line 724
___nl__4 = new ImmArray(new Imm[] {___nl__5,___nl__6,}).clone();
//line 724
___nl__5 = null;
//line 724
___nl__6 = null;
//line 724
__function_map = new Dictionary<String, Imm>();
__function_map.Add("r",___nl__3);
__function_map.Add("a",___nl__4);
___nl__2 = new ImmHash(__function_map).clone();
//line 724
___nl__3 = null;
//line 724
___nl__4 = null;
//line 724
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 724
___nl__2 = null;
//line 724
___nl__1 = null;
//line 728
___nl__1 = new ImmString("array::len").clone();
//line 728
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 728
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 728
___nl__8 = tct_NL.NL_tct_im().clone();

//line 728
___nl__7 = tct_NL.NL_tct_arr(___nl__8).clone();

//line 728
___nl__8 = null;
//line 728
___nl__8 = new ImmString("").clone();
//line 728
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__6);
__function_map.Add("type",___nl__7);
__function_map.Add("name",___nl__8);
___nl__5 = new ImmHash(__function_map).clone();
//line 728
___nl__6 = null;
//line 728
___nl__7 = null;
//line 728
___nl__8 = null;
//line 728
___nl__4 = new ImmArray(new Imm[] {___nl__5,}).clone();
//line 728
___nl__5 = null;
//line 728
__function_map = new Dictionary<String, Imm>();
__function_map.Add("r",___nl__3);
__function_map.Add("a",___nl__4);
___nl__2 = new ImmHash(__function_map).clone();
//line 728
___nl__3 = null;
//line 728
___nl__4 = null;
//line 728
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 728
___nl__2 = null;
//line 728
___nl__1 = null;
//line 732
___nl__1 = new ImmString("hash::set_value").clone();
//line 732
___nl__3 = tct_NL.NL_tct_void().clone();

//line 732
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("ref")).clone();
//line 732
___nl__8 = tct_NL.NL_tct_im().clone();

//line 732
___nl__7 = tct_NL.NL_tct_hash(___nl__8).clone();

//line 732
___nl__8 = null;
//line 732
___nl__8 = new ImmString("").clone();
//line 732
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__6);
__function_map.Add("type",___nl__7);
__function_map.Add("name",___nl__8);
___nl__5 = new ImmHash(__function_map).clone();
//line 732
___nl__6 = null;
//line 732
___nl__7 = null;
//line 732
___nl__8 = null;
//line 732
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 732
___nl__8 = tct_NL.NL_tct_sim().clone();

//line 732
___nl__9 = new ImmString("").clone();
//line 732
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__7);
__function_map.Add("type",___nl__8);
__function_map.Add("name",___nl__9);
___nl__6 = new ImmHash(__function_map).clone();
//line 732
___nl__7 = null;
//line 732
___nl__8 = null;
//line 732
___nl__9 = null;
//line 732
___nl__8 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 732
___nl__9 = tct_NL.NL_tct_im().clone();

//line 732
___nl__10 = new ImmString("").clone();
//line 732
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__8);
__function_map.Add("type",___nl__9);
__function_map.Add("name",___nl__10);
___nl__7 = new ImmHash(__function_map).clone();
//line 732
___nl__8 = null;
//line 732
___nl__9 = null;
//line 732
___nl__10 = null;
//line 732
___nl__4 = new ImmArray(new Imm[] {___nl__5,___nl__6,___nl__7,}).clone();
//line 732
___nl__5 = null;
//line 732
___nl__6 = null;
//line 732
___nl__7 = null;
//line 732
__function_map = new Dictionary<String, Imm>();
__function_map.Add("r",___nl__3);
__function_map.Add("a",___nl__4);
___nl__2 = new ImmHash(__function_map).clone();
//line 732
___nl__3 = null;
//line 732
___nl__4 = null;
//line 732
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 732
___nl__2 = null;
//line 732
___nl__1 = null;
//line 737
___nl__1 = new ImmString("hash::get_value").clone();
//line 737
___nl__3 = tct_NL.NL_tct_im().clone();

//line 737
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 737
___nl__8 = tct_NL.NL_tct_im().clone();

//line 737
___nl__7 = tct_NL.NL_tct_hash(___nl__8).clone();

//line 737
___nl__8 = null;
//line 737
___nl__8 = new ImmString("").clone();
//line 737
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__6);
__function_map.Add("type",___nl__7);
__function_map.Add("name",___nl__8);
___nl__5 = new ImmHash(__function_map).clone();
//line 737
___nl__6 = null;
//line 737
___nl__7 = null;
//line 737
___nl__8 = null;
//line 737
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 737
___nl__8 = tct_NL.NL_tct_sim().clone();

//line 737
___nl__9 = new ImmString("").clone();
//line 737
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__7);
__function_map.Add("type",___nl__8);
__function_map.Add("name",___nl__9);
___nl__6 = new ImmHash(__function_map).clone();
//line 737
___nl__7 = null;
//line 737
___nl__8 = null;
//line 737
___nl__9 = null;
//line 737
___nl__4 = new ImmArray(new Imm[] {___nl__5,___nl__6,}).clone();
//line 737
___nl__5 = null;
//line 737
___nl__6 = null;
//line 737
__function_map = new Dictionary<String, Imm>();
__function_map.Add("r",___nl__3);
__function_map.Add("a",___nl__4);
___nl__2 = new ImmHash(__function_map).clone();
//line 737
___nl__3 = null;
//line 737
___nl__4 = null;
//line 737
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 737
___nl__2 = null;
//line 737
___nl__1 = null;
//line 740
___nl__1 = new ImmString("hash::has_key").clone();
//line 740
___nl__3 = tct_NL.NL_tct_bool().clone();

//line 740
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 740
___nl__8 = tct_NL.NL_tct_im().clone();

//line 740
___nl__7 = tct_NL.NL_tct_hash(___nl__8).clone();

//line 740
___nl__8 = null;
//line 740
___nl__8 = new ImmString("").clone();
//line 740
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__6);
__function_map.Add("type",___nl__7);
__function_map.Add("name",___nl__8);
___nl__5 = new ImmHash(__function_map).clone();
//line 740
___nl__6 = null;
//line 740
___nl__7 = null;
//line 740
___nl__8 = null;
//line 740
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 740
___nl__8 = tct_NL.NL_tct_sim().clone();

//line 740
___nl__9 = new ImmString("").clone();
//line 740
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__7);
__function_map.Add("type",___nl__8);
__function_map.Add("name",___nl__9);
___nl__6 = new ImmHash(__function_map).clone();
//line 740
___nl__7 = null;
//line 740
___nl__8 = null;
//line 740
___nl__9 = null;
//line 740
___nl__4 = new ImmArray(new Imm[] {___nl__5,___nl__6,}).clone();
//line 740
___nl__5 = null;
//line 740
___nl__6 = null;
//line 740
__function_map = new Dictionary<String, Imm>();
__function_map.Add("r",___nl__3);
__function_map.Add("a",___nl__4);
___nl__2 = new ImmHash(__function_map).clone();
//line 740
___nl__3 = null;
//line 740
___nl__4 = null;
//line 740
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 740
___nl__2 = null;
//line 740
___nl__1 = null;
//line 743
___nl__1 = new ImmString("hash::delete").clone();
//line 743
___nl__3 = tct_NL.NL_tct_void().clone();

//line 743
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("ref")).clone();
//line 743
___nl__8 = tct_NL.NL_tct_im().clone();

//line 743
___nl__7 = tct_NL.NL_tct_hash(___nl__8).clone();

//line 743
___nl__8 = null;
//line 743
___nl__8 = new ImmString("").clone();
//line 743
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__6);
__function_map.Add("type",___nl__7);
__function_map.Add("name",___nl__8);
___nl__5 = new ImmHash(__function_map).clone();
//line 743
___nl__6 = null;
//line 743
___nl__7 = null;
//line 743
___nl__8 = null;
//line 743
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 743
___nl__8 = tct_NL.NL_tct_sim().clone();

//line 743
___nl__9 = new ImmString("").clone();
//line 743
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__7);
__function_map.Add("type",___nl__8);
__function_map.Add("name",___nl__9);
___nl__6 = new ImmHash(__function_map).clone();
//line 743
___nl__7 = null;
//line 743
___nl__8 = null;
//line 743
___nl__9 = null;
//line 743
___nl__4 = new ImmArray(new Imm[] {___nl__5,___nl__6,}).clone();
//line 743
___nl__5 = null;
//line 743
___nl__6 = null;
//line 743
__function_map = new Dictionary<String, Imm>();
__function_map.Add("r",___nl__3);
__function_map.Add("a",___nl__4);
___nl__2 = new ImmHash(__function_map).clone();
//line 743
___nl__3 = null;
//line 743
___nl__4 = null;
//line 743
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 743
___nl__2 = null;
//line 743
___nl__1 = null;
//line 746
___nl__1 = new ImmString("hash::size").clone();
//line 746
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 746
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 746
___nl__8 = tct_NL.NL_tct_im().clone();

//line 746
___nl__7 = tct_NL.NL_tct_hash(___nl__8).clone();

//line 746
___nl__8 = null;
//line 746
___nl__8 = new ImmString("").clone();
//line 746
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__6);
__function_map.Add("type",___nl__7);
__function_map.Add("name",___nl__8);
___nl__5 = new ImmHash(__function_map).clone();
//line 746
___nl__6 = null;
//line 746
___nl__7 = null;
//line 746
___nl__8 = null;
//line 746
___nl__4 = new ImmArray(new Imm[] {___nl__5,}).clone();
//line 746
___nl__5 = null;
//line 746
__function_map = new Dictionary<String, Imm>();
__function_map.Add("r",___nl__3);
__function_map.Add("a",___nl__4);
___nl__2 = new ImmHash(__function_map).clone();
//line 746
___nl__3 = null;
//line 746
___nl__4 = null;
//line 746
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 746
___nl__2 = null;
//line 746
___nl__1 = null;
//line 748
___nl__1 = new ImmString("hash::values").clone();
//line 748
___nl__4 = tct_NL.NL_tct_im().clone();

//line 748
___nl__3 = tct_NL.NL_tct_arr(___nl__4).clone();

//line 748
___nl__4 = null;
//line 748
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 748
___nl__8 = tct_NL.NL_tct_im().clone();

//line 748
___nl__7 = tct_NL.NL_tct_hash(___nl__8).clone();

//line 748
___nl__8 = null;
//line 748
___nl__8 = new ImmString("").clone();
//line 748
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__6);
__function_map.Add("type",___nl__7);
__function_map.Add("name",___nl__8);
___nl__5 = new ImmHash(__function_map).clone();
//line 748
___nl__6 = null;
//line 748
___nl__7 = null;
//line 748
___nl__8 = null;
//line 748
___nl__4 = new ImmArray(new Imm[] {___nl__5,}).clone();
//line 748
___nl__5 = null;
//line 748
__function_map = new Dictionary<String, Imm>();
__function_map.Add("r",___nl__3);
__function_map.Add("a",___nl__4);
___nl__2 = new ImmHash(__function_map).clone();
//line 748
___nl__3 = null;
//line 748
___nl__4 = null;
//line 748
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 748
___nl__2 = null;
//line 748
___nl__1 = null;
//line 751
___nl__1 = new ImmString("ov::is").clone();
//line 751
___nl__3 = tct_NL.NL_tct_bool().clone();

//line 751
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 751
__function_map = new Dictionary<String, Imm>();
___nl__8 = new ImmHash(__function_map).clone();
//line 751
___nl__7 = tct_NL.NL_tct_var(___nl__8).clone();

//line 751
___nl__8 = null;
//line 751
___nl__8 = new ImmString("").clone();
//line 751
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__6);
__function_map.Add("type",___nl__7);
__function_map.Add("name",___nl__8);
___nl__5 = new ImmHash(__function_map).clone();
//line 751
___nl__6 = null;
//line 751
___nl__7 = null;
//line 751
___nl__8 = null;
//line 751
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 751
___nl__8 = tct_NL.NL_tct_sim().clone();

//line 751
___nl__9 = new ImmString("").clone();
//line 751
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__7);
__function_map.Add("type",___nl__8);
__function_map.Add("name",___nl__9);
___nl__6 = new ImmHash(__function_map).clone();
//line 751
___nl__7 = null;
//line 751
___nl__8 = null;
//line 751
___nl__9 = null;
//line 751
___nl__4 = new ImmArray(new Imm[] {___nl__5,___nl__6,}).clone();
//line 751
___nl__5 = null;
//line 751
___nl__6 = null;
//line 751
__function_map = new Dictionary<String, Imm>();
__function_map.Add("r",___nl__3);
__function_map.Add("a",___nl__4);
___nl__2 = new ImmHash(__function_map).clone();
//line 751
___nl__3 = null;
//line 751
___nl__4 = null;
//line 751
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 751
___nl__2 = null;
//line 751
___nl__1 = null;
//line 755
___nl__1 = new ImmString("ov::as").clone();
//line 755
___nl__3 = tct_NL.NL_tct_im().clone();

//line 755
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 755
__function_map = new Dictionary<String, Imm>();
___nl__8 = new ImmHash(__function_map).clone();
//line 755
___nl__7 = tct_NL.NL_tct_var(___nl__8).clone();

//line 755
___nl__8 = null;
//line 755
___nl__8 = new ImmString("").clone();
//line 755
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__6);
__function_map.Add("type",___nl__7);
__function_map.Add("name",___nl__8);
___nl__5 = new ImmHash(__function_map).clone();
//line 755
___nl__6 = null;
//line 755
___nl__7 = null;
//line 755
___nl__8 = null;
//line 755
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 755
___nl__8 = tct_NL.NL_tct_sim().clone();

//line 755
___nl__9 = new ImmString("").clone();
//line 755
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__7);
__function_map.Add("type",___nl__8);
__function_map.Add("name",___nl__9);
___nl__6 = new ImmHash(__function_map).clone();
//line 755
___nl__7 = null;
//line 755
___nl__8 = null;
//line 755
___nl__9 = null;
//line 755
___nl__4 = new ImmArray(new Imm[] {___nl__5,___nl__6,}).clone();
//line 755
___nl__5 = null;
//line 755
___nl__6 = null;
//line 755
__function_map = new Dictionary<String, Imm>();
__function_map.Add("r",___nl__3);
__function_map.Add("a",___nl__4);
___nl__2 = new ImmHash(__function_map).clone();
//line 755
___nl__3 = null;
//line 755
___nl__4 = null;
//line 755
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 755
___nl__2 = null;
//line 755
___nl__1 = null;
//line 760
___nl__1 = new ImmString("dfile::ssave").clone();
//line 760
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 760
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 760
___nl__7 = tct_NL.NL_tct_im().clone();

//line 760
___nl__8 = new ImmString("").clone();
//line 760
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__6);
__function_map.Add("type",___nl__7);
__function_map.Add("name",___nl__8);
___nl__5 = new ImmHash(__function_map).clone();
//line 760
___nl__6 = null;
//line 760
___nl__7 = null;
//line 760
___nl__8 = null;
//line 760
___nl__4 = new ImmArray(new Imm[] {___nl__5,}).clone();
//line 760
___nl__5 = null;
//line 760
__function_map = new Dictionary<String, Imm>();
__function_map.Add("r",___nl__3);
__function_map.Add("a",___nl__4);
___nl__2 = new ImmHash(__function_map).clone();
//line 760
___nl__3 = null;
//line 760
___nl__4 = null;
//line 760
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 760
___nl__2 = null;
//line 760
___nl__1 = null;
//line 764
___nl__1 = new ImmString("string::lf").clone();
//line 764
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 764
___nl__4 = new ImmArray(new Imm[0]).clone();
//line 764
__function_map = new Dictionary<String, Imm>();
__function_map.Add("r",___nl__3);
__function_map.Add("a",___nl__4);
___nl__2 = new ImmHash(__function_map).clone();
//line 764
___nl__3 = null;
//line 764
___nl__4 = null;
//line 764
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 764
___nl__2 = null;
//line 764
___nl__1 = null;
//line 765
___nl__1 = new ImmString("string::length").clone();
//line 765
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 765
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 765
___nl__7 = tct_NL.NL_tct_sim().clone();

//line 765
___nl__8 = new ImmString("").clone();
//line 765
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__6);
__function_map.Add("type",___nl__7);
__function_map.Add("name",___nl__8);
___nl__5 = new ImmHash(__function_map).clone();
//line 765
___nl__6 = null;
//line 765
___nl__7 = null;
//line 765
___nl__8 = null;
//line 765
___nl__4 = new ImmArray(new Imm[] {___nl__5,}).clone();
//line 765
___nl__5 = null;
//line 765
__function_map = new Dictionary<String, Imm>();
__function_map.Add("r",___nl__3);
__function_map.Add("a",___nl__4);
___nl__2 = new ImmHash(__function_map).clone();
//line 765
___nl__3 = null;
//line 765
___nl__4 = null;
//line 765
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 765
___nl__2 = null;
//line 765
___nl__1 = null;
//line 768
___nl__1 = new ImmString("string::substr").clone();
//line 768
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 768
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 768
___nl__7 = tct_NL.NL_tct_sim().clone();

//line 768
___nl__8 = new ImmString("").clone();
//line 768
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__6);
__function_map.Add("type",___nl__7);
__function_map.Add("name",___nl__8);
___nl__5 = new ImmHash(__function_map).clone();
//line 768
___nl__6 = null;
//line 768
___nl__7 = null;
//line 768
___nl__8 = null;
//line 768
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 768
___nl__8 = tct_NL.NL_tct_sim().clone();

//line 768
___nl__9 = new ImmString("").clone();
//line 768
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__7);
__function_map.Add("type",___nl__8);
__function_map.Add("name",___nl__9);
___nl__6 = new ImmHash(__function_map).clone();
//line 768
___nl__7 = null;
//line 768
___nl__8 = null;
//line 768
___nl__9 = null;
//line 768
___nl__8 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 768
___nl__9 = tct_NL.NL_tct_sim().clone();

//line 768
___nl__10 = new ImmString("").clone();
//line 768
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__8);
__function_map.Add("type",___nl__9);
__function_map.Add("name",___nl__10);
___nl__7 = new ImmHash(__function_map).clone();
//line 768
___nl__8 = null;
//line 768
___nl__9 = null;
//line 768
___nl__10 = null;
//line 768
___nl__4 = new ImmArray(new Imm[] {___nl__5,___nl__6,___nl__7,}).clone();
//line 768
___nl__5 = null;
//line 768
___nl__6 = null;
//line 768
___nl__7 = null;
//line 768
__function_map = new Dictionary<String, Imm>();
__function_map.Add("r",___nl__3);
__function_map.Add("a",___nl__4);
___nl__2 = new ImmHash(__function_map).clone();
//line 768
___nl__3 = null;
//line 768
___nl__4 = null;
//line 768
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 768
___nl__2 = null;
//line 768
___nl__1 = null;
//line 773
___nl__1 = new ImmString("string::replace").clone();
//line 773
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 773
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 773
___nl__7 = tct_NL.NL_tct_sim().clone();

//line 773
___nl__8 = new ImmString("").clone();
//line 773
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__6);
__function_map.Add("type",___nl__7);
__function_map.Add("name",___nl__8);
___nl__5 = new ImmHash(__function_map).clone();
//line 773
___nl__6 = null;
//line 773
___nl__7 = null;
//line 773
___nl__8 = null;
//line 773
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 773
___nl__8 = tct_NL.NL_tct_sim().clone();

//line 773
___nl__9 = new ImmString("").clone();
//line 773
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__7);
__function_map.Add("type",___nl__8);
__function_map.Add("name",___nl__9);
___nl__6 = new ImmHash(__function_map).clone();
//line 773
___nl__7 = null;
//line 773
___nl__8 = null;
//line 773
___nl__9 = null;
//line 773
___nl__8 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 773
___nl__9 = tct_NL.NL_tct_sim().clone();

//line 773
___nl__10 = new ImmString("").clone();
//line 773
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__8);
__function_map.Add("type",___nl__9);
__function_map.Add("name",___nl__10);
___nl__7 = new ImmHash(__function_map).clone();
//line 773
___nl__8 = null;
//line 773
___nl__9 = null;
//line 773
___nl__10 = null;
//line 773
___nl__4 = new ImmArray(new Imm[] {___nl__5,___nl__6,___nl__7,}).clone();
//line 773
___nl__5 = null;
//line 773
___nl__6 = null;
//line 773
___nl__7 = null;
//line 773
__function_map = new Dictionary<String, Imm>();
__function_map.Add("r",___nl__3);
__function_map.Add("a",___nl__4);
___nl__2 = new ImmHash(__function_map).clone();
//line 773
___nl__3 = null;
//line 773
___nl__4 = null;
//line 773
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 773
___nl__2 = null;
//line 773
___nl__1 = null;
//line 778
___nl__1 = new ImmString("string::chr").clone();
//line 778
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 778
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 778
___nl__7 = tct_NL.NL_tct_sim().clone();

//line 778
___nl__8 = new ImmString("").clone();
//line 778
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__6);
__function_map.Add("type",___nl__7);
__function_map.Add("name",___nl__8);
___nl__5 = new ImmHash(__function_map).clone();
//line 778
___nl__6 = null;
//line 778
___nl__7 = null;
//line 778
___nl__8 = null;
//line 778
___nl__4 = new ImmArray(new Imm[] {___nl__5,}).clone();
//line 778
___nl__5 = null;
//line 778
__function_map = new Dictionary<String, Imm>();
__function_map.Add("r",___nl__3);
__function_map.Add("a",___nl__4);
___nl__2 = new ImmHash(__function_map).clone();
//line 778
___nl__3 = null;
//line 778
___nl__4 = null;
//line 778
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 778
___nl__2 = null;
//line 778
___nl__1 = null;
//line 781
___nl__1 = new ImmString("string::ord").clone();
//line 781
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 781
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 781
___nl__7 = tct_NL.NL_tct_sim().clone();

//line 781
___nl__8 = new ImmString("").clone();
//line 781
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__6);
__function_map.Add("type",___nl__7);
__function_map.Add("name",___nl__8);
___nl__5 = new ImmHash(__function_map).clone();
//line 781
___nl__6 = null;
//line 781
___nl__7 = null;
//line 781
___nl__8 = null;
//line 781
___nl__4 = new ImmArray(new Imm[] {___nl__5,}).clone();
//line 781
___nl__5 = null;
//line 781
__function_map = new Dictionary<String, Imm>();
__function_map.Add("r",___nl__3);
__function_map.Add("a",___nl__4);
___nl__2 = new ImmHash(__function_map).clone();
//line 781
___nl__3 = null;
//line 781
___nl__4 = null;
//line 781
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 781
___nl__2 = null;
//line 781
___nl__1 = null;
//line 784
___nl__1 = new ImmString("string::split").clone();
//line 784
___nl__4 = tct_NL.NL_tct_sim().clone();

//line 784
___nl__3 = tct_NL.NL_tct_arr(___nl__4).clone();

//line 784
___nl__4 = null;
//line 784
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 784
___nl__7 = tct_NL.NL_tct_sim().clone();

//line 784
___nl__8 = new ImmString("").clone();
//line 784
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__6);
__function_map.Add("type",___nl__7);
__function_map.Add("name",___nl__8);
___nl__5 = new ImmHash(__function_map).clone();
//line 784
___nl__6 = null;
//line 784
___nl__7 = null;
//line 784
___nl__8 = null;
//line 784
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 784
___nl__8 = tct_NL.NL_tct_sim().clone();

//line 784
___nl__9 = new ImmString("").clone();
//line 784
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__7);
__function_map.Add("type",___nl__8);
__function_map.Add("name",___nl__9);
___nl__6 = new ImmHash(__function_map).clone();
//line 784
___nl__7 = null;
//line 784
___nl__8 = null;
//line 784
___nl__9 = null;
//line 784
___nl__4 = new ImmArray(new Imm[] {___nl__5,___nl__6,}).clone();
//line 784
___nl__5 = null;
//line 784
___nl__6 = null;
//line 784
__function_map = new Dictionary<String, Imm>();
__function_map.Add("r",___nl__3);
__function_map.Add("a",___nl__4);
___nl__2 = new ImmHash(__function_map).clone();
//line 784
___nl__3 = null;
//line 784
___nl__4 = null;
//line 784
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 784
___nl__2 = null;
//line 784
___nl__1 = null;
//line 788
___nl__1 = new ImmString("c_std_lib::fast_substr").clone();
//line 788
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 788
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 788
___nl__7 = tct_NL.NL_tct_im().clone();

//line 788
___nl__8 = new ImmString("").clone();
//line 788
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__6);
__function_map.Add("type",___nl__7);
__function_map.Add("name",___nl__8);
___nl__5 = new ImmHash(__function_map).clone();
//line 788
___nl__6 = null;
//line 788
___nl__7 = null;
//line 788
___nl__8 = null;
//line 788
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 788
___nl__8 = tct_NL.NL_tct_im().clone();

//line 788
___nl__9 = new ImmString("").clone();
//line 788
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__7);
__function_map.Add("type",___nl__8);
__function_map.Add("name",___nl__9);
___nl__6 = new ImmHash(__function_map).clone();
//line 788
___nl__7 = null;
//line 788
___nl__8 = null;
//line 788
___nl__9 = null;
//line 788
___nl__8 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 788
___nl__9 = tct_NL.NL_tct_im().clone();

//line 788
___nl__10 = new ImmString("").clone();
//line 788
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__8);
__function_map.Add("type",___nl__9);
__function_map.Add("name",___nl__10);
___nl__7 = new ImmHash(__function_map).clone();
//line 788
___nl__8 = null;
//line 788
___nl__9 = null;
//line 788
___nl__10 = null;
//line 788
___nl__4 = new ImmArray(new Imm[] {___nl__5,___nl__6,___nl__7,}).clone();
//line 788
___nl__5 = null;
//line 788
___nl__6 = null;
//line 788
___nl__7 = null;
//line 788
__function_map = new Dictionary<String, Imm>();
__function_map.Add("r",___nl__3);
__function_map.Add("a",___nl__4);
___nl__2 = new ImmHash(__function_map).clone();
//line 788
___nl__3 = null;
//line 788
___nl__4 = null;
//line 788
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 788
___nl__2 = null;
//line 788
___nl__1 = null;
//line 793
___nl__1 = new ImmString("c_singleton::sigleton_do_not_use_without_approval").clone();
//line 793
___nl__3 = tct_NL.NL_tct_im().clone();

//line 793
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 793
___nl__7 = tct_NL.NL_tct_im().clone();

//line 793
___nl__8 = new ImmString("").clone();
//line 793
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__6);
__function_map.Add("type",___nl__7);
__function_map.Add("name",___nl__8);
___nl__5 = new ImmHash(__function_map).clone();
//line 793
___nl__6 = null;
//line 793
___nl__7 = null;
//line 793
___nl__8 = null;
//line 793
___nl__4 = new ImmArray(new Imm[] {___nl__5,}).clone();
//line 793
___nl__5 = null;
//line 793
__function_map = new Dictionary<String, Imm>();
__function_map.Add("r",___nl__3);
__function_map.Add("a",___nl__4);
___nl__2 = new ImmHash(__function_map).clone();
//line 793
___nl__3 = null;
//line 793
___nl__4 = null;
//line 793
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 793
___nl__2 = null;
//line 793
___nl__1 = null;
//line 796
___nl__1 = singleton_NL.NL_sigleton_do_not_use_without_approval(___nl__0).clone();

//line 796
___nl__0 = null;
//line 796
if(true) return ___nl__1;
//line 796
___nl__1 = null;
//line 796
___nl__0 = null;
//line 796
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_get_special_functions_priv = null;
private static Imm NL_get_special_functions_priv() {
	if (value__singleton__NL_SINGLETON_get_special_functions_priv == null) {
		value__singleton__NL_SINGLETON_get_special_functions_priv = NL_SINGLETON_get_special_functions_priv();
	}
	return value__singleton__NL_SINGLETON_get_special_functions_priv;
}
private static Imm NL_get_special_function_def_priv(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
Imm ___nl__9 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
ImmRef ___ref______nl__6 = null;
ImmRef ___ref______nl__7 = null;
ImmRef ___ref______nl__8 = null;
ImmRef ___ref______nl__9 = null;
Dictionary<String, Imm> __function_map;
//line 799
___nl__2 = type_checker_NL.NL_get_special_functions_priv().clone();

//line 800
___nl__5 = nast_NL.NL_empty_debug().clone();

//line 800
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("nop")).clone();
//line 800
__function_map = new Dictionary<String, Imm>();
__function_map.Add("debug",___nl__5);
__function_map.Add("cmd",___nl__6);
___nl__4 = new ImmHash(__function_map).clone();
//line 800
___nl__5 = null;
//line 800
___nl__6 = null;
//line 800
___nl__5 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("no")).clone();
//line 800
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("no")).clone();
//line 800
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("pub")).clone();
//line 800
___nl__8 = new ImmArray(new Imm[0]).clone();
//line 800
___nl__9 = tct_NL.NL_tct_empty().clone();

//line 800
__function_map = new Dictionary<String, Imm>();
__function_map.Add("cmd",___nl__4);
__function_map.Add("is_type",___nl__5);
__function_map.Add("ref_types",___nl__6);
__function_map.Add("name",___nl__1);
__function_map.Add("module",___nl__0);
__function_map.Add("access",___nl__7);
__function_map.Add("args",___nl__8);
__function_map.Add("ret_type",___nl__9);
___nl__3 = new ImmHash(__function_map).clone();
//line 800
___nl__4 = null;
//line 800
___nl__5 = null;
//line 800
___nl__6 = null;
//line 800
___nl__7 = null;
//line 800
___nl__8 = null;
//line 800
___nl__9 = null;
//line 810
___nl__4 = type_checker_NL.NL_get_function_name_priv(___nl__0,___nl__1).clone();

//line 810
___nl__1 = ___nl__4.clone();
//line 810
___nl__4 = null;
//line 811
___nl__4 = hash_NL.NL_has_key(___nl__2,___nl__1).clone();

//line 811
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 811
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 812
___nl__5 = hash_NL.NL_get_value(___nl__2,___nl__1).clone();

//line 813
___nl__6 = ((ImmHash)___nl__5).getHashValue()["a"].clone();
//line 813
___nl__7 = ___nl__6.clone();
//line 813
((ImmHash)___nl__3).set("args", ___nl__7);
//line 813
___nl__6 = null;
//line 813
___nl__7 = null;
//line 814
___nl__6 = ((ImmHash)___nl__5).getHashValue()["r"].clone();
//line 814
___nl__7 = ___nl__6.clone();
//line 814
((ImmHash)___nl__3).set("ret_type", ___nl__7);
//line 814
___nl__6 = null;
//line 814
___nl__7 = null;
//line 814
___nl__5 = null;
//line 815
if (true) {goto label_1;}
//line 815
label_2:
//line 816
___nl__5 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("priv")).clone();
//line 816
___nl__6 = ___nl__5.clone();
//line 816
((ImmHash)___nl__3).set("access", ___nl__6);
//line 816
___nl__5 = null;
//line 816
___nl__6 = null;
//line 817
if (true) {goto label_1;}
//line 817
label_1:
//line 817
___nl__4 = null;
//line 818
___nl__0 = null;
//line 818
___nl__1 = null;
//line 818
___nl__2 = null;
//line 818
if(true) return ___nl__3;
//line 818
___nl__2 = null;
//line 818
___nl__3 = null;
//line 818
___nl__0 = null;
//line 818
___nl__1 = null;
//line 818
if(true) return null;
}

private static Imm NL_check_special_function_priv(Imm ___arg__0, Imm ___arg__1, Imm ___arg__2, ImmRef ___arg__3, ImmRef ___arg__4, ImmRef ___arg__5) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();Imm ___nl__3 = ___arg__3.getValue().clone();Imm ___nl__4 = ___arg__4.getValue().clone();Imm ___nl__5 = ___arg__5.getValue().clone();
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
Imm ___nl__9 = null;
Imm ___nl__10 = null;
Imm ___nl__11 = null;
Imm ___nl__12 = null;
Imm ___nl__13 = null;
Imm ___nl__14 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
ImmRef ___ref______nl__6 = null;
ImmRef ___ref______nl__7 = null;
ImmRef ___ref______nl__8 = null;
ImmRef ___ref______nl__9 = null;
ImmRef ___ref______nl__10 = null;
ImmRef ___ref______nl__11 = null;
ImmRef ___ref______nl__12 = null;
ImmRef ___ref______nl__13 = null;
ImmRef ___ref______nl__14 = null;
Dictionary<String, Imm> __function_map;
//line 822
___nl__7 = ((ImmHash)___nl__1).getHashValue()["module"].clone();
//line 822
___nl__8 = ((ImmHash)___nl__1).getHashValue()["name"].clone();
//line 822
___nl__6 = type_checker_NL.NL_get_function_name_priv(___nl__7,___nl__8).clone();

//line 822
___nl__8 = null;
//line 822
___nl__7 = null;
//line 824
___nl__7 = new ImmString("ptd::ensure").clone();
//line 824
___nl__7 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__7.toString())).clone();
//line 824
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_3;}}
//line 824
___nl__7 = new ImmString("ptd::ensure_only_static_do_not_touch_without_permission").clone();
//line 824
___nl__7 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__7.toString())).clone();
//line 824
label_3:
//line 824
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 824
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_2;}}
//line 825
___nl__9 = ((ImmHash)___nl__1).getHashValue()["args"].clone();
//line 825
___nl__10 = new ImmDouble(0).clone();
//line 825
___nl__9 = (___nl__9 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()].clone();
//line 825
___nl__10 = null;
//line 825
___nl__9 = ((ImmHash)___nl__9).getHashValue()["val"].clone();
//line 825
___nl__8 = ptd_parser_NL.NL_try_value_to_ptd(___nl__9).clone();

//line 825
___nl__9 = null;
//line 825
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("err")).clone();
//line 825
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_5;}}
//line 828
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("ok")).clone();
//line 828
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_6;}}
//line 828
___nl__9 = new ImmString("NOMATCHALERT").clone();
//line 828
___nl__9 = new ImmArray(new Imm[] {___nl__9,___nl__8,}).clone();
//line 828
c_rt_lib_NL.NL_die();
//line 825
label_5:
//line 825
___nl__10 = c_rt_lib_NL.NL_ov_as(___nl__8, new ImmString("err")).clone();
//line 826
___ref______nl__5 = new ImmRef(___nl__5);
type_checker_NL.NL_add_error_priv(___ref______nl__5,___nl__10);
___nl__5 = ___ref______nl__5.getValue().clone();

//line 827
___nl__11 = tct_NL.NL_tct_im().clone();

//line 827
___nl__12 = ___nl__11.clone();
//line 827
((ImmHash)___nl__0).set("type", ___nl__12);
//line 827
___nl__11 = null;
//line 827
___nl__12 = null;
//line 827
___nl__10 = null;
//line 828
if (true) {goto label_4;}
//line 828
label_6:
//line 828
___nl__10 = c_rt_lib_NL.NL_ov_as(___nl__8, new ImmString("ok")).clone();
//line 829
___nl__13 = new ImmDouble(1).clone();
//line 829
___nl__12 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__13).getDoubleValue()].clone();
//line 829
___nl__13 = null;
//line 829
___ref______nl__3 = new ImmRef(___nl__3);
___ref______nl__5 = new ImmRef(___nl__5);
___nl__11 = ptd_system_NL.NL_cast_type(___nl__10,___nl__12,___ref______nl__3,___ref______nl__5).clone();
___nl__3 = ___ref______nl__3.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();

//line 829
___nl__12 = null;
//line 830
___nl__13 = new ImmString("err").clone();
//line 830
___nl__12 = ov_NL.NL_is(___nl__11,___nl__13).clone();

//line 830
___nl__13 = null;
//line 830
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 830
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_8;}}
//line 831
___nl__13 = new ImmString("this casting of type cannot be correct: ").clone();
//line 831
___nl__14 = type_checker_NL.NL_get_print_check_info_priv(___nl__11).clone();

//line 831
___nl__13 = new ImmString(___nl__13.toString() + ___nl__14.toString()).clone();
//line 831
___nl__14 = null;
//line 831
___ref______nl__5 = new ImmRef(___nl__5);
type_checker_NL.NL_add_error_priv(___ref______nl__5,___nl__13);
___nl__5 = ___ref______nl__5.getValue().clone();

//line 831
___nl__13 = null;
//line 832
if (true) {goto label_8;}
//line 832
label_8:
//line 832
___nl__12 = null;
//line 833
___nl__12 = ___nl__10.clone();
//line 833
((ImmHash)___nl__0).set("type", ___nl__12);
//line 833
___nl__12 = null;
//line 834
___ref______nl__3 = new ImmRef(___nl__3);
___ref______nl__5 = new ImmRef(___nl__5);
type_checker_NL.NL_check_types_imported_priv(___nl__10,___ref______nl__3,___ref______nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();

//line 834
___nl__11 = null;
//line 834
___nl__10 = null;
//line 835
if (true) {goto label_4;}
//line 835
label_4:
//line 835
___nl__8 = null;
//line 835
___nl__9 = null;
//line 836
if (true) {goto label_2;}
//line 836
label_2:
//line 836
___nl__7 = null;
//line 837
___nl__7 = new ImmString("array::push").clone();
//line 837
___nl__7 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__7.toString())).clone();
//line 837
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 837
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_10;}}
//line 838
___nl__10 = new ImmDouble(1).clone();
//line 838
___nl__9 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()].clone();
//line 838
___nl__10 = null;
//line 838
___nl__9 = ((ImmHash)___nl__9).getHashValue()["type"].clone();
//line 838
___nl__8 = tct_NL.NL_tct_arr(___nl__9).clone();

//line 838
___nl__9 = null;
//line 838
___nl__10 = new ImmDouble(1).clone();
//line 838
___nl__9 = c_rt_lib_NL.NL_get_ref_arr(___nl__2,___nl__10).clone();

//line 838
___nl__11 = ___nl__8.clone();
//line 838
((ImmHash)___nl__9).set("type", ___nl__11);
//line 838
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_arr(___ref______nl__2,___nl__10,___nl__9);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 838
___nl__8 = null;
//line 838
___nl__9 = null;
//line 838
___nl__10 = null;
//line 838
___nl__11 = null;
//line 839
___nl__8 = ((ImmHash)___nl__1).getHashValue()["args"].clone();
//line 839
___nl__9 = new ImmDouble(0).clone();
//line 839
___nl__8 = (___nl__8 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()].clone();
//line 839
___nl__9 = null;
//line 839
___nl__8 = ((ImmHash)___nl__8).getHashValue()["val"].clone();
//line 839
___nl__10 = new ImmDouble(0).clone();
//line 839
___nl__9 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()].clone();
//line 839
___nl__10 = null;
//line 839
___nl__11 = new ImmDouble(1).clone();
//line 839
___nl__10 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__11).getDoubleValue()].clone();
//line 839
___nl__11 = null;
//line 839
___nl__12 = tct_NL.NL_tct_empty().clone();

//line 839
___nl__11 = tct_NL.NL_tct_arr(___nl__12).clone();

//line 839
___nl__12 = null;
//line 839
___ref______nl__3 = new ImmRef(___nl__3);
___ref______nl__4 = new ImmRef(___nl__4);
___ref______nl__5 = new ImmRef(___nl__5);
type_checker_NL.NL_set_type_to_lval_spec_priv(___nl__8,___nl__9,___nl__10,___nl__11,___ref______nl__3,___ref______nl__4,___ref______nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();
___nl__4 = ___ref______nl__4.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();

//line 839
___nl__11 = null;
//line 839
___nl__10 = null;
//line 839
___nl__9 = null;
//line 839
___nl__8 = null;
//line 841
if (true) {goto label_10;}
//line 841
label_10:
//line 841
___nl__7 = null;
//line 842
___nl__7 = new ImmString("array::append").clone();
//line 842
___nl__7 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__7.toString())).clone();
//line 842
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 842
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_12;}}
//line 843
___nl__8 = ((ImmHash)___nl__1).getHashValue()["args"].clone();
//line 843
___nl__9 = new ImmDouble(0).clone();
//line 843
___nl__8 = (___nl__8 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()].clone();
//line 843
___nl__9 = null;
//line 843
___nl__8 = ((ImmHash)___nl__8).getHashValue()["val"].clone();
//line 843
___nl__10 = new ImmDouble(0).clone();
//line 843
___nl__9 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()].clone();
//line 843
___nl__10 = null;
//line 843
___nl__11 = new ImmDouble(1).clone();
//line 843
___nl__10 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__11).getDoubleValue()].clone();
//line 843
___nl__11 = null;
//line 843
___nl__12 = tct_NL.NL_tct_empty().clone();

//line 843
___nl__11 = tct_NL.NL_tct_arr(___nl__12).clone();

//line 843
___nl__12 = null;
//line 843
___ref______nl__3 = new ImmRef(___nl__3);
___ref______nl__4 = new ImmRef(___nl__4);
___ref______nl__5 = new ImmRef(___nl__5);
type_checker_NL.NL_set_type_to_lval_spec_priv(___nl__8,___nl__9,___nl__10,___nl__11,___ref______nl__3,___ref______nl__4,___ref______nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();
___nl__4 = ___ref______nl__4.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();

//line 843
___nl__11 = null;
//line 843
___nl__10 = null;
//line 843
___nl__9 = null;
//line 843
___nl__8 = null;
//line 845
if (true) {goto label_12;}
//line 845
label_12:
//line 845
___nl__7 = null;
//line 846
___nl__7 = new ImmString("array::subarray").clone();
//line 846
___nl__7 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__7.toString())).clone();
//line 846
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 846
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_14;}}
//line 847
___nl__9 = new ImmDouble(0).clone();
//line 847
___nl__8 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()].clone();
//line 847
___nl__9 = null;
//line 847
___nl__0 = null;
//line 847
___nl__1 = null;
//line 847
___nl__2 = null;
//line 847
___nl__6 = null;
//line 847
___nl__7 = null;
//line 847
___arg__3.setValue(___nl__3);___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__8;
//line 847
___nl__8 = null;
//line 848
if (true) {goto label_14;}
//line 848
label_14:
//line 848
___nl__7 = null;
//line 850
___nl__7 = new ImmString("hash::set_value").clone();
//line 850
___nl__7 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__7.toString())).clone();
//line 850
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 850
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_16;}}
//line 851
___nl__10 = new ImmDouble(2).clone();
//line 851
___nl__9 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()].clone();
//line 851
___nl__10 = null;
//line 851
___nl__9 = ((ImmHash)___nl__9).getHashValue()["type"].clone();
//line 851
___nl__8 = tct_NL.NL_tct_hash(___nl__9).clone();

//line 851
___nl__9 = null;
//line 851
___nl__10 = new ImmDouble(2).clone();
//line 851
___nl__9 = c_rt_lib_NL.NL_get_ref_arr(___nl__2,___nl__10).clone();

//line 851
___nl__11 = ___nl__8.clone();
//line 851
((ImmHash)___nl__9).set("type", ___nl__11);
//line 851
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_arr(___ref______nl__2,___nl__10,___nl__9);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 851
___nl__8 = null;
//line 851
___nl__9 = null;
//line 851
___nl__10 = null;
//line 851
___nl__11 = null;
//line 852
___nl__8 = ((ImmHash)___nl__1).getHashValue()["args"].clone();
//line 852
___nl__9 = new ImmDouble(0).clone();
//line 852
___nl__8 = (___nl__8 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()].clone();
//line 852
___nl__9 = null;
//line 852
___nl__8 = ((ImmHash)___nl__8).getHashValue()["val"].clone();
//line 852
___nl__10 = new ImmDouble(0).clone();
//line 852
___nl__9 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()].clone();
//line 852
___nl__10 = null;
//line 852
___nl__11 = new ImmDouble(2).clone();
//line 852
___nl__10 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__11).getDoubleValue()].clone();
//line 852
___nl__11 = null;
//line 852
__function_map = new Dictionary<String, Imm>();
___nl__12 = new ImmHash(__function_map).clone();
//line 852
___nl__11 = tct_NL.NL_tct_rec(___nl__12).clone();

//line 852
___nl__12 = null;
//line 852
___ref______nl__3 = new ImmRef(___nl__3);
___ref______nl__4 = new ImmRef(___nl__4);
___ref______nl__5 = new ImmRef(___nl__5);
type_checker_NL.NL_set_type_to_lval_spec_priv(___nl__8,___nl__9,___nl__10,___nl__11,___ref______nl__3,___ref______nl__4,___ref______nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();
___nl__4 = ___ref______nl__4.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();

//line 852
___nl__11 = null;
//line 852
___nl__10 = null;
//line 852
___nl__9 = null;
//line 852
___nl__8 = null;
//line 854
if (true) {goto label_16;}
//line 854
label_16:
//line 854
___nl__7 = null;
//line 855
___nl__7 = new ImmString("hash::delete").clone();
//line 855
___nl__7 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__7.toString())).clone();
//line 855
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 855
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_18;}}
//line 856
___nl__10 = new ImmDouble(0).clone();
//line 856
___nl__9 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()].clone();
//line 856
___nl__10 = null;
//line 856
___ref______nl__3 = new ImmRef(___nl__3);
___ref______nl__5 = new ImmRef(___nl__5);
___nl__8 = ptd_system_NL.NL_can_delete(___nl__9,___ref______nl__3,___ref______nl__5).clone();
___nl__3 = ___ref______nl__3.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();

//line 856
___nl__9 = null;
//line 857
___nl__9 = ((ImmHash)___nl__8).getHashValue()["type"].clone();
//line 857
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__9, new ImmString("tct_rec")).clone();
//line 857
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 857
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_20;}}
//line 858
___nl__10 = ___nl__8.clone();
//line 859
___nl__13 = tct_NL.NL_tct_empty().clone();

//line 859
___nl__12 = tct_NL.NL_tct_hash(___nl__13).clone();

//line 859
___nl__13 = null;
//line 859
___nl__13 = ((ImmHash)___nl__8).getHashValue()["type"].clone();
//line 859
___ref______nl__3 = new ImmRef(___nl__3);
___ref______nl__5 = new ImmRef(___nl__5);
___nl__11 = ptd_system_NL.NL_cross_type(___nl__12,___nl__13,___ref______nl__3,___ref______nl__5).clone();
___nl__3 = ___ref______nl__3.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();

//line 859
___nl__13 = null;
//line 859
___nl__12 = null;
//line 859
___nl__12 = ___nl__11.clone();
//line 859
((ImmHash)___nl__10).set("type", ___nl__12);
//line 859
___nl__11 = null;
//line 859
___nl__12 = null;
//line 860
___nl__11 = ((ImmHash)___nl__1).getHashValue()["args"].clone();
//line 860
___nl__12 = new ImmDouble(0).clone();
//line 860
___nl__11 = (___nl__11 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__12).getDoubleValue()].clone();
//line 860
___nl__12 = null;
//line 860
___nl__11 = ((ImmHash)___nl__11).getHashValue()["val"].clone();
//line 860
__function_map = new Dictionary<String, Imm>();
___nl__13 = new ImmHash(__function_map).clone();
//line 860
___nl__12 = tct_NL.NL_tct_rec(___nl__13).clone();

//line 860
___nl__13 = null;
//line 860
___ref______nl__3 = new ImmRef(___nl__3);
___ref______nl__4 = new ImmRef(___nl__4);
___ref______nl__5 = new ImmRef(___nl__5);
type_checker_NL.NL_set_type_to_lval_spec_priv(___nl__11,___nl__8,___nl__10,___nl__12,___ref______nl__3,___ref______nl__4,___ref______nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();
___nl__4 = ___ref______nl__4.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();

//line 860
___nl__12 = null;
//line 860
___nl__11 = null;
//line 860
___nl__10 = null;
//line 861
if (true) {goto label_20;}
//line 861
label_20:
//line 861
___nl__9 = null;
//line 861
___nl__8 = null;
//line 862
if (true) {goto label_18;}
//line 862
label_18:
//line 862
___nl__7 = null;
//line 863
___nl__7 = new ImmString("hash::get_value").clone();
//line 863
___nl__7 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__7.toString())).clone();
//line 863
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 863
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_22;}}
//line 864
___nl__10 = new ImmDouble(0).clone();
//line 864
___nl__9 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()].clone();
//line 864
___nl__10 = null;
//line 864
___ref______nl__3 = new ImmRef(___nl__3);
___ref______nl__5 = new ImmRef(___nl__5);
___nl__8 = ptd_system_NL.NL_can_delete(___nl__9,___ref______nl__3,___ref______nl__5).clone();
___nl__3 = ___ref______nl__3.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();

//line 864
___nl__9 = null;
//line 865
___nl__9 = ((ImmHash)___nl__8).getHashValue()["src"].clone();
//line 865
___nl__10 = ___nl__9.clone();
//line 865
((ImmHash)___nl__0).set("src", ___nl__10);
//line 865
___nl__9 = null;
//line 865
___nl__10 = null;
//line 866
___nl__9 = ((ImmHash)___nl__8).getHashValue()["type"].clone();
//line 866
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__9, new ImmString("tct_hash")).clone();
//line 866
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 866
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_24;}}
//line 866
___nl__10 = ((ImmHash)___nl__8).getHashValue()["type"].clone();
//line 866
___nl__10 = c_rt_lib_NL.NL_ov_as(___nl__10, new ImmString("tct_hash")).clone();
//line 866
___nl__11 = ___nl__10.clone();
//line 866
((ImmHash)___nl__0).set("type", ___nl__11);
//line 866
___nl__10 = null;
//line 866
___nl__11 = null;
//line 866
if (true) {goto label_24;}
//line 866
label_24:
//line 866
___nl__9 = null;
//line 866
___nl__8 = null;
//line 867
if (true) {goto label_22;}
//line 867
label_22:
//line 867
___nl__7 = null;
//line 868
___nl__7 = new ImmString("hash::values").clone();
//line 868
___nl__7 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__7.toString())).clone();
//line 868
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 868
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_26;}}
//line 869
___nl__10 = new ImmDouble(0).clone();
//line 869
___nl__9 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()].clone();
//line 869
___nl__10 = null;
//line 869
___ref______nl__3 = new ImmRef(___nl__3);
___ref______nl__5 = new ImmRef(___nl__5);
___nl__8 = ptd_system_NL.NL_can_delete(___nl__9,___ref______nl__3,___ref______nl__5).clone();
___nl__3 = ___ref______nl__3.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();

//line 869
___nl__9 = null;
//line 870
___nl__9 = ((ImmHash)___nl__8).getHashValue()["src"].clone();
//line 870
___nl__10 = ___nl__9.clone();
//line 870
((ImmHash)___nl__0).set("src", ___nl__10);
//line 870
___nl__9 = null;
//line 870
___nl__10 = null;
//line 871
___nl__9 = ((ImmHash)___nl__8).getHashValue()["type"].clone();
//line 871
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__9, new ImmString("tct_hash")).clone();
//line 871
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 871
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_28;}}
//line 871
___nl__11 = ((ImmHash)___nl__8).getHashValue()["type"].clone();
//line 871
___nl__11 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("tct_hash")).clone();
//line 871
___nl__10 = tct_NL.NL_tct_arr(___nl__11).clone();

//line 871
___nl__11 = null;
//line 871
___nl__11 = ___nl__10.clone();
//line 871
((ImmHash)___nl__0).set("type", ___nl__11);
//line 871
___nl__10 = null;
//line 871
___nl__11 = null;
//line 871
if (true) {goto label_28;}
//line 871
label_28:
//line 871
___nl__9 = null;
//line 871
___nl__8 = null;
//line 872
if (true) {goto label_26;}
//line 872
label_26:
//line 872
___nl__7 = null;
//line 873
___nl__7 = new ImmString("ov::as").clone();
//line 873
___nl__7 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__7.toString())).clone();
//line 873
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 873
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_30;}}
//line 874
___nl__8 = tct_NL.NL_tct_im().clone();

//line 874
___nl__10 = new ImmDouble(0).clone();
//line 874
___nl__9 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()].clone();
//line 874
___nl__10 = null;
//line 874
___ref______nl__3 = new ImmRef(___nl__3);
___ref______nl__5 = new ImmRef(___nl__5);
ptd_system_NL.NL_check_assignment(___nl__8,___nl__9,___ref______nl__3,___ref______nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();

//line 874
___nl__9 = null;
//line 874
___nl__8 = null;
//line 875
if (true) {goto label_30;}
//line 875
label_30:
//line 875
___nl__7 = null;
//line 876
___nl__7 = new ImmString("dfile::ssave").clone();
//line 876
___nl__7 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__7.toString())).clone();
//line 876
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 876
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_32;}}
//line 877
___nl__8 = tct_NL.NL_tct_im().clone();

//line 877
___nl__10 = new ImmDouble(0).clone();
//line 877
___nl__9 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()].clone();
//line 877
___nl__10 = null;
//line 877
___ref______nl__3 = new ImmRef(___nl__3);
___ref______nl__5 = new ImmRef(___nl__5);
ptd_system_NL.NL_check_assignment(___nl__8,___nl__9,___ref______nl__3,___ref______nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();

//line 877
___nl__9 = null;
//line 877
___nl__8 = null;
//line 878
if (true) {goto label_32;}
//line 878
label_32:
//line 878
___nl__7 = null;
//line 879
___nl__7 = new ImmString("singleton::sigleton_do_not_use_without_approval").clone();
//line 879
___nl__7 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__7.toString())).clone();
//line 879
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 879
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_34;}}
//line 880
___nl__9 = new ImmDouble(0).clone();
//line 880
___nl__8 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()].clone();
//line 880
___nl__9 = null;
//line 880
___nl__0 = null;
//line 880
___nl__1 = null;
//line 880
___nl__2 = null;
//line 880
___nl__6 = null;
//line 880
___nl__7 = null;
//line 880
___arg__3.setValue(___nl__3);___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__8;
//line 880
___nl__8 = null;
//line 881
if (true) {goto label_34;}
//line 881
label_34:
//line 881
___nl__7 = null;
//line 883
___nl__1 = null;
//line 883
___nl__2 = null;
//line 883
___nl__6 = null;
//line 883
___arg__3.setValue(___nl__3);___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__0;
//line 883
___nl__6 = null;
//line 883
___nl__0 = null;
//line 883
___nl__1 = null;
//line 883
___nl__2 = null;
//line 883
___arg__3.setValue(___nl__3);___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return null;
}

private static Imm NL_rec_get_var_from_lval_priv(Imm ___arg__0, ImmRef ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
ImmRef ___ref______nl__6 = null;
ImmRef ___ref______nl__7 = null;
Dictionary<String, Imm> __function_map;
//line 887
___nl__2 = new ImmArray(new Imm[0]).clone();
//line 888
___nl__4 = new ImmString("var").clone();
//line 888
___nl__3 = ov_NL.NL_is(___nl__0,___nl__4).clone();

//line 888
___nl__4 = null;
//line 888
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 888
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 889
___nl__4 = ___nl__0.clone();
//line 889
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("var")).clone();
//line 890
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("var"), ___nl__4).clone();
//line 890
___ref______nl__2 = new ImmRef(___nl__2);
array_NL.NL_push(___ref______nl__2,___nl__5);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 890
___nl__5 = null;
//line 890
___nl__4 = null;
//line 891
if (true) {goto label_1;}
//line 891
label_2:
//line 891
___nl__4 = new ImmString("bin_op").clone();
//line 891
___nl__3 = ov_NL.NL_is(___nl__0,___nl__4).clone();

//line 891
___nl__4 = null;
//line 891
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 891
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 892
___nl__4 = ___nl__0.clone();
//line 892
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("bin_op")).clone();
//line 893
___nl__5 = ((ImmHash)___nl__4).getHashValue()["op"].clone();
//line 893
___nl__6 = new ImmString("->").clone();
//line 893
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__5.toString().Equals(___nl__6.toString())).clone();
//line 893
___nl__6 = null;
//line 893
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 893
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_5;}}
//line 894
___nl__7 = ((ImmHash)___nl__4).getHashValue()["left"].clone();
//line 894
___ref______nl__1 = new ImmRef(___nl__1);
___nl__6 = type_checker_NL.NL_rec_get_var_from_lval_priv(___nl__7,___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 894
___nl__7 = null;
//line 894
___nl__2 = ___nl__6.clone();
//line 894
___nl__6 = null;
//line 895
___nl__6 = ((ImmHash)___nl__4).getHashValue()["right"].clone();
//line 895
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("hash_key")).clone();
//line 895
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("rec"), ___nl__6).clone();
//line 895
___ref______nl__2 = new ImmRef(___nl__2);
array_NL.NL_push(___ref______nl__2,___nl__6);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 895
___nl__6 = null;
//line 896
if (true) {goto label_4;}
//line 896
label_5:
//line 896
___nl__5 = ((ImmHash)___nl__4).getHashValue()["op"].clone();
//line 896
___nl__6 = new ImmString("ARRAY_INDEX").clone();
//line 896
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__5.toString().Equals(___nl__6.toString())).clone();
//line 896
___nl__6 = null;
//line 896
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 896
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_6;}}
//line 897
___nl__7 = ((ImmHash)___nl__4).getHashValue()["left"].clone();
//line 897
___ref______nl__1 = new ImmRef(___nl__1);
___nl__6 = type_checker_NL.NL_rec_get_var_from_lval_priv(___nl__7,___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 897
___nl__7 = null;
//line 897
___nl__2 = ___nl__6.clone();
//line 897
___nl__6 = null;
//line 898
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("arr")).clone();
//line 898
___ref______nl__2 = new ImmRef(___nl__2);
array_NL.NL_push(___ref______nl__2,___nl__6);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 898
___nl__6 = null;
//line 899
if (true) {goto label_4;}
//line 899
label_6:
//line 900
___nl__6 = new ImmString("invalid operator ").clone();
//line 900
___nl__7 = ((ImmHash)___nl__4).getHashValue()["op"].clone();
//line 900
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 900
___nl__7 = null;
//line 900
___nl__7 = new ImmString(" used in lvalue").clone();
//line 900
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 900
___nl__7 = null;
//line 900
___ref______nl__1 = new ImmRef(___nl__1);
type_checker_NL.NL_add_error_priv(___ref______nl__1,___nl__6);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 900
___nl__6 = null;
//line 901
if (true) {goto label_4;}
//line 901
label_4:
//line 901
___nl__5 = null;
//line 901
___nl__4 = null;
//line 903
if (true) {goto label_1;}
//line 903
label_3:
//line 904
___nl__4 = new ImmString("invalid type for lvalue").clone();
//line 904
___ref______nl__1 = new ImmRef(___nl__1);
type_checker_NL.NL_add_error_priv(___ref______nl__1,___nl__4);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 904
___nl__4 = null;
//line 905
if (true) {goto label_1;}
//line 905
label_1:
//line 905
___nl__3 = null;
//line 907
___nl__0 = null;
//line 907
___arg__1.setValue(___nl__1);if(true) return ___nl__2;
//line 907
___nl__2 = null;
//line 907
___nl__0 = null;
//line 907
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_mk_new_type_lval_priv(Imm ___arg__0, Imm ___arg__1, Imm ___arg__2, Imm ___arg__3, ImmRef ___arg__4, ImmRef ___arg__5) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();Imm ___nl__3 = ___arg__3.clone();Imm ___nl__4 = ___arg__4.getValue().clone();Imm ___nl__5 = ___arg__5.getValue().clone();
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
Imm ___nl__9 = null;
Imm ___nl__10 = null;
Imm ___nl__11 = null;
Imm ___nl__12 = null;
Imm ___nl__13 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
ImmRef ___ref______nl__6 = null;
ImmRef ___ref______nl__7 = null;
ImmRef ___ref______nl__8 = null;
ImmRef ___ref______nl__9 = null;
ImmRef ___ref______nl__10 = null;
ImmRef ___ref______nl__11 = null;
ImmRef ___ref______nl__12 = null;
ImmRef ___ref______nl__13 = null;
Dictionary<String, Imm> __function_map;
//line 912
___nl__7 = new ImmDouble(1).clone();
//line 912
___nl__8 = array_NL.NL_len(___nl__0).clone();

//line 912
___nl__9 = new ImmDouble(1).clone();
//line 912
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))-(Double.Parse(___nl__9.getValue().ToString()))).clone();
//line 912
___nl__9 = null;
//line 912
___nl__6 = array_NL.NL_subarray(___nl__0,___nl__7,___nl__8).clone();

//line 912
___nl__8 = null;
//line 912
___nl__7 = null;
//line 912
___nl__0 = ___nl__6.clone();
//line 912
___nl__6 = null;
//line 913
___nl__6 = array_NL.NL_len(___nl__0).clone();

//line 913
___nl__7 = new ImmDouble(0).clone();
//line 913
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__6.getValue().ToString())) ==((Double.Parse(___nl__7.getValue().ToString())))  ).clone();
//line 913
___nl__7 = null;
//line 913
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 913
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_2;}}
//line 914
___nl__7 = type_checker_NL.NL_is_known_priv(___nl__2).clone();

//line 914
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 914
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_4;}}
//line 915
___nl__9 = ((ImmHash)___nl__2).getHashValue()["type"].clone();
//line 915
___ref______nl__4 = new ImmRef(___nl__4);
___ref______nl__5 = new ImmRef(___nl__5);
___nl__8 = ptd_system_NL.NL_check_assignment(___nl__9,___nl__1,___ref______nl__4,___ref______nl__5).clone();
___nl__4 = ___ref______nl__4.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();

//line 915
___nl__9 = null;
//line 916
___nl__10 = new ImmString("err").clone();
//line 916
___nl__9 = ov_NL.NL_is(___nl__8,___nl__10).clone();

//line 916
___nl__10 = null;
//line 916
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 916
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_6;}}
//line 917
___nl__10 = new ImmString("invalid type in assignment: ").clone();
//line 917
___nl__11 = type_checker_NL.NL_get_print_check_info_priv(___nl__8).clone();

//line 917
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString()).clone();
//line 917
___nl__11 = null;
//line 917
___ref______nl__5 = new ImmRef(___nl__5);
type_checker_NL.NL_add_error_priv(___ref______nl__5,___nl__10);
___nl__5 = ___ref______nl__5.getValue().clone();

//line 917
___nl__10 = null;
//line 918
if (true) {goto label_6;}
//line 918
label_6:
//line 918
___nl__9 = null;
//line 919
___nl__9 = ((ImmHash)___nl__2).getHashValue()["type"].clone();
//line 919
___nl__0 = null;
//line 919
___nl__1 = null;
//line 919
___nl__2 = null;
//line 919
___nl__3 = null;
//line 919
___nl__6 = null;
//line 919
___nl__7 = null;
//line 919
___nl__8 = null;
//line 919
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__9;
//line 919
___nl__9 = null;
//line 919
___nl__8 = null;
//line 920
if (true) {goto label_3;}
//line 920
label_4:
//line 921
___nl__8 = tct_NL.NL_tct_im().clone();

//line 921
___ref______nl__4 = new ImmRef(___nl__4);
___ref______nl__5 = new ImmRef(___nl__5);
ptd_system_NL.NL_check_assignment(___nl__8,___nl__1,___ref______nl__4,___ref______nl__5);
___nl__4 = ___ref______nl__4.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();

//line 921
___nl__8 = null;
//line 922
___ref______nl__4 = new ImmRef(___nl__4);
___ref______nl__5 = new ImmRef(___nl__5);
___nl__8 = ptd_system_NL.NL_can_create(___nl__2,___ref______nl__4,___ref______nl__5).clone();
___nl__4 = ___ref______nl__4.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();

//line 922
___nl__2 = ___nl__8.clone();
//line 922
___nl__8 = null;
//line 923
___nl__9 = ((ImmHash)___nl__2).getHashValue()["type"].clone();
//line 923
___nl__8 = ptd_system_NL.NL_is_equal(___nl__9,___nl__3).clone();

//line 923
___nl__9 = null;
//line 923
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 923
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_8;}}
//line 923
___nl__9 = ((ImmHash)___nl__1).getHashValue()["type"].clone();
//line 923
___nl__0 = null;
//line 923
___nl__1 = null;
//line 923
___nl__2 = null;
//line 923
___nl__3 = null;
//line 923
___nl__6 = null;
//line 923
___nl__7 = null;
//line 923
___nl__8 = null;
//line 923
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__9;
//line 923
___nl__9 = null;
//line 923
if (true) {goto label_8;}
//line 923
label_8:
//line 923
___nl__8 = null;
//line 924
___nl__9 = ((ImmHash)___nl__2).getHashValue()["type"].clone();
//line 924
___nl__10 = ((ImmHash)___nl__1).getHashValue()["type"].clone();
//line 924
___ref______nl__4 = new ImmRef(___nl__4);
___ref______nl__5 = new ImmRef(___nl__5);
___nl__8 = ptd_system_NL.NL_cross_type(___nl__9,___nl__10,___ref______nl__4,___ref______nl__5).clone();
___nl__4 = ___ref______nl__4.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();

//line 924
___nl__10 = null;
//line 924
___nl__9 = null;
//line 924
___nl__0 = null;
//line 924
___nl__1 = null;
//line 924
___nl__2 = null;
//line 924
___nl__3 = null;
//line 924
___nl__6 = null;
//line 924
___nl__7 = null;
//line 924
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__8;
//line 924
___nl__8 = null;
//line 925
if (true) {goto label_3;}
//line 925
label_3:
//line 925
___nl__7 = null;
//line 926
if (true) {goto label_1;}
//line 926
label_2:
//line 927
___ref______nl__4 = new ImmRef(___nl__4);
___ref______nl__5 = new ImmRef(___nl__5);
___nl__7 = ptd_system_NL.NL_can_create(___nl__2,___ref______nl__4,___ref______nl__5).clone();
___nl__4 = ___ref______nl__4.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();

//line 927
___nl__2 = ___nl__7.clone();
//line 927
___nl__7 = null;
//line 928
___nl__8 = new ImmDouble(0).clone();
//line 928
___nl__7 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()].clone();
//line 928
___nl__8 = null;
//line 928
___nl__8 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("var")).clone();
//line 928
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_10;}}
//line 930
___nl__8 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("arr")).clone();
//line 930
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_11;}}
//line 934
___nl__8 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("rec")).clone();
//line 934
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_12;}}
//line 934
___nl__8 = new ImmString("NOMATCHALERT").clone();
//line 934
___nl__8 = new ImmArray(new Imm[] {___nl__8,___nl__7,}).clone();
//line 934
c_rt_lib_NL.NL_die();
//line 928
label_10:
//line 928
___nl__9 = c_rt_lib_NL.NL_ov_as(___nl__7, new ImmString("var")).clone();
//line 929
___nl__10 = new ImmArray(new Imm[] {___nl__0,}).clone();
//line 929
c_rt_lib_NL.NL_die();
//line 929
___nl__10 = null;
//line 929
___nl__9 = null;
//line 930
if (true) {goto label_9;}
//line 930
label_11:
//line 931
___nl__10 = ((ImmHash)___nl__2).getHashValue()["type"].clone();
//line 931
___nl__11 = new ImmString("tct_arr").clone();
//line 931
___nl__9 = ov_NL.NL_is(___nl__10,___nl__11).clone();

//line 931
___nl__11 = null;
//line 931
___nl__10 = null;
//line 931
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 931
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 931
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_14;}}
//line 931
___nl__10 = tct_NL.NL_tct_im().clone();

//line 931
___nl__0 = null;
//line 931
___nl__1 = null;
//line 931
___nl__2 = null;
//line 931
___nl__3 = null;
//line 931
___nl__6 = null;
//line 931
___nl__7 = null;
//line 931
___nl__8 = null;
//line 931
___nl__9 = null;
//line 931
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__10;
//line 931
___nl__10 = null;
//line 931
if (true) {goto label_14;}
//line 931
label_14:
//line 931
___nl__9 = null;
//line 932
___nl__9 = ((ImmHash)___nl__2).getHashValue()["type"].clone();
//line 932
___nl__9 = c_rt_lib_NL.NL_ov_as(___nl__9, new ImmString("tct_arr")).clone();
//line 932
___nl__10 = ___nl__9.clone();
//line 932
((ImmHash)___nl__2).set("type", ___nl__10);
//line 932
___nl__9 = null;
//line 932
___nl__10 = null;
//line 933
___ref______nl__4 = new ImmRef(___nl__4);
___ref______nl__5 = new ImmRef(___nl__5);
___nl__10 = type_checker_NL.NL_mk_new_type_lval_priv(___nl__0,___nl__1,___nl__2,___nl__3,___ref______nl__4,___ref______nl__5).clone();
___nl__4 = ___ref______nl__4.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();

//line 933
___nl__9 = tct_NL.NL_tct_arr(___nl__10).clone();

//line 933
___nl__10 = null;
//line 933
___nl__0 = null;
//line 933
___nl__1 = null;
//line 933
___nl__2 = null;
//line 933
___nl__3 = null;
//line 933
___nl__6 = null;
//line 933
___nl__7 = null;
//line 933
___nl__8 = null;
//line 933
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__9;
//line 933
___nl__9 = null;
//line 934
if (true) {goto label_9;}
//line 934
label_12:
//line 934
___nl__9 = c_rt_lib_NL.NL_ov_as(___nl__7, new ImmString("rec")).clone();
//line 935
___nl__11 = ((ImmHash)___nl__2).getHashValue()["type"].clone();
//line 935
___nl__12 = new ImmString("tct_rec").clone();
//line 935
___nl__10 = ov_NL.NL_is(___nl__11,___nl__12).clone();

//line 935
___nl__12 = null;
//line 935
___nl__11 = null;
//line 935
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 935
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 935
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_16;}}
//line 935
___nl__11 = tct_NL.NL_tct_im().clone();

//line 935
___nl__0 = null;
//line 935
___nl__1 = null;
//line 935
___nl__2 = null;
//line 935
___nl__3 = null;
//line 935
___nl__6 = null;
//line 935
___nl__7 = null;
//line 935
___nl__8 = null;
//line 935
___nl__9 = null;
//line 935
___nl__10 = null;
//line 935
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__11;
//line 935
___nl__11 = null;
//line 935
if (true) {goto label_16;}
//line 935
label_16:
//line 935
___nl__10 = null;
//line 936
___nl__10 = ((ImmHash)___nl__2).getHashValue()["type"].clone();
//line 936
___nl__10 = c_rt_lib_NL.NL_ov_as(___nl__10, new ImmString("tct_rec")).clone();
//line 937
___nl__11 = hash_NL.NL_has_key(___nl__10,___nl__9).clone();

//line 937
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 937
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_18;}}
//line 938
___nl__12 = hash_NL.NL_get_value(___nl__10,___nl__9).clone();

//line 938
___nl__13 = ___nl__12.clone();
//line 938
((ImmHash)___nl__2).set("type", ___nl__13);
//line 938
___nl__12 = null;
//line 938
___nl__13 = null;
//line 939
___ref______nl__4 = new ImmRef(___nl__4);
___ref______nl__5 = new ImmRef(___nl__5);
___nl__12 = type_checker_NL.NL_mk_new_type_lval_priv(___nl__0,___nl__1,___nl__2,___nl__3,___ref______nl__4,___ref______nl__5).clone();
___nl__4 = ___ref______nl__4.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();

//line 939
___ref______nl__10 = new ImmRef(___nl__10);
hash_NL.NL_set_value(___ref______nl__10,___nl__9,___nl__12);
___nl__10 = ___ref______nl__10.getValue().clone();

//line 939
___nl__12 = null;
//line 940
if (true) {goto label_17;}
//line 940
label_18:
//line 941
___nl__12 = array_NL.NL_len(___nl__0).clone();

//line 941
___nl__13 = new ImmDouble(1).clone();
//line 941
___nl__12 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__12.getValue().ToString())) !=((Double.Parse(___nl__13.getValue().ToString())))  ).clone();
//line 941
___nl__13 = null;
//line 941
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 941
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_20;}}
//line 942
___nl__13 = tct_NL.NL_tct_im().clone();

//line 942
___nl__0 = null;
//line 942
___nl__1 = null;
//line 942
___nl__2 = null;
//line 942
___nl__3 = null;
//line 942
___nl__6 = null;
//line 942
___nl__7 = null;
//line 942
___nl__8 = null;
//line 942
___nl__9 = null;
//line 942
___nl__10 = null;
//line 942
___nl__11 = null;
//line 942
___nl__12 = null;
//line 942
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__13;
//line 942
___nl__13 = null;
//line 943
if (true) {goto label_20;}
//line 943
label_20:
//line 943
___nl__12 = null;
//line 944
___nl__12 = tct_NL.NL_tct_im().clone();

//line 944
___ref______nl__4 = new ImmRef(___nl__4);
___ref______nl__5 = new ImmRef(___nl__5);
ptd_system_NL.NL_check_assignment(___nl__12,___nl__1,___ref______nl__4,___ref______nl__5);
___nl__4 = ___ref______nl__4.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();

//line 944
___nl__12 = null;
//line 945
___nl__12 = ((ImmHash)___nl__1).getHashValue()["type"].clone();
//line 945
___ref______nl__10 = new ImmRef(___nl__10);
hash_NL.NL_set_value(___ref______nl__10,___nl__9,___nl__12);
___nl__10 = ___ref______nl__10.getValue().clone();

//line 945
___nl__12 = null;
//line 946
if (true) {goto label_17;}
//line 946
label_17:
//line 946
___nl__11 = null;
//line 948
___nl__11 = tct_NL.NL_tct_rec(___nl__10).clone();

//line 948
___nl__0 = null;
//line 948
___nl__1 = null;
//line 948
___nl__2 = null;
//line 948
___nl__3 = null;
//line 948
___nl__6 = null;
//line 948
___nl__7 = null;
//line 948
___nl__8 = null;
//line 948
___nl__9 = null;
//line 948
___nl__10 = null;
//line 948
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__11;
//line 948
___nl__11 = null;
//line 948
___nl__10 = null;
//line 948
___nl__9 = null;
//line 949
if (true) {goto label_9;}
//line 949
label_9:
//line 949
___nl__7 = null;
//line 949
___nl__8 = null;
//line 950
if (true) {goto label_1;}
//line 950
label_1:
//line 950
___nl__6 = null;
//line 950
___nl__0 = null;
//line 950
___nl__1 = null;
//line 950
___nl__2 = null;
//line 950
___nl__3 = null;
//line 950
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return null;
}

private static Imm NL_set_type_to_lval_priv(Imm ___arg__0, Imm ___arg__1, Imm ___arg__2, ImmRef ___arg__3, ImmRef ___arg__4, ImmRef ___arg__5) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();Imm ___nl__3 = ___arg__3.getValue().clone();Imm ___nl__4 = ___arg__4.getValue().clone();Imm ___nl__5 = ___arg__5.getValue().clone();
Imm ___nl__6 = null;
Imm ___nl__7 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
ImmRef ___ref______nl__6 = null;
ImmRef ___ref______nl__7 = null;
Dictionary<String, Imm> __function_map;
//line 954
___nl__7 = ((ImmHash)___nl__1).getHashValue()["type"].clone();
//line 954
___ref______nl__3 = new ImmRef(___nl__3);
___ref______nl__4 = new ImmRef(___nl__4);
___ref______nl__5 = new ImmRef(___nl__5);
___nl__6 = type_checker_NL.NL_set_type_to_lval_spec_priv(___nl__0,___nl__1,___nl__2,___nl__7,___ref______nl__3,___ref______nl__4,___ref______nl__5).clone();
___nl__3 = ___ref______nl__3.getValue().clone();
___nl__4 = ___ref______nl__4.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();

//line 954
___nl__7 = null;
//line 954
___nl__0 = null;
//line 954
___nl__1 = null;
//line 954
___nl__2 = null;
//line 954
___arg__3.setValue(___nl__3);___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__6;
//line 954
___nl__6 = null;
//line 954
___nl__0 = null;
//line 954
___nl__1 = null;
//line 954
___nl__2 = null;
//line 954
___arg__3.setValue(___nl__3);___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return null;
}

private static Imm NL_set_type_to_lval_spec_priv(Imm ___arg__0, Imm ___arg__1, Imm ___arg__2, Imm ___arg__3, ImmRef ___arg__4, ImmRef ___arg__5, ImmRef ___arg__6) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();Imm ___nl__3 = ___arg__3.clone();Imm ___nl__4 = ___arg__4.getValue().clone();Imm ___nl__5 = ___arg__5.getValue().clone();Imm ___nl__6 = ___arg__6.getValue().clone();
Imm ___nl__7 = null;
Imm ___nl__8 = null;
Imm ___nl__9 = null;
Imm ___nl__10 = null;
Imm ___nl__11 = null;
Imm ___nl__12 = null;
Imm ___nl__13 = null;
Imm ___nl__14 = null;
Imm ___nl__15 = null;
Imm ___nl__16 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
ImmRef ___ref______nl__6 = null;
ImmRef ___ref______nl__7 = null;
ImmRef ___ref______nl__8 = null;
ImmRef ___ref______nl__9 = null;
ImmRef ___ref______nl__10 = null;
ImmRef ___ref______nl__11 = null;
ImmRef ___ref______nl__12 = null;
ImmRef ___ref______nl__13 = null;
ImmRef ___ref______nl__14 = null;
ImmRef ___ref______nl__15 = null;
ImmRef ___ref______nl__16 = null;
Dictionary<String, Imm> __function_map;
//line 959
___nl__8 = ((ImmHash)___nl__6).getHashValue()["errors"].clone();
//line 959
___nl__7 = array_NL.NL_len(___nl__8).clone();

//line 959
___nl__8 = null;
//line 960
___ref______nl__6 = new ImmRef(___nl__6);
___nl__8 = type_checker_NL.NL_rec_get_var_from_lval_priv(___nl__0,___ref______nl__6).clone();
___nl__6 = ___ref______nl__6.getValue().clone();

//line 961
___nl__10 = ((ImmHash)___nl__6).getHashValue()["errors"].clone();
//line 961
___nl__9 = array_NL.NL_len(___nl__10).clone();

//line 961
___nl__10 = null;
//line 961
___nl__9 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString())) !=((Double.Parse(___nl__9.getValue().ToString())))  ).clone();
//line 961
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 961
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_2;}}
//line 961
___nl__0 = null;
//line 961
___nl__2 = null;
//line 961
___nl__3 = null;
//line 961
___nl__7 = null;
//line 961
___nl__8 = null;
//line 961
___nl__9 = null;
//line 961
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);___arg__6.setValue(___nl__6);if(true) return ___nl__1;
//line 961
if (true) {goto label_2;}
//line 961
label_2:
//line 961
___nl__9 = null;
//line 962
___nl__11 = new ImmDouble(0).clone();
//line 962
___nl__10 = (___nl__8 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__11).getDoubleValue()].clone();
//line 962
___nl__11 = null;
//line 962
___nl__11 = new ImmString("var").clone();
//line 962
___nl__9 = ov_NL.NL_as(___nl__10,___nl__11).clone();

//line 962
___nl__11 = null;
//line 962
___nl__10 = null;
//line 963
___nl__10 = hash_NL.NL_has_key(___nl__5,___nl__9).clone();

//line 963
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 963
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 963
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_4;}}
//line 964
___nl__11 = new ImmString("variable ").clone();
//line 964
___nl__11 = new ImmString(___nl__11.toString() + ___nl__9.toString()).clone();
//line 964
___nl__12 = new ImmString(" dont exist").clone();
//line 964
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString()).clone();
//line 964
___nl__12 = null;
//line 964
___ref______nl__6 = new ImmRef(___nl__6);
type_checker_NL.NL_add_error_priv(___ref______nl__6,___nl__11);
___nl__6 = ___ref______nl__6.getValue().clone();

//line 964
___nl__11 = null;
//line 965
___nl__0 = null;
//line 965
___nl__2 = null;
//line 965
___nl__3 = null;
//line 965
___nl__7 = null;
//line 965
___nl__8 = null;
//line 965
___nl__9 = null;
//line 965
___nl__10 = null;
//line 965
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);___arg__6.setValue(___nl__6);if(true) return ___nl__1;
//line 966
if (true) {goto label_4;}
//line 966
label_4:
//line 966
___nl__10 = null;
//line 967
___nl__10 = hash_NL.NL_get_value(___nl__5,___nl__9).clone();

//line 968
___nl__11 = ((ImmHash)___nl__10).getHashValue()["overwrited"].clone();
//line 968
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("yes")).clone();
//line 968
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_6;}}
//line 972
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("no")).clone();
//line 972
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_7;}}
//line 972
___nl__12 = new ImmString("NOMATCHALERT").clone();
//line 972
___nl__12 = new ImmArray(new Imm[] {___nl__12,___nl__11,}).clone();
//line 972
c_rt_lib_NL.NL_die();
//line 968
label_6:
//line 969
___nl__15 = ((ImmHash)___nl__10).getHashValue()["type"].clone();
//line 969
___nl__16 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("speculation")).clone();
//line 969
__function_map = new Dictionary<String, Imm>();
__function_map.Add("type",___nl__15);
__function_map.Add("src",___nl__16);
___nl__14 = new ImmHash(__function_map).clone();
//line 969
___nl__15 = null;
//line 969
___nl__16 = null;
//line 969
___ref______nl__4 = new ImmRef(___nl__4);
___ref______nl__6 = new ImmRef(___nl__6);
___nl__13 = type_checker_NL.NL_mk_new_type_lval_priv(___nl__8,___nl__2,___nl__14,___nl__3,___ref______nl__4,___ref______nl__6).clone();
___nl__4 = ___ref______nl__4.getValue().clone();
___nl__6 = ___ref______nl__6.getValue().clone();

//line 969
___nl__14 = null;
//line 970
___nl__15 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("yes")).clone();
//line 970
__function_map = new Dictionary<String, Imm>();
__function_map.Add("overwrited",___nl__15);
__function_map.Add("type",___nl__13);
___nl__14 = new ImmHash(__function_map).clone();
//line 970
___nl__15 = null;
//line 970
___ref______nl__5 = new ImmRef(___nl__5);
hash_NL.NL_set_value(___ref______nl__5,___nl__9,___nl__14);
___nl__5 = ___ref______nl__5.getValue().clone();

//line 970
___nl__14 = null;
//line 971
___nl__0 = null;
//line 971
___nl__1 = null;
//line 971
___nl__3 = null;
//line 971
___nl__7 = null;
//line 971
___nl__8 = null;
//line 971
___nl__9 = null;
//line 971
___nl__10 = null;
//line 971
___nl__11 = null;
//line 971
___nl__12 = null;
//line 971
___nl__13 = null;
//line 971
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);___arg__6.setValue(___nl__6);if(true) return ___nl__2;
//line 971
___nl__13 = null;
//line 972
if (true) {goto label_5;}
//line 972
label_7:
//line 973
___nl__14 = ((ImmHash)___nl__10).getHashValue()["type"].clone();
//line 973
___nl__15 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("known")).clone();
//line 973
__function_map = new Dictionary<String, Imm>();
__function_map.Add("type",___nl__14);
__function_map.Add("src",___nl__15);
___nl__13 = new ImmHash(__function_map).clone();
//line 973
___nl__14 = null;
//line 973
___nl__15 = null;
//line 973
___ref______nl__4 = new ImmRef(___nl__4);
___ref______nl__6 = new ImmRef(___nl__6);
type_checker_NL.NL_mk_new_type_lval_priv(___nl__8,___nl__2,___nl__13,___nl__3,___ref______nl__4,___ref______nl__6);
___nl__4 = ___ref______nl__4.getValue().clone();
___nl__6 = ___ref______nl__6.getValue().clone();

//line 973
___nl__13 = null;
//line 974
___nl__0 = null;
//line 974
___nl__2 = null;
//line 974
___nl__3 = null;
//line 974
___nl__7 = null;
//line 974
___nl__8 = null;
//line 974
___nl__9 = null;
//line 974
___nl__10 = null;
//line 974
___nl__11 = null;
//line 974
___nl__12 = null;
//line 974
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);___arg__6.setValue(___nl__6);if(true) return ___nl__1;
//line 975
if (true) {goto label_5;}
//line 975
label_5:
//line 975
___nl__11 = null;
//line 975
___nl__12 = null;
//line 975
___nl__7 = null;
//line 975
___nl__8 = null;
//line 975
___nl__9 = null;
//line 975
___nl__10 = null;
//line 975
___nl__0 = null;
//line 975
___nl__1 = null;
//line 975
___nl__2 = null;
//line 975
___nl__3 = null;
//line 975
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);___arg__6.setValue(___nl__6);if(true) return null;
}

private static Imm NL_get_type_left_site_equation_priv(Imm ___arg__0, ImmRef ___arg__1, ImmRef ___arg__2, ImmRef ___arg__3) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();Imm ___nl__2 = ___arg__2.getValue().clone();Imm ___nl__3 = ___arg__3.getValue().clone();
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
ImmRef ___ref______nl__6 = null;
Dictionary<String, Imm> __function_map;
//line 980
___nl__6 = new ImmString("bin_op").clone();
//line 980
___nl__4 = ov_NL.NL_is(___nl__0,___nl__6).clone();

//line 980
___nl__6 = null;
//line 980
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 980
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_3;}}
//line 980
___nl__4 = ___nl__0.clone();
//line 980
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("bin_op")).clone();
//line 980
___nl__4 = ((ImmHash)___nl__4).getHashValue()["op"].clone();
//line 980
___nl__6 = new ImmString("->").clone();
//line 980
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__4.toString().Equals(___nl__6.toString())).clone();
//line 980
___nl__6 = null;
//line 980
label_3:
//line 980
___nl__5 = null;
//line 980
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 980
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 981
___nl__6 = ___nl__0.clone();
//line 981
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("bin_op")).clone();
//line 981
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__5 = type_checker_NL.NL_get_type_record_key_priv(___nl__6,___ref______nl__1,___ref______nl__2,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 981
___nl__6 = null;
//line 981
___nl__0 = null;
//line 981
___nl__4 = null;
//line 981
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__5;
//line 981
___nl__5 = null;
//line 982
if (true) {goto label_1;}
//line 982
label_2:
//line 983
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__5 = type_checker_NL.NL_check_val_priv(___nl__0,___ref______nl__1,___ref______nl__2,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 983
___nl__0 = null;
//line 983
___nl__4 = null;
//line 983
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__5;
//line 983
___nl__5 = null;
//line 984
if (true) {goto label_1;}
//line 984
label_1:
//line 984
___nl__4 = null;
//line 984
___nl__0 = null;
//line 984
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return null;
}

private static Imm NL_get_type_record_key_priv(Imm ___arg__0, ImmRef ___arg__1, ImmRef ___arg__2, ImmRef ___arg__3) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();Imm ___nl__2 = ___arg__2.getValue().clone();Imm ___nl__3 = ___arg__3.getValue().clone();
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
Imm ___nl__9 = null;
Imm ___nl__10 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
ImmRef ___ref______nl__6 = null;
ImmRef ___ref______nl__7 = null;
ImmRef ___ref______nl__8 = null;
ImmRef ___ref______nl__9 = null;
ImmRef ___ref______nl__10 = null;
Dictionary<String, Imm> __function_map;
//line 988
___nl__5 = ((ImmHash)___nl__0).getHashValue()["left"].clone();
//line 988
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__4 = type_checker_NL.NL_check_val_priv(___nl__5,___ref______nl__1,___ref______nl__2,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 988
___nl__5 = null;
//line 989
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__5 = ptd_system_NL.NL_can_delete(___nl__4,___ref______nl__1,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 989
___nl__4 = ___nl__5.clone();
//line 989
___nl__5 = null;
//line 990
___nl__5 = ((ImmHash)___nl__4).getHashValue()["type"].clone();
//line 990
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("tct_rec")).clone();
//line 990
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 990
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_2;}}
//line 991
___nl__6 = ((ImmHash)___nl__4).getHashValue()["type"].clone();
//line 991
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("tct_rec")).clone();
//line 992
___nl__7 = ((ImmHash)___nl__0).getHashValue()["right"].clone();
//line 992
___nl__7 = c_rt_lib_NL.NL_ov_as(___nl__7, new ImmString("hash_key")).clone();
//line 993
___nl__8 = hash_NL.NL_has_key(___nl__6,___nl__7).clone();

//line 993
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 993
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 993
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_4;}}
//line 994
___nl__9 = type_checker_NL.NL_is_known_priv(___nl__4).clone();

//line 994
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 994
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_6;}}
//line 994
___nl__10 = new ImmString("unknown record key: ").clone();
//line 994
___nl__10 = new ImmString(___nl__10.toString() + ___nl__7.toString()).clone();
//line 994
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__10);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 994
___nl__10 = null;
//line 994
if (true) {goto label_6;}
//line 994
label_6:
//line 994
___nl__9 = null;
//line 995
___nl__9 = tct_NL.NL_tct_im().clone();

//line 995
___nl__10 = ___nl__9.clone();
//line 995
((ImmHash)___nl__4).set("type", ___nl__10);
//line 995
___nl__9 = null;
//line 995
___nl__10 = null;
//line 996
___nl__0 = null;
//line 996
___nl__5 = null;
//line 996
___nl__6 = null;
//line 996
___nl__7 = null;
//line 996
___nl__8 = null;
//line 996
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__4;
//line 997
if (true) {goto label_4;}
//line 997
label_4:
//line 997
___nl__8 = null;
//line 998
___nl__8 = hash_NL.NL_get_value(___nl__6,___nl__7).clone();

//line 998
___nl__9 = ___nl__8.clone();
//line 998
((ImmHash)___nl__4).set("type", ___nl__9);
//line 998
___nl__8 = null;
//line 998
___nl__9 = null;
//line 999
___nl__0 = null;
//line 999
___nl__5 = null;
//line 999
___nl__6 = null;
//line 999
___nl__7 = null;
//line 999
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__4;
//line 999
___nl__6 = null;
//line 999
___nl__7 = null;
//line 1000
if (true) {goto label_2;}
//line 1000
label_2:
//line 1000
___nl__5 = null;
//line 1001
___nl__5 = ((ImmHash)___nl__4).getHashValue()["type"].clone();
//line 1001
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("tct_hash")).clone();
//line 1001
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 1001
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_8;}}
//line 1002
___nl__6 = ((ImmHash)___nl__4).getHashValue()["type"].clone();
//line 1002
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("tct_hash")).clone();
//line 1002
___nl__7 = ___nl__6.clone();
//line 1002
((ImmHash)___nl__4).set("type", ___nl__7);
//line 1002
___nl__6 = null;
//line 1002
___nl__7 = null;
//line 1003
___nl__0 = null;
//line 1003
___nl__5 = null;
//line 1003
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__4;
//line 1004
if (true) {goto label_8;}
//line 1004
label_8:
//line 1004
___nl__5 = null;
//line 1005
__function_map = new Dictionary<String, Imm>();
___nl__7 = new ImmHash(__function_map).clone();
//line 1005
___nl__6 = tct_NL.NL_tct_rec(___nl__7).clone();

//line 1005
___nl__7 = null;
//line 1005
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__5 = ptd_system_NL.NL_is_accepted(___nl__4,___nl__6,___ref______nl__1,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 1005
___nl__6 = null;
//line 1005
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 1005
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 1005
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_10;}}
//line 1006
___nl__6 = new ImmString("binary operator -> can be applied only to record : ").clone();
//line 1006
___nl__8 = ((ImmHash)___nl__4).getHashValue()["type"].clone();
//line 1006
___nl__7 = type_checker_NL.NL_get_print_tct_type_name_priv(___nl__8).clone();

//line 1006
___nl__8 = null;
//line 1006
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 1006
___nl__7 = null;
//line 1006
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__6);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 1006
___nl__6 = null;
//line 1008
if (true) {goto label_10;}
//line 1008
label_10:
//line 1008
___nl__5 = null;
//line 1009
___nl__5 = tct_NL.NL_tct_im().clone();

//line 1009
___nl__6 = ___nl__5.clone();
//line 1009
((ImmHash)___nl__4).set("type", ___nl__6);
//line 1009
___nl__5 = null;
//line 1009
___nl__6 = null;
//line 1010
___nl__0 = null;
//line 1010
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__4;
//line 1010
___nl__4 = null;
//line 1010
___nl__0 = null;
//line 1010
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return null;
}

private static Imm NL_get_type_from_bin_op_and_check_priv(Imm ___arg__0, ImmRef ___arg__1, ImmRef ___arg__2, ImmRef ___arg__3) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();Imm ___nl__2 = ___arg__2.getValue().clone();Imm ___nl__3 = ___arg__3.getValue().clone();
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
Imm ___nl__9 = null;
Imm ___nl__10 = null;
Imm ___nl__11 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
ImmRef ___ref______nl__6 = null;
ImmRef ___ref______nl__7 = null;
ImmRef ___ref______nl__8 = null;
ImmRef ___ref______nl__9 = null;
ImmRef ___ref______nl__10 = null;
ImmRef ___ref______nl__11 = null;
Dictionary<String, Imm> __function_map;
//line 1014
___nl__4 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 1015
___nl__6 = ((ImmHash)___nl__0).getHashValue()["right"].clone();
//line 1015
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__5 = type_checker_NL.NL_check_val_priv(___nl__6,___ref______nl__1,___ref______nl__2,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 1015
___nl__6 = null;
//line 1016
___nl__6 = new ImmString("=").clone();
//line 1016
___nl__6 = c_rt_lib_NL.NL_native_to_nl(___nl__4.toString().Equals(___nl__6.toString())).clone();
//line 1016
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 1016
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_2;}}
//line 1017
___nl__8 = ((ImmHash)___nl__5).getHashValue()["type"].clone();
//line 1017
___nl__9 = new ImmString("tct_void").clone();
//line 1017
___nl__7 = ov_NL.NL_is(___nl__8,___nl__9).clone();

//line 1017
___nl__9 = null;
//line 1017
___nl__8 = null;
//line 1017
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 1017
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_4;}}
//line 1018
___nl__8 = new ImmString("cannot use 'void' type returned from function as value").clone();
//line 1018
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__8);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 1018
___nl__8 = null;
//line 1019
___nl__9 = tct_NL.NL_tct_im().clone();

//line 1019
___nl__10 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("speculation")).clone();
//line 1019
__function_map = new Dictionary<String, Imm>();
__function_map.Add("type",___nl__9);
__function_map.Add("src",___nl__10);
___nl__8 = new ImmHash(__function_map).clone();
//line 1019
___nl__9 = null;
//line 1019
___nl__10 = null;
//line 1019
___nl__0 = null;
//line 1019
___nl__4 = null;
//line 1019
___nl__5 = null;
//line 1019
___nl__6 = null;
//line 1019
___nl__7 = null;
//line 1019
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__8;
//line 1019
___nl__8 = null;
//line 1020
if (true) {goto label_4;}
//line 1020
label_4:
//line 1020
___nl__7 = null;
//line 1021
___nl__8 = ((ImmHash)___nl__3).getHashValue()["errors"].clone();
//line 1021
___nl__7 = array_NL.NL_len(___nl__8).clone();

//line 1021
___nl__8 = null;
//line 1022
___nl__9 = ((ImmHash)___nl__0).getHashValue()["left"].clone();
//line 1022
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__8 = type_checker_NL.NL_get_type_left_site_equation_priv(___nl__9,___ref______nl__1,___ref______nl__2,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 1022
___nl__9 = null;
//line 1023
___nl__10 = ((ImmHash)___nl__3).getHashValue()["errors"].clone();
//line 1023
___nl__9 = array_NL.NL_len(___nl__10).clone();

//line 1023
___nl__10 = null;
//line 1023
___nl__9 = new ImmDouble((Double.Parse(___nl__9.getValue().ToString()))-(Double.Parse(___nl__7.getValue().ToString()))).clone();
//line 1023
___nl__10 = new ImmDouble(0).clone();
//line 1023
___nl__9 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__9.getValue().ToString()))>(Double.Parse(___nl__10.getValue().ToString())) ).clone();
//line 1023
___nl__10 = null;
//line 1023
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 1023
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_6;}}
//line 1023
___nl__0 = null;
//line 1023
___nl__4 = null;
//line 1023
___nl__5 = null;
//line 1023
___nl__6 = null;
//line 1023
___nl__7 = null;
//line 1023
___nl__9 = null;
//line 1023
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__8;
//line 1023
if (true) {goto label_6;}
//line 1023
label_6:
//line 1023
___nl__9 = null;
//line 1024
___nl__10 = ((ImmHash)___nl__0).getHashValue()["left"].clone();
//line 1024
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__9 = type_checker_NL.NL_set_type_to_lval_priv(___nl__10,___nl__8,___nl__5,___ref______nl__1,___ref______nl__2,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 1024
___nl__10 = null;
//line 1024
___nl__0 = null;
//line 1024
___nl__4 = null;
//line 1024
___nl__5 = null;
//line 1024
___nl__6 = null;
//line 1024
___nl__7 = null;
//line 1024
___nl__8 = null;
//line 1024
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__9;
//line 1024
___nl__9 = null;
//line 1024
___nl__7 = null;
//line 1024
___nl__8 = null;
//line 1025
if (true) {goto label_2;}
//line 1025
label_2:
//line 1025
___nl__6 = null;
//line 1027
___nl__8 = ((ImmHash)___nl__0).getHashValue()["left"].clone();
//line 1027
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__7 = type_checker_NL.NL_check_val_priv(___nl__8,___ref______nl__1,___ref______nl__2,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 1027
___nl__8 = null;
//line 1027
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__6 = ptd_system_NL.NL_can_delete(___nl__7,___ref______nl__1,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 1027
___nl__7 = null;
//line 1029
___nl__8 = tct_NL.NL_tct_im().clone();

//line 1029
___nl__9 = ((ImmHash)___nl__6).getHashValue()["src"].clone();
//line 1029
__function_map = new Dictionary<String, Imm>();
__function_map.Add("type",___nl__8);
__function_map.Add("src",___nl__9);
___nl__7 = new ImmHash(__function_map).clone();
//line 1029
___nl__8 = null;
//line 1029
___nl__9 = null;
//line 1030
___nl__8 = new ImmString("->").clone();
//line 1030
___nl__8 = c_rt_lib_NL.NL_native_to_nl(___nl__4.toString().Equals(___nl__8.toString())).clone();
//line 1030
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 1030
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_8;}}
//line 1031
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__9 = type_checker_NL.NL_get_type_record_key_priv(___nl__0,___ref______nl__1,___ref______nl__2,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 1031
___nl__0 = null;
//line 1031
___nl__4 = null;
//line 1031
___nl__5 = null;
//line 1031
___nl__6 = null;
//line 1031
___nl__7 = null;
//line 1031
___nl__8 = null;
//line 1031
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__9;
//line 1031
___nl__9 = null;
//line 1032
if (true) {goto label_8;}
//line 1032
label_8:
//line 1032
___nl__8 = null;
//line 1034
___nl__8 = new ImmString("ARRAY_INDEX").clone();
//line 1034
___nl__8 = c_rt_lib_NL.NL_native_to_nl(___nl__4.toString().Equals(___nl__8.toString())).clone();
//line 1034
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 1034
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_10;}}
//line 1035
___nl__11 = tct_NL.NL_tct_im().clone();

//line 1035
___nl__10 = tct_NL.NL_tct_arr(___nl__11).clone();

//line 1035
___nl__11 = null;
//line 1035
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__9 = ptd_system_NL.NL_is_accepted(___nl__6,___nl__10,___ref______nl__1,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 1035
___nl__10 = null;
//line 1035
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 1035
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 1035
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_12;}}
//line 1036
___nl__10 = new ImmString("array operator '[]' can be applied only to array").clone();
//line 1036
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__10);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 1036
___nl__10 = null;
//line 1037
___nl__0 = null;
//line 1037
___nl__4 = null;
//line 1037
___nl__5 = null;
//line 1037
___nl__6 = null;
//line 1037
___nl__8 = null;
//line 1037
___nl__9 = null;
//line 1037
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__7;
//line 1038
if (true) {goto label_12;}
//line 1038
label_12:
//line 1038
___nl__9 = null;
//line 1039
___nl__10 = tct_NL.NL_tct_sim().clone();

//line 1039
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__9 = ptd_system_NL.NL_is_accepted(___nl__5,___nl__10,___ref______nl__1,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 1039
___nl__10 = null;
//line 1039
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 1039
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 1039
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_14;}}
//line 1040
___nl__10 = new ImmString("array index should be number").clone();
//line 1040
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__10);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 1040
___nl__10 = null;
//line 1041
if (true) {goto label_14;}
//line 1041
label_14:
//line 1041
___nl__9 = null;
//line 1042
___nl__9 = ((ImmHash)___nl__6).getHashValue()["type"].clone();
//line 1042
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__9, new ImmString("tct_arr")).clone();
//line 1042
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 1042
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_16;}}
//line 1042
___nl__10 = ((ImmHash)___nl__6).getHashValue()["type"].clone();
//line 1042
___nl__10 = c_rt_lib_NL.NL_ov_as(___nl__10, new ImmString("tct_arr")).clone();
//line 1042
___nl__11 = ___nl__10.clone();
//line 1042
((ImmHash)___nl__6).set("type", ___nl__11);
//line 1042
___nl__10 = null;
//line 1042
___nl__11 = null;
//line 1042
if (true) {goto label_16;}
//line 1042
label_16:
//line 1042
___nl__9 = null;
//line 1043
___nl__0 = null;
//line 1043
___nl__4 = null;
//line 1043
___nl__5 = null;
//line 1043
___nl__7 = null;
//line 1043
___nl__8 = null;
//line 1043
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__6;
//line 1044
if (true) {goto label_10;}
//line 1044
label_10:
//line 1044
___nl__8 = null;
//line 1046
___nl__8 = tc_types_NL.NL_get_bin_op_def(___nl__4).clone();

//line 1047
___nl__10 = ((ImmHash)___nl__8).getHashValue()["arg1"].clone();
//line 1047
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__9 = ptd_system_NL.NL_is_accepted(___nl__6,___nl__10,___ref______nl__1,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 1047
___nl__10 = null;
//line 1047
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 1047
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 1047
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_18;}}
//line 1048
___nl__10 = new ImmString("incorrect type of the first argument operator '").clone();
//line 1048
___nl__10 = new ImmString(___nl__10.toString() + ___nl__4.toString()).clone();
//line 1048
___nl__11 = new ImmString("'").clone();
//line 1048
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString()).clone();
//line 1048
___nl__11 = null;
//line 1048
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__10);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 1048
___nl__10 = null;
//line 1049
if (true) {goto label_18;}
//line 1049
label_18:
//line 1049
___nl__9 = null;
//line 1050
___nl__10 = ((ImmHash)___nl__8).getHashValue()["arg2"].clone();
//line 1050
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__9 = ptd_system_NL.NL_is_accepted(___nl__5,___nl__10,___ref______nl__1,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 1050
___nl__10 = null;
//line 1050
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 1050
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 1050
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_20;}}
//line 1051
___nl__10 = new ImmString("incorrect type of the second argument operator '").clone();
//line 1051
___nl__10 = new ImmString(___nl__10.toString() + ___nl__4.toString()).clone();
//line 1051
___nl__11 = new ImmString("'").clone();
//line 1051
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString()).clone();
//line 1051
___nl__11 = null;
//line 1051
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__10);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 1051
___nl__10 = null;
//line 1052
if (true) {goto label_20;}
//line 1052
label_20:
//line 1052
___nl__9 = null;
//line 1054
___nl__10 = ((ImmHash)___nl__8).getHashValue()["ret"].clone();
//line 1054
___nl__11 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("speculation")).clone();
//line 1054
__function_map = new Dictionary<String, Imm>();
__function_map.Add("type",___nl__10);
__function_map.Add("src",___nl__11);
___nl__9 = new ImmHash(__function_map).clone();
//line 1054
___nl__10 = null;
//line 1054
___nl__11 = null;
//line 1054
___nl__0 = null;
//line 1054
___nl__4 = null;
//line 1054
___nl__5 = null;
//line 1054
___nl__6 = null;
//line 1054
___nl__7 = null;
//line 1054
___nl__8 = null;
//line 1054
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__9;
//line 1054
___nl__9 = null;
//line 1054
___nl__4 = null;
//line 1054
___nl__5 = null;
//line 1054
___nl__6 = null;
//line 1054
___nl__7 = null;
//line 1054
___nl__8 = null;
//line 1054
___nl__0 = null;
//line 1054
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return null;
}

private static Imm NL_get_print_tct_type_name_priv(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
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
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
ImmRef ___ref______nl__6 = null;
ImmRef ___ref______nl__7 = null;
ImmRef ___ref______nl__8 = null;
ImmRef ___ref______nl__9 = null;
ImmRef ___ref______nl__10 = null;
Dictionary<String, Imm> __function_map;
//line 1057
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_empty")).clone();
//line 1057
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_2;}}
//line 1059
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_im")).clone();
//line 1059
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_3;}}
//line 1061
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_void")).clone();
//line 1061
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_4;}}
//line 1063
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_sim")).clone();
//line 1063
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_5;}}
//line 1065
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_ref")).clone();
//line 1065
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_6;}}
//line 1067
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_arr")).clone();
//line 1067
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_7;}}
//line 1069
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_var")).clone();
//line 1069
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_8;}}
//line 1079
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_rec")).clone();
//line 1079
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_9;}}
//line 1085
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_hash")).clone();
//line 1085
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_10;}}
//line 1085
___nl__1 = new ImmString("NOMATCHALERT").clone();
//line 1085
___nl__1 = new ImmArray(new Imm[] {___nl__1,___nl__0,}).clone();
//line 1085
c_rt_lib_NL.NL_die();
//line 1057
label_2:
//line 1058
___nl__2 = new ImmString("").clone();
//line 1058
___nl__0 = null;
//line 1058
___nl__1 = null;
//line 1058
if(true) return ___nl__2;
//line 1058
___nl__2 = null;
//line 1059
if (true) {goto label_1;}
//line 1059
label_3:
//line 1060
___nl__2 = new ImmString("ptd::ptd_im()").clone();
//line 1060
___nl__0 = null;
//line 1060
___nl__1 = null;
//line 1060
if(true) return ___nl__2;
//line 1060
___nl__2 = null;
//line 1061
if (true) {goto label_1;}
//line 1061
label_4:
//line 1062
___nl__2 = new ImmString("ptd::void()").clone();
//line 1062
___nl__0 = null;
//line 1062
___nl__1 = null;
//line 1062
if(true) return ___nl__2;
//line 1062
___nl__2 = null;
//line 1063
if (true) {goto label_1;}
//line 1063
label_5:
//line 1064
___nl__2 = new ImmString("ptd::sim()").clone();
//line 1064
___nl__0 = null;
//line 1064
___nl__1 = null;
//line 1064
if(true) return ___nl__2;
//line 1064
___nl__2 = null;
//line 1065
if (true) {goto label_1;}
//line 1065
label_6:
//line 1065
___nl__2 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("tct_ref")).clone();
//line 1066
___nl__3 = new ImmString("@").clone();
//line 1066
___nl__3 = new ImmString(___nl__3.toString() + ___nl__2.toString()).clone();
//line 1066
___nl__0 = null;
//line 1066
___nl__1 = null;
//line 1066
___nl__2 = null;
//line 1066
if(true) return ___nl__3;
//line 1066
___nl__3 = null;
//line 1066
___nl__2 = null;
//line 1067
if (true) {goto label_1;}
//line 1067
label_7:
//line 1067
___nl__2 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("tct_arr")).clone();
//line 1068
___nl__3 = new ImmString("ptd::arr(").clone();
//line 1068
___nl__4 = type_checker_NL.NL_get_print_tct_type_name_priv(___nl__2).clone();

//line 1068
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 1068
___nl__4 = null;
//line 1068
___nl__4 = new ImmString(")").clone();
//line 1068
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 1068
___nl__4 = null;
//line 1068
___nl__0 = null;
//line 1068
___nl__1 = null;
//line 1068
___nl__2 = null;
//line 1068
if(true) return ___nl__3;
//line 1068
___nl__3 = null;
//line 1068
___nl__2 = null;
//line 1069
if (true) {goto label_1;}
//line 1069
label_8:
//line 1069
___nl__2 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("tct_var")).clone();
//line 1070
___nl__3 = new ImmString("ptd::var(").clone();
//line 1071
___nl__6 = c_rt_lib_NL.NL_init_iter(___nl__2).clone();

//line 1071
label_13:
//line 1071
___nl__4 = c_rt_lib_NL.NL_is_end_hash(___nl__6).clone();

//line 1071
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_11;}}
//line 1071
___nl__4 = c_rt_lib_NL.NL_get_key_iter(___nl__6).clone();

//line 1071
___nl__5 = c_rt_lib_NL.NL_hash_get_value(___nl__2,___nl__4).clone();

//line 1072
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("with_param")).clone();
//line 1072
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_15;}}
//line 1074
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("no_param")).clone();
//line 1074
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_16;}}
//line 1074
___nl__7 = new ImmString("NOMATCHALERT").clone();
//line 1074
___nl__7 = new ImmArray(new Imm[] {___nl__7,___nl__5,}).clone();
//line 1074
c_rt_lib_NL.NL_die();
//line 1072
label_15:
//line 1072
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("with_param")).clone();
//line 1073
___nl__9 = new ImmString(" => ").clone();
//line 1073
___nl__9 = new ImmString(___nl__4.toString() + ___nl__9.toString()).clone();
//line 1073
___nl__10 = type_checker_NL.NL_get_print_tct_type_name_priv(___nl__8).clone();

//line 1073
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 1073
___nl__10 = null;
//line 1073
___nl__10 = new ImmString(", ").clone();
//line 1073
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 1073
___nl__10 = null;
//line 1073
___nl__3 = new ImmString(___nl__3.toString() + ___nl__9.toString()).clone();
//line 1073
___nl__9 = null;
//line 1073
___nl__8 = null;
//line 1074
if (true) {goto label_14;}
//line 1074
label_16:
//line 1075
___nl__8 = new ImmString(", ").clone();
//line 1075
___nl__8 = new ImmString(___nl__4.toString() + ___nl__8.toString()).clone();
//line 1075
___nl__3 = new ImmString(___nl__3.toString() + ___nl__8.toString()).clone();
//line 1075
___nl__8 = null;
//line 1076
if (true) {goto label_14;}
//line 1076
label_14:
//line 1076
___nl__7 = null;
//line 1077
___nl__6 = c_rt_lib_NL.NL_next_iter(___nl__6).clone();

//line 1077
if (true) {goto label_13;}
//line 1077
label_11:
//line 1077
___nl__4 = null;
//line 1077
___nl__5 = null;
//line 1077
___nl__6 = null;
//line 1078
___nl__4 = new ImmString(")").clone();
//line 1078
___nl__4 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 1078
___nl__0 = null;
//line 1078
___nl__1 = null;
//line 1078
___nl__2 = null;
//line 1078
___nl__3 = null;
//line 1078
if(true) return ___nl__4;
//line 1078
___nl__4 = null;
//line 1078
___nl__3 = null;
//line 1078
___nl__2 = null;
//line 1079
if (true) {goto label_1;}
//line 1079
label_9:
//line 1079
___nl__2 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("tct_rec")).clone();
//line 1080
___nl__3 = new ImmString("ptd::rec(").clone();
//line 1081
___nl__6 = c_rt_lib_NL.NL_init_iter(___nl__2).clone();

//line 1081
label_19:
//line 1081
___nl__4 = c_rt_lib_NL.NL_is_end_hash(___nl__6).clone();

//line 1081
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_17;}}
//line 1081
___nl__4 = c_rt_lib_NL.NL_get_key_iter(___nl__6).clone();

//line 1081
___nl__5 = c_rt_lib_NL.NL_hash_get_value(___nl__2,___nl__4).clone();

//line 1082
___nl__7 = new ImmString(" => ").clone();
//line 1082
___nl__7 = new ImmString(___nl__4.toString() + ___nl__7.toString()).clone();
//line 1082
___nl__8 = type_checker_NL.NL_get_print_tct_type_name_priv(___nl__5).clone();

//line 1082
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 1082
___nl__8 = null;
//line 1082
___nl__8 = new ImmString(", ").clone();
//line 1082
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 1082
___nl__8 = null;
//line 1082
___nl__3 = new ImmString(___nl__3.toString() + ___nl__7.toString()).clone();
//line 1082
___nl__7 = null;
//line 1083
___nl__6 = c_rt_lib_NL.NL_next_iter(___nl__6).clone();

//line 1083
if (true) {goto label_19;}
//line 1083
label_17:
//line 1083
___nl__4 = null;
//line 1083
___nl__5 = null;
//line 1083
___nl__6 = null;
//line 1084
___nl__4 = new ImmString(")").clone();
//line 1084
___nl__4 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 1084
___nl__0 = null;
//line 1084
___nl__1 = null;
//line 1084
___nl__2 = null;
//line 1084
___nl__3 = null;
//line 1084
if(true) return ___nl__4;
//line 1084
___nl__4 = null;
//line 1084
___nl__3 = null;
//line 1084
___nl__2 = null;
//line 1085
if (true) {goto label_1;}
//line 1085
label_10:
//line 1085
___nl__2 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("tct_hash")).clone();
//line 1086
___nl__3 = new ImmString("ptd::hash(").clone();
//line 1086
___nl__4 = type_checker_NL.NL_get_print_tct_type_name_priv(___nl__2).clone();

//line 1086
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 1086
___nl__4 = null;
//line 1086
___nl__4 = new ImmString(")").clone();
//line 1086
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 1086
___nl__4 = null;
//line 1086
___nl__0 = null;
//line 1086
___nl__1 = null;
//line 1086
___nl__2 = null;
//line 1086
if(true) return ___nl__3;
//line 1086
___nl__3 = null;
//line 1086
___nl__2 = null;
//line 1087
if (true) {goto label_1;}
//line 1087
label_1:
//line 1087
___nl__1 = null;
//line 1087
___nl__0 = null;
//line 1087
if(true) return null;
}

private static Imm NL_get_print_tct_label_priv(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 1090
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_empty")).clone();
//line 1090
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_2;}}
//line 1092
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_im")).clone();
//line 1092
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_3;}}
//line 1094
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_void")).clone();
//line 1094
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_4;}}
//line 1096
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_sim")).clone();
//line 1096
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_5;}}
//line 1098
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_ref")).clone();
//line 1098
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_6;}}
//line 1100
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_arr")).clone();
//line 1100
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_7;}}
//line 1102
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_var")).clone();
//line 1102
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_8;}}
//line 1104
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_rec")).clone();
//line 1104
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_9;}}
//line 1106
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_hash")).clone();
//line 1106
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_10;}}
//line 1106
___nl__1 = new ImmString("NOMATCHALERT").clone();
//line 1106
___nl__1 = new ImmArray(new Imm[] {___nl__1,___nl__0,}).clone();
//line 1106
c_rt_lib_NL.NL_die();
//line 1090
label_2:
//line 1091
___nl__2 = new ImmString("ptd::ptd_empty").clone();
//line 1091
___nl__0 = null;
//line 1091
___nl__1 = null;
//line 1091
if(true) return ___nl__2;
//line 1091
___nl__2 = null;
//line 1092
if (true) {goto label_1;}
//line 1092
label_3:
//line 1093
___nl__2 = new ImmString("ptd::ptd_im").clone();
//line 1093
___nl__0 = null;
//line 1093
___nl__1 = null;
//line 1093
if(true) return ___nl__2;
//line 1093
___nl__2 = null;
//line 1094
if (true) {goto label_1;}
//line 1094
label_4:
//line 1095
___nl__2 = new ImmString("ptd::void").clone();
//line 1095
___nl__0 = null;
//line 1095
___nl__1 = null;
//line 1095
if(true) return ___nl__2;
//line 1095
___nl__2 = null;
//line 1096
if (true) {goto label_1;}
//line 1096
label_5:
//line 1097
___nl__2 = new ImmString("ptd::sim").clone();
//line 1097
___nl__0 = null;
//line 1097
___nl__1 = null;
//line 1097
if(true) return ___nl__2;
//line 1097
___nl__2 = null;
//line 1098
if (true) {goto label_1;}
//line 1098
label_6:
//line 1098
___nl__2 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("tct_ref")).clone();
//line 1099
___nl__3 = new ImmString("ptd::ref").clone();
//line 1099
___nl__0 = null;
//line 1099
___nl__1 = null;
//line 1099
___nl__2 = null;
//line 1099
if(true) return ___nl__3;
//line 1099
___nl__3 = null;
//line 1099
___nl__2 = null;
//line 1100
if (true) {goto label_1;}
//line 1100
label_7:
//line 1100
___nl__2 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("tct_arr")).clone();
//line 1101
___nl__3 = new ImmString("ptd::arr").clone();
//line 1101
___nl__0 = null;
//line 1101
___nl__1 = null;
//line 1101
___nl__2 = null;
//line 1101
if(true) return ___nl__3;
//line 1101
___nl__3 = null;
//line 1101
___nl__2 = null;
//line 1102
if (true) {goto label_1;}
//line 1102
label_8:
//line 1102
___nl__2 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("tct_var")).clone();
//line 1103
___nl__3 = new ImmString("ptd::var").clone();
//line 1103
___nl__0 = null;
//line 1103
___nl__1 = null;
//line 1103
___nl__2 = null;
//line 1103
if(true) return ___nl__3;
//line 1103
___nl__3 = null;
//line 1103
___nl__2 = null;
//line 1104
if (true) {goto label_1;}
//line 1104
label_9:
//line 1104
___nl__2 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("tct_rec")).clone();
//line 1105
___nl__3 = new ImmString("ptd::rec").clone();
//line 1105
___nl__0 = null;
//line 1105
___nl__1 = null;
//line 1105
___nl__2 = null;
//line 1105
if(true) return ___nl__3;
//line 1105
___nl__3 = null;
//line 1105
___nl__2 = null;
//line 1106
if (true) {goto label_1;}
//line 1106
label_10:
//line 1106
___nl__2 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("tct_hash")).clone();
//line 1107
___nl__3 = new ImmString("ptd::hash").clone();
//line 1107
___nl__0 = null;
//line 1107
___nl__1 = null;
//line 1107
___nl__2 = null;
//line 1107
if(true) return ___nl__3;
//line 1107
___nl__3 = null;
//line 1107
___nl__2 = null;
//line 1108
if (true) {goto label_1;}
//line 1108
label_1:
//line 1108
___nl__1 = null;
//line 1108
___nl__0 = null;
//line 1108
if(true) return null;
}

private static Imm NL_get_print_check_info_priv(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
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
Imm ___nl__14 = null;
Imm ___nl__15 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
ImmRef ___ref______nl__6 = null;
ImmRef ___ref______nl__7 = null;
ImmRef ___ref______nl__8 = null;
ImmRef ___ref______nl__9 = null;
ImmRef ___ref______nl__10 = null;
ImmRef ___ref______nl__11 = null;
ImmRef ___ref______nl__12 = null;
ImmRef ___ref______nl__13 = null;
ImmRef ___ref______nl__14 = null;
ImmRef ___ref______nl__15 = null;
Dictionary<String, Imm> __function_map;
//line 1111
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("ok")).clone();
//line 1111
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_2;}}
//line 1113
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("err")).clone();
//line 1113
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_3;}}
//line 1113
___nl__1 = new ImmString("NOMATCHALERT").clone();
//line 1113
___nl__1 = new ImmArray(new Imm[] {___nl__1,___nl__0,}).clone();
//line 1113
c_rt_lib_NL.NL_die();
//line 1111
label_2:
//line 1112
___nl__2 = new ImmArray(new Imm[0]).clone();
//line 1112
c_rt_lib_NL.NL_die();
//line 1112
___nl__2 = null;
//line 1113
if (true) {goto label_1;}
//line 1113
label_3:
//line 1113
___nl__2 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("err")).clone();
//line 1114
___nl__3 = new ImmString(" ").clone();
//line 1115
___nl__5 = ((ImmHash)___nl__2).getHashValue()["stack"].clone();
//line 1115
___nl__4 = array_NL.NL_len(___nl__5).clone();

//line 1115
___nl__5 = null;
//line 1115
___nl__5 = new ImmDouble(1).clone();
//line 1115
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))-(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 1115
___nl__5 = null;
//line 1115
label_5:
//line 1115
___nl__5 = new ImmDouble(0).clone();
//line 1115
___nl__5 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__5.getValue().ToString())) ).clone();
//line 1115
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 1115
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_4;}}
//line 1116
___nl__6 = ((ImmHash)___nl__2).getHashValue()["stack"].clone();
//line 1116
___nl__6 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()].clone();
//line 1116
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("ptd_arr")).clone();
//line 1116
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_8;}}
//line 1118
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("ptd_var")).clone();
//line 1118
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_9;}}
//line 1120
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("ptd_rec")).clone();
//line 1120
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_10;}}
//line 1122
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("ptd_hash")).clone();
//line 1122
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_11;}}
//line 1122
___nl__7 = new ImmString("NOMATCHALERT").clone();
//line 1122
___nl__7 = new ImmArray(new Imm[] {___nl__7,___nl__6,}).clone();
//line 1122
c_rt_lib_NL.NL_die();
//line 1116
label_8:
//line 1117
___nl__8 = new ImmString("ptd::arr").clone();
//line 1117
___nl__3 = new ImmString(___nl__3.toString() + ___nl__8.toString()).clone();
//line 1117
___nl__8 = null;
//line 1118
if (true) {goto label_7;}
//line 1118
label_9:
//line 1118
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("ptd_var")).clone();
//line 1119
___nl__9 = new ImmString("ptd::var(").clone();
//line 1119
___nl__9 = new ImmString(___nl__9.toString() + ___nl__8.toString()).clone();
//line 1119
___nl__10 = new ImmString(")").clone();
//line 1119
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 1119
___nl__10 = null;
//line 1119
___nl__3 = new ImmString(___nl__3.toString() + ___nl__9.toString()).clone();
//line 1119
___nl__9 = null;
//line 1119
___nl__8 = null;
//line 1120
if (true) {goto label_7;}
//line 1120
label_10:
//line 1120
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("ptd_rec")).clone();
//line 1121
___nl__9 = new ImmString("ptd::rec(").clone();
//line 1121
___nl__9 = new ImmString(___nl__9.toString() + ___nl__8.toString()).clone();
//line 1121
___nl__10 = new ImmString(")").clone();
//line 1121
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 1121
___nl__10 = null;
//line 1121
___nl__3 = new ImmString(___nl__3.toString() + ___nl__9.toString()).clone();
//line 1121
___nl__9 = null;
//line 1121
___nl__8 = null;
//line 1122
if (true) {goto label_7;}
//line 1122
label_11:
//line 1123
___nl__8 = new ImmString("ptd::hash").clone();
//line 1123
___nl__3 = new ImmString(___nl__3.toString() + ___nl__8.toString()).clone();
//line 1123
___nl__8 = null;
//line 1124
if (true) {goto label_7;}
//line 1124
label_7:
//line 1124
___nl__6 = null;
//line 1124
___nl__7 = null;
//line 1125
___nl__6 = new ImmString("->").clone();
//line 1125
___nl__3 = new ImmString(___nl__3.toString() + ___nl__6.toString()).clone();
//line 1125
___nl__6 = null;
//line 1125
___nl__6 = new ImmDouble(1).clone();
//line 1125
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))-(Double.Parse(___nl__6.getValue().ToString()))).clone();
//line 1125
___nl__6 = null;
//line 1126
if (true) {goto label_5;}
//line 1126
label_4:
//line 1126
___nl__4 = null;
//line 1126
___nl__5 = null;
//line 1127
___nl__4 = ((ImmHash)___nl__2).getHashValue()["from"].clone();
//line 1127
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("tct_rec")).clone();
//line 1127
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 1127
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_14;}}
//line 1127
___nl__4 = ((ImmHash)___nl__2).getHashValue()["to"].clone();
//line 1127
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("tct_rec")).clone();
//line 1127
label_14:
//line 1127
___nl__5 = null;
//line 1127
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 1127
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_13;}}
//line 1128
___nl__5 = ((ImmHash)___nl__2).getHashValue()["from"].clone();
//line 1128
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("tct_rec")).clone();
//line 1128
___nl__8 = c_rt_lib_NL.NL_init_iter(___nl__5).clone();

//line 1128
label_17:
//line 1128
___nl__6 = c_rt_lib_NL.NL_is_end_hash(___nl__8).clone();

//line 1128
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_15;}}
//line 1128
___nl__6 = c_rt_lib_NL.NL_get_key_iter(___nl__8).clone();

//line 1128
___nl__7 = c_rt_lib_NL.NL_hash_get_value(___nl__5,___nl__6).clone();

//line 1129
___nl__10 = ((ImmHash)___nl__2).getHashValue()["to"].clone();
//line 1129
___nl__10 = c_rt_lib_NL.NL_ov_as(___nl__10, new ImmString("tct_rec")).clone();
//line 1129
___nl__9 = hash_NL.NL_has_key(___nl__10,___nl__6).clone();

//line 1129
___nl__10 = null;
//line 1129
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 1129
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_19;}}
//line 1129
___nl__9 = null;
//line 1129
if (true) {goto label_16;}
//line 1129
if (true) {goto label_19;}
//line 1129
label_19:
//line 1129
___nl__9 = null;
//line 1130
___nl__9 = new ImmString("(ptd::rec with field: '").clone();
//line 1130
___nl__9 = new ImmString(___nl__3.toString() + ___nl__9.toString()).clone();
//line 1130
___nl__9 = new ImmString(___nl__9.toString() + ___nl__6.toString()).clone();
//line 1130
___nl__10 = new ImmString("' instead of ptd::rec without field: '").clone();
//line 1130
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 1130
___nl__10 = null;
//line 1130
___nl__9 = new ImmString(___nl__9.toString() + ___nl__6.toString()).clone();
//line 1130
___nl__10 = new ImmString("')").clone();
//line 1130
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 1130
___nl__10 = null;
//line 1130
___nl__0 = null;
//line 1130
___nl__1 = null;
//line 1130
___nl__2 = null;
//line 1130
___nl__3 = null;
//line 1130
___nl__4 = null;
//line 1130
___nl__5 = null;
//line 1130
___nl__6 = null;
//line 1130
___nl__7 = null;
//line 1130
___nl__8 = null;
//line 1130
if(true) return ___nl__9;
//line 1130
___nl__9 = null;
//line 1130
label_16:
//line 1131
___nl__8 = c_rt_lib_NL.NL_next_iter(___nl__8).clone();

//line 1131
if (true) {goto label_17;}
//line 1131
label_15:
//line 1131
___nl__5 = null;
//line 1131
___nl__6 = null;
//line 1131
___nl__7 = null;
//line 1131
___nl__8 = null;
//line 1132
___nl__5 = ((ImmHash)___nl__2).getHashValue()["to"].clone();
//line 1132
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("tct_rec")).clone();
//line 1132
___nl__8 = c_rt_lib_NL.NL_init_iter(___nl__5).clone();

//line 1132
label_22:
//line 1132
___nl__6 = c_rt_lib_NL.NL_is_end_hash(___nl__8).clone();

//line 1132
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_20;}}
//line 1132
___nl__6 = c_rt_lib_NL.NL_get_key_iter(___nl__8).clone();

//line 1132
___nl__7 = c_rt_lib_NL.NL_hash_get_value(___nl__5,___nl__6).clone();

//line 1133
___nl__10 = ((ImmHash)___nl__2).getHashValue()["from"].clone();
//line 1133
___nl__10 = c_rt_lib_NL.NL_ov_as(___nl__10, new ImmString("tct_rec")).clone();
//line 1133
___nl__9 = hash_NL.NL_has_key(___nl__10,___nl__6).clone();

//line 1133
___nl__10 = null;
//line 1133
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 1133
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_24;}}
//line 1133
___nl__9 = null;
//line 1133
if (true) {goto label_21;}
//line 1133
if (true) {goto label_24;}
//line 1133
label_24:
//line 1133
___nl__9 = null;
//line 1134
___nl__9 = new ImmString("(ptd::rec without field: '").clone();
//line 1134
___nl__9 = new ImmString(___nl__3.toString() + ___nl__9.toString()).clone();
//line 1134
___nl__9 = new ImmString(___nl__9.toString() + ___nl__6.toString()).clone();
//line 1134
___nl__10 = new ImmString("' instead of ptd::rec with field: '").clone();
//line 1134
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 1134
___nl__10 = null;
//line 1134
___nl__9 = new ImmString(___nl__9.toString() + ___nl__6.toString()).clone();
//line 1134
___nl__10 = new ImmString("')").clone();
//line 1134
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 1134
___nl__10 = null;
//line 1134
___nl__0 = null;
//line 1134
___nl__1 = null;
//line 1134
___nl__2 = null;
//line 1134
___nl__3 = null;
//line 1134
___nl__4 = null;
//line 1134
___nl__5 = null;
//line 1134
___nl__6 = null;
//line 1134
___nl__7 = null;
//line 1134
___nl__8 = null;
//line 1134
if(true) return ___nl__9;
//line 1134
___nl__9 = null;
//line 1134
label_21:
//line 1135
___nl__8 = c_rt_lib_NL.NL_next_iter(___nl__8).clone();

//line 1135
if (true) {goto label_22;}
//line 1135
label_20:
//line 1135
___nl__5 = null;
//line 1135
___nl__6 = null;
//line 1135
___nl__7 = null;
//line 1135
___nl__8 = null;
//line 1136
if (true) {goto label_12;}
//line 1136
label_13:
//line 1136
___nl__4 = ((ImmHash)___nl__2).getHashValue()["from"].clone();
//line 1136
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("tct_var")).clone();
//line 1136
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 1136
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_26;}}
//line 1136
___nl__4 = ((ImmHash)___nl__2).getHashValue()["to"].clone();
//line 1136
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("tct_var")).clone();
//line 1136
label_26:
//line 1136
___nl__5 = null;
//line 1136
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 1136
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_25;}}
//line 1137
___nl__5 = ((ImmHash)___nl__2).getHashValue()["from"].clone();
//line 1137
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("tct_var")).clone();
//line 1137
___nl__8 = c_rt_lib_NL.NL_init_iter(___nl__5).clone();

//line 1137
label_29:
//line 1137
___nl__6 = c_rt_lib_NL.NL_is_end_hash(___nl__8).clone();

//line 1137
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_27;}}
//line 1137
___nl__6 = c_rt_lib_NL.NL_get_key_iter(___nl__8).clone();

//line 1137
___nl__7 = c_rt_lib_NL.NL_hash_get_value(___nl__5,___nl__6).clone();

//line 1138
___nl__9 = ((ImmHash)___nl__2).getHashValue()["to"].clone();
//line 1138
___nl__9 = c_rt_lib_NL.NL_ov_as(___nl__9, new ImmString("tct_var")).clone();
//line 1139
___nl__10 = hash_NL.NL_has_key(___nl__9,___nl__6).clone();

//line 1139
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 1139
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_31;}}
//line 1140
___nl__11 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("no_param")).clone();
//line 1140
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_33;}}
//line 1144
___nl__11 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("with_param")).clone();
//line 1144
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_34;}}
//line 1144
___nl__11 = new ImmString("NOMATCHALERT").clone();
//line 1144
___nl__11 = new ImmArray(new Imm[] {___nl__11,___nl__7,}).clone();
//line 1144
c_rt_lib_NL.NL_die();
//line 1140
label_33:
//line 1141
___nl__12 = hash_NL.NL_get_value(___nl__9,___nl__6).clone();

//line 1141
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__12, new ImmString("with_param")).clone();
//line 1141
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 1141
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_36;}}
//line 1142
___nl__13 = new ImmString("(ptd::var case: '").clone();
//line 1142
___nl__13 = new ImmString(___nl__3.toString() + ___nl__13.toString()).clone();
//line 1142
___nl__13 = new ImmString(___nl__13.toString() + ___nl__6.toString()).clone();
//line 1142
___nl__14 = new ImmString("' no_param instead of ptd::var case: '").clone();
//line 1142
___nl__13 = new ImmString(___nl__13.toString() + ___nl__14.toString()).clone();
//line 1142
___nl__14 = null;
//line 1142
___nl__13 = new ImmString(___nl__13.toString() + ___nl__6.toString()).clone();
//line 1142
___nl__14 = new ImmString("' with_param)").clone();
//line 1142
___nl__13 = new ImmString(___nl__13.toString() + ___nl__14.toString()).clone();
//line 1142
___nl__14 = null;
//line 1142
___nl__0 = null;
//line 1142
___nl__1 = null;
//line 1142
___nl__2 = null;
//line 1142
___nl__3 = null;
//line 1142
___nl__4 = null;
//line 1142
___nl__5 = null;
//line 1142
___nl__6 = null;
//line 1142
___nl__7 = null;
//line 1142
___nl__8 = null;
//line 1142
___nl__9 = null;
//line 1142
___nl__10 = null;
//line 1142
___nl__11 = null;
//line 1142
___nl__12 = null;
//line 1142
if(true) return ___nl__13;
//line 1142
___nl__13 = null;
//line 1143
if (true) {goto label_36;}
//line 1143
label_36:
//line 1143
___nl__12 = null;
//line 1144
if (true) {goto label_32;}
//line 1144
label_34:
//line 1144
___nl__12 = c_rt_lib_NL.NL_ov_as(___nl__7, new ImmString("with_param")).clone();
//line 1145
___nl__13 = hash_NL.NL_get_value(___nl__9,___nl__6).clone();

//line 1145
___nl__13 = c_rt_lib_NL.NL_ov_is(___nl__13, new ImmString("no_param")).clone();
//line 1145
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13)).clone();
//line 1145
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_38;}}
//line 1146
___nl__14 = new ImmString("(ptd::var case: '").clone();
//line 1146
___nl__14 = new ImmString(___nl__3.toString() + ___nl__14.toString()).clone();
//line 1146
___nl__14 = new ImmString(___nl__14.toString() + ___nl__6.toString()).clone();
//line 1146
___nl__15 = new ImmString("' with_param instead of ptd::var case: '").clone();
//line 1146
___nl__14 = new ImmString(___nl__14.toString() + ___nl__15.toString()).clone();
//line 1146
___nl__15 = null;
//line 1146
___nl__14 = new ImmString(___nl__14.toString() + ___nl__6.toString()).clone();
//line 1146
___nl__15 = new ImmString("' no_param)").clone();
//line 1146
___nl__14 = new ImmString(___nl__14.toString() + ___nl__15.toString()).clone();
//line 1146
___nl__15 = null;
//line 1146
___nl__0 = null;
//line 1146
___nl__1 = null;
//line 1146
___nl__2 = null;
//line 1146
___nl__3 = null;
//line 1146
___nl__4 = null;
//line 1146
___nl__5 = null;
//line 1146
___nl__6 = null;
//line 1146
___nl__7 = null;
//line 1146
___nl__8 = null;
//line 1146
___nl__9 = null;
//line 1146
___nl__10 = null;
//line 1146
___nl__11 = null;
//line 1146
___nl__12 = null;
//line 1146
___nl__13 = null;
//line 1146
if(true) return ___nl__14;
//line 1146
___nl__14 = null;
//line 1147
if (true) {goto label_38;}
//line 1147
label_38:
//line 1147
___nl__13 = null;
//line 1147
___nl__12 = null;
//line 1148
if (true) {goto label_32;}
//line 1148
label_32:
//line 1148
___nl__11 = null;
//line 1149
if (true) {goto label_30;}
//line 1149
label_31:
//line 1150
___nl__11 = new ImmString("(ptd::var with case: '").clone();
//line 1150
___nl__11 = new ImmString(___nl__3.toString() + ___nl__11.toString()).clone();
//line 1150
___nl__11 = new ImmString(___nl__11.toString() + ___nl__6.toString()).clone();
//line 1150
___nl__12 = new ImmString("' instead of ptd::var without case: '").clone();
//line 1150
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString()).clone();
//line 1150
___nl__12 = null;
//line 1150
___nl__11 = new ImmString(___nl__11.toString() + ___nl__6.toString()).clone();
//line 1150
___nl__12 = new ImmString("')").clone();
//line 1150
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString()).clone();
//line 1150
___nl__12 = null;
//line 1150
___nl__0 = null;
//line 1150
___nl__1 = null;
//line 1150
___nl__2 = null;
//line 1150
___nl__3 = null;
//line 1150
___nl__4 = null;
//line 1150
___nl__5 = null;
//line 1150
___nl__6 = null;
//line 1150
___nl__7 = null;
//line 1150
___nl__8 = null;
//line 1150
___nl__9 = null;
//line 1150
___nl__10 = null;
//line 1150
if(true) return ___nl__11;
//line 1150
___nl__11 = null;
//line 1151
if (true) {goto label_30;}
//line 1151
label_30:
//line 1151
___nl__10 = null;
//line 1151
___nl__9 = null;
//line 1152
___nl__8 = c_rt_lib_NL.NL_next_iter(___nl__8).clone();

//line 1152
if (true) {goto label_29;}
//line 1152
label_27:
//line 1152
___nl__5 = null;
//line 1152
___nl__6 = null;
//line 1152
___nl__7 = null;
//line 1152
___nl__8 = null;
//line 1153
if (true) {goto label_12;}
//line 1153
label_25:
//line 1154
___nl__5 = new ImmString("(").clone();
//line 1154
___nl__7 = ((ImmHash)___nl__2).getHashValue()["from"].clone();
//line 1154
___nl__6 = type_checker_NL.NL_get_print_tct_label_priv(___nl__7).clone();

//line 1154
___nl__7 = null;
//line 1154
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 1154
___nl__6 = null;
//line 1154
___nl__6 = new ImmString(" instead of ").clone();
//line 1154
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 1154
___nl__6 = null;
//line 1154
___nl__7 = ((ImmHash)___nl__2).getHashValue()["to"].clone();
//line 1154
___nl__6 = type_checker_NL.NL_get_print_tct_label_priv(___nl__7).clone();

//line 1154
___nl__7 = null;
//line 1154
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 1154
___nl__6 = null;
//line 1154
___nl__6 = new ImmString(")").clone();
//line 1154
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 1154
___nl__6 = null;
//line 1154
___nl__3 = new ImmString(___nl__3.toString() + ___nl__5.toString()).clone();
//line 1154
___nl__5 = null;
//line 1155
if (true) {goto label_12;}
//line 1155
label_12:
//line 1155
___nl__4 = null;
//line 1156
___nl__0 = null;
//line 1156
___nl__1 = null;
//line 1156
___nl__2 = null;
//line 1156
if(true) return ___nl__3;
//line 1156
___nl__3 = null;
//line 1156
___nl__2 = null;
//line 1157
if (true) {goto label_1;}
//line 1157
label_1:
//line 1157
___nl__1 = null;
//line 1157
___nl__0 = null;
//line 1157
if(true) return null;
}

private static Imm NL_check_var_decl_priv(Imm ___arg__0, ImmRef ___arg__1, ImmRef ___arg__2, ImmRef ___arg__3) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();Imm ___nl__2 = ___arg__2.getValue().clone();Imm ___nl__3 = ___arg__3.getValue().clone();
Imm ___nl__4 = null;
Imm ___nl__5 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
Dictionary<String, Imm> __function_map;
//line 1162
___nl__5 = c_rt_lib_NL.NL_get_false().clone();
//line 1162
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__4 = type_checker_NL.NL_check_var_decl_try_priv(___nl__0,___nl__5,___ref______nl__1,___ref______nl__2,___ref______nl__3).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 1162
___nl__5 = null;
//line 1162
___nl__0 = null;
//line 1162
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__4;
//line 1162
___nl__4 = null;
//line 1162
___nl__0 = null;
//line 1162
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return null;
}

private static Imm NL_check_var_decl_try_priv(Imm ___arg__0, Imm ___arg__1, ImmRef ___arg__2, ImmRef ___arg__3, ImmRef ___arg__4) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.getValue().clone();Imm ___nl__3 = ___arg__3.getValue().clone();Imm ___nl__4 = ___arg__4.getValue().clone();
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
Imm ___nl__9 = null;
Imm ___nl__10 = null;
Imm ___nl__11 = null;
Imm ___nl__12 = null;
Imm ___nl__13 = null;
Imm ___nl__14 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
ImmRef ___ref______nl__6 = null;
ImmRef ___ref______nl__7 = null;
ImmRef ___ref______nl__8 = null;
ImmRef ___ref______nl__9 = null;
ImmRef ___ref______nl__10 = null;
ImmRef ___ref______nl__11 = null;
ImmRef ___ref______nl__12 = null;
ImmRef ___ref______nl__13 = null;
ImmRef ___ref______nl__14 = null;
Dictionary<String, Imm> __function_map;
//line 1168
___nl__6 = ((ImmHash)___nl__0).getHashValue()["name"].clone();
//line 1168
___nl__5 = hash_NL.NL_has_key(___nl__3,___nl__6).clone();

//line 1168
___nl__6 = null;
//line 1168
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 1168
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_2;}}
//line 1168
___nl__6 = new ImmString("variable `").clone();
//line 1168
___nl__7 = ((ImmHash)___nl__0).getHashValue()["name"].clone();
//line 1168
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 1168
___nl__7 = null;
//line 1168
___nl__7 = new ImmString("' already exists").clone();
//line 1168
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 1168
___nl__7 = null;
//line 1168
___ref______nl__4 = new ImmRef(___nl__4);
type_checker_NL.NL_add_error_priv(___ref______nl__4,___nl__6);
___nl__4 = ___ref______nl__4.getValue().clone();

//line 1168
___nl__6 = null;
//line 1168
if (true) {goto label_2;}
//line 1168
label_2:
//line 1168
___nl__5 = null;
//line 1169
___nl__5 = tct_NL.NL_tct_empty().clone();

//line 1170
___nl__6 = ((ImmHash)___nl__0).getHashValue()["type"].clone();
//line 1170
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("type")).clone();
//line 1170
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_4;}}
//line 1178
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("none")).clone();
//line 1178
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_5;}}
//line 1178
___nl__7 = new ImmString("NOMATCHALERT").clone();
//line 1178
___nl__7 = new ImmArray(new Imm[] {___nl__7,___nl__6,}).clone();
//line 1178
c_rt_lib_NL.NL_die();
//line 1170
label_4:
//line 1170
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("type")).clone();
//line 1171
___nl__9 = ptd_parser_NL.NL_try_value_to_ptd(___nl__8).clone();

//line 1171
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__9, new ImmString("err")).clone();
//line 1171
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_7;}}
//line 1174
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__9, new ImmString("ok")).clone();
//line 1174
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_8;}}
//line 1174
___nl__10 = new ImmString("NOMATCHALERT").clone();
//line 1174
___nl__10 = new ImmArray(new Imm[] {___nl__10,___nl__9,}).clone();
//line 1174
c_rt_lib_NL.NL_die();
//line 1171
label_7:
//line 1171
___nl__11 = c_rt_lib_NL.NL_ov_as(___nl__9, new ImmString("err")).clone();
//line 1172
___ref______nl__4 = new ImmRef(___nl__4);
type_checker_NL.NL_add_error_priv(___ref______nl__4,___nl__11);
___nl__4 = ___ref______nl__4.getValue().clone();

//line 1173
___nl__12 = tct_NL.NL_tct_im().clone();

//line 1173
___nl__5 = ___nl__12.clone();
//line 1173
___nl__12 = null;
//line 1173
___nl__11 = null;
//line 1174
if (true) {goto label_6;}
//line 1174
label_8:
//line 1174
___nl__11 = c_rt_lib_NL.NL_ov_as(___nl__9, new ImmString("ok")).clone();
//line 1175
___nl__5 = ___nl__11.clone();
//line 1176
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__4 = new ImmRef(___nl__4);
type_checker_NL.NL_check_types_imported_priv(___nl__11,___ref______nl__2,___ref______nl__4);
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__4 = ___ref______nl__4.getValue().clone();

//line 1176
___nl__11 = null;
//line 1177
if (true) {goto label_6;}
//line 1177
label_6:
//line 1177
___nl__9 = null;
//line 1177
___nl__10 = null;
//line 1177
___nl__8 = null;
//line 1178
if (true) {goto label_3;}
//line 1178
label_5:
//line 1179
if (true) {goto label_3;}
//line 1179
label_3:
//line 1179
___nl__6 = null;
//line 1179
___nl__7 = null;
//line 1180
___nl__6 = ((ImmHash)___nl__0).getHashValue()["value"].clone();
//line 1180
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("value")).clone();
//line 1180
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_10;}}
//line 1200
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("none")).clone();
//line 1200
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_11;}}
//line 1200
___nl__7 = new ImmString("NOMATCHALERT").clone();
//line 1200
___nl__7 = new ImmArray(new Imm[] {___nl__7,___nl__6,}).clone();
//line 1200
c_rt_lib_NL.NL_die();
//line 1180
label_10:
//line 1180
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("value")).clone();
//line 1181
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___ref______nl__4 = new ImmRef(___nl__4);
___nl__9 = type_checker_NL.NL_check_val_priv(___nl__8,___ref______nl__2,___ref______nl__3,___ref______nl__4).clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();
___nl__4 = ___ref______nl__4.getValue().clone();

//line 1182
___nl__11 = ((ImmHash)___nl__9).getHashValue()["type"].clone();
//line 1182
___nl__12 = new ImmString("tct_void").clone();
//line 1182
___nl__10 = ov_NL.NL_is(___nl__11,___nl__12).clone();

//line 1182
___nl__12 = null;
//line 1182
___nl__11 = null;
//line 1182
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 1182
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_13;}}
//line 1183
___nl__11 = new ImmString("cannot use 'void' type returned from function as value").clone();
//line 1183
___ref______nl__4 = new ImmRef(___nl__4);
type_checker_NL.NL_add_error_priv(___ref______nl__4,___nl__11);
___nl__4 = ___ref______nl__4.getValue().clone();

//line 1183
___nl__11 = null;
//line 1184
___nl__12 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("yes")).clone();
//line 1184
___nl__13 = tct_NL.NL_tct_im().clone();

//line 1184
__function_map = new Dictionary<String, Imm>();
__function_map.Add("overwrited",___nl__12);
__function_map.Add("type",___nl__13);
___nl__11 = new ImmHash(__function_map).clone();
//line 1184
___nl__12 = null;
//line 1184
___nl__13 = null;
//line 1184
___nl__0 = null;
//line 1184
___nl__1 = null;
//line 1184
___nl__5 = null;
//line 1184
___nl__6 = null;
//line 1184
___nl__7 = null;
//line 1184
___nl__8 = null;
//line 1184
___nl__9 = null;
//line 1184
___nl__10 = null;
//line 1184
___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);___arg__4.setValue(___nl__4);if(true) return ___nl__11;
//line 1184
___nl__11 = null;
//line 1185
if (true) {goto label_13;}
//line 1185
label_13:
//line 1185
___nl__10 = null;
//line 1186
___nl__10 = ___nl__1.clone();
//line 1186
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 1186
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_15;}}
//line 1187
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__4 = new ImmRef(___nl__4);
___nl__11 = ptd_system_NL.NL_get_try_ensure_ok_type(___nl__9,___ref______nl__2,___ref______nl__4).clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__4 = ___ref______nl__4.getValue().clone();

//line 1187
___nl__12 = ___nl__11.clone();
//line 1187
((ImmHash)___nl__9).set("type", ___nl__12);
//line 1187
___nl__11 = null;
//line 1187
___nl__12 = null;
//line 1188
if (true) {goto label_15;}
//line 1188
label_15:
//line 1188
___nl__10 = null;
//line 1189
___nl__11 = new ImmString("tct_empty").clone();
//line 1189
___nl__10 = ov_NL.NL_is(___nl__5,___nl__11).clone();

//line 1189
___nl__11 = null;
//line 1189
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 1189
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_17;}}
//line 1190
___nl__11 = tct_NL.NL_tct_im().clone();

//line 1190
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__4 = new ImmRef(___nl__4);
ptd_system_NL.NL_check_assignment(___nl__11,___nl__9,___ref______nl__2,___ref______nl__4);
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__4 = ___ref______nl__4.getValue().clone();

//line 1190
___nl__11 = null;
//line 1191
___nl__11 = ((ImmHash)___nl__9).getHashValue()["type"].clone();
//line 1191
___nl__5 = ___nl__11.clone();
//line 1191
___nl__11 = null;
//line 1192
___nl__12 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("yes")).clone();
//line 1192
__function_map = new Dictionary<String, Imm>();
__function_map.Add("overwrited",___nl__12);
__function_map.Add("type",___nl__5);
___nl__11 = new ImmHash(__function_map).clone();
//line 1192
___nl__12 = null;
//line 1192
___nl__0 = null;
//line 1192
___nl__1 = null;
//line 1192
___nl__5 = null;
//line 1192
___nl__6 = null;
//line 1192
___nl__7 = null;
//line 1192
___nl__8 = null;
//line 1192
___nl__9 = null;
//line 1192
___nl__10 = null;
//line 1192
___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);___arg__4.setValue(___nl__4);if(true) return ___nl__11;
//line 1192
___nl__11 = null;
//line 1193
if (true) {goto label_16;}
//line 1193
label_17:
//line 1194
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__4 = new ImmRef(___nl__4);
___nl__11 = ptd_system_NL.NL_check_assignment(___nl__5,___nl__9,___ref______nl__2,___ref______nl__4).clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__4 = ___ref______nl__4.getValue().clone();

//line 1195
___nl__13 = new ImmString("err").clone();
//line 1195
___nl__12 = ov_NL.NL_is(___nl__11,___nl__13).clone();

//line 1195
___nl__13 = null;
//line 1195
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 1195
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_19;}}
//line 1196
___nl__13 = new ImmString("invalid type in variable declaration: ").clone();
//line 1196
___nl__14 = type_checker_NL.NL_get_print_check_info_priv(___nl__11).clone();

//line 1196
___nl__13 = new ImmString(___nl__13.toString() + ___nl__14.toString()).clone();
//line 1196
___nl__14 = null;
//line 1196
___ref______nl__4 = new ImmRef(___nl__4);
type_checker_NL.NL_add_error_priv(___ref______nl__4,___nl__13);
___nl__4 = ___ref______nl__4.getValue().clone();

//line 1196
___nl__13 = null;
//line 1197
if (true) {goto label_19;}
//line 1197
label_19:
//line 1197
___nl__12 = null;
//line 1198
___nl__13 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("no")).clone();
//line 1198
__function_map = new Dictionary<String, Imm>();
__function_map.Add("overwrited",___nl__13);
__function_map.Add("type",___nl__5);
___nl__12 = new ImmHash(__function_map).clone();
//line 1198
___nl__13 = null;
//line 1198
___nl__0 = null;
//line 1198
___nl__1 = null;
//line 1198
___nl__5 = null;
//line 1198
___nl__6 = null;
//line 1198
___nl__7 = null;
//line 1198
___nl__8 = null;
//line 1198
___nl__9 = null;
//line 1198
___nl__10 = null;
//line 1198
___nl__11 = null;
//line 1198
___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);___arg__4.setValue(___nl__4);if(true) return ___nl__12;
//line 1198
___nl__12 = null;
//line 1198
___nl__11 = null;
//line 1199
if (true) {goto label_16;}
//line 1199
label_16:
//line 1199
___nl__10 = null;
//line 1199
___nl__9 = null;
//line 1199
___nl__8 = null;
//line 1200
if (true) {goto label_9;}
//line 1200
label_11:
//line 1201
___nl__9 = new ImmString("tct_empty").clone();
//line 1201
___nl__8 = ov_NL.NL_is(___nl__5,___nl__9).clone();

//line 1201
___nl__9 = null;
//line 1201
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 1201
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_21;}}
//line 1201
___nl__10 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("yes")).clone();
//line 1201
__function_map = new Dictionary<String, Imm>();
__function_map.Add("overwrited",___nl__10);
__function_map.Add("type",___nl__5);
___nl__9 = new ImmHash(__function_map).clone();
//line 1201
___nl__10 = null;
//line 1201
___nl__0 = null;
//line 1201
___nl__1 = null;
//line 1201
___nl__5 = null;
//line 1201
___nl__6 = null;
//line 1201
___nl__7 = null;
//line 1201
___nl__8 = null;
//line 1201
___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);___arg__4.setValue(___nl__4);if(true) return ___nl__9;
//line 1201
___nl__9 = null;
//line 1201
if (true) {goto label_21;}
//line 1201
label_21:
//line 1201
___nl__8 = null;
//line 1202
if (true) {goto label_9;}
//line 1202
label_9:
//line 1202
___nl__6 = null;
//line 1202
___nl__7 = null;
//line 1203
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("no")).clone();
//line 1203
__function_map = new Dictionary<String, Imm>();
__function_map.Add("overwrited",___nl__7);
__function_map.Add("type",___nl__5);
___nl__6 = new ImmHash(__function_map).clone();
//line 1203
___nl__7 = null;
//line 1203
___nl__0 = null;
//line 1203
___nl__1 = null;
//line 1203
___nl__5 = null;
//line 1203
___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);___arg__4.setValue(___nl__4);if(true) return ___nl__6;
//line 1203
___nl__6 = null;
//line 1203
___nl__5 = null;
//line 1203
___nl__0 = null;
//line 1203
___nl__1 = null;
//line 1203
___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);___arg__4.setValue(___nl__4);if(true) return null;
}

private static Imm NL_add_var_to_vars_priv(Imm ___arg__0, Imm ___arg__1, ImmRef ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.getValue().clone();
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 1207
___ref______nl__2 = new ImmRef(___nl__2);
hash_NL.NL_set_value(___ref______nl__2,___nl__1,___nl__0);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 1207
___nl__0 = null;
//line 1207
___nl__1 = null;
//line 1207
___arg__2.setValue(___nl__2);if(true) return null;
}

private static Imm NL_add_var_decl_to_vars_priv(Imm ___arg__0, Imm ___arg__1, ImmRef ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.getValue().clone();
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
Dictionary<String, Imm> __function_map;
//line 1211
___nl__4 = new ImmString("tct_im").clone();
//line 1211
___nl__3 = ov_NL.NL_is(___nl__0,___nl__4).clone();

//line 1211
___nl__4 = null;
//line 1211
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 1211
___nl__4 = new ImmString("tct_empty").clone();
//line 1211
___nl__3 = ov_NL.NL_is(___nl__0,___nl__4).clone();

//line 1211
___nl__4 = null;
//line 1211
label_3:
//line 1211
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 1211
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 1212
___nl__5 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("yes")).clone();
//line 1212
__function_map = new Dictionary<String, Imm>();
__function_map.Add("overwrited",___nl__5);
__function_map.Add("type",___nl__0);
___nl__4 = new ImmHash(__function_map).clone();
//line 1212
___nl__5 = null;
//line 1212
___ref______nl__2 = new ImmRef(___nl__2);
type_checker_NL.NL_add_var_to_vars_priv(___nl__4,___nl__1,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 1212
___nl__4 = null;
//line 1213
if (true) {goto label_1;}
//line 1213
label_2:
//line 1214
___nl__5 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("no")).clone();
//line 1214
__function_map = new Dictionary<String, Imm>();
__function_map.Add("overwrited",___nl__5);
__function_map.Add("type",___nl__0);
___nl__4 = new ImmHash(__function_map).clone();
//line 1214
___nl__5 = null;
//line 1214
___ref______nl__2 = new ImmRef(___nl__2);
type_checker_NL.NL_add_var_to_vars_priv(___nl__4,___nl__1,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 1214
___nl__4 = null;
//line 1215
if (true) {goto label_1;}
//line 1215
label_1:
//line 1215
___nl__3 = null;
//line 1215
___nl__0 = null;
//line 1215
___nl__1 = null;
//line 1215
___arg__2.setValue(___nl__2);if(true) return null;
}

private static Imm NL_add_var_decl_with_type_and_check_priv(Imm ___arg__0, Imm ___arg__1, ImmRef ___arg__2, ImmRef ___arg__3) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.getValue().clone();Imm ___nl__3 = ___arg__3.getValue().clone();
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
ImmRef ___ref______nl__6 = null;
ImmRef ___ref______nl__7 = null;
Dictionary<String, Imm> __function_map;
//line 1220
___nl__5 = ((ImmHash)___nl__0).getHashValue()["name"].clone();
//line 1220
___nl__4 = hash_NL.NL_has_key(___nl__2,___nl__5).clone();

//line 1220
___nl__5 = null;
//line 1220
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 1220
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 1220
___nl__5 = new ImmString("variable `").clone();
//line 1220
___nl__6 = ((ImmHash)___nl__0).getHashValue()["name"].clone();
//line 1220
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 1220
___nl__6 = null;
//line 1220
___nl__6 = new ImmString("' already exists").clone();
//line 1220
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 1220
___nl__6 = null;
//line 1220
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 1220
___nl__5 = null;
//line 1220
if (true) {goto label_2;}
//line 1220
label_2:
//line 1220
___nl__4 = null;
//line 1221
___nl__4 = type_checker_NL.NL_is_known_priv(___nl__1).clone();

//line 1221
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 1221
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_4;}}
//line 1222
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("no")).clone();
//line 1222
___nl__7 = ((ImmHash)___nl__1).getHashValue()["type"].clone();
//line 1222
__function_map = new Dictionary<String, Imm>();
__function_map.Add("overwrited",___nl__6);
__function_map.Add("type",___nl__7);
___nl__5 = new ImmHash(__function_map).clone();
//line 1222
___nl__6 = null;
//line 1222
___nl__7 = null;
//line 1222
___nl__6 = ((ImmHash)___nl__0).getHashValue()["name"].clone();
//line 1222
___ref______nl__2 = new ImmRef(___nl__2);
type_checker_NL.NL_add_var_to_vars_priv(___nl__5,___nl__6,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 1222
___nl__6 = null;
//line 1222
___nl__5 = null;
//line 1223
if (true) {goto label_3;}
//line 1223
label_4:
//line 1224
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("yes")).clone();
//line 1224
___nl__7 = ((ImmHash)___nl__1).getHashValue()["type"].clone();
//line 1224
__function_map = new Dictionary<String, Imm>();
__function_map.Add("overwrited",___nl__6);
__function_map.Add("type",___nl__7);
___nl__5 = new ImmHash(__function_map).clone();
//line 1224
___nl__6 = null;
//line 1224
___nl__7 = null;
//line 1224
___nl__6 = ((ImmHash)___nl__0).getHashValue()["name"].clone();
//line 1224
___ref______nl__2 = new ImmRef(___nl__2);
type_checker_NL.NL_add_var_to_vars_priv(___nl__5,___nl__6,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 1224
___nl__6 = null;
//line 1224
___nl__5 = null;
//line 1225
if (true) {goto label_3;}
//line 1225
label_3:
//line 1225
___nl__4 = null;
//line 1225
___nl__0 = null;
//line 1225
___nl__1 = null;
//line 1225
___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return null;
}

private static Imm NL_is_known_priv(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 1228
___nl__2 = ((ImmHash)___nl__0).getHashValue()["src"].clone();
//line 1228
___nl__1 = ptd_system_NL.NL_is_known(___nl__2).clone();

//line 1228
___nl__2 = null;
//line 1228
___nl__0 = null;
//line 1228
if(true) return ___nl__1;
//line 1228
___nl__1 = null;
//line 1228
___nl__0 = null;
//line 1228
if(true) return null;
}

private static Imm NL_get_function_name_priv(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();
Imm ___nl__2 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 1231
___nl__2 = new ImmString("").clone();
//line 1231
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!___nl__0.toString().Equals(___nl__2.toString())).clone();
//line 1231
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 1231
___nl__2 = new ImmString("").clone();
//line 1231
if (true) {goto label_1;}
//line 1231
label_2:
//line 1231
___nl__2 = new ImmString("::").clone();
//line 1231
___nl__2 = new ImmString(___nl__0.toString() + ___nl__2.toString()).clone();
//line 1231
label_1:
//line 1231
___nl__2 = new ImmString(___nl__2.toString() + ___nl__1.toString()).clone();
//line 1231
___nl__0 = null;
//line 1231
___nl__1 = null;
//line 1231
if(true) return ___nl__2;
//line 1231
___nl__2 = null;
//line 1231
___nl__0 = null;
//line 1231
___nl__1 = null;
//line 1231
if(true) return null;
}

private static Imm NL_get_fun_module_priv(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();
Imm ___nl__2 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 1235
___nl__2 = new ImmString("").clone();
//line 1235
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__2.toString())).clone();
//line 1235
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 1235
___nl__2 = ___nl__0.clone();
//line 1235
if (true) {goto label_1;}
//line 1235
label_2:
//line 1235
___nl__2 = ___nl__1.clone();
//line 1235
label_1:
//line 1235
___nl__0 = null;
//line 1235
___nl__1 = null;
//line 1235
if(true) return ___nl__2;
//line 1235
___nl__2 = null;
//line 1235
___nl__0 = null;
//line 1235
___nl__1 = null;
//line 1235
if(true) return null;
}

private static Imm NL_get_function_def_priv(Imm ___arg__0, Imm ___arg__1, Imm ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
ImmRef ___ref______nl__6 = null;
ImmRef ___ref______nl__7 = null;
Dictionary<String, Imm> __function_map;
//line 1240
___nl__5 = ((ImmHash)___nl__2).getHashValue()["funs"].clone();
//line 1240
___nl__7 = ((ImmHash)___nl__2).getHashValue()["env"].clone();
//line 1240
___nl__7 = ((ImmHash)___nl__7).getHashValue()["current_module"].clone();
//line 1240
___nl__6 = type_checker_NL.NL_get_fun_module_priv(___nl__0,___nl__7).clone();

//line 1240
___nl__7 = null;
//line 1240
___nl__4 = hash_NL.NL_get_value(___nl__5,___nl__6).clone();

//line 1240
___nl__6 = null;
//line 1240
___nl__5 = null;
//line 1240
___nl__5 = type_checker_NL.NL_get_fun_key_priv(___nl__1,___nl__0).clone();

//line 1240
___nl__3 = hash_NL.NL_get_value(___nl__4,___nl__5).clone();

//line 1240
___nl__5 = null;
//line 1240
___nl__4 = null;
//line 1240
___nl__0 = null;
//line 1240
___nl__1 = null;
//line 1240
___nl__2 = null;
//line 1240
if(true) return ___nl__3;
//line 1240
___nl__3 = null;
//line 1240
___nl__0 = null;
//line 1240
___nl__1 = null;
//line 1240
___nl__2 = null;
//line 1240
if(true) return null;
}

private static Imm NL_check_function_exists_priv(Imm ___arg__0, Imm ___arg__1, ImmRef ___arg__2, ImmRef ___arg__3) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.getValue().clone();Imm ___nl__3 = ___arg__3.getValue().clone();
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
ImmRef ___ref______nl__6 = null;
ImmRef ___ref______nl__7 = null;
ImmRef ___ref______nl__8 = null;
Dictionary<String, Imm> __function_map;
//line 1246
___nl__5 = ((ImmHash)___nl__2).getHashValue()["env"].clone();
//line 1246
___nl__5 = ((ImmHash)___nl__5).getHashValue()["current_module"].clone();
//line 1246
___nl__4 = type_checker_NL.NL_get_fun_module_priv(___nl__0,___nl__5).clone();

//line 1246
___nl__5 = null;
//line 1247
___nl__6 = ((ImmHash)___nl__2).getHashValue()["imports"].clone();
//line 1247
___nl__5 = hash_NL.NL_has_key(___nl__6,___nl__4).clone();

//line 1247
___nl__6 = null;
//line 1247
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 1247
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_3;}}
//line 1247
___nl__6 = ((ImmHash)___nl__2).getHashValue()["imports"].clone();
//line 1247
___nl__5 = hash_NL.NL_get_value(___nl__6,___nl__4).clone();

//line 1247
___nl__6 = null;
//line 1247
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 1247
label_3:
//line 1247
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 1247
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_2;}}
//line 1248
___nl__7 = ((ImmHash)___nl__2).getHashValue()["imports"].clone();
//line 1248
___nl__6 = hash_NL.NL_has_key(___nl__7,___nl__4).clone();

//line 1248
___nl__7 = null;
//line 1248
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 1248
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 1248
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_5;}}
//line 1248
___nl__7 = new ImmString("module '").clone();
//line 1248
___nl__7 = new ImmString(___nl__7.toString() + ___nl__4.toString()).clone();
//line 1248
___nl__8 = new ImmString("' not imported").clone();
//line 1248
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 1248
___nl__8 = null;
//line 1248
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__7);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 1248
___nl__7 = null;
//line 1248
if (true) {goto label_5;}
//line 1248
label_5:
//line 1248
___nl__6 = null;
//line 1249
___nl__6 = new ImmString("imports").clone();
//line 1249
___nl__6 = c_rt_lib_NL.NL_get_ref_hash(___nl__2,___nl__6).clone();

//line 1249
___nl__7 = c_rt_lib_NL.NL_get_false().clone();
//line 1249
___ref______nl__6 = new ImmRef(___nl__6);
hash_NL.NL_set_value(___ref______nl__6,___nl__4,___nl__7);
___nl__6 = ___ref______nl__6.getValue().clone();

//line 1249
___nl__7 = null;
//line 1249
___nl__7 = new ImmString("imports").clone();
//line 1249
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__2,___nl__7,___nl__6);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 1249
___nl__7 = null;
//line 1249
___nl__6 = null;
//line 1250
___nl__6 = c_rt_lib_NL.NL_get_false().clone();
//line 1250
___nl__0 = null;
//line 1250
___nl__1 = null;
//line 1250
___nl__4 = null;
//line 1250
___nl__5 = null;
//line 1250
___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__6;
//line 1250
___nl__6 = null;
//line 1251
if (true) {goto label_6;}
//line 1251
label_2:
//line 1251
___nl__6 = ((ImmHash)___nl__2).getHashValue()["funs"].clone();
//line 1251
___nl__5 = hash_NL.NL_has_key(___nl__6,___nl__4).clone();

//line 1251
___nl__6 = null;
//line 1251
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 1251
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 1251
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_6;}}
//line 1252
___nl__6 = c_rt_lib_NL.NL_get_false().clone();
//line 1252
___nl__0 = null;
//line 1252
___nl__1 = null;
//line 1252
___nl__4 = null;
//line 1252
___nl__5 = null;
//line 1252
___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__6;
//line 1252
___nl__6 = null;
//line 1253
if (true) {goto label_6;}
//line 1253
label_6:
//line 1253
___nl__5 = null;
//line 1255
___nl__7 = ((ImmHash)___nl__2).getHashValue()["funs"].clone();
//line 1255
___nl__6 = hash_NL.NL_get_value(___nl__7,___nl__4).clone();

//line 1255
___nl__7 = null;
//line 1255
___nl__7 = type_checker_NL.NL_get_fun_key_priv(___nl__1,___nl__0).clone();

//line 1255
___nl__5 = hash_NL.NL_has_key(___nl__6,___nl__7).clone();

//line 1255
___nl__7 = null;
//line 1255
___nl__6 = null;
//line 1255
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 1255
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 1255
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_8;}}
//line 1256
___nl__6 = new ImmString("function `").clone();
//line 1256
___nl__7 = type_checker_NL.NL_get_function_name_priv(___nl__0,___nl__1).clone();

//line 1256
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 1256
___nl__7 = null;
//line 1256
___nl__7 = new ImmString("' does not exist").clone();
//line 1256
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 1256
___nl__7 = null;
//line 1256
___ref______nl__3 = new ImmRef(___nl__3);
type_checker_NL.NL_add_error_priv(___ref______nl__3,___nl__6);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 1256
___nl__6 = null;
//line 1257
___nl__6 = c_rt_lib_NL.NL_get_false().clone();
//line 1257
___nl__0 = null;
//line 1257
___nl__1 = null;
//line 1257
___nl__4 = null;
//line 1257
___nl__5 = null;
//line 1257
___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__6;
//line 1257
___nl__6 = null;
//line 1258
if (true) {goto label_8;}
//line 1258
label_8:
//line 1258
___nl__5 = null;
//line 1260
___nl__5 = c_rt_lib_NL.NL_get_true().clone();
//line 1260
___nl__0 = null;
//line 1260
___nl__1 = null;
//line 1260
___nl__4 = null;
//line 1260
___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__5;
//line 1260
___nl__5 = null;
//line 1260
___nl__4 = null;
//line 1260
___nl__0 = null;
//line 1260
___nl__1 = null;
//line 1260
___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return null;
}

private static Imm NL_add_error_priv(ImmRef ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
Dictionary<String, Imm> __function_map;
//line 1264
___nl__2 = new ImmString("errors").clone();
//line 1264
___nl__2 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__2).clone();

//line 1264
___nl__4 = ((ImmHash)___nl__0).getHashValue()["current_line"].clone();
//line 1264
___nl__5 = ((ImmHash)___nl__0).getHashValue()["module"].clone();
//line 1264
__function_map = new Dictionary<String, Imm>();
__function_map.Add("msg",___nl__1);
__function_map.Add("line",___nl__4);
__function_map.Add("module",___nl__5);
___nl__3 = new ImmHash(__function_map).clone();
//line 1264
___nl__4 = null;
//line 1264
___nl__5 = null;
//line 1264
___ref______nl__2 = new ImmRef(___nl__2);
array_NL.NL_push(___ref______nl__2,___nl__3);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 1264
___nl__3 = null;
//line 1264
___nl__3 = new ImmString("errors").clone();
//line 1264
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__3,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 1264
___nl__3 = null;
//line 1264
___nl__2 = null;
//line 1264
___nl__1 = null;
//line 1264
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_add_warning_priv(ImmRef ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
Dictionary<String, Imm> __function_map;
//line 1267
___nl__2 = new ImmString("warnings").clone();
//line 1267
___nl__2 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__2).clone();

//line 1267
___nl__4 = ((ImmHash)___nl__0).getHashValue()["current_line"].clone();
//line 1267
___nl__5 = ((ImmHash)___nl__0).getHashValue()["module"].clone();
//line 1267
__function_map = new Dictionary<String, Imm>();
__function_map.Add("msg",___nl__1);
__function_map.Add("line",___nl__4);
__function_map.Add("module",___nl__5);
___nl__3 = new ImmHash(__function_map).clone();
//line 1267
___nl__4 = null;
//line 1267
___nl__5 = null;
//line 1267
___ref______nl__2 = new ImmRef(___nl__2);
array_NL.NL_push(___ref______nl__2,___nl__3);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 1267
___nl__3 = null;
//line 1267
___nl__3 = new ImmString("warnings").clone();
//line 1267
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__3,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 1267
___nl__3 = null;
//line 1267
___nl__2 = null;
//line 1267
___nl__1 = null;
//line 1267
___arg__0.setValue(___nl__0);if(true) return null;
}

}
}