using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class test_mod_NL {

public static Imm NL_SINGLETON_test() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 8
___nl__0 = new ImmDouble(10).clone();
//line 9
___nl__1 = new ImmDouble(5).clone();
//line 10
___ref______nl__0 = new ImmRef(___nl__0);
test_mod_NL.NL_test_function_priv(___ref______nl__0,___nl__1);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 10
___nl__0 = null;
//line 10
___nl__1 = null;
//line 10
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_test = null;
public static Imm NL_test() {
	if (value__singleton__NL_SINGLETON_test == null) {
		value__singleton__NL_SINGLETON_test = NL_SINGLETON_test();
	}
	return value__singleton__NL_SINGLETON_test;
}
private static Imm NL_test_function_priv(ImmRef ___arg__0, Imm ___arg__1) {
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
//line 14
___nl__3 = new ImmDouble(1).clone();
//line 14
___nl__4 = new ImmDouble(2).clone();
//line 14
___nl__5 = new ImmDouble(3).clone();
//line 14
___nl__2 = new ImmArray(new Imm[] {___nl__3,___nl__4,___nl__5,}).clone();
//line 14
___nl__3 = null;
//line 14
___nl__4 = null;
//line 14
___nl__5 = null;
//line 15
___nl__4 = new ImmDouble(1).clone();
//line 15
___nl__5 = new ImmDouble(2).clone();
//line 15
___nl__6 = new ImmDouble(3).clone();
//line 15
___nl__7 = new ImmDouble(4).clone();
//line 15
__function_map = new Dictionary<String, Imm>();
__function_map.Add("a",___nl__4);
__function_map.Add("b",___nl__5);
__function_map.Add("c",___nl__6);
__function_map.Add("d",___nl__7);
___nl__3 = new ImmHash(__function_map).clone();
//line 15
___nl__4 = null;
//line 15
___nl__5 = null;
//line 15
___nl__6 = null;
//line 15
___nl__7 = null;
//line 16
___nl__4 = c_rt_lib_NL.NL_get_true().clone();
//line 16
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 16
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 16
new ImmDouble(1);
//line 16
if (true) {goto label_2;}
//line 16
label_2:
//line 16
___nl__4 = null;
//line 17
___nl__4 = c_rt_lib_NL.NL_get_true().clone();
//line 17
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 17
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 17
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_4;}}
//line 17
___nl__5 = new ImmArray(new Imm[0]).clone();
//line 17
c_rt_lib_NL.NL_die();
//line 17
if (true) {goto label_4;}
//line 17
label_4:
//line 17
___nl__4 = null;
//line 17
___nl__5 = null;
//line 18
label_6:
//line 18
___nl__4 = c_rt_lib_NL.NL_get_false().clone();
//line 18
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 18
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_5;}}
//line 18
___nl__5 = new ImmArray(new Imm[0]).clone();
//line 18
c_rt_lib_NL.NL_die();
//line 18
if (true) {goto label_6;}
//line 18
label_5:
//line 18
___nl__4 = null;
//line 18
___nl__5 = null;
//line 19
___nl__4 = new ImmDouble(0).clone();
//line 20
___nl__6 = new ImmDouble(0).clone();
//line 20
___nl__7 = new ImmDouble(1).clone();
//line 20
___nl__8 = c_rt_lib_NL.NL_array_len(___nl__2).clone();

//line 20
label_9:
//line 20
___nl__9 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__6.getValue().ToString()))>=(Double.Parse(___nl__8.getValue().ToString())) ).clone();
//line 20
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_7;}}
//line 20
___nl__5 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()].clone();
//line 20
___nl__10 = new ImmDouble(1).clone();
//line 20
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__10.getValue().ToString()))).clone();
//line 20
___nl__10 = null;
//line 20
___nl__6 = new ImmDouble((Double.Parse(___nl__6.getValue().ToString()))+(Double.Parse(___nl__7.getValue().ToString()))).clone();
//line 20
if (true) {goto label_9;}
//line 20
label_7:
//line 20
___nl__5 = null;
//line 20
___nl__6 = null;
//line 20
___nl__7 = null;
//line 20
___nl__8 = null;
//line 20
___nl__9 = null;
//line 21
___nl__5 = new ImmDouble(3).clone();
//line 21
nassert_NL.NL_a(___nl__4,___nl__5);

