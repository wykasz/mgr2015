using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class nlasm_NL {

public static Imm NL_SINGLETON_result_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Dictionary<String, Imm> __function_map;
//line 9
___nl__2 = ptd_NL.NL_sim().clone();

//line 9
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("function_t"));
___nl__4 = new ImmHash(__function_map).clone();
//line 9
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__4).clone();
//line 9
___nl__3 = ptd_NL.NL_arr(___nl__4).clone();

//line 9
___nl__4 = null;
//line 9
___nl__5 = ptd_NL.NL_sim().clone();

//line 9
___nl__4 = ptd_NL.NL_arr(___nl__5).clone();

//line 9
___nl__5 = null;
//line 9
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module_name",___nl__2);
__function_map.Add("functions",___nl__3);
__function_map.Add("imports",___nl__4);
___nl__1 = new ImmHash(__function_map).clone();
//line 9
___nl__2 = null;
//line 9
___nl__3 = null;
//line 9
___nl__4 = null;
//line 9
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 9
___nl__1 = null;
//line 9
if(true) return ___nl__0;
//line 9
___nl__0 = null;
//line 9
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_result_t = null;
public static Imm NL_result_t() {
	if (value__singleton__NL_SINGLETON_result_t == null) {
		value__singleton__NL_SINGLETON_result_t = NL_SINGLETON_result_t();
	}
	return value__singleton__NL_SINGLETON_result_t;
}
public static Imm NL_SINGLETON_access_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 17
___nl__2 = ptd_NL.NL_none().clone();

//line 17
___nl__3 = ptd_NL.NL_none().clone();

//line 17
__function_map = new Dictionary<String, Imm>();
__function_map.Add("pub",___nl__2);
__function_map.Add("priv",___nl__3);
___nl__1 = new ImmHash(__function_map).clone();
//line 17
___nl__2 = null;
//line 17
___nl__3 = null;
//line 17
___nl__0 = ptd_NL.NL_var(___nl__1).clone();

//line 17
___nl__1 = null;
//line 17
if(true) return ___nl__0;
//line 17
___nl__0 = null;
//line 17
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_access_t = null;
public static Imm NL_access_t() {
	if (value__singleton__NL_SINGLETON_access_t == null) {
		value__singleton__NL_SINGLETON_access_t = NL_SINGLETON_access_t();
	}
	return value__singleton__NL_SINGLETON_access_t;
}
public static Imm NL_SINGLETON_arg_type_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 24
___nl__2 = ptd_NL.NL_none().clone();

//line 24
___nl__3 = ptd_NL.NL_none().clone();

//line 24
__function_map = new Dictionary<String, Imm>();
__function_map.Add("val",___nl__2);
__function_map.Add("ref",___nl__3);
___nl__1 = new ImmHash(__function_map).clone();
//line 24
___nl__2 = null;
//line 24
___nl__3 = null;
//line 24
___nl__0 = ptd_NL.NL_var(___nl__1).clone();

//line 24
___nl__1 = null;
//line 24
if(true) return ___nl__0;
//line 24
___nl__0 = null;
//line 24
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_arg_type_t = null;
public static Imm NL_arg_type_t() {
	if (value__singleton__NL_SINGLETON_arg_type_t == null) {
		value__singleton__NL_SINGLETON_arg_type_t = NL_SINGLETON_arg_type_t();
	}
	return value__singleton__NL_SINGLETON_arg_type_t;
}
public static Imm NL_SINGLETON_function_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Dictionary<String, Imm> __function_map;
//line 31
___nl__4 = ptd_NL.NL_none().clone();

//line 31
___nl__5 = ptd_NL.NL_none().clone();

//line 31
___nl__6 = ptd_NL.NL_none().clone();

