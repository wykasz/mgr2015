using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class nparser_NL {

private static Imm NL_SINGLETON_get_end_list_priv() {

Imm ___nl__0 = null;
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
//line 17
___nl__2 = new ImmString(";");
//line 17
___nl__3 = new ImmString("if");
//line 17
___nl__4 = new ImmString("unless");
//line 17
___nl__5 = new ImmString("fora");
//line 17
___nl__6 = new ImmString("forh");
//line 17
___nl__7 = new ImmString("rep");
//line 17
___nl__8 = new ImmString("while");
//line 17
___nl__1 = new ImmArray(new Imm[] {___nl__2,___nl__3,___nl__4,___nl__5,___nl__6,___nl__7,___nl__8,});
//line 17
___nl__2 = null;
//line 17
___nl__3 = null;
//line 17
___nl__4 = null;
//line 17
___nl__5 = null;
//line 17
___nl__6 = null;
//line 17
___nl__7 = null;
//line 17
___nl__8 = null;
//line 17
___nl__0 = singleton_NL.NL_sigleton_do_not_use_without_approval(___nl__1);

//line 17
___nl__1 = null;
//line 17
if(true) return ___nl__0;
//line 17
___nl__0 = null;
//line 17
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_get_end_list_priv = null;
private static Imm NL_get_end_list_priv() {
	if (value__singleton__NL_SINGLETON_get_end_list_priv == null) {
		value__singleton__NL_SINGLETON_get_end_list_priv = NL_SINGLETON_get_end_list_priv();
	}
	return value__singleton__NL_SINGLETON_get_end_list_priv;
}
public static Imm NL_SINGLETON_parse_ret_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 21
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("module_t"));
___nl__2 = new ImmHash(__function_map);
//line 21
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2);
//line 21
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nparser_NL"));
__function_map.Add("name",new ImmString("errors_t"));
___nl__3 = new ImmHash(__function_map);
//line 21
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3);
//line 21
__function_map = new Dictionary<String, Imm>();
__function_map.Add("ok",___nl__2);
__function_map.Add("error",___nl__3);
___nl__1 = new ImmHash(__function_map);
//line 21
___nl__2 = null;
//line 21
___nl__3 = null;
//line 21
___nl__0 = ptd_NL.NL_var(___nl__1);

//line 21
___nl__1 = null;
//line 21
if(true) return ___nl__0;
//line 21
___nl__0 = null;
//line 21
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_parse_ret_t = null;
public static Imm NL_parse_ret_t() {
	if (value__singleton__NL_SINGLETON_parse_ret_t == null) {
		value__singleton__NL_SINGLETON_parse_ret_t = NL_SINGLETON_parse_ret_t();
	}
	return value__singleton__NL_SINGLETON_parse_ret_t;
}
public static Imm NL_SINGLETON_state_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 25
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("ntokenizer_NL"));
__function_map.Add("name",new ImmString("state_t"));
___nl__2 = new ImmHash(__function_map);
//line 25
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2);
//line 25
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nparser_NL"));
__function_map.Add("name",new ImmString("errors_t"));
___nl__3 = new ImmHash(__function_map);
//line 25
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3);
//line 25
__function_map = new Dictionary<String, Imm>();
__function_map.Add("state",___nl__2);
__function_map.Add("errors",___nl__3);
___nl__1 = new ImmHash(__function_map);
//line 25
___nl__2 = null;
//line 25
___nl__3 = null;
//line 25
___nl__0 = ptd_NL.NL_rec(___nl__1);

//line 25
___nl__1 = null;
//line 25
if(true) return ___nl__0;
//line 25
___nl__0 = null;
//line 25
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_state_t = null;
public static Imm NL_state_t() {
	if (value__singleton__NL_SINGLETON_state_t == null) {
		value__singleton__NL_SINGLETON_state_t = NL_SINGLETON_state_t();
	}
	return value__singleton__NL_SINGLETON_state_t;
}
public static Imm NL_SINGLETON_try_value_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 32
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("value_t"));
___nl__2 = new ImmHash(__function_map);
//line 32
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2);
//line 32
___nl__3 = ptd_NL.NL_sim();

//line 32
__function_map = new Dictionary<String, Imm>();
__function_map.Add("ok",___nl__2);
__function_map.Add("err",___nl__3);
___nl__1 = new ImmHash(__function_map);
//line 32
___nl__2 = null;
//line 32
___nl__3 = null;
//line 32
___nl__0 = ptd_NL.NL_var(___nl__1);

//line 32
___nl__1 = null;
//line 32
if(true) return ___nl__0;
//line 32
___nl__0 = null;
//line 32
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_try_value_t = null;
public static Imm NL_try_value_t() {
	if (value__singleton__NL_SINGLETON_try_value_t == null) {
		value__singleton__NL_SINGLETON_try_value_t = NL_SINGLETON_try_value_t();
	}
	return value__singleton__NL_SINGLETON_try_value_t;
}
public static Imm NL_SINGLETON_try_cmd_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 35
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("cmd_t"));
___nl__2 = new ImmHash(__function_map);
//line 35
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2);
//line 35
___nl__3 = ptd_NL.NL_sim();

//line 35
__function_map = new Dictionary<String, Imm>();
__function_map.Add("ok",___nl__2);
__function_map.Add("err",___nl__3);
___nl__1 = new ImmHash(__function_map);
//line 35
___nl__2 = null;
//line 35
___nl__3 = null;
//line 35
___nl__0 = ptd_NL.NL_var(___nl__1);

//line 35
___nl__1 = null;
//line 35
if(true) return ___nl__0;
//line 35
___nl__0 = null;
//line 35
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_try_cmd_t = null;
public static Imm NL_try_cmd_t() {
	if (value__singleton__NL_SINGLETON_try_cmd_t == null) {
		value__singleton__NL_SINGLETON_try_cmd_t = NL_SINGLETON_try_cmd_t();
	}
	return value__singleton__NL_SINGLETON_try_cmd_t;
}
public static Imm NL_sparse(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();
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
//line 39
___nl__3 = new ImmArray(new Imm[0]);
//line 39
___nl__4 = ntokenizer_NL.NL_init(___nl__0);

//line 39
__function_map = new Dictionary<String, Imm>();
__function_map.Add("errors",___nl__3);
__function_map.Add("state",___nl__4);
___nl__2 = new ImmHash(__function_map);
//line 39
___nl__3 = null;
//line 39
___nl__4 = null;
//line 40
___ref______nl__2 = new ImmRef(___nl__2);
___nl__3 = nparser_NL.NL_parse_module_priv(___ref______nl__2,___nl__1);
___nl__2 = ___ref______nl__2.getValue();

//line 41
___nl__5 = ((ImmHash)___nl__2).getHashValue()["errors"];
//line 41
___nl__4 = array_NL.NL_len(___nl__5);

//line 41
___nl__5 = null;
//line 41
___nl__5 = new ImmDouble(0);
//line 41
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>(Double.Parse(___nl__5.getValue().ToString())) );
//line 41
___nl__5 = null;
//line 41
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 41
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 41
___nl__5 = ((ImmHash)___nl__2).getHashValue()["errors"];
//line 41
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("error"), ___nl__5);
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
if(true) return ___nl__5;
//line 41
___nl__5 = null;
//line 41
if (true) {goto label_2;}
//line 41
label_2:
//line 41
___nl__4 = null;
//line 42
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__3);
//line 42
___nl__0 = null;
//line 42
___nl__1 = null;
//line 42
___nl__2 = null;
//line 42
___nl__3 = null;
//line 42
if(true) return ___nl__4;
//line 42
___nl__4 = null;
//line 42
___nl__2 = null;
//line 42
___nl__3 = null;
//line 42
___nl__0 = null;
//line 42
___nl__1 = null;
//line 42
if(true) return null;
}

public static Imm NL_SINGLETON_errors_t() {

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
//line 46
___nl__3 = ptd_NL.NL_sim();

//line 46
___nl__4 = ptd_NL.NL_sim();

//line 46
__function_map = new Dictionary<String, Imm>();
__function_map.Add("line",___nl__3);
__function_map.Add("msg",___nl__4);
___nl__2 = new ImmHash(__function_map);
//line 46
___nl__3 = null;
//line 46
___nl__4 = null;
//line 46
___nl__1 = ptd_NL.NL_rec(___nl__2);

//line 46
___nl__2 = null;
//line 46
___nl__0 = ptd_NL.NL_arr(___nl__1);

//line 46
___nl__1 = null;
//line 46
if(true) return ___nl__0;
//line 46
___nl__0 = null;
//line 46
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_errors_t = null;
public static Imm NL_errors_t() {
	if (value__singleton__NL_SINGLETON_errors_t == null) {
		value__singleton__NL_SINGLETON_errors_t = NL_SINGLETON_errors_t();
	}
	return value__singleton__NL_SINGLETON_errors_t;
}
private static Imm NL_add_error_priv(ImmRef ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 50
___nl__3 = new ImmString("state");
//line 50
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__3);

//line 50
___ref______nl__3 = new ImmRef(___nl__3);
___nl__2 = ntokenizer_NL.NL_get_line(___ref______nl__3);
___nl__3 = ___ref______nl__3.getValue();

//line 50
___nl__4 = new ImmString("state");
//line 50
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__4,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 50
___nl__4 = null;
//line 50
___nl__3 = null;
//line 51
___nl__3 = new ImmString("errors");
//line 51
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__3);

//line 51
__function_map = new Dictionary<String, Imm>();
__function_map.Add("line",___nl__2);
__function_map.Add("msg",___nl__1);
___nl__4 = new ImmHash(__function_map);
//line 51
___ref______nl__3 = new ImmRef(___nl__3);
array_NL.NL_push(___ref______nl__3,___nl__4);
___nl__3 = ___ref______nl__3.getValue();

//line 51
___nl__4 = null;
//line 51
___nl__4 = new ImmString("errors");
//line 51
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__4,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 51
___nl__4 = null;
//line 51
___nl__3 = null;
//line 51
___nl__2 = null;
//line 51
___nl__1 = null;
//line 51
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_eat_priv(ImmRef ___arg__0, Imm ___arg__1) {
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
//line 55
___nl__3 = new ImmString("state");
//line 55
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__3);

//line 55
___ref______nl__3 = new ImmRef(___nl__3);
___nl__2 = ntokenizer_NL.NL_eat_token(___ref______nl__3,___nl__1);
___nl__3 = ___ref______nl__3.getValue();

//line 55
___nl__4 = new ImmString("state");
//line 55
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__4,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 55
___nl__4 = null;
//line 55
___nl__3 = null;
//line 55
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 55
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 55
___nl__3 = c_rt_lib_NL.NL_get_true();
//line 55
___nl__1 = null;
//line 55
___nl__2 = null;
//line 55
___arg__0.setValue(___nl__0);if(true) return ___nl__3;
//line 55
___nl__3 = null;
//line 55
if (true) {goto label_2;}
//line 55
label_2:
//line 55
___nl__2 = null;
//line 56
___nl__2 = new ImmString("expected: ");
//line 56
___nl__2 = new ImmString(___nl__2.toString() + ___nl__1.toString());
//line 56
___nl__3 = string_NL.NL_lf();

//line 56
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 56
___nl__3 = null;
//line 56
___nl__4 = new ImmString("state");
//line 56
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__4);

//line 56
___ref______nl__4 = new ImmRef(___nl__4);
___nl__3 = ntokenizer_NL.NL_info(___ref______nl__4);
___nl__4 = ___ref______nl__4.getValue();

//line 56
___nl__5 = new ImmString("state");
//line 56
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 56
___nl__5 = null;
//line 56
___nl__4 = null;
//line 56
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 56
___nl__3 = null;
//line 56
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_add_error_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 56
___nl__2 = null;
//line 57
___nl__2 = c_rt_lib_NL.NL_get_false();
//line 57
___nl__1 = null;
//line 57
___arg__0.setValue(___nl__0);if(true) return ___nl__2;
//line 57
___nl__2 = null;
//line 57
___nl__1 = null;
//line 57
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_try_eat_priv(ImmRef ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 61
___nl__3 = new ImmString("state");
//line 61
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__3);

//line 61
___ref______nl__3 = new ImmRef(___nl__3);
___nl__2 = ntokenizer_NL.NL_eat_token(___ref______nl__3,___nl__1);
___nl__3 = ___ref______nl__3.getValue();

//line 61
___nl__4 = new ImmString("state");
//line 61
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__4,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 61
___nl__4 = null;
//line 61
___nl__3 = null;
//line 61
___nl__1 = null;
//line 61
___arg__0.setValue(___nl__0);if(true) return ___nl__2;
//line 61
___nl__2 = null;
//line 61
___nl__1 = null;
//line 61
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_parse_module_priv(ImmRef ___arg__0, Imm ___arg__1) {
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
//line 65
___nl__3 = new ImmArray(new Imm[0]);
//line 65
___nl__4 = new ImmArray(new Imm[0]);
//line 65
__function_map = new Dictionary<String, Imm>();
__function_map.Add("name",___nl__1);
__function_map.Add("import",___nl__3);
__function_map.Add("fun_def",___nl__4);
___nl__2 = new ImmHash(__function_map);
//line 65
___nl__3 = null;
//line 65
___nl__4 = null;
//line 66
label_2:
//line 66
___nl__4 = new ImmString("use");
//line 66
___ref______nl__0 = new ImmRef(___nl__0);
___nl__3 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 66
___nl__4 = null;
//line 66
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 66
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_1;}}
//line 67
___nl__5 = new ImmString("state");
//line 67
___nl__5 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__5);

//line 67
___ref______nl__5 = new ImmRef(___nl__5);
___nl__4 = ntokenizer_NL.NL_get_line(___ref______nl__5);
___nl__5 = ___ref______nl__5.getValue();

//line 67
___nl__6 = new ImmString("state");
//line 67
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__6,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 67
___nl__6 = null;
//line 67
___nl__5 = null;
//line 68
___nl__6 = new ImmString("state");
//line 68
___nl__6 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__6);

//line 68
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("word"));
//line 68
___ref______nl__6 = new ImmRef(___nl__6);
___nl__5 = ntokenizer_NL.NL_is_type(___ref______nl__6,___nl__7);
___nl__6 = ___ref______nl__6.getValue();

//line 68
___nl__7 = null;
//line 68
___nl__7 = new ImmString("state");
//line 68
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__7,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

//line 68
___nl__7 = null;
//line 68
___nl__6 = null;
//line 68
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 68
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_4;}}
//line 69
___nl__6 = new ImmString("import");
//line 69
___nl__6 = c_rt_lib_NL.NL_get_ref_hash(___nl__2,___nl__6);

//line 69
___nl__9 = new ImmString("state");
//line 69
___nl__9 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__9);

//line 69
___nl__10 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("word"));
//line 69
___ref______nl__9 = new ImmRef(___nl__9);
___nl__8 = ntokenizer_NL.NL_eat_type(___ref______nl__9,___nl__10);
___nl__9 = ___ref______nl__9.getValue();

//line 69
___nl__10 = null;
//line 69
___nl__10 = new ImmString("state");
//line 69
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__10,___nl__9);
___nl__0 = ___ref______nl__0.getValue();

//line 69
___nl__10 = null;
//line 69
___nl__9 = null;
//line 69
__function_map = new Dictionary<String, Imm>();
__function_map.Add("name",___nl__8);
__function_map.Add("line",___nl__4);
___nl__7 = new ImmHash(__function_map);
//line 69
___nl__8 = null;
//line 69
___ref______nl__6 = new ImmRef(___nl__6);
array_NL.NL_push(___ref______nl__6,___nl__7);
___nl__6 = ___ref______nl__6.getValue();

//line 69
___nl__7 = null;
//line 69
___nl__7 = new ImmString("import");
//line 69
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__2,___nl__7,___nl__6);
___nl__2 = ___ref______nl__2.getValue();

//line 69
___nl__7 = null;
//line 69
___nl__6 = null;
//line 70
if (true) {goto label_3;}
//line 70
label_4:
//line 71
___nl__6 = new ImmString("expected word as name of module");
//line 71
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_add_error_priv(___ref______nl__0,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

//line 71
___nl__6 = null;
//line 72
if (true) {goto label_3;}
//line 72
label_3:
//line 72
___nl__5 = null;
//line 73
___nl__5 = new ImmString(";");
//line 73
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 73
___nl__5 = null;
//line 73
___nl__4 = null;
//line 74
if (true) {goto label_2;}
//line 74
label_1:
//line 74
___nl__3 = null;
//line 76
label_6:
//line 76
___nl__4 = new ImmString("state");
//line 76
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__4);

//line 76
___nl__5 = new ImmString("def");
//line 76
___ref______nl__4 = new ImmRef(___nl__4);
___nl__3 = ntokenizer_NL.NL_next_is(___ref______nl__4,___nl__5);
___nl__4 = ___ref______nl__4.getValue();

//line 76
___nl__5 = null;
//line 76
___nl__5 = new ImmString("state");
//line 76
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 76
___nl__5 = null;
//line 76
___nl__4 = null;
//line 76
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 76
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_5;}}
//line 77
___ref______nl__0 = new ImmRef(___nl__0);
___nl__4 = nparser_NL.NL_parse_fun_def_priv(___ref______nl__0,___nl__1);
___nl__0 = ___ref______nl__0.getValue();

//line 77
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("ok"));
//line 77
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_8;}}
//line 79
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("err"));
//line 79
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_9;}}
//line 79
___nl__5 = new ImmString("NOMATCHALERT");
//line 79
___nl__5 = new ImmArray(new Imm[] {___nl__5,___nl__4,});
//line 79
c_rt_lib_NL.NL_die();
//line 77
label_8:
//line 77
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("ok"));
//line 78
___nl__7 = new ImmString("fun_def");
//line 78
___nl__7 = c_rt_lib_NL.NL_get_ref_hash(___nl__2,___nl__7);

//line 78
___ref______nl__7 = new ImmRef(___nl__7);
array_NL.NL_push(___ref______nl__7,___nl__6);
___nl__7 = ___ref______nl__7.getValue();

//line 78
___nl__8 = new ImmString("fun_def");
//line 78
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__2,___nl__8,___nl__7);
___nl__2 = ___ref______nl__2.getValue();

//line 78
___nl__8 = null;
//line 78
___nl__7 = null;
//line 78
___nl__6 = null;
//line 79
if (true) {goto label_7;}
//line 79
label_9:
//line 79
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("err"));
//line 80
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_add_error_priv(___ref______nl__0,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

//line 81
___nl__1 = null;
//line 81
___nl__3 = null;
//line 81
___nl__4 = null;
//line 81
___nl__5 = null;
//line 81
___nl__6 = null;
//line 81
___arg__0.setValue(___nl__0);if(true) return ___nl__2;
//line 81
___nl__6 = null;
//line 82
if (true) {goto label_7;}
//line 82
label_7:
//line 82
___nl__4 = null;
//line 82
___nl__5 = null;
//line 83
if (true) {goto label_6;}
//line 83
label_5:
//line 83
___nl__3 = null;
//line 85
___nl__4 = new ImmString("state");
//line 85
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__4);

//line 85
___nl__5 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("end"));
//line 85
___ref______nl__4 = new ImmRef(___nl__4);
___nl__3 = ntokenizer_NL.NL_is_type(___ref______nl__4,___nl__5);
___nl__4 = ___ref______nl__4.getValue();

//line 85
___nl__5 = null;
//line 85
___nl__5 = new ImmString("state");
//line 85
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 85
___nl__5 = null;
//line 85
___nl__4 = null;
//line 85
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 85
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 85
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_11;}}
//line 85
___nl__4 = new ImmString("expected function definition");
//line 85
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_add_error_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 85
___nl__4 = null;
//line 85
if (true) {goto label_11;}
//line 85
label_11:
//line 85
___nl__3 = null;
//line 86
___nl__1 = null;
//line 86
___arg__0.setValue(___nl__0);if(true) return ___nl__2;
//line 86
___nl__2 = null;
//line 86
___nl__1 = null;
//line 86
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_parse_fun_arg_list_priv(ImmRef ___arg__0) {
Imm ___nl__0 = ___arg__0.getValue().clone();
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
//line 90
___nl__1 = new ImmString("(");
//line 90
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__1);
___nl__0 = ___ref______nl__0.getValue();

//line 90
___nl__1 = null;
//line 91
___nl__1 = new ImmArray(new Imm[0]);
//line 92
label_2:
//line 92
___nl__3 = new ImmString("state");
//line 92
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__3);

//line 92
___nl__4 = new ImmString(")");
//line 92
___ref______nl__3 = new ImmRef(___nl__3);
___nl__2 = ntokenizer_NL.NL_next_is(___ref______nl__3,___nl__4);
___nl__3 = ___ref______nl__3.getValue();

//line 92
___nl__4 = null;
//line 92
___nl__4 = new ImmString("state");
//line 92
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__4,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 92
___nl__4 = null;
//line 92
___nl__3 = null;
//line 92
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 92
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 92
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_1;}}
//line 93
___nl__4 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none"));
//line 93
___nl__5 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none"));
//line 93
___nl__6 = new ImmString("");
//line 93
__function_map = new Dictionary<String, Imm>();
__function_map.Add("mod",___nl__4);
__function_map.Add("type",___nl__5);
__function_map.Add("name",___nl__6);
___nl__3 = new ImmHash(__function_map);
//line 93
___nl__4 = null;
//line 93
___nl__5 = null;
//line 93
___nl__6 = null;
//line 94
___nl__5 = new ImmString("ref");
//line 94
___ref______nl__0 = new ImmRef(___nl__0);
___nl__4 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 94
___nl__5 = null;
//line 94
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 94
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_4;}}
//line 94
___nl__5 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("ref"));
//line 94
___nl__6 = ___nl__5;
//line 94
((ImmHash)___nl__3).set("mod", ___nl__6);
//line 94
___nl__5 = null;
//line 94
___nl__6 = null;
//line 94
if (true) {goto label_4;}
//line 94
label_4:
//line 94
___nl__4 = null;
//line 96
___nl__5 = new ImmString("state");
//line 96
___nl__5 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__5);

//line 96
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("word"));
//line 96
___ref______nl__5 = new ImmRef(___nl__5);
___nl__4 = ntokenizer_NL.NL_is_type(___ref______nl__5,___nl__6);
___nl__5 = ___ref______nl__5.getValue();

//line 96
___nl__6 = null;
//line 96
___nl__6 = new ImmString("state");
//line 96
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__6,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 96
___nl__6 = null;
//line 96
___nl__5 = null;
//line 96
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 96
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_6;}}
//line 97
___nl__6 = new ImmString("state");
//line 97
___nl__6 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__6);

//line 97
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("word"));
//line 97
___ref______nl__6 = new ImmRef(___nl__6);
___nl__5 = ntokenizer_NL.NL_eat_type(___ref______nl__6,___nl__7);
___nl__6 = ___ref______nl__6.getValue();

//line 97
___nl__7 = null;
//line 97
___nl__7 = new ImmString("state");
//line 97
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__7,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

