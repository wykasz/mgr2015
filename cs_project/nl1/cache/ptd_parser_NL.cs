using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class ptd_parser_NL {

public static Imm NL_fun_def_to_ptd(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
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
___nl__1 = ((ImmHash)___nl__0).getHashValue()["cmd"];
//line 16
___nl__2 = ___nl__1;
//line 16
___nl__2 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("block"));
//line 16
___nl__1 = ___nl__2;
//line 16
___nl__2 = null;
//line 17
___nl__2 = array_NL.NL_len(___nl__1);

//line 17
___nl__4 = new ImmDouble(1);
//line 17
___nl__2 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__2.getValue().ToString())) ==((Double.Parse(___nl__4.getValue().ToString())))  );
//line 17
___nl__4 = null;
//line 17
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 17
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 17
___nl__5 = new ImmDouble(0);
//line 17
___nl__4 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()];
//line 17
___nl__5 = null;
//line 17
___nl__4 = ((ImmHash)___nl__4).getHashValue()["cmd"];
//line 17
___nl__5 = new ImmString("return");
//line 17
___nl__2 = ov_NL.NL_is(___nl__4,___nl__5);

//line 17
___nl__5 = null;
//line 17
___nl__4 = null;
//line 17
label_3:
//line 17
___nl__3 = null;
//line 17
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 17
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 17
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 17
___nl__3 = new ImmString("type function should have only a return command");
//line 17
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("err"), ___nl__3);
//line 17
___nl__0 = null;
//line 17
___nl__1 = null;
//line 17
___nl__2 = null;
//line 17
if(true) return ___nl__3;
//line 17
___nl__3 = null;
//line 17
if (true) {goto label_2;}
//line 17
label_2:
//line 17
___nl__2 = null;
//line 18
___nl__4 = new ImmDouble(0);
//line 18
___nl__3 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()];
//line 18
___nl__4 = null;
//line 18
___nl__3 = ((ImmHash)___nl__3).getHashValue()["cmd"];
//line 18
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("return"));
//line 18
___nl__2 = ptd_parser_NL.NL_try_value_to_ptd(___nl__3);

//line 18
___nl__3 = null;
//line 18
___nl__0 = null;
//line 18
___nl__1 = null;
//line 18
if(true) return ___nl__2;
//line 18
___nl__2 = null;
//line 18
___nl__1 = null;
//line 18
___nl__0 = null;
//line 18
if(true) return null;
}

public static Imm NL_try_value_to_ptd(Imm ___arg__0) {
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
Dictionary<String, Imm> __function_map;
//line 22
___nl__2 = new ImmString("unary_op");
//line 22
___nl__1 = ov_NL.NL_is(___nl__0,___nl__2);

//line 22
___nl__2 = null;
//line 22
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1));
//line 22
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_2;}}
//line 23
___nl__3 = new ImmString("unary_op");
//line 23
___nl__2 = ov_NL.NL_as(___nl__0,___nl__3);

//line 23
___nl__3 = null;
//line 24
___nl__3 = ((ImmHash)___nl__2).getHashValue()["op"];
//line 24
___nl__4 = new ImmString("@");
//line 24
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__4.toString()));
//line 24
___nl__4 = null;
//line 24
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 24
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 24
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_4;}}
//line 24
___nl__4 = new ImmString("ptd function argument can be other ptd function or reference type start witch @: ");
//line 24
___nl__5 = ((ImmHash)___nl__2).getHashValue()["op"];
//line 24
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 24
___nl__5 = null;
//line 24
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("err"), ___nl__4);
//line 24
___nl__0 = null;
//line 24
___nl__1 = null;
//line 24
___nl__2 = null;
//line 24
___nl__3 = null;
//line 24
if(true) return ___nl__4;
//line 24
___nl__4 = null;
//line 24
if (true) {goto label_4;}
//line 24
label_4:
//line 24
___nl__3 = null;
//line 27
___nl__4 = ((ImmHash)___nl__2).getHashValue()["val"];
//line 27
___nl__5 = new ImmString("fun_label");
//line 27
___nl__3 = ov_NL.NL_as(___nl__4,___nl__5);

