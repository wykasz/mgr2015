using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class module_checker_NL {

public static Imm NL_SINGLETON_stack_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 19
___nl__1 = ptd_NL.NL_sim();

//line 19
___nl__0 = ptd_NL.NL_arr(___nl__1);

//line 19
___nl__1 = null;
//line 19
if(true) return ___nl__0;
//line 19
___nl__0 = null;
//line 19
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_stack_t = null;
public static Imm NL_stack_t() {
	if (value__singleton__NL_SINGLETON_stack_t == null) {
		value__singleton__NL_SINGLETON_stack_t = NL_SINGLETON_stack_t();
	}
	return value__singleton__NL_SINGLETON_stack_t;
}
public static Imm NL_SINGLETON_stack_hash_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 23
___nl__1 = ptd_NL.NL_sim();

//line 23
___nl__0 = ptd_NL.NL_hash(___nl__1);

//line 23
___nl__1 = null;
//line 23
if(true) return ___nl__0;
//line 23
___nl__0 = null;
//line 23
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_stack_hash_t = null;
public static Imm NL_stack_hash_t() {
	if (value__singleton__NL_SINGLETON_stack_hash_t == null) {
		value__singleton__NL_SINGLETON_stack_hash_t = NL_SINGLETON_stack_hash_t();
	}
	return value__singleton__NL_SINGLETON_stack_hash_t;
}
public static Imm NL_SINGLETON_ret_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 27
___nl__3 = ptd_NL.NL_sim();

//line 27
___nl__2 = ptd_NL.NL_arr(___nl__3);

//line 27
___nl__3 = null;
//line 27
___nl__3 = ptd_NL.NL_none();

//line 27
__function_map = new Dictionary<String, Imm>();
__function_map.Add("loop",___nl__2);
__function_map.Add("ok",___nl__3);
___nl__1 = new ImmHash(__function_map);
//line 27
___nl__2 = null;
//line 27
___nl__3 = null;
//line 27
___nl__0 = ptd_NL.NL_var(___nl__1);

//line 27
___nl__1 = null;
//line 27
if(true) return ___nl__0;
//line 27
___nl__0 = null;
//line 27
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_ret_t = null;
public static Imm NL_ret_t() {
	if (value__singleton__NL_SINGLETON_ret_t == null) {
		value__singleton__NL_SINGLETON_ret_t = NL_SINGLETON_ret_t();
	}
	return value__singleton__NL_SINGLETON_ret_t;
}
public static Imm NL_SINGLETON_modules_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 31
___nl__2 = ptd_NL.NL_sim();

//line 31
___nl__1 = ptd_NL.NL_arr(___nl__2);

//line 31
___nl__2 = null;
//line 31
___nl__0 = ptd_NL.NL_hash(___nl__1);

//line 31
___nl__1 = null;
//line 31
if(true) return ___nl__0;
//line 31
___nl__0 = null;
//line 31
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_modules_t = null;
public static Imm NL_modules_t() {
	if (value__singleton__NL_SINGLETON_modules_t == null) {
		value__singleton__NL_SINGLETON_modules_t = NL_SINGLETON_modules_t();
	}
	return value__singleton__NL_SINGLETON_modules_t;
}
public static Imm NL_search_loops(Imm ___arg__0) {
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
//line 35
__function_map = new Dictionary<String, Imm>();
___nl__1 = new ImmHash(__function_map);
//line 36
___nl__4 = c_rt_lib_NL.NL_init_iter(___nl__0);

//line 36
label_3:
//line 36
___nl__2 = c_rt_lib_NL.NL_is_end_hash(___nl__4);

//line 36
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_1;}}
//line 36
___nl__2 = c_rt_lib_NL.NL_get_key_iter(___nl__4);

//line 36
___nl__3 = c_rt_lib_NL.NL_hash_get_value(___nl__0,___nl__2);

//line 37
___nl__5 = hash_NL.NL_has_key(___nl__1,___nl__2);

//line 37
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 37
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 37
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_5;}}
//line 38
___nl__6 = new ImmArray(new Imm[0]);
//line 39
__function_map = new Dictionary<String, Imm>();
___nl__7 = new ImmHash(__function_map);
//line 40
___ref______nl__6 = new ImmRef(___nl__6);
___ref______nl__7 = new ImmRef(___nl__7);
___ref______nl__1 = new ImmRef(___nl__1);
___nl__8 = module_checker_NL.NL_check_module_priv(___nl__2,___nl__0,___ref______nl__6,___ref______nl__7,___ref______nl__1);
___nl__6 = ___ref______nl__6.getValue();
___nl__7 = ___ref______nl__7.getValue();
___nl__1 = ___ref______nl__1.getValue();

//line 40
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("loop"));
//line 40
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_7;}}
//line 42
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("ok"));
//line 42
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_8;}}
//line 42
___nl__9 = new ImmString("NOMATCHALERT");
//line 42
___nl__9 = new ImmArray(new Imm[] {___nl__9,___nl__8,});
//line 42
c_rt_lib_NL.NL_die();
//line 40
label_7:
//line 40
___nl__10 = c_rt_lib_NL.NL_ov_as(___nl__8, new ImmString("loop"));
//line 41
___nl__11 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("loop"), ___nl__10);
//line 41
___nl__0 = null;
//line 41
___nl__1 = null;
//line 41
___nl__2 = null;
//line 41
___nl__3 = null;
//line 41
___nl__4 = null;
//line 41
___nl__5 = null;
//line 41
___nl__6 = null;
//line 41
___nl__7 = null;
//line 41
___nl__8 = null;
//line 41
___nl__9 = null;
//line 41
___nl__10 = null;
//line 41
if(true) return ___nl__11;
//line 41
___nl__11 = null;
//line 41
___nl__10 = null;
//line 42
if (true) {goto label_6;}
//line 42
label_8:
//line 43
if (true) {goto label_6;}
//line 43
label_6:
//line 43
___nl__8 = null;
//line 43
___nl__9 = null;
//line 43
___nl__6 = null;
//line 43
___nl__7 = null;
//line 44
if (true) {goto label_5;}
//line 44
label_5:
//line 44
___nl__5 = null;
//line 45
___nl__4 = c_rt_lib_NL.NL_next_iter(___nl__4);

//line 45
if (true) {goto label_3;}
//line 45
label_1:
//line 45
___nl__2 = null;
//line 45
___nl__3 = null;
//line 45
___nl__4 = null;
//line 46
___nl__2 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("ok"));
//line 46
___nl__0 = null;
//line 46
___nl__1 = null;
//line 46
if(true) return ___nl__2;
//line 46
___nl__2 = null;
//line 46
___nl__1 = null;
//line 46
___nl__0 = null;
//line 46
if(true) return null;
}

private static Imm NL_check_module_priv(Imm ___arg__0, Imm ___arg__1, ImmRef ___arg__2, ImmRef ___arg__3, ImmRef ___arg__4) {
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
//line 51
___nl__5 = new ImmDouble(1);
//line 51
___ref______nl__4 = new ImmRef(___nl__4);
hash_NL.NL_set_value(___ref______nl__4,___nl__0,___nl__5);
___nl__4 = ___ref______nl__4.getValue();

//line 51
___nl__5 = null;
//line 52
___nl__5 = new ImmDouble(1);
//line 52
___ref______nl__3 = new ImmRef(___nl__3);
hash_NL.NL_set_value(___ref______nl__3,___nl__0,___nl__5);
___nl__3 = ___ref______nl__3.getValue();

//line 52
___nl__5 = null;
//line 53
___ref______nl__2 = new ImmRef(___nl__2);
array_NL.NL_push(___ref______nl__2,___nl__0);
___nl__2 = ___ref______nl__2.getValue();

//line 54
___nl__5 = hash_NL.NL_get_value(___nl__1,___nl__0);

//line 54
___nl__7 = new ImmDouble(0);
//line 54
___nl__8 = new ImmDouble(1);
//line 54
___nl__9 = c_rt_lib_NL.NL_array_len(___nl__5);

//line 54
label_3:
//line 54
___nl__10 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))>=(Double.Parse(___nl__9.getValue().ToString())) );
//line 54
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_1;}}
//line 54
___nl__6 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 55
___nl__11 = hash_NL.NL_has_key(___nl__3,___nl__6);

//line 55
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11));
//line 55
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_5;}}
//line 56
___nl__12 = module_checker_NL.NL_get_loop_from_stack_priv(___nl__6,___nl__2);

//line 56
___nl__12 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("loop"), ___nl__12);
//line 56
___nl__0 = null;
//line 56
___nl__1 = null;
//line 56
___nl__5 = null;
//line 56
___nl__6 = null;
//line 56
___nl__7 = null;
//line 56
___nl__8 = null;
//line 56
___nl__9 = null;
//line 56
___nl__10 = null;
//line 56
___nl__11 = null;
//line 56
___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);___arg__4.setValue(___nl__4);if(true) return ___nl__12;
//line 56
___nl__12 = null;
//line 57
if (true) {goto label_6;}
//line 57
label_5:
//line 57
___nl__11 = hash_NL.NL_has_key(___nl__1,___nl__6);

//line 57
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11));
//line 57
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_7;}}
//line 57
___nl__11 = hash_NL.NL_has_key(___nl__4,___nl__6);

//line 57
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11));
//line 57
label_7:
//line 57
___nl__12 = null;
//line 57
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11));
//line 57
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_6;}}
//line 58
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___ref______nl__4 = new ImmRef(___nl__4);
___nl__12 = module_checker_NL.NL_check_module_priv(___nl__6,___nl__1,___ref______nl__2,___ref______nl__3,___ref______nl__4);
___nl__2 = ___ref______nl__2.getValue();
___nl__3 = ___ref______nl__3.getValue();
___nl__4 = ___ref______nl__4.getValue();

//line 58
___nl__13 = c_rt_lib_NL.NL_ov_is(___nl__12, new ImmString("loop"));
//line 58
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_9;}}
//line 60
___nl__13 = c_rt_lib_NL.NL_ov_is(___nl__12, new ImmString("ok"));
//line 60
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_10;}}
//line 60
___nl__13 = new ImmString("NOMATCHALERT");
//line 60
___nl__13 = new ImmArray(new Imm[] {___nl__13,___nl__12,});
//line 60
c_rt_lib_NL.NL_die();
//line 58
label_9:
//line 58
___nl__14 = c_rt_lib_NL.NL_ov_as(___nl__12, new ImmString("loop"));
//line 59
___nl__15 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("loop"), ___nl__14);
//line 59
___nl__0 = null;
//line 59
___nl__1 = null;
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
___nl__12 = null;
//line 59
___nl__13 = null;
//line 59
___nl__14 = null;
//line 59
___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);___arg__4.setValue(___nl__4);if(true) return ___nl__15;
//line 59
___nl__15 = null;
//line 59
___nl__14 = null;
//line 60
if (true) {goto label_8;}
//line 60
label_10:
//line 61
if (true) {goto label_8;}
//line 61
label_8:
//line 61
___nl__12 = null;
//line 61
___nl__13 = null;
//line 62
if (true) {goto label_6;}
//line 62
label_6:
//line 62
___nl__11 = null;
//line 63
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString())));
//line 63
if (true) {goto label_3;}
//line 63
label_1:
//line 63
___nl__5 = null;
//line 63
___nl__6 = null;
//line 63
___nl__7 = null;
//line 63
___nl__8 = null;
//line 63
___nl__9 = null;
//line 63
___nl__10 = null;
//line 64
___ref______nl__3 = new ImmRef(___nl__3);
hash_NL.NL_delete(___ref______nl__3,___nl__0);
___nl__3 = ___ref______nl__3.getValue();

//line 65
___nl__6 = new ImmDouble(0);
//line 65
___nl__7 = array_NL.NL_len(___nl__2);

//line 65
___nl__8 = new ImmDouble(1);
//line 65
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))-(Double.Parse(___nl__8.getValue().ToString())));
//line 65
___nl__8 = null;
//line 65
___nl__5 = array_NL.NL_subarray(___nl__2,___nl__6,___nl__7);

//line 65
___nl__7 = null;
//line 65
___nl__6 = null;
//line 65
___nl__2 = ___nl__5;
//line 65
___nl__5 = null;
//line 66
___nl__5 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("ok"));
//line 66
___nl__0 = null;
//line 66
___nl__1 = null;
//line 66
___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);___arg__4.setValue(___nl__4);if(true) return ___nl__5;
//line 66
___nl__5 = null;
//line 66
___nl__0 = null;
//line 66
___nl__1 = null;
//line 66
___arg__2.setValue(___nl__2);___arg__3.setValue(___nl__3);___arg__4.setValue(___nl__4);if(true) return null;
}

private static Imm NL_get_loop_from_stack_priv(Imm ___arg__0, Imm ___arg__1) {
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
//line 70
___nl__2 = new ImmArray(new Imm[0]);
//line 71
___nl__4 = new ImmDouble(0);
//line 71
___nl__5 = new ImmDouble(1);
//line 71
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__1);

//line 71
label_3:
//line 71
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) );
//line 71
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_1;}}
//line 71
___nl__3 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()];
//line 72
___nl__8 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__0.toString()));
//line 72
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8));
//line 72
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_5;}}
//line 72
___nl__9 = new ImmArray(new Imm[0]);
//line 72
___nl__2 = ___nl__9;
//line 72
___nl__9 = null;
//line 72
if (true) {goto label_5;}
//line 72
label_5:
//line 72
___nl__8 = null;
//line 73
___ref______nl__2 = new ImmRef(___nl__2);
array_NL.NL_push(___ref______nl__2,___nl__3);
___nl__2 = ___ref______nl__2.getValue();

//line 74
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString())));
//line 74
if (true) {goto label_3;}
//line 74
label_1:
//line 74
___nl__3 = null;
//line 74
___nl__4 = null;
//line 74
___nl__5 = null;
//line 74
___nl__6 = null;
//line 74
___nl__7 = null;
//line 75
___ref______nl__2 = new ImmRef(___nl__2);
array_NL.NL_push(___ref______nl__2,___nl__0);
___nl__2 = ___ref______nl__2.getValue();

//line 76
___nl__0 = null;
//line 76
___nl__1 = null;
//line 76
if(true) return ___nl__2;
//line 76
___nl__2 = null;
//line 76
___nl__0 = null;
//line 76
___nl__1 = null;
//line 76
if(true) return null;
}

public static Imm NL_SINGLETON_var_t() {

Imm ___nl__0 = null;
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
//line 79
___nl__4 = ptd_NL.NL_none();

//line 79
___nl__5 = ptd_NL.NL_none();

//line 79
___nl__6 = ptd_NL.NL_none();

//line 79
__function_map = new Dictionary<String, Imm>();
__function_map.Add("const",___nl__4);
__function_map.Add("none",___nl__5);
__function_map.Add("value",___nl__6);
___nl__3 = new ImmHash(__function_map);
//line 79
___nl__4 = null;
//line 79
___nl__5 = null;
//line 79
___nl__6 = null;
//line 79
___nl__2 = ptd_NL.NL_var(___nl__3);

//line 79
___nl__3 = null;
//line 79
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("boolean_t_NL"));
__function_map.Add("name",new ImmString("type"));
___nl__3 = new ImmHash(__function_map);
//line 79
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3);
//line 79
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("boolean_t_NL"));
__function_map.Add("name",new ImmString("type"));
___nl__4 = new ImmHash(__function_map);
//line 79
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__4);
//line 79
__function_map = new Dictionary<String, Imm>();
__function_map.Add("write",___nl__2);
__function_map.Add("read",___nl__3);
__function_map.Add("is_required",___nl__4);
___nl__1 = new ImmHash(__function_map);
//line 79
___nl__2 = null;
//line 79
___nl__3 = null;
//line 79
___nl__4 = null;
//line 79
___nl__0 = ptd_NL.NL_rec(___nl__1);

//line 79
___nl__1 = null;
//line 79
if(true) return ___nl__0;
//line 79
___nl__0 = null;
//line 79
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_var_t = null;
public static Imm NL_var_t() {
	if (value__singleton__NL_SINGLETON_var_t == null) {
		value__singleton__NL_SINGLETON_var_t = NL_SINGLETON_var_t();
	}
	return value__singleton__NL_SINGLETON_var_t;
}
public static Imm NL_SINGLETON_return_t() {

Imm ___nl__0 = null;
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
//line 86
___nl__2 = ptd_NL.NL_none();

//line 86
___nl__3 = ptd_NL.NL_none();

//line 86
___nl__4 = ptd_NL.NL_none();

//line 86
___nl__5 = ptd_NL.NL_none();

//line 86
___nl__6 = ptd_NL.NL_none();

//line 86
__function_map = new Dictionary<String, Imm>();
__function_map.Add("void",___nl__2);
__function_map.Add("none",___nl__3);
__function_map.Add("value",___nl__4);
__function_map.Add("was_void",___nl__5);
__function_map.Add("was_value",___nl__6);
___nl__1 = new ImmHash(__function_map);
//line 86
___nl__2 = null;
//line 86
___nl__3 = null;
//line 86
___nl__4 = null;
//line 86
___nl__5 = null;
//line 86
___nl__6 = null;
//line 86
___nl__0 = ptd_NL.NL_var(___nl__1);

//line 86
___nl__1 = null;
//line 86
if(true) return ___nl__0;
//line 86
___nl__0 = null;
//line 86
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_return_t = null;
public static Imm NL_return_t() {
	if (value__singleton__NL_SINGLETON_return_t == null) {
		value__singleton__NL_SINGLETON_return_t = NL_SINGLETON_return_t();
	}
	return value__singleton__NL_SINGLETON_return_t;
}
public static Imm NL_SINGLETON_state_t() {

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
//line 89
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("boolean_t_NL"));
__function_map.Add("name",new ImmString("type"));
___nl__2 = new ImmHash(__function_map);
//line 89
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2);
//line 89
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("boolean_t_NL"));
__function_map.Add("name",new ImmString("type"));
___nl__5 = new ImmHash(__function_map);
//line 89
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__5);
//line 89
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("module_checker_NL"));
__function_map.Add("name",new ImmString("return_t"));
___nl__6 = new ImmHash(__function_map);
//line 89
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__6);
//line 89
__function_map = new Dictionary<String, Imm>();
__function_map.Add("was",___nl__5);
__function_map.Add("arg",___nl__6);
___nl__4 = new ImmHash(__function_map);
//line 89
___nl__5 = null;
//line 89
___nl__6 = null;
//line 89
___nl__3 = ptd_NL.NL_rec(___nl__4);

//line 89
___nl__4 = null;
//line 89
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("module_checker_NL"));
__function_map.Add("name",new ImmString("var_t"));
___nl__5 = new ImmHash(__function_map);
//line 89
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__5);
//line 89
___nl__4 = ptd_NL.NL_hash(___nl__5);

