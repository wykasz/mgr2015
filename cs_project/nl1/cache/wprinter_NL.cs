using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class wprinter_NL {

private static Imm NL_SINGLETON_get_tab_size_priv() {

Imm ___nl__0 = null;
Dictionary<String, Imm> __function_map;
//line 13
___nl__0 = new ImmDouble(4).clone();
//line 13
if(true) return ___nl__0;
//line 13
___nl__0 = null;
//line 13
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_get_tab_size_priv = null;
private static Imm NL_get_tab_size_priv() {
	if (value__singleton__NL_SINGLETON_get_tab_size_priv == null) {
		value__singleton__NL_SINGLETON_get_tab_size_priv = NL_SINGLETON_get_tab_size_priv();
	}
	return value__singleton__NL_SINGLETON_get_tab_size_priv;
}
private static Imm NL_SINGLETON_get_line_width_priv() {

Imm ___nl__0 = null;
Dictionary<String, Imm> __function_map;
//line 17
___nl__0 = new ImmDouble(120).clone();
//line 17
if(true) return ___nl__0;
//line 17
___nl__0 = null;
//line 17
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_get_line_width_priv = null;
private static Imm NL_get_line_width_priv() {
	if (value__singleton__NL_SINGLETON_get_line_width_priv == null) {
		value__singleton__NL_SINGLETON_get_line_width_priv = NL_SINGLETON_get_line_width_priv();
	}
	return value__singleton__NL_SINGLETON_get_line_width_priv;
}
private static Imm NL_SINGLETON_get_sep_priv() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 21
___nl__1 = new ImmDouble(1).clone();
//line 21
___nl__2 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("sep")).clone();
//line 21
__function_map = new Dictionary<String, Imm>();
__function_map.Add("len",___nl__1);
__function_map.Add("el",___nl__2);
___nl__0 = new ImmHash(__function_map).clone();
//line 21
___nl__1 = null;
//line 21
___nl__2 = null;
//line 21
if(true) return ___nl__0;
//line 21
___nl__0 = null;
//line 21
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_get_sep_priv = null;
private static Imm NL_get_sep_priv() {
	if (value__singleton__NL_SINGLETON_get_sep_priv == null) {
		value__singleton__NL_SINGLETON_get_sep_priv = NL_SINGLETON_get_sep_priv();
	}
	return value__singleton__NL_SINGLETON_get_sep_priv;
}
public static Imm NL_SINGLETON_state_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 25
___nl__2 = ptd_NL.NL_sim().clone();

//line 25
__function_map = new Dictionary<String, Imm>();
__function_map.Add("out",___nl__2);
___nl__1 = new ImmHash(__function_map).clone();
//line 25
___nl__2 = null;
//line 25
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

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
private static Imm NL_is_to_long_priv(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 29
___nl__1 = wprinter_NL.NL_get_line_width_priv().clone();

//line 29
___nl__1 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__0.getValue().ToString()))>(Double.Parse(___nl__1.getValue().ToString())) ).clone();
//line 29
___nl__0 = null;
//line 29
if(true) return ___nl__1;
//line 29
___nl__1 = null;
//line 29
___nl__0 = null;
//line 29
if(true) return null;
}

private static Imm NL_state_print_priv(ref Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0;Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 33
___nl__2 = new ImmString("out").clone();
//line 33
___nl__2 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__2).clone();

//line 33
___nl__2 = new ImmString(___nl__2.toString() + ___nl__1.toString()).clone();
//line 33
___nl__3 = new ImmString("out").clone();
//line 33
c_rt_lib_NL.NL_set_ref_hash(ref ___nl__0,___nl__3,___nl__2);

//line 33
___nl__3 = null;
//line 33
___nl__2 = null;
//line 33
___nl__1 = null;
//line 33
___arg__0 = ___nl__0;if(true) return null;
}

private static Imm NL_pind_priv(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Dictionary<String, Imm> __function_map;
//line 37
___nl__1 = new ImmString("").clone();
//line 38
___nl__2 = new ImmDouble(0).clone();
//line 38
___nl__3 = new ImmDouble(1).clone();
//line 38
label_3:
//line 38
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__2.getValue().ToString()))>=(Double.Parse(___nl__0.getValue().ToString())) ).clone();
//line 38
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_1;}}
//line 38
___nl__6 = new ImmDouble(9).clone();
//line 38
___nl__5 = string_NL.NL_chr(___nl__6).clone();

//line 38
___nl__6 = null;
//line 38
___nl__1 = new ImmString(___nl__1.toString() + ___nl__5.toString()).clone();
//line 38
___nl__5 = null;
//line 38
___nl__2 = new ImmDouble((Double.Parse(___nl__2.getValue().ToString()))+(Double.Parse(___nl__3.getValue().ToString()))).clone();
//line 38
if (true) {goto label_3;}
//line 38
label_1:
//line 38
___nl__2 = null;
//line 38
___nl__3 = null;
//line 38
___nl__4 = null;
//line 39
___nl__0 = null;
//line 39
if(true) return ___nl__1;
//line 39
___nl__1 = null;
//line 39
___nl__0 = null;
//line 39
if(true) return null;
}

public static Imm NL_SINGLETON_arr_kind_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 43
___nl__2 = ptd_NL.NL_none().clone();

//line 43
___nl__3 = ptd_NL.NL_none().clone();

//line 43
___nl__4 = ptd_NL.NL_none().clone();

//line 43
__function_map = new Dictionary<String, Imm>();
__function_map.Add("array",___nl__2);
__function_map.Add("list",___nl__3);
__function_map.Add("op_list",___nl__4);
___nl__1 = new ImmHash(__function_map).clone();
//line 43
___nl__2 = null;
//line 43
___nl__3 = null;
//line 43
___nl__4 = null;
//line 43
___nl__0 = ptd_NL.NL_var(___nl__1).clone();

//line 43
___nl__1 = null;
//line 43
if(true) return ___nl__0;
//line 43
___nl__0 = null;
//line 43
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_arr_kind_t = null;
public static Imm NL_arr_kind_t() {
	if (value__singleton__NL_SINGLETON_arr_kind_t == null) {
		value__singleton__NL_SINGLETON_arr_kind_t = NL_SINGLETON_arr_kind_t();
	}
	return value__singleton__NL_SINGLETON_arr_kind_t;
}
public static Imm NL_SINGLETON_pretty_t() {

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
Dictionary<String, Imm> __function_map;
//line 47
___nl__2 = ptd_NL.NL_sim().clone();

//line 47
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("wprinter_NL"));
__function_map.Add("name",new ImmString("pretty_arr_t"));
___nl__7 = new ImmHash(__function_map).clone();
//line 47
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__7).clone();
//line 47
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("wprinter_NL"));
__function_map.Add("name",new ImmString("arr_kind_t"));
___nl__8 = new ImmHash(__function_map).clone();
//line 47
___nl__8 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__8).clone();
//line 47
__function_map = new Dictionary<String, Imm>();
__function_map.Add("arr",___nl__7);
__function_map.Add("type",___nl__8);
___nl__6 = new ImmHash(__function_map).clone();
//line 47
___nl__7 = null;
//line 47
___nl__8 = null;
//line 47
___nl__5 = ptd_NL.NL_rec(___nl__6).clone();

//line 47
___nl__6 = null;
//line 47
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("wprinter_NL"));
__function_map.Add("name",new ImmString("pretty_arr_t"));
___nl__8 = new ImmHash(__function_map).clone();
//line 47
___nl__8 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__8).clone();
//line 47
___nl__9 = ptd_NL.NL_sim().clone();

//line 47
___nl__10 = ptd_NL.NL_sim().clone();

//line 47
__function_map = new Dictionary<String, Imm>();
__function_map.Add("arr",___nl__8);
__function_map.Add("start",___nl__9);
__function_map.Add("end",___nl__10);
___nl__7 = new ImmHash(__function_map).clone();
//line 47
___nl__8 = null;
//line 47
___nl__9 = null;
//line 47
___nl__10 = null;
//line 47
___nl__6 = ptd_NL.NL_rec(___nl__7).clone();

//line 47
___nl__7 = null;
//line 47
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("wprinter_NL"));
__function_map.Add("name",new ImmString("pretty_t"));
___nl__9 = new ImmHash(__function_map).clone();
//line 47
___nl__9 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__9).clone();
//line 47
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("wprinter_NL"));
__function_map.Add("name",new ImmString("pretty_t"));
___nl__10 = new ImmHash(__function_map).clone();
//line 47
___nl__10 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__10).clone();
//line 47
__function_map = new Dictionary<String, Imm>();
__function_map.Add("first",___nl__9);
__function_map.Add("second",___nl__10);
___nl__8 = new ImmHash(__function_map).clone();
//line 47
___nl__9 = null;
//line 47
___nl__10 = null;
//line 47
___nl__7 = ptd_NL.NL_rec(___nl__8).clone();

