using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class interpreter_NL {

public static Imm NL_SINGLETON_stack_element_t() {

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
//line 20
___nl__2 = ptd_NL.NL_sim();

//line 20
___nl__3 = ptd_NL.NL_sim();

//line 20
___nl__4 = ptd_NL.NL_sim();

//line 20
___nl__6 = ptd_NL.NL_ptd_im();

//line 20
___nl__5 = ptd_NL.NL_arr(___nl__6);

//line 20
___nl__6 = null;
//line 20
___nl__6 = ptd_NL.NL_sim();

//line 20
___nl__8 = ptd_NL.NL_sim();

//line 20
___nl__7 = ptd_NL.NL_hash(___nl__8);

//line 20
___nl__8 = null;
//line 20
___nl__9 = ptd_NL.NL_sim();

//line 20
___nl__8 = ptd_NL.NL_hash(___nl__9);

//line 20
___nl__9 = null;
//line 20
__function_map = new Dictionary<String, Imm>();
__function_map.Add("func_key",___nl__2);
__function_map.Add("module_name",___nl__3);
__function_map.Add("next",___nl__4);
__function_map.Add("vars",___nl__5);
__function_map.Add("ret",___nl__6);
__function_map.Add("code_vars",___nl__7);
__function_map.Add("ref_arguments",___nl__8);
___nl__1 = new ImmHash(__function_map);
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
___nl__0 = ptd_NL.NL_rec(___nl__1);

//line 20
___nl__1 = null;
//line 20
if(true) return ___nl__0;
//line 20
___nl__0 = null;
//line 20
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_stack_element_t = null;
public static Imm NL_stack_element_t() {
	if (value__singleton__NL_SINGLETON_stack_element_t == null) {
		value__singleton__NL_SINGLETON_stack_element_t = NL_SINGLETON_stack_element_t();
	}
	return value__singleton__NL_SINGLETON_stack_element_t;
}
public static Imm NL_SINGLETON_module_labels_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 32
___nl__2 = ptd_NL.NL_sim();

//line 32
___nl__1 = ptd_NL.NL_hash(___nl__2);

//line 32
___nl__2 = null;
//line 32
___nl__0 = ptd_NL.NL_hash(___nl__1);

//line 32
___nl__1 = null;
//line 32
if(true) return ___nl__0;
//line 32
___nl__0 = null;
//line 32
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_module_labels_t = null;
public static Imm NL_module_labels_t() {
	if (value__singleton__NL_SINGLETON_module_labels_t == null) {
		value__singleton__NL_SINGLETON_module_labels_t = NL_SINGLETON_module_labels_t();
	}
	return value__singleton__NL_SINGLETON_module_labels_t;
}
public static Imm NL_SINGLETON_known_exec_func_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
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
//line 36
___nl__2 = ptd_NL.NL_ptd_im();

//line 36
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("ptd_NL"));
__function_map.Add("name",new ImmString("meta_type"));
___nl__4 = new ImmHash(__function_map);
//line 36
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__4);
//line 36
___nl__3 = ptd_NL.NL_arr(___nl__4);

//line 36
___nl__4 = null;
//line 36
___nl__6 = ptd_NL.NL_none();

//line 36
___nl__7 = ptd_NL.NL_none();

//line 36
__function_map = new Dictionary<String, Imm>();
__function_map.Add("callback",___nl__6);
__function_map.Add("sequential",___nl__7);
___nl__5 = new ImmHash(__function_map);
//line 36
___nl__6 = null;
//line 36
___nl__7 = null;
//line 36
___nl__4 = ptd_NL.NL_var(___nl__5);

//line 36
___nl__5 = null;
//line 36
__function_map = new Dictionary<String, Imm>();
__function_map.Add("func",___nl__2);
__function_map.Add("args",___nl__3);
__function_map.Add("type",___nl__4);
___nl__1 = new ImmHash(__function_map);
//line 36
___nl__2 = null;
//line 36
___nl__3 = null;
//line 36
___nl__4 = null;
//line 36
___nl__0 = ptd_NL.NL_rec(___nl__1);

//line 36
___nl__1 = null;
//line 36
if(true) return ___nl__0;
//line 36
___nl__0 = null;
//line 36
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_known_exec_func_t = null;
public static Imm NL_known_exec_func_t() {
	if (value__singleton__NL_SINGLETON_known_exec_func_t == null) {
		value__singleton__NL_SINGLETON_known_exec_func_t = NL_SINGLETON_known_exec_func_t();
	}
	return value__singleton__NL_SINGLETON_known_exec_func_t;
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
//line 46
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("interpreter_NL"));
__function_map.Add("name",new ImmString("rstate_t"));
___nl__2 = new ImmHash(__function_map);
//line 46
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2);
//line 46
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("function_t"));
___nl__3 = new ImmHash(__function_map);
//line 46
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3);
//line 46
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("interpreter_NL"));
__function_map.Add("name",new ImmString("module_labels_t"));
___nl__5 = new ImmHash(__function_map);
//line 46
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__5);
//line 46
___nl__4 = ptd_NL.NL_hash(___nl__5);

//line 46
___nl__5 = null;
//line 46
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("function_t"));
___nl__6 = new ImmHash(__function_map);
//line 46
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__6);
//line 46
___nl__5 = ptd_NL.NL_hash(___nl__6);

//line 46
___nl__6 = null;
//line 46
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("interpreter_NL"));
__function_map.Add("name",new ImmString("stack_element_t"));
___nl__7 = new ImmHash(__function_map);
//line 46
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__7);
//line 46
___nl__6 = ptd_NL.NL_arr(___nl__7);

//line 46
___nl__7 = null;
//line 46
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("interpreter_NL"));
__function_map.Add("name",new ImmString("stack_element_t"));
___nl__7 = new ImmHash(__function_map);
//line 46
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__7);
//line 46
___nl__8 = ptd_NL.NL_sim();

//line 46
___nl__9 = ptd_NL.NL_sim();

//line 46
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("boolean_t_NL"));
__function_map.Add("name",new ImmString("type"));
___nl__10 = new ImmHash(__function_map);
//line 46
___nl__10 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__10);
//line 46
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("interpreter_NL"));
__function_map.Add("name",new ImmString("known_exec_func_t"));
___nl__12 = new ImmHash(__function_map);
//line 46
___nl__12 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__12);
//line 46
___nl__11 = ptd_NL.NL_hash(___nl__12);

//line 46
___nl__12 = null;
//line 46
___nl__13 = ptd_NL.NL_sim();

//line 46
___nl__12 = ptd_NL.NL_hash(___nl__13);

//line 46
___nl__13 = null;
//line 46
__function_map = new Dictionary<String, Imm>();
__function_map.Add("rstate",___nl__2);
__function_map.Add("func",___nl__3);
__function_map.Add("labels",___nl__4);
__function_map.Add("functions",___nl__5);
__function_map.Add("stack",___nl__6);
__function_map.Add("top",___nl__7);
__function_map.Add("instruction_nr",___nl__8);
__function_map.Add("read_dest",___nl__9);
__function_map.Add("check_all_instructions",___nl__10);
__function_map.Add("known_exec_func",___nl__11);
__function_map.Add("compiler_functions",___nl__12);
___nl__1 = new ImmHash(__function_map);
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
___nl__7 = null;
//line 46
___nl__8 = null;
//line 46
___nl__9 = null;
//line 46
___nl__10 = null;
//line 46
___nl__11 = null;
//line 46
___nl__12 = null;
//line 46
___nl__0 = ptd_NL.NL_rec(___nl__1);

//line 46
___nl__1 = null;
//line 46
if(true) return ___nl__0;
//line 46
___nl__0 = null;
//line 46
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_state_t = null;
public static Imm NL_state_t() {
	if (value__singleton__NL_SINGLETON_state_t == null) {
		value__singleton__NL_SINGLETON_state_t = NL_SINGLETON_state_t();
	}
	return value__singleton__NL_SINGLETON_state_t;
}
public static Imm NL_SINGLETON_rstate_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
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
//line 62
___nl__2 = ptd_NL.NL_none();

//line 62
___nl__3 = ptd_NL.NL_sim();

//line 62
___nl__4 = ptd_NL.NL_sim();

//line 62
___nl__5 = ptd_NL.NL_ptd_im();

//line 62
__function_map = new Dictionary<String, Imm>();
__function_map.Add("running",___nl__2);
__function_map.Add("error",___nl__3);
__function_map.Add("callback",___nl__4);
__function_map.Add("finished",___nl__5);
___nl__1 = new ImmHash(__function_map);
//line 62
___nl__2 = null;
//line 62
___nl__3 = null;
//line 62
___nl__4 = null;
//line 62
___nl__5 = null;
//line 62
___nl__0 = ptd_NL.NL_var(___nl__1);

//line 62
___nl__1 = null;
//line 62
if(true) return ___nl__0;
//line 62
___nl__0 = null;
//line 62
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_rstate_t = null;
public static Imm NL_rstate_t() {
	if (value__singleton__NL_SINGLETON_rstate_t == null) {
		value__singleton__NL_SINGLETON_rstate_t = NL_SINGLETON_rstate_t();
	}
	return value__singleton__NL_SINGLETON_rstate_t;
}
public static Imm NL_SINGLETON_stack_element_debug_t() {

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
//line 71
___nl__5 = ptd_NL.NL_sim();

//line 71
___nl__6 = ptd_NL.NL_ptd_im();

//line 71
__function_map = new Dictionary<String, Imm>();
__function_map.Add("name",___nl__5);
__function_map.Add("value",___nl__6);
___nl__4 = new ImmHash(__function_map);
//line 71
___nl__5 = null;
//line 71
___nl__6 = null;
//line 71
___nl__3 = ptd_NL.NL_rec(___nl__4);

//line 71
___nl__4 = null;
//line 71
___nl__2 = ptd_NL.NL_arr(___nl__3);

//line 71
___nl__3 = null;
//line 71
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("debug_t"));
___nl__3 = new ImmHash(__function_map);
//line 71
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3);
//line 71
___nl__4 = ptd_NL.NL_sim();

//line 71
__function_map = new Dictionary<String, Imm>();
__function_map.Add("variables",___nl__2);
__function_map.Add("command_debug",___nl__3);
__function_map.Add("func_name",___nl__4);
___nl__1 = new ImmHash(__function_map);
//line 71
___nl__2 = null;
//line 71
___nl__3 = null;
//line 71
___nl__4 = null;
//line 71
___nl__0 = ptd_NL.NL_rec(___nl__1);

//line 71
___nl__1 = null;
//line 71
if(true) return ___nl__0;
//line 71
___nl__0 = null;
//line 71
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_stack_element_debug_t = null;
public static Imm NL_stack_element_debug_t() {
	if (value__singleton__NL_SINGLETON_stack_element_debug_t == null) {
		value__singleton__NL_SINGLETON_stack_element_debug_t = NL_SINGLETON_stack_element_debug_t();
	}
	return value__singleton__NL_SINGLETON_stack_element_debug_t;
}
private static Imm NL_build_state_priv(Imm ___arg__0, Imm ___arg__1) {
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
//line 84
___nl__3 = new ImmString("");
//line 84
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("finished"), ___nl__3);
//line 84
___nl__5 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none"));
//line 84
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("priv"));
//line 84
___nl__7 = new ImmDouble(0);
//line 84
___nl__8 = new ImmArray(new Imm[0]);
//line 84
___nl__9 = new ImmArray(new Imm[0]);
//line 84
___nl__10 = new ImmString("");
//line 84
__function_map = new Dictionary<String, Imm>();
__function_map.Add("annotation",___nl__5);
__function_map.Add("access",___nl__6);
__function_map.Add("reg_size",___nl__7);
__function_map.Add("args_type",___nl__8);
__function_map.Add("commands",___nl__9);
__function_map.Add("name",___nl__10);
___nl__4 = new ImmHash(__function_map);
//line 84
___nl__5 = null;
//line 84
___nl__6 = null;
//line 84
___nl__7 = null;
//line 84
___nl__8 = null;
//line 84
___nl__9 = null;
//line 84
___nl__10 = null;
//line 84
___nl__5 = interpreter_NL.NL_build_labels_priv(___nl__0);

//line 84
___nl__6 = interpreter_NL.NL_build_functions_priv(___nl__0);

//line 84
___nl__7 = new ImmArray(new Imm[0]);
//line 84
___nl__9 = new ImmString("");
//line 84
___nl__10 = new ImmString("");
//line 84
___nl__11 = new ImmDouble(0);
//line 84
___nl__12 = new ImmArray(new Imm[0]);
//line 84
___nl__13 = new ImmString("");
//line 84
__function_map = new Dictionary<String, Imm>();
___nl__14 = new ImmHash(__function_map);
//line 84
__function_map = new Dictionary<String, Imm>();
___nl__15 = new ImmHash(__function_map);
//line 84
__function_map = new Dictionary<String, Imm>();
__function_map.Add("func_key",___nl__9);
__function_map.Add("module_name",___nl__10);
__function_map.Add("next",___nl__11);
__function_map.Add("vars",___nl__12);
__function_map.Add("ret",___nl__13);
__function_map.Add("code_vars",___nl__14);
__function_map.Add("ref_arguments",___nl__15);
___nl__8 = new ImmHash(__function_map);
//line 84
___nl__9 = null;
//line 84
___nl__10 = null;
//line 84
___nl__11 = null;
//line 84
___nl__12 = null;
//line 84
___nl__13 = null;
//line 84
___nl__14 = null;
//line 84
___nl__15 = null;
//line 84
___nl__9 = new ImmDouble(1);
//line 84
___nl__9 = new ImmDouble(-((ImmDouble)___nl__9).getDoubleValue());
//line 84
___nl__10 = new ImmString("");
//line 84
___nl__11 = c_rt_lib_NL.NL_get_true();
//line 84
___nl__12 = interpreter_NL.NL_get_compiler_functions_priv();

//line 84
__function_map = new Dictionary<String, Imm>();
__function_map.Add("rstate",___nl__3);
__function_map.Add("func",___nl__4);
__function_map.Add("labels",___nl__5);
__function_map.Add("functions",___nl__6);
__function_map.Add("stack",___nl__7);
__function_map.Add("top",___nl__8);
__function_map.Add("instruction_nr",___nl__9);
__function_map.Add("read_dest",___nl__10);
__function_map.Add("check_all_instructions",___nl__11);
__function_map.Add("known_exec_func",___nl__1);
__function_map.Add("compiler_functions",___nl__12);
___nl__2 = new ImmHash(__function_map);
//line 84
___nl__3 = null;
//line 84
___nl__4 = null;
//line 84
___nl__5 = null;
//line 84
___nl__6 = null;
//line 84
___nl__7 = null;
//line 84
___nl__8 = null;
//line 84
___nl__9 = null;
//line 84
___nl__10 = null;
//line 84
___nl__11 = null;
//line 84
___nl__12 = null;
//line 84
___nl__0 = null;
//line 84
___nl__1 = null;
//line 84
if(true) return ___nl__2;
//line 84
___nl__2 = null;
//line 84
___nl__0 = null;
//line 84
___nl__1 = null;
//line 84
if(true) return null;
}

public static Imm NL_init(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();
Imm ___nl__2 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 108
___nl__2 = interpreter_NL.NL_build_state_priv(___nl__0,___nl__1);

//line 108
___nl__0 = null;
//line 108
___nl__1 = null;
//line 108
if(true) return ___nl__2;
//line 108
___nl__2 = null;
//line 108
___nl__0 = null;
//line 108
___nl__1 = null;
//line 108
if(true) return null;
}

public static Imm NL_start(ImmRef ___arg__0, Imm ___arg__1, Imm ___arg__2) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();
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
//line 113
___nl__3 = new ImmString("::");
//line 113
___nl__3 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 113
___nl__3 = new ImmString(___nl__3.toString() + ___nl__1.toString());
//line 114
___nl__5 = ((ImmHash)___nl__0).getHashValue()["functions"];
//line 114
___nl__4 = hash_NL.NL_has_key(___nl__5,___nl__3);

//line 114
___nl__5 = null;
//line 114
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 114
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 114
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 115
___nl__5 = new ImmString("brak funkcji ");
//line 115
___nl__5 = new ImmString(___nl__5.toString() + ___nl__3.toString());
//line 115
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("err"), ___nl__5);
//line 115
___nl__1 = null;
//line 115
___nl__2 = null;
//line 115
___nl__3 = null;
//line 115
___nl__4 = null;
//line 115
___arg__0.setValue(___nl__0);if(true) return ___nl__5;
//line 115
___nl__5 = null;
//line 116
if (true) {goto label_2;}
//line 116
label_2:
//line 116
___nl__4 = null;
//line 117
___nl__4 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("running"));
//line 117
___nl__5 = ___nl__4;
//line 117
((ImmHash)___nl__0).set("rstate", ___nl__5);
//line 117
___nl__4 = null;
//line 117
___nl__5 = null;
//line 118
___nl__5 = ((ImmHash)___nl__0).getHashValue()["functions"];
//line 118
___nl__4 = hash_NL.NL_get_value(___nl__5,___nl__3);

//line 118
___nl__5 = null;
//line 119
___nl__5 = ___nl__4;
//line 119
((ImmHash)___nl__0).set("func", ___nl__5);
//line 119
___nl__5 = null;
//line 120
___nl__5 = new ImmArray(new Imm[0]);
//line 120
___nl__6 = ___nl__5;
//line 120
((ImmHash)___nl__0).set("stack", ___nl__6);
//line 120
___nl__5 = null;
//line 120
___nl__6 = null;
//line 121
___nl__6 = new ImmDouble(0);
//line 121
___nl__8 = ((ImmHash)___nl__4).getHashValue()["reg_size"];
//line 121
___nl__7 = interpreter_NL.NL_build_registers_priv(___nl__8);

//line 121
___nl__8 = null;
//line 121
___nl__8 = new ImmString("");
//line 121
__function_map = new Dictionary<String, Imm>();
___nl__9 = new ImmHash(__function_map);
//line 121
__function_map = new Dictionary<String, Imm>();
___nl__10 = new ImmHash(__function_map);
//line 121
__function_map = new Dictionary<String, Imm>();
__function_map.Add("func_key",___nl__3);
__function_map.Add("module_name",___nl__2);
__function_map.Add("next",___nl__6);
__function_map.Add("vars",___nl__7);
__function_map.Add("ret",___nl__8);
__function_map.Add("code_vars",___nl__9);
__function_map.Add("ref_arguments",___nl__10);
___nl__5 = new ImmHash(__function_map);
//line 121
___nl__6 = null;
//line 121
___nl__7 = null;
//line 121
___nl__8 = null;
//line 121
___nl__9 = null;
//line 121
___nl__10 = null;
//line 121
___nl__6 = ___nl__5;
//line 121
((ImmHash)___nl__0).set("top", ___nl__6);
//line 121
___nl__5 = null;
//line 121
___nl__6 = null;
//line 130
___nl__5 = new ImmDouble(1);
//line 130
___nl__5 = new ImmDouble(-((ImmDouble)___nl__5).getDoubleValue());
//line 130
___nl__6 = ___nl__5;
//line 130
((ImmHash)___nl__0).set("instruction_nr", ___nl__6);
//line 130
___nl__5 = null;
//line 130
___nl__6 = null;
//line 131
___nl__5 = new ImmString("");
//line 131
___nl__6 = ___nl__5;
//line 131
((ImmHash)___nl__0).set("read_dest", ___nl__6);
//line 131
___nl__5 = null;
//line 131
___nl__6 = null;
//line 132
___ref______nl__0 = new ImmRef(___nl__0);
interpreter_NL.NL_handle_new_declarations_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 133
___nl__5 = new ImmString("");
//line 133
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__5);
//line 133
___nl__1 = null;
//line 133
___nl__2 = null;
//line 133
___nl__3 = null;
//line 133
___nl__4 = null;
//line 133
___arg__0.setValue(___nl__0);if(true) return ___nl__5;
//line 133
___nl__5 = null;
//line 133
___nl__3 = null;
//line 133
___nl__4 = null;
//line 133
___nl__1 = null;
//line 133
___nl__2 = null;
//line 133
___arg__0.setValue(___nl__0);if(true) return null;
}

public static Imm NL_exec_all_code(Imm ___arg__0) {
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
//line 136
___ref______nl__0 = new ImmRef(___nl__0);
interpreter_NL.NL_step_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 137
label_2:
//line 138
___nl__1 = ((ImmHash)___nl__0).getHashValue()["rstate"];
//line 138
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("error"));
//line 138
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_4;}}
//line 140
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("running"));
//line 140
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_5;}}
//line 142
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("callback"));
//line 142
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_6;}}
//line 145
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("finished"));
//line 145
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_7;}}
//line 145
___nl__2 = new ImmString("NOMATCHALERT");
//line 145
___nl__2 = new ImmArray(new Imm[] {___nl__2,___nl__1,});
//line 145
c_rt_lib_NL.NL_die();
//line 138
label_4:
//line 138
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__1, new ImmString("error"));
//line 139
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("err"), ___nl__3);
//line 139
___nl__0 = null;
//line 139
___nl__1 = null;
//line 139
___nl__2 = null;
//line 139
___nl__3 = null;
//line 139
if(true) return ___nl__4;
//line 139
___nl__4 = null;
//line 139
___nl__3 = null;
//line 140
if (true) {goto label_3;}
//line 140
label_5:
//line 141
___ref______nl__0 = new ImmRef(___nl__0);
interpreter_NL.NL_step_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 142
if (true) {goto label_3;}
//line 142
label_6:
//line 142
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__1, new ImmString("callback"));
//line 142
___nl__3 = null;
//line 145
if (true) {goto label_3;}
//line 145
label_7:
//line 145
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__1, new ImmString("finished"));
//line 146
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__3);
//line 146
___nl__0 = null;
//line 146
___nl__1 = null;
//line 146
___nl__2 = null;
//line 146
___nl__3 = null;
//line 146
if(true) return ___nl__4;
//line 146
___nl__4 = null;
//line 146
___nl__3 = null;
//line 147
if (true) {goto label_3;}
//line 147
label_3:
//line 147
___nl__1 = null;
//line 147
___nl__2 = null;
//line 137
if (true) {goto label_2;}
//line 149
___nl__1 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("err"));
//line 149
___nl__0 = null;
//line 149
if(true) return ___nl__1;
//line 149
___nl__1 = null;
//line 149
___nl__0 = null;
//line 149
if(true) return null;
}

public static Imm NL_evaluate_const(Imm ___arg__0, Imm ___arg__1, Imm ___arg__2, Imm ___arg__3, Imm ___arg__4) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();Imm ___nl__3 = ___arg__3.clone();Imm ___nl__4 = ___arg__4.clone();
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
//line 155
___nl__5 = interpreter_NL.NL_get_func_key_priv(___nl__1,___nl__2);

//line 156
___nl__7 = ((ImmHash)___nl__0).getHashValue()["functions"];
//line 156
___nl__6 = hash_NL.NL_has_key(___nl__7,___nl__5);

//line 156
___nl__7 = null;
//line 156
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 156
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 156
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_2;}}
//line 156
___nl__7 = new ImmArray(new Imm[0]);
//line 156
c_rt_lib_NL.NL_die();
//line 156
if (true) {goto label_2;}
//line 156
label_2:
//line 156
___nl__6 = null;
//line 156
___nl__7 = null;
//line 157
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("running"));
//line 157
___nl__7 = ___nl__6;
//line 157
((ImmHash)___nl__0).set("rstate", ___nl__7);
//line 157
___nl__6 = null;
//line 157
___nl__7 = null;
//line 158
___nl__7 = ((ImmHash)___nl__0).getHashValue()["functions"];
//line 158
___nl__6 = hash_NL.NL_get_value(___nl__7,___nl__5);

//line 158
___nl__7 = null;
//line 158
___nl__1 = ___nl__6;
//line 158
___nl__6 = null;
//line 159
___nl__6 = ___nl__1;
//line 159
((ImmHash)___nl__0).set("func", ___nl__6);
//line 159
___nl__6 = null;
//line 160
___nl__6 = new ImmArray(new Imm[0]);
//line 160
___nl__7 = ___nl__6;
//line 160
((ImmHash)___nl__0).set("stack", ___nl__7);
//line 160
___nl__6 = null;
//line 160
___nl__7 = null;
//line 161
___nl__7 = new ImmString("");
//line 161
__function_map = new Dictionary<String, Imm>();
___nl__8 = new ImmHash(__function_map);
//line 161
__function_map = new Dictionary<String, Imm>();
___nl__9 = new ImmHash(__function_map);
//line 161
__function_map = new Dictionary<String, Imm>();
__function_map.Add("func_key",___nl__5);
__function_map.Add("module_name",___nl__2);
__function_map.Add("next",___nl__4);
__function_map.Add("vars",___nl__3);
__function_map.Add("ret",___nl__7);
__function_map.Add("code_vars",___nl__8);
__function_map.Add("ref_arguments",___nl__9);
___nl__6 = new ImmHash(__function_map);
//line 161
___nl__7 = null;
//line 161
___nl__8 = null;
//line 161
___nl__9 = null;
//line 161
___nl__7 = ___nl__6;
//line 161
((ImmHash)___nl__0).set("top", ___nl__7);
//line 161
___nl__6 = null;
//line 161
___nl__7 = null;
//line 170
___nl__6 = new ImmDouble(1);
//line 170
___nl__6 = new ImmDouble(-((ImmDouble)___nl__6).getDoubleValue());
//line 170
___nl__7 = ___nl__6;
//line 170
((ImmHash)___nl__0).set("instruction_nr", ___nl__7);
//line 170
___nl__6 = null;
//line 170
___nl__7 = null;
//line 171
___nl__6 = new ImmString("");
//line 171
___nl__7 = ___nl__6;
//line 171
((ImmHash)___nl__0).set("read_dest", ___nl__7);
//line 171
___nl__6 = null;
//line 171
___nl__7 = null;
//line 172
___ref______nl__0 = new ImmRef(___nl__0);
interpreter_NL.NL_handle_new_declarations_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 173
___ref______nl__0 = new ImmRef(___nl__0);
interpreter_NL.NL_step_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 174
___nl__6 = new ImmDouble(1);
//line 175
label_4:
//line 175
___nl__9 = ((ImmHash)___nl__0).getHashValue()["stack"];
//line 175
___nl__7 = array_NL.NL_len(___nl__9);

//line 175
___nl__9 = null;
//line 175
___nl__9 = new ImmDouble(0);
//line 175
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString())) !=((Double.Parse(___nl__9.getValue().ToString())))  );
//line 175
___nl__9 = null;
//line 175
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 175
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_5;}}
//line 175
___nl__7 = ((ImmHash)___nl__0).getHashValue()["rstate"];
//line 175
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("running"));
//line 175
label_5:
//line 175
___nl__8 = null;
//line 175
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 175
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_3;}}
//line 176
___nl__8 = new ImmDouble(5000);
//line 176
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__6.getValue().ToString()))>(Double.Parse(___nl__8.getValue().ToString())) );
//line 176
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8));
//line 176
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_7;}}
//line 177
___nl__9 = new ImmString("steps limit exceeded");
//line 177
___nl__9 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("err"), ___nl__9);
//line 177
___nl__0 = null;
//line 177
___nl__1 = null;
//line 177
___nl__2 = null;
//line 177
___nl__3 = null;
//line 177
___nl__4 = null;
//line 177
___nl__5 = null;
//line 177
___nl__6 = null;
//line 177
___nl__7 = null;
//line 177
___nl__8 = null;
//line 177
if(true) return ___nl__9;
//line 177
___nl__9 = null;
//line 178
if (true) {goto label_7;}
//line 178
label_7:
//line 178
___nl__8 = null;
//line 179
___ref______nl__0 = new ImmRef(___nl__0);
interpreter_NL.NL_step_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 180
___nl__8 = new ImmDouble(1);
//line 180
___nl__6 = new ImmDouble((Double.Parse(___nl__6.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString())));
//line 180
___nl__8 = null;
//line 181
if (true) {goto label_4;}
//line 181
label_3:
//line 181
___nl__7 = null;
//line 182
___nl__7 = ((ImmHash)___nl__0).getHashValue()["rstate"];
//line 182
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("error"));
//line 182
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 182
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_9;}}
//line 183
___nl__8 = ((ImmHash)___nl__0).getHashValue()["rstate"];
//line 183
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__8, new ImmString("error"));
//line 183
___nl__8 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("err"), ___nl__8);
//line 183
___nl__0 = null;
//line 183
___nl__1 = null;
//line 183
___nl__2 = null;
//line 183
___nl__3 = null;
//line 183
___nl__4 = null;
//line 183
___nl__5 = null;
//line 183
___nl__6 = null;
//line 183
___nl__7 = null;
//line 183
if(true) return ___nl__8;
//line 183
___nl__8 = null;
//line 184
if (true) {goto label_8;}
//line 184
label_9:
//line 185
___nl__8 = ((ImmHash)___nl__0).getHashValue()["top"];
//line 185
___nl__8 = ((ImmHash)___nl__8).getHashValue()["vars"];
//line 185
___nl__8 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__8);
//line 185
___nl__0 = null;
//line 185
___nl__1 = null;
//line 185
___nl__2 = null;
//line 185
___nl__3 = null;
//line 185
___nl__4 = null;
//line 185
___nl__5 = null;
//line 185
___nl__6 = null;
//line 185
___nl__7 = null;
//line 185
if(true) return ___nl__8;
//line 185
___nl__8 = null;
//line 186
if (true) {goto label_8;}
//line 186
label_8:
//line 186
___nl__7 = null;
//line 186
___nl__5 = null;
//line 186
___nl__6 = null;
//line 186
___nl__0 = null;
//line 186
___nl__1 = null;
//line 186
___nl__2 = null;
//line 186
___nl__3 = null;
//line 186
___nl__4 = null;
//line 186
if(true) return null;
}

public static Imm NL_SINGLETON_get_none_variant() {

Imm ___nl__0 = null;
ImmRef ___ref______nl__0 = null;
Dictionary<String, Imm> __function_map;
//line 190
___nl__0 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none_variant_do_not_use"));
//line 190
if(true) return ___nl__0;
//line 190
___nl__0 = null;
//line 190
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_get_none_variant = null;
public static Imm NL_get_none_variant() {
	if (value__singleton__NL_SINGLETON_get_none_variant == null) {
		value__singleton__NL_SINGLETON_get_none_variant = NL_SINGLETON_get_none_variant();
	}
	return value__singleton__NL_SINGLETON_get_none_variant;
}
private static Imm NL_build_registers_priv(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
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
//line 194
___nl__1 = new ImmArray(new Imm[0]);
//line 195
___nl__2 = new ImmDouble(0);
//line 195
___nl__3 = new ImmDouble(1);
//line 195
label_3:
//line 195
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__2.getValue().ToString()))>=(Double.Parse(___nl__0.getValue().ToString())) );
//line 195
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_1;}}
//line 195
___nl__5 = interpreter_NL.NL_get_none_variant();

//line 195
___ref______nl__1 = new ImmRef(___nl__1);
array_NL.NL_push(___ref______nl__1,___nl__5);
___nl__1 = ___ref______nl__1.getValue();

//line 195
___nl__5 = null;
//line 195
___nl__2 = new ImmDouble((Double.Parse(___nl__2.getValue().ToString()))+(Double.Parse(___nl__3.getValue().ToString())));
//line 195
if (true) {goto label_3;}
//line 195
label_1:
//line 195
___nl__2 = null;
//line 195
___nl__3 = null;
//line 195
___nl__4 = null;
//line 196
___nl__0 = null;
//line 196
if(true) return ___nl__1;
//line 196
___nl__1 = null;
//line 196
___nl__0 = null;
//line 196
if(true) return null;
}

private static Imm NL_build_labels_priv(Imm ___arg__0) {
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
Imm ___nl__22 = null;
Imm ___nl__23 = null;
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
Dictionary<String, Imm> __function_map;
//line 200
__function_map = new Dictionary<String, Imm>();
___nl__1 = new ImmHash(__function_map);
//line 201
___nl__3 = new ImmDouble(0);
//line 201
___nl__4 = new ImmDouble(1);
//line 201
___nl__5 = c_rt_lib_NL.NL_array_len(___nl__0);

//line 201
label_3:
//line 201
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))>=(Double.Parse(___nl__5.getValue().ToString())) );
//line 201
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_1;}}
//line 201
___nl__2 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__3).getDoubleValue()];
//line 202
___nl__7 = ((ImmHash)___nl__2).getHashValue()["module_name"];
//line 203
__function_map = new Dictionary<String, Imm>();
___nl__8 = new ImmHash(__function_map);
//line 204
___nl__9 = ((ImmHash)___nl__2).getHashValue()["functions"];
//line 204
___nl__11 = new ImmDouble(0);
//line 204
___nl__12 = new ImmDouble(1);
//line 204
___nl__13 = c_rt_lib_NL.NL_array_len(___nl__9);