//line 89
___nl__5 = null;
//line 89
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("tc_types_NL"));
__function_map.Add("name",new ImmString("errors_t"));
___nl__5 = new ImmHash(__function_map);
//line 89
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__5);
//line 89
___nl__9 = ptd_NL.NL_sim();

//line 89
___nl__8 = ptd_NL.NL_hash(___nl__9);

//line 89
___nl__9 = null;
//line 89
___nl__10 = ptd_NL.NL_sim();

//line 89
___nl__9 = ptd_NL.NL_hash(___nl__10);

//line 89
___nl__10 = null;
//line 89
__function_map = new Dictionary<String, Imm>();
__function_map.Add("func",___nl__8);
__function_map.Add("module",___nl__9);
___nl__7 = new ImmHash(__function_map);
//line 89
___nl__8 = null;
//line 89
___nl__9 = null;
//line 89
___nl__6 = ptd_NL.NL_rec(___nl__7);

//line 89
___nl__7 = null;
//line 89
___nl__7 = ptd_NL.NL_sim();

//line 89
__function_map = new Dictionary<String, Imm>();
__function_map.Add("in_loop",___nl__2);
__function_map.Add("return",___nl__3);
__function_map.Add("vars",___nl__4);
__function_map.Add("errors",___nl__5);
__function_map.Add("called",___nl__6);
__function_map.Add("current_module",___nl__7);
___nl__1 = new ImmHash(__function_map);
//line 89
___nl__2 = null;
//line 89
___nl__3 = null;
//line 89
___nl__4 = null;
//line 89
___nl__5 = null;
//line 89
___nl__6 = null;
//line 89
___nl__7 = null;
//line 89
___nl__0 = ptd_NL.NL_rec(___nl__1);

//line 89
___nl__1 = null;
//line 89
if(true) return ___nl__0;
//line 89
___nl__0 = null;
//line 89
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_state_t = null;
public static Imm NL_state_t() {
	if (value__singleton__NL_SINGLETON_state_t == null) {
		value__singleton__NL_SINGLETON_state_t = NL_SINGLETON_state_t();
	}
	return value__singleton__NL_SINGLETON_state_t;
}
public static Imm NL_SINGLETON_save_t() {

Imm ___nl__0 = null;
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
//line 102
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("boolean_t_NL"));
__function_map.Add("name",new ImmString("type"));
___nl__2 = new ImmHash(__function_map);
//line 102
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2);
//line 102
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("module_checker_NL"));
__function_map.Add("name",new ImmString("var_t"));
___nl__4 = new ImmHash(__function_map);
//line 102
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__4);
//line 102
___nl__3 = ptd_NL.NL_hash(___nl__4);

//line 102
___nl__4 = null;
//line 102
__function_map = new Dictionary<String, Imm>();
__function_map.Add("in_loop",___nl__2);
__function_map.Add("vars",___nl__3);
___nl__1 = new ImmHash(__function_map);
//line 102
___nl__2 = null;
//line 102
___nl__3 = null;
//line 102
___nl__0 = ptd_NL.NL_rec(___nl__1);

//line 102
___nl__1 = null;
//line 102
if(true) return ___nl__0;
//line 102
___nl__0 = null;
//line 102
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_save_t = null;
public static Imm NL_save_t() {
	if (value__singleton__NL_SINGLETON_save_t == null) {
		value__singleton__NL_SINGLETON_save_t = NL_SINGLETON_save_t();
	}
	return value__singleton__NL_SINGLETON_save_t;
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
//line 109
___nl__2 = new ImmString("errors");
//line 109
___nl__2 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__2);

//line 109
___nl__4 = ((ImmHash)___nl__0).getHashValue()["current_line"];
//line 109
___nl__5 = ((ImmHash)___nl__0).getHashValue()["module"];
//line 109
__function_map = new Dictionary<String, Imm>();
__function_map.Add("msg",___nl__1);
__function_map.Add("line",___nl__4);
__function_map.Add("module",___nl__5);
___nl__3 = new ImmHash(__function_map);
//line 109
___nl__4 = null;
//line 109
___nl__5 = null;
//line 109
___ref______nl__2 = new ImmRef(___nl__2);
array_NL.NL_push(___ref______nl__2,___nl__3);
___nl__2 = ___ref______nl__2.getValue();

//line 109
___nl__3 = null;
//line 109
___nl__3 = new ImmString("errors");
//line 109
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__3,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 109
___nl__3 = null;
//line 109
___nl__2 = null;
//line 109
___nl__1 = null;
//line 109
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
//line 112
___nl__2 = new ImmString("warnings");
//line 112
___nl__2 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__2);

//line 112
___nl__4 = ((ImmHash)___nl__0).getHashValue()["current_line"];
//line 112
___nl__5 = ((ImmHash)___nl__0).getHashValue()["module"];
//line 112
__function_map = new Dictionary<String, Imm>();
__function_map.Add("msg",___nl__1);
__function_map.Add("line",___nl__4);
__function_map.Add("module",___nl__5);
___nl__3 = new ImmHash(__function_map);
//line 112
___nl__4 = null;
//line 112
___nl__5 = null;
//line 112
___ref______nl__2 = new ImmRef(___nl__2);
array_NL.NL_push(___ref______nl__2,___nl__3);
___nl__2 = ___ref______nl__2.getValue();

//line 112
___nl__3 = null;
//line 112
___nl__3 = new ImmString("warnings");
//line 112
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__3,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 112
___nl__3 = null;
//line 112
___nl__2 = null;
//line 112
___nl__1 = null;
//line 112
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_set_used_function_priv(Imm ___arg__0, Imm ___arg__1, ImmRef ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.getValue().clone();
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
//line 115
___nl__3 = new ImmDouble(0);
//line 115
___ref______nl__2 = new ImmRef(___nl__2);
hash_NL.NL_set_value(___ref______nl__2,___nl__0,___nl__3);
___nl__2 = ___ref______nl__2.getValue();

//line 115
___nl__3 = null;
//line 116
___nl__3 = hash_NL.NL_get_value(___nl__1,___nl__0);

//line 116
___nl__6 = c_rt_lib_NL.NL_init_iter(___nl__3);

//line 116
label_3:
//line 116
___nl__4 = c_rt_lib_NL.NL_is_end_hash(___nl__6);

//line 116
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_1;}}
//line 116
___nl__4 = c_rt_lib_NL.NL_get_key_iter(___nl__6);

//line 116
___nl__5 = c_rt_lib_NL.NL_hash_get_value(___nl__3,___nl__4);

//line 117
___nl__7 = hash_NL.NL_has_key(___nl__1,___nl__4);

//line 117
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 117
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 117
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_5;}}
//line 117
___nl__7 = null;
//line 117
if (true) {goto label_2;}
//line 117
if (true) {goto label_5;}
//line 117
label_5:
//line 117
___nl__7 = null;
//line 118
___nl__7 = hash_NL.NL_has_key(___nl__2,___nl__4);

//line 118
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 118
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_7;}}
//line 118
___nl__7 = null;
//line 118
if (true) {goto label_2;}
//line 118
if (true) {goto label_7;}
//line 118
label_7:
//line 118
___nl__7 = null;
//line 119
___ref______nl__2 = new ImmRef(___nl__2);
module_checker_NL.NL_set_used_function_priv(___nl__4,___nl__1,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue();

//line 119
label_2:
//line 120
___nl__6 = c_rt_lib_NL.NL_next_iter(___nl__6);

//line 120
if (true) {goto label_3;}
//line 120
label_1:
//line 120
___nl__3 = null;
//line 120
___nl__4 = null;
//line 120
___nl__5 = null;
//line 120
___nl__6 = null;
//line 120
___nl__0 = null;
//line 120
___nl__1 = null;
//line 120
___arg__2.setValue(___nl__2);if(true) return null;
}

public static Imm NL_check_module(Imm ___arg__0) {
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
//line 123
___nl__2 = new ImmArray(new Imm[0]);
//line 123
___nl__3 = new ImmArray(new Imm[0]);
//line 123
___nl__4 = new ImmDouble(1);
//line 123
___nl__4 = new ImmDouble(-((ImmDouble)___nl__4).getDoubleValue());
//line 123
___nl__5 = ((ImmHash)___nl__0).getHashValue()["name"];
//line 123
__function_map = new Dictionary<String, Imm>();
__function_map.Add("errors",___nl__2);
__function_map.Add("warnings",___nl__3);
__function_map.Add("current_line",___nl__4);
__function_map.Add("module",___nl__5);
___nl__1 = new ImmHash(__function_map);
//line 123
___nl__2 = null;
//line 123
___nl__3 = null;
//line 123
___nl__4 = null;
//line 123
___nl__5 = null;
//line 124
__function_map = new Dictionary<String, Imm>();
___nl__3 = new ImmHash(__function_map);
//line 124
__function_map = new Dictionary<String, Imm>();
___nl__4 = new ImmHash(__function_map);
//line 124
__function_map = new Dictionary<String, Imm>();
__function_map.Add("func",___nl__3);
__function_map.Add("module",___nl__4);
___nl__2 = new ImmHash(__function_map);
//line 124
___nl__3 = null;
//line 124
___nl__4 = null;
//line 125
___nl__5 = c_rt_lib_NL.NL_get_false();
//line 125
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none"));
//line 125
__function_map = new Dictionary<String, Imm>();
__function_map.Add("was",___nl__5);
__function_map.Add("arg",___nl__6);
___nl__4 = new ImmHash(__function_map);
//line 125
___nl__5 = null;
//line 125
___nl__6 = null;
//line 125
___nl__5 = ((ImmHash)___nl__0).getHashValue()["name"];
//line 125
___nl__6 = c_rt_lib_NL.NL_get_false();
//line 125
__function_map = new Dictionary<String, Imm>();
___nl__7 = new ImmHash(__function_map);
//line 125
__function_map = new Dictionary<String, Imm>();
__function_map.Add("return",___nl__4);
__function_map.Add("current_module",___nl__5);
__function_map.Add("in_loop",___nl__6);
__function_map.Add("called",___nl__2);
__function_map.Add("vars",___nl__7);
__function_map.Add("errors",___nl__1);
___nl__3 = new ImmHash(__function_map);
//line 125
___nl__4 = null;
//line 125
___nl__5 = null;
//line 125
___nl__6 = null;
//line 125
___nl__7 = null;
//line 126
__function_map = new Dictionary<String, Imm>();
___nl__4 = new ImmHash(__function_map);
//line 127
__function_map = new Dictionary<String, Imm>();
___nl__5 = new ImmHash(__function_map);
//line 128
___nl__6 = ((ImmHash)___nl__0).getHashValue()["fun_def"];
//line 128
___nl__8 = new ImmDouble(0);
//line 128
___nl__9 = new ImmDouble(1);
//line 128
___nl__10 = c_rt_lib_NL.NL_array_len(___nl__6);

//line 128
label_3:
//line 128
___nl__11 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString()))>=(Double.Parse(___nl__10.getValue().ToString())) );
//line 128
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_1;}}
//line 128
___nl__7 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 129
___nl__12 = ((ImmHash)___nl__7).getHashValue()["line"];
//line 129
___nl__13 = new ImmString("errors");
//line 129
___nl__13 = c_rt_lib_NL.NL_get_ref_hash(___nl__3,___nl__13);

//line 129
___nl__14 = ___nl__12;
//line 129
((ImmHash)___nl__13).set("current_line", ___nl__14);
//line 129
___nl__15 = new ImmString("errors");
//line 129
___ref______nl__3 = new ImmRef(___nl__3);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__3,___nl__15,___nl__13);
___nl__3 = ___ref______nl__3.getValue();

//line 129
___nl__15 = null;
//line 129
___nl__12 = null;
//line 129
___nl__13 = null;
//line 129
___nl__14 = null;
//line 130
__function_map = new Dictionary<String, Imm>();
___nl__12 = new ImmHash(__function_map);
//line 130
___nl__13 = ___nl__12;
//line 130
((ImmHash)___nl__3).set("vars", ___nl__13);
//line 130
___nl__12 = null;
//line 130
___nl__13 = null;
//line 131
___nl__13 = c_rt_lib_NL.NL_get_false();
//line 131
___nl__15 = ((ImmHash)___nl__7).getHashValue()["ret_type"];
//line 131
___ref______nl__3 = new ImmRef(___nl__3);
___nl__14 = module_checker_NL.NL_check_return_type_priv(___nl__15,___ref______nl__3);
___nl__3 = ___ref______nl__3.getValue();

//line 131
___nl__15 = null;
//line 131
__function_map = new Dictionary<String, Imm>();
__function_map.Add("was",___nl__13);
__function_map.Add("arg",___nl__14);
___nl__12 = new ImmHash(__function_map);
//line 131
___nl__13 = null;
//line 131
___nl__14 = null;
//line 131
___nl__13 = ___nl__12;
//line 131
((ImmHash)___nl__3).set("return", ___nl__13);
//line 131
___nl__12 = null;
//line 131
___nl__13 = null;
//line 132
___ref______nl__3 = new ImmRef(___nl__3);
___nl__12 = module_checker_NL.NL_save_block_priv(___ref______nl__3);
___nl__3 = ___ref______nl__3.getValue();

//line 133
___nl__13 = ((ImmHash)___nl__7).getHashValue()["args"];
//line 133
___nl__15 = new ImmDouble(0);
//line 133
___nl__16 = new ImmDouble(1);
//line 133
___nl__17 = c_rt_lib_NL.NL_array_len(___nl__13);

//line 133
label_6:
//line 133
___nl__18 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__15.getValue().ToString()))>=(Double.Parse(___nl__17.getValue().ToString())) );
//line 133
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_4;}}
//line 133
___nl__14 = (___nl__13 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__15).getDoubleValue()];
//line 134
___nl__19 = ((ImmHash)___nl__14).getHashValue()["name"];
//line 134
___nl__20 = c_rt_lib_NL.NL_get_false();
//line 134
___nl__21 = c_rt_lib_NL.NL_get_false();
//line 134
___ref______nl__3 = new ImmRef(___nl__3);
module_checker_NL.NL_add_var_priv(___nl__19,___nl__20,___nl__21,___ref______nl__3);
___nl__3 = ___ref______nl__3.getValue();

//line 134
___nl__21 = null;
//line 134
___nl__20 = null;
//line 134
___nl__19 = null;
//line 135
___nl__19 = ((ImmHash)___nl__14).getHashValue()["type"];
//line 135
___ref______nl__3 = new ImmRef(___nl__3);
module_checker_NL.NL_check_type_priv(___nl__19,___ref______nl__3);
___nl__3 = ___ref______nl__3.getValue();

//line 135
___nl__19 = null;
//line 136
___nl__19 = ((ImmHash)___nl__14).getHashValue()["name"];
//line 136
___nl__20 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("set"));
//line 136
___ref______nl__3 = new ImmRef(___nl__3);
module_checker_NL.NL_use_var_priv(___nl__19,___nl__20,___ref______nl__3);
___nl__3 = ___ref______nl__3.getValue();

//line 136
___nl__20 = null;
//line 136
___nl__19 = null;
//line 137
___nl__15 = new ImmDouble((Double.Parse(___nl__15.getValue().ToString()))+(Double.Parse(___nl__16.getValue().ToString())));
//line 137
if (true) {goto label_6;}
//line 137
label_4:
//line 137
___nl__13 = null;
//line 137
___nl__14 = null;
//line 137
___nl__15 = null;
//line 137
___nl__16 = null;
//line 137
___nl__17 = null;
//line 137
___nl__18 = null;
//line 138
___nl__13 = ((ImmHash)___nl__7).getHashValue()["cmd"];
//line 138
___ref______nl__3 = new ImmRef(___nl__3);
module_checker_NL.NL_check_cmd_priv(___nl__13,___ref______nl__3);
___nl__3 = ___ref______nl__3.getValue();

//line 138
___nl__13 = null;
//line 139
___nl__13 = ((ImmHash)___nl__7).getHashValue()["args"];
//line 139
___nl__15 = new ImmDouble(0);
//line 139
___nl__16 = new ImmDouble(1);
//line 139
___nl__17 = c_rt_lib_NL.NL_array_len(___nl__13);

//line 139
label_9:
//line 139
___nl__18 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__15.getValue().ToString()))>=(Double.Parse(___nl__17.getValue().ToString())) );
//line 139
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_7;}}
//line 139
___nl__14 = (___nl__13 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__15).getDoubleValue()];
//line 140
___nl__19 = ((ImmHash)___nl__14).getHashValue()["mod"];
//line 140
___nl__19 = c_rt_lib_NL.NL_ov_is(___nl__19, new ImmString("ref"));
//line 140
___nl__19 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__19));
//line 140
if (c_rt_lib_NL.NL_check_true_native(___nl__19)) {if (true) {goto label_11;}}
//line 141
___nl__20 = ((ImmHash)___nl__14).getHashValue()["name"];
//line 141
___nl__21 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("get"));
//line 141
___ref______nl__3 = new ImmRef(___nl__3);
module_checker_NL.NL_use_var_priv(___nl__20,___nl__21,___ref______nl__3);
___nl__3 = ___ref______nl__3.getValue();

//line 141
___nl__21 = null;
//line 141
___nl__20 = null;
//line 142
if (true) {goto label_11;}
//line 142
label_11:
//line 142
___nl__19 = null;
//line 143
___nl__15 = new ImmDouble((Double.Parse(___nl__15.getValue().ToString()))+(Double.Parse(___nl__16.getValue().ToString())));
//line 143
if (true) {goto label_9;}
//line 143
label_7:
//line 143
___nl__13 = null;
//line 143
___nl__14 = null;
//line 143
___nl__15 = null;
//line 143
___nl__16 = null;
//line 143
___nl__17 = null;
//line 143
___nl__18 = null;
//line 144
___ref______nl__3 = new ImmRef(___nl__3);
module_checker_NL.NL_load_block_priv(___ref______nl__3,___nl__12);
___nl__3 = ___ref______nl__3.getValue();

//line 145
___nl__13 = ((ImmHash)___nl__3).getHashValue()["return"];
//line 145
___nl__13 = ((ImmHash)___nl__13).getHashValue()["was"];
//line 145
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13));
//line 145
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13));
//line 145
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_13;}}
//line 146
___nl__14 = ((ImmHash)___nl__3).getHashValue()["return"];
//line 146
___nl__14 = ((ImmHash)___nl__14).getHashValue()["arg"];
//line 146
___nl__14 = c_rt_lib_NL.NL_ov_is(___nl__14, new ImmString("value"));
//line 146
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_16;}}
//line 146
___nl__14 = ((ImmHash)___nl__3).getHashValue()["return"];
//line 146
___nl__14 = ((ImmHash)___nl__14).getHashValue()["arg"];
//line 146
___nl__14 = c_rt_lib_NL.NL_ov_is(___nl__14, new ImmString("was_value"));
//line 146
label_16:
//line 146
___nl__14 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__14));
//line 146
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_15;}}
//line 146
___nl__15 = new ImmString("errors");
//line 146
___nl__15 = c_rt_lib_NL.NL_get_ref_hash(___nl__3,___nl__15);

