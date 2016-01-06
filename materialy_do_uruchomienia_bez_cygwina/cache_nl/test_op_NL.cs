using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class test_op_NL {

public static Imm NL_SINGLETON_test() {

Dictionary<String, Imm> __function_map;
//line 8
test_op_NL.NL_test_one();

//line 9
test_op_NL.NL_test_post_operators();

//line 9
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_test = null;
public static Imm NL_test() {
	if (value__singleton__NL_SINGLETON_test == null) {
		value__singleton__NL_SINGLETON_test = NL_SINGLETON_test();
	}
	return value__singleton__NL_SINGLETON_test;
}
public static Imm NL_SINGLETON_test_one() {

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
//line 13
___nl__0 = new ImmDouble(0);
//line 14
___nl__1 = new ImmDouble(1);
//line 14
___nl__0 = new ImmDouble((Double.Parse(___nl__0.getValue().ToString()))+(Double.Parse(___nl__1.getValue().ToString())));
//line 14
___nl__1 = null;
//line 15
___nl__1 = new ImmDouble(1);
//line 15
nassert_NL.NL_a(___nl__0,___nl__1);

//line 15
___nl__1 = null;
//line 16
___nl__3 = new ImmDouble(55);
//line 16
__function_map = new Dictionary<String, Imm>();
__function_map.Add("b",___nl__3);
___nl__2 = new ImmHash(__function_map);
//line 16
___nl__3 = null;
//line 16
___nl__1 = new ImmArray(new Imm[] {___nl__2,});
//line 16
___nl__2 = null;
//line 17
___nl__3 = new ImmDouble(0);
//line 17
___nl__2 = c_rt_lib_NL.NL_get_ref_arr(___nl__1,___nl__3);

//line 17
___nl__4 = new ImmString("b");
//line 17
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__2,___nl__4);

//line 17
___nl__5 = new ImmDouble(1);
//line 17
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))-(Double.Parse(___nl__5.getValue().ToString())));
//line 17
___nl__6 = new ImmString("b");
//line 17
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__2,___nl__6,___nl__4);
___nl__2 = ___ref______nl__2.getValue();

//line 17
___ref______nl__1 = new ImmRef(___nl__1);
c_rt_lib_NL.NL_set_ref_arr(___ref______nl__1,___nl__3,___nl__2);
___nl__1 = ___ref______nl__1.getValue();

//line 17
___nl__6 = null;
//line 17
___nl__2 = null;
//line 17
___nl__3 = null;
//line 17
___nl__4 = null;
//line 17
___nl__5 = null;
//line 18
___nl__3 = new ImmDouble(0);
//line 18
___nl__2 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__3).getDoubleValue()];
//line 18
___nl__3 = null;
//line 18
___nl__2 = ((ImmHash)___nl__2).getHashValue()["b"];
//line 18
___nl__3 = new ImmDouble(54);
//line 18
nassert_NL.NL_a(___nl__2,___nl__3);

//line 18
___nl__3 = null;
//line 18
___nl__2 = null;
//line 19
___nl__3 = new ImmDouble(3);
//line 19
__function_map = new Dictionary<String, Imm>();
__function_map.Add("d",___nl__3);
___nl__2 = new ImmHash(__function_map);
//line 19
___nl__3 = null;
//line 20
___nl__3 = new ImmString("d");
//line 20
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__2,___nl__3);

//line 20
___nl__4 = new ImmDouble(1);
//line 20
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString())));
//line 20
___nl__5 = new ImmString("d");
//line 20
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__2,___nl__5,___nl__3);
___nl__2 = ___ref______nl__2.getValue();

//line 20
___nl__5 = null;
//line 20
___nl__3 = null;
//line 20
___nl__4 = null;
//line 21
___nl__3 = ((ImmHash)___nl__2).getHashValue()["d"];
//line 21
___nl__4 = new ImmDouble(4);
//line 21
nassert_NL.NL_a(___nl__3,___nl__4);

//line 21
___nl__4 = null;
//line 21
___nl__3 = null;
//line 22
___nl__3 = new ImmDouble(4);
//line 22
___nl__4 = new ImmString("d");
//line 22
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__2,___nl__4);

//line 22
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__3.getValue().ToString())));
//line 22
___nl__5 = new ImmString("d");
//line 22
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__2,___nl__5,___nl__4);
___nl__2 = ___ref______nl__2.getValue();

//line 22
___nl__5 = null;
//line 22
___nl__3 = null;
//line 22
___nl__4 = null;
//line 23
___nl__4 = new ImmDouble(8);
//line 23
__function_map = new Dictionary<String, Imm>();
__function_map.Add("d",___nl__4);
___nl__3 = new ImmHash(__function_map);
//line 23
___nl__4 = null;
//line 23
nassert_NL.NL_a(___nl__2,___nl__3);

//line 23
___nl__3 = null;
//line 24
___nl__3 = new ImmDouble(7);
//line 24
___nl__4 = new ImmString("d");
//line 24
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__2,___nl__4);

