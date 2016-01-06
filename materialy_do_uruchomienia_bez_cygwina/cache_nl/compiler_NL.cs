using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class compiler_NL {

private static Imm NL_SINGLETON_get_dir_cache_name_priv() {

Imm ___nl__0 = null;
ImmRef ___ref______nl__0 = null;
Dictionary<String, Imm> __function_map;
//line 31
___nl__0 = new ImmString("cache_nl");
//line 31
if(true) return ___nl__0;
//line 31
___nl__0 = null;
//line 31
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_get_dir_cache_name_priv = null;
private static Imm NL_get_dir_cache_name_priv() {
	if (value__singleton__NL_SINGLETON_get_dir_cache_name_priv == null) {
		value__singleton__NL_SINGLETON_get_dir_cache_name_priv = NL_SINGLETON_get_dir_cache_name_priv();
	}
	return value__singleton__NL_SINGLETON_get_dir_cache_name_priv;
}
private static Imm NL_SINGLETON_get_dir_pretty_name_priv() {

Imm ___nl__0 = null;
ImmRef ___ref______nl__0 = null;
Dictionary<String, Imm> __function_map;
//line 34
___nl__0 = new ImmString("pretty_nl");
//line 34
if(true) return ___nl__0;
//line 34
___nl__0 = null;
//line 34
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_get_dir_pretty_name_priv = null;
private static Imm NL_get_dir_pretty_name_priv() {
	if (value__singleton__NL_SINGLETON_get_dir_pretty_name_priv == null) {
		value__singleton__NL_SINGLETON_get_dir_pretty_name_priv = NL_SINGLETON_get_dir_pretty_name_priv();
	}
	return value__singleton__NL_SINGLETON_get_dir_pretty_name_priv;
}
private static Imm NL_SINGLETON_get_default_deref_file_priv() {

Imm ___nl__0 = null;
ImmRef ___ref______nl__0 = null;
Dictionary<String, Imm> __function_map;
//line 37
___nl__0 = new ImmString("deref.gr");
//line 37
if(true) return ___nl__0;
//line 37
___nl__0 = null;
//line 37
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_get_default_deref_file_priv = null;
private static Imm NL_get_default_deref_file_priv() {
	if (value__singleton__NL_SINGLETON_get_default_deref_file_priv == null) {
		value__singleton__NL_SINGLETON_get_default_deref_file_priv = NL_SINGLETON_get_default_deref_file_priv();
	}
	return value__singleton__NL_SINGLETON_get_default_deref_file_priv;
}
private static Imm NL_SINGLETON_get_default_math_file_priv() {

Imm ___nl__0 = null;
ImmRef ___ref______nl__0 = null;
Dictionary<String, Imm> __function_map;
//line 40
___nl__0 = new ImmString("math_fun.gr");
//line 40
if(true) return ___nl__0;
//line 40
___nl__0 = null;
//line 40
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_get_default_math_file_priv = null;
private static Imm NL_get_default_math_file_priv() {
	if (value__singleton__NL_SINGLETON_get_default_math_file_priv == null) {
		value__singleton__NL_SINGLETON_get_default_math_file_priv = NL_SINGLETON_get_default_math_file_priv();
	}
	return value__singleton__NL_SINGLETON_get_default_math_file_priv;
}
public static Imm NL_SINGLETON_parse_check_t() {

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
//line 44
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("module_t"));
___nl__3 = new ImmHash(__function_map);
//line 44
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3);
//line 44
___nl__2 = ptd_NL.NL_hash(___nl__3);

//line 44
___nl__3 = null;
//line 44
___nl__4 = ptd_NL.NL_sim();

//line 44
___nl__3 = ptd_NL.NL_arr(___nl__4);

//line 44
___nl__4 = null;
//line 44
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("tc_types_NL"));
__function_map.Add("name",new ImmString("deref_types"));
___nl__4 = new ImmHash(__function_map);
//line 44
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__4);
//line 44
__function_map = new Dictionary<String, Imm>();
__function_map.Add("asts",___nl__2);
__function_map.Add("errors",___nl__3);
__function_map.Add("deref_type",___nl__4);
___nl__1 = new ImmHash(__function_map);
//line 44
___nl__2 = null;
//line 44
___nl__3 = null;
//line 44
___nl__4 = null;
//line 44
___nl__0 = ptd_NL.NL_rec(___nl__1);

//line 44
___nl__1 = null;
//line 44
if(true) return ___nl__0;
//line 44
___nl__0 = null;
//line 44
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_parse_check_t = null;
public static Imm NL_parse_check_t() {
	if (value__singleton__NL_SINGLETON_parse_check_t == null) {
		value__singleton__NL_SINGLETON_parse_check_t = NL_SINGLETON_parse_check_t();
	}
	return value__singleton__NL_SINGLETON_parse_check_t;
}
public static Imm NL_SINGLETON_errors_hash_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 47
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("tc_types_NL"));
__function_map.Add("name",new ImmString("check_error_t"));
___nl__2 = new ImmHash(__function_map);
//line 47
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2);
//line 47
___nl__1 = ptd_NL.NL_arr(___nl__2);

//line 47
___nl__2 = null;
//line 47
___nl__0 = ptd_NL.NL_hash(___nl__1);

//line 47
___nl__1 = null;
//line 47
if(true) return ___nl__0;
//line 47
___nl__0 = null;
//line 47
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_errors_hash_t = null;
public static Imm NL_errors_hash_t() {
	if (value__singleton__NL_SINGLETON_errors_hash_t == null) {
		value__singleton__NL_SINGLETON_errors_hash_t = NL_SINGLETON_errors_hash_t();
	}
	return value__singleton__NL_SINGLETON_errors_hash_t;
}
public static Imm NL_SINGLETON_errors_group_t() {

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
//line 50
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("compiler_NL"));
__function_map.Add("name",new ImmString("errors_hash_t"));
___nl__2 = new ImmHash(__function_map);
//line 50
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2);
//line 50
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("compiler_NL"));
__function_map.Add("name",new ImmString("errors_hash_t"));
___nl__3 = new ImmHash(__function_map);
//line 50
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3);
//line 50
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("compiler_NL"));
__function_map.Add("name",new ImmString("errors_hash_t"));
___nl__4 = new ImmHash(__function_map);
//line 50
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__4);
//line 50
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("compiler_NL"));
__function_map.Add("name",new ImmString("errors_hash_t"));
___nl__5 = new ImmHash(__function_map);
//line 50
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__5);
//line 50
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("module_checker_NL"));
__function_map.Add("name",new ImmString("ret_t"));
___nl__6 = new ImmHash(__function_map);
//line 50
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__6);
//line 50
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module_errors",___nl__2);
__function_map.Add("module_warnings",___nl__3);
__function_map.Add("type_errors",___nl__4);
__function_map.Add("type_warnings",___nl__5);
__function_map.Add("loop_error",___nl__6);
___nl__1 = new ImmHash(__function_map);
//line 50
___nl__2 = null;
//line 50
___nl__3 = null;
//line 50
___nl__4 = null;
//line 50
___nl__5 = null;
//line 50
___nl__6 = null;
//line 50
___nl__0 = ptd_NL.NL_rec(___nl__1);

//line 50
___nl__1 = null;
//line 50
if(true) return ___nl__0;
//line 50
___nl__0 = null;
//line 50
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_errors_group_t = null;
public static Imm NL_errors_group_t() {
	if (value__singleton__NL_SINGLETON_errors_group_t == null) {
		value__singleton__NL_SINGLETON_errors_group_t = NL_SINGLETON_errors_group_t();
	}
	return value__singleton__NL_SINGLETON_errors_group_t;
}
public static Imm NL_SINGLETON_language_t() {

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
//line 59
___nl__2 = ptd_NL.NL_none();

//line 59
___nl__3 = ptd_NL.NL_none();

//line 59
___nl__4 = ptd_NL.NL_none();

//line 59
___nl__5 = ptd_NL.NL_none();

//line 59
___nl__6 = ptd_NL.NL_none();

//line 59
___nl__7 = ptd_NL.NL_none();

//line 59
___nl__8 = ptd_NL.NL_none();

//line 59
___nl__9 = ptd_NL.NL_none();

//line 59
__function_map = new Dictionary<String, Imm>();
__function_map.Add("pm",___nl__2);
__function_map.Add("nla",___nl__3);
__function_map.Add("c",___nl__4);
__function_map.Add("nl",___nl__5);
__function_map.Add("ast",___nl__6);
__function_map.Add("js",___nl__7);
__function_map.Add("java",___nl__8);
__function_map.Add("cs",___nl__9);
___nl__1 = new ImmHash(__function_map);
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
___nl__0 = ptd_NL.NL_var(___nl__1);

//line 59
___nl__1 = null;
//line 59
if(true) return ___nl__0;
//line 59
___nl__0 = null;
//line 59
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_language_t = null;
public static Imm NL_language_t() {
	if (value__singleton__NL_SINGLETON_language_t == null) {
		value__singleton__NL_SINGLETON_language_t = NL_SINGLETON_language_t();
	}
	return value__singleton__NL_SINGLETON_language_t;
}
public static Imm NL_SINGLETON_destination_t() {

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
//line 62
___nl__2 = ptd_NL.NL_sim();

//line 62
___nl__3 = ptd_NL.NL_sim();

//line 62
___nl__6 = ptd_NL.NL_sim();

//line 62
___nl__7 = ptd_NL.NL_sim();

//line 62
__function_map = new Dictionary<String, Imm>();
__function_map.Add("c",___nl__6);
__function_map.Add("h",___nl__7);
___nl__5 = new ImmHash(__function_map);
//line 62
___nl__6 = null;
//line 62
___nl__7 = null;
//line 62
___nl__4 = ptd_NL.NL_rec(___nl__5);

//line 62
___nl__5 = null;
//line 62
___nl__5 = ptd_NL.NL_sim();

//line 62
___nl__6 = ptd_NL.NL_sim();

//line 62
___nl__7 = ptd_NL.NL_sim();

//line 62
___nl__8 = ptd_NL.NL_sim();

//line 62
___nl__9 = ptd_NL.NL_sim();

//line 62
___nl__10 = ptd_NL.NL_none();

//line 62
__function_map = new Dictionary<String, Imm>();
__function_map.Add("pm",___nl__2);
__function_map.Add("nla",___nl__3);
__function_map.Add("c",___nl__4);
__function_map.Add("nl",___nl__5);
__function_map.Add("ast",___nl__6);
__function_map.Add("js",___nl__7);
__function_map.Add("java",___nl__8);
__function_map.Add("cs",___nl__9);
__function_map.Add("none",___nl__10);
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
___nl__6 = null;
//line 62
___nl__7 = null;
//line 62
___nl__8 = null;
//line 62
___nl__9 = null;
//line 62
___nl__10 = null;
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
private static Imm value__singleton__NL_SINGLETON_destination_t = null;
public static Imm NL_destination_t() {
	if (value__singleton__NL_SINGLETON_destination_t == null) {
		value__singleton__NL_SINGLETON_destination_t = NL_SINGLETON_destination_t();
	}
	return value__singleton__NL_SINGLETON_destination_t;
}
public static Imm NL_SINGLETON_module_t() {

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
//line 65
___nl__3 = ptd_NL.NL_sim();

//line 65
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("compiler_NL"));
__function_map.Add("name",new ImmString("destination_t"));
___nl__4 = new ImmHash(__function_map);
//line 65
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__4);
//line 65
__function_map = new Dictionary<String, Imm>();
__function_map.Add("src",___nl__3);
__function_map.Add("dst",___nl__4);
___nl__2 = new ImmHash(__function_map);
//line 65
___nl__3 = null;
//line 65
___nl__4 = null;
//line 65
___nl__1 = ptd_NL.NL_rec(___nl__2);

//line 65
___nl__2 = null;
//line 65
___nl__0 = ptd_NL.NL_hash(___nl__1);

//line 65
___nl__1 = null;
//line 65
if(true) return ___nl__0;
//line 65
___nl__0 = null;
//line 65
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_module_t = null;
public static Imm NL_module_t() {
	if (value__singleton__NL_SINGLETON_module_t == null) {
		value__singleton__NL_SINGLETON_module_t = NL_SINGLETON_module_t();
	}
	return value__singleton__NL_SINGLETON_module_t;
}
public static Imm NL_SINGLETON_deref_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 68
___nl__2 = ptd_NL.NL_sim();

//line 68
___nl__3 = ptd_NL.NL_none();

//line 68
__function_map = new Dictionary<String, Imm>();
__function_map.Add("yes",___nl__2);
__function_map.Add("no",___nl__3);
___nl__1 = new ImmHash(__function_map);
//line 68
___nl__2 = null;
//line 68
___nl__3 = null;
//line 68
___nl__0 = ptd_NL.NL_var(___nl__1);

//line 68
___nl__1 = null;
//line 68
if(true) return ___nl__0;
//line 68
___nl__0 = null;
//line 68
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_deref_t = null;
public static Imm NL_deref_t() {
	if (value__singleton__NL_SINGLETON_deref_t == null) {
		value__singleton__NL_SINGLETON_deref_t = NL_SINGLETON_deref_t();
	}
	return value__singleton__NL_SINGLETON_deref_t;
}
public static Imm NL_SINGLETON_try_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 71
___nl__2 = ptd_NL.NL_sim();

//line 71
___nl__3 = ptd_NL.NL_sim();

//line 71
__function_map = new Dictionary<String, Imm>();
__function_map.Add("err",___nl__2);
__function_map.Add("ok",___nl__3);
___nl__1 = new ImmHash(__function_map);
//line 71
___nl__2 = null;
//line 71
___nl__3 = null;
//line 71
___nl__0 = ptd_NL.NL_var(___nl__1);

//line 71
___nl__1 = null;
//line 71
if(true) return ___nl__0;
//line 71
___nl__0 = null;
//line 71
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_try_t = null;
public static Imm NL_try_t() {
	if (value__singleton__NL_SINGLETON_try_t == null) {
		value__singleton__NL_SINGLETON_try_t = NL_SINGLETON_try_t();
	}
	return value__singleton__NL_SINGLETON_try_t;
}
public static Imm NL_SINGLETON_input_type() {

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
//line 74
___nl__3 = ptd_NL.NL_sim();

//line 74
___nl__2 = ptd_NL.NL_arr(___nl__3);

//line 74
___nl__3 = null;
//line 74
___nl__3 = ptd_NL.NL_sim();

//line 74
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("compiler_NL"));
__function_map.Add("name",new ImmString("deref_t"));
___nl__4 = new ImmHash(__function_map);
//line 74
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__4);
//line 74
___nl__7 = ptd_NL.NL_none();

//line 74
___nl__8 = ptd_NL.NL_none();

//line 74
___nl__9 = ptd_NL.NL_none();

//line 74
___nl__10 = ptd_NL.NL_none();

//line 74
___nl__11 = ptd_NL.NL_none();

//line 74
__function_map = new Dictionary<String, Imm>();
__function_map.Add("o0",___nl__7);
__function_map.Add("o1",___nl__8);
__function_map.Add("o2",___nl__9);
__function_map.Add("o3",___nl__10);
__function_map.Add("o4",___nl__11);
___nl__6 = new ImmHash(__function_map);
//line 74
___nl__7 = null;
//line 74
___nl__8 = null;
//line 74
___nl__9 = null;
//line 74
___nl__10 = null;
//line 74
___nl__11 = null;
//line 74
___nl__5 = ptd_NL.NL_var(___nl__6);

//line 74
___nl__6 = null;
//line 74
___nl__6 = ptd_NL.NL_sim();

//line 74
___nl__9 = ptd_NL.NL_none();

//line 74
___nl__10 = ptd_NL.NL_none();

//line 74
___nl__11 = ptd_NL.NL_none();

//line 74
___nl__12 = ptd_NL.NL_sim();

//line 74
__function_map = new Dictionary<String, Imm>();
__function_map.Add("strict",___nl__9);
__function_map.Add("exec",___nl__10);
__function_map.Add("ide",___nl__11);
__function_map.Add("idex",___nl__12);
___nl__8 = new ImmHash(__function_map);
//line 74
___nl__9 = null;
//line 74
___nl__10 = null;
//line 74
___nl__11 = null;
//line 74
___nl__12 = null;
//line 74
___nl__7 = ptd_NL.NL_var(___nl__8);

//line 74
___nl__8 = null;
//line 74
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("compiler_NL"));
__function_map.Add("name",new ImmString("language_t"));
___nl__8 = new ImmHash(__function_map);
//line 74
___nl__8 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__8);
//line 74
___nl__11 = ptd_NL.NL_none();

//line 74
___nl__12 = ptd_NL.NL_none();

//line 74
__function_map = new Dictionary<String, Imm>();
__function_map.Add("norm",___nl__11);
__function_map.Add("wall",___nl__12);
___nl__10 = new ImmHash(__function_map);
//line 74
___nl__11 = null;
//line 74
___nl__12 = null;
//line 74
___nl__9 = ptd_NL.NL_var(___nl__10);

//line 74
___nl__10 = null;
//line 74
__function_map = new Dictionary<String, Imm>();
__function_map.Add("input_path",___nl__2);
__function_map.Add("cache_path",___nl__3);
__function_map.Add("deref",___nl__4);
__function_map.Add("optimization",___nl__5);
__function_map.Add("math_fun",___nl__6);
__function_map.Add("mode",___nl__7);
__function_map.Add("language",___nl__8);
__function_map.Add("alarm",___nl__9);
___nl__1 = new ImmHash(__function_map);
//line 74
___nl__2 = null;
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
//line 74
___nl__8 = null;
//line 74
___nl__9 = null;
//line 74
___nl__0 = ptd_NL.NL_rec(___nl__1);

//line 74
___nl__1 = null;
//line 74
if(true) return ___nl__0;
//line 74
___nl__0 = null;
//line 74
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_input_type = null;
public static Imm NL_input_type() {
	if (value__singleton__NL_SINGLETON_input_type == null) {
		value__singleton__NL_SINGLETON_input_type = NL_SINGLETON_input_type();
	}
	return value__singleton__NL_SINGLETON_input_type;
}
public static Imm NL_SINGLETON_file_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 86
___nl__2 = ptd_NL.NL_sim();

//line 86
___nl__3 = ptd_NL.NL_sim();

//line 86
__function_map = new Dictionary<String, Imm>();
__function_map.Add("ok",___nl__2);
__function_map.Add("err",___nl__3);
___nl__1 = new ImmHash(__function_map);
//line 86
___nl__2 = null;
//line 86
___nl__3 = null;
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
private static Imm value__singleton__NL_SINGLETON_file_t = null;
public static Imm NL_file_t() {
	if (value__singleton__NL_SINGLETON_file_t == null) {
		value__singleton__NL_SINGLETON_file_t = NL_SINGLETON_file_t();
	}
	return value__singleton__NL_SINGLETON_file_t;
}
public static Imm NL_compile(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 89
___nl__1 = compiler_NL.NL_parse_command_line_args_priv(___nl__0);

//line 90
___nl__2 = ((ImmHash)___nl__1).getHashValue()["cache_path"];
//line 90
c_fe_lib_NL.NL_mk_path(___nl__2);

//line 90
___nl__2 = null;
//line 91
___nl__2 = ((ImmHash)___nl__1).getHashValue()["mode"];
//line 91
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("strict"));
//line 91
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 91
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 92
___nl__3 = new ImmString("strict mode processing...");
//line 92
c_fe_lib_NL.NL_print(___nl__3);

//line 92
___nl__3 = null;
//line 93
compiler_NL.NL_compile_strict_file_priv(___nl__1);

//line 94
if (true) {goto label_1;}
//line 94
label_2:
//line 94
___nl__2 = ((ImmHash)___nl__1).getHashValue()["mode"];
//line 94
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("ide"));
//line 94
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_4;}}
//line 94
___nl__2 = ((ImmHash)___nl__1).getHashValue()["mode"];
//line 94
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("idex"));
//line 94
label_4:
//line 94
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 94
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_3;}}
//line 95
___nl__3 = new ImmString("ide mode processing...");
//line 95
c_fe_lib_NL.NL_print(___nl__3);

//line 95
___nl__3 = null;
//line 96
compiler_NL.NL_compile_ide_priv(___nl__1);

//line 97
if (true) {goto label_1;}
//line 97
label_3:
//line 97
___nl__2 = ((ImmHash)___nl__1).getHashValue()["mode"];
//line 97
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("exec"));
//line 97
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 97
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_5;}}
//line 98
compiler_NL.NL_exec_interpreter_priv(___nl__1);

//line 99
if (true) {goto label_1;}
//line 99
label_5:
//line 100
___nl__3 = new ImmArray(new Imm[0]);
//line 100
c_rt_lib_NL.NL_die();
//line 100
___nl__3 = null;
//line 101
if (true) {goto label_1;}
//line 101
label_1:
//line 101
___nl__2 = null;
//line 101
___nl__1 = null;
//line 101
___nl__0 = null;
//line 101
if(true) return null;
}

private static Imm NL_SINGLETON_get_known_func_priv() {

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
//line 104
__function_map = new Dictionary<String, Imm>();
___nl__0 = new ImmHash(__function_map);
//line 105
___nl__1 = new ImmString("nl::print");
//line 105
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nl_NL"));
__function_map.Add("name",new ImmString("print"));
___nl__3 = new ImmHash(__function_map);
//line 105
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3);
//line 105
___nl__4 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("sequential"));
//line 105
___nl__6 = ptd_NL.NL_sim();

//line 105
___nl__5 = new ImmArray(new Imm[] {___nl__6,});
//line 105
___nl__6 = null;
//line 105
__function_map = new Dictionary<String, Imm>();
__function_map.Add("func",___nl__3);
__function_map.Add("type",___nl__4);
__function_map.Add("args",___nl__5);
___nl__2 = new ImmHash(__function_map);
//line 105
___nl__3 = null;
//line 105
___nl__4 = null;
//line 105
___nl__5 = null;
//line 105
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 105
___nl__2 = null;
//line 105
___nl__1 = null;
//line 106
if(true) return ___nl__0;
//line 106
___nl__0 = null;
//line 106
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_get_known_func_priv = null;
private static Imm NL_get_known_func_priv() {
	if (value__singleton__NL_SINGLETON_get_known_func_priv == null) {
		value__singleton__NL_SINGLETON_get_known_func_priv = NL_SINGLETON_get_known_func_priv();
	}
	return value__singleton__NL_SINGLETON_get_known_func_priv;
}
private static Imm NL_exec_interpreter_priv(Imm ___arg__0) {
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
//line 109
__function_map = new Dictionary<String, Imm>();
___nl__1 = new ImmHash(__function_map);
//line 110
__function_map = new Dictionary<String, Imm>();
___nl__3 = new ImmHash(__function_map);
//line 110
__function_map = new Dictionary<String, Imm>();
___nl__4 = new ImmHash(__function_map);
//line 110
__function_map = new Dictionary<String, Imm>();
___nl__5 = new ImmHash(__function_map);
//line 110
__function_map = new Dictionary<String, Imm>();
___nl__6 = new ImmHash(__function_map);
//line 110
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("ok"));
//line 110
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module_errors",___nl__3);
__function_map.Add("module_warnings",___nl__4);
__function_map.Add("type_errors",___nl__5);
__function_map.Add("type_warnings",___nl__6);
__function_map.Add("loop_error",___nl__7);
___nl__2 = new ImmHash(__function_map);
//line 110
___nl__3 = null;
//line 110
___nl__4 = null;
//line 110
___nl__5 = null;
//line 110
___nl__6 = null;
//line 110
___nl__7 = null;
//line 111
___nl__3 = new ImmDouble(0);
//line 112
___nl__4 = compiler_NL.NL_get_files_to_parse_priv(___nl__0);

//line 113
___nl__7 = c_rt_lib_NL.NL_init_iter(___nl__4);

//line 113
label_3:
//line 113
___nl__5 = c_rt_lib_NL.NL_is_end_hash(___nl__7);

//line 113
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_1;}}
//line 113
___nl__5 = c_rt_lib_NL.NL_get_key_iter(___nl__7);

//line 113
___nl__6 = c_rt_lib_NL.NL_hash_get_value(___nl__4,___nl__5);

//line 114
___nl__9 = ((ImmHash)___nl__6).getHashValue()["src"];
//line 114
___ref______nl__2 = new ImmRef(___nl__2);
___nl__8 = compiler_NL.NL_parse_module_priv(___nl__5,___nl__9,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue();

//line 114
___nl__9 = null;
//line 114
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("ok"));
//line 114
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_5;}}
//line 116
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("err"));
//line 116
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_6;}}
//line 116
___nl__9 = new ImmString("NOMATCHALERT");
//line 116
___nl__9 = new ImmArray(new Imm[] {___nl__9,___nl__8,});
//line 116
c_rt_lib_NL.NL_die();
//line 114
label_5:
//line 114
___nl__10 = c_rt_lib_NL.NL_ov_as(___nl__8, new ImmString("ok"));
//line 115
___ref______nl__1 = new ImmRef(___nl__1);
hash_NL.NL_set_value(___ref______nl__1,___nl__5,___nl__10);
___nl__1 = ___ref______nl__1.getValue();

