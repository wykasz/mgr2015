using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class ptd_NL {

public static Imm NL_arr(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 12
___nl__1 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ptd_arr"), ___nl__0).clone();
//line 12
___nl__0 = null;
//line 12
if(true) return ___nl__1;
//line 12
___nl__1 = null;
//line 12
___nl__0 = null;
//line 12
if(true) return null;
}

public static Imm NL_rec(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 16
___nl__1 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ptd_rec"), ___nl__0).clone();
//line 16
___nl__0 = null;
//line 16
if(true) return ___nl__1;
//line 16
___nl__1 = null;
//line 16
___nl__0 = null;
//line 16
if(true) return null;
}

public static Imm NL_SINGLETON_sim() {

Imm ___nl__0 = null;
ImmRef ___ref______nl__0 = null;
Dictionary<String, Imm> __function_map;
//line 20
___nl__0 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("ptd_sim")).clone();
//line 20
if(true) return ___nl__0;
//line 20
___nl__0 = null;
//line 20
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_sim = null;
public static Imm NL_sim() {
	if (value__singleton__NL_SINGLETON_sim == null) {
		value__singleton__NL_SINGLETON_sim = NL_SINGLETON_sim();
	}
	return value__singleton__NL_SINGLETON_sim;
}
public static Imm NL_SINGLETON_none() {

Imm ___nl__0 = null;
ImmRef ___ref______nl__0 = null;
Dictionary<String, Imm> __function_map;
//line 24
___nl__0 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("ptd_var_none")).clone();
//line 24
if(true) return ___nl__0;
//line 24
___nl__0 = null;
//line 24
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_none = null;
public static Imm NL_none() {
	if (value__singleton__NL_SINGLETON_none == null) {
		value__singleton__NL_SINGLETON_none = NL_SINGLETON_none();
	}
	return value__singleton__NL_SINGLETON_none;
}
public static Imm NL_SINGLETON_void() {

Imm ___nl__0 = null;
ImmRef ___ref______nl__0 = null;
Dictionary<String, Imm> __function_map;
//line 28
___nl__0 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("ptd_void")).clone();
//line 28
if(true) return ___nl__0;
//line 28
___nl__0 = null;
//line 28
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_void = null;
public static Imm NL_void() {
	if (value__singleton__NL_SINGLETON_void == null) {
		value__singleton__NL_SINGLETON_void = NL_SINGLETON_void();
	}
	return value__singleton__NL_SINGLETON_void;
}
public static Imm NL_hash(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 32
___nl__1 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ptd_hash"), ___nl__0).clone();
//line 32
___nl__0 = null;
//line 32
if(true) return ___nl__1;
//line 32
___nl__1 = null;
//line 32
___nl__0 = null;
//line 32
if(true) return null;
}

public static Imm NL_SINGLETON_ptd_im() {

Imm ___nl__0 = null;
ImmRef ___ref______nl__0 = null;
Dictionary<String, Imm> __function_map;
//line 36
___nl__0 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("ptd_im")).clone();
//line 36
if(true) return ___nl__0;
//line 36
___nl__0 = null;
//line 36
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_ptd_im = null;
public static Imm NL_ptd_im() {
	if (value__singleton__NL_SINGLETON_ptd_im == null) {
		value__singleton__NL_SINGLETON_ptd_im = NL_SINGLETON_ptd_im();
	}
	return value__singleton__NL_SINGLETON_ptd_im;
}
public static Imm NL_var(Imm ___arg__0) {
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
//line 40
__function_map = new Dictionary<String, Imm>();
___nl__1 = new ImmHash(__function_map).clone();
//line 41
___nl__4 = c_rt_lib_NL.NL_init_iter(___nl__0).clone();

//line 41
label_3:
//line 41
___nl__2 = c_rt_lib_NL.NL_is_end_hash(___nl__4).clone();

//line 41
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_1;}}
//line 41
___nl__2 = c_rt_lib_NL.NL_get_key_iter(___nl__4).clone();

//line 41
___nl__3 = c_rt_lib_NL.NL_hash_get_value(___nl__0,___nl__2).clone();