//line 27
___nl__5 = null;
//line 27
___nl__4 = null;
//line 28
___nl__5 = ((ImmHash)___nl__3).getHashValue()["module"];
//line 28
___nl__6 = new ImmString("::");
//line 28
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 28
___nl__6 = null;
//line 28
___nl__6 = ((ImmHash)___nl__3).getHashValue()["name"];
//line 28
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 28
___nl__6 = null;
//line 28
___nl__4 = tct_NL.NL_tct_ref(___nl__5);

//line 28
___nl__5 = null;
//line 28
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__4);
//line 28
___nl__0 = null;
//line 28
___nl__1 = null;
//line 28
___nl__2 = null;
//line 28
___nl__3 = null;
//line 28
if(true) return ___nl__4;
//line 28
___nl__4 = null;
//line 28
___nl__2 = null;
//line 28
___nl__3 = null;
//line 29
if (true) {goto label_2;}
//line 29
label_2:
//line 29
___nl__1 = null;
//line 31
___nl__2 = new ImmString("fun_val");
//line 31
___nl__1 = ov_NL.NL_is(___nl__0,___nl__2);

//line 31
___nl__2 = null;
//line 31
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1));
//line 31
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1));
//line 31
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_6;}}
//line 31
___nl__2 = new ImmString("can parse only function: ");
//line 31
___nl__3 = ov_NL.NL_get_element(___nl__0);

//line 31
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 31
___nl__3 = null;
//line 31
___nl__2 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("err"), ___nl__2);
//line 31
___nl__0 = null;
//line 31
___nl__1 = null;
//line 31
if(true) return ___nl__2;
//line 31
___nl__2 = null;
//line 31
if (true) {goto label_6;}
//line 31
label_6:
//line 31
___nl__1 = null;
//line 32
___nl__1 = ___nl__0;
//line 32
___nl__1 = c_rt_lib_NL.NL_ov_as(___nl__1, new ImmString("fun_val"));
//line 33
___nl__2 = ((ImmHash)___nl__1).getHashValue()["module"];
//line 33
___nl__3 = new ImmString("ptd");
//line 33
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 33
___nl__3 = null;
//line 33
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 33
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 33
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_8;}}
//line 33
___nl__3 = new ImmString("can parse only ptd function: ");
//line 33
___nl__4 = ((ImmHash)___nl__1).getHashValue()["module"];
//line 33
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 33
___nl__4 = null;
//line 33
___nl__4 = new ImmString("::");
//line 33
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 33
___nl__4 = null;
//line 33
___nl__4 = ((ImmHash)___nl__1).getHashValue()["name"];
//line 33
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 33
___nl__4 = null;
//line 33
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("err"), ___nl__3);
//line 33
___nl__0 = null;
//line 33
___nl__1 = null;
//line 33
___nl__2 = null;
//line 33
if(true) return ___nl__3;
//line 33
___nl__3 = null;
//line 33
if (true) {goto label_8;}
//line 33
label_8:
//line 33
___nl__2 = null;
//line 36
___nl__3 = ((ImmHash)___nl__1).getHashValue()["args"];
//line 36
___nl__2 = array_NL.NL_len(___nl__3);

//line 36
___nl__3 = null;
//line 37
___nl__3 = ((ImmHash)___nl__1).getHashValue()["name"];
//line 38
___nl__4 = new ImmString("sim");
//line 38
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__4.toString()));
//line 38
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 38
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_10;}}
//line 39
___nl__5 = new ImmDouble(0);
//line 39
___nl__5 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__2.getValue().ToString())) ==((Double.Parse(___nl__5.getValue().ToString())))  );
//line 39
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 39
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 39
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_12;}}
//line 39
___nl__6 = new ImmString("sim can't have arguments: ");
//line 39
___nl__6 = new ImmString(___nl__6.toString() + ___nl__2.toString());
//line 39
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("err"), ___nl__6);
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
if(true) return ___nl__6;
//line 39
___nl__6 = null;
//line 39
if (true) {goto label_12;}
//line 39
label_12:
//line 39
___nl__5 = null;
//line 40
___nl__5 = tct_NL.NL_tct_sim();