//line 21
___nl__5 = null;
//line 22
___nl__5 = new ImmDouble(0).clone();
//line 23
___nl__8 = c_rt_lib_NL.NL_init_iter(___nl__3).clone();

//line 23
label_12:
//line 23
___nl__6 = c_rt_lib_NL.NL_is_end_hash(___nl__8).clone();

//line 23
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_10;}}
//line 23
___nl__6 = c_rt_lib_NL.NL_get_key_iter(___nl__8).clone();

//line 23
___nl__7 = c_rt_lib_NL.NL_hash_get_value(___nl__3,___nl__6).clone();

//line 23
___nl__9 = new ImmString("").clone();
//line 23
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!___nl__6.toString().Equals(___nl__9.toString())).clone();
//line 23
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_14;}}
//line 23
___nl__10 = new ImmDouble(1).clone();
//line 23
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))-(Double.Parse(___nl__10.getValue().ToString()))).clone();
//line 23
___nl__10 = null;
//line 23
if (true) {goto label_13;}
//line 23
label_14:
//line 23
___nl__10 = new ImmDouble(1).clone();
//line 23
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__10.getValue().ToString()))).clone();
//line 23
___nl__10 = null;
//line 23
label_13:
//line 23
___nl__9 = null;
//line 23
___nl__8 = c_rt_lib_NL.NL_next_iter(___nl__8).clone();

//line 23
if (true) {goto label_12;}
//line 23
label_10:
//line 23
___nl__6 = null;
//line 23
___nl__7 = null;
//line 23
___nl__8 = null;
//line 24
___nl__6 = new ImmDouble(4).clone();
//line 24
nassert_NL.NL_a(___nl__5,___nl__6);

//line 24
___nl__6 = null;
//line 25
___nl__6 = new ImmDouble(0).clone();
//line 26
___nl__7 = new ImmDouble(10).clone();
//line 26
___nl__8 = new ImmDouble(0).clone();
//line 26
___nl__9 = new ImmDouble(1).clone();
//line 26
label_17:
//line 26
___nl__10 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) ).clone();
//line 26
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_15;}}
//line 26
___nl__11 = new ImmDouble(1).clone();
//line 26
___nl__6 = new ImmDouble((Double.Parse(___nl__6.getValue().ToString()))-(Double.Parse(___nl__11.getValue().ToString()))).clone();
//line 26
___nl__11 = null;
//line 26
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))+(Double.Parse(___nl__9.getValue().ToString()))).clone();
//line 26
if (true) {goto label_17;}
//line 26
label_15:
//line 26
___nl__7 = null;
//line 26
___nl__8 = null;
//line 26
___nl__9 = null;
//line 26
___nl__10 = null;
//line 27
___nl__7 = new ImmDouble(10).clone();
//line 27
___nl__7 = new ImmDouble(-((ImmDouble)___nl__7).getDoubleValue()).clone();
//line 27
nassert_NL.NL_a(___nl__6,___nl__7);

//line 27
___nl__7 = null;
//line 28
___nl__7 = new ImmDouble(1).clone();
//line 29
___nl__8 = new ImmDouble(0).clone();
//line 29
label_19:
//line 29
___nl__9 = new ImmDouble(10).clone();
//line 29
___nl__9 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString()))<(Double.Parse(___nl__9.getValue().ToString())) ).clone();
//line 29
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 29
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_18;}}
//line 30
___nl__10 = new ImmDouble(10).clone();
//line 30
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))+(Double.Parse(___nl__10.getValue().ToString()))).clone();
//line 30
___nl__10 = null;
//line 31
___nl__7 = ___nl__8.clone();
//line 31
___nl__10 = new ImmDouble(1).clone();
//line 31
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))+(Double.Parse(___nl__10.getValue().ToString()))).clone();
//line 31
___nl__10 = null;
//line 32
if (true) {goto label_19;}
//line 32
label_18:
//line 32
___nl__8 = null;
//line 32
___nl__9 = null;
//line 33
___nl__8 = new ImmDouble(10).clone();
//line 33
nassert_NL.NL_a(___nl__7,___nl__8);

//line 33
___nl__8 = null;
//line 33
___nl__2 = null;
//line 33
___nl__3 = null;
//line 33
___nl__4 = null;
//line 33
___nl__5 = null;
//line 33
___nl__6 = null;
//line 33
___nl__7 = null;
//line 33
___nl__1 = null;
//line 33
___arg__0.setValue(___nl__0);if(true) return null;
}

}
}