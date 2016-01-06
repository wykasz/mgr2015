using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class tc_types_NL {

private static Imm NL_op_def_priv(ImmRef ___arg__0, Imm ___arg__1, Imm ___arg__2, Imm ___arg__3, Imm ___arg__4) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();Imm ___nl__3 = ___arg__3.clone();Imm ___nl__4 = ___arg__4.clone();
Imm ___nl__5 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
Dictionary<String, Imm> __function_map;
//line 16
__function_map = new Dictionary<String, Imm>();
__function_map.Add("arg1",___nl__2);
__function_map.Add("arg2",___nl__3);
__function_map.Add("ret",___nl__4);
___nl__5 = new ImmHash(__function_map).clone();
//line 16
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__1,___nl__5);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 16
___nl__5 = null;
//line 16
___nl__1 = null;
//line 16
___nl__2 = null;
//line 16
___nl__3 = null;
//line 16
___nl__4 = null;
//line 16
___arg__0.setValue(___nl__0);if(true) return null;
}

public static Imm NL_get_bin_op_def(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 20
___nl__2 = tc_types_NL.NL_get_binary_ops_priv().clone();

//line 20
___nl__1 = hash_NL.NL_get_value(___nl__2,___nl__0).clone();

//line 20
___nl__2 = null;
//line 20
___nl__0 = null;
//line 20
if(true) return ___nl__1;
//line 20
___nl__1 = null;
//line 20
___nl__0 = null;
//line 20
if(true) return null;
}

