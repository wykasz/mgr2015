using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class ptd_system_NL {

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
//line 16
___nl__2 = new ImmString("errors").clone();
//line 16
___nl__2 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__2).clone();

//line 16
___nl__4 = ((ImmHash)___nl__0).getHashValue()["current_line"].clone();
//line 16
___nl__5 = ((ImmHash)___nl__0).getHashValue()["module"].clone();
//line 16
__function_map = new Dictionary<String, Imm>();
__function_map.Add("msg",___nl__1);
__function_map.Add("line",___nl__4);
__function_map.Add("module",___nl__5);
___nl__3 = new ImmHash(__function_map).clone();
//line 16
___nl__4 = null;
//line 16
___nl__5 = null;
//line 16
___ref______nl__2 = new ImmRef(___nl__2);
array_NL.NL_push(___ref______nl__2,___nl__3);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 16
___nl__3 = null;
//line 16
___nl__3 = new ImmString("errors").clone();
//line 16
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__3,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 16
___nl__3 = null;
//line 16
___nl__2 = null;
//line 16
___nl__1 = null;
//line 16
___arg__0.setValue(___nl__0);if(true) return null;
}

public static Imm NL_is_known(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 19
___nl__2 = new ImmString("known").clone();
//line 19
___nl__1 = ov_NL.NL_is(___nl__0,___nl__2).clone();

//line 19
___nl__2 = null;
//line 19
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_1;}}
//line 19
___nl__2 = new ImmString("knownhash").clone();
//line 19
___nl__1 = ov_NL.NL_is(___nl__0,___nl__2).clone();

//line 19
___nl__2 = null;
//line 19
label_1:
//line 19
___nl__0 = null;
//line 19
if(true) return ___nl__1;
//line 19
___nl__1 = null;
//line 19
___nl__0 = null;
//line 19
if(true) return null;
}

public static Imm NL_is_equal(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();
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
//line 22
___nl__2 = ov_NL.NL_get_element(___nl__0).clone();

//line 22
___nl__3 = ov_NL.NL_get_element(___nl__1).clone();

//line 22
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 22
___nl__3 = null;
//line 22
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 22
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 22
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 22
___nl__3 = c_rt_lib_NL.NL_get_false().clone();
//line 22
___nl__0 = null;
//line 22
___nl__1 = null;
//line 22
___nl__2 = null;
//line 22
if(true) return ___nl__3;
//line 22
___nl__3 = null;
//line 22
if (true) {goto label_2;}
//line 22
label_2:
//line 22
___nl__2 = null;
//line 23
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_im")).clone();
//line 23
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_4;}}
//line 24
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_arr")).clone();
//line 24
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_5;}}
//line 26
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_hash")).clone();
//line 26
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_6;}}
//line 28
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_rec")).clone();
//line 28
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_7;}}
//line 34
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_ref")).clone();
//line 34
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_8;}}
//line 36
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_sim")).clone();
//line 36
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_9;}}
//line 37
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_var")).clone();
//line 37
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_10;}}
//line 49
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_empty")).clone();
//line 49
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_11;}}
//line 50
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_void")).clone();
//line 50
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_12;}}
//line 50
___nl__2 = new ImmString("NOMATCHALERT").clone();
//line 50
___nl__2 = new ImmArray(new Imm[] {___nl__2,___nl__0,}).clone();
//line 50
c_rt_lib_NL.NL_die();
//line 23
label_4:
//line 24
if (true) {goto label_3;}
//line 24
label_5:
//line 24
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("tct_arr")).clone();
//line 25
___nl__5 = ___nl__1.clone();
//line 25
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("tct_arr")).clone();
//line 25
___nl__4 = ptd_system_NL.NL_is_equal(___nl__3,___nl__5).clone();

//line 25
___nl__5 = null;
//line 25
___nl__0 = null;
//line 25
___nl__1 = null;
//line 25
___nl__2 = null;
//line 25
___nl__3 = null;
//line 25
if(true) return ___nl__4;
//line 25
___nl__4 = null;
//line 25
___nl__3 = null;
//line 26
if (true) {goto label_3;}
//line 26
label_6:
//line 26
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("tct_hash")).clone();
//line 27
___nl__5 = ___nl__1.clone();
//line 27
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("tct_hash")).clone();
//line 27
___nl__4 = ptd_system_NL.NL_is_equal(___nl__3,___nl__5).clone();

//line 27
___nl__5 = null;
//line 27
___nl__0 = null;
//line 27
___nl__1 = null;
//line 27
___nl__2 = null;
//line 27
___nl__3 = null;
//line 27
if(true) return ___nl__4;
//line 27
___nl__4 = null;
//line 27
___nl__3 = null;
//line 28
if (true) {goto label_3;}
//line 28
label_7:
//line 28
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("tct_rec")).clone();
//line 29
___nl__5 = ___nl__1.clone();
//line 29
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("tct_rec")).clone();
//line 29
___nl__4 = hash_NL.NL_size(___nl__5).clone();

//line 29
___nl__5 = null;
//line 29
___nl__5 = hash_NL.NL_size(___nl__3).clone();

//line 29
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString())) !=((Double.Parse(___nl__5.getValue().ToString())))  ).clone();
//line 29
___nl__5 = null;
//line 29
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 29
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_14;}}
//line 29
___nl__5 = c_rt_lib_NL.NL_get_false().clone();
//line 29
___nl__0 = null;
//line 29
___nl__1 = null;
//line 29
___nl__2 = null;
//line 29
___nl__3 = null;
//line 29
___nl__4 = null;
//line 29
if(true) return ___nl__5;
//line 29
___nl__5 = null;
//line 29
if (true) {goto label_14;}
//line 29
label_14:
//line 29
___nl__4 = null;
//line 30
___nl__6 = c_rt_lib_NL.NL_init_iter(___nl__3).clone();

//line 30
label_17:
//line 30
___nl__4 = c_rt_lib_NL.NL_is_end_hash(___nl__6).clone();

//line 30
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_15;}}
//line 30
___nl__4 = c_rt_lib_NL.NL_get_key_iter(___nl__6).clone();

//line 30
___nl__5 = c_rt_lib_NL.NL_hash_get_value(___nl__3,___nl__4).clone();

//line 31
___nl__8 = ___nl__1.clone();
//line 31
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__8, new ImmString("tct_rec")).clone();
//line 31
___nl__7 = hash_NL.NL_has_key(___nl__8,___nl__4).clone();

//line 31
___nl__8 = null;
//line 31
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 31
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 31
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_19;}}
//line 31
___nl__8 = c_rt_lib_NL.NL_get_false().clone();
//line 31
___nl__0 = null;
//line 31
___nl__1 = null;
//line 31
___nl__2 = null;
//line 31
___nl__3 = null;
//line 31
___nl__4 = null;
//line 31
___nl__5 = null;
//line 31
___nl__6 = null;
//line 31
___nl__7 = null;
//line 31
if(true) return ___nl__8;
//line 31
___nl__8 = null;
//line 31
if (true) {goto label_19;}
//line 31
label_19:
//line 31
___nl__7 = null;
//line 32
___nl__9 = ___nl__1.clone();
//line 32
___nl__9 = c_rt_lib_NL.NL_ov_as(___nl__9, new ImmString("tct_rec")).clone();
//line 32
___nl__8 = hash_NL.NL_get_value(___nl__9,___nl__4).clone();

//line 32
___nl__9 = null;
//line 32
___nl__7 = ptd_system_NL.NL_is_equal(___nl__5,___nl__8).clone();

//line 32
___nl__8 = null;
//line 32
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 32
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 32
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_21;}}
//line 32
___nl__8 = c_rt_lib_NL.NL_get_false().clone();
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
___nl__5 = null;
//line 32
___nl__6 = null;
//line 32
___nl__7 = null;
//line 32
if(true) return ___nl__8;
//line 32
___nl__8 = null;
//line 32
if (true) {goto label_21;}
//line 32
label_21:
//line 32
___nl__7 = null;
//line 33
___nl__6 = c_rt_lib_NL.NL_next_iter(___nl__6).clone();

//line 33
if (true) {goto label_17;}
//line 33
label_15:
//line 33
___nl__4 = null;
//line 33
___nl__5 = null;
//line 33
___nl__6 = null;
//line 33
___nl__3 = null;
//line 34
if (true) {goto label_3;}
//line 34
label_8:
//line 34
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("tct_ref")).clone();
//line 35
___nl__4 = ___nl__1.clone();
//line 35
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("tct_ref")).clone();
//line 35
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__4.toString())).clone();
//line 35
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 35
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 35
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_23;}}
//line 35
___nl__5 = c_rt_lib_NL.NL_get_false().clone();
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
if(true) return ___nl__5;
//line 35
___nl__5 = null;
//line 35
if (true) {goto label_23;}
//line 35
label_23:
//line 35
___nl__4 = null;
//line 35
___nl__3 = null;
//line 36
if (true) {goto label_3;}
//line 36
label_9:
//line 37
if (true) {goto label_3;}
//line 37
label_10:
//line 37
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("tct_var")).clone();
//line 38
___nl__5 = ___nl__1.clone();
//line 38
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("tct_var")).clone();
//line 38
___nl__4 = hash_NL.NL_size(___nl__5).clone();

//line 38
___nl__5 = null;
//line 38
___nl__5 = hash_NL.NL_size(___nl__3).clone();

//line 38
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString())) !=((Double.Parse(___nl__5.getValue().ToString())))  ).clone();
//line 38
___nl__5 = null;
//line 38
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 38
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_25;}}
//line 38
___nl__5 = c_rt_lib_NL.NL_get_false().clone();
//line 38
___nl__0 = null;
//line 38
___nl__1 = null;
//line 38
___nl__2 = null;
//line 38
___nl__3 = null;
//line 38
___nl__4 = null;
//line 38
if(true) return ___nl__5;
//line 38
___nl__5 = null;
//line 38
if (true) {goto label_25;}
//line 38
label_25:
//line 38
___nl__4 = null;
//line 39
___nl__6 = c_rt_lib_NL.NL_init_iter(___nl__3).clone();

//line 39
label_28:
//line 39
___nl__4 = c_rt_lib_NL.NL_is_end_hash(___nl__6).clone();

//line 39
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_26;}}
//line 39
___nl__4 = c_rt_lib_NL.NL_get_key_iter(___nl__6).clone();

//line 39
___nl__5 = c_rt_lib_NL.NL_hash_get_value(___nl__3,___nl__4).clone();

//line 40
___nl__8 = ___nl__1.clone();
//line 40
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__8, new ImmString("tct_var")).clone();
//line 40
___nl__7 = hash_NL.NL_has_key(___nl__8,___nl__4).clone();

//line 40
___nl__8 = null;
//line 40
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 40
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 40
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_30;}}
//line 40
___nl__8 = c_rt_lib_NL.NL_get_false().clone();
//line 40
___nl__0 = null;
//line 40
___nl__1 = null;
//line 40
___nl__2 = null;
//line 40
___nl__3 = null;
//line 40
___nl__4 = null;
//line 40
___nl__5 = null;
//line 40
___nl__6 = null;
//line 40
___nl__7 = null;
//line 40
if(true) return ___nl__8;
//line 40
___nl__8 = null;
//line 40
if (true) {goto label_30;}
//line 40
label_30:
//line 40
___nl__7 = null;
//line 41
___nl__8 = ___nl__1.clone();
//line 41
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__8, new ImmString("tct_var")).clone();
//line 41
___nl__7 = hash_NL.NL_get_value(___nl__8,___nl__4).clone();

//line 41
___nl__8 = null;
//line 42
___nl__10 = new ImmString("no_param").clone();
//line 42
___nl__8 = ov_NL.NL_is(___nl__5,___nl__10).clone();

//line 42
___nl__10 = null;
//line 42
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 42
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_33;}}
//line 42
___nl__10 = new ImmString("no_param").clone();
//line 42
___nl__8 = ov_NL.NL_is(___nl__7,___nl__10).clone();

//line 42
___nl__10 = null;
//line 42
label_33:
//line 42
___nl__9 = null;
//line 42
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 42
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_32;}}
//line 42
___nl__7 = null;
//line 42
___nl__8 = null;
//line 42
if (true) {goto label_27;}
//line 42
if (true) {goto label_32;}
//line 42
label_32:
//line 42
___nl__8 = null;
//line 43
___nl__10 = new ImmString("with_param").clone();
//line 43
___nl__8 = ov_NL.NL_is(___nl__5,___nl__10).clone();

//line 43
___nl__10 = null;
//line 43
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 43
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_36;}}
//line 43
___nl__10 = new ImmString("with_param").clone();
//line 43
___nl__8 = ov_NL.NL_is(___nl__7,___nl__10).clone();

//line 43
___nl__10 = null;
//line 43
label_36:
//line 43
___nl__9 = null;
//line 43
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 43
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 43
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_35;}}
//line 43
___nl__9 = c_rt_lib_NL.NL_get_false().clone();
//line 43
___nl__0 = null;
//line 43
___nl__1 = null;
//line 43
___nl__2 = null;
//line 43
___nl__3 = null;
//line 43
___nl__4 = null;
//line 43
___nl__5 = null;
//line 43
___nl__6 = null;
//line 43
___nl__7 = null;
//line 43
___nl__8 = null;
//line 43
if(true) return ___nl__9;
//line 43
___nl__9 = null;
//line 43
if (true) {goto label_35;}
//line 43
label_35:
//line 43
___nl__8 = null;
//line 44
___nl__9 = ___nl__7.clone();
//line 44
___nl__9 = c_rt_lib_NL.NL_ov_as(___nl__9, new ImmString("with_param")).clone();
//line 44
___nl__10 = ___nl__5.clone();
//line 44
___nl__10 = c_rt_lib_NL.NL_ov_as(___nl__10, new ImmString("with_param")).clone();
//line 44
___nl__8 = ptd_system_NL.NL_is_equal(___nl__9,___nl__10).clone();

//line 44
___nl__10 = null;
//line 44
___nl__9 = null;
//line 44
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 44
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 44
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_38;}}
//line 44
___nl__9 = c_rt_lib_NL.NL_get_false().clone();
//line 44
___nl__0 = null;
//line 44
___nl__1 = null;
//line 44
___nl__2 = null;
//line 44
___nl__3 = null;
//line 44
___nl__4 = null;
//line 44
___nl__5 = null;
//line 44
___nl__6 = null;
//line 44
___nl__7 = null;
//line 44
___nl__8 = null;
//line 44
if(true) return ___nl__9;
//line 44
___nl__9 = null;
//line 44
if (true) {goto label_38;}
//line 44
label_38:
//line 44
___nl__8 = null;
//line 44
___nl__7 = null;
//line 44
label_27:
//line 48
___nl__6 = c_rt_lib_NL.NL_next_iter(___nl__6).clone();

//line 48
if (true) {goto label_28;}
//line 48
label_26:
//line 48
___nl__4 = null;
//line 48
___nl__5 = null;
//line 48
___nl__6 = null;
//line 48
___nl__3 = null;
//line 49
if (true) {goto label_3;}
//line 49
label_11:
//line 50
if (true) {goto label_3;}
//line 50
label_12:
//line 51
if (true) {goto label_3;}
//line 51
label_3:
//line 51
___nl__2 = null;
//line 52
___nl__2 = c_rt_lib_NL.NL_get_true().clone();
//line 52
___nl__0 = null;
//line 52
___nl__1 = null;
//line 52
if(true) return ___nl__2;
//line 52
___nl__2 = null;
//line 52
___nl__0 = null;
//line 52
___nl__1 = null;
//line 52
if(true) return null;
}

public static Imm NL_is_try_ensure_type(Imm ___arg__0, ImmRef ___arg__1, ImmRef ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();Imm ___nl__2 = ___arg__2.getValue().clone();
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
//line 56
___nl__6 = tct_NL.NL_tct_im().clone();

//line 56
___nl__7 = tct_NL.NL_tct_im().clone();

//line 56
__function_map = new Dictionary<String, Imm>();
__function_map.Add("ok",___nl__6);
__function_map.Add("err",___nl__7);
___nl__5 = new ImmHash(__function_map).clone();
//line 56
___nl__6 = null;
//line 56
___nl__7 = null;
//line 56
___nl__4 = tct_NL.NL_tct_var(___nl__5).clone();

//line 56
___nl__5 = null;
//line 56
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___nl__3 = ptd_system_NL.NL_is_accepted(___nl__0,___nl__4,___ref______nl__1,___ref______nl__2).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 56
___nl__4 = null;
//line 56
___nl__0 = null;
//line 56
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 56
___nl__3 = null;
//line 56
___nl__0 = null;
//line 56
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return null;
}

public static Imm NL_get_try_ensure_ok_type(Imm ___arg__0, ImmRef ___arg__1, ImmRef ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();Imm ___nl__2 = ___arg__2.getValue().clone();
Imm ___nl__3 = null;
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
//line 60
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___nl__3 = ptd_system_NL.NL_can_delete(___nl__0,___ref______nl__1,___ref______nl__2).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 60
___nl__0 = ___nl__3.clone();
//line 60
___nl__3 = null;
//line 61
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___nl__3 = ptd_system_NL.NL_is_try_ensure_type(___nl__0,___ref______nl__1,___ref______nl__2).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 61
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 61
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 62
___nl__5 = ((ImmHash)___nl__0).getHashValue()["type"].clone();
//line 62
___nl__6 = new ImmString("tct_im").clone();
//line 62
___nl__4 = ov_NL.NL_is(___nl__5,___nl__6).clone();

//line 62
___nl__6 = null;
//line 62
___nl__5 = null;
//line 62
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 62
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_4;}}
//line 62
___nl__5 = tct_NL.NL_tct_im().clone();

//line 62
___nl__0 = null;
//line 62
___nl__3 = null;
//line 62
___nl__4 = null;
//line 62
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__5;
//line 62
___nl__5 = null;
//line 62
if (true) {goto label_4;}
//line 62
label_4:
//line 62
___nl__4 = null;
//line 63
___nl__5 = ((ImmHash)___nl__0).getHashValue()["type"].clone();
//line 63
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("tct_var")).clone();
//line 63
___nl__6 = new ImmString("ok").clone();
//line 63
___nl__4 = hash_NL.NL_get_value(___nl__5,___nl__6).clone();

//line 63
___nl__6 = null;
//line 63
___nl__5 = null;
//line 64
___nl__6 = new ImmString("no_param").clone();
//line 64
___nl__5 = ov_NL.NL_is(___nl__4,___nl__6).clone();

//line 64
___nl__6 = null;
//line 64
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 64
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_6;}}
//line 64
___nl__6 = tct_NL.NL_tct_empty().clone();

//line 64
___nl__0 = null;
//line 64
___nl__3 = null;
//line 64
___nl__4 = null;
//line 64
___nl__5 = null;
//line 64
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__6;
//line 64
___nl__6 = null;
//line 64
if (true) {goto label_6;}
//line 64
label_6:
//line 64
___nl__5 = null;
//line 65
___nl__5 = ___nl__4.clone();
//line 65
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("with_param")).clone();
//line 65
___nl__0 = null;
//line 65
___nl__3 = null;
//line 65
___nl__4 = null;
//line 65
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__5;
//line 65
___nl__5 = null;
//line 65
___nl__4 = null;
//line 66
if (true) {goto label_1;}
//line 66
label_2:
//line 67
___nl__4 = new ImmString("in try|ensure expr; expr must be variant: ok|err").clone();
//line 67
___ref______nl__2 = new ImmRef(___nl__2);
ptd_system_NL.NL_add_error_priv(___ref______nl__2,___nl__4);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 67
___nl__4 = null;
//line 68
___nl__4 = tct_NL.NL_tct_im().clone();

//line 68
___nl__0 = null;
//line 68
___nl__3 = null;
//line 68
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__4;
//line 68
___nl__4 = null;
//line 69
if (true) {goto label_1;}
//line 69
label_1:
//line 69
___nl__3 = null;
//line 69
___nl__0 = null;
//line 69
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return null;
}

public static Imm NL_is_condition_type(Imm ___arg__0, ImmRef ___arg__1, ImmRef ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();Imm ___nl__2 = ___arg__2.getValue().clone();
Imm ___nl__3 = null;
Imm ___nl__4 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 74
___nl__4 = tct_NL.NL_tct_bool().clone();

//line 74
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___nl__3 = ptd_system_NL.NL_is_accepted(___nl__0,___nl__4,___ref______nl__1,___ref______nl__2).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 74
___nl__4 = null;
//line 74
___nl__0 = null;
//line 74
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 74
___nl__3 = null;
//line 74
___nl__0 = null;
//line 74
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return null;
}

public static Imm NL_is_accepted(Imm ___arg__0, Imm ___arg__1, ImmRef ___arg__2, ImmRef ___arg__3) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.getValue().clone();Imm ___nl__3 = ___arg__3.getValue().clone();
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
//line 79
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__4 = ptd_system_NL.NL_is_accepted_info(___nl__0,___nl__1,___ref______nl__2,___ref______nl__3).clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 80
___nl__6 = new ImmString("ok").clone();
//line 80
___nl__5 = ov_NL.NL_is(___nl__4,___nl__6).clone();

