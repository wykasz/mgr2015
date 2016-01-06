using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class dfile_NL {

public static Imm NL_fsave(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 17
___nl__4 = dfile_NL.NL_ssave(___nl__1);

//line 17
___nl__3 = c_fe_lib_NL.NL_string_to_file(___nl__0,___nl__4);

//line 17
___nl__4 = null;
//line 17
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("ok"));
//line 17
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_1;}}
//line 17
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ensure"), ___nl__3);
//line 17
c_rt_lib_NL.NL_die();
//line 17
label_1:
//line 17
___nl__2 = null;
//line 17
___nl__3 = null;
//line 17
___nl__0 = null;
//line 17
___nl__1 = null;
//line 17
if(true) return null;
}

public static Imm NL_fload(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 21
___nl__3 = c_fe_lib_NL.NL_file_to_string(___nl__0);

//line 21
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("ok"));
//line 21
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_1;}}
//line 21
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ensure"), ___nl__3);
//line 21
c_rt_lib_NL.NL_die();
//line 21
label_1:
//line 21
___nl__1 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("ok"));
//line 21
___nl__2 = null;
//line 21
___nl__3 = null;
//line 22
___nl__2 = dfile_NL.NL_sload(___nl__1);

//line 22
___nl__0 = null;
//line 22
___nl__1 = null;
//line 22
if(true) return ___nl__2;
//line 22
___nl__2 = null;
//line 22
___nl__1 = null;
//line 22
___nl__0 = null;
//line 22
if(true) return null;
}

public static Imm NL_ssave(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 26
___nl__2 = new ImmString("");
//line 26
__function_map = new Dictionary<String, Imm>();
___nl__3 = new ImmHash(__function_map);
//line 26
__function_map = new Dictionary<String, Imm>();
__function_map.Add("str",___nl__2);
__function_map.Add("objects",___nl__3);
___nl__1 = new ImmHash(__function_map);
//line 26
___nl__2 = null;
//line 26
___nl__3 = null;
//line 27
___nl__2 = new ImmDouble(0);
//line 27
___nl__3 = c_rt_lib_NL.NL_get_false();
//line 27
___ref______nl__1 = new ImmRef(___nl__1);
dfile_NL.NL_sprint_priv(___ref______nl__1,___nl__0,___nl__2,___nl__3);
___nl__1 = ___ref______nl__1.getValue();

//line 27
___nl__3 = null;
//line 27
___nl__2 = null;
//line 28
___nl__2 = ((ImmHash)___nl__1).getHashValue()["str"];
//line 28
___nl__0 = null;
//line 28
___nl__1 = null;
//line 28
if(true) return ___nl__2;
//line 28
___nl__2 = null;
//line 28
___nl__1 = null;
//line 28
___nl__0 = null;
//line 28
if(true) return null;
}

public static Imm NL_debug(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 32
___nl__2 = new ImmString("");
//line 32
__function_map = new Dictionary<String, Imm>();
___nl__3 = new ImmHash(__function_map);
//line 32
__function_map = new Dictionary<String, Imm>();
__function_map.Add("str",___nl__2);
__function_map.Add("objects",___nl__3);
___nl__1 = new ImmHash(__function_map);
//line 32
___nl__2 = null;
//line 32
___nl__3 = null;
//line 33
___nl__2 = new ImmDouble(0);
//line 33
___nl__3 = c_rt_lib_NL.NL_get_true();
//line 33
___ref______nl__1 = new ImmRef(___nl__1);
dfile_NL.NL_sprint_priv(___ref______nl__1,___nl__0,___nl__2,___nl__3);
___nl__1 = ___ref______nl__1.getValue();

//line 33
___nl__3 = null;
//line 33
___nl__2 = null;
//line 34
___nl__2 = ((ImmHash)___nl__1).getHashValue()["str"];
//line 34
___nl__0 = null;
//line 34
___nl__1 = null;
//line 34
if(true) return ___nl__2;
//line 34
___nl__2 = null;
//line 34
___nl__1 = null;
//line 34
___nl__0 = null;
//line 34
if(true) return null;
}

public static Imm NL_ssave_net_format(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 38
___nl__2 = new ImmString("");
//line 38
__function_map = new Dictionary<String, Imm>();
___nl__3 = new ImmHash(__function_map);
//line 38
__function_map = new Dictionary<String, Imm>();
__function_map.Add("str",___nl__2);
__function_map.Add("objects",___nl__3);
___nl__1 = new ImmHash(__function_map);
//line 38
___nl__2 = null;
//line 38
___nl__3 = null;
//line 39
___ref______nl__1 = new ImmRef(___nl__1);
dfile_NL.NL_print_net_format_priv(___ref______nl__1,___nl__0);
___nl__1 = ___ref______nl__1.getValue();

//line 40
___nl__2 = ((ImmHash)___nl__1).getHashValue()["str"];
//line 40
___nl__0 = null;
//line 40
___nl__1 = null;
//line 40
if(true) return ___nl__2;
//line 40
___nl__2 = null;
//line 40
___nl__1 = null;
//line 40
___nl__0 = null;
//line 40
if(true) return null;
}

private static Imm NL_eat_ws_priv(ImmRef ___arg__0) {
Imm ___nl__0 = ___arg__0.getValue().clone();
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
//line 44
label_2:
//line 45
___nl__1 = ((ImmHash)___nl__0).getHashValue()["pos"];
//line 45
___nl__2 = ((ImmHash)___nl__0).getHashValue()["len"];
//line 45
___nl__1 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__1.getValue().ToString())) ==((Double.Parse(___nl__2.getValue().ToString())))  );
//line 45
___nl__2 = null;
//line 45
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1));
//line 45
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_4;}}
//line 45
___nl__1 = null;
//line 45
___arg__0.setValue(___nl__0);if(true) return null;
//line 45
if (true) {goto label_4;}
//line 45
label_4:
//line 45
___nl__1 = null;
//line 46
___ref______nl__0 = new ImmRef(___nl__0);
___nl__2 = dfile_NL.NL_get_char_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 46
___nl__1 = string_NL.NL_ord(___nl__2);

//line 46
___nl__2 = null;
//line 47
___nl__2 = new ImmDouble(9);
//line 47
___nl__2 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__1.getValue().ToString())) ==((Double.Parse(___nl__2.getValue().ToString())))  );
//line 47
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_9;}}
//line 47
___nl__2 = new ImmDouble(10);
//line 47
___nl__2 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__1.getValue().ToString())) ==((Double.Parse(___nl__2.getValue().ToString())))  );
//line 47
label_9:
//line 47
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_8;}}
//line 47
___nl__2 = new ImmDouble(13);
//line 47
___nl__2 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__1.getValue().ToString())) ==((Double.Parse(___nl__2.getValue().ToString())))  );
//line 47
label_8:
//line 47
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_7;}}
//line 47
___nl__2 = new ImmDouble(32);
//line 47
___nl__2 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__1.getValue().ToString())) ==((Double.Parse(___nl__2.getValue().ToString())))  );
//line 47
label_7:
//line 47
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 47
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_6;}}
//line 48
___nl__3 = new ImmString("pos");
//line 48
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__3);

//line 48
___nl__4 = new ImmDouble(1);
//line 48
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString())));
//line 48
___nl__5 = new ImmString("pos");
//line 48
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 48
___nl__5 = null;
//line 48
___nl__3 = null;
//line 48
___nl__4 = null;
//line 49
if (true) {goto label_5;}
//line 49
label_6:
//line 50
___nl__1 = null;
//line 50
___nl__2 = null;
//line 50
___arg__0.setValue(___nl__0);if(true) return null;
//line 51
if (true) {goto label_5;}
//line 51
label_5:
//line 51
___nl__2 = null;
//line 51
___nl__1 = null;
//line 44
if (true) {goto label_2;}
//line 44
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_get_char_priv(ImmRef ___arg__0) {
Imm ___nl__0 = ___arg__0.getValue().clone();
Imm ___nl__1 = null;
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
//line 55
___nl__2 = ptd_NL.NL_sim();

//line 55
___nl__4 = ((ImmHash)___nl__0).getHashValue()["str"];
//line 55
___nl__5 = ((ImmHash)___nl__0).getHashValue()["pos"];
//line 55
___nl__6 = new ImmDouble(1);
//line 55
___nl__3 = c_std_lib_NL.NL_fast_substr(___nl__4,___nl__5,___nl__6);

//line 55
___nl__6 = null;
//line 55
___nl__5 = null;
//line 55
___nl__4 = null;
//line 55
___nl__1 = ptd_NL.NL_ensure(___nl__2,___nl__3);

//line 55
___nl__3 = null;
//line 55
___nl__2 = null;
//line 55
___arg__0.setValue(___nl__0);if(true) return ___nl__1;
//line 55
___nl__1 = null;
//line 55
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_is_ov_priv(ImmRef ___arg__0) {
Imm ___nl__0 = ___arg__0.getValue().clone();
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
//line 58
___nl__2 = ((ImmHash)___nl__0).getHashValue()["str"];
//line 58
___nl__3 = ((ImmHash)___nl__0).getHashValue()["pos"];
//line 58
___nl__4 = new ImmDouble(7);
//line 58
___nl__1 = c_std_lib_NL.NL_fast_substr(___nl__2,___nl__3,___nl__4);

//line 58
___nl__4 = null;
//line 58
___nl__3 = null;
//line 58
___nl__2 = null;
//line 58
___nl__2 = new ImmString("ov::mk(");
//line 58
___nl__1 = c_rt_lib_NL.NL_native_to_nl(___nl__1.toString().Equals(___nl__2.toString()));
//line 58
___nl__2 = null;
//line 58
___arg__0.setValue(___nl__0);if(true) return ___nl__1;
//line 58
___nl__1 = null;
//line 58
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_eat_non_ws_priv(ImmRef ___arg__0, ImmRef ___arg__1) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.getValue().clone();
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
//line 62
___nl__2 = new ImmString("");
//line 63
___nl__3 = ((ImmHash)___nl__0).getHashValue()["len"];
//line 64
___nl__4 = ((ImmHash)___nl__0).getHashValue()["pos"];
//line 64
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__3.getValue().ToString())) );
//line 64
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 64
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 65
___nl__5 = c_rt_lib_NL.NL_get_true();
//line 65
___nl__1 = ___nl__5;
//line 65
___nl__5 = null;
//line 66
___nl__5 = new ImmString("pos ");
//line 66
___nl__6 = ((ImmHash)___nl__0).getHashValue()["pos"];
//line 66
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 66
___nl__6 = null;
//line 66
___nl__6 = new ImmString(": expected scalar");
//line 66
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 66
___nl__6 = null;
//line 66
___nl__2 = null;
//line 66
___nl__3 = null;
//line 66
___nl__4 = null;
//line 66
___arg__0.setValue(___nl__0);___arg__1.setValue(___nl__1);if(true) return ___nl__5;
//line 66
___nl__5 = null;
//line 67
if (true) {goto label_2;}
//line 67
label_2:
//line 67
___nl__4 = null;
//line 68
label_4:
//line 69
___ref______nl__0 = new ImmRef(___nl__0);
___nl__4 = dfile_NL.NL_get_char_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 70
___nl__5 = string_NL.NL_is_letter(___nl__4);

