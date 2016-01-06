using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class string_compiler_NL {

public static Imm NL_compile(Imm ___arg__0, Imm ___arg__1) {
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
//line 19
___nl__2 = nparser_NL.NL_sparse(___nl__0,___nl__1).clone();

//line 20
___nl__3 = new ImmArray(new Imm[0]).clone();
//line 21
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("ok")).clone();
//line 21
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 31
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("error")).clone();
//line 31
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_3;}}
//line 31
___nl__4 = new ImmString("NOMATCHALERT").clone();
//line 31
___nl__4 = new ImmArray(new Imm[] {___nl__4,___nl__2,}).clone();
//line 31
c_rt_lib_NL.NL_die();
//line 21
label_2:
//line 21
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("ok")).clone();
//line 22
___nl__6 = module_checker_NL.NL_check_module(___nl__5).clone();

//line 23
___nl__7 = ((ImmHash)___nl__6).getHashValue()["errors"].clone();
//line 23
___nl__3 = ___nl__7.clone();
//line 23
___nl__7 = null;
//line 24
___nl__7 = array_NL.NL_len(___nl__3).clone();

//line 24
___nl__8 = new ImmDouble(0).clone();
//line 24
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString())) ==((Double.Parse(___nl__8.getValue().ToString())))  ).clone();
//line 24
___nl__8 = null;
//line 24
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 24
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_5;}}
//line 25
__function_map = new Dictionary<String, Imm>();
___nl__8 = new ImmHash(__function_map).clone();
//line 26
___nl__9 = ((ImmHash)___nl__5).getHashValue()["name"].clone();
//line 26
___ref______nl__8 = new ImmRef(___nl__8);
hash_NL.NL_set_value(___ref______nl__8,___nl__9,___nl__5);
___nl__8 = ___ref______nl__8.getValue().clone();

//line 26
___nl__9 = null;
//line 27
___nl__9 = type_checker_NL.NL_check_modules(___nl__8,___nl__8).clone();

//line 28
___nl__10 = ((ImmHash)___nl__9).getHashValue()["errors"].clone();
//line 28
___nl__3 = ___nl__10.clone();
//line 28
___nl__10 = null;
//line 28
___nl__8 = null;
//line 28
___nl__9 = null;
//line 29
if (true) {goto label_5;}
//line 29
label_5:
//line 29
___nl__7 = null;
//line 30
___nl__7 = array_NL.NL_len(___nl__3).clone();

//line 30
___nl__8 = new ImmDouble(0).clone();
//line 30
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString())) ==((Double.Parse(___nl__8.getValue().ToString())))  ).clone();
//line 30
___nl__8 = null;
//line 30
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 30
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_7;}}
//line 30
___nl__8 = translator_NL.NL_translate(___nl__5).clone();

//line 30
___nl__8 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__8).clone();
//line 30
___nl__0 = null;
//line 30
___nl__1 = null;
//line 30
___nl__2 = null;
//line 30
___nl__3 = null;
//line 30
___nl__4 = null;
//line 30
___nl__5 = null;
//line 30
___nl__6 = null;
//line 30
___nl__7 = null;
//line 30
if(true) return ___nl__8;
//line 30
___nl__8 = null;
//line 30
if (true) {goto label_7;}
//line 30
label_7:
//line 30
___nl__7 = null;
//line 30
___nl__6 = null;
//line 30
___nl__5 = null;
//line 31
if (true) {goto label_1;}
//line 31
label_3:
//line 31
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("error")).clone();
//line 32
___nl__3 = ___nl__5.clone();
//line 32
___nl__5 = null;
//line 33
if (true) {goto label_1;}
//line 33
label_1:
//line 33
___nl__4 = null;
//line 34
___nl__6 = new ImmDouble(0).clone();
//line 34
___nl__5 = (___nl__3 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()].clone();
//line 34
___nl__6 = null;
//line 34
___nl__5 = ((ImmHash)___nl__5).getHashValue()["line"].clone();
//line 34
___nl__7 = new ImmDouble(0).clone();
//line 34
___nl__6 = (___nl__3 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()].clone();
//line 34
___nl__7 = null;
//line 34
___nl__6 = ((ImmHash)___nl__6).getHashValue()["msg"].clone();
//line 34
__function_map = new Dictionary<String, Imm>();
__function_map.Add("line",___nl__5);
__function_map.Add("message",___nl__6);
___nl__4 = new ImmHash(__function_map).clone();
//line 34
___nl__5 = null;
//line 34
___nl__6 = null;
//line 34
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("err"), ___nl__4).clone();
//line 34
___nl__0 = null;
//line 34
___nl__1 = null;
//line 34
___nl__2 = null;
//line 34
___nl__3 = null;
//line 34
if(true) return ___nl__4;
//line 34
___nl__4 = null;
//line 34
___nl__2 = null;
//line 34
___nl__3 = null;
//line 34
___nl__0 = null;
//line 34
___nl__1 = null;
//line 34
if(true) return null;
}

