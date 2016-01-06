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
___nl__1 = generator_c_NL.NL_gen_bin_ops_priv();

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
___nl__1 = generator_c_NL.NL_gen_bin_ops_mod_priv();

//line 20
___nl__0 = singleton_NL.NL_sigleton_do_not_use_without_approval(___nl__1);

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
___nl__1 = generator_c_NL.NL_gen_unary_ops_priv();

//line 24
___nl__0 = singleton_NL.NL_sigleton_do_not_use_without_approval(___nl__1);

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
___nl__0 = new ImmHash(__function_map);
//line 29
___nl__1 = new ImmString("!");
//line 29
___nl__2 = new ImmString("not");
//line 29
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 29
___nl__2 = null;
//line 29
___nl__1 = null;
//line 30
___nl__1 = new ImmString("-");
//line 30
___nl__2 = new ImmString("unary_minus");
//line 30
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 30
___nl__2 = null;
//line 30
___nl__1 = null;
//line 31
___nl__1 = new ImmString("+");
//line 31
___nl__2 = new ImmString("unary_plus");
//line 31
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__0 = new ImmHash(__function_map);
//line 37
___nl__1 = new ImmString("eq");
//line 37
___nl__2 = new ImmString("eq");
//line 37
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 37
___nl__2 = null;
//line 37
___nl__1 = null;
//line 38
___nl__1 = new ImmString("ne");
//line 38
___nl__2 = new ImmString("ne");
//line 38
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 38
___nl__2 = null;
//line 38
___nl__1 = null;
//line 39
___nl__1 = new ImmString("+");
//line 39
___nl__2 = new ImmString("add");
//line 39
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 39
___nl__2 = null;
//line 39
___nl__1 = null;
//line 40
___nl__1 = new ImmString("-");
//line 40
___nl__2 = new ImmString("sub");
//line 40
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 40
___nl__2 = null;
//line 40
___nl__1 = null;
//line 41
___nl__1 = new ImmString("*");
//line 41
___nl__2 = new ImmString("mul");
//line 41
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 41
___nl__2 = null;
//line 41
___nl__1 = null;
//line 42
___nl__1 = new ImmString("/");
//line 42
___nl__2 = new ImmString("div");
//line 42
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 42
___nl__2 = null;
//line 42
___nl__1 = null;
//line 43
___nl__1 = new ImmString("%");
//line 43
___nl__2 = new ImmString("mod");
//line 43
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 43
___nl__2 = null;
//line 43
___nl__1 = null;
//line 44
___nl__1 = new ImmString("<=");
//line 44
___nl__2 = new ImmString("le");
//line 44
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 44
___nl__2 = null;
//line 44
___nl__1 = null;
//line 45
___nl__1 = new ImmString("<");
//line 45
___nl__2 = new ImmString("lt");
//line 45
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 45
___nl__2 = null;
//line 45
___nl__1 = null;
//line 46
___nl__1 = new ImmString("==");
//line 46
___nl__2 = new ImmString("num_eq");
//line 46
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 46
___nl__2 = null;
//line 46
___nl__1 = null;
//line 47
___nl__1 = new ImmString("!=");
//line 47
___nl__2 = new ImmString("num_ne");
//line 47
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 47
___nl__2 = null;
//line 47
___nl__1 = null;
//line 48
___nl__1 = new ImmString(">");
//line 48
___nl__2 = new ImmString("gt");
//line 48
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 48
___nl__2 = null;
//line 48
___nl__1 = null;
//line 49
___nl__1 = new ImmString(">=");
//line 49
___nl__2 = new ImmString("ge");
//line 49
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 49
___nl__2 = null;
//line 49
___nl__1 = null;
//line 50
___nl__1 = new ImmString(".");
//line 50
___nl__2 = new ImmString("concat_new");
//line 50
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__0 = new ImmHash(__function_map);
//line 55
___nl__1 = new ImmString("+");
//line 55
___nl__2 = new ImmString("add_mod");
//line 55
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 55
___nl__2 = null;
//line 55
___nl__1 = null;
//line 56
___nl__1 = new ImmString("-");
//line 56
___nl__2 = new ImmString("sub_mod");
//line 56
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 56
___nl__2 = null;
//line 56
___nl__1 = null;
//line 57
___nl__1 = new ImmString("*");
//line 57
___nl__2 = new ImmString("mul_mod");
//line 57
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 57
___nl__2 = null;
//line 57
___nl__1 = null;
//line 58
___nl__1 = new ImmString("/");
//line 58
___nl__2 = new ImmString("div_mod");
//line 58
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 58
___nl__2 = null;
//line 58
___nl__1 = null;
//line 59
___nl__1 = new ImmString("%");
//line 59
___nl__2 = new ImmString("mod_mod");
//line 59
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 59
___nl__2 = null;
//line 59
___nl__1 = null;
//line 60
___nl__1 = new ImmString(".");
//line 60
___nl__2 = new ImmString("concat_add");
//line 60
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__3 = ptd_NL.NL_sim();

//line 65
___nl__2 = ptd_NL.NL_arr(___nl__3);

//line 65
___nl__3 = null;
//line 65
___nl__4 = ptd_NL.NL_sim();

//line 65
___nl__3 = ptd_NL.NL_hash(___nl__4);

//line 65
___nl__4 = null;
//line 65
__function_map = new Dictionary<String, Imm>();
__function_map.Add("arr",___nl__2);
__function_map.Add("hash",___nl__3);
___nl__1 = new ImmHash(__function_map);
//line 65
___nl__2 = null;
//line 65
___nl__3 = null;
//line 65
___nl__0 = ptd_NL.NL_rec(___nl__1);

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
___nl__3 = ptd_NL.NL_none();

//line 71
___nl__4 = ptd_NL.NL_none();

//line 71
__function_map = new Dictionary<String, Imm>();
__function_map.Add("val",___nl__3);
__function_map.Add("ref",___nl__4);
___nl__2 = new ImmHash(__function_map);
//line 71
___nl__3 = null;
//line 71
___nl__4 = null;
//line 71
___nl__1 = ptd_NL.NL_var(___nl__2);

//line 71
___nl__2 = null;
//line 71
___nl__0 = ptd_NL.NL_arr(___nl__1);

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
___nl__3 = ptd_NL.NL_sim();

//line 74
___nl__2 = ptd_NL.NL_arr(___nl__3);

//line 74
___nl__3 = null;
//line 74
___nl__4 = ptd_NL.NL_sim();

//line 74
___nl__3 = ptd_NL.NL_hash(___nl__4);

//line 74
___nl__4 = null;
//line 74
__function_map = new Dictionary<String, Imm>();
__function_map.Add("arr",___nl__2);
__function_map.Add("hash",___nl__3);
___nl__1 = new ImmHash(__function_map);
//line 74
___nl__2 = null;
//line 74
___nl__3 = null;
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
___nl__5 = ptd_NL.NL_sim();

//line 80
___nl__6 = ptd_NL.NL_sim();

//line 80
__function_map = new Dictionary<String, Imm>();
__function_map.Add("key",___nl__5);
__function_map.Add("uses",___nl__6);
___nl__4 = new ImmHash(__function_map);
//line 80
___nl__5 = null;
//line 80
___nl__6 = null;
//line 80
___nl__3 = ptd_NL.NL_rec(___nl__4);

//line 80
___nl__4 = null;
//line 80
___nl__2 = ptd_NL.NL_arr(___nl__3);

//line 80
___nl__3 = null;
//line 80
___nl__4 = ptd_NL.NL_sim();

//line 80
___nl__3 = ptd_NL.NL_hash(___nl__4);

//line 80
___nl__4 = null;
//line 80
___nl__5 = ptd_NL.NL_sim();

//line 80
___nl__4 = ptd_NL.NL_arr(___nl__5);

//line 80
___nl__5 = null;
//line 80
___nl__7 = ptd_NL.NL_sim();

//line 80
___nl__6 = ptd_NL.NL_hash(___nl__7);

//line 80
___nl__7 = null;
//line 80
___nl__5 = ptd_NL.NL_hash(___nl__6);

//line 80
___nl__6 = null;
//line 80
__function_map = new Dictionary<String, Imm>();
__function_map.Add("arr",___nl__2);
__function_map.Add("hash",___nl__3);
__function_map.Add("holes",___nl__4);
__function_map.Add("module_consts",___nl__5);
___nl__1 = new ImmHash(__function_map);
//line 80
___nl__2 = null;
//line 80
___nl__3 = null;
//line 80
___nl__4 = null;
//line 80
___nl__5 = null;
//line 80
___nl__0 = ptd_NL.NL_rec(___nl__1);

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
___nl__2 = new ImmHash(__function_map);
//line 90
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2);
//line 90
___nl__3 = ptd_NL.NL_sim();

//line 90
___nl__4 = ptd_NL.NL_sim();

//line 90
___nl__5 = ptd_NL.NL_sim();

//line 90
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("generator_c_NL"));
__function_map.Add("name",new ImmString("fun_args_t"));
___nl__6 = new ImmHash(__function_map);
//line 90
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__6);
//line 90
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("generator_c_NL"));
__function_map.Add("name",new ImmString("const_t"));
___nl__9 = new ImmHash(__function_map);
//line 90
___nl__9 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__9);
//line 90
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("generator_c_NL"));
__function_map.Add("name",new ImmString("const_t"));
___nl__10 = new ImmHash(__function_map);
//line 90
___nl__10 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__10);
//line 90
___nl__11 = ptd_NL.NL_sim();

//line 90
__function_map = new Dictionary<String, Imm>();
__function_map.Add("sim",___nl__9);
__function_map.Add("singleton",___nl__10);
__function_map.Add("dynamic_nr",___nl__11);
___nl__8 = new ImmHash(__function_map);
//line 90
___nl__9 = null;
//line 90
___nl__10 = null;
//line 90
___nl__11 = null;
//line 90
___nl__7 = ptd_NL.NL_rec(___nl__8);

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
___nl__1 = new ImmHash(__function_map);
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
___nl__0 = ptd_NL.NL_rec(___nl__1);

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
___nl__2 = new ImmArray(new Imm[0]);
//line 105
__function_map = new Dictionary<String, Imm>();
___nl__3 = new ImmHash(__function_map);
//line 105
___nl__4 = new ImmArray(new Imm[0]);
//line 105
__function_map = new Dictionary<String, Imm>();
___nl__5 = new ImmHash(__function_map);
//line 105
__function_map = new Dictionary<String, Imm>();
__function_map.Add("arr",___nl__2);
__function_map.Add("hash",___nl__3);
__function_map.Add("holes",___nl__4);
__function_map.Add("module_consts",___nl__5);
___nl__1 = new ImmHash(__function_map);
//line 105
___nl__2 = null;
//line 105
___nl__3 = null;
//line 105
___nl__4 = null;
//line 105
___nl__5 = null;
//line 105
___nl__2 = new ImmString("");
//line 105
___nl__3 = new ImmString("");
//line 105
___nl__4 = new ImmArray(new Imm[0]);
//line 105
___nl__6 = new ImmDouble(0);
//line 105
___nl__8 = new ImmArray(new Imm[0]);
//line 105
__function_map = new Dictionary<String, Imm>();
___nl__9 = new ImmHash(__function_map);
//line 105
__function_map = new Dictionary<String, Imm>();
__function_map.Add("arr",___nl__8);
__function_map.Add("hash",___nl__9);
___nl__7 = new ImmHash(__function_map);
//line 105
___nl__8 = null;
//line 105
___nl__9 = null;
//line 105
___nl__9 = new ImmArray(new Imm[0]);
//line 105
__function_map = new Dictionary<String, Imm>();
___nl__10 = new ImmHash(__function_map);
//line 105
__function_map = new Dictionary<String, Imm>();
__function_map.Add("arr",___nl__9);
__function_map.Add("hash",___nl__10);
___nl__8 = new ImmHash(__function_map);
//line 105
___nl__9 = null;
//line 105
___nl__10 = null;
//line 105
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dynamic_nr",___nl__6);
__function_map.Add("sim",___nl__7);
__function_map.Add("singleton",___nl__8);
___nl__5 = new ImmHash(__function_map);
//line 105
___nl__6 = null;
//line 105
___nl__7 = null;
//line 105
___nl__8 = null;
//line 105
___nl__6 = new ImmString("");
//line 105
__function_map = new Dictionary<String, Imm>();
__function_map.Add("global_const",___nl__1);
__function_map.Add("ret",___nl__2);
__function_map.Add("header",___nl__3);
__function_map.Add("fun_args",___nl__4);
__function_map.Add("const",___nl__5);
__function_map.Add("mod_name",___nl__6);
___nl__0 = new ImmHash(__function_map);
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
___nl__2 = new ImmString("ret");
//line 120
___nl__2 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__2);

//line 120
___nl__2 = new ImmString(___nl__2.toString() + ___nl__1.toString());
//line 120
___nl__3 = new ImmString("ret");
//line 120
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__3,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__2 = new ImmString("header");
//line 124
___nl__2 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__2);

//line 124
___nl__2 = new ImmString(___nl__2.toString() + ___nl__1.toString());
//line 124
___nl__3 = new ImmString("header");
//line 124
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__3,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__2 = string_NL.NL_lf();

//line 128
___nl__2 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 128
___nl__3 = new ImmString("header");
//line 128
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__3);

//line 128
___nl__3 = new ImmString(___nl__3.toString() + ___nl__2.toString());
//line 128
___nl__4 = new ImmString("header");
//line 128
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__4,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__0 = new ImmString("ImmT ");
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
___nl__2 = new ImmString("ret");
//line 136
___nl__2 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__2);

//line 136
___nl__2 = new ImmString(___nl__2.toString() + ___nl__1.toString());
//line 136
___nl__3 = new ImmString("ret");
//line 136
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__3,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 136
___nl__3 = null;
//line 136
___nl__2 = null;
//line 137
___nl__2 = string_NL.NL_lf();

//line 137
___nl__3 = new ImmString("ret");
//line 137
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__3);

//line 137
___nl__3 = new ImmString(___nl__3.toString() + ___nl__2.toString());
//line 137
___nl__4 = new ImmString("ret");
//line 137
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__4,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__2 = ((ImmHash)___nl__0).getHashValue()["fun_args"];
//line 142
___nl__3 = array_NL.NL_len(___nl__2);

//line 142
___nl__3 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))>(Double.Parse(___nl__1.getValue().ToString())) );
//line 142
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 142
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_3;}}
//line 142
___nl__3 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__1).getDoubleValue()];
//line 142
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("ref"));
//line 142
label_3:
//line 142
___nl__4 = null;
//line 142
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 142
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 143
___nl__4 = new ImmString("*___ref___");
//line 143
___nl__4 = new ImmString(___nl__4.toString() + ___nl__1.toString());
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
___nl__3 = new ImmString("___nl__");
//line 145
___nl__3 = new ImmString(___nl__3.toString() + ___nl__1.toString());
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
___nl__2 = ((ImmHash)___nl__0).getHashValue()["fun_args"];
//line 149
___nl__3 = array_NL.NL_len(___nl__2);

//line 149
___nl__3 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))>(Double.Parse(___nl__1.getValue().ToString())) );
//line 149
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 149
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_3;}}
//line 149
___nl__3 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__1).getDoubleValue()];
//line 149
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("ref"));
//line 149
label_3:
//line 149
___nl__4 = null;
//line 149
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 149
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 150
___nl__4 = new ImmString("___ref___");
//line 150
___nl__4 = new ImmString(___nl__4.toString() + ___nl__1.toString());
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
___nl__3 = new ImmString("&___nl__");
//line 152
___nl__3 = new ImmString(___nl__3.toString() + ___nl__1.toString());
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
___nl__1 = new ImmString("\"");
//line 155
___nl__1 = new ImmString(___nl__1.toString() + ___nl__0.toString());
//line 155
___nl__2 = new ImmString("\"");
//line 155
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
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
___nl__2 = ptd_NL.NL_sim();

//line 159
___nl__3 = ptd_NL.NL_sim();

//line 159
__function_map = new Dictionary<String, Imm>();
__function_map.Add("c",___nl__2);
__function_map.Add("h",___nl__3);
___nl__1 = new ImmHash(__function_map);
//line 159
___nl__2 = null;
//line 159
___nl__3 = null;
//line 159
___nl__0 = ptd_NL.NL_rec(___nl__1);

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
___nl__3 = new ImmHash(__function_map);
//line 163
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3);
//line 163
___nl__2 = ptd_NL.NL_hash(___nl__3);

//line 163
___nl__3 = null;
//line 163
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("generator_c_NL"));
__function_map.Add("name",new ImmString("module_out_t"));
___nl__3 = new ImmHash(__function_map);
//line 163
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3);
//line 163
__function_map = new Dictionary<String, Imm>();
__function_map.Add("modules",___nl__2);
__function_map.Add("global_const",___nl__3);
___nl__1 = new ImmHash(__function_map);
//line 163
___nl__2 = null;
//line 163
___nl__3 = null;
//line 163
___nl__0 = ptd_NL.NL_rec(___nl__1);

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
___nl__2 = new ImmHash(__function_map);
//line 171
___nl__3 = new ImmArray(new Imm[0]);
//line 172
___nl__6 = c_rt_lib_NL.NL_init_iter(___nl__0);

//line 172
label_3:
//line 172
___nl__4 = c_rt_lib_NL.NL_is_end_hash(___nl__6);

//line 172
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_1;}}
//line 172
___nl__4 = c_rt_lib_NL.NL_get_key_iter(___nl__6);

//line 172
___nl__5 = c_rt_lib_NL.NL_hash_get_value(___nl__0,___nl__4);

//line 173
___ref______nl__3 = new ImmRef(___nl__3);
array_NL.NL_push(___ref______nl__3,___nl__4);
___nl__3 = ___ref______nl__3.getValue();

//line 174
___nl__6 = c_rt_lib_NL.NL_next_iter(___nl__6);

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
___nl__3 = ___ref______nl__3.getValue();

//line 176
___nl__5 = new ImmDouble(0);
//line 176
___nl__6 = new ImmDouble(1);
//line 176
___nl__7 = c_rt_lib_NL.NL_array_len(___nl__3);

//line 176
label_6:
//line 176
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) );
//line 176
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_4;}}
//line 176
___nl__4 = (___nl__3 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()];
//line 177
___nl__9 = hash_NL.NL_get_value(___nl__0,___nl__4);

//line 178
___ref______nl__1 = new ImmRef(___nl__1);
generator_c_NL.NL_clear_module_from_state(___ref______nl__1,___nl__4);
___nl__1 = ___ref______nl__1.getValue();

//line 179
___nl__10 = new ImmString("global_const");
//line 179
___nl__10 = c_rt_lib_NL.NL_get_ref_hash(___nl__1,___nl__10);

//line 179
___nl__11 = new ImmString("module_consts");
//line 179
___nl__11 = c_rt_lib_NL.NL_get_ref_hash(___nl__10,___nl__11);