//line 43
___nl__6 = ___nl__3.clone();
//line 43
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("ptd_var_none")).clone();
//line 43
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 43
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_5;}}
//line 44
___nl__7 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("no_param")).clone();
//line 44
___nl__5 = ___nl__7.clone();
//line 44
___nl__7 = null;
//line 45
if (true) {goto label_4;}
//line 45
label_5:
//line 46
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("with_param"), ___nl__3).clone();
//line 46
___nl__5 = ___nl__7.clone();
//line 46
___nl__7 = null;
//line 47
if (true) {goto label_4;}
//line 47
label_4:
//line 47
___nl__6 = null;
//line 48
___ref______nl__1 = new ImmRef(___nl__1);
hash_NL.NL_set_value(___ref______nl__1,___nl__2,___nl__5);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 48
___nl__5 = null;
//line 49
___nl__4 = c_rt_lib_NL.NL_next_iter(___nl__4).clone();

//line 49
if (true) {goto label_3;}
//line 49
label_1:
//line 49
___nl__2 = null;
//line 49
___nl__3 = null;
//line 49
___nl__4 = null;
//line 50
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("ptd_NL"));
__function_map.Add("name",new ImmString("meta_type"));
___nl__3 = new ImmHash(__function_map).clone();
//line 50
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3).clone();
//line 50
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ptd_var"), ___nl__1).clone();
//line 50
___nl__2 = ptd_NL.NL_ensure_only_static_do_not_touch_without_permission(___nl__3,___nl__4).clone();

//line 50
___nl__4 = null;
//line 50
___nl__3 = null;
//line 50
___nl__0 = null;
//line 50
___nl__1 = null;
//line 50
if(true) return ___nl__2;
//line 50
___nl__2 = null;
//line 50
___nl__1 = null;
//line 50
___nl__0 = null;
//line 50
if(true) return null;
}

public static Imm NL_meta_type() {

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
//line 54
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("ptd_NL"));
__function_map.Add("name",new ImmString("meta_type"));
___nl__3 = new ImmHash(__function_map).clone();
//line 54
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3).clone();
//line 54
___nl__2 = ptd_NL.NL_hash(___nl__3).clone();

//line 54
___nl__3 = null;
//line 54
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("ptd_NL"));
__function_map.Add("name",new ImmString("meta_type"));
___nl__3 = new ImmHash(__function_map).clone();
//line 54
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3).clone();
//line 54
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("ptd_NL"));
__function_map.Add("name",new ImmString("meta_type"));
___nl__4 = new ImmHash(__function_map).clone();
//line 54
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__4).clone();
//line 54
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("ptd_NL"));
__function_map.Add("name",new ImmString("meta_type"));
___nl__8 = new ImmHash(__function_map).clone();
//line 54
___nl__8 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__8).clone();
//line 54
___nl__9 = ptd_NL.NL_none().clone();

//line 54
__function_map = new Dictionary<String, Imm>();
__function_map.Add("with_param",___nl__8);
__function_map.Add("no_param",___nl__9);
___nl__7 = new ImmHash(__function_map).clone();
//line 54
___nl__8 = null;
//line 54
___nl__9 = null;
//line 54
___nl__6 = ptd_NL.NL_var(___nl__7).clone();

//line 54
___nl__7 = null;
//line 54
___nl__5 = ptd_NL.NL_hash(___nl__6).clone();

//line 54
___nl__6 = null;
//line 54
___nl__6 = ptd_NL.NL_sim().clone();

//line 54
___nl__7 = ptd_NL.NL_none().clone();

//line 54
___nl__8 = ptd_NL.NL_none().clone();

//line 54
__function_map = new Dictionary<String, Imm>();
__function_map.Add("ptd_rec",___nl__2);
__function_map.Add("ptd_hash",___nl__3);
__function_map.Add("ptd_arr",___nl__4);
__function_map.Add("ptd_var",___nl__5);
__function_map.Add("ref",___nl__6);
__function_map.Add("ptd_sim",___nl__7);
__function_map.Add("ptd_im",___nl__8);
___nl__1 = new ImmHash(__function_map).clone();
//line 54
___nl__2 = null;
//line 54
___nl__3 = null;
//line 54
___nl__4 = null;
//line 54
___nl__5 = null;
//line 54
___nl__6 = null;
//line 54
___nl__7 = null;
//line 54
___nl__8 = null;
//line 54
___nl__0 = ptd_NL.NL_var(___nl__1).clone();