//line 70
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_8;}}
//line 70
___nl__5 = string_NL.NL_is_digit(___nl__4);

//line 70
label_8:
//line 70
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_7;}}
//line 70
___nl__5 = new ImmString("_");
//line 70
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__4.toString().Equals(___nl__5.toString()));
//line 70
label_7:
//line 70
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 70
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 70
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_6;}}
//line 70
___nl__4 = null;
//line 70
___nl__5 = null;
//line 70
if (true) {goto label_3;}
//line 70
if (true) {goto label_6;}
//line 70
label_6:
//line 70
___nl__5 = null;
//line 71
___nl__5 = new ImmString("pos");
//line 71
___nl__5 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__5);

//line 71
___nl__6 = new ImmDouble(1);
//line 71
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString())));
//line 71
___nl__7 = new ImmString("pos");
//line 71
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__7,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 71
___nl__7 = null;
//line 71
___nl__5 = null;
//line 71
___nl__6 = null;
//line 72
___nl__2 = new ImmString(___nl__2.toString() + ___nl__4.toString());
//line 73
___nl__5 = ((ImmHash)___nl__0).getHashValue()["pos"];
//line 73
___nl__5 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__3.getValue().ToString())) );
//line 73
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 73
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_10;}}
//line 73
___nl__4 = null;
//line 73
___nl__5 = null;
//line 73
if (true) {goto label_3;}
//line 73
if (true) {goto label_10;}
//line 73
label_10:
//line 73
___nl__5 = null;
//line 73
___nl__4 = null;
//line 68
if (true) {goto label_4;}
//line 68
label_3:
//line 75
___nl__4 = new ImmString("");
//line 75
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__4.toString()));
//line 75
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 75
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_12;}}
//line 76
___nl__5 = c_rt_lib_NL.NL_get_true();
//line 76
___nl__1 = ___nl__5;
//line 76
___nl__5 = null;
//line 77
___nl__5 = new ImmString("pos ");
//line 77
___nl__6 = ((ImmHash)___nl__0).getHashValue()["pos"];
//line 77
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 77
___nl__6 = null;
//line 77
___nl__6 = new ImmString(": expected scalar");
//line 77
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 77
___nl__6 = null;
//line 77
___nl__2 = null;
//line 77
___nl__3 = null;
//line 77
___nl__4 = null;
//line 77
___arg__0.setValue(___nl__0);___arg__1.setValue(___nl__1);if(true) return ___nl__5;
//line 77
___nl__5 = null;
//line 78
if (true) {goto label_12;}
//line 78
label_12:
//line 78
___nl__4 = null;
//line 79
___nl__3 = null;
//line 79
___arg__0.setValue(___nl__0);___arg__1.setValue(___nl__1);if(true) return ___nl__2;
//line 79
___nl__2 = null;
//line 79
___nl__3 = null;
//line 79
___arg__0.setValue(___nl__0);___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_parse_scalar_priv(ImmRef ___arg__0, ImmRef ___arg__1) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.getValue().clone();
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
//line 83
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_eat_ws_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 84
___ref______nl__0 = new ImmRef(___nl__0);
___nl__2 = dfile_NL.NL_get_char_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 84
___nl__3 = new ImmString("\"");
//line 84
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 84
___nl__3 = null;
//line 84
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 84
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 85
___nl__3 = new ImmString("pos");
//line 85
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__3);

//line 85
___nl__4 = new ImmDouble(1);
//line 85
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString())));
//line 85
___nl__5 = new ImmString("pos");
//line 85
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 85
___nl__5 = null;
//line 85
___nl__3 = null;
//line 85
___nl__4 = null;
//line 86
___nl__3 = new ImmString("");
//line 87
label_4:
//line 88
___nl__4 = ((ImmHash)___nl__0).getHashValue()["pos"];
//line 88
___nl__5 = ((ImmHash)___nl__0).getHashValue()["len"];
//line 88
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__5.getValue().ToString())) );
//line 88
___nl__5 = null;
//line 88
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 88
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_6;}}
//line 89
___nl__5 = c_rt_lib_NL.NL_get_true();
//line 89
___nl__1 = ___nl__5;
//line 89
___nl__5 = null;
//line 90
___nl__5 = new ImmString("pos ");
//line 90
___nl__6 = ((ImmHash)___nl__0).getHashValue()["pos"];
//line 90
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 90
___nl__6 = null;
//line 90
___nl__6 = new ImmString(": expected \"");
//line 90
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 90
___nl__6 = null;
//line 90
___nl__2 = null;
//line 90
___nl__3 = null;
//line 90
___nl__4 = null;
//line 90
___arg__0.setValue(___nl__0);___arg__1.setValue(___nl__1);if(true) return ___nl__5;
//line 90
___nl__5 = null;
//line 91
if (true) {goto label_6;}
//line 91
label_6:
//line 91
___nl__4 = null;
//line 92
___ref______nl__0 = new ImmRef(___nl__0);
___nl__4 = dfile_NL.NL_get_char_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 93
___nl__5 = new ImmString("pos");
//line 93
___nl__5 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__5);

//line 93
___nl__6 = new ImmDouble(1);
//line 93
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString())));
//line 93
___nl__7 = new ImmString("pos");
//line 93
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__7,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 93
___nl__7 = null;
//line 93
___nl__5 = null;
//line 93
___nl__6 = null;
//line 94
___nl__5 = new ImmString("\"");
//line 94
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__4.toString().Equals(___nl__5.toString()));
//line 94
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 94
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_8;}}
//line 94
___nl__4 = null;
//line 94
___nl__5 = null;
//line 94
if (true) {goto label_3;}
//line 94
if (true) {goto label_8;}
//line 94
label_8:
//line 94
___nl__5 = null;
//line 95
___nl__5 = new ImmString("\\");
//line 95
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__4.toString().Equals(___nl__5.toString()));
//line 95
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 95
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_10;}}
//line 96
___ref______nl__0 = new ImmRef(___nl__0);
___nl__6 = dfile_NL.NL_get_char_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 97
___nl__7 = new ImmString("n");
//line 97
___nl__7 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__7.toString()));
//line 97
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 97
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_12;}}
//line 98
___nl__8 = string_NL.NL_lf();

//line 98
___nl__3 = new ImmString(___nl__3.toString() + ___nl__8.toString());
//line 98
___nl__8 = null;
//line 99
if (true) {goto label_11;}
//line 99
label_12:
//line 99
___nl__7 = new ImmString("r");
//line 99
___nl__7 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__7.toString()));
//line 99
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 99
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_13;}}
//line 100
___nl__8 = string_NL.NL_r();

//line 100
___nl__3 = new ImmString(___nl__3.toString() + ___nl__8.toString());
//line 100
___nl__8 = null;
//line 101
if (true) {goto label_11;}
//line 101
label_13:
//line 101
___nl__7 = new ImmString("t");
//line 101
___nl__7 = c_rt_lib_NL.NL_native_to_nl(___nl__6.toString().Equals(___nl__7.toString()));
//line 101
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 101
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_14;}}
//line 102
___nl__8 = string_NL.NL_tab();

//line 102
___nl__3 = new ImmString(___nl__3.toString() + ___nl__8.toString());
//line 102
___nl__8 = null;
//line 103
if (true) {goto label_11;}
//line 103
label_14:
//line 104
___nl__3 = new ImmString(___nl__3.toString() + ___nl__6.toString());
//line 105
if (true) {goto label_11;}
//line 105
label_11:
//line 105
___nl__7 = null;
//line 106
___nl__7 = new ImmString("pos");
//line 106
___nl__7 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__7);

