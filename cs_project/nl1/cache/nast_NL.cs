using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class nast_NL {

public static Imm NL_SINGLETON_bool_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 11
___nl__2 = ptd_NL.NL_none().clone();

//line 11
___nl__3 = ptd_NL.NL_none().clone();

//line 11
__function_map = new Dictionary<String, Imm>();
__function_map.Add("FALSE",___nl__2);
__function_map.Add("TRUE",___nl__3);
___nl__1 = new ImmHash(__function_map).clone();
//line 11
___nl__2 = null;
//line 11
___nl__3 = null;
//line 11
___nl__0 = ptd_NL.NL_var(___nl__1).clone();

//line 11
___nl__1 = null;
//line 11
if(true) return ___nl__0;
//line 11
___nl__0 = null;
//line 11
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_bool_t = null;
public static Imm NL_bool_t() {
	if (value__singleton__NL_SINGLETON_bool_t == null) {
		value__singleton__NL_SINGLETON_bool_t = NL_SINGLETON_bool_t();
	}
	return value__singleton__NL_SINGLETON_bool_t;
}
public static Imm NL_SINGLETON_op_assoc_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 15
___nl__2 = ptd_NL.NL_none().clone();

//line 15
___nl__3 = ptd_NL.NL_none().clone();

//line 15
___nl__4 = ptd_NL.NL_none().clone();

//line 15
__function_map = new Dictionary<String, Imm>();
__function_map.Add("left",___nl__2);
__function_map.Add("right",___nl__3);
__function_map.Add("none",___nl__4);
___nl__1 = new ImmHash(__function_map).clone();
//line 15
___nl__2 = null;
//line 15
___nl__3 = null;
//line 15
___nl__4 = null;
//line 15
___nl__0 = ptd_NL.NL_var(___nl__1).clone();

//line 15
___nl__1 = null;
//line 15
if(true) return ___nl__0;
//line 15
___nl__0 = null;
//line 15
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_op_assoc_t = null;
public static Imm NL_op_assoc_t() {
	if (value__singleton__NL_SINGLETON_op_assoc_t == null) {
		value__singleton__NL_SINGLETON_op_assoc_t = NL_SINGLETON_op_assoc_t();
	}
	return value__singleton__NL_SINGLETON_op_assoc_t;
}
public static Imm NL_SINGLETON_op_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 19
___nl__2 = ptd_NL.NL_sim().clone();

//line 19
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("op_assoc_t"));
___nl__3 = new ImmHash(__function_map).clone();
//line 19
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3).clone();
//line 19
__function_map = new Dictionary<String, Imm>();
__function_map.Add("prec",___nl__2);
__function_map.Add("assoc",___nl__3);
___nl__1 = new ImmHash(__function_map).clone();
//line 19
___nl__2 = null;
//line 19
___nl__3 = null;
//line 19
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 19
___nl__1 = null;
//line 19
if(true) return ___nl__0;
//line 19
___nl__0 = null;
//line 19
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_op_t = null;
public static Imm NL_op_t() {
	if (value__singleton__NL_SINGLETON_op_t == null) {
		value__singleton__NL_SINGLETON_op_t = NL_SINGLETON_op_t();
	}
	return value__singleton__NL_SINGLETON_op_t;
}
public static Imm NL_SINGLETON_op_struct_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 23
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("op_t"));
___nl__1 = new ImmHash(__function_map).clone();
//line 23
___nl__1 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__1).clone();
//line 23
___nl__0 = ptd_NL.NL_hash(___nl__1).clone();

//line 23
___nl__1 = null;
//line 23
if(true) return ___nl__0;
//line 23
___nl__0 = null;
//line 23
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_op_struct_t = null;
public static Imm NL_op_struct_t() {
	if (value__singleton__NL_SINGLETON_op_struct_t == null) {
		value__singleton__NL_SINGLETON_op_struct_t = NL_SINGLETON_op_struct_t();
	}
	return value__singleton__NL_SINGLETON_op_struct_t;
}
private static Imm NL_op_def_priv(ref Imm ___arg__0, Imm ___arg__1, Imm ___arg__2, Imm ___arg__3) {
Imm ___nl__0 = ___arg__0;Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);Imm ___nl__2 = null;c_rt_lib_NL.NL_copy(ref ___nl__2, ___arg__2);Imm ___nl__3 = null;c_rt_lib_NL.NL_copy(ref ___nl__3, ___arg__3);
Imm ___nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 27
__function_map = new Dictionary<String, Imm>();
__function_map.Add("prec",___nl__2);
__function_map.Add("assoc",___nl__3);
___nl__4 = new ImmHash(__function_map).clone();
//line 27
hash_NL.NL_set_value(ref ___nl__0,___nl__1,___nl__4);

//line 27
___nl__4 = null;
//line 27
___nl__1 = null;
//line 27
___nl__2 = null;
//line 27
___nl__3 = null;
//line 27
___arg__0 = ___nl__0;if(true) return null;
}

public static Imm NL_SINGLETON_get_ternary_ops() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 31
__function_map = new Dictionary<String, Imm>();
___nl__0 = new ImmHash(__function_map).clone();
//line 32
___nl__1 = new ImmString("?").clone();
//line 32
___nl__2 = new ImmDouble(880).clone();
//line 32
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("right")).clone();
//line 32
nast_NL.NL_op_def_priv(ref ___nl__0,___nl__1,___nl__2,___nl__3);

//line 32
___nl__3 = null;
//line 32
___nl__2 = null;
//line 32
___nl__1 = null;
//line 33
___nl__1 = singleton_NL.NL_sigleton_do_not_use_without_approval(___nl__0).clone();

//line 33
___nl__0 = null;
//line 33
if(true) return ___nl__1;
//line 33
___nl__1 = null;
//line 33
___nl__0 = null;
//line 33
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_get_ternary_ops = null;
public static Imm NL_get_ternary_ops() {
	if (value__singleton__NL_SINGLETON_get_ternary_ops == null) {
		value__singleton__NL_SINGLETON_get_ternary_ops = NL_SINGLETON_get_ternary_ops();
	}
	return value__singleton__NL_SINGLETON_get_ternary_ops;
}
public static Imm NL_SINGLETON_get_unary_ops() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 37
__function_map = new Dictionary<String, Imm>();
___nl__0 = new ImmHash(__function_map).clone();
//line 38
___nl__1 = new ImmString("@").clone();
//line 38
___nl__2 = new ImmDouble(1010).clone();
//line 38
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("right")).clone();
//line 38
nast_NL.NL_op_def_priv(ref ___nl__0,___nl__1,___nl__2,___nl__3);

//line 38
___nl__3 = null;
//line 38
___nl__2 = null;
//line 38
___nl__1 = null;
//line 39
___nl__1 = new ImmString("++").clone();
//line 39
___nl__2 = new ImmDouble(990).clone();
//line 39
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 39
nast_NL.NL_op_def_priv(ref ___nl__0,___nl__1,___nl__2,___nl__3);

//line 39
___nl__3 = null;
//line 39
___nl__2 = null;
//line 39
___nl__1 = null;
//line 40
___nl__1 = new ImmString("--").clone();
//line 40
___nl__2 = new ImmDouble(990).clone();
//line 40
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 40
nast_NL.NL_op_def_priv(ref ___nl__0,___nl__1,___nl__2,___nl__3);

//line 40
___nl__3 = null;
//line 40
___nl__2 = null;
//line 40
___nl__1 = null;
//line 41
___nl__1 = new ImmString("!").clone();
//line 41
___nl__2 = new ImmDouble(980).clone();
//line 41
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("right")).clone();
//line 41
nast_NL.NL_op_def_priv(ref ___nl__0,___nl__1,___nl__2,___nl__3);

//line 41
___nl__3 = null;
//line 41
___nl__2 = null;
//line 41
___nl__1 = null;
//line 42
___nl__1 = new ImmString("+").clone();
//line 42
___nl__2 = new ImmDouble(980).clone();
//line 42
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("right")).clone();
//line 42
nast_NL.NL_op_def_priv(ref ___nl__0,___nl__1,___nl__2,___nl__3);

//line 42
___nl__3 = null;
//line 42
___nl__2 = null;
//line 42
___nl__1 = null;
//line 43
___nl__1 = new ImmString("-").clone();
//line 43
___nl__2 = new ImmDouble(980).clone();
//line 43
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("right")).clone();
//line 43
nast_NL.NL_op_def_priv(ref ___nl__0,___nl__1,___nl__2,___nl__3);

