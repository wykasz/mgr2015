using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class csv_NL {

public static Imm NL_save(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
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
Imm ___nl__18 = null;
Imm ___nl__19 = null;
Imm ___nl__20 = null;
Imm ___nl__21 = null;
Imm ___nl__22 = null;
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
ImmRef ___ref______nl__17 = null;
ImmRef ___ref______nl__18 = null;
ImmRef ___ref______nl__19 = null;
ImmRef ___ref______nl__20 = null;
ImmRef ___ref______nl__21 = null;
ImmRef ___ref______nl__22 = null;
Dictionary<String, Imm> __function_map;
//line 10
___nl__1 = new ImmString("\"");
//line 11
___nl__2 = string_NL.NL_tab();

//line 12
___nl__3 = new ImmString(___nl__1.toString() + ___nl__1.toString());
//line 13
___nl__4 = new ImmString("");
//line 14
___nl__6 = new ImmDouble(0);
//line 14
___nl__7 = new ImmDouble(1);
//line 14
___nl__8 = c_rt_lib_NL.NL_array_len(___nl__0);

//line 14
label_3:
//line 14
___nl__9 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__6.getValue().ToString()))>=(Double.Parse(___nl__8.getValue().ToString())) );
//line 14
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_1;}}
//line 14
___nl__5 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()];
//line 15
___nl__10 = array_NL.NL_len(___nl__5);

//line 16
___nl__11 = new ImmDouble(0);
//line 16
___nl__12 = new ImmDouble(1);
//line 16
label_6:
//line 16
___nl__13 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__11.getValue().ToString()))>=(Double.Parse(___nl__10.getValue().ToString())) );
//line 16
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_4;}}
//line 17
___nl__14 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__11).getDoubleValue()];
//line 18
___nl__15 = string_NL.NL_length(___nl__14);

//line 19
___nl__16 = c_rt_lib_NL.NL_get_false();
//line 20
___nl__17 = new ImmDouble(0);
//line 20
___nl__18 = new ImmDouble(1);
//line 20
label_9:
//line 20
___nl__19 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__17.getValue().ToString()))>=(Double.Parse(___nl__15.getValue().ToString())) );
//line 20
if (c_rt_lib_NL.NL_check_true_native(___nl__19)) {if (true) {goto label_7;}}
//line 21
___nl__21 = new ImmDouble(1);
//line 21
___nl__20 = string_NL.NL_substr(___nl__14,___nl__17,___nl__21);

//line 21
___nl__21 = null;
//line 22
___nl__21 = string_NL.NL_ord(___nl__20);

//line 22
___nl__22 = new ImmDouble(32);
//line 22
___nl__21 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__21.getValue().ToString()))<(Double.Parse(___nl__22.getValue().ToString())) );
//line 22
___nl__22 = null;
//line 22
if (c_rt_lib_NL.NL_check_true_native(___nl__21)) {if (true) {goto label_12;}}
//line 22
___nl__21 = c_rt_lib_NL.NL_native_to_nl(___nl__20.toString().Equals(___nl__1.toString()));
//line 22
label_12:
//line 22
___nl__21 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__21));
//line 22
if (c_rt_lib_NL.NL_check_true_native(___nl__21)) {if (true) {goto label_11;}}
//line 22
___nl__22 = c_rt_lib_NL.NL_get_true();
//line 22
___nl__16 = ___nl__22;
//line 22
___nl__22 = null;
//line 22
if (true) {goto label_11;}
//line 22
label_11:
//line 22
___nl__21 = null;
//line 22
___nl__20 = null;
//line 23
___nl__17 = new ImmDouble((Double.Parse(___nl__17.getValue().ToString()))+(Double.Parse(___nl__18.getValue().ToString())));
//line 23
if (true) {goto label_9;}
//line 23
label_7:
//line 23
___nl__17 = null;
//line 23
___nl__18 = null;
//line 23
___nl__19 = null;
//line 24
___nl__17 = ___nl__16;
//line 24
___nl__17 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__17));
//line 24
if (c_rt_lib_NL.NL_check_true_native(___nl__17)) {if (true) {goto label_14;}}
//line 24
___nl__18 = string_NL.NL_replace(___nl__14,___nl__1,___nl__3);

