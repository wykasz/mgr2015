using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class complexity_test_NL {

private static Imm NL_test1_f1_priv(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 8
___nl__1 = new ImmArray(new Imm[0]).clone();
//line 9
___nl__2 = new ImmDouble(0).clone();
//line 9
___nl__3 = new ImmDouble(1).clone();
//line 9
label_3:
//line 9
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__2.getValue().ToString()))>=(Double.Parse(___nl__0.getValue().ToString())) ).clone();
//line 9
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_1;}}
//line 10
array_NL.NL_push(ref ___nl__1,___nl__2);

//line 11
___nl__2 = new ImmDouble((Double.Parse(___nl__2.getValue().ToString()))+(Double.Parse(___nl__3.getValue().ToString()))).clone();
//line 11
if (true) {goto label_3;}
//line 11
label_1:
//line 11
___nl__2 = null;
//line 11
___nl__3 = null;
//line 11
___nl__4 = null;
//line 11
___nl__1 = null;
//line 11
___nl__0 = null;
//line 11
if(true) return null;
}

private static Imm NL_test1_priv() {

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
Dictionary<String, Imm> __function_map;
//line 15
___nl__0 = new ImmString("Array push test").clone();
//line 15
assert_NL.NL_section(___nl__0);

//line 15
___nl__0 = null;
//line 17
___nl__0 = new ImmDouble(10).clone();
//line 18
___nl__1 = new ImmDouble(2).clone();
//line 19
___nl__2 = new ImmDouble(1).clone();
//line 20
___nl__3 = new ImmDouble(1000).clone();
//line 21
___nl__4 = new ImmArray(new Imm[0]).clone();
//line 23
___nl__5 = new ImmDouble(1).clone();
//line 23
___nl__5 = new ImmDouble((Double.Parse(___nl__0.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 23
___nl__6 = new ImmDouble(0).clone();
//line 23
___nl__7 = new ImmDouble(1).clone();
//line 23
label_3:
//line 23
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__6.getValue().ToString()))>=(Double.Parse(___nl__5.getValue().ToString())) ).clone();
//line 23
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_1;}}
//line 25
___nl__9 = c_fe_lib_NL.NL_get_time().clone();

//line 26
___nl__10 = new ImmDouble(0).clone();
//line 26
___nl__11 = new ImmDouble(1).clone();
//line 26
label_6:
//line 26
___nl__12 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__10.getValue().ToString()))>=(Double.Parse(___nl__3.getValue().ToString())) ).clone();
//line 26
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_4;}}
//line 27
complexity_test_NL.NL_test1_f1_priv(___nl__2);

//line 28
___nl__10 = new ImmDouble((Double.Parse(___nl__10.getValue().ToString()))+(Double.Parse(___nl__11.getValue().ToString()))).clone();
//line 28
if (true) {goto label_6;}
//line 28
label_4:
//line 28
___nl__10 = null;
//line 28
___nl__11 = null;
//line 28
___nl__12 = null;
//line 29
___nl__10 = c_fe_lib_NL.NL_get_time().clone();

//line 31
___nl__13 = new ImmDouble(0).clone();
//line 31
___nl__12 = (___nl__10 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__13).getDoubleValue()].clone();
//line 31
___nl__13 = null;
//line 31
___nl__14 = new ImmDouble(0).clone();
//line 31
___nl__13 = (___nl__9 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__14).getDoubleValue()].clone();
//line 31
___nl__14 = null;
//line 31
___nl__12 = new ImmDouble((Double.Parse(___nl__12.getValue().ToString()))-(Double.Parse(___nl__13.getValue().ToString()))).clone();
//line 31
___nl__13 = null;
//line 31
___nl__14 = new ImmDouble(0).clone();
//line 31
___nl__13 = (___nl__10 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__14).getDoubleValue()].clone();
//line 31
___nl__14 = null;
//line 31
___nl__15 = new ImmDouble(0).clone();
//line 31
___nl__14 = (___nl__9 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__15).getDoubleValue()].clone();
//line 31
___nl__15 = null;
//line 31
___nl__13 = new ImmDouble((Double.Parse(___nl__13.getValue().ToString()))-(Double.Parse(___nl__14.getValue().ToString()))).clone();
//line 31
___nl__14 = null;
//line 31
___nl__13 = new ImmDouble((Double.Parse(___nl__13.getValue().ToString()))/(Double.Parse(___nl__2.getValue().ToString()))).clone();
//line 31
___nl__14 = new ImmDouble(0).clone();
//line 31
___nl__15 = new ImmDouble(0).clone();
//line 31
__function_map = new Dictionary<String, Imm>();
__function_map.Add("size",___nl__2);
__function_map.Add("time",___nl__12);
__function_map.Add("tps",___nl__13);
__function_map.Add("time_vs_base",___nl__14);
__function_map.Add("time_vs_base_vs_size",___nl__15);
___nl__11 = new ImmHash(__function_map).clone();
//line 31
___nl__12 = null;
//line 31
___nl__13 = null;
//line 31
___nl__14 = null;
//line 31
___nl__15 = null;
//line 31
array_NL.NL_push(ref ___nl__4,___nl__11);