//line 47
___nl__8 = null;
//line 47
___nl__8 = ptd_NL.NL_sim().clone();

//line 47
___nl__9 = ptd_NL.NL_none().clone();

//line 47
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("wprinter_NL"));
__function_map.Add("name",new ImmString("str_arr_t"));
___nl__10 = new ImmHash(__function_map).clone();
//line 47
___nl__10 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__10).clone();
//line 47
__function_map = new Dictionary<String, Imm>();
__function_map.Add("arr",___nl__5);
__function_map.Add("arr_decl",___nl__6);
__function_map.Add("bind",___nl__7);
__function_map.Add("sim",___nl__8);
__function_map.Add("sep",___nl__9);
__function_map.Add("str_arr",___nl__10);
___nl__4 = new ImmHash(__function_map).clone();
//line 47
___nl__5 = null;
//line 47
___nl__6 = null;
//line 47
___nl__7 = null;
//line 47
___nl__8 = null;
//line 47
___nl__9 = null;
//line 47
___nl__10 = null;
//line 47
___nl__3 = ptd_NL.NL_var(___nl__4).clone();

//line 47
___nl__4 = null;
//line 47
__function_map = new Dictionary<String, Imm>();
__function_map.Add("len",___nl__2);
__function_map.Add("el",___nl__3);
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
private static Imm value__singleton__NL_SINGLETON_pretty_t = null;
public static Imm NL_pretty_t() {
	if (value__singleton__NL_SINGLETON_pretty_t == null) {
		value__singleton__NL_SINGLETON_pretty_t = NL_SINGLETON_pretty_t();
	}
	return value__singleton__NL_SINGLETON_pretty_t;
}
public static Imm NL_SINGLETON_str_arr_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Dictionary<String, Imm> __function_map;
//line 60
___nl__3 = ptd_NL.NL_sim().clone();

//line 60
___nl__2 = ptd_NL.NL_arr(___nl__3).clone();

//line 60
___nl__3 = null;
//line 60
___nl__5 = ptd_NL.NL_none().clone();

//line 60
___nl__6 = ptd_NL.NL_none().clone();

//line 60
__function_map = new Dictionary<String, Imm>();
__function_map.Add("end",___nl__5);
__function_map.Add("new_line",___nl__6);
___nl__4 = new ImmHash(__function_map).clone();
//line 60
___nl__5 = null;
//line 60
___nl__6 = null;
//line 60
___nl__3 = ptd_NL.NL_var(___nl__4).clone();

//line 60
___nl__4 = null;
//line 60
__function_map = new Dictionary<String, Imm>();
__function_map.Add("arr",___nl__2);
__function_map.Add("last",___nl__3);
___nl__1 = new ImmHash(__function_map).clone();
//line 60
___nl__2 = null;
//line 60
___nl__3 = null;
//line 60
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 60
___nl__1 = null;
//line 60
if(true) return ___nl__0;
//line 60
___nl__0 = null;
//line 60
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_str_arr_t = null;
public static Imm NL_str_arr_t() {
	if (value__singleton__NL_SINGLETON_str_arr_t == null) {
		value__singleton__NL_SINGLETON_str_arr_t = NL_SINGLETON_str_arr_t();
	}
	return value__singleton__NL_SINGLETON_str_arr_t;
}
public static Imm NL_SINGLETON_pretty_arr_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 67
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("wprinter_NL"));
__function_map.Add("name",new ImmString("pretty_t"));
___nl__1 = new ImmHash(__function_map).clone();
//line 67
___nl__1 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__1).clone();
//line 67
___nl__0 = ptd_NL.NL_arr(___nl__1).clone();

//line 67
___nl__1 = null;
//line 67
if(true) return ___nl__0;
//line 67
___nl__0 = null;
//line 67
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_pretty_arr_t = null;
public static Imm NL_pretty_arr_t() {
	if (value__singleton__NL_SINGLETON_pretty_arr_t == null) {
		value__singleton__NL_SINGLETON_pretty_arr_t = NL_SINGLETON_pretty_arr_t();
	}
	return value__singleton__NL_SINGLETON_pretty_arr_t;
}
public static Imm NL_SINGLETON_get_sep() {

Imm ___nl__0 = null;
Dictionary<String, Imm> __function_map;
//line 71
___nl__0 = wprinter_NL.NL_get_sep_priv().clone();

//line 71
if(true) return ___nl__0;
//line 71
___nl__0 = null;
//line 71
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_get_sep = null;
public static Imm NL_get_sep() {
	if (value__singleton__NL_SINGLETON_get_sep == null) {
		value__singleton__NL_SINGLETON_get_sep = NL_SINGLETON_get_sep();
	}
	return value__singleton__NL_SINGLETON_get_sep;
}
private static Imm NL_count_len_priv(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Dictionary<String, Imm> __function_map;
//line 75
___nl__1 = new ImmDouble(0).clone();
//line 76
___nl__3 = new ImmDouble(0).clone();
//line 76
___nl__4 = new ImmDouble(1).clone();
//line 76
___nl__5 = c_rt_lib_NL.NL_array_len(___nl__0).clone();

//line 76
label_3:
//line 76
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))>=(Double.Parse(___nl__5.getValue().ToString())) ).clone();
//line 76
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_1;}}
//line 76
___nl__2 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__3).getDoubleValue()].clone();
//line 77
___nl__7 = ((ImmHash)___nl__2).getHashValue()["len"].clone();
//line 77
___nl__1 = new ImmDouble((Double.Parse(___nl__1.getValue().ToString()))+(Double.Parse(___nl__7.getValue().ToString()))).clone();
//line 77
___nl__7 = null;
//line 78
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString()))).clone();
//line 78
if (true) {goto label_3;}
//line 78
label_1:
//line 78
___nl__2 = null;
//line 78
___nl__3 = null;
//line 78
___nl__4 = null;
//line 78
___nl__5 = null;
//line 78
___nl__6 = null;
//line 79
___nl__0 = null;
//line 79
if(true) return ___nl__1;
//line 79
___nl__1 = null;
//line 79
___nl__0 = null;
//line 79
if(true) return null;
}

public static Imm NL_build_pretty_a(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 83
___nl__2 = wprinter_NL.NL_count_len_priv(___nl__0).clone();

//line 83
___nl__4 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("array")).clone();
//line 83
__function_map = new Dictionary<String, Imm>();
__function_map.Add("arr",___nl__0);
__function_map.Add("type",___nl__4);
___nl__3 = new ImmHash(__function_map).clone();
//line 83
___nl__4 = null;
//line 83
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("arr"), ___nl__3).clone();
//line 83
__function_map = new Dictionary<String, Imm>();
__function_map.Add("len",___nl__2);
__function_map.Add("el",___nl__3);
___nl__1 = new ImmHash(__function_map).clone();
//line 83
___nl__2 = null;
//line 83
___nl__3 = null;
//line 83
___nl__0 = null;
//line 83
if(true) return ___nl__1;
//line 83
___nl__1 = null;
//line 83
___nl__0 = null;
//line 83
if(true) return null;
}

public static Imm NL_build_pretty_l(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 87
___nl__2 = wprinter_NL.NL_count_len_priv(___nl__0).clone();

//line 87
___nl__4 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("list")).clone();
//line 87
__function_map = new Dictionary<String, Imm>();
__function_map.Add("arr",___nl__0);
__function_map.Add("type",___nl__4);
___nl__3 = new ImmHash(__function_map).clone();
//line 87
___nl__4 = null;
//line 87
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("arr"), ___nl__3).clone();
//line 87
__function_map = new Dictionary<String, Imm>();
__function_map.Add("len",___nl__2);
__function_map.Add("el",___nl__3);
___nl__1 = new ImmHash(__function_map).clone();
//line 87
___nl__2 = null;
//line 87
___nl__3 = null;
//line 87
___nl__0 = null;
//line 87
if(true) return ___nl__1;
//line 87
___nl__1 = null;
//line 87
___nl__0 = null;
//line 87
if(true) return null;
}