//line 31
__function_map = new Dictionary<String, Imm>();
__function_map.Add("none",___nl__4);
__function_map.Add("math",___nl__5);
__function_map.Add("state",___nl__6);
___nl__3 = new ImmHash(__function_map).clone();
//line 31
___nl__4 = null;
//line 31
___nl__5 = null;
//line 31
___nl__6 = null;
//line 31
___nl__2 = ptd_NL.NL_var(___nl__3).clone();

//line 31
___nl__3 = null;
//line 31
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("access_t"));
___nl__3 = new ImmHash(__function_map).clone();
//line 31
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3).clone();
//line 31
___nl__4 = ptd_NL.NL_sim().clone();

//line 31
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("arg_type_t"));
___nl__6 = new ImmHash(__function_map).clone();
//line 31
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__6).clone();
//line 31
___nl__5 = ptd_NL.NL_arr(___nl__6).clone();

//line 31
___nl__6 = null;
//line 31
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("cmd_t"));
___nl__7 = new ImmHash(__function_map).clone();
//line 31
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__7).clone();
//line 31
___nl__6 = ptd_NL.NL_arr(___nl__7).clone();

//line 31
___nl__7 = null;
//line 31
___nl__7 = ptd_NL.NL_sim().clone();

//line 31
__function_map = new Dictionary<String, Imm>();
__function_map.Add("annotation",___nl__2);
__function_map.Add("access",___nl__3);
__function_map.Add("reg_size",___nl__4);
__function_map.Add("args_type",___nl__5);
__function_map.Add("commands",___nl__6);
__function_map.Add("name",___nl__7);
___nl__1 = new ImmHash(__function_map).clone();
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
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 31
___nl__1 = null;
//line 31
if(true) return ___nl__0;
//line 31
___nl__0 = null;
//line 31
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_function_t = null;
public static Imm NL_function_t() {
	if (value__singleton__NL_SINGLETON_function_t == null) {
		value__singleton__NL_SINGLETON_function_t = NL_SINGLETON_function_t();
	}
	return value__singleton__NL_SINGLETON_function_t;
}
public static Imm NL_SINGLETON_reg_t() {

Imm ___nl__0 = null;
Dictionary<String, Imm> __function_map;
//line 46
___nl__0 = ptd_NL.NL_sim().clone();

//line 46
if(true) return ___nl__0;
//line 46
___nl__0 = null;
//line 46
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_reg_t = null;
public static Imm NL_reg_t() {
	if (value__singleton__NL_SINGLETON_reg_t == null) {
		value__singleton__NL_SINGLETON_reg_t = NL_SINGLETON_reg_t();
	}
	return value__singleton__NL_SINGLETON_reg_t;
}
public static Imm NL_SINGLETON_debug_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Dictionary<String, Imm> __function_map;
//line 50
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("debug_t"));
___nl__2 = new ImmHash(__function_map).clone();
//line 50
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2).clone();
//line 50
___nl__3 = ptd_NL.NL_sim().clone();

//line 50
___nl__5 = ptd_NL.NL_sim().clone();

//line 50
___nl__4 = ptd_NL.NL_hash(___nl__5).clone();

//line 50
___nl__5 = null;
//line 50
__function_map = new Dictionary<String, Imm>();
__function_map.Add("nast_debug",___nl__2);
__function_map.Add("instruction_nr",___nl__3);
__function_map.Add("declarations",___nl__4);
___nl__1 = new ImmHash(__function_map).clone();
//line 50
___nl__2 = null;
//line 50
___nl__3 = null;
//line 50
___nl__4 = null;
//line 50
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 50
___nl__1 = null;
//line 50
if(true) return ___nl__0;
//line 50
___nl__0 = null;
//line 50
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_debug_t = null;
public static Imm NL_debug_t() {
	if (value__singleton__NL_SINGLETON_debug_t == null) {
		value__singleton__NL_SINGLETON_debug_t = NL_SINGLETON_debug_t();
	}
	return value__singleton__NL_SINGLETON_debug_t;
}
public static Imm NL_SINGLETON_empty_debug() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 58
___nl__1 = nast_NL.NL_empty_debug().clone();

