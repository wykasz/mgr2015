using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class post_processing_NL {

public static Imm NL_SINGLETON_fun_tree_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 17
___nl__4 = ptd_NL.NL_sim().clone();

//line 17
___nl__3 = ptd_NL.NL_arr(___nl__4).clone();

//line 17
___nl__4 = null;
//line 17
___nl__2 = ptd_NL.NL_hash(___nl__3).clone();

//line 17
___nl__3 = null;
//line 17
___nl__1 = ptd_NL.NL_hash(___nl__2).clone();

//line 17
___nl__2 = null;
//line 17
___nl__0 = ptd_NL.NL_hash(___nl__1).clone();

//line 17
___nl__1 = null;
//line 17
if(true) return ___nl__0;
//line 17
___nl__0 = null;
//line 17
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_fun_tree_t = null;
public static Imm NL_fun_tree_t() {
	if (value__singleton__NL_SINGLETON_fun_tree_t == null) {
		value__singleton__NL_SINGLETON_fun_tree_t = NL_SINGLETON_fun_tree_t();
	}
	return value__singleton__NL_SINGLETON_fun_tree_t;
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
Dictionary<String, Imm> __function_map;
//line 20
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("result_t"));
___nl__3 = new ImmHash(__function_map).clone();
//line 20
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3).clone();
//line 20
___nl__2 = ptd_NL.NL_hash(___nl__3).clone();

//line 20
___nl__3 = null;
//line 20
___nl__4 = ptd_NL.NL_sim().clone();

//line 20
___nl__3 = ptd_NL.NL_hash(___nl__4).clone();

//line 20
___nl__4 = null;
//line 20
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("post_processing_NL"));
__function_map.Add("name",new ImmString("math_funs_t"));
___nl__4 = new ImmHash(__function_map).clone();
//line 20
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__4).clone();
//line 20
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("post_processing_NL"));
__function_map.Add("name",new ImmString("fun_tree_t"));
___nl__5 = new ImmHash(__function_map).clone();
//line 20
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__5).clone();
//line 20
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("post_processing_NL"));
__function_map.Add("name",new ImmString("math_funs_t"));
___nl__6 = new ImmHash(__function_map).clone();
//line 20
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__6).clone();
//line 20
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("post_processing_NL"));
__function_map.Add("name",new ImmString("optimization_t"));
___nl__7 = new ImmHash(__function_map).clone();
//line 20
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__7).clone();
//line 20
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("interpreter_NL"));
__function_map.Add("name",new ImmString("state_t"));
___nl__8 = new ImmHash(__function_map).clone();
//line 20
___nl__8 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__8).clone();
//line 20
__function_map = new Dictionary<String, Imm>();
__function_map.Add("nl_asm",___nl__2);
__function_map.Add("mat_fun_def",___nl__3);
__function_map.Add("math_fs",___nl__4);
__function_map.Add("fun_calls",___nl__5);
__function_map.Add("const_com",___nl__6);
__function_map.Add("optimization",___nl__7);
__function_map.Add("interpreter_state",___nl__8);
___nl__1 = new ImmHash(__function_map).clone();
//line 20
___nl__2 = null;
//line 20
___nl__3 = null;
//line 20
___nl__4 = null;
//line 20
___nl__5 = null;
//line 20
___nl__6 = null;
//line 20
___nl__7 = null;
//line 20
___nl__8 = null;
//line 20
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 20
___nl__1 = null;
//line 20
if(true) return ___nl__0;
//line 20
___nl__0 = null;
//line 20
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_state_t = null;
public static Imm NL_state_t() {
	if (value__singleton__NL_SINGLETON_state_t == null) {
		value__singleton__NL_SINGLETON_state_t = NL_SINGLETON_state_t();
	}
	return value__singleton__NL_SINGLETON_state_t;
}
public static Imm NL_SINGLETON_math_funs_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 31
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("boolean_t_NL"));
__function_map.Add("name",new ImmString("type"));
___nl__1 = new ImmHash(__function_map).clone();
//line 31
___nl__1 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__1).clone();
//line 31
___nl__0 = ptd_NL.NL_hash(___nl__1).clone();

//line 31
___nl__1 = null;
//line 31
if(true) return ___nl__0;
//line 31
___nl__0 = null;
//line 31
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_math_funs_t = null;
public static Imm NL_math_funs_t() {
	if (value__singleton__NL_SINGLETON_math_funs_t == null) {
		value__singleton__NL_SINGLETON_math_funs_t = NL_SINGLETON_math_funs_t();
	}
	return value__singleton__NL_SINGLETON_math_funs_t;
}
public static Imm NL_SINGLETON_reg_const() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 34
___nl__2 = ptd_NL.NL_none().clone();

//line 34
___nl__3 = ptd_NL.NL_sim().clone();

//line 34
__function_map = new Dictionary<String, Imm>();
__function_map.Add("no",___nl__2);
__function_map.Add("yes",___nl__3);
___nl__1 = new ImmHash(__function_map).clone();
//line 34
___nl__2 = null;
//line 34
___nl__3 = null;
//line 34
___nl__0 = ptd_NL.NL_var(___nl__1).clone();

//line 34
___nl__1 = null;
//line 34
if(true) return ___nl__0;
//line 34
___nl__0 = null;
//line 34
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_reg_const = null;
public static Imm NL_reg_const() {
	if (value__singleton__NL_SINGLETON_reg_const == null) {
		value__singleton__NL_SINGLETON_reg_const = NL_SINGLETON_reg_const();
	}
	return value__singleton__NL_SINGLETON_reg_const;
}
public static Imm NL_SINGLETON_reg_val_const() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Dictionary<String, Imm> __function_map;
//line 37
___nl__2 = ptd_NL.NL_none().clone();

//line 37
___nl__5 = ptd_NL.NL_sim().clone();

//line 37
___nl__6 = ptd_NL.NL_ptd_im().clone();

//line 37
__function_map = new Dictionary<String, Imm>();
__function_map.Add("nr",___nl__5);
__function_map.Add("value",___nl__6);
___nl__4 = new ImmHash(__function_map).clone();
//line 37
___nl__5 = null;
//line 37
___nl__6 = null;
//line 37
___nl__3 = ptd_NL.NL_rec(___nl__4).clone();

//line 37
___nl__4 = null;
//line 37
__function_map = new Dictionary<String, Imm>();
__function_map.Add("no",___nl__2);
__function_map.Add("yes",___nl__3);
___nl__1 = new ImmHash(__function_map).clone();
//line 37
___nl__2 = null;
//line 37
___nl__3 = null;
//line 37
___nl__0 = ptd_NL.NL_var(___nl__1).clone();

//line 37
___nl__1 = null;
//line 37
if(true) return ___nl__0;
//line 37
___nl__0 = null;
//line 37
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_reg_val_const = null;
public static Imm NL_reg_val_const() {
	if (value__singleton__NL_SINGLETON_reg_val_const == null) {
		value__singleton__NL_SINGLETON_reg_val_const = NL_SINGLETON_reg_val_const();
	}
	return value__singleton__NL_SINGLETON_reg_val_const;
}
public static Imm NL_SINGLETON_optimization_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Dictionary<String, Imm> __function_map;
//line 46
___nl__2 = ptd_NL.NL_none().clone();

//line 46
___nl__3 = ptd_NL.NL_none().clone();

//line 46
___nl__4 = ptd_NL.NL_none().clone();

//line 46
___nl__5 = ptd_NL.NL_none().clone();

//line 46
___nl__6 = ptd_NL.NL_none().clone();

//line 46
__function_map = new Dictionary<String, Imm>();
__function_map.Add("o0",___nl__2);
__function_map.Add("o1",___nl__3);
__function_map.Add("o2",___nl__4);
__function_map.Add("o3",___nl__5);
__function_map.Add("o4",___nl__6);
___nl__1 = new ImmHash(__function_map).clone();
//line 46
___nl__2 = null;
//line 46
___nl__3 = null;
//line 46
___nl__4 = null;
//line 46
___nl__5 = null;
//line 46
___nl__6 = null;
//line 46
___nl__0 = ptd_NL.NL_var(___nl__1).clone();

//line 46
___nl__1 = null;
//line 46
if(true) return ___nl__0;
//line 46
___nl__0 = null;
//line 46
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_optimization_t = null;
public static Imm NL_optimization_t() {
	if (value__singleton__NL_SINGLETON_optimization_t == null) {
		value__singleton__NL_SINGLETON_optimization_t = NL_SINGLETON_optimization_t();
	}
	return value__singleton__NL_SINGLETON_optimization_t;
}
public static Imm NL_SINGLETON_const_reg_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 49
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("post_processing_NL"));
__function_map.Add("name",new ImmString("reg_const"));
___nl__4 = new ImmHash(__function_map).clone();
//line 49
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__4).clone();
//line 49
___nl__3 = ptd_NL.NL_arr(___nl__4).clone();

//line 49
___nl__4 = null;
//line 49
___nl__4 = ptd_NL.NL_sim().clone();

//line 49
__function_map = new Dictionary<String, Imm>();
__function_map.Add("regs",___nl__3);
__function_map.Add("was",___nl__4);
___nl__2 = new ImmHash(__function_map).clone();
//line 49
___nl__3 = null;
//line 49
___nl__4 = null;
//line 49
___nl__1 = ptd_NL.NL_rec(___nl__2).clone();

//line 49
___nl__2 = null;
//line 49
___nl__0 = ptd_NL.NL_arr(___nl__1).clone();

//line 49
___nl__1 = null;
//line 49
if(true) return ___nl__0;
//line 49
___nl__0 = null;
//line 49
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_const_reg_t = null;
public static Imm NL_const_reg_t() {
	if (value__singleton__NL_SINGLETON_const_reg_t == null) {
		value__singleton__NL_SINGLETON_const_reg_t = NL_SINGLETON_const_reg_t();
	}
	return value__singleton__NL_SINGLETON_const_reg_t;
}
public static Imm NL_SINGLETON_const_reg_val_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 52
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("post_processing_NL"));
__function_map.Add("name",new ImmString("reg_val_const"));
___nl__4 = new ImmHash(__function_map).clone();
//line 52
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__4).clone();
//line 52
___nl__3 = ptd_NL.NL_arr(___nl__4).clone();

//line 52
___nl__4 = null;
//line 52
___nl__4 = ptd_NL.NL_sim().clone();

//line 52
__function_map = new Dictionary<String, Imm>();
__function_map.Add("regs",___nl__3);
__function_map.Add("was",___nl__4);
___nl__2 = new ImmHash(__function_map).clone();
//line 52
___nl__3 = null;
//line 52
___nl__4 = null;
//line 52
___nl__1 = ptd_NL.NL_rec(___nl__2).clone();

//line 52
___nl__2 = null;
//line 52
___nl__0 = ptd_NL.NL_arr(___nl__1).clone();

//line 52
___nl__1 = null;
//line 52
if(true) return ___nl__0;
//line 52
___nl__0 = null;
//line 52
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_const_reg_val_t = null;
public static Imm NL_const_reg_val_t() {
	if (value__singleton__NL_SINGLETON_const_reg_val_t == null) {
		value__singleton__NL_SINGLETON_const_reg_val_t = NL_SINGLETON_const_reg_val_t();
	}
	return value__singleton__NL_SINGLETON_const_reg_val_t;
}
private static Imm NL_SINGLETON_get_command_for_const_priv() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 61
__function_map = new Dictionary<String, Imm>();
___nl__0 = new ImmHash(__function_map).clone();
//line 62
___nl__1 = new ImmString("arr_decl").clone();
//line 62
___nl__2 = c_rt_lib_NL.NL_get_true().clone();
//line 62
hash_NL.NL_set_value(ref ___nl__0,___nl__1,___nl__2);

//line 62
___nl__2 = null;
//line 62
___nl__1 = null;
//line 63
___nl__1 = new ImmString("hash_decl").clone();
//line 63
___nl__2 = c_rt_lib_NL.NL_get_true().clone();
//line 63
hash_NL.NL_set_value(ref ___nl__0,___nl__1,___nl__2);

//line 63
___nl__2 = null;
//line 63
___nl__1 = null;
//line 64
___nl__1 = new ImmString("func").clone();
//line 64
___nl__2 = c_rt_lib_NL.NL_get_true().clone();
//line 64
hash_NL.NL_set_value(ref ___nl__0,___nl__1,___nl__2);

//line 64
___nl__2 = null;
//line 64
___nl__1 = null;
//line 65
___nl__1 = new ImmString("load_const").clone();
//line 65
___nl__2 = c_rt_lib_NL.NL_get_true().clone();
//line 65
hash_NL.NL_set_value(ref ___nl__0,___nl__1,___nl__2);

//line 65
___nl__2 = null;
//line 65
___nl__1 = null;
//line 75
___nl__1 = new ImmString("ov_mk").clone();
//line 75
___nl__2 = c_rt_lib_NL.NL_get_true().clone();
//line 75
hash_NL.NL_set_value(ref ___nl__0,___nl__1,___nl__2);

//line 75
___nl__2 = null;
//line 75
___nl__1 = null;
//line 76
if(true) return ___nl__0;
//line 76
___nl__0 = null;
//line 76
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_get_command_for_const_priv = null;
private static Imm NL_get_command_for_const_priv() {
	if (value__singleton__NL_SINGLETON_get_command_for_const_priv == null) {
		value__singleton__NL_SINGLETON_get_command_for_const_priv = NL_SINGLETON_get_command_for_const_priv();
	}
	return value__singleton__NL_SINGLETON_get_command_for_const_priv;
}
public static Imm NL_init(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Dictionary<String, Imm> __function_map;
//line 80
__function_map = new Dictionary<String, Imm>();
___nl__3 = new ImmHash(__function_map).clone();
//line 80
__function_map = new Dictionary<String, Imm>();
___nl__4 = new ImmHash(__function_map).clone();
//line 80
__function_map = new Dictionary<String, Imm>();
___nl__5 = new ImmHash(__function_map).clone();
//line 80
__function_map = new Dictionary<String, Imm>();
__function_map.Add("nl_asm",___nl__3);
__function_map.Add("fun_calls",___nl__4);
__function_map.Add("math_fs",___nl__5);
___nl__2 = new ImmHash(__function_map).clone();
//line 80
___nl__3 = null;
//line 80
___nl__4 = null;
//line 80
___nl__5 = null;
//line 81
___nl__3 = ___nl__0.clone();
//line 81
((ImmHash)___nl__2).set("mat_fun_def", ___nl__3);
//line 81
___nl__3 = null;
//line 82
___nl__3 = ___nl__1.clone();
//line 82
((ImmHash)___nl__2).set("optimization", ___nl__3);
//line 82
___nl__3 = null;
//line 83
___nl__3 = post_processing_NL.NL_get_command_for_const_priv().clone();

//line 83
___nl__4 = ___nl__3.clone();
//line 83
((ImmHash)___nl__2).set("const_com", ___nl__4);
//line 83
___nl__3 = null;
//line 83
___nl__4 = null;
//line 84
___nl__4 = new ImmArray(new Imm[0]).clone();
//line 84
__function_map = new Dictionary<String, Imm>();
___nl__5 = new ImmHash(__function_map).clone();
//line 84
___nl__3 = interpreter_NL.NL_init(___nl__4,___nl__5).clone();

//line 84
___nl__5 = null;
//line 84
___nl__4 = null;
//line 84
___nl__4 = ___nl__3.clone();
//line 84
((ImmHash)___nl__2).set("interpreter_state", ___nl__4);
//line 84
___nl__3 = null;
//line 84
___nl__4 = null;
//line 85
___nl__0 = null;
//line 85
___nl__1 = null;
//line 85
if(true) return ___nl__2;
//line 85
___nl__2 = null;
//line 85
___nl__0 = null;
//line 85
___nl__1 = null;
//line 85
if(true) return null;
}

public static Imm NL_clear_module_from_state(ref Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0;Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 88
___nl__2 = new ImmString("nl_asm").clone();
//line 88
___nl__2 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__2).clone();

//line 88
hash_NL.NL_delete(ref ___nl__2,___nl__1);

//line 88
___nl__3 = new ImmString("nl_asm").clone();
//line 88
c_rt_lib_NL.NL_set_ref_hash(ref ___nl__0,___nl__3,___nl__2);

//line 88
___nl__3 = null;
//line 88
___nl__2 = null;
//line 89
___nl__2 = new ImmString("fun_calls").clone();
//line 89
___nl__2 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__2).clone();

//line 89
hash_NL.NL_delete(ref ___nl__2,___nl__1);

//line 89
___nl__3 = new ImmString("fun_calls").clone();
//line 89
c_rt_lib_NL.NL_set_ref_hash(ref ___nl__0,___nl__3,___nl__2);

//line 89
___nl__3 = null;
//line 89
___nl__2 = null;
//line 89
___nl__1 = null;
//line 89
___arg__0 = ___nl__0;if(true) return null;
}

private static Imm NL_delete_unused_labels_priv(ref Imm ___arg__0) {
Imm ___nl__0 = ___arg__0;
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
//line 92
__function_map = new Dictionary<String, Imm>();
___nl__1 = new ImmHash(__function_map).clone();
//line 93
___nl__4 = c_rt_lib_NL.NL_init_iter(___nl__0).clone();

//line 93
label_3:
//line 93
___nl__2 = c_rt_lib_NL.NL_is_end_hash(___nl__4).clone();

//line 93
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_1;}}
//line 93
___nl__2 = c_rt_lib_NL.NL_get_key_iter(___nl__4).clone();

//line 93
___nl__3 = c_rt_lib_NL.NL_hash_get_value(___nl__0,___nl__2).clone();

//line 94
___nl__5 = ___nl__3.clone();
//line 95
___nl__7 = ((ImmHash)___nl__5).getHashValue()["functions"].clone();
//line 95
___nl__6 = array_NL.NL_len(___nl__7).clone();

//line 95
___nl__7 = null;
//line 95
___nl__7 = new ImmDouble(0).clone();
//line 95
___nl__8 = new ImmDouble(1).clone();
//line 95
label_6:
//line 95
___nl__9 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) ).clone();
//line 95
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_4;}}
//line 96
___nl__10 = new ImmString("functions").clone();
//line 96
___nl__10 = c_rt_lib_NL.NL_get_ref_hash(___nl__5,___nl__10).clone();

//line 96
___nl__11 = c_rt_lib_NL.NL_get_ref_arr(___nl__10,___nl__7).clone();

//line 96
___nl__12 = new ImmString("commands").clone();
//line 96
___nl__12 = c_rt_lib_NL.NL_get_ref_hash(___nl__11,___nl__12).clone();

//line 96
post_processing_NL.NL_delete_unused_labels_com_priv(ref ___nl__12);

//line 96
___nl__13 = new ImmString("commands").clone();
//line 96
c_rt_lib_NL.NL_set_ref_hash(ref ___nl__11,___nl__13,___nl__12);

//line 96
c_rt_lib_NL.NL_set_ref_arr(ref ___nl__10,___nl__7,___nl__11);

//line 96
___nl__13 = new ImmString("functions").clone();
//line 96
c_rt_lib_NL.NL_set_ref_hash(ref ___nl__5,___nl__13,___nl__10);

//line 96
___nl__13 = null;
//line 96
___nl__10 = null;
//line 96
___nl__11 = null;
//line 96
___nl__12 = null;
//line 97
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString()))).clone();
//line 97
if (true) {goto label_6;}
//line 97
label_4:
//line 97
___nl__6 = null;
//line 97
___nl__7 = null;
//line 97
___nl__8 = null;
//line 97
___nl__9 = null;
//line 98
hash_NL.NL_set_value(ref ___nl__1,___nl__2,___nl__5);

//line 98
___nl__5 = null;
//line 99
___nl__4 = c_rt_lib_NL.NL_next_iter(___nl__4).clone();

//line 99
if (true) {goto label_3;}
//line 99
label_1:
//line 99
___nl__2 = null;
//line 99
___nl__3 = null;
//line 99
___nl__4 = null;
//line 100
___nl__0 = ___nl__1.clone();
//line 100
___nl__1 = null;
//line 100
___arg__0 = ___nl__0;if(true) return null;
}

private static Imm NL_delete_unnecessary_commands_priv(ref Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0;Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);
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
Dictionary<String, Imm> __function_map;
//line 103
__function_map = new Dictionary<String, Imm>();
___nl__2 = new ImmHash(__function_map).clone();
//line 104
___nl__5 = c_rt_lib_NL.NL_init_iter(___nl__0).clone();

//line 104
label_3:
//line 104
___nl__3 = c_rt_lib_NL.NL_is_end_hash(___nl__5).clone();

//line 104
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_1;}}
//line 104
___nl__3 = c_rt_lib_NL.NL_get_key_iter(___nl__5).clone();

//line 104
___nl__4 = c_rt_lib_NL.NL_hash_get_value(___nl__0,___nl__3).clone();

//line 105
___nl__6 = ___nl__4.clone();
//line 106
___nl__8 = ((ImmHash)___nl__6).getHashValue()["functions"].clone();
//line 106
___nl__7 = array_NL.NL_len(___nl__8).clone();

//line 106
___nl__8 = null;
//line 106
___nl__8 = new ImmDouble(0).clone();
//line 106
___nl__9 = new ImmDouble(1).clone();
//line 106
label_6:
//line 106
___nl__10 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) ).clone();
//line 106
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_4;}}
//line 107
___nl__11 = ((ImmHash)___nl__6).getHashValue()["functions"].clone();
//line 107
___nl__11 = (___nl__11 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()].clone();
//line 108
___nl__12 = ((ImmHash)___nl__4).getHashValue()["module_name"].clone();
//line 108
___nl__13 = ((ImmHash)___nl__11).getHashValue()["access"].clone();
//line 108
___nl__13 = c_rt_lib_NL.NL_ov_is(___nl__13, new ImmString("pub")).clone();
//line 108
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_8;}}
//line 108
___nl__13 = new ImmString("_priv::").clone();
//line 108
if (true) {goto label_7;}
//line 108
label_8:
//line 108
___nl__13 = new ImmString("::").clone();
//line 108
label_7:
//line 108
___nl__12 = new ImmString(___nl__12.toString() + ___nl__13.toString()).clone();
//line 108
___nl__13 = null;
//line 108
___nl__13 = ((ImmHash)___nl__11).getHashValue()["name"].clone();
//line 108
___nl__12 = new ImmString(___nl__12.toString() + ___nl__13.toString()).clone();
//line 108
___nl__13 = null;
//line 109
___nl__13 = hash_NL.NL_has_key(___nl__1,___nl__12).clone();

//line 109
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13)).clone();
//line 109
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_10;}}
//line 110
___nl__14 = new ImmString("functions").clone();
//line 110
___nl__14 = c_rt_lib_NL.NL_get_ref_hash(___nl__6,___nl__14).clone();

//line 110
___nl__15 = c_rt_lib_NL.NL_get_ref_arr(___nl__14,___nl__8).clone();

//line 110
unnecessary_commands_NL.NL_delete_unnecessary_commands(ref ___nl__15);

//line 110
c_rt_lib_NL.NL_set_ref_arr(ref ___nl__14,___nl__8,___nl__15);

//line 110
___nl__16 = new ImmString("functions").clone();
//line 110
c_rt_lib_NL.NL_set_ref_hash(ref ___nl__6,___nl__16,___nl__14);

//line 110
___nl__16 = null;
//line 110
___nl__14 = null;
//line 110
___nl__15 = null;
//line 111
if (true) {goto label_10;}
//line 111
label_10:
//line 111
___nl__13 = null;
//line 111
___nl__11 = null;
//line 111
___nl__12 = null;
//line 112
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))+(Double.Parse(___nl__9.getValue().ToString()))).clone();
//line 112
if (true) {goto label_6;}
//line 112
label_4:
//line 112
___nl__7 = null;
//line 112
___nl__8 = null;
//line 112
___nl__9 = null;
//line 112
___nl__10 = null;
//line 113
hash_NL.NL_set_value(ref ___nl__2,___nl__3,___nl__6);

//line 113
___nl__6 = null;
//line 114
___nl__5 = c_rt_lib_NL.NL_next_iter(___nl__5).clone();

//line 114
if (true) {goto label_3;}
//line 114
label_1:
//line 114
___nl__3 = null;
//line 114
___nl__4 = null;
//line 114
___nl__5 = null;
//line 115
___nl__0 = ___nl__2.clone();
//line 115
___nl__2 = null;
//line 115
___nl__1 = null;
//line 115
___arg__0 = ___nl__0;if(true) return null;
}

public static Imm NL_find(ref Imm ___arg__0, ref Imm ___arg__1) {
Imm ___nl__0 = ___arg__0;Imm ___nl__1 = ___arg__1;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Dictionary<String, Imm> __function_map;
//line 119
post_processing_NL.NL_delete_unused_labels_priv(ref ___nl__1);

//line 120
___nl__2 = ((ImmHash)___nl__0).getHashValue()["optimization"].clone();
//line 120
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("o0")).clone();
//line 120
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 120
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 120
___nl__2 = null;
//line 120
___arg__0 = ___nl__0;___arg__1 = ___nl__1;if(true) return null;
//line 120
if (true) {goto label_2;}
//line 120
label_2:
//line 120
___nl__2 = null;
//line 122
___nl__2 = new ImmString("fun_calls").clone();
//line 122
___nl__2 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__2).clone();

//line 122
post_processing_NL.NL_set_function_calls_priv(ref ___nl__2,___nl__1);

//line 122
___nl__3 = new ImmString("fun_calls").clone();
//line 122
c_rt_lib_NL.NL_set_ref_hash(ref ___nl__0,___nl__3,___nl__2);

//line 122
___nl__3 = null;
//line 122
___nl__2 = null;
//line 123
___nl__3 = ((ImmHash)___nl__0).getHashValue()["fun_calls"].clone();
//line 123
___nl__4 = ((ImmHash)___nl__0).getHashValue()["mat_fun_def"].clone();
//line 123
___nl__2 = post_processing_NL.NL_get_math_fun_priv(___nl__3,___nl__4).clone();

//line 123
___nl__4 = null;
//line 123
___nl__3 = null;
//line 125
___nl__5 = c_rt_lib_NL.NL_init_iter(___nl__1).clone();

//line 125
label_5:
//line 125
___nl__3 = c_rt_lib_NL.NL_is_end_hash(___nl__5).clone();

//line 125
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 125
___nl__3 = c_rt_lib_NL.NL_get_key_iter(___nl__5).clone();

//line 125
___nl__4 = c_rt_lib_NL.NL_hash_get_value(___nl__1,___nl__3).clone();

//line 126
___nl__6 = new ImmString("nl_asm").clone();
//line 126
___nl__6 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__6).clone();

//line 126
hash_NL.NL_set_value(ref ___nl__6,___nl__3,___nl__4);

//line 126
___nl__7 = new ImmString("nl_asm").clone();
//line 126
c_rt_lib_NL.NL_set_ref_hash(ref ___nl__0,___nl__7,___nl__6);

//line 126
___nl__7 = null;
//line 126
___nl__6 = null;
//line 127
___nl__5 = c_rt_lib_NL.NL_next_iter(___nl__5).clone();

//line 127
if (true) {goto label_5;}
//line 127
label_3:
//line 127
___nl__3 = null;
//line 127
___nl__4 = null;
//line 127
___nl__5 = null;
//line 128
__function_map = new Dictionary<String, Imm>();
___nl__3 = new ImmHash(__function_map).clone();
//line 129
___nl__4 = ((ImmHash)___nl__0).getHashValue()["optimization"].clone();
//line 129
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("o0")).clone();
//line 129
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_7;}}
//line 130
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("o1")).clone();
//line 130
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_8;}}
//line 132
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("o2")).clone();
//line 132
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_9;}}
//line 135
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("o3")).clone();
//line 135
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_10;}}
//line 139
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("o4")).clone();
//line 139
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_11;}}
//line 139
___nl__5 = new ImmString("NOMATCHALERT").clone();
//line 139
___nl__5 = new ImmArray(new Imm[] {___nl__5,___nl__4,}).clone();
//line 139
c_rt_lib_NL.NL_die();
//line 129
label_7:
//line 130
if (true) {goto label_6;}
//line 130
label_8:
//line 131
post_processing_NL.NL_set_mathfun_in_modules_priv(ref ___nl__0,___nl__2,ref ___nl__3,ref ___nl__1);

//line 132
if (true) {goto label_6;}
//line 132
label_9:
//line 133
post_processing_NL.NL_set_mathfun_in_modules_priv(ref ___nl__0,___nl__2,ref ___nl__3,ref ___nl__1);

//line 134
___nl__6 = ((ImmHash)___nl__0).getHashValue()["const_com"].clone();
//line 134
post_processing_NL.NL_set_const_commands_in_modules_priv(ref ___nl__0,___nl__3,ref ___nl__1,___nl__6,___nl__2);

//line 134
___nl__6 = null;
//line 135
if (true) {goto label_6;}
//line 135
label_10:
//line 136
post_processing_NL.NL_set_mathfun_in_modules_priv(ref ___nl__0,___nl__2,ref ___nl__3,ref ___nl__1);

//line 137
___nl__6 = ((ImmHash)___nl__0).getHashValue()["const_com"].clone();
//line 137
post_processing_NL.NL_set_const_commands_in_modules_priv(ref ___nl__0,___nl__3,ref ___nl__1,___nl__6,___nl__2);

//line 137
___nl__6 = null;
//line 138
post_processing_NL.NL_delete_unnecessary_commands_priv(ref ___nl__1,___nl__3);