public static Imm NL_build_pretty_op_l(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 91
___nl__2 = wprinter_NL.NL_count_len_priv(___nl__0).clone();

//line 91
___nl__4 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("op_list")).clone();
//line 91
__function_map = new Dictionary<String, Imm>();
__function_map.Add("arr",___nl__0);
__function_map.Add("type",___nl__4);
___nl__3 = new ImmHash(__function_map).clone();
//line 91
___nl__4 = null;
//line 91
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("arr"), ___nl__3).clone();
//line 91
__function_map = new Dictionary<String, Imm>();
__function_map.Add("len",___nl__2);
__function_map.Add("el",___nl__3);
___nl__1 = new ImmHash(__function_map).clone();
//line 91
___nl__2 = null;
//line 91
___nl__3 = null;
//line 91
___nl__0 = null;
//line 91
if(true) return ___nl__1;
//line 91
___nl__1 = null;
//line 91
___nl__0 = null;
//line 91
if(true) return null;
}

public static Imm NL_build_pretty_bind(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 95
___nl__3 = ((ImmHash)___nl__0).getHashValue()["len"].clone();
//line 95
___nl__4 = ((ImmHash)___nl__1).getHashValue()["len"].clone();
//line 95
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString()))).clone();
//line 95
___nl__4 = null;
//line 95
__function_map = new Dictionary<String, Imm>();
__function_map.Add("first",___nl__0);
__function_map.Add("second",___nl__1);
___nl__4 = new ImmHash(__function_map).clone();
//line 95
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("bind"), ___nl__4).clone();
//line 95
__function_map = new Dictionary<String, Imm>();
__function_map.Add("len",___nl__3);
__function_map.Add("el",___nl__4);
___nl__2 = new ImmHash(__function_map).clone();
//line 95
___nl__3 = null;
//line 95
___nl__4 = null;
//line 95
___nl__0 = null;
//line 95
___nl__1 = null;
//line 95
if(true) return ___nl__2;
//line 95
___nl__2 = null;
//line 95
___nl__0 = null;
//line 95
___nl__1 = null;
//line 95
if(true) return null;
}

public static Imm NL_build_pretty_arr_decl(Imm ___arg__0, Imm ___arg__1, Imm ___arg__2) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);Imm ___nl__2 = null;c_rt_lib_NL.NL_copy(ref ___nl__2, ___arg__2);
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Dictionary<String, Imm> __function_map;
//line 100
___nl__4 = wprinter_NL.NL_count_len_priv(___nl__0).clone();

//line 100
___nl__5 = string_NL.NL_length(___nl__1).clone();

//line 100
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 100
___nl__5 = null;
//line 100
___nl__5 = string_NL.NL_length(___nl__2).clone();

//line 100
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 100
___nl__5 = null;
//line 100
__function_map = new Dictionary<String, Imm>();
__function_map.Add("arr",___nl__0);
__function_map.Add("start",___nl__1);
__function_map.Add("end",___nl__2);
___nl__5 = new ImmHash(__function_map).clone();
//line 100
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("arr_decl"), ___nl__5).clone();
//line 100
__function_map = new Dictionary<String, Imm>();
__function_map.Add("len",___nl__4);
__function_map.Add("el",___nl__5);
___nl__3 = new ImmHash(__function_map).clone();
//line 100
___nl__4 = null;
//line 100
___nl__5 = null;
//line 100
___nl__0 = null;
//line 100
___nl__1 = null;
//line 100
___nl__2 = null;
//line 100
if(true) return ___nl__3;
//line 100
___nl__3 = null;
//line 100
___nl__0 = null;
//line 100
___nl__1 = null;
//line 100
___nl__2 = null;
//line 100
if(true) return null;
}

public static Imm NL_build_sim(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 107
___nl__2 = string_NL.NL_length(___nl__0).clone();

//line 107
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("sim"), ___nl__0).clone();
//line 107
__function_map = new Dictionary<String, Imm>();
__function_map.Add("len",___nl__2);
__function_map.Add("el",___nl__3);
___nl__1 = new ImmHash(__function_map).clone();
//line 107
___nl__2 = null;
//line 107
___nl__3 = null;
//line 107
___nl__0 = null;
//line 107
if(true) return ___nl__1;
//line 107
___nl__1 = null;
//line 107
___nl__0 = null;
//line 107
if(true) return null;
}

public static Imm NL_build_str_arr(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Dictionary<String, Imm> __function_map;
//line 111
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("end")).clone();
//line 111
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 113
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("new_line")).clone();
//line 113
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_3;}}
//line 113
___nl__2 = new ImmString("NOMATCHALERT").clone();
//line 113
___nl__2 = new ImmArray(new Imm[] {___nl__2,___nl__1,}).clone();
//line 113
c_rt_lib_NL.NL_die();
//line 111
label_2:
//line 112
___nl__3 = array_NL.NL_len(___nl__0).clone();

//line 112
___nl__4 = new ImmDouble(1).clone();
//line 112
___nl__3 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString())) ==((Double.Parse(___nl__4.getValue().ToString())))  ).clone();
//line 112
___nl__4 = null;
//line 112
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 112
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_5;}}
//line 112
___nl__6 = new ImmDouble(0).clone();
//line 112
___nl__5 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()].clone();
//line 112
___nl__6 = null;
//line 112
___nl__4 = wprinter_NL.NL_build_sim(___nl__5).clone();

//line 112
___nl__5 = null;
//line 112
___nl__0 = null;
//line 112
___nl__1 = null;
//line 112
___nl__2 = null;
//line 112
___nl__3 = null;
//line 112
if(true) return ___nl__4;
//line 112
___nl__4 = null;
//line 112
if (true) {goto label_5;}
//line 112
label_5:
//line 112
___nl__3 = null;
//line 113
if (true) {goto label_1;}
//line 113
label_3:
//line 114
if (true) {goto label_1;}
//line 114
label_1:
//line 114
___nl__2 = null;
//line 115
___nl__3 = new ImmDouble(2).clone();
//line 115
___nl__4 = wprinter_NL.NL_get_line_width_priv().clone();

//line 115
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))*(Double.Parse(___nl__4.getValue().ToString()))).clone();
//line 115
___nl__4 = null;
//line 115
__function_map = new Dictionary<String, Imm>();
__function_map.Add("arr",___nl__0);
__function_map.Add("last",___nl__1);
___nl__4 = new ImmHash(__function_map).clone();
//line 115
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("str_arr"), ___nl__4).clone();
//line 115
__function_map = new Dictionary<String, Imm>();
__function_map.Add("len",___nl__3);
__function_map.Add("el",___nl__4);
___nl__2 = new ImmHash(__function_map).clone();
//line 115
___nl__3 = null;
//line 115
___nl__4 = null;
//line 115
___nl__0 = null;
//line 115
___nl__1 = null;
//line 115
if(true) return ___nl__2;
//line 115
___nl__2 = null;
//line 115
___nl__0 = null;
//line 115
___nl__1 = null;
//line 115
if(true) return null;
}

private static Imm NL_print_sim_arr_priv(ref Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0;Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Dictionary<String, Imm> __function_map;
//line 119
___nl__3 = new ImmDouble(0).clone();
//line 119
___nl__4 = new ImmDouble(1).clone();
//line 119
___nl__5 = c_rt_lib_NL.NL_array_len(___nl__1).clone();

//line 119
label_3:
//line 119
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))>=(Double.Parse(___nl__5.getValue().ToString())) ).clone();
//line 119
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_1;}}
//line 119
___nl__2 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__3).getDoubleValue()].clone();
//line 120
wprinter_NL.NL_print_sim_rec_priv(ref ___nl__0,___nl__2);

//line 121
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString()))).clone();
//line 121
if (true) {goto label_3;}
//line 121
label_1:
//line 121
___nl__2 = null;
//line 121
___nl__3 = null;
//line 121
___nl__4 = null;
//line 121
___nl__5 = null;
//line 121
___nl__6 = null;
//line 121
___nl__1 = null;
//line 121
___arg__0 = ___nl__0;if(true) return null;
}

private static Imm NL_print_str_arr_priv(ref Imm ___arg__0, Imm ___arg__1, Imm ___arg__2, Imm ___arg__3) {
Imm ___nl__0 = ___arg__0;Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);Imm ___nl__2 = null;c_rt_lib_NL.NL_copy(ref ___nl__2, ___arg__2);Imm ___nl__3 = null;c_rt_lib_NL.NL_copy(ref ___nl__3, ___arg__3);
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
Dictionary<String, Imm> __function_map;
//line 125
___nl__4 = ___nl__2.clone();
//line 126
___nl__5 = ((ImmHash)___nl__1).getHashValue()["arr"].clone();
//line 127
___nl__9 = new ImmDouble(0).clone();
//line 127
___nl__8 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()].clone();
//line 127
___nl__9 = null;
//line 127
___nl__7 = string_NL.NL_length(___nl__8).clone();

