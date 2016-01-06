using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class profile_NL {

private static Imm NL_diff_time_priv(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();
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
//line 15
___nl__3 = new ImmDouble(0);
//line 15
___nl__2 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__3).getDoubleValue()];
//line 15
___nl__3 = null;
//line 15
___nl__4 = new ImmDouble(0);
//line 15
___nl__3 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()];
//line 15
___nl__4 = null;
//line 15
___nl__2 = new ImmDouble((Double.Parse(___nl__2.getValue().ToString()))-(Double.Parse(___nl__3.getValue().ToString())));
//line 15
___nl__3 = null;
//line 16
___nl__4 = new ImmDouble(1);
//line 16
___nl__3 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()];
//line 16
___nl__4 = null;
//line 16
___nl__5 = new ImmDouble(1);
//line 16
___nl__4 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()];
//line 16
___nl__5 = null;
//line 16
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))-(Double.Parse(___nl__4.getValue().ToString())));
//line 16
___nl__4 = null;
//line 17
___nl__4 = new ImmDouble(0);
//line 17
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))<(Double.Parse(___nl__4.getValue().ToString())) );
//line 17
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 17
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 18
___nl__5 = new ImmDouble(1);
//line 18
___nl__2 = new ImmDouble((Double.Parse(___nl__2.getValue().ToString()))-(Double.Parse(___nl__5.getValue().ToString())));
//line 18
___nl__5 = null;
//line 19
___nl__5 = new ImmDouble(1000000);
//line 19
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString())));
//line 19
___nl__5 = null;
//line 20
if (true) {goto label_2;}
//line 20
label_2:
//line 20
___nl__4 = null;
//line 21
___nl__4 = new ImmDouble(1000.0);
//line 21
___nl__4 = new ImmDouble((Double.Parse(___nl__2.getValue().ToString()))*(Double.Parse(___nl__4.getValue().ToString())));
//line 21
___nl__5 = new ImmDouble(1000.0);
//line 21
___nl__5 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))/(Double.Parse(___nl__5.getValue().ToString())));
//line 21
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString())));
//line 21
___nl__5 = null;
//line 21
___nl__0 = null;
//line 21
___nl__1 = null;
//line 21
___nl__2 = null;
//line 21
___nl__3 = null;
//line 21
if(true) return ___nl__4;
//line 21
___nl__4 = null;
//line 21
___nl__2 = null;
//line 21
___nl__3 = null;
//line 21
___nl__0 = null;
//line 21
___nl__1 = null;
//line 21
if(true) return null;
}

private static Imm NL_print_row_priv(ImmRef ___arg__0, Imm ___arg__1, Imm ___arg__2) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();
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
ImmRef ___ref______nl__12 = null;
ImmRef ___ref______nl__13 = null;
ImmRef ___ref______nl__14 = null;
ImmRef ___ref______nl__15 = null;
ImmRef ___ref______nl__16 = null;
Dictionary<String, Imm> __function_map;
//line 25
___nl__3 = new ImmString("");
//line 26
___nl__4 = ((ImmHash)___nl__0).getHashValue()["stack"];
//line 26
___nl__6 = new ImmDouble(0);
//line 26
___nl__7 = new ImmDouble(1);
//line 26
___nl__8 = c_rt_lib_NL.NL_array_len(___nl__4);

//line 26
label_3:
//line 26
___nl__9 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__6.getValue().ToString()))>=(Double.Parse(___nl__8.getValue().ToString())) );
//line 26
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_1;}}
//line 26
___nl__5 = (___nl__4 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()];
//line 27
___nl__10 = new ImmString("           ");
//line 27
___nl__11 = profile_NL.NL_diff_time_priv(___nl__1,___nl__5);

//line 27
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString());
//line 27
___nl__11 = null;
//line 28
___nl__12 = new ImmString(".");
//line 28
___nl__11 = string_NL.NL_index2(___nl__10,___nl__12);

//line 28
___nl__12 = null;
//line 29
___nl__12 = string_NL.NL_length(___nl__10);

//line 30
___nl__13 = new ImmDouble(1);
//line 30
___nl__13 = new ImmDouble(-((ImmDouble)___nl__13).getDoubleValue());
//line 30
___nl__13 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__11.getValue().ToString())) ==((Double.Parse(___nl__13.getValue().ToString())))  );
//line 30
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13));
//line 30
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_5;}}
//line 31
___nl__14 = new ImmString(".000");
//line 31
___nl__10 = new ImmString(___nl__10.toString() + ___nl__14.toString());
//line 31
___nl__14 = null;
//line 32
if (true) {goto label_4;}
//line 32
label_5:
//line 33
___nl__14 = new ImmString("000");
//line 33
___nl__10 = new ImmString(___nl__10.toString() + ___nl__14.toString());
//line 33
___nl__14 = null;
//line 34
___nl__15 = new ImmDouble(0);
//line 34
___nl__16 = new ImmDouble(4);
//line 34
___nl__16 = new ImmDouble((Double.Parse(___nl__11.getValue().ToString()))+(Double.Parse(___nl__16.getValue().ToString())));
//line 34
___nl__14 = string_NL.NL_substr(___nl__10,___nl__15,___nl__16);