//line 43
___nl__3 = null;
//line 43
___nl__2 = null;
//line 43
___nl__1 = null;
//line 44
___nl__1 = singleton_NL.NL_sigleton_do_not_use_without_approval(___nl__0).clone();

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
private static Imm value__singleton__NL_SINGLETON_get_unary_ops = null;
public static Imm NL_get_unary_ops() {
	if (value__singleton__NL_SINGLETON_get_unary_ops == null) {
		value__singleton__NL_SINGLETON_get_unary_ops = NL_SINGLETON_get_unary_ops();
	}
	return value__singleton__NL_SINGLETON_get_unary_ops;
}
public static Imm NL_SINGLETON_get_bin_ops() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 48
__function_map = new Dictionary<String, Imm>();
___nl__0 = new ImmHash(__function_map).clone();
//line 49
___nl__1 = new ImmString("->").clone();
//line 49
___nl__2 = new ImmDouble(2000).clone();
//line 49
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("left")).clone();
//line 49
nast_NL.NL_op_def_priv(ref ___nl__0,___nl__1,___nl__2,___nl__3);

//line 49
___nl__3 = null;
//line 49
___nl__2 = null;
//line 49
___nl__1 = null;
//line 50
___nl__1 = new ImmString("is").clone();
//line 50
___nl__2 = new ImmDouble(1500).clone();
//line 50
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("left")).clone();
//line 50
nast_NL.NL_op_def_priv(ref ___nl__0,___nl__1,___nl__2,___nl__3);

//line 50
___nl__3 = null;
//line 50
___nl__2 = null;
//line 50
___nl__1 = null;
//line 51
___nl__1 = new ImmString("as").clone();
//line 51
___nl__2 = new ImmDouble(1500).clone();
//line 51
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("left")).clone();
//line 51
nast_NL.NL_op_def_priv(ref ___nl__0,___nl__1,___nl__2,___nl__3);

//line 51
___nl__3 = null;
//line 51
___nl__2 = null;
//line 51
___nl__1 = null;
//line 52
___nl__1 = new ImmString("*").clone();
//line 52
___nl__2 = new ImmDouble(970).clone();
//line 52
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("left")).clone();
//line 52
nast_NL.NL_op_def_priv(ref ___nl__0,___nl__1,___nl__2,___nl__3);

//line 52
___nl__3 = null;
//line 52
___nl__2 = null;
//line 52
___nl__1 = null;
//line 53
___nl__1 = new ImmString("/").clone();
//line 53
___nl__2 = new ImmDouble(970).clone();
//line 53
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("left")).clone();
//line 53
nast_NL.NL_op_def_priv(ref ___nl__0,___nl__1,___nl__2,___nl__3);

//line 53
___nl__3 = null;
//line 53
___nl__2 = null;
//line 53
___nl__1 = null;
//line 54
___nl__1 = new ImmString("%").clone();
//line 54
___nl__2 = new ImmDouble(970).clone();
//line 54
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("left")).clone();
//line 54
nast_NL.NL_op_def_priv(ref ___nl__0,___nl__1,___nl__2,___nl__3);

//line 54
___nl__3 = null;
//line 54
___nl__2 = null;
//line 54
___nl__1 = null;
//line 55
___nl__1 = new ImmString("+").clone();
//line 55
___nl__2 = new ImmDouble(960).clone();
//line 55
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("left")).clone();
//line 55
nast_NL.NL_op_def_priv(ref ___nl__0,___nl__1,___nl__2,___nl__3);

//line 55
___nl__3 = null;
//line 55
___nl__2 = null;
//line 55
___nl__1 = null;
//line 56
___nl__1 = new ImmString("-").clone();
//line 56
___nl__2 = new ImmDouble(960).clone();
//line 56
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("left")).clone();
//line 56
nast_NL.NL_op_def_priv(ref ___nl__0,___nl__1,___nl__2,___nl__3);

//line 56
___nl__3 = null;
//line 56
___nl__2 = null;
//line 56
___nl__1 = null;
//line 57
___nl__1 = new ImmString(".").clone();
//line 57
___nl__2 = new ImmDouble(960).clone();
//line 57
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("left")).clone();
//line 57
nast_NL.NL_op_def_priv(ref ___nl__0,___nl__1,___nl__2,___nl__3);

//line 57
___nl__3 = null;
//line 57
___nl__2 = null;
//line 57
___nl__1 = null;
//line 58
___nl__1 = new ImmString(">=").clone();
//line 58
___nl__2 = new ImmDouble(940).clone();
//line 58
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 58
nast_NL.NL_op_def_priv(ref ___nl__0,___nl__1,___nl__2,___nl__3);

//line 58
___nl__3 = null;
//line 58
___nl__2 = null;
//line 58
___nl__1 = null;
//line 59
___nl__1 = new ImmString("<=").clone();
//line 59
___nl__2 = new ImmDouble(940).clone();
//line 59
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 59
nast_NL.NL_op_def_priv(ref ___nl__0,___nl__1,___nl__2,___nl__3);

//line 59
___nl__3 = null;
//line 59
___nl__2 = null;
//line 59
___nl__1 = null;
//line 60
___nl__1 = new ImmString("<").clone();
//line 60
___nl__2 = new ImmDouble(940).clone();
//line 60
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 60
nast_NL.NL_op_def_priv(ref ___nl__0,___nl__1,___nl__2,___nl__3);

//line 60
___nl__3 = null;
//line 60
___nl__2 = null;
//line 60
___nl__1 = null;
//line 61
___nl__1 = new ImmString(">").clone();
//line 61
___nl__2 = new ImmDouble(940).clone();
//line 61
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 61
nast_NL.NL_op_def_priv(ref ___nl__0,___nl__1,___nl__2,___nl__3);

//line 61
___nl__3 = null;
//line 61
___nl__2 = null;
//line 61
___nl__1 = null;
//line 62
___nl__1 = new ImmString("==").clone();
//line 62
___nl__2 = new ImmDouble(930).clone();
//line 62
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 62
nast_NL.NL_op_def_priv(ref ___nl__0,___nl__1,___nl__2,___nl__3);

//line 62
___nl__3 = null;
//line 62
___nl__2 = null;
//line 62
___nl__1 = null;
//line 63
___nl__1 = new ImmString("!=").clone();
//line 63
___nl__2 = new ImmDouble(930).clone();
//line 63
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 63
nast_NL.NL_op_def_priv(ref ___nl__0,___nl__1,___nl__2,___nl__3);

//line 63
___nl__3 = null;
//line 63
___nl__2 = null;
//line 63
___nl__1 = null;
//line 64
___nl__1 = new ImmString("eq").clone();
//line 64
___nl__2 = new ImmDouble(930).clone();
//line 64
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 64
nast_NL.NL_op_def_priv(ref ___nl__0,___nl__1,___nl__2,___nl__3);

//line 64
___nl__3 = null;
//line 64
___nl__2 = null;
//line 64
___nl__1 = null;
//line 65
___nl__1 = new ImmString("ne").clone();
//line 65
___nl__2 = new ImmDouble(930).clone();
//line 65
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 65
nast_NL.NL_op_def_priv(ref ___nl__0,___nl__1,___nl__2,___nl__3);

//line 65
___nl__3 = null;
//line 65
___nl__2 = null;
//line 65
___nl__1 = null;
//line 66
___nl__1 = new ImmString("&&").clone();
//line 66
___nl__2 = new ImmDouble(900).clone();
//line 66
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("left")).clone();
//line 66
nast_NL.NL_op_def_priv(ref ___nl__0,___nl__1,___nl__2,___nl__3);

//line 66
___nl__3 = null;
//line 66
___nl__2 = null;
//line 66
___nl__1 = null;
//line 67
___nl__1 = new ImmString("||").clone();
//line 67
___nl__2 = new ImmDouble(890).clone();
//line 67
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("left")).clone();
//line 67
nast_NL.NL_op_def_priv(ref ___nl__0,___nl__1,___nl__2,___nl__3);

//line 67
___nl__3 = null;
//line 67
___nl__2 = null;
//line 67
___nl__1 = null;
//line 68
___nl__1 = new ImmString("=").clone();
//line 68
___nl__2 = new ImmDouble(870).clone();
//line 68
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("right")).clone();
//line 68
nast_NL.NL_op_def_priv(ref ___nl__0,___nl__1,___nl__2,___nl__3);

//line 68
___nl__3 = null;
//line 68
___nl__2 = null;
//line 68
___nl__1 = null;
//line 69
___nl__1 = new ImmString("+=").clone();
//line 69
___nl__2 = new ImmDouble(870).clone();
//line 69
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("right")).clone();
//line 69
nast_NL.NL_op_def_priv(ref ___nl__0,___nl__1,___nl__2,___nl__3);

//line 69
___nl__3 = null;
//line 69
___nl__2 = null;
//line 69
___nl__1 = null;
//line 70
___nl__1 = new ImmString("/=").clone();
//line 70
___nl__2 = new ImmDouble(870).clone();
//line 70
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("right")).clone();
//line 70
nast_NL.NL_op_def_priv(ref ___nl__0,___nl__1,___nl__2,___nl__3);

