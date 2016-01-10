using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class ref_test_NL {

private static Imm NL_test1_f1_priv(ref Imm ___arg__0) {
Imm ___nl__0 = ___arg__0;
Imm ___nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 7
___nl__1 = new ImmDouble(5).clone();
//line 7
___nl__0 = ___nl__1.clone();
//line 7
___nl__1 = null;
//line 7
___arg__0 = ___nl__0;if(true) return null;
}

private static Imm NL_test1_priv() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Dictionary<String, Imm> __function_map;
//line 11
___nl__0 = new ImmDouble(1).clone();
//line 12
___nl__1 = ___nl__0.clone();
//line 13
___nl__2 = new ImmDouble(1.1).clone();
//line 13
___nl__3 = c_rt_lib_NL.NL_get_true().clone();
//line 13
assert_NL.NL_assert(___nl__2,___nl__0,___nl__1,___nl__3);

//line 13
___nl__3 = null;
//line 13
___nl__2 = null;
//line 15
___nl__2 = new ImmDouble(2).clone();
//line 15
___nl__1 = ___nl__2.clone();
//line 15
___nl__2 = null;
//line 16
___nl__2 = new ImmDouble(1.2).clone();
//line 16
___nl__3 = c_rt_lib_NL.NL_get_false().clone();
//line 16
assert_NL.NL_assert(___nl__2,___nl__0,___nl__1,___nl__3);

//line 16
___nl__3 = null;
//line 16
___nl__2 = null;
//line 18
___nl__2 = ___nl__0.clone();
//line 19
ref_test_NL.NL_test1_f1_priv(ref ___nl__0);

//line 20
___nl__3 = new ImmDouble(1.3).clone();
//line 20
___nl__4 = new ImmDouble(5).clone();
//line 20
___nl__5 = c_rt_lib_NL.NL_get_true().clone();
//line 20
assert_NL.NL_assert(___nl__3,___nl__0,___nl__4,___nl__5);

//line 20
___nl__5 = null;
//line 20
___nl__4 = null;
//line 20
___nl__3 = null;
//line 21
___nl__3 = new ImmDouble(1.4).clone();
//line 21
___nl__4 = new ImmDouble(5).clone();
//line 21
___nl__5 = c_rt_lib_NL.NL_get_false().clone();
//line 21
assert_NL.NL_assert(___nl__3,___nl__1,___nl__4,___nl__5);

//line 21
___nl__5 = null;
//line 21
___nl__4 = null;
//line 21
___nl__3 = null;
//line 22
___nl__3 = new ImmDouble(1.5).clone();
//line 22
___nl__4 = new ImmDouble(5).clone();
//line 22
___nl__5 = c_rt_lib_NL.NL_get_false().clone();
//line 22
assert_NL.NL_assert(___nl__3,___nl__2,___nl__4,___nl__5);

//line 22
___nl__5 = null;
//line 22
___nl__4 = null;
//line 22
___nl__3 = null;
//line 22
___nl__0 = null;
//line 22
___nl__1 = null;
//line 22
___nl__2 = null;
//line 22
if(true) return null;
}

private static Imm NL_test2_priv() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Dictionary<String, Imm> __function_map;
//line 26
___nl__0 = new ImmArray(new Imm[0]).clone();
//line 27
___nl__1 = new ImmDouble(1).clone();
//line 27
array_NL.NL_push(ref ___nl__0,___nl__1);

//line 27
___nl__1 = null;
//line 28
___nl__1 = new ImmDouble(2.1).clone();
//line 28
___nl__2 = array_NL.NL_len(___nl__0).clone();

//line 28
___nl__3 = new ImmDouble(1).clone();
//line 28
___nl__4 = c_rt_lib_NL.NL_get_true().clone();
//line 28
assert_NL.NL_assert(___nl__1,___nl__2,___nl__3,___nl__4);