private static Imm NL_SINGLETON_get_binary_ops_priv() {

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
//line 24
__function_map = new Dictionary<String, Imm>();
___nl__0 = new ImmHash(__function_map).clone();
//line 25
___nl__1 = new ImmString("*").clone();
//line 25
___nl__2 = tct_NL.NL_tct_sim().clone();

//line 25
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 25
___nl__4 = tct_NL.NL_tct_sim().clone();

//line 25
___ref______nl__0 = new ImmRef(___nl__0);
tc_types_NL.NL_op_def_priv(___ref______nl__0,___nl__1,___nl__2,___nl__3,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 25
___nl__4 = null;
//line 25
___nl__3 = null;
//line 25
___nl__2 = null;
//line 25
___nl__1 = null;
//line 26
___nl__1 = new ImmString("/").clone();
//line 26
___nl__2 = tct_NL.NL_tct_sim().clone();

//line 26
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 26
___nl__4 = tct_NL.NL_tct_sim().clone();

//line 26
___ref______nl__0 = new ImmRef(___nl__0);
tc_types_NL.NL_op_def_priv(___ref______nl__0,___nl__1,___nl__2,___nl__3,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 26
___nl__4 = null;
//line 26
___nl__3 = null;
//line 26
___nl__2 = null;
//line 26
___nl__1 = null;
//line 27
___nl__1 = new ImmString("%").clone();
//line 27
___nl__2 = tct_NL.NL_tct_sim().clone();

//line 27
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 27
___nl__4 = tct_NL.NL_tct_sim().clone();

//line 27
___ref______nl__0 = new ImmRef(___nl__0);
tc_types_NL.NL_op_def_priv(___ref______nl__0,___nl__1,___nl__2,___nl__3,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 27
___nl__4 = null;
//line 27
___nl__3 = null;
//line 27
___nl__2 = null;
//line 27
___nl__1 = null;
//line 28
___nl__1 = new ImmString("+").clone();
//line 28
___nl__2 = tct_NL.NL_tct_sim().clone();

//line 28
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 28
___nl__4 = tct_NL.NL_tct_sim().clone();

//line 28
___ref______nl__0 = new ImmRef(___nl__0);
tc_types_NL.NL_op_def_priv(___ref______nl__0,___nl__1,___nl__2,___nl__3,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 28
___nl__4 = null;
//line 28
___nl__3 = null;
//line 28
___nl__2 = null;
//line 28
___nl__1 = null;
//line 29
___nl__1 = new ImmString("-").clone();
//line 29
___nl__2 = tct_NL.NL_tct_sim().clone();

//line 29
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 29
___nl__4 = tct_NL.NL_tct_sim().clone();

//line 29
___ref______nl__0 = new ImmRef(___nl__0);
tc_types_NL.NL_op_def_priv(___ref______nl__0,___nl__1,___nl__2,___nl__3,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 29
___nl__4 = null;
//line 29
___nl__3 = null;
//line 29
___nl__2 = null;
//line 29
___nl__1 = null;
//line 30
___nl__1 = new ImmString(".").clone();
//line 30
___nl__2 = tct_NL.NL_tct_sim().clone();

//line 30
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 30
___nl__4 = tct_NL.NL_tct_sim().clone();

//line 30
___ref______nl__0 = new ImmRef(___nl__0);
tc_types_NL.NL_op_def_priv(___ref______nl__0,___nl__1,___nl__2,___nl__3,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 30
___nl__4 = null;
//line 30
___nl__3 = null;
//line 30
___nl__2 = null;
//line 30
___nl__1 = null;
//line 31
___nl__1 = new ImmString("<<").clone();
//line 31
___nl__2 = tct_NL.NL_tct_sim().clone();

//line 31
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 31
___nl__4 = tct_NL.NL_tct_sim().clone();

//line 31
___ref______nl__0 = new ImmRef(___nl__0);
tc_types_NL.NL_op_def_priv(___ref______nl__0,___nl__1,___nl__2,___nl__3,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 31
___nl__4 = null;
//line 31
___nl__3 = null;
//line 31
___nl__2 = null;
//line 31
___nl__1 = null;
//line 32
___nl__1 = new ImmString(">>").clone();
//line 32
___nl__2 = tct_NL.NL_tct_sim().clone();

//line 32
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 32
___nl__4 = tct_NL.NL_tct_sim().clone();

//line 32
___ref______nl__0 = new ImmRef(___nl__0);
tc_types_NL.NL_op_def_priv(___ref______nl__0,___nl__1,___nl__2,___nl__3,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 32
___nl__4 = null;
//line 32
___nl__3 = null;
//line 32
___nl__2 = null;
//line 32
___nl__1 = null;
//line 33
___nl__1 = new ImmString(">=").clone();
//line 33
___nl__2 = tct_NL.NL_tct_sim().clone();

//line 33
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 33
___nl__4 = tct_NL.NL_tct_bool().clone();

//line 33
___ref______nl__0 = new ImmRef(___nl__0);
tc_types_NL.NL_op_def_priv(___ref______nl__0,___nl__1,___nl__2,___nl__3,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 33
___nl__4 = null;
//line 33
___nl__3 = null;
//line 33
___nl__2 = null;
//line 33
___nl__1 = null;
//line 34
___nl__1 = new ImmString("lt").clone();
//line 34
___nl__2 = tct_NL.NL_tct_sim().clone();

//line 34
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 34
___nl__4 = tct_NL.NL_tct_bool().clone();

//line 34
___ref______nl__0 = new ImmRef(___nl__0);
tc_types_NL.NL_op_def_priv(___ref______nl__0,___nl__1,___nl__2,___nl__3,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 34
___nl__4 = null;
//line 34
___nl__3 = null;
//line 34
___nl__2 = null;
//line 34
___nl__1 = null;
//line 35
___nl__1 = new ImmString("gt").clone();
//line 35
___nl__2 = tct_NL.NL_tct_sim().clone();

//line 35
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 35
___nl__4 = tct_NL.NL_tct_bool().clone();

//line 35
___ref______nl__0 = new ImmRef(___nl__0);
tc_types_NL.NL_op_def_priv(___ref______nl__0,___nl__1,___nl__2,___nl__3,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 35
___nl__4 = null;
//line 35
___nl__3 = null;
//line 35
___nl__2 = null;
//line 35
___nl__1 = null;
//line 36
___nl__1 = new ImmString("le").clone();
//line 36
___nl__2 = tct_NL.NL_tct_sim().clone();

//line 36
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 36
___nl__4 = tct_NL.NL_tct_bool().clone();

//line 36
___ref______nl__0 = new ImmRef(___nl__0);
tc_types_NL.NL_op_def_priv(___ref______nl__0,___nl__1,___nl__2,___nl__3,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 36
___nl__4 = null;
//line 36
___nl__3 = null;
//line 36
___nl__2 = null;
//line 36
___nl__1 = null;
//line 37
___nl__1 = new ImmString("ge").clone();
//line 37
___nl__2 = tct_NL.NL_tct_sim().clone();

//line 37
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 37
___nl__4 = tct_NL.NL_tct_bool().clone();

//line 37
___ref______nl__0 = new ImmRef(___nl__0);
tc_types_NL.NL_op_def_priv(___ref______nl__0,___nl__1,___nl__2,___nl__3,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 37
___nl__4 = null;
//line 37
___nl__3 = null;
//line 37
___nl__2 = null;
//line 37
___nl__1 = null;
//line 38
___nl__1 = new ImmString("<=").clone();
//line 38
___nl__2 = tct_NL.NL_tct_sim().clone();

//line 38
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 38
___nl__4 = tct_NL.NL_tct_bool().clone();

//line 38
___ref______nl__0 = new ImmRef(___nl__0);
tc_types_NL.NL_op_def_priv(___ref______nl__0,___nl__1,___nl__2,___nl__3,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 38
___nl__4 = null;
//line 38
___nl__3 = null;
//line 38
___nl__2 = null;
//line 38
___nl__1 = null;
//line 39
___nl__1 = new ImmString("<").clone();
//line 39
___nl__2 = tct_NL.NL_tct_sim().clone();

//line 39
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 39
___nl__4 = tct_NL.NL_tct_bool().clone();

//line 39
___ref______nl__0 = new ImmRef(___nl__0);
tc_types_NL.NL_op_def_priv(___ref______nl__0,___nl__1,___nl__2,___nl__3,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 39
___nl__4 = null;
//line 39
___nl__3 = null;
//line 39
___nl__2 = null;
//line 39
___nl__1 = null;
//line 40
___nl__1 = new ImmString(">").clone();
//line 40
___nl__2 = tct_NL.NL_tct_sim().clone();

//line 40
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 40
___nl__4 = tct_NL.NL_tct_bool().clone();

//line 40
___ref______nl__0 = new ImmRef(___nl__0);
tc_types_NL.NL_op_def_priv(___ref______nl__0,___nl__1,___nl__2,___nl__3,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 40
___nl__4 = null;
//line 40
___nl__3 = null;
//line 40
___nl__2 = null;
//line 40
___nl__1 = null;
//line 41
___nl__1 = new ImmString("==").clone();
//line 41
___nl__2 = tct_NL.NL_tct_sim().clone();

//line 41
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 41
___nl__4 = tct_NL.NL_tct_bool().clone();

//line 41
___ref______nl__0 = new ImmRef(___nl__0);
tc_types_NL.NL_op_def_priv(___ref______nl__0,___nl__1,___nl__2,___nl__3,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 41
___nl__4 = null;
//line 41
___nl__3 = null;
//line 41
___nl__2 = null;
//line 41
___nl__1 = null;
//line 42
___nl__1 = new ImmString("!=").clone();
//line 42
___nl__2 = tct_NL.NL_tct_sim().clone();

//line 42
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 42
___nl__4 = tct_NL.NL_tct_bool().clone();

//line 42
___ref______nl__0 = new ImmRef(___nl__0);
tc_types_NL.NL_op_def_priv(___ref______nl__0,___nl__1,___nl__2,___nl__3,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 42
___nl__4 = null;
//line 42
___nl__3 = null;
//line 42
___nl__2 = null;
//line 42
___nl__1 = null;
//line 43
___nl__1 = new ImmString("<=>").clone();
//line 43
___nl__2 = tct_NL.NL_tct_sim().clone();

//line 43
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 43
___nl__4 = tct_NL.NL_tct_bool().clone();

//line 43
___ref______nl__0 = new ImmRef(___nl__0);
tc_types_NL.NL_op_def_priv(___ref______nl__0,___nl__1,___nl__2,___nl__3,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 43
___nl__4 = null;
//line 43
___nl__3 = null;
//line 43
___nl__2 = null;
//line 43
___nl__1 = null;
//line 44
___nl__1 = new ImmString("eq").clone();
//line 44
___nl__2 = tct_NL.NL_tct_sim().clone();

//line 44
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 44
___nl__4 = tct_NL.NL_tct_bool().clone();

//line 44
___ref______nl__0 = new ImmRef(___nl__0);
tc_types_NL.NL_op_def_priv(___ref______nl__0,___nl__1,___nl__2,___nl__3,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 44
___nl__4 = null;
//line 44
___nl__3 = null;
//line 44
___nl__2 = null;
//line 44
___nl__1 = null;
//line 45
___nl__1 = new ImmString("ne").clone();
//line 45
___nl__2 = tct_NL.NL_tct_sim().clone();

//line 45
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 45
___nl__4 = tct_NL.NL_tct_bool().clone();

//line 45
___ref______nl__0 = new ImmRef(___nl__0);
tc_types_NL.NL_op_def_priv(___ref______nl__0,___nl__1,___nl__2,___nl__3,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 45
___nl__4 = null;
//line 45
___nl__3 = null;
//line 45
___nl__2 = null;
//line 45
___nl__1 = null;
//line 46
___nl__1 = new ImmString("cmp").clone();
//line 46
___nl__2 = tct_NL.NL_tct_sim().clone();

//line 46
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 46
___nl__4 = tct_NL.NL_tct_bool().clone();

//line 46
___ref______nl__0 = new ImmRef(___nl__0);
tc_types_NL.NL_op_def_priv(___ref______nl__0,___nl__1,___nl__2,___nl__3,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 46
___nl__4 = null;
//line 46
___nl__3 = null;
//line 46
___nl__2 = null;
//line 46
___nl__1 = null;
//line 47
___nl__1 = new ImmString("&").clone();
//line 47
___nl__2 = tct_NL.NL_tct_sim().clone();

//line 47
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 47
___nl__4 = tct_NL.NL_tct_sim().clone();

//line 47
___ref______nl__0 = new ImmRef(___nl__0);
tc_types_NL.NL_op_def_priv(___ref______nl__0,___nl__1,___nl__2,___nl__3,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 47
___nl__4 = null;
//line 47
___nl__3 = null;
//line 47
___nl__2 = null;
//line 47
___nl__1 = null;
//line 48
___nl__1 = new ImmString("|").clone();
//line 48
___nl__2 = tct_NL.NL_tct_sim().clone();

//line 48
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 48
___nl__4 = tct_NL.NL_tct_sim().clone();

//line 48
___ref______nl__0 = new ImmRef(___nl__0);
tc_types_NL.NL_op_def_priv(___ref______nl__0,___nl__1,___nl__2,___nl__3,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 48
___nl__4 = null;
//line 48
___nl__3 = null;
//line 48
___nl__2 = null;
//line 48
___nl__1 = null;
//line 49
___nl__1 = new ImmString("^").clone();
//line 49
___nl__2 = tct_NL.NL_tct_sim().clone();

//line 49
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 49
___nl__4 = tct_NL.NL_tct_sim().clone();

//line 49
___ref______nl__0 = new ImmRef(___nl__0);
tc_types_NL.NL_op_def_priv(___ref______nl__0,___nl__1,___nl__2,___nl__3,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 49
___nl__4 = null;
//line 49
___nl__3 = null;
//line 49
___nl__2 = null;
//line 49
___nl__1 = null;
//line 50
___nl__1 = new ImmString("&&").clone();
//line 50
___nl__2 = tct_NL.NL_tct_bool().clone();

//line 50
___nl__3 = tct_NL.NL_tct_bool().clone();

//line 50
___nl__4 = tct_NL.NL_tct_bool().clone();

//line 50
___ref______nl__0 = new ImmRef(___nl__0);
tc_types_NL.NL_op_def_priv(___ref______nl__0,___nl__1,___nl__2,___nl__3,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 50
___nl__4 = null;
//line 50
___nl__3 = null;
//line 50
___nl__2 = null;
//line 50
___nl__1 = null;
//line 51
___nl__1 = new ImmString("||").clone();
//line 51
___nl__2 = tct_NL.NL_tct_bool().clone();

//line 51
___nl__3 = tct_NL.NL_tct_bool().clone();

//line 51
___nl__4 = tct_NL.NL_tct_bool().clone();

//line 51
___ref______nl__0 = new ImmRef(___nl__0);
tc_types_NL.NL_op_def_priv(___ref______nl__0,___nl__1,___nl__2,___nl__3,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 51
___nl__4 = null;
//line 51
___nl__3 = null;
//line 51
___nl__2 = null;
//line 51
___nl__1 = null;
//line 52
___nl__1 = new ImmString("+=").clone();
//line 52
___nl__2 = tct_NL.NL_tct_sim().clone();

//line 52
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 52
___nl__4 = tct_NL.NL_tct_sim().clone();

//line 52
___ref______nl__0 = new ImmRef(___nl__0);
tc_types_NL.NL_op_def_priv(___ref______nl__0,___nl__1,___nl__2,___nl__3,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 52
___nl__4 = null;
//line 52
___nl__3 = null;
//line 52
___nl__2 = null;
//line 52
___nl__1 = null;
//line 53
___nl__1 = new ImmString("/=").clone();
//line 53
___nl__2 = tct_NL.NL_tct_sim().clone();

//line 53
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 53
___nl__4 = tct_NL.NL_tct_sim().clone();

//line 53
___ref______nl__0 = new ImmRef(___nl__0);
tc_types_NL.NL_op_def_priv(___ref______nl__0,___nl__1,___nl__2,___nl__3,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 53
___nl__4 = null;
//line 53
___nl__3 = null;
//line 53
___nl__2 = null;
//line 53
___nl__1 = null;
//line 54
___nl__1 = new ImmString("*=").clone();
//line 54
___nl__2 = tct_NL.NL_tct_sim().clone();

//line 54
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 54
___nl__4 = tct_NL.NL_tct_sim().clone();

//line 54
___ref______nl__0 = new ImmRef(___nl__0);
tc_types_NL.NL_op_def_priv(___ref______nl__0,___nl__1,___nl__2,___nl__3,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 54
___nl__4 = null;
//line 54
___nl__3 = null;
//line 54
___nl__2 = null;
//line 54
___nl__1 = null;
//line 55
___nl__1 = new ImmString(".=").clone();
//line 55
___nl__2 = tct_NL.NL_tct_sim().clone();

//line 55
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 55
___nl__4 = tct_NL.NL_tct_sim().clone();

//line 55
___ref______nl__0 = new ImmRef(___nl__0);
tc_types_NL.NL_op_def_priv(___ref______nl__0,___nl__1,___nl__2,___nl__3,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 55
___nl__4 = null;
//line 55
___nl__3 = null;
//line 55
___nl__2 = null;
//line 55
___nl__1 = null;
//line 56
___nl__1 = new ImmString("-=").clone();
//line 56
___nl__2 = tct_NL.NL_tct_sim().clone();

//line 56
___nl__3 = tct_NL.NL_tct_sim().clone();

//line 56
___nl__4 = tct_NL.NL_tct_sim().clone();

//line 56
___ref______nl__0 = new ImmRef(___nl__0);
tc_types_NL.NL_op_def_priv(___ref______nl__0,___nl__1,___nl__2,___nl__3,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 56
___nl__4 = null;
//line 56
___nl__3 = null;
//line 56
___nl__2 = null;
//line 56
___nl__1 = null;
//line 57
___nl__1 = singleton_NL.NL_sigleton_do_not_use_without_approval(___nl__0).clone();

//line 57
___nl__0 = null;
//line 57
if(true) return ___nl__1;
//line 57
___nl__1 = null;
//line 57
___nl__0 = null;
//line 57
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_get_binary_ops_priv = null;
private static Imm NL_get_binary_ops_priv() {
	if (value__singleton__NL_SINGLETON_get_binary_ops_priv == null) {
		value__singleton__NL_SINGLETON_get_binary_ops_priv = NL_SINGLETON_get_binary_ops_priv();
	}
	return value__singleton__NL_SINGLETON_get_binary_ops_priv;
}
public static Imm NL_SINGLETON_errors_t() {

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
//line 61
___nl__2 = ptd_NL.NL_sim().clone();

//line 61
___nl__3 = ptd_NL.NL_sim().clone();

//line 61
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("tc_types_NL"));
__function_map.Add("name",new ImmString("check_errors_t"));
___nl__4 = new ImmHash(__function_map).clone();
//line 61
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__4).clone();
//line 61
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("tc_types_NL"));
__function_map.Add("name",new ImmString("check_errors_t"));
___nl__5 = new ImmHash(__function_map).clone();
//line 61
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__5).clone();
//line 61
__function_map = new Dictionary<String, Imm>();
__function_map.Add("current_line",___nl__2);
__function_map.Add("module",___nl__3);
__function_map.Add("warnings",___nl__4);
__function_map.Add("errors",___nl__5);
___nl__1 = new ImmHash(__function_map).clone();
//line 61
___nl__2 = null;
//line 61
___nl__3 = null;
//line 61
___nl__4 = null;
//line 61
___nl__5 = null;
//line 61
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 61
___nl__1 = null;
//line 61
if(true) return ___nl__0;
//line 61
___nl__0 = null;
//line 61
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_errors_t = null;
public static Imm NL_errors_t() {
	if (value__singleton__NL_SINGLETON_errors_t == null) {
		value__singleton__NL_SINGLETON_errors_t = NL_SINGLETON_errors_t();
	}
	return value__singleton__NL_SINGLETON_errors_t;
}
public static Imm NL_SINGLETON_bin_op_type() {

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
//line 70
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("tct_NL"));
__function_map.Add("name",new ImmString("meta_type"));
___nl__2 = new ImmHash(__function_map).clone();
//line 70
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2).clone();
//line 70
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("tct_NL"));
__function_map.Add("name",new ImmString("meta_type"));
___nl__3 = new ImmHash(__function_map).clone();
//line 70
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3).clone();
//line 70
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("tct_NL"));
__function_map.Add("name",new ImmString("meta_type"));
___nl__4 = new ImmHash(__function_map).clone();
//line 70
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__4).clone();
//line 70
__function_map = new Dictionary<String, Imm>();
__function_map.Add("arg1",___nl__2);
__function_map.Add("arg2",___nl__3);
__function_map.Add("ret",___nl__4);
___nl__1 = new ImmHash(__function_map).clone();
//line 70
___nl__2 = null;
//line 70
___nl__3 = null;
//line 70
___nl__4 = null;
//line 70
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 70
___nl__1 = null;
//line 70
if(true) return ___nl__0;
//line 70
___nl__0 = null;
//line 70
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_bin_op_type = null;
public static Imm NL_bin_op_type() {
	if (value__singleton__NL_SINGLETON_bin_op_type == null) {
		value__singleton__NL_SINGLETON_bin_op_type = NL_SINGLETON_bin_op_type();
	}
	return value__singleton__NL_SINGLETON_bin_op_type;
}
public static Imm NL_SINGLETON_defs_funs_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 74
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("tc_types_NL"));
__function_map.Add("name",new ImmString("def_fun_t"));
___nl__2 = new ImmHash(__function_map).clone();
//line 74
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2).clone();
//line 74
___nl__1 = ptd_NL.NL_hash(___nl__2).clone();

//line 74
___nl__2 = null;
//line 74
___nl__0 = ptd_NL.NL_hash(___nl__1).clone();

//line 74
___nl__1 = null;
//line 74
if(true) return ___nl__0;
//line 74
___nl__0 = null;
//line 74
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_defs_funs_t = null;
public static Imm NL_defs_funs_t() {
	if (value__singleton__NL_SINGLETON_defs_funs_t == null) {
		value__singleton__NL_SINGLETON_defs_funs_t = NL_SINGLETON_defs_funs_t();
	}
	return value__singleton__NL_SINGLETON_defs_funs_t;
}
public static Imm NL_SINGLETON_return_t() {

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
//line 77
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("tc_types_NL"));
__function_map.Add("name",new ImmString("check_errors_t"));
___nl__2 = new ImmHash(__function_map).clone();
//line 77
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2).clone();
//line 77
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("tc_types_NL"));
__function_map.Add("name",new ImmString("check_errors_t"));
___nl__3 = new ImmHash(__function_map).clone();
//line 77
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3).clone();
//line 77
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("tc_types_NL"));
__function_map.Add("name",new ImmString("deref_types"));
___nl__4 = new ImmHash(__function_map).clone();
//line 77
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__4).clone();
//line 77
__function_map = new Dictionary<String, Imm>();
__function_map.Add("errors",___nl__2);
__function_map.Add("warnings",___nl__3);
__function_map.Add("deref",___nl__4);
___nl__1 = new ImmHash(__function_map).clone();
//line 77
___nl__2 = null;
//line 77
___nl__3 = null;
//line 77
___nl__4 = null;
//line 77
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 77
___nl__1 = null;
//line 77
if(true) return ___nl__0;
//line 77
___nl__0 = null;
//line 77
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_return_t = null;
public static Imm NL_return_t() {
	if (value__singleton__NL_SINGLETON_return_t == null) {
		value__singleton__NL_SINGLETON_return_t = NL_SINGLETON_return_t();
	}
	return value__singleton__NL_SINGLETON_return_t;
}
public static Imm NL_SINGLETON_modules_t() {

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
//line 84
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("boolean_t_NL"));
__function_map.Add("name",new ImmString("type"));
___nl__3 = new ImmHash(__function_map).clone();
//line 84
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3).clone();
//line 84
___nl__2 = ptd_NL.NL_hash(___nl__3).clone();

//line 84
___nl__3 = null;
//line 84
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("tc_types_NL"));
__function_map.Add("name",new ImmString("env"));
___nl__3 = new ImmHash(__function_map).clone();
//line 84
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3).clone();
//line 84
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("tc_types_NL"));
__function_map.Add("name",new ImmString("defs_funs_t"));
___nl__4 = new ImmHash(__function_map).clone();
//line 84
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__4).clone();
//line 84
__function_map = new Dictionary<String, Imm>();
__function_map.Add("imports",___nl__2);
__function_map.Add("env",___nl__3);
__function_map.Add("funs",___nl__4);
___nl__1 = new ImmHash(__function_map).clone();
//line 84
___nl__2 = null;
//line 84
___nl__3 = null;
//line 84
___nl__4 = null;
//line 84
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 84
___nl__1 = null;
//line 84
if(true) return ___nl__0;
//line 84
___nl__0 = null;
//line 84
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_modules_t = null;
public static Imm NL_modules_t() {
	if (value__singleton__NL_SINGLETON_modules_t == null) {
		value__singleton__NL_SINGLETON_modules_t = NL_SINGLETON_modules_t();
	}
	return value__singleton__NL_SINGLETON_modules_t;
}
public static Imm NL_SINGLETON_deref_type() {

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
//line 91
___nl__2 = ptd_NL.NL_sim().clone();

//line 91
___nl__3 = ptd_NL.NL_sim().clone();

//line 91
___nl__4 = ptd_NL.NL_sim().clone();

//line 91
__function_map = new Dictionary<String, Imm>();
__function_map.Add("line",___nl__2);
__function_map.Add("module",___nl__3);
__function_map.Add("type_name",___nl__4);
___nl__1 = new ImmHash(__function_map).clone();
//line 91
___nl__2 = null;
//line 91
___nl__3 = null;
//line 91
___nl__4 = null;
//line 91
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 91
___nl__1 = null;
//line 91
if(true) return ___nl__0;
//line 91
___nl__0 = null;
//line 91
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_deref_type = null;
public static Imm NL_deref_type() {
	if (value__singleton__NL_SINGLETON_deref_type == null) {
		value__singleton__NL_SINGLETON_deref_type = NL_SINGLETON_deref_type();
	}
	return value__singleton__NL_SINGLETON_deref_type;
}
public static Imm NL_SINGLETON_deref_types() {

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
//line 98
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("tc_types_NL"));
__function_map.Add("name",new ImmString("deref_type"));
___nl__3 = new ImmHash(__function_map).clone();
//line 98
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3).clone();
//line 98
___nl__2 = ptd_NL.NL_arr(___nl__3).clone();

//line 98
___nl__3 = null;
//line 98
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("tc_types_NL"));
__function_map.Add("name",new ImmString("deref_type"));
___nl__4 = new ImmHash(__function_map).clone();
//line 98
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__4).clone();
//line 98
___nl__3 = ptd_NL.NL_arr(___nl__4).clone();

//line 98
___nl__4 = null;
//line 98
__function_map = new Dictionary<String, Imm>();
__function_map.Add("delete",___nl__2);
__function_map.Add("create",___nl__3);
___nl__1 = new ImmHash(__function_map).clone();
//line 98
___nl__2 = null;
//line 98
___nl__3 = null;
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
private static Imm value__singleton__NL_SINGLETON_deref_types = null;
public static Imm NL_deref_types() {
	if (value__singleton__NL_SINGLETON_deref_types == null) {
		value__singleton__NL_SINGLETON_deref_types = NL_SINGLETON_deref_types();
	}
	return value__singleton__NL_SINGLETON_deref_types;
}
public static Imm NL_SINGLETON_env() {

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
//line 104
___nl__2 = ptd_NL.NL_sim().clone();

//line 104
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("tc_types_NL"));
__function_map.Add("name",new ImmString("vars_t"));
___nl__5 = new ImmHash(__function_map).clone();
//line 104
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__5).clone();
//line 104
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("boolean_t_NL"));
__function_map.Add("name",new ImmString("type"));
___nl__6 = new ImmHash(__function_map).clone();
//line 104
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__6).clone();
//line 104
__function_map = new Dictionary<String, Imm>();
__function_map.Add("vars",___nl__5);
__function_map.Add("is",___nl__6);
___nl__4 = new ImmHash(__function_map).clone();
//line 104
___nl__5 = null;
//line 104
___nl__6 = null;
//line 104
___nl__3 = ptd_NL.NL_rec(___nl__4).clone();

//line 104
___nl__4 = null;
//line 104
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("tct_NL"));
__function_map.Add("name",new ImmString("meta_type"));
___nl__4 = new ImmHash(__function_map).clone();
//line 104
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__4).clone();
//line 104
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("tc_types_NL"));
__function_map.Add("name",new ImmString("deref_types"));
___nl__5 = new ImmHash(__function_map).clone();
//line 104
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__5).clone();
//line 104
__function_map = new Dictionary<String, Imm>();
__function_map.Add("current_module",___nl__2);
__function_map.Add("breaks",___nl__3);
__function_map.Add("ret_type",___nl__4);
__function_map.Add("deref",___nl__5);
___nl__1 = new ImmHash(__function_map).clone();
//line 104
___nl__2 = null;
//line 104
___nl__3 = null;
//line 104
___nl__4 = null;
//line 104
___nl__5 = null;
//line 104
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 104
___nl__1 = null;
//line 104
if(true) return ___nl__0;
//line 104
___nl__0 = null;
//line 104
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_env = null;
public static Imm NL_env() {
	if (value__singleton__NL_SINGLETON_env == null) {
		value__singleton__NL_SINGLETON_env = NL_SINGLETON_env();
	}
	return value__singleton__NL_SINGLETON_env;
}
public static Imm NL_SINGLETON_var_t() {

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
//line 113
___nl__4 = ptd_NL.NL_none().clone();

//line 113
___nl__5 = ptd_NL.NL_none().clone();

//line 113
__function_map = new Dictionary<String, Imm>();
__function_map.Add("yes",___nl__4);
__function_map.Add("no",___nl__5);
___nl__3 = new ImmHash(__function_map).clone();
//line 113
___nl__4 = null;
//line 113
___nl__5 = null;
//line 113
___nl__2 = ptd_NL.NL_var(___nl__3).clone();

//line 113
___nl__3 = null;
//line 113
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("tct_NL"));
__function_map.Add("name",new ImmString("meta_type"));
___nl__3 = new ImmHash(__function_map).clone();
//line 113
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3).clone();
//line 113
__function_map = new Dictionary<String, Imm>();
__function_map.Add("overwrited",___nl__2);
__function_map.Add("type",___nl__3);
___nl__1 = new ImmHash(__function_map).clone();
//line 113
___nl__2 = null;
//line 113
___nl__3 = null;
//line 113
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 113
___nl__1 = null;
//line 113
if(true) return ___nl__0;
//line 113
___nl__0 = null;
//line 113
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_var_t = null;
public static Imm NL_var_t() {
	if (value__singleton__NL_SINGLETON_var_t == null) {
		value__singleton__NL_SINGLETON_var_t = NL_SINGLETON_var_t();
	}
	return value__singleton__NL_SINGLETON_var_t;
}
public static Imm NL_SINGLETON_fun_arg_t() {

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
//line 117
___nl__2 = ptd_NL.NL_sim().clone();

//line 117
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("tct_NL"));
__function_map.Add("name",new ImmString("meta_type"));
___nl__3 = new ImmHash(__function_map).clone();
//line 117
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3).clone();
//line 117
___nl__6 = ptd_NL.NL_none().clone();

//line 117
___nl__7 = ptd_NL.NL_none().clone();

//line 117
__function_map = new Dictionary<String, Imm>();
__function_map.Add("none",___nl__6);
__function_map.Add("ref",___nl__7);
___nl__5 = new ImmHash(__function_map).clone();
//line 117
___nl__6 = null;
//line 117
___nl__7 = null;
//line 117
___nl__4 = ptd_NL.NL_var(___nl__5).clone();

//line 117
___nl__5 = null;
//line 117
__function_map = new Dictionary<String, Imm>();
__function_map.Add("name",___nl__2);
__function_map.Add("type",___nl__3);
__function_map.Add("mod",___nl__4);
___nl__1 = new ImmHash(__function_map).clone();
//line 117
___nl__2 = null;
//line 117
___nl__3 = null;
//line 117
___nl__4 = null;
//line 117
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 117
___nl__1 = null;
//line 117
if(true) return ___nl__0;
//line 117
___nl__0 = null;
//line 117
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_fun_arg_t = null;
public static Imm NL_fun_arg_t() {
	if (value__singleton__NL_SINGLETON_fun_arg_t == null) {
		value__singleton__NL_SINGLETON_fun_arg_t = NL_SINGLETON_fun_arg_t();
	}
	return value__singleton__NL_SINGLETON_fun_arg_t;
}
public static Imm NL_SINGLETON_def_fun_t() {

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
//line 125
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nast_NL"));
__function_map.Add("name",new ImmString("cmd_t"));
___nl__2 = new ImmHash(__function_map).clone();
//line 125
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2).clone();
//line 125
___nl__5 = ptd_NL.NL_none().clone();

//line 125
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("tct_NL"));
__function_map.Add("name",new ImmString("meta_type"));
___nl__6 = new ImmHash(__function_map).clone();
//line 125
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__6).clone();
//line 125
__function_map = new Dictionary<String, Imm>();
__function_map.Add("no",___nl__5);
__function_map.Add("yes",___nl__6);
___nl__4 = new ImmHash(__function_map).clone();
//line 125
___nl__5 = null;
//line 125
___nl__6 = null;
//line 125
___nl__3 = ptd_NL.NL_var(___nl__4).clone();

