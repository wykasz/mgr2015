using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class forh_test_NL {

public static Imm NL_test() {

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
Dictionary<String, Imm> __function_map;
//line 7
___nl__0 = new ImmString("Forh test").clone();
//line 7
assert_NL.NL_section(___nl__0);

//line 7
___nl__0 = null;
//line 9
___nl__1 = new ImmString("xx").clone();
//line 9
___nl__2 = new ImmString("yy").clone();
//line 9
___nl__3 = new ImmString("zz").clone();
//line 9
__function_map = new Dictionary<String, Imm>();
__function_map.Add("a",___nl__1);
__function_map.Add("b",___nl__2);
__function_map.Add("c",___nl__3);
___nl__0 = new ImmHash(__function_map).clone();
//line 9
___nl__1 = null;
//line 9
___nl__2 = null;
//line 9
___nl__3 = null;
//line 10
__function_map = new Dictionary<String, Imm>();
___nl__1 = new ImmHash(__function_map).clone();
//line 11
___nl__4 = c_rt_lib_NL.NL_init_iter(___nl__0).clone();

//line 11
label_3:
//line 11
___nl__2 = c_rt_lib_NL.NL_is_end_hash(___nl__4).clone();

//line 11
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_1;}}
//line 11
___nl__2 = c_rt_lib_NL.NL_get_key_iter(___nl__4).clone();

//line 11
___nl__3 = c_rt_lib_NL.NL_hash_get_value(___nl__0,___nl__2).clone();

//line 12
___nl__5 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 12
___nl__6 = new ImmDouble(1).clone();
//line 12
hash_NL.NL_set_value(ref ___nl__1,___nl__5,___nl__6);

//line 12
___nl__6 = null;
//line 12
___nl__5 = null;
//line 13
___nl__4 = c_rt_lib_NL.NL_next_iter(___nl__4).clone();

//line 13
if (true) {goto label_3;}
//line 13
label_1:
//line 13
___nl__2 = null;
//line 13
___nl__3 = null;
//line 13
___nl__4 = null;
//line 14
___nl__2 = new ImmDouble(1).clone();
//line 14
___nl__4 = new ImmString("axx").clone();
//line 14
___nl__3 = hash_NL.NL_has_key(___nl__1,___nl__4).clone();

//line 14
___nl__4 = null;
//line 14
___nl__4 = c_rt_lib_NL.NL_get_true().clone();
//line 14
assert_NL.NL_assert_s(___nl__2,___nl__3,___nl__4);

//line 14
___nl__4 = null;
//line 14
___nl__3 = null;
//line 14
___nl__2 = null;
//line 15
___nl__2 = new ImmDouble(2).clone();
//line 15
___nl__4 = new ImmString("byy").clone();
//line 15
___nl__3 = hash_NL.NL_has_key(___nl__1,___nl__4).clone();

//line 15
___nl__4 = null;
//line 15
___nl__4 = c_rt_lib_NL.NL_get_true().clone();
//line 15
assert_NL.NL_assert_s(___nl__2,___nl__3,___nl__4);

//line 15
___nl__4 = null;
//line 15
___nl__3 = null;
//line 15
___nl__2 = null;
//line 16
___nl__2 = new ImmDouble(3).clone();
//line 16
___nl__4 = new ImmString("czz").clone();
//line 16
___nl__3 = hash_NL.NL_has_key(___nl__1,___nl__4).clone();

//line 16
___nl__4 = null;
//line 16
___nl__4 = c_rt_lib_NL.NL_get_true().clone();
//line 16
assert_NL.NL_assert_s(___nl__2,___nl__3,___nl__4);

//line 16
___nl__4 = null;
//line 16
___nl__3 = null;
//line 16
___nl__2 = null;
//line 17
___nl__2 = new ImmDouble(4).clone();
//line 17
___nl__3 = hash_NL.NL_size(___nl__1).clone();

//line 17
___nl__4 = new ImmDouble(3).clone();
//line 17
___nl__5 = c_rt_lib_NL.NL_get_true().clone();
//line 17
assert_NL.NL_assert(___nl__2,___nl__3,___nl__4,___nl__5);