//line 28
___nl__4 = null;
//line 28
___nl__3 = null;
//line 28
___nl__2 = null;
//line 28
___nl__1 = null;
//line 29
___nl__1 = new ImmDouble(2.2).clone();
//line 29
___nl__3 = new ImmDouble(0).clone();
//line 29
___nl__2 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__3).getDoubleValue()].clone();
//line 29
___nl__3 = null;
//line 29
___nl__3 = new ImmDouble(1).clone();
//line 29
___nl__4 = c_rt_lib_NL.NL_get_true().clone();
//line 29
assert_NL.NL_assert(___nl__1,___nl__2,___nl__3,___nl__4);

//line 29
___nl__4 = null;
//line 29
___nl__3 = null;
//line 29
___nl__2 = null;
//line 29
___nl__1 = null;
//line 31
___nl__1 = new ImmArray(new Imm[0]).clone();
//line 32
___nl__2 = new ImmDouble(10).clone();
//line 32
___nl__3 = new ImmDouble(0).clone();
//line 32
___nl__4 = new ImmDouble(1).clone();
//line 32
label_3:
//line 32
___nl__5 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))>=(Double.Parse(___nl__2.getValue().ToString())) ).clone();
//line 32
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_1;}}
//line 33
array_NL.NL_push(ref ___nl__1,___nl__3);

//line 34
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString()))).clone();
//line 34
if (true) {goto label_3;}
//line 34
label_1:
//line 34
___nl__2 = null;
//line 34
___nl__3 = null;
//line 34
___nl__4 = null;
//line 34
___nl__5 = null;
//line 35
___nl__2 = new ImmDouble(2.3).clone();
//line 35
___nl__3 = array_NL.NL_len(___nl__1).clone();

//line 35
___nl__4 = new ImmDouble(10).clone();
//line 35
___nl__5 = c_rt_lib_NL.NL_get_true().clone();
//line 35
assert_NL.NL_assert(___nl__2,___nl__3,___nl__4,___nl__5);

//line 35
___nl__5 = null;
//line 35
___nl__4 = null;
//line 35
___nl__3 = null;
//line 35
___nl__2 = null;
//line 36
___nl__2 = new ImmDouble(2.4).clone();
//line 36
___nl__4 = new ImmDouble(0).clone();
//line 36
___nl__3 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()].clone();
//line 36
___nl__4 = null;
//line 36
___nl__4 = new ImmDouble(0).clone();
//line 36
___nl__5 = c_rt_lib_NL.NL_get_true().clone();
//line 36
assert_NL.NL_assert(___nl__2,___nl__3,___nl__4,___nl__5);

//line 36
___nl__5 = null;
//line 36
___nl__4 = null;
//line 36
___nl__3 = null;
//line 36
___nl__2 = null;
//line 37
___nl__2 = new ImmDouble(2.5).clone();
//line 37
___nl__4 = new ImmDouble(9).clone();
//line 37
___nl__3 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()].clone();
//line 37
___nl__4 = null;
//line 37
___nl__4 = new ImmDouble(9).clone();
//line 37
___nl__5 = c_rt_lib_NL.NL_get_true().clone();
//line 37
assert_NL.NL_assert(___nl__2,___nl__3,___nl__4,___nl__5);

//line 37
___nl__5 = null;
//line 37
___nl__4 = null;
//line 37
___nl__3 = null;
//line 37
___nl__2 = null;
//line 37
___nl__0 = null;
//line 37
___nl__1 = null;
//line 37
if(true) return null;
}

private static Imm NL_test3_priv() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Dictionary<String, Imm> __function_map;
//line 41
___nl__0 = new ImmArray(new Imm[0]).clone();
//line 42
___nl__1 = new ImmDouble(1).clone();
//line 42
array_NL.NL_push(ref ___nl__0,___nl__1);

//line 42
___nl__1 = null;
//line 43
___nl__1 = new ImmDouble(3.1).clone();
//line 43
___nl__2 = array_NL.NL_len(___nl__0).clone();

//line 43
___nl__3 = new ImmDouble(1).clone();
//line 43
___nl__4 = c_rt_lib_NL.NL_get_true().clone();
//line 43
assert_NL.NL_assert(___nl__1,___nl__2,___nl__3,___nl__4);