//line 204
label_6:
//line 204
___nl__14 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__11.getValue().ToString()))>=(Double.Parse(___nl__13.getValue().ToString())) );
//line 204
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_4;}}
//line 204
___nl__10 = (___nl__9 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__11).getDoubleValue()];
//line 205
___nl__15 = interpreter_NL.NL_get_func_key_priv(___nl__10,___nl__7);

//line 206
__function_map = new Dictionary<String, Imm>();
___nl__16 = new ImmHash(__function_map);
//line 207
___nl__18 = ((ImmHash)___nl__10).getHashValue()["commands"];
//line 207
___nl__17 = array_NL.NL_len(___nl__18);

//line 207
___nl__18 = null;
//line 207
___nl__18 = new ImmDouble(0);
//line 207
___nl__19 = new ImmDouble(1);
//line 207
label_9:
//line 207
___nl__20 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__18.getValue().ToString()))>=(Double.Parse(___nl__17.getValue().ToString())) );
//line 207
if (c_rt_lib_NL.NL_check_true_native(___nl__20)) {if (true) {goto label_7;}}
//line 208
___nl__21 = ((ImmHash)___nl__10).getHashValue()["commands"];
//line 208
___nl__21 = (___nl__21 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__18).getDoubleValue()];
//line 208
___nl__21 = ((ImmHash)___nl__21).getHashValue()["cmd"];
//line 209
___nl__22 = ___nl__21;
//line 209
___nl__22 = c_rt_lib_NL.NL_ov_is(___nl__22, new ImmString("prt_lbl"));
//line 209
___nl__22 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__22));
//line 209
if (c_rt_lib_NL.NL_check_true_native(___nl__22)) {if (true) {goto label_11;}}
//line 210
___nl__23 = ___nl__21;
//line 210
___nl__23 = c_rt_lib_NL.NL_ov_as(___nl__23, new ImmString("prt_lbl"));
//line 211
___ref______nl__16 = new ImmRef(___nl__16);
hash_NL.NL_set_value(___ref______nl__16,___nl__23,___nl__18);
___nl__16 = ___ref______nl__16.getValue();

//line 211
___nl__23 = null;
//line 212
if (true) {goto label_11;}
//line 212
label_11:
//line 212
___nl__22 = null;
//line 212
___nl__21 = null;
//line 213
___nl__18 = new ImmDouble((Double.Parse(___nl__18.getValue().ToString()))+(Double.Parse(___nl__19.getValue().ToString())));
//line 213
if (true) {goto label_9;}
//line 213
label_7:
//line 213
___nl__17 = null;
//line 213
___nl__18 = null;
//line 213
___nl__19 = null;
//line 213
___nl__20 = null;
//line 214
___ref______nl__8 = new ImmRef(___nl__8);
hash_NL.NL_set_value(___ref______nl__8,___nl__15,___nl__16);
___nl__8 = ___ref______nl__8.getValue();

//line 214
___nl__15 = null;
//line 214
___nl__16 = null;
//line 215
___nl__11 = new ImmDouble((Double.Parse(___nl__11.getValue().ToString()))+(Double.Parse(___nl__12.getValue().ToString())));
//line 215
if (true) {goto label_6;}
//line 215
label_4:
//line 215
___nl__9 = null;
//line 215
___nl__10 = null;
//line 215
___nl__11 = null;
//line 215
___nl__12 = null;
//line 215
___nl__13 = null;
//line 215
___nl__14 = null;
//line 216
___nl__9 = ((ImmHash)___nl__2).getHashValue()["module_name"];
//line 216
___ref______nl__1 = new ImmRef(___nl__1);
hash_NL.NL_set_value(___ref______nl__1,___nl__9,___nl__8);
___nl__1 = ___ref______nl__1.getValue();

//line 216
___nl__9 = null;
//line 216
___nl__7 = null;
//line 216
___nl__8 = null;
//line 217
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString())));
//line 217
if (true) {goto label_3;}
//line 217
label_1:
//line 217
___nl__2 = null;
//line 217
___nl__3 = null;
//line 217
___nl__4 = null;
//line 217
___nl__5 = null;
//line 217
___nl__6 = null;
//line 218
___nl__0 = null;
//line 218
if(true) return ___nl__1;
//line 218
___nl__1 = null;
//line 218
___nl__0 = null;
//line 218
if(true) return null;
}

private static Imm NL_build_functions_priv(Imm ___arg__0) {
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
//line 222
__function_map = new Dictionary<String, Imm>();
___nl__1 = new ImmHash(__function_map);
//line 223
___nl__3 = new ImmDouble(0);
//line 223
___nl__4 = new ImmDouble(1);
//line 223
___nl__5 = c_rt_lib_NL.NL_array_len(___nl__0);

//line 223
label_3:
//line 223
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))>=(Double.Parse(___nl__5.getValue().ToString())) );
//line 223
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_1;}}
//line 223
___nl__2 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__3).getDoubleValue()];
//line 224
___nl__7 = ((ImmHash)___nl__2).getHashValue()["module_name"];
//line 225
___nl__8 = ((ImmHash)___nl__2).getHashValue()["functions"];
//line 225
___nl__10 = new ImmDouble(0);
//line 225
___nl__11 = new ImmDouble(1);
//line 225
___nl__12 = c_rt_lib_NL.NL_array_len(___nl__8);

//line 225
label_6:
//line 225
___nl__13 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__10.getValue().ToString()))>=(Double.Parse(___nl__12.getValue().ToString())) );
//line 225
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_4;}}
//line 225
___nl__9 = (___nl__8 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()];
//line 226
___nl__14 = interpreter_NL.NL_get_func_key_priv(___nl__9,___nl__7);

//line 227
___ref______nl__1 = new ImmRef(___nl__1);
hash_NL.NL_set_value(___ref______nl__1,___nl__14,___nl__9);
___nl__1 = ___ref______nl__1.getValue();

//line 227
___nl__14 = null;
//line 228
___nl__10 = new ImmDouble((Double.Parse(___nl__10.getValue().ToString()))+(Double.Parse(___nl__11.getValue().ToString())));
//line 228
if (true) {goto label_6;}
//line 228
label_4:
//line 228
___nl__8 = null;
//line 228
___nl__9 = null;
//line 228
___nl__10 = null;
//line 228
___nl__11 = null;
//line 228
___nl__12 = null;
//line 228
___nl__13 = null;
//line 228
___nl__7 = null;
//line 229
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString())));
//line 229
if (true) {goto label_3;}
//line 229
label_1:
//line 229
___nl__2 = null;
//line 229
___nl__3 = null;
//line 229
___nl__4 = null;
//line 229
___nl__5 = null;
//line 229
___nl__6 = null;
//line 230
___nl__0 = null;
//line 230
if(true) return ___nl__1;
//line 230
___nl__1 = null;
//line 230
___nl__0 = null;
//line 230
if(true) return null;
}

private static Imm NL_get_stack_element_debug_priv(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();
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
//line 234
___nl__3 = ((ImmHash)___nl__1).getHashValue()["functions"];
//line 234
___nl__4 = ((ImmHash)___nl__0).getHashValue()["func_key"];
//line 234
___nl__2 = hash_NL.NL_get_value(___nl__3,___nl__4);

//line 234
___nl__4 = null;
//line 234
___nl__3 = null;
//line 235
___nl__4 = interpreter_NL.NL_get_variables_priv(___nl__0);

//line 235
___nl__5 = ((ImmHash)___nl__2).getHashValue()["commands"];
//line 235
___nl__6 = ((ImmHash)___nl__0).getHashValue()["next"];
//line 235
___nl__5 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()];
//line 235
___nl__6 = null;
//line 235
___nl__5 = ((ImmHash)___nl__5).getHashValue()["debug"];
//line 235
___nl__5 = ((ImmHash)___nl__5).getHashValue()["nast_debug"];
//line 235
___nl__6 = ((ImmHash)___nl__2).getHashValue()["name"];
//line 235
__function_map = new Dictionary<String, Imm>();
__function_map.Add("variables",___nl__4);
__function_map.Add("command_debug",___nl__5);
__function_map.Add("func_name",___nl__6);
___nl__3 = new ImmHash(__function_map);
//line 235
___nl__4 = null;
//line 235
___nl__5 = null;
//line 235
___nl__6 = null;
//line 235
___nl__0 = null;
//line 235
___nl__1 = null;
//line 235
___nl__2 = null;
//line 235
if(true) return ___nl__3;
//line 235
___nl__3 = null;
//line 235
___nl__2 = null;
//line 235
___nl__0 = null;
//line 235
___nl__1 = null;
//line 235
if(true) return null;
}

public static Imm NL_get_whole_stack_debug(Imm ___arg__0) {
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
//line 243
___nl__1 = new ImmArray(new Imm[0]);
//line 244
___nl__2 = ((ImmHash)___nl__0).getHashValue()["rstate"];
//line 244
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("finished"));
//line 244
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 244
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 244
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 244
___nl__4 = ((ImmHash)___nl__0).getHashValue()["top"];
//line 244
___nl__3 = interpreter_NL.NL_get_stack_element_debug_priv(___nl__4,___nl__0);

//line 244
___nl__4 = null;
//line 244
___ref______nl__1 = new ImmRef(___nl__1);
array_NL.NL_push(___ref______nl__1,___nl__3);
___nl__1 = ___ref______nl__1.getValue();

//line 244
___nl__3 = null;
//line 244
if (true) {goto label_2;}
//line 244
label_2:
//line 244
___nl__2 = null;
//line 245
___nl__3 = ((ImmHash)___nl__0).getHashValue()["stack"];
//line 245
___nl__2 = array_NL.NL_len(___nl__3);

//line 245
___nl__3 = null;
//line 246
___nl__3 = new ImmDouble(0);
//line 246
___nl__4 = new ImmDouble(1);
//line 246
label_5:
//line 246
___nl__5 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))>=(Double.Parse(___nl__2.getValue().ToString())) );
//line 246
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_3;}}
//line 247
___nl__7 = ((ImmHash)___nl__0).getHashValue()["stack"];
//line 247
___nl__8 = new ImmDouble((Double.Parse(___nl__2.getValue().ToString()))-(Double.Parse(___nl__3.getValue().ToString())));
//line 247
___nl__9 = new ImmDouble(1);
//line 247
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))-(Double.Parse(___nl__9.getValue().ToString())));
//line 247
___nl__9 = null;
//line 247
___nl__7 = (___nl__7 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 247
___nl__8 = null;
//line 247
___nl__6 = interpreter_NL.NL_get_stack_element_debug_priv(___nl__7,___nl__0);

//line 247
___nl__7 = null;
//line 247
___ref______nl__1 = new ImmRef(___nl__1);
array_NL.NL_push(___ref______nl__1,___nl__6);
___nl__1 = ___ref______nl__1.getValue();

//line 247
___nl__6 = null;
//line 248
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString())));
//line 248
if (true) {goto label_5;}
//line 248
label_3:
//line 248
___nl__3 = null;
//line 248
___nl__4 = null;
//line 248
___nl__5 = null;
//line 249
___nl__0 = null;
//line 249
___nl__2 = null;
//line 249
if(true) return ___nl__1;
//line 249
___nl__1 = null;
//line 249
___nl__2 = null;
//line 249
___nl__0 = null;
//line 249
if(true) return null;
}

public static Imm NL_has_next_instruction(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 253
___nl__1 = ((ImmHash)___nl__0).getHashValue()["top"];
//line 253
___nl__1 = ((ImmHash)___nl__1).getHashValue()["next"];
//line 253
___nl__3 = ((ImmHash)___nl__0).getHashValue()["func"];
//line 253
___nl__3 = ((ImmHash)___nl__3).getHashValue()["commands"];
//line 253
___nl__2 = array_NL.NL_len(___nl__3);

//line 253
___nl__3 = null;
//line 253
___nl__1 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__1.getValue().ToString()))<(Double.Parse(___nl__2.getValue().ToString())) );
//line 253
___nl__2 = null;
//line 253
___nl__0 = null;
//line 253
if(true) return ___nl__1;
//line 253
___nl__1 = null;
//line 253
___nl__0 = null;
//line 253
if(true) return null;
}

private static Imm NL_get_variables_priv(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
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
//line 258
___nl__1 = new ImmArray(new Imm[0]);
//line 259
___nl__2 = ((ImmHash)___nl__0).getHashValue()["code_vars"];
//line 259
___nl__5 = c_rt_lib_NL.NL_init_iter(___nl__2);

//line 259
label_3:
//line 259
___nl__3 = c_rt_lib_NL.NL_is_end_hash(___nl__5);

//line 259
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_1;}}
//line 259
___nl__3 = c_rt_lib_NL.NL_get_key_iter(___nl__5);

//line 259
___nl__4 = c_rt_lib_NL.NL_hash_get_value(___nl__2,___nl__3);

//line 260
___nl__6 = ((ImmHash)___nl__0).getHashValue()["vars"];
//line 260
___nl__6 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()];
//line 261
__function_map = new Dictionary<String, Imm>();
__function_map.Add("name",___nl__3);
__function_map.Add("value",___nl__6);
___nl__7 = new ImmHash(__function_map);
//line 261
___ref______nl__1 = new ImmRef(___nl__1);
array_NL.NL_push(___ref______nl__1,___nl__7);
___nl__1 = ___ref______nl__1.getValue();

//line 261
___nl__7 = null;
//line 261
___nl__6 = null;
//line 262
___nl__5 = c_rt_lib_NL.NL_next_iter(___nl__5);

//line 262
if (true) {goto label_3;}
//line 262
label_1:
//line 262
___nl__2 = null;
//line 262
___nl__3 = null;
//line 262
___nl__4 = null;
//line 262
___nl__5 = null;
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

private static Imm NL_get_instruction_nr_priv(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 267
___nl__1 = interpreter_NL.NL_get_command_priv(___nl__0);

//line 267
___nl__1 = ((ImmHash)___nl__1).getHashValue()["debug"];
//line 267
___nl__1 = ((ImmHash)___nl__1).getHashValue()["instruction_nr"];
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

private static Imm NL_is_hidden_priv(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 271
___nl__1 = ((ImmHash)___nl__0).getHashValue()["cmd"];
//line 271
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("prt_lbl"));
//line 271
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_1;}}
//line 271
___nl__1 = ((ImmHash)___nl__0).getHashValue()["cmd"];
//line 271
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("clear"));
//line 271
label_1:
//line 271
___nl__0 = null;
//line 271
if(true) return ___nl__1;
//line 271
___nl__1 = null;
//line 271
___nl__0 = null;
//line 271
if(true) return null;
}

public static Imm NL_execute_full_instruction(ImmRef ___arg__0) {
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
//line 275
___nl__1 = ((ImmHash)___nl__0).getHashValue()["rstate"];
//line 275
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("running"));
//line 275
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1));
//line 275
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1));
//line 275
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_2;}}
//line 275
___nl__1 = null;
//line 275
___arg__0.setValue(___nl__0);if(true) return null;
//line 275
if (true) {goto label_2;}
//line 275
label_2:
//line 275
___nl__1 = null;
//line 276
___nl__1 = interpreter_NL.NL_get_instruction_nr_priv(___nl__0);

//line 276
___nl__2 = ___nl__1;
//line 276
((ImmHash)___nl__0).set("instruction_nr", ___nl__2);
//line 276
___nl__1 = null;
//line 276
___nl__2 = null;
//line 277
label_4:
//line 278
___nl__1 = interpreter_NL.NL_get_command_priv(___nl__0);

//line 279
___nl__2 = interpreter_NL.NL_is_hidden_priv(___nl__1);

//line 279
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 279
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 279
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_6;}}
//line 280
___nl__3 = ((ImmHash)___nl__0).getHashValue()["instruction_nr"];
//line 280
___nl__4 = ((ImmHash)___nl__1).getHashValue()["debug"];
//line 280
___nl__4 = ((ImmHash)___nl__4).getHashValue()["instruction_nr"];
//line 280
___nl__3 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString())) ==((Double.Parse(___nl__4.getValue().ToString())))  );
//line 280
___nl__4 = null;
//line 280
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 280
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 280
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_8;}}
//line 280
___nl__1 = null;
//line 280
___nl__2 = null;
//line 280
___nl__3 = null;
//line 280
if (true) {goto label_3;}
//line 280
if (true) {goto label_8;}
//line 280
label_8:
//line 280
___nl__3 = null;
//line 281
if (true) {goto label_6;}
//line 281
label_6:
//line 281
___nl__2 = null;
//line 282
___ref______nl__0 = new ImmRef(___nl__0);
interpreter_NL.NL_step_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 283
___nl__2 = ((ImmHash)___nl__0).getHashValue()["rstate"];
//line 283
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("error"));
//line 283
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 283
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_10;}}
//line 283
___nl__1 = null;
//line 283
___nl__2 = null;
//line 283
if (true) {goto label_3;}
//line 283
if (true) {goto label_10;}
//line 283
label_10:
//line 283
___nl__2 = null;
//line 284
___nl__2 = interpreter_NL.NL_has_next_instruction(___nl__0);

//line 284
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 284
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 284
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_12;}}
//line 284
___nl__1 = null;
//line 284
___nl__2 = null;
//line 284
if (true) {goto label_3;}
//line 284
if (true) {goto label_12;}
//line 284
label_12:
//line 284
___nl__2 = null;
//line 284
___nl__1 = null;
//line 277
if (true) {goto label_4;}
//line 277
label_3:
//line 277
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_handle_new_declarations_priv(ImmRef ___arg__0) {
Imm ___nl__0 = ___arg__0.getValue().clone();
Imm ___nl__1 = null;
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
//line 289
___nl__1 = interpreter_NL.NL_has_next_instruction(___nl__0);

//line 289
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1));
//line 289
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1));
//line 289
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_2;}}
//line 289
___nl__1 = null;
//line 289
___arg__0.setValue(___nl__0);if(true) return null;
//line 289
if (true) {goto label_2;}
//line 289
label_2:
//line 289
___nl__1 = null;
//line 290
___nl__1 = interpreter_NL.NL_get_command_priv(___nl__0);

//line 291
___nl__2 = ((ImmHash)___nl__1).getHashValue()["debug"];
//line 291
___nl__2 = ((ImmHash)___nl__2).getHashValue()["declarations"];
//line 291
___nl__5 = c_rt_lib_NL.NL_init_iter(___nl__2);

//line 291
label_5:
//line 291
___nl__3 = c_rt_lib_NL.NL_is_end_hash(___nl__5);

//line 291
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 291
___nl__3 = c_rt_lib_NL.NL_get_key_iter(___nl__5);

//line 291
___nl__4 = c_rt_lib_NL.NL_hash_get_value(___nl__2,___nl__3);

//line 292
___nl__6 = new ImmString("top");
//line 292
___nl__6 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__6);

//line 292
___nl__7 = new ImmString("code_vars");
//line 292
___nl__7 = c_rt_lib_NL.NL_get_ref_hash(___nl__6,___nl__7);

//line 292
___ref______nl__7 = new ImmRef(___nl__7);
hash_NL.NL_set_value(___ref______nl__7,___nl__3,___nl__4);
___nl__7 = ___ref______nl__7.getValue();

//line 292
___nl__8 = new ImmString("code_vars");
//line 292
___ref______nl__6 = new ImmRef(___nl__6);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__6,___nl__8,___nl__7);
___nl__6 = ___ref______nl__6.getValue();

//line 292
___nl__8 = new ImmString("top");
//line 292
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__8,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

//line 292
___nl__8 = null;
//line 292
___nl__6 = null;
//line 292
___nl__7 = null;
//line 293
___nl__5 = c_rt_lib_NL.NL_next_iter(___nl__5);

//line 293
if (true) {goto label_5;}
//line 293
label_3:
//line 293
___nl__2 = null;
//line 293
___nl__3 = null;
//line 293
___nl__4 = null;
//line 293
___nl__5 = null;
//line 293
___nl__1 = null;
//line 293
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_step_priv(ImmRef ___arg__0) {
Imm ___nl__0 = ___arg__0.getValue().clone();
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
//line 297
___nl__1 = interpreter_NL.NL_has_next_instruction(___nl__0);

//line 297
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1));
//line 297
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1));
//line 297
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_2;}}
//line 297
___nl__2 = new ImmArray(new Imm[0]);
//line 297
c_rt_lib_NL.NL_die();
//line 297
if (true) {goto label_2;}
//line 297
label_2:
//line 297
___nl__1 = null;
//line 297
___nl__2 = null;
//line 298
___nl__1 = interpreter_NL.NL_get_command_priv(___nl__0);

//line 299
___nl__2 = ((ImmHash)___nl__1).getHashValue()["cmd"];
//line 300
___nl__3 = new ImmString("top");
//line 300
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__3);

//line 300
___nl__4 = new ImmString("next");
//line 300
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__3,___nl__4);

//line 300
___nl__5 = new ImmDouble(1);
//line 300
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString())));
//line 300
___nl__6 = new ImmString("next");
//line 300
___ref______nl__3 = new ImmRef(___nl__3);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__3,___nl__6,___nl__4);
___nl__3 = ___ref______nl__3.getValue();

//line 300
___nl__6 = new ImmString("top");
//line 300
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__6,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 300
___nl__6 = null;
//line 300
___nl__3 = null;
//line 300
___nl__4 = null;
//line 300
___nl__5 = null;
//line 301
___nl__3 = interpreter_NL.NL_check_command_priv(___nl__0,___nl__2);

//line 301
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 301
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 301
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_4;}}
//line 302
___nl__4 = new ImmString("incorrect command");
//line 302
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("error"), ___nl__4);
//line 302
___nl__5 = ___nl__4;
//line 302
((ImmHash)___nl__0).set("rstate", ___nl__5);
//line 302
___nl__4 = null;
//line 302
___nl__5 = null;
//line 303
___nl__1 = null;
//line 303
___nl__2 = null;
//line 303
___nl__3 = null;
//line 303
___arg__0.setValue(___nl__0);if(true) return null;
//line 304
if (true) {goto label_4;}
//line 304
label_4:
//line 304
___nl__3 = null;
//line 305
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("arr_decl"));
//line 305
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_6;}}
//line 310
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("hash_decl"));
//line 310
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_7;}}
//line 317
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("call"));
//line 317
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_8;}}
//line 334
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("func"));
//line 334
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_9;}}
//line 336
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("una_op"));
//line 336
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_10;}}
//line 340
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("bin_op"));
//line 340
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_11;}}
//line 345
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("ov_is"));
//line 345
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_12;}}
//line 347
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("ov_as"));
//line 347
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_13;}}
//line 349
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("return"));
//line 349
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_14;}}
//line 351
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("die"));
//line 351
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_15;}}
//line 353
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("move"));
//line 353
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_16;}}
//line 355
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("load_const"));
//line 355
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_17;}}
//line 357
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("get_frm_idx"));
//line 357
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_18;}}
//line 361
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("set_at_idx"));
//line 361
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_19;}}
//line 367
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("get_val"));
//line 367
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_20;}}
//line 370
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("set_val"));
//line 370
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_21;}}
//line 375
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("ov_mk"));
//line 375
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_22;}}
//line 383
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("prt_lbl"));
//line 383
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_23;}}
//line 384
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("if_goto"));
//line 384
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_24;}}
//line 386
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("goto"));
//line 386
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_25;}}
//line 388
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("clear"));
//line 388
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_26;}}
//line 388
___nl__3 = new ImmString("NOMATCHALERT");
//line 388
___nl__3 = new ImmArray(new Imm[] {___nl__3,___nl__2,});
//line 388
c_rt_lib_NL.NL_die();
//line 305
label_6:
//line 305
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("arr_decl"));
//line 306
___nl__5 = new ImmArray(new Imm[0]);
//line 307
___nl__6 = ((ImmHash)___nl__4).getHashValue()["src"];
//line 307
___nl__8 = new ImmDouble(0);
//line 307
___nl__9 = new ImmDouble(1);
//line 307
___nl__10 = c_rt_lib_NL.NL_array_len(___nl__6);

//line 307
label_29:
//line 307
___nl__11 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString()))>=(Double.Parse(___nl__10.getValue().ToString())) );
//line 307
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_27;}}
//line 307
___nl__7 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 307
___nl__12 = ((ImmHash)___nl__0).getHashValue()["top"];
//line 307
___nl__12 = ((ImmHash)___nl__12).getHashValue()["vars"];
//line 307
___nl__12 = (___nl__12 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 307
___ref______nl__5 = new ImmRef(___nl__5);
array_NL.NL_push(___ref______nl__5,___nl__12);
___nl__5 = ___ref______nl__5.getValue();

//line 307
___nl__12 = null;
//line 307
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))+(Double.Parse(___nl__9.getValue().ToString())));
//line 307
if (true) {goto label_29;}
//line 307
label_27:
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
//line 308
___nl__6 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 308
___nl__7 = new ImmString("");
//line 308
___nl__6 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__7.toString()));
//line 308
___nl__7 = null;
//line 308
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 308
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 308
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_31;}}
//line 308
___nl__7 = new ImmString("top");
//line 308
___nl__7 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__7);

//line 308
___nl__8 = new ImmString("vars");
//line 308
___nl__8 = c_rt_lib_NL.NL_get_ref_hash(___nl__7,___nl__8);

//line 308
___nl__10 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 308
___nl__9 = ___nl__5;
//line 308
(___nl__8 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()] = ___nl__9;
//line 308
___nl__11 = new ImmString("vars");
//line 308
___ref______nl__7 = new ImmRef(___nl__7);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__7,___nl__11,___nl__8);
___nl__7 = ___ref______nl__7.getValue();

//line 308
___nl__11 = new ImmString("top");
//line 308
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__11,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 308
___nl__11 = null;
//line 308
___nl__7 = null;
//line 308
___nl__8 = null;
//line 308
___nl__9 = null;
//line 308
___nl__10 = null;
//line 308
if (true) {goto label_31;}
//line 308
label_31:
//line 308
___nl__6 = null;
//line 308
___nl__5 = null;
//line 308
___nl__4 = null;
//line 310
if (true) {goto label_5;}
//line 310
label_7:
//line 310
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("hash_decl"));
//line 311
__function_map = new Dictionary<String, Imm>();
___nl__5 = new ImmHash(__function_map);
//line 312
___nl__6 = ((ImmHash)___nl__4).getHashValue()["src"];
//line 312
___nl__8 = new ImmDouble(0);
//line 312
___nl__9 = new ImmDouble(1);
//line 312
___nl__10 = c_rt_lib_NL.NL_array_len(___nl__6);

//line 312
label_34:
//line 312
___nl__11 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString()))>=(Double.Parse(___nl__10.getValue().ToString())) );
//line 312
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_32;}}
//line 312
___nl__7 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 313
___nl__12 = ((ImmHash)___nl__0).getHashValue()["top"];
//line 313
___nl__12 = ((ImmHash)___nl__12).getHashValue()["vars"];
//line 313
___nl__13 = ((ImmHash)___nl__7).getHashValue()["val"];
//line 313
___nl__12 = (___nl__12 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__13).getDoubleValue()];
//line 313
___nl__13 = null;
//line 314
___nl__13 = ((ImmHash)___nl__7).getHashValue()["key"];
//line 314
___ref______nl__5 = new ImmRef(___nl__5);
hash_NL.NL_set_value(___ref______nl__5,___nl__13,___nl__12);
___nl__5 = ___ref______nl__5.getValue();

//line 314
___nl__13 = null;
//line 314
___nl__12 = null;
//line 315
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))+(Double.Parse(___nl__9.getValue().ToString())));
//line 315
if (true) {goto label_34;}
//line 315
label_32:
//line 315
___nl__6 = null;
//line 315
___nl__7 = null;
//line 315
___nl__8 = null;
//line 315
___nl__9 = null;
//line 315
___nl__10 = null;
//line 315
___nl__11 = null;
//line 316
___nl__6 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 316
___nl__7 = new ImmString("");
//line 316
___nl__6 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__7.toString()));
//line 316
___nl__7 = null;
//line 316
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 316
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 316
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_36;}}
//line 316
___nl__7 = new ImmString("top");
//line 316
___nl__7 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__7);

//line 316
___nl__8 = new ImmString("vars");
//line 316
___nl__8 = c_rt_lib_NL.NL_get_ref_hash(___nl__7,___nl__8);

//line 316
___nl__10 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 316
___nl__9 = ___nl__5;
//line 316
(___nl__8 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()] = ___nl__9;
//line 316
___nl__11 = new ImmString("vars");
//line 316
___ref______nl__7 = new ImmRef(___nl__7);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__7,___nl__11,___nl__8);
___nl__7 = ___ref______nl__7.getValue();

//line 316
___nl__11 = new ImmString("top");
//line 316
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__11,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 316
___nl__11 = null;
//line 316
___nl__7 = null;
//line 316
___nl__8 = null;
//line 316
___nl__9 = null;
//line 316
___nl__10 = null;
//line 316
if (true) {goto label_36;}
//line 316
label_36:
//line 316
___nl__6 = null;
//line 316
___nl__5 = null;
//line 316
___nl__4 = null;
//line 317
if (true) {goto label_5;}
//line 317
label_8:
//line 317
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("call"));
//line 319
___nl__6 = ((ImmHash)___nl__4).getHashValue()["mod"];
//line 319
___nl__7 = new ImmString("");
//line 319
___nl__6 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__7.toString()));
//line 319
___nl__7 = null;
//line 319
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 319
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_38;}}
//line 320
___nl__7 = ((ImmHash)___nl__0).getHashValue()["top"];
//line 320
___nl__7 = ((ImmHash)___nl__7).getHashValue()["module_name"];
//line 320
___nl__8 = new ImmString("::priv::");
//line 320
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 320
___nl__8 = null;
//line 320
___nl__8 = ((ImmHash)___nl__4).getHashValue()["fun_name"];
//line 320
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 320
___nl__8 = null;
//line 320
___nl__5 = ___nl__7;
//line 320
___nl__7 = null;
//line 321
if (true) {goto label_37;}
//line 321
label_38:
//line 322
___nl__7 = ((ImmHash)___nl__4).getHashValue()["mod"];
//line 322
___nl__8 = new ImmString("::");
//line 322
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 322
___nl__8 = null;
//line 322
___nl__8 = ((ImmHash)___nl__4).getHashValue()["fun_name"];
//line 322
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 322
___nl__8 = null;
//line 322
___nl__5 = ___nl__7;
//line 322
___nl__7 = null;
//line 323
if (true) {goto label_37;}
//line 323
label_37:
//line 323
___nl__6 = null;
//line 324
___nl__7 = ((ImmHash)___nl__0).getHashValue()["compiler_functions"];
//line 324
___nl__6 = hash_NL.NL_has_key(___nl__7,___nl__5);

//line 324
___nl__7 = null;
//line 324
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 324
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_40;}}
//line 325
___ref______nl__0 = new ImmRef(___nl__0);
interpreter_NL.NL_handle_compiler_call_priv(___nl__4,___nl__5,___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 326
if (true) {goto label_39;}
//line 326
label_40:
//line 326
___nl__7 = ((ImmHash)___nl__0).getHashValue()["known_exec_func"];
//line 326
___nl__6 = hash_NL.NL_has_key(___nl__7,___nl__5);

//line 326
___nl__7 = null;
//line 326
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 326
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_41;}}
//line 327
___ref______nl__0 = new ImmRef(___nl__0);
interpreter_NL.NL_handle_extern_call_priv(___nl__4,___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 328
if (true) {goto label_39;}
//line 328
label_41:
//line 328
___nl__7 = ((ImmHash)___nl__0).getHashValue()["functions"];
//line 328
___nl__6 = hash_NL.NL_has_key(___nl__7,___nl__5);

//line 328
___nl__7 = null;
//line 328
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 328
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_42;}}
//line 329
___ref______nl__0 = new ImmRef(___nl__0);
interpreter_NL.NL_handle_normal_call_priv(___nl__4,___nl__5,___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 330
if (true) {goto label_39;}
//line 330
label_42:
//line 331
___nl__7 = new ImmString("unknown function call: ");
//line 331
___nl__7 = new ImmString(___nl__7.toString() + ___nl__5.toString());
//line 331
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("error"), ___nl__7);
//line 331
___nl__8 = ___nl__7;
//line 331
((ImmHash)___nl__0).set("rstate", ___nl__8);
//line 331
___nl__7 = null;
//line 331
___nl__8 = null;
//line 332
if (true) {goto label_39;}
//line 332
label_39:
//line 332
___nl__6 = null;
//line 332
___nl__5 = null;
//line 332
___nl__4 = null;
//line 334
if (true) {goto label_5;}
//line 334
label_9:
//line 334
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("func"));
//line 335
___nl__5 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 335
___nl__6 = new ImmString("");
//line 335
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__5.toString().Equals(___nl__6.toString()));
//line 335
___nl__6 = null;
//line 335
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 335
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 335
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_44;}}
//line 335
___nl__7 = ((ImmHash)___nl__4).getHashValue()["module"];
//line 335
___nl__8 = ((ImmHash)___nl__4).getHashValue()["name"];
//line 335
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",___nl__7);
__function_map.Add("name",___nl__8);
___nl__6 = new ImmHash(__function_map);
//line 335
___nl__7 = null;
//line 335
___nl__8 = null;
//line 335
___nl__7 = new ImmString("top");
//line 335
___nl__7 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__7);