//line 115
___nl__10 = null;
//line 116
if (true) {goto label_4;}
//line 116
label_6:
//line 116
___nl__10 = c_rt_lib_NL.NL_ov_as(___nl__8, new ImmString("err"));
//line 117
___nl__11 = new ImmDouble(1);
//line 117
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__11.getValue().ToString())));
//line 117
___nl__11 = null;
//line 117
___nl__10 = null;
//line 118
if (true) {goto label_4;}
//line 118
label_4:
//line 118
___nl__8 = null;
//line 118
___nl__9 = null;
//line 119
___nl__7 = c_rt_lib_NL.NL_next_iter(___nl__7);

//line 119
if (true) {goto label_3;}
//line 119
label_1:
//line 119
___nl__5 = null;
//line 119
___nl__6 = null;
//line 119
___nl__7 = null;
//line 120
___nl__5 = new ImmDouble(0);
//line 120
___nl__5 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString())) !=((Double.Parse(___nl__5.getValue().ToString())))  );
//line 120
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 120
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_8;}}
//line 121
compiler_NL.NL_show_and_count_errors_priv(___nl__2,___nl__0);

//line 122
___nl__0 = null;
//line 122
___nl__1 = null;
//line 122
___nl__2 = null;
//line 122
___nl__3 = null;
//line 122
___nl__4 = null;
//line 122
___nl__5 = null;
//line 122
if(true) return null;
//line 123
if (true) {goto label_8;}
//line 123
label_8:
//line 123
___nl__5 = null;
//line 124
___nl__5 = ((ImmHash)___nl__0).getHashValue()["deref"];
//line 124
___ref______nl__2 = new ImmRef(___nl__2);
compiler_NL.NL_check_modules_priv(___nl__1,___ref______nl__2,___nl__5);
___nl__2 = ___ref______nl__2.getValue();

//line 124
___nl__5 = null;
//line 125
___nl__5 = compiler_NL.NL_show_and_count_errors_priv(___nl__2,___nl__0);

//line 125
___nl__6 = new ImmDouble(0);
//line 125
___nl__5 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>(Double.Parse(___nl__6.getValue().ToString())) );
//line 125
___nl__6 = null;
//line 125
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 125
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_10;}}
//line 126
___nl__0 = null;
//line 126
___nl__1 = null;
//line 126
___nl__2 = null;
//line 126
___nl__3 = null;
//line 126
___nl__4 = null;
//line 126
___nl__5 = null;
//line 126
if(true) return null;
//line 127
if (true) {goto label_10;}
//line 127
label_10:
//line 127
___nl__5 = null;
//line 129
__function_map = new Dictionary<String, Imm>();
___nl__6 = new ImmHash(__function_map);
//line 129
___nl__7 = ((ImmHash)___nl__0).getHashValue()["optimization"];
//line 129
___nl__5 = post_processing_NL.NL_init(___nl__6,___nl__7);

//line 129
___nl__7 = null;
//line 129
___nl__6 = null;
//line 130
___ref______nl__5 = new ImmRef(___nl__5);
___nl__6 = compiler_NL.NL_translate_priv(___nl__1,___ref______nl__5);
___nl__5 = ___ref______nl__5.getValue();

//line 131
___nl__7 = new ImmArray(new Imm[0]);
//line 132
___nl__8 = new ImmString("");
//line 133
___nl__11 = c_rt_lib_NL.NL_init_iter(___nl__6);

//line 133
label_13:
//line 133
___nl__9 = c_rt_lib_NL.NL_is_end_hash(___nl__11);

//line 133
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_11;}}
//line 133
___nl__9 = c_rt_lib_NL.NL_get_key_iter(___nl__11);

//line 133
___nl__10 = c_rt_lib_NL.NL_hash_get_value(___nl__6,___nl__9);

//line 134
___nl__12 = ((ImmHash)___nl__10).getHashValue()["functions"];
//line 134
___nl__14 = new ImmDouble(0);
//line 134
___nl__15 = new ImmDouble(1);
//line 134
___nl__16 = c_rt_lib_NL.NL_array_len(___nl__12);

//line 134
label_16:
//line 134
___nl__17 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__14.getValue().ToString()))>=(Double.Parse(___nl__16.getValue().ToString())) );
//line 134
if (c_rt_lib_NL.NL_check_true_native(___nl__17)) {if (true) {goto label_14;}}
//line 134
___nl__13 = (___nl__12 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__14).getDoubleValue()];
//line 135
___nl__18 = ((ImmHash)___nl__13).getHashValue()["name"];
//line 135
___nl__19 = new ImmString("main");
//line 135
___nl__18 = c_rt_lib_NL.NL_native_to_nl(___nl__18.toString().Equals(___nl__19.toString()));
//line 135
___nl__19 = null;
//line 135
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18));
//line 135
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_18;}}
//line 136
___nl__8 = ___nl__9;
//line 137
if (true) {goto label_18;}
//line 137
label_18:
//line 137
___nl__18 = null;
//line 138
___nl__14 = new ImmDouble((Double.Parse(___nl__14.getValue().ToString()))+(Double.Parse(___nl__15.getValue().ToString())));
//line 138
if (true) {goto label_16;}
//line 138
label_14:
//line 138
___nl__12 = null;
//line 138
___nl__13 = null;
//line 138
___nl__14 = null;
//line 138
___nl__15 = null;
//line 138
___nl__16 = null;
//line 138
___nl__17 = null;
//line 139
___ref______nl__7 = new ImmRef(___nl__7);
array_NL.NL_push(___ref______nl__7,___nl__10);
___nl__7 = ___ref______nl__7.getValue();

//line 140
___nl__11 = c_rt_lib_NL.NL_next_iter(___nl__11);

//line 140
if (true) {goto label_13;}
//line 140
label_11:
//line 140
___nl__9 = null;
//line 140
___nl__10 = null;
//line 140
___nl__11 = null;
//line 141
___nl__10 = compiler_NL.NL_get_known_func_priv();

//line 141
___nl__9 = interpreter_NL.NL_init(___nl__7,___nl__10);

//line 141
___nl__10 = null;
//line 142
___nl__12 = new ImmString("main");
//line 142
___ref______nl__9 = new ImmRef(___nl__9);
___nl__11 = interpreter_NL.NL_start(___ref______nl__9,___nl__12,___nl__8);
___nl__9 = ___ref______nl__9.getValue();

//line 142
___nl__12 = null;
//line 142
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("ok"));
//line 142
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_19;}}
//line 142
___nl__11 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ensure"), ___nl__11);
//line 142
c_rt_lib_NL.NL_die();
//line 142
label_19:
//line 142
___nl__10 = null;
//line 142
___nl__11 = null;
//line 143
___nl__11 = interpreter_NL.NL_exec_all_code(___nl__9);

//line 143
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("ok"));
//line 143
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_20;}}
//line 143
___nl__11 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ensure"), ___nl__11);
//line 143
c_rt_lib_NL.NL_die();
//line 143
label_20:
//line 143
___nl__10 = null;
//line 143
___nl__11 = null;
//line 143
___nl__1 = null;
//line 143
___nl__2 = null;
//line 143
___nl__3 = null;
//line 143
___nl__4 = null;
//line 143
___nl__5 = null;
//line 143
___nl__6 = null;
//line 143
___nl__7 = null;
//line 143
___nl__8 = null;
//line 143
___nl__9 = null;
//line 143
___nl__0 = null;
//line 143
if(true) return null;
}

private static Imm NL_get_module_name_priv(Imm ___arg__0) {
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
//line 146
___nl__1 = string_NL.NL_length(___nl__0);

//line 146
___nl__2 = new ImmDouble(1);
//line 146
___nl__1 = new ImmDouble((Double.Parse(___nl__1.getValue().ToString()))-(Double.Parse(___nl__2.getValue().ToString())));
//line 146
___nl__2 = null;
//line 147
label_2:
//line 147
___nl__2 = new ImmDouble(0);
//line 147
___nl__2 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__1.getValue().ToString()))>=(Double.Parse(___nl__2.getValue().ToString())) );
//line 147
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 147
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_4;}}
//line 147
___nl__5 = new ImmDouble(1);
//line 147
___nl__2 = string_NL.NL_substr(___nl__0,___nl__1,___nl__5);

//line 147
___nl__5 = null;
//line 147
___nl__5 = new ImmString("/");
//line 147
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!___nl__2.toString().Equals(___nl__5.toString()));
//line 147
___nl__5 = null;
//line 147
label_4:
//line 147
___nl__4 = null;
//line 147
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 147
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 147
___nl__4 = new ImmDouble(1);
//line 147
___nl__2 = string_NL.NL_substr(___nl__0,___nl__1,___nl__4);

//line 147
___nl__4 = null;
//line 147
___nl__4 = new ImmString("\\");
//line 147
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!___nl__2.toString().Equals(___nl__4.toString()));
//line 147
___nl__4 = null;
//line 147
label_3:
//line 147
___nl__3 = null;
//line 147
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 147
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_1;}}
//line 148
___nl__4 = new ImmDouble(1);
//line 148
___nl__3 = string_NL.NL_substr(___nl__0,___nl__1,___nl__4);

//line 148
___nl__4 = null;
//line 148
___nl__4 = new ImmString(".");
//line 148
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__4.toString()));
//line 148
___nl__4 = null;
//line 148
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 148
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_6;}}
//line 149
___nl__4 = new ImmDouble(1);
//line 149
___nl__1 = new ImmDouble((Double.Parse(___nl__1.getValue().ToString()))-(Double.Parse(___nl__4.getValue().ToString())));
//line 149
___nl__4 = null;
//line 150
___nl__3 = null;
//line 150
if (true) {goto label_1;}
//line 151
if (true) {goto label_6;}
//line 151
label_6:
//line 151
___nl__3 = null;
//line 152
___nl__3 = new ImmDouble(1);
//line 152
___nl__1 = new ImmDouble((Double.Parse(___nl__1.getValue().ToString()))-(Double.Parse(___nl__3.getValue().ToString())));
//line 152
___nl__3 = null;
//line 153
if (true) {goto label_2;}
//line 153
label_1:
//line 153
___nl__2 = null;
//line 154
___nl__2 = new ImmString("");
//line 155
label_8:
//line 155
___nl__3 = new ImmDouble(0);
//line 155
___nl__3 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__1.getValue().ToString()))>=(Double.Parse(___nl__3.getValue().ToString())) );
//line 155
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 155
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_10;}}
//line 155
___nl__6 = new ImmDouble(1);
//line 155
___nl__3 = string_NL.NL_substr(___nl__0,___nl__1,___nl__6);

//line 155
___nl__6 = null;
//line 155
___nl__6 = new ImmString("/");
//line 155
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!___nl__3.toString().Equals(___nl__6.toString()));
//line 155
___nl__6 = null;
//line 155
label_10:
//line 155
___nl__5 = null;
//line 155
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 155
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_9;}}
//line 155
___nl__5 = new ImmDouble(1);
//line 155
___nl__3 = string_NL.NL_substr(___nl__0,___nl__1,___nl__5);

//line 155
___nl__5 = null;
//line 155
___nl__5 = new ImmString("\\");
//line 155
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!___nl__3.toString().Equals(___nl__5.toString()));
//line 155
___nl__5 = null;
//line 155
label_9:
//line 155
___nl__4 = null;
//line 155
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 155
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_7;}}
//line 156
___nl__5 = new ImmDouble(1);
//line 156
___nl__4 = string_NL.NL_substr(___nl__0,___nl__1,___nl__5);

//line 156
___nl__5 = null;
//line 156
___nl__4 = new ImmString(___nl__4.toString() + ___nl__2.toString());
//line 156
___nl__2 = ___nl__4;
//line 156
___nl__4 = null;
//line 157
___nl__4 = new ImmDouble(1);
//line 157
___nl__1 = new ImmDouble((Double.Parse(___nl__1.getValue().ToString()))-(Double.Parse(___nl__4.getValue().ToString())));
//line 157
___nl__4 = null;
//line 158
if (true) {goto label_8;}
//line 158
label_7:
//line 158
___nl__3 = null;
//line 159
___nl__0 = null;
//line 159
___nl__1 = null;
//line 159
if(true) return ___nl__2;
//line 159
___nl__1 = null;
//line 159
___nl__2 = null;
//line 159
___nl__0 = null;
//line 159
if(true) return null;
}

private static Imm NL_has_extension_priv(Imm ___arg__0, Imm ___arg__1) {
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
//line 162
___nl__2 = string_NL.NL_length(___nl__1);

//line 163
___nl__3 = string_NL.NL_length(___nl__0);

//line 163
___nl__3 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))<=(Double.Parse(___nl__2.getValue().ToString())) );
//line 163
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 163
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 163
___nl__4 = c_rt_lib_NL.NL_get_false();
//line 163
___nl__0 = null;
//line 163
___nl__1 = null;
//line 163
___nl__2 = null;
//line 163
___nl__3 = null;
//line 163
if(true) return ___nl__4;
//line 163
___nl__4 = null;
//line 163
if (true) {goto label_2;}
//line 163
label_2:
//line 163
___nl__3 = null;
//line 164
___nl__4 = string_NL.NL_length(___nl__0);

//line 164
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))-(Double.Parse(___nl__2.getValue().ToString())));
//line 164
___nl__3 = string_NL.NL_substr(___nl__0,___nl__4,___nl__2);

//line 164
___nl__4 = null;
//line 164
___nl__2 = ___nl__3;
//line 164
___nl__3 = null;
//line 165
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__1.toString()));
//line 165
___nl__0 = null;
//line 165
___nl__1 = null;
//line 165
___nl__2 = null;
//line 165
if(true) return ___nl__3;
//line 165
___nl__3 = null;
//line 165
___nl__2 = null;
//line 165
___nl__0 = null;
//line 165
___nl__1 = null;
//line 165
if(true) return null;
}

private static Imm NL_get_generator_state_priv(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 168
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("pm"));
//line 168
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_2;}}
//line 170
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("nla"));
//line 170
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_3;}}
//line 172
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("c"));
//line 172
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_4;}}
//line 174
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("ast"));
//line 174
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_5;}}
//line 176
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("nl"));
//line 176
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_6;}}
//line 178
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("js"));
//line 178
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_7;}}
//line 180
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("java"));
//line 180
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_8;}}
//line 182
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("cs"));
//line 182
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_9;}}
//line 182
___nl__1 = new ImmString("NOMATCHALERT");
//line 182
___nl__1 = new ImmArray(new Imm[] {___nl__1,___nl__0,});
//line 182
c_rt_lib_NL.NL_die();
//line 168
label_2:
//line 169
___nl__2 = generator_c_NL.NL_get_empty_state();

//line 169
___nl__0 = null;
//line 169
___nl__1 = null;
//line 169
if(true) return ___nl__2;
//line 169
___nl__2 = null;
//line 170
if (true) {goto label_1;}
//line 170
label_3:
//line 171
___nl__2 = generator_c_NL.NL_get_empty_state();

//line 171
___nl__0 = null;
//line 171
___nl__1 = null;
//line 171
if(true) return ___nl__2;
//line 171
___nl__2 = null;
//line 172
if (true) {goto label_1;}
//line 172
label_4:
//line 173
___nl__2 = generator_c_NL.NL_get_empty_state();

//line 173
___nl__0 = null;
//line 173
___nl__1 = null;
//line 173
if(true) return ___nl__2;
//line 173
___nl__2 = null;
//line 174
if (true) {goto label_1;}
//line 174
label_5:
//line 175
___nl__2 = new ImmArray(new Imm[0]);
//line 175
c_rt_lib_NL.NL_die();
//line 175
___nl__2 = null;
//line 176
if (true) {goto label_1;}
//line 176
label_6:
//line 177
___nl__2 = new ImmArray(new Imm[0]);
//line 177
c_rt_lib_NL.NL_die();
//line 177
___nl__2 = null;
//line 178
if (true) {goto label_1;}
//line 178
label_7:
//line 179
___nl__2 = generator_c_NL.NL_get_empty_state();

//line 179
___nl__0 = null;
//line 179
___nl__1 = null;
//line 179
if(true) return ___nl__2;
//line 179
___nl__2 = null;
//line 180
if (true) {goto label_1;}
//line 180
label_8:
//line 181
___nl__2 = generator_c_NL.NL_get_empty_state();

//line 181
___nl__0 = null;
//line 181
___nl__1 = null;
//line 181
if(true) return ___nl__2;
//line 181
___nl__2 = null;
//line 182
if (true) {goto label_1;}
//line 182
label_9:
//line 183
___nl__2 = generator_c_NL.NL_get_empty_state();

//line 183
___nl__0 = null;
//line 183
___nl__1 = null;
//line 183
if(true) return ___nl__2;
//line 183
___nl__2 = null;
//line 184
if (true) {goto label_1;}
//line 184
label_1:
//line 184
___nl__1 = null;
//line 184
___nl__0 = null;
//line 184
if(true) return null;
}

private static Imm NL_get_out_ext_priv(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 187
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("pm"));
//line 187
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_2;}}
//line 189
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("nla"));
//line 189
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_3;}}
//line 191
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("c"));
//line 191
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_4;}}
//line 193
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("ast"));
//line 193
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_5;}}
//line 195
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("nl"));
//line 195
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_6;}}
//line 197
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("js"));
//line 197
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_7;}}
//line 199
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("java"));
//line 199
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_8;}}
//line 201
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("cs"));
//line 201
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_9;}}
//line 201
___nl__1 = new ImmString("NOMATCHALERT");
//line 201
___nl__1 = new ImmArray(new Imm[] {___nl__1,___nl__0,});
//line 201
c_rt_lib_NL.NL_die();
//line 187
label_2:
//line 188
___nl__2 = new ImmString(".pm");
//line 188
___nl__0 = null;
//line 188
___nl__1 = null;
//line 188
if(true) return ___nl__2;
//line 188
___nl__2 = null;
//line 189
if (true) {goto label_1;}
//line 189
label_3:
//line 190
___nl__2 = new ImmString(".nla");
//line 190
___nl__0 = null;
//line 190
___nl__1 = null;
//line 190
if(true) return ___nl__2;
//line 190
___nl__2 = null;
//line 191
if (true) {goto label_1;}
//line 191
label_4:
//line 192
___nl__2 = new ImmString(".c");
//line 192
___nl__0 = null;
//line 192
___nl__1 = null;
//line 192
if(true) return ___nl__2;
//line 192
___nl__2 = null;
//line 193
if (true) {goto label_1;}
//line 193
label_5:
//line 194
___nl__2 = new ImmString(".ast");
//line 194
___nl__0 = null;
//line 194
___nl__1 = null;
//line 194
if(true) return ___nl__2;
//line 194
___nl__2 = null;
//line 195
if (true) {goto label_1;}
//line 195
label_6:
//line 196
___nl__2 = new ImmString(".nl");
//line 196
___nl__0 = null;
//line 196
___nl__1 = null;
//line 196
if(true) return ___nl__2;
//line 196
___nl__2 = null;
//line 197
if (true) {goto label_1;}
//line 197
label_7:
//line 198
___nl__2 = new ImmString(".js");
//line 198
___nl__0 = null;
//line 198
___nl__1 = null;
//line 198
if(true) return ___nl__2;
//line 198
___nl__2 = null;
//line 199
if (true) {goto label_1;}
//line 199
label_8:
//line 200
___nl__2 = new ImmString(".java");
//line 200
___nl__0 = null;
//line 200
___nl__1 = null;
//line 200
if(true) return ___nl__2;
//line 200
___nl__2 = null;
//line 201
if (true) {goto label_1;}
//line 201
label_9:
//line 202
___nl__2 = new ImmString(".cs");
//line 202
___nl__0 = null;
//line 202
___nl__1 = null;
//line 202
if(true) return ___nl__2;
//line 202
___nl__2 = null;
//line 203
if (true) {goto label_1;}
//line 203
label_1:
//line 203
___nl__1 = null;
//line 203
___nl__0 = null;
//line 203
if(true) return null;
}

private static Imm NL_mk_path_priv(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();
Imm ___nl__2 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 206
___nl__2 = new ImmString(".");
//line 206
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__1.toString().Equals(___nl__2.toString()));
//line 206
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 206
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 206
___nl__0 = null;
//line 206
___nl__1 = null;
//line 206
___nl__2 = null;
//line 206
if(true) return null;
//line 206
if (true) {goto label_2;}
//line 206
label_2:
//line 206
___nl__2 = null;
//line 207
___nl__2 = compiler_NL.NL_get_dir_priv(___nl__1);

//line 207
compiler_NL.NL_mk_path_priv(___nl__0,___nl__2);

//line 207
___nl__2 = null;
//line 208
___nl__2 = new ImmString(___nl__0.toString() + ___nl__1.toString());
//line 208
c_fe_lib_NL.NL_mk_path(___nl__2);

//line 208
___nl__2 = null;
//line 208
___nl__0 = null;
//line 208
___nl__1 = null;
//line 208
if(true) return null;
}

private static Imm NL_mk_path_module_priv(Imm ___arg__0, Imm ___arg__1, Imm ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();
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
//line 211
___nl__3 = ((ImmHash)___nl__2).getHashValue()["cache_path"];
//line 211
___nl__3 = new ImmString(___nl__3.toString() + ___nl__1.toString());
//line 212
___nl__4 = ((ImmHash)___nl__0).getHashValue()["file"];
//line 213
___nl__5 = ((ImmHash)___nl__2).getHashValue()["language"];
//line 213
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("pm"));
//line 213
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_2;}}
//line 215
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("nla"));
//line 215
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_3;}}
//line 217
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("c"));
//line 217
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_4;}}
//line 219
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("nl"));
//line 219
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_5;}}
//line 227
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("ast"));
//line 227
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_6;}}
//line 229
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("js"));
//line 229
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_7;}}
//line 231
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("java"));
//line 231
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_8;}}
//line 233
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("cs"));
//line 233
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_9;}}
//line 233
___nl__6 = new ImmString("NOMATCHALERT");
//line 233
___nl__6 = new ImmArray(new Imm[] {___nl__6,___nl__5,});
//line 233
c_rt_lib_NL.NL_die();
//line 213
label_2:
//line 214
___nl__8 = new ImmString(".pm");
//line 214
___nl__8 = new ImmString(___nl__3.toString() + ___nl__8.toString());
//line 214
___nl__8 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("pm"), ___nl__8);
//line 214
__function_map = new Dictionary<String, Imm>();
__function_map.Add("src",___nl__4);
__function_map.Add("dst",___nl__8);
___nl__7 = new ImmHash(__function_map);
//line 214
___nl__8 = null;
//line 214
___nl__0 = null;
//line 214
___nl__1 = null;
//line 214
___nl__2 = null;
//line 214
___nl__3 = null;
//line 214
___nl__4 = null;
//line 214
___nl__5 = null;
//line 214
___nl__6 = null;
//line 214
if(true) return ___nl__7;
//line 214
___nl__7 = null;
//line 215
if (true) {goto label_1;}
//line 215
label_3:
//line 216
___nl__8 = new ImmString(".nla");
//line 216
___nl__8 = new ImmString(___nl__3.toString() + ___nl__8.toString());
//line 216
___nl__8 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("nla"), ___nl__8);
//line 216
__function_map = new Dictionary<String, Imm>();
__function_map.Add("src",___nl__4);
__function_map.Add("dst",___nl__8);
___nl__7 = new ImmHash(__function_map);
//line 216
___nl__8 = null;
//line 216
___nl__0 = null;
//line 216
___nl__1 = null;
//line 216
___nl__2 = null;
//line 216
___nl__3 = null;
//line 216
___nl__4 = null;
//line 216
___nl__5 = null;
//line 216
___nl__6 = null;
//line 216
if(true) return ___nl__7;
//line 216
___nl__7 = null;
//line 217
if (true) {goto label_1;}
//line 217
label_4:
//line 218
___nl__9 = new ImmString(".c");
//line 218
___nl__9 = new ImmString(___nl__3.toString() + ___nl__9.toString());
//line 218
___nl__10 = new ImmString(".h");
//line 218
___nl__10 = new ImmString(___nl__3.toString() + ___nl__10.toString());
//line 218
__function_map = new Dictionary<String, Imm>();
__function_map.Add("c",___nl__9);
__function_map.Add("h",___nl__10);
___nl__8 = new ImmHash(__function_map);
//line 218
___nl__9 = null;
//line 218
___nl__10 = null;
//line 218
___nl__8 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("c"), ___nl__8);
//line 218
__function_map = new Dictionary<String, Imm>();
__function_map.Add("src",___nl__4);
__function_map.Add("dst",___nl__8);
___nl__7 = new ImmHash(__function_map);
//line 218
___nl__8 = null;
//line 218
___nl__0 = null;
//line 218
___nl__1 = null;
//line 218
___nl__2 = null;
//line 218
___nl__3 = null;
//line 218
___nl__4 = null;
//line 218
___nl__5 = null;
//line 218
___nl__6 = null;
//line 218
if(true) return ___nl__7;
//line 218
___nl__7 = null;
//line 219
if (true) {goto label_1;}
//line 219
label_5:
//line 220
___nl__8 = ((ImmHash)___nl__0).getHashValue()["dir"];
//line 220
___nl__7 = string_NL.NL_length(___nl__8);