//line 97
___nl__7 = null;
//line 97
___nl__6 = null;
//line 97
___nl__6 = ___nl__5;
//line 97
((ImmHash)___nl__3).set("name", ___nl__6);
//line 97
___nl__5 = null;
//line 97
___nl__6 = null;
//line 98
if (true) {goto label_5;}
//line 98
label_6:
//line 99
___nl__5 = new ImmString("word expected as fun arg name");
//line 99
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_add_error_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 99
___nl__5 = null;
//line 100
if (true) {goto label_5;}
//line 100
label_5:
//line 100
___nl__4 = null;
//line 101
___nl__5 = new ImmString(":");
//line 101
___ref______nl__0 = new ImmRef(___nl__0);
___nl__4 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 101
___nl__5 = null;
//line 101
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 101
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_8;}}
//line 102
___ref______nl__0 = new ImmRef(___nl__0);
___nl__7 = nparser_NL.NL_parse_type_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 102
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("ok"));
//line 102
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_9;}}
//line 102
___nl__1 = null;
//line 102
___nl__2 = null;
//line 102
___nl__3 = null;
//line 102
___nl__4 = null;
//line 102
___nl__5 = null;
//line 102
___nl__6 = null;
//line 102
___arg__0.setValue(___nl__0);if(true) return ___nl__7;
//line 102
label_9:
//line 102
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__7, new ImmString("ok"));
//line 102
___nl__6 = null;
//line 102
___nl__7 = null;
//line 103
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("type"), ___nl__5);
//line 103
___nl__7 = ___nl__6;
//line 103
((ImmHash)___nl__3).set("type", ___nl__7);
//line 103
___nl__6 = null;
//line 103
___nl__7 = null;
//line 103
___nl__5 = null;
//line 104
if (true) {goto label_8;}
//line 104
label_8:
//line 104
___nl__4 = null;
//line 105
___ref______nl__1 = new ImmRef(___nl__1);
array_NL.NL_push(___ref______nl__1,___nl__3);
___nl__1 = ___ref______nl__1.getValue();

//line 106
___nl__5 = new ImmString(",");
//line 106
___ref______nl__0 = new ImmRef(___nl__0);
___nl__4 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 106
___nl__5 = null;
//line 106
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 106
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 106
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_11;}}
//line 106
___nl__3 = null;
//line 106
___nl__4 = null;
//line 106
if (true) {goto label_1;}
//line 106
if (true) {goto label_11;}
//line 106
label_11:
//line 106
___nl__4 = null;
//line 106
___nl__3 = null;
//line 107
if (true) {goto label_2;}
//line 107
label_1:
//line 107
___nl__2 = null;
//line 108
___nl__2 = new ImmString(")");
//line 108
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 108
___nl__2 = null;
//line 109
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__1);
//line 109
___nl__1 = null;
//line 109
___arg__0.setValue(___nl__0);if(true) return ___nl__2;
//line 109
___nl__2 = null;
//line 109
___nl__1 = null;
//line 109
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_parse_fun_def_priv(ImmRef ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.clone();
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
//line 113
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none"));
//line 113
___nl__5 = new ImmString("state");
//line 113
___nl__5 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__5);

//line 113
___ref______nl__5 = new ImmRef(___nl__5);
___nl__4 = ntokenizer_NL.NL_get_line(___ref______nl__5);
___nl__5 = ___ref______nl__5.getValue();

//line 113
___nl__6 = new ImmString("state");
//line 113
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__6,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 113
___nl__6 = null;
//line 113
___nl__5 = null;
//line 113
___nl__5 = new ImmArray(new Imm[0]);
//line 113
___nl__6 = new ImmString("");
//line 113
___nl__8 = nast_NL.NL_empty_debug();

//line 113
___nl__9 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("nop"));
//line 113
__function_map = new Dictionary<String, Imm>();
__function_map.Add("debug",___nl__8);
__function_map.Add("cmd",___nl__9);
___nl__7 = new ImmHash(__function_map);
//line 113
___nl__8 = null;
//line 113
___nl__9 = null;
//line 113
___nl__8 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("priv"));
//line 113
__function_map = new Dictionary<String, Imm>();
__function_map.Add("ret_type",___nl__3);
__function_map.Add("line",___nl__4);
__function_map.Add("args",___nl__5);
__function_map.Add("name",___nl__6);
__function_map.Add("cmd",___nl__7);
__function_map.Add("access",___nl__8);
___nl__2 = new ImmHash(__function_map);
//line 113
___nl__3 = null;
//line 113
___nl__4 = null;
//line 113
___nl__5 = null;
//line 113
___nl__6 = null;
//line 113
___nl__7 = null;
//line 113
___nl__8 = null;
//line 121
___nl__3 = new ImmString("def");
//line 121
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 121
___nl__3 = null;
//line 122
___ref______nl__0 = new ImmRef(___nl__0);
___nl__4 = nparser_NL.NL_eat_text_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 122
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("ok"));
//line 122
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_1;}}
//line 122
___nl__1 = null;
//line 122
___nl__2 = null;
//line 122
___nl__3 = null;
//line 122
___arg__0.setValue(___nl__0);if(true) return ___nl__4;
//line 122
label_1:
//line 122
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("ok"));
//line 122
((ImmHash)___nl__2).set("name", ___nl__5);
//line 122
___nl__3 = null;
//line 122
___nl__4 = null;
//line 122
___nl__5 = null;
//line 123
___nl__4 = new ImmString("::");
//line 123
___ref______nl__0 = new ImmRef(___nl__0);
___nl__3 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 123
___nl__4 = null;
//line 123
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 123
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 124
___nl__4 = ((ImmHash)___nl__2).getHashValue()["name"];
//line 124
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!___nl__4.toString().Equals(___nl__1.toString()));
//line 124
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 124
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_5;}}
//line 125
___nl__5 = new ImmString("incorrect module name: ");
//line 125
___nl__6 = ((ImmHash)___nl__2).getHashValue()["name"];
//line 125
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 125
___nl__6 = null;
//line 125
___nl__6 = new ImmString(" of function, expected: ");
//line 125
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 125
___nl__6 = null;
//line 125
___nl__5 = new ImmString(___nl__5.toString() + ___nl__1.toString());
//line 125
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_add_error_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 125
___nl__5 = null;
//line 126
if (true) {goto label_5;}
//line 126
label_5:
//line 126
___nl__4 = null;
//line 127
___ref______nl__0 = new ImmRef(___nl__0);
___nl__5 = nparser_NL.NL_eat_text_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 127
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("ok"));
//line 127
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_6;}}
//line 127
___nl__1 = null;
//line 127
___nl__2 = null;
//line 127
___nl__3 = null;
//line 127
___nl__4 = null;
//line 127
___arg__0.setValue(___nl__0);if(true) return ___nl__5;
//line 127
label_6:
//line 127
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("ok"));
//line 127
((ImmHash)___nl__2).set("name", ___nl__6);
//line 127
___nl__4 = null;
//line 127
___nl__5 = null;
//line 127
___nl__6 = null;
//line 128
___nl__4 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("pub"));
//line 128
___nl__5 = ___nl__4;
//line 128
((ImmHash)___nl__2).set("access", ___nl__5);
//line 128
___nl__4 = null;
//line 128
___nl__5 = null;
//line 129
if (true) {goto label_3;}
//line 129
label_3:
//line 129
___nl__3 = null;
//line 130
___ref______nl__0 = new ImmRef(___nl__0);
___nl__4 = nparser_NL.NL_parse_fun_arg_list_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 130
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("ok"));
//line 130
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_7;}}
//line 130
___nl__1 = null;
//line 130
___nl__2 = null;
//line 130
___nl__3 = null;
//line 130
___arg__0.setValue(___nl__0);if(true) return ___nl__4;
//line 130
label_7:
//line 130
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("ok"));
//line 130
((ImmHash)___nl__2).set("args", ___nl__5);
//line 130
___nl__3 = null;
//line 130
___nl__4 = null;
//line 130
___nl__5 = null;
//line 131
___nl__4 = new ImmString("state");
//line 131
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__4);

//line 131
___nl__5 = new ImmString(":");
//line 131
___ref______nl__4 = new ImmRef(___nl__4);
___nl__3 = ntokenizer_NL.NL_next_is(___ref______nl__4,___nl__5);
___nl__4 = ___ref______nl__4.getValue();

//line 131
___nl__5 = null;
//line 131
___nl__5 = new ImmString("state");
//line 131
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 131
___nl__5 = null;
//line 131
___nl__4 = null;
//line 131
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 131
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_9;}}
//line 132
___nl__4 = new ImmString(":");
//line 132
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 132
___nl__4 = null;
//line 133
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = nparser_NL.NL_parse_type_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 133
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("ok"));
//line 133
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_10;}}
//line 133
___nl__1 = null;
//line 133
___nl__2 = null;
//line 133
___nl__3 = null;
//line 133
___nl__4 = null;
//line 133
___nl__5 = null;
//line 133
___arg__0.setValue(___nl__0);if(true) return ___nl__6;
//line 133
label_10:
//line 133
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("ok"));
//line 133
___nl__5 = null;
//line 133
___nl__6 = null;
//line 134
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("type"), ___nl__4);
//line 134
___nl__6 = ___nl__5;
//line 134
((ImmHash)___nl__2).set("ret_type", ___nl__6);
//line 134
___nl__5 = null;
//line 134
___nl__6 = null;
//line 134
___nl__4 = null;
//line 135
if (true) {goto label_9;}
//line 135
label_9:
//line 135
___nl__3 = null;
//line 137
___ref______nl__0 = new ImmRef(___nl__0);
___nl__4 = nparser_NL.NL_parse_block_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 137
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("ok"));
//line 137
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_11;}}
//line 137
___nl__1 = null;
//line 137
___nl__2 = null;
//line 137
___nl__3 = null;
//line 137
___arg__0.setValue(___nl__0);if(true) return ___nl__4;
//line 137
label_11:
//line 137
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("ok"));
//line 137
((ImmHash)___nl__2).set("cmd", ___nl__5);
//line 137
___nl__3 = null;
//line 137
___nl__4 = null;
//line 137
___nl__5 = null;
//line 138
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__2);
//line 138
___nl__1 = null;
//line 138
___nl__2 = null;
//line 138
___arg__0.setValue(___nl__0);if(true) return ___nl__3;
//line 138
___nl__3 = null;
//line 138
___nl__2 = null;
//line 138
___nl__1 = null;
//line 138
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_parse_fun_val_arg_list_priv(ImmRef ___arg__0) {
Imm ___nl__0 = ___arg__0.getValue().clone();
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
//line 142
___nl__1 = new ImmArray(new Imm[0]);
//line 143
label_2:
//line 143
___nl__3 = new ImmString("state");
//line 143
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__3);

//line 143
___nl__4 = new ImmString(")");
//line 143
___ref______nl__3 = new ImmRef(___nl__3);
___nl__2 = ntokenizer_NL.NL_next_is(___ref______nl__3,___nl__4);
___nl__3 = ___ref______nl__3.getValue();

//line 143
___nl__4 = null;
//line 143
___nl__4 = new ImmString("state");
//line 143
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__4,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 143
___nl__4 = null;
//line 143
___nl__3 = null;
//line 143
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 143
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 143
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_1;}}
//line 144
___ref______nl__0 = new ImmRef(___nl__0);
___nl__5 = nparser_NL.NL_parse_fun_val_arg_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 144
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("ok"));
//line 144
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_3;}}
//line 144
___nl__1 = null;
//line 144
___nl__2 = null;
//line 144
___nl__3 = null;
//line 144
___nl__4 = null;
//line 144
___arg__0.setValue(___nl__0);if(true) return ___nl__5;
//line 144
label_3:
//line 144
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("ok"));
//line 144
___nl__4 = null;
//line 144
___nl__5 = null;
//line 145
___ref______nl__1 = new ImmRef(___nl__1);
array_NL.NL_push(___ref______nl__1,___nl__3);
___nl__1 = ___ref______nl__1.getValue();

//line 146
___nl__5 = new ImmString(",");
//line 146
___ref______nl__0 = new ImmRef(___nl__0);
___nl__4 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 146
___nl__5 = null;
//line 146
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 146
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 146
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_5;}}
//line 146
___nl__3 = null;
//line 146
___nl__4 = null;
//line 146
if (true) {goto label_1;}
//line 146
if (true) {goto label_5;}
//line 146
label_5:
//line 146
___nl__4 = null;
//line 146
___nl__3 = null;
//line 147
if (true) {goto label_2;}
//line 147
label_1:
//line 147
___nl__2 = null;
//line 148
___nl__2 = new ImmString(")");
//line 148
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 148
___nl__2 = null;
//line 150
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__1);
//line 150
___nl__1 = null;
//line 150
___arg__0.setValue(___nl__0);if(true) return ___nl__2;
//line 150
___nl__2 = null;
//line 150
___nl__1 = null;
//line 150
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_parse_expr_list_priv(ImmRef ___arg__0) {
Imm ___nl__0 = ___arg__0.getValue().clone();
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
//line 154
___nl__1 = new ImmArray(new Imm[0]);
//line 155
label_2:
//line 155
___nl__3 = new ImmString("state");
//line 155
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__3);

//line 155
___nl__4 = new ImmString(")");
//line 155
___ref______nl__3 = new ImmRef(___nl__3);
___nl__2 = ntokenizer_NL.NL_next_is(___ref______nl__3,___nl__4);
___nl__3 = ___ref______nl__3.getValue();

//line 155
___nl__4 = null;
//line 155
___nl__4 = new ImmString("state");
//line 155
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__4,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 155
___nl__4 = null;
//line 155
___nl__3 = null;
//line 155
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 155
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 155
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_1;}}
//line 156
___ref______nl__0 = new ImmRef(___nl__0);
___nl__5 = nparser_NL.NL_parse_expr_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 156
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("ok"));
//line 156
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_3;}}
//line 156
___nl__1 = null;
//line 156
___nl__2 = null;
//line 156
___nl__3 = null;
//line 156
___nl__4 = null;
//line 156
___arg__0.setValue(___nl__0);if(true) return ___nl__5;
//line 156
label_3:
//line 156
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("ok"));
//line 156
___nl__4 = null;
//line 156
___nl__5 = null;
//line 157
___ref______nl__1 = new ImmRef(___nl__1);
array_NL.NL_push(___ref______nl__1,___nl__3);
___nl__1 = ___ref______nl__1.getValue();

//line 158
___nl__5 = new ImmString(",");
//line 158
___ref______nl__0 = new ImmRef(___nl__0);
___nl__4 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 158
___nl__5 = null;
//line 158
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 158
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 158
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_5;}}
//line 158
___nl__3 = null;
//line 158
___nl__4 = null;
//line 158
if (true) {goto label_1;}
//line 158
if (true) {goto label_5;}
//line 158
label_5:
//line 158
___nl__4 = null;
//line 158
___nl__3 = null;
//line 159
if (true) {goto label_2;}
//line 159
label_1:
//line 159
___nl__2 = null;
//line 160
___nl__2 = new ImmString(")");
//line 160
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 160
___nl__2 = null;
//line 161
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__1);
//line 161
___nl__1 = null;
//line 161
___arg__0.setValue(___nl__0);if(true) return ___nl__2;
//line 161
___nl__2 = null;
//line 161
___nl__1 = null;
//line 161
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_parse_fun_val_arg_priv(ImmRef ___arg__0) {
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
//line 165
__function_map = new Dictionary<String, Imm>();
___nl__1 = new ImmHash(__function_map);
//line 166
___nl__3 = new ImmString("ref");
//line 166
___ref______nl__0 = new ImmRef(___nl__0);
___nl__2 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 166
___nl__3 = null;
//line 166
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 166
___nl__2 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none"));
//line 166
if (true) {goto label_1;}
//line 166
label_2:
//line 166
___nl__2 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("ref"));
//line 166
label_1:
//line 166
___nl__3 = ___nl__2;
//line 166
((ImmHash)___nl__1).set("mod", ___nl__3);
//line 166
___nl__2 = null;
//line 166
___nl__3 = null;
//line 167
___ref______nl__0 = new ImmRef(___nl__0);
___nl__3 = nparser_NL.NL_parse_expr_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 167
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("ok"));
//line 167
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_3;}}
//line 167
___nl__1 = null;
//line 167
___nl__2 = null;
//line 167
___arg__0.setValue(___nl__0);if(true) return ___nl__3;
//line 167
label_3:
//line 167
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("ok"));
//line 167
((ImmHash)___nl__1).set("val", ___nl__4);
//line 167
___nl__2 = null;
//line 167
___nl__3 = null;
//line 167
___nl__4 = null;
//line 168
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__1);
//line 168
___nl__1 = null;
//line 168
___arg__0.setValue(___nl__0);if(true) return ___nl__2;
//line 168
___nl__2 = null;
//line 168
___nl__1 = null;
//line 168
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_parse_fun_label_priv(ImmRef ___arg__0) {
Imm ___nl__0 = ___arg__0.getValue().clone();
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
//line 172
___nl__2 = new ImmString("");
//line 172
___nl__3 = new ImmString("");
//line 172
__function_map = new Dictionary<String, Imm>();
__function_map.Add("name",___nl__2);
__function_map.Add("module",___nl__3);
___nl__1 = new ImmHash(__function_map);
//line 172
___nl__2 = null;
//line 172
___nl__3 = null;
//line 173
___nl__3 = new ImmString("state");
//line 173
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__3);

//line 173
___nl__4 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("word"));
//line 173
___ref______nl__3 = new ImmRef(___nl__3);
___nl__2 = ntokenizer_NL.NL_is_type(___ref______nl__3,___nl__4);
___nl__3 = ___ref______nl__3.getValue();

//line 173
___nl__4 = null;
//line 173
___nl__4 = new ImmString("state");
//line 173
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__4,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 173
___nl__4 = null;
//line 173
___nl__3 = null;
//line 173
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 173
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 173
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 174
___nl__3 = new ImmString("after '@' module name of function expacted");
//line 174
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_add_error_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 174
___nl__3 = null;
//line 175
___nl__2 = null;
//line 175
___arg__0.setValue(___nl__0);if(true) return ___nl__1;
//line 176
if (true) {goto label_2;}
//line 176
label_2:
//line 176
___nl__2 = null;
//line 177
___nl__3 = new ImmString("state");
//line 177
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__3);

//line 177
___nl__4 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("word"));
//line 177
___ref______nl__3 = new ImmRef(___nl__3);
___nl__2 = ntokenizer_NL.NL_eat_type(___ref______nl__3,___nl__4);
___nl__3 = ___ref______nl__3.getValue();

//line 177
___nl__4 = null;
//line 177
___nl__4 = new ImmString("state");
//line 177
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__4,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 177
___nl__4 = null;
//line 177
___nl__3 = null;
//line 177
___nl__3 = ___nl__2;
//line 177
((ImmHash)___nl__1).set("module", ___nl__3);
//line 177
___nl__2 = null;
//line 177
___nl__3 = null;
//line 178
___nl__4 = new ImmString("::");
//line 178
___ref______nl__0 = new ImmRef(___nl__0);
___nl__2 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 178
___nl__4 = null;
//line 178
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 178
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_5;}}
//line 178
___nl__4 = new ImmString("state");
//line 178
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__4);

//line 178
___ref______nl__4 = new ImmRef(___nl__4);
___nl__2 = ntokenizer_NL.NL_is_text(___ref______nl__4);
___nl__4 = ___ref______nl__4.getValue();

//line 178
___nl__5 = new ImmString("state");
//line 178
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 178
___nl__5 = null;
//line 178
___nl__4 = null;
//line 178
label_5:
//line 178
___nl__3 = null;
//line 178
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 178
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_4;}}
//line 179
___nl__4 = new ImmString("state");
//line 179
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__4);

//line 179
___ref______nl__4 = new ImmRef(___nl__4);
___nl__3 = ntokenizer_NL.NL_eat_text(___ref______nl__4);
___nl__4 = ___ref______nl__4.getValue();

//line 179
___nl__5 = new ImmString("state");
//line 179
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 179
___nl__5 = null;
//line 179
___nl__4 = null;
//line 179
___nl__4 = ___nl__3;
//line 179
((ImmHash)___nl__1).set("name", ___nl__4);
//line 179
___nl__3 = null;
//line 179
___nl__4 = null;
//line 180
if (true) {goto label_3;}
//line 180
label_4:
//line 181
___nl__3 = new ImmString("reference of function can be taken only to public function");
//line 181
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_add_error_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 181
___nl__3 = null;
//line 182
if (true) {goto label_3;}
//line 182
label_3:
//line 182
___nl__2 = null;
//line 183
___arg__0.setValue(___nl__0);if(true) return ___nl__1;
//line 183
___nl__1 = null;
//line 183
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_parse_label_priv(ImmRef ___arg__0) {
Imm ___nl__0 = ___arg__0.getValue().clone();
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
//line 187
___nl__2 = new ImmString("state");
//line 187
___nl__2 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__2);

//line 187
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("word"));
//line 187
___ref______nl__2 = new ImmRef(___nl__2);
___nl__1 = ntokenizer_NL.NL_eat_type(___ref______nl__2,___nl__3);
___nl__2 = ___ref______nl__2.getValue();

//line 187
___nl__3 = null;
//line 187
___nl__3 = new ImmString("state");
//line 187
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__3,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 187
___nl__3 = null;
//line 187
___nl__2 = null;
//line 188
___nl__4 = new ImmString("state");
//line 188
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__4);

//line 188
___nl__5 = new ImmString("(");
//line 188
___ref______nl__4 = new ImmRef(___nl__4);
___nl__2 = ntokenizer_NL.NL_next_is(___ref______nl__4,___nl__5);
___nl__4 = ___ref______nl__4.getValue();

//line 188
___nl__5 = null;
//line 188
___nl__5 = new ImmString("state");
//line 188
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 188
___nl__5 = null;
//line 188
___nl__4 = null;
//line 188
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 188
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 188
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 188
___nl__4 = new ImmString("state");
//line 188
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__4);

//line 188
___nl__5 = new ImmString("::");
//line 188
___ref______nl__4 = new ImmRef(___nl__4);
___nl__2 = ntokenizer_NL.NL_next_is(___ref______nl__4,___nl__5);
___nl__4 = ___ref______nl__4.getValue();

