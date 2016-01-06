using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class translator_NL {

public static Imm NL_SINGLETON_function_logic_t() {

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
//line 17
___nl__2 = ptd_NL.NL_sim().clone();

//line 17
___nl__4 = ptd_NL.NL_sim().clone();

//line 17
___nl__3 = ptd_NL.NL_hash(___nl__4).clone();

//line 17
___nl__4 = null;
//line 17
__function_map = new Dictionary<String, Imm>();
__function_map.Add("register",___nl__2);
__function_map.Add("variables",___nl__3);
___nl__1 = new ImmHash(__function_map).clone();
//line 17
___nl__2 = null;
//line 17
___nl__3 = null;
//line 17
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 17
___nl__1 = null;
//line 17
if(true) return ___nl__0;
//line 17
___nl__0 = null;
//line 17
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_function_logic_t = null;
public static Imm NL_function_logic_t() {
	if (value__singleton__NL_SINGLETON_function_logic_t == null) {
		value__singleton__NL_SINGLETON_function_logic_t = NL_SINGLETON_function_logic_t();
	}
	return value__singleton__NL_SINGLETON_function_logic_t;
}
public static Imm NL_SINGLETON_loop() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 23
___nl__2 = ptd_NL.NL_sim().clone();

//line 23
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("translator_NL"));
__function_map.Add("name",new ImmString("function_logic_t"));
___nl__3 = new ImmHash(__function_map).clone();
//line 23
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3).clone();
//line 23
__function_map = new Dictionary<String, Imm>();
__function_map.Add("label",___nl__2);
__function_map.Add("logic",___nl__3);
___nl__1 = new ImmHash(__function_map).clone();
//line 23
___nl__2 = null;
//line 23
___nl__3 = null;
//line 23
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 23
___nl__1 = null;
//line 23
if(true) return ___nl__0;
//line 23
___nl__0 = null;
//line 23
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_loop = null;
public static Imm NL_loop() {
	if (value__singleton__NL_SINGLETON_loop == null) {
		value__singleton__NL_SINGLETON_loop = NL_SINGLETON_loop();
	}
	return value__singleton__NL_SINGLETON_loop;
}
public static Imm NL_SINGLETON_loop_label() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 29
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("translator_NL"));
__function_map.Add("name",new ImmString("loop"));
___nl__2 = new ImmHash(__function_map).clone();
//line 29
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2).clone();
//line 29
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("translator_NL"));
__function_map.Add("name",new ImmString("loop"));
___nl__3 = new ImmHash(__function_map).clone();
//line 29
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3).clone();
//line 29
__function_map = new Dictionary<String, Imm>();
__function_map.Add("break",___nl__2);
__function_map.Add("continue",___nl__3);
___nl__1 = new ImmHash(__function_map).clone();
//line 29
___nl__2 = null;
//line 29
___nl__3 = null;
//line 29
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 29
___nl__1 = null;
//line 29
if(true) return ___nl__0;
//line 29
___nl__0 = null;
//line 29
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_loop_label = null;
public static Imm NL_loop_label() {
	if (value__singleton__NL_SINGLETON_loop_label == null) {
		value__singleton__NL_SINGLETON_loop_label = NL_SINGLETON_loop_label();
	}
	return value__singleton__NL_SINGLETON_loop_label;
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
___nl__2 = ptd_NL.NL_sim().clone();

//line 36
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("debug_t"));
___nl__3 = new ImmHash(__function_map).clone();
//line 36
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3).clone();
//line 36
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("translator_NL"));
__function_map.Add("name",new ImmString("function_logic_t"));
___nl__4 = new ImmHash(__function_map).clone();
//line 36
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__4).clone();
//line 36
___nl__5 = ptd_NL.NL_sim().clone();

//line 36
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("function_t"));
___nl__6 = new ImmHash(__function_map).clone();
//line 36
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__6).clone();
//line 36
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("translator_NL"));
__function_map.Add("name",new ImmString("loop_label"));
___nl__7 = new ImmHash(__function_map).clone();
//line 36
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__7).clone();
//line 36
__function_map = new Dictionary<String, Imm>();
__function_map.Add("label_nr",___nl__2);
__function_map.Add("debug",___nl__3);
__function_map.Add("logic",___nl__4);
__function_map.Add("module_name",___nl__5);
__function_map.Add("result",___nl__6);
__function_map.Add("loop_label",___nl__7);
___nl__1 = new ImmHash(__function_map).clone();
//line 36
___nl__2 = null;
//line 36
___nl__3 = null;
//line 36
___nl__4 = null;
//line 36
___nl__5 = null;
//line 36
___nl__6 = null;
//line 36
___nl__7 = null;
//line 36
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 36
___nl__1 = null;
//line 36
if(true) return ___nl__0;
//line 36
___nl__0 = null;
//line 36
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_state_t = null;
public static Imm NL_state_t() {
	if (value__singleton__NL_SINGLETON_state_t == null) {
		value__singleton__NL_SINGLETON_state_t = NL_SINGLETON_state_t();
	}
	return value__singleton__NL_SINGLETON_state_t;
}
public static Imm NL_SINGLETON_string_t() {

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
//line 47
___nl__3 = ptd_NL.NL_sim().clone();

//line 47
___nl__2 = ptd_NL.NL_arr(___nl__3).clone();

//line 47
___nl__3 = null;
//line 47
___nl__5 = ptd_NL.NL_none().clone();

//line 47
___nl__6 = ptd_NL.NL_none().clone();

//line 47
__function_map = new Dictionary<String, Imm>();
__function_map.Add("end",___nl__5);
__function_map.Add("new_line",___nl__6);
___nl__4 = new ImmHash(__function_map).clone();
//line 47
___nl__5 = null;
//line 47
___nl__6 = null;
//line 47
___nl__3 = ptd_NL.NL_var(___nl__4).clone();

//line 47
___nl__4 = null;
//line 47
__function_map = new Dictionary<String, Imm>();
__function_map.Add("arr",___nl__2);
__function_map.Add("last",___nl__3);
___nl__1 = new ImmHash(__function_map).clone();
//line 47
___nl__2 = null;
//line 47
___nl__3 = null;
//line 47
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 47
___nl__1 = null;
//line 47
if(true) return ___nl__0;
//line 47
___nl__0 = null;
//line 47
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_string_t = null;
public static Imm NL_string_t() {
	if (value__singleton__NL_SINGLETON_string_t == null) {
		value__singleton__NL_SINGLETON_string_t = NL_SINGLETON_string_t();
	}
	return value__singleton__NL_SINGLETON_string_t;
}
public static Imm NL_SINGLETON_lvalue_values_t() {

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
//line 54
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__3 = new ImmHash(__function_map).clone();
//line 54
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3).clone();
//line 54
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__6 = new ImmHash(__function_map).clone();
//line 54
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__6).clone();
//line 54
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__7 = new ImmHash(__function_map).clone();
//line 54
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__7).clone();
//line 54
__function_map = new Dictionary<String, Imm>();
__function_map.Add("value",___nl__6);
__function_map.Add("index",___nl__7);
___nl__5 = new ImmHash(__function_map).clone();
//line 54
___nl__6 = null;
//line 54
___nl__7 = null;
//line 54
___nl__4 = ptd_NL.NL_rec(___nl__5).clone();

//line 54
___nl__5 = null;
//line 54
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__7 = new ImmHash(__function_map).clone();
//line 54
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__7).clone();
//line 54
___nl__8 = ptd_NL.NL_sim().clone();

//line 54
__function_map = new Dictionary<String, Imm>();
__function_map.Add("value",___nl__7);
__function_map.Add("key",___nl__8);
___nl__6 = new ImmHash(__function_map).clone();
//line 54
___nl__7 = null;
//line 54
___nl__8 = null;
//line 54
___nl__5 = ptd_NL.NL_rec(___nl__6).clone();

//line 54
___nl__6 = null;
//line 54
__function_map = new Dictionary<String, Imm>();
__function_map.Add("value",___nl__3);
__function_map.Add("index",___nl__4);
__function_map.Add("key",___nl__5);
___nl__2 = new ImmHash(__function_map).clone();
//line 54
___nl__3 = null;
//line 54
___nl__4 = null;
//line 54
___nl__5 = null;
//line 54
___nl__1 = ptd_NL.NL_var(___nl__2).clone();

//line 54
___nl__2 = null;
//line 54
___nl__0 = ptd_NL.NL_arr(___nl__1).clone();

//line 54
___nl__1 = null;
//line 54
if(true) return ___nl__0;
//line 54
___nl__0 = null;
//line 54
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_lvalue_values_t = null;
public static Imm NL_lvalue_values_t() {
	if (value__singleton__NL_SINGLETON_lvalue_values_t == null) {
		value__singleton__NL_SINGLETON_lvalue_values_t = NL_SINGLETON_lvalue_values_t();
	}
	return value__singleton__NL_SINGLETON_lvalue_values_t;
}
public static Imm NL_last_debug_char(Imm ___arg__0) {
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
//line 62
___nl__2 = ((ImmHash)___nl__0).getHashValue()["end"].clone();
//line 62
___nl__2 = ((ImmHash)___nl__2).getHashValue()["line"].clone();
//line 62
___nl__3 = ((ImmHash)___nl__0).getHashValue()["end"].clone();
//line 62
___nl__3 = ((ImmHash)___nl__3).getHashValue()["position"].clone();
//line 62
___nl__4 = new ImmDouble(1).clone();
//line 62
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))-(Double.Parse(___nl__4.getValue().ToString()))).clone();
//line 62
___nl__4 = null;
//line 62
__function_map = new Dictionary<String, Imm>();
__function_map.Add("line",___nl__2);
__function_map.Add("position",___nl__3);
___nl__1 = new ImmHash(__function_map).clone();
//line 62
___nl__2 = null;
//line 62
___nl__3 = null;
//line 66
___nl__3 = ((ImmHash)___nl__0).getHashValue()["end"].clone();
//line 66
___nl__3 = ((ImmHash)___nl__3).getHashValue()["line"].clone();
//line 66
___nl__4 = ((ImmHash)___nl__0).getHashValue()["end"].clone();
//line 66
___nl__4 = ((ImmHash)___nl__4).getHashValue()["position"].clone();
//line 66
__function_map = new Dictionary<String, Imm>();
__function_map.Add("line",___nl__3);
__function_map.Add("position",___nl__4);
___nl__2 = new ImmHash(__function_map).clone();
//line 66
___nl__3 = null;
//line 66
___nl__4 = null;
//line 70
__function_map = new Dictionary<String, Imm>();
__function_map.Add("begin",___nl__1);
__function_map.Add("end",___nl__2);
___nl__3 = new ImmHash(__function_map).clone();
//line 70
___nl__0 = null;
//line 70
___nl__1 = null;
//line 70
___nl__2 = null;
//line 70
if(true) return ___nl__3;
//line 70
___nl__3 = null;
//line 70
___nl__1 = null;
//line 70
___nl__2 = null;
//line 70
___nl__0 = null;
//line 70
if(true) return null;
}

public static Imm NL_translate(Imm ___arg__0) {
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
//line 74
___nl__2 = ((ImmHash)___nl__0).getHashValue()["name"].clone();
//line 74
___nl__3 = new ImmArray(new Imm[0]).clone();
//line 74
___nl__4 = new ImmArray(new Imm[0]).clone();
//line 74
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module_name",___nl__2);
__function_map.Add("functions",___nl__3);
__function_map.Add("imports",___nl__4);
___nl__1 = new ImmHash(__function_map).clone();
//line 74
___nl__2 = null;
//line 74
___nl__3 = null;
//line 74
___nl__4 = null;
//line 79
___nl__2 = new ImmArray(new Imm[0]).clone();
//line 79
___nl__3 = ___nl__2.clone();
//line 79
((ImmHash)___nl__1).set("imports", ___nl__3);
//line 79
___nl__2 = null;
//line 79
___nl__3 = null;
//line 80
___nl__2 = ((ImmHash)___nl__0).getHashValue()["import"].clone();
//line 80
___nl__4 = new ImmDouble(0).clone();
//line 80
___nl__5 = new ImmDouble(1).clone();
//line 80
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__2).clone();

//line 80
label_3:
//line 80
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) ).clone();
//line 80
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_1;}}
//line 80
___nl__3 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()].clone();
//line 81
___nl__8 = new ImmString("imports").clone();
//line 81
___nl__8 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__8).clone();

//line 81
___nl__9 = ((ImmHash)___nl__3).getHashValue()["name"].clone();
//line 81
___ref______nl__8 = new ImmRef(___nl__8);
array_NL.NL_push(___ref______nl__8,___nl__9);
___nl__8 = ___ref______nl__8.getValue().clone();

//line 81
___nl__9 = null;
//line 81
___nl__9 = new ImmString("imports").clone();
//line 81
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__9,___nl__8);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 81
___nl__9 = null;
//line 81
___nl__8 = null;
//line 82
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 82
if (true) {goto label_3;}
//line 82
label_1:
//line 82
___nl__2 = null;
//line 82
___nl__3 = null;
//line 82
___nl__4 = null;
//line 82
___nl__5 = null;
//line 82
___nl__6 = null;
//line 82
___nl__7 = null;
//line 83
___nl__2 = ((ImmHash)___nl__0).getHashValue()["fun_def"].clone();
//line 83
___nl__4 = new ImmDouble(0).clone();
//line 83
___nl__5 = new ImmDouble(1).clone();
//line 83
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__2).clone();

//line 83
label_6:
//line 83
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) ).clone();
//line 83
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_4;}}
//line 83
___nl__3 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()].clone();
//line 84
__function_map = new Dictionary<String, Imm>();
___nl__9 = new ImmHash(__function_map).clone();
//line 84
___nl__10 = new ImmDouble(0).clone();
//line 84
__function_map = new Dictionary<String, Imm>();
__function_map.Add("variables",___nl__9);
__function_map.Add("register",___nl__10);
___nl__8 = new ImmHash(__function_map).clone();
//line 84
___nl__9 = null;
//line 84
___nl__10 = null;
//line 85
___nl__10 = new ImmDouble(0).clone();
//line 85
___nl__11 = nlasm_NL.NL_empty_debug().clone();

//line 85
___nl__12 = ((ImmHash)___nl__0).getHashValue()["name"].clone();
//line 85
___nl__14 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 85
___nl__15 = ((ImmHash)___nl__3).getHashValue()["access"].clone();
//line 85
___nl__16 = new ImmDouble(0).clone();
//line 85
___nl__17 = new ImmArray(new Imm[0]).clone();
//line 85
___nl__18 = new ImmArray(new Imm[0]).clone();
//line 85
___nl__19 = ((ImmHash)___nl__3).getHashValue()["name"].clone();
//line 85
__function_map = new Dictionary<String, Imm>();
__function_map.Add("annotation",___nl__14);
__function_map.Add("access",___nl__15);
__function_map.Add("reg_size",___nl__16);
__function_map.Add("args_type",___nl__17);
__function_map.Add("commands",___nl__18);
__function_map.Add("name",___nl__19);
___nl__13 = new ImmHash(__function_map).clone();
//line 85
___nl__14 = null;
//line 85
___nl__15 = null;
//line 85
___nl__16 = null;
//line 85
___nl__17 = null;
//line 85
___nl__18 = null;
//line 85
___nl__19 = null;
//line 85
___nl__16 = new ImmString("").clone();
//line 85
__function_map = new Dictionary<String, Imm>();
__function_map.Add("label",___nl__16);
__function_map.Add("logic",___nl__8);
___nl__15 = new ImmHash(__function_map).clone();
//line 85
___nl__16 = null;
//line 85
___nl__17 = new ImmString("").clone();
//line 85
__function_map = new Dictionary<String, Imm>();
__function_map.Add("label",___nl__17);
__function_map.Add("logic",___nl__8);
___nl__16 = new ImmHash(__function_map).clone();
//line 85
___nl__17 = null;
//line 85
__function_map = new Dictionary<String, Imm>();
__function_map.Add("break",___nl__15);
__function_map.Add("continue",___nl__16);
___nl__14 = new ImmHash(__function_map).clone();
//line 85
___nl__15 = null;
//line 85
___nl__16 = null;
//line 85
__function_map = new Dictionary<String, Imm>();
__function_map.Add("label_nr",___nl__10);
__function_map.Add("debug",___nl__11);
__function_map.Add("module_name",___nl__12);
__function_map.Add("logic",___nl__8);
__function_map.Add("result",___nl__13);
__function_map.Add("loop_label",___nl__14);
___nl__9 = new ImmHash(__function_map).clone();
//line 85
___nl__10 = null;
//line 85
___nl__11 = null;
//line 85
___nl__12 = null;
//line 85
___nl__13 = null;
//line 85
___nl__14 = null;
//line 103
___ref______nl__9 = new ImmRef(___nl__9);
translator_NL.NL_print_fun_def_priv(___nl__3,___ref______nl__9);
___nl__9 = ___ref______nl__9.getValue().clone();

//line 104
___nl__10 = new ImmString("functions").clone();
//line 104
___nl__10 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__10).clone();

//line 104
___nl__11 = ((ImmHash)___nl__9).getHashValue()["result"].clone();
//line 104
___ref______nl__10 = new ImmRef(___nl__10);
array_NL.NL_push(___ref______nl__10,___nl__11);
___nl__10 = ___ref______nl__10.getValue().clone();

//line 104
___nl__11 = null;
//line 104
___nl__11 = new ImmString("functions").clone();
//line 104
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__11,___nl__10);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 104
___nl__11 = null;
//line 104
___nl__10 = null;
//line 104
___nl__8 = null;
//line 104
___nl__9 = null;
//line 105
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 105
if (true) {goto label_6;}
//line 105
label_4:
//line 105
___nl__2 = null;
//line 105
___nl__3 = null;
//line 105
___nl__4 = null;
//line 105
___nl__5 = null;
//line 105
___nl__6 = null;
//line 105
___nl__7 = null;
//line 106
___nl__0 = null;
//line 106
if(true) return ___nl__1;
//line 106
___nl__1 = null;
//line 106
___nl__0 = null;
//line 106
if(true) return null;
}

private static Imm NL_print_fun_def_priv(Imm ___arg__0, ImmRef ___arg__1) {
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
//line 110
___nl__2 = ((ImmHash)___nl__0).getHashValue()["args"].clone();
//line 110
___nl__4 = new ImmDouble(0).clone();
//line 110
___nl__5 = new ImmDouble(1).clone();
//line 110
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__2).clone();

//line 110
label_3:
//line 110
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) ).clone();
//line 110
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_1;}}
//line 110
___nl__3 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()].clone();
//line 111
___nl__8 = ((ImmHash)___nl__3).getHashValue()["mod"].clone();
//line 111
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("none")).clone();
//line 111
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_5;}}
//line 114
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("ref")).clone();
//line 114
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_6;}}
//line 114
___nl__9 = new ImmString("NOMATCHALERT").clone();
//line 114
___nl__9 = new ImmArray(new Imm[] {___nl__9,___nl__8,}).clone();
//line 114
c_rt_lib_NL.NL_die();
//line 111
label_5:
//line 112
___nl__10 = ((ImmHash)___nl__3).getHashValue()["name"].clone();
//line 112
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_new_declaration_priv(___nl__10,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 112
___nl__10 = null;
//line 113
___nl__10 = new ImmString("result").clone();
//line 113
___nl__10 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__10).clone();

//line 113
___nl__11 = new ImmString("args_type").clone();
//line 113
___nl__11 = c_rt_lib_NL.NL_get_ref_hash(___nl__10,___nl__11).clone();

//line 113
___nl__12 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("val")).clone();
//line 113
___ref______nl__11 = new ImmRef(___nl__11);
array_NL.NL_push(___ref______nl__11,___nl__12);
___nl__11 = ___ref______nl__11.getValue().clone();

//line 113
___nl__12 = null;
//line 113
___nl__12 = new ImmString("args_type").clone();
//line 113
___ref______nl__10 = new ImmRef(___nl__10);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__10,___nl__12,___nl__11);
___nl__10 = ___ref______nl__10.getValue().clone();

//line 113
___nl__12 = new ImmString("result").clone();
//line 113
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__12,___nl__10);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 113
___nl__12 = null;
//line 113
___nl__10 = null;
//line 113
___nl__11 = null;
//line 114
if (true) {goto label_4;}
//line 114
label_6:
//line 115
___nl__10 = ((ImmHash)___nl__3).getHashValue()["name"].clone();
//line 115
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_new_declaration_priv(___nl__10,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 115
___nl__10 = null;
//line 116
___nl__10 = new ImmString("result").clone();
//line 116
___nl__10 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__10).clone();

//line 116
___nl__11 = new ImmString("args_type").clone();
//line 116
___nl__11 = c_rt_lib_NL.NL_get_ref_hash(___nl__10,___nl__11).clone();

//line 116
___nl__12 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("ref")).clone();
//line 116
___ref______nl__11 = new ImmRef(___nl__11);
array_NL.NL_push(___ref______nl__11,___nl__12);
___nl__11 = ___ref______nl__11.getValue().clone();

//line 116
___nl__12 = null;
//line 116
___nl__12 = new ImmString("args_type").clone();
//line 116
___ref______nl__10 = new ImmRef(___nl__10);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__10,___nl__12,___nl__11);
___nl__10 = ___ref______nl__10.getValue().clone();

//line 116
___nl__12 = new ImmString("result").clone();
//line 116
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__12,___nl__10);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 116
___nl__12 = null;
//line 116
___nl__10 = null;
//line 116
___nl__11 = null;
//line 117
if (true) {goto label_4;}
//line 117
label_4:
//line 117
___nl__8 = null;
//line 117
___nl__9 = null;
//line 118
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 118
if (true) {goto label_3;}
//line 118
label_1:
//line 118
___nl__2 = null;
//line 118
___nl__3 = null;
//line 118
___nl__4 = null;
//line 118
___nl__5 = null;
//line 118
___nl__6 = null;
//line 118
___nl__7 = null;
//line 119
___nl__2 = ((ImmHash)___nl__0).getHashValue()["cmd"].clone();
//line 119
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_cmd_priv(___nl__2,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 119
___nl__2 = null;
//line 120
___nl__2 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("nop")).clone();
//line 120
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_return_priv(___nl__2,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 120
___nl__2 = null;
//line 120
___nl__0 = null;
//line 120
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_print_array_declaration_priv(Imm ___arg__0, Imm ___arg__1, ImmRef ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.getValue().clone();
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
//line 124
___nl__3 = new ImmArray(new Imm[0]).clone();
//line 125
___nl__5 = new ImmDouble(0).clone();
//line 125
___nl__6 = new ImmDouble(1).clone();
//line 125
___nl__7 = c_rt_lib_NL.NL_array_len(___nl__0).clone();

//line 125
label_3:
//line 125
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) ).clone();
//line 125
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_1;}}
//line 125
___nl__4 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()].clone();
//line 126
___ref______nl__2 = new ImmRef(___nl__2);
___nl__9 = translator_NL.NL_calc_val_priv(___nl__4,___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 126
___ref______nl__3 = new ImmRef(___nl__3);
array_NL.NL_push(___ref______nl__3,___nl__9);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 126
___nl__9 = null;
//line 127
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString()))).clone();
//line 127
if (true) {goto label_3;}
//line 127
label_1:
//line 127
___nl__4 = null;
//line 127
___nl__5 = null;
//line 127
___nl__6 = null;
//line 127
___nl__7 = null;
//line 127
___nl__8 = null;
//line 128
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__1);
__function_map.Add("src",___nl__3);
___nl__4 = new ImmHash(__function_map).clone();
//line 128
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("arr_decl"), ___nl__4).clone();
//line 128
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_priv(___ref______nl__2,___nl__4);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 128
___nl__4 = null;
//line 128
___nl__3 = null;
//line 128
___nl__0 = null;
//line 128
___nl__1 = null;
//line 128
___arg__2.setValue(___nl__2);if(true) return null;
}

private static Imm NL_print_hash_declaration_priv(Imm ___arg__0, Imm ___arg__1, ImmRef ___arg__2) {
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
//line 136
___nl__3 = new ImmArray(new Imm[0]).clone();
//line 137
___nl__5 = new ImmDouble(0).clone();
//line 137
___nl__6 = new ImmDouble(1).clone();
//line 137
___nl__7 = c_rt_lib_NL.NL_array_len(___nl__0).clone();

//line 137
label_3:
//line 137
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) ).clone();
//line 137
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_1;}}
//line 137
___nl__4 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()].clone();
//line 138
___nl__10 = ((ImmHash)___nl__4).getHashValue()["key"].clone();
//line 138
___nl__10 = c_rt_lib_NL.NL_ov_as(___nl__10, new ImmString("hash_key")).clone();
//line 138
___nl__12 = ((ImmHash)___nl__4).getHashValue()["val"].clone();
//line 138
___ref______nl__2 = new ImmRef(___nl__2);
___nl__11 = translator_NL.NL_calc_val_priv(___nl__12,___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 138
___nl__12 = null;
//line 138
__function_map = new Dictionary<String, Imm>();
__function_map.Add("key",___nl__10);
__function_map.Add("val",___nl__11);
___nl__9 = new ImmHash(__function_map).clone();
//line 138
___nl__10 = null;
//line 138
___nl__11 = null;
//line 138
___ref______nl__3 = new ImmRef(___nl__3);
array_NL.NL_push(___ref______nl__3,___nl__9);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 138
___nl__9 = null;
//line 142
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString()))).clone();
//line 142
if (true) {goto label_3;}
//line 142
label_1:
//line 142
___nl__4 = null;
//line 142
___nl__5 = null;
//line 142
___nl__6 = null;
//line 142
___nl__7 = null;
//line 142
___nl__8 = null;
//line 143
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__1);
__function_map.Add("src",___nl__3);
___nl__4 = new ImmHash(__function_map).clone();
//line 143
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("hash_decl"), ___nl__4).clone();
//line 143
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_priv(___ref______nl__2,___nl__4);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 143
___nl__4 = null;
//line 143
___nl__3 = null;
//line 143
___nl__0 = null;
//line 143
___nl__1 = null;
//line 143
___arg__2.setValue(___nl__2);if(true) return null;
}