//line 24
___nl__18 = new ImmString(___nl__1.toString() + ___nl__18.toString());
//line 24
___nl__18 = new ImmString(___nl__18.toString() + ___nl__1.toString());
//line 24
___nl__14 = ___nl__18;
//line 24
___nl__18 = null;
//line 24
if (true) {goto label_14;}
//line 24
label_14:
//line 24
___nl__17 = null;
//line 25
___nl__4 = new ImmString(___nl__4.toString() + ___nl__14.toString());
//line 26
___nl__17 = new ImmDouble(1);
//line 26
___nl__17 = new ImmDouble((Double.Parse(___nl__10.getValue().ToString()))-(Double.Parse(___nl__17.getValue().ToString())));
//line 26
___nl__17 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__11.getValue().ToString())) ==((Double.Parse(___nl__17.getValue().ToString())))  );
//line 26
___nl__17 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__17));
//line 26
___nl__17 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__17));
//line 26
if (c_rt_lib_NL.NL_check_true_native(___nl__17)) {if (true) {goto label_16;}}
//line 26
___nl__4 = new ImmString(___nl__4.toString() + ___nl__2.toString());
//line 26
if (true) {goto label_16;}
//line 26
label_16:
//line 26
___nl__17 = null;
//line 26
___nl__14 = null;
//line 26
___nl__15 = null;
//line 26
___nl__16 = null;
//line 27
___nl__11 = new ImmDouble((Double.Parse(___nl__11.getValue().ToString()))+(Double.Parse(___nl__12.getValue().ToString())));
//line 27
if (true) {goto label_6;}
//line 27
label_4:
//line 27
___nl__11 = null;
//line 27
___nl__12 = null;
//line 27
___nl__13 = null;
//line 28
___nl__11 = string_NL.NL_lf();

//line 28
___nl__4 = new ImmString(___nl__4.toString() + ___nl__11.toString());
//line 28
___nl__11 = null;
//line 28
___nl__10 = null;
//line 29
___nl__6 = new ImmDouble((Double.Parse(___nl__6.getValue().ToString()))+(Double.Parse(___nl__7.getValue().ToString())));
//line 29
if (true) {goto label_3;}
//line 29
label_1:
//line 29
___nl__5 = null;
//line 29
___nl__6 = null;
//line 29
___nl__7 = null;
//line 29
___nl__8 = null;
//line 29
___nl__9 = null;
//line 30
___nl__0 = null;
//line 30
___nl__1 = null;
//line 30
___nl__2 = null;
//line 30
___nl__3 = null;
//line 30
if(true) return ___nl__4;
//line 30
___nl__1 = null;
//line 30
___nl__2 = null;
//line 30
___nl__3 = null;
//line 30
___nl__4 = null;
//line 30
___nl__0 = null;
//line 30
if(true) return null;
}

private static Imm NL_get_char_priv(Imm ___arg__0, ImmRef ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 34
___nl__3 = ___nl__1;
//line 34
___nl__4 = new ImmDouble(1);
//line 34
___nl__1 = new ImmDouble((Double.Parse(___nl__1.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString())));
//line 34
___nl__4 = null;
//line 34
___nl__4 = new ImmDouble(1);
//line 34
___nl__2 = string_NL.NL_substr(___nl__0,___nl__3,___nl__4);

//line 34
___nl__4 = null;
//line 34
___nl__3 = null;
//line 34
___nl__0 = null;
//line 34
___arg__1.setValue(___nl__1);if(true) return ___nl__2;
//line 34
___nl__2 = null;
//line 34
___nl__0 = null;
//line 34
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_end_priv(ImmRef ___arg__0, ImmRef ___arg__1, Imm ___arg__2) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.getValue().clone();Imm ___nl__2 = ___arg__2.clone();
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 37
___ref______nl__1 = new ImmRef(___nl__1);
array_NL.NL_push(___ref______nl__1,___nl__2);
___nl__1 = ___ref______nl__1.getValue();

//line 38
___ref______nl__0 = new ImmRef(___nl__0);
array_NL.NL_push(___ref______nl__0,___nl__1);
___nl__0 = ___ref______nl__0.getValue();

//line 39
___nl__3 = ___nl__0;
//line 39
___nl__2 = null;
//line 39
___arg__0.setValue(___nl__0);___arg__1.setValue(___nl__1);if(true) return ___nl__3;
//line 39
___nl__3 = null;
//line 39
___nl__2 = null;
//line 39
___arg__0.setValue(___nl__0);___arg__1.setValue(___nl__1);if(true) return null;
}