//line 125
___nl__4 = null;
//line 125
___nl__6 = ptd_NL.NL_none().clone();

//line 125
___nl__8 = ptd_NL.NL_sim().clone();

//line 125
___nl__7 = ptd_NL.NL_arr(___nl__8).clone();

//line 125
___nl__8 = null;
//line 125
__function_map = new Dictionary<String, Imm>();
__function_map.Add("no",___nl__6);
__function_map.Add("yes",___nl__7);
___nl__5 = new ImmHash(__function_map).clone();
//line 125
___nl__6 = null;
//line 125
___nl__7 = null;
//line 125
___nl__4 = ptd_NL.NL_var(___nl__5).clone();

//line 125
___nl__5 = null;
//line 125
___nl__5 = ptd_NL.NL_sim().clone();

//line 125
___nl__6 = ptd_NL.NL_sim().clone();

//line 125
___nl__9 = ptd_NL.NL_none().clone();

//line 125
___nl__10 = ptd_NL.NL_none().clone();

//line 125
__function_map = new Dictionary<String, Imm>();
__function_map.Add("priv",___nl__9);
__function_map.Add("pub",___nl__10);
___nl__8 = new ImmHash(__function_map).clone();
//line 125
___nl__9 = null;
//line 125
___nl__10 = null;
//line 125
___nl__7 = ptd_NL.NL_var(___nl__8).clone();