//line 127
___nl__8 = null;
//line 127
___nl__7 = new ImmDouble((Double.Parse(___nl__2.getValue().ToString()))+(Double.Parse(___nl__7.getValue().ToString()))).clone();
//line 127
___nl__6 = wprinter_NL.NL_is_to_long_priv(___nl__7).clone();

//line 127
___nl__7 = null;
//line 127
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 127
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_2;}}
//line 128
___nl__7 = string_NL.NL_lf().clone();

//line 128
wprinter_NL.NL_state_print_priv(ref ___nl__0,___nl__7);

//line 128
___nl__7 = null;
//line 129
___nl__7 = wprinter_NL.NL_pind_priv(___nl__3).clone();

//line 129
wprinter_NL.NL_state_print_priv(ref ___nl__0,___nl__7);

//line 129
___nl__7 = null;
//line 130
___nl__7 = wprinter_NL.NL_get_tab_size_priv().clone();

//line 130
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))*(Double.Parse(___nl__3.getValue().ToString()))).clone();
//line 130
___nl__4 = ___nl__7.clone();
//line 130
___nl__7 = null;
//line 131
if (true) {goto label_2;}
//line 131
label_2:
//line 131
___nl__6 = null;
//line 133
___nl__6 = new ImmDouble(0).clone();
//line 134
___nl__8 = new ImmDouble(0).clone();
//line 134
___nl__9 = new ImmDouble(1).clone();
//line 134
___nl__10 = c_rt_lib_NL.NL_array_len(___nl__5).clone();

//line 134
label_5:
//line 134
___nl__11 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString()))>=(Double.Parse(___nl__10.getValue().ToString())) ).clone();
//line 134
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_3;}}
//line 134
___nl__7 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()].clone();
//line 135
wprinter_NL.NL_state_print_priv(ref ___nl__0,___nl__7);

//line 136
___nl__12 = string_NL.NL_length(___nl__7).clone();

//line 136
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__12.getValue().ToString()))).clone();
//line 136
___nl__12 = null;
//line 137
___nl__12 = array_NL.NL_len(___nl__5).clone();

//line 137
___nl__13 = new ImmDouble(1).clone();
//line 137
___nl__12 = new ImmDouble((Double.Parse(___nl__12.getValue().ToString()))-(Double.Parse(___nl__13.getValue().ToString()))).clone();
//line 137
___nl__13 = null;
//line 137
___nl__12 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__6.getValue().ToString())) !=((Double.Parse(___nl__12.getValue().ToString())))  ).clone();
//line 137
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 137
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_7;}}
//line 138
___nl__13 = string_NL.NL_lf().clone();

//line 138
___nl__14 = wprinter_NL.NL_pind_priv(___nl__3).clone();

//line 138
___nl__13 = new ImmString(___nl__13.toString() + ___nl__14.toString()).clone();
//line 138
___nl__14 = null;
//line 138
wprinter_NL.NL_state_print_priv(ref ___nl__0,___nl__13);

//line 138
___nl__13 = null;
//line 139
___nl__13 = wprinter_NL.NL_get_tab_size_priv().clone();

//line 139
___nl__13 = new ImmDouble((Double.Parse(___nl__13.getValue().ToString()))*(Double.Parse(___nl__3.getValue().ToString()))).clone();
//line 139
___nl__4 = ___nl__13.clone();
//line 139
___nl__13 = null;
//line 140
if (true) {goto label_7;}
//line 140
label_7:
//line 140
___nl__12 = null;
//line 142
___nl__12 = new ImmDouble(1).clone();
//line 142
___nl__6 = new ImmDouble((Double.Parse(___nl__6.getValue().ToString()))+(Double.Parse(___nl__12.getValue().ToString()))).clone();
//line 142
___nl__12 = null;
//line 143
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))+(Double.Parse(___nl__9.getValue().ToString()))).clone();
//line 143
if (true) {goto label_5;}
//line 143
label_3:
//line 143
___nl__7 = null;
//line 143
___nl__8 = null;
//line 143
___nl__9 = null;
//line 143
___nl__10 = null;
//line 143
___nl__11 = null;
//line 144
___nl__7 = ((ImmHash)___nl__1).getHashValue()["last"].clone();
//line 144
___nl__8 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("new_line")).clone();
//line 144
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_9;}}
//line 147
___nl__8 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("end")).clone();
//line 147
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_10;}}
//line 147
___nl__8 = new ImmString("NOMATCHALERT").clone();
//line 147
___nl__8 = new ImmArray(new Imm[] {___nl__8,___nl__7,}).clone();
//line 147
c_rt_lib_NL.NL_die();
//line 144
label_9:
//line 145
___nl__9 = string_NL.NL_lf().clone();

//line 145
___nl__10 = wprinter_NL.NL_pind_priv(___nl__3).clone();

//line 145
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 145
___nl__10 = null;
//line 145
wprinter_NL.NL_state_print_priv(ref ___nl__0,___nl__9);

//line 145
___nl__9 = null;
//line 146
___nl__9 = wprinter_NL.NL_get_tab_size_priv().clone();

//line 146
___nl__9 = new ImmDouble((Double.Parse(___nl__9.getValue().ToString()))*(Double.Parse(___nl__3.getValue().ToString()))).clone();
//line 146
___nl__4 = ___nl__9.clone();
//line 146
___nl__9 = null;
//line 147
if (true) {goto label_8;}
//line 147
label_10:
//line 148
if (true) {goto label_8;}
//line 148
label_8:
//line 148
___nl__7 = null;
//line 148
___nl__8 = null;
//line 149
___nl__1 = null;
//line 149
___nl__2 = null;
//line 149
___nl__3 = null;
//line 149
___nl__5 = null;
//line 149
___nl__6 = null;
//line 149
___arg__0 = ___nl__0;if(true) return ___nl__4;
//line 149
___nl__4 = null;
//line 149
___nl__5 = null;
//line 149
___nl__6 = null;
//line 149
___nl__1 = null;
//line 149
___nl__2 = null;
//line 149
___nl__3 = null;
//line 149
___arg__0 = ___nl__0;if(true) return null;
}

private static Imm NL_print_sim_rec_priv(ref Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0;Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Dictionary<String, Imm> __function_map;
//line 153
___nl__2 = ((ImmHash)___nl__1).getHashValue()["el"].clone();
//line 153
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("sim")).clone();
//line 153
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 155
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("arr")).clone();
//line 155
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 157
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("sep")).clone();
//line 157
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_4;}}
//line 159
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("arr_decl")).clone();
//line 159
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_5;}}
//line 163
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("bind")).clone();
//line 163
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_6;}}
//line 166
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("str_arr")).clone();
//line 166
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_7;}}
//line 166
___nl__3 = new ImmString("NOMATCHALERT").clone();
//line 166
___nl__3 = new ImmArray(new Imm[] {___nl__3,___nl__2,}).clone();
//line 166
c_rt_lib_NL.NL_die();
//line 153
label_2:
//line 153
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("sim")).clone();
//line 154
wprinter_NL.NL_state_print_priv(ref ___nl__0,___nl__4);

//line 154
___nl__4 = null;
//line 155
if (true) {goto label_1;}
//line 155
label_3:
//line 155
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("arr")).clone();
//line 156
___nl__5 = ((ImmHash)___nl__4).getHashValue()["arr"].clone();
//line 156
wprinter_NL.NL_print_sim_arr_priv(ref ___nl__0,___nl__5);

//line 156
___nl__5 = null;
//line 156
___nl__4 = null;
//line 157
if (true) {goto label_1;}
//line 157
label_4:
//line 158
___nl__4 = new ImmString(" ").clone();
//line 158
wprinter_NL.NL_state_print_priv(ref ___nl__0,___nl__4);

//line 158
___nl__4 = null;
//line 159
if (true) {goto label_1;}
//line 159
label_5:
//line 159
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("arr_decl")).clone();
//line 160
___nl__5 = ((ImmHash)___nl__4).getHashValue()["start"].clone();
//line 160
wprinter_NL.NL_state_print_priv(ref ___nl__0,___nl__5);

//line 160
___nl__5 = null;
//line 161
___nl__5 = ((ImmHash)___nl__4).getHashValue()["arr"].clone();
//line 161
wprinter_NL.NL_print_sim_arr_priv(ref ___nl__0,___nl__5);

//line 161
___nl__5 = null;
//line 162
___nl__5 = ((ImmHash)___nl__4).getHashValue()["end"].clone();
//line 162
wprinter_NL.NL_state_print_priv(ref ___nl__0,___nl__5);