public static Imm NL_load(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
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
Dictionary<String, Imm> __function_map;
//line 42
___nl__1 = new ImmString("\"");
//line 43
___nl__2 = string_NL.NL_tab();

//line 44
___nl__3 = string_NL.NL_ord(___nl__2);

//line 45
___nl__4 = new ImmArray(new Imm[0]);
//line 46
___nl__5 = new ImmArray(new Imm[0]);
//line 47
___nl__6 = string_NL.NL_length(___nl__0);

//line 48
___nl__7 = new ImmDouble(0);
//line 48
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__6.getValue().ToString())) ==((Double.Parse(___nl__7.getValue().ToString())))  );
//line 48
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 48
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_2;}}
//line 48
___nl__0 = null;
//line 48
___nl__1 = null;
//line 48
___nl__2 = null;
//line 48
___nl__3 = null;
//line 48
___nl__5 = null;
//line 48
___nl__6 = null;
//line 48
___nl__7 = null;
//line 48
if(true) return ___nl__4;
//line 48
if (true) {goto label_2;}
//line 48
label_2:
//line 48
___nl__7 = null;
//line 49
___nl__9 = new ImmDouble(1);
//line 49
___nl__9 = new ImmDouble((Double.Parse(___nl__6.getValue().ToString()))-(Double.Parse(___nl__9.getValue().ToString())));
//line 49
___nl__10 = new ImmDouble(1);
//line 49
___nl__8 = string_NL.NL_substr(___nl__0,___nl__9,___nl__10);

//line 49
___nl__10 = null;
//line 49
___nl__9 = null;
//line 49
___nl__7 = string_NL.NL_ord(___nl__8);

//line 49
___nl__8 = null;
//line 49
___nl__8 = new ImmDouble(10);
//line 49
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString())) ==((Double.Parse(___nl__8.getValue().ToString())))  );
//line 49
___nl__8 = null;
//line 49
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 49
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_4;}}
//line 50
___nl__8 = new ImmDouble(1);
//line 50
___nl__6 = new ImmDouble((Double.Parse(___nl__6.getValue().ToString()))-(Double.Parse(___nl__8.getValue().ToString())));
//line 50
___nl__8 = null;
//line 51
___nl__10 = new ImmDouble(1);
//line 51
___nl__10 = new ImmDouble((Double.Parse(___nl__6.getValue().ToString()))-(Double.Parse(___nl__10.getValue().ToString())));
//line 51
___nl__11 = new ImmDouble(1);
//line 51
___nl__9 = string_NL.NL_substr(___nl__0,___nl__10,___nl__11);

//line 51
___nl__11 = null;
//line 51
___nl__10 = null;
//line 51
___nl__8 = string_NL.NL_ord(___nl__9);