//line 220
___nl__8 = null;
//line 221
___nl__8 = compiler_NL.NL_get_dir_priv(___nl__4);

//line 222
___nl__9 = ((ImmHash)___nl__2).getHashValue()["cache_path"];
//line 222
___nl__9 = new ImmString(___nl__9.toString() + ___nl__8.toString());
//line 222
___nl__10 = new ImmString("/");
//line 222
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString());
//line 222
___nl__10 = null;
//line 222
___nl__9 = new ImmString(___nl__9.toString() + ___nl__1.toString());
//line 222
___nl__3 = ___nl__9;
//line 222
___nl__9 = null;
//line 223
___nl__9 = string_NL.NL_length(___nl__8);

//line 223
___nl__9 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))<(Double.Parse(___nl__9.getValue().ToString())) );
//line 223
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9));
//line 223
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_11;}}
//line 224
___nl__10 = ((ImmHash)___nl__2).getHashValue()["cache_path"];
//line 224
___nl__12 = new ImmDouble(1);
//line 224
___nl__12 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))+(Double.Parse(___nl__12.getValue().ToString())));
//line 224
___nl__11 = string_NL.NL_substr2(___nl__8,___nl__12);

//line 224
___nl__12 = null;
//line 224
compiler_NL.NL_mk_path_priv(___nl__10,___nl__11);

//line 224
___nl__11 = null;
//line 224
___nl__10 = null;
//line 225
if (true) {goto label_11;}
//line 225
label_11:
//line 225
___nl__9 = null;
//line 226
___nl__10 = new ImmString(".nl");
//line 226
___nl__10 = new ImmString(___nl__3.toString() + ___nl__10.toString());
//line 226
___nl__10 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("nl"), ___nl__10);
//line 226
__function_map = new Dictionary<String, Imm>();
__function_map.Add("src",___nl__4);
__function_map.Add("dst",___nl__10);
___nl__9 = new ImmHash(__function_map);
//line 226
___nl__10 = null;
//line 226
___nl__0 = null;
//line 226
___nl__1 = null;
//line 226
___nl__2 = null;
//line 226
___nl__3 = null;
//line 226
___nl__4 = null;
//line 226
___nl__5 = null;
//line 226
___nl__6 = null;
//line 226
___nl__7 = null;
//line 226
___nl__8 = null;
//line 226
if(true) return ___nl__9;
//line 226
___nl__9 = null;
//line 226
___nl__7 = null;
//line 226
___nl__8 = null;
//line 227
if (true) {goto label_1;}
//line 227
label_6:
//line 228
___nl__8 = new ImmString(".ast");
//line 228
___nl__8 = new ImmString(___nl__3.toString() + ___nl__8.toString());
//line 228
___nl__8 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ast"), ___nl__8);
//line 228
__function_map = new Dictionary<String, Imm>();
__function_map.Add("src",___nl__4);
__function_map.Add("dst",___nl__8);
___nl__7 = new ImmHash(__function_map);
//line 228
___nl__8 = null;
//line 228
___nl__0 = null;
//line 228
___nl__1 = null;
//line 228
___nl__2 = null;
//line 228
___nl__3 = null;
//line 228
___nl__4 = null;
//line 228
___nl__5 = null;
//line 228
___nl__6 = null;
//line 228
if(true) return ___nl__7;
//line 228
___nl__7 = null;
//line 229
if (true) {goto label_1;}
//line 229
label_7:
//line 230
___nl__8 = new ImmString(".js");
//line 230
___nl__8 = new ImmString(___nl__3.toString() + ___nl__8.toString());
//line 230
___nl__8 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("js"), ___nl__8);
//line 230
__function_map = new Dictionary<String, Imm>();
__function_map.Add("src",___nl__4);
__function_map.Add("dst",___nl__8);
___nl__7 = new ImmHash(__function_map);
//line 230
___nl__8 = null;
//line 230
___nl__0 = null;
//line 230
___nl__1 = null;
//line 230
___nl__2 = null;
//line 230
___nl__3 = null;
//line 230
___nl__4 = null;
//line 230
___nl__5 = null;
//line 230
___nl__6 = null;
//line 230
if(true) return ___nl__7;
//line 230
___nl__7 = null;
//line 231
if (true) {goto label_1;}
//line 231
label_8:
//line 232
___nl__8 = new ImmString("_NL.java");
//line 232
___nl__8 = new ImmString(___nl__3.toString() + ___nl__8.toString());
//line 232
___nl__8 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("java"), ___nl__8);
//line 232
__function_map = new Dictionary<String, Imm>();
__function_map.Add("src",___nl__4);
__function_map.Add("dst",___nl__8);
___nl__7 = new ImmHash(__function_map);
//line 232
___nl__8 = null;
//line 232
___nl__0 = null;
//line 232
___nl__1 = null;
//line 232
___nl__2 = null;
//line 232
___nl__3 = null;
//line 232
___nl__4 = null;
//line 232
___nl__5 = null;
//line 232
___nl__6 = null;
//line 232
if(true) return ___nl__7;
//line 232
___nl__7 = null;
//line 233
if (true) {goto label_1;}
//line 233
label_9:
//line 234
___nl__8 = new ImmString("_NL.cs");
//line 234
___nl__8 = new ImmString(___nl__3.toString() + ___nl__8.toString());
//line 234
___nl__8 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("cs"), ___nl__8);
//line 234
__function_map = new Dictionary<String, Imm>();
__function_map.Add("src",___nl__4);
__function_map.Add("dst",___nl__8);
___nl__7 = new ImmHash(__function_map);
//line 234
___nl__8 = null;
//line 234
___nl__0 = null;
//line 234
___nl__1 = null;
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
if(true) return ___nl__7;
//line 234
___nl__7 = null;
//line 235
if (true) {goto label_1;}
//line 235
label_1:
//line 235
___nl__5 = null;
//line 235
___nl__6 = null;
//line 235
___nl__3 = null;
//line 235
___nl__4 = null;
//line 235
___nl__0 = null;
//line 235
___nl__1 = null;
//line 235
___nl__2 = null;
//line 235
if(true) return null;
}

private static Imm NL_get_all_nianio_file_priv(Imm ___arg__0) {
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
//line 239
___nl__1 = new ImmArray(new Imm[0]);
//line 240
___nl__4 = ptd_NL.NL_sim();

//line 240
___nl__3 = ptd_NL.NL_arr(___nl__4);

//line 240
___nl__4 = null;
//line 240
___nl__4 = c_fe_lib_NL.NL_get_module_files_rec(___nl__0);

//line 240
___nl__2 = ptd_NL.NL_ensure(___nl__3,___nl__4);

//line 240
___nl__4 = null;
//line 240
___nl__3 = null;
//line 241
___nl__4 = new ImmDouble(0);
//line 241
___nl__5 = new ImmDouble(1);
//line 241
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__2);

//line 241
label_3:
//line 241
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) );
//line 241
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_1;}}
//line 241
___nl__3 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()];
//line 242
___nl__9 = new ImmString(".nl");
//line 242
___nl__8 = compiler_NL.NL_has_extension_priv(___nl__3,___nl__9);

//line 242
___nl__9 = null;
//line 242
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8));
//line 242
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_5;}}
//line 242
___ref______nl__1 = new ImmRef(___nl__1);
array_NL.NL_push(___ref______nl__1,___nl__3);
___nl__1 = ___ref______nl__1.getValue();

//line 242
if (true) {goto label_5;}
//line 242
label_5:
//line 242
___nl__8 = null;
//line 243
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString())));
//line 243
if (true) {goto label_3;}
//line 243
label_1:
//line 243
___nl__3 = null;
//line 243
___nl__4 = null;
//line 243
___nl__5 = null;
//line 243
___nl__6 = null;
//line 243
___nl__7 = null;
//line 244
___nl__0 = null;
//line 244
___nl__2 = null;
//line 244
if(true) return ___nl__1;
//line 244
___nl__1 = null;
//line 244
___nl__2 = null;
//line 244
___nl__0 = null;
//line 244
if(true) return null;
}

private static Imm NL_get_files_to_parse_priv(Imm ___arg__0) {
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
//line 247
___nl__1 = ((ImmHash)___nl__0).getHashValue()["cache_path"];
//line 248
___nl__2 = new ImmArray(new Imm[0]);
//line 249
___nl__3 = ((ImmHash)___nl__0).getHashValue()["input_path"];
//line 249
___nl__5 = new ImmDouble(0);
//line 249
___nl__6 = new ImmDouble(1);
//line 249
___nl__7 = c_rt_lib_NL.NL_array_len(___nl__3);

//line 249
label_3:
//line 249
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) );
//line 249
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_1;}}
//line 249
___nl__4 = (___nl__3 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()];
//line 250
___nl__10 = new ImmString(".nl");
//line 250
___nl__9 = compiler_NL.NL_has_extension_priv(___nl__4,___nl__10);

//line 250
___nl__10 = null;
//line 250
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9));
//line 250
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_5;}}
//line 251
___nl__11 = compiler_NL.NL_get_dir_priv(___nl__4);

//line 251
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dir",___nl__11);
__function_map.Add("file",___nl__4);
___nl__10 = new ImmHash(__function_map);
//line 251
___nl__11 = null;
//line 251
___ref______nl__2 = new ImmRef(___nl__2);
array_NL.NL_push(___ref______nl__2,___nl__10);
___nl__2 = ___ref______nl__2.getValue();

//line 251
___nl__10 = null;
//line 252
if (true) {goto label_4;}
//line 252
label_5:
//line 253
___nl__10 = compiler_NL.NL_get_all_nianio_file_priv(___nl__4);

//line 253
___nl__12 = new ImmDouble(0);
//line 253
___nl__13 = new ImmDouble(1);
//line 253
___nl__14 = c_rt_lib_NL.NL_array_len(___nl__10);

//line 253
label_8:
//line 253
___nl__15 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__12.getValue().ToString()))>=(Double.Parse(___nl__14.getValue().ToString())) );
//line 253
if (c_rt_lib_NL.NL_check_true_native(___nl__15)) {if (true) {goto label_6;}}
//line 253
___nl__11 = (___nl__10 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__12).getDoubleValue()];
//line 254
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dir",___nl__4);
__function_map.Add("file",___nl__11);
___nl__16 = new ImmHash(__function_map);
//line 254
___ref______nl__2 = new ImmRef(___nl__2);
array_NL.NL_push(___ref______nl__2,___nl__16);
___nl__2 = ___ref______nl__2.getValue();

//line 254
___nl__16 = null;
//line 255
___nl__12 = new ImmDouble((Double.Parse(___nl__12.getValue().ToString()))+(Double.Parse(___nl__13.getValue().ToString())));
//line 255
if (true) {goto label_8;}
//line 255
label_6:
//line 255
___nl__10 = null;
//line 255
___nl__11 = null;
//line 255
___nl__12 = null;
//line 255
___nl__13 = null;
//line 255
___nl__14 = null;
//line 255
___nl__15 = null;
//line 256
if (true) {goto label_4;}
//line 256
label_4:
//line 256
___nl__9 = null;
//line 257
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString())));
//line 257
if (true) {goto label_3;}
//line 257
label_1:
//line 257
___nl__3 = null;
//line 257
___nl__4 = null;
//line 257
___nl__5 = null;
//line 257
___nl__6 = null;
//line 257
___nl__7 = null;
//line 257
___nl__8 = null;
//line 258
___nl__4 = ((ImmHash)___nl__0).getHashValue()["language"];
//line 258
___nl__3 = compiler_NL.NL_get_out_ext_priv(___nl__4);

//line 258
___nl__4 = null;
//line 259
__function_map = new Dictionary<String, Imm>();
___nl__4 = new ImmHash(__function_map);
//line 260
___nl__5 = c_fe_lib_NL.NL_get_module_files(___nl__1);

//line 260
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("ok"));
//line 260
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_10;}}
//line 265
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("err"));
//line 265
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_11;}}
//line 265
___nl__6 = new ImmString("NOMATCHALERT");
//line 265
___nl__6 = new ImmArray(new Imm[] {___nl__6,___nl__5,});
//line 265
c_rt_lib_NL.NL_die();
//line 260
label_10:
//line 260
___nl__7 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("ok"));
//line 261
___nl__10 = ptd_NL.NL_sim();

//line 261
___nl__9 = ptd_NL.NL_arr(___nl__10);

//line 261
___nl__10 = null;
//line 261
___nl__8 = ptd_NL.NL_ensure(___nl__9,___nl__7);

//line 261
___nl__9 = null;
//line 261
___nl__10 = new ImmDouble(0);
//line 261
___nl__11 = new ImmDouble(1);
//line 261
___nl__12 = c_rt_lib_NL.NL_array_len(___nl__8);

//line 261
label_14:
//line 261
___nl__13 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__10.getValue().ToString()))>=(Double.Parse(___nl__12.getValue().ToString())) );
//line 261
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_12;}}
//line 261
___nl__9 = (___nl__8 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()];
//line 262
___nl__14 = compiler_NL.NL_has_extension_priv(___nl__9,___nl__3);

//line 262
___nl__14 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__14));
//line 262
___nl__14 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__14));
//line 262
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_16;}}
//line 262
___nl__14 = null;
//line 262
if (true) {goto label_13;}
//line 262
if (true) {goto label_16;}
//line 262
label_16:
//line 262
___nl__14 = null;
//line 263
___nl__14 = compiler_NL.NL_get_module_name_priv(___nl__9);

//line 263
___ref______nl__4 = new ImmRef(___nl__4);
hash_NL.NL_set_value(___ref______nl__4,___nl__14,___nl__9);
___nl__4 = ___ref______nl__4.getValue();

//line 263
___nl__14 = null;
//line 263
label_13:
//line 264
___nl__10 = new ImmDouble((Double.Parse(___nl__10.getValue().ToString()))+(Double.Parse(___nl__11.getValue().ToString())));
//line 264
if (true) {goto label_14;}
//line 264
label_12:
//line 264
___nl__8 = null;
//line 264
___nl__9 = null;
//line 264
___nl__10 = null;
//line 264
___nl__11 = null;
//line 264
___nl__12 = null;
//line 264
___nl__13 = null;
//line 264
___nl__7 = null;
//line 265
if (true) {goto label_9;}
//line 265
label_11:
//line 265
___nl__7 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("err"));
//line 266
__function_map = new Dictionary<String, Imm>();
___nl__8 = new ImmHash(__function_map);
//line 266
___nl__0 = null;
//line 266
___nl__1 = null;
//line 266
___nl__2 = null;
//line 266
___nl__3 = null;
//line 266
___nl__4 = null;
//line 266
___nl__5 = null;
//line 266
___nl__6 = null;
//line 266
___nl__7 = null;
//line 266
if(true) return ___nl__8;
//line 266
___nl__8 = null;
//line 266
___nl__7 = null;
//line 267
if (true) {goto label_9;}
//line 267
label_9:
//line 267
___nl__5 = null;
//line 267
___nl__6 = null;
//line 268
__function_map = new Dictionary<String, Imm>();
___nl__5 = new ImmHash(__function_map);
//line 269
___nl__7 = new ImmDouble(0);
//line 269
___nl__8 = new ImmDouble(1);
//line 269
___nl__9 = c_rt_lib_NL.NL_array_len(___nl__2);

//line 269
label_19:
//line 269
___nl__10 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))>=(Double.Parse(___nl__9.getValue().ToString())) );
//line 269
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_17;}}
//line 269
___nl__6 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 270
___nl__12 = ((ImmHash)___nl__6).getHashValue()["file"];
//line 270
___nl__11 = compiler_NL.NL_get_module_name_priv(___nl__12);

//line 270
___nl__12 = null;
//line 271
___nl__12 = compiler_NL.NL_mk_path_module_priv(___nl__6,___nl__11,___nl__0);

//line 272
___ref______nl__5 = new ImmRef(___nl__5);
hash_NL.NL_set_value(___ref______nl__5,___nl__11,___nl__12);
___nl__5 = ___ref______nl__5.getValue();

//line 272
___nl__11 = null;
//line 272
___nl__12 = null;
//line 273
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString())));
//line 273
if (true) {goto label_19;}
//line 273
label_17:
//line 273
___nl__6 = null;
//line 273
___nl__7 = null;
//line 273
___nl__8 = null;
//line 273
___nl__9 = null;
//line 273
___nl__10 = null;
//line 274
___nl__0 = null;
//line 274
___nl__1 = null;
//line 274
___nl__2 = null;
//line 274
___nl__3 = null;
//line 274
___nl__4 = null;
//line 274
if(true) return ___nl__5;
//line 274
___nl__1 = null;
//line 274
___nl__2 = null;
//line 274
___nl__3 = null;
//line 274
___nl__4 = null;
//line 274
___nl__5 = null;
//line 274
___nl__0 = null;
//line 274
if(true) return null;
}

private static Imm NL_parse_module_priv(Imm ___arg__0, Imm ___arg__1, ImmRef ___arg__2) {
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
//line 278
___nl__3 = new ImmString("processing ");
//line 278
___nl__3 = new ImmString(___nl__3.toString() + ___nl__0.toString());
//line 278
___nl__4 = new ImmString("...");
//line 278
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 278
___nl__4 = null;
//line 278
c_fe_lib_NL.NL_print(___nl__3);

//line 278
___nl__3 = null;
//line 279
___nl__5 = c_fe_lib_NL.NL_file_to_string(___nl__1);

//line 279
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("ok"));
//line 279
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_1;}}
//line 279
___nl__0 = null;
//line 279
___nl__1 = null;
//line 279
___nl__3 = null;
//line 279
___nl__4 = null;
//line 279
___arg__2.setValue(___nl__2);if(true) return ___nl__5;
//line 279
label_1:
//line 279
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("ok"));
//line 279
___nl__4 = null;
//line 279
___nl__5 = null;
//line 280
___nl__6 = ptd_NL.NL_sim();

//line 280
___nl__5 = ptd_NL.NL_ensure(___nl__6,___nl__3);

//line 280
___nl__6 = null;
//line 280
___nl__4 = nparser_NL.NL_sparse(___nl__5,___nl__0);

//line 280
___nl__5 = null;
//line 281
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("ok"));
//line 281
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_3;}}
//line 287
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("error"));
//line 287
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_4;}}
//line 287
___nl__5 = new ImmString("NOMATCHALERT");
//line 287
___nl__5 = new ImmArray(new Imm[] {___nl__5,___nl__4,});
//line 287
c_rt_lib_NL.NL_die();
//line 281
label_3:
//line 281
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("ok"));
//line 282
___nl__7 = module_checker_NL.NL_check_module(___nl__6);

//line 283
___nl__8 = new ImmString("module_warnings");
//line 283
___nl__8 = c_rt_lib_NL.NL_get_ref_hash(___nl__2,___nl__8);

//line 283
___nl__9 = ((ImmHash)___nl__7).getHashValue()["warnings"];
//line 283
___ref______nl__8 = new ImmRef(___nl__8);
hash_NL.NL_set_value(___ref______nl__8,___nl__0,___nl__9);
___nl__8 = ___ref______nl__8.getValue();

//line 283
___nl__9 = null;
//line 283
___nl__9 = new ImmString("module_warnings");
//line 283
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__2,___nl__9,___nl__8);
___nl__2 = ___ref______nl__2.getValue();

//line 283
___nl__9 = null;
//line 283
___nl__8 = null;
//line 284
___nl__8 = new ImmString("module_errors");
//line 284
___nl__8 = c_rt_lib_NL.NL_get_ref_hash(___nl__2,___nl__8);

//line 284
___nl__9 = ((ImmHash)___nl__7).getHashValue()["errors"];
//line 284
___ref______nl__8 = new ImmRef(___nl__8);
hash_NL.NL_set_value(___ref______nl__8,___nl__0,___nl__9);
___nl__8 = ___ref______nl__8.getValue();

//line 284
___nl__9 = null;
//line 284
___nl__9 = new ImmString("module_errors");
//line 284
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__2,___nl__9,___nl__8);
___nl__2 = ___ref______nl__2.getValue();

//line 284
___nl__9 = null;
//line 284
___nl__8 = null;
//line 285
___nl__9 = ((ImmHash)___nl__7).getHashValue()["errors"];
//line 285
___nl__8 = array_NL.NL_len(___nl__9);

//line 285
___nl__9 = null;
//line 285
___nl__9 = new ImmDouble(0);
//line 285
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString())) ==((Double.Parse(___nl__9.getValue().ToString())))  );
//line 285
___nl__9 = null;
//line 285
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8));
//line 285
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8));
//line 285
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_6;}}
//line 285
___nl__9 = new ImmString("");
//line 285
___nl__9 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("err"), ___nl__9);
//line 285
___nl__0 = null;
//line 285
___nl__1 = null;
//line 285
___nl__3 = null;
//line 285
___nl__4 = null;
//line 285
___nl__5 = null;
//line 285
___nl__6 = null;
//line 285
___nl__7 = null;
//line 285
___nl__8 = null;
//line 285
___arg__2.setValue(___nl__2);if(true) return ___nl__9;
//line 285
___nl__9 = null;
//line 285
if (true) {goto label_6;}
//line 285
label_6:
//line 285
___nl__8 = null;
//line 286
___nl__8 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__6);
//line 286
___nl__0 = null;
//line 286
___nl__1 = null;
//line 286
___nl__3 = null;
//line 286
___nl__4 = null;
//line 286
___nl__5 = null;
//line 286
___nl__6 = null;
//line 286
___nl__7 = null;
//line 286
___arg__2.setValue(___nl__2);if(true) return ___nl__8;
//line 286
___nl__8 = null;
//line 286
___nl__7 = null;
//line 286
___nl__6 = null;
//line 287
if (true) {goto label_2;}
//line 287
label_4:
//line 287
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("error"));
//line 288
___nl__7 = new ImmString("module_warnings");
//line 288
___nl__7 = c_rt_lib_NL.NL_get_ref_hash(___nl__2,___nl__7);

//line 288
___nl__8 = new ImmArray(new Imm[0]);
//line 288
___ref______nl__7 = new ImmRef(___nl__7);
hash_NL.NL_set_value(___ref______nl__7,___nl__0,___nl__8);
___nl__7 = ___ref______nl__7.getValue();

//line 288
___nl__8 = null;
//line 288
___nl__8 = new ImmString("module_warnings");
//line 288
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__2,___nl__8,___nl__7);
___nl__2 = ___ref______nl__2.getValue();

//line 288
___nl__8 = null;
//line 288
___nl__7 = null;
//line 289
___nl__7 = new ImmArray(new Imm[0]);
//line 290
___nl__9 = new ImmDouble(0);
//line 290
___nl__10 = new ImmDouble(1);
//line 290
___nl__11 = c_rt_lib_NL.NL_array_len(___nl__6);

//line 290
label_9:
//line 290
___nl__12 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__9.getValue().ToString()))>=(Double.Parse(___nl__11.getValue().ToString())) );
//line 290
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_7;}}
//line 290
___nl__8 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()];
//line 291
___nl__14 = ((ImmHash)___nl__8).getHashValue()["msg"];
//line 291
___nl__15 = ((ImmHash)___nl__8).getHashValue()["line"];
//line 291
__function_map = new Dictionary<String, Imm>();
__function_map.Add("msg",___nl__14);
__function_map.Add("line",___nl__15);
__function_map.Add("module",___nl__0);
___nl__13 = new ImmHash(__function_map);
//line 291
___nl__14 = null;
//line 291
___nl__15 = null;
//line 291
___ref______nl__7 = new ImmRef(___nl__7);
array_NL.NL_push(___ref______nl__7,___nl__13);
___nl__7 = ___ref______nl__7.getValue();