//line 146
___nl__16 = new ImmString("no return value at end of function");
//line 146
___ref______nl__15 = new ImmRef(___nl__15);
module_checker_NL.NL_add_error_priv(___ref______nl__15,___nl__16);
___nl__15 = ___ref______nl__15.getValue();

//line 146
___nl__16 = null;
//line 146
___nl__16 = new ImmString("errors");
//line 146
___ref______nl__3 = new ImmRef(___nl__3);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__3,___nl__16,___nl__15);
___nl__3 = ___ref______nl__3.getValue();

//line 146
___nl__16 = null;
//line 146
___nl__15 = null;
//line 146
if (true) {goto label_15;}
//line 146
label_15:
//line 146
___nl__14 = null;
//line 148
if (true) {goto label_13;}
//line 148
label_13:
//line 148
___nl__13 = null;
//line 149
___nl__14 = ((ImmHash)___nl__7).getHashValue()["access"];
//line 149
___nl__14 = c_rt_lib_NL.NL_ov_is(___nl__14, new ImmString("pub"));
//line 149
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_18;}}
//line 149
___nl__14 = new ImmString("");
//line 149
if (true) {goto label_17;}
//line 149
label_18:
//line 149
___nl__14 = ((ImmHash)___nl__0).getHashValue()["name"];
//line 149
label_17:
//line 149
___nl__15 = ((ImmHash)___nl__7).getHashValue()["name"];
//line 149
___nl__16 = ((ImmHash)___nl__0).getHashValue()["name"];
//line 149
___nl__13 = module_checker_NL.NL_get_fun_key_priv(___nl__14,___nl__15,___nl__16);

//line 149
___nl__16 = null;
//line 149
___nl__15 = null;
//line 149
___nl__14 = null;
//line 150
___nl__14 = ((ImmHash)___nl__3).getHashValue()["called"];
//line 150
___nl__14 = ((ImmHash)___nl__14).getHashValue()["func"];
//line 150
___ref______nl__4 = new ImmRef(___nl__4);
hash_NL.NL_set_value(___ref______nl__4,___nl__13,___nl__14);
___nl__4 = ___ref______nl__4.getValue();

//line 150
___nl__14 = null;
//line 151
___nl__14 = ((ImmHash)___nl__7).getHashValue()["access"];
//line 151
___nl__14 = c_rt_lib_NL.NL_ov_is(___nl__14, new ImmString("priv"));
//line 151
___nl__14 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__14));
//line 151
___nl__14 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__14));
//line 151
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_20;}}
//line 151
___nl__15 = new ImmDouble(0);
//line 151
___ref______nl__5 = new ImmRef(___nl__5);
hash_NL.NL_set_value(___ref______nl__5,___nl__13,___nl__15);
___nl__5 = ___ref______nl__5.getValue();

//line 151
___nl__15 = null;
//line 151
if (true) {goto label_20;}
//line 151
label_20:
//line 151
___nl__14 = null;
//line 152
__function_map = new Dictionary<String, Imm>();
___nl__14 = new ImmHash(__function_map);
//line 152
___nl__15 = new ImmString("called");
//line 152
___nl__15 = c_rt_lib_NL.NL_get_ref_hash(___nl__3,___nl__15);

//line 152
___nl__16 = ___nl__14;
//line 152
((ImmHash)___nl__15).set("func", ___nl__16);
//line 152
___nl__17 = new ImmString("called");
//line 152
___ref______nl__3 = new ImmRef(___nl__3);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__3,___nl__17,___nl__15);
___nl__3 = ___ref______nl__3.getValue();

//line 152
___nl__17 = null;
//line 152
___nl__14 = null;
//line 152
___nl__15 = null;
//line 152
___nl__16 = null;
//line 152
___nl__12 = null;
//line 152
___nl__13 = null;
//line 153
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))+(Double.Parse(___nl__9.getValue().ToString())));
//line 153
if (true) {goto label_3;}
//line 153
label_1:
//line 153
___nl__6 = null;
//line 153
___nl__7 = null;
//line 153
___nl__8 = null;
//line 153
___nl__9 = null;
//line 153
___nl__10 = null;
//line 153
___nl__11 = null;
//line 154
__function_map = new Dictionary<String, Imm>();
___nl__6 = new ImmHash(__function_map);
//line 155
___nl__7 = ((ImmHash)___nl__0).getHashValue()["import"];
//line 155
___nl__9 = new ImmDouble(0);
//line 155
___nl__10 = new ImmDouble(1);
//line 155
___nl__11 = c_rt_lib_NL.NL_array_len(___nl__7);

//line 155
label_23:
//line 155
___nl__12 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__9.getValue().ToString()))>=(Double.Parse(___nl__11.getValue().ToString())) );
//line 155
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_21;}}
//line 155
___nl__8 = (___nl__7 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()];
//line 156
___nl__13 = ((ImmHash)___nl__8).getHashValue()["line"];
//line 156
___nl__14 = new ImmString("errors");
//line 156
___nl__14 = c_rt_lib_NL.NL_get_ref_hash(___nl__3,___nl__14);

//line 156
___nl__15 = ___nl__13;
//line 156
((ImmHash)___nl__14).set("current_line", ___nl__15);
//line 156
___nl__16 = new ImmString("errors");
//line 156
___ref______nl__3 = new ImmRef(___nl__3);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__3,___nl__16,___nl__14);
___nl__3 = ___ref______nl__3.getValue();

//line 156
___nl__16 = null;
//line 156
___nl__13 = null;
//line 156
___nl__14 = null;
//line 156
___nl__15 = null;
//line 157
___nl__14 = ((ImmHash)___nl__8).getHashValue()["name"];
//line 157
___nl__13 = hash_NL.NL_has_key(___nl__6,___nl__14);

//line 157
___nl__14 = null;
//line 157
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13));
//line 157
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_25;}}
//line 157
___nl__14 = new ImmString("errors");
//line 157
___nl__14 = c_rt_lib_NL.NL_get_ref_hash(___nl__3,___nl__14);

//line 157
___nl__15 = new ImmString("multiple use module:");
//line 157
___nl__16 = ((ImmHash)___nl__8).getHashValue()["name"];
//line 157
___nl__15 = new ImmString(___nl__15.toString() + ___nl__16.toString());
//line 157
___nl__16 = null;
//line 157
___ref______nl__14 = new ImmRef(___nl__14);
module_checker_NL.NL_add_warning_priv(___ref______nl__14,___nl__15);
___nl__14 = ___ref______nl__14.getValue();

//line 157
___nl__15 = null;
//line 157
___nl__15 = new ImmString("errors");
//line 157
___ref______nl__3 = new ImmRef(___nl__3);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__3,___nl__15,___nl__14);
___nl__3 = ___ref______nl__3.getValue();

//line 157
___nl__15 = null;
//line 157
___nl__14 = null;
//line 157
if (true) {goto label_25;}
//line 157
label_25:
//line 157
___nl__13 = null;
//line 159
___nl__14 = ((ImmHash)___nl__3).getHashValue()["called"];
//line 159
___nl__14 = ((ImmHash)___nl__14).getHashValue()["module"];
//line 159
___nl__15 = ((ImmHash)___nl__8).getHashValue()["name"];
//line 159
___nl__13 = hash_NL.NL_has_key(___nl__14,___nl__15);

//line 159
___nl__15 = null;
//line 159
___nl__14 = null;
//line 159
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13));
//line 159
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13));
//line 159
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_27;}}
//line 159
___nl__14 = new ImmString("errors");
//line 159
___nl__14 = c_rt_lib_NL.NL_get_ref_hash(___nl__3,___nl__14);

//line 159
___nl__15 = new ImmString("unused module:");
//line 159
___nl__16 = ((ImmHash)___nl__8).getHashValue()["name"];
//line 159
___nl__15 = new ImmString(___nl__15.toString() + ___nl__16.toString());
//line 159
___nl__16 = null;
//line 159
___ref______nl__14 = new ImmRef(___nl__14);
module_checker_NL.NL_add_warning_priv(___ref______nl__14,___nl__15);
___nl__14 = ___ref______nl__14.getValue();

//line 159
___nl__15 = null;
//line 159
___nl__15 = new ImmString("errors");
//line 159
___ref______nl__3 = new ImmRef(___nl__3);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__3,___nl__15,___nl__14);
___nl__3 = ___ref______nl__3.getValue();

//line 159
___nl__15 = null;
//line 159
___nl__14 = null;
//line 159
if (true) {goto label_27;}
//line 159
label_27:
//line 159
___nl__13 = null;
//line 161
___nl__13 = ((ImmHash)___nl__8).getHashValue()["name"];
//line 161
___nl__14 = c_rt_lib_NL.NL_get_true();
//line 161
___ref______nl__6 = new ImmRef(___nl__6);
hash_NL.NL_set_value(___ref______nl__6,___nl__13,___nl__14);
___nl__6 = ___ref______nl__6.getValue();

//line 161
___nl__14 = null;
//line 161
___nl__13 = null;
//line 162
___nl__9 = new ImmDouble((Double.Parse(___nl__9.getValue().ToString()))+(Double.Parse(___nl__10.getValue().ToString())));
//line 162
if (true) {goto label_23;}
//line 162
label_21:
//line 162
___nl__7 = null;
//line 162
___nl__8 = null;
//line 162
___nl__9 = null;
//line 162
___nl__10 = null;
//line 162
___nl__11 = null;
//line 162
___nl__12 = null;
//line 163
___nl__7 = ((ImmHash)___nl__3).getHashValue()["called"];
//line 163
___nl__7 = ((ImmHash)___nl__7).getHashValue()["module"];
//line 163
___nl__10 = c_rt_lib_NL.NL_init_iter(___nl__7);

//line 163
label_30:
//line 163
___nl__8 = c_rt_lib_NL.NL_is_end_hash(___nl__10);

//line 163
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_28;}}
//line 163
___nl__8 = c_rt_lib_NL.NL_get_key_iter(___nl__10);

//line 163
___nl__9 = c_rt_lib_NL.NL_hash_get_value(___nl__7,___nl__8);

//line 164
___nl__11 = new ImmString("errors");
//line 164
___nl__11 = c_rt_lib_NL.NL_get_ref_hash(___nl__3,___nl__11);

//line 164
___nl__12 = ___nl__9;
//line 164
((ImmHash)___nl__11).set("current_line", ___nl__12);
//line 164
___nl__13 = new ImmString("errors");
//line 164
___ref______nl__3 = new ImmRef(___nl__3);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__3,___nl__13,___nl__11);
___nl__3 = ___ref______nl__3.getValue();

//line 164
___nl__13 = null;
//line 164
___nl__11 = null;
//line 164
___nl__12 = null;
//line 165
___nl__11 = ((ImmHash)___nl__0).getHashValue()["name"];
//line 165
___nl__11 = c_rt_lib_NL.NL_native_to_nl(___nl__11.toString().Equals(___nl__8.toString()));
//line 165
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11));
//line 165
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_32;}}
//line 165
___nl__11 = null;
//line 165
if (true) {goto label_29;}
//line 165
if (true) {goto label_32;}
//line 165
label_32:
//line 165
___nl__11 = null;
//line 166
___nl__11 = hash_NL.NL_has_key(___nl__6,___nl__8);

//line 166
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11));
//line 166
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11));
//line 166
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_34;}}
//line 166
___nl__12 = new ImmString("errors");
//line 166
___nl__12 = c_rt_lib_NL.NL_get_ref_hash(___nl__3,___nl__12);

//line 166
___nl__13 = new ImmString("module '");
//line 166
___nl__13 = new ImmString(___nl__13.toString() + ___nl__8.toString());
//line 166
___nl__14 = new ImmString("' not imported");
//line 166
___nl__13 = new ImmString(___nl__13.toString() + ___nl__14.toString());
//line 166
___nl__14 = null;
//line 166
___ref______nl__12 = new ImmRef(___nl__12);
module_checker_NL.NL_add_error_priv(___ref______nl__12,___nl__13);
___nl__12 = ___ref______nl__12.getValue();

//line 166
___nl__13 = null;
//line 166
___nl__13 = new ImmString("errors");
//line 166
___ref______nl__3 = new ImmRef(___nl__3);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__3,___nl__13,___nl__12);
___nl__3 = ___ref______nl__3.getValue();

//line 166
___nl__13 = null;
//line 166
___nl__12 = null;
//line 166
if (true) {goto label_34;}
//line 166
label_34:
//line 166
___nl__11 = null;
//line 166
label_29:
//line 168
___nl__10 = c_rt_lib_NL.NL_next_iter(___nl__10);

//line 168
if (true) {goto label_30;}
//line 168
label_28:
//line 168
___nl__7 = null;
//line 168
___nl__8 = null;
//line 168
___nl__9 = null;
//line 168
___nl__10 = null;
//line 169
___nl__7 = ___nl__5;
//line 170
___nl__10 = c_rt_lib_NL.NL_init_iter(___nl__7);

//line 170
label_37:
//line 170
___nl__8 = c_rt_lib_NL.NL_is_end_hash(___nl__10);

//line 170
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_35;}}
//line 170
___nl__8 = c_rt_lib_NL.NL_get_key_iter(___nl__10);

//line 170
___nl__9 = c_rt_lib_NL.NL_hash_get_value(___nl__7,___nl__8);

//line 171
___ref______nl__5 = new ImmRef(___nl__5);
module_checker_NL.NL_set_used_function_priv(___nl__8,___nl__4,___ref______nl__5);
___nl__5 = ___ref______nl__5.getValue();

//line 172
___nl__10 = c_rt_lib_NL.NL_next_iter(___nl__10);

//line 172
if (true) {goto label_37;}
//line 172
label_35:
//line 172
___nl__8 = null;
//line 172
___nl__9 = null;
//line 172
___nl__10 = null;
//line 173
___nl__8 = ((ImmHash)___nl__0).getHashValue()["fun_def"];
//line 173
___nl__10 = new ImmDouble(0);
//line 173
___nl__11 = new ImmDouble(1);
//line 173
___nl__12 = c_rt_lib_NL.NL_array_len(___nl__8);

//line 173
label_40:
//line 173
___nl__13 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__10.getValue().ToString()))>=(Double.Parse(___nl__12.getValue().ToString())) );
//line 173
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_38;}}
//line 173
___nl__9 = (___nl__8 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()];
//line 174
___nl__14 = ((ImmHash)___nl__9).getHashValue()["access"];
//line 174
___nl__14 = c_rt_lib_NL.NL_ov_is(___nl__14, new ImmString("pub"));
//line 174
___nl__14 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__14));
//line 174
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_42;}}
//line 174
___nl__14 = null;
//line 174
if (true) {goto label_39;}
//line 174
if (true) {goto label_42;}
//line 174
label_42:
//line 174
___nl__14 = null;
//line 175
___nl__15 = new ImmString("priv:");
//line 175
___nl__16 = ((ImmHash)___nl__0).getHashValue()["name"];
//line 175
___nl__15 = new ImmString(___nl__15.toString() + ___nl__16.toString());
//line 175
___nl__16 = null;
//line 175
___nl__16 = new ImmString("::");
//line 175
___nl__15 = new ImmString(___nl__15.toString() + ___nl__16.toString());
//line 175
___nl__16 = null;
//line 175
___nl__16 = ((ImmHash)___nl__9).getHashValue()["name"];
//line 175
___nl__15 = new ImmString(___nl__15.toString() + ___nl__16.toString());
//line 175
___nl__16 = null;
//line 175
___nl__14 = hash_NL.NL_has_key(___nl__5,___nl__15);

//line 175
___nl__15 = null;
//line 175
___nl__14 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__14));
//line 175
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_44;}}
//line 175
___nl__14 = null;
//line 175
if (true) {goto label_39;}
//line 175
if (true) {goto label_44;}
//line 175
label_44:
//line 175
___nl__14 = null;
//line 176
___nl__14 = ((ImmHash)___nl__9).getHashValue()["line"];
//line 176
___nl__15 = new ImmString("errors");
//line 176
___nl__15 = c_rt_lib_NL.NL_get_ref_hash(___nl__3,___nl__15);

//line 176
___nl__16 = ___nl__14;
//line 176
((ImmHash)___nl__15).set("current_line", ___nl__16);
//line 176
___nl__17 = new ImmString("errors");
//line 176
___ref______nl__3 = new ImmRef(___nl__3);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__3,___nl__17,___nl__15);
___nl__3 = ___ref______nl__3.getValue();

//line 176
___nl__17 = null;
//line 176
___nl__14 = null;
//line 176
___nl__15 = null;
//line 176
___nl__16 = null;
//line 177
___nl__14 = new ImmString("errors");
//line 177
___nl__14 = c_rt_lib_NL.NL_get_ref_hash(___nl__3,___nl__14);

//line 177
___nl__15 = new ImmString("unused function: ");
//line 177
___nl__16 = ((ImmHash)___nl__0).getHashValue()["name"];
//line 177
___nl__15 = new ImmString(___nl__15.toString() + ___nl__16.toString());
//line 177
___nl__16 = null;
//line 177
___nl__16 = new ImmString("_priv::");
//line 177
___nl__15 = new ImmString(___nl__15.toString() + ___nl__16.toString());
//line 177
___nl__16 = null;
//line 177
___nl__16 = ((ImmHash)___nl__9).getHashValue()["name"];
//line 177
___nl__15 = new ImmString(___nl__15.toString() + ___nl__16.toString());
//line 177
___nl__16 = null;
//line 177
___ref______nl__14 = new ImmRef(___nl__14);
module_checker_NL.NL_add_warning_priv(___ref______nl__14,___nl__15);
___nl__14 = ___ref______nl__14.getValue();

//line 177
___nl__15 = null;
//line 177
___nl__15 = new ImmString("errors");
//line 177
___ref______nl__3 = new ImmRef(___nl__3);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__3,___nl__15,___nl__14);
___nl__3 = ___ref______nl__3.getValue();

//line 177
___nl__15 = null;
//line 177
___nl__14 = null;
//line 177
label_39:
//line 178
___nl__10 = new ImmDouble((Double.Parse(___nl__10.getValue().ToString()))+(Double.Parse(___nl__11.getValue().ToString())));
//line 178
if (true) {goto label_40;}
//line 178
label_38:
//line 178
___nl__8 = null;
//line 178
___nl__9 = null;
//line 178
___nl__10 = null;
//line 178
___nl__11 = null;
//line 178
___nl__12 = null;
//line 178
___nl__13 = null;
//line 179
___nl__8 = ((ImmHash)___nl__3).getHashValue()["errors"];
//line 179
___nl__0 = null;
//line 179
___nl__1 = null;
//line 179
___nl__2 = null;
//line 179
___nl__3 = null;
//line 179
___nl__4 = null;
//line 179
___nl__5 = null;
//line 179
___nl__6 = null;
//line 179
___nl__7 = null;
//line 179
if(true) return ___nl__8;
//line 179
___nl__8 = null;
//line 179
___nl__1 = null;
//line 179
___nl__2 = null;
//line 179
___nl__3 = null;
//line 179
___nl__4 = null;
//line 179
___nl__5 = null;
//line 179
___nl__6 = null;
//line 179
___nl__7 = null;
//line 179
___nl__0 = null;
//line 179
if(true) return null;
}