//line 335
___nl__8 = new ImmString("vars");
//line 335
___nl__8 = c_rt_lib_NL.NL_get_ref_hash(___nl__7,___nl__8);

//line 335
___nl__10 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 335
___nl__9 = ___nl__6;
//line 335
(___nl__8 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()] = ___nl__9;
//line 335
___nl__11 = new ImmString("vars");
//line 335
___ref______nl__7 = new ImmRef(___nl__7);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__7,___nl__11,___nl__8);
___nl__7 = ___ref______nl__7.getValue();

//line 335
___nl__11 = new ImmString("top");
//line 335
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__11,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 335
___nl__11 = null;
//line 335
___nl__6 = null;
//line 335
___nl__7 = null;
//line 335
___nl__8 = null;
//line 335
___nl__9 = null;
//line 335
___nl__10 = null;
//line 335
if (true) {goto label_44;}
//line 335
label_44:
//line 335
___nl__5 = null;
//line 335
___nl__4 = null;
//line 336
if (true) {goto label_5;}
//line 336
label_10:
//line 336
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("una_op"));
//line 337
___nl__5 = ((ImmHash)___nl__0).getHashValue()["top"];
//line 337
___nl__5 = ((ImmHash)___nl__5).getHashValue()["vars"];
//line 337
___nl__6 = ((ImmHash)___nl__4).getHashValue()["src"];
//line 337
___nl__5 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()];
//line 337
___nl__6 = null;
//line 338
___nl__7 = ((ImmHash)___nl__4).getHashValue()["op"];
//line 338
___nl__6 = interpreter_NL.NL_execute_una_op_priv(___nl__5,___nl__7);

//line 338
___nl__7 = null;
//line 339
___nl__7 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 339
___nl__8 = new ImmString("");
//line 339
___nl__7 = c_rt_lib_NL.NL_native_to_nl(___nl__7.toString().Equals(___nl__8.toString()));
//line 339
___nl__8 = null;
//line 339
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 339
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 339
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_46;}}
//line 339
___nl__8 = new ImmString("top");
//line 339
___nl__8 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__8);

//line 339
___nl__9 = new ImmString("vars");
//line 339
___nl__9 = c_rt_lib_NL.NL_get_ref_hash(___nl__8,___nl__9);

//line 339
___nl__11 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 339
___nl__10 = ___nl__6;
//line 339
(___nl__9 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__11).getDoubleValue()] = ___nl__10;
//line 339
___nl__12 = new ImmString("vars");
//line 339
___ref______nl__8 = new ImmRef(___nl__8);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__8,___nl__12,___nl__9);
___nl__8 = ___ref______nl__8.getValue();

//line 339
___nl__12 = new ImmString("top");
//line 339
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__12,___nl__8);
___nl__0 = ___ref______nl__0.getValue();

//line 339
___nl__12 = null;
//line 339
___nl__8 = null;
//line 339
___nl__9 = null;
//line 339
___nl__10 = null;
//line 339
___nl__11 = null;
//line 339
if (true) {goto label_46;}
//line 339
label_46:
//line 339
___nl__7 = null;
//line 339
___nl__5 = null;
//line 339
___nl__6 = null;
//line 339
___nl__4 = null;
//line 340
if (true) {goto label_5;}
//line 340
label_11:
//line 340
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("bin_op"));
//line 341
___nl__5 = ((ImmHash)___nl__0).getHashValue()["top"];
//line 341
___nl__5 = ((ImmHash)___nl__5).getHashValue()["vars"];
//line 341
___nl__6 = ((ImmHash)___nl__4).getHashValue()["left"];
//line 341
___nl__5 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()];
//line 341
___nl__6 = null;
//line 342
___nl__6 = ((ImmHash)___nl__0).getHashValue()["top"];
//line 342
___nl__6 = ((ImmHash)___nl__6).getHashValue()["vars"];
//line 342
___nl__7 = ((ImmHash)___nl__4).getHashValue()["right"];
//line 342
___nl__6 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 342
___nl__7 = null;
//line 343
___nl__8 = ((ImmHash)___nl__4).getHashValue()["op"];
//line 343
___nl__7 = interpreter_NL.NL_execute_bin_op_priv(___nl__5,___nl__6,___nl__8);

//line 343
___nl__8 = null;
//line 344
___nl__8 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 344
___nl__9 = new ImmString("");
//line 344
___nl__8 = c_rt_lib_NL.NL_native_to_nl(___nl__8.toString().Equals(___nl__9.toString()));
//line 344
___nl__9 = null;
//line 344
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8));
//line 344
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8));
//line 344
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_48;}}
//line 344
___nl__9 = new ImmString("top");
//line 344
___nl__9 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__9);

//line 344
___nl__10 = new ImmString("vars");
//line 344
___nl__10 = c_rt_lib_NL.NL_get_ref_hash(___nl__9,___nl__10);

//line 344
___nl__12 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 344
___nl__11 = ___nl__7;
//line 344
(___nl__10 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__12).getDoubleValue()] = ___nl__11;
//line 344
___nl__13 = new ImmString("vars");
//line 344
___ref______nl__9 = new ImmRef(___nl__9);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__9,___nl__13,___nl__10);
___nl__9 = ___ref______nl__9.getValue();

//line 344
___nl__13 = new ImmString("top");
//line 344
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__13,___nl__9);
___nl__0 = ___ref______nl__0.getValue();

//line 344
___nl__13 = null;
//line 344
___nl__9 = null;
//line 344
___nl__10 = null;
//line 344
___nl__11 = null;
//line 344
___nl__12 = null;
//line 344
if (true) {goto label_48;}
//line 344
label_48:
//line 344
___nl__8 = null;
//line 344
___nl__5 = null;
//line 344
___nl__6 = null;
//line 344
___nl__7 = null;
//line 344
___nl__4 = null;
//line 345
if (true) {goto label_5;}
//line 345
label_12:
//line 345
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("ov_is"));
//line 346
___nl__5 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 346
___nl__6 = new ImmString("");
//line 346
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__5.toString().Equals(___nl__6.toString()));
//line 346
___nl__6 = null;
//line 346
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 346
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 346
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_50;}}
//line 346
___nl__7 = ((ImmHash)___nl__0).getHashValue()["top"];
//line 346
___nl__7 = ((ImmHash)___nl__7).getHashValue()["vars"];
//line 346
___nl__8 = ((ImmHash)___nl__4).getHashValue()["src"];
//line 346
___nl__7 = (___nl__7 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 346
___nl__8 = null;
//line 346
___nl__8 = ((ImmHash)___nl__4).getHashValue()["type"];
//line 346
___nl__6 = ov_NL.NL_is(___nl__7,___nl__8);

//line 346
___nl__8 = null;
//line 346
___nl__7 = null;
//line 346
___nl__7 = new ImmString("top");
//line 346
___nl__7 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__7);

//line 346
___nl__8 = new ImmString("vars");
//line 346
___nl__8 = c_rt_lib_NL.NL_get_ref_hash(___nl__7,___nl__8);

//line 346
___nl__10 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 346
___nl__9 = ___nl__6;
//line 346
(___nl__8 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()] = ___nl__9;
//line 346
___nl__11 = new ImmString("vars");
//line 346
___ref______nl__7 = new ImmRef(___nl__7);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__7,___nl__11,___nl__8);
___nl__7 = ___ref______nl__7.getValue();

//line 346
___nl__11 = new ImmString("top");
//line 346
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__11,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 346
___nl__11 = null;
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
if (true) {goto label_50;}
//line 346
label_50:
//line 346
___nl__5 = null;
//line 346
___nl__4 = null;
//line 347
if (true) {goto label_5;}
//line 347
label_13:
//line 347
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("ov_as"));
//line 348
___nl__5 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 348
___nl__6 = new ImmString("");
//line 348
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__5.toString().Equals(___nl__6.toString()));
//line 348
___nl__6 = null;
//line 348
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 348
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 348
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_52;}}
//line 348
___nl__7 = ((ImmHash)___nl__0).getHashValue()["top"];
//line 348
___nl__7 = ((ImmHash)___nl__7).getHashValue()["vars"];
//line 348
___nl__8 = ((ImmHash)___nl__4).getHashValue()["src"];
//line 348
___nl__7 = (___nl__7 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 348
___nl__8 = null;
//line 348
___nl__8 = ((ImmHash)___nl__4).getHashValue()["type"];
//line 348
___nl__6 = ov_NL.NL_as(___nl__7,___nl__8);

//line 348
___nl__8 = null;
//line 348
___nl__7 = null;
//line 348
___nl__7 = new ImmString("top");
//line 348
___nl__7 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__7);

//line 348
___nl__8 = new ImmString("vars");
//line 348
___nl__8 = c_rt_lib_NL.NL_get_ref_hash(___nl__7,___nl__8);

//line 348
___nl__10 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 348
___nl__9 = ___nl__6;
//line 348
(___nl__8 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()] = ___nl__9;
//line 348
___nl__11 = new ImmString("vars");
//line 348
___ref______nl__7 = new ImmRef(___nl__7);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__7,___nl__11,___nl__8);
___nl__7 = ___ref______nl__7.getValue();

//line 348
___nl__11 = new ImmString("top");
//line 348
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__11,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 348
___nl__11 = null;
//line 348
___nl__6 = null;
//line 348
___nl__7 = null;
//line 348
___nl__8 = null;
//line 348
___nl__9 = null;
//line 348
___nl__10 = null;
//line 348
if (true) {goto label_52;}
//line 348
label_52:
//line 348
___nl__5 = null;
//line 348
___nl__4 = null;
//line 349
if (true) {goto label_5;}
//line 349
label_14:
//line 349
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("return"));
//line 350
___ref______nl__0 = new ImmRef(___nl__0);
interpreter_NL.NL_handle_return_priv(___nl__4,___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 350
___nl__4 = null;
//line 351
if (true) {goto label_5;}
//line 351
label_15:
//line 351
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("die"));
//line 352
___nl__5 = new ImmString("die");
//line 352
___nl__7 = ((ImmHash)___nl__0).getHashValue()["top"];
//line 352
___nl__7 = ((ImmHash)___nl__7).getHashValue()["vars"];
//line 352
___nl__7 = (___nl__7 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()];
//line 352
___nl__6 = dfile_NL.NL_ssave(___nl__7);

//line 352
___nl__7 = null;
//line 352
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 352
___nl__6 = null;
//line 352
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("error"), ___nl__5);
//line 352
___nl__6 = ___nl__5;
//line 352
((ImmHash)___nl__0).set("rstate", ___nl__6);
//line 352
___nl__5 = null;
//line 352
___nl__6 = null;
//line 352
___nl__4 = null;
//line 353
if (true) {goto label_5;}
//line 353
label_16:
//line 353
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("move"));
//line 354
___nl__5 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 354
___nl__6 = new ImmString("");
//line 354
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__5.toString().Equals(___nl__6.toString()));
//line 354
___nl__6 = null;
//line 354
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 354
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 354
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_54;}}
//line 354
___nl__6 = ((ImmHash)___nl__0).getHashValue()["top"];
//line 354
___nl__6 = ((ImmHash)___nl__6).getHashValue()["vars"];
//line 354
___nl__7 = ((ImmHash)___nl__4).getHashValue()["src"];
//line 354
___nl__6 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 354
___nl__7 = null;
//line 354
___nl__7 = new ImmString("top");
//line 354
___nl__7 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__7);

//line 354
___nl__8 = new ImmString("vars");
//line 354
___nl__8 = c_rt_lib_NL.NL_get_ref_hash(___nl__7,___nl__8);

//line 354
___nl__10 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 354
___nl__9 = ___nl__6;
//line 354
(___nl__8 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()] = ___nl__9;
//line 354
___nl__11 = new ImmString("vars");
//line 354
___ref______nl__7 = new ImmRef(___nl__7);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__7,___nl__11,___nl__8);
___nl__7 = ___ref______nl__7.getValue();

//line 354
___nl__11 = new ImmString("top");
//line 354
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__11,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 354
___nl__11 = null;
//line 354
___nl__6 = null;
//line 354
___nl__7 = null;
//line 354
___nl__8 = null;
//line 354
___nl__9 = null;
//line 354
___nl__10 = null;
//line 354
if (true) {goto label_54;}
//line 354
label_54:
//line 354
___nl__5 = null;
//line 354
___nl__4 = null;
//line 355
if (true) {goto label_5;}
//line 355
label_17:
//line 355
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("load_const"));
//line 356
___nl__5 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 356
___nl__6 = new ImmString("");
//line 356
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__5.toString().Equals(___nl__6.toString()));
//line 356
___nl__6 = null;
//line 356
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 356
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 356
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_56;}}
//line 356
___nl__6 = ((ImmHash)___nl__4).getHashValue()["val"];
//line 356
___nl__7 = new ImmString("top");
//line 356
___nl__7 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__7);

//line 356
___nl__8 = new ImmString("vars");
//line 356
___nl__8 = c_rt_lib_NL.NL_get_ref_hash(___nl__7,___nl__8);

//line 356
___nl__10 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 356
___nl__9 = ___nl__6;
//line 356
(___nl__8 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()] = ___nl__9;
//line 356
___nl__11 = new ImmString("vars");
//line 356
___ref______nl__7 = new ImmRef(___nl__7);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__7,___nl__11,___nl__8);
___nl__7 = ___ref______nl__7.getValue();

//line 356
___nl__11 = new ImmString("top");
//line 356
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__11,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 356
___nl__11 = null;
//line 356
___nl__6 = null;
//line 356
___nl__7 = null;
//line 356
___nl__8 = null;
//line 356
___nl__9 = null;
//line 356
___nl__10 = null;
//line 356
if (true) {goto label_56;}
//line 356
label_56:
//line 356
___nl__5 = null;
//line 356
___nl__4 = null;
//line 357
if (true) {goto label_5;}
//line 357
label_18:
//line 357
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("get_frm_idx"));
//line 358
___nl__5 = ((ImmHash)___nl__0).getHashValue()["top"];
//line 358
___nl__5 = ((ImmHash)___nl__5).getHashValue()["vars"];
//line 358
___nl__6 = ((ImmHash)___nl__4).getHashValue()["src"];
//line 358
___nl__5 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()];
//line 358
___nl__6 = null;
//line 359
___nl__6 = ((ImmHash)___nl__0).getHashValue()["top"];
//line 359
___nl__6 = ((ImmHash)___nl__6).getHashValue()["vars"];
//line 359
___nl__7 = ((ImmHash)___nl__4).getHashValue()["idx"];
//line 359
___nl__6 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 359
___nl__7 = null;
//line 360
___nl__7 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 360
___nl__8 = new ImmString("");
//line 360
___nl__7 = c_rt_lib_NL.NL_native_to_nl(___nl__7.toString().Equals(___nl__8.toString()));
//line 360
___nl__8 = null;
//line 360
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 360
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 360
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_58;}}
//line 360
___nl__8 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()];
//line 360
___nl__9 = new ImmString("top");
//line 360
___nl__9 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__9);

//line 360
___nl__10 = new ImmString("vars");
//line 360
___nl__10 = c_rt_lib_NL.NL_get_ref_hash(___nl__9,___nl__10);

//line 360
___nl__12 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 360
___nl__11 = ___nl__8;
//line 360
(___nl__10 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__12).getDoubleValue()] = ___nl__11;
//line 360
___nl__13 = new ImmString("vars");
//line 360
___ref______nl__9 = new ImmRef(___nl__9);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__9,___nl__13,___nl__10);
___nl__9 = ___ref______nl__9.getValue();

//line 360
___nl__13 = new ImmString("top");
//line 360
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__13,___nl__9);
___nl__0 = ___ref______nl__0.getValue();

//line 360
___nl__13 = null;
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
if (true) {goto label_58;}
//line 360
label_58:
//line 360
___nl__7 = null;
//line 360
___nl__5 = null;
//line 360
___nl__6 = null;
//line 360
___nl__4 = null;
//line 361
if (true) {goto label_5;}
//line 361
label_19:
//line 361
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("set_at_idx"));
//line 362
___nl__5 = ((ImmHash)___nl__0).getHashValue()["top"];
//line 362
___nl__5 = ((ImmHash)___nl__5).getHashValue()["vars"];
//line 362
___nl__6 = ((ImmHash)___nl__4).getHashValue()["src"];
//line 362
___nl__5 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()];
//line 362
___nl__6 = null;
//line 363
___nl__6 = ((ImmHash)___nl__0).getHashValue()["top"];
//line 363
___nl__6 = ((ImmHash)___nl__6).getHashValue()["vars"];
//line 363
___nl__7 = ((ImmHash)___nl__4).getHashValue()["idx"];
//line 363
___nl__6 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 363
___nl__7 = null;
//line 364
___nl__7 = ((ImmHash)___nl__0).getHashValue()["top"];
//line 364
___nl__7 = ((ImmHash)___nl__7).getHashValue()["vars"];
//line 364
___nl__8 = ((ImmHash)___nl__4).getHashValue()["val"];
//line 364
___nl__7 = (___nl__7 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 364
___nl__8 = null;
//line 365
___nl__8 = ___nl__7;
//line 365
(___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()] = ___nl__8;
//line 365
___nl__8 = null;
//line 366
___nl__8 = new ImmString("top");
//line 366
___nl__8 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__8);

//line 366
___nl__9 = new ImmString("vars");
//line 366
___nl__9 = c_rt_lib_NL.NL_get_ref_hash(___nl__8,___nl__9);

//line 366
___nl__11 = ((ImmHash)___nl__4).getHashValue()["src"];
//line 366
___nl__10 = ___nl__5;
//line 366
(___nl__9 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__11).getDoubleValue()] = ___nl__10;
//line 366
___nl__12 = new ImmString("vars");
//line 366
___ref______nl__8 = new ImmRef(___nl__8);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__8,___nl__12,___nl__9);
___nl__8 = ___ref______nl__8.getValue();

//line 366
___nl__12 = new ImmString("top");
//line 366
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__12,___nl__8);
___nl__0 = ___ref______nl__0.getValue();

//line 366
___nl__12 = null;
//line 366
___nl__8 = null;
//line 366
___nl__9 = null;
//line 366
___nl__10 = null;
//line 366
___nl__11 = null;
//line 366
___nl__5 = null;
//line 366
___nl__6 = null;
//line 366
___nl__7 = null;
//line 366
___nl__4 = null;
//line 367
if (true) {goto label_5;}
//line 367
label_20:
//line 367
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("get_val"));
//line 368
___nl__6 = ((ImmHash)___nl__0).getHashValue()["top"];
//line 368
___nl__6 = ((ImmHash)___nl__6).getHashValue()["vars"];
//line 368
___nl__7 = ((ImmHash)___nl__4).getHashValue()["src"];
//line 368
___nl__6 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 368
___nl__7 = null;
//line 368
___nl__7 = ((ImmHash)___nl__4).getHashValue()["key"];
//line 368
___nl__5 = hash_NL.NL_get_value(___nl__6,___nl__7);

//line 368
___nl__7 = null;
//line 368
___nl__6 = null;
//line 369
___nl__6 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 369
___nl__7 = new ImmString("");
//line 369
___nl__6 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__7.toString()));
//line 369
___nl__7 = null;
//line 369
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 369
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 369
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_60;}}
//line 369
___nl__7 = new ImmString("top");
//line 369
___nl__7 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__7);

//line 369
___nl__8 = new ImmString("vars");
//line 369
___nl__8 = c_rt_lib_NL.NL_get_ref_hash(___nl__7,___nl__8);

//line 369
___nl__10 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 369
___nl__9 = ___nl__5;
//line 369
(___nl__8 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()] = ___nl__9;
//line 369
___nl__11 = new ImmString("vars");
//line 369
___ref______nl__7 = new ImmRef(___nl__7);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__7,___nl__11,___nl__8);
___nl__7 = ___ref______nl__7.getValue();

//line 369
___nl__11 = new ImmString("top");
//line 369
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__11,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 369
___nl__11 = null;
//line 369
___nl__7 = null;
//line 369
___nl__8 = null;
//line 369
___nl__9 = null;
//line 369
___nl__10 = null;
//line 369
if (true) {goto label_60;}
//line 369
label_60:
//line 369
___nl__6 = null;
//line 369
___nl__5 = null;
//line 369
___nl__4 = null;
//line 370
if (true) {goto label_5;}
//line 370
label_21:
//line 370
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("set_val"));
//line 371
___nl__5 = ((ImmHash)___nl__0).getHashValue()["top"];
//line 371
___nl__5 = ((ImmHash)___nl__5).getHashValue()["vars"];
//line 371
___nl__6 = ((ImmHash)___nl__4).getHashValue()["src"];
//line 371
___nl__5 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()];
//line 371
___nl__6 = null;
//line 372
___nl__6 = ((ImmHash)___nl__0).getHashValue()["top"];
//line 372
___nl__6 = ((ImmHash)___nl__6).getHashValue()["vars"];
//line 372
___nl__7 = ((ImmHash)___nl__4).getHashValue()["val"];
//line 372
___nl__6 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 372
___nl__7 = null;
//line 373
___nl__7 = ((ImmHash)___nl__4).getHashValue()["key"];
//line 373
___ref______nl__5 = new ImmRef(___nl__5);
hash_NL.NL_set_value(___ref______nl__5,___nl__7,___nl__6);
___nl__5 = ___ref______nl__5.getValue();

//line 373
___nl__7 = null;
//line 374
___nl__7 = new ImmString("top");
//line 374
___nl__7 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__7);

//line 374
___nl__8 = new ImmString("vars");
//line 374
___nl__8 = c_rt_lib_NL.NL_get_ref_hash(___nl__7,___nl__8);

//line 374
___nl__10 = ((ImmHash)___nl__4).getHashValue()["src"];
//line 374
___nl__9 = ___nl__5;
//line 374
(___nl__8 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()] = ___nl__9;
//line 374
___nl__11 = new ImmString("vars");
//line 374
___ref______nl__7 = new ImmRef(___nl__7);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__7,___nl__11,___nl__8);
___nl__7 = ___ref______nl__7.getValue();

//line 374
___nl__11 = new ImmString("top");
//line 374
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__11,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 374
___nl__11 = null;
//line 374
___nl__7 = null;
//line 374
___nl__8 = null;
//line 374
___nl__9 = null;
//line 374
___nl__10 = null;
//line 374
___nl__5 = null;
//line 374
___nl__6 = null;
//line 374
___nl__4 = null;
//line 375
if (true) {goto label_5;}
//line 375
label_22:
//line 375
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("ov_mk"));
//line 377
___nl__6 = ((ImmHash)___nl__4).getHashValue()["src"];
//line 377
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("arg"));
//line 377
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_62;}}
//line 379
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("emp"));
//line 379
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_63;}}
//line 379
___nl__7 = new ImmString("NOMATCHALERT");
//line 379
___nl__7 = new ImmArray(new Imm[] {___nl__7,___nl__6,});
//line 379
c_rt_lib_NL.NL_die();
//line 377
label_62:
//line 377
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("arg"));
//line 378
___nl__10 = ((ImmHash)___nl__4).getHashValue()["name"];
//line 378
___nl__11 = ((ImmHash)___nl__0).getHashValue()["top"];
//line 378
___nl__11 = ((ImmHash)___nl__11).getHashValue()["vars"];
//line 378
___nl__11 = (___nl__11 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 378
___nl__9 = ov_NL.NL_mk_val(___nl__10,___nl__11);

//line 378
___nl__11 = null;
//line 378
___nl__10 = null;
//line 378
___nl__5 = ___nl__9;
//line 378
___nl__9 = null;
//line 378
___nl__8 = null;
//line 379
if (true) {goto label_61;}
//line 379
label_63:
//line 380
___nl__9 = ((ImmHash)___nl__4).getHashValue()["name"];
//line 380
___nl__8 = ov_NL.NL_mk(___nl__9);

//line 380
___nl__9 = null;
//line 380
___nl__5 = ___nl__8;
//line 380
___nl__8 = null;
//line 381
if (true) {goto label_61;}
//line 381
label_61:
//line 381
___nl__6 = null;
//line 381
___nl__7 = null;
//line 382
___nl__6 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 382
___nl__7 = new ImmString("");
//line 382
___nl__6 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__7.toString()));
//line 382
___nl__7 = null;
//line 382
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 382
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 382
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_65;}}
//line 382
___nl__7 = new ImmString("top");
//line 382
___nl__7 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__7);

//line 382
___nl__8 = new ImmString("vars");
//line 382
___nl__8 = c_rt_lib_NL.NL_get_ref_hash(___nl__7,___nl__8);

//line 382
___nl__10 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 382
___nl__9 = ___nl__5;
//line 382
(___nl__8 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()] = ___nl__9;
//line 382
___nl__11 = new ImmString("vars");
//line 382
___ref______nl__7 = new ImmRef(___nl__7);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__7,___nl__11,___nl__8);
___nl__7 = ___ref______nl__7.getValue();

//line 382
___nl__11 = new ImmString("top");
//line 382
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__11,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 382
___nl__11 = null;
//line 382
___nl__7 = null;
//line 382
___nl__8 = null;
//line 382
___nl__9 = null;
//line 382
___nl__10 = null;
//line 382
if (true) {goto label_65;}
//line 382
label_65:
//line 382
___nl__6 = null;
//line 382
___nl__5 = null;
//line 382
___nl__4 = null;
//line 383
if (true) {goto label_5;}
//line 383
label_23:
//line 383
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("prt_lbl"));
//line 383
___nl__4 = null;
//line 384
if (true) {goto label_5;}
//line 384
label_24:
//line 384
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("if_goto"));
//line 385
___nl__5 = ((ImmHash)___nl__0).getHashValue()["top"];
//line 385
___nl__5 = ((ImmHash)___nl__5).getHashValue()["vars"];
//line 385
___nl__6 = ((ImmHash)___nl__4).getHashValue()["src"];
//line 385
___nl__5 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()];
//line 385
___nl__6 = null;
//line 385
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 385
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_67;}}
//line 385
___nl__6 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 385
___ref______nl__0 = new ImmRef(___nl__0);
interpreter_NL.NL_goto_priv(___ref______nl__0,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

//line 385
___nl__6 = null;
//line 385
if (true) {goto label_67;}
//line 385
label_67:
//line 385
___nl__5 = null;
//line 385
___nl__4 = null;
//line 386
if (true) {goto label_5;}
//line 386
label_25:
//line 386
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("goto"));
//line 387
___ref______nl__0 = new ImmRef(___nl__0);
interpreter_NL.NL_goto_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 387
___nl__4 = null;
//line 388
if (true) {goto label_5;}
//line 388
label_26:
//line 388
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("clear"));
//line 389
___nl__5 = new ImmString("");
//line 389
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!___nl__4.toString().Equals(___nl__5.toString()));
//line 389
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 389
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_69;}}
//line 390
___nl__6 = interpreter_NL.NL_get_none_variant();

//line 390
___nl__7 = new ImmString("top");
//line 390
___nl__7 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__7);

//line 390
___nl__8 = new ImmString("vars");
//line 390
___nl__8 = c_rt_lib_NL.NL_get_ref_hash(___nl__7,___nl__8);

//line 390
___nl__9 = ___nl__6;
//line 390
(___nl__8 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()] = ___nl__9;
//line 390
___nl__10 = new ImmString("vars");
//line 390
___ref______nl__7 = new ImmRef(___nl__7);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__7,___nl__10,___nl__8);
___nl__7 = ___ref______nl__7.getValue();

//line 390
___nl__10 = new ImmString("top");
//line 390
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__10,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 390
___nl__10 = null;
//line 390
___nl__6 = null;
//line 390
___nl__7 = null;
//line 390
___nl__8 = null;
//line 390
___nl__9 = null;
//line 391
___nl__6 = ((ImmHash)___nl__0).getHashValue()["top"];
//line 391
___nl__6 = ((ImmHash)___nl__6).getHashValue()["code_vars"];
//line 391
___nl__9 = c_rt_lib_NL.NL_init_iter(___nl__6);

//line 391
label_72:
//line 391
___nl__7 = c_rt_lib_NL.NL_is_end_hash(___nl__9);

//line 391
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_70;}}
//line 391
___nl__7 = c_rt_lib_NL.NL_get_key_iter(___nl__9);

//line 391
___nl__8 = c_rt_lib_NL.NL_hash_get_value(___nl__6,___nl__7);

//line 392
___nl__10 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString())) ==((Double.Parse(___nl__8.getValue().ToString())))  );
//line 392
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10));
//line 392
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_74;}}
//line 393
___nl__11 = new ImmString("top");
//line 393
___nl__11 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__11);

//line 393
___nl__12 = new ImmString("code_vars");
//line 393
___nl__12 = c_rt_lib_NL.NL_get_ref_hash(___nl__11,___nl__12);

//line 393
___ref______nl__12 = new ImmRef(___nl__12);
hash_NL.NL_delete(___ref______nl__12,___nl__7);
___nl__12 = ___ref______nl__12.getValue();

//line 393
___nl__13 = new ImmString("code_vars");
//line 393
___ref______nl__11 = new ImmRef(___nl__11);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__11,___nl__13,___nl__12);
___nl__11 = ___ref______nl__11.getValue();

//line 393
___nl__13 = new ImmString("top");
//line 393
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__13,___nl__11);
___nl__0 = ___ref______nl__0.getValue();

//line 393
___nl__13 = null;
//line 393
___nl__11 = null;
//line 393
___nl__12 = null;
//line 394
___nl__10 = null;
//line 394
if (true) {goto label_70;}
//line 395
if (true) {goto label_74;}
//line 395
label_74:
//line 395
___nl__10 = null;
//line 396
___nl__9 = c_rt_lib_NL.NL_next_iter(___nl__9);