private static Imm NL_print_variant_priv(Imm ___arg__0, Imm ___arg__1, ImmRef ___arg__2) {
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
//line 151
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("emp")).clone();
//line 152
___nl__4 = ((ImmHash)___nl__0).getHashValue()["var"].clone();
//line 152
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("nop")).clone();
//line 152
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 152
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 152
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 153
___nl__6 = ((ImmHash)___nl__0).getHashValue()["var"].clone();
//line 153
___ref______nl__2 = new ImmRef(___nl__2);
___nl__5 = translator_NL.NL_dest_val_priv(___nl__6,___nl__1,___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 153
___nl__6 = null;
//line 153
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("arg"), ___nl__5).clone();
//line 153
___nl__3 = ___nl__5.clone();
//line 153
___nl__5 = null;
//line 154
if (true) {goto label_2;}
//line 154
label_2:
//line 154
___nl__4 = null;
//line 155
___nl__5 = ((ImmHash)___nl__0).getHashValue()["name"].clone();
//line 155
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__1);
__function_map.Add("src",___nl__3);
__function_map.Add("name",___nl__5);
___nl__4 = new ImmHash(__function_map).clone();
//line 155
___nl__5 = null;
//line 155
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ov_mk"), ___nl__4).clone();
//line 155
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_priv(___ref______nl__2,___nl__4);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 155
___nl__4 = null;
//line 155
___nl__3 = null;
//line 155
___nl__0 = null;
//line 155
___nl__1 = null;
//line 155
___arg__2.setValue(___nl__2);if(true) return null;
}

private static Imm NL_print_var_decl_priv(Imm ___arg__0, ImmRef ___arg__1) {
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
//line 164
___nl__3 = ((ImmHash)___nl__0).getHashValue()["name"].clone();
//line 164
___ref______nl__1 = new ImmRef(___nl__1);
___nl__2 = translator_NL.NL_new_declaration_priv(___nl__3,___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 164
___nl__3 = null;
//line 165
___nl__3 = ((ImmHash)___nl__0).getHashValue()["value"].clone();
//line 165
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("none")).clone();
//line 165
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 166
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("value")).clone();
//line 166
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_3;}}
//line 166
___nl__4 = new ImmString("NOMATCHALERT").clone();
//line 166
___nl__4 = new ImmArray(new Imm[] {___nl__4,___nl__3,}).clone();
//line 166
c_rt_lib_NL.NL_die();
//line 165
label_2:
//line 166
if (true) {goto label_1;}
//line 166
label_3:
//line 166
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("value")).clone();
//line 167
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_val_priv(___nl__5,___nl__2,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 167
___nl__5 = null;
//line 168
if (true) {goto label_1;}
//line 168
label_1:
//line 168
___nl__3 = null;
//line 168
___nl__4 = null;
//line 169
___nl__0 = null;
//line 169
___arg__1.setValue(___nl__1);if(true) return ___nl__2;
//line 169
___nl__2 = null;
//line 169
___nl__0 = null;
//line 169
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_load_const_priv(Imm ___arg__0, Imm ___arg__1, ImmRef ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.getValue().clone();
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 173
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__1);
__function_map.Add("val",___nl__0);
___nl__3 = new ImmHash(__function_map).clone();
//line 173
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("load_const"), ___nl__3).clone();
//line 173
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_priv(___ref______nl__2,___nl__3);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 173
___nl__3 = null;
//line 173
___nl__0 = null;
//line 173
___nl__1 = null;
//line 173
___arg__2.setValue(___nl__2);if(true) return null;
}

public static Imm NL_SINGLETON_ref_rec_args_t() {

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
//line 181
___nl__3 = ptd_NL.NL_sim().clone();

//line 181
___nl__4 = ptd_NL.NL_sim().clone();

//line 181
___nl__5 = ptd_NL.NL_sim().clone();

//line 181
__function_map = new Dictionary<String, Imm>();
__function_map.Add("var_name",___nl__3);
__function_map.Add("list_name",___nl__4);
__function_map.Add("lvalue_var_name",___nl__5);
___nl__2 = new ImmHash(__function_map).clone();
//line 181
___nl__3 = null;
//line 181
___nl__4 = null;
//line 181
___nl__5 = null;
//line 181
___nl__1 = ptd_NL.NL_rec(___nl__2).clone();

//line 181
___nl__2 = null;
//line 181
___nl__0 = ptd_NL.NL_arr(___nl__1).clone();

//line 181
___nl__1 = null;
//line 181
if(true) return ___nl__0;
//line 181
___nl__0 = null;
//line 181
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_ref_rec_args_t = null;
public static Imm NL_ref_rec_args_t() {
	if (value__singleton__NL_SINGLETON_ref_rec_args_t == null) {
		value__singleton__NL_SINGLETON_ref_rec_args_t = NL_SINGLETON_ref_rec_args_t();
	}
	return value__singleton__NL_SINGLETON_ref_rec_args_t;
}
private static Imm NL_print_fun_val_priv(Imm ___arg__0, Imm ___arg__1, ImmRef ___arg__2) {
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
//line 185
___nl__3 = new ImmArray(new Imm[0]).clone();
//line 189
__function_map = new Dictionary<String, Imm>();
___nl__4 = new ImmHash(__function_map).clone();
//line 190
__function_map = new Dictionary<String, Imm>();
___nl__5 = new ImmHash(__function_map).clone();
//line 191
__function_map = new Dictionary<String, Imm>();
___nl__6 = new ImmHash(__function_map).clone();
//line 192
___nl__8 = ((ImmHash)___nl__0).getHashValue()["args"].clone();
//line 192
___nl__7 = array_NL.NL_len(___nl__8).clone();

//line 192
___nl__8 = null;
//line 192
___nl__8 = new ImmDouble(1).clone();
//line 192
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))-(Double.Parse(___nl__8.getValue().ToString()))).clone();
//line 192
___nl__8 = null;
//line 192
label_2:
//line 192
___nl__8 = new ImmDouble(0).clone();
//line 192
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))>=(Double.Parse(___nl__8.getValue().ToString())) ).clone();
//line 192
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 192
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_1;}}
//line 193
___nl__9 = ((ImmHash)___nl__0).getHashValue()["args"].clone();
//line 193
___nl__9 = (___nl__9 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()].clone();
//line 193
___nl__9 = ((ImmHash)___nl__9).getHashValue()["mod"].clone();
//line 193
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__9, new ImmString("ref")).clone();
//line 193
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 193
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 193
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_5;}}
//line 193
___nl__9 = null;
//line 193
if (true) {goto label_3;}
//line 193
if (true) {goto label_5;}
//line 193
label_5:
//line 193
___nl__9 = null;
//line 194
___nl__9 = ((ImmHash)___nl__0).getHashValue()["args"].clone();
//line 194
___nl__9 = (___nl__9 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()].clone();
//line 194
___nl__9 = ((ImmHash)___nl__9).getHashValue()["val"].clone();
//line 195
___ref______nl__9 = new ImmRef(___nl__9);
translator_NL.NL_get_stuct_of_lvalue_priv(___ref______nl__9);
___nl__9 = ___ref______nl__9.getValue().clone();

//line 196
___nl__11 = ___nl__9.clone();
//line 196
___nl__11 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("var")).clone();
//line 196
___nl__10 = hash_NL.NL_has_key(___nl__6,___nl__11).clone();

//line 196
___nl__11 = null;
//line 196
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 196
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_7;}}
//line 196
___nl__9 = null;
//line 196
___nl__10 = null;
//line 196
if (true) {goto label_3;}
//line 196
if (true) {goto label_7;}
//line 196
label_7:
//line 196
___nl__10 = null;
//line 197
___nl__10 = ___nl__9.clone();
//line 197
___nl__10 = c_rt_lib_NL.NL_ov_as(___nl__10, new ImmString("var")).clone();
//line 197
___nl__11 = new ImmDouble(0).clone();
//line 197
___ref______nl__6 = new ImmRef(___nl__6);
hash_NL.NL_set_value(___ref______nl__6,___nl__10,___nl__11);
___nl__6 = ___ref______nl__6.getValue().clone();

//line 197
___nl__11 = null;
//line 197
___nl__10 = null;
//line 198
___nl__10 = new ImmDouble(0).clone();
//line 198
___ref______nl__5 = new ImmRef(___nl__5);
hash_NL.NL_set_value(___ref______nl__5,___nl__7,___nl__10);
___nl__5 = ___ref______nl__5.getValue().clone();

//line 198
___nl__10 = null;
//line 198
___nl__9 = null;
//line 198
label_3:
//line 198
___nl__9 = new ImmDouble(1).clone();
//line 198
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))-(Double.Parse(___nl__9.getValue().ToString()))).clone();
//line 198
___nl__9 = null;
//line 199
if (true) {goto label_2;}
//line 199
label_1:
//line 199
___nl__7 = null;
//line 199
___nl__8 = null;
//line 200
___nl__7 = new ImmArray(new Imm[0]).clone();
//line 201
___nl__9 = ((ImmHash)___nl__0).getHashValue()["args"].clone();
//line 201
___nl__8 = array_NL.NL_len(___nl__9).clone();

//line 201
___nl__9 = null;
//line 201
___nl__9 = new ImmDouble(0).clone();
//line 201
___nl__10 = new ImmDouble(1).clone();
//line 201
label_10:
//line 201
___nl__11 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__9.getValue().ToString()))>=(Double.Parse(___nl__8.getValue().ToString())) ).clone();
//line 201
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_8;}}
//line 202
___nl__12 = ((ImmHash)___nl__0).getHashValue()["args"].clone();
//line 202
___nl__12 = (___nl__12 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()].clone();
//line 203
___nl__13 = ((ImmHash)___nl__12).getHashValue()["mod"].clone();
//line 203
___nl__14 = c_rt_lib_NL.NL_ov_is(___nl__13, new ImmString("none")).clone();
//line 203
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_12;}}
//line 205
___nl__14 = c_rt_lib_NL.NL_ov_is(___nl__13, new ImmString("ref")).clone();
//line 205
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_13;}}
//line 205
___nl__14 = new ImmString("NOMATCHALERT").clone();
//line 205
___nl__14 = new ImmArray(new Imm[] {___nl__14,___nl__13,}).clone();
//line 205
c_rt_lib_NL.NL_die();
//line 203
label_12:
//line 204
___nl__16 = ((ImmHash)___nl__12).getHashValue()["val"].clone();
//line 204
___ref______nl__2 = new ImmRef(___nl__2);
___nl__15 = translator_NL.NL_calc_val_priv(___nl__16,___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 204
___nl__16 = null;
//line 204
___nl__15 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("val"), ___nl__15).clone();
//line 204
___ref______nl__3 = new ImmRef(___nl__3);
array_NL.NL_push(___ref______nl__3,___nl__15);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 204
___nl__15 = null;
//line 205
if (true) {goto label_11;}
//line 205
label_13:
//line 206
___nl__15 = hash_NL.NL_has_key(___nl__5,___nl__9).clone();

//line 206
___nl__15 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__15)).clone();
//line 206
if (c_rt_lib_NL.NL_check_true_native(___nl__15)) {if (true) {goto label_15;}}
//line 207
___nl__17 = ((ImmHash)___nl__12).getHashValue()["val"].clone();
//line 207
___nl__18 = new ImmDouble(1).clone();
//line 207
___ref______nl__2 = new ImmRef(___nl__2);
___nl__16 = translator_NL.NL_get_value_of_lvalue_priv(___nl__17,___nl__18,___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 207
___nl__18 = null;
//line 207
___nl__17 = null;
//line 208
___nl__18 = array_NL.NL_len(___nl__16).clone();

//line 208
___nl__19 = new ImmDouble(1).clone();
//line 208
___nl__18 = new ImmDouble((Double.Parse(___nl__18.getValue().ToString()))-(Double.Parse(___nl__19.getValue().ToString()))).clone();
//line 208
___nl__19 = null;
//line 208
___nl__17 = (___nl__16 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__18).getDoubleValue()].clone();
//line 208
___nl__18 = null;
//line 208
___nl__17 = c_rt_lib_NL.NL_ov_as(___nl__17, new ImmString("value")).clone();
//line 209
___nl__18 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__17).clone();
//line 209
___ref______nl__3 = new ImmRef(___nl__3);
array_NL.NL_push(___ref______nl__3,___nl__18);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 209
___nl__18 = null;
//line 210
___ref______nl__4 = new ImmRef(___nl__4);
hash_NL.NL_set_value(___ref______nl__4,___nl__9,___nl__16);
___nl__4 = ___ref______nl__4.getValue().clone();

//line 210
___nl__16 = null;
//line 210
___nl__17 = null;
//line 211
if (true) {goto label_14;}
//line 211
label_15:
//line 212
___ref______nl__2 = new ImmRef(___nl__2);
___nl__16 = translator_NL.NL_new_register_priv(___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 213
___nl__17 = ((ImmHash)___nl__12).getHashValue()["val"].clone();
//line 213
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_val_priv(___nl__17,___nl__16,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 213
___nl__17 = null;
//line 214
___nl__17 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__16).clone();
//line 214
___ref______nl__3 = new ImmRef(___nl__3);
array_NL.NL_push(___ref______nl__3,___nl__17);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 214
___nl__17 = null;
//line 214
___nl__16 = null;
//line 215
if (true) {goto label_14;}
//line 215
label_14:
//line 215
___nl__15 = null;
//line 216
if (true) {goto label_11;}
//line 216
label_11:
//line 216
___nl__13 = null;
//line 216
___nl__14 = null;
//line 217
___ref______nl__2 = new ImmRef(___nl__2);
___nl__13 = translator_NL.NL_save_registers_priv(___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 217
___ref______nl__7 = new ImmRef(___nl__7);
array_NL.NL_push(___ref______nl__7,___nl__13);
___nl__7 = ___ref______nl__7.getValue().clone();

//line 217
___nl__13 = null;
//line 217
___nl__12 = null;
//line 218
___nl__9 = new ImmDouble((Double.Parse(___nl__9.getValue().ToString()))+(Double.Parse(___nl__10.getValue().ToString()))).clone();
//line 218
if (true) {goto label_10;}
//line 218
label_8:
//line 218
___nl__8 = null;
//line 218
___nl__9 = null;
//line 218
___nl__10 = null;
//line 218
___nl__11 = null;
//line 219
___nl__9 = ((ImmHash)___nl__0).getHashValue()["module"].clone();
//line 219
___nl__10 = ((ImmHash)___nl__0).getHashValue()["name"].clone();
//line 219
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__1);
__function_map.Add("mod",___nl__9);
__function_map.Add("fun_name",___nl__10);
__function_map.Add("args",___nl__3);
___nl__8 = new ImmHash(__function_map).clone();
//line 219
___nl__9 = null;
//line 219
___nl__10 = null;
//line 219
___nl__8 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("call"), ___nl__8).clone();
//line 219
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_priv(___ref______nl__2,___nl__8);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 219
___nl__8 = null;
//line 226
___nl__8 = array_NL.NL_len(___nl__7).clone();

//line 226
___nl__9 = new ImmDouble(1).clone();
//line 226
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))-(Double.Parse(___nl__9.getValue().ToString()))).clone();
//line 226
___nl__9 = null;
//line 226
label_17:
//line 226
___nl__9 = new ImmDouble(0).clone();
//line 226
___nl__9 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString()))>=(Double.Parse(___nl__9.getValue().ToString())) ).clone();
//line 226
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 226
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_16;}}
//line 227
___nl__10 = (___nl__7 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()].clone();
//line 227
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_restore_registers_priv(___nl__10,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 227
___nl__10 = null;
//line 228
___nl__10 = hash_NL.NL_has_key(___nl__4,___nl__8).clone();

//line 228
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 228
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 228
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_20;}}
//line 228
___nl__10 = null;
//line 228
if (true) {goto label_18;}
//line 228
if (true) {goto label_20;}
//line 228
label_20:
//line 228
___nl__10 = null;
//line 229
___nl__10 = hash_NL.NL_get_value(___nl__4,___nl__8).clone();

//line 229
___nl__11 = new ImmDouble(1).clone();
//line 229
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_set_value_of_lvalue_priv(___nl__10,___nl__11,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 229
___nl__11 = null;
//line 229
___nl__10 = null;
//line 229
label_18:
//line 229
___nl__10 = new ImmDouble(1).clone();
//line 229
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))-(Double.Parse(___nl__10.getValue().ToString()))).clone();
//line 229
___nl__10 = null;
//line 230
if (true) {goto label_17;}
//line 230
label_16:
//line 230
___nl__8 = null;
//line 230
___nl__9 = null;
//line 230
___nl__3 = null;
//line 230
___nl__4 = null;
//line 230
___nl__5 = null;
//line 230
___nl__6 = null;
//line 230
___nl__7 = null;
//line 230
___nl__0 = null;
//line 230
___nl__1 = null;
//line 230
___arg__2.setValue(___nl__2);if(true) return null;
}

private static Imm NL_print_val_priv(Imm ___arg__0, Imm ___arg__1, ImmRef ___arg__2) {
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
//line 234
___ref______nl__2 = new ImmRef(___nl__2);
___nl__3 = translator_NL.NL_save_registers_priv(___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 235
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("const")).clone();
//line 235
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 237
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("string")).clone();
//line 237
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_3;}}
//line 239
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("ternary_op")).clone();
//line 239
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_4;}}
//line 241
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("hash_key")).clone();
//line 241
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_5;}}
//line 243
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("variant")).clone();
//line 243
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_6;}}
//line 245
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("var")).clone();
//line 245
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_7;}}
//line 247
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("parenthesis")).clone();
//line 247
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_8;}}
//line 249
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("bin_op")).clone();
//line 249
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_9;}}
//line 251
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("var_op")).clone();
//line 251
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_10;}}
//line 253
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("unary_op")).clone();
//line 253
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_11;}}
//line 255
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("fun_val")).clone();
//line 255
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_12;}}
//line 257
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("arr_decl")).clone();
//line 257
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_13;}}
//line 259
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("hash_decl")).clone();
//line 259
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_14;}}
//line 261
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("nop")).clone();
//line 261
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_15;}}
//line 262
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("fun_label")).clone();
//line 262
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_16;}}
//line 264
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("post_inc")).clone();
//line 264
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_17;}}
//line 266
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("post_dec")).clone();
//line 266
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_18;}}
//line 266
___nl__4 = new ImmString("NOMATCHALERT").clone();
//line 266
___nl__4 = new ImmArray(new Imm[] {___nl__4,___nl__0,}).clone();
//line 266
c_rt_lib_NL.NL_die();
//line 235
label_2:
//line 235
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("const")).clone();
//line 236
___nl__6 = translator_NL.NL_convert_str_to_number_priv(___nl__5).clone();

//line 236
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_load_const_priv(___nl__6,___nl__1,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 236
___nl__6 = null;
//line 236
___nl__5 = null;
//line 237
if (true) {goto label_1;}
//line 237
label_3:
//line 237
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("string")).clone();
//line 238
___ref______nl__2 = new ImmRef(___nl__2);
___nl__6 = translator_NL.NL_make_string_priv(___nl__5,___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 238
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_load_const_priv(___nl__6,___nl__1,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 238
___nl__6 = null;
//line 238
___nl__5 = null;
//line 239
if (true) {goto label_1;}
//line 239
label_4:
//line 239
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("ternary_op")).clone();
//line 240
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_ternary_op_priv(___nl__5,___nl__1,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 240
___nl__5 = null;
//line 241
if (true) {goto label_1;}
//line 241
label_5:
//line 241
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("hash_key")).clone();
//line 242
___nl__6 = new ImmArray(new Imm[0]).clone();
//line 242
c_rt_lib_NL.NL_die();
//line 242
___nl__6 = null;
//line 242
___nl__5 = null;
//line 243
if (true) {goto label_1;}
//line 243
label_6:
//line 243
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("variant")).clone();
//line 244
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_variant_priv(___nl__5,___nl__1,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 244
___nl__5 = null;
//line 245
if (true) {goto label_1;}
//line 245
label_7:
//line 245
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("var")).clone();
//line 246
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_variable_priv(___nl__5,___nl__1,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 246
___nl__5 = null;
//line 247
if (true) {goto label_1;}
//line 247
label_8:
//line 247
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("parenthesis")).clone();
//line 248
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_val_priv(___nl__5,___nl__1,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 248
___nl__5 = null;
//line 249
if (true) {goto label_1;}
//line 249
label_9:
//line 249
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("bin_op")).clone();
//line 250
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_bin_op_priv(___nl__5,___nl__1,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 250
___nl__5 = null;
//line 251
if (true) {goto label_1;}
//line 251
label_10:
//line 251
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("var_op")).clone();
//line 252
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_var_op_priv(___nl__5,___nl__1,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 252
___nl__5 = null;
//line 253
if (true) {goto label_1;}
//line 253
label_11:
//line 253
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("unary_op")).clone();
//line 254
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_unary_op_priv(___nl__5,___nl__1,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 254
___nl__5 = null;
//line 255
if (true) {goto label_1;}
//line 255
label_12:
//line 255
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("fun_val")).clone();
//line 256
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_fun_val_priv(___nl__5,___nl__1,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 256
___nl__5 = null;
//line 257
if (true) {goto label_1;}
//line 257
label_13:
//line 257
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("arr_decl")).clone();
//line 258
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_array_declaration_priv(___nl__5,___nl__1,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 258
___nl__5 = null;
//line 259
if (true) {goto label_1;}
//line 259
label_14:
//line 259
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("hash_decl")).clone();
//line 260
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_hash_declaration_priv(___nl__5,___nl__1,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 260
___nl__5 = null;
//line 261
if (true) {goto label_1;}
//line 261
label_15:
//line 262
if (true) {goto label_1;}
//line 262
label_16:
//line 262
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("fun_label")).clone();
//line 263
___nl__6 = new ImmArray(new Imm[0]).clone();
//line 263
c_rt_lib_NL.NL_die();
//line 263
___nl__6 = null;
//line 263
___nl__5 = null;
//line 264
if (true) {goto label_1;}
//line 264
label_17:
//line 264
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("post_inc")).clone();
//line 265
___nl__6 = new ImmString("++").clone();
//line 265
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_post_operator_priv(___nl__5,___nl__6,___nl__1,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 265
___nl__6 = null;
//line 265
___nl__5 = null;
//line 266
if (true) {goto label_1;}
//line 266
label_18:
//line 266
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("post_dec")).clone();
//line 267
___nl__6 = new ImmString("--").clone();
//line 267
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_post_operator_priv(___nl__5,___nl__6,___nl__1,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 267
___nl__6 = null;
//line 267
___nl__5 = null;
//line 268
if (true) {goto label_1;}
//line 268
label_1:
//line 268
___nl__4 = null;
//line 269
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_restore_registers_priv(___nl__3,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 269
___nl__3 = null;
//line 269
___nl__0 = null;
//line 269
___nl__1 = null;
//line 269
___arg__2.setValue(___nl__2);if(true) return null;
}

private static Imm NL_print_variable_priv(Imm ___arg__0, Imm ___arg__1, ImmRef ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.getValue().clone();
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 273
___ref______nl__2 = new ImmRef(___nl__2);
___nl__3 = translator_NL.NL_get_var_register_priv(___nl__0,___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 273
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_move_priv(___nl__1,___nl__3,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 273
___nl__3 = null;
//line 273
___nl__0 = null;
//line 273
___nl__1 = null;
//line 273
___arg__2.setValue(___nl__2);if(true) return null;
}

private static Imm NL_print_post_operator_priv(Imm ___arg__0, Imm ___arg__1, Imm ___arg__2, ImmRef ___arg__3) {
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
//line 277
___nl__5 = new ImmDouble(1).clone();
//line 277
___ref______nl__3 = new ImmRef(___nl__3);
___nl__4 = translator_NL.NL_get_value_of_lvalue_priv(___nl__0,___nl__5,___ref______nl__3).clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 277
___nl__5 = null;
//line 278
___nl__6 = array_NL.NL_len(___nl__4).clone();

//line 278
___nl__7 = new ImmDouble(1).clone();
//line 278
___nl__6 = new ImmDouble((Double.Parse(___nl__6.getValue().ToString()))-(Double.Parse(___nl__7.getValue().ToString()))).clone();
//line 278
___nl__7 = null;
//line 278
___nl__5 = (___nl__4 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()].clone();
//line 278
___nl__6 = null;
//line 278
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("value")).clone();
//line 279
___ref______nl__3 = new ImmRef(___nl__3);
translator_NL.NL_move_priv(___nl__2,___nl__5,___ref______nl__3);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 280
___nl__7 = new ImmDouble(1).clone();
//line 280
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("const"), ___nl__7).clone();
//line 280
___ref______nl__3 = new ImmRef(___nl__3);
___nl__6 = translator_NL.NL_calc_val_priv(___nl__7,___ref______nl__3).clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 280
___nl__7 = null;
//line 281
___nl__7 = new ImmString("++").clone();
//line 281
___nl__7 = c_rt_lib_NL.NL_native_to_nl(___nl__1.toString().Equals(___nl__7.toString())).clone();
//line 281
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_2;}}
//line 281
___nl__7 = new ImmString("-").clone();
//line 281
if (true) {goto label_1;}
//line 281
label_2:
//line 281
___nl__7 = new ImmString("+").clone();
//line 281
label_1:
//line 281
___ref______nl__3 = new ImmRef(___nl__3);
translator_NL.NL_print_bin_op_operator_command_priv(___nl__5,___nl__5,___nl__6,___nl__7,___ref______nl__3);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 281
___nl__7 = null;
//line 282
___nl__7 = new ImmDouble(1).clone();
//line 282
___ref______nl__3 = new ImmRef(___nl__3);
translator_NL.NL_set_value_of_lvalue_priv(___nl__4,___nl__7,___ref______nl__3);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 282
___nl__7 = null;
//line 282
___nl__4 = null;
//line 282
___nl__5 = null;
//line 282
___nl__6 = null;
//line 282
___nl__0 = null;
//line 282
___nl__1 = null;
//line 282
___nl__2 = null;
//line 282
___arg__3.setValue(___nl__3);if(true) return null;
}