//line 179
__function_map = new Dictionary<String, Imm>();
___nl__12 = new ImmHash(__function_map);
//line 179
___ref______nl__11 = new ImmRef(___nl__11);
hash_NL.NL_set_value(___ref______nl__11,___nl__4,___nl__12);
___nl__11 = ___ref______nl__11.getValue();

//line 179
___nl__12 = null;
//line 179
___nl__12 = new ImmString("module_consts");
//line 179
___ref______nl__10 = new ImmRef(___nl__10);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__10,___nl__12,___nl__11);
___nl__10 = ___ref______nl__10.getValue();

//line 179
___nl__12 = new ImmString("global_const");
//line 179
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__1,___nl__12,___nl__10);
___nl__1 = ___ref______nl__1.getValue();

//line 179
___nl__12 = null;
//line 179
___nl__10 = null;
//line 179
___nl__11 = null;
//line 180
___nl__10 = new ImmString("");
//line 180
___nl__11 = ___nl__10;
//line 180
((ImmHash)___nl__1).set("ret", ___nl__11);
//line 180
___nl__10 = null;
//line 180
___nl__11 = null;
//line 181
___nl__10 = new ImmString("");
//line 181
___nl__11 = ___nl__10;
//line 181
((ImmHash)___nl__1).set("header", ___nl__11);
//line 181
___nl__10 = null;
//line 181
___nl__11 = null;
//line 182
___nl__10 = new ImmArray(new Imm[0]);
//line 182
___nl__11 = ___nl__10;
//line 182
((ImmHash)___nl__1).set("fun_args", ___nl__11);
//line 182
___nl__10 = null;
//line 182
___nl__11 = null;
//line 183
___nl__11 = new ImmDouble(0);
//line 183
___nl__13 = new ImmArray(new Imm[0]);
//line 183
__function_map = new Dictionary<String, Imm>();
___nl__14 = new ImmHash(__function_map);
//line 183
__function_map = new Dictionary<String, Imm>();
__function_map.Add("arr",___nl__13);
__function_map.Add("hash",___nl__14);
___nl__12 = new ImmHash(__function_map);
//line 183
___nl__13 = null;
//line 183
___nl__14 = null;
//line 183
___nl__14 = new ImmArray(new Imm[0]);
//line 183
__function_map = new Dictionary<String, Imm>();
___nl__15 = new ImmHash(__function_map);
//line 183
__function_map = new Dictionary<String, Imm>();
__function_map.Add("arr",___nl__14);
__function_map.Add("hash",___nl__15);
___nl__13 = new ImmHash(__function_map);
//line 183
___nl__14 = null;
//line 183
___nl__15 = null;
//line 183
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dynamic_nr",___nl__11);
__function_map.Add("sim",___nl__12);
__function_map.Add("singleton",___nl__13);
___nl__10 = new ImmHash(__function_map);
//line 183
___nl__11 = null;
//line 183
___nl__12 = null;
//line 183
___nl__13 = null;
//line 183
___nl__11 = ___nl__10;
//line 183
((ImmHash)___nl__1).set("const", ___nl__11);
//line 183
___nl__10 = null;
//line 183
___nl__11 = null;
//line 188
___nl__10 = ___nl__4;
//line 188
((ImmHash)___nl__1).set("mod_name", ___nl__10);
//line 188
___nl__10 = null;
//line 189
___ref______nl__1 = new ImmRef(___nl__1);
generator_c_NL.NL_print_mod_priv(___ref______nl__1,___nl__9);
___nl__1 = ___ref______nl__1.getValue();

//line 190
___nl__11 = ((ImmHash)___nl__1).getHashValue()["ret"];
//line 190
___nl__12 = ((ImmHash)___nl__1).getHashValue()["header"];
//line 190
__function_map = new Dictionary<String, Imm>();
__function_map.Add("c",___nl__11);
__function_map.Add("h",___nl__12);
___nl__10 = new ImmHash(__function_map);
//line 190
___nl__11 = null;
//line 190
___nl__12 = null;
//line 190
___ref______nl__2 = new ImmRef(___nl__2);
hash_NL.NL_set_value(___ref______nl__2,___nl__4,___nl__10);
___nl__2 = ___ref______nl__2.getValue();

//line 190
___nl__10 = null;
//line 190
___nl__9 = null;
//line 191
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString())));
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
___nl__5 = generator_c_NL.NL_generate_global_const_files_priv(___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 192
__function_map = new Dictionary<String, Imm>();
__function_map.Add("modules",___nl__2);
__function_map.Add("global_const",___nl__5);
___nl__4 = new ImmHash(__function_map);
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
___nl__1 = new ImmString("");
//line 196
___nl__2 = ___nl__1;
//line 196
((ImmHash)___nl__0).set("ret", ___nl__2);
//line 196
___nl__1 = null;
//line 196
___nl__2 = null;
//line 197
___nl__1 = new ImmString("");
//line 197
___nl__2 = ___nl__1;
//line 197
((ImmHash)___nl__0).set("header", ___nl__2);
//line 197
___nl__1 = null;
//line 197
___nl__2 = null;
//line 198
___nl__1 = new ImmArray(new Imm[0]);
//line 198
___nl__2 = ___nl__1;
//line 198
((ImmHash)___nl__0).set("fun_args", ___nl__2);
//line 198
___nl__1 = null;
//line 198
___nl__2 = null;
//line 199
___nl__2 = new ImmDouble(0);
//line 199
___nl__4 = new ImmArray(new Imm[0]);
//line 199
__function_map = new Dictionary<String, Imm>();
___nl__5 = new ImmHash(__function_map);
//line 199
__function_map = new Dictionary<String, Imm>();
__function_map.Add("arr",___nl__4);
__function_map.Add("hash",___nl__5);
___nl__3 = new ImmHash(__function_map);
//line 199
___nl__4 = null;
//line 199
___nl__5 = null;
//line 199
___nl__5 = new ImmArray(new Imm[0]);
//line 199
__function_map = new Dictionary<String, Imm>();
___nl__6 = new ImmHash(__function_map);
//line 199
__function_map = new Dictionary<String, Imm>();
__function_map.Add("arr",___nl__5);
__function_map.Add("hash",___nl__6);
___nl__4 = new ImmHash(__function_map);
//line 199
___nl__5 = null;
//line 199
___nl__6 = null;
//line 199
__function_map = new Dictionary<String, Imm>();
__function_map.Add("dynamic_nr",___nl__2);
__function_map.Add("sim",___nl__3);
__function_map.Add("singleton",___nl__4);
___nl__1 = new ImmHash(__function_map);
//line 199
___nl__2 = null;
//line 199
___nl__3 = null;
//line 199
___nl__4 = null;
//line 199
___nl__2 = ___nl__1;
//line 199
((ImmHash)___nl__0).set("const", ___nl__2);
//line 199
___nl__1 = null;
//line 199
___nl__2 = null;
//line 204
___nl__1 = new ImmString("");
//line 204
___nl__2 = ___nl__1;
//line 204
((ImmHash)___nl__0).set("mod_name", ___nl__2);
//line 204
___nl__1 = null;
//line 204
___nl__2 = null;
//line 206
___nl__1 = generator_c_NL.NL_get_cr_priv();

//line 206
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_to_header_priv(___ref______nl__0,___nl__1);
___nl__0 = ___ref______nl__0.getValue();

//line 206
___nl__1 = null;
//line 207
___nl__1 = new ImmString("#pragma once");
//line 207
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_to_header_priv(___ref______nl__0,___nl__1);
___nl__0 = ___ref______nl__0.getValue();

//line 207
___nl__1 = null;
//line 208
___nl__2 = new ImmString("c_rt_lib");
//line 208
___nl__1 = generator_c_NL.NL_get_include_priv(___nl__2);

//line 208
___nl__2 = null;
//line 208
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_to_header_priv(___ref______nl__0,___nl__1);
___nl__0 = ___ref______nl__0.getValue();

//line 208
___nl__1 = null;
//line 211
___nl__1 = generator_c_NL.NL_get_cr_priv();

//line 211
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__1);
___nl__0 = ___ref______nl__0.getValue();

//line 211
___nl__1 = null;
//line 212
___nl__2 = new ImmString("c_global_const");
//line 212
___nl__1 = generator_c_NL.NL_get_include_priv(___nl__2);

//line 212
___nl__2 = null;
//line 212
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__1);
___nl__0 = ___ref______nl__0.getValue();

//line 212
___nl__1 = null;
//line 214
___nl__1 = ((ImmHash)___nl__0).getHashValue()["global_const"];
//line 214
___nl__1 = ((ImmHash)___nl__1).getHashValue()["arr"];
//line 215
___nl__2 = array_NL.NL_len(___nl__1);

//line 217
___nl__3 = new ImmString("void ___global_const_init();");
//line 217
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_to_header_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 217
___nl__3 = null;
//line 218
___nl__3 = generator_c_NL.NL_arg_t_priv();

//line 218
___nl__4 = new ImmString(" ___get_global_const(int __nr);");
//line 218
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 218
___nl__4 = null;
//line 218
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_to_header_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 218
___nl__3 = null;
//line 220
___nl__3 = new ImmString("\nstatic ");
//line 220
___nl__4 = generator_c_NL.NL_arg_t_priv();

//line 220
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 220
___nl__4 = null;
//line 220
___nl__4 = new ImmString(" ___global_const__ = NULL;\nstatic int ___global_const_init__ = 1;\nstatic int ___global_const_offset;");
//line 220
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 220
___nl__4 = null;
//line 220
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 220
___nl__3 = null;
//line 225
___nl__3 = new ImmString("void ___global_const_init(){\nif(___global_const_init__) {\n___global_const_init__ = 0;\n___global_const_offset = c_rt_lib0get_global_const_offset();\n___global_const__ = alloc_mem(");
//line 225
___nl__3 = new ImmString(___nl__3.toString() + ___nl__2.toString());
//line 225
___nl__4 = new ImmString(" * ___global_const_offset);\n");
//line 225
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 225
___nl__4 = null;
//line 225
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 225
___nl__3 = null;
//line 232
___nl__3 = new ImmDouble(0);
//line 232
___nl__4 = new ImmDouble(1);
//line 232
label_3:
//line 232
___nl__5 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))>=(Double.Parse(___nl__2.getValue().ToString())) );
//line 232
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_1;}}
//line 233
___nl__7 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__3).getDoubleValue()];
//line 233
___nl__7 = ((ImmHash)___nl__7).getHashValue()["key"];
//line 233
___nl__8 = new ImmString("___global_const__ + ___global_const_offset * ");
//line 233
___nl__8 = new ImmString(___nl__8.toString() + ___nl__3.toString());
//line 233
___nl__6 = generator_c_NL.NL_create_sim_to_memory_priv(___nl__7,___nl__8);

//line 233
___nl__8 = null;
//line 233
___nl__7 = null;
//line 233
___nl__7 = new ImmString(";");
//line 233
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 233
___nl__7 = null;
//line 233
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

//line 233
___nl__6 = null;
//line 234
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString())));
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
___nl__3 = new ImmString("\n");
//line 236
___nl__5 = new ImmString("register_global_const");
//line 236
___nl__4 = generator_c_NL.NL_get_lib_fun_priv(___nl__5);

//line 236
___nl__5 = null;
//line 236
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 236
___nl__4 = null;
//line 236
___nl__4 = new ImmString("((");
//line 236
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 236
___nl__4 = null;
//line 236
___nl__4 = generator_c_NL.NL_arg_t_priv();

//line 236
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 236
___nl__4 = null;
//line 236
___nl__4 = new ImmString(")___global_const__,(");
//line 236
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 236
___nl__4 = null;
//line 236
___nl__4 = generator_c_NL.NL_arg_t_priv();

//line 236
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 236
___nl__4 = null;
//line 236
___nl__4 = new ImmString(")___global_const__ + ");
//line 236
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 236
___nl__4 = null;
//line 236
___nl__3 = new ImmString(___nl__3.toString() + ___nl__2.toString());
//line 236
___nl__4 = new ImmString(" * ___global_const_offset);\n}}");
//line 236
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 236
___nl__4 = null;
//line 236
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 236
___nl__3 = null;
//line 241
___nl__3 = generator_c_NL.NL_arg_t_priv();

//line 241
___nl__4 = new ImmString("___get_global_const(int __nr) {\n");
//line 241
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 241
___nl__4 = null;
//line 241
___nl__4 = generator_c_NL.NL_arg_t_priv();

//line 241
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 241
___nl__4 = null;
//line 241
___nl__4 = new ImmString("ret = NULL;\n");
//line 241
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 241
___nl__4 = null;
//line 241
___nl__5 = new ImmString("copy");
//line 241
___nl__7 = new ImmString("&ret");
//line 241
___nl__8 = new ImmString("(");
//line 241
___nl__9 = generator_c_NL.NL_arg_t_priv();

//line 241
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 241
___nl__9 = null;
//line 241
___nl__9 = new ImmString(")___global_const__ + ___global_const_offset * __nr");
//line 241
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 241
___nl__9 = null;
//line 241
___nl__6 = new ImmArray(new Imm[] {___nl__7,___nl__8,});
//line 241
___nl__7 = null;
//line 241
___nl__8 = null;
//line 241
___nl__4 = generator_c_NL.NL_get_fun_lib_priv(___nl__5,___nl__6);

//line 241
___nl__6 = null;
//line 241
___nl__5 = null;
//line 241
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 241
___nl__4 = null;
//line 241
___nl__4 = new ImmString(";\nreturn ret;\n}");
//line 241
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 241
___nl__4 = null;
//line 241
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 241
___nl__3 = null;
//line 248
___nl__4 = ((ImmHash)___nl__0).getHashValue()["ret"];
//line 248
___nl__5 = ((ImmHash)___nl__0).getHashValue()["header"];
//line 248
__function_map = new Dictionary<String, Imm>();
__function_map.Add("c",___nl__4);
__function_map.Add("h",___nl__5);
___nl__3 = new ImmHash(__function_map);
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
___nl__1 = new ImmString("#include \"");
//line 252
___nl__1 = new ImmString(___nl__1.toString() + ___nl__0.toString());
//line 252
___nl__2 = new ImmString(".h\"");
//line 252
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
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
___nl__0 = new ImmString("\n/* (c) Atinea Sp z o. o.\n *  Stamp: nianio lang\n */\n");
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
___nl__3 = ((ImmHash)___nl__0).getHashValue()["access"];
//line 264
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("pub"));
//line 264
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 266
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("priv"));
//line 266
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_3;}}
//line 266
___nl__4 = new ImmString("NOMATCHALERT");
//line 266
___nl__4 = new ImmArray(new Imm[] {___nl__4,___nl__3,});
//line 266
c_rt_lib_NL.NL_die();
//line 264
label_2:
//line 265
___nl__2 = ___nl__1;
//line 266
if (true) {goto label_1;}
//line 266
label_3:
//line 267
___nl__5 = new ImmString("");
//line 267
___nl__2 = ___nl__5;
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
___nl__4 = ((ImmHash)___nl__0).getHashValue()["name"];
//line 269
___nl__3 = generator_c_NL.NL_get_fun_name_priv(___nl__2,___nl__4,___nl__1);

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
___nl__2 = new ImmString("");
//line 273
___nl__3 = generator_c_NL.NL_get_function_name_priv(___nl__0,___nl__1);

//line 274
___nl__4 = generator_c_NL.NL_arg_t_priv();

//line 274
___nl__4 = new ImmString(___nl__4.toString() + ___nl__3.toString());
//line 274
___nl__5 = new ImmString("(");
//line 274
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 274
___nl__5 = null;
//line 274
___nl__2 = new ImmString(___nl__2.toString() + ___nl__4.toString());
//line 274
___nl__4 = null;
//line 275
___nl__4 = new ImmDouble(0);
//line 276
___nl__5 = ((ImmHash)___nl__0).getHashValue()["args_type"];
//line 276
___nl__7 = new ImmDouble(0);
//line 276
___nl__8 = new ImmDouble(1);
//line 276
___nl__9 = c_rt_lib_NL.NL_array_len(___nl__5);

//line 276
label_3:
//line 276
___nl__10 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))>=(Double.Parse(___nl__9.getValue().ToString())) );
//line 276
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_1;}}
//line 276
___nl__6 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 277
___nl__11 = new ImmDouble(0);
//line 277
___nl__11 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__11.getValue().ToString())) ==((Double.Parse(___nl__4.getValue().ToString())))  );
//line 277
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11));
//line 277
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11));
//line 277
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_5;}}
//line 277
___nl__12 = new ImmString(",");
//line 277
___nl__2 = new ImmString(___nl__2.toString() + ___nl__12.toString());
//line 277
___nl__12 = null;
//line 277
if (true) {goto label_5;}
//line 277
label_5:
//line 277
___nl__11 = null;
//line 278
___nl__11 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("val"));
//line 278
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_7;}}
//line 280
___nl__11 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("ref"));
//line 280
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_8;}}
//line 280
___nl__11 = new ImmString("NOMATCHALERT");
//line 280
___nl__11 = new ImmArray(new Imm[] {___nl__11,___nl__6,});
//line 280
c_rt_lib_NL.NL_die();
//line 278
label_7:
//line 279
___nl__12 = generator_c_NL.NL_arg_t_priv();

//line 279
___nl__13 = new ImmString("___nl__");
//line 279
___nl__12 = new ImmString(___nl__12.toString() + ___nl__13.toString());
//line 279
___nl__13 = null;
//line 279
___nl__12 = new ImmString(___nl__12.toString() + ___nl__4.toString());
//line 279
___nl__2 = new ImmString(___nl__2.toString() + ___nl__12.toString());
//line 279
___nl__12 = null;
//line 280
if (true) {goto label_6;}
//line 280
label_8:
//line 281
___nl__12 = generator_c_NL.NL_arg_t_priv();

//line 281
___nl__13 = new ImmString("* ___ref___");
//line 281
___nl__12 = new ImmString(___nl__12.toString() + ___nl__13.toString());
//line 281
___nl__13 = null;
//line 281
___nl__12 = new ImmString(___nl__12.toString() + ___nl__4.toString());
//line 281
___nl__2 = new ImmString(___nl__2.toString() + ___nl__12.toString());
//line 281
___nl__12 = null;
//line 282
if (true) {goto label_6;}
//line 282
label_6:
//line 282
___nl__11 = null;
//line 283
___nl__11 = new ImmDouble(1);
//line 283
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__11.getValue().ToString())));
//line 283
___nl__11 = null;
//line 284
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString())));
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
___nl__5 = new ImmString(")");
//line 286
___nl__2 = new ImmString(___nl__2.toString() + ___nl__5.toString());
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
___nl__2 = new ImmDouble(1);
//line 291
___nl__2 = new ImmDouble(-((ImmDouble)___nl__2).getDoubleValue());
//line 292
___nl__4 = ((ImmHash)___nl__0).getHashValue()["hash"];
//line 292
___nl__3 = hash_NL.NL_has_key(___nl__4,___nl__1);