//line 106
___nl__8 = new ImmDouble(1);
//line 106
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString())));
//line 106
___nl__9 = new ImmString("pos");
//line 106
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__9,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 106
___nl__9 = null;
//line 106
___nl__7 = null;
//line 106
___nl__8 = null;
//line 106
___nl__6 = null;
//line 107
if (true) {goto label_9;}
//line 107
label_10:
//line 108
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 109
if (true) {goto label_9;}
//line 109
label_9:
//line 109
___nl__5 = null;
//line 109
___nl__4 = null;
//line 87
if (true) {goto label_4;}
//line 87
label_3:
//line 111
___nl__2 = null;
//line 111
___arg__0.setValue(___nl__0);___arg__1.setValue(___nl__1);if(true) return ___nl__3;
//line 111
___nl__3 = null;
//line 112
if (true) {goto label_1;}
//line 112
label_2:
//line 113
___ref______nl__0 = new ImmRef(___nl__0);
___ref______nl__1 = new ImmRef(___nl__1);
___nl__3 = dfile_NL.NL_eat_non_ws_priv(___ref______nl__0,___ref______nl__1);
___nl__0 = ___ref______nl__0.getValue();
___nl__1 = ___ref______nl__1.getValue();

//line 113
___nl__2 = null;
//line 113
___arg__0.setValue(___nl__0);___arg__1.setValue(___nl__1);if(true) return ___nl__3;
//line 113
___nl__3 = null;
//line 114
if (true) {goto label_1;}
//line 114
label_1:
//line 114
___nl__2 = null;
//line 114
___arg__0.setValue(___nl__0);___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_match_s_priv(ImmRef ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.clone();
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
//line 118
___nl__2 = string_NL.NL_length(___nl__1);

//line 119
___nl__4 = ((ImmHash)___nl__0).getHashValue()["str"];
//line 119
___nl__5 = ((ImmHash)___nl__0).getHashValue()["pos"];
//line 119
___nl__3 = c_std_lib_NL.NL_fast_substr(___nl__4,___nl__5,___nl__2);

//line 119
___nl__5 = null;
//line 119
___nl__4 = null;
//line 119
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__1.toString()));
//line 119
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 119
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 120
___nl__4 = new ImmString("pos");
//line 120
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__4);

//line 120
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__2.getValue().ToString())));
//line 120
___nl__5 = new ImmString("pos");
//line 120
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 120
___nl__5 = null;
//line 120
___nl__4 = null;
//line 121
___nl__4 = c_rt_lib_NL.NL_get_true();
//line 121
___nl__1 = null;
//line 121
___nl__2 = null;
//line 121
___nl__3 = null;
//line 121
___arg__0.setValue(___nl__0);if(true) return ___nl__4;
//line 121
___nl__4 = null;
//line 122
if (true) {goto label_1;}
//line 122
label_2:
//line 123
___nl__4 = c_rt_lib_NL.NL_get_false();
//line 123
___nl__1 = null;
//line 123
___nl__2 = null;
//line 123
___nl__3 = null;
//line 123
___arg__0.setValue(___nl__0);if(true) return ___nl__4;
//line 123
___nl__4 = null;
//line 124
if (true) {goto label_1;}
//line 124
label_1:
//line 124
___nl__3 = null;
//line 124
___nl__2 = null;
//line 124
___nl__1 = null;
//line 124
___arg__0.setValue(___nl__0);if(true) return null;
}

public static Imm NL_SINGLETON_state_t() {

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
//line 128
___nl__3 = ptd_NL.NL_sim();

//line 128
___nl__2 = ptd_NL.NL_arr(___nl__3);

//line 128
___nl__3 = null;
//line 128
___nl__3 = ptd_NL.NL_sim();

//line 128
___nl__4 = ptd_NL.NL_sim();

//line 128
__function_map = new Dictionary<String, Imm>();
__function_map.Add("str",___nl__2);
__function_map.Add("len",___nl__3);
__function_map.Add("pos",___nl__4);
___nl__1 = new ImmHash(__function_map);
//line 128
___nl__2 = null;
//line 128
___nl__3 = null;
//line 128
___nl__4 = null;
//line 128
___nl__0 = ptd_NL.NL_rec(___nl__1);

//line 128
___nl__1 = null;
//line 128
if(true) return ___nl__0;
//line 128
___nl__0 = null;
//line 128
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_state_t = null;
public static Imm NL_state_t() {
	if (value__singleton__NL_SINGLETON_state_t == null) {
		value__singleton__NL_SINGLETON_state_t = NL_SINGLETON_state_t();
	}
	return value__singleton__NL_SINGLETON_state_t;
}
private static Imm NL_parse_priv(ImmRef ___arg__0, ImmRef ___arg__1) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.getValue().clone();
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
//line 136
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_eat_ws_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 137
___ref______nl__0 = new ImmRef(___nl__0);
___nl__2 = dfile_NL.NL_get_char_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 138
___nl__3 = new ImmString("{");
//line 138
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 138
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 138
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 139
___nl__4 = new ImmDouble(1);
//line 139
___nl__5 = new ImmString("pos");
//line 139
___nl__5 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__5);

//line 139
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString())));
//line 139
___nl__6 = new ImmString("pos");
//line 139
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__6,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 139
___nl__6 = null;
//line 139
___nl__4 = null;
//line 139
___nl__5 = null;
//line 140
__function_map = new Dictionary<String, Imm>();
___nl__4 = new ImmHash(__function_map);
//line 141
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_eat_ws_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 142
label_4:
//line 142
___nl__6 = new ImmString("}");
//line 142
___ref______nl__0 = new ImmRef(___nl__0);
___nl__5 = dfile_NL.NL_match_s_priv(___ref______nl__0,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

//line 142
___nl__6 = null;
//line 142
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 142
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 142
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_3;}}
//line 143
___ref______nl__0 = new ImmRef(___nl__0);
___ref______nl__1 = new ImmRef(___nl__1);
___nl__6 = dfile_NL.NL_parse_scalar_priv(___ref______nl__0,___ref______nl__1);
___nl__0 = ___ref______nl__0.getValue();
___nl__1 = ___ref______nl__1.getValue();

//line 144
___nl__7 = ___nl__1;
//line 144
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 144
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_6;}}
//line 144
___nl__2 = null;
//line 144
___nl__3 = null;
//line 144
___nl__4 = null;
//line 144
___nl__5 = null;
//line 144
___nl__7 = null;
//line 144
___arg__0.setValue(___nl__0);___arg__1.setValue(___nl__1);if(true) return ___nl__6;
//line 144
if (true) {goto label_6;}
//line 144
label_6:
//line 144
___nl__7 = null;
//line 145
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_eat_ws_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 146
___nl__8 = new ImmString("=>");
//line 146
___ref______nl__0 = new ImmRef(___nl__0);
___nl__7 = dfile_NL.NL_match_s_priv(___ref______nl__0,___nl__8);
___nl__0 = ___ref______nl__0.getValue();

//line 146
___nl__8 = null;
//line 146
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 146
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 146
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_8;}}
//line 147
___nl__8 = c_rt_lib_NL.NL_get_true();
//line 147
___nl__1 = ___nl__8;
//line 147
___nl__8 = null;
//line 148
___nl__8 = new ImmString("pos ");
//line 148
___nl__9 = ((ImmHash)___nl__0).getHashValue()["pos"];
//line 148
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 148
___nl__9 = null;
//line 148
___nl__9 = new ImmString(": expected =>");
//line 148
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 148
___nl__9 = null;
//line 148
___nl__2 = null;
//line 148
___nl__3 = null;
//line 148
___nl__4 = null;
//line 148
___nl__5 = null;
//line 148
___nl__6 = null;
//line 148
___nl__7 = null;
//line 148
___arg__0.setValue(___nl__0);___arg__1.setValue(___nl__1);if(true) return ___nl__8;
//line 148
___nl__8 = null;
//line 149
if (true) {goto label_8;}
//line 149
label_8:
//line 149
___nl__7 = null;
//line 150
___ref______nl__0 = new ImmRef(___nl__0);
___ref______nl__1 = new ImmRef(___nl__1);
___nl__7 = dfile_NL.NL_parse_priv(___ref______nl__0,___ref______nl__1);
___nl__0 = ___ref______nl__0.getValue();
___nl__1 = ___ref______nl__1.getValue();

//line 151
___nl__8 = ___nl__1;
//line 151
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8));
//line 151
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_10;}}
//line 151
___nl__2 = null;
//line 151
___nl__3 = null;
//line 151
___nl__4 = null;
//line 151
___nl__5 = null;
//line 151
___nl__6 = null;
//line 151
___nl__8 = null;
//line 151
___arg__0.setValue(___nl__0);___arg__1.setValue(___nl__1);if(true) return ___nl__7;
//line 151
if (true) {goto label_10;}
//line 151
label_10:
//line 151
___nl__8 = null;
//line 152
___ref______nl__4 = new ImmRef(___nl__4);
hash_NL.NL_set_value(___ref______nl__4,___nl__6,___nl__7);
___nl__4 = ___ref______nl__4.getValue();