//line 125
___nl__8 = null;
//line 125
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("tc_types_NL"));
__function_map.Add("name",new ImmString("fun_arg_t"));
___nl__9 = new ImmHash(__function_map).clone();
//line 125
___nl__9 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__9).clone();
//line 125
___nl__8 = ptd_NL.NL_arr(___nl__9).clone();

//line 125
___nl__9 = null;
//line 125
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("tct_NL"));
__function_map.Add("name",new ImmString("meta_type"));
___nl__9 = new ImmHash(__function_map).clone();
//line 125
___nl__9 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__9).clone();
//line 125
__function_map = new Dictionary<String, Imm>();
__function_map.Add("cmd",___nl__2);
__function_map.Add("is_type",___nl__3);
__function_map.Add("ref_types",___nl__4);
__function_map.Add("name",___nl__5);
__function_map.Add("module",___nl__6);
__function_map.Add("access",___nl__7);
__function_map.Add("args",___nl__8);
__function_map.Add("ret_type",___nl__9);
___nl__1 = new ImmHash(__function_map).clone();
//line 125
___nl__2 = null;
//line 125
___nl__3 = null;
//line 125
___nl__4 = null;
//line 125
___nl__5 = null;
//line 125
___nl__6 = null;
//line 125
___nl__7 = null;
//line 125
___nl__8 = null;
//line 125
___nl__9 = null;
//line 125
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 125
___nl__1 = null;
//line 125
if(true) return ___nl__0;
//line 125
___nl__0 = null;
//line 125
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_def_fun_t = null;
public static Imm NL_def_fun_t() {
	if (value__singleton__NL_SINGLETON_def_fun_t == null) {
		value__singleton__NL_SINGLETON_def_fun_t = NL_SINGLETON_def_fun_t();
	}
	return value__singleton__NL_SINGLETON_def_fun_t;
}
public static Imm NL_SINGLETON_vars_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 138
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("tc_types_NL"));
__function_map.Add("name",new ImmString("var_t"));
___nl__1 = new ImmHash(__function_map).clone();
//line 138
___nl__1 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__1).clone();
//line 138
___nl__0 = ptd_NL.NL_hash(___nl__1).clone();