//line 80
___nl__6 = null;
//line 80
___nl__0 = null;
//line 80
___nl__1 = null;
//line 80
___nl__4 = null;
//line 80
___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__5;
//line 80
___nl__5 = null;
//line 80
___nl__4 = null;
//line 80
___nl__0 = null;
//line 80
___nl__1 = null;
//line 80
___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return null;
}

public static Imm NL_is_accepted_info(Imm ___arg__0, Imm ___arg__1, ImmRef ___arg__2, ImmRef ___arg__3) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.getValue().clone();Imm ___nl__3 = ___arg__3.getValue().clone();
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
//line 84
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__4 = ptd_system_NL.NL_can_delete(___nl__0,___ref______nl__2,___ref______nl__3).clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 84
___nl__0 = ___nl__4.clone();
//line 84
___nl__4 = null;
//line 85
___nl__5 = ((ImmHash)___nl__0).getHashValue()["type"].clone();
//line 85
___nl__6 = new ImmString("tct_im").clone();
//line 85
___nl__4 = ov_NL.NL_is(___nl__5,___nl__6).clone();

//line 85
___nl__6 = null;
//line 85
___nl__5 = null;
//line 85
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 85
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 85
___nl__5 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("ok")).clone();
//line 85
___nl__0 = null;
//line 85
___nl__1 = null;
//line 85
___nl__4 = null;
//line 85
___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__5;
//line 85
___nl__5 = null;
//line 85
if (true) {goto label_2;}
//line 85
label_2:
//line 85
___nl__4 = null;
//line 86
___nl__5 = new ImmString("tct_rec").clone();
//line 86
___nl__4 = ov_NL.NL_is(___nl__1,___nl__5).clone();

//line 86
___nl__5 = null;
//line 86
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 86
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_4;}}
//line 87
___nl__8 = new ImmString("tct_rec").clone();
//line 87
___nl__7 = ov_NL.NL_as(___nl__1,___nl__8).clone();

//line 87
___nl__8 = null;
//line 87
___nl__5 = hash_NL.NL_size(___nl__7).clone();

//line 87
___nl__7 = null;
//line 87
___nl__7 = new ImmDouble(0).clone();
//line 87
___nl__5 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString())) ==((Double.Parse(___nl__7.getValue().ToString())))  ).clone();
//line 87
___nl__7 = null;
//line 87
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 87
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_7;}}
//line 87
___nl__7 = ((ImmHash)___nl__0).getHashValue()["type"].clone();
//line 87
___nl__8 = new ImmString("tct_rec").clone();
//line 87
___nl__5 = ov_NL.NL_is(___nl__7,___nl__8).clone();

//line 87
___nl__8 = null;
//line 87
___nl__7 = null;
//line 87
label_7:
//line 87
___nl__6 = null;
//line 87
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 87
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_6;}}
//line 87
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("ok")).clone();
//line 87
___nl__0 = null;
//line 87
___nl__1 = null;
//line 87
___nl__4 = null;
//line 87
___nl__5 = null;
//line 87
___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__6;
//line 87
___nl__6 = null;
//line 87
if (true) {goto label_6;}
//line 87
label_6:
//line 87
___nl__5 = null;
//line 88
if (true) {goto label_8;}
//line 88
label_4:
//line 88
___nl__5 = new ImmString("tct_var").clone();
//line 88
___nl__4 = ov_NL.NL_is(___nl__1,___nl__5).clone();

//line 88
___nl__5 = null;
//line 88
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 88
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_8;}}
//line 89
___nl__8 = new ImmString("tct_var").clone();
//line 89
___nl__7 = ov_NL.NL_as(___nl__1,___nl__8).clone();

//line 89
___nl__8 = null;
//line 89
___nl__5 = hash_NL.NL_size(___nl__7).clone();

//line 89
___nl__7 = null;
//line 89
___nl__7 = new ImmDouble(0).clone();
//line 89
___nl__5 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString())) ==((Double.Parse(___nl__7.getValue().ToString())))  ).clone();
//line 89
___nl__7 = null;
//line 89
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 89
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_11;}}
//line 89
___nl__7 = ((ImmHash)___nl__0).getHashValue()["type"].clone();
//line 89
___nl__8 = new ImmString("tct_var").clone();
//line 89
___nl__5 = ov_NL.NL_is(___nl__7,___nl__8).clone();

//line 89
___nl__8 = null;
//line 89
___nl__7 = null;
//line 89
label_11:
//line 89
___nl__6 = null;
//line 89
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 89
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_10;}}
//line 89
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("ok")).clone();
//line 89
___nl__0 = null;
//line 89
___nl__1 = null;
//line 89
___nl__4 = null;
//line 89
___nl__5 = null;
//line 89
___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__6;
//line 89
___nl__6 = null;
//line 89
if (true) {goto label_10;}
//line 89
label_10:
//line 89
___nl__5 = null;
//line 90
if (true) {goto label_8;}
//line 90
label_8:
//line 90
___nl__4 = null;
//line 91
___nl__5 = new ImmDouble(1).clone();
//line 91
__function_map = new Dictionary<String, Imm>();
___nl__6 = new ImmHash(__function_map).clone();
//line 91
__function_map = new Dictionary<String, Imm>();
___nl__7 = new ImmHash(__function_map).clone();
//line 91
___nl__8 = c_rt_lib_NL.NL_get_false().clone();
//line 91
___nl__9 = c_rt_lib_NL.NL_get_false().clone();
//line 91
__function_map = new Dictionary<String, Imm>();
__function_map.Add("level",___nl__5);
__function_map.Add("from",___nl__6);
__function_map.Add("to",___nl__7);
__function_map.Add("check",___nl__8);
__function_map.Add("cast",___nl__9);
___nl__4 = new ImmHash(__function_map).clone();
//line 91
___nl__5 = null;
//line 91
___nl__6 = null;
//line 91
___nl__7 = null;
//line 91
___nl__8 = null;
//line 91
___nl__9 = null;
//line 92
___nl__6 = ((ImmHash)___nl__0).getHashValue()["type"].clone();
//line 92
___nl__7 = ((ImmHash)___nl__0).getHashValue()["src"].clone();
//line 92
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__5 = ptd_system_NL.NL_check_assignment_info_priv(___nl__1,___nl__6,___nl__4,___nl__7,___ref______nl__2,___ref______nl__3).clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 92
___nl__7 = null;
//line 92
___nl__6 = null;
//line 92
___nl__0 = null;
//line 92
___nl__1 = null;
//line 92
___nl__4 = null;
//line 92
___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__5;
//line 92
___nl__5 = null;
//line 92
___nl__4 = null;
//line 92
___nl__0 = null;
//line 92
___nl__1 = null;
//line 92
___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return null;
}

private static Imm NL_add_ref_name_priv(ImmRef ___arg__0, ImmRef ___arg__1, ImmRef ___arg__2, Imm ___arg__3, ImmRef ___arg__4, ImmRef ___arg__5) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.getValue().clone();Imm ___nl__2 = ___arg__2.getValue().clone();Imm ___nl__3 = ___arg__3.clone();Imm ___nl__4 = ___arg__4.getValue().clone();Imm ___nl__5 = ___arg__5.getValue().clone();
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
//line 98
___nl__6 = ___nl__0.clone();
//line 98
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("tct_ref")).clone();
//line 99
___nl__7 = hash_NL.NL_has_key(___nl__1,___nl__6).clone();

//line 99
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 99
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_2;}}
//line 99
___nl__8 = hash_NL.NL_get_value(___nl__1,___nl__6).clone();

//line 99
___nl__2 = ___nl__8.clone();
//line 99
___nl__8 = null;
//line 99
if (true) {goto label_2;}
//line 99
label_2:
//line 99
___nl__7 = null;
//line 100
___ref______nl__2 = new ImmRef(___nl__2);
array_NL.NL_push(___ref______nl__2,___nl__3);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 101
___ref______nl__1 = new ImmRef(___nl__1);
hash_NL.NL_set_value(___ref______nl__1,___nl__6,___nl__2);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 102
___ref______nl__4 = new ImmRef(___nl__4);
___ref______nl__5 = new ImmRef(___nl__5);
___nl__7 = ptd_system_NL.NL_get_ref_type(___nl__6,___ref______nl__4,___ref______nl__5).clone();
___nl__4 = ___ref______nl__4.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();

//line 102
___nl__0 = ___nl__7.clone();
//line 102
___nl__7 = null;
//line 103
___nl__3 = null;
//line 103
___arg__0.setValue(___nl__0);___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__6;
//line 103
___nl__6 = null;
//line 103
___nl__3 = null;
//line 103
___arg__0.setValue(___nl__0);___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return null;
}

private static Imm NL_is_cycle_ref_priv(ImmRef ___arg__0, ImmRef ___arg__1, ImmRef ___arg__2, Imm ___arg__3, Imm ___arg__4, ImmRef ___arg__5, ImmRef ___arg__6) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.getValue().clone();Imm ___nl__2 = ___arg__2.getValue().clone();Imm ___nl__3 = ___arg__3.clone();Imm ___nl__4 = ___arg__4.clone();Imm ___nl__5 = ___arg__5.getValue().clone();Imm ___nl__6 = ___arg__6.getValue().clone();
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
//line 108
___nl__9 = new ImmString("tct_ref").clone();
//line 108
___nl__7 = ov_NL.NL_is(___nl__0,___nl__9).clone();

//line 108
___nl__9 = null;
//line 108
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 108
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_3;}}
//line 108
___nl__9 = new ImmString("tct_ref").clone();
//line 108
___nl__7 = ov_NL.NL_is(___nl__1,___nl__9).clone();

//line 108
___nl__9 = null;
//line 108
label_3:
//line 108
___nl__8 = null;
//line 108
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 108
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_2;}}
//line 109
___nl__9 = new ImmString("tct_ref").clone();
//line 109
___nl__8 = ov_NL.NL_as(___nl__0,___nl__9).clone();

//line 109
___nl__9 = null;
//line 109
___nl__10 = new ImmString("tct_ref").clone();
//line 109
___nl__9 = ov_NL.NL_as(___nl__1,___nl__10).clone();

//line 109
___nl__10 = null;
//line 109
___nl__8 = c_rt_lib_NL.NL_native_to_nl(___nl__8.toString().Equals(___nl__9.toString())).clone();
//line 109
___nl__9 = null;
//line 109
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 109
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_5;}}
//line 109
___nl__9 = c_rt_lib_NL.NL_get_true().clone();
//line 109
___nl__3 = null;
//line 109
___nl__4 = null;
//line 109
___nl__7 = null;
//line 109
___nl__8 = null;
//line 109
___arg__0.setValue(___nl__0);___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__5.setValue(___nl__5);___arg__6.setValue(___nl__6);if(true) return ___nl__9;
//line 109
___nl__9 = null;
//line 109
if (true) {goto label_5;}
//line 109
label_5:
//line 109
___nl__8 = null;
//line 110
___nl__8 = ___nl__3.clone();
//line 110
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 110
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_8;}}
//line 110
___nl__11 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("speculation")).clone();
//line 110
___ref______nl__5 = new ImmRef(___nl__5);
___ref______nl__6 = new ImmRef(___nl__6);
___nl__10 = ptd_system_NL.NL_check_assignment_info_priv(___nl__0,___nl__1,___nl__2,___nl__11,___ref______nl__5,___ref______nl__6).clone();
___nl__5 = ___ref______nl__5.getValue().clone();
___nl__6 = ___ref______nl__6.getValue().clone();

//line 110
___nl__11 = null;
//line 110
___nl__11 = new ImmString("ok").clone();
//line 110
___nl__8 = ov_NL.NL_is(___nl__10,___nl__11).clone();

//line 110
___nl__11 = null;
//line 110
___nl__10 = null;
//line 110
label_8:
//line 110
___nl__9 = null;
//line 110
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 110
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_7;}}
//line 110
___nl__9 = c_rt_lib_NL.NL_get_true().clone();
//line 110
___nl__3 = null;
//line 110
___nl__4 = null;
//line 110
___nl__7 = null;
//line 110
___nl__8 = null;
//line 110
___arg__0.setValue(___nl__0);___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__5.setValue(___nl__5);___arg__6.setValue(___nl__6);if(true) return ___nl__9;
//line 110
___nl__9 = null;
//line 110
if (true) {goto label_7;}
//line 110
label_7:
//line 110
___nl__8 = null;
//line 111
if (true) {goto label_2;}
//line 111
label_2:
//line 111
___nl__7 = null;
//line 113
___nl__7 = new ImmArray(new Imm[0]).clone();
//line 114
___nl__8 = new ImmArray(new Imm[0]).clone();
//line 115
label_10:
//line 115
___nl__10 = new ImmString("tct_ref").clone();
//line 115
___nl__9 = ov_NL.NL_is(___nl__1,___nl__10).clone();

//line 115
___nl__10 = null;
//line 115
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 115
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_9;}}
//line 116
___nl__11 = new ImmString("from").clone();
//line 116
___nl__11 = c_rt_lib_NL.NL_get_ref_hash(___nl__2,___nl__11).clone();

//line 116
___nl__12 = ((ImmHash)___nl__2).getHashValue()["level"].clone();
//line 116
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__11 = new ImmRef(___nl__11);
___ref______nl__8 = new ImmRef(___nl__8);
___ref______nl__5 = new ImmRef(___nl__5);
___ref______nl__6 = new ImmRef(___nl__6);
___nl__10 = ptd_system_NL.NL_add_ref_name_priv(___ref______nl__1,___ref______nl__11,___ref______nl__8,___nl__12,___ref______nl__5,___ref______nl__6).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__11 = ___ref______nl__11.getValue().clone();
___nl__8 = ___ref______nl__8.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();
___nl__6 = ___ref______nl__6.getValue().clone();

//line 116
___nl__12 = null;
//line 116
___nl__12 = new ImmString("from").clone();
//line 116
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__2,___nl__12,___nl__11);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 116
___nl__12 = null;
//line 116
___nl__11 = null;
//line 117
___nl__11 = ((ImmHash)___nl__2).getHashValue()["check"].clone();
//line 117
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 117
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_14;}}
//line 117
___nl__11 = array_NL.NL_len(___nl__8).clone();

//line 117
___nl__14 = new ImmDouble(1).clone();
//line 117
___nl__11 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__11.getValue().ToString())) ==((Double.Parse(___nl__14.getValue().ToString())))  ).clone();
//line 117
___nl__14 = null;
//line 117
label_14:
//line 117
___nl__13 = null;
//line 117
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 117
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_13;}}
//line 117
___nl__11 = ___nl__4.clone();
//line 117
label_13:
//line 117
___nl__12 = null;
//line 117
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 117
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_12;}}
//line 117
___ref______nl__5 = new ImmRef(___nl__5);
___ref______nl__6 = new ImmRef(___nl__6);
ptd_system_NL.NL_add_delete_priv(___nl__10,___ref______nl__5,___ref______nl__6);
___nl__5 = ___ref______nl__5.getValue().clone();
___nl__6 = ___ref______nl__6.getValue().clone();

//line 117
if (true) {goto label_12;}
//line 117
label_12:
//line 117
___nl__11 = null;
//line 117
___nl__10 = null;
//line 118
if (true) {goto label_10;}
//line 118
label_9:
//line 118
___nl__9 = null;
//line 119
___nl__9 = ((ImmHash)___nl__2).getHashValue()["cast"].clone();
//line 119
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 119
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_16;}}
//line 120
___nl__11 = new ImmString("tct_im").clone();
//line 120
___nl__10 = ov_NL.NL_is(___nl__1,___nl__11).clone();

//line 120
___nl__11 = null;
//line 120
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 120
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_18;}}
//line 121
___nl__11 = ((ImmHash)___nl__2).getHashValue()["check"].clone();
//line 121
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 121
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_20;}}
//line 121
___nl__12 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("create")).clone();
//line 121
___nl__13 = ((ImmHash)___nl__2).getHashValue()["to"].clone();
//line 121
___ref______nl__5 = new ImmRef(___nl__5);
___ref______nl__6 = new ImmRef(___nl__6);
ptd_system_NL.NL_walk_on_type_priv(___nl__0,___nl__12,___nl__13,___ref______nl__5,___ref______nl__6);
___nl__5 = ___ref______nl__5.getValue().clone();
___nl__6 = ___ref______nl__6.getValue().clone();

//line 121
___nl__13 = null;
//line 121
___nl__12 = null;
//line 121
if (true) {goto label_20;}
//line 121
label_20:
//line 121
___nl__11 = null;
//line 122
___nl__11 = c_rt_lib_NL.NL_get_true().clone();
//line 122
___nl__3 = null;
//line 122
___nl__4 = null;
//line 122
___nl__7 = null;
//line 122
___nl__8 = null;
//line 122
___nl__9 = null;
//line 122
___nl__10 = null;
//line 122
___arg__0.setValue(___nl__0);___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__5.setValue(___nl__5);___arg__6.setValue(___nl__6);if(true) return ___nl__11;
//line 122
___nl__11 = null;
//line 123
if (true) {goto label_18;}
//line 123
label_18:
//line 123
___nl__10 = null;
//line 124
if (true) {goto label_16;}
//line 124
label_16:
//line 124
___nl__9 = null;
//line 125
label_22:
//line 125
___nl__10 = new ImmString("tct_ref").clone();
//line 125
___nl__9 = ov_NL.NL_is(___nl__0,___nl__10).clone();

//line 125
___nl__10 = null;
//line 125
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 125
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_21;}}
//line 126
___nl__11 = new ImmString("to").clone();
//line 126
___nl__11 = c_rt_lib_NL.NL_get_ref_hash(___nl__2,___nl__11).clone();

//line 126
___nl__12 = ((ImmHash)___nl__2).getHashValue()["level"].clone();
//line 126
___ref______nl__0 = new ImmRef(___nl__0);
___ref______nl__11 = new ImmRef(___nl__11);
___ref______nl__7 = new ImmRef(___nl__7);
___ref______nl__5 = new ImmRef(___nl__5);
___ref______nl__6 = new ImmRef(___nl__6);
___nl__10 = ptd_system_NL.NL_add_ref_name_priv(___ref______nl__0,___ref______nl__11,___ref______nl__7,___nl__12,___ref______nl__5,___ref______nl__6).clone();
___nl__0 = ___ref______nl__0.getValue().clone();
___nl__11 = ___ref______nl__11.getValue().clone();
___nl__7 = ___ref______nl__7.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();
___nl__6 = ___ref______nl__6.getValue().clone();

//line 126
___nl__12 = null;
//line 126
___nl__12 = new ImmString("to").clone();
//line 126
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__2,___nl__12,___nl__11);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 126
___nl__12 = null;
//line 126
___nl__11 = null;
//line 127
___nl__11 = ((ImmHash)___nl__2).getHashValue()["check"].clone();
//line 127
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 127
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_25;}}
//line 127
___nl__11 = array_NL.NL_len(___nl__7).clone();

//line 127
___nl__13 = new ImmDouble(1).clone();
//line 127
___nl__11 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__11.getValue().ToString())) ==((Double.Parse(___nl__13.getValue().ToString())))  ).clone();
//line 127
___nl__13 = null;
//line 127
label_25:
//line 127
___nl__12 = null;
//line 127
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 127
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_24;}}
//line 127
___ref______nl__5 = new ImmRef(___nl__5);
___ref______nl__6 = new ImmRef(___nl__6);
ptd_system_NL.NL_add_create_priv(___nl__10,___ref______nl__5,___ref______nl__6);
___nl__5 = ___ref______nl__5.getValue().clone();
___nl__6 = ___ref______nl__6.getValue().clone();

//line 127
if (true) {goto label_24;}
//line 127
label_24:
//line 127
___nl__11 = null;
//line 127
___nl__10 = null;
//line 128
if (true) {goto label_22;}
//line 128
label_21:
//line 128
___nl__9 = null;
//line 130
___nl__9 = new ImmDouble(0).clone();
//line 131
___nl__10 = new ImmDouble(0).clone();
//line 131
label_27:
//line 131
___nl__11 = array_NL.NL_len(___nl__7).clone();

//line 131
___nl__13 = new ImmDouble(1).clone();
//line 131
___nl__11 = new ImmDouble((Double.Parse(___nl__11.getValue().ToString()))-(Double.Parse(___nl__13.getValue().ToString()))).clone();
//line 131
___nl__13 = null;
//line 131
___nl__11 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__10.getValue().ToString()))<(Double.Parse(___nl__11.getValue().ToString())) ).clone();
//line 131
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 131
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_29;}}
//line 131
___nl__11 = array_NL.NL_len(___nl__8).clone();