//line 70
___nl__3 = null;
//line 70
___nl__2 = null;
//line 70
___nl__1 = null;
//line 71
___nl__1 = new ImmString("*=").clone();
//line 71
___nl__2 = new ImmDouble(870).clone();
//line 71
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("right")).clone();
//line 71
nast_NL.NL_op_def_priv(ref ___nl__0,___nl__1,___nl__2,___nl__3);

//line 71
___nl__3 = null;
//line 71
___nl__2 = null;
//line 71
___nl__1 = null;
//line 72
___nl__1 = new ImmString(".=").clone();
//line 72
___nl__2 = new ImmDouble(870).clone();
//line 72
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("right")).clone();
//line 72
nast_NL.NL_op_def_priv(ref ___nl__0,___nl__1,___nl__2,___nl__3);

//line 72
___nl__3 = null;
//line 72
___nl__2 = null;
//line 72
___nl__1 = null;
//line 73
___nl__1 = new ImmString("-=").clone();
//line 73
___nl__2 = new ImmDouble(870).clone();
//line 73
___nl__3 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("right")).clone();
//line 73
nast_NL.NL_op_def_priv(ref ___nl__0,___nl__1,___nl__2,___nl__3);

//line 73
___nl__3 = null;
//line 73
___nl__2 = null;
//line 73
___nl__1 = null;
//line 74
___nl__1 = singleton_NL.NL_sigleton_do_not_use_without_approval(___nl__0).clone();

//line 74
___nl__0 = null;
//line 74
if(true) return ___nl__1;
//line 74
___nl__1 = null;
//line 74
___nl__0 = null;
//line 74
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_get_bin_ops = null;
public static Imm NL_get_bin_ops() {
	if (value__singleton__NL_SINGLETON_get_bin_ops == null) {
		value__singleton__NL_SINGLETON_get_bin_ops = NL_SINGLETON_get_bin_ops();
	}
	return value__singleton__NL_SINGLETON_get_bin_ops;
}
public static Imm NL_SINGLETON_get_max_precedence() {

Imm ___nl__0 = null;
Dictionary<String, Imm> __function_map;
//line 79
___nl__0 = new ImmDouble(2000).clone();
//line 79
if(true) return ___nl__0;
//line 79
___nl__0 = null;
//line 79
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_get_max_precedence = null;
public static Imm NL_get_max_precedence() {
	if (value__singleton__NL_SINGLETON_get_max_precedence == null) {
		value__singleton__NL_SINGLETON_get_max_precedence = NL_SINGLETON_get_max_precedence();
	}
	return value__singleton__NL_SINGLETON_get_max_precedence;
}
public static Imm NL_SINGLETON_variant_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 83
___nl__2 = ptd_NL.NL_sim().clone();

//line 83
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("value_t"));
___nl__3 = new ImmHash(__function_map).clone();
//line 83
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3).clone();
//line 83
__function_map = new Dictionary<String, Imm>();
__function_map.Add("name",___nl__2);
__function_map.Add("var",___nl__3);
___nl__1 = new ImmHash(__function_map).clone();
//line 83
___nl__2 = null;
//line 83
___nl__3 = null;
//line 83
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 83
___nl__1 = null;
//line 83
if(true) return ___nl__0;
//line 83
___nl__0 = null;
//line 83
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_variant_t = null;
public static Imm NL_variant_t() {
	if (value__singleton__NL_SINGLETON_variant_t == null) {
		value__singleton__NL_SINGLETON_variant_t = NL_SINGLETON_variant_t();
	}
	return value__singleton__NL_SINGLETON_variant_t;
}
public static Imm NL_SINGLETON_fun_def_t() {

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
//line 87
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("variable_type_t"));
___nl__2 = new ImmHash(__function_map).clone();
//line 87
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2).clone();
//line 87
___nl__3 = ptd_NL.NL_sim().clone();

//line 87
___nl__4 = ptd_NL.NL_sim().clone();

//line 87
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("cmd_t"));
___nl__5 = new ImmHash(__function_map).clone();
//line 87
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__5).clone();
//line 87
___nl__8 = ptd_NL.NL_none().clone();

//line 87
___nl__9 = ptd_NL.NL_none().clone();

//line 87
__function_map = new Dictionary<String, Imm>();
__function_map.Add("priv",___nl__8);
__function_map.Add("pub",___nl__9);
___nl__7 = new ImmHash(__function_map).clone();
//line 87
___nl__8 = null;
//line 87
___nl__9 = null;
//line 87
___nl__6 = ptd_NL.NL_var(___nl__7).clone();

//line 87
___nl__7 = null;
//line 87
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("fun_def_arg_t"));
___nl__8 = new ImmHash(__function_map).clone();
//line 87
___nl__8 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__8).clone();
//line 87
___nl__7 = ptd_NL.NL_arr(___nl__8).clone();

//line 87
___nl__8 = null;
//line 87
__function_map = new Dictionary<String, Imm>();
__function_map.Add("ret_type",___nl__2);
__function_map.Add("line",___nl__3);
__function_map.Add("name",___nl__4);
__function_map.Add("cmd",___nl__5);
__function_map.Add("access",___nl__6);
__function_map.Add("args",___nl__7);
___nl__1 = new ImmHash(__function_map).clone();
//line 87
___nl__2 = null;
//line 87
___nl__3 = null;
//line 87
___nl__4 = null;
//line 87
___nl__5 = null;
//line 87
___nl__6 = null;
//line 87
___nl__7 = null;
//line 87
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 87
___nl__1 = null;
//line 87
if(true) return ___nl__0;
//line 87
___nl__0 = null;
//line 87
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_fun_def_t = null;
public static Imm NL_fun_def_t() {
	if (value__singleton__NL_SINGLETON_fun_def_t == null) {
		value__singleton__NL_SINGLETON_fun_def_t = NL_SINGLETON_fun_def_t();
	}
	return value__singleton__NL_SINGLETON_fun_def_t;
}
public static Imm NL_SINGLETON_fun_def_arg_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Dictionary<String, Imm> __function_map;
//line 98
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("variable_type_t"));
___nl__2 = new ImmHash(__function_map).clone();
//line 98
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2).clone();
//line 98
___nl__3 = ptd_NL.NL_sim().clone();

//line 98
___nl__6 = ptd_NL.NL_none().clone();

//line 98
___nl__7 = ptd_NL.NL_none().clone();

//line 98
__function_map = new Dictionary<String, Imm>();
__function_map.Add("none",___nl__6);
__function_map.Add("ref",___nl__7);
___nl__5 = new ImmHash(__function_map).clone();
//line 98
___nl__6 = null;
//line 98
___nl__7 = null;
//line 98
___nl__4 = ptd_NL.NL_var(___nl__5).clone();

//line 98
___nl__5 = null;
//line 98
__function_map = new Dictionary<String, Imm>();
__function_map.Add("type",___nl__2);
__function_map.Add("name",___nl__3);
__function_map.Add("mod",___nl__4);
___nl__1 = new ImmHash(__function_map).clone();
//line 98
___nl__2 = null;
//line 98
___nl__3 = null;
//line 98
___nl__4 = null;
//line 98
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 98
___nl__1 = null;
//line 98
if(true) return ___nl__0;
//line 98
___nl__0 = null;
//line 98
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_fun_def_arg_t = null;
public static Imm NL_fun_def_arg_t() {
	if (value__singleton__NL_SINGLETON_fun_def_arg_t == null) {
		value__singleton__NL_SINGLETON_fun_def_arg_t = NL_SINGLETON_fun_def_arg_t();
	}
	return value__singleton__NL_SINGLETON_fun_def_arg_t;
}
public static Imm NL_SINGLETON_module_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Dictionary<String, Imm> __function_map;
//line 106
___nl__2 = ptd_NL.NL_sim().clone();

//line 106
___nl__6 = ptd_NL.NL_sim().clone();

//line 106
___nl__7 = ptd_NL.NL_sim().clone();

//line 106
__function_map = new Dictionary<String, Imm>();
__function_map.Add("name",___nl__6);
__function_map.Add("line",___nl__7);
___nl__5 = new ImmHash(__function_map).clone();
//line 106
___nl__6 = null;
//line 106
___nl__7 = null;
//line 106
___nl__4 = ptd_NL.NL_rec(___nl__5).clone();

//line 106
___nl__5 = null;
//line 106
___nl__3 = ptd_NL.NL_arr(___nl__4).clone();

//line 106
___nl__4 = null;
//line 106
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("fun_def_t"));
___nl__5 = new ImmHash(__function_map).clone();
//line 106
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__5).clone();
//line 106
___nl__4 = ptd_NL.NL_arr(___nl__5).clone();