private static Imm NL_print_unary_op_priv(Imm ___arg__0, Imm ___arg__1, ImmRef ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.getValue().clone();
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
//line 286
___nl__3 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 286
___nl__4 = new ImmString("!").clone();
//line 286
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__4.toString())).clone();
//line 286
___nl__4 = null;
//line 286
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_4;}}
//line 286
___nl__3 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 286
___nl__4 = new ImmString("-").clone();
//line 286
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__4.toString())).clone();
//line 286
___nl__4 = null;
//line 286
label_4:
//line 286
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 286
___nl__3 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 286
___nl__4 = new ImmString("+").clone();
//line 286
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__4.toString())).clone();
//line 286
___nl__4 = null;
//line 286
label_3:
//line 286
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 286
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 289
___nl__4 = new ImmString("").clone();
//line 289
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__1.toString().Equals(___nl__4.toString())).clone();
//line 289
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 289
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_6;}}
//line 289
___nl__0 = null;
//line 289
___nl__1 = null;
//line 289
___nl__3 = null;
//line 289
___nl__4 = null;
//line 289
___arg__2.setValue(___nl__2);if(true) return null;
//line 289
if (true) {goto label_6;}
//line 289
label_6:
//line 289
___nl__4 = null;
//line 290
___nl__4 = ((ImmHash)___nl__0).getHashValue()["val"].clone();
//line 290
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_val_priv(___nl__4,___nl__1,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 290
___nl__4 = null;
//line 291
___nl__5 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 291
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__1);
__function_map.Add("src",___nl__1);
__function_map.Add("op",___nl__5);
___nl__4 = new ImmHash(__function_map).clone();
//line 291
___nl__5 = null;
//line 291
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("una_op"), ___nl__4).clone();
//line 291
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_priv(___ref______nl__2,___nl__4);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 291
___nl__4 = null;
//line 297
if (true) {goto label_1;}
//line 297
label_2:
//line 297
___nl__3 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 297
___nl__4 = new ImmString("++").clone();
//line 297
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__4.toString())).clone();
//line 297
___nl__4 = null;
//line 297
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_8;}}
//line 297
___nl__3 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 297
___nl__4 = new ImmString("--").clone();
//line 297
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__4.toString())).clone();
//line 297
___nl__4 = null;
//line 297
label_8:
//line 297
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 297
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_7;}}
//line 298
___nl__5 = ((ImmHash)___nl__0).getHashValue()["val"].clone();
//line 298
___nl__6 = new ImmDouble(1).clone();
//line 298
___ref______nl__2 = new ImmRef(___nl__2);
___nl__4 = translator_NL.NL_get_value_of_lvalue_priv(___nl__5,___nl__6,___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 298
___nl__6 = null;
//line 298
___nl__5 = null;
//line 299
___nl__6 = array_NL.NL_len(___nl__4).clone();

//line 299
___nl__7 = new ImmDouble(1).clone();
//line 299
___nl__6 = new ImmDouble((Double.Parse(___nl__6.getValue().ToString()))-(Double.Parse(___nl__7.getValue().ToString()))).clone();
//line 299
___nl__7 = null;
//line 299
___nl__5 = (___nl__4 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()].clone();
//line 299
___nl__6 = null;
//line 299
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("value")).clone();
//line 300
___nl__7 = new ImmDouble(1).clone();
//line 300
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("const"), ___nl__7).clone();
//line 300
___ref______nl__2 = new ImmRef(___nl__2);
___nl__6 = translator_NL.NL_dest_val_priv(___nl__7,___nl__1,___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 300
___nl__7 = null;
//line 301
___nl__7 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 301
___nl__8 = new ImmString("++").clone();
//line 301
___nl__7 = c_rt_lib_NL.NL_native_to_nl(___nl__7.toString().Equals(___nl__8.toString())).clone();
//line 301
___nl__8 = null;
//line 301
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_10;}}
//line 301
___nl__7 = new ImmString("-").clone();
//line 301
if (true) {goto label_9;}
//line 301
label_10:
//line 301
___nl__7 = new ImmString("+").clone();
//line 301
label_9:
//line 301
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_bin_op_operator_command_priv(___nl__5,___nl__5,___nl__6,___nl__7,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 301
___nl__7 = null;
//line 302
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_move_priv(___nl__1,___nl__5,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 303
___nl__7 = new ImmDouble(1).clone();
//line 303
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_set_value_of_lvalue_priv(___nl__4,___nl__7,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 303
___nl__7 = null;
//line 303
___nl__4 = null;
//line 303
___nl__5 = null;
//line 303
___nl__6 = null;
//line 304
if (true) {goto label_1;}
//line 304
label_7:
//line 304
___nl__3 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 304
___nl__4 = new ImmString("@").clone();
//line 304
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__4.toString())).clone();
//line 304
___nl__4 = null;
//line 304
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 304
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_11;}}
//line 305
___nl__4 = new ImmString("").clone();
//line 305
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__1.toString().Equals(___nl__4.toString())).clone();
//line 305
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 305
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_13;}}
//line 305
___nl__0 = null;
//line 305
___nl__1 = null;
//line 305
___nl__3 = null;
//line 305
___nl__4 = null;
//line 305
___arg__2.setValue(___nl__2);if(true) return null;
//line 305
if (true) {goto label_13;}
//line 305
label_13:
//line 305
___nl__4 = null;
//line 306
___nl__4 = ((ImmHash)___nl__0).getHashValue()["val"].clone();
//line 306
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("fun_label")).clone();
//line 307
___nl__6 = ((ImmHash)___nl__4).getHashValue()["module"].clone();
//line 307
___nl__7 = ((ImmHash)___nl__4).getHashValue()["name"].clone();
//line 307
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__1);
__function_map.Add("module",___nl__6);
__function_map.Add("name",___nl__7);
___nl__5 = new ImmHash(__function_map).clone();
//line 307
___nl__6 = null;
//line 307
___nl__7 = null;
//line 307
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("func"), ___nl__5).clone();
//line 307
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_priv(___ref______nl__2,___nl__5);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 307
___nl__5 = null;
//line 313
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("arg"), ___nl__1).clone();
//line 313
___nl__7 = new ImmString("ref").clone();
//line 313
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__1);
__function_map.Add("src",___nl__6);
__function_map.Add("name",___nl__7);
___nl__5 = new ImmHash(__function_map).clone();
//line 313
___nl__6 = null;
//line 313
___nl__7 = null;
//line 313
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ov_mk"), ___nl__5).clone();
//line 313
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_priv(___ref______nl__2,___nl__5);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 313
___nl__5 = null;
//line 313
___nl__4 = null;
//line 319
if (true) {goto label_1;}
//line 319
label_11:
//line 320
___nl__4 = new ImmArray(new Imm[0]).clone();
//line 320
c_rt_lib_NL.NL_die();
//line 320
___nl__4 = null;
//line 321
if (true) {goto label_1;}
//line 321
label_1:
//line 321
___nl__3 = null;
//line 321
___nl__0 = null;
//line 321
___nl__1 = null;
//line 321
___arg__2.setValue(___nl__2);if(true) return null;
}

private static Imm NL_print_var_op_priv(Imm ___arg__0, Imm ___arg__1, ImmRef ___arg__2) {
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
//line 325
___nl__3 = new ImmString("").clone();
//line 325
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__1.toString().Equals(___nl__3.toString())).clone();
//line 325
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 325
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 325
___nl__0 = null;
//line 325
___nl__1 = null;
//line 325
___nl__3 = null;
//line 325
___arg__2.setValue(___nl__2);if(true) return null;
//line 325
if (true) {goto label_2;}
//line 325
label_2:
//line 325
___nl__3 = null;
//line 326
___nl__3 = ((ImmHash)___nl__0).getHashValue()["left"].clone();
//line 326
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_val_priv(___nl__3,___nl__1,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 326
___nl__3 = null;
//line 328
___nl__4 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 328
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("ov_is")).clone();
//line 328
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_4;}}
//line 334
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("ov_as")).clone();
//line 334
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_5;}}
//line 334
___nl__5 = new ImmString("NOMATCHALERT").clone();
//line 334
___nl__5 = new ImmArray(new Imm[] {___nl__5,___nl__4,}).clone();
//line 334
c_rt_lib_NL.NL_die();
//line 328
label_4:
//line 329
___nl__7 = ((ImmHash)___nl__0).getHashValue()["case"].clone();
//line 329
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__1);
__function_map.Add("src",___nl__1);
__function_map.Add("type",___nl__7);
___nl__6 = new ImmHash(__function_map).clone();
//line 329
___nl__7 = null;
//line 329
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ov_is"), ___nl__6).clone();
//line 329
___nl__3 = ___nl__6.clone();
//line 329
___nl__6 = null;
//line 334
if (true) {goto label_3;}
//line 334
label_5:
//line 335
___nl__7 = ((ImmHash)___nl__0).getHashValue()["case"].clone();
//line 335
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__1);
__function_map.Add("src",___nl__1);
__function_map.Add("type",___nl__7);
___nl__6 = new ImmHash(__function_map).clone();
//line 335
___nl__7 = null;
//line 335
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ov_as"), ___nl__6).clone();
//line 335
___nl__3 = ___nl__6.clone();
//line 335
___nl__6 = null;
//line 340
if (true) {goto label_3;}
//line 340
label_3:
//line 340
___nl__4 = null;
//line 340
___nl__5 = null;
//line 341
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_priv(___ref______nl__2,___nl__3);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 341
___nl__3 = null;
//line 341
___nl__0 = null;
//line 341
___nl__1 = null;
//line 341
___arg__2.setValue(___nl__2);if(true) return null;
}

private static Imm NL_print_bin_op_priv(Imm ___arg__0, Imm ___arg__1, ImmRef ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.getValue().clone();
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
//line 344
___nl__3 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 344
___nl__4 = new ImmString("=").clone();
//line 344
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__4.toString())).clone();
//line 344
___nl__4 = null;
//line 344
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 344
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 345
___nl__5 = ((ImmHash)___nl__0).getHashValue()["right"].clone();
//line 345
___ref______nl__2 = new ImmRef(___nl__2);
___nl__4 = translator_NL.NL_dest_val_priv(___nl__5,___nl__1,___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 345
___nl__5 = null;
//line 346
___nl__6 = ((ImmHash)___nl__0).getHashValue()["left"].clone();
//line 346
___nl__7 = new ImmDouble(0).clone();
//line 346
___ref______nl__2 = new ImmRef(___nl__2);
___nl__5 = translator_NL.NL_get_value_of_lvalue_priv(___nl__6,___nl__7,___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 346
___nl__7 = null;
//line 346
___nl__6 = null;
//line 347
___nl__7 = array_NL.NL_len(___nl__5).clone();

//line 347
___nl__8 = new ImmDouble(1).clone();
//line 347
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))-(Double.Parse(___nl__8.getValue().ToString()))).clone();
//line 347
___nl__8 = null;
//line 347
___nl__6 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()].clone();
//line 347
___nl__7 = null;
//line 347
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("value")).clone();
//line 348
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_move_priv(___nl__6,___nl__4,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 349
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_move_priv(___nl__1,___nl__6,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 350
___nl__7 = new ImmDouble(0).clone();
//line 350
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_set_value_of_lvalue_priv(___nl__5,___nl__7,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 350
___nl__7 = null;
//line 350
___nl__4 = null;
//line 350
___nl__5 = null;
//line 350
___nl__6 = null;
//line 351
if (true) {goto label_1;}
//line 351
label_2:
//line 351
___nl__3 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 351
___nl__4 = new ImmString("ARRAY_INDEX").clone();
//line 351
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__4.toString())).clone();
//line 351
___nl__4 = null;
//line 351
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_4;}}
//line 351
___nl__3 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 351
___nl__4 = new ImmString("->").clone();
//line 351
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__4.toString())).clone();
//line 351
___nl__4 = null;
//line 351
label_4:
//line 351
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 351
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 352
___nl__5 = ((ImmHash)___nl__0).getHashValue()["left"].clone();
//line 352
___ref______nl__2 = new ImmRef(___nl__2);
___nl__4 = translator_NL.NL_dest_val_priv(___nl__5,___nl__1,___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 352
___nl__5 = null;
//line 353
___nl__5 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 353
___nl__6 = new ImmString("ARRAY_INDEX").clone();
//line 353
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__5.toString().Equals(___nl__6.toString())).clone();
//line 353
___nl__6 = null;
//line 353
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 353
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_6;}}
//line 354
___nl__7 = ((ImmHash)___nl__0).getHashValue()["right"].clone();
//line 354
___ref______nl__2 = new ImmRef(___nl__2);
___nl__6 = translator_NL.NL_calc_val_priv(___nl__7,___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 354
___nl__7 = null;
//line 355
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_get_from_index_priv(___nl__1,___nl__4,___nl__6,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 355
___nl__6 = null;
//line 356
if (true) {goto label_5;}
//line 356
label_6:
//line 357
___nl__6 = ((ImmHash)___nl__0).getHashValue()["right"].clone();
//line 357
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("hash_key")).clone();
//line 357
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_get_value_priv(___nl__1,___nl__4,___nl__6,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 357
___nl__6 = null;
//line 358
if (true) {goto label_5;}
//line 358
label_5:
//line 358
___nl__5 = null;
//line 358
___nl__4 = null;
//line 359
if (true) {goto label_1;}
//line 359
label_3:
//line 359
___nl__3 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 359
___nl__4 = new ImmString("+=").clone();
//line 359
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__4.toString())).clone();
//line 359
___nl__4 = null;
//line 359
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_11;}}
//line 359
___nl__3 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 359
___nl__4 = new ImmString("-=").clone();
//line 359
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__4.toString())).clone();
//line 359
___nl__4 = null;
//line 359
label_11:
//line 359
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_10;}}
//line 359
___nl__3 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 359
___nl__4 = new ImmString("/=").clone();
//line 359
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__4.toString())).clone();
//line 359
___nl__4 = null;
//line 359
label_10:
//line 359
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_9;}}
//line 359
___nl__3 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 359
___nl__4 = new ImmString("*=").clone();
//line 359
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__4.toString())).clone();
//line 359
___nl__4 = null;
//line 359
label_9:
//line 359
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_8;}}
//line 359
___nl__3 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 359
___nl__4 = new ImmString(".=").clone();
//line 359
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__4.toString())).clone();
//line 359
___nl__4 = null;
//line 359
label_8:
//line 359
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 359
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_7;}}
//line 362
___nl__5 = ((ImmHash)___nl__0).getHashValue()["right"].clone();
//line 362
___ref______nl__2 = new ImmRef(___nl__2);
___nl__4 = translator_NL.NL_calc_val_priv(___nl__5,___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 362
___nl__5 = null;
//line 363
___nl__6 = ((ImmHash)___nl__0).getHashValue()["left"].clone();
//line 363
___nl__7 = new ImmDouble(1).clone();
//line 363
___ref______nl__2 = new ImmRef(___nl__2);
___nl__5 = translator_NL.NL_get_value_of_lvalue_priv(___nl__6,___nl__7,___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 363
___nl__7 = null;
//line 363
___nl__6 = null;
//line 364
___nl__7 = array_NL.NL_len(___nl__5).clone();

//line 364
___nl__8 = new ImmDouble(1).clone();
//line 364
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))-(Double.Parse(___nl__8.getValue().ToString()))).clone();
//line 364
___nl__8 = null;
//line 364
___nl__6 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()].clone();
//line 364
___nl__7 = null;
//line 364
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("value")).clone();
//line 365
___nl__7 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 365
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_bin_op_operator_command_priv(___nl__6,___nl__6,___nl__4,___nl__7,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 365
___nl__7 = null;
//line 366
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_move_priv(___nl__1,___nl__6,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 367
___nl__7 = new ImmDouble(1).clone();
//line 367
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_set_value_of_lvalue_priv(___nl__5,___nl__7,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 367
___nl__7 = null;
//line 367
___nl__4 = null;
//line 367
___nl__5 = null;
//line 367
___nl__6 = null;
//line 368
if (true) {goto label_1;}
//line 368
label_7:
//line 368
___nl__3 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 368
___nl__4 = new ImmString("&&").clone();
//line 368
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__4.toString())).clone();
//line 368
___nl__4 = null;
//line 368
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 368
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_12;}}
//line 369
___ref______nl__2 = new ImmRef(___nl__2);
___nl__4 = translator_NL.NL_get_sim_label_priv(___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 370
___ref______nl__2 = new ImmRef(___nl__2);
___nl__5 = translator_NL.NL_new_register_priv(___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 371
___nl__7 = ((ImmHash)___nl__0).getHashValue()["left"].clone();
//line 371
___ref______nl__2 = new ImmRef(___nl__2);
___nl__6 = translator_NL.NL_def_val_priv(___nl__7,___nl__1,___nl__5,___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 371
___nl__7 = null;
//line 372
___nl__8 = new ImmString("!").clone();
//line 372
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__5);
__function_map.Add("src",___nl__6);
__function_map.Add("op",___nl__8);
___nl__7 = new ImmHash(__function_map).clone();
//line 372
___nl__8 = null;
//line 372
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("una_op"), ___nl__7).clone();
//line 372
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_priv(___ref______nl__2,___nl__7);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 372
___nl__7 = null;
//line 379
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_if_goto_priv(___nl__4,___nl__5,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 380
___nl__7 = ((ImmHash)___nl__0).getHashValue()["right"].clone();
//line 380
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_def_val_priv(___nl__7,___nl__1,___nl__5,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 380
___nl__7 = null;
//line 381
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_sim_label_priv(___nl__4,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 381
___nl__4 = null;
//line 381
___nl__5 = null;
//line 381
___nl__6 = null;
//line 382
if (true) {goto label_1;}
//line 382
label_12:
//line 382
___nl__3 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 382
___nl__4 = new ImmString("||").clone();
//line 382
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__4.toString())).clone();
//line 382
___nl__4 = null;
//line 382
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 382
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_13;}}
//line 383
___ref______nl__2 = new ImmRef(___nl__2);
___nl__4 = translator_NL.NL_get_sim_label_priv(___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 384
___nl__6 = ((ImmHash)___nl__0).getHashValue()["left"].clone();
//line 384
___ref______nl__2 = new ImmRef(___nl__2);
___nl__5 = translator_NL.NL_dest_val_priv(___nl__6,___nl__1,___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 384
___nl__6 = null;
//line 385
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!___nl__1.toString().Equals(___nl__5.toString())).clone();
//line 385
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 385
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_15;}}
//line 385
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_move_priv(___nl__1,___nl__5,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 385
if (true) {goto label_15;}
//line 385
label_15:
//line 385
___nl__6 = null;
//line 386
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_if_goto_priv(___nl__4,___nl__5,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 387
___nl__7 = ((ImmHash)___nl__0).getHashValue()["right"].clone();
//line 387
___ref______nl__2 = new ImmRef(___nl__2);
___nl__6 = translator_NL.NL_dest_val_priv(___nl__7,___nl__1,___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 387
___nl__7 = null;
//line 387
___nl__5 = ___nl__6.clone();
//line 387
___nl__6 = null;
//line 388
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!___nl__5.toString().Equals(___nl__1.toString())).clone();
//line 388
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 388
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_17;}}
//line 388
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_move_priv(___nl__1,___nl__5,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 388
if (true) {goto label_17;}
//line 388
label_17:
//line 388
___nl__6 = null;
//line 389
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_sim_label_priv(___nl__4,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 389
___nl__4 = null;
//line 389
___nl__5 = null;
//line 390
if (true) {goto label_1;}
//line 390
label_13:
//line 391
___nl__5 = ((ImmHash)___nl__0).getHashValue()["left"].clone();
//line 391
___ref______nl__2 = new ImmRef(___nl__2);
___nl__4 = translator_NL.NL_dest_val_priv(___nl__5,___nl__1,___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 391
___nl__5 = null;
//line 393
___nl__6 = c_rt_lib_NL.NL_native_to_nl(___nl__4.toString().Equals(___nl__1.toString())).clone();
//line 393
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 393
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_19;}}
//line 394
___nl__8 = ((ImmHash)___nl__0).getHashValue()["right"].clone();
//line 394
___ref______nl__2 = new ImmRef(___nl__2);
___nl__7 = translator_NL.NL_calc_val_priv(___nl__8,___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 394
___nl__8 = null;
//line 394
___nl__5 = ___nl__7.clone();
//line 394
___nl__7 = null;
//line 395
if (true) {goto label_18;}
//line 395
label_19:
//line 396
___nl__8 = ((ImmHash)___nl__0).getHashValue()["right"].clone();
//line 396
___ref______nl__2 = new ImmRef(___nl__2);
___nl__7 = translator_NL.NL_dest_val_priv(___nl__8,___nl__1,___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 396
___nl__8 = null;
//line 396
___nl__5 = ___nl__7.clone();
//line 396
___nl__7 = null;
//line 397
if (true) {goto label_18;}
//line 397
label_18:
//line 397
___nl__6 = null;
//line 398
___nl__6 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 398
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_bin_op_operator_command_priv(___nl__1,___nl__4,___nl__5,___nl__6,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 398
___nl__6 = null;
//line 398
___nl__4 = null;
//line 398
___nl__5 = null;
//line 399
if (true) {goto label_1;}
//line 399
label_1:
//line 399
___nl__3 = null;
//line 399
___nl__0 = null;
//line 399
___nl__1 = null;
//line 399
___arg__2.setValue(___nl__2);if(true) return null;
}

private static Imm NL_print_cmd_array_priv(Imm ___arg__0, ImmRef ___arg__1) {
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
//line 403
___ref______nl__1 = new ImmRef(___nl__1);
___nl__2 = translator_NL.NL_save_registers_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 404
___nl__4 = new ImmDouble(0).clone();
//line 404
___nl__5 = new ImmDouble(1).clone();
//line 404
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__0).clone();

//line 404
label_3:
//line 404
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) ).clone();
//line 404
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_1;}}
//line 404
___nl__3 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()].clone();
//line 405
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_cmd_priv(___nl__3,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 406
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 406
if (true) {goto label_3;}
//line 406
label_1:
//line 406
___nl__3 = null;
//line 406
___nl__4 = null;
//line 406
___nl__5 = null;
//line 406
___nl__6 = null;
//line 406
___nl__7 = null;
//line 407
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_restore_registers_priv(___nl__2,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 407
___nl__2 = null;
//line 407
___nl__0 = null;
//line 407
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_print_try_ensure_priv(Imm ___arg__0, Imm ___arg__1, ImmRef ___arg__2) {
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
//line 411
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("decl")).clone();
//line 411
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 416
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("lval")).clone();
//line 416
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 417
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("expr")).clone();
//line 417
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_4;}}
//line 417
___nl__3 = new ImmString("NOMATCHALERT").clone();
//line 417
___nl__3 = new ImmArray(new Imm[] {___nl__3,___nl__0,}).clone();
//line 417
c_rt_lib_NL.NL_die();
//line 411
label_2:
//line 411
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("decl")).clone();
//line 412
___nl__6 = ((ImmHash)___nl__4).getHashValue()["name"].clone();
//line 412
___nl__7 = ((ImmHash)___nl__4).getHashValue()["type"].clone();
//line 412
___nl__8 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 412
__function_map = new Dictionary<String, Imm>();
__function_map.Add("name",___nl__6);
__function_map.Add("type",___nl__7);
__function_map.Add("value",___nl__8);
___nl__5 = new ImmHash(__function_map).clone();
//line 412
___nl__6 = null;
//line 412
___nl__7 = null;
//line 412
___nl__8 = null;
//line 412
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_var_decl_priv(___nl__5,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 412
___nl__5 = null;
//line 412
___nl__4 = null;
//line 416
if (true) {goto label_1;}
//line 416
label_3:
//line 416
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("lval")).clone();
//line 416
___nl__4 = null;
//line 417
if (true) {goto label_1;}
//line 417
label_4:
//line 417
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("expr")).clone();
//line 417
___nl__4 = null;
//line 418
if (true) {goto label_1;}
//line 418
label_1:
//line 418
___nl__3 = null;
//line 420
___ref______nl__2 = new ImmRef(___nl__2);
___nl__3 = translator_NL.NL_save_registers_priv(___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 421
___ref______nl__2 = new ImmRef(___nl__2);
___nl__4 = translator_NL.NL_new_register_priv(___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 424
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("decl")).clone();
//line 424
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_6;}}
//line 429
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("lval")).clone();
//line 429
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_7;}}
//line 431
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("expr")).clone();
//line 431
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_8;}}
//line 431
___nl__6 = new ImmString("NOMATCHALERT").clone();
//line 431
___nl__6 = new ImmArray(new Imm[] {___nl__6,___nl__0,}).clone();
//line 431
c_rt_lib_NL.NL_die();
//line 424
label_6:
//line 424
___nl__7 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("decl")).clone();
//line 425
___nl__8 = ((ImmHash)___nl__7).getHashValue()["value"].clone();
//line 425
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("value")).clone();
//line 425
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_10;}}
//line 427
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("none")).clone();
//line 427
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_11;}}
//line 427
___nl__9 = new ImmString("NOMATCHALERT").clone();
//line 427
___nl__9 = new ImmArray(new Imm[] {___nl__9,___nl__8,}).clone();
//line 427
c_rt_lib_NL.NL_die();
//line 425
label_10:
//line 425
___nl__10 = c_rt_lib_NL.NL_ov_as(___nl__8, new ImmString("value")).clone();
//line 426
___ref______nl__2 = new ImmRef(___nl__2);
___nl__11 = translator_NL.NL_calc_val_priv(___nl__10,___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 426
___nl__5 = ___nl__11.clone();
//line 426
___nl__11 = null;
//line 426
___nl__10 = null;
//line 427
if (true) {goto label_9;}
//line 427
label_11:
//line 428
if (true) {goto label_9;}
//line 428
label_9:
//line 428
___nl__8 = null;
//line 428
___nl__9 = null;
//line 428
___nl__7 = null;
//line 429
if (true) {goto label_5;}
//line 429
label_7:
//line 429
___nl__7 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("lval")).clone();
//line 430
___nl__9 = ((ImmHash)___nl__7).getHashValue()["right"].clone();
//line 430
___ref______nl__2 = new ImmRef(___nl__2);
___nl__8 = translator_NL.NL_calc_val_priv(___nl__9,___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 430
___nl__9 = null;
//line 430
___nl__5 = ___nl__8.clone();
//line 430
___nl__8 = null;
//line 430
___nl__7 = null;
//line 431
if (true) {goto label_5;}
//line 431
label_8:
//line 431
___nl__7 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("expr")).clone();
//line 432
___ref______nl__2 = new ImmRef(___nl__2);
___nl__8 = translator_NL.NL_calc_val_priv(___nl__7,___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 432
___nl__5 = ___nl__8.clone();
//line 432
___nl__8 = null;
//line 432
___nl__7 = null;
//line 433
if (true) {goto label_5;}
//line 433
label_5:
//line 433
___nl__6 = null;
//line 435
___ref______nl__2 = new ImmRef(___nl__2);
___nl__6 = translator_NL.NL_get_sim_label_priv(___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 437
___nl__8 = new ImmString("ok").clone();
//line 437
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__4);
__function_map.Add("src",___nl__5);
__function_map.Add("type",___nl__8);
___nl__7 = new ImmHash(__function_map).clone();
//line 437
___nl__8 = null;
//line 437
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ov_is"), ___nl__7).clone();
//line 437
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_priv(___ref______nl__2,___nl__7);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 437
___nl__7 = null;
//line 444
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_if_goto_priv(___nl__6,___nl__4,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 446
___nl__7 = ___nl__1.clone();
//line 446
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 446
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_13;}}
//line 447
___nl__8 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("val"), ___nl__5).clone();
//line 447
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_safe_return_priv(___nl__8,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 447
___nl__8 = null;
//line 448
if (true) {goto label_12;}
//line 448
label_13:
//line 449
___nl__9 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("arg"), ___nl__5).clone();
//line 449
___nl__10 = new ImmString("ensure").clone();
//line 449
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__5);
__function_map.Add("src",___nl__9);
__function_map.Add("name",___nl__10);
___nl__8 = new ImmHash(__function_map).clone();
//line 449
___nl__9 = null;
//line 449
___nl__10 = null;
//line 449
___nl__8 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ov_mk"), ___nl__8).clone();
//line 449
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_priv(___ref______nl__2,___nl__8);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 449
___nl__8 = null;
//line 456
___nl__8 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("die"), ___nl__5).clone();
//line 456
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_priv(___ref______nl__2,___nl__8);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 456
___nl__8 = null;
//line 457
if (true) {goto label_12;}
//line 457
label_12:
//line 457
___nl__7 = null;
//line 458
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_sim_label_priv(___nl__6,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 459
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("decl")).clone();
//line 459
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_15;}}
//line 466
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("lval")).clone();
//line 466
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_16;}}
//line 476
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("expr")).clone();
//line 476
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_17;}}
//line 476
___nl__7 = new ImmString("NOMATCHALERT").clone();
//line 476
___nl__7 = new ImmArray(new Imm[] {___nl__7,___nl__0,}).clone();
//line 476
c_rt_lib_NL.NL_die();
//line 459
label_15:
//line 459
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("decl")).clone();
//line 460
___nl__11 = ((ImmHash)___nl__8).getHashValue()["name"].clone();
//line 460
___ref______nl__2 = new ImmRef(___nl__2);
___nl__10 = translator_NL.NL_get_var_register_priv(___nl__11,___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 460
___nl__11 = null;
//line 460
___nl__11 = new ImmString("ok").clone();
//line 460
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__10);
__function_map.Add("src",___nl__5);
__function_map.Add("type",___nl__11);
___nl__9 = new ImmHash(__function_map).clone();
//line 460
___nl__10 = null;
//line 460
___nl__11 = null;
//line 460
___nl__9 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ov_as"), ___nl__9).clone();
//line 460
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_priv(___ref______nl__2,___nl__9);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 460
___nl__9 = null;
//line 460
___nl__8 = null;
//line 466
if (true) {goto label_14;}
//line 466
label_16:
//line 466
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("lval")).clone();
//line 467
___nl__10 = ((ImmHash)___nl__8).getHashValue()["left"].clone();
//line 467
___nl__11 = new ImmDouble(0).clone();
//line 467
___ref______nl__2 = new ImmRef(___nl__2);
___nl__9 = translator_NL.NL_get_value_of_lvalue_priv(___nl__10,___nl__11,___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 467
___nl__11 = null;
//line 467
___nl__10 = null;
//line 468
___nl__11 = array_NL.NL_len(___nl__9).clone();

//line 468
___nl__12 = new ImmDouble(1).clone();
//line 468
___nl__11 = new ImmDouble((Double.Parse(___nl__11.getValue().ToString()))-(Double.Parse(___nl__12.getValue().ToString()))).clone();
//line 468
___nl__12 = null;
//line 468
___nl__10 = (___nl__9 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__11).getDoubleValue()].clone();
//line 468
___nl__11 = null;
//line 468
___nl__10 = c_rt_lib_NL.NL_ov_as(___nl__10, new ImmString("value")).clone();
//line 469
___nl__12 = new ImmString("ok").clone();
//line 469
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__10);
__function_map.Add("src",___nl__5);
__function_map.Add("type",___nl__12);
___nl__11 = new ImmHash(__function_map).clone();
//line 469
___nl__12 = null;
//line 469
___nl__11 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ov_as"), ___nl__11).clone();
//line 469
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_priv(___ref______nl__2,___nl__11);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 469
___nl__11 = null;
//line 475
___nl__11 = new ImmDouble(0).clone();
//line 475
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_set_value_of_lvalue_priv(___nl__9,___nl__11,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 475
___nl__11 = null;
//line 475
___nl__9 = null;
//line 475
___nl__10 = null;
//line 475
___nl__8 = null;
//line 476
if (true) {goto label_14;}
//line 476
label_17:
//line 476
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("expr")).clone();
//line 476
___nl__8 = null;
//line 477
if (true) {goto label_14;}
//line 477
label_14:
//line 477
___nl__7 = null;
//line 478
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_restore_registers_priv(___nl__3,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 478
___nl__3 = null;
//line 478
___nl__4 = null;
//line 478
___nl__5 = null;
//line 478
___nl__6 = null;
//line 478
___nl__0 = null;
//line 478
___nl__1 = null;
//line 478
___arg__2.setValue(___nl__2);if(true) return null;
}