private static Imm NL_check_types_imported_priv(Imm ___arg__0, ImmRef ___arg__1) {
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
//line 182
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_im"));
//line 182
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 183
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_arr"));
//line 183
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_3;}}
//line 185
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_hash"));
//line 185
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_4;}}
//line 187
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_rec"));
//line 187
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_5;}}
//line 191
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_ref"));
//line 191
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_6;}}
//line 200
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_void"));
//line 200
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_7;}}
//line 201
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_sim"));
//line 201
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_8;}}
//line 202
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_var"));
//line 202
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_9;}}
//line 209
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("tct_empty"));
//line 209
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_10;}}
//line 209
___nl__2 = new ImmString("NOMATCHALERT");
//line 209
___nl__2 = new ImmArray(new Imm[] {___nl__2,___nl__0,});
//line 209
c_rt_lib_NL.NL_die();
//line 182
label_2:
//line 183
if (true) {goto label_1;}
//line 183
label_3:
//line 183
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("tct_arr"));
//line 184
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_types_imported_priv(___nl__3,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 184
___nl__3 = null;
//line 185
if (true) {goto label_1;}
//line 185
label_4:
//line 185
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("tct_hash"));
//line 186
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_types_imported_priv(___nl__3,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 186
___nl__3 = null;
//line 187
if (true) {goto label_1;}
//line 187
label_5:
//line 187
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("tct_rec"));
//line 188
___nl__6 = c_rt_lib_NL.NL_init_iter(___nl__3);

//line 188
label_13:
//line 188
___nl__4 = c_rt_lib_NL.NL_is_end_hash(___nl__6);

//line 188
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_11;}}
//line 188
___nl__4 = c_rt_lib_NL.NL_get_key_iter(___nl__6);

//line 188
___nl__5 = c_rt_lib_NL.NL_hash_get_value(___nl__3,___nl__4);

//line 189
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_types_imported_priv(___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 190
___nl__6 = c_rt_lib_NL.NL_next_iter(___nl__6);

//line 190
if (true) {goto label_13;}
//line 190
label_11:
//line 190
___nl__4 = null;
//line 190
___nl__5 = null;
//line 190
___nl__6 = null;
//line 190
___nl__3 = null;
//line 191
if (true) {goto label_1;}
//line 191
label_6:
//line 191
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("tct_ref"));
//line 192
___nl__5 = new ImmString("::");
//line 192
___nl__4 = string_NL.NL_index2(___nl__3,___nl__5);

//line 192
___nl__5 = null;
//line 193
___nl__5 = new ImmDouble(0);
//line 193
___nl__5 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__5.getValue().ToString())) );
//line 193
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 193
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_15;}}
//line 194
___nl__7 = new ImmDouble(0);
//line 194
___nl__6 = string_NL.NL_substr(___nl__3,___nl__7,___nl__4);

//line 194
___nl__7 = null;
//line 195
___nl__8 = new ImmDouble(2);
//line 195
___nl__8 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString())));
//line 195
___nl__9 = string_NL.NL_length(___nl__3);

//line 195
___nl__9 = new ImmDouble((Double.Parse(___nl__9.getValue().ToString()))-(Double.Parse(___nl__4.getValue().ToString())));
//line 195
___nl__10 = new ImmDouble(2);
//line 195
___nl__9 = new ImmDouble((Double.Parse(___nl__9.getValue().ToString()))-(Double.Parse(___nl__10.getValue().ToString())));
//line 195
___nl__10 = null;
//line 195
___nl__7 = string_NL.NL_substr(___nl__3,___nl__8,___nl__9);

//line 195
___nl__9 = null;
//line 195
___nl__8 = null;
//line 196
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_add_fun_used_priv(___nl__6,___nl__7,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 196
___nl__6 = null;
//line 196
___nl__7 = null;
//line 197
if (true) {goto label_14;}
//line 197
label_15:
//line 198
___nl__6 = new ImmString("errors");
//line 198
___nl__6 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__6);

//line 198
___nl__7 = new ImmString("wrong type function name '");
//line 198
___nl__7 = new ImmString(___nl__7.toString() + ___nl__3.toString());
//line 198
___nl__8 = new ImmString("' ");
//line 198
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 198
___nl__8 = null;
//line 198
___ref______nl__6 = new ImmRef(___nl__6);
module_checker_NL.NL_add_error_priv(___ref______nl__6,___nl__7);
___nl__6 = ___ref______nl__6.getValue();

//line 198
___nl__7 = null;
//line 198
___nl__7 = new ImmString("errors");
//line 198
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__7,___nl__6);
___nl__1 = ___ref______nl__1.getValue();

//line 198
___nl__7 = null;
//line 198
___nl__6 = null;
//line 199
if (true) {goto label_14;}
//line 199
label_14:
//line 199
___nl__5 = null;
//line 199
___nl__4 = null;
//line 199
___nl__3 = null;
//line 200
if (true) {goto label_1;}
//line 200
label_7:
//line 201
if (true) {goto label_1;}
//line 201
label_8:
//line 202
if (true) {goto label_1;}
//line 202
label_9:
//line 202
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("tct_var"));
//line 203
___nl__6 = c_rt_lib_NL.NL_init_iter(___nl__3);

//line 203
label_18:
//line 203
___nl__4 = c_rt_lib_NL.NL_is_end_hash(___nl__6);

//line 203
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_16;}}
//line 203
___nl__4 = c_rt_lib_NL.NL_get_key_iter(___nl__6);

//line 203
___nl__5 = c_rt_lib_NL.NL_hash_get_value(___nl__3,___nl__4);

//line 204
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("no_param"));
//line 204
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_20;}}
//line 205
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("with_param"));
//line 205
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_21;}}
//line 205
___nl__7 = new ImmString("NOMATCHALERT");
//line 205
___nl__7 = new ImmArray(new Imm[] {___nl__7,___nl__5,});
//line 205
c_rt_lib_NL.NL_die();
//line 204
label_20:
//line 205
if (true) {goto label_19;}
//line 205
label_21:
//line 205
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("with_param"));
//line 206
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_types_imported_priv(___nl__8,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 206
___nl__8 = null;
//line 207
if (true) {goto label_19;}
//line 207
label_19:
//line 207
___nl__7 = null;
//line 208
___nl__6 = c_rt_lib_NL.NL_next_iter(___nl__6);

//line 208
if (true) {goto label_18;}
//line 208
label_16:
//line 208
___nl__4 = null;
//line 208
___nl__5 = null;
//line 208
___nl__6 = null;
//line 208
___nl__3 = null;
//line 209
if (true) {goto label_1;}
//line 209
label_10:
//line 210
if (true) {goto label_1;}
//line 210
label_1:
//line 210
___nl__2 = null;
//line 210
___nl__0 = null;
//line 210
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_get_fun_key_priv(Imm ___arg__0, Imm ___arg__1, Imm ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();
Imm ___nl__3 = null;
Imm ___nl__4 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 214
___nl__3 = new ImmString("");
//line 214
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__3.toString()));
//line 214
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 214
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 214
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 214
___nl__4 = new ImmString("::");
//line 214
___nl__4 = new ImmString(___nl__0.toString() + ___nl__4.toString());
//line 214
___nl__4 = new ImmString(___nl__4.toString() + ___nl__1.toString());
//line 214
___nl__0 = null;
//line 214
___nl__1 = null;
//line 214
___nl__2 = null;
//line 214
___nl__3 = null;
//line 214
if(true) return ___nl__4;
//line 214
___nl__4 = null;
//line 214
if (true) {goto label_2;}
//line 214
label_2:
//line 214
___nl__3 = null;
//line 215
___nl__3 = new ImmString("priv:");
//line 215
___nl__3 = new ImmString(___nl__3.toString() + ___nl__2.toString());
//line 215
___nl__4 = new ImmString("::");
//line 215
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 215
___nl__4 = null;
//line 215
___nl__3 = new ImmString(___nl__3.toString() + ___nl__1.toString());
//line 215
___nl__0 = null;
//line 215
___nl__1 = null;
//line 215
___nl__2 = null;
//line 215
if(true) return ___nl__3;
//line 215
___nl__3 = null;
//line 215
___nl__0 = null;
//line 215
___nl__1 = null;
//line 215
___nl__2 = null;
//line 215
if(true) return null;
}

private static Imm NL_add_fun_used_priv(Imm ___arg__0, Imm ___arg__1, ImmRef ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.getValue().clone();
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
//line 219
___nl__4 = ((ImmHash)___nl__2).getHashValue()["current_module"];
//line 219
___nl__3 = module_checker_NL.NL_get_fun_key_priv(___nl__0,___nl__1,___nl__4);

//line 219
___nl__4 = null;
//line 220
___nl__5 = ((ImmHash)___nl__2).getHashValue()["called"];
//line 220
___nl__5 = ((ImmHash)___nl__5).getHashValue()["func"];
//line 220
___nl__4 = hash_NL.NL_has_key(___nl__5,___nl__3);

//line 220
___nl__5 = null;
//line 220
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 220
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 220
___nl__0 = null;
//line 220
___nl__1 = null;
//line 220
___nl__3 = null;
//line 220
___nl__4 = null;
//line 220
___arg__2.setValue(___nl__2);if(true) return null;
//line 220
if (true) {goto label_2;}
//line 220
label_2:
//line 220
___nl__4 = null;
//line 221
___nl__4 = new ImmString("called");
//line 221
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__2,___nl__4);

//line 221
___nl__5 = new ImmString("func");
//line 221
___nl__5 = c_rt_lib_NL.NL_get_ref_hash(___nl__4,___nl__5);

//line 221
___nl__6 = ((ImmHash)___nl__2).getHashValue()["errors"];
//line 221
___nl__6 = ((ImmHash)___nl__6).getHashValue()["current_line"];
//line 221
___ref______nl__5 = new ImmRef(___nl__5);
hash_NL.NL_set_value(___ref______nl__5,___nl__3,___nl__6);
___nl__5 = ___ref______nl__5.getValue();

//line 221
___nl__6 = null;
//line 221
___nl__6 = new ImmString("func");
//line 221
___ref______nl__4 = new ImmRef(___nl__4);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__4,___nl__6,___nl__5);
___nl__4 = ___ref______nl__4.getValue();

//line 221
___nl__6 = new ImmString("called");
//line 221
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__2,___nl__6,___nl__4);
___nl__2 = ___ref______nl__2.getValue();

//line 221
___nl__6 = null;
//line 221
___nl__4 = null;
//line 221
___nl__5 = null;
//line 222
___nl__4 = new ImmString("");
//line 222
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__4.toString()));
//line 222
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_5;}}
//line 222
___nl__5 = ((ImmHash)___nl__2).getHashValue()["called"];
//line 222
___nl__5 = ((ImmHash)___nl__5).getHashValue()["module"];
//line 222
___nl__4 = hash_NL.NL_has_key(___nl__5,___nl__0);

//line 222
___nl__5 = null;
//line 222
label_5:
//line 222
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 222
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_4;}}
//line 222
___nl__0 = null;
//line 222
___nl__1 = null;
//line 222
___nl__3 = null;
//line 222
___nl__4 = null;
//line 222
___arg__2.setValue(___nl__2);if(true) return null;
//line 222
if (true) {goto label_4;}
//line 222
label_4:
//line 222
___nl__4 = null;
//line 223
___nl__4 = new ImmString("called");
//line 223
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__2,___nl__4);

//line 223
___nl__5 = new ImmString("module");
//line 223
___nl__5 = c_rt_lib_NL.NL_get_ref_hash(___nl__4,___nl__5);

//line 223
___nl__6 = ((ImmHash)___nl__2).getHashValue()["errors"];
//line 223
___nl__6 = ((ImmHash)___nl__6).getHashValue()["current_line"];
//line 223
___ref______nl__5 = new ImmRef(___nl__5);
hash_NL.NL_set_value(___ref______nl__5,___nl__0,___nl__6);
___nl__5 = ___ref______nl__5.getValue();

//line 223
___nl__6 = null;
//line 223
___nl__6 = new ImmString("module");
//line 223
___ref______nl__4 = new ImmRef(___nl__4);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__4,___nl__6,___nl__5);
___nl__4 = ___ref______nl__4.getValue();

//line 223
___nl__6 = new ImmString("called");
//line 223
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__2,___nl__6,___nl__4);
___nl__2 = ___ref______nl__2.getValue();

//line 223
___nl__6 = null;
//line 223
___nl__4 = null;
//line 223
___nl__5 = null;
//line 223
___nl__3 = null;
//line 223
___nl__0 = null;
//line 223
___nl__1 = null;
//line 223
___arg__2.setValue(___nl__2);if(true) return null;
}

private static Imm NL_check_return_type_priv(Imm ___arg__0, ImmRef ___arg__1) {
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
//line 227
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("none"));
//line 227
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 229
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("type"));
//line 229
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_3;}}
//line 229
___nl__2 = new ImmString("NOMATCHALERT");
//line 229
___nl__2 = new ImmArray(new Imm[] {___nl__2,___nl__0,});
//line 229
c_rt_lib_NL.NL_die();
//line 227
label_2:
//line 228
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none"));
//line 228
___nl__0 = null;
//line 228
___nl__2 = null;
//line 228
___arg__1.setValue(___nl__1);if(true) return ___nl__3;
//line 228
___nl__3 = null;
//line 229
if (true) {goto label_1;}
//line 229
label_3:
//line 229
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("type"));
//line 230
___nl__4 = ___nl__3;
//line 230
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("fun_val"));
//line 230
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 230
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_5;}}
//line 231
___nl__5 = ___nl__3;
//line 231
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("fun_val"));
//line 232
___nl__6 = ((ImmHash)___nl__5).getHashValue()["module"];
//line 232
___nl__8 = new ImmString("ptd");
//line 232
___nl__6 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__8.toString()));
//line 232
___nl__8 = null;
//line 232
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 232
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_8;}}
//line 232
___nl__6 = ((ImmHash)___nl__5).getHashValue()["name"];
//line 232
___nl__8 = new ImmString("void");
//line 232
___nl__6 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__8.toString()));
//line 232
___nl__8 = null;
//line 232
label_8:
//line 232
___nl__7 = null;
//line 232
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 232
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_7;}}
//line 233
___nl__7 = new ImmString("ptd");
//line 233
___nl__8 = new ImmString("void");
//line 233
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_add_fun_used_priv(___nl__7,___nl__8,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 233
___nl__8 = null;
//line 233
___nl__7 = null;
//line 234
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("void"));
//line 234
___nl__0 = null;
//line 234
___nl__2 = null;
//line 234
___nl__3 = null;
//line 234
___nl__4 = null;
//line 234
___nl__5 = null;
//line 234
___nl__6 = null;
//line 234
___arg__1.setValue(___nl__1);if(true) return ___nl__7;
//line 234
___nl__7 = null;
//line 235
if (true) {goto label_7;}
//line 235
label_7:
//line 235
___nl__6 = null;
//line 235
___nl__5 = null;
//line 236
if (true) {goto label_5;}
//line 236
label_5:
//line 236
___nl__4 = null;
//line 236
___nl__3 = null;
//line 237
if (true) {goto label_1;}
//line 237
label_1:
//line 237
___nl__2 = null;
//line 238
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_type_priv(___nl__0,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 239
___nl__2 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("value"));
//line 239
___nl__0 = null;
//line 239
___arg__1.setValue(___nl__1);if(true) return ___nl__2;
//line 239
___nl__2 = null;
//line 239
___nl__0 = null;
//line 239
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_check_type_priv(Imm ___arg__0, ImmRef ___arg__1) {
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
//line 242
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("none"));
//line 242
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 243
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("type"));
//line 243
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_3;}}
//line 243
___nl__2 = new ImmString("NOMATCHALERT");
//line 243
___nl__2 = new ImmArray(new Imm[] {___nl__2,___nl__0,});
//line 243
c_rt_lib_NL.NL_die();
//line 242
label_2:
//line 243
if (true) {goto label_1;}
//line 243
label_3:
//line 243
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("type"));
//line 244
___nl__4 = ___nl__3;
//line 244
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("fun_val"));
//line 244
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 244
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_5;}}
//line 245
___nl__5 = ___nl__3;
//line 245
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("fun_val"));
//line 246
___nl__6 = ((ImmHash)___nl__5).getHashValue()["module"];
//line 246
___nl__7 = ((ImmHash)___nl__5).getHashValue()["name"];
//line 246
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_add_fun_used_priv(___nl__6,___nl__7,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 246
___nl__7 = null;
//line 246
___nl__6 = null;
//line 246
___nl__5 = null;
//line 247
if (true) {goto label_5;}
//line 247
label_5:
//line 247
___nl__4 = null;
//line 248
___nl__4 = ptd_parser_NL.NL_try_value_to_ptd(___nl__3);

//line 248
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("err"));
//line 248
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_7;}}
//line 250
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("ok"));
//line 250
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_8;}}
//line 250
___nl__5 = new ImmString("NOMATCHALERT");
//line 250
___nl__5 = new ImmArray(new Imm[] {___nl__5,___nl__4,});
//line 250
c_rt_lib_NL.NL_die();
//line 248
label_7:
//line 248
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("err"));
//line 249
___nl__7 = new ImmString("errors");
//line 249
___nl__7 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__7);

//line 249
___ref______nl__7 = new ImmRef(___nl__7);
module_checker_NL.NL_add_error_priv(___ref______nl__7,___nl__6);
___nl__7 = ___ref______nl__7.getValue();

//line 249
___nl__8 = new ImmString("errors");
//line 249
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__8,___nl__7);
___nl__1 = ___ref______nl__1.getValue();