//line 131
___nl__13 = new ImmDouble(0).clone();
//line 131
___nl__11 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__11.getValue().ToString()))>(Double.Parse(___nl__13.getValue().ToString())) ).clone();
//line 131
___nl__13 = null;
//line 131
label_29:
//line 131
___nl__12 = null;
//line 131
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 131
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_26;}}
//line 132
label_31:
//line 132
___nl__12 = (___nl__8 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()].clone();
//line 132
___nl__13 = (___nl__7 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()].clone();
//line 132
___nl__12 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__12.getValue().ToString()))<(Double.Parse(___nl__13.getValue().ToString())) ).clone();
//line 132
___nl__13 = null;
//line 132
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 132
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_30;}}
//line 133
___nl__13 = new ImmDouble(1).clone();
//line 133
___nl__9 = new ImmDouble((Double.Parse(___nl__9.getValue().ToString()))+(Double.Parse(___nl__13.getValue().ToString()))).clone();
//line 133
___nl__13 = null;
//line 134
if (true) {goto label_31;}
//line 134
label_30:
//line 134
___nl__12 = null;
//line 136
___nl__12 = (___nl__8 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()].clone();
//line 136
___nl__13 = (___nl__7 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()].clone();
//line 136
___nl__12 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__12.getValue().ToString())) ==((Double.Parse(___nl__13.getValue().ToString())))  ).clone();
//line 136
___nl__13 = null;
//line 136
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 136
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_33;}}
//line 136
___nl__13 = c_rt_lib_NL.NL_get_true().clone();
//line 136
___nl__3 = null;
//line 136
___nl__4 = null;
//line 136
___nl__7 = null;
//line 136
___nl__8 = null;
//line 136
___nl__9 = null;
//line 136
___nl__10 = null;
//line 136
___nl__11 = null;
//line 136
___nl__12 = null;
//line 136
___arg__0.setValue(___nl__0);___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__5.setValue(___nl__5);___arg__6.setValue(___nl__6);if(true) return ___nl__13;
//line 136
___nl__13 = null;
//line 136
if (true) {goto label_33;}
//line 136
label_33:
//line 136
___nl__12 = null;
//line 136
___nl__12 = new ImmDouble(1).clone();
//line 136
___nl__10 = new ImmDouble((Double.Parse(___nl__10.getValue().ToString()))+(Double.Parse(___nl__12.getValue().ToString()))).clone();
//line 136
___nl__12 = null;
//line 137
if (true) {goto label_27;}
//line 137
label_26:
//line 137
___nl__10 = null;
//line 137
___nl__11 = null;
//line 138
___nl__10 = new ImmDouble(1).clone();
//line 138
___nl__11 = new ImmString("level").clone();
//line 138
___nl__11 = c_rt_lib_NL.NL_get_ref_hash(___nl__2,___nl__11).clone();

//line 138
___nl__11 = new ImmDouble((Double.Parse(___nl__11.getValue().ToString()))+(Double.Parse(___nl__10.getValue().ToString()))).clone();
//line 138
___nl__12 = new ImmString("level").clone();
//line 138
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__2,___nl__12,___nl__11);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 138
___nl__12 = null;
//line 138
___nl__10 = null;
//line 138
___nl__11 = null;
//line 139
___nl__10 = c_rt_lib_NL.NL_get_false().clone();
//line 139
___nl__3 = null;
//line 139
___nl__4 = null;
//line 139
___nl__7 = null;
//line 139
___nl__8 = null;
//line 139
___nl__9 = null;
//line 139
___arg__0.setValue(___nl__0);___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__5.setValue(___nl__5);___arg__6.setValue(___nl__6);if(true) return ___nl__10;
//line 139
___nl__10 = null;
//line 139
___nl__7 = null;
//line 139
___nl__8 = null;
//line 139
___nl__9 = null;
//line 139
___nl__3 = null;
//line 139
___nl__4 = null;
//line 139
___arg__0.setValue(___nl__0);___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__5.setValue(___nl__5);___arg__6.setValue(___nl__6);if(true) return null;
}

public static Imm NL_cross_type(Imm ___arg__0, Imm ___arg__1, ImmRef ___arg__2, ImmRef ___arg__3) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.getValue().clone();Imm ___nl__3 = ___arg__3.getValue().clone();
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
//line 144
___nl__5 = new ImmDouble(1).clone();
//line 144
__function_map = new Dictionary<String, Imm>();
___nl__6 = new ImmHash(__function_map).clone();
//line 144
__function_map = new Dictionary<String, Imm>();
___nl__7 = new ImmHash(__function_map).clone();
//line 144
___nl__8 = c_rt_lib_NL.NL_get_false().clone();
//line 144
___nl__9 = c_rt_lib_NL.NL_get_false().clone();
//line 144
__function_map = new Dictionary<String, Imm>();
__function_map.Add("level",___nl__5);
__function_map.Add("from",___nl__6);
__function_map.Add("to",___nl__7);
__function_map.Add("check",___nl__8);
__function_map.Add("cast",___nl__9);
___nl__4 = new ImmHash(__function_map).clone();
//line 144
___nl__5 = null;
//line 144
___nl__6 = null;
//line 144
___nl__7 = null;
//line 144
___nl__8 = null;
//line 144
___nl__9 = null;
//line 145
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__5 = ptd_system_NL.NL_cross_type_priv(___nl__0,___nl__1,___nl__4,___ref______nl__2,___ref______nl__3).clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 145
___nl__0 = null;
//line 145
___nl__1 = null;
//line 145
___nl__4 = null;
//line 145
___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__5;
//line 145
___nl__5 = null;
//line 145
___nl__4 = null;
//line 145
___nl__0 = null;
//line 145
___nl__1 = null;
//line 145
___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return null;
}

private static Imm NL_cross_type_priv(Imm ___arg__0, Imm ___arg__1, Imm ___arg__2, ImmRef ___arg__3, ImmRef ___arg__4) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();Imm ___nl__3 = ___arg__3.getValue().clone();Imm ___nl__4 = ___arg__4.getValue().clone();
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
//line 149
___nl__6 = new ImmString("tct_im").clone();
//line 149
___nl__5 = ov_NL.NL_is(___nl__1,___nl__6).clone();

//line 149
___nl__6 = null;
//line 149
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_3;}}
//line 149
___nl__6 = new ImmString("tct_im").clone();
//line 149
___nl__5 = ov_NL.NL_is(___nl__0,___nl__6).clone();

//line 149
___nl__6 = null;
//line 149
label_3:
//line 149
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 149
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_2;}}
//line 149
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("tct_im")).clone();
//line 149
___nl__0 = null;
//line 149
___nl__1 = null;
//line 149
___nl__2 = null;
//line 149
___nl__5 = null;
//line 149
___arg__3.setValue(___nl__3);___arg__4.setValue(___nl__4);if(true) return ___nl__6;
//line 149
___nl__6 = null;
//line 149
if (true) {goto label_2;}
//line 149
label_2:
//line 149
___nl__5 = null;
//line 150
___nl__6 = c_rt_lib_NL.NL_get_true().clone();
//line 150
___nl__7 = c_rt_lib_NL.NL_get_false().clone();
//line 150
___ref______nl__0 = new ImmRef(___nl__0);
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___ref______nl__4 = new ImmRef(___nl__4);
___nl__5 = ptd_system_NL.NL_is_cycle_ref_priv(___ref______nl__0,___ref______nl__1,___ref______nl__2,___nl__6,___nl__7,___ref______nl__3,___ref______nl__4).clone();
___nl__0 = ___ref______nl__0.getValue().clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();
___nl__4 = ___ref______nl__4.getValue().clone();

//line 150
___nl__7 = null;
//line 150
___nl__6 = null;
//line 150
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 150
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_5;}}
//line 151
___nl__1 = null;
//line 151
___nl__2 = null;
//line 151
___nl__5 = null;
//line 151
___arg__3.setValue(___nl__3);___arg__4.setValue(___nl__4);if(true) return ___nl__0;
//line 152
if (true) {goto label_5;}
//line 152
label_5:
//line 152
___nl__5 = null;
//line 153
___nl__5 = ((ImmHash)___nl__2).getHashValue()["level"].clone();
//line 153
___nl__6 = new ImmDouble(200).clone();
//line 153
___nl__5 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString())) ==((Double.Parse(___nl__6.getValue().ToString())))  ).clone();
//line 153
___nl__6 = null;
//line 153
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 153
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_7;}}
//line 154
___nl__6 = new ImmString("can't assignment two that diffrent type to one var").clone();
//line 154
___ref______nl__4 = new ImmRef(___nl__4);
ptd_system_NL.NL_add_error_priv(___ref______nl__4,___nl__6);
___nl__4 = ___ref______nl__4.getValue().clone();

//line 154
___nl__6 = null;
//line 155
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("tct_im")).clone();
//line 155
___nl__0 = null;
//line 155
___nl__1 = null;
//line 155
___nl__2 = null;
//line 155
___nl__5 = null;
//line 155
___arg__3.setValue(___nl__3);___arg__4.setValue(___nl__4);if(true) return ___nl__6;
//line 155
___nl__6 = null;
//line 156
if (true) {goto label_7;}
//line 156
label_7:
//line 156
___nl__5 = null;
//line 157
___nl__6 = new ImmString("tct_empty").clone();
//line 157
___nl__5 = ov_NL.NL_is(___nl__1,___nl__6).clone();

//line 157
___nl__6 = null;
//line 157
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 157
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_9;}}
//line 157
___nl__1 = null;
//line 157
___nl__2 = null;
//line 157
___nl__5 = null;
//line 157
___arg__3.setValue(___nl__3);___arg__4.setValue(___nl__4);if(true) return ___nl__0;
//line 157
if (true) {goto label_9;}
//line 157
label_9:
//line 157
___nl__5 = null;
//line 158
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_empty")).clone();
//line 158
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_11;}}
//line 160
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_im")).clone();
//line 160
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_12;}}
//line 162
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_sim")).clone();
//line 162
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_13;}}
//line 164
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_ref")).clone();
//line 164
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_14;}}
//line 166
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_void")).clone();
//line 166
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_15;}}
//line 168
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_arr")).clone();
//line 168
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_16;}}
//line 173
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_var")).clone();
//line 173
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_17;}}
//line 213
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_rec")).clone();
//line 213
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_18;}}
//line 239
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_hash")).clone();
//line 239
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_19;}}
//line 239
___nl__5 = new ImmString("NOMATCHALERT").clone();
//line 239
___nl__5 = new ImmArray(new Imm[] {___nl__5,___nl__0,}).clone();
//line 239
c_rt_lib_NL.NL_die();
//line 158
label_11:
//line 159
___nl__0 = null;
//line 159
___nl__2 = null;
//line 159
___nl__5 = null;
//line 159
___arg__3.setValue(___nl__3);___arg__4.setValue(___nl__4);if(true) return ___nl__1;
//line 160
if (true) {goto label_10;}
//line 160
label_12:
//line 161
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("tct_im")).clone();
//line 161
___nl__0 = null;
//line 161
___nl__1 = null;
//line 161
___nl__2 = null;
//line 161
___nl__5 = null;
//line 161
___arg__3.setValue(___nl__3);___arg__4.setValue(___nl__4);if(true) return ___nl__6;
//line 161
___nl__6 = null;
//line 162
if (true) {goto label_10;}
//line 162
label_13:
//line 163
___nl__7 = new ImmString("tct_sim").clone();
//line 163
___nl__6 = ov_NL.NL_is(___nl__1,___nl__7).clone();

//line 163
___nl__7 = null;
//line 163
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 163
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_21;}}
//line 163
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("tct_sim")).clone();
//line 163
___nl__0 = null;
//line 163
___nl__1 = null;
//line 163
___nl__2 = null;
//line 163
___nl__5 = null;
//line 163
___nl__6 = null;
//line 163
___arg__3.setValue(___nl__3);___arg__4.setValue(___nl__4);if(true) return ___nl__7;
//line 163
___nl__7 = null;
//line 163
if (true) {goto label_21;}
//line 163
label_21:
//line 163
___nl__6 = null;
//line 164
if (true) {goto label_10;}
//line 164
label_14:
//line 164
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("tct_ref")).clone();
//line 165
___nl__7 = new ImmArray(new Imm[0]).clone();
//line 165
c_rt_lib_NL.NL_die();
//line 165
___nl__7 = null;
//line 165
___nl__6 = null;
//line 166
if (true) {goto label_10;}
//line 166
label_15:
//line 167
___nl__6 = new ImmArray(new Imm[0]).clone();
//line 167
c_rt_lib_NL.NL_die();
//line 167
___nl__6 = null;
//line 168
if (true) {goto label_10;}
//line 168
label_16:
//line 168
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("tct_arr")).clone();
//line 169
___nl__8 = new ImmString("tct_arr").clone();
//line 169
___nl__7 = ov_NL.NL_is(___nl__1,___nl__8).clone();

//line 169
___nl__8 = null;
//line 169
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 169
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_23;}}
//line 170
___nl__10 = ___nl__1.clone();
//line 170
___nl__10 = c_rt_lib_NL.NL_ov_as(___nl__10, new ImmString("tct_arr")).clone();
//line 170
___ref______nl__3 = new ImmRef(___nl__3);
___ref______nl__4 = new ImmRef(___nl__4);
___nl__9 = ptd_system_NL.NL_cross_type_priv(___nl__6,___nl__10,___nl__2,___ref______nl__3,___ref______nl__4).clone();
___nl__3 = ___ref______nl__3.getValue().clone();
___nl__4 = ___ref______nl__4.getValue().clone();

//line 170
___nl__10 = null;
//line 170
___nl__8 = tct_NL.NL_tct_arr(___nl__9).clone();

//line 170
___nl__9 = null;
//line 170
___nl__0 = null;
//line 170
___nl__1 = null;
//line 170
___nl__2 = null;
//line 170
___nl__5 = null;
//line 170
___nl__6 = null;
//line 170
___nl__7 = null;
//line 170
___arg__3.setValue(___nl__3);___arg__4.setValue(___nl__4);if(true) return ___nl__8;
//line 170
___nl__8 = null;
//line 171
if (true) {goto label_23;}
//line 171
label_23:
//line 171
___nl__7 = null;
//line 171
___nl__6 = null;
//line 173
if (true) {goto label_10;}
//line 173
label_17:
//line 173
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("tct_var")).clone();
//line 174
___nl__7 = ___nl__6.clone();
//line 175
___nl__9 = new ImmString("tct_var").clone();
//line 175
___nl__8 = ov_NL.NL_is(___nl__1,___nl__9).clone();

//line 175
___nl__9 = null;
//line 175
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 175
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_25;}}
//line 176
___nl__9 = ___nl__1.clone();
//line 176
___nl__9 = c_rt_lib_NL.NL_ov_as(___nl__9, new ImmString("tct_var")).clone();
//line 177
___nl__12 = c_rt_lib_NL.NL_init_iter(___nl__6).clone();

//line 177
label_28:
//line 177
___nl__10 = c_rt_lib_NL.NL_is_end_hash(___nl__12).clone();

//line 177
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_26;}}
//line 177
___nl__10 = c_rt_lib_NL.NL_get_key_iter(___nl__12).clone();

//line 177
___nl__11 = c_rt_lib_NL.NL_hash_get_value(___nl__6,___nl__10).clone();

//line 178
___nl__13 = hash_NL.NL_has_key(___nl__9,___nl__10).clone();

//line 178
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13)).clone();
//line 178
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_30;}}
//line 179
___nl__14 = hash_NL.NL_get_value(___nl__9,___nl__10).clone();

//line 180
___nl__15 = c_rt_lib_NL.NL_ov_is(___nl__14, new ImmString("with_param")).clone();
//line 180
if (c_rt_lib_NL.NL_check_true_native(___nl__15)) {if (true) {goto label_32;}}
//line 186
___nl__15 = c_rt_lib_NL.NL_ov_is(___nl__14, new ImmString("no_param")).clone();
//line 186
if (c_rt_lib_NL.NL_check_true_native(___nl__15)) {if (true) {goto label_33;}}
//line 186
___nl__15 = new ImmString("NOMATCHALERT").clone();
//line 186
___nl__15 = new ImmArray(new Imm[] {___nl__15,___nl__14,}).clone();
//line 186
c_rt_lib_NL.NL_die();
//line 180
label_32:
//line 180
___nl__16 = c_rt_lib_NL.NL_ov_as(___nl__14, new ImmString("with_param")).clone();
//line 181
___nl__17 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("with_param")).clone();
//line 181
if (c_rt_lib_NL.NL_check_true_native(___nl__17)) {if (true) {goto label_35;}}
//line 183
___nl__17 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("no_param")).clone();
//line 183
if (c_rt_lib_NL.NL_check_true_native(___nl__17)) {if (true) {goto label_36;}}
//line 183
___nl__17 = new ImmString("NOMATCHALERT").clone();
//line 183
___nl__17 = new ImmArray(new Imm[] {___nl__17,___nl__11,}).clone();
//line 183
c_rt_lib_NL.NL_die();
//line 181
label_35:
//line 181
___nl__18 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("with_param")).clone();
//line 182
___ref______nl__3 = new ImmRef(___nl__3);
___ref______nl__4 = new ImmRef(___nl__4);
___nl__19 = ptd_system_NL.NL_cross_type_priv(___nl__16,___nl__18,___nl__2,___ref______nl__3,___ref______nl__4).clone();
___nl__3 = ___ref______nl__3.getValue().clone();
___nl__4 = ___ref______nl__4.getValue().clone();

//line 182
___ref______nl__7 = new ImmRef(___nl__7);
hash_NL.NL_set_value(___ref______nl__7,___nl__10,___nl__19);
___nl__7 = ___ref______nl__7.getValue().clone();

//line 182
___nl__19 = null;
//line 182
___nl__18 = null;
//line 183
if (true) {goto label_34;}
//line 183
label_36:
//line 184
___nl__18 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("tct_im")).clone();
//line 184
___nl__0 = null;
//line 184
___nl__1 = null;
//line 184
___nl__2 = null;
//line 184
___nl__5 = null;
//line 184
___nl__6 = null;
//line 184
___nl__7 = null;
//line 184
___nl__8 = null;
//line 184
___nl__9 = null;
//line 184
___nl__10 = null;
//line 184
___nl__11 = null;
//line 184
___nl__12 = null;
//line 184
___nl__13 = null;
//line 184
___nl__14 = null;
//line 184
___nl__15 = null;
//line 184
___nl__16 = null;
//line 184
___nl__17 = null;
//line 184
___arg__3.setValue(___nl__3);___arg__4.setValue(___nl__4);if(true) return ___nl__18;
//line 184
___nl__18 = null;
//line 185
if (true) {goto label_34;}
//line 185
label_34:
//line 185
___nl__17 = null;
//line 185
___nl__16 = null;
//line 186
if (true) {goto label_31;}
//line 186
label_33:
//line 187
___nl__16 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("with_param")).clone();
//line 187
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_38;}}
//line 189
___nl__16 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("no_param")).clone();
//line 189
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_39;}}
//line 189
___nl__16 = new ImmString("NOMATCHALERT").clone();
//line 189
___nl__16 = new ImmArray(new Imm[] {___nl__16,___nl__11,}).clone();
//line 189
c_rt_lib_NL.NL_die();
//line 187
label_38:
//line 187
___nl__17 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("with_param")).clone();
//line 188
___nl__18 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("tct_im")).clone();
//line 188
___nl__0 = null;
//line 188
___nl__1 = null;
//line 188
___nl__2 = null;
//line 188
___nl__5 = null;
//line 188
___nl__6 = null;
//line 188
___nl__7 = null;
//line 188
___nl__8 = null;
//line 188
___nl__9 = null;
//line 188
___nl__10 = null;
//line 188
___nl__11 = null;
//line 188
___nl__12 = null;
//line 188
___nl__13 = null;
//line 188
___nl__14 = null;
//line 188
___nl__15 = null;
//line 188
___nl__16 = null;
//line 188
___nl__17 = null;
//line 188
___arg__3.setValue(___nl__3);___arg__4.setValue(___nl__4);if(true) return ___nl__18;
//line 188
___nl__18 = null;
//line 188
___nl__17 = null;
//line 189
if (true) {goto label_37;}
//line 189
label_39:
//line 190
___nl__17 = tct_NL.NL_tct_none().clone();

//line 190
___ref______nl__7 = new ImmRef(___nl__7);
hash_NL.NL_set_value(___ref______nl__7,___nl__10,___nl__17);
___nl__7 = ___ref______nl__7.getValue().clone();

//line 190
___nl__17 = null;
//line 191
if (true) {goto label_37;}
//line 191
label_37:
//line 191
___nl__16 = null;
//line 192
if (true) {goto label_31;}
//line 192
label_31:
//line 192
___nl__15 = null;
//line 192
___nl__14 = null;
//line 193
if (true) {goto label_29;}
//line 193
label_30:
//line 194
___nl__14 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("with_param")).clone();
//line 194
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_41;}}
//line 196
___nl__14 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("no_param")).clone();
//line 196
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_42;}}
//line 196
___nl__14 = new ImmString("NOMATCHALERT").clone();
//line 196
___nl__14 = new ImmArray(new Imm[] {___nl__14,___nl__11,}).clone();
//line 196
c_rt_lib_NL.NL_die();
//line 194
label_41:
//line 194
___nl__15 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("with_param")).clone();
//line 195
___ref______nl__7 = new ImmRef(___nl__7);
hash_NL.NL_set_value(___ref______nl__7,___nl__10,___nl__15);
___nl__7 = ___ref______nl__7.getValue().clone();

//line 195
___nl__15 = null;
//line 196
if (true) {goto label_40;}
//line 196
label_42:
//line 197
___nl__15 = tct_NL.NL_tct_none().clone();

//line 197
___ref______nl__7 = new ImmRef(___nl__7);
hash_NL.NL_set_value(___ref______nl__7,___nl__10,___nl__15);
___nl__7 = ___ref______nl__7.getValue().clone();

