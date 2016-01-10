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
//line 18
___nl__0 = null;
//line 18
___nl__1 = null;
//line 18
if(true) return null;
}

public static Imm NL_test() {

Imm ___nl__0 = null;
Dictionary<String, Imm> __function_map;
//line 22
___nl__0 = new ImmString("Simple test").clone();
//line 22
assert_NL.NL_section(___nl__0);

//line 22
___nl__0 = null;
//line 24
simple_test_NL.NL_test1_priv();

//line 25
simple_test_NL.NL_test2_priv();

//line 25
if(true) return null;
}

}
}