//line 292
___nl__4 = null;
//line 292
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 292
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 292
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 293
___nl__5 = ((ImmHash)___nl__0).getHashValue()["arr"];
//line 293
___nl__4 = array_NL.NL_len(___nl__5);

//line 293
___nl__5 = null;
//line 293
___nl__2 = ___nl__4;
//line 293
___nl__4 = null;
//line 294
___nl__4 = new ImmString("arr");
//line 294
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__4);

//line 294
___ref______nl__4 = new ImmRef(___nl__4);
array_NL.NL_push(___ref______nl__4,___nl__1);
___nl__4 = ___ref______nl__4.getValue();

//line 294
___nl__5 = new ImmString("arr");
//line 294
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 294
___nl__5 = null;
//line 294
___nl__4 = null;
//line 295
___nl__4 = new ImmString("hash");
//line 295
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__4);

//line 295
___ref______nl__4 = new ImmRef(___nl__4);
hash_NL.NL_set_value(___ref______nl__4,___nl__1,___nl__2);
___nl__4 = ___ref______nl__4.getValue();

//line 295
___nl__5 = new ImmString("hash");
//line 295
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 295
___nl__5 = null;
//line 295
___nl__4 = null;
//line 296
if (true) {goto label_1;}
//line 296
label_2:
//line 297
___nl__5 = ((ImmHash)___nl__0).getHashValue()["hash"];
//line 297
___nl__4 = hash_NL.NL_get_value(___nl__5,___nl__1);

//line 297
___nl__5 = null;
//line 297
___nl__2 = ___nl__4;
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
___nl__4 = ((ImmHash)___nl__0).getHashValue()["module_consts"];
//line 302
___nl__3 = hash_NL.NL_get_value(___nl__4,___nl__2);

//line 302
___nl__4 = null;
//line 303
___nl__4 = new ImmString("");
//line 303
___ref______nl__3 = new ImmRef(___nl__3);
hash_NL.NL_set_value(___ref______nl__3,___nl__1,___nl__4);
___nl__3 = ___ref______nl__3.getValue();

//line 303
___nl__4 = null;
//line 304
___nl__4 = new ImmString("module_consts");
//line 304
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__4);

//line 304
___ref______nl__4 = new ImmRef(___nl__4);
hash_NL.NL_set_value(___ref______nl__4,___nl__2,___nl__3);
___nl__4 = ___ref______nl__4.getValue();

//line 304
___nl__5 = new ImmString("module_consts");
//line 304
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__3 = new ImmDouble(1);
//line 307
___nl__3 = new ImmDouble(-((ImmDouble)___nl__3).getDoubleValue());
//line 308
___nl__5 = ((ImmHash)___nl__0).getHashValue()["hash"];
//line 308
___nl__4 = hash_NL.NL_has_key(___nl__5,___nl__1);

//line 308
___nl__5 = null;
//line 308
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 308
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 308
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 309
___nl__6 = ((ImmHash)___nl__0).getHashValue()["holes"];
//line 309
___nl__5 = array_NL.NL_len(___nl__6);

//line 309
___nl__6 = null;
//line 309
___nl__6 = new ImmDouble(0);
//line 309
___nl__5 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>(Double.Parse(___nl__6.getValue().ToString())) );
//line 309
___nl__6 = null;
//line 309
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 309
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_4;}}
//line 310
___nl__6 = ((ImmHash)___nl__0).getHashValue()["holes"];
//line 310
___nl__8 = ((ImmHash)___nl__0).getHashValue()["holes"];
//line 310
___nl__7 = array_NL.NL_len(___nl__8);

//line 310
___nl__8 = null;
//line 310
___nl__8 = new ImmDouble(1);
//line 310
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))-(Double.Parse(___nl__8.getValue().ToString())));
//line 310
___nl__8 = null;
//line 310
___nl__6 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 310
___nl__7 = null;
//line 310
___nl__3 = ___nl__6;
//line 310
___nl__6 = null;
//line 311
___nl__6 = new ImmString("holes");
//line 311
___nl__6 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__6);

//line 311
___ref______nl__6 = new ImmRef(___nl__6);
array_NL.NL_pop(___ref______nl__6);
___nl__6 = ___ref______nl__6.getValue();

//line 311
___nl__7 = new ImmString("holes");
//line 311
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__7,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

//line 311
___nl__7 = null;
//line 311
___nl__6 = null;
//line 312
___nl__7 = new ImmDouble(1);
//line 312
__function_map = new Dictionary<String, Imm>();
__function_map.Add("key",___nl__1);
__function_map.Add("uses",___nl__7);
___nl__6 = new ImmHash(__function_map);
//line 312
___nl__7 = null;
//line 312
___nl__7 = new ImmString("arr");
//line 312
___nl__7 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__7);

//line 312
___nl__8 = ___nl__6;
//line 312
(___nl__7 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__3).getDoubleValue()] = ___nl__8;
//line 312
___nl__9 = new ImmString("arr");
//line 312
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__9,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__7 = ((ImmHash)___nl__0).getHashValue()["arr"];
//line 314
___nl__6 = array_NL.NL_len(___nl__7);

//line 314
___nl__7 = null;
//line 314
___nl__3 = ___nl__6;
//line 314
___nl__6 = null;
//line 315
___nl__6 = new ImmString("arr");
//line 315
___nl__6 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__6);

//line 315
___nl__8 = new ImmDouble(1);
//line 315
__function_map = new Dictionary<String, Imm>();
__function_map.Add("key",___nl__1);
__function_map.Add("uses",___nl__8);
___nl__7 = new ImmHash(__function_map);
//line 315
___nl__8 = null;
//line 315
___ref______nl__6 = new ImmRef(___nl__6);
array_NL.NL_push(___ref______nl__6,___nl__7);
___nl__6 = ___ref______nl__6.getValue();

//line 315
___nl__7 = null;
//line 315
___nl__7 = new ImmString("arr");
//line 315
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__7,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__0 = ___ref______nl__0.getValue();

//line 318
___nl__5 = new ImmString("hash");
//line 318
___nl__5 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__5);

//line 318
___ref______nl__5 = new ImmRef(___nl__5);
hash_NL.NL_set_value(___ref______nl__5,___nl__1,___nl__3);
___nl__5 = ___ref______nl__5.getValue();

//line 318
___nl__6 = new ImmString("hash");
//line 318
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__6,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 318
___nl__6 = null;
//line 318
___nl__5 = null;
//line 319
if (true) {goto label_1;}
//line 319
label_2:
//line 320
___nl__6 = ((ImmHash)___nl__0).getHashValue()["hash"];
//line 320
___nl__5 = hash_NL.NL_get_value(___nl__6,___nl__1);

//line 320
___nl__6 = null;
//line 320
___nl__3 = ___nl__5;
//line 320
___nl__5 = null;
//line 321
___nl__6 = ((ImmHash)___nl__0).getHashValue()["module_consts"];
//line 321
___nl__5 = hash_NL.NL_get_value(___nl__6,___nl__2);

//line 321
___nl__6 = null;
//line 322
___nl__6 = hash_NL.NL_has_key(___nl__5,___nl__1);

//line 322
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 322
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 322
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_6;}}
//line 323
___nl__7 = new ImmString("arr");
//line 323
___nl__7 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__7);

//line 323
___nl__8 = c_rt_lib_NL.NL_get_ref_arr(___nl__7,___nl__3);

//line 323
___nl__9 = new ImmString("uses");
//line 323
___nl__9 = c_rt_lib_NL.NL_get_ref_hash(___nl__8,___nl__9);

//line 323
___nl__10 = new ImmDouble(1);
//line 323
___nl__9 = new ImmDouble((Double.Parse(___nl__9.getValue().ToString()))+(Double.Parse(___nl__10.getValue().ToString())));
//line 323
___nl__11 = new ImmString("uses");
//line 323
___ref______nl__8 = new ImmRef(___nl__8);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__8,___nl__11,___nl__9);
___nl__8 = ___ref______nl__8.getValue();

//line 323
___ref______nl__7 = new ImmRef(___nl__7);
c_rt_lib_NL.NL_set_ref_arr(___ref______nl__7,___nl__3,___nl__8);
___nl__7 = ___ref______nl__7.getValue();

//line 323
___nl__11 = new ImmString("arr");
//line 323
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__11,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__0 = ___ref______nl__0.getValue();

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
___nl__3 = ((ImmHash)___nl__0).getHashValue()["global_const"];
//line 330
___nl__3 = ((ImmHash)___nl__3).getHashValue()["module_consts"];
//line 330
___nl__2 = hash_NL.NL_has_key(___nl__3,___nl__1);

//line 330
___nl__3 = null;
//line 330
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 330
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 331
___nl__4 = ((ImmHash)___nl__0).getHashValue()["global_const"];
//line 331
___nl__4 = ((ImmHash)___nl__4).getHashValue()["module_consts"];
//line 331
___nl__3 = hash_NL.NL_get_value(___nl__4,___nl__1);

//line 331
___nl__4 = null;
//line 332
___nl__6 = c_rt_lib_NL.NL_init_iter(___nl__3);

//line 332
label_5:
//line 332
___nl__4 = c_rt_lib_NL.NL_is_end_hash(___nl__6);

//line 332
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_3;}}
//line 332
___nl__4 = c_rt_lib_NL.NL_get_key_iter(___nl__6);

//line 332
___nl__5 = c_rt_lib_NL.NL_hash_get_value(___nl__3,___nl__4);

//line 333
___nl__8 = ((ImmHash)___nl__0).getHashValue()["global_const"];
//line 333
___nl__8 = ((ImmHash)___nl__8).getHashValue()["hash"];
//line 333
___nl__7 = hash_NL.NL_get_value(___nl__8,___nl__4);

//line 333
___nl__8 = null;
//line 334
___nl__8 = new ImmString("global_const");
//line 334
___nl__8 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__8);

//line 334
___nl__9 = new ImmString("arr");
//line 334
___nl__9 = c_rt_lib_NL.NL_get_ref_hash(___nl__8,___nl__9);

//line 334
___nl__10 = c_rt_lib_NL.NL_get_ref_arr(___nl__9,___nl__7);

//line 334
___nl__11 = new ImmString("uses");
//line 334
___nl__11 = c_rt_lib_NL.NL_get_ref_hash(___nl__10,___nl__11);

//line 334
___nl__12 = new ImmDouble(1);
//line 334
___nl__11 = new ImmDouble((Double.Parse(___nl__11.getValue().ToString()))-(Double.Parse(___nl__12.getValue().ToString())));
//line 334
___nl__13 = new ImmString("uses");
//line 334
___ref______nl__10 = new ImmRef(___nl__10);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__10,___nl__13,___nl__11);
___nl__10 = ___ref______nl__10.getValue();

//line 334
___ref______nl__9 = new ImmRef(___nl__9);
c_rt_lib_NL.NL_set_ref_arr(___ref______nl__9,___nl__7,___nl__10);
___nl__9 = ___ref______nl__9.getValue();

//line 334
___nl__13 = new ImmString("arr");
//line 334
___ref______nl__8 = new ImmRef(___nl__8);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__8,___nl__13,___nl__9);
___nl__8 = ___ref______nl__8.getValue();

//line 334
___nl__13 = new ImmString("global_const");
//line 334
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__13,___nl__8);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__8 = ((ImmHash)___nl__0).getHashValue()["global_const"];
//line 335
___nl__8 = ((ImmHash)___nl__8).getHashValue()["arr"];
//line 335
___nl__8 = (___nl__8 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 335
___nl__8 = ((ImmHash)___nl__8).getHashValue()["uses"];
//line 335
___nl__9 = new ImmDouble(0);
//line 335
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString())) ==((Double.Parse(___nl__9.getValue().ToString())))  );
//line 335
___nl__9 = null;
//line 335
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8));
//line 335
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_7;}}
//line 336
___nl__9 = new ImmString("global_const");
//line 336
___nl__9 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__9);

//line 336
___nl__10 = new ImmString("hash");
//line 336
___nl__10 = c_rt_lib_NL.NL_get_ref_hash(___nl__9,___nl__10);

//line 336
___ref______nl__10 = new ImmRef(___nl__10);
hash_NL.NL_delete(___ref______nl__10,___nl__4);
___nl__10 = ___ref______nl__10.getValue();

//line 336
___nl__11 = new ImmString("hash");
//line 336
___ref______nl__9 = new ImmRef(___nl__9);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__9,___nl__11,___nl__10);
___nl__9 = ___ref______nl__9.getValue();

//line 336
___nl__11 = new ImmString("global_const");
//line 336
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__11,___nl__9);
___nl__0 = ___ref______nl__0.getValue();

//line 336
___nl__11 = null;
//line 336
___nl__9 = null;
//line 336
___nl__10 = null;
//line 337
___nl__9 = new ImmString("global_const");
//line 337
___nl__9 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__9);

//line 337
___nl__10 = new ImmString("holes");
//line 337
___nl__10 = c_rt_lib_NL.NL_get_ref_hash(___nl__9,___nl__10);

//line 337
___ref______nl__10 = new ImmRef(___nl__10);
array_NL.NL_push(___ref______nl__10,___nl__7);
___nl__10 = ___ref______nl__10.getValue();

//line 337
___nl__11 = new ImmString("holes");
//line 337
___ref______nl__9 = new ImmRef(___nl__9);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__9,___nl__11,___nl__10);
___nl__9 = ___ref______nl__9.getValue();

//line 337
___nl__11 = new ImmString("global_const");
//line 337
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__11,___nl__9);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__6 = c_rt_lib_NL.NL_next_iter(___nl__6);

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
___nl__4 = new ImmString("global_const");
//line 340
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__4);

//line 340
___nl__5 = new ImmString("module_consts");
//line 340
___nl__5 = c_rt_lib_NL.NL_get_ref_hash(___nl__4,___nl__5);

//line 340
___ref______nl__5 = new ImmRef(___nl__5);
hash_NL.NL_delete(___ref______nl__5,___nl__1);
___nl__5 = ___ref______nl__5.getValue();

//line 340
___nl__6 = new ImmString("module_consts");
//line 340
___ref______nl__4 = new ImmRef(___nl__4);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__4,___nl__6,___nl__5);
___nl__4 = ___ref______nl__4.getValue();

//line 340
___nl__6 = new ImmString("global_const");
//line 340
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__6,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__3 = new ImmString("global_const");
//line 344
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__3);

//line 344
___nl__4 = ((ImmHash)___nl__0).getHashValue()["mod_name"];
//line 344
___ref______nl__3 = new ImmRef(___nl__3);
___nl__2 = generator_c_NL.NL_get_global_const_priv(___ref______nl__3,___nl__1,___nl__4);
___nl__3 = ___ref______nl__3.getValue();

//line 344
___nl__4 = null;
//line 344
___nl__4 = new ImmString("global_const");
//line 344
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__4,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 344
___nl__4 = null;
//line 344
___nl__3 = null;
//line 345
___nl__3 = new ImmString("___get_global_const(");
//line 345
___nl__3 = new ImmString(___nl__3.toString() + ___nl__2.toString());
//line 345
___nl__4 = new ImmString(")");
//line 345
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
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
___nl__3 = new ImmString("const");
//line 348
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__3);

//line 348
___nl__4 = new ImmString("singleton");
//line 348
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__3,___nl__4);

//line 348
___ref______nl__4 = new ImmRef(___nl__4);
___nl__2 = generator_c_NL.NL_get_const_priv(___ref______nl__4,___nl__1);
___nl__4 = ___ref______nl__4.getValue();

//line 348
___nl__5 = new ImmString("singleton");
//line 348
___ref______nl__3 = new ImmRef(___nl__3);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__3,___nl__5,___nl__4);
___nl__3 = ___ref______nl__3.getValue();

//line 348
___nl__5 = new ImmString("const");
//line 348
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 348
___nl__5 = null;
//line 348
___nl__3 = null;
//line 348
___nl__4 = null;
//line 349
___nl__4 = new ImmString("");
//line 349
___nl__5 = new ImmString("__const__sing");
//line 349
___nl__6 = ((ImmHash)___nl__0).getHashValue()["mod_name"];
//line 349
___nl__3 = generator_c_NL.NL_get_fun_name_priv(___nl__4,___nl__5,___nl__6);

//line 349
___nl__6 = null;
//line 349
___nl__5 = null;
//line 349
___nl__4 = null;
//line 349
___nl__4 = new ImmString("(");
//line 349
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 349
___nl__4 = null;
//line 349
___nl__3 = new ImmString(___nl__3.toString() + ___nl__2.toString());
//line 349
___nl__4 = new ImmString(")");
//line 349
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
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
___nl__2 = generator_c_NL.NL_arg_t_priv();

//line 352
___nl__3 = generator_c_NL.NL_get_function_name_priv(___nl__0,___nl__1);

//line 352
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 352
___nl__3 = null;
//line 352
___nl__3 = new ImmString("0ptr(int _num, ImmT *_tab)");
//line 352
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
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
___nl__2 = generator_c_NL.NL_get_cr_priv();

//line 356
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_to_header_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 356
___nl__2 = null;
//line 357
___nl__2 = new ImmString("#pragma once");
//line 357
___nl__3 = string_NL.NL_lf();

//line 357
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 357
___nl__3 = null;
//line 357
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_to_header_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 357
___nl__2 = null;
//line 358
___nl__3 = new ImmString("c_rt_lib");
//line 358
___nl__2 = generator_c_NL.NL_get_include_priv(___nl__3);

//line 358
___nl__3 = null;
//line 358
___nl__3 = string_NL.NL_lf();

//line 358
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 358
___nl__3 = null;
//line 358
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_to_header_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 358
___nl__2 = null;
//line 360
___nl__2 = generator_c_NL.NL_get_cr_priv();

//line 360
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 360
___nl__2 = null;
//line 361
___nl__3 = new ImmString("c_rt_lib");
//line 361
___nl__2 = generator_c_NL.NL_get_include_priv(___nl__3);

//line 361
___nl__3 = null;
//line 361
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 361
___nl__2 = null;
//line 362
___nl__3 = new ImmString("c_global_const");
//line 362
___nl__2 = generator_c_NL.NL_get_include_priv(___nl__3);

//line 362
___nl__3 = null;
//line 362
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 362
___nl__2 = null;
//line 363
___nl__3 = ((ImmHash)___nl__0).getHashValue()["mod_name"];
//line 363
___nl__2 = generator_c_NL.NL_get_include_priv(___nl__3);

//line 363
___nl__3 = null;
//line 363
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 363
___nl__2 = null;
//line 365
___nl__2 = ((ImmHash)___nl__1).getHashValue()["imports"];
//line 365
___nl__4 = new ImmDouble(0);
//line 365
___nl__5 = new ImmDouble(1);
//line 365
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__2);

