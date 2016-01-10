using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class simple_test_NL {

private static Imm NL_test1_priv() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 6
___nl__0 = new ImmDouble(3).clone();
//line 7
___nl__1 = ___nl__0.clone();
//line 8
___nl__2 = new ImmDouble(1.1).clone();
//line 8
___nl__3 = c_rt_lib_NL.NL_get_true().clone();
//line 8
assert_NL.NL_assert(___nl__2,___nl__0,___nl__1,___nl__3);

//line 8
___nl__3 = null;
//line 8
___nl__2 = null;
//line 9
___nl__2 = new ImmDouble(2).clone();
//line 9
___nl__0 = ___nl__2.clone();
//line 9
___nl__2 = null;
//line 10
___nl__2 = new ImmDouble(1.2).clone();
//line 10
___nl__3 = c_rt_lib_NL.NL_get_false().clone();
//line 10
assert_NL.NL_assert(___nl__2,___nl__0,___nl__1,___nl__3);

//line 10
___nl__3 = null;
//line 10
___nl__2 = null;
//line 10
___nl__0 = null;
//line 10
___nl__1 = null;
//line 10
if(true) return null;
}

private static Imm NL_test2_priv() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 14
___nl__0 = new ImmDouble(3).clone();
//line 15
___nl__1 = new ImmArray(new Imm[] {___nl__0,}).clone();
//line 16
___nl__2 = new ImmDouble(2.1).clone();
//line 16
___nl__4 = new ImmDouble(0).clone();
//line 16
___nl__3 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()].clone();
//line 16
___nl__4 = null;
//line 16
___nl__4 = c_rt_lib_NL.NL_get_true().clone();
//line 16
assert_NL.NL_assert(___nl__2,___nl__0,___nl__3,___nl__4);

//line 16
___nl__4 = null;
//line 16
___nl__3 = null;
//line 16
___nl__2 = null;
//line 17
___nl__2 = new ImmDouble(2).clone();
//line 17
___nl__0 = ___nl__2.clone();
//line 17
___nl__2 = null;
//line 18
___nl__2 = new ImmDouble(2.2).clone();
//line 18
___nl__4 = new ImmDouble(0).clone();
//line 18
___nl__3 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()].clone();
//line 18
___nl__4 = null;
//line 18
___nl__4 = c_rt_lib_NL.NL_get_false().clone();
//line 18
assert_NL.NL_assert(___nl__2,___nl__0,___nl__3,___nl__4);

//line 18
___nl__4 = null;
//line 18
___nl__3 = null;
//line 18
___nl__2 = null;
//line 19
___nl__2 = new ImmDouble(2).clone();
//line 19
___nl__4 = new ImmDouble(0).clone();
//line 19
___nl__3 = ___nl__2.clone();
//line 19
(___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()] = ___nl__3;
//line 19
___nl__2 = null;
//line 19
___nl__3 = null;
//line 19
___nl__4 = null;
//line 20
___nl__2 = new ImmDouble(2.3).clone();
//line 20
___nl__4 = new ImmDouble(0).clone();
//line 20
___nl__3 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()].clone();
//line 20
___nl__4 = null;
//line 20
___nl__4 = c_rt_lib_NL.NL_get_true().clone();
//line 20
assert_NL.NL_assert(___nl__2,___nl__0,___nl__3,___nl__4);

//line 20
___nl__4 = null;
//line 20
___nl__3 = null;
//line 20
___nl__2 = null;
//line 20
___nl__0 = null;
//line 20
___nl__1 = null;
//line 20
if(true) return null;
}

private static Imm NL_test3_priv() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 24
___nl__0 = new ImmDouble(3).clone();
//line 25
__function_map = new Dictionary<String, Imm>();
__function_map.Add("a",___nl__0);
___nl__1 = new ImmHash(__function_map).clone();
//line 26
___nl__2 = new ImmDouble(3.1).clone();
//line 26
___nl__3 = ((ImmHash)___nl__1).getHashValue()["a"].clone();
//line 26
___nl__4 = c_rt_lib_NL.NL_get_true().clone();
//line 26
assert_NL.NL_assert(___nl__2,___nl__0,___nl__3,___nl__4);

//line 26
___nl__4 = null;
//line 26
___nl__3 = null;
//line 26
___nl__2 = null;
//line 27
___nl__2 = new ImmDouble(2).clone();
//line 27
___nl__0 = ___nl__2.clone();
//line 27
___nl__2 = null;
//line 28
___nl__2 = new ImmDouble(3.2).clone();
//line 28
___nl__3 = ((ImmHash)___nl__1).getHashValue()["a"].clone();
//line 28
___nl__4 = c_rt_lib_NL.NL_get_false().clone();
//line 28
assert_NL.NL_assert(___nl__2,___nl__0,___nl__3,___nl__4);

//line 28
___nl__4 = null;
//line 28
___nl__3 = null;
//line 28
___nl__2 = null;
//line 29
___nl__2 = new ImmDouble(2).clone();
//line 29
___nl__3 = ___nl__2.clone();
//line 29
((ImmHash)___nl__1).set("a", ___nl__3);
//line 29
___nl__2 = null;
//line 29
___nl__3 = null;
//line 30
___nl__2 = new ImmDouble(3.3).clone();
//line 30
___nl__3 = ((ImmHash)___nl__1).getHashValue()["a"].clone();
//line 30
___nl__4 = c_rt_lib_NL.NL_get_true().clone();
//line 30
assert_NL.NL_assert(___nl__2,___nl__0,___nl__3,___nl__4);

//line 30
___nl__4 = null;
//line 30
___nl__3 = null;
//line 30
___nl__2 = null;
//line 30
___nl__0 = null;
//line 30
___nl__1 = null;
//line 30
if(true) return null;
}

private static Imm NL_test4_priv() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 34
___nl__0 = new ImmDouble(3).clone();
//line 35
___nl__1 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__0).clone();
//line 36
___nl__2 = new ImmDouble(4.1).clone();
//line 36
___nl__3 = ___nl__1.clone();
//line 36
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("ok")).clone();
//line 36
___nl__4 = c_rt_lib_NL.NL_get_true().clone();
//line 36
assert_NL.NL_assert(___nl__2,___nl__0,___nl__3,___nl__4);

//line 36
___nl__4 = null;
//line 36
___nl__3 = null;
//line 36
___nl__2 = null;
//line 37
___nl__2 = new ImmDouble(2).clone();
//line 37
___nl__0 = ___nl__2.clone();
//line 37
___nl__2 = null;
//line 38
___nl__2 = new ImmDouble(4.2).clone();
//line 38
___nl__3 = ___nl__1.clone();
//line 38
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("ok")).clone();
//line 38
___nl__4 = c_rt_lib_NL.NL_get_false().clone();
//line 38
assert_NL.NL_assert(___nl__2,___nl__0,___nl__3,___nl__4);

//line 38
___nl__4 = null;
//line 38
___nl__3 = null;
//line 38
___nl__2 = null;
//line 38
___nl__0 = null;
//line 38
___nl__1 = null;
//line 38
if(true) return null;
}

public static Imm NL_test() {

Imm ___nl__0 = null;
Dictionary<String, Imm> __function_map;
//line 42
___nl__0 = new ImmString("Simple test").clone();
//line 42
assert_NL.NL_section(___nl__0);

//line 42
___nl__0 = null;
//line 44
simple_test_NL.NL_test1_priv();

//line 45
simple_test_NL.NL_test2_priv();

//line 46
simple_test_NL.NL_test3_priv();

//line 47
simple_test_NL.NL_test4_priv();

//line 47
if(true) return null;
}

}
}