//line 51
___nl__9 = null;
//line 51
___nl__9 = new ImmDouble(13);
//line 51
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString())) ==((Double.Parse(___nl__9.getValue().ToString())))  );
//line 51
___nl__9 = null;
//line 51
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8));
//line 51
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_6;}}
//line 51
___nl__9 = new ImmDouble(1);
//line 51
___nl__6 = new ImmDouble((Double.Parse(___nl__6.getValue().ToString()))-(Double.Parse(___nl__9.getValue().ToString())));
//line 51
___nl__9 = null;
//line 51
if (true) {goto label_6;}
//line 51
label_6:
//line 51
___nl__8 = null;
//line 52
if (true) {goto label_4;}
//line 52
label_4:
//line 52
___nl__7 = null;
//line 53
___nl__7 = new ImmString("");
//line 54
___nl__8 = new ImmDouble(0);
//line 55
label_8:
//line 55
___nl__9 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString()))<(Double.Parse(___nl__6.getValue().ToString())) );
//line 55
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9));
//line 55
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_7;}}
//line 56
___ref______nl__8 = new ImmRef(___nl__8);
___nl__10 = csv_NL.NL_get_char_priv(___nl__0,___ref______nl__8);
___nl__8 = ___ref______nl__8.getValue();

//line 57
___nl__11 = c_rt_lib_NL.NL_native_to_nl(___nl__10.toString().Equals(___nl__1.toString()));
//line 57
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11));
//line 57
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_10;}}
//line 58
label_12:
//line 59
___nl__12 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) );
//line 59
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12));
//line 59
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_14;}}
//line 59
___ref______nl__4 = new ImmRef(___nl__4);
___ref______nl__5 = new ImmRef(___nl__5);
___nl__13 = csv_NL.NL_end_priv(___ref______nl__4,___ref______nl__5,___nl__7);
___nl__4 = ___ref______nl__4.getValue();
___nl__5 = ___ref______nl__5.getValue();

//line 59
___nl__0 = null;
//line 59
___nl__1 = null;
//line 59
___nl__2 = null;
//line 59
___nl__3 = null;
//line 59
___nl__4 = null;
//line 59
___nl__5 = null;
//line 59
___nl__6 = null;
//line 59
___nl__7 = null;
//line 59
___nl__8 = null;
//line 59
___nl__9 = null;
//line 59
___nl__10 = null;
//line 59
___nl__11 = null;
//line 59
___nl__12 = null;
//line 59
if(true) return ___nl__13;
//line 59
___nl__13 = null;
//line 59
if (true) {goto label_14;}
//line 59
label_14:
//line 59
___nl__12 = null;
//line 60
___ref______nl__8 = new ImmRef(___nl__8);
___nl__12 = csv_NL.NL_get_char_priv(___nl__0,___ref______nl__8);
___nl__8 = ___ref______nl__8.getValue();

//line 60
___nl__10 = ___nl__12;
//line 60
___nl__12 = null;
//line 61
___nl__12 = c_rt_lib_NL.NL_native_to_nl(___nl__10.toString().Equals(___nl__1.toString()));
//line 61
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12));
//line 61
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_16;}}
//line 62
___nl__13 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) );
//line 62
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13));
//line 62
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_18;}}
//line 62
___ref______nl__4 = new ImmRef(___nl__4);
___ref______nl__5 = new ImmRef(___nl__5);
___nl__14 = csv_NL.NL_end_priv(___ref______nl__4,___ref______nl__5,___nl__7);
___nl__4 = ___ref______nl__4.getValue();
___nl__5 = ___ref______nl__5.getValue();

//line 62
___nl__0 = null;
//line 62
___nl__1 = null;
//line 62
___nl__2 = null;
//line 62
___nl__3 = null;
//line 62
___nl__4 = null;
//line 62
___nl__5 = null;
//line 62
___nl__6 = null;
//line 62
___nl__7 = null;
//line 62
___nl__8 = null;
//line 62
___nl__9 = null;
//line 62
___nl__10 = null;
//line 62
___nl__11 = null;
//line 62
___nl__12 = null;
//line 62
___nl__13 = null;
//line 62
if(true) return ___nl__14;
//line 62
___nl__14 = null;
//line 62
if (true) {goto label_18;}
//line 62
label_18:
//line 62
___nl__13 = null;
//line 63
___ref______nl__8 = new ImmRef(___nl__8);
___nl__13 = csv_NL.NL_get_char_priv(___nl__0,___ref______nl__8);
___nl__8 = ___ref______nl__8.getValue();