//line 139
if (true) {goto label_6;}
//line 139
label_11:
//line 140
post_processing_NL.NL_set_mathfun_in_modules_priv(ref ___nl__0,___nl__2,ref ___nl__3,ref ___nl__1);

//line 141
post_processing_NL.NL_set_interpreted_changed_functions_priv(___nl__0,___nl__2,ref ___nl__3);

//line 142
post_processing_NL.NL_evaluate_const_in_modules_priv(ref ___nl__0,___nl__3,ref ___nl__1,___nl__2);

//line 143
post_processing_NL.NL_delete_unnecessary_commands_priv(ref ___nl__1,___nl__3);

//line 144
if (true) {goto label_6;}
//line 144
label_6:
//line 144
___nl__4 = null;
//line 144
___nl__5 = null;
//line 145
post_processing_NL.NL_delete_unused_labels_priv(ref ___nl__1);

//line 146
___nl__4 = ___nl__2.clone();
//line 146
((ImmHash)___nl__0).set("math_fs", ___nl__4);
//line 146
___nl__4 = null;
//line 146
___nl__2 = null;
//line 146
___nl__3 = null;
//line 146
___arg__0 = ___nl__0;___arg__1 = ___nl__1;if(true) return null;
}

private static Imm NL_set_const_commands_in_modules_priv(ref Imm ___arg__0, Imm ___arg__1, ref Imm ___arg__2, Imm ___arg__3, Imm ___arg__4) {
Imm ___nl__0 = ___arg__0;Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);Imm ___nl__2 = ___arg__2;Imm ___nl__3 = null;c_rt_lib_NL.NL_copy(ref ___nl__3, ___arg__3);Imm ___nl__4 = null;c_rt_lib_NL.NL_copy(ref ___nl__4, ___arg__4);
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
Imm ___nl__27 = null;
Imm ___nl__28 = null;
Imm ___nl__29 = null;
Imm ___nl__30 = null;
Imm ___nl__31 = null;
Dictionary<String, Imm> __function_map;
//line 151
___nl__6 = ((ImmHash)___nl__0).getHashValue()["nl_asm"].clone();
//line 151
___nl__5 = hash_NL.NL_keys(___nl__6).clone();

//line 151
___nl__6 = null;
//line 151
___nl__7 = new ImmDouble(0).clone();
//line 151
___nl__8 = new ImmDouble(1).clone();
//line 151
___nl__9 = c_rt_lib_NL.NL_array_len(___nl__5).clone();

//line 151
label_3:
//line 151
___nl__10 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))>=(Double.Parse(___nl__9.getValue().ToString())) ).clone();
//line 151
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_1;}}
//line 151
___nl__6 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()].clone();
//line 152
___nl__12 = ((ImmHash)___nl__0).getHashValue()["nl_asm"].clone();
//line 152
___nl__11 = hash_NL.NL_get_value(___nl__12,___nl__6).clone();

//line 152
___nl__12 = null;
//line 153
___nl__12 = c_rt_lib_NL.NL_get_false().clone();
//line 154
___nl__14 = ((ImmHash)___nl__11).getHashValue()["functions"].clone();
//line 154
___nl__13 = array_NL.NL_len(___nl__14).clone();

//line 154
___nl__14 = null;
//line 154
___nl__14 = new ImmDouble(0).clone();
//line 154
___nl__15 = new ImmDouble(1).clone();
//line 154
label_6:
//line 154
___nl__16 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__14.getValue().ToString()))>=(Double.Parse(___nl__13.getValue().ToString())) ).clone();
//line 154
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_4;}}
//line 155
___nl__17 = ((ImmHash)___nl__11).getHashValue()["functions"].clone();
//line 155
___nl__17 = (___nl__17 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__14).getDoubleValue()].clone();
//line 156
___nl__18 = ((ImmHash)___nl__17).getHashValue()["access"].clone();
//line 156
___nl__18 = c_rt_lib_NL.NL_ov_is(___nl__18, new ImmString("pub")).clone();
//line 156
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_8;}}
//line 156
___nl__18 = new ImmString("_priv::").clone();
//line 156
if (true) {goto label_7;}
//line 156
label_8:
//line 156
___nl__18 = new ImmString("::").clone();
//line 156
label_7:
//line 156
___nl__18 = new ImmString(___nl__6.toString() + ___nl__18.toString()).clone();
//line 156
___nl__19 = ((ImmHash)___nl__17).getHashValue()["name"].clone();
//line 156
___nl__18 = new ImmString(___nl__18.toString() + ___nl__19.toString()).clone();
//line 156
___nl__19 = null;
//line 157
___nl__19 = hash_NL.NL_has_key(___nl__1,___nl__18).clone();

//line 157
___nl__19 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__19)).clone();
//line 157
if (c_rt_lib_NL.NL_check_true_native(___nl__19)) {if (true) {goto label_10;}}
//line 158
___nl__20 = c_rt_lib_NL.NL_get_true().clone();
//line 158
___nl__12 = ___nl__20.clone();
//line 158
___nl__20 = null;
//line 159
___nl__21 = ((ImmHash)___nl__17).getHashValue()["commands"].clone();
//line 159
___nl__22 = ((ImmHash)___nl__17).getHashValue()["args_type"].clone();
//line 159
___nl__20 = flow_graph_NL.NL_make_blocks(___nl__21,___nl__22).clone();

//line 159
___nl__22 = null;
//line 159
___nl__21 = null;
//line 160
___nl__21 = ((ImmHash)___nl__11).getHashValue()["module_name"].clone();
//line 160
___nl__22 = ((ImmHash)___nl__17).getHashValue()["reg_size"].clone();
//line 160
post_processing_NL.NL_set_const_reg_priv(ref ___nl__20,___nl__4,___nl__21,___nl__22);

//line 160
___nl__22 = null;
//line 160
___nl__21 = null;
//line 161
___nl__21 = flow_graph_NL.NL_combine_blocks(___nl__20).clone();

//line 162
___nl__22 = array_NL.NL_len(___nl__21).clone();

//line 162
___nl__23 = new ImmDouble(0).clone();
//line 162
___nl__24 = new ImmDouble(1).clone();
//line 162
label_13:
//line 162
___nl__25 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__23.getValue().ToString()))>=(Double.Parse(___nl__22.getValue().ToString())) ).clone();
//line 162
if (c_rt_lib_NL.NL_check_true_native(___nl__25)) {if (true) {goto label_11;}}
//line 163
___nl__26 = (___nl__21 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__23).getDoubleValue()].clone();
//line 164
___nl__29 = ((ImmHash)___nl__26).getHashValue()["cmd"].clone();
//line 164
___nl__28 = ov_NL.NL_get_element(___nl__29).clone();

//line 164
___nl__29 = null;
//line 164
___nl__27 = hash_NL.NL_has_key(___nl__3,___nl__28).clone();

//line 164
___nl__28 = null;
//line 164
___nl__27 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__27)).clone();
//line 164
___nl__27 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__27)).clone();
//line 164
if (c_rt_lib_NL.NL_check_true_native(___nl__27)) {if (true) {goto label_15;}}
//line 165
___nl__28 = ((ImmHash)___nl__26).getHashValue()["annotation"].clone();
//line 165
___nl__28 = c_rt_lib_NL.NL_ov_is(___nl__28, new ImmString("const")).clone();
//line 165
___nl__28 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__28)).clone();
//line 165
if (c_rt_lib_NL.NL_check_true_native(___nl__28)) {if (true) {goto label_17;}}
//line 166
___nl__29 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 166
___nl__30 = c_rt_lib_NL.NL_get_ref_arr(___nl__21,___nl__23).clone();

//line 166
___nl__31 = ___nl__29.clone();
//line 166
((ImmHash)___nl__30).set("annotation", ___nl__31);
//line 166
c_rt_lib_NL.NL_set_ref_arr(ref ___nl__21,___nl__23,___nl__30);

//line 166
___nl__29 = null;
//line 166
___nl__30 = null;
//line 166
___nl__31 = null;
//line 167
if (true) {goto label_17;}
//line 167
label_17:
//line 167
___nl__28 = null;
//line 168
if (true) {goto label_15;}
//line 168
label_15:
//line 168
___nl__27 = null;
//line 168
___nl__26 = null;
//line 169
___nl__23 = new ImmDouble((Double.Parse(___nl__23.getValue().ToString()))+(Double.Parse(___nl__24.getValue().ToString()))).clone();
//line 169
if (true) {goto label_13;}
//line 169
label_11:
//line 169
___nl__22 = null;
//line 169
___nl__23 = null;
//line 169
___nl__24 = null;
//line 169
___nl__25 = null;
//line 170
___nl__22 = ___nl__21.clone();
//line 170
((ImmHash)___nl__17).set("commands", ___nl__22);
//line 170
___nl__22 = null;
//line 171
___nl__22 = new ImmString("functions").clone();
//line 171
___nl__22 = c_rt_lib_NL.NL_get_ref_hash(___nl__11,___nl__22).clone();

//line 171
___nl__23 = ___nl__17.clone();
//line 171
(___nl__22 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__14).getDoubleValue()] = ___nl__23;
//line 171
___nl__24 = new ImmString("functions").clone();
//line 171
c_rt_lib_NL.NL_set_ref_hash(ref ___nl__11,___nl__24,___nl__22);

//line 171
___nl__24 = null;
//line 171
___nl__22 = null;
//line 171
___nl__23 = null;
//line 171
___nl__20 = null;
//line 171
___nl__21 = null;
//line 172
if (true) {goto label_10;}
//line 172
label_10:
//line 172
___nl__19 = null;
//line 172
___nl__17 = null;
//line 172
___nl__18 = null;
//line 173
___nl__14 = new ImmDouble((Double.Parse(___nl__14.getValue().ToString()))+(Double.Parse(___nl__15.getValue().ToString()))).clone();
//line 173
if (true) {goto label_6;}
//line 173
label_4:
//line 173
___nl__13 = null;
//line 173
___nl__14 = null;
//line 173
___nl__15 = null;
//line 173
___nl__16 = null;
//line 174
___nl__13 = ___nl__12.clone();
//line 174
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13)).clone();
//line 174
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13)).clone();
//line 174
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_19;}}
//line 174
___nl__11 = null;
//line 174
___nl__12 = null;
//line 174
___nl__13 = null;
//line 174
if (true) {goto label_2;}
//line 174
if (true) {goto label_19;}
//line 174
label_19:
//line 174
___nl__13 = null;
//line 175
___nl__13 = new ImmString("nl_asm").clone();
//line 175
___nl__13 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__13).clone();

//line 175
hash_NL.NL_set_value(ref ___nl__13,___nl__6,___nl__11);

//line 175
___nl__14 = new ImmString("nl_asm").clone();
//line 175
c_rt_lib_NL.NL_set_ref_hash(ref ___nl__0,___nl__14,___nl__13);

//line 175
___nl__14 = null;
//line 175
___nl__13 = null;
//line 176
hash_NL.NL_set_value(ref ___nl__2,___nl__6,___nl__11);

//line 176
___nl__11 = null;
//line 176
___nl__12 = null;
//line 176
label_2:
//line 177
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString()))).clone();
//line 177
if (true) {goto label_3;}
//line 177
label_1:
//line 177
___nl__5 = null;
//line 177
___nl__6 = null;
//line 177
___nl__7 = null;
//line 177
___nl__8 = null;
//line 177
___nl__9 = null;
//line 177
___nl__10 = null;
//line 177
___nl__1 = null;
//line 177
___nl__3 = null;
//line 177
___nl__4 = null;
//line 177
___arg__0 = ___nl__0;___arg__2 = ___nl__2;if(true) return null;
}

private static Imm NL_evaluate_const_in_modules_priv(ref Imm ___arg__0, Imm ___arg__1, ref Imm ___arg__2, Imm ___arg__3) {
Imm ___nl__0 = ___arg__0;Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);Imm ___nl__2 = ___arg__2;Imm ___nl__3 = null;c_rt_lib_NL.NL_copy(ref ___nl__3, ___arg__3);
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
Dictionary<String, Imm> __function_map;
//line 183
___nl__4 = new ImmArray(new Imm[0]).clone();
//line 184
___nl__5 = ((ImmHash)___nl__0).getHashValue()["nl_asm"].clone();
//line 184
___nl__8 = c_rt_lib_NL.NL_init_iter(___nl__5).clone();

//line 184
label_3:
//line 184
___nl__6 = c_rt_lib_NL.NL_is_end_hash(___nl__8).clone();

//line 184
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_1;}}
//line 184
___nl__6 = c_rt_lib_NL.NL_get_key_iter(___nl__8).clone();

//line 184
___nl__7 = c_rt_lib_NL.NL_hash_get_value(___nl__5,___nl__6).clone();

//line 185
array_NL.NL_push(ref ___nl__4,___nl__7);

//line 186
___nl__8 = c_rt_lib_NL.NL_next_iter(___nl__8).clone();

//line 186
if (true) {goto label_3;}
//line 186
label_1:
//line 186
___nl__5 = null;
//line 186
___nl__6 = null;
//line 186
___nl__7 = null;
//line 186
___nl__8 = null;
//line 187
__function_map = new Dictionary<String, Imm>();
___nl__6 = new ImmHash(__function_map).clone();
//line 187
___nl__5 = interpreter_NL.NL_init(___nl__4,___nl__6).clone();

//line 187
___nl__6 = null;
//line 187
___nl__6 = ___nl__5.clone();
//line 187
((ImmHash)___nl__0).set("interpreter_state", ___nl__6);
//line 187
___nl__5 = null;
//line 187
___nl__6 = null;
//line 188
___nl__6 = ((ImmHash)___nl__0).getHashValue()["nl_asm"].clone();
//line 188
___nl__5 = hash_NL.NL_keys(___nl__6).clone();

//line 188
___nl__6 = null;
//line 188
___nl__7 = new ImmDouble(0).clone();
//line 188
___nl__8 = new ImmDouble(1).clone();
//line 188
___nl__9 = c_rt_lib_NL.NL_array_len(___nl__5).clone();

//line 188
label_6:
//line 188
___nl__10 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))>=(Double.Parse(___nl__9.getValue().ToString())) ).clone();
//line 188
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_4;}}
//line 188
___nl__6 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()].clone();
//line 189
___nl__12 = ((ImmHash)___nl__0).getHashValue()["nl_asm"].clone();
//line 189
___nl__11 = hash_NL.NL_get_value(___nl__12,___nl__6).clone();

//line 189
___nl__12 = null;
//line 190
___nl__12 = c_rt_lib_NL.NL_get_false().clone();
//line 191
___nl__14 = ((ImmHash)___nl__11).getHashValue()["functions"].clone();
//line 191
___nl__13 = array_NL.NL_len(___nl__14).clone();

//line 191
___nl__14 = null;
//line 191
___nl__14 = new ImmDouble(0).clone();
//line 191
___nl__15 = new ImmDouble(1).clone();
//line 191
label_9:
//line 191
___nl__16 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__14.getValue().ToString()))>=(Double.Parse(___nl__13.getValue().ToString())) ).clone();
//line 191
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_7;}}
//line 192
___nl__17 = ((ImmHash)___nl__11).getHashValue()["functions"].clone();
//line 192
___nl__17 = (___nl__17 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__14).getDoubleValue()].clone();
//line 193
___nl__18 = ((ImmHash)___nl__17).getHashValue()["access"].clone();
//line 193
___nl__18 = c_rt_lib_NL.NL_ov_is(___nl__18, new ImmString("pub")).clone();
//line 193
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_11;}}
//line 193
___nl__18 = new ImmString("_priv::").clone();
//line 193
if (true) {goto label_10;}
//line 193
label_11:
//line 193
___nl__18 = new ImmString("::").clone();
//line 193
label_10:
//line 193
___nl__18 = new ImmString(___nl__6.toString() + ___nl__18.toString()).clone();
//line 193
___nl__19 = ((ImmHash)___nl__17).getHashValue()["name"].clone();
//line 193
___nl__18 = new ImmString(___nl__18.toString() + ___nl__19.toString()).clone();
//line 193
___nl__19 = null;
//line 194
___nl__19 = hash_NL.NL_has_key(___nl__1,___nl__18).clone();

//line 194
___nl__19 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__19)).clone();
//line 194
if (c_rt_lib_NL.NL_check_true_native(___nl__19)) {if (true) {goto label_13;}}
//line 195
___nl__20 = c_rt_lib_NL.NL_get_true().clone();
//line 195
___nl__12 = ___nl__20.clone();
//line 195
___nl__20 = null;
//line 196
___nl__21 = ((ImmHash)___nl__11).getHashValue()["module_name"].clone();
//line 196
___nl__22 = ((ImmHash)___nl__0).getHashValue()["interpreter_state"].clone();
//line 196
___nl__20 = post_processing_NL.NL_evaluate_const_in_function_priv(___nl__17,___nl__21,___nl__3,___nl__22).clone();

//line 196
___nl__22 = null;
//line 196
___nl__21 = null;
//line 196
___nl__21 = ___nl__20.clone();
//line 196
((ImmHash)___nl__17).set("commands", ___nl__21);
//line 196
___nl__20 = null;
//line 196
___nl__21 = null;
//line 197
___nl__20 = new ImmString("functions").clone();
//line 197
___nl__20 = c_rt_lib_NL.NL_get_ref_hash(___nl__11,___nl__20).clone();

//line 197
___nl__21 = ___nl__17.clone();
//line 197
(___nl__20 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__14).getDoubleValue()] = ___nl__21;
//line 197
___nl__22 = new ImmString("functions").clone();
//line 197
c_rt_lib_NL.NL_set_ref_hash(ref ___nl__11,___nl__22,___nl__20);

//line 197
___nl__22 = null;
//line 197
___nl__20 = null;
//line 197
___nl__21 = null;
//line 198
if (true) {goto label_13;}
//line 198
label_13:
//line 198
___nl__19 = null;
//line 198
___nl__17 = null;
//line 198
___nl__18 = null;
//line 199
___nl__14 = new ImmDouble((Double.Parse(___nl__14.getValue().ToString()))+(Double.Parse(___nl__15.getValue().ToString()))).clone();
//line 199
if (true) {goto label_9;}
//line 199
label_7:
//line 199
___nl__13 = null;
//line 199
___nl__14 = null;
//line 199
___nl__15 = null;
//line 199
___nl__16 = null;
//line 200
___nl__13 = ___nl__12.clone();
//line 200
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13)).clone();
//line 200
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13)).clone();
//line 200
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_15;}}
//line 200
___nl__11 = null;
//line 200
___nl__12 = null;
//line 200
___nl__13 = null;
//line 200
if (true) {goto label_5;}
//line 200
if (true) {goto label_15;}
//line 200
label_15:
//line 200
___nl__13 = null;
//line 201
___nl__13 = new ImmString("nl_asm").clone();
//line 201
___nl__13 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__13).clone();

//line 201
hash_NL.NL_set_value(ref ___nl__13,___nl__6,___nl__11);

//line 201
___nl__14 = new ImmString("nl_asm").clone();
//line 201
c_rt_lib_NL.NL_set_ref_hash(ref ___nl__0,___nl__14,___nl__13);

//line 201
___nl__14 = null;
//line 201
___nl__13 = null;
//line 202
hash_NL.NL_set_value(ref ___nl__2,___nl__6,___nl__11);

//line 202
___nl__11 = null;
//line 202
___nl__12 = null;
//line 202
label_5:
//line 203
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString()))).clone();
//line 203
if (true) {goto label_6;}
//line 203
label_4:
//line 203
___nl__5 = null;
//line 203
___nl__6 = null;
//line 203
___nl__7 = null;
//line 203
___nl__8 = null;
//line 203
___nl__9 = null;
//line 203
___nl__10 = null;
//line 203
___nl__4 = null;
//line 203
___nl__1 = null;
//line 203
___nl__3 = null;
//line 203
___arg__0 = ___nl__0;___arg__2 = ___nl__2;if(true) return null;
}

private static Imm NL_evaluate_const_in_function_priv(Imm ___arg__0, Imm ___arg__1, Imm ___arg__2, Imm ___arg__3) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);Imm ___nl__2 = null;c_rt_lib_NL.NL_copy(ref ___nl__2, ___arg__2);Imm ___nl__3 = null;c_rt_lib_NL.NL_copy(ref ___nl__3, ___arg__3);
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Dictionary<String, Imm> __function_map;
//line 207
___nl__5 = ((ImmHash)___nl__0).getHashValue()["commands"].clone();
//line 207
___nl__6 = ((ImmHash)___nl__0).getHashValue()["args_type"].clone();
//line 207
___nl__4 = flow_graph_NL.NL_make_blocks(___nl__5,___nl__6).clone();

//line 207
___nl__6 = null;
//line 207
___nl__5 = null;
//line 208
post_processing_NL.NL_evaluate_const_in_blocks_priv(ref ___nl__4,___nl__2,___nl__0,___nl__1,___nl__3);

//line 209
___nl__5 = flow_graph_NL.NL_combine_blocks(___nl__4).clone();

//line 209
___nl__0 = null;
//line 209
___nl__1 = null;
//line 209
___nl__2 = null;
//line 209
___nl__3 = null;
//line 209
___nl__4 = null;
//line 209
if(true) return ___nl__5;
//line 209
___nl__5 = null;
//line 209
___nl__4 = null;
//line 209
___nl__0 = null;
//line 209
___nl__1 = null;
//line 209
___nl__2 = null;
//line 209
___nl__3 = null;
//line 209
if(true) return null;
}

private static Imm NL_set_interpreted_changed_functions_priv(Imm ___arg__0, Imm ___arg__1, ref Imm ___arg__2) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);Imm ___nl__2 = ___arg__2;
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
Dictionary<String, Imm> __function_map;
//line 213
___nl__3 = ((ImmHash)___nl__0).getHashValue()["fun_calls"].clone();
//line 214
___nl__4 = ((ImmHash)___nl__0).getHashValue()["nl_asm"].clone();
//line 214
___nl__7 = c_rt_lib_NL.NL_init_iter(___nl__4).clone();

//line 214
label_3:
//line 214
___nl__5 = c_rt_lib_NL.NL_is_end_hash(___nl__7).clone();

//line 214
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_1;}}
//line 214
___nl__5 = c_rt_lib_NL.NL_get_key_iter(___nl__7).clone();

//line 214
___nl__6 = c_rt_lib_NL.NL_hash_get_value(___nl__4,___nl__5).clone();

//line 215
___nl__8 = ((ImmHash)___nl__6).getHashValue()["functions"].clone();
//line 215
___nl__10 = new ImmDouble(0).clone();
//line 215
___nl__11 = new ImmDouble(1).clone();
//line 215
___nl__12 = c_rt_lib_NL.NL_array_len(___nl__8).clone();

//line 215
label_6:
//line 215
___nl__13 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__10.getValue().ToString()))>=(Double.Parse(___nl__12.getValue().ToString())) ).clone();
//line 215
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_4;}}
//line 215
___nl__9 = (___nl__8 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()].clone();
//line 216
___nl__14 = ((ImmHash)___nl__9).getHashValue()["access"].clone();
//line 216
___nl__14 = c_rt_lib_NL.NL_ov_is(___nl__14, new ImmString("pub")).clone();
//line 216
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_8;}}
//line 216
___nl__14 = new ImmString("_priv::").clone();
//line 216
if (true) {goto label_7;}
//line 216
label_8:
//line 216
___nl__14 = new ImmString("::").clone();
//line 216
label_7:
//line 216
___nl__15 = ((ImmHash)___nl__9).getHashValue()["name"].clone();
//line 216
___nl__14 = new ImmString(___nl__14.toString() + ___nl__15.toString()).clone();
//line 216
___nl__15 = null;
//line 217
___nl__15 = new ImmString(___nl__5.toString() + ___nl__14.toString()).clone();
//line 218
___nl__17 = hash_NL.NL_get_value(___nl__3,___nl__5).clone();

//line 218
___nl__16 = hash_NL.NL_get_value(___nl__17,___nl__14).clone();

//line 218
___nl__17 = null;
//line 219
___nl__19 = c_rt_lib_NL.NL_init_iter(___nl__16).clone();

//line 219
label_11:
//line 219
___nl__17 = c_rt_lib_NL.NL_is_end_hash(___nl__19).clone();

//line 219
if (c_rt_lib_NL.NL_check_true_native(___nl__17)) {if (true) {goto label_9;}}
//line 219
___nl__17 = c_rt_lib_NL.NL_get_key_iter(___nl__19).clone();

//line 219
___nl__18 = c_rt_lib_NL.NL_hash_get_value(___nl__16,___nl__17).clone();

//line 220
___nl__20 = hash_NL.NL_has_key(___nl__2,___nl__17).clone();

//line 220
___nl__20 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__20)).clone();
//line 220
___nl__20 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__20)).clone();
//line 220
if (c_rt_lib_NL.NL_check_true_native(___nl__20)) {if (true) {goto label_13;}}
//line 220
___nl__20 = null;
//line 220
if (true) {goto label_10;}
//line 220
if (true) {goto label_13;}
//line 220
label_13:
//line 220
___nl__20 = null;
//line 221
___nl__20 = hash_NL.NL_get_value(___nl__1,___nl__17).clone();

//line 222
___nl__21 = ___nl__20.clone();
//line 222
___nl__21 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__21)).clone();
//line 222
___nl__21 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__21)).clone();
//line 222
if (c_rt_lib_NL.NL_check_true_native(___nl__21)) {if (true) {goto label_15;}}
//line 222
___nl__20 = null;
//line 222
___nl__21 = null;
//line 222
if (true) {goto label_10;}
//line 222
if (true) {goto label_15;}
//line 222
label_15:
//line 222
___nl__21 = null;
//line 223
___nl__21 = new ImmString("").clone();
//line 223
hash_NL.NL_set_value(ref ___nl__2,___nl__15,___nl__21);

//line 223
___nl__21 = null;
//line 223
___nl__20 = null;
//line 223
label_10:
//line 224
___nl__19 = c_rt_lib_NL.NL_next_iter(___nl__19).clone();

//line 224
if (true) {goto label_11;}
//line 224
label_9:
//line 224
___nl__17 = null;
//line 224
___nl__18 = null;
//line 224
___nl__19 = null;
//line 224
___nl__14 = null;
//line 224
___nl__15 = null;
//line 224
___nl__16 = null;
//line 225
___nl__10 = new ImmDouble((Double.Parse(___nl__10.getValue().ToString()))+(Double.Parse(___nl__11.getValue().ToString()))).clone();
//line 225
if (true) {goto label_6;}
//line 225
label_4:
//line 225
___nl__8 = null;
//line 225
___nl__9 = null;
//line 225
___nl__10 = null;
//line 225
___nl__11 = null;
//line 225
___nl__12 = null;
//line 225
___nl__13 = null;
//line 226
___nl__7 = c_rt_lib_NL.NL_next_iter(___nl__7).clone();

//line 226
if (true) {goto label_3;}
//line 226
label_1:
//line 226
___nl__4 = null;
//line 226
___nl__5 = null;
//line 226
___nl__6 = null;
//line 226
___nl__7 = null;
//line 226
___nl__3 = null;
//line 226
___nl__0 = null;
//line 226
___nl__1 = null;
//line 226
___arg__2 = ___nl__2;if(true) return null;
}

private static Imm NL_get_called_switched_priv(Imm ___arg__0, Imm ___arg__1) {
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
Imm ___nl__11 = null;
Imm ___nl__12 = null;
Imm ___nl__13 = null;
Dictionary<String, Imm> __function_map;
//line 230
__function_map = new Dictionary<String, Imm>();
___nl__2 = new ImmHash(__function_map).clone();
//line 231
___nl__5 = c_rt_lib_NL.NL_init_iter(___nl__0).clone();

//line 231
label_3:
//line 231
___nl__3 = c_rt_lib_NL.NL_is_end_hash(___nl__5).clone();

//line 231
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_1;}}
//line 231
___nl__3 = c_rt_lib_NL.NL_get_key_iter(___nl__5).clone();

//line 231
___nl__4 = c_rt_lib_NL.NL_hash_get_value(___nl__0,___nl__3).clone();

//line 232
___nl__8 = c_rt_lib_NL.NL_init_iter(___nl__4).clone();

//line 232
label_6:
//line 232
___nl__6 = c_rt_lib_NL.NL_is_end_hash(___nl__8).clone();

//line 232
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_4;}}
//line 232
___nl__6 = c_rt_lib_NL.NL_get_key_iter(___nl__8).clone();

//line 232
___nl__7 = c_rt_lib_NL.NL_hash_get_value(___nl__4,___nl__6).clone();

//line 233
___nl__11 = c_rt_lib_NL.NL_init_iter(___nl__7).clone();

//line 233
label_9:
//line 233
___nl__9 = c_rt_lib_NL.NL_is_end_hash(___nl__11).clone();

//line 233
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_7;}}
//line 233
___nl__9 = c_rt_lib_NL.NL_get_key_iter(___nl__11).clone();

//line 233
___nl__10 = c_rt_lib_NL.NL_hash_get_value(___nl__7,___nl__9).clone();

//line 234
___nl__12 = hash_NL.NL_has_key(___nl__1,___nl__9).clone();

//line 234
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 234
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_11;}}
//line 235
___nl__13 = c_rt_lib_NL.NL_get_true().clone();
//line 235
hash_NL.NL_set_value(ref ___nl__2,___nl__9,___nl__13);

//line 235
___nl__13 = null;
//line 236
if (true) {goto label_11;}
//line 236
label_11:
//line 236
___nl__12 = null;
//line 237
___nl__11 = c_rt_lib_NL.NL_next_iter(___nl__11).clone();