//line 40
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__5);
//line 40
___nl__0 = null;
//line 40
___nl__1 = null;
//line 40
___nl__2 = null;
//line 40
___nl__3 = null;
//line 40
___nl__4 = null;
//line 40
if(true) return ___nl__5;
//line 40
___nl__5 = null;
//line 41
if (true) {goto label_16;}
//line 41
label_10:
//line 41
___nl__4 = new ImmString("ptd_im");
//line 41
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__4.toString()));
//line 41
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 41
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_13;}}
//line 42
___nl__5 = new ImmDouble(0);
//line 42
___nl__5 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__2.getValue().ToString())) ==((Double.Parse(___nl__5.getValue().ToString())))  );
//line 42
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 42
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 42
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_15;}}
//line 42
___nl__6 = new ImmString("im can't have arguments: ");
//line 42
___nl__6 = new ImmString(___nl__6.toString() + ___nl__2.toString());
//line 42
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("err"), ___nl__6);
//line 42
___nl__0 = null;
//line 42
___nl__1 = null;
//line 42
___nl__2 = null;
//line 42
___nl__3 = null;
//line 42
___nl__4 = null;
//line 42
___nl__5 = null;
//line 42
if(true) return ___nl__6;
//line 42
___nl__6 = null;
//line 42
if (true) {goto label_15;}
//line 42
label_15:
//line 42
___nl__5 = null;
//line 43
___nl__5 = tct_NL.NL_tct_im();

//line 43
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__5);
//line 43
___nl__0 = null;
//line 43
___nl__1 = null;
//line 43
___nl__2 = null;
//line 43
___nl__3 = null;
//line 43
___nl__4 = null;
//line 43
if(true) return ___nl__5;
//line 43
___nl__5 = null;
//line 44
if (true) {goto label_16;}
//line 44
label_13:
//line 44
___nl__4 = new ImmString("void");
//line 44
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__4.toString()));
//line 44
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 44
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_16;}}
//line 45
___nl__5 = new ImmString("Void type can be used only as a return type of function");
//line 45
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("err"), ___nl__5);
//line 45
___nl__0 = null;
//line 45
___nl__1 = null;
//line 45
___nl__2 = null;
//line 45
___nl__3 = null;
//line 45
___nl__4 = null;
//line 45
if(true) return ___nl__5;
//line 45
___nl__5 = null;
//line 46
if (true) {goto label_16;}
//line 46
label_16:
//line 46
___nl__4 = null;
//line 47
___nl__4 = new ImmString("none");
//line 47
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__4.toString()));
//line 47
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 47
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_18;}}
//line 47
___nl__5 = new ImmString("'none' type can be used only in 'var' type");
//line 47
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("err"), ___nl__5);
//line 47
___nl__0 = null;
//line 47
___nl__1 = null;
//line 47
___nl__2 = null;
//line 47
___nl__3 = null;
//line 47
___nl__4 = null;
//line 47
if(true) return ___nl__5;
//line 47
___nl__5 = null;
//line 47
if (true) {goto label_18;}
//line 47
label_18:
//line 47
___nl__4 = null;
//line 48
___nl__5 = ((ImmHash)___nl__1).getHashValue()["args"];
//line 48
___nl__4 = array_NL.NL_len(___nl__5);