//line 188
___nl__5 = null;
//line 188
___nl__5 = new ImmString("state");
//line 188
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 188
___nl__5 = null;
//line 188
___nl__4 = null;
//line 188
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 188
label_3:
//line 188
___nl__3 = null;
//line 188
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 188
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 188
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("var"), ___nl__1);
//line 188
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__3);
//line 188
___nl__1 = null;
//line 188
___nl__2 = null;
//line 188
___arg__0.setValue(___nl__0);if(true) return ___nl__3;
//line 188
___nl__3 = null;
//line 188
if (true) {goto label_2;}
//line 188
label_2:
//line 188
___nl__2 = null;
//line 189
___nl__3 = new ImmString("");
//line 189
___nl__4 = new ImmString("");
//line 189
___nl__5 = new ImmArray(new Imm[0]);
//line 189
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",___nl__3);
__function_map.Add("name",___nl__4);
__function_map.Add("args",___nl__5);
___nl__2 = new ImmHash(__function_map);
//line 189
___nl__3 = null;
//line 189
___nl__4 = null;
//line 189
___nl__5 = null;
//line 190
___nl__4 = new ImmString("::");
//line 190
___ref______nl__0 = new ImmRef(___nl__0);
___nl__3 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 190
___nl__4 = null;
//line 190
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 190
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_5;}}
//line 191
___nl__4 = ___nl__1;
//line 191
((ImmHash)___nl__2).set("module", ___nl__4);
//line 191
___nl__4 = null;
//line 192
___ref______nl__0 = new ImmRef(___nl__0);
___nl__5 = nparser_NL.NL_eat_text_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 192
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("ok"));
//line 192
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_6;}}
//line 192
___nl__1 = null;
//line 192
___nl__2 = null;
//line 192
___nl__3 = null;
//line 192
___nl__4 = null;
//line 192
___arg__0.setValue(___nl__0);if(true) return ___nl__5;
//line 192
label_6:
//line 192
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("ok"));
//line 192
((ImmHash)___nl__2).set("name", ___nl__6);
//line 192
___nl__4 = null;
//line 192
___nl__5 = null;
//line 192
___nl__6 = null;
//line 193
if (true) {goto label_4;}
//line 193
label_5:
//line 194
___nl__4 = ___nl__1;
//line 194
((ImmHash)___nl__2).set("name", ___nl__4);
//line 194
___nl__4 = null;
//line 195
if (true) {goto label_4;}
//line 195
label_4:
//line 195
___nl__3 = null;
//line 197
___nl__3 = new ImmString("(");
//line 197
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 197
___nl__3 = null;
//line 198
___ref______nl__0 = new ImmRef(___nl__0);
___nl__4 = nparser_NL.NL_parse_fun_val_arg_list_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 198
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("ok"));
//line 198
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_7;}}
//line 198
___nl__1 = null;
//line 198
___nl__2 = null;
//line 198
___nl__3 = null;
//line 198
___arg__0.setValue(___nl__0);if(true) return ___nl__4;
//line 198
label_7:
//line 198
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("ok"));
//line 198
((ImmHash)___nl__2).set("args", ___nl__5);
//line 198
___nl__3 = null;
//line 198
___nl__4 = null;
//line 198
___nl__5 = null;
//line 199
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("fun_val"), ___nl__2);
//line 199
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__3);
//line 199
___nl__1 = null;
//line 199
___nl__2 = null;
//line 199
___arg__0.setValue(___nl__0);if(true) return ___nl__3;
//line 199
___nl__3 = null;
//line 199
___nl__1 = null;
//line 199
___nl__2 = null;
//line 199
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_parse_hash_key_priv(ImmRef ___arg__0) {
Imm ___nl__0 = ___arg__0.getValue().clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 203
___nl__2 = new ImmString("state");
//line 203
___nl__2 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__2);

//line 203
___ref______nl__2 = new ImmRef(___nl__2);
___nl__1 = ntokenizer_NL.NL_is_text(___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue();

//line 203
___nl__3 = new ImmString("state");
//line 203
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__3,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 203
___nl__3 = null;
//line 203
___nl__2 = null;
//line 203
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1));
//line 203
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1));
//line 203
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_2;}}
//line 203
___nl__2 = new ImmString("");
//line 203
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("hash_key"), ___nl__2);
//line 203
___nl__1 = null;
//line 203
___arg__0.setValue(___nl__0);if(true) return ___nl__2;
//line 203
___nl__2 = null;
//line 203
if (true) {goto label_2;}
//line 203
label_2:
//line 203
___nl__1 = null;
//line 204
___nl__2 = new ImmString("state");
//line 204
___nl__2 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__2);

//line 204
___ref______nl__2 = new ImmRef(___nl__2);
___nl__1 = ntokenizer_NL.NL_eat_text(___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue();

//line 204
___nl__3 = new ImmString("state");
//line 204
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__3,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 204
___nl__3 = null;
//line 204
___nl__2 = null;
//line 205
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("hash_key"), ___nl__1);
//line 205
___nl__1 = null;
//line 205
___arg__0.setValue(___nl__0);if(true) return ___nl__2;
//line 205
___nl__2 = null;
//line 205
___nl__1 = null;
//line 205
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_parse_hash_priv(ImmRef ___arg__0) {
Imm ___nl__0 = ___arg__0.getValue().clone();
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
//line 209
___nl__1 = new ImmArray(new Imm[0]);
//line 210
___nl__2 = new ImmString("{");
//line 210
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 210
___nl__2 = null;
//line 211
label_2:
//line 211
___nl__3 = new ImmString("state");
//line 211
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__3);

//line 211
___nl__4 = new ImmString("}");
//line 211
___ref______nl__3 = new ImmRef(___nl__3);
___nl__2 = ntokenizer_NL.NL_next_is(___ref______nl__3,___nl__4);
___nl__3 = ___ref______nl__3.getValue();

//line 211
___nl__4 = null;
//line 211
___nl__4 = new ImmString("state");
//line 211
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__4,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 211
___nl__4 = null;
//line 211
___nl__3 = null;
//line 211
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 211
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 211
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_1;}}
//line 212
___nl__4 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("nop"));
//line 212
___nl__5 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("nop"));
//line 212
__function_map = new Dictionary<String, Imm>();
__function_map.Add("key",___nl__4);
__function_map.Add("val",___nl__5);
___nl__3 = new ImmHash(__function_map);
//line 212
___nl__4 = null;
//line 212
___nl__5 = null;
//line 213
___ref______nl__0 = new ImmRef(___nl__0);
___nl__4 = nparser_NL.NL_parse_hash_key_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 213
___nl__5 = ___nl__4;
//line 213
((ImmHash)___nl__3).set("key", ___nl__5);
//line 213
___nl__4 = null;
//line 213
___nl__5 = null;
//line 214
___nl__4 = new ImmString("=>");
//line 214
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 214
___nl__4 = null;
//line 215
___ref______nl__0 = new ImmRef(___nl__0);
___nl__5 = nparser_NL.NL_parse_expr_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 215
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("ok"));
//line 215
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_3;}}
//line 215
___nl__1 = null;
//line 215
___nl__2 = null;
//line 215
___nl__3 = null;
//line 215
___nl__4 = null;
//line 215
___arg__0.setValue(___nl__0);if(true) return ___nl__5;
//line 215
label_3:
//line 215
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("ok"));
//line 215
((ImmHash)___nl__3).set("val", ___nl__6);
//line 215
___nl__4 = null;
//line 215
___nl__5 = null;
//line 215
___nl__6 = null;
//line 216
___ref______nl__1 = new ImmRef(___nl__1);
array_NL.NL_push(___ref______nl__1,___nl__3);
___nl__1 = ___ref______nl__1.getValue();

//line 217
___nl__5 = new ImmString(",");
//line 217
___ref______nl__0 = new ImmRef(___nl__0);
___nl__4 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 217
___nl__5 = null;
//line 217
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 217
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 217
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_5;}}
//line 217
___nl__3 = null;
//line 217
___nl__4 = null;
//line 217
if (true) {goto label_1;}
//line 217
if (true) {goto label_5;}
//line 217
label_5:
//line 217
___nl__4 = null;
//line 217
___nl__3 = null;
//line 218
if (true) {goto label_2;}
//line 218
label_1:
//line 218
___nl__2 = null;
//line 219
___nl__2 = new ImmString("}");
//line 219
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 219
___nl__2 = null;
//line 220
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__1);
//line 220
___nl__1 = null;
//line 220
___arg__0.setValue(___nl__0);if(true) return ___nl__2;
//line 220
___nl__2 = null;
//line 220
___nl__1 = null;
//line 220
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_parse_arr_priv(ImmRef ___arg__0) {
Imm ___nl__0 = ___arg__0.getValue().clone();
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
//line 224
___nl__1 = new ImmArray(new Imm[0]);
//line 225
___nl__2 = new ImmString("[");
//line 225
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 225
___nl__2 = null;
//line 226
label_2:
//line 226
___nl__3 = new ImmString("state");
//line 226
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__3);

//line 226
___nl__4 = new ImmString("]");
//line 226
___ref______nl__3 = new ImmRef(___nl__3);
___nl__2 = ntokenizer_NL.NL_next_is(___ref______nl__3,___nl__4);
___nl__3 = ___ref______nl__3.getValue();

//line 226
___nl__4 = null;
//line 226
___nl__4 = new ImmString("state");
//line 226
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__4,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 226
___nl__4 = null;
//line 226
___nl__3 = null;
//line 226
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 226
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 226
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_1;}}
//line 227
___ref______nl__0 = new ImmRef(___nl__0);
___nl__5 = nparser_NL.NL_parse_expr_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 227
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("ok"));
//line 227
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_3;}}
//line 227
___nl__1 = null;
//line 227
___nl__2 = null;
//line 227
___nl__3 = null;
//line 227
___nl__4 = null;
//line 227
___arg__0.setValue(___nl__0);if(true) return ___nl__5;
//line 227
label_3:
//line 227
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("ok"));
//line 227
___nl__4 = null;
//line 227
___nl__5 = null;
//line 228
___ref______nl__1 = new ImmRef(___nl__1);
array_NL.NL_push(___ref______nl__1,___nl__3);
___nl__1 = ___ref______nl__1.getValue();

//line 229
___nl__5 = new ImmString(",");
//line 229
___ref______nl__0 = new ImmRef(___nl__0);
___nl__4 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 229
___nl__5 = null;
//line 229
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 229
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 229
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_5;}}
//line 229
___nl__3 = null;
//line 229
___nl__4 = null;
//line 229
if (true) {goto label_1;}
//line 229
if (true) {goto label_5;}
//line 229
label_5:
//line 229
___nl__4 = null;
//line 229
___nl__3 = null;
//line 230
if (true) {goto label_2;}
//line 230
label_1:
//line 230
___nl__2 = null;
//line 231
___nl__2 = new ImmString("]");
//line 231
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 231
___nl__2 = null;
//line 232
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__1);
//line 232
___nl__1 = null;
//line 232
___arg__0.setValue(___nl__0);if(true) return ___nl__2;
//line 232
___nl__2 = null;
//line 232
___nl__1 = null;
//line 232
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_parse_expr_priv(ImmRef ___arg__0) {
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
//line 236
___nl__4 = new ImmDouble(0);
//line 236
___ref______nl__0 = new ImmRef(___nl__0);
___nl__3 = nparser_NL.NL_parse_expr_rec_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 236
___nl__4 = null;
//line 236
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("ok"));
//line 236
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_1;}}
//line 236
___nl__1 = null;
//line 236
___nl__2 = null;
//line 236
___arg__0.setValue(___nl__0);if(true) return ___nl__3;
//line 236
label_1:
//line 236
___nl__1 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("ok"));
//line 236
___nl__2 = null;
//line 236
___nl__3 = null;
//line 237
___nl__3 = new ImmDouble(0);
//line 237
___ref______nl__0 = new ImmRef(___nl__0);
___nl__2 = nparser_NL.NL_parse_expr_rec_left_priv(___ref______nl__0,___nl__1,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 237
___nl__3 = null;
//line 237
___nl__1 = null;
//line 237
___arg__0.setValue(___nl__0);if(true) return ___nl__2;
//line 237
___nl__2 = null;
//line 237
___nl__1 = null;
//line 237
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_parse_type_priv(ImmRef ___arg__0) {
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
//line 240
___nl__2 = new ImmString("@");
//line 240
___ref______nl__0 = new ImmRef(___nl__0);
___nl__1 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 240
___nl__2 = null;
//line 240
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1));
//line 240
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_2;}}
//line 241
___nl__3 = new ImmString("@");
//line 241
___ref______nl__0 = new ImmRef(___nl__0);
___nl__4 = nparser_NL.NL_parse_fun_label_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 241
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("fun_label"), ___nl__4);
//line 241
__function_map = new Dictionary<String, Imm>();
__function_map.Add("op",___nl__3);
__function_map.Add("val",___nl__4);
___nl__2 = new ImmHash(__function_map);
//line 241
___nl__3 = null;
//line 241
___nl__4 = null;
//line 241
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("unary_op"), ___nl__2);
//line 241
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__2);
//line 241
___nl__1 = null;
//line 241
___arg__0.setValue(___nl__0);if(true) return ___nl__2;
//line 241
___nl__2 = null;
//line 242
if (true) {goto label_2;}
//line 242
label_2:
//line 242
___nl__1 = null;
//line 243
___nl__2 = new ImmString("state");
//line 243
___nl__2 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__2);

//line 243
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("word"));
//line 243
___ref______nl__2 = new ImmRef(___nl__2);
___nl__1 = ntokenizer_NL.NL_is_type(___ref______nl__2,___nl__3);
___nl__2 = ___ref______nl__2.getValue();

//line 243
___nl__3 = null;
//line 243
___nl__3 = new ImmString("state");
//line 243
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__3,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 243
___nl__3 = null;
//line 243
___nl__2 = null;
//line 243
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1));
//line 243
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_4;}}
//line 244
___ref______nl__0 = new ImmRef(___nl__0);
___nl__4 = nparser_NL.NL_parse_label_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 244
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("ok"));
//line 244
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_5;}}
//line 244
___nl__1 = null;
//line 244
___nl__2 = null;
//line 244
___nl__3 = null;
//line 244
___arg__0.setValue(___nl__0);if(true) return ___nl__4;
//line 244
label_5:
//line 244
___nl__2 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("ok"));
//line 244
___nl__3 = null;
//line 244
___nl__4 = null;
//line 245
___nl__3 = ___nl__2;
//line 245
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("fun_val"));
//line 245
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 245
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_7;}}
//line 245
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__2);
//line 245
___nl__1 = null;
//line 245
___nl__2 = null;
//line 245
___nl__3 = null;
//line 245
___arg__0.setValue(___nl__0);if(true) return ___nl__4;
//line 245
___nl__4 = null;
//line 245
if (true) {goto label_7;}
//line 245
label_7:
//line 245
___nl__3 = null;
//line 245
___nl__2 = null;
//line 246
if (true) {goto label_4;}
//line 246
label_4:
//line 246
___nl__1 = null;
//line 247
___nl__1 = new ImmString("wrong format of type, expected '@' or function call");
//line 247
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_add_error_priv(___ref______nl__0,___nl__1);
___nl__0 = ___ref______nl__0.getValue();

//line 247
___nl__1 = null;
//line 248
___nl__1 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("nop"));
//line 248
___nl__1 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__1);
//line 248
___arg__0.setValue(___nl__0);if(true) return ___nl__1;
//line 248
___nl__1 = null;
//line 248
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_parse_expr_rec_left_priv(ImmRef ___arg__0, Imm ___arg__1, Imm ___arg__2) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();
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
//line 251
label_2:
//line 252
___nl__4 = new ImmString("state");
//line 252
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__4);

//line 252
___ref______nl__4 = new ImmRef(___nl__4);
___nl__3 = ntokenizer_NL.NL_get_token(___ref______nl__4);
___nl__4 = ___ref______nl__4.getValue();

//line 252
___nl__5 = new ImmString("state");
//line 252
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 252
___nl__5 = null;
//line 252
___nl__4 = null;
//line 254
___nl__6 = nast_NL.NL_get_ternary_ops();

//line 254
___nl__5 = hash_NL.NL_has_key(___nl__6,___nl__3);

//line 254
___nl__6 = null;
//line 254
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 254
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_4;}}
//line 255
___nl__4 = ___nl__3;
//line 256
___nl__6 = new ImmString("?");
//line 256
___nl__6 = c_rt_lib_NL.NL_native_to_nl(___nl__4.toString().Equals(___nl__6.toString()));
//line 256
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 256
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_6;}}
//line 257
___nl__8 = nast_NL.NL_get_ternary_ops();

//line 257
___nl__9 = new ImmString("?");
//line 257
___nl__7 = hash_NL.NL_get_value(___nl__8,___nl__9);

//line 257
___nl__9 = null;
//line 257
___nl__8 = null;
//line 258
___nl__8 = ((ImmHash)___nl__7).getHashValue()["prec"];
//line 258
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString()))<(Double.Parse(___nl__2.getValue().ToString())) );
//line 258
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_9;}}
//line 258
___nl__8 = ((ImmHash)___nl__7).getHashValue()["prec"];
//line 258
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString())) ==((Double.Parse(___nl__2.getValue().ToString())))  );
//line 258
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8));
//line 258
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_10;}}
//line 258
___nl__10 = ((ImmHash)___nl__7).getHashValue()["assoc"];
//line 258
___nl__11 = new ImmString("left");
//line 258
___nl__8 = ov_NL.NL_is(___nl__10,___nl__11);

//line 258
___nl__11 = null;
//line 258
___nl__10 = null;
//line 258
label_10:
//line 258
___nl__9 = null;
//line 258
label_9:
//line 258
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8));
//line 258
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_8;}}
//line 258
___nl__9 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__1);
//line 258
___nl__1 = null;
//line 258
___nl__2 = null;
//line 258
___nl__3 = null;
//line 258
___nl__4 = null;
//line 258
___nl__5 = null;
//line 258
___nl__6 = null;
//line 258
___nl__7 = null;
//line 258
___nl__8 = null;
//line 258
___arg__0.setValue(___nl__0);if(true) return ___nl__9;
//line 258
___nl__9 = null;
//line 258
if (true) {goto label_8;}
//line 258
label_8:
//line 258
___nl__8 = null;
//line 259
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 260
___ref______nl__0 = new ImmRef(___nl__0);
___nl__10 = nparser_NL.NL_parse_expr_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 260
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__10, new ImmString("ok"));
//line 260
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_11;}}
//line 260
___nl__1 = null;
//line 260
___nl__2 = null;
//line 260
___nl__3 = null;
//line 260
___nl__4 = null;
//line 260
___nl__5 = null;
//line 260
___nl__6 = null;
//line 260
___nl__7 = null;
//line 260
___nl__8 = null;
//line 260
___nl__9 = null;
//line 260
___arg__0.setValue(___nl__0);if(true) return ___nl__10;
//line 260
label_11:
//line 260
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__10, new ImmString("ok"));
//line 260
___nl__9 = null;
//line 260
___nl__10 = null;
//line 261
___nl__9 = new ImmString(":");
//line 261
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__9);
___nl__0 = ___ref______nl__0.getValue();

//line 261
___nl__9 = null;
//line 262
___nl__12 = ((ImmHash)___nl__7).getHashValue()["prec"];
//line 262
___ref______nl__0 = new ImmRef(___nl__0);
___nl__11 = nparser_NL.NL_parse_expr_rec_priv(___ref______nl__0,___nl__12);
___nl__0 = ___ref______nl__0.getValue();

//line 262
___nl__12 = null;
//line 262
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("ok"));
//line 262
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_12;}}
//line 262
___nl__1 = null;
//line 262
___nl__2 = null;
//line 262
___nl__3 = null;
//line 262
___nl__4 = null;
//line 262
___nl__5 = null;
//line 262
___nl__6 = null;
//line 262
___nl__7 = null;
//line 262
___nl__8 = null;
//line 262
___nl__9 = null;
//line 262
___nl__10 = null;
//line 262
___arg__0.setValue(___nl__0);if(true) return ___nl__11;
//line 262
label_12:
//line 262
___nl__9 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("ok"));
//line 262
___nl__10 = null;
//line 262
___nl__11 = null;
//line 263
___nl__11 = new ImmString("?");
//line 263
__function_map = new Dictionary<String, Imm>();
__function_map.Add("fst",___nl__1);
__function_map.Add("snd",___nl__8);
__function_map.Add("thrd",___nl__9);
__function_map.Add("op",___nl__11);
___nl__10 = new ImmHash(__function_map);
//line 263
___nl__11 = null;
//line 263
___nl__10 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ternary_op"), ___nl__10);
//line 263
___nl__1 = ___nl__10;
//line 263
___nl__10 = null;
//line 263
___nl__7 = null;
//line 263
___nl__8 = null;
//line 263
___nl__9 = null;
//line 264
if (true) {goto label_5;}
//line 264
label_6:
//line 265
___nl__7 = new ImmString("ternary op: ");
//line 265
___nl__7 = new ImmString(___nl__7.toString() + ___nl__4.toString());
//line 265
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("err"), ___nl__7);
//line 265
___nl__1 = null;
//line 265
___nl__2 = null;
//line 265
___nl__3 = null;
//line 265
___nl__4 = null;
//line 265
___nl__5 = null;
//line 265
___nl__6 = null;
//line 265
___arg__0.setValue(___nl__0);if(true) return ___nl__7;
//line 265
___nl__7 = null;
//line 266
if (true) {goto label_5;}
//line 266
label_5:
//line 266
___nl__6 = null;
//line 267
if (true) {goto label_3;}
//line 267
label_4:
//line 267
___nl__6 = nast_NL.NL_get_bin_ops();

//line 267
___nl__5 = hash_NL.NL_has_key(___nl__6,___nl__3);

//line 267
___nl__6 = null;
//line 267
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 267
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_13;}}
//line 268
___nl__4 = ___nl__3;
//line 269
___nl__7 = nast_NL.NL_get_bin_ops();

//line 269
___nl__6 = hash_NL.NL_get_value(___nl__7,___nl__3);

//line 269
___nl__7 = null;
//line 270
___nl__7 = ((ImmHash)___nl__6).getHashValue()["prec"];
//line 270
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))<(Double.Parse(___nl__2.getValue().ToString())) );
//line 270
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_16;}}
//line 270
___nl__7 = ((ImmHash)___nl__6).getHashValue()["prec"];
//line 270
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString())) ==((Double.Parse(___nl__2.getValue().ToString())))  );
//line 270
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 270
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_17;}}
//line 270
___nl__9 = ((ImmHash)___nl__6).getHashValue()["assoc"];
//line 270
___nl__10 = new ImmString("left");
//line 270
___nl__7 = ov_NL.NL_is(___nl__9,___nl__10);

//line 270
___nl__10 = null;
//line 270
___nl__9 = null;
//line 270
label_17:
//line 270
___nl__8 = null;
//line 270
label_16:
//line 270
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 270
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_15;}}
//line 270
___nl__8 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__1);
//line 270
___nl__1 = null;
//line 270
___nl__2 = null;
//line 270
___nl__3 = null;
//line 270
___nl__4 = null;
//line 270
___nl__5 = null;
//line 270
___nl__6 = null;
//line 270
___nl__7 = null;
//line 270
___arg__0.setValue(___nl__0);if(true) return ___nl__8;
//line 270
___nl__8 = null;
//line 270
if (true) {goto label_15;}
//line 270
label_15:
//line 270
___nl__7 = null;
//line 271
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 272
___nl__7 = new ImmString("->");
//line 272
___nl__7 = c_rt_lib_NL.NL_native_to_nl(___nl__4.toString().Equals(___nl__7.toString()));
//line 272
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 272
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_19;}}
//line 273
___ref______nl__0 = new ImmRef(___nl__0);
___nl__9 = nparser_NL.NL_parse_hash_key_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 273
__function_map = new Dictionary<String, Imm>();
__function_map.Add("op",___nl__4);
__function_map.Add("left",___nl__1);
__function_map.Add("right",___nl__9);
___nl__8 = new ImmHash(__function_map);
//line 273
___nl__9 = null;
//line 273
___nl__8 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("bin_op"), ___nl__8);
//line 273
___nl__1 = ___nl__8;
//line 273
___nl__8 = null;
//line 274
if (true) {goto label_18;}
//line 274
label_19:
//line 274
___nl__7 = new ImmString("as");
//line 274
___nl__7 = c_rt_lib_NL.NL_native_to_nl(___nl__4.toString().Equals(___nl__7.toString()));
//line 274
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 274
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_20;}}
//line 275
___nl__8 = new ImmString(":");
//line 275
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__8);
___nl__0 = ___ref______nl__0.getValue();

