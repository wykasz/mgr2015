using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class test_nl_NL {

private static Imm NL_p_priv(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 20
___nl__1 = new ImmString("Test ").clone();
//line 20
___nl__1 = new ImmString(___nl__1.toString() + ___nl__0.toString()).clone();
//line 20
___nl__2 = string_NL.NL_lf().clone();

//line 20
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 20
___nl__2 = null;
//line 20
nl_NL.NL_print(___nl__1);

//line 20
___nl__1 = null;
//line 20
___nl__0 = null;
//line 20
if(true) return null;
}

public static Imm NL_test() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 24
___nl__0 = new ImmString("test_nl").clone();
//line 24
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("test_nl_NL"));
__function_map.Add("name",new ImmString("all"));
___nl__1 = new ImmHash(__function_map).clone();
//line 24
___nl__1 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__1).clone();
//line 24
___nl__2 = new ImmArray(new Imm[0]).clone();
//line 24
profile_NL.NL_sub(___nl__0,___nl__1,___nl__2);

//line 24
___nl__2 = null;
//line 24
___nl__1 = null;
//line 24
___nl__0 = null;
//line 24
if(true) return null;
}

public static Imm NL_all() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 27
___nl__0 = new ImmString("forh").clone();
//line 27
test_nl_NL.NL_p_priv(___nl__0);

//line 27
___nl__0 = null;
//line 28
___nl__0 = new ImmString("test_forh").clone();
//line 28
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("test_forh_NL"));
__function_map.Add("name",new ImmString("test"));
___nl__1 = new ImmHash(__function_map).clone();
//line 28
___nl__1 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__1).clone();
//line 28
___nl__2 = new ImmArray(new Imm[0]).clone();
//line 28
profile_NL.NL_sub(___nl__0,___nl__1,___nl__2);

//line 28
___nl__2 = null;
//line 28
___nl__1 = null;
//line 28
___nl__0 = null;
//line 29
___nl__0 = new ImmString("mod").clone();
//line 29
test_nl_NL.NL_p_priv(___nl__0);

//line 29
___nl__0 = null;
//line 30
___nl__0 = new ImmString("test_mod").clone();
//line 30
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("test_mod_NL"));
__function_map.Add("name",new ImmString("test"));
___nl__1 = new ImmHash(__function_map).clone();
//line 30
___nl__1 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__1).clone();
//line 30
___nl__2 = new ImmArray(new Imm[0]).clone();
//line 30
profile_NL.NL_sub(___nl__0,___nl__1,___nl__2);

//line 30
___nl__2 = null;
//line 30
___nl__1 = null;
//line 30
___nl__0 = null;
//line 31
___nl__0 = new ImmString("num").clone();
//line 31
test_nl_NL.NL_p_priv(___nl__0);

//line 31
___nl__0 = null;
//line 32
___nl__0 = new ImmString("test_num").clone();
//line 32
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("test_num_NL"));
__function_map.Add("name",new ImmString("test"));
___nl__1 = new ImmHash(__function_map).clone();
//line 32
___nl__1 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__1).clone();
//line 32
___nl__2 = new ImmArray(new Imm[0]).clone();
//line 32
profile_NL.NL_sub(___nl__0,___nl__1,___nl__2);

//line 32
___nl__2 = null;
//line 32
___nl__1 = null;
//line 32
___nl__0 = null;
//line 33
___nl__0 = new ImmString("op").clone();
//line 33
test_nl_NL.NL_p_priv(___nl__0);

//line 33
___nl__0 = null;
//line 34
___nl__0 = new ImmString("test_op").clone();
//line 34
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("test_op_NL"));
__function_map.Add("name",new ImmString("test"));
___nl__1 = new ImmHash(__function_map).clone();
//line 34
___nl__1 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__1).clone();
//line 34
___nl__2 = new ImmArray(new Imm[0]).clone();
//line 34
profile_NL.NL_sub(___nl__0,___nl__1,___nl__2);

//line 34
___nl__2 = null;
//line 34
___nl__1 = null;
//line 34
___nl__0 = null;
//line 35
___nl__0 = new ImmString("pub").clone();
//line 35
test_nl_NL.NL_p_priv(___nl__0);

//line 35
___nl__0 = null;
//line 36
___nl__0 = new ImmString("test_pub").clone();
//line 36
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("test_pub_NL"));
__function_map.Add("name",new ImmString("test"));
___nl__1 = new ImmHash(__function_map).clone();
//line 36
___nl__1 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__1).clone();
//line 36
___nl__2 = new ImmArray(new Imm[0]).clone();
//line 36
profile_NL.NL_sub(___nl__0,___nl__1,___nl__2);

//line 36
___nl__2 = null;
//line 36
___nl__1 = null;
//line 36
___nl__0 = null;
//line 37
___nl__0 = new ImmString("ref").clone();
//line 37
test_nl_NL.NL_p_priv(___nl__0);

//line 37
___nl__0 = null;
//line 38
___nl__0 = new ImmString("test_ref").clone();
//line 38
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("test_ref_NL"));
__function_map.Add("name",new ImmString("test"));
___nl__1 = new ImmHash(__function_map).clone();
//line 38
___nl__1 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__1).clone();
//line 38
___nl__2 = new ImmArray(new Imm[0]).clone();
//line 38
profile_NL.NL_sub(___nl__0,___nl__1,___nl__2);

//line 38
___nl__2 = null;
//line 38
___nl__1 = null;
//line 38
___nl__0 = null;
//line 39
___nl__0 = new ImmString("str").clone();
//line 39
test_nl_NL.NL_p_priv(___nl__0);

//line 39
___nl__0 = null;
//line 40
___nl__0 = new ImmString("test_str").clone();
//line 40
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("test_str_NL"));
__function_map.Add("name",new ImmString("test"));
___nl__1 = new ImmHash(__function_map).clone();
//line 40
___nl__1 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__1).clone();
//line 40
___nl__2 = new ImmArray(new Imm[0]).clone();
//line 40
profile_NL.NL_sub(___nl__0,___nl__1,___nl__2);

//line 40
___nl__2 = null;
//line 40
___nl__1 = null;
//line 40
___nl__0 = null;
//line 41
___nl__0 = new ImmString("type").clone();
//line 41
test_nl_NL.NL_p_priv(___nl__0);

//line 41
___nl__0 = null;
//line 42
___nl__0 = new ImmString("test_type").clone();
//line 42
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("test_type_NL"));
__function_map.Add("name",new ImmString("test"));
___nl__1 = new ImmHash(__function_map).clone();
//line 42
___nl__1 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__1).clone();
//line 42
___nl__2 = new ImmArray(new Imm[0]).clone();
//line 42
profile_NL.NL_sub(___nl__0,___nl__1,___nl__2);

//line 42
___nl__2 = null;
//line 42
___nl__1 = null;
//line 42
___nl__0 = null;
//line 43
___nl__0 = new ImmString("function").clone();
//line 43
test_nl_NL.NL_p_priv(___nl__0);

//line 43
___nl__0 = null;
//line 44
___nl__0 = new ImmString("test_fun").clone();
//line 44
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("test_fun_NL"));
__function_map.Add("name",new ImmString("test"));
___nl__1 = new ImmHash(__function_map).clone();
//line 44
___nl__1 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__1).clone();
//line 44
___nl__2 = new ImmArray(new Imm[0]).clone();
//line 44
profile_NL.NL_sub(___nl__0,___nl__1,___nl__2);

//line 44
___nl__2 = null;
//line 44
___nl__1 = null;
//line 44
___nl__0 = null;
//line 44
if(true) return null;
}

}
}