//line 138
___nl__1 = null;
//line 138
if(true) return ___nl__0;
//line 138
___nl__0 = null;
//line 138
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_vars_t = null;
public static Imm NL_vars_t() {
	if (value__singleton__NL_SINGLETON_vars_t == null) {
		value__singleton__NL_SINGLETON_vars_t = NL_SINGLETON_vars_t();
	}
	return value__singleton__NL_SINGLETON_vars_t;
}
public static Imm NL_SINGLETON_check_error_t() {

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
//line 142
___nl__2 = ptd_NL.NL_sim().clone();

//line 142
___nl__3 = ptd_NL.NL_sim().clone();

//line 142
___nl__4 = ptd_NL.NL_sim().clone();

//line 142
__function_map = new Dictionary<String, Imm>();
__function_map.Add("msg",___nl__2);
__function_map.Add("line",___nl__3);
__function_map.Add("module",___nl__4);
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
private static Imm value__singleton__NL_SINGLETON_check_error_t = null;
public static Imm NL_check_error_t() {
	if (value__singleton__NL_SINGLETON_check_error_t == null) {
		value__singleton__NL_SINGLETON_check_error_t = NL_SINGLETON_check_error_t();
	}
	return value__singleton__NL_SINGLETON_check_error_t;
}
public static Imm NL_SINGLETON_check_errors_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 146
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("tc_types_NL"));
__function_map.Add("name",new ImmString("check_error_t"));
___nl__1 = new ImmHash(__function_map).clone();
//line 146
___nl__1 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__1).clone();
//line 146
___nl__0 = ptd_NL.NL_arr(___nl__1).clone();