//line 58
___nl__2 = new ImmDouble(0).clone();
//line 58
__function_map = new Dictionary<String, Imm>();
___nl__3 = new ImmHash(__function_map).clone();
//line 58
__function_map = new Dictionary<String, Imm>();
__function_map.Add("nast_debug",___nl__1);
__function_map.Add("instruction_nr",___nl__2);
__function_map.Add("declarations",___nl__3);
___nl__0 = new ImmHash(__function_map).clone();
//line 58
___nl__1 = null;
//line 58
___nl__2 = null;
//line 58
___nl__3 = null;
//line 58
if(true) return ___nl__0;
//line 58
___nl__0 = null;
//line 58
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_empty_debug = null;
public static Imm NL_empty_debug() {
	if (value__singleton__NL_SINGLETON_empty_debug == null) {
		value__singleton__NL_SINGLETON_empty_debug = NL_SINGLETON_empty_debug();
	}
	return value__singleton__NL_SINGLETON_empty_debug;
}
public static Imm NL_SINGLETON_cmd_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Dictionary<String, Imm> __function_map;
//line 66
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("debug_t"));
___nl__2 = new ImmHash(__function_map).clone();
//line 66
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2).clone();
//line 66
___nl__5 = ptd_NL.NL_none().clone();

//line 66
___nl__7 = ptd_NL.NL_sim().clone();

//line 66
___nl__6 = ptd_NL.NL_arr(___nl__7).clone();

//line 66
___nl__7 = null;
//line 66
__function_map = new Dictionary<String, Imm>();
__function_map.Add("none",___nl__5);
__function_map.Add("const",___nl__6);
___nl__4 = new ImmHash(__function_map).clone();
//line 66
___nl__5 = null;
//line 66
___nl__6 = null;
//line 66
___nl__3 = ptd_NL.NL_var(___nl__4).clone();

//line 66
___nl__4 = null;
//line 66
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("order_t"));
___nl__4 = new ImmHash(__function_map).clone();
//line 66
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__4).clone();
//line 66
__function_map = new Dictionary<String, Imm>();
__function_map.Add("debug",___nl__2);
__function_map.Add("annotation",___nl__3);
__function_map.Add("cmd",___nl__4);
___nl__1 = new ImmHash(__function_map).clone();
//line 66
___nl__2 = null;
//line 66
___nl__3 = null;
//line 66
___nl__4 = null;
//line 66
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 66
___nl__1 = null;
//line 66
if(true) return ___nl__0;
//line 66
___nl__0 = null;
//line 66
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_cmd_t = null;
public static Imm NL_cmd_t() {
	if (value__singleton__NL_SINGLETON_cmd_t == null) {
		value__singleton__NL_SINGLETON_cmd_t = NL_SINGLETON_cmd_t();
	}
	return value__singleton__NL_SINGLETON_cmd_t;
}
public static Imm NL_SINGLETON_order_t() {

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
//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__4 = new ImmHash(__function_map).clone();
//line 76
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__4).clone();
//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__6 = new ImmHash(__function_map).clone();
//line 76
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__6).clone();
//line 76
___nl__5 = ptd_NL.NL_arr(___nl__6).clone();

//line 76
___nl__6 = null;
//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__4);
__function_map.Add("src",___nl__5);
___nl__3 = new ImmHash(__function_map).clone();
//line 76
___nl__4 = null;
//line 76
___nl__5 = null;
//line 76
___nl__2 = ptd_NL.NL_rec(___nl__3).clone();

//line 76
___nl__3 = null;
//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__5 = new ImmHash(__function_map).clone();
//line 76
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__5).clone();
//line 76
___nl__9 = ptd_NL.NL_sim().clone();

