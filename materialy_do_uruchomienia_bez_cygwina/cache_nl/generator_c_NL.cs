using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class generator_c_NL {

private static Imm NL_SINGLETON_get_bin_ops_priv() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 17
___nl__1 = generator_c_NL.NL_gen_bin_ops_priv().clone();

//line 17
___nl__0 = singleton_NL.NL_sigleton_do_not_use_without_approval(___nl__1).clone();

//line 17
___nl__1 = null;
//line 17
if(true) return ___nl__0;
//line 17
___nl__0 = null;
//line 17
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_get_bin_ops_priv = null;
private static Imm NL_get_bin_ops_priv() {
	if (value__singleton__NL_SINGLETON_get_bin_ops_priv == null) {
		value__singleton__NL_SINGLETON_get_bin_ops_priv = NL_SINGLETON_get_bin_ops_priv();
	}
	return value__singleton__NL_SINGLETON_get_bin_ops_priv;
}
private static Imm NL_SINGLETON_get_bin_ops_mod_priv() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 20
___nl__1 = generator_c_NL.NL_gen_bin_ops_mod_priv().clone();

//line 20
___nl__0 = singleton_NL.NL_sigleton_do_not_use_without_approval(___nl__1).clone();

//line 20
___nl__1 = null;
//line 20
if(true) return ___nl__0;
//line 20
___nl__0 = null;
//line 20
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_get_bin_ops_mod_priv = null;
private static Imm NL_get_bin_ops_mod_priv() {
	if (value__singleton__NL_SINGLETON_get_bin_ops_mod_priv == null) {
		value__singleton__NL_SINGLETON_get_bin_ops_mod_priv = NL_SINGLETON_get_bin_ops_mod_priv();
	}
	return value__singleton__NL_SINGLETON_get_bin_ops_mod_priv;
}
private static Imm NL_SINGLETON_get_unary_ops_priv() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 24
___nl__1 = generator_c_NL.NL_gen_unary_ops_priv().clone();

//line 24
___nl__0 = singleton_NL.NL_sigleton_do_not_use_without_approval(___nl__1).clone();

//line 24
___nl__1 = null;
//line 24
if(true) return ___nl__0;
//line 24
___nl__0 = null;
//line 24
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_get_unary_ops_priv = null;
private static Imm NL_get_unary_ops_priv() {
	if (value__singleton__NL_SINGLETON_get_unary_ops_priv == null) {
		value__singleton__NL_SINGLETON_get_unary_ops_priv = NL_SINGLETON_get_unary_ops_priv();
	}
	return value__singleton__NL_SINGLETON_get_unary_ops_priv;
}
private static Imm NL_SINGLETON_gen_unary_ops_priv() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 28
__function_map = new Dictionary<String, Imm>();
___nl__0 = new ImmHash(__function_map).clone();
//line 29
___nl__1 = new ImmString("!").clone();
//line 29
___nl__2 = new ImmString("not").clone();
//line 29
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 29
___nl__2 = null;
//line 29
___nl__1 = null;
//line 30
___nl__1 = new ImmString("-").clone();
//line 30
___nl__2 = new ImmString("unary_minus").clone();
//line 30
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 30
___nl__2 = null;
//line 30
___nl__1 = null;
//line 31
___nl__1 = new ImmString("+").clone();
//line 31
___nl__2 = new ImmString("unary_plus").clone();
//line 31
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 31
___nl__2 = null;
//line 31
___nl__1 = null;
//line 32
if(true) return ___nl__0;
//line 32
___nl__0 = null;
//line 32
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_gen_unary_ops_priv = null;
private static Imm NL_gen_unary_ops_priv() {
	if (value__singleton__NL_SINGLETON_gen_unary_ops_priv == null) {
		value__singleton__NL_SINGLETON_gen_unary_ops_priv = NL_SINGLETON_gen_unary_ops_priv();
	}
	return value__singleton__NL_SINGLETON_gen_unary_ops_priv;
}
private static Imm NL_SINGLETON_gen_bin_ops_priv() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 36
__function_map = new Dictionary<String, Imm>();
___nl__0 = new ImmHash(__function_map).clone();
//line 37
___nl__1 = new ImmString("eq").clone();
//line 37
___nl__2 = new ImmString("eq").clone();
//line 37
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 37
___nl__2 = null;
//line 37
___nl__1 = null;
//line 38
___nl__1 = new ImmString("ne").clone();
//line 38
___nl__2 = new ImmString("ne").clone();
//line 38
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 38
___nl__2 = null;
//line 38
___nl__1 = null;
//line 39
___nl__1 = new ImmString("+").clone();
//line 39
___nl__2 = new ImmString("add").clone();
//line 39
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 39
___nl__2 = null;
//line 39
___nl__1 = null;
//line 40
___nl__1 = new ImmString("-").clone();
//line 40
___nl__2 = new ImmString("sub").clone();
//line 40
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 40
___nl__2 = null;
//line 40
___nl__1 = null;
//line 41
___nl__1 = new ImmString("*").clone();
//line 41
___nl__2 = new ImmString("mul").clone();
//line 41
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 41
___nl__2 = null;
//line 41
___nl__1 = null;
//line 42
___nl__1 = new ImmString("/").clone();
//line 42
___nl__2 = new ImmString("div").clone();
//line 42
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 42
___nl__2 = null;
//line 42
___nl__1 = null;
//line 43
___nl__1 = new ImmString("%").clone();
//line 43
___nl__2 = new ImmString("mod").clone();
//line 43
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 43
___nl__2 = null;
//line 43
___nl__1 = null;
//line 44
___nl__1 = new ImmString("<=").clone();
//line 44
___nl__2 = new ImmString("le").clone();
//line 44
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 44
___nl__2 = null;
//line 44
___nl__1 = null;
//line 45
___nl__1 = new ImmString("<").clone();
//line 45
___nl__2 = new ImmString("lt").clone();
//line 45
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 45
___nl__2 = null;
//line 45
___nl__1 = null;
//line 46
___nl__1 = new ImmString("==").clone();
//line 46
___nl__2 = new ImmString("num_eq").clone();
//line 46
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 46
___nl__2 = null;
//line 46
___nl__1 = null;
//line 47
___nl__1 = new ImmString("!=").clone();
//line 47
___nl__2 = new ImmString("num_ne").clone();
//line 47
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 47
___nl__2 = null;
//line 47
___nl__1 = null;
//line 48
___nl__1 = new ImmString(">").clone();
//line 48
___nl__2 = new ImmString("gt").clone();
//line 48
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 48
___nl__2 = null;
//line 48
___nl__1 = null;
//line 49
___nl__1 = new ImmString(">=").clone();
//line 49
___nl__2 = new ImmString("ge").clone();
//line 49
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 49
___nl__2 = null;
//line 49
___nl__1 = null;
//line 50
___nl__1 = new ImmString(".").clone();
//line 50
___nl__2 = new ImmString("concat_new").clone();
//line 50
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 50
___nl__2 = null;
//line 50
___nl__1 = null;
//line 51
if(true) return ___nl__0;
//line 51
___nl__0 = null;
//line 51
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_gen_bin_ops_priv = null;
private static Imm NL_gen_bin_ops_priv() {
	if (value__singleton__NL_SINGLETON_gen_bin_ops_priv == null) {
		value__singleton__NL_SINGLETON_gen_bin_ops_priv = NL_SINGLETON_gen_bin_ops_priv();
	}
	return value__singleton__NL_SINGLETON_gen_bin_ops_priv;
}
private static Imm NL_SINGLETON_gen_bin_ops_mod_priv() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 54
__function_map = new Dictionary<String, Imm>();
___nl__0 = new ImmHash(__function_map).clone();
//line 55
___nl__1 = new ImmString("+").clone();
//line 55
___nl__2 = new ImmString("add_mod").clone();
//line 55
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 55
___nl__2 = null;
//line 55
___nl__1 = null;
//line 56
___nl__1 = new ImmString("-").clone();
//line 56
___nl__2 = new ImmString("sub_mod").clone();
//line 56
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 56
___nl__2 = null;
//line 56
___nl__1 = null;
//line 57
___nl__1 = new ImmString("*").clone();
//line 57
___nl__2 = new ImmString("mul_mod").clone();
//line 57
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 57
___nl__2 = null;
//line 57
___nl__1 = null;
//line 58
___nl__1 = new ImmString("/").clone();
//line 58
___nl__2 = new ImmString("div_mod").clone();
//line 58
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 58
___nl__2 = null;
//line 58
___nl__1 = null;
//line 59
___nl__1 = new ImmString("%").clone();
//line 59
___nl__2 = new ImmString("mod_mod").clone();
//line 59
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 59
___nl__2 = null;
//line 59
___nl__1 = null;
//line 60
___nl__1 = new ImmString(".").clone();
//line 60
___nl__2 = new ImmString("concat_add").clone();
//line 60
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 60
___nl__2 = null;
//line 60
___nl__1 = null;
//line 61
if(true) return ___nl__0;
//line 61
___nl__0 = null;
//line 61
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_gen_bin_ops_mod_priv = null;
private static Imm NL_gen_bin_ops_mod_priv() {
	if (value__singleton__NL_SINGLETON_gen_bin_ops_mod_priv == null) {
		value__singleton__NL_SINGLETON_gen_bin_ops_mod_priv = NL_SINGLETON_gen_bin_ops_mod_priv();
	}
	return value__singleton__NL_SINGLETON_gen_bin_ops_mod_priv;
}
public static Imm NL_SINGLETON_const_dict() {

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
___nl__3 = ptd_NL.NL_sim().clone();

//line 65
___nl__2 = ptd_NL.NL_arr(___nl__3).clone();

//line 65
___nl__3 = null;
//line 65
___nl__4 = ptd_NL.NL_sim().clone();

//line 65
___nl__3 = ptd_NL.NL_hash(___nl__4).clone();

//line 65
___nl__4 = null;
//line 65
__function_map = new Dictionary<String, Imm>();
__function_map.Add("arr",___nl__2);
__function_map.Add("hash",___nl__3);
___nl__1 = new ImmHash(__function_map).clone();
//line 65
___nl__2 = null;
//line 65
___nl__3 = null;
//line 65
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 65
___nl__1 = null;
//line 65
if(true) return ___nl__0;
//line 65
___nl__0 = null;
//line 65
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_const_dict = null;
public static Imm NL_const_dict() {
	if (value__singleton__NL_SINGLETON_const_dict == null) {
		value__singleton__NL_SINGLETON_const_dict = NL_SINGLETON_const_dict();
	}
	return value__singleton__NL_SINGLETON_const_dict;
}
public static Imm NL_SINGLETON_fun_args_t() {

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
//line 71
___nl__3 = ptd_NL.NL_none().clone();

//line 71
___nl__4 = ptd_NL.NL_none().clone();

//line 71
__function_map = new Dictionary<String, Imm>();
__function_map.Add("val",___nl__3);
__function_map.Add("ref",___nl__4);
___nl__2 = new ImmHash(__function_map).clone();
//line 71
___nl__3 = null;
//line 71
___nl__4 = null;
//line 71
___nl__1 = ptd_NL.NL_var(___nl__2).clone();

//line 71
___nl__2 = null;
//line 71
___nl__0 = ptd_NL.NL_arr(___nl__1).clone();

//line 71
___nl__1 = null;
//line 71
if(true) return ___nl__0;
//line 71
___nl__0 = null;
//line 71
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_fun_args_t = null;
public static Imm NL_fun_args_t() {
	if (value__singleton__NL_SINGLETON_fun_args_t == null) {
		value__singleton__NL_SINGLETON_fun_args_t = NL_SINGLETON_fun_args_t();
	}
	return value__singleton__NL_SINGLETON_fun_args_t;
}
public static Imm NL_SINGLETON_const_t() {

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
//line 74
___nl__3 = ptd_NL.NL_sim().clone();

//line 74
___nl__2 = ptd_NL.NL_arr(___nl__3).clone();

//line 74
___nl__3 = null;
//line 74
___nl__4 = ptd_NL.NL_sim().clone();

//line 74
___nl__3 = ptd_NL.NL_hash(___nl__4).clone();

//line 74
___nl__4 = null;
//line 74
__function_map = new Dictionary<String, Imm>();
__function_map.Add("arr",___nl__2);
__function_map.Add("hash",___nl__3);
___nl__1 = new ImmHash(__function_map).clone();
//line 74
___nl__2 = null;
//line 74
___nl__3 = null;
//line 74
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 74
___nl__1 = null;
//line 74
if(true) return ___nl__0;
//line 74
___nl__0 = null;
//line 74
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_const_t = null;
public static Imm NL_const_t() {
	if (value__singleton__NL_SINGLETON_const_t == null) {
		value__singleton__NL_SINGLETON_const_t = NL_SINGLETON_const_t();
	}
	return value__singleton__NL_SINGLETON_const_t;
}
public static Imm NL_SINGLETON_global_const_t() {

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
//line 80
___nl__5 = ptd_NL.NL_sim().clone();

//line 80
___nl__6 = ptd_NL.NL_sim().clone();

//line 80
__function_map = new Dictionary<String, Imm>();
__function_map.Add("key",___nl__5);
__function_map.Add("uses",___nl__6);
___nl__4 = new ImmHash(__function_map).clone();
//line 80
___nl__5 = null;
//line 80
___nl__6 = null;
//line 80
___nl__3 = ptd_NL.NL_rec(___nl__4).clone();

//line 80
___nl__4 = null;
//line 80
___nl__2 = ptd_NL.NL_arr(___nl__3).clone();

//line 80
___nl__3 = null;
//line 80
___nl__4 = ptd_NL.NL_sim().clone();

//line 80
___nl__3 = ptd_NL.NL_hash(___nl__4).clone();

//line 80
___nl__4 = null;
//line 80
___nl__5 = ptd_NL.NL_sim().clone();

//line 80
___nl__4 = ptd_NL.NL_arr(___nl__5).clone();

//line 80
___nl__5 = null;
//line 80
___nl__7 = ptd_NL.NL_sim().clone();

//line 80
___nl__6 = ptd_NL.NL_hash(___nl__7).clone();

//line 80
___nl__7 = null;
//line 80
___nl__5 = ptd_NL.NL_hash(___nl__6).clone();

//line 80
___nl__6 = null;
//line 80
__function_map = new Dictionary<String, Imm>();
__function_map.Add("arr",___nl__2);
__function_map.Add("hash",___nl__3);
__function_map.Add("holes",___nl__4);
__function_map.Add("module_consts",___nl__5);
___nl__1 = new ImmHash(__function_map).clone();
//line 80
___nl__2 = null;
//line 80
___nl__3 = null;
//line 80
___nl__4 = null;
//line 80
___nl__5 = null;
//line 80
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 80
___nl__1 = null;
//line 80
if(true) return ___nl__0;
//line 80
___nl__0 = null;
//line 80
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_global_const_t = null;
public static Imm NL_global_const_t() {
	if (value__singleton__NL_SINGLETON_global_const_t == null) {
		value__singleton__NL_SINGLETON_global_const_t = NL_SINGLETON_global_const_t();
	}
	return value__singleton__NL_SINGLETON_global_const_t;
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
//line 90
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("generator_c_NL"));
__function_map.Add("name",new ImmString("global_const_t"));
___nl__2 = new ImmHash(__function_map).clone();
//line 90
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2).clone();
//line 90
___nl__3 = ptd_NL.NL_sim().clone();

//line 90
___nl__4 = ptd_NL.NL_sim().clone();

//line 90
___nl__5 = ptd_NL.NL_sim().clone();

//line 90
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("generator_c_NL"));
__function_map.Add("name",new ImmString("fun_args_t"));
___nl__6 = new ImmHash(__function_map).clone();
//line 90
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__6).clone();
//line 90
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("generator_c_NL"));
__function_map.Add("name",new ImmString("const_t"));
___nl__9 = new ImmHash(__function_map).clone();
//line 90
___nl__9 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__9).clone();
//line 90
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("generator_c_NL"));
__function_map.Add("name",new ImmString("const_t"));
___nl__10 = new ImmHash(__function_map).clone();
//line 90
___nl__10 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__10).clone();
//line 90
___nl__11 = ptd_NL.NL_sim().clone();

//line 90
__function_map = new Dictionary<String, Imm>();
__function_map.Add("sim",___nl__9);
__function_map.Add("singleton",___nl__10);
__function_map.Add("dynamic_nr",___nl__11);
___nl__8 = new ImmHash(__function_map).clone();
//line 90
___nl__9 = null;
//line 90
___nl__10 = null;
//line 90
___nl__11 = null;
//line 90
___nl__7 = ptd_NL.NL_rec(___nl__8).clone();

//line 90
___nl__8 = null;
//line 90
__function_map = new Dictionary<String, Imm>();
__function_map.Add("global_const",___nl__2);
__function_map.Add("header",___nl__3);
__function_map.Add("ret",___nl__4);
__function_map.Add("mod_name",___nl__5);
__function_map.Add("fun_args",___nl__6);
__function_map.Add("const",___nl__7);
___nl__1 = new ImmHash(__function_map).clone();
//line 90
___nl__2 = null;
//line 90
___nl__3 = null;
//line 90
___nl__4 = null;
//line 90
___nl__5 = null;
//line 90
___nl__6 = null;
//line 90
___nl__7 = null;
//line 90
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 90
___nl__1 = null;
//line 90
if(true) return ___nl__0;
//line 90
___nl__0 = null;
//line 90
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_state_t = null;
public static Imm NL_state_t() {
	if (value__singleton__NL_SINGLETON_state_t == null) {
		value__singleton__NL_SINGLETON_state_t = NL_SINGLETON_state_t();
	}
	return value__singleton__NL_SINGLETON_state_t;
}
public static Imm NL_SINGLETON_get_empty_state() {

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
//line 105
___nl__2 = new ImmArray(new Imm[0]).clone();
//line 105
__function_map = new Dictionary<String, Imm>();
___nl__3 = new ImmHash(__function_map).clone();
//line 105
___nl__4 = new ImmArray(new Imm[0]).clone();
//line 105
__function_map = new Dictionary<String, Imm>();
___nl__5 = new ImmHash(__function_map).clone();
//line 105
__function_map = new Dictionary<String, Imm>();
__function_map.Add("arr",___nl__2);
__function_map.Add("hash",___nl__3);
__function_map.Add("holes",___nl__4);
__function_map.Add("module_consts",___nl__5);
___nl__1 = new ImmHash(__function_map).clone();
//line 105
___nl__2 = null;
//line 105
___nl__3 = null;
//line 105
___nl__4 = null;
//line 105
___nl__5 = null;
//line 105
___nl__2 = new ImmString("").clone();
//line 105
___nl__3 = new ImmString("").clone();
//line 105
___nl__4 = new ImmArray(new Imm[0]).clone();
//line 105
___nl__6 = new ImmDouble(0).clone();
//line 105
___nl__8 = new ImmArray(new Imm[0]).clone();
//line 105
__function_map = new Dictionary<String, Imm>();
___nl__9 = new ImmHash(__function_map).clone();
//line 105
__function_map = new Dictionary<String, Imm>();
__function_map.Add("arr",___nl__8);
__function_map.Add("hash",___nl__9);
___nl__7 = new ImmHash(__function_map).clone();
//line 105
___nl__8 = null;
//line 105
___nl__9 = null;
//line 105
___nl__9 = new ImmArray(new Imm[0]).clone();
//line 105
__function_map = new Dictionary<String, Imm>();
___nl__10 = new ImmHash(__function_map).clone();
//line 105
__function_map = new Dictionary<String, Imm>();
__function_map.Add("arr",___nl__9);
__function_map.Add("hash",___nl__10);
___nl__8 = new ImmHash(__function_map).clone();
//line 105
___nl__9 = null;
//line 105
___nl__10 = null;
//line 105
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dynamic_nr",___nl__6);
__function_map.Add("sim",___nl__7);
__function_map.Add("singleton",___nl__8);
___nl__5 = new ImmHash(__function_map).clone();
//line 105
___nl__6 = null;
//line 105
___nl__7 = null;
//line 105
___nl__8 = null;
//line 105
___nl__6 = new ImmString("").clone();
//line 105
__function_map = new Dictionary<String, Imm>();
__function_map.Add("global_const",___nl__1);
__function_map.Add("ret",___nl__2);
__function_map.Add("header",___nl__3);
__function_map.Add("fun_args",___nl__4);
__function_map.Add("const",___nl__5);
__function_map.Add("mod_name",___nl__6);
___nl__0 = new ImmHash(__function_map).clone();
//line 105
___nl__1 = null;
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
if(true) return ___nl__0;
//line 105
___nl__0 = null;
//line 105
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_get_empty_state = null;
public static Imm NL_get_empty_state() {
	if (value__singleton__NL_SINGLETON_get_empty_state == null) {
		value__singleton__NL_SINGLETON_get_empty_state = NL_SINGLETON_get_empty_state();
	}
	return value__singleton__NL_SINGLETON_get_empty_state;
}
private static Imm NL_print_priv(ImmRef ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 120
___nl__2 = new ImmString("ret").clone();
//line 120
___nl__2 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__2).clone();

//line 120
___nl__2 = new ImmString(___nl__2.toString() + ___nl__1.toString()).clone();
//line 120
___nl__3 = new ImmString("ret").clone();
//line 120
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__3,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 120
___nl__3 = null;
//line 120
___nl__2 = null;
//line 120
___nl__1 = null;
//line 120
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_print_to_header_priv(ImmRef ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 124
___nl__2 = new ImmString("header").clone();
//line 124
___nl__2 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__2).clone();

//line 124
___nl__2 = new ImmString(___nl__2.toString() + ___nl__1.toString()).clone();
//line 124
___nl__3 = new ImmString("header").clone();
//line 124
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__3,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 124
___nl__3 = null;
//line 124
___nl__2 = null;
//line 124
___nl__1 = null;
//line 124
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_println_to_header_priv(ImmRef ___arg__0, Imm ___arg__1) {
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
//line 128
___nl__2 = string_NL.NL_lf().clone();

//line 128
___nl__2 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 128
___nl__3 = new ImmString("header").clone();
//line 128
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__3).clone();

//line 128
___nl__3 = new ImmString(___nl__3.toString() + ___nl__2.toString()).clone();
//line 128
___nl__4 = new ImmString("header").clone();
//line 128
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__4,___nl__3);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 128
___nl__4 = null;
//line 128
___nl__2 = null;
//line 128
___nl__3 = null;
//line 128
___nl__1 = null;
//line 128
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_SINGLETON_arg_t_priv() {

Imm ___nl__0 = null;
ImmRef ___ref______nl__0 = null;
Dictionary<String, Imm> __function_map;
//line 132
___nl__0 = new ImmString("ImmT ").clone();
//line 132
if(true) return ___nl__0;
//line 132
___nl__0 = null;
//line 132
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_arg_t_priv = null;
private static Imm NL_arg_t_priv() {
	if (value__singleton__NL_SINGLETON_arg_t_priv == null) {
		value__singleton__NL_SINGLETON_arg_t_priv = NL_SINGLETON_arg_t_priv();
	}
	return value__singleton__NL_SINGLETON_arg_t_priv;
}
private static Imm NL_println_priv(ImmRef ___arg__0, Imm ___arg__1) {
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
//line 136
___nl__2 = new ImmString("ret").clone();
//line 136
___nl__2 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__2).clone();

//line 136
___nl__2 = new ImmString(___nl__2.toString() + ___nl__1.toString()).clone();
//line 136
___nl__3 = new ImmString("ret").clone();
//line 136
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__3,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 136
___nl__3 = null;
//line 136
___nl__2 = null;
//line 137
___nl__2 = string_NL.NL_lf().clone();

//line 137
___nl__3 = new ImmString("ret").clone();
//line 137
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__3).clone();