//line 48
___nl__5 = null;
//line 48
___nl__5 = new ImmDouble(1);
//line 48
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString())) ==((Double.Parse(___nl__5.getValue().ToString())))  );
//line 48
___nl__5 = null;
//line 48
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 48
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 48
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_20;}}
//line 48
___nl__5 = new ImmString("expected one argument in ");
//line 48
___nl__5 = new ImmString(___nl__5.toString() + ___nl__3.toString());
//line 48
___nl__6 = new ImmString(" function call");
//line 48
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 48
___nl__6 = null;
//line 48
___nl__5 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("err"), ___nl__5);
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
if(true) return ___nl__5;
//line 48
___nl__5 = null;
//line 48
if (true) {goto label_20;}
//line 48
label_20:
//line 48
___nl__4 = null;
//line 49
___nl__4 = ((ImmHash)___nl__1).getHashValue()["args"];
//line 49
___nl__5 = new ImmDouble(0);
//line 49
___nl__4 = (___nl__4 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()];
//line 49
___nl__5 = null;
//line 49
___nl__4 = ((ImmHash)___nl__4).getHashValue()["val"];
//line 50
___nl__5 = new ImmString("rec");
//line 50
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__5.toString()));
//line 50
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 50
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_22;}}
//line 51
___nl__7 = new ImmString("hash_decl");
//line 51
___nl__6 = ov_NL.NL_is(___nl__4,___nl__7);

//line 51
___nl__7 = null;
//line 51
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 51
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 51
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_24;}}
//line 51
___nl__7 = new ImmString("rec must have hash: ");
//line 51
___nl__8 = ov_NL.NL_get_element(___nl__4);

//line 51
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 51
___nl__8 = null;
//line 51
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("err"), ___nl__7);
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
___nl__6 = null;
//line 51
if(true) return ___nl__7;
//line 51
___nl__7 = null;
//line 51
if (true) {goto label_24;}
//line 51
label_24:
//line 51
___nl__6 = null;
//line 52
___nl__8 = ptd_parser_NL.NL_parse_hash_priv(___nl__4);

//line 52
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("ok"));
//line 52
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_25;}}
//line 52
___nl__0 = null;
//line 52
___nl__1 = null;
//line 52
___nl__2 = null;
//line 52
___nl__3 = null;
//line 52
___nl__4 = null;
//line 52
___nl__5 = null;
//line 52
___nl__6 = null;
//line 52
___nl__7 = null;
//line 52
if(true) return ___nl__8;
//line 52
label_25:
//line 52
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__8, new ImmString("ok"));
//line 52
___nl__7 = null;
//line 52
___nl__8 = null;
//line 53
___nl__7 = tct_NL.NL_tct_rec(___nl__6);

//line 53
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__7);
//line 53
___nl__0 = null;
//line 53
___nl__1 = null;
//line 53
___nl__2 = null;
//line 53
___nl__3 = null;
//line 53
___nl__4 = null;
//line 53
___nl__5 = null;
//line 53
___nl__6 = null;
//line 53
if(true) return ___nl__7;
//line 53
___nl__7 = null;
//line 53
___nl__6 = null;
//line 54
if (true) {goto label_21;}
//line 54
label_22:
//line 54
___nl__5 = new ImmString("hash");
//line 54
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__5.toString()));
//line 54
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 54
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_26;}}
//line 55
___nl__8 = ptd_parser_NL.NL_try_value_to_ptd(___nl__4);

//line 55
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("ok"));
//line 55
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_27;}}
//line 55
___nl__0 = null;
//line 55
___nl__1 = null;
//line 55
___nl__2 = null;
//line 55
___nl__3 = null;
//line 55
___nl__4 = null;
//line 55
___nl__5 = null;
//line 55
___nl__6 = null;
//line 55
___nl__7 = null;
//line 55
if(true) return ___nl__8;
//line 55
label_27:
//line 55
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__8, new ImmString("ok"));
//line 55
___nl__7 = null;
//line 55
___nl__8 = null;
//line 56
___nl__7 = tct_NL.NL_tct_hash(___nl__6);

//line 56
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__7);
//line 56
___nl__0 = null;
//line 56
___nl__1 = null;
//line 56
___nl__2 = null;
//line 56
___nl__3 = null;
//line 56
___nl__4 = null;
//line 56
___nl__5 = null;
//line 56
___nl__6 = null;
//line 56
if(true) return ___nl__7;
//line 56
___nl__7 = null;
//line 56
___nl__6 = null;
//line 57
if (true) {goto label_21;}
//line 57
label_26:
//line 57
___nl__5 = new ImmString("arr");
//line 57
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__5.toString()));
//line 57
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 57
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_28;}}
//line 58
___nl__8 = ptd_parser_NL.NL_try_value_to_ptd(___nl__4);