//line 396
if (true) {goto label_72;}
//line 396
label_70:
//line 396
___nl__6 = null;
//line 396
___nl__7 = null;
//line 396
___nl__8 = null;
//line 396
___nl__9 = null;
//line 397
if (true) {goto label_69;}
//line 397
label_69:
//line 397
___nl__5 = null;
//line 397
___nl__4 = null;
//line 398
if (true) {goto label_5;}
//line 398
label_5:
//line 398
___nl__3 = null;
//line 399
___ref______nl__0 = new ImmRef(___nl__0);
interpreter_NL.NL_handle_new_declarations_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 399
___nl__1 = null;
//line 399
___nl__2 = null;
//line 399
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_check_command_priv(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();
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
//line 403
___nl__2 = ((ImmHash)___nl__0).getHashValue()["check_all_instructions"];
//line 403
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 403
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 403
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 403
___nl__3 = c_rt_lib_NL.NL_get_true();
//line 403
___nl__0 = null;
//line 403
___nl__1 = null;
//line 403
___nl__2 = null;
//line 403
if(true) return ___nl__3;
//line 403
___nl__3 = null;
//line 403
if (true) {goto label_2;}
//line 403
label_2:
//line 403
___nl__2 = null;
//line 404
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("arr_decl"));
//line 404
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_4;}}
//line 405
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("hash_decl"));
//line 405
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_5;}}
//line 406
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("call"));
//line 406
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_6;}}
//line 407
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("func"));
//line 407
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_7;}}
//line 408
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("una_op"));
//line 408
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_8;}}
//line 416
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("bin_op"));
//line 416
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_9;}}
//line 421
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("ov_is"));
//line 421
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_10;}}
//line 424
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("ov_as"));
//line 424
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_11;}}
//line 429
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("return"));
//line 429
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_12;}}
//line 430
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("die"));
//line 430
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_13;}}
//line 431
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("move"));
//line 431
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_14;}}
//line 432
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("load_const"));
//line 432
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_15;}}
//line 433
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("get_frm_idx"));
//line 433
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_16;}}
//line 440
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("set_at_idx"));
//line 440
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_17;}}
//line 446
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("get_val"));
//line 446
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_18;}}
//line 451
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("set_val"));
//line 451
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_19;}}
//line 455
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("ov_mk"));
//line 455
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_20;}}
//line 457
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("prt_lbl"));
//line 457
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_21;}}
//line 458
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("if_goto"));
//line 458
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_22;}}
//line 462
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("goto"));
//line 462
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_23;}}
//line 463
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("clear"));
//line 463
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_24;}}
//line 463
___nl__2 = new ImmString("NOMATCHALERT");
//line 463
___nl__2 = new ImmArray(new Imm[] {___nl__2,___nl__1,});
//line 463
c_rt_lib_NL.NL_die();
//line 404
label_4:
//line 404
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__1, new ImmString("arr_decl"));
//line 404
___nl__3 = null;
//line 405
if (true) {goto label_3;}
//line 405
label_5:
//line 405
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__1, new ImmString("hash_decl"));
//line 405
___nl__3 = null;
//line 406
if (true) {goto label_3;}
//line 406
label_6:
//line 406
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__1, new ImmString("call"));
//line 406
___nl__3 = null;
//line 407
if (true) {goto label_3;}
//line 407
label_7:
//line 407
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__1, new ImmString("func"));
//line 407
___nl__3 = null;
//line 408
if (true) {goto label_3;}
//line 408
label_8:
//line 408
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__1, new ImmString("una_op"));
//line 409
___nl__4 = ((ImmHash)___nl__0).getHashValue()["top"];
//line 409
___nl__4 = ((ImmHash)___nl__4).getHashValue()["vars"];
//line 409
___nl__5 = ((ImmHash)___nl__3).getHashValue()["src"];
//line 409
___nl__4 = (___nl__4 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()];
//line 409
___nl__5 = null;
//line 410
___nl__5 = ((ImmHash)___nl__3).getHashValue()["op"];
//line 410
___nl__6 = new ImmString("!");
//line 410
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__5.toString().Equals(___nl__6.toString()));
//line 410
___nl__6 = null;
//line 410
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 410
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_26;}}
//line 411
___nl__6 = nl_NL.NL_is_variant(___nl__4);

//line 411
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 411
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 411
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_28;}}
//line 411
___nl__7 = c_rt_lib_NL.NL_get_false();
//line 411
___nl__0 = null;
//line 411
___nl__1 = null;
//line 411
___nl__2 = null;
//line 411
___nl__3 = null;
//line 411
___nl__4 = null;
//line 411
___nl__5 = null;
//line 411
___nl__6 = null;
//line 411
if(true) return ___nl__7;
//line 411
___nl__7 = null;
//line 411
if (true) {goto label_28;}
//line 411
label_28:
//line 411
___nl__6 = null;
//line 412
___nl__6 = ___nl__4;
//line 412
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("TRUE"));
//line 412
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_31;}}
//line 412
___nl__6 = ___nl__4;
//line 412
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("FALSE"));
//line 412
label_31:
//line 412
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 412
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 412
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_30;}}
//line 412
___nl__7 = c_rt_lib_NL.NL_get_false();
//line 412
___nl__0 = null;
//line 412
___nl__1 = null;
//line 412
___nl__2 = null;
//line 412
___nl__3 = null;
//line 412
___nl__4 = null;
//line 412
___nl__5 = null;
//line 412
___nl__6 = null;
//line 412
if(true) return ___nl__7;
//line 412
___nl__7 = null;
//line 412
if (true) {goto label_30;}
//line 412
label_30:
//line 412
___nl__6 = null;
//line 413
if (true) {goto label_25;}
//line 413
label_26:
//line 414
___nl__6 = nl_NL.NL_is_sim(___nl__4);

//line 414
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 414
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 414
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_33;}}
//line 414
___nl__7 = c_rt_lib_NL.NL_get_false();
//line 414
___nl__0 = null;
//line 414
___nl__1 = null;
//line 414
___nl__2 = null;
//line 414
___nl__3 = null;
//line 414
___nl__4 = null;
//line 414
___nl__5 = null;
//line 414
___nl__6 = null;
//line 414
if(true) return ___nl__7;
//line 414
___nl__7 = null;
//line 414
if (true) {goto label_33;}
//line 414
label_33:
//line 414
___nl__6 = null;
//line 415
if (true) {goto label_25;}
//line 415
label_25:
//line 415
___nl__5 = null;
//line 415
___nl__4 = null;
//line 415
___nl__3 = null;
//line 416
if (true) {goto label_3;}
//line 416
label_9:
//line 416
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__1, new ImmString("bin_op"));
//line 417
___nl__4 = ((ImmHash)___nl__0).getHashValue()["top"];
//line 417
___nl__4 = ((ImmHash)___nl__4).getHashValue()["vars"];
//line 417
___nl__5 = ((ImmHash)___nl__3).getHashValue()["left"];
//line 417
___nl__4 = (___nl__4 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()];
//line 417
___nl__5 = null;
//line 418
___nl__5 = ((ImmHash)___nl__0).getHashValue()["top"];
//line 418
___nl__5 = ((ImmHash)___nl__5).getHashValue()["vars"];
//line 418
___nl__6 = ((ImmHash)___nl__3).getHashValue()["right"];
//line 418
___nl__5 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()];
//line 418
___nl__6 = null;
//line 419
___nl__6 = nl_NL.NL_is_sim(___nl__4);

//line 419
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 419
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 419
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_35;}}
//line 419
___nl__7 = c_rt_lib_NL.NL_get_false();
//line 419
___nl__0 = null;
//line 419
___nl__1 = null;
//line 419
___nl__2 = null;
//line 419
___nl__3 = null;
//line 419
___nl__4 = null;
//line 419
___nl__5 = null;
//line 419
___nl__6 = null;
//line 419
if(true) return ___nl__7;
//line 419
___nl__7 = null;
//line 419
if (true) {goto label_35;}
//line 419
label_35:
//line 419
___nl__6 = null;
//line 420
___nl__6 = nl_NL.NL_is_sim(___nl__5);

//line 420
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 420
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 420
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_37;}}
//line 420
___nl__7 = c_rt_lib_NL.NL_get_false();
//line 420
___nl__0 = null;
//line 420
___nl__1 = null;
//line 420
___nl__2 = null;
//line 420
___nl__3 = null;
//line 420
___nl__4 = null;
//line 420
___nl__5 = null;
//line 420
___nl__6 = null;
//line 420
if(true) return ___nl__7;
//line 420
___nl__7 = null;
//line 420
if (true) {goto label_37;}
//line 420
label_37:
//line 420
___nl__6 = null;
//line 420
___nl__4 = null;
//line 420
___nl__5 = null;
//line 420
___nl__3 = null;
//line 421
if (true) {goto label_3;}
//line 421
label_10:
//line 421
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__1, new ImmString("ov_is"));
//line 422
___nl__5 = ((ImmHash)___nl__0).getHashValue()["top"];
//line 422
___nl__5 = ((ImmHash)___nl__5).getHashValue()["vars"];
//line 422
___nl__6 = ((ImmHash)___nl__3).getHashValue()["src"];
//line 422
___nl__5 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()];
//line 422
___nl__6 = null;
//line 422
___nl__4 = nl_NL.NL_is_variant(___nl__5);

//line 422
___nl__5 = null;
//line 422
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 422
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 422
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_39;}}
//line 422
___nl__5 = c_rt_lib_NL.NL_get_false();
//line 422
___nl__0 = null;
//line 422
___nl__1 = null;
//line 422
___nl__2 = null;
//line 422
___nl__3 = null;
//line 422
___nl__4 = null;
//line 422
if(true) return ___nl__5;
//line 422
___nl__5 = null;
//line 422
if (true) {goto label_39;}
//line 422
label_39:
//line 422
___nl__4 = null;
//line 423
___nl__5 = ((ImmHash)___nl__3).getHashValue()["type"];
//line 423
___nl__4 = nl_NL.NL_is_sim(___nl__5);

//line 423
___nl__5 = null;
//line 423
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 423
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 423
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_41;}}
//line 423
___nl__5 = c_rt_lib_NL.NL_get_false();
//line 423
___nl__0 = null;
//line 423
___nl__1 = null;
//line 423
___nl__2 = null;
//line 423
___nl__3 = null;
//line 423
___nl__4 = null;
//line 423
if(true) return ___nl__5;
//line 423
___nl__5 = null;
//line 423
if (true) {goto label_41;}
//line 423
label_41:
//line 423
___nl__4 = null;
//line 423
___nl__3 = null;
//line 424
if (true) {goto label_3;}
//line 424
label_11:
//line 424
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__1, new ImmString("ov_as"));
//line 425
___nl__4 = ((ImmHash)___nl__0).getHashValue()["top"];
//line 425
___nl__4 = ((ImmHash)___nl__4).getHashValue()["vars"];
//line 425
___nl__5 = ((ImmHash)___nl__3).getHashValue()["src"];
//line 425
___nl__4 = (___nl__4 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()];
//line 425
___nl__5 = null;
//line 426
___nl__5 = nl_NL.NL_is_variant(___nl__4);

//line 426
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 426
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 426
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_43;}}
//line 426
___nl__6 = c_rt_lib_NL.NL_get_false();
//line 426
___nl__0 = null;
//line 426
___nl__1 = null;
//line 426
___nl__2 = null;
//line 426
___nl__3 = null;
//line 426
___nl__4 = null;
//line 426
___nl__5 = null;
//line 426
if(true) return ___nl__6;
//line 426
___nl__6 = null;
//line 426
if (true) {goto label_43;}
//line 426
label_43:
//line 426
___nl__5 = null;
//line 427
___nl__6 = ((ImmHash)___nl__3).getHashValue()["type"];
//line 427
___nl__5 = nl_NL.NL_is_sim(___nl__6);

//line 427
___nl__6 = null;
//line 427
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 427
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 427
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_45;}}
//line 427
___nl__6 = c_rt_lib_NL.NL_get_false();
//line 427
___nl__0 = null;
//line 427
___nl__1 = null;
//line 427
___nl__2 = null;
//line 427
___nl__3 = null;
//line 427
___nl__4 = null;
//line 427
___nl__5 = null;
//line 427
if(true) return ___nl__6;
//line 427
___nl__6 = null;
//line 427
if (true) {goto label_45;}
//line 427
label_45:
//line 427
___nl__5 = null;
//line 428
___nl__6 = ((ImmHash)___nl__3).getHashValue()["type"];
//line 428
___nl__5 = ov_NL.NL_is(___nl__4,___nl__6);

//line 428
___nl__6 = null;
//line 428
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 428
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 428
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_47;}}
//line 428
___nl__6 = c_rt_lib_NL.NL_get_false();
//line 428
___nl__0 = null;
//line 428
___nl__1 = null;
//line 428
___nl__2 = null;
//line 428
___nl__3 = null;
//line 428
___nl__4 = null;
//line 428
___nl__5 = null;
//line 428
if(true) return ___nl__6;
//line 428
___nl__6 = null;
//line 428
if (true) {goto label_47;}
//line 428
label_47:
//line 428
___nl__5 = null;
//line 428
___nl__4 = null;
//line 428
___nl__3 = null;
//line 429
if (true) {goto label_3;}
//line 429
label_12:
//line 429
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__1, new ImmString("return"));
//line 429
___nl__3 = null;
//line 430
if (true) {goto label_3;}
//line 430
label_13:
//line 430
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__1, new ImmString("die"));
//line 430
___nl__3 = null;
//line 431
if (true) {goto label_3;}
//line 431
label_14:
//line 431
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__1, new ImmString("move"));
//line 431
___nl__3 = null;
//line 432
if (true) {goto label_3;}
//line 432
label_15:
//line 432
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__1, new ImmString("load_const"));
//line 432
___nl__3 = null;
//line 433
if (true) {goto label_3;}
//line 433
label_16:
//line 433
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__1, new ImmString("get_frm_idx"));
//line 434
___nl__4 = ((ImmHash)___nl__0).getHashValue()["top"];
//line 434
___nl__4 = ((ImmHash)___nl__4).getHashValue()["vars"];
//line 434
___nl__5 = ((ImmHash)___nl__3).getHashValue()["src"];
//line 434
___nl__4 = (___nl__4 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()];
//line 434
___nl__5 = null;
//line 435
___nl__5 = nl_NL.NL_is_array(___nl__4);

//line 435
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 435
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 435
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_49;}}
//line 435
___nl__6 = c_rt_lib_NL.NL_get_false();
//line 435
___nl__0 = null;
//line 435
___nl__1 = null;
//line 435
___nl__2 = null;
//line 435
___nl__3 = null;
//line 435
___nl__4 = null;
//line 435
___nl__5 = null;
//line 435
if(true) return ___nl__6;
//line 435
___nl__6 = null;
//line 435
if (true) {goto label_49;}
//line 435
label_49:
//line 435
___nl__5 = null;
//line 436
___nl__5 = ((ImmHash)___nl__0).getHashValue()["top"];
//line 436
___nl__5 = ((ImmHash)___nl__5).getHashValue()["vars"];
//line 436
___nl__6 = ((ImmHash)___nl__3).getHashValue()["idx"];
//line 436
___nl__5 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()];
//line 436
___nl__6 = null;
//line 437
___nl__6 = nl_NL.NL_is_sim(___nl__5);

//line 437
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 437
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 437
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_51;}}
//line 437
___nl__7 = c_rt_lib_NL.NL_get_false();
//line 437
___nl__0 = null;
//line 437
___nl__1 = null;
//line 437
___nl__2 = null;
//line 437
___nl__3 = null;
//line 437
___nl__4 = null;
//line 437
___nl__5 = null;
//line 437
___nl__6 = null;
//line 437
if(true) return ___nl__7;
//line 437
___nl__7 = null;
//line 437
if (true) {goto label_51;}
//line 437
label_51:
//line 437
___nl__6 = null;
//line 438
___nl__6 = array_NL.NL_len(___nl__4);

//line 438
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))<(Double.Parse(___nl__6.getValue().ToString())) );
//line 438
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 438
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 438
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_53;}}
//line 438
___nl__7 = c_rt_lib_NL.NL_get_false();
//line 438
___nl__0 = null;
//line 438
___nl__1 = null;
//line 438
___nl__2 = null;
//line 438
___nl__3 = null;
//line 438
___nl__4 = null;
//line 438
___nl__5 = null;
//line 438
___nl__6 = null;
//line 438
if(true) return ___nl__7;
//line 438
___nl__7 = null;
//line 438
if (true) {goto label_53;}
//line 438
label_53:
//line 438
___nl__6 = null;
//line 439
___nl__6 = new ImmDouble(0);
//line 439
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) );
//line 439
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 439
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 439
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_55;}}
//line 439
___nl__7 = c_rt_lib_NL.NL_get_false();
//line 439
___nl__0 = null;
//line 439
___nl__1 = null;
//line 439
___nl__2 = null;
//line 439
___nl__3 = null;
//line 439
___nl__4 = null;
//line 439
___nl__5 = null;
//line 439
___nl__6 = null;
//line 439
if(true) return ___nl__7;
//line 439
___nl__7 = null;
//line 439
if (true) {goto label_55;}
//line 439
label_55:
//line 439
___nl__6 = null;
//line 439
___nl__4 = null;
//line 439
___nl__5 = null;
//line 439
___nl__3 = null;
//line 440
if (true) {goto label_3;}
//line 440
label_17:
//line 440
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__1, new ImmString("set_at_idx"));
//line 441
___nl__4 = ((ImmHash)___nl__0).getHashValue()["top"];
//line 441
___nl__4 = ((ImmHash)___nl__4).getHashValue()["vars"];
//line 441
___nl__5 = ((ImmHash)___nl__3).getHashValue()["src"];
//line 441
___nl__4 = (___nl__4 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()];
//line 441
___nl__5 = null;
//line 442
___nl__5 = nl_NL.NL_is_array(___nl__4);

//line 442
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 442
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 442
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_57;}}
//line 442
___nl__6 = c_rt_lib_NL.NL_get_false();
//line 442
___nl__0 = null;
//line 442
___nl__1 = null;
//line 442
___nl__2 = null;
//line 442
___nl__3 = null;
//line 442
___nl__4 = null;
//line 442
___nl__5 = null;
//line 442
if(true) return ___nl__6;
//line 442
___nl__6 = null;
//line 442
if (true) {goto label_57;}
//line 442
label_57:
//line 442
___nl__5 = null;
//line 443
___nl__5 = ((ImmHash)___nl__0).getHashValue()["top"];
//line 443
___nl__5 = ((ImmHash)___nl__5).getHashValue()["vars"];
//line 443
___nl__6 = ((ImmHash)___nl__3).getHashValue()["idx"];
//line 443
___nl__5 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()];
//line 443
___nl__6 = null;
//line 444
___nl__6 = nl_NL.NL_is_sim(___nl__5);

//line 444
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 444
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 444
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_59;}}
//line 444
___nl__7 = c_rt_lib_NL.NL_get_false();
//line 444
___nl__0 = null;
//line 444
___nl__1 = null;
//line 444
___nl__2 = null;
//line 444
___nl__3 = null;
//line 444
___nl__4 = null;
//line 444
___nl__5 = null;
//line 444
___nl__6 = null;
//line 444
if(true) return ___nl__7;
//line 444
___nl__7 = null;
//line 444
if (true) {goto label_59;}
//line 444
label_59:
//line 444
___nl__6 = null;
//line 445
___nl__6 = array_NL.NL_len(___nl__4);

//line 445
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))<(Double.Parse(___nl__6.getValue().ToString())) );
//line 445
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 445
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 445
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_61;}}
//line 445
___nl__7 = c_rt_lib_NL.NL_get_false();
//line 445
___nl__0 = null;
//line 445
___nl__1 = null;
//line 445
___nl__2 = null;
//line 445
___nl__3 = null;
//line 445
___nl__4 = null;
//line 445
___nl__5 = null;
//line 445
___nl__6 = null;
//line 445
if(true) return ___nl__7;
//line 445
___nl__7 = null;
//line 445
if (true) {goto label_61;}
//line 445
label_61:
//line 445
___nl__6 = null;
//line 445
___nl__4 = null;
//line 445
___nl__5 = null;
//line 445
___nl__3 = null;
//line 446
if (true) {goto label_3;}
//line 446
label_18:
//line 446
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__1, new ImmString("get_val"));
//line 447
___nl__4 = ((ImmHash)___nl__0).getHashValue()["top"];
//line 447
___nl__4 = ((ImmHash)___nl__4).getHashValue()["vars"];
//line 447
___nl__5 = ((ImmHash)___nl__3).getHashValue()["src"];
//line 447
___nl__4 = (___nl__4 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()];
//line 447
___nl__5 = null;
//line 448
___nl__5 = nl_NL.NL_is_hash(___nl__4);

//line 448
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 448
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 448
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_63;}}
//line 448
___nl__6 = c_rt_lib_NL.NL_get_false();
//line 448
___nl__0 = null;
//line 448
___nl__1 = null;
//line 448
___nl__2 = null;
//line 448
___nl__3 = null;
//line 448
___nl__4 = null;
//line 448
___nl__5 = null;
//line 448
if(true) return ___nl__6;
//line 448
___nl__6 = null;
//line 448
if (true) {goto label_63;}
//line 448
label_63:
//line 448
___nl__5 = null;
//line 449
___nl__6 = ((ImmHash)___nl__3).getHashValue()["key"];
//line 449
___nl__5 = nl_NL.NL_is_sim(___nl__6);

//line 449
___nl__6 = null;
//line 449
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 449
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 449
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_65;}}
//line 449
___nl__6 = c_rt_lib_NL.NL_get_false();
//line 449
___nl__0 = null;
//line 449
___nl__1 = null;
//line 449
___nl__2 = null;
//line 449
___nl__3 = null;
//line 449
___nl__4 = null;
//line 449
___nl__5 = null;
//line 449
if(true) return ___nl__6;
//line 449
___nl__6 = null;
//line 449
if (true) {goto label_65;}
//line 449
label_65:
//line 449
___nl__5 = null;
//line 450
___nl__6 = ((ImmHash)___nl__3).getHashValue()["key"];
//line 450
___nl__5 = hash_NL.NL_has_key(___nl__4,___nl__6);

//line 450
___nl__6 = null;
//line 450
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 450
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 450
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_67;}}
//line 450
___nl__6 = c_rt_lib_NL.NL_get_false();
//line 450
___nl__0 = null;
//line 450
___nl__1 = null;
//line 450
___nl__2 = null;
//line 450
___nl__3 = null;
//line 450
___nl__4 = null;
//line 450
___nl__5 = null;
//line 450
if(true) return ___nl__6;
//line 450
___nl__6 = null;
//line 450
if (true) {goto label_67;}
//line 450
label_67:
//line 450
___nl__5 = null;
//line 450
___nl__4 = null;
//line 450
___nl__3 = null;
//line 451
if (true) {goto label_3;}
//line 451
label_19:
//line 451
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__1, new ImmString("set_val"));
//line 452
___nl__4 = ((ImmHash)___nl__0).getHashValue()["top"];
//line 452
___nl__4 = ((ImmHash)___nl__4).getHashValue()["vars"];
//line 452
___nl__5 = ((ImmHash)___nl__3).getHashValue()["src"];
//line 452
___nl__4 = (___nl__4 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()];
//line 452
___nl__5 = null;
//line 453
___nl__5 = nl_NL.NL_is_hash(___nl__4);

//line 453
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 453
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 453
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_69;}}
//line 453
___nl__6 = c_rt_lib_NL.NL_get_false();
//line 453
___nl__0 = null;
//line 453
___nl__1 = null;
//line 453
___nl__2 = null;
//line 453
___nl__3 = null;
//line 453
___nl__4 = null;
//line 453
___nl__5 = null;
//line 453
if(true) return ___nl__6;
//line 453
___nl__6 = null;
//line 453
if (true) {goto label_69;}
//line 453
label_69:
//line 453
___nl__5 = null;
//line 454
___nl__6 = ((ImmHash)___nl__3).getHashValue()["key"];
//line 454
___nl__5 = nl_NL.NL_is_sim(___nl__6);

//line 454
___nl__6 = null;
//line 454
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 454
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 454
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_71;}}
//line 454
___nl__6 = c_rt_lib_NL.NL_get_false();
//line 454
___nl__0 = null;
//line 454
___nl__1 = null;
//line 454
___nl__2 = null;
//line 454
___nl__3 = null;
//line 454
___nl__4 = null;
//line 454
___nl__5 = null;
//line 454
if(true) return ___nl__6;
//line 454
___nl__6 = null;
//line 454
if (true) {goto label_71;}
//line 454
label_71:
//line 454
___nl__5 = null;
//line 454
___nl__4 = null;
//line 454
___nl__3 = null;
//line 455
if (true) {goto label_3;}
//line 455
label_20:
//line 455
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__1, new ImmString("ov_mk"));
//line 456
___nl__5 = ((ImmHash)___nl__3).getHashValue()["name"];
//line 456
___nl__4 = nl_NL.NL_is_sim(___nl__5);

//line 456
___nl__5 = null;
//line 456
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 456
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 456
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_73;}}
//line 456
___nl__5 = c_rt_lib_NL.NL_get_false();
//line 456
___nl__0 = null;
//line 456
___nl__1 = null;
//line 456
___nl__2 = null;
//line 456
___nl__3 = null;
//line 456
___nl__4 = null;
//line 456
if(true) return ___nl__5;
//line 456
___nl__5 = null;
//line 456
if (true) {goto label_73;}
//line 456
label_73:
//line 456
___nl__4 = null;
//line 456
___nl__3 = null;
//line 457
if (true) {goto label_3;}
//line 457
label_21:
//line 457
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__1, new ImmString("prt_lbl"));
//line 457
___nl__3 = null;
//line 458
if (true) {goto label_3;}
//line 458
label_22:
//line 458
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__1, new ImmString("if_goto"));
//line 459
___nl__4 = ((ImmHash)___nl__0).getHashValue()["top"];
//line 459
___nl__4 = ((ImmHash)___nl__4).getHashValue()["vars"];
//line 459
___nl__5 = ((ImmHash)___nl__3).getHashValue()["src"];
//line 459
___nl__4 = (___nl__4 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()];
//line 459
___nl__5 = null;
//line 460
___nl__5 = nl_NL.NL_is_variant(___nl__4);

//line 460
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 460
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 460
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_75;}}
//line 460
___nl__6 = c_rt_lib_NL.NL_get_false();
//line 460
___nl__0 = null;
//line 460
___nl__1 = null;
//line 460
___nl__2 = null;
//line 460
___nl__3 = null;
//line 460
___nl__4 = null;
//line 460
___nl__5 = null;
//line 460
if(true) return ___nl__6;
//line 460
___nl__6 = null;
//line 460
if (true) {goto label_75;}
//line 460
label_75:
//line 460
___nl__5 = null;
//line 461
___nl__5 = ___nl__4;
//line 461
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("TRUE"));
//line 461
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_78;}}
//line 461
___nl__5 = ___nl__4;
//line 461
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("FALSE"));
//line 461
label_78:
//line 461
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 461
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 461
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_77;}}
//line 461
___nl__6 = c_rt_lib_NL.NL_get_false();
//line 461
___nl__0 = null;
//line 461
___nl__1 = null;
//line 461
___nl__2 = null;
//line 461
___nl__3 = null;
//line 461
___nl__4 = null;
//line 461
___nl__5 = null;
//line 461
if(true) return ___nl__6;
//line 461
___nl__6 = null;
//line 461
if (true) {goto label_77;}
//line 461
label_77:
//line 461
___nl__5 = null;
//line 461
___nl__4 = null;
//line 461
___nl__3 = null;
//line 462
if (true) {goto label_3;}
//line 462
label_23:
//line 462
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__1, new ImmString("goto"));
//line 462
___nl__3 = null;
//line 463
if (true) {goto label_3;}
//line 463
label_24:
//line 463
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__1, new ImmString("clear"));
//line 463
___nl__3 = null;
//line 464
if (true) {goto label_3;}
//line 464
label_3:
//line 464
___nl__2 = null;
//line 465
___nl__2 = c_rt_lib_NL.NL_get_true();
//line 465
___nl__0 = null;
//line 465
___nl__1 = null;
//line 465
if(true) return ___nl__2;
//line 465
___nl__2 = null;
//line 465
___nl__0 = null;
//line 465
___nl__1 = null;
//line 465
if(true) return null;
}

public static Imm NL_finish_callback(Imm ___arg__0, Imm ___arg__1, ImmRef ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.getValue().clone();
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
//line 469
___nl__3 = ((ImmHash)___nl__2).getHashValue()["rstate"];
//line 469
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("callback"));
//line 469
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 469
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 469
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 469
___nl__4 = new ImmArray(new Imm[0]);
//line 469
c_rt_lib_NL.NL_die();
//line 469
if (true) {goto label_2;}
//line 469
label_2:
//line 469
___nl__3 = null;
//line 469
___nl__4 = null;
//line 470
___nl__3 = ((ImmHash)___nl__2).getHashValue()["rstate"];
//line 470
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("callback"));
//line 470
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__0.toString()));
//line 470
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 470
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 470
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_4;}}
//line 470
___nl__4 = new ImmArray(new Imm[0]);
//line 470
c_rt_lib_NL.NL_die();
//line 470
if (true) {goto label_4;}
//line 470
label_4:
//line 470
___nl__3 = null;
//line 470
___nl__4 = null;
//line 471
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("ok"));
//line 471
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_6;}}
//line 477
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("err"));
//line 477
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_7;}}
//line 477
___nl__3 = new ImmString("NOMATCHALERT");
//line 477
___nl__3 = new ImmArray(new Imm[] {___nl__3,___nl__1,});
//line 477
c_rt_lib_NL.NL_die();
//line 471
label_6:
//line 471
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__1, new ImmString("ok"));
//line 472
___nl__5 = new ImmString("top");
//line 472
___nl__5 = c_rt_lib_NL.NL_get_ref_hash(___nl__2,___nl__5);

//line 472
___nl__6 = new ImmString("next");
//line 472
___nl__6 = c_rt_lib_NL.NL_get_ref_hash(___nl__5,___nl__6);

//line 472
___nl__7 = new ImmDouble(1);
//line 472
___nl__6 = new ImmDouble((Double.Parse(___nl__6.getValue().ToString()))+(Double.Parse(___nl__7.getValue().ToString())));
//line 472
___nl__8 = new ImmString("next");
//line 472
___ref______nl__5 = new ImmRef(___nl__5);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__5,___nl__8,___nl__6);
___nl__5 = ___ref______nl__5.getValue();

//line 472
___nl__8 = new ImmString("top");
//line 472
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__2,___nl__8,___nl__5);
___nl__2 = ___ref______nl__2.getValue();

//line 472
___nl__8 = null;
//line 472
___nl__5 = null;
//line 472
___nl__6 = null;
//line 472
___nl__7 = null;
//line 473
___nl__5 = ((ImmHash)___nl__2).getHashValue()["read_dest"];
//line 473
___nl__6 = new ImmString("");
//line 473
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__5.toString().Equals(___nl__6.toString()));
//line 473
___nl__6 = null;
//line 473
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 473
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 473
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_9;}}
//line 473
___nl__6 = new ImmString("top");
//line 473
___nl__6 = c_rt_lib_NL.NL_get_ref_hash(___nl__2,___nl__6);

//line 473
___nl__7 = new ImmString("vars");
//line 473
___nl__7 = c_rt_lib_NL.NL_get_ref_hash(___nl__6,___nl__7);

//line 473
___nl__9 = ((ImmHash)___nl__2).getHashValue()["read_dest"];
//line 473
___nl__8 = ___nl__4;
//line 473
(___nl__7 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()] = ___nl__8;
//line 473
___nl__10 = new ImmString("vars");
//line 473
___ref______nl__6 = new ImmRef(___nl__6);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__6,___nl__10,___nl__7);
___nl__6 = ___ref______nl__6.getValue();

//line 473
___nl__10 = new ImmString("top");
//line 473
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__2,___nl__10,___nl__6);
___nl__2 = ___ref______nl__2.getValue();

//line 473
___nl__10 = null;
//line 473
___nl__6 = null;
//line 473
___nl__7 = null;
//line 473
___nl__8 = null;
//line 473
___nl__9 = null;
//line 473
if (true) {goto label_9;}
//line 473
label_9:
//line 473
___nl__5 = null;
//line 474
___nl__5 = new ImmString("");
//line 474
___nl__6 = ___nl__5;
//line 474
((ImmHash)___nl__2).set("read_dest", ___nl__6);
//line 474
___nl__5 = null;
//line 474
___nl__6 = null;
//line 475
___nl__5 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("running"));
//line 475
___nl__6 = ___nl__5;
//line 475
((ImmHash)___nl__2).set("rstate", ___nl__6);
//line 475
___nl__5 = null;
//line 475
___nl__6 = null;
//line 476
___ref______nl__2 = new ImmRef(___nl__2);
interpreter_NL.NL_handle_new_declarations_priv(___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue();

//line 476
___nl__4 = null;
//line 477
if (true) {goto label_5;}
//line 477
label_7:
//line 477
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__1, new ImmString("err"));
//line 478
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("error"), ___nl__4);
//line 478
___nl__6 = ___nl__5;
//line 478
((ImmHash)___nl__2).set("rstate", ___nl__6);
//line 478
___nl__5 = null;
//line 478
___nl__6 = null;
//line 478
___nl__4 = null;
//line 479
if (true) {goto label_5;}
//line 479
label_5:
//line 479
___nl__3 = null;
//line 479
___nl__0 = null;
//line 479
___nl__1 = null;
//line 479
___arg__2.setValue(___nl__2);if(true) return null;
}

public static Imm NL_finish_read(Imm ___arg__0, ImmRef ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();
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
//line 483
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("ok"));
//line 483
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 489
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("err"));
//line 489
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_3;}}
//line 489
___nl__2 = new ImmString("NOMATCHALERT");
//line 489
___nl__2 = new ImmArray(new Imm[] {___nl__2,___nl__0,});
//line 489
c_rt_lib_NL.NL_die();
//line 483
label_2:
//line 483
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("ok"));
//line 484
___nl__4 = new ImmString("top");
//line 484
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__4);

//line 484
___nl__5 = new ImmString("next");
//line 484
___nl__5 = c_rt_lib_NL.NL_get_ref_hash(___nl__4,___nl__5);

//line 484
___nl__6 = new ImmDouble(1);
//line 484
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString())));
//line 484
___nl__7 = new ImmString("next");
//line 484
___ref______nl__4 = new ImmRef(___nl__4);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__4,___nl__7,___nl__5);
___nl__4 = ___ref______nl__4.getValue();