//line 106
___nl__5 = null;
//line 106
__function_map = new Dictionary<String, Imm>();
__function_map.Add("name",___nl__2);
__function_map.Add("import",___nl__3);
__function_map.Add("fun_def",___nl__4);
___nl__1 = new ImmHash(__function_map).clone();
//line 106
___nl__2 = null;
//line 106
___nl__3 = null;
//line 106
___nl__4 = null;
//line 106
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 106
___nl__1 = null;
//line 106
if(true) return ___nl__0;
//line 106
___nl__0 = null;
//line 106
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_module_t = null;
public static Imm NL_module_t() {
	if (value__singleton__NL_SINGLETON_module_t == null) {
		value__singleton__NL_SINGLETON_module_t = NL_SINGLETON_module_t();
	}
	return value__singleton__NL_SINGLETON_module_t;
}
public static Imm NL_SINGLETON_variable_type_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 114
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("value_t"));
___nl__2 = new ImmHash(__function_map).clone();
//line 114
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2).clone();
//line 114
___nl__3 = ptd_NL.NL_none().clone();

//line 114
__function_map = new Dictionary<String, Imm>();
__function_map.Add("type",___nl__2);
__function_map.Add("none",___nl__3);
___nl__1 = new ImmHash(__function_map).clone();
//line 114
___nl__2 = null;
//line 114
___nl__3 = null;
//line 114
___nl__0 = ptd_NL.NL_var(___nl__1).clone();

//line 114
___nl__1 = null;
//line 114
if(true) return ___nl__0;
//line 114
___nl__0 = null;
//line 114
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_variable_type_t = null;
public static Imm NL_variable_type_t() {
	if (value__singleton__NL_SINGLETON_variable_type_t == null) {
		value__singleton__NL_SINGLETON_variable_type_t = NL_SINGLETON_variable_type_t();
	}
	return value__singleton__NL_SINGLETON_variable_type_t;
}
public static Imm NL_SINGLETON_variable_declaration_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Dictionary<String, Imm> __function_map;
//line 118
___nl__2 = ptd_NL.NL_sim().clone();

//line 118
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("variable_type_t"));
___nl__3 = new ImmHash(__function_map).clone();
//line 118
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3).clone();
//line 118
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("value_t"));
___nl__6 = new ImmHash(__function_map).clone();
//line 118
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__6).clone();
//line 118
___nl__7 = ptd_NL.NL_none().clone();

//line 118
__function_map = new Dictionary<String, Imm>();
__function_map.Add("value",___nl__6);
__function_map.Add("none",___nl__7);
___nl__5 = new ImmHash(__function_map).clone();
//line 118
___nl__6 = null;
//line 118
___nl__7 = null;
//line 118
___nl__4 = ptd_NL.NL_var(___nl__5).clone();

//line 118
___nl__5 = null;
//line 118
__function_map = new Dictionary<String, Imm>();
__function_map.Add("name",___nl__2);
__function_map.Add("type",___nl__3);
__function_map.Add("value",___nl__4);
___nl__1 = new ImmHash(__function_map).clone();
//line 118
___nl__2 = null;
//line 118
___nl__3 = null;
//line 118
___nl__4 = null;
//line 118
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 118
___nl__1 = null;
//line 118
if(true) return ___nl__0;
//line 118
___nl__0 = null;
//line 118
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_variable_declaration_t = null;
public static Imm NL_variable_declaration_t() {
	if (value__singleton__NL_SINGLETON_variable_declaration_t == null) {
		value__singleton__NL_SINGLETON_variable_declaration_t = NL_SINGLETON_variable_declaration_t();
	}
	return value__singleton__NL_SINGLETON_variable_declaration_t;
}
public static Imm NL_SINGLETON_fun_val_arg_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Dictionary<String, Imm> __function_map;
//line 126
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("value_t"));
___nl__2 = new ImmHash(__function_map).clone();
//line 126
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2).clone();
//line 126
___nl__5 = ptd_NL.NL_none().clone();

//line 126
___nl__6 = ptd_NL.NL_none().clone();

//line 126
__function_map = new Dictionary<String, Imm>();
__function_map.Add("none",___nl__5);
__function_map.Add("ref",___nl__6);
___nl__4 = new ImmHash(__function_map).clone();
//line 126
___nl__5 = null;
//line 126
___nl__6 = null;
//line 126
___nl__3 = ptd_NL.NL_var(___nl__4).clone();

//line 126
___nl__4 = null;
//line 126
__function_map = new Dictionary<String, Imm>();
__function_map.Add("val",___nl__2);
__function_map.Add("mod",___nl__3);
___nl__1 = new ImmHash(__function_map).clone();
//line 126
___nl__2 = null;
//line 126
___nl__3 = null;
//line 126
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 126
___nl__1 = null;
//line 126
if(true) return ___nl__0;
//line 126
___nl__0 = null;
//line 126
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_fun_val_arg_t = null;
public static Imm NL_fun_val_arg_t() {
	if (value__singleton__NL_SINGLETON_fun_val_arg_t == null) {
		value__singleton__NL_SINGLETON_fun_val_arg_t = NL_SINGLETON_fun_val_arg_t();
	}
	return value__singleton__NL_SINGLETON_fun_val_arg_t;
}
public static Imm NL_SINGLETON_fun_val_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Dictionary<String, Imm> __function_map;
//line 130
___nl__2 = ptd_NL.NL_sim().clone();

//line 130
___nl__3 = ptd_NL.NL_sim().clone();

//line 130
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("fun_val_arg_t"));
___nl__5 = new ImmHash(__function_map).clone();
//line 130
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__5).clone();
//line 130
___nl__4 = ptd_NL.NL_arr(___nl__5).clone();

//line 130
___nl__5 = null;
//line 130
__function_map = new Dictionary<String, Imm>();
__function_map.Add("name",___nl__2);
__function_map.Add("module",___nl__3);
__function_map.Add("args",___nl__4);
___nl__1 = new ImmHash(__function_map).clone();
//line 130
___nl__2 = null;
//line 130
___nl__3 = null;
//line 130
___nl__4 = null;
//line 130
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 130
___nl__1 = null;
//line 130
if(true) return ___nl__0;
//line 130
___nl__0 = null;
//line 130
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_fun_val_t = null;
public static Imm NL_fun_val_t() {
	if (value__singleton__NL_SINGLETON_fun_val_t == null) {
		value__singleton__NL_SINGLETON_fun_val_t = NL_SINGLETON_fun_val_t();
	}
	return value__singleton__NL_SINGLETON_fun_val_t;
}
public static Imm NL_SINGLETON_hash_elem_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 134
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("value_t"));
___nl__2 = new ImmHash(__function_map).clone();
//line 134
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2).clone();
//line 134
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("value_t"));
___nl__3 = new ImmHash(__function_map).clone();
//line 134
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3).clone();
//line 134
__function_map = new Dictionary<String, Imm>();
__function_map.Add("key",___nl__2);
__function_map.Add("val",___nl__3);
___nl__1 = new ImmHash(__function_map).clone();
//line 134
___nl__2 = null;
//line 134
___nl__3 = null;
//line 134
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 134
___nl__1 = null;
//line 134
if(true) return ___nl__0;
//line 134
___nl__0 = null;
//line 134
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_hash_elem_t = null;
public static Imm NL_hash_elem_t() {
	if (value__singleton__NL_SINGLETON_hash_elem_t == null) {
		value__singleton__NL_SINGLETON_hash_elem_t = NL_SINGLETON_hash_elem_t();
	}
	return value__singleton__NL_SINGLETON_hash_elem_t;
}
public static Imm NL_SINGLETON_hash_decl_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 138
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("hash_elem_t"));
___nl__1 = new ImmHash(__function_map).clone();
//line 138
___nl__1 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__1).clone();
//line 138
___nl__0 = ptd_NL.NL_arr(___nl__1).clone();

//line 138
___nl__1 = null;
//line 138
if(true) return ___nl__0;
//line 138
___nl__0 = null;
//line 138
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_hash_decl_t = null;
public static Imm NL_hash_decl_t() {
	if (value__singleton__NL_SINGLETON_hash_decl_t == null) {
		value__singleton__NL_SINGLETON_hash_decl_t = NL_SINGLETON_hash_decl_t();
	}
	return value__singleton__NL_SINGLETON_hash_decl_t;
}
public static Imm NL_SINGLETON_bin_op_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 142
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("value_t"));
___nl__2 = new ImmHash(__function_map).clone();
//line 142
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2).clone();
//line 142
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("value_t"));
___nl__3 = new ImmHash(__function_map).clone();
//line 142
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3).clone();
//line 142
___nl__4 = ptd_NL.NL_sim().clone();