//line 31
___nl__11 = null;
//line 39
___nl__2 = new ImmDouble((Double.Parse(___nl__2.getValue().ToString()))*(Double.Parse(___nl__1.getValue().ToString()))).clone();
//line 39
___nl__9 = null;
//line 39
___nl__10 = null;
//line 40
___nl__6 = new ImmDouble((Double.Parse(___nl__6.getValue().ToString()))+(Double.Parse(___nl__7.getValue().ToString()))).clone();
//line 40
if (true) {goto label_3;}
//line 40
label_1:
//line 40
___nl__5 = null;
//line 40
___nl__6 = null;
//line 40
___nl__7 = null;
//line 40
___nl__8 = null;
//line 42
___nl__6 = new ImmDouble(0).clone();
//line 42
___nl__5 = (___nl__4 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()].clone();
//line 42
___nl__6 = null;
//line 42
___nl__5 = ((ImmHash)___nl__5).getHashValue()["time"].clone();
//line 43
___nl__6 = new ImmDouble(1).clone();
//line 43
___nl__6 = new ImmDouble((Double.Parse(___nl__0.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString()))).clone();
//line 43
___nl__7 = new ImmDouble(0).clone();
//line 43
___nl__8 = new ImmDouble(1).clone();
//line 43
label_9:
//line 43
___nl__9 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) ).clone();
//line 43
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_7;}}
//line 44
___nl__10 = (___nl__4 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()].clone();
//line 44
___nl__10 = ((ImmHash)___nl__10).getHashValue()["time"].clone();
//line 45
___nl__11 = (___nl__4 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()].clone();
//line 45
___nl__11 = ((ImmHash)___nl__11).getHashValue()["size"].clone();
//line 47
___nl__12 = new ImmDouble((Double.Parse(___nl__10.getValue().ToString()))/(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 47
___nl__13 = c_rt_lib_NL.NL_get_ref_arr(___nl__4,___nl__7).clone();

//line 47
___nl__14 = ___nl__12.clone();
//line 47
((ImmHash)___nl__13).set("time_vs_base", ___nl__14);
//line 47
c_rt_lib_NL.NL_set_ref_arr(ref ___nl__4,___nl__7,___nl__13);

//line 47
___nl__12 = null;
//line 47
___nl__13 = null;
//line 47
___nl__14 = null;
//line 48
___nl__12 = new ImmDouble((Double.Parse(___nl__10.getValue().ToString()))/(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 48
___nl__12 = new ImmDouble((Double.Parse(___nl__12.getValue().ToString()))/(Double.Parse(___nl__11.getValue().ToString()))).clone();
//line 48
___nl__13 = c_rt_lib_NL.NL_get_ref_arr(___nl__4,___nl__7).clone();

//line 48
___nl__14 = ___nl__12.clone();
//line 48
((ImmHash)___nl__13).set("time_vs_base_vs_size", ___nl__14);
//line 48
c_rt_lib_NL.NL_set_ref_arr(ref ___nl__4,___nl__7,___nl__13);

//line 48
___nl__12 = null;
//line 48
___nl__13 = null;
//line 48
___nl__14 = null;
//line 48
___nl__10 = null;
//line 48
___nl__11 = null;
//line 49
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString()))).clone();
//line 49
if (true) {goto label_9;}
//line 49
label_7:
//line 49
___nl__6 = null;
//line 49
___nl__7 = null;
//line 49
___nl__8 = null;
//line 49
___nl__9 = null;
//line 51
___nl__6 = new ImmString("Array push result: ").clone();
//line 51
assert_NL.NL_print(___nl__6,___nl__4);

//line 51
___nl__6 = null;
//line 51
___nl__0 = null;
//line 51
___nl__1 = null;
//line 51
___nl__2 = null;
//line 51
___nl__3 = null;
//line 51
___nl__4 = null;
//line 51
___nl__5 = null;
//line 51
if(true) return null;
}