//line 153
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_eat_ws_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 154
___nl__9 = new ImmString(",");
//line 154
___ref______nl__0 = new ImmRef(___nl__0);
___nl__8 = dfile_NL.NL_match_s_priv(___ref______nl__0,___nl__9);
___nl__0 = ___ref______nl__0.getValue();

//line 154
___nl__9 = null;
//line 154
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8));
//line 154
___nl__8 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__8));
//line 154
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_12;}}
//line 155
___nl__9 = c_rt_lib_NL.NL_get_true();
//line 155
___nl__1 = ___nl__9;
//line 155
___nl__9 = null;
//line 156
___nl__9 = new ImmString("pos ");
//line 156
___nl__10 = ((ImmHash)___nl__0).getHashValue()["pos"];
//line 156
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString());
//line 156
___nl__10 = null;
//line 156
___nl__10 = new ImmString(": expected ,");
//line 156
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString());
//line 156
___nl__10 = null;
//line 156
___nl__2 = null;
//line 156
___nl__3 = null;
//line 156
___nl__4 = null;
//line 156
___nl__5 = null;
//line 156
___nl__6 = null;
//line 156
___nl__7 = null;
//line 156
___nl__8 = null;
//line 156
___arg__0.setValue(___nl__0);___arg__1.setValue(___nl__1);if(true) return ___nl__9;
//line 156
___nl__9 = null;
//line 157
if (true) {goto label_12;}
//line 157
label_12:
//line 157
___nl__8 = null;
//line 158
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_eat_ws_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 158
___nl__6 = null;
//line 158
___nl__7 = null;
//line 159
if (true) {goto label_4;}
//line 159
label_3:
//line 159
___nl__5 = null;
//line 160
___nl__2 = null;
//line 160
___nl__3 = null;
//line 160
___arg__0.setValue(___nl__0);___arg__1.setValue(___nl__1);if(true) return ___nl__4;
//line 160
___nl__4 = null;
//line 161
if (true) {goto label_1;}
//line 161
label_2:
//line 161
___nl__3 = new ImmString("[");
//line 161
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 161
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 161
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_13;}}
//line 162
___nl__4 = new ImmDouble(1);
//line 162
___nl__5 = new ImmString("pos");
//line 162
___nl__5 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__5);

//line 162
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString())));
//line 162
___nl__6 = new ImmString("pos");
//line 162
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__6,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 162
___nl__6 = null;
//line 162
___nl__4 = null;
//line 162
___nl__5 = null;
//line 163
___nl__4 = new ImmArray(new Imm[0]);
//line 164
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_eat_ws_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 165
label_15:
//line 165
___nl__6 = new ImmString("]");
//line 165
___ref______nl__0 = new ImmRef(___nl__0);
___nl__5 = dfile_NL.NL_match_s_priv(___ref______nl__0,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

//line 165
___nl__6 = null;
//line 165
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 165
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 165
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_14;}}
//line 166
___ref______nl__0 = new ImmRef(___nl__0);
___ref______nl__1 = new ImmRef(___nl__1);
___nl__6 = dfile_NL.NL_parse_priv(___ref______nl__0,___ref______nl__1);
___nl__0 = ___ref______nl__0.getValue();
___nl__1 = ___ref______nl__1.getValue();

//line 167
___nl__7 = ___nl__1;
//line 167
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 167
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_17;}}
//line 167
___nl__2 = null;
//line 167
___nl__3 = null;
//line 167
___nl__4 = null;
//line 167
___nl__5 = null;
//line 167
___nl__7 = null;
//line 167
___arg__0.setValue(___nl__0);___arg__1.setValue(___nl__1);if(true) return ___nl__6;
//line 167
if (true) {goto label_17;}
//line 167
label_17:
//line 167
___nl__7 = null;
//line 168
___ref______nl__4 = new ImmRef(___nl__4);
array_NL.NL_push(___ref______nl__4,___nl__6);
___nl__4 = ___ref______nl__4.getValue();

//line 169
___nl__8 = new ImmString(",");
//line 169
___ref______nl__0 = new ImmRef(___nl__0);
___nl__7 = dfile_NL.NL_match_s_priv(___ref______nl__0,___nl__8);
___nl__0 = ___ref______nl__0.getValue();

//line 169
___nl__8 = null;
//line 169
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 169
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 169
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_19;}}
//line 170
___nl__8 = c_rt_lib_NL.NL_get_true();
//line 170
___nl__1 = ___nl__8;
//line 170
___nl__8 = null;
//line 171
___nl__8 = new ImmString("pos ");
//line 171
___nl__9 = ((ImmHash)___nl__0).getHashValue()["pos"];
//line 171
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 171
___nl__9 = null;
//line 171
___nl__9 = new ImmString(": expected ,");
//line 171
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 171
___nl__9 = null;
//line 171
___nl__2 = null;
//line 171
___nl__3 = null;
//line 171
___nl__4 = null;
//line 171
___nl__5 = null;
//line 171
___nl__6 = null;
//line 171
___nl__7 = null;
//line 171
___arg__0.setValue(___nl__0);___arg__1.setValue(___nl__1);if(true) return ___nl__8;
//line 171
___nl__8 = null;
//line 172
if (true) {goto label_19;}
//line 172
label_19:
//line 172
___nl__7 = null;
//line 173
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_eat_ws_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 173
___nl__6 = null;
//line 174
if (true) {goto label_15;}
//line 174
label_14:
//line 174
___nl__5 = null;
//line 175
___nl__2 = null;
//line 175
___nl__3 = null;
//line 175
___arg__0.setValue(___nl__0);___arg__1.setValue(___nl__1);if(true) return ___nl__4;
//line 175
___nl__4 = null;
//line 176
if (true) {goto label_1;}
//line 176
label_13:
//line 176
___nl__3 = new ImmString("o");
//line 176
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 176
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 176
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_21;}}
//line 176
___ref______nl__0 = new ImmRef(___nl__0);
___nl__3 = dfile_NL.NL_is_ov_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 176
label_21:
//line 176
___nl__4 = null;
//line 176
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 176
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_20;}}
//line 177
___nl__4 = new ImmDouble(7);
//line 177
___nl__5 = new ImmString("pos");
//line 177
___nl__5 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__5);

//line 177
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString())));
//line 177
___nl__6 = new ImmString("pos");
//line 177
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__6,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 177
___nl__6 = null;
//line 177
___nl__4 = null;
//line 177
___nl__5 = null;
//line 178
___ref______nl__0 = new ImmRef(___nl__0);
___ref______nl__1 = new ImmRef(___nl__1);
___nl__4 = dfile_NL.NL_parse_scalar_priv(___ref______nl__0,___ref______nl__1);
___nl__0 = ___ref______nl__0.getValue();
___nl__1 = ___ref______nl__1.getValue();

//line 179
___nl__5 = ___nl__1;
//line 179
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 179
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_23;}}
//line 179
___nl__2 = null;
//line 179
___nl__3 = null;
//line 179
___nl__5 = null;
//line 179
___arg__0.setValue(___nl__0);___arg__1.setValue(___nl__1);if(true) return ___nl__4;
//line 179
if (true) {goto label_23;}
//line 179
label_23:
//line 179
___nl__5 = null;
//line 180
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_eat_ws_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 181
___nl__6 = new ImmString(",");
//line 181
___ref______nl__0 = new ImmRef(___nl__0);
___nl__5 = dfile_NL.NL_match_s_priv(___ref______nl__0,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

//line 181
___nl__6 = null;
//line 181
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 181
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_25;}}
//line 182
___ref______nl__0 = new ImmRef(___nl__0);
___ref______nl__1 = new ImmRef(___nl__1);
___nl__6 = dfile_NL.NL_parse_priv(___ref______nl__0,___ref______nl__1);
___nl__0 = ___ref______nl__0.getValue();
___nl__1 = ___ref______nl__1.getValue();

//line 183
___nl__7 = ___nl__1;
//line 183
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 183
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_27;}}
//line 183
___nl__2 = null;
//line 183
___nl__3 = null;
//line 183
___nl__4 = null;
//line 183
___nl__5 = null;
//line 183
___nl__7 = null;
//line 183
___arg__0.setValue(___nl__0);___arg__1.setValue(___nl__1);if(true) return ___nl__6;
//line 183
if (true) {goto label_27;}
//line 183
label_27:
//line 183
___nl__7 = null;
//line 184
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_eat_ws_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 185
___nl__8 = new ImmString(")");
//line 185
___ref______nl__0 = new ImmRef(___nl__0);
___nl__7 = dfile_NL.NL_match_s_priv(___ref______nl__0,___nl__8);
___nl__0 = ___ref______nl__0.getValue();

//line 185
___nl__8 = null;
//line 185
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 185
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 185
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_29;}}
//line 186
___nl__8 = c_rt_lib_NL.NL_get_true();
//line 186
___nl__1 = ___nl__8;
//line 186
___nl__8 = null;
//line 187
___nl__8 = new ImmString("pos ");
//line 187
___nl__9 = ((ImmHash)___nl__0).getHashValue()["pos"];
//line 187
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 187
___nl__9 = null;
//line 187
___nl__9 = new ImmString(": expected )");
//line 187
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 187
___nl__9 = null;
//line 187
___nl__2 = null;
//line 187
___nl__3 = null;
//line 187
___nl__4 = null;
//line 187
___nl__5 = null;
//line 187
___nl__6 = null;
//line 187
___nl__7 = null;
//line 187
___arg__0.setValue(___nl__0);___arg__1.setValue(___nl__1);if(true) return ___nl__8;
//line 187
___nl__8 = null;
//line 188
if (true) {goto label_29;}
//line 188
label_29:
//line 188
___nl__7 = null;
//line 189
___nl__7 = ov_NL.NL_mk_val(___nl__4,___nl__6);