//line 162
___nl__5 = null;
//line 162
___nl__4 = null;
//line 163
if (true) {goto label_1;}
//line 163
label_6:
//line 163
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("bind")).clone();
//line 164
___nl__5 = ((ImmHash)___nl__4).getHashValue()["first"].clone();
//line 164
wprinter_NL.NL_print_sim_rec_priv(ref ___nl__0,___nl__5);

//line 164
___nl__5 = null;
//line 165
___nl__5 = ((ImmHash)___nl__4).getHashValue()["second"].clone();
//line 165
wprinter_NL.NL_print_sim_rec_priv(ref ___nl__0,___nl__5);

//line 165
___nl__5 = null;
//line 165
___nl__4 = null;
//line 166
if (true) {goto label_1;}
//line 166
label_7:
//line 166
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("str_arr")).clone();
//line 167
___nl__5 = new ImmArray(new Imm[0]).clone();
//line 167
c_rt_lib_NL.NL_die();
//line 167
___nl__5 = null;
//line 167
___nl__4 = null;
//line 168
if (true) {goto label_1;}
//line 168
label_1:
//line 168
___nl__2 = null;
//line 168
___nl__3 = null;
//line 168
___nl__1 = null;
//line 168
___arg__0 = ___nl__0;if(true) return null;
}

public static Imm NL_print_t(ref Imm ___arg__0, Imm ___arg__1, Imm ___arg__2) {
Imm ___nl__0 = ___arg__0;Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);Imm ___nl__2 = null;c_rt_lib_NL.NL_copy(ref ___nl__2, ___arg__2);
Imm ___nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 172
___nl__3 = wprinter_NL.NL_get_tab_size_priv().clone();

//line 172
___nl__3 = new ImmDouble((Double.Parse(___nl__2.getValue().ToString()))*(Double.Parse(___nl__3.getValue().ToString()))).clone();
//line 172
wprinter_NL.NL_print_t_rec_priv(ref ___nl__0,___nl__1,___nl__3,___nl__2);

//line 172
___nl__3 = null;
//line 172
___nl__1 = null;
//line 172
___nl__2 = null;
//line 172
___arg__0 = ___nl__0;if(true) return null;
}

private static Imm NL_flush_list_priv(ref Imm ___arg__0, Imm ___arg__1, Imm ___arg__2, Imm ___arg__3, Imm ___arg__4, Imm ___arg__5) {
Imm ___nl__0 = ___arg__0;Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);Imm ___nl__2 = null;c_rt_lib_NL.NL_copy(ref ___nl__2, ___arg__2);Imm ___nl__3 = null;c_rt_lib_NL.NL_copy(ref ___nl__3, ___arg__3);Imm ___nl__4 = null;c_rt_lib_NL.NL_copy(ref ___nl__4, ___arg__4);Imm ___nl__5 = null;c_rt_lib_NL.NL_copy(ref ___nl__5, ___arg__5);
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
Imm ___nl__9 = null;
Imm ___nl__10 = null;
Imm ___nl__11 = null;
Imm ___nl__12 = null;
Imm ___nl__13 = null;
Dictionary<String, Imm> __function_map;
//line 177
___nl__6 = wprinter_NL.NL_is_to_long_priv(___nl__3).clone();

//line 177
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 177
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 177
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_2;}}
//line 178
___nl__8 = new ImmDouble(0).clone();
//line 178
___nl__9 = new ImmDouble(1).clone();
//line 178
___nl__10 = c_rt_lib_NL.NL_array_len(___nl__1).clone();

//line 178
label_5:
//line 178
___nl__11 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString()))>=(Double.Parse(___nl__10.getValue().ToString())) ).clone();
//line 178
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_3;}}
//line 178
___nl__7 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()].clone();
//line 179
wprinter_NL.NL_print_sim_rec_priv(ref ___nl__0,___nl__7);

//line 180
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))+(Double.Parse(___nl__9.getValue().ToString()))).clone();
//line 180
if (true) {goto label_5;}
//line 180
label_3:
//line 180
___nl__7 = null;
//line 180
___nl__8 = null;
//line 180
___nl__9 = null;
//line 180
___nl__10 = null;
//line 180
___nl__11 = null;
//line 181
___nl__1 = null;
//line 181
___nl__2 = null;
//line 181
___nl__4 = null;
//line 181
___nl__5 = null;
//line 181
___nl__6 = null;
//line 181
___arg__0 = ___nl__0;if(true) return ___nl__3;
//line 182
if (true) {goto label_1;}
//line 182
label_2:
//line 183
___nl__8 = array_NL.NL_len(___nl__1).clone();

//line 183
___nl__9 = new ImmDouble(1).clone();
//line 183
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))-(Double.Parse(___nl__9.getValue().ToString()))).clone();
//line 183
___nl__9 = null;
//line 183
___nl__7 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()].clone();
//line 183
___nl__8 = null;
//line 183
___nl__7 = ((ImmHash)___nl__7).getHashValue()["el"].clone();
//line 183
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("str_arr")).clone();
//line 183
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 183
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 183
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_7;}}
//line 184
___nl__8 = new ImmDouble(1).clone();
//line 184
___nl__8 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString()))).clone();
//line 184
___nl__10 = wprinter_NL.NL_get_tab_size_priv().clone();

//line 184
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))*(Double.Parse(___nl__10.getValue().ToString()))).clone();
//line 184
___nl__10 = null;
//line 184
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString()))<(Double.Parse(___nl__2.getValue().ToString())) ).clone();
//line 184
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 184
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_10;}}
//line 184
___nl__8 = ___nl__5.clone();
//line 184
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 184
label_10:
//line 184
___nl__9 = null;
//line 184
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 184
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_9;}}
//line 185
___nl__9 = string_NL.NL_lf().clone();

//line 185
___nl__11 = new ImmDouble(1).clone();
//line 185
___nl__11 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__11.getValue().ToString()))).clone();
//line 185
___nl__10 = wprinter_NL.NL_pind_priv(___nl__11).clone();

//line 185
___nl__11 = null;
//line 185
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 185
___nl__10 = null;
//line 185
wprinter_NL.NL_state_print_priv(ref ___nl__0,___nl__9);

//line 185
___nl__9 = null;
//line 186
___nl__9 = new ImmDouble(1).clone();
//line 186
___nl__9 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__9.getValue().ToString()))).clone();
//line 186
___nl__10 = wprinter_NL.NL_get_tab_size_priv().clone();

//line 186
___nl__9 = new ImmDouble((Double.Parse(___nl__9.getValue().ToString()))*(Double.Parse(___nl__10.getValue().ToString()))).clone();
//line 186
___nl__10 = null;
//line 186
___nl__2 = ___nl__9.clone();
//line 186
___nl__9 = null;
//line 187
if (true) {goto label_9;}
//line 187
label_9:
//line 187
___nl__8 = null;
//line 188
if (true) {goto label_7;}
//line 188
label_7:
//line 188
___nl__7 = null;
//line 189
___nl__8 = new ImmDouble(0).clone();
//line 189
___nl__9 = new ImmDouble(1).clone();
//line 189
___nl__10 = c_rt_lib_NL.NL_array_len(___nl__1).clone();

//line 189
label_13:
//line 189
___nl__11 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString()))>=(Double.Parse(___nl__10.getValue().ToString())) ).clone();
//line 189
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_11;}}
//line 189
___nl__7 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()].clone();
//line 190
___nl__13 = new ImmDouble(1).clone();
//line 190
___nl__13 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__13.getValue().ToString()))).clone();
//line 190
___nl__12 = wprinter_NL.NL_print_t_rec_priv(ref ___nl__0,___nl__7,___nl__2,___nl__13).clone();

//line 190
___nl__13 = null;
//line 190
___nl__2 = ___nl__12.clone();
//line 190
___nl__12 = null;
//line 191
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))+(Double.Parse(___nl__9.getValue().ToString()))).clone();
//line 191
if (true) {goto label_13;}
//line 191
label_11:
//line 191
___nl__7 = null;
//line 191
___nl__8 = null;
//line 191
___nl__9 = null;
//line 191
___nl__10 = null;
//line 191
___nl__11 = null;
//line 192
___nl__1 = null;
//line 192
___nl__3 = null;
//line 192
___nl__4 = null;
//line 192
___nl__5 = null;
//line 192
___nl__6 = null;
//line 192
___arg__0 = ___nl__0;if(true) return ___nl__2;
//line 193
if (true) {goto label_1;}
//line 193
label_1:
//line 193
___nl__6 = null;
//line 193
___nl__1 = null;
//line 193
___nl__2 = null;
//line 193
___nl__3 = null;
//line 193
___nl__4 = null;
//line 193
___nl__5 = null;
//line 193
___arg__0 = ___nl__0;if(true) return null;
}