private static Imm NL_test2_priv() {

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
Dictionary<String, Imm> __function_map;
//line 55
___nl__0 = new ImmString("Array cp test").clone();
//line 55
assert_NL.NL_section(___nl__0);

//line 55
___nl__0 = null;
//line 57
___nl__0 = new ImmDouble(1000).clone();
//line 58
___nl__1 = new ImmDouble(1000).clone();
//line 58
___nl__2 = new ImmDouble(1).clone();
//line 58
___nl__1 = new ImmDouble((Double.Parse(___nl__1.getValue().ToString()))*(Double.Parse(___nl__2.getValue().ToString()))).clone();
//line 58
___nl__2 = null;
//line 59
___nl__2 = new ImmDouble(1000).clone();
//line 59
___nl__3 = new ImmDouble(10).clone();
//line 59
___nl__2 = new ImmDouble((Double.Parse(___nl__2.getValue().ToString()))*(Double.Parse(___nl__3.getValue().ToString()))).clone();
//line 59
___nl__3 = null;
//line 61
___nl__3 = new ImmDouble(1).clone();
//line 62
___nl__4 = new ImmDouble(0).clone();
//line 63
___nl__5 = new ImmDouble(2.1).clone();
//line 63
___nl__6 = c_rt_lib_NL.NL_get_false().clone();
//line 63
assert_NL.NL_assert(___nl__5,___nl__3,___nl__4,___nl__6);

//line 63
___nl__6 = null;
//line 63
___nl__5 = null;
//line 65
___nl__5 = c_fe_lib_NL.NL_get_time().clone();

//line 66
___nl__6 = new ImmDouble(0).clone();
//line 66
___nl__7 = new ImmDouble(1).clone();
//line 66
label_3:
//line 66
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__6.getValue().ToString()))>=(Double.Parse(___nl__0.getValue().ToString())) ).clone();
//line 66
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_1;}}
//line 67
___nl__4 = ___nl__3.clone();
//line 68
___nl__6 = new ImmDouble((Double.Parse(___nl__6.getValue().ToString()))+(Double.Parse(___nl__7.getValue().ToString()))).clone();
//line 68
if (true) {goto label_3;}
//line 68
label_1:
//line 68
___nl__6 = null;
//line 68
___nl__7 = null;
//line 68
___nl__8 = null;
//line 69
___nl__6 = c_fe_lib_NL.NL_get_time().clone();

//line 70
___nl__8 = new ImmDouble(0).clone();
//line 70
___nl__7 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()].clone();
//line 70
___nl__8 = null;
//line 70
___nl__9 = new ImmDouble(0).clone();
//line 70
___nl__8 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()].clone();
//line 70
___nl__9 = null;
//line 70
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))-(Double.Parse(___nl__8.getValue().ToString()))).clone();
//line 70
___nl__8 = null;
//line 72
___nl__8 = new ImmDouble(2.2).clone();
//line 72
___nl__9 = c_rt_lib_NL.NL_get_true().clone();
//line 72
assert_NL.NL_assert(___nl__8,___nl__3,___nl__4,___nl__9);