private static Imm NL_start_new_instruction_priv(Imm ___arg__0, ImmRef ___arg__1) {
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
//line 482
___nl__2 = new ImmString("debug").clone();
//line 482
___nl__2 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__2).clone();

//line 482
___nl__3 = ___nl__0.clone();
//line 482
((ImmHash)___nl__2).set("nast_debug", ___nl__3);
//line 482
___nl__4 = new ImmString("debug").clone();
//line 482
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__4,___nl__2);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 482
___nl__4 = null;
//line 482
___nl__2 = null;
//line 482
___nl__3 = null;
//line 483
___nl__2 = new ImmString("debug").clone();
//line 483
___nl__2 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__2).clone();

//line 483
___nl__3 = new ImmString("instruction_nr").clone();
//line 483
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__2,___nl__3).clone();

//line 483
___nl__4 = new ImmDouble(1).clone();
//line 483
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString()))).clone();
//line 483
___nl__5 = new ImmString("instruction_nr").clone();
//line 483
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__2,___nl__5,___nl__3);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 483
___nl__5 = new ImmString("debug").clone();
//line 483
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__5,___nl__2);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 483
___nl__5 = null;
//line 483
___nl__2 = null;
//line 483
___nl__3 = null;
//line 483
___nl__4 = null;
//line 483
___nl__0 = null;
//line 483
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_print_cmd_priv(Imm ___arg__0, ImmRef ___arg__1) {
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
//line 487
___nl__2 = ((ImmHash)___nl__0).getHashValue()["debug"].clone();
//line 487
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_start_new_instruction_priv(___nl__2,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 487
___nl__2 = null;
//line 488
___nl__2 = ((ImmHash)___nl__0).getHashValue()["cmd"].clone();
//line 488
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("if")).clone();
//line 488
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 490
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("fora")).clone();
//line 490
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 492
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("loop")).clone();
//line 492
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_4;}}
//line 494
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("rep")).clone();
//line 494
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_5;}}
//line 496
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("forh")).clone();
//line 496
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_6;}}
//line 498
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("while")).clone();
//line 498
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_7;}}
//line 500
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("for")).clone();
//line 500
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_8;}}
//line 502
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("nop")).clone();
//line 502
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_9;}}
//line 503
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("value")).clone();
//line 503
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_10;}}
//line 505
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("block")).clone();
//line 505
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_11;}}
//line 507
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("return")).clone();
//line 507
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_12;}}
//line 509
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("match")).clone();
//line 509
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_13;}}
//line 511
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("try")).clone();
//line 511
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_14;}}
//line 513
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("ensure")).clone();
//line 513
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_15;}}
//line 515
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("break")).clone();
//line 515
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_16;}}
//line 517
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("continue")).clone();
//line 517
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_17;}}
//line 519
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("die")).clone();
//line 519
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_18;}}
//line 521
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("var_decl")).clone();
//line 521
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_19;}}
//line 523
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("if_mod")).clone();
//line 523
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_20;}}
//line 525
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("unless_mod")).clone();
//line 525
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_21;}}
//line 525
___nl__3 = new ImmString("NOMATCHALERT").clone();
//line 525
___nl__3 = new ImmArray(new Imm[] {___nl__3,___nl__2,}).clone();
//line 525
c_rt_lib_NL.NL_die();
//line 488
label_2:
//line 488
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("if")).clone();
//line 489
___nl__5 = c_rt_lib_NL.NL_get_false().clone();
//line 489
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_if_priv(___nl__4,___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 489
___nl__5 = null;
//line 489
___nl__4 = null;
//line 490
if (true) {goto label_1;}
//line 490
label_3:
//line 490
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("fora")).clone();
//line 491
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_fora_priv(___nl__4,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 491
___nl__4 = null;
//line 492
if (true) {goto label_1;}
//line 492
label_4:
//line 492
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("loop")).clone();
//line 493
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_loop_priv(___nl__4,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 493
___nl__4 = null;
//line 494
if (true) {goto label_1;}
//line 494
label_5:
//line 494
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("rep")).clone();
//line 495
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_rep_priv(___nl__4,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 495
___nl__4 = null;
//line 496
if (true) {goto label_1;}
//line 496
label_6:
//line 496
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("forh")).clone();
//line 497
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_forh_priv(___nl__4,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 497
___nl__4 = null;
//line 498
if (true) {goto label_1;}
//line 498
label_7:
//line 498
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("while")).clone();
//line 499
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_while_priv(___nl__4,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 499
___nl__4 = null;
//line 500
if (true) {goto label_1;}
//line 500
label_8:
//line 500
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("for")).clone();
//line 501
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_for_priv(___nl__4,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 501
___nl__4 = null;
//line 502
if (true) {goto label_1;}
//line 502
label_9:
//line 503
if (true) {goto label_1;}
//line 503
label_10:
//line 503
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("value")).clone();
//line 504
___nl__5 = new ImmString("").clone();
//line 504
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_val_priv(___nl__4,___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 504
___nl__5 = null;
//line 504
___nl__4 = null;
//line 505
if (true) {goto label_1;}
//line 505
label_11:
//line 505
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("block")).clone();
//line 506
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_cmd_array_priv(___nl__4,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 506
___nl__4 = null;
//line 507
if (true) {goto label_1;}
//line 507
label_12:
//line 507
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("return")).clone();
//line 508
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_return_priv(___nl__4,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 508
___nl__4 = null;
//line 509
if (true) {goto label_1;}
//line 509
label_13:
//line 509
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("match")).clone();
//line 510
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_match_priv(___nl__4,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 510
___nl__4 = null;
//line 511
if (true) {goto label_1;}
//line 511
label_14:
//line 511
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("try")).clone();
//line 512
___nl__5 = c_rt_lib_NL.NL_get_true().clone();
//line 512
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_try_ensure_priv(___nl__4,___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 512
___nl__5 = null;
//line 512
___nl__4 = null;
//line 513
if (true) {goto label_1;}
//line 513
label_15:
//line 513
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("ensure")).clone();
//line 514
___nl__5 = c_rt_lib_NL.NL_get_false().clone();
//line 514
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_try_ensure_priv(___nl__4,___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 514
___nl__5 = null;
//line 514
___nl__4 = null;
//line 515
if (true) {goto label_1;}
//line 515
label_16:
//line 516
___nl__4 = ((ImmHash)___nl__1).getHashValue()["loop_label"].clone();
//line 516
___nl__4 = ((ImmHash)___nl__4).getHashValue()["break"].clone();
//line 516
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_loop_break_priv(___ref______nl__1,___nl__4);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 516
___nl__4 = null;
//line 517
if (true) {goto label_1;}
//line 517
label_17:
//line 518
___nl__4 = ((ImmHash)___nl__1).getHashValue()["loop_label"].clone();
//line 518
___nl__4 = ((ImmHash)___nl__4).getHashValue()["continue"].clone();
//line 518
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_loop_break_priv(___ref______nl__1,___nl__4);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 518
___nl__4 = null;
//line 519
if (true) {goto label_1;}
//line 519
label_18:
//line 519
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("die")).clone();
//line 520
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_die_priv(___nl__4,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 520
___nl__4 = null;
//line 521
if (true) {goto label_1;}
//line 521
label_19:
//line 521
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("var_decl")).clone();
//line 522
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_var_decl_priv(___nl__4,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 522
___nl__4 = null;
//line 523
if (true) {goto label_1;}
//line 523
label_20:
//line 523
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("if_mod")).clone();
//line 524
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_if_mod_priv(___nl__4,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 524
___nl__4 = null;
//line 525
if (true) {goto label_1;}
//line 525
label_21:
//line 525
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("unless_mod")).clone();
//line 526
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_unless_mod_priv(___nl__4,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 526
___nl__4 = null;
//line 527
if (true) {goto label_1;}
//line 527
label_1:
//line 527
___nl__2 = null;
//line 527
___nl__3 = null;
//line 527
___nl__0 = null;
//line 527
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_print_loop_break_priv(ImmRef ___arg__0, Imm ___arg__1) {
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
//line 530
___nl__2 = ((ImmHash)___nl__1).getHashValue()["logic"].clone();
//line 530
___nl__2 = ((ImmHash)___nl__2).getHashValue()["register"].clone();
//line 530
label_2:
//line 530
___nl__3 = ((ImmHash)___nl__0).getHashValue()["logic"].clone();
//line 530
___nl__3 = ((ImmHash)___nl__3).getHashValue()["register"].clone();
//line 530
___nl__3 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__2.getValue().ToString()))<(Double.Parse(___nl__3.getValue().ToString())) ).clone();
//line 530
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 530
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_1;}}
//line 531
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__5 = new ImmHash(__function_map).clone();
//line 531
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__5).clone();
//line 531
___nl__4 = ptd_NL.NL_ensure(___nl__5,___nl__2).clone();