//line 237
if (true) {goto label_9;}
//line 237
label_7:
//line 237
___nl__9 = null;
//line 237
___nl__10 = null;
//line 237
___nl__11 = null;
//line 238
___nl__8 = c_rt_lib_NL.NL_next_iter(___nl__8).clone();

//line 238
if (true) {goto label_6;}
//line 238
label_4:
//line 238
___nl__6 = null;
//line 238
___nl__7 = null;
//line 238
___nl__8 = null;
//line 239
___nl__5 = c_rt_lib_NL.NL_next_iter(___nl__5).clone();

//line 239
if (true) {goto label_3;}
//line 239
label_1:
//line 239
___nl__3 = null;
//line 239
___nl__4 = null;
//line 239
___nl__5 = null;
//line 240
___nl__0 = null;
//line 240
___nl__1 = null;
//line 240
if(true) return ___nl__2;
//line 240
___nl__2 = null;
//line 240
___nl__0 = null;
//line 240
___nl__1 = null;
//line 240
if(true) return null;
}

private static Imm NL_get_switched_func_priv(Imm ___arg__0, Imm ___arg__1) {
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
//line 243
__function_map = new Dictionary<String, Imm>();
___nl__2 = new ImmHash(__function_map).clone();
//line 244
___nl__5 = c_rt_lib_NL.NL_init_iter(___nl__1).clone();

//line 244
label_3:
//line 244
___nl__3 = c_rt_lib_NL.NL_is_end_hash(___nl__5).clone();

//line 244
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_1;}}
//line 244
___nl__3 = c_rt_lib_NL.NL_get_key_iter(___nl__5).clone();

//line 244
___nl__4 = c_rt_lib_NL.NL_hash_get_value(___nl__1,___nl__3).clone();

//line 245
___nl__6 = hash_NL.NL_has_key(___nl__0,___nl__3).clone();

//line 245
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 245
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_5;}}
//line 246
___nl__7 = hash_NL.NL_get_value(___nl__0,___nl__3).clone();

//line 247
___nl__8 = ___nl__7.clone();
//line 247
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 247
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_9;}}
//line 247
___nl__8 = ___nl__4.clone();
//line 247
label_9:
//line 247
___nl__9 = null;
//line 247
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_8;}}
//line 247
___nl__8 = ___nl__7.clone();
//line 247
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 247
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 247
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_10;}}
//line 247
___nl__8 = ___nl__4.clone();
//line 247
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 247
label_10:
//line 247
___nl__9 = null;
//line 247
label_8:
//line 247
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 247
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_7;}}
//line 247
___nl__6 = null;
//line 247
___nl__7 = null;
//line 247
___nl__8 = null;
//line 247
if (true) {goto label_2;}
//line 247
if (true) {goto label_7;}
//line 247
label_7:
//line 247
___nl__8 = null;
//line 247
___nl__7 = null;
//line 248
if (true) {goto label_5;}
//line 248
label_5:
//line 248
___nl__6 = null;
//line 249
hash_NL.NL_set_value(ref ___nl__2,___nl__3,___nl__4);

//line 249
label_2:
//line 250
___nl__5 = c_rt_lib_NL.NL_next_iter(___nl__5).clone();

//line 250
if (true) {goto label_3;}
//line 250
label_1:
//line 250
___nl__3 = null;
//line 250
___nl__4 = null;
//line 250
___nl__5 = null;
//line 251
___nl__0 = null;
//line 251
___nl__1 = null;
//line 251
if(true) return ___nl__2;
//line 251
___nl__2 = null;
//line 251
___nl__0 = null;
//line 251
___nl__1 = null;
//line 251
if(true) return null;
}

private static Imm NL_set_function_calls_priv(ref Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0;Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);
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
Dictionary<String, Imm> __function_map;
//line 254
___nl__4 = c_rt_lib_NL.NL_init_iter(___nl__1).clone();

//line 254
label_3:
//line 254
___nl__2 = c_rt_lib_NL.NL_is_end_hash(___nl__4).clone();

//line 254
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_1;}}
//line 254
___nl__2 = c_rt_lib_NL.NL_get_key_iter(___nl__4).clone();

//line 254
___nl__3 = c_rt_lib_NL.NL_hash_get_value(___nl__1,___nl__2).clone();

//line 255
__function_map = new Dictionary<String, Imm>();
___nl__5 = new ImmHash(__function_map).clone();
//line 256
___nl__6 = ((ImmHash)___nl__3).getHashValue()["functions"].clone();
//line 256
___nl__8 = new ImmDouble(0).clone();
//line 256
___nl__9 = new ImmDouble(1).clone();
//line 256
___nl__10 = c_rt_lib_NL.NL_array_len(___nl__6).clone();

//line 256
label_6:
//line 256
___nl__11 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString()))>=(Double.Parse(___nl__10.getValue().ToString())) ).clone();
//line 256
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_4;}}
//line 256
___nl__7 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()].clone();
//line 257
__function_map = new Dictionary<String, Imm>();
___nl__12 = new ImmHash(__function_map).clone();
//line 258
___nl__13 = ((ImmHash)___nl__7).getHashValue()["commands"].clone();
//line 258
___nl__15 = new ImmDouble(0).clone();
//line 258
___nl__16 = new ImmDouble(1).clone();
//line 258
___nl__17 = c_rt_lib_NL.NL_array_len(___nl__13).clone();

//line 258
label_9:
//line 258
___nl__18 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__15.getValue().ToString()))>=(Double.Parse(___nl__17.getValue().ToString())) ).clone();
//line 258
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_7;}}
//line 258
___nl__14 = (___nl__13 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__15).getDoubleValue()].clone();
//line 259
___nl__19 = ((ImmHash)___nl__14).getHashValue()["cmd"].clone();
//line 259
___nl__19 = c_rt_lib_NL.NL_ov_is(___nl__19, new ImmString("call")).clone();
//line 259
___nl__19 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__19)).clone();
//line 259
___nl__19 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__19)).clone();
//line 259
if (c_rt_lib_NL.NL_check_true_native(___nl__19)) {if (true) {goto label_11;}}
//line 259
___nl__19 = null;
//line 259
if (true) {goto label_8;}
//line 259
if (true) {goto label_11;}
//line 259
label_11:
//line 259
___nl__19 = null;
//line 260
___nl__19 = ((ImmHash)___nl__14).getHashValue()["cmd"].clone();
//line 260
___nl__19 = c_rt_lib_NL.NL_ov_as(___nl__19, new ImmString("call")).clone();
//line 261
___nl__20 = ((ImmHash)___nl__19).getHashValue()["mod"].clone();
//line 262
___nl__21 = new ImmString("::").clone();
//line 262
___nl__22 = ((ImmHash)___nl__19).getHashValue()["fun_name"].clone();
//line 262
___nl__21 = new ImmString(___nl__21.toString() + ___nl__22.toString()).clone();
//line 262
___nl__22 = null;
//line 263
___nl__22 = new ImmString("").clone();
//line 263
___nl__22 = c_rt_lib_NL.NL_native_to_nl(___nl__20.toString().Equals(___nl__22.toString())).clone();
//line 263
___nl__22 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__22)).clone();
//line 263
if (c_rt_lib_NL.NL_check_true_native(___nl__22)) {if (true) {goto label_13;}}
//line 264
___nl__20 = ___nl__2.clone();
//line 265
___nl__23 = new ImmString("_priv").clone();
//line 265
___nl__23 = new ImmString(___nl__23.toString() + ___nl__21.toString()).clone();
//line 265
___nl__21 = ___nl__23.clone();
//line 265
___nl__23 = null;
//line 266
if (true) {goto label_13;}
//line 266
label_13:
//line 266
___nl__22 = null;
//line 267
___nl__22 = new ImmString(___nl__20.toString() + ___nl__21.toString()).clone();
//line 267
___nl__23 = new ImmArray(new Imm[] {___nl__20,___nl__21,}).clone();
//line 267
hash_NL.NL_set_value(ref ___nl__12,___nl__22,___nl__23);

//line 267
___nl__23 = null;
//line 267
___nl__22 = null;
//line 267
___nl__19 = null;
//line 267
___nl__20 = null;
//line 267
___nl__21 = null;
//line 267
label_8:
//line 268
___nl__15 = new ImmDouble((Double.Parse(___nl__15.getValue().ToString()))+(Double.Parse(___nl__16.getValue().ToString()))).clone();
//line 268
if (true) {goto label_9;}
//line 268
label_7:
//line 268
___nl__13 = null;
//line 268
___nl__14 = null;
//line 268
___nl__15 = null;
//line 268
___nl__16 = null;
//line 268
___nl__17 = null;
//line 268
___nl__18 = null;
//line 269
___nl__13 = ((ImmHash)___nl__7).getHashValue()["access"].clone();
//line 269
___nl__13 = c_rt_lib_NL.NL_ov_is(___nl__13, new ImmString("pub")).clone();
//line 269
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_15;}}
//line 269
___nl__13 = new ImmString("_priv::").clone();
//line 269
if (true) {goto label_14;}
//line 269
label_15:
//line 269
___nl__13 = new ImmString("::").clone();
//line 269
label_14:
//line 270
___nl__14 = ((ImmHash)___nl__7).getHashValue()["name"].clone();
//line 270
___nl__14 = new ImmString(___nl__13.toString() + ___nl__14.toString()).clone();
//line 270
hash_NL.NL_set_value(ref ___nl__5,___nl__14,___nl__12);

//line 270
___nl__14 = null;
//line 270
___nl__12 = null;
//line 270
___nl__13 = null;
//line 271
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))+(Double.Parse(___nl__9.getValue().ToString()))).clone();
//line 271
if (true) {goto label_6;}
//line 271
label_4:
//line 271
___nl__6 = null;
//line 271
___nl__7 = null;
//line 271
___nl__8 = null;
//line 271
___nl__9 = null;
//line 271
___nl__10 = null;
//line 271
___nl__11 = null;
//line 272
hash_NL.NL_set_value(ref ___nl__0,___nl__2,___nl__5);

//line 272
___nl__5 = null;
//line 273
___nl__4 = c_rt_lib_NL.NL_next_iter(___nl__4).clone();

//line 273
if (true) {goto label_3;}
//line 273
label_1:
//line 273
___nl__2 = null;
//line 273
___nl__3 = null;
//line 273
___nl__4 = null;
//line 273
___nl__1 = null;
//line 273
___arg__0 = ___nl__0;if(true) return null;
}

private static Imm NL_get_math_fun_priv(Imm ___arg__0, Imm ___arg__1) {
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
Imm ___nl__11 = null;
Imm ___nl__12 = null;
Imm ___nl__13 = null;
Imm ___nl__14 = null;
Imm ___nl__15 = null;
Imm ___nl__16 = null;
Dictionary<String, Imm> __function_map;
//line 277
__function_map = new Dictionary<String, Imm>();
___nl__2 = new ImmHash(__function_map).clone();
//line 278
___nl__5 = c_rt_lib_NL.NL_init_iter(___nl__1).clone();

//line 278
label_3:
//line 278
___nl__3 = c_rt_lib_NL.NL_is_end_hash(___nl__5).clone();

//line 278
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_1;}}
//line 278
___nl__3 = c_rt_lib_NL.NL_get_key_iter(___nl__5).clone();

//line 278
___nl__4 = c_rt_lib_NL.NL_hash_get_value(___nl__1,___nl__3).clone();

//line 279
___nl__6 = c_rt_lib_NL.NL_get_true().clone();
//line 279
hash_NL.NL_set_value(ref ___nl__2,___nl__3,___nl__6);

//line 279
___nl__6 = null;
//line 280
___nl__5 = c_rt_lib_NL.NL_next_iter(___nl__5).clone();

//line 280
if (true) {goto label_3;}
//line 280
label_1:
//line 280
___nl__3 = null;
//line 280
___nl__4 = null;
//line 280
___nl__5 = null;
//line 281
___nl__5 = c_rt_lib_NL.NL_init_iter(___nl__0).clone();

//line 281
label_6:
//line 281
___nl__3 = c_rt_lib_NL.NL_is_end_hash(___nl__5).clone();

//line 281
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_4;}}
//line 281
___nl__3 = c_rt_lib_NL.NL_get_key_iter(___nl__5).clone();

//line 281
___nl__4 = c_rt_lib_NL.NL_hash_get_value(___nl__0,___nl__3).clone();

//line 282
___nl__8 = c_rt_lib_NL.NL_init_iter(___nl__4).clone();

//line 282
label_9:
//line 282
___nl__6 = c_rt_lib_NL.NL_is_end_hash(___nl__8).clone();

//line 282
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_7;}}
//line 282
___nl__6 = c_rt_lib_NL.NL_get_key_iter(___nl__8).clone();

//line 282
___nl__7 = c_rt_lib_NL.NL_hash_get_value(___nl__4,___nl__6).clone();

//line 283
___nl__9 = new ImmString(___nl__3.toString() + ___nl__6.toString()).clone();
//line 283
___nl__10 = c_rt_lib_NL.NL_get_true().clone();
//line 283
hash_NL.NL_set_value(ref ___nl__2,___nl__9,___nl__10);

//line 283
___nl__10 = null;
//line 283
___nl__9 = null;
//line 284
___nl__8 = c_rt_lib_NL.NL_next_iter(___nl__8).clone();

//line 284
if (true) {goto label_9;}
//line 284
label_7:
//line 284
___nl__6 = null;
//line 284
___nl__7 = null;
//line 284
___nl__8 = null;
//line 285
___nl__5 = c_rt_lib_NL.NL_next_iter(___nl__5).clone();

//line 285
if (true) {goto label_6;}
//line 285
label_4:
//line 285
___nl__3 = null;
//line 285
___nl__4 = null;
//line 285
___nl__5 = null;
//line 286
__function_map = new Dictionary<String, Imm>();
___nl__3 = new ImmHash(__function_map).clone();
//line 287
__function_map = new Dictionary<String, Imm>();
___nl__4 = new ImmHash(__function_map).clone();
//line 288
___nl__7 = c_rt_lib_NL.NL_init_iter(___nl__0).clone();

//line 288
label_12:
//line 288
___nl__5 = c_rt_lib_NL.NL_is_end_hash(___nl__7).clone();

//line 288
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_10;}}
//line 288
___nl__5 = c_rt_lib_NL.NL_get_key_iter(___nl__7).clone();

//line 288
___nl__6 = c_rt_lib_NL.NL_hash_get_value(___nl__0,___nl__5).clone();

//line 289
___nl__10 = c_rt_lib_NL.NL_init_iter(___nl__6).clone();

//line 289
label_15:
//line 289
___nl__8 = c_rt_lib_NL.NL_is_end_hash(___nl__10).clone();

//line 289
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_13;}}
//line 289
___nl__8 = c_rt_lib_NL.NL_get_key_iter(___nl__10).clone();

//line 289
___nl__9 = c_rt_lib_NL.NL_hash_get_value(___nl__6,___nl__8).clone();

//line 290
___nl__13 = c_rt_lib_NL.NL_init_iter(___nl__9).clone();

//line 290
label_18:
//line 290
___nl__11 = c_rt_lib_NL.NL_is_end_hash(___nl__13).clone();

//line 290
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_16;}}
//line 290
___nl__11 = c_rt_lib_NL.NL_get_key_iter(___nl__13).clone();

//line 290
___nl__12 = c_rt_lib_NL.NL_hash_get_value(___nl__9,___nl__11).clone();

//line 291
__function_map = new Dictionary<String, Imm>();
___nl__14 = new ImmHash(__function_map).clone();
//line 292
___nl__15 = hash_NL.NL_has_key(___nl__3,___nl__11).clone();

//line 292
___nl__15 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__15)).clone();
//line 292
if (c_rt_lib_NL.NL_check_true_native(___nl__15)) {if (true) {goto label_20;}}
//line 293
___nl__16 = hash_NL.NL_get_value(___nl__3,___nl__11).clone();

//line 293
___nl__14 = ___nl__16.clone();
//line 293
___nl__16 = null;
//line 294
if (true) {goto label_20;}
//line 294
label_20:
//line 294
___nl__15 = null;
//line 295
___nl__15 = hash_NL.NL_has_key(___nl__2,___nl__11).clone();

//line 295
___nl__15 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__15)).clone();
//line 295
___nl__15 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__15)).clone();
//line 295
if (c_rt_lib_NL.NL_check_true_native(___nl__15)) {if (true) {goto label_22;}}
//line 295
___nl__16 = c_rt_lib_NL.NL_get_true().clone();
//line 295
hash_NL.NL_set_value(ref ___nl__4,___nl__11,___nl__16);

//line 295
___nl__16 = null;
//line 295
if (true) {goto label_22;}
//line 295
label_22:
//line 295
___nl__15 = null;
//line 297
___nl__15 = new ImmString(___nl__5.toString() + ___nl__8.toString()).clone();
//line 297
___nl__16 = new ImmDouble(0).clone();
//line 297
hash_NL.NL_set_value(ref ___nl__14,___nl__15,___nl__16);

//line 297
___nl__16 = null;
//line 297
___nl__15 = null;
//line 298
hash_NL.NL_set_value(ref ___nl__3,___nl__11,___nl__14);

//line 298
___nl__14 = null;
//line 299
___nl__13 = c_rt_lib_NL.NL_next_iter(___nl__13).clone();

//line 299
if (true) {goto label_18;}
//line 299
label_16:
//line 299
___nl__11 = null;
//line 299
___nl__12 = null;
//line 299
___nl__13 = null;
//line 300
___nl__10 = c_rt_lib_NL.NL_next_iter(___nl__10).clone();

//line 300
if (true) {goto label_15;}
//line 300
label_13:
//line 300
___nl__8 = null;
//line 300
___nl__9 = null;
//line 300
___nl__10 = null;
//line 301
___nl__7 = c_rt_lib_NL.NL_next_iter(___nl__7).clone();

//line 301
if (true) {goto label_12;}
//line 301
label_10:
//line 301
___nl__5 = null;
//line 301
___nl__6 = null;
//line 301
___nl__7 = null;
//line 302
___nl__7 = c_rt_lib_NL.NL_init_iter(___nl__4).clone();

//line 302
label_25:
//line 302
___nl__5 = c_rt_lib_NL.NL_is_end_hash(___nl__7).clone();

//line 302
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_23;}}
//line 302
___nl__5 = c_rt_lib_NL.NL_get_key_iter(___nl__7).clone();

//line 302
___nl__6 = c_rt_lib_NL.NL_hash_get_value(___nl__4,___nl__5).clone();

//line 303
___nl__8 = c_rt_lib_NL.NL_get_true().clone();
//line 303
hash_NL.NL_set_value(ref ___nl__2,___nl__5,___nl__8);

//line 303
___nl__8 = null;
//line 304
post_processing_NL.NL_set_non_math_fun_rec_priv(ref ___nl__2,___nl__5,___nl__3);

//line 305
___nl__7 = c_rt_lib_NL.NL_next_iter(___nl__7).clone();

//line 305
if (true) {goto label_25;}
//line 305
label_23:
//line 305
___nl__5 = null;
//line 305
___nl__6 = null;
//line 305
___nl__7 = null;
//line 306
___nl__0 = null;
//line 306
___nl__1 = null;
//line 306
___nl__3 = null;
//line 306
___nl__4 = null;
//line 306
if(true) return ___nl__2;
//line 306
___nl__2 = null;
//line 306
___nl__3 = null;
//line 306
___nl__4 = null;
//line 306
___nl__0 = null;
//line 306
___nl__1 = null;
//line 306
if(true) return null;
}

private static Imm NL_set_non_math_fun_rec_priv(ref Imm ___arg__0, Imm ___arg__1, Imm ___arg__2) {
Imm ___nl__0 = ___arg__0;Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);Imm ___nl__2 = null;c_rt_lib_NL.NL_copy(ref ___nl__2, ___arg__2);
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Dictionary<String, Imm> __function_map;
//line 309
___nl__3 = hash_NL.NL_get_value(___nl__0,___nl__1).clone();

//line 309
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 309
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 309
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 309
___nl__1 = null;
//line 309
___nl__2 = null;
//line 309
___nl__3 = null;
//line 309
___arg__0 = ___nl__0;if(true) return null;
//line 309
if (true) {goto label_2;}
//line 309
label_2:
//line 309
___nl__3 = null;
//line 310
___nl__3 = c_rt_lib_NL.NL_get_false().clone();
//line 310
hash_NL.NL_set_value(ref ___nl__0,___nl__1,___nl__3);

//line 310
___nl__3 = null;
//line 311
___nl__3 = hash_NL.NL_has_key(___nl__2,___nl__1).clone();

//line 311
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 311
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 311
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_4;}}
//line 311
___nl__1 = null;
//line 311
___nl__2 = null;
//line 311
___nl__3 = null;
//line 311
___arg__0 = ___nl__0;if(true) return null;
//line 311
if (true) {goto label_4;}
//line 311
label_4:
//line 311
___nl__3 = null;
//line 312
___nl__3 = hash_NL.NL_get_value(___nl__2,___nl__1).clone();

//line 313
___nl__6 = c_rt_lib_NL.NL_init_iter(___nl__3).clone();

//line 313
label_7:
//line 313
___nl__4 = c_rt_lib_NL.NL_is_end_hash(___nl__6).clone();

//line 313
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_5;}}
//line 313
___nl__4 = c_rt_lib_NL.NL_get_key_iter(___nl__6).clone();

//line 313
___nl__5 = c_rt_lib_NL.NL_hash_get_value(___nl__3,___nl__4).clone();

//line 314
post_processing_NL.NL_set_non_math_fun_rec_priv(ref ___nl__0,___nl__4,___nl__2);

//line 315
___nl__6 = c_rt_lib_NL.NL_next_iter(___nl__6).clone();

//line 315
if (true) {goto label_7;}
//line 315
label_5:
//line 315
___nl__4 = null;
//line 315
___nl__5 = null;
//line 315
___nl__6 = null;
//line 315
___nl__3 = null;
//line 315
___nl__1 = null;
//line 315
___nl__2 = null;
//line 315
___arg__0 = ___nl__0;if(true) return null;
}

private static Imm NL_set_mathfun_in_modules_priv(ref Imm ___arg__0, Imm ___arg__1, ref Imm ___arg__2, ref Imm ___arg__3) {
Imm ___nl__0 = ___arg__0;Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);Imm ___nl__2 = ___arg__2;Imm ___nl__3 = ___arg__3;
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
Imm ___nl__27 = null;
Dictionary<String, Imm> __function_map;
//line 320
___nl__5 = ((ImmHash)___nl__0).getHashValue()["math_fs"].clone();
//line 320
___nl__4 = post_processing_NL.NL_get_switched_func_priv(___nl__5,___nl__1).clone();

//line 320
___nl__5 = null;
//line 321
___nl__6 = ((ImmHash)___nl__0).getHashValue()["fun_calls"].clone();
//line 321
___nl__5 = post_processing_NL.NL_get_called_switched_priv(___nl__6,___nl__4).clone();

//line 321
___nl__6 = null;
//line 322
___nl__7 = ((ImmHash)___nl__0).getHashValue()["nl_asm"].clone();
//line 322
___nl__6 = hash_NL.NL_keys(___nl__7).clone();

//line 322
___nl__7 = null;
//line 322
___nl__8 = new ImmDouble(0).clone();
//line 322
___nl__9 = new ImmDouble(1).clone();
//line 322
___nl__10 = c_rt_lib_NL.NL_array_len(___nl__6).clone();

//line 322
label_3:
//line 322
___nl__11 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString()))>=(Double.Parse(___nl__10.getValue().ToString())) ).clone();
//line 322
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_1;}}
//line 322
___nl__7 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()].clone();
//line 323
___nl__13 = ((ImmHash)___nl__0).getHashValue()["nl_asm"].clone();
//line 323
___nl__12 = hash_NL.NL_get_value(___nl__13,___nl__7).clone();

//line 323
___nl__13 = null;
//line 324
___nl__13 = c_rt_lib_NL.NL_get_false().clone();
//line 325
___nl__15 = ((ImmHash)___nl__12).getHashValue()["functions"].clone();
//line 325
___nl__14 = array_NL.NL_len(___nl__15).clone();

//line 325
___nl__15 = null;
//line 325
___nl__15 = new ImmDouble(0).clone();
//line 325
___nl__16 = new ImmDouble(1).clone();
//line 325
label_6:
//line 325
___nl__17 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__15.getValue().ToString()))>=(Double.Parse(___nl__14.getValue().ToString())) ).clone();
//line 325
if (c_rt_lib_NL.NL_check_true_native(___nl__17)) {if (true) {goto label_4;}}
//line 326
___nl__18 = c_rt_lib_NL.NL_get_false().clone();
//line 327
___nl__19 = ((ImmHash)___nl__12).getHashValue()["functions"].clone();
//line 327
___nl__19 = (___nl__19 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__15).getDoubleValue()].clone();
//line 328
___nl__20 = ((ImmHash)___nl__12).getHashValue()["module_name"].clone();
//line 328
___nl__21 = ((ImmHash)___nl__19).getHashValue()["access"].clone();
//line 328
___nl__21 = c_rt_lib_NL.NL_ov_is(___nl__21, new ImmString("pub")).clone();
//line 328
if (c_rt_lib_NL.NL_check_true_native(___nl__21)) {if (true) {goto label_8;}}
//line 328
___nl__21 = new ImmString("_priv::").clone();
//line 328
if (true) {goto label_7;}
//line 328
label_8:
//line 328
___nl__21 = new ImmString("::").clone();
//line 328
label_7:
//line 328
___nl__20 = new ImmString(___nl__20.toString() + ___nl__21.toString()).clone();
//line 328
___nl__21 = null;
//line 328
___nl__21 = ((ImmHash)___nl__19).getHashValue()["name"].clone();
//line 328
___nl__20 = new ImmString(___nl__20.toString() + ___nl__21.toString()).clone();
//line 328
___nl__21 = null;
//line 329
___nl__21 = hash_NL.NL_get_value(___nl__1,___nl__20).clone();

//line 330
___nl__22 = ___nl__21.clone();
//line 330
___nl__23 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__22)).clone();
//line 330
if (c_rt_lib_NL.NL_check_true_native(___nl__23)) {if (true) {goto label_11;}}
//line 330
___nl__22 = ((ImmHash)___nl__19).getHashValue()["annotation"].clone();
//line 330
___nl__22 = c_rt_lib_NL.NL_ov_is(___nl__22, new ImmString("math")).clone();
//line 330
___nl__22 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__22)).clone();
//line 330
label_11:
//line 330
___nl__23 = null;
//line 330
___nl__22 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__22)).clone();
//line 330
if (c_rt_lib_NL.NL_check_true_native(___nl__22)) {if (true) {goto label_10;}}
//line 331
___nl__23 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("math")).clone();
//line 331
___nl__24 = new ImmString("functions").clone();
//line 331
___nl__24 = c_rt_lib_NL.NL_get_ref_hash(___nl__12,___nl__24).clone();

//line 331
___nl__25 = c_rt_lib_NL.NL_get_ref_arr(___nl__24,___nl__15).clone();

//line 331
___nl__26 = ___nl__23.clone();
//line 331
((ImmHash)___nl__25).set("annotation", ___nl__26);
//line 331
c_rt_lib_NL.NL_set_ref_arr(ref ___nl__24,___nl__15,___nl__25);

//line 331
___nl__27 = new ImmString("functions").clone();
//line 331
c_rt_lib_NL.NL_set_ref_hash(ref ___nl__12,___nl__27,___nl__24);

//line 331
___nl__27 = null;
//line 331
___nl__23 = null;
//line 331
___nl__24 = null;
//line 331
___nl__25 = null;
//line 331
___nl__26 = null;
//line 332
___nl__23 = c_rt_lib_NL.NL_get_true().clone();
//line 332
___nl__18 = ___nl__23.clone();
//line 332
___nl__23 = null;
//line 333
if (true) {goto label_12;}
//line 333
label_10:
//line 333
___nl__22 = ___nl__21.clone();
//line 333
___nl__22 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__22)).clone();
//line 333
___nl__23 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__22)).clone();
//line 333
if (c_rt_lib_NL.NL_check_true_native(___nl__23)) {if (true) {goto label_13;}}
//line 333
___nl__22 = ((ImmHash)___nl__19).getHashValue()["annotation"].clone();
//line 333
___nl__22 = c_rt_lib_NL.NL_ov_is(___nl__22, new ImmString("state")).clone();
//line 333
___nl__22 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__22)).clone();
//line 333
label_13:
//line 333
___nl__23 = null;
//line 333
___nl__22 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__22)).clone();
//line 333
if (c_rt_lib_NL.NL_check_true_native(___nl__22)) {if (true) {goto label_12;}}
//line 334
___nl__23 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("state")).clone();
//line 334
___nl__24 = new ImmString("functions").clone();
//line 334
___nl__24 = c_rt_lib_NL.NL_get_ref_hash(___nl__12,___nl__24).clone();

//line 334
___nl__25 = c_rt_lib_NL.NL_get_ref_arr(___nl__24,___nl__15).clone();

//line 334
___nl__26 = ___nl__23.clone();
//line 334
((ImmHash)___nl__25).set("annotation", ___nl__26);
//line 334
c_rt_lib_NL.NL_set_ref_arr(ref ___nl__24,___nl__15,___nl__25);

//line 334
___nl__27 = new ImmString("functions").clone();
//line 334
c_rt_lib_NL.NL_set_ref_hash(ref ___nl__12,___nl__27,___nl__24);