//line 291
___nl__13 = null;
//line 292
___nl__9 = new ImmDouble((Double.Parse(___nl__9.getValue().ToString()))+(Double.Parse(___nl__10.getValue().ToString())));
//line 292
if (true) {goto label_9;}
//line 292
label_7:
//line 292
___nl__8 = null;
//line 292
___nl__9 = null;
//line 292
___nl__10 = null;
//line 292
___nl__11 = null;
//line 292
___nl__12 = null;
//line 293
___nl__8 = new ImmString("module_errors");
//line 293
___nl__8 = c_rt_lib_NL.NL_get_ref_hash(___nl__2,___nl__8);

//line 293
___ref______nl__8 = new ImmRef(___nl__8);
hash_NL.NL_set_value(___ref______nl__8,___nl__0,___nl__7);
___nl__8 = ___ref______nl__8.getValue();

//line 293
___nl__9 = new ImmString("module_errors");
//line 293
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__2,___nl__9,___nl__8);
___nl__2 = ___ref______nl__2.getValue();

//line 293
___nl__9 = null;
//line 293
___nl__8 = null;
//line 294
___nl__8 = new ImmString("");
//line 294
___nl__8 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("err"), ___nl__8);
//line 294
___nl__0 = null;
//line 294
___nl__1 = null;
//line 294
___nl__3 = null;
//line 294
___nl__4 = null;
//line 294
___nl__5 = null;
//line 294
___nl__6 = null;
//line 294
___nl__7 = null;
//line 294
___arg__2.setValue(___nl__2);if(true) return ___nl__8;
//line 294
___nl__8 = null;
//line 294
___nl__7 = null;
//line 294
___nl__6 = null;
//line 295
if (true) {goto label_2;}
//line 295
label_2:
//line 295
___nl__5 = null;
//line 295
___nl__3 = null;
//line 295
___nl__4 = null;
//line 295
___nl__0 = null;
//line 295
___nl__1 = null;
//line 295
___arg__2.setValue(___nl__2);if(true) return null;
}

private static Imm NL_get_mathematical_func_priv(Imm ___arg__0) {
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
//line 298
__function_map = new Dictionary<String, Imm>();
___nl__1 = new ImmHash(__function_map);
//line 299
___nl__3 = ((ImmHash)___nl__0).getHashValue()["math_fun"];
//line 299
___nl__2 = c_fe_lib_NL.NL_file_to_string(___nl__3);

//line 299
___nl__3 = null;
//line 299
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("ok"));
//line 299
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 312
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("err"));
//line 312
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 312
___nl__3 = new ImmString("NOMATCHALERT");
//line 312
___nl__3 = new ImmArray(new Imm[] {___nl__3,___nl__2,});
//line 312
c_rt_lib_NL.NL_die();
//line 299
label_2:
//line 299
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("ok"));
//line 300
___nl__5 = new ImmString("list of mathematical functions loaded");
//line 300
c_fe_lib_NL.NL_print(___nl__5);

//line 300
___nl__5 = null;
//line 301
___nl__5 = dfile_NL.NL_try_sload(___nl__4);

//line 302
___nl__6 = new ImmArray(new Imm[0]);
//line 303
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("ok"));
//line 303
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_5;}}
//line 305
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("err"));
//line 305
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_6;}}
//line 305
___nl__7 = new ImmString("NOMATCHALERT");
//line 305
___nl__7 = new ImmArray(new Imm[] {___nl__7,___nl__5,});
//line 305
c_rt_lib_NL.NL_die();
//line 303
label_5:
//line 303
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("ok"));
//line 304
___nl__6 = ___nl__8;
//line 304
___nl__8 = null;
//line 305
if (true) {goto label_4;}
//line 305
label_6:
//line 305
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("err"));
//line 306
___nl__9 = new ImmString("could not parse list of mathematical functions:");
//line 306
c_fe_lib_NL.NL_print(___nl__9);

//line 306
___nl__9 = null;
//line 307
c_fe_lib_NL.NL_print(___nl__8);

//line 307
___nl__8 = null;
//line 308
if (true) {goto label_4;}
//line 308
label_4:
//line 308
___nl__7 = null;
//line 309
___nl__8 = new ImmDouble(0);
//line 309
___nl__9 = new ImmDouble(1);
//line 309
___nl__10 = c_rt_lib_NL.NL_array_len(___nl__6);

//line 309
label_9:
//line 309
___nl__11 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString()))>=(Double.Parse(___nl__10.getValue().ToString())) );
//line 309
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_7;}}
//line 309
___nl__7 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 310
___nl__12 = new ImmDouble(1);
//line 310
___ref______nl__1 = new ImmRef(___nl__1);
hash_NL.NL_set_value(___ref______nl__1,___nl__7,___nl__12);
___nl__1 = ___ref______nl__1.getValue();

//line 310
___nl__12 = null;
//line 311
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))+(Double.Parse(___nl__9.getValue().ToString())));
//line 311
if (true) {goto label_9;}
//line 311
label_7:
//line 311
___nl__7 = null;
//line 311
___nl__8 = null;
//line 311
___nl__9 = null;
//line 311
___nl__10 = null;
//line 311
___nl__11 = null;
//line 311
___nl__5 = null;
//line 311
___nl__6 = null;
//line 311
___nl__4 = null;
//line 312
if (true) {goto label_1;}
//line 312
label_3:
//line 312
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("err"));
//line 313
___nl__5 = new ImmString("NOT LOAD: list of mathematical functions");
//line 313
c_fe_lib_NL.NL_print(___nl__5);

//line 313
___nl__5 = null;
//line 313
___nl__4 = null;
//line 314
if (true) {goto label_1;}
//line 314
label_1:
//line 314
___nl__2 = null;
//line 314
___nl__3 = null;
//line 315
___nl__0 = null;
//line 315
if(true) return ___nl__1;
//line 315
___nl__1 = null;
//line 315
___nl__0 = null;
//line 315
if(true) return null;
}

private static Imm NL_compile_ide_priv(Imm ___arg__0) {
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
//line 318
__function_map = new Dictionary<String, Imm>();
___nl__1 = new ImmHash(__function_map);
//line 319
__function_map = new Dictionary<String, Imm>();
___nl__2 = new ImmHash(__function_map);
//line 320
__function_map = new Dictionary<String, Imm>();
___nl__3 = new ImmHash(__function_map);
//line 321
__function_map = new Dictionary<String, Imm>();
___nl__4 = new ImmHash(__function_map);
//line 322
__function_map = new Dictionary<String, Imm>();
___nl__6 = new ImmHash(__function_map);
//line 322
__function_map = new Dictionary<String, Imm>();
___nl__7 = new ImmHash(__function_map);
//line 322
__function_map = new Dictionary<String, Imm>();
___nl__8 = new ImmHash(__function_map);
//line 322
__function_map = new Dictionary<String, Imm>();
___nl__9 = new ImmHash(__function_map);
//line 322
___nl__10 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("ok"));
//line 322
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module_errors",___nl__6);
__function_map.Add("module_warnings",___nl__7);
__function_map.Add("type_errors",___nl__8);
__function_map.Add("type_warnings",___nl__9);
__function_map.Add("loop_error",___nl__10);
___nl__5 = new ImmHash(__function_map);
//line 322
___nl__6 = null;
//line 322
___nl__7 = null;
//line 322
___nl__8 = null;
//line 322
___nl__9 = null;
//line 322
___nl__10 = null;
//line 323
___nl__7 = compiler_NL.NL_get_mathematical_func_priv(___nl__0);

//line 323
___nl__8 = ((ImmHash)___nl__0).getHashValue()["optimization"];
//line 323
___nl__6 = post_processing_NL.NL_init(___nl__7,___nl__8);

//line 323
___nl__8 = null;
//line 323
___nl__7 = null;
//line 324
__function_map = new Dictionary<String, Imm>();
___nl__7 = new ImmHash(__function_map);
//line 325
___nl__9 = ((ImmHash)___nl__0).getHashValue()["language"];
//line 325
___nl__8 = compiler_NL.NL_get_generator_state_priv(___nl__9);

//line 325
___nl__9 = null;
//line 326
label_2:
//line 327
__function_map = new Dictionary<String, Imm>();
___nl__9 = new ImmHash(__function_map);
//line 327
___nl__10 = ___nl__9;
//line 327
((ImmHash)___nl__5).set("type_errors", ___nl__10);
//line 327
___nl__9 = null;
//line 327
___nl__10 = null;
//line 328
__function_map = new Dictionary<String, Imm>();
___nl__9 = new ImmHash(__function_map);
//line 328
___nl__10 = ___nl__9;
//line 328
((ImmHash)___nl__5).set("type_warnings", ___nl__10);
//line 328
___nl__9 = null;
//line 328
___nl__10 = null;
//line 329
___nl__9 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("ok"));
//line 329
___nl__10 = ___nl__9;
//line 329
((ImmHash)___nl__5).set("loop_error", ___nl__10);
//line 329
___nl__9 = null;
//line 329
___nl__10 = null;
//line 330
___nl__9 = compiler_NL.NL_get_files_to_parse_priv(___nl__0);

//line 331
___nl__10 = new ImmDouble(0);
//line 332
___nl__13 = c_rt_lib_NL.NL_init_iter(___nl__9);

//line 332
label_5:
//line 332
___nl__11 = c_rt_lib_NL.NL_is_end_hash(___nl__13);

//line 332
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_3;}}
//line 332
___nl__11 = c_rt_lib_NL.NL_get_key_iter(___nl__13);

//line 332
___nl__12 = c_rt_lib_NL.NL_hash_get_value(___nl__9,___nl__11);

//line 333
___nl__15 = ((ImmHash)___nl__12).getHashValue()["src"];
//line 333
___nl__14 = c_fe_lib_NL.NL_get_modif_time(___nl__15);

//line 333
___nl__15 = null;
//line 334
___nl__15 = ___nl__14;
//line 334
___nl__15 = c_rt_lib_NL.NL_ov_is(___nl__15, new ImmString("err"));
//line 334
___nl__15 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__15));
//line 334
if (c_rt_lib_NL.NL_check_true_native(___nl__15)) {if (true) {goto label_7;}}
//line 334
___nl__14 = null;
//line 334
___nl__15 = null;
//line 334
if (true) {goto label_4;}
//line 334
if (true) {goto label_7;}
//line 334
label_7:
//line 334
___nl__15 = null;
//line 335
___nl__15 = ___nl__14;
//line 335
___nl__15 = c_rt_lib_NL.NL_ov_as(___nl__15, new ImmString("ok"));
//line 335
___nl__14 = ___nl__15;
//line 335
___nl__15 = null;
//line 336
___nl__15 = hash_NL.NL_has_key(___nl__1,___nl__11);

//line 336
___nl__15 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__15));
//line 336
if (c_rt_lib_NL.NL_check_true_native(___nl__15)) {if (true) {goto label_9;}}
//line 337
___nl__16 = hash_NL.NL_get_value(___nl__1,___nl__11);

//line 338
___nl__17 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__14.getValue().ToString()))>(Double.Parse(___nl__16.getValue().ToString())) );
//line 338
___nl__17 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__17));
//line 338
___nl__17 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__17));
//line 338
if (c_rt_lib_NL.NL_check_true_native(___nl__17)) {if (true) {goto label_11;}}
//line 338
___nl__14 = null;
//line 338
___nl__15 = null;
//line 338
___nl__16 = null;
//line 338
___nl__17 = null;
//line 338
if (true) {goto label_4;}
//line 338
if (true) {goto label_11;}
//line 338
label_11:
//line 338
___nl__17 = null;
//line 338
___nl__16 = null;
//line 339
if (true) {goto label_9;}
//line 339
label_9:
//line 339
___nl__15 = null;
//line 340
___ref______nl__1 = new ImmRef(___nl__1);
hash_NL.NL_set_value(___ref______nl__1,___nl__11,___nl__14);
___nl__1 = ___ref______nl__1.getValue();

//line 341
___ref______nl__4 = new ImmRef(___nl__4);
hash_NL.NL_set_value(___ref______nl__4,___nl__11,___nl__12);
___nl__4 = ___ref______nl__4.getValue();

//line 342
___nl__15 = new ImmDouble(1);
//line 342
___nl__10 = new ImmDouble((Double.Parse(___nl__10.getValue().ToString()))+(Double.Parse(___nl__15.getValue().ToString())));
//line 342
___nl__15 = null;
//line 342
___nl__14 = null;
//line 342
label_4:
//line 343
___nl__13 = c_rt_lib_NL.NL_next_iter(___nl__13);

//line 343
if (true) {goto label_5;}
//line 343
label_3:
//line 343
___nl__11 = null;
//line 343
___nl__12 = null;
//line 343
___nl__13 = null;
//line 344
___nl__13 = c_rt_lib_NL.NL_init_iter(___nl__7);

//line 344
label_14:
//line 344
___nl__11 = c_rt_lib_NL.NL_is_end_hash(___nl__13);

//line 344
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_12;}}
//line 344
___nl__11 = c_rt_lib_NL.NL_get_key_iter(___nl__13);

//line 344
___nl__12 = c_rt_lib_NL.NL_hash_get_value(___nl__7,___nl__11);

//line 345
___nl__14 = hash_NL.NL_has_key(___nl__9,___nl__11);

//line 345
___nl__14 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__14));
//line 345
___nl__14 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__14));
//line 345
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_16;}}
//line 346
___nl__15 = new ImmDouble(1);
//line 346
___nl__10 = new ImmDouble((Double.Parse(___nl__10.getValue().ToString()))+(Double.Parse(___nl__15.getValue().ToString())));
//line 346
___nl__15 = null;
//line 347
___nl__15 = new ImmString("module_errors");
//line 347
___nl__15 = c_rt_lib_NL.NL_get_ref_hash(___nl__5,___nl__15);

//line 347
___ref______nl__15 = new ImmRef(___nl__15);
hash_NL.NL_delete(___ref______nl__15,___nl__11);
___nl__15 = ___ref______nl__15.getValue();

//line 347
___nl__16 = new ImmString("module_errors");
//line 347
___ref______nl__5 = new ImmRef(___nl__5);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__5,___nl__16,___nl__15);
___nl__5 = ___ref______nl__5.getValue();

//line 347
___nl__16 = null;
//line 347
___nl__15 = null;
//line 348
___nl__15 = new ImmString("module_warnings");
//line 348
___nl__15 = c_rt_lib_NL.NL_get_ref_hash(___nl__5,___nl__15);

//line 348
___ref______nl__15 = new ImmRef(___nl__15);
hash_NL.NL_delete(___ref______nl__15,___nl__11);
___nl__15 = ___ref______nl__15.getValue();

//line 348
___nl__16 = new ImmString("module_warnings");
//line 348
___ref______nl__5 = new ImmRef(___nl__5);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__5,___nl__16,___nl__15);
___nl__5 = ___ref______nl__5.getValue();

//line 348
___nl__16 = null;
//line 348
___nl__15 = null;
//line 349
___ref______nl__2 = new ImmRef(___nl__2);
hash_NL.NL_delete(___ref______nl__2,___nl__11);
___nl__2 = ___ref______nl__2.getValue();

//line 350
___ref______nl__1 = new ImmRef(___nl__1);
hash_NL.NL_delete(___ref______nl__1,___nl__11);
___nl__1 = ___ref______nl__1.getValue();

//line 351
___ref______nl__4 = new ImmRef(___nl__4);
hash_NL.NL_delete(___ref______nl__4,___nl__11);
___nl__4 = ___ref______nl__4.getValue();

//line 352
___ref______nl__3 = new ImmRef(___nl__3);
hash_NL.NL_delete(___ref______nl__3,___nl__11);
___nl__3 = ___ref______nl__3.getValue();

//line 353
___ref______nl__6 = new ImmRef(___nl__6);
post_processing_NL.NL_clear_module_from_state(___ref______nl__6,___nl__11);
___nl__6 = ___ref______nl__6.getValue();

//line 354
___nl__15 = ((ImmHash)___nl__0).getHashValue()["language"];
//line 354
___nl__15 = c_rt_lib_NL.NL_ov_is(___nl__15, new ImmString("c"));
//line 354
___nl__15 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__15));
//line 354
if (c_rt_lib_NL.NL_check_true_native(___nl__15)) {if (true) {goto label_18;}}
//line 355
___ref______nl__8 = new ImmRef(___nl__8);
generator_c_NL.NL_clear_module_from_state(___ref______nl__8,___nl__11);
___nl__8 = ___ref______nl__8.getValue();

//line 356
if (true) {goto label_18;}
//line 356
label_18:
//line 356
___nl__15 = null;
//line 357
if (true) {goto label_16;}
//line 357
label_16:
//line 357
___nl__14 = null;
//line 358
___nl__13 = c_rt_lib_NL.NL_next_iter(___nl__13);

//line 358
if (true) {goto label_14;}
//line 358
label_12:
//line 358
___nl__11 = null;
//line 358
___nl__12 = null;
//line 358
___nl__13 = null;
//line 359
___nl__7 = ___nl__9;
//line 360
___nl__11 = new ImmDouble(0);
//line 360
___nl__11 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__10.getValue().ToString())) ==((Double.Parse(___nl__11.getValue().ToString())))  );
//line 360
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11));
//line 360
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_20;}}
//line 361
___nl__12 = new ImmDouble(1);
//line 361
c_fe_lib_NL.NL_sleep(___nl__12);

//line 361
___nl__12 = null;
//line 362
___nl__9 = null;
//line 362
___nl__10 = null;
//line 362
___nl__11 = null;
//line 362
if (true) {goto label_2;}
//line 363
if (true) {goto label_20;}
//line 363
label_20:
//line 363
___nl__11 = null;
//line 364
__function_map = new Dictionary<String, Imm>();
___nl__11 = new ImmHash(__function_map);
//line 365
___nl__14 = c_rt_lib_NL.NL_init_iter(___nl__4);

//line 365
label_23:
//line 365
___nl__12 = c_rt_lib_NL.NL_is_end_hash(___nl__14);

//line 365
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_21;}}
//line 365
___nl__12 = c_rt_lib_NL.NL_get_key_iter(___nl__14);

//line 365
___nl__13 = c_rt_lib_NL.NL_hash_get_value(___nl__4,___nl__12);

//line 366
___nl__16 = ((ImmHash)___nl__13).getHashValue()["src"];
//line 366
___ref______nl__5 = new ImmRef(___nl__5);
___nl__15 = compiler_NL.NL_parse_module_priv(___nl__12,___nl__16,___ref______nl__5);
___nl__5 = ___ref______nl__5.getValue();

//line 366
___nl__16 = null;
//line 366
___nl__16 = c_rt_lib_NL.NL_ov_is(___nl__15, new ImmString("ok"));
//line 366
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_25;}}
//line 369
___nl__16 = c_rt_lib_NL.NL_ov_is(___nl__15, new ImmString("err"));
//line 369
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_26;}}
//line 369
___nl__16 = new ImmString("NOMATCHALERT");
//line 369
___nl__16 = new ImmArray(new Imm[] {___nl__16,___nl__15,});
//line 369
c_rt_lib_NL.NL_die();
//line 366
label_25:
//line 366
___nl__17 = c_rt_lib_NL.NL_ov_as(___nl__15, new ImmString("ok"));
//line 367
___ref______nl__2 = new ImmRef(___nl__2);
hash_NL.NL_set_value(___ref______nl__2,___nl__12,___nl__17);
___nl__2 = ___ref______nl__2.getValue();

//line 368
___ref______nl__3 = new ImmRef(___nl__3);
hash_NL.NL_set_value(___ref______nl__3,___nl__12,___nl__17);
___nl__3 = ___ref______nl__3.getValue();

//line 368
___nl__17 = null;
//line 369
if (true) {goto label_24;}
//line 369
label_26:
//line 369
___nl__17 = c_rt_lib_NL.NL_ov_as(___nl__15, new ImmString("err"));
//line 370
___ref______nl__11 = new ImmRef(___nl__11);
hash_NL.NL_set_value(___ref______nl__11,___nl__12,___nl__13);
___nl__11 = ___ref______nl__11.getValue();

//line 370
___nl__17 = null;
//line 371
if (true) {goto label_24;}
//line 371
label_24:
//line 371
___nl__15 = null;
//line 371
___nl__16 = null;
//line 372
___nl__14 = c_rt_lib_NL.NL_next_iter(___nl__14);

//line 372
if (true) {goto label_23;}
//line 372
label_21:
//line 372
___nl__12 = null;
//line 372
___nl__13 = null;
//line 372
___nl__14 = null;
//line 373
___nl__4 = ___nl__11;
//line 374
___nl__12 = hash_NL.NL_size(___nl__4);

//line 374
___nl__13 = new ImmDouble(0);
//line 374
___nl__12 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__12.getValue().ToString()))>(Double.Parse(___nl__13.getValue().ToString())) );
//line 374
___nl__13 = null;
//line 374
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12));
//line 374
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_28;}}
//line 375
compiler_NL.NL_show_and_count_errors_priv(___nl__5,___nl__0);

//line 376
___nl__13 = string_NL.NL_lf();

//line 376
___nl__14 = new ImmString("ERROR: while parsing ");
//line 376
___nl__13 = new ImmString(___nl__13.toString() + ___nl__14.toString());
//line 376
___nl__14 = null;
//line 376
___nl__14 = hash_NL.NL_size(___nl__4);

//line 376
___nl__13 = new ImmString(___nl__13.toString() + ___nl__14.toString());
//line 376
___nl__14 = null;
//line 376
___nl__14 = new ImmString(" modules");
//line 376
___nl__13 = new ImmString(___nl__13.toString() + ___nl__14.toString());
//line 376
___nl__14 = null;
//line 376
c_fe_lib_NL.NL_print(___nl__13);

//line 376
___nl__13 = null;
//line 377
___nl__13 = new ImmString("############################################################");
//line 377
c_fe_lib_NL.NL_print(___nl__13);

//line 377
___nl__13 = null;
//line 378
___nl__9 = null;
//line 378
___nl__10 = null;
//line 378
___nl__11 = null;
//line 378
___nl__12 = null;
//line 378
if (true) {goto label_2;}
//line 379
if (true) {goto label_28;}
//line 379
label_28:
//line 379
___nl__12 = null;
//line 380
___nl__12 = ((ImmHash)___nl__0).getHashValue()["deref"];
//line 380
___ref______nl__5 = new ImmRef(___nl__5);
compiler_NL.NL_check_modules_priv(___nl__2,___ref______nl__5,___nl__12);
___nl__5 = ___ref______nl__5.getValue();

//line 380
___nl__12 = null;
//line 381
___nl__12 = compiler_NL.NL_show_and_count_errors_priv(___nl__5,___nl__0);

//line 381
___nl__13 = new ImmDouble(0);
//line 381
___nl__12 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__12.getValue().ToString()))>(Double.Parse(___nl__13.getValue().ToString())) );
//line 381
___nl__13 = null;
//line 381
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12));
//line 381
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_30;}}
//line 382
___nl__13 = new ImmString("############################################################");
//line 382
c_fe_lib_NL.NL_print(___nl__13);

//line 382
___nl__13 = null;
//line 383
___nl__9 = null;
//line 383
___nl__10 = null;
//line 383
___nl__11 = null;
//line 383
___nl__12 = null;
//line 383
if (true) {goto label_2;}
//line 384
if (true) {goto label_30;}
//line 384
label_30:
//line 384
___nl__12 = null;
//line 385
___nl__12 = ((ImmHash)___nl__0).getHashValue()["language"];
//line 385
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__12, new ImmString("ast"));
//line 385
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_33;}}
//line 385
___nl__12 = ((ImmHash)___nl__0).getHashValue()["language"];
//line 385
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__12, new ImmString("nl"));
//line 385
label_33:
//line 385
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12));
//line 385
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12));
//line 385
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_32;}}
//line 386
___nl__13 = new ImmString("search constants...");
//line 386
c_fe_lib_NL.NL_print(___nl__13);

//line 386
___nl__13 = null;
//line 387
__function_map = new Dictionary<String, Imm>();
___nl__13 = new ImmHash(__function_map);
//line 388
___ref______nl__6 = new ImmRef(___nl__6);
___nl__14 = compiler_NL.NL_translate_priv(___nl__3,___ref______nl__6);
___nl__6 = ___ref______nl__6.getValue();

//line 389
___nl__16 = ((ImmHash)___nl__0).getHashValue()["cache_path"];
//line 389
___nl__17 = ((ImmHash)___nl__0).getHashValue()["language"];
//line 389
___ref______nl__8 = new ImmRef(___nl__8);
___nl__15 = compiler_NL.NL_generate_modules_to_files_priv(___nl__14,___nl__9,___nl__16,___ref______nl__8,___nl__17);
___nl__8 = ___ref______nl__8.getValue();