//line 146
___nl__1 = null;
//line 146
if(true) return ___nl__0;
//line 146
___nl__0 = null;
//line 146
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_check_errors_t = null;
public static Imm NL_check_errors_t() {
	if (value__singleton__NL_SINGLETON_check_errors_t == null) {
		value__singleton__NL_SINGLETON_check_errors_t = NL_SINGLETON_check_errors_t();
	}
	return value__singleton__NL_SINGLETON_check_errors_t;
}
public static Imm NL_SINGLETON_type() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 149
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("tc_types_NL"));
__function_map.Add("name",new ImmString("value_src"));
___nl__2 = new ImmHash(__function_map).clone();
//line 149
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2).clone();
//line 149
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("tct_NL"));
__function_map.Add("name",new ImmString("meta_type"));
___nl__3 = new ImmHash(__function_map).clone();
//line 149
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3).clone();
//line 149
__function_map = new Dictionary<String, Imm>();
__function_map.Add("src",___nl__2);
__function_map.Add("type",___nl__3);
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
private static Imm value__singleton__NL_SINGLETON_type = null;
public static Imm NL_type() {
	if (value__singleton__NL_SINGLETON_type == null) {
		value__singleton__NL_SINGLETON_type = NL_SINGLETON_type();
	}
	return value__singleton__NL_SINGLETON_type;
}
public static Imm NL_SINGLETON_value_src() {

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
//line 153
___nl__2 = ptd_NL.NL_none().clone();

//line 153
___nl__3 = ptd_NL.NL_none().clone();

//line 153
___nl__4 = ptd_NL.NL_none().clone();

//line 153
__function_map = new Dictionary<String, Imm>();
__function_map.Add("known",___nl__2);
__function_map.Add("knownhash",___nl__3);
__function_map.Add("speculation",___nl__4);
___nl__1 = new ImmHash(__function_map).clone();
//line 153
___nl__2 = null;
//line 153
___nl__3 = null;
//line 153
___nl__4 = null;
//line 153
___nl__0 = ptd_NL.NL_var(___nl__1).clone();

//line 153
___nl__1 = null;
//line 153
if(true) return ___nl__0;
//line 153
___nl__0 = null;
//line 153
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_value_src = null;
public static Imm NL_value_src() {
	if (value__singleton__NL_SINGLETON_value_src == null) {
		value__singleton__NL_SINGLETON_value_src = NL_SINGLETON_value_src();
	}
	return value__singleton__NL_SINGLETON_value_src;
}
public static Imm NL_SINGLETON_lval_path() {

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
//line 156
___nl__3 = ptd_NL.NL_sim().clone();

//line 156
___nl__4 = ptd_NL.NL_none().clone();

//line 156
___nl__5 = ptd_NL.NL_sim().clone();

//line 156
__function_map = new Dictionary<String, Imm>();
__function_map.Add("var",___nl__3);
__function_map.Add("arr",___nl__4);
__function_map.Add("rec",___nl__5);
___nl__2 = new ImmHash(__function_map).clone();
//line 156
___nl__3 = null;
//line 156
___nl__4 = null;
//line 156
___nl__5 = null;
//line 156
___nl__1 = ptd_NL.NL_var(___nl__2).clone();

//line 156
___nl__2 = null;
//line 156
___nl__0 = ptd_NL.NL_arr(___nl__1).clone();

//line 156
___nl__1 = null;
//line 156
if(true) return ___nl__0;
//line 156
___nl__0 = null;
//line 156
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_lval_path = null;
public static Imm NL_lval_path() {
	if (value__singleton__NL_SINGLETON_lval_path == null) {
		value__singleton__NL_SINGLETON_lval_path = NL_SINGLETON_lval_path();
	}
	return value__singleton__NL_SINGLETON_lval_path;
}
public static Imm NL_SINGLETON_walk_arg() {

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
//line 159
___nl__4 = ptd_NL.NL_sim().clone();

//line 159
___nl__3 = ptd_NL.NL_arr(___nl__4).clone();

//line 159
___nl__4 = null;
//line 159
___nl__2 = ptd_NL.NL_hash(___nl__3).clone();

//line 159
___nl__3 = null;
//line 159
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("tc_types_NL"));
__function_map.Add("name",new ImmString("errors_t"));
___nl__3 = new ImmHash(__function_map).clone();
//line 159
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3).clone();
//line 159
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("tc_types_NL"));
__function_map.Add("name",new ImmString("modules_t"));
___nl__4 = new ImmHash(__function_map).clone();
//line 159
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__4).clone();
//line 159
__function_map = new Dictionary<String, Imm>();
__function_map.Add("ref_inf",___nl__2);
__function_map.Add("errors",___nl__3);
__function_map.Add("modules",___nl__4);
___nl__1 = new ImmHash(__function_map).clone();
//line 159
___nl__2 = null;
//line 159
___nl__3 = null;
//line 159
___nl__4 = null;
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
private static Imm value__singleton__NL_SINGLETON_walk_arg = null;
public static Imm NL_walk_arg() {
	if (value__singleton__NL_SINGLETON_walk_arg == null) {
		value__singleton__NL_SINGLETON_walk_arg = NL_SINGLETON_walk_arg();
	}
	return value__singleton__NL_SINGLETON_walk_arg;
}
public static Imm NL_SINGLETON_ref_t() {

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
//line 167
___nl__2 = ptd_NL.NL_sim().clone();

//line 167
___nl__5 = ptd_NL.NL_sim().clone();

//line 167
___nl__4 = ptd_NL.NL_arr(___nl__5).clone();

//line 167
___nl__5 = null;
//line 167
___nl__3 = ptd_NL.NL_hash(___nl__4).clone();

//line 167
___nl__4 = null;
//line 167
___nl__6 = ptd_NL.NL_sim().clone();

//line 167
___nl__5 = ptd_NL.NL_arr(___nl__6).clone();

//line 167
___nl__6 = null;
//line 167
___nl__4 = ptd_NL.NL_hash(___nl__5).clone();

//line 167
___nl__5 = null;
//line 167
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("boolean_t_NL"));
__function_map.Add("name",new ImmString("type"));
___nl__5 = new ImmHash(__function_map).clone();
//line 167
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__5).clone();
//line 167
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("boolean_t_NL"));
__function_map.Add("name",new ImmString("type"));
___nl__6 = new ImmHash(__function_map).clone();
//line 167
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__6).clone();
//line 167
__function_map = new Dictionary<String, Imm>();
__function_map.Add("level",___nl__2);
__function_map.Add("from",___nl__3);
__function_map.Add("to",___nl__4);
__function_map.Add("check",___nl__5);
__function_map.Add("cast",___nl__6);
___nl__1 = new ImmHash(__function_map).clone();
//line 167
___nl__2 = null;
//line 167
___nl__3 = null;
//line 167
___nl__4 = null;
//line 167
___nl__5 = null;
//line 167
___nl__6 = null;
//line 167
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 167
___nl__1 = null;
//line 167
if(true) return ___nl__0;
//line 167
___nl__0 = null;
//line 167
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_ref_t = null;
public static Imm NL_ref_t() {
	if (value__singleton__NL_SINGLETON_ref_t == null) {
		value__singleton__NL_SINGLETON_ref_t = NL_SINGLETON_ref_t();
	}
	return value__singleton__NL_SINGLETON_ref_t;
}
public static Imm NL_SINGLETON_stack_info_type() {

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
//line 176
___nl__2 = ptd_NL.NL_none().clone();

//line 176
___nl__3 = ptd_NL.NL_none().clone();

//line 176
___nl__4 = ptd_NL.NL_sim().clone();

//line 176
___nl__5 = ptd_NL.NL_sim().clone();

//line 176
__function_map = new Dictionary<String, Imm>();
__function_map.Add("ptd_hash",___nl__2);
__function_map.Add("ptd_arr",___nl__3);
__function_map.Add("ptd_rec",___nl__4);
__function_map.Add("ptd_var",___nl__5);
___nl__1 = new ImmHash(__function_map).clone();
//line 176
___nl__2 = null;
//line 176
___nl__3 = null;
//line 176
___nl__4 = null;
//line 176
___nl__5 = null;
//line 176
___nl__0 = ptd_NL.NL_var(___nl__1).clone();

//line 176
___nl__1 = null;
//line 176
if(true) return ___nl__0;
//line 176
___nl__0 = null;
//line 176
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_stack_info_type = null;
public static Imm NL_stack_info_type() {
	if (value__singleton__NL_SINGLETON_stack_info_type == null) {
		value__singleton__NL_SINGLETON_stack_info_type = NL_SINGLETON_stack_info_type();
	}
	return value__singleton__NL_SINGLETON_stack_info_type;
}
public static Imm NL_SINGLETON_check_info() {

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
//line 184
___nl__2 = ptd_NL.NL_none().clone();

//line 184
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("tct_NL"));
__function_map.Add("name",new ImmString("meta_type"));
___nl__5 = new ImmHash(__function_map).clone();
//line 184
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__5).clone();
//line 184
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("tct_NL"));
__function_map.Add("name",new ImmString("meta_type"));
___nl__6 = new ImmHash(__function_map).clone();
//line 184
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__6).clone();
//line 184
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("tc_types_NL"));
__function_map.Add("name",new ImmString("stack_info_type"));
___nl__8 = new ImmHash(__function_map).clone();
//line 184
___nl__8 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__8).clone();
//line 184
___nl__7 = ptd_NL.NL_arr(___nl__8).clone();