//line 137
___nl__3 = new ImmString(___nl__3.toString() + ___nl__2.toString()).clone();
//line 137
___nl__4 = new ImmString("ret").clone();
//line 137
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__4,___nl__3);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 137
___nl__4 = null;
//line 137
___nl__2 = null;
//line 137
___nl__3 = null;
//line 137
___nl__1 = null;
//line 137
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_get_reg_priv(ImmRef ___arg__0, Imm ___arg__1) {
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
//line 141
___nl__2 = ((ImmHash)___nl__0).getHashValue()["fun_args"].clone();
//line 142
___nl__3 = array_NL.NL_len(___nl__2).clone();

//line 142
___nl__3 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))>(Double.Parse(___nl__1.getValue().ToString())) ).clone();
//line 142
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 142
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_3;}}
//line 142
___nl__3 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__1).getDoubleValue()].clone();
//line 142
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("ref")).clone();
//line 142
label_3:
//line 142
___nl__4 = null;
//line 142
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 142
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 143
___nl__4 = new ImmString("*___ref___").clone();
//line 143
___nl__4 = new ImmString(___nl__4.toString() + ___nl__1.toString()).clone();
//line 143
___nl__1 = null;
//line 143
___nl__2 = null;
//line 143
___nl__3 = null;
//line 143
___arg__0.setValue(___nl__0);if(true) return ___nl__4;
//line 143
___nl__4 = null;
//line 144
if (true) {goto label_2;}
//line 144
label_2:
//line 144
___nl__3 = null;
//line 145
___nl__3 = new ImmString("___nl__").clone();
//line 145
___nl__3 = new ImmString(___nl__3.toString() + ___nl__1.toString()).clone();
//line 145
___nl__1 = null;
//line 145
___nl__2 = null;
//line 145
___arg__0.setValue(___nl__0);if(true) return ___nl__3;
//line 145
___nl__3 = null;
//line 145
___nl__2 = null;
//line 145
___nl__1 = null;
//line 145
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_get_reg_ref_priv(ImmRef ___arg__0, Imm ___arg__1) {
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
//line 148
___nl__2 = ((ImmHash)___nl__0).getHashValue()["fun_args"].clone();
//line 149
___nl__3 = array_NL.NL_len(___nl__2).clone();

//line 149
___nl__3 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))>(Double.Parse(___nl__1.getValue().ToString())) ).clone();
//line 149
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 149
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_3;}}
//line 149
___nl__3 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__1).getDoubleValue()].clone();
//line 149
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("ref")).clone();
//line 149
label_3:
//line 149
___nl__4 = null;
//line 149
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 149
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 150
___nl__4 = new ImmString("___ref___").clone();
//line 150
___nl__4 = new ImmString(___nl__4.toString() + ___nl__1.toString()).clone();
//line 150
___nl__1 = null;
//line 150
___nl__2 = null;
//line 150
___nl__3 = null;
//line 150
___arg__0.setValue(___nl__0);if(true) return ___nl__4;
//line 150
___nl__4 = null;
//line 151
if (true) {goto label_2;}
//line 151
label_2:
//line 151
___nl__3 = null;
//line 152
___nl__3 = new ImmString("&___nl__").clone();
//line 152
___nl__3 = new ImmString(___nl__3.toString() + ___nl__1.toString()).clone();
//line 152
___nl__1 = null;
//line 152
___nl__2 = null;
//line 152
___arg__0.setValue(___nl__0);if(true) return ___nl__3;
//line 152
___nl__3 = null;
//line 152
___nl__2 = null;
//line 152
___nl__1 = null;
//line 152
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_get_string_priv(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 155
___nl__1 = new ImmString("\"").clone();
//line 155
___nl__1 = new ImmString(___nl__1.toString() + ___nl__0.toString()).clone();
//line 155
___nl__2 = new ImmString("\"").clone();
//line 155
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 155
___nl__2 = null;
//line 155
___nl__0 = null;
//line 155
if(true) return ___nl__1;
//line 155
___nl__1 = null;
//line 155
___nl__0 = null;
//line 155
if(true) return null;
}

public static Imm NL_SINGLETON_module_out_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 159
___nl__2 = ptd_NL.NL_sim().clone();

//line 159
___nl__3 = ptd_NL.NL_sim().clone();

//line 159
__function_map = new Dictionary<String, Imm>();
__function_map.Add("c",___nl__2);
__function_map.Add("h",___nl__3);
___nl__1 = new ImmHash(__function_map).clone();
//line 159
___nl__2 = null;
//line 159
___nl__3 = null;
//line 159
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 159
___nl__1 = null;
//line 159
if(true) return ___nl__0;
//line 159
___nl__0 = null;
//line 159
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_module_out_t = null;
public static Imm NL_module_out_t() {
	if (value__singleton__NL_SINGLETON_module_out_t == null) {
		value__singleton__NL_SINGLETON_module_out_t = NL_SINGLETON_module_out_t();
	}
	return value__singleton__NL_SINGLETON_module_out_t;
}
public static Imm NL_SINGLETON_out_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 163
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("generator_c_NL"));
__function_map.Add("name",new ImmString("module_out_t"));
___nl__3 = new ImmHash(__function_map).clone();
//line 163
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3).clone();
//line 163
___nl__2 = ptd_NL.NL_hash(___nl__3).clone();

//line 163
___nl__3 = null;
//line 163
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("generator_c_NL"));
__function_map.Add("name",new ImmString("module_out_t"));
___nl__3 = new ImmHash(__function_map).clone();
//line 163
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3).clone();
//line 163
__function_map = new Dictionary<String, Imm>();
__function_map.Add("modules",___nl__2);
__function_map.Add("global_const",___nl__3);
___nl__1 = new ImmHash(__function_map).clone();
//line 163
___nl__2 = null;
//line 163
___nl__3 = null;
//line 163
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 163
___nl__1 = null;
//line 163
if(true) return ___nl__0;
//line 163
___nl__0 = null;
//line 163
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_out_t = null;
public static Imm NL_out_t() {
	if (value__singleton__NL_SINGLETON_out_t == null) {
		value__singleton__NL_SINGLETON_out_t = NL_SINGLETON_out_t();
	}
	return value__singleton__NL_SINGLETON_out_t;
}
public static Imm NL_generate(Imm ___arg__0, ImmRef ___arg__1) {
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
//line 170
__function_map = new Dictionary<String, Imm>();
___nl__2 = new ImmHash(__function_map).clone();
//line 171
___nl__3 = new ImmArray(new Imm[0]).clone();
//line 172
___nl__6 = c_rt_lib_NL.NL_init_iter(___nl__0).clone();

//line 172
label_3:
//line 172
___nl__4 = c_rt_lib_NL.NL_is_end_hash(___nl__6).clone();

//line 172
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_1;}}
//line 172
___nl__4 = c_rt_lib_NL.NL_get_key_iter(___nl__6).clone();

//line 172
___nl__5 = c_rt_lib_NL.NL_hash_get_value(___nl__0,___nl__4).clone();

//line 173
___ref______nl__3 = new ImmRef(___nl__3);
array_NL.NL_push(___ref______nl__3,___nl__4);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 174
___nl__6 = c_rt_lib_NL.NL_next_iter(___nl__6).clone();

//line 174
if (true) {goto label_3;}
//line 174
label_1:
//line 174
___nl__4 = null;
//line 174
___nl__5 = null;
//line 174
___nl__6 = null;
//line 175
___ref______nl__3 = new ImmRef(___nl__3);
array_NL.NL_sort(___ref______nl__3);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 176
___nl__5 = new ImmDouble(0).clone();
//line 176
___nl__6 = new ImmDouble(1).clone();
//line 176
___nl__7 = c_rt_lib_NL.NL_array_len(___nl__3).clone();

//line 176
label_6:
//line 176
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) ).clone();
//line 176
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_4;}}
//line 176
___nl__4 = (___nl__3 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()].clone();
//line 177
___nl__9 = hash_NL.NL_get_value(___nl__0,___nl__4).clone();

//line 178
___ref______nl__1 = new ImmRef(___nl__1);
generator_c_NL.NL_clear_module_from_state(___ref______nl__1,___nl__4);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 179
___nl__10 = new ImmString("global_const").clone();
//line 179
___nl__10 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__10).clone();

//line 179
___nl__11 = new ImmString("module_consts").clone();
//line 179
___nl__11 = c_rt_lib_NL.NL_get_ref_hash(___nl__10,___nl__11).clone();

//line 179
__function_map = new Dictionary<String, Imm>();
___nl__12 = new ImmHash(__function_map).clone();
//line 179
___ref______nl__11 = new ImmRef(___nl__11);
hash_NL.NL_set_value(___ref______nl__11,___nl__4,___nl__12);
___nl__11 = ___ref______nl__11.getValue().clone();

//line 179
___nl__12 = null;
//line 179
___nl__12 = new ImmString("module_consts").clone();
//line 179
___ref______nl__10 = new ImmRef(___nl__10);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__10,___nl__12,___nl__11);
___nl__10 = ___ref______nl__10.getValue().clone();

//line 179
___nl__12 = new ImmString("global_const").clone();
//line 179
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__12,___nl__10);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 179
___nl__12 = null;
//line 179
___nl__10 = null;
//line 179
___nl__11 = null;
//line 180
___nl__10 = new ImmString("").clone();
//line 180
___nl__11 = ___nl__10.clone();
//line 180
((ImmHash)___nl__1).set("ret", ___nl__11);
//line 180
___nl__10 = null;
//line 180
___nl__11 = null;
//line 181
___nl__10 = new ImmString("").clone();
//line 181
___nl__11 = ___nl__10.clone();
//line 181
((ImmHash)___nl__1).set("header", ___nl__11);
//line 181
___nl__10 = null;
//line 181
___nl__11 = null;
//line 182
___nl__10 = new ImmArray(new Imm[0]).clone();
//line 182
___nl__11 = ___nl__10.clone();
//line 182
((ImmHash)___nl__1).set("fun_args", ___nl__11);
//line 182
___nl__10 = null;
//line 182
___nl__11 = null;
//line 183
___nl__11 = new ImmDouble(0).clone();
//line 183
___nl__13 = new ImmArray(new Imm[0]).clone();
//line 183
__function_map = new Dictionary<String, Imm>();
___nl__14 = new ImmHash(__function_map).clone();
//line 183
__function_map = new Dictionary<String, Imm>();
__function_map.Add("arr",___nl__13);
__function_map.Add("hash",___nl__14);
___nl__12 = new ImmHash(__function_map).clone();
//line 183
___nl__13 = null;
//line 183
___nl__14 = null;
//line 183
___nl__14 = new ImmArray(new Imm[0]).clone();
//line 183
__function_map = new Dictionary<String, Imm>();
___nl__15 = new ImmHash(__function_map).clone();
//line 183
__function_map = new Dictionary<String, Imm>();
__function_map.Add("arr",___nl__14);
__function_map.Add("hash",___nl__15);
___nl__13 = new ImmHash(__function_map).clone();
//line 183
___nl__14 = null;
//line 183
___nl__15 = null;
//line 183
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dynamic_nr",___nl__11);
__function_map.Add("sim",___nl__12);
__function_map.Add("singleton",___nl__13);
___nl__10 = new ImmHash(__function_map).clone();
//line 183
___nl__11 = null;
//line 183
___nl__12 = null;
//line 183
___nl__13 = null;
//line 183
___nl__11 = ___nl__10.clone();
//line 183
((ImmHash)___nl__1).set("const", ___nl__11);
//line 183
___nl__10 = null;
//line 183
___nl__11 = null;
//line 188
___nl__10 = ___nl__4.clone();
//line 188
((ImmHash)___nl__1).set("mod_name", ___nl__10);
//line 188
___nl__10 = null;
//line 189
___ref______nl__1 = new ImmRef(___nl__1);
generator_c_NL.NL_print_mod_priv(___ref______nl__1,___nl__9);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 190
___nl__11 = ((ImmHash)___nl__1).getHashValue()["ret"].clone();
//line 190
___nl__12 = ((ImmHash)___nl__1).getHashValue()["header"].clone();
//line 190
__function_map = new Dictionary<String, Imm>();
__function_map.Add("c",___nl__11);
__function_map.Add("h",___nl__12);
___nl__10 = new ImmHash(__function_map).clone();
//line 190
___nl__11 = null;
//line 190
___nl__12 = null;
//line 190
___ref______nl__2 = new ImmRef(___nl__2);
hash_NL.NL_set_value(___ref______nl__2,___nl__4,___nl__10);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 190
___nl__10 = null;
//line 190
___nl__9 = null;
//line 191
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString()))).clone();
//line 191
if (true) {goto label_6;}
//line 191
label_4:
//line 191
___nl__4 = null;
//line 191
___nl__5 = null;
//line 191
___nl__6 = null;
//line 191
___nl__7 = null;
//line 191
___nl__8 = null;
//line 192
___ref______nl__1 = new ImmRef(___nl__1);
___nl__5 = generator_c_NL.NL_generate_global_const_files_priv(___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 192
__function_map = new Dictionary<String, Imm>();
__function_map.Add("modules",___nl__2);
__function_map.Add("global_const",___nl__5);
___nl__4 = new ImmHash(__function_map).clone();
//line 192
___nl__5 = null;
//line 192
___nl__0 = null;
//line 192
___nl__2 = null;
//line 192
___nl__3 = null;
//line 192
___arg__1.setValue(___nl__1);if(true) return ___nl__4;
//line 192
___nl__4 = null;
//line 192
___nl__2 = null;
//line 192
___nl__3 = null;
//line 192
___nl__0 = null;
//line 192
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_generate_global_const_files_priv(ImmRef ___arg__0) {
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
//line 196
___nl__1 = new ImmString("").clone();
//line 196
___nl__2 = ___nl__1.clone();
//line 196
((ImmHash)___nl__0).set("ret", ___nl__2);
//line 196
___nl__1 = null;
//line 196
___nl__2 = null;
//line 197
___nl__1 = new ImmString("").clone();
//line 197
___nl__2 = ___nl__1.clone();
//line 197
((ImmHash)___nl__0).set("header", ___nl__2);
//line 197
___nl__1 = null;
//line 197
___nl__2 = null;
//line 198
___nl__1 = new ImmArray(new Imm[0]).clone();
//line 198
___nl__2 = ___nl__1.clone();
//line 198
((ImmHash)___nl__0).set("fun_args", ___nl__2);
//line 198
___nl__1 = null;
//line 198
___nl__2 = null;
//line 199
___nl__2 = new ImmDouble(0).clone();
//line 199
___nl__4 = new ImmArray(new Imm[0]).clone();
//line 199
__function_map = new Dictionary<String, Imm>();
___nl__5 = new ImmHash(__function_map).clone();
//line 199
__function_map = new Dictionary<String, Imm>();
__function_map.Add("arr",___nl__4);
__function_map.Add("hash",___nl__5);
___nl__3 = new ImmHash(__function_map).clone();
//line 199
___nl__4 = null;
//line 199
___nl__5 = null;
//line 199
___nl__5 = new ImmArray(new Imm[0]).clone();
//line 199
__function_map = new Dictionary<String, Imm>();
___nl__6 = new ImmHash(__function_map).clone();
//line 199
__function_map = new Dictionary<String, Imm>();
__function_map.Add("arr",___nl__5);
__function_map.Add("hash",___nl__6);
___nl__4 = new ImmHash(__function_map).clone();
//line 199
___nl__5 = null;
//line 199
___nl__6 = null;
//line 199
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dynamic_nr",___nl__2);
__function_map.Add("sim",___nl__3);
__function_map.Add("singleton",___nl__4);
___nl__1 = new ImmHash(__function_map).clone();
//line 199
___nl__2 = null;
//line 199
___nl__3 = null;
//line 199
___nl__4 = null;
//line 199
___nl__2 = ___nl__1.clone();
//line 199
((ImmHash)___nl__0).set("const", ___nl__2);
//line 199
___nl__1 = null;
//line 199
___nl__2 = null;
//line 204
___nl__1 = new ImmString("").clone();
//line 204
___nl__2 = ___nl__1.clone();
//line 204
((ImmHash)___nl__0).set("mod_name", ___nl__2);
//line 204
___nl__1 = null;
//line 204
___nl__2 = null;
//line 206
___nl__1 = generator_c_NL.NL_get_cr_priv().clone();

//line 206
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_to_header_priv(___ref______nl__0,___nl__1);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 206
___nl__1 = null;
//line 207
___nl__1 = new ImmString("#pragma once").clone();
//line 207
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_to_header_priv(___ref______nl__0,___nl__1);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 207
___nl__1 = null;
//line 208
___nl__2 = new ImmString("c_rt_lib").clone();
//line 208
___nl__1 = generator_c_NL.NL_get_include_priv(___nl__2).clone();

//line 208
___nl__2 = null;
//line 208
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_to_header_priv(___ref______nl__0,___nl__1);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 208
___nl__1 = null;
//line 211
___nl__1 = generator_c_NL.NL_get_cr_priv().clone();

//line 211
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__1);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 211
___nl__1 = null;
//line 212
___nl__2 = new ImmString("c_global_const").clone();
//line 212
___nl__1 = generator_c_NL.NL_get_include_priv(___nl__2).clone();

//line 212
___nl__2 = null;
//line 212
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__1);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 212
___nl__1 = null;
//line 214
___nl__1 = ((ImmHash)___nl__0).getHashValue()["global_const"].clone();
//line 214
___nl__1 = ((ImmHash)___nl__1).getHashValue()["arr"].clone();
//line 215
___nl__2 = array_NL.NL_len(___nl__1).clone();

//line 217
___nl__3 = new ImmString("void ___global_const_init();").clone();
//line 217
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_to_header_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 217
___nl__3 = null;
//line 218
___nl__3 = generator_c_NL.NL_arg_t_priv().clone();

//line 218
___nl__4 = new ImmString(" ___get_global_const(int __nr);").clone();
//line 218
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 218
___nl__4 = null;
//line 218
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_to_header_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 218
___nl__3 = null;
//line 220
___nl__3 = new ImmString("\nstatic ").clone();
//line 220
___nl__4 = generator_c_NL.NL_arg_t_priv().clone();

//line 220
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 220
___nl__4 = null;
//line 220
___nl__4 = new ImmString(" ___global_const__ = NULL;\nstatic int ___global_const_init__ = 1;\nstatic int ___global_const_offset;").clone();
//line 220
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 220
___nl__4 = null;
//line 220
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 220
___nl__3 = null;
//line 225
___nl__3 = new ImmString("void ___global_const_init(){\nif(___global_const_init__) {\n___global_const_init__ = 0;\n___global_const_offset = c_rt_lib0get_global_const_offset();\n___global_const__ = alloc_mem(").clone();
//line 225
___nl__3 = new ImmString(___nl__3.toString() + ___nl__2.toString()).clone();
//line 225
___nl__4 = new ImmString(" * ___global_const_offset);\n").clone();
//line 225
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 225
___nl__4 = null;
//line 225
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 225
___nl__3 = null;
//line 232
___nl__3 = new ImmDouble(0).clone();
//line 232
___nl__4 = new ImmDouble(1).clone();
//line 232
label_3:
//line 232
___nl__5 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))>=(Double.Parse(___nl__2.getValue().ToString())) ).clone();
//line 232
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_1;}}
//line 233
___nl__7 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__3).getDoubleValue()].clone();
//line 233
___nl__7 = ((ImmHash)___nl__7).getHashValue()["key"].clone();
//line 233
___nl__8 = new ImmString("___global_const__ + ___global_const_offset * ").clone();
//line 233
___nl__8 = new ImmString(___nl__8.toString() + ___nl__3.toString()).clone();
//line 233
___nl__6 = generator_c_NL.NL_create_sim_to_memory_priv(___nl__7,___nl__8).clone();

//line 233
___nl__8 = null;
//line 233
___nl__7 = null;
//line 233
___nl__7 = new ImmString(";").clone();
//line 233
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 233
___nl__7 = null;
//line 233
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__6);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 233
___nl__6 = null;
//line 234
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString()))).clone();
//line 234
if (true) {goto label_3;}
//line 234
label_1:
//line 234
___nl__3 = null;
//line 234
___nl__4 = null;
//line 234
___nl__5 = null;
//line 236
___nl__3 = new ImmString("\n").clone();
//line 236
___nl__5 = new ImmString("register_global_const").clone();
//line 236
___nl__4 = generator_c_NL.NL_get_lib_fun_priv(___nl__5).clone();

//line 236
___nl__5 = null;
//line 236
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 236
___nl__4 = null;
//line 236
___nl__4 = new ImmString("((").clone();
//line 236
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 236
___nl__4 = null;
//line 236
___nl__4 = generator_c_NL.NL_arg_t_priv().clone();

//line 236
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 236
___nl__4 = null;
//line 236
___nl__4 = new ImmString(")___global_const__,(").clone();
//line 236
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 236
___nl__4 = null;
//line 236
___nl__4 = generator_c_NL.NL_arg_t_priv().clone();

//line 236
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 236
___nl__4 = null;
//line 236
___nl__4 = new ImmString(")___global_const__ + ").clone();
//line 236
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 236
___nl__4 = null;
//line 236
___nl__3 = new ImmString(___nl__3.toString() + ___nl__2.toString()).clone();
//line 236
___nl__4 = new ImmString(" * ___global_const_offset);\n}}").clone();
//line 236
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 236
___nl__4 = null;
//line 236
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 236
___nl__3 = null;
//line 241
___nl__3 = generator_c_NL.NL_arg_t_priv().clone();

//line 241
___nl__4 = new ImmString("___get_global_const(int __nr) {\n").clone();
//line 241
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 241
___nl__4 = null;
//line 241
___nl__4 = generator_c_NL.NL_arg_t_priv().clone();

//line 241
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 241
___nl__4 = null;
//line 241
___nl__4 = new ImmString("ret = NULL;\n").clone();
//line 241
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 241
___nl__4 = null;
//line 241
___nl__5 = new ImmString("copy").clone();
//line 241
___nl__7 = new ImmString("&ret").clone();
//line 241
___nl__8 = new ImmString("(").clone();
//line 241
___nl__9 = generator_c_NL.NL_arg_t_priv().clone();

//line 241
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 241
___nl__9 = null;
//line 241
___nl__9 = new ImmString(")___global_const__ + ___global_const_offset * __nr").clone();
//line 241
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 241
___nl__9 = null;
//line 241
___nl__6 = new ImmArray(new Imm[] {___nl__7,___nl__8,}).clone();
//line 241
___nl__7 = null;
//line 241
___nl__8 = null;
//line 241
___nl__4 = generator_c_NL.NL_get_fun_lib_priv(___nl__5,___nl__6).clone();

//line 241
___nl__6 = null;
//line 241
___nl__5 = null;
//line 241
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 241
___nl__4 = null;
//line 241
___nl__4 = new ImmString(";\nreturn ret;\n}").clone();
//line 241
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 241
___nl__4 = null;
//line 241
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 241
___nl__3 = null;
//line 248
___nl__4 = ((ImmHash)___nl__0).getHashValue()["ret"].clone();
//line 248
___nl__5 = ((ImmHash)___nl__0).getHashValue()["header"].clone();
//line 248
__function_map = new Dictionary<String, Imm>();
__function_map.Add("c",___nl__4);
__function_map.Add("h",___nl__5);
___nl__3 = new ImmHash(__function_map).clone();
//line 248
___nl__4 = null;
//line 248
___nl__5 = null;
//line 248
___nl__1 = null;
//line 248
___nl__2 = null;
//line 248
___arg__0.setValue(___nl__0);if(true) return ___nl__3;
//line 248
___nl__3 = null;
//line 248
___nl__1 = null;
//line 248
___nl__2 = null;
//line 248
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_get_include_priv(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 252
___nl__1 = new ImmString("#include \"").clone();
//line 252
___nl__1 = new ImmString(___nl__1.toString() + ___nl__0.toString()).clone();
//line 252
___nl__2 = new ImmString(".h\"").clone();
//line 252
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 252
___nl__2 = null;
//line 252
___nl__0 = null;
//line 252
if(true) return ___nl__1;
//line 252
___nl__1 = null;
//line 252
___nl__0 = null;
//line 252
if(true) return null;
}

private static Imm NL_SINGLETON_get_cr_priv() {

Imm ___nl__0 = null;
ImmRef ___ref______nl__0 = null;
Dictionary<String, Imm> __function_map;
//line 256
___nl__0 = new ImmString("\n/* (c) Atinea Sp z o. o.\n *  Stamp: nianio lang\n */\n").clone();
//line 256
if(true) return ___nl__0;
//line 256
___nl__0 = null;
//line 256
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_get_cr_priv = null;
private static Imm NL_get_cr_priv() {
	if (value__singleton__NL_SINGLETON_get_cr_priv == null) {
		value__singleton__NL_SINGLETON_get_cr_priv = NL_SINGLETON_get_cr_priv();
	}
	return value__singleton__NL_SINGLETON_get_cr_priv;
}
private static Imm NL_get_function_name_priv(Imm ___arg__0, Imm ___arg__1) {
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
//line 264
___nl__3 = ((ImmHash)___nl__0).getHashValue()["access"].clone();
//line 264
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("pub")).clone();
//line 264
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 266
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("priv")).clone();
//line 266
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_3;}}
//line 266
___nl__4 = new ImmString("NOMATCHALERT").clone();
//line 266
___nl__4 = new ImmArray(new Imm[] {___nl__4,___nl__3,}).clone();
//line 266
c_rt_lib_NL.NL_die();
//line 264
label_2:
//line 265
___nl__2 = ___nl__1.clone();
//line 266
if (true) {goto label_1;}
//line 266
label_3:
//line 267
___nl__5 = new ImmString("").clone();
//line 267
___nl__2 = ___nl__5.clone();
//line 267
___nl__5 = null;
//line 268
if (true) {goto label_1;}
//line 268
label_1:
//line 268
___nl__3 = null;
//line 268
___nl__4 = null;
//line 269
___nl__4 = ((ImmHash)___nl__0).getHashValue()["name"].clone();
//line 269
___nl__3 = generator_c_NL.NL_get_fun_name_priv(___nl__2,___nl__4,___nl__1).clone();

//line 269
___nl__4 = null;
//line 269
___nl__0 = null;
//line 269
___nl__1 = null;
//line 269
___nl__2 = null;
//line 269
if(true) return ___nl__3;
//line 269
___nl__3 = null;
//line 269
___nl__2 = null;
//line 269
___nl__0 = null;
//line 269
___nl__1 = null;
//line 269
if(true) return null;
}