//line 484
___nl__7 = new ImmString("top");
//line 484
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__7,___nl__4);
___nl__1 = ___ref______nl__1.getValue();

//line 484
___nl__7 = null;
//line 484
___nl__4 = null;
//line 484
___nl__5 = null;
//line 484
___nl__6 = null;
//line 485
___nl__4 = ((ImmHash)___nl__1).getHashValue()["read_dest"];
//line 485
___nl__5 = new ImmString("");
//line 485
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__4.toString().Equals(___nl__5.toString()));
//line 485
___nl__5 = null;
//line 485
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 485
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 485
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_5;}}
//line 485
___nl__5 = new ImmString("top");
//line 485
___nl__5 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__5);

//line 485
___nl__6 = new ImmString("vars");
//line 485
___nl__6 = c_rt_lib_NL.NL_get_ref_hash(___nl__5,___nl__6);

//line 485
___nl__8 = ((ImmHash)___nl__1).getHashValue()["read_dest"];
//line 485
___nl__7 = ___nl__3;
//line 485
(___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()] = ___nl__7;
//line 485
___nl__9 = new ImmString("vars");
//line 485
___ref______nl__5 = new ImmRef(___nl__5);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__5,___nl__9,___nl__6);
___nl__5 = ___ref______nl__5.getValue();

//line 485
___nl__9 = new ImmString("top");
//line 485
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__9,___nl__5);
___nl__1 = ___ref______nl__1.getValue();

//line 485
___nl__9 = null;
//line 485
___nl__5 = null;
//line 485
___nl__6 = null;
//line 485
___nl__7 = null;
//line 485
___nl__8 = null;
//line 485
if (true) {goto label_5;}
//line 485
label_5:
//line 485
___nl__4 = null;
//line 486
___nl__4 = new ImmString("");
//line 486
___nl__5 = ___nl__4;
//line 486
((ImmHash)___nl__1).set("read_dest", ___nl__5);
//line 486
___nl__4 = null;
//line 486
___nl__5 = null;
//line 487
___nl__4 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("running"));
//line 487
___nl__5 = ___nl__4;
//line 487
((ImmHash)___nl__1).set("rstate", ___nl__5);
//line 487
___nl__4 = null;
//line 487
___nl__5 = null;
//line 488
___ref______nl__1 = new ImmRef(___nl__1);
interpreter_NL.NL_handle_new_declarations_priv(___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 488
___nl__3 = null;
//line 489
if (true) {goto label_1;}
//line 489
label_3:
//line 489
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("err"));
//line 490
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("error"), ___nl__3);
//line 490
___nl__5 = ___nl__4;
//line 490
((ImmHash)___nl__1).set("rstate", ___nl__5);
//line 490
___nl__4 = null;
//line 490
___nl__5 = null;
//line 490
___nl__3 = null;
//line 491
if (true) {goto label_1;}
//line 491
label_1:
//line 491
___nl__2 = null;
//line 491
___nl__0 = null;
//line 491
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_handle_normal_call_priv(Imm ___arg__0, Imm ___arg__1, ImmRef ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.getValue().clone();
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
//line 494
___nl__3 = new ImmString("top");
//line 494
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__2,___nl__3);

//line 494
___nl__4 = new ImmString("next");
//line 494
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__3,___nl__4);

//line 494
___nl__5 = new ImmDouble(1);
//line 494
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))-(Double.Parse(___nl__5.getValue().ToString())));
//line 494
___nl__6 = new ImmString("next");
//line 494
___ref______nl__3 = new ImmRef(___nl__3);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__3,___nl__6,___nl__4);
___nl__3 = ___ref______nl__3.getValue();

//line 494
___nl__6 = new ImmString("top");
//line 494
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__2,___nl__6,___nl__3);
___nl__2 = ___ref______nl__2.getValue();

//line 494
___nl__6 = null;
//line 494
___nl__3 = null;
//line 494
___nl__4 = null;
//line 494
___nl__5 = null;
//line 496
___nl__4 = ((ImmHash)___nl__0).getHashValue()["mod"];
//line 496
___nl__5 = new ImmString("");
//line 496
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__4.toString().Equals(___nl__5.toString()));
//line 496
___nl__5 = null;
//line 496
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 496
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 497
___nl__5 = ((ImmHash)___nl__2).getHashValue()["top"];
//line 497
___nl__5 = ((ImmHash)___nl__5).getHashValue()["module_name"];
//line 497
___nl__3 = ___nl__5;
//line 497
___nl__5 = null;
//line 498
if (true) {goto label_1;}
//line 498
label_2:
//line 499
___nl__5 = ((ImmHash)___nl__0).getHashValue()["mod"];
//line 499
___nl__3 = ___nl__5;
//line 499
___nl__5 = null;
//line 500
if (true) {goto label_1;}
//line 500
label_1:
//line 500
___nl__4 = null;
//line 501
___nl__5 = ((ImmHash)___nl__2).getHashValue()["functions"];
//line 501
___nl__4 = hash_NL.NL_get_value(___nl__5,___nl__1);

//line 501
___nl__5 = null;
//line 502
___nl__6 = ((ImmHash)___nl__4).getHashValue()["reg_size"];
//line 502
___nl__5 = interpreter_NL.NL_build_registers_priv(___nl__6);

//line 502
___nl__6 = null;
//line 503
__function_map = new Dictionary<String, Imm>();
___nl__6 = new ImmHash(__function_map);
//line 504
__function_map = new Dictionary<String, Imm>();
___nl__7 = new ImmHash(__function_map);
//line 505
___nl__8 = new ImmDouble(0);
//line 506
___nl__10 = ((ImmHash)___nl__0).getHashValue()["args"];
//line 506
___nl__9 = array_NL.NL_len(___nl__10);

//line 506
___nl__10 = null;
//line 506
___nl__10 = new ImmDouble(0);
//line 506
___nl__11 = new ImmDouble(1);
//line 506
label_5:
//line 506
___nl__12 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__10.getValue().ToString()))>=(Double.Parse(___nl__9.getValue().ToString())) );
//line 506
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_3;}}
//line 507
___nl__13 = ((ImmHash)___nl__0).getHashValue()["args"];
//line 507
___nl__13 = (___nl__13 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()];
//line 509
___nl__15 = c_rt_lib_NL.NL_ov_is(___nl__13, new ImmString("val"));
//line 509
if (c_rt_lib_NL.NL_check_true_native(___nl__15)) {if (true) {goto label_7;}}
//line 511
___nl__15 = c_rt_lib_NL.NL_ov_is(___nl__13, new ImmString("ref"));
//line 511
if (c_rt_lib_NL.NL_check_true_native(___nl__15)) {if (true) {goto label_8;}}
//line 511
___nl__15 = new ImmString("NOMATCHALERT");
//line 511
___nl__15 = new ImmArray(new Imm[] {___nl__15,___nl__13,});
//line 511
c_rt_lib_NL.NL_die();
//line 509
label_7:
//line 509
___nl__16 = c_rt_lib_NL.NL_ov_as(___nl__13, new ImmString("val"));
//line 510
___nl__17 = ((ImmHash)___nl__2).getHashValue()["top"];
//line 510
___nl__17 = ((ImmHash)___nl__17).getHashValue()["vars"];
//line 510
___nl__17 = (___nl__17 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__16).getDoubleValue()];
//line 510
___nl__14 = ___nl__17;
//line 510
___nl__17 = null;
//line 510
___nl__16 = null;
//line 511
if (true) {goto label_6;}
//line 511
label_8:
//line 511
___nl__16 = c_rt_lib_NL.NL_ov_as(___nl__13, new ImmString("ref"));
//line 512
___nl__17 = ((ImmHash)___nl__2).getHashValue()["top"];
//line 512
___nl__17 = ((ImmHash)___nl__17).getHashValue()["vars"];
//line 512
___nl__17 = (___nl__17 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__16).getDoubleValue()];
//line 512
___nl__14 = ___nl__17;
//line 512
___nl__17 = null;
//line 513
___ref______nl__7 = new ImmRef(___nl__7);
hash_NL.NL_set_value(___ref______nl__7,___nl__8,___nl__16);
___nl__7 = ___ref______nl__7.getValue();

//line 513
___nl__16 = null;
//line 514
if (true) {goto label_6;}
//line 514
label_6:
//line 514
___nl__15 = null;
//line 515
___nl__15 = ___nl__14;
//line 515
(___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()] = ___nl__15;
//line 515
___nl__15 = null;
//line 516
___nl__15 = new ImmDouble(1);
//line 516
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))+(Double.Parse(___nl__15.getValue().ToString())));
//line 516
___nl__15 = null;
//line 516
___nl__13 = null;
//line 516
___nl__14 = null;
//line 517
___nl__10 = new ImmDouble((Double.Parse(___nl__10.getValue().ToString()))+(Double.Parse(___nl__11.getValue().ToString())));
//line 517
if (true) {goto label_5;}
//line 517
label_3:
//line 517
___nl__9 = null;
//line 517
___nl__10 = null;
//line 517
___nl__11 = null;
//line 517
___nl__12 = null;
//line 518
___nl__9 = new ImmString("stack");
//line 518
___nl__9 = c_rt_lib_NL.NL_get_ref_hash(___nl__2,___nl__9);

//line 518
___nl__10 = ((ImmHash)___nl__2).getHashValue()["top"];
//line 518
___ref______nl__9 = new ImmRef(___nl__9);
array_NL.NL_push(___ref______nl__9,___nl__10);
___nl__9 = ___ref______nl__9.getValue();

//line 518
___nl__10 = null;
//line 518
___nl__10 = new ImmString("stack");
//line 518
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__2,___nl__10,___nl__9);
___nl__2 = ___ref______nl__2.getValue();

//line 518
___nl__10 = null;
//line 518
___nl__9 = null;
//line 519
___nl__9 = ___nl__4;
//line 519
((ImmHash)___nl__2).set("func", ___nl__9);
//line 519
___nl__9 = null;
//line 520
___nl__10 = new ImmDouble(0);
//line 520
___nl__11 = ((ImmHash)___nl__0).getHashValue()["dest"];
//line 520
__function_map = new Dictionary<String, Imm>();
__function_map.Add("func_key",___nl__1);
__function_map.Add("module_name",___nl__3);
__function_map.Add("next",___nl__10);
__function_map.Add("vars",___nl__5);
__function_map.Add("ret",___nl__11);
__function_map.Add("code_vars",___nl__6);
__function_map.Add("ref_arguments",___nl__7);
___nl__9 = new ImmHash(__function_map);
//line 520
___nl__10 = null;
//line 520
___nl__11 = null;
//line 520
___nl__10 = ___nl__9;
//line 520
((ImmHash)___nl__2).set("top", ___nl__10);
//line 520
___nl__9 = null;
//line 520
___nl__10 = null;
//line 529
___nl__9 = new ImmDouble(1);
//line 529
___nl__9 = new ImmDouble(-((ImmDouble)___nl__9).getDoubleValue());
//line 529
___nl__10 = ___nl__9;
//line 529
((ImmHash)___nl__2).set("instruction_nr", ___nl__10);
//line 529
___nl__9 = null;
//line 529
___nl__10 = null;
//line 529
___nl__3 = null;
//line 529
___nl__4 = null;
//line 529
___nl__5 = null;
//line 529
___nl__6 = null;
//line 529
___nl__7 = null;
//line 529
___nl__8 = null;
//line 529
___nl__0 = null;
//line 529
___nl__1 = null;
//line 529
___arg__2.setValue(___nl__2);if(true) return null;
}

private static Imm NL_handle_extern_call_priv(Imm ___arg__0, ImmRef ___arg__1) {
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
//line 533
___nl__2 = new ImmArray(new Imm[0]);
//line 534
___nl__3 = ((ImmHash)___nl__0).getHashValue()["args"];
//line 534
___nl__5 = new ImmDouble(0);
//line 534
___nl__6 = new ImmDouble(1);
//line 534
___nl__7 = c_rt_lib_NL.NL_array_len(___nl__3);

//line 534
label_3:
//line 534
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) );
//line 534
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_1;}}
//line 534
___nl__4 = (___nl__3 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()];
//line 536
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("val"));
//line 536
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_5;}}
//line 538
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("ref"));
//line 538
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_6;}}
//line 538
___nl__10 = new ImmString("NOMATCHALERT");
//line 538
___nl__10 = new ImmArray(new Imm[] {___nl__10,___nl__4,});
//line 538
c_rt_lib_NL.NL_die();
//line 536
label_5:
//line 536
___nl__11 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("val"));
//line 537
___nl__12 = ((ImmHash)___nl__1).getHashValue()["top"];
//line 537
___nl__12 = ((ImmHash)___nl__12).getHashValue()["vars"];
//line 537
___nl__12 = (___nl__12 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__11).getDoubleValue()];
//line 537
___nl__9 = ___nl__12;
//line 537
___nl__12 = null;
//line 537
___nl__11 = null;
//line 538
if (true) {goto label_4;}
//line 538
label_6:
//line 538
___nl__11 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("ref"));
//line 539
___nl__12 = ((ImmHash)___nl__1).getHashValue()["top"];
//line 539
___nl__12 = ((ImmHash)___nl__12).getHashValue()["vars"];
//line 539
___nl__12 = (___nl__12 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__11).getDoubleValue()];
//line 539
___nl__9 = ___nl__12;
//line 539
___nl__12 = null;
//line 539
___nl__11 = null;
//line 540
if (true) {goto label_4;}
//line 540
label_4:
//line 540
___nl__10 = null;
//line 541
___ref______nl__2 = new ImmRef(___nl__2);
array_NL.NL_push(___ref______nl__2,___nl__9);
___nl__2 = ___ref______nl__2.getValue();

//line 541
___nl__9 = null;
//line 542
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString())));
//line 542
if (true) {goto label_3;}
//line 542
label_1:
//line 542
___nl__3 = null;
//line 542
___nl__4 = null;
//line 542
___nl__5 = null;
//line 542
___nl__6 = null;
//line 542
___nl__7 = null;
//line 542
___nl__8 = null;
//line 544
___nl__4 = ((ImmHash)___nl__1).getHashValue()["known_exec_func"];
//line 544
___nl__5 = ((ImmHash)___nl__0).getHashValue()["mod"];
//line 544
___nl__6 = new ImmString("::");
//line 544
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 544
___nl__6 = null;
//line 544
___nl__6 = ((ImmHash)___nl__0).getHashValue()["fun_name"];
//line 544
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 544
___nl__6 = null;
//line 544
___nl__3 = hash_NL.NL_get_value(___nl__4,___nl__5);

//line 544
___nl__5 = null;
//line 544
___nl__4 = null;
//line 546
___nl__5 = ((ImmHash)___nl__3).getHashValue()["args"];
//line 546
___nl__4 = array_NL.NL_len(___nl__5);

//line 546
___nl__5 = null;
//line 546
___nl__5 = array_NL.NL_len(___nl__2);

//line 546
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString())) !=((Double.Parse(___nl__5.getValue().ToString())))  );
//line 546
___nl__5 = null;
//line 546
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 546
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_8;}}
//line 547
___nl__5 = new ImmString("incorrect console call");
//line 547
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("error"), ___nl__5);
//line 547
___nl__6 = ___nl__5;
//line 547
((ImmHash)___nl__1).set("rstate", ___nl__6);
//line 547
___nl__5 = null;
//line 547
___nl__6 = null;
//line 548
if (true) {goto label_8;}
//line 548
label_8:
//line 548
___nl__4 = null;
//line 549
___nl__4 = array_NL.NL_len(___nl__2);

//line 549
___nl__5 = new ImmDouble(0);
//line 549
___nl__6 = new ImmDouble(1);
//line 549
label_11:
//line 549
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__4.getValue().ToString())) );
//line 549
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_9;}}
//line 550
___nl__8 = ((ImmHash)___nl__3).getHashValue()["args"];
//line 550
___nl__8 = (___nl__8 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()];
//line 550
___nl__9 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()];
//line 550
ptd_NL.NL_ensure_only_dynamic(___nl__8,___nl__9);

//line 550
___nl__9 = null;
//line 550
___nl__8 = null;
//line 551
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString())));
//line 551
if (true) {goto label_11;}
//line 551
label_9:
//line 551
___nl__4 = null;
//line 551
___nl__5 = null;
//line 551
___nl__6 = null;
//line 551
___nl__7 = null;
//line 552
___nl__5 = ((ImmHash)___nl__3).getHashValue()["func"];
//line 552
___ref______nl__2 = new ImmRef(___nl__2);
___nl__4 = func_NL.NL_exec_ref(___nl__5,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue();

//line 552
___nl__5 = null;
//line 553
___nl__5 = ((ImmHash)___nl__3).getHashValue()["type"];
//line 553
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("sequential"));
//line 553
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_13;}}
//line 562
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("callback"));
//line 562
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_14;}}
//line 562
___nl__6 = new ImmString("NOMATCHALERT");
//line 562
___nl__6 = new ImmArray(new Imm[] {___nl__6,___nl__5,});
//line 562
c_rt_lib_NL.NL_die();
//line 553
label_13:
//line 554
___nl__8 = ((ImmHash)___nl__0).getHashValue()["args"];
//line 554
___nl__7 = array_NL.NL_len(___nl__8);

//line 554
___nl__8 = null;
//line 554
___nl__8 = new ImmDouble(0);
//line 554
___nl__9 = new ImmDouble(1);
//line 554
label_17:
//line 554
___nl__10 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) );
//line 554
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_15;}}
//line 555
___nl__11 = ((ImmHash)___nl__0).getHashValue()["args"];
//line 555
___nl__11 = (___nl__11 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 556
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("val"));
//line 556
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_19;}}
//line 557
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("ref"));
//line 557
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_20;}}
//line 557
___nl__12 = new ImmString("NOMATCHALERT");
//line 557
___nl__12 = new ImmArray(new Imm[] {___nl__12,___nl__11,});
//line 557
c_rt_lib_NL.NL_die();
//line 556
label_19:
//line 556
___nl__13 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("val"));
//line 556
___nl__13 = null;
//line 557
if (true) {goto label_18;}
//line 557
label_20:
//line 557
___nl__13 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("ref"));
//line 558
___nl__14 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 558
___nl__15 = new ImmString("top");
//line 558
___nl__15 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__15);

//line 558
___nl__16 = new ImmString("vars");
//line 558
___nl__16 = c_rt_lib_NL.NL_get_ref_hash(___nl__15,___nl__16);

//line 558
___nl__17 = ___nl__14;
//line 558
(___nl__16 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__13).getDoubleValue()] = ___nl__17;
//line 558
___nl__18 = new ImmString("vars");
//line 558
___ref______nl__15 = new ImmRef(___nl__15);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__15,___nl__18,___nl__16);
___nl__15 = ___ref______nl__15.getValue();

//line 558
___nl__18 = new ImmString("top");
//line 558
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__18,___nl__15);
___nl__1 = ___ref______nl__1.getValue();

//line 558
___nl__18 = null;
//line 558
___nl__14 = null;
//line 558
___nl__15 = null;
//line 558
___nl__16 = null;
//line 558
___nl__17 = null;
//line 558
___nl__13 = null;
//line 559
if (true) {goto label_18;}
//line 559
label_18:
//line 559
___nl__12 = null;
//line 559
___nl__11 = null;
//line 560
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))+(Double.Parse(___nl__9.getValue().ToString())));
//line 560
if (true) {goto label_17;}
//line 560
label_15:
//line 560
___nl__7 = null;
//line 560
___nl__8 = null;
//line 560
___nl__9 = null;
//line 560
___nl__10 = null;
//line 561
___nl__7 = ((ImmHash)___nl__0).getHashValue()["dest"];
//line 561
___nl__8 = new ImmString("");
//line 561
___nl__7 = c_rt_lib_NL.NL_native_to_nl(___nl__7.toString().Equals(___nl__8.toString()));
//line 561
___nl__8 = null;
//line 561
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 561
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 561
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_22;}}
//line 561
___nl__8 = new ImmString("top");
//line 561
___nl__8 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__8);

//line 561
___nl__9 = new ImmString("vars");
//line 561
___nl__9 = c_rt_lib_NL.NL_get_ref_hash(___nl__8,___nl__9);

//line 561
___nl__11 = ((ImmHash)___nl__0).getHashValue()["dest"];
//line 561
___nl__10 = ___nl__4;
//line 561
(___nl__9 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__11).getDoubleValue()] = ___nl__10;
//line 561
___nl__12 = new ImmString("vars");
//line 561
___ref______nl__8 = new ImmRef(___nl__8);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__8,___nl__12,___nl__9);
___nl__8 = ___ref______nl__8.getValue();

//line 561
___nl__12 = new ImmString("top");
//line 561
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__12,___nl__8);
___nl__1 = ___ref______nl__1.getValue();

//line 561
___nl__12 = null;
//line 561
___nl__8 = null;
//line 561
___nl__9 = null;
//line 561
___nl__10 = null;
//line 561
___nl__11 = null;
//line 561
if (true) {goto label_22;}
//line 561
label_22:
//line 561
___nl__7 = null;
//line 562
if (true) {goto label_12;}
//line 562
label_14:
//line 563
___nl__7 = ((ImmHash)___nl__0).getHashValue()["mod"];
//line 563
___nl__8 = new ImmString("::");
//line 563
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 563
___nl__8 = null;
//line 563
___nl__8 = ((ImmHash)___nl__0).getHashValue()["fun_name"];
//line 563
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 563
___nl__8 = null;
//line 563
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("callback"), ___nl__7);
//line 563
___nl__8 = ___nl__7;
//line 563
((ImmHash)___nl__1).set("rstate", ___nl__8);
//line 563
___nl__7 = null;
//line 563
___nl__8 = null;
//line 564
___nl__7 = ((ImmHash)___nl__0).getHashValue()["dest"];
//line 564
___nl__8 = ___nl__7;
//line 564
((ImmHash)___nl__1).set("read_dest", ___nl__8);
//line 564
___nl__7 = null;
//line 564
___nl__8 = null;
//line 565
___nl__7 = new ImmDouble(1);
//line 565
___nl__7 = new ImmDouble(-((ImmDouble)___nl__7).getDoubleValue());
//line 565
___nl__8 = ___nl__7;
//line 565
((ImmHash)___nl__1).set("instruction_nr", ___nl__8);
//line 565
___nl__7 = null;
//line 565
___nl__8 = null;
//line 566
___nl__7 = new ImmString("top");
//line 566
___nl__7 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__7);

//line 566
___nl__8 = new ImmString("next");
//line 566
___nl__8 = c_rt_lib_NL.NL_get_ref_hash(___nl__7,___nl__8);

//line 566
___nl__9 = new ImmDouble(1);
//line 566
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))-(Double.Parse(___nl__9.getValue().ToString())));
//line 566
___nl__10 = new ImmString("next");
//line 566
___ref______nl__7 = new ImmRef(___nl__7);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__7,___nl__10,___nl__8);
___nl__7 = ___ref______nl__7.getValue();

//line 566
___nl__10 = new ImmString("top");
//line 566
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__10,___nl__7);
___nl__1 = ___ref______nl__1.getValue();

//line 566
___nl__10 = null;
//line 566
___nl__7 = null;
//line 566
___nl__8 = null;
//line 566
___nl__9 = null;
//line 567
if (true) {goto label_12;}
//line 567
label_12:
//line 567
___nl__5 = null;
//line 567
___nl__6 = null;
//line 567
___nl__2 = null;
//line 567
___nl__3 = null;
//line 567
___nl__4 = null;
//line 567
___nl__0 = null;
//line 567
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_SINGLETON_get_compiler_functions_priv() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 570
__function_map = new Dictionary<String, Imm>();
___nl__0 = new ImmHash(__function_map);
//line 571
___nl__1 = new ImmString("array::push");
//line 571
___nl__2 = new ImmString("");
//line 571
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 571
___nl__2 = null;
//line 571
___nl__1 = null;
//line 572
___nl__1 = new ImmString("array::pop");
//line 572
___nl__2 = new ImmString("");
//line 572
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 572
___nl__2 = null;
//line 572
___nl__1 = null;
//line 573
___nl__1 = new ImmString("array::subarray");
//line 573
___nl__2 = new ImmString("");
//line 573
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 573
___nl__2 = null;
//line 573
___nl__1 = null;
//line 574
___nl__1 = new ImmString("array::append");
//line 574
___nl__2 = new ImmString("");
//line 574
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 574
___nl__2 = null;
//line 574
___nl__1 = null;
//line 575
___nl__1 = new ImmString("array::len");
//line 575
___nl__2 = new ImmString("");
//line 575
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 575
___nl__2 = null;
//line 575
___nl__1 = null;
//line 576
___nl__1 = new ImmString("array::cmp");
//line 576
___nl__2 = new ImmString("");
//line 576
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 576
___nl__2 = null;
//line 576
___nl__1 = null;
//line 577
___nl__1 = new ImmString("array::sort");
//line 577
___nl__2 = new ImmString("");
//line 577
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 577
___nl__2 = null;
//line 577
___nl__1 = null;
//line 579
___nl__1 = new ImmString("hash::get_value");
//line 579
___nl__2 = new ImmString("");
//line 579
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 579
___nl__2 = null;
//line 579
___nl__1 = null;
//line 580
___nl__1 = new ImmString("hash::has_key");
//line 580
___nl__2 = new ImmString("");
//line 580
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 580
___nl__2 = null;
//line 580
___nl__1 = null;
//line 581
___nl__1 = new ImmString("hash::set_value");
//line 581
___nl__2 = new ImmString("");
//line 581
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 581
___nl__2 = null;
//line 581
___nl__1 = null;
//line 582
___nl__1 = new ImmString("hash::delete");
//line 582
___nl__2 = new ImmString("");
//line 582
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 582
___nl__2 = null;
//line 582
___nl__1 = null;
//line 583
___nl__1 = new ImmString("hash::size");
//line 583
___nl__2 = new ImmString("");
//line 583
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 583
___nl__2 = null;
//line 583
___nl__1 = null;
//line 584
___nl__1 = new ImmString("hash::keys");
//line 584
___nl__2 = new ImmString("");
//line 584
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 584
___nl__2 = null;
//line 584
___nl__1 = null;
//line 586
___nl__1 = new ImmString("string::lf");
//line 586
___nl__2 = new ImmString("");
//line 586
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 586
___nl__2 = null;
//line 586
___nl__1 = null;
//line 587
___nl__1 = new ImmString("string::t");
//line 587
___nl__2 = new ImmString("");
//line 587
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 587
___nl__2 = null;
//line 587
___nl__1 = null;
//line 588
___nl__1 = new ImmString("string::length");
//line 588
___nl__2 = new ImmString("");
//line 588
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 588
___nl__2 = null;
//line 588
___nl__1 = null;
//line 589
___nl__1 = new ImmString("string::substr");
//line 589
___nl__2 = new ImmString("");
//line 589
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 589
___nl__2 = null;
//line 589
___nl__1 = null;
//line 590
___nl__1 = new ImmString("string::is_digit");
//line 590
___nl__2 = new ImmString("");
//line 590
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 590
___nl__2 = null;
//line 590
___nl__1 = null;
//line 591
___nl__1 = new ImmString("string::is_letter");
//line 591
___nl__2 = new ImmString("");
//line 591
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 591
___nl__2 = null;
//line 591
___nl__1 = null;
//line 592
___nl__1 = new ImmString("string::ord");
//line 592
___nl__2 = new ImmString("");
//line 592
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 592
___nl__2 = null;
//line 592
___nl__1 = null;
//line 593
___nl__1 = new ImmString("string::chr");
//line 593
___nl__2 = new ImmString("");
//line 593
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 593
___nl__2 = null;
//line 593
___nl__1 = null;
//line 595
___nl__1 = new ImmString("ov::mk");
//line 595
___nl__2 = new ImmString("");
//line 595
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 595
___nl__2 = null;
//line 595
___nl__1 = null;
//line 596
___nl__1 = new ImmString("ov::mk_val");
//line 596
___nl__2 = new ImmString("");
//line 596
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 596
___nl__2 = null;
//line 596
___nl__1 = null;
//line 597
___nl__1 = new ImmString("ov::has_value");
//line 597
___nl__2 = new ImmString("");
//line 597
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 597
___nl__2 = null;
//line 597
___nl__1 = null;
//line 598
___nl__1 = new ImmString("ov::get_element");
//line 598
___nl__2 = new ImmString("");
//line 598
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 598
___nl__2 = null;
//line 598
___nl__1 = null;
//line 599
___nl__1 = new ImmString("ov::get_value");
//line 599
___nl__2 = new ImmString("");
//line 599
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 599
___nl__2 = null;
//line 599
___nl__1 = null;
//line 600
___nl__1 = new ImmString("ov::is");
//line 600
___nl__2 = new ImmString("");
//line 600
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 600
___nl__2 = null;
//line 600
___nl__1 = null;
//line 601
___nl__1 = new ImmString("ov::as");
//line 601
___nl__2 = new ImmString("");
//line 601
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 601
___nl__2 = null;
//line 601
___nl__1 = null;
//line 603
___nl__1 = new ImmString("c_rt_lib::array_len");
//line 603
___nl__2 = new ImmString("");
//line 603
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 603
___nl__2 = null;
//line 603
___nl__1 = null;
//line 604
___nl__1 = new ImmString("c_rt_lib::set_ref_arr");
//line 604
___nl__2 = new ImmString("");
//line 604
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 604
___nl__2 = null;
//line 604
___nl__1 = null;
//line 605
___nl__1 = new ImmString("c_rt_lib::set_ref_hash");
//line 605
___nl__2 = new ImmString("");
//line 605
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 605
___nl__2 = null;
//line 605
___nl__1 = null;
//line 606
___nl__1 = new ImmString("c_rt_lib::get_ref_arr");
//line 606
___nl__2 = new ImmString("");
//line 606
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 606
___nl__2 = null;
//line 606
___nl__1 = null;
//line 607
___nl__1 = new ImmString("c_rt_lib::get_ref_hash");
//line 607
___nl__2 = new ImmString("");
//line 607
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 607
___nl__2 = null;
//line 607
___nl__1 = null;
//line 608
___nl__1 = new ImmString("c_rt_lib::init_iter");
//line 608
___nl__2 = new ImmString("");
//line 608
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 608
___nl__2 = null;
//line 608
___nl__1 = null;
//line 609
___nl__1 = new ImmString("c_rt_lib::is_end_hash");
//line 609
___nl__2 = new ImmString("");
//line 609
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 609
___nl__2 = null;
//line 609
___nl__1 = null;
//line 610
___nl__1 = new ImmString("c_rt_lib::get_key_iter");
//line 610
___nl__2 = new ImmString("");
//line 610
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 610
___nl__2 = null;
//line 610
___nl__1 = null;
//line 611
___nl__1 = new ImmString("c_rt_lib::hash_get_value");
//line 611
___nl__2 = new ImmString("");
//line 611
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 611
___nl__2 = null;
//line 611
___nl__1 = null;
//line 612
___nl__1 = new ImmString("c_rt_lib::next_iter");
//line 612
___nl__2 = new ImmString("");
//line 612
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 612
___nl__2 = null;
//line 612
___nl__1 = null;
//line 614
if(true) return ___nl__0;
//line 614
___nl__0 = null;
//line 614
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_get_compiler_functions_priv = null;
private static Imm NL_get_compiler_functions_priv() {
	if (value__singleton__NL_SINGLETON_get_compiler_functions_priv == null) {
		value__singleton__NL_SINGLETON_get_compiler_functions_priv = NL_SINGLETON_get_compiler_functions_priv();
	}
	return value__singleton__NL_SINGLETON_get_compiler_functions_priv;
}
private static Imm NL_handle_array_call_priv(Imm ___arg__0, ImmRef ___arg__1, ImmRef ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();Imm ___nl__2 = ___arg__2.getValue().clone();
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
//line 618
___nl__3 = new ImmString("incorrect command");
//line 618
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("err"), ___nl__3);
//line 619
___nl__6 = new ImmDouble(0);
//line 619
___nl__5 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()];
//line 619
___nl__6 = null;
//line 619
___nl__4 = nl_NL.NL_is_array(___nl__5);

//line 619
___nl__5 = null;
//line 619
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 619
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 619
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 619
___nl__0 = null;
//line 619
___nl__4 = null;
//line 619
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 619
if (true) {goto label_2;}
//line 619
label_2:
//line 619
___nl__4 = null;
//line 620
___nl__4 = new ImmString("array::push");
//line 620
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__4.toString()));
//line 620
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 620
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_4;}}
//line 621
___nl__6 = new ImmDouble(0);
//line 621
___nl__5 = c_rt_lib_NL.NL_get_ref_arr(___nl__2,___nl__6);