//line 189
___nl__2 = null;
//line 189
___nl__3 = null;
//line 189
___nl__4 = null;
//line 189
___nl__5 = null;
//line 189
___nl__6 = null;
//line 189
___arg__0.setValue(___nl__0);___arg__1.setValue(___nl__1);if(true) return ___nl__7;
//line 189
___nl__7 = null;
//line 189
___nl__6 = null;
//line 190
if (true) {goto label_25;}
//line 190
label_25:
//line 190
___nl__5 = null;
//line 191
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_eat_ws_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 192
___nl__6 = new ImmString(")");
//line 192
___ref______nl__0 = new ImmRef(___nl__0);
___nl__5 = dfile_NL.NL_match_s_priv(___ref______nl__0,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

//line 192
___nl__6 = null;
//line 192
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 192
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 192
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_31;}}
//line 193
___nl__6 = c_rt_lib_NL.NL_get_true();
//line 193
___nl__1 = ___nl__6;
//line 193
___nl__6 = null;
//line 194
___nl__6 = new ImmString("pos ");
//line 194
___nl__7 = ((ImmHash)___nl__0).getHashValue()["pos"];
//line 194
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 194
___nl__7 = null;
//line 194
___nl__7 = new ImmString(": expected )");
//line 194
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 194
___nl__7 = null;
//line 194
___nl__2 = null;
//line 194
___nl__3 = null;
//line 194
___nl__4 = null;
//line 194
___nl__5 = null;
//line 194
___arg__0.setValue(___nl__0);___arg__1.setValue(___nl__1);if(true) return ___nl__6;
//line 194
___nl__6 = null;
//line 195
if (true) {goto label_31;}
//line 195
label_31:
//line 195
___nl__5 = null;
//line 196
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_eat_ws_priv(___ref______nl__0);
___nl__0 = ___ref______nl__0.getValue();

//line 197
___nl__5 = ov_NL.NL_mk(___nl__4);

//line 197
___nl__2 = null;
//line 197
___nl__3 = null;
//line 197
___nl__4 = null;
//line 197
___arg__0.setValue(___nl__0);___arg__1.setValue(___nl__1);if(true) return ___nl__5;
//line 197
___nl__5 = null;
//line 197
___nl__4 = null;
//line 198
if (true) {goto label_1;}
//line 198
label_20:
//line 199
___ref______nl__0 = new ImmRef(___nl__0);
___ref______nl__1 = new ImmRef(___nl__1);
___nl__4 = dfile_NL.NL_parse_scalar_priv(___ref______nl__0,___ref______nl__1);
___nl__0 = ___ref______nl__0.getValue();
___nl__1 = ___ref______nl__1.getValue();

//line 199
___nl__2 = null;
//line 199
___nl__3 = null;
//line 199
___arg__0.setValue(___nl__0);___arg__1.setValue(___nl__1);if(true) return ___nl__4;
//line 199
___nl__4 = null;
//line 200
if (true) {goto label_1;}
//line 200
label_1:
//line 200
___nl__3 = null;
//line 200
___nl__2 = null;
//line 200
___arg__0.setValue(___nl__0);___arg__1.setValue(___nl__1);if(true) return null;
}

public static Imm NL_sload(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 204
___nl__3 = dfile_NL.NL_try_sload(___nl__0);

//line 204
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("ok"));
//line 204
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_1;}}
//line 204
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ensure"), ___nl__3);
//line 204
c_rt_lib_NL.NL_die();
//line 204
label_1:
//line 204
___nl__1 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("ok"));
//line 204
___nl__2 = null;
//line 204
___nl__3 = null;
//line 205
___nl__0 = null;
//line 205
if(true) return ___nl__1;
//line 205
___nl__1 = null;
//line 205
___nl__0 = null;
//line 205
if(true) return null;
}

public static Imm NL_try_sload(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
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
//line 209
___nl__2 = ptd_NL.NL_sim();

//line 209
___nl__1 = ptd_NL.NL_ensure(___nl__2,___nl__0);

//line 209
___nl__2 = null;
//line 210
___nl__3 = new ImmArray(new Imm[] {___nl__1,});
//line 210
___nl__4 = new ImmDouble(0);
//line 210
___nl__5 = string_NL.NL_length(___nl__1);

//line 210
__function_map = new Dictionary<String, Imm>();
__function_map.Add("str",___nl__3);
__function_map.Add("pos",___nl__4);
__function_map.Add("len",___nl__5);
___nl__2 = new ImmHash(__function_map);
//line 210
___nl__3 = null;
//line 210
___nl__4 = null;
//line 210
___nl__5 = null;
//line 211
___nl__3 = c_rt_lib_NL.NL_get_false();
//line 212
___nl__4 = new ImmString("use utf8;");
//line 212
___ref______nl__2 = new ImmRef(___nl__2);
dfile_NL.NL_match_s_priv(___ref______nl__2,___nl__4);
___nl__2 = ___ref______nl__2.getValue();

//line 212
___nl__4 = null;
//line 213
___ref______nl__2 = new ImmRef(___nl__2);
dfile_NL.NL_eat_ws_priv(___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue();

//line 214
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
___nl__4 = dfile_NL.NL_parse_priv(___ref______nl__2,___ref______nl__3);
___nl__2 = ___ref______nl__2.getValue();
___nl__3 = ___ref______nl__3.getValue();

//line 215
___ref______nl__2 = new ImmRef(___nl__2);
dfile_NL.NL_eat_ws_priv(___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue();

//line 216
___nl__5 = ___nl__3;
//line 216
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 216
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 216
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_3;}}
//line 216
___nl__5 = ((ImmHash)___nl__2).getHashValue()["pos"];
//line 216
___nl__7 = ((ImmHash)___nl__2).getHashValue()["len"];
//line 216
___nl__5 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString())) !=((Double.Parse(___nl__7.getValue().ToString())))  );
//line 216
___nl__7 = null;
//line 216
label_3:
//line 216
___nl__6 = null;
//line 216
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 216
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_2;}}
//line 217
___nl__6 = c_rt_lib_NL.NL_get_true();
//line 217
___nl__3 = ___nl__6;
//line 217
___nl__6 = null;
//line 218
___nl__6 = new ImmString("pos ");
//line 218
___nl__7 = ((ImmHash)___nl__2).getHashValue()["pos"];
//line 218
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 218
___nl__7 = null;
//line 218
___nl__7 = new ImmString(": expected eof");
//line 218
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 218
___nl__7 = null;
//line 218
___nl__4 = ___nl__6;
//line 218
___nl__6 = null;
//line 219
if (true) {goto label_2;}
//line 219
label_2:
//line 219
___nl__5 = null;
//line 220
___nl__5 = ___nl__3;
//line 220
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 220
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_5;}}
//line 221
___nl__7 = ptd_NL.NL_sim();

//line 221
___nl__6 = ptd_NL.NL_ensure(___nl__7,___nl__4);

//line 221
___nl__7 = null;
//line 221
___nl__4 = ___nl__6;
//line 221
___nl__6 = null;
//line 222
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("err"), ___nl__4);
//line 222
___nl__0 = null;
//line 222
___nl__1 = null;
//line 222
___nl__2 = null;
//line 222
___nl__3 = null;
//line 222
___nl__4 = null;
//line 222
___nl__5 = null;
//line 222
if(true) return ___nl__6;
//line 222
___nl__6 = null;
//line 223
if (true) {goto label_4;}
//line 223
label_5:
//line 224
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ok"), ___nl__4);
//line 224
___nl__0 = null;
//line 224
___nl__1 = null;
//line 224
___nl__2 = null;
//line 224
___nl__3 = null;
//line 224
___nl__4 = null;
//line 224
___nl__5 = null;
//line 224
if(true) return ___nl__6;
//line 224
___nl__6 = null;
//line 225
if (true) {goto label_4;}
//line 225
label_4:
//line 225
___nl__5 = null;
//line 225
___nl__1 = null;
//line 225
___nl__2 = null;
//line 225
___nl__3 = null;
//line 225
___nl__4 = null;
//line 225
___nl__0 = null;
//line 225
if(true) return null;
}

public static Imm NL_SINGLETON_state_out() {

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
//line 230
___nl__2 = ptd_NL.NL_sim();

//line 230
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("boolean_t_NL"));
__function_map.Add("name",new ImmString("type"));
___nl__4 = new ImmHash(__function_map);
//line 230
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__4);
//line 230
___nl__3 = ptd_NL.NL_hash(___nl__4);

//line 230
___nl__4 = null;
//line 230
__function_map = new Dictionary<String, Imm>();
__function_map.Add("str",___nl__2);
__function_map.Add("objects",___nl__3);
___nl__1 = new ImmHash(__function_map);
//line 230
___nl__2 = null;
//line 230
___nl__3 = null;
//line 230
___nl__0 = ptd_NL.NL_rec(___nl__1);