public static Imm NL_compile_to_nlasm(Imm ___arg__0) {
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
Imm ___nl__16 = null;
Imm ___nl__17 = null;
Imm ___nl__18 = null;
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
Dictionary<String, Imm> __function_map;
//line 38
___nl__1 = new ImmArray(new Imm[0]).clone();
//line 39
__function_map = new Dictionary<String, Imm>();
___nl__2 = new ImmHash(__function_map).clone();
//line 40
___nl__5 = c_rt_lib_NL.NL_init_iter(___nl__0).clone();

//line 40
label_3:
//line 40
___nl__3 = c_rt_lib_NL.NL_is_end_hash(___nl__5).clone();

//line 40
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_1;}}
//line 40
___nl__3 = c_rt_lib_NL.NL_get_key_iter(___nl__5).clone();

//line 40
___nl__4 = c_rt_lib_NL.NL_hash_get_value(___nl__0,___nl__3).clone();

//line 41
___nl__6 = nparser_NL.NL_sparse(___nl__4,___nl__3).clone();

//line 41
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("ok")).clone();
//line 41
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_5;}}
//line 47
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("error")).clone();
//line 47
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_6;}}
//line 47
___nl__7 = new ImmString("NOMATCHALERT").clone();
//line 47
___nl__7 = new ImmArray(new Imm[] {___nl__7,___nl__6,}).clone();
//line 47
c_rt_lib_NL.NL_die();
//line 41
label_5:
//line 41
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("ok")).clone();
//line 42
___nl__9 = module_checker_NL.NL_check_module(___nl__8).clone();

//line 43
___nl__10 = ((ImmHash)___nl__9).getHashValue()["errors"].clone();
//line 43
___nl__12 = new ImmDouble(0).clone();
//line 43
___nl__13 = new ImmDouble(1).clone();
//line 43
___nl__14 = c_rt_lib_NL.NL_array_len(___nl__10).clone();

//line 43
label_9:
//line 43
___nl__15 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__12.getValue().ToString()))>=(Double.Parse(___nl__14.getValue().ToString())) ).clone();
//line 43
if (c_rt_lib_NL.NL_check_true_native(___nl__15)) {if (true) {goto label_7;}}
//line 43
___nl__11 = (___nl__10 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__12).getDoubleValue()].clone();
//line 44
___nl__17 = ((ImmHash)___nl__11).getHashValue()["msg"].clone();
//line 44
___nl__18 = ((ImmHash)___nl__11).getHashValue()["line"].clone();
//line 44
__function_map = new Dictionary<String, Imm>();
__function_map.Add("msg",___nl__17);
__function_map.Add("line",___nl__18);
__function_map.Add("module",___nl__3);
___nl__16 = new ImmHash(__function_map).clone();
//line 44
___nl__17 = null;
//line 44
___nl__18 = null;
//line 44
___ref______nl__1 = new ImmRef(___nl__1);
array_NL.NL_push(___ref______nl__1,___nl__16);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 44
___nl__16 = null;
//line 45
___nl__12 = new ImmDouble((Double.Parse(___nl__12.getValue().ToString()))+(Double.Parse(___nl__13.getValue().ToString()))).clone();
//line 45
if (true) {goto label_9;}
//line 45
label_7:
//line 45
___nl__10 = null;
//line 45
___nl__11 = null;
//line 45
___nl__12 = null;
//line 45
___nl__13 = null;
//line 45
___nl__14 = null;
//line 45
___nl__15 = null;
//line 46
___ref______nl__2 = new ImmRef(___nl__2);
hash_NL.NL_set_value(___ref______nl__2,___nl__3,___nl__8);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 46
___nl__9 = null;
//line 46
___nl__8 = null;
//line 47
if (true) {goto label_4;}
//line 47
label_6:
//line 47
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("error")).clone();
//line 48
___nl__10 = new ImmDouble(0).clone();
//line 48
___nl__11 = new ImmDouble(1).clone();
//line 48
___nl__12 = c_rt_lib_NL.NL_array_len(___nl__8).clone();