//line 142
__function_map = new Dictionary<String, Imm>();
__function_map.Add("left",___nl__2);
__function_map.Add("right",___nl__3);
__function_map.Add("op",___nl__4);
___nl__1 = new ImmHash(__function_map).clone();
//line 142
___nl__2 = null;
//line 142
___nl__3 = null;
//line 142
___nl__4 = null;
//line 142
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 142
___nl__1 = null;
//line 142
if(true) return ___nl__0;
//line 142
___nl__0 = null;
//line 142
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_bin_op_t = null;
public static Imm NL_bin_op_t() {
	if (value__singleton__NL_SINGLETON_bin_op_t == null) {
		value__singleton__NL_SINGLETON_bin_op_t = NL_SINGLETON_bin_op_t();
	}
	return value__singleton__NL_SINGLETON_bin_op_t;
}
public static Imm NL_SINGLETON_var_op_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Dictionary<String, Imm> __function_map;
//line 145
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("value_t"));
___nl__2 = new ImmHash(__function_map).clone();
//line 145
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2).clone();
//line 145
___nl__5 = ptd_NL.NL_none().clone();

//line 145
___nl__6 = ptd_NL.NL_none().clone();

//line 145
__function_map = new Dictionary<String, Imm>();
__function_map.Add("ov_is",___nl__5);
__function_map.Add("ov_as",___nl__6);
___nl__4 = new ImmHash(__function_map).clone();
//line 145
___nl__5 = null;
//line 145
___nl__6 = null;
//line 145
___nl__3 = ptd_NL.NL_var(___nl__4).clone();

//line 145
___nl__4 = null;
//line 145
___nl__4 = ptd_NL.NL_sim().clone();

//line 145
__function_map = new Dictionary<String, Imm>();
__function_map.Add("left",___nl__2);
__function_map.Add("op",___nl__3);
__function_map.Add("case",___nl__4);
___nl__1 = new ImmHash(__function_map).clone();
//line 145
___nl__2 = null;
//line 145
___nl__3 = null;
//line 145
___nl__4 = null;
//line 145
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 145
___nl__1 = null;
//line 145
if(true) return ___nl__0;
//line 145
___nl__0 = null;
//line 145
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_var_op_t = null;
public static Imm NL_var_op_t() {
	if (value__singleton__NL_SINGLETON_var_op_t == null) {
		value__singleton__NL_SINGLETON_var_op_t = NL_SINGLETON_var_op_t();
	}
	return value__singleton__NL_SINGLETON_var_op_t;
}
public static Imm NL_SINGLETON_fun_label_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 149
___nl__2 = ptd_NL.NL_sim().clone();

//line 149
___nl__3 = ptd_NL.NL_sim().clone();

//line 149
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",___nl__2);
__function_map.Add("name",___nl__3);
___nl__1 = new ImmHash(__function_map).clone();
//line 149
___nl__2 = null;
//line 149
___nl__3 = null;
//line 149
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 149
___nl__1 = null;
//line 149
if(true) return ___nl__0;
//line 149
___nl__0 = null;
//line 149
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_fun_label_t = null;
public static Imm NL_fun_label_t() {
	if (value__singleton__NL_SINGLETON_fun_label_t == null) {
		value__singleton__NL_SINGLETON_fun_label_t = NL_SINGLETON_fun_label_t();
	}
	return value__singleton__NL_SINGLETON_fun_label_t;
}
public static Imm NL_SINGLETON_unary_op_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 153
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("value_t"));
___nl__2 = new ImmHash(__function_map).clone();
//line 153
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2).clone();
//line 153
___nl__3 = ptd_NL.NL_sim().clone();

//line 153
__function_map = new Dictionary<String, Imm>();
__function_map.Add("val",___nl__2);
__function_map.Add("op",___nl__3);
___nl__1 = new ImmHash(__function_map).clone();
//line 153
___nl__2 = null;
//line 153
___nl__3 = null;
//line 153
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 153
___nl__1 = null;
//line 153
if(true) return ___nl__0;
//line 153
___nl__0 = null;
//line 153
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_unary_op_t = null;
public static Imm NL_unary_op_t() {
	if (value__singleton__NL_SINGLETON_unary_op_t == null) {
		value__singleton__NL_SINGLETON_unary_op_t = NL_SINGLETON_unary_op_t();
	}
	return value__singleton__NL_SINGLETON_unary_op_t;
}
public static Imm NL_SINGLETON_ternary_op_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Dictionary<String, Imm> __function_map;
//line 156
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("value_t"));
___nl__2 = new ImmHash(__function_map).clone();
//line 156
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2).clone();
//line 156
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("value_t"));
___nl__3 = new ImmHash(__function_map).clone();
//line 156
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3).clone();
//line 156
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("value_t"));
___nl__4 = new ImmHash(__function_map).clone();
//line 156
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__4).clone();
//line 156
___nl__5 = ptd_NL.NL_sim().clone();

//line 156
__function_map = new Dictionary<String, Imm>();
__function_map.Add("fst",___nl__2);
__function_map.Add("snd",___nl__3);
__function_map.Add("thrd",___nl__4);
__function_map.Add("op",___nl__5);
___nl__1 = new ImmHash(__function_map).clone();
//line 156
___nl__2 = null;
//line 156
___nl__3 = null;
//line 156
___nl__4 = null;
//line 156
___nl__5 = null;
//line 156
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 156
___nl__1 = null;
//line 156
if(true) return ___nl__0;
//line 156
___nl__0 = null;
//line 156
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_ternary_op_t = null;
public static Imm NL_ternary_op_t() {
	if (value__singleton__NL_SINGLETON_ternary_op_t == null) {
		value__singleton__NL_SINGLETON_ternary_op_t = NL_SINGLETON_ternary_op_t();
	}
	return value__singleton__NL_SINGLETON_ternary_op_t;
}
public static Imm NL_SINGLETON_value_t() {

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
Dictionary<String, Imm> __function_map;
//line 165
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("ternary_op_t"));
___nl__2 = new ImmHash(__function_map).clone();
//line 165
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2).clone();
//line 165
___nl__3 = ptd_NL.NL_sim().clone();

//line 165
___nl__4 = ptd_NL.NL_none().clone();

//line 165
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("value_t"));
___nl__5 = new ImmHash(__function_map).clone();
//line 165
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__5).clone();
//line 165
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("variant_t"));
___nl__6 = new ImmHash(__function_map).clone();
//line 165
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__6).clone();
//line 165
___nl__7 = ptd_NL.NL_sim().clone();

//line 165
___nl__11 = ptd_NL.NL_sim().clone();

//line 165
___nl__10 = ptd_NL.NL_arr(___nl__11).clone();

//line 165
___nl__11 = null;
//line 165
___nl__13 = ptd_NL.NL_none().clone();

//line 165
___nl__14 = ptd_NL.NL_none().clone();

//line 165
__function_map = new Dictionary<String, Imm>();
__function_map.Add("end",___nl__13);
__function_map.Add("new_line",___nl__14);
___nl__12 = new ImmHash(__function_map).clone();
//line 165
___nl__13 = null;
//line 165
___nl__14 = null;
//line 165
___nl__11 = ptd_NL.NL_var(___nl__12).clone();

//line 165
___nl__12 = null;
//line 165
__function_map = new Dictionary<String, Imm>();
__function_map.Add("arr",___nl__10);
__function_map.Add("last",___nl__11);
___nl__9 = new ImmHash(__function_map).clone();
//line 165
___nl__10 = null;
//line 165
___nl__11 = null;
//line 165
___nl__8 = ptd_NL.NL_rec(___nl__9).clone();

//line 165
___nl__9 = null;
//line 165
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("value_t"));
___nl__10 = new ImmHash(__function_map).clone();
//line 165
___nl__10 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__10).clone();
//line 165
___nl__9 = ptd_NL.NL_arr(___nl__10).clone();

//line 165
___nl__10 = null;
//line 165
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("hash_decl_t"));
___nl__10 = new ImmHash(__function_map).clone();
//line 165
___nl__10 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__10).clone();
//line 165
___nl__11 = ptd_NL.NL_sim().clone();