//line 230
___nl__1 = null;
//line 230
if(true) return ___nl__0;
//line 230
___nl__0 = null;
//line 230
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_state_out = null;
public static Imm NL_state_out() {
	if (value__singleton__NL_SINGLETON_state_out == null) {
		value__singleton__NL_SINGLETON_state_out = NL_SINGLETON_state_out();
	}
	return value__singleton__NL_SINGLETON_state_out;
}
private static Imm NL_sp_priv(ImmRef ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 236
___nl__2 = new ImmString("str");
//line 236
___nl__2 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__2);

//line 236
___nl__2 = new ImmString(___nl__2.toString() + ___nl__1.toString());
//line 236
___nl__3 = new ImmString("str");
//line 236
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__3,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 236
___nl__3 = null;
//line 236
___nl__2 = null;
//line 236
___nl__1 = null;
//line 236
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_sprintstr_priv(ImmRef ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 240
___nl__2 = new ImmString("");
//line 240
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 240
___nl__2 = null;
//line 241
___nl__3 = new ImmString("\\");
//line 241
___nl__4 = new ImmString("\\\\");
//line 241
___nl__2 = string_NL.NL_replace(___nl__1,___nl__3,___nl__4);

//line 241
___nl__4 = null;
//line 241
___nl__3 = null;
//line 241
___nl__1 = ___nl__2;
//line 241
___nl__2 = null;
//line 242
___nl__3 = new ImmString("$");
//line 242
___nl__4 = new ImmString("\\$");
//line 242
___nl__2 = string_NL.NL_replace(___nl__1,___nl__3,___nl__4);

//line 242
___nl__4 = null;
//line 242
___nl__3 = null;
//line 242
___nl__1 = ___nl__2;
//line 242
___nl__2 = null;
//line 243
___nl__3 = new ImmString("@");
//line 243
___nl__4 = new ImmString("\\@");
//line 243
___nl__2 = string_NL.NL_replace(___nl__1,___nl__3,___nl__4);

//line 243
___nl__4 = null;
//line 243
___nl__3 = null;
//line 243
___nl__1 = ___nl__2;
//line 243
___nl__2 = null;
//line 244
___nl__3 = new ImmString("\"");
//line 244
___nl__4 = new ImmString("\\\"");
//line 244
___nl__2 = string_NL.NL_replace(___nl__1,___nl__3,___nl__4);

//line 244
___nl__4 = null;
//line 244
___nl__3 = null;
//line 244
___nl__1 = ___nl__2;
//line 244
___nl__2 = null;
//line 245
___nl__2 = new ImmString("\"");
//line 245
___nl__2 = new ImmString(___nl__2.toString() + ___nl__1.toString());
//line 245
___nl__3 = new ImmString("\"");
//line 245
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 245
___nl__3 = null;
//line 245
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_sp_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 245
___nl__2 = null;
//line 245
___nl__1 = null;
//line 245
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_is_simple_string_priv(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
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
//line 249
___nl__1 = string_NL.NL_length(___nl__0);

//line 250
___nl__2 = new ImmDouble(0);
//line 250
___nl__2 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__1.getValue().ToString())) ==((Double.Parse(___nl__2.getValue().ToString())))  );
//line 250
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 250
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 250
___nl__3 = c_rt_lib_NL.NL_get_false();
//line 250
___nl__0 = null;
//line 250
___nl__1 = null;
//line 250
___nl__2 = null;
//line 250
if(true) return ___nl__3;
//line 250
___nl__3 = null;
//line 250
if (true) {goto label_2;}
//line 250
label_2:
//line 250
___nl__2 = null;
//line 251
___nl__4 = new ImmDouble(0);
//line 251
___nl__5 = new ImmDouble(1);
//line 251
___nl__3 = string_NL.NL_substr(___nl__0,___nl__4,___nl__5);

//line 251
___nl__5 = null;
//line 251
___nl__4 = null;
//line 251
___nl__2 = string_NL.NL_is_letter(___nl__3);

//line 251
___nl__3 = null;
//line 251
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_5;}}
//line 251
___nl__3 = new ImmDouble(0);
//line 251
___nl__4 = new ImmDouble(1);
//line 251
___nl__2 = string_NL.NL_substr(___nl__0,___nl__3,___nl__4);

//line 251
___nl__4 = null;
//line 251
___nl__3 = null;
//line 251
___nl__3 = new ImmString("_");
//line 251
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 251
___nl__3 = null;
//line 251
label_5:
//line 251
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 251
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 251
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_4;}}
//line 251
___nl__3 = c_rt_lib_NL.NL_get_false();
//line 251
___nl__0 = null;
//line 251
___nl__1 = null;
//line 251
___nl__2 = null;
//line 251
if(true) return ___nl__3;
//line 251
___nl__3 = null;
//line 251
if (true) {goto label_4;}
//line 251
label_4:
//line 251
___nl__2 = null;
//line 252
___nl__2 = new ImmDouble(0);
//line 252
___nl__3 = new ImmDouble(1);
//line 252
label_8:
//line 252
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__2.getValue().ToString()))>=(Double.Parse(___nl__1.getValue().ToString())) );
//line 252
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_6;}}
//line 253
___nl__6 = new ImmDouble(1);
//line 253
___nl__5 = string_NL.NL_substr(___nl__0,___nl__2,___nl__6);

//line 253
___nl__6 = null;
//line 254
___nl__6 = string_NL.NL_is_letter(___nl__5);

//line 254
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_12;}}
//line 254
___nl__6 = string_NL.NL_is_digit(___nl__5);

//line 254
label_12:
//line 254
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_11;}}
//line 254
___nl__6 = new ImmString("_");
//line 254
___nl__6 = c_rt_lib_NL.NL_native_to_nl(___nl__5.toString().Equals(___nl__6.toString()));
//line 254
label_11:
//line 254
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 254
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6));
//line 254
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_10;}}
//line 254
___nl__7 = c_rt_lib_NL.NL_get_false();
//line 254
___nl__0 = null;
//line 254
___nl__1 = null;
//line 254
___nl__2 = null;
//line 254
___nl__3 = null;
//line 254
___nl__4 = null;
//line 254
___nl__5 = null;
//line 254
___nl__6 = null;
//line 254
if(true) return ___nl__7;
//line 254
___nl__7 = null;
//line 254
if (true) {goto label_10;}
//line 254
label_10:
//line 254
___nl__6 = null;
//line 254
___nl__5 = null;
//line 255
___nl__2 = new ImmDouble((Double.Parse(___nl__2.getValue().ToString()))+(Double.Parse(___nl__3.getValue().ToString())));
//line 255
if (true) {goto label_8;}
//line 255
label_6:
//line 255
___nl__2 = null;
//line 255
___nl__3 = null;
//line 255
___nl__4 = null;
//line 256
___nl__2 = c_rt_lib_NL.NL_get_true();
//line 256
___nl__0 = null;
//line 256
___nl__1 = null;
//line 256
if(true) return ___nl__2;
//line 256
___nl__2 = null;
//line 256
___nl__1 = null;
//line 256
___nl__0 = null;
//line 256
if(true) return null;
}

private static Imm NL_sprint_hash_key_priv(ImmRef ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.clone();
Imm ___nl__2 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 260
___nl__2 = dfile_NL.NL_is_simple_string_priv(___nl__1);

//line 260
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 260
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 261
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_sp_priv(___ref______nl__0,___nl__1);
___nl__0 = ___ref______nl__0.getValue();

//line 262
if (true) {goto label_1;}
//line 262
label_2:
//line 263
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_sprintstr_priv(___ref______nl__0,___nl__1);
___nl__0 = ___ref______nl__0.getValue();

//line 264
if (true) {goto label_1;}
//line 264
label_1:
//line 264
___nl__2 = null;
//line 264
___nl__1 = null;
//line 264
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_get_ind_priv(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 268
___nl__2 = string_NL.NL_tab();

//line 268
___nl__1 = string_NL.NL_char_times(___nl__2,___nl__0);

//line 268
___nl__2 = null;
//line 268
___nl__0 = null;
//line 268
if(true) return ___nl__1;
//line 268
___nl__1 = null;
//line 268
___nl__0 = null;
//line 268
if(true) return null;
}

private static Imm NL_sprint_hash_priv(ImmRef ___arg__0, Imm ___arg__1, Imm ___arg__2, Imm ___arg__3) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();Imm ___nl__3 = ___arg__3.clone();
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
Imm ___nl__9 = null;
Imm ___nl__10 = null;
Imm ___nl__11 = null;
Imm ___nl__12 = null;
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
Dictionary<String, Imm> __function_map;
//line 273
___nl__4 = new ImmString("{");
//line 273
___nl__5 = string_NL.NL_lf();

//line 273
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 273
___nl__5 = null;
//line 273
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_sp_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 273
___nl__4 = null;
//line 274
___nl__4 = hash_NL.NL_keys(___nl__1);

//line 275
___ref______nl__4 = new ImmRef(___nl__4);
array_NL.NL_sort(___ref______nl__4);
___nl__4 = ___ref______nl__4.getValue();

//line 276
___nl__6 = new ImmDouble(0);
//line 276
___nl__7 = new ImmDouble(1);
//line 276
___nl__8 = c_rt_lib_NL.NL_array_len(___nl__4);

//line 276
label_3:
//line 276
___nl__9 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__6.getValue().ToString()))>=(Double.Parse(___nl__8.getValue().ToString())) );
//line 276
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_1;}}
//line 276
___nl__5 = (___nl__4 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()];
//line 277
___nl__10 = hash_NL.NL_get_value(___nl__1,___nl__5);