//line 249
___nl__8 = null;
//line 249
___nl__7 = null;
//line 249
___nl__6 = null;
//line 250
if (true) {goto label_6;}
//line 250
label_8:
//line 250
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("ok"));
//line 251
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_types_imported_priv(___nl__6,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 251
___nl__6 = null;
//line 252
if (true) {goto label_6;}
//line 252
label_6:
//line 252
___nl__4 = null;
//line 252
___nl__5 = null;
//line 252
___nl__3 = null;
//line 253
if (true) {goto label_1;}
//line 253
label_1:
//line 253
___nl__2 = null;
//line 253
___nl__0 = null;
//line 253
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_add_var_priv(Imm ___arg__0, Imm ___arg__1, Imm ___arg__2, ImmRef ___arg__3) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();Imm ___nl__3 = ___arg__3.getValue().clone();
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
//line 257
___nl__5 = ((ImmHash)___nl__3).getHashValue()["vars"];
//line 257
___nl__4 = hash_NL.NL_has_key(___nl__5,___nl__0);

//line 257
___nl__5 = null;
//line 257
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 257
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 258
___nl__5 = new ImmString("errors");
//line 258
___nl__5 = c_rt_lib_NL.NL_get_ref_hash(___nl__3,___nl__5);

//line 258
___nl__6 = new ImmString("redeclaration variable: ");
//line 258
___nl__6 = new ImmString(___nl__6.toString() + ___nl__0.toString());
//line 258
___ref______nl__5 = new ImmRef(___nl__5);
module_checker_NL.NL_add_error_priv(___ref______nl__5,___nl__6);
___nl__5 = ___ref______nl__5.getValue();

//line 258
___nl__6 = null;
//line 258
___nl__6 = new ImmString("errors");
//line 258
___ref______nl__3 = new ImmRef(___nl__3);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__3,___nl__6,___nl__5);
___nl__3 = ___ref______nl__3.getValue();

//line 258
___nl__6 = null;
//line 258
___nl__5 = null;
//line 259
if (true) {goto label_2;}
//line 259
label_2:
//line 259
___nl__4 = null;
//line 260
___nl__5 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none"));
//line 260
___nl__6 = c_rt_lib_NL.NL_get_false();
//line 260
__function_map = new Dictionary<String, Imm>();
__function_map.Add("write",___nl__5);
__function_map.Add("read",___nl__6);
__function_map.Add("is_required",___nl__2);
___nl__4 = new ImmHash(__function_map);
//line 260
___nl__5 = null;
//line 260
___nl__6 = null;
//line 261
___nl__5 = ___nl__1;
//line 261
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 261
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_4;}}
//line 261
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("const"));
//line 261
___nl__7 = ___nl__6;
//line 261
((ImmHash)___nl__4).set("write", ___nl__7);
//line 261
___nl__6 = null;
//line 261
___nl__7 = null;
//line 261
if (true) {goto label_4;}
//line 261
label_4:
//line 261
___nl__5 = null;
//line 262
___nl__5 = new ImmString("vars");
//line 262
___nl__5 = c_rt_lib_NL.NL_get_ref_hash(___nl__3,___nl__5);

//line 262
___ref______nl__5 = new ImmRef(___nl__5);
hash_NL.NL_set_value(___ref______nl__5,___nl__0,___nl__4);
___nl__5 = ___ref______nl__5.getValue();

//line 262
___nl__6 = new ImmString("vars");
//line 262
___ref______nl__3 = new ImmRef(___nl__3);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__3,___nl__6,___nl__5);
___nl__3 = ___ref______nl__3.getValue();

//line 262
___nl__6 = null;
//line 262
___nl__5 = null;
//line 262
___nl__4 = null;
//line 262
___nl__0 = null;
//line 262
___nl__1 = null;
//line 262
___nl__2 = null;
//line 262
___arg__3.setValue(___nl__3);if(true) return null;
}

private static Imm NL_use_var_priv(Imm ___arg__0, Imm ___arg__1, ImmRef ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.getValue().clone();
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
//line 265
___nl__4 = ((ImmHash)___nl__2).getHashValue()["vars"];
//line 265
___nl__3 = hash_NL.NL_has_key(___nl__4,___nl__0);

//line 265
___nl__4 = null;
//line 265
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 265
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 265
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 266
___nl__4 = new ImmString("errors");
//line 266
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__2,___nl__4);

//line 266
___nl__5 = new ImmString("unknown variable: ");
//line 266
___nl__5 = new ImmString(___nl__5.toString() + ___nl__0.toString());
//line 266
___ref______nl__4 = new ImmRef(___nl__4);
module_checker_NL.NL_add_error_priv(___ref______nl__4,___nl__5);
___nl__4 = ___ref______nl__4.getValue();

//line 266
___nl__5 = null;
//line 266
___nl__5 = new ImmString("errors");
//line 266
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__2,___nl__5,___nl__4);
___nl__2 = ___ref______nl__2.getValue();

//line 266
___nl__5 = null;
//line 266
___nl__4 = null;
//line 267
___nl__0 = null;
//line 267
___nl__1 = null;
//line 267
___nl__3 = null;
//line 267
___arg__2.setValue(___nl__2);if(true) return null;
//line 268
if (true) {goto label_2;}
//line 268
label_2:
//line 268
___nl__3 = null;
//line 269
___nl__4 = ((ImmHash)___nl__2).getHashValue()["vars"];
//line 269
___nl__3 = hash_NL.NL_get_value(___nl__4,___nl__0);

//line 269
___nl__4 = null;
//line 270
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("get"));
//line 270
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_4;}}
//line 272
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("set"));
//line 272
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_5;}}
//line 278
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("mod"));
//line 278
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_6;}}
//line 278
___nl__4 = new ImmString("NOMATCHALERT");
//line 278
___nl__4 = new ImmArray(new Imm[] {___nl__4,___nl__1,});
//line 278
c_rt_lib_NL.NL_die();
//line 270
label_4:
//line 271
___nl__5 = c_rt_lib_NL.NL_get_true();
//line 271
___nl__6 = ___nl__5;
//line 271
((ImmHash)___nl__3).set("read", ___nl__6);
//line 271
___nl__5 = null;
//line 271
___nl__6 = null;
//line 272
if (true) {goto label_3;}
//line 272
label_5:
//line 273
___nl__5 = ((ImmHash)___nl__3).getHashValue()["write"];
//line 273
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("const"));
//line 273
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 273
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_8;}}
//line 274
___nl__6 = new ImmString("errors");
//line 274
___nl__6 = c_rt_lib_NL.NL_get_ref_hash(___nl__2,___nl__6);

//line 274
___nl__7 = new ImmString("can't change const variable: ");
//line 274
___nl__7 = new ImmString(___nl__7.toString() + ___nl__0.toString());
//line 274
___ref______nl__6 = new ImmRef(___nl__6);
module_checker_NL.NL_add_error_priv(___ref______nl__6,___nl__7);
___nl__6 = ___ref______nl__6.getValue();

//line 274
___nl__7 = null;
//line 274
___nl__7 = new ImmString("errors");
//line 274
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__2,___nl__7,___nl__6);
___nl__2 = ___ref______nl__2.getValue();

//line 274
___nl__7 = null;
//line 274
___nl__6 = null;
//line 275
___nl__0 = null;
//line 275
___nl__1 = null;
//line 275
___nl__3 = null;
//line 275
___nl__4 = null;
//line 275
___nl__5 = null;
//line 275
___arg__2.setValue(___nl__2);if(true) return null;
//line 276
if (true) {goto label_8;}
//line 276
label_8:
//line 276
___nl__5 = null;
//line 277
___nl__5 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("value"));
//line 277
___nl__6 = ___nl__5;
//line 277
((ImmHash)___nl__3).set("write", ___nl__6);
//line 277
___nl__5 = null;
//line 277
___nl__6 = null;
//line 278
if (true) {goto label_3;}
//line 278
label_6:
//line 279
___nl__5 = c_rt_lib_NL.NL_get_true();
//line 279
___nl__6 = ___nl__5;
//line 279
((ImmHash)___nl__3).set("read", ___nl__6);
//line 279
___nl__5 = null;
//line 279
___nl__6 = null;
//line 280
___nl__5 = ((ImmHash)___nl__3).getHashValue()["write"];
//line 280
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("const"));
//line 280
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 280
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_10;}}
//line 281
___nl__6 = new ImmString("errors");
//line 281
___nl__6 = c_rt_lib_NL.NL_get_ref_hash(___nl__2,___nl__6);

//line 281
___nl__7 = new ImmString("can't change const variable: ");
//line 281
___nl__7 = new ImmString(___nl__7.toString() + ___nl__0.toString());
//line 281
___ref______nl__6 = new ImmRef(___nl__6);
module_checker_NL.NL_add_error_priv(___ref______nl__6,___nl__7);
___nl__6 = ___ref______nl__6.getValue();

//line 281
___nl__7 = null;
//line 281
___nl__7 = new ImmString("errors");
//line 281
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__2,___nl__7,___nl__6);
___nl__2 = ___ref______nl__2.getValue();

//line 281
___nl__7 = null;
//line 281
___nl__6 = null;
//line 282
___nl__0 = null;
//line 282
___nl__1 = null;
//line 282
___nl__3 = null;
//line 282
___nl__4 = null;
//line 282
___nl__5 = null;
//line 282
___arg__2.setValue(___nl__2);if(true) return null;
//line 283
if (true) {goto label_10;}
//line 283
label_10:
//line 283
___nl__5 = null;
//line 284
___nl__5 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("value"));
//line 284
___nl__6 = ___nl__5;
//line 284
((ImmHash)___nl__3).set("write", ___nl__6);
//line 284
___nl__5 = null;
//line 284
___nl__6 = null;
//line 285
if (true) {goto label_3;}
//line 285
label_3:
//line 285
___nl__4 = null;
//line 286
___nl__4 = new ImmString("vars");
//line 286
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__2,___nl__4);

//line 286
___ref______nl__4 = new ImmRef(___nl__4);
hash_NL.NL_set_value(___ref______nl__4,___nl__0,___nl__3);
___nl__4 = ___ref______nl__4.getValue();

//line 286
___nl__5 = new ImmString("vars");
//line 286
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__2,___nl__5,___nl__4);
___nl__2 = ___ref______nl__2.getValue();

//line 286
___nl__5 = null;
//line 286
___nl__4 = null;
//line 286
___nl__3 = null;
//line 286
___nl__0 = null;
//line 286
___nl__1 = null;
//line 286
___arg__2.setValue(___nl__2);if(true) return null;
}

private static Imm NL_add_var_dec_priv(Imm ___arg__0, Imm ___arg__1, Imm ___arg__2, ImmRef ___arg__3) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();Imm ___nl__3 = ___arg__3.getValue().clone();
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
//line 289
___nl__4 = ((ImmHash)___nl__0).getHashValue()["name"];
//line 289
___ref______nl__3 = new ImmRef(___nl__3);
module_checker_NL.NL_add_var_priv(___nl__4,___nl__1,___nl__2,___ref______nl__3);
___nl__3 = ___ref______nl__3.getValue();

//line 289
___nl__4 = null;
//line 290
___nl__4 = ((ImmHash)___nl__0).getHashValue()["type"];
//line 290
___ref______nl__3 = new ImmRef(___nl__3);
module_checker_NL.NL_check_type_priv(___nl__4,___ref______nl__3);
___nl__3 = ___ref______nl__3.getValue();

//line 290
___nl__4 = null;
//line 291
___nl__4 = ((ImmHash)___nl__0).getHashValue()["value"];
//line 291
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("value"));
//line 291
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_2;}}
//line 295
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("none"));
//line 295
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_3;}}
//line 295
___nl__5 = new ImmString("NOMATCHALERT");
//line 295
___nl__5 = new ImmArray(new Imm[] {___nl__5,___nl__4,});
//line 295
c_rt_lib_NL.NL_die();
//line 291
label_2:
//line 291
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("value"));
//line 292
___ref______nl__3 = new ImmRef(___nl__3);
module_checker_NL.NL_check_val_priv(___nl__6,___ref______nl__3);
___nl__3 = ___ref______nl__3.getValue();

//line 293
___nl__7 = ___nl__1;
//line 293
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 293
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_5;}}
//line 293
___nl__8 = new ImmArray(new Imm[0]);
//line 293
c_rt_lib_NL.NL_die();
//line 293
if (true) {goto label_5;}
//line 293
label_5:
//line 293
___nl__7 = null;
//line 293
___nl__8 = null;
//line 294
___nl__7 = ((ImmHash)___nl__0).getHashValue()["name"];
//line 294
___nl__8 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("set"));
//line 294
___ref______nl__3 = new ImmRef(___nl__3);
module_checker_NL.NL_use_var_priv(___nl__7,___nl__8,___ref______nl__3);
___nl__3 = ___ref______nl__3.getValue();

//line 294
___nl__8 = null;
//line 294
___nl__7 = null;
//line 294
___nl__6 = null;
//line 295
if (true) {goto label_1;}
//line 295
label_3:
//line 296
if (true) {goto label_1;}
//line 296
label_1:
//line 296
___nl__4 = null;
//line 296
___nl__5 = null;
//line 296
___nl__0 = null;
//line 296
___nl__1 = null;
//line 296
___nl__2 = null;
//line 296
___arg__3.setValue(___nl__3);if(true) return null;
}

private static Imm NL_check_cmd_priv(Imm ___arg__0, ImmRef ___arg__1) {
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
Dictionary<String, Imm> __function_map;
//line 300
___nl__2 = ((ImmHash)___nl__0).getHashValue()["debug"];
//line 300
___nl__2 = ((ImmHash)___nl__2).getHashValue()["begin"];
//line 300
___nl__2 = ((ImmHash)___nl__2).getHashValue()["line"];
//line 300
___nl__3 = new ImmString("errors");
//line 300
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__3);

//line 300
___nl__4 = ___nl__2;
//line 300
((ImmHash)___nl__3).set("current_line", ___nl__4);
//line 300
___nl__5 = new ImmString("errors");
//line 300
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__5,___nl__3);
___nl__1 = ___ref______nl__1.getValue();

//line 300
___nl__5 = null;
//line 300
___nl__2 = null;
//line 300
___nl__3 = null;
//line 300
___nl__4 = null;
//line 301
___nl__2 = ((ImmHash)___nl__1).getHashValue()["return"];
//line 301
___nl__2 = ((ImmHash)___nl__2).getHashValue()["was"];
//line 301
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 301
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 302
___nl__3 = new ImmString("errors");
//line 302
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__3);

//line 302
___nl__4 = new ImmString("never used command");
//line 302
___ref______nl__3 = new ImmRef(___nl__3);
module_checker_NL.NL_add_warning_priv(___ref______nl__3,___nl__4);
___nl__3 = ___ref______nl__3.getValue();

//line 302
___nl__4 = null;
//line 302
___nl__4 = new ImmString("errors");
//line 302
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__4,___nl__3);
___nl__1 = ___ref______nl__1.getValue();

//line 302
___nl__4 = null;
//line 302
___nl__3 = null;
//line 303
___nl__3 = c_rt_lib_NL.NL_get_false();
//line 303
___nl__4 = new ImmString("return");
//line 303
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__4);

//line 303
___nl__5 = ___nl__3;
//line 303
((ImmHash)___nl__4).set("was", ___nl__5);
//line 303
___nl__6 = new ImmString("return");
//line 303
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__6,___nl__4);
___nl__1 = ___ref______nl__1.getValue();

//line 303
___nl__6 = null;
//line 303
___nl__3 = null;
//line 303
___nl__4 = null;
//line 303
___nl__5 = null;
//line 304
if (true) {goto label_2;}
//line 304
label_2:
//line 304
___nl__2 = null;
//line 305
___nl__2 = ((ImmHash)___nl__0).getHashValue()["cmd"];
//line 305
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("if"));
//line 305
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_4;}}
//line 319
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("for"));
//line 319
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_5;}}
//line 332
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("fora"));
//line 332
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_6;}}
//line 340
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("forh"));
//line 340
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_7;}}
//line 349
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("loop"));
//line 349
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_8;}}
//line 354
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("rep"));
//line 354
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_9;}}
//line 362
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("while"));
//line 362
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_10;}}
//line 369
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("if_mod"));
//line 369
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_11;}}
//line 373
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("unless_mod"));
//line 373
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_12;}}
//line 377
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("break"));
//line 377
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_13;}}
//line 381
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("continue"));
//line 381
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_14;}}
//line 385
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("match"));
//line 385
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_15;}}
//line 400
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("value"));
//line 400
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_16;}}
//line 402
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("return"));
//line 402
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_17;}}
//line 418
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("block"));
//line 418
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_18;}}
//line 424
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("die"));
//line 424
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_19;}}
//line 429
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("var_decl"));
//line 429
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_20;}}
//line 431
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("try"));
//line 431
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_21;}}
//line 439
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("ensure"));
//line 439
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_22;}}
//line 447
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("nop"));
//line 447
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_23;}}
//line 447
___nl__3 = new ImmString("NOMATCHALERT");
//line 447
___nl__3 = new ImmArray(new Imm[] {___nl__3,___nl__2,});
//line 447
c_rt_lib_NL.NL_die();
//line 305
label_4:
//line 305
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("if"));
//line 306
___nl__5 = ((ImmHash)___nl__4).getHashValue()["cond"];
//line 306
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_val_priv(___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 306
___nl__5 = null;
//line 307
___nl__5 = ((ImmHash)___nl__4).getHashValue()["if"];
//line 307
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_cmd_priv(___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 307
___nl__5 = null;
//line 308
___nl__5 = ((ImmHash)___nl__1).getHashValue()["return"];
//line 308
___nl__5 = ((ImmHash)___nl__5).getHashValue()["was"];
//line 309
___nl__6 = ((ImmHash)___nl__4).getHashValue()["elsif"];
//line 309
___nl__8 = new ImmDouble(0);
//line 309
___nl__9 = new ImmDouble(1);
//line 309
___nl__10 = c_rt_lib_NL.NL_array_len(___nl__6);

//line 309
label_26:
//line 309
___nl__11 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString()))>=(Double.Parse(___nl__10.getValue().ToString())) );
//line 309
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_24;}}
//line 309
___nl__7 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 310
___nl__12 = c_rt_lib_NL.NL_get_false();
//line 310
___nl__13 = new ImmString("return");
//line 310
___nl__13 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__13);

//line 310
___nl__14 = ___nl__12;
//line 310
((ImmHash)___nl__13).set("was", ___nl__14);
//line 310
___nl__15 = new ImmString("return");
//line 310
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__15,___nl__13);
___nl__1 = ___ref______nl__1.getValue();

//line 310
___nl__15 = null;
//line 310
___nl__12 = null;
//line 310
___nl__13 = null;
//line 310
___nl__14 = null;
//line 311
___nl__12 = ((ImmHash)___nl__7).getHashValue()["cond"];
//line 311
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_val_priv(___nl__12,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 311
___nl__12 = null;
//line 312
___nl__12 = ((ImmHash)___nl__7).getHashValue()["cmd"];
//line 312
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_cmd_priv(___nl__12,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 312
___nl__12 = null;
//line 313
___nl__12 = ((ImmHash)___nl__1).getHashValue()["return"];
//line 313
___nl__12 = ((ImmHash)___nl__12).getHashValue()["was"];
//line 313
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12));
//line 313
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12));
//line 313
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_28;}}
//line 313
___nl__13 = c_rt_lib_NL.NL_get_false();
//line 313
___nl__5 = ___nl__13;
//line 313
___nl__13 = null;
//line 313
if (true) {goto label_28;}
//line 313
label_28:
//line 313
___nl__12 = null;
//line 314
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))+(Double.Parse(___nl__9.getValue().ToString())));
//line 314
if (true) {goto label_26;}
//line 314
label_24:
//line 314
___nl__6 = null;
//line 314
___nl__7 = null;
//line 314
___nl__8 = null;
//line 314
___nl__9 = null;
//line 314
___nl__10 = null;
//line 314
___nl__11 = null;
//line 315
___nl__6 = c_rt_lib_NL.NL_get_false();
//line 315
___nl__7 = new ImmString("return");
//line 315
___nl__7 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__7);