//line 24
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))-(Double.Parse(___nl__3.getValue().ToString())));
//line 24
___nl__5 = new ImmString("d");
//line 24
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__2,___nl__5,___nl__4);
___nl__2 = ___ref______nl__2.getValue();

//line 24
___nl__5 = null;
//line 24
___nl__3 = null;
//line 24
___nl__4 = null;
//line 25
___nl__4 = new ImmDouble(1);
//line 25
__function_map = new Dictionary<String, Imm>();
__function_map.Add("d",___nl__4);
___nl__3 = new ImmHash(__function_map);
//line 25
___nl__4 = null;
//line 25
nassert_NL.NL_a(___nl__2,___nl__3);

//line 25
___nl__3 = null;
//line 26
___nl__3 = new ImmDouble(14);
//line 26
___nl__4 = new ImmString("d");
//line 26
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__2,___nl__4);

//line 26
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__3.getValue().ToString())));
//line 26
___nl__5 = new ImmString("d");
//line 26
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__2,___nl__5,___nl__4);
___nl__2 = ___ref______nl__2.getValue();

//line 26
___nl__5 = null;
//line 26
___nl__3 = null;
//line 26
___nl__4 = null;
//line 27
___nl__3 = new ImmDouble(3);
//line 27
___nl__4 = new ImmString("d");
//line 27
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__2,___nl__4);

//line 27
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))/(Double.Parse(___nl__3.getValue().ToString())));
//line 27
___nl__5 = new ImmString("d");
//line 27
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__2,___nl__5,___nl__4);
___nl__2 = ___ref______nl__2.getValue();

//line 27
___nl__5 = null;
//line 27
___nl__3 = null;
//line 27
___nl__4 = null;
//line 28
___nl__4 = new ImmDouble(5);
//line 28
__function_map = new Dictionary<String, Imm>();
__function_map.Add("d",___nl__4);
___nl__3 = new ImmHash(__function_map);
//line 28
___nl__4 = null;
//line 28
nassert_NL.NL_a(___nl__2,___nl__3);

//line 28
___nl__3 = null;
//line 29
___nl__4 = new ImmString("cos ciekawego");
//line 29
___nl__3 = new ImmArray(new Imm[] {___nl__4,});
//line 29
___nl__4 = null;
//line 30
___nl__5 = new ImmDouble(0);
//line 30
___nl__4 = (___nl__3 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()];
//line 30
___nl__5 = null;
//line 31
___nl__5 = new ImmString("...");
//line 31
___nl__7 = new ImmDouble(0);
//line 31
___nl__6 = c_rt_lib_NL.NL_get_ref_arr(___nl__3,___nl__7);

//line 31
___nl__6 = new ImmString(___nl__6.toString() + ___nl__5.toString());
//line 31
___ref______nl__3 = new ImmRef(___nl__3);
c_rt_lib_NL.NL_set_ref_arr(___ref______nl__3,___nl__7,___nl__6);
___nl__3 = ___ref______nl__3.getValue();

//line 31
___nl__5 = null;
//line 31
___nl__6 = null;
//line 31
___nl__7 = null;
//line 32
___nl__6 = new ImmString("cos ciekawego...");
//line 32
___nl__5 = new ImmArray(new Imm[] {___nl__6,});
//line 32
___nl__6 = null;
//line 32
nassert_NL.NL_a(___nl__3,___nl__5);

//line 32
___nl__5 = null;
//line 33
___nl__5 = new ImmString("cos ciekawego");
//line 33
nassert_NL.NL_a(___nl__4,___nl__5);