private static Imm NL_get_function_header_priv(Imm ___arg__0, Imm ___arg__1) {
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
//line 272
___nl__2 = new ImmString("").clone();
//line 273
___nl__3 = generator_c_NL.NL_get_function_name_priv(___nl__0,___nl__1).clone();

//line 274
___nl__4 = generator_c_NL.NL_arg_t_priv().clone();

//line 274
___nl__4 = new ImmString(___nl__4.toString() + ___nl__3.toString()).clone();
//line 274
___nl__5 = new ImmString("(").clone();
//line 274
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 274
___nl__5 = null;
//line 274
___nl__2 = new ImmString(___nl__2.toString() + ___nl__4.toString()).clone();
//line 274
___nl__4 = null;
//line 275
___nl__4 = new ImmDouble(0).clone();
//line 276
___nl__5 = ((ImmHash)___nl__0).getHashValue()["args_type"].clone();
//line 276
___nl__7 = new ImmDouble(0).clone();
//line 276
___nl__8 = new ImmDouble(1).clone();
//line 276
___nl__9 = c_rt_lib_NL.NL_array_len(___nl__5).clone();

//line 276
label_3:
//line 276
___nl__10 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))>=(Double.Parse(___nl__9.getValue().ToString())) ).clone();
//line 276
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_1;}}
//line 276
___nl__6 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()].clone();
//line 277
___nl__11 = new ImmDouble(0).clone();
//line 277
___nl__11 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__11.getValue().ToString())) ==((Double.Parse(___nl__4.getValue().ToString())))  ).clone();
//line 277
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 277
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 277
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_5;}}
//line 277
___nl__12 = new ImmString(",").clone();
//line 277
___nl__2 = new ImmString(___nl__2.toString() + ___nl__12.toString()).clone();
//line 277
___nl__12 = null;
//line 277
if (true) {goto label_5;}
//line 277
label_5:
//line 277
___nl__11 = null;
//line 278
___nl__11 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("val")).clone();
//line 278
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_7;}}
//line 280
___nl__11 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("ref")).clone();
//line 280
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_8;}}
//line 280
___nl__11 = new ImmString("NOMATCHALERT").clone();
//line 280
___nl__11 = new ImmArray(new Imm[] {___nl__11,___nl__6,}).clone();
//line 280
c_rt_lib_NL.NL_die();
//line 278
label_7:
//line 279
___nl__12 = generator_c_NL.NL_arg_t_priv().clone();

//line 279
___nl__13 = new ImmString("___nl__").clone();
//line 279
___nl__12 = new ImmString(___nl__12.toString() + ___nl__13.toString()).clone();
//line 279
___nl__13 = null;
//line 279
___nl__12 = new ImmString(___nl__12.toString() + ___nl__4.toString()).clone();
//line 279
___nl__2 = new ImmString(___nl__2.toString() + ___nl__12.toString()).clone();
//line 279
___nl__12 = null;
//line 280
if (true) {goto label_6;}
//line 280
label_8:
//line 281
___nl__12 = generator_c_NL.NL_arg_t_priv().clone();

//line 281
___nl__13 = new ImmString("* ___ref___").clone();
//line 281
___nl__12 = new ImmString(___nl__12.toString() + ___nl__13.toString()).clone();
//line 281
___nl__13 = null;
//line 281
___nl__12 = new ImmString(___nl__12.toString() + ___nl__4.toString()).clone();
//line 281
___nl__2 = new ImmString(___nl__2.toString() + ___nl__12.toString()).clone();
//line 281
___nl__12 = null;
//line 282
if (true) {goto label_6;}
//line 282
label_6:
//line 282
___nl__11 = null;
//line 283
___nl__11 = new ImmDouble(1).clone();
//line 283
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__11.getValue().ToString()))).clone();
//line 283
___nl__11 = null;
//line 284
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString()))).clone();
//line 284
if (true) {goto label_3;}
//line 284
label_1:
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
___nl__10 = null;
//line 286
___nl__5 = new ImmString(")").clone();
//line 286
___nl__2 = new ImmString(___nl__2.toString() + ___nl__5.toString()).clone();
//line 286
___nl__5 = null;
//line 288
___nl__0 = null;
//line 288
___nl__1 = null;
//line 288
___nl__3 = null;
//line 288
___nl__4 = null;
//line 288
if(true) return ___nl__2;
//line 288
___nl__2 = null;
//line 288
___nl__3 = null;
//line 288
___nl__4 = null;
//line 288
___nl__0 = null;
//line 288
___nl__1 = null;
//line 288
if(true) return null;
}

private static Imm NL_get_const_priv(ImmRef ___arg__0, Imm ___arg__1) {
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
//line 291
___nl__2 = new ImmDouble(1).clone();
//line 291
___nl__2 = new ImmDouble(-((ImmDouble)___nl__2).getDoubleValue()).clone();
//line 292
___nl__4 = ((ImmHash)___nl__0).getHashValue()["hash"].clone();
//line 292
___nl__3 = hash_NL.NL_has_key(___nl__4,___nl__1).clone();

//line 292
___nl__4 = null;
//line 292
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 292
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 292
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 293
___nl__5 = ((ImmHash)___nl__0).getHashValue()["arr"].clone();
//line 293
___nl__4 = array_NL.NL_len(___nl__5).clone();

//line 293
___nl__5 = null;
//line 293
___nl__2 = ___nl__4.clone();
//line 293
___nl__4 = null;
//line 294
___nl__4 = new ImmString("arr").clone();
//line 294
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__4).clone();

//line 294
___ref______nl__4 = new ImmRef(___nl__4);
array_NL.NL_push(___ref______nl__4,___nl__1);
___nl__4 = ___ref______nl__4.getValue().clone();

//line 294
___nl__5 = new ImmString("arr").clone();
//line 294
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 294
___nl__5 = null;
//line 294
___nl__4 = null;
//line 295
___nl__4 = new ImmString("hash").clone();
//line 295
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__4).clone();

//line 295
___ref______nl__4 = new ImmRef(___nl__4);
hash_NL.NL_set_value(___ref______nl__4,___nl__1,___nl__2);
___nl__4 = ___ref______nl__4.getValue().clone();

//line 295
___nl__5 = new ImmString("hash").clone();
//line 295
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 295
___nl__5 = null;
//line 295
___nl__4 = null;
//line 296
if (true) {goto label_1;}
//line 296
label_2:
//line 297
___nl__5 = ((ImmHash)___nl__0).getHashValue()["hash"].clone();
//line 297
___nl__4 = hash_NL.NL_get_value(___nl__5,___nl__1).clone();

//line 297
___nl__5 = null;
//line 297
___nl__2 = ___nl__4.clone();
//line 297
___nl__4 = null;
//line 298
if (true) {goto label_1;}
//line 298
label_1:
//line 298
___nl__3 = null;
//line 299
___nl__1 = null;
//line 299
___arg__0.setValue(___nl__0);if(true) return ___nl__2;
//line 299
___nl__2 = null;
//line 299
___nl__1 = null;
//line 299
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_insert_const_to_modules_hash_priv(ImmRef ___arg__0, Imm ___arg__1, Imm ___arg__2) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();
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
//line 302
___nl__4 = ((ImmHash)___nl__0).getHashValue()["module_consts"].clone();
//line 302
___nl__3 = hash_NL.NL_get_value(___nl__4,___nl__2).clone();

//line 302
___nl__4 = null;
//line 303
___nl__4 = new ImmString("").clone();
//line 303
___ref______nl__3 = new ImmRef(___nl__3);
hash_NL.NL_set_value(___ref______nl__3,___nl__1,___nl__4);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 303
___nl__4 = null;
//line 304
___nl__4 = new ImmString("module_consts").clone();
//line 304
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__4).clone();

//line 304
___ref______nl__4 = new ImmRef(___nl__4);
hash_NL.NL_set_value(___ref______nl__4,___nl__2,___nl__3);
___nl__4 = ___ref______nl__4.getValue().clone();

//line 304
___nl__5 = new ImmString("module_consts").clone();
//line 304
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 304
___nl__5 = null;
//line 304
___nl__4 = null;
//line 304
___nl__3 = null;
//line 304
___nl__1 = null;
//line 304
___nl__2 = null;
//line 304
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_get_global_const_priv(ImmRef ___arg__0, Imm ___arg__1, Imm ___arg__2) {
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
//line 307
___nl__3 = new ImmDouble(1).clone();
//line 307
___nl__3 = new ImmDouble(-((ImmDouble)___nl__3).getDoubleValue()).clone();
//line 308
___nl__5 = ((ImmHash)___nl__0).getHashValue()["hash"].clone();
//line 308
___nl__4 = hash_NL.NL_has_key(___nl__5,___nl__1).clone();

//line 308
___nl__5 = null;
//line 308
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 308
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 308
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 309
___nl__6 = ((ImmHash)___nl__0).getHashValue()["holes"].clone();
//line 309
___nl__5 = array_NL.NL_len(___nl__6).clone();

//line 309
___nl__6 = null;
//line 309
___nl__6 = new ImmDouble(0).clone();
//line 309
___nl__5 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>(Double.Parse(___nl__6.getValue().ToString())) ).clone();
//line 309
___nl__6 = null;
//line 309
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 309
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_4;}}
//line 310
___nl__6 = ((ImmHash)___nl__0).getHashValue()["holes"].clone();
//line 310
___nl__8 = ((ImmHash)___nl__0).getHashValue()["holes"].clone();
//line 310
___nl__7 = array_NL.NL_len(___nl__8).clone();

//line 310
___nl__8 = null;
//line 310
___nl__8 = new ImmDouble(1).clone();
//line 310
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))-(Double.Parse(___nl__8.getValue().ToString()))).clone();
//line 310
___nl__8 = null;
//line 310
___nl__6 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()].clone();
//line 310
___nl__7 = null;
//line 310
___nl__3 = ___nl__6.clone();
//line 310
___nl__6 = null;
//line 311
___nl__6 = new ImmString("holes").clone();
//line 311
___nl__6 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__6).clone();

//line 311
___ref______nl__6 = new ImmRef(___nl__6);
array_NL.NL_pop(___ref______nl__6);
___nl__6 = ___ref______nl__6.getValue().clone();

//line 311
___nl__7 = new ImmString("holes").clone();
//line 311
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__7,___nl__6);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 311
___nl__7 = null;
//line 311
___nl__6 = null;
//line 312
___nl__7 = new ImmDouble(1).clone();
//line 312
__function_map = new Dictionary<String, Imm>();
__function_map.Add("key",___nl__1);
__function_map.Add("uses",___nl__7);
___nl__6 = new ImmHash(__function_map).clone();
//line 312
___nl__7 = null;
//line 312
___nl__7 = new ImmString("arr").clone();
//line 312
___nl__7 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__7).clone();

//line 312
___nl__8 = ___nl__6.clone();
//line 312
(___nl__7 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__3).getDoubleValue()] = ___nl__8;
//line 312
___nl__9 = new ImmString("arr").clone();
//line 312
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__9,___nl__7);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 312
___nl__9 = null;
//line 312
___nl__6 = null;
//line 312
___nl__7 = null;
//line 312
___nl__8 = null;
//line 313
if (true) {goto label_3;}
//line 313
label_4:
//line 314
___nl__7 = ((ImmHash)___nl__0).getHashValue()["arr"].clone();
//line 314
___nl__6 = array_NL.NL_len(___nl__7).clone();

//line 314
___nl__7 = null;
//line 314
___nl__3 = ___nl__6.clone();
//line 314
___nl__6 = null;
//line 315
___nl__6 = new ImmString("arr").clone();
//line 315
___nl__6 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__6).clone();

//line 315
___nl__8 = new ImmDouble(1).clone();
//line 315
__function_map = new Dictionary<String, Imm>();
__function_map.Add("key",___nl__1);
__function_map.Add("uses",___nl__8);
___nl__7 = new ImmHash(__function_map).clone();
//line 315
___nl__8 = null;
//line 315
___ref______nl__6 = new ImmRef(___nl__6);
array_NL.NL_push(___ref______nl__6,___nl__7);
___nl__6 = ___ref______nl__6.getValue().clone();

//line 315
___nl__7 = null;
//line 315
___nl__7 = new ImmString("arr").clone();
//line 315
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__7,___nl__6);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 315
___nl__7 = null;
//line 315
___nl__6 = null;
//line 316
if (true) {goto label_3;}
//line 316
label_3:
//line 316
___nl__5 = null;
//line 317
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_insert_const_to_modules_hash_priv(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 318
___nl__5 = new ImmString("hash").clone();
//line 318
___nl__5 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__5).clone();

//line 318
___ref______nl__5 = new ImmRef(___nl__5);
hash_NL.NL_set_value(___ref______nl__5,___nl__1,___nl__3);
___nl__5 = ___ref______nl__5.getValue().clone();

//line 318
___nl__6 = new ImmString("hash").clone();
//line 318
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__6,___nl__5);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 318
___nl__6 = null;
//line 318
___nl__5 = null;
//line 319
if (true) {goto label_1;}
//line 319
label_2:
//line 320
___nl__6 = ((ImmHash)___nl__0).getHashValue()["hash"].clone();
//line 320
___nl__5 = hash_NL.NL_get_value(___nl__6,___nl__1).clone();

//line 320
___nl__6 = null;
//line 320
___nl__3 = ___nl__5.clone();
//line 320
___nl__5 = null;
//line 321
___nl__6 = ((ImmHash)___nl__0).getHashValue()["module_consts"].clone();
//line 321
___nl__5 = hash_NL.NL_get_value(___nl__6,___nl__2).clone();

//line 321
___nl__6 = null;
//line 322
___nl__6 = hash_NL.NL_has_key(___nl__5,___nl__1).clone();

//line 322
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 322
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 322
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_6;}}
//line 323
___nl__7 = new ImmString("arr").clone();
//line 323
___nl__7 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__7).clone();

//line 323
___nl__8 = c_rt_lib_NL.NL_get_ref_arr(___nl__7,___nl__3).clone();

//line 323
___nl__9 = new ImmString("uses").clone();
//line 323
___nl__9 = c_rt_lib_NL.NL_get_ref_hash(___nl__8,___nl__9).clone();

//line 323
___nl__10 = new ImmDouble(1).clone();
//line 323
___nl__9 = new ImmDouble((Double.Parse(___nl__9.getValue().ToString()))+(Double.Parse(___nl__10.getValue().ToString()))).clone();
//line 323
___nl__11 = new ImmString("uses").clone();
//line 323
___ref______nl__8 = new ImmRef(___nl__8);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__8,___nl__11,___nl__9);
___nl__8 = ___ref______nl__8.getValue().clone();

//line 323
___ref______nl__7 = new ImmRef(___nl__7);
c_rt_lib_NL.NL_set_ref_arr(___ref______nl__7,___nl__3,___nl__8);
___nl__7 = ___ref______nl__7.getValue().clone();

//line 323
___nl__11 = new ImmString("arr").clone();
//line 323
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__11,___nl__7);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 323
___nl__11 = null;
//line 323
___nl__7 = null;
//line 323
___nl__8 = null;
//line 323
___nl__9 = null;
//line 323
___nl__10 = null;
//line 324
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_insert_const_to_modules_hash_priv(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 325
if (true) {goto label_6;}
//line 325
label_6:
//line 325
___nl__6 = null;
//line 325
___nl__5 = null;
//line 326
if (true) {goto label_1;}
//line 326
label_1:
//line 326
___nl__4 = null;
//line 327
___nl__1 = null;
//line 327
___nl__2 = null;
//line 327
___arg__0.setValue(___nl__0);if(true) return ___nl__3;
//line 327
___nl__3 = null;
//line 327
___nl__1 = null;
//line 327
___nl__2 = null;
//line 327
___arg__0.setValue(___nl__0);if(true) return null;
}

public static Imm NL_clear_module_from_state(ImmRef ___arg__0, Imm ___arg__1) {
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
//line 330
___nl__3 = ((ImmHash)___nl__0).getHashValue()["global_const"].clone();
//line 330
___nl__3 = ((ImmHash)___nl__3).getHashValue()["module_consts"].clone();
//line 330
___nl__2 = hash_NL.NL_has_key(___nl__3,___nl__1).clone();

//line 330
___nl__3 = null;
//line 330
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 330
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 331
___nl__4 = ((ImmHash)___nl__0).getHashValue()["global_const"].clone();
//line 331
___nl__4 = ((ImmHash)___nl__4).getHashValue()["module_consts"].clone();
//line 331
___nl__3 = hash_NL.NL_get_value(___nl__4,___nl__1).clone();

//line 331
___nl__4 = null;
//line 332
___nl__6 = c_rt_lib_NL.NL_init_iter(___nl__3).clone();

//line 332
label_5:
//line 332
___nl__4 = c_rt_lib_NL.NL_is_end_hash(___nl__6).clone();

//line 332
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_3;}}
//line 332
___nl__4 = c_rt_lib_NL.NL_get_key_iter(___nl__6).clone();

//line 332
___nl__5 = c_rt_lib_NL.NL_hash_get_value(___nl__3,___nl__4).clone();

//line 333
___nl__8 = ((ImmHash)___nl__0).getHashValue()["global_const"].clone();
//line 333
___nl__8 = ((ImmHash)___nl__8).getHashValue()["hash"].clone();
//line 333
___nl__7 = hash_NL.NL_get_value(___nl__8,___nl__4).clone();

//line 333
___nl__8 = null;
//line 334
___nl__8 = new ImmString("global_const").clone();
//line 334
___nl__8 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__8).clone();

//line 334
___nl__9 = new ImmString("arr").clone();
//line 334
___nl__9 = c_rt_lib_NL.NL_get_ref_hash(___nl__8,___nl__9).clone();

//line 334
___nl__10 = c_rt_lib_NL.NL_get_ref_arr(___nl__9,___nl__7).clone();

//line 334
___nl__11 = new ImmString("uses").clone();
//line 334
___nl__11 = c_rt_lib_NL.NL_get_ref_hash(___nl__10,___nl__11).clone();

//line 334
___nl__12 = new ImmDouble(1).clone();
//line 334
___nl__11 = new ImmDouble((Double.Parse(___nl__11.getValue().ToString()))-(Double.Parse(___nl__12.getValue().ToString()))).clone();
//line 334
___nl__13 = new ImmString("uses").clone();
//line 334
___ref______nl__10 = new ImmRef(___nl__10);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__10,___nl__13,___nl__11);
___nl__10 = ___ref______nl__10.getValue().clone();

//line 334
___ref______nl__9 = new ImmRef(___nl__9);
c_rt_lib_NL.NL_set_ref_arr(___ref______nl__9,___nl__7,___nl__10);
___nl__9 = ___ref______nl__9.getValue().clone();

//line 334
___nl__13 = new ImmString("arr").clone();
//line 334
___ref______nl__8 = new ImmRef(___nl__8);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__8,___nl__13,___nl__9);
___nl__8 = ___ref______nl__8.getValue().clone();

//line 334
___nl__13 = new ImmString("global_const").clone();
//line 334
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__13,___nl__8);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 334
___nl__13 = null;
//line 334
___nl__8 = null;
//line 334
___nl__9 = null;
//line 334
___nl__10 = null;
//line 334
___nl__11 = null;
//line 334
___nl__12 = null;
//line 335
___nl__8 = ((ImmHash)___nl__0).getHashValue()["global_const"].clone();
//line 335
___nl__8 = ((ImmHash)___nl__8).getHashValue()["arr"].clone();
//line 335
___nl__8 = (___nl__8 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()].clone();
//line 335
___nl__8 = ((ImmHash)___nl__8).getHashValue()["uses"].clone();
//line 335
___nl__9 = new ImmDouble(0).clone();
//line 335
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString())) ==((Double.Parse(___nl__9.getValue().ToString())))  ).clone();
//line 335
___nl__9 = null;
//line 335
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 335
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_7;}}
//line 336
___nl__9 = new ImmString("global_const").clone();
//line 336
___nl__9 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__9).clone();

//line 336
___nl__10 = new ImmString("hash").clone();
//line 336
___nl__10 = c_rt_lib_NL.NL_get_ref_hash(___nl__9,___nl__10).clone();

//line 336
___ref______nl__10 = new ImmRef(___nl__10);
hash_NL.NL_delete(___ref______nl__10,___nl__4);
___nl__10 = ___ref______nl__10.getValue().clone();

//line 336
___nl__11 = new ImmString("hash").clone();
//line 336
___ref______nl__9 = new ImmRef(___nl__9);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__9,___nl__11,___nl__10);
___nl__9 = ___ref______nl__9.getValue().clone();

//line 336
___nl__11 = new ImmString("global_const").clone();
//line 336
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__11,___nl__9);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 336
___nl__11 = null;
//line 336
___nl__9 = null;
//line 336
___nl__10 = null;
//line 337
___nl__9 = new ImmString("global_const").clone();
//line 337
___nl__9 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__9).clone();

//line 337
___nl__10 = new ImmString("holes").clone();
//line 337
___nl__10 = c_rt_lib_NL.NL_get_ref_hash(___nl__9,___nl__10).clone();

//line 337
___ref______nl__10 = new ImmRef(___nl__10);
array_NL.NL_push(___ref______nl__10,___nl__7);
___nl__10 = ___ref______nl__10.getValue().clone();

//line 337
___nl__11 = new ImmString("holes").clone();
//line 337
___ref______nl__9 = new ImmRef(___nl__9);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__9,___nl__11,___nl__10);
___nl__9 = ___ref______nl__9.getValue().clone();

//line 337
___nl__11 = new ImmString("global_const").clone();
//line 337
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__11,___nl__9);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 337
___nl__11 = null;
//line 337
___nl__9 = null;
//line 337
___nl__10 = null;
//line 338
if (true) {goto label_7;}
//line 338
label_7:
//line 338
___nl__8 = null;
//line 338
___nl__7 = null;
//line 339
___nl__6 = c_rt_lib_NL.NL_next_iter(___nl__6).clone();

//line 339
if (true) {goto label_5;}
//line 339
label_3:
//line 339
___nl__4 = null;
//line 339
___nl__5 = null;
//line 339
___nl__6 = null;
//line 340
___nl__4 = new ImmString("global_const").clone();
//line 340
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__4).clone();

//line 340
___nl__5 = new ImmString("module_consts").clone();
//line 340
___nl__5 = c_rt_lib_NL.NL_get_ref_hash(___nl__4,___nl__5).clone();

//line 340
___ref______nl__5 = new ImmRef(___nl__5);
hash_NL.NL_delete(___ref______nl__5,___nl__1);
___nl__5 = ___ref______nl__5.getValue().clone();

//line 340
___nl__6 = new ImmString("module_consts").clone();
//line 340
___ref______nl__4 = new ImmRef(___nl__4);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__4,___nl__6,___nl__5);
___nl__4 = ___ref______nl__4.getValue().clone();

//line 340
___nl__6 = new ImmString("global_const").clone();
//line 340
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__6,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 340
___nl__6 = null;
//line 340
___nl__4 = null;
//line 340
___nl__5 = null;
//line 340
___nl__3 = null;
//line 341
if (true) {goto label_2;}
//line 341
label_2:
//line 341
___nl__2 = null;
//line 341
___nl__1 = null;
//line 341
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_get_const_sim_priv(ImmRef ___arg__0, Imm ___arg__1) {
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
//line 344
___nl__3 = new ImmString("global_const").clone();
//line 344
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__3).clone();

//line 344
___nl__4 = ((ImmHash)___nl__0).getHashValue()["mod_name"].clone();
//line 344
___ref______nl__3 = new ImmRef(___nl__3);
___nl__2 = generator_c_NL.NL_get_global_const_priv(___ref______nl__3,___nl__1,___nl__4).clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 344
___nl__4 = null;
//line 344
___nl__4 = new ImmString("global_const").clone();
//line 344
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__4,___nl__3);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 344
___nl__4 = null;
//line 344
___nl__3 = null;
//line 345
___nl__3 = new ImmString("___get_global_const(").clone();
//line 345
___nl__3 = new ImmString(___nl__3.toString() + ___nl__2.toString()).clone();
//line 345
___nl__4 = new ImmString(")").clone();
//line 345
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 345
___nl__4 = null;
//line 345
___nl__1 = null;
//line 345
___nl__2 = null;
//line 345
___arg__0.setValue(___nl__0);if(true) return ___nl__3;
//line 345
___nl__3 = null;
//line 345
___nl__2 = null;
//line 345
___nl__1 = null;
//line 345
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_get_const_singleton_priv(ImmRef ___arg__0, Imm ___arg__1) {
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
//line 348
___nl__3 = new ImmString("const").clone();
//line 348
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__3).clone();

//line 348
___nl__4 = new ImmString("singleton").clone();
//line 348
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__3,___nl__4).clone();

//line 348
___ref______nl__4 = new ImmRef(___nl__4);
___nl__2 = generator_c_NL.NL_get_const_priv(___ref______nl__4,___nl__1).clone();
___nl__4 = ___ref______nl__4.getValue().clone();

//line 348
___nl__5 = new ImmString("singleton").clone();
//line 348
___ref______nl__3 = new ImmRef(___nl__3);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__3,___nl__5,___nl__4);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 348
___nl__5 = new ImmString("const").clone();
//line 348
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__3);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 348
___nl__5 = null;
//line 348
___nl__3 = null;
//line 348
___nl__4 = null;
//line 349
___nl__4 = new ImmString("").clone();
//line 349
___nl__5 = new ImmString("__const__sing").clone();
//line 349
___nl__6 = ((ImmHash)___nl__0).getHashValue()["mod_name"].clone();
//line 349
___nl__3 = generator_c_NL.NL_get_fun_name_priv(___nl__4,___nl__5,___nl__6).clone();