//line 58
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("ok"));
//line 58
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_29;}}
//line 58
___nl__0 = null;
//line 58
___nl__1 = null;
//line 58
___nl__2 = null;
//line 58
___nl__3 = null;
//line 58
___nl__4 = null;
//line 58
___nl__5 = null;
//line 58
___nl__6 = null;
//line 58
___nl__7 = null;
//line 58
if(true) return ___nl__8;
//line 58
label_29:
//line 58
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__8, new ImmString("ok"));
//line 58
___nl__7 = null;
//line 58
___nl__8 = null;
//line 59
___nl__7 = tct_NL.NL_tct_arr(___nl__6);

//line 59
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__7);
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
if(true) return ___nl__7;
//line 59
___nl__7 = null;
//line 59
___nl__6 = null;
//line 60
if (true) {goto label_21;}
//line 60
label_28:
//line 60
___nl__5 = new ImmString("var");
//line 60
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__5.toString()));
//line 60
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 60
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_30;}}
//line 61
___nl__6 = new ImmDouble(1);
//line 61
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__2.getValue().ToString())) ==((Double.Parse(___nl__6.getValue().ToString())))  );
//line 61
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 61
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 61
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_32;}}
//line 61
___nl__7 = new ImmString("var must have hash");
//line 61
___nl__7 = new ImmString(___nl__7.toString() + ___nl__2.toString());
//line 61
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("err"), ___nl__7);
//line 61
___nl__0 = null;
//line 61
___nl__1 = null;
//line 61
___nl__2 = null;
//line 61
___nl__3 = null;
//line 61
___nl__4 = null;
//line 61
___nl__5 = null;
//line 61
___nl__6 = null;
//line 61
if(true) return ___nl__7;
//line 61
___nl__7 = null;
//line 61
if (true) {goto label_32;}
//line 61
label_32:
//line 61
___nl__6 = null;
//line 62
___nl__7 = new ImmString("hash_decl");
//line 62
___nl__6 = ov_NL.NL_is(___nl__4,___nl__7);

//line 62
___nl__7 = null;
//line 62
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 62
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 62
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_34;}}
//line 62
___nl__7 = new ImmString("var must have hash: ");
//line 62
___nl__8 = ov_NL.NL_get_element(___nl__4);

//line 62
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 62
___nl__8 = null;
//line 62
___nl__7 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("err"), ___nl__7);
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
if(true) return ___nl__7;
//line 62
___nl__7 = null;
//line 62
if (true) {goto label_34;}
//line 62
label_34:
//line 62
___nl__6 = null;
//line 63
___nl__6 = ___nl__4;
//line 63
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("hash_decl"));
//line 64
__function_map = new Dictionary<String, Imm>();
___nl__7 = new ImmHash(__function_map);
//line 65
___nl__9 = new ImmDouble(0);
//line 65
___nl__10 = new ImmDouble(1);
//line 65
___nl__11 = c_rt_lib_NL.NL_array_len(___nl__6);

//line 65
label_37:
//line 65
___nl__12 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__9.getValue().ToString()))>=(Double.Parse(___nl__11.getValue().ToString())) );
//line 65
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_35;}}
//line 65
___nl__8 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()];
//line 66
___nl__14 = ((ImmHash)___nl__8).getHashValue()["val"];
//line 66
___nl__15 = new ImmString("fun_val");
//line 66
___nl__13 = ov_NL.NL_is(___nl__14,___nl__15);