//line 34
___nl__16 = null;
//line 34
___nl__15 = null;
//line 34
___nl__10 = ___nl__14;
//line 34
___nl__14 = null;
//line 35
___nl__12 = ___nl__11;
//line 36
if (true) {goto label_4;}
//line 36
label_4:
//line 36
___nl__13 = null;
//line 37
___nl__14 = new ImmDouble(7);
//line 37
___nl__14 = new ImmDouble((Double.Parse(___nl__12.getValue().ToString()))-(Double.Parse(___nl__14.getValue().ToString())));
//line 37
___nl__15 = new ImmDouble(4);
//line 37
___nl__13 = string_NL.NL_substr(___nl__10,___nl__14,___nl__15);

//line 37
___nl__15 = null;
//line 37
___nl__14 = null;
//line 37
___nl__14 = new ImmString(" ");
//line 37
___nl__13 = new ImmString(___nl__13.toString() + ___nl__14.toString());
//line 37
___nl__14 = null;
//line 37
___nl__15 = new ImmDouble(3);
//line 37
___nl__15 = new ImmDouble((Double.Parse(___nl__12.getValue().ToString()))-(Double.Parse(___nl__15.getValue().ToString())));
//line 37
___nl__16 = new ImmDouble(7);
//line 37
___nl__14 = string_NL.NL_substr(___nl__10,___nl__15,___nl__16);

//line 37
___nl__16 = null;
//line 37
___nl__15 = null;
//line 37
___nl__13 = new ImmString(___nl__13.toString() + ___nl__14.toString());
//line 37
___nl__14 = null;
//line 37
___nl__14 = string_NL.NL_tab();

//line 37
___nl__13 = new ImmString(___nl__13.toString() + ___nl__14.toString());
//line 37
___nl__14 = null;
//line 37
___nl__10 = ___nl__13;
//line 37
___nl__13 = null;
//line 38
___nl__3 = new ImmString(___nl__3.toString() + ___nl__10.toString());
//line 38
___nl__10 = null;
//line 38
___nl__11 = null;
//line 38
___nl__12 = null;
//line 39
___nl__6 = new ImmDouble((Double.Parse(___nl__6.getValue().ToString()))+(Double.Parse(___nl__7.getValue().ToString())));
//line 39
if (true) {goto label_3;}
//line 39
label_1:
//line 39
___nl__4 = null;
//line 39
___nl__5 = null;
//line 39
___nl__6 = null;
//line 39
___nl__7 = null;
//line 39
___nl__8 = null;
//line 39
___nl__9 = null;
//line 40
___nl__4 = string_NL.NL_tab();

//line 40
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 40
___nl__4 = null;
//line 41
___nl__3 = new ImmString(___nl__3.toString() + ___nl__2.toString());
//line 42
___nl__4 = string_NL.NL_lf();

//line 42
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 42
___nl__4 = null;
//line 43
___nl__4 = new ImmString("out");
//line 43
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__4);

//line 43
___nl__4 = new ImmString(___nl__4.toString() + ___nl__3.toString());
//line 43
___nl__5 = new ImmString("out");
//line 43
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 43
___nl__5 = null;
//line 43
___nl__4 = null;
//line 43
___nl__3 = null;
//line 43
___nl__1 = null;
//line 43
___nl__2 = null;
//line 43
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_get_profile_global_priv() {

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
//line 46
___nl__0 = c_std_lib_NL.NL_get_profile_global();

//line 47
___nl__1 = hash_NL.NL_size(___nl__0);

//line 47
___nl__2 = new ImmDouble(0);
//line 47
___nl__1 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__1.getValue().ToString())) ==((Double.Parse(___nl__2.getValue().ToString())))  );
//line 47
___nl__2 = null;
//line 47
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1));
//line 47
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_2;}}
//line 47
___nl__3 = new ImmString("");
//line 47
___nl__4 = new ImmArray(new Imm[0]);
//line 47
__function_map = new Dictionary<String, Imm>();
__function_map.Add("out",___nl__3);
__function_map.Add("stack",___nl__4);
___nl__2 = new ImmHash(__function_map);
//line 47
___nl__3 = null;
//line 47
___nl__4 = null;
//line 47
___nl__0 = ___nl__2;
//line 47
___nl__2 = null;
//line 47
if (true) {goto label_2;}
//line 47
label_2:
//line 47
___nl__1 = null;
//line 48
if(true) return ___nl__0;
//line 48
___nl__0 = null;
//line 48
if(true) return null;
}