//line 365
label_3:
//line 365
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) );
//line 365
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_1;}}
//line 365
___nl__3 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()];
//line 366
___nl__8 = generator_c_NL.NL_get_include_priv(___nl__3);

//line 366
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__8);
___nl__0 = ___ref______nl__0.getValue();

//line 366
___nl__8 = null;
//line 367
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString())));
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
___nl__2 = new ImmString("#line 1 \"");
//line 368
___nl__3 = ((ImmHash)___nl__0).getHashValue()["mod_name"];
//line 368
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 368
___nl__3 = null;
//line 368
___nl__3 = new ImmString(".nl\"");
//line 368
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 368
___nl__3 = null;
//line 368
___nl__3 = string_NL.NL_lf();

//line 368
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 368
___nl__3 = null;
//line 368
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 368
___nl__2 = null;
//line 371
___nl__2 = new ImmString("static ");
//line 371
___nl__3 = generator_c_NL.NL_arg_t_priv();

//line 371
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 371
___nl__3 = null;
//line 371
___nl__3 = new ImmString("*__const__f = NULL;");
//line 371
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 371
___nl__3 = null;
//line 371
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 371
___nl__2 = null;
//line 372
___nl__2 = new ImmString("void ");
//line 372
___nl__4 = new ImmString("");
//line 372
___nl__5 = new ImmString("__const__init");
//line 372
___nl__6 = ((ImmHash)___nl__0).getHashValue()["mod_name"];
//line 372
___nl__3 = generator_c_NL.NL_get_fun_name_priv(___nl__4,___nl__5,___nl__6);

//line 372
___nl__6 = null;
//line 372
___nl__5 = null;
//line 372
___nl__4 = null;
//line 372
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 372
___nl__3 = null;
//line 372
___nl__3 = new ImmString("();");
//line 372
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 372
___nl__3 = null;
//line 372
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 372
___nl__2 = null;
//line 373
___nl__2 = generator_c_NL.NL_arg_t_priv();

//line 373
___nl__4 = new ImmString("");
//line 373
___nl__5 = new ImmString("__const__sim");
//line 373
___nl__6 = ((ImmHash)___nl__0).getHashValue()["mod_name"];
//line 373
___nl__3 = generator_c_NL.NL_get_fun_name_priv(___nl__4,___nl__5,___nl__6);

//line 373
___nl__6 = null;
//line 373
___nl__5 = null;
//line 373
___nl__4 = null;
//line 373
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 373
___nl__3 = null;
//line 373
___nl__3 = new ImmString("(int __nr);");
//line 373
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 373
___nl__3 = null;
//line 373
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 373
___nl__2 = null;
//line 374
___nl__2 = generator_c_NL.NL_arg_t_priv();

//line 374
___nl__4 = new ImmString("");
//line 374
___nl__5 = new ImmString("__const__sing");
//line 374
___nl__6 = ((ImmHash)___nl__0).getHashValue()["mod_name"];
//line 374
___nl__3 = generator_c_NL.NL_get_fun_name_priv(___nl__4,___nl__5,___nl__6);

//line 374
___nl__6 = null;
//line 374
___nl__5 = null;
//line 374
___nl__4 = null;
//line 374
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 374
___nl__3 = null;
//line 374
___nl__3 = new ImmString("(int __nr);");
//line 374
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 374
___nl__3 = null;
//line 374
___nl__3 = string_NL.NL_lf();

//line 374
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 374
___nl__3 = null;
//line 374
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 374
___nl__2 = null;
//line 376
___nl__2 = ((ImmHash)___nl__1).getHashValue()["functions"];
//line 376
___nl__4 = new ImmDouble(0);
//line 376
___nl__5 = new ImmDouble(1);
//line 376
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__2);

//line 376
label_6:
//line 376
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) );
//line 376
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_4;}}
//line 376
___nl__3 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()];
//line 377
___nl__9 = ((ImmHash)___nl__0).getHashValue()["mod_name"];
//line 377
___nl__8 = generator_c_NL.NL_get_function_header_priv(___nl__3,___nl__9);

//line 377
___nl__9 = null;
//line 378
___nl__9 = ((ImmHash)___nl__3).getHashValue()["access"];
//line 378
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__9, new ImmString("pub"));
//line 378
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_8;}}
//line 381
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__9, new ImmString("priv"));
//line 381
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_9;}}
//line 381
___nl__10 = new ImmString("NOMATCHALERT");
//line 381
___nl__10 = new ImmArray(new Imm[] {___nl__10,___nl__9,});
//line 381
c_rt_lib_NL.NL_die();
//line 378
label_8:
//line 379
___nl__11 = new ImmString(";");
//line 379
___nl__11 = new ImmString(___nl__8.toString() + ___nl__11.toString());
//line 379
___nl__12 = string_NL.NL_lf();

//line 379
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString());
//line 379
___nl__12 = null;
//line 379
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_to_header_priv(___ref______nl__0,___nl__11);
___nl__0 = ___ref______nl__0.getValue();

//line 379
___nl__11 = null;
//line 380
___nl__12 = ((ImmHash)___nl__0).getHashValue()["mod_name"];
//line 380
___nl__11 = generator_c_NL.NL_get_func_ptr_header_priv(___nl__3,___nl__12);

//line 380
___nl__12 = null;
//line 380
___nl__12 = new ImmString(";");
//line 380
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString());
//line 380
___nl__12 = null;
//line 380
___nl__12 = string_NL.NL_lf();

//line 380
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString());
//line 380
___nl__12 = null;
//line 380
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_to_header_priv(___ref______nl__0,___nl__11);
___nl__0 = ___ref______nl__0.getValue();

//line 380
___nl__11 = null;
//line 381
if (true) {goto label_7;}
//line 381
label_9:
//line 382
___nl__11 = new ImmString(";");
//line 382
___nl__11 = new ImmString(___nl__8.toString() + ___nl__11.toString());
//line 382
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__11);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString())));
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
___nl__2 = string_NL.NL_lf();

//line 385
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 385
___nl__2 = null;
//line 387
___nl__2 = ((ImmHash)___nl__1).getHashValue()["functions"];
//line 387
___nl__4 = new ImmDouble(0);
//line 387
___nl__5 = new ImmDouble(1);
//line 387
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__2);

//line 387
label_12:
//line 387
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) );
//line 387
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_10;}}
//line 387
___nl__3 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()];
//line 388
___nl__8 = ((ImmHash)___nl__3).getHashValue()["access"];
//line 388
___nl__8 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("pub"));
//line 388
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8));
//line 388
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_14;}}
//line 389
___nl__10 = ((ImmHash)___nl__0).getHashValue()["mod_name"];
//line 389
___nl__9 = generator_c_NL.NL_get_function_name_priv(___nl__3,___nl__10);

//line 389
___nl__10 = null;
//line 390
___nl__11 = ((ImmHash)___nl__0).getHashValue()["mod_name"];
//line 390
___nl__10 = generator_c_NL.NL_get_func_ptr_header_priv(___nl__3,___nl__11);

//line 390
___nl__11 = null;
//line 390
___nl__11 = new ImmString("{");
//line 390
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString());
//line 390
___nl__11 = null;
//line 390
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__10);
___nl__0 = ___ref______nl__0.getValue();

//line 390
___nl__10 = null;
//line 391
___nl__11 = ((ImmHash)___nl__3).getHashValue()["args_type"];
//line 391
___nl__10 = array_NL.NL_len(___nl__11);

//line 391
___nl__11 = null;
//line 392
___nl__12 = new ImmString("func_num_args");
//line 392
___nl__14 = new ImmString("_num");
//line 392
___nl__15 = generator_c_NL.NL_get_string_priv(___nl__9);

//line 392
___nl__13 = new ImmArray(new Imm[] {___nl__14,___nl__10,___nl__15,});
//line 392
___nl__14 = null;
//line 392
___nl__15 = null;
//line 392
___nl__11 = generator_c_NL.NL_get_fun_lib_priv(___nl__12,___nl__13);

//line 392
___nl__13 = null;
//line 392
___nl__12 = null;
//line 392
___nl__12 = new ImmString(";");
//line 392
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString());
//line 392
___nl__12 = null;
//line 392
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__11);
___nl__0 = ___ref______nl__0.getValue();

//line 392
___nl__11 = null;
//line 393
___nl__11 = new ImmString("return ");
//line 393
___nl__11 = new ImmString(___nl__11.toString() + ___nl__9.toString());
//line 393
___nl__12 = new ImmString("(");
//line 393
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString());
//line 393
___nl__12 = null;
//line 393
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__11);
___nl__0 = ___ref______nl__0.getValue();

//line 393
___nl__11 = null;
//line 394
___nl__11 = new ImmDouble(0);
//line 394
___nl__12 = new ImmDouble(1);
//line 394
label_17:
//line 394
___nl__13 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__11.getValue().ToString()))>=(Double.Parse(___nl__10.getValue().ToString())) );
//line 394
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_15;}}
//line 395
___nl__14 = new ImmDouble(0);
//line 395
___nl__14 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__11.getValue().ToString()))>(Double.Parse(___nl__14.getValue().ToString())) );
//line 395
___nl__14 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__14));
//line 395
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_19;}}
//line 395
___nl__15 = new ImmString(", ");
//line 395
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__15);
___nl__0 = ___ref______nl__0.getValue();

//line 395
___nl__15 = null;
//line 395
if (true) {goto label_19;}
//line 395
label_19:
//line 395
___nl__14 = null;
//line 396
___nl__14 = ((ImmHash)___nl__3).getHashValue()["args_type"];
//line 396
___nl__14 = (___nl__14 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__11).getDoubleValue()];
//line 396
___nl__15 = c_rt_lib_NL.NL_ov_is(___nl__14, new ImmString("val"));
//line 396
if (c_rt_lib_NL.NL_check_true_native(___nl__15)) {if (true) {goto label_21;}}
//line 398
___nl__15 = c_rt_lib_NL.NL_ov_is(___nl__14, new ImmString("ref"));
//line 398
if (c_rt_lib_NL.NL_check_true_native(___nl__15)) {if (true) {goto label_22;}}
//line 398
___nl__15 = new ImmString("NOMATCHALERT");
//line 398
___nl__15 = new ImmArray(new Imm[] {___nl__15,___nl__14,});
//line 398
c_rt_lib_NL.NL_die();
//line 396
label_21:
//line 397
___nl__16 = new ImmString("_tab[");
//line 397
___nl__16 = new ImmString(___nl__16.toString() + ___nl__11.toString());
//line 397
___nl__17 = new ImmString("]");
//line 397
___nl__16 = new ImmString(___nl__16.toString() + ___nl__17.toString());
//line 397
___nl__17 = null;
//line 397
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__16);
___nl__0 = ___ref______nl__0.getValue();

//line 397
___nl__16 = null;
//line 398
if (true) {goto label_20;}
//line 398
label_22:
//line 399
___nl__16 = new ImmString("&_tab[");
//line 399
___nl__16 = new ImmString(___nl__16.toString() + ___nl__11.toString());
//line 399
___nl__17 = new ImmString("]");
//line 399
___nl__16 = new ImmString(___nl__16.toString() + ___nl__17.toString());
//line 399
___nl__17 = null;
//line 399
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__16);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__11 = new ImmDouble((Double.Parse(___nl__11.getValue().ToString()))+(Double.Parse(___nl__12.getValue().ToString())));
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
___nl__11 = new ImmString(");}");
//line 402
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__11);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__8 = generator_c_NL.NL_is_singleton_use_function_priv(___nl__3);

//line 404
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8));
//line 404
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_24;}}
//line 405
___nl__10 = ((ImmHash)___nl__0).getHashValue()["mod_name"];
//line 405
___nl__9 = generator_c_NL.NL_get_function_name_priv(___nl__3,___nl__10);

//line 405
___nl__10 = null;
//line 406
___nl__10 = generator_c_NL.NL_arg_t_priv();

//line 406
___nl__10 = new ImmString(___nl__10.toString() + ___nl__9.toString());
//line 406
___nl__11 = new ImmString("(){");
//line 406
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString());
//line 406
___nl__11 = null;
//line 406
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__10);
___nl__0 = ___ref______nl__0.getValue();

//line 406
___nl__10 = null;
//line 407
___nl__11 = new ImmString("");
//line 407
___nl__12 = new ImmString("__const__init");
//line 407
___nl__13 = ((ImmHash)___nl__0).getHashValue()["mod_name"];
//line 407
___nl__10 = generator_c_NL.NL_get_fun_name_priv(___nl__11,___nl__12,___nl__13);

//line 407
___nl__13 = null;
//line 407
___nl__12 = null;
//line 407
___nl__11 = null;
//line 407
___nl__11 = new ImmString("();");
//line 407
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString());
//line 407
___nl__11 = null;
//line 407
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__10);
___nl__0 = ___ref______nl__0.getValue();

//line 407
___nl__10 = null;
//line 408
___nl__10 = new ImmString("return ");
//line 408
___ref______nl__0 = new ImmRef(___nl__0);
___nl__11 = generator_c_NL.NL_get_const_singleton_priv(___ref______nl__0,___nl__9);
___nl__0 = ___ref______nl__0.getValue();

//line 408
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString());
//line 408
___nl__11 = null;
//line 408
___nl__11 = new ImmString(";}");
//line 408
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString());
//line 408
___nl__11 = null;
//line 408
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__10);
___nl__0 = ___ref______nl__0.getValue();

//line 408
___nl__10 = null;
//line 409
___nl__10 = generator_c_NL.NL_arg_t_priv();

//line 409
___nl__10 = new ImmString(___nl__10.toString() + ___nl__9.toString());
//line 409
___nl__11 = new ImmString("0cal()");
//line 409
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString());
//line 409
___nl__11 = null;
//line 409
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__10);
___nl__0 = ___ref______nl__0.getValue();

//line 409
___nl__10 = null;
//line 409
___nl__9 = null;
//line 410
if (true) {goto label_23;}
//line 410
label_24:
//line 411
___nl__10 = ((ImmHash)___nl__0).getHashValue()["mod_name"];
//line 411
___nl__9 = generator_c_NL.NL_get_function_header_priv(___nl__3,___nl__10);

//line 411
___nl__10 = null;
//line 411
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__9);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__0 = ___ref______nl__0.getValue();

//line 414
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString())));
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
___nl__0 = ___ref______nl__0.getValue();

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
___nl__1 = ((ImmHash)___nl__0).getHashValue()["const"];
//line 418
___nl__1 = ((ImmHash)___nl__1).getHashValue()["sim"];
//line 418
___nl__1 = ((ImmHash)___nl__1).getHashValue()["arr"];
//line 419
___nl__2 = ((ImmHash)___nl__0).getHashValue()["const"];
//line 419
___nl__2 = ((ImmHash)___nl__2).getHashValue()["singleton"];
//line 419
___nl__2 = ((ImmHash)___nl__2).getHashValue()["arr"];
//line 420
___nl__3 = array_NL.NL_len(___nl__1);

//line 421
___nl__4 = array_NL.NL_len(___nl__2);

//line 422
___nl__5 = ((ImmHash)___nl__0).getHashValue()["const"];
//line 422
___nl__5 = ((ImmHash)___nl__5).getHashValue()["dynamic_nr"];
//line 423
___nl__6 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString())));
//line 423
___nl__6 = new ImmDouble((Double.Parse(___nl__6.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString())));
//line 424
___nl__7 = new ImmString("\nstatic ");
//line 424
___nl__8 = generator_c_NL.NL_arg_t_priv();

//line 424
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 424
___nl__8 = null;
//line 424
___nl__8 = new ImmString("___const__[");
//line 424
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 424
___nl__8 = null;
//line 424
___nl__8 = new ImmDouble(1);
//line 424
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString())));
//line 424
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 424
___nl__8 = null;
//line 424
___nl__8 = new ImmString("];\nstatic int ___const_init__ = 1;");
//line 424
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 424
___nl__8 = null;
//line 424
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 424
___nl__7 = null;
//line 427
___nl__7 = new ImmString("void ");
//line 427
___nl__9 = new ImmString("");
//line 427
___nl__10 = new ImmString("__const__init");
//line 427
___nl__11 = ((ImmHash)___nl__0).getHashValue()["mod_name"];
//line 427
___nl__8 = generator_c_NL.NL_get_fun_name_priv(___nl__9,___nl__10,___nl__11);

//line 427
___nl__11 = null;
//line 427
___nl__10 = null;
//line 427
___nl__9 = null;
//line 427
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 427
___nl__8 = null;
//line 427
___nl__8 = new ImmString("(){\nif(___const_init__) {\n___const_init__ = 0;\n__const__f = &___const__[");
//line 427
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 427
___nl__8 = null;
//line 427
___nl__8 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString())));
//line 427
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 427
___nl__8 = null;
//line 427
___nl__8 = new ImmString("];\n");
//line 427
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 427
___nl__8 = null;
//line 427
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 427
___nl__7 = null;
//line 432
___nl__7 = new ImmDouble(0);
//line 432
___nl__8 = new ImmDouble(1);
//line 432
label_3:
//line 432
___nl__9 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))>=(Double.Parse(___nl__3.getValue().ToString())) );
//line 432
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_1;}}
//line 433
___nl__10 = new ImmString("___const__[");
//line 433
___nl__10 = new ImmString(___nl__10.toString() + ___nl__7.toString());
//line 433
___nl__11 = new ImmString("] = ");
//line 433
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString());
//line 433
___nl__11 = null;
//line 433
___nl__12 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 433
___nl__11 = generator_c_NL.NL_create_sim_priv(___nl__12);

//line 433
___nl__12 = null;
//line 433
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString());
//line 433
___nl__11 = null;
//line 433
___nl__11 = new ImmString(";");
//line 433
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString());
//line 433
___nl__11 = null;
//line 433
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__10);
___nl__0 = ___ref______nl__0.getValue();

//line 433
___nl__10 = null;
//line 434
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString())));
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
___nl__7 = new ImmString("\nfor(int i=");
//line 435
___nl__7 = new ImmString(___nl__7.toString() + ___nl__3.toString());
//line 435
___nl__8 = new ImmString(";i<");
//line 435
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 435
___nl__8 = null;
//line 435
___nl__7 = new ImmString(___nl__7.toString() + ___nl__6.toString());
//line 435
___nl__8 = new ImmString(";++i) ___const__[i] = NULL;\n");
//line 435
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 435
___nl__8 = null;
//line 435
___nl__9 = new ImmString("register_const");
//line 435
___nl__8 = generator_c_NL.NL_get_lib_fun_priv(___nl__9);

//line 435
___nl__9 = null;
//line 435
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 435
___nl__8 = null;
//line 435
___nl__8 = new ImmString("(___const__, ");
//line 435
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 435
___nl__8 = null;
//line 435
___nl__7 = new ImmString(___nl__7.toString() + ___nl__6.toString());
//line 435
___nl__8 = new ImmString(");\n}}");
//line 435
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 435
___nl__8 = null;
//line 435
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 435
___nl__7 = null;
//line 439
___nl__7 = generator_c_NL.NL_arg_t_priv();