//line 43
___nl__4 = null;
//line 43
___nl__3 = null;
//line 43
___nl__2 = null;
//line 43
___nl__1 = null;
//line 44
___nl__1 = new ImmDouble(3.2).clone();
//line 44
___nl__3 = new ImmDouble(0).clone();
//line 44
___nl__2 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__3).getDoubleValue()].clone();
//line 44
___nl__3 = null;
//line 44
___nl__3 = new ImmDouble(1).clone();
//line 44
___nl__4 = c_rt_lib_NL.NL_get_true().clone();
//line 44
assert_NL.NL_assert(___nl__1,___nl__2,___nl__3,___nl__4);

//line 44
___nl__4 = null;
//line 44
___nl__3 = null;
//line 44
___nl__2 = null;
//line 44
___nl__1 = null;
//line 46
___nl__1 = ___nl__0.clone();
//line 47
___nl__2 = new ImmDouble(3.3).clone();
//line 47
___nl__3 = c_rt_lib_NL.NL_get_true().clone();
//line 47
assert_NL.NL_assert(___nl__2,___nl__0,___nl__1,___nl__3);

//line 47
___nl__3 = null;
//line 47
___nl__2 = null;
//line 49
___nl__2 = new ImmDouble(2).clone();
//line 49
array_NL.NL_push(ref ___nl__1,___nl__2);

//line 49
___nl__2 = null;
//line 50
___nl__2 = new ImmDouble(3.4).clone();
//line 50
___nl__3 = array_NL.NL_len(___nl__1).clone();

//line 50
___nl__4 = new ImmDouble(2).clone();
//line 50
___nl__5 = c_rt_lib_NL.NL_get_true().clone();
//line 50
assert_NL.NL_assert(___nl__2,___nl__3,___nl__4,___nl__5);

//line 50
___nl__5 = null;
//line 50
___nl__4 = null;
//line 50
___nl__3 = null;
//line 50
___nl__2 = null;
//line 51
___nl__2 = new ImmDouble(3.5).clone();
//line 51
___nl__4 = new ImmDouble(0).clone();
//line 51
___nl__3 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()].clone();
//line 51
___nl__4 = null;
//line 51
___nl__4 = new ImmDouble(1).clone();
//line 51
___nl__5 = c_rt_lib_NL.NL_get_true().clone();
//line 51
assert_NL.NL_assert(___nl__2,___nl__3,___nl__4,___nl__5);

//line 51
___nl__5 = null;
//line 51
___nl__4 = null;
//line 51
___nl__3 = null;
//line 51
___nl__2 = null;
//line 52
___nl__2 = new ImmDouble(3.6).clone();
//line 52
___nl__4 = new ImmDouble(1).clone();
//line 52
___nl__3 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()].clone();
//line 52
___nl__4 = null;
//line 52
___nl__4 = new ImmDouble(2).clone();
//line 52
___nl__5 = c_rt_lib_NL.NL_get_true().clone();
//line 52
assert_NL.NL_assert(___nl__2,___nl__3,___nl__4,___nl__5);

//line 52
___nl__5 = null;
//line 52
___nl__4 = null;
//line 52
___nl__3 = null;
//line 52
___nl__2 = null;
//line 53
___nl__2 = new ImmDouble(3.7).clone();
//line 53
___nl__3 = c_rt_lib_NL.NL_get_false().clone();
//line 53
assert_NL.NL_assert(___nl__2,___nl__0,___nl__1,___nl__3);

//line 53
___nl__3 = null;
//line 53
___nl__2 = null;
//line 53
___nl__0 = null;
//line 53
___nl__1 = null;
//line 53
if(true) return null;
}

private static Imm NL_test45_f1_priv(ref Imm ___arg__0) {
Imm ___nl__0 = ___arg__0;
Imm ___nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 57
___nl__1 = new ImmDouble(5).clone();
//line 57
___nl__0 = ___nl__1.clone();
//line 57
___nl__1 = null;
//line 57
___arg__0 = ___nl__0;if(true) return null;
}

private static Imm NL_test4_priv() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Dictionary<String, Imm> __function_map;
//line 61
___nl__0 = new ImmArray(new Imm[0]).clone();
//line 62
___nl__1 = new ImmDouble(1).clone();
//line 62
array_NL.NL_push(ref ___nl__0,___nl__1);