//line 531
___nl__5 = null;
//line 531
___ref______nl__0 = new ImmRef(___nl__0);
translator_NL.NL_undef_reg_priv(___nl__4,___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 531
___nl__4 = null;
//line 531
___nl__4 = new ImmDouble(1).clone();
//line 531
___nl__2 = new ImmDouble((Double.Parse(___nl__2.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString()))).clone();
//line 531
___nl__4 = null;
//line 532
if (true) {goto label_2;}
//line 532
label_1:
//line 532
___nl__2 = null;
//line 532
___nl__3 = null;
//line 533
___nl__2 = ((ImmHash)___nl__1).getHashValue()["label"].clone();
//line 533
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("goto"), ___nl__2).clone();
//line 533
___ref______nl__0 = new ImmRef(___nl__0);
translator_NL.NL_print_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 533
___nl__2 = null;
//line 533
___nl__1 = null;
//line 533
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_print_if_mod_priv(Imm ___arg__0, ImmRef ___arg__1) {
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
//line 537
___nl__3 = ((ImmHash)___nl__0).getHashValue()["cond"].clone();
//line 537
___nl__4 = ((ImmHash)___nl__0).getHashValue()["cmd"].clone();
//line 537
___nl__5 = new ImmArray(new Imm[0]).clone();
//line 537
___nl__7 = ((ImmHash)___nl__0).getHashValue()["cmd"].clone();
//line 537
___nl__7 = ((ImmHash)___nl__7).getHashValue()["debug"].clone();
//line 537
___nl__8 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("nop")).clone();
//line 537
__function_map = new Dictionary<String, Imm>();
__function_map.Add("debug",___nl__7);
__function_map.Add("cmd",___nl__8);
___nl__6 = new ImmHash(__function_map).clone();
//line 537
___nl__7 = null;
//line 537
___nl__8 = null;
//line 537
__function_map = new Dictionary<String, Imm>();
__function_map.Add("cond",___nl__3);
__function_map.Add("if",___nl__4);
__function_map.Add("elsif",___nl__5);
__function_map.Add("else",___nl__6);
___nl__2 = new ImmHash(__function_map).clone();
//line 537
___nl__3 = null;
//line 537
___nl__4 = null;
//line 537
___nl__5 = null;
//line 537
___nl__6 = null;
//line 538
___nl__3 = c_rt_lib_NL.NL_get_true().clone();
//line 538
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_if_priv(___nl__2,___nl__3,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 538
___nl__3 = null;
//line 538
___nl__2 = null;
//line 538
___nl__0 = null;
//line 538
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_print_unless_mod_priv(Imm ___arg__0, ImmRef ___arg__1) {
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
//line 542
___nl__4 = ((ImmHash)___nl__0).getHashValue()["cond"].clone();
//line 542
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("parenthesis"), ___nl__4).clone();
//line 542
___nl__5 = new ImmString("!").clone();
//line 542
__function_map = new Dictionary<String, Imm>();
__function_map.Add("val",___nl__4);
__function_map.Add("op",___nl__5);
___nl__3 = new ImmHash(__function_map).clone();
//line 542
___nl__4 = null;
//line 542
___nl__5 = null;
//line 542
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("unary_op"), ___nl__3).clone();
//line 542
___nl__4 = ((ImmHash)___nl__0).getHashValue()["cmd"].clone();
//line 542
___nl__5 = new ImmArray(new Imm[0]).clone();
//line 542
___nl__7 = ((ImmHash)___nl__0).getHashValue()["cmd"].clone();
//line 542
___nl__7 = ((ImmHash)___nl__7).getHashValue()["debug"].clone();
//line 542
___nl__8 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("nop")).clone();
//line 542
__function_map = new Dictionary<String, Imm>();
__function_map.Add("debug",___nl__7);
__function_map.Add("cmd",___nl__8);
___nl__6 = new ImmHash(__function_map).clone();
//line 542
___nl__7 = null;
//line 542
___nl__8 = null;
//line 542
__function_map = new Dictionary<String, Imm>();
__function_map.Add("cond",___nl__3);
__function_map.Add("if",___nl__4);
__function_map.Add("elsif",___nl__5);
__function_map.Add("else",___nl__6);
___nl__2 = new ImmHash(__function_map).clone();
//line 542
___nl__3 = null;
//line 542
___nl__4 = null;
//line 542
___nl__5 = null;
//line 542
___nl__6 = null;
//line 548
___nl__3 = c_rt_lib_NL.NL_get_true().clone();
//line 548
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_if_priv(___nl__2,___nl__3,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 548
___nl__3 = null;
//line 548
___nl__2 = null;
//line 548
___nl__0 = null;
//line 548
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_print_if_priv(Imm ___arg__0, Imm ___arg__1, ImmRef ___arg__2) {
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
//line 552
___ref______nl__2 = new ImmRef(___nl__2);
___nl__3 = translator_NL.NL_save_registers_priv(___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 554
___ref______nl__2 = new ImmRef(___nl__2);
___nl__4 = translator_NL.NL_get_sim_label_priv(___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 555
___ref______nl__2 = new ImmRef(___nl__2);
___nl__5 = translator_NL.NL_get_sim_label_priv(___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 557
___ref______nl__2 = new ImmRef(___nl__2);
___nl__6 = translator_NL.NL_new_register_priv(___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 558
___ref______nl__2 = new ImmRef(___nl__2);
___nl__7 = translator_NL.NL_save_registers_priv(___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 560
___nl__8 = ((ImmHash)___nl__0).getHashValue()["cond"].clone();
//line 560
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_val_priv(___nl__8,___nl__6,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 560
___nl__8 = null;
//line 561
___nl__9 = new ImmString("!").clone();
//line 561
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__6);
__function_map.Add("src",___nl__6);
__function_map.Add("op",___nl__9);
___nl__8 = new ImmHash(__function_map).clone();
//line 561
___nl__9 = null;
//line 561
___nl__8 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("una_op"), ___nl__8).clone();
//line 561
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_priv(___ref______nl__2,___nl__8);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 561
___nl__8 = null;
//line 568
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_restore_registers_priv(___nl__7,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 569
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_if_goto_priv(___nl__5,___nl__6,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 570
___nl__8 = ((ImmHash)___nl__0).getHashValue()["if"].clone();
//line 570
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_cmd_priv(___nl__8,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 570
___nl__8 = null;
//line 571
___nl__8 = ___nl__1.clone();
//line 571
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 571
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 571
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_2;}}
//line 571
___nl__10 = ((ImmHash)___nl__0).getHashValue()["if"].clone();
//line 571
___nl__10 = ((ImmHash)___nl__10).getHashValue()["debug"].clone();
//line 571
___nl__9 = translator_NL.NL_last_debug_char(___nl__10).clone();

//line 571
___nl__10 = null;
//line 571
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_start_new_instruction_priv(___nl__9,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 571
___nl__9 = null;
//line 571
if (true) {goto label_2;}
//line 571
label_2:
//line 571
___nl__8 = null;
//line 572
___nl__8 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("goto"), ___nl__4).clone();
//line 572
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_priv(___ref______nl__2,___nl__8);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 572
___nl__8 = null;
//line 573
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_sim_label_priv(___nl__5,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 575
___nl__8 = ((ImmHash)___nl__0).getHashValue()["elsif"].clone();
//line 575
___nl__10 = new ImmDouble(0).clone();
//line 575
___nl__11 = new ImmDouble(1).clone();
//line 575
___nl__12 = c_rt_lib_NL.NL_array_len(___nl__8).clone();

//line 575
label_5:
//line 575
___nl__13 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__10.getValue().ToString()))>=(Double.Parse(___nl__12.getValue().ToString())) ).clone();
//line 575
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_3;}}
//line 575
___nl__9 = (___nl__8 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()].clone();
//line 576
___nl__14 = ((ImmHash)___nl__9).getHashValue()["debug"].clone();
//line 576
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_start_new_instruction_priv(___nl__14,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 576
___nl__14 = null;
//line 577
___ref______nl__2 = new ImmRef(___nl__2);
___nl__14 = translator_NL.NL_get_sim_label_priv(___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 577
___nl__5 = ___nl__14.clone();
//line 577
___nl__14 = null;
//line 579
___nl__14 = ((ImmHash)___nl__9).getHashValue()["cond"].clone();
//line 579
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_val_priv(___nl__14,___nl__6,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 579
___nl__14 = null;
//line 580
___nl__15 = new ImmString("!").clone();
//line 580
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__6);
__function_map.Add("src",___nl__6);
__function_map.Add("op",___nl__15);
___nl__14 = new ImmHash(__function_map).clone();
//line 580
___nl__15 = null;
//line 580
___nl__14 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("una_op"), ___nl__14).clone();
//line 580
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_priv(___ref______nl__2,___nl__14);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 580
___nl__14 = null;
//line 587
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_restore_registers_priv(___nl__7,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 588
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_if_goto_priv(___nl__5,___nl__6,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 589
___nl__14 = ((ImmHash)___nl__9).getHashValue()["cmd"].clone();
//line 589
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_cmd_priv(___nl__14,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 589
___nl__14 = null;
//line 590
___nl__15 = ((ImmHash)___nl__9).getHashValue()["cmd"].clone();
//line 590
___nl__15 = ((ImmHash)___nl__15).getHashValue()["debug"].clone();
//line 590
___nl__14 = translator_NL.NL_last_debug_char(___nl__15).clone();

//line 590
___nl__15 = null;
//line 590
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_start_new_instruction_priv(___nl__14,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 590
___nl__14 = null;
//line 591
___nl__14 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("goto"), ___nl__4).clone();
//line 591
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_priv(___ref______nl__2,___nl__14);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 591
___nl__14 = null;
//line 592
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_sim_label_priv(___nl__5,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 593
___nl__10 = new ImmDouble((Double.Parse(___nl__10.getValue().ToString()))+(Double.Parse(___nl__11.getValue().ToString()))).clone();
//line 593
if (true) {goto label_5;}
//line 593
label_3:
//line 593
___nl__8 = null;
//line 593
___nl__9 = null;
//line 593
___nl__10 = null;
//line 593
___nl__11 = null;
//line 593
___nl__12 = null;
//line 593
___nl__13 = null;
//line 594
___nl__8 = ((ImmHash)___nl__0).getHashValue()["else"].clone();
//line 594
___nl__8 = ((ImmHash)___nl__8).getHashValue()["cmd"].clone();
//line 594
___nl__8 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("nop")).clone();
//line 594
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 594
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 594
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_7;}}
//line 595
___nl__9 = ((ImmHash)___nl__0).getHashValue()["else"].clone();
//line 595
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_cmd_priv(___nl__9,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 595
___nl__9 = null;
//line 596
___nl__10 = ((ImmHash)___nl__0).getHashValue()["else"].clone();
//line 596
___nl__10 = ((ImmHash)___nl__10).getHashValue()["debug"].clone();
//line 596
___nl__9 = translator_NL.NL_last_debug_char(___nl__10).clone();

//line 596
___nl__10 = null;
//line 596
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_start_new_instruction_priv(___nl__9,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 596
___nl__9 = null;
//line 597
___nl__9 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("goto"), ___nl__4).clone();
//line 597
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_priv(___ref______nl__2,___nl__9);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 597
___nl__9 = null;
//line 598
if (true) {goto label_7;}
//line 598
label_7:
//line 598
___nl__8 = null;
//line 600
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_sim_label_priv(___nl__4,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 601
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_restore_registers_priv(___nl__3,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 601
___nl__3 = null;
//line 601
___nl__4 = null;
//line 601
___nl__5 = null;
//line 601
___nl__6 = null;
//line 601
___nl__7 = null;
//line 601
___nl__0 = null;
//line 601
___nl__1 = null;
//line 601
___arg__2.setValue(___nl__2);if(true) return null;
}

private static Imm NL_print_call_base_priv(Imm ___arg__0, Imm ___arg__1, Imm ___arg__2, ImmRef ___arg__3) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();Imm ___nl__3 = ___arg__3.getValue().clone();
Imm ___nl__4 = null;
Imm ___nl__5 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
Dictionary<String, Imm> __function_map;
//line 607
___nl__5 = new ImmString("c_rt_lib").clone();
//line 607
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__0);
__function_map.Add("mod",___nl__5);
__function_map.Add("fun_name",___nl__1);
__function_map.Add("args",___nl__2);
___nl__4 = new ImmHash(__function_map).clone();
//line 607
___nl__5 = null;
//line 607
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("call"), ___nl__4).clone();
//line 607
___ref______nl__3 = new ImmRef(___nl__3);
translator_NL.NL_print_priv(___ref______nl__3,___nl__4);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 607
___nl__4 = null;
//line 607
___nl__0 = null;
//line 607
___nl__1 = null;
//line 607
___nl__2 = null;
//line 607
___arg__3.setValue(___nl__3);if(true) return null;
}

private static Imm NL_save_loop_break_priv(ImmRef ___arg__0, Imm ___arg__1, Imm ___arg__2) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();
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
//line 617
___nl__3 = ((ImmHash)___nl__0).getHashValue()["loop_label"].clone();
//line 618
___ref______nl__0 = new ImmRef(___nl__0);
___nl__4 = translator_NL.NL_save_registers_priv(___ref______nl__0).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 619
__function_map = new Dictionary<String, Imm>();
__function_map.Add("label",___nl__1);
__function_map.Add("logic",___nl__4);
___nl__5 = new ImmHash(__function_map).clone();
//line 619
___nl__6 = new ImmString("loop_label").clone();
//line 619
___nl__6 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__6).clone();

//line 619
___nl__7 = ___nl__5.clone();
//line 619
((ImmHash)___nl__6).set("break", ___nl__7);
//line 619
___nl__8 = new ImmString("loop_label").clone();
//line 619
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__8,___nl__6);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 619
___nl__8 = null;
//line 619
___nl__5 = null;
//line 619
___nl__6 = null;
//line 619
___nl__7 = null;
//line 620
__function_map = new Dictionary<String, Imm>();
__function_map.Add("label",___nl__2);
__function_map.Add("logic",___nl__4);
___nl__5 = new ImmHash(__function_map).clone();
//line 620
___nl__6 = new ImmString("loop_label").clone();
//line 620
___nl__6 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__6).clone();

//line 620
___nl__7 = ___nl__5.clone();
//line 620
((ImmHash)___nl__6).set("continue", ___nl__7);
//line 620
___nl__8 = new ImmString("loop_label").clone();
//line 620
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__8,___nl__6);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 620
___nl__8 = null;
//line 620
___nl__5 = null;
//line 620
___nl__6 = null;
//line 620
___nl__7 = null;
//line 621
___nl__1 = null;
//line 621
___nl__2 = null;
//line 621
___nl__4 = null;
//line 621
___arg__0.setValue(___nl__0);if(true) return ___nl__3;
//line 621
___nl__3 = null;
//line 621
___nl__4 = null;
//line 621
___nl__1 = null;
//line 621
___nl__2 = null;
//line 621
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_print_fora_priv(Imm ___arg__0, ImmRef ___arg__1) {
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
//line 624
___nl__2 = ((ImmHash)___nl__1).getHashValue()["debug"].clone();
//line 624
___nl__2 = ((ImmHash)___nl__2).getHashValue()["nast_debug"].clone();
//line 625
___ref______nl__1 = new ImmRef(___nl__1);
___nl__3 = translator_NL.NL_save_registers_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 627
___nl__5 = ((ImmHash)___nl__0).getHashValue()["array"].clone();
//line 627
___ref______nl__1 = new ImmRef(___nl__1);
___nl__4 = translator_NL.NL_calc_val_priv(___nl__5,___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 627
___nl__5 = null;
//line 628
___nl__6 = ((ImmHash)___nl__0).getHashValue()["iter"].clone();
//line 628
___ref______nl__1 = new ImmRef(___nl__1);
___nl__5 = translator_NL.NL_print_var_decl_priv(___nl__6,___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 628
___nl__6 = null;
//line 630
___ref______nl__1 = new ImmRef(___nl__1);
___nl__6 = translator_NL.NL_get_sim_label_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 631
___ref______nl__1 = new ImmRef(___nl__1);
___nl__7 = translator_NL.NL_get_sim_label_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 632
___ref______nl__1 = new ImmRef(___nl__1);
___nl__8 = translator_NL.NL_get_sim_label_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 634
___ref______nl__1 = new ImmRef(___nl__1);
___nl__9 = translator_NL.NL_new_register_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 635
___nl__10 = new ImmDouble(0).clone();
//line 635
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_load_const_priv(___nl__10,___nl__9,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 635
___nl__10 = null;
//line 636
___ref______nl__1 = new ImmRef(___nl__1);
___nl__10 = translator_NL.NL_new_register_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 637
___nl__11 = new ImmDouble(1).clone();
//line 637
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_load_const_priv(___nl__11,___nl__10,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 637
___nl__11 = null;
//line 639
___ref______nl__1 = new ImmRef(___nl__1);
___nl__11 = translator_NL.NL_new_register_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 640
___nl__12 = new ImmString("array_len").clone();
//line 640
___nl__14 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("val"), ___nl__4).clone();
//line 640
___nl__13 = new ImmArray(new Imm[] {___nl__14,}).clone();
//line 640
___nl__14 = null;
//line 640
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_call_base_priv(___nl__11,___nl__12,___nl__13,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 640
___nl__13 = null;
//line 640
___nl__12 = null;
//line 642
___ref______nl__1 = new ImmRef(___nl__1);
___nl__12 = translator_NL.NL_new_register_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 644
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_sim_label_priv(___nl__8,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 645
___nl__13 = new ImmString(">=").clone();
//line 645
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_bin_op_operator_command_priv(___nl__12,___nl__9,___nl__11,___nl__13,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 645
___nl__13 = null;
//line 647
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_if_goto_priv(___nl__6,___nl__12,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 648
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__5);
__function_map.Add("src",___nl__4);
__function_map.Add("idx",___nl__9);
___nl__13 = new ImmHash(__function_map).clone();
//line 648
___nl__13 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("get_frm_idx"), ___nl__13).clone();
//line 648
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_priv(___ref______nl__1,___nl__13);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 648
___nl__13 = null;
//line 655
___ref______nl__1 = new ImmRef(___nl__1);
___nl__13 = translator_NL.NL_save_loop_break_priv(___ref______nl__1,___nl__6,___nl__7).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 656
___nl__14 = ((ImmHash)___nl__0).getHashValue()["cmd"].clone();
//line 656
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_cmd_priv(___nl__14,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 656
___nl__14 = null;
//line 658
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_sim_label_priv(___nl__7,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 659
___nl__14 = ((ImmHash)___nl__0).getHashValue()["short"].clone();
//line 659
___nl__14 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__14)).clone();
//line 659
___nl__14 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__14)).clone();
//line 659
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_2;}}
//line 659
___nl__15 = translator_NL.NL_last_debug_char(___nl__2).clone();

//line 659
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_start_new_instruction_priv(___nl__15,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 659
___nl__15 = null;
//line 659
if (true) {goto label_2;}
//line 659
label_2:
//line 659
___nl__14 = null;
//line 660
___nl__15 = new ImmString("+").clone();
//line 660
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__9);
__function_map.Add("left",___nl__9);
__function_map.Add("right",___nl__10);
__function_map.Add("op",___nl__15);
___nl__14 = new ImmHash(__function_map).clone();
//line 660
___nl__15 = null;
//line 660
___nl__14 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("bin_op"), ___nl__14).clone();
//line 660
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_priv(___ref______nl__1,___nl__14);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 660
___nl__14 = null;
//line 667
___nl__14 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("goto"), ___nl__8).clone();
//line 667
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_priv(___ref______nl__1,___nl__14);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 667
___nl__14 = null;
//line 668
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_sim_label_priv(___nl__6,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 670
___nl__14 = ___nl__13.clone();
//line 670
((ImmHash)___nl__1).set("loop_label", ___nl__14);
//line 670
___nl__14 = null;
//line 671
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_restore_registers_priv(___nl__3,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 671
___nl__2 = null;
//line 671
___nl__3 = null;
//line 671
___nl__4 = null;
//line 671
___nl__5 = null;
//line 671
___nl__6 = null;
//line 671
___nl__7 = null;
//line 671
___nl__8 = null;
//line 671
___nl__9 = null;
//line 671
___nl__10 = null;
//line 671
___nl__11 = null;
//line 671
___nl__12 = null;
//line 671
___nl__13 = null;
//line 671
___nl__0 = null;
//line 671
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_print_loop_priv(Imm ___arg__0, ImmRef ___arg__1) {
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
//line 675
___ref______nl__1 = new ImmRef(___nl__1);
___nl__2 = translator_NL.NL_save_registers_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 677
___ref______nl__1 = new ImmRef(___nl__1);
___nl__3 = translator_NL.NL_get_sim_label_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 678
___ref______nl__1 = new ImmRef(___nl__1);
___nl__4 = translator_NL.NL_get_sim_label_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 680
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_sim_label_priv(___nl__4,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 682
___ref______nl__1 = new ImmRef(___nl__1);
___nl__5 = translator_NL.NL_save_loop_break_priv(___ref______nl__1,___nl__3,___nl__4).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 683
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_cmd_priv(___nl__0,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 684
___nl__6 = ((ImmHash)___nl__0).getHashValue()["debug"].clone();
//line 684
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_start_new_instruction_priv(___nl__6,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 684
___nl__6 = null;
//line 685
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("goto"), ___nl__4).clone();
//line 685
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_priv(___ref______nl__1,___nl__6);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 685
___nl__6 = null;
//line 687
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_sim_label_priv(___nl__3,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 688
___nl__6 = ___nl__5.clone();
//line 688
((ImmHash)___nl__1).set("loop_label", ___nl__6);
//line 688
___nl__6 = null;
//line 689
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_restore_registers_priv(___nl__2,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 689
___nl__2 = null;
//line 689
___nl__3 = null;
//line 689
___nl__4 = null;
//line 689
___nl__5 = null;
//line 689
___nl__0 = null;
//line 689
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_print_rep_priv(Imm ___arg__0, ImmRef ___arg__1) {
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
//line 693
___ref______nl__1 = new ImmRef(___nl__1);
___nl__2 = translator_NL.NL_save_registers_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 695
___ref______nl__1 = new ImmRef(___nl__1);
___nl__3 = translator_NL.NL_get_sim_label_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 696
___ref______nl__1 = new ImmRef(___nl__1);
___nl__4 = translator_NL.NL_get_sim_label_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 697
___ref______nl__1 = new ImmRef(___nl__1);
___nl__5 = translator_NL.NL_get_sim_label_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 699
___nl__7 = ((ImmHash)___nl__0).getHashValue()["count"].clone();
//line 699
___ref______nl__1 = new ImmRef(___nl__1);
___nl__6 = translator_NL.NL_calc_val_priv(___nl__7,___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 699
___nl__7 = null;
//line 701
___nl__8 = ((ImmHash)___nl__0).getHashValue()["iter"].clone();
//line 701
___ref______nl__1 = new ImmRef(___nl__1);
___nl__7 = translator_NL.NL_print_var_decl_priv(___nl__8,___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 701
___nl__8 = null;
//line 702
___nl__8 = new ImmDouble(0).clone();
//line 702
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_load_const_priv(___nl__8,___nl__7,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 702
___nl__8 = null;
//line 703
___ref______nl__1 = new ImmRef(___nl__1);
___nl__8 = translator_NL.NL_new_register_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 704
___nl__9 = new ImmDouble(1).clone();
//line 704
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_load_const_priv(___nl__9,___nl__8,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 704
___nl__9 = null;
//line 706
___ref______nl__1 = new ImmRef(___nl__1);
___nl__9 = translator_NL.NL_new_register_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 708
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_sim_label_priv(___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 709
___nl__10 = new ImmString(">=").clone();
//line 709
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_bin_op_operator_command_priv(___nl__9,___nl__7,___nl__6,___nl__10,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 709
___nl__10 = null;
//line 710
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_if_goto_priv(___nl__3,___nl__9,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 712
___ref______nl__1 = new ImmRef(___nl__1);
___nl__10 = translator_NL.NL_save_loop_break_priv(___ref______nl__1,___nl__3,___nl__4).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 713
___nl__11 = ((ImmHash)___nl__0).getHashValue()["cmd"].clone();
//line 713
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_cmd_priv(___nl__11,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 713
___nl__11 = null;
//line 715
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_sim_label_priv(___nl__4,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 716
___nl__11 = ((ImmHash)___nl__0).getHashValue()["short"].clone();
//line 716
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 716
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 716
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_2;}}
//line 716
___nl__13 = ((ImmHash)___nl__0).getHashValue()["cmd"].clone();
//line 716
___nl__13 = ((ImmHash)___nl__13).getHashValue()["debug"].clone();
//line 716
___nl__12 = translator_NL.NL_last_debug_char(___nl__13).clone();

//line 716
___nl__13 = null;
//line 716
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_start_new_instruction_priv(___nl__12,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 716
___nl__12 = null;
//line 716
if (true) {goto label_2;}
//line 716
label_2:
//line 716
___nl__11 = null;
//line 717
___nl__12 = new ImmString("+").clone();
//line 717
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__7);
__function_map.Add("left",___nl__7);
__function_map.Add("right",___nl__8);
__function_map.Add("op",___nl__12);
___nl__11 = new ImmHash(__function_map).clone();
//line 717
___nl__12 = null;
//line 717
___nl__11 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("bin_op"), ___nl__11).clone();
//line 717
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_priv(___ref______nl__1,___nl__11);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 717
___nl__11 = null;
//line 724
___nl__11 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("goto"), ___nl__5).clone();
//line 724
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_priv(___ref______nl__1,___nl__11);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 724
___nl__11 = null;
//line 725
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_sim_label_priv(___nl__3,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 727
___nl__11 = ___nl__10.clone();
//line 727
((ImmHash)___nl__1).set("loop_label", ___nl__11);
//line 727
___nl__11 = null;
//line 728
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_restore_registers_priv(___nl__2,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 728
___nl__2 = null;
//line 728
___nl__3 = null;
//line 728
___nl__4 = null;
//line 728
___nl__5 = null;
//line 728
___nl__6 = null;
//line 728
___nl__7 = null;
//line 728
___nl__8 = null;
//line 728
___nl__9 = null;
//line 728
___nl__10 = null;
//line 728
___nl__0 = null;
//line 728
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_print_forh_priv(Imm ___arg__0, ImmRef ___arg__1) {
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
//line 732
___nl__2 = ((ImmHash)___nl__1).getHashValue()["debug"].clone();
//line 732
___nl__2 = ((ImmHash)___nl__2).getHashValue()["nast_debug"].clone();
//line 733
___ref______nl__1 = new ImmRef(___nl__1);
___nl__3 = translator_NL.NL_save_registers_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 735
___ref______nl__1 = new ImmRef(___nl__1);
___nl__4 = translator_NL.NL_get_sim_label_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 736
___ref______nl__1 = new ImmRef(___nl__1);
___nl__5 = translator_NL.NL_get_sim_label_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 737
___ref______nl__1 = new ImmRef(___nl__1);
___nl__6 = translator_NL.NL_get_sim_label_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 739
___nl__8 = ((ImmHash)___nl__0).getHashValue()["hash"].clone();
//line 739
___ref______nl__1 = new ImmRef(___nl__1);
___nl__7 = translator_NL.NL_calc_val_priv(___nl__8,___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 739
___nl__8 = null;
//line 741
___nl__9 = ((ImmHash)___nl__0).getHashValue()["key"].clone();
//line 741
___ref______nl__1 = new ImmRef(___nl__1);
___nl__8 = translator_NL.NL_print_var_decl_priv(___nl__9,___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 741
___nl__9 = null;
//line 742
___nl__10 = ((ImmHash)___nl__0).getHashValue()["val"].clone();
//line 742
___ref______nl__1 = new ImmRef(___nl__1);
___nl__9 = translator_NL.NL_print_var_decl_priv(___nl__10,___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 742
___nl__10 = null;
//line 744
___ref______nl__1 = new ImmRef(___nl__1);
___nl__10 = translator_NL.NL_new_register_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 745
___nl__11 = new ImmString("init_iter").clone();
//line 745
___nl__13 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("val"), ___nl__7).clone();
//line 745
___nl__12 = new ImmArray(new Imm[] {___nl__13,}).clone();
//line 745
___nl__13 = null;
//line 745
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_call_base_priv(___nl__10,___nl__11,___nl__12,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 745
___nl__12 = null;
//line 745
___nl__11 = null;
//line 747
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_sim_label_priv(___nl__6,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 748
___nl__11 = new ImmString("is_end_hash").clone();
//line 748
___nl__13 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("val"), ___nl__10).clone();
//line 748
___nl__12 = new ImmArray(new Imm[] {___nl__13,}).clone();
//line 748
___nl__13 = null;
//line 748
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_call_base_priv(___nl__8,___nl__11,___nl__12,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 748
___nl__12 = null;
//line 748
___nl__11 = null;
//line 749
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_if_goto_priv(___nl__4,___nl__8,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 751
___nl__11 = new ImmString("get_key_iter").clone();
//line 751
___nl__13 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("val"), ___nl__10).clone();
//line 751
___nl__12 = new ImmArray(new Imm[] {___nl__13,}).clone();
//line 751
___nl__13 = null;
//line 751
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_call_base_priv(___nl__8,___nl__11,___nl__12,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 751
___nl__12 = null;
//line 751
___nl__11 = null;
//line 752
___nl__11 = new ImmString("hash_get_value").clone();
//line 752
___nl__13 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("val"), ___nl__7).clone();
//line 752
___nl__14 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("val"), ___nl__8).clone();
//line 752
___nl__12 = new ImmArray(new Imm[] {___nl__13,___nl__14,}).clone();
//line 752
___nl__13 = null;
//line 752
___nl__14 = null;
//line 752
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_call_base_priv(___nl__9,___nl__11,___nl__12,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 752
___nl__12 = null;
//line 752
___nl__11 = null;
//line 754
___ref______nl__1 = new ImmRef(___nl__1);
___nl__11 = translator_NL.NL_save_loop_break_priv(___ref______nl__1,___nl__4,___nl__5).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 755
___nl__12 = ((ImmHash)___nl__0).getHashValue()["cmd"].clone();
//line 755
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_cmd_priv(___nl__12,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 755
___nl__12 = null;
//line 757
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_sim_label_priv(___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 758
___nl__12 = ((ImmHash)___nl__0).getHashValue()["short"].clone();
//line 758
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 758
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 758
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_2;}}
//line 758
___nl__13 = translator_NL.NL_last_debug_char(___nl__2).clone();

//line 758
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_start_new_instruction_priv(___nl__13,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 758
___nl__13 = null;
//line 758
if (true) {goto label_2;}
//line 758
label_2:
//line 758
___nl__12 = null;
//line 759
___nl__12 = new ImmString("next_iter").clone();
//line 759
___nl__14 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("val"), ___nl__10).clone();
//line 759
___nl__13 = new ImmArray(new Imm[] {___nl__14,}).clone();
//line 759
___nl__14 = null;
//line 759
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_call_base_priv(___nl__10,___nl__12,___nl__13,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 759
___nl__13 = null;
//line 759
___nl__12 = null;
//line 760
___nl__12 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("goto"), ___nl__6).clone();
//line 760
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_priv(___ref______nl__1,___nl__12);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 760
___nl__12 = null;
//line 762
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_sim_label_priv(___nl__4,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 764
___nl__12 = ___nl__11.clone();
//line 764
((ImmHash)___nl__1).set("loop_label", ___nl__12);
//line 764
___nl__12 = null;
//line 765
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_restore_registers_priv(___nl__3,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 765
___nl__2 = null;
//line 765
___nl__3 = null;
//line 765
___nl__4 = null;
//line 765
___nl__5 = null;
//line 765
___nl__6 = null;
//line 765
___nl__7 = null;
//line 765
___nl__8 = null;
//line 765
___nl__9 = null;
//line 765
___nl__10 = null;
//line 765
___nl__11 = null;
//line 765
___nl__0 = null;
//line 765
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_print_while_priv(Imm ___arg__0, ImmRef ___arg__1) {
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
//line 769
___ref______nl__1 = new ImmRef(___nl__1);
___nl__2 = translator_NL.NL_save_registers_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 771
___ref______nl__1 = new ImmRef(___nl__1);
___nl__3 = translator_NL.NL_get_sim_label_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 772
___ref______nl__1 = new ImmRef(___nl__1);
___nl__4 = translator_NL.NL_get_sim_label_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 774
___nl__5 = ((ImmHash)___nl__1).getHashValue()["debug"].clone();
//line 774
___nl__5 = ((ImmHash)___nl__5).getHashValue()["nast_debug"].clone();
//line 775
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_sim_label_priv(___nl__4,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 776
___nl__7 = ((ImmHash)___nl__0).getHashValue()["cond"].clone();
//line 776
___ref______nl__1 = new ImmRef(___nl__1);
___nl__6 = translator_NL.NL_calc_val_priv(___nl__7,___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 776
___nl__7 = null;
//line 777
___nl__8 = new ImmString("!").clone();
//line 777
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__6);
__function_map.Add("src",___nl__6);
__function_map.Add("op",___nl__8);
___nl__7 = new ImmHash(__function_map).clone();
//line 777
___nl__8 = null;
//line 777
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("una_op"), ___nl__7).clone();
//line 777
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_priv(___ref______nl__1,___nl__7);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 777
___nl__7 = null;
//line 784
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_if_goto_priv(___nl__3,___nl__6,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 786
___ref______nl__1 = new ImmRef(___nl__1);
___nl__7 = translator_NL.NL_save_loop_break_priv(___ref______nl__1,___nl__3,___nl__4).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 787
___nl__8 = ((ImmHash)___nl__0).getHashValue()["cmd"].clone();
//line 787
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_cmd_priv(___nl__8,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 787
___nl__8 = null;
//line 788
___nl__8 = ((ImmHash)___nl__0).getHashValue()["short"].clone();
//line 788
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 788
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 788
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_2;}}
//line 788
___nl__9 = translator_NL.NL_last_debug_char(___nl__5).clone();

//line 788
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_start_new_instruction_priv(___nl__9,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 788
___nl__9 = null;
//line 788
if (true) {goto label_2;}
//line 788
label_2:
//line 788
___nl__8 = null;
//line 789
___nl__8 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("goto"), ___nl__4).clone();
//line 789
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_priv(___ref______nl__1,___nl__8);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 789
___nl__8 = null;
//line 790
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_sim_label_priv(___nl__3,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 792
___nl__8 = ___nl__7.clone();
//line 792
((ImmHash)___nl__1).set("loop_label", ___nl__8);
//line 792
___nl__8 = null;
//line 793
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_restore_registers_priv(___nl__2,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 793
___nl__2 = null;
//line 793
___nl__3 = null;
//line 793
___nl__4 = null;
//line 793
___nl__5 = null;
//line 793
___nl__6 = null;
//line 793
___nl__7 = null;
//line 793
___nl__0 = null;
//line 793
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_print_for_priv(Imm ___arg__0, ImmRef ___arg__1) {
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
//line 797
___ref______nl__1 = new ImmRef(___nl__1);
___nl__2 = translator_NL.NL_save_registers_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 799
___ref______nl__1 = new ImmRef(___nl__1);
___nl__3 = translator_NL.NL_get_sim_label_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 800
___ref______nl__1 = new ImmRef(___nl__1);
___nl__4 = translator_NL.NL_get_sim_label_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 801
___ref______nl__1 = new ImmRef(___nl__1);
___nl__5 = translator_NL.NL_get_sim_label_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 803
___nl__6 = ((ImmHash)___nl__0).getHashValue()["start"].clone();
//line 803
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("value")).clone();
//line 803
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_2;}}
//line 805
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("var_decl")).clone();
//line 805
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_3;}}
//line 805
___nl__7 = new ImmString("NOMATCHALERT").clone();
//line 805
___nl__7 = new ImmArray(new Imm[] {___nl__7,___nl__6,}).clone();
//line 805
c_rt_lib_NL.NL_die();
//line 803
label_2:
//line 803
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("value")).clone();
//line 804
___nl__9 = new ImmString("").clone();
//line 804
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_val_priv(___nl__8,___nl__9,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 804
___nl__9 = null;
//line 804
___nl__8 = null;
//line 805
if (true) {goto label_1;}
//line 805
label_3:
//line 805
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("var_decl")).clone();
//line 806
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_var_decl_priv(___nl__8,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 806
___nl__8 = null;
//line 807
if (true) {goto label_1;}
//line 807
label_1:
//line 807
___nl__6 = null;
//line 807
___nl__7 = null;
//line 809
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_sim_label_priv(___nl__4,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 810
___nl__6 = ((ImmHash)___nl__0).getHashValue()["cond"].clone();
//line 810
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("nop")).clone();
//line 810
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 810
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 810
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_5;}}
//line 811
___nl__8 = ((ImmHash)___nl__0).getHashValue()["cond"].clone();
//line 811
___ref______nl__1 = new ImmRef(___nl__1);
___nl__7 = translator_NL.NL_calc_val_priv(___nl__8,___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 811
___nl__8 = null;
//line 812
___nl__9 = new ImmString("!").clone();
//line 812
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__7);
__function_map.Add("src",___nl__7);
__function_map.Add("op",___nl__9);
___nl__8 = new ImmHash(__function_map).clone();
//line 812
___nl__9 = null;
//line 812
___nl__8 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("una_op"), ___nl__8).clone();
//line 812
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_priv(___ref______nl__1,___nl__8);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 812
___nl__8 = null;
//line 819
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_if_goto_priv(___nl__3,___nl__7,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 819
___nl__7 = null;
//line 820
if (true) {goto label_5;}
//line 820
label_5:
//line 820
___nl__6 = null;
//line 821
___ref______nl__1 = new ImmRef(___nl__1);
___nl__6 = translator_NL.NL_save_loop_break_priv(___ref______nl__1,___nl__3,___nl__5).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 822
___nl__7 = ((ImmHash)___nl__0).getHashValue()["cmd"].clone();
//line 822
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_cmd_priv(___nl__7,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 822
___nl__7 = null;
//line 824
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_sim_label_priv(___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 825
___nl__7 = ((ImmHash)___nl__0).getHashValue()["iter"].clone();
//line 825
___nl__8 = new ImmString("").clone();
//line 825
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_val_priv(___nl__7,___nl__8,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 825
___nl__8 = null;
//line 825
___nl__7 = null;
//line 826
___nl__8 = ((ImmHash)___nl__0).getHashValue()["cmd"].clone();
//line 826
___nl__8 = ((ImmHash)___nl__8).getHashValue()["debug"].clone();
//line 826
___nl__7 = translator_NL.NL_last_debug_char(___nl__8).clone();

//line 826
___nl__8 = null;
//line 826
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_start_new_instruction_priv(___nl__7,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 826
___nl__7 = null;
//line 827
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("goto"), ___nl__4).clone();
//line 827
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_priv(___ref______nl__1,___nl__7);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 827
___nl__7 = null;
//line 829
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_sim_label_priv(___nl__3,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 831
___nl__7 = ___nl__6.clone();
//line 831
((ImmHash)___nl__1).set("loop_label", ___nl__7);
//line 831
___nl__7 = null;
//line 832
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_restore_registers_priv(___nl__2,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 832
___nl__2 = null;
//line 832
___nl__3 = null;
//line 832
___nl__4 = null;
//line 832
___nl__5 = null;
//line 832
___nl__6 = null;
//line 832
___nl__0 = null;
//line 832
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_print_match_priv(Imm ___arg__0, ImmRef ___arg__1) {
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
Dictionary<String, Imm> __function_map;
//line 836
___ref______nl__1 = new ImmRef(___nl__1);
___nl__2 = translator_NL.NL_save_registers_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 838
___nl__3 = new ImmArray(new Imm[0]).clone();
//line 839
___nl__5 = ((ImmHash)___nl__0).getHashValue()["val"].clone();
//line 839
___ref______nl__1 = new ImmRef(___nl__1);
___nl__4 = translator_NL.NL_calc_val_priv(___nl__5,___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 839
___nl__5 = null;
//line 840
___ref______nl__1 = new ImmRef(___nl__1);
___nl__5 = translator_NL.NL_new_register_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 841
___ref______nl__1 = new ImmRef(___nl__1);
___nl__6 = translator_NL.NL_get_sim_label_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 842
___nl__7 = ((ImmHash)___nl__0).getHashValue()["branch_list"].clone();
//line 842
___nl__9 = new ImmDouble(0).clone();
//line 842
___nl__10 = new ImmDouble(1).clone();
//line 842
___nl__11 = c_rt_lib_NL.NL_array_len(___nl__7).clone();

//line 842
label_3:
//line 842
___nl__12 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__9.getValue().ToString()))>=(Double.Parse(___nl__11.getValue().ToString())) ).clone();
//line 842
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_1;}}
//line 842
___nl__8 = (___nl__7 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()].clone();
//line 843
___nl__13 = ((ImmHash)___nl__8).getHashValue()["debug"].clone();
//line 843
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_start_new_instruction_priv(___nl__13,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 843
___nl__13 = null;
//line 844
___nl__14 = ((ImmHash)___nl__8).getHashValue()["variant"].clone();
//line 844
___nl__14 = ((ImmHash)___nl__14).getHashValue()["name"].clone();
//line 844
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__5);
__function_map.Add("src",___nl__4);
__function_map.Add("type",___nl__14);
___nl__13 = new ImmHash(__function_map).clone();
//line 844
___nl__14 = null;
//line 844
___nl__13 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ov_is"), ___nl__13).clone();
//line 844
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_priv(___ref______nl__1,___nl__13);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 844
___nl__13 = null;
//line 850
___ref______nl__1 = new ImmRef(___nl__1);
___nl__13 = translator_NL.NL_get_sim_label_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 851
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_if_goto_priv(___nl__13,___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 852
___ref______nl__3 = new ImmRef(___nl__3);
array_NL.NL_push(___ref______nl__3,___nl__13);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 852
___nl__13 = null;
//line 853
___nl__9 = new ImmDouble((Double.Parse(___nl__9.getValue().ToString()))+(Double.Parse(___nl__10.getValue().ToString()))).clone();
//line 853
if (true) {goto label_3;}
//line 853
label_1:
//line 853
___nl__7 = null;
//line 853
___nl__8 = null;
//line 853
___nl__9 = null;
//line 853
___nl__10 = null;
//line 853
___nl__11 = null;
//line 853
___nl__12 = null;
//line 854
___nl__7 = new ImmString("NOMATCHALERT").clone();
//line 854
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_load_const_priv(___nl__7,___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 854
___nl__7 = null;
//line 855
___nl__8 = new ImmArray(new Imm[] {___nl__5,___nl__4,}).clone();
//line 855
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__5);
__function_map.Add("src",___nl__8);
___nl__7 = new ImmHash(__function_map).clone();
//line 855
___nl__8 = null;
//line 855
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("arr_decl"), ___nl__7).clone();
//line 855
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_priv(___ref______nl__1,___nl__7);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 855
___nl__7 = null;
//line 860
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("die"), ___nl__5).clone();
//line 860
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_priv(___ref______nl__1,___nl__7);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 860
___nl__7 = null;
//line 861
___nl__7 = new ImmDouble(0).clone();
//line 862
___nl__8 = ((ImmHash)___nl__0).getHashValue()["branch_list"].clone();
//line 862
___nl__10 = new ImmDouble(0).clone();
//line 862
___nl__11 = new ImmDouble(1).clone();
//line 862
___nl__12 = c_rt_lib_NL.NL_array_len(___nl__8).clone();

//line 862
label_6:
//line 862
___nl__13 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__10.getValue().ToString()))>=(Double.Parse(___nl__12.getValue().ToString())) ).clone();
//line 862
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_4;}}
//line 862
___nl__9 = (___nl__8 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()].clone();
//line 863
___nl__14 = ((ImmHash)___nl__9).getHashValue()["cmd"].clone();
//line 863
___nl__14 = ((ImmHash)___nl__14).getHashValue()["debug"].clone();
//line 863
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_start_new_instruction_priv(___nl__14,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 863
___nl__14 = null;
//line 864
___nl__14 = (___nl__3 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()].clone();
//line 864
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_sim_label_priv(___nl__14,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 864
___nl__14 = null;
//line 865
___ref______nl__1 = new ImmRef(___nl__1);
___nl__14 = translator_NL.NL_save_registers_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 866
___nl__15 = ((ImmHash)___nl__9).getHashValue()["variant"].clone();
//line 866
___nl__15 = ((ImmHash)___nl__15).getHashValue()["value"].clone();
//line 866
___nl__16 = c_rt_lib_NL.NL_ov_is(___nl__15, new ImmString("value")).clone();
//line 866
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_8;}}
//line 874
___nl__16 = c_rt_lib_NL.NL_ov_is(___nl__15, new ImmString("none")).clone();
//line 874
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_9;}}
//line 874
___nl__16 = new ImmString("NOMATCHALERT").clone();
//line 874
___nl__16 = new ImmArray(new Imm[] {___nl__16,___nl__15,}).clone();
//line 874
c_rt_lib_NL.NL_die();
//line 866
label_8:
//line 866
___nl__17 = c_rt_lib_NL.NL_ov_as(___nl__15, new ImmString("value")).clone();
//line 867
___ref______nl__1 = new ImmRef(___nl__1);
___nl__18 = translator_NL.NL_print_var_decl_priv(___nl__17,___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 868
___nl__20 = ((ImmHash)___nl__9).getHashValue()["variant"].clone();
//line 868
___nl__20 = ((ImmHash)___nl__20).getHashValue()["name"].clone();
//line 868
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__18);
__function_map.Add("src",___nl__4);
__function_map.Add("type",___nl__20);
___nl__19 = new ImmHash(__function_map).clone();
//line 868
___nl__20 = null;
//line 868
___nl__19 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ov_as"), ___nl__19).clone();
//line 868
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_priv(___ref______nl__1,___nl__19);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 868
___nl__19 = null;
//line 868
___nl__18 = null;
//line 868
___nl__17 = null;
//line 874
if (true) {goto label_7;}
//line 874
label_9:
//line 875
if (true) {goto label_7;}
//line 875
label_7:
//line 875
___nl__15 = null;
//line 875
___nl__16 = null;
//line 876
___nl__15 = ((ImmHash)___nl__9).getHashValue()["cmd"].clone();
//line 876
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_cmd_priv(___nl__15,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 876
___nl__15 = null;
//line 877
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_restore_registers_priv(___nl__14,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 878
___nl__16 = ((ImmHash)___nl__9).getHashValue()["cmd"].clone();
//line 878
___nl__16 = ((ImmHash)___nl__16).getHashValue()["debug"].clone();
//line 878
___nl__15 = translator_NL.NL_last_debug_char(___nl__16).clone();

//line 878
___nl__16 = null;
//line 878
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_start_new_instruction_priv(___nl__15,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 878
___nl__15 = null;
//line 879
___nl__15 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("goto"), ___nl__6).clone();
//line 879
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_priv(___ref______nl__1,___nl__15);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 879
___nl__15 = null;
//line 880
___nl__15 = new ImmDouble(1).clone();
//line 880
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))+(Double.Parse(___nl__15.getValue().ToString()))).clone();
//line 880
___nl__15 = null;
//line 880
___nl__14 = null;
//line 881
___nl__10 = new ImmDouble((Double.Parse(___nl__10.getValue().ToString()))+(Double.Parse(___nl__11.getValue().ToString()))).clone();
//line 881
if (true) {goto label_6;}
//line 881
label_4:
//line 881
___nl__8 = null;
//line 881
___nl__9 = null;
//line 881
___nl__10 = null;
//line 881
___nl__11 = null;
//line 881
___nl__12 = null;
//line 881
___nl__13 = null;
//line 882
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_sim_label_priv(___nl__6,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 883
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_restore_registers_priv(___nl__2,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 883
___nl__2 = null;
//line 883
___nl__3 = null;
//line 883
___nl__4 = null;
//line 883
___nl__5 = null;
//line 883
___nl__6 = null;
//line 883
___nl__7 = null;
//line 883
___nl__0 = null;
//line 883
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_move_priv(Imm ___arg__0, Imm ___arg__1, ImmRef ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.getValue().clone();
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 888
___nl__3 = new ImmString("").clone();
//line 888
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__3.toString())).clone();
//line 888
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 888
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 888
___nl__0 = null;
//line 888
___nl__1 = null;
//line 888
___nl__3 = null;
//line 888
___arg__2.setValue(___nl__2);if(true) return null;
//line 888
if (true) {goto label_2;}
//line 888
label_2:
//line 888
___nl__3 = null;
//line 889
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__0);
__function_map.Add("src",___nl__1);
___nl__3 = new ImmHash(__function_map).clone();
//line 889
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("move"), ___nl__3).clone();
//line 889
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_priv(___ref______nl__2,___nl__3);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 889
___nl__3 = null;
//line 889
___nl__0 = null;
//line 889
___nl__1 = null;
//line 889
___arg__2.setValue(___nl__2);if(true) return null;
}

private static Imm NL_print_bin_op_operator_command_priv(Imm ___arg__0, Imm ___arg__1, Imm ___arg__2, Imm ___arg__3, ImmRef ___arg__4) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();Imm ___nl__3 = ___arg__3.clone();Imm ___nl__4 = ___arg__4.getValue().clone();
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
//line 899
___nl__5 = new ImmString("+").clone();
//line 899
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__5.toString())).clone();
//line 899
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_3;}}
//line 899
___nl__5 = new ImmString("+=").clone();
//line 899
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__5.toString())).clone();
//line 899
label_3:
//line 899
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 899
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_2;}}
//line 900
___nl__6 = new ImmString("+").clone();
//line 900
___nl__3 = ___nl__6.clone();
//line 900
___nl__6 = null;
//line 901
if (true) {goto label_10;}
//line 901
label_2:
//line 901
___nl__5 = new ImmString("-").clone();
//line 901
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__5.toString())).clone();
//line 901
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_5;}}
//line 901
___nl__5 = new ImmString("-=").clone();
//line 901
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__5.toString())).clone();
//line 901
label_5:
//line 901
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 901
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_4;}}
//line 902
___nl__6 = new ImmString("-").clone();
//line 902
___nl__3 = ___nl__6.clone();
//line 902
___nl__6 = null;
//line 903
if (true) {goto label_10;}
//line 903
label_4:
//line 903
___nl__5 = new ImmString("*").clone();
//line 903
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__5.toString())).clone();
//line 903
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_7;}}
//line 903
___nl__5 = new ImmString("*=").clone();
//line 903
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__5.toString())).clone();
//line 903
label_7:
//line 903
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 903
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_6;}}
//line 904
___nl__6 = new ImmString("*").clone();
//line 904
___nl__3 = ___nl__6.clone();
//line 904
___nl__6 = null;
//line 905
if (true) {goto label_10;}
//line 905
label_6:
//line 905
___nl__5 = new ImmString("/").clone();
//line 905
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__5.toString())).clone();
//line 905
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_9;}}
//line 905
___nl__5 = new ImmString("/=").clone();
//line 905
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__5.toString())).clone();
//line 905
label_9:
//line 905
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 905
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_8;}}
//line 906
___nl__6 = new ImmString("/").clone();
//line 906
___nl__3 = ___nl__6.clone();
//line 906
___nl__6 = null;
//line 907
if (true) {goto label_10;}
//line 907
label_8:
//line 907
___nl__5 = new ImmString(".").clone();
//line 907
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__5.toString())).clone();
//line 907
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_11;}}
//line 907
___nl__5 = new ImmString(".=").clone();
//line 907
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__5.toString())).clone();
//line 907
label_11:
//line 907
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 907
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_10;}}
//line 908
___nl__6 = new ImmString(".").clone();
//line 908
___nl__3 = ___nl__6.clone();
//line 908
___nl__6 = null;
//line 909
if (true) {goto label_10;}
//line 909
label_10:
//line 909
___nl__5 = null;
//line 910
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__0);
__function_map.Add("left",___nl__1);
__function_map.Add("right",___nl__2);
__function_map.Add("op",___nl__3);
___nl__5 = new ImmHash(__function_map).clone();
//line 910
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("bin_op"), ___nl__5).clone();
//line 910
___ref______nl__4 = new ImmRef(___nl__4);
translator_NL.NL_print_priv(___ref______nl__4,___nl__5);
___nl__4 = ___ref______nl__4.getValue().clone();