//line 54
___nl__1 = null;
//line 54
if(true) return ___nl__0;
//line 54
___nl__0 = null;
//line 54
if(true) return null;
}

public static Imm NL_ensure(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 66
ptd_NL.NL_ensure_dyn(___nl__0,___nl__1);

//line 67
___nl__0 = null;
//line 67
if(true) return ___nl__1;
//line 67
___nl__0 = null;
//line 67
___nl__1 = null;
//line 67
if(true) return null;
}

public static Imm NL_ensure_only_dynamic(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 71
ptd_NL.NL_ensure_dyn(___nl__0,___nl__1);

//line 72
___nl__0 = null;
//line 72
if(true) return ___nl__1;
//line 72
___nl__0 = null;
//line 72
___nl__1 = null;
//line 72
if(true) return null;
}

public static Imm NL_ensure_only_static_do_not_touch_without_permission(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 77
___nl__0 = null;
//line 77
if(true) return ___nl__1;
//line 77
___nl__0 = null;
//line 77
___nl__1 = null;
//line 77
if(true) return null;
}

public static Imm NL_ensure_dyn(Imm ___arg__0, Imm ___arg__1) {
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
//line 80
___nl__2 = c_std_lib_NL.NL_is_variant(___nl__0).clone();

//line 80
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 80
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 80
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 80
___nl__4 = new ImmString("1 Not ov reference in ensure").clone();
//line 80
___nl__3 = new ImmArray(new Imm[] {___nl__4,}).clone();
//line 80
___nl__4 = null;
//line 80
c_rt_lib_NL.NL_die();
//line 80
if (true) {goto label_2;}
//line 80
label_2:
//line 80
___nl__2 = null;
//line 80
___nl__3 = null;
//line 81
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("ptd_hash")).clone();
//line 81
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_4;}}
//line 86
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("ptd_arr")).clone();
//line 86
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_5;}}
//line 91
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("ptd_rec")).clone();
//line 91
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_6;}}
//line 98
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("ptd_sim")).clone();
//line 98
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_7;}}
//line 100
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("ptd_var")).clone();
//line 100
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_8;}}
//line 111
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("ptd_im")).clone();
//line 111
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_9;}}
//line 112
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("ref")).clone();
//line 112
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_10;}}
//line 112
___nl__2 = new ImmString("NOMATCHALERT").clone();
//line 112
___nl__2 = new ImmArray(new Imm[] {___nl__2,___nl__0,}).clone();
//line 112
c_rt_lib_NL.NL_die();
//line 81
label_4:
//line 81
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("ptd_hash")).clone();
//line 82
___nl__4 = c_std_lib_NL.NL_is_hash(___nl__1).clone();

//line 82
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 82
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 82
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_12;}}
//line 82
___nl__6 = new ImmString("2 HASH ref expected ").clone();
//line 82
___nl__5 = new ImmArray(new Imm[] {___nl__6,}).clone();
//line 82
___nl__6 = null;
//line 82
c_rt_lib_NL.NL_die();
//line 82
if (true) {goto label_12;}
//line 82
label_12:
//line 82
___nl__4 = null;
//line 82
___nl__5 = null;
//line 83
___nl__6 = c_rt_lib_NL.NL_init_iter(___nl__1).clone();

//line 83
label_15:
//line 83
___nl__4 = c_rt_lib_NL.NL_is_end_hash(___nl__6).clone();

//line 83
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_13;}}
//line 83
___nl__4 = c_rt_lib_NL.NL_get_key_iter(___nl__6).clone();

//line 83
___nl__5 = c_rt_lib_NL.NL_hash_get_value(___nl__1,___nl__4).clone();

//line 84
ptd_NL.NL_ensure_dyn(___nl__3,___nl__5);

//line 85
___nl__6 = c_rt_lib_NL.NL_next_iter(___nl__6).clone();