//line 197
___nl__15 = null;
//line 198
if (true) {goto label_40;}
//line 198
label_40:
//line 198
___nl__14 = null;
//line 199
if (true) {goto label_29;}
//line 199
label_29:
//line 199
___nl__13 = null;
//line 201
___nl__12 = c_rt_lib_NL.NL_next_iter(___nl__12).clone();

//line 201
if (true) {goto label_28;}
//line 201
label_26:
//line 201
___nl__10 = null;
//line 201
___nl__11 = null;
//line 201
___nl__12 = null;
//line 202
___nl__12 = c_rt_lib_NL.NL_init_iter(___nl__9).clone();

//line 202
label_45:
//line 202
___nl__10 = c_rt_lib_NL.NL_is_end_hash(___nl__12).clone();

//line 202
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_43;}}
//line 202
___nl__10 = c_rt_lib_NL.NL_get_key_iter(___nl__12).clone();

//line 202
___nl__11 = c_rt_lib_NL.NL_hash_get_value(___nl__9,___nl__10).clone();

//line 203
___nl__13 = hash_NL.NL_has_key(___nl__7,___nl__10).clone();

//line 203
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13)).clone();
//line 203
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_47;}}
//line 203
___nl__13 = null;
//line 203
if (true) {goto label_44;}
//line 203
if (true) {goto label_47;}
//line 203
label_47:
//line 203
___nl__13 = null;
//line 204
___nl__13 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("with_param")).clone();
//line 204
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_49;}}
//line 206
___nl__13 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("no_param")).clone();
//line 206
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_50;}}
//line 206
___nl__13 = new ImmString("NOMATCHALERT").clone();
//line 206
___nl__13 = new ImmArray(new Imm[] {___nl__13,___nl__11,}).clone();
//line 206
c_rt_lib_NL.NL_die();
//line 204
label_49:
//line 204
___nl__14 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("with_param")).clone();
//line 205
___ref______nl__7 = new ImmRef(___nl__7);
hash_NL.NL_set_value(___ref______nl__7,___nl__10,___nl__14);
___nl__7 = ___ref______nl__7.getValue().clone();

//line 205
___nl__14 = null;
//line 206
if (true) {goto label_48;}
//line 206
label_50:
//line 207
___nl__14 = tct_NL.NL_tct_none().clone();

//line 207
___ref______nl__7 = new ImmRef(___nl__7);
hash_NL.NL_set_value(___ref______nl__7,___nl__10,___nl__14);
___nl__7 = ___ref______nl__7.getValue().clone();

//line 207
___nl__14 = null;
//line 208
if (true) {goto label_48;}
//line 208
label_48:
//line 208
___nl__13 = null;
//line 208
label_44:
//line 209
___nl__12 = c_rt_lib_NL.NL_next_iter(___nl__12).clone();

//line 209
if (true) {goto label_45;}
//line 209
label_43:
//line 209
___nl__10 = null;
//line 209
___nl__11 = null;
//line 209
___nl__12 = null;
//line 210
___nl__10 = tct_NL.NL_tct_var(___nl__7).clone();

//line 210
___nl__0 = null;
//line 210
___nl__1 = null;
//line 210
___nl__2 = null;
//line 210
___nl__5 = null;
//line 210
___nl__6 = null;
//line 210
___nl__7 = null;
//line 210
___nl__8 = null;
//line 210
___nl__9 = null;
//line 210
___arg__3.setValue(___nl__3);___arg__4.setValue(___nl__4);if(true) return ___nl__10;
//line 210
___nl__10 = null;
//line 210
___nl__9 = null;
//line 211
if (true) {goto label_25;}
//line 211
label_25:
//line 211
___nl__8 = null;
//line 211
___nl__7 = null;
//line 211
___nl__6 = null;
//line 213
if (true) {goto label_10;}
//line 213
label_18:
//line 213
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("tct_rec")).clone();
//line 214
___nl__8 = new ImmString("tct_rec").clone();
//line 214
___nl__7 = ov_NL.NL_is(___nl__1,___nl__8).clone();

//line 214
___nl__8 = null;
//line 214
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 214
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_52;}}
//line 215
___nl__8 = ___nl__1.clone();
//line 215
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__8, new ImmString("tct_rec")).clone();
//line 216
___nl__9 = c_rt_lib_NL.NL_get_false().clone();
//line 217
___nl__12 = c_rt_lib_NL.NL_init_iter(___nl__6).clone();

//line 217
label_55:
//line 217
___nl__10 = c_rt_lib_NL.NL_is_end_hash(___nl__12).clone();

//line 217
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_53;}}
//line 217
___nl__10 = c_rt_lib_NL.NL_get_key_iter(___nl__12).clone();

//line 217
___nl__11 = c_rt_lib_NL.NL_hash_get_value(___nl__6,___nl__10).clone();

//line 218
___nl__13 = hash_NL.NL_has_key(___nl__8,___nl__10).clone();

//line 218
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13)).clone();
//line 218
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13)).clone();
//line 218
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_57;}}
//line 218
___nl__14 = c_rt_lib_NL.NL_get_true().clone();
//line 218
___nl__9 = ___nl__14.clone();
//line 218
___nl__14 = null;
//line 218
if (true) {goto label_57;}
//line 218
label_57:
//line 218
___nl__13 = null;
//line 219
___nl__12 = c_rt_lib_NL.NL_next_iter(___nl__12).clone();

//line 219
if (true) {goto label_55;}
//line 219
label_53:
//line 219
___nl__10 = null;
//line 219
___nl__11 = null;
//line 219
___nl__12 = null;
//line 220
___nl__12 = c_rt_lib_NL.NL_init_iter(___nl__8).clone();

//line 220
label_60:
//line 220
___nl__10 = c_rt_lib_NL.NL_is_end_hash(___nl__12).clone();

//line 220
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_58;}}
//line 220
___nl__10 = c_rt_lib_NL.NL_get_key_iter(___nl__12).clone();

//line 220
___nl__11 = c_rt_lib_NL.NL_hash_get_value(___nl__8,___nl__10).clone();

//line 221
___nl__13 = hash_NL.NL_has_key(___nl__6,___nl__10).clone();

//line 221
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13)).clone();
//line 221
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13)).clone();
//line 221
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_62;}}
//line 221
___nl__14 = c_rt_lib_NL.NL_get_true().clone();
//line 221
___nl__9 = ___nl__14.clone();
//line 221
___nl__14 = null;
//line 221
if (true) {goto label_62;}
//line 221
label_62:
//line 221
___nl__13 = null;
//line 222
___nl__12 = c_rt_lib_NL.NL_next_iter(___nl__12).clone();

//line 222
if (true) {goto label_60;}
//line 222
label_58:
//line 222
___nl__10 = null;
//line 222
___nl__11 = null;
//line 222
___nl__12 = null;
//line 223
___nl__10 = ___nl__9.clone();
//line 223
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 223
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_64;}}
//line 224
___ref______nl__3 = new ImmRef(___nl__3);
___ref______nl__4 = new ImmRef(___nl__4);
___nl__11 = ptd_system_NL.NL_rec_to_hash(___nl__0,___nl__2,___ref______nl__3,___ref______nl__4).clone();
___nl__3 = ___ref______nl__3.getValue().clone();
___nl__4 = ___ref______nl__4.getValue().clone();

//line 225
___ref______nl__3 = new ImmRef(___nl__3);
___ref______nl__4 = new ImmRef(___nl__4);
___nl__12 = ptd_system_NL.NL_rec_to_hash(___nl__1,___nl__2,___ref______nl__3,___ref______nl__4).clone();
___nl__3 = ___ref______nl__3.getValue().clone();
___nl__4 = ___ref______nl__4.getValue().clone();

//line 226
___ref______nl__3 = new ImmRef(___nl__3);
___ref______nl__4 = new ImmRef(___nl__4);
___nl__14 = ptd_system_NL.NL_cross_type_priv(___nl__11,___nl__12,___nl__2,___ref______nl__3,___ref______nl__4).clone();
___nl__3 = ___ref______nl__3.getValue().clone();
___nl__4 = ___ref______nl__4.getValue().clone();

//line 226
___nl__13 = tct_NL.NL_tct_hash(___nl__14).clone();

//line 226
___nl__14 = null;
//line 226
___nl__0 = null;
//line 226
___nl__1 = null;
//line 226
___nl__2 = null;
//line 226
___nl__5 = null;
//line 226
___nl__6 = null;
//line 226
___nl__7 = null;
//line 226
___nl__8 = null;
//line 226
___nl__9 = null;
//line 226
___nl__10 = null;
//line 226
___nl__11 = null;
//line 226
___nl__12 = null;
//line 226
___arg__3.setValue(___nl__3);___arg__4.setValue(___nl__4);if(true) return ___nl__13;
//line 226
___nl__13 = null;
//line 226
___nl__11 = null;
//line 226
___nl__12 = null;
//line 227
if (true) {goto label_63;}
//line 227
label_64:
//line 228
__function_map = new Dictionary<String, Imm>();
___nl__11 = new ImmHash(__function_map).clone();
//line 229
___nl__14 = c_rt_lib_NL.NL_init_iter(___nl__6).clone();

//line 229
label_67:
//line 229
___nl__12 = c_rt_lib_NL.NL_is_end_hash(___nl__14).clone();

//line 229
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_65;}}
//line 229
___nl__12 = c_rt_lib_NL.NL_get_key_iter(___nl__14).clone();

//line 229
___nl__13 = c_rt_lib_NL.NL_hash_get_value(___nl__6,___nl__12).clone();

//line 230
___nl__16 = hash_NL.NL_get_value(___nl__8,___nl__12).clone();

//line 230
___ref______nl__3 = new ImmRef(___nl__3);
___ref______nl__4 = new ImmRef(___nl__4);
___nl__15 = ptd_system_NL.NL_cross_type_priv(___nl__13,___nl__16,___nl__2,___ref______nl__3,___ref______nl__4).clone();
___nl__3 = ___ref______nl__3.getValue().clone();
___nl__4 = ___ref______nl__4.getValue().clone();

//line 230
___nl__16 = null;
//line 230
___ref______nl__11 = new ImmRef(___nl__11);
hash_NL.NL_set_value(___ref______nl__11,___nl__12,___nl__15);
___nl__11 = ___ref______nl__11.getValue().clone();

//line 230
___nl__15 = null;
//line 231
___nl__14 = c_rt_lib_NL.NL_next_iter(___nl__14).clone();

//line 231
if (true) {goto label_67;}
//line 231
label_65:
//line 231
___nl__12 = null;
//line 231
___nl__13 = null;
//line 231
___nl__14 = null;
//line 232
___nl__12 = tct_NL.NL_tct_rec(___nl__11).clone();

//line 232
___nl__0 = null;
//line 232
___nl__1 = null;
//line 232
___nl__2 = null;
//line 232
___nl__5 = null;
//line 232
___nl__6 = null;
//line 232
___nl__7 = null;
//line 232
___nl__8 = null;
//line 232
___nl__9 = null;
//line 232
___nl__10 = null;
//line 232
___nl__11 = null;
//line 232
___arg__3.setValue(___nl__3);___arg__4.setValue(___nl__4);if(true) return ___nl__12;
//line 232
___nl__12 = null;
//line 232
___nl__11 = null;
//line 233
if (true) {goto label_63;}
//line 233
label_63:
//line 233
___nl__10 = null;
//line 233
___nl__8 = null;
//line 233
___nl__9 = null;
//line 234
if (true) {goto label_52;}
//line 234
label_52:
//line 234
___nl__7 = null;
//line 235
___nl__8 = new ImmString("tct_hash").clone();
//line 235
___nl__7 = ov_NL.NL_is(___nl__1,___nl__8).clone();

//line 235
___nl__8 = null;
//line 235
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 235
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_69;}}
//line 236
___ref______nl__3 = new ImmRef(___nl__3);
___ref______nl__4 = new ImmRef(___nl__4);
___nl__8 = ptd_system_NL.NL_rec_to_hash(___nl__0,___nl__2,___ref______nl__3,___ref______nl__4).clone();
___nl__3 = ___ref______nl__3.getValue().clone();
___nl__4 = ___ref______nl__4.getValue().clone();

//line 237
___nl__11 = ___nl__1.clone();
//line 237
___nl__11 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("tct_hash")).clone();
//line 237
___ref______nl__3 = new ImmRef(___nl__3);
___ref______nl__4 = new ImmRef(___nl__4);
___nl__10 = ptd_system_NL.NL_cross_type(___nl__11,___nl__8,___ref______nl__3,___ref______nl__4).clone();
___nl__3 = ___ref______nl__3.getValue().clone();
___nl__4 = ___ref______nl__4.getValue().clone();

//line 237
___nl__11 = null;
//line 237
___nl__9 = tct_NL.NL_tct_hash(___nl__10).clone();

//line 237
___nl__10 = null;
//line 237
___nl__0 = null;
//line 237
___nl__1 = null;
//line 237
___nl__2 = null;
//line 237
___nl__5 = null;
//line 237
___nl__6 = null;
//line 237
___nl__7 = null;
//line 237
___nl__8 = null;
//line 237
___arg__3.setValue(___nl__3);___arg__4.setValue(___nl__4);if(true) return ___nl__9;
//line 237
___nl__9 = null;
//line 237
___nl__8 = null;
//line 238
if (true) {goto label_69;}
//line 238
label_69:
//line 238
___nl__7 = null;
//line 238
___nl__6 = null;
//line 239
if (true) {goto label_10;}
//line 239
label_19:
//line 239
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("tct_hash")).clone();
//line 240
___nl__8 = new ImmString("tct_hash").clone();
//line 240
___nl__7 = ov_NL.NL_is(___nl__1,___nl__8).clone();

//line 240
___nl__8 = null;
//line 240
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 240
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_71;}}
//line 241
___nl__10 = ___nl__1.clone();
//line 241
___nl__10 = c_rt_lib_NL.NL_ov_as(___nl__10, new ImmString("tct_hash")).clone();
//line 241
___ref______nl__3 = new ImmRef(___nl__3);
___ref______nl__4 = new ImmRef(___nl__4);
___nl__9 = ptd_system_NL.NL_cross_type_priv(___nl__6,___nl__10,___nl__2,___ref______nl__3,___ref______nl__4).clone();
___nl__3 = ___ref______nl__3.getValue().clone();
___nl__4 = ___ref______nl__4.getValue().clone();

//line 241
___nl__10 = null;
//line 241
___nl__8 = tct_NL.NL_tct_hash(___nl__9).clone();

//line 241
___nl__9 = null;
//line 241
___nl__0 = null;
//line 241
___nl__1 = null;
//line 241
___nl__2 = null;
//line 241
___nl__5 = null;
//line 241
___nl__6 = null;
//line 241
___nl__7 = null;
//line 241
___arg__3.setValue(___nl__3);___arg__4.setValue(___nl__4);if(true) return ___nl__8;
//line 241
___nl__8 = null;
//line 242
if (true) {goto label_71;}
//line 242
label_71:
//line 242
___nl__7 = null;
//line 243
___nl__8 = new ImmString("tct_rec").clone();
//line 243
___nl__7 = ov_NL.NL_is(___nl__1,___nl__8).clone();

//line 243
___nl__8 = null;
//line 243
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 243
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_73;}}
//line 244
___ref______nl__3 = new ImmRef(___nl__3);
___ref______nl__4 = new ImmRef(___nl__4);
___nl__8 = ptd_system_NL.NL_rec_to_hash(___nl__1,___nl__2,___ref______nl__3,___ref______nl__4).clone();
___nl__3 = ___ref______nl__3.getValue().clone();
___nl__4 = ___ref______nl__4.getValue().clone();

//line 245
___ref______nl__3 = new ImmRef(___nl__3);
___ref______nl__4 = new ImmRef(___nl__4);
___nl__10 = ptd_system_NL.NL_cross_type(___nl__6,___nl__8,___ref______nl__3,___ref______nl__4).clone();
___nl__3 = ___ref______nl__3.getValue().clone();
___nl__4 = ___ref______nl__4.getValue().clone();

//line 245
___nl__9 = tct_NL.NL_tct_hash(___nl__10).clone();

//line 245
___nl__10 = null;
//line 245
___nl__0 = null;
//line 245
___nl__1 = null;
//line 245
___nl__2 = null;
//line 245
___nl__5 = null;
//line 245
___nl__6 = null;
//line 245
___nl__7 = null;
//line 245
___nl__8 = null;
//line 245
___arg__3.setValue(___nl__3);___arg__4.setValue(___nl__4);if(true) return ___nl__9;
//line 245
___nl__9 = null;
//line 245
___nl__8 = null;
//line 246
if (true) {goto label_73;}
//line 246
label_73:
//line 246
___nl__7 = null;
//line 246
___nl__6 = null;
//line 247
if (true) {goto label_10;}
//line 247
label_10:
//line 247
___nl__5 = null;
//line 248
___nl__5 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("tct_im")).clone();
//line 248
___nl__0 = null;
//line 248
___nl__1 = null;
//line 248
___nl__2 = null;
//line 248
___arg__3.setValue(___nl__3);___arg__4.setValue(___nl__4);if(true) return ___nl__5;
//line 248
___nl__5 = null;
//line 248
___nl__0 = null;
//line 248
___nl__1 = null;
//line 248
___nl__2 = null;
//line 248
___arg__3.setValue(___nl__3);___arg__4.setValue(___nl__4);if(true) return null;
}

public static Imm NL_rec_to_hash(Imm ___arg__0, Imm ___arg__1, ImmRef ___arg__2, ImmRef ___arg__3) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.getValue().clone();Imm ___nl__3 = ___arg__3.getValue().clone();
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
//line 251
___nl__4 = tct_NL.NL_tct_empty().clone();

//line 252
___nl__5 = ___nl__0.clone();
//line 252
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("tct_rec")).clone();
//line 252
___nl__8 = c_rt_lib_NL.NL_init_iter(___nl__5).clone();

//line 252
label_3:
//line 252
___nl__6 = c_rt_lib_NL.NL_is_end_hash(___nl__8).clone();

//line 252
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_1;}}
//line 252
___nl__6 = c_rt_lib_NL.NL_get_key_iter(___nl__8).clone();

//line 252
___nl__7 = c_rt_lib_NL.NL_hash_get_value(___nl__5,___nl__6).clone();

//line 253
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__9 = ptd_system_NL.NL_cross_type_priv(___nl__7,___nl__4,___nl__1,___ref______nl__2,___ref______nl__3).clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 253
___nl__4 = ___nl__9.clone();
//line 253
___nl__9 = null;
//line 254
___nl__8 = c_rt_lib_NL.NL_next_iter(___nl__8).clone();

//line 254
if (true) {goto label_3;}
//line 254
label_1:
//line 254
___nl__5 = null;
//line 254
___nl__6 = null;
//line 254
___nl__7 = null;
//line 254
___nl__8 = null;
//line 255
___nl__0 = null;
//line 255
___nl__1 = null;
//line 255
___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__4;
//line 255
___nl__4 = null;
//line 255
___nl__0 = null;
//line 255
___nl__1 = null;
//line 255
___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return null;
}

public static Imm NL_cast_type(Imm ___arg__0, Imm ___arg__1, ImmRef ___arg__2, ImmRef ___arg__3) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.getValue().clone();Imm ___nl__3 = ___arg__3.getValue().clone();
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
//line 259
___nl__5 = new ImmDouble(1).clone();
//line 259
__function_map = new Dictionary<String, Imm>();
___nl__6 = new ImmHash(__function_map).clone();
//line 259
__function_map = new Dictionary<String, Imm>();
___nl__7 = new ImmHash(__function_map).clone();
//line 259
___nl__8 = c_rt_lib_NL.NL_get_true().clone();
//line 259
___nl__9 = c_rt_lib_NL.NL_get_true().clone();
//line 259
__function_map = new Dictionary<String, Imm>();
__function_map.Add("level",___nl__5);
__function_map.Add("from",___nl__6);
__function_map.Add("to",___nl__7);
__function_map.Add("check",___nl__8);
__function_map.Add("cast",___nl__9);
___nl__4 = new ImmHash(__function_map).clone();
//line 259
___nl__5 = null;
//line 259
___nl__6 = null;
//line 259
___nl__7 = null;
//line 259
___nl__8 = null;
//line 259
___nl__9 = null;
//line 260
___nl__6 = ((ImmHash)___nl__1).getHashValue()["type"].clone();
//line 260
___nl__7 = ((ImmHash)___nl__1).getHashValue()["src"].clone();
//line 260
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__5 = ptd_system_NL.NL_check_assignment_info_priv(___nl__0,___nl__6,___nl__4,___nl__7,___ref______nl__2,___ref______nl__3).clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 260
___nl__7 = null;
//line 260
___nl__6 = null;
//line 260
___nl__0 = null;
//line 260
___nl__1 = null;
//line 260
___nl__4 = null;
//line 260
___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__5;
//line 260
___nl__5 = null;
//line 260
___nl__4 = null;
//line 260
___nl__0 = null;
//line 260
___nl__1 = null;
//line 260
___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return null;
}