private static Imm NL_print_arr_in_lines_priv(ref Imm ___arg__0, Imm ___arg__1, Imm ___arg__2, Imm ___arg__3) {
Imm ___nl__0 = ___arg__0;Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);Imm ___nl__2 = null;c_rt_lib_NL.NL_copy(ref ___nl__2, ___arg__2);Imm ___nl__3 = null;c_rt_lib_NL.NL_copy(ref ___nl__3, ___arg__3);
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
Imm ___nl__9 = null;
Imm ___nl__10 = null;
Imm ___nl__11 = null;
Dictionary<String, Imm> __function_map;
//line 198
___nl__5 = new ImmDouble(0).clone();
//line 198
___nl__6 = new ImmDouble(1).clone();
//line 198
___nl__7 = c_rt_lib_NL.NL_array_len(___nl__1).clone();

//line 198
label_3:
//line 198
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) ).clone();
//line 198
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_1;}}
//line 198
___nl__4 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()].clone();
//line 199
___nl__10 = ((ImmHash)___nl__4).getHashValue()["el"].clone();
//line 199
___nl__11 = new ImmString("sep").clone();
//line 199
___nl__9 = ov_NL.NL_is(___nl__10,___nl__11).clone();

//line 199
___nl__11 = null;
//line 199
___nl__10 = null;
//line 199
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 199
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_5;}}
//line 200
___nl__10 = string_NL.NL_lf().clone();

//line 200
___nl__11 = wprinter_NL.NL_pind_priv(___nl__2).clone();

//line 200
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString()).clone();
//line 200
___nl__11 = null;
//line 200
wprinter_NL.NL_state_print_priv(ref ___nl__0,___nl__10);

//line 200
___nl__10 = null;
//line 201
___nl__10 = wprinter_NL.NL_get_tab_size_priv().clone();

//line 201
___nl__10 = new ImmDouble((Double.Parse(___nl__2.getValue().ToString()))*(Double.Parse(___nl__10.getValue().ToString()))).clone();
//line 201
___nl__3 = ___nl__10.clone();
//line 201
___nl__10 = null;
//line 202
___nl__9 = null;
//line 202
if (true) {goto label_2;}
//line 203
if (true) {goto label_5;}
//line 203
label_5:
//line 203
___nl__9 = null;
//line 205
___nl__9 = wprinter_NL.NL_print_t_rec_priv(ref ___nl__0,___nl__4,___nl__3,___nl__2).clone();

//line 205
___nl__3 = ___nl__9.clone();
//line 205
___nl__9 = null;
//line 205
label_2:
//line 206
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString()))).clone();
//line 206
if (true) {goto label_3;}
//line 206
label_1:
//line 206
___nl__4 = null;
//line 206
___nl__5 = null;
//line 206
___nl__6 = null;
//line 206
___nl__7 = null;
//line 206
___nl__8 = null;
//line 207
___nl__1 = null;
//line 207
___nl__2 = null;
//line 207
___arg__0 = ___nl__0;if(true) return ___nl__3;
//line 207
___nl__1 = null;
//line 207
___nl__2 = null;
//line 207
___nl__3 = null;
//line 207
___arg__0 = ___nl__0;if(true) return null;
}

private static Imm NL_process_list_priv(ref Imm ___arg__0, Imm ___arg__1, Imm ___arg__2, Imm ___arg__3, Imm ___arg__4) {
Imm ___nl__0 = ___arg__0;Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);Imm ___nl__2 = null;c_rt_lib_NL.NL_copy(ref ___nl__2, ___arg__2);Imm ___nl__3 = null;c_rt_lib_NL.NL_copy(ref ___nl__3, ___arg__3);Imm ___nl__4 = null;c_rt_lib_NL.NL_copy(ref ___nl__4, ___arg__4);
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
Dictionary<String, Imm> __function_map;
//line 212
___nl__5 = new ImmArray(new Imm[0]).clone();
//line 213
___nl__6 = new ImmDouble(0).clone();
//line 214
___nl__7 = c_rt_lib_NL.NL_get_true().clone();
//line 215
___nl__8 = array_NL.NL_len(___nl__1).clone();

//line 215
___nl__9 = new ImmDouble(0).clone();
//line 215
___nl__10 = new ImmDouble(1).clone();
//line 215
label_3:
//line 215
___nl__11 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__9.getValue().ToString()))>=(Double.Parse(___nl__8.getValue().ToString())) ).clone();
//line 215
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_1;}}
//line 216
___nl__12 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()].clone();
//line 217
___nl__14 = ((ImmHash)___nl__12).getHashValue()["el"].clone();
//line 217
___nl__15 = new ImmString("sep").clone();
//line 217
___nl__13 = ov_NL.NL_is(___nl__14,___nl__15).clone();

//line 217
___nl__15 = null;
//line 217
___nl__14 = null;
//line 217
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13)).clone();
//line 217
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_5;}}
//line 218
___nl__15 = new ImmDouble((Double.Parse(___nl__6.getValue().ToString()))+(Double.Parse(___nl__3.getValue().ToString()))).clone();
//line 218
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_7;}}
//line 218
___nl__16 = new ImmDouble(0).clone();
//line 218
if (true) {goto label_6;}
//line 218
label_7:
//line 218
___nl__16 = new ImmDouble(1).clone();
//line 218
label_6:
//line 218
___nl__16 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))-(Double.Parse(___nl__16.getValue().ToString()))).clone();
//line 218
___nl__17 = ___nl__7.clone();
//line 218
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_8;}}
//line 218
___nl__17 = ___nl__2.clone();
//line 218
___nl__17 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__17)).clone();
//line 218
label_8:
//line 218
___nl__14 = wprinter_NL.NL_flush_list_priv(ref ___nl__0,___nl__5,___nl__3,___nl__15,___nl__16,___nl__17).clone();

//line 218
___nl__17 = null;
//line 218
___nl__16 = null;
//line 218
___nl__15 = null;
//line 218
___nl__3 = ___nl__14.clone();
//line 218
___nl__14 = null;
//line 219
___nl__14 = c_rt_lib_NL.NL_get_false().clone();
//line 219
___nl__7 = ___nl__14.clone();
//line 219
___nl__14 = null;
//line 220
___nl__14 = new ImmString(" ").clone();
//line 220
wprinter_NL.NL_state_print_priv(ref ___nl__0,___nl__14);

//line 220
___nl__14 = null;
//line 221
___nl__14 = new ImmDouble(1).clone();
//line 221
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__14.getValue().ToString()))).clone();
//line 221
___nl__14 = null;
//line 222
___nl__14 = new ImmArray(new Imm[0]).clone();
//line 222
___nl__5 = ___nl__14.clone();
//line 222
___nl__14 = null;
//line 223
___nl__14 = new ImmDouble(0).clone();
//line 223
___nl__6 = ___nl__14.clone();
//line 223
___nl__14 = null;
//line 224
if (true) {goto label_4;}
//line 224
label_5:
//line 225
array_NL.NL_push(ref ___nl__5,___nl__12);

//line 226
___nl__14 = ((ImmHash)___nl__12).getHashValue()["len"].clone();
//line 226
___nl__6 = new ImmDouble((Double.Parse(___nl__6.getValue().ToString()))+(Double.Parse(___nl__14.getValue().ToString()))).clone();
//line 226
___nl__14 = null;
//line 227
if (true) {goto label_4;}
//line 227
label_4:
//line 227
___nl__13 = null;
//line 227
___nl__12 = null;
//line 229
___nl__9 = new ImmDouble((Double.Parse(___nl__9.getValue().ToString()))+(Double.Parse(___nl__10.getValue().ToString()))).clone();
//line 229
if (true) {goto label_3;}
//line 229
label_1:
//line 229
___nl__8 = null;
//line 229
___nl__9 = null;
//line 229
___nl__10 = null;
//line 229
___nl__11 = null;
//line 230
___nl__8 = array_NL.NL_len(___nl__5).clone();