//line 184
___nl__8 = null;
//line 184
__function_map = new Dictionary<String, Imm>();
__function_map.Add("from",___nl__5);
__function_map.Add("to",___nl__6);
__function_map.Add("stack",___nl__7);
___nl__4 = new ImmHash(__function_map).clone();
//line 184
___nl__5 = null;
//line 184
___nl__6 = null;
//line 184
___nl__7 = null;
//line 184
___nl__3 = ptd_NL.NL_rec(___nl__4).clone();

//line 184
___nl__4 = null;
//line 184
__function_map = new Dictionary<String, Imm>();
__function_map.Add("ok",___nl__2);
__function_map.Add("err",___nl__3);
___nl__1 = new ImmHash(__function_map).clone();
//line 184
___nl__2 = null;
//line 184
___nl__3 = null;
//line 184
___nl__0 = ptd_NL.NL_var(___nl__1).clone();

//line 184
___nl__1 = null;
//line 184
if(true) return ___nl__0;
//line 184
___nl__0 = null;
//line 184
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_check_info = null;
public static Imm NL_check_info() {
	if (value__singleton__NL_SINGLETON_check_info == null) {
		value__singleton__NL_SINGLETON_check_info = NL_SINGLETON_check_info();
	}
	return value__singleton__NL_SINGLETON_check_info;
}
public static Imm NL_SINGLETON_special_functions() {

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
//line 194
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("tct_NL"));
__function_map.Add("name",new ImmString("meta_type"));
___nl__3 = new ImmHash(__function_map).clone();
//line 194
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3).clone();
//line 194
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("tc_types_NL"));
__function_map.Add("name",new ImmString("fun_arg_t"));
___nl__5 = new ImmHash(__function_map).clone();
//line 194
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__5).clone();
//line 194
___nl__4 = ptd_NL.NL_arr(___nl__5).clone();

//line 194
___nl__5 = null;
//line 194
__function_map = new Dictionary<String, Imm>();
__function_map.Add("r",___nl__3);
__function_map.Add("a",___nl__4);
___nl__2 = new ImmHash(__function_map).clone();
//line 194
___nl__3 = null;
//line 194
___nl__4 = null;
//line 194
___nl__1 = ptd_NL.NL_rec(___nl__2).clone();

//line 194
___nl__2 = null;
//line 194
___nl__0 = ptd_NL.NL_hash(___nl__1).clone();

//line 194
___nl__1 = null;
//line 194
if(true) return ___nl__0;
//line 194
___nl__0 = null;
//line 194
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_special_functions = null;
public static Imm NL_special_functions() {
	if (value__singleton__NL_SINGLETON_special_functions == null) {
		value__singleton__NL_SINGLETON_special_functions = NL_SINGLETON_special_functions();
	}
	return value__singleton__NL_SINGLETON_special_functions;
}
}
}