//line 66
___nl__15 = null;
//line 66
___nl__14 = null;
//line 66
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13));
//line 66
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_39;}}
//line 67
___nl__14 = ((ImmHash)___nl__8).getHashValue()["val"];
//line 67
___nl__14 = c_rt_lib_NL.NL_ov_as(___nl__14, new ImmString("fun_val"));
//line 67
___nl__1 = ___nl__14;
//line 67
___nl__14 = null;
//line 68
___nl__14 = ((ImmHash)___nl__1).getHashValue()["module"];
//line 68
___nl__16 = new ImmString("ptd");
//line 68
___nl__14 = c_rt_lib_NL.NL_native_to_nl(___nl__14.toString().Equals(___nl__16.toString()));
//line 68
___nl__16 = null;
//line 68
___nl__15 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__14));
//line 68
if (c_rt_lib_NL.NL_check_true_native(___nl__15)) {if (true) {goto label_42;}}
//line 68
___nl__14 = ((ImmHash)___nl__1).getHashValue()["name"];
//line 68
___nl__16 = new ImmString("none");
//line 68
___nl__14 = c_rt_lib_NL.NL_native_to_nl(___nl__14.toString().Equals(___nl__16.toString()));
//line 68
___nl__16 = null;
//line 68
label_42:
//line 68
___nl__15 = null;
//line 68
___nl__14 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__14));
//line 68
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_41;}}
//line 69
___nl__16 = ((ImmHash)___nl__8).getHashValue()["key"];
//line 69
___nl__17 = new ImmString("hash_key");
//line 69
___nl__15 = ov_NL.NL_as(___nl__16,___nl__17);

//line 69
___nl__17 = null;
//line 69
___nl__16 = null;
//line 69
___nl__16 = tct_NL.NL_tct_none();

//line 69
___ref______nl__7 = new ImmRef(___nl__7);
hash_NL.NL_set_value(___ref______nl__7,___nl__15,___nl__16);
___nl__7 = ___ref______nl__7.getValue();

//line 69
___nl__16 = null;
//line 69
___nl__15 = null;
//line 70
___nl__13 = null;
//line 70
___nl__14 = null;
//line 70
if (true) {goto label_36;}
//line 71
if (true) {goto label_41;}
//line 71
label_41:
//line 71
___nl__14 = null;
//line 72
if (true) {goto label_39;}
//line 72
label_39:
//line 72
___nl__13 = null;
//line 73
___nl__16 = ((ImmHash)___nl__8).getHashValue()["val"];
//line 73
___nl__15 = ptd_parser_NL.NL_try_value_to_ptd(___nl__16);

//line 73
___nl__16 = null;
//line 73
___nl__14 = c_rt_lib_NL.NL_ov_is(___nl__15, new ImmString("ok"));
//line 73
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_43;}}
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
label_43:
//line 73
___nl__13 = c_rt_lib_NL.NL_ov_as(___nl__15, new ImmString("ok"));
//line 73
___nl__14 = null;
//line 73
___nl__15 = null;
//line 74
___nl__15 = ((ImmHash)___nl__8).getHashValue()["key"];
//line 74
___nl__16 = new ImmString("hash_key");
//line 74
___nl__14 = ov_NL.NL_as(___nl__15,___nl__16);

//line 74
___nl__16 = null;
//line 74
___nl__15 = null;
//line 74
___ref______nl__7 = new ImmRef(___nl__7);
hash_NL.NL_set_value(___ref______nl__7,___nl__14,___nl__13);
___nl__7 = ___ref______nl__7.getValue();

//line 74
___nl__14 = null;
//line 74
___nl__13 = null;
//line 74
label_36:
//line 75
___nl__9 = new ImmDouble((Double.Parse(___nl__9.getValue().ToString()))+(Double.Parse(___nl__10.getValue().ToString())));
//line 75
if (true) {goto label_37;}
//line 75
label_35:
//line 75
___nl__8 = null;
//line 75
___nl__9 = null;
//line 75
___nl__10 = null;
//line 75
___nl__11 = null;
//line 75
___nl__12 = null;
//line 76
___nl__8 = tct_NL.NL_tct_var(___nl__7);