//line 910
___nl__5 = null;
//line 910
___nl__0 = null;
//line 910
___nl__1 = null;
//line 910
___nl__2 = null;
//line 910
___nl__3 = null;
//line 910
___arg__4.setValue(___nl__4);if(true) return null;
}

private static Imm NL_print_priv(ImmRef ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.clone();
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
//line 920
___nl__3 = ((ImmHash)___nl__0).getHashValue()["debug"].clone();
//line 920
___nl__4 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 920
__function_map = new Dictionary<String, Imm>();
__function_map.Add("cmd",___nl__1);
__function_map.Add("debug",___nl__3);
__function_map.Add("annotation",___nl__4);
___nl__2 = new ImmHash(__function_map).clone();
//line 920
___nl__3 = null;
//line 920
___nl__4 = null;
//line 921
___nl__3 = new ImmString("result").clone();
//line 921
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__3).clone();

//line 921
___nl__4 = new ImmString("commands").clone();
//line 921
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__3,___nl__4).clone();

//line 921
___ref______nl__4 = new ImmRef(___nl__4);
array_NL.NL_push(___ref______nl__4,___nl__2);
___nl__4 = ___ref______nl__4.getValue().clone();

//line 921
___nl__5 = new ImmString("commands").clone();
//line 921
___ref______nl__3 = new ImmRef(___nl__3);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__3,___nl__5,___nl__4);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 921
___nl__5 = new ImmString("result").clone();
//line 921
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__3);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 921
___nl__5 = null;
//line 921
___nl__3 = null;
//line 921
___nl__4 = null;
//line 922
__function_map = new Dictionary<String, Imm>();
___nl__3 = new ImmHash(__function_map).clone();
//line 922
___nl__4 = new ImmString("debug").clone();
//line 922
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__4).clone();

//line 922
___nl__5 = ___nl__3.clone();
//line 922
((ImmHash)___nl__4).set("declarations", ___nl__5);
//line 922
___nl__6 = new ImmString("debug").clone();
//line 922
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__6,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 922
___nl__6 = null;
//line 922
___nl__3 = null;
//line 922
___nl__4 = null;
//line 922
___nl__5 = null;
//line 922
___nl__2 = null;
//line 922
___nl__1 = null;
//line 922
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_print_if_goto_priv(Imm ___arg__0, Imm ___arg__1, ImmRef ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.getValue().clone();
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 926
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__0);
__function_map.Add("src",___nl__1);
___nl__3 = new ImmHash(__function_map).clone();
//line 926
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("if_goto"), ___nl__3).clone();
//line 926
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_priv(___ref______nl__2,___nl__3);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 926
___nl__3 = null;
//line 926
___nl__0 = null;
//line 926
___nl__1 = null;
//line 926
___arg__2.setValue(___nl__2);if(true) return null;
}

private static Imm NL_print_get_from_index_priv(Imm ___arg__0, Imm ___arg__1, Imm ___arg__2, ImmRef ___arg__3) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();Imm ___nl__3 = ___arg__3.getValue().clone();
Imm ___nl__4 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 936
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__0);
__function_map.Add("src",___nl__1);
__function_map.Add("idx",___nl__2);
___nl__4 = new ImmHash(__function_map).clone();
//line 936
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("get_frm_idx"), ___nl__4).clone();
//line 936
___ref______nl__3 = new ImmRef(___nl__3);
translator_NL.NL_print_priv(___ref______nl__3,___nl__4);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 936
___nl__4 = null;
//line 936
___nl__0 = null;
//line 936
___nl__1 = null;
//line 936
___nl__2 = null;
//line 936
___arg__3.setValue(___nl__3);if(true) return null;
}

private static Imm NL_print_set_at_index_priv(Imm ___arg__0, Imm ___arg__1, Imm ___arg__2, ImmRef ___arg__3) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();Imm ___nl__3 = ___arg__3.getValue().clone();
Imm ___nl__4 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 948
__function_map = new Dictionary<String, Imm>();
__function_map.Add("src",___nl__0);
__function_map.Add("idx",___nl__1);
__function_map.Add("val",___nl__2);
___nl__4 = new ImmHash(__function_map).clone();
//line 948
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("set_at_idx"), ___nl__4).clone();
//line 948
___ref______nl__3 = new ImmRef(___nl__3);
translator_NL.NL_print_priv(___ref______nl__3,___nl__4);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 948
___nl__4 = null;
//line 948
___nl__0 = null;
//line 948
___nl__1 = null;
//line 948
___nl__2 = null;
//line 948
___arg__3.setValue(___nl__3);if(true) return null;
}

private static Imm NL_print_get_value_priv(Imm ___arg__0, Imm ___arg__1, Imm ___arg__2, ImmRef ___arg__3) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();Imm ___nl__3 = ___arg__3.getValue().clone();
Imm ___nl__4 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 959
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dest",___nl__0);
__function_map.Add("src",___nl__1);
__function_map.Add("key",___nl__2);
___nl__4 = new ImmHash(__function_map).clone();
//line 959
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("get_val"), ___nl__4).clone();
//line 959
___ref______nl__3 = new ImmRef(___nl__3);
translator_NL.NL_print_priv(___ref______nl__3,___nl__4);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 959
___nl__4 = null;
//line 959
___nl__0 = null;
//line 959
___nl__1 = null;
//line 959
___nl__2 = null;
//line 959
___arg__3.setValue(___nl__3);if(true) return null;
}

private static Imm NL_print_set_value_priv(Imm ___arg__0, Imm ___arg__1, Imm ___arg__2, ImmRef ___arg__3) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();Imm ___nl__3 = ___arg__3.getValue().clone();
Imm ___nl__4 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 969
__function_map = new Dictionary<String, Imm>();
__function_map.Add("src",___nl__0);
__function_map.Add("key",___nl__1);
__function_map.Add("val",___nl__2);
___nl__4 = new ImmHash(__function_map).clone();
//line 969
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("set_val"), ___nl__4).clone();
//line 969
___ref______nl__3 = new ImmRef(___nl__3);
translator_NL.NL_print_priv(___ref______nl__3,___nl__4);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 969
___nl__4 = null;
//line 969
___nl__0 = null;
//line 969
___nl__1 = null;
//line 969
___nl__2 = null;
//line 969
___arg__3.setValue(___nl__3);if(true) return null;
}

private static Imm NL_get_stuct_of_lvalue_priv(ImmRef ___arg__0) {
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
//line 977
___nl__1 = new ImmArray(new Imm[0]).clone();
//line 978
label_2:
//line 978
___nl__3 = new ImmString("bin_op").clone();
//line 978
___nl__2 = ov_NL.NL_is(___nl__0,___nl__3).clone();

//line 978
___nl__3 = null;
//line 978
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 978
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_1;}}
//line 979
___nl__3 = ___nl__0.clone();
//line 979
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("bin_op")).clone();
//line 980
___nl__4 = ((ImmHash)___nl__3).getHashValue()["op"].clone();
//line 980
___nl__5 = new ImmString("ARRAY_INDEX").clone();
//line 980
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__4.toString().Equals(___nl__5.toString())).clone();
//line 980
___nl__5 = null;
//line 980
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_5;}}
//line 980
___nl__4 = ((ImmHash)___nl__3).getHashValue()["op"].clone();
//line 980
___nl__5 = new ImmString("->").clone();
//line 980
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__4.toString().Equals(___nl__5.toString())).clone();
//line 980
___nl__5 = null;
//line 980
label_5:
//line 980
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 980
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 980
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_4;}}
//line 980
___nl__5 = new ImmArray(new Imm[0]).clone();
//line 980
c_rt_lib_NL.NL_die();
//line 980
if (true) {goto label_4;}
//line 980
label_4:
//line 980
___nl__4 = null;
//line 980
___nl__5 = null;
//line 981
___nl__4 = new ImmArray(new Imm[0]).clone();
//line 982
___nl__5 = ((ImmHash)___nl__3).getHashValue()["op"].clone();
//line 982
___nl__6 = new ImmString("ARRAY_INDEX").clone();
//line 982
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__5.toString().Equals(___nl__6.toString())).clone();
//line 982
___nl__6 = null;
//line 982
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 982
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_7;}}
//line 983
___nl__7 = ((ImmHash)___nl__3).getHashValue()["right"].clone();
//line 983
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("index"), ___nl__7).clone();
//line 983
___nl__6 = new ImmArray(new Imm[] {___nl__7,}).clone();
//line 983
___nl__7 = null;
//line 983
___nl__4 = ___nl__6.clone();
//line 983
___nl__6 = null;
//line 984
if (true) {goto label_6;}
//line 984
label_7:
//line 985
___nl__7 = ((ImmHash)___nl__3).getHashValue()["right"].clone();
//line 985
___nl__7 = c_rt_lib_NL.NL_ov_as(___nl__7, new ImmString("hash_key")).clone();
//line 985
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("key"), ___nl__7).clone();
//line 985
___nl__6 = new ImmArray(new Imm[] {___nl__7,}).clone();
//line 985
___nl__7 = null;
//line 985
___nl__4 = ___nl__6.clone();
//line 985
___nl__6 = null;
//line 986
if (true) {goto label_6;}
//line 986
label_6:
//line 986
___nl__5 = null;
//line 987
___ref______nl__4 = new ImmRef(___nl__4);
array_NL.NL_append(___ref______nl__4,___nl__1);
___nl__4 = ___ref______nl__4.getValue().clone();

//line 988
___nl__1 = ___nl__4.clone();
//line 989
___nl__5 = ((ImmHash)___nl__3).getHashValue()["left"].clone();
//line 989
___nl__0 = ___nl__5.clone();
//line 989
___nl__5 = null;
//line 989
___nl__3 = null;
//line 989
___nl__4 = null;
//line 990
if (true) {goto label_2;}
//line 990
label_1:
//line 990
___nl__2 = null;
//line 991
___arg__0.setValue(___nl__0);if(true) return ___nl__1;
//line 991
___nl__1 = null;
//line 991
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_get_value_of_lvalue_priv(Imm ___arg__0, Imm ___arg__1, ImmRef ___arg__2) {
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
//line 995
___ref______nl__0 = new ImmRef(___nl__0);
___nl__3 = translator_NL.NL_get_stuct_of_lvalue_priv(___ref______nl__0).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 996
___nl__4 = ___nl__0.clone();
//line 996
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("var")).clone();
//line 997
___ref______nl__2 = new ImmRef(___nl__2);
___nl__6 = translator_NL.NL_get_var_register_priv(___nl__4,___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 997
___nl__5 = new ImmArray(new Imm[] {___nl__6,}).clone();
//line 997
___nl__6 = null;
//line 999
___nl__6 = new ImmArray(new Imm[0]).clone();
//line 1000
___nl__7 = array_NL.NL_len(___nl__3).clone();

//line 1000
___nl__8 = new ImmDouble(0).clone();
//line 1000
___nl__9 = new ImmDouble(1).clone();
//line 1000
label_3:
//line 1000
___nl__10 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) ).clone();
//line 1000
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_1;}}
//line 1001
___ref______nl__2 = new ImmRef(___nl__2);
___nl__11 = translator_NL.NL_new_register_priv(___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 1001
___ref______nl__5 = new ImmRef(___nl__5);
array_NL.NL_push(___ref______nl__5,___nl__11);
___nl__5 = ___ref______nl__5.getValue().clone();

//line 1001
___nl__11 = null;
//line 1002
___nl__11 = (___nl__3 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()].clone();
//line 1002
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("index")).clone();
//line 1002
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_5;}}
//line 1007
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("key")).clone();
//line 1007
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_6;}}
//line 1007
___nl__12 = new ImmString("NOMATCHALERT").clone();
//line 1007
___nl__12 = new ImmArray(new Imm[] {___nl__12,___nl__11,}).clone();
//line 1007
c_rt_lib_NL.NL_die();
//line 1002
label_5:
//line 1002
___nl__13 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("index")).clone();
//line 1003
___ref______nl__2 = new ImmRef(___nl__2);
___nl__14 = translator_NL.NL_calc_val_priv(___nl__13,___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 1004
___nl__16 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()].clone();
//line 1004
__function_map = new Dictionary<String, Imm>();
__function_map.Add("value",___nl__16);
__function_map.Add("index",___nl__14);
___nl__15 = new ImmHash(__function_map).clone();
//line 1004
___nl__16 = null;
//line 1004
___nl__15 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("index"), ___nl__15).clone();
//line 1004
___ref______nl__6 = new ImmRef(___nl__6);
array_NL.NL_push(___ref______nl__6,___nl__15);
___nl__6 = ___ref______nl__6.getValue().clone();