//line 85
if (true) {goto label_15;}
//line 85
label_13:
//line 85
___nl__4 = null;
//line 85
___nl__5 = null;
//line 85
___nl__6 = null;
//line 85
___nl__3 = null;
//line 86
if (true) {goto label_3;}
//line 86
label_5:
//line 86
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("ptd_arr")).clone();
//line 87
___nl__4 = c_std_lib_NL.NL_is_array(___nl__1).clone();

//line 87
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 87
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 87
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_17;}}
//line 87
___nl__6 = new ImmString("3 ARRAY ref expected ").clone();
//line 87
___nl__5 = new ImmArray(new Imm[] {___nl__6,}).clone();
//line 87
___nl__6 = null;
//line 87
c_rt_lib_NL.NL_die();
//line 87
if (true) {goto label_17;}
//line 87
label_17:
//line 87
___nl__4 = null;
//line 87
___nl__5 = null;
//line 88
___nl__5 = new ImmDouble(0).clone();
//line 88
___nl__6 = new ImmDouble(1).clone();
//line 88
___nl__7 = c_rt_lib_NL.NL_array_len(___nl__1).clone();

//line 88
label_20:
//line 88
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) ).clone();
//line 88
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_18;}}
//line 88
___nl__4 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()].clone();
//line 89
ptd_NL.NL_ensure_dyn(___nl__3,___nl__4);

//line 90
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString()))).clone();
//line 90
if (true) {goto label_20;}
//line 90
label_18:
//line 90
___nl__4 = null;
//line 90
___nl__5 = null;
//line 90
___nl__6 = null;
//line 90
___nl__7 = null;
//line 90
___nl__8 = null;
//line 90
___nl__3 = null;
//line 91
if (true) {goto label_3;}
//line 91
label_6:
//line 91
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("ptd_rec")).clone();
//line 92
___nl__4 = c_std_lib_NL.NL_is_hash(___nl__1).clone();

//line 92
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 92
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 92
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_22;}}
//line 92
___nl__6 = new ImmString("4 HASH ref expected ").clone();
//line 92
___nl__5 = new ImmArray(new Imm[] {___nl__6,}).clone();
//line 92
___nl__6 = null;
//line 92
c_rt_lib_NL.NL_die();
//line 92
if (true) {goto label_22;}
//line 92
label_22:
//line 92
___nl__4 = null;
//line 92
___nl__5 = null;
//line 93
___nl__4 = hash_NL.NL_size(___nl__3).clone();

//line 93
___nl__5 = hash_NL.NL_size(___nl__1).clone();

//line 93
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString())) ==((Double.Parse(___nl__5.getValue().ToString())))  ).clone();
//line 93
___nl__5 = null;
//line 93
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 93
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 93
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_24;}}
//line 93
___nl__6 = new ImmString("5 keys amount mismatch in ptd_rec").clone();
//line 93
___nl__5 = new ImmArray(new Imm[] {___nl__6,}).clone();
//line 93
___nl__6 = null;
//line 93
c_rt_lib_NL.NL_die();
//line 93
if (true) {goto label_24;}
//line 93
label_24:
//line 93
___nl__4 = null;
//line 93
___nl__5 = null;
//line 94
___nl__6 = c_rt_lib_NL.NL_init_iter(___nl__3).clone();

//line 94
label_27:
//line 94
___nl__4 = c_rt_lib_NL.NL_is_end_hash(___nl__6).clone();

//line 94
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_25;}}
//line 94
___nl__4 = c_rt_lib_NL.NL_get_key_iter(___nl__6).clone();

//line 94
___nl__5 = c_rt_lib_NL.NL_hash_get_value(___nl__3,___nl__4).clone();

//line 95
___nl__7 = hash_NL.NL_has_key(___nl__1,___nl__4).clone();