//line 165
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("bin_op_t"));
___nl__12 = new ImmHash(__function_map).clone();
//line 165
___nl__12 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__12).clone();
//line 165
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("var_op_t"));
___nl__13 = new ImmHash(__function_map).clone();
//line 165
___nl__13 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__13).clone();
//line 165
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("unary_op_t"));
___nl__14 = new ImmHash(__function_map).clone();
//line 165
___nl__14 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__14).clone();
//line 165
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("fun_label_t"));
___nl__15 = new ImmHash(__function_map).clone();
//line 165
___nl__15 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__15).clone();
//line 165
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("fun_val_t"));
___nl__16 = new ImmHash(__function_map).clone();
//line 165
___nl__16 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__16).clone();
//line 165
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("value_t"));
___nl__17 = new ImmHash(__function_map).clone();
//line 165
___nl__17 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__17).clone();
//line 165
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("value_t"));
___nl__18 = new ImmHash(__function_map).clone();
//line 165
___nl__18 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__18).clone();
//line 165
__function_map = new Dictionary<String, Imm>();
__function_map.Add("ternary_op",___nl__2);
__function_map.Add("hash_key",___nl__3);
__function_map.Add("nop",___nl__4);
__function_map.Add("parenthesis",___nl__5);
__function_map.Add("variant",___nl__6);
__function_map.Add("const",___nl__7);
__function_map.Add("string",___nl__8);
__function_map.Add("arr_decl",___nl__9);
__function_map.Add("hash_decl",___nl__10);
__function_map.Add("var",___nl__11);
__function_map.Add("bin_op",___nl__12);
__function_map.Add("var_op",___nl__13);
__function_map.Add("unary_op",___nl__14);
__function_map.Add("fun_label",___nl__15);
__function_map.Add("fun_val",___nl__16);
__function_map.Add("post_inc",___nl__17);
__function_map.Add("post_dec",___nl__18);
___nl__1 = new ImmHash(__function_map).clone();
//line 165
___nl__2 = null;
//line 165
___nl__3 = null;
//line 165
___nl__4 = null;
//line 165
___nl__5 = null;
//line 165
___nl__6 = null;
//line 165
___nl__7 = null;
//line 165
___nl__8 = null;
//line 165
___nl__9 = null;
//line 165
___nl__10 = null;
//line 165
___nl__11 = null;
//line 165
___nl__12 = null;
//line 165
___nl__13 = null;
//line 165
___nl__14 = null;
//line 165
___nl__15 = null;
//line 165
___nl__16 = null;
//line 165
___nl__17 = null;
//line 165
___nl__18 = null;
//line 165
___nl__0 = ptd_NL.NL_var(___nl__1).clone();

//line 165
___nl__1 = null;
//line 165
if(true) return ___nl__0;
//line 165
___nl__0 = null;
//line 165
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_value_t = null;
public static Imm NL_value_t() {
	if (value__singleton__NL_SINGLETON_value_t == null) {
		value__singleton__NL_SINGLETON_value_t = NL_SINGLETON_value_t();
	}
	return value__singleton__NL_SINGLETON_value_t;
}
public static Imm NL_SINGLETON_match_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 190
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("value_t"));
___nl__2 = new ImmHash(__function_map).clone();
//line 190
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2).clone();
//line 190
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("match_branch_t"));
___nl__4 = new ImmHash(__function_map).clone();
//line 190
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__4).clone();
//line 190
___nl__3 = ptd_NL.NL_arr(___nl__4).clone();

//line 190
___nl__4 = null;
//line 190
__function_map = new Dictionary<String, Imm>();
__function_map.Add("val",___nl__2);
__function_map.Add("branch_list",___nl__3);
___nl__1 = new ImmHash(__function_map).clone();
//line 190
___nl__2 = null;
//line 190
___nl__3 = null;
//line 190
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 190
___nl__1 = null;
//line 190
if(true) return ___nl__0;
//line 190
___nl__0 = null;
//line 190
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_match_t = null;
public static Imm NL_match_t() {
	if (value__singleton__NL_SINGLETON_match_t == null) {
		value__singleton__NL_SINGLETON_match_t = NL_SINGLETON_match_t();
	}
	return value__singleton__NL_SINGLETON_match_t;
}
public static Imm NL_SINGLETON_variant_decl_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Dictionary<String, Imm> __function_map;
//line 194
___nl__2 = ptd_NL.NL_sim().clone();

//line 194
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("variable_declaration_t"));
___nl__5 = new ImmHash(__function_map).clone();
//line 194
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__5).clone();
//line 194
___nl__6 = ptd_NL.NL_none().clone();

//line 194
__function_map = new Dictionary<String, Imm>();
__function_map.Add("value",___nl__5);
__function_map.Add("none",___nl__6);
___nl__4 = new ImmHash(__function_map).clone();
//line 194
___nl__5 = null;
//line 194
___nl__6 = null;
//line 194
___nl__3 = ptd_NL.NL_var(___nl__4).clone();

//line 194
___nl__4 = null;
//line 194
__function_map = new Dictionary<String, Imm>();
__function_map.Add("name",___nl__2);
__function_map.Add("value",___nl__3);
___nl__1 = new ImmHash(__function_map).clone();
//line 194
___nl__2 = null;
//line 194
___nl__3 = null;
//line 194
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 194
___nl__1 = null;
//line 194
if(true) return ___nl__0;
//line 194
___nl__0 = null;
//line 194
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_variant_decl_t = null;
public static Imm NL_variant_decl_t() {
	if (value__singleton__NL_SINGLETON_variant_decl_t == null) {
		value__singleton__NL_SINGLETON_variant_decl_t = NL_SINGLETON_variant_decl_t();
	}
	return value__singleton__NL_SINGLETON_variant_decl_t;
}
public static Imm NL_SINGLETON_match_branch_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 201
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("variant_decl_t"));
___nl__2 = new ImmHash(__function_map).clone();
//line 201
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2).clone();
//line 201
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("cmd_t"));
___nl__3 = new ImmHash(__function_map).clone();
//line 201
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3).clone();
//line 201
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("debug_t"));
___nl__4 = new ImmHash(__function_map).clone();
//line 201
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__4).clone();
//line 201
__function_map = new Dictionary<String, Imm>();
__function_map.Add("variant",___nl__2);
__function_map.Add("cmd",___nl__3);
__function_map.Add("debug",___nl__4);
___nl__1 = new ImmHash(__function_map).clone();
//line 201
___nl__2 = null;
//line 201
___nl__3 = null;
//line 201
___nl__4 = null;
//line 201
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 201
___nl__1 = null;
//line 201
if(true) return ___nl__0;
//line 201
___nl__0 = null;
//line 201
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_match_branch_t = null;
public static Imm NL_match_branch_t() {
	if (value__singleton__NL_SINGLETON_match_branch_t == null) {
		value__singleton__NL_SINGLETON_match_branch_t = NL_SINGLETON_match_branch_t();
	}
	return value__singleton__NL_SINGLETON_match_branch_t;
}
public static Imm NL_SINGLETON_fora_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Dictionary<String, Imm> __function_map;
//line 205
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("variable_declaration_t"));
___nl__2 = new ImmHash(__function_map).clone();
//line 205
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2).clone();
//line 205
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("cmd_t"));
___nl__3 = new ImmHash(__function_map).clone();
//line 205
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3).clone();
//line 205
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("value_t"));
___nl__4 = new ImmHash(__function_map).clone();
//line 205
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__4).clone();
//line 205
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("bool_t"));
___nl__5 = new ImmHash(__function_map).clone();
//line 205
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__5).clone();
//line 205
__function_map = new Dictionary<String, Imm>();
__function_map.Add("iter",___nl__2);
__function_map.Add("cmd",___nl__3);
__function_map.Add("array",___nl__4);
__function_map.Add("short",___nl__5);
___nl__1 = new ImmHash(__function_map).clone();
//line 205
___nl__2 = null;
//line 205
___nl__3 = null;
//line 205
___nl__4 = null;
//line 205
___nl__5 = null;
//line 205
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 205
___nl__1 = null;
//line 205
if(true) return ___nl__0;
//line 205
___nl__0 = null;
//line 205
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_fora_t = null;
public static Imm NL_fora_t() {
	if (value__singleton__NL_SINGLETON_fora_t == null) {
		value__singleton__NL_SINGLETON_fora_t = NL_SINGLETON_fora_t();
	}
	return value__singleton__NL_SINGLETON_fora_t;
}
public static Imm NL_SINGLETON_forh_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Dictionary<String, Imm> __function_map;
//line 214
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("variable_declaration_t"));
___nl__2 = new ImmHash(__function_map).clone();
//line 214
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2).clone();
//line 214
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("variable_declaration_t"));
___nl__3 = new ImmHash(__function_map).clone();
//line 214
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3).clone();
//line 214
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("value_t"));
___nl__4 = new ImmHash(__function_map).clone();
//line 214
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__4).clone();
//line 214
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("cmd_t"));
___nl__5 = new ImmHash(__function_map).clone();
//line 214
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__5).clone();
//line 214
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("bool_t"));
___nl__6 = new ImmHash(__function_map).clone();
//line 214
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__6).clone();
//line 214
__function_map = new Dictionary<String, Imm>();
__function_map.Add("key",___nl__2);
__function_map.Add("val",___nl__3);
__function_map.Add("hash",___nl__4);
__function_map.Add("cmd",___nl__5);
__function_map.Add("short",___nl__6);
___nl__1 = new ImmHash(__function_map).clone();
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
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 214
___nl__1 = null;
//line 214
if(true) return ___nl__0;
//line 214
___nl__0 = null;
//line 214
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_forh_t = null;
public static Imm NL_forh_t() {
	if (value__singleton__NL_SINGLETON_forh_t == null) {
		value__singleton__NL_SINGLETON_forh_t = NL_SINGLETON_forh_t();
	}
	return value__singleton__NL_SINGLETON_forh_t;
}
public static Imm NL_SINGLETON_rep_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Dictionary<String, Imm> __function_map;
//line 224
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("variable_declaration_t"));
___nl__2 = new ImmHash(__function_map).clone();
//line 224
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2).clone();
//line 224
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("cmd_t"));
___nl__3 = new ImmHash(__function_map).clone();
//line 224
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3).clone();
//line 224
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("value_t"));
___nl__4 = new ImmHash(__function_map).clone();
//line 224
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__4).clone();
//line 224
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("bool_t"));
___nl__5 = new ImmHash(__function_map).clone();
//line 224
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__5).clone();
//line 224
__function_map = new Dictionary<String, Imm>();
__function_map.Add("iter",___nl__2);
__function_map.Add("cmd",___nl__3);
__function_map.Add("count",___nl__4);
__function_map.Add("short",___nl__5);
___nl__1 = new ImmHash(__function_map).clone();
//line 224
___nl__2 = null;
//line 224
___nl__3 = null;
//line 224
___nl__4 = null;
//line 224
___nl__5 = null;
//line 224
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 224
___nl__1 = null;
//line 224
if(true) return ___nl__0;
//line 224
___nl__0 = null;
//line 224
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_rep_t = null;
public static Imm NL_rep_t() {
	if (value__singleton__NL_SINGLETON_rep_t == null) {
		value__singleton__NL_SINGLETON_rep_t = NL_SINGLETON_rep_t();
	}
	return value__singleton__NL_SINGLETON_rep_t;
}
public static Imm NL_SINGLETON_while_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 233
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("value_t"));
___nl__2 = new ImmHash(__function_map).clone();
//line 233
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2).clone();
//line 233
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("cmd_t"));
___nl__3 = new ImmHash(__function_map).clone();
//line 233
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3).clone();
//line 233
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("bool_t"));
___nl__4 = new ImmHash(__function_map).clone();
//line 233
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__4).clone();
//line 233
__function_map = new Dictionary<String, Imm>();
__function_map.Add("cond",___nl__2);
__function_map.Add("cmd",___nl__3);
__function_map.Add("short",___nl__4);
___nl__1 = new ImmHash(__function_map).clone();
//line 233
___nl__2 = null;
//line 233
___nl__3 = null;
//line 233
___nl__4 = null;
//line 233
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 233
___nl__1 = null;
//line 233
if(true) return ___nl__0;
//line 233
___nl__0 = null;
//line 233
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_while_t = null;
public static Imm NL_while_t() {
	if (value__singleton__NL_SINGLETON_while_t == null) {
		value__singleton__NL_SINGLETON_while_t = NL_SINGLETON_while_t();
	}
	return value__singleton__NL_SINGLETON_while_t;
}
public static Imm NL_SINGLETON_try_ensure_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 237
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("variable_declaration_t"));
___nl__2 = new ImmHash(__function_map).clone();
//line 237
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2).clone();
//line 237
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("bin_op_t"));
___nl__3 = new ImmHash(__function_map).clone();
//line 237
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3).clone();
//line 237
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("value_t"));
___nl__4 = new ImmHash(__function_map).clone();
//line 237
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__4).clone();
//line 237
__function_map = new Dictionary<String, Imm>();
__function_map.Add("decl",___nl__2);
__function_map.Add("lval",___nl__3);
__function_map.Add("expr",___nl__4);
___nl__1 = new ImmHash(__function_map).clone();
//line 237
___nl__2 = null;
//line 237
___nl__3 = null;
//line 237
___nl__4 = null;
//line 237
___nl__0 = ptd_NL.NL_var(___nl__1).clone();