//line 275
___nl__8 = null;
//line 276
___ref______nl__0 = new ImmRef(___nl__0);
___nl__8 = nparser_NL.NL_parse_variant_label_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 277
___nl__10 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("ov_as"));
//line 277
__function_map = new Dictionary<String, Imm>();
__function_map.Add("op",___nl__10);
__function_map.Add("left",___nl__1);
__function_map.Add("case",___nl__8);
___nl__9 = new ImmHash(__function_map);
//line 277
___nl__10 = null;
//line 277
___nl__9 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("var_op"), ___nl__9);
//line 277
___nl__1 = ___nl__9;
//line 277
___nl__9 = null;
//line 277
___nl__8 = null;
//line 278
if (true) {goto label_18;}
//line 278
label_20:
//line 278
___nl__7 = new ImmString("is");
//line 278
___nl__7 = c_rt_lib_NL.NL_native_to_nl(___nl__4.toString().Equals(___nl__7.toString()));
//line 278
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 278
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_21;}}
//line 279
___nl__8 = new ImmString(":");
//line 279
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__8);
___nl__0 = ___ref______nl__0.getValue();

//line 279
___nl__8 = null;
//line 280
___ref______nl__0 = new ImmRef(___nl__0);
___nl__8 = nparser_NL.NL_parse_variant_label_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 281
___nl__10 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("ov_is"));
//line 281
__function_map = new Dictionary<String, Imm>();
__function_map.Add("op",___nl__10);
__function_map.Add("left",___nl__1);
__function_map.Add("case",___nl__8);
___nl__9 = new ImmHash(__function_map);
//line 281
___nl__10 = null;
//line 281
___nl__9 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("var_op"), ___nl__9);
//line 281
___nl__1 = ___nl__9;
//line 281
___nl__9 = null;
//line 281
___nl__8 = null;
//line 282
if (true) {goto label_18;}
//line 282
label_21:
//line 283
___nl__8 = new ImmString("=");
//line 283
___nl__8 = c_rt_lib_NL.NL_native_to_nl(___nl__4.toString().Equals(___nl__8.toString()));
//line 283
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8));
//line 283
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_23;}}
//line 283
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_check_lvalue_priv(___ref______nl__0,___nl__1);
___nl__0 = ___ref______nl__0.getValue();

//line 283
if (true) {goto label_23;}
//line 283
label_23:
//line 283
___nl__8 = null;
//line 284
___nl__12 = nast_NL.NL_get_bin_ops();

//line 284
___nl__11 = hash_NL.NL_get_value(___nl__12,___nl__4);

//line 284
___nl__12 = null;
//line 284
___nl__11 = ((ImmHash)___nl__11).getHashValue()["prec"];
//line 284
___ref______nl__0 = new ImmRef(___nl__0);
___nl__10 = nparser_NL.NL_parse_expr_rec_priv(___ref______nl__0,___nl__11);
___nl__0 = ___ref______nl__0.getValue();

//line 284
___nl__11 = null;
//line 284
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__10, new ImmString("ok"));
//line 284
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_24;}}
//line 284
___nl__1 = null;
//line 284
___nl__2 = null;
//line 284
___nl__3 = null;
//line 284
___nl__4 = null;
//line 284
___nl__5 = null;
//line 284
___nl__6 = null;
//line 284
___nl__7 = null;
//line 284
___nl__8 = null;
//line 284
___nl__9 = null;
//line 284
___arg__0.setValue(___nl__0);if(true) return ___nl__10;
//line 284
label_24:
//line 284
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__10, new ImmString("ok"));
//line 284
___nl__9 = null;
//line 284
___nl__10 = null;
//line 285
__function_map = new Dictionary<String, Imm>();
__function_map.Add("left",___nl__1);
__function_map.Add("op",___nl__4);
__function_map.Add("right",___nl__8);
___nl__9 = new ImmHash(__function_map);
//line 285
___nl__9 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("bin_op"), ___nl__9);
//line 285
___nl__1 = ___nl__9;
//line 285
___nl__9 = null;
//line 285
___nl__8 = null;
//line 290
if (true) {goto label_18;}
//line 290
label_18:
//line 290
___nl__7 = null;
//line 290
___nl__6 = null;
//line 291
if (true) {goto label_3;}
//line 291
label_13:
//line 291
___nl__6 = new ImmString("[");
//line 291
___ref______nl__0 = new ImmRef(___nl__0);
___nl__5 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

//line 291
___nl__6 = null;
//line 291
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 291
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_25;}}
//line 292
___nl__6 = new ImmString("ARRAY_INDEX");
//line 292
___nl__4 = ___nl__6;
//line 292
___nl__6 = null;
//line 293
___ref______nl__0 = new ImmRef(___nl__0);
___nl__8 = nparser_NL.NL_parse_expr_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 293
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("ok"));
//line 293
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_26;}}
//line 293
___nl__1 = null;
//line 293
___nl__2 = null;
//line 293
___nl__3 = null;
//line 293
___nl__4 = null;
//line 293
___nl__5 = null;
//line 293
___nl__6 = null;
//line 293
___nl__7 = null;
//line 293
___arg__0.setValue(___nl__0);if(true) return ___nl__8;
//line 293
label_26:
//line 293
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__8, new ImmString("ok"));
//line 293
___nl__7 = null;
//line 293
___nl__8 = null;
//line 294
___nl__7 = new ImmString("]");
//line 294
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 294
___nl__7 = null;
//line 295
__function_map = new Dictionary<String, Imm>();
__function_map.Add("op",___nl__4);
__function_map.Add("left",___nl__1);
__function_map.Add("right",___nl__6);
___nl__7 = new ImmHash(__function_map);
//line 295
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("bin_op"), ___nl__7);
//line 295
___nl__1 = ___nl__7;
//line 295
___nl__7 = null;
//line 295
___nl__6 = null;
//line 296
if (true) {goto label_3;}
//line 296
label_25:
//line 296
___nl__6 = new ImmString("++");
//line 296
___ref______nl__0 = new ImmRef(___nl__0);
___nl__5 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

//line 296
___nl__6 = null;
//line 296
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 296
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_27;}}
//line 297
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("post_inc"), ___nl__1);
//line 297
___nl__1 = ___nl__6;
//line 297
___nl__6 = null;
//line 298
if (true) {goto label_3;}
//line 298
label_27:
//line 298
___nl__6 = new ImmString("--");
//line 298
___ref______nl__0 = new ImmRef(___nl__0);
___nl__5 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

//line 298
___nl__6 = null;
//line 298
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 298
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_28;}}
//line 299
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("post_dec"), ___nl__1);
//line 299
___nl__1 = ___nl__6;
//line 299
___nl__6 = null;
//line 300
if (true) {goto label_3;}
//line 300
label_28:
//line 301
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__1);
//line 301
___nl__1 = null;
//line 301
___nl__2 = null;
//line 301
___nl__3 = null;
//line 301
___nl__4 = null;
//line 301
___nl__5 = null;
//line 301
___arg__0.setValue(___nl__0);if(true) return ___nl__6;
//line 301
___nl__6 = null;
//line 302
if (true) {goto label_3;}
//line 302
label_3:
//line 302
___nl__5 = null;
//line 302
___nl__3 = null;
//line 302
___nl__4 = null;
//line 251
if (true) {goto label_2;}
//line 304
___nl__3 = new ImmArray(new Imm[0]);
//line 304
c_rt_lib_NL.NL_die();
//line 304
___nl__3 = null;
//line 304
___nl__1 = null;
//line 304
___nl__2 = null;
//line 304
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_parse_expr_rec_priv(ImmRef ___arg__0, Imm ___arg__1) {
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
//line 309
___nl__4 = new ImmString("(");
//line 309
___ref______nl__0 = new ImmRef(___nl__0);
___nl__3 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 309
___nl__4 = null;
//line 309
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 309
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 310
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = nparser_NL.NL_parse_expr_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 310
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("ok"));
//line 310
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_3;}}
//line 310
___nl__1 = null;
//line 310
___nl__2 = null;
//line 310
___nl__3 = null;
//line 310
___nl__4 = null;
//line 310
___nl__5 = null;
//line 310
___arg__0.setValue(___nl__0);if(true) return ___nl__6;
//line 310
label_3:
//line 310
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("ok"));
//line 310
___nl__5 = null;
//line 310
___nl__6 = null;
//line 311
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("parenthesis"), ___nl__4);
//line 311
___nl__2 = ___nl__5;
//line 311
___nl__5 = null;
//line 312
___nl__5 = new ImmString(")");
//line 312
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 312
___nl__5 = null;
//line 312
___nl__4 = null;
//line 313
if (true) {goto label_1;}
//line 313
label_2:
//line 313
___nl__4 = new ImmString("state");
//line 313
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__4);

//line 313
___nl__5 = new ImmString("{");
//line 313
___ref______nl__4 = new ImmRef(___nl__4);
___nl__3 = ntokenizer_NL.NL_next_is(___ref______nl__4,___nl__5);
___nl__4 = ___ref______nl__4.getValue();

//line 313
___nl__5 = null;
//line 313
___nl__5 = new ImmString("state");
//line 313
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 313
___nl__5 = null;
//line 313
___nl__4 = null;
//line 313
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 313
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_4;}}
//line 314
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = nparser_NL.NL_parse_hash_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 314
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("ok"));
//line 314
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_5;}}
//line 314
___nl__1 = null;
//line 314
___nl__2 = null;
//line 314
___nl__3 = null;
//line 314
___nl__4 = null;
//line 314
___nl__5 = null;
//line 314
___arg__0.setValue(___nl__0);if(true) return ___nl__6;
//line 314
label_5:
//line 314
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("ok"));
//line 314
___nl__5 = null;
//line 314
___nl__6 = null;
//line 315
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("hash_decl"), ___nl__4);
//line 315
___nl__2 = ___nl__5;
//line 315
___nl__5 = null;
//line 315
___nl__4 = null;
//line 316
if (true) {goto label_1;}
//line 316
label_4:
//line 316
___nl__4 = new ImmString("state");
//line 316
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__4);

//line 316
___nl__5 = new ImmString("[");
//line 316
___ref______nl__4 = new ImmRef(___nl__4);
___nl__3 = ntokenizer_NL.NL_next_is(___ref______nl__4,___nl__5);
___nl__4 = ___ref______nl__4.getValue();

//line 316
___nl__5 = null;
//line 316
___nl__5 = new ImmString("state");
//line 316
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 316
___nl__5 = null;
//line 316
___nl__4 = null;
//line 316
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 316
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_6;}}
//line 317
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = nparser_NL.NL_parse_arr_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 317
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("ok"));
//line 317
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_7;}}
//line 317
___nl__1 = null;
//line 317
___nl__2 = null;
//line 317
___nl__3 = null;
//line 317
___nl__4 = null;
//line 317
___nl__5 = null;
//line 317
___arg__0.setValue(___nl__0);if(true) return ___nl__6;
//line 317
label_7:
//line 317
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("ok"));
//line 317
___nl__5 = null;
//line 317
___nl__6 = null;
//line 318
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("arr_decl"), ___nl__4);
//line 318
___nl__2 = ___nl__5;
//line 318
___nl__5 = null;
//line 318
___nl__4 = null;
//line 319
if (true) {goto label_1;}
//line 319
label_6:
//line 319
___nl__4 = new ImmString("state");
//line 319
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__4);

//line 319
___nl__5 = new ImmString(":");
//line 319
___ref______nl__4 = new ImmRef(___nl__4);
___nl__3 = ntokenizer_NL.NL_next_is(___ref______nl__4,___nl__5);
___nl__4 = ___ref______nl__4.getValue();

//line 319
___nl__5 = null;
//line 319
___nl__5 = new ImmString("state");
//line 319
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 319
___nl__5 = null;
//line 319
___nl__4 = null;
//line 319
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 319
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_8;}}
//line 320
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = nparser_NL.NL_parse_variant_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 320
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("ok"));
//line 320
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_9;}}
//line 320
___nl__1 = null;
//line 320
___nl__2 = null;
//line 320
___nl__3 = null;
//line 320
___nl__4 = null;
//line 320
___nl__5 = null;
//line 320
___arg__0.setValue(___nl__0);if(true) return ___nl__6;
//line 320
label_9:
//line 320
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("ok"));
//line 320
___nl__5 = null;
//line 320
___nl__6 = null;
//line 321
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("variant"), ___nl__4);
//line 321
___nl__2 = ___nl__5;
//line 321
___nl__5 = null;
//line 321
___nl__4 = null;
//line 322
if (true) {goto label_1;}
//line 322
label_8:
//line 322
___nl__4 = new ImmString("state");
//line 322
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__4);

//line 322
___nl__5 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("number"));
//line 322
___ref______nl__4 = new ImmRef(___nl__4);
___nl__3 = ntokenizer_NL.NL_is_type(___ref______nl__4,___nl__5);
___nl__4 = ___ref______nl__4.getValue();

//line 322
___nl__5 = null;
//line 322
___nl__5 = new ImmString("state");
//line 322
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 322
___nl__5 = null;
//line 322
___nl__4 = null;
//line 322
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 322
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_10;}}
//line 323
___nl__5 = new ImmString("state");
//line 323
___nl__5 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__5);

//line 323
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("number"));
//line 323
___ref______nl__5 = new ImmRef(___nl__5);
___nl__4 = ntokenizer_NL.NL_eat_type(___ref______nl__5,___nl__6);
___nl__5 = ___ref______nl__5.getValue();

//line 323
___nl__6 = null;
//line 323
___nl__6 = new ImmString("state");
//line 323
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__6,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 323
___nl__6 = null;
//line 323
___nl__5 = null;
//line 323
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("const"), ___nl__4);
//line 323
___nl__2 = ___nl__4;
//line 323
___nl__4 = null;
//line 324
if (true) {goto label_1;}
//line 324
label_10:
//line 324
___nl__4 = new ImmString("state");
//line 324
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__4);

//line 324
___nl__5 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("multi_string"));
//line 324
___ref______nl__4 = new ImmRef(___nl__4);
___nl__3 = ntokenizer_NL.NL_is_type(___ref______nl__4,___nl__5);
___nl__4 = ___ref______nl__4.getValue();

//line 324
___nl__5 = null;
//line 324
___nl__5 = new ImmString("state");
//line 324
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 324
___nl__5 = null;
//line 324
___nl__4 = null;
//line 324
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_12;}}
//line 324
___nl__4 = new ImmString("state");
//line 324
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__4);

//line 324
___nl__5 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("string"));
//line 324
___ref______nl__4 = new ImmRef(___nl__4);
___nl__3 = ntokenizer_NL.NL_is_type(___ref______nl__4,___nl__5);
___nl__4 = ___ref______nl__4.getValue();

//line 324
___nl__5 = null;
//line 324
___nl__5 = new ImmString("state");
//line 324
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 324
___nl__5 = null;
//line 324
___nl__4 = null;
//line 324
label_12:
//line 324
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 324
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_11;}}
//line 325
___nl__5 = new ImmArray(new Imm[0]);
//line 325
__function_map = new Dictionary<String, Imm>();
__function_map.Add("arr",___nl__5);
___nl__4 = new ImmHash(__function_map);
//line 325
___nl__5 = null;
//line 326
label_14:
//line 326
___nl__6 = new ImmString("state");
//line 326
___nl__6 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__6);

//line 326
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("multi_string"));
//line 326
___ref______nl__6 = new ImmRef(___nl__6);
___nl__5 = ntokenizer_NL.NL_is_type(___ref______nl__6,___nl__7);
___nl__6 = ___ref______nl__6.getValue();

//line 326
___nl__7 = null;
//line 326
___nl__7 = new ImmString("state");
//line 326
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__7,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

//line 326
___nl__7 = null;
//line 326
___nl__6 = null;
//line 326
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 326
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_13;}}
//line 327
___nl__6 = new ImmString("arr");
//line 327
___nl__6 = c_rt_lib_NL.NL_get_ref_hash(___nl__4,___nl__6);

//line 327
___nl__8 = new ImmString("state");
//line 327
___nl__8 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__8);

//line 327
___nl__9 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("multi_string"));
//line 327
___ref______nl__8 = new ImmRef(___nl__8);
___nl__7 = ntokenizer_NL.NL_eat_type(___ref______nl__8,___nl__9);
___nl__8 = ___ref______nl__8.getValue();

//line 327
___nl__9 = null;
//line 327
___nl__9 = new ImmString("state");
//line 327
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__9,___nl__8);
___nl__0 = ___ref______nl__0.getValue();

//line 327
___nl__9 = null;
//line 327
___nl__8 = null;
//line 327
___ref______nl__6 = new ImmRef(___nl__6);
array_NL.NL_push(___ref______nl__6,___nl__7);
___nl__6 = ___ref______nl__6.getValue();

//line 327
___nl__7 = null;
//line 327
___nl__7 = new ImmString("arr");
//line 327
___ref______nl__4 = new ImmRef(___nl__4);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__4,___nl__7,___nl__6);
___nl__4 = ___ref______nl__4.getValue();

//line 327
___nl__7 = null;
//line 327
___nl__6 = null;
//line 328
if (true) {goto label_14;}
//line 328
label_13:
//line 328
___nl__5 = null;
//line 330
___nl__6 = new ImmString("state");
//line 330
___nl__6 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__6);

//line 330
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("string"));
//line 330
___ref______nl__6 = new ImmRef(___nl__6);
___nl__5 = ntokenizer_NL.NL_is_type(___ref______nl__6,___nl__7);
___nl__6 = ___ref______nl__6.getValue();

//line 330
___nl__7 = null;
//line 330
___nl__7 = new ImmString("state");
//line 330
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__7,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

//line 330
___nl__7 = null;
//line 330
___nl__6 = null;
//line 330
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 330
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_16;}}
//line 331
___nl__6 = new ImmString("arr");
//line 331
___nl__6 = c_rt_lib_NL.NL_get_ref_hash(___nl__4,___nl__6);

//line 331
___nl__8 = new ImmString("state");
//line 331
___nl__8 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__8);

//line 331
___nl__9 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("string"));
//line 331
___ref______nl__8 = new ImmRef(___nl__8);
___nl__7 = ntokenizer_NL.NL_eat_type(___ref______nl__8,___nl__9);
___nl__8 = ___ref______nl__8.getValue();

//line 331
___nl__9 = null;
//line 331
___nl__9 = new ImmString("state");
//line 331
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__9,___nl__8);
___nl__0 = ___ref______nl__0.getValue();

//line 331
___nl__9 = null;
//line 331
___nl__8 = null;
//line 331
___ref______nl__6 = new ImmRef(___nl__6);
array_NL.NL_push(___ref______nl__6,___nl__7);
___nl__6 = ___ref______nl__6.getValue();

//line 331
___nl__7 = null;
//line 331
___nl__7 = new ImmString("arr");
//line 331
___ref______nl__4 = new ImmRef(___nl__4);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__4,___nl__7,___nl__6);
___nl__4 = ___ref______nl__4.getValue();

//line 331
___nl__7 = null;
//line 331
___nl__6 = null;
//line 332
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("end"));
//line 332
___nl__7 = ___nl__6;
//line 332
((ImmHash)___nl__4).set("last", ___nl__7);
//line 332
___nl__6 = null;
//line 332
___nl__7 = null;
//line 333
if (true) {goto label_15;}
//line 333
label_16:
//line 334
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("new_line"));
//line 334
___nl__7 = ___nl__6;
//line 334
((ImmHash)___nl__4).set("last", ___nl__7);
//line 334
___nl__6 = null;
//line 334
___nl__7 = null;
//line 335
if (true) {goto label_15;}
//line 335
label_15:
//line 335
___nl__5 = null;
//line 336
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("string"), ___nl__4);
//line 336
___nl__2 = ___nl__5;
//line 336
___nl__5 = null;
//line 336
___nl__4 = null;
//line 337
if (true) {goto label_1;}
//line 337
label_11:
//line 337
___nl__4 = new ImmString("state");
//line 337
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__4);

//line 337
___nl__5 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("word"));
//line 337
___ref______nl__4 = new ImmRef(___nl__4);
___nl__3 = ntokenizer_NL.NL_is_type(___ref______nl__4,___nl__5);
___nl__4 = ___ref______nl__4.getValue();

//line 337
___nl__5 = null;
//line 337
___nl__5 = new ImmString("state");
//line 337
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 337
___nl__5 = null;
//line 337
___nl__4 = null;
//line 337
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 337
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_17;}}
//line 338
___ref______nl__0 = new ImmRef(___nl__0);
___nl__5 = nparser_NL.NL_parse_label_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 338
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("ok"));
//line 338
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_18;}}
//line 338
___nl__1 = null;
//line 338
___nl__2 = null;
//line 338
___nl__3 = null;
//line 338
___nl__4 = null;
//line 338
___arg__0.setValue(___nl__0);if(true) return ___nl__5;
//line 338
label_18:
//line 338
___nl__2 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("ok"));
//line 338
___nl__4 = null;
//line 338
___nl__5 = null;
//line 339
if (true) {goto label_1;}
//line 339
label_17:
//line 339
___nl__5 = new ImmString("state");
//line 339
___nl__5 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__5);

//line 339
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("operator"));
//line 339
___ref______nl__5 = new ImmRef(___nl__5);
___nl__3 = ntokenizer_NL.NL_is_type(___ref______nl__5,___nl__6);
___nl__5 = ___ref______nl__5.getValue();

//line 339
___nl__6 = null;
//line 339
___nl__6 = new ImmString("state");
//line 339
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__6,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 339
___nl__6 = null;
//line 339
___nl__5 = null;
//line 339
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 339
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_20;}}
//line 339
___nl__5 = nast_NL.NL_get_unary_ops();

//line 339
___nl__7 = new ImmString("state");
//line 339
___nl__7 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__7);

//line 339
___ref______nl__7 = new ImmRef(___nl__7);
___nl__6 = ntokenizer_NL.NL_get_token(___ref______nl__7);
___nl__7 = ___ref______nl__7.getValue();

//line 339
___nl__8 = new ImmString("state");
//line 339
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__8,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 339
___nl__8 = null;
//line 339
___nl__7 = null;
//line 339
___nl__3 = hash_NL.NL_has_key(___nl__5,___nl__6);

//line 339
___nl__6 = null;
//line 339
___nl__5 = null;
//line 339
label_20:
//line 339
___nl__4 = null;
//line 339
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 339
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_19;}}
//line 340
___nl__5 = new ImmString("state");
//line 340
___nl__5 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__5);