//line 230
___nl__9 = new ImmDouble(0).clone();
//line 230
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString()))>(Double.Parse(___nl__9.getValue().ToString())) ).clone();
//line 230
___nl__9 = null;
//line 230
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 230
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_10;}}
//line 230
___nl__10 = new ImmDouble((Double.Parse(___nl__6.getValue().ToString()))+(Double.Parse(___nl__3.getValue().ToString()))).clone();
//line 230
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_12;}}
//line 230
___nl__11 = new ImmDouble(0).clone();
//line 230
if (true) {goto label_11;}
//line 230
label_12:
//line 230
___nl__11 = new ImmDouble(1).clone();
//line 230
label_11:
//line 230
___nl__11 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))-(Double.Parse(___nl__11.getValue().ToString()))).clone();
//line 230
___nl__12 = ___nl__7.clone();
//line 230
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_13;}}
//line 230
___nl__12 = ___nl__2.clone();
//line 230
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 230
label_13:
//line 230
___nl__9 = wprinter_NL.NL_flush_list_priv(ref ___nl__0,___nl__5,___nl__3,___nl__10,___nl__11,___nl__12).clone();

//line 230
___nl__12 = null;
//line 230
___nl__11 = null;
//line 230
___nl__10 = null;
//line 230
___nl__3 = ___nl__9.clone();
//line 230
___nl__9 = null;
//line 230
if (true) {goto label_10;}
//line 230
label_10:
//line 230
___nl__8 = null;
//line 233
___nl__1 = null;
//line 233
___nl__2 = null;
//line 233
___nl__4 = null;
//line 233
___nl__5 = null;
//line 233
___nl__6 = null;
//line 233
___nl__7 = null;
//line 233
___arg__0 = ___nl__0;if(true) return ___nl__3;
//line 233
___nl__5 = null;
//line 233
___nl__6 = null;
//line 233
___nl__7 = null;
//line 233
___nl__1 = null;
//line 233
___nl__2 = null;
//line 233
___nl__3 = null;
//line 233
___nl__4 = null;
//line 233
___arg__0 = ___nl__0;if(true) return null;
}

private static Imm NL_print_t_rec_priv(ref Imm ___arg__0, Imm ___arg__1, Imm ___arg__2, Imm ___arg__3) {
Imm ___nl__0 = ___arg__0;Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);Imm ___nl__2 = null;c_rt_lib_NL.NL_copy(ref ___nl__2, ___arg__2);Imm ___nl__3 = null;c_rt_lib_NL.NL_copy(ref ___nl__3, ___arg__3);
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
Imm ___nl__9 = null;
Imm ___nl__10 = null;
Imm ___nl__11 = null;
Dictionary<String, Imm> __function_map;
//line 237
___nl__5 = ((ImmHash)___nl__1).getHashValue()["len"].clone();
//line 237
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__2.getValue().ToString()))).clone();
//line 237
___nl__4 = wprinter_NL.NL_is_to_long_priv(___nl__5).clone();

//line 237
___nl__5 = null;
//line 237
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 237
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 237
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 238
wprinter_NL.NL_print_sim_rec_priv(ref ___nl__0,___nl__1);

//line 239
___nl__5 = ((ImmHash)___nl__1).getHashValue()["len"].clone();
//line 239
___nl__2 = new ImmDouble((Double.Parse(___nl__2.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 239
___nl__5 = null;
//line 240
___nl__1 = null;
//line 240
___nl__3 = null;
//line 240
___nl__4 = null;
//line 240
___arg__0 = ___nl__0;if(true) return ___nl__2;
//line 241
if (true) {goto label_2;}
//line 241
label_2:
//line 241
___nl__4 = null;
//line 243
___nl__4 = ((ImmHash)___nl__1).getHashValue()["el"].clone();
//line 243
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("sim")).clone();
//line 243
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_4;}}
//line 251
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("arr_decl")).clone();
//line 251
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_5;}}
//line 258
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("arr")).clone();
//line 258
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_6;}}
//line 267
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("bind")).clone();
//line 267
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_7;}}
//line 272
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("sep")).clone();
//line 272
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_8;}}
//line 275
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("str_arr")).clone();
//line 275
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_9;}}
//line 275
___nl__5 = new ImmString("NOMATCHALERT").clone();
//line 275
___nl__5 = new ImmArray(new Imm[] {___nl__5,___nl__4,}).clone();
//line 275
c_rt_lib_NL.NL_die();
//line 243
label_4:
//line 243
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("sim")).clone();
//line 244
___nl__7 = new ImmString(",").clone();
//line 244
___nl__7 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__7.toString())).clone();
//line 244
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_12;}}
//line 244
___nl__7 = new ImmString(")").clone();
//line 244
___nl__7 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__7.toString())).clone();
//line 244
label_12:
//line 244
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 244
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_11;}}
//line 245
wprinter_NL.NL_state_print_priv(ref ___nl__0,___nl__6);

//line 246
___nl__8 = ((ImmHash)___nl__1).getHashValue()["len"].clone();
//line 246
___nl__8 = new ImmDouble((Double.Parse(___nl__2.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString()))).clone();
//line 246
___nl__1 = null;
//line 246
___nl__2 = null;
//line 246
___nl__3 = null;
//line 246
___nl__4 = null;
//line 246
___nl__5 = null;
//line 246
___nl__6 = null;
//line 246
___nl__7 = null;
//line 246
___arg__0 = ___nl__0;if(true) return ___nl__8;
//line 246
___nl__8 = null;
//line 247
if (true) {goto label_11;}
//line 247
label_11:
//line 247
___nl__7 = null;
//line 248
___nl__7 = wprinter_NL.NL_get_tab_size_priv().clone();

//line 248
___nl__7 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))*(Double.Parse(___nl__7.getValue().ToString()))).clone();
//line 248
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__2.getValue().ToString())) !=((Double.Parse(___nl__7.getValue().ToString())))  ).clone();
//line 248
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 248
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_14;}}
//line 248
___nl__8 = string_NL.NL_lf().clone();

//line 248
___nl__9 = wprinter_NL.NL_pind_priv(___nl__3).clone();

//line 248
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 248
___nl__9 = null;
//line 248
wprinter_NL.NL_state_print_priv(ref ___nl__0,___nl__8);

//line 248
___nl__8 = null;
//line 248
if (true) {goto label_14;}
//line 248
label_14:
//line 248
___nl__7 = null;
//line 249
wprinter_NL.NL_print_sim_rec_priv(ref ___nl__0,___nl__1);

//line 250
___nl__7 = ((ImmHash)___nl__1).getHashValue()["len"].clone();
//line 250
___nl__8 = wprinter_NL.NL_get_tab_size_priv().clone();

//line 250
___nl__8 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))*(Double.Parse(___nl__8.getValue().ToString()))).clone();
//line 250
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString()))).clone();
//line 250
___nl__8 = null;
//line 250
___nl__1 = null;
//line 250
___nl__2 = null;
//line 250
___nl__3 = null;
//line 250
___nl__4 = null;
//line 250
___nl__5 = null;
//line 250
___nl__6 = null;
//line 250
___arg__0 = ___nl__0;if(true) return ___nl__7;
//line 250
___nl__7 = null;
//line 250
___nl__6 = null;
//line 251
if (true) {goto label_3;}
//line 251
label_5:
//line 251
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("arr_decl")).clone();
//line 252
___nl__7 = ((ImmHash)___nl__6).getHashValue()["start"].clone();
//line 252
___nl__8 = string_NL.NL_lf().clone();

//line 252
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 252
___nl__8 = null;
//line 252
___nl__9 = new ImmDouble(1).clone();
//line 252
___nl__9 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__9.getValue().ToString()))).clone();
//line 252
___nl__8 = wprinter_NL.NL_pind_priv(___nl__9).clone();

//line 252
___nl__9 = null;
//line 252
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 252
___nl__8 = null;
//line 252
wprinter_NL.NL_state_print_priv(ref ___nl__0,___nl__7);

//line 252
___nl__7 = null;
//line 253
___nl__7 = new ImmDouble(1).clone();
//line 253
___nl__7 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__7.getValue().ToString()))).clone();
//line 253
___nl__8 = wprinter_NL.NL_get_tab_size_priv().clone();

//line 253
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))*(Double.Parse(___nl__8.getValue().ToString()))).clone();
//line 253
___nl__8 = null;
//line 253
___nl__2 = ___nl__7.clone();
//line 253
___nl__7 = null;
//line 254
___nl__8 = ((ImmHash)___nl__6).getHashValue()["arr"].clone();
//line 254
___nl__9 = new ImmDouble(1).clone();
//line 254
___nl__9 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__9.getValue().ToString()))).clone();
//line 254
___nl__7 = wprinter_NL.NL_print_arr_in_lines_priv(ref ___nl__0,___nl__8,___nl__9,___nl__2).clone();