//line 334
___nl__27 = null;
//line 334
___nl__23 = null;
//line 334
___nl__24 = null;
//line 334
___nl__25 = null;
//line 334
___nl__26 = null;
//line 335
___nl__23 = c_rt_lib_NL.NL_get_true().clone();
//line 335
___nl__18 = ___nl__23.clone();
//line 335
___nl__23 = null;
//line 336
if (true) {goto label_12;}
//line 336
label_12:
//line 336
___nl__22 = null;
//line 337
___nl__22 = hash_NL.NL_has_key(___nl__5,___nl__20).clone();

//line 337
___nl__22 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__22)).clone();
//line 337
if (c_rt_lib_NL.NL_check_true_native(___nl__22)) {if (true) {goto label_15;}}
//line 337
___nl__23 = c_rt_lib_NL.NL_get_true().clone();
//line 337
___nl__18 = ___nl__23.clone();
//line 337
___nl__23 = null;
//line 337
if (true) {goto label_15;}
//line 337
label_15:
//line 337
___nl__22 = null;
//line 338
___nl__22 = ___nl__18.clone();
//line 338
___nl__22 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__22)).clone();
//line 338
if (c_rt_lib_NL.NL_check_true_native(___nl__22)) {if (true) {goto label_17;}}
//line 339
___nl__23 = new ImmString("").clone();
//line 339
hash_NL.NL_set_value(ref ___nl__2,___nl__20,___nl__23);

//line 339
___nl__23 = null;
//line 340
___nl__23 = c_rt_lib_NL.NL_get_true().clone();
//line 340
___nl__13 = ___nl__23.clone();
//line 340
___nl__23 = null;
//line 341
if (true) {goto label_17;}
//line 341
label_17:
//line 341
___nl__22 = null;
//line 341
___nl__18 = null;
//line 341
___nl__19 = null;
//line 341
___nl__20 = null;
//line 341
___nl__21 = null;
//line 342
___nl__15 = new ImmDouble((Double.Parse(___nl__15.getValue().ToString()))+(Double.Parse(___nl__16.getValue().ToString()))).clone();
//line 342
if (true) {goto label_6;}
//line 342
label_4:
//line 342
___nl__14 = null;
//line 342
___nl__15 = null;
//line 342
___nl__16 = null;
//line 342
___nl__17 = null;
//line 343
___nl__14 = ___nl__13.clone();
//line 343
___nl__14 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__14)).clone();
//line 343
___nl__14 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__14)).clone();
//line 343
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_19;}}
//line 343
___nl__12 = null;
//line 343
___nl__13 = null;
//line 343
___nl__14 = null;
//line 343
if (true) {goto label_2;}
//line 343
if (true) {goto label_19;}
//line 343
label_19:
//line 343
___nl__14 = null;
//line 344
hash_NL.NL_set_value(ref ___nl__3,___nl__7,___nl__12);

//line 345
___nl__14 = new ImmString("nl_asm").clone();
//line 345
___nl__14 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__14).clone();

//line 345
hash_NL.NL_set_value(ref ___nl__14,___nl__7,___nl__12);

//line 345
___nl__15 = new ImmString("nl_asm").clone();
//line 345
c_rt_lib_NL.NL_set_ref_hash(ref ___nl__0,___nl__15,___nl__14);

//line 345
___nl__15 = null;
//line 345
___nl__14 = null;
//line 345
___nl__12 = null;
//line 345
___nl__13 = null;
//line 345
label_2:
//line 346
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))+(Double.Parse(___nl__9.getValue().ToString()))).clone();
//line 346
if (true) {goto label_3;}
//line 346
label_1:
//line 346
___nl__6 = null;
//line 346
___nl__7 = null;
//line 346
___nl__8 = null;
//line 346
___nl__9 = null;
//line 346
___nl__10 = null;
//line 346
___nl__11 = null;
//line 346
___nl__4 = null;
//line 346
___nl__5 = null;
//line 346
___nl__1 = null;
//line 346
___arg__0 = ___nl__0;___arg__2 = ___nl__2;___arg__3 = ___nl__3;if(true) return null;
}

private static Imm NL_set_const_reg_priv(ref Imm ___arg__0, Imm ___arg__1, Imm ___arg__2, Imm ___arg__3) {
Imm ___nl__0 = ___arg__0;Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);Imm ___nl__2 = null;c_rt_lib_NL.NL_copy(ref ___nl__2, ___arg__2);Imm ___nl__3 = null;c_rt_lib_NL.NL_copy(ref ___nl__3, ___arg__3);
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
Imm ___nl__9 = null;
Imm ___nl__10 = null;
Dictionary<String, Imm> __function_map;
//line 349
___nl__4 = new ImmArray(new Imm[0]).clone();
//line 350
___nl__5 = new ImmDouble(0).clone();
//line 350
___nl__6 = new ImmDouble(1).clone();
//line 350
label_3:
//line 350
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__3.getValue().ToString())) ).clone();
//line 350
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_1;}}
//line 351
___nl__8 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("no")).clone();
//line 351
array_NL.NL_push(ref ___nl__4,___nl__8);

//line 351
___nl__8 = null;
//line 352
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString()))).clone();
//line 352
if (true) {goto label_3;}
//line 352
label_1:
//line 352
___nl__5 = null;
//line 352
___nl__6 = null;
//line 352
___nl__7 = null;
//line 353
___nl__5 = new ImmArray(new Imm[0]).clone();
//line 354
___nl__7 = new ImmDouble(0).clone();
//line 354
___nl__8 = new ImmArray(new Imm[0]).clone();
//line 354
__function_map = new Dictionary<String, Imm>();
__function_map.Add("was",___nl__7);
__function_map.Add("regs",___nl__8);
___nl__6 = new ImmHash(__function_map).clone();
//line 354
___nl__7 = null;
//line 354
___nl__8 = null;
//line 355
___nl__7 = array_NL.NL_len(___nl__0).clone();

//line 355
___nl__8 = new ImmDouble(0).clone();
//line 355
___nl__9 = new ImmDouble(1).clone();
//line 355
label_6:
//line 355
___nl__10 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) ).clone();
//line 355
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_4;}}
//line 356
array_NL.NL_push(ref ___nl__5,___nl__6);

//line 357
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))+(Double.Parse(___nl__9.getValue().ToString()))).clone();
//line 357
if (true) {goto label_6;}
//line 357
label_4:
//line 357
___nl__7 = null;
//line 357
___nl__8 = null;
//line 357
___nl__9 = null;
//line 357
___nl__10 = null;
//line 358
___nl__7 = array_NL.NL_len(___nl__0).clone();

//line 358
___nl__8 = new ImmDouble(0).clone();
//line 358
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString())) ==((Double.Parse(___nl__8.getValue().ToString())))  ).clone();
//line 358
___nl__8 = null;
//line 358
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 358
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_8;}}
//line 358
___nl__8 = new ImmArray(new Imm[0]).clone();
//line 358
c_rt_lib_NL.NL_die();
//line 358
if (true) {goto label_8;}
//line 358
label_8:
//line 358
___nl__7 = null;
//line 358
___nl__8 = null;
//line 359
___nl__7 = new ImmDouble(0).clone();
//line 359
post_processing_NL.NL_set_const_block_priv(___nl__7,ref ___nl__0,___nl__1,ref ___nl__5,___nl__2,___nl__4);

//line 359
___nl__7 = null;
//line 359
___nl__4 = null;
//line 359
___nl__5 = null;
//line 359
___nl__6 = null;
//line 359
___nl__1 = null;
//line 359
___nl__2 = null;
//line 359
___nl__3 = null;
//line 359
___arg__0 = ___nl__0;if(true) return null;
}

private static Imm NL_evaluate_const_in_blocks_priv(ref Imm ___arg__0, Imm ___arg__1, Imm ___arg__2, Imm ___arg__3, Imm ___arg__4) {
Imm ___nl__0 = ___arg__0;Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);Imm ___nl__2 = null;c_rt_lib_NL.NL_copy(ref ___nl__2, ___arg__2);Imm ___nl__3 = null;c_rt_lib_NL.NL_copy(ref ___nl__3, ___arg__3);Imm ___nl__4 = null;c_rt_lib_NL.NL_copy(ref ___nl__4, ___arg__4);
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
Imm ___nl__9 = null;
Imm ___nl__10 = null;
Imm ___nl__11 = null;
Dictionary<String, Imm> __function_map;
//line 363
___nl__5 = new ImmArray(new Imm[0]).clone();
//line 364
___nl__6 = ((ImmHash)___nl__2).getHashValue()["reg_size"].clone();
//line 364
___nl__7 = new ImmDouble(0).clone();
//line 364
___nl__8 = new ImmDouble(1).clone();
//line 364
label_3:
//line 364
___nl__9 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) ).clone();
//line 364
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_1;}}
//line 365
___nl__10 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("no")).clone();
//line 365
array_NL.NL_push(ref ___nl__5,___nl__10);

//line 365
___nl__10 = null;
//line 366
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString()))).clone();
//line 366
if (true) {goto label_3;}
//line 366
label_1:
//line 366
___nl__6 = null;
//line 366
___nl__7 = null;
//line 366
___nl__8 = null;
//line 366
___nl__9 = null;
//line 367
___nl__6 = new ImmArray(new Imm[0]).clone();
//line 368
___nl__8 = new ImmDouble(0).clone();
//line 368
___nl__9 = new ImmArray(new Imm[0]).clone();
//line 368
__function_map = new Dictionary<String, Imm>();
__function_map.Add("was",___nl__8);
__function_map.Add("regs",___nl__9);
___nl__7 = new ImmHash(__function_map).clone();
//line 368
___nl__8 = null;
//line 368
___nl__9 = null;
//line 369
___nl__8 = array_NL.NL_len(___nl__0).clone();

//line 369
___nl__9 = new ImmDouble(0).clone();
//line 369
___nl__10 = new ImmDouble(1).clone();
//line 369
label_6:
//line 369
___nl__11 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__9.getValue().ToString()))>=(Double.Parse(___nl__8.getValue().ToString())) ).clone();
//line 369
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_4;}}
//line 370
array_NL.NL_push(ref ___nl__6,___nl__7);

//line 371
___nl__9 = new ImmDouble((Double.Parse(___nl__9.getValue().ToString()))+(Double.Parse(___nl__10.getValue().ToString()))).clone();
//line 371
if (true) {goto label_6;}
//line 371
label_4:
//line 371
___nl__8 = null;
//line 371
___nl__9 = null;
//line 371
___nl__10 = null;
//line 371
___nl__11 = null;
//line 372
___nl__8 = array_NL.NL_len(___nl__0).clone();

//line 372
___nl__9 = new ImmDouble(0).clone();
//line 372
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString())) ==((Double.Parse(___nl__9.getValue().ToString())))  ).clone();
//line 372
___nl__9 = null;
//line 372
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 372
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_8;}}
//line 372
___nl__9 = new ImmArray(new Imm[0]).clone();
//line 372
c_rt_lib_NL.NL_die();
//line 372
if (true) {goto label_8;}
//line 372
label_8:
//line 372
___nl__8 = null;
//line 372
___nl__9 = null;
//line 373
___nl__8 = ___nl__0.clone();
//line 375
___nl__9 = new ImmDouble(0).clone();
//line 375
post_processing_NL.NL_set_const_block_val_priv(___nl__9,___nl__0,ref ___nl__8,___nl__1,ref ___nl__6,___nl__4,___nl__5,___nl__2,___nl__3);

//line 375
___nl__9 = null;
//line 376
___nl__0 = ___nl__8.clone();
//line 376
___nl__5 = null;
//line 376
___nl__6 = null;
//line 376
___nl__7 = null;
//line 376
___nl__8 = null;
//line 376
___nl__1 = null;
//line 376
___nl__2 = null;
//line 376
___nl__3 = null;
//line 376
___nl__4 = null;
//line 376
___arg__0 = ___nl__0;if(true) return null;
}

private static Imm NL_check_sub_priv(ref Imm ___arg__0, Imm ___arg__1, ref Imm ___arg__2) {
Imm ___nl__0 = ___arg__0;Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);Imm ___nl__2 = ___arg__2;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 379
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("no")).clone();
//line 379
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 381
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("yes")).clone();
//line 381
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 381
___nl__3 = new ImmString("NOMATCHALERT").clone();
//line 381
___nl__3 = new ImmArray(new Imm[] {___nl__3,___nl__1,}).clone();
//line 381
c_rt_lib_NL.NL_die();
//line 379
label_2:
//line 380
___nl__4 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("no")).clone();
//line 380
___nl__0 = ___nl__4.clone();
//line 380
___nl__4 = null;
//line 381
if (true) {goto label_1;}
//line 381
label_3:
//line 381
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__1, new ImmString("yes")).clone();
//line 382
array_NL.NL_push(ref ___nl__2,___nl__4);

//line 382
___nl__4 = null;
//line 383
if (true) {goto label_1;}
//line 383
label_1:
//line 383
___nl__3 = null;
//line 383
___nl__1 = null;
//line 383
___arg__0 = ___nl__0;___arg__2 = ___nl__2;if(true) return null;
}

private static Imm NL_check_sub_val_priv(ref Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0;Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 386
___nl__2 = ___nl__1.clone();
//line 386
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("no")).clone();
//line 386
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 386
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 387
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("no")).clone();
//line 387
___nl__0 = ___nl__3.clone();
//line 387
___nl__3 = null;
//line 388
if (true) {goto label_2;}
//line 388
label_2:
//line 388
___nl__2 = null;
//line 388
___nl__1 = null;
//line 388
___arg__0 = ___nl__0;if(true) return null;
}

private static Imm NL_set_const_block_priv(Imm ___arg__0, ref Imm ___arg__1, Imm ___arg__2, ref Imm ___arg__3, Imm ___arg__4, Imm ___arg__5) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);Imm ___nl__1 = ___arg__1;Imm ___nl__2 = null;c_rt_lib_NL.NL_copy(ref ___nl__2, ___arg__2);Imm ___nl__3 = ___arg__3;Imm ___nl__4 = null;c_rt_lib_NL.NL_copy(ref ___nl__4, ___arg__4);Imm ___nl__5 = null;c_rt_lib_NL.NL_copy(ref ___nl__5, ___arg__5);
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
Imm ___nl__27 = null;
Imm ___nl__28 = null;
Dictionary<String, Imm> __function_map;
//line 392
___nl__6 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__0).getDoubleValue()].clone();
//line 393
___nl__7 = (___nl__3 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__0).getDoubleValue()].clone();
//line 393
___nl__7 = ((ImmHash)___nl__7).getHashValue()["was"].clone();
//line 393
___nl__8 = new ImmDouble(0).clone();
//line 393
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))>(Double.Parse(___nl__8.getValue().ToString())) ).clone();
//line 393
___nl__8 = null;
//line 393
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 393
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_2;}}
//line 394
___nl__8 = c_rt_lib_NL.NL_get_false().clone();
//line 395
___nl__9 = (___nl__3 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__0).getDoubleValue()].clone();
//line 395
___nl__9 = ((ImmHash)___nl__9).getHashValue()["regs"].clone();
//line 396
___nl__10 = array_NL.NL_len(___nl__5).clone();

//line 396
___nl__11 = new ImmDouble(0).clone();
//line 396
___nl__12 = new ImmDouble(1).clone();
//line 396
label_5:
//line 396
___nl__13 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__11.getValue().ToString()))>=(Double.Parse(___nl__10.getValue().ToString())) ).clone();
//line 396
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_3;}}
//line 397
___nl__14 = (___nl__9 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__11).getDoubleValue()].clone();
//line 397
___nl__14 = c_rt_lib_NL.NL_ov_is(___nl__14, new ImmString("no")).clone();
//line 397
___nl__14 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__14)).clone();
//line 397
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_7;}}
//line 398
___nl__15 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("no")).clone();
//line 398
___nl__16 = ___nl__15.clone();
//line 398
(___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__11).getDoubleValue()] = ___nl__16;
//line 398
___nl__15 = null;
//line 398
___nl__16 = null;
//line 399
___nl__14 = null;
//line 399
if (true) {goto label_4;}
//line 400
if (true) {goto label_6;}
//line 400
label_7:
//line 401
___nl__15 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__11).getDoubleValue()].clone();
//line 401
___nl__15 = c_rt_lib_NL.NL_ov_is(___nl__15, new ImmString("yes")).clone();
//line 401
___nl__15 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__15)).clone();
//line 401
if (c_rt_lib_NL.NL_check_true_native(___nl__15)) {if (true) {goto label_9;}}
//line 402
___nl__16 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__11).getDoubleValue()].clone();
//line 402
___nl__16 = c_rt_lib_NL.NL_ov_as(___nl__16, new ImmString("yes")).clone();
//line 403
___nl__17 = (___nl__9 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__11).getDoubleValue()].clone();
//line 403
___nl__17 = c_rt_lib_NL.NL_ov_as(___nl__17, new ImmString("yes")).clone();
//line 404
___nl__18 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__16.getValue().ToString())) ==((Double.Parse(___nl__17.getValue().ToString())))  ).clone();
//line 404
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 404
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_11;}}
//line 404
___nl__14 = null;
//line 404
___nl__15 = null;
//line 404
___nl__16 = null;
//line 404
___nl__17 = null;
//line 404
___nl__18 = null;
//line 404
if (true) {goto label_4;}
//line 404
if (true) {goto label_11;}
//line 404
label_11:
//line 404
___nl__18 = null;
//line 404
___nl__16 = null;
//line 404
___nl__17 = null;
//line 405
if (true) {goto label_9;}
//line 405
label_9:
//line 405
___nl__15 = null;
//line 406
___nl__15 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("no")).clone();
//line 406
___nl__16 = ___nl__15.clone();
//line 406
(___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__11).getDoubleValue()] = ___nl__16;
//line 406
___nl__15 = null;
//line 406
___nl__16 = null;
//line 407
___nl__15 = c_rt_lib_NL.NL_get_true().clone();
//line 407
___nl__8 = ___nl__15.clone();
//line 407
___nl__15 = null;
//line 408
if (true) {goto label_6;}
//line 408
label_6:
//line 408
___nl__14 = null;
//line 408
label_4:
//line 409
___nl__11 = new ImmDouble((Double.Parse(___nl__11.getValue().ToString()))+(Double.Parse(___nl__12.getValue().ToString()))).clone();
//line 409
if (true) {goto label_5;}
//line 409
label_3:
//line 409
___nl__10 = null;
//line 409
___nl__11 = null;
//line 409
___nl__12 = null;
//line 409
___nl__13 = null;
//line 410
___nl__10 = ___nl__8.clone();
//line 410
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 410
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 410
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_13;}}
//line 410
___nl__0 = null;
//line 410
___nl__2 = null;
//line 410
___nl__4 = null;
//line 410
___nl__5 = null;
//line 410
___nl__6 = null;
//line 410
___nl__7 = null;
//line 410
___nl__8 = null;
//line 410
___nl__9 = null;
//line 410
___nl__10 = null;
//line 410
___arg__1 = ___nl__1;___arg__3 = ___nl__3;if(true) return null;
//line 410
if (true) {goto label_13;}
//line 410
label_13:
//line 410
___nl__10 = null;
//line 411
___nl__10 = c_rt_lib_NL.NL_get_ref_arr(___nl__3,___nl__0).clone();

//line 411
___nl__11 = ___nl__5.clone();
//line 411
((ImmHash)___nl__10).set("regs", ___nl__11);
//line 411
c_rt_lib_NL.NL_set_ref_arr(ref ___nl__3,___nl__0,___nl__10);

//line 411
___nl__10 = null;
//line 411
___nl__11 = null;
//line 411
___nl__8 = null;
//line 411
___nl__9 = null;
//line 412
if (true) {goto label_1;}
//line 412
label_2:
//line 413
___nl__8 = c_rt_lib_NL.NL_get_ref_arr(___nl__3,___nl__0).clone();

//line 413
___nl__9 = ___nl__5.clone();
//line 413
((ImmHash)___nl__8).set("regs", ___nl__9);
//line 413
c_rt_lib_NL.NL_set_ref_arr(ref ___nl__3,___nl__0,___nl__8);

//line 413
___nl__8 = null;
//line 413
___nl__9 = null;
//line 414
if (true) {goto label_1;}
//line 414
label_1:
//line 414
___nl__7 = null;
//line 415
___nl__7 = c_rt_lib_NL.NL_get_ref_arr(___nl__3,___nl__0).clone();

//line 415
___nl__8 = new ImmString("was").clone();
//line 415
___nl__8 = c_rt_lib_NL.NL_get_ref_hash(___nl__7,___nl__8).clone();

//line 415
___nl__9 = new ImmDouble(1).clone();
//line 415
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))+(Double.Parse(___nl__9.getValue().ToString()))).clone();
//line 415
___nl__10 = new ImmString("was").clone();
//line 415
c_rt_lib_NL.NL_set_ref_hash(ref ___nl__7,___nl__10,___nl__8);

//line 415
c_rt_lib_NL.NL_set_ref_arr(ref ___nl__3,___nl__0,___nl__7);

//line 415
___nl__10 = null;
//line 415
___nl__7 = null;
//line 415
___nl__8 = null;
//line 415
___nl__9 = null;
//line 416
___nl__7 = ((ImmHash)___nl__6).getHashValue()["cmds"].clone();
//line 417
___nl__8 = array_NL.NL_len(___nl__7).clone();

//line 417
___nl__9 = new ImmDouble(0).clone();
//line 417
___nl__10 = new ImmDouble(1).clone();
//line 417
label_16:
//line 417
___nl__11 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__9.getValue().ToString()))>=(Double.Parse(___nl__8.getValue().ToString())) ).clone();
//line 417
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_14;}}
//line 418
___nl__12 = new ImmArray(new Imm[0]).clone();
//line 419
___nl__13 = new ImmArray(new Imm[0]).clone();
//line 420
___nl__14 = ((ImmHash)___nl__6).getHashValue()["from"].clone();
//line 420
___nl__14 = new ImmDouble((Double.Parse(___nl__9.getValue().ToString()))+(Double.Parse(___nl__14.getValue().ToString()))).clone();
//line 420
___nl__14 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("yes"), ___nl__14).clone();
//line 421
___nl__15 = (___nl__7 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()].clone();
//line 421
___nl__15 = ((ImmHash)___nl__15).getHashValue()["cmd"].clone();
//line 421
___nl__16 = c_rt_lib_NL.NL_ov_is(___nl__15, new ImmString("arr_decl")).clone();
//line 421
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_18;}}
//line 427
___nl__16 = c_rt_lib_NL.NL_ov_is(___nl__15, new ImmString("hash_decl")).clone();
//line 427
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_19;}}
//line 433
___nl__16 = c_rt_lib_NL.NL_ov_is(___nl__15, new ImmString("call")).clone();
//line 433
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_20;}}
//line 458
___nl__16 = c_rt_lib_NL.NL_ov_is(___nl__15, new ImmString("una_op")).clone();
//line 458
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_21;}}
//line 462
___nl__16 = c_rt_lib_NL.NL_ov_is(___nl__15, new ImmString("bin_op")).clone();
//line 462
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_22;}}
//line 467
___nl__16 = c_rt_lib_NL.NL_ov_is(___nl__15, new ImmString("ov_is")).clone();
//line 467
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_23;}}
//line 471
___nl__16 = c_rt_lib_NL.NL_ov_is(___nl__15, new ImmString("ov_as")).clone();
//line 471
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_24;}}
//line 475
___nl__16 = c_rt_lib_NL.NL_ov_is(___nl__15, new ImmString("func")).clone();
//line 475
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_25;}}
//line 478
___nl__16 = c_rt_lib_NL.NL_ov_is(___nl__15, new ImmString("move")).clone();
//line 478
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_26;}}
//line 482
___nl__16 = c_rt_lib_NL.NL_ov_is(___nl__15, new ImmString("load_const")).clone();
//line 482
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_27;}}
//line 485
___nl__16 = c_rt_lib_NL.NL_ov_is(___nl__15, new ImmString("get_frm_idx")).clone();
//line 485
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_28;}}
//line 490
___nl__16 = c_rt_lib_NL.NL_ov_is(___nl__15, new ImmString("set_at_idx")).clone();
//line 490
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_29;}}
//line 496
___nl__16 = c_rt_lib_NL.NL_ov_is(___nl__15, new ImmString("get_val")).clone();
//line 496
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_30;}}
//line 500
___nl__16 = c_rt_lib_NL.NL_ov_is(___nl__15, new ImmString("set_val")).clone();
//line 500
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_31;}}
//line 505
___nl__16 = c_rt_lib_NL.NL_ov_is(___nl__15, new ImmString("ov_mk")).clone();
//line 505
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_32;}}
//line 511
___nl__16 = c_rt_lib_NL.NL_ov_is(___nl__15, new ImmString("return")).clone();
//line 511
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_33;}}
//line 515
___nl__16 = c_rt_lib_NL.NL_ov_is(___nl__15, new ImmString("die")).clone();
//line 515
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_34;}}
//line 517
___nl__16 = c_rt_lib_NL.NL_ov_is(___nl__15, new ImmString("prt_lbl")).clone();
//line 517
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_35;}}
//line 519
___nl__16 = c_rt_lib_NL.NL_ov_is(___nl__15, new ImmString("if_goto")).clone();
//line 519
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_36;}}
//line 521
___nl__16 = c_rt_lib_NL.NL_ov_is(___nl__15, new ImmString("goto")).clone();
//line 521
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_37;}}
//line 523
___nl__16 = c_rt_lib_NL.NL_ov_is(___nl__15, new ImmString("clear")).clone();
//line 523
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_38;}}
//line 523
___nl__16 = new ImmString("NOMATCHALERT").clone();
//line 523
___nl__16 = new ImmArray(new Imm[] {___nl__16,___nl__15,}).clone();
//line 523
c_rt_lib_NL.NL_die();
//line 421
label_18:
//line 421
___nl__17 = c_rt_lib_NL.NL_ov_as(___nl__15, new ImmString("arr_decl")).clone();
//line 422
___nl__18 = ((ImmHash)___nl__17).getHashValue()["src"].clone();
//line 422
___nl__20 = new ImmDouble(0).clone();
//line 422
___nl__21 = new ImmDouble(1).clone();
//line 422
___nl__22 = c_rt_lib_NL.NL_array_len(___nl__18).clone();

//line 422
label_41:
//line 422
___nl__23 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__20.getValue().ToString()))>=(Double.Parse(___nl__22.getValue().ToString())) ).clone();
//line 422
if (c_rt_lib_NL.NL_check_true_native(___nl__23)) {if (true) {goto label_39;}}
//line 422
___nl__19 = (___nl__18 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__20).getDoubleValue()].clone();
//line 423
___nl__24 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__19).getDoubleValue()].clone();
//line 423
post_processing_NL.NL_check_sub_priv(ref ___nl__14,___nl__24,ref ___nl__12);

//line 423
___nl__24 = null;
//line 424
___nl__20 = new ImmDouble((Double.Parse(___nl__20.getValue().ToString()))+(Double.Parse(___nl__21.getValue().ToString()))).clone();
//line 424
if (true) {goto label_41;}
//line 424
label_39:
//line 424
___nl__18 = null;
//line 424
___nl__19 = null;
//line 424
___nl__20 = null;
//line 424
___nl__21 = null;
//line 424
___nl__22 = null;
//line 424
___nl__23 = null;
//line 425
___nl__18 = ((ImmHash)___nl__17).getHashValue()["dest"].clone();
//line 425
___nl__19 = new ImmString("").clone();
//line 425
___nl__18 = c_rt_lib_NL.NL_native_to_nl(___nl__18.toString().Equals(___nl__19.toString())).clone();
//line 425
___nl__19 = null;
//line 425
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 425
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 425
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_43;}}
//line 425
___nl__20 = ((ImmHash)___nl__17).getHashValue()["dest"].clone();
//line 425
___nl__19 = ___nl__14.clone();
//line 425
(___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__20).getDoubleValue()] = ___nl__19;
//line 425
___nl__19 = null;
//line 425
___nl__20 = null;
//line 425
if (true) {goto label_43;}
//line 425
label_43:
//line 425
___nl__18 = null;
//line 426
___nl__18 = ((ImmHash)___nl__17).getHashValue()["dest"].clone();
//line 426
array_NL.NL_push(ref ___nl__13,___nl__18);

//line 426
___nl__18 = null;
//line 426
___nl__17 = null;
//line 427
if (true) {goto label_17;}
//line 427
label_19:
//line 427
___nl__17 = c_rt_lib_NL.NL_ov_as(___nl__15, new ImmString("hash_decl")).clone();
//line 428
___nl__18 = ((ImmHash)___nl__17).getHashValue()["src"].clone();
//line 428
___nl__20 = new ImmDouble(0).clone();
//line 428
___nl__21 = new ImmDouble(1).clone();
//line 428
___nl__22 = c_rt_lib_NL.NL_array_len(___nl__18).clone();

//line 428
label_46:
//line 428
___nl__23 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__20.getValue().ToString()))>=(Double.Parse(___nl__22.getValue().ToString())) ).clone();
//line 428
if (c_rt_lib_NL.NL_check_true_native(___nl__23)) {if (true) {goto label_44;}}
//line 428
___nl__19 = (___nl__18 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__20).getDoubleValue()].clone();
//line 429
___nl__25 = ((ImmHash)___nl__19).getHashValue()["val"].clone();
//line 429
___nl__24 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__25).getDoubleValue()].clone();
//line 429
___nl__25 = null;
//line 429
post_processing_NL.NL_check_sub_priv(ref ___nl__14,___nl__24,ref ___nl__12);