//line 17
___nl__5 = null;
//line 17
___nl__4 = null;
//line 17
___nl__3 = null;
//line 17
___nl__2 = null;
//line 18
___nl__2 = new ImmDouble(0).clone();
//line 19
label_5:
//line 20
___nl__3 = new ImmDouble(10).clone();
//line 20
___nl__3 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__2.getValue().ToString())) ==((Double.Parse(___nl__3.getValue().ToString())))  ).clone();
//line 20
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 20
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_8;}}
//line 20
___nl__3 = null;
//line 20
if (true) {goto label_4;}
//line 20
if (true) {goto label_8;}
//line 20
label_8:
//line 20
___nl__3 = null;
//line 21
___nl__3 = new ImmDouble(1).clone();
//line 21
___nl__2 = new ImmDouble((Double.Parse(___nl__2.getValue().ToString()))+(Double.Parse(___nl__3.getValue().ToString()))).clone();
//line 21
___nl__3 = null;
//line 22
if (true) {goto label_5;}
//line 22
label_4:
//line 23
___nl__3 = new ImmDouble(5).clone();
//line 23
___nl__4 = new ImmDouble(10).clone();
//line 23
___nl__5 = c_rt_lib_NL.NL_get_true().clone();
//line 23
assert_NL.NL_assert(___nl__3,___nl__2,___nl__4,___nl__5);

//line 23
___nl__5 = null;
//line 23
___nl__4 = null;
//line 23
___nl__3 = null;
//line 24
___nl__3 = new ImmArray(new Imm[0]).clone();
//line 25
forh_test_NL.NL_exec2_priv(ref ___nl__3);

//line 27
___nl__5 = new ImmString("").clone();
//line 27
__function_map = new Dictionary<String, Imm>();
__function_map.Add("arr",___nl__3);
__function_map.Add("inne",___nl__5);
___nl__4 = new ImmHash(__function_map).clone();
//line 27
___nl__5 = null;
//line 28
___nl__5 = new ImmDouble(100).clone();
//line 28
___nl__6 = new ImmDouble(0).clone();
//line 28
___nl__7 = new ImmDouble(1).clone();
//line 28
label_11:
//line 28
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__6.getValue().ToString()))>=(Double.Parse(___nl__5.getValue().ToString())) ).clone();
//line 28
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_9;}}
//line 28
___nl__9 = new ImmString("arr").clone();
//line 28
___nl__9 = c_rt_lib_NL.NL_get_ref_hash(___nl__4,___nl__9).clone();

//line 28
forh_test_NL.NL_exec_priv(ref ___nl__9,___nl__6);

//line 28
___nl__10 = new ImmString("arr").clone();
//line 28
c_rt_lib_NL.NL_set_ref_hash(ref ___nl__4,___nl__10,___nl__9);

//line 28
___nl__10 = null;
//line 28
___nl__9 = null;
//line 28
___nl__6 = new ImmDouble((Double.Parse(___nl__6.getValue().ToString()))+(Double.Parse(___nl__7.getValue().ToString()))).clone();
//line 28
if (true) {goto label_11;}
//line 28
label_9:
//line 28
___nl__5 = null;
//line 28
___nl__6 = null;
//line 28
___nl__7 = null;
//line 28
___nl__8 = null;
//line 30
___nl__5 = new ImmDouble(100).clone();
//line 30
___nl__6 = new ImmDouble(0).clone();
//line 30
___nl__7 = new ImmDouble(1).clone();
//line 30
label_14:
//line 30
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__6.getValue().ToString()))>=(Double.Parse(___nl__5.getValue().ToString())) ).clone();
//line 30
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_12;}}
//line 30
___nl__9 = new ImmString("arr").clone();
//line 30
___nl__9 = c_rt_lib_NL.NL_get_ref_hash(___nl__4,___nl__9).clone();

//line 30
___nl__10 = c_rt_lib_NL.NL_get_ref_arr(___nl__9,___nl__6).clone();

//line 30
___nl__10 = new ImmDouble((Double.Parse(___nl__10.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString()))).clone();
//line 30
c_rt_lib_NL.NL_set_ref_arr(ref ___nl__9,___nl__6,___nl__10);

//line 30
___nl__11 = new ImmString("arr").clone();
//line 30
c_rt_lib_NL.NL_set_ref_hash(ref ___nl__4,___nl__11,___nl__9);