//line 95
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 95
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 95
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_29;}}
//line 95
___nl__9 = new ImmString("6 key ").clone();
//line 95
___nl__9 = new ImmString(___nl__9.toString() + ___nl__4.toString()).clone();
//line 95
___nl__10 = new ImmString(" not exists in hash").clone();
//line 95
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 95
___nl__10 = null;
//line 95
___nl__8 = new ImmArray(new Imm[] {___nl__9,}).clone();
//line 95
___nl__9 = null;
//line 95
c_rt_lib_NL.NL_die();
//line 95
if (true) {goto label_29;}
//line 95
label_29:
//line 95
___nl__7 = null;
//line 95
___nl__8 = null;
//line 96
___nl__7 = hash_NL.NL_get_value(___nl__1,___nl__4).clone();

//line 96
ptd_NL.NL_ensure_dyn(___nl__5,___nl__7);

//line 96
___nl__7 = null;
//line 97
___nl__6 = c_rt_lib_NL.NL_next_iter(___nl__6).clone();

//line 97
if (true) {goto label_27;}
//line 97
label_25:
//line 97
___nl__4 = null;
//line 97
___nl__5 = null;
//line 97
___nl__6 = null;
//line 97
___nl__3 = null;
//line 98
if (true) {goto label_3;}
//line 98
label_7:
//line 99
___nl__3 = c_std_lib_NL.NL_is_sim(___nl__1).clone();

//line 99
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 99
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 99
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_31;}}
//line 99
___nl__5 = new ImmString("8 wrong sim ref ").clone();
//line 99
___nl__4 = new ImmArray(new Imm[] {___nl__5,}).clone();
//line 99
___nl__5 = null;
//line 99
c_rt_lib_NL.NL_die();
//line 99
if (true) {goto label_31;}
//line 99
label_31:
//line 99
___nl__3 = null;
//line 99
___nl__4 = null;
//line 100
if (true) {goto label_3;}
//line 100
label_8:
//line 100
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("ptd_var")).clone();
//line 101
___nl__4 = c_std_lib_NL.NL_is_variant(___nl__1).clone();

//line 101
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 101
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 101
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_33;}}
//line 101
___nl__6 = new ImmString("9 not ov ref").clone();
//line 101
___nl__5 = new ImmArray(new Imm[] {___nl__6,}).clone();
//line 101
___nl__6 = null;
//line 101
c_rt_lib_NL.NL_die();
//line 101
if (true) {goto label_33;}
//line 101
label_33:
//line 101
___nl__4 = null;
//line 101
___nl__5 = null;
//line 102
___nl__4 = ov_NL.NL_get_element(___nl__1).clone();

//line 103
___nl__5 = hash_NL.NL_has_key(___nl__3,___nl__4).clone();

//line 103
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 103
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 103
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_35;}}
//line 103
___nl__7 = new ImmString("10 Case ").clone();
//line 103
___nl__7 = new ImmString(___nl__7.toString() + ___nl__4.toString()).clone();
//line 103
___nl__8 = new ImmString(" not allowed in variant. ").clone();
//line 103
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 103
___nl__8 = null;
//line 103
___nl__6 = new ImmArray(new Imm[] {___nl__7,}).clone();
//line 103
___nl__7 = null;
//line 103
c_rt_lib_NL.NL_die();
//line 103
if (true) {goto label_35;}
//line 103
label_35:
//line 103
___nl__5 = null;
//line 103
___nl__6 = null;
//line 104
___nl__5 = hash_NL.NL_get_value(___nl__3,___nl__4).clone();

//line 105
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("with_param")).clone();
//line 105
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_37;}}
//line 108
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("no_param")).clone();
//line 108
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_38;}}
//line 108
___nl__6 = new ImmString("NOMATCHALERT").clone();
//line 108
___nl__6 = new ImmArray(new Imm[] {___nl__6,___nl__5,}).clone();
//line 108
c_rt_lib_NL.NL_die();
//line 105
label_37:
//line 105
___nl__7 = c_rt_lib_NL.NL_ov_as(___nl__5, new ImmString("with_param")).clone();
//line 106
___nl__8 = ov_NL.NL_has_value(___nl__1).clone();