//line 349
___nl__6 = null;
//line 349
___nl__5 = null;
//line 349
___nl__4 = null;
//line 349
___nl__4 = new ImmString("(").clone();
//line 349
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 349
___nl__4 = null;
//line 349
___nl__3 = new ImmString(___nl__3.toString() + ___nl__2.toString()).clone();
//line 349
___nl__4 = new ImmString(")").clone();
//line 349
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 349
___nl__4 = null;
//line 349
___nl__1 = null;
//line 349
___nl__2 = null;
//line 349
___arg__0.setValue(___nl__0);if(true) return ___nl__3;
//line 349
___nl__3 = null;
//line 349
___nl__2 = null;
//line 349
___nl__1 = null;
//line 349
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_get_func_ptr_header_priv(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 352
___nl__2 = generator_c_NL.NL_arg_t_priv().clone();

//line 352
___nl__3 = generator_c_NL.NL_get_function_name_priv(___nl__0,___nl__1).clone();

//line 352
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 352
___nl__3 = null;
//line 352
___nl__3 = new ImmString("0ptr(int _num, ImmT *_tab)").clone();
//line 352
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 352
___nl__3 = null;
//line 352
___nl__0 = null;
//line 352
___nl__1 = null;
//line 352
if(true) return ___nl__2;
//line 352
___nl__2 = null;
//line 352
___nl__0 = null;
//line 352
___nl__1 = null;
//line 352
if(true) return null;
}

private static Imm NL_print_mod_priv(ImmRef ___arg__0, Imm ___arg__1) {
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
//line 356
___nl__2 = generator_c_NL.NL_get_cr_priv().clone();

//line 356
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_to_header_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 356
___nl__2 = null;
//line 357
___nl__2 = new ImmString("#pragma once").clone();
//line 357
___nl__3 = string_NL.NL_lf().clone();

//line 357
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 357
___nl__3 = null;
//line 357
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_to_header_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 357
___nl__2 = null;
//line 358
___nl__3 = new ImmString("c_rt_lib").clone();
//line 358
___nl__2 = generator_c_NL.NL_get_include_priv(___nl__3).clone();

//line 358
___nl__3 = null;
//line 358
___nl__3 = string_NL.NL_lf().clone();

//line 358
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 358
___nl__3 = null;
//line 358
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_to_header_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 358
___nl__2 = null;
//line 360
___nl__2 = generator_c_NL.NL_get_cr_priv().clone();

//line 360
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 360
___nl__2 = null;
//line 361
___nl__3 = new ImmString("c_rt_lib").clone();
//line 361
___nl__2 = generator_c_NL.NL_get_include_priv(___nl__3).clone();

//line 361
___nl__3 = null;
//line 361
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 361
___nl__2 = null;
//line 362
___nl__3 = new ImmString("c_global_const").clone();
//line 362
___nl__2 = generator_c_NL.NL_get_include_priv(___nl__3).clone();

//line 362
___nl__3 = null;
//line 362
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 362
___nl__2 = null;
//line 363
___nl__3 = ((ImmHash)___nl__0).getHashValue()["mod_name"].clone();
//line 363
___nl__2 = generator_c_NL.NL_get_include_priv(___nl__3).clone();

//line 363
___nl__3 = null;
//line 363
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 363
___nl__2 = null;
//line 365
___nl__2 = ((ImmHash)___nl__1).getHashValue()["imports"].clone();
//line 365
___nl__4 = new ImmDouble(0).clone();
//line 365
___nl__5 = new ImmDouble(1).clone();
//line 365
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__2).clone();

//line 365
label_3:
//line 365
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) ).clone();
//line 365
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_1;}}
//line 365
___nl__3 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()].clone();
//line 366
___nl__8 = generator_c_NL.NL_get_include_priv(___nl__3).clone();

//line 366
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__8);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 366
___nl__8 = null;
//line 367
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 367
if (true) {goto label_3;}
//line 367
label_1:
//line 367
___nl__2 = null;
//line 367
___nl__3 = null;
//line 367
___nl__4 = null;
//line 367
___nl__5 = null;
//line 367
___nl__6 = null;
//line 367
___nl__7 = null;
//line 368
___nl__2 = new ImmString("#line 1 \"").clone();
//line 368
___nl__3 = ((ImmHash)___nl__0).getHashValue()["mod_name"].clone();
//line 368
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 368
___nl__3 = null;
//line 368
___nl__3 = new ImmString(".nl\"").clone();
//line 368
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 368
___nl__3 = null;
//line 368
___nl__3 = string_NL.NL_lf().clone();

//line 368
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 368
___nl__3 = null;
//line 368
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 368
___nl__2 = null;
//line 371
___nl__2 = new ImmString("static ").clone();
//line 371
___nl__3 = generator_c_NL.NL_arg_t_priv().clone();

//line 371
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 371
___nl__3 = null;
//line 371
___nl__3 = new ImmString("*__const__f = NULL;").clone();
//line 371
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 371
___nl__3 = null;
//line 371
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 371
___nl__2 = null;
//line 372
___nl__2 = new ImmString("void ").clone();
//line 372
___nl__4 = new ImmString("").clone();
//line 372
___nl__5 = new ImmString("__const__init").clone();
//line 372
___nl__6 = ((ImmHash)___nl__0).getHashValue()["mod_name"].clone();
//line 372
___nl__3 = generator_c_NL.NL_get_fun_name_priv(___nl__4,___nl__5,___nl__6).clone();

//line 372
___nl__6 = null;
//line 372
___nl__5 = null;
//line 372
___nl__4 = null;
//line 372
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 372
___nl__3 = null;
//line 372
___nl__3 = new ImmString("();").clone();
//line 372
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 372
___nl__3 = null;
//line 372
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 372
___nl__2 = null;
//line 373
___nl__2 = generator_c_NL.NL_arg_t_priv().clone();

//line 373
___nl__4 = new ImmString("").clone();
//line 373
___nl__5 = new ImmString("__const__sim").clone();
//line 373
___nl__6 = ((ImmHash)___nl__0).getHashValue()["mod_name"].clone();
//line 373
___nl__3 = generator_c_NL.NL_get_fun_name_priv(___nl__4,___nl__5,___nl__6).clone();

//line 373
___nl__6 = null;
//line 373
___nl__5 = null;
//line 373
___nl__4 = null;
//line 373
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 373
___nl__3 = null;
//line 373
___nl__3 = new ImmString("(int __nr);").clone();
//line 373
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 373
___nl__3 = null;
//line 373
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 373
___nl__2 = null;
//line 374
___nl__2 = generator_c_NL.NL_arg_t_priv().clone();

//line 374
___nl__4 = new ImmString("").clone();
//line 374
___nl__5 = new ImmString("__const__sing").clone();
//line 374
___nl__6 = ((ImmHash)___nl__0).getHashValue()["mod_name"].clone();
//line 374
___nl__3 = generator_c_NL.NL_get_fun_name_priv(___nl__4,___nl__5,___nl__6).clone();

//line 374
___nl__6 = null;
//line 374
___nl__5 = null;
//line 374
___nl__4 = null;
//line 374
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 374
___nl__3 = null;
//line 374
___nl__3 = new ImmString("(int __nr);").clone();
//line 374
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 374
___nl__3 = null;
//line 374
___nl__3 = string_NL.NL_lf().clone();

//line 374
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 374
___nl__3 = null;
//line 374
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 374
___nl__2 = null;
//line 376
___nl__2 = ((ImmHash)___nl__1).getHashValue()["functions"].clone();
//line 376
___nl__4 = new ImmDouble(0).clone();
//line 376
___nl__5 = new ImmDouble(1).clone();
//line 376
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__2).clone();

//line 376
label_6:
//line 376
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) ).clone();
//line 376
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_4;}}
//line 376
___nl__3 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()].clone();
//line 377
___nl__9 = ((ImmHash)___nl__0).getHashValue()["mod_name"].clone();
//line 377
___nl__8 = generator_c_NL.NL_get_function_header_priv(___nl__3,___nl__9).clone();

//line 377
___nl__9 = null;
//line 378
___nl__9 = ((ImmHash)___nl__3).getHashValue()["access"].clone();
//line 378
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__9, new ImmString("pub")).clone();
//line 378
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_8;}}
//line 381
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__9, new ImmString("priv")).clone();
//line 381
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_9;}}
//line 381
___nl__10 = new ImmString("NOMATCHALERT").clone();
//line 381
___nl__10 = new ImmArray(new Imm[] {___nl__10,___nl__9,}).clone();
//line 381
c_rt_lib_NL.NL_die();
//line 378
label_8:
//line 379
___nl__11 = new ImmString(";").clone();
//line 379
___nl__11 = new ImmString(___nl__8.toString() + ___nl__11.toString()).clone();
//line 379
___nl__12 = string_NL.NL_lf().clone();

//line 379
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString()).clone();
//line 379
___nl__12 = null;
//line 379
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_to_header_priv(___ref______nl__0,___nl__11);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 379
___nl__11 = null;
//line 380
___nl__12 = ((ImmHash)___nl__0).getHashValue()["mod_name"].clone();
//line 380
___nl__11 = generator_c_NL.NL_get_func_ptr_header_priv(___nl__3,___nl__12).clone();

//line 380
___nl__12 = null;
//line 380
___nl__12 = new ImmString(";").clone();
//line 380
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString()).clone();
//line 380
___nl__12 = null;
//line 380
___nl__12 = string_NL.NL_lf().clone();

//line 380
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString()).clone();
//line 380
___nl__12 = null;
//line 380
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_to_header_priv(___ref______nl__0,___nl__11);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 380
___nl__11 = null;
//line 381
if (true) {goto label_7;}
//line 381
label_9:
//line 382
___nl__11 = new ImmString(";").clone();
//line 382
___nl__11 = new ImmString(___nl__8.toString() + ___nl__11.toString()).clone();
//line 382
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__11);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 382
___nl__11 = null;
//line 383
if (true) {goto label_7;}
//line 383
label_7:
//line 383
___nl__9 = null;
//line 383
___nl__10 = null;
//line 383
___nl__8 = null;
//line 384
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 384
if (true) {goto label_6;}
//line 384
label_4:
//line 384
___nl__2 = null;
//line 384
___nl__3 = null;
//line 384
___nl__4 = null;
//line 384
___nl__5 = null;
//line 384
___nl__6 = null;
//line 384
___nl__7 = null;
//line 385
___nl__2 = string_NL.NL_lf().clone();

//line 385
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 385
___nl__2 = null;
//line 387
___nl__2 = ((ImmHash)___nl__1).getHashValue()["functions"].clone();
//line 387
___nl__4 = new ImmDouble(0).clone();
//line 387
___nl__5 = new ImmDouble(1).clone();
//line 387
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__2).clone();

//line 387
label_12:
//line 387
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) ).clone();
//line 387
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_10;}}
//line 387
___nl__3 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()].clone();
//line 388
___nl__8 = ((ImmHash)___nl__3).getHashValue()["access"].clone();
//line 388
___nl__8 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("pub")).clone();
//line 388
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 388
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_14;}}
//line 389
___nl__10 = ((ImmHash)___nl__0).getHashValue()["mod_name"].clone();
//line 389
___nl__9 = generator_c_NL.NL_get_function_name_priv(___nl__3,___nl__10).clone();

//line 389
___nl__10 = null;
//line 390
___nl__11 = ((ImmHash)___nl__0).getHashValue()["mod_name"].clone();
//line 390
___nl__10 = generator_c_NL.NL_get_func_ptr_header_priv(___nl__3,___nl__11).clone();

//line 390
___nl__11 = null;
//line 390
___nl__11 = new ImmString("{").clone();
//line 390
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString()).clone();
//line 390
___nl__11 = null;
//line 390
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__10);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 390
___nl__10 = null;
//line 391
___nl__11 = ((ImmHash)___nl__3).getHashValue()["args_type"].clone();
//line 391
___nl__10 = array_NL.NL_len(___nl__11).clone();

//line 391
___nl__11 = null;
//line 392
___nl__12 = new ImmString("func_num_args").clone();
//line 392
___nl__14 = new ImmString("_num").clone();
//line 392
___nl__15 = generator_c_NL.NL_get_string_priv(___nl__9).clone();

//line 392
___nl__13 = new ImmArray(new Imm[] {___nl__14,___nl__10,___nl__15,}).clone();
//line 392
___nl__14 = null;
//line 392
___nl__15 = null;
//line 392
___nl__11 = generator_c_NL.NL_get_fun_lib_priv(___nl__12,___nl__13).clone();

//line 392
___nl__13 = null;
//line 392
___nl__12 = null;
//line 392
___nl__12 = new ImmString(";").clone();
//line 392
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString()).clone();
//line 392
___nl__12 = null;
//line 392
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__11);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 392
___nl__11 = null;
//line 393
___nl__11 = new ImmString("return ").clone();
//line 393
___nl__11 = new ImmString(___nl__11.toString() + ___nl__9.toString()).clone();
//line 393
___nl__12 = new ImmString("(").clone();
//line 393
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString()).clone();
//line 393
___nl__12 = null;
//line 393
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__11);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 393
___nl__11 = null;
//line 394
___nl__11 = new ImmDouble(0).clone();
//line 394
___nl__12 = new ImmDouble(1).clone();
//line 394
label_17:
//line 394
___nl__13 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__11.getValue().ToString()))>=(Double.Parse(___nl__10.getValue().ToString())) ).clone();
//line 394
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_15;}}
//line 395
___nl__14 = new ImmDouble(0).clone();
//line 395
___nl__14 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__11.getValue().ToString()))>(Double.Parse(___nl__14.getValue().ToString())) ).clone();
//line 395
___nl__14 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__14)).clone();
//line 395
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_19;}}
//line 395
___nl__15 = new ImmString(", ").clone();
//line 395
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__15);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 395
___nl__15 = null;
//line 395
if (true) {goto label_19;}
//line 395
label_19:
//line 395
___nl__14 = null;
//line 396
___nl__14 = ((ImmHash)___nl__3).getHashValue()["args_type"].clone();
//line 396
___nl__14 = (___nl__14 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__11).getDoubleValue()].clone();
//line 396
___nl__15 = c_rt_lib_NL.NL_ov_is(___nl__14, new ImmString("val")).clone();
//line 396
if (c_rt_lib_NL.NL_check_true_native(___nl__15)) {if (true) {goto label_21;}}
//line 398
___nl__15 = c_rt_lib_NL.NL_ov_is(___nl__14, new ImmString("ref")).clone();
//line 398
if (c_rt_lib_NL.NL_check_true_native(___nl__15)) {if (true) {goto label_22;}}
//line 398
___nl__15 = new ImmString("NOMATCHALERT").clone();
//line 398
___nl__15 = new ImmArray(new Imm[] {___nl__15,___nl__14,}).clone();
//line 398
c_rt_lib_NL.NL_die();
//line 396
label_21:
//line 397
___nl__16 = new ImmString("_tab[").clone();
//line 397
___nl__16 = new ImmString(___nl__16.toString() + ___nl__11.toString()).clone();
//line 397
___nl__17 = new ImmString("]").clone();
//line 397
___nl__16 = new ImmString(___nl__16.toString() + ___nl__17.toString()).clone();
//line 397
___nl__17 = null;
//line 397
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__16);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 397
___nl__16 = null;
//line 398
if (true) {goto label_20;}
//line 398
label_22:
//line 399
___nl__16 = new ImmString("&_tab[").clone();
//line 399
___nl__16 = new ImmString(___nl__16.toString() + ___nl__11.toString()).clone();
//line 399
___nl__17 = new ImmString("]").clone();
//line 399
___nl__16 = new ImmString(___nl__16.toString() + ___nl__17.toString()).clone();
//line 399
___nl__17 = null;
//line 399
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__16);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 399
___nl__16 = null;
//line 400
if (true) {goto label_20;}
//line 400
label_20:
//line 400
___nl__14 = null;
//line 400
___nl__15 = null;
//line 401
___nl__11 = new ImmDouble((Double.Parse(___nl__11.getValue().ToString()))+(Double.Parse(___nl__12.getValue().ToString()))).clone();
//line 401
if (true) {goto label_17;}
//line 401
label_15:
//line 401
___nl__11 = null;
//line 401
___nl__12 = null;
//line 401
___nl__13 = null;
//line 402
___nl__11 = new ImmString(");}").clone();
//line 402
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__11);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 402
___nl__11 = null;
//line 402
___nl__9 = null;
//line 402
___nl__10 = null;
//line 403
if (true) {goto label_14;}
//line 403
label_14:
//line 403
___nl__8 = null;
//line 404
___nl__8 = generator_c_NL.NL_is_singleton_use_function_priv(___nl__3).clone();

//line 404
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8)).clone();
//line 404
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_24;}}
//line 405
___nl__10 = ((ImmHash)___nl__0).getHashValue()["mod_name"].clone();
//line 405
___nl__9 = generator_c_NL.NL_get_function_name_priv(___nl__3,___nl__10).clone();

//line 405
___nl__10 = null;
//line 406
___nl__10 = generator_c_NL.NL_arg_t_priv().clone();

//line 406
___nl__10 = new ImmString(___nl__10.toString() + ___nl__9.toString()).clone();
//line 406
___nl__11 = new ImmString("(){").clone();
//line 406
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString()).clone();
//line 406
___nl__11 = null;
//line 406
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__10);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 406
___nl__10 = null;
//line 407
___nl__11 = new ImmString("").clone();
//line 407
___nl__12 = new ImmString("__const__init").clone();
//line 407
___nl__13 = ((ImmHash)___nl__0).getHashValue()["mod_name"].clone();
//line 407
___nl__10 = generator_c_NL.NL_get_fun_name_priv(___nl__11,___nl__12,___nl__13).clone();

//line 407
___nl__13 = null;
//line 407
___nl__12 = null;
//line 407
___nl__11 = null;
//line 407
___nl__11 = new ImmString("();").clone();
//line 407
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString()).clone();
//line 407
___nl__11 = null;
//line 407
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__10);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 407
___nl__10 = null;
//line 408
___nl__10 = new ImmString("return ").clone();
//line 408
___ref______nl__0 = new ImmRef(___nl__0);
___nl__11 = generator_c_NL.NL_get_const_singleton_priv(___ref______nl__0,___nl__9).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 408
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString()).clone();
//line 408
___nl__11 = null;
//line 408
___nl__11 = new ImmString(";}").clone();
//line 408
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString()).clone();
//line 408
___nl__11 = null;
//line 408
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__10);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 408
___nl__10 = null;
//line 409
___nl__10 = generator_c_NL.NL_arg_t_priv().clone();

//line 409
___nl__10 = new ImmString(___nl__10.toString() + ___nl__9.toString()).clone();
//line 409
___nl__11 = new ImmString("0cal()").clone();
//line 409
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString()).clone();
//line 409
___nl__11 = null;
//line 409
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__10);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 409
___nl__10 = null;
//line 409
___nl__9 = null;
//line 410
if (true) {goto label_23;}
//line 410
label_24:
//line 411
___nl__10 = ((ImmHash)___nl__0).getHashValue()["mod_name"].clone();
//line 411
___nl__9 = generator_c_NL.NL_get_function_header_priv(___nl__3,___nl__10).clone();

//line 411
___nl__10 = null;
//line 411
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__9);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 411
___nl__9 = null;
//line 412
if (true) {goto label_23;}
//line 412
label_23:
//line 412
___nl__8 = null;
//line 413
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_function_block_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 414
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 414
if (true) {goto label_12;}
//line 414
label_10:
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
___nl__7 = null;
//line 415
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_init_const_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 415
___nl__1 = null;
//line 415
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_print_init_const_priv(ImmRef ___arg__0) {
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
//line 418
___nl__1 = ((ImmHash)___nl__0).getHashValue()["const"].clone();
//line 418
___nl__1 = ((ImmHash)___nl__1).getHashValue()["sim"].clone();
//line 418
___nl__1 = ((ImmHash)___nl__1).getHashValue()["arr"].clone();
//line 419
___nl__2 = ((ImmHash)___nl__0).getHashValue()["const"].clone();
//line 419
___nl__2 = ((ImmHash)___nl__2).getHashValue()["singleton"].clone();
//line 419
___nl__2 = ((ImmHash)___nl__2).getHashValue()["arr"].clone();
//line 420
___nl__3 = array_NL.NL_len(___nl__1).clone();

//line 421
___nl__4 = array_NL.NL_len(___nl__2).clone();

//line 422
___nl__5 = ((ImmHash)___nl__0).getHashValue()["const"].clone();
//line 422
___nl__5 = ((ImmHash)___nl__5).getHashValue()["dynamic_nr"].clone();
//line 423
___nl__6 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString()))).clone();
//line 423
___nl__6 = new ImmDouble((Double.Parse(___nl__6.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 424
___nl__7 = new ImmString("\nstatic ").clone();
//line 424
___nl__8 = generator_c_NL.NL_arg_t_priv().clone();

//line 424
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 424
___nl__8 = null;
//line 424
___nl__8 = new ImmString("___const__[").clone();
//line 424
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 424
___nl__8 = null;
//line 424
___nl__8 = new ImmDouble(1).clone();
//line 424
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString()))).clone();
//line 424
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 424
___nl__8 = null;
//line 424
___nl__8 = new ImmString("];\nstatic int ___const_init__ = 1;").clone();
//line 424
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 424
___nl__8 = null;
//line 424
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 424
___nl__7 = null;
//line 427
___nl__7 = new ImmString("void ").clone();
//line 427
___nl__9 = new ImmString("").clone();
//line 427
___nl__10 = new ImmString("__const__init").clone();
//line 427
___nl__11 = ((ImmHash)___nl__0).getHashValue()["mod_name"].clone();
//line 427
___nl__8 = generator_c_NL.NL_get_fun_name_priv(___nl__9,___nl__10,___nl__11).clone();

//line 427
___nl__11 = null;
//line 427
___nl__10 = null;
//line 427
___nl__9 = null;
//line 427
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 427
___nl__8 = null;
//line 427
___nl__8 = new ImmString("(){\nif(___const_init__) {\n___const_init__ = 0;\n__const__f = &___const__[").clone();
//line 427
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 427
___nl__8 = null;
//line 427
___nl__8 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString()))).clone();
//line 427
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 427
___nl__8 = null;
//line 427
___nl__8 = new ImmString("];\n").clone();
//line 427
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 427
___nl__8 = null;
//line 427
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 427
___nl__7 = null;
//line 432
___nl__7 = new ImmDouble(0).clone();
//line 432
___nl__8 = new ImmDouble(1).clone();
//line 432
label_3:
//line 432
___nl__9 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))>=(Double.Parse(___nl__3.getValue().ToString())) ).clone();
//line 432
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_1;}}
//line 433
___nl__10 = new ImmString("___const__[").clone();
//line 433
___nl__10 = new ImmString(___nl__10.toString() + ___nl__7.toString()).clone();
//line 433
___nl__11 = new ImmString("] = ").clone();
//line 433
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString()).clone();
//line 433
___nl__11 = null;
//line 433
___nl__12 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()].clone();
//line 433
___nl__11 = generator_c_NL.NL_create_sim_priv(___nl__12).clone();

//line 433
___nl__12 = null;
//line 433
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString()).clone();
//line 433
___nl__11 = null;
//line 433
___nl__11 = new ImmString(";").clone();
//line 433
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString()).clone();
//line 433
___nl__11 = null;
//line 433
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__10);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 433
___nl__10 = null;
//line 434
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString()))).clone();
//line 434
if (true) {goto label_3;}
//line 434
label_1:
//line 434
___nl__7 = null;
//line 434
___nl__8 = null;
//line 434
___nl__9 = null;
//line 435
___nl__7 = new ImmString("\nfor(int i=").clone();
//line 435
___nl__7 = new ImmString(___nl__7.toString() + ___nl__3.toString()).clone();
//line 435
___nl__8 = new ImmString(";i<").clone();
//line 435
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 435
___nl__8 = null;
//line 435
___nl__7 = new ImmString(___nl__7.toString() + ___nl__6.toString()).clone();
//line 435
___nl__8 = new ImmString(";++i) ___const__[i] = NULL;\n").clone();
//line 435
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 435
___nl__8 = null;
//line 435
___nl__9 = new ImmString("register_const").clone();
//line 435
___nl__8 = generator_c_NL.NL_get_lib_fun_priv(___nl__9).clone();

//line 435
___nl__9 = null;
//line 435
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 435
___nl__8 = null;
//line 435
___nl__8 = new ImmString("(___const__, ").clone();
//line 435
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 435
___nl__8 = null;
//line 435
___nl__7 = new ImmString(___nl__7.toString() + ___nl__6.toString()).clone();
//line 435
___nl__8 = new ImmString(");\n}}").clone();
//line 435
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 435
___nl__8 = null;
//line 435
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 435
___nl__7 = null;
//line 439
___nl__7 = generator_c_NL.NL_arg_t_priv().clone();

//line 439
___nl__9 = new ImmString("").clone();
//line 439
___nl__10 = new ImmString("__const__sim").clone();
//line 439
___nl__11 = ((ImmHash)___nl__0).getHashValue()["mod_name"].clone();
//line 439
___nl__8 = generator_c_NL.NL_get_fun_name_priv(___nl__9,___nl__10,___nl__11).clone();

