using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class nassert_NL {

private static Imm NL_SINGLETON_get_check_priv() {

Imm ___nl__0 = null;
ImmRef ___ref______nl__0 = null;
Dictionary<String, Imm> __function_map;
//line 9
___nl__0 = c_rt_lib_NL.NL_get_true().clone();
//line 9
if(true) return ___nl__0;
//line 9
___nl__0 = null;
//line 9
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_get_check_priv = null;
private static Imm NL_get_check_priv() {
	if (value__singleton__NL_SINGLETON_get_check_priv == null) {
		value__singleton__NL_SINGLETON_get_check_priv = NL_SINGLETON_get_check_priv();
	}
	return value__singleton__NL_SINGLETON_get_check_priv;
}
private static Imm NL_SINGLETON_get_verbose_priv() {

Imm ___nl__0 = null;
ImmRef ___ref______nl__0 = null;
Dictionary<String, Imm> __function_map;
//line 12
___nl__0 = c_rt_lib_NL.NL_get_true().clone();
//line 12
if(true) return ___nl__0;
//line 12
___nl__0 = null;
//line 12
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_get_verbose_priv = null;
private static Imm NL_get_verbose_priv() {
	if (value__singleton__NL_SINGLETON_get_verbose_priv == null) {
		value__singleton__NL_SINGLETON_get_verbose_priv = NL_SINGLETON_get_verbose_priv();
	}
	return value__singleton__NL_SINGLETON_get_verbose_priv;
}
public static Imm NL_a(Imm ___arg__0, Imm ___arg__1) {
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
//line 16
___nl__2 = nassert_NL.NL_get_check_priv().clone();

//line 16
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 16
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 16
___nl__2 = dfile_NL.NL_ssave(___nl__0).clone();

//line 16
___nl__4 = dfile_NL.NL_ssave(___nl__1).clone();

//line 16
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!___nl__2.toString().Equals(___nl__4.toString())).clone();
//line 16
___nl__4 = null;
//line 16
label_3:
//line 16
___nl__3 = null;
//line 16
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 16
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 17
___nl__3 = nassert_NL.NL_get_verbose_priv().clone();

//line 17
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 17
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_5;}}
//line 18
___nl__5 = dfile_NL.NL_ssave(___nl__0).clone();

//line 18
___nl__6 = new ImmString(" != ").clone();
//line 18
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 18
___nl__6 = null;
//line 18
___nl__6 = dfile_NL.NL_ssave(___nl__1).clone();

//line 18
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 18
___nl__6 = null;
//line 18
___nl__4 = new ImmArray(new Imm[] {___nl__5,}).clone();
//line 18
___nl__5 = null;
//line 18
c_rt_lib_NL.NL_die();
//line 18
___nl__4 = null;
//line 19
if (true) {goto label_4;}
//line 19
label_5:
//line 20
___nl__4 = new ImmArray(new Imm[0]).clone();
//line 20
c_rt_lib_NL.NL_die();
//line 20
___nl__4 = null;
//line 21
if (true) {goto label_4;}
//line 21
label_4:
//line 21
___nl__3 = null;
//line 23
if (true) {goto label_2;}
//line 23
label_2:
//line 23
___nl__2 = null;
//line 23
___nl__0 = null;
//line 23
___nl__1 = null;
//line 23
if(true) return null;
}

public static Imm NL_as(Imm ___arg__0, Imm ___arg__1, Imm ___arg__2) {
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
//line 28
___nl__3 = nassert_NL.NL_get_check_priv().clone();

//line 28
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 28
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_3;}}
//line 28
___nl__3 = dfile_NL.NL_ssave(___nl__0).clone();

//line 28
___nl__5 = dfile_NL.NL_ssave(___nl__1).clone();

//line 28
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__5.toString())).clone();
//line 28
___nl__5 = null;
//line 28
label_3:
//line 28
___nl__4 = null;
//line 28
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 28
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 28
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 28
___nl__4 = new ImmArray(new Imm[] {___nl__2,}).clone();
//line 28
c_rt_lib_NL.NL_die();
//line 28
if (true) {goto label_2;}
//line 28
label_2:
//line 28
___nl__3 = null;
//line 28
___nl__4 = null;
//line 28
___nl__0 = null;
//line 28
___nl__1 = null;
//line 28
___nl__2 = null;
//line 28
if(true) return null;
}

}
}