public static Imm NL_check_assignment(Imm ___arg__0, Imm ___arg__1, ImmRef ___arg__2, ImmRef ___arg__3) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.getValue().clone();Imm ___nl__3 = ___arg__3.getValue().clone();
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
//line 265
___nl__5 = new ImmDouble(1).clone();
//line 265
__function_map = new Dictionary<String, Imm>();
___nl__6 = new ImmHash(__function_map).clone();
//line 265
__function_map = new Dictionary<String, Imm>();
___nl__7 = new ImmHash(__function_map).clone();
//line 265
___nl__8 = c_rt_lib_NL.NL_get_true().clone();
//line 265
___nl__9 = c_rt_lib_NL.NL_get_false().clone();
//line 265
__function_map = new Dictionary<String, Imm>();
__function_map.Add("level",___nl__5);
__function_map.Add("from",___nl__6);
__function_map.Add("to",___nl__7);
__function_map.Add("check",___nl__8);
__function_map.Add("cast",___nl__9);
___nl__4 = new ImmHash(__function_map).clone();
//line 265
___nl__5 = null;
//line 265
___nl__6 = null;
//line 265
___nl__7 = null;
//line 265
___nl__8 = null;
//line 265
___nl__9 = null;
//line 266
___nl__6 = ((ImmHash)___nl__1).getHashValue()["type"].clone();
//line 266
___nl__7 = ((ImmHash)___nl__1).getHashValue()["src"].clone();
//line 266
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__5 = ptd_system_NL.NL_check_assignment_info_priv(___nl__0,___nl__6,___nl__4,___nl__7,___ref______nl__2,___ref______nl__3).clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 266
___nl__7 = null;
//line 266
___nl__6 = null;
//line 266
___nl__0 = null;
//line 266
___nl__1 = null;
//line 266
___nl__4 = null;
//line 266
___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return ___nl__5;
//line 266
___nl__5 = null;
//line 266
___nl__4 = null;
//line 266
___nl__0 = null;
//line 266
___nl__1 = null;
//line 266
___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return null;
}

private static Imm NL_mk_err_priv(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 270
___nl__3 = new ImmArray(new Imm[0]).clone();
//line 270
__function_map = new Dictionary<String, Imm>();
__function_map.Add("to",___nl__0);
__function_map.Add("from",___nl__1);
__function_map.Add("stack",___nl__3);
___nl__2 = new ImmHash(__function_map).clone();
//line 270
___nl__3 = null;
//line 270
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("err"), ___nl__2).clone();
//line 270
___nl__0 = null;
//line 270
___nl__1 = null;
//line 270
if(true) return ___nl__2;
//line 270
___nl__2 = null;
//line 270
___nl__0 = null;
//line 270
___nl__1 = null;
//line 270
if(true) return null;
}

private static Imm NL_check_assignment_info_priv(Imm ___arg__0, Imm ___arg__1, Imm ___arg__2, Imm ___arg__3, ImmRef ___arg__4, ImmRef ___arg__5) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();Imm ___nl__3 = ___arg__3.clone();Imm ___nl__4 = ___arg__4.getValue().clone();Imm ___nl__5 = ___arg__5.getValue().clone();
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
//line 274
___nl__7 = new ImmString("tct_empty").clone();
//line 274
___nl__6 = ov_NL.NL_is(___nl__1,___nl__7).clone();

//line 274
___nl__7 = null;
//line 274
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 274
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_2;}}
//line 274
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("ok")).clone();
//line 274
___nl__0 = null;
//line 274
___nl__1 = null;
//line 274
___nl__2 = null;
//line 274
___nl__3 = null;
//line 274
___nl__6 = null;
//line 274
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__7;
//line 274
___nl__7 = null;
//line 274
if (true) {goto label_2;}
//line 274
label_2:
//line 274
___nl__6 = null;
//line 275
___nl__7 = new ImmString("tct_void").clone();
//line 275
___nl__6 = ov_NL.NL_is(___nl__1,___nl__7).clone();

//line 275
___nl__7 = null;
//line 275
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 275
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_4;}}
//line 275
___nl__7 = ptd_system_NL.NL_mk_err_priv(___nl__0,___nl__1).clone();

//line 275
___nl__0 = null;
//line 275
___nl__1 = null;
//line 275
___nl__2 = null;
//line 275
___nl__3 = null;
//line 275
___nl__6 = null;
//line 275
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__7;
//line 275
___nl__7 = null;
//line 275
if (true) {goto label_4;}
//line 275
label_4:
//line 275
___nl__6 = null;
//line 276
___nl__7 = new ImmString("tct_im").clone();
//line 276
___nl__6 = ov_NL.NL_is(___nl__0,___nl__7).clone();

//line 276
___nl__7 = null;
//line 276
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 276
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_6;}}
//line 277
___nl__7 = ((ImmHash)___nl__2).getHashValue()["check"].clone();
//line 277
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 277
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_9;}}
//line 277
___nl__7 = ptd_system_NL.NL_is_known(___nl__3).clone();

//line 277
label_9:
//line 277
___nl__8 = null;
//line 277
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 277
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_8;}}
//line 277
___nl__8 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("delete")).clone();
//line 277
___nl__9 = ((ImmHash)___nl__2).getHashValue()["from"].clone();
//line 277
___ref______nl__4 = new ImmRef(___nl__4);
___ref______nl__5 = new ImmRef(___nl__5);
ptd_system_NL.NL_walk_on_type_priv(___nl__1,___nl__8,___nl__9,___ref______nl__4,___ref______nl__5);
___nl__4 = ___ref______nl__4.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();

//line 277
___nl__9 = null;
//line 277
___nl__8 = null;
//line 277
if (true) {goto label_8;}
//line 277
label_8:
//line 277
___nl__7 = null;
//line 278
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("ok")).clone();
//line 278
___nl__0 = null;
//line 278
___nl__1 = null;
//line 278
___nl__2 = null;
//line 278
___nl__3 = null;
//line 278
___nl__6 = null;
//line 278
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__7;
//line 278
___nl__7 = null;
//line 279
if (true) {goto label_6;}
//line 279
label_6:
//line 279
___nl__6 = null;
//line 280
___nl__7 = c_rt_lib_NL.NL_get_false().clone();
//line 280
___nl__8 = ptd_system_NL.NL_is_known(___nl__3).clone();

//line 280
___ref______nl__0 = new ImmRef(___nl__0);
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__4 = new ImmRef(___nl__4);
___ref______nl__5 = new ImmRef(___nl__5);
___nl__6 = ptd_system_NL.NL_is_cycle_ref_priv(___ref______nl__0,___ref______nl__1,___ref______nl__2,___nl__7,___nl__8,___ref______nl__4,___ref______nl__5).clone();
___nl__0 = ___ref______nl__0.getValue().clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__4 = ___ref______nl__4.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();

//line 280
___nl__8 = null;
//line 280
___nl__7 = null;
//line 280
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 280
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_11;}}
//line 281
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("ok")).clone();
//line 281
___nl__0 = null;
//line 281
___nl__1 = null;
//line 281
___nl__2 = null;
//line 281
___nl__3 = null;
//line 281
___nl__6 = null;
//line 281
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__7;
//line 281
___nl__7 = null;
//line 282
if (true) {goto label_11;}
//line 282
label_11:
//line 282
___nl__6 = null;
//line 284
___nl__6 = ((ImmHash)___nl__2).getHashValue()["level"].clone();
//line 284
___nl__7 = new ImmDouble(200).clone();
//line 284
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__6.getValue().ToString())) ==((Double.Parse(___nl__7.getValue().ToString())))  ).clone();
//line 284
___nl__7 = null;
//line 284
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 284
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_13;}}
//line 285
___nl__7 = new ImmString("can't assignment this two type").clone();
//line 285
___ref______nl__5 = new ImmRef(___nl__5);
ptd_system_NL.NL_add_error_priv(___ref______nl__5,___nl__7);
___nl__5 = ___ref______nl__5.getValue().clone();

//line 285
___nl__7 = null;
//line 286
___nl__7 = ptd_system_NL.NL_mk_err_priv(___nl__0,___nl__1).clone();

//line 286
___nl__0 = null;
//line 286
___nl__1 = null;
//line 286
___nl__2 = null;
//line 286
___nl__3 = null;
//line 286
___nl__6 = null;
//line 286
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__7;
//line 286
___nl__7 = null;
//line 287
if (true) {goto label_13;}
//line 287
label_13:
//line 287
___nl__6 = null;
//line 289
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_im")).clone();
//line 289
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_15;}}
//line 291
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_arr")).clone();
//line 291
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_16;}}
//line 300
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_hash")).clone();
//line 300
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_17;}}
//line 321
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_rec")).clone();
//line 321
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_18;}}
//line 348
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_ref")).clone();
//line 348
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_19;}}
//line 350
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_void")).clone();
//line 350
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_20;}}
//line 352
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_sim")).clone();
//line 352
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_21;}}
//line 355
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_var")).clone();
//line 355
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_22;}}
//line 382
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_empty")).clone();
//line 382
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_23;}}
//line 382
___nl__6 = new ImmString("NOMATCHALERT").clone();
//line 382
___nl__6 = new ImmArray(new Imm[] {___nl__6,___nl__0,}).clone();
//line 382
c_rt_lib_NL.NL_die();
//line 289
label_15:
//line 290
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("ok")).clone();
//line 290
___nl__0 = null;
//line 290
___nl__1 = null;
//line 290
___nl__2 = null;
//line 290
___nl__3 = null;
//line 290
___nl__6 = null;
//line 290
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__7;
//line 290
___nl__7 = null;
//line 291
if (true) {goto label_14;}
//line 291
label_16:
//line 291
___nl__7 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("tct_arr")).clone();
//line 292
___nl__9 = new ImmString("tct_arr").clone();
//line 292
___nl__8 = ov_NL.NL_is(___nl__1,___nl__9).clone();

//line 292
___nl__9 = null;
//line 292
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 292
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 292
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_25;}}
//line 292
___nl__9 = ptd_system_NL.NL_mk_err_priv(___nl__0,___nl__1).clone();

//line 292
___nl__0 = null;
//line 292
___nl__1 = null;
//line 292
___nl__2 = null;
//line 292
___nl__3 = null;
//line 292
___nl__6 = null;
//line 292
___nl__7 = null;
//line 292
___nl__8 = null;
//line 292
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__9;
//line 292
___nl__9 = null;
//line 292
if (true) {goto label_25;}
//line 292
label_25:
//line 292
___nl__8 = null;
//line 293
___nl__9 = ___nl__1.clone();
//line 293
___nl__9 = c_rt_lib_NL.NL_ov_as(___nl__9, new ImmString("tct_arr")).clone();
//line 293
___ref______nl__4 = new ImmRef(___nl__4);
___ref______nl__5 = new ImmRef(___nl__5);
___nl__8 = ptd_system_NL.NL_check_assignment_info_priv(___nl__7,___nl__9,___nl__2,___nl__3,___ref______nl__4,___ref______nl__5).clone();
___nl__4 = ___ref______nl__4.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();

//line 293
___nl__9 = null;
//line 294
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("ok")).clone();
//line 294
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_27;}}
//line 296
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("err")).clone();
//line 296
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_28;}}
//line 296
___nl__9 = new ImmString("NOMATCHALERT").clone();
//line 296
___nl__9 = new ImmArray(new Imm[] {___nl__9,___nl__8,}).clone();
//line 296
c_rt_lib_NL.NL_die();
//line 294
label_27:
//line 295
___nl__10 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("ok")).clone();
//line 295
___nl__0 = null;
//line 295
___nl__1 = null;
//line 295
___nl__2 = null;
//line 295
___nl__3 = null;
//line 295
___nl__6 = null;
//line 295
___nl__7 = null;
//line 295
___nl__8 = null;
//line 295
___nl__9 = null;
//line 295
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__10;
//line 295
___nl__10 = null;
//line 296
if (true) {goto label_26;}
//line 296
label_28:
//line 296
___nl__10 = c_rt_lib_NL.NL_ov_as(___nl__8, new ImmString("err")).clone();
//line 297
___nl__11 = new ImmString("stack").clone();
//line 297
___nl__11 = c_rt_lib_NL.NL_get_ref_hash(___nl__10,___nl__11).clone();

//line 297
___nl__12 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("ptd_arr")).clone();
//line 297
___ref______nl__11 = new ImmRef(___nl__11);
array_NL.NL_push(___ref______nl__11,___nl__12);
___nl__11 = ___ref______nl__11.getValue().clone();

//line 297
___nl__12 = null;
//line 297
___nl__12 = new ImmString("stack").clone();
//line 297
___ref______nl__10 = new ImmRef(___nl__10);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__10,___nl__12,___nl__11);
___nl__10 = ___ref______nl__10.getValue().clone();

//line 297
___nl__12 = null;
//line 297
___nl__11 = null;
//line 298
___nl__11 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("err"), ___nl__10).clone();
//line 298
___nl__0 = null;
//line 298
___nl__1 = null;
//line 298
___nl__2 = null;
//line 298
___nl__3 = null;
//line 298
___nl__6 = null;
//line 298
___nl__7 = null;
//line 298
___nl__8 = null;
//line 298
___nl__9 = null;
//line 298
___nl__10 = null;
//line 298
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__11;
//line 298
___nl__11 = null;
//line 298
___nl__10 = null;
//line 299
if (true) {goto label_26;}
//line 299
label_26:
//line 299
___nl__9 = null;
//line 299
___nl__8 = null;
//line 299
___nl__7 = null;
//line 300
if (true) {goto label_14;}
//line 300
label_17:
//line 300
___nl__7 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("tct_hash")).clone();
//line 301
___nl__10 = new ImmString("tct_rec").clone();
//line 301
___nl__8 = ov_NL.NL_is(___nl__1,___nl__10).clone();

//line 301
___nl__10 = null;
//line 301
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 301
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_31;}}
//line 301
___nl__10 = new ImmString("known").clone();
//line 301
___nl__8 = ov_NL.NL_is(___nl__3,___nl__10).clone();

//line 301
___nl__10 = null;
//line 301
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 301
label_31:
//line 301
___nl__9 = null;
//line 301
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 301
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_30;}}
//line 302
___nl__9 = ___nl__1.clone();
//line 302
___nl__9 = c_rt_lib_NL.NL_ov_as(___nl__9, new ImmString("tct_rec")).clone();
//line 302
___nl__12 = c_rt_lib_NL.NL_init_iter(___nl__9).clone();

//line 302
label_34:
//line 302
___nl__10 = c_rt_lib_NL.NL_is_end_hash(___nl__12).clone();

//line 302
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_32;}}
//line 302
___nl__10 = c_rt_lib_NL.NL_get_key_iter(___nl__12).clone();

//line 302
___nl__11 = c_rt_lib_NL.NL_hash_get_value(___nl__9,___nl__10).clone();

//line 303
___ref______nl__4 = new ImmRef(___nl__4);
___ref______nl__5 = new ImmRef(___nl__5);
___nl__13 = ptd_system_NL.NL_check_assignment_info_priv(___nl__7,___nl__11,___nl__2,___nl__3,___ref______nl__4,___ref______nl__5).clone();
___nl__4 = ___ref______nl__4.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();

//line 304
___nl__14 = c_rt_lib_NL.NL_ov_is(___nl__13, new ImmString("ok")).clone();
//line 304
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_36;}}
//line 305
___nl__14 = c_rt_lib_NL.NL_ov_is(___nl__13, new ImmString("err")).clone();
//line 305
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_37;}}
//line 305
___nl__14 = new ImmString("NOMATCHALERT").clone();
//line 305
___nl__14 = new ImmArray(new Imm[] {___nl__14,___nl__13,}).clone();
//line 305
c_rt_lib_NL.NL_die();
//line 304
label_36:
//line 305
if (true) {goto label_35;}
//line 305
label_37:
//line 305
___nl__15 = c_rt_lib_NL.NL_ov_as(___nl__13, new ImmString("err")).clone();
//line 306
___nl__16 = new ImmString("stack").clone();
//line 306
___nl__16 = c_rt_lib_NL.NL_get_ref_hash(___nl__15,___nl__16).clone();

//line 306
___nl__17 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ptd_rec"), ___nl__10).clone();
//line 306
___ref______nl__16 = new ImmRef(___nl__16);
array_NL.NL_push(___ref______nl__16,___nl__17);
___nl__16 = ___ref______nl__16.getValue().clone();

//line 306
___nl__17 = null;
//line 306
___nl__17 = new ImmString("stack").clone();
//line 306
___ref______nl__15 = new ImmRef(___nl__15);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__15,___nl__17,___nl__16);
___nl__15 = ___ref______nl__15.getValue().clone();

//line 306
___nl__17 = null;
//line 306
___nl__16 = null;
//line 307
___nl__16 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("err"), ___nl__15).clone();
//line 307
___nl__0 = null;
//line 307
___nl__1 = null;
//line 307
___nl__2 = null;
//line 307
___nl__3 = null;
//line 307
___nl__6 = null;
//line 307
___nl__7 = null;
//line 307
___nl__8 = null;
//line 307
___nl__9 = null;
//line 307
___nl__10 = null;
//line 307
___nl__11 = null;
//line 307
___nl__12 = null;
//line 307
___nl__13 = null;
//line 307
___nl__14 = null;
//line 307
___nl__15 = null;
//line 307
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__16;
//line 307
___nl__16 = null;
//line 307
___nl__15 = null;
//line 308
if (true) {goto label_35;}
//line 308
label_35:
//line 308
___nl__14 = null;
//line 308
___nl__13 = null;
//line 309
___nl__12 = c_rt_lib_NL.NL_next_iter(___nl__12).clone();

//line 309
if (true) {goto label_34;}
//line 309
label_32:
//line 309
___nl__9 = null;
//line 309
___nl__10 = null;
//line 309
___nl__11 = null;
//line 309
___nl__12 = null;
//line 310
___nl__9 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("ok")).clone();
//line 310
___nl__0 = null;
//line 310
___nl__1 = null;
//line 310
___nl__2 = null;
//line 310
___nl__3 = null;
//line 310
___nl__6 = null;
//line 310
___nl__7 = null;
//line 310
___nl__8 = null;
//line 310
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__9;
//line 310
___nl__9 = null;
//line 311
if (true) {goto label_30;}
//line 311
label_30:
//line 311
___nl__8 = null;
//line 313
___nl__9 = new ImmString("tct_hash").clone();
//line 313
___nl__8 = ov_NL.NL_is(___nl__1,___nl__9).clone();

//line 313
___nl__9 = null;
//line 313
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 313
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 313
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_39;}}
//line 313
___nl__9 = ptd_system_NL.NL_mk_err_priv(___nl__0,___nl__1).clone();

//line 313
___nl__0 = null;
//line 313
___nl__1 = null;
//line 313
___nl__2 = null;
//line 313
___nl__3 = null;
//line 313
___nl__6 = null;
//line 313
___nl__7 = null;
//line 313
___nl__8 = null;
//line 313
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__9;
//line 313
___nl__9 = null;
//line 313
if (true) {goto label_39;}
//line 313
label_39:
//line 313
___nl__8 = null;
//line 314
___nl__9 = ___nl__1.clone();
//line 314
___nl__9 = c_rt_lib_NL.NL_ov_as(___nl__9, new ImmString("tct_hash")).clone();
//line 314
___ref______nl__4 = new ImmRef(___nl__4);
___ref______nl__5 = new ImmRef(___nl__5);
___nl__8 = ptd_system_NL.NL_check_assignment_info_priv(___nl__7,___nl__9,___nl__2,___nl__3,___ref______nl__4,___ref______nl__5).clone();
___nl__4 = ___ref______nl__4.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();

//line 314
___nl__9 = null;
//line 315
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("ok")).clone();
//line 315
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_41;}}
//line 317
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("err")).clone();
//line 317
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_42;}}
//line 317
___nl__9 = new ImmString("NOMATCHALERT").clone();
//line 317
___nl__9 = new ImmArray(new Imm[] {___nl__9,___nl__8,}).clone();
//line 317
c_rt_lib_NL.NL_die();
//line 315
label_41:
//line 316
___nl__10 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("ok")).clone();
//line 316
___nl__0 = null;
//line 316
___nl__1 = null;
//line 316
___nl__2 = null;
//line 316
___nl__3 = null;
//line 316
___nl__6 = null;
//line 316
___nl__7 = null;
//line 316
___nl__8 = null;
//line 316
___nl__9 = null;
//line 316
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__10;
//line 316
___nl__10 = null;
//line 317
if (true) {goto label_40;}
//line 317
label_42:
//line 317
___nl__10 = c_rt_lib_NL.NL_ov_as(___nl__8, new ImmString("err")).clone();
//line 318
___nl__11 = new ImmString("stack").clone();
//line 318
___nl__11 = c_rt_lib_NL.NL_get_ref_hash(___nl__10,___nl__11).clone();

//line 318
___nl__12 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("ptd_hash")).clone();
//line 318
___ref______nl__11 = new ImmRef(___nl__11);
array_NL.NL_push(___ref______nl__11,___nl__12);
___nl__11 = ___ref______nl__11.getValue().clone();

//line 318
___nl__12 = null;
//line 318
___nl__12 = new ImmString("stack").clone();
//line 318
___ref______nl__10 = new ImmRef(___nl__10);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__10,___nl__12,___nl__11);
___nl__10 = ___ref______nl__10.getValue().clone();