//line 315
___nl__8 = ___nl__6;
//line 315
((ImmHash)___nl__7).set("was", ___nl__8);
//line 315
___nl__9 = new ImmString("return");
//line 315
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__9,___nl__7);
___nl__1 = ___ref______nl__1.getValue();

//line 315
___nl__9 = null;
//line 315
___nl__6 = null;
//line 315
___nl__7 = null;
//line 315
___nl__8 = null;
//line 316
___nl__6 = ((ImmHash)___nl__4).getHashValue()["else"];
//line 316
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_cmd_priv(___nl__6,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 316
___nl__6 = null;
//line 317
___nl__6 = ((ImmHash)___nl__1).getHashValue()["return"];
//line 317
___nl__6 = ((ImmHash)___nl__6).getHashValue()["was"];
//line 317
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 317
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 317
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_30;}}
//line 317
___nl__7 = c_rt_lib_NL.NL_get_false();
//line 317
___nl__5 = ___nl__7;
//line 317
___nl__7 = null;
//line 317
if (true) {goto label_30;}
//line 317
label_30:
//line 317
___nl__6 = null;
//line 318
___nl__6 = new ImmString("return");
//line 318
___nl__6 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__6);

//line 318
___nl__7 = ___nl__5;
//line 318
((ImmHash)___nl__6).set("was", ___nl__7);
//line 318
___nl__8 = new ImmString("return");
//line 318
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__8,___nl__6);
___nl__1 = ___ref______nl__1.getValue();

//line 318
___nl__8 = null;
//line 318
___nl__6 = null;
//line 318
___nl__7 = null;
//line 318
___nl__5 = null;
//line 318
___nl__4 = null;
//line 319
if (true) {goto label_3;}
//line 319
label_5:
//line 319
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("for"));
//line 320
___ref______nl__1 = new ImmRef(___nl__1);
___nl__5 = module_checker_NL.NL_save_block_priv(___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 321
___nl__6 = ((ImmHash)___nl__4).getHashValue()["start"];
//line 321
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("value"));
//line 321
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_32;}}
//line 323
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("var_decl"));
//line 323
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_33;}}
//line 323
___nl__7 = new ImmString("NOMATCHALERT");
//line 323
___nl__7 = new ImmArray(new Imm[] {___nl__7,___nl__6,});
//line 323
c_rt_lib_NL.NL_die();
//line 321
label_32:
//line 321
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("value"));
//line 322
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_val_priv(___nl__8,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 322
___nl__8 = null;
//line 323
if (true) {goto label_31;}
//line 323
label_33:
//line 323
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("var_decl"));
//line 324
___nl__9 = c_rt_lib_NL.NL_get_false();
//line 324
___nl__10 = c_rt_lib_NL.NL_get_false();
//line 324
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_add_var_dec_priv(___nl__8,___nl__9,___nl__10,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 324
___nl__10 = null;
//line 324
___nl__9 = null;
//line 324
___nl__8 = null;
//line 325
if (true) {goto label_31;}
//line 325
label_31:
//line 325
___nl__6 = null;
//line 325
___nl__7 = null;
//line 326
___nl__6 = ((ImmHash)___nl__4).getHashValue()["cond"];
//line 326
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_val_priv(___nl__6,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 326
___nl__6 = null;
//line 327
___nl__6 = c_rt_lib_NL.NL_get_true();
//line 327
___nl__7 = ___nl__6;
//line 327
((ImmHash)___nl__1).set("in_loop", ___nl__7);
//line 327
___nl__6 = null;
//line 327
___nl__7 = null;
//line 328
___nl__6 = ((ImmHash)___nl__4).getHashValue()["cmd"];
//line 328
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_cmd_priv(___nl__6,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 328
___nl__6 = null;
//line 329
___nl__6 = ((ImmHash)___nl__4).getHashValue()["iter"];
//line 329
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_val_priv(___nl__6,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 329
___nl__6 = null;
//line 330
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_load_block_priv(___ref______nl__1,___nl__5);
___nl__1 = ___ref______nl__1.getValue();

//line 331
___nl__6 = c_rt_lib_NL.NL_get_false();
//line 331
___nl__7 = new ImmString("return");
//line 331
___nl__7 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__7);

//line 331
___nl__8 = ___nl__6;
//line 331
((ImmHash)___nl__7).set("was", ___nl__8);
//line 331
___nl__9 = new ImmString("return");
//line 331
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__9,___nl__7);
___nl__1 = ___ref______nl__1.getValue();

//line 331
___nl__9 = null;
//line 331
___nl__6 = null;
//line 331
___nl__7 = null;
//line 331
___nl__8 = null;
//line 331
___nl__5 = null;
//line 331
___nl__4 = null;
//line 332
if (true) {goto label_3;}
//line 332
label_6:
//line 332
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("fora"));
//line 333
___ref______nl__1 = new ImmRef(___nl__1);
___nl__5 = module_checker_NL.NL_save_block_priv(___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 334
___nl__6 = ((ImmHash)___nl__4).getHashValue()["array"];
//line 334
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_val_priv(___nl__6,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 334
___nl__6 = null;
//line 335
___nl__6 = ((ImmHash)___nl__4).getHashValue()["iter"];
//line 335
___nl__7 = c_rt_lib_NL.NL_get_true();
//line 335
___nl__8 = c_rt_lib_NL.NL_get_true();
//line 335
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_add_var_dec_priv(___nl__6,___nl__7,___nl__8,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 335
___nl__8 = null;
//line 335
___nl__7 = null;
//line 335
___nl__6 = null;
//line 336
___nl__6 = c_rt_lib_NL.NL_get_true();
//line 336
___nl__7 = ___nl__6;
//line 336
((ImmHash)___nl__1).set("in_loop", ___nl__7);
//line 336
___nl__6 = null;
//line 336
___nl__7 = null;
//line 337
___nl__6 = ((ImmHash)___nl__4).getHashValue()["cmd"];
//line 337
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_cmd_priv(___nl__6,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 337
___nl__6 = null;
//line 338
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_load_block_priv(___ref______nl__1,___nl__5);
___nl__1 = ___ref______nl__1.getValue();

//line 339
___nl__6 = c_rt_lib_NL.NL_get_false();
//line 339
___nl__7 = new ImmString("return");
//line 339
___nl__7 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__7);

//line 339
___nl__8 = ___nl__6;
//line 339
((ImmHash)___nl__7).set("was", ___nl__8);
//line 339
___nl__9 = new ImmString("return");
//line 339
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__9,___nl__7);
___nl__1 = ___ref______nl__1.getValue();

//line 339
___nl__9 = null;
//line 339
___nl__6 = null;
//line 339
___nl__7 = null;
//line 339
___nl__8 = null;
//line 339
___nl__5 = null;
//line 339
___nl__4 = null;
//line 340
if (true) {goto label_3;}
//line 340
label_7:
//line 340
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("forh"));
//line 341
___ref______nl__1 = new ImmRef(___nl__1);
___nl__5 = module_checker_NL.NL_save_block_priv(___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 342
___nl__6 = ((ImmHash)___nl__4).getHashValue()["hash"];
//line 342
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_val_priv(___nl__6,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 342
___nl__6 = null;
//line 343
___nl__6 = ((ImmHash)___nl__4).getHashValue()["val"];
//line 343
___nl__7 = c_rt_lib_NL.NL_get_true();
//line 343
___nl__8 = c_rt_lib_NL.NL_get_true();
//line 343
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_add_var_dec_priv(___nl__6,___nl__7,___nl__8,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 343
___nl__8 = null;
//line 343
___nl__7 = null;
//line 343
___nl__6 = null;
//line 344
___nl__6 = ((ImmHash)___nl__4).getHashValue()["key"];
//line 344
___nl__7 = c_rt_lib_NL.NL_get_true();
//line 344
___nl__8 = c_rt_lib_NL.NL_get_true();
//line 344
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_add_var_dec_priv(___nl__6,___nl__7,___nl__8,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 344
___nl__8 = null;
//line 344
___nl__7 = null;
//line 344
___nl__6 = null;
//line 345
___nl__6 = c_rt_lib_NL.NL_get_true();
//line 345
___nl__7 = ___nl__6;
//line 345
((ImmHash)___nl__1).set("in_loop", ___nl__7);
//line 345
___nl__6 = null;
//line 345
___nl__7 = null;
//line 346
___nl__6 = ((ImmHash)___nl__4).getHashValue()["cmd"];
//line 346
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_cmd_priv(___nl__6,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 346
___nl__6 = null;
//line 347
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_load_block_priv(___ref______nl__1,___nl__5);
___nl__1 = ___ref______nl__1.getValue();

//line 348
___nl__6 = c_rt_lib_NL.NL_get_false();
//line 348
___nl__7 = new ImmString("return");
//line 348
___nl__7 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__7);

//line 348
___nl__8 = ___nl__6;
//line 348
((ImmHash)___nl__7).set("was", ___nl__8);
//line 348
___nl__9 = new ImmString("return");
//line 348
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__9,___nl__7);
___nl__1 = ___ref______nl__1.getValue();

//line 348
___nl__9 = null;
//line 348
___nl__6 = null;
//line 348
___nl__7 = null;
//line 348
___nl__8 = null;
//line 348
___nl__5 = null;
//line 348
___nl__4 = null;
//line 349
if (true) {goto label_3;}
//line 349
label_8:
//line 349
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("loop"));
//line 350
___ref______nl__1 = new ImmRef(___nl__1);
___nl__5 = module_checker_NL.NL_save_block_priv(___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 351
___nl__6 = c_rt_lib_NL.NL_get_true();
//line 351
___nl__7 = ___nl__6;
//line 351
((ImmHash)___nl__1).set("in_loop", ___nl__7);
//line 351
___nl__6 = null;
//line 351
___nl__7 = null;
//line 352
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_cmd_priv(___nl__4,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 353
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_load_block_priv(___ref______nl__1,___nl__5);
___nl__1 = ___ref______nl__1.getValue();

//line 353
___nl__5 = null;
//line 353
___nl__4 = null;
//line 354
if (true) {goto label_3;}
//line 354
label_9:
//line 354
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("rep"));
//line 355
___ref______nl__1 = new ImmRef(___nl__1);
___nl__5 = module_checker_NL.NL_save_block_priv(___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 356
___nl__6 = ((ImmHash)___nl__4).getHashValue()["count"];
//line 356
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_val_priv(___nl__6,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 356
___nl__6 = null;
//line 357
___nl__6 = ((ImmHash)___nl__4).getHashValue()["iter"];
//line 357
___nl__7 = c_rt_lib_NL.NL_get_true();
//line 357
___nl__8 = c_rt_lib_NL.NL_get_true();
//line 357
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_add_var_dec_priv(___nl__6,___nl__7,___nl__8,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 357
___nl__8 = null;
//line 357
___nl__7 = null;
//line 357
___nl__6 = null;
//line 358
___nl__6 = c_rt_lib_NL.NL_get_true();
//line 358
___nl__7 = ___nl__6;
//line 358
((ImmHash)___nl__1).set("in_loop", ___nl__7);
//line 358
___nl__6 = null;
//line 358
___nl__7 = null;
//line 359
___nl__6 = ((ImmHash)___nl__4).getHashValue()["cmd"];
//line 359
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_cmd_priv(___nl__6,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 359
___nl__6 = null;
//line 360
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_load_block_priv(___ref______nl__1,___nl__5);
___nl__1 = ___ref______nl__1.getValue();

//line 361
___nl__6 = c_rt_lib_NL.NL_get_false();
//line 361
___nl__7 = new ImmString("return");
//line 361
___nl__7 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__7);

//line 361
___nl__8 = ___nl__6;
//line 361
((ImmHash)___nl__7).set("was", ___nl__8);
//line 361
___nl__9 = new ImmString("return");
//line 361
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__9,___nl__7);
___nl__1 = ___ref______nl__1.getValue();

//line 361
___nl__9 = null;
//line 361
___nl__6 = null;
//line 361
___nl__7 = null;
//line 361
___nl__8 = null;
//line 361
___nl__5 = null;
//line 361
___nl__4 = null;
//line 362
if (true) {goto label_3;}
//line 362
label_10:
//line 362
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("while"));
//line 363
___ref______nl__1 = new ImmRef(___nl__1);
___nl__5 = module_checker_NL.NL_save_block_priv(___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 364
___nl__6 = ((ImmHash)___nl__4).getHashValue()["cond"];
//line 364
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_val_priv(___nl__6,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 364
___nl__6 = null;
//line 365
___nl__6 = c_rt_lib_NL.NL_get_true();
//line 365
___nl__7 = ___nl__6;
//line 365
((ImmHash)___nl__1).set("in_loop", ___nl__7);
//line 365
___nl__6 = null;
//line 365
___nl__7 = null;
//line 366
___nl__6 = ((ImmHash)___nl__4).getHashValue()["cmd"];
//line 366
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_cmd_priv(___nl__6,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 366
___nl__6 = null;
//line 367
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_load_block_priv(___ref______nl__1,___nl__5);
___nl__1 = ___ref______nl__1.getValue();

//line 368
___nl__6 = c_rt_lib_NL.NL_get_false();
//line 368
___nl__7 = new ImmString("return");
//line 368
___nl__7 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__7);

//line 368
___nl__8 = ___nl__6;
//line 368
((ImmHash)___nl__7).set("was", ___nl__8);
//line 368
___nl__9 = new ImmString("return");
//line 368
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__9,___nl__7);
___nl__1 = ___ref______nl__1.getValue();

//line 368
___nl__9 = null;
//line 368
___nl__6 = null;
//line 368
___nl__7 = null;
//line 368
___nl__8 = null;
//line 368
___nl__5 = null;
//line 368
___nl__4 = null;
//line 369
if (true) {goto label_3;}
//line 369
label_11:
//line 369
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("if_mod"));
//line 370
___nl__5 = ((ImmHash)___nl__4).getHashValue()["cond"];
//line 370
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_val_priv(___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 370
___nl__5 = null;
//line 371
___nl__5 = ((ImmHash)___nl__4).getHashValue()["cmd"];
//line 371
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_cmd_priv(___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 371
___nl__5 = null;
//line 372
___nl__5 = c_rt_lib_NL.NL_get_false();
//line 372
___nl__6 = new ImmString("return");
//line 372
___nl__6 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__6);

//line 372
___nl__7 = ___nl__5;
//line 372
((ImmHash)___nl__6).set("was", ___nl__7);
//line 372
___nl__8 = new ImmString("return");
//line 372
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__8,___nl__6);
___nl__1 = ___ref______nl__1.getValue();

//line 372
___nl__8 = null;
//line 372
___nl__5 = null;
//line 372
___nl__6 = null;
//line 372
___nl__7 = null;
//line 372
___nl__4 = null;
//line 373
if (true) {goto label_3;}
//line 373
label_12:
//line 373
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("unless_mod"));
//line 374
___nl__5 = ((ImmHash)___nl__4).getHashValue()["cond"];
//line 374
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_val_priv(___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 374
___nl__5 = null;
//line 375
___nl__5 = ((ImmHash)___nl__4).getHashValue()["cmd"];
//line 375
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_cmd_priv(___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 375
___nl__5 = null;
//line 376
___nl__5 = c_rt_lib_NL.NL_get_false();
//line 376
___nl__6 = new ImmString("return");
//line 376
___nl__6 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__6);

//line 376
___nl__7 = ___nl__5;
//line 376
((ImmHash)___nl__6).set("was", ___nl__7);
//line 376
___nl__8 = new ImmString("return");
//line 376
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__8,___nl__6);
___nl__1 = ___ref______nl__1.getValue();

//line 376
___nl__8 = null;
//line 376
___nl__5 = null;
//line 376
___nl__6 = null;
//line 376
___nl__7 = null;
//line 376
___nl__4 = null;
//line 377
if (true) {goto label_3;}
//line 377
label_13:
//line 378
___nl__4 = ((ImmHash)___nl__1).getHashValue()["in_loop"];
//line 378
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 378
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 378
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_35;}}
//line 379
___nl__5 = new ImmString("errors");
//line 379
___nl__5 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__5);

//line 379
___nl__6 = new ImmString("command break can be used only in cyclic block");
//line 379
___ref______nl__5 = new ImmRef(___nl__5);
module_checker_NL.NL_add_error_priv(___ref______nl__5,___nl__6);
___nl__5 = ___ref______nl__5.getValue();

//line 379
___nl__6 = null;
//line 379
___nl__6 = new ImmString("errors");
//line 379
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__6,___nl__5);
___nl__1 = ___ref______nl__1.getValue();

//line 379
___nl__6 = null;
//line 379
___nl__5 = null;
//line 380
if (true) {goto label_35;}
//line 380
label_35:
//line 380
___nl__4 = null;
//line 381
if (true) {goto label_3;}
//line 381
label_14:
//line 382
___nl__4 = ((ImmHash)___nl__1).getHashValue()["in_loop"];
//line 382
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 382
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 382
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_37;}}
//line 383
___nl__5 = new ImmString("errors");
//line 383
___nl__5 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__5);

//line 383
___nl__6 = new ImmString("command continue can be used only in cyclic block");
//line 383
___ref______nl__5 = new ImmRef(___nl__5);
module_checker_NL.NL_add_error_priv(___ref______nl__5,___nl__6);
___nl__5 = ___ref______nl__5.getValue();

//line 383
___nl__6 = null;
//line 383
___nl__6 = new ImmString("errors");
//line 383
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__6,___nl__5);
___nl__1 = ___ref______nl__1.getValue();

//line 383
___nl__6 = null;
//line 383
___nl__5 = null;
//line 384
if (true) {goto label_37;}
//line 384
label_37:
//line 384
___nl__4 = null;
//line 385
if (true) {goto label_3;}
//line 385
label_15:
//line 385
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("match"));
//line 386
___nl__5 = ((ImmHash)___nl__4).getHashValue()["val"];
//line 386
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_val_priv(___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 386
___nl__5 = null;
//line 387
___nl__5 = c_rt_lib_NL.NL_get_true();
//line 388
___nl__6 = ((ImmHash)___nl__4).getHashValue()["branch_list"];
//line 388
___nl__8 = new ImmDouble(0);
//line 388
___nl__9 = new ImmDouble(1);
//line 388
___nl__10 = c_rt_lib_NL.NL_array_len(___nl__6);

//line 388
label_40:
//line 388
___nl__11 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString()))>=(Double.Parse(___nl__10.getValue().ToString())) );
//line 388
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_38;}}
//line 388
___nl__7 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 389
___nl__12 = c_rt_lib_NL.NL_get_false();
//line 389
___nl__13 = new ImmString("return");
//line 389
___nl__13 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__13);