//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__10 = new ImmHash(__function_map).clone();
//line 76
___nl__10 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__10).clone();
//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("key",___nl__9);
__function_map.Add("val",___nl__10);
___nl__8 = new ImmHash(__function_map).clone();
//line 76
___nl__9 = null;
//line 76
___nl__10 = null;
//line 76
___nl__7 = ptd_NL.NL_rec(___nl__8).clone();

//line 76
___nl__8 = null;
//line 76
___nl__6 = ptd_NL.NL_arr(___nl__7).clone();

//line 76
___nl__7 = null;
//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__5);
__function_map.Add("src",___nl__6);
___nl__4 = new ImmHash(__function_map).clone();
//line 76
___nl__5 = null;
//line 76
___nl__6 = null;
//line 76
___nl__3 = ptd_NL.NL_rec(___nl__4).clone();

//line 76
___nl__4 = null;
//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__6 = new ImmHash(__function_map).clone();
//line 76
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__6).clone();
//line 76
___nl__7 = ptd_NL.NL_sim().clone();

//line 76
___nl__8 = ptd_NL.NL_sim().clone();

//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__6);
__function_map.Add("module",___nl__7);
__function_map.Add("name",___nl__8);
___nl__5 = new ImmHash(__function_map).clone();
//line 76
___nl__6 = null;
//line 76
___nl__7 = null;
//line 76
___nl__8 = null;
//line 76
___nl__4 = ptd_NL.NL_rec(___nl__5).clone();

//line 76
___nl__5 = null;
//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("call_t"));
___nl__5 = new ImmHash(__function_map).clone();
//line 76
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__5).clone();
//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__8 = new ImmHash(__function_map).clone();
//line 76
___nl__8 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__8).clone();
//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__9 = new ImmHash(__function_map).clone();
//line 76
___nl__9 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__9).clone();
//line 76
___nl__10 = ptd_NL.NL_sim().clone();

//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__8);
__function_map.Add("src",___nl__9);
__function_map.Add("op",___nl__10);
___nl__7 = new ImmHash(__function_map).clone();
//line 76
___nl__8 = null;
//line 76
___nl__9 = null;
//line 76
___nl__10 = null;
//line 76
___nl__6 = ptd_NL.NL_rec(___nl__7).clone();

//line 76
___nl__7 = null;
//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__9 = new ImmHash(__function_map).clone();
//line 76
___nl__9 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__9).clone();
//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__10 = new ImmHash(__function_map).clone();
//line 76
___nl__10 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__10).clone();
//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__11 = new ImmHash(__function_map).clone();
//line 76
___nl__11 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__11).clone();
//line 76
___nl__12 = ptd_NL.NL_sim().clone();

//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__9);
__function_map.Add("left",___nl__10);
__function_map.Add("right",___nl__11);
__function_map.Add("op",___nl__12);
___nl__8 = new ImmHash(__function_map).clone();
//line 76
___nl__9 = null;
//line 76
___nl__10 = null;
//line 76
___nl__11 = null;
//line 76
___nl__12 = null;
//line 76
___nl__7 = ptd_NL.NL_rec(___nl__8).clone();

//line 76
___nl__8 = null;
//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__10 = new ImmHash(__function_map).clone();
//line 76
___nl__10 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__10).clone();
//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__11 = new ImmHash(__function_map).clone();
//line 76
___nl__11 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__11).clone();
//line 76
___nl__12 = ptd_NL.NL_sim().clone();

//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__10);
__function_map.Add("src",___nl__11);
__function_map.Add("type",___nl__12);
___nl__9 = new ImmHash(__function_map).clone();
//line 76
___nl__10 = null;
//line 76
___nl__11 = null;
//line 76
___nl__12 = null;
//line 76
___nl__8 = ptd_NL.NL_rec(___nl__9).clone();

//line 76
___nl__9 = null;
//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__11 = new ImmHash(__function_map).clone();
//line 76
___nl__11 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__11).clone();
//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__12 = new ImmHash(__function_map).clone();
//line 76
___nl__12 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__12).clone();
//line 76
___nl__13 = ptd_NL.NL_sim().clone();