//line 340
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("operator"));
//line 340
___ref______nl__5 = new ImmRef(___nl__5);
___nl__4 = ntokenizer_NL.NL_eat_type(___ref______nl__5,___nl__6);
___nl__5 = ___ref______nl__5.getValue();

//line 340
___nl__6 = null;
//line 340
___nl__6 = new ImmString("state");
//line 340
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__6,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 340
___nl__6 = null;
//line 340
___nl__5 = null;
//line 342
___nl__6 = new ImmString("@");
//line 342
___nl__6 = c_rt_lib_NL.NL_native_to_nl(___nl__4.toString().Equals(___nl__6.toString()));
//line 342
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 342
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_22;}}
//line 343
___ref______nl__0 = new ImmRef(___nl__0);
___nl__7 = nparser_NL.NL_parse_fun_label_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 343
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("fun_label"), ___nl__7);
//line 343
___nl__5 = ___nl__7;
//line 343
___nl__7 = null;
//line 344
if (true) {goto label_21;}
//line 344
label_22:
//line 345
___nl__10 = nast_NL.NL_get_unary_ops();

//line 345
___nl__9 = hash_NL.NL_get_value(___nl__10,___nl__4);

//line 345
___nl__10 = null;
//line 345
___nl__9 = ((ImmHash)___nl__9).getHashValue()["prec"];
//line 345
___ref______nl__0 = new ImmRef(___nl__0);
___nl__8 = nparser_NL.NL_parse_expr_rec_priv(___ref______nl__0,___nl__9);
___nl__0 = ___ref______nl__0.getValue();

//line 345
___nl__9 = null;
//line 345
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("ok"));
//line 345
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_23;}}
//line 345
___nl__1 = null;
//line 345
___nl__2 = null;
//line 345
___nl__3 = null;
//line 345
___nl__4 = null;
//line 345
___nl__5 = null;
//line 345
___nl__6 = null;
//line 345
___nl__7 = null;
//line 345
___arg__0.setValue(___nl__0);if(true) return ___nl__8;
//line 345
label_23:
//line 345
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__8, new ImmString("ok"));
//line 345
___nl__7 = null;
//line 345
___nl__8 = null;
//line 346
___nl__7 = ___nl__5;
//line 346
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("unary_op"));
//line 346
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 346
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_25;}}
//line 346
___nl__8 = new ImmString("unary operator after unary operator");
//line 346
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_add_error_priv(___ref______nl__0,___nl__8);
___nl__0 = ___ref______nl__0.getValue();

//line 346
___nl__8 = null;
//line 346
if (true) {goto label_25;}
//line 346
label_25:
//line 346
___nl__7 = null;
//line 347
if (true) {goto label_21;}
//line 347
label_21:
//line 347
___nl__6 = null;
//line 348
__function_map = new Dictionary<String, Imm>();
__function_map.Add("op",___nl__4);
__function_map.Add("val",___nl__5);
___nl__6 = new ImmHash(__function_map);
//line 348
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("unary_op"), ___nl__6);
//line 348
___nl__2 = ___nl__6;
//line 348
___nl__6 = null;
//line 348
___nl__4 = null;
//line 348
___nl__5 = null;
//line 349
if (true) {goto label_1;}
//line 349
label_19:
//line 349
___nl__4 = new ImmString("state");
//line 349
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__4);

//line 349
___nl__5 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("keyword"));
//line 349
___ref______nl__4 = new ImmRef(___nl__4);
___nl__3 = ntokenizer_NL.NL_is_type(___ref______nl__4,___nl__5);
___nl__4 = ___ref______nl__4.getValue();

//line 349
___nl__5 = null;
//line 349
___nl__5 = new ImmString("state");
//line 349
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 349
___nl__5 = null;
//line 349
___nl__4 = null;
//line 349
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 349
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_26;}}
//line 350
___nl__5 = new ImmString("true");
//line 350
___ref______nl__0 = new ImmRef(___nl__0);
___nl__4 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 350
___nl__5 = null;
//line 350
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 350
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_28;}}
//line 351
___nl__6 = new ImmString("TRUE");
//line 351
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("nop"));
//line 351
__function_map = new Dictionary<String, Imm>();
__function_map.Add("name",___nl__6);
__function_map.Add("var",___nl__7);
___nl__5 = new ImmHash(__function_map);
//line 351
___nl__6 = null;
//line 351
___nl__7 = null;
//line 351
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("variant"), ___nl__5);
//line 351
___nl__2 = ___nl__5;
//line 351
___nl__5 = null;
//line 352
if (true) {goto label_27;}
//line 352
label_28:
//line 352
___nl__5 = new ImmString("false");
//line 352
___ref______nl__0 = new ImmRef(___nl__0);
___nl__4 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 352
___nl__5 = null;
//line 352
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 352
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_29;}}
//line 353
___nl__6 = new ImmString("FALSE");
//line 353
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("nop"));
//line 353
__function_map = new Dictionary<String, Imm>();
__function_map.Add("name",___nl__6);
__function_map.Add("var",___nl__7);
___nl__5 = new ImmHash(__function_map);
//line 353
___nl__6 = null;
//line 353
___nl__7 = null;
//line 353
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("variant"), ___nl__5);
//line 353
___nl__2 = ___nl__5;
//line 353
___nl__5 = null;
//line 354
if (true) {goto label_27;}
//line 354
label_29:
//line 355
___nl__5 = new ImmString("use keyword in wrong context:");
//line 355
___nl__6 = string_NL.NL_lf();

//line 355
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 355
___nl__6 = null;
//line 355
___nl__7 = new ImmString("state");
//line 355
___nl__7 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__7);

//line 355
___ref______nl__7 = new ImmRef(___nl__7);
___nl__6 = ntokenizer_NL.NL_info(___ref______nl__7);
___nl__7 = ___ref______nl__7.getValue();

//line 355
___nl__8 = new ImmString("state");
//line 355
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__8,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 355
___nl__8 = null;
//line 355
___nl__7 = null;
//line 355
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 355
___nl__6 = null;
//line 356
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_add_error_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 357
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("err"), ___nl__5);
//line 357
___nl__1 = null;
//line 357
___nl__2 = null;
//line 357
___nl__3 = null;
//line 357
___nl__4 = null;
//line 357
___nl__5 = null;
//line 357
___arg__0.setValue(___nl__0);if(true) return ___nl__6;
//line 357
___nl__6 = null;
//line 357
___nl__5 = null;
//line 358
if (true) {goto label_27;}
//line 358
label_27:
//line 358
___nl__4 = null;
//line 359
if (true) {goto label_1;}
//line 359
label_26:
//line 360
___nl__4 = new ImmString("error in parse_expr:");
//line 360
___nl__5 = string_NL.NL_lf();

//line 360
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 360
___nl__5 = null;
//line 360
___nl__6 = new ImmString("state");
//line 360
___nl__6 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__6);

//line 360
___ref______nl__6 = new ImmRef(___nl__6);
___nl__5 = ntokenizer_NL.NL_info(___ref______nl__6);
___nl__6 = ___ref______nl__6.getValue();

//line 360
___nl__7 = new ImmString("state");
//line 360
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__7,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

//line 360
___nl__7 = null;
//line 360
___nl__6 = null;
//line 360
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 360
___nl__5 = null;
//line 361
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_add_error_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 362
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("err"), ___nl__4);
//line 362
___nl__1 = null;
//line 362
___nl__2 = null;
//line 362
___nl__3 = null;
//line 362
___nl__4 = null;
//line 362
___arg__0.setValue(___nl__0);if(true) return ___nl__5;
//line 362
___nl__5 = null;
//line 362
___nl__4 = null;
//line 363
if (true) {goto label_1;}
//line 363
label_1:
//line 363
___nl__3 = null;
//line 365
___ref______nl__0 = new ImmRef(___nl__0);
___nl__3 = nparser_NL.NL_parse_expr_rec_left_priv(___ref______nl__0,___nl__2,___nl__1);
___nl__0 = ___ref______nl__0.getValue();

//line 365
___nl__1 = null;
//line 365
___nl__2 = null;
//line 365
___arg__0.setValue(___nl__0);if(true) return ___nl__3;
//line 365
___nl__3 = null;
//line 365
___nl__2 = null;
//line 365
___nl__1 = null;
//line 365
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_eat_text_priv(ImmRef ___arg__0) {
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
//line 368
___nl__2 = new ImmString("state");
//line 368
___nl__2 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__2);

//line 368
___ref______nl__2 = new ImmRef(___nl__2);
___nl__1 = ntokenizer_NL.NL_is_text(___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue();

//line 368
___nl__3 = new ImmString("state");
//line 368
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__3,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 368
___nl__3 = null;
//line 368
___nl__2 = null;
//line 368
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1));
//line 368
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_2;}}
//line 369
___nl__3 = new ImmString("state");
//line 369
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__3);

//line 369
___ref______nl__3 = new ImmRef(___nl__3);
___nl__2 = ntokenizer_NL.NL_eat_text(___ref______nl__3);
___nl__3 = ___ref______nl__3.getValue();

//line 369
___nl__4 = new ImmString("state");
//line 369
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__4,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 369
___nl__4 = null;
//line 369
___nl__3 = null;
//line 369
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__2);
//line 369
___nl__1 = null;
//line 369
___arg__0.setValue(___nl__0);if(true) return ___nl__2;
//line 369
___nl__2 = null;
//line 370
if (true) {goto label_1;}
//line 370
label_2:
//line 371
___nl__2 = new ImmString("word expected");
//line 371
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_add_error_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 371
___nl__2 = null;
//line 372
___nl__2 = new ImmString("word expected");
//line 372
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("err"), ___nl__2);
//line 372
___nl__1 = null;
//line 372
___arg__0.setValue(___nl__0);if(true) return ___nl__2;
//line 372
___nl__2 = null;
//line 373
if (true) {goto label_1;}
//line 373
label_1:
//line 373
___nl__1 = null;
//line 373
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_parse_variant_label_priv(ImmRef ___arg__0) {
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
//line 377
___nl__2 = new ImmString("state");
//line 377
___nl__2 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__2);

//line 377
___ref______nl__2 = new ImmRef(___nl__2);
___nl__1 = ntokenizer_NL.NL_is_text(___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue();

//line 377
___nl__3 = new ImmString("state");
//line 377
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__3,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 377
___nl__3 = null;
//line 377
___nl__2 = null;
//line 377
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1));
//line 377
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_2;}}
//line 378
___nl__3 = new ImmString("state");
//line 378
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__3);

//line 378
___ref______nl__3 = new ImmRef(___nl__3);
___nl__2 = ntokenizer_NL.NL_eat_text(___ref______nl__3);
___nl__3 = ___ref______nl__3.getValue();

//line 378
___nl__4 = new ImmString("state");
//line 378
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__4,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 378
___nl__4 = null;
//line 378
___nl__3 = null;
//line 378
___nl__1 = null;
//line 378
___arg__0.setValue(___nl__0);if(true) return ___nl__2;
//line 378
___nl__2 = null;
//line 379
if (true) {goto label_1;}
//line 379
label_2:
//line 380
___nl__2 = new ImmString("word expected");
//line 380
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_add_error_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 380
___nl__2 = null;
//line 381
___nl__2 = new ImmString("");
//line 381
___nl__1 = null;
//line 381
___arg__0.setValue(___nl__0);if(true) return ___nl__2;
//line 381
___nl__2 = null;
//line 382
if (true) {goto label_1;}
//line 382
label_1:
//line 382
___nl__1 = null;
//line 382
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_parse_variant_priv(ImmRef ___arg__0) {
Imm ___nl__0 = ___arg__0.getValue().clone();
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
//line 386
___nl__1 = new ImmString(":");
//line 386
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__1);
___nl__0 = ___ref______nl__0.getValue();

//line 386
___nl__1 = null;
//line 387
___ref______nl__0 = new ImmRef(___nl__0);
___nl__1 = nparser_NL.NL_parse_variant_label_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 388
___nl__2 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("nop"));
//line 389
___nl__4 = new ImmString("(");
//line 389
___ref______nl__0 = new ImmRef(___nl__0);
___nl__3 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 389
___nl__4 = null;
//line 389
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 389
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 390
___ref______nl__0 = new ImmRef(___nl__0);
___nl__5 = nparser_NL.NL_parse_expr_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 390
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("ok"));
//line 390
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_3;}}
//line 390
___nl__1 = null;
//line 390
___nl__2 = null;
//line 390
___nl__3 = null;
//line 390
___nl__4 = null;
//line 390
___arg__0.setValue(___nl__0);if(true) return ___nl__5;
//line 390
label_3:
//line 390
___nl__2 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("ok"));
//line 390
___nl__4 = null;
//line 390
___nl__5 = null;
//line 391
___nl__4 = new ImmString(")");
//line 391
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 391
___nl__4 = null;
//line 392
if (true) {goto label_1;}
//line 392
label_2:
//line 393
___nl__4 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("nop"));
//line 393
___nl__2 = ___nl__4;
//line 393
___nl__4 = null;
//line 394
if (true) {goto label_1;}
//line 394
label_1:
//line 394
___nl__3 = null;
//line 395
__function_map = new Dictionary<String, Imm>();
__function_map.Add("name",___nl__1);
__function_map.Add("var",___nl__2);
___nl__3 = new ImmHash(__function_map);
//line 395
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__3);
//line 395
___nl__1 = null;
//line 395
___nl__2 = null;
//line 395
___arg__0.setValue(___nl__0);if(true) return ___nl__3;
//line 395
___nl__3 = null;
//line 395
___nl__1 = null;
//line 395
___nl__2 = null;
//line 395
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_check_lvalue_priv(ImmRef ___arg__0, Imm ___arg__1) {
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
//line 398
___nl__2 = ___nl__1;
//line 398
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("var"));
//line 398
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 398
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 399
___nl__1 = null;
//line 399
___nl__2 = null;
//line 399
___arg__0.setValue(___nl__0);if(true) return null;
//line 400
if (true) {goto label_3;}
//line 400
label_2:
//line 400
___nl__2 = ___nl__1;
//line 400
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("bin_op"));
//line 400
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 400
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_3;}}
//line 401
___nl__3 = ___nl__1;
//line 401
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("bin_op"));
//line 402
___nl__4 = ((ImmHash)___nl__3).getHashValue()["op"];
//line 402
___nl__5 = new ImmString("->");
//line 402
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__4.toString().Equals(___nl__5.toString()));
//line 402
___nl__5 = null;
//line 402
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_6;}}
//line 402
___nl__4 = ((ImmHash)___nl__3).getHashValue()["op"];
//line 402
___nl__5 = new ImmString("ARRAY_INDEX");
//line 402
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__4.toString().Equals(___nl__5.toString()));
//line 402
___nl__5 = null;
//line 402
label_6:
//line 402
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 402
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_5;}}
//line 403
___nl__5 = ((ImmHash)___nl__3).getHashValue()["left"];
//line 403
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_check_lvalue_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 403
___nl__5 = null;
//line 404
___nl__1 = null;
//line 404
___nl__2 = null;
//line 404
___nl__3 = null;
//line 404
___nl__4 = null;
//line 404
___arg__0.setValue(___nl__0);if(true) return null;
//line 405
if (true) {goto label_5;}
//line 405
label_5:
//line 405
___nl__4 = null;
//line 405
___nl__3 = null;
//line 406
if (true) {goto label_3;}
//line 406
label_3:
//line 406
___nl__2 = null;
//line 407
___nl__2 = new ImmString("invalid expr for lvalue");
//line 407
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_add_error_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 407
___nl__2 = null;
//line 407
___nl__1 = null;
//line 407
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_parse_variant_decl_priv(ImmRef ___arg__0) {
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
//line 410
___nl__1 = new ImmString(":");
//line 410
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__1);
___nl__0 = ___ref______nl__0.getValue();

//line 410
___nl__1 = null;
//line 411
___ref______nl__0 = new ImmRef(___nl__0);
___nl__2 = nparser_NL.NL_parse_variant_label_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 411
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none"));
//line 411
__function_map = new Dictionary<String, Imm>();
__function_map.Add("name",___nl__2);
__function_map.Add("value",___nl__3);
___nl__1 = new ImmHash(__function_map);
//line 411
___nl__2 = null;
//line 411
___nl__3 = null;
//line 412
___nl__3 = new ImmString("(");
//line 412
___ref______nl__0 = new ImmRef(___nl__0);
___nl__2 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 412
___nl__3 = null;
//line 412
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 412
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 413
___ref______nl__0 = new ImmRef(___nl__0);
___nl__3 = nparser_NL.NL_parse_var_decl_sim_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 413
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("value"), ___nl__3);
//line 413
___nl__4 = ___nl__3;
//line 413
((ImmHash)___nl__1).set("value", ___nl__4);
//line 413
___nl__3 = null;
//line 413
___nl__4 = null;
//line 414
___nl__3 = new ImmString(")");
//line 414
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 414
___nl__3 = null;
//line 415
if (true) {goto label_2;}
//line 415
label_2:
//line 415
___nl__2 = null;
//line 417
___arg__0.setValue(___nl__0);if(true) return ___nl__1;
//line 417
___nl__1 = null;
//line 417
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_parse_var_decl_priv(ImmRef ___arg__0) {
Imm ___nl__0 = ___arg__0.getValue().clone();
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
//line 421
___nl__1 = new ImmString("var");
//line 421
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__1);
___nl__0 = ___ref______nl__0.getValue();

//line 421
___nl__1 = null;
//line 422
___nl__2 = new ImmString("");
//line 422
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none"));
//line 422
___nl__4 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none"));
//line 422
__function_map = new Dictionary<String, Imm>();
__function_map.Add("name",___nl__2);
__function_map.Add("type",___nl__3);
__function_map.Add("value",___nl__4);
___nl__1 = new ImmHash(__function_map);
//line 422
___nl__2 = null;
//line 422
___nl__3 = null;
//line 422
___nl__4 = null;
//line 423
___nl__3 = new ImmString("state");
//line 423
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__3);

//line 423
___nl__4 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("word"));
//line 423
___ref______nl__3 = new ImmRef(___nl__3);
___nl__2 = ntokenizer_NL.NL_is_type(___ref______nl__3,___nl__4);
___nl__3 = ___ref______nl__3.getValue();

//line 423
___nl__4 = null;
//line 423
___nl__4 = new ImmString("state");
//line 423
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__4,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 423
___nl__4 = null;
//line 423
___nl__3 = null;
//line 423
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 423
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 424
___nl__4 = new ImmString("state");
//line 424
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__4);

//line 424
___nl__5 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("word"));
//line 424
___ref______nl__4 = new ImmRef(___nl__4);
___nl__3 = ntokenizer_NL.NL_eat_type(___ref______nl__4,___nl__5);
___nl__4 = ___ref______nl__4.getValue();

//line 424
___nl__5 = null;
//line 424
___nl__5 = new ImmString("state");
//line 424
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 424
___nl__5 = null;
//line 424
___nl__4 = null;
//line 424
___nl__4 = ___nl__3;
//line 424
((ImmHash)___nl__1).set("name", ___nl__4);
//line 424
___nl__3 = null;
//line 424
___nl__4 = null;
//line 425
if (true) {goto label_1;}
//line 425
label_2:
//line 426
___nl__3 = new ImmString("variable name expected");
//line 426
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_add_error_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 426
___nl__3 = null;
//line 427
if (true) {goto label_1;}
//line 427
label_1:
//line 427
___nl__2 = null;
//line 428
___nl__3 = new ImmString(":");
//line 428
___ref______nl__0 = new ImmRef(___nl__0);
___nl__2 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 428
___nl__3 = null;
//line 428
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 428
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_4;}}
//line 429
___ref______nl__0 = new ImmRef(___nl__0);
___nl__5 = nparser_NL.NL_parse_type_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 429
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("ok"));
//line 429
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_5;}}
//line 429
___nl__1 = null;
//line 429
___nl__2 = null;
//line 429
___nl__3 = null;
//line 429
___nl__4 = null;
//line 429
___arg__0.setValue(___nl__0);if(true) return ___nl__5;
//line 429
label_5:
//line 429
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("ok"));
//line 429
___nl__4 = null;
//line 429
___nl__5 = null;
//line 430
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("type"), ___nl__3);
//line 430
___nl__5 = ___nl__4;
//line 430
((ImmHash)___nl__1).set("type", ___nl__5);
//line 430
___nl__4 = null;
//line 430
___nl__5 = null;
//line 430
___nl__3 = null;
//line 431
if (true) {goto label_4;}
//line 431
label_4:
//line 431
___nl__2 = null;
//line 432
___nl__3 = new ImmString("=");
//line 432
___ref______nl__0 = new ImmRef(___nl__0);
___nl__2 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 432
___nl__3 = null;
//line 432
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 432
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_7;}}
//line 433
___ref______nl__0 = new ImmRef(___nl__0);
___nl__5 = nparser_NL.NL_parse_expr_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 433
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("ok"));
//line 433
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_8;}}
//line 433
___nl__1 = null;
//line 433
___nl__2 = null;
//line 433
___nl__3 = null;
//line 433
___nl__4 = null;
//line 433
___arg__0.setValue(___nl__0);if(true) return ___nl__5;
//line 433
label_8:
//line 433
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("ok"));
//line 433
___nl__4 = null;
//line 433
___nl__5 = null;
//line 434
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("value"), ___nl__3);
//line 434
___nl__5 = ___nl__4;
//line 434
((ImmHash)___nl__1).set("value", ___nl__5);
//line 434
___nl__4 = null;
//line 434
___nl__5 = null;
//line 434
___nl__3 = null;
//line 435
if (true) {goto label_7;}
//line 435
label_7:
//line 435
___nl__2 = null;
//line 436
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__1);
//line 436
___nl__1 = null;
//line 436
___arg__0.setValue(___nl__0);if(true) return ___nl__2;
//line 436
___nl__2 = null;
//line 436
___nl__1 = null;
//line 436
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_parse_var_decl_sim_priv(ImmRef ___arg__0) {
Imm ___nl__0 = ___arg__0.getValue().clone();
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
//line 440
___nl__1 = new ImmString("var");
//line 440
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__1);
___nl__0 = ___ref______nl__0.getValue();

//line 440
___nl__1 = null;
//line 441
___nl__2 = new ImmString("");
//line 441
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none"));
//line 441
___nl__4 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none"));
//line 441
__function_map = new Dictionary<String, Imm>();
__function_map.Add("name",___nl__2);
__function_map.Add("type",___nl__3);
__function_map.Add("value",___nl__4);
___nl__1 = new ImmHash(__function_map);
//line 441
___nl__2 = null;
//line 441
___nl__3 = null;
//line 441
___nl__4 = null;
//line 442
___nl__3 = new ImmString("state");
//line 442
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__3);

//line 442
___nl__4 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("word"));
//line 442
___ref______nl__3 = new ImmRef(___nl__3);
___nl__2 = ntokenizer_NL.NL_is_type(___ref______nl__3,___nl__4);
___nl__3 = ___ref______nl__3.getValue();

//line 442
___nl__4 = null;
//line 442
___nl__4 = new ImmString("state");
//line 442
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__4,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 442
___nl__4 = null;
//line 442
___nl__3 = null;
//line 442
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 442
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 443
___nl__4 = new ImmString("state");
//line 443
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__4);