//line 318
___nl__12 = null;
//line 318
___nl__11 = null;
//line 319
___nl__11 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("err"), ___nl__10).clone();
//line 319
___nl__0 = null;
//line 319
___nl__1 = null;
//line 319
___nl__2 = null;
//line 319
___nl__3 = null;
//line 319
___nl__6 = null;
//line 319
___nl__7 = null;
//line 319
___nl__8 = null;
//line 319
___nl__9 = null;
//line 319
___nl__10 = null;
//line 319
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__11;
//line 319
___nl__11 = null;
//line 319
___nl__10 = null;
//line 320
if (true) {goto label_40;}
//line 320
label_40:
//line 320
___nl__9 = null;
//line 320
___nl__8 = null;
//line 320
___nl__7 = null;
//line 321
if (true) {goto label_14;}
//line 321
label_18:
//line 321
___nl__7 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("tct_rec")).clone();
//line 322
___nl__8 = ((ImmHash)___nl__2).getHashValue()["cast"].clone();
//line 322
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 322
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_45;}}
//line 322
___nl__8 = ___nl__1.clone();
//line 322
___nl__8 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("tct_hash")).clone();
//line 322
label_45:
//line 322
___nl__9 = null;
//line 322
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 322
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_44;}}
//line 323
___nl__9 = ___nl__1.clone();
//line 323
___nl__9 = c_rt_lib_NL.NL_ov_as(___nl__9, new ImmString("tct_hash")).clone();
//line 324
___nl__12 = c_rt_lib_NL.NL_init_iter(___nl__7).clone();

//line 324
label_48:
//line 324
___nl__10 = c_rt_lib_NL.NL_is_end_hash(___nl__12).clone();

//line 324
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_46;}}
//line 324
___nl__10 = c_rt_lib_NL.NL_get_key_iter(___nl__12).clone();

//line 324
___nl__11 = c_rt_lib_NL.NL_hash_get_value(___nl__7,___nl__10).clone();

//line 325
___ref______nl__4 = new ImmRef(___nl__4);
___ref______nl__5 = new ImmRef(___nl__5);
___nl__13 = ptd_system_NL.NL_check_assignment_info_priv(___nl__11,___nl__9,___nl__2,___nl__3,___ref______nl__4,___ref______nl__5).clone();
___nl__4 = ___ref______nl__4.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();

//line 326
___nl__14 = c_rt_lib_NL.NL_ov_is(___nl__13, new ImmString("ok")).clone();
//line 326
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_50;}}
//line 327
___nl__14 = c_rt_lib_NL.NL_ov_is(___nl__13, new ImmString("err")).clone();
//line 327
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_51;}}
//line 327
___nl__14 = new ImmString("NOMATCHALERT").clone();
//line 327
___nl__14 = new ImmArray(new Imm[] {___nl__14,___nl__13,}).clone();
//line 327
c_rt_lib_NL.NL_die();
//line 326
label_50:
//line 327
if (true) {goto label_49;}
//line 327
label_51:
//line 327
___nl__15 = c_rt_lib_NL.NL_ov_as(___nl__13, new ImmString("err")).clone();
//line 328
___nl__16 = new ImmString("stack").clone();
//line 328
___nl__16 = c_rt_lib_NL.NL_get_ref_hash(___nl__15,___nl__16).clone();

//line 328
___nl__17 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ptd_rec"), ___nl__10).clone();
//line 328
___ref______nl__16 = new ImmRef(___nl__16);
array_NL.NL_push(___ref______nl__16,___nl__17);
___nl__16 = ___ref______nl__16.getValue().clone();

//line 328
___nl__17 = null;
//line 328
___nl__17 = new ImmString("stack").clone();
//line 328
___ref______nl__15 = new ImmRef(___nl__15);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__15,___nl__17,___nl__16);
___nl__15 = ___ref______nl__15.getValue().clone();

//line 328
___nl__17 = null;
//line 328
___nl__16 = null;
//line 329
___nl__16 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("err"), ___nl__15).clone();
//line 329
___nl__0 = null;
//line 329
___nl__1 = null;
//line 329
___nl__2 = null;
//line 329
___nl__3 = null;
//line 329
___nl__6 = null;
//line 329
___nl__7 = null;
//line 329
___nl__8 = null;
//line 329
___nl__9 = null;
//line 329
___nl__10 = null;
//line 329
___nl__11 = null;
//line 329
___nl__12 = null;
//line 329
___nl__13 = null;
//line 329
___nl__14 = null;
//line 329
___nl__15 = null;
//line 329
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__16;
//line 329
___nl__16 = null;
//line 329
___nl__15 = null;
//line 330
if (true) {goto label_49;}
//line 330
label_49:
//line 330
___nl__14 = null;
//line 330
___nl__13 = null;
//line 331
___nl__12 = c_rt_lib_NL.NL_next_iter(___nl__12).clone();

//line 331
if (true) {goto label_48;}
//line 331
label_46:
//line 331
___nl__10 = null;
//line 331
___nl__11 = null;
//line 331
___nl__12 = null;
//line 332
___nl__10 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("ok")).clone();
//line 332
___nl__0 = null;
//line 332
___nl__1 = null;
//line 332
___nl__2 = null;
//line 332
___nl__3 = null;
//line 332
___nl__6 = null;
//line 332
___nl__7 = null;
//line 332
___nl__8 = null;
//line 332
___nl__9 = null;
//line 332
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__10;
//line 332
___nl__10 = null;
//line 332
___nl__9 = null;
//line 333
if (true) {goto label_44;}
//line 333
label_44:
//line 333
___nl__8 = null;
//line 334
___nl__9 = new ImmString("tct_rec").clone();
//line 334
___nl__8 = ov_NL.NL_is(___nl__1,___nl__9).clone();

//line 334
___nl__9 = null;
//line 334
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 334
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 334
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_53;}}
//line 334
___nl__9 = ptd_system_NL.NL_mk_err_priv(___nl__0,___nl__1).clone();

//line 334
___nl__0 = null;
//line 334
___nl__1 = null;
//line 334
___nl__2 = null;
//line 334
___nl__3 = null;
//line 334
___nl__6 = null;
//line 334
___nl__7 = null;
//line 334
___nl__8 = null;
//line 334
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__9;
//line 334
___nl__9 = null;
//line 334
if (true) {goto label_53;}
//line 334
label_53:
//line 334
___nl__8 = null;
//line 335
___nl__8 = ___nl__1.clone();
//line 335
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__8, new ImmString("tct_rec")).clone();
//line 336
___nl__9 = hash_NL.NL_size(___nl__8).clone();

//line 336
___nl__10 = hash_NL.NL_size(___nl__7).clone();

//line 336
___nl__9 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__9.getValue().ToString())) !=((Double.Parse(___nl__10.getValue().ToString())))  ).clone();
//line 336
___nl__10 = null;
//line 336
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 336
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_55;}}
//line 336
___nl__10 = ptd_system_NL.NL_mk_err_priv(___nl__0,___nl__1).clone();

//line 336
___nl__0 = null;
//line 336
___nl__1 = null;
//line 336
___nl__2 = null;
//line 336
___nl__3 = null;
//line 336
___nl__6 = null;
//line 336
___nl__7 = null;
//line 336
___nl__8 = null;
//line 336
___nl__9 = null;
//line 336
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__10;
//line 336
___nl__10 = null;
//line 336
if (true) {goto label_55;}
//line 336
label_55:
//line 336
___nl__9 = null;
//line 337
___nl__11 = c_rt_lib_NL.NL_init_iter(___nl__7).clone();

//line 337
label_58:
//line 337
___nl__9 = c_rt_lib_NL.NL_is_end_hash(___nl__11).clone();

//line 337
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_56;}}
//line 337
___nl__9 = c_rt_lib_NL.NL_get_key_iter(___nl__11).clone();

//line 337
___nl__10 = c_rt_lib_NL.NL_hash_get_value(___nl__7,___nl__9).clone();

//line 338
___nl__12 = hash_NL.NL_has_key(___nl__8,___nl__9).clone();

//line 338
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 338
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 338
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_60;}}
//line 338
___nl__13 = ptd_system_NL.NL_mk_err_priv(___nl__0,___nl__1).clone();

//line 338
___nl__0 = null;
//line 338
___nl__1 = null;
//line 338
___nl__2 = null;
//line 338
___nl__3 = null;
//line 338
___nl__6 = null;
//line 338
___nl__7 = null;
//line 338
___nl__8 = null;
//line 338
___nl__9 = null;
//line 338
___nl__10 = null;
//line 338
___nl__11 = null;
//line 338
___nl__12 = null;
//line 338
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__13;
//line 338
___nl__13 = null;
//line 338
if (true) {goto label_60;}
//line 338
label_60:
//line 338
___nl__12 = null;
//line 339
___nl__12 = hash_NL.NL_get_value(___nl__8,___nl__9).clone();

//line 340
___ref______nl__4 = new ImmRef(___nl__4);
___ref______nl__5 = new ImmRef(___nl__5);
___nl__13 = ptd_system_NL.NL_check_assignment_info_priv(___nl__10,___nl__12,___nl__2,___nl__3,___ref______nl__4,___ref______nl__5).clone();
___nl__4 = ___ref______nl__4.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();

//line 341
___nl__14 = c_rt_lib_NL.NL_ov_is(___nl__13, new ImmString("ok")).clone();
//line 341
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_62;}}
//line 342
___nl__14 = c_rt_lib_NL.NL_ov_is(___nl__13, new ImmString("err")).clone();
//line 342
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_63;}}
//line 342
___nl__14 = new ImmString("NOMATCHALERT").clone();
//line 342
___nl__14 = new ImmArray(new Imm[] {___nl__14,___nl__13,}).clone();
//line 342
c_rt_lib_NL.NL_die();
//line 341
label_62:
//line 342
if (true) {goto label_61;}
//line 342
label_63:
//line 342
___nl__15 = c_rt_lib_NL.NL_ov_as(___nl__13, new ImmString("err")).clone();
//line 343
___nl__16 = new ImmString("stack").clone();
//line 343
___nl__16 = c_rt_lib_NL.NL_get_ref_hash(___nl__15,___nl__16).clone();

//line 343
___nl__17 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ptd_rec"), ___nl__9).clone();
//line 343
___ref______nl__16 = new ImmRef(___nl__16);
array_NL.NL_push(___ref______nl__16,___nl__17);
___nl__16 = ___ref______nl__16.getValue().clone();

//line 343
___nl__17 = null;
//line 343
___nl__17 = new ImmString("stack").clone();
//line 343
___ref______nl__15 = new ImmRef(___nl__15);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__15,___nl__17,___nl__16);
___nl__15 = ___ref______nl__15.getValue().clone();

//line 343
___nl__17 = null;
//line 343
___nl__16 = null;
//line 344
___nl__16 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("err"), ___nl__15).clone();
//line 344
___nl__0 = null;
//line 344
___nl__1 = null;
//line 344
___nl__2 = null;
//line 344
___nl__3 = null;
//line 344
___nl__6 = null;
//line 344
___nl__7 = null;
//line 344
___nl__8 = null;
//line 344
___nl__9 = null;
//line 344
___nl__10 = null;
//line 344
___nl__11 = null;
//line 344
___nl__12 = null;
//line 344
___nl__13 = null;
//line 344
___nl__14 = null;
//line 344
___nl__15 = null;
//line 344
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__16;
//line 344
___nl__16 = null;
//line 344
___nl__15 = null;
//line 345
if (true) {goto label_61;}
//line 345
label_61:
//line 345
___nl__14 = null;
//line 345
___nl__12 = null;
//line 345
___nl__13 = null;
//line 346
___nl__11 = c_rt_lib_NL.NL_next_iter(___nl__11).clone();

//line 346
if (true) {goto label_58;}
//line 346
label_56:
//line 346
___nl__9 = null;
//line 346
___nl__10 = null;
//line 346
___nl__11 = null;
//line 347
___nl__9 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("ok")).clone();
//line 347
___nl__0 = null;
//line 347
___nl__1 = null;
//line 347
___nl__2 = null;
//line 347
___nl__3 = null;
//line 347
___nl__6 = null;
//line 347
___nl__7 = null;
//line 347
___nl__8 = null;
//line 347
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__9;
//line 347
___nl__9 = null;
//line 347
___nl__8 = null;
//line 347
___nl__7 = null;
//line 348
if (true) {goto label_14;}
//line 348
label_19:
//line 348
___nl__7 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("tct_ref")).clone();
//line 349
___nl__8 = new ImmArray(new Imm[0]).clone();
//line 349
c_rt_lib_NL.NL_die();
//line 349
___nl__8 = null;
//line 349
___nl__7 = null;
//line 350
if (true) {goto label_14;}
//line 350
label_20:
//line 351
___nl__7 = new ImmArray(new Imm[0]).clone();
//line 351
c_rt_lib_NL.NL_die();
//line 351
___nl__7 = null;
//line 352
if (true) {goto label_14;}
//line 352
label_21:
//line 353
___nl__8 = new ImmString("tct_sim").clone();
//line 353
___nl__7 = ov_NL.NL_is(___nl__1,___nl__8).clone();

//line 353
___nl__8 = null;
//line 353
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 353
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_65;}}
//line 353
___nl__8 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("ok")).clone();
//line 353
___nl__0 = null;
//line 353
___nl__1 = null;
//line 353
___nl__2 = null;
//line 353
___nl__3 = null;
//line 353
___nl__6 = null;
//line 353
___nl__7 = null;
//line 353
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__8;
//line 353
___nl__8 = null;
//line 353
if (true) {goto label_65;}
//line 353
label_65:
//line 353
___nl__7 = null;
//line 354
___nl__7 = ptd_system_NL.NL_mk_err_priv(___nl__0,___nl__1).clone();

//line 354
___nl__0 = null;
//line 354
___nl__1 = null;
//line 354
___nl__2 = null;
//line 354
___nl__3 = null;
//line 354
___nl__6 = null;
//line 354
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__7;
//line 354
___nl__7 = null;
//line 355
if (true) {goto label_14;}
//line 355
label_22:
//line 355
___nl__7 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("tct_var")).clone();
//line 356
___nl__9 = new ImmString("tct_var").clone();
//line 356
___nl__8 = ov_NL.NL_is(___nl__1,___nl__9).clone();

//line 356
___nl__9 = null;
//line 356
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 356
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 356
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_67;}}
//line 356
___nl__9 = ptd_system_NL.NL_mk_err_priv(___nl__0,___nl__1).clone();

//line 356
___nl__0 = null;
//line 356
___nl__1 = null;
//line 356
___nl__2 = null;
//line 356
___nl__3 = null;
//line 356
___nl__6 = null;
//line 356
___nl__7 = null;
//line 356
___nl__8 = null;
//line 356
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__9;
//line 356
___nl__9 = null;
//line 356
if (true) {goto label_67;}
//line 356
label_67:
//line 356
___nl__8 = null;
//line 357
___nl__8 = ___nl__1.clone();
//line 357
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__8, new ImmString("tct_var")).clone();
//line 359
___nl__11 = c_rt_lib_NL.NL_init_iter(___nl__8).clone();

//line 359
label_70:
//line 359
___nl__9 = c_rt_lib_NL.NL_is_end_hash(___nl__11).clone();

//line 359
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_68;}}
//line 359
___nl__9 = c_rt_lib_NL.NL_get_key_iter(___nl__11).clone();

//line 359
___nl__10 = c_rt_lib_NL.NL_hash_get_value(___nl__8,___nl__9).clone();

//line 360
___nl__12 = hash_NL.NL_has_key(___nl__7,___nl__9).clone();

//line 360
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 360
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 360
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_72;}}
//line 360
___nl__13 = ptd_system_NL.NL_mk_err_priv(___nl__0,___nl__1).clone();

//line 360
___nl__0 = null;
//line 360
___nl__1 = null;
//line 360
___nl__2 = null;
//line 360
___nl__3 = null;
//line 360
___nl__6 = null;
//line 360
___nl__7 = null;
//line 360
___nl__8 = null;
//line 360
___nl__9 = null;
//line 360
___nl__10 = null;
//line 360
___nl__11 = null;
//line 360
___nl__12 = null;
//line 360
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__13;
//line 360
___nl__13 = null;
//line 360
if (true) {goto label_72;}
//line 360
label_72:
//line 360
___nl__12 = null;
//line 361
___nl__12 = hash_NL.NL_get_value(___nl__7,___nl__9).clone();

//line 362
___nl__13 = c_rt_lib_NL.NL_ov_is(___nl__10, new ImmString("no_param")).clone();
//line 362
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_74;}}
//line 368
___nl__13 = c_rt_lib_NL.NL_ov_is(___nl__10, new ImmString("with_param")).clone();
//line 368
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_75;}}
//line 368
___nl__13 = new ImmString("NOMATCHALERT").clone();
//line 368
___nl__13 = new ImmArray(new Imm[] {___nl__13,___nl__10,}).clone();
//line 368
c_rt_lib_NL.NL_die();
//line 362
label_74:
//line 363
___nl__14 = c_rt_lib_NL.NL_ov_is(___nl__12, new ImmString("no_param")).clone();
//line 363
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_77;}}
//line 365
___nl__14 = c_rt_lib_NL.NL_ov_is(___nl__12, new ImmString("with_param")).clone();
//line 365
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_78;}}
//line 365
___nl__14 = new ImmString("NOMATCHALERT").clone();
//line 365
___nl__14 = new ImmArray(new Imm[] {___nl__14,___nl__12,}).clone();
//line 365
c_rt_lib_NL.NL_die();
//line 363
label_77:
//line 364
___nl__12 = null;
//line 364
___nl__13 = null;
//line 364
___nl__14 = null;
//line 364
if (true) {goto label_69;}
//line 365
if (true) {goto label_76;}
//line 365
label_78:
//line 365
___nl__15 = c_rt_lib_NL.NL_ov_as(___nl__12, new ImmString("with_param")).clone();
//line 366
___nl__16 = ptd_system_NL.NL_mk_err_priv(___nl__0,___nl__1).clone();

//line 366
___nl__0 = null;
//line 366
___nl__1 = null;
//line 366
___nl__2 = null;
//line 366
___nl__3 = null;
//line 366
___nl__6 = null;
//line 366
___nl__7 = null;
//line 366
___nl__8 = null;
//line 366
___nl__9 = null;
//line 366
___nl__10 = null;
//line 366
___nl__11 = null;
//line 366
___nl__12 = null;
//line 366
___nl__13 = null;
//line 366
___nl__14 = null;
//line 366
___nl__15 = null;
//line 366
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__16;
//line 366
___nl__16 = null;
//line 366
___nl__15 = null;
//line 367
if (true) {goto label_76;}
//line 367
label_76:
//line 367
___nl__14 = null;
//line 368
if (true) {goto label_73;}
//line 368
label_75:
//line 368
___nl__14 = c_rt_lib_NL.NL_ov_as(___nl__10, new ImmString("with_param")).clone();
//line 369
___nl__15 = c_rt_lib_NL.NL_ov_is(___nl__12, new ImmString("no_param")).clone();
//line 369
if (c_rt_lib_NL.NL_check_true_native(___nl__15)) {if (true) {goto label_80;}}
//line 371
___nl__15 = c_rt_lib_NL.NL_ov_is(___nl__12, new ImmString("with_param")).clone();
//line 371
if (c_rt_lib_NL.NL_check_true_native(___nl__15)) {if (true) {goto label_81;}}
//line 371
___nl__15 = new ImmString("NOMATCHALERT").clone();
//line 371
___nl__15 = new ImmArray(new Imm[] {___nl__15,___nl__12,}).clone();
//line 371
c_rt_lib_NL.NL_die();
//line 369
label_80:
//line 370
___nl__16 = ptd_system_NL.NL_mk_err_priv(___nl__0,___nl__1).clone();

//line 370
___nl__0 = null;
//line 370
___nl__1 = null;
//line 370
___nl__2 = null;
//line 370
___nl__3 = null;
//line 370
___nl__6 = null;
//line 370
___nl__7 = null;
//line 370
___nl__8 = null;
//line 370
___nl__9 = null;
//line 370
___nl__10 = null;
//line 370
___nl__11 = null;
//line 370
___nl__12 = null;
//line 370
___nl__13 = null;
//line 370
___nl__14 = null;
//line 370
___nl__15 = null;
//line 370
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__16;
//line 370
___nl__16 = null;
//line 371
if (true) {goto label_79;}
//line 371
label_81:
//line 371
___nl__16 = c_rt_lib_NL.NL_ov_as(___nl__12, new ImmString("with_param")).clone();
//line 372
___ref______nl__4 = new ImmRef(___nl__4);
___ref______nl__5 = new ImmRef(___nl__5);
___nl__17 = ptd_system_NL.NL_check_assignment_info_priv(___nl__16,___nl__14,___nl__2,___nl__3,___ref______nl__4,___ref______nl__5).clone();
___nl__4 = ___ref______nl__4.getValue().clone();
___nl__5 = ___ref______nl__5.getValue().clone();

//line 373
___nl__18 = c_rt_lib_NL.NL_ov_is(___nl__17, new ImmString("ok")).clone();
//line 373
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_83;}}
//line 374
___nl__18 = c_rt_lib_NL.NL_ov_is(___nl__17, new ImmString("err")).clone();
//line 374
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_84;}}
//line 374
___nl__18 = new ImmString("NOMATCHALERT").clone();
//line 374
___nl__18 = new ImmArray(new Imm[] {___nl__18,___nl__17,}).clone();
//line 374
c_rt_lib_NL.NL_die();
//line 373
label_83:
//line 374
if (true) {goto label_82;}
//line 374
label_84:
//line 374
___nl__19 = c_rt_lib_NL.NL_ov_as(___nl__17, new ImmString("err")).clone();
//line 375
___nl__20 = new ImmString("stack").clone();
//line 375
___nl__20 = c_rt_lib_NL.NL_get_ref_hash(___nl__19,___nl__20).clone();