//line 389
___nl__17 = null;
//line 389
___nl__16 = null;
//line 389
___nl__16 = c_rt_lib_NL.NL_ov_is(___nl__15, new ImmString("err"));
//line 389
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_35;}}
//line 393
___nl__16 = c_rt_lib_NL.NL_ov_is(___nl__15, new ImmString("ok"));
//line 393
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_36;}}
//line 393
___nl__16 = new ImmString("NOMATCHALERT");
//line 393
___nl__16 = new ImmArray(new Imm[] {___nl__16,___nl__15,});
//line 393
c_rt_lib_NL.NL_die();
//line 389
label_35:
//line 389
___nl__17 = c_rt_lib_NL.NL_ov_as(___nl__15, new ImmString("err"));
//line 390
___nl__20 = c_rt_lib_NL.NL_init_iter(___nl__17);

//line 390
label_39:
//line 390
___nl__18 = c_rt_lib_NL.NL_is_end_hash(___nl__20);

//line 390
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_37;}}
//line 390
___nl__18 = c_rt_lib_NL.NL_get_key_iter(___nl__20);

//line 390
___nl__19 = c_rt_lib_NL.NL_hash_get_value(___nl__17,___nl__18);

//line 391
___nl__21 = hash_NL.NL_get_value(___nl__2,___nl__18);

//line 391
___ref______nl__13 = new ImmRef(___nl__13);
hash_NL.NL_set_value(___ref______nl__13,___nl__18,___nl__21);
___nl__13 = ___ref______nl__13.getValue();

//line 391
___nl__21 = null;
//line 392
___nl__20 = c_rt_lib_NL.NL_next_iter(___nl__20);

//line 392
if (true) {goto label_39;}
//line 392
label_37:
//line 392
___nl__18 = null;
//line 392
___nl__19 = null;
//line 392
___nl__20 = null;
//line 392
___nl__17 = null;
//line 393
if (true) {goto label_34;}
//line 393
label_36:
//line 393
___nl__17 = c_rt_lib_NL.NL_ov_as(___nl__15, new ImmString("ok"));
//line 393
___nl__17 = null;
//line 394
if (true) {goto label_34;}
//line 394
label_34:
//line 394
___nl__15 = null;
//line 394
___nl__16 = null;
//line 395
___nl__3 = ___nl__13;
//line 395
___nl__13 = null;
//line 395
___nl__14 = null;
//line 396
if (true) {goto label_31;}
//line 396
label_32:
//line 397
__function_map = new Dictionary<String, Imm>();
___nl__13 = new ImmHash(__function_map);
//line 398
___nl__16 = c_rt_lib_NL.NL_init_iter(___nl__3);

//line 398
label_42:
//line 398
___nl__14 = c_rt_lib_NL.NL_is_end_hash(___nl__16);

//line 398
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_40;}}
//line 398
___nl__14 = c_rt_lib_NL.NL_get_key_iter(___nl__16);

//line 398
___nl__15 = c_rt_lib_NL.NL_hash_get_value(___nl__3,___nl__14);

//line 399
___nl__17 = new ImmString("saving file: ");
//line 399
___nl__17 = new ImmString(___nl__17.toString() + ___nl__14.toString());
//line 399
c_fe_lib_NL.NL_print(___nl__17);

//line 399
___nl__17 = null;
//line 400
___nl__18 = hash_NL.NL_get_value(___nl__9,___nl__14);

//line 400
___nl__18 = ((ImmHash)___nl__18).getHashValue()["dst"];
//line 400
___nl__17 = compiler_NL.NL_save_module_to_file_priv(___nl__15,___nl__18);

//line 400
___nl__18 = null;
//line 400
___nl__18 = c_rt_lib_NL.NL_ov_is(___nl__17, new ImmString("err"));
//line 400
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_44;}}
//line 403
___nl__18 = c_rt_lib_NL.NL_ov_is(___nl__17, new ImmString("ok"));
//line 403
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_45;}}
//line 403
___nl__18 = new ImmString("NOMATCHALERT");
//line 403
___nl__18 = new ImmArray(new Imm[] {___nl__18,___nl__17,});
//line 403
c_rt_lib_NL.NL_die();
//line 400
label_44:
//line 400
___nl__19 = c_rt_lib_NL.NL_ov_as(___nl__17, new ImmString("err"));
//line 401
___nl__20 = new ImmString("ERROR: ");
//line 401
___nl__20 = new ImmString(___nl__20.toString() + ___nl__19.toString());
//line 401
c_fe_lib_NL.NL_print(___nl__20);

//line 401
___nl__20 = null;
//line 402
___ref______nl__13 = new ImmRef(___nl__13);
hash_NL.NL_set_value(___ref______nl__13,___nl__14,___nl__15);
___nl__13 = ___ref______nl__13.getValue();

//line 402
___nl__19 = null;
//line 403
if (true) {goto label_43;}
//line 403
label_45:
//line 403
___nl__19 = c_rt_lib_NL.NL_ov_as(___nl__17, new ImmString("ok"));
//line 403
___nl__19 = null;
//line 404
if (true) {goto label_43;}
//line 404
label_43:
//line 404
___nl__17 = null;
//line 404
___nl__18 = null;
//line 405
___nl__16 = c_rt_lib_NL.NL_next_iter(___nl__16);

//line 405
if (true) {goto label_42;}
//line 405
label_40:
//line 405
___nl__14 = null;
//line 405
___nl__15 = null;
//line 405
___nl__16 = null;
//line 406
___nl__3 = ___nl__13;
//line 406
___nl__13 = null;
//line 407
if (true) {goto label_31;}
//line 407
label_31:
//line 407
___nl__12 = null;
//line 408
___nl__12 = hash_NL.NL_size(___nl__3);

//line 408
___nl__13 = new ImmDouble(0);
//line 408
___nl__12 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__12.getValue().ToString()))>(Double.Parse(___nl__13.getValue().ToString())) );
//line 408
___nl__13 = null;
//line 408
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12));
//line 408
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_47;}}
//line 409
___nl__13 = new ImmString("Can not save ");
//line 409
___nl__14 = hash_NL.NL_size(___nl__3);

//line 409
___nl__13 = new ImmString(___nl__13.toString() + ___nl__14.toString());
//line 409
___nl__14 = null;
//line 409
___nl__14 = new ImmString(" files. ");
//line 409
___nl__13 = new ImmString(___nl__13.toString() + ___nl__14.toString());
//line 409
___nl__14 = null;
//line 410
___nl__14 = string_NL.NL_lf();

//line 410
___nl__15 = new ImmString("ERROR: ");
//line 410
___nl__14 = new ImmString(___nl__14.toString() + ___nl__15.toString());
//line 410
___nl__15 = null;
//line 410
___nl__14 = new ImmString(___nl__14.toString() + ___nl__13.toString());
//line 410
c_fe_lib_NL.NL_print(___nl__14);

//line 410
___nl__14 = null;
//line 410
___nl__13 = null;
//line 411
if (true) {goto label_46;}
//line 411
label_47:
//line 412
___nl__13 = ((ImmHash)___nl__0).getHashValue()["mode"];
//line 412
___nl__13 = c_rt_lib_NL.NL_ov_is(___nl__13, new ImmString("idex"));
//line 412
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13));
//line 412
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_49;}}
//line 412
___nl__14 = ((ImmHash)___nl__0).getHashValue()["mode"];
//line 412
___nl__14 = c_rt_lib_NL.NL_ov_as(___nl__14, new ImmString("idex"));
//line 412
c_fe_lib_NL.NL_exec_cmd(___nl__14);

//line 412
___nl__14 = null;
//line 412
if (true) {goto label_49;}
//line 412
label_49:
//line 412
___nl__13 = null;
//line 413
___nl__13 = string_NL.NL_lf();

//line 413
___nl__14 = new ImmString("OK: compile, check types and save changes without errors");
//line 413
___nl__13 = new ImmString(___nl__13.toString() + ___nl__14.toString());
//line 413
___nl__14 = null;
//line 413
c_fe_lib_NL.NL_print(___nl__13);

//line 413
___nl__13 = null;
//line 414
if (true) {goto label_46;}
//line 414
label_46:
//line 414
___nl__12 = null;
//line 415
___nl__12 = new ImmString("############################################################");
//line 415
c_fe_lib_NL.NL_print(___nl__12);

//line 415
___nl__12 = null;
//line 415
___nl__9 = null;
//line 415
___nl__10 = null;
//line 415
___nl__11 = null;
//line 326
if (true) {goto label_2;}
//line 326
___nl__1 = null;
//line 326
___nl__2 = null;
//line 326
___nl__3 = null;
//line 326
___nl__4 = null;
//line 326
___nl__5 = null;
//line 326
___nl__6 = null;
//line 326
___nl__7 = null;
//line 326
___nl__8 = null;
//line 326
___nl__0 = null;
//line 326
if(true) return null;
}

private static Imm NL_compile_strict_file_priv(Imm ___arg__0) {
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
//line 419
__function_map = new Dictionary<String, Imm>();
___nl__1 = new ImmHash(__function_map);
//line 420
__function_map = new Dictionary<String, Imm>();
___nl__3 = new ImmHash(__function_map);
//line 420
__function_map = new Dictionary<String, Imm>();
___nl__4 = new ImmHash(__function_map);
//line 420
__function_map = new Dictionary<String, Imm>();
___nl__5 = new ImmHash(__function_map);
//line 420
__function_map = new Dictionary<String, Imm>();
___nl__6 = new ImmHash(__function_map);
//line 420
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("ok"));
//line 420
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module_errors",___nl__3);
__function_map.Add("module_warnings",___nl__4);
__function_map.Add("type_errors",___nl__5);
__function_map.Add("type_warnings",___nl__6);
__function_map.Add("loop_error",___nl__7);
___nl__2 = new ImmHash(__function_map);
//line 420
___nl__3 = null;
//line 420
___nl__4 = null;
//line 420
___nl__5 = null;
//line 420
___nl__6 = null;
//line 420
___nl__7 = null;
//line 421
___nl__3 = new ImmDouble(0);
//line 422
___nl__4 = compiler_NL.NL_get_files_to_parse_priv(___nl__0);

//line 423
___nl__7 = c_rt_lib_NL.NL_init_iter(___nl__4);

//line 423
label_3:
//line 423
___nl__5 = c_rt_lib_NL.NL_is_end_hash(___nl__7);

//line 423
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_1;}}
//line 423
___nl__5 = c_rt_lib_NL.NL_get_key_iter(___nl__7);

//line 423
___nl__6 = c_rt_lib_NL.NL_hash_get_value(___nl__4,___nl__5);

//line 424
___nl__9 = ((ImmHash)___nl__6).getHashValue()["src"];
//line 424
___ref______nl__2 = new ImmRef(___nl__2);
___nl__8 = compiler_NL.NL_parse_module_priv(___nl__5,___nl__9,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue();

//line 424
___nl__9 = null;
//line 424
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("ok"));
//line 424
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_5;}}
//line 426
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("err"));
//line 426
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_6;}}
//line 426
___nl__9 = new ImmString("NOMATCHALERT");
//line 426
___nl__9 = new ImmArray(new Imm[] {___nl__9,___nl__8,});
//line 426
c_rt_lib_NL.NL_die();
//line 424
label_5:
//line 424
___nl__10 = c_rt_lib_NL.NL_ov_as(___nl__8, new ImmString("ok"));
//line 425
___ref______nl__1 = new ImmRef(___nl__1);
hash_NL.NL_set_value(___ref______nl__1,___nl__5,___nl__10);
___nl__1 = ___ref______nl__1.getValue();

//line 425
___nl__10 = null;
//line 426
if (true) {goto label_4;}
//line 426
label_6:
//line 426
___nl__10 = c_rt_lib_NL.NL_ov_as(___nl__8, new ImmString("err"));
//line 427
___nl__11 = new ImmDouble(1);
//line 427
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__11.getValue().ToString())));
//line 427
___nl__11 = null;
//line 427
___nl__10 = null;
//line 428
if (true) {goto label_4;}
//line 428
label_4:
//line 428
___nl__8 = null;
//line 428
___nl__9 = null;
//line 429
___nl__7 = c_rt_lib_NL.NL_next_iter(___nl__7);

//line 429
if (true) {goto label_3;}
//line 429
label_1:
//line 429
___nl__5 = null;
//line 429
___nl__6 = null;
//line 429
___nl__7 = null;
//line 430
___nl__5 = new ImmDouble(0);
//line 430
___nl__5 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString())) !=((Double.Parse(___nl__5.getValue().ToString())))  );
//line 430
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 430
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_8;}}
//line 431
compiler_NL.NL_show_and_count_errors_priv(___nl__2,___nl__0);

//line 432
___nl__0 = null;
//line 432
___nl__1 = null;
//line 432
___nl__2 = null;
//line 432
___nl__3 = null;
//line 432
___nl__4 = null;
//line 432
___nl__5 = null;
//line 432
if(true) return null;
//line 433
if (true) {goto label_8;}
//line 433
label_8:
//line 433
___nl__5 = null;
//line 434
___nl__5 = ((ImmHash)___nl__0).getHashValue()["deref"];
//line 434
___ref______nl__2 = new ImmRef(___nl__2);
compiler_NL.NL_check_modules_priv(___nl__1,___ref______nl__2,___nl__5);
___nl__2 = ___ref______nl__2.getValue();

//line 434
___nl__5 = null;
//line 435
___nl__5 = compiler_NL.NL_show_and_count_errors_priv(___nl__2,___nl__0);

//line 435
___nl__6 = new ImmDouble(0);
//line 435
___nl__5 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>(Double.Parse(___nl__6.getValue().ToString())) );
//line 435
___nl__6 = null;
//line 435
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 435
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_10;}}
//line 436
___nl__0 = null;
//line 436
___nl__1 = null;
//line 436
___nl__2 = null;
//line 436
___nl__3 = null;
//line 436
___nl__4 = null;
//line 436
___nl__5 = null;
//line 436
if(true) return null;
//line 437
if (true) {goto label_10;}
//line 437
label_10:
//line 437
___nl__5 = null;
//line 439
___nl__5 = ((ImmHash)___nl__0).getHashValue()["language"];
//line 439
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("ast"));
//line 439
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_13;}}
//line 439
___nl__5 = ((ImmHash)___nl__0).getHashValue()["language"];
//line 439
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("nl"));
//line 439
label_13:
//line 439
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 439
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 439
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_12;}}
//line 440
___nl__7 = ((ImmHash)___nl__0).getHashValue()["language"];
//line 440
___nl__6 = compiler_NL.NL_get_generator_state_priv(___nl__7);

//line 440
___nl__7 = null;
//line 441
___nl__7 = new ImmString("search constants...");
//line 441
c_fe_lib_NL.NL_print(___nl__7);

//line 441
___nl__7 = null;
//line 442
___nl__8 = compiler_NL.NL_get_mathematical_func_priv(___nl__0);

//line 442
___nl__9 = ((ImmHash)___nl__0).getHashValue()["optimization"];
//line 442
___nl__7 = post_processing_NL.NL_init(___nl__8,___nl__9);

//line 442
___nl__9 = null;
//line 442
___nl__8 = null;
//line 443
___ref______nl__7 = new ImmRef(___nl__7);
___nl__8 = compiler_NL.NL_translate_priv(___nl__1,___ref______nl__7);
___nl__7 = ___ref______nl__7.getValue();

//line 444
___nl__9 = ((ImmHash)___nl__0).getHashValue()["cache_path"];
//line 444
___nl__10 = ((ImmHash)___nl__0).getHashValue()["language"];
//line 444
___ref______nl__6 = new ImmRef(___nl__6);
compiler_NL.NL_generate_modules_to_files_priv(___nl__8,___nl__4,___nl__9,___ref______nl__6,___nl__10);
___nl__6 = ___ref______nl__6.getValue();

//line 444
___nl__10 = null;
//line 444
___nl__9 = null;
//line 444
___nl__6 = null;
//line 444
___nl__7 = null;
//line 444
___nl__8 = null;
//line 445
if (true) {goto label_11;}
//line 445
label_12:
//line 446
___nl__8 = c_rt_lib_NL.NL_init_iter(___nl__1);

//line 446
label_16:
//line 446
___nl__6 = c_rt_lib_NL.NL_is_end_hash(___nl__8);

//line 446
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_14;}}
//line 446
___nl__6 = c_rt_lib_NL.NL_get_key_iter(___nl__8);

//line 446
___nl__7 = c_rt_lib_NL.NL_hash_get_value(___nl__1,___nl__6);

//line 447
___nl__9 = new ImmString("saving file: ");
//line 447
___nl__9 = new ImmString(___nl__9.toString() + ___nl__6.toString());
//line 447
c_fe_lib_NL.NL_print(___nl__9);

//line 447
___nl__9 = null;
//line 448
___nl__10 = hash_NL.NL_get_value(___nl__4,___nl__6);

//line 448
___nl__10 = ((ImmHash)___nl__10).getHashValue()["dst"];
//line 448
___nl__9 = compiler_NL.NL_save_module_to_file_priv(___nl__7,___nl__10);

//line 448
___nl__10 = null;
//line 448
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__9, new ImmString("err"));
//line 448
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_18;}}
//line 450
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__9, new ImmString("ok"));
//line 450
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_19;}}
//line 450
___nl__10 = new ImmString("NOMATCHALERT");
//line 450
___nl__10 = new ImmArray(new Imm[] {___nl__10,___nl__9,});
//line 450
c_rt_lib_NL.NL_die();
//line 448
label_18:
//line 448
___nl__11 = c_rt_lib_NL.NL_ov_as(___nl__9, new ImmString("err"));
//line 449
___nl__12 = new ImmString("ERROR: ");
//line 449
___nl__12 = new ImmString(___nl__12.toString() + ___nl__11.toString());
//line 449
c_fe_lib_NL.NL_print(___nl__12);

//line 449
___nl__12 = null;
//line 449
___nl__11 = null;
//line 450
if (true) {goto label_17;}
//line 450
label_19:
//line 450
___nl__11 = c_rt_lib_NL.NL_ov_as(___nl__9, new ImmString("ok"));
//line 450
___nl__11 = null;
//line 451
if (true) {goto label_17;}
//line 451
label_17:
//line 451
___nl__9 = null;
//line 451
___nl__10 = null;
//line 452
___nl__8 = c_rt_lib_NL.NL_next_iter(___nl__8);

//line 452
if (true) {goto label_16;}
//line 452
label_14:
//line 452
___nl__6 = null;
//line 452
___nl__7 = null;
//line 452
___nl__8 = null;
//line 453
if (true) {goto label_11;}
//line 453
label_11:
//line 453
___nl__5 = null;
//line 453
___nl__1 = null;
//line 453
___nl__2 = null;
//line 453
___nl__3 = null;
//line 453
___nl__4 = null;
//line 453
___nl__0 = null;
//line 453
if(true) return null;
}

private static Imm NL_construct_error_message_priv(Imm ___arg__0) {
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
//line 456
___nl__1 = new ImmString("");
//line 457
___nl__3 = ((ImmHash)___nl__0).getHashValue()["module"];
//line 457
___nl__2 = string_NL.NL_length(___nl__3);

//line 457
___nl__3 = null;
//line 457
___nl__3 = new ImmDouble(0);
//line 457
___nl__2 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__2.getValue().ToString())) ==((Double.Parse(___nl__3.getValue().ToString())))  );
//line 457
___nl__3 = null;
//line 457
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 457
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 457
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 457
___nl__3 = new ImmString(" mod: ");
//line 457
___nl__4 = ((ImmHash)___nl__0).getHashValue()["module"];
//line 457
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 457
___nl__4 = null;
//line 457
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString());
//line 457
___nl__3 = null;
//line 457
if (true) {goto label_2;}
//line 457
label_2:
//line 457
___nl__2 = null;
//line 458
___nl__3 = ((ImmHash)___nl__0).getHashValue()["line"];
//line 458
___nl__2 = string_NL.NL_length(___nl__3);

//line 458
___nl__3 = null;
//line 458
___nl__3 = new ImmDouble(0);
//line 458
___nl__2 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__2.getValue().ToString())) ==((Double.Parse(___nl__3.getValue().ToString())))  );
//line 458
___nl__3 = null;
//line 458
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 458
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 458
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_4;}}
//line 458
___nl__3 = new ImmString(" line: ");
//line 458
___nl__4 = ((ImmHash)___nl__0).getHashValue()["line"];
//line 458
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 458
___nl__4 = null;
//line 458
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString());
//line 458
___nl__3 = null;
//line 458
if (true) {goto label_4;}
//line 458
label_4:
//line 458
___nl__2 = null;
//line 459
___nl__2 = string_NL.NL_lf();

//line 459
___nl__3 = new ImmString("     ");
//line 459
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 459
___nl__3 = null;
//line 459
___nl__3 = ((ImmHash)___nl__0).getHashValue()["msg"];
//line 459
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 459
___nl__3 = null;
//line 459
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 459
___nl__2 = null;
//line 460
___nl__0 = null;
//line 460
if(true) return ___nl__1;
//line 460
___nl__1 = null;
//line 460
___nl__0 = null;
//line 460
if(true) return null;
}

private static Imm NL_show_and_count_errors_priv(Imm ___arg__0, Imm ___arg__1) {
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
//line 463
___nl__2 = new ImmDouble(0);
//line 464
___nl__3 = new ImmDouble(0);
//line 465
___nl__4 = ((ImmHash)___nl__0).getHashValue()["module_warnings"];
//line 465
___nl__7 = c_rt_lib_NL.NL_init_iter(___nl__4);

//line 465
label_3:
//line 465
___nl__5 = c_rt_lib_NL.NL_is_end_hash(___nl__7);

//line 465
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_1;}}
//line 465
___nl__5 = c_rt_lib_NL.NL_get_key_iter(___nl__7);

//line 465
___nl__6 = c_rt_lib_NL.NL_hash_get_value(___nl__4,___nl__5);

//line 466
___nl__8 = new ImmString("WAR");
//line 467
___nl__9 = ((ImmHash)___nl__1).getHashValue()["alarm"];
//line 467
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__9, new ImmString("wall"));
//line 467
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9));
//line 467
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_5;}}
//line 467
___nl__10 = new ImmString("ERR");
//line 467
___nl__8 = ___nl__10;
//line 467
___nl__10 = null;
//line 467
if (true) {goto label_5;}
//line 467
label_5:
//line 467
___nl__9 = null;
//line 468
___nl__10 = new ImmDouble(0);
//line 468
___nl__11 = new ImmDouble(1);
//line 468
___nl__12 = c_rt_lib_NL.NL_array_len(___nl__6);

//line 468
label_8:
//line 468
___nl__13 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__10.getValue().ToString()))>=(Double.Parse(___nl__12.getValue().ToString())) );
//line 468
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_6;}}
//line 468
___nl__9 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()];
//line 469
___nl__14 = compiler_NL.NL_construct_error_message_priv(___nl__9);

//line 469
___nl__14 = new ImmString(___nl__8.toString() + ___nl__14.toString());
//line 469
c_fe_lib_NL.NL_print(___nl__14);

//line 469
___nl__14 = null;
//line 470
___nl__10 = new ImmDouble((Double.Parse(___nl__10.getValue().ToString()))+(Double.Parse(___nl__11.getValue().ToString())));
//line 470
if (true) {goto label_8;}
//line 470
label_6:
//line 470
___nl__9 = null;
//line 470
___nl__10 = null;
//line 470
___nl__11 = null;
//line 470
___nl__12 = null;
//line 470
___nl__13 = null;
//line 471
___nl__9 = array_NL.NL_len(___nl__6);

//line 471
___nl__2 = new ImmDouble((Double.Parse(___nl__2.getValue().ToString()))+(Double.Parse(___nl__9.getValue().ToString())));
//line 471
___nl__9 = null;
//line 472
___nl__10 = ((ImmHash)___nl__0).getHashValue()["type_warnings"];
//line 472
___nl__9 = hash_NL.NL_has_key(___nl__10,___nl__5);

//line 472
___nl__10 = null;
//line 472
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9));
//line 472
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_10;}}
//line 473
___nl__11 = ((ImmHash)___nl__0).getHashValue()["type_warnings"];
//line 473
___nl__10 = hash_NL.NL_get_value(___nl__11,___nl__5);

//line 473
___nl__11 = null;
//line 474
___nl__12 = new ImmDouble(0);
//line 474
___nl__13 = new ImmDouble(1);
//line 474
___nl__14 = c_rt_lib_NL.NL_array_len(___nl__10);

//line 474
label_13:
//line 474
___nl__15 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__12.getValue().ToString()))>=(Double.Parse(___nl__14.getValue().ToString())) );
//line 474
if (c_rt_lib_NL.NL_check_true_native(___nl__15)) {if (true) {goto label_11;}}
//line 474
___nl__11 = (___nl__10 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__12).getDoubleValue()];
//line 475
___nl__16 = compiler_NL.NL_construct_error_message_priv(___nl__11);