//line 33
___nl__5 = null;
//line 34
___nl__5 = new ImmString("OK");
//line 34
___nl__0 = null;
//line 34
___nl__1 = null;
//line 34
___nl__2 = null;
//line 34
___nl__3 = null;
//line 34
___nl__4 = null;
//line 34
if(true) return ___nl__5;
//line 34
___nl__5 = null;
//line 34
___nl__0 = null;
//line 34
___nl__1 = null;
//line 34
___nl__2 = null;
//line 34
___nl__3 = null;
//line 34
___nl__4 = null;
//line 34
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_test_one = null;
public static Imm NL_test_one() {
	if (value__singleton__NL_SINGLETON_test_one == null) {
		value__singleton__NL_SINGLETON_test_one = NL_SINGLETON_test_one();
	}
	return value__singleton__NL_SINGLETON_test_one;
}
public static Imm NL_SINGLETON_test_post_operators() {

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
//line 38
___nl__0 = new ImmDouble(10);
//line 39
___nl__1 = ___nl__0;
//line 39
___nl__2 = new ImmDouble(1);
//line 39
___nl__0 = new ImmDouble((Double.Parse(___nl__0.getValue().ToString()))+(Double.Parse(___nl__2.getValue().ToString())));
//line 39
___nl__2 = null;
//line 40
___nl__2 = new ImmDouble(11);
//line 40
nassert_NL.NL_a(___nl__0,___nl__2);

//line 40
___nl__2 = null;
//line 41
___nl__2 = new ImmDouble(10);
//line 41
nassert_NL.NL_a(___nl__1,___nl__2);

//line 41
___nl__2 = null;
//line 42
___nl__5 = new ImmDouble(10);
//line 42
__function_map = new Dictionary<String, Imm>();
__function_map.Add("c",___nl__5);
___nl__4 = new ImmHash(__function_map);
//line 42
___nl__5 = null;
//line 42
__function_map = new Dictionary<String, Imm>();
__function_map.Add("b",___nl__4);
___nl__3 = new ImmHash(__function_map);
//line 42
___nl__4 = null;
//line 42
___nl__2 = new ImmArray(new Imm[] {___nl__3,});
//line 42
___nl__3 = null;
//line 43
___nl__3 = ___nl__2;
//line 44
___nl__6 = new ImmDouble(0);
//line 44
___nl__5 = c_rt_lib_NL.NL_get_ref_arr(___nl__2,___nl__6);

//line 44
___nl__7 = new ImmString("b");
//line 44
___nl__7 = c_rt_lib_NL.NL_get_ref_hash(___nl__5,___nl__7);

//line 44
___nl__8 = new ImmString("c");
//line 44
___nl__8 = c_rt_lib_NL.NL_get_ref_hash(___nl__7,___nl__8);

//line 44
___nl__4 = ___nl__8;
//line 44
___nl__9 = new ImmDouble(1);
//line 44
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))+(Double.Parse(___nl__9.getValue().ToString())));
//line 44
___nl__10 = new ImmString("c");
//line 44
___ref______nl__7 = new ImmRef(___nl__7);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__7,___nl__10,___nl__8);
___nl__7 = ___ref______nl__7.getValue();

//line 44
___nl__10 = new ImmString("b");
//line 44
___ref______nl__5 = new ImmRef(___nl__5);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__5,___nl__10,___nl__7);
___nl__5 = ___ref______nl__5.getValue();

//line 44
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_arr(___ref______nl__2,___nl__6,___nl__5);
___nl__2 = ___ref______nl__2.getValue();

//line 44
___nl__10 = null;
//line 44
___nl__5 = null;
//line 44
___nl__6 = null;
//line 44
___nl__7 = null;
//line 44
___nl__8 = null;
//line 44
___nl__9 = null;
//line 45
___nl__6 = new ImmDouble(0);
//line 45
___nl__5 = c_rt_lib_NL.NL_get_ref_arr(___nl__3,___nl__6);

//line 45
___nl__7 = new ImmString("b");
//line 45
___nl__7 = c_rt_lib_NL.NL_get_ref_hash(___nl__5,___nl__7);

//line 45
___nl__8 = new ImmString("c");
//line 45
___nl__8 = c_rt_lib_NL.NL_get_ref_hash(___nl__7,___nl__8);

//line 45
___nl__9 = new ImmDouble(1);
//line 45
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))+(Double.Parse(___nl__9.getValue().ToString())));
//line 45
___nl__10 = new ImmString("c");
//line 45
___ref______nl__7 = new ImmRef(___nl__7);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__7,___nl__10,___nl__8);
___nl__7 = ___ref______nl__7.getValue();

//line 45
___nl__10 = new ImmString("b");
//line 45
___ref______nl__5 = new ImmRef(___nl__5);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__5,___nl__10,___nl__7);
___nl__5 = ___ref______nl__5.getValue();

//line 45
___ref______nl__3 = new ImmRef(___nl__3);
c_rt_lib_NL.NL_set_ref_arr(___ref______nl__3,___nl__6,___nl__5);
___nl__3 = ___ref______nl__3.getValue();

//line 45
___nl__10 = null;
//line 45
___nl__5 = null;
//line 45
___nl__6 = null;
//line 45
___nl__7 = null;
//line 45
___nl__8 = null;
//line 45
___nl__9 = null;
//line 46
___nl__6 = new ImmDouble(0);
//line 46
___nl__5 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()];
//line 46
___nl__6 = null;
//line 46
___nl__5 = ((ImmHash)___nl__5).getHashValue()["b"];
//line 46
___nl__5 = ((ImmHash)___nl__5).getHashValue()["c"];
//line 46
___nl__6 = new ImmDouble(11);
//line 46
nassert_NL.NL_a(___nl__5,___nl__6);

//line 46
___nl__6 = null;
//line 46
___nl__5 = null;
//line 47
nassert_NL.NL_a(___nl__3,___nl__2);

//line 48
___nl__5 = new ImmDouble(10);
//line 48
nassert_NL.NL_a(___nl__4,___nl__5);

//line 48
___nl__5 = null;
//line 48
___nl__0 = null;
//line 48
___nl__1 = null;
//line 48
___nl__2 = null;
//line 48
___nl__3 = null;
//line 48
___nl__4 = null;
//line 48
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_test_post_operators = null;
public static Imm NL_test_post_operators() {
	if (value__singleton__NL_SINGLETON_test_post_operators == null) {
		value__singleton__NL_SINGLETON_test_post_operators = NL_SINGLETON_test_post_operators();
	}
	return value__singleton__NL_SINGLETON_test_post_operators;
}
}
}