//line 375
___nl__21 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ptd_var"), ___nl__9).clone();
//line 375
___ref______nl__20 = new ImmRef(___nl__20);
array_NL.NL_push(___ref______nl__20,___nl__21);
___nl__20 = ___ref______nl__20.getValue().clone();

//line 375
___nl__21 = null;
//line 375
___nl__21 = new ImmString("stack").clone();
//line 375
___ref______nl__19 = new ImmRef(___nl__19);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__19,___nl__21,___nl__20);
___nl__19 = ___ref______nl__19.getValue().clone();

//line 375
___nl__21 = null;
//line 375
___nl__20 = null;
//line 376
___nl__20 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("err"), ___nl__19).clone();
//line 376
___nl__0 = null;
//line 376
___nl__1 = null;
//line 376
___nl__2 = null;
//line 376
___nl__3 = null;
//line 376
___nl__6 = null;
//line 376
___nl__7 = null;
//line 376
___nl__8 = null;
//line 376
___nl__9 = null;
//line 376
___nl__10 = null;
//line 376
___nl__11 = null;
//line 376
___nl__12 = null;
//line 376
___nl__13 = null;
//line 376
___nl__14 = null;
//line 376
___nl__15 = null;
//line 376
___nl__16 = null;
//line 376
___nl__17 = null;
//line 376
___nl__18 = null;
//line 376
___nl__19 = null;
//line 376
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__20;
//line 376
___nl__20 = null;
//line 376
___nl__19 = null;
//line 377
if (true) {goto label_82;}
//line 377
label_82:
//line 377
___nl__18 = null;
//line 377
___nl__17 = null;
//line 377
___nl__16 = null;
//line 378
if (true) {goto label_79;}
//line 378
label_79:
//line 378
___nl__15 = null;
//line 378
___nl__14 = null;
//line 379
if (true) {goto label_73;}
//line 379
label_73:
//line 379
___nl__13 = null;
//line 379
___nl__12 = null;
//line 379
label_69:
//line 380
___nl__11 = c_rt_lib_NL.NL_next_iter(___nl__11).clone();

//line 380
if (true) {goto label_70;}
//line 380
label_68:
//line 380
___nl__9 = null;
//line 380
___nl__10 = null;
//line 380
___nl__11 = null;
//line 381
___nl__9 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("ok")).clone();
//line 381
___nl__0 = null;
//line 381
___nl__1 = null;
//line 381
___nl__2 = null;
//line 381
___nl__3 = null;
//line 381
___nl__6 = null;
//line 381
___nl__7 = null;
//line 381
___nl__8 = null;
//line 381
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return ___nl__9;
//line 381
___nl__9 = null;
//line 381
___nl__8 = null;
//line 381
___nl__7 = null;
//line 382
if (true) {goto label_14;}
//line 382
label_23:
//line 383
___nl__7 = new ImmArray(new Imm[0]).clone();
//line 383
c_rt_lib_NL.NL_die();
//line 383
___nl__7 = null;
//line 384
if (true) {goto label_14;}
//line 384
label_14:
//line 384
___nl__6 = null;
//line 384
___nl__0 = null;
//line 384
___nl__1 = null;
//line 384
___nl__2 = null;
//line 384
___nl__3 = null;
//line 384
___arg__4.setValue(___nl__4);___arg__5.setValue(___nl__5);if(true) return null;
}

private static Imm NL_add_delete_priv(Imm ___arg__0, ImmRef ___arg__1, ImmRef ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();Imm ___nl__2 = ___arg__2.getValue().clone();
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
//line 388
___nl__3 = new ImmString("env").clone();
//line 388
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__3).clone();

//line 388
___nl__4 = new ImmString("deref").clone();
//line 388
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__3,___nl__4).clone();

//line 388
___nl__5 = new ImmString("delete").clone();
//line 388
___nl__5 = c_rt_lib_NL.NL_get_ref_hash(___nl__4,___nl__5).clone();

//line 388
___nl__7 = ((ImmHash)___nl__2).getHashValue()["current_line"].clone();
//line 388
___nl__8 = ((ImmHash)___nl__1).getHashValue()["env"].clone();
//line 388
___nl__8 = ((ImmHash)___nl__8).getHashValue()["current_module"].clone();
//line 388
__function_map = new Dictionary<String, Imm>();
__function_map.Add("line",___nl__7);
__function_map.Add("module",___nl__8);
__function_map.Add("type_name",___nl__0);
___nl__6 = new ImmHash(__function_map).clone();
//line 388
___nl__7 = null;
//line 388
___nl__8 = null;
//line 388
___ref______nl__5 = new ImmRef(___nl__5);
array_NL.NL_push(___ref______nl__5,___nl__6);
___nl__5 = ___ref______nl__5.getValue().clone();

//line 388
___nl__6 = null;
//line 388
___nl__6 = new ImmString("delete").clone();
//line 388
___ref______nl__4 = new ImmRef(___nl__4);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__4,___nl__6,___nl__5);
___nl__4 = ___ref______nl__4.getValue().clone();

//line 388
___nl__6 = new ImmString("deref").clone();
//line 388
___ref______nl__3 = new ImmRef(___nl__3);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__3,___nl__6,___nl__4);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 388
___nl__6 = new ImmString("env").clone();
//line 388
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__6,___nl__3);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 388
___nl__6 = null;
//line 388
___nl__3 = null;
//line 388
___nl__4 = null;
//line 388
___nl__5 = null;
//line 388
___nl__0 = null;
//line 388
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return null;
}

private static Imm NL_add_create_priv(Imm ___arg__0, ImmRef ___arg__1, ImmRef ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();Imm ___nl__2 = ___arg__2.getValue().clone();
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
//line 392
___nl__3 = new ImmString("env").clone();
//line 392
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__3).clone();

//line 392
___nl__4 = new ImmString("deref").clone();
//line 392
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__3,___nl__4).clone();

//line 392
___nl__5 = new ImmString("create").clone();
//line 392
___nl__5 = c_rt_lib_NL.NL_get_ref_hash(___nl__4,___nl__5).clone();

//line 392
___nl__7 = ((ImmHash)___nl__2).getHashValue()["current_line"].clone();
//line 392
___nl__8 = ((ImmHash)___nl__1).getHashValue()["env"].clone();
//line 392
___nl__8 = ((ImmHash)___nl__8).getHashValue()["current_module"].clone();
//line 392
__function_map = new Dictionary<String, Imm>();
__function_map.Add("line",___nl__7);
__function_map.Add("module",___nl__8);
__function_map.Add("type_name",___nl__0);
___nl__6 = new ImmHash(__function_map).clone();
//line 392
___nl__7 = null;
//line 392
___nl__8 = null;
//line 392
___ref______nl__5 = new ImmRef(___nl__5);
array_NL.NL_push(___ref______nl__5,___nl__6);
___nl__5 = ___ref______nl__5.getValue().clone();

//line 392
___nl__6 = null;
//line 392
___nl__6 = new ImmString("create").clone();
//line 392
___ref______nl__4 = new ImmRef(___nl__4);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__4,___nl__6,___nl__5);
___nl__4 = ___ref______nl__4.getValue().clone();

//line 392
___nl__6 = new ImmString("deref").clone();
//line 392
___ref______nl__3 = new ImmRef(___nl__3);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__3,___nl__6,___nl__4);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 392
___nl__6 = new ImmString("env").clone();
//line 392
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__6,___nl__3);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 392
___nl__6 = null;
//line 392
___nl__3 = null;
//line 392
___nl__4 = null;
//line 392
___nl__5 = null;
//line 392
___nl__0 = null;
//line 392
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return null;
}

public static Imm NL_can_delete(Imm ___arg__0, ImmRef ___arg__1, ImmRef ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();Imm ___nl__2 = ___arg__2.getValue().clone();
Imm ___nl__3 = null;
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
//line 396
label_2:
//line 396
___nl__4 = ((ImmHash)___nl__0).getHashValue()["type"].clone();
//line 396
___nl__5 = new ImmString("tct_ref").clone();
//line 396
___nl__3 = ov_NL.NL_is(___nl__4,___nl__5).clone();

//line 396
___nl__5 = null;
//line 396
___nl__4 = null;
//line 396
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 396
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_1;}}
//line 397
___nl__4 = ((ImmHash)___nl__0).getHashValue()["type"].clone();
//line 397
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("tct_ref")).clone();
//line 398
___nl__6 = ((ImmHash)___nl__0).getHashValue()["src"].clone();
//line 398
___nl__5 = ptd_system_NL.NL_is_known(___nl__6).clone();

//line 398
___nl__6 = null;
//line 398
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 398
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_4;}}
//line 398
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
ptd_system_NL.NL_add_delete_priv(___nl__4,___ref______nl__1,___ref______nl__2);
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 398
if (true) {goto label_4;}
//line 398
label_4:
//line 398
___nl__5 = null;
//line 399
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___nl__5 = ptd_system_NL.NL_get_ref_type(___nl__4,___ref______nl__1,___ref______nl__2).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 399
___nl__6 = ___nl__5.clone();
//line 399
((ImmHash)___nl__0).set("type", ___nl__6);
//line 399
___nl__5 = null;
//line 399
___nl__6 = null;
//line 399
___nl__4 = null;
//line 400
if (true) {goto label_2;}
//line 400
label_1:
//line 400
___nl__3 = null;
//line 401
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__0;
//line 401
___nl__0 = null;
//line 401
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return null;
}

public static Imm NL_can_create(Imm ___arg__0, ImmRef ___arg__1, ImmRef ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();Imm ___nl__2 = ___arg__2.getValue().clone();
Imm ___nl__3 = null;
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
//line 405
label_2:
//line 405
___nl__4 = ((ImmHash)___nl__0).getHashValue()["type"].clone();
//line 405
___nl__5 = new ImmString("tct_ref").clone();
//line 405
___nl__3 = ov_NL.NL_is(___nl__4,___nl__5).clone();

//line 405
___nl__5 = null;
//line 405
___nl__4 = null;
//line 405
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 405
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_1;}}
//line 406
___nl__4 = ((ImmHash)___nl__0).getHashValue()["type"].clone();
//line 406
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("tct_ref")).clone();
//line 407
___nl__6 = ((ImmHash)___nl__0).getHashValue()["src"].clone();
//line 407
___nl__5 = ptd_system_NL.NL_is_known(___nl__6).clone();

//line 407
___nl__6 = null;
//line 407
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 407
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_4;}}
//line 407
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
ptd_system_NL.NL_add_create_priv(___nl__4,___ref______nl__1,___ref______nl__2);
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 407
if (true) {goto label_4;}
//line 407
label_4:
//line 407
___nl__5 = null;
//line 408
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___nl__5 = ptd_system_NL.NL_get_ref_type(___nl__4,___ref______nl__1,___ref______nl__2).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 408
___nl__6 = ___nl__5.clone();
//line 408
((ImmHash)___nl__0).set("type", ___nl__6);
//line 408
___nl__5 = null;
//line 408
___nl__6 = null;
//line 408
___nl__4 = null;
//line 409
if (true) {goto label_2;}
//line 409
label_1:
//line 409
___nl__3 = null;
//line 410
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__0;
//line 410
___nl__0 = null;
//line 410
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return null;
}

private static Imm NL_walk_on_type_priv(Imm ___arg__0, Imm ___arg__1, Imm ___arg__2, ImmRef ___arg__3, ImmRef ___arg__4) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();Imm ___nl__3 = ___arg__3.getValue().clone();Imm ___nl__4 = ___arg__4.getValue().clone();
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
//line 414
__function_map = new Dictionary<String, Imm>();
___nl__5 = new ImmHash(__function_map).clone();
//line 415
___ref______nl__5 = new ImmRef(___nl__5);
ptd_system_NL.NL_get_ref_in_type_priv(___nl__0,___ref______nl__5);
___nl__5 = ___ref______nl__5.getValue().clone();

//line 416
___nl__6 = ___nl__5.clone();
//line 417
___nl__9 = c_rt_lib_NL.NL_init_iter(___nl__6).clone();

//line 417
label_3:
//line 417
___nl__7 = c_rt_lib_NL.NL_is_end_hash(___nl__9).clone();

//line 417
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_1;}}
//line 417
___nl__7 = c_rt_lib_NL.NL_get_key_iter(___nl__9).clone();

//line 417
___nl__8 = c_rt_lib_NL.NL_hash_get_value(___nl__6,___nl__7).clone();

//line 418
___ref______nl__3 = new ImmRef(___nl__3);
___ref______nl__4 = new ImmRef(___nl__4);
___nl__10 = ptd_system_NL.NL_get_function_def_priv(___nl__7,___ref______nl__3,___ref______nl__4).clone();
___nl__3 = ___ref______nl__3.getValue().clone();
___nl__4 = ___ref______nl__4.getValue().clone();

//line 419
___nl__11 = array_NL.NL_len(___nl__10).clone();

//line 419
___nl__12 = new ImmDouble(0).clone();
//line 419
___nl__11 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__11.getValue().ToString())) ==((Double.Parse(___nl__12.getValue().ToString())))  ).clone();
//line 419
___nl__12 = null;
//line 419
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 419
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_5;}}
//line 419
___nl__0 = null;
//line 419
___nl__1 = null;
//line 419
___nl__2 = null;
//line 419
___nl__5 = null;
//line 419
___nl__6 = null;
//line 419
___nl__7 = null;
//line 419
___nl__8 = null;
//line 419
___nl__9 = null;
//line 419
___nl__10 = null;
//line 419
___nl__11 = null;
//line 419
___arg__3.setValue(___nl__3);___arg__4.setValue(___nl__4);if(true) return null;
//line 419
if (true) {goto label_5;}
//line 419
label_5:
//line 419
___nl__11 = null;
//line 420
___nl__12 = new ImmDouble(0).clone();
//line 420
___nl__11 = (___nl__10 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__12).getDoubleValue()].clone();
//line 420
___nl__12 = null;
//line 420
___nl__10 = ___nl__11.clone();
//line 420
___nl__11 = null;
//line 421
___nl__11 = ((ImmHash)___nl__10).getHashValue()["ref_types"].clone();
//line 421
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("yes")).clone();
//line 421
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_7;}}
//line 425
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("no")).clone();
//line 425
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_8;}}
//line 425
___nl__12 = new ImmString("NOMATCHALERT").clone();
//line 425
___nl__12 = new ImmArray(new Imm[] {___nl__12,___nl__11,}).clone();
//line 425
c_rt_lib_NL.NL_die();
//line 421
label_7:
//line 421
___nl__13 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("yes")).clone();
//line 422
___nl__15 = new ImmDouble(0).clone();
//line 422
___nl__16 = new ImmDouble(1).clone();
//line 422
___nl__17 = c_rt_lib_NL.NL_array_len(___nl__13).clone();

//line 422
label_11:
//line 422
___nl__18 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__15.getValue().ToString()))>=(Double.Parse(___nl__17.getValue().ToString())) ).clone();
//line 422
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_9;}}
//line 422
___nl__14 = (___nl__13 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__15).getDoubleValue()].clone();
//line 423
___nl__19 = new ImmString("").clone();
//line 423
___ref______nl__5 = new ImmRef(___nl__5);
hash_NL.NL_set_value(___ref______nl__5,___nl__14,___nl__19);
___nl__5 = ___ref______nl__5.getValue().clone();

//line 423
___nl__19 = null;
//line 424
___nl__15 = new ImmDouble((Double.Parse(___nl__15.getValue().ToString()))+(Double.Parse(___nl__16.getValue().ToString()))).clone();
//line 424
if (true) {goto label_11;}
//line 424
label_9:
//line 424
___nl__14 = null;
//line 424
___nl__15 = null;
//line 424
___nl__16 = null;
//line 424
___nl__17 = null;
//line 424
___nl__18 = null;
//line 424
___nl__13 = null;
//line 425
if (true) {goto label_6;}
//line 425
label_8:
//line 426
___ref______nl__3 = new ImmRef(___nl__3);
___ref______nl__4 = new ImmRef(___nl__4);
___nl__13 = ptd_system_NL.NL_get_ref_type(___nl__7,___ref______nl__3,___ref______nl__4).clone();
___nl__3 = ___ref______nl__3.getValue().clone();
___nl__4 = ___ref______nl__4.getValue().clone();

//line 426
___nl__0 = ___nl__13.clone();
//line 426
___nl__13 = null;
//line 427
__function_map = new Dictionary<String, Imm>();
___nl__13 = new ImmHash(__function_map).clone();
//line 428
___ref______nl__13 = new ImmRef(___nl__13);
___ref______nl__3 = new ImmRef(___nl__3);
___ref______nl__4 = new ImmRef(___nl__4);
ptd_system_NL.NL_get_all_ref_in_type_priv(___nl__0,___ref______nl__13,___ref______nl__3,___ref______nl__4);
___nl__13 = ___ref______nl__13.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();
___nl__4 = ___ref______nl__4.getValue().clone();

//line 429
___nl__14 = new ImmArray(new Imm[0]).clone();
//line 430
___nl__17 = c_rt_lib_NL.NL_init_iter(___nl__13).clone();

//line 430
label_14:
//line 430
___nl__15 = c_rt_lib_NL.NL_is_end_hash(___nl__17).clone();

//line 430
if (c_rt_lib_NL.NL_check_true_native(___nl__15)) {if (true) {goto label_12;}}
//line 430
___nl__15 = c_rt_lib_NL.NL_get_key_iter(___nl__17).clone();

//line 430
___nl__16 = c_rt_lib_NL.NL_hash_get_value(___nl__13,___nl__15).clone();

//line 431
___nl__18 = new ImmString("").clone();
//line 431
___ref______nl__5 = new ImmRef(___nl__5);
hash_NL.NL_set_value(___ref______nl__5,___nl__15,___nl__18);
___nl__5 = ___ref______nl__5.getValue().clone();

//line 431
___nl__18 = null;
//line 432
___ref______nl__14 = new ImmRef(___nl__14);
array_NL.NL_push(___ref______nl__14,___nl__15);
___nl__14 = ___ref______nl__14.getValue().clone();

//line 433
___nl__17 = c_rt_lib_NL.NL_next_iter(___nl__17).clone();

//line 433
if (true) {goto label_14;}
//line 433
label_12:
//line 433
___nl__15 = null;
//line 433
___nl__16 = null;
//line 433
___nl__17 = null;
//line 434
___ref______nl__3 = new ImmRef(___nl__3);
___ref______nl__4 = new ImmRef(___nl__4);
___nl__15 = ptd_system_NL.NL_get_function_def_priv(___nl__7,___ref______nl__3,___ref______nl__4).clone();
___nl__3 = ___ref______nl__3.getValue().clone();
___nl__4 = ___ref______nl__4.getValue().clone();

//line 434
___nl__16 = new ImmDouble(0).clone();
//line 434
___nl__15 = (___nl__15 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__16).getDoubleValue()].clone();
//line 434
___nl__16 = null;
//line 434
___nl__10 = ___nl__15.clone();
//line 434
___nl__15 = null;
//line 435
___nl__15 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("yes"), ___nl__14).clone();
//line 435
___nl__16 = ___nl__15.clone();
//line 435
((ImmHash)___nl__10).set("ref_types", ___nl__16);
//line 435
___nl__15 = null;
//line 435
___nl__16 = null;
//line 436
___nl__16 = ((ImmHash)___nl__3).getHashValue()["funs"].clone();
//line 436
___nl__17 = ((ImmHash)___nl__10).getHashValue()["module"].clone();
//line 436
___nl__15 = hash_NL.NL_get_value(___nl__16,___nl__17).clone();

//line 436
___nl__17 = null;
//line 436
___nl__16 = null;
//line 437
___nl__16 = ((ImmHash)___nl__10).getHashValue()["name"].clone();
//line 437
___ref______nl__15 = new ImmRef(___nl__15);
hash_NL.NL_set_value(___ref______nl__15,___nl__16,___nl__10);
___nl__15 = ___ref______nl__15.getValue().clone();

//line 437
___nl__16 = null;
//line 438
___nl__16 = new ImmString("funs").clone();
//line 438
___nl__16 = c_rt_lib_NL.NL_get_ref_hash(___nl__3,___nl__16).clone();

//line 438
___nl__17 = ((ImmHash)___nl__10).getHashValue()["module"].clone();
//line 438
___ref______nl__16 = new ImmRef(___nl__16);
hash_NL.NL_set_value(___ref______nl__16,___nl__17,___nl__15);
___nl__16 = ___ref______nl__16.getValue().clone();

//line 438
___nl__17 = null;
//line 438
___nl__17 = new ImmString("funs").clone();
//line 438
___ref______nl__3 = new ImmRef(___nl__3);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__3,___nl__17,___nl__16);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 438
___nl__17 = null;
//line 438
___nl__16 = null;
//line 438
___nl__13 = null;
//line 438
___nl__14 = null;
//line 438
___nl__15 = null;
//line 439
if (true) {goto label_6;}
//line 439
label_6:
//line 439
___nl__11 = null;
//line 439
___nl__12 = null;
//line 439
___nl__10 = null;
//line 440
___nl__9 = c_rt_lib_NL.NL_next_iter(___nl__9).clone();