//line 72
___nl__9 = null;
//line 72
___nl__8 = null;
//line 75
___nl__8 = new ImmArray(new Imm[0]).clone();
//line 76
___nl__9 = new ImmDouble(0).clone();
//line 76
___nl__10 = new ImmDouble(1).clone();
//line 76
label_6:
//line 76
___nl__11 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__9.getValue().ToString()))>=(Double.Parse(___nl__1.getValue().ToString())) ).clone();
//line 76
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_4;}}
//line 77
array_NL.NL_push(ref ___nl__8,___nl__9);

//line 78
___nl__9 = new ImmDouble((Double.Parse(___nl__9.getValue().ToString()))+(Double.Parse(___nl__10.getValue().ToString()))).clone();
//line 78
if (true) {goto label_6;}
//line 78
label_4:
//line 78
___nl__9 = null;
//line 78
___nl__10 = null;
//line 78
___nl__11 = null;
//line 79
___nl__9 = new ImmArray(new Imm[0]).clone();
//line 80
___nl__10 = new ImmDouble(2.3).clone();
//line 80
___nl__11 = c_rt_lib_NL.NL_get_false().clone();
//line 80
assert_NL.NL_assert(___nl__10,___nl__8,___nl__9,___nl__11);

//line 80
___nl__11 = null;
//line 80
___nl__10 = null;
//line 82
___nl__10 = c_fe_lib_NL.NL_get_time().clone();

//line 84
___nl__11 = new ImmDouble(0).clone();
//line 84
___nl__12 = new ImmDouble(1).clone();
//line 84
label_9:
//line 84
___nl__13 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__11.getValue().ToString()))>=(Double.Parse(___nl__0.getValue().ToString())) ).clone();
//line 84
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_7;}}
//line 85
___nl__9 = ___nl__8.clone();
//line 86
___nl__11 = new ImmDouble((Double.Parse(___nl__11.getValue().ToString()))+(Double.Parse(___nl__12.getValue().ToString()))).clone();
//line 86
if (true) {goto label_9;}
//line 86
label_7:
//line 86
___nl__11 = null;
//line 86
___nl__12 = null;
//line 86
___nl__13 = null;
//line 87
___nl__11 = c_fe_lib_NL.NL_get_time().clone();

//line 88
___nl__13 = new ImmDouble(0).clone();
//line 88
___nl__12 = (___nl__11 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__13).getDoubleValue()].clone();
//line 88
___nl__13 = null;
//line 88
___nl__14 = new ImmDouble(0).clone();
//line 88
___nl__13 = (___nl__10 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__14).getDoubleValue()].clone();
//line 88
___nl__14 = null;
//line 88
___nl__12 = new ImmDouble((Double.Parse(___nl__12.getValue().ToString()))-(Double.Parse(___nl__13.getValue().ToString()))).clone();
//line 88
___nl__13 = null;
//line 89
___nl__13 = new ImmDouble(2.4).clone();
//line 89
___nl__14 = c_rt_lib_NL.NL_get_true().clone();
//line 89
assert_NL.NL_assert(___nl__13,___nl__8,___nl__9,___nl__14);

//line 89
___nl__14 = null;
//line 89
___nl__13 = null;
//line 91
___nl__13 = new ImmArray(new Imm[0]).clone();
//line 91
___nl__8 = ___nl__13.clone();
//line 91
___nl__13 = null;
//line 92
___nl__13 = new ImmDouble(0).clone();
//line 92
___nl__14 = new ImmDouble(1).clone();
//line 92
label_12:
//line 92
___nl__15 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__13.getValue().ToString()))>=(Double.Parse(___nl__2.getValue().ToString())) ).clone();
//line 92
if (c_rt_lib_NL.NL_check_true_native(___nl__15)) {if (true) {goto label_10;}}
//line 93
array_NL.NL_push(ref ___nl__8,___nl__13);

//line 94
___nl__13 = new ImmDouble((Double.Parse(___nl__13.getValue().ToString()))+(Double.Parse(___nl__14.getValue().ToString()))).clone();
//line 94
if (true) {goto label_12;}
//line 94
label_10:
//line 94
___nl__13 = null;
//line 94
___nl__14 = null;
//line 94
___nl__15 = null;
//line 95
___nl__13 = new ImmArray(new Imm[0]).clone();
//line 95
___nl__9 = ___nl__13.clone();
//line 95
___nl__13 = null;
//line 96
___nl__13 = new ImmDouble(2.5).clone();
//line 96
___nl__14 = c_rt_lib_NL.NL_get_false().clone();
//line 96
assert_NL.NL_assert(___nl__13,___nl__8,___nl__9,___nl__14);