//line 429
___nl__24 = null;
//line 430
___nl__20 = new ImmDouble((Double.Parse(___nl__20.getValue().ToString()))+(Double.Parse(___nl__21.getValue().ToString()))).clone();
//line 430
if (true) {goto label_46;}
//line 430
label_44:
//line 430
___nl__18 = null;
//line 430
___nl__19 = null;
//line 430
___nl__20 = null;
//line 430
___nl__21 = null;
//line 430
___nl__22 = null;
//line 430
___nl__23 = null;
//line 431
___nl__18 = ((ImmHash)___nl__17).getHashValue()["dest"].clone();
//line 431
___nl__19 = new ImmString("").clone();
//line 431
___nl__18 = c_rt_lib_NL.NL_native_to_nl(___nl__18.toString().Equals(___nl__19.toString())).clone();
//line 431
___nl__19 = null;
//line 431
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 431
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 431
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_48;}}
//line 431
___nl__20 = ((ImmHash)___nl__17).getHashValue()["dest"].clone();
//line 431
___nl__19 = ___nl__14.clone();
//line 431
(___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__20).getDoubleValue()] = ___nl__19;
//line 431
___nl__19 = null;
//line 431
___nl__20 = null;
//line 431
if (true) {goto label_48;}
//line 431
label_48:
//line 431
___nl__18 = null;
//line 432
___nl__18 = ((ImmHash)___nl__17).getHashValue()["dest"].clone();
//line 432
array_NL.NL_push(ref ___nl__13,___nl__18);

//line 432
___nl__18 = null;
//line 432
___nl__17 = null;
//line 433
if (true) {goto label_17;}
//line 433
label_20:
//line 433
___nl__17 = c_rt_lib_NL.NL_ov_as(___nl__15, new ImmString("call")).clone();
//line 434
___nl__18 = ((ImmHash)___nl__17).getHashValue()["mod"].clone();
//line 434
___nl__19 = new ImmString("").clone();
//line 434
___nl__18 = c_rt_lib_NL.NL_native_to_nl(___nl__18.toString().Equals(___nl__19.toString())).clone();
//line 434
___nl__19 = null;
//line 434
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_50;}}
//line 434
___nl__18 = ((ImmHash)___nl__17).getHashValue()["mod"].clone();
//line 434
if (true) {goto label_49;}
//line 434
label_50:
//line 434
___nl__18 = new ImmString("_priv").clone();
//line 434
___nl__18 = new ImmString(___nl__4.toString() + ___nl__18.toString()).clone();
//line 434
label_49:
//line 434
___nl__19 = new ImmString("::").clone();
//line 434
___nl__18 = new ImmString(___nl__18.toString() + ___nl__19.toString()).clone();
//line 434
___nl__19 = null;
//line 434
___nl__19 = ((ImmHash)___nl__17).getHashValue()["fun_name"].clone();
//line 434
___nl__18 = new ImmString(___nl__18.toString() + ___nl__19.toString()).clone();
//line 434
___nl__19 = null;
//line 435
___nl__19 = hash_NL.NL_has_key(___nl__2,___nl__18).clone();

//line 435
___nl__19 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__19)).clone();
//line 435
if (c_rt_lib_NL.NL_check_true_native(___nl__19)) {if (true) {goto label_52;}}
//line 436
___nl__20 = hash_NL.NL_get_value(___nl__2,___nl__18).clone();

//line 436
___nl__20 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__20)).clone();
//line 436
___nl__20 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__20)).clone();
//line 436
if (c_rt_lib_NL.NL_check_true_native(___nl__20)) {if (true) {goto label_54;}}
//line 436
___nl__21 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("no")).clone();
//line 436
___nl__14 = ___nl__21.clone();
//line 436
___nl__21 = null;
//line 436
if (true) {goto label_54;}
//line 436
label_54:
//line 436
___nl__20 = null;
//line 437
if (true) {goto label_51;}
//line 437
label_52:
//line 438
___nl__20 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("no")).clone();
//line 438
___nl__14 = ___nl__20.clone();
//line 438
___nl__20 = null;
//line 439
if (true) {goto label_51;}
//line 439
label_51:
//line 439
___nl__19 = null;
//line 440
___nl__19 = ___nl__14.clone();
//line 440
___nl__19 = c_rt_lib_NL.NL_ov_is(___nl__19, new ImmString("yes")).clone();
//line 440
___nl__19 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__19)).clone();
//line 440
if (c_rt_lib_NL.NL_check_true_native(___nl__19)) {if (true) {goto label_56;}}
//line 441
___nl__20 = ((ImmHash)___nl__17).getHashValue()["args"].clone();
//line 441
___nl__22 = new ImmDouble(0).clone();
//line 441
___nl__23 = new ImmDouble(1).clone();
//line 441
___nl__24 = c_rt_lib_NL.NL_array_len(___nl__20).clone();

//line 441
label_59:
//line 441
___nl__25 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__22.getValue().ToString()))>=(Double.Parse(___nl__24.getValue().ToString())) ).clone();
//line 441
if (c_rt_lib_NL.NL_check_true_native(___nl__25)) {if (true) {goto label_57;}}
//line 441
___nl__21 = (___nl__20 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__22).getDoubleValue()].clone();
//line 442
___nl__26 = c_rt_lib_NL.NL_ov_is(___nl__21, new ImmString("val")).clone();
//line 442
if (c_rt_lib_NL.NL_check_true_native(___nl__26)) {if (true) {goto label_61;}}
//line 444
___nl__26 = c_rt_lib_NL.NL_ov_is(___nl__21, new ImmString("ref")).clone();
//line 444
if (c_rt_lib_NL.NL_check_true_native(___nl__26)) {if (true) {goto label_62;}}
//line 444
___nl__26 = new ImmString("NOMATCHALERT").clone();
//line 444
___nl__26 = new ImmArray(new Imm[] {___nl__26,___nl__21,}).clone();
//line 444
c_rt_lib_NL.NL_die();
//line 442
label_61:
//line 442
___nl__27 = c_rt_lib_NL.NL_ov_as(___nl__21, new ImmString("val")).clone();
//line 443
___nl__28 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__27).getDoubleValue()].clone();
//line 443
post_processing_NL.NL_check_sub_priv(ref ___nl__14,___nl__28,ref ___nl__12);

//line 443
___nl__28 = null;
//line 443
___nl__27 = null;
//line 444
if (true) {goto label_60;}
//line 444
label_62:
//line 444
___nl__27 = c_rt_lib_NL.NL_ov_as(___nl__21, new ImmString("ref")).clone();
//line 445
___nl__28 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__27).getDoubleValue()].clone();
//line 445
post_processing_NL.NL_check_sub_priv(ref ___nl__14,___nl__28,ref ___nl__12);

//line 445
___nl__28 = null;
//line 445
___nl__27 = null;
//line 446
if (true) {goto label_60;}
//line 446
label_60:
//line 446
___nl__26 = null;
//line 447
___nl__22 = new ImmDouble((Double.Parse(___nl__22.getValue().ToString()))+(Double.Parse(___nl__23.getValue().ToString()))).clone();
//line 447
if (true) {goto label_59;}
//line 447
label_57:
//line 447
___nl__20 = null;
//line 447
___nl__21 = null;
//line 447
___nl__22 = null;
//line 447
___nl__23 = null;
//line 447
___nl__24 = null;
//line 447
___nl__25 = null;
//line 448
if (true) {goto label_56;}
//line 448
label_56:
//line 448
___nl__19 = null;
//line 449
___nl__19 = ((ImmHash)___nl__17).getHashValue()["args"].clone();
//line 449
___nl__21 = new ImmDouble(0).clone();
//line 449
___nl__22 = new ImmDouble(1).clone();
//line 449
___nl__23 = c_rt_lib_NL.NL_array_len(___nl__19).clone();

//line 449
label_65:
//line 449
___nl__24 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__21.getValue().ToString()))>=(Double.Parse(___nl__23.getValue().ToString())) ).clone();
//line 449
if (c_rt_lib_NL.NL_check_true_native(___nl__24)) {if (true) {goto label_63;}}
//line 449
___nl__20 = (___nl__19 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__21).getDoubleValue()].clone();
//line 450
___nl__25 = c_rt_lib_NL.NL_ov_is(___nl__20, new ImmString("val")).clone();
//line 450
if (c_rt_lib_NL.NL_check_true_native(___nl__25)) {if (true) {goto label_67;}}
//line 451
___nl__25 = c_rt_lib_NL.NL_ov_is(___nl__20, new ImmString("ref")).clone();
//line 451
if (c_rt_lib_NL.NL_check_true_native(___nl__25)) {if (true) {goto label_68;}}
//line 451
___nl__25 = new ImmString("NOMATCHALERT").clone();
//line 451
___nl__25 = new ImmArray(new Imm[] {___nl__25,___nl__20,}).clone();
//line 451
c_rt_lib_NL.NL_die();
//line 450
label_67:
//line 450
___nl__26 = c_rt_lib_NL.NL_ov_as(___nl__20, new ImmString("val")).clone();
//line 450
___nl__26 = null;
//line 451
if (true) {goto label_66;}
//line 451
label_68:
//line 451
___nl__26 = c_rt_lib_NL.NL_ov_as(___nl__20, new ImmString("ref")).clone();
//line 452
___nl__27 = ___nl__14.clone();
//line 452
(___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__26).getDoubleValue()] = ___nl__27;
//line 452
___nl__27 = null;
//line 453
array_NL.NL_push(ref ___nl__13,___nl__26);

//line 453
___nl__26 = null;
//line 454
if (true) {goto label_66;}
//line 454
label_66:
//line 454
___nl__25 = null;
//line 455
___nl__21 = new ImmDouble((Double.Parse(___nl__21.getValue().ToString()))+(Double.Parse(___nl__22.getValue().ToString()))).clone();
//line 455
if (true) {goto label_65;}
//line 455
label_63:
//line 455
___nl__19 = null;
//line 455
___nl__20 = null;
//line 455
___nl__21 = null;
//line 455
___nl__22 = null;
//line 455
___nl__23 = null;
//line 455
___nl__24 = null;
//line 456
___nl__19 = ((ImmHash)___nl__17).getHashValue()["dest"].clone();
//line 456
___nl__20 = new ImmString("").clone();
//line 456
___nl__19 = c_rt_lib_NL.NL_native_to_nl(___nl__19.toString().Equals(___nl__20.toString())).clone();
//line 456
___nl__20 = null;
//line 456
___nl__19 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__19)).clone();
//line 456
___nl__19 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__19)).clone();
//line 456
if (c_rt_lib_NL.NL_check_true_native(___nl__19)) {if (true) {goto label_70;}}
//line 456
___nl__21 = ((ImmHash)___nl__17).getHashValue()["dest"].clone();
//line 456
___nl__20 = ___nl__14.clone();
//line 456
(___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__21).getDoubleValue()] = ___nl__20;
//line 456
___nl__20 = null;
//line 456
___nl__21 = null;
//line 456
if (true) {goto label_70;}
//line 456
label_70:
//line 456
___nl__19 = null;
//line 457
___nl__19 = ((ImmHash)___nl__17).getHashValue()["dest"].clone();
//line 457
array_NL.NL_push(ref ___nl__13,___nl__19);

//line 457
___nl__19 = null;
//line 457
___nl__18 = null;
//line 457
___nl__17 = null;
//line 458
if (true) {goto label_17;}
//line 458
label_21:
//line 458
___nl__17 = c_rt_lib_NL.NL_ov_as(___nl__15, new ImmString("una_op")).clone();
//line 459
___nl__19 = ((ImmHash)___nl__17).getHashValue()["src"].clone();
//line 459
___nl__18 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__19).getDoubleValue()].clone();
//line 459
___nl__19 = null;
//line 459
post_processing_NL.NL_check_sub_priv(ref ___nl__14,___nl__18,ref ___nl__12);

//line 459
___nl__18 = null;
//line 460
___nl__18 = ((ImmHash)___nl__17).getHashValue()["dest"].clone();
//line 460
___nl__19 = new ImmString("").clone();
//line 460
___nl__18 = c_rt_lib_NL.NL_native_to_nl(___nl__18.toString().Equals(___nl__19.toString())).clone();
//line 460
___nl__19 = null;
//line 460
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 460
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 460
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_72;}}
//line 460
___nl__20 = ((ImmHash)___nl__17).getHashValue()["dest"].clone();
//line 460
___nl__19 = ___nl__14.clone();
//line 460
(___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__20).getDoubleValue()] = ___nl__19;
//line 460
___nl__19 = null;
//line 460
___nl__20 = null;
//line 460
if (true) {goto label_72;}
//line 460
label_72:
//line 460
___nl__18 = null;
//line 461
___nl__18 = ((ImmHash)___nl__17).getHashValue()["dest"].clone();
//line 461
array_NL.NL_push(ref ___nl__13,___nl__18);

//line 461
___nl__18 = null;
//line 461
___nl__17 = null;
//line 462
if (true) {goto label_17;}
//line 462
label_22:
//line 462
___nl__17 = c_rt_lib_NL.NL_ov_as(___nl__15, new ImmString("bin_op")).clone();
//line 463
___nl__19 = ((ImmHash)___nl__17).getHashValue()["left"].clone();
//line 463
___nl__18 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__19).getDoubleValue()].clone();
//line 463
___nl__19 = null;
//line 463
post_processing_NL.NL_check_sub_priv(ref ___nl__14,___nl__18,ref ___nl__12);

//line 463
___nl__18 = null;
//line 464
___nl__19 = ((ImmHash)___nl__17).getHashValue()["right"].clone();
//line 464
___nl__18 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__19).getDoubleValue()].clone();
//line 464
___nl__19 = null;
//line 464
post_processing_NL.NL_check_sub_priv(ref ___nl__14,___nl__18,ref ___nl__12);

//line 464
___nl__18 = null;
//line 465
___nl__18 = ((ImmHash)___nl__17).getHashValue()["dest"].clone();
//line 465
___nl__19 = new ImmString("").clone();
//line 465
___nl__18 = c_rt_lib_NL.NL_native_to_nl(___nl__18.toString().Equals(___nl__19.toString())).clone();
//line 465
___nl__19 = null;
//line 465
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 465
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 465
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_74;}}
//line 465
___nl__20 = ((ImmHash)___nl__17).getHashValue()["dest"].clone();
//line 465
___nl__19 = ___nl__14.clone();
//line 465
(___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__20).getDoubleValue()] = ___nl__19;
//line 465
___nl__19 = null;
//line 465
___nl__20 = null;
//line 465
if (true) {goto label_74;}
//line 465
label_74:
//line 465
___nl__18 = null;
//line 466
___nl__18 = ((ImmHash)___nl__17).getHashValue()["dest"].clone();
//line 466
array_NL.NL_push(ref ___nl__13,___nl__18);

//line 466
___nl__18 = null;
//line 466
___nl__17 = null;
//line 467
if (true) {goto label_17;}
//line 467
label_23:
//line 467
___nl__17 = c_rt_lib_NL.NL_ov_as(___nl__15, new ImmString("ov_is")).clone();
//line 468
___nl__19 = ((ImmHash)___nl__17).getHashValue()["src"].clone();
//line 468
___nl__18 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__19).getDoubleValue()].clone();
//line 468
___nl__19 = null;
//line 468
post_processing_NL.NL_check_sub_priv(ref ___nl__14,___nl__18,ref ___nl__12);

//line 468
___nl__18 = null;
//line 469
___nl__18 = ((ImmHash)___nl__17).getHashValue()["dest"].clone();
//line 469
___nl__19 = new ImmString("").clone();
//line 469
___nl__18 = c_rt_lib_NL.NL_native_to_nl(___nl__18.toString().Equals(___nl__19.toString())).clone();
//line 469
___nl__19 = null;
//line 469
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 469
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 469
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_76;}}
//line 469
___nl__20 = ((ImmHash)___nl__17).getHashValue()["dest"].clone();
//line 469
___nl__19 = ___nl__14.clone();
//line 469
(___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__20).getDoubleValue()] = ___nl__19;
//line 469
___nl__19 = null;
//line 469
___nl__20 = null;
//line 469
if (true) {goto label_76;}
//line 469
label_76:
//line 469
___nl__18 = null;
//line 470
___nl__18 = ((ImmHash)___nl__17).getHashValue()["dest"].clone();
//line 470
array_NL.NL_push(ref ___nl__13,___nl__18);

//line 470
___nl__18 = null;
//line 470
___nl__17 = null;
//line 471
if (true) {goto label_17;}
//line 471
label_24:
//line 471
___nl__17 = c_rt_lib_NL.NL_ov_as(___nl__15, new ImmString("ov_as")).clone();
//line 472
___nl__19 = ((ImmHash)___nl__17).getHashValue()["src"].clone();
//line 472
___nl__18 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__19).getDoubleValue()].clone();
//line 472
___nl__19 = null;
//line 472
post_processing_NL.NL_check_sub_priv(ref ___nl__14,___nl__18,ref ___nl__12);

//line 472
___nl__18 = null;
//line 473
___nl__18 = ((ImmHash)___nl__17).getHashValue()["dest"].clone();
//line 473
___nl__19 = new ImmString("").clone();
//line 473
___nl__18 = c_rt_lib_NL.NL_native_to_nl(___nl__18.toString().Equals(___nl__19.toString())).clone();
//line 473
___nl__19 = null;
//line 473
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 473
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 473
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_78;}}
//line 473
___nl__20 = ((ImmHash)___nl__17).getHashValue()["dest"].clone();
//line 473
___nl__19 = ___nl__14.clone();
//line 473
(___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__20).getDoubleValue()] = ___nl__19;
//line 473
___nl__19 = null;
//line 473
___nl__20 = null;
//line 473
if (true) {goto label_78;}
//line 473
label_78:
//line 473
___nl__18 = null;
//line 474
___nl__18 = ((ImmHash)___nl__17).getHashValue()["dest"].clone();
//line 474
array_NL.NL_push(ref ___nl__13,___nl__18);

//line 474
___nl__18 = null;
//line 474
___nl__17 = null;
//line 475
if (true) {goto label_17;}
//line 475
label_25:
//line 475
___nl__17 = c_rt_lib_NL.NL_ov_as(___nl__15, new ImmString("func")).clone();
//line 476
___nl__18 = ((ImmHash)___nl__17).getHashValue()["dest"].clone();
//line 476
___nl__19 = new ImmString("").clone();
//line 476
___nl__18 = c_rt_lib_NL.NL_native_to_nl(___nl__18.toString().Equals(___nl__19.toString())).clone();
//line 476
___nl__19 = null;
//line 476
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 476
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 476
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_80;}}
//line 476
___nl__20 = ((ImmHash)___nl__17).getHashValue()["dest"].clone();
//line 476
___nl__19 = ___nl__14.clone();
//line 476
(___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__20).getDoubleValue()] = ___nl__19;
//line 476
___nl__19 = null;
//line 476
___nl__20 = null;
//line 476
if (true) {goto label_80;}
//line 476
label_80:
//line 476
___nl__18 = null;
//line 477
___nl__18 = ((ImmHash)___nl__17).getHashValue()["dest"].clone();
//line 477
array_NL.NL_push(ref ___nl__13,___nl__18);

//line 477
___nl__18 = null;
//line 477
___nl__17 = null;
//line 478
if (true) {goto label_17;}
//line 478
label_26:
//line 478
___nl__17 = c_rt_lib_NL.NL_ov_as(___nl__15, new ImmString("move")).clone();
//line 479
___nl__19 = ((ImmHash)___nl__17).getHashValue()["src"].clone();
//line 479
___nl__18 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__19).getDoubleValue()].clone();
//line 479
___nl__19 = null;
//line 479
post_processing_NL.NL_check_sub_priv(ref ___nl__14,___nl__18,ref ___nl__12);

//line 479
___nl__18 = null;
//line 480
___nl__18 = ((ImmHash)___nl__17).getHashValue()["dest"].clone();
//line 480
___nl__19 = new ImmString("").clone();
//line 480
___nl__18 = c_rt_lib_NL.NL_native_to_nl(___nl__18.toString().Equals(___nl__19.toString())).clone();
//line 480
___nl__19 = null;
//line 480
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 480
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 480
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_82;}}
//line 480
___nl__20 = ((ImmHash)___nl__17).getHashValue()["dest"].clone();
//line 480
___nl__19 = ___nl__14.clone();
//line 480
(___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__20).getDoubleValue()] = ___nl__19;
//line 480
___nl__19 = null;
//line 480
___nl__20 = null;
//line 480
if (true) {goto label_82;}
//line 480
label_82:
//line 480
___nl__18 = null;
//line 481
___nl__18 = ((ImmHash)___nl__17).getHashValue()["dest"].clone();
//line 481
array_NL.NL_push(ref ___nl__13,___nl__18);

//line 481
___nl__18 = null;
//line 481
___nl__17 = null;
//line 482
if (true) {goto label_17;}
//line 482
label_27:
//line 482
___nl__17 = c_rt_lib_NL.NL_ov_as(___nl__15, new ImmString("load_const")).clone();
//line 483
___nl__18 = ((ImmHash)___nl__17).getHashValue()["dest"].clone();
//line 483
___nl__19 = new ImmString("").clone();
//line 483
___nl__18 = c_rt_lib_NL.NL_native_to_nl(___nl__18.toString().Equals(___nl__19.toString())).clone();
//line 483
___nl__19 = null;
//line 483
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 483
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 483
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_84;}}
//line 483
___nl__20 = ((ImmHash)___nl__17).getHashValue()["dest"].clone();
//line 483
___nl__19 = ___nl__14.clone();
//line 483
(___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__20).getDoubleValue()] = ___nl__19;
//line 483
___nl__19 = null;
//line 483
___nl__20 = null;
//line 483
if (true) {goto label_84;}
//line 483
label_84:
//line 483
___nl__18 = null;
//line 484
___nl__18 = ((ImmHash)___nl__17).getHashValue()["dest"].clone();
//line 484
array_NL.NL_push(ref ___nl__13,___nl__18);

//line 484
___nl__18 = null;
//line 484
___nl__17 = null;
//line 485
if (true) {goto label_17;}
//line 485
label_28:
//line 485
___nl__17 = c_rt_lib_NL.NL_ov_as(___nl__15, new ImmString("get_frm_idx")).clone();
//line 486
___nl__19 = ((ImmHash)___nl__17).getHashValue()["src"].clone();
//line 486
___nl__18 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__19).getDoubleValue()].clone();
//line 486
___nl__19 = null;
//line 486
post_processing_NL.NL_check_sub_priv(ref ___nl__14,___nl__18,ref ___nl__12);

//line 486
___nl__18 = null;
//line 487
___nl__19 = ((ImmHash)___nl__17).getHashValue()["idx"].clone();
//line 487
___nl__18 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__19).getDoubleValue()].clone();
//line 487
___nl__19 = null;
//line 487
post_processing_NL.NL_check_sub_priv(ref ___nl__14,___nl__18,ref ___nl__12);

//line 487
___nl__18 = null;
//line 488
___nl__18 = ((ImmHash)___nl__17).getHashValue()["dest"].clone();
//line 488
___nl__19 = new ImmString("").clone();
//line 488
___nl__18 = c_rt_lib_NL.NL_native_to_nl(___nl__18.toString().Equals(___nl__19.toString())).clone();
//line 488
___nl__19 = null;
//line 488
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 488
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 488
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_86;}}
//line 488
___nl__20 = ((ImmHash)___nl__17).getHashValue()["dest"].clone();
//line 488
___nl__19 = ___nl__14.clone();
//line 488
(___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__20).getDoubleValue()] = ___nl__19;
//line 488
___nl__19 = null;
//line 488
___nl__20 = null;
//line 488
if (true) {goto label_86;}
//line 488
label_86:
//line 488
___nl__18 = null;
//line 489
___nl__18 = ((ImmHash)___nl__17).getHashValue()["dest"].clone();
//line 489
array_NL.NL_push(ref ___nl__13,___nl__18);

//line 489
___nl__18 = null;
//line 489
___nl__17 = null;
//line 490
if (true) {goto label_17;}
//line 490
label_29:
//line 490
___nl__17 = c_rt_lib_NL.NL_ov_as(___nl__15, new ImmString("set_at_idx")).clone();
//line 491
___nl__19 = ((ImmHash)___nl__17).getHashValue()["src"].clone();
//line 491
___nl__18 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__19).getDoubleValue()].clone();
//line 491
___nl__19 = null;
//line 491
post_processing_NL.NL_check_sub_priv(ref ___nl__14,___nl__18,ref ___nl__12);

//line 491
___nl__18 = null;
//line 492
___nl__19 = ((ImmHash)___nl__17).getHashValue()["idx"].clone();
//line 492
___nl__18 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__19).getDoubleValue()].clone();
//line 492
___nl__19 = null;
//line 492
post_processing_NL.NL_check_sub_priv(ref ___nl__14,___nl__18,ref ___nl__12);

//line 492
___nl__18 = null;
//line 493
___nl__19 = ((ImmHash)___nl__17).getHashValue()["val"].clone();
//line 493
___nl__18 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__19).getDoubleValue()].clone();
//line 493
___nl__19 = null;
//line 493
post_processing_NL.NL_check_sub_priv(ref ___nl__14,___nl__18,ref ___nl__12);

//line 493
___nl__18 = null;
//line 494
___nl__19 = ((ImmHash)___nl__17).getHashValue()["src"].clone();
//line 494
___nl__18 = ___nl__14.clone();
//line 494
(___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__19).getDoubleValue()] = ___nl__18;
//line 494
___nl__18 = null;
//line 494
___nl__19 = null;
//line 495
___nl__18 = ((ImmHash)___nl__17).getHashValue()["src"].clone();
//line 495
array_NL.NL_push(ref ___nl__13,___nl__18);

//line 495
___nl__18 = null;
//line 495
___nl__17 = null;
//line 496
if (true) {goto label_17;}
//line 496
label_30:
//line 496
___nl__17 = c_rt_lib_NL.NL_ov_as(___nl__15, new ImmString("get_val")).clone();
//line 497
___nl__19 = ((ImmHash)___nl__17).getHashValue()["src"].clone();
//line 497
___nl__18 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__19).getDoubleValue()].clone();
//line 497
___nl__19 = null;
//line 497
post_processing_NL.NL_check_sub_priv(ref ___nl__14,___nl__18,ref ___nl__12);

//line 497
___nl__18 = null;
//line 498
___nl__18 = ((ImmHash)___nl__17).getHashValue()["dest"].clone();
//line 498
___nl__19 = new ImmString("").clone();
//line 498
___nl__18 = c_rt_lib_NL.NL_native_to_nl(___nl__18.toString().Equals(___nl__19.toString())).clone();
//line 498
___nl__19 = null;
//line 498
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 498
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 498
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_88;}}
//line 498
___nl__20 = ((ImmHash)___nl__17).getHashValue()["dest"].clone();
//line 498
___nl__19 = ___nl__14.clone();
//line 498
(___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__20).getDoubleValue()] = ___nl__19;
//line 498
___nl__19 = null;
//line 498
___nl__20 = null;
//line 498
if (true) {goto label_88;}
//line 498
label_88:
//line 498
___nl__18 = null;
//line 499
___nl__18 = ((ImmHash)___nl__17).getHashValue()["dest"].clone();
//line 499
array_NL.NL_push(ref ___nl__13,___nl__18);

//line 499
___nl__18 = null;
//line 499
___nl__17 = null;
//line 500
if (true) {goto label_17;}
//line 500
label_31:
//line 500
___nl__17 = c_rt_lib_NL.NL_ov_as(___nl__15, new ImmString("set_val")).clone();
//line 501
___nl__19 = ((ImmHash)___nl__17).getHashValue()["src"].clone();
//line 501
___nl__18 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__19).getDoubleValue()].clone();
//line 501
___nl__19 = null;
//line 501
post_processing_NL.NL_check_sub_priv(ref ___nl__14,___nl__18,ref ___nl__12);

//line 501
___nl__18 = null;
//line 502
___nl__19 = ((ImmHash)___nl__17).getHashValue()["val"].clone();
//line 502
___nl__18 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__19).getDoubleValue()].clone();
//line 502
___nl__19 = null;
//line 502
post_processing_NL.NL_check_sub_priv(ref ___nl__14,___nl__18,ref ___nl__12);

//line 502
___nl__18 = null;
//line 503
___nl__19 = ((ImmHash)___nl__17).getHashValue()["src"].clone();
//line 503
___nl__18 = ___nl__14.clone();
//line 503
(___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__19).getDoubleValue()] = ___nl__18;
//line 503
___nl__18 = null;
//line 503
___nl__19 = null;
//line 504
___nl__18 = ((ImmHash)___nl__17).getHashValue()["src"].clone();
//line 504
array_NL.NL_push(ref ___nl__13,___nl__18);

//line 504
___nl__18 = null;
//line 504
___nl__17 = null;
//line 505
if (true) {goto label_17;}
//line 505
label_32:
//line 505
___nl__17 = c_rt_lib_NL.NL_ov_as(___nl__15, new ImmString("ov_mk")).clone();
//line 506
___nl__18 = ((ImmHash)___nl__17).getHashValue()["src"].clone();
//line 506
___nl__18 = c_rt_lib_NL.NL_ov_is(___nl__18, new ImmString("arg")).clone();
//line 506
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 506
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_90;}}
//line 507
___nl__20 = ((ImmHash)___nl__17).getHashValue()["src"].clone();
//line 507
___nl__20 = c_rt_lib_NL.NL_ov_as(___nl__20, new ImmString("arg")).clone();
//line 507
___nl__19 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__20).getDoubleValue()].clone();
//line 507
___nl__20 = null;
//line 507
post_processing_NL.NL_check_sub_priv(ref ___nl__14,___nl__19,ref ___nl__12);