//line 475
___nl__16 = new ImmString(___nl__8.toString() + ___nl__16.toString());
//line 475
c_fe_lib_NL.NL_print(___nl__16);

//line 475
___nl__16 = null;
//line 476
___nl__12 = new ImmDouble((Double.Parse(___nl__12.getValue().ToString()))+(Double.Parse(___nl__13.getValue().ToString())));
//line 476
if (true) {goto label_13;}
//line 476
label_11:
//line 476
___nl__11 = null;
//line 476
___nl__12 = null;
//line 476
___nl__13 = null;
//line 476
___nl__14 = null;
//line 476
___nl__15 = null;
//line 477
___nl__11 = array_NL.NL_len(___nl__10);

//line 477
___nl__2 = new ImmDouble((Double.Parse(___nl__2.getValue().ToString()))+(Double.Parse(___nl__11.getValue().ToString())));
//line 477
___nl__11 = null;
//line 477
___nl__10 = null;
//line 478
if (true) {goto label_10;}
//line 478
label_10:
//line 478
___nl__9 = null;
//line 479
___nl__9 = new ImmString("ERR");
//line 479
___nl__8 = ___nl__9;
//line 479
___nl__9 = null;
//line 480
___nl__10 = ((ImmHash)___nl__0).getHashValue()["module_errors"];
//line 480
___nl__9 = hash_NL.NL_get_value(___nl__10,___nl__5);

//line 480
___nl__10 = null;
//line 481
___nl__11 = new ImmDouble(0);
//line 481
___nl__12 = new ImmDouble(1);
//line 481
___nl__13 = c_rt_lib_NL.NL_array_len(___nl__9);

//line 481
label_16:
//line 481
___nl__14 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__11.getValue().ToString()))>=(Double.Parse(___nl__13.getValue().ToString())) );
//line 481
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_14;}}
//line 481
___nl__10 = (___nl__9 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__11).getDoubleValue()];
//line 482
___nl__15 = new ImmString("ERR");
//line 482
___nl__16 = compiler_NL.NL_construct_error_message_priv(___nl__10);

//line 482
___nl__15 = new ImmString(___nl__15.toString() + ___nl__16.toString());
//line 482
___nl__16 = null;
//line 482
c_fe_lib_NL.NL_print(___nl__15);

//line 482
___nl__15 = null;
//line 483
___nl__11 = new ImmDouble((Double.Parse(___nl__11.getValue().ToString()))+(Double.Parse(___nl__12.getValue().ToString())));
//line 483
if (true) {goto label_16;}
//line 483
label_14:
//line 483
___nl__10 = null;
//line 483
___nl__11 = null;
//line 483
___nl__12 = null;
//line 483
___nl__13 = null;
//line 483
___nl__14 = null;
//line 484
___nl__10 = array_NL.NL_len(___nl__9);

//line 484
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__10.getValue().ToString())));
//line 484
___nl__10 = null;
//line 485
___nl__11 = ((ImmHash)___nl__0).getHashValue()["type_errors"];
//line 485
___nl__10 = hash_NL.NL_has_key(___nl__11,___nl__5);

//line 485
___nl__11 = null;
//line 485
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10));
//line 485
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_18;}}
//line 486
___nl__12 = ((ImmHash)___nl__0).getHashValue()["type_errors"];
//line 486
___nl__11 = hash_NL.NL_get_value(___nl__12,___nl__5);

//line 486
___nl__12 = null;
//line 487
___nl__13 = new ImmDouble(0);
//line 487
___nl__14 = new ImmDouble(1);
//line 487
___nl__15 = c_rt_lib_NL.NL_array_len(___nl__11);

//line 487
label_21:
//line 487
___nl__16 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__13.getValue().ToString()))>=(Double.Parse(___nl__15.getValue().ToString())) );
//line 487
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_19;}}
//line 487
___nl__12 = (___nl__11 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__13).getDoubleValue()];
//line 488
___nl__17 = new ImmString("ERR");
//line 488
___nl__18 = compiler_NL.NL_construct_error_message_priv(___nl__12);

//line 488
___nl__17 = new ImmString(___nl__17.toString() + ___nl__18.toString());
//line 488
___nl__18 = null;
//line 488
c_fe_lib_NL.NL_print(___nl__17);

//line 488
___nl__17 = null;
//line 489
___nl__13 = new ImmDouble((Double.Parse(___nl__13.getValue().ToString()))+(Double.Parse(___nl__14.getValue().ToString())));
//line 489
if (true) {goto label_21;}
//line 489
label_19:
//line 489
___nl__12 = null;
//line 489
___nl__13 = null;
//line 489
___nl__14 = null;
//line 489
___nl__15 = null;
//line 489
___nl__16 = null;
//line 490
___nl__12 = array_NL.NL_len(___nl__11);

//line 490
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__12.getValue().ToString())));
//line 490
___nl__12 = null;
//line 490
___nl__11 = null;
//line 491
if (true) {goto label_18;}
//line 491
label_18:
//line 491
___nl__10 = null;
//line 491
___nl__8 = null;
//line 491
___nl__9 = null;
//line 492
___nl__7 = c_rt_lib_NL.NL_next_iter(___nl__7);

//line 492
if (true) {goto label_3;}
//line 492
label_1:
//line 492
___nl__4 = null;
//line 492
___nl__5 = null;
//line 492
___nl__6 = null;
//line 492
___nl__7 = null;
//line 493
___nl__4 = ((ImmHash)___nl__0).getHashValue()["loop_error"];
//line 493
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("loop"));
//line 493
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_23;}}
//line 500
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("ok"));
//line 500
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_24;}}
//line 500
___nl__5 = new ImmString("NOMATCHALERT");
//line 500
___nl__5 = new ImmArray(new Imm[] {___nl__5,___nl__4,});
//line 500
c_rt_lib_NL.NL_die();
//line 493
label_23:
//line 493
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("loop"));
//line 494
___nl__7 = new ImmString("");
//line 495
___nl__9 = new ImmDouble(0);
//line 495
___nl__10 = new ImmDouble(1);
//line 495
___nl__11 = c_rt_lib_NL.NL_array_len(___nl__6);

//line 495
label_27:
//line 495
___nl__12 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__9.getValue().ToString()))>=(Double.Parse(___nl__11.getValue().ToString())) );
//line 495
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_25;}}
//line 495
___nl__8 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()];
//line 496
___nl__13 = new ImmString(" -> ");
//line 496
___nl__13 = new ImmString(___nl__8.toString() + ___nl__13.toString());
//line 496
___nl__7 = new ImmString(___nl__7.toString() + ___nl__13.toString());
//line 496
___nl__13 = null;
//line 497
___nl__9 = new ImmDouble((Double.Parse(___nl__9.getValue().ToString()))+(Double.Parse(___nl__10.getValue().ToString())));
//line 497
if (true) {goto label_27;}
//line 497
label_25:
//line 497
___nl__8 = null;
//line 497
___nl__9 = null;
//line 497
___nl__10 = null;
//line 497
___nl__11 = null;
//line 497
___nl__12 = null;
//line 498
___nl__8 = new ImmString("ERR Loop found in module imports: ");
//line 498
___nl__8 = new ImmString(___nl__8.toString() + ___nl__7.toString());
//line 498
___nl__9 = new ImmString(". ");
//line 498
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 498
___nl__9 = null;
//line 498
c_fe_lib_NL.NL_print(___nl__8);

//line 498
___nl__8 = null;
//line 499
___nl__8 = new ImmDouble(1);
//line 499
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString())));
//line 499
___nl__8 = null;
//line 499
___nl__7 = null;
//line 499
___nl__6 = null;
//line 500
if (true) {goto label_22;}
//line 500
label_24:
//line 501
if (true) {goto label_22;}
//line 501
label_22:
//line 501
___nl__4 = null;
//line 501
___nl__5 = null;
//line 503
___nl__4 = ((ImmHash)___nl__1).getHashValue()["alarm"];
//line 503
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("wall"));
//line 503
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 503
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_29;}}
//line 504
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__2.getValue().ToString())));
//line 505
___nl__5 = new ImmDouble(0);
//line 505
___nl__2 = ___nl__5;
//line 505
___nl__5 = null;
//line 506
if (true) {goto label_29;}
//line 506
label_29:
//line 506
___nl__4 = null;
//line 507
___nl__4 = new ImmString("ERR: ");
//line 507
___nl__4 = new ImmString(___nl__4.toString() + ___nl__3.toString());
//line 507
___nl__5 = new ImmString(" WAR: ");
//line 507
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 507
___nl__5 = null;
//line 507
___nl__4 = new ImmString(___nl__4.toString() + ___nl__2.toString());
//line 507
c_fe_lib_NL.NL_print(___nl__4);

//line 507
___nl__4 = null;
//line 508
___nl__0 = null;
//line 508
___nl__1 = null;
//line 508
___nl__2 = null;
//line 508
if(true) return ___nl__3;
//line 508
___nl__2 = null;
//line 508
___nl__3 = null;
//line 508
___nl__0 = null;
//line 508
___nl__1 = null;
//line 508
if(true) return null;
}

private static Imm NL_translate_priv(Imm ___arg__0, ImmRef ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();
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
//line 511
__function_map = new Dictionary<String, Imm>();
___nl__2 = new ImmHash(__function_map);
//line 512
___nl__5 = c_rt_lib_NL.NL_init_iter(___nl__0);

//line 512
label_3:
//line 512
___nl__3 = c_rt_lib_NL.NL_is_end_hash(___nl__5);

//line 512
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_1;}}
//line 512
___nl__3 = c_rt_lib_NL.NL_get_key_iter(___nl__5);

//line 512
___nl__4 = c_rt_lib_NL.NL_hash_get_value(___nl__0,___nl__3);

//line 513
___nl__6 = translator_NL.NL_translate(___nl__4);

//line 514
___ref______nl__2 = new ImmRef(___nl__2);
hash_NL.NL_set_value(___ref______nl__2,___nl__3,___nl__6);
___nl__2 = ___ref______nl__2.getValue();

//line 514
___nl__6 = null;
//line 515
___nl__5 = c_rt_lib_NL.NL_next_iter(___nl__5);

//line 515
if (true) {goto label_3;}
//line 515
label_1:
//line 515
___nl__3 = null;
//line 515
___nl__4 = null;
//line 515
___nl__5 = null;
//line 516
___ref______nl__1 = new ImmRef(___nl__1);
___ref______nl__2 = new ImmRef(___nl__2);
post_processing_NL.NL_find(___ref______nl__1,___ref______nl__2);
___nl__1 = ___ref______nl__1.getValue();
___nl__2 = ___ref______nl__2.getValue();

//line 517
___nl__0 = null;
//line 517
___arg__1.setValue(___nl__1);if(true) return ___nl__2;
//line 517
___nl__2 = null;
//line 517
___nl__0 = null;
//line 517
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_check_modules_priv(Imm ___arg__0, ImmRef ___arg__1, Imm ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();Imm ___nl__2 = ___arg__2.clone();
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
//line 520
___nl__3 = new ImmString("type checking...");
//line 520
c_fe_lib_NL.NL_print(___nl__3);

//line 520
___nl__3 = null;
//line 521
___nl__3 = type_checker_NL.NL_check_modules(___nl__0,___nl__0);

//line 522
___nl__5 = ((ImmHash)___nl__3).getHashValue()["errors"];
//line 522
___nl__4 = array_NL.NL_len(___nl__5);

//line 522
___nl__5 = null;
//line 523
___nl__5 = ((ImmHash)___nl__3).getHashValue()["errors"];
//line 523
___nl__7 = new ImmDouble(0);
//line 523
___nl__8 = new ImmDouble(1);
//line 523
___nl__9 = c_rt_lib_NL.NL_array_len(___nl__5);

//line 523
label_3:
//line 523
___nl__10 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))>=(Double.Parse(___nl__9.getValue().ToString())) );
//line 523
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_1;}}
//line 523
___nl__6 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 524
___nl__11 = new ImmArray(new Imm[0]);
//line 525
___nl__13 = ((ImmHash)___nl__1).getHashValue()["type_errors"];
//line 525
___nl__14 = ((ImmHash)___nl__6).getHashValue()["module"];
//line 525
___nl__12 = hash_NL.NL_has_key(___nl__13,___nl__14);

//line 525
___nl__14 = null;
//line 525
___nl__13 = null;
//line 525
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12));
//line 525
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_5;}}
//line 526
___nl__14 = ((ImmHash)___nl__1).getHashValue()["type_errors"];
//line 526
___nl__15 = ((ImmHash)___nl__6).getHashValue()["module"];
//line 526
___nl__13 = hash_NL.NL_get_value(___nl__14,___nl__15);

//line 526
___nl__15 = null;
//line 526
___nl__14 = null;
//line 526
___nl__11 = ___nl__13;
//line 526
___nl__13 = null;
//line 527
if (true) {goto label_5;}
//line 527
label_5:
//line 527
___nl__12 = null;
//line 528
___ref______nl__11 = new ImmRef(___nl__11);
array_NL.NL_push(___ref______nl__11,___nl__6);
___nl__11 = ___ref______nl__11.getValue();

//line 529
___nl__12 = new ImmString("type_errors");
//line 529
___nl__12 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__12);

//line 529
___nl__13 = ((ImmHash)___nl__6).getHashValue()["module"];
//line 529
___ref______nl__12 = new ImmRef(___nl__12);
hash_NL.NL_set_value(___ref______nl__12,___nl__13,___nl__11);
___nl__12 = ___ref______nl__12.getValue();

//line 529
___nl__13 = null;
//line 529
___nl__13 = new ImmString("type_errors");
//line 529
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__13,___nl__12);
___nl__1 = ___ref______nl__1.getValue();

//line 529
___nl__13 = null;
//line 529
___nl__12 = null;
//line 529
___nl__11 = null;
//line 530
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString())));
//line 530
if (true) {goto label_3;}
//line 530
label_1:
//line 530
___nl__5 = null;
//line 530
___nl__6 = null;
//line 530
___nl__7 = null;
//line 530
___nl__8 = null;
//line 530
___nl__9 = null;
//line 530
___nl__10 = null;
//line 531
___nl__5 = ((ImmHash)___nl__3).getHashValue()["warnings"];
//line 531
___nl__7 = new ImmDouble(0);
//line 531
___nl__8 = new ImmDouble(1);
//line 531
___nl__9 = c_rt_lib_NL.NL_array_len(___nl__5);

//line 531
label_8:
//line 531
___nl__10 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))>=(Double.Parse(___nl__9.getValue().ToString())) );
//line 531
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_6;}}
//line 531
___nl__6 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 532
___nl__11 = new ImmArray(new Imm[0]);
//line 533
___nl__13 = ((ImmHash)___nl__1).getHashValue()["type_warnings"];
//line 533
___nl__14 = ((ImmHash)___nl__6).getHashValue()["module"];
//line 533
___nl__12 = hash_NL.NL_has_key(___nl__13,___nl__14);

//line 533
___nl__14 = null;
//line 533
___nl__13 = null;
//line 533
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12));
//line 533
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_10;}}
//line 534
___nl__14 = ((ImmHash)___nl__1).getHashValue()["type_warnings"];
//line 534
___nl__15 = ((ImmHash)___nl__6).getHashValue()["module"];
//line 534
___nl__13 = hash_NL.NL_get_value(___nl__14,___nl__15);

//line 534
___nl__15 = null;
//line 534
___nl__14 = null;
//line 534
___nl__11 = ___nl__13;
//line 534
___nl__13 = null;
//line 535
if (true) {goto label_10;}
//line 535
label_10:
//line 535
___nl__12 = null;
//line 536
___ref______nl__11 = new ImmRef(___nl__11);
array_NL.NL_push(___ref______nl__11,___nl__6);
___nl__11 = ___ref______nl__11.getValue();

//line 537
___nl__12 = new ImmString("type_warnings");
//line 537
___nl__12 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__12);

//line 537
___nl__13 = ((ImmHash)___nl__6).getHashValue()["module"];
//line 537
___ref______nl__12 = new ImmRef(___nl__12);
hash_NL.NL_set_value(___ref______nl__12,___nl__13,___nl__11);
___nl__12 = ___ref______nl__12.getValue();

//line 537
___nl__13 = null;
//line 537
___nl__13 = new ImmString("type_warnings");
//line 537
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__13,___nl__12);
___nl__1 = ___ref______nl__1.getValue();

//line 537
___nl__13 = null;
//line 537
___nl__12 = null;
//line 537
___nl__11 = null;
//line 538
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString())));
//line 538
if (true) {goto label_8;}
//line 538
label_6:
//line 538
___nl__5 = null;
//line 538
___nl__6 = null;
//line 538
___nl__7 = null;
//line 538
___nl__8 = null;
//line 538
___nl__9 = null;
//line 538
___nl__10 = null;
//line 539
___nl__5 = new ImmDouble(0);
//line 539
___nl__5 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString())) ==((Double.Parse(___nl__5.getValue().ToString())))  );
//line 539
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 539
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 539
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_12;}}
//line 539
___nl__6 = new ImmString("Found ");
//line 539
___nl__6 = new ImmString(___nl__6.toString() + ___nl__4.toString());
//line 539
___nl__7 = new ImmString(" errors of types. ");
//line 539
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 539
___nl__7 = null;
//line 539
c_fe_lib_NL.NL_print(___nl__6);

//line 539
___nl__6 = null;
//line 539
if (true) {goto label_12;}
//line 539
label_12:
//line 539
___nl__5 = null;
//line 540
__function_map = new Dictionary<String, Imm>();
___nl__5 = new ImmHash(__function_map);
//line 541
___nl__8 = c_rt_lib_NL.NL_init_iter(___nl__0);

//line 541
label_15:
//line 541
___nl__6 = c_rt_lib_NL.NL_is_end_hash(___nl__8);

//line 541
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_13;}}
//line 541
___nl__6 = c_rt_lib_NL.NL_get_key_iter(___nl__8);

//line 541
___nl__7 = c_rt_lib_NL.NL_hash_get_value(___nl__0,___nl__6);

//line 542
___nl__9 = new ImmArray(new Imm[0]);
//line 543
___nl__10 = ((ImmHash)___nl__7).getHashValue()["import"];
//line 543
___nl__12 = new ImmDouble(0);
//line 543
___nl__13 = new ImmDouble(1);
//line 543
___nl__14 = c_rt_lib_NL.NL_array_len(___nl__10);

//line 543
label_18:
//line 543
___nl__15 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__12.getValue().ToString()))>=(Double.Parse(___nl__14.getValue().ToString())) );
//line 543
if (c_rt_lib_NL.NL_check_true_native(___nl__15)) {if (true) {goto label_16;}}
//line 543
___nl__11 = (___nl__10 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__12).getDoubleValue()];
//line 544
___nl__16 = ((ImmHash)___nl__11).getHashValue()["name"];
//line 544
___ref______nl__9 = new ImmRef(___nl__9);
array_NL.NL_push(___ref______nl__9,___nl__16);
___nl__9 = ___ref______nl__9.getValue();

//line 544
___nl__16 = null;
//line 545
___nl__12 = new ImmDouble((Double.Parse(___nl__12.getValue().ToString()))+(Double.Parse(___nl__13.getValue().ToString())));
//line 545
if (true) {goto label_18;}
//line 545
label_16:
//line 545
___nl__10 = null;
//line 545
___nl__11 = null;
//line 545
___nl__12 = null;
//line 545
___nl__13 = null;
//line 545
___nl__14 = null;
//line 545
___nl__15 = null;
//line 546
___ref______nl__5 = new ImmRef(___nl__5);
hash_NL.NL_set_value(___ref______nl__5,___nl__6,___nl__9);
___nl__5 = ___ref______nl__5.getValue();

//line 546
___nl__9 = null;
//line 547
___nl__8 = c_rt_lib_NL.NL_next_iter(___nl__8);

//line 547
if (true) {goto label_15;}
//line 547
label_13:
//line 547
___nl__6 = null;
//line 547
___nl__7 = null;
//line 547
___nl__8 = null;
//line 548
___nl__6 = module_checker_NL.NL_search_loops(___nl__5);

//line 548
___nl__7 = ___nl__6;
//line 548
((ImmHash)___nl__1).set("loop_error", ___nl__7);
//line 548
___nl__6 = null;
//line 548
___nl__7 = null;
//line 549
___nl__6 = ___nl__2;
//line 549
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("yes"));
//line 549
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 549
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_20;}}
//line 550
___nl__7 = new ImmString("deleted types: ");
//line 550
___nl__9 = ((ImmHash)___nl__3).getHashValue()["deref"];
//line 550
___nl__9 = ((ImmHash)___nl__9).getHashValue()["delete"];
//line 550
___nl__8 = array_NL.NL_len(___nl__9);

//line 550
___nl__9 = null;
//line 550
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 550
___nl__8 = null;
//line 550
c_fe_lib_NL.NL_print(___nl__7);

//line 550
___nl__7 = null;
//line 551
___nl__7 = new ImmString("created types: ");
//line 551
___nl__9 = ((ImmHash)___nl__3).getHashValue()["deref"];
//line 551
___nl__9 = ((ImmHash)___nl__9).getHashValue()["create"];
//line 551
___nl__8 = array_NL.NL_len(___nl__9);

//line 551
___nl__9 = null;
//line 551
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 551
___nl__8 = null;
//line 551
c_fe_lib_NL.NL_print(___nl__7);

//line 551
___nl__7 = null;
//line 552
___nl__7 = ___nl__2;
//line 552
___nl__7 = c_rt_lib_NL.NL_ov_as(___nl__7, new ImmString("yes"));
//line 552
___nl__9 = ((ImmHash)___nl__3).getHashValue()["deref"];
//line 552
___nl__8 = dfile_NL.NL_ssave(___nl__9);

//line 552
___nl__9 = null;
//line 552
c_fe_lib_NL.NL_string_to_file(___nl__7,___nl__8);

//line 552
___nl__8 = null;
//line 552
___nl__7 = null;
//line 553
if (true) {goto label_20;}
//line 553
label_20:
//line 553
___nl__6 = null;
//line 553
___nl__3 = null;
//line 553
___nl__4 = null;
//line 553
___nl__5 = null;
//line 553
___nl__0 = null;
//line 553
___nl__2 = null;
//line 553
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_try_save_file_priv(Imm ___arg__0, Imm ___arg__1, ImmRef ___arg__2) {
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
//line 556
___nl__3 = c_fe_lib_NL.NL_string_to_file(___nl__1,___nl__0);

//line 556
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("ok"));
//line 556
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 557
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("err"));
//line 557
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_3;}}
//line 557
___nl__4 = new ImmString("NOMATCHALERT");
//line 557
___nl__4 = new ImmArray(new Imm[] {___nl__4,___nl__3,});
//line 557
c_rt_lib_NL.NL_die();
//line 556
label_2:
//line 556
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("ok"));
//line 556
___nl__5 = null;
//line 557
if (true) {goto label_1;}
//line 557
label_3:
//line 557
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("err"));
//line 558
___nl__6 = new ImmString("ERROR: ");
//line 558
___nl__6 = new ImmString(___nl__6.toString() + ___nl__5.toString());
//line 558
c_fe_lib_NL.NL_print(___nl__6);

//line 558
___nl__6 = null;
//line 559
___nl__6 = c_rt_lib_NL.NL_get_true();
//line 559
___nl__2 = ___nl__6;
//line 559
___nl__6 = null;
//line 559
___nl__5 = null;
//line 560
if (true) {goto label_1;}
//line 560
label_1:
//line 560
___nl__3 = null;
//line 560
___nl__4 = null;
//line 560
___nl__0 = null;
//line 560
___nl__1 = null;
//line 560
___arg__2.setValue(___nl__2);if(true) return null;
}

private static Imm NL_generate_modules_to_files_priv(Imm ___arg__0, Imm ___arg__1, Imm ___arg__2, ImmRef ___arg__3, Imm ___arg__4) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();Imm ___nl__3 = ___arg__3.getValue().clone();Imm ___nl__4 = ___arg__4.clone();
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
//line 564
__function_map = new Dictionary<String, Imm>();
___nl__5 = new ImmHash(__function_map);
//line 565
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("nla"));
//line 565
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_2;}}
//line 573
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("c"));
//line 573
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_3;}}
//line 587
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("pm"));
//line 587
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_4;}}
//line 596
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("js"));
//line 596
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_5;}}
//line 605
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("java"));
//line 605
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_6;}}
//line 614
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("cs"));
//line 614
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_7;}}
//line 623
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("nl"));
//line 623
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_8;}}
//line 625
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("ast"));
//line 625
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_9;}}
//line 625
___nl__6 = new ImmString("NOMATCHALERT");
//line 625
___nl__6 = new ImmArray(new Imm[] {___nl__6,___nl__4,});
//line 625
c_rt_lib_NL.NL_die();
//line 565
label_2:
//line 566
___nl__9 = c_rt_lib_NL.NL_init_iter(___nl__0);