//line 278
___nl__12 = new ImmDouble(1);
//line 278
___nl__12 = new ImmDouble((Double.Parse(___nl__2.getValue().ToString()))+(Double.Parse(___nl__12.getValue().ToString())));
//line 278
___nl__11 = dfile_NL.NL_get_ind_priv(___nl__12);

//line 278
___nl__12 = null;
//line 278
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_sp_priv(___ref______nl__0,___nl__11);
___nl__0 = ___ref______nl__0.getValue();

//line 278
___nl__11 = null;
//line 279
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_sprint_hash_key_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 280
___nl__11 = new ImmString(" => ");
//line 280
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_sp_priv(___ref______nl__0,___nl__11);
___nl__0 = ___ref______nl__0.getValue();

//line 280
___nl__11 = null;
//line 281
___nl__11 = new ImmDouble(1);
//line 281
___nl__11 = new ImmDouble((Double.Parse(___nl__2.getValue().ToString()))+(Double.Parse(___nl__11.getValue().ToString())));
//line 281
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_sprint_priv(___ref______nl__0,___nl__10,___nl__11,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 281
___nl__11 = null;
//line 282
___nl__11 = new ImmString(",");
//line 282
___nl__12 = string_NL.NL_lf();

//line 282
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString());
//line 282
___nl__12 = null;
//line 282
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_sp_priv(___ref______nl__0,___nl__11);
___nl__0 = ___ref______nl__0.getValue();

//line 282
___nl__11 = null;
//line 282
___nl__10 = null;
//line 283
___nl__6 = new ImmDouble((Double.Parse(___nl__6.getValue().ToString()))+(Double.Parse(___nl__7.getValue().ToString())));
//line 283
if (true) {goto label_3;}
//line 283
label_1:
//line 283
___nl__5 = null;
//line 283
___nl__6 = null;
//line 283
___nl__7 = null;
//line 283
___nl__8 = null;
//line 283
___nl__9 = null;
//line 284
___nl__5 = dfile_NL.NL_get_ind_priv(___nl__2);

//line 284
___nl__6 = new ImmString("}");
//line 284
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 284
___nl__6 = null;
//line 284
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_sp_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 284
___nl__5 = null;
//line 284
___nl__4 = null;
//line 284
___nl__1 = null;
//line 284
___nl__2 = null;
//line 284
___nl__3 = null;
//line 284
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_handle_debug_priv(ImmRef ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 288
___nl__2 = nl_NL.NL_is_hash(___nl__1);

//line 288
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_4;}}
//line 288
___nl__2 = nl_NL.NL_is_array(___nl__1);

//line 288
label_4:
//line 288
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 288
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 288
___nl__4 = ((ImmHash)___nl__0).getHashValue()["objects"];
//line 288
___nl__2 = hash_NL.NL_has_key(___nl__4,___nl__1);

//line 288
___nl__4 = null;
//line 288
label_3:
//line 288
___nl__3 = null;
//line 288
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 288
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 289
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_sp_priv(___ref______nl__0,___nl__1);
___nl__0 = ___ref______nl__0.getValue();

//line 290
___nl__3 = c_rt_lib_NL.NL_get_true();
//line 290
___nl__1 = null;
//line 290
___nl__2 = null;
//line 290
___arg__0.setValue(___nl__0);if(true) return ___nl__3;
//line 290
___nl__3 = null;
//line 291
if (true) {goto label_1;}
//line 291
label_2:
//line 292
___nl__3 = new ImmString("objects");
//line 292
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__3);

//line 292
___nl__4 = c_rt_lib_NL.NL_get_true();
//line 292
___ref______nl__3 = new ImmRef(___nl__3);
hash_NL.NL_set_value(___ref______nl__3,___nl__1,___nl__4);
___nl__3 = ___ref______nl__3.getValue();

//line 292
___nl__4 = null;
//line 292
___nl__4 = new ImmString("objects");
//line 292
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__4,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 292
___nl__4 = null;
//line 292
___nl__3 = null;
//line 293
___nl__3 = c_rt_lib_NL.NL_get_false();
//line 293
___nl__1 = null;
//line 293
___nl__2 = null;
//line 293
___arg__0.setValue(___nl__0);if(true) return ___nl__3;
//line 293
___nl__3 = null;
//line 294
if (true) {goto label_1;}
//line 294
label_1:
//line 294
___nl__2 = null;
//line 294
___nl__1 = null;
//line 294
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_sprint_priv(ImmRef ___arg__0, Imm ___arg__1, Imm ___arg__2, Imm ___arg__3) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();Imm ___nl__3 = ___arg__3.clone();
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
//line 298
___nl__4 = ___nl__3;
//line 298
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 298
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_3;}}
//line 298
___ref______nl__0 = new ImmRef(___nl__0);
___nl__4 = dfile_NL.NL_handle_debug_priv(___ref______nl__0,___nl__1);
___nl__0 = ___ref______nl__0.getValue();

//line 298
label_3:
//line 298
___nl__5 = null;
//line 298
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 298
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 298
___nl__1 = null;
//line 298
___nl__2 = null;
//line 298
___nl__3 = null;
//line 298
___nl__4 = null;
//line 298
___arg__0.setValue(___nl__0);if(true) return null;
//line 298
if (true) {goto label_2;}
//line 298
label_2:
//line 298
___nl__4 = null;
//line 299
___nl__4 = nl_NL.NL_is_sim(___nl__1);

//line 299
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 299
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_5;}}
//line 300
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_sprintstr_priv(___ref______nl__0,___nl__1);
___nl__0 = ___ref______nl__0.getValue();

//line 301
if (true) {goto label_4;}
//line 301
label_5:
//line 301
___nl__4 = nl_NL.NL_is_array(___nl__1);

//line 301
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 301
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_6;}}
//line 302
___nl__5 = new ImmString("[");
//line 302
___nl__6 = string_NL.NL_lf();

//line 302
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 302
___nl__6 = null;
//line 302
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_sp_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 302
___nl__5 = null;
//line 303
___nl__6 = new ImmDouble(0);
//line 303
___nl__7 = new ImmDouble(1);
//line 303
___nl__8 = c_rt_lib_NL.NL_array_len(___nl__1);

//line 303
label_9:
//line 303
___nl__9 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__6.getValue().ToString()))>=(Double.Parse(___nl__8.getValue().ToString())) );
//line 303
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_7;}}
//line 303
___nl__5 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()];
//line 304
___nl__11 = new ImmDouble(1);
//line 304
___nl__11 = new ImmDouble((Double.Parse(___nl__2.getValue().ToString()))+(Double.Parse(___nl__11.getValue().ToString())));
//line 304
___nl__10 = dfile_NL.NL_get_ind_priv(___nl__11);

//line 304
___nl__11 = null;
//line 304
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_sp_priv(___ref______nl__0,___nl__10);
___nl__0 = ___ref______nl__0.getValue();

//line 304
___nl__10 = null;
//line 305
___nl__10 = new ImmDouble(1);
//line 305
___nl__10 = new ImmDouble((Double.Parse(___nl__2.getValue().ToString()))+(Double.Parse(___nl__10.getValue().ToString())));
//line 305
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_sprint_priv(___ref______nl__0,___nl__5,___nl__10,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 305
___nl__10 = null;
//line 306
___nl__10 = new ImmString(",");
//line 306
___nl__11 = string_NL.NL_lf();

//line 306
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString());
//line 306
___nl__11 = null;
//line 306
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_sp_priv(___ref______nl__0,___nl__10);
___nl__0 = ___ref______nl__0.getValue();

//line 306
___nl__10 = null;
//line 307
___nl__6 = new ImmDouble((Double.Parse(___nl__6.getValue().ToString()))+(Double.Parse(___nl__7.getValue().ToString())));
//line 307
if (true) {goto label_9;}
//line 307
label_7:
//line 307
___nl__5 = null;
//line 307
___nl__6 = null;
//line 307
___nl__7 = null;
//line 307
___nl__8 = null;
//line 307
___nl__9 = null;
//line 308
___nl__5 = dfile_NL.NL_get_ind_priv(___nl__2);

//line 308
___nl__6 = new ImmString("]");
//line 308
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 308
___nl__6 = null;
//line 308
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_sp_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 308
___nl__5 = null;
//line 309
if (true) {goto label_4;}
//line 309
label_6:
//line 309
___nl__4 = nl_NL.NL_is_hash(___nl__1);

//line 309
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 309
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_10;}}
//line 310
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_sprint_hash_priv(___ref______nl__0,___nl__1,___nl__2,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 311
if (true) {goto label_4;}
//line 311
label_10:
//line 311
___nl__4 = nl_NL.NL_is_variant(___nl__1);

//line 311
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 311
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_11;}}
//line 312
___nl__5 = new ImmString("ov::mk(");
//line 312
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_sp_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 312
___nl__5 = null;
//line 313
___nl__5 = ov_NL.NL_get_element(___nl__1);

//line 313
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_sprintstr_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 313
___nl__5 = null;
//line 314
___nl__5 = ov_NL.NL_has_value(___nl__1);