//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__11);
__function_map.Add("src",___nl__12);
__function_map.Add("type",___nl__13);
___nl__10 = new ImmHash(__function_map).clone();
//line 76
___nl__11 = null;
//line 76
___nl__12 = null;
//line 76
___nl__13 = null;
//line 76
___nl__9 = ptd_NL.NL_rec(___nl__10).clone();

//line 76
___nl__10 = null;
//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__12 = new ImmHash(__function_map).clone();
//line 76
___nl__12 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__12).clone();
//line 76
___nl__13 = ptd_NL.NL_none().clone();

//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("val",___nl__12);
__function_map.Add("emp",___nl__13);
___nl__11 = new ImmHash(__function_map).clone();
//line 76
___nl__12 = null;
//line 76
___nl__13 = null;
//line 76
___nl__10 = ptd_NL.NL_var(___nl__11).clone();

//line 76
___nl__11 = null;
//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__11 = new ImmHash(__function_map).clone();
//line 76
___nl__11 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__11).clone();
//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__14 = new ImmHash(__function_map).clone();
//line 76
___nl__14 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__14).clone();
//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__15 = new ImmHash(__function_map).clone();
//line 76
___nl__15 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__15).clone();
//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__14);
__function_map.Add("src",___nl__15);
___nl__13 = new ImmHash(__function_map).clone();
//line 76
___nl__14 = null;
//line 76
___nl__15 = null;
//line 76
___nl__12 = ptd_NL.NL_rec(___nl__13).clone();

//line 76
___nl__13 = null;
//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__15 = new ImmHash(__function_map).clone();
//line 76
___nl__15 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__15).clone();
//line 76
___nl__16 = ptd_NL.NL_ptd_im().clone();

//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__15);
__function_map.Add("val",___nl__16);
___nl__14 = new ImmHash(__function_map).clone();
//line 76
___nl__15 = null;
//line 76
___nl__16 = null;
//line 76
___nl__13 = ptd_NL.NL_rec(___nl__14).clone();

//line 76
___nl__14 = null;
//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__16 = new ImmHash(__function_map).clone();
//line 76
___nl__16 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__16).clone();
//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__17 = new ImmHash(__function_map).clone();
//line 76
___nl__17 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__17).clone();
//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__18 = new ImmHash(__function_map).clone();
//line 76
___nl__18 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__18).clone();
//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__16);
__function_map.Add("src",___nl__17);
__function_map.Add("idx",___nl__18);
___nl__15 = new ImmHash(__function_map).clone();
//line 76
___nl__16 = null;
//line 76
___nl__17 = null;
//line 76
___nl__18 = null;
//line 76
___nl__14 = ptd_NL.NL_rec(___nl__15).clone();

//line 76
___nl__15 = null;
//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__17 = new ImmHash(__function_map).clone();
//line 76
___nl__17 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__17).clone();
//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__18 = new ImmHash(__function_map).clone();
//line 76
___nl__18 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__18).clone();
//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__19 = new ImmHash(__function_map).clone();
//line 76
___nl__19 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__19).clone();
//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("src",___nl__17);
__function_map.Add("idx",___nl__18);
__function_map.Add("val",___nl__19);
___nl__16 = new ImmHash(__function_map).clone();
//line 76
___nl__17 = null;
//line 76
___nl__18 = null;
//line 76
___nl__19 = null;
//line 76
___nl__15 = ptd_NL.NL_rec(___nl__16).clone();

//line 76
___nl__16 = null;
//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__18 = new ImmHash(__function_map).clone();
//line 76
___nl__18 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__18).clone();
//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__19 = new ImmHash(__function_map).clone();
//line 76
___nl__19 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__19).clone();
//line 76
___nl__20 = ptd_NL.NL_sim().clone();