//line 1004
___nl__15 = null;
//line 1005
___nl__15 = new ImmDouble(0).clone();
//line 1005
___nl__15 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__1.getValue().ToString())) ==((Double.Parse(___nl__15.getValue().ToString())))  ).clone();
//line 1005
___nl__16 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__15)).clone();
//line 1005
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_9;}}
//line 1005
___nl__15 = array_NL.NL_len(___nl__3).clone();

//line 1005
___nl__17 = new ImmDouble(1).clone();
//line 1005
___nl__15 = new ImmDouble((Double.Parse(___nl__15.getValue().ToString()))-(Double.Parse(___nl__17.getValue().ToString()))).clone();
//line 1005
___nl__17 = null;
//line 1005
___nl__15 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString())) ==((Double.Parse(___nl__15.getValue().ToString())))  ).clone();
//line 1005
label_9:
//line 1005
___nl__16 = null;
//line 1005
___nl__15 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__15)).clone();
//line 1005
if (c_rt_lib_NL.NL_check_true_native(___nl__15)) {if (true) {goto label_8;}}
//line 1005
___nl__11 = null;
//line 1005
___nl__12 = null;
//line 1005
___nl__13 = null;
//line 1005
___nl__14 = null;
//line 1005
___nl__15 = null;
//line 1005
if (true) {goto label_1;}
//line 1005
if (true) {goto label_8;}
//line 1005
label_8:
//line 1005
___nl__15 = null;
//line 1006
___nl__16 = new ImmDouble(1).clone();
//line 1006
___nl__16 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))+(Double.Parse(___nl__16.getValue().ToString()))).clone();
//line 1006
___nl__15 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__16).getDoubleValue()].clone();
//line 1006
___nl__16 = null;
//line 1006
___nl__16 = new ImmString("get_ref_arr").clone();
//line 1006
___nl__18 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()].clone();
//line 1006
___nl__18 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("val"), ___nl__18).clone();
//line 1006
___nl__19 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("val"), ___nl__14).clone();
//line 1006
___nl__17 = new ImmArray(new Imm[] {___nl__18,___nl__19,}).clone();
//line 1006
___nl__18 = null;
//line 1006
___nl__19 = null;
//line 1006
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_call_base_priv(___nl__15,___nl__16,___nl__17,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 1006
___nl__17 = null;
//line 1006
___nl__16 = null;
//line 1006
___nl__15 = null;
//line 1006
___nl__14 = null;
//line 1006
___nl__13 = null;
//line 1007
if (true) {goto label_4;}
//line 1007
label_6:
//line 1007
___nl__13 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("key")).clone();
//line 1008
___nl__15 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()].clone();
//line 1008
__function_map = new Dictionary<String, Imm>();
__function_map.Add("value",___nl__15);
__function_map.Add("key",___nl__13);
___nl__14 = new ImmHash(__function_map).clone();
//line 1008
___nl__15 = null;
//line 1008
___nl__14 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("key"), ___nl__14).clone();
//line 1008
___ref______nl__6 = new ImmRef(___nl__6);
array_NL.NL_push(___ref______nl__6,___nl__14);
___nl__6 = ___ref______nl__6.getValue().clone();

//line 1008
___nl__14 = null;
//line 1009
___nl__14 = new ImmDouble(0).clone();
//line 1009
___nl__14 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__1.getValue().ToString())) ==((Double.Parse(___nl__14.getValue().ToString())))  ).clone();
//line 1009
___nl__15 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__14)).clone();
//line 1009
if (c_rt_lib_NL.NL_check_true_native(___nl__15)) {if (true) {goto label_12;}}
//line 1009
___nl__14 = array_NL.NL_len(___nl__3).clone();

//line 1009
___nl__16 = new ImmDouble(1).clone();
//line 1009
___nl__14 = new ImmDouble((Double.Parse(___nl__14.getValue().ToString()))-(Double.Parse(___nl__16.getValue().ToString()))).clone();
//line 1009
___nl__16 = null;
//line 1009
___nl__14 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString())) ==((Double.Parse(___nl__14.getValue().ToString())))  ).clone();
//line 1009
label_12:
//line 1009
___nl__15 = null;
//line 1009
___nl__14 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__14)).clone();
//line 1009
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_11;}}
//line 1009
___nl__11 = null;
//line 1009
___nl__12 = null;
//line 1009
___nl__13 = null;
//line 1009
___nl__14 = null;
//line 1009
if (true) {goto label_1;}
//line 1009
if (true) {goto label_11;}
//line 1009
label_11:
//line 1009
___nl__14 = null;
//line 1010
___nl__15 = new ImmDouble(1).clone();
//line 1010
___nl__15 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))+(Double.Parse(___nl__15.getValue().ToString()))).clone();
//line 1010
___nl__14 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__15).getDoubleValue()].clone();
//line 1010
___nl__15 = null;
//line 1010
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_load_const_priv(___nl__13,___nl__14,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 1010
___nl__14 = null;
//line 1011
___nl__15 = new ImmDouble(1).clone();
//line 1011
___nl__15 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))+(Double.Parse(___nl__15.getValue().ToString()))).clone();
//line 1011
___nl__14 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__15).getDoubleValue()].clone();
//line 1011
___nl__15 = null;
//line 1011
___nl__15 = new ImmString("get_ref_hash").clone();
//line 1011
___nl__17 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()].clone();
//line 1011
___nl__17 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("val"), ___nl__17).clone();
//line 1011
___nl__19 = new ImmDouble(1).clone();
//line 1011
___nl__19 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))+(Double.Parse(___nl__19.getValue().ToString()))).clone();
//line 1011
___nl__18 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__19).getDoubleValue()].clone();
//line 1011
___nl__19 = null;
//line 1011
___nl__18 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("val"), ___nl__18).clone();
//line 1011
___nl__16 = new ImmArray(new Imm[] {___nl__17,___nl__18,}).clone();
//line 1011
___nl__17 = null;
//line 1011
___nl__18 = null;
//line 1011
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_call_base_priv(___nl__14,___nl__15,___nl__16,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 1011
___nl__16 = null;
//line 1011
___nl__15 = null;
//line 1011
___nl__14 = null;
//line 1011
___nl__13 = null;
//line 1012
if (true) {goto label_4;}
//line 1012
label_4:
//line 1012
___nl__11 = null;
//line 1012
___nl__12 = null;
//line 1013
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))+(Double.Parse(___nl__9.getValue().ToString()))).clone();
//line 1013
if (true) {goto label_3;}
//line 1013
label_1:
//line 1013
___nl__7 = null;
//line 1013
___nl__8 = null;
//line 1013
___nl__9 = null;
//line 1013
___nl__10 = null;
//line 1014
___nl__8 = array_NL.NL_len(___nl__5).clone();

//line 1014
___nl__9 = new ImmDouble(1).clone();
//line 1014
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))-(Double.Parse(___nl__9.getValue().ToString()))).clone();
//line 1014
___nl__9 = null;
//line 1014
___nl__7 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()].clone();
//line 1014
___nl__8 = null;
//line 1014
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("value"), ___nl__7).clone();
//line 1014
___ref______nl__6 = new ImmRef(___nl__6);
array_NL.NL_push(___ref______nl__6,___nl__7);
___nl__6 = ___ref______nl__6.getValue().clone();

//line 1014
___nl__7 = null;
//line 1015
___nl__0 = null;
//line 1015
___nl__1 = null;
//line 1015
___nl__3 = null;
//line 1015
___nl__4 = null;
//line 1015
___nl__5 = null;
//line 1015
___arg__2.setValue(___nl__2);if(true) return ___nl__6;
//line 1015
___nl__3 = null;
//line 1015
___nl__4 = null;
//line 1015
___nl__5 = null;
//line 1015
___nl__6 = null;
//line 1015
___nl__0 = null;
//line 1015
___nl__1 = null;
//line 1015
___arg__2.setValue(___nl__2);if(true) return null;
}

private static Imm NL_set_value_of_lvalue_priv(Imm ___arg__0, Imm ___arg__1, ImmRef ___arg__2) {
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
//line 1019
___ref______nl__2 = new ImmRef(___nl__2);
___nl__3 = translator_NL.NL_save_registers_priv(___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 1020
___nl__4 = array_NL.NL_len(___nl__0).clone();

//line 1021
___nl__6 = new ImmDouble(1).clone();
//line 1021
___nl__6 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))-(Double.Parse(___nl__6.getValue().ToString()))).clone();
//line 1021
___nl__5 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()].clone();
//line 1021
___nl__6 = null;
//line 1021
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("value")).clone();
//line 1022
___nl__6 = new ImmString("").clone();
//line 1023
___nl__7 = new ImmDouble(2).clone();
//line 1023
___nl__7 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))-(Double.Parse(___nl__7.getValue().ToString()))).clone();
//line 1023
label_2:
//line 1023
___nl__8 = new ImmDouble(0).clone();
//line 1023
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))>=(Double.Parse(___nl__8.getValue().ToString())) ).clone();
//line 1023
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 1023
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_1;}}
//line 1024
___nl__9 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()].clone();
//line 1024
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__9, new ImmString("value")).clone();
//line 1024
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_5;}}
//line 1026
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__9, new ImmString("index")).clone();
//line 1026
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_6;}}
//line 1033
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__9, new ImmString("key")).clone();
//line 1033
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_7;}}
//line 1033
___nl__10 = new ImmString("NOMATCHALERT").clone();
//line 1033
___nl__10 = new ImmArray(new Imm[] {___nl__10,___nl__9,}).clone();
//line 1033
c_rt_lib_NL.NL_die();
//line 1024
label_5:
//line 1024
___nl__11 = c_rt_lib_NL.NL_ov_as(___nl__9, new ImmString("value")).clone();
//line 1025
___nl__12 = new ImmArray(new Imm[0]).clone();
//line 1025
c_rt_lib_NL.NL_die();
//line 1025
___nl__12 = null;
//line 1025
___nl__11 = null;
//line 1026
if (true) {goto label_4;}
//line 1026
label_6:
//line 1026
___nl__11 = c_rt_lib_NL.NL_ov_as(___nl__9, new ImmString("index")).clone();
//line 1027
___nl__12 = new ImmDouble(0).clone();
//line 1027
___nl__12 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__1.getValue().ToString())) ==((Double.Parse(___nl__12.getValue().ToString())))  ).clone();
//line 1027
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 1027
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_10;}}
//line 1027
___nl__12 = new ImmDouble(2).clone();
//line 1027
___nl__12 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))-(Double.Parse(___nl__12.getValue().ToString()))).clone();
//line 1027
___nl__12 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString())) ==((Double.Parse(___nl__12.getValue().ToString())))  ).clone();
//line 1027
label_10:
//line 1027
___nl__13 = null;
//line 1027
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 1027
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_9;}}
//line 1028
___nl__13 = ((ImmHash)___nl__11).getHashValue()["value"].clone();
//line 1028
___nl__14 = ((ImmHash)___nl__11).getHashValue()["index"].clone();
//line 1028
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_set_at_index_priv(___nl__13,___nl__14,___nl__5,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 1028
___nl__14 = null;
//line 1028
___nl__13 = null;
//line 1029
if (true) {goto label_8;}
//line 1029
label_9:
//line 1030
___nl__13 = new ImmString("").clone();
//line 1030
___nl__14 = new ImmString("set_ref_arr").clone();
//line 1030
___nl__16 = ((ImmHash)___nl__11).getHashValue()["value"].clone();
//line 1030
___nl__16 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__16).clone();
//line 1030
___nl__17 = ((ImmHash)___nl__11).getHashValue()["index"].clone();
//line 1030
___nl__17 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("val"), ___nl__17).clone();
//line 1030
___nl__18 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("val"), ___nl__5).clone();
//line 1030
___nl__15 = new ImmArray(new Imm[] {___nl__16,___nl__17,___nl__18,}).clone();
//line 1030
___nl__16 = null;
//line 1030
___nl__17 = null;
//line 1030
___nl__18 = null;
//line 1030
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_call_base_priv(___nl__13,___nl__14,___nl__15,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 1030
___nl__15 = null;
//line 1030
___nl__14 = null;
//line 1030
___nl__13 = null;
//line 1031
if (true) {goto label_8;}
//line 1031
label_8:
//line 1031
___nl__12 = null;
//line 1032
___nl__12 = ((ImmHash)___nl__11).getHashValue()["value"].clone();
//line 1032
___nl__5 = ___nl__12.clone();
//line 1032
___nl__12 = null;
//line 1032
___nl__11 = null;
//line 1033
if (true) {goto label_4;}
//line 1033
label_7:
//line 1033
___nl__11 = c_rt_lib_NL.NL_ov_as(___nl__9, new ImmString("key")).clone();
//line 1034
___nl__12 = new ImmDouble(0).clone();
//line 1034
___nl__12 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__1.getValue().ToString())) ==((Double.Parse(___nl__12.getValue().ToString())))  ).clone();
//line 1034
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 1034
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_13;}}
//line 1034
___nl__12 = new ImmDouble(2).clone();
//line 1034
___nl__12 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))-(Double.Parse(___nl__12.getValue().ToString()))).clone();
//line 1034
___nl__12 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString())) ==((Double.Parse(___nl__12.getValue().ToString())))  ).clone();
//line 1034
label_13:
//line 1034
___nl__13 = null;
//line 1034
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 1034
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_12;}}
//line 1035
___nl__13 = ((ImmHash)___nl__11).getHashValue()["value"].clone();
//line 1035
___nl__14 = ((ImmHash)___nl__11).getHashValue()["key"].clone();
//line 1035
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_set_value_priv(___nl__13,___nl__14,___nl__5,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 1035
___nl__14 = null;
//line 1035
___nl__13 = null;
//line 1036
if (true) {goto label_11;}
//line 1036
label_12:
//line 1037
___nl__13 = new ImmString("").clone();
//line 1037
___nl__13 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__13.toString())).clone();
//line 1037
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13)).clone();
//line 1037
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_15;}}
//line 1037
___ref______nl__2 = new ImmRef(___nl__2);
___nl__14 = translator_NL.NL_new_register_priv(___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 1037
___nl__6 = ___nl__14.clone();
//line 1037
___nl__14 = null;
//line 1037
if (true) {goto label_15;}
//line 1037
label_15:
//line 1037
___nl__13 = null;
//line 1038
___nl__13 = ((ImmHash)___nl__11).getHashValue()["key"].clone();
//line 1038
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_load_const_priv(___nl__13,___nl__6,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 1038
___nl__13 = null;
//line 1039
___nl__13 = new ImmString("").clone();
//line 1039
___nl__14 = new ImmString("set_ref_hash").clone();
//line 1039
___nl__16 = ((ImmHash)___nl__11).getHashValue()["value"].clone();
//line 1039
___nl__16 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__16).clone();
//line 1039
___nl__17 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("val"), ___nl__6).clone();
//line 1039
___nl__18 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("val"), ___nl__5).clone();
//line 1039
___nl__15 = new ImmArray(new Imm[] {___nl__16,___nl__17,___nl__18,}).clone();
//line 1039
___nl__16 = null;
//line 1039
___nl__17 = null;
//line 1039
___nl__18 = null;
//line 1039
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_call_base_priv(___nl__13,___nl__14,___nl__15,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 1039
___nl__15 = null;
//line 1039
___nl__14 = null;
//line 1039
___nl__13 = null;
//line 1040
if (true) {goto label_11;}
//line 1040
label_11:
//line 1040
___nl__12 = null;
//line 1041
___nl__12 = ((ImmHash)___nl__11).getHashValue()["value"].clone();
//line 1041
___nl__5 = ___nl__12.clone();
//line 1041
___nl__12 = null;
//line 1041
___nl__11 = null;
//line 1042
if (true) {goto label_4;}
//line 1042
label_4:
//line 1042
___nl__9 = null;
//line 1042
___nl__10 = null;
//line 1042
___nl__9 = new ImmDouble(1).clone();
//line 1042
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))-(Double.Parse(___nl__9.getValue().ToString()))).clone();
//line 1042
___nl__9 = null;
//line 1043
if (true) {goto label_2;}
//line 1043
label_1:
//line 1043
___nl__7 = null;
//line 1043
___nl__8 = null;
//line 1044
___nl__7 = new ImmString("").clone();
//line 1044
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!___nl__6.toString().Equals(___nl__7.toString())).clone();
//line 1044
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 1044
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_17;}}
//line 1044
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_restore_registers_priv(___nl__3,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 1044
if (true) {goto label_17;}
//line 1044
label_17:
//line 1044
___nl__7 = null;
//line 1044
___nl__3 = null;
//line 1044
___nl__4 = null;
//line 1044
___nl__5 = null;
//line 1044
___nl__6 = null;
//line 1044
___nl__0 = null;
//line 1044
___nl__1 = null;
//line 1044
___arg__2.setValue(___nl__2);if(true) return null;
}

private static Imm NL_make_string_priv(Imm ___arg__0, ImmRef ___arg__1) {
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
//line 1048
___nl__2 = new ImmString("").clone();
//line 1049
___nl__3 = new ImmDouble(0).clone();
//line 1050
___nl__4 = ((ImmHash)___nl__0).getHashValue()["arr"].clone();
//line 1050
___nl__6 = new ImmDouble(0).clone();
//line 1050
___nl__7 = new ImmDouble(1).clone();
//line 1050
___nl__8 = c_rt_lib_NL.NL_array_len(___nl__4).clone();

//line 1050
label_3:
//line 1050
___nl__9 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__6.getValue().ToString()))>=(Double.Parse(___nl__8.getValue().ToString())) ).clone();
//line 1050
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_1;}}
//line 1050
___nl__5 = (___nl__4 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()].clone();
//line 1051
___nl__10 = new ImmDouble(0).clone();
//line 1051
___nl__10 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))>(Double.Parse(___nl__10.getValue().ToString())) ).clone();
//line 1051
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 1051
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_5;}}
//line 1051
___nl__11 = string_NL.NL_lf().clone();

//line 1051
___nl__2 = new ImmString(___nl__2.toString() + ___nl__11.toString()).clone();
//line 1051
___nl__11 = null;
//line 1051
if (true) {goto label_5;}
//line 1051
label_5:
//line 1051
___nl__10 = null;
//line 1052
___nl__2 = new ImmString(___nl__2.toString() + ___nl__5.toString()).clone();
//line 1053
___nl__10 = new ImmDouble(1).clone();
//line 1053
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__10.getValue().ToString()))).clone();
//line 1053
___nl__10 = null;
//line 1054
___nl__6 = new ImmDouble((Double.Parse(___nl__6.getValue().ToString()))+(Double.Parse(___nl__7.getValue().ToString()))).clone();
//line 1054
if (true) {goto label_3;}
//line 1054
label_1:
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
___nl__9 = null;
//line 1055
___nl__4 = ((ImmHash)___nl__0).getHashValue()["last"].clone();
//line 1055
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("new_line")).clone();
//line 1055
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_7;}}
//line 1057
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("end")).clone();
//line 1057
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_8;}}
//line 1057
___nl__5 = new ImmString("NOMATCHALERT").clone();
//line 1057
___nl__5 = new ImmArray(new Imm[] {___nl__5,___nl__4,}).clone();
//line 1057
c_rt_lib_NL.NL_die();
//line 1055
label_7:
//line 1056
___nl__6 = string_NL.NL_lf().clone();

//line 1056
___nl__2 = new ImmString(___nl__2.toString() + ___nl__6.toString()).clone();
//line 1056
___nl__6 = null;
//line 1057
if (true) {goto label_6;}
//line 1057
label_8:
//line 1058
if (true) {goto label_6;}
//line 1058
label_6:
//line 1058
___nl__4 = null;
//line 1058
___nl__5 = null;
//line 1059
___nl__0 = null;
//line 1059
___nl__3 = null;
//line 1059
___arg__1.setValue(___nl__1);if(true) return ___nl__2;
//line 1059
___nl__2 = null;
//line 1059
___nl__3 = null;
//line 1059
___nl__0 = null;
//line 1059
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_print_ternary_op_priv(Imm ___arg__0, Imm ___arg__1, ImmRef ___arg__2) {
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
//line 1065
___nl__3 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 1065
___nl__4 = new ImmString("?").clone();
//line 1065
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__4.toString())).clone();
//line 1065
___nl__4 = null;
//line 1065
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 1065
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 1065
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 1065
___nl__4 = new ImmArray(new Imm[0]).clone();
//line 1065
c_rt_lib_NL.NL_die();
//line 1065
if (true) {goto label_2;}
//line 1065
label_2:
//line 1065
___nl__3 = null;
//line 1065
___nl__4 = null;
//line 1067
___ref______nl__2 = new ImmRef(___nl__2);
___nl__3 = translator_NL.NL_get_sim_label_priv(___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 1068
___ref______nl__2 = new ImmRef(___nl__2);
___nl__4 = translator_NL.NL_get_sim_label_priv(___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 1070
___nl__6 = ((ImmHash)___nl__0).getHashValue()["fst"].clone();
//line 1070
___ref______nl__2 = new ImmRef(___nl__2);
___nl__5 = translator_NL.NL_dest_val_priv(___nl__6,___nl__1,___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 1070
___nl__6 = null;
//line 1072
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_if_goto_priv(___nl__4,___nl__5,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 1073
___nl__6 = ((ImmHash)___nl__0).getHashValue()["thrd"].clone();
//line 1073
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_val_priv(___nl__6,___nl__1,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 1073
___nl__6 = null;
//line 1074
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("goto"), ___nl__3).clone();
//line 1074
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_priv(___ref______nl__2,___nl__6);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 1074
___nl__6 = null;
//line 1076
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_sim_label_priv(___nl__4,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 1077
___nl__6 = ((ImmHash)___nl__0).getHashValue()["snd"].clone();
//line 1077
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_val_priv(___nl__6,___nl__1,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 1077
___nl__6 = null;
//line 1079
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_sim_label_priv(___nl__3,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 1079
___nl__3 = null;
//line 1079
___nl__4 = null;
//line 1079
___nl__5 = null;
//line 1079
___nl__0 = null;
//line 1079
___nl__1 = null;
//line 1079
___arg__2.setValue(___nl__2);if(true) return null;
}

private static Imm NL_print_die_priv(Imm ___arg__0, ImmRef ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 1084
___ref______nl__1 = new ImmRef(___nl__1);
___nl__2 = translator_NL.NL_new_register_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 1085
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("arr_decl"), ___nl__0).clone();
//line 1085
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_val_priv(___nl__3,___nl__2,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 1085
___nl__3 = null;
//line 1086
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("die"), ___nl__2).clone();
//line 1086
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_priv(___ref______nl__1,___nl__3);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 1086
___nl__3 = null;
//line 1086
___nl__2 = null;
//line 1086
___nl__0 = null;
//line 1086
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_print_return_priv(Imm ___arg__0, ImmRef ___arg__1) {
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
//line 1090
___ref______nl__1 = new ImmRef(___nl__1);
___nl__2 = translator_NL.NL_save_registers_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 1091
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("emp")).clone();
//line 1092
___nl__4 = ___nl__0.clone();
//line 1092
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("nop")).clone();
//line 1092
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 1092
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 1092
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 1093
___ref______nl__1 = new ImmRef(___nl__1);
___nl__5 = translator_NL.NL_calc_val_priv(___nl__0,___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 1093
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("val"), ___nl__5).clone();
//line 1093
___nl__3 = ___nl__5.clone();
//line 1093
___nl__5 = null;
//line 1094
if (true) {goto label_2;}
//line 1094
label_2:
//line 1094
___nl__4 = null;
//line 1095
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_safe_return_priv(___nl__3,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 1096
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_restore_registers_priv(___nl__2,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 1096
___nl__2 = null;
//line 1096
___nl__3 = null;
//line 1096
___nl__0 = null;
//line 1096
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_print_safe_return_priv(Imm ___arg__0, ImmRef ___arg__1) {
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
//line 1099
___ref______nl__1 = new ImmRef(___nl__1);
___nl__2 = translator_NL.NL_save_registers_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 1100
___nl__3 = ((ImmHash)___nl__1).getHashValue()["logic"].clone();
//line 1100
___nl__3 = ((ImmHash)___nl__3).getHashValue()["register"].clone();
//line 1101
___nl__4 = new ImmDouble(1).clone();
//line 1101
___nl__4 = new ImmDouble(-((ImmDouble)___nl__4).getDoubleValue()).clone();
//line 1102
___nl__5 = ((ImmHash)___nl__1).getHashValue()["result"].clone();
//line 1102
___nl__5 = ((ImmHash)___nl__5).getHashValue()["args_type"].clone();
//line 1103
___nl__6 = ___nl__0.clone();
//line 1103
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("val")).clone();
//line 1103
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 1103
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_2;}}
//line 1104
___nl__7 = ___nl__0.clone();
//line 1104
___nl__7 = c_rt_lib_NL.NL_ov_as(___nl__7, new ImmString("val")).clone();
//line 1104
___nl__4 = ___nl__7.clone();
//line 1104
___nl__7 = null;
//line 1105
___nl__7 = array_NL.NL_len(___nl__5).clone();

//line 1105
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))<(Double.Parse(___nl__7.getValue().ToString())) ).clone();
//line 1105
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 1105
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_5;}}
//line 1105
___nl__7 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()].clone();
//line 1105
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("ref")).clone();
//line 1105
label_5:
//line 1105
___nl__8 = null;
//line 1105
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 1105
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_4;}}
//line 1106
___ref______nl__1 = new ImmRef(___nl__1);
___nl__8 = translator_NL.NL_new_register_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 1106
___nl__4 = ___nl__8.clone();
//line 1106
___nl__8 = null;
//line 1107
___nl__8 = ___nl__0.clone();
//line 1107
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__8, new ImmString("val")).clone();
//line 1107
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_move_priv(___nl__4,___nl__8,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 1107
___nl__8 = null;
//line 1108
___nl__8 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("val"), ___nl__4).clone();
//line 1108
___nl__0 = ___nl__8.clone();
//line 1108
___nl__8 = null;
//line 1109
if (true) {goto label_4;}
//line 1109
label_4:
//line 1109
___nl__7 = null;
//line 1110
if (true) {goto label_2;}
//line 1110
label_2:
//line 1110
___nl__6 = null;
//line 1111
___nl__6 = new ImmDouble(0).clone();
//line 1111
label_7:
//line 1111
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__6.getValue().ToString()))<(Double.Parse(___nl__3.getValue().ToString())) ).clone();
//line 1111
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 1111
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_6;}}
//line 1112
___nl__8 = array_NL.NL_len(___nl__5).clone();

