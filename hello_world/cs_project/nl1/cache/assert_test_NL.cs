using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class assert_test_NL {

public static Imm NL_test() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Dictionary<String, Imm> __function_map;
//line 5
___nl__0 = new ImmString("Assert test").clone();
//line 5
assert_NL.NL_section(___nl__0);

//line 5
___nl__0 = null;
//line 6
___nl__0 = new ImmDouble(1).clone();
//line 6
___nl__1 = new ImmDouble(1).clone();
//line 6
___nl__2 = new ImmDouble(1).clone();
//line 6
___nl__3 = c_rt_lib_NL.NL_get_true().clone();
//line 6
assert_NL.NL_assert(___nl__0,___nl__1,___nl__2,___nl__3);

//line 6
___nl__3 = null;
//line 6
___nl__2 = null;
//line 6
___nl__1 = null;
//line 6
___nl__0 = null;
//line 7
___nl__0 = new ImmDouble(2).clone();
//line 7
___nl__1 = new ImmDouble(1).clone();
//line 7
___nl__2 = new ImmDouble(2).clone();
//line 7
___nl__3 = c_rt_lib_NL.NL_get_false().clone();
//line 7
assert_NL.NL_assert(___nl__0,___nl__1,___nl__2,___nl__3);

//line 7
___nl__3 = null;
//line 7
___nl__2 = null;
//line 7
___nl__1 = null;
//line 7
___nl__0 = null;
//line 8
___nl__0 = new ImmDouble(3).clone();
//line 8
___nl__1 = new ImmDouble(1).clone();
//line 8
___nl__1 = new ImmDouble(-((ImmDouble)___nl__1).getDoubleValue()).clone();
//line 8
___nl__2 = new ImmDouble(1).clone();
//line 8
___nl__3 = c_rt_lib_NL.NL_get_false().clone();
//line 8
assert_NL.NL_assert(___nl__0,___nl__1,___nl__2,___nl__3);

//line 8
___nl__3 = null;
//line 8
___nl__2 = null;
//line 8
___nl__1 = null;
//line 8
___nl__0 = null;
//line 9
___nl__0 = new ImmDouble(4).clone();
//line 9
___nl__1 = c_rt_lib_NL.NL_get_true().clone();
//line 9
___nl__2 = c_rt_lib_NL.NL_get_true().clone();
//line 9
___nl__3 = c_rt_lib_NL.NL_get_true().clone();
//line 9
assert_NL.NL_assert(___nl__0,___nl__1,___nl__2,___nl__3);

//line 9
___nl__3 = null;
//line 9
___nl__2 = null;
//line 9
___nl__1 = null;
//line 9
___nl__0 = null;
//line 10
___nl__0 = new ImmDouble(5).clone();
//line 10
___nl__1 = c_rt_lib_NL.NL_get_true().clone();
//line 10
___nl__2 = c_rt_lib_NL.NL_get_false().clone();
//line 10
___nl__3 = c_rt_lib_NL.NL_get_false().clone();
//line 10
assert_NL.NL_assert(___nl__0,___nl__1,___nl__2,___nl__3);

//line 10
___nl__3 = null;
//line 10
___nl__2 = null;
//line 10
___nl__1 = null;
//line 10
___nl__0 = null;
//line 11
___nl__0 = new ImmDouble(6).clone();
//line 11
___nl__1 = new ImmArray(new Imm[0]).clone();
//line 11
___nl__2 = new ImmArray(new Imm[0]).clone();
//line 11
___nl__3 = c_rt_lib_NL.NL_get_true().clone();
//line 11
assert_NL.NL_assert(___nl__0,___nl__1,___nl__2,___nl__3);

//line 11
___nl__3 = null;
//line 11
___nl__2 = null;
//line 11
___nl__1 = null;
//line 11
___nl__0 = null;
//line 12
___nl__0 = new ImmDouble(7).clone();
//line 12
___nl__2 = new ImmDouble(1).clone();
//line 12
___nl__3 = new ImmDouble(2).clone();
//line 12
___nl__4 = new ImmDouble(3).clone();
//line 12
___nl__1 = new ImmArray(new Imm[] {___nl__2,___nl__3,___nl__4,}).clone();
//line 12
___nl__2 = null;
//line 12
___nl__3 = null;
//line 12
___nl__4 = null;
//line 12
___nl__3 = new ImmDouble(1).clone();
//line 12
___nl__4 = new ImmDouble(2).clone();
//line 12
___nl__5 = new ImmDouble(3).clone();
//line 12
___nl__2 = new ImmArray(new Imm[] {___nl__3,___nl__4,___nl__5,}).clone();
//line 12
___nl__3 = null;
//line 12
___nl__4 = null;
//line 12
___nl__5 = null;
//line 12
___nl__3 = c_rt_lib_NL.NL_get_true().clone();
//line 12
assert_NL.NL_assert(___nl__0,___nl__1,___nl__2,___nl__3);

//line 12
___nl__3 = null;
//line 12
___nl__2 = null;
//line 12
___nl__1 = null;
//line 12
___nl__0 = null;
//line 13
___nl__0 = new ImmDouble(8).clone();
//line 13
___nl__2 = new ImmDouble(1).clone();
//line 13
___nl__3 = new ImmDouble(2).clone();
//line 13
___nl__4 = new ImmDouble(3).clone();
//line 13
___nl__1 = new ImmArray(new Imm[] {___nl__2,___nl__3,___nl__4,}).clone();
//line 13
___nl__2 = null;
//line 13
___nl__3 = null;
//line 13
___nl__4 = null;
//line 13
___nl__3 = new ImmDouble(3).clone();
//line 13
___nl__4 = new ImmDouble(2).clone();
//line 13
___nl__5 = new ImmDouble(1).clone();
//line 13
___nl__2 = new ImmArray(new Imm[] {___nl__3,___nl__4,___nl__5,}).clone();
//line 13
___nl__3 = null;
//line 13
___nl__4 = null;
//line 13
___nl__5 = null;
//line 13
___nl__3 = c_rt_lib_NL.NL_get_false().clone();
//line 13
assert_NL.NL_assert(___nl__0,___nl__1,___nl__2,___nl__3);

//line 13
___nl__3 = null;
//line 13
___nl__2 = null;
//line 13
___nl__1 = null;
//line 13
___nl__0 = null;
//line 14
___nl__0 = new ImmDouble(9).clone();
//line 14
__function_map = new Dictionary<String, Imm>();
___nl__1 = new ImmHash(__function_map).clone();
//line 14
__function_map = new Dictionary<String, Imm>();
___nl__2 = new ImmHash(__function_map).clone();
//line 14
___nl__3 = c_rt_lib_NL.NL_get_true().clone();
//line 14
assert_NL.NL_assert(___nl__0,___nl__1,___nl__2,___nl__3);

//line 14
___nl__3 = null;
//line 14
___nl__2 = null;
//line 14
___nl__1 = null;
//line 14
___nl__0 = null;
//line 15
___nl__0 = new ImmDouble(10).clone();
//line 15
___nl__2 = new ImmString("b").clone();
//line 15
__function_map = new Dictionary<String, Imm>();
__function_map.Add("a",___nl__2);
___nl__1 = new ImmHash(__function_map).clone();
//line 15
___nl__2 = null;
//line 15
___nl__3 = new ImmString("b").clone();
//line 15
__function_map = new Dictionary<String, Imm>();
__function_map.Add("a",___nl__3);
___nl__2 = new ImmHash(__function_map).clone();
//line 15
___nl__3 = null;
//line 15
___nl__3 = c_rt_lib_NL.NL_get_true().clone();
//line 15
assert_NL.NL_assert(___nl__0,___nl__1,___nl__2,___nl__3);

//line 15
___nl__3 = null;
//line 15
___nl__2 = null;
//line 15
___nl__1 = null;
//line 15
___nl__0 = null;
//line 16
___nl__0 = new ImmDouble(11).clone();
//line 16
___nl__2 = new ImmString("b").clone();
//line 16
__function_map = new Dictionary<String, Imm>();
__function_map.Add("a",___nl__2);
___nl__1 = new ImmHash(__function_map).clone();
//line 16
___nl__2 = null;
//line 16
__function_map = new Dictionary<String, Imm>();
___nl__2 = new ImmHash(__function_map).clone();
//line 16
___nl__3 = c_rt_lib_NL.NL_get_false().clone();
//line 16
assert_NL.NL_assert(___nl__0,___nl__1,___nl__2,___nl__3);

//line 16
___nl__3 = null;
//line 16
___nl__2 = null;
//line 16
___nl__1 = null;
//line 16
___nl__0 = null;
//line 17
___nl__0 = new ImmDouble(12).clone();
//line 17
___nl__1 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("a")).clone();
//line 17
___nl__2 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("a")).clone();
//line 17
___nl__3 = c_rt_lib_NL.NL_get_true().clone();
//line 17
assert_NL.NL_assert(___nl__0,___nl__1,___nl__2,___nl__3);