//line 237
___nl__1 = null;
//line 237
if(true) return ___nl__0;
//line 237
___nl__0 = null;
//line 237
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_try_ensure_t = null;
public static Imm NL_try_ensure_t() {
	if (value__singleton__NL_SINGLETON_try_ensure_t == null) {
		value__singleton__NL_SINGLETON_try_ensure_t = NL_SINGLETON_try_ensure_t();
	}
	return value__singleton__NL_SINGLETON_try_ensure_t;
}
public static Imm NL_SINGLETON_if_t() {

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
//line 240
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("value_t"));
___nl__2 = new ImmHash(__function_map).clone();
//line 240
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2).clone();
//line 240
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("cmd_t"));
___nl__3 = new ImmHash(__function_map).clone();
//line 240
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3).clone();
//line 240
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("value_t"));
___nl__7 = new ImmHash(__function_map).clone();
//line 240
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__7).clone();
//line 240
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("cmd_t"));
___nl__8 = new ImmHash(__function_map).clone();
//line 240
___nl__8 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__8).clone();
//line 240
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("debug_t"));
___nl__9 = new ImmHash(__function_map).clone();
//line 240
___nl__9 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__9).clone();
//line 240
__function_map = new Dictionary<String, Imm>();
__function_map.Add("cond",___nl__7);
__function_map.Add("cmd",___nl__8);
__function_map.Add("debug",___nl__9);
___nl__6 = new ImmHash(__function_map).clone();
//line 240
___nl__7 = null;
//line 240
___nl__8 = null;
//line 240
___nl__9 = null;
//line 240
___nl__5 = ptd_NL.NL_rec(___nl__6).clone();

//line 240
___nl__6 = null;
//line 240
___nl__4 = ptd_NL.NL_arr(___nl__5).clone();

//line 240
___nl__5 = null;
//line 240
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("cmd_t"));
___nl__5 = new ImmHash(__function_map).clone();
//line 240
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__5).clone();
//line 240
__function_map = new Dictionary<String, Imm>();
__function_map.Add("cond",___nl__2);
__function_map.Add("if",___nl__3);
__function_map.Add("elsif",___nl__4);
__function_map.Add("else",___nl__5);
___nl__1 = new ImmHash(__function_map).clone();
//line 240
___nl__2 = null;
//line 240
___nl__3 = null;
//line 240
___nl__4 = null;
//line 240
___nl__5 = null;
//line 240
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 240
___nl__1 = null;
//line 240
if(true) return ___nl__0;
//line 240
___nl__0 = null;
//line 240
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_if_t = null;
public static Imm NL_if_t() {
	if (value__singleton__NL_SINGLETON_if_t == null) {
		value__singleton__NL_SINGLETON_if_t = NL_SINGLETON_if_t();
	}
	return value__singleton__NL_SINGLETON_if_t;
}
public static Imm NL_SINGLETON_for_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Dictionary<String, Imm> __function_map;
//line 249
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("variable_declaration_t"));
___nl__4 = new ImmHash(__function_map).clone();
//line 249
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__4).clone();
//line 249
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("value_t"));
___nl__5 = new ImmHash(__function_map).clone();
//line 249
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__5).clone();
//line 249
__function_map = new Dictionary<String, Imm>();
__function_map.Add("var_decl",___nl__4);
__function_map.Add("value",___nl__5);
___nl__3 = new ImmHash(__function_map).clone();
//line 249
___nl__4 = null;
//line 249
___nl__5 = null;
//line 249
___nl__2 = ptd_NL.NL_var(___nl__3).clone();

//line 249
___nl__3 = null;
//line 249
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("value_t"));
___nl__3 = new ImmHash(__function_map).clone();
//line 249
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3).clone();
//line 249
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("value_t"));
___nl__4 = new ImmHash(__function_map).clone();
//line 249
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__4).clone();
//line 249
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("cmd_t"));
___nl__5 = new ImmHash(__function_map).clone();
//line 249
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__5).clone();
//line 249
__function_map = new Dictionary<String, Imm>();
__function_map.Add("start",___nl__2);
__function_map.Add("iter",___nl__3);
__function_map.Add("cond",___nl__4);
__function_map.Add("cmd",___nl__5);
___nl__1 = new ImmHash(__function_map).clone();
//line 249
___nl__2 = null;
//line 249
___nl__3 = null;
//line 249
___nl__4 = null;
//line 249
___nl__5 = null;
//line 249
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 249
___nl__1 = null;
//line 249
if(true) return ___nl__0;
//line 249
___nl__0 = null;
//line 249
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_for_t = null;
public static Imm NL_for_t() {
	if (value__singleton__NL_SINGLETON_for_t == null) {
		value__singleton__NL_SINGLETON_for_t = NL_SINGLETON_for_t();
	}
	return value__singleton__NL_SINGLETON_for_t;
}
public static Imm NL_SINGLETON_place_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 258
___nl__2 = ptd_NL.NL_sim().clone();

//line 258
___nl__3 = ptd_NL.NL_sim().clone();