//line 1112
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__6.getValue().ToString()))<(Double.Parse(___nl__8.getValue().ToString())) ).clone();
//line 1112
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 1112
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_11;}}
//line 1112
___nl__8 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()].clone();
//line 1112
___nl__8 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("ref")).clone();
//line 1112
label_11:
//line 1112
___nl__9 = null;
//line 1112
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 1112
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_10;}}
//line 1112
___nl__8 = null;
//line 1112
if (true) {goto label_8;}
//line 1112
if (true) {goto label_10;}
//line 1112
label_10:
//line 1112
___nl__8 = null;
//line 1113
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__6.getValue().ToString())) ==((Double.Parse(___nl__4.getValue().ToString())))  ).clone();
//line 1113
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 1113
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_13;}}
//line 1113
___nl__8 = null;
//line 1113
if (true) {goto label_8;}
//line 1113
if (true) {goto label_13;}
//line 1113
label_13:
//line 1113
___nl__8 = null;
//line 1114
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__9 = new ImmHash(__function_map).clone();
//line 1114
___nl__9 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__9).clone();
//line 1114
___nl__8 = ptd_NL.NL_ensure(___nl__9,___nl__6).clone();

//line 1114
___nl__9 = null;
//line 1114
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_undef_reg_priv(___nl__8,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 1114
___nl__8 = null;
//line 1114
label_8:
//line 1114
___nl__8 = new ImmDouble(1).clone();
//line 1114
___nl__6 = new ImmDouble((Double.Parse(___nl__6.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString()))).clone();
//line 1114
___nl__8 = null;
//line 1115
if (true) {goto label_7;}
//line 1115
label_6:
//line 1115
___nl__6 = null;
//line 1115
___nl__7 = null;
//line 1116
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("return"), ___nl__0).clone();
//line 1116
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_priv(___ref______nl__1,___nl__6);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 1116
___nl__6 = null;
//line 1117
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_restore_registers_priv(___nl__2,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 1117
___nl__2 = null;
//line 1117
___nl__3 = null;
//line 1117
___nl__4 = null;
//line 1117
___nl__5 = null;
//line 1117
___nl__0 = null;
//line 1117
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_convert_str_to_number_priv(Imm ___arg__0) {
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
//line 1120
___nl__1 = string_NL.NL_length(___nl__0).clone();

//line 1121
___nl__2 = new ImmDouble(3).clone();
//line 1121
___nl__2 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__1.getValue().ToString()))>=(Double.Parse(___nl__2.getValue().ToString())) ).clone();
//line 1121
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 1121
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 1121
___nl__4 = new ImmDouble(1).clone();
//line 1121
___nl__5 = new ImmDouble(1).clone();
//line 1121
___nl__2 = string_NL.NL_substr(___nl__0,___nl__4,___nl__5).clone();

//line 1121
___nl__5 = null;
//line 1121
___nl__4 = null;
//line 1121
___nl__4 = new ImmString("x").clone();
//line 1121
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__4.toString())).clone();
//line 1121
___nl__4 = null;
//line 1121
label_3:
//line 1121
___nl__3 = null;
//line 1121
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 1121
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 1122
___nl__3 = new ImmDouble(0).clone();
//line 1123
___nl__4 = new ImmDouble(2).clone();
//line 1123
label_5:
//line 1123
___nl__5 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))<(Double.Parse(___nl__1.getValue().ToString())) ).clone();
//line 1123
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 1123
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_4;}}
//line 1124
___nl__7 = new ImmDouble(1).clone();
//line 1124
___nl__6 = string_NL.NL_substr(___nl__0,___nl__4,___nl__7).clone();

//line 1124
___nl__7 = null;
//line 1125
___nl__7 = string_NL.NL_ord(___nl__6).clone();

//line 1126
___nl__8 = new ImmDouble(16).clone();
//line 1126
___nl__8 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))*(Double.Parse(___nl__8.getValue().ToString()))).clone();
//line 1126
___nl__3 = ___nl__8.clone();
//line 1126
___nl__8 = null;
//line 1127
___nl__10 = new ImmDouble(0).clone();
//line 1127
___nl__8 = string_NL.NL_ord(___nl__10).clone();

//line 1127
___nl__10 = null;
//line 1127
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))>=(Double.Parse(___nl__8.getValue().ToString())) ).clone();
//line 1127
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 1127
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_9;}}
//line 1127
___nl__10 = new ImmDouble(9).clone();
//line 1127
___nl__8 = string_NL.NL_ord(___nl__10).clone();

//line 1127
___nl__10 = null;
//line 1127
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))<=(Double.Parse(___nl__8.getValue().ToString())) ).clone();
//line 1127
label_9:
//line 1127
___nl__9 = null;
//line 1127
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 1127
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_8;}}
//line 1128
___nl__10 = new ImmDouble(0).clone();
//line 1128
___nl__9 = string_NL.NL_ord(___nl__10).clone();

//line 1128
___nl__10 = null;
//line 1128
___nl__9 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))-(Double.Parse(___nl__9.getValue().ToString()))).clone();
//line 1128
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__9.getValue().ToString()))).clone();
//line 1128
___nl__9 = null;
//line 1129
if (true) {goto label_7;}
//line 1129
label_8:
//line 1129
___nl__10 = new ImmString("A").clone();
//line 1129
___nl__8 = string_NL.NL_ord(___nl__10).clone();

//line 1129
___nl__10 = null;
//line 1129
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))>=(Double.Parse(___nl__8.getValue().ToString())) ).clone();
//line 1129
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 1129
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_11;}}
//line 1129
___nl__10 = new ImmString("F").clone();
//line 1129
___nl__8 = string_NL.NL_ord(___nl__10).clone();

//line 1129
___nl__10 = null;
//line 1129
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))<=(Double.Parse(___nl__8.getValue().ToString())) ).clone();
//line 1129
label_11:
//line 1129
___nl__9 = null;
//line 1129
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 1129
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_10;}}
//line 1130
___nl__10 = new ImmString("A").clone();
//line 1130
___nl__9 = string_NL.NL_ord(___nl__10).clone();

//line 1130
___nl__10 = null;
//line 1130
___nl__9 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))-(Double.Parse(___nl__9.getValue().ToString()))).clone();
//line 1130
___nl__10 = new ImmDouble(10).clone();
//line 1130
___nl__9 = new ImmDouble((Double.Parse(___nl__9.getValue().ToString()))+(Double.Parse(___nl__10.getValue().ToString()))).clone();
//line 1130
___nl__10 = null;
//line 1130
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__9.getValue().ToString()))).clone();
//line 1130
___nl__9 = null;
//line 1131
if (true) {goto label_7;}
//line 1131
label_10:
//line 1131
___nl__10 = new ImmString("a").clone();
//line 1131
___nl__8 = string_NL.NL_ord(___nl__10).clone();

//line 1131
___nl__10 = null;
//line 1131
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))>=(Double.Parse(___nl__8.getValue().ToString())) ).clone();
//line 1131
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 1131
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_13;}}
//line 1131
___nl__10 = new ImmString("f").clone();
//line 1131
___nl__8 = string_NL.NL_ord(___nl__10).clone();

//line 1131
___nl__10 = null;
//line 1131
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))<=(Double.Parse(___nl__8.getValue().ToString())) ).clone();
//line 1131
label_13:
//line 1131
___nl__9 = null;
//line 1131
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 1131
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_12;}}
//line 1132
___nl__10 = new ImmString("a").clone();
//line 1132
___nl__9 = string_NL.NL_ord(___nl__10).clone();

//line 1132
___nl__10 = null;
//line 1132
___nl__9 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))-(Double.Parse(___nl__9.getValue().ToString()))).clone();
//line 1132
___nl__10 = new ImmDouble(10).clone();
//line 1132
___nl__9 = new ImmDouble((Double.Parse(___nl__9.getValue().ToString()))+(Double.Parse(___nl__10.getValue().ToString()))).clone();
//line 1132
___nl__10 = null;
//line 1132
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__9.getValue().ToString()))).clone();
//line 1132
___nl__9 = null;
//line 1133
if (true) {goto label_7;}
//line 1133
label_12:
//line 1134
___nl__9 = new ImmArray(new Imm[0]).clone();
//line 1134
c_rt_lib_NL.NL_die();
//line 1134
___nl__9 = null;
//line 1135
if (true) {goto label_7;}
//line 1135
label_7:
//line 1135
___nl__8 = null;
//line 1135
___nl__6 = null;
//line 1135
___nl__7 = null;
//line 1135
___nl__6 = new ImmDouble(1).clone();
//line 1135
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString()))).clone();
//line 1135
___nl__6 = null;
//line 1136
if (true) {goto label_5;}
//line 1136
label_4:
//line 1136
___nl__4 = null;
//line 1136
___nl__5 = null;
//line 1137
___nl__0 = null;
//line 1137
___nl__1 = null;
//line 1137
___nl__2 = null;
//line 1137
if(true) return ___nl__3;
//line 1137
___nl__3 = null;
//line 1138
if (true) {goto label_1;}
//line 1138
label_2:
//line 1138
___nl__2 = new ImmDouble(2).clone();
//line 1138
___nl__2 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__1.getValue().ToString()))>=(Double.Parse(___nl__2.getValue().ToString())) ).clone();
//line 1138
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 1138
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_16;}}
//line 1138
___nl__5 = new ImmDouble(0).clone();
//line 1138
___nl__6 = new ImmDouble(1).clone();
//line 1138
___nl__2 = string_NL.NL_substr(___nl__0,___nl__5,___nl__6).clone();

//line 1138
___nl__6 = null;
//line 1138
___nl__5 = null;
//line 1138
___nl__5 = new ImmDouble(0).clone();
//line 1138
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__5.toString())).clone();
//line 1138
___nl__5 = null;
//line 1138
label_16:
//line 1138
___nl__4 = null;
//line 1138
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 1138
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_15;}}
//line 1138
___nl__2 = string_utils_NL.NL_is_integer(___nl__0).clone();

//line 1138
label_15:
//line 1138
___nl__3 = null;
//line 1138
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 1138
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_14;}}
//line 1139
___nl__3 = new ImmDouble(0).clone();
//line 1140
___nl__4 = new ImmDouble(0).clone();
//line 1140
___nl__5 = new ImmDouble(1).clone();
//line 1140
label_19:
//line 1140
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__1.getValue().ToString())) ).clone();
//line 1140
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_17;}}
//line 1141
___nl__7 = new ImmDouble(8).clone();
//line 1141
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))*(Double.Parse(___nl__7.getValue().ToString()))).clone();
//line 1141
___nl__7 = null;
//line 1142
___nl__9 = new ImmDouble(1).clone();
//line 1142
___nl__8 = string_NL.NL_substr(___nl__0,___nl__4,___nl__9).clone();

//line 1142
___nl__9 = null;
//line 1142
___nl__7 = string_NL.NL_ord(___nl__8).clone();

//line 1142
___nl__8 = null;
//line 1142
___nl__9 = new ImmDouble(0).clone();
//line 1142
___nl__8 = string_NL.NL_ord(___nl__9).clone();

//line 1142
___nl__9 = null;
//line 1142
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))-(Double.Parse(___nl__8.getValue().ToString()))).clone();
//line 1142
___nl__8 = null;
//line 1142
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__7.getValue().ToString()))).clone();
//line 1142
___nl__7 = null;
//line 1143
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 1143
if (true) {goto label_19;}
//line 1143
label_17:
//line 1143
___nl__4 = null;
//line 1143
___nl__5 = null;
//line 1143
___nl__6 = null;
//line 1144
___nl__0 = null;
//line 1144
___nl__1 = null;
//line 1144
___nl__2 = null;
//line 1144
if(true) return ___nl__3;
//line 1144
___nl__3 = null;
//line 1145
if (true) {goto label_1;}
//line 1145
label_14:
//line 1146
___nl__1 = null;
//line 1146
___nl__2 = null;
//line 1146
if(true) return ___nl__0;
//line 1147
if (true) {goto label_1;}
//line 1147
label_1:
//line 1147
___nl__2 = null;
//line 1147
___nl__1 = null;
//line 1147
___nl__0 = null;
//line 1147
if(true) return null;
}

private static Imm NL_dest_val_priv(Imm ___arg__0, Imm ___arg__1, ImmRef ___arg__2) {
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
//line 1151
___nl__3 = ___nl__0.clone();
//line 1151
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("var")).clone();
//line 1151
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 1151
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 1152
___nl__5 = ___nl__0.clone();
//line 1152
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("var")).clone();
//line 1152
___ref______nl__2 = new ImmRef(___nl__2);
___nl__4 = translator_NL.NL_get_var_register_priv(___nl__5,___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 1152
___nl__5 = null;
//line 1152
___nl__0 = null;
//line 1152
___nl__1 = null;
//line 1152
___nl__3 = null;
//line 1152
___arg__2.setValue(___nl__2);if(true) return ___nl__4;
//line 1152
___nl__4 = null;
//line 1153
if (true) {goto label_2;}
//line 1153
label_2:
//line 1153
___nl__3 = null;
//line 1154
___nl__3 = new ImmString("").clone();
//line 1154
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__1.toString().Equals(___nl__3.toString())).clone();
//line 1154
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 1154
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_4;}}
//line 1154
___ref______nl__2 = new ImmRef(___nl__2);
___nl__4 = translator_NL.NL_new_register_priv(___ref______nl__2).clone();
___nl__2 = ___ref______nl__2.getValue().clone();

//line 1154
___nl__1 = ___nl__4.clone();
//line 1154
___nl__4 = null;
//line 1154
if (true) {goto label_4;}
//line 1154
label_4:
//line 1154
___nl__3 = null;
//line 1155
___ref______nl__2 = new ImmRef(___nl__2);
translator_NL.NL_print_val_priv(___nl__0,___nl__1,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 1156
___nl__0 = null;
//line 1156
___arg__2.setValue(___nl__2);if(true) return ___nl__1;
//line 1156
___nl__0 = null;
//line 1156
___nl__1 = null;
//line 1156
___arg__2.setValue(___nl__2);if(true) return null;
}

private static Imm NL_def_val_priv(Imm ___arg__0, Imm ___arg__1, Imm ___arg__2, ImmRef ___arg__3) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();Imm ___nl__3 = ___arg__3.getValue().clone();
Imm ___nl__4 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 1159
___nl__4 = new ImmString("").clone();
//line 1159
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__1.toString().Equals(___nl__4.toString())).clone();
//line 1159
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 1159
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 1159
___nl__1 = ___nl__2.clone();
//line 1159
if (true) {goto label_2;}
//line 1159
label_2:
//line 1159
___nl__4 = null;
//line 1160
___ref______nl__3 = new ImmRef(___nl__3);
translator_NL.NL_print_val_priv(___nl__0,___nl__1,___ref______nl__3);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 1161
___nl__0 = null;
//line 1161
___nl__2 = null;
//line 1161
___arg__3.setValue(___nl__3);if(true) return ___nl__1;
//line 1161
___nl__0 = null;
//line 1161
___nl__1 = null;
//line 1161
___nl__2 = null;
//line 1161
___arg__3.setValue(___nl__3);if(true) return null;
}

private static Imm NL_calc_val_priv(Imm ___arg__0, ImmRef ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 1165
___nl__2 = ___nl__0.clone();
//line 1165
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("var")).clone();
//line 1165
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 1165
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 1166
___nl__4 = ___nl__0.clone();
//line 1166
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("var")).clone();
//line 1166
___ref______nl__1 = new ImmRef(___nl__1);
___nl__3 = translator_NL.NL_get_var_register_priv(___nl__4,___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 1166
___nl__4 = null;
//line 1166
___nl__0 = null;
//line 1166
___nl__2 = null;
//line 1166
___arg__1.setValue(___nl__1);if(true) return ___nl__3;
//line 1166
___nl__3 = null;
//line 1167
if (true) {goto label_2;}
//line 1167
label_2:
//line 1167
___nl__2 = null;
//line 1168
___ref______nl__1 = new ImmRef(___nl__1);
___nl__2 = translator_NL.NL_new_register_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 1169
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_val_priv(___nl__0,___nl__2,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 1170
___nl__0 = null;
//line 1170
___arg__1.setValue(___nl__1);if(true) return ___nl__2;
//line 1170
___nl__2 = null;
//line 1170
___nl__0 = null;
//line 1170
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_get_var_register_priv(Imm ___arg__0, ImmRef ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 1174
___nl__3 = ((ImmHash)___nl__1).getHashValue()["logic"].clone();
//line 1174
___nl__3 = ((ImmHash)___nl__3).getHashValue()["variables"].clone();
//line 1174
___nl__2 = hash_NL.NL_get_value(___nl__3,___nl__0).clone();

//line 1174
___nl__3 = null;
//line 1174
___nl__0 = null;
//line 1174
___arg__1.setValue(___nl__1);if(true) return ___nl__2;
//line 1174
___nl__2 = null;
//line 1174
___nl__0 = null;
//line 1174
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_new_declaration_priv(Imm ___arg__0, ImmRef ___arg__1) {
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
//line 1178
___ref______nl__1 = new ImmRef(___nl__1);
___nl__2 = translator_NL.NL_new_register_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 1179
___nl__3 = new ImmString("logic").clone();
//line 1179
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__3).clone();

//line 1179
___nl__4 = new ImmString("variables").clone();
//line 1179
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__3,___nl__4).clone();

//line 1179
___ref______nl__4 = new ImmRef(___nl__4);
hash_NL.NL_set_value(___ref______nl__4,___nl__0,___nl__2);
___nl__4 = ___ref______nl__4.getValue().clone();

//line 1179
___nl__5 = new ImmString("variables").clone();
//line 1179
___ref______nl__3 = new ImmRef(___nl__3);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__3,___nl__5,___nl__4);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 1179
___nl__5 = new ImmString("logic").clone();
//line 1179
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__5,___nl__3);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 1179
___nl__5 = null;
//line 1179
___nl__3 = null;
//line 1179
___nl__4 = null;
//line 1180
___nl__3 = new ImmString("debug").clone();
//line 1180
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__3).clone();

//line 1180
___nl__4 = new ImmString("declarations").clone();
//line 1180
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__3,___nl__4).clone();

//line 1180
___ref______nl__4 = new ImmRef(___nl__4);
hash_NL.NL_set_value(___ref______nl__4,___nl__0,___nl__2);
___nl__4 = ___ref______nl__4.getValue().clone();

//line 1180
___nl__5 = new ImmString("declarations").clone();
//line 1180
___ref______nl__3 = new ImmRef(___nl__3);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__3,___nl__5,___nl__4);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 1180
___nl__5 = new ImmString("debug").clone();
//line 1180
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__5,___nl__3);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 1180
___nl__5 = null;
//line 1180
___nl__3 = null;
//line 1180
___nl__4 = null;
//line 1181
___nl__0 = null;
//line 1181
___arg__1.setValue(___nl__1);if(true) return ___nl__2;
//line 1181
___nl__2 = null;
//line 1181
___nl__0 = null;
//line 1181
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_new_register_priv(ImmRef ___arg__0) {
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
//line 1185
___nl__1 = new ImmString("logic").clone();
//line 1185
___nl__1 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__1).clone();

//line 1185
___nl__2 = new ImmString("register").clone();
//line 1185
___nl__2 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__2).clone();

//line 1185
___nl__3 = new ImmDouble(1).clone();
//line 1185
___nl__2 = new ImmDouble((Double.Parse(___nl__2.getValue().ToString()))+(Double.Parse(___nl__3.getValue().ToString()))).clone();
//line 1185
___nl__4 = new ImmString("register").clone();
//line 1185
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__4,___nl__2);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 1185
___nl__4 = new ImmString("logic").clone();
//line 1185
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__4,___nl__1);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 1185
___nl__4 = null;
//line 1185
___nl__1 = null;
//line 1185
___nl__2 = null;
//line 1185
___nl__3 = null;
//line 1186
___nl__1 = ((ImmHash)___nl__0).getHashValue()["result"].clone();
//line 1186
___nl__1 = ((ImmHash)___nl__1).getHashValue()["reg_size"].clone();
//line 1186
___nl__2 = ((ImmHash)___nl__0).getHashValue()["logic"].clone();
//line 1186
___nl__2 = ((ImmHash)___nl__2).getHashValue()["register"].clone();
//line 1186
___nl__1 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__1.getValue().ToString()))<(Double.Parse(___nl__2.getValue().ToString())) ).clone();
//line 1186
___nl__2 = null;
//line 1186
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1)).clone();
//line 1186
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_2;}}
//line 1186
___nl__2 = ((ImmHash)___nl__0).getHashValue()["logic"].clone();
//line 1186
___nl__2 = ((ImmHash)___nl__2).getHashValue()["register"].clone();
//line 1186
___nl__3 = new ImmString("result").clone();
//line 1186
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__3).clone();

//line 1186
___nl__4 = ___nl__2.clone();
//line 1186
((ImmHash)___nl__3).set("reg_size", ___nl__4);
//line 1186
___nl__5 = new ImmString("result").clone();
//line 1186
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__3);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 1186
___nl__5 = null;
//line 1186
___nl__2 = null;
//line 1186
___nl__3 = null;
//line 1186
___nl__4 = null;
//line 1186
if (true) {goto label_2;}
//line 1186
label_2:
//line 1186
___nl__1 = null;
//line 1188
___nl__1 = ((ImmHash)___nl__0).getHashValue()["logic"].clone();
//line 1188
___nl__1 = ((ImmHash)___nl__1).getHashValue()["register"].clone();
//line 1188
___nl__2 = new ImmDouble(1).clone();
//line 1188
___nl__1 = new ImmDouble((Double.Parse(___nl__1.getValue().ToString()))-(Double.Parse(___nl__2.getValue().ToString()))).clone();
//line 1188
___nl__2 = null;
//line 1188
___arg__0.setValue(___nl__0);if(true) return ___nl__1;
//line 1188
___nl__1 = null;
//line 1188
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_save_registers_priv(ImmRef ___arg__0) {
Imm ___nl__0 = ___arg__0.getValue().clone();
Imm ___nl__1 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 1192
___nl__1 = ((ImmHash)___nl__0).getHashValue()["logic"].clone();
//line 1192
___arg__0.setValue(___nl__0);if(true) return ___nl__1;
//line 1192
___nl__1 = null;
//line 1192
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_undef_reg_priv(Imm ___arg__0, ImmRef ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();
Imm ___nl__2 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 1195
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("clear"), ___nl__0).clone();
//line 1195
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_priv(___ref______nl__1,___nl__2);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 1195
___nl__2 = null;
//line 1195
___nl__0 = null;
//line 1195
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_restore_registers_priv(Imm ___arg__0, ImmRef ___arg__1) {
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
//line 1200
___nl__2 = ((ImmHash)___nl__0).getHashValue()["register"].clone();
//line 1200
label_2:
//line 1200
___nl__3 = ((ImmHash)___nl__1).getHashValue()["logic"].clone();
//line 1200
___nl__3 = ((ImmHash)___nl__3).getHashValue()["register"].clone();
//line 1200
___nl__3 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__2.getValue().ToString()))<(Double.Parse(___nl__3.getValue().ToString())) ).clone();
//line 1200
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 1200
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_1;}}
//line 1201
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("reg_t"));
___nl__5 = new ImmHash(__function_map).clone();
//line 1201
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__5).clone();
//line 1201
___nl__4 = ptd_NL.NL_ensure(___nl__5,___nl__2).clone();

//line 1201
___nl__5 = null;
//line 1201
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_undef_reg_priv(___nl__4,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 1201
___nl__4 = null;
//line 1201
___nl__4 = new ImmDouble(1).clone();
//line 1201
___nl__2 = new ImmDouble((Double.Parse(___nl__2.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString()))).clone();
//line 1201
___nl__4 = null;
//line 1202
if (true) {goto label_2;}
//line 1202
label_1:
//line 1202
___nl__2 = null;
//line 1202
___nl__3 = null;
//line 1203
___nl__2 = ___nl__0.clone();
//line 1203
((ImmHash)___nl__1).set("logic", ___nl__2);
//line 1203
___nl__2 = null;
//line 1203
___nl__0 = null;
//line 1203
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_print_sim_label_priv(Imm ___arg__0, ImmRef ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();
Imm ___nl__2 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 1207
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("prt_lbl"), ___nl__0).clone();
//line 1207
___ref______nl__1 = new ImmRef(___nl__1);
translator_NL.NL_print_priv(___ref______nl__1,___nl__2);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 1207
___nl__2 = null;
//line 1207
___nl__0 = null;
//line 1207
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_get_sim_label_priv(ImmRef ___arg__0) {
Imm ___nl__0 = ___arg__0.getValue().clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 1210
___nl__1 = new ImmString("label_nr").clone();
//line 1210
___nl__1 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__1).clone();

//line 1210
___nl__2 = new ImmDouble(1).clone();
//line 1210
___nl__1 = new ImmDouble((Double.Parse(___nl__1.getValue().ToString()))+(Double.Parse(___nl__2.getValue().ToString()))).clone();
//line 1210
___nl__3 = new ImmString("label_nr").clone();
//line 1210
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__3,___nl__1);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 1210
___nl__3 = null;
//line 1210
___nl__1 = null;
//line 1210
___nl__2 = null;
//line 1211
___nl__1 = new ImmString("label_").clone();
//line 1211
___nl__2 = ((ImmHash)___nl__0).getHashValue()["label_nr"].clone();
//line 1211
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 1211
___nl__2 = null;
//line 1211
___arg__0.setValue(___nl__0);if(true) return ___nl__1;
//line 1211
___nl__1 = null;
//line 1211
___arg__0.setValue(___nl__0);if(true) return null;
}

}
}