//line 621
___nl__8 = new ImmDouble(1);
//line 621
___nl__7 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 621
___nl__8 = null;
//line 621
___ref______nl__5 = new ImmRef(___nl__5);
array_NL.NL_push(___ref______nl__5,___nl__7);
___nl__5 = ___ref______nl__5.getValue();

//line 621
___nl__7 = null;
//line 621
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_arr(___ref______nl__2,___nl__6,___nl__5);
___nl__2 = ___ref______nl__2.getValue();

//line 621
___nl__5 = null;
//line 621
___nl__6 = null;
//line 622
if (true) {goto label_3;}
//line 622
label_4:
//line 622
___nl__4 = new ImmString("array::pop");
//line 622
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__4.toString()));
//line 622
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 622
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_5;}}
//line 623
___nl__7 = new ImmDouble(0);
//line 623
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 623
___nl__7 = null;
//line 623
___nl__5 = array_NL.NL_len(___nl__6);

//line 623
___nl__6 = null;
//line 623
___nl__6 = new ImmDouble(0);
//line 623
___nl__5 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>(Double.Parse(___nl__6.getValue().ToString())) );
//line 623
___nl__6 = null;
//line 623
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 623
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 623
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_7;}}
//line 623
___nl__0 = null;
//line 623
___nl__4 = null;
//line 623
___nl__5 = null;
//line 623
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 623
if (true) {goto label_7;}
//line 623
label_7:
//line 623
___nl__5 = null;
//line 624
___nl__6 = new ImmDouble(0);
//line 624
___nl__5 = c_rt_lib_NL.NL_get_ref_arr(___nl__2,___nl__6);

//line 624
___ref______nl__5 = new ImmRef(___nl__5);
array_NL.NL_pop(___ref______nl__5);
___nl__5 = ___ref______nl__5.getValue();

//line 624
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_arr(___ref______nl__2,___nl__6,___nl__5);
___nl__2 = ___ref______nl__2.getValue();

//line 624
___nl__5 = null;
//line 624
___nl__6 = null;
//line 625
if (true) {goto label_3;}
//line 625
label_5:
//line 625
___nl__4 = new ImmString("array::subarray");
//line 625
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__4.toString()));
//line 625
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 625
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_8;}}
//line 626
___nl__8 = new ImmDouble(1);
//line 626
___nl__7 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 626
___nl__8 = null;
//line 626
___nl__5 = nl_NL.NL_is_sim(___nl__7);

//line 626
___nl__7 = null;
//line 626
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 626
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_11;}}
//line 626
___nl__8 = new ImmDouble(2);
//line 626
___nl__7 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 626
___nl__8 = null;
//line 626
___nl__5 = nl_NL.NL_is_sim(___nl__7);

//line 626
___nl__7 = null;
//line 626
label_11:
//line 626
___nl__6 = null;
//line 626
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 626
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 626
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_10;}}
//line 626
___nl__0 = null;
//line 626
___nl__4 = null;
//line 626
___nl__5 = null;
//line 626
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 626
if (true) {goto label_10;}
//line 626
label_10:
//line 626
___nl__5 = null;
//line 627
___nl__8 = new ImmDouble(1);
//line 627
___nl__7 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 627
___nl__8 = null;
//line 627
___nl__5 = string_utils_NL.NL_is_number(___nl__7);

//line 627
___nl__7 = null;
//line 627
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 627
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_14;}}
//line 627
___nl__8 = new ImmDouble(2);
//line 627
___nl__7 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 627
___nl__8 = null;
//line 627
___nl__5 = string_utils_NL.NL_is_number(___nl__7);

//line 627
___nl__7 = null;
//line 627
label_14:
//line 627
___nl__6 = null;
//line 627
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 627
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 627
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_13;}}
//line 627
___nl__0 = null;
//line 627
___nl__4 = null;
//line 627
___nl__5 = null;
//line 627
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 627
if (true) {goto label_13;}
//line 627
label_13:
//line 627
___nl__5 = null;
//line 628
___nl__7 = new ImmDouble(1);
//line 628
___nl__5 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 628
___nl__7 = null;
//line 628
___nl__7 = new ImmDouble(0);
//line 628
___nl__5 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) );
//line 628
___nl__7 = null;
//line 628
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 628
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_17;}}
//line 628
___nl__7 = new ImmDouble(1);
//line 628
___nl__5 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 628
___nl__7 = null;
//line 628
___nl__9 = new ImmDouble(0);
//line 628
___nl__8 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()];
//line 628
___nl__9 = null;
//line 628
___nl__7 = array_NL.NL_len(___nl__8);

//line 628
___nl__8 = null;
//line 628
___nl__5 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))<(Double.Parse(___nl__7.getValue().ToString())) );
//line 628
___nl__7 = null;
//line 628
label_17:
//line 628
___nl__6 = null;
//line 628
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 628
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 628
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_16;}}
//line 628
___nl__0 = null;
//line 628
___nl__4 = null;
//line 628
___nl__5 = null;
//line 628
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 628
if (true) {goto label_16;}
//line 628
label_16:
//line 628
___nl__5 = null;
//line 629
___nl__6 = new ImmDouble(2);
//line 629
___nl__5 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()];
//line 629
___nl__6 = null;
//line 629
___nl__6 = new ImmDouble(0);
//line 629
___nl__5 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) );
//line 629
___nl__6 = null;
//line 629
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 629
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 629
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_19;}}
//line 629
___nl__0 = null;
//line 629
___nl__4 = null;
//line 629
___nl__5 = null;
//line 629
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 629
if (true) {goto label_19;}
//line 629
label_19:
//line 629
___nl__5 = null;
//line 630
___nl__7 = new ImmDouble(1);
//line 630
___nl__5 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 630
___nl__7 = null;
//line 630
___nl__8 = new ImmDouble(2);
//line 630
___nl__7 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 630
___nl__8 = null;
//line 630
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__7.getValue().ToString())));
//line 630
___nl__7 = null;
//line 630
___nl__7 = new ImmDouble(0);
//line 630
___nl__5 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) );
//line 630
___nl__7 = null;
//line 630
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 630
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_22;}}
//line 630
___nl__7 = new ImmDouble(1);
//line 630
___nl__5 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 630
___nl__7 = null;
//line 630
___nl__8 = new ImmDouble(2);
//line 630
___nl__7 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 630
___nl__8 = null;
//line 630
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__7.getValue().ToString())));
//line 630
___nl__7 = null;
//line 630
___nl__7 = new ImmDouble(1);
//line 630
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))-(Double.Parse(___nl__7.getValue().ToString())));
//line 630
___nl__7 = null;
//line 630
___nl__9 = new ImmDouble(0);
//line 630
___nl__8 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()];
//line 630
___nl__9 = null;
//line 630
___nl__7 = array_NL.NL_len(___nl__8);

//line 630
___nl__8 = null;
//line 630
___nl__5 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))<(Double.Parse(___nl__7.getValue().ToString())) );
//line 630
___nl__7 = null;
//line 630
label_22:
//line 630
___nl__6 = null;
//line 630
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 630
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 630
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_21;}}
//line 630
___nl__0 = null;
//line 630
___nl__4 = null;
//line 630
___nl__5 = null;
//line 630
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 630
if (true) {goto label_21;}
//line 630
label_21:
//line 630
___nl__5 = null;
//line 631
___nl__7 = new ImmDouble(0);
//line 631
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 631
___nl__7 = null;
//line 631
___nl__8 = new ImmDouble(1);
//line 631
___nl__7 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 631
___nl__8 = null;
//line 631
___nl__9 = new ImmDouble(2);
//line 631
___nl__8 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()];
//line 631
___nl__9 = null;
//line 631
___nl__5 = array_NL.NL_subarray(___nl__6,___nl__7,___nl__8);

//line 631
___nl__8 = null;
//line 631
___nl__7 = null;
//line 631
___nl__6 = null;
//line 631
___nl__1 = ___nl__5;
//line 631
___nl__5 = null;
//line 632
if (true) {goto label_3;}
//line 632
label_8:
//line 632
___nl__4 = new ImmString("array::append");
//line 632
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__4.toString()));
//line 632
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 632
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_23;}}
//line 633
___nl__7 = new ImmDouble(1);
//line 633
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 633
___nl__7 = null;
//line 633
___nl__5 = nl_NL.NL_is_array(___nl__6);

//line 633
___nl__6 = null;
//line 633
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 633
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 633
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_25;}}
//line 633
___nl__0 = null;
//line 633
___nl__4 = null;
//line 633
___nl__5 = null;
//line 633
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 633
if (true) {goto label_25;}
//line 633
label_25:
//line 633
___nl__5 = null;
//line 634
___nl__6 = new ImmDouble(0);
//line 634
___nl__5 = c_rt_lib_NL.NL_get_ref_arr(___nl__2,___nl__6);

//line 634
___nl__8 = new ImmDouble(1);
//line 634
___nl__7 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 634
___nl__8 = null;
//line 634
___ref______nl__5 = new ImmRef(___nl__5);
array_NL.NL_append(___ref______nl__5,___nl__7);
___nl__5 = ___ref______nl__5.getValue();

//line 634
___nl__7 = null;
//line 634
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_arr(___ref______nl__2,___nl__6,___nl__5);
___nl__2 = ___ref______nl__2.getValue();

//line 634
___nl__5 = null;
//line 634
___nl__6 = null;
//line 635
if (true) {goto label_3;}
//line 635
label_23:
//line 635
___nl__4 = new ImmString("array::len");
//line 635
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__4.toString()));
//line 635
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 635
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_26;}}
//line 636
___nl__7 = new ImmDouble(0);
//line 636
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 636
___nl__7 = null;
//line 636
___nl__5 = array_NL.NL_len(___nl__6);

//line 636
___nl__6 = null;
//line 636
___nl__1 = ___nl__5;
//line 636
___nl__5 = null;
//line 637
if (true) {goto label_3;}
//line 637
label_26:
//line 637
___nl__4 = new ImmString("array::cmp");
//line 637
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__4.toString()));
//line 637
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 637
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_27;}}
//line 638
___nl__7 = new ImmDouble(1);
//line 638
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 638
___nl__7 = null;
//line 638
___nl__5 = nl_NL.NL_is_array(___nl__6);

//line 638
___nl__6 = null;
//line 638
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 638
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 638
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_29;}}
//line 638
___nl__0 = null;
//line 638
___nl__4 = null;
//line 638
___nl__5 = null;
//line 638
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 638
if (true) {goto label_29;}
//line 638
label_29:
//line 638
___nl__5 = null;
//line 639
___nl__7 = new ImmDouble(0);
//line 639
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 639
___nl__7 = null;
//line 639
___nl__8 = new ImmDouble(1);
//line 639
___nl__7 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 639
___nl__8 = null;
//line 639
___nl__5 = array_NL.NL_cmp(___nl__6,___nl__7);

//line 639
___nl__7 = null;
//line 639
___nl__6 = null;
//line 639
___nl__1 = ___nl__5;
//line 639
___nl__5 = null;
//line 640
if (true) {goto label_3;}
//line 640
label_27:
//line 640
___nl__4 = new ImmString("array::sort");
//line 640
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__4.toString()));
//line 640
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 640
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_30;}}
//line 641
___nl__6 = new ImmDouble(0);
//line 641
___nl__5 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()];
//line 641
___nl__6 = null;
//line 641
___nl__1 = ___nl__5;
//line 641
___nl__5 = null;
//line 642
___ref______nl__1 = new ImmRef(___nl__1);
array_NL.NL_sort(___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 643
if (true) {goto label_3;}
//line 643
label_30:
//line 644
___nl__5 = new ImmArray(new Imm[0]);
//line 644
c_rt_lib_NL.NL_die();
//line 644
___nl__5 = null;
//line 645
if (true) {goto label_3;}
//line 645
label_3:
//line 645
___nl__4 = null;
//line 646
___nl__4 = new ImmString("");
//line 646
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__4);
//line 646
___nl__0 = null;
//line 646
___nl__3 = null;
//line 646
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__4;
//line 646
___nl__4 = null;
//line 646
___nl__3 = null;
//line 646
___nl__0 = null;
//line 646
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return null;
}

private static Imm NL_handle_hash_call_priv(Imm ___arg__0, ImmRef ___arg__1, ImmRef ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();Imm ___nl__2 = ___arg__2.getValue().clone();
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
//line 650
___nl__3 = new ImmString("incorrect command");
//line 650
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("err"), ___nl__3);
//line 651
___nl__6 = new ImmDouble(0);
//line 651
___nl__5 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()];
//line 651
___nl__6 = null;
//line 651
___nl__4 = nl_NL.NL_is_hash(___nl__5);

//line 651
___nl__5 = null;
//line 651
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 651
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 651
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 651
___nl__0 = null;
//line 651
___nl__4 = null;
//line 651
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 651
if (true) {goto label_2;}
//line 651
label_2:
//line 651
___nl__4 = null;
//line 652
___nl__4 = new ImmString("hash::get_value");
//line 652
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__4.toString()));
//line 652
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 652
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_4;}}
//line 653
___nl__7 = new ImmDouble(1);
//line 653
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 653
___nl__7 = null;
//line 653
___nl__5 = nl_NL.NL_is_sim(___nl__6);

//line 653
___nl__6 = null;
//line 653
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 653
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 653
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_6;}}
//line 653
___nl__0 = null;
//line 653
___nl__4 = null;
//line 653
___nl__5 = null;
//line 653
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 653
if (true) {goto label_6;}
//line 653
label_6:
//line 653
___nl__5 = null;
//line 654
___nl__7 = new ImmDouble(0);
//line 654
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 654
___nl__7 = null;
//line 654
___nl__8 = new ImmDouble(1);
//line 654
___nl__7 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 654
___nl__8 = null;
//line 654
___nl__5 = hash_NL.NL_has_key(___nl__6,___nl__7);

//line 654
___nl__7 = null;
//line 654
___nl__6 = null;
//line 654
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 654
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 654
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_8;}}
//line 654
___nl__0 = null;
//line 654
___nl__4 = null;
//line 654
___nl__5 = null;
//line 654
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 654
if (true) {goto label_8;}
//line 654
label_8:
//line 654
___nl__5 = null;
//line 655
___nl__7 = new ImmDouble(0);
//line 655
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 655
___nl__7 = null;
//line 655
___nl__8 = new ImmDouble(1);
//line 655
___nl__7 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 655
___nl__8 = null;
//line 655
___nl__5 = hash_NL.NL_get_value(___nl__6,___nl__7);

//line 655
___nl__7 = null;
//line 655
___nl__6 = null;
//line 655
___nl__1 = ___nl__5;
//line 655
___nl__5 = null;
//line 656
if (true) {goto label_3;}
//line 656
label_4:
//line 656
___nl__4 = new ImmString("hash::has_key");
//line 656
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__4.toString()));
//line 656
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 656
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_9;}}
//line 657
___nl__7 = new ImmDouble(1);
//line 657
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 657
___nl__7 = null;
//line 657
___nl__5 = nl_NL.NL_is_sim(___nl__6);

//line 657
___nl__6 = null;
//line 657
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 657
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 657
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_11;}}
//line 657
___nl__0 = null;
//line 657
___nl__4 = null;
//line 657
___nl__5 = null;
//line 657
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 657
if (true) {goto label_11;}
//line 657
label_11:
//line 657
___nl__5 = null;
//line 658
___nl__7 = new ImmDouble(0);
//line 658
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 658
___nl__7 = null;
//line 658
___nl__8 = new ImmDouble(1);
//line 658
___nl__7 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 658
___nl__8 = null;
//line 658
___nl__5 = hash_NL.NL_has_key(___nl__6,___nl__7);

//line 658
___nl__7 = null;
//line 658
___nl__6 = null;
//line 658
___nl__1 = ___nl__5;
//line 658
___nl__5 = null;
//line 659
if (true) {goto label_3;}
//line 659
label_9:
//line 659
___nl__4 = new ImmString("hash::set_value");
//line 659
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__4.toString()));
//line 659
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 659
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_12;}}
//line 660
___nl__7 = new ImmDouble(1);
//line 660
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 660
___nl__7 = null;
//line 660
___nl__5 = nl_NL.NL_is_sim(___nl__6);

//line 660
___nl__6 = null;
//line 660
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 660
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 660
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_14;}}
//line 660
___nl__0 = null;
//line 660
___nl__4 = null;
//line 660
___nl__5 = null;
//line 660
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 660
if (true) {goto label_14;}
//line 660
label_14:
//line 660
___nl__5 = null;
//line 661
___nl__6 = new ImmDouble(0);
//line 661
___nl__5 = c_rt_lib_NL.NL_get_ref_arr(___nl__2,___nl__6);

//line 661
___nl__8 = new ImmDouble(1);
//line 661
___nl__7 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 661
___nl__8 = null;
//line 661
___nl__9 = new ImmDouble(2);
//line 661
___nl__8 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()];
//line 661
___nl__9 = null;
//line 661
___ref______nl__5 = new ImmRef(___nl__5);
hash_NL.NL_set_value(___ref______nl__5,___nl__7,___nl__8);
___nl__5 = ___ref______nl__5.getValue();

//line 661
___nl__8 = null;
//line 661
___nl__7 = null;
//line 661
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_arr(___ref______nl__2,___nl__6,___nl__5);
___nl__2 = ___ref______nl__2.getValue();

//line 661
___nl__5 = null;
//line 661
___nl__6 = null;
//line 662
if (true) {goto label_3;}
//line 662
label_12:
//line 662
___nl__4 = new ImmString("hash::delete");
//line 662
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__4.toString()));
//line 662
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 662
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_15;}}
//line 663
___nl__7 = new ImmDouble(1);
//line 663
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 663
___nl__7 = null;
//line 663
___nl__5 = nl_NL.NL_is_sim(___nl__6);

//line 663
___nl__6 = null;
//line 663
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 663
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 663
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_17;}}
//line 663
___nl__0 = null;
//line 663
___nl__4 = null;
//line 663
___nl__5 = null;
//line 663
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 663
if (true) {goto label_17;}
//line 663
label_17:
//line 663
___nl__5 = null;
//line 664
___nl__6 = new ImmDouble(0);
//line 664
___nl__5 = c_rt_lib_NL.NL_get_ref_arr(___nl__2,___nl__6);

//line 664
___nl__8 = new ImmDouble(1);
//line 664
___nl__7 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 664
___nl__8 = null;
//line 664
___ref______nl__5 = new ImmRef(___nl__5);
hash_NL.NL_delete(___ref______nl__5,___nl__7);
___nl__5 = ___ref______nl__5.getValue();

//line 664
___nl__7 = null;
//line 664
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_arr(___ref______nl__2,___nl__6,___nl__5);
___nl__2 = ___ref______nl__2.getValue();

//line 664
___nl__5 = null;
//line 664
___nl__6 = null;
//line 665
if (true) {goto label_3;}
//line 665
label_15:
//line 665
___nl__4 = new ImmString("hash::size");
//line 665
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__4.toString()));
//line 665
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 665
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_18;}}
//line 666
___nl__7 = new ImmDouble(0);
//line 666
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 666
___nl__7 = null;
//line 666
___nl__5 = hash_NL.NL_size(___nl__6);

//line 666
___nl__6 = null;
//line 666
___nl__1 = ___nl__5;
//line 666
___nl__5 = null;
//line 667
if (true) {goto label_3;}
//line 667
label_18:
//line 667
___nl__4 = new ImmString("hash::keys");
//line 667
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__4.toString()));
//line 667
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 667
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_19;}}
//line 668
___nl__7 = new ImmDouble(0);
//line 668
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 668
___nl__7 = null;
//line 668
___nl__5 = hash_NL.NL_keys(___nl__6);

//line 668
___nl__6 = null;
//line 668
___nl__1 = ___nl__5;
//line 668
___nl__5 = null;
//line 669
if (true) {goto label_3;}
//line 669
label_19:
//line 670
___nl__5 = new ImmArray(new Imm[0]);
//line 670
c_rt_lib_NL.NL_die();
//line 670
___nl__5 = null;
//line 671
if (true) {goto label_3;}
//line 671
label_3:
//line 671
___nl__4 = null;
//line 672
___nl__4 = new ImmString("");
//line 672
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__4);
//line 672
___nl__0 = null;
//line 672
___nl__3 = null;
//line 672
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__4;
//line 672
___nl__4 = null;
//line 672
___nl__3 = null;
//line 672
___nl__0 = null;
//line 672
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return null;
}

private static Imm NL_handle_string_call_priv(Imm ___arg__0, ImmRef ___arg__1, ImmRef ___arg__2) {
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
//line 676
___nl__3 = new ImmString("incorrect command");
//line 676
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("err"), ___nl__3);
//line 677
___nl__4 = new ImmString("string::lf");
//line 677
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__4.toString()));
//line 677
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 677
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 678
___nl__5 = string_NL.NL_lf();

//line 678
___nl__1 = ___nl__5;
//line 678
___nl__5 = null;
//line 679
if (true) {goto label_1;}
//line 679
label_2:
//line 679
___nl__4 = new ImmString("string::tab");
//line 679
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__4.toString()));
//line 679
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 679
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_3;}}
//line 680
___nl__5 = string_NL.NL_tab();

//line 680
___nl__1 = ___nl__5;
//line 680
___nl__5 = null;
//line 681
if (true) {goto label_1;}
//line 681
label_3:
//line 681
___nl__4 = new ImmString("string::ord");
//line 681
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__4.toString()));
//line 681
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 681
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_4;}}
//line 682
___nl__7 = new ImmDouble(0);
//line 682
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 682
___nl__7 = null;
//line 682
___nl__5 = nl_NL.NL_is_sim(___nl__6);

//line 682
___nl__6 = null;
//line 682
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 682
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 682
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_6;}}
//line 682
___nl__0 = null;
//line 682
___nl__4 = null;
//line 682
___nl__5 = null;
//line 682
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 682
if (true) {goto label_6;}
//line 682
label_6:
//line 682
___nl__5 = null;
//line 683
___nl__7 = new ImmDouble(0);
//line 683
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 683
___nl__7 = null;
//line 683
___nl__5 = string_NL.NL_length(___nl__6);

//line 683
___nl__6 = null;
//line 683
___nl__6 = new ImmDouble(1);
//line 683
___nl__5 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString())) ==((Double.Parse(___nl__6.getValue().ToString())))  );
//line 683
___nl__6 = null;
//line 683
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 683
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 683
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_8;}}
//line 683
___nl__0 = null;
//line 683
___nl__4 = null;
//line 683
___nl__5 = null;
//line 683
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 683
if (true) {goto label_8;}
//line 683
label_8:
//line 683
___nl__5 = null;
//line 684
___nl__7 = new ImmDouble(0);
//line 684
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 684
___nl__7 = null;
//line 684
___nl__5 = string_NL.NL_ord(___nl__6);

//line 684
___nl__6 = null;
//line 684
___nl__1 = ___nl__5;
//line 684
___nl__5 = null;
//line 685
if (true) {goto label_1;}
//line 685
label_4:
//line 685
___nl__4 = new ImmString("string::chr");
//line 685
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__4.toString()));
//line 685
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 685
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_9;}}
//line 686
___nl__7 = new ImmDouble(0);
//line 686
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 686
___nl__7 = null;
//line 686
___nl__5 = nl_NL.NL_is_sim(___nl__6);

//line 686
___nl__6 = null;
//line 686
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 686
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 686
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_11;}}
//line 686
___nl__0 = null;
//line 686
___nl__4 = null;
//line 686
___nl__5 = null;
//line 686
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 686
if (true) {goto label_11;}
//line 686
label_11:
//line 686
___nl__5 = null;
//line 687
___nl__7 = new ImmDouble(0);
//line 687
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 687
___nl__7 = null;
//line 687
___nl__5 = string_utils_NL.NL_is_number(___nl__6);

//line 687
___nl__6 = null;
//line 687
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 687
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 687
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_13;}}
//line 687
___nl__0 = null;
//line 687
___nl__4 = null;
//line 687
___nl__5 = null;
//line 687
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 687
if (true) {goto label_13;}
//line 687
label_13:
//line 687
___nl__5 = null;
//line 688
___nl__7 = new ImmDouble(0);
//line 688
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 688
___nl__7 = null;
//line 688
___nl__5 = string_NL.NL_chr(___nl__6);

//line 688
___nl__6 = null;
//line 688
___nl__1 = ___nl__5;
//line 688
___nl__5 = null;
//line 689
if (true) {goto label_1;}
//line 689
label_9:
//line 690
___nl__7 = new ImmDouble(0);
//line 690
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 690
___nl__7 = null;
//line 690
___nl__5 = nl_NL.NL_is_sim(___nl__6);

//line 690
___nl__6 = null;
//line 690
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 690
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 690
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_15;}}
//line 690
___nl__0 = null;
//line 690
___nl__4 = null;
//line 690
___nl__5 = null;
//line 690
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 690
if (true) {goto label_15;}
//line 690
label_15:
//line 690
___nl__5 = null;
//line 691
___nl__5 = new ImmString("string::length");
//line 691
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__5.toString()));
//line 691
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 691
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_17;}}
//line 692
___nl__8 = new ImmDouble(0);
//line 692
___nl__7 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 692
___nl__8 = null;
//line 692
___nl__6 = string_NL.NL_length(___nl__7);

//line 692
___nl__7 = null;
//line 692
___nl__1 = ___nl__6;
//line 692
___nl__6 = null;
//line 693
if (true) {goto label_16;}
//line 693
label_17:
//line 693
___nl__5 = new ImmString("string::substr");
//line 693
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__5.toString()));
//line 693
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 693
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_18;}}
//line 694
___nl__9 = new ImmDouble(1);
//line 694
___nl__8 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()];
//line 694
___nl__9 = null;
//line 694
___nl__6 = nl_NL.NL_is_sim(___nl__8);

//line 694
___nl__8 = null;
//line 694
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 694
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_21;}}
//line 694
___nl__9 = new ImmDouble(2);
//line 694
___nl__8 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()];
//line 694
___nl__9 = null;
//line 694
___nl__6 = nl_NL.NL_is_sim(___nl__8);

//line 694
___nl__8 = null;
//line 694
label_21:
//line 694
___nl__7 = null;
//line 694
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 694
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 694
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_20;}}
//line 694
___nl__0 = null;
//line 694
___nl__4 = null;
//line 694
___nl__5 = null;
//line 694
___nl__6 = null;
//line 694
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 694
if (true) {goto label_20;}
//line 694
label_20:
//line 694
___nl__6 = null;
//line 695
___nl__9 = new ImmDouble(1);
//line 695
___nl__8 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()];
//line 695
___nl__9 = null;
//line 695
___nl__6 = string_utils_NL.NL_is_number(___nl__8);

//line 695
___nl__8 = null;
//line 695
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 695
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_24;}}
//line 695
___nl__9 = new ImmDouble(2);
//line 695
___nl__8 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()];
//line 695
___nl__9 = null;
//line 695
___nl__6 = string_utils_NL.NL_is_number(___nl__8);

//line 695
___nl__8 = null;
//line 695
label_24:
//line 695
___nl__7 = null;
//line 695
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 695
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 695
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_23;}}
//line 695
___nl__0 = null;
//line 695
___nl__4 = null;
//line 695
___nl__5 = null;
//line 695
___nl__6 = null;
//line 695
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 695
if (true) {goto label_23;}
//line 695
label_23:
//line 695
___nl__6 = null;
//line 696
___nl__8 = new ImmDouble(1);
//line 696
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 696
___nl__8 = null;
//line 696
___nl__8 = new ImmDouble(0);
//line 696
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__6.getValue().ToString()))>=(Double.Parse(___nl__8.getValue().ToString())) );
//line 696
___nl__8 = null;
//line 696
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 696
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_27;}}
//line 696
___nl__8 = new ImmDouble(1);
//line 696
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 696
___nl__8 = null;
//line 696
___nl__10 = new ImmDouble(0);
//line 696
___nl__9 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()];
//line 696
___nl__10 = null;
//line 696
___nl__8 = string_NL.NL_length(___nl__9);

//line 696
___nl__9 = null;
//line 696
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__6.getValue().ToString()))<(Double.Parse(___nl__8.getValue().ToString())) );
//line 696
___nl__8 = null;
//line 696
label_27:
//line 696
___nl__7 = null;
//line 696
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 696
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 696
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_26;}}
//line 696
___nl__0 = null;
//line 696
___nl__4 = null;
//line 696
___nl__5 = null;
//line 696
___nl__6 = null;
//line 696
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 696
if (true) {goto label_26;}
//line 696
label_26:
//line 696
___nl__6 = null;
//line 697
___nl__7 = new ImmDouble(2);
//line 697
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 697
___nl__7 = null;
//line 697
___nl__7 = new ImmDouble(0);
//line 697
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__6.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) );
//line 697
___nl__7 = null;
//line 697
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 697
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 697
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_29;}}
//line 697
___nl__0 = null;
//line 697
___nl__4 = null;
//line 697
___nl__5 = null;
//line 697
___nl__6 = null;
//line 697
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 697
if (true) {goto label_29;}
//line 697
label_29:
//line 697
___nl__6 = null;
//line 698
___nl__8 = new ImmDouble(1);
//line 698
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 698
___nl__8 = null;
//line 698
___nl__9 = new ImmDouble(2);
//line 698
___nl__8 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()];
//line 698
___nl__9 = null;
//line 698
___nl__6 = new ImmDouble((Double.Parse(___nl__6.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString())));
//line 698
___nl__8 = null;
//line 698
___nl__8 = new ImmDouble(0);
//line 698
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__6.getValue().ToString()))>=(Double.Parse(___nl__8.getValue().ToString())) );
//line 698
___nl__8 = null;
//line 698
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 698
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_32;}}
//line 698
___nl__8 = new ImmDouble(1);
//line 698
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 698
___nl__8 = null;
//line 698
___nl__9 = new ImmDouble(2);
//line 698
___nl__8 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()];
//line 698
___nl__9 = null;
//line 698
___nl__6 = new ImmDouble((Double.Parse(___nl__6.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString())));
//line 698
___nl__8 = null;
//line 698
___nl__8 = new ImmDouble(1);
//line 698
___nl__6 = new ImmDouble((Double.Parse(___nl__6.getValue().ToString()))-(Double.Parse(___nl__8.getValue().ToString())));
//line 698
___nl__8 = null;
//line 698
___nl__10 = new ImmDouble(0);
//line 698
___nl__9 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()];
//line 698
___nl__10 = null;
//line 698
___nl__8 = string_NL.NL_length(___nl__9);

//line 698
___nl__9 = null;
//line 698
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__6.getValue().ToString()))<(Double.Parse(___nl__8.getValue().ToString())) );
//line 698
___nl__8 = null;
//line 698
label_32:
//line 698
___nl__7 = null;
//line 698
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 698
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 698
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_31;}}
//line 698
___nl__0 = null;
//line 698
___nl__4 = null;
//line 698
___nl__5 = null;
//line 698
___nl__6 = null;
//line 698
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 698
if (true) {goto label_31;}
//line 698
label_31:
//line 698
___nl__6 = null;
//line 699
___nl__8 = new ImmDouble(0);
//line 699
___nl__7 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 699
___nl__8 = null;
//line 699
___nl__9 = new ImmDouble(1);
//line 699
___nl__8 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()];
//line 699
___nl__9 = null;
//line 699
___nl__10 = new ImmDouble(2);
//line 699
___nl__9 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()];
//line 699
___nl__10 = null;
//line 699
___nl__6 = string_NL.NL_substr(___nl__7,___nl__8,___nl__9);

//line 699
___nl__9 = null;
//line 699
___nl__8 = null;
//line 699
___nl__7 = null;
//line 699
___nl__1 = ___nl__6;
//line 699
___nl__6 = null;
//line 700
if (true) {goto label_16;}
//line 700
label_18:
//line 700
___nl__5 = new ImmString("string::is_digit");
//line 700
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__5.toString()));
//line 700
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 700
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_33;}}
//line 701
___nl__8 = new ImmDouble(0);
//line 701
___nl__7 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 701
___nl__8 = null;
//line 701
___nl__6 = string_NL.NL_length(___nl__7);