//line 96
___nl__14 = null;
//line 96
___nl__13 = null;
//line 98
___nl__13 = c_fe_lib_NL.NL_get_time().clone();

//line 100
___nl__14 = new ImmDouble(0).clone();
//line 100
___nl__15 = new ImmDouble(1).clone();
//line 100
label_15:
//line 100
___nl__16 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__14.getValue().ToString()))>=(Double.Parse(___nl__0.getValue().ToString())) ).clone();
//line 100
if (c_rt_lib_NL.NL_check_true_native(___nl__16)) {if (true) {goto label_13;}}
//line 101
___nl__9 = ___nl__8.clone();
//line 102
___nl__14 = new ImmDouble((Double.Parse(___nl__14.getValue().ToString()))+(Double.Parse(___nl__15.getValue().ToString()))).clone();
//line 102
if (true) {goto label_15;}
//line 102
label_13:
//line 102
___nl__14 = null;
//line 102
___nl__15 = null;
//line 102
___nl__16 = null;
//line 103
___nl__14 = c_fe_lib_NL.NL_get_time().clone();

//line 104
___nl__16 = new ImmDouble(0).clone();
//line 104
___nl__15 = (___nl__14 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__16).getDoubleValue()].clone();
//line 104
___nl__16 = null;
//line 104
___nl__17 = new ImmDouble(0).clone();
//line 104
___nl__16 = (___nl__13 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__17).getDoubleValue()].clone();
//line 104
___nl__17 = null;
//line 104
___nl__15 = new ImmDouble((Double.Parse(___nl__15.getValue().ToString()))-(Double.Parse(___nl__16.getValue().ToString()))).clone();
//line 104
___nl__16 = null;
//line 105
___nl__16 = new ImmDouble(2.6).clone();
//line 105
___nl__17 = c_rt_lib_NL.NL_get_true().clone();
//line 105
assert_NL.NL_assert(___nl__16,___nl__8,___nl__9,___nl__17);

//line 105
___nl__17 = null;
//line 105
___nl__16 = null;
//line 107
___nl__16 = new ImmString("Base time").clone();
//line 107
assert_NL.NL_print(___nl__16,___nl__7);

//line 107
___nl__16 = null;
//line 108
___nl__16 = new ImmString("Test 1 time").clone();
//line 108
assert_NL.NL_print(___nl__16,___nl__12);

//line 108
___nl__16 = null;
//line 109
___nl__16 = new ImmString("Test 2 time").clone();
//line 109
assert_NL.NL_print(___nl__16,___nl__15);

//line 109
___nl__16 = null;
//line 109
___nl__0 = null;
//line 109
___nl__1 = null;
//line 109
___nl__2 = null;
//line 109
___nl__3 = null;
//line 109
___nl__4 = null;
//line 109
___nl__5 = null;
//line 109
___nl__6 = null;
//line 109
___nl__7 = null;
//line 109
___nl__8 = null;
//line 109
___nl__9 = null;
//line 109
___nl__10 = null;
//line 109
___nl__11 = null;
//line 109
___nl__12 = null;
//line 109
___nl__13 = null;
//line 109
___nl__14 = null;
//line 109
___nl__15 = null;
//line 109
if(true) return null;
}

public static Imm NL_test() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 113
___nl__0 = new ImmString("Complexity test").clone();
//line 113
assert_NL.NL_section(___nl__0);

//line 113
___nl__0 = null;
//line 114
___nl__0 = new ImmString("time: ").clone();
//line 114
___nl__1 = c_fe_lib_NL.NL_get_time().clone();

//line 114
assert_NL.NL_print(___nl__0,___nl__1);

//line 114
___nl__1 = null;
//line 114
___nl__0 = null;
//line 115
complexity_test_NL.NL_test1_priv();

//line 116
complexity_test_NL.NL_test2_priv();

//line 116
if(true) return null;
}

}
}