//line 30
___nl__11 = null;
//line 30
___nl__9 = null;
//line 30
___nl__10 = null;
//line 30
___nl__6 = new ImmDouble((Double.Parse(___nl__6.getValue().ToString()))+(Double.Parse(___nl__7.getValue().ToString()))).clone();
//line 30
if (true) {goto label_14;}
//line 30
label_12:
//line 30
___nl__5 = null;
//line 30
___nl__6 = null;
//line 30
___nl__7 = null;
//line 30
___nl__8 = null;
//line 32
__function_map = new Dictionary<String, Imm>();
___nl__5 = new ImmHash(__function_map).clone();
//line 33
___nl__6 = new ImmDouble(100).clone();
//line 33
___nl__7 = new ImmDouble(0).clone();
//line 33
___nl__8 = new ImmDouble(1).clone();
//line 33
label_17:
//line 33
___nl__9 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) ).clone();
//line 33
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_15;}}
//line 34
___nl__10 = c_rt_lib_NL.NL_get_true().clone();
//line 34
hash_NL.NL_set_value(ref ___nl__5,___nl__7,___nl__10);

//line 34
___nl__10 = null;
//line 35
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString()))).clone();
//line 35
if (true) {goto label_17;}
//line 35
label_15:
//line 35
___nl__6 = null;
//line 35
___nl__7 = null;
//line 35
___nl__8 = null;
//line 35
___nl__9 = null;
//line 36
___nl__6 = new ImmDouble(100).clone();
//line 36
___nl__7 = new ImmDouble(0).clone();
//line 36
___nl__8 = new ImmDouble(1).clone();
//line 36
label_20:
//line 36
___nl__9 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) ).clone();
//line 36
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_18;}}
//line 37
hash_NL.NL_delete(ref ___nl__5,___nl__7);

//line 38
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString()))).clone();
//line 38
if (true) {goto label_20;}
//line 38
label_18:
//line 38
___nl__6 = null;
//line 38
___nl__7 = null;
//line 38
___nl__8 = null;
//line 38
___nl__9 = null;
//line 39
___nl__6 = new ImmDouble(6).clone();
//line 39
___nl__7 = hash_NL.NL_size(___nl__5).clone();

//line 39
___nl__8 = new ImmDouble(0).clone();
//line 39
___nl__9 = c_rt_lib_NL.NL_get_true().clone();
//line 39
assert_NL.NL_assert(___nl__6,___nl__7,___nl__8,___nl__9);

//line 39
___nl__9 = null;
//line 39
___nl__8 = null;
//line 39
___nl__7 = null;
//line 39
___nl__6 = null;
//line 39
___nl__0 = null;
//line 39
___nl__1 = null;
//line 39
___nl__2 = null;
//line 39
___nl__3 = null;
//line 39
___nl__4 = null;
//line 39
___nl__5 = null;
//line 39
if(true) return null;
}

private static Imm NL_exec_priv(ref Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0;Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 43
array_NL.NL_push(ref ___nl__0,___nl__1);

//line 44
___nl__3 = new ImmDouble(0).clone();
//line 44
___nl__2 = ___nl__1.clone();
//line 44
(___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__3).getDoubleValue()] = ___nl__2;
//line 44
___nl__2 = null;
//line 44
___nl__3 = null;
//line 45
___nl__2 = c_rt_lib_NL.NL_get_false().clone();
//line 45
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 45
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 46
___nl__1 = null;
//line 46
___nl__2 = null;
//line 46
___arg__0 = ___nl__0;if(true) return null;
//line 47
if (true) {goto label_1;}
//line 47
label_2:
//line 49
___nl__1 = null;
//line 49
___nl__2 = null;
//line 49
___arg__0 = ___nl__0;if(true) return null;
//line 48
if (true) {goto label_2;}
//line 51
if (true) {goto label_1;}
//line 51
label_1:
//line 51
___nl__2 = null;
//line 51
___nl__1 = null;
//line 51
___arg__0 = ___nl__0;if(true) return null;
}

private static Imm NL_exec2_priv(ref Imm ___arg__0) {
Imm ___nl__0 = ___arg__0;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 55
___nl__1 = new ImmDouble(100000).clone();
//line 55
___nl__2 = new ImmDouble(0).clone();
//line 55
___nl__3 = new ImmDouble(1).clone();
//line 55
label_3:
//line 55
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__2.getValue().ToString()))>=(Double.Parse(___nl__1.getValue().ToString())) ).clone();
//line 55
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_1;}}
//line 55
array_NL.NL_push(ref ___nl__0,___nl__2);

//line 55
___nl__2 = new ImmDouble((Double.Parse(___nl__2.getValue().ToString()))+(Double.Parse(___nl__3.getValue().ToString()))).clone();
//line 55
if (true) {goto label_3;}
//line 55
label_1:
//line 55
___nl__1 = null;
//line 55
___nl__2 = null;
//line 55
___nl__3 = null;
//line 55
___nl__4 = null;
//line 55
___arg__0 = ___nl__0;if(true) return null;
}

}
}