//line 389
___nl__14 = ___nl__12;
//line 389
((ImmHash)___nl__13).set("was", ___nl__14);
//line 389
___nl__15 = new ImmString("return");
//line 389
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__15,___nl__13);
___nl__1 = ___ref______nl__1.getValue();

//line 389
___nl__15 = null;
//line 389
___nl__12 = null;
//line 389
___nl__13 = null;
//line 389
___nl__14 = null;
//line 390
___ref______nl__1 = new ImmRef(___nl__1);
___nl__12 = module_checker_NL.NL_save_block_priv(___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 391
___nl__13 = ((ImmHash)___nl__7).getHashValue()["variant"];
//line 391
___nl__13 = ((ImmHash)___nl__13).getHashValue()["value"];
//line 391
___nl__14 = c_rt_lib_NL.NL_ov_is(___nl__13, new ImmString("none"));
//line 391
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_42;}}
//line 392
___nl__14 = c_rt_lib_NL.NL_ov_is(___nl__13, new ImmString("value"));
//line 392
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_43;}}
//line 392
___nl__14 = new ImmString("NOMATCHALERT");
//line 392
___nl__14 = new ImmArray(new Imm[] {___nl__14,___nl__13,});
//line 392
c_rt_lib_NL.NL_die();
//line 391
label_42:
//line 392
if (true) {goto label_41;}
//line 392
label_43:
//line 392
___nl__15 = c_rt_lib_NL.NL_ov_as(___nl__13, new ImmString("value"));
//line 393
___nl__16 = c_rt_lib_NL.NL_get_false();
//line 393
___nl__17 = c_rt_lib_NL.NL_get_true();
//line 393
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_add_var_dec_priv(___nl__15,___nl__16,___nl__17,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 393
___nl__17 = null;
//line 393
___nl__16 = null;
//line 393
___nl__15 = null;
//line 394
if (true) {goto label_41;}
//line 394
label_41:
//line 394
___nl__13 = null;
//line 394
___nl__14 = null;
//line 395
___nl__13 = ((ImmHash)___nl__7).getHashValue()["cmd"];
//line 395
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_cmd_priv(___nl__13,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 395
___nl__13 = null;
//line 396
___nl__13 = ((ImmHash)___nl__1).getHashValue()["return"];
//line 396
___nl__13 = ((ImmHash)___nl__13).getHashValue()["was"];
//line 396
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13));
//line 396
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13));
//line 396
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_45;}}
//line 396
___nl__14 = c_rt_lib_NL.NL_get_false();
//line 396
___nl__5 = ___nl__14;
//line 396
___nl__14 = null;
//line 396
if (true) {goto label_45;}
//line 396
label_45:
//line 396
___nl__13 = null;
//line 397
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_load_block_priv(___ref______nl__1,___nl__12);
___nl__1 = ___ref______nl__1.getValue();

//line 397
___nl__12 = null;
//line 398
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))+(Double.Parse(___nl__9.getValue().ToString())));
//line 398
if (true) {goto label_40;}
//line 398
label_38:
//line 398
___nl__6 = null;
//line 398
___nl__7 = null;
//line 398
___nl__8 = null;
//line 398
___nl__9 = null;
//line 398
___nl__10 = null;
//line 398
___nl__11 = null;
//line 399
___nl__6 = new ImmString("return");
//line 399
___nl__6 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__6);

//line 399
___nl__7 = ___nl__5;
//line 399
((ImmHash)___nl__6).set("was", ___nl__7);
//line 399
___nl__8 = new ImmString("return");
//line 399
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__8,___nl__6);
___nl__1 = ___ref______nl__1.getValue();

//line 399
___nl__8 = null;
//line 399
___nl__6 = null;
//line 399
___nl__7 = null;
//line 399
___nl__5 = null;
//line 399
___nl__4 = null;
//line 400
if (true) {goto label_3;}
//line 400
label_16:
//line 400
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("value"));
//line 401
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_val_priv(___nl__4,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 401
___nl__4 = null;
//line 402
if (true) {goto label_3;}
//line 402
label_17:
//line 402
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("return"));
//line 403
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_val_priv(___nl__4,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 404
___nl__5 = ((ImmHash)___nl__1).getHashValue()["return"];
//line 404
___nl__5 = ((ImmHash)___nl__5).getHashValue()["arg"];
//line 404
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("value"));
//line 404
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_47;}}
//line 406
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("none"));
//line 406
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_48;}}
//line 408
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("was_value"));
//line 408
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_49;}}
//line 411
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("was_void"));
//line 411
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_50;}}
//line 414
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("void"));
//line 414
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_51;}}
//line 414
___nl__6 = new ImmString("NOMATCHALERT");
//line 414
___nl__6 = new ImmArray(new Imm[] {___nl__6,___nl__5,});
//line 414
c_rt_lib_NL.NL_die();
//line 404
label_47:
//line 405
___nl__7 = ___nl__4;
//line 405
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("nop"));
//line 405
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 405
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_53;}}
//line 405
___nl__8 = new ImmString("errors");
//line 405
___nl__8 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__8);

//line 405
___nl__9 = new ImmString("return command without value");
//line 405
___ref______nl__8 = new ImmRef(___nl__8);
module_checker_NL.NL_add_error_priv(___ref______nl__8,___nl__9);
___nl__8 = ___ref______nl__8.getValue();

//line 405
___nl__9 = null;
//line 405
___nl__9 = new ImmString("errors");
//line 405
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__9,___nl__8);
___nl__1 = ___ref______nl__1.getValue();

//line 405
___nl__9 = null;
//line 405
___nl__8 = null;
//line 405
if (true) {goto label_53;}
//line 405
label_53:
//line 405
___nl__7 = null;
//line 406
if (true) {goto label_46;}
//line 406
label_48:
//line 407
___nl__7 = ___nl__4;
//line 407
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("nop"));
//line 407
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_55;}}
//line 407
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("was_value"));
//line 407
if (true) {goto label_54;}
//line 407
label_55:
//line 407
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("was_void"));
//line 407
label_54:
//line 407
___nl__8 = new ImmString("return");
//line 407
___nl__8 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__8);

//line 407
___nl__9 = ___nl__7;
//line 407
((ImmHash)___nl__8).set("arg", ___nl__9);
//line 407
___nl__10 = new ImmString("return");
//line 407
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__10,___nl__8);
___nl__1 = ___ref______nl__1.getValue();

//line 407
___nl__10 = null;
//line 407
___nl__7 = null;
//line 407
___nl__8 = null;
//line 407
___nl__9 = null;
//line 408
if (true) {goto label_46;}
//line 408
label_49:
//line 409
___nl__7 = ___nl__4;
//line 409
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("nop"));
//line 409
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 409
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_57;}}
//line 409
___nl__8 = new ImmString("errors");
//line 409
___nl__8 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__8);

//line 409
___nl__9 = new ImmString("previously was return with value");
//line 409
___ref______nl__8 = new ImmRef(___nl__8);
module_checker_NL.NL_add_error_priv(___ref______nl__8,___nl__9);
___nl__8 = ___ref______nl__8.getValue();

//line 409
___nl__9 = null;
//line 409
___nl__9 = new ImmString("errors");
//line 409
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__9,___nl__8);
___nl__1 = ___ref______nl__1.getValue();

//line 409
___nl__9 = null;
//line 409
___nl__8 = null;
//line 409
if (true) {goto label_57;}
//line 409
label_57:
//line 409
___nl__7 = null;
//line 410
___nl__7 = ___nl__4;
//line 410
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("nop"));
//line 410
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_59;}}
//line 410
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("was_value"));
//line 410
if (true) {goto label_58;}
//line 410
label_59:
//line 410
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("was_void"));
//line 410
label_58:
//line 410
___nl__8 = new ImmString("return");
//line 410
___nl__8 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__8);

//line 410
___nl__9 = ___nl__7;
//line 410
((ImmHash)___nl__8).set("arg", ___nl__9);
//line 410
___nl__10 = new ImmString("return");
//line 410
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__10,___nl__8);
___nl__1 = ___ref______nl__1.getValue();

//line 410
___nl__10 = null;
//line 410
___nl__7 = null;
//line 410
___nl__8 = null;
//line 410
___nl__9 = null;
//line 411
if (true) {goto label_46;}
//line 411
label_50:
//line 412
___nl__7 = ___nl__4;
//line 412
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("nop"));
//line 412
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 412
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 412
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_61;}}
//line 412
___nl__8 = new ImmString("errors");
//line 412
___nl__8 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__8);

//line 412
___nl__9 = new ImmString("previously was empty return");
//line 412
___ref______nl__8 = new ImmRef(___nl__8);
module_checker_NL.NL_add_error_priv(___ref______nl__8,___nl__9);
___nl__8 = ___ref______nl__8.getValue();

//line 412
___nl__9 = null;
//line 412
___nl__9 = new ImmString("errors");
//line 412
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__9,___nl__8);
___nl__1 = ___ref______nl__1.getValue();

//line 412
___nl__9 = null;
//line 412
___nl__8 = null;
//line 412
if (true) {goto label_61;}
//line 412
label_61:
//line 412
___nl__7 = null;
//line 413
___nl__7 = ___nl__4;
//line 413
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("nop"));
//line 413
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_63;}}
//line 413
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("was_value"));
//line 413
if (true) {goto label_62;}
//line 413
label_63:
//line 413
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("was_void"));
//line 413
label_62:
//line 413
___nl__8 = new ImmString("return");
//line 413
___nl__8 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__8);

//line 413
___nl__9 = ___nl__7;
//line 413
((ImmHash)___nl__8).set("arg", ___nl__9);
//line 413
___nl__10 = new ImmString("return");
//line 413
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__10,___nl__8);
___nl__1 = ___ref______nl__1.getValue();

//line 413
___nl__10 = null;
//line 413
___nl__7 = null;
//line 413
___nl__8 = null;
//line 413
___nl__9 = null;
//line 414
if (true) {goto label_46;}
//line 414
label_51:
//line 415
___nl__7 = ___nl__4;
//line 415
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("nop"));
//line 415
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 415
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 415
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_65;}}
//line 415
___nl__8 = new ImmString("errors");
//line 415
___nl__8 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__8);

//line 415
___nl__9 = new ImmString("return value in void function");
//line 415
___ref______nl__8 = new ImmRef(___nl__8);
module_checker_NL.NL_add_error_priv(___ref______nl__8,___nl__9);
___nl__8 = ___ref______nl__8.getValue();

//line 415
___nl__9 = null;
//line 415
___nl__9 = new ImmString("errors");
//line 415
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__9,___nl__8);
___nl__1 = ___ref______nl__1.getValue();

//line 415
___nl__9 = null;
//line 415
___nl__8 = null;
//line 415
if (true) {goto label_65;}
//line 415
label_65:
//line 415
___nl__7 = null;
//line 416
if (true) {goto label_46;}
//line 416
label_46:
//line 416
___nl__5 = null;
//line 416
___nl__6 = null;
//line 417
___nl__5 = c_rt_lib_NL.NL_get_true();
//line 417
___nl__6 = new ImmString("return");
//line 417
___nl__6 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__6);

//line 417
___nl__7 = ___nl__5;
//line 417
((ImmHash)___nl__6).set("was", ___nl__7);
//line 417
___nl__8 = new ImmString("return");
//line 417
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__8,___nl__6);
___nl__1 = ___ref______nl__1.getValue();

//line 417
___nl__8 = null;
//line 417
___nl__5 = null;
//line 417
___nl__6 = null;
//line 417
___nl__7 = null;
//line 417
___nl__4 = null;
//line 418
if (true) {goto label_3;}
//line 418
label_18:
//line 418
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("block"));
//line 419
___ref______nl__1 = new ImmRef(___nl__1);
___nl__5 = module_checker_NL.NL_save_block_priv(___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 420
___nl__7 = new ImmDouble(0);
//line 420
___nl__8 = new ImmDouble(1);
//line 420
___nl__9 = c_rt_lib_NL.NL_array_len(___nl__4);

//line 420
label_68:
//line 420
___nl__10 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))>=(Double.Parse(___nl__9.getValue().ToString())) );
//line 420
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_66;}}
//line 420
___nl__6 = (___nl__4 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 421
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_cmd_priv(___nl__6,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 422
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString())));
//line 422
if (true) {goto label_68;}
//line 422
label_66:
//line 422
___nl__6 = null;
//line 422
___nl__7 = null;
//line 422
___nl__8 = null;
//line 422
___nl__9 = null;
//line 422
___nl__10 = null;
//line 423
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_load_block_priv(___ref______nl__1,___nl__5);
___nl__1 = ___ref______nl__1.getValue();

//line 423
___nl__5 = null;
//line 423
___nl__4 = null;
//line 424
if (true) {goto label_3;}
//line 424
label_19:
//line 424
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("die"));
//line 425
___nl__6 = new ImmDouble(0);
//line 425
___nl__7 = new ImmDouble(1);
//line 425
___nl__8 = c_rt_lib_NL.NL_array_len(___nl__4);

//line 425
label_71:
//line 425
___nl__9 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__6.getValue().ToString()))>=(Double.Parse(___nl__8.getValue().ToString())) );
//line 425
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_69;}}
//line 425
___nl__5 = (___nl__4 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()];
//line 426
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_val_priv(___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 427
___nl__6 = new ImmDouble((Double.Parse(___nl__6.getValue().ToString()))+(Double.Parse(___nl__7.getValue().ToString())));
//line 427
if (true) {goto label_71;}
//line 427
label_69:
//line 427
___nl__5 = null;
//line 427
___nl__6 = null;
//line 427
___nl__7 = null;
//line 427
___nl__8 = null;
//line 427
___nl__9 = null;
//line 428
___nl__5 = c_rt_lib_NL.NL_get_true();
//line 428
___nl__6 = new ImmString("return");
//line 428
___nl__6 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__6);

//line 428
___nl__7 = ___nl__5;
//line 428
((ImmHash)___nl__6).set("was", ___nl__7);
//line 428
___nl__8 = new ImmString("return");
//line 428
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__8,___nl__6);
___nl__1 = ___ref______nl__1.getValue();

//line 428
___nl__8 = null;
//line 428
___nl__5 = null;
//line 428
___nl__6 = null;
//line 428
___nl__7 = null;
//line 428
___nl__4 = null;
//line 429
if (true) {goto label_3;}
//line 429
label_20:
//line 429
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("var_decl"));
//line 430
___nl__5 = c_rt_lib_NL.NL_get_false();
//line 430
___nl__6 = c_rt_lib_NL.NL_get_false();
//line 430
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_add_var_dec_priv(___nl__4,___nl__5,___nl__6,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 430
___nl__6 = null;
//line 430
___nl__5 = null;
//line 430
___nl__4 = null;
//line 431
if (true) {goto label_3;}
//line 431
label_21:
//line 431
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("try"));
//line 432
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("decl"));
//line 432
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_73;}}
//line 434
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("lval"));
//line 434
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_74;}}
//line 436
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("expr"));
//line 436
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_75;}}
//line 436
___nl__5 = new ImmString("NOMATCHALERT");
//line 436
___nl__5 = new ImmArray(new Imm[] {___nl__5,___nl__4,});
//line 436
c_rt_lib_NL.NL_die();
//line 432
label_73:
//line 432
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("decl"));
//line 433
___nl__7 = c_rt_lib_NL.NL_get_false();
//line 433
___nl__8 = c_rt_lib_NL.NL_get_false();
//line 433
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_add_var_dec_priv(___nl__6,___nl__7,___nl__8,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 433
___nl__8 = null;
//line 433
___nl__7 = null;
//line 433
___nl__6 = null;
//line 434
if (true) {goto label_72;}
//line 434
label_74:
//line 434
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("lval"));
//line 435
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("bin_op"), ___nl__6);
//line 435
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_val_priv(___nl__7,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 435
___nl__7 = null;
//line 435
___nl__6 = null;
//line 436
if (true) {goto label_72;}
//line 436
label_75:
//line 436
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("expr"));
//line 437
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_val_priv(___nl__6,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 437
___nl__6 = null;
//line 438
if (true) {goto label_72;}
//line 438
label_72:
//line 438
___nl__5 = null;
//line 438
___nl__4 = null;
//line 439
if (true) {goto label_3;}
//line 439
label_22:
//line 439
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("ensure"));
//line 440
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("decl"));
//line 440
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_77;}}
//line 442
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("lval"));
//line 442
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_78;}}
//line 444
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("expr"));
//line 444
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_79;}}
//line 444
___nl__5 = new ImmString("NOMATCHALERT");
//line 444
___nl__5 = new ImmArray(new Imm[] {___nl__5,___nl__4,});
//line 444
c_rt_lib_NL.NL_die();
//line 440
label_77:
//line 440
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("decl"));
//line 441
___nl__7 = c_rt_lib_NL.NL_get_false();
//line 441
___nl__8 = c_rt_lib_NL.NL_get_false();
//line 441
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_add_var_dec_priv(___nl__6,___nl__7,___nl__8,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 441
___nl__8 = null;
//line 441
___nl__7 = null;
//line 441
___nl__6 = null;
//line 442
if (true) {goto label_76;}
//line 442
label_78:
//line 442
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("lval"));
//line 443
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("bin_op"), ___nl__6);
//line 443
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_val_priv(___nl__7,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 443
___nl__7 = null;
//line 443
___nl__6 = null;
//line 444
if (true) {goto label_76;}
//line 444
label_79:
//line 444
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("expr"));
//line 445
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_val_priv(___nl__6,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 445
___nl__6 = null;
//line 446
if (true) {goto label_76;}
//line 446
label_76:
//line 446
___nl__5 = null;
//line 446
___nl__4 = null;
//line 447
if (true) {goto label_3;}
//line 447
label_23:
//line 448
if (true) {goto label_3;}
//line 448
label_3:
//line 448
___nl__2 = null;
//line 448
___nl__3 = null;
//line 448
___nl__0 = null;
//line 448
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_check_lvalue_priv(Imm ___arg__0, ImmRef ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();
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
//line 451
___nl__2 = ___nl__0;
//line 451
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("var"));
//line 451
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 451
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 452
___nl__3 = ___nl__0;
//line 452
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("var"));
//line 452
___nl__4 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("mod"));
//line 452
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_use_var_priv(___nl__3,___nl__4,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 452
___nl__4 = null;
//line 452
___nl__3 = null;
//line 453
___nl__0 = null;
//line 453
___nl__2 = null;
//line 453
___arg__1.setValue(___nl__1);if(true) return null;
//line 454
if (true) {goto label_3;}
//line 454
label_2:
//line 454
___nl__2 = ___nl__0;
//line 454
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("bin_op"));
//line 454
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 454
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_3;}}
//line 455
___nl__3 = ___nl__0;
//line 455
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("bin_op"));
//line 456
___nl__4 = ((ImmHash)___nl__3).getHashValue()["op"];
//line 456
___nl__5 = new ImmString("->");
//line 456
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__4.toString().Equals(___nl__5.toString()));
//line 456
___nl__5 = null;
//line 456
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_6;}}
//line 456
___nl__4 = ((ImmHash)___nl__3).getHashValue()["op"];
//line 456
___nl__5 = new ImmString("ARRAY_INDEX");
//line 456
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__4.toString().Equals(___nl__5.toString()));
//line 456
___nl__5 = null;
//line 456
label_6:
//line 456
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 456
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_5;}}
//line 457
___nl__5 = ((ImmHash)___nl__3).getHashValue()["left"];
//line 457
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_lvalue_priv(___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 457
___nl__5 = null;
//line 458
___nl__5 = ((ImmHash)___nl__3).getHashValue()["right"];
//line 458
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_val_priv(___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 458
___nl__5 = null;
//line 459
___nl__0 = null;
//line 459
___nl__2 = null;
//line 459
___nl__3 = null;
//line 459
___nl__4 = null;
//line 459
___arg__1.setValue(___nl__1);if(true) return null;
//line 460
if (true) {goto label_5;}
//line 460
label_5:
//line 460
___nl__4 = null;
//line 460
___nl__3 = null;
//line 461
if (true) {goto label_3;}
//line 461
label_3:
//line 461
___nl__2 = null;
//line 462
___nl__2 = new ImmString("errors");
//line 462
___nl__2 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__2);

//line 462
___nl__3 = new ImmString("invalid expression for lvalue");
//line 462
___ref______nl__2 = new ImmRef(___nl__2);
module_checker_NL.NL_add_error_priv(___ref______nl__2,___nl__3);
___nl__2 = ___ref______nl__2.getValue();

//line 462
___nl__3 = null;
//line 462
___nl__3 = new ImmString("errors");
//line 462
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__3,___nl__2);
___nl__1 = ___ref______nl__1.getValue();