public static Imm NL_sub(Imm ___arg__0, Imm ___arg__1, Imm ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 52
___ref______nl__2 = new ImmRef(___nl__2);
___nl__3 = profile_NL.NL_sub_ref(___nl__0,___nl__1,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue();

//line 52
___nl__0 = null;
//line 52
___nl__1 = null;
//line 52
___nl__2 = null;
//line 52
if(true) return ___nl__3;
//line 52
___nl__3 = null;
//line 52
___nl__0 = null;
//line 52
___nl__1 = null;
//line 52
___nl__2 = null;
//line 52
if(true) return null;
}

public static Imm NL_sub_ref(Imm ___arg__0, Imm ___arg__1, ImmRef ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.getValue().clone();
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
//line 55
___nl__3 = profile_NL.NL_get_profile_global_priv();

//line 56
___nl__4 = c_fe_lib_NL.NL_get_time();

//line 57
___nl__5 = ((ImmHash)___nl__3).getHashValue()["stack"];
//line 58
___nl__6 = new ImmString("stack");
//line 58
___nl__6 = c_rt_lib_NL.NL_get_ref_hash(___nl__3,___nl__6);

//line 58
___ref______nl__6 = new ImmRef(___nl__6);
array_NL.NL_push(___ref______nl__6,___nl__4);
___nl__6 = ___ref______nl__6.getValue();

//line 58
___nl__7 = new ImmString("stack");
//line 58
___ref______nl__3 = new ImmRef(___nl__3);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__3,___nl__7,___nl__6);
___nl__3 = ___ref______nl__3.getValue();

//line 58
___nl__7 = null;
//line 58
___nl__6 = null;
//line 59
___ref______nl__3 = new ImmRef(___nl__3);
profile_NL.NL_print_row_priv(___ref______nl__3,___nl__4,___nl__0);
___nl__3 = ___ref______nl__3.getValue();

//line 60
c_std_lib_NL.NL_set_profile_global(___nl__3);

//line 61
___ref______nl__2 = new ImmRef(___nl__2);
___nl__6 = func_NL.NL_exec_ref(___nl__1,___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue();

//line 62
___nl__7 = profile_NL.NL_get_profile_global_priv();

//line 62
___nl__3 = ___nl__7;
//line 62
___nl__7 = null;
//line 63
___nl__7 = c_fe_lib_NL.NL_get_time();

//line 63
___nl__4 = ___nl__7;
//line 63
___nl__7 = null;
//line 64
___nl__7 = new ImmString("TOTAL: ");
//line 64
___nl__7 = new ImmString(___nl__7.toString() + ___nl__0.toString());
//line 64
___ref______nl__3 = new ImmRef(___nl__3);
profile_NL.NL_print_row_priv(___ref______nl__3,___nl__4,___nl__7);
___nl__3 = ___ref______nl__3.getValue();

//line 64
___nl__7 = null;
//line 65
___nl__7 = ___nl__5;
//line 65
((ImmHash)___nl__3).set("stack", ___nl__7);
//line 65
___nl__7 = null;
//line 66
c_std_lib_NL.NL_set_profile_global(___nl__3);

//line 67
___nl__0 = null;
//line 67
___nl__1 = null;
//line 67
___nl__3 = null;
//line 67
___nl__4 = null;
//line 67
___nl__5 = null;
//line 67
___arg__2.setValue(___nl__2);if(true) return ___nl__6;
//line 67
___nl__3 = null;
//line 67
___nl__4 = null;
//line 67
___nl__5 = null;
//line 67
___nl__6 = null;
//line 67
___nl__0 = null;
//line 67
___nl__1 = null;
//line 67
___arg__2.setValue(___nl__2);if(true) return null;
}

public static Imm NL_save(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 71
___nl__1 = profile_NL.NL_get_profile_global_priv();

//line 72
___nl__3 = ((ImmHash)___nl__1).getHashValue()["stack"];
//line 72
___nl__2 = array_NL.NL_len(___nl__3);

//line 72
___nl__3 = null;
//line 72
___nl__3 = new ImmDouble(0);
//line 72
___nl__2 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__2.getValue().ToString())) !=((Double.Parse(___nl__3.getValue().ToString())))  );
//line 72
___nl__3 = null;
//line 72
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 72
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 72
___nl__3 = new ImmArray(new Imm[0]);
//line 72
c_rt_lib_NL.NL_die();
//line 72
if (true) {goto label_2;}
//line 72
label_2:
//line 72
___nl__2 = null;
//line 72
___nl__3 = null;
//line 73
___nl__2 = ((ImmHash)___nl__1).getHashValue()["out"];
//line 73
c_fe_lib_NL.NL_string_to_file(___nl__0,___nl__2);

//line 73
___nl__2 = null;
//line 74
___nl__2 = new ImmString("");
//line 74
___nl__3 = ___nl__2;
//line 74
((ImmHash)___nl__1).set("out", ___nl__3);
//line 74
___nl__2 = null;
//line 74
___nl__3 = null;
//line 75
c_std_lib_NL.NL_set_profile_global(___nl__1);

//line 75
___nl__1 = null;
//line 75
___nl__0 = null;
//line 75
if(true) return null;
}

}
}