//line 566
label_12:
//line 566
___nl__7 = c_rt_lib_NL.NL_is_end_hash(___nl__9);

//line 566
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_10;}}
//line 566
___nl__7 = c_rt_lib_NL.NL_get_key_iter(___nl__9);

//line 566
___nl__8 = c_rt_lib_NL.NL_hash_get_value(___nl__0,___nl__7);

//line 567
___nl__10 = c_rt_lib_NL.NL_get_false();
//line 568
___nl__11 = hash_NL.NL_get_value(___nl__1,___nl__7);

//line 568
___nl__11 = ((ImmHash)___nl__11).getHashValue()["dst"];
//line 568
___nl__11 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("nla"));
//line 569
___nl__12 = new ImmString("saving file: ");
//line 569
___nl__12 = new ImmString(___nl__12.toString() + ___nl__7.toString());
//line 569
c_fe_lib_NL.NL_print(___nl__12);

//line 569
___nl__12 = null;
//line 570
___nl__12 = dfile_NL.NL_ssave(___nl__8);

//line 570
___ref______nl__10 = new ImmRef(___nl__10);
compiler_NL.NL_try_save_file_priv(___nl__12,___nl__11,___ref______nl__10);
___nl__10 = ___ref______nl__10.getValue();

//line 570
___nl__12 = null;
//line 571
___nl__12 = ___nl__10;
//line 571
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12));
//line 571
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_14;}}
//line 571
___nl__13 = new ImmString("");
//line 571
___ref______nl__5 = new ImmRef(___nl__5);
hash_NL.NL_set_value(___ref______nl__5,___nl__7,___nl__13);
___nl__5 = ___ref______nl__5.getValue();

//line 571
___nl__13 = null;
//line 571
if (true) {goto label_14;}
//line 571
label_14:
//line 571
___nl__12 = null;
//line 571
___nl__10 = null;
//line 571
___nl__11 = null;
//line 572
___nl__9 = c_rt_lib_NL.NL_next_iter(___nl__9);

//line 572
if (true) {goto label_12;}
//line 572
label_10:
//line 572
___nl__7 = null;
//line 572
___nl__8 = null;
//line 572
___nl__9 = null;
//line 573
if (true) {goto label_1;}
//line 573
label_3:
//line 574
___ref______nl__3 = new ImmRef(___nl__3);
___nl__7 = generator_c_NL.NL_generate(___nl__0,___ref______nl__3);
___nl__3 = ___ref______nl__3.getValue();

//line 575
___nl__8 = c_rt_lib_NL.NL_get_false();
//line 576
___nl__9 = ((ImmHash)___nl__7).getHashValue()["modules"];
//line 576
___nl__12 = c_rt_lib_NL.NL_init_iter(___nl__9);

//line 576
label_17:
//line 576
___nl__10 = c_rt_lib_NL.NL_is_end_hash(___nl__12);

//line 576
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_15;}}
//line 576
___nl__10 = c_rt_lib_NL.NL_get_key_iter(___nl__12);

//line 576
___nl__11 = c_rt_lib_NL.NL_hash_get_value(___nl__9,___nl__10);

//line 577
___nl__13 = c_rt_lib_NL.NL_get_false();
//line 577
___nl__8 = ___nl__13;
//line 577
___nl__13 = null;
//line 578
___nl__13 = hash_NL.NL_get_value(___nl__1,___nl__10);

//line 578
___nl__13 = ((ImmHash)___nl__13).getHashValue()["dst"];
//line 578
___nl__13 = c_rt_lib_NL.NL_ov_as(___nl__13, new ImmString("c"));
//line 579
___nl__14 = new ImmString("saving file: ");
//line 579
___nl__14 = new ImmString(___nl__14.toString() + ___nl__10.toString());
//line 579
c_fe_lib_NL.NL_print(___nl__14);

//line 579
___nl__14 = null;
//line 580
___nl__14 = ((ImmHash)___nl__11).getHashValue()["c"];
//line 580
___nl__15 = ((ImmHash)___nl__13).getHashValue()["c"];
//line 580
___ref______nl__8 = new ImmRef(___nl__8);
compiler_NL.NL_try_save_file_priv(___nl__14,___nl__15,___ref______nl__8);
___nl__8 = ___ref______nl__8.getValue();

//line 580
___nl__15 = null;
//line 580
___nl__14 = null;
//line 581
___nl__14 = ((ImmHash)___nl__11).getHashValue()["h"];
//line 581
___nl__15 = ((ImmHash)___nl__13).getHashValue()["h"];
//line 581
___ref______nl__8 = new ImmRef(___nl__8);
compiler_NL.NL_try_save_file_priv(___nl__14,___nl__15,___ref______nl__8);
___nl__8 = ___ref______nl__8.getValue();

//line 581
___nl__15 = null;
//line 581
___nl__14 = null;
//line 582
___nl__14 = ___nl__8;
//line 582
___nl__14 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__14));
//line 582
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_19;}}
//line 582
___nl__15 = new ImmString("");
//line 582
___ref______nl__5 = new ImmRef(___nl__5);
hash_NL.NL_set_value(___ref______nl__5,___nl__10,___nl__15);
___nl__5 = ___ref______nl__5.getValue();

//line 582
___nl__15 = null;
//line 582
if (true) {goto label_19;}
//line 582
label_19:
//line 582
___nl__14 = null;
//line 582
___nl__13 = null;
//line 583
___nl__12 = c_rt_lib_NL.NL_next_iter(___nl__12);

//line 583
if (true) {goto label_17;}
//line 583
label_15:
//line 583
___nl__9 = null;
//line 583
___nl__10 = null;
//line 583
___nl__11 = null;
//line 583
___nl__12 = null;
//line 584
___nl__9 = new ImmString("saving global const file");
//line 584
c_fe_lib_NL.NL_print(___nl__9);

//line 584
___nl__9 = null;
//line 585
___nl__9 = ((ImmHash)___nl__7).getHashValue()["global_const"];
//line 585
___nl__9 = ((ImmHash)___nl__9).getHashValue()["c"];
//line 585
___nl__10 = new ImmString("c_global_const.c");
//line 585
___nl__10 = new ImmString(___nl__2.toString() + ___nl__10.toString());
//line 585
___ref______nl__8 = new ImmRef(___nl__8);
compiler_NL.NL_try_save_file_priv(___nl__9,___nl__10,___ref______nl__8);
___nl__8 = ___ref______nl__8.getValue();

//line 585
___nl__10 = null;
//line 585
___nl__9 = null;
//line 586
___nl__9 = ((ImmHash)___nl__7).getHashValue()["global_const"];
//line 586
___nl__9 = ((ImmHash)___nl__9).getHashValue()["h"];
//line 586
___nl__10 = new ImmString("c_global_const.h");
//line 586
___nl__10 = new ImmString(___nl__2.toString() + ___nl__10.toString());
//line 586
___ref______nl__8 = new ImmRef(___nl__8);
compiler_NL.NL_try_save_file_priv(___nl__9,___nl__10,___ref______nl__8);
___nl__8 = ___ref______nl__8.getValue();

//line 586
___nl__10 = null;
//line 586
___nl__9 = null;
//line 586
___nl__7 = null;
//line 586
___nl__8 = null;
//line 587
if (true) {goto label_1;}
//line 587
label_4:
//line 588
___nl__9 = c_rt_lib_NL.NL_init_iter(___nl__0);

//line 588
label_22:
//line 588
___nl__7 = c_rt_lib_NL.NL_is_end_hash(___nl__9);

//line 588
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_20;}}
//line 588
___nl__7 = c_rt_lib_NL.NL_get_key_iter(___nl__9);

//line 588
___nl__8 = c_rt_lib_NL.NL_hash_get_value(___nl__0,___nl__7);

//line 589
___nl__10 = c_rt_lib_NL.NL_get_false();
//line 590
___nl__11 = generator_pm_NL.NL_generate(___nl__8);

//line 591
___nl__12 = hash_NL.NL_get_value(___nl__1,___nl__7);

//line 591
___nl__12 = ((ImmHash)___nl__12).getHashValue()["dst"];
//line 591
___nl__12 = c_rt_lib_NL.NL_ov_as(___nl__12, new ImmString("pm"));
//line 592
___nl__13 = new ImmString("saving file: ");
//line 592
___nl__13 = new ImmString(___nl__13.toString() + ___nl__7.toString());
//line 592
c_fe_lib_NL.NL_print(___nl__13);

//line 592
___nl__13 = null;
//line 593
___ref______nl__10 = new ImmRef(___nl__10);
compiler_NL.NL_try_save_file_priv(___nl__11,___nl__12,___ref______nl__10);
___nl__10 = ___ref______nl__10.getValue();

//line 594
___nl__13 = ___nl__10;
//line 594
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13));
//line 594
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_24;}}
//line 594
___nl__14 = new ImmString("");
//line 594
___ref______nl__5 = new ImmRef(___nl__5);
hash_NL.NL_set_value(___ref______nl__5,___nl__7,___nl__14);
___nl__5 = ___ref______nl__5.getValue();

//line 594
___nl__14 = null;
//line 594
if (true) {goto label_24;}
//line 594
label_24:
//line 594
___nl__13 = null;
//line 594
___nl__10 = null;
//line 594
___nl__11 = null;
//line 594
___nl__12 = null;
//line 595
___nl__9 = c_rt_lib_NL.NL_next_iter(___nl__9);

//line 595
if (true) {goto label_22;}
//line 595
label_20:
//line 595
___nl__7 = null;
//line 595
___nl__8 = null;
//line 595
___nl__9 = null;
//line 596
if (true) {goto label_1;}
//line 596
label_5:
//line 597
___nl__9 = c_rt_lib_NL.NL_init_iter(___nl__0);

//line 597
label_27:
//line 597
___nl__7 = c_rt_lib_NL.NL_is_end_hash(___nl__9);

//line 597
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_25;}}
//line 597
___nl__7 = c_rt_lib_NL.NL_get_key_iter(___nl__9);

//line 597
___nl__8 = c_rt_lib_NL.NL_hash_get_value(___nl__0,___nl__7);

//line 598
___nl__10 = c_rt_lib_NL.NL_get_false();
//line 599
___nl__11 = generator_js_NL.NL_generate(___nl__8);

//line 600
___nl__12 = hash_NL.NL_get_value(___nl__1,___nl__7);

//line 600
___nl__12 = ((ImmHash)___nl__12).getHashValue()["dst"];
//line 600
___nl__12 = c_rt_lib_NL.NL_ov_as(___nl__12, new ImmString("js"));
//line 601
___nl__13 = new ImmString("saving file: ");
//line 601
___nl__13 = new ImmString(___nl__13.toString() + ___nl__7.toString());
//line 601
c_fe_lib_NL.NL_print(___nl__13);

//line 601
___nl__13 = null;
//line 602
___ref______nl__10 = new ImmRef(___nl__10);
compiler_NL.NL_try_save_file_priv(___nl__11,___nl__12,___ref______nl__10);
___nl__10 = ___ref______nl__10.getValue();

//line 603
___nl__13 = ___nl__10;
//line 603
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13));
//line 603
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_29;}}
//line 603
___nl__14 = new ImmString("");
//line 603
___ref______nl__5 = new ImmRef(___nl__5);
hash_NL.NL_set_value(___ref______nl__5,___nl__7,___nl__14);
___nl__5 = ___ref______nl__5.getValue();

//line 603
___nl__14 = null;
//line 603
if (true) {goto label_29;}
//line 603
label_29:
//line 603
___nl__13 = null;
//line 603
___nl__10 = null;
//line 603
___nl__11 = null;
//line 603
___nl__12 = null;
//line 604
___nl__9 = c_rt_lib_NL.NL_next_iter(___nl__9);

//line 604
if (true) {goto label_27;}
//line 604
label_25:
//line 604
___nl__7 = null;
//line 604
___nl__8 = null;
//line 604
___nl__9 = null;
//line 605
if (true) {goto label_1;}
//line 605
label_6:
//line 606
___nl__9 = c_rt_lib_NL.NL_init_iter(___nl__0);

//line 606
label_32:
//line 606
___nl__7 = c_rt_lib_NL.NL_is_end_hash(___nl__9);

//line 606
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_30;}}
//line 606
___nl__7 = c_rt_lib_NL.NL_get_key_iter(___nl__9);

//line 606
___nl__8 = c_rt_lib_NL.NL_hash_get_value(___nl__0,___nl__7);

//line 607
___nl__10 = c_rt_lib_NL.NL_get_false();
//line 608
___nl__11 = generator_java_NL.NL_generate(___nl__8);

//line 609
___nl__12 = hash_NL.NL_get_value(___nl__1,___nl__7);

//line 609
___nl__12 = ((ImmHash)___nl__12).getHashValue()["dst"];
//line 609
___nl__12 = c_rt_lib_NL.NL_ov_as(___nl__12, new ImmString("java"));
//line 610
___nl__13 = new ImmString("saving file: ");
//line 610
___nl__13 = new ImmString(___nl__13.toString() + ___nl__7.toString());
//line 610
c_fe_lib_NL.NL_print(___nl__13);

//line 610
___nl__13 = null;
//line 611
___ref______nl__10 = new ImmRef(___nl__10);
compiler_NL.NL_try_save_file_priv(___nl__11,___nl__12,___ref______nl__10);
___nl__10 = ___ref______nl__10.getValue();

//line 612
___nl__13 = ___nl__10;
//line 612
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13));
//line 612
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_34;}}
//line 612
___nl__14 = new ImmString("");
//line 612
___ref______nl__5 = new ImmRef(___nl__5);
hash_NL.NL_set_value(___ref______nl__5,___nl__7,___nl__14);
___nl__5 = ___ref______nl__5.getValue();

//line 612
___nl__14 = null;
//line 612
if (true) {goto label_34;}
//line 612
label_34:
//line 612
___nl__13 = null;
//line 612
___nl__10 = null;
//line 612
___nl__11 = null;
//line 612
___nl__12 = null;
//line 613
___nl__9 = c_rt_lib_NL.NL_next_iter(___nl__9);

//line 613
if (true) {goto label_32;}
//line 613
label_30:
//line 613
___nl__7 = null;
//line 613
___nl__8 = null;
//line 613
___nl__9 = null;
//line 614
if (true) {goto label_1;}
//line 614
label_7:
//line 615
___nl__9 = c_rt_lib_NL.NL_init_iter(___nl__0);

//line 615
label_37:
//line 615
___nl__7 = c_rt_lib_NL.NL_is_end_hash(___nl__9);

//line 615
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_35;}}
//line 615
___nl__7 = c_rt_lib_NL.NL_get_key_iter(___nl__9);

//line 615
___nl__8 = c_rt_lib_NL.NL_hash_get_value(___nl__0,___nl__7);

//line 616
___nl__10 = c_rt_lib_NL.NL_get_false();
//line 617
___nl__11 = generator_cs_NL.NL_generate(___nl__8);

//line 618
___nl__12 = hash_NL.NL_get_value(___nl__1,___nl__7);

//line 618
___nl__12 = ((ImmHash)___nl__12).getHashValue()["dst"];
//line 618
___nl__12 = c_rt_lib_NL.NL_ov_as(___nl__12, new ImmString("cs"));
//line 619
___nl__13 = new ImmString("saving file: ");
//line 619
___nl__13 = new ImmString(___nl__13.toString() + ___nl__7.toString());
//line 619
c_fe_lib_NL.NL_print(___nl__13);

//line 619
___nl__13 = null;
//line 620
___ref______nl__10 = new ImmRef(___nl__10);
compiler_NL.NL_try_save_file_priv(___nl__11,___nl__12,___ref______nl__10);
___nl__10 = ___ref______nl__10.getValue();

//line 621
___nl__13 = ___nl__10;
//line 621
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13));
//line 621
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_39;}}
//line 621
___nl__14 = new ImmString("");
//line 621
___ref______nl__5 = new ImmRef(___nl__5);
hash_NL.NL_set_value(___ref______nl__5,___nl__7,___nl__14);
___nl__5 = ___ref______nl__5.getValue();

//line 621
___nl__14 = null;
//line 621
if (true) {goto label_39;}
//line 621
label_39:
//line 621
___nl__13 = null;
//line 621
___nl__10 = null;
//line 621
___nl__11 = null;
//line 621
___nl__12 = null;
//line 622
___nl__9 = c_rt_lib_NL.NL_next_iter(___nl__9);

//line 622
if (true) {goto label_37;}
//line 622
label_35:
//line 622
___nl__7 = null;
//line 622
___nl__8 = null;
//line 622
___nl__9 = null;
//line 623
if (true) {goto label_1;}
//line 623
label_8:
//line 624
___nl__7 = new ImmArray(new Imm[0]);
//line 624
c_rt_lib_NL.NL_die();
//line 624
___nl__7 = null;
//line 625
if (true) {goto label_1;}
//line 625
label_9:
//line 626
___nl__7 = new ImmArray(new Imm[0]);
//line 626
c_rt_lib_NL.NL_die();
//line 626
___nl__7 = null;
//line 627
if (true) {goto label_1;}
//line 627
label_1:
//line 627
___nl__6 = null;
//line 628
___nl__6 = hash_NL.NL_size(___nl__5);

//line 628
___nl__7 = new ImmDouble(0);
//line 628
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__6.getValue().ToString()))>(Double.Parse(___nl__7.getValue().ToString())) );
//line 628
___nl__7 = null;
//line 628
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 628
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_41;}}
//line 629
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("err"), ___nl__5);
//line 629
___nl__0 = null;
//line 629
___nl__1 = null;
//line 629
___nl__2 = null;
//line 629
___nl__4 = null;
//line 629
___nl__5 = null;
//line 629
___nl__6 = null;
//line 629
___arg__3.setValue(___nl__3);if(true) return ___nl__7;
//line 629
___nl__7 = null;
//line 630
if (true) {goto label_40;}
//line 630
label_41:
//line 631
___nl__7 = new ImmString("");
//line 631
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__7);
//line 631
___nl__0 = null;
//line 631
___nl__1 = null;
//line 631
___nl__2 = null;
//line 631
___nl__4 = null;
//line 631
___nl__5 = null;
//line 631
___nl__6 = null;
//line 631
___arg__3.setValue(___nl__3);if(true) return ___nl__7;
//line 631
___nl__7 = null;
//line 632
if (true) {goto label_40;}
//line 632
label_40:
//line 632
___nl__6 = null;
//line 632
___nl__5 = null;
//line 632
___nl__0 = null;
//line 632
___nl__1 = null;
//line 632
___nl__2 = null;
//line 632
___nl__4 = null;
//line 632
___arg__3.setValue(___nl__3);if(true) return null;
}

private static Imm NL_save_module_to_file_priv(Imm ___arg__0, Imm ___arg__1) {
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
//line 635
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("nla"));
//line 635
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 637
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("c"));
//line 637
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_3;}}
//line 639
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("pm"));
//line 639
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_4;}}
//line 641
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("js"));
//line 641
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_5;}}
//line 643
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("java"));
//line 643
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_6;}}
//line 645
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("cs"));
//line 645
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_7;}}
//line 647
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("nl"));
//line 647
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_8;}}
//line 649
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("ast"));
//line 649
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_9;}}
//line 651
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("none"));
//line 651
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_10;}}
//line 651
___nl__2 = new ImmString("NOMATCHALERT");
//line 651
___nl__2 = new ImmArray(new Imm[] {___nl__2,___nl__1,});
//line 651
c_rt_lib_NL.NL_die();
//line 635
label_2:
//line 635
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__1, new ImmString("nla"));
//line 636
___nl__4 = new ImmArray(new Imm[0]);
//line 636
c_rt_lib_NL.NL_die();
//line 636
___nl__4 = null;
//line 636
___nl__3 = null;
//line 637
if (true) {goto label_1;}
//line 637
label_3:
//line 637
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__1, new ImmString("c"));
//line 638
___nl__4 = new ImmArray(new Imm[0]);
//line 638
c_rt_lib_NL.NL_die();
//line 638
___nl__4 = null;
//line 638
___nl__3 = null;
//line 639
if (true) {goto label_1;}
//line 639
label_4:
//line 639
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__1, new ImmString("pm"));
//line 640
___nl__4 = new ImmArray(new Imm[0]);
//line 640
c_rt_lib_NL.NL_die();
//line 640
___nl__4 = null;
//line 640
___nl__3 = null;
//line 641
if (true) {goto label_1;}
//line 641
label_5:
//line 641
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__1, new ImmString("js"));
//line 642
___nl__4 = new ImmArray(new Imm[0]);
//line 642
c_rt_lib_NL.NL_die();
//line 642
___nl__4 = null;
//line 642
___nl__3 = null;
//line 643
if (true) {goto label_1;}
//line 643
label_6:
//line 643
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__1, new ImmString("java"));
//line 644
___nl__4 = new ImmArray(new Imm[0]);
//line 644
c_rt_lib_NL.NL_die();
//line 644
___nl__4 = null;
//line 644
___nl__3 = null;
//line 645
if (true) {goto label_1;}
//line 645
label_7:
//line 645
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__1, new ImmString("cs"));
//line 646
___nl__4 = new ImmArray(new Imm[0]);
//line 646
c_rt_lib_NL.NL_die();
//line 646
___nl__4 = null;
//line 646
___nl__3 = null;
//line 647
if (true) {goto label_1;}
//line 647
label_8:
//line 647
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__1, new ImmString("nl"));
//line 648
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("compiler_NL"));
__function_map.Add("name",new ImmString("file_t"));
___nl__5 = new ImmHash(__function_map);
//line 648
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__5);
//line 648
___nl__7 = pretty_printer_NL.NL_print_module_to_str(___nl__0);

//line 648
___nl__6 = c_fe_lib_NL.NL_string_to_file(___nl__3,___nl__7);

//line 648
___nl__7 = null;
//line 648
___nl__4 = ptd_NL.NL_ensure(___nl__5,___nl__6);

//line 648
___nl__6 = null;
//line 648
___nl__5 = null;
//line 648
___nl__0 = null;
//line 648
___nl__1 = null;
//line 648
___nl__2 = null;
//line 648
___nl__3 = null;
//line 648
if(true) return ___nl__4;
//line 648
___nl__4 = null;
//line 648
___nl__3 = null;
//line 649
if (true) {goto label_1;}
//line 649
label_9:
//line 649
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__1, new ImmString("ast"));
//line 650
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("compiler_NL"));
__function_map.Add("name",new ImmString("file_t"));
___nl__5 = new ImmHash(__function_map);
//line 650
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__5);
//line 650
___nl__7 = dfile_NL.NL_ssave(___nl__0);

//line 650
___nl__6 = c_fe_lib_NL.NL_string_to_file(___nl__3,___nl__7);

//line 650
___nl__7 = null;
//line 650
___nl__4 = ptd_NL.NL_ensure(___nl__5,___nl__6);

//line 650
___nl__6 = null;
//line 650
___nl__5 = null;
//line 650
___nl__0 = null;
//line 650
___nl__1 = null;
//line 650
___nl__2 = null;
//line 650
___nl__3 = null;
//line 650
if(true) return ___nl__4;
//line 650
___nl__4 = null;
//line 650
___nl__3 = null;
//line 651
if (true) {goto label_1;}
//line 651
label_10:
//line 652
___nl__3 = new ImmArray(new Imm[0]);
//line 652
c_rt_lib_NL.NL_die();
//line 652
___nl__3 = null;
//line 653
if (true) {goto label_1;}
//line 653
label_1:
//line 653
___nl__2 = null;
//line 653
___nl__0 = null;
//line 653
___nl__1 = null;
//line 653
if(true) return null;
}

private static Imm NL_get_dir_priv(Imm ___arg__0) {
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
//line 657
___nl__1 = string_NL.NL_length(___nl__0);

//line 657
___nl__2 = new ImmDouble(1);
//line 657
___nl__1 = new ImmDouble((Double.Parse(___nl__1.getValue().ToString()))-(Double.Parse(___nl__2.getValue().ToString())));
//line 657
___nl__2 = null;
//line 658
___nl__3 = new ImmDouble(1);
//line 658
___nl__2 = string_NL.NL_substr(___nl__0,___nl__1,___nl__3);

//line 658
___nl__3 = null;
//line 658
___nl__3 = new ImmString("/");
//line 658
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 658
___nl__3 = null;
//line 658
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_3;}}
//line 658
___nl__3 = new ImmDouble(1);
//line 658
___nl__2 = string_NL.NL_substr(___nl__0,___nl__1,___nl__3);