//line 507
___nl__19 = null;
//line 508
if (true) {goto label_90;}
//line 508
label_90:
//line 508
___nl__18 = null;
//line 509
___nl__18 = ((ImmHash)___nl__17).getHashValue()["dest"].clone();
//line 509
___nl__19 = new ImmString("").clone();
//line 509
___nl__18 = c_rt_lib_NL.NL_native_to_nl(___nl__18.toString().Equals(___nl__19.toString())).clone();
//line 509
___nl__19 = null;
//line 509
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 509
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 509
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_92;}}
//line 509
___nl__20 = ((ImmHash)___nl__17).getHashValue()["dest"].clone();
//line 509
___nl__19 = ___nl__14.clone();
//line 509
(___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__20).getDoubleValue()] = ___nl__19;
//line 509
___nl__19 = null;
//line 509
___nl__20 = null;
//line 509
if (true) {goto label_92;}
//line 509
label_92:
//line 509
___nl__18 = null;
//line 510
___nl__18 = ((ImmHash)___nl__17).getHashValue()["dest"].clone();
//line 510
array_NL.NL_push(ref ___nl__13,___nl__18);

//line 510
___nl__18 = null;
//line 510
___nl__17 = null;
//line 511
if (true) {goto label_17;}
//line 511
label_33:
//line 511
___nl__17 = c_rt_lib_NL.NL_ov_as(___nl__15, new ImmString("return")).clone();
//line 512
___nl__18 = ___nl__17.clone();
//line 512
___nl__18 = c_rt_lib_NL.NL_ov_is(___nl__18, new ImmString("val")).clone();
//line 512
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 512
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_94;}}
//line 513
___nl__20 = ___nl__17.clone();
//line 513
___nl__20 = c_rt_lib_NL.NL_ov_as(___nl__20, new ImmString("val")).clone();
//line 513
___nl__19 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__20).getDoubleValue()].clone();
//line 513
___nl__20 = null;
//line 513
post_processing_NL.NL_check_sub_priv(ref ___nl__14,___nl__19,ref ___nl__12);

//line 513
___nl__19 = null;
//line 514
if (true) {goto label_94;}
//line 514
label_94:
//line 514
___nl__18 = null;
//line 514
___nl__17 = null;
//line 515
if (true) {goto label_17;}
//line 515
label_34:
//line 515
___nl__17 = c_rt_lib_NL.NL_ov_as(___nl__15, new ImmString("die")).clone();
//line 516
___nl__18 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__17).getDoubleValue()].clone();
//line 516
post_processing_NL.NL_check_sub_priv(ref ___nl__14,___nl__18,ref ___nl__12);

//line 516
___nl__18 = null;
//line 516
___nl__17 = null;
//line 517
if (true) {goto label_17;}
//line 517
label_35:
//line 517
___nl__17 = c_rt_lib_NL.NL_ov_as(___nl__15, new ImmString("prt_lbl")).clone();
//line 518
___nl__18 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("no")).clone();
//line 518
___nl__14 = ___nl__18.clone();
//line 518
___nl__18 = null;
//line 518
___nl__17 = null;
//line 519
if (true) {goto label_17;}
//line 519
label_36:
//line 519
___nl__17 = c_rt_lib_NL.NL_ov_as(___nl__15, new ImmString("if_goto")).clone();
//line 520
___nl__19 = ((ImmHash)___nl__17).getHashValue()["src"].clone();
//line 520
___nl__18 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__19).getDoubleValue()].clone();
//line 520
___nl__19 = null;
//line 520
post_processing_NL.NL_check_sub_priv(ref ___nl__14,___nl__18,ref ___nl__12);

//line 520
___nl__18 = null;
//line 520
___nl__17 = null;
//line 521
if (true) {goto label_17;}
//line 521
label_37:
//line 521
___nl__17 = c_rt_lib_NL.NL_ov_as(___nl__15, new ImmString("goto")).clone();
//line 522
___nl__18 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("no")).clone();
//line 522
___nl__14 = ___nl__18.clone();
//line 522
___nl__18 = null;
//line 522
___nl__17 = null;
//line 523
if (true) {goto label_17;}
//line 523
label_38:
//line 523
___nl__17 = c_rt_lib_NL.NL_ov_as(___nl__15, new ImmString("clear")).clone();
//line 524
___nl__18 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__17).getDoubleValue()].clone();
//line 524
post_processing_NL.NL_check_sub_priv(ref ___nl__14,___nl__18,ref ___nl__12);

//line 524
___nl__18 = null;
//line 525
___nl__18 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("no")).clone();
//line 525
___nl__19 = ___nl__18.clone();
//line 525
(___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__17).getDoubleValue()] = ___nl__19;
//line 525
___nl__18 = null;
//line 525
___nl__19 = null;
//line 525
___nl__17 = null;
//line 526
if (true) {goto label_17;}
//line 526
label_17:
//line 526
___nl__15 = null;
//line 526
___nl__16 = null;
//line 527
___nl__15 = array_NL.NL_len(___nl__13).clone();

//line 528
___nl__16 = new ImmDouble(0).clone();
//line 528
___nl__16 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__15.getValue().ToString()))>(Double.Parse(___nl__16.getValue().ToString())) ).clone();
//line 528
___nl__17 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__16)).clone();
//line 528
if (c_rt_lib_NL.NL_check_true_native(___nl__17)) {if (true) {goto label_97;}}
//line 528
___nl__18 = new ImmDouble(1).clone();
//line 528
___nl__18 = new ImmDouble((Double.Parse(___nl__15.getValue().ToString()))-(Double.Parse(___nl__18.getValue().ToString()))).clone();
//line 528
___nl__16 = (___nl__13 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__18).getDoubleValue()].clone();
//line 528
___nl__18 = null;
//line 528
___nl__18 = new ImmString("").clone();
//line 528
___nl__16 = c_rt_lib_NL.NL_native_to_nl(___nl__16.toString().Equals(___nl__18.toString())).clone();
//line 528
___nl__18 = null;
//line 528
label_97:
//line 528
___nl__17 = null;
//line 528
___nl__16 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__16)).clone();
//line 528
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_96;}}
//line 529
array_NL.NL_pop(ref ___nl__13);

//line 530
if (true) {goto label_96;}
//line 530
label_96:
//line 530
___nl__16 = null;
//line 531
___nl__16 = ___nl__14.clone();
//line 531
___nl__16 = c_rt_lib_NL.NL_ov_is(___nl__16, new ImmString("yes")).clone();
//line 531
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_99;}}
//line 531
___nl__16 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 531
if (true) {goto label_98;}
//line 531
label_99:
//line 531
___nl__16 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("const"), ___nl__13).clone();
//line 531
label_98:
//line 531
___nl__17 = c_rt_lib_NL.NL_get_ref_arr(___nl__7,___nl__9).clone();

//line 531
___nl__18 = ___nl__16.clone();
//line 531
((ImmHash)___nl__17).set("annotation", ___nl__18);
//line 531
c_rt_lib_NL.NL_set_ref_arr(ref ___nl__7,___nl__9,___nl__17);

//line 531
___nl__16 = null;
//line 531
___nl__17 = null;
//line 531
___nl__18 = null;
//line 531
___nl__12 = null;
//line 531
___nl__13 = null;
//line 531
___nl__14 = null;
//line 531
___nl__15 = null;
//line 532
___nl__9 = new ImmDouble((Double.Parse(___nl__9.getValue().ToString()))+(Double.Parse(___nl__10.getValue().ToString()))).clone();
//line 532
if (true) {goto label_16;}
//line 532
label_14:
//line 532
___nl__8 = null;
//line 532
___nl__9 = null;
//line 532
___nl__10 = null;
//line 532
___nl__11 = null;
//line 533
___nl__8 = ___nl__7.clone();
//line 533
((ImmHash)___nl__6).set("cmds", ___nl__8);
//line 533
___nl__8 = null;
//line 534
___nl__8 = ___nl__6.clone();
//line 534
(___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__0).getDoubleValue()] = ___nl__8;
//line 534
___nl__8 = null;
//line 535
___nl__8 = ((ImmHash)___nl__6).getHashValue()["next"].clone();
//line 535
___nl__10 = new ImmDouble(0).clone();
//line 535
___nl__11 = new ImmDouble(1).clone();
//line 535
___nl__12 = c_rt_lib_NL.NL_array_len(___nl__8).clone();

//line 535
label_102:
//line 535
___nl__13 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__10.getValue().ToString()))>=(Double.Parse(___nl__12.getValue().ToString())) ).clone();
//line 535
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_100;}}
//line 535
___nl__9 = (___nl__8 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()].clone();
//line 536
post_processing_NL.NL_set_const_block_priv(___nl__9,ref ___nl__1,___nl__2,ref ___nl__3,___nl__4,___nl__5);

//line 537
___nl__10 = new ImmDouble((Double.Parse(___nl__10.getValue().ToString()))+(Double.Parse(___nl__11.getValue().ToString()))).clone();
//line 537
if (true) {goto label_102;}
//line 537
label_100:
//line 537
___nl__8 = null;
//line 537
___nl__9 = null;
//line 537
___nl__10 = null;
//line 537
___nl__11 = null;
//line 537
___nl__12 = null;
//line 537
___nl__13 = null;
//line 537
___nl__6 = null;
//line 537
___nl__7 = null;
//line 537
___nl__0 = null;
//line 537
___nl__2 = null;
//line 537
___nl__4 = null;
//line 537
___nl__5 = null;
//line 537
___arg__1 = ___nl__1;___arg__3 = ___nl__3;if(true) return null;
}

private static Imm NL_evaluate_const_priv(Imm ___arg__0, Imm ___arg__1, Imm ___arg__2, ref Imm ___arg__3, ref Imm ___arg__4, Imm ___arg__5, Imm ___arg__6) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);Imm ___nl__2 = null;c_rt_lib_NL.NL_copy(ref ___nl__2, ___arg__2);Imm ___nl__3 = ___arg__3;Imm ___nl__4 = ___arg__4;Imm ___nl__5 = null;c_rt_lib_NL.NL_copy(ref ___nl__5, ___arg__5);Imm ___nl__6 = null;c_rt_lib_NL.NL_copy(ref ___nl__6, ___arg__6);
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
Dictionary<String, Imm> __function_map;
//line 542
___nl__7 = ___nl__3.clone();
//line 542
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("no")).clone();
//line 542
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 542
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_2;}}
//line 543
___nl__9 = new ImmDouble(0).clone();
//line 543
___nl__10 = new ImmDouble(1).clone();
//line 543
___nl__11 = c_rt_lib_NL.NL_array_len(___nl__6).clone();

//line 543
label_5:
//line 543
___nl__12 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__9.getValue().ToString()))>=(Double.Parse(___nl__11.getValue().ToString())) ).clone();
//line 543
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_3;}}
//line 543
___nl__8 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()].clone();
//line 544
___nl__13 = new ImmString("").clone();
//line 544
___nl__13 = c_rt_lib_NL.NL_native_to_nl(___nl__8.toString().Equals(___nl__13.toString())).clone();
//line 544
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13)).clone();
//line 544
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13)).clone();
//line 544
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_7;}}
//line 544
___nl__14 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("no")).clone();
//line 544
___nl__15 = ___nl__14.clone();
//line 544
(___nl__4 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()] = ___nl__15;
//line 544
___nl__14 = null;
//line 544
___nl__15 = null;
//line 544
if (true) {goto label_7;}
//line 544
label_7:
//line 544
___nl__13 = null;
//line 545
___nl__9 = new ImmDouble((Double.Parse(___nl__9.getValue().ToString()))+(Double.Parse(___nl__10.getValue().ToString()))).clone();
//line 545
if (true) {goto label_5;}
//line 545
label_3:
//line 545
___nl__8 = null;
//line 545
___nl__9 = null;
//line 545
___nl__10 = null;
//line 545
___nl__11 = null;
//line 545
___nl__12 = null;
//line 546
___nl__0 = null;
//line 546
___nl__1 = null;
//line 546
___nl__2 = null;
//line 546
___nl__5 = null;
//line 546
___nl__6 = null;
//line 546
___nl__7 = null;
//line 546
___arg__3 = ___nl__3;___arg__4 = ___nl__4;if(true) return null;
//line 547
if (true) {goto label_2;}
//line 547
label_2:
//line 547
___nl__7 = null;
//line 548
___nl__7 = ___nl__3.clone();
//line 548
___nl__7 = c_rt_lib_NL.NL_ov_as(___nl__7, new ImmString("yes")).clone();
//line 549
___nl__8 = new ImmArray(new Imm[0]).clone();
//line 550
___nl__10 = new ImmDouble(0).clone();
//line 550
___nl__11 = new ImmDouble(1).clone();
//line 550
___nl__12 = c_rt_lib_NL.NL_array_len(___nl__4).clone();

//line 550
label_10:
//line 550
___nl__13 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__10.getValue().ToString()))>=(Double.Parse(___nl__12.getValue().ToString())) ).clone();
//line 550
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_8;}}
//line 550
___nl__9 = (___nl__4 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()].clone();
//line 551
___nl__14 = interpreter_NL.NL_get_none_variant().clone();

//line 552
___nl__15 = ___nl__9.clone();
//line 552
___nl__15 = c_rt_lib_NL.NL_ov_is(___nl__15, new ImmString("yes")).clone();
//line 552
___nl__15 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__15)).clone();
//line 552
if (c_rt_lib_NL.NL_check_true_native(___nl__15)) {if (true) {goto label_12;}}
//line 553
___nl__16 = ___nl__9.clone();
//line 553
___nl__16 = c_rt_lib_NL.NL_ov_as(___nl__16, new ImmString("yes")).clone();
//line 554
___nl__17 = ((ImmHash)___nl__16).getHashValue()["value"].clone();
//line 554
___nl__14 = ___nl__17.clone();
//line 554
___nl__17 = null;
//line 554
___nl__16 = null;
//line 555
if (true) {goto label_12;}
//line 555
label_12:
//line 555
___nl__15 = null;
//line 556
array_NL.NL_push(ref ___nl__8,___nl__14);

//line 556
___nl__14 = null;
//line 557
___nl__10 = new ImmDouble((Double.Parse(___nl__10.getValue().ToString()))+(Double.Parse(___nl__11.getValue().ToString()))).clone();
//line 557
if (true) {goto label_10;}
//line 557
label_8:
//line 557
___nl__9 = null;
//line 557
___nl__10 = null;
//line 557
___nl__11 = null;
//line 557
___nl__12 = null;
//line 557
___nl__13 = null;
//line 558
___nl__9 = interpreter_NL.NL_evaluate_const(___nl__5,___nl__0,___nl__1,___nl__8,___nl__2).clone();

//line 559
___nl__10 = ___nl__9.clone();
//line 559
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__10, new ImmString("err")).clone();
//line 559
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 559
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_14;}}
//line 560
___nl__11 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("no")).clone();
//line 560
___nl__3 = ___nl__11.clone();
//line 560
___nl__11 = null;
//line 561
___nl__12 = new ImmDouble(0).clone();
//line 561
___nl__13 = new ImmDouble(1).clone();
//line 561
___nl__14 = c_rt_lib_NL.NL_array_len(___nl__6).clone();

//line 561
label_17:
//line 561
___nl__15 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__12.getValue().ToString()))>=(Double.Parse(___nl__14.getValue().ToString())) ).clone();
//line 561
if (c_rt_lib_NL.NL_check_true_native(___nl__15)) {if (true) {goto label_15;}}
//line 561
___nl__11 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__12).getDoubleValue()].clone();
//line 562
___nl__16 = new ImmString("").clone();
//line 562
___nl__16 = c_rt_lib_NL.NL_native_to_nl(___nl__11.toString().Equals(___nl__16.toString())).clone();
//line 562
___nl__16 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__16)).clone();
//line 562
___nl__16 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__16)).clone();
//line 562
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_19;}}
//line 562
___nl__17 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("no")).clone();
//line 562
___nl__18 = ___nl__17.clone();
//line 562
(___nl__4 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__11).getDoubleValue()] = ___nl__18;
//line 562
___nl__17 = null;
//line 562
___nl__18 = null;
//line 562
if (true) {goto label_19;}
//line 562
label_19:
//line 562
___nl__16 = null;
//line 563
___nl__12 = new ImmDouble((Double.Parse(___nl__12.getValue().ToString()))+(Double.Parse(___nl__13.getValue().ToString()))).clone();
//line 563
if (true) {goto label_17;}
//line 563
label_15:
//line 563
___nl__11 = null;
//line 563
___nl__12 = null;
//line 563
___nl__13 = null;
//line 563
___nl__14 = null;
//line 563
___nl__15 = null;
//line 564
if (true) {goto label_13;}
//line 564
label_14:
//line 565
___nl__11 = ___nl__9.clone();
//line 565
___nl__11 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("ok")).clone();
//line 566
___nl__12 = array_NL.NL_len(___nl__6).clone();

//line 566
___nl__13 = new ImmDouble(0).clone();
//line 566
___nl__14 = new ImmDouble(1).clone();
//line 566
label_22:
//line 566
___nl__15 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__13.getValue().ToString()))>=(Double.Parse(___nl__12.getValue().ToString())) ).clone();
//line 566
if (c_rt_lib_NL.NL_check_true_native(___nl__15)) {if (true) {goto label_20;}}
//line 567
___nl__16 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__13).getDoubleValue()].clone();
//line 568
___nl__17 = new ImmString("").clone();
//line 568
___nl__17 = c_rt_lib_NL.NL_native_to_nl(___nl__16.toString().Equals(___nl__17.toString())).clone();
//line 568
___nl__17 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__17)).clone();
//line 568
___nl__17 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__17)).clone();
//line 568
if (c_rt_lib_NL.NL_check_true_native(___nl__17)) {if (true) {goto label_24;}}
//line 568
___nl__19 = new ImmDouble(10000).clone();
//line 568
___nl__20 = ((ImmHash)___nl__7).getHashValue()["nr"].clone();
//line 568
___nl__19 = new ImmDouble((Double.Parse(___nl__19.getValue().ToString()))*(Double.Parse(___nl__20.getValue().ToString()))).clone();
//line 568
___nl__20 = null;
//line 568
___nl__19 = new ImmDouble((Double.Parse(___nl__19.getValue().ToString()))+(Double.Parse(___nl__13.getValue().ToString()))).clone();
//line 568
___nl__20 = (___nl__11 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__16).getDoubleValue()].clone();
//line 568
__function_map = new Dictionary<String, Imm>();
__function_map.Add("nr",___nl__19);
__function_map.Add("value",___nl__20);
___nl__18 = new ImmHash(__function_map).clone();
//line 568
___nl__19 = null;
//line 568
___nl__20 = null;
//line 568
___nl__18 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("yes"), ___nl__18).clone();
//line 568
___nl__19 = ___nl__18.clone();
//line 568
(___nl__4 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__16).getDoubleValue()] = ___nl__19;
//line 568
___nl__18 = null;
//line 568
___nl__19 = null;
//line 568
if (true) {goto label_24;}
//line 568
label_24:
//line 568
___nl__17 = null;
//line 568
___nl__16 = null;
//line 569
___nl__13 = new ImmDouble((Double.Parse(___nl__13.getValue().ToString()))+(Double.Parse(___nl__14.getValue().ToString()))).clone();
//line 569
if (true) {goto label_22;}
//line 569
label_20:
//line 569
___nl__12 = null;
//line 569
___nl__13 = null;
//line 569
___nl__14 = null;
//line 569
___nl__15 = null;
//line 569
___nl__11 = null;
//line 570
if (true) {goto label_13;}
//line 570
label_13:
//line 570
___nl__10 = null;
//line 570
___nl__7 = null;
//line 570
___nl__8 = null;
//line 570
___nl__9 = null;
//line 570
___nl__0 = null;
//line 570
___nl__1 = null;
//line 570
___nl__2 = null;
//line 570
___nl__5 = null;
//line 570
___nl__6 = null;
//line 570
___arg__3 = ___nl__3;___arg__4 = ___nl__4;if(true) return null;
}

private static Imm NL_push_load_const_priv(ref Imm ___arg__0, Imm ___arg__1, Imm ___arg__2, Imm ___arg__3) {
Imm ___nl__0 = ___arg__0;Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);Imm ___nl__2 = null;c_rt_lib_NL.NL_copy(ref ___nl__2, ___arg__2);Imm ___nl__3 = null;c_rt_lib_NL.NL_copy(ref ___nl__3, ___arg__3);
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
Imm ___nl__9 = null;
Dictionary<String, Imm> __function_map;
//line 573
___nl__4 = ___nl__1.clone();
//line 573
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("yes")).clone();
//line 573
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 573
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 573
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 573
___nl__5 = new ImmArray(new Imm[0]).clone();
//line 573
c_rt_lib_NL.NL_die();
//line 573
if (true) {goto label_2;}
//line 573
label_2:
//line 573
___nl__4 = null;
//line 573
___nl__5 = null;
//line 574
___nl__4 = ___nl__1.clone();
//line 574
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("yes")).clone();
//line 575
___nl__6 = ((ImmHash)___nl__3).getHashValue()["debug"].clone();
//line 575
___nl__7 = new ImmArray(new Imm[] {___nl__2,}).clone();
//line 575
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("const"), ___nl__7).clone();
//line 575
___nl__9 = ((ImmHash)___nl__4).getHashValue()["value"].clone();
//line 575
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__2);
__function_map.Add("val",___nl__9);
___nl__8 = new ImmHash(__function_map).clone();
//line 575
___nl__9 = null;
//line 575
___nl__8 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("load_const"), ___nl__8).clone();
//line 575
__function_map = new Dictionary<String, Imm>();
__function_map.Add("debug",___nl__6);
__function_map.Add("annotation",___nl__7);
__function_map.Add("cmd",___nl__8);
___nl__5 = new ImmHash(__function_map).clone();
//line 575
___nl__6 = null;
//line 575
___nl__7 = null;
//line 575
___nl__8 = null;
//line 575
array_NL.NL_push(ref ___nl__0,___nl__5);

//line 575
___nl__5 = null;
//line 575
___nl__4 = null;
//line 575
___nl__1 = null;
//line 575
___nl__2 = null;
//line 575
___nl__3 = null;
//line 575
___arg__0 = ___nl__0;if(true) return null;
}

private static Imm NL_set_const_block_val_priv(Imm ___arg__0, Imm ___arg__1, ref Imm ___arg__2, Imm ___arg__3, ref Imm ___arg__4, Imm ___arg__5, Imm ___arg__6, Imm ___arg__7, Imm ___arg__8) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);Imm ___nl__2 = ___arg__2;Imm ___nl__3 = null;c_rt_lib_NL.NL_copy(ref ___nl__3, ___arg__3);Imm ___nl__4 = ___arg__4;Imm ___nl__5 = null;c_rt_lib_NL.NL_copy(ref ___nl__5, ___arg__5);Imm ___nl__6 = null;c_rt_lib_NL.NL_copy(ref ___nl__6, ___arg__6);Imm ___nl__7 = null;c_rt_lib_NL.NL_copy(ref ___nl__7, ___arg__7);Imm ___nl__8 = null;c_rt_lib_NL.NL_copy(ref ___nl__8, ___arg__8);
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
Imm ___nl__27 = null;
Imm ___nl__28 = null;
Imm ___nl__29 = null;
Imm ___nl__30 = null;
Imm ___nl__31 = null;
Dictionary<String, Imm> __function_map;
//line 587
___nl__9 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__0).getDoubleValue()].clone();
//line 588
___nl__10 = (___nl__4 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__0).getDoubleValue()].clone();
//line 588
___nl__10 = ((ImmHash)___nl__10).getHashValue()["was"].clone();
//line 588
___nl__11 = new ImmDouble(0).clone();
//line 588
___nl__10 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__10.getValue().ToString()))>(Double.Parse(___nl__11.getValue().ToString())) ).clone();
//line 588
___nl__11 = null;
//line 588
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 588
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_2;}}
//line 589
___nl__11 = c_rt_lib_NL.NL_get_false().clone();
//line 590
___nl__12 = (___nl__4 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__0).getDoubleValue()].clone();
//line 590
___nl__12 = ((ImmHash)___nl__12).getHashValue()["regs"].clone();
//line 591
___nl__13 = array_NL.NL_len(___nl__6).clone();

//line 591
___nl__14 = new ImmDouble(0).clone();
//line 591
___nl__15 = new ImmDouble(1).clone();
//line 591
label_5:
//line 591
___nl__16 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__14.getValue().ToString()))>=(Double.Parse(___nl__13.getValue().ToString())) ).clone();
//line 591
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_3;}}
//line 592
___nl__17 = (___nl__12 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__14).getDoubleValue()].clone();
//line 592
___nl__17 = c_rt_lib_NL.NL_ov_is(___nl__17, new ImmString("no")).clone();
//line 592
___nl__17 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__17)).clone();
//line 592
if (c_rt_lib_NL.NL_check_true_native(___nl__17)) {if (true) {goto label_7;}}
//line 593
___nl__18 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("no")).clone();
//line 593
___nl__19 = ___nl__18.clone();
//line 593
(___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__14).getDoubleValue()] = ___nl__19;
//line 593
___nl__18 = null;
//line 593
___nl__19 = null;
//line 594
___nl__17 = null;
//line 594
if (true) {goto label_4;}
//line 595
if (true) {goto label_6;}
//line 595
label_7:
//line 596
___nl__18 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__14).getDoubleValue()].clone();
//line 596
___nl__18 = c_rt_lib_NL.NL_ov_is(___nl__18, new ImmString("yes")).clone();
//line 596
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 596
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_9;}}
//line 597
___nl__19 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__14).getDoubleValue()].clone();
//line 597
___nl__19 = c_rt_lib_NL.NL_ov_as(___nl__19, new ImmString("yes")).clone();
//line 598
___nl__20 = (___nl__12 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__14).getDoubleValue()].clone();
//line 598
___nl__20 = c_rt_lib_NL.NL_ov_as(___nl__20, new ImmString("yes")).clone();
//line 599
___nl__21 = ((ImmHash)___nl__19).getHashValue()["nr"].clone();
//line 599
___nl__22 = ((ImmHash)___nl__20).getHashValue()["nr"].clone();
//line 599
___nl__21 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__21.getValue().ToString())) ==((Double.Parse(___nl__22.getValue().ToString())))  ).clone();
//line 599
___nl__22 = null;
//line 599
___nl__21 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__21)).clone();
//line 599
if (c_rt_lib_NL.NL_check_true_native(___nl__21)) {if (true) {goto label_11;}}
//line 599
___nl__17 = null;
//line 599
___nl__18 = null;
//line 599
___nl__19 = null;
//line 599
___nl__20 = null;
//line 599
___nl__21 = null;
//line 599
if (true) {goto label_4;}
//line 599
if (true) {goto label_11;}
//line 599
label_11:
//line 599
___nl__21 = null;
//line 599
___nl__19 = null;
//line 599
___nl__20 = null;
//line 600
if (true) {goto label_9;}
//line 600
label_9:
//line 600
___nl__18 = null;
//line 601
___nl__18 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("no")).clone();
//line 601
___nl__19 = ___nl__18.clone();
//line 601
(___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__14).getDoubleValue()] = ___nl__19;
//line 601
___nl__18 = null;
//line 601
___nl__19 = null;
//line 602
___nl__18 = c_rt_lib_NL.NL_get_true().clone();
//line 602
___nl__11 = ___nl__18.clone();
//line 602
___nl__18 = null;
//line 603
if (true) {goto label_6;}
//line 603
label_6:
//line 603
___nl__17 = null;
//line 603
label_4:
//line 604
___nl__14 = new ImmDouble((Double.Parse(___nl__14.getValue().ToString()))+(Double.Parse(___nl__15.getValue().ToString()))).clone();
//line 604
if (true) {goto label_5;}
//line 604
label_3:
//line 604
___nl__13 = null;
//line 604
___nl__14 = null;
//line 604
___nl__15 = null;
//line 604
___nl__16 = null;
//line 605
___nl__13 = ___nl__11.clone();
//line 605
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13)).clone();
//line 605
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13)).clone();
//line 605
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_13;}}
//line 605
___nl__0 = null;
//line 605
___nl__1 = null;
//line 605
___nl__3 = null;
//line 605
___nl__5 = null;
//line 605
___nl__6 = null;
//line 605
___nl__7 = null;
//line 605
___nl__8 = null;
//line 605
___nl__9 = null;
//line 605
___nl__10 = null;
//line 605
___nl__11 = null;
//line 605
___nl__12 = null;
//line 605
___nl__13 = null;
//line 605
___arg__2 = ___nl__2;___arg__4 = ___nl__4;if(true) return null;
//line 605
if (true) {goto label_13;}
//line 605
label_13:
//line 605
___nl__13 = null;
//line 605
___nl__11 = null;
//line 605
___nl__12 = null;
//line 606
if (true) {goto label_2;}
//line 606
label_2:
//line 606
___nl__10 = null;
//line 607
___nl__10 = c_rt_lib_NL.NL_get_ref_arr(___nl__4,___nl__0).clone();