//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__18);
__function_map.Add("src",___nl__19);
__function_map.Add("key",___nl__20);
___nl__17 = new ImmHash(__function_map).clone();
//line 76
___nl__18 = null;
//line 76
___nl__19 = null;
//line 76
___nl__20 = null;
//line 76
___nl__16 = ptd_NL.NL_rec(___nl__17).clone();

//line 76
___nl__17 = null;
//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__19 = new ImmHash(__function_map).clone();
//line 76
___nl__19 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__19).clone();
//line 76
___nl__20 = ptd_NL.NL_sim().clone();

//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__21 = new ImmHash(__function_map).clone();
//line 76
___nl__21 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__21).clone();
//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("src",___nl__19);
__function_map.Add("key",___nl__20);
__function_map.Add("val",___nl__21);
___nl__18 = new ImmHash(__function_map).clone();
//line 76
___nl__19 = null;
//line 76
___nl__20 = null;
//line 76
___nl__21 = null;
//line 76
___nl__17 = ptd_NL.NL_rec(___nl__18).clone();

//line 76
___nl__18 = null;
//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("ov_mk_t"));
___nl__18 = new ImmHash(__function_map).clone();
//line 76
___nl__18 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__18).clone();
//line 76
___nl__19 = ptd_NL.NL_sim().clone();

//line 76
___nl__22 = ptd_NL.NL_sim().clone();

//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__23 = new ImmHash(__function_map).clone();
//line 76
___nl__23 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__23).clone();
//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__22);
__function_map.Add("src",___nl__23);
___nl__21 = new ImmHash(__function_map).clone();
//line 76
___nl__22 = null;
//line 76
___nl__23 = null;
//line 76
___nl__20 = ptd_NL.NL_rec(___nl__21).clone();

//line 76
___nl__21 = null;
//line 76
___nl__21 = ptd_NL.NL_sim().clone();

//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__22 = new ImmHash(__function_map).clone();
//line 76
___nl__22 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__22).clone();
//line 76
__function_map = new Dictionary<String, Imm>();
__function_map.Add("arr_decl",___nl__2);
__function_map.Add("hash_decl",___nl__3);
__function_map.Add("func",___nl__4);
__function_map.Add("call",___nl__5);
__function_map.Add("una_op",___nl__6);
__function_map.Add("bin_op",___nl__7);
__function_map.Add("ov_is",___nl__8);
__function_map.Add("ov_as",___nl__9);
__function_map.Add("return",___nl__10);
__function_map.Add("die",___nl__11);
__function_map.Add("move",___nl__12);
__function_map.Add("load_const",___nl__13);
__function_map.Add("get_frm_idx",___nl__14);
__function_map.Add("set_at_idx",___nl__15);
__function_map.Add("get_val",___nl__16);
__function_map.Add("set_val",___nl__17);
__function_map.Add("ov_mk",___nl__18);
__function_map.Add("prt_lbl",___nl__19);
__function_map.Add("if_goto",___nl__20);
__function_map.Add("goto",___nl__21);
__function_map.Add("clear",___nl__22);
___nl__1 = new ImmHash(__function_map).clone();
//line 76
___nl__2 = null;
//line 76
___nl__3 = null;
//line 76
___nl__4 = null;
//line 76
___nl__5 = null;
//line 76
___nl__6 = null;
//line 76
___nl__7 = null;
//line 76
___nl__8 = null;
//line 76
___nl__9 = null;
//line 76
___nl__10 = null;
//line 76
___nl__11 = null;
//line 76
___nl__12 = null;
//line 76
___nl__13 = null;
//line 76
___nl__14 = null;
//line 76
___nl__15 = null;
//line 76
___nl__16 = null;
//line 76
___nl__17 = null;
//line 76
___nl__18 = null;
//line 76
___nl__19 = null;
//line 76
___nl__20 = null;
//line 76
___nl__21 = null;
//line 76
___nl__22 = null;
//line 76
___nl__0 = ptd_NL.NL_var(___nl__1).clone();