//line 462
___nl__3 = null;
//line 462
___nl__2 = null;
//line 462
___nl__0 = null;
//line 462
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_check_val_priv(Imm ___arg__0, ImmRef ___arg__1) {
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
Dictionary<String, Imm> __function_map;
//line 465
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("ternary_op"));
//line 465
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 469
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("parenthesis"));
//line 469
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_3;}}
//line 471
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("variant"));
//line 471
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_4;}}
//line 473
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("const"));
//line 473
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_5;}}
//line 474
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("string"));
//line 474
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_6;}}
//line 475
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("nop"));
//line 475
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_7;}}
//line 476
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("hash_key"));
//line 476
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_8;}}
//line 477
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("arr_decl"));
//line 477
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_9;}}
//line 481
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("hash_decl"));
//line 481
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_10;}}
//line 486
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("var"));
//line 486
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_11;}}
//line 488
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("bin_op"));
//line 488
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_12;}}
//line 500
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("var_op"));
//line 500
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_13;}}
//line 502
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("unary_op"));
//line 502
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_14;}}
//line 504
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("fun_label"));
//line 504
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_15;}}
//line 506
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("fun_val"));
//line 506
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_16;}}
//line 515
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("post_inc"));
//line 515
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_17;}}
//line 517
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("post_dec"));
//line 517
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_18;}}
//line 517
___nl__2 = new ImmString("NOMATCHALERT");
//line 517
___nl__2 = new ImmArray(new Imm[] {___nl__2,___nl__0,});
//line 517
c_rt_lib_NL.NL_die();
//line 465
label_2:
//line 465
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("ternary_op"));
//line 466
___nl__4 = ((ImmHash)___nl__3).getHashValue()["fst"];
//line 466
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_val_priv(___nl__4,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 466
___nl__4 = null;
//line 467
___nl__4 = ((ImmHash)___nl__3).getHashValue()["snd"];
//line 467
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_val_priv(___nl__4,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 467
___nl__4 = null;
//line 468
___nl__4 = ((ImmHash)___nl__3).getHashValue()["thrd"];
//line 468
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_val_priv(___nl__4,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 468
___nl__4 = null;
//line 468
___nl__3 = null;
//line 469
if (true) {goto label_1;}
//line 469
label_3:
//line 469
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("parenthesis"));
//line 470
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_val_priv(___nl__3,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 470
___nl__3 = null;
//line 471
if (true) {goto label_1;}
//line 471
label_4:
//line 471
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("variant"));
//line 472
___nl__4 = ((ImmHash)___nl__3).getHashValue()["var"];
//line 472
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_val_priv(___nl__4,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 472
___nl__4 = null;
//line 472
___nl__3 = null;
//line 473
if (true) {goto label_1;}
//line 473
label_5:
//line 473
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("const"));
//line 473
___nl__3 = null;
//line 474
if (true) {goto label_1;}
//line 474
label_6:
//line 474
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("string"));
//line 474
___nl__3 = null;
//line 475
if (true) {goto label_1;}
//line 475
label_7:
//line 476
if (true) {goto label_1;}
//line 476
label_8:
//line 476
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("hash_key"));
//line 476
___nl__3 = null;
//line 477
if (true) {goto label_1;}
//line 477
label_9:
//line 477
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("arr_decl"));
//line 478
___nl__5 = new ImmDouble(0);
//line 478
___nl__6 = new ImmDouble(1);
//line 478
___nl__7 = c_rt_lib_NL.NL_array_len(___nl__3);

//line 478
label_21:
//line 478
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) );
//line 478
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_19;}}
//line 478
___nl__4 = (___nl__3 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()];
//line 479
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_val_priv(___nl__4,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 480
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString())));
//line 480
if (true) {goto label_21;}
//line 480
label_19:
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
___nl__3 = null;
//line 481
if (true) {goto label_1;}
//line 481
label_10:
//line 481
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("hash_decl"));
//line 482
___nl__5 = new ImmDouble(0);
//line 482
___nl__6 = new ImmDouble(1);
//line 482
___nl__7 = c_rt_lib_NL.NL_array_len(___nl__3);

//line 482
label_24:
//line 482
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) );
//line 482
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_22;}}
//line 482
___nl__4 = (___nl__3 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()];
//line 483
___nl__9 = ((ImmHash)___nl__4).getHashValue()["key"];
//line 483
___nl__10 = new ImmString("hash_key");
//line 483
ov_NL.NL_as(___nl__9,___nl__10);

//line 483
___nl__10 = null;
//line 483
___nl__9 = null;
//line 484
___nl__9 = ((ImmHash)___nl__4).getHashValue()["val"];
//line 484
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_val_priv(___nl__9,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 484
___nl__9 = null;
//line 485
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString())));
//line 485
if (true) {goto label_24;}
//line 485
label_22:
//line 485
___nl__4 = null;
//line 485
___nl__5 = null;
//line 485
___nl__6 = null;
//line 485
___nl__7 = null;
//line 485
___nl__8 = null;
//line 485
___nl__3 = null;
//line 486
if (true) {goto label_1;}
//line 486
label_11:
//line 486
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("var"));
//line 487
___nl__4 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("get"));
//line 487
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_use_var_priv(___nl__3,___nl__4,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 487
___nl__4 = null;
//line 487
___nl__3 = null;
//line 488
if (true) {goto label_1;}
//line 488
label_12:
//line 488
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("bin_op"));
//line 489
___nl__4 = ((ImmHash)___nl__3).getHashValue()["op"];
//line 490
___nl__5 = new ImmString("=");
//line 490
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__4.toString().Equals(___nl__5.toString()));
//line 490
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_31;}}
//line 490
___nl__5 = new ImmString("+=");
//line 490
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__4.toString().Equals(___nl__5.toString()));
//line 490
label_31:
//line 490
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_30;}}
//line 490
___nl__5 = new ImmString("-=");
//line 490
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__4.toString().Equals(___nl__5.toString()));
//line 490
label_30:
//line 490
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_29;}}
//line 490
___nl__5 = new ImmString("*=");
//line 490
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__4.toString().Equals(___nl__5.toString()));
//line 490
label_29:
//line 490
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_28;}}
//line 490
___nl__5 = new ImmString("/=");
//line 490
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__4.toString().Equals(___nl__5.toString()));
//line 490
label_28:
//line 490
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_27;}}
//line 490
___nl__5 = new ImmString(".=");
//line 490
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__4.toString().Equals(___nl__5.toString()));
//line 490
label_27:
//line 490
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 490
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_26;}}
//line 491
___nl__6 = ((ImmHash)___nl__3).getHashValue()["left"];
//line 491
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("var"));
//line 491
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 491
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_34;}}
//line 491
___nl__6 = new ImmString("=");
//line 491
___nl__6 = c_rt_lib_NL.NL_native_to_nl(___nl__4.toString().Equals(___nl__6.toString()));
//line 491
label_34:
//line 491
___nl__7 = null;
//line 491
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 491
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_33;}}
//line 492
___nl__7 = ((ImmHash)___nl__3).getHashValue()["left"];
//line 492
___nl__7 = c_rt_lib_NL.NL_ov_as(___nl__7, new ImmString("var"));
//line 492
___nl__8 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("set"));
//line 492
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_use_var_priv(___nl__7,___nl__8,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 492
___nl__8 = null;
//line 492
___nl__7 = null;
//line 493
if (true) {goto label_32;}
//line 493
label_33:
//line 494
___nl__7 = ((ImmHash)___nl__3).getHashValue()["left"];
//line 494
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_lvalue_priv(___nl__7,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 494
___nl__7 = null;
//line 495
if (true) {goto label_32;}
//line 495
label_32:
//line 495
___nl__6 = null;
//line 496
if (true) {goto label_25;}
//line 496
label_26:
//line 497
___nl__6 = ((ImmHash)___nl__3).getHashValue()["left"];
//line 497
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_val_priv(___nl__6,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 497
___nl__6 = null;
//line 498
if (true) {goto label_25;}
//line 498
label_25:
//line 498
___nl__5 = null;
//line 499
___nl__5 = ((ImmHash)___nl__3).getHashValue()["right"];
//line 499
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_val_priv(___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 499
___nl__5 = null;
//line 499
___nl__4 = null;
//line 499
___nl__3 = null;
//line 500
if (true) {goto label_1;}
//line 500
label_13:
//line 500
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("var_op"));
//line 501
___nl__4 = ((ImmHash)___nl__3).getHashValue()["left"];
//line 501
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_val_priv(___nl__4,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 501
___nl__4 = null;
//line 501
___nl__3 = null;
//line 502
if (true) {goto label_1;}
//line 502
label_14:
//line 502
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("unary_op"));
//line 503
___nl__4 = ((ImmHash)___nl__3).getHashValue()["val"];
//line 503
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_val_priv(___nl__4,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 503
___nl__4 = null;
//line 503
___nl__3 = null;
//line 504
if (true) {goto label_1;}
//line 504
label_15:
//line 504
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("fun_label"));
//line 505
___nl__4 = ((ImmHash)___nl__3).getHashValue()["module"];
//line 505
___nl__5 = ((ImmHash)___nl__3).getHashValue()["name"];
//line 505
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_add_fun_used_priv(___nl__4,___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 505
___nl__5 = null;
//line 505
___nl__4 = null;
//line 505
___nl__3 = null;
//line 506
if (true) {goto label_1;}
//line 506
label_16:
//line 506
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("fun_val"));
//line 507
___nl__4 = ((ImmHash)___nl__3).getHashValue()["args"];
//line 507
___nl__6 = new ImmDouble(0);
//line 507
___nl__7 = new ImmDouble(1);
//line 507
___nl__8 = c_rt_lib_NL.NL_array_len(___nl__4);

//line 507
label_37:
//line 507
___nl__9 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__6.getValue().ToString()))>=(Double.Parse(___nl__8.getValue().ToString())) );
//line 507
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_35;}}
//line 507
___nl__5 = (___nl__4 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()];
//line 508
___nl__10 = ((ImmHash)___nl__5).getHashValue()["mod"];
//line 508
___nl__11 = c_rt_lib_NL.NL_ov_is(___nl__10, new ImmString("none"));
//line 508
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_39;}}
//line 510
___nl__11 = c_rt_lib_NL.NL_ov_is(___nl__10, new ImmString("ref"));
//line 510
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_40;}}
//line 510
___nl__11 = new ImmString("NOMATCHALERT");
//line 510
___nl__11 = new ImmArray(new Imm[] {___nl__11,___nl__10,});
//line 510
c_rt_lib_NL.NL_die();
//line 508
label_39:
//line 509
___nl__12 = ((ImmHash)___nl__5).getHashValue()["val"];
//line 509
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_val_priv(___nl__12,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 509
___nl__12 = null;
//line 510
if (true) {goto label_38;}
//line 510
label_40:
//line 511
___nl__12 = ((ImmHash)___nl__5).getHashValue()["val"];
//line 511
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_lvalue_priv(___nl__12,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 511
___nl__12 = null;
//line 512
if (true) {goto label_38;}
//line 512
label_38:
//line 512
___nl__10 = null;
//line 512
___nl__11 = null;
//line 513
___nl__6 = new ImmDouble((Double.Parse(___nl__6.getValue().ToString()))+(Double.Parse(___nl__7.getValue().ToString())));
//line 513
if (true) {goto label_37;}
//line 513
label_35:
//line 513
___nl__4 = null;
//line 513
___nl__5 = null;
//line 513
___nl__6 = null;
//line 513
___nl__7 = null;
//line 513
___nl__8 = null;
//line 513
___nl__9 = null;
//line 514
___nl__4 = ((ImmHash)___nl__3).getHashValue()["module"];
//line 514
___nl__5 = ((ImmHash)___nl__3).getHashValue()["name"];
//line 514
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_add_fun_used_priv(___nl__4,___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 514
___nl__5 = null;
//line 514
___nl__4 = null;
//line 514
___nl__3 = null;
//line 515
if (true) {goto label_1;}
//line 515
label_17:
//line 515
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("post_inc"));
//line 516
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_val_priv(___nl__3,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 516
___nl__3 = null;
//line 517
if (true) {goto label_1;}
//line 517
label_18:
//line 517
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("post_dec"));
//line 518
___ref______nl__1 = new ImmRef(___nl__1);
module_checker_NL.NL_check_val_priv(___nl__3,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 518
___nl__3 = null;
//line 519
if (true) {goto label_1;}
//line 519
label_1:
//line 519
___nl__2 = null;
//line 519
___nl__0 = null;
//line 519
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_save_block_priv(ImmRef ___arg__0) {
Imm ___nl__0 = ___arg__0.getValue().clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 522
___nl__2 = ((ImmHash)___nl__0).getHashValue()["in_loop"];
//line 522
___nl__3 = ((ImmHash)___nl__0).getHashValue()["vars"];
//line 522
__function_map = new Dictionary<String, Imm>();
__function_map.Add("in_loop",___nl__2);
__function_map.Add("vars",___nl__3);
___nl__1 = new ImmHash(__function_map);
//line 522
___nl__2 = null;
//line 522
___nl__3 = null;
//line 522
___arg__0.setValue(___nl__0);if(true) return ___nl__1;
//line 522
___nl__1 = null;
//line 522
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_load_block_priv(ImmRef ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.clone();
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
Dictionary<String, Imm> __function_map;
//line 525
___nl__2 = ((ImmHash)___nl__1).getHashValue()["in_loop"];
//line 525
___nl__3 = ___nl__2;
//line 525
((ImmHash)___nl__0).set("in_loop", ___nl__3);
//line 525
___nl__2 = null;
//line 525
___nl__3 = null;
//line 526
___nl__3 = ((ImmHash)___nl__0).getHashValue()["vars"];
//line 526
___nl__2 = hash_NL.NL_keys(___nl__3);

//line 526
___nl__3 = null;
//line 527
___nl__4 = new ImmDouble(0);
//line 527
___nl__5 = new ImmDouble(1);
//line 527
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__2);

//line 527
label_3:
//line 527
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) );
//line 527
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_1;}}
//line 527
___nl__3 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()];
//line 528
___nl__9 = ((ImmHash)___nl__1).getHashValue()["vars"];
//line 528
___nl__8 = hash_NL.NL_has_key(___nl__9,___nl__3);

//line 528
___nl__9 = null;
//line 528
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8));
//line 528
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8));
//line 528
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_5;}}
//line 529
___nl__10 = ((ImmHash)___nl__0).getHashValue()["vars"];
//line 529
___nl__9 = hash_NL.NL_get_value(___nl__10,___nl__3);

//line 529
___nl__10 = null;
//line 530
___nl__10 = new ImmString("vars");
//line 530
___nl__10 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__10);

//line 530
___ref______nl__10 = new ImmRef(___nl__10);
hash_NL.NL_delete(___ref______nl__10,___nl__3);
___nl__10 = ___ref______nl__10.getValue();

//line 530
___nl__11 = new ImmString("vars");
//line 530
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__11,___nl__10);
___nl__0 = ___ref______nl__0.getValue();

//line 530
___nl__11 = null;
//line 530
___nl__10 = null;
//line 531
___nl__10 = ((ImmHash)___nl__9).getHashValue()["read"];
//line 531
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10));
//line 531
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10));
//line 531
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_8;}}
//line 531
___nl__10 = ((ImmHash)___nl__9).getHashValue()["is_required"];
//line 531
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10));
//line 531
label_8:
//line 531
___nl__11 = null;
//line 531
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10));
//line 531
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_7;}}
//line 532
___nl__11 = new ImmString("errors");
//line 532
___nl__11 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__11);

//line 532
___nl__12 = new ImmString("never read variable: ");
//line 532
___nl__12 = new ImmString(___nl__12.toString() + ___nl__3.toString());
//line 532
___ref______nl__11 = new ImmRef(___nl__11);
module_checker_NL.NL_add_warning_priv(___ref______nl__11,___nl__12);
___nl__11 = ___ref______nl__11.getValue();

//line 532
___nl__12 = null;
//line 532
___nl__12 = new ImmString("errors");
//line 532
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__12,___nl__11);
___nl__0 = ___ref______nl__0.getValue();

//line 532
___nl__12 = null;
//line 532
___nl__11 = null;
//line 533
if (true) {goto label_7;}
//line 533
label_7:
//line 533
___nl__10 = null;
//line 533
___nl__9 = null;
//line 534
if (true) {goto label_5;}
//line 534
label_5:
//line 534
___nl__8 = null;
//line 535
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString())));
//line 535
if (true) {goto label_3;}
//line 535
label_1:
//line 535
___nl__3 = null;
//line 535
___nl__4 = null;
//line 535
___nl__5 = null;
//line 535
___nl__6 = null;
//line 535
___nl__7 = null;
//line 535
___nl__2 = null;
//line 535
___nl__1 = null;
//line 535
___arg__0.setValue(___nl__0);if(true) return null;
}

}
}