//line 63
___nl__10 = ___nl__13;
//line 63
___nl__13 = null;
//line 64
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!___nl__10.toString().Equals(___nl__1.toString()));
//line 64
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13));
//line 64
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_20;}}
//line 64
___nl__12 = null;
//line 64
___nl__13 = null;
//line 64
if (true) {goto label_11;}
//line 64
if (true) {goto label_20;}
//line 64
label_20:
//line 64
___nl__13 = null;
//line 65
if (true) {goto label_16;}
//line 65
label_16:
//line 65
___nl__12 = null;
//line 66
___nl__7 = new ImmString(___nl__7.toString() + ___nl__10.toString());
//line 58
if (true) {goto label_12;}
//line 58
label_11:
//line 68
if (true) {goto label_9;}
//line 68
label_10:
//line 69
___nl__12 = string_NL.NL_ord(___nl__10);

//line 70
label_22:
//line 70
___nl__13 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__12.getValue().ToString())) !=((Double.Parse(___nl__3.getValue().ToString())))  );
//line 70
___nl__15 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13));
//line 70
if (c_rt_lib_NL.NL_check_true_native(___nl__15)) {if (true) {goto label_24;}}
//line 70
___nl__13 = new ImmDouble(10);
//line 70
___nl__13 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__12.getValue().ToString())) !=((Double.Parse(___nl__13.getValue().ToString())))  );
//line 70
label_24:
//line 70
___nl__15 = null;
//line 70
___nl__14 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13));
//line 70
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_23;}}
//line 70
___nl__13 = new ImmDouble(13);
//line 70
___nl__13 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__12.getValue().ToString())) !=((Double.Parse(___nl__13.getValue().ToString())))  );
//line 70
label_23:
//line 70
___nl__14 = null;
//line 70
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13));
//line 70
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_21;}}
//line 72
___nl__7 = new ImmString(___nl__7.toString() + ___nl__10.toString());
//line 73
___nl__14 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) );
//line 73
___nl__14 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__14));
//line 73
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_26;}}
//line 73
___ref______nl__4 = new ImmRef(___nl__4);
___ref______nl__5 = new ImmRef(___nl__5);
___nl__15 = csv_NL.NL_end_priv(___ref______nl__4,___ref______nl__5,___nl__7);
___nl__4 = ___ref______nl__4.getValue();
___nl__5 = ___ref______nl__5.getValue();

//line 73
___nl__0 = null;
//line 73
___nl__1 = null;
//line 73
___nl__2 = null;
//line 73
___nl__3 = null;
//line 73
___nl__4 = null;
//line 73
___nl__5 = null;
//line 73
___nl__6 = null;
//line 73
___nl__7 = null;
//line 73
___nl__8 = null;
//line 73
___nl__9 = null;
//line 73
___nl__10 = null;
//line 73
___nl__11 = null;
//line 73
___nl__12 = null;
//line 73
___nl__13 = null;
//line 73
___nl__14 = null;
//line 73
if(true) return ___nl__15;
//line 73
___nl__15 = null;
//line 73
if (true) {goto label_26;}
//line 73
label_26:
//line 73
___nl__14 = null;
//line 74
___ref______nl__8 = new ImmRef(___nl__8);
___nl__14 = csv_NL.NL_get_char_priv(___nl__0,___ref______nl__8);
___nl__8 = ___ref______nl__8.getValue();

//line 74
___nl__10 = ___nl__14;
//line 74
___nl__14 = null;
//line 75
___nl__14 = string_NL.NL_ord(___nl__10);

//line 75
___nl__12 = ___nl__14;
//line 75
___nl__14 = null;
//line 76
if (true) {goto label_22;}
//line 76
label_21:
//line 76
___nl__13 = null;
//line 76
___nl__12 = null;
//line 77
if (true) {goto label_9;}
//line 77
label_9:
//line 77
___nl__11 = null;
//line 78
___ref______nl__5 = new ImmRef(___nl__5);
array_NL.NL_push(___ref______nl__5,___nl__7);
___nl__5 = ___ref______nl__5.getValue();