//line 254
___nl__9 = null;
//line 254
___nl__8 = null;
//line 254
___nl__2 = ___nl__7.clone();
//line 254
___nl__7 = null;
//line 255
___nl__8 = ((ImmHash)___nl__6).getHashValue()["arr"].clone();
//line 255
___nl__7 = array_NL.NL_len(___nl__8).clone();

//line 255
___nl__8 = null;
//line 255
___nl__8 = new ImmDouble(0).clone();
//line 255
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))>(Double.Parse(___nl__8.getValue().ToString())) ).clone();
//line 255
___nl__8 = null;
//line 255
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 255
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_16;}}
//line 255
___nl__8 = string_NL.NL_lf().clone();

//line 255
___nl__9 = wprinter_NL.NL_pind_priv(___nl__3).clone();

//line 255
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 255
___nl__9 = null;
//line 255
wprinter_NL.NL_state_print_priv(ref ___nl__0,___nl__8);

//line 255
___nl__8 = null;
//line 255
if (true) {goto label_16;}
//line 255
label_16:
//line 255
___nl__7 = null;
//line 256
___nl__7 = ((ImmHash)___nl__6).getHashValue()["end"].clone();
//line 256
wprinter_NL.NL_state_print_priv(ref ___nl__0,___nl__7);

//line 256
___nl__7 = null;
//line 257
___nl__7 = wprinter_NL.NL_get_tab_size_priv().clone();

//line 257
___nl__7 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))*(Double.Parse(___nl__7.getValue().ToString()))).clone();
//line 257
___nl__9 = ((ImmHash)___nl__6).getHashValue()["end"].clone();
//line 257
___nl__8 = string_NL.NL_length(___nl__9).clone();

//line 257
___nl__9 = null;
//line 257
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString()))).clone();
//line 257
___nl__8 = null;
//line 257
___nl__1 = null;
//line 257
___nl__2 = null;
//line 257
___nl__3 = null;
//line 257
___nl__4 = null;
//line 257
___nl__5 = null;
//line 257
___nl__6 = null;
//line 257
___arg__0 = ___nl__0;if(true) return ___nl__7;
//line 257
___nl__7 = null;
//line 257
___nl__6 = null;
//line 258
if (true) {goto label_3;}
//line 258
label_6:
//line 258
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("arr")).clone();
//line 259
___nl__7 = ((ImmHash)___nl__6).getHashValue()["arr"].clone();
//line 260
___nl__8 = ((ImmHash)___nl__6).getHashValue()["type"].clone();
//line 260
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("array")).clone();
//line 260
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_18;}}
//line 262
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("list")).clone();
//line 262
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_19;}}
//line 264
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("op_list")).clone();
//line 264
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_20;}}
//line 264
___nl__9 = new ImmString("NOMATCHALERT").clone();
//line 264
___nl__9 = new ImmArray(new Imm[] {___nl__9,___nl__8,}).clone();
//line 264
c_rt_lib_NL.NL_die();
//line 260
label_18:
//line 261
___nl__11 = new ImmDouble(1).clone();
//line 261
___nl__11 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__11.getValue().ToString()))).clone();
//line 261
___nl__10 = wprinter_NL.NL_print_arr_in_lines_priv(ref ___nl__0,___nl__7,___nl__11,___nl__2).clone();

//line 261
___nl__11 = null;
//line 261
___nl__2 = ___nl__10.clone();
//line 261
___nl__10 = null;
//line 262
if (true) {goto label_17;}
//line 262
label_19:
//line 263
___nl__11 = c_rt_lib_NL.NL_get_false().clone();
//line 263
___nl__10 = wprinter_NL.NL_process_list_priv(ref ___nl__0,___nl__7,___nl__11,___nl__2,___nl__3).clone();

//line 263
___nl__11 = null;
//line 263
___nl__1 = null;
//line 263
___nl__2 = null;
//line 263
___nl__3 = null;
//line 263
___nl__4 = null;
//line 263
___nl__5 = null;
//line 263
___nl__6 = null;
//line 263
___nl__7 = null;
//line 263
___nl__8 = null;
//line 263
___nl__9 = null;
//line 263
___arg__0 = ___nl__0;if(true) return ___nl__10;
//line 263
___nl__10 = null;
//line 264
if (true) {goto label_17;}
//line 264
label_20:
//line 265
___nl__11 = c_rt_lib_NL.NL_get_true().clone();
//line 265
___nl__10 = wprinter_NL.NL_process_list_priv(ref ___nl__0,___nl__7,___nl__11,___nl__2,___nl__3).clone();

//line 265
___nl__11 = null;
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
___nl__7 = null;
//line 265
___nl__8 = null;
//line 265
___nl__9 = null;
//line 265
___arg__0 = ___nl__0;if(true) return ___nl__10;
//line 265
___nl__10 = null;
//line 266
if (true) {goto label_17;}
//line 266
label_17:
//line 266
___nl__8 = null;
//line 266
___nl__9 = null;
//line 266
___nl__7 = null;
//line 266
___nl__6 = null;
//line 267
if (true) {goto label_3;}
//line 267
label_7:
//line 267
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("bind")).clone();
//line 268
___nl__7 = string_NL.NL_lf().clone();

//line 268
___nl__8 = wprinter_NL.NL_pind_priv(___nl__3).clone();

//line 268
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 268
___nl__8 = null;
//line 268
wprinter_NL.NL_state_print_priv(ref ___nl__0,___nl__7);

//line 268
___nl__7 = null;
//line 269
___nl__7 = ((ImmHash)___nl__6).getHashValue()["first"].clone();
//line 269
___nl__7 = ((ImmHash)___nl__7).getHashValue()["len"].clone();
//line 269
___nl__8 = wprinter_NL.NL_get_tab_size_priv().clone();

//line 269
___nl__8 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))*(Double.Parse(___nl__8.getValue().ToString()))).clone();
//line 269
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString()))).clone();
//line 269
___nl__8 = null;
//line 269
___nl__2 = ___nl__7.clone();
//line 269
___nl__7 = null;
//line 270
___nl__7 = ((ImmHash)___nl__6).getHashValue()["first"].clone();
//line 270
wprinter_NL.NL_print_sim_rec_priv(ref ___nl__0,___nl__7);

//line 270
___nl__7 = null;
//line 271
___nl__8 = ((ImmHash)___nl__6).getHashValue()["second"].clone();
//line 271
___nl__7 = wprinter_NL.NL_print_t_rec_priv(ref ___nl__0,___nl__8,___nl__2,___nl__3).clone();

//line 271
___nl__8 = null;
//line 271
___nl__1 = null;
//line 271
___nl__2 = null;
//line 271
___nl__3 = null;
//line 271
___nl__4 = null;
//line 271
___nl__5 = null;
//line 271
___nl__6 = null;
//line 271
___arg__0 = ___nl__0;if(true) return ___nl__7;
//line 271
___nl__7 = null;
//line 271
___nl__6 = null;
//line 272
if (true) {goto label_3;}
//line 272
label_8:
//line 273
___nl__6 = new ImmString(" ").clone();
//line 273
wprinter_NL.NL_state_print_priv(ref ___nl__0,___nl__6);

//line 273
___nl__6 = null;
//line 274
___nl__6 = new ImmDouble(1).clone();
//line 274
___nl__6 = new ImmDouble((Double.Parse(___nl__2.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString()))).clone();
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
___arg__0 = ___nl__0;if(true) return ___nl__6;
//line 274
___nl__6 = null;
//line 275
if (true) {goto label_3;}
//line 275
label_9:
//line 275
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("str_arr")).clone();
//line 276
___nl__7 = wprinter_NL.NL_print_str_arr_priv(ref ___nl__0,___nl__6,___nl__2,___nl__3).clone();

//line 276
___nl__1 = null;
//line 276
___nl__2 = null;
//line 276
___nl__3 = null;
//line 276
___nl__4 = null;
//line 276
___nl__5 = null;
//line 276
___nl__6 = null;
//line 276
___arg__0 = ___nl__0;if(true) return ___nl__7;
//line 276
___nl__7 = null;
//line 276
___nl__6 = null;
//line 277
if (true) {goto label_3;}
//line 277
label_3:
//line 277
___nl__4 = null;
//line 277
___nl__5 = null;
//line 278
___nl__1 = null;
//line 278
___nl__3 = null;
//line 278
___arg__0 = ___nl__0;if(true) return ___nl__2;
//line 278
___nl__1 = null;
//line 278
___nl__2 = null;
//line 278
___nl__3 = null;
//line 278
___arg__0 = ___nl__0;if(true) return null;
}

}
}