//line 76
___nl__8 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__8);
//line 76
___nl__0 = null;
//line 76
___nl__1 = null;
//line 76
___nl__2 = null;
//line 76
___nl__3 = null;
//line 76
___nl__4 = null;
//line 76
___nl__5 = null;
//line 76
___nl__6 = null;
//line 76
___nl__7 = null;
//line 76
if(true) return ___nl__8;
//line 76
___nl__8 = null;
//line 76
___nl__6 = null;
//line 76
___nl__7 = null;
//line 77
if (true) {goto label_21;}
//line 77
label_30:
//line 78
___nl__6 = new ImmString("it is not type function : ");
//line 78
___nl__6 = new ImmString(___nl__6.toString() + ___nl__3.toString());
//line 78
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("err"), ___nl__6);
//line 78
___nl__0 = null;
//line 78
___nl__1 = null;
//line 78
___nl__2 = null;
//line 78
___nl__3 = null;
//line 78
___nl__4 = null;
//line 78
___nl__5 = null;
//line 78
if(true) return ___nl__6;
//line 78
___nl__6 = null;
//line 79
if (true) {goto label_21;}
//line 79
label_21:
//line 79
___nl__5 = null;
//line 79
___nl__1 = null;
//line 79
___nl__2 = null;
//line 79
___nl__3 = null;
//line 79
___nl__4 = null;
//line 79
___nl__0 = null;
//line 79
if(true) return null;
}

private static Imm NL_parse_hash_priv(Imm ___arg__0) {
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
//line 84
___nl__1 = ___nl__0;
//line 84
___nl__1 = c_rt_lib_NL.NL_ov_as(___nl__1, new ImmString("hash_decl"));
//line 85
__function_map = new Dictionary<String, Imm>();
___nl__2 = new ImmHash(__function_map);
//line 86
___nl__4 = new ImmDouble(0);
//line 86
___nl__5 = new ImmDouble(1);
//line 86
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__1);

//line 86
label_3:
//line 86
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) );
//line 86
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_1;}}
//line 86
___nl__3 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()];
//line 87
___nl__11 = ((ImmHash)___nl__3).getHashValue()["val"];
//line 87
___nl__10 = ptd_parser_NL.NL_try_value_to_ptd(___nl__11);

//line 87
___nl__11 = null;
//line 87
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__10, new ImmString("ok"));
//line 87
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_4;}}
//line 87
___nl__0 = null;
//line 87
___nl__1 = null;
//line 87
___nl__2 = null;
//line 87
___nl__3 = null;
//line 87
___nl__4 = null;
//line 87
___nl__5 = null;
//line 87
___nl__6 = null;
//line 87
___nl__7 = null;
//line 87
___nl__8 = null;
//line 87
___nl__9 = null;
//line 87
if(true) return ___nl__10;
//line 87
label_4:
//line 87
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__10, new ImmString("ok"));
//line 87
___nl__9 = null;
//line 87
___nl__10 = null;
//line 88
___nl__10 = ((ImmHash)___nl__3).getHashValue()["key"];
//line 88
___nl__11 = new ImmString("hash_key");
//line 88
___nl__9 = ov_NL.NL_as(___nl__10,___nl__11);

//line 88
___nl__11 = null;
//line 88
___nl__10 = null;
//line 88
___ref______nl__2 = new ImmRef(___nl__2);
hash_NL.NL_set_value(___ref______nl__2,___nl__9,___nl__8);
___nl__2 = ___ref______nl__2.getValue();

//line 88
___nl__9 = null;
//line 88
___nl__8 = null;
//line 89
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString())));
//line 89
if (true) {goto label_3;}
//line 89
label_1:
//line 89
___nl__3 = null;
//line 89
___nl__4 = null;
//line 89
___nl__5 = null;
//line 89
___nl__6 = null;
//line 89
___nl__7 = null;
//line 90
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__2);
//line 90
___nl__0 = null;
//line 90
___nl__1 = null;
//line 90
___nl__2 = null;
//line 90
if(true) return ___nl__3;
//line 90
___nl__3 = null;
//line 90
___nl__1 = null;
//line 90
___nl__2 = null;
//line 90
___nl__0 = null;
//line 90
if(true) return null;
}

}
}