//line 439
___nl__9 = new ImmString("");
//line 439
___nl__10 = new ImmString("__const__sim");
//line 439
___nl__11 = ((ImmHash)___nl__0).getHashValue()["mod_name"];
//line 439
___nl__8 = generator_c_NL.NL_get_fun_name_priv(___nl__9,___nl__10,___nl__11);

//line 439
___nl__11 = null;
//line 439
___nl__10 = null;
//line 439
___nl__9 = null;
//line 439
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 439
___nl__8 = null;
//line 439
___nl__8 = new ImmString("(int __nr) {\n");
//line 439
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 439
___nl__8 = null;
//line 439
___nl__8 = generator_c_NL.NL_arg_t_priv();

//line 439
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 439
___nl__8 = null;
//line 439
___nl__8 = new ImmString("ret = NULL;\n");
//line 439
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 439
___nl__8 = null;
//line 439
___nl__9 = new ImmString("copy");
//line 439
___nl__11 = new ImmString("&ret");
//line 439
___nl__12 = new ImmString("___const__[__nr]");
//line 439
___nl__10 = new ImmArray(new Imm[] {___nl__11,___nl__12,});
//line 439
___nl__11 = null;
//line 439
___nl__12 = null;
//line 439
___nl__8 = generator_c_NL.NL_get_fun_lib_priv(___nl__9,___nl__10);

//line 439
___nl__10 = null;
//line 439
___nl__9 = null;
//line 439
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 439
___nl__8 = null;
//line 439
___nl__8 = new ImmString(";\nreturn ret;\n}");
//line 439
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 439
___nl__8 = null;
//line 439
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 439
___nl__7 = null;
//line 444
___nl__7 = generator_c_NL.NL_arg_t_priv();

//line 444
___nl__9 = new ImmString("");
//line 444
___nl__10 = new ImmString("__const__sing");
//line 444
___nl__11 = ((ImmHash)___nl__0).getHashValue()["mod_name"];
//line 444
___nl__8 = generator_c_NL.NL_get_fun_name_priv(___nl__9,___nl__10,___nl__11);

//line 444
___nl__11 = null;
//line 444
___nl__10 = null;
//line 444
___nl__9 = null;
//line 444
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 444
___nl__8 = null;
//line 444
___nl__8 = new ImmString("(int __nr) {\nif(___const__[__nr+");
//line 444
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 444
___nl__8 = null;
//line 444
___nl__7 = new ImmString(___nl__7.toString() + ___nl__3.toString());
//line 444
___nl__8 = new ImmString("]==NULL) {\nswitch(__nr){");
//line 444
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 444
___nl__8 = null;
//line 444
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 444
___nl__7 = null;
//line 447
___nl__7 = array_NL.NL_len(___nl__2);

//line 447
___nl__8 = new ImmDouble(0);
//line 447
___nl__9 = new ImmDouble(1);
//line 447
label_6:
//line 447
___nl__10 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) );
//line 447
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_4;}}
//line 448
___nl__11 = new ImmString("case ");
//line 448
___nl__11 = new ImmString(___nl__11.toString() + ___nl__8.toString());
//line 448
___nl__12 = new ImmString(":");
//line 448
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString());
//line 448
___nl__12 = null;
//line 448
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__11);
___nl__0 = ___ref______nl__0.getValue();

//line 448
___nl__11 = null;
//line 449
___nl__11 = new ImmString("	___const__[");
//line 449
___nl__12 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))+(Double.Parse(___nl__3.getValue().ToString())));
//line 449
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString());
//line 449
___nl__12 = null;
//line 449
___nl__12 = new ImmString("] = ");
//line 449
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString());
//line 449
___nl__12 = null;
//line 449
___nl__12 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 449
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString());
//line 449
___nl__12 = null;
//line 449
___nl__12 = new ImmString("0cal();");
//line 449
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString());
//line 449
___nl__12 = null;
//line 449
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__11);
___nl__0 = ___ref______nl__0.getValue();

//line 449
___nl__11 = null;
//line 450
___nl__11 = new ImmString("	break;");
//line 450
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__11);
___nl__0 = ___ref______nl__0.getValue();

//line 450
___nl__11 = null;
//line 451
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))+(Double.Parse(___nl__9.getValue().ToString())));
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
___nl__7 = new ImmString("default:\n	nl_die();\n}}\n");
//line 452
___nl__8 = generator_c_NL.NL_arg_t_priv();

//line 452
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 452
___nl__8 = null;
//line 452
___nl__8 = new ImmString("ret = NULL;\n");
//line 452
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 452
___nl__8 = null;
//line 452
___nl__9 = new ImmString("copy");
//line 452
___nl__11 = new ImmString("&ret");
//line 452
___nl__12 = new ImmString("___const__[__nr+");
//line 452
___nl__12 = new ImmString(___nl__12.toString() + ___nl__3.toString());
//line 452
___nl__13 = new ImmString("]");
//line 452
___nl__12 = new ImmString(___nl__12.toString() + ___nl__13.toString());
//line 452
___nl__13 = null;
//line 452
___nl__10 = new ImmArray(new Imm[] {___nl__11,___nl__12,});
//line 452
___nl__11 = null;
//line 452
___nl__12 = null;
//line 452
___nl__8 = generator_c_NL.NL_get_fun_lib_priv(___nl__9,___nl__10);

//line 452
___nl__10 = null;
//line 452
___nl__9 = null;
//line 452
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 452
___nl__8 = null;
//line 452
___nl__8 = new ImmString(";\nreturn ret;\n}");
//line 452
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 452
___nl__8 = null;
//line 452
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__2 = new ImmString(" {");
//line 461
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 461
___nl__2 = null;
//line 462
___nl__2 = ((ImmHash)___nl__1).getHashValue()["args_type"];
//line 462
___nl__3 = ___nl__2;
//line 462
((ImmHash)___nl__0).set("fun_args", ___nl__3);
//line 462
___nl__2 = null;
//line 462
___nl__3 = null;
//line 463
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_move_args_to_register_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 464
___nl__3 = new ImmString("");
//line 464
___nl__4 = new ImmString("__const__init");
//line 464
___nl__5 = ((ImmHash)___nl__0).getHashValue()["mod_name"];
//line 464
___nl__2 = generator_c_NL.NL_get_fun_name_priv(___nl__3,___nl__4,___nl__5);

//line 464
___nl__5 = null;
//line 464
___nl__4 = null;
//line 464
___nl__3 = null;
//line 464
___nl__3 = new ImmString("();");
//line 464
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 464
___nl__3 = null;
//line 464
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 464
___nl__2 = null;
//line 465
___nl__3 = ((ImmHash)___nl__1).getHashValue()["args_type"];
//line 465
___nl__2 = array_NL.NL_len(___nl__3);

//line 465
___nl__3 = null;
//line 465
label_2:
//line 465
___nl__3 = ((ImmHash)___nl__1).getHashValue()["reg_size"];
//line 465
___nl__3 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__2.getValue().ToString()))<(Double.Parse(___nl__3.getValue().ToString())) );
//line 465
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 465
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_1;}}
//line 466
___nl__4 = generator_c_NL.NL_arg_t_priv();

//line 466
___ref______nl__0 = new ImmRef(___nl__0);
___nl__5 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 466
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 466
___nl__5 = null;
//line 466
___nl__5 = new ImmString(" = NULL;");
//line 466
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 466
___nl__5 = null;
//line 466
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 466
___nl__4 = null;
//line 466
___nl__4 = new ImmDouble(1);
//line 466
___nl__2 = new ImmDouble((Double.Parse(___nl__2.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString())));
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
___nl__2 = ((ImmHash)___nl__1).getHashValue()["commands"];
//line 468
___nl__4 = new ImmDouble(0);
//line 468
___nl__5 = new ImmDouble(1);
//line 468
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__2);

//line 468
label_6:
//line 468
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) );
//line 468
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_4;}}
//line 468
___nl__3 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()];
//line 469
___nl__8 = ((ImmHash)___nl__3).getHashValue()["annotation"];
//line 469
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("none"));
//line 469
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_8;}}
//line 471
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("const"));
//line 471
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_9;}}
//line 471
___nl__9 = new ImmString("NOMATCHALERT");
//line 471
___nl__9 = new ImmArray(new Imm[] {___nl__9,___nl__8,});
//line 471
c_rt_lib_NL.NL_die();
//line 469
label_8:
//line 470
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_cmd_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 471
if (true) {goto label_7;}
//line 471
label_9:
//line 471
___nl__10 = c_rt_lib_NL.NL_ov_as(___nl__8, new ImmString("const"));
//line 472
___nl__11 = ((ImmHash)___nl__3).getHashValue()["cmd"];
//line 472
___nl__11 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("load_const"));
//line 472
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11));
//line 472
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_11;}}
//line 473
___nl__12 = ((ImmHash)___nl__3).getHashValue()["cmd"];
//line 473
___nl__12 = c_rt_lib_NL.NL_ov_as(___nl__12, new ImmString("load_const"));
//line 473
___nl__12 = ((ImmHash)___nl__12).getHashValue()["val"];
//line 474
___nl__13 = nl_NL.NL_is_sim(___nl__12);

//line 474
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13));
//line 474
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_13;}}
//line 475
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_cmd_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__11 = array_NL.NL_len(___nl__10);

//line 480
___nl__12 = new ImmDouble(0);
//line 480
___nl__12 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__11.getValue().ToString())) ==((Double.Parse(___nl__12.getValue().ToString())))  );
//line 480
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12));
//line 480
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_15;}}
//line 481
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_cmd_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__13 = ((ImmHash)___nl__0).getHashValue()["const"];
//line 484
___nl__13 = ((ImmHash)___nl__13).getHashValue()["dynamic_nr"];
//line 485
___nl__14 = new ImmString("if(__const__f[");
//line 485
___nl__14 = new ImmString(___nl__14.toString() + ___nl__13.toString());
//line 485
___nl__15 = new ImmString("] == NULL) {");
//line 485
___nl__14 = new ImmString(___nl__14.toString() + ___nl__15.toString());
//line 485
___nl__15 = null;
//line 485
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__14);
___nl__0 = ___ref______nl__0.getValue();

//line 485
___nl__14 = null;
//line 486
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_cmd_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 487
___nl__15 = new ImmDouble(0);
//line 487
___nl__16 = new ImmDouble(1);
//line 487
___nl__17 = c_rt_lib_NL.NL_array_len(___nl__10);

//line 487
label_18:
//line 487
___nl__18 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__15.getValue().ToString()))>=(Double.Parse(___nl__17.getValue().ToString())) );
//line 487
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_16;}}
//line 487
___nl__14 = (___nl__10 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__15).getDoubleValue()];
//line 488
___nl__20 = new ImmString("copy");
//line 488
___nl__22 = new ImmString("&__const__f[");
//line 488
___nl__22 = new ImmString(___nl__22.toString() + ___nl__13.toString());
//line 488
___nl__23 = new ImmString("]");
//line 488
___nl__22 = new ImmString(___nl__22.toString() + ___nl__23.toString());
//line 488
___nl__23 = null;
//line 488
___ref______nl__0 = new ImmRef(___nl__0);
___nl__23 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__14);
___nl__0 = ___ref______nl__0.getValue();

//line 488
___nl__21 = new ImmArray(new Imm[] {___nl__22,___nl__23,});
//line 488
___nl__22 = null;
//line 488
___nl__23 = null;
//line 488
___nl__19 = generator_c_NL.NL_get_fun_lib_priv(___nl__20,___nl__21);

//line 488
___nl__21 = null;
//line 488
___nl__20 = null;
//line 488
___nl__20 = new ImmString(";");
//line 488
___nl__19 = new ImmString(___nl__19.toString() + ___nl__20.toString());
//line 488
___nl__20 = null;
//line 488
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__19);
___nl__0 = ___ref______nl__0.getValue();

//line 488
___nl__19 = null;
//line 489
___nl__19 = new ImmDouble(1);
//line 489
___nl__13 = new ImmDouble((Double.Parse(___nl__13.getValue().ToString()))+(Double.Parse(___nl__19.getValue().ToString())));
//line 489
___nl__19 = null;
//line 490
___nl__15 = new ImmDouble((Double.Parse(___nl__15.getValue().ToString()))+(Double.Parse(___nl__16.getValue().ToString())));
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
___nl__14 = new ImmString("}");
//line 491
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__14);
___nl__0 = ___ref______nl__0.getValue();

//line 491
___nl__14 = null;
//line 492
___nl__13 = new ImmDouble((Double.Parse(___nl__13.getValue().ToString()))-(Double.Parse(___nl__11.getValue().ToString())));
//line 493
___nl__15 = new ImmDouble(0);
//line 493
___nl__16 = new ImmDouble(1);
//line 493
___nl__17 = c_rt_lib_NL.NL_array_len(___nl__10);

//line 493
label_21:
//line 493
___nl__18 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__15.getValue().ToString()))>=(Double.Parse(___nl__17.getValue().ToString())) );
//line 493
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_19;}}
//line 493
___nl__14 = (___nl__10 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__15).getDoubleValue()];
//line 494
___nl__20 = new ImmString("copy");
//line 494
___ref______nl__0 = new ImmRef(___nl__0);
___nl__22 = generator_c_NL.NL_get_reg_ref_priv(___ref______nl__0,___nl__14);
___nl__0 = ___ref______nl__0.getValue();

//line 494
___nl__23 = new ImmString("__const__f[");
//line 494
___nl__23 = new ImmString(___nl__23.toString() + ___nl__13.toString());
//line 494
___nl__24 = new ImmString("]");
//line 494
___nl__23 = new ImmString(___nl__23.toString() + ___nl__24.toString());
//line 494
___nl__24 = null;
//line 494
___nl__21 = new ImmArray(new Imm[] {___nl__22,___nl__23,});
//line 494
___nl__22 = null;
//line 494
___nl__23 = null;
//line 494
___nl__19 = generator_c_NL.NL_get_fun_lib_priv(___nl__20,___nl__21);

//line 494
___nl__21 = null;
//line 494
___nl__20 = null;
//line 494
___nl__20 = new ImmString(";");
//line 494
___nl__19 = new ImmString(___nl__19.toString() + ___nl__20.toString());
//line 494
___nl__20 = null;
//line 494
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__19);
___nl__0 = ___ref______nl__0.getValue();

//line 494
___nl__19 = null;
//line 495
___nl__19 = new ImmDouble(1);
//line 495
___nl__13 = new ImmDouble((Double.Parse(___nl__13.getValue().ToString()))+(Double.Parse(___nl__19.getValue().ToString())));
//line 495
___nl__19 = null;
//line 496
___nl__15 = new ImmDouble((Double.Parse(___nl__15.getValue().ToString()))+(Double.Parse(___nl__16.getValue().ToString())));
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
___nl__14 = new ImmString("const");
//line 497
___nl__14 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__14);

//line 497
___nl__15 = ___nl__13;
//line 497
((ImmHash)___nl__14).set("dynamic_nr", ___nl__15);
//line 497
___nl__16 = new ImmString("const");
//line 497
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__16,___nl__14);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString())));
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
___nl__2 = new ImmString("}");
//line 501
___nl__3 = string_NL.NL_lf();

//line 501
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 501
___nl__3 = null;
//line 501
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__2 = ((ImmHash)___nl__0).getHashValue()["args_type"];
//line 504
___nl__1 = array_NL.NL_len(___nl__2);

//line 504
___nl__2 = null;
//line 504
___nl__2 = new ImmDouble(0);
//line 504
___nl__1 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__1.getValue().ToString()))>(Double.Parse(___nl__2.getValue().ToString())) );
//line 504
___nl__2 = null;
//line 504
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1));
//line 504
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_2;}}
//line 504
___nl__2 = c_rt_lib_NL.NL_get_false();
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
___nl__1 = ((ImmHash)___nl__0).getHashValue()["annotation"];
//line 505
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("math"));
//line 506
___nl__2 = c_rt_lib_NL.NL_get_false();
//line 508
___nl__4 = ((ImmHash)___nl__0).getHashValue()["commands"];
//line 508
___nl__6 = new ImmDouble(0);
//line 508
___nl__7 = new ImmDouble(1);
//line 508
___nl__8 = c_rt_lib_NL.NL_array_len(___nl__4);

//line 508
label_5:
//line 508
___nl__9 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__6.getValue().ToString()))>=(Double.Parse(___nl__8.getValue().ToString())) );
//line 508
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_3;}}
//line 508
___nl__5 = (___nl__4 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()];
//line 509
___nl__10 = ((ImmHash)___nl__5).getHashValue()["cmd"];
//line 510
___nl__11 = ___nl__10;
//line 510
___nl__11 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("call"));
//line 510
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11));
//line 510
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_7;}}
//line 511
___nl__12 = ___nl__10;
//line 511
___nl__12 = c_rt_lib_NL.NL_ov_as(___nl__12, new ImmString("call"));
//line 512
___nl__13 = ((ImmHash)___nl__12).getHashValue()["fun_name"];
//line 512
___nl__14 = new ImmString("sigleton_do_not_use_without_approval");
//line 512
___nl__13 = c_rt_lib_NL.NL_native_to_nl(___nl__13.toString().Equals(___nl__14.toString()));
//line 512
___nl__14 = null;
//line 512
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13));
//line 512
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13));
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
___nl__13 = ((ImmHash)___nl__12).getHashValue()["mod"];
//line 513
___nl__14 = new ImmString("singleton");
//line 513
___nl__13 = c_rt_lib_NL.NL_native_to_nl(___nl__13.toString().Equals(___nl__14.toString()));
//line 513
___nl__14 = null;
//line 513
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13));
//line 513
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13));
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
___nl__13 = c_rt_lib_NL.NL_get_true();
//line 514
___nl__2 = ___nl__13;
//line 514
___nl__13 = null;
//line 515
___nl__13 = ((ImmHash)___nl__12).getHashValue()["dest"];
//line 515
___nl__3 = ___nl__13;
//line 515
___nl__13 = null;
//line 515
___nl__12 = null;
//line 516
if (true) {goto label_6;}
//line 516
label_7:
//line 516
___nl__11 = ___nl__10;
//line 516
___nl__11 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("return"));
//line 516
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11));
//line 516
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_12;}}
//line 517
___nl__12 = ___nl__10;
//line 517
___nl__12 = c_rt_lib_NL.NL_ov_as(___nl__12, new ImmString("return"));
//line 518
___nl__13 = ___nl__12;
//line 518
___nl__13 = c_rt_lib_NL.NL_ov_is(___nl__13, new ImmString("val"));
//line 518
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13));
//line 518
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13));
//line 518
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_14;}}
//line 518
___nl__14 = c_rt_lib_NL.NL_get_false();
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
___nl__13 = ___nl__1;
//line 519
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13));
//line 519
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_16;}}
//line 519
___nl__14 = c_rt_lib_NL.NL_get_true();
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
___nl__13 = ___nl__2;
//line 520
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13));
//line 520
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13));
//line 520
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_18;}}
//line 520
___nl__14 = c_rt_lib_NL.NL_get_false();
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
___nl__13 = ___nl__12;
//line 521
___nl__13 = c_rt_lib_NL.NL_ov_as(___nl__13, new ImmString("val"));
//line 521
___nl__13 = c_rt_lib_NL.NL_native_to_nl(___nl__13.toString().Equals(___nl__3.toString()));
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
___nl__11 = ___nl__10;
//line 522
___nl__11 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("prt_lbl"));
//line 522
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11));
//line 522
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_19;}}
//line 523
if (true) {goto label_6;}
//line 523
label_19:
//line 523
___nl__11 = ___nl__10;
//line 523
___nl__11 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("clear"));
//line 523
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11));
//line 523
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_20;}}
//line 524
if (true) {goto label_6;}
//line 524
label_20:
//line 525
___nl__12 = ___nl__2;
//line 525
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12));
//line 525
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_22;}}
//line 525
___nl__13 = c_rt_lib_NL.NL_get_false();
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
___nl__6 = new ImmDouble((Double.Parse(___nl__6.getValue().ToString()))+(Double.Parse(___nl__7.getValue().ToString())));
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
___nl__4 = c_rt_lib_NL.NL_get_false();
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
___nl__2 = ((ImmHash)___nl__0).getHashValue()["fun_args"];
//line 532
___nl__1 = array_NL.NL_len(___nl__2);