//line 106
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 106
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 106
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_40;}}
//line 106
___nl__10 = new ImmString("12 with_param ov has no value").clone();
//line 106
___nl__9 = new ImmArray(new Imm[] {___nl__10,}).clone();
//line 106
___nl__10 = null;
//line 106
c_rt_lib_NL.NL_die();
//line 106
if (true) {goto label_40;}
//line 106
label_40:
//line 106
___nl__8 = null;
//line 106
___nl__9 = null;
//line 107
___nl__8 = ov_NL.NL_get_value(___nl__1).clone();

//line 107
ptd_NL.NL_ensure_dyn(___nl__7,___nl__8);

//line 107
___nl__8 = null;
//line 107
___nl__7 = null;
//line 108
if (true) {goto label_36;}
//line 108
label_38:
//line 109
___nl__7 = ov_NL.NL_has_value(___nl__1).clone();

//line 109
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 109
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_42;}}
//line 109
___nl__9 = new ImmString("11 no_param ov has value").clone();
//line 109
___nl__8 = new ImmArray(new Imm[] {___nl__9,}).clone();
//line 109
___nl__9 = null;
//line 109
c_rt_lib_NL.NL_die();
//line 109
if (true) {goto label_42;}
//line 109
label_42:
//line 109
___nl__7 = null;
//line 109
___nl__8 = null;
//line 110
if (true) {goto label_36;}
//line 110
label_36:
//line 110
___nl__6 = null;
//line 110
___nl__4 = null;
//line 110
___nl__5 = null;
//line 110
___nl__3 = null;
//line 111
if (true) {goto label_3;}
//line 111
label_9:
//line 112
if (true) {goto label_3;}
//line 112
label_10:
//line 112
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("ref")).clone();
//line 113
___nl__5 = new ImmArray(new Imm[0]).clone();
//line 113
___nl__4 = ptd_NL.NL_exec_priv(___nl__0,___nl__5).clone();

//line 113
___nl__5 = null;
//line 113
ptd_NL.NL_ensure_dyn(___nl__4,___nl__1);

//line 113
___nl__4 = null;
//line 113
___nl__3 = null;
//line 114
if (true) {goto label_3;}
//line 114
label_3:
//line 114
___nl__2 = null;
//line 114
___nl__0 = null;
//line 114
___nl__1 = null;
//line 114
if(true) return null;
}

public static Imm NL_is_ref_type(Imm ___arg__0, Imm ___arg__1) {
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
//line 118
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("ref")).clone();
//line 118
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 128
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("ptd_im")).clone();
//line 128
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_3;}}
//line 129
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("ptd_sim")).clone();
//line 129
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_4;}}
//line 130
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("ptd_arr")).clone();
//line 130
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_5;}}
//line 131
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("ptd_var")).clone();
//line 131
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_6;}}
//line 132
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("ptd_rec")).clone();
//line 132
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_7;}}
//line 133
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("ptd_hash")).clone();
//line 133
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_8;}}
//line 133
___nl__2 = new ImmString("NOMATCHALERT").clone();
//line 133
___nl__2 = new ImmArray(new Imm[] {___nl__2,___nl__0,}).clone();
//line 133
c_rt_lib_NL.NL_die();
//line 118
label_2:
//line 118
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("ref")).clone();
//line 119
___nl__4 = ___nl__1.clone();
//line 119
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("ref")).clone();
//line 119
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 119
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 119
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_10;}}
//line 119
___nl__5 = c_rt_lib_NL.NL_get_false().clone();
//line 119
___nl__0 = null;
//line 119
___nl__1 = null;
//line 119
___nl__2 = null;
//line 119
___nl__3 = null;
//line 119
___nl__4 = null;
//line 119
if(true) return ___nl__5;
//line 119
___nl__5 = null;
//line 119
if (true) {goto label_10;}
//line 119
label_10:
//line 119
___nl__4 = null;
//line 120
___nl__4 = ___nl__1.clone();
//line 120
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("ref")).clone();
//line 121
___nl__5 = c_std_lib_NL.NL_is_hash(___nl__4).clone();