//line 17
___nl__3 = null;
//line 17
___nl__2 = null;
//line 17
___nl__1 = null;
//line 17
___nl__0 = null;
//line 18
___nl__0 = new ImmDouble(13).clone();
//line 18
___nl__1 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("a")).clone();
//line 18
___nl__2 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("b")).clone();
//line 18
___nl__3 = c_rt_lib_NL.NL_get_false().clone();
//line 18
assert_NL.NL_assert(___nl__0,___nl__1,___nl__2,___nl__3);

//line 18
___nl__3 = null;
//line 18
___nl__2 = null;
//line 18
___nl__1 = null;
//line 18
___nl__0 = null;
//line 19
___nl__0 = new ImmDouble(13).clone();
//line 19
__function_map = new Dictionary<String, Imm>();
___nl__1 = new ImmHash(__function_map).clone();
//line 19
___nl__2 = new ImmArray(new Imm[0]).clone();
//line 19
___nl__3 = c_rt_lib_NL.NL_get_false().clone();
//line 19
assert_NL.NL_assert(___nl__0,___nl__1,___nl__2,___nl__3);

//line 19
___nl__3 = null;
//line 19
___nl__2 = null;
//line 19
___nl__1 = null;
//line 19
___nl__0 = null;
//line 19
if(true) return null;
}

}
}