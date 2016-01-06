using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class test_type_NL {

public static Imm NL_SINGLETON_test() {

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
//line 12
___nl__1 = new ImmString("nothing").clone();
//line 12
___nl__1 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("a"), ___nl__1).clone();
//line 12
___nl__0 = test_type_NL.NL_funkcja_priv(___nl__1).clone();

//line 12
___nl__1 = null;
//line 13
___nl__1 = ___nl__0.clone();
//line 14
___nl__3 = new ImmArray(new Imm[0]).clone();
//line 14
__function_map = new Dictionary<String, Imm>();
__function_map.Add("a",___nl__3);
___nl__2 = new ImmHash(__function_map).clone();
//line 14
___nl__3 = null;
//line 15
___nl__3 = new ImmString("a").clone();
//line 15
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__2,___nl__3).clone();

//line 15
___ref______nl__3 = new ImmRef(___nl__3);
array_NL.NL_push(___ref______nl__3,___nl__0);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 15
___nl__4 = new ImmString("a").clone();
//line 15
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__2,___nl__4,___nl__3);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 15
___nl__4 = null;
//line 15
___nl__3 = null;
//line 16
___nl__3 = new ImmString("a").clone();
//line 16
___nl__4 = new ImmArray(new Imm[] {___nl__0,}).clone();
//line 16
___ref______nl__2 = new ImmRef(___nl__2);
hash_NL.NL_set_value(___ref______nl__2,___nl__3,___nl__4);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 16
___nl__4 = null;
//line 16
___nl__3 = null;
//line 17
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("stolik")).clone();
//line 18
___nl__4 = new ImmString("nic").clone();
//line 18
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("a"), ___nl__4).clone();
//line 18
___nl__3 = ___nl__4.clone();
//line 18
___nl__4 = null;
//line 19
___nl__5 = new ImmString("").clone();
//line 19
__function_map = new Dictionary<String, Imm>();
__function_map.Add("g",___nl__5);
___nl__4 = new ImmHash(__function_map).clone();
//line 19
___nl__5 = null;
//line 20
___nl__5 = c_rt_lib_NL.NL_get_true().clone();
//line 20
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 20
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_2;}}
//line 21
___nl__6 = new ImmString("").clone();
//line 21
___nl__7 = ___nl__6.clone();
//line 21
((ImmHash)___nl__4).set("h", ___nl__7);
//line 21
___nl__6 = null;
//line 21
___nl__7 = null;
//line 22
if (true) {goto label_1;}
//line 22
label_2:
//line 23
___nl__6 = new ImmString("s").clone();
//line 23
___nl__7 = ___nl__6.clone();
//line 23
((ImmHash)___nl__4).set("h", ___nl__7);
//line 23
___nl__6 = null;
//line 23
___nl__7 = null;
//line 24
if (true) {goto label_1;}
//line 24
label_1:
//line 24
___nl__5 = null;
//line 25
___nl__5 = c_rt_lib_NL.NL_get_false().clone();
//line 25
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 25
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_4;}}
//line 26
___nl__6 = new ImmString("nic").clone();
//line 26
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("a"), ___nl__6).clone();
//line 26
___nl__3 = ___nl__6.clone();
//line 26
___nl__6 = null;
//line 27
if (true) {goto label_3;}
//line 27
label_4:
//line 28
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("d"), ___nl__4).clone();
//line 28
___nl__3 = ___nl__6.clone();
//line 28
___nl__6 = null;
//line 29
if (true) {goto label_3;}
//line 29
label_3:
//line 29
___nl__5 = null;
//line 30
___nl__5 = c_rt_lib_NL.NL_get_true().clone();
//line 30
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 30
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_6;}}
//line 31
___nl__7 = new ImmString("ss").clone();
//line 31
___nl__8 = new ImmString("ff").clone();
//line 31
__function_map = new Dictionary<String, Imm>();
__function_map.Add("a",___nl__7);
__function_map.Add("c",___nl__8);
___nl__6 = new ImmHash(__function_map).clone();
//line 31
___nl__7 = null;
//line 31
___nl__8 = null;
//line 31
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("b"), ___nl__6).clone();
//line 31
___nl__3 = ___nl__6.clone();
//line 31
___nl__6 = null;
//line 32
if (true) {goto label_5;}
//line 32
label_6:
//line 33
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("kotek")).clone();
//line 33
___nl__3 = ___nl__6.clone();
//line 33
___nl__6 = null;
//line 34
___nl__6 = new ImmArray(new Imm[0]).clone();
//line 34
c_rt_lib_NL.NL_die();
//line 34
___nl__6 = null;
//line 35
if (true) {goto label_5;}
//line 35
label_5:
//line 35
___nl__5 = null;
//line 36
test_type_NL.NL_funkcja_priv(___nl__3);

