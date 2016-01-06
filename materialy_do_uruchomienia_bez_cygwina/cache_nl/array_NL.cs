using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class array_NL {

public static Imm NL_subarray(Imm ___arg__0, Imm ___arg__1, Imm ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 8
___nl__3 = c_std_lib_NL.NL_array_sub(___nl__0,___nl__1,___nl__2).clone();

//line 8
___nl__0 = null;
//line 8
___nl__1 = null;
//line 8
___nl__2 = null;
//line 8
if(true) return ___nl__3;
//line 8
___nl__3 = null;
//line 8
___nl__0 = null;
//line 8
___nl__1 = null;
//line 8
___nl__2 = null;
//line 8
if(true) return null;
}

public static Imm NL_join(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
Imm ___nl__9 = null;
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
Dictionary<String, Imm> __function_map;
//line 12
___nl__2 = new ImmString("").clone();
//line 13
___nl__3 = c_rt_lib_NL.NL_get_true().clone();
//line 14
___nl__5 = new ImmDouble(0).clone();
//line 14
___nl__6 = new ImmDouble(1).clone();
//line 14
___nl__7 = c_rt_lib_NL.NL_array_len(___nl__1).clone();

//line 14
label_3:
//line 14
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) ).clone();
//line 14
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_1;}}
//line 14
___nl__4 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()].clone();
//line 15
___nl__9 = ___nl__3.clone();
//line 15
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 15
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9)).clone();
//line 15
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_5;}}
//line 15
___nl__2 = new ImmString(___nl__2.toString() + ___nl__0.toString()).clone();
//line 15
if (true) {goto label_5;}
//line 15
label_5:
//line 15
___nl__9 = null;
//line 16
___nl__2 = new ImmString(___nl__2.toString() + ___nl__4.toString()).clone();
//line 17
___nl__9 = c_rt_lib_NL.NL_get_false().clone();
//line 17
___nl__3 = ___nl__9.clone();
//line 17
___nl__9 = null;
//line 18
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString()))).clone();
//line 18
if (true) {goto label_3;}
//line 18
label_1:
//line 18
___nl__4 = null;
//line 18
___nl__5 = null;
//line 18
___nl__6 = null;
//line 18
___nl__7 = null;
//line 18
___nl__8 = null;
//line 19
___nl__0 = null;
//line 19
___nl__1 = null;
//line 19
___nl__3 = null;
//line 19
if(true) return ___nl__2;
//line 19
___nl__2 = null;
//line 19
___nl__3 = null;
//line 19
___nl__0 = null;
//line 19
___nl__1 = null;
//line 19
if(true) return null;
}

public static Imm NL_push(ImmRef ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.clone();
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 23
___ref______nl__0 = new ImmRef(___nl__0);
c_std_lib_NL.NL_array_push(___ref______nl__0,___nl__1);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 23
___nl__1 = null;
//line 23
___arg__0.setValue(___nl__0);if(true) return null;
}

public static Imm NL_pop(ImmRef ___arg__0) {
Imm ___nl__0 = ___arg__0.getValue().clone();
ImmRef ___ref______nl__0 = null;
Dictionary<String, Imm> __function_map;
//line 26
___ref______nl__0 = new ImmRef(___nl__0);
c_std_lib_NL.NL_array_pop(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 26
___arg__0.setValue(___nl__0);if(true) return null;
}

public static Imm NL_append(ImmRef ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.clone();
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
//line 30
___nl__3 = new ImmDouble(0).clone();
//line 30
___nl__4 = new ImmDouble(1).clone();
//line 30
___nl__5 = c_rt_lib_NL.NL_array_len(___nl__1).clone();

//line 30
label_3:
//line 30
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))>=(Double.Parse(___nl__5.getValue().ToString())) ).clone();
//line 30
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_1;}}
//line 30
___nl__2 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__3).getDoubleValue()].clone();
//line 31
___ref______nl__0 = new ImmRef(___nl__0);
array_NL.NL_push(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 32
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString()))).clone();
//line 32
if (true) {goto label_3;}
//line 32
label_1:
//line 32
___nl__2 = null;
//line 32
___nl__3 = null;
//line 32
___nl__4 = null;
//line 32
___nl__5 = null;
//line 32
___nl__6 = null;
//line 32
___nl__1 = null;
//line 32
___arg__0.setValue(___nl__0);if(true) return null;
}

public static Imm NL_len(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 36
___nl__1 = c_std_lib_NL.NL_array_len(___nl__0).clone();

//line 36
___nl__0 = null;
//line 36
if(true) return ___nl__1;
//line 36
___nl__1 = null;
//line 36
___nl__0 = null;
//line 36
if(true) return null;
}

public static Imm NL_cmp(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 40
___nl__2 = c_std_lib_NL.NL_string_compare(___nl__0,___nl__1).clone();

//line 40
___nl__3 = new ImmDouble(0).clone();
//line 40
___nl__2 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__2.getValue().ToString()))<(Double.Parse(___nl__3.getValue().ToString())) ).clone();
//line 40
___nl__3 = null;
//line 40
___nl__0 = null;
//line 40
___nl__1 = null;
//line 40
if(true) return ___nl__2;
//line 40
___nl__2 = null;
//line 40
___nl__0 = null;
//line 40
___nl__1 = null;
//line 40
if(true) return null;
}

public static Imm NL_sort(ImmRef ___arg__0) {
Imm ___nl__0 = ___arg__0.getValue().clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 44
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("array_NL"));
__function_map.Add("name",new ImmString("cmp"));
___nl__2 = new ImmHash(__function_map).clone();
//line 44
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__2).clone();
//line 44
___nl__1 = c_std_lib_NL.NL_array_sort(___nl__0,___nl__2).clone();

//line 44
___nl__2 = null;
//line 44
___nl__0 = ___nl__1.clone();
//line 44
___nl__1 = null;
//line 44
___arg__0.setValue(___nl__0);if(true) return null;
}

}
}