//line 607
___nl__11 = ___nl__6.clone();
//line 607
((ImmHash)___nl__10).set("regs", ___nl__11);
//line 607
c_rt_lib_NL.NL_set_ref_arr(ref ___nl__4,___nl__0,___nl__10);

//line 607
___nl__10 = null;
//line 607
___nl__11 = null;
//line 608
___nl__10 = new ImmArray(new Imm[0]).clone();
//line 609
___nl__11 = c_rt_lib_NL.NL_get_ref_arr(___nl__4,___nl__0).clone();

//line 609
___nl__12 = new ImmString("was").clone();
//line 609
___nl__12 = c_rt_lib_NL.NL_get_ref_hash(___nl__11,___nl__12).clone();

//line 609
___nl__13 = new ImmDouble(1).clone();
//line 609
___nl__12 = new ImmDouble((Double.Parse(___nl__12.getValue().ToString()))+(Double.Parse(___nl__13.getValue().ToString()))).clone();
//line 609
___nl__14 = new ImmString("was").clone();
//line 609
c_rt_lib_NL.NL_set_ref_hash(ref ___nl__11,___nl__14,___nl__12);

//line 609
c_rt_lib_NL.NL_set_ref_arr(ref ___nl__4,___nl__0,___nl__11);

//line 609
___nl__14 = null;
//line 609
___nl__11 = null;
//line 609
___nl__12 = null;
//line 609
___nl__13 = null;
//line 610
___nl__11 = ((ImmHash)___nl__9).getHashValue()["cmds"].clone();
//line 611
___nl__12 = array_NL.NL_len(___nl__11).clone();

//line 611
___nl__13 = new ImmDouble(0).clone();
//line 611
___nl__14 = new ImmDouble(1).clone();
//line 611
label_16:
//line 611
___nl__15 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__13.getValue().ToString()))>=(Double.Parse(___nl__12.getValue().ToString())) ).clone();
//line 611
if (c_rt_lib_NL.NL_check_true_native(___nl__15)) {if (true) {goto label_14;}}
//line 612
___nl__16 = ((ImmHash)___nl__9).getHashValue()["from"].clone();
//line 612
___nl__16 = new ImmDouble((Double.Parse(___nl__16.getValue().ToString()))+(Double.Parse(___nl__13.getValue().ToString()))).clone();
//line 613
___nl__18 = ((ImmHash)___nl__9).getHashValue()["from"].clone();
//line 613
___nl__18 = new ImmDouble((Double.Parse(___nl__13.getValue().ToString()))+(Double.Parse(___nl__18.getValue().ToString()))).clone();
//line 613
___nl__19 = new ImmString("").clone();
//line 613
__function_map = new Dictionary<String, Imm>();
__function_map.Add("nr",___nl__18);
__function_map.Add("value",___nl__19);
___nl__17 = new ImmHash(__function_map).clone();
//line 613
___nl__18 = null;
//line 613
___nl__19 = null;
//line 613
___nl__17 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("yes"), ___nl__17).clone();
//line 614
___nl__18 = (___nl__11 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__13).getDoubleValue()].clone();
//line 615
___nl__19 = new ImmArray(new Imm[0]).clone();
//line 616
___nl__20 = ((ImmHash)___nl__18).getHashValue()["cmd"].clone();
//line 616
___nl__21 = c_rt_lib_NL.NL_ov_is(___nl__20, new ImmString("arr_decl")).clone();
//line 616
if (c_rt_lib_NL.NL_check_true_native(___nl__21)) {if (true) {goto label_18;}}
//line 622
___nl__21 = c_rt_lib_NL.NL_ov_is(___nl__20, new ImmString("hash_decl")).clone();
//line 622
if (c_rt_lib_NL.NL_check_true_native(___nl__21)) {if (true) {goto label_19;}}
//line 628
___nl__21 = c_rt_lib_NL.NL_ov_is(___nl__20, new ImmString("call")).clone();
//line 628
if (c_rt_lib_NL.NL_check_true_native(___nl__21)) {if (true) {goto label_20;}}
//line 650
___nl__21 = c_rt_lib_NL.NL_ov_is(___nl__20, new ImmString("una_op")).clone();
//line 650
if (c_rt_lib_NL.NL_check_true_native(___nl__21)) {if (true) {goto label_21;}}
//line 654
___nl__21 = c_rt_lib_NL.NL_ov_is(___nl__20, new ImmString("bin_op")).clone();
//line 654
if (c_rt_lib_NL.NL_check_true_native(___nl__21)) {if (true) {goto label_22;}}
//line 659
___nl__21 = c_rt_lib_NL.NL_ov_is(___nl__20, new ImmString("ov_is")).clone();
//line 659
if (c_rt_lib_NL.NL_check_true_native(___nl__21)) {if (true) {goto label_23;}}
//line 663
___nl__21 = c_rt_lib_NL.NL_ov_is(___nl__20, new ImmString("ov_as")).clone();
//line 663
if (c_rt_lib_NL.NL_check_true_native(___nl__21)) {if (true) {goto label_24;}}
//line 667
___nl__21 = c_rt_lib_NL.NL_ov_is(___nl__20, new ImmString("func")).clone();
//line 667
if (c_rt_lib_NL.NL_check_true_native(___nl__21)) {if (true) {goto label_25;}}
//line 671
___nl__21 = c_rt_lib_NL.NL_ov_is(___nl__20, new ImmString("move")).clone();
//line 671
if (c_rt_lib_NL.NL_check_true_native(___nl__21)) {if (true) {goto label_26;}}
//line 675
___nl__21 = c_rt_lib_NL.NL_ov_is(___nl__20, new ImmString("load_const")).clone();
//line 675
if (c_rt_lib_NL.NL_check_true_native(___nl__21)) {if (true) {goto label_27;}}
//line 680
___nl__21 = c_rt_lib_NL.NL_ov_is(___nl__20, new ImmString("get_frm_idx")).clone();
//line 680
if (c_rt_lib_NL.NL_check_true_native(___nl__21)) {if (true) {goto label_28;}}
//line 685
___nl__21 = c_rt_lib_NL.NL_ov_is(___nl__20, new ImmString("set_at_idx")).clone();
//line 685
if (c_rt_lib_NL.NL_check_true_native(___nl__21)) {if (true) {goto label_29;}}
//line 691
___nl__21 = c_rt_lib_NL.NL_ov_is(___nl__20, new ImmString("get_val")).clone();
//line 691
if (c_rt_lib_NL.NL_check_true_native(___nl__21)) {if (true) {goto label_30;}}
//line 695
___nl__21 = c_rt_lib_NL.NL_ov_is(___nl__20, new ImmString("set_val")).clone();
//line 695
if (c_rt_lib_NL.NL_check_true_native(___nl__21)) {if (true) {goto label_31;}}
//line 700
___nl__21 = c_rt_lib_NL.NL_ov_is(___nl__20, new ImmString("ov_mk")).clone();
//line 700
if (c_rt_lib_NL.NL_check_true_native(___nl__21)) {if (true) {goto label_32;}}
//line 706
___nl__21 = c_rt_lib_NL.NL_ov_is(___nl__20, new ImmString("return")).clone();
//line 706
if (c_rt_lib_NL.NL_check_true_native(___nl__21)) {if (true) {goto label_33;}}
//line 711
___nl__21 = c_rt_lib_NL.NL_ov_is(___nl__20, new ImmString("die")).clone();
//line 711
if (c_rt_lib_NL.NL_check_true_native(___nl__21)) {if (true) {goto label_34;}}
//line 714
___nl__21 = c_rt_lib_NL.NL_ov_is(___nl__20, new ImmString("prt_lbl")).clone();
//line 714
if (c_rt_lib_NL.NL_check_true_native(___nl__21)) {if (true) {goto label_35;}}
//line 716
___nl__21 = c_rt_lib_NL.NL_ov_is(___nl__20, new ImmString("if_goto")).clone();
//line 716
if (c_rt_lib_NL.NL_check_true_native(___nl__21)) {if (true) {goto label_36;}}
//line 719
___nl__21 = c_rt_lib_NL.NL_ov_is(___nl__20, new ImmString("goto")).clone();
//line 719
if (c_rt_lib_NL.NL_check_true_native(___nl__21)) {if (true) {goto label_37;}}
//line 721
___nl__21 = c_rt_lib_NL.NL_ov_is(___nl__20, new ImmString("clear")).clone();
//line 721
if (c_rt_lib_NL.NL_check_true_native(___nl__21)) {if (true) {goto label_38;}}
//line 721
___nl__21 = new ImmString("NOMATCHALERT").clone();
//line 721
___nl__21 = new ImmArray(new Imm[] {___nl__21,___nl__20,}).clone();
//line 721
c_rt_lib_NL.NL_die();
//line 616
label_18:
//line 616
___nl__22 = c_rt_lib_NL.NL_ov_as(___nl__20, new ImmString("arr_decl")).clone();
//line 617
___nl__23 = ((ImmHash)___nl__22).getHashValue()["src"].clone();
//line 617
___nl__25 = new ImmDouble(0).clone();
//line 617
___nl__26 = new ImmDouble(1).clone();
//line 617
___nl__27 = c_rt_lib_NL.NL_array_len(___nl__23).clone();

//line 617
label_41:
//line 617
___nl__28 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__25.getValue().ToString()))>=(Double.Parse(___nl__27.getValue().ToString())) ).clone();
//line 617
if (c_rt_lib_NL.NL_check_true_native(___nl__28)) {if (true) {goto label_39;}}
//line 617
___nl__24 = (___nl__23 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__25).getDoubleValue()].clone();
//line 618
___nl__29 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__24).getDoubleValue()].clone();
//line 618
post_processing_NL.NL_check_sub_val_priv(ref ___nl__17,___nl__29);

//line 618
___nl__29 = null;
//line 619
___nl__25 = new ImmDouble((Double.Parse(___nl__25.getValue().ToString()))+(Double.Parse(___nl__26.getValue().ToString()))).clone();
//line 619
if (true) {goto label_41;}
//line 619
label_39:
//line 619
___nl__23 = null;
//line 619
___nl__24 = null;
//line 619
___nl__25 = null;
//line 619
___nl__26 = null;
//line 619
___nl__27 = null;
//line 619
___nl__28 = null;
//line 620
___nl__24 = ((ImmHash)___nl__22).getHashValue()["dest"].clone();
//line 620
___nl__23 = new ImmArray(new Imm[] {___nl__24,}).clone();
//line 620
___nl__24 = null;
//line 620
___nl__19 = ___nl__23.clone();
//line 620
___nl__23 = null;
//line 621
post_processing_NL.NL_evaluate_const_priv(___nl__7,___nl__8,___nl__16,ref ___nl__17,ref ___nl__6,___nl__5,___nl__19);

//line 621
___nl__22 = null;
//line 622
if (true) {goto label_17;}
//line 622
label_19:
//line 622
___nl__22 = c_rt_lib_NL.NL_ov_as(___nl__20, new ImmString("hash_decl")).clone();
//line 623
___nl__23 = ((ImmHash)___nl__22).getHashValue()["src"].clone();
//line 623
___nl__25 = new ImmDouble(0).clone();
//line 623
___nl__26 = new ImmDouble(1).clone();
//line 623
___nl__27 = c_rt_lib_NL.NL_array_len(___nl__23).clone();

//line 623
label_44:
//line 623
___nl__28 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__25.getValue().ToString()))>=(Double.Parse(___nl__27.getValue().ToString())) ).clone();
//line 623
if (c_rt_lib_NL.NL_check_true_native(___nl__28)) {if (true) {goto label_42;}}
//line 623
___nl__24 = (___nl__23 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__25).getDoubleValue()].clone();
//line 624
___nl__30 = ((ImmHash)___nl__24).getHashValue()["val"].clone();
//line 624
___nl__29 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__30).getDoubleValue()].clone();
//line 624
___nl__30 = null;
//line 624
post_processing_NL.NL_check_sub_val_priv(ref ___nl__17,___nl__29);

//line 624
___nl__29 = null;
//line 625
___nl__25 = new ImmDouble((Double.Parse(___nl__25.getValue().ToString()))+(Double.Parse(___nl__26.getValue().ToString()))).clone();
//line 625
if (true) {goto label_44;}
//line 625
label_42:
//line 625
___nl__23 = null;
//line 625
___nl__24 = null;
//line 625
___nl__25 = null;
//line 625
___nl__26 = null;
//line 625
___nl__27 = null;
//line 625
___nl__28 = null;
//line 626
___nl__24 = ((ImmHash)___nl__22).getHashValue()["dest"].clone();
//line 626
___nl__23 = new ImmArray(new Imm[] {___nl__24,}).clone();
//line 626
___nl__24 = null;
//line 626
___nl__19 = ___nl__23.clone();
//line 626
___nl__23 = null;
//line 627
post_processing_NL.NL_evaluate_const_priv(___nl__7,___nl__8,___nl__16,ref ___nl__17,ref ___nl__6,___nl__5,___nl__19);

//line 627
___nl__22 = null;
//line 628
if (true) {goto label_17;}
//line 628
label_20:
//line 628
___nl__22 = c_rt_lib_NL.NL_ov_as(___nl__20, new ImmString("call")).clone();
//line 629
___nl__23 = ((ImmHash)___nl__22).getHashValue()["args"].clone();
//line 629
___nl__25 = new ImmDouble(0).clone();
//line 629
___nl__26 = new ImmDouble(1).clone();
//line 629
___nl__27 = c_rt_lib_NL.NL_array_len(___nl__23).clone();

//line 629
label_47:
//line 629
___nl__28 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__25.getValue().ToString()))>=(Double.Parse(___nl__27.getValue().ToString())) ).clone();
//line 629
if (c_rt_lib_NL.NL_check_true_native(___nl__28)) {if (true) {goto label_45;}}
//line 629
___nl__24 = (___nl__23 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__25).getDoubleValue()].clone();
//line 630
___nl__29 = c_rt_lib_NL.NL_ov_is(___nl__24, new ImmString("val")).clone();
//line 630
if (c_rt_lib_NL.NL_check_true_native(___nl__29)) {if (true) {goto label_49;}}
//line 632
___nl__29 = c_rt_lib_NL.NL_ov_is(___nl__24, new ImmString("ref")).clone();
//line 632
if (c_rt_lib_NL.NL_check_true_native(___nl__29)) {if (true) {goto label_50;}}
//line 632
___nl__29 = new ImmString("NOMATCHALERT").clone();
//line 632
___nl__29 = new ImmArray(new Imm[] {___nl__29,___nl__24,}).clone();
//line 632
c_rt_lib_NL.NL_die();
//line 630
label_49:
//line 630
___nl__30 = c_rt_lib_NL.NL_ov_as(___nl__24, new ImmString("val")).clone();
//line 631
___nl__31 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__30).getDoubleValue()].clone();
//line 631
post_processing_NL.NL_check_sub_val_priv(ref ___nl__17,___nl__31);

//line 631
___nl__31 = null;
//line 631
___nl__30 = null;
//line 632
if (true) {goto label_48;}
//line 632
label_50:
//line 632
___nl__30 = c_rt_lib_NL.NL_ov_as(___nl__24, new ImmString("ref")).clone();
//line 633
___nl__31 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__30).getDoubleValue()].clone();
//line 633
post_processing_NL.NL_check_sub_val_priv(ref ___nl__17,___nl__31);

//line 633
___nl__31 = null;
//line 634
array_NL.NL_push(ref ___nl__19,___nl__30);

//line 634
___nl__30 = null;
//line 635
if (true) {goto label_48;}
//line 635
label_48:
//line 635
___nl__29 = null;
//line 636
___nl__25 = new ImmDouble((Double.Parse(___nl__25.getValue().ToString()))+(Double.Parse(___nl__26.getValue().ToString()))).clone();
//line 636
if (true) {goto label_47;}
//line 636
label_45:
//line 636
___nl__23 = null;
//line 636
___nl__24 = null;
//line 636
___nl__25 = null;
//line 636
___nl__26 = null;
//line 636
___nl__27 = null;
//line 636
___nl__28 = null;
//line 637
___nl__23 = ((ImmHash)___nl__22).getHashValue()["dest"].clone();
//line 637
array_NL.NL_push(ref ___nl__19,___nl__23);

//line 637
___nl__23 = null;
//line 638
___nl__23 = ((ImmHash)___nl__22).getHashValue()["mod"].clone();
//line 638
___nl__24 = new ImmString("").clone();
//line 638
___nl__23 = c_rt_lib_NL.NL_native_to_nl(___nl__23.toString().Equals(___nl__24.toString())).clone();
//line 638
___nl__24 = null;
//line 638
if (c_rt_lib_NL.NL_check_true_native(___nl__23)) {if (true) {goto label_52;}}
//line 638
___nl__23 = ((ImmHash)___nl__22).getHashValue()["mod"].clone();
//line 638
if (true) {goto label_51;}
//line 638
label_52:
//line 638
___nl__23 = new ImmString("_priv").clone();
//line 638
___nl__23 = new ImmString(___nl__8.toString() + ___nl__23.toString()).clone();
//line 638
label_51:
//line 638
___nl__24 = new ImmString("::").clone();
//line 638
___nl__23 = new ImmString(___nl__23.toString() + ___nl__24.toString()).clone();
//line 638
___nl__24 = null;
//line 638
___nl__24 = ((ImmHash)___nl__22).getHashValue()["fun_name"].clone();
//line 638
___nl__23 = new ImmString(___nl__23.toString() + ___nl__24.toString()).clone();
//line 638
___nl__24 = null;
//line 639
___nl__24 = hash_NL.NL_has_key(___nl__3,___nl__23).clone();

//line 639
___nl__24 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__24)).clone();
//line 639
if (c_rt_lib_NL.NL_check_true_native(___nl__24)) {if (true) {goto label_54;}}
//line 640
___nl__25 = hash_NL.NL_get_value(___nl__3,___nl__23).clone();

//line 640
___nl__25 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__25)).clone();
//line 640
___nl__25 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__25)).clone();
//line 640
if (c_rt_lib_NL.NL_check_true_native(___nl__25)) {if (true) {goto label_56;}}
//line 640
___nl__26 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("no")).clone();
//line 640
___nl__17 = ___nl__26.clone();
//line 640
___nl__26 = null;
//line 640
if (true) {goto label_56;}
//line 640
label_56:
//line 640
___nl__25 = null;
//line 641
if (true) {goto label_53;}
//line 641
label_54:
//line 642
___nl__25 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("no")).clone();
//line 642
___nl__17 = ___nl__25.clone();
//line 642
___nl__25 = null;
//line 643
if (true) {goto label_53;}
//line 643
label_53:
//line 643
___nl__24 = null;
//line 644
___nl__24 = ((ImmHash)___nl__22).getHashValue()["mod"].clone();
//line 644
___nl__25 = new ImmString("c_rt_lib").clone();
//line 644
___nl__24 = c_rt_lib_NL.NL_native_to_nl(___nl__24.toString().Equals(___nl__25.toString())).clone();
//line 644
___nl__25 = null;
//line 644
___nl__24 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__24)).clone();
//line 644
if (c_rt_lib_NL.NL_check_true_native(___nl__24)) {if (true) {goto label_58;}}
//line 645
___nl__25 = ((ImmHash)___nl__22).getHashValue()["fun_name"].clone();
//line 645
___nl__26 = new ImmString("init_iter").clone();
//line 645
___nl__25 = c_rt_lib_NL.NL_native_to_nl(___nl__25.toString().Equals(___nl__26.toString())).clone();
//line 645
___nl__26 = null;
//line 645
if (c_rt_lib_NL.NL_check_true_native(___nl__25)) {if (true) {goto label_63;}}
//line 645
___nl__25 = ((ImmHash)___nl__22).getHashValue()["fun_name"].clone();
//line 645
___nl__26 = new ImmString("is_end_hash").clone();
//line 645
___nl__25 = c_rt_lib_NL.NL_native_to_nl(___nl__25.toString().Equals(___nl__26.toString())).clone();
//line 645
___nl__26 = null;
//line 645
label_63:
//line 645
if (c_rt_lib_NL.NL_check_true_native(___nl__25)) {if (true) {goto label_62;}}
//line 645
___nl__25 = ((ImmHash)___nl__22).getHashValue()["fun_name"].clone();
//line 645
___nl__26 = new ImmString("get_key_iter").clone();
//line 645
___nl__25 = c_rt_lib_NL.NL_native_to_nl(___nl__25.toString().Equals(___nl__26.toString())).clone();
//line 645
___nl__26 = null;
//line 645
label_62:
//line 645
if (c_rt_lib_NL.NL_check_true_native(___nl__25)) {if (true) {goto label_61;}}
//line 645
___nl__25 = ((ImmHash)___nl__22).getHashValue()["fun_name"].clone();
//line 645
___nl__26 = new ImmString("next_iter").clone();
//line 645
___nl__25 = c_rt_lib_NL.NL_native_to_nl(___nl__25.toString().Equals(___nl__26.toString())).clone();
//line 645
___nl__26 = null;
//line 645
label_61:
//line 645
___nl__25 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__25)).clone();
//line 645
if (c_rt_lib_NL.NL_check_true_native(___nl__25)) {if (true) {goto label_60;}}
//line 646
___nl__26 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("no")).clone();
//line 646
___nl__17 = ___nl__26.clone();
//line 646
___nl__26 = null;
//line 647
if (true) {goto label_60;}
//line 647
label_60:
//line 647
___nl__25 = null;
//line 648
if (true) {goto label_58;}
//line 648
label_58:
//line 648
___nl__24 = null;
//line 649
post_processing_NL.NL_evaluate_const_priv(___nl__7,___nl__8,___nl__16,ref ___nl__17,ref ___nl__6,___nl__5,___nl__19);

//line 649
___nl__23 = null;
//line 649
___nl__22 = null;
//line 650
if (true) {goto label_17;}
//line 650
label_21:
//line 650
___nl__22 = c_rt_lib_NL.NL_ov_as(___nl__20, new ImmString("una_op")).clone();
//line 651
___nl__24 = ((ImmHash)___nl__22).getHashValue()["src"].clone();
//line 651
___nl__23 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__24).getDoubleValue()].clone();
//line 651
___nl__24 = null;
//line 651
post_processing_NL.NL_check_sub_val_priv(ref ___nl__17,___nl__23);

//line 651
___nl__23 = null;
//line 652
___nl__24 = ((ImmHash)___nl__22).getHashValue()["dest"].clone();
//line 652
___nl__23 = new ImmArray(new Imm[] {___nl__24,}).clone();
//line 652
___nl__24 = null;
//line 652
___nl__19 = ___nl__23.clone();
//line 652
___nl__23 = null;
//line 653
post_processing_NL.NL_evaluate_const_priv(___nl__7,___nl__8,___nl__16,ref ___nl__17,ref ___nl__6,___nl__5,___nl__19);

//line 653
___nl__22 = null;
//line 654
if (true) {goto label_17;}
//line 654
label_22:
//line 654
___nl__22 = c_rt_lib_NL.NL_ov_as(___nl__20, new ImmString("bin_op")).clone();
//line 655
___nl__24 = ((ImmHash)___nl__22).getHashValue()["left"].clone();
//line 655
___nl__23 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__24).getDoubleValue()].clone();
//line 655
___nl__24 = null;
//line 655
post_processing_NL.NL_check_sub_val_priv(ref ___nl__17,___nl__23);

//line 655
___nl__23 = null;
//line 656
___nl__24 = ((ImmHash)___nl__22).getHashValue()["right"].clone();
//line 656
___nl__23 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__24).getDoubleValue()].clone();
//line 656
___nl__24 = null;
//line 656
post_processing_NL.NL_check_sub_val_priv(ref ___nl__17,___nl__23);

//line 656
___nl__23 = null;
//line 657
___nl__24 = ((ImmHash)___nl__22).getHashValue()["dest"].clone();
//line 657
___nl__23 = new ImmArray(new Imm[] {___nl__24,}).clone();
//line 657
___nl__24 = null;
//line 657
___nl__19 = ___nl__23.clone();
//line 657
___nl__23 = null;
//line 658
post_processing_NL.NL_evaluate_const_priv(___nl__7,___nl__8,___nl__16,ref ___nl__17,ref ___nl__6,___nl__5,___nl__19);

//line 658
___nl__22 = null;
//line 659
if (true) {goto label_17;}
//line 659
label_23:
//line 659
___nl__22 = c_rt_lib_NL.NL_ov_as(___nl__20, new ImmString("ov_is")).clone();
//line 660
___nl__24 = ((ImmHash)___nl__22).getHashValue()["src"].clone();
//line 660
___nl__23 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__24).getDoubleValue()].clone();
//line 660
___nl__24 = null;
//line 660
post_processing_NL.NL_check_sub_val_priv(ref ___nl__17,___nl__23);

//line 660
___nl__23 = null;
//line 661
___nl__24 = ((ImmHash)___nl__22).getHashValue()["dest"].clone();
//line 661
___nl__23 = new ImmArray(new Imm[] {___nl__24,}).clone();
//line 661
___nl__24 = null;
//line 661
___nl__19 = ___nl__23.clone();
//line 661
___nl__23 = null;
//line 662
post_processing_NL.NL_evaluate_const_priv(___nl__7,___nl__8,___nl__16,ref ___nl__17,ref ___nl__6,___nl__5,___nl__19);

//line 662
___nl__22 = null;
//line 663
if (true) {goto label_17;}
//line 663
label_24:
//line 663
___nl__22 = c_rt_lib_NL.NL_ov_as(___nl__20, new ImmString("ov_as")).clone();
//line 664
___nl__24 = ((ImmHash)___nl__22).getHashValue()["src"].clone();
//line 664
___nl__23 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__24).getDoubleValue()].clone();
//line 664
___nl__24 = null;
//line 664
post_processing_NL.NL_check_sub_val_priv(ref ___nl__17,___nl__23);

//line 664
___nl__23 = null;
//line 665
___nl__24 = ((ImmHash)___nl__22).getHashValue()["dest"].clone();
//line 665
___nl__23 = new ImmArray(new Imm[] {___nl__24,}).clone();
//line 665
___nl__24 = null;
//line 665
___nl__19 = ___nl__23.clone();
//line 665
___nl__23 = null;
//line 666
post_processing_NL.NL_evaluate_const_priv(___nl__7,___nl__8,___nl__16,ref ___nl__17,ref ___nl__6,___nl__5,___nl__19);

//line 666
___nl__22 = null;
//line 667
if (true) {goto label_17;}
//line 667
label_25:
//line 667
___nl__22 = c_rt_lib_NL.NL_ov_as(___nl__20, new ImmString("func")).clone();
//line 668
___nl__24 = ((ImmHash)___nl__22).getHashValue()["dest"].clone();
//line 668
___nl__23 = new ImmArray(new Imm[] {___nl__24,}).clone();
//line 668
___nl__24 = null;
//line 668
___nl__19 = ___nl__23.clone();
//line 668
___nl__23 = null;
//line 669
___nl__23 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("no")).clone();
//line 669
___nl__17 = ___nl__23.clone();
//line 669
___nl__23 = null;
//line 670
post_processing_NL.NL_evaluate_const_priv(___nl__7,___nl__8,___nl__16,ref ___nl__17,ref ___nl__6,___nl__5,___nl__19);

//line 670
___nl__22 = null;
//line 671
if (true) {goto label_17;}
//line 671
label_26:
//line 671
___nl__22 = c_rt_lib_NL.NL_ov_as(___nl__20, new ImmString("move")).clone();
//line 672
___nl__24 = ((ImmHash)___nl__22).getHashValue()["src"].clone();
//line 672
___nl__23 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__24).getDoubleValue()].clone();
//line 672
___nl__24 = null;
//line 672
post_processing_NL.NL_check_sub_val_priv(ref ___nl__17,___nl__23);

//line 672
___nl__23 = null;
//line 673
___nl__24 = ((ImmHash)___nl__22).getHashValue()["dest"].clone();
//line 673
___nl__23 = new ImmArray(new Imm[] {___nl__24,}).clone();
//line 673
___nl__24 = null;
//line 673
___nl__19 = ___nl__23.clone();
//line 673
___nl__23 = null;
//line 674
post_processing_NL.NL_evaluate_const_priv(___nl__7,___nl__8,___nl__16,ref ___nl__17,ref ___nl__6,___nl__5,___nl__19);