//line 439
___nl__11 = null;
//line 439
___nl__10 = null;
//line 439
___nl__9 = null;
//line 439
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 439
___nl__8 = null;
//line 439
___nl__8 = new ImmString("(int __nr) {\n").clone();
//line 439
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 439
___nl__8 = null;
//line 439
___nl__8 = generator_c_NL.NL_arg_t_priv().clone();

//line 439
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 439
___nl__8 = null;
//line 439
___nl__8 = new ImmString("ret = NULL;\n").clone();
//line 439
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 439
___nl__8 = null;
//line 439
___nl__9 = new ImmString("copy").clone();
//line 439
___nl__11 = new ImmString("&ret").clone();
//line 439
___nl__12 = new ImmString("___const__[__nr]").clone();
//line 439
___nl__10 = new ImmArray(new Imm[] {___nl__11,___nl__12,}).clone();
//line 439
___nl__11 = null;
//line 439
___nl__12 = null;
//line 439
___nl__8 = generator_c_NL.NL_get_fun_lib_priv(___nl__9,___nl__10).clone();

//line 439
___nl__10 = null;
//line 439
___nl__9 = null;
//line 439
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 439
___nl__8 = null;
//line 439
___nl__8 = new ImmString(";\nreturn ret;\n}").clone();
//line 439
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 439
___nl__8 = null;
//line 439
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 439
___nl__7 = null;
//line 444
___nl__7 = generator_c_NL.NL_arg_t_priv().clone();

//line 444
___nl__9 = new ImmString("").clone();
//line 444
___nl__10 = new ImmString("__const__sing").clone();
//line 444
___nl__11 = ((ImmHash)___nl__0).getHashValue()["mod_name"].clone();
//line 444
___nl__8 = generator_c_NL.NL_get_fun_name_priv(___nl__9,___nl__10,___nl__11).clone();

//line 444
___nl__11 = null;
//line 444
___nl__10 = null;
//line 444
___nl__9 = null;
//line 444
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 444
___nl__8 = null;
//line 444
___nl__8 = new ImmString("(int __nr) {\nif(___const__[__nr+").clone();
//line 444
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 444
___nl__8 = null;
//line 444
___nl__7 = new ImmString(___nl__7.toString() + ___nl__3.toString()).clone();
//line 444
___nl__8 = new ImmString("]==NULL) {\nswitch(__nr){").clone();
//line 444
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 444
___nl__8 = null;
//line 444
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 444
___nl__7 = null;
//line 447
___nl__7 = array_NL.NL_len(___nl__2).clone();

//line 447
___nl__8 = new ImmDouble(0).clone();
//line 447
___nl__9 = new ImmDouble(1).clone();
//line 447
label_6:
//line 447
___nl__10 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) ).clone();
//line 447
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_4;}}
//line 448
___nl__11 = new ImmString("case ").clone();
//line 448
___nl__11 = new ImmString(___nl__11.toString() + ___nl__8.toString()).clone();
//line 448
___nl__12 = new ImmString(":").clone();
//line 448
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString()).clone();
//line 448
___nl__12 = null;
//line 448
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__11);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 448
___nl__11 = null;
//line 449
___nl__11 = new ImmString("	___const__[").clone();
//line 449
___nl__12 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))+(Double.Parse(___nl__3.getValue().ToString()))).clone();
//line 449
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString()).clone();
//line 449
___nl__12 = null;
//line 449
___nl__12 = new ImmString("] = ").clone();
//line 449
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString()).clone();
//line 449
___nl__12 = null;
//line 449
___nl__12 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()].clone();
//line 449
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString()).clone();
//line 449
___nl__12 = null;
//line 449
___nl__12 = new ImmString("0cal();").clone();
//line 449
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString()).clone();
//line 449
___nl__12 = null;
//line 449
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__11);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 449
___nl__11 = null;
//line 450
___nl__11 = new ImmString("	break;").clone();
//line 450
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__11);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 450
___nl__11 = null;
//line 451
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))+(Double.Parse(___nl__9.getValue().ToString()))).clone();
//line 451
if (true) {goto label_6;}
//line 451
label_4:
//line 451
___nl__7 = null;
//line 451
___nl__8 = null;
//line 451
___nl__9 = null;
//line 451
___nl__10 = null;
//line 452
___nl__7 = new ImmString("default:\n	nl_die();\n}}\n").clone();
//line 452
___nl__8 = generator_c_NL.NL_arg_t_priv().clone();

//line 452
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 452
___nl__8 = null;
//line 452
___nl__8 = new ImmString("ret = NULL;\n").clone();
//line 452
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 452
___nl__8 = null;
//line 452
___nl__9 = new ImmString("copy").clone();
//line 452
___nl__11 = new ImmString("&ret").clone();
//line 452
___nl__12 = new ImmString("___const__[__nr+").clone();
//line 452
___nl__12 = new ImmString(___nl__12.toString() + ___nl__3.toString()).clone();
//line 452
___nl__13 = new ImmString("]").clone();
//line 452
___nl__12 = new ImmString(___nl__12.toString() + ___nl__13.toString()).clone();
//line 452
___nl__13 = null;
//line 452
___nl__10 = new ImmArray(new Imm[] {___nl__11,___nl__12,}).clone();
//line 452
___nl__11 = null;
//line 452
___nl__12 = null;
//line 452
___nl__8 = generator_c_NL.NL_get_fun_lib_priv(___nl__9,___nl__10).clone();

//line 452
___nl__10 = null;
//line 452
___nl__9 = null;
//line 452
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 452
___nl__8 = null;
//line 452
___nl__8 = new ImmString(";\nreturn ret;\n}").clone();
//line 452
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 452
___nl__8 = null;
//line 452
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 452
___nl__7 = null;
//line 452
___nl__1 = null;
//line 452
___nl__2 = null;
//line 452
___nl__3 = null;
//line 452
___nl__4 = null;
//line 452
___nl__5 = null;
//line 452
___nl__6 = null;
//line 452
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_print_function_block_priv(ImmRef ___arg__0, Imm ___arg__1) {
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
ImmRef ___ref______nl__24 = null;
Dictionary<String, Imm> __function_map;
//line 461
___nl__2 = new ImmString(" {").clone();
//line 461
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 461
___nl__2 = null;
//line 462
___nl__2 = ((ImmHash)___nl__1).getHashValue()["args_type"].clone();
//line 462
___nl__3 = ___nl__2.clone();
//line 462
((ImmHash)___nl__0).set("fun_args", ___nl__3);
//line 462
___nl__2 = null;
//line 462
___nl__3 = null;
//line 463
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_move_args_to_register_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 464
___nl__3 = new ImmString("").clone();
//line 464
___nl__4 = new ImmString("__const__init").clone();
//line 464
___nl__5 = ((ImmHash)___nl__0).getHashValue()["mod_name"].clone();
//line 464
___nl__2 = generator_c_NL.NL_get_fun_name_priv(___nl__3,___nl__4,___nl__5).clone();

//line 464
___nl__5 = null;
//line 464
___nl__4 = null;
//line 464
___nl__3 = null;
//line 464
___nl__3 = new ImmString("();").clone();
//line 464
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 464
___nl__3 = null;
//line 464
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 464
___nl__2 = null;
//line 465
___nl__3 = ((ImmHash)___nl__1).getHashValue()["args_type"].clone();
//line 465
___nl__2 = array_NL.NL_len(___nl__3).clone();

//line 465
___nl__3 = null;
//line 465
label_2:
//line 465
___nl__3 = ((ImmHash)___nl__1).getHashValue()["reg_size"].clone();
//line 465
___nl__3 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__2.getValue().ToString()))<(Double.Parse(___nl__3.getValue().ToString())) ).clone();
//line 465
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 465
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_1;}}
//line 466
___nl__4 = generator_c_NL.NL_arg_t_priv().clone();

//line 466
___ref______nl__0 = new ImmRef(___nl__0);
___nl__5 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__2).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 466
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 466
___nl__5 = null;
//line 466
___nl__5 = new ImmString(" = NULL;").clone();
//line 466
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 466
___nl__5 = null;
//line 466
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 466
___nl__4 = null;
//line 466
___nl__4 = new ImmDouble(1).clone();
//line 466
___nl__2 = new ImmDouble((Double.Parse(___nl__2.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString()))).clone();
//line 466
___nl__4 = null;
//line 467
if (true) {goto label_2;}
//line 467
label_1:
//line 467
___nl__2 = null;
//line 467
___nl__3 = null;
//line 468
___nl__2 = ((ImmHash)___nl__1).getHashValue()["commands"].clone();
//line 468
___nl__4 = new ImmDouble(0).clone();
//line 468
___nl__5 = new ImmDouble(1).clone();
//line 468
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__2).clone();

//line 468
label_6:
//line 468
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) ).clone();
//line 468
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_4;}}
//line 468
___nl__3 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()].clone();
//line 469
___nl__8 = ((ImmHash)___nl__3).getHashValue()["annotation"].clone();
//line 469
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("none")).clone();
//line 469
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_8;}}
//line 471
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("const")).clone();
//line 471
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_9;}}
//line 471
___nl__9 = new ImmString("NOMATCHALERT").clone();
//line 471
___nl__9 = new ImmArray(new Imm[] {___nl__9,___nl__8,}).clone();
//line 471
c_rt_lib_NL.NL_die();
//line 469
label_8:
//line 470
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_cmd_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 471
if (true) {goto label_7;}
//line 471
label_9:
//line 471
___nl__10 = c_rt_lib_NL.NL_ov_as(___nl__8, new ImmString("const")).clone();
//line 472
___nl__11 = ((ImmHash)___nl__3).getHashValue()["cmd"].clone();
//line 472
___nl__11 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("load_const")).clone();
//line 472
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 472
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_11;}}
//line 473
___nl__12 = ((ImmHash)___nl__3).getHashValue()["cmd"].clone();
//line 473
___nl__12 = c_rt_lib_NL.NL_ov_as(___nl__12, new ImmString("load_const")).clone();
//line 473
___nl__12 = ((ImmHash)___nl__12).getHashValue()["val"].clone();
//line 474
___nl__13 = nl_NL.NL_is_sim(___nl__12).clone();

//line 474
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13)).clone();
//line 474
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_13;}}
//line 475
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_cmd_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 476
___nl__8 = null;
//line 476
___nl__9 = null;
//line 476
___nl__10 = null;
//line 476
___nl__11 = null;
//line 476
___nl__12 = null;
//line 476
___nl__13 = null;
//line 476
if (true) {goto label_5;}
//line 477
if (true) {goto label_13;}
//line 477
label_13:
//line 477
___nl__13 = null;
//line 477
___nl__12 = null;
//line 478
if (true) {goto label_11;}
//line 478
label_11:
//line 478
___nl__11 = null;
//line 479
___nl__11 = array_NL.NL_len(___nl__10).clone();

//line 480
___nl__12 = new ImmDouble(0).clone();
//line 480
___nl__12 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__11.getValue().ToString())) ==((Double.Parse(___nl__12.getValue().ToString())))  ).clone();
//line 480
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 480
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_15;}}
//line 481
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_cmd_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 482
___nl__8 = null;
//line 482
___nl__9 = null;
//line 482
___nl__10 = null;
//line 482
___nl__11 = null;
//line 482
___nl__12 = null;
//line 482
if (true) {goto label_5;}
//line 483
if (true) {goto label_14;}
//line 483
label_15:
//line 484
___nl__13 = ((ImmHash)___nl__0).getHashValue()["const"].clone();
//line 484
___nl__13 = ((ImmHash)___nl__13).getHashValue()["dynamic_nr"].clone();
//line 485
___nl__14 = new ImmString("if(__const__f[").clone();
//line 485
___nl__14 = new ImmString(___nl__14.toString() + ___nl__13.toString()).clone();
//line 485
___nl__15 = new ImmString("] == NULL) {").clone();
//line 485
___nl__14 = new ImmString(___nl__14.toString() + ___nl__15.toString()).clone();
//line 485
___nl__15 = null;
//line 485
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__14);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 485
___nl__14 = null;
//line 486
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_cmd_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 487
___nl__15 = new ImmDouble(0).clone();
//line 487
___nl__16 = new ImmDouble(1).clone();
//line 487
___nl__17 = c_rt_lib_NL.NL_array_len(___nl__10).clone();

//line 487
label_18:
//line 487
___nl__18 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__15.getValue().ToString()))>=(Double.Parse(___nl__17.getValue().ToString())) ).clone();
//line 487
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_16;}}
//line 487
___nl__14 = (___nl__10 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__15).getDoubleValue()].clone();
//line 488
___nl__20 = new ImmString("copy").clone();
//line 488
___nl__22 = new ImmString("&__const__f[").clone();
//line 488
___nl__22 = new ImmString(___nl__22.toString() + ___nl__13.toString()).clone();
//line 488
___nl__23 = new ImmString("]").clone();
//line 488
___nl__22 = new ImmString(___nl__22.toString() + ___nl__23.toString()).clone();
//line 488
___nl__23 = null;
//line 488
___ref______nl__0 = new ImmRef(___nl__0);
___nl__23 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__14).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 488
___nl__21 = new ImmArray(new Imm[] {___nl__22,___nl__23,}).clone();
//line 488
___nl__22 = null;
//line 488
___nl__23 = null;
//line 488
___nl__19 = generator_c_NL.NL_get_fun_lib_priv(___nl__20,___nl__21).clone();

//line 488
___nl__21 = null;
//line 488
___nl__20 = null;
//line 488
___nl__20 = new ImmString(";").clone();
//line 488
___nl__19 = new ImmString(___nl__19.toString() + ___nl__20.toString()).clone();
//line 488
___nl__20 = null;
//line 488
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__19);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 488
___nl__19 = null;
//line 489
___nl__19 = new ImmDouble(1).clone();
//line 489
___nl__13 = new ImmDouble((Double.Parse(___nl__13.getValue().ToString()))+(Double.Parse(___nl__19.getValue().ToString()))).clone();
//line 489
___nl__19 = null;
//line 490
___nl__15 = new ImmDouble((Double.Parse(___nl__15.getValue().ToString()))+(Double.Parse(___nl__16.getValue().ToString()))).clone();
//line 490
if (true) {goto label_18;}
//line 490
label_16:
//line 490
___nl__14 = null;
//line 490
___nl__15 = null;
//line 490
___nl__16 = null;
//line 490
___nl__17 = null;
//line 490
___nl__18 = null;
//line 491
___nl__14 = new ImmString("}").clone();
//line 491
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__14);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 491
___nl__14 = null;
//line 492
___nl__13 = new ImmDouble((Double.Parse(___nl__13.getValue().ToString()))-(Double.Parse(___nl__11.getValue().ToString()))).clone();
//line 493
___nl__15 = new ImmDouble(0).clone();
//line 493
___nl__16 = new ImmDouble(1).clone();
//line 493
___nl__17 = c_rt_lib_NL.NL_array_len(___nl__10).clone();

//line 493
label_21:
//line 493
___nl__18 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__15.getValue().ToString()))>=(Double.Parse(___nl__17.getValue().ToString())) ).clone();
//line 493
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_19;}}
//line 493
___nl__14 = (___nl__10 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__15).getDoubleValue()].clone();
//line 494
___nl__20 = new ImmString("copy").clone();
//line 494
___ref______nl__0 = new ImmRef(___nl__0);
___nl__22 = generator_c_NL.NL_get_reg_ref_priv(___ref______nl__0,___nl__14).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 494
___nl__23 = new ImmString("__const__f[").clone();
//line 494
___nl__23 = new ImmString(___nl__23.toString() + ___nl__13.toString()).clone();
//line 494
___nl__24 = new ImmString("]").clone();
//line 494
___nl__23 = new ImmString(___nl__23.toString() + ___nl__24.toString()).clone();
//line 494
___nl__24 = null;
//line 494
___nl__21 = new ImmArray(new Imm[] {___nl__22,___nl__23,}).clone();
//line 494
___nl__22 = null;
//line 494
___nl__23 = null;
//line 494
___nl__19 = generator_c_NL.NL_get_fun_lib_priv(___nl__20,___nl__21).clone();

//line 494
___nl__21 = null;
//line 494
___nl__20 = null;
//line 494
___nl__20 = new ImmString(";").clone();
//line 494
___nl__19 = new ImmString(___nl__19.toString() + ___nl__20.toString()).clone();
//line 494
___nl__20 = null;
//line 494
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__19);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 494
___nl__19 = null;
//line 495
___nl__19 = new ImmDouble(1).clone();
//line 495
___nl__13 = new ImmDouble((Double.Parse(___nl__13.getValue().ToString()))+(Double.Parse(___nl__19.getValue().ToString()))).clone();
//line 495
___nl__19 = null;
//line 496
___nl__15 = new ImmDouble((Double.Parse(___nl__15.getValue().ToString()))+(Double.Parse(___nl__16.getValue().ToString()))).clone();
//line 496
if (true) {goto label_21;}
//line 496
label_19:
//line 496
___nl__14 = null;
//line 496
___nl__15 = null;
//line 496
___nl__16 = null;
//line 496
___nl__17 = null;
//line 496
___nl__18 = null;
//line 497
___nl__14 = new ImmString("const").clone();
//line 497
___nl__14 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__14).clone();

//line 497
___nl__15 = ___nl__13.clone();
//line 497
((ImmHash)___nl__14).set("dynamic_nr", ___nl__15);
//line 497
___nl__16 = new ImmString("const").clone();
//line 497
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__16,___nl__14);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 497
___nl__16 = null;
//line 497
___nl__14 = null;
//line 497
___nl__15 = null;
//line 497
___nl__13 = null;
//line 498
if (true) {goto label_14;}
//line 498
label_14:
//line 498
___nl__12 = null;
//line 498
___nl__11 = null;
//line 498
___nl__10 = null;
//line 499
if (true) {goto label_7;}
//line 499
label_7:
//line 499
___nl__8 = null;
//line 499
___nl__9 = null;
//line 499
label_5:
//line 500
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 500
if (true) {goto label_6;}
//line 500
label_4:
//line 500
___nl__2 = null;
//line 500
___nl__3 = null;
//line 500
___nl__4 = null;
//line 500
___nl__5 = null;
//line 500
___nl__6 = null;
//line 500
___nl__7 = null;
//line 501
___nl__2 = new ImmString("}").clone();
//line 501
___nl__3 = string_NL.NL_lf().clone();

//line 501
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 501
___nl__3 = null;
//line 501
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 501
___nl__2 = null;
//line 501
___nl__1 = null;
//line 501
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_is_singleton_use_function_priv(Imm ___arg__0) {
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
//line 504
___nl__2 = ((ImmHash)___nl__0).getHashValue()["args_type"].clone();
//line 504
___nl__1 = array_NL.NL_len(___nl__2).clone();

//line 504
___nl__2 = null;
//line 504
___nl__2 = new ImmDouble(0).clone();
//line 504
___nl__1 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__1.getValue().ToString()))>(Double.Parse(___nl__2.getValue().ToString())) ).clone();
//line 504
___nl__2 = null;
//line 504
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1)).clone();
//line 504
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_2;}}
//line 504
___nl__2 = c_rt_lib_NL.NL_get_false().clone();
//line 504
___nl__0 = null;
//line 504
___nl__1 = null;
//line 504
if(true) return ___nl__2;
//line 504
___nl__2 = null;
//line 504
if (true) {goto label_2;}
//line 504
label_2:
//line 504
___nl__1 = null;
//line 505
___nl__1 = ((ImmHash)___nl__0).getHashValue()["annotation"].clone();
//line 505
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("math")).clone();
//line 506
___nl__2 = c_rt_lib_NL.NL_get_false().clone();
//line 508
___nl__4 = ((ImmHash)___nl__0).getHashValue()["commands"].clone();
//line 508
___nl__6 = new ImmDouble(0).clone();
//line 508
___nl__7 = new ImmDouble(1).clone();
//line 508
___nl__8 = c_rt_lib_NL.NL_array_len(___nl__4).clone();

//line 508
label_5:
//line 508
___nl__9 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__6.getValue().ToString()))>=(Double.Parse(___nl__8.getValue().ToString())) ).clone();
//line 508
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_3;}}
//line 508
___nl__5 = (___nl__4 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()].clone();
//line 509
___nl__10 = ((ImmHash)___nl__5).getHashValue()["cmd"].clone();
//line 510
___nl__11 = ___nl__10.clone();
//line 510
___nl__11 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("call")).clone();
//line 510
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 510
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_7;}}
//line 511
___nl__12 = ___nl__10.clone();
//line 511
___nl__12 = c_rt_lib_NL.NL_ov_as(___nl__12, new ImmString("call")).clone();
//line 512
___nl__13 = ((ImmHash)___nl__12).getHashValue()["fun_name"].clone();
//line 512
___nl__14 = new ImmString("sigleton_do_not_use_without_approval").clone();
//line 512
___nl__13 = c_rt_lib_NL.NL_native_to_nl(___nl__13.toString().Equals(___nl__14.toString())).clone();
//line 512
___nl__14 = null;
//line 512
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13)).clone();
//line 512
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13)).clone();
//line 512
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_9;}}
//line 512
___nl__10 = null;
//line 512
___nl__11 = null;
//line 512
___nl__12 = null;
//line 512
___nl__13 = null;
//line 512
if (true) {goto label_4;}
//line 512
if (true) {goto label_9;}
//line 512
label_9:
//line 512
___nl__13 = null;
//line 513
___nl__13 = ((ImmHash)___nl__12).getHashValue()["mod"].clone();
//line 513
___nl__14 = new ImmString("singleton").clone();
//line 513
___nl__13 = c_rt_lib_NL.NL_native_to_nl(___nl__13.toString().Equals(___nl__14.toString())).clone();
//line 513
___nl__14 = null;
//line 513
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13)).clone();
//line 513
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13)).clone();
//line 513
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_11;}}
//line 513
___nl__10 = null;
//line 513
___nl__11 = null;
//line 513
___nl__12 = null;
//line 513
___nl__13 = null;
//line 513
if (true) {goto label_4;}
//line 513
if (true) {goto label_11;}
//line 513
label_11:
//line 513
___nl__13 = null;
//line 514
___nl__13 = c_rt_lib_NL.NL_get_true().clone();
//line 514
___nl__2 = ___nl__13.clone();
//line 514
___nl__13 = null;
//line 515
___nl__13 = ((ImmHash)___nl__12).getHashValue()["dest"].clone();
//line 515
___nl__3 = ___nl__13.clone();
//line 515
___nl__13 = null;
//line 515
___nl__12 = null;
//line 516
if (true) {goto label_6;}
//line 516
label_7:
//line 516
___nl__11 = ___nl__10.clone();
//line 516
___nl__11 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("return")).clone();
//line 516
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 516
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_12;}}
//line 517
___nl__12 = ___nl__10.clone();
//line 517
___nl__12 = c_rt_lib_NL.NL_ov_as(___nl__12, new ImmString("return")).clone();
//line 518
___nl__13 = ___nl__12.clone();
//line 518
___nl__13 = c_rt_lib_NL.NL_ov_is(___nl__13, new ImmString("val")).clone();
//line 518
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13)).clone();
//line 518
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13)).clone();
//line 518
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_14;}}
//line 518
___nl__14 = c_rt_lib_NL.NL_get_false().clone();
//line 518
___nl__0 = null;
//line 518
___nl__1 = null;
//line 518
___nl__2 = null;
//line 518
___nl__3 = null;
//line 518
___nl__4 = null;
//line 518
___nl__5 = null;
//line 518
___nl__6 = null;
//line 518
___nl__7 = null;
//line 518
___nl__8 = null;
//line 518
___nl__9 = null;
//line 518
___nl__10 = null;
//line 518
___nl__11 = null;
//line 518
___nl__12 = null;
//line 518
___nl__13 = null;
//line 518
if(true) return ___nl__14;
//line 518
___nl__14 = null;
//line 518
if (true) {goto label_14;}
//line 518
label_14:
//line 518
___nl__13 = null;
//line 519
___nl__13 = ___nl__1.clone();
//line 519
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13)).clone();
//line 519
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_16;}}
//line 519
___nl__14 = c_rt_lib_NL.NL_get_true().clone();
//line 519
___nl__0 = null;
//line 519
___nl__1 = null;
//line 519
___nl__2 = null;
//line 519
___nl__3 = null;
//line 519
___nl__4 = null;
//line 519
___nl__5 = null;
//line 519
___nl__6 = null;
//line 519
___nl__7 = null;
//line 519
___nl__8 = null;
//line 519
___nl__9 = null;
//line 519
___nl__10 = null;
//line 519
___nl__11 = null;
//line 519
___nl__12 = null;
//line 519
___nl__13 = null;
//line 519
if(true) return ___nl__14;
//line 519
___nl__14 = null;
//line 519
if (true) {goto label_16;}
//line 519
label_16:
//line 519
___nl__13 = null;
//line 520
___nl__13 = ___nl__2.clone();
//line 520
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13)).clone();
//line 520
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13)).clone();
//line 520
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_18;}}
//line 520
___nl__14 = c_rt_lib_NL.NL_get_false().clone();
//line 520
___nl__0 = null;
//line 520
___nl__1 = null;
//line 520
___nl__2 = null;
//line 520
___nl__3 = null;
//line 520
___nl__4 = null;
//line 520
___nl__5 = null;
//line 520
___nl__6 = null;
//line 520
___nl__7 = null;
//line 520
___nl__8 = null;
//line 520
___nl__9 = null;
//line 520
___nl__10 = null;
//line 520
___nl__11 = null;
//line 520
___nl__12 = null;
//line 520
___nl__13 = null;
//line 520
if(true) return ___nl__14;
//line 520
___nl__14 = null;
//line 520
if (true) {goto label_18;}
//line 520
label_18:
//line 520
___nl__13 = null;
//line 521
___nl__13 = ___nl__12.clone();
//line 521
___nl__13 = c_rt_lib_NL.NL_ov_as(___nl__13, new ImmString("val")).clone();
//line 521
___nl__13 = c_rt_lib_NL.NL_native_to_nl(___nl__13.toString().Equals(___nl__3.toString())).clone();
//line 521
___nl__0 = null;
//line 521
___nl__1 = null;
//line 521
___nl__2 = null;
//line 521
___nl__3 = null;
//line 521
___nl__4 = null;
//line 521
___nl__5 = null;
//line 521
___nl__6 = null;
//line 521
___nl__7 = null;
//line 521
___nl__8 = null;
//line 521
___nl__9 = null;
//line 521
___nl__10 = null;
//line 521
___nl__11 = null;
//line 521
___nl__12 = null;
//line 521
if(true) return ___nl__13;
//line 521
___nl__13 = null;
//line 521
___nl__12 = null;
//line 522
if (true) {goto label_6;}
//line 522
label_12:
//line 522
___nl__11 = ___nl__10.clone();
//line 522
___nl__11 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("prt_lbl")).clone();
//line 522
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 522
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_19;}}
//line 523
if (true) {goto label_6;}
//line 523
label_19:
//line 523
___nl__11 = ___nl__10.clone();
//line 523
___nl__11 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("clear")).clone();
//line 523
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 523
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_20;}}
//line 524
if (true) {goto label_6;}
//line 524
label_20:
//line 525
___nl__12 = ___nl__2.clone();
//line 525
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 525
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_22;}}
//line 525
___nl__13 = c_rt_lib_NL.NL_get_false().clone();
//line 525
___nl__0 = null;
//line 525
___nl__1 = null;
//line 525
___nl__2 = null;
//line 525
___nl__3 = null;
//line 525
___nl__4 = null;
//line 525
___nl__5 = null;
//line 525
___nl__6 = null;
//line 525
___nl__7 = null;
//line 525
___nl__8 = null;
//line 525
___nl__9 = null;
//line 525
___nl__10 = null;
//line 525
___nl__11 = null;
//line 525
___nl__12 = null;
//line 525
if(true) return ___nl__13;
//line 525
___nl__13 = null;
//line 525
if (true) {goto label_22;}
//line 525
label_22:
//line 525
___nl__12 = null;
//line 526
if (true) {goto label_6;}
//line 526
label_6:
//line 526
___nl__11 = null;
//line 526
___nl__10 = null;
//line 526
label_4:
//line 527
___nl__6 = new ImmDouble((Double.Parse(___nl__6.getValue().ToString()))+(Double.Parse(___nl__7.getValue().ToString()))).clone();
//line 527
if (true) {goto label_5;}
//line 527
label_3:
//line 527
___nl__4 = null;
//line 527
___nl__5 = null;
//line 527
___nl__6 = null;
//line 527
___nl__7 = null;
//line 527
___nl__8 = null;
//line 527
___nl__9 = null;
//line 528
___nl__4 = c_rt_lib_NL.NL_get_false().clone();
//line 528
___nl__0 = null;
//line 528
___nl__1 = null;
//line 528
___nl__2 = null;
//line 528
___nl__3 = null;
//line 528
if(true) return ___nl__4;
//line 528
___nl__4 = null;
//line 528
___nl__1 = null;
//line 528
___nl__2 = null;
//line 528
___nl__3 = null;
//line 528
___nl__0 = null;
//line 528
if(true) return null;
}