//line 258
__function_map = new Dictionary<String, Imm>();
__function_map.Add("line",___nl__2);
__function_map.Add("position",___nl__3);
___nl__1 = new ImmHash(__function_map).clone();
//line 258
___nl__2 = null;
//line 258
___nl__3 = null;
//line 258
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 258
___nl__1 = null;
//line 258
if(true) return ___nl__0;
//line 258
___nl__0 = null;
//line 258
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_place_t = null;
public static Imm NL_place_t() {
	if (value__singleton__NL_SINGLETON_place_t == null) {
		value__singleton__NL_SINGLETON_place_t = NL_SINGLETON_place_t();
	}
	return value__singleton__NL_SINGLETON_place_t;
}
public static Imm NL_SINGLETON_debug_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 265
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("place_t"));
___nl__2 = new ImmHash(__function_map).clone();
//line 265
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2).clone();
//line 265
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("place_t"));
___nl__3 = new ImmHash(__function_map).clone();
//line 265
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3).clone();
//line 265
__function_map = new Dictionary<String, Imm>();
__function_map.Add("begin",___nl__2);
__function_map.Add("end",___nl__3);
___nl__1 = new ImmHash(__function_map).clone();
//line 265
___nl__2 = null;
//line 265
___nl__3 = null;
//line 265
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 265
___nl__1 = null;
//line 265
if(true) return ___nl__0;
//line 265
___nl__0 = null;
//line 265
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
Imm ___nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 272
___nl__2 = new ImmDouble(1).clone();
//line 272
___nl__3 = new ImmDouble(1).clone();
//line 272
__function_map = new Dictionary<String, Imm>();
__function_map.Add("line",___nl__2);
__function_map.Add("position",___nl__3);
___nl__1 = new ImmHash(__function_map).clone();
//line 272
___nl__2 = null;
//line 272
___nl__3 = null;
//line 272
___nl__3 = new ImmDouble(1).clone();
//line 272
___nl__4 = new ImmDouble(1).clone();
//line 272
__function_map = new Dictionary<String, Imm>();
__function_map.Add("line",___nl__3);
__function_map.Add("position",___nl__4);
___nl__2 = new ImmHash(__function_map).clone();
//line 272
___nl__3 = null;
//line 272
___nl__4 = null;
//line 272
__function_map = new Dictionary<String, Imm>();
__function_map.Add("begin",___nl__1);
__function_map.Add("end",___nl__2);
___nl__0 = new ImmHash(__function_map).clone();
//line 272
___nl__1 = null;
//line 272
___nl__2 = null;
//line 272
if(true) return ___nl__0;
//line 272
___nl__0 = null;
//line 272
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
Dictionary<String, Imm> __function_map;
//line 276
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("debug_t"));
___nl__2 = new ImmHash(__function_map).clone();
//line 276
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2).clone();
//line 276
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("if_t"));
___nl__5 = new ImmHash(__function_map).clone();
//line 276
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__5).clone();
//line 276
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("for_t"));
___nl__6 = new ImmHash(__function_map).clone();
//line 276
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__6).clone();
//line 276
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("fora_t"));
___nl__7 = new ImmHash(__function_map).clone();
//line 276
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__7).clone();
//line 276
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("forh_t"));
___nl__8 = new ImmHash(__function_map).clone();
//line 276
___nl__8 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__8).clone();
//line 276
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("cmd_t"));
___nl__9 = new ImmHash(__function_map).clone();
//line 276
___nl__9 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__9).clone();
//line 276
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("rep_t"));
___nl__10 = new ImmHash(__function_map).clone();
//line 276
___nl__10 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__10).clone();
//line 276
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("while_t"));
___nl__11 = new ImmHash(__function_map).clone();
//line 276
___nl__11 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__11).clone();
//line 276
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("value_t"));
___nl__14 = new ImmHash(__function_map).clone();
//line 276
___nl__14 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__14).clone();
//line 276
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("cmd_t"));
___nl__15 = new ImmHash(__function_map).clone();
//line 276
___nl__15 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__15).clone();
//line 276
__function_map = new Dictionary<String, Imm>();
__function_map.Add("cond",___nl__14);
__function_map.Add("cmd",___nl__15);
___nl__13 = new ImmHash(__function_map).clone();
//line 276
___nl__14 = null;
//line 276
___nl__15 = null;
//line 276
___nl__12 = ptd_NL.NL_rec(___nl__13).clone();

//line 276
___nl__13 = null;
//line 276
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("value_t"));
___nl__15 = new ImmHash(__function_map).clone();
//line 276
___nl__15 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__15).clone();
//line 276
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("cmd_t"));
___nl__16 = new ImmHash(__function_map).clone();
//line 276
___nl__16 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__16).clone();
//line 276
__function_map = new Dictionary<String, Imm>();
__function_map.Add("cond",___nl__15);
__function_map.Add("cmd",___nl__16);
___nl__14 = new ImmHash(__function_map).clone();
//line 276
___nl__15 = null;
//line 276
___nl__16 = null;
//line 276
___nl__13 = ptd_NL.NL_rec(___nl__14).clone();

//line 276
___nl__14 = null;
//line 276
___nl__14 = ptd_NL.NL_none().clone();

//line 276
___nl__15 = ptd_NL.NL_none().clone();

//line 276
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("match_t"));
___nl__16 = new ImmHash(__function_map).clone();
//line 276
___nl__16 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__16).clone();
//line 276
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("value_t"));
___nl__17 = new ImmHash(__function_map).clone();
//line 276
___nl__17 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__17).clone();
//line 276
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("try_ensure_t"));
___nl__18 = new ImmHash(__function_map).clone();
//line 276
___nl__18 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__18).clone();
//line 276
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("try_ensure_t"));
___nl__19 = new ImmHash(__function_map).clone();
//line 276
___nl__19 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__19).clone();
//line 276
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("variable_declaration_t"));
___nl__20 = new ImmHash(__function_map).clone();
//line 276
___nl__20 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__20).clone();
//line 276
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("value_t"));
___nl__21 = new ImmHash(__function_map).clone();
//line 276
___nl__21 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__21).clone();
//line 276
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("cmd_t"));
___nl__23 = new ImmHash(__function_map).clone();
//line 276
___nl__23 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__23).clone();
//line 276
___nl__22 = ptd_NL.NL_arr(___nl__23).clone();

//line 276
___nl__23 = null;
//line 276
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("value_t"));
___nl__24 = new ImmHash(__function_map).clone();
//line 276
___nl__24 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__24).clone();
//line 276
___nl__23 = ptd_NL.NL_arr(___nl__24).clone();

//line 276
___nl__24 = null;
//line 276
___nl__24 = ptd_NL.NL_none().clone();

//line 276
__function_map = new Dictionary<String, Imm>();
__function_map.Add("if",___nl__5);
__function_map.Add("for",___nl__6);
__function_map.Add("fora",___nl__7);
__function_map.Add("forh",___nl__8);
__function_map.Add("loop",___nl__9);
__function_map.Add("rep",___nl__10);
__function_map.Add("while",___nl__11);
__function_map.Add("if_mod",___nl__12);
__function_map.Add("unless_mod",___nl__13);
__function_map.Add("break",___nl__14);
__function_map.Add("continue",___nl__15);
__function_map.Add("match",___nl__16);
__function_map.Add("value",___nl__17);
__function_map.Add("try",___nl__18);
__function_map.Add("ensure",___nl__19);
__function_map.Add("var_decl",___nl__20);
__function_map.Add("return",___nl__21);
__function_map.Add("block",___nl__22);
__function_map.Add("die",___nl__23);
__function_map.Add("nop",___nl__24);
___nl__4 = new ImmHash(__function_map).clone();
//line 276
___nl__5 = null;
//line 276
___nl__6 = null;
//line 276
___nl__7 = null;
//line 276
___nl__8 = null;
//line 276
___nl__9 = null;
//line 276
___nl__10 = null;
//line 276
___nl__11 = null;
//line 276
___nl__12 = null;
//line 276
___nl__13 = null;
//line 276
___nl__14 = null;
//line 276
___nl__15 = null;
//line 276
___nl__16 = null;
//line 276
___nl__17 = null;
//line 276
___nl__18 = null;
//line 276
___nl__19 = null;
//line 276
___nl__20 = null;
//line 276
___nl__21 = null;
//line 276
___nl__22 = null;
//line 276
___nl__23 = null;
//line 276
___nl__24 = null;
//line 276
___nl__3 = ptd_NL.NL_var(___nl__4).clone();

//line 276
___nl__4 = null;
//line 276
__function_map = new Dictionary<String, Imm>();
__function_map.Add("debug",___nl__2);
__function_map.Add("cmd",___nl__3);
___nl__1 = new ImmHash(__function_map).clone();
//line 276
___nl__2 = null;
//line 276
___nl__3 = null;
//line 276
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 276
___nl__1 = null;
//line 276
if(true) return ___nl__0;
//line 276
___nl__0 = null;
//line 276
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_cmd_t = null;
public static Imm NL_cmd_t() {
	if (value__singleton__NL_SINGLETON_cmd_t == null) {
		value__singleton__NL_SINGLETON_cmd_t = NL_SINGLETON_cmd_t();
	}
	return value__singleton__NL_SINGLETON_cmd_t;
}
}
}