//line 36
___nl__0 = null;
//line 36
___nl__1 = null;
//line 36
___nl__2 = null;
//line 36
___nl__3 = null;
//line 36
___nl__4 = null;
//line 36
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_test = null;
public static Imm NL_test() {
	if (value__singleton__NL_SINGLETON_test == null) {
		value__singleton__NL_SINGLETON_test = NL_SINGLETON_test();
	}
	return value__singleton__NL_SINGLETON_test;
}
private static Imm NL_SINGLETON_cos_priv() {

Imm ___nl__0 = null;
ImmRef ___ref______nl__0 = null;
Dictionary<String, Imm> __function_map;
//line 39
___nl__0 = new ImmString("").clone();
//line 39
___nl__0 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("h"), ___nl__0).clone();
//line 39
if(true) return ___nl__0;
//line 39
___nl__0 = null;
//line 39
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_cos_priv = null;
private static Imm NL_cos_priv() {
	if (value__singleton__NL_SINGLETON_cos_priv == null) {
		value__singleton__NL_SINGLETON_cos_priv = NL_SINGLETON_cos_priv();
	}
	return value__singleton__NL_SINGLETON_cos_priv;
}
private static Imm NL_f_priv(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 42
___nl__1 = ___nl__0.clone();
//line 43
___nl__2 = test_type_NL.NL_cos_priv().clone();

//line 43
___nl__3 = ___nl__2.clone();
//line 43
((ImmHash)___nl__1).set("h", ___nl__3);
//line 43
___nl__2 = null;
//line 43
___nl__3 = null;
//line 44
___nl__0 = null;
//line 44
if(true) return ___nl__1;
//line 44
___nl__1 = null;
//line 44
___nl__0 = null;
//line 44
if(true) return null;
}

public static Imm NL_SINGLETON_typ1() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 47
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("test_type_NL"));
__function_map.Add("name",new ImmString("typ2"));
___nl__2 = new ImmHash(__function_map).clone();
//line 47
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2).clone();
//line 47
___nl__3 = ptd_NL.NL_sim().clone();

//line 47
__function_map = new Dictionary<String, Imm>();
__function_map.Add("g",___nl__2);
__function_map.Add("h",___nl__3);
___nl__1 = new ImmHash(__function_map).clone();
//line 47
___nl__2 = null;
//line 47
___nl__3 = null;
//line 47
___nl__0 = ptd_NL.NL_var(___nl__1).clone();

//line 47
___nl__1 = null;
//line 47
if(true) return ___nl__0;
//line 47
___nl__0 = null;
//line 47
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_typ1 = null;
public static Imm NL_typ1() {
	if (value__singleton__NL_SINGLETON_typ1 == null) {
		value__singleton__NL_SINGLETON_typ1 = NL_SINGLETON_typ1();
	}
	return value__singleton__NL_SINGLETON_typ1;
}
public static Imm NL_SINGLETON_typ2() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 51
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("test_type_NL"));
__function_map.Add("name",new ImmString("typ1"));
___nl__2 = new ImmHash(__function_map).clone();
//line 51
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2).clone();
//line 51
___nl__3 = ptd_NL.NL_sim().clone();

//line 51
__function_map = new Dictionary<String, Imm>();
__function_map.Add("g",___nl__2);
__function_map.Add("h",___nl__3);
___nl__1 = new ImmHash(__function_map).clone();
//line 51
___nl__2 = null;
//line 51
___nl__3 = null;
//line 51
___nl__0 = ptd_NL.NL_var(___nl__1).clone();

//line 51
___nl__1 = null;
//line 51
if(true) return ___nl__0;
//line 51
___nl__0 = null;
//line 51
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_typ2 = null;
public static Imm NL_typ2() {
	if (value__singleton__NL_SINGLETON_typ2 == null) {
		value__singleton__NL_SINGLETON_typ2 = NL_SINGLETON_typ2();
	}
	return value__singleton__NL_SINGLETON_typ2;
}
public static Imm NL_SINGLETON_rekord() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 55
___nl__2 = ptd_NL.NL_sim().clone();