//line 48
label_12:
//line 48
___nl__13 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__10.getValue().ToString()))>=(Double.Parse(___nl__12.getValue().ToString())) ).clone();
//line 48
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_10;}}
//line 48
___nl__9 = (___nl__8 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()].clone();
//line 49
___nl__15 = ((ImmHash)___nl__9).getHashValue()["msg"].clone();
//line 49
___nl__16 = ((ImmHash)___nl__9).getHashValue()["line"].clone();
//line 49
__function_map = new Dictionary<String, Imm>();
__function_map.Add("msg",___nl__15);
__function_map.Add("line",___nl__16);
__function_map.Add("module",___nl__3);
___nl__14 = new ImmHash(__function_map).clone();
//line 49
___nl__15 = null;
//line 49
___nl__16 = null;
//line 49
___ref______nl__1 = new ImmRef(___nl__1);
array_NL.NL_push(___ref______nl__1,___nl__14);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 49
___nl__14 = null;
//line 50
___nl__10 = new ImmDouble((Double.Parse(___nl__10.getValue().ToString()))+(Double.Parse(___nl__11.getValue().ToString()))).clone();
//line 50
if (true) {goto label_12;}
//line 50
label_10:
//line 50
___nl__9 = null;
//line 50
___nl__10 = null;
//line 50
___nl__11 = null;
//line 50
___nl__12 = null;
//line 50
___nl__13 = null;
//line 50
___nl__8 = null;
//line 51
if (true) {goto label_4;}
//line 51
label_4:
//line 51
___nl__6 = null;
//line 51
___nl__7 = null;
//line 52
___nl__5 = c_rt_lib_NL.NL_next_iter(___nl__5).clone();

//line 52
if (true) {goto label_3;}
//line 52
label_1:
//line 52
___nl__3 = null;
//line 52
___nl__4 = null;
//line 52
___nl__5 = null;
//line 53
___nl__3 = array_NL.NL_len(___nl__1).clone();

//line 53
___nl__4 = new ImmDouble(0).clone();
//line 53
___nl__3 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))>(Double.Parse(___nl__4.getValue().ToString())) ).clone();
//line 53
___nl__4 = null;
//line 53
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 53
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_14;}}
//line 53
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("err"), ___nl__1).clone();
//line 53
___nl__0 = null;
//line 53
___nl__1 = null;
//line 53
___nl__2 = null;
//line 53
___nl__3 = null;
//line 53
if(true) return ___nl__4;
//line 53
___nl__4 = null;
//line 53
if (true) {goto label_14;}
//line 53
label_14:
//line 53
___nl__3 = null;
//line 55
___nl__3 = type_checker_NL.NL_check_modules(___nl__2,___nl__2).clone();

//line 56
___nl__5 = ((ImmHash)___nl__3).getHashValue()["errors"].clone();
//line 56
___nl__4 = array_NL.NL_len(___nl__5).clone();

//line 56
___nl__5 = null;
//line 56
___nl__5 = new ImmDouble(0).clone();
//line 56
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>(Double.Parse(___nl__5.getValue().ToString())) ).clone();
//line 56
___nl__5 = null;
//line 56
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 56
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_16;}}
//line 56
___nl__5 = ((ImmHash)___nl__3).getHashValue()["errors"].clone();
//line 56
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("err"), ___nl__5).clone();
//line 56
___nl__0 = null;
//line 56
___nl__1 = null;
//line 56
___nl__2 = null;
//line 56
___nl__3 = null;
//line 56
___nl__4 = null;
//line 56
if(true) return ___nl__5;
//line 56
___nl__5 = null;
//line 56
if (true) {goto label_16;}
//line 56
label_16:
//line 56
___nl__4 = null;
//line 58
__function_map = new Dictionary<String, Imm>();
___nl__4 = new ImmHash(__function_map).clone();
//line 59
___nl__7 = c_rt_lib_NL.NL_init_iter(___nl__2).clone();

//line 59
label_19:
//line 59
___nl__5 = c_rt_lib_NL.NL_is_end_hash(___nl__7).clone();