private static Imm NL_move_args_to_register_priv(ImmRef ___arg__0) {
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
//line 532
___nl__2 = ((ImmHash)___nl__0).getHashValue()["fun_args"].clone();
//line 532
___nl__1 = array_NL.NL_len(___nl__2).clone();

//line 532
___nl__2 = null;
//line 532
___nl__2 = new ImmDouble(0).clone();
//line 532
___nl__3 = new ImmDouble(1).clone();
//line 532
label_3:
//line 532
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__2.getValue().ToString()))>=(Double.Parse(___nl__1.getValue().ToString())) ).clone();
//line 532
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_1;}}
//line 533
___nl__5 = ((ImmHash)___nl__0).getHashValue()["fun_args"].clone();
//line 533
___nl__5 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__2).getDoubleValue()].clone();
//line 533
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("val")).clone();
//line 533
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_5;}}
//line 536
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("ref")).clone();
//line 536
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_6;}}
//line 536
___nl__6 = new ImmString("NOMATCHALERT").clone();
//line 536
___nl__6 = new ImmArray(new Imm[] {___nl__6,___nl__5,}).clone();
//line 536
c_rt_lib_NL.NL_die();
//line 533
label_5:
//line 534
___nl__8 = new ImmString("arg_val").clone();
//line 534
___ref______nl__0 = new ImmRef(___nl__0);
___nl__10 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__2).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 534
___nl__9 = new ImmArray(new Imm[] {___nl__10,}).clone();
//line 534
___nl__10 = null;
//line 534
___nl__7 = generator_c_NL.NL_get_fun_lib_priv(___nl__8,___nl__9).clone();

//line 534
___nl__9 = null;
//line 534
___nl__8 = null;
//line 534
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 534
___nl__7 = null;
//line 535
___nl__7 = new ImmString(";").clone();
//line 535
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 535
___nl__7 = null;
//line 536
if (true) {goto label_4;}
//line 536
label_6:
//line 537
if (true) {goto label_4;}
//line 537
label_4:
//line 537
___nl__5 = null;
//line 537
___nl__6 = null;
//line 538
___nl__2 = new ImmDouble((Double.Parse(___nl__2.getValue().ToString()))+(Double.Parse(___nl__3.getValue().ToString()))).clone();
//line 538
if (true) {goto label_3;}
//line 538
label_1:
//line 538
___nl__1 = null;
//line 538
___nl__2 = null;
//line 538
___nl__3 = null;
//line 538
___nl__4 = null;
//line 538
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_move_register_to_ref_args_priv(ImmRef ___arg__0) {
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
//line 541
___nl__2 = ((ImmHash)___nl__0).getHashValue()["fun_args"].clone();
//line 541
___nl__1 = array_NL.NL_len(___nl__2).clone();

//line 541
___nl__2 = null;
//line 541
___nl__2 = new ImmDouble(0).clone();
//line 541
___nl__3 = new ImmDouble(1).clone();
//line 541
label_3:
//line 541
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__2.getValue().ToString()))>=(Double.Parse(___nl__1.getValue().ToString())) ).clone();
//line 541
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_1;}}
//line 542
___nl__5 = ((ImmHash)___nl__0).getHashValue()["fun_args"].clone();
//line 542
___nl__5 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__2).getDoubleValue()].clone();
//line 542
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("val")).clone();
//line 542
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_5;}}
//line 543
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("ref")).clone();
//line 543
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_6;}}
//line 543
___nl__6 = new ImmString("NOMATCHALERT").clone();
//line 543
___nl__6 = new ImmArray(new Imm[] {___nl__6,___nl__5,}).clone();
//line 543
c_rt_lib_NL.NL_die();
//line 542
label_5:
//line 543
if (true) {goto label_4;}
//line 543
label_6:
//line 544
if (true) {goto label_4;}
//line 544
label_4:
//line 544
___nl__5 = null;
//line 544
___nl__6 = null;
//line 545
___nl__2 = new ImmDouble((Double.Parse(___nl__2.getValue().ToString()))+(Double.Parse(___nl__3.getValue().ToString()))).clone();
//line 545
if (true) {goto label_3;}
//line 545
label_1:
//line 545
___nl__1 = null;
//line 545
___nl__2 = null;
//line 545
___nl__3 = null;
//line 545
___nl__4 = null;
//line 545
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_get_fun_lib_priv(Imm ___arg__0, Imm ___arg__1) {
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
//line 549
___nl__2 = generator_c_NL.NL_get_lib_fun_priv(___nl__0).clone();

//line 549
___nl__3 = new ImmString("(").clone();
//line 549
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 549
___nl__3 = null;
//line 550
___nl__3 = new ImmDouble(0).clone();
//line 551
___nl__5 = new ImmDouble(0).clone();
//line 551
___nl__6 = new ImmDouble(1).clone();
//line 551
___nl__7 = c_rt_lib_NL.NL_array_len(___nl__1).clone();

//line 551
label_3:
//line 551
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) ).clone();
//line 551
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_1;}}
//line 551
___nl__4 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()].clone();
//line 552
___nl__9 = new ImmDouble(0).clone();
//line 552
___nl__9 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__9.getValue().ToString())) ==((Double.Parse(___nl__3.getValue().ToString())))  ).clone();
//line 552
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 552
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 552
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_5;}}
//line 552
___nl__10 = new ImmString(", ").clone();
//line 552
___nl__2 = new ImmString(___nl__2.toString() + ___nl__10.toString()).clone();
//line 552
___nl__10 = null;
//line 552
if (true) {goto label_5;}
//line 552
label_5:
//line 552
___nl__9 = null;
//line 553
___nl__2 = new ImmString(___nl__2.toString() + ___nl__4.toString()).clone();
//line 554
___nl__9 = new ImmDouble(1).clone();
//line 554
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__9.getValue().ToString()))).clone();
//line 554
___nl__9 = null;
//line 555
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString()))).clone();
//line 555
if (true) {goto label_3;}
//line 555
label_1:
//line 555
___nl__4 = null;
//line 555
___nl__5 = null;
//line 555
___nl__6 = null;
//line 555
___nl__7 = null;
//line 555
___nl__8 = null;
//line 556
___nl__4 = new ImmString(")").clone();
//line 556
___nl__4 = new ImmString(___nl__2.toString() + ___nl__4.toString()).clone();
//line 556
___nl__0 = null;
//line 556
___nl__1 = null;
//line 556
___nl__2 = null;
//line 556
___nl__3 = null;
//line 556
if(true) return ___nl__4;
//line 556
___nl__4 = null;
//line 556
___nl__2 = null;
//line 556
___nl__3 = null;
//line 556
___nl__0 = null;
//line 556
___nl__1 = null;
//line 556
if(true) return null;
}

private static Imm NL_get_module_name_priv(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 560
___nl__2 = new ImmDouble(0).clone();
//line 560
___nl__3 = new ImmString("00").clone();
//line 560
___nl__1 = string_NL.NL_replace(___nl__0,___nl__2,___nl__3).clone();

//line 560
___nl__3 = null;
//line 560
___nl__2 = null;
//line 560
___nl__0 = null;
//line 560
if(true) return ___nl__1;
//line 560
___nl__1 = null;
//line 560
___nl__0 = null;
//line 560
if(true) return null;
}

private static Imm NL_get_fun_name_priv(Imm ___arg__0, Imm ___arg__1, Imm ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();
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
//line 564
___nl__3 = new ImmString("").clone();
//line 564
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__3.toString())).clone();
//line 564
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 564
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 564
___nl__4 = new ImmString("_priv").clone();
//line 564
___nl__4 = new ImmString(___nl__2.toString() + ___nl__4.toString()).clone();
//line 564
___nl__0 = ___nl__4.clone();
//line 564
___nl__4 = null;
//line 564
if (true) {goto label_2;}
//line 564
label_2:
//line 564
___nl__3 = null;
//line 565
___nl__3 = generator_c_NL.NL_get_module_name_priv(___nl__0).clone();

//line 565
___nl__4 = new ImmDouble(0).clone();
//line 565
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 565
___nl__4 = null;
//line 565
___nl__5 = new ImmDouble(0).clone();
//line 565
___nl__6 = new ImmString("00").clone();
//line 565
___nl__4 = string_NL.NL_replace(___nl__1,___nl__5,___nl__6).clone();

//line 565
___nl__6 = null;
//line 565
___nl__5 = null;
//line 565
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 565
___nl__4 = null;
//line 565
___nl__0 = null;
//line 565
___nl__1 = null;
//line 565
___nl__2 = null;
//line 565
if(true) return ___nl__3;
//line 565
___nl__3 = null;
//line 565
___nl__0 = null;
//line 565
___nl__1 = null;
//line 565
___nl__2 = null;
//line 565
if(true) return null;
}

private static Imm NL_get_lib_fun_priv(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 570
___nl__2 = new ImmString("c_rt_lib").clone();
//line 570
___nl__3 = new ImmString("").clone();
//line 570
___nl__1 = generator_c_NL.NL_get_fun_name_priv(___nl__2,___nl__0,___nl__3).clone();

//line 570
___nl__3 = null;
//line 570
___nl__2 = null;
//line 570
___nl__0 = null;
//line 570
if(true) return ___nl__1;
//line 570
___nl__1 = null;
//line 570
___nl__0 = null;
//line 570
if(true) return null;
}

private static Imm NL_generate_imm_priv(ImmRef ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.clone();
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
//line 574
___nl__2 = nl_NL.NL_is_hash(___nl__1).clone();

//line 574
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 574
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 575
___nl__4 = new ImmString("hash_mk_dec").clone();
//line 575
___nl__3 = generator_c_NL.NL_get_lib_fun_priv(___nl__4).clone();

//line 575
___nl__4 = null;
//line 575
___nl__4 = new ImmString("(").clone();
//line 575
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 575
___nl__4 = null;
//line 575
___nl__4 = hash_NL.NL_size(___nl__1).clone();

//line 575
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 575
___nl__4 = null;
//line 575
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 575
___nl__3 = null;
//line 576
___nl__5 = c_rt_lib_NL.NL_init_iter(___nl__1).clone();

//line 576
label_5:
//line 576
___nl__3 = c_rt_lib_NL.NL_is_end_hash(___nl__5).clone();

//line 576
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 576
___nl__3 = c_rt_lib_NL.NL_get_key_iter(___nl__5).clone();

//line 576
___nl__4 = c_rt_lib_NL.NL_hash_get_value(___nl__1,___nl__3).clone();

//line 577
___nl__6 = new ImmString(", ").clone();
//line 577
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__6);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 577
___nl__6 = null;
//line 578
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = generator_c_NL.NL_get_const_sim_priv(___ref______nl__0,___nl__3).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 578
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__6);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 578
___nl__6 = null;
//line 579
___nl__6 = new ImmString(", ").clone();
//line 579
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__6);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 579
___nl__6 = null;
//line 580
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_generate_imm_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 581
___nl__5 = c_rt_lib_NL.NL_next_iter(___nl__5).clone();

//line 581
if (true) {goto label_5;}
//line 581
label_3:
//line 581
___nl__3 = null;
//line 581
___nl__4 = null;
//line 581
___nl__5 = null;
//line 582
___nl__3 = new ImmString(")").clone();
//line 582
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 582
___nl__3 = null;
//line 583
if (true) {goto label_1;}
//line 583
label_2:
//line 583
___nl__2 = nl_NL.NL_is_array(___nl__1).clone();

//line 583
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 583
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_6;}}
//line 584
___nl__4 = new ImmString("array_mk_dec").clone();
//line 584
___nl__3 = generator_c_NL.NL_get_lib_fun_priv(___nl__4).clone();

//line 584
___nl__4 = null;
//line 584
___nl__4 = new ImmString("(").clone();
//line 584
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 584
___nl__4 = null;
//line 584
___nl__4 = array_NL.NL_len(___nl__1).clone();

//line 584
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 584
___nl__4 = null;
//line 584
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 584
___nl__3 = null;
//line 585
___nl__4 = new ImmDouble(0).clone();
//line 585
___nl__5 = new ImmDouble(1).clone();
//line 585
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__1).clone();

//line 585
label_9:
//line 585
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) ).clone();
//line 585
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_7;}}
//line 585
___nl__3 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()].clone();
//line 586
___nl__8 = new ImmString(", ").clone();
//line 586
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__8);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 586
___nl__8 = null;
//line 587
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_generate_imm_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 588
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 588
if (true) {goto label_9;}
//line 588
label_7:
//line 588
___nl__3 = null;
//line 588
___nl__4 = null;
//line 588
___nl__5 = null;
//line 588
___nl__6 = null;
//line 588
___nl__7 = null;
//line 589
___nl__3 = new ImmString(")").clone();
//line 589
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 589
___nl__3 = null;
//line 590
if (true) {goto label_1;}
//line 590
label_6:
//line 590
___nl__2 = nl_NL.NL_is_variant(___nl__1).clone();

//line 590
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 590
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_10;}}
//line 591
___nl__5 = ptd_NL.NL_sim().clone();

//line 591
___nl__6 = ov_NL.NL_get_element(___nl__1).clone();

//line 591
___nl__4 = ptd_NL.NL_ensure(___nl__5,___nl__6).clone();

//line 591
___nl__6 = null;
//line 591
___nl__5 = null;
//line 591
___ref______nl__0 = new ImmRef(___nl__0);
___nl__3 = generator_c_NL.NL_get_const_sim_priv(___ref______nl__0,___nl__4).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 591
___nl__4 = null;
//line 592
___nl__4 = ov_NL.NL_has_value(___nl__1).clone();

//line 592
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 592
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_12;}}
//line 593
___nl__6 = new ImmString("ov_mk_arg_dec").clone();
//line 593
___nl__5 = generator_c_NL.NL_get_lib_fun_priv(___nl__6).clone();

//line 593
___nl__6 = null;
//line 593
___nl__6 = new ImmString("(").clone();
//line 593
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 593
___nl__6 = null;
//line 593
___nl__5 = new ImmString(___nl__5.toString() + ___nl__3.toString()).clone();
//line 593
___nl__6 = new ImmString(", ").clone();
//line 593
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 593
___nl__6 = null;
//line 593
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 593
___nl__5 = null;
//line 594
___nl__5 = ov_NL.NL_get_value(___nl__1).clone();

//line 594
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_generate_imm_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 594
___nl__5 = null;
//line 595
___nl__5 = new ImmString(")").clone();
//line 595
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 595
___nl__5 = null;
//line 596
if (true) {goto label_11;}
//line 596
label_12:
//line 597
___nl__6 = new ImmString("ov_mk_none").clone();
//line 597
___nl__5 = generator_c_NL.NL_get_lib_fun_priv(___nl__6).clone();

//line 597
___nl__6 = null;
//line 597
___nl__6 = new ImmString("(").clone();
//line 597
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 597
___nl__6 = null;
//line 597
___nl__5 = new ImmString(___nl__5.toString() + ___nl__3.toString()).clone();
//line 597
___nl__6 = new ImmString(")").clone();
//line 597
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 597
___nl__6 = null;
//line 597
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 597
___nl__5 = null;
//line 598
if (true) {goto label_11;}
//line 598
label_11:
//line 598
___nl__4 = null;
//line 598
___nl__3 = null;
//line 599
if (true) {goto label_1;}
//line 599
label_10:
//line 599
___nl__2 = nl_NL.NL_is_sim(___nl__1).clone();

//line 599
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 599
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_13;}}
//line 600
___nl__5 = ptd_NL.NL_sim().clone();

//line 600
___nl__4 = ptd_NL.NL_ensure(___nl__5,___nl__1).clone();

//line 600
___nl__5 = null;
//line 600
___ref______nl__0 = new ImmRef(___nl__0);
___nl__3 = generator_c_NL.NL_get_const_sim_priv(___ref______nl__0,___nl__4).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 600
___nl__4 = null;
//line 600
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 600
___nl__3 = null;
//line 601
if (true) {goto label_1;}
//line 601
label_13:
//line 602
___nl__3 = new ImmArray(new Imm[0]).clone();
//line 602
c_rt_lib_NL.NL_die();
//line 602
___nl__3 = null;
//line 603
if (true) {goto label_1;}
//line 603
label_1:
//line 603
___nl__2 = null;
//line 603
___nl__1 = null;
//line 603
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_print_cmd_priv(ImmRef ___arg__0, Imm ___arg__1) {
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
//line 607
___nl__2 = new ImmString("#line ").clone();
//line 607
___nl__3 = ((ImmHash)___nl__1).getHashValue()["debug"].clone();
//line 607
___nl__3 = ((ImmHash)___nl__3).getHashValue()["nast_debug"].clone();
//line 607
___nl__3 = ((ImmHash)___nl__3).getHashValue()["begin"].clone();
//line 607
___nl__3 = ((ImmHash)___nl__3).getHashValue()["line"].clone();
//line 607
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 607
___nl__3 = null;
//line 607
___nl__3 = string_NL.NL_lf().clone();

//line 607
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 607
___nl__3 = null;
//line 607
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 607
___nl__2 = null;
//line 608
___nl__2 = ((ImmHash)___nl__1).getHashValue()["cmd"].clone();
//line 608
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("arr_decl")).clone();
//line 608
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 613
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("hash_decl")).clone();
//line 613
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 621
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("func")).clone();
//line 621
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_4;}}
//line 628
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("call")).clone();
//line 628
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_5;}}
//line 630
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("una_op")).clone();
//line 630
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_6;}}
//line 634
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("bin_op")).clone();
//line 634
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_7;}}
//line 641
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("ov_is")).clone();
//line 641
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_8;}}
//line 644
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("ov_as")).clone();
//line 644
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_9;}}
//line 647
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("return")).clone();
//line 647
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_10;}}
//line 655
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("die")).clone();
//line 655
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_11;}}
//line 657
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("move")).clone();
//line 657
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_12;}}
//line 661
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("load_const")).clone();
//line 661
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_13;}}
//line 666
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("get_frm_idx")).clone();
//line 666
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_14;}}
//line 669
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("set_at_idx")).clone();
//line 669
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_15;}}
//line 672
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("get_val")).clone();
//line 672
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_16;}}
//line 676
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("set_val")).clone();
//line 676
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_17;}}
//line 679
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("ov_mk")).clone();
//line 679
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_18;}}
//line 693
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("prt_lbl")).clone();
//line 693
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_19;}}
//line 696
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("if_goto")).clone();
//line 696
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_20;}}
//line 701
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("goto")).clone();
//line 701
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_21;}}
//line 703
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("clear")).clone();
//line 703
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_22;}}
//line 703
___nl__3 = new ImmString("NOMATCHALERT").clone();
//line 703
___nl__3 = new ImmArray(new Imm[] {___nl__3,___nl__2,}).clone();
//line 703
c_rt_lib_NL.NL_die();
//line 608
label_2:
//line 608
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("arr_decl")).clone();
//line 609
___nl__7 = ((ImmHash)___nl__4).getHashValue()["src"].clone();
//line 609
___nl__6 = array_NL.NL_len(___nl__7).clone();

//line 609
___nl__7 = null;
//line 609
___nl__5 = new ImmArray(new Imm[] {___nl__6,}).clone();
//line 609
___nl__6 = null;
//line 610
___nl__6 = ((ImmHash)___nl__4).getHashValue()["src"].clone();
//line 610
___nl__8 = new ImmDouble(0).clone();
//line 610
___nl__9 = new ImmDouble(1).clone();
//line 610
___nl__10 = c_rt_lib_NL.NL_array_len(___nl__6).clone();

//line 610
label_25:
//line 610
___nl__11 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString()))>=(Double.Parse(___nl__10.getValue().ToString())) ).clone();
//line 610
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_23;}}
//line 610
___nl__7 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()].clone();
//line 610
___ref______nl__0 = new ImmRef(___nl__0);
___nl__12 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__7).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 610
___ref______nl__5 = new ImmRef(___nl__5);
array_NL.NL_push(___ref______nl__5,___nl__12);
___nl__5 = ___ref______nl__5.getValue().clone();

//line 610
___nl__12 = null;
//line 610
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))+(Double.Parse(___nl__9.getValue().ToString()))).clone();
//line 610
if (true) {goto label_25;}
//line 610
label_23:
//line 610
___nl__6 = null;
//line 610
___nl__7 = null;
//line 610
___nl__8 = null;
//line 610
___nl__9 = null;
//line 610
___nl__10 = null;
//line 610
___nl__11 = null;
//line 611
___nl__7 = new ImmString("array_mk").clone();
//line 611
___nl__6 = generator_c_NL.NL_get_fun_lib_priv(___nl__7,___nl__5).clone();

//line 611
___nl__7 = null;
//line 612
___nl__8 = ((ImmHash)___nl__4).getHashValue()["dest"].clone();
//line 612
___ref______nl__0 = new ImmRef(___nl__0);
___nl__7 = generator_c_NL.NL_get_assign_priv(___ref______nl__0,___nl__8,___nl__6).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 612
___nl__8 = null;
//line 612
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 612
___nl__7 = null;
//line 612
___nl__5 = null;
//line 612
___nl__6 = null;
//line 612
___nl__4 = null;
//line 613
if (true) {goto label_1;}
//line 613
label_3:
//line 613
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("hash_decl")).clone();
//line 614
___nl__7 = ((ImmHash)___nl__4).getHashValue()["src"].clone();
//line 614
___nl__6 = array_NL.NL_len(___nl__7).clone();