//line 443
___nl__5 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("word"));
//line 443
___ref______nl__4 = new ImmRef(___nl__4);
___nl__3 = ntokenizer_NL.NL_eat_type(___ref______nl__4,___nl__5);
___nl__4 = ___ref______nl__4.getValue();

//line 443
___nl__5 = null;
//line 443
___nl__5 = new ImmString("state");
//line 443
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 443
___nl__5 = null;
//line 443
___nl__4 = null;
//line 443
___nl__4 = ___nl__3;
//line 443
((ImmHash)___nl__1).set("name", ___nl__4);
//line 443
___nl__3 = null;
//line 443
___nl__4 = null;
//line 444
if (true) {goto label_1;}
//line 444
label_2:
//line 445
___nl__3 = new ImmString("variable name expected");
//line 445
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_add_error_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 445
___nl__3 = null;
//line 446
if (true) {goto label_1;}
//line 446
label_1:
//line 446
___nl__2 = null;
//line 447
___arg__0.setValue(___nl__0);if(true) return ___nl__1;
//line 447
___nl__1 = null;
//line 447
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_parse_cond_priv(ImmRef ___arg__0) {
Imm ___nl__0 = ___arg__0.getValue().clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 450
___nl__1 = new ImmString("(");
//line 450
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__1);
___nl__0 = ___ref______nl__0.getValue();

//line 450
___nl__1 = null;
//line 451
___ref______nl__0 = new ImmRef(___nl__0);
___nl__3 = nparser_NL.NL_parse_expr_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 451
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("ok"));
//line 451
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_1;}}
//line 451
___nl__1 = null;
//line 451
___nl__2 = null;
//line 451
___arg__0.setValue(___nl__0);if(true) return ___nl__3;
//line 451
label_1:
//line 451
___nl__1 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("ok"));
//line 451
___nl__2 = null;
//line 451
___nl__3 = null;
//line 452
___nl__2 = new ImmString(")");
//line 452
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 452
___nl__2 = null;
//line 453
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__1);
//line 453
___nl__1 = null;
//line 453
___arg__0.setValue(___nl__0);if(true) return ___nl__2;
//line 453
___nl__2 = null;
//line 453
___nl__1 = null;
//line 453
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_parse_block_priv(ImmRef ___arg__0) {
Imm ___nl__0 = ___arg__0.getValue().clone();
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
//line 457
___nl__2 = new ImmString("state");
//line 457
___nl__2 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__2);

//line 457
___ref______nl__2 = new ImmRef(___nl__2);
___nl__1 = ntokenizer_NL.NL_get_place(___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue();

//line 457
___nl__3 = new ImmString("state");
//line 457
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__3,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 457
___nl__3 = null;
//line 457
___nl__2 = null;
//line 458
___nl__2 = new ImmString("{");
//line 458
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 458
___nl__2 = null;
//line 459
___nl__2 = new ImmArray(new Imm[0]);
//line 460
label_2:
//line 460
___nl__4 = new ImmString("}");
//line 460
___ref______nl__0 = new ImmRef(___nl__0);
___nl__3 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 460
___nl__4 = null;
//line 460
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 460
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 460
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_1;}}
//line 461
___nl__5 = new ImmString(";");
//line 461
___ref______nl__0 = new ImmRef(___nl__0);
___nl__4 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 461
___nl__5 = null;
//line 461
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 461
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_4;}}
//line 461
___nl__4 = null;
//line 461
if (true) {goto label_2;}
//line 461
if (true) {goto label_4;}
//line 461
label_4:
//line 461
___nl__4 = null;
//line 462
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = nparser_NL.NL_parse_cmd_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 462
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("ok"));
//line 462
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_5;}}
//line 462
___nl__1 = null;
//line 462
___nl__2 = null;
//line 462
___nl__3 = null;
//line 462
___nl__4 = null;
//line 462
___nl__5 = null;
//line 462
___arg__0.setValue(___nl__0);if(true) return ___nl__6;
//line 462
label_5:
//line 462
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("ok"));
//line 462
___nl__5 = null;
//line 462
___nl__6 = null;
//line 463
___ref______nl__2 = new ImmRef(___nl__2);
array_NL.NL_push(___ref______nl__2,___nl__4);
___nl__2 = ___ref______nl__2.getValue();

//line 463
___nl__4 = null;
//line 464
if (true) {goto label_2;}
//line 464
label_1:
//line 464
___nl__3 = null;
//line 465
___nl__4 = new ImmString("state");
//line 465
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__4);

//line 465
___ref______nl__4 = new ImmRef(___nl__4);
___nl__3 = ntokenizer_NL.NL_get_place_ws(___ref______nl__4);
___nl__4 = ___ref______nl__4.getValue();

//line 465
___nl__5 = new ImmString("state");
//line 465
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 465
___nl__5 = null;
//line 465
___nl__4 = null;
//line 466
__function_map = new Dictionary<String, Imm>();
__function_map.Add("begin",___nl__1);
__function_map.Add("end",___nl__3);
___nl__4 = new ImmHash(__function_map);
//line 470
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("block"), ___nl__2);
//line 470
__function_map = new Dictionary<String, Imm>();
__function_map.Add("debug",___nl__4);
__function_map.Add("cmd",___nl__6);
___nl__5 = new ImmHash(__function_map);
//line 470
___nl__6 = null;
//line 470
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__5);
//line 470
___nl__1 = null;
//line 470
___nl__2 = null;
//line 470
___nl__3 = null;
//line 470
___nl__4 = null;
//line 470
___arg__0.setValue(___nl__0);if(true) return ___nl__5;
//line 470
___nl__5 = null;
//line 470
___nl__1 = null;
//line 470
___nl__2 = null;
//line 470
___nl__3 = null;
//line 470
___nl__4 = null;
//line 470
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_parse_try_ensure_priv(ImmRef ___arg__0) {
Imm ___nl__0 = ___arg__0.getValue().clone();
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
//line 474
___nl__2 = new ImmString("state");
//line 474
___nl__2 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__2);

//line 474
___nl__3 = new ImmString("var");
//line 474
___ref______nl__2 = new ImmRef(___nl__2);
___nl__1 = ntokenizer_NL.NL_next_is(___ref______nl__2,___nl__3);
___nl__2 = ___ref______nl__2.getValue();

//line 474
___nl__3 = null;
//line 474
___nl__3 = new ImmString("state");
//line 474
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__3,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 474
___nl__3 = null;
//line 474
___nl__2 = null;
//line 474
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1));
//line 474
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_2;}}
//line 475
___ref______nl__0 = new ImmRef(___nl__0);
___nl__4 = nparser_NL.NL_parse_var_decl_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 475
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("ok"));
//line 475
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 475
___nl__1 = null;
//line 475
___nl__2 = null;
//line 475
___nl__3 = null;
//line 475
___arg__0.setValue(___nl__0);if(true) return ___nl__4;
//line 475
label_3:
//line 475
___nl__2 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("ok"));
//line 475
___nl__3 = null;
//line 475
___nl__4 = null;
//line 476
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("decl"), ___nl__2);
//line 476
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__3);
//line 476
___nl__1 = null;
//line 476
___nl__2 = null;
//line 476
___arg__0.setValue(___nl__0);if(true) return ___nl__3;
//line 476
___nl__3 = null;
//line 476
___nl__2 = null;
//line 477
if (true) {goto label_1;}
//line 477
label_2:
//line 478
___ref______nl__0 = new ImmRef(___nl__0);
___nl__4 = nparser_NL.NL_parse_expr_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 478
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("ok"));
//line 478
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_4;}}
//line 478
___nl__1 = null;
//line 478
___nl__2 = null;
//line 478
___nl__3 = null;
//line 478
___arg__0.setValue(___nl__0);if(true) return ___nl__4;
//line 478
label_4:
//line 478
___nl__2 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("ok"));
//line 478
___nl__3 = null;
//line 478
___nl__4 = null;
//line 479
___nl__3 = ___nl__2;
//line 479
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("bin_op"));
//line 479
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 479
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_7;}}
//line 479
___nl__3 = ___nl__2;
//line 479
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("bin_op"));
//line 479
___nl__3 = ((ImmHash)___nl__3).getHashValue()["op"];
//line 479
___nl__5 = new ImmString("=");
//line 479
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__5.toString()));
//line 479
___nl__5 = null;
//line 479
label_7:
//line 479
___nl__4 = null;
//line 479
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 479
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_6;}}
//line 480
___nl__4 = ___nl__2;
//line 480
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("bin_op"));
//line 480
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("lval"), ___nl__4);
//line 480
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__4);
//line 480
___nl__1 = null;
//line 480
___nl__2 = null;
//line 480
___nl__3 = null;
//line 480
___arg__0.setValue(___nl__0);if(true) return ___nl__4;
//line 480
___nl__4 = null;
//line 481
if (true) {goto label_5;}
//line 481
label_6:
//line 482
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("expr"), ___nl__2);
//line 482
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__4);
//line 482
___nl__1 = null;
//line 482
___nl__2 = null;
//line 482
___nl__3 = null;
//line 482
___arg__0.setValue(___nl__0);if(true) return ___nl__4;
//line 482
___nl__4 = null;
//line 483
if (true) {goto label_5;}
//line 483
label_5:
//line 483
___nl__3 = null;
//line 483
___nl__2 = null;
//line 484
if (true) {goto label_1;}
//line 484
label_1:
//line 484
___nl__1 = null;
//line 484
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_parse_cmd_priv(ImmRef ___arg__0) {
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
//line 488
___nl__2 = new ImmString("state");
//line 488
___nl__2 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__2);

//line 488
___ref______nl__2 = new ImmRef(___nl__2);
___nl__1 = ntokenizer_NL.NL_get_place(___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue();

//line 488
___nl__3 = new ImmString("state");
//line 488
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__3,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 488
___nl__3 = null;
//line 488
___nl__2 = null;
//line 490
___nl__4 = new ImmString("if");
//line 490
___ref______nl__0 = new ImmRef(___nl__0);
___nl__3 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 490
___nl__4 = null;
//line 490
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 490
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 491
__function_map = new Dictionary<String, Imm>();
___nl__4 = new ImmHash(__function_map);
//line 492
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = nparser_NL.NL_parse_cond_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 492
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("ok"));
//line 492
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_3;}}
//line 492
___nl__1 = null;
//line 492
___nl__2 = null;
//line 492
___nl__3 = null;
//line 492
___nl__4 = null;
//line 492
___nl__5 = null;
//line 492
___arg__0.setValue(___nl__0);if(true) return ___nl__6;
//line 492
label_3:
//line 492
___nl__7 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("ok"));
//line 492
((ImmHash)___nl__4).set("cond", ___nl__7);
//line 492
___nl__5 = null;
//line 492
___nl__6 = null;
//line 492
___nl__7 = null;
//line 493
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = nparser_NL.NL_parse_block_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 493
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("ok"));
//line 493
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_4;}}
//line 493
___nl__1 = null;
//line 493
___nl__2 = null;
//line 493
___nl__3 = null;
//line 493
___nl__4 = null;
//line 493
___nl__5 = null;
//line 493
___arg__0.setValue(___nl__0);if(true) return ___nl__6;
//line 493
label_4:
//line 493
___nl__7 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("ok"));
//line 493
((ImmHash)___nl__4).set("if", ___nl__7);
//line 493
___nl__5 = null;
//line 493
___nl__6 = null;
//line 493
___nl__7 = null;
//line 494
___nl__5 = new ImmArray(new Imm[0]);
//line 495
___nl__6 = new ImmArray(new Imm[0]);
//line 495
___nl__7 = ___nl__6;
//line 495
((ImmHash)___nl__4).set("elsif", ___nl__7);
//line 495
___nl__6 = null;
//line 495
___nl__7 = null;
//line 496
label_6:
//line 496
___nl__7 = new ImmString("elsif");
//line 496
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 496
___nl__7 = null;
//line 496
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 496
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_5;}}
//line 497
__function_map = new Dictionary<String, Imm>();
___nl__7 = new ImmHash(__function_map);
//line 498
___nl__9 = new ImmString("state");
//line 498
___nl__9 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__9);

//line 498
___ref______nl__9 = new ImmRef(___nl__9);
___nl__8 = ntokenizer_NL.NL_get_place(___ref______nl__9);
___nl__9 = ___ref______nl__9.getValue();

//line 498
___nl__10 = new ImmString("state");
//line 498
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__10,___nl__9);
___nl__0 = ___ref______nl__0.getValue();

//line 498
___nl__10 = null;
//line 498
___nl__9 = null;
//line 499
___ref______nl__0 = new ImmRef(___nl__0);
___nl__10 = nparser_NL.NL_parse_cond_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 499
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__10, new ImmString("ok"));
//line 499
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_7;}}
//line 499
___nl__1 = null;
//line 499
___nl__2 = null;
//line 499
___nl__3 = null;
//line 499
___nl__4 = null;
//line 499
___nl__5 = null;
//line 499
___nl__6 = null;
//line 499
___nl__7 = null;
//line 499
___nl__8 = null;
//line 499
___nl__9 = null;
//line 499
___arg__0.setValue(___nl__0);if(true) return ___nl__10;
//line 499
label_7:
//line 499
___nl__11 = c_rt_lib_NL.NL_ov_as(___nl__10, new ImmString("ok"));
//line 499
((ImmHash)___nl__7).set("cond", ___nl__11);
//line 499
___nl__9 = null;
//line 499
___nl__10 = null;
//line 499
___nl__11 = null;
//line 500
___nl__10 = new ImmString("state");
//line 500
___nl__10 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__10);

//line 500
___ref______nl__10 = new ImmRef(___nl__10);
___nl__9 = ntokenizer_NL.NL_get_place_ws(___ref______nl__10);
___nl__10 = ___ref______nl__10.getValue();

//line 500
___nl__11 = new ImmString("state");
//line 500
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__11,___nl__10);
___nl__0 = ___ref______nl__0.getValue();

//line 500
___nl__11 = null;
//line 500
___nl__10 = null;
//line 501
__function_map = new Dictionary<String, Imm>();
__function_map.Add("begin",___nl__8);
__function_map.Add("end",___nl__9);
___nl__10 = new ImmHash(__function_map);
//line 501
___nl__11 = ___nl__10;
//line 501
((ImmHash)___nl__7).set("debug", ___nl__11);
//line 501
___nl__10 = null;
//line 501
___nl__11 = null;
//line 502
___ref______nl__0 = new ImmRef(___nl__0);
___nl__11 = nparser_NL.NL_parse_block_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 502
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("ok"));
//line 502
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_8;}}
//line 502
___nl__1 = null;
//line 502
___nl__2 = null;
//line 502
___nl__3 = null;
//line 502
___nl__4 = null;
//line 502
___nl__5 = null;
//line 502
___nl__6 = null;
//line 502
___nl__7 = null;
//line 502
___nl__8 = null;
//line 502
___nl__9 = null;
//line 502
___nl__10 = null;
//line 502
___arg__0.setValue(___nl__0);if(true) return ___nl__11;
//line 502
label_8:
//line 502
___nl__12 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("ok"));
//line 502
((ImmHash)___nl__7).set("cmd", ___nl__12);
//line 502
___nl__10 = null;
//line 502
___nl__11 = null;
//line 502
___nl__12 = null;
//line 503
___ref______nl__5 = new ImmRef(___nl__5);
array_NL.NL_push(___ref______nl__5,___nl__7);
___nl__5 = ___ref______nl__5.getValue();

//line 503
___nl__7 = null;
//line 503
___nl__8 = null;
//line 503
___nl__9 = null;
//line 504
if (true) {goto label_6;}
//line 504
label_5:
//line 504
___nl__6 = null;
//line 505
___nl__6 = ___nl__5;
//line 505
((ImmHash)___nl__4).set("elsif", ___nl__6);
//line 505
___nl__6 = null;
//line 506
___nl__7 = new ImmString("else");
//line 506
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 506
___nl__7 = null;
//line 506
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 506
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_10;}}
//line 507
___ref______nl__0 = new ImmRef(___nl__0);
___nl__8 = nparser_NL.NL_parse_block_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 507
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("ok"));
//line 507
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_11;}}
//line 507
___nl__1 = null;
//line 507
___nl__2 = null;
//line 507
___nl__3 = null;
//line 507
___nl__4 = null;
//line 507
___nl__5 = null;
//line 507
___nl__6 = null;
//line 507
___nl__7 = null;
//line 507
___arg__0.setValue(___nl__0);if(true) return ___nl__8;
//line 507
label_11:
//line 507
___nl__9 = c_rt_lib_NL.NL_ov_as(___nl__8, new ImmString("ok"));
//line 507
((ImmHash)___nl__4).set("else", ___nl__9);
//line 507
___nl__7 = null;
//line 507
___nl__8 = null;
//line 507
___nl__9 = null;
//line 508
if (true) {goto label_9;}
//line 508
label_10:
//line 509
___nl__8 = nast_NL.NL_empty_debug();

//line 509
___nl__9 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("nop"));
//line 509
__function_map = new Dictionary<String, Imm>();
__function_map.Add("debug",___nl__8);
__function_map.Add("cmd",___nl__9);
___nl__7 = new ImmHash(__function_map);
//line 509
___nl__8 = null;
//line 509
___nl__9 = null;
//line 509
___nl__8 = ___nl__7;
//line 509
((ImmHash)___nl__4).set("else", ___nl__8);
//line 509
___nl__7 = null;
//line 509
___nl__8 = null;
//line 510
if (true) {goto label_9;}
//line 510
label_9:
//line 510
___nl__6 = null;
//line 511
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("if"), ___nl__4);
//line 511
___nl__2 = ___nl__6;
//line 511
___nl__6 = null;
//line 511
___nl__4 = null;
//line 511
___nl__5 = null;
//line 512
if (true) {goto label_1;}
//line 512
label_2:
//line 512
___nl__4 = new ImmString("fora");
//line 512
___ref______nl__0 = new ImmRef(___nl__0);
___nl__3 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 512
___nl__4 = null;
//line 512
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 512
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_12;}}
//line 513
__function_map = new Dictionary<String, Imm>();
___nl__4 = new ImmHash(__function_map);
//line 514
___nl__5 = c_rt_lib_NL.NL_get_false();
//line 514
___nl__6 = ___nl__5;
//line 514
((ImmHash)___nl__4).set("short", ___nl__6);
//line 514
___nl__5 = null;
//line 514
___nl__6 = null;
//line 515
___ref______nl__0 = new ImmRef(___nl__0);
___nl__5 = nparser_NL.NL_parse_var_decl_sim_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 515
___nl__6 = ___nl__5;
//line 515
((ImmHash)___nl__4).set("iter", ___nl__6);
//line 515
___nl__5 = null;
//line 515
___nl__6 = null;
//line 516
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = nparser_NL.NL_parse_cond_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 516
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("ok"));
//line 516
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_13;}}
//line 516
___nl__1 = null;
//line 516
___nl__2 = null;
//line 516
___nl__3 = null;
//line 516
___nl__4 = null;
//line 516
___nl__5 = null;
//line 516
___arg__0.setValue(___nl__0);if(true) return ___nl__6;
//line 516
label_13:
//line 516
___nl__7 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("ok"));
//line 516
((ImmHash)___nl__4).set("array", ___nl__7);
//line 516
___nl__5 = null;
//line 516
___nl__6 = null;
//line 516
___nl__7 = null;
//line 517
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = nparser_NL.NL_parse_block_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 517
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("ok"));
//line 517
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_14;}}
//line 517
___nl__1 = null;
//line 517
___nl__2 = null;
//line 517
___nl__3 = null;
//line 517
___nl__4 = null;
//line 517
___nl__5 = null;
//line 517
___arg__0.setValue(___nl__0);if(true) return ___nl__6;
//line 517
label_14:
//line 517
___nl__7 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("ok"));
//line 517
((ImmHash)___nl__4).set("cmd", ___nl__7);
//line 517
___nl__5 = null;
//line 517
___nl__6 = null;
//line 517
___nl__7 = null;
//line 518
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("fora"), ___nl__4);
//line 518
___nl__2 = ___nl__5;
//line 518
___nl__5 = null;
//line 518
___nl__4 = null;
//line 519
if (true) {goto label_1;}
//line 519
label_12:
//line 519
___nl__4 = new ImmString("rep");
//line 519
___ref______nl__0 = new ImmRef(___nl__0);
___nl__3 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 519
___nl__4 = null;
//line 519
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 519
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_15;}}
//line 520
__function_map = new Dictionary<String, Imm>();
___nl__4 = new ImmHash(__function_map);
//line 521
___nl__5 = c_rt_lib_NL.NL_get_false();
//line 521
___nl__6 = ___nl__5;
//line 521
((ImmHash)___nl__4).set("short", ___nl__6);
//line 521
___nl__5 = null;
//line 521
___nl__6 = null;
//line 522
___ref______nl__0 = new ImmRef(___nl__0);
___nl__5 = nparser_NL.NL_parse_var_decl_sim_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 522
___nl__6 = ___nl__5;
//line 522
((ImmHash)___nl__4).set("iter", ___nl__6);
//line 522
___nl__5 = null;
//line 522
___nl__6 = null;
//line 523
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = nparser_NL.NL_parse_cond_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 523
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("ok"));
//line 523
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_16;}}
//line 523
___nl__1 = null;
//line 523
___nl__2 = null;
//line 523
___nl__3 = null;
//line 523
___nl__4 = null;
//line 523
___nl__5 = null;
//line 523
___arg__0.setValue(___nl__0);if(true) return ___nl__6;
//line 523
label_16:
//line 523
___nl__7 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("ok"));
//line 523
((ImmHash)___nl__4).set("count", ___nl__7);
//line 523
___nl__5 = null;
//line 523
___nl__6 = null;
//line 523
___nl__7 = null;
//line 524
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = nparser_NL.NL_parse_block_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 524
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("ok"));
//line 524
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_17;}}
//line 524
___nl__1 = null;
//line 524
___nl__2 = null;
//line 524
___nl__3 = null;
//line 524
___nl__4 = null;
//line 524
___nl__5 = null;
//line 524
___arg__0.setValue(___nl__0);if(true) return ___nl__6;
//line 524
label_17:
//line 524
___nl__7 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("ok"));
//line 524
((ImmHash)___nl__4).set("cmd", ___nl__7);
//line 524
___nl__5 = null;
//line 524
___nl__6 = null;
//line 524
___nl__7 = null;
//line 525
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("rep"), ___nl__4);
//line 525
___nl__2 = ___nl__5;
//line 525
___nl__5 = null;
//line 525
___nl__4 = null;
//line 526
if (true) {goto label_1;}
//line 526
label_15:
//line 526
___nl__4 = new ImmString("loop");
//line 526
___ref______nl__0 = new ImmRef(___nl__0);
___nl__3 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 526
___nl__4 = null;
//line 526
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 526
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_18;}}
//line 527
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = nparser_NL.NL_parse_block_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 527
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("ok"));
//line 527
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_19;}}
//line 527
___nl__1 = null;
//line 527
___nl__2 = null;
//line 527
___nl__3 = null;
//line 527
___nl__4 = null;
//line 527
___nl__5 = null;
//line 527
___arg__0.setValue(___nl__0);if(true) return ___nl__6;
//line 527
label_19:
//line 527
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("ok"));
//line 527
___nl__5 = null;
//line 527
___nl__6 = null;
//line 528
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("loop"), ___nl__4);
//line 528
___nl__2 = ___nl__5;
//line 528
___nl__5 = null;
//line 528
___nl__4 = null;
//line 529
if (true) {goto label_1;}
//line 529
label_18:
//line 529
___nl__4 = new ImmString("forh");
//line 529
___ref______nl__0 = new ImmRef(___nl__0);
___nl__3 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 529
___nl__4 = null;
//line 529
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 529
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_20;}}
//line 530
__function_map = new Dictionary<String, Imm>();
___nl__4 = new ImmHash(__function_map);
//line 531
___nl__5 = c_rt_lib_NL.NL_get_false();
//line 531
___nl__6 = ___nl__5;
//line 531
((ImmHash)___nl__4).set("short", ___nl__6);
//line 531
___nl__5 = null;
//line 531
___nl__6 = null;
//line 532
___ref______nl__0 = new ImmRef(___nl__0);
___nl__5 = nparser_NL.NL_parse_var_decl_sim_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 532
___nl__6 = ___nl__5;
//line 532
((ImmHash)___nl__4).set("key", ___nl__6);
//line 532
___nl__5 = null;
//line 532
___nl__6 = null;
//line 533
___nl__5 = new ImmString(",");
//line 533
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 533
___nl__5 = null;
//line 534
___ref______nl__0 = new ImmRef(___nl__0);
___nl__5 = nparser_NL.NL_parse_var_decl_sim_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 534
___nl__6 = ___nl__5;
//line 534
((ImmHash)___nl__4).set("val", ___nl__6);
//line 534
___nl__5 = null;
//line 534
___nl__6 = null;
//line 535
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = nparser_NL.NL_parse_cond_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 535
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("ok"));
//line 535
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_21;}}
//line 535
___nl__1 = null;
//line 535
___nl__2 = null;
//line 535
___nl__3 = null;
//line 535
___nl__4 = null;
//line 535
___nl__5 = null;
//line 535
___arg__0.setValue(___nl__0);if(true) return ___nl__6;
//line 535
label_21:
//line 535
___nl__7 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("ok"));
//line 535
((ImmHash)___nl__4).set("hash", ___nl__7);
//line 535
___nl__5 = null;
//line 535
___nl__6 = null;
//line 535
___nl__7 = null;
//line 536
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = nparser_NL.NL_parse_block_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 536
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("ok"));
//line 536
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_22;}}
//line 536
___nl__1 = null;
//line 536
___nl__2 = null;
//line 536
___nl__3 = null;
//line 536
___nl__4 = null;
//line 536
___nl__5 = null;
//line 536
___arg__0.setValue(___nl__0);if(true) return ___nl__6;
//line 536
label_22:
//line 536
___nl__7 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("ok"));
//line 536
((ImmHash)___nl__4).set("cmd", ___nl__7);
//line 536
___nl__5 = null;
//line 536
___nl__6 = null;
//line 536
___nl__7 = null;
//line 537
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("forh"), ___nl__4);
//line 537
___nl__2 = ___nl__5;
//line 537
___nl__5 = null;
//line 537
___nl__4 = null;
//line 538
if (true) {goto label_1;}
//line 538
label_20:
//line 538
___nl__4 = new ImmString("while");
//line 538
___ref______nl__0 = new ImmRef(___nl__0);
___nl__3 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 538
___nl__4 = null;
//line 538
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 538
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_23;}}
//line 539
__function_map = new Dictionary<String, Imm>();
___nl__4 = new ImmHash(__function_map);
//line 540
___nl__5 = c_rt_lib_NL.NL_get_false();
//line 540
___nl__6 = ___nl__5;
//line 540
((ImmHash)___nl__4).set("short", ___nl__6);
//line 540
___nl__5 = null;
//line 540
___nl__6 = null;
//line 541
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = nparser_NL.NL_parse_cond_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 541
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("ok"));
//line 541
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_24;}}
//line 541
___nl__1 = null;
//line 541
___nl__2 = null;
//line 541
___nl__3 = null;
//line 541
___nl__4 = null;
//line 541
___nl__5 = null;
//line 541
___arg__0.setValue(___nl__0);if(true) return ___nl__6;
//line 541
label_24:
//line 541
___nl__7 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("ok"));
//line 541
((ImmHash)___nl__4).set("cond", ___nl__7);
//line 541
___nl__5 = null;
//line 541
___nl__6 = null;
//line 541
___nl__7 = null;
//line 542
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = nparser_NL.NL_parse_block_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 542
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("ok"));
//line 542
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_25;}}
//line 542
___nl__1 = null;
//line 542
___nl__2 = null;
//line 542
___nl__3 = null;
//line 542
___nl__4 = null;
//line 542
___nl__5 = null;
//line 542
___arg__0.setValue(___nl__0);if(true) return ___nl__6;
//line 542
label_25:
//line 542
___nl__7 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("ok"));
//line 542
((ImmHash)___nl__4).set("cmd", ___nl__7);
//line 542
___nl__5 = null;
//line 542
___nl__6 = null;
//line 542
___nl__7 = null;
//line 543
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("while"), ___nl__4);
//line 543
___nl__2 = ___nl__5;
//line 543
___nl__5 = null;
//line 543
___nl__4 = null;
//line 544
if (true) {goto label_1;}
//line 544
label_23:
//line 544
___nl__4 = new ImmString("for");
//line 544
___ref______nl__0 = new ImmRef(___nl__0);
___nl__3 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 544
___nl__4 = null;
//line 544
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 544
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_26;}}
//line 545
__function_map = new Dictionary<String, Imm>();
___nl__4 = new ImmHash(__function_map);
//line 546
___nl__5 = new ImmString("(");
//line 546
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 546
___nl__5 = null;
//line 547
___nl__6 = new ImmString("state");
//line 547
___nl__6 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__6);