//line 59
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_17;}}
//line 59
___nl__5 = c_rt_lib_NL.NL_get_key_iter(___nl__7).clone();

//line 59
___nl__6 = c_rt_lib_NL.NL_hash_get_value(___nl__2,___nl__5).clone();

//line 60
___nl__8 = translator_NL.NL_translate(___nl__6).clone();

//line 60
___ref______nl__4 = new ImmRef(___nl__4);
hash_NL.NL_set_value(___ref______nl__4,___nl__5,___nl__8);
___nl__4 = ___ref______nl__4.getValue().clone();

//line 60
___nl__8 = null;
//line 61
___nl__7 = c_rt_lib_NL.NL_next_iter(___nl__7).clone();

//line 61
if (true) {goto label_19;}
//line 61
label_17:
//line 61
___nl__5 = null;
//line 61
___nl__6 = null;
//line 61
___nl__7 = null;
//line 62
__function_map = new Dictionary<String, Imm>();
___nl__6 = new ImmHash(__function_map).clone();
//line 62
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("o0")).clone();
//line 62
___nl__5 = post_processing_NL.NL_init(___nl__6,___nl__7).clone();

//line 62
___nl__7 = null;
//line 62
___nl__6 = null;
//line 63
___ref______nl__5 = new ImmRef(___nl__5);
___ref______nl__4 = new ImmRef(___nl__4);
post_processing_NL.NL_find(___ref______nl__5,___ref______nl__4);
___nl__5 = ___ref______nl__5.getValue().clone();
___nl__4 = ___ref______nl__4.getValue().clone();

//line 64
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__4).clone();
//line 64
___nl__0 = null;
//line 64
___nl__1 = null;
//line 64
___nl__2 = null;
//line 64
___nl__3 = null;
//line 64
___nl__4 = null;
//line 64
___nl__5 = null;
//line 64
if(true) return ___nl__6;
//line 64
___nl__6 = null;
//line 64
___nl__1 = null;
//line 64
___nl__2 = null;
//line 64
___nl__3 = null;
//line 64
___nl__4 = null;
//line 64
___nl__5 = null;
//line 64
___nl__0 = null;
//line 64
if(true) return null;
}

public static Imm NL_compile_to_js(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
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
//line 69
___nl__3 = string_compiler_NL.NL_compile_to_nlasm(___nl__0).clone();

//line 69
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("ok")).clone();
//line 69
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_1;}}
//line 69
___nl__0 = null;
//line 69
___nl__1 = null;
//line 69
___nl__2 = null;
//line 69
if(true) return ___nl__3;
//line 69
label_1:
//line 69
___nl__1 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("ok")).clone();
//line 69
___nl__2 = null;
//line 69
___nl__3 = null;
//line 70
__function_map = new Dictionary<String, Imm>();
___nl__2 = new ImmHash(__function_map).clone();
//line 71
___nl__5 = c_rt_lib_NL.NL_init_iter(___nl__1).clone();

//line 71
label_4:
//line 71
___nl__3 = c_rt_lib_NL.NL_is_end_hash(___nl__5).clone();

//line 71
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 71
___nl__3 = c_rt_lib_NL.NL_get_key_iter(___nl__5).clone();

//line 71
___nl__4 = c_rt_lib_NL.NL_hash_get_value(___nl__1,___nl__3).clone();

//line 72
___nl__6 = generator_js_NL.NL_generate(___nl__4).clone();

//line 72
___ref______nl__2 = new ImmRef(___nl__2);
hash_NL.NL_set_value(___ref______nl__2,___nl__3,___nl__6);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 72
___nl__6 = null;
//line 73
___nl__5 = c_rt_lib_NL.NL_next_iter(___nl__5).clone();

//line 73
if (true) {goto label_4;}
//line 73
label_2:
//line 73
___nl__3 = null;
//line 73
___nl__4 = null;
//line 73
___nl__5 = null;
//line 74
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__2).clone();
//line 74
___nl__0 = null;
//line 74
___nl__1 = null;
//line 74
___nl__2 = null;
//line 74
if(true) return ___nl__3;
//line 74
___nl__3 = null;
//line 74
___nl__1 = null;
//line 74
___nl__2 = null;
//line 74
___nl__0 = null;
//line 74
if(true) return null;
}

}
}