//line 314
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 314
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_13;}}
//line 315
___nl__6 = new ImmString(", ");
//line 315
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_sp_priv(___ref______nl__0,___nl__6);
___nl__0 = ___ref______nl__0.getValue();

//line 315
___nl__6 = null;
//line 316
___nl__6 = ov_NL.NL_get_value(___nl__1);

//line 316
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_sprint_priv(___ref______nl__0,___nl__6,___nl__2,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 316
___nl__6 = null;
//line 317
if (true) {goto label_13;}
//line 317
label_13:
//line 317
___nl__5 = null;
//line 318
___nl__5 = new ImmString(")");
//line 318
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_sp_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 318
___nl__5 = null;
//line 319
if (true) {goto label_4;}
//line 319
label_11:
//line 320
___nl__5 = new ImmArray(new Imm[0]);
//line 320
c_rt_lib_NL.NL_die();
//line 320
___nl__5 = null;
//line 321
if (true) {goto label_4;}
//line 321
label_4:
//line 321
___nl__4 = null;
//line 321
___nl__1 = null;
//line 321
___nl__2 = null;
//line 321
___nl__3 = null;
//line 321
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_print_net_formatstr_priv(ImmRef ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 325
___nl__2 = new ImmString("");
//line 325
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 325
___nl__2 = null;
//line 326
___nl__3 = new ImmString("\\");
//line 326
___nl__4 = new ImmString("\\\\");
//line 326
___nl__2 = string_NL.NL_replace(___nl__1,___nl__3,___nl__4);

//line 326
___nl__4 = null;
//line 326
___nl__3 = null;
//line 326
___nl__1 = ___nl__2;
//line 326
___nl__2 = null;
//line 327
___nl__3 = string_NL.NL_lf();

//line 327
___nl__4 = new ImmString("\\n");
//line 327
___nl__2 = string_NL.NL_replace(___nl__1,___nl__3,___nl__4);

//line 327
___nl__4 = null;
//line 327
___nl__3 = null;
//line 327
___nl__1 = ___nl__2;
//line 327
___nl__2 = null;
//line 328
___nl__3 = new ImmString("$");
//line 328
___nl__4 = new ImmString("\\$");
//line 328
___nl__2 = string_NL.NL_replace(___nl__1,___nl__3,___nl__4);

//line 328
___nl__4 = null;
//line 328
___nl__3 = null;
//line 328
___nl__1 = ___nl__2;
//line 328
___nl__2 = null;
//line 329
___nl__3 = new ImmString("@");
//line 329
___nl__4 = new ImmString("\\@");
//line 329
___nl__2 = string_NL.NL_replace(___nl__1,___nl__3,___nl__4);

//line 329
___nl__4 = null;
//line 329
___nl__3 = null;
//line 329
___nl__1 = ___nl__2;
//line 329
___nl__2 = null;
//line 330
___nl__3 = new ImmString("\"");
//line 330
___nl__4 = new ImmString("\\\"");
//line 330
___nl__2 = string_NL.NL_replace(___nl__1,___nl__3,___nl__4);

//line 330
___nl__4 = null;
//line 330
___nl__3 = null;
//line 330
___nl__1 = ___nl__2;
//line 330
___nl__2 = null;
//line 331
___nl__2 = new ImmString("\"");
//line 331
___nl__2 = new ImmString(___nl__2.toString() + ___nl__1.toString());
//line 331
___nl__3 = new ImmString("\"");
//line 331
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 331
___nl__3 = null;
//line 331
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_sp_priv(___ref______nl__0,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 331
___nl__2 = null;
//line 331
___nl__1 = null;
//line 331
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_print_net_format_priv(ImmRef ___arg__0, Imm ___arg__1) {
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
//line 336
___nl__2 = nl_NL.NL_is_sim(___nl__1);

//line 336
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 336
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 337
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_print_net_formatstr_priv(___ref______nl__0,___nl__1);
___nl__0 = ___ref______nl__0.getValue();

//line 338
if (true) {goto label_1;}
//line 338
label_2:
//line 338
___nl__2 = nl_NL.NL_is_array(___nl__1);

//line 338
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 338
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_3;}}
//line 339
___nl__3 = new ImmString("[");
//line 339
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_sp_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 339
___nl__3 = null;
//line 340
___nl__4 = new ImmDouble(0);
//line 340
___nl__5 = new ImmDouble(1);
//line 340
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__1);

//line 340
label_6:
//line 340
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) );
//line 340
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_4;}}
//line 340
___nl__3 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()];
//line 341
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_print_net_format_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 342
___nl__8 = new ImmString(",");
//line 342
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_sp_priv(___ref______nl__0,___nl__8);
___nl__0 = ___ref______nl__0.getValue();

//line 342
___nl__8 = null;
//line 343
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString())));
//line 343
if (true) {goto label_6;}
//line 343
label_4:
//line 343
___nl__3 = null;
//line 343
___nl__4 = null;
//line 343
___nl__5 = null;
//line 343
___nl__6 = null;
//line 343
___nl__7 = null;
//line 344
___nl__3 = new ImmString("]");
//line 344
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_sp_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 344
___nl__3 = null;
//line 345
if (true) {goto label_1;}
//line 345
label_3:
//line 345
___nl__2 = nl_NL.NL_is_hash(___nl__1);

//line 345
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 345
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_7;}}
//line 346
___nl__3 = new ImmString("{");
//line 346
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_sp_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 346
___nl__3 = null;
//line 347
___nl__3 = hash_NL.NL_keys(___nl__1);

//line 347
___nl__5 = new ImmDouble(0);
//line 347
___nl__6 = new ImmDouble(1);
//line 347
___nl__7 = c_rt_lib_NL.NL_array_len(___nl__3);

//line 347
label_10:
//line 347
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) );
//line 347
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_8;}}
//line 347
___nl__4 = (___nl__3 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()];
//line 348
___nl__9 = hash_NL.NL_get_value(___nl__1,___nl__4);

//line 349
___nl__11 = new ImmString("");
//line 349
___nl__11 = new ImmString(___nl__4.toString() + ___nl__11.toString());
//line 349
___nl__10 = dfile_NL.NL_is_simple_string_priv(___nl__11);

//line 349
___nl__11 = null;
//line 349
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10));
//line 349
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_12;}}
//line 350
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_sp_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 351
if (true) {goto label_11;}
//line 351
label_12:
//line 352
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_print_net_formatstr_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 353
if (true) {goto label_11;}
//line 353
label_11:
//line 353
___nl__10 = null;
//line 354
___nl__10 = new ImmString("=>");
//line 354
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_sp_priv(___ref______nl__0,___nl__10);
___nl__0 = ___ref______nl__0.getValue();

//line 354
___nl__10 = null;
//line 355
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_print_net_format_priv(___ref______nl__0,___nl__9);
___nl__0 = ___ref______nl__0.getValue();

//line 356
___nl__10 = new ImmString(",");
//line 356
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_sp_priv(___ref______nl__0,___nl__10);
___nl__0 = ___ref______nl__0.getValue();

//line 356
___nl__10 = null;
//line 356
___nl__9 = null;
//line 357
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString())));
//line 357
if (true) {goto label_10;}
//line 357
label_8:
//line 357
___nl__3 = null;
//line 357
___nl__4 = null;
//line 357
___nl__5 = null;
//line 357
___nl__6 = null;
//line 357
___nl__7 = null;
//line 357
___nl__8 = null;
//line 358
___nl__3 = new ImmString("}");
//line 358
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_sp_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 358
___nl__3 = null;
//line 359
if (true) {goto label_1;}
//line 359
label_7:
//line 359
___nl__2 = nl_NL.NL_is_variant(___nl__1);

//line 359
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 359
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_13;}}
//line 360
___nl__3 = new ImmString("ov::mk(");
//line 360
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_sp_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 360
___nl__3 = null;
//line 361
___nl__3 = ov_NL.NL_get_element(___nl__1);

//line 361
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_print_net_formatstr_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 361
___nl__3 = null;
//line 362
___nl__3 = ov_NL.NL_has_value(___nl__1);

//line 362
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 362
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_15;}}
//line 363
___nl__4 = new ImmString(",");
//line 363
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_sp_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 363
___nl__4 = null;
//line 364
___nl__4 = ov_NL.NL_get_value(___nl__1);

//line 364
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_print_net_format_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue();

//line 364
___nl__4 = null;
//line 365
if (true) {goto label_15;}
//line 365
label_15:
//line 365
___nl__3 = null;
//line 366
___nl__3 = new ImmString(")");
//line 366
___ref______nl__0 = new ImmRef(___nl__0);
dfile_NL.NL_sp_priv(___ref______nl__0,___nl__3);
___nl__0 = ___ref______nl__0.getValue();

//line 366
___nl__3 = null;
//line 367
if (true) {goto label_1;}
//line 367
label_13:
//line 368
___nl__3 = new ImmArray(new Imm[] {___nl__1,});
//line 368
c_rt_lib_NL.NL_die();
//line 368
___nl__3 = null;
//line 369
if (true) {goto label_1;}
//line 369
label_1:
//line 369
___nl__2 = null;
//line 369
___nl__1 = null;
//line 369
___arg__0.setValue(___nl__0);if(true) return null;
}

}
}