//line 55
___nl__3 = ptd_NL.NL_sim().clone();

//line 55
__function_map = new Dictionary<String, Imm>();
__function_map.Add("g",___nl__2);
__function_map.Add("h",___nl__3);
___nl__1 = new ImmHash(__function_map).clone();
//line 55
___nl__2 = null;
//line 55
___nl__3 = null;
//line 55
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 55
___nl__1 = null;
//line 55
if(true) return ___nl__0;
//line 55
___nl__0 = null;
//line 55
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_rekord = null;
public static Imm NL_rekord() {
	if (value__singleton__NL_SINGLETON_rekord == null) {
		value__singleton__NL_SINGLETON_rekord = NL_SINGLETON_rekord();
	}
	return value__singleton__NL_SINGLETON_rekord;
}
private static Imm NL_test_is_priv(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 58
___nl__1 = ___nl__0.clone();
//line 58
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("h")).clone();
//line 58
___nl__0 = null;
//line 58
if(true) return ___nl__1;
//line 58
___nl__1 = null;
//line 58
___nl__0 = null;
//line 58
if(true) return null;
}

private static Imm NL_funkcja_priv(Imm ___arg__0) {
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
//line 64
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("a")).clone();
//line 64
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 67
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("b")).clone();
//line 67
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 69
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("d")).clone();
//line 69
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_4;}}
//line 69
___nl__3 = new ImmString("NOMATCHALERT").clone();
//line 69
___nl__3 = new ImmArray(new Imm[] {___nl__3,___nl__0,}).clone();
//line 69
c_rt_lib_NL.NL_die();
//line 64
label_2:
//line 64
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("a")).clone();
//line 65
___nl__5 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("dynia")).clone();
//line 65
___nl__1 = ___nl__5.clone();
//line 65
___nl__5 = null;
//line 66
___nl__5 = new ImmString("").clone();
//line 66
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("h"), ___nl__5).clone();
//line 66
___nl__0 = null;
//line 66
___nl__1 = null;
//line 66
___nl__2 = null;
//line 66
___nl__3 = null;
//line 66
___nl__4 = null;
//line 66
if(true) return ___nl__5;
//line 66
___nl__5 = null;
//line 66
___nl__4 = null;
//line 67
if (true) {goto label_1;}
//line 67
label_3:
//line 67
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("b")).clone();
//line 68
___nl__5 = new ImmString("").clone();
//line 68
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("h"), ___nl__5).clone();
//line 68
___nl__1 = ___nl__5.clone();
//line 68
___nl__5 = null;
//line 68
___nl__4 = null;
//line 69
if (true) {goto label_1;}
//line 69
label_4:
//line 69
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("d")).clone();
//line 70
___nl__5 = ___nl__4.clone();
//line 71
___nl__2 = ___nl__5.clone();
//line 72
___nl__6 = ___nl__0.clone();
//line 72
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("d")).clone();
//line 72
___nl__2 = ___nl__6.clone();
//line 72
___nl__6 = null;
//line 73
___nl__6 = new ImmString("").clone();
//line 73
___nl__7 = ___nl__6.clone();
//line 73
((ImmHash)___nl__5).set("g", ___nl__7);
//line 73
___nl__6 = null;
//line 73
___nl__7 = null;
//line 74
___nl__6 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("mysz")).clone();
//line 74
___nl__1 = ___nl__6.clone();
//line 74
___nl__6 = null;
//line 75
___nl__6 = new ImmArray(new Imm[0]).clone();
//line 75
c_rt_lib_NL.NL_die();
//line 75
___nl__5 = null;
//line 75
___nl__6 = null;
//line 75
___nl__4 = null;
//line 76
if (true) {goto label_1;}
//line 76
label_1:
//line 76
___nl__3 = null;
//line 77
___nl__3 = test_type_NL.NL_test_is_priv(___nl__1).clone();

//line 77
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 77
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 77
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_6;}}
//line 77
___nl__4 = new ImmArray(new Imm[0]).clone();
//line 77
c_rt_lib_NL.NL_die();
//line 77
if (true) {goto label_6;}
//line 77
label_6:
//line 77
___nl__3 = null;
//line 77
___nl__4 = null;
//line 78
___nl__0 = null;
//line 78
___nl__2 = null;
//line 78
if(true) return ___nl__1;
//line 78
___nl__1 = null;
//line 78
___nl__2 = null;
//line 78
___nl__0 = null;
//line 78
if(true) return null;
}

}
}