//line 532
___nl__2 = null;
//line 532
___nl__2 = new ImmDouble(0);
//line 532
___nl__3 = new ImmDouble(1);
//line 532
label_3:
//line 532
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__2.getValue().ToString()))>=(Double.Parse(___nl__1.getValue().ToString())) );
//line 532
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_1;}}
//line 533
___nl__5 = ((ImmHash)___nl__0).getHashValue()["fun_args"];
//line 533
___nl__5 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__2).getDoubleValue()];
//line 533
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("val"));
//line 533
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_5;}}
//line 536
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("ref"));
//line 536
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_6;}}
//line 536
___nl__6 = new ImmString("NOMATCHALERT");
//line 536
___nl__6 = new ImmArray(new Imm[] {___nl__6,___nl__5,});
//line 536
c_rt_lib_NL.NL_die();
//line 533
label_5:
//line 534
___nl__8 = new ImmString("arg_val");
//line 534
___ref______nl__0 = new ImmRef(___nl__0);
___nl__10 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 534
___nl__9 = new ImmArray(new Imm[] {___nl__10,});
//line 534
___nl__10 = null;
//line 534
___nl__7 = generator_c_NL.NL_get_fun_lib_priv(___nl__8,___nl__9);

//line 534
___nl__9 = null;
//line 534
___nl__8 = null;
//line 534
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 534
___nl__7 = null;
//line 535
___nl__7 = new ImmString(";");
//line 535
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_println_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__2 = new ImmDouble((Double.Parse(___nl__2.getValue().ToString()))+(Double.Parse(___nl__3.getValue().ToString())));
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
___nl__2 = ((ImmHash)___nl__0).getHashValue()["fun_args"];
//line 541
___nl__1 = array_NL.NL_len(___nl__2);

//line 541
___nl__2 = null;
//line 541
___nl__2 = new ImmDouble(0);
//line 541
___nl__3 = new ImmDouble(1);
//line 541
label_3:
//line 541
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__2.getValue().ToString()))>=(Double.Parse(___nl__1.getValue().ToString())) );
//line 541
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_1;}}
//line 542
___nl__5 = ((ImmHash)___nl__0).getHashValue()["fun_args"];
//line 542
___nl__5 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__2).getDoubleValue()];
//line 542
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("val"));
//line 542
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_5;}}
//line 543
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("ref"));
//line 543
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_6;}}
//line 543
___nl__6 = new ImmString("NOMATCHALERT");
//line 543
___nl__6 = new ImmArray(new Imm[] {___nl__6,___nl__5,});
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
___nl__2 = new ImmDouble((Double.Parse(___nl__2.getValue().ToString()))+(Double.Parse(___nl__3.getValue().ToString())));
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
___nl__2 = generator_c_NL.NL_get_lib_fun_priv(___nl__0);

//line 549
___nl__3 = new ImmString("(");
//line 549
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 549
___nl__3 = null;
//line 550
___nl__3 = new ImmDouble(0);
//line 551
___nl__5 = new ImmDouble(0);
//line 551
___nl__6 = new ImmDouble(1);
//line 551
___nl__7 = c_rt_lib_NL.NL_array_len(___nl__1);

//line 551
label_3:
//line 551
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) );
//line 551
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_1;}}
//line 551
___nl__4 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()];
//line 552
___nl__9 = new ImmDouble(0);
//line 552
___nl__9 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__9.getValue().ToString())) ==((Double.Parse(___nl__3.getValue().ToString())))  );
//line 552
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9));
//line 552
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9));
//line 552
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_5;}}
//line 552
___nl__10 = new ImmString(", ");
//line 552
___nl__2 = new ImmString(___nl__2.toString() + ___nl__10.toString());
//line 552
___nl__10 = null;
//line 552
if (true) {goto label_5;}
//line 552
label_5:
//line 552
___nl__9 = null;
//line 553
___nl__2 = new ImmString(___nl__2.toString() + ___nl__4.toString());
//line 554
___nl__9 = new ImmDouble(1);
//line 554
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__9.getValue().ToString())));
//line 554
___nl__9 = null;
//line 555
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString())));
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
___nl__4 = new ImmString(")");
//line 556
___nl__4 = new ImmString(___nl__2.toString() + ___nl__4.toString());
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
___nl__2 = new ImmDouble(0);
//line 560
___nl__3 = new ImmString("00");
//line 560
___nl__1 = string_NL.NL_replace(___nl__0,___nl__2,___nl__3);

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
___nl__3 = new ImmString("");
//line 564
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__3.toString()));
//line 564
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 564
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 564
___nl__4 = new ImmString("_priv");
//line 564
___nl__4 = new ImmString(___nl__2.toString() + ___nl__4.toString());
//line 564
___nl__0 = ___nl__4;
//line 564
___nl__4 = null;
//line 564
if (true) {goto label_2;}
//line 564
label_2:
//line 564
___nl__3 = null;
//line 565
___nl__3 = generator_c_NL.NL_get_module_name_priv(___nl__0);

//line 565
___nl__4 = new ImmDouble(0);
//line 565
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 565
___nl__4 = null;
//line 565
___nl__5 = new ImmDouble(0);
//line 565
___nl__6 = new ImmString("00");
//line 565
___nl__4 = string_NL.NL_replace(___nl__1,___nl__5,___nl__6);

//line 565
___nl__6 = null;
//line 565
___nl__5 = null;
//line 565
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
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
___nl__2 = new ImmString("c_rt_lib");
//line 570
___nl__3 = new ImmString("");
//line 570
___nl__1 = generator_c_NL.NL_get_fun_name_priv(___nl__2,___nl__0,___nl__3);

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
___nl__2 = nl_NL.NL_is_hash(___nl__1);

//line 574
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 574
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 575
___nl__4 = new ImmString("hash_mk_dec");
//line 575
___nl__3 = generator_c_NL.NL_get_lib_fun_priv(___nl__4);

//line 575
___nl__4 = null;
//line 575
___nl__4 = new ImmString("(");
//line 575
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 575
___nl__4 = null;
//line 575
___nl__4 = hash_NL.NL_size(___nl__1);

//line 575
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 575
___nl__4 = null;
//line 575
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 575
___nl__3 = null;
//line 576
___nl__5 = c_rt_lib_NL.NL_init_iter(___nl__1);

//line 576
label_5:
//line 576
___nl__3 = c_rt_lib_NL.NL_is_end_hash(___nl__5);

//line 576
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 576
___nl__3 = c_rt_lib_NL.NL_get_key_iter(___nl__5);

//line 576
___nl__4 = c_rt_lib_NL.NL_hash_get_value(___nl__1,___nl__3);

//line 577
___nl__6 = new ImmString(", ");
//line 577
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

//line 577
___nl__6 = null;
//line 578
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = generator_c_NL.NL_get_const_sim_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 578
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

//line 578
___nl__6 = null;
//line 579
___nl__6 = new ImmString(", ");
//line 579
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

//line 579
___nl__6 = null;
//line 580
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_generate_imm_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 581
___nl__5 = c_rt_lib_NL.NL_next_iter(___nl__5);

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
___nl__3 = new ImmString(")");
//line 582
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 582
___nl__3 = null;
//line 583
if (true) {goto label_1;}
//line 583
label_2:
//line 583
___nl__2 = nl_NL.NL_is_array(___nl__1);

//line 583
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 583
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_6;}}
//line 584
___nl__4 = new ImmString("array_mk_dec");
//line 584
___nl__3 = generator_c_NL.NL_get_lib_fun_priv(___nl__4);

//line 584
___nl__4 = null;
//line 584
___nl__4 = new ImmString("(");
//line 584
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 584
___nl__4 = null;
//line 584
___nl__4 = array_NL.NL_len(___nl__1);

//line 584
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 584
___nl__4 = null;
//line 584
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 584
___nl__3 = null;
//line 585
___nl__4 = new ImmDouble(0);
//line 585
___nl__5 = new ImmDouble(1);
//line 585
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__1);

//line 585
label_9:
//line 585
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) );
//line 585
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_7;}}
//line 585
___nl__3 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()];
//line 586
___nl__8 = new ImmString(", ");
//line 586
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__8);
___nl__0 = ___ref______nl__0.getValue();

//line 586
___nl__8 = null;
//line 587
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_generate_imm_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 588
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString())));
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
___nl__3 = new ImmString(")");
//line 589
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 589
___nl__3 = null;
//line 590
if (true) {goto label_1;}
//line 590
label_6:
//line 590
___nl__2 = nl_NL.NL_is_variant(___nl__1);

//line 590
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 590
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_10;}}
//line 591
___nl__5 = ptd_NL.NL_sim();

//line 591
___nl__6 = ov_NL.NL_get_element(___nl__1);

//line 591
___nl__4 = ptd_NL.NL_ensure(___nl__5,___nl__6);

//line 591
___nl__6 = null;
//line 591
___nl__5 = null;
//line 591
___ref______nl__0 = new ImmRef(___nl__0);
___nl__3 = generator_c_NL.NL_get_const_sim_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 591
___nl__4 = null;
//line 592
___nl__4 = ov_NL.NL_has_value(___nl__1);

//line 592
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 592
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_12;}}
//line 593
___nl__6 = new ImmString("ov_mk_arg_dec");
//line 593
___nl__5 = generator_c_NL.NL_get_lib_fun_priv(___nl__6);

//line 593
___nl__6 = null;
//line 593
___nl__6 = new ImmString("(");
//line 593
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 593
___nl__6 = null;
//line 593
___nl__5 = new ImmString(___nl__5.toString() + ___nl__3.toString());
//line 593
___nl__6 = new ImmString(", ");
//line 593
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 593
___nl__6 = null;
//line 593
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 593
___nl__5 = null;
//line 594
___nl__5 = ov_NL.NL_get_value(___nl__1);

//line 594
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_generate_imm_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 594
___nl__5 = null;
//line 595
___nl__5 = new ImmString(")");
//line 595
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 595
___nl__5 = null;
//line 596
if (true) {goto label_11;}
//line 596
label_12:
//line 597
___nl__6 = new ImmString("ov_mk_none");
//line 597
___nl__5 = generator_c_NL.NL_get_lib_fun_priv(___nl__6);

//line 597
___nl__6 = null;
//line 597
___nl__6 = new ImmString("(");
//line 597
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 597
___nl__6 = null;
//line 597
___nl__5 = new ImmString(___nl__5.toString() + ___nl__3.toString());
//line 597
___nl__6 = new ImmString(")");
//line 597
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 597
___nl__6 = null;
//line 597
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__2 = nl_NL.NL_is_sim(___nl__1);

//line 599
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 599
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_13;}}
//line 600
___nl__5 = ptd_NL.NL_sim();

//line 600
___nl__4 = ptd_NL.NL_ensure(___nl__5,___nl__1);

//line 600
___nl__5 = null;
//line 600
___ref______nl__0 = new ImmRef(___nl__0);
___nl__3 = generator_c_NL.NL_get_const_sim_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 600
___nl__4 = null;
//line 600
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 600
___nl__3 = null;
//line 601
if (true) {goto label_1;}
//line 601
label_13:
//line 602
___nl__3 = new ImmArray(new Imm[0]);
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
___nl__2 = new ImmString("#line ");
//line 607
___nl__3 = ((ImmHash)___nl__1).getHashValue()["debug"];
//line 607
___nl__3 = ((ImmHash)___nl__3).getHashValue()["nast_debug"];
//line 607
___nl__3 = ((ImmHash)___nl__3).getHashValue()["begin"];
//line 607
___nl__3 = ((ImmHash)___nl__3).getHashValue()["line"];
//line 607
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 607
___nl__3 = null;
//line 607
___nl__3 = string_NL.NL_lf();

//line 607
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 607
___nl__3 = null;
//line 607
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 607
___nl__2 = null;
//line 608
___nl__2 = ((ImmHash)___nl__1).getHashValue()["cmd"];
//line 608
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("arr_decl"));
//line 608
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 613
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("hash_decl"));
//line 613
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 621
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("func"));
//line 621
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_4;}}
//line 628
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("call"));
//line 628
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_5;}}
//line 630
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("una_op"));
//line 630
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_6;}}
//line 634
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("bin_op"));
//line 634
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_7;}}
//line 641
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("ov_is"));
//line 641
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_8;}}
//line 644
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("ov_as"));
//line 644
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_9;}}
//line 647
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("return"));
//line 647
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_10;}}
//line 655
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("die"));
//line 655
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_11;}}
//line 657
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("move"));
//line 657
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_12;}}
//line 661
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("load_const"));
//line 661
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_13;}}
//line 666
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("get_frm_idx"));
//line 666
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_14;}}
//line 669
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("set_at_idx"));
//line 669
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_15;}}
//line 672
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("get_val"));
//line 672
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_16;}}
//line 676
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("set_val"));
//line 676
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_17;}}
//line 679
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("ov_mk"));
//line 679
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_18;}}
//line 693
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("prt_lbl"));
//line 693
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_19;}}
//line 696
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("if_goto"));
//line 696
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_20;}}
//line 701
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("goto"));
//line 701
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_21;}}
//line 703
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("clear"));
//line 703
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_22;}}
//line 703
___nl__3 = new ImmString("NOMATCHALERT");
//line 703
___nl__3 = new ImmArray(new Imm[] {___nl__3,___nl__2,});
//line 703
c_rt_lib_NL.NL_die();
//line 608
label_2:
//line 608
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("arr_decl"));
//line 609
___nl__7 = ((ImmHash)___nl__4).getHashValue()["src"];
//line 609
___nl__6 = array_NL.NL_len(___nl__7);

//line 609
___nl__7 = null;
//line 609
___nl__5 = new ImmArray(new Imm[] {___nl__6,});
//line 609
___nl__6 = null;
//line 610
___nl__6 = ((ImmHash)___nl__4).getHashValue()["src"];
//line 610
___nl__8 = new ImmDouble(0);
//line 610
___nl__9 = new ImmDouble(1);
//line 610
___nl__10 = c_rt_lib_NL.NL_array_len(___nl__6);

//line 610
label_25:
//line 610
___nl__11 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString()))>=(Double.Parse(___nl__10.getValue().ToString())) );
//line 610
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_23;}}
//line 610
___nl__7 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 610
___ref______nl__0 = new ImmRef(___nl__0);
___nl__12 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 610
___ref______nl__5 = new ImmRef(___nl__5);
array_NL.NL_push(___ref______nl__5,___nl__12);
___nl__5 = ___ref______nl__5.getValue();

//line 610
___nl__12 = null;
//line 610
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))+(Double.Parse(___nl__9.getValue().ToString())));
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
___nl__7 = new ImmString("array_mk");
//line 611
___nl__6 = generator_c_NL.NL_get_fun_lib_priv(___nl__7,___nl__5);

//line 611
___nl__7 = null;
//line 612
___nl__8 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 612
___ref______nl__0 = new ImmRef(___nl__0);
___nl__7 = generator_c_NL.NL_get_assign_priv(___ref______nl__0,___nl__8,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

//line 612
___nl__8 = null;
//line 612
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("hash_decl"));
//line 614
___nl__7 = ((ImmHash)___nl__4).getHashValue()["src"];
//line 614
___nl__6 = array_NL.NL_len(___nl__7);

//line 614
___nl__7 = null;
//line 614
___nl__5 = new ImmArray(new Imm[] {___nl__6,});
//line 614
___nl__6 = null;
//line 615
___nl__6 = ((ImmHash)___nl__4).getHashValue()["src"];
//line 615
___nl__8 = new ImmDouble(0);
//line 615
___nl__9 = new ImmDouble(1);
//line 615
___nl__10 = c_rt_lib_NL.NL_array_len(___nl__6);

//line 615
label_28:
//line 615
___nl__11 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString()))>=(Double.Parse(___nl__10.getValue().ToString())) );
//line 615
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_26;}}
//line 615
___nl__7 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 616
___nl__13 = ((ImmHash)___nl__7).getHashValue()["key"];
//line 616
___ref______nl__0 = new ImmRef(___nl__0);
___nl__12 = generator_c_NL.NL_get_const_sim_priv(___ref______nl__0,___nl__13);
___nl__0 = ___ref______nl__0.getValue();

//line 616
___nl__13 = null;
//line 616
___ref______nl__5 = new ImmRef(___nl__5);
array_NL.NL_push(___ref______nl__5,___nl__12);
___nl__5 = ___ref______nl__5.getValue();

//line 616
___nl__12 = null;
//line 617
___nl__13 = ((ImmHash)___nl__7).getHashValue()["val"];
//line 617
___ref______nl__0 = new ImmRef(___nl__0);
___nl__12 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__13);
___nl__0 = ___ref______nl__0.getValue();

//line 617
___nl__13 = null;
//line 617
___ref______nl__5 = new ImmRef(___nl__5);
array_NL.NL_push(___ref______nl__5,___nl__12);
___nl__5 = ___ref______nl__5.getValue();

//line 617
___nl__12 = null;
//line 618
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))+(Double.Parse(___nl__9.getValue().ToString())));
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
___nl__7 = new ImmString("hash_mk");
//line 619
___nl__6 = generator_c_NL.NL_get_fun_lib_priv(___nl__7,___nl__5);