//line 701
___nl__7 = null;
//line 701
___nl__7 = new ImmDouble(1);
//line 701
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__6.getValue().ToString())) ==((Double.Parse(___nl__7.getValue().ToString())))  );
//line 701
___nl__7 = null;
//line 701
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 701
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 701
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_35;}}
//line 701
___nl__0 = null;
//line 701
___nl__4 = null;
//line 701
___nl__5 = null;
//line 701
___nl__6 = null;
//line 701
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 701
if (true) {goto label_35;}
//line 701
label_35:
//line 701
___nl__6 = null;
//line 702
___nl__8 = new ImmDouble(0);
//line 702
___nl__7 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 702
___nl__8 = null;
//line 702
___nl__6 = string_NL.NL_is_digit(___nl__7);

//line 702
___nl__7 = null;
//line 702
___nl__1 = ___nl__6;
//line 702
___nl__6 = null;
//line 703
if (true) {goto label_16;}
//line 703
label_33:
//line 703
___nl__5 = new ImmString("string::is_letter");
//line 703
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__5.toString()));
//line 703
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 703
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_36;}}
//line 704
___nl__8 = new ImmDouble(0);
//line 704
___nl__7 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 704
___nl__8 = null;
//line 704
___nl__6 = string_NL.NL_length(___nl__7);

//line 704
___nl__7 = null;
//line 704
___nl__7 = new ImmDouble(1);
//line 704
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__6.getValue().ToString())) ==((Double.Parse(___nl__7.getValue().ToString())))  );
//line 704
___nl__7 = null;
//line 704
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 704
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 704
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_38;}}
//line 704
___nl__0 = null;
//line 704
___nl__4 = null;
//line 704
___nl__5 = null;
//line 704
___nl__6 = null;
//line 704
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 704
if (true) {goto label_38;}
//line 704
label_38:
//line 704
___nl__6 = null;
//line 705
___nl__8 = new ImmDouble(0);
//line 705
___nl__7 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 705
___nl__8 = null;
//line 705
___nl__6 = string_NL.NL_is_letter(___nl__7);

//line 705
___nl__7 = null;
//line 705
___nl__1 = ___nl__6;
//line 705
___nl__6 = null;
//line 706
if (true) {goto label_16;}
//line 706
label_36:
//line 707
___nl__6 = new ImmArray(new Imm[0]);
//line 707
c_rt_lib_NL.NL_die();
//line 707
___nl__6 = null;
//line 708
if (true) {goto label_16;}
//line 708
label_16:
//line 708
___nl__5 = null;
//line 709
if (true) {goto label_1;}
//line 709
label_1:
//line 709
___nl__4 = null;
//line 710
___nl__4 = new ImmString("");
//line 710
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__4);
//line 710
___nl__0 = null;
//line 710
___nl__3 = null;
//line 710
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__4;
//line 710
___nl__4 = null;
//line 710
___nl__3 = null;
//line 710
___nl__0 = null;
//line 710
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return null;
}

private static Imm NL_handle_ov_call_priv(Imm ___arg__0, ImmRef ___arg__1, ImmRef ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();Imm ___nl__2 = ___arg__2.getValue().clone();
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
//line 714
___nl__3 = new ImmString("incorrect command");
//line 714
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("err"), ___nl__3);
//line 715
___nl__4 = new ImmString("ov::mk");
//line 715
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__4.toString()));
//line 715
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 715
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 716
___nl__7 = new ImmDouble(0);
//line 716
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 716
___nl__7 = null;
//line 716
___nl__5 = nl_NL.NL_is_sim(___nl__6);

//line 716
___nl__6 = null;
//line 716
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 716
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 716
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_4;}}
//line 716
___nl__0 = null;
//line 716
___nl__4 = null;
//line 716
___nl__5 = null;
//line 716
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 716
if (true) {goto label_4;}
//line 716
label_4:
//line 716
___nl__5 = null;
//line 717
___nl__7 = new ImmDouble(0);
//line 717
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 717
___nl__7 = null;
//line 717
___nl__5 = ov_NL.NL_mk(___nl__6);

//line 717
___nl__6 = null;
//line 717
___nl__1 = ___nl__5;
//line 717
___nl__5 = null;
//line 718
if (true) {goto label_1;}
//line 718
label_2:
//line 718
___nl__4 = new ImmString("ov::mk_val");
//line 718
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__4.toString()));
//line 718
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 718
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_5;}}
//line 719
___nl__7 = new ImmDouble(0);
//line 719
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 719
___nl__7 = null;
//line 719
___nl__5 = nl_NL.NL_is_sim(___nl__6);

//line 719
___nl__6 = null;
//line 719
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 719
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 719
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_7;}}
//line 719
___nl__0 = null;
//line 719
___nl__4 = null;
//line 719
___nl__5 = null;
//line 719
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 719
if (true) {goto label_7;}
//line 719
label_7:
//line 719
___nl__5 = null;
//line 720
___nl__7 = new ImmDouble(0);
//line 720
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 720
___nl__7 = null;
//line 720
___nl__8 = new ImmDouble(1);
//line 720
___nl__7 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 720
___nl__8 = null;
//line 720
___nl__5 = ov_NL.NL_mk_val(___nl__6,___nl__7);

//line 720
___nl__7 = null;
//line 720
___nl__6 = null;
//line 720
___nl__1 = ___nl__5;
//line 720
___nl__5 = null;
//line 721
if (true) {goto label_1;}
//line 721
label_5:
//line 722
___nl__7 = new ImmDouble(0);
//line 722
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 722
___nl__7 = null;
//line 722
___nl__5 = nl_NL.NL_is_variant(___nl__6);

//line 722
___nl__6 = null;
//line 722
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 722
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 722
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_9;}}
//line 722
___nl__0 = null;
//line 722
___nl__4 = null;
//line 722
___nl__5 = null;
//line 722
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 722
if (true) {goto label_9;}
//line 722
label_9:
//line 722
___nl__5 = null;
//line 723
___nl__5 = new ImmString("ov::has_value");
//line 723
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__5.toString()));
//line 723
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 723
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_11;}}
//line 724
___nl__8 = new ImmDouble(0);
//line 724
___nl__7 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 724
___nl__8 = null;
//line 724
___nl__6 = ov_NL.NL_has_value(___nl__7);

//line 724
___nl__7 = null;
//line 724
___nl__1 = ___nl__6;
//line 724
___nl__6 = null;
//line 725
if (true) {goto label_17;}
//line 725
label_11:
//line 725
___nl__5 = new ImmString("ov::get_element");
//line 725
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__5.toString()));
//line 725
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 725
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_12;}}
//line 726
___nl__8 = new ImmDouble(0);
//line 726
___nl__7 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 726
___nl__8 = null;
//line 726
___nl__6 = ov_NL.NL_get_element(___nl__7);

//line 726
___nl__7 = null;
//line 726
___nl__1 = ___nl__6;
//line 726
___nl__6 = null;
//line 727
if (true) {goto label_17;}
//line 727
label_12:
//line 727
___nl__5 = new ImmString("ov::get_value");
//line 727
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__5.toString()));
//line 727
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 727
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_13;}}
//line 728
___nl__8 = new ImmDouble(0);
//line 728
___nl__7 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 728
___nl__8 = null;
//line 728
___nl__6 = ov_NL.NL_get_value(___nl__7);

//line 728
___nl__7 = null;
//line 728
___nl__1 = ___nl__6;
//line 728
___nl__6 = null;
//line 729
if (true) {goto label_17;}
//line 729
label_13:
//line 729
___nl__5 = new ImmString("ov::is");
//line 729
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__5.toString()));
//line 729
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 729
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_14;}}
//line 730
___nl__8 = new ImmDouble(1);
//line 730
___nl__7 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 730
___nl__8 = null;
//line 730
___nl__6 = nl_NL.NL_is_sim(___nl__7);

//line 730
___nl__7 = null;
//line 730
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 730
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 730
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_16;}}
//line 730
___nl__0 = null;
//line 730
___nl__4 = null;
//line 730
___nl__5 = null;
//line 730
___nl__6 = null;
//line 730
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 730
if (true) {goto label_16;}
//line 730
label_16:
//line 730
___nl__6 = null;
//line 731
___nl__8 = new ImmDouble(0);
//line 731
___nl__7 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 731
___nl__8 = null;
//line 731
___nl__9 = new ImmDouble(1);
//line 731
___nl__8 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()];
//line 731
___nl__9 = null;
//line 731
___nl__6 = ov_NL.NL_is(___nl__7,___nl__8);

//line 731
___nl__8 = null;
//line 731
___nl__7 = null;
//line 731
___nl__1 = ___nl__6;
//line 731
___nl__6 = null;
//line 732
if (true) {goto label_17;}
//line 732
label_14:
//line 732
___nl__5 = new ImmString("ov::as");
//line 732
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__5.toString()));
//line 732
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 732
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_17;}}
//line 733
___nl__8 = new ImmDouble(1);
//line 733
___nl__7 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 733
___nl__8 = null;
//line 733
___nl__6 = nl_NL.NL_is_sim(___nl__7);

//line 733
___nl__7 = null;
//line 733
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 733
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 733
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_19;}}
//line 733
___nl__0 = null;
//line 733
___nl__4 = null;
//line 733
___nl__5 = null;
//line 733
___nl__6 = null;
//line 733
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 733
if (true) {goto label_19;}
//line 733
label_19:
//line 733
___nl__6 = null;
//line 734
___nl__8 = new ImmDouble(0);
//line 734
___nl__7 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 734
___nl__8 = null;
//line 734
___nl__9 = new ImmDouble(1);
//line 734
___nl__8 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()];
//line 734
___nl__9 = null;
//line 734
___nl__6 = ov_NL.NL_is(___nl__7,___nl__8);

//line 734
___nl__8 = null;
//line 734
___nl__7 = null;
//line 734
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 734
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 734
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_21;}}
//line 734
___nl__0 = null;
//line 734
___nl__4 = null;
//line 734
___nl__5 = null;
//line 734
___nl__6 = null;
//line 734
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 734
if (true) {goto label_21;}
//line 734
label_21:
//line 734
___nl__6 = null;
//line 735
___nl__8 = new ImmDouble(0);
//line 735
___nl__7 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 735
___nl__8 = null;
//line 735
___nl__9 = new ImmDouble(1);
//line 735
___nl__8 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()];
//line 735
___nl__9 = null;
//line 735
___nl__6 = ov_NL.NL_as(___nl__7,___nl__8);

//line 735
___nl__8 = null;
//line 735
___nl__7 = null;
//line 735
___nl__1 = ___nl__6;
//line 735
___nl__6 = null;
//line 736
if (true) {goto label_17;}
//line 736
label_17:
//line 736
___nl__5 = null;
//line 737
if (true) {goto label_1;}
//line 737
label_1:
//line 737
___nl__4 = null;
//line 738
___nl__4 = new ImmString("");
//line 738
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__4);
//line 738
___nl__0 = null;
//line 738
___nl__3 = null;
//line 738
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__4;
//line 738
___nl__4 = null;
//line 738
___nl__3 = null;
//line 738
___nl__0 = null;
//line 738
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return null;
}

private static Imm NL_handle_c_rt_lib_call_priv(Imm ___arg__0, ImmRef ___arg__1, ImmRef ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();Imm ___nl__2 = ___arg__2.getValue().clone();
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
//line 742
___nl__3 = new ImmString("incorrect command");
//line 742
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("err"), ___nl__3);
//line 743
___nl__4 = new ImmString("c_rt_lib::array_len");
//line 743
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__4.toString()));
//line 743
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 743
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 744
___nl__7 = new ImmDouble(0);
//line 744
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 744
___nl__7 = null;
//line 744
___nl__5 = nl_NL.NL_is_array(___nl__6);

//line 744
___nl__6 = null;
//line 744
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 744
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 744
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_4;}}
//line 744
___nl__0 = null;
//line 744
___nl__4 = null;
//line 744
___nl__5 = null;
//line 744
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 744
if (true) {goto label_4;}
//line 744
label_4:
//line 744
___nl__5 = null;
//line 745
___nl__7 = new ImmDouble(0);
//line 745
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 745
___nl__7 = null;
//line 745
___nl__5 = c_rt_lib_NL.NL_array_len(___nl__6);

//line 745
___nl__6 = null;
//line 745
___nl__1 = ___nl__5;
//line 745
___nl__5 = null;
//line 746
if (true) {goto label_49;}
//line 746
label_2:
//line 746
___nl__4 = new ImmString("c_rt_lib::set_ref_arr");
//line 746
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__4.toString()));
//line 746
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 746
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_5;}}
//line 747
___nl__7 = new ImmDouble(0);
//line 747
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 747
___nl__7 = null;
//line 747
___nl__5 = nl_NL.NL_is_array(___nl__6);

//line 747
___nl__6 = null;
//line 747
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 747
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 747
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_7;}}
//line 747
___nl__0 = null;
//line 747
___nl__4 = null;
//line 747
___nl__5 = null;
//line 747
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 747
if (true) {goto label_7;}
//line 747
label_7:
//line 747
___nl__5 = null;
//line 748
___nl__7 = new ImmDouble(1);
//line 748
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 748
___nl__7 = null;
//line 748
___nl__5 = nl_NL.NL_is_sim(___nl__6);

//line 748
___nl__6 = null;
//line 748
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 748
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 748
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_9;}}
//line 748
___nl__0 = null;
//line 748
___nl__4 = null;
//line 748
___nl__5 = null;
//line 748
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 748
if (true) {goto label_9;}
//line 748
label_9:
//line 748
___nl__5 = null;
//line 749
___nl__7 = new ImmDouble(1);
//line 749
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 749
___nl__7 = null;
//line 749
___nl__5 = string_utils_NL.NL_is_number(___nl__6);

//line 749
___nl__6 = null;
//line 749
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 749
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 749
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_11;}}
//line 749
___nl__0 = null;
//line 749
___nl__4 = null;
//line 749
___nl__5 = null;
//line 749
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 749
if (true) {goto label_11;}
//line 749
label_11:
//line 749
___nl__5 = null;
//line 750
___nl__7 = new ImmDouble(1);
//line 750
___nl__5 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 750
___nl__7 = null;
//line 750
___nl__7 = new ImmDouble(0);
//line 750
___nl__5 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) );
//line 750
___nl__7 = null;
//line 750
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 750
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_14;}}
//line 750
___nl__7 = new ImmDouble(1);
//line 750
___nl__5 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 750
___nl__7 = null;
//line 750
___nl__9 = new ImmDouble(0);
//line 750
___nl__8 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()];
//line 750
___nl__9 = null;
//line 750
___nl__7 = array_NL.NL_len(___nl__8);

//line 750
___nl__8 = null;
//line 750
___nl__5 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))<(Double.Parse(___nl__7.getValue().ToString())) );
//line 750
___nl__7 = null;
//line 750
label_14:
//line 750
___nl__6 = null;
//line 750
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 750
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 750
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_13;}}
//line 750
___nl__0 = null;
//line 750
___nl__4 = null;
//line 750
___nl__5 = null;
//line 750
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 750
if (true) {goto label_13;}
//line 750
label_13:
//line 750
___nl__5 = null;
//line 751
___nl__6 = new ImmDouble(0);
//line 751
___nl__5 = c_rt_lib_NL.NL_get_ref_arr(___nl__2,___nl__6);

//line 751
___nl__8 = new ImmDouble(1);
//line 751
___nl__7 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 751
___nl__8 = null;
//line 751
___nl__9 = new ImmDouble(2);
//line 751
___nl__8 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()];
//line 751
___nl__9 = null;
//line 751
___ref______nl__5 = new ImmRef(___nl__5);
c_rt_lib_NL.NL_set_ref_arr(___ref______nl__5,___nl__7,___nl__8);
___nl__5 = ___ref______nl__5.getValue();

//line 751
___nl__8 = null;
//line 751
___nl__7 = null;
//line 751
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_arr(___ref______nl__2,___nl__6,___nl__5);
___nl__2 = ___ref______nl__2.getValue();

//line 751
___nl__5 = null;
//line 751
___nl__6 = null;
//line 752
if (true) {goto label_49;}
//line 752
label_5:
//line 752
___nl__4 = new ImmString("c_rt_lib::set_ref_hash");
//line 752
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__4.toString()));
//line 752
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 752
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_15;}}
//line 753
___nl__7 = new ImmDouble(0);
//line 753
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 753
___nl__7 = null;
//line 753
___nl__5 = nl_NL.NL_is_hash(___nl__6);

//line 753
___nl__6 = null;
//line 753
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 753
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 753
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_17;}}
//line 753
___nl__0 = null;
//line 753
___nl__4 = null;
//line 753
___nl__5 = null;
//line 753
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 753
if (true) {goto label_17;}
//line 753
label_17:
//line 753
___nl__5 = null;
//line 754
___nl__7 = new ImmDouble(1);
//line 754
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 754
___nl__7 = null;
//line 754
___nl__5 = nl_NL.NL_is_sim(___nl__6);

//line 754
___nl__6 = null;
//line 754
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 754
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 754
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_19;}}
//line 754
___nl__0 = null;
//line 754
___nl__4 = null;
//line 754
___nl__5 = null;
//line 754
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 754
if (true) {goto label_19;}
//line 754
label_19:
//line 754
___nl__5 = null;
//line 755
___nl__6 = new ImmDouble(0);
//line 755
___nl__5 = c_rt_lib_NL.NL_get_ref_arr(___nl__2,___nl__6);

//line 755
___nl__8 = new ImmDouble(1);
//line 755
___nl__7 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 755
___nl__8 = null;
//line 755
___nl__9 = new ImmDouble(2);
//line 755
___nl__8 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()];
//line 755
___nl__9 = null;
//line 755
___ref______nl__5 = new ImmRef(___nl__5);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__5,___nl__7,___nl__8);
___nl__5 = ___ref______nl__5.getValue();

//line 755
___nl__8 = null;
//line 755
___nl__7 = null;
//line 755
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_arr(___ref______nl__2,___nl__6,___nl__5);
___nl__2 = ___ref______nl__2.getValue();

//line 755
___nl__5 = null;
//line 755
___nl__6 = null;
//line 756
if (true) {goto label_49;}
//line 756
label_15:
//line 756
___nl__4 = new ImmString("c_rt_lib::get_ref_arr");
//line 756
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__4.toString()));
//line 756
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 756
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_20;}}
//line 757
___nl__7 = new ImmDouble(0);
//line 757
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 757
___nl__7 = null;
//line 757
___nl__5 = nl_NL.NL_is_array(___nl__6);

//line 757
___nl__6 = null;
//line 757
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 757
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 757
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_22;}}
//line 757
___nl__0 = null;
//line 757
___nl__4 = null;
//line 757
___nl__5 = null;
//line 757
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 757
if (true) {goto label_22;}
//line 757
label_22:
//line 757
___nl__5 = null;
//line 758
___nl__7 = new ImmDouble(1);
//line 758
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 758
___nl__7 = null;
//line 758
___nl__5 = nl_NL.NL_is_sim(___nl__6);

//line 758
___nl__6 = null;
//line 758
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 758
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 758
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_24;}}
//line 758
___nl__0 = null;
//line 758
___nl__4 = null;
//line 758
___nl__5 = null;
//line 758
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 758
if (true) {goto label_24;}
//line 758
label_24:
//line 758
___nl__5 = null;
//line 759
___nl__7 = new ImmDouble(1);
//line 759
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 759
___nl__7 = null;
//line 759
___nl__5 = string_utils_NL.NL_is_number(___nl__6);

//line 759
___nl__6 = null;
//line 759
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 759
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 759
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_26;}}
//line 759
___nl__0 = null;
//line 759
___nl__4 = null;
//line 759
___nl__5 = null;
//line 759
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 759
if (true) {goto label_26;}
//line 759
label_26:
//line 759
___nl__5 = null;
//line 760
___nl__7 = new ImmDouble(1);
//line 760
___nl__5 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 760
___nl__7 = null;
//line 760
___nl__7 = new ImmDouble(0);
//line 760
___nl__5 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) );
//line 760
___nl__7 = null;
//line 760
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 760
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_29;}}
//line 760
___nl__7 = new ImmDouble(1);
//line 760
___nl__5 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 760
___nl__7 = null;
//line 760
___nl__9 = new ImmDouble(0);
//line 760
___nl__8 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()];
//line 760
___nl__9 = null;
//line 760
___nl__7 = array_NL.NL_len(___nl__8);

//line 760
___nl__8 = null;
//line 760
___nl__5 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))<(Double.Parse(___nl__7.getValue().ToString())) );
//line 760
___nl__7 = null;
//line 760
label_29:
//line 760
___nl__6 = null;
//line 760
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 760
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 760
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_28;}}
//line 760
___nl__0 = null;
//line 760
___nl__4 = null;
//line 760
___nl__5 = null;
//line 760
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 760
if (true) {goto label_28;}
//line 760
label_28:
//line 760
___nl__5 = null;
//line 761
___nl__7 = new ImmDouble(0);
//line 761
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 761
___nl__7 = null;
//line 761
___nl__8 = new ImmDouble(1);
//line 761
___nl__7 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 761
___nl__8 = null;
//line 761
___nl__5 = c_rt_lib_NL.NL_get_ref_arr(___nl__6,___nl__7);

//line 761
___nl__7 = null;
//line 761
___nl__6 = null;
//line 761
___nl__1 = ___nl__5;
//line 761
___nl__5 = null;
//line 762
if (true) {goto label_49;}
//line 762
label_20:
//line 762
___nl__4 = new ImmString("c_rt_lib::get_ref_hash");
//line 762
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__4.toString()));
//line 762
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 762
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_30;}}
//line 763
___nl__7 = new ImmDouble(0);
//line 763
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 763
___nl__7 = null;
//line 763
___nl__5 = nl_NL.NL_is_hash(___nl__6);

//line 763
___nl__6 = null;
//line 763
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 763
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 763
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_32;}}
//line 763
___nl__0 = null;
//line 763
___nl__4 = null;
//line 763
___nl__5 = null;
//line 763
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 763
if (true) {goto label_32;}
//line 763
label_32:
//line 763
___nl__5 = null;
//line 764
___nl__7 = new ImmDouble(1);
//line 764
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 764
___nl__7 = null;
//line 764
___nl__5 = nl_NL.NL_is_sim(___nl__6);

//line 764
___nl__6 = null;
//line 764
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 764
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 764
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_34;}}
//line 764
___nl__0 = null;
//line 764
___nl__4 = null;
//line 764
___nl__5 = null;
//line 764
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 764
if (true) {goto label_34;}
//line 764
label_34:
//line 764
___nl__5 = null;
//line 765
___nl__7 = new ImmDouble(0);
//line 765
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 765
___nl__7 = null;
//line 765
___nl__8 = new ImmDouble(1);
//line 765
___nl__7 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 765
___nl__8 = null;
//line 765
___nl__5 = hash_NL.NL_has_key(___nl__6,___nl__7);

//line 765
___nl__7 = null;
//line 765
___nl__6 = null;
//line 765
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 765
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 765
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_36;}}
//line 765
___nl__0 = null;
//line 765
___nl__4 = null;
//line 765
___nl__5 = null;
//line 765
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 765
if (true) {goto label_36;}
//line 765
label_36:
//line 765
___nl__5 = null;
//line 766
___nl__7 = new ImmDouble(0);
//line 766
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 766
___nl__7 = null;
//line 766
___nl__8 = new ImmDouble(1);
//line 766
___nl__7 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 766
___nl__8 = null;
//line 766
___nl__5 = c_rt_lib_NL.NL_get_ref_hash(___nl__6,___nl__7);

//line 766
___nl__7 = null;
//line 766
___nl__6 = null;
//line 766
___nl__1 = ___nl__5;
//line 766
___nl__5 = null;
//line 767
if (true) {goto label_49;}
//line 767
label_30:
//line 767
___nl__4 = new ImmString("c_rt_lib::init_iter");
//line 767
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__4.toString()));
//line 767
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 767
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_37;}}
//line 768
___nl__7 = new ImmDouble(0);
//line 768
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 768
___nl__7 = null;
//line 768
___nl__5 = nl_NL.NL_is_hash(___nl__6);

//line 768
___nl__6 = null;
//line 768
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 768
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 768
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_39;}}
//line 768
___nl__0 = null;
//line 768
___nl__4 = null;
//line 768
___nl__5 = null;
//line 768
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 768
if (true) {goto label_39;}
//line 768
label_39:
//line 768
___nl__5 = null;
//line 769
___nl__7 = new ImmDouble(0);
//line 769
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 769
___nl__7 = null;
//line 769
___nl__5 = c_rt_lib_NL.NL_init_iter(___nl__6);

//line 769
___nl__6 = null;
//line 769
___nl__1 = ___nl__5;
//line 769
___nl__5 = null;
//line 770
if (true) {goto label_49;}
//line 770
label_37:
//line 770
___nl__4 = new ImmString("c_rt_lib::is_end_hash");
//line 770
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__4.toString()));
//line 770
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 770
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_40;}}
//line 771
___nl__7 = new ImmDouble(0);
//line 771
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 771
___nl__7 = null;
//line 771
___nl__5 = c_rt_lib_NL.NL_is_end_hash(___nl__6);

//line 771
___nl__6 = null;
//line 771
___nl__1 = ___nl__5;
//line 771
___nl__5 = null;
//line 772
if (true) {goto label_49;}
//line 772
label_40:
//line 772
___nl__4 = new ImmString("c_rt_lib::get_key_iter");
//line 772
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__4.toString()));
//line 772
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 772
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_41;}}
//line 773
___nl__7 = new ImmDouble(0);
//line 773
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 773
___nl__7 = null;
//line 773
___nl__5 = c_rt_lib_NL.NL_get_key_iter(___nl__6);

//line 773
___nl__6 = null;
//line 773
___nl__1 = ___nl__5;
//line 773
___nl__5 = null;
//line 774
if (true) {goto label_49;}
//line 774
label_41:
//line 774
___nl__4 = new ImmString("c_rt_lib::hash_get_value");
//line 774
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__4.toString()));
//line 774
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 774
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_42;}}
//line 775
___nl__7 = new ImmDouble(0);
//line 775
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 775
___nl__7 = null;
//line 775
___nl__5 = nl_NL.NL_is_hash(___nl__6);

//line 775
___nl__6 = null;
//line 775
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 775
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 775
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_44;}}
//line 775
___nl__0 = null;
//line 775
___nl__4 = null;
//line 775
___nl__5 = null;
//line 775
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 775
if (true) {goto label_44;}
//line 775
label_44:
//line 775
___nl__5 = null;
//line 776
___nl__7 = new ImmDouble(1);
//line 776
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 776
___nl__7 = null;
//line 776
___nl__5 = nl_NL.NL_is_sim(___nl__6);

//line 776
___nl__6 = null;
//line 776
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 776
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 776
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_46;}}
//line 776
___nl__0 = null;
//line 776
___nl__4 = null;
//line 776
___nl__5 = null;
//line 776
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 776
if (true) {goto label_46;}
//line 776
label_46:
//line 776
___nl__5 = null;
//line 777
___nl__7 = new ImmDouble(0);
//line 777
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 777
___nl__7 = null;
//line 777
___nl__8 = new ImmDouble(1);
//line 777
___nl__7 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 777
___nl__8 = null;
//line 777
___nl__5 = hash_NL.NL_has_key(___nl__6,___nl__7);

//line 777
___nl__7 = null;
//line 777
___nl__6 = null;
//line 777
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 777
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 777
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_48;}}
//line 777
___nl__0 = null;
//line 777
___nl__4 = null;
//line 777
___nl__5 = null;
//line 777
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__3;
//line 777
if (true) {goto label_48;}
//line 777
label_48:
//line 777
___nl__5 = null;
//line 778
___nl__7 = new ImmDouble(0);
//line 778
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 778
___nl__7 = null;
//line 778
___nl__8 = new ImmDouble(1);
//line 778
___nl__7 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 778
___nl__8 = null;
//line 778
___nl__5 = c_rt_lib_NL.NL_hash_get_value(___nl__6,___nl__7);

//line 778
___nl__7 = null;
//line 778
___nl__6 = null;
//line 778
___nl__1 = ___nl__5;
//line 778
___nl__5 = null;
//line 779
if (true) {goto label_49;}
//line 779
label_42:
//line 779
___nl__4 = new ImmString("c_rt_lib::next_iter");
//line 779
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__4.toString()));
//line 779
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 779
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_49;}}
//line 780
___nl__7 = new ImmDouble(0);
//line 780
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 780
___nl__7 = null;
//line 780
___nl__5 = c_rt_lib_NL.NL_next_iter(___nl__6);

//line 780
___nl__6 = null;
//line 780
___nl__1 = ___nl__5;
//line 780
___nl__5 = null;
//line 781
if (true) {goto label_49;}
//line 781
label_49:
//line 781
___nl__4 = null;
//line 782
___nl__4 = new ImmString("");
//line 782
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__4);
//line 782
___nl__0 = null;
//line 782
___nl__3 = null;
//line 782
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return ___nl__4;
//line 782
___nl__4 = null;
//line 782
___nl__3 = null;
//line 782
___nl__0 = null;
//line 782
___arg__1.setValue(___nl__1);___arg__2.setValue(___nl__2);if(true) return null;
}

private static Imm NL_handle_compiler_call_priv(Imm ___arg__0, Imm ___arg__1, ImmRef ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.getValue().clone();
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
//line 785
___nl__3 = new ImmArray(new Imm[0]);
//line 786
___nl__4 = ((ImmHash)___nl__0).getHashValue()["args"];
//line 786
___nl__6 = new ImmDouble(0);
//line 786
___nl__7 = new ImmDouble(1);
//line 786
___nl__8 = c_rt_lib_NL.NL_array_len(___nl__4);

//line 786
label_3:
//line 786
___nl__9 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__6.getValue().ToString()))>=(Double.Parse(___nl__8.getValue().ToString())) );
//line 786
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_1;}}
//line 786
___nl__5 = (___nl__4 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()];
//line 788
___nl__11 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("val"));
//line 788
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_5;}}
//line 790
___nl__11 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("ref"));
//line 790
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_6;}}
//line 790
___nl__11 = new ImmString("NOMATCHALERT");
//line 790
___nl__11 = new ImmArray(new Imm[] {___nl__11,___nl__5,});
//line 790
c_rt_lib_NL.NL_die();
//line 788
label_5:
//line 788
___nl__12 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("val"));
//line 789
___nl__13 = ((ImmHash)___nl__2).getHashValue()["top"];
//line 789
___nl__13 = ((ImmHash)___nl__13).getHashValue()["vars"];
//line 789
___nl__13 = (___nl__13 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__12).getDoubleValue()];
//line 789
___nl__10 = ___nl__13;
//line 789
___nl__13 = null;
//line 789
___nl__12 = null;
//line 790
if (true) {goto label_4;}
//line 790
label_6:
//line 790
___nl__12 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("ref"));
//line 791
___nl__13 = ((ImmHash)___nl__2).getHashValue()["top"];
//line 791
___nl__13 = ((ImmHash)___nl__13).getHashValue()["vars"];
//line 791
___nl__13 = (___nl__13 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__12).getDoubleValue()];
//line 791
___nl__10 = ___nl__13;
//line 791
___nl__13 = null;
//line 791
___nl__12 = null;
//line 792
if (true) {goto label_4;}
//line 792
label_4:
//line 792
___nl__11 = null;
//line 793
___ref______nl__3 = new ImmRef(___nl__3);
array_NL.NL_push(___ref______nl__3,___nl__10);
___nl__3 = ___ref______nl__3.getValue();

//line 793
___nl__10 = null;
//line 794
___nl__6 = new ImmDouble((Double.Parse(___nl__6.getValue().ToString()))+(Double.Parse(___nl__7.getValue().ToString())));
//line 794
if (true) {goto label_3;}
//line 794
label_1:
//line 794
___nl__4 = null;
//line 794
___nl__5 = null;
//line 794
___nl__6 = null;
//line 794
___nl__7 = null;
//line 794
___nl__8 = null;
//line 794
___nl__9 = null;
//line 795
___nl__4 = new ImmString("");
//line 797
___nl__6 = ((ImmHash)___nl__0).getHashValue()["mod"];
//line 797
___nl__7 = new ImmString("array");
//line 797
___nl__6 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__7.toString()));
//line 797
___nl__7 = null;
//line 797
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 797
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_8;}}
//line 798
___ref______nl__4 = new ImmRef(___nl__4);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__7 = interpreter_NL.NL_handle_array_call_priv(___nl__1,___ref______nl__4,___ref______nl__3);
___nl__4 = ___ref______nl__4.getValue();
___nl__3 = ___ref______nl__3.getValue();