//line 440
if (true) {goto label_3;}
//line 440
label_1:
//line 440
___nl__7 = null;
//line 440
___nl__8 = null;
//line 440
___nl__9 = null;
//line 441
___nl__9 = c_rt_lib_NL.NL_init_iter(___nl__5).clone();

//line 441
label_17:
//line 441
___nl__7 = c_rt_lib_NL.NL_is_end_hash(___nl__9).clone();

//line 441
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_15;}}
//line 441
___nl__7 = c_rt_lib_NL.NL_get_key_iter(___nl__9).clone();

//line 441
___nl__8 = c_rt_lib_NL.NL_hash_get_value(___nl__5,___nl__7).clone();

//line 442
___nl__10 = hash_NL.NL_has_key(___nl__2,___nl__7).clone();

//line 442
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 442
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_19;}}
//line 442
___nl__10 = null;
//line 442
if (true) {goto label_16;}
//line 442
if (true) {goto label_19;}
//line 442
label_19:
//line 442
___nl__10 = null;
//line 443
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("create")).clone();
//line 443
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_21;}}
//line 445
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("delete")).clone();
//line 445
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_22;}}
//line 445
___nl__10 = new ImmString("NOMATCHALERT").clone();
//line 445
___nl__10 = new ImmArray(new Imm[] {___nl__10,___nl__1,}).clone();
//line 445
c_rt_lib_NL.NL_die();
//line 443
label_21:
//line 444
___ref______nl__3 = new ImmRef(___nl__3);
___ref______nl__4 = new ImmRef(___nl__4);
ptd_system_NL.NL_add_create_priv(___nl__7,___ref______nl__3,___ref______nl__4);
___nl__3 = ___ref______nl__3.getValue().clone();
___nl__4 = ___ref______nl__4.getValue().clone();

//line 445
if (true) {goto label_20;}
//line 445
label_22:
//line 446
___ref______nl__3 = new ImmRef(___nl__3);
___ref______nl__4 = new ImmRef(___nl__4);
ptd_system_NL.NL_add_delete_priv(___nl__7,___ref______nl__3,___ref______nl__4);
___nl__3 = ___ref______nl__3.getValue().clone();
___nl__4 = ___ref______nl__4.getValue().clone();

//line 447
if (true) {goto label_20;}
//line 447
label_20:
//line 447
___nl__10 = null;
//line 447
label_16:
//line 448
___nl__9 = c_rt_lib_NL.NL_next_iter(___nl__9).clone();

//line 448
if (true) {goto label_17;}
//line 448
label_15:
//line 448
___nl__7 = null;
//line 448
___nl__8 = null;
//line 448
___nl__9 = null;
//line 448
___nl__5 = null;
//line 448
___nl__6 = null;
//line 448
___nl__0 = null;
//line 448
___nl__1 = null;
//line 448
___nl__2 = null;
//line 448
___arg__3.setValue(___nl__3);___arg__4.setValue(___nl__4);if(true) return null;
}

private static Imm NL_get_all_ref_in_type_priv(Imm ___arg__0, ImmRef ___arg__1, ImmRef ___arg__2, ImmRef ___arg__3) {
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
//line 452
__function_map = new Dictionary<String, Imm>();
___nl__4 = new ImmHash(__function_map).clone();
//line 453
___ref______nl__4 = new ImmRef(___nl__4);
ptd_system_NL.NL_get_ref_in_type_priv(___nl__0,___ref______nl__4);
___nl__4 = ___ref______nl__4.getValue().clone();

//line 454
___nl__7 = c_rt_lib_NL.NL_init_iter(___nl__4).clone();

//line 454
label_3:
//line 454
___nl__5 = c_rt_lib_NL.NL_is_end_hash(___nl__7).clone();

//line 454
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_1;}}
//line 454
___nl__5 = c_rt_lib_NL.NL_get_key_iter(___nl__7).clone();

//line 454
___nl__6 = c_rt_lib_NL.NL_hash_get_value(___nl__4,___nl__5).clone();

//line 455
___nl__8 = hash_NL.NL_has_key(___nl__1,___nl__5).clone();

//line 455
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 455
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_5;}}
//line 455
___nl__8 = null;
//line 455
if (true) {goto label_2;}
//line 455
if (true) {goto label_5;}
//line 455
label_5:
//line 455
___nl__8 = null;
//line 456
___nl__8 = new ImmString("").clone();
//line 456
___ref______nl__1 = new ImmRef(___nl__1);
hash_NL.NL_set_value(___ref______nl__1,___nl__5,___nl__8);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 456
___nl__8 = null;
//line 457
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__8 = ptd_system_NL.NL_get_ref_type(___nl__5,___ref______nl__2,___ref______nl__3).clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 457
___nl__0 = ___nl__8.clone();
//line 457
___nl__8 = null;
//line 458
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
ptd_system_NL.NL_get_all_ref_in_type_priv(___nl__0,___ref______nl__1,___ref______nl__2,___ref______nl__3);
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 458
label_2:
//line 459
___nl__7 = c_rt_lib_NL.NL_next_iter(___nl__7).clone();

//line 459
if (true) {goto label_3;}
//line 459
label_1:
//line 459
___nl__5 = null;
//line 459
___nl__6 = null;
//line 459
___nl__7 = null;
//line 459
___nl__4 = null;
//line 459
___nl__0 = null;
//line 459
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);if(true) return null;
}

private static Imm NL_get_ref_in_type_priv(Imm ___arg__0, ImmRef ___arg__1) {
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
//line 462
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_im")).clone();
//line 462
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 463
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_arr")).clone();
//line 463
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_3;}}
//line 465
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_hash")).clone();
//line 465
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_4;}}
//line 467
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_rec")).clone();
//line 467
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_5;}}
//line 471
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_ref")).clone();
//line 471
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_6;}}
//line 473
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_void")).clone();
//line 473
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_7;}}
//line 474
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_sim")).clone();
//line 474
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_8;}}
//line 475
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_var")).clone();
//line 475
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_9;}}
//line 482
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_empty")).clone();
//line 482
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_10;}}
//line 482
___nl__2 = new ImmString("NOMATCHALERT").clone();
//line 482
___nl__2 = new ImmArray(new Imm[] {___nl__2,___nl__0,}).clone();
//line 482
c_rt_lib_NL.NL_die();
//line 462
label_2:
//line 463
if (true) {goto label_1;}
//line 463
label_3:
//line 463
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("tct_arr")).clone();
//line 464
___ref______nl__1 = new ImmRef(___nl__1);
ptd_system_NL.NL_get_ref_in_type_priv(___nl__3,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 464
___nl__3 = null;
//line 465
if (true) {goto label_1;}
//line 465
label_4:
//line 465
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("tct_hash")).clone();
//line 466
___ref______nl__1 = new ImmRef(___nl__1);
ptd_system_NL.NL_get_ref_in_type_priv(___nl__3,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 466
___nl__3 = null;
//line 467
if (true) {goto label_1;}
//line 467
label_5:
//line 467
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("tct_rec")).clone();
//line 468
___nl__6 = c_rt_lib_NL.NL_init_iter(___nl__3).clone();

//line 468
label_13:
//line 468
___nl__4 = c_rt_lib_NL.NL_is_end_hash(___nl__6).clone();

//line 468
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_11;}}
//line 468
___nl__4 = c_rt_lib_NL.NL_get_key_iter(___nl__6).clone();

//line 468
___nl__5 = c_rt_lib_NL.NL_hash_get_value(___nl__3,___nl__4).clone();

//line 469
___ref______nl__1 = new ImmRef(___nl__1);
ptd_system_NL.NL_get_ref_in_type_priv(___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 470
___nl__6 = c_rt_lib_NL.NL_next_iter(___nl__6).clone();

//line 470
if (true) {goto label_13;}
//line 470
label_11:
//line 470
___nl__4 = null;
//line 470
___nl__5 = null;
//line 470
___nl__6 = null;
//line 470
___nl__3 = null;
//line 471
if (true) {goto label_1;}
//line 471
label_6:
//line 471
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("tct_ref")).clone();
//line 472
___nl__4 = new ImmString("").clone();
//line 472
___ref______nl__1 = new ImmRef(___nl__1);
hash_NL.NL_set_value(___ref______nl__1,___nl__3,___nl__4);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 472
___nl__4 = null;
//line 472
___nl__3 = null;
//line 473
if (true) {goto label_1;}
//line 473
label_7:
//line 474
if (true) {goto label_1;}
//line 474
label_8:
//line 475
if (true) {goto label_1;}
//line 475
label_9:
//line 475
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("tct_var")).clone();
//line 476
___nl__6 = c_rt_lib_NL.NL_init_iter(___nl__3).clone();

//line 476
label_16:
//line 476
___nl__4 = c_rt_lib_NL.NL_is_end_hash(___nl__6).clone();

//line 476
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_14;}}
//line 476
___nl__4 = c_rt_lib_NL.NL_get_key_iter(___nl__6).clone();

//line 476
___nl__5 = c_rt_lib_NL.NL_hash_get_value(___nl__3,___nl__4).clone();

//line 477
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("no_param")).clone();
//line 477
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_18;}}
//line 478
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("with_param")).clone();
//line 478
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_19;}}
//line 478
___nl__7 = new ImmString("NOMATCHALERT").clone();
//line 478
___nl__7 = new ImmArray(new Imm[] {___nl__7,___nl__5,}).clone();
//line 478
c_rt_lib_NL.NL_die();
//line 477
label_18:
//line 478
if (true) {goto label_17;}
//line 478
label_19:
//line 478
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("with_param")).clone();
//line 479
___ref______nl__1 = new ImmRef(___nl__1);
ptd_system_NL.NL_get_ref_in_type_priv(___nl__8,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 479
___nl__8 = null;
//line 480
if (true) {goto label_17;}
//line 480
label_17:
//line 480
___nl__7 = null;
//line 481
___nl__6 = c_rt_lib_NL.NL_next_iter(___nl__6).clone();

//line 481
if (true) {goto label_16;}
//line 481
label_14:
//line 481
___nl__4 = null;
//line 481
___nl__5 = null;
//line 481
___nl__6 = null;
//line 481
___nl__3 = null;
//line 482
if (true) {goto label_1;}
//line 482
label_10:
//line 483
if (true) {goto label_1;}
//line 483
label_1:
//line 483
___nl__2 = null;
//line 483
___nl__0 = null;
//line 483
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_get_function_def_priv(Imm ___arg__0, ImmRef ___arg__1, ImmRef ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();Imm ___nl__2 = ___arg__2.getValue().clone();
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
//line 489
___nl__6 = new ImmString("::").clone();
//line 489
___nl__5 = string_NL.NL_index2(___nl__0,___nl__6).clone();

//line 489
___nl__6 = null;
//line 490
___nl__6 = new ImmDouble(0).clone();
//line 490
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) ).clone();
//line 490
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 490
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_2;}}
//line 491
___nl__8 = new ImmDouble(0).clone();
//line 491
___nl__7 = string_NL.NL_substr(___nl__0,___nl__8,___nl__5).clone();

//line 491
___nl__8 = null;
//line 491
___nl__3 = ___nl__7.clone();
//line 491
___nl__7 = null;
//line 492
___nl__8 = new ImmDouble(2).clone();
//line 492
___nl__8 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString()))).clone();
//line 492
___nl__9 = string_NL.NL_length(___nl__0).clone();

//line 492
___nl__9 = new ImmDouble((Double.Parse(___nl__9.getValue().ToString()))-(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 492
___nl__10 = new ImmDouble(2).clone();
//line 492
___nl__9 = new ImmDouble((Double.Parse(___nl__9.getValue().ToString()))-(Double.Parse(___nl__10.getValue().ToString()))).clone();
//line 492
___nl__10 = null;
//line 492
___nl__7 = string_NL.NL_substr(___nl__0,___nl__8,___nl__9).clone();

//line 492
___nl__9 = null;
//line 492
___nl__8 = null;
//line 492
___nl__4 = ___nl__7.clone();
//line 492
___nl__7 = null;
//line 493
if (true) {goto label_1;}
//line 493
label_2:
//line 494
___nl__7 = new ImmString("wrong type name `").clone();
//line 494
___nl__7 = new ImmString(___nl__7.toString() + ___nl__0.toString()).clone();
//line 494
___nl__8 = new ImmString("' ").clone();
//line 494
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 494
___nl__8 = null;
//line 494
___ref______nl__2 = new ImmRef(___nl__2);
ptd_system_NL.NL_add_error_priv(___ref______nl__2,___nl__7);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 494
___nl__7 = null;
//line 495
___nl__7 = new ImmArray(new Imm[0]).clone();
//line 495
___nl__0 = null;
//line 495
___nl__3 = null;
//line 495
___nl__4 = null;
//line 495
___nl__5 = null;
//line 495
___nl__6 = null;
//line 495
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__7;
//line 495
___nl__7 = null;
//line 496
if (true) {goto label_1;}
//line 496
label_1:
//line 496
___nl__6 = null;
//line 497
___nl__7 = ((ImmHash)___nl__1).getHashValue()["funs"].clone();
//line 497
___nl__6 = hash_NL.NL_has_key(___nl__7,___nl__3).clone();

//line 497
___nl__7 = null;
//line 497
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 497
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 497
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_4;}}
//line 498
___nl__7 = new ImmArray(new Imm[0]).clone();
//line 498
___nl__0 = null;
//line 498
___nl__3 = null;
//line 498
___nl__4 = null;
//line 498
___nl__5 = null;
//line 498
___nl__6 = null;
//line 498
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__7;
//line 498
___nl__7 = null;
//line 499
if (true) {goto label_4;}
//line 499
label_4:
//line 499
___nl__6 = null;
//line 501
___nl__7 = ((ImmHash)___nl__1).getHashValue()["funs"].clone();
//line 501
___nl__6 = hash_NL.NL_get_value(___nl__7,___nl__3).clone();

//line 501
___nl__7 = null;
//line 502
___nl__7 = hash_NL.NL_has_key(___nl__6,___nl__4).clone();

//line 502
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 502
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 502
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_6;}}
//line 503
___nl__8 = new ImmString("function `").clone();
//line 503
___nl__8 = new ImmString(___nl__8.toString() + ___nl__0.toString()).clone();
//line 503
___nl__9 = new ImmString("' does not exist").clone();
//line 503
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 503
___nl__9 = null;
//line 503
___ref______nl__2 = new ImmRef(___nl__2);
ptd_system_NL.NL_add_error_priv(___ref______nl__2,___nl__8);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 503
___nl__8 = null;
//line 504
___nl__8 = new ImmArray(new Imm[0]).clone();
//line 504
___nl__0 = null;
//line 504
___nl__3 = null;
//line 504
___nl__4 = null;
//line 504
___nl__5 = null;
//line 504
___nl__6 = null;
//line 504
___nl__7 = null;
//line 504
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__8;
//line 504
___nl__8 = null;
//line 505
if (true) {goto label_6;}
//line 505
label_6:
//line 505
___nl__7 = null;
//line 507
___nl__8 = hash_NL.NL_get_value(___nl__6,___nl__4).clone();

//line 507
___nl__7 = new ImmArray(new Imm[] {___nl__8,}).clone();
//line 507
___nl__8 = null;
//line 507
___nl__0 = null;
//line 507
___nl__3 = null;
//line 507
___nl__4 = null;
//line 507
___nl__5 = null;
//line 507
___nl__6 = null;
//line 507
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__7;
//line 507
___nl__7 = null;
//line 507
___nl__3 = null;
//line 507
___nl__4 = null;
//line 507
___nl__5 = null;
//line 507
___nl__6 = null;
//line 507
___nl__0 = null;
//line 507
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return null;
}

public static Imm NL_get_ref_type(Imm ___arg__0, ImmRef ___arg__1, ImmRef ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();Imm ___nl__2 = ___arg__2.getValue().clone();
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
//line 511
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
___nl__3 = ptd_system_NL.NL_get_function_def_priv(___nl__0,___ref______nl__1,___ref______nl__2).clone();
___nl__1 = ___ref______nl__1.getValue().clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 512
___nl__4 = array_NL.NL_len(___nl__3).clone();

//line 512
___nl__5 = new ImmDouble(0).clone();
//line 512
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString())) ==((Double.Parse(___nl__5.getValue().ToString())))  ).clone();
//line 512
___nl__5 = null;
//line 512
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 512
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 512
___nl__5 = tct_NL.NL_tct_im().clone();

//line 512
___nl__0 = null;
//line 512
___nl__3 = null;
//line 512
___nl__4 = null;
//line 512
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__5;
//line 512
___nl__5 = null;
//line 512
if (true) {goto label_2;}
//line 512
label_2:
//line 512
___nl__4 = null;
//line 513
___nl__5 = new ImmDouble(0).clone();
//line 513
___nl__4 = (___nl__3 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()].clone();
//line 513
___nl__5 = null;
//line 513
___nl__3 = ___nl__4.clone();
//line 513
___nl__4 = null;
//line 514
___nl__5 = ((ImmHash)___nl__1).getHashValue()["funs"].clone();
//line 514
___nl__6 = ((ImmHash)___nl__3).getHashValue()["module"].clone();
//line 514
___nl__4 = hash_NL.NL_get_value(___nl__5,___nl__6).clone();

//line 514
___nl__6 = null;
//line 514
___nl__5 = null;
//line 515
___nl__5 = ((ImmHash)___nl__3).getHashValue()["is_type"].clone();
//line 515
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("yes")).clone();
//line 515
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_4;}}
//line 517
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("no")).clone();
//line 517
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_5;}}
//line 517
___nl__6 = new ImmString("NOMATCHALERT").clone();
//line 517
___nl__6 = new ImmArray(new Imm[] {___nl__6,___nl__5,}).clone();
//line 517
c_rt_lib_NL.NL_die();
//line 515
label_4:
//line 515
___nl__7 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("yes")).clone();
//line 516
___nl__0 = null;
//line 516
___nl__3 = null;
//line 516
___nl__4 = null;
//line 516
___nl__5 = null;
//line 516
___nl__6 = null;
//line 516
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__7;
//line 516
___nl__7 = null;
//line 517
if (true) {goto label_3;}
//line 517
label_5:
//line 518
if (true) {goto label_3;}
//line 518
label_3:
//line 518
___nl__5 = null;
//line 518
___nl__6 = null;
//line 519
___nl__5 = tct_NL.NL_tct_im().clone();

//line 520
___nl__7 = ((ImmHash)___nl__3).getHashValue()["cmd"].clone();
//line 520
___nl__6 = ptd_parser_NL.NL_fun_def_to_ptd(___nl__7).clone();

//line 520
___nl__7 = null;
//line 520
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("err")).clone();
//line 520
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_7;}}
//line 522
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("ok")).clone();
//line 522
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_8;}}
//line 522
___nl__7 = new ImmString("NOMATCHALERT").clone();
//line 522
___nl__7 = new ImmArray(new Imm[] {___nl__7,___nl__6,}).clone();
//line 522
c_rt_lib_NL.NL_die();
//line 520
label_7:
//line 520
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("err")).clone();
//line 521
___ref______nl__2 = new ImmRef(___nl__2);
ptd_system_NL.NL_add_error_priv(___ref______nl__2,___nl__8);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 521
___nl__8 = null;
//line 522
if (true) {goto label_6;}
//line 522
label_8:
//line 522
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("ok")).clone();
//line 523
___nl__5 = ___nl__8.clone();
//line 523
___nl__8 = null;
//line 524
if (true) {goto label_6;}
//line 524
label_6:
//line 524
___nl__6 = null;
//line 524
___nl__7 = null;
//line 525
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("yes"), ___nl__5).clone();
//line 525
___nl__7 = ___nl__6.clone();
//line 525
((ImmHash)___nl__3).set("is_type", ___nl__7);
//line 525
___nl__6 = null;
//line 525
___nl__7 = null;
//line 526
___nl__6 = ((ImmHash)___nl__3).getHashValue()["name"].clone();
//line 526
___ref______nl__4 = new ImmRef(___nl__4);
hash_NL.NL_set_value(___ref______nl__4,___nl__6,___nl__3);
___nl__4 = ___ref______nl__4.getValue().clone();

//line 526
___nl__6 = null;
//line 527
___nl__6 = new ImmString("funs").clone();
//line 527
___nl__6 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__6).clone();

//line 527
___nl__7 = ((ImmHash)___nl__3).getHashValue()["module"].clone();
//line 527
___ref______nl__6 = new ImmRef(___nl__6);
hash_NL.NL_set_value(___ref______nl__6,___nl__7,___nl__4);
___nl__6 = ___ref______nl__6.getValue().clone();

//line 527
___nl__7 = null;
//line 527
___nl__7 = new ImmString("funs").clone();
//line 527
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__7,___nl__6);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 527
___nl__7 = null;
//line 527
___nl__6 = null;
//line 528
___nl__0 = null;
//line 528
___nl__3 = null;
//line 528
___nl__4 = null;
//line 528
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__5;
//line 528
___nl__3 = null;
//line 528
___nl__4 = null;
//line 528
___nl__5 = null;
//line 528
___nl__0 = null;
//line 528
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return null;
}

}
}