//line 547
___nl__7 = new ImmString("var");
//line 547
___ref______nl__6 = new ImmRef(___nl__6);
___nl__5 = ntokenizer_NL.NL_next_is(___ref______nl__6,___nl__7);
___nl__6 = ___ref______nl__6.getValue();

//line 547
___nl__7 = null;
//line 547
___nl__7 = new ImmString("state");
//line 547
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__7,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

//line 547
___nl__7 = null;
//line 547
___nl__6 = null;
//line 547
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 547
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_28;}}
//line 548
___ref______nl__0 = new ImmRef(___nl__0);
___nl__8 = nparser_NL.NL_parse_var_decl_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 548
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("ok"));
//line 548
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_29;}}
//line 548
___nl__1 = null;
//line 548
___nl__2 = null;
//line 548
___nl__3 = null;
//line 548
___nl__4 = null;
//line 548
___nl__5 = null;
//line 548
___nl__6 = null;
//line 548
___nl__7 = null;
//line 548
___arg__0.setValue(___nl__0);if(true) return ___nl__8;
//line 548
label_29:
//line 548
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__8, new ImmString("ok"));
//line 548
___nl__7 = null;
//line 548
___nl__8 = null;
//line 549
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("var_decl"), ___nl__6);
//line 549
___nl__8 = ___nl__7;
//line 549
((ImmHash)___nl__4).set("start", ___nl__8);
//line 549
___nl__7 = null;
//line 549
___nl__8 = null;
//line 549
___nl__6 = null;
//line 550
if (true) {goto label_27;}
//line 550
label_28:
//line 550
___nl__6 = new ImmString("state");
//line 550
___nl__6 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__6);

//line 550
___nl__7 = new ImmString(";");
//line 550
___ref______nl__6 = new ImmRef(___nl__6);
___nl__5 = ntokenizer_NL.NL_next_is(___ref______nl__6,___nl__7);
___nl__6 = ___ref______nl__6.getValue();

//line 550
___nl__7 = null;
//line 550
___nl__7 = new ImmString("state");
//line 550
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__7,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

//line 550
___nl__7 = null;
//line 550
___nl__6 = null;
//line 550
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 550
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_30;}}
//line 551
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("nop"));
//line 551
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("value"), ___nl__6);
//line 551
___nl__7 = ___nl__6;
//line 551
((ImmHash)___nl__4).set("start", ___nl__7);
//line 551
___nl__6 = null;
//line 551
___nl__7 = null;
//line 552
if (true) {goto label_27;}
//line 552
label_30:
//line 553
___ref______nl__0 = new ImmRef(___nl__0);
___nl__8 = nparser_NL.NL_parse_expr_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 553
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("ok"));
//line 553
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_31;}}
//line 553
___nl__1 = null;
//line 553
___nl__2 = null;
//line 553
___nl__3 = null;
//line 553
___nl__4 = null;
//line 553
___nl__5 = null;
//line 553
___nl__6 = null;
//line 553
___nl__7 = null;
//line 553
___arg__0.setValue(___nl__0);if(true) return ___nl__8;
//line 553
label_31:
//line 553
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__8, new ImmString("ok"));
//line 553
___nl__7 = null;
//line 553
___nl__8 = null;
//line 554
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("value"), ___nl__6);
//line 554
___nl__8 = ___nl__7;
//line 554
((ImmHash)___nl__4).set("start", ___nl__8);
//line 554
___nl__7 = null;
//line 554
___nl__8 = null;
//line 554
___nl__6 = null;
//line 555
if (true) {goto label_27;}
//line 555
label_27:
//line 555
___nl__5 = null;
//line 556
___nl__5 = new ImmString(";");
//line 556
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 556
___nl__5 = null;
//line 557
___nl__5 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("nop"));
//line 557
___nl__6 = ___nl__5;
//line 557
((ImmHash)___nl__4).set("cond", ___nl__6);
//line 557
___nl__5 = null;
//line 557
___nl__6 = null;
//line 558
___nl__6 = new ImmString("state");
//line 558
___nl__6 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__6);

//line 558
___nl__7 = new ImmString(";");
//line 558
___ref______nl__6 = new ImmRef(___nl__6);
___nl__5 = ntokenizer_NL.NL_next_is(___ref______nl__6,___nl__7);
___nl__6 = ___ref______nl__6.getValue();

//line 558
___nl__7 = null;
//line 558
___nl__7 = new ImmString("state");
//line 558
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__7,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

//line 558
___nl__7 = null;
//line 558
___nl__6 = null;
//line 558
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 558
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 558
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_33;}}
//line 558
___ref______nl__0 = new ImmRef(___nl__0);
___nl__7 = nparser_NL.NL_parse_expr_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 558
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("ok"));
//line 558
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_34;}}
//line 558
___nl__1 = null;
//line 558
___nl__2 = null;
//line 558
___nl__3 = null;
//line 558
___nl__4 = null;
//line 558
___nl__5 = null;
//line 558
___nl__6 = null;
//line 558
___arg__0.setValue(___nl__0);if(true) return ___nl__7;
//line 558
label_34:
//line 558
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__7, new ImmString("ok"));
//line 558
((ImmHash)___nl__4).set("cond", ___nl__8);
//line 558
___nl__6 = null;
//line 558
___nl__7 = null;
//line 558
___nl__8 = null;
//line 558
if (true) {goto label_33;}
//line 558
label_33:
//line 558
___nl__5 = null;
//line 559
___nl__5 = new ImmString(";");
//line 559
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 559
___nl__5 = null;
//line 560
___nl__5 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("nop"));
//line 560
___nl__6 = ___nl__5;
//line 560
((ImmHash)___nl__4).set("iter", ___nl__6);
//line 560
___nl__5 = null;
//line 560
___nl__6 = null;
//line 561
___nl__6 = new ImmString("state");
//line 561
___nl__6 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__6);

//line 561
___nl__7 = new ImmString(")");
//line 561
___ref______nl__6 = new ImmRef(___nl__6);
___nl__5 = ntokenizer_NL.NL_next_is(___ref______nl__6,___nl__7);
___nl__6 = ___ref______nl__6.getValue();

//line 561
___nl__7 = null;
//line 561
___nl__7 = new ImmString("state");
//line 561
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__7,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

//line 561
___nl__7 = null;
//line 561
___nl__6 = null;
//line 561
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 561
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 561
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_36;}}
//line 561
___ref______nl__0 = new ImmRef(___nl__0);
___nl__7 = nparser_NL.NL_parse_expr_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 561
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("ok"));
//line 561
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_37;}}
//line 561
___nl__1 = null;
//line 561
___nl__2 = null;
//line 561
___nl__3 = null;
//line 561
___nl__4 = null;
//line 561
___nl__5 = null;
//line 561
___nl__6 = null;
//line 561
___arg__0.setValue(___nl__0);if(true) return ___nl__7;
//line 561
label_37:
//line 561
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__7, new ImmString("ok"));
//line 561
((ImmHash)___nl__4).set("iter", ___nl__8);
//line 561
___nl__6 = null;
//line 561
___nl__7 = null;
//line 561
___nl__8 = null;
//line 561
if (true) {goto label_36;}
//line 561
label_36:
//line 561
___nl__5 = null;
//line 562
___nl__5 = new ImmString(")");
//line 562
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 562
___nl__5 = null;
//line 563
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = nparser_NL.NL_parse_block_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 563
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("ok"));
//line 563
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_38;}}
//line 563
___nl__1 = null;
//line 563
___nl__2 = null;
//line 563
___nl__3 = null;
//line 563
___nl__4 = null;
//line 563
___nl__5 = null;
//line 563
___arg__0.setValue(___nl__0);if(true) return ___nl__6;
//line 563
label_38:
//line 563
___nl__7 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("ok"));
//line 563
((ImmHash)___nl__4).set("cmd", ___nl__7);
//line 563
___nl__5 = null;
//line 563
___nl__6 = null;
//line 563
___nl__7 = null;
//line 564
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("for"), ___nl__4);
//line 564
___nl__2 = ___nl__5;
//line 564
___nl__5 = null;
//line 564
___nl__4 = null;
//line 565
if (true) {goto label_1;}
//line 565
label_26:
//line 565
___nl__4 = new ImmString("state");
//line 565
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__4);

//line 565
___nl__5 = new ImmString("{");
//line 565
___ref______nl__4 = new ImmRef(___nl__4);
___nl__3 = ntokenizer_NL.NL_next_is(___ref______nl__4,___nl__5);
___nl__4 = ___ref______nl__4.getValue();

//line 565
___nl__5 = null;
//line 565
___nl__5 = new ImmString("state");
//line 565
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 565
___nl__5 = null;
//line 565
___nl__4 = null;
//line 565
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 565
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_39;}}
//line 566
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = nparser_NL.NL_parse_block_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 566
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("ok"));
//line 566
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_40;}}
//line 566
___nl__1 = null;
//line 566
___nl__2 = null;
//line 566
___nl__3 = null;
//line 566
___nl__4 = null;
//line 566
___nl__5 = null;
//line 566
___arg__0.setValue(___nl__0);if(true) return ___nl__6;
//line 566
label_40:
//line 566
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("ok"));
//line 566
___nl__5 = null;
//line 566
___nl__6 = null;
//line 567
___nl__5 = ((ImmHash)___nl__4).getHashValue()["cmd"];
//line 567
___nl__2 = ___nl__5;
//line 567
___nl__5 = null;
//line 567
___nl__4 = null;
//line 568
if (true) {goto label_1;}
//line 568
label_39:
//line 568
___nl__4 = new ImmString("break");
//line 568
___ref______nl__0 = new ImmRef(___nl__0);
___nl__3 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 568
___nl__4 = null;
//line 568
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 568
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_41;}}
//line 569
___nl__4 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("break"));
//line 569
___nl__2 = ___nl__4;
//line 569
___nl__4 = null;
//line 570
if (true) {goto label_1;}
//line 570
label_41:
//line 570
___nl__4 = new ImmString("continue");
//line 570
___ref______nl__0 = new ImmRef(___nl__0);
___nl__3 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 570
___nl__4 = null;
//line 570
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 570
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_42;}}
//line 571
___nl__4 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("continue"));
//line 571
___nl__2 = ___nl__4;
//line 571
___nl__4 = null;
//line 572
if (true) {goto label_1;}
//line 572
label_42:
//line 572
___nl__4 = new ImmString("return");
//line 572
___ref______nl__0 = new ImmRef(___nl__0);
___nl__3 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 572
___nl__4 = null;
//line 572
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 572
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_43;}}
//line 573
___nl__5 = new ImmString("state");
//line 573
___nl__5 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__5);

//line 573
___ref______nl__5 = new ImmRef(___nl__5);
___nl__4 = ntokenizer_NL.NL_get_token(___ref______nl__5);
___nl__5 = ___ref______nl__5.getValue();

//line 573
___nl__6 = new ImmString("state");
//line 573
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__6,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 573
___nl__6 = null;
//line 573
___nl__5 = null;
//line 574
___nl__5 = c_rt_lib_NL.NL_get_false();
//line 575
___nl__6 = nparser_NL.NL_get_end_list_priv();

//line 575
___nl__8 = new ImmDouble(0);
//line 575
___nl__9 = new ImmDouble(1);
//line 575
___nl__10 = c_rt_lib_NL.NL_array_len(___nl__6);

//line 575
label_46:
//line 575
___nl__11 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString()))>=(Double.Parse(___nl__10.getValue().ToString())) );
//line 575
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_44;}}
//line 575
___nl__7 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 576
___nl__12 = c_rt_lib_NL.NL_native_to_nl(___nl__4.toString().Equals(___nl__7.toString()));
//line 576
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12));
//line 576
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_48;}}
//line 577
___nl__13 = c_rt_lib_NL.NL_get_true();
//line 577
___nl__5 = ___nl__13;
//line 577
___nl__13 = null;
//line 578
___nl__12 = null;
//line 578
if (true) {goto label_44;}
//line 579
if (true) {goto label_48;}
//line 579
label_48:
//line 579
___nl__12 = null;
//line 580
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))+(Double.Parse(___nl__9.getValue().ToString())));
//line 580
if (true) {goto label_46;}
//line 580
label_44:
//line 580
___nl__6 = null;
//line 580
___nl__7 = null;
//line 580
___nl__8 = null;
//line 580
___nl__9 = null;
//line 580
___nl__10 = null;
//line 580
___nl__11 = null;
//line 581
___nl__6 = ___nl__5;
//line 581
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 581
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_50;}}
//line 582
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("nop"));
//line 582
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("return"), ___nl__7);
//line 582
___nl__2 = ___nl__7;
//line 582
___nl__7 = null;
//line 583
if (true) {goto label_49;}
//line 583
label_50:
//line 584
___ref______nl__0 = new ImmRef(___nl__0);
___nl__9 = nparser_NL.NL_parse_expr_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 584
___nl__8 = c_rt_lib_NL.NL_ov_is(___nl__9, new ImmString("ok"));
//line 584
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_51;}}
//line 584
___nl__1 = null;
//line 584
___nl__2 = null;
//line 584
___nl__3 = null;
//line 584
___nl__4 = null;
//line 584
___nl__5 = null;
//line 584
___nl__6 = null;
//line 584
___nl__7 = null;
//line 584
___nl__8 = null;
//line 584
___arg__0.setValue(___nl__0);if(true) return ___nl__9;
//line 584
label_51:
//line 584
___nl__7 = c_rt_lib_NL.NL_ov_as(___nl__9, new ImmString("ok"));
//line 584
___nl__8 = null;
//line 584
___nl__9 = null;
//line 585
___nl__8 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("return"), ___nl__7);
//line 585
___nl__2 = ___nl__8;
//line 585
___nl__8 = null;
//line 585
___nl__7 = null;
//line 586
if (true) {goto label_49;}
//line 586
label_49:
//line 586
___nl__6 = null;
//line 586
___nl__4 = null;
//line 586
___nl__5 = null;
//line 587
if (true) {goto label_1;}
//line 587
label_43:
//line 587
___nl__4 = new ImmString("match");
//line 587
___ref______nl__0 = new ImmRef(___nl__0);
___nl__3 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 587
___nl__4 = null;
//line 587
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 587
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_52;}}
//line 588
___nl__4 = new ImmString("(");
//line 588
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 588
___nl__4 = null;
//line 589
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = nparser_NL.NL_parse_expr_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 589
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("ok"));
//line 589
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_53;}}
//line 589
___nl__1 = null;
//line 589
___nl__2 = null;
//line 589
___nl__3 = null;
//line 589
___nl__4 = null;
//line 589
___nl__5 = null;
//line 589
___arg__0.setValue(___nl__0);if(true) return ___nl__6;
//line 589
label_53:
//line 589
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("ok"));
//line 589
___nl__5 = null;
//line 589
___nl__6 = null;
//line 590
___nl__6 = new ImmArray(new Imm[0]);
//line 590
__function_map = new Dictionary<String, Imm>();
__function_map.Add("val",___nl__4);
__function_map.Add("branch_list",___nl__6);
___nl__5 = new ImmHash(__function_map);
//line 590
___nl__6 = null;
//line 591
___nl__6 = new ImmString(")");
//line 591
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

//line 591
___nl__6 = null;
//line 592
___nl__7 = new ImmString("state");
//line 592
___nl__7 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__7);

//line 592
___ref______nl__7 = new ImmRef(___nl__7);
___nl__6 = ntokenizer_NL.NL_get_place(___ref______nl__7);
___nl__7 = ___ref______nl__7.getValue();

//line 592
___nl__8 = new ImmString("state");
//line 592
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__8,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 592
___nl__8 = null;
//line 592
___nl__7 = null;
//line 593
label_55:
//line 593
___nl__8 = new ImmString("case");
//line 593
___ref______nl__0 = new ImmRef(___nl__0);
___nl__7 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__8);
___nl__0 = ___ref______nl__0.getValue();

//line 593
___nl__8 = null;
//line 593
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 593
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_54;}}
//line 594
___ref______nl__0 = new ImmRef(___nl__0);
___nl__9 = nparser_NL.NL_parse_variant_decl_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 594
__function_map = new Dictionary<String, Imm>();
__function_map.Add("variant",___nl__9);
___nl__8 = new ImmHash(__function_map);
//line 594
___nl__9 = null;
//line 595
___nl__11 = new ImmString("state");
//line 595
___nl__11 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__11);

//line 595
___ref______nl__11 = new ImmRef(___nl__11);
___nl__10 = ntokenizer_NL.NL_get_place_ws(___ref______nl__11);
___nl__11 = ___ref______nl__11.getValue();

//line 595
___nl__12 = new ImmString("state");
//line 595
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__12,___nl__11);
___nl__0 = ___ref______nl__0.getValue();