//line 798
___nl__5 = ___nl__7;
//line 798
___nl__7 = null;
//line 799
if (true) {goto label_7;}
//line 799
label_8:
//line 799
___nl__6 = ((ImmHash)___nl__0).getHashValue()["mod"];
//line 799
___nl__7 = new ImmString("hash");
//line 799
___nl__6 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__7.toString()));
//line 799
___nl__7 = null;
//line 799
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 799
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_9;}}
//line 800
___ref______nl__4 = new ImmRef(___nl__4);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__7 = interpreter_NL.NL_handle_hash_call_priv(___nl__1,___ref______nl__4,___ref______nl__3);
___nl__4 = ___ref______nl__4.getValue();
___nl__3 = ___ref______nl__3.getValue();

//line 800
___nl__5 = ___nl__7;
//line 800
___nl__7 = null;
//line 801
if (true) {goto label_7;}
//line 801
label_9:
//line 801
___nl__6 = ((ImmHash)___nl__0).getHashValue()["mod"];
//line 801
___nl__7 = new ImmString("string");
//line 801
___nl__6 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__7.toString()));
//line 801
___nl__7 = null;
//line 801
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 801
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_10;}}
//line 802
___ref______nl__4 = new ImmRef(___nl__4);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__7 = interpreter_NL.NL_handle_string_call_priv(___nl__1,___ref______nl__4,___ref______nl__3);
___nl__4 = ___ref______nl__4.getValue();
___nl__3 = ___ref______nl__3.getValue();

//line 802
___nl__5 = ___nl__7;
//line 802
___nl__7 = null;
//line 803
if (true) {goto label_7;}
//line 803
label_10:
//line 803
___nl__6 = ((ImmHash)___nl__0).getHashValue()["mod"];
//line 803
___nl__7 = new ImmString("ov");
//line 803
___nl__6 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__7.toString()));
//line 803
___nl__7 = null;
//line 803
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 803
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_11;}}
//line 804
___ref______nl__4 = new ImmRef(___nl__4);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__7 = interpreter_NL.NL_handle_ov_call_priv(___nl__1,___ref______nl__4,___ref______nl__3);
___nl__4 = ___ref______nl__4.getValue();
___nl__3 = ___ref______nl__3.getValue();

//line 804
___nl__5 = ___nl__7;
//line 804
___nl__7 = null;
//line 805
if (true) {goto label_7;}
//line 805
label_11:
//line 805
___nl__6 = ((ImmHash)___nl__0).getHashValue()["mod"];
//line 805
___nl__7 = new ImmString("c_rt_lib");
//line 805
___nl__6 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__7.toString()));
//line 805
___nl__7 = null;
//line 805
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 805
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_12;}}
//line 806
___ref______nl__4 = new ImmRef(___nl__4);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__7 = interpreter_NL.NL_handle_c_rt_lib_call_priv(___nl__1,___ref______nl__4,___ref______nl__3);
___nl__4 = ___ref______nl__4.getValue();
___nl__3 = ___ref______nl__3.getValue();

//line 806
___nl__5 = ___nl__7;
//line 806
___nl__7 = null;
//line 807
if (true) {goto label_7;}
//line 807
label_12:
//line 808
___nl__7 = new ImmArray(new Imm[0]);
//line 808
c_rt_lib_NL.NL_die();
//line 808
___nl__7 = null;
//line 809
if (true) {goto label_7;}
//line 809
label_7:
//line 809
___nl__6 = null;
//line 810
___nl__6 = ___nl__5;
//line 810
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("err"));
//line 810
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 810
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_14;}}
//line 811
___nl__7 = ___nl__5;
//line 811
___nl__7 = c_rt_lib_NL.NL_ov_as(___nl__7, new ImmString("err"));
//line 811
___nl__7 = new ImmString(___nl__7.toString() + ___nl__1.toString());
//line 811
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("error"), ___nl__7);
//line 811
___nl__8 = ___nl__7;
//line 811
((ImmHash)___nl__2).set("rstate", ___nl__8);
//line 811
___nl__7 = null;
//line 811
___nl__8 = null;
//line 812
if (true) {goto label_13;}
//line 812
label_14:
//line 813
___nl__8 = ((ImmHash)___nl__0).getHashValue()["args"];
//line 813
___nl__7 = array_NL.NL_len(___nl__8);

//line 813
___nl__8 = null;
//line 813
___nl__8 = new ImmDouble(0);
//line 813
___nl__9 = new ImmDouble(1);
//line 813
label_17:
//line 813
___nl__10 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) );
//line 813
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_15;}}
//line 814
___nl__11 = ((ImmHash)___nl__0).getHashValue()["args"];
//line 814
___nl__11 = (___nl__11 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 815
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("val"));
//line 815
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_19;}}
//line 816
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("ref"));
//line 816
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_20;}}
//line 816
___nl__12 = new ImmString("NOMATCHALERT");
//line 816
___nl__12 = new ImmArray(new Imm[] {___nl__12,___nl__11,});
//line 816
c_rt_lib_NL.NL_die();
//line 815
label_19:
//line 815
___nl__13 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("val"));
//line 815
___nl__13 = null;
//line 816
if (true) {goto label_18;}
//line 816
label_20:
//line 816
___nl__13 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("ref"));
//line 817
___nl__14 = (___nl__3 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 817
___nl__15 = new ImmString("top");
//line 817
___nl__15 = c_rt_lib_NL.NL_get_ref_hash(___nl__2,___nl__15);

//line 817
___nl__16 = new ImmString("vars");
//line 817
___nl__16 = c_rt_lib_NL.NL_get_ref_hash(___nl__15,___nl__16);

//line 817
___nl__17 = ___nl__14;
//line 817
(___nl__16 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__13).getDoubleValue()] = ___nl__17;
//line 817
___nl__18 = new ImmString("vars");
//line 817
___ref______nl__15 = new ImmRef(___nl__15);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__15,___nl__18,___nl__16);
___nl__15 = ___ref______nl__15.getValue();

//line 817
___nl__18 = new ImmString("top");
//line 817
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__2,___nl__18,___nl__15);
___nl__2 = ___ref______nl__2.getValue();

//line 817
___nl__18 = null;
//line 817
___nl__14 = null;
//line 817
___nl__15 = null;
//line 817
___nl__16 = null;
//line 817
___nl__17 = null;
//line 817
___nl__13 = null;
//line 818
if (true) {goto label_18;}
//line 818
label_18:
//line 818
___nl__12 = null;
//line 818
___nl__11 = null;
//line 819
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))+(Double.Parse(___nl__9.getValue().ToString())));
//line 819
if (true) {goto label_17;}
//line 819
label_15:
//line 819
___nl__7 = null;
//line 819
___nl__8 = null;
//line 819
___nl__9 = null;
//line 819
___nl__10 = null;
//line 820
___nl__7 = ((ImmHash)___nl__0).getHashValue()["dest"];
//line 820
___nl__8 = new ImmString("");
//line 820
___nl__7 = c_rt_lib_NL.NL_native_to_nl(___nl__7.toString().Equals(___nl__8.toString()));
//line 820
___nl__8 = null;
//line 820
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 820
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 820
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_22;}}
//line 820
___nl__8 = new ImmString("top");
//line 820
___nl__8 = c_rt_lib_NL.NL_get_ref_hash(___nl__2,___nl__8);

//line 820
___nl__9 = new ImmString("vars");
//line 820
___nl__9 = c_rt_lib_NL.NL_get_ref_hash(___nl__8,___nl__9);

//line 820
___nl__11 = ((ImmHash)___nl__0).getHashValue()["dest"];
//line 820
___nl__10 = ___nl__4;
//line 820
(___nl__9 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__11).getDoubleValue()] = ___nl__10;
//line 820
___nl__12 = new ImmString("vars");
//line 820
___ref______nl__8 = new ImmRef(___nl__8);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__8,___nl__12,___nl__9);
___nl__8 = ___ref______nl__8.getValue();

//line 820
___nl__12 = new ImmString("top");
//line 820
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__2,___nl__12,___nl__8);
___nl__2 = ___ref______nl__2.getValue();

//line 820
___nl__12 = null;
//line 820
___nl__8 = null;
//line 820
___nl__9 = null;
//line 820
___nl__10 = null;
//line 820
___nl__11 = null;
//line 820
if (true) {goto label_22;}
//line 820
label_22:
//line 820
___nl__7 = null;
//line 821
if (true) {goto label_13;}
//line 821
label_13:
//line 821
___nl__6 = null;
//line 821
___nl__3 = null;
//line 821
___nl__4 = null;
//line 821
___nl__5 = null;
//line 821
___nl__0 = null;
//line 821
___nl__1 = null;
//line 821
___arg__2.setValue(___nl__2);if(true) return null;
}

private static Imm NL_handle_return_priv(Imm ___arg__0, ImmRef ___arg__1) {
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
//line 826
___nl__2 = interpreter_NL.NL_get_none_variant();

//line 827
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("val"));
//line 827
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 829
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("emp"));
//line 829
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 829
___nl__3 = new ImmString("NOMATCHALERT");
//line 829
___nl__3 = new ImmArray(new Imm[] {___nl__3,___nl__0,});
//line 829
c_rt_lib_NL.NL_die();
//line 827
label_2:
//line 827
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("val"));
//line 828
___nl__5 = ((ImmHash)___nl__1).getHashValue()["top"];
//line 828
___nl__5 = ((ImmHash)___nl__5).getHashValue()["vars"];
//line 828
___nl__5 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()];
//line 828
___nl__2 = ___nl__5;
//line 828
___nl__5 = null;
//line 828
___nl__4 = null;
//line 829
if (true) {goto label_1;}
//line 829
label_3:
//line 830
if (true) {goto label_1;}
//line 830
label_1:
//line 830
___nl__3 = null;
//line 831
___nl__4 = ((ImmHash)___nl__1).getHashValue()["stack"];
//line 831
___nl__3 = array_NL.NL_len(___nl__4);

//line 831
___nl__4 = null;
//line 831
___nl__4 = new ImmDouble(0);
//line 831
___nl__3 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString())) ==((Double.Parse(___nl__4.getValue().ToString())))  );
//line 831
___nl__4 = null;
//line 831
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 831
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_5;}}
//line 832
___nl__5 = ((ImmHash)___nl__1).getHashValue()["func"];
//line 832
___nl__5 = ((ImmHash)___nl__5).getHashValue()["commands"];
//line 832
___nl__4 = array_NL.NL_len(___nl__5);

//line 832
___nl__5 = null;
//line 832
___nl__5 = new ImmString("top");
//line 832
___nl__5 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__5);

//line 832
___nl__6 = ___nl__4;
//line 832
((ImmHash)___nl__5).set("next", ___nl__6);
//line 832
___nl__7 = new ImmString("top");
//line 832
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__7,___nl__5);
___nl__1 = ___ref______nl__1.getValue();

//line 832
___nl__7 = null;
//line 832
___nl__4 = null;
//line 832
___nl__5 = null;
//line 832
___nl__6 = null;
//line 833
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("finished"), ___nl__2);
//line 833
___nl__5 = ___nl__4;
//line 833
((ImmHash)___nl__1).set("rstate", ___nl__5);
//line 833
___nl__4 = null;
//line 833
___nl__5 = null;
//line 834
if (true) {goto label_4;}
//line 834
label_5:
//line 835
___nl__4 = ((ImmHash)___nl__1).getHashValue()["top"];
//line 835
___nl__4 = ((ImmHash)___nl__4).getHashValue()["ref_arguments"];
//line 836
___nl__5 = ((ImmHash)___nl__1).getHashValue()["top"];
//line 836
___nl__5 = ((ImmHash)___nl__5).getHashValue()["vars"];
//line 837
___nl__6 = ((ImmHash)___nl__1).getHashValue()["top"];
//line 837
___nl__6 = ((ImmHash)___nl__6).getHashValue()["ret"];
//line 838
___nl__7 = ((ImmHash)___nl__1).getHashValue()["stack"];
//line 838
___nl__9 = ((ImmHash)___nl__1).getHashValue()["stack"];
//line 838
___nl__8 = array_NL.NL_len(___nl__9);

//line 838
___nl__9 = null;
//line 838
___nl__9 = new ImmDouble(1);
//line 838
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))-(Double.Parse(___nl__9.getValue().ToString())));
//line 838
___nl__9 = null;
//line 838
___nl__7 = (___nl__7 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 838
___nl__8 = null;
//line 839
___nl__8 = new ImmString("stack");
//line 839
___nl__8 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__8);

//line 839
___ref______nl__8 = new ImmRef(___nl__8);
array_NL.NL_pop(___ref______nl__8);
___nl__8 = ___ref______nl__8.getValue();

//line 839
___nl__9 = new ImmString("stack");
//line 839
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__9,___nl__8);
___nl__1 = ___ref______nl__1.getValue();

//line 839
___nl__9 = null;
//line 839
___nl__8 = null;
//line 840
___nl__8 = ___nl__7;
//line 840
((ImmHash)___nl__1).set("top", ___nl__8);
//line 840
___nl__8 = null;
//line 841
___nl__9 = ((ImmHash)___nl__1).getHashValue()["functions"];
//line 841
___nl__10 = ((ImmHash)___nl__1).getHashValue()["top"];
//line 841
___nl__10 = ((ImmHash)___nl__10).getHashValue()["func_key"];
//line 841
___nl__8 = hash_NL.NL_get_value(___nl__9,___nl__10);

//line 841
___nl__10 = null;
//line 841
___nl__9 = null;
//line 841
___nl__9 = ___nl__8;
//line 841
((ImmHash)___nl__1).set("func", ___nl__9);
//line 841
___nl__8 = null;
//line 841
___nl__9 = null;
//line 842
___nl__10 = c_rt_lib_NL.NL_init_iter(___nl__4);

//line 842
label_8:
//line 842
___nl__8 = c_rt_lib_NL.NL_is_end_hash(___nl__10);

//line 842
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_6;}}
//line 842
___nl__8 = c_rt_lib_NL.NL_get_key_iter(___nl__10);

//line 842
___nl__9 = c_rt_lib_NL.NL_hash_get_value(___nl__4,___nl__8);

//line 843
___nl__11 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 844
___nl__12 = new ImmString("top");
//line 844
___nl__12 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__12);

//line 844
___nl__13 = new ImmString("vars");
//line 844
___nl__13 = c_rt_lib_NL.NL_get_ref_hash(___nl__12,___nl__13);

//line 844
___nl__14 = ___nl__11;
//line 844
(___nl__13 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()] = ___nl__14;
//line 844
___nl__15 = new ImmString("vars");
//line 844
___ref______nl__12 = new ImmRef(___nl__12);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__12,___nl__15,___nl__13);
___nl__12 = ___ref______nl__12.getValue();

//line 844
___nl__15 = new ImmString("top");
//line 844
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__15,___nl__12);
___nl__1 = ___ref______nl__1.getValue();

//line 844
___nl__15 = null;
//line 844
___nl__12 = null;
//line 844
___nl__13 = null;
//line 844
___nl__14 = null;
//line 844
___nl__11 = null;
//line 845
___nl__10 = c_rt_lib_NL.NL_next_iter(___nl__10);

//line 845
if (true) {goto label_8;}
//line 845
label_6:
//line 845
___nl__8 = null;
//line 845
___nl__9 = null;
//line 845
___nl__10 = null;
//line 846
___nl__8 = new ImmString("");
//line 846
___nl__8 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__8.toString()));
//line 846
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8));
//line 846
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8));
//line 846
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_10;}}
//line 846
___nl__9 = new ImmString("top");
//line 846
___nl__9 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__9);

//line 846
___nl__10 = new ImmString("vars");
//line 846
___nl__10 = c_rt_lib_NL.NL_get_ref_hash(___nl__9,___nl__10);

//line 846
___nl__11 = ___nl__2;
//line 846
(___nl__10 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()] = ___nl__11;
//line 846
___nl__12 = new ImmString("vars");
//line 846
___ref______nl__9 = new ImmRef(___nl__9);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__9,___nl__12,___nl__10);
___nl__9 = ___ref______nl__9.getValue();

//line 846
___nl__12 = new ImmString("top");
//line 846
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__12,___nl__9);
___nl__1 = ___ref______nl__1.getValue();

//line 846
___nl__12 = null;
//line 846
___nl__9 = null;
//line 846
___nl__10 = null;
//line 846
___nl__11 = null;
//line 846
if (true) {goto label_10;}
//line 846
label_10:
//line 846
___nl__8 = null;
//line 846
___nl__4 = null;
//line 846
___nl__5 = null;
//line 846
___nl__6 = null;
//line 846
___nl__7 = null;
//line 847
if (true) {goto label_4;}
//line 847
label_4:
//line 847
___nl__3 = null;
//line 848
___nl__3 = new ImmDouble(1);
//line 848
___nl__3 = new ImmDouble(-((ImmDouble)___nl__3).getDoubleValue());
//line 848
___nl__4 = ___nl__3;
//line 848
((ImmHash)___nl__1).set("instruction_nr", ___nl__4);
//line 848
___nl__3 = null;
//line 848
___nl__4 = null;
//line 849
___nl__3 = new ImmString("top");
//line 849
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__3);

//line 849
___nl__4 = new ImmString("next");
//line 849
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__3,___nl__4);

//line 849
___nl__5 = new ImmDouble(1);
//line 849
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString())));
//line 849
___nl__6 = new ImmString("next");
//line 849
___ref______nl__3 = new ImmRef(___nl__3);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__3,___nl__6,___nl__4);
___nl__3 = ___ref______nl__3.getValue();

//line 849
___nl__6 = new ImmString("top");
//line 849
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__6,___nl__3);
___nl__1 = ___ref______nl__1.getValue();

//line 849
___nl__6 = null;
//line 849
___nl__3 = null;
//line 849
___nl__4 = null;
//line 849
___nl__5 = null;
//line 849
___nl__2 = null;
//line 849
___nl__0 = null;
//line 849
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_goto_priv(ImmRef ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.clone();
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
//line 853
___nl__3 = ((ImmHash)___nl__0).getHashValue()["labels"];
//line 853
___nl__4 = ((ImmHash)___nl__0).getHashValue()["top"];
//line 853
___nl__4 = ((ImmHash)___nl__4).getHashValue()["module_name"];
//line 853
___nl__2 = hash_NL.NL_get_value(___nl__3,___nl__4);

//line 853
___nl__4 = null;
//line 853
___nl__3 = null;
//line 854
___nl__4 = ((ImmHash)___nl__0).getHashValue()["top"];
//line 854
___nl__4 = ((ImmHash)___nl__4).getHashValue()["func_key"];
//line 854
___nl__3 = hash_NL.NL_get_value(___nl__2,___nl__4);

//line 854
___nl__4 = null;
//line 855
___nl__4 = hash_NL.NL_has_key(___nl__3,___nl__1);

//line 855
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 855
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 855
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 856
___nl__5 = new ImmArray(new Imm[0]);
//line 856
c_rt_lib_NL.NL_die();
//line 856
___nl__5 = null;
//line 857
if (true) {goto label_2;}
//line 857
label_2:
//line 857
___nl__4 = null;
//line 858
___nl__4 = hash_NL.NL_get_value(___nl__3,___nl__1);

//line 858
___nl__5 = new ImmDouble(1);
//line 858
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString())));
//line 858
___nl__5 = null;
//line 858
___nl__5 = new ImmString("top");
//line 858
___nl__5 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__5);

//line 858
___nl__6 = ___nl__4;
//line 858
((ImmHash)___nl__5).set("next", ___nl__6);
//line 858
___nl__7 = new ImmString("top");
//line 858
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__7,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 858
___nl__7 = null;
//line 858
___nl__4 = null;
//line 858
___nl__5 = null;
//line 858
___nl__6 = null;
//line 858
___nl__2 = null;
//line 858
___nl__3 = null;
//line 858
___nl__1 = null;
//line 858
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_execute_bin_op_priv(Imm ___arg__0, Imm ___arg__1, Imm ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();
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
//line 862
___nl__3 = new ImmString("+");
//line 862
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 862
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 862
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 862
___nl__4 = new ImmDouble((Double.Parse(___nl__0.getValue().ToString()))+(Double.Parse(___nl__1.getValue().ToString())));
//line 862
___nl__0 = null;
//line 862
___nl__1 = null;
//line 862
___nl__2 = null;
//line 862
___nl__3 = null;
//line 862
if(true) return ___nl__4;
//line 862
___nl__4 = null;
//line 862
if (true) {goto label_2;}
//line 862
label_2:
//line 862
___nl__3 = null;
//line 863
___nl__3 = new ImmString("-");
//line 863
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 863
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 863
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_4;}}
//line 863
___nl__4 = new ImmDouble((Double.Parse(___nl__0.getValue().ToString()))-(Double.Parse(___nl__1.getValue().ToString())));
//line 863
___nl__0 = null;
//line 863
___nl__1 = null;
//line 863
___nl__2 = null;
//line 863
___nl__3 = null;
//line 863
if(true) return ___nl__4;
//line 863
___nl__4 = null;
//line 863
if (true) {goto label_4;}
//line 863
label_4:
//line 863
___nl__3 = null;
//line 864
___nl__3 = new ImmString("*");
//line 864
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 864
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 864
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_6;}}
//line 864
___nl__4 = new ImmDouble((Double.Parse(___nl__0.getValue().ToString()))*(Double.Parse(___nl__1.getValue().ToString())));
//line 864
___nl__0 = null;
//line 864
___nl__1 = null;
//line 864
___nl__2 = null;
//line 864
___nl__3 = null;
//line 864
if(true) return ___nl__4;
//line 864
___nl__4 = null;
//line 864
if (true) {goto label_6;}
//line 864
label_6:
//line 864
___nl__3 = null;
//line 865
___nl__3 = new ImmString("/");
//line 865
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 865
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 865
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_8;}}
//line 865
___nl__4 = new ImmDouble((Double.Parse(___nl__0.getValue().ToString()))/(Double.Parse(___nl__1.getValue().ToString())));
//line 865
___nl__0 = null;
//line 865
___nl__1 = null;
//line 865
___nl__2 = null;
//line 865
___nl__3 = null;
//line 865
if(true) return ___nl__4;
//line 865
___nl__4 = null;
//line 865
if (true) {goto label_8;}
//line 865
label_8:
//line 865
___nl__3 = null;
//line 866
___nl__3 = new ImmString("%");
//line 866
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 866
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 866
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_10;}}
//line 866
___nl__4 = new ImmDouble((Double.Parse(___nl__0.getValue().ToString()))%(Double.Parse(___nl__1.getValue().ToString())));
//line 866
___nl__0 = null;
//line 866
___nl__1 = null;
//line 866
___nl__2 = null;
//line 866
___nl__3 = null;
//line 866
if(true) return ___nl__4;
//line 866
___nl__4 = null;
//line 866
if (true) {goto label_10;}
//line 866
label_10:
//line 866
___nl__3 = null;
//line 867
___nl__3 = new ImmString("==");
//line 867
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 867
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 867
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_12;}}
//line 867
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__0.getValue().ToString())) ==((Double.Parse(___nl__1.getValue().ToString())))  );
//line 867
___nl__0 = null;
//line 867
___nl__1 = null;
//line 867
___nl__2 = null;
//line 867
___nl__3 = null;
//line 867
if(true) return ___nl__4;
//line 867
___nl__4 = null;
//line 867
if (true) {goto label_12;}
//line 867
label_12:
//line 867
___nl__3 = null;
//line 868
___nl__3 = new ImmString("!=");
//line 868
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 868
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 868
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_14;}}
//line 868
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__0.getValue().ToString())) !=((Double.Parse(___nl__1.getValue().ToString())))  );
//line 868
___nl__0 = null;
//line 868
___nl__1 = null;
//line 868
___nl__2 = null;
//line 868
___nl__3 = null;
//line 868
if(true) return ___nl__4;
//line 868
___nl__4 = null;
//line 868
if (true) {goto label_14;}
//line 868
label_14:
//line 868
___nl__3 = null;
//line 869
___nl__3 = new ImmString("<");
//line 869
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 869
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 869
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_16;}}
//line 869
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__0.getValue().ToString()))<(Double.Parse(___nl__1.getValue().ToString())) );
//line 869
___nl__0 = null;
//line 869
___nl__1 = null;
//line 869
___nl__2 = null;
//line 869
___nl__3 = null;
//line 869
if(true) return ___nl__4;
//line 869
___nl__4 = null;
//line 869
if (true) {goto label_16;}
//line 869
label_16:
//line 869
___nl__3 = null;
//line 870
___nl__3 = new ImmString("<=");
//line 870
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 870
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 870
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_18;}}
//line 870
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__0.getValue().ToString()))<=(Double.Parse(___nl__1.getValue().ToString())) );
//line 870
___nl__0 = null;
//line 870
___nl__1 = null;
//line 870
___nl__2 = null;
//line 870
___nl__3 = null;
//line 870
if(true) return ___nl__4;
//line 870
___nl__4 = null;
//line 870
if (true) {goto label_18;}
//line 870
label_18:
//line 870
___nl__3 = null;
//line 871
___nl__3 = new ImmString(">");
//line 871
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 871
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 871
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_20;}}
//line 871
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__0.getValue().ToString()))>(Double.Parse(___nl__1.getValue().ToString())) );
//line 871
___nl__0 = null;
//line 871
___nl__1 = null;
//line 871
___nl__2 = null;
//line 871
___nl__3 = null;
//line 871
if(true) return ___nl__4;
//line 871
___nl__4 = null;
//line 871
if (true) {goto label_20;}
//line 871
label_20:
//line 871
___nl__3 = null;
//line 872
___nl__3 = new ImmString(">=");
//line 872
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 872
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 872
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_22;}}
//line 872
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__0.getValue().ToString()))>=(Double.Parse(___nl__1.getValue().ToString())) );
//line 872
___nl__0 = null;
//line 872
___nl__1 = null;
//line 872
___nl__2 = null;
//line 872
___nl__3 = null;
//line 872
if(true) return ___nl__4;
//line 872
___nl__4 = null;
//line 872
if (true) {goto label_22;}
//line 872
label_22:
//line 872
___nl__3 = null;
//line 873
___nl__3 = new ImmString(".");
//line 873
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 873
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 873
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_24;}}
//line 873
___nl__4 = new ImmString(___nl__0.toString() + ___nl__1.toString());
//line 873
___nl__0 = null;
//line 873
___nl__1 = null;
//line 873
___nl__2 = null;
//line 873
___nl__3 = null;
//line 873
if(true) return ___nl__4;
//line 873
___nl__4 = null;
//line 873
if (true) {goto label_24;}
//line 873
label_24:
//line 873
___nl__3 = null;
//line 874
___nl__3 = new ImmString("&&");
//line 874
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 874
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 874
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_26;}}
//line 874
___nl__4 = ___nl__0;
//line 874
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 874
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_27;}}
//line 874
___nl__4 = ___nl__1;
//line 874
label_27:
//line 874
___nl__5 = null;
//line 874
___nl__0 = null;
//line 874
___nl__1 = null;
//line 874
___nl__2 = null;
//line 874
___nl__3 = null;
//line 874
if(true) return ___nl__4;
//line 874
___nl__4 = null;
//line 874
if (true) {goto label_26;}
//line 874
label_26:
//line 874
___nl__3 = null;
//line 875
___nl__3 = new ImmString("||");
//line 875
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 875
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 875
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_29;}}
//line 875
___nl__4 = ___nl__0;
//line 875
if (c_rt_lib_NL.NL_check_true_native(___nl__0)) {if (true) {goto label_30;}}
//line 875
___nl__4 = ___nl__1;
//line 875
label_30:
//line 875
___nl__0 = null;
//line 875
___nl__1 = null;
//line 875
___nl__2 = null;
//line 875
___nl__3 = null;
//line 875
if(true) return ___nl__4;
//line 875
___nl__4 = null;
//line 875
if (true) {goto label_29;}
//line 875
label_29:
//line 875
___nl__3 = null;
//line 876
___nl__3 = new ImmString("eq");
//line 876
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 876
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 876
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_32;}}
//line 876
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__1.toString()));
//line 876
___nl__0 = null;
//line 876
___nl__1 = null;
//line 876
___nl__2 = null;
//line 876
___nl__3 = null;
//line 876
if(true) return ___nl__4;
//line 876
___nl__4 = null;
//line 876
if (true) {goto label_32;}
//line 876
label_32:
//line 876
___nl__3 = null;
//line 877
___nl__3 = new ImmString("ne");
//line 877
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 877
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 877
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_34;}}
//line 877
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!___nl__0.toString().Equals(___nl__1.toString()));
//line 877
___nl__0 = null;
//line 877
___nl__1 = null;
//line 877
___nl__2 = null;
//line 877
___nl__3 = null;
//line 877
if(true) return ___nl__4;
//line 877
___nl__4 = null;
//line 877
if (true) {goto label_34;}
//line 877
label_34:
//line 877
___nl__3 = null;
//line 878
___nl__3 = new ImmArray(new Imm[0]);
//line 878
c_rt_lib_NL.NL_die();
//line 878
___nl__3 = null;
//line 878
___nl__0 = null;
//line 878
___nl__1 = null;
//line 878
___nl__2 = null;
//line 878
if(true) return null;
}

private static Imm NL_execute_una_op_priv(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 882
___nl__2 = new ImmString("!");
//line 882
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__1.toString().Equals(___nl__2.toString()));
//line 882
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 882
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 882
___nl__3 = ___nl__0;
//line 882
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 882
___nl__0 = null;
//line 882
___nl__1 = null;
//line 882
___nl__2 = null;
//line 882
if(true) return ___nl__3;
//line 882
___nl__3 = null;
//line 882
if (true) {goto label_2;}
//line 882
label_2:
//line 882
___nl__2 = null;
//line 883
___nl__2 = new ImmString("-");
//line 883
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__1.toString().Equals(___nl__2.toString()));
//line 883
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 883
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_4;}}
//line 883
___nl__3 = ___nl__0;
//line 883
___nl__3 = new ImmDouble(-((ImmDouble)___nl__3).getDoubleValue());
//line 883
___nl__0 = null;
//line 883
___nl__1 = null;
//line 883
___nl__2 = null;
//line 883
if(true) return ___nl__3;
//line 883
___nl__3 = null;
//line 883
if (true) {goto label_4;}
//line 883
label_4:
//line 883
___nl__2 = null;
//line 884
___nl__2 = new ImmString("+");
//line 884
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__1.toString().Equals(___nl__2.toString()));
//line 884
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 884
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_6;}}
//line 884
___nl__3 = ___nl__0;
//line 884
___nl__3 = new ImmDouble(+((ImmDouble)___nl__3).getDoubleValue());
//line 884
___nl__0 = null;
//line 884
___nl__1 = null;
//line 884
___nl__2 = null;
//line 884
if(true) return ___nl__3;
//line 884
___nl__3 = null;
//line 884
if (true) {goto label_6;}
//line 884
label_6:
//line 884
___nl__2 = null;
//line 885
___nl__2 = new ImmArray(new Imm[0]);
//line 885
c_rt_lib_NL.NL_die();
//line 885
___nl__2 = null;
//line 885
___nl__0 = null;
//line 885
___nl__1 = null;
//line 885
if(true) return null;
}

private static Imm NL_get_command_priv(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 889
___nl__1 = ((ImmHash)___nl__0).getHashValue()["func"];
//line 889
___nl__1 = ((ImmHash)___nl__1).getHashValue()["commands"];
//line 889
___nl__2 = ((ImmHash)___nl__0).getHashValue()["top"];
//line 889
___nl__2 = ((ImmHash)___nl__2).getHashValue()["next"];
//line 889
___nl__1 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__2).getDoubleValue()];
//line 889
___nl__2 = null;
//line 889
___nl__0 = null;
//line 889
if(true) return ___nl__1;
//line 889
___nl__1 = null;
//line 889
___nl__0 = null;
//line 889
if(true) return null;
}

private static Imm NL_get_func_key_priv(Imm ___arg__0, Imm ___arg__1) {
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
//line 893
___nl__2 = new ImmString("::");
//line 893
___nl__2 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 894
___nl__3 = ((ImmHash)___nl__0).getHashValue()["access"];
//line 894
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("priv"));
//line 894
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 894
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 895
___nl__4 = new ImmString("priv::");
//line 895
___nl__2 = new ImmString(___nl__2.toString() + ___nl__4.toString());
//line 895
___nl__4 = null;
//line 896
if (true) {goto label_2;}
//line 896
label_2:
//line 896
___nl__3 = null;
//line 897
___nl__3 = ((ImmHash)___nl__0).getHashValue()["name"];
//line 897
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 897
___nl__3 = null;
//line 898
___nl__0 = null;
//line 898
___nl__1 = null;
//line 898
if(true) return ___nl__2;
//line 898
___nl__2 = null;
//line 898
___nl__0 = null;
//line 898
___nl__1 = null;
//line 898
if(true) return null;
}

}
}