//line 658
___nl__3 = null;
//line 658
___nl__3 = new ImmString("\\");
//line 658
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 658
___nl__3 = null;
//line 658
label_3:
//line 658
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 658
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 658
___nl__3 = new ImmDouble(1);
//line 658
___nl__1 = new ImmDouble((Double.Parse(___nl__1.getValue().ToString()))-(Double.Parse(___nl__3.getValue().ToString())));
//line 658
___nl__3 = null;
//line 658
if (true) {goto label_2;}
//line 658
label_2:
//line 658
___nl__2 = null;
//line 659
label_5:
//line 659
___nl__2 = new ImmDouble(0);
//line 659
___nl__2 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__1.getValue().ToString()))>=(Double.Parse(___nl__2.getValue().ToString())) );
//line 659
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 659
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_7;}}
//line 659
___nl__5 = new ImmDouble(1);
//line 659
___nl__2 = string_NL.NL_substr(___nl__0,___nl__1,___nl__5);

//line 659
___nl__5 = null;
//line 659
___nl__5 = new ImmString("/");
//line 659
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!___nl__2.toString().Equals(___nl__5.toString()));
//line 659
___nl__5 = null;
//line 659
label_7:
//line 659
___nl__4 = null;
//line 659
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 659
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_6;}}
//line 659
___nl__4 = new ImmDouble(1);
//line 659
___nl__2 = string_NL.NL_substr(___nl__0,___nl__1,___nl__4);

//line 659
___nl__4 = null;
//line 659
___nl__4 = new ImmString("\\");
//line 659
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!___nl__2.toString().Equals(___nl__4.toString()));
//line 659
___nl__4 = null;
//line 659
label_6:
//line 659
___nl__3 = null;
//line 659
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 659
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_4;}}
//line 659
___nl__3 = new ImmDouble(1);
//line 659
___nl__1 = new ImmDouble((Double.Parse(___nl__1.getValue().ToString()))-(Double.Parse(___nl__3.getValue().ToString())));
//line 659
___nl__3 = null;
//line 659
if (true) {goto label_5;}
//line 659
label_4:
//line 659
___nl__2 = null;
//line 660
___nl__2 = new ImmDouble(0);
//line 660
___nl__2 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__1.getValue().ToString()))<=(Double.Parse(___nl__2.getValue().ToString())) );
//line 660
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 660
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_9;}}
//line 660
___nl__3 = new ImmString(".");
//line 660
___nl__0 = null;
//line 660
___nl__1 = null;
//line 660
___nl__2 = null;
//line 660
if(true) return ___nl__3;
//line 660
___nl__3 = null;
//line 660
if (true) {goto label_9;}
//line 660
label_9:
//line 660
___nl__2 = null;
//line 661
___nl__3 = new ImmDouble(0);
//line 661
___nl__2 = string_NL.NL_substr(___nl__0,___nl__3,___nl__1);

//line 661
___nl__3 = null;
//line 661
___nl__0 = null;
//line 661
___nl__1 = null;
//line 661
if(true) return ___nl__2;
//line 661
___nl__2 = null;
//line 661
___nl__1 = null;
//line 661
___nl__0 = null;
//line 661
if(true) return null;
}

private static Imm NL_parse_command_line_args_priv(Imm ___arg__0) {
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
//line 665
___nl__2 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("c"));
//line 665
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("strict"));
//line 665
___nl__5 = new ImmString(".");
//line 665
___nl__4 = new ImmArray(new Imm[] {___nl__5,});
//line 665
___nl__5 = null;
//line 665
___nl__5 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("o1"));
//line 665
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("no"));
//line 665
___nl__7 = compiler_NL.NL_get_default_math_file_priv();

//line 665
___nl__8 = new ImmString("");
//line 665
___nl__9 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("norm"));
//line 665
__function_map = new Dictionary<String, Imm>();
__function_map.Add("language",___nl__2);
__function_map.Add("mode",___nl__3);
__function_map.Add("input_path",___nl__4);
__function_map.Add("optimization",___nl__5);
__function_map.Add("deref",___nl__6);
__function_map.Add("math_fun",___nl__7);
__function_map.Add("cache_path",___nl__8);
__function_map.Add("alarm",___nl__9);
___nl__1 = new ImmHash(__function_map);
//line 665
___nl__2 = null;
//line 665
___nl__3 = null;
//line 665
___nl__4 = null;
//line 665
___nl__5 = null;
//line 665
___nl__6 = null;
//line 665
___nl__7 = null;
//line 665
___nl__8 = null;
//line 665
___nl__9 = null;
//line 675
___nl__2 = c_rt_lib_NL.NL_get_false();
//line 676
___nl__3 = compiler_NL.NL_get_dir_cache_name_priv();

//line 677
___nl__4 = new ImmDouble(1);
//line 677
label_2:
//line 677
___nl__5 = array_NL.NL_len(___nl__0);

//line 677
___nl__5 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))<(Double.Parse(___nl__5.getValue().ToString())) );
//line 677
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 677
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_1;}}
//line 678
___nl__6 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()];
//line 679
___nl__7 = string_NL.NL_length(___nl__6);

//line 679
___nl__9 = new ImmDouble(2);
//line 679
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))>=(Double.Parse(___nl__9.getValue().ToString())) );
//line 679
___nl__9 = null;
//line 679
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 679
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_6;}}
//line 679
___nl__9 = new ImmDouble(0);
//line 679
___nl__10 = new ImmDouble(2);
//line 679
___nl__7 = string_NL.NL_substr(___nl__6,___nl__9,___nl__10);

//line 679
___nl__10 = null;
//line 679
___nl__9 = null;
//line 679
___nl__9 = new ImmString("--");
//line 679
___nl__7 = c_rt_lib_NL.NL_native_to_nl(___nl__7.toString().Equals(___nl__9.toString()));
//line 679
___nl__9 = null;
//line 679
label_6:
//line 679
___nl__8 = null;
//line 679
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 679
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_5;}}
//line 680
___nl__9 = new ImmDouble(2);
//line 680
___nl__10 = string_NL.NL_length(___nl__6);

//line 680
___nl__11 = new ImmDouble(2);
//line 680
___nl__10 = new ImmDouble((Double.Parse(___nl__10.getValue().ToString()))-(Double.Parse(___nl__11.getValue().ToString())));
//line 680
___nl__11 = null;
//line 680
___nl__8 = string_NL.NL_substr(___nl__6,___nl__9,___nl__10);

//line 680
___nl__10 = null;
//line 680
___nl__9 = null;
//line 681
___nl__9 = new ImmString("deref");
//line 681
___nl__9 = c_rt_lib_NL.NL_native_to_nl(___nl__8.toString().Equals(___nl__9.toString()));
//line 681
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9));
//line 681
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_8;}}
//line 682
___nl__10 = new ImmString("");
//line 682
___nl__10 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("yes"), ___nl__10);
//line 682
___nl__11 = ___nl__10;
//line 682
((ImmHash)___nl__1).set("deref", ___nl__11);
//line 682
___nl__10 = null;
//line 682
___nl__11 = null;
//line 683
if (true) {goto label_7;}
//line 683
label_8:
//line 683
___nl__9 = new ImmString("nla");
//line 683
___nl__9 = c_rt_lib_NL.NL_native_to_nl(___nl__8.toString().Equals(___nl__9.toString()));
//line 683
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9));
//line 683
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_9;}}
//line 684
___nl__10 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("nla"));
//line 684
___nl__11 = ___nl__10;
//line 684
((ImmHash)___nl__1).set("language", ___nl__11);
//line 684
___nl__10 = null;
//line 684
___nl__11 = null;
//line 685
if (true) {goto label_7;}
//line 685
label_9:
//line 685
___nl__9 = new ImmString("ast");
//line 685
___nl__9 = c_rt_lib_NL.NL_native_to_nl(___nl__8.toString().Equals(___nl__9.toString()));
//line 685
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9));
//line 685
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_10;}}
//line 686
___nl__10 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("ast"));
//line 686
___nl__11 = ___nl__10;
//line 686
((ImmHash)___nl__1).set("language", ___nl__11);
//line 686
___nl__10 = null;
//line 686
___nl__11 = null;
//line 687
if (true) {goto label_7;}
//line 687
label_10:
//line 687
___nl__9 = new ImmString("pm");
//line 687
___nl__9 = c_rt_lib_NL.NL_native_to_nl(___nl__8.toString().Equals(___nl__9.toString()));
//line 687
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9));
//line 687
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_11;}}
//line 688
___nl__10 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("pm"));
//line 688
___nl__11 = ___nl__10;
//line 688
((ImmHash)___nl__1).set("language", ___nl__11);
//line 688
___nl__10 = null;
//line 688
___nl__11 = null;
//line 689
if (true) {goto label_7;}
//line 689
label_11:
//line 689
___nl__9 = new ImmString("c");
//line 689
___nl__9 = c_rt_lib_NL.NL_native_to_nl(___nl__8.toString().Equals(___nl__9.toString()));
//line 689
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9));
//line 689
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_12;}}
//line 690
___nl__10 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("c"));
//line 690
___nl__11 = ___nl__10;
//line 690
((ImmHash)___nl__1).set("language", ___nl__11);
//line 690
___nl__10 = null;
//line 690
___nl__11 = null;
//line 691
if (true) {goto label_7;}
//line 691
label_12:
//line 691
___nl__9 = new ImmString("js");
//line 691
___nl__9 = c_rt_lib_NL.NL_native_to_nl(___nl__8.toString().Equals(___nl__9.toString()));
//line 691
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9));
//line 691
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_13;}}
//line 692
___nl__10 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("js"));
//line 692
___nl__11 = ___nl__10;
//line 692
((ImmHash)___nl__1).set("language", ___nl__11);
//line 692
___nl__10 = null;
//line 692
___nl__11 = null;
//line 693
if (true) {goto label_7;}
//line 693
label_13:
//line 693
___nl__9 = new ImmString("java");
//line 693
___nl__9 = c_rt_lib_NL.NL_native_to_nl(___nl__8.toString().Equals(___nl__9.toString()));
//line 693
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9));
//line 693
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_14;}}
//line 694
___nl__10 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("java"));
//line 694
___nl__11 = ___nl__10;
//line 694
((ImmHash)___nl__1).set("language", ___nl__11);
//line 694
___nl__10 = null;
//line 694
___nl__11 = null;
//line 695
if (true) {goto label_7;}
//line 695
label_14:
//line 695
___nl__9 = new ImmString("cs");
//line 695
___nl__9 = c_rt_lib_NL.NL_native_to_nl(___nl__8.toString().Equals(___nl__9.toString()));
//line 695
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9));
//line 695
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_15;}}
//line 696
___nl__10 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("cs"));
//line 696
___nl__11 = ___nl__10;
//line 696
((ImmHash)___nl__1).set("language", ___nl__11);
//line 696
___nl__10 = null;
//line 696
___nl__11 = null;
//line 697
if (true) {goto label_7;}
//line 697
label_15:
//line 697
___nl__9 = new ImmString("nl");
//line 697
___nl__9 = c_rt_lib_NL.NL_native_to_nl(___nl__8.toString().Equals(___nl__9.toString()));
//line 697
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9));
//line 697
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_16;}}
//line 698
___nl__10 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("nl"));
//line 698
___nl__11 = ___nl__10;
//line 698
((ImmHash)___nl__1).set("language", ___nl__11);
//line 698
___nl__10 = null;
//line 698
___nl__11 = null;
//line 699
___nl__10 = compiler_NL.NL_get_dir_pretty_name_priv();

//line 699
___nl__3 = ___nl__10;
//line 699
___nl__10 = null;
//line 700
if (true) {goto label_7;}
//line 700
label_16:
//line 700
___nl__9 = new ImmString("ide");
//line 700
___nl__9 = c_rt_lib_NL.NL_native_to_nl(___nl__8.toString().Equals(___nl__9.toString()));
//line 700
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9));
//line 700
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_17;}}
//line 701
___nl__10 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("ide"));
//line 701
___nl__11 = ___nl__10;
//line 701
((ImmHash)___nl__1).set("mode", ___nl__11);
//line 701
___nl__10 = null;
//line 701
___nl__11 = null;
//line 702
if (true) {goto label_7;}
//line 702
label_17:
//line 702
___nl__9 = new ImmString("idex");
//line 702
___nl__9 = c_rt_lib_NL.NL_native_to_nl(___nl__8.toString().Equals(___nl__9.toString()));
//line 702
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9));
//line 702
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_18;}}
//line 703
___nl__10 = new ImmDouble(1);
//line 703
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__10.getValue().ToString())));
//line 703
___nl__10 = null;
//line 704
___nl__10 = array_NL.NL_len(___nl__0);

//line 704
___nl__10 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))<(Double.Parse(___nl__10.getValue().ToString())) );
//line 704
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10));
//line 704
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10));
//line 704
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_20;}}
//line 704
___nl__11 = new ImmArray(new Imm[0]);
//line 704
c_rt_lib_NL.NL_die();
//line 704
if (true) {goto label_20;}
//line 704
label_20:
//line 704
___nl__10 = null;
//line 704
___nl__11 = null;
//line 705
___nl__10 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()];
//line 705
___nl__10 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("idex"), ___nl__10);
//line 705
___nl__11 = ___nl__10;
//line 705
((ImmHash)___nl__1).set("mode", ___nl__11);
//line 705
___nl__10 = null;
//line 705
___nl__11 = null;
//line 706
if (true) {goto label_7;}
//line 706
label_18:
//line 706
___nl__9 = new ImmString("strict");
//line 706
___nl__9 = c_rt_lib_NL.NL_native_to_nl(___nl__8.toString().Equals(___nl__9.toString()));
//line 706
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9));
//line 706
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_21;}}
//line 707
___nl__10 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("strict"));
//line 707
___nl__11 = ___nl__10;
//line 707
((ImmHash)___nl__1).set("mode", ___nl__11);
//line 707
___nl__10 = null;
//line 707
___nl__11 = null;
//line 708
if (true) {goto label_7;}
//line 708
label_21:
//line 708
___nl__9 = new ImmString("exec");
//line 708
___nl__9 = c_rt_lib_NL.NL_native_to_nl(___nl__8.toString().Equals(___nl__9.toString()));
//line 708
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9));
//line 708
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_22;}}
//line 709
___nl__10 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("exec"));
//line 709
___nl__11 = ___nl__10;
//line 709
((ImmHash)___nl__1).set("mode", ___nl__11);
//line 709
___nl__10 = null;
//line 709
___nl__11 = null;
//line 710
if (true) {goto label_7;}
//line 710
label_22:
//line 710
___nl__9 = new ImmString("o");
//line 710
___nl__9 = c_rt_lib_NL.NL_native_to_nl(___nl__8.toString().Equals(___nl__9.toString()));
//line 710
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_24;}}
//line 710
___nl__9 = new ImmString("out");
//line 710
___nl__9 = c_rt_lib_NL.NL_native_to_nl(___nl__8.toString().Equals(___nl__9.toString()));
//line 710
label_24:
//line 710
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9));
//line 710
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_23;}}
//line 711
___nl__10 = new ImmDouble(1);
//line 711
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__10.getValue().ToString())));
//line 711
___nl__10 = null;
//line 712
___nl__10 = array_NL.NL_len(___nl__0);

//line 712
___nl__10 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))<(Double.Parse(___nl__10.getValue().ToString())) );
//line 712
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10));
//line 712
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10));
//line 712
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_26;}}
//line 712
___nl__11 = new ImmArray(new Imm[0]);
//line 712
c_rt_lib_NL.NL_die();
//line 712
if (true) {goto label_26;}
//line 712
label_26:
//line 712
___nl__10 = null;
//line 712
___nl__11 = null;
//line 713
___nl__10 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()];
//line 713
___nl__11 = new ImmString("/");
//line 713
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString());
//line 713
___nl__11 = null;
//line 713
___nl__11 = ___nl__10;
//line 713
((ImmHash)___nl__1).set("cache_path", ___nl__11);
//line 713
___nl__10 = null;
//line 713
___nl__11 = null;
//line 714
if (true) {goto label_7;}
//line 714
label_23:
//line 714
___nl__9 = new ImmString("math");
//line 714
___nl__9 = c_rt_lib_NL.NL_native_to_nl(___nl__8.toString().Equals(___nl__9.toString()));
//line 714
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9));
//line 714
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_27;}}
//line 715
___nl__10 = new ImmDouble(1);
//line 715
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__10.getValue().ToString())));
//line 715
___nl__10 = null;
//line 716
___nl__10 = array_NL.NL_len(___nl__0);

//line 716
___nl__10 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))<(Double.Parse(___nl__10.getValue().ToString())) );
//line 716
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10));
//line 716
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10));
//line 716
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_29;}}
//line 716
___nl__11 = new ImmArray(new Imm[0]);
//line 716
c_rt_lib_NL.NL_die();
//line 716
if (true) {goto label_29;}
//line 716
label_29:
//line 716
___nl__10 = null;
//line 716
___nl__11 = null;
//line 717
___nl__10 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()];
//line 717
___nl__11 = ___nl__10;
//line 717
((ImmHash)___nl__1).set("math_fun", ___nl__11);
//line 717
___nl__10 = null;
//line 717
___nl__11 = null;
//line 718
if (true) {goto label_7;}
//line 718
label_27:
//line 718
___nl__9 = new ImmString("O0");
//line 718
___nl__9 = c_rt_lib_NL.NL_native_to_nl(___nl__8.toString().Equals(___nl__9.toString()));
//line 718
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9));
//line 718
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_30;}}
//line 719
___nl__10 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("o0"));
//line 719
___nl__11 = ___nl__10;
//line 719
((ImmHash)___nl__1).set("optimization", ___nl__11);
//line 719
___nl__10 = null;
//line 719
___nl__11 = null;
//line 720
if (true) {goto label_7;}
//line 720
label_30:
//line 720
___nl__9 = new ImmString("O1");
//line 720
___nl__9 = c_rt_lib_NL.NL_native_to_nl(___nl__8.toString().Equals(___nl__9.toString()));
//line 720
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9));
//line 720
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_31;}}
//line 721
___nl__10 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("o1"));
//line 721
___nl__11 = ___nl__10;
//line 721
((ImmHash)___nl__1).set("optimization", ___nl__11);
//line 721
___nl__10 = null;
//line 721
___nl__11 = null;
//line 722
if (true) {goto label_7;}
//line 722
label_31:
//line 722
___nl__9 = new ImmString("O2");
//line 722
___nl__9 = c_rt_lib_NL.NL_native_to_nl(___nl__8.toString().Equals(___nl__9.toString()));
//line 722
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9));
//line 722
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_32;}}
//line 723
___nl__10 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("o2"));
//line 723
___nl__11 = ___nl__10;
//line 723
((ImmHash)___nl__1).set("optimization", ___nl__11);
//line 723
___nl__10 = null;
//line 723
___nl__11 = null;
//line 724
if (true) {goto label_7;}
//line 724
label_32:
//line 724
___nl__9 = new ImmString("O3");
//line 724
___nl__9 = c_rt_lib_NL.NL_native_to_nl(___nl__8.toString().Equals(___nl__9.toString()));
//line 724
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9));
//line 724
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_33;}}
//line 725
___nl__10 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("o3"));
//line 725
___nl__11 = ___nl__10;
//line 725
((ImmHash)___nl__1).set("optimization", ___nl__11);
//line 725
___nl__10 = null;
//line 725
___nl__11 = null;
//line 726
if (true) {goto label_7;}
//line 726
label_33:
//line 726
___nl__9 = new ImmString("O4");
//line 726
___nl__9 = c_rt_lib_NL.NL_native_to_nl(___nl__8.toString().Equals(___nl__9.toString()));
//line 726
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9));
//line 726
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_34;}}
//line 727
___nl__10 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("o4"));
//line 727
___nl__11 = ___nl__10;
//line 727
((ImmHash)___nl__1).set("optimization", ___nl__11);
//line 727
___nl__10 = null;
//line 727
___nl__11 = null;
//line 728
if (true) {goto label_7;}
//line 728
label_34:
//line 728
___nl__9 = new ImmString("Wall");
//line 728
___nl__9 = c_rt_lib_NL.NL_native_to_nl(___nl__8.toString().Equals(___nl__9.toString()));
//line 728
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9));
//line 728
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_35;}}
//line 729
___nl__10 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("wall"));
//line 729
___nl__11 = ___nl__10;
//line 729
((ImmHash)___nl__1).set("alarm", ___nl__11);
//line 729
___nl__10 = null;
//line 729
___nl__11 = null;
//line 730
if (true) {goto label_7;}
//line 730
label_35:
//line 731
___nl__10 = new ImmString("unknown compiler option: ");
//line 731
___nl__10 = new ImmString(___nl__10.toString() + ___nl__6.toString());
//line 731
c_fe_lib_NL.NL_print(___nl__10);

//line 731
___nl__10 = null;
//line 732
if (true) {goto label_7;}
//line 732
label_7:
//line 732
___nl__9 = null;
//line 732
___nl__8 = null;
//line 733
if (true) {goto label_4;}
//line 733
label_5:
//line 734
___nl__8 = ___nl__2;
//line 734
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8));
//line 734
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8));
//line 734
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_37;}}
//line 734
___nl__9 = new ImmArray(new Imm[0]);
//line 734
___nl__10 = ___nl__9;
//line 734
((ImmHash)___nl__1).set("input_path", ___nl__10);
//line 734
___nl__9 = null;
//line 734
___nl__10 = null;
//line 734
if (true) {goto label_37;}
//line 734
label_37:
//line 734
___nl__8 = null;
//line 735
___nl__8 = new ImmString("input_path");
//line 735
___nl__8 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__8);

//line 735
___ref______nl__8 = new ImmRef(___nl__8);
array_NL.NL_push(___ref______nl__8,___nl__6);
___nl__8 = ___ref______nl__8.getValue();

//line 735
___nl__9 = new ImmString("input_path");
//line 735
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__9,___nl__8);
___nl__1 = ___ref______nl__1.getValue();

//line 735
___nl__9 = null;
//line 735
___nl__8 = null;
//line 736
___nl__8 = c_rt_lib_NL.NL_get_true();
//line 736
___nl__2 = ___nl__8;
//line 736
___nl__8 = null;
//line 737
if (true) {goto label_4;}
//line 737
label_4:
//line 737
___nl__7 = null;
//line 737
___nl__6 = null;
//line 737
___nl__6 = new ImmDouble(1);
//line 737
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString())));
//line 737
___nl__6 = null;
//line 738
if (true) {goto label_2;}
//line 738
label_1:
//line 738
___nl__4 = null;
//line 738
___nl__5 = null;
//line 739
___nl__4 = ((ImmHash)___nl__1).getHashValue()["cache_path"];
//line 739
___nl__5 = new ImmString("");
//line 739
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__4.toString().Equals(___nl__5.toString()));
//line 739
___nl__5 = null;
//line 739
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 739
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_39;}}
//line 740
___nl__5 = new ImmString("./");
//line 740
___nl__5 = new ImmString(___nl__5.toString() + ___nl__3.toString());
//line 740
___nl__6 = new ImmString("/");
//line 740
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 740
___nl__6 = null;
//line 740
___nl__6 = ___nl__5;
//line 740
((ImmHash)___nl__1).set("cache_path", ___nl__6);
//line 740
___nl__5 = null;
//line 740
___nl__6 = null;
//line 741
if (true) {goto label_39;}
//line 741
label_39:
//line 741
___nl__4 = null;
//line 742
___nl__4 = ((ImmHash)___nl__1).getHashValue()["deref"];
//line 742
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("yes"));
//line 742
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 742
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_41;}}
//line 742
___nl__5 = ((ImmHash)___nl__1).getHashValue()["cache_path"];
//line 742
___nl__6 = compiler_NL.NL_get_default_deref_file_priv();

//line 742
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 742
___nl__6 = null;
//line 742
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("yes"), ___nl__5);
//line 742
___nl__6 = ___nl__5;
//line 742
((ImmHash)___nl__1).set("deref", ___nl__6);
//line 742
___nl__5 = null;
//line 742
___nl__6 = null;
//line 742
if (true) {goto label_41;}
//line 742
label_41:
//line 742
___nl__4 = null;
//line 743
___nl__4 = dfile_NL.NL_ssave(___nl__1);

//line 743
nl_NL.NL_print(___nl__4);

//line 743
___nl__4 = null;
//line 744
___nl__0 = null;
//line 744
___nl__2 = null;
//line 744
___nl__3 = null;
//line 744
if(true) return ___nl__1;
//line 744
___nl__1 = null;
//line 744
___nl__2 = null;
//line 744
___nl__3 = null;
//line 744
___nl__0 = null;
//line 744
if(true) return null;
}

}
}