//line 619
___nl__7 = null;
//line 620
___nl__8 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 620
___ref______nl__0 = new ImmRef(___nl__0);
___nl__7 = generator_c_NL.NL_get_assign_priv(___ref______nl__0,___nl__8,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

//line 620
___nl__8 = null;
//line 620
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("func"));
//line 622
___nl__6 = new ImmString("func_new");
//line 622
___nl__9 = ((ImmHash)___nl__4).getHashValue()["module"];
//line 622
___nl__10 = ((ImmHash)___nl__4).getHashValue()["name"];
//line 622
___nl__11 = ((ImmHash)___nl__0).getHashValue()["mod_name"];
//line 622
___nl__8 = generator_c_NL.NL_get_fun_name_priv(___nl__9,___nl__10,___nl__11);

//line 622
___nl__11 = null;
//line 622
___nl__10 = null;
//line 622
___nl__9 = null;
//line 622
___nl__9 = new ImmString("0ptr");
//line 622
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 622
___nl__9 = null;
//line 622
___nl__10 = ((ImmHash)___nl__4).getHashValue()["module"];
//line 622
___ref______nl__0 = new ImmRef(___nl__0);
___nl__9 = generator_c_NL.NL_get_const_sim_priv(___ref______nl__0,___nl__10);
___nl__0 = ___ref______nl__0.getValue();

//line 622
___nl__10 = null;
//line 622
___nl__11 = ((ImmHash)___nl__4).getHashValue()["name"];
//line 622
___ref______nl__0 = new ImmRef(___nl__0);
___nl__10 = generator_c_NL.NL_get_const_sim_priv(___ref______nl__0,___nl__11);
___nl__0 = ___ref______nl__0.getValue();

//line 622
___nl__11 = null;
//line 622
___nl__7 = new ImmArray(new Imm[] {___nl__8,___nl__9,___nl__10,});
//line 622
___nl__8 = null;
//line 622
___nl__9 = null;
//line 622
___nl__10 = null;
//line 622
___nl__5 = generator_c_NL.NL_get_fun_lib_priv(___nl__6,___nl__7);

//line 622
___nl__7 = null;
//line 622
___nl__6 = null;
//line 627
___nl__7 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 627
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = generator_c_NL.NL_get_assign_priv(___ref______nl__0,___nl__7,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 627
___nl__7 = null;
//line 627
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("call"));
//line 629
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_generate_call_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 629
___nl__4 = null;
//line 630
if (true) {goto label_1;}
//line 630
label_6:
//line 630
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("una_op"));
//line 631
___nl__6 = generator_c_NL.NL_get_unary_ops_priv();

//line 631
___nl__7 = ((ImmHash)___nl__4).getHashValue()["op"];
//line 631
___nl__5 = hash_NL.NL_get_value(___nl__6,___nl__7);

//line 631
___nl__7 = null;
//line 631
___nl__6 = null;
//line 632
___nl__9 = ((ImmHash)___nl__4).getHashValue()["src"];
//line 632
___ref______nl__0 = new ImmRef(___nl__0);
___nl__8 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__9);
___nl__0 = ___ref______nl__0.getValue();

//line 632
___nl__9 = null;
//line 632
___nl__7 = new ImmArray(new Imm[] {___nl__8,});
//line 632
___nl__8 = null;
//line 632
___nl__6 = generator_c_NL.NL_get_fun_lib_priv(___nl__5,___nl__7);

//line 632
___nl__7 = null;
//line 633
___nl__8 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 633
___ref______nl__0 = new ImmRef(___nl__0);
___nl__7 = generator_c_NL.NL_get_assign_priv(___ref______nl__0,___nl__8,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

//line 633
___nl__8 = null;
//line 633
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("bin_op"));
//line 635
___nl__6 = generator_c_NL.NL_get_bin_ops_priv();

//line 635
___nl__7 = ((ImmHash)___nl__4).getHashValue()["op"];
//line 635
___nl__5 = hash_NL.NL_get_value(___nl__6,___nl__7);

//line 635
___nl__7 = null;
//line 635
___nl__6 = null;
//line 636
___nl__6 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 636
___nl__8 = ((ImmHash)___nl__4).getHashValue()["left"];
//line 636
___nl__6 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__8.toString()));
//line 636
___nl__8 = null;
//line 636
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 636
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_31;}}
//line 636
___nl__8 = generator_c_NL.NL_get_bin_ops_mod_priv();

//line 636
___nl__9 = ((ImmHash)___nl__4).getHashValue()["op"];
//line 636
___nl__6 = hash_NL.NL_has_key(___nl__8,___nl__9);

//line 636
___nl__9 = null;
//line 636
___nl__8 = null;
//line 636
label_31:
//line 636
___nl__7 = null;
//line 636
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 636
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_30;}}
//line 637
___nl__8 = generator_c_NL.NL_get_bin_ops_mod_priv();

//line 637
___nl__9 = ((ImmHash)___nl__4).getHashValue()["op"];
//line 637
___nl__7 = hash_NL.NL_get_value(___nl__8,___nl__9);

//line 637
___nl__9 = null;
//line 637
___nl__8 = null;
//line 637
___nl__5 = ___nl__7;
//line 637
___nl__7 = null;
//line 638
if (true) {goto label_30;}
//line 638
label_30:
//line 638
___nl__6 = null;
//line 639
___nl__9 = ((ImmHash)___nl__4).getHashValue()["left"];
//line 639
___ref______nl__0 = new ImmRef(___nl__0);
___nl__8 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__9);
___nl__0 = ___ref______nl__0.getValue();

//line 639
___nl__9 = null;
//line 639
___nl__10 = ((ImmHash)___nl__4).getHashValue()["right"];
//line 639
___ref______nl__0 = new ImmRef(___nl__0);
___nl__9 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__10);
___nl__0 = ___ref______nl__0.getValue();

//line 639
___nl__10 = null;
//line 639
___nl__7 = new ImmArray(new Imm[] {___nl__8,___nl__9,});
//line 639
___nl__8 = null;
//line 639
___nl__9 = null;
//line 639
___nl__6 = generator_c_NL.NL_get_fun_lib_priv(___nl__5,___nl__7);

//line 639
___nl__7 = null;
//line 640
___nl__8 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 640
___ref______nl__0 = new ImmRef(___nl__0);
___nl__7 = generator_c_NL.NL_get_assign_priv(___ref______nl__0,___nl__8,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

//line 640
___nl__8 = null;
//line 640
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("ov_is"));
//line 642
___nl__6 = new ImmString("priv_is");
//line 642
___nl__9 = ((ImmHash)___nl__4).getHashValue()["src"];
//line 642
___ref______nl__0 = new ImmRef(___nl__0);
___nl__8 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__9);
___nl__0 = ___ref______nl__0.getValue();

//line 642
___nl__9 = null;
//line 642
___nl__10 = ((ImmHash)___nl__4).getHashValue()["type"];
//line 642
___ref______nl__0 = new ImmRef(___nl__0);
___nl__9 = generator_c_NL.NL_get_const_sim_priv(___ref______nl__0,___nl__10);
___nl__0 = ___ref______nl__0.getValue();

//line 642
___nl__10 = null;
//line 642
___nl__7 = new ImmArray(new Imm[] {___nl__8,___nl__9,});
//line 642
___nl__8 = null;
//line 642
___nl__9 = null;
//line 642
___nl__5 = generator_c_NL.NL_get_fun_lib_priv(___nl__6,___nl__7);

//line 642
___nl__7 = null;
//line 642
___nl__6 = null;
//line 643
___nl__7 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 643
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = generator_c_NL.NL_get_assign_priv(___ref______nl__0,___nl__7,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 643
___nl__7 = null;
//line 643
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("ov_as"));
//line 645
___nl__6 = new ImmString("priv_as");
//line 645
___nl__9 = ((ImmHash)___nl__4).getHashValue()["src"];
//line 645
___ref______nl__0 = new ImmRef(___nl__0);
___nl__8 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__9);
___nl__0 = ___ref______nl__0.getValue();

//line 645
___nl__9 = null;
//line 645
___nl__10 = ((ImmHash)___nl__4).getHashValue()["type"];
//line 645
___ref______nl__0 = new ImmRef(___nl__0);
___nl__9 = generator_c_NL.NL_get_const_sim_priv(___ref______nl__0,___nl__10);
___nl__0 = ___ref______nl__0.getValue();

//line 645
___nl__10 = null;
//line 645
___nl__7 = new ImmArray(new Imm[] {___nl__8,___nl__9,});
//line 645
___nl__8 = null;
//line 645
___nl__9 = null;
//line 645
___nl__5 = generator_c_NL.NL_get_fun_lib_priv(___nl__6,___nl__7);

//line 645
___nl__7 = null;
//line 645
___nl__6 = null;
//line 646
___nl__7 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 646
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = generator_c_NL.NL_get_assign_priv(___ref______nl__0,___nl__7,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 646
___nl__7 = null;
//line 646
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("return"));
//line 648
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_move_register_to_ref_args_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 649
___nl__5 = new ImmString("return ");
//line 649
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 649
___nl__5 = null;
//line 650
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("val"));
//line 650
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_33;}}
//line 652
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("emp"));
//line 652
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_34;}}
//line 652
___nl__5 = new ImmString("NOMATCHALERT");
//line 652
___nl__5 = new ImmArray(new Imm[] {___nl__5,___nl__4,});
//line 652
c_rt_lib_NL.NL_die();
//line 650
label_33:
//line 650
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("val"));
//line 651
___ref______nl__0 = new ImmRef(___nl__0);
___nl__7 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

//line 651
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 651
___nl__7 = null;
//line 651
___nl__6 = null;
//line 652
if (true) {goto label_32;}
//line 652
label_34:
//line 653
___nl__6 = new ImmString("NULL");
//line 653
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("die"));
//line 656
___nl__5 = new ImmString("nl_die_arg(");
//line 656
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 656
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 656
___nl__6 = null;
//line 656
___nl__6 = new ImmString(")");
//line 656
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 656
___nl__6 = null;
//line 656
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 656
___nl__5 = null;
//line 656
___nl__4 = null;
//line 657
if (true) {goto label_1;}
//line 657
label_12:
//line 657
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("move"));
//line 658
___nl__5 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 658
___nl__6 = new ImmString("");
//line 658
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__5.toString().Equals(___nl__6.toString()));
//line 658
___nl__6 = null;
//line 658
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
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
___nl__7 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 659
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = generator_c_NL.NL_get_reg_ref_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 659
___nl__7 = null;
//line 659
___nl__8 = ((ImmHash)___nl__4).getHashValue()["src"];
//line 659
___ref______nl__0 = new ImmRef(___nl__0);
___nl__7 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__8);
___nl__0 = ___ref______nl__0.getValue();

//line 659
___nl__8 = null;
//line 659
___nl__5 = new ImmArray(new Imm[] {___nl__6,___nl__7,});
//line 659
___nl__6 = null;
//line 659
___nl__7 = null;
//line 660
___nl__7 = new ImmString("copy");
//line 660
___nl__6 = generator_c_NL.NL_get_fun_lib_priv(___nl__7,___nl__5);

//line 660
___nl__7 = null;
//line 660
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("load_const"));
//line 662
___nl__5 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 662
___nl__6 = new ImmString("");
//line 662
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__5.toString().Equals(___nl__6.toString()));
//line 662
___nl__6 = null;
//line 662
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
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
___nl__6 = new ImmString("move");
//line 663
___nl__5 = generator_c_NL.NL_get_lib_fun_priv(___nl__6);

//line 663
___nl__6 = null;
//line 663
___nl__6 = new ImmString("(");
//line 663
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 663
___nl__6 = null;
//line 663
___nl__7 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 663
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = generator_c_NL.NL_get_reg_ref_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 663
___nl__7 = null;
//line 663
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 663
___nl__6 = null;
//line 663
___nl__6 = new ImmString(",");
//line 663
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 663
___nl__6 = null;
//line 663
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 663
___nl__5 = null;
//line 664
___nl__5 = ((ImmHash)___nl__4).getHashValue()["val"];
//line 664
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_generate_imm_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 664
___nl__5 = null;
//line 665
___nl__5 = new ImmString(")");
//line 665
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 665
___nl__5 = null;
//line 665
___nl__4 = null;
//line 666
if (true) {goto label_1;}
//line 666
label_14:
//line 666
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("get_frm_idx"));
//line 667
___nl__6 = new ImmString("array_get");
//line 667
___nl__9 = ((ImmHash)___nl__4).getHashValue()["src"];
//line 667
___ref______nl__0 = new ImmRef(___nl__0);
___nl__8 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__9);
___nl__0 = ___ref______nl__0.getValue();

//line 667
___nl__9 = null;
//line 667
___nl__10 = ((ImmHash)___nl__4).getHashValue()["idx"];
//line 667
___ref______nl__0 = new ImmRef(___nl__0);
___nl__9 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__10);
___nl__0 = ___ref______nl__0.getValue();

//line 667
___nl__10 = null;
//line 667
___nl__7 = new ImmArray(new Imm[] {___nl__8,___nl__9,});
//line 667
___nl__8 = null;
//line 667
___nl__9 = null;
//line 667
___nl__5 = generator_c_NL.NL_get_fun_lib_priv(___nl__6,___nl__7);

//line 667
___nl__7 = null;
//line 667
___nl__6 = null;
//line 668
___nl__7 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 668
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = generator_c_NL.NL_get_assign_priv(___ref______nl__0,___nl__7,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 668
___nl__7 = null;
//line 668
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("set_at_idx"));
//line 670
___nl__6 = new ImmString("array_set");
//line 670
___nl__9 = ((ImmHash)___nl__4).getHashValue()["src"];
//line 670
___ref______nl__0 = new ImmRef(___nl__0);
___nl__8 = generator_c_NL.NL_get_reg_ref_priv(___ref______nl__0,___nl__9);
___nl__0 = ___ref______nl__0.getValue();

//line 670
___nl__9 = null;
//line 670
___nl__10 = ((ImmHash)___nl__4).getHashValue()["idx"];
//line 670
___ref______nl__0 = new ImmRef(___nl__0);
___nl__9 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__10);
___nl__0 = ___ref______nl__0.getValue();

//line 670
___nl__10 = null;
//line 670
___nl__11 = ((ImmHash)___nl__4).getHashValue()["val"];
//line 670
___ref______nl__0 = new ImmRef(___nl__0);
___nl__10 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__11);
___nl__0 = ___ref______nl__0.getValue();

//line 670
___nl__11 = null;
//line 670
___nl__7 = new ImmArray(new Imm[] {___nl__8,___nl__9,___nl__10,});
//line 670
___nl__8 = null;
//line 670
___nl__9 = null;
//line 670
___nl__10 = null;
//line 670
___nl__5 = generator_c_NL.NL_get_fun_lib_priv(___nl__6,___nl__7);

//line 670
___nl__7 = null;
//line 670
___nl__6 = null;
//line 670
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 670
___nl__5 = null;
//line 670
___nl__4 = null;
//line 672
if (true) {goto label_1;}
//line 672
label_16:
//line 672
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("get_val"));
//line 673
___nl__6 = new ImmString("hash_get_value_dec");
//line 673
___nl__9 = ((ImmHash)___nl__4).getHashValue()["src"];
//line 673
___ref______nl__0 = new ImmRef(___nl__0);
___nl__8 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__9);
___nl__0 = ___ref______nl__0.getValue();

//line 673
___nl__9 = null;
//line 673
___nl__10 = ((ImmHash)___nl__4).getHashValue()["key"];
//line 673
___ref______nl__0 = new ImmRef(___nl__0);
___nl__9 = generator_c_NL.NL_get_const_sim_priv(___ref______nl__0,___nl__10);
___nl__0 = ___ref______nl__0.getValue();

//line 673
___nl__10 = null;
//line 673
___nl__7 = new ImmArray(new Imm[] {___nl__8,___nl__9,});
//line 673
___nl__8 = null;
//line 673
___nl__9 = null;
//line 673
___nl__5 = generator_c_NL.NL_get_fun_lib_priv(___nl__6,___nl__7);

//line 673
___nl__7 = null;
//line 673
___nl__6 = null;
//line 675
___nl__7 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 675
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = generator_c_NL.NL_get_assign_priv(___ref______nl__0,___nl__7,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 675
___nl__7 = null;
//line 675
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("set_val"));
//line 677
___nl__6 = new ImmString("hash_set_value_dec");
//line 677
___nl__9 = ((ImmHash)___nl__4).getHashValue()["src"];
//line 677
___ref______nl__0 = new ImmRef(___nl__0);
___nl__8 = generator_c_NL.NL_get_reg_ref_priv(___ref______nl__0,___nl__9);
___nl__0 = ___ref______nl__0.getValue();

//line 677
___nl__9 = null;
//line 677
___nl__10 = ((ImmHash)___nl__4).getHashValue()["key"];
//line 677
___ref______nl__0 = new ImmRef(___nl__0);
___nl__9 = generator_c_NL.NL_get_const_sim_priv(___ref______nl__0,___nl__10);
___nl__0 = ___ref______nl__0.getValue();

//line 677
___nl__10 = null;
//line 677
___nl__11 = ((ImmHash)___nl__4).getHashValue()["val"];
//line 677
___ref______nl__0 = new ImmRef(___nl__0);
___nl__10 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__11);
___nl__0 = ___ref______nl__0.getValue();

//line 677
___nl__11 = null;
//line 677
___nl__7 = new ImmArray(new Imm[] {___nl__8,___nl__9,___nl__10,});
//line 677
___nl__8 = null;
//line 677
___nl__9 = null;
//line 677
___nl__10 = null;
//line 677
___nl__5 = generator_c_NL.NL_get_fun_lib_priv(___nl__6,___nl__7);

//line 677
___nl__7 = null;
//line 677
___nl__6 = null;
//line 677
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 677
___nl__5 = null;
//line 677
___nl__4 = null;
//line 679
if (true) {goto label_1;}
//line 679
label_18:
//line 679
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("ov_mk"));
//line 681
___nl__6 = ((ImmHash)___nl__4).getHashValue()["src"];
//line 681
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("emp"));
//line 681
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 681
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_41;}}
//line 681
___nl__6 = ((ImmHash)___nl__4).getHashValue()["name"];
//line 681
___nl__8 = new ImmString("TRUE");
//line 681
___nl__6 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__8.toString()));
//line 681
___nl__8 = null;
//line 681
label_41:
//line 681
___nl__7 = null;
//line 681
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 681
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_40;}}
//line 682
___nl__8 = new ImmString("get_true");
//line 682
___nl__9 = new ImmArray(new Imm[0]);
//line 682
___nl__7 = generator_c_NL.NL_get_fun_lib_priv(___nl__8,___nl__9);