//line 121
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 121
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_12;}}
//line 122
___nl__6 = ((ImmHash)___nl__4).getHashValue()["module"].clone();
//line 122
___nl__7 = ((ImmHash)___nl__3).getHashValue()["module"].clone();
//line 122
___nl__6 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__7.toString())).clone();
//line 122
___nl__7 = null;
//line 122
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 122
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 122
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_14;}}
//line 122
___nl__7 = c_rt_lib_NL.NL_get_false().clone();
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
___nl__6 = null;
//line 122
if(true) return ___nl__7;
//line 122
___nl__7 = null;
//line 122
if (true) {goto label_14;}
//line 122
label_14:
//line 122
___nl__6 = null;
//line 123
___nl__6 = ((ImmHash)___nl__4).getHashValue()["name"].clone();
//line 123
___nl__7 = ((ImmHash)___nl__3).getHashValue()["name"].clone();
//line 123
___nl__6 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__7.toString())).clone();
//line 123
___nl__7 = null;
//line 123
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 123
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 123
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_16;}}
//line 123
___nl__7 = c_rt_lib_NL.NL_get_false().clone();
//line 123
___nl__0 = null;
//line 123
___nl__1 = null;
//line 123
___nl__2 = null;
//line 123
___nl__3 = null;
//line 123
___nl__4 = null;
//line 123
___nl__5 = null;
//line 123
___nl__6 = null;
//line 123
if(true) return ___nl__7;
//line 123
___nl__7 = null;
//line 123
if (true) {goto label_16;}
//line 123
label_16:
//line 123
___nl__6 = null;
//line 124
if (true) {goto label_11;}
//line 124
label_12:
//line 125
___nl__6 = c_rt_lib_NL.NL_native_to_nl(___nl__4.toString().Equals(___nl__3.toString())).clone();
//line 125
___nl__0 = null;
//line 125
___nl__1 = null;
//line 125
___nl__2 = null;
//line 125
___nl__3 = null;
//line 125
___nl__4 = null;
//line 125
___nl__5 = null;
//line 125
if(true) return ___nl__6;
//line 125
___nl__6 = null;
//line 126
if (true) {goto label_11;}
//line 126
label_11:
//line 126
___nl__5 = null;
//line 127
___nl__5 = c_rt_lib_NL.NL_get_true().clone();
//line 127
___nl__0 = null;
//line 127
___nl__1 = null;
//line 127
___nl__2 = null;
//line 127
___nl__3 = null;
//line 127
___nl__4 = null;
//line 127
if(true) return ___nl__5;
//line 127
___nl__5 = null;
//line 127
___nl__4 = null;
//line 127
___nl__3 = null;
//line 128
if (true) {goto label_1;}
//line 128
label_3:
//line 129
if (true) {goto label_1;}
//line 129
label_4:
//line 130
if (true) {goto label_1;}
//line 130
label_5:
//line 130
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("ptd_arr")).clone();
//line 130
___nl__3 = null;
//line 131
if (true) {goto label_1;}
//line 131
label_6:
//line 131
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("ptd_var")).clone();
//line 131
___nl__3 = null;
//line 132
if (true) {goto label_1;}
//line 132
label_7:
//line 132
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("ptd_rec")).clone();
//line 132
___nl__3 = null;
//line 133
if (true) {goto label_1;}
//line 133
label_8:
//line 133
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("ptd_hash")).clone();
//line 133
___nl__3 = null;
//line 134
if (true) {goto label_1;}
//line 134
label_1:
//line 134
___nl__2 = null;
//line 135
___nl__2 = c_rt_lib_NL.NL_get_false().clone();
//line 135
___nl__0 = null;
//line 135
___nl__1 = null;
//line 135
if(true) return ___nl__2;
//line 135
___nl__2 = null;
//line 135
___nl__0 = null;
//line 135
___nl__1 = null;
//line 135
if(true) return null;
}

private static Imm NL_exec_priv(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();
Imm ___nl__2 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 139
___ref______nl__1 = new ImmRef(___nl__1);
___nl__2 = c_std_lib_NL.NL_exec(___nl__0,___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 139
___nl__0 = null;
//line 139
___nl__1 = null;
//line 139
if(true) return ___nl__2;
//line 139
___nl__2 = null;
//line 139
___nl__0 = null;
//line 139
___nl__1 = null;
//line 139
if(true) return null;
}

}
}