//line 614
___nl__7 = null;
//line 614
___nl__5 = new ImmArray(new Imm[] {___nl__6,}).clone();
//line 614
___nl__6 = null;
//line 615
___nl__6 = ((ImmHash)___nl__4).getHashValue()["src"].clone();
//line 615
___nl__8 = new ImmDouble(0).clone();
//line 615
___nl__9 = new ImmDouble(1).clone();
//line 615
___nl__10 = c_rt_lib_NL.NL_array_len(___nl__6).clone();

//line 615
label_28:
//line 615
___nl__11 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString()))>=(Double.Parse(___nl__10.getValue().ToString())) ).clone();
//line 615
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_26;}}
//line 615
___nl__7 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()].clone();
//line 616
___nl__13 = ((ImmHash)___nl__7).getHashValue()["key"].clone();
//line 616
___ref______nl__0 = new ImmRef(___nl__0);
___nl__12 = generator_c_NL.NL_get_const_sim_priv(___ref______nl__0,___nl__13).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 616
___nl__13 = null;
//line 616
___ref______nl__5 = new ImmRef(___nl__5);
array_NL.NL_push(___ref______nl__5,___nl__12);
___nl__5 = ___ref______nl__5.getValue().clone();

//line 616
___nl__12 = null;
//line 617
___nl__13 = ((ImmHash)___nl__7).getHashValue()["val"].clone();
//line 617
___ref______nl__0 = new ImmRef(___nl__0);
___nl__12 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__13).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 617
___nl__13 = null;
//line 617
___ref______nl__5 = new ImmRef(___nl__5);
array_NL.NL_push(___ref______nl__5,___nl__12);
___nl__5 = ___ref______nl__5.getValue().clone();

//line 617
___nl__12 = null;
//line 618
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))+(Double.Parse(___nl__9.getValue().ToString()))).clone();
//line 618
if (true) {goto label_28;}
//line 618
label_26:
//line 618
___nl__6 = null;
//line 618
___nl__7 = null;
//line 618
___nl__8 = null;
//line 618
___nl__9 = null;
//line 618
___nl__10 = null;
//line 618
___nl__11 = null;
//line 619
___nl__7 = new ImmString("hash_mk").clone();
//line 619
___nl__6 = generator_c_NL.NL_get_fun_lib_priv(___nl__7,___nl__5).clone();

//line 619
___nl__7 = null;
//line 620
___nl__8 = ((ImmHash)___nl__4).getHashValue()["dest"].clone();
//line 620
___ref______nl__0 = new ImmRef(___nl__0);
___nl__7 = generator_c_NL.NL_get_assign_priv(___ref______nl__0,___nl__8,___nl__6).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 620
___nl__8 = null;
//line 620
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 620
___nl__7 = null;
//line 620
___nl__5 = null;
//line 620
___nl__6 = null;
//line 620
___nl__4 = null;
//line 621
if (true) {goto label_1;}
//line 621
label_4:
//line 621
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("func")).clone();
//line 622
___nl__6 = new ImmString("func_new").clone();
//line 622
___nl__9 = ((ImmHash)___nl__4).getHashValue()["module"].clone();
//line 622
___nl__10 = ((ImmHash)___nl__4).getHashValue()["name"].clone();
//line 622
___nl__11 = ((ImmHash)___nl__0).getHashValue()["mod_name"].clone();
//line 622
___nl__8 = generator_c_NL.NL_get_fun_name_priv(___nl__9,___nl__10,___nl__11).clone();

//line 622
___nl__11 = null;
//line 622
___nl__10 = null;
//line 622
___nl__9 = null;
//line 622
___nl__9 = new ImmString("0ptr").clone();
//line 622
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 622
___nl__9 = null;
//line 622
___nl__10 = ((ImmHash)___nl__4).getHashValue()["module"].clone();
//line 622
___ref______nl__0 = new ImmRef(___nl__0);
___nl__9 = generator_c_NL.NL_get_const_sim_priv(___ref______nl__0,___nl__10).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 622
___nl__10 = null;
//line 622
___nl__11 = ((ImmHash)___nl__4).getHashValue()["name"].clone();
//line 622
___ref______nl__0 = new ImmRef(___nl__0);
___nl__10 = generator_c_NL.NL_get_const_sim_priv(___ref______nl__0,___nl__11).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 622
___nl__11 = null;
//line 622
___nl__7 = new ImmArray(new Imm[] {___nl__8,___nl__9,___nl__10,}).clone();
//line 622
___nl__8 = null;
//line 622
___nl__9 = null;
//line 622
___nl__10 = null;
//line 622
___nl__5 = generator_c_NL.NL_get_fun_lib_priv(___nl__6,___nl__7).clone();

//line 622
___nl__7 = null;
//line 622
___nl__6 = null;
//line 627
___nl__7 = ((ImmHash)___nl__4).getHashValue()["dest"].clone();
//line 627
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = generator_c_NL.NL_get_assign_priv(___ref______nl__0,___nl__7,___nl__5).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 627
___nl__7 = null;
//line 627
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__6);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 627
___nl__6 = null;
//line 627
___nl__5 = null;
//line 627
___nl__4 = null;
//line 628
if (true) {goto label_1;}
//line 628
label_5:
//line 628
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("call")).clone();
//line 629
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_generate_call_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 629
___nl__4 = null;
//line 630
if (true) {goto label_1;}
//line 630
label_6:
//line 630
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("una_op")).clone();
//line 631
___nl__6 = generator_c_NL.NL_get_unary_ops_priv().clone();

//line 631
___nl__7 = ((ImmHash)___nl__4).getHashValue()["op"].clone();
//line 631
___nl__5 = hash_NL.NL_get_value(___nl__6,___nl__7).clone();

//line 631
___nl__7 = null;
//line 631
___nl__6 = null;
//line 632
___nl__9 = ((ImmHash)___nl__4).getHashValue()["src"].clone();
//line 632
___ref______nl__0 = new ImmRef(___nl__0);
___nl__8 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__9).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 632
___nl__9 = null;
//line 632
___nl__7 = new ImmArray(new Imm[] {___nl__8,}).clone();
//line 632
___nl__8 = null;
//line 632
___nl__6 = generator_c_NL.NL_get_fun_lib_priv(___nl__5,___nl__7).clone();

//line 632
___nl__7 = null;
//line 633
___nl__8 = ((ImmHash)___nl__4).getHashValue()["dest"].clone();
//line 633
___ref______nl__0 = new ImmRef(___nl__0);
___nl__7 = generator_c_NL.NL_get_assign_priv(___ref______nl__0,___nl__8,___nl__6).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 633
___nl__8 = null;
//line 633
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 633
___nl__7 = null;
//line 633
___nl__5 = null;
//line 633
___nl__6 = null;
//line 633
___nl__4 = null;
//line 634
if (true) {goto label_1;}
//line 634
label_7:
//line 634
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("bin_op")).clone();
//line 635
___nl__6 = generator_c_NL.NL_get_bin_ops_priv().clone();

//line 635
___nl__7 = ((ImmHash)___nl__4).getHashValue()["op"].clone();
//line 635
___nl__5 = hash_NL.NL_get_value(___nl__6,___nl__7).clone();

//line 635
___nl__7 = null;
//line 635
___nl__6 = null;
//line 636
___nl__6 = ((ImmHash)___nl__4).getHashValue()["dest"].clone();
//line 636
___nl__8 = ((ImmHash)___nl__4).getHashValue()["left"].clone();
//line 636
___nl__6 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__8.toString())).clone();
//line 636
___nl__8 = null;
//line 636
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 636
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_31;}}
//line 636
___nl__8 = generator_c_NL.NL_get_bin_ops_mod_priv().clone();

//line 636
___nl__9 = ((ImmHash)___nl__4).getHashValue()["op"].clone();
//line 636
___nl__6 = hash_NL.NL_has_key(___nl__8,___nl__9).clone();

//line 636
___nl__9 = null;
//line 636
___nl__8 = null;
//line 636
label_31:
//line 636
___nl__7 = null;
//line 636
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 636
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_30;}}
//line 637
___nl__8 = generator_c_NL.NL_get_bin_ops_mod_priv().clone();

//line 637
___nl__9 = ((ImmHash)___nl__4).getHashValue()["op"].clone();
//line 637
___nl__7 = hash_NL.NL_get_value(___nl__8,___nl__9).clone();

//line 637
___nl__9 = null;
//line 637
___nl__8 = null;
//line 637
___nl__5 = ___nl__7.clone();
//line 637
___nl__7 = null;
//line 638
if (true) {goto label_30;}
//line 638
label_30:
//line 638
___nl__6 = null;
//line 639
___nl__9 = ((ImmHash)___nl__4).getHashValue()["left"].clone();
//line 639
___ref______nl__0 = new ImmRef(___nl__0);
___nl__8 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__9).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 639
___nl__9 = null;
//line 639
___nl__10 = ((ImmHash)___nl__4).getHashValue()["right"].clone();
//line 639
___ref______nl__0 = new ImmRef(___nl__0);
___nl__9 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__10).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 639
___nl__10 = null;
//line 639
___nl__7 = new ImmArray(new Imm[] {___nl__8,___nl__9,}).clone();
//line 639
___nl__8 = null;
//line 639
___nl__9 = null;
//line 639
___nl__6 = generator_c_NL.NL_get_fun_lib_priv(___nl__5,___nl__7).clone();

//line 639
___nl__7 = null;
//line 640
___nl__8 = ((ImmHash)___nl__4).getHashValue()["dest"].clone();
//line 640
___ref______nl__0 = new ImmRef(___nl__0);
___nl__7 = generator_c_NL.NL_get_assign_priv(___ref______nl__0,___nl__8,___nl__6).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 640
___nl__8 = null;
//line 640
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 640
___nl__7 = null;
//line 640
___nl__5 = null;
//line 640
___nl__6 = null;
//line 640
___nl__4 = null;
//line 641
if (true) {goto label_1;}
//line 641
label_8:
//line 641
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("ov_is")).clone();
//line 642
___nl__6 = new ImmString("priv_is").clone();
//line 642
___nl__9 = ((ImmHash)___nl__4).getHashValue()["src"].clone();
//line 642
___ref______nl__0 = new ImmRef(___nl__0);
___nl__8 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__9).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 642
___nl__9 = null;
//line 642
___nl__10 = ((ImmHash)___nl__4).getHashValue()["type"].clone();
//line 642
___ref______nl__0 = new ImmRef(___nl__0);
___nl__9 = generator_c_NL.NL_get_const_sim_priv(___ref______nl__0,___nl__10).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 642
___nl__10 = null;
//line 642
___nl__7 = new ImmArray(new Imm[] {___nl__8,___nl__9,}).clone();
//line 642
___nl__8 = null;
//line 642
___nl__9 = null;
//line 642
___nl__5 = generator_c_NL.NL_get_fun_lib_priv(___nl__6,___nl__7).clone();

//line 642
___nl__7 = null;
//line 642
___nl__6 = null;
//line 643
___nl__7 = ((ImmHash)___nl__4).getHashValue()["dest"].clone();
//line 643
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = generator_c_NL.NL_get_assign_priv(___ref______nl__0,___nl__7,___nl__5).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 643
___nl__7 = null;
//line 643
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__6);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 643
___nl__6 = null;
//line 643
___nl__5 = null;
//line 643
___nl__4 = null;
//line 644
if (true) {goto label_1;}
//line 644
label_9:
//line 644
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("ov_as")).clone();
//line 645
___nl__6 = new ImmString("priv_as").clone();
//line 645
___nl__9 = ((ImmHash)___nl__4).getHashValue()["src"].clone();
//line 645
___ref______nl__0 = new ImmRef(___nl__0);
___nl__8 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__9).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 645
___nl__9 = null;
//line 645
___nl__10 = ((ImmHash)___nl__4).getHashValue()["type"].clone();
//line 645
___ref______nl__0 = new ImmRef(___nl__0);
___nl__9 = generator_c_NL.NL_get_const_sim_priv(___ref______nl__0,___nl__10).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 645
___nl__10 = null;
//line 645
___nl__7 = new ImmArray(new Imm[] {___nl__8,___nl__9,}).clone();
//line 645
___nl__8 = null;
//line 645
___nl__9 = null;
//line 645
___nl__5 = generator_c_NL.NL_get_fun_lib_priv(___nl__6,___nl__7).clone();

//line 645
___nl__7 = null;
//line 645
___nl__6 = null;
//line 646
___nl__7 = ((ImmHash)___nl__4).getHashValue()["dest"].clone();
//line 646
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = generator_c_NL.NL_get_assign_priv(___ref______nl__0,___nl__7,___nl__5).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 646
___nl__7 = null;
//line 646
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__6);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 646
___nl__6 = null;
//line 646
___nl__5 = null;
//line 646
___nl__4 = null;
//line 647
if (true) {goto label_1;}
//line 647
label_10:
//line 647
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("return")).clone();
//line 648
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_move_register_to_ref_args_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 649
___nl__5 = new ImmString("return ").clone();
//line 649
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 649
___nl__5 = null;
//line 650
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("val")).clone();
//line 650
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_33;}}
//line 652
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("emp")).clone();
//line 652
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_34;}}
//line 652
___nl__5 = new ImmString("NOMATCHALERT").clone();
//line 652
___nl__5 = new ImmArray(new Imm[] {___nl__5,___nl__4,}).clone();
//line 652
c_rt_lib_NL.NL_die();
//line 650
label_33:
//line 650
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("val")).clone();
//line 651
___ref______nl__0 = new ImmRef(___nl__0);
___nl__7 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__6).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 651
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 651
___nl__7 = null;
//line 651
___nl__6 = null;
//line 652
if (true) {goto label_32;}
//line 652
label_34:
//line 653
___nl__6 = new ImmString("NULL").clone();
//line 653
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__6);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 653
___nl__6 = null;
//line 654
if (true) {goto label_32;}
//line 654
label_32:
//line 654
___nl__5 = null;
//line 654
___nl__4 = null;
//line 655
if (true) {goto label_1;}
//line 655
label_11:
//line 655
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("die")).clone();
//line 656
___nl__5 = new ImmString("nl_die_arg(").clone();
//line 656
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__4).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 656
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 656
___nl__6 = null;
//line 656
___nl__6 = new ImmString(")").clone();
//line 656
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 656
___nl__6 = null;
//line 656
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 656
___nl__5 = null;
//line 656
___nl__4 = null;
//line 657
if (true) {goto label_1;}
//line 657
label_12:
//line 657
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("move")).clone();
//line 658
___nl__5 = ((ImmHash)___nl__4).getHashValue()["dest"].clone();
//line 658
___nl__6 = new ImmString("").clone();
//line 658
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__5.toString().Equals(___nl__6.toString())).clone();
//line 658
___nl__6 = null;
//line 658
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 658
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_36;}}
//line 658
___nl__1 = null;
//line 658
___nl__2 = null;
//line 658
___nl__3 = null;
//line 658
___nl__4 = null;
//line 658
___nl__5 = null;
//line 658
___arg__0.setValue(___nl__0);if(true) return null;
//line 658
if (true) {goto label_36;}
//line 658
label_36:
//line 658
___nl__5 = null;
//line 659
___nl__7 = ((ImmHash)___nl__4).getHashValue()["dest"].clone();
//line 659
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = generator_c_NL.NL_get_reg_ref_priv(___ref______nl__0,___nl__7).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 659
___nl__7 = null;
//line 659
___nl__8 = ((ImmHash)___nl__4).getHashValue()["src"].clone();
//line 659
___ref______nl__0 = new ImmRef(___nl__0);
___nl__7 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__8).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 659
___nl__8 = null;
//line 659
___nl__5 = new ImmArray(new Imm[] {___nl__6,___nl__7,}).clone();
//line 659
___nl__6 = null;
//line 659
___nl__7 = null;
//line 660
___nl__7 = new ImmString("copy").clone();
//line 660
___nl__6 = generator_c_NL.NL_get_fun_lib_priv(___nl__7,___nl__5).clone();

//line 660
___nl__7 = null;
//line 660
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__6);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 660
___nl__6 = null;
//line 660
___nl__5 = null;
//line 660
___nl__4 = null;
//line 661
if (true) {goto label_1;}
//line 661
label_13:
//line 661
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("load_const")).clone();
//line 662
___nl__5 = ((ImmHash)___nl__4).getHashValue()["dest"].clone();
//line 662
___nl__6 = new ImmString("").clone();
//line 662
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__5.toString().Equals(___nl__6.toString())).clone();
//line 662
___nl__6 = null;
//line 662
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 662
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_38;}}
//line 662
___nl__1 = null;
//line 662
___nl__2 = null;
//line 662
___nl__3 = null;
//line 662
___nl__4 = null;
//line 662
___nl__5 = null;
//line 662
___arg__0.setValue(___nl__0);if(true) return null;
//line 662
if (true) {goto label_38;}
//line 662
label_38:
//line 662
___nl__5 = null;
//line 663
___nl__6 = new ImmString("move").clone();
//line 663
___nl__5 = generator_c_NL.NL_get_lib_fun_priv(___nl__6).clone();

//line 663
___nl__6 = null;
//line 663
___nl__6 = new ImmString("(").clone();
//line 663
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 663
___nl__6 = null;
//line 663
___nl__7 = ((ImmHash)___nl__4).getHashValue()["dest"].clone();
//line 663
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = generator_c_NL.NL_get_reg_ref_priv(___ref______nl__0,___nl__7).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 663
___nl__7 = null;
//line 663
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 663
___nl__6 = null;
//line 663
___nl__6 = new ImmString(",").clone();
//line 663
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 663
___nl__6 = null;
//line 663
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 663
___nl__5 = null;
//line 664
___nl__5 = ((ImmHash)___nl__4).getHashValue()["val"].clone();
//line 664
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_generate_imm_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 664
___nl__5 = null;
//line 665
___nl__5 = new ImmString(")").clone();
//line 665
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 665
___nl__5 = null;
//line 665
___nl__4 = null;
//line 666
if (true) {goto label_1;}
//line 666
label_14:
//line 666
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("get_frm_idx")).clone();
//line 667
___nl__6 = new ImmString("array_get").clone();
//line 667
___nl__9 = ((ImmHash)___nl__4).getHashValue()["src"].clone();
//line 667
___ref______nl__0 = new ImmRef(___nl__0);
___nl__8 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__9).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 667
___nl__9 = null;
//line 667
___nl__10 = ((ImmHash)___nl__4).getHashValue()["idx"].clone();
//line 667
___ref______nl__0 = new ImmRef(___nl__0);
___nl__9 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__10).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 667
___nl__10 = null;
//line 667
___nl__7 = new ImmArray(new Imm[] {___nl__8,___nl__9,}).clone();
//line 667
___nl__8 = null;
//line 667
___nl__9 = null;
//line 667
___nl__5 = generator_c_NL.NL_get_fun_lib_priv(___nl__6,___nl__7).clone();

//line 667
___nl__7 = null;
//line 667
___nl__6 = null;
//line 668
___nl__7 = ((ImmHash)___nl__4).getHashValue()["dest"].clone();
//line 668
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = generator_c_NL.NL_get_assign_priv(___ref______nl__0,___nl__7,___nl__5).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 668
___nl__7 = null;
//line 668
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__6);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 668
___nl__6 = null;
//line 668
___nl__5 = null;
//line 668
___nl__4 = null;
//line 669
if (true) {goto label_1;}
//line 669
label_15:
//line 669
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("set_at_idx")).clone();
//line 670
___nl__6 = new ImmString("array_set").clone();
//line 670
___nl__9 = ((ImmHash)___nl__4).getHashValue()["src"].clone();
//line 670
___ref______nl__0 = new ImmRef(___nl__0);
___nl__8 = generator_c_NL.NL_get_reg_ref_priv(___ref______nl__0,___nl__9).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 670
___nl__9 = null;
//line 670
___nl__10 = ((ImmHash)___nl__4).getHashValue()["idx"].clone();
//line 670
___ref______nl__0 = new ImmRef(___nl__0);
___nl__9 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__10).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 670
___nl__10 = null;
//line 670
___nl__11 = ((ImmHash)___nl__4).getHashValue()["val"].clone();
//line 670
___ref______nl__0 = new ImmRef(___nl__0);
___nl__10 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__11).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 670
___nl__11 = null;
//line 670
___nl__7 = new ImmArray(new Imm[] {___nl__8,___nl__9,___nl__10,}).clone();
//line 670
___nl__8 = null;
//line 670
___nl__9 = null;
//line 670
___nl__10 = null;
//line 670
___nl__5 = generator_c_NL.NL_get_fun_lib_priv(___nl__6,___nl__7).clone();

//line 670
___nl__7 = null;
//line 670
___nl__6 = null;
//line 670
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 670
___nl__5 = null;
//line 670
___nl__4 = null;
//line 672
if (true) {goto label_1;}
//line 672
label_16:
//line 672
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("get_val")).clone();
//line 673
___nl__6 = new ImmString("hash_get_value_dec").clone();
//line 673
___nl__9 = ((ImmHash)___nl__4).getHashValue()["src"].clone();
//line 673
___ref______nl__0 = new ImmRef(___nl__0);
___nl__8 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__9).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 673
___nl__9 = null;
//line 673
___nl__10 = ((ImmHash)___nl__4).getHashValue()["key"].clone();
//line 673
___ref______nl__0 = new ImmRef(___nl__0);
___nl__9 = generator_c_NL.NL_get_const_sim_priv(___ref______nl__0,___nl__10).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 673
___nl__10 = null;
//line 673
___nl__7 = new ImmArray(new Imm[] {___nl__8,___nl__9,}).clone();
//line 673
___nl__8 = null;
//line 673
___nl__9 = null;
//line 673
___nl__5 = generator_c_NL.NL_get_fun_lib_priv(___nl__6,___nl__7).clone();

//line 673
___nl__7 = null;
//line 673
___nl__6 = null;
//line 675
___nl__7 = ((ImmHash)___nl__4).getHashValue()["dest"].clone();
//line 675
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = generator_c_NL.NL_get_assign_priv(___ref______nl__0,___nl__7,___nl__5).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 675
___nl__7 = null;
//line 675
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__6);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 675
___nl__6 = null;
//line 675
___nl__5 = null;
//line 675
___nl__4 = null;
//line 676
if (true) {goto label_1;}
//line 676
label_17:
//line 676
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("set_val")).clone();
//line 677
___nl__6 = new ImmString("hash_set_value_dec").clone();
//line 677
___nl__9 = ((ImmHash)___nl__4).getHashValue()["src"].clone();
//line 677
___ref______nl__0 = new ImmRef(___nl__0);
___nl__8 = generator_c_NL.NL_get_reg_ref_priv(___ref______nl__0,___nl__9).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 677
___nl__9 = null;
//line 677
___nl__10 = ((ImmHash)___nl__4).getHashValue()["key"].clone();
//line 677
___ref______nl__0 = new ImmRef(___nl__0);
___nl__9 = generator_c_NL.NL_get_const_sim_priv(___ref______nl__0,___nl__10).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 677
___nl__10 = null;
//line 677
___nl__11 = ((ImmHash)___nl__4).getHashValue()["val"].clone();
//line 677
___ref______nl__0 = new ImmRef(___nl__0);
___nl__10 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__11).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 677
___nl__11 = null;
//line 677
___nl__7 = new ImmArray(new Imm[] {___nl__8,___nl__9,___nl__10,}).clone();
//line 677
___nl__8 = null;
//line 677
___nl__9 = null;
//line 677
___nl__10 = null;
//line 677
___nl__5 = generator_c_NL.NL_get_fun_lib_priv(___nl__6,___nl__7).clone();

//line 677
___nl__7 = null;
//line 677
___nl__6 = null;
//line 677
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 677
___nl__5 = null;
//line 677
___nl__4 = null;
//line 679
if (true) {goto label_1;}
//line 679
label_18:
//line 679
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("ov_mk")).clone();
//line 681
___nl__6 = ((ImmHash)___nl__4).getHashValue()["src"].clone();
//line 681
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("emp")).clone();
//line 681
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 681
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_41;}}
//line 681
___nl__6 = ((ImmHash)___nl__4).getHashValue()["name"].clone();
//line 681
___nl__8 = new ImmString("TRUE").clone();
//line 681
___nl__6 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__8.toString())).clone();
//line 681
___nl__8 = null;
//line 681
label_41:
//line 681
___nl__7 = null;
//line 681
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 681
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_40;}}
//line 682
___nl__8 = new ImmString("get_true").clone();
//line 682
___nl__9 = new ImmArray(new Imm[0]).clone();
//line 682
___nl__7 = generator_c_NL.NL_get_fun_lib_priv(___nl__8,___nl__9).clone();

//line 682
___nl__9 = null;
//line 682
___nl__8 = null;
//line 682
___nl__5 = ___nl__7.clone();
//line 682
___nl__7 = null;
//line 683
if (true) {goto label_39;}
//line 683
label_40:
//line 683
___nl__6 = ((ImmHash)___nl__4).getHashValue()["src"].clone();
//line 683
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("emp")).clone();
//line 683
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 683
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_43;}}
//line 683
___nl__6 = ((ImmHash)___nl__4).getHashValue()["name"].clone();
//line 683
___nl__8 = new ImmString("FALSE").clone();
//line 683
___nl__6 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__8.toString())).clone();
//line 683
___nl__8 = null;
//line 683
label_43:
//line 683
___nl__7 = null;
//line 683
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 683
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_42;}}
//line 684
___nl__8 = new ImmString("get_false").clone();
//line 684
___nl__9 = new ImmArray(new Imm[0]).clone();
//line 684
___nl__7 = generator_c_NL.NL_get_fun_lib_priv(___nl__8,___nl__9).clone();