//line 62
___nl__1 = null;
//line 63
___nl__1 = new ImmDouble(4.1).clone();
//line 63
___nl__2 = array_NL.NL_len(___nl__0).clone();

//line 63
___nl__3 = new ImmDouble(1).clone();
//line 63
___nl__4 = c_rt_lib_NL.NL_get_true().clone();
//line 63
assert_NL.NL_assert(___nl__1,___nl__2,___nl__3,___nl__4);

//line 63
___nl__4 = null;
//line 63
___nl__3 = null;
//line 63
___nl__2 = null;
//line 63
___nl__1 = null;
//line 64
___nl__1 = new ImmDouble(4.2).clone();
//line 64
___nl__3 = new ImmDouble(0).clone();
//line 64
___nl__2 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__3).getDoubleValue()].clone();
//line 64
___nl__3 = null;
//line 64
___nl__3 = new ImmDouble(1).clone();
//line 64
___nl__4 = c_rt_lib_NL.NL_get_true().clone();
//line 64
assert_NL.NL_assert(___nl__1,___nl__2,___nl__3,___nl__4);

//line 64
___nl__4 = null;
//line 64
___nl__3 = null;
//line 64
___nl__2 = null;
//line 64
___nl__1 = null;
//line 66
___nl__1 = ___nl__0.clone();
//line 67
___nl__2 = new ImmDouble(4.3).clone();
//line 67
___nl__3 = c_rt_lib_NL.NL_get_true().clone();
//line 67
assert_NL.NL_assert(___nl__2,___nl__0,___nl__1,___nl__3);

//line 67
___nl__3 = null;
//line 67
___nl__2 = null;
//line 69
___nl__3 = new ImmDouble(0).clone();
//line 69
___nl__2 = c_rt_lib_NL.NL_get_ref_arr(___nl__0,___nl__3).clone();

//line 69
ref_test_NL.NL_test45_f1_priv(ref ___nl__2);

//line 69
c_rt_lib_NL.NL_set_ref_arr(ref ___nl__0,___nl__3,___nl__2);

//line 69
___nl__2 = null;
//line 69
___nl__3 = null;
//line 70
___nl__2 = new ImmDouble(4.4).clone();
//line 70
___nl__4 = new ImmDouble(0).clone();
//line 70
___nl__3 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()].clone();
//line 70
___nl__4 = null;
//line 70
___nl__4 = new ImmDouble(5).clone();
//line 70
___nl__5 = c_rt_lib_NL.NL_get_true().clone();
//line 70
assert_NL.NL_assert(___nl__2,___nl__3,___nl__4,___nl__5);

//line 70
___nl__5 = null;
//line 70
___nl__4 = null;
//line 70
___nl__3 = null;
//line 70
___nl__2 = null;
//line 71
___nl__2 = new ImmDouble(4.5).clone();
//line 71
___nl__3 = c_rt_lib_NL.NL_get_false().clone();
//line 71
assert_NL.NL_assert(___nl__2,___nl__0,___nl__1,___nl__3);

//line 71
___nl__3 = null;
//line 71
___nl__2 = null;
//line 71
___nl__0 = null;
//line 71
___nl__1 = null;
//line 71
if(true) return null;
}

private static Imm NL_test5_priv() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Dictionary<String, Imm> __function_map;
//line 75
___nl__0 = new ImmArray(new Imm[0]).clone();
//line 76
___nl__2 = new ImmDouble(1).clone();
//line 76
___nl__1 = new ImmArray(new Imm[] {___nl__2,}).clone();
//line 76
___nl__2 = null;
//line 76
array_NL.NL_push(ref ___nl__0,___nl__1);

//line 76
___nl__1 = null;
//line 77
___nl__1 = new ImmDouble(5.1).clone();
//line 77
___nl__2 = array_NL.NL_len(___nl__0).clone();

//line 77
___nl__3 = new ImmDouble(1).clone();
//line 77
___nl__4 = c_rt_lib_NL.NL_get_true().clone();
//line 77
assert_NL.NL_assert(___nl__1,___nl__2,___nl__3,___nl__4);