//line 682
___nl__9 = null;
//line 682
___nl__8 = null;
//line 682
___nl__5 = ___nl__7;
//line 682
___nl__7 = null;
//line 683
if (true) {goto label_39;}
//line 683
label_40:
//line 683
___nl__6 = ((ImmHash)___nl__4).getHashValue()["src"];
//line 683
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("emp"));
//line 683
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 683
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_43;}}
//line 683
___nl__6 = ((ImmHash)___nl__4).getHashValue()["name"];
//line 683
___nl__8 = new ImmString("FALSE");
//line 683
___nl__6 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__8.toString()));
//line 683
___nl__8 = null;
//line 683
label_43:
//line 683
___nl__7 = null;
//line 683
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 683
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_42;}}
//line 684
___nl__8 = new ImmString("get_false");
//line 684
___nl__9 = new ImmArray(new Imm[0]);
//line 684
___nl__7 = generator_c_NL.NL_get_fun_lib_priv(___nl__8,___nl__9);

//line 684
___nl__9 = null;
//line 684
___nl__8 = null;
//line 684
___nl__5 = ___nl__7;
//line 684
___nl__7 = null;
//line 685
if (true) {goto label_39;}
//line 685
label_42:
//line 686
___nl__7 = ((ImmHash)___nl__4).getHashValue()["src"];
//line 686
___nl__8 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("arg"));
//line 686
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_45;}}
//line 688
___nl__8 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("emp"));
//line 688
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_46;}}
//line 688
___nl__8 = new ImmString("NOMATCHALERT");
//line 688
___nl__8 = new ImmArray(new Imm[] {___nl__8,___nl__7,});
//line 688
c_rt_lib_NL.NL_die();
//line 686
label_45:
//line 686
___nl__9 = c_rt_lib_NL.NL_ov_as(___nl__7, new ImmString("arg"));
//line 687
___nl__11 = new ImmString("ov_mk_arg");
//line 687
___nl__14 = ((ImmHash)___nl__4).getHashValue()["name"];
//line 687
___ref______nl__0 = new ImmRef(___nl__0);
___nl__13 = generator_c_NL.NL_get_const_sim_priv(___ref______nl__0,___nl__14);
___nl__0 = ___ref______nl__0.getValue();

//line 687
___nl__14 = null;
//line 687
___ref______nl__0 = new ImmRef(___nl__0);
___nl__14 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__9);
___nl__0 = ___ref______nl__0.getValue();

//line 687
___nl__12 = new ImmArray(new Imm[] {___nl__13,___nl__14,});
//line 687
___nl__13 = null;
//line 687
___nl__14 = null;
//line 687
___nl__10 = generator_c_NL.NL_get_fun_lib_priv(___nl__11,___nl__12);

//line 687
___nl__12 = null;
//line 687
___nl__11 = null;
//line 687
___nl__5 = ___nl__10;
//line 687
___nl__10 = null;
//line 687
___nl__9 = null;
//line 688
if (true) {goto label_44;}
//line 688
label_46:
//line 689
___nl__10 = new ImmString("ov_mk_none");
//line 689
___nl__13 = ((ImmHash)___nl__4).getHashValue()["name"];
//line 689
___ref______nl__0 = new ImmRef(___nl__0);
___nl__12 = generator_c_NL.NL_get_const_sim_priv(___ref______nl__0,___nl__13);
___nl__0 = ___ref______nl__0.getValue();

//line 689
___nl__13 = null;
//line 689
___nl__11 = new ImmArray(new Imm[] {___nl__12,});
//line 689
___nl__12 = null;
//line 689
___nl__9 = generator_c_NL.NL_get_fun_lib_priv(___nl__10,___nl__11);

//line 689
___nl__11 = null;
//line 689
___nl__10 = null;
//line 689
___nl__5 = ___nl__9;
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
___nl__7 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 692
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = generator_c_NL.NL_get_assign_priv(___ref______nl__0,___nl__7,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 692
___nl__7 = null;
//line 692
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("prt_lbl"));
//line 694
___nl__5 = new ImmString(":");
//line 694
___nl__5 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 694
___nl__6 = string_NL.NL_lf();

//line 694
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 694
___nl__6 = null;
//line 694
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("if_goto"));
//line 697
___nl__5 = new ImmString("if(");
//line 697
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 697
___nl__5 = null;
//line 698
___nl__6 = new ImmString("check_true_native");
//line 698
___nl__9 = ((ImmHash)___nl__4).getHashValue()["src"];
//line 698
___ref______nl__0 = new ImmRef(___nl__0);
___nl__8 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__9);
___nl__0 = ___ref______nl__0.getValue();

//line 698
___nl__9 = null;
//line 698
___nl__7 = new ImmArray(new Imm[] {___nl__8,});
//line 698
___nl__8 = null;
//line 698
___nl__5 = generator_c_NL.NL_get_fun_lib_priv(___nl__6,___nl__7);

//line 698
___nl__7 = null;
//line 698
___nl__6 = null;
//line 698
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 698
___nl__5 = null;
//line 699
___nl__5 = new ImmString("){ goto ");
//line 699
___nl__6 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 699
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 699
___nl__6 = null;
//line 699
___nl__6 = new ImmString(";}");
//line 699
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 699
___nl__6 = null;
//line 699
___nl__6 = string_NL.NL_lf();

//line 699
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 699
___nl__6 = null;
//line 699
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("goto"));
//line 702
___nl__5 = new ImmString("goto ");
//line 702
___nl__5 = new ImmString(___nl__5.toString() + ___nl__4.toString());
//line 702
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 702
___nl__5 = null;
//line 702
___nl__4 = null;
//line 703
if (true) {goto label_1;}
//line 703
label_22:
//line 703
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("clear"));
//line 704
___nl__6 = new ImmString("clear");
//line 704
___ref______nl__0 = new ImmRef(___nl__0);
___nl__8 = generator_c_NL.NL_get_reg_ref_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 704
___nl__7 = new ImmArray(new Imm[] {___nl__8,});
//line 704
___nl__8 = null;
//line 704
___nl__5 = generator_c_NL.NL_get_fun_lib_priv(___nl__6,___nl__7);

//line 704
___nl__7 = null;
//line 704
___nl__6 = null;
//line 704
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__2 = new ImmString(";");
//line 706
___nl__3 = string_NL.NL_lf();

//line 706
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 706
___nl__3 = null;
//line 706
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__3 = new ImmString("");
//line 710
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__1.toString().Equals(___nl__3.toString()));
//line 710
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 710
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 711
___nl__5 = new ImmString("delete");
//line 711
___nl__6 = new ImmArray(new Imm[] {___nl__2,});
//line 711
___nl__4 = generator_c_NL.NL_get_fun_lib_priv(___nl__5,___nl__6);

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
___nl__5 = new ImmString("move");
//line 713
___ref______nl__0 = new ImmRef(___nl__0);
___nl__7 = generator_c_NL.NL_get_reg_ref_priv(___ref______nl__0,___nl__1);
___nl__0 = ___ref______nl__0.getValue();

//line 713
___nl__6 = new ImmArray(new Imm[] {___nl__7,___nl__2,});
//line 713
___nl__7 = null;
//line 713
___nl__4 = generator_c_NL.NL_get_fun_lib_priv(___nl__5,___nl__6);

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
___nl__3 = ((ImmHash)___nl__1).getHashValue()["mod"];
//line 718
___nl__4 = ((ImmHash)___nl__1).getHashValue()["fun_name"];
//line 718
___nl__5 = ((ImmHash)___nl__0).getHashValue()["mod_name"];
//line 718
___nl__2 = generator_c_NL.NL_get_fun_name_priv(___nl__3,___nl__4,___nl__5);

//line 718
___nl__5 = null;
//line 718
___nl__4 = null;
//line 718
___nl__3 = null;
//line 718
___nl__3 = new ImmString("(");
//line 718
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 718
___nl__3 = null;
//line 719
___nl__4 = ((ImmHash)___nl__1).getHashValue()["args"];
//line 719
___nl__3 = array_NL.NL_len(___nl__4);

//line 719
___nl__4 = null;
//line 719
___nl__4 = new ImmDouble(0);
//line 719
___nl__5 = new ImmDouble(1);
//line 719
label_3:
//line 719
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__3.getValue().ToString())) );
//line 719
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_1;}}
//line 720
___nl__7 = new ImmDouble(0);
//line 720
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString())) ==((Double.Parse(___nl__4.getValue().ToString())))  );
//line 720
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 720
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 720
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_5;}}
//line 720
___nl__8 = new ImmString(", ");
//line 720
___nl__2 = new ImmString(___nl__2.toString() + ___nl__8.toString());
//line 720
___nl__8 = null;
//line 720
if (true) {goto label_5;}
//line 720
label_5:
//line 720
___nl__7 = null;
//line 721
___nl__7 = ((ImmHash)___nl__1).getHashValue()["args"];
//line 721
___nl__7 = (___nl__7 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()];
//line 721
___nl__8 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("val"));
//line 721
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_7;}}
//line 723
___nl__8 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("ref"));
//line 723
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_8;}}
//line 723
___nl__8 = new ImmString("NOMATCHALERT");
//line 723
___nl__8 = new ImmArray(new Imm[] {___nl__8,___nl__7,});
//line 723
c_rt_lib_NL.NL_die();
//line 721
label_7:
//line 721
___nl__9 = c_rt_lib_NL.NL_ov_as(___nl__7, new ImmString("val"));
//line 722
___ref______nl__0 = new ImmRef(___nl__0);
___nl__10 = generator_c_NL.NL_get_reg_priv(___ref______nl__0,___nl__9);
___nl__0 = ___ref______nl__0.getValue();

//line 722
___nl__2 = new ImmString(___nl__2.toString() + ___nl__10.toString());
//line 722
___nl__10 = null;
//line 722
___nl__9 = null;
//line 723
if (true) {goto label_6;}
//line 723
label_8:
//line 723
___nl__9 = c_rt_lib_NL.NL_ov_as(___nl__7, new ImmString("ref"));
//line 724
___ref______nl__0 = new ImmRef(___nl__0);
___nl__10 = generator_c_NL.NL_get_reg_ref_priv(___ref______nl__0,___nl__9);
___nl__0 = ___ref______nl__0.getValue();

//line 724
___nl__2 = new ImmString(___nl__2.toString() + ___nl__10.toString());
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
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString())));
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
___nl__3 = new ImmString(")");
//line 727
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 727
___nl__3 = null;
//line 728
___nl__4 = ((ImmHash)___nl__1).getHashValue()["dest"];
//line 728
___ref______nl__0 = new ImmRef(___nl__0);
___nl__3 = generator_c_NL.NL_get_assign_priv(___ref______nl__0,___nl__4,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 728
___nl__4 = null;
//line 728
___ref______nl__0 = new ImmRef(___nl__0);
generator_c_NL.NL_print_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

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
___nl__1 = string_utils_NL.NL_is_integer(___nl__0);

//line 732
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1));
//line 732
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_2;}}
//line 733
___nl__3 = new ImmString("int_new");
//line 733
___nl__2 = generator_c_NL.NL_get_lib_fun_priv(___nl__3);

//line 733
___nl__3 = null;
//line 733
___nl__3 = new ImmString("(");
//line 733
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 733
___nl__3 = null;
//line 733
___nl__2 = new ImmString(___nl__2.toString() + ___nl__0.toString());
//line 733
___nl__3 = new ImmString(")");
//line 733
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
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
___nl__1 = string_utils_NL.NL_is_float(___nl__0);

//line 734
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1));
//line 734
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_3;}}
//line 735
___nl__3 = new ImmString("float_new");
//line 735
___nl__2 = generator_c_NL.NL_get_lib_fun_priv(___nl__3);

//line 735
___nl__3 = null;
//line 735
___nl__3 = new ImmString("(");
//line 735
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 735
___nl__3 = null;
//line 735
___nl__2 = new ImmString(___nl__2.toString() + ___nl__0.toString());
//line 735
___nl__3 = new ImmString(")");
//line 735
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
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
___nl__2 = new ImmString("");
//line 737
___nl__2 = new ImmString(___nl__0.toString() + ___nl__2.toString());
//line 738
___nl__4 = new ImmString("\\");
//line 738
___nl__5 = new ImmString("\\\\");
//line 738
___nl__3 = string_NL.NL_replace(___nl__2,___nl__4,___nl__5);

//line 738
___nl__5 = null;
//line 738
___nl__4 = null;
//line 738
___nl__2 = ___nl__3;
//line 738
___nl__3 = null;
//line 739
___nl__4 = string_NL.NL_lf();

//line 739
___nl__5 = new ImmString("\\n");
//line 739
___nl__3 = string_NL.NL_replace(___nl__2,___nl__4,___nl__5);

//line 739
___nl__5 = null;
//line 739
___nl__4 = null;
//line 739
___nl__2 = ___nl__3;
//line 739
___nl__3 = null;
//line 740
___nl__4 = string_NL.NL_r();

//line 740
___nl__5 = new ImmString("\\r");
//line 740
___nl__3 = string_NL.NL_replace(___nl__2,___nl__4,___nl__5);

//line 740
___nl__5 = null;
//line 740
___nl__4 = null;
//line 740
___nl__2 = ___nl__3;
//line 740
___nl__3 = null;
//line 741
___nl__4 = string_NL.NL_tab();

//line 741
___nl__5 = new ImmString("\\t");
//line 741
___nl__3 = string_NL.NL_replace(___nl__2,___nl__4,___nl__5);

//line 741
___nl__5 = null;
//line 741
___nl__4 = null;
//line 741
___nl__2 = ___nl__3;
//line 741
___nl__3 = null;
//line 742
___nl__4 = new ImmString("\"");
//line 742
___nl__5 = new ImmString("\\\"");
//line 742
___nl__3 = string_NL.NL_replace(___nl__2,___nl__4,___nl__5);

//line 742
___nl__5 = null;
//line 742
___nl__4 = null;
//line 742
___nl__2 = ___nl__3;
//line 742
___nl__3 = null;
//line 743
___nl__4 = new ImmString("'");
//line 743
___nl__5 = new ImmString("\\'");
//line 743
___nl__3 = string_NL.NL_replace(___nl__2,___nl__4,___nl__5);

//line 743
___nl__5 = null;
//line 743
___nl__4 = null;
//line 743
___nl__2 = ___nl__3;
//line 743
___nl__3 = null;
//line 744
___nl__4 = new ImmString("string_new");
//line 744
___nl__3 = generator_c_NL.NL_get_lib_fun_priv(___nl__4);

//line 744
___nl__4 = null;
//line 744
___nl__4 = new ImmString("(\"");
//line 744
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 744
___nl__4 = null;
//line 744
___nl__3 = new ImmString(___nl__3.toString() + ___nl__2.toString());
//line 744
___nl__4 = new ImmString("\")");
//line 744
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
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
___nl__2 = string_utils_NL.NL_is_integer(___nl__0);

//line 749
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 749
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 750
___nl__4 = new ImmString("int_new_to_memory");
//line 750
___nl__3 = generator_c_NL.NL_get_lib_fun_priv(___nl__4);

//line 750
___nl__4 = null;
//line 750
___nl__4 = new ImmString("(");
//line 750
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 750
___nl__4 = null;
//line 750
___nl__3 = new ImmString(___nl__3.toString() + ___nl__0.toString());
//line 750
___nl__4 = new ImmString(",");
//line 750
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 750
___nl__4 = null;
//line 750
___nl__3 = new ImmString(___nl__3.toString() + ___nl__1.toString());
//line 750
___nl__4 = new ImmString(")");
//line 750
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
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
___nl__2 = string_utils_NL.NL_is_float(___nl__0);

//line 751
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 751
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_3;}}
//line 752
___nl__4 = new ImmString("float_new_to_memory");
//line 752
___nl__3 = generator_c_NL.NL_get_lib_fun_priv(___nl__4);

//line 752
___nl__4 = null;
//line 752
___nl__4 = new ImmString("(");
//line 752
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 752
___nl__4 = null;
//line 752
___nl__3 = new ImmString(___nl__3.toString() + ___nl__0.toString());
//line 752
___nl__4 = new ImmString(",");
//line 752
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 752
___nl__4 = null;
//line 752
___nl__3 = new ImmString(___nl__3.toString() + ___nl__1.toString());
//line 752
___nl__4 = new ImmString(")");
//line 752
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
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
___nl__3 = new ImmString("");
//line 754
___nl__3 = new ImmString(___nl__0.toString() + ___nl__3.toString());
//line 755
___nl__5 = new ImmString("\\");
//line 755
___nl__6 = new ImmString("\\\\");
//line 755
___nl__4 = string_NL.NL_replace(___nl__3,___nl__5,___nl__6);

//line 755
___nl__6 = null;
//line 755
___nl__5 = null;
//line 755
___nl__3 = ___nl__4;
//line 755
___nl__4 = null;
//line 756
___nl__5 = string_NL.NL_lf();

//line 756
___nl__6 = new ImmString("\\n");
//line 756
___nl__4 = string_NL.NL_replace(___nl__3,___nl__5,___nl__6);

//line 756
___nl__6 = null;
//line 756
___nl__5 = null;
//line 756
___nl__3 = ___nl__4;
//line 756
___nl__4 = null;
//line 757
___nl__5 = string_NL.NL_r();

//line 757
___nl__6 = new ImmString("\\r");
//line 757
___nl__4 = string_NL.NL_replace(___nl__3,___nl__5,___nl__6);

//line 757
___nl__6 = null;
//line 757
___nl__5 = null;
//line 757
___nl__3 = ___nl__4;
//line 757
___nl__4 = null;
//line 758
___nl__5 = string_NL.NL_tab();

//line 758
___nl__6 = new ImmString("\\t");
//line 758
___nl__4 = string_NL.NL_replace(___nl__3,___nl__5,___nl__6);

//line 758
___nl__6 = null;
//line 758
___nl__5 = null;
//line 758
___nl__3 = ___nl__4;
//line 758
___nl__4 = null;
//line 759
___nl__5 = new ImmString("\"");
//line 759
___nl__6 = new ImmString("\\\"");
//line 759
___nl__4 = string_NL.NL_replace(___nl__3,___nl__5,___nl__6);

//line 759
___nl__6 = null;
//line 759
___nl__5 = null;
//line 759
___nl__3 = ___nl__4;
//line 759
___nl__4 = null;
//line 760
___nl__5 = new ImmString("'");
//line 760
___nl__6 = new ImmString("\\'");
//line 760
___nl__4 = string_NL.NL_replace(___nl__3,___nl__5,___nl__6);

//line 760
___nl__6 = null;
//line 760
___nl__5 = null;
//line 760
___nl__3 = ___nl__4;
//line 760
___nl__4 = null;
//line 761
___nl__5 = new ImmString("string_new_to_memory");
//line 761
___nl__4 = generator_c_NL.NL_get_lib_fun_priv(___nl__5);

//line 761
___nl__5 = null;
//line 761
___nl__5 = new ImmString("(\"");
//line 761
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 761
___nl__5 = null;
//line 761
___nl__4 = new ImmString(___nl__4.toString() + ___nl__3.toString());
//line 761
___nl__5 = new ImmString("\",");
//line 761
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 761
___nl__5 = null;
//line 761
___nl__4 = new ImmString(___nl__4.toString() + ___nl__1.toString());
//line 761
___nl__5 = new ImmString(")");
//line 761
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
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