//line 684
___nl__9 = null;
//line 684
___nl__8 = null;
//line 684
___nl__5 = ___nl__7.clone();
//line 684
___nl__7 = null;
//line 685
if (true) {goto label_39;}
//line 685
label_42:
//line 686
___nl__7 = ((ImmHash)___nl__4).getHashValue()["src"].clone();
//line 686
___nl__8 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("arg")).clone();
//line 686
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_45;}}
//line 688
___nl__8 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("emp")).clone();
//line 688
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_46;}}
//line 688
___nl__8 = new ImmString("NOMATCHALERT").clone();
//line 688
___nl__8 = new ImmArray(new Imm[] {___nl__8,___nl__7,}).clone();
//line 688
c_rt_lib_NL.NL_die();
//line 686
label_45:
//line 686
___nl__9 = c_rt_lib_NL.NL_ov_as(___nl__7, new ImmString("arg")).clone();
//line 687
___nl__11 = new ImmString("ov_mk_arg").clone();
//line 687
___nl__14 = ((ImmHash)___nl__4).getHashValue()["name"].clone();
//line 687
___ref______nl__0 = new ImmRef(___nl__0);
___nl__13 = generator_c_NL.NL_get_const_sim_priv(___ref______nl__0,___nl__14).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 687
___nl__14 = null;
//line 687
___ref______nl__0 = new ImmRef(___nl__0);
___nl__14 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__9).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 687
___nl__12 = new ImmArray(new Imm[] {___nl__13,___nl__14,}).clone();
//line 687
___nl__13 = null;
//line 687
___nl__14 = null;
//line 687
___nl__10 = generator_c_NL.NL_get_fun_lib_priv(___nl__11,___nl__12).clone();

//line 687
___nl__12 = null;
//line 687
___nl__11 = null;
//line 687
___nl__5 = ___nl__10.clone();
//line 687
___nl__10 = null;
//line 687
___nl__9 = null;
//line 688
if (true) {goto label_44;}
//line 688
label_46:
//line 689
___nl__10 = new ImmString("ov_mk_none").clone();
//line 689
___nl__13 = ((ImmHash)___nl__4).getHashValue()["name"].clone();
//line 689
___ref______nl__0 = new ImmRef(___nl__0);
___nl__12 = generator_c_NL.NL_get_const_sim_priv(___ref______nl__0,___nl__13).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 689
___nl__13 = null;
//line 689
___nl__11 = new ImmArray(new Imm[] {___nl__12,}).clone();
//line 689
___nl__12 = null;
//line 689
___nl__9 = generator_c_NL.NL_get_fun_lib_priv(___nl__10,___nl__11).clone();

//line 689
___nl__11 = null;
//line 689
___nl__10 = null;
//line 689
___nl__5 = ___nl__9.clone();
//line 689
___nl__9 = null;
//line 690
if (true) {goto label_44;}
//line 690
label_44:
//line 690
___nl__7 = null;
//line 690
___nl__8 = null;
//line 691
if (true) {goto label_39;}
//line 691
label_39:
//line 691
___nl__6 = null;
//line 692
___nl__7 = ((ImmHash)___nl__4).getHashValue()["dest"].clone();
//line 692
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = generator_c_NL.NL_get_assign_priv(___ref______nl__0,___nl__7,___nl__5).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 692
___nl__7 = null;
//line 692
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__6);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 692
___nl__6 = null;
//line 692
___nl__5 = null;
//line 692
___nl__4 = null;
//line 693
if (true) {goto label_1;}
//line 693
label_19:
//line 693
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("prt_lbl")).clone();
//line 694
___nl__5 = new ImmString(":").clone();
//line 694
___nl__5 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 694
___nl__6 = string_NL.NL_lf().clone();

//line 694
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 694
___nl__6 = null;
//line 694
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 694
___nl__5 = null;
//line 695
___nl__1 = null;
//line 695
___nl__2 = null;
//line 695
___nl__3 = null;
//line 695
___nl__4 = null;
//line 695
___arg__0.setValue(___nl__0);if(true) return null;
//line 695
___nl__4 = null;
//line 696
if (true) {goto label_1;}
//line 696
label_20:
//line 696
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("if_goto")).clone();
//line 697
___nl__5 = new ImmString("if(").clone();
//line 697
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 697
___nl__5 = null;
//line 698
___nl__6 = new ImmString("check_true_native").clone();
//line 698
___nl__9 = ((ImmHash)___nl__4).getHashValue()["src"].clone();
//line 698
___ref______nl__0 = new ImmRef(___nl__0);
___nl__8 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__9).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 698
___nl__9 = null;
//line 698
___nl__7 = new ImmArray(new Imm[] {___nl__8,}).clone();
//line 698
___nl__8 = null;
//line 698
___nl__5 = generator_c_NL.NL_get_fun_lib_priv(___nl__6,___nl__7).clone();

//line 698
___nl__7 = null;
//line 698
___nl__6 = null;
//line 698
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 698
___nl__5 = null;
//line 699
___nl__5 = new ImmString("){ goto ").clone();
//line 699
___nl__6 = ((ImmHash)___nl__4).getHashValue()["dest"].clone();
//line 699
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 699
___nl__6 = null;
//line 699
___nl__6 = new ImmString(";}").clone();
//line 699
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 699
___nl__6 = null;
//line 699
___nl__6 = string_NL.NL_lf().clone();

//line 699
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 699
___nl__6 = null;
//line 699
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 699
___nl__5 = null;
//line 700
___nl__1 = null;
//line 700
___nl__2 = null;
//line 700
___nl__3 = null;
//line 700
___nl__4 = null;
//line 700
___arg__0.setValue(___nl__0);if(true) return null;
//line 700
___nl__4 = null;
//line 701
if (true) {goto label_1;}
//line 701
label_21:
//line 701
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("goto")).clone();
//line 702
___nl__5 = new ImmString("goto ").clone();
//line 702
___nl__5 = new ImmString(___nl__5.toString() + ___nl__4.toString()).clone();
//line 702
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 702
___nl__5 = null;
//line 702
___nl__4 = null;
//line 703
if (true) {goto label_1;}
//line 703
label_22:
//line 703
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("clear")).clone();
//line 704
___nl__6 = new ImmString("clear").clone();
//line 704
___ref______nl__0 = new ImmRef(___nl__0);
___nl__8 = generator_c_NL.NL_get_reg_ref_priv(___ref______nl__0,___nl__4).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 704
___nl__7 = new ImmArray(new Imm[] {___nl__8,}).clone();
//line 704
___nl__8 = null;
//line 704
___nl__5 = generator_c_NL.NL_get_fun_lib_priv(___nl__6,___nl__7).clone();

//line 704
___nl__7 = null;
//line 704
___nl__6 = null;
//line 704
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 704
___nl__5 = null;
//line 704
___nl__4 = null;
//line 705
if (true) {goto label_1;}
//line 705
label_1:
//line 705
___nl__2 = null;
//line 705
___nl__3 = null;
//line 706
___nl__2 = new ImmString(";").clone();
//line 706
___nl__3 = string_NL.NL_lf().clone();

//line 706
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 706
___nl__3 = null;
//line 706
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 706
___nl__2 = null;
//line 706
___nl__1 = null;
//line 706
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_get_assign_priv(ImmRef ___arg__0, Imm ___arg__1, Imm ___arg__2) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();
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
//line 710
___nl__3 = new ImmString("").clone();
//line 710
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__1.toString().Equals(___nl__3.toString())).clone();
//line 710
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 710
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 711
___nl__5 = new ImmString("delete").clone();
//line 711
___nl__6 = new ImmArray(new Imm[] {___nl__2,}).clone();
//line 711
___nl__4 = generator_c_NL.NL_get_fun_lib_priv(___nl__5,___nl__6).clone();

//line 711
___nl__6 = null;
//line 711
___nl__5 = null;
//line 711
___nl__1 = null;
//line 711
___nl__2 = null;
//line 711
___nl__3 = null;
//line 711
___arg__0.setValue(___nl__0);if(true) return ___nl__4;
//line 711
___nl__4 = null;
//line 712
if (true) {goto label_1;}
//line 712
label_2:
//line 713
___nl__5 = new ImmString("move").clone();
//line 713
___ref______nl__0 = new ImmRef(___nl__0);
___nl__7 = generator_c_NL.NL_get_reg_ref_priv(___ref______nl__0,___nl__1).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 713
___nl__6 = new ImmArray(new Imm[] {___nl__7,___nl__2,}).clone();
//line 713
___nl__7 = null;
//line 713
___nl__4 = generator_c_NL.NL_get_fun_lib_priv(___nl__5,___nl__6).clone();

//line 713
___nl__6 = null;
//line 713
___nl__5 = null;
//line 713
___nl__1 = null;
//line 713
___nl__2 = null;
//line 713
___nl__3 = null;
//line 713
___arg__0.setValue(___nl__0);if(true) return ___nl__4;
//line 713
___nl__4 = null;
//line 714
if (true) {goto label_1;}
//line 714
label_1:
//line 714
___nl__3 = null;
//line 714
___nl__1 = null;
//line 714
___nl__2 = null;
//line 714
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_generate_call_priv(ImmRef ___arg__0, Imm ___arg__1) {
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
//line 718
___nl__3 = ((ImmHash)___nl__1).getHashValue()["mod"].clone();
//line 718
___nl__4 = ((ImmHash)___nl__1).getHashValue()["fun_name"].clone();
//line 718
___nl__5 = ((ImmHash)___nl__0).getHashValue()["mod_name"].clone();
//line 718
___nl__2 = generator_c_NL.NL_get_fun_name_priv(___nl__3,___nl__4,___nl__5).clone();

//line 718
___nl__5 = null;
//line 718
___nl__4 = null;
//line 718
___nl__3 = null;
//line 718
___nl__3 = new ImmString("(").clone();
//line 718
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 718
___nl__3 = null;
//line 719
___nl__4 = ((ImmHash)___nl__1).getHashValue()["args"].clone();
//line 719
___nl__3 = array_NL.NL_len(___nl__4).clone();

//line 719
___nl__4 = null;
//line 719
___nl__4 = new ImmDouble(0).clone();
//line 719
___nl__5 = new ImmDouble(1).clone();
//line 719
label_3:
//line 719
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__3.getValue().ToString())) ).clone();
//line 719
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_1;}}
//line 720
___nl__7 = new ImmDouble(0).clone();
//line 720
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString())) ==((Double.Parse(___nl__4.getValue().ToString())))  ).clone();
//line 720
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 720
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 720
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_5;}}
//line 720
___nl__8 = new ImmString(", ").clone();
//line 720
___nl__2 = new ImmString(___nl__2.toString() + ___nl__8.toString()).clone();
//line 720
___nl__8 = null;
//line 720
if (true) {goto label_5;}
//line 720
label_5:
//line 720
___nl__7 = null;
//line 721
___nl__7 = ((ImmHash)___nl__1).getHashValue()["args"].clone();
//line 721
___nl__7 = (___nl__7 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()].clone();
//line 721
___nl__8 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("val")).clone();
//line 721
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_7;}}
//line 723
___nl__8 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("ref")).clone();
//line 723
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_8;}}
//line 723
___nl__8 = new ImmString("NOMATCHALERT").clone();
//line 723
___nl__8 = new ImmArray(new Imm[] {___nl__8,___nl__7,}).clone();
//line 723
c_rt_lib_NL.NL_die();
//line 721
label_7:
//line 721
___nl__9 = c_rt_lib_NL.NL_ov_as(___nl__7, new ImmString("val")).clone();
//line 722
___ref______nl__0 = new ImmRef(___nl__0);
___nl__10 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__9).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 722
___nl__2 = new ImmString(___nl__2.toString() + ___nl__10.toString()).clone();
//line 722
___nl__10 = null;
//line 722
___nl__9 = null;
//line 723
if (true) {goto label_6;}
//line 723
label_8:
//line 723
___nl__9 = c_rt_lib_NL.NL_ov_as(___nl__7, new ImmString("ref")).clone();
//line 724
___ref______nl__0 = new ImmRef(___nl__0);
___nl__10 = generator_c_NL.NL_get_reg_ref_priv(___ref______nl__0,___nl__9).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 724
___nl__2 = new ImmString(___nl__2.toString() + ___nl__10.toString()).clone();
//line 724
___nl__10 = null;
//line 724
___nl__9 = null;
//line 725
if (true) {goto label_6;}
//line 725
label_6:
//line 725
___nl__7 = null;
//line 725
___nl__8 = null;
//line 726
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 726
if (true) {goto label_3;}
//line 726
label_1:
//line 726
___nl__3 = null;
//line 726
___nl__4 = null;
//line 726
___nl__5 = null;
//line 726
___nl__6 = null;
//line 727
___nl__3 = new ImmString(")").clone();
//line 727
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 727
___nl__3 = null;
//line 728
___nl__4 = ((ImmHash)___nl__1).getHashValue()["dest"].clone();
//line 728
___ref______nl__0 = new ImmRef(___nl__0);
___nl__3 = generator_c_NL.NL_get_assign_priv(___ref______nl__0,___nl__4,___nl__2).clone();
___nl__0 = ___ref______nl__0.getValue().clone();

//line 728
___nl__4 = null;
//line 728
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 728
___nl__3 = null;
//line 728
___nl__2 = null;
//line 728
___nl__1 = null;
//line 728
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_create_sim_priv(Imm ___arg__0) {
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
//line 732
___nl__1 = string_utils_NL.NL_is_integer(___nl__0).clone();

//line 732
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1)).clone();
//line 732
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_2;}}
//line 733
___nl__3 = new ImmString("int_new").clone();
//line 733
___nl__2 = generator_c_NL.NL_get_lib_fun_priv(___nl__3).clone();

//line 733
___nl__3 = null;
//line 733
___nl__3 = new ImmString("(").clone();
//line 733
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 733
___nl__3 = null;
//line 733
___nl__2 = new ImmString(___nl__2.toString() + ___nl__0.toString()).clone();
//line 733
___nl__3 = new ImmString(")").clone();
//line 733
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 733
___nl__3 = null;
//line 733
___nl__0 = null;
//line 733
___nl__1 = null;
//line 733
if(true) return ___nl__2;
//line 733
___nl__2 = null;
//line 734
if (true) {goto label_1;}
//line 734
label_2:
//line 734
___nl__1 = string_utils_NL.NL_is_float(___nl__0).clone();

//line 734
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1)).clone();
//line 734
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_3;}}
//line 735
___nl__3 = new ImmString("float_new").clone();
//line 735
___nl__2 = generator_c_NL.NL_get_lib_fun_priv(___nl__3).clone();

//line 735
___nl__3 = null;
//line 735
___nl__3 = new ImmString("(").clone();
//line 735
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 735
___nl__3 = null;
//line 735
___nl__2 = new ImmString(___nl__2.toString() + ___nl__0.toString()).clone();
//line 735
___nl__3 = new ImmString(")").clone();
//line 735
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 735
___nl__3 = null;
//line 735
___nl__0 = null;
//line 735
___nl__1 = null;
//line 735
if(true) return ___nl__2;
//line 735
___nl__2 = null;
//line 736
if (true) {goto label_1;}
//line 736
label_3:
//line 737
___nl__2 = new ImmString("").clone();
//line 737
___nl__2 = new ImmString(___nl__0.toString() + ___nl__2.toString()).clone();
//line 738
___nl__4 = new ImmString("\\").clone();
//line 738
___nl__5 = new ImmString("\\\\").clone();
//line 738
___nl__3 = string_NL.NL_replace(___nl__2,___nl__4,___nl__5).clone();

//line 738
___nl__5 = null;
//line 738
___nl__4 = null;
//line 738
___nl__2 = ___nl__3.clone();
//line 738
___nl__3 = null;
//line 739
___nl__4 = string_NL.NL_lf().clone();

//line 739
___nl__5 = new ImmString("\\n").clone();
//line 739
___nl__3 = string_NL.NL_replace(___nl__2,___nl__4,___nl__5).clone();

//line 739
___nl__5 = null;
//line 739
___nl__4 = null;
//line 739
___nl__2 = ___nl__3.clone();
//line 739
___nl__3 = null;
//line 740
___nl__4 = string_NL.NL_r().clone();

//line 740
___nl__5 = new ImmString("\\r").clone();
//line 740
___nl__3 = string_NL.NL_replace(___nl__2,___nl__4,___nl__5).clone();

//line 740
___nl__5 = null;
//line 740
___nl__4 = null;
//line 740
___nl__2 = ___nl__3.clone();
//line 740
___nl__3 = null;
//line 741
___nl__4 = string_NL.NL_tab().clone();

//line 741
___nl__5 = new ImmString("\\t").clone();
//line 741
___nl__3 = string_NL.NL_replace(___nl__2,___nl__4,___nl__5).clone();

//line 741
___nl__5 = null;
//line 741
___nl__4 = null;
//line 741
___nl__2 = ___nl__3.clone();
//line 741
___nl__3 = null;
//line 742
___nl__4 = new ImmString("\"").clone();
//line 742
___nl__5 = new ImmString("\\\"").clone();
//line 742
___nl__3 = string_NL.NL_replace(___nl__2,___nl__4,___nl__5).clone();

//line 742
___nl__5 = null;
//line 742
___nl__4 = null;
//line 742
___nl__2 = ___nl__3.clone();
//line 742
___nl__3 = null;
//line 743
___nl__4 = new ImmString("'").clone();
//line 743
___nl__5 = new ImmString("\\'").clone();
//line 743
___nl__3 = string_NL.NL_replace(___nl__2,___nl__4,___nl__5).clone();

//line 743
___nl__5 = null;
//line 743
___nl__4 = null;
//line 743
___nl__2 = ___nl__3.clone();
//line 743
___nl__3 = null;
//line 744
___nl__4 = new ImmString("string_new").clone();
//line 744
___nl__3 = generator_c_NL.NL_get_lib_fun_priv(___nl__4).clone();

//line 744
___nl__4 = null;
//line 744
___nl__4 = new ImmString("(\"").clone();
//line 744
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 744
___nl__4 = null;
//line 744
___nl__3 = new ImmString(___nl__3.toString() + ___nl__2.toString()).clone();
//line 744
___nl__4 = new ImmString("\")").clone();
//line 744
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 744
___nl__4 = null;
//line 744
___nl__0 = null;
//line 744
___nl__1 = null;
//line 744
___nl__2 = null;
//line 744
if(true) return ___nl__3;
//line 744
___nl__3 = null;
//line 744
___nl__2 = null;
//line 745
if (true) {goto label_1;}
//line 745
label_1:
//line 745
___nl__1 = null;
//line 745
___nl__0 = null;
//line 745
if(true) return null;
}

private static Imm NL_create_sim_to_memory_priv(Imm ___arg__0, Imm ___arg__1) {
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
//line 749
___nl__2 = string_utils_NL.NL_is_integer(___nl__0).clone();

//line 749
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 749
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 750
___nl__4 = new ImmString("int_new_to_memory").clone();
//line 750
___nl__3 = generator_c_NL.NL_get_lib_fun_priv(___nl__4).clone();

//line 750
___nl__4 = null;
//line 750
___nl__4 = new ImmString("(").clone();
//line 750
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 750
___nl__4 = null;
//line 750
___nl__3 = new ImmString(___nl__3.toString() + ___nl__0.toString()).clone();
//line 750
___nl__4 = new ImmString(",").clone();
//line 750
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 750
___nl__4 = null;
//line 750
___nl__3 = new ImmString(___nl__3.toString() + ___nl__1.toString()).clone();
//line 750
___nl__4 = new ImmString(")").clone();
//line 750
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 750
___nl__4 = null;
//line 750
___nl__0 = null;
//line 750
___nl__1 = null;
//line 750
___nl__2 = null;
//line 750
if(true) return ___nl__3;
//line 750
___nl__3 = null;
//line 751
if (true) {goto label_1;}
//line 751
label_2:
//line 751
___nl__2 = string_utils_NL.NL_is_float(___nl__0).clone();

//line 751
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 751
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_3;}}
//line 752
___nl__4 = new ImmString("float_new_to_memory").clone();
//line 752
___nl__3 = generator_c_NL.NL_get_lib_fun_priv(___nl__4).clone();

//line 752
___nl__4 = null;
//line 752
___nl__4 = new ImmString("(").clone();
//line 752
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 752
___nl__4 = null;
//line 752
___nl__3 = new ImmString(___nl__3.toString() + ___nl__0.toString()).clone();
//line 752
___nl__4 = new ImmString(",").clone();
//line 752
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 752
___nl__4 = null;
//line 752
___nl__3 = new ImmString(___nl__3.toString() + ___nl__1.toString()).clone();
//line 752
___nl__4 = new ImmString(")").clone();
//line 752
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 752
___nl__4 = null;
//line 752
___nl__0 = null;
//line 752
___nl__1 = null;
//line 752
___nl__2 = null;
//line 752
if(true) return ___nl__3;
//line 752
___nl__3 = null;
//line 753
if (true) {goto label_1;}
//line 753
label_3:
//line 754
___nl__3 = new ImmString("").clone();
//line 754
___nl__3 = new ImmString(___nl__0.toString() + ___nl__3.toString()).clone();
//line 755
___nl__5 = new ImmString("\\").clone();
//line 755
___nl__6 = new ImmString("\\\\").clone();
//line 755
___nl__4 = string_NL.NL_replace(___nl__3,___nl__5,___nl__6).clone();

//line 755
___nl__6 = null;
//line 755
___nl__5 = null;
//line 755
___nl__3 = ___nl__4.clone();
//line 755
___nl__4 = null;
//line 756
___nl__5 = string_NL.NL_lf().clone();

//line 756
___nl__6 = new ImmString("\\n").clone();
//line 756
___nl__4 = string_NL.NL_replace(___nl__3,___nl__5,___nl__6).clone();

//line 756
___nl__6 = null;
//line 756
___nl__5 = null;
//line 756
___nl__3 = ___nl__4.clone();
//line 756
___nl__4 = null;
//line 757
___nl__5 = string_NL.NL_r().clone();

//line 757
___nl__6 = new ImmString("\\r").clone();
//line 757
___nl__4 = string_NL.NL_replace(___nl__3,___nl__5,___nl__6).clone();

//line 757
___nl__6 = null;
//line 757
___nl__5 = null;
//line 757
___nl__3 = ___nl__4.clone();
//line 757
___nl__4 = null;
//line 758
___nl__5 = string_NL.NL_tab().clone();

//line 758
___nl__6 = new ImmString("\\t").clone();
//line 758
___nl__4 = string_NL.NL_replace(___nl__3,___nl__5,___nl__6).clone();

//line 758
___nl__6 = null;
//line 758
___nl__5 = null;
//line 758
___nl__3 = ___nl__4.clone();
//line 758
___nl__4 = null;
//line 759
___nl__5 = new ImmString("\"").clone();
//line 759
___nl__6 = new ImmString("\\\"").clone();
//line 759
___nl__4 = string_NL.NL_replace(___nl__3,___nl__5,___nl__6).clone();

//line 759
___nl__6 = null;
//line 759
___nl__5 = null;
//line 759
___nl__3 = ___nl__4.clone();
//line 759
___nl__4 = null;
//line 760
___nl__5 = new ImmString("'").clone();
//line 760
___nl__6 = new ImmString("\\'").clone();
//line 760
___nl__4 = string_NL.NL_replace(___nl__3,___nl__5,___nl__6).clone();

//line 760
___nl__6 = null;
//line 760
___nl__5 = null;
//line 760
___nl__3 = ___nl__4.clone();
//line 760
___nl__4 = null;
//line 761
___nl__5 = new ImmString("string_new_to_memory").clone();
//line 761
___nl__4 = generator_c_NL.NL_get_lib_fun_priv(___nl__5).clone();

//line 761
___nl__5 = null;
//line 761
___nl__5 = new ImmString("(\"").clone();
//line 761
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 761
___nl__5 = null;
//line 761
___nl__4 = new ImmString(___nl__4.toString() + ___nl__3.toString()).clone();
//line 761
___nl__5 = new ImmString("\",").clone();
//line 761
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 761
___nl__5 = null;
//line 761
___nl__4 = new ImmString(___nl__4.toString() + ___nl__1.toString()).clone();
//line 761
___nl__5 = new ImmString(")").clone();
//line 761
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 761
___nl__5 = null;
//line 761
___nl__0 = null;
//line 761
___nl__1 = null;
//line 761
___nl__2 = null;
//line 761
___nl__3 = null;
//line 761
if(true) return ___nl__4;
//line 761
___nl__4 = null;
//line 761
___nl__3 = null;
//line 762
if (true) {goto label_1;}
//line 762
label_1:
//line 762
___nl__2 = null;
//line 762
___nl__0 = null;
//line 762
___nl__1 = null;
//line 762
if(true) return null;
}

}
}