//line 77
___nl__4 = null;
//line 77
___nl__3 = null;
//line 77
___nl__2 = null;
//line 77
___nl__1 = null;
//line 78
___nl__1 = new ImmDouble(5.2).clone();
//line 78
___nl__3 = new ImmDouble(0).clone();
//line 78
___nl__2 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__3).getDoubleValue()].clone();
//line 78
___nl__3 = null;
//line 78
___nl__4 = new ImmDouble(1).clone();
//line 78
___nl__3 = new ImmArray(new Imm[] {___nl__4,}).clone();
//line 78
___nl__4 = null;
//line 78
___nl__4 = c_rt_lib_NL.NL_get_true().clone();
//line 78
assert_NL.NL_assert(___nl__1,___nl__2,___nl__3,___nl__4);

//line 78
___nl__4 = null;
//line 78
___nl__3 = null;
//line 78
___nl__2 = null;
//line 78
___nl__1 = null;
//line 80
___nl__1 = ___nl__0.clone();
//line 81
___nl__2 = new ImmDouble(5.3).clone();
//line 81
___nl__3 = c_rt_lib_NL.NL_get_true().clone();
//line 81
assert_NL.NL_assert(___nl__2,___nl__0,___nl__1,___nl__3);

//line 81
___nl__3 = null;
//line 81
___nl__2 = null;
//line 83
___nl__3 = new ImmDouble(0).clone();
//line 83
___nl__2 = c_rt_lib_NL.NL_get_ref_arr(___nl__0,___nl__3).clone();

//line 83
___nl__5 = new ImmDouble(0).clone();
//line 83
___nl__4 = c_rt_lib_NL.NL_get_ref_arr(___nl__2,___nl__5).clone();

//line 83
ref_test_NL.NL_test45_f1_priv(ref ___nl__4);

//line 83
c_rt_lib_NL.NL_set_ref_arr(ref ___nl__2,___nl__5,___nl__4);

//line 83
c_rt_lib_NL.NL_set_ref_arr(ref ___nl__0,___nl__3,___nl__2);

//line 83
___nl__2 = null;
//line 83
___nl__3 = null;
//line 83
___nl__4 = null;
//line 83
___nl__5 = null;
//line 84
___nl__2 = new ImmDouble(5.4).clone();
//line 84
___nl__4 = new ImmDouble(0).clone();
//line 84
___nl__3 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()].clone();
//line 84
___nl__4 = null;
//line 84
___nl__4 = new ImmDouble(0).clone();
//line 84
___nl__3 = (___nl__3 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()].clone();
//line 84
___nl__4 = null;
//line 84
___nl__4 = new ImmDouble(5).clone();
//line 84
___nl__5 = c_rt_lib_NL.NL_get_true().clone();
//line 84
assert_NL.NL_assert(___nl__2,___nl__3,___nl__4,___nl__5);

//line 84
___nl__5 = null;
//line 84
___nl__4 = null;
//line 84
___nl__3 = null;
//line 84
___nl__2 = null;
//line 85
___nl__2 = new ImmDouble(5.5).clone();
//line 85
___nl__3 = c_rt_lib_NL.NL_get_false().clone();
//line 85
assert_NL.NL_assert(___nl__2,___nl__0,___nl__1,___nl__3);

//line 85
___nl__3 = null;
//line 85
___nl__2 = null;
//line 85
___nl__0 = null;
//line 85
___nl__1 = null;
//line 85
if(true) return null;
}

public static Imm NL_test() {

Imm ___nl__0 = null;
Dictionary<String, Imm> __function_map;
//line 89
___nl__0 = new ImmString("Ref test").clone();
//line 89
assert_NL.NL_section(___nl__0);

//line 89
___nl__0 = null;
//line 90
ref_test_NL.NL_test1_priv();

//line 91
ref_test_NL.NL_test2_priv();

//line 92
ref_test_NL.NL_test3_priv();

//line 93
ref_test_NL.NL_test4_priv();

//line 94
ref_test_NL.NL_test5_priv();

//line 94
if(true) return null;
}

}
}