//line 674
___nl__22 = null;
//line 675
if (true) {goto label_17;}
//line 675
label_27:
//line 675
___nl__22 = c_rt_lib_NL.NL_ov_as(___nl__20, new ImmString("load_const")).clone();
//line 676
___nl__24 = ((ImmHash)___nl__22).getHashValue()["dest"].clone();
//line 676
___nl__23 = new ImmArray(new Imm[] {___nl__24,}).clone();
//line 676
___nl__24 = null;
//line 676
___nl__19 = ___nl__23.clone();
//line 676
___nl__23 = null;
//line 677
___nl__24 = ((ImmHash)___nl__9).getHashValue()["from"].clone();
//line 677
___nl__24 = new ImmDouble((Double.Parse(___nl__13.getValue().ToString()))+(Double.Parse(___nl__24.getValue().ToString()))).clone();
//line 677
___nl__25 = ((ImmHash)___nl__22).getHashValue()["val"].clone();
//line 677
__function_map = new Dictionary<String, Imm>();
__function_map.Add("nr",___nl__24);
__function_map.Add("value",___nl__25);
___nl__23 = new ImmHash(__function_map).clone();
//line 677
___nl__24 = null;
//line 677
___nl__25 = null;
//line 677
___nl__23 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("yes"), ___nl__23).clone();
//line 677
___nl__17 = ___nl__23.clone();
//line 677
___nl__23 = null;
//line 678
___nl__23 = ((ImmHash)___nl__22).getHashValue()["dest"].clone();
//line 678
___nl__24 = new ImmString("").clone();
//line 678
___nl__23 = c_rt_lib_NL.NL_native_to_nl(___nl__23.toString().Equals(___nl__24.toString())).clone();
//line 678
___nl__24 = null;
//line 678
___nl__23 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__23)).clone();
//line 678
___nl__23 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__23)).clone();
//line 678
if (c_rt_lib_NL.NL_check_true_native(___nl__23)) {if (true) {goto label_65;}}
//line 678
___nl__25 = ((ImmHash)___nl__22).getHashValue()["dest"].clone();
//line 678
___nl__24 = ___nl__17.clone();
//line 678
(___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__25).getDoubleValue()] = ___nl__24;
//line 678
___nl__24 = null;
//line 678
___nl__25 = null;
//line 678
if (true) {goto label_65;}
//line 678
label_65:
//line 678
___nl__23 = null;
//line 679
___nl__24 = ((ImmHash)___nl__22).getHashValue()["dest"].clone();
//line 679
___nl__23 = new ImmArray(new Imm[] {___nl__24,}).clone();
//line 679
___nl__24 = null;
//line 679
___nl__23 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("const"), ___nl__23).clone();
//line 679
___nl__24 = ___nl__23.clone();
//line 679
((ImmHash)___nl__18).set("annotation", ___nl__24);
//line 679
___nl__23 = null;
//line 679
___nl__24 = null;
//line 679
___nl__22 = null;
//line 680
if (true) {goto label_17;}
//line 680
label_28:
//line 680
___nl__22 = c_rt_lib_NL.NL_ov_as(___nl__20, new ImmString("get_frm_idx")).clone();
//line 681
___nl__24 = ((ImmHash)___nl__22).getHashValue()["src"].clone();
//line 681
___nl__23 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__24).getDoubleValue()].clone();
//line 681
___nl__24 = null;
//line 681
post_processing_NL.NL_check_sub_val_priv(ref ___nl__17,___nl__23);

//line 681
___nl__23 = null;
//line 682
___nl__24 = ((ImmHash)___nl__22).getHashValue()["idx"].clone();
//line 682
___nl__23 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__24).getDoubleValue()].clone();
//line 682
___nl__24 = null;
//line 682
post_processing_NL.NL_check_sub_val_priv(ref ___nl__17,___nl__23);

//line 682
___nl__23 = null;
//line 683
___nl__24 = ((ImmHash)___nl__22).getHashValue()["dest"].clone();
//line 683
___nl__23 = new ImmArray(new Imm[] {___nl__24,}).clone();
//line 683
___nl__24 = null;
//line 683
___nl__19 = ___nl__23.clone();
//line 683
___nl__23 = null;
//line 684
post_processing_NL.NL_evaluate_const_priv(___nl__7,___nl__8,___nl__16,ref ___nl__17,ref ___nl__6,___nl__5,___nl__19);

//line 684
___nl__22 = null;
//line 685
if (true) {goto label_17;}
//line 685
label_29:
//line 685
___nl__22 = c_rt_lib_NL.NL_ov_as(___nl__20, new ImmString("set_at_idx")).clone();
//line 686
___nl__24 = ((ImmHash)___nl__22).getHashValue()["src"].clone();
//line 686
___nl__23 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__24).getDoubleValue()].clone();
//line 686
___nl__24 = null;
//line 686
post_processing_NL.NL_check_sub_val_priv(ref ___nl__17,___nl__23);

//line 686
___nl__23 = null;
//line 687
___nl__24 = ((ImmHash)___nl__22).getHashValue()["idx"].clone();
//line 687
___nl__23 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__24).getDoubleValue()].clone();
//line 687
___nl__24 = null;
//line 687
post_processing_NL.NL_check_sub_val_priv(ref ___nl__17,___nl__23);

//line 687
___nl__23 = null;
//line 688
___nl__24 = ((ImmHash)___nl__22).getHashValue()["val"].clone();
//line 688
___nl__23 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__24).getDoubleValue()].clone();
//line 688
___nl__24 = null;
//line 688
post_processing_NL.NL_check_sub_val_priv(ref ___nl__17,___nl__23);

//line 688
___nl__23 = null;
//line 689
___nl__24 = ((ImmHash)___nl__22).getHashValue()["src"].clone();
//line 689
___nl__23 = new ImmArray(new Imm[] {___nl__24,}).clone();
//line 689
___nl__24 = null;
//line 689
___nl__19 = ___nl__23.clone();
//line 689
___nl__23 = null;
//line 690
post_processing_NL.NL_evaluate_const_priv(___nl__7,___nl__8,___nl__16,ref ___nl__17,ref ___nl__6,___nl__5,___nl__19);

//line 690
___nl__22 = null;
//line 691
if (true) {goto label_17;}
//line 691
label_30:
//line 691
___nl__22 = c_rt_lib_NL.NL_ov_as(___nl__20, new ImmString("get_val")).clone();
//line 692
___nl__24 = ((ImmHash)___nl__22).getHashValue()["src"].clone();
//line 692
___nl__23 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__24).getDoubleValue()].clone();
//line 692
___nl__24 = null;
//line 692
post_processing_NL.NL_check_sub_val_priv(ref ___nl__17,___nl__23);

//line 692
___nl__23 = null;
//line 693
___nl__24 = ((ImmHash)___nl__22).getHashValue()["dest"].clone();
//line 693
___nl__23 = new ImmArray(new Imm[] {___nl__24,}).clone();
//line 693
___nl__24 = null;
//line 693
___nl__19 = ___nl__23.clone();
//line 693
___nl__23 = null;
//line 694
post_processing_NL.NL_evaluate_const_priv(___nl__7,___nl__8,___nl__16,ref ___nl__17,ref ___nl__6,___nl__5,___nl__19);

//line 694
___nl__22 = null;
//line 695
if (true) {goto label_17;}
//line 695
label_31:
//line 695
___nl__22 = c_rt_lib_NL.NL_ov_as(___nl__20, new ImmString("set_val")).clone();
//line 696
___nl__24 = ((ImmHash)___nl__22).getHashValue()["src"].clone();
//line 696
___nl__23 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__24).getDoubleValue()].clone();
//line 696
___nl__24 = null;
//line 696
post_processing_NL.NL_check_sub_val_priv(ref ___nl__17,___nl__23);

//line 696
___nl__23 = null;
//line 697
___nl__24 = ((ImmHash)___nl__22).getHashValue()["val"].clone();
//line 697
___nl__23 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__24).getDoubleValue()].clone();
//line 697
___nl__24 = null;
//line 697
post_processing_NL.NL_check_sub_val_priv(ref ___nl__17,___nl__23);

//line 697
___nl__23 = null;
//line 698
___nl__24 = ((ImmHash)___nl__22).getHashValue()["src"].clone();
//line 698
___nl__23 = new ImmArray(new Imm[] {___nl__24,}).clone();
//line 698
___nl__24 = null;
//line 698
___nl__19 = ___nl__23.clone();
//line 698
___nl__23 = null;
//line 699
post_processing_NL.NL_evaluate_const_priv(___nl__7,___nl__8,___nl__16,ref ___nl__17,ref ___nl__6,___nl__5,___nl__19);

//line 699
___nl__22 = null;
//line 700
if (true) {goto label_17;}
//line 700
label_32:
//line 700
___nl__22 = c_rt_lib_NL.NL_ov_as(___nl__20, new ImmString("ov_mk")).clone();
//line 701
___nl__23 = ((ImmHash)___nl__22).getHashValue()["src"].clone();
//line 701
___nl__23 = c_rt_lib_NL.NL_ov_is(___nl__23, new ImmString("arg")).clone();
//line 701
___nl__23 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__23)).clone();
//line 701
if (c_rt_lib_NL.NL_check_true_native(___nl__23)) {if (true) {goto label_67;}}
//line 702
___nl__25 = ((ImmHash)___nl__22).getHashValue()["src"].clone();
//line 702
___nl__25 = c_rt_lib_NL.NL_ov_as(___nl__25, new ImmString("arg")).clone();
//line 702
___nl__24 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__25).getDoubleValue()].clone();
//line 702
___nl__25 = null;
//line 702
post_processing_NL.NL_check_sub_val_priv(ref ___nl__17,___nl__24);

//line 702
___nl__24 = null;
//line 703
if (true) {goto label_67;}
//line 703
label_67:
//line 703
___nl__23 = null;
//line 704
___nl__24 = ((ImmHash)___nl__22).getHashValue()["dest"].clone();
//line 704
___nl__23 = new ImmArray(new Imm[] {___nl__24,}).clone();
//line 704
___nl__24 = null;
//line 704
___nl__19 = ___nl__23.clone();
//line 704
___nl__23 = null;
//line 705
post_processing_NL.NL_evaluate_const_priv(___nl__7,___nl__8,___nl__16,ref ___nl__17,ref ___nl__6,___nl__5,___nl__19);

//line 705
___nl__22 = null;
//line 706
if (true) {goto label_17;}
//line 706
label_33:
//line 706
___nl__22 = c_rt_lib_NL.NL_ov_as(___nl__20, new ImmString("return")).clone();
//line 707
___nl__23 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("no")).clone();
//line 707
___nl__17 = ___nl__23.clone();
//line 707
___nl__23 = null;
//line 708
___nl__23 = ___nl__22.clone();
//line 708
___nl__23 = c_rt_lib_NL.NL_ov_is(___nl__23, new ImmString("val")).clone();
//line 708
___nl__23 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__23)).clone();
//line 708
if (c_rt_lib_NL.NL_check_true_native(___nl__23)) {if (true) {goto label_69;}}
//line 709
___nl__25 = ___nl__22.clone();
//line 709
___nl__25 = c_rt_lib_NL.NL_ov_as(___nl__25, new ImmString("val")).clone();
//line 709
___nl__24 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__25).getDoubleValue()].clone();
//line 709
___nl__25 = null;
//line 709
post_processing_NL.NL_check_sub_val_priv(ref ___nl__17,___nl__24);

//line 709
___nl__24 = null;
//line 710
if (true) {goto label_69;}
//line 710
label_69:
//line 710
___nl__23 = null;
//line 710
___nl__22 = null;
//line 711
if (true) {goto label_17;}
//line 711
label_34:
//line 711
___nl__22 = c_rt_lib_NL.NL_ov_as(___nl__20, new ImmString("die")).clone();
//line 712
___nl__23 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("no")).clone();
//line 712
___nl__17 = ___nl__23.clone();
//line 712
___nl__23 = null;
//line 713
___nl__23 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__22).getDoubleValue()].clone();
//line 713
post_processing_NL.NL_check_sub_val_priv(ref ___nl__17,___nl__23);

//line 713
___nl__23 = null;
//line 713
___nl__22 = null;
//line 714
if (true) {goto label_17;}
//line 714
label_35:
//line 714
___nl__22 = c_rt_lib_NL.NL_ov_as(___nl__20, new ImmString("prt_lbl")).clone();
//line 715
___nl__23 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("no")).clone();
//line 715
___nl__17 = ___nl__23.clone();
//line 715
___nl__23 = null;
//line 715
___nl__22 = null;
//line 716
if (true) {goto label_17;}
//line 716
label_36:
//line 716
___nl__22 = c_rt_lib_NL.NL_ov_as(___nl__20, new ImmString("if_goto")).clone();
//line 717
___nl__23 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("no")).clone();
//line 717
___nl__17 = ___nl__23.clone();
//line 717
___nl__23 = null;
//line 718
___nl__24 = ((ImmHash)___nl__22).getHashValue()["src"].clone();
//line 718
___nl__23 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__24).getDoubleValue()].clone();
//line 718
___nl__24 = null;
//line 718
post_processing_NL.NL_check_sub_val_priv(ref ___nl__17,___nl__23);

//line 718
___nl__23 = null;
//line 718
___nl__22 = null;
//line 719
if (true) {goto label_17;}
//line 719
label_37:
//line 719
___nl__22 = c_rt_lib_NL.NL_ov_as(___nl__20, new ImmString("goto")).clone();
//line 720
___nl__23 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("no")).clone();
//line 720
___nl__17 = ___nl__23.clone();
//line 720
___nl__23 = null;
//line 720
___nl__22 = null;
//line 721
if (true) {goto label_17;}
//line 721
label_38:
//line 721
___nl__22 = c_rt_lib_NL.NL_ov_as(___nl__20, new ImmString("clear")).clone();
//line 722
___nl__23 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("no")).clone();
//line 722
___nl__17 = ___nl__23.clone();
//line 722
___nl__23 = null;
//line 723
___nl__23 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("no")).clone();
//line 723
___nl__24 = ___nl__23.clone();
//line 723
(___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__22).getDoubleValue()] = ___nl__24;
//line 723
___nl__23 = null;
//line 723
___nl__24 = null;
//line 723
___nl__22 = null;
//line 724
if (true) {goto label_17;}
//line 724
label_17:
//line 724
___nl__20 = null;
//line 724
___nl__21 = null;
//line 725
___nl__20 = ___nl__17.clone();
//line 725
___nl__20 = c_rt_lib_NL.NL_ov_is(___nl__20, new ImmString("yes")).clone();
//line 725
___nl__20 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__20)).clone();
//line 725
if (c_rt_lib_NL.NL_check_true_native(___nl__20)) {if (true) {goto label_71;}}
//line 726
___nl__22 = new ImmDouble(0).clone();
//line 726
___nl__23 = new ImmDouble(1).clone();
//line 726
___nl__24 = c_rt_lib_NL.NL_array_len(___nl__19).clone();

//line 726
label_74:
//line 726
___nl__25 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__22.getValue().ToString()))>=(Double.Parse(___nl__24.getValue().ToString())) ).clone();
//line 726
if (c_rt_lib_NL.NL_check_true_native(___nl__25)) {if (true) {goto label_72;}}
//line 726
___nl__21 = (___nl__19 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__22).getDoubleValue()].clone();
//line 727
___nl__26 = new ImmString("").clone();
//line 727
___nl__26 = c_rt_lib_NL.NL_native_to_nl(___nl__21.toString().Equals(___nl__26.toString())).clone();
//line 727
___nl__26 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__26)).clone();
//line 727
___nl__26 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__26)).clone();
//line 727
if (c_rt_lib_NL.NL_check_true_native(___nl__26)) {if (true) {goto label_76;}}
//line 727
___nl__27 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__21).getDoubleValue()].clone();
//line 727
___nl__28 = (___nl__11 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__13).getDoubleValue()].clone();
//line 727
post_processing_NL.NL_push_load_const_priv(ref ___nl__10,___nl__27,___nl__21,___nl__28);

//line 727
___nl__28 = null;
//line 727
___nl__27 = null;
//line 727
if (true) {goto label_76;}
//line 727
label_76:
//line 727
___nl__26 = null;
//line 728
___nl__22 = new ImmDouble((Double.Parse(___nl__22.getValue().ToString()))+(Double.Parse(___nl__23.getValue().ToString()))).clone();
//line 728
if (true) {goto label_74;}
//line 728
label_72:
//line 728
___nl__21 = null;
//line 728
___nl__22 = null;
//line 728
___nl__23 = null;
//line 728
___nl__24 = null;
//line 728
___nl__25 = null;
//line 729
if (true) {goto label_70;}
//line 729
label_71:
//line 730
array_NL.NL_push(ref ___nl__10,___nl__18);

//line 731
if (true) {goto label_70;}
//line 731
label_70:
//line 731
___nl__20 = null;
//line 731
___nl__16 = null;
//line 731
___nl__17 = null;
//line 731
___nl__18 = null;
//line 731
___nl__19 = null;
//line 732
___nl__13 = new ImmDouble((Double.Parse(___nl__13.getValue().ToString()))+(Double.Parse(___nl__14.getValue().ToString()))).clone();
//line 732
if (true) {goto label_16;}
//line 732
label_14:
//line 732
___nl__12 = null;
//line 732
___nl__13 = null;
//line 732
___nl__14 = null;
//line 732
___nl__15 = null;
//line 733
___nl__12 = c_rt_lib_NL.NL_get_ref_arr(___nl__2,___nl__0).clone();

//line 733
___nl__13 = ___nl__10.clone();
//line 733
((ImmHash)___nl__12).set("cmds", ___nl__13);
//line 733
c_rt_lib_NL.NL_set_ref_arr(ref ___nl__2,___nl__0,___nl__12);

//line 733
___nl__12 = null;
//line 733
___nl__13 = null;
//line 734
___nl__12 = ((ImmHash)___nl__9).getHashValue()["next"].clone();
//line 734
___nl__14 = new ImmDouble(0).clone();
//line 734
___nl__15 = new ImmDouble(1).clone();
//line 734
___nl__16 = c_rt_lib_NL.NL_array_len(___nl__12).clone();

//line 734
label_79:
//line 734
___nl__17 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__14.getValue().ToString()))>=(Double.Parse(___nl__16.getValue().ToString())) ).clone();
//line 734
if (c_rt_lib_NL.NL_check_true_native(___nl__17)) {if (true) {goto label_77;}}
//line 734
___nl__13 = (___nl__12 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__14).getDoubleValue()].clone();
//line 735
post_processing_NL.NL_set_const_block_val_priv(___nl__13,___nl__1,ref ___nl__2,___nl__3,ref ___nl__4,___nl__5,___nl__6,___nl__7,___nl__8);

//line 736
___nl__14 = new ImmDouble((Double.Parse(___nl__14.getValue().ToString()))+(Double.Parse(___nl__15.getValue().ToString()))).clone();
//line 736
if (true) {goto label_79;}
//line 736
label_77:
//line 736
___nl__12 = null;
//line 736
___nl__13 = null;
//line 736
___nl__14 = null;
//line 736
___nl__15 = null;
//line 736
___nl__16 = null;
//line 736
___nl__17 = null;
//line 736
___nl__9 = null;
//line 736
___nl__10 = null;
//line 736
___nl__11 = null;
//line 736
___nl__0 = null;
//line 736
___nl__1 = null;
//line 736
___nl__3 = null;
//line 736
___nl__5 = null;
//line 736
___nl__6 = null;
//line 736
___nl__7 = null;
//line 736
___nl__8 = null;
//line 736
___arg__2 = ___nl__2;___arg__4 = ___nl__4;if(true) return null;
}

private static Imm NL_delete_unused_labels_com_priv(ref Imm ___arg__0) {
Imm ___nl__0 = ___arg__0;
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
Dictionary<String, Imm> __function_map;
//line 739
__function_map = new Dictionary<String, Imm>();
___nl__1 = new ImmHash(__function_map).clone();
//line 740
__function_map = new Dictionary<String, Imm>();
___nl__2 = new ImmHash(__function_map).clone();
//line 742
___nl__4 = new ImmString("").clone();
//line 743
___nl__6 = new ImmDouble(0).clone();
//line 743
___nl__7 = new ImmDouble(1).clone();
//line 743
___nl__8 = c_rt_lib_NL.NL_array_len(___nl__0).clone();

//line 743
label_3:
//line 743
___nl__9 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__6.getValue().ToString()))>=(Double.Parse(___nl__8.getValue().ToString())) ).clone();
//line 743
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_1;}}
//line 743
___nl__5 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()].clone();
//line 744
___nl__10 = ((ImmHash)___nl__5).getHashValue()["cmd"].clone();
//line 745
___nl__11 = ___nl__10.clone();
//line 745
___nl__11 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("prt_lbl")).clone();
//line 745
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 745
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_5;}}
//line 746
___nl__12 = ___nl__10.clone();
//line 746
___nl__12 = c_rt_lib_NL.NL_ov_as(___nl__12, new ImmString("prt_lbl")).clone();
//line 746
___nl__3 = ___nl__12.clone();
//line 746
___nl__12 = null;
//line 747
___nl__12 = new ImmString("").clone();
//line 747
___nl__12 = c_rt_lib_NL.NL_native_to_nl(___nl__4.toString().Equals(___nl__12.toString())).clone();
//line 747
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 747
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_7;}}
//line 748
___nl__4 = ___nl__3.clone();
//line 749
if (true) {goto label_6;}
//line 749
label_7:
//line 750
hash_NL.NL_set_value(ref ___nl__2,___nl__3,___nl__4);

//line 751
if (true) {goto label_6;}
//line 751
label_6:
//line 751
___nl__12 = null;
//line 752
if (true) {goto label_4;}
//line 752
label_5:
//line 753
___nl__12 = new ImmString("").clone();
//line 753
___nl__4 = ___nl__12.clone();
//line 753
___nl__12 = null;
//line 754
if (true) {goto label_4;}
//line 754
label_4:
//line 754
___nl__11 = null;
//line 755
___nl__11 = ___nl__10.clone();
//line 755
___nl__11 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("goto")).clone();
//line 755
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 755
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_9;}}
//line 756
___nl__12 = ___nl__10.clone();
//line 756
___nl__12 = c_rt_lib_NL.NL_ov_as(___nl__12, new ImmString("goto")).clone();
//line 756
___nl__3 = ___nl__12.clone();
//line 756
___nl__12 = null;
//line 757
hash_NL.NL_set_value(ref ___nl__1,___nl__3,___nl__3);

//line 758
if (true) {goto label_10;}
//line 758
label_9:
//line 758
___nl__11 = ___nl__10.clone();
//line 758
___nl__11 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("if_goto")).clone();
//line 758
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 758
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_10;}}
//line 759
___nl__12 = ___nl__10.clone();
//line 759
___nl__12 = c_rt_lib_NL.NL_ov_as(___nl__12, new ImmString("if_goto")).clone();
//line 759
___nl__3 = ___nl__12.clone();
//line 759
___nl__12 = null;
//line 760
___nl__12 = ((ImmHash)___nl__3).getHashValue()["dest"].clone();
//line 760
___nl__13 = ((ImmHash)___nl__3).getHashValue()["dest"].clone();
//line 760
hash_NL.NL_set_value(ref ___nl__1,___nl__12,___nl__13);

//line 760
___nl__13 = null;
//line 760
___nl__12 = null;
//line 761
if (true) {goto label_10;}
//line 761
label_10:
//line 761
___nl__11 = null;
//line 761
___nl__10 = null;
//line 762
___nl__6 = new ImmDouble((Double.Parse(___nl__6.getValue().ToString()))+(Double.Parse(___nl__7.getValue().ToString()))).clone();
//line 762
if (true) {goto label_3;}
//line 762
label_1:
//line 762
___nl__5 = null;
//line 762
___nl__6 = null;
//line 762
___nl__7 = null;
//line 762
___nl__8 = null;
//line 762
___nl__9 = null;
//line 763
___nl__7 = c_rt_lib_NL.NL_init_iter(___nl__2).clone();

//line 763
label_13:
//line 763
___nl__5 = c_rt_lib_NL.NL_is_end_hash(___nl__7).clone();

//line 763
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_11;}}
//line 763
___nl__5 = c_rt_lib_NL.NL_get_key_iter(___nl__7).clone();

//line 763
___nl__6 = c_rt_lib_NL.NL_hash_get_value(___nl__2,___nl__5).clone();

//line 764
___nl__8 = hash_NL.NL_has_key(___nl__1,___nl__5).clone();

//line 764
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 764
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_15;}}
//line 765
hash_NL.NL_set_value(ref ___nl__1,___nl__6,___nl__6);

//line 766
if (true) {goto label_15;}
//line 766
label_15:
//line 766
___nl__8 = null;
//line 767
___nl__7 = c_rt_lib_NL.NL_next_iter(___nl__7).clone();

//line 767
if (true) {goto label_13;}
//line 767
label_11:
//line 767
___nl__5 = null;
//line 767
___nl__6 = null;
//line 767
___nl__7 = null;
//line 768
___nl__5 = new ImmArray(new Imm[0]).clone();
//line 769
___nl__7 = new ImmDouble(0).clone();
//line 769
___nl__8 = new ImmDouble(1).clone();
//line 769
___nl__9 = c_rt_lib_NL.NL_array_len(___nl__0).clone();

//line 769
label_18:
//line 769
___nl__10 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))>=(Double.Parse(___nl__9.getValue().ToString())) ).clone();
//line 769
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_16;}}
//line 769
___nl__6 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()].clone();
//line 770
___nl__11 = ((ImmHash)___nl__6).getHashValue()["cmd"].clone();
//line 771
___nl__12 = ___nl__11.clone();
//line 771
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__12, new ImmString("prt_lbl")).clone();
//line 771
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 771
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_20;}}
//line 772
___nl__13 = ___nl__11.clone();
//line 772
___nl__13 = c_rt_lib_NL.NL_ov_as(___nl__13, new ImmString("prt_lbl")).clone();
//line 772
___nl__3 = ___nl__13.clone();
//line 772
___nl__13 = null;
//line 773
___nl__13 = hash_NL.NL_has_key(___nl__2,___nl__3).clone();

//line 773
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13)).clone();
//line 773
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_22;}}
//line 773
___nl__11 = null;
//line 773
___nl__12 = null;
//line 773
___nl__13 = null;
//line 773
if (true) {goto label_17;}
//line 773
if (true) {goto label_22;}
//line 773
label_22:
//line 773
___nl__13 = null;
//line 774
___nl__13 = hash_NL.NL_has_key(___nl__1,___nl__3).clone();

//line 774
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13)).clone();
//line 774
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13)).clone();
//line 774
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_24;}}
//line 774
___nl__11 = null;
//line 774
___nl__12 = null;
//line 774
___nl__13 = null;
//line 774
if (true) {goto label_17;}
//line 774
if (true) {goto label_24;}
//line 774
label_24:
//line 774
___nl__13 = null;
//line 775
if (true) {goto label_28;}
//line 775
label_20:
//line 775
___nl__12 = ___nl__11.clone();
//line 775
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__12, new ImmString("goto")).clone();
//line 775
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 775
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_25;}}
//line 776
___nl__13 = ___nl__11.clone();
//line 776
___nl__13 = c_rt_lib_NL.NL_ov_as(___nl__13, new ImmString("goto")).clone();
//line 776
___nl__3 = ___nl__13.clone();
//line 776
___nl__13 = null;
//line 777
___nl__13 = hash_NL.NL_has_key(___nl__2,___nl__3).clone();

//line 777
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13)).clone();
//line 777
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_27;}}
//line 777
___nl__14 = hash_NL.NL_get_value(___nl__2,___nl__3).clone();

//line 777
___nl__3 = ___nl__14.clone();
//line 777
___nl__14 = null;
//line 777
if (true) {goto label_27;}
//line 777
label_27:
//line 777
___nl__13 = null;
//line 778
___nl__13 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("goto"), ___nl__3).clone();
//line 778
___nl__11 = ___nl__13.clone();
//line 778
___nl__13 = null;
//line 779
if (true) {goto label_28;}
//line 779
label_25:
//line 779
___nl__12 = ___nl__11.clone();
//line 779
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__12, new ImmString("if_goto")).clone();
//line 779
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 779
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_28;}}
//line 780
___nl__13 = ___nl__11.clone();
//line 780
___nl__13 = c_rt_lib_NL.NL_ov_as(___nl__13, new ImmString("if_goto")).clone();
//line 780
___nl__3 = ___nl__13.clone();
//line 780
___nl__13 = null;
//line 781
___nl__14 = ((ImmHash)___nl__3).getHashValue()["dest"].clone();
//line 781
___nl__13 = hash_NL.NL_has_key(___nl__2,___nl__14).clone();

//line 781
___nl__14 = null;
//line 781
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13)).clone();
//line 781
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_30;}}
//line 781
___nl__15 = ((ImmHash)___nl__3).getHashValue()["dest"].clone();
//line 781
___nl__14 = hash_NL.NL_get_value(___nl__2,___nl__15).clone();

//line 781
___nl__15 = null;
//line 781
___nl__15 = ___nl__14.clone();
//line 781
((ImmHash)___nl__3).set("dest", ___nl__15);
//line 781
___nl__14 = null;
//line 781
___nl__15 = null;
//line 781
if (true) {goto label_30;}
//line 781
label_30:
//line 781
___nl__13 = null;
//line 782
___nl__13 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("if_goto"), ___nl__3).clone();
//line 782
___nl__11 = ___nl__13.clone();
//line 782
___nl__13 = null;
//line 783
if (true) {goto label_28;}
//line 783
label_28:
//line 783
___nl__12 = null;
//line 784
___nl__12 = ___nl__6.clone();
//line 785
___nl__13 = ___nl__11.clone();
//line 785
((ImmHash)___nl__12).set("cmd", ___nl__13);
//line 785
___nl__13 = null;
//line 786
array_NL.NL_push(ref ___nl__5,___nl__12);

//line 786
___nl__11 = null;
//line 786
___nl__12 = null;
//line 786
label_17:
//line 787
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString()))).clone();
//line 787
if (true) {goto label_18;}
//line 787
label_16:
//line 787
___nl__6 = null;
//line 787
___nl__7 = null;
//line 787
___nl__8 = null;
//line 787
___nl__9 = null;
//line 787
___nl__10 = null;
//line 788
___nl__0 = ___nl__5.clone();
//line 788
___nl__1 = null;
//line 788
___nl__2 = null;
//line 788
___nl__3 = null;
//line 788
___nl__4 = null;
//line 788
___nl__5 = null;
//line 788
___arg__0 = ___nl__0;if(true) return null;
}

}
}