//line 79
___nl__11 = new ImmString("");
//line 79
___nl__7 = ___nl__11;
//line 79
___nl__11 = null;
//line 80
___nl__11 = string_NL.NL_ord(___nl__10);

//line 81
___nl__12 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__11.getValue().ToString())) ==((Double.Parse(___nl__3.getValue().ToString())))  );
//line 81
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12));
//line 81
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_28;}}
//line 81
___nl__10 = null;
//line 81
___nl__11 = null;
//line 81
___nl__12 = null;
//line 81
if (true) {goto label_8;}
//line 81
if (true) {goto label_28;}
//line 81
label_28:
//line 81
___nl__12 = null;
//line 82
___nl__12 = new ImmDouble(13);
//line 82
___nl__12 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__11.getValue().ToString())) ==((Double.Parse(___nl__12.getValue().ToString())))  );
//line 82
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12));
//line 82
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_30;}}
//line 83
___ref______nl__8 = new ImmRef(___nl__8);
___nl__13 = csv_NL.NL_get_char_priv(___nl__0,___ref______nl__8);
___nl__8 = ___ref______nl__8.getValue();

//line 83
___nl__10 = ___nl__13;
//line 83
___nl__13 = null;
//line 84
___nl__13 = string_NL.NL_ord(___nl__10);

//line 84
___nl__11 = ___nl__13;
//line 84
___nl__13 = null;
//line 85
if (true) {goto label_30;}
//line 85
label_30:
//line 85
___nl__12 = null;
//line 86
___nl__12 = new ImmDouble(10);
//line 86
___nl__12 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__11.getValue().ToString())) ==((Double.Parse(___nl__12.getValue().ToString())))  );
//line 86
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12));
//line 86
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_32;}}
//line 87
___ref______nl__4 = new ImmRef(___nl__4);
array_NL.NL_push(___ref______nl__4,___nl__5);
___nl__4 = ___ref______nl__4.getValue();

//line 88
___nl__13 = new ImmArray(new Imm[0]);
//line 88
___nl__5 = ___nl__13;
//line 88
___nl__13 = null;
//line 89
___nl__10 = null;
//line 89
___nl__11 = null;
//line 89
___nl__12 = null;
//line 89
if (true) {goto label_8;}
//line 90
if (true) {goto label_32;}
//line 90
label_32:
//line 90
___nl__12 = null;
//line 90
___nl__10 = null;
//line 90
___nl__11 = null;
//line 92
if (true) {goto label_8;}
//line 92
label_7:
//line 92
___nl__9 = null;
//line 93
___ref______nl__4 = new ImmRef(___nl__4);
___ref______nl__5 = new ImmRef(___nl__5);
___nl__9 = csv_NL.NL_end_priv(___ref______nl__4,___ref______nl__5,___nl__7);
___nl__4 = ___ref______nl__4.getValue();
___nl__5 = ___ref______nl__5.getValue();

//line 93
___nl__0 = null;
//line 93
___nl__1 = null;
//line 93
___nl__2 = null;
//line 93
___nl__3 = null;
//line 93
___nl__4 = null;
//line 93
___nl__5 = null;
//line 93
___nl__6 = null;
//line 93
___nl__7 = null;
//line 93
___nl__8 = null;
//line 93
if(true) return ___nl__9;
//line 93
___nl__9 = null;
//line 93
___nl__1 = null;
//line 93
___nl__2 = null;
//line 93
___nl__3 = null;
//line 93
___nl__4 = null;
//line 93
___nl__5 = null;
//line 93
___nl__6 = null;
//line 93
___nl__7 = null;
//line 93
___nl__8 = null;
//line 93
___nl__0 = null;
//line 93
if(true) return null;
}

}
}