//line 595
___nl__12 = null;
//line 595
___nl__11 = null;
//line 595
__function_map = new Dictionary<String, Imm>();
__function_map.Add("begin",___nl__6);
__function_map.Add("end",___nl__10);
___nl__9 = new ImmHash(__function_map);
//line 595
___nl__10 = null;
//line 595
___nl__10 = ___nl__9;
//line 595
((ImmHash)___nl__8).set("debug", ___nl__10);
//line 595
___nl__9 = null;
//line 595
___nl__10 = null;
//line 596
___ref______nl__0 = new ImmRef(___nl__0);
___nl__10 = nparser_NL.NL_parse_block_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 596
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__10, new ImmString("ok"));
//line 596
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_56;}}
//line 596
___nl__1 = null;
//line 596
___nl__2 = null;
//line 596
___nl__3 = null;
//line 596
___nl__4 = null;
//line 596
___nl__5 = null;
//line 596
___nl__6 = null;
//line 596
___nl__7 = null;
//line 596
___nl__8 = null;
//line 596
___nl__9 = null;
//line 596
___arg__0.setValue(___nl__0);if(true) return ___nl__10;
//line 596
label_56:
//line 596
___nl__11 = c_rt_lib_NL.NL_ov_as(___nl__10, new ImmString("ok"));
//line 596
((ImmHash)___nl__8).set("cmd", ___nl__11);
//line 596
___nl__9 = null;
//line 596
___nl__10 = null;
//line 596
___nl__11 = null;
//line 597
___nl__9 = new ImmString("branch_list");
//line 597
___nl__9 = c_rt_lib_NL.NL_get_ref_hash(___nl__5,___nl__9);

//line 597
___ref______nl__9 = new ImmRef(___nl__9);
array_NL.NL_push(___ref______nl__9,___nl__8);
___nl__9 = ___ref______nl__9.getValue();

//line 597
___nl__10 = new ImmString("branch_list");
//line 597
___ref______nl__5 = new ImmRef(___nl__5);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__5,___nl__10,___nl__9);
___nl__5 = ___ref______nl__5.getValue();

//line 597
___nl__10 = null;
//line 597
___nl__9 = null;
//line 598
___nl__10 = new ImmString("state");
//line 598
___nl__10 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__10);

//line 598
___ref______nl__10 = new ImmRef(___nl__10);
___nl__9 = ntokenizer_NL.NL_get_place(___ref______nl__10);
___nl__10 = ___ref______nl__10.getValue();

//line 598
___nl__11 = new ImmString("state");
//line 598
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__11,___nl__10);
___nl__0 = ___ref______nl__0.getValue();

//line 598
___nl__11 = null;
//line 598
___nl__10 = null;
//line 598
___nl__6 = ___nl__9;
//line 598
___nl__9 = null;
//line 598
___nl__8 = null;
//line 599
if (true) {goto label_55;}
//line 599
label_54:
//line 599
___nl__7 = null;
//line 601
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("match"), ___nl__5);
//line 601
___nl__2 = ___nl__7;
//line 601
___nl__7 = null;
//line 601
___nl__4 = null;
//line 601
___nl__5 = null;
//line 601
___nl__6 = null;
//line 602
if (true) {goto label_1;}
//line 602
label_52:
//line 602
___nl__4 = new ImmString("die");
//line 602
___ref______nl__0 = new ImmRef(___nl__0);
___nl__3 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 602
___nl__4 = null;
//line 602
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 602
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_57;}}
//line 603
___nl__4 = new ImmArray(new Imm[0]);
//line 604
___nl__6 = new ImmString("(");
//line 604
___ref______nl__0 = new ImmRef(___nl__0);
___nl__5 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

//line 604
___nl__6 = null;
//line 604
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 604
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_59;}}
//line 605
___ref______nl__0 = new ImmRef(___nl__0);
___nl__7 = nparser_NL.NL_parse_expr_list_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 605
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("ok"));
//line 605
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_60;}}
//line 605
___nl__1 = null;
//line 605
___nl__2 = null;
//line 605
___nl__3 = null;
//line 605
___nl__4 = null;
//line 605
___nl__5 = null;
//line 605
___nl__6 = null;
//line 605
___arg__0.setValue(___nl__0);if(true) return ___nl__7;
//line 605
label_60:
//line 605
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__7, new ImmString("ok"));
//line 605
___nl__6 = null;
//line 605
___nl__7 = null;
//line 606
if (true) {goto label_59;}
//line 606
label_59:
//line 606
___nl__5 = null;
//line 608
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("die"), ___nl__4);
//line 608
___nl__2 = ___nl__5;
//line 608
___nl__5 = null;
//line 608
___nl__4 = null;
//line 609
if (true) {goto label_1;}
//line 609
label_57:
//line 609
___nl__4 = new ImmString("state");
//line 609
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__4);

//line 609
___nl__5 = new ImmString("var");
//line 609
___ref______nl__4 = new ImmRef(___nl__4);
___nl__3 = ntokenizer_NL.NL_next_is(___ref______nl__4,___nl__5);
___nl__4 = ___ref______nl__4.getValue();

//line 609
___nl__5 = null;
//line 609
___nl__5 = new ImmString("state");
//line 609
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 609
___nl__5 = null;
//line 609
___nl__4 = null;
//line 609
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 609
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_61;}}
//line 610
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = nparser_NL.NL_parse_var_decl_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 610
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("ok"));
//line 610
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_62;}}
//line 610
___nl__1 = null;
//line 610
___nl__2 = null;
//line 610
___nl__3 = null;
//line 610
___nl__4 = null;
//line 610
___nl__5 = null;
//line 610
___arg__0.setValue(___nl__0);if(true) return ___nl__6;
//line 610
label_62:
//line 610
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("ok"));
//line 610
___nl__5 = null;
//line 610
___nl__6 = null;
//line 611
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("var_decl"), ___nl__4);
//line 611
___nl__2 = ___nl__5;
//line 611
___nl__5 = null;
//line 612
___nl__5 = new ImmString(";");
//line 612
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 612
___nl__5 = null;
//line 612
___nl__4 = null;
//line 613
if (true) {goto label_1;}
//line 613
label_61:
//line 613
___nl__4 = new ImmString("state");
//line 613
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__4);

//line 613
___nl__5 = new ImmString("try");
//line 613
___ref______nl__4 = new ImmRef(___nl__4);
___nl__3 = ntokenizer_NL.NL_next_is(___ref______nl__4,___nl__5);
___nl__4 = ___ref______nl__4.getValue();

//line 613
___nl__5 = null;
//line 613
___nl__5 = new ImmString("state");
//line 613
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 613
___nl__5 = null;
//line 613
___nl__4 = null;
//line 613
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 613
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_63;}}
//line 614
___nl__4 = new ImmString("try");
//line 614
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 614
___nl__4 = null;
//line 615
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = nparser_NL.NL_parse_try_ensure_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 615
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("ok"));
//line 615
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_64;}}
//line 615
___nl__1 = null;
//line 615
___nl__2 = null;
//line 615
___nl__3 = null;
//line 615
___nl__4 = null;
//line 615
___nl__5 = null;
//line 615
___arg__0.setValue(___nl__0);if(true) return ___nl__6;
//line 615
label_64:
//line 615
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("ok"));
//line 615
___nl__5 = null;
//line 615
___nl__6 = null;
//line 616
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("try"), ___nl__4);
//line 616
___nl__2 = ___nl__5;
//line 616
___nl__5 = null;
//line 616
___nl__4 = null;
//line 617
if (true) {goto label_1;}
//line 617
label_63:
//line 617
___nl__4 = new ImmString("state");
//line 617
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__4);

//line 617
___nl__5 = new ImmString("ensure");
//line 617
___ref______nl__4 = new ImmRef(___nl__4);
___nl__3 = ntokenizer_NL.NL_next_is(___ref______nl__4,___nl__5);
___nl__4 = ___ref______nl__4.getValue();

//line 617
___nl__5 = null;
//line 617
___nl__5 = new ImmString("state");
//line 617
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 617
___nl__5 = null;
//line 617
___nl__4 = null;
//line 617
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 617
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_65;}}
//line 618
___nl__4 = new ImmString("ensure");
//line 618
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 618
___nl__4 = null;
//line 619
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = nparser_NL.NL_parse_try_ensure_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 619
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("ok"));
//line 619
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_66;}}
//line 619
___nl__1 = null;
//line 619
___nl__2 = null;
//line 619
___nl__3 = null;
//line 619
___nl__4 = null;
//line 619
___nl__5 = null;
//line 619
___arg__0.setValue(___nl__0);if(true) return ___nl__6;
//line 619
label_66:
//line 619
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("ok"));
//line 619
___nl__5 = null;
//line 619
___nl__6 = null;
//line 620
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ensure"), ___nl__4);
//line 620
___nl__2 = ___nl__5;
//line 620
___nl__5 = null;
//line 620
___nl__4 = null;
//line 621
if (true) {goto label_1;}
//line 621
label_65:
//line 622
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = nparser_NL.NL_parse_expr_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 622
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("ok"));
//line 622
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_67;}}
//line 622
___nl__1 = null;
//line 622
___nl__2 = null;
//line 622
___nl__3 = null;
//line 622
___nl__4 = null;
//line 622
___nl__5 = null;
//line 622
___arg__0.setValue(___nl__0);if(true) return ___nl__6;
//line 622
label_67:
//line 622
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("ok"));
//line 622
___nl__5 = null;
//line 622
___nl__6 = null;
//line 623
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("value"), ___nl__4);
//line 623
___nl__2 = ___nl__5;
//line 623
___nl__5 = null;
//line 623
___nl__4 = null;
//line 624
if (true) {goto label_1;}
//line 624
label_1:
//line 624
___nl__3 = null;
//line 626
___nl__3 = ___nl__2;
//line 626
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("break"));
//line 626
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_75;}}
//line 626
___nl__3 = ___nl__2;
//line 626
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("continue"));
//line 626
label_75:
//line 626
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_74;}}
//line 626
___nl__3 = ___nl__2;
//line 626
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("value"));
//line 626
label_74:
//line 626
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_73;}}
//line 626
___nl__3 = ___nl__2;
//line 626
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("return"));
//line 626
label_73:
//line 626
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_72;}}
//line 626
___nl__3 = ___nl__2;
//line 626
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("die"));
//line 626
label_72:
//line 626
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_71;}}
//line 626
___nl__3 = ___nl__2;
//line 626
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("ensure"));
//line 626
label_71:
//line 626
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_70;}}
//line 626
___nl__3 = ___nl__2;
//line 626
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("try"));
//line 626
label_70:
//line 626
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 626
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_69;}}
//line 628
___nl__6 = new ImmString("state");
//line 628
___nl__6 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__6);

//line 628
___ref______nl__6 = new ImmRef(___nl__6);
___nl__5 = ntokenizer_NL.NL_get_place_ws(___ref______nl__6);
___nl__6 = ___ref______nl__6.getValue();

//line 628
___nl__7 = new ImmString("state");
//line 628
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__7,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

//line 628
___nl__7 = null;
//line 628
___nl__6 = null;
//line 628
__function_map = new Dictionary<String, Imm>();
__function_map.Add("begin",___nl__1);
__function_map.Add("end",___nl__5);
___nl__4 = new ImmHash(__function_map);
//line 628
___nl__5 = null;
//line 632
__function_map = new Dictionary<String, Imm>();
__function_map.Add("debug",___nl__4);
__function_map.Add("cmd",___nl__2);
___nl__6 = new ImmHash(__function_map);
//line 632
__function_map = new Dictionary<String, Imm>();
__function_map.Add("cmd",___nl__6);
___nl__5 = new ImmHash(__function_map);
//line 632
___nl__6 = null;
//line 633
___nl__7 = new ImmString("fora");
//line 633
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 633
___nl__7 = null;
//line 633
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 633
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_77;}}
//line 634
___nl__7 = c_rt_lib_NL.NL_get_true();
//line 634
___nl__8 = ___nl__7;
//line 634
((ImmHash)___nl__5).set("short", ___nl__8);
//line 634
___nl__7 = null;
//line 634
___nl__8 = null;
//line 635
___ref______nl__0 = new ImmRef(___nl__0);
___nl__7 = nparser_NL.NL_parse_var_decl_sim_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 635
___nl__8 = ___nl__7;
//line 635
((ImmHash)___nl__5).set("iter", ___nl__8);
//line 635
___nl__7 = null;
//line 635
___nl__8 = null;
//line 636
___nl__7 = new ImmString("(");
//line 636
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 636
___nl__7 = null;
//line 637
___ref______nl__0 = new ImmRef(___nl__0);
___nl__8 = nparser_NL.NL_parse_expr_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 637
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("ok"));
//line 637
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_78;}}
//line 637
___nl__1 = null;
//line 637
___nl__2 = null;
//line 637
___nl__3 = null;
//line 637
___nl__4 = null;
//line 637
___nl__5 = null;
//line 637
___nl__6 = null;
//line 637
___nl__7 = null;
//line 637
___arg__0.setValue(___nl__0);if(true) return ___nl__8;
//line 637
label_78:
//line 637
___nl__9 = c_rt_lib_NL.NL_ov_as(___nl__8, new ImmString("ok"));
//line 637
((ImmHash)___nl__5).set("array", ___nl__9);
//line 637
___nl__7 = null;
//line 637
___nl__8 = null;
//line 637
___nl__9 = null;
//line 638
___nl__7 = new ImmString(")");
//line 638
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 638
___nl__7 = null;
//line 639
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("fora"), ___nl__5);
//line 639
___nl__2 = ___nl__7;
//line 639
___nl__7 = null;
//line 640
if (true) {goto label_87;}
//line 640
label_77:
//line 640
___nl__7 = new ImmString("rep");
//line 640
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 640
___nl__7 = null;
//line 640
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 640
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_79;}}
//line 641
___nl__7 = c_rt_lib_NL.NL_get_true();
//line 641
___nl__8 = ___nl__7;
//line 641
((ImmHash)___nl__5).set("short", ___nl__8);
//line 641
___nl__7 = null;
//line 641
___nl__8 = null;
//line 642
___ref______nl__0 = new ImmRef(___nl__0);
___nl__7 = nparser_NL.NL_parse_var_decl_sim_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 642
___nl__8 = ___nl__7;
//line 642
((ImmHash)___nl__5).set("iter", ___nl__8);
//line 642
___nl__7 = null;
//line 642
___nl__8 = null;
//line 643
___nl__7 = new ImmString("(");
//line 643
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 643
___nl__7 = null;
//line 644
___ref______nl__0 = new ImmRef(___nl__0);
___nl__8 = nparser_NL.NL_parse_expr_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 644
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("ok"));
//line 644
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_80;}}
//line 644
___nl__1 = null;
//line 644
___nl__2 = null;
//line 644
___nl__3 = null;
//line 644
___nl__4 = null;
//line 644
___nl__5 = null;
//line 644
___nl__6 = null;
//line 644
___nl__7 = null;
//line 644
___arg__0.setValue(___nl__0);if(true) return ___nl__8;
//line 644
label_80:
//line 644
___nl__9 = c_rt_lib_NL.NL_ov_as(___nl__8, new ImmString("ok"));
//line 644
((ImmHash)___nl__5).set("count", ___nl__9);
//line 644
___nl__7 = null;
//line 644
___nl__8 = null;
//line 644
___nl__9 = null;
//line 645
___nl__7 = new ImmString(")");
//line 645
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 645
___nl__7 = null;
//line 646
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("rep"), ___nl__5);
//line 646
___nl__2 = ___nl__7;
//line 646
___nl__7 = null;
//line 647
if (true) {goto label_87;}
//line 647
label_79:
//line 647
___nl__7 = new ImmString("forh");
//line 647
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 647
___nl__7 = null;
//line 647
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 647
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_81;}}
//line 648
___nl__7 = c_rt_lib_NL.NL_get_true();
//line 648
___nl__8 = ___nl__7;
//line 648
((ImmHash)___nl__5).set("short", ___nl__8);
//line 648
___nl__7 = null;
//line 648
___nl__8 = null;
//line 649
___ref______nl__0 = new ImmRef(___nl__0);
___nl__7 = nparser_NL.NL_parse_var_decl_sim_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 649
___nl__8 = ___nl__7;
//line 649
((ImmHash)___nl__5).set("key", ___nl__8);
//line 649
___nl__7 = null;
//line 649
___nl__8 = null;
//line 650
___nl__7 = new ImmString(",");
//line 650
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 650
___nl__7 = null;
//line 651
___ref______nl__0 = new ImmRef(___nl__0);
___nl__7 = nparser_NL.NL_parse_var_decl_sim_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 651
___nl__8 = ___nl__7;
//line 651
((ImmHash)___nl__5).set("val", ___nl__8);
//line 651
___nl__7 = null;
//line 651
___nl__8 = null;
//line 652
___nl__7 = new ImmString("(");
//line 652
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 652
___nl__7 = null;
//line 653
___ref______nl__0 = new ImmRef(___nl__0);
___nl__8 = nparser_NL.NL_parse_expr_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 653
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("ok"));
//line 653
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_82;}}
//line 653
___nl__1 = null;
//line 653
___nl__2 = null;
//line 653
___nl__3 = null;
//line 653
___nl__4 = null;
//line 653
___nl__5 = null;
//line 653
___nl__6 = null;
//line 653
___nl__7 = null;
//line 653
___arg__0.setValue(___nl__0);if(true) return ___nl__8;
//line 653
label_82:
//line 653
___nl__9 = c_rt_lib_NL.NL_ov_as(___nl__8, new ImmString("ok"));
//line 653
((ImmHash)___nl__5).set("hash", ___nl__9);
//line 653
___nl__7 = null;
//line 653
___nl__8 = null;
//line 653
___nl__9 = null;
//line 654
___nl__7 = new ImmString(")");
//line 654
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 654
___nl__7 = null;
//line 655
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("forh"), ___nl__5);
//line 655
___nl__2 = ___nl__7;
//line 655
___nl__7 = null;
//line 656
if (true) {goto label_87;}
//line 656
label_81:
//line 656
___nl__7 = new ImmString("if");
//line 656
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 656
___nl__7 = null;
//line 656
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 656
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_83;}}
//line 657
___ref______nl__0 = new ImmRef(___nl__0);
___nl__8 = nparser_NL.NL_parse_expr_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 657
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("ok"));
//line 657
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_84;}}
//line 657
___nl__1 = null;
//line 657
___nl__2 = null;
//line 657
___nl__3 = null;
//line 657
___nl__4 = null;
//line 657
___nl__5 = null;
//line 657
___nl__6 = null;
//line 657
___nl__7 = null;
//line 657
___arg__0.setValue(___nl__0);if(true) return ___nl__8;
//line 657
label_84:
//line 657
___nl__9 = c_rt_lib_NL.NL_ov_as(___nl__8, new ImmString("ok"));
//line 657
((ImmHash)___nl__5).set("cond", ___nl__9);
//line 657
___nl__7 = null;
//line 657
___nl__8 = null;
//line 657
___nl__9 = null;
//line 658
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("if_mod"), ___nl__5);
//line 658
___nl__2 = ___nl__7;
//line 658
___nl__7 = null;
//line 659
if (true) {goto label_87;}
//line 659
label_83:
//line 659
___nl__7 = new ImmString("unless");
//line 659
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 659
___nl__7 = null;
//line 659
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 659
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_85;}}
//line 660
___ref______nl__0 = new ImmRef(___nl__0);
___nl__8 = nparser_NL.NL_parse_expr_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 660
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("ok"));
//line 660
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_86;}}
//line 660
___nl__1 = null;
//line 660
___nl__2 = null;
//line 660
___nl__3 = null;
//line 660
___nl__4 = null;
//line 660
___nl__5 = null;
//line 660
___nl__6 = null;
//line 660
___nl__7 = null;
//line 660
___arg__0.setValue(___nl__0);if(true) return ___nl__8;
//line 660
label_86:
//line 660
___nl__9 = c_rt_lib_NL.NL_ov_as(___nl__8, new ImmString("ok"));
//line 660
((ImmHash)___nl__5).set("cond", ___nl__9);
//line 660
___nl__7 = null;
//line 660
___nl__8 = null;
//line 660
___nl__9 = null;
//line 661
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("unless_mod"), ___nl__5);
//line 661
___nl__2 = ___nl__7;
//line 661
___nl__7 = null;
//line 662
if (true) {goto label_87;}
//line 662
label_85:
//line 662
___nl__7 = new ImmString("while");
//line 662
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = nparser_NL.NL_try_eat_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 662
___nl__7 = null;
//line 662
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 662
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_87;}}
//line 663
___nl__7 = c_rt_lib_NL.NL_get_true();
//line 663
___nl__8 = ___nl__7;
//line 663
((ImmHash)___nl__5).set("short", ___nl__8);
//line 663
___nl__7 = null;
//line 663
___nl__8 = null;
//line 664
___ref______nl__0 = new ImmRef(___nl__0);
___nl__8 = nparser_NL.NL_parse_expr_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 664
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("ok"));
//line 664
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_88;}}
//line 664
___nl__1 = null;
//line 664
___nl__2 = null;
//line 664
___nl__3 = null;
//line 664
___nl__4 = null;
//line 664
___nl__5 = null;
//line 664
___nl__6 = null;
//line 664
___nl__7 = null;
//line 664
___arg__0.setValue(___nl__0);if(true) return ___nl__8;
//line 664
label_88:
//line 664
___nl__9 = c_rt_lib_NL.NL_ov_as(___nl__8, new ImmString("ok"));
//line 664
((ImmHash)___nl__5).set("cond", ___nl__9);
//line 664
___nl__7 = null;
//line 664
___nl__8 = null;
//line 664
___nl__9 = null;
//line 665
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("while"), ___nl__5);
//line 665
___nl__2 = ___nl__7;
//line 665
___nl__7 = null;
//line 666
if (true) {goto label_87;}
//line 666
label_87:
//line 666
___nl__6 = null;
//line 667
___nl__6 = new ImmString(";");
//line 667
___ref______nl__0 = new ImmRef(___nl__0);
nparser_NL.NL_eat_priv(___ref______nl__0,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

//line 667
___nl__6 = null;
//line 667
___nl__4 = null;
//line 667
___nl__5 = null;
//line 668
if (true) {goto label_69;}
//line 668
label_69:
//line 668
___nl__3 = null;
//line 669
___nl__4 = new ImmString("state");
//line 669
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__4);

//line 669
___ref______nl__4 = new ImmRef(___nl__4);
___nl__3 = ntokenizer_NL.NL_get_place_ws(___ref______nl__4);
___nl__4 = ___ref______nl__4.getValue();

//line 669
___nl__5 = new ImmString("state");
//line 669
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 669
___nl__5 = null;
//line 669
___nl__4 = null;
//line 670
__function_map = new Dictionary<String, Imm>();
__function_map.Add("begin",___nl__1);
__function_map.Add("end",___nl__3);
___nl__4 = new ImmHash(__function_map);
//line 674
__function_map = new Dictionary<String, Imm>();
__function_map.Add("cmd",___nl__2);
__function_map.Add("debug",___nl__4);
___nl__5 = new ImmHash(__function_map);
//line 674
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__5);
//line 674
___nl__1 = null;
//line 674
___nl__2 = null;
//line 674
___nl__3 = null;
//line 674
___nl__4 = null;
//line 674
___arg__0.setValue(___nl__0);if(true) return ___nl__5;
//line 674
___nl__5 = null;
//line 674
___nl__1 = null;
//line 674
___nl__2 = null;
//line 674
___nl__3 = null;
//line 674
___nl__4 = null;
//line 674
___arg__0.setValue(___nl__0);if(true) return null;
}

}
}