//line 76
___nl__1 = null;
//line 76
if(true) return ___nl__0;
//line 76
___nl__0 = null;
//line 76
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_order_t = null;
public static Imm NL_order_t() {
	if (value__singleton__NL_SINGLETON_order_t == null) {
		value__singleton__NL_SINGLETON_order_t = NL_SINGLETON_order_t();
	}
	return value__singleton__NL_SINGLETON_order_t;
}
public static Imm NL_SINGLETON_ov_mk_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Dictionary<String, Imm> __function_map;
//line 162
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__2 = new ImmHash(__function_map).clone();
//line 162
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2).clone();
//line 162
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__5 = new ImmHash(__function_map).clone();
//line 162
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__5).clone();
//line 162
___nl__6 = ptd_NL.NL_none().clone();

//line 162
__function_map = new Dictionary<String, Imm>();
__function_map.Add("arg",___nl__5);
__function_map.Add("emp",___nl__6);
___nl__4 = new ImmHash(__function_map).clone();
//line 162
___nl__5 = null;
//line 162
___nl__6 = null;
//line 162
___nl__3 = ptd_NL.NL_var(___nl__4).clone();

//line 162
___nl__4 = null;
//line 162
___nl__4 = ptd_NL.NL_sim().clone();

//line 162
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__2);
__function_map.Add("src",___nl__3);
__function_map.Add("name",___nl__4);
___nl__1 = new ImmHash(__function_map).clone();
//line 162
___nl__2 = null;
//line 162
___nl__3 = null;
//line 162
___nl__4 = null;
//line 162
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 162
___nl__1 = null;
//line 162
if(true) return ___nl__0;
//line 162
___nl__0 = null;
//line 162
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_ov_mk_t = null;
public static Imm NL_ov_mk_t() {
	if (value__singleton__NL_SINGLETON_ov_mk_t == null) {
		value__singleton__NL_SINGLETON_ov_mk_t = NL_SINGLETON_ov_mk_t();
	}
	return value__singleton__NL_SINGLETON_ov_mk_t;
}
public static Imm NL_SINGLETON_call_t() {

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
Dictionary<String, Imm> __function_map;
//line 173
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__2 = new ImmHash(__function_map).clone();
//line 173
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2).clone();
//line 173
___nl__3 = ptd_NL.NL_sim().clone();

//line 173
___nl__4 = ptd_NL.NL_sim().clone();

//line 173
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__8 = new ImmHash(__function_map).clone();
//line 173
___nl__8 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__8).clone();
//line 173
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__9 = new ImmHash(__function_map).clone();
//line 173
___nl__9 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__9).clone();
//line 173
__function_map = new Dictionary<String, Imm>();
__function_map.Add("val",___nl__8);
__function_map.Add("ref",___nl__9);
___nl__7 = new ImmHash(__function_map).clone();
//line 173
___nl__8 = null;
//line 173
___nl__9 = null;
//line 173
___nl__6 = ptd_NL.NL_var(___nl__7).clone();

//line 173
___nl__7 = null;
//line 173
___nl__5 = ptd_NL.NL_arr(___nl__6).clone();

//line 173
___nl__6 = null;
//line 173
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__2);
__function_map.Add("mod",___nl__3);
__function_map.Add("fun_name",___nl__4);
__function_map.Add("args",___nl__5);
___nl__1 = new ImmHash(__function_map).clone();
//line 173
___nl__2 = null;
//line 173
___nl__3 = null;
//line 173
___nl__4 = null;
//line 173
___nl__5 = null;
//line 173
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 173
___nl__1 = null;
//line 173
if(true) return ___nl__0;
//line 173
___nl__0 = null;
//line 173
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_call_t = null;
public static Imm NL_call_t() {
	if (value__singleton__NL_SINGLETON_call_t == null) {
		value__singleton__NL_SINGLETON_call_t = NL_SINGLETON_call_t();
	}
	return value__singleton__NL_SINGLETON_call_t;
}
}
}