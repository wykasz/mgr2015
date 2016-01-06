using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class generator_cs_NL {

public static Imm NL_generate(Imm ___arg__0) {
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
//line 16
___nl__1 = new ImmString("");
//line 17
___nl__2 = generator_cs_NL.NL_print_imports_priv(___nl__0);

//line 17
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 17
___nl__2 = null;
//line 18
___nl__3 = ((ImmHash)___nl__0).getHashValue()["module_name"];
//line 18
___nl__2 = generator_cs_NL.NL_print_class_begin_priv(___nl__3);

//line 18
___nl__3 = null;
//line 18
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 18
___nl__2 = null;
//line 19
___nl__2 = ((ImmHash)___nl__0).getHashValue()["functions"];
//line 19
___nl__4 = new ImmDouble(0);
//line 19
___nl__5 = new ImmDouble(1);
//line 19
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__2);

//line 19
label_3:
//line 19
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) );
//line 19
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_1;}}
//line 19
___nl__3 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()];
//line 19
___nl__9 = ((ImmHash)___nl__0).getHashValue()["module_name"];
//line 19
___nl__8 = generator_cs_NL.NL_print_function_or_singleton_priv(___nl__3,___nl__9);

//line 19
___nl__9 = null;
//line 19
___nl__1 = new ImmString(___nl__1.toString() + ___nl__8.toString());
//line 19
___nl__8 = null;
//line 19
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString())));
//line 19
if (true) {goto label_3;}
//line 19
label_1:
//line 19
___nl__2 = null;
//line 19
___nl__3 = null;
//line 19
___nl__4 = null;
//line 19
___nl__5 = null;
//line 19
___nl__6 = null;
//line 19
___nl__7 = null;
//line 20
___nl__2 = generator_cs_NL.NL_print_class_end_priv();

//line 20
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 20
___nl__2 = null;
//line 21
___nl__0 = null;
//line 21
if(true) return ___nl__1;
//line 21
___nl__1 = null;
//line 21
___nl__0 = null;
//line 21
if(true) return null;
}

private static Imm NL_print_imports_priv(Imm ___arg__0) {
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
___nl__1 = new ImmString("");
//line 27
___nl__2 = new ImmString("using System;");
//line 27
___nl__3 = string_NL.NL_lf();

//line 27
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 27
___nl__3 = null;
//line 27
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 27
___nl__2 = null;
//line 28
___nl__2 = new ImmString("using System.Collections.Generic;");
//line 28
___nl__3 = string_NL.NL_lf();

//line 28
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 28
___nl__3 = null;
//line 28
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 28
___nl__2 = null;
//line 29
___nl__2 = new ImmString("using nianio;");
//line 29
___nl__3 = string_NL.NL_lf();

//line 29
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 29
___nl__3 = null;
//line 29
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 29
___nl__2 = null;
//line 33
___nl__0 = null;
//line 33
if(true) return ___nl__1;
//line 33
___nl__1 = null;
//line 33
___nl__0 = null;
//line 33
if(true) return null;
}

private static Imm NL_get_class_name_priv(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 37
___nl__1 = new ImmString("_NL");
//line 37
___nl__1 = new ImmString(___nl__0.toString() + ___nl__1.toString());
//line 37
___nl__0 = null;
//line 37
if(true) return ___nl__1;
//line 37
___nl__1 = null;
//line 37
___nl__0 = null;
//line 37
if(true) return null;
}

private static Imm NL_print_class_begin_priv(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 41
___nl__1 = new ImmString("namespace nianio { ");
//line 41
___nl__2 = string_NL.NL_lf();

//line 41
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 41
___nl__2 = null;
//line 42
___nl__2 = new ImmString("public class ");
//line 42
___nl__3 = generator_cs_NL.NL_get_class_name_priv(___nl__0);

//line 42
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 42
___nl__3 = null;
//line 42
___nl__3 = new ImmString(" {");
//line 42
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 42
___nl__3 = null;
//line 42
___nl__3 = string_NL.NL_lf();

//line 42
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 42
___nl__3 = null;
//line 42
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 42
___nl__2 = null;
//line 43
___nl__0 = null;
//line 43
if(true) return ___nl__1;
//line 43
___nl__1 = null;
//line 43
___nl__0 = null;
//line 43
if(true) return null;
}

private static Imm NL_SINGLETON_print_class_end_priv() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 47
___nl__0 = string_NL.NL_lf();

//line 47
___nl__1 = new ImmString("}");
//line 47
___nl__0 = new ImmString(___nl__0.toString() + ___nl__1.toString());
//line 47
___nl__1 = null;
//line 48
___nl__1 = string_NL.NL_lf();

//line 48
___nl__2 = new ImmString("}");
//line 48
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 48
___nl__2 = null;
//line 48
___nl__0 = new ImmString(___nl__0.toString() + ___nl__1.toString());
//line 48
___nl__1 = null;
//line 49
if(true) return ___nl__0;
//line 49
___nl__0 = null;
//line 49
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_print_class_end_priv = null;
private static Imm NL_print_class_end_priv() {
	if (value__singleton__NL_SINGLETON_print_class_end_priv == null) {
		value__singleton__NL_SINGLETON_print_class_end_priv = NL_SINGLETON_print_class_end_priv();
	}
	return value__singleton__NL_SINGLETON_print_class_end_priv;
}
private static Imm NL_get_function_name_priv(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
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
//line 53
___nl__1 = new ImmString("");
//line 54
___nl__2 = ((ImmHash)___nl__0).getHashValue()["access"];
//line 54
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("pub"));
//line 54
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 55
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("priv"));
//line 55
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 55
___nl__3 = new ImmString("NOMATCHALERT");
//line 55
___nl__3 = new ImmArray(new Imm[] {___nl__3,___nl__2,});
//line 55
c_rt_lib_NL.NL_die();
//line 54
label_2:
//line 55
if (true) {goto label_1;}
//line 55
label_3:
//line 56
___nl__4 = new ImmString("_priv");
//line 56
___nl__1 = ___nl__4;
//line 56
___nl__4 = null;
//line 57
if (true) {goto label_1;}
//line 57
label_1:
//line 57
___nl__2 = null;
//line 57
___nl__3 = null;
//line 58
___nl__2 = new ImmString("NL_");
//line 58
___nl__3 = ((ImmHash)___nl__0).getHashValue()["name"];
//line 58
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 58
___nl__3 = null;
//line 58
___nl__2 = new ImmString(___nl__2.toString() + ___nl__1.toString());
//line 58
___nl__0 = null;
//line 58
___nl__1 = null;
//line 58
if(true) return ___nl__2;
//line 58
___nl__2 = null;
//line 58
___nl__1 = null;
//line 58
___nl__0 = null;
//line 58
if(true) return null;
}

private static Imm NL_get_function_declaration_priv(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
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
//line 62
___nl__1 = new ImmString("");
//line 63
___nl__2 = ((ImmHash)___nl__0).getHashValue()["access"];
//line 63
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("pub"));
//line 63
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 65
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("priv"));
//line 65
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 65
___nl__3 = new ImmString("NOMATCHALERT");
//line 65
___nl__3 = new ImmArray(new Imm[] {___nl__3,___nl__2,});
//line 65
c_rt_lib_NL.NL_die();
//line 63
label_2:
//line 64
___nl__4 = new ImmString("public");
//line 64
___nl__1 = ___nl__4;
//line 64
___nl__4 = null;
//line 65
if (true) {goto label_1;}
//line 65
label_3:
//line 66
___nl__4 = new ImmString("private");
//line 66
___nl__1 = ___nl__4;
//line 66
___nl__4 = null;
//line 67
if (true) {goto label_1;}
//line 67
label_1:
//line 67
___nl__2 = null;
//line 67
___nl__3 = null;
//line 68
___nl__2 = new ImmString(" static Imm ");
//line 68
___nl__2 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 68
___nl__3 = generator_cs_NL.NL_get_function_name_priv(___nl__0);

//line 68
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 68
___nl__3 = null;
//line 68
___nl__0 = null;
//line 68
___nl__1 = null;
//line 68
if(true) return ___nl__2;
//line 68
___nl__2 = null;
//line 68
___nl__1 = null;
//line 68
___nl__0 = null;
//line 68
if(true) return null;
}

private static Imm NL_escape_string_priv(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 72
___nl__2 = new ImmString("\\");
//line 72
___nl__3 = new ImmString("\\\\");
//line 72
___nl__1 = string_NL.NL_replace(___nl__0,___nl__2,___nl__3);

//line 72
___nl__3 = null;
//line 72
___nl__2 = null;
//line 72
___nl__0 = ___nl__1;
//line 72
___nl__1 = null;
//line 73
___nl__2 = new ImmString("\"");
//line 73
___nl__3 = new ImmString("\\\"");
//line 73
___nl__1 = string_NL.NL_replace(___nl__0,___nl__2,___nl__3);

//line 73
___nl__3 = null;
//line 73
___nl__2 = null;
//line 73
___nl__0 = ___nl__1;
//line 73
___nl__1 = null;
//line 74
___nl__3 = new ImmDouble(13);
//line 74
___nl__2 = string_NL.NL_chr(___nl__3);

//line 74
___nl__3 = null;
//line 74
___nl__3 = string_NL.NL_lf();

//line 74
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 74
___nl__3 = null;
//line 74
___nl__3 = new ImmString("\\r\\n");
//line 74
___nl__1 = string_NL.NL_replace(___nl__0,___nl__2,___nl__3);

//line 74
___nl__3 = null;
//line 74
___nl__2 = null;
//line 74
___nl__0 = ___nl__1;
//line 74
___nl__1 = null;
//line 75
___nl__2 = string_NL.NL_lf();

//line 75
___nl__3 = new ImmString("\\n");
//line 75
___nl__1 = string_NL.NL_replace(___nl__0,___nl__2,___nl__3);

//line 75
___nl__3 = null;
//line 75
___nl__2 = null;
//line 75
___nl__0 = null;
//line 75
if(true) return ___nl__1;
//line 75
___nl__1 = null;
//line 75
___nl__0 = null;
//line 75
if(true) return null;
}

private static Imm NL_is_singleton_use_function_priv(Imm ___arg__0) {
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
Dictionary<String, Imm> __function_map;
//line 78
___nl__2 = ((ImmHash)___nl__0).getHashValue()["args_type"];
//line 78
___nl__1 = array_NL.NL_len(___nl__2);

//line 78
___nl__2 = null;
//line 78
___nl__2 = new ImmDouble(0);
//line 78
___nl__1 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__1.getValue().ToString()))>(Double.Parse(___nl__2.getValue().ToString())) );
//line 78
___nl__2 = null;
//line 78
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1));
//line 78
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_2;}}
//line 78
___nl__2 = c_rt_lib_NL.NL_get_false();
//line 78
___nl__0 = null;
//line 78
___nl__1 = null;
//line 78
if(true) return ___nl__2;
//line 78
___nl__2 = null;
//line 78
if (true) {goto label_2;}
//line 78
label_2:
//line 78
___nl__1 = null;
//line 79
___nl__1 = ((ImmHash)___nl__0).getHashValue()["annotation"];
//line 79
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("math"));
//line 79
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1));
//line 79
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_4;}}
//line 79
___nl__2 = c_rt_lib_NL.NL_get_true();
//line 79
___nl__0 = null;
//line 79
___nl__1 = null;
//line 79
if(true) return ___nl__2;
//line 79
___nl__2 = null;
//line 79
if (true) {goto label_4;}
//line 79
label_4:
//line 79
___nl__1 = null;
//line 80
___nl__1 = c_rt_lib_NL.NL_get_false();
//line 82
___nl__3 = ((ImmHash)___nl__0).getHashValue()["commands"];
//line 82
___nl__5 = new ImmDouble(0);
//line 82
___nl__6 = new ImmDouble(1);
//line 82
___nl__7 = c_rt_lib_NL.NL_array_len(___nl__3);

//line 82
label_7:
//line 82
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) );
//line 82
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_5;}}
//line 82
___nl__4 = (___nl__3 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()];
//line 83
___nl__9 = ((ImmHash)___nl__4).getHashValue()["cmd"];
//line 84
___nl__10 = ___nl__9;
//line 84
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__10, new ImmString("call"));
//line 84
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10));
//line 84
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_9;}}
//line 85
___nl__11 = ___nl__9;
//line 85
___nl__11 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("call"));
//line 86
___nl__12 = ((ImmHash)___nl__11).getHashValue()["fun_name"];
//line 86
___nl__13 = new ImmString("sigleton_do_not_use_without_approval");
//line 86
___nl__12 = c_rt_lib_NL.NL_native_to_nl(___nl__12.toString().Equals(___nl__13.toString()));
//line 86
___nl__13 = null;
//line 86
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12));
//line 86
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12));
//line 86
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_11;}}
//line 86
___nl__9 = null;
//line 86
___nl__10 = null;
//line 86
___nl__11 = null;
//line 86
___nl__12 = null;
//line 86
if (true) {goto label_6;}
//line 86
if (true) {goto label_11;}
//line 86
label_11:
//line 86
___nl__12 = null;
//line 87
___nl__12 = ((ImmHash)___nl__11).getHashValue()["mod"];
//line 87
___nl__13 = new ImmString("singleton");
//line 87
___nl__12 = c_rt_lib_NL.NL_native_to_nl(___nl__12.toString().Equals(___nl__13.toString()));
//line 87
___nl__13 = null;
//line 87
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12));
//line 87
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12));
//line 87
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_13;}}
//line 87
___nl__9 = null;
//line 87
___nl__10 = null;
//line 87
___nl__11 = null;
//line 87
___nl__12 = null;
//line 87
if (true) {goto label_6;}
//line 87
if (true) {goto label_13;}
//line 87
label_13:
//line 87
___nl__12 = null;
//line 88
___nl__12 = c_rt_lib_NL.NL_get_true();
//line 88
___nl__1 = ___nl__12;
//line 88
___nl__12 = null;
//line 89
___nl__12 = ((ImmHash)___nl__11).getHashValue()["dest"];
//line 89
___nl__2 = ___nl__12;
//line 89
___nl__12 = null;
//line 89
___nl__11 = null;
//line 90
if (true) {goto label_8;}
//line 90
label_9:
//line 90
___nl__10 = ___nl__9;
//line 90
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__10, new ImmString("return"));
//line 90
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10));
//line 90
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_14;}}
//line 91
___nl__11 = ___nl__1;
//line 91
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11));
//line 91
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11));
//line 91
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_16;}}
//line 91
___nl__12 = c_rt_lib_NL.NL_get_false();
//line 91
___nl__0 = null;
//line 91
___nl__1 = null;
//line 91
___nl__2 = null;
//line 91
___nl__3 = null;
//line 91
___nl__4 = null;
//line 91
___nl__5 = null;
//line 91
___nl__6 = null;
//line 91
___nl__7 = null;
//line 91
___nl__8 = null;
//line 91
___nl__9 = null;
//line 91
___nl__10 = null;
//line 91
___nl__11 = null;
//line 91
if(true) return ___nl__12;
//line 91
___nl__12 = null;
//line 91
if (true) {goto label_16;}
//line 91
label_16:
//line 91
___nl__11 = null;
//line 92
___nl__11 = ___nl__9;
//line 92
___nl__11 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("return"));
//line 93
___nl__12 = ___nl__11;
//line 93
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__12, new ImmString("val"));
//line 93
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12));
//line 93
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12));
//line 93
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_18;}}
//line 93
___nl__13 = c_rt_lib_NL.NL_get_false();
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
___nl__9 = null;
//line 93
___nl__10 = null;
//line 93
___nl__11 = null;
//line 93
___nl__12 = null;
//line 93
if(true) return ___nl__13;
//line 93
___nl__13 = null;
//line 93
if (true) {goto label_18;}
//line 93
label_18:
//line 93
___nl__12 = null;
//line 94
___nl__12 = ___nl__11;
//line 94
___nl__12 = c_rt_lib_NL.NL_ov_as(___nl__12, new ImmString("val"));
//line 94
___nl__12 = c_rt_lib_NL.NL_native_to_nl(___nl__12.toString().Equals(___nl__2.toString()));
//line 94
___nl__0 = null;
//line 94
___nl__1 = null;
//line 94
___nl__2 = null;
//line 94
___nl__3 = null;
//line 94
___nl__4 = null;
//line 94
___nl__5 = null;
//line 94
___nl__6 = null;
//line 94
___nl__7 = null;
//line 94
___nl__8 = null;
//line 94
___nl__9 = null;
//line 94
___nl__10 = null;
//line 94
___nl__11 = null;
//line 94
if(true) return ___nl__12;
//line 94
___nl__12 = null;
//line 94
___nl__11 = null;
//line 95
if (true) {goto label_8;}
//line 95
label_14:
//line 95
___nl__10 = ___nl__9;
//line 95
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__10, new ImmString("prt_lbl"));
//line 95
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10));
//line 95
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_19;}}
//line 96
if (true) {goto label_8;}
//line 96
label_19:
//line 96
___nl__10 = ___nl__9;
//line 96
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__10, new ImmString("clear"));
//line 96
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10));
//line 96
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_20;}}
//line 97
if (true) {goto label_8;}
//line 97
label_20:
//line 98
___nl__11 = ___nl__1;
//line 98
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11));
//line 98
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_22;}}
//line 98
___nl__12 = c_rt_lib_NL.NL_get_false();
//line 98
___nl__0 = null;
//line 98
___nl__1 = null;
//line 98
___nl__2 = null;
//line 98
___nl__3 = null;
//line 98
___nl__4 = null;
//line 98
___nl__5 = null;
//line 98
___nl__6 = null;
//line 98
___nl__7 = null;
//line 98
___nl__8 = null;
//line 98
___nl__9 = null;
//line 98
___nl__10 = null;
//line 98
___nl__11 = null;
//line 98
if(true) return ___nl__12;
//line 98
___nl__12 = null;
//line 98
if (true) {goto label_22;}
//line 98
label_22:
//line 98
___nl__11 = null;
//line 99
if (true) {goto label_8;}
//line 99
label_8:
//line 99
___nl__10 = null;
//line 99
___nl__9 = null;
//line 99
label_6:
//line 100
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString())));
//line 100
if (true) {goto label_7;}
//line 100
label_5:
//line 100
___nl__3 = null;
//line 100
___nl__4 = null;
//line 100
___nl__5 = null;
//line 100
___nl__6 = null;
//line 100
___nl__7 = null;
//line 100
___nl__8 = null;
//line 101
___nl__3 = c_rt_lib_NL.NL_get_false();
//line 101
___nl__0 = null;
//line 101
___nl__1 = null;
//line 101
___nl__2 = null;
//line 101
if(true) return ___nl__3;
//line 101
___nl__3 = null;
//line 101
___nl__1 = null;
//line 101
___nl__2 = null;
//line 101
___nl__0 = null;
//line 101
if(true) return null;
}

private static Imm NL_print_function_or_singleton_priv(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
ImmRef ___ref______nl__6 = null;
ImmRef ___ref______nl__7 = null;
ImmRef ___ref______nl__8 = null;
Dictionary<String, Imm> __function_map;
//line 106
___nl__2 = generator_cs_NL.NL_is_singleton_use_function_priv(___nl__0);

//line 106
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 106
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 107
___nl__3 = ___nl__0;
//line 108
___nl__4 = new ImmString("SINGLETON_");
//line 108
___nl__5 = ((ImmHash)___nl__0).getHashValue()["name"];
//line 108
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 108
___nl__5 = null;
//line 108
___nl__5 = ___nl__4;
//line 108
((ImmHash)___nl__3).set("name", ___nl__5);
//line 108
___nl__4 = null;
//line 108
___nl__5 = null;
//line 109
___nl__4 = generator_cs_NL.NL_get_function_name_priv(___nl__3);

//line 110
___nl__5 = new ImmString("value__singleton__");
//line 110
___nl__5 = new ImmString(___nl__5.toString() + ___nl__4.toString());
//line 112
___nl__6 = generator_cs_NL.NL_print_function_priv(___nl__3,___nl__1);

//line 114
___nl__7 = new ImmString("private static Imm ");
//line 114
___nl__7 = new ImmString(___nl__7.toString() + ___nl__5.toString());
//line 114
___nl__8 = new ImmString(" = null;");
//line 114
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 114
___nl__8 = null;
//line 114
___nl__8 = string_NL.NL_lf();

//line 114
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 114
___nl__8 = null;
//line 114
___nl__8 = generator_cs_NL.NL_get_function_declaration_priv(___nl__0);

//line 114
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 114
___nl__8 = null;
//line 114
___nl__8 = new ImmString("() {\n	if (");
//line 114
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 114
___nl__8 = null;
//line 114
___nl__7 = new ImmString(___nl__7.toString() + ___nl__5.toString());
//line 114
___nl__8 = new ImmString(" == null) {\n		");
//line 114
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 114
___nl__8 = null;
//line 114
___nl__7 = new ImmString(___nl__7.toString() + ___nl__5.toString());
//line 114
___nl__8 = new ImmString(" = ");
//line 114
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 114
___nl__8 = null;
//line 114
___nl__7 = new ImmString(___nl__7.toString() + ___nl__4.toString());
//line 114
___nl__8 = new ImmString("();\n	}\n	return ");
//line 114
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 114
___nl__8 = null;
//line 114
___nl__7 = new ImmString(___nl__7.toString() + ___nl__5.toString());
//line 114
___nl__8 = new ImmString(";\n}");
//line 114
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 114
___nl__8 = null;
//line 114
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 114
___nl__7 = null;
//line 121
___nl__0 = null;
//line 121
___nl__1 = null;
//line 121
___nl__2 = null;
//line 121
___nl__3 = null;
//line 121
___nl__4 = null;
//line 121
___nl__5 = null;
//line 121
if(true) return ___nl__6;
//line 121
___nl__3 = null;
//line 121
___nl__4 = null;
//line 121
___nl__5 = null;
//line 121
___nl__6 = null;
//line 122
if (true) {goto label_1;}
//line 122
label_2:
//line 123
___nl__3 = generator_cs_NL.NL_print_function_priv(___nl__0,___nl__1);

//line 123
___nl__0 = null;
//line 123
___nl__1 = null;
//line 123
___nl__2 = null;
//line 123
if(true) return ___nl__3;
//line 123
___nl__3 = null;
//line 124
if (true) {goto label_1;}
//line 124
label_1:
//line 124
___nl__2 = null;
//line 124
___nl__0 = null;
//line 124
___nl__1 = null;
//line 124
if(true) return null;
}

private static Imm NL_print_function_priv(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();
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
//line 128
___nl__2 = string_NL.NL_lf();

//line 128
___nl__3 = generator_cs_NL.NL_get_function_declaration_priv(___nl__0);

//line 128
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 128
___nl__3 = null;
//line 128
___nl__3 = new ImmString("(");
//line 128
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 128
___nl__3 = null;
//line 129
___nl__4 = ((ImmHash)___nl__0).getHashValue()["args_type"];
//line 129
___nl__3 = array_NL.NL_len(___nl__4);

//line 129
___nl__4 = null;
//line 129
___nl__4 = new ImmDouble(0);
//line 129
___nl__5 = new ImmDouble(1);
//line 129
label_3:
//line 129
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__3.getValue().ToString())) );
//line 129
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_1;}}
//line 130
___nl__7 = new ImmDouble(0);
//line 130
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString())) ==((Double.Parse(___nl__7.getValue().ToString())))  );
//line 130
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 130
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 130
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_5;}}
//line 130
___nl__8 = new ImmString(", ");
//line 130
___nl__2 = new ImmString(___nl__2.toString() + ___nl__8.toString());
//line 130
___nl__8 = null;
//line 130
if (true) {goto label_5;}
//line 130
label_5:
//line 130
___nl__7 = null;
//line 131
___nl__7 = ((ImmHash)___nl__0).getHashValue()["args_type"];
//line 131
___nl__7 = (___nl__7 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()];
//line 131
___nl__8 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("val"));
//line 131
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_7;}}
//line 133
___nl__8 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("ref"));
//line 133
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_8;}}
//line 133
___nl__8 = new ImmString("NOMATCHALERT");
//line 133
___nl__8 = new ImmArray(new Imm[] {___nl__8,___nl__7,});
//line 133
c_rt_lib_NL.NL_die();
//line 131
label_7:
//line 132
___nl__9 = new ImmString("Imm ___arg__");
//line 132
___nl__9 = new ImmString(___nl__9.toString() + ___nl__4.toString());
//line 132
___nl__2 = new ImmString(___nl__2.toString() + ___nl__9.toString());
//line 132
___nl__9 = null;
//line 133
if (true) {goto label_6;}
//line 133
label_8:
//line 134
___nl__9 = new ImmString("ImmRef ___arg__");
//line 134
___nl__9 = new ImmString(___nl__9.toString() + ___nl__4.toString());
//line 134
___nl__2 = new ImmString(___nl__2.toString() + ___nl__9.toString());
//line 134
___nl__9 = null;
//line 135
if (true) {goto label_6;}
//line 135
label_6:
//line 135
___nl__7 = null;
//line 135
___nl__8 = null;
//line 136
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString())));
//line 136
if (true) {goto label_3;}
//line 136
label_1:
//line 136
___nl__3 = null;
//line 136
___nl__4 = null;
//line 136
___nl__5 = null;
//line 136
___nl__6 = null;
//line 137
___nl__3 = new ImmString(") {");
//line 137
___nl__4 = string_NL.NL_lf();

//line 137
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 137
___nl__4 = null;
//line 137
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 137
___nl__3 = null;
//line 138
___nl__4 = ((ImmHash)___nl__0).getHashValue()["args_type"];
//line 138
___nl__3 = array_NL.NL_len(___nl__4);

//line 138
___nl__4 = null;
//line 138
___nl__4 = new ImmDouble(0);
//line 138
___nl__5 = new ImmDouble(1);
//line 138
label_11:
//line 138
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__3.getValue().ToString())) );
//line 138
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_9;}}
//line 139
___nl__7 = ((ImmHash)___nl__0).getHashValue()["args_type"];
//line 139
___nl__7 = (___nl__7 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()];
//line 139
___nl__8 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("val"));
//line 139
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_13;}}
//line 141
___nl__8 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("ref"));
//line 141
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_14;}}
//line 141
___nl__8 = new ImmString("NOMATCHALERT");
//line 141
___nl__8 = new ImmArray(new Imm[] {___nl__8,___nl__7,});
//line 141
c_rt_lib_NL.NL_die();
//line 139
label_13:
//line 140
___nl__9 = new ImmString("Imm ___nl__");
//line 140
___nl__9 = new ImmString(___nl__9.toString() + ___nl__4.toString());
//line 140
___nl__10 = new ImmString(" = ___arg__");
//line 140
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString());
//line 140
___nl__10 = null;
//line 140
___nl__9 = new ImmString(___nl__9.toString() + ___nl__4.toString());
//line 140
___nl__10 = new ImmString(".clone();");
//line 140
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString());
//line 140
___nl__10 = null;
//line 140
___nl__2 = new ImmString(___nl__2.toString() + ___nl__9.toString());
//line 140
___nl__9 = null;
//line 141
if (true) {goto label_12;}
//line 141
label_14:
//line 142
___nl__9 = new ImmString("Imm ___nl__");
//line 142
___nl__9 = new ImmString(___nl__9.toString() + ___nl__4.toString());
//line 142
___nl__10 = new ImmString(" = ___arg__");
//line 142
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString());
//line 142
___nl__10 = null;
//line 142
___nl__9 = new ImmString(___nl__9.toString() + ___nl__4.toString());
//line 142
___nl__10 = new ImmString(".getValue().clone();");
//line 142
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString());
//line 142
___nl__10 = null;
//line 142
___nl__2 = new ImmString(___nl__2.toString() + ___nl__9.toString());
//line 142
___nl__9 = null;
//line 143
if (true) {goto label_12;}
//line 143
label_12:
//line 143
___nl__7 = null;
//line 143
___nl__8 = null;
//line 144
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString())));
//line 144
if (true) {goto label_11;}
//line 144
label_9:
//line 144
___nl__3 = null;
//line 144
___nl__4 = null;
//line 144
___nl__5 = null;
//line 144
___nl__6 = null;
//line 145
___nl__3 = string_NL.NL_lf();

//line 145
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 145
___nl__3 = null;
//line 146
___nl__4 = ((ImmHash)___nl__0).getHashValue()["args_type"];
//line 146
___nl__3 = array_NL.NL_len(___nl__4);

//line 146
___nl__4 = null;
//line 146
label_16:
//line 146
___nl__4 = ((ImmHash)___nl__0).getHashValue()["reg_size"];
//line 146
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))<(Double.Parse(___nl__4.getValue().ToString())) );
//line 146
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 146
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_15;}}
//line 147
___nl__5 = new ImmString("Imm ___nl__");
//line 147
___nl__5 = new ImmString(___nl__5.toString() + ___nl__3.toString());
//line 147
___nl__6 = new ImmString(" = null;");
//line 147
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 147
___nl__6 = null;
//line 147
___nl__6 = string_NL.NL_lf();

//line 147
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 147
___nl__6 = null;
//line 147
___nl__2 = new ImmString(___nl__2.toString() + ___nl__5.toString());
//line 147
___nl__5 = null;
//line 147
___nl__5 = new ImmDouble(1);
//line 147
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString())));
//line 147
___nl__5 = null;
//line 148
if (true) {goto label_16;}
//line 148
label_15:
//line 148
___nl__3 = null;
//line 148
___nl__4 = null;
//line 149
___nl__3 = new ImmDouble(0);
//line 149
label_19:
//line 149
___nl__4 = ((ImmHash)___nl__0).getHashValue()["reg_size"];
//line 149
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))<(Double.Parse(___nl__4.getValue().ToString())) );
//line 149
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 149
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_18;}}
//line 150
___nl__5 = new ImmString("ImmRef ___ref______nl__");
//line 150
___nl__5 = new ImmString(___nl__5.toString() + ___nl__3.toString());
//line 150
___nl__6 = new ImmString(" = null;");
//line 150
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 150
___nl__6 = null;
//line 150
___nl__6 = string_NL.NL_lf();

//line 150
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 150
___nl__6 = null;
//line 150
___nl__2 = new ImmString(___nl__2.toString() + ___nl__5.toString());
//line 150
___nl__5 = null;
//line 150
___nl__5 = new ImmDouble(1);
//line 150
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString())));
//line 150
___nl__5 = null;
//line 151
if (true) {goto label_19;}
//line 151
label_18:
//line 151
___nl__3 = null;
//line 151
___nl__4 = null;
//line 152
___nl__3 = new ImmString("Dictionary<String, Imm> ");
//line 152
___nl__4 = generator_cs_NL.NL_print_hash_name_priv();

//line 152
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 152
___nl__4 = null;
//line 152
___nl__4 = new ImmString(";");
//line 152
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 152
___nl__4 = null;
//line 152
___nl__4 = string_NL.NL_lf();

//line 152
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 152
___nl__4 = null;
//line 152
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 152
___nl__3 = null;
//line 154
___nl__3 = new ImmString("");
//line 155
___nl__5 = ((ImmHash)___nl__0).getHashValue()["args_type"];
//line 155
___nl__4 = array_NL.NL_len(___nl__5);

//line 155
___nl__5 = null;
//line 155
___nl__5 = new ImmDouble(0);
//line 155
___nl__6 = new ImmDouble(1);
//line 155
label_23:
//line 155
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__4.getValue().ToString())) );
//line 155
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_21;}}
//line 156
___nl__8 = ((ImmHash)___nl__0).getHashValue()["args_type"];
//line 156
___nl__8 = (___nl__8 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()];
//line 156
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("val"));
//line 156
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_25;}}
//line 157
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("ref"));
//line 157
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_26;}}
//line 157
___nl__9 = new ImmString("NOMATCHALERT");
//line 157
___nl__9 = new ImmArray(new Imm[] {___nl__9,___nl__8,});
//line 157
c_rt_lib_NL.NL_die();
//line 156
label_25:
//line 157
if (true) {goto label_24;}
//line 157
label_26:
//line 158
___nl__10 = new ImmString("___arg__");
//line 158
___nl__10 = new ImmString(___nl__10.toString() + ___nl__5.toString());
//line 158
___nl__11 = new ImmString(".setValue(___nl__");
//line 158
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString());
//line 158
___nl__11 = null;
//line 158
___nl__10 = new ImmString(___nl__10.toString() + ___nl__5.toString());
//line 158
___nl__11 = new ImmString(");");
//line 158
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString());
//line 158
___nl__11 = null;
//line 158
___nl__3 = new ImmString(___nl__3.toString() + ___nl__10.toString());
//line 158
___nl__10 = null;
//line 159
if (true) {goto label_24;}
//line 159
label_24:
//line 159
___nl__8 = null;
//line 159
___nl__9 = null;
//line 160
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString())));
//line 160
if (true) {goto label_23;}
//line 160
label_21:
//line 160
___nl__4 = null;
//line 160
___nl__5 = null;
//line 160
___nl__6 = null;
//line 160
___nl__7 = null;
//line 162
___nl__4 = ((ImmHash)___nl__0).getHashValue()["commands"];
//line 162
___nl__6 = new ImmDouble(0);
//line 162
___nl__7 = new ImmDouble(1);
//line 162
___nl__8 = c_rt_lib_NL.NL_array_len(___nl__4);

//line 162
label_29:
//line 162
___nl__9 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__6.getValue().ToString()))>=(Double.Parse(___nl__8.getValue().ToString())) );
//line 162
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_27;}}
//line 162
___nl__5 = (___nl__4 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()];
//line 162
___nl__10 = generator_cs_NL.NL_print_command_priv(___nl__1,___nl__5,___nl__3);

//line 162
___nl__2 = new ImmString(___nl__2.toString() + ___nl__10.toString());
//line 162
___nl__10 = null;
//line 162
___nl__6 = new ImmDouble((Double.Parse(___nl__6.getValue().ToString()))+(Double.Parse(___nl__7.getValue().ToString())));
//line 162
if (true) {goto label_29;}
//line 162
label_27:
//line 162
___nl__4 = null;
//line 162
___nl__5 = null;
//line 162
___nl__6 = null;
//line 162
___nl__7 = null;
//line 162
___nl__8 = null;
//line 162
___nl__9 = null;
//line 164
___nl__4 = new ImmString("}");
//line 164
___nl__4 = new ImmString(___nl__2.toString() + ___nl__4.toString());
//line 164
___nl__5 = string_NL.NL_lf();

//line 164
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 164
___nl__5 = null;
//line 164
___nl__0 = null;
//line 164
___nl__1 = null;
//line 164
___nl__2 = null;
//line 164
___nl__3 = null;
//line 164
if(true) return ___nl__4;
//line 164
___nl__4 = null;
//line 164
___nl__2 = null;
//line 164
___nl__3 = null;
//line 164
___nl__0 = null;
//line 164
___nl__1 = null;
//line 164
if(true) return null;
}

private static Imm NL_print_command_priv(Imm ___arg__0, Imm ___arg__1, Imm ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();
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
//line 169
___nl__4 = ((ImmHash)___nl__1).getHashValue()["cmd"];
//line 169
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("arr_decl"));
//line 169
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_2;}}
//line 171
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("hash_decl"));
//line 171
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_3;}}
//line 174
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("call"));
//line 174
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_4;}}
//line 178
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("func"));
//line 178
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_5;}}
//line 180
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("una_op"));
//line 180
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_6;}}
//line 182
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("bin_op"));
//line 182
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_7;}}
//line 184
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("ov_is"));
//line 184
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_8;}}
//line 186
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("ov_as"));
//line 186
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_9;}}
//line 188
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("return"));
//line 188
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_10;}}
//line 191
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("die"));
//line 191
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_11;}}
//line 193
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("move"));
//line 193
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_12;}}
//line 195
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("load_const"));
//line 195
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_13;}}
//line 197
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("get_frm_idx"));
//line 197
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_14;}}
//line 201
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("set_at_idx"));
//line 201
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_15;}}
//line 204
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("get_val"));
//line 204
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_16;}}
//line 206
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("set_val"));
//line 206
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_17;}}
//line 208
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("ov_mk"));
//line 208
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_18;}}
//line 210
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("prt_lbl"));
//line 210
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_19;}}
//line 212
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("if_goto"));
//line 212
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_20;}}
//line 214
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("goto"));
//line 214
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_21;}}
//line 216
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("clear"));
//line 216
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_22;}}
//line 216
___nl__5 = new ImmString("NOMATCHALERT");
//line 216
___nl__5 = new ImmArray(new Imm[] {___nl__5,___nl__4,});
//line 216
c_rt_lib_NL.NL_die();
//line 169
label_2:
//line 169
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("arr_decl"));
//line 170
___nl__8 = ((ImmHash)___nl__6).getHashValue()["dest"];
//line 170
___nl__10 = ((ImmHash)___nl__6).getHashValue()["src"];
//line 170
___nl__9 = generator_cs_NL.NL_print_arr_priv(___nl__10);

//line 170
___nl__10 = null;
//line 170
___nl__7 = generator_cs_NL.NL_print_register_setter_priv(___nl__8,___nl__9);

//line 170
___nl__9 = null;
//line 170
___nl__8 = null;
//line 170
___nl__8 = new ImmString(";");
//line 170
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 170
___nl__8 = null;
//line 170
___nl__3 = ___nl__7;
//line 170
___nl__7 = null;
//line 170
___nl__6 = null;
//line 171
if (true) {goto label_1;}
//line 171
label_3:
//line 171
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("hash_decl"));
//line 172
___nl__7 = generator_cs_NL.NL_print_hash_priv(___nl__6);

//line 172
___nl__3 = ___nl__7;
//line 172
___nl__7 = null;
//line 173
___nl__8 = ((ImmHash)___nl__6).getHashValue()["dest"];
//line 173
___nl__9 = new ImmString("new ImmHash(");
//line 173
___nl__10 = generator_cs_NL.NL_print_hash_name_priv();

//line 173
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString());
//line 173
___nl__10 = null;
//line 173
___nl__10 = new ImmString(")");
//line 173
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString());
//line 173
___nl__10 = null;
//line 173
___nl__7 = generator_cs_NL.NL_print_register_setter_priv(___nl__8,___nl__9);

//line 173
___nl__9 = null;
//line 173
___nl__8 = null;
//line 173
___nl__8 = new ImmString(";");
//line 173
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 173
___nl__8 = null;
//line 173
___nl__3 = new ImmString(___nl__3.toString() + ___nl__7.toString());
//line 173
___nl__7 = null;
//line 173
___nl__6 = null;
//line 174
if (true) {goto label_1;}
//line 174
label_4:
//line 174
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("call"));
//line 175
___nl__8 = ((ImmHash)___nl__6).getHashValue()["args"];
//line 175
___nl__7 = generator_cs_NL.NL_print_call_ref_prepare_priv(___nl__8);

//line 175
___nl__8 = null;
//line 175
___nl__3 = ___nl__7;
//line 175
___nl__7 = null;
//line 176
___nl__8 = ((ImmHash)___nl__6).getHashValue()["dest"];
//line 176
___nl__10 = ((ImmHash)___nl__6).getHashValue()["mod"];
//line 176
___nl__11 = ((ImmHash)___nl__6).getHashValue()["fun_name"];
//line 176
___nl__12 = ((ImmHash)___nl__6).getHashValue()["args"];
//line 176
___nl__9 = generator_cs_NL.NL_print_call_priv(___nl__0,___nl__10,___nl__11,___nl__12);

//line 176
___nl__12 = null;
//line 176
___nl__11 = null;
//line 176
___nl__10 = null;
//line 176
___nl__7 = generator_cs_NL.NL_print_register_setter_priv(___nl__8,___nl__9);

//line 176
___nl__9 = null;
//line 176
___nl__8 = null;
//line 176
___nl__8 = new ImmString(";");
//line 176
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 176
___nl__8 = null;
//line 176
___nl__8 = string_NL.NL_lf();

//line 176
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 176
___nl__8 = null;
//line 176
___nl__3 = new ImmString(___nl__3.toString() + ___nl__7.toString());
//line 176
___nl__7 = null;
//line 177
___nl__8 = ((ImmHash)___nl__6).getHashValue()["args"];
//line 177
___nl__7 = generator_cs_NL.NL_print_call_ref_setter_priv(___nl__8);

//line 177
___nl__8 = null;
//line 177
___nl__3 = new ImmString(___nl__3.toString() + ___nl__7.toString());
//line 177
___nl__7 = null;
//line 177
___nl__6 = null;
//line 178
if (true) {goto label_1;}
//line 178
label_5:
//line 178
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("func"));
//line 179
___nl__8 = ((ImmHash)___nl__6).getHashValue()["dest"];
//line 179
___nl__11 = ((ImmHash)___nl__6).getHashValue()["module"];
//line 179
___nl__10 = generator_cs_NL.NL_get_class_name_priv(___nl__11);

//line 179
___nl__11 = null;
//line 179
___nl__11 = ((ImmHash)___nl__6).getHashValue()["name"];
//line 179
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",___nl__10);
__function_map.Add("name",___nl__11);
___nl__9 = new ImmHash(__function_map);
//line 179
___nl__10 = null;
//line 179
___nl__11 = null;
//line 179
___nl__7 = generator_cs_NL.NL_print_const_hash_priv(___nl__8,___nl__9);

//line 179
___nl__9 = null;
//line 179
___nl__8 = null;
//line 179
___nl__8 = new ImmString(";");
//line 179
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 179
___nl__8 = null;
//line 179
___nl__3 = ___nl__7;
//line 179
___nl__7 = null;
//line 179
___nl__6 = null;
//line 180
if (true) {goto label_1;}
//line 180
label_6:
//line 180
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("una_op"));
//line 181
___nl__7 = generator_cs_NL.NL_print_una_op_priv(___nl__6);

//line 181
___nl__3 = ___nl__7;
//line 181
___nl__7 = null;
//line 181
___nl__6 = null;
//line 182
if (true) {goto label_1;}
//line 182
label_7:
//line 182
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("bin_op"));
//line 183
___nl__7 = generator_cs_NL.NL_print_bin_op_priv(___nl__6);

//line 183
___nl__3 = ___nl__7;
//line 183
___nl__7 = null;
//line 183
___nl__6 = null;
//line 184
if (true) {goto label_1;}
//line 184
label_8:
//line 184
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("ov_is"));
//line 185
___nl__8 = ((ImmHash)___nl__6).getHashValue()["dest"];
//line 185
___nl__9 = new ImmString("c_rt_lib_NL.NL_ov_is(");
//line 185
___nl__11 = ((ImmHash)___nl__6).getHashValue()["src"];
//line 185
___nl__10 = generator_cs_NL.NL_print_register_priv(___nl__11);

//line 185
___nl__11 = null;
//line 185
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString());
//line 185
___nl__10 = null;
//line 185
___nl__10 = new ImmString(", new ImmString(\"");
//line 185
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString());
//line 185
___nl__10 = null;
//line 185
___nl__11 = ((ImmHash)___nl__6).getHashValue()["type"];
//line 185
___nl__10 = generator_cs_NL.NL_escape_string_priv(___nl__11);

//line 185
___nl__11 = null;
//line 185
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString());
//line 185
___nl__10 = null;
//line 185
___nl__10 = new ImmString("\"))");
//line 185
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString());
//line 185
___nl__10 = null;
//line 185
___nl__7 = generator_cs_NL.NL_print_register_setter_priv(___nl__8,___nl__9);

//line 185
___nl__9 = null;
//line 185
___nl__8 = null;
//line 185
___nl__8 = new ImmString(";");
//line 185
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 185
___nl__8 = null;
//line 185
___nl__3 = ___nl__7;
//line 185
___nl__7 = null;
//line 185
___nl__6 = null;
//line 186
if (true) {goto label_1;}
//line 186
label_9:
//line 186
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("ov_as"));
//line 187
___nl__8 = ((ImmHash)___nl__6).getHashValue()["dest"];
//line 187
___nl__9 = new ImmString("c_rt_lib_NL.NL_ov_as(");
//line 187
___nl__11 = ((ImmHash)___nl__6).getHashValue()["src"];
//line 187
___nl__10 = generator_cs_NL.NL_print_register_priv(___nl__11);

//line 187
___nl__11 = null;
//line 187
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString());
//line 187
___nl__10 = null;
//line 187
___nl__10 = new ImmString(", new ImmString(\"");
//line 187
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString());
//line 187
___nl__10 = null;
//line 187
___nl__11 = ((ImmHash)___nl__6).getHashValue()["type"];
//line 187
___nl__10 = generator_cs_NL.NL_escape_string_priv(___nl__11);

//line 187
___nl__11 = null;
//line 187
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString());
//line 187
___nl__10 = null;
//line 187
___nl__10 = new ImmString("\"))");
//line 187
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString());
//line 187
___nl__10 = null;
//line 187
___nl__7 = generator_cs_NL.NL_print_register_setter_priv(___nl__8,___nl__9);

//line 187
___nl__9 = null;
//line 187
___nl__8 = null;
//line 187
___nl__8 = new ImmString(";");
//line 187
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 187
___nl__8 = null;
//line 187
___nl__3 = ___nl__7;
//line 187
___nl__7 = null;
//line 187
___nl__6 = null;
//line 188
if (true) {goto label_1;}
//line 188
label_10:
//line 188
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("return"));
//line 189
___nl__3 = ___nl__2;
//line 190
___nl__7 = generator_cs_NL.NL_print_return_priv(___nl__6);

//line 190
___nl__3 = new ImmString(___nl__3.toString() + ___nl__7.toString());
//line 190
___nl__7 = null;
//line 190
___nl__6 = null;
//line 191
if (true) {goto label_1;}
//line 191
label_11:
//line 191
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("die"));
//line 192
___nl__7 = new ImmString("c_rt_lib_NL.NL_die();");
//line 192
___nl__3 = ___nl__7;
//line 192
___nl__7 = null;
//line 192
___nl__6 = null;
//line 193
if (true) {goto label_1;}
//line 193
label_12:
//line 193
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("move"));
//line 194
___nl__8 = ((ImmHash)___nl__6).getHashValue()["dest"];
//line 194
___nl__10 = ((ImmHash)___nl__6).getHashValue()["src"];
//line 194
___nl__9 = generator_cs_NL.NL_print_register_priv(___nl__10);

//line 194
___nl__10 = null;
//line 194
___nl__7 = generator_cs_NL.NL_print_register_setter_priv(___nl__8,___nl__9);

//line 194
___nl__9 = null;
//line 194
___nl__8 = null;
//line 194
___nl__8 = new ImmString(";");
//line 194
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 194
___nl__8 = null;
//line 194
___nl__3 = ___nl__7;
//line 194
___nl__7 = null;
//line 194
___nl__6 = null;
//line 195
if (true) {goto label_1;}
//line 195
label_13:
//line 195
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("load_const"));
//line 196
___nl__8 = ((ImmHash)___nl__6).getHashValue()["dest"];
//line 196
___nl__11 = ((ImmHash)___nl__6).getHashValue()["dest"];
//line 196
___nl__10 = generator_cs_NL.NL_print_register_priv(___nl__11);

//line 196
___nl__11 = null;
//line 196
___nl__11 = ((ImmHash)___nl__6).getHashValue()["val"];
//line 196
___nl__9 = generator_cs_NL.NL_print_const_value_priv(___nl__10,___nl__11);

//line 196
___nl__11 = null;
//line 196
___nl__10 = null;
//line 196
___nl__7 = generator_cs_NL.NL_print_register_setter_priv(___nl__8,___nl__9);

//line 196
___nl__9 = null;
//line 196
___nl__8 = null;
//line 196
___nl__8 = new ImmString(";");
//line 196
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 196
___nl__8 = null;
//line 196
___nl__3 = ___nl__7;
//line 196
___nl__7 = null;
//line 196
___nl__6 = null;
//line 197
if (true) {goto label_1;}
//line 197
label_14:
//line 197
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("get_frm_idx"));
//line 198
___nl__7 = new ImmString("(");
//line 198
___nl__9 = ((ImmHash)___nl__6).getHashValue()["src"];
//line 198
___nl__8 = generator_cs_NL.NL_print_register_priv(___nl__9);

//line 198
___nl__9 = null;
//line 198
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 198
___nl__8 = null;
//line 198
___nl__8 = new ImmString(" as ImmArray).getArrayValue()");
//line 198
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 198
___nl__8 = null;
//line 198
___nl__3 = ___nl__7;
//line 198
___nl__7 = null;
//line 199
___nl__7 = new ImmString("[(int)((ImmDouble)");
//line 199
___nl__9 = ((ImmHash)___nl__6).getHashValue()["idx"];
//line 199
___nl__8 = generator_cs_NL.NL_print_register_priv(___nl__9);

//line 199
___nl__9 = null;
//line 199
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 199
___nl__8 = null;
//line 199
___nl__8 = new ImmString(").getDoubleValue()]");
//line 199
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 199
___nl__8 = null;
//line 199
___nl__3 = new ImmString(___nl__3.toString() + ___nl__7.toString());
//line 199
___nl__7 = null;
//line 200
___nl__8 = ((ImmHash)___nl__6).getHashValue()["dest"];
//line 200
___nl__7 = generator_cs_NL.NL_print_register_setter_priv(___nl__8,___nl__3);

//line 200
___nl__8 = null;
//line 200
___nl__8 = new ImmString(";");
//line 200
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 200
___nl__8 = null;
//line 200
___nl__3 = ___nl__7;
//line 200
___nl__7 = null;
//line 200
___nl__6 = null;
//line 201
if (true) {goto label_1;}
//line 201
label_15:
//line 201
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("set_at_idx"));
//line 202
___nl__7 = new ImmString("(");
//line 202
___nl__9 = ((ImmHash)___nl__6).getHashValue()["src"];
//line 202
___nl__8 = generator_cs_NL.NL_print_register_priv(___nl__9);

//line 202
___nl__9 = null;
//line 202
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 202
___nl__8 = null;
//line 202
___nl__8 = new ImmString(" as ImmArray).getArrayValue()");
//line 202
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 202
___nl__8 = null;
//line 202
___nl__3 = ___nl__7;
//line 202
___nl__7 = null;
//line 203
___nl__7 = new ImmString("[(int)((ImmDouble)");
//line 203
___nl__9 = ((ImmHash)___nl__6).getHashValue()["idx"];
//line 203
___nl__8 = generator_cs_NL.NL_print_register_priv(___nl__9);

//line 203
___nl__9 = null;
//line 203
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 203
___nl__8 = null;
//line 203
___nl__8 = new ImmString(").getDoubleValue()] = ");
//line 203
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 203
___nl__8 = null;
//line 203
___nl__9 = ((ImmHash)___nl__6).getHashValue()["val"];
//line 203
___nl__8 = generator_cs_NL.NL_print_register_priv(___nl__9);

//line 203
___nl__9 = null;
//line 203
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 203
___nl__8 = null;
//line 203
___nl__8 = new ImmString(";");
//line 203
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 203
___nl__8 = null;
//line 203
___nl__3 = new ImmString(___nl__3.toString() + ___nl__7.toString());
//line 203
___nl__7 = null;
//line 203
___nl__6 = null;
//line 204
if (true) {goto label_1;}
//line 204
label_16:
//line 204
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("get_val"));
//line 205
___nl__8 = ((ImmHash)___nl__6).getHashValue()["dest"];
//line 205
___nl__9 = generator_cs_NL.NL_print_get_hash_value_priv(___nl__6);

//line 205
___nl__7 = generator_cs_NL.NL_print_register_setter_priv(___nl__8,___nl__9);

//line 205
___nl__9 = null;
//line 205
___nl__8 = null;
//line 205
___nl__8 = new ImmString(";");
//line 205
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 205
___nl__8 = null;
//line 205
___nl__3 = ___nl__7;
//line 205
___nl__7 = null;
//line 205
___nl__6 = null;
//line 206
if (true) {goto label_1;}
//line 206
label_17:
//line 206
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("set_val"));
//line 207
___nl__7 = generator_cs_NL.NL_print_set_hash_value_priv(___nl__6);

//line 207
___nl__8 = new ImmString(";");
//line 207
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 207
___nl__8 = null;
//line 207
___nl__3 = ___nl__7;
//line 207
___nl__7 = null;
//line 207
___nl__6 = null;
//line 208
if (true) {goto label_1;}
//line 208
label_18:
//line 208
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("ov_mk"));
//line 209
___nl__7 = generator_cs_NL.NL_print_ov_mk_priv(___nl__6);

//line 209
___nl__3 = ___nl__7;
//line 209
___nl__7 = null;
//line 209
___nl__6 = null;
//line 210
if (true) {goto label_1;}
//line 210
label_19:
//line 210
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("prt_lbl"));
//line 211
___nl__7 = new ImmString("");
//line 211
___nl__7 = new ImmString(___nl__7.toString() + ___nl__6.toString());
//line 211
___nl__8 = new ImmString(":");
//line 211
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 211
___nl__8 = null;
//line 211
___nl__3 = ___nl__7;
//line 211
___nl__7 = null;
//line 211
___nl__6 = null;
//line 212
if (true) {goto label_1;}
//line 212
label_20:
//line 212
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("if_goto"));
//line 213
___nl__7 = new ImmString("if (c_rt_lib_NL.NL_check_true_native(");
//line 213
___nl__9 = ((ImmHash)___nl__6).getHashValue()["src"];
//line 213
___nl__8 = generator_cs_NL.NL_print_register_priv(___nl__9);

//line 213
___nl__9 = null;
//line 213
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 213
___nl__8 = null;
//line 213
___nl__8 = new ImmString(")) {");
//line 213
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 213
___nl__8 = null;
//line 213
___nl__9 = ((ImmHash)___nl__6).getHashValue()["dest"];
//line 213
___nl__8 = generator_cs_NL.NL_print_goto_priv(___nl__9);

//line 213
___nl__9 = null;
//line 213
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 213
___nl__8 = null;
//line 213
___nl__8 = new ImmString("}");
//line 213
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 213
___nl__8 = null;
//line 213
___nl__3 = ___nl__7;
//line 213
___nl__7 = null;
//line 213
___nl__6 = null;
//line 214
if (true) {goto label_1;}
//line 214
label_21:
//line 214
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("goto"));
//line 215
___nl__7 = generator_cs_NL.NL_print_goto_priv(___nl__6);

//line 215
___nl__3 = ___nl__7;
//line 215
___nl__7 = null;
//line 215
___nl__6 = null;
//line 216
if (true) {goto label_1;}
//line 216
label_22:
//line 216
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("clear"));
//line 217
___nl__8 = new ImmString("null");
//line 217
___nl__7 = generator_cs_NL.NL_print_register_setter_priv(___nl__6,___nl__8);

//line 217
___nl__8 = null;
//line 217
___nl__8 = new ImmString(";");
//line 217
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 217
___nl__8 = null;
//line 217
___nl__3 = ___nl__7;
//line 217
___nl__7 = null;
//line 217
___nl__6 = null;
//line 218
if (true) {goto label_1;}
//line 218
label_1:
//line 218
___nl__4 = null;
//line 218
___nl__5 = null;
//line 219
___nl__4 = new ImmString("//line ");
//line 219
___nl__5 = ((ImmHash)___nl__1).getHashValue()["debug"];
//line 219
___nl__5 = ((ImmHash)___nl__5).getHashValue()["nast_debug"];
//line 219
___nl__5 = ((ImmHash)___nl__5).getHashValue()["begin"];
//line 219
___nl__5 = ((ImmHash)___nl__5).getHashValue()["line"];
//line 219
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 219
___nl__5 = null;
//line 219
___nl__5 = string_NL.NL_lf();

//line 219
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 219
___nl__5 = null;
//line 219
___nl__4 = new ImmString(___nl__4.toString() + ___nl__3.toString());
//line 219
___nl__5 = string_NL.NL_lf();

//line 219
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 219
___nl__5 = null;
//line 219
___nl__0 = null;
//line 219
___nl__1 = null;
//line 219
___nl__2 = null;
//line 219
___nl__3 = null;
//line 219
if(true) return ___nl__4;
//line 219
___nl__4 = null;
//line 219
___nl__3 = null;
//line 219
___nl__0 = null;
//line 219
___nl__1 = null;
//line 219
___nl__2 = null;
//line 219
if(true) return null;
}

private static Imm NL_print_arr_priv(Imm ___arg__0) {
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
//line 223
___nl__1 = new ImmString("new ImmArray(new Imm[");
//line 224
___nl__2 = array_NL.NL_len(___nl__0);

//line 224
___nl__3 = new ImmDouble(0);
//line 224
___nl__2 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__2.getValue().ToString())) ==((Double.Parse(___nl__3.getValue().ToString())))  );
//line 224
___nl__3 = null;
//line 224
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 224
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 225
___nl__3 = new ImmString("0]");
//line 225
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString());
//line 225
___nl__3 = null;
//line 226
if (true) {goto label_1;}
//line 226
label_2:
//line 227
___nl__3 = new ImmString("] {");
//line 227
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString());
//line 227
___nl__3 = null;
//line 228
___nl__4 = new ImmDouble(0);
//line 228
___nl__5 = new ImmDouble(1);
//line 228
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__0);

//line 228
label_5:
//line 228
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) );
//line 228
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_3;}}
//line 228
___nl__3 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()];
//line 228
___nl__8 = generator_cs_NL.NL_print_register_priv(___nl__3);

//line 228
___nl__9 = new ImmString(",");
//line 228
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 228
___nl__9 = null;
//line 228
___nl__1 = new ImmString(___nl__1.toString() + ___nl__8.toString());
//line 228
___nl__8 = null;
//line 228
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString())));
//line 228
if (true) {goto label_5;}
//line 228
label_3:
//line 228
___nl__3 = null;
//line 228
___nl__4 = null;
//line 228
___nl__5 = null;
//line 228
___nl__6 = null;
//line 228
___nl__7 = null;
//line 229
___nl__3 = new ImmString("}");
//line 229
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString());
//line 229
___nl__3 = null;
//line 230
if (true) {goto label_1;}
//line 230
label_1:
//line 230
___nl__2 = null;
//line 231
___nl__2 = new ImmString(")");
//line 231
___nl__2 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 231
___nl__0 = null;
//line 231
___nl__1 = null;
//line 231
if(true) return ___nl__2;
//line 231
___nl__2 = null;
//line 231
___nl__1 = null;
//line 231
___nl__0 = null;
//line 231
if(true) return null;
}

private static Imm NL_print_bin_op_priv(Imm ___arg__0) {
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
//line 235
___nl__1 = new ImmString("");
//line 236
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 236
___nl__3 = new ImmString(">=");
//line 236
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 236
___nl__3 = null;
//line 236
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_7;}}
//line 236
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 236
___nl__3 = new ImmString("<=");
//line 236
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 236
___nl__3 = null;
//line 236
label_7:
//line 236
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_6;}}
//line 236
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 236
___nl__3 = new ImmString("<");
//line 236
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 236
___nl__3 = null;
//line 236
label_6:
//line 236
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_5;}}
//line 236
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 236
___nl__3 = new ImmString(">");
//line 236
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 236
___nl__3 = null;
//line 236
label_5:
//line 236
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_4;}}
//line 236
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 236
___nl__3 = new ImmString("==");
//line 236
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 236
___nl__3 = null;
//line 236
label_4:
//line 236
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_3;}}
//line 236
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 236
___nl__3 = new ImmString("!=");
//line 236
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 236
___nl__3 = null;
//line 236
label_3:
//line 236
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 236
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 238
___nl__3 = new ImmString("c_rt_lib_NL.NL_native_to_nl(");
//line 238
___nl__4 = generator_cs_NL.NL_print_imm_double_operation_priv(___nl__0);

//line 238
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 238
___nl__4 = null;
//line 238
___nl__4 = new ImmString(" )");
//line 238
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 238
___nl__4 = null;
//line 238
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString());
//line 238
___nl__3 = null;
//line 239
if (true) {goto label_1;}
//line 239
label_2:
//line 239
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 239
___nl__3 = new ImmString("eq");
//line 239
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 239
___nl__3 = null;
//line 239
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_9;}}
//line 239
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 239
___nl__3 = new ImmString("ne");
//line 239
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 239
___nl__3 = null;
//line 239
label_9:
//line 239
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 239
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_8;}}
//line 240
___nl__3 = new ImmString("c_rt_lib_NL.NL_native_to_nl(");
//line 240
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString());
//line 240
___nl__3 = null;
//line 241
___nl__3 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 241
___nl__4 = new ImmString("ne");
//line 241
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__4.toString()));
//line 241
___nl__4 = null;
//line 241
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 241
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_11;}}
//line 242
___nl__4 = new ImmString("!");
//line 242
___nl__1 = new ImmString(___nl__1.toString() + ___nl__4.toString());
//line 242
___nl__4 = null;
//line 243
if (true) {goto label_11;}
//line 243
label_11:
//line 243
___nl__3 = null;
//line 244
___nl__4 = ((ImmHash)___nl__0).getHashValue()["left"];
//line 244
___nl__3 = generator_cs_NL.NL_print_register_priv(___nl__4);

//line 244
___nl__4 = null;
//line 244
___nl__4 = new ImmString(".toString().Equals(");
//line 244
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 244
___nl__4 = null;
//line 244
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString());
//line 244
___nl__3 = null;
//line 245
___nl__4 = ((ImmHash)___nl__0).getHashValue()["right"];
//line 245
___nl__3 = generator_cs_NL.NL_print_register_priv(___nl__4);

//line 245
___nl__4 = null;
//line 245
___nl__4 = new ImmString(".toString()))");
//line 245
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 245
___nl__4 = null;
//line 245
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString());
//line 245
___nl__3 = null;
//line 246
if (true) {goto label_1;}
//line 246
label_8:
//line 246
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 246
___nl__3 = new ImmString(".");
//line 246
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 246
___nl__3 = null;
//line 246
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 246
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_12;}}
//line 247
___nl__3 = new ImmString("new ImmString(");
//line 247
___nl__5 = ((ImmHash)___nl__0).getHashValue()["left"];
//line 247
___nl__4 = generator_cs_NL.NL_print_register_priv(___nl__5);

//line 247
___nl__5 = null;
//line 247
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 247
___nl__4 = null;
//line 247
___nl__4 = new ImmString(".toString() + ");
//line 247
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 247
___nl__4 = null;
//line 247
___nl__5 = ((ImmHash)___nl__0).getHashValue()["right"];
//line 247
___nl__4 = generator_cs_NL.NL_print_register_priv(___nl__5);

//line 247
___nl__5 = null;
//line 247
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 247
___nl__4 = null;
//line 247
___nl__4 = new ImmString(".toString())");
//line 247
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 247
___nl__4 = null;
//line 247
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString());
//line 247
___nl__3 = null;
//line 248
if (true) {goto label_1;}
//line 248
label_12:
//line 249
___nl__3 = new ImmString("new ImmDouble(");
//line 249
___nl__4 = generator_cs_NL.NL_print_imm_double_operation_priv(___nl__0);

//line 249
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 249
___nl__4 = null;
//line 249
___nl__4 = new ImmString(")");
//line 249
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 249
___nl__4 = null;
//line 249
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString());
//line 249
___nl__3 = null;
//line 250
if (true) {goto label_1;}
//line 250
label_1:
//line 250
___nl__2 = null;
//line 251
___nl__3 = ((ImmHash)___nl__0).getHashValue()["dest"];
//line 251
___nl__2 = generator_cs_NL.NL_print_register_setter_priv(___nl__3,___nl__1);

//line 251
___nl__3 = null;
//line 251
___nl__3 = new ImmString(";");
//line 251
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 251
___nl__3 = null;
//line 251
___nl__0 = null;
//line 251
___nl__1 = null;
//line 251
if(true) return ___nl__2;
//line 251
___nl__2 = null;
//line 251
___nl__1 = null;
//line 251
___nl__0 = null;
//line 251
if(true) return null;
}

private static Imm NL_print_imm_double_operation_priv(Imm ___arg__0) {
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
//line 255
___nl__2 = ((ImmHash)___nl__0).getHashValue()["left"];
//line 255
___nl__1 = generator_cs_NL.NL_print_register_as_number_priv(___nl__2);

//line 255
___nl__2 = null;
//line 256
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 256
___nl__3 = new ImmString("==");
//line 256
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 256
___nl__3 = null;
//line 256
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_3;}}
//line 256
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 256
___nl__3 = new ImmString("!=");
//line 256
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 256
___nl__3 = null;
//line 256
label_3:
//line 256
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 256
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 257
___nl__3 = new ImmString(" ");
//line 257
___nl__4 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 257
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 257
___nl__4 = null;
//line 257
___nl__4 = new ImmString("(");
//line 257
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 257
___nl__4 = null;
//line 257
___nl__5 = ((ImmHash)___nl__0).getHashValue()["right"];
//line 257
___nl__4 = generator_cs_NL.NL_print_register_as_number_priv(___nl__5);

//line 257
___nl__5 = null;
//line 257
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 257
___nl__4 = null;
//line 257
___nl__4 = new ImmString(") ");
//line 257
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 257
___nl__4 = null;
//line 257
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString());
//line 257
___nl__3 = null;
//line 258
if (true) {goto label_1;}
//line 258
label_2:
//line 259
___nl__3 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 259
___nl__5 = ((ImmHash)___nl__0).getHashValue()["right"];
//line 259
___nl__4 = generator_cs_NL.NL_print_register_as_number_priv(___nl__5);

//line 259
___nl__5 = null;
//line 259
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 259
___nl__4 = null;
//line 259
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString());
//line 259
___nl__3 = null;
//line 260
if (true) {goto label_1;}
//line 260
label_1:
//line 260
___nl__2 = null;
//line 261
___nl__0 = null;
//line 261
if(true) return ___nl__1;
//line 261
___nl__1 = null;
//line 261
___nl__0 = null;
//line 261
if(true) return null;
}

private static Imm NL_print_register_as_number_priv(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 265
___nl__1 = new ImmString("(Double.Parse(");
//line 265
___nl__2 = generator_cs_NL.NL_print_register_priv(___nl__0);

//line 265
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 265
___nl__2 = null;
//line 265
___nl__2 = generator_cs_NL.NL_print_getter_priv();

//line 265
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 265
___nl__2 = null;
//line 265
___nl__2 = new ImmString(".ToString()))");
//line 265
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 265
___nl__2 = null;
//line 265
___nl__0 = null;
//line 265
if(true) return ___nl__1;
//line 265
___nl__1 = null;
//line 265
___nl__0 = null;
//line 265
if(true) return null;
}

private static Imm NL_print_call_priv(Imm ___arg__0, Imm ___arg__1, Imm ___arg__2, Imm ___arg__3) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();Imm ___nl__3 = ___arg__3.clone();
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
Dictionary<String, Imm> __function_map;
//line 269
___nl__4 = new ImmString("");
//line 269
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__1.toString().Equals(___nl__4.toString()));
//line 269
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 269
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 269
___nl__5 = new ImmString("_priv");
//line 269
___nl__5 = new ImmString(___nl__2.toString() + ___nl__5.toString());
//line 269
___nl__2 = ___nl__5;
//line 269
___nl__5 = null;
//line 269
if (true) {goto label_2;}
//line 269
label_2:
//line 269
___nl__4 = null;
//line 270
___nl__4 = new ImmString("");
//line 270
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__1.toString().Equals(___nl__4.toString()));
//line 270
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 270
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_4;}}
//line 270
___nl__1 = ___nl__0;
//line 270
if (true) {goto label_4;}
//line 270
label_4:
//line 270
___nl__4 = null;
//line 271
___nl__4 = generator_cs_NL.NL_get_class_name_priv(___nl__1);

//line 271
___nl__5 = new ImmString(".NL_");
//line 271
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 271
___nl__5 = null;
//line 271
___nl__5 = ___nl__2;
//line 271
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 271
___nl__5 = null;
//line 271
___nl__5 = new ImmString("(");
//line 271
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 271
___nl__5 = null;
//line 272
___nl__5 = new ImmDouble(0);
//line 273
___nl__7 = new ImmDouble(0);
//line 273
___nl__8 = new ImmDouble(1);
//line 273
___nl__9 = c_rt_lib_NL.NL_array_len(___nl__3);

//line 273
label_7:
//line 273
___nl__10 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))>=(Double.Parse(___nl__9.getValue().ToString())) );
//line 273
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_5;}}
//line 273
___nl__6 = (___nl__3 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 274
___nl__11 = new ImmDouble(0);
//line 274
___nl__11 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString())) ==((Double.Parse(___nl__11.getValue().ToString())))  );
//line 274
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11));
//line 274
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11));
//line 274
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_9;}}
//line 274
___nl__12 = new ImmString(",");
//line 274
___nl__4 = new ImmString(___nl__4.toString() + ___nl__12.toString());
//line 274
___nl__12 = null;
//line 274
if (true) {goto label_9;}
//line 274
label_9:
//line 274
___nl__11 = null;
//line 275
___nl__11 = new ImmDouble(1);
//line 275
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__11.getValue().ToString())));
//line 275
___nl__11 = null;
//line 276
___nl__11 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("ref"));
//line 276
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_11;}}
//line 278
___nl__11 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("val"));
//line 278
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_12;}}
//line 278
___nl__11 = new ImmString("NOMATCHALERT");
//line 278
___nl__11 = new ImmArray(new Imm[] {___nl__11,___nl__6,});
//line 278
c_rt_lib_NL.NL_die();
//line 276
label_11:
//line 276
___nl__12 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("ref"));
//line 277
___nl__13 = new ImmString("___ref___");
//line 277
___nl__14 = generator_cs_NL.NL_print_register_priv(___nl__12);

//line 277
___nl__13 = new ImmString(___nl__13.toString() + ___nl__14.toString());
//line 277
___nl__14 = null;
//line 277
___nl__4 = new ImmString(___nl__4.toString() + ___nl__13.toString());
//line 277
___nl__13 = null;
//line 277
___nl__12 = null;
//line 278
if (true) {goto label_10;}
//line 278
label_12:
//line 278
___nl__12 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("val"));
//line 279
___nl__13 = generator_cs_NL.NL_print_register_priv(___nl__12);

//line 279
___nl__4 = new ImmString(___nl__4.toString() + ___nl__13.toString());
//line 279
___nl__13 = null;
//line 279
___nl__12 = null;
//line 280
if (true) {goto label_10;}
//line 280
label_10:
//line 280
___nl__11 = null;
//line 281
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString())));
//line 281
if (true) {goto label_7;}
//line 281
label_5:
//line 281
___nl__6 = null;
//line 281
___nl__7 = null;
//line 281
___nl__8 = null;
//line 281
___nl__9 = null;
//line 281
___nl__10 = null;
//line 282
___nl__6 = new ImmString(")");
//line 282
___nl__6 = new ImmString(___nl__4.toString() + ___nl__6.toString());
//line 282
___nl__0 = null;
//line 282
___nl__1 = null;
//line 282
___nl__2 = null;
//line 282
___nl__3 = null;
//line 282
___nl__4 = null;
//line 282
___nl__5 = null;
//line 282
if(true) return ___nl__6;
//line 282
___nl__6 = null;
//line 282
___nl__4 = null;
//line 282
___nl__5 = null;
//line 282
___nl__0 = null;
//line 282
___nl__1 = null;
//line 282
___nl__2 = null;
//line 282
___nl__3 = null;
//line 282
if(true) return null;
}

private static Imm NL_print_call_ref_prepare_priv(Imm ___arg__0) {
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
//line 286
___nl__1 = new ImmString("");
//line 287
___nl__3 = new ImmDouble(0);
//line 287
___nl__4 = new ImmDouble(1);
//line 287
___nl__5 = c_rt_lib_NL.NL_array_len(___nl__0);

//line 287
label_3:
//line 287
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))>=(Double.Parse(___nl__5.getValue().ToString())) );
//line 287
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_1;}}
//line 287
___nl__2 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__3).getDoubleValue()];
//line 288
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("ref"));
//line 288
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_5;}}
//line 290
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("val"));
//line 290
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_6;}}
//line 290
___nl__7 = new ImmString("NOMATCHALERT");
//line 290
___nl__7 = new ImmArray(new Imm[] {___nl__7,___nl__2,});
//line 290
c_rt_lib_NL.NL_die();
//line 288
label_5:
//line 288
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("ref"));
//line 289
___nl__9 = new ImmString("___ref___");
//line 289
___nl__10 = generator_cs_NL.NL_print_register_priv(___nl__8);

//line 289
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString());
//line 289
___nl__10 = null;
//line 289
___nl__10 = new ImmString(" = new ImmRef(");
//line 289
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString());
//line 289
___nl__10 = null;
//line 289
___nl__10 = generator_cs_NL.NL_print_register_priv(___nl__8);

//line 289
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString());
//line 289
___nl__10 = null;
//line 289
___nl__10 = new ImmString(");");
//line 289
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString());
//line 289
___nl__10 = null;
//line 289
___nl__10 = string_NL.NL_lf();

//line 289
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString());
//line 289
___nl__10 = null;
//line 289
___nl__1 = new ImmString(___nl__1.toString() + ___nl__9.toString());
//line 289
___nl__9 = null;
//line 289
___nl__8 = null;
//line 290
if (true) {goto label_4;}
//line 290
label_6:
//line 290
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("val"));
//line 290
___nl__8 = null;
//line 291
if (true) {goto label_4;}
//line 291
label_4:
//line 291
___nl__7 = null;
//line 292
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString())));
//line 292
if (true) {goto label_3;}
//line 292
label_1:
//line 292
___nl__2 = null;
//line 292
___nl__3 = null;
//line 292
___nl__4 = null;
//line 292
___nl__5 = null;
//line 292
___nl__6 = null;
//line 293
___nl__0 = null;
//line 293
if(true) return ___nl__1;
//line 293
___nl__1 = null;
//line 293
___nl__0 = null;
//line 293
if(true) return null;
}

private static Imm NL_print_call_ref_setter_priv(Imm ___arg__0) {
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
//line 297
___nl__1 = new ImmString("");
//line 298
___nl__3 = new ImmDouble(0);
//line 298
___nl__4 = new ImmDouble(1);
//line 298
___nl__5 = c_rt_lib_NL.NL_array_len(___nl__0);

//line 298
label_3:
//line 298
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))>=(Double.Parse(___nl__5.getValue().ToString())) );
//line 298
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_1;}}
//line 298
___nl__2 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__3).getDoubleValue()];
//line 299
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("ref"));
//line 299
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_5;}}
//line 302
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("val"));
//line 302
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_6;}}
//line 302
___nl__7 = new ImmString("NOMATCHALERT");
//line 302
___nl__7 = new ImmArray(new Imm[] {___nl__7,___nl__2,});
//line 302
c_rt_lib_NL.NL_die();
//line 299
label_5:
//line 299
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("ref"));
//line 300
___nl__9 = new ImmString("___ref___");
//line 300
___nl__10 = generator_cs_NL.NL_print_register_priv(___nl__8);

//line 300
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString());
//line 300
___nl__10 = null;
//line 300
___nl__10 = new ImmString(".getValue()");
//line 300
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString());
//line 300
___nl__10 = null;
//line 301
___nl__10 = generator_cs_NL.NL_print_register_setter_priv(___nl__8,___nl__9);

//line 301
___nl__11 = new ImmString(";");
//line 301
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString());
//line 301
___nl__11 = null;
//line 301
___nl__11 = string_NL.NL_lf();

//line 301
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString());
//line 301
___nl__11 = null;
//line 301
___nl__1 = new ImmString(___nl__1.toString() + ___nl__10.toString());
//line 301
___nl__10 = null;
//line 301
___nl__9 = null;
//line 301
___nl__8 = null;
//line 302
if (true) {goto label_4;}
//line 302
label_6:
//line 302
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("val"));
//line 302
___nl__8 = null;
//line 303
if (true) {goto label_4;}
//line 303
label_4:
//line 303
___nl__7 = null;
//line 304
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString())));
//line 304
if (true) {goto label_3;}
//line 304
label_1:
//line 304
___nl__2 = null;
//line 304
___nl__3 = null;
//line 304
___nl__4 = null;
//line 304
___nl__5 = null;
//line 304
___nl__6 = null;
//line 305
___nl__0 = null;
//line 305
if(true) return ___nl__1;
//line 305
___nl__1 = null;
//line 305
___nl__0 = null;
//line 305
if(true) return null;
}

private static Imm NL_print_const_arr_priv(Imm ___arg__0, Imm ___arg__1) {
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
//line 309
___nl__2 = new ImmString("new Imm[] {");
//line 310
___nl__4 = new ImmDouble(0);
//line 310
___nl__5 = new ImmDouble(1);
//line 310
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__1);

//line 310
label_3:
//line 310
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) );
//line 310
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_1;}}
//line 310
___nl__3 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()];
//line 310
___nl__8 = generator_cs_NL.NL_print_const_value_priv(___nl__0,___nl__3);

//line 310
___nl__9 = new ImmString(",");
//line 310
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 310
___nl__9 = null;
//line 310
___nl__2 = new ImmString(___nl__2.toString() + ___nl__8.toString());
//line 310
___nl__8 = null;
//line 310
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString())));
//line 310
if (true) {goto label_3;}
//line 310
label_1:
//line 310
___nl__3 = null;
//line 310
___nl__4 = null;
//line 310
___nl__5 = null;
//line 310
___nl__6 = null;
//line 310
___nl__7 = null;
//line 311
___nl__3 = new ImmString("}");
//line 311
___nl__3 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 311
___nl__0 = null;
//line 311
___nl__1 = null;
//line 311
___nl__2 = null;
//line 311
if(true) return ___nl__3;
//line 311
___nl__3 = null;
//line 311
___nl__2 = null;
//line 311
___nl__0 = null;
//line 311
___nl__1 = null;
//line 311
if(true) return null;
}

private static Imm NL_print_const_hash_priv(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();
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
//line 315
___nl__2 = generator_cs_NL.NL_print_hash_name_priv();

//line 315
___nl__3 = new ImmString(" = new Dictionary<String, Imm>();");
//line 315
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 315
___nl__3 = null;
//line 315
___nl__3 = string_NL.NL_lf();

//line 315
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 315
___nl__3 = null;
//line 316
___nl__5 = c_rt_lib_NL.NL_init_iter(___nl__1);

//line 316
label_3:
//line 316
___nl__3 = c_rt_lib_NL.NL_is_end_hash(___nl__5);

//line 316
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_1;}}
//line 316
___nl__3 = c_rt_lib_NL.NL_get_key_iter(___nl__5);

//line 316
___nl__4 = c_rt_lib_NL.NL_hash_get_value(___nl__1,___nl__3);

//line 316
___nl__6 = generator_cs_NL.NL_print_hash_name_priv();

//line 316
___nl__7 = new ImmString(".Add(\"");
//line 316
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 316
___nl__7 = null;
//line 316
___nl__7 = generator_cs_NL.NL_escape_string_priv(___nl__3);

//line 316
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 316
___nl__7 = null;
//line 316
___nl__7 = new ImmString("\",");
//line 316
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 316
___nl__7 = null;
//line 316
___nl__7 = generator_cs_NL.NL_print_const_value_priv(___nl__0,___nl__4);

//line 316
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 316
___nl__7 = null;
//line 316
___nl__7 = new ImmString(");");
//line 316
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 316
___nl__7 = null;
//line 316
___nl__7 = string_NL.NL_lf();

//line 316
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 316
___nl__7 = null;
//line 316
___nl__2 = new ImmString(___nl__2.toString() + ___nl__6.toString());
//line 316
___nl__6 = null;
//line 316
___nl__5 = c_rt_lib_NL.NL_next_iter(___nl__5);

//line 316
if (true) {goto label_3;}
//line 316
label_1:
//line 316
___nl__3 = null;
//line 316
___nl__4 = null;
//line 316
___nl__5 = null;
//line 317
___nl__4 = new ImmString("new ImmHash(");
//line 317
___nl__5 = generator_cs_NL.NL_print_hash_name_priv();

//line 317
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 317
___nl__5 = null;
//line 317
___nl__5 = new ImmString(")");
//line 317
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 317
___nl__5 = null;
//line 317
___nl__3 = generator_cs_NL.NL_print_register_setter_priv(___nl__0,___nl__4);

//line 317
___nl__4 = null;
//line 317
___nl__3 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 317
___nl__0 = null;
//line 317
___nl__1 = null;
//line 317
___nl__2 = null;
//line 317
if(true) return ___nl__3;
//line 317
___nl__3 = null;
//line 317
___nl__2 = null;
//line 317
___nl__0 = null;
//line 317
___nl__1 = null;
//line 317
if(true) return null;
}

private static Imm NL_print_const_ov_priv(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();
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
//line 321
___nl__2 = new ImmString("");
//line 322
___nl__3 = ov_NL.NL_has_value(___nl__1);

//line 322
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 322
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 323
___nl__4 = new ImmString("new OV(\"");
//line 323
___nl__6 = ov_NL.NL_get_element(___nl__1);

//line 323
___nl__5 = generator_cs_NL.NL_escape_string_priv(___nl__6);

//line 323
___nl__6 = null;
//line 323
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 323
___nl__5 = null;
//line 323
___nl__5 = new ImmString("\", ");
//line 323
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 323
___nl__5 = null;
//line 323
___nl__6 = ov_NL.NL_get_value(___nl__1);

//line 323
___nl__5 = generator_cs_NL.NL_print_const_value_priv(___nl__0,___nl__6);

//line 323
___nl__6 = null;
//line 323
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 323
___nl__5 = null;
//line 323
___nl__5 = new ImmString(")");
//line 323
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 323
___nl__5 = null;
//line 323
___nl__2 = ___nl__4;
//line 323
___nl__4 = null;
//line 324
if (true) {goto label_1;}
//line 324
label_2:
//line 325
___nl__4 = new ImmString("new OV(\"");
//line 325
___nl__6 = ov_NL.NL_get_element(___nl__1);

//line 325
___nl__5 = generator_cs_NL.NL_escape_string_priv(___nl__6);

//line 325
___nl__6 = null;
//line 325
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 325
___nl__5 = null;
//line 325
___nl__5 = new ImmString("\", null)");
//line 325
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 325
___nl__5 = null;
//line 325
___nl__2 = ___nl__4;
//line 325
___nl__4 = null;
//line 326
if (true) {goto label_1;}
//line 326
label_1:
//line 326
___nl__3 = null;
//line 327
___nl__0 = null;
//line 327
___nl__1 = null;
//line 327
if(true) return ___nl__2;
//line 327
___nl__2 = null;
//line 327
___nl__0 = null;
//line 327
___nl__1 = null;
//line 327
if(true) return null;
}

private static Imm NL_print_const_value_priv(Imm ___arg__0, Imm ___arg__1) {
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
//line 331
___nl__2 = nl_NL.NL_is_sim(___nl__1);

//line 331
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 331
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_4;}}
//line 331
___nl__5 = ptd_NL.NL_sim();

//line 331
___nl__4 = ptd_NL.NL_ensure(___nl__5,___nl__1);

//line 331
___nl__5 = null;
//line 331
___nl__2 = string_utils_NL.NL_is_integer(___nl__4);

//line 331
___nl__4 = null;
//line 331
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_4;}}
//line 331
___nl__5 = ptd_NL.NL_sim();

//line 331
___nl__4 = ptd_NL.NL_ensure(___nl__5,___nl__1);

//line 331
___nl__5 = null;
//line 331
___nl__2 = string_utils_NL.NL_is_float(___nl__4);

//line 331
___nl__4 = null;
//line 331
label_4:
//line 331
___nl__3 = null;
//line 331
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 331
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 333
___nl__3 = new ImmString("new ImmDouble(");
//line 333
___nl__3 = new ImmString(___nl__3.toString() + ___nl__1.toString());
//line 333
___nl__4 = new ImmString(")");
//line 333
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 333
___nl__4 = null;
//line 333
___nl__0 = null;
//line 333
___nl__1 = null;
//line 333
___nl__2 = null;
//line 333
if(true) return ___nl__3;
//line 333
___nl__3 = null;
//line 334
if (true) {goto label_1;}
//line 334
label_2:
//line 334
___nl__2 = nl_NL.NL_is_sim(___nl__1);

//line 334
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 334
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_5;}}
//line 335
___nl__3 = new ImmString("new ImmString(\"");
//line 335
___nl__4 = generator_cs_NL.NL_escape_string_priv(___nl__1);

//line 335
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 335
___nl__4 = null;
//line 335
___nl__4 = new ImmString("\")");
//line 335
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 335
___nl__4 = null;
//line 335
___nl__0 = null;
//line 335
___nl__1 = null;
//line 335
___nl__2 = null;
//line 335
if(true) return ___nl__3;
//line 335
___nl__3 = null;
//line 336
if (true) {goto label_1;}
//line 336
label_5:
//line 336
___nl__2 = nl_NL.NL_is_array(___nl__1);

//line 336
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 336
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_6;}}
//line 337
___nl__3 = generator_cs_NL.NL_print_const_arr_priv(___nl__0,___nl__1);

//line 337
___nl__0 = null;
//line 337
___nl__1 = null;
//line 337
___nl__2 = null;
//line 337
if(true) return ___nl__3;
//line 337
___nl__3 = null;
//line 338
if (true) {goto label_1;}
//line 338
label_6:
//line 338
___nl__2 = nl_NL.NL_is_hash(___nl__1);

//line 338
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 338
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_7;}}
//line 339
___nl__3 = generator_cs_NL.NL_print_const_hash_priv(___nl__0,___nl__1);

//line 339
___nl__0 = null;
//line 339
___nl__1 = null;
//line 339
___nl__2 = null;
//line 339
if(true) return ___nl__3;
//line 339
___nl__3 = null;
//line 340
if (true) {goto label_1;}
//line 340
label_7:
//line 340
___nl__2 = nl_NL.NL_is_variant(___nl__1);

//line 340
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 340
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_8;}}
//line 341
___nl__3 = generator_cs_NL.NL_print_const_ov_priv(___nl__0,___nl__1);

//line 341
___nl__0 = null;
//line 341
___nl__1 = null;
//line 341
___nl__2 = null;
//line 341
if(true) return ___nl__3;
//line 341
___nl__3 = null;
//line 342
if (true) {goto label_1;}
//line 342
label_8:
//line 343
___nl__3 = new ImmArray(new Imm[0]);
//line 343
c_rt_lib_NL.NL_die();
//line 343
___nl__3 = null;
//line 344
if (true) {goto label_1;}
//line 344
label_1:
//line 344
___nl__2 = null;
//line 344
___nl__0 = null;
//line 344
___nl__1 = null;
//line 344
if(true) return null;
}

private static Imm NL_print_goto_priv(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 348
___nl__1 = new ImmString("if (true) {goto ");
//line 348
___nl__1 = new ImmString(___nl__1.toString() + ___nl__0.toString());
//line 348
___nl__2 = new ImmString(";}");
//line 348
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 348
___nl__2 = null;
//line 348
___nl__0 = null;
//line 348
if(true) return ___nl__1;
//line 348
___nl__1 = null;
//line 348
___nl__0 = null;
//line 348
if(true) return null;
}

private static Imm NL_print_hash_priv(Imm ___arg__0) {
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
//line 352
___nl__1 = generator_cs_NL.NL_print_hash_name_priv();

//line 352
___nl__2 = new ImmString(" = new Dictionary<String, Imm>();");
//line 352
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 352
___nl__2 = null;
//line 352
___nl__2 = string_NL.NL_lf();

//line 352
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 352
___nl__2 = null;
//line 353
___nl__2 = ((ImmHash)___nl__0).getHashValue()["src"];
//line 353
___nl__4 = new ImmDouble(0);
//line 353
___nl__5 = new ImmDouble(1);
//line 353
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__2);

//line 353
label_3:
//line 353
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) );
//line 353
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_1;}}
//line 353
___nl__3 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()];
//line 353
___nl__8 = generator_cs_NL.NL_print_hash_name_priv();

//line 353
___nl__9 = new ImmString(".Add(\"");
//line 353
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 353
___nl__9 = null;
//line 353
___nl__10 = ((ImmHash)___nl__3).getHashValue()["key"];
//line 353
___nl__9 = generator_cs_NL.NL_escape_string_priv(___nl__10);

//line 353
___nl__10 = null;
//line 353
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 353
___nl__9 = null;
//line 353
___nl__9 = new ImmString("\",");
//line 353
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 353
___nl__9 = null;
//line 353
___nl__10 = ((ImmHash)___nl__3).getHashValue()["val"];
//line 353
___nl__9 = generator_cs_NL.NL_print_register_priv(___nl__10);

//line 353
___nl__10 = null;
//line 353
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 353
___nl__9 = null;
//line 353
___nl__9 = new ImmString(");");
//line 353
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 353
___nl__9 = null;
//line 353
___nl__9 = string_NL.NL_lf();

//line 353
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 353
___nl__9 = null;
//line 353
___nl__1 = new ImmString(___nl__1.toString() + ___nl__8.toString());
//line 353
___nl__8 = null;
//line 353
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString())));
//line 353
if (true) {goto label_3;}
//line 353
label_1:
//line 353
___nl__2 = null;
//line 353
___nl__3 = null;
//line 353
___nl__4 = null;
//line 353
___nl__5 = null;
//line 353
___nl__6 = null;
//line 353
___nl__7 = null;
//line 354
___nl__0 = null;
//line 354
if(true) return ___nl__1;
//line 354
___nl__1 = null;
//line 354
___nl__0 = null;
//line 354
if(true) return null;
}

private static Imm NL_SINGLETON_print_hash_name_priv() {

Imm ___nl__0 = null;
ImmRef ___ref______nl__0 = null;
Dictionary<String, Imm> __function_map;
//line 358
___nl__0 = new ImmString("__function_map");
//line 358
if(true) return ___nl__0;
//line 358
___nl__0 = null;
//line 358
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_print_hash_name_priv = null;
private static Imm NL_print_hash_name_priv() {
	if (value__singleton__NL_SINGLETON_print_hash_name_priv == null) {
		value__singleton__NL_SINGLETON_print_hash_name_priv = NL_SINGLETON_print_hash_name_priv();
	}
	return value__singleton__NL_SINGLETON_print_hash_name_priv;
}
private static Imm NL_print_get_hash_value_priv(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 362
___nl__1 = new ImmString("((ImmHash)");
//line 362
___nl__3 = ((ImmHash)___nl__0).getHashValue()["src"];
//line 362
___nl__2 = generator_cs_NL.NL_print_register_priv(___nl__3);

//line 362
___nl__3 = null;
//line 362
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 362
___nl__2 = null;
//line 362
___nl__2 = new ImmString(").getHashValue()[\"");
//line 362
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 362
___nl__2 = null;
//line 362
___nl__3 = ((ImmHash)___nl__0).getHashValue()["key"];
//line 362
___nl__2 = generator_cs_NL.NL_escape_string_priv(___nl__3);

//line 362
___nl__3 = null;
//line 362
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 362
___nl__2 = null;
//line 362
___nl__2 = new ImmString("\"]");
//line 362
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 362
___nl__2 = null;
//line 362
___nl__0 = null;
//line 362
if(true) return ___nl__1;
//line 362
___nl__1 = null;
//line 362
___nl__0 = null;
//line 362
if(true) return null;
}

private static Imm NL_print_set_hash_value_priv(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 366
___nl__1 = new ImmString("((ImmHash)");
//line 366
___nl__3 = ((ImmHash)___nl__0).getHashValue()["src"];
//line 366
___nl__2 = generator_cs_NL.NL_print_register_priv(___nl__3);

//line 366
___nl__3 = null;
//line 366
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 366
___nl__2 = null;
//line 366
___nl__2 = new ImmString(").set(\"");
//line 366
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 366
___nl__2 = null;
//line 366
___nl__3 = ((ImmHash)___nl__0).getHashValue()["key"];
//line 366
___nl__2 = generator_cs_NL.NL_escape_string_priv(___nl__3);

//line 366
___nl__3 = null;
//line 366
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 366
___nl__2 = null;
//line 366
___nl__2 = new ImmString("\", ");
//line 366
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 366
___nl__2 = null;
//line 367
___nl__3 = ((ImmHash)___nl__0).getHashValue()["val"];
//line 367
___nl__2 = generator_cs_NL.NL_print_register_priv(___nl__3);

//line 367
___nl__3 = null;
//line 367
___nl__3 = new ImmString(")");
//line 367
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 367
___nl__3 = null;
//line 367
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 367
___nl__2 = null;
//line 368
___nl__0 = null;
//line 368
if(true) return ___nl__1;
//line 368
___nl__1 = null;
//line 368
___nl__0 = null;
//line 368
if(true) return null;
}

private static Imm NL_print_ov_mk_priv(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
ImmRef ___ref______nl__6 = null;
ImmRef ___ref______nl__7 = null;
ImmRef ___ref______nl__8 = null;
Dictionary<String, Imm> __function_map;
//line 372
___nl__1 = new ImmString("");
//line 373
___nl__2 = ((ImmHash)___nl__0).getHashValue()["src"];
//line 373
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("emp"));
//line 373
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 373
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 373
___nl__2 = ((ImmHash)___nl__0).getHashValue()["name"];
//line 373
___nl__4 = new ImmString("TRUE");
//line 373
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__4.toString()));
//line 373
___nl__4 = null;
//line 373
label_3:
//line 373
___nl__3 = null;
//line 373
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 373
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 374
___nl__3 = new ImmString("c_rt_lib_NL.NL_get_true()");
//line 374
___nl__1 = ___nl__3;
//line 374
___nl__3 = null;
//line 375
if (true) {goto label_1;}
//line 375
label_2:
//line 375
___nl__2 = ((ImmHash)___nl__0).getHashValue()["src"];
//line 375
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("emp"));
//line 375
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 375
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_5;}}
//line 375
___nl__2 = ((ImmHash)___nl__0).getHashValue()["name"];
//line 375
___nl__4 = new ImmString("FALSE");
//line 375
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__4.toString()));
//line 375
___nl__4 = null;
//line 375
label_5:
//line 375
___nl__3 = null;
//line 375
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 375
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_4;}}
//line 376
___nl__3 = new ImmString("c_rt_lib_NL.NL_get_false()");
//line 376
___nl__1 = ___nl__3;
//line 376
___nl__3 = null;
//line 377
if (true) {goto label_1;}
//line 377
label_4:
//line 378
___nl__3 = ((ImmHash)___nl__0).getHashValue()["src"];
//line 378
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("arg"));
//line 378
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_7;}}
//line 380
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("emp"));
//line 380
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_8;}}
//line 380
___nl__4 = new ImmString("NOMATCHALERT");
//line 380
___nl__4 = new ImmArray(new Imm[] {___nl__4,___nl__3,});
//line 380
c_rt_lib_NL.NL_die();
//line 378
label_7:
//line 378
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("arg"));
//line 379
___nl__6 = new ImmString("c_rt_lib_NL.NL_ov_mk_arg(new ImmString(\"");
//line 379
___nl__8 = ((ImmHash)___nl__0).getHashValue()["name"];
//line 379
___nl__7 = generator_cs_NL.NL_escape_string_priv(___nl__8);

//line 379
___nl__8 = null;
//line 379
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 379
___nl__7 = null;
//line 379
___nl__7 = new ImmString("\"), ");
//line 379
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 379
___nl__7 = null;
//line 379
___nl__7 = generator_cs_NL.NL_print_register_priv(___nl__5);

//line 379
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 379
___nl__7 = null;
//line 379
___nl__7 = new ImmString(")");
//line 379
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 379
___nl__7 = null;
//line 379
___nl__1 = ___nl__6;
//line 379
___nl__6 = null;
//line 379
___nl__5 = null;
//line 380
if (true) {goto label_6;}
//line 380
label_8:
//line 381
___nl__5 = new ImmString("c_rt_lib_NL.NL_ov_mk_none(new ImmString(\"");
//line 381
___nl__7 = ((ImmHash)___nl__0).getHashValue()["name"];
//line 381
___nl__6 = generator_cs_NL.NL_escape_string_priv(___nl__7);

//line 381
___nl__7 = null;
//line 381
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 381
___nl__6 = null;
//line 381
___nl__6 = new ImmString("\"))");
//line 381
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 381
___nl__6 = null;
//line 381
___nl__1 = ___nl__5;
//line 381
___nl__5 = null;
//line 382
if (true) {goto label_6;}
//line 382
label_6:
//line 382
___nl__3 = null;
//line 382
___nl__4 = null;
//line 383
if (true) {goto label_1;}
//line 383
label_1:
//line 383
___nl__2 = null;
//line 384
___nl__3 = ((ImmHash)___nl__0).getHashValue()["dest"];
//line 384
___nl__2 = generator_cs_NL.NL_print_register_setter_priv(___nl__3,___nl__1);

//line 384
___nl__3 = null;
//line 384
___nl__3 = new ImmString(";");
//line 384
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 384
___nl__3 = null;
//line 384
___nl__0 = null;
//line 384
___nl__1 = null;
//line 384
if(true) return ___nl__2;
//line 384
___nl__2 = null;
//line 384
___nl__1 = null;
//line 384
___nl__0 = null;
//line 384
if(true) return null;
}

private static Imm NL_print_register_priv(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 388
___nl__1 = new ImmString("___nl__");
//line 388
___nl__1 = new ImmString(___nl__1.toString() + ___nl__0.toString());
//line 388
___nl__0 = null;
//line 388
if(true) return ___nl__1;
//line 388
___nl__1 = null;
//line 388
___nl__0 = null;
//line 388
if(true) return null;
}

private static Imm NL_SINGLETON_print_getter_priv() {

Imm ___nl__0 = null;
ImmRef ___ref______nl__0 = null;
Dictionary<String, Imm> __function_map;
//line 392
___nl__0 = new ImmString(".getValue()");
//line 392
if(true) return ___nl__0;
//line 392
___nl__0 = null;
//line 392
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_print_getter_priv = null;
private static Imm NL_print_getter_priv() {
	if (value__singleton__NL_SINGLETON_print_getter_priv == null) {
		value__singleton__NL_SINGLETON_print_getter_priv = NL_SINGLETON_print_getter_priv();
	}
	return value__singleton__NL_SINGLETON_print_getter_priv;
}
private static Imm NL_print_register_setter_priv(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 396
___nl__2 = new ImmString("");
//line 396
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__2.toString()));
//line 396
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 396
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 396
___nl__3 = new ImmString("");
//line 396
___nl__3 = new ImmString(___nl__1.toString() + ___nl__3.toString());
//line 396
___nl__0 = null;
//line 396
___nl__1 = null;
//line 396
___nl__2 = null;
//line 396
if(true) return ___nl__3;
//line 396
___nl__3 = null;
//line 396
if (true) {goto label_2;}
//line 396
label_2:
//line 396
___nl__2 = null;
//line 397
___nl__2 = generator_cs_NL.NL_print_register_priv(___nl__0);

//line 397
___nl__3 = new ImmString(" = ");
//line 397
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 397
___nl__3 = null;
//line 397
___nl__2 = new ImmString(___nl__2.toString() + ___nl__1.toString());
//line 397
___nl__0 = null;
//line 397
___nl__1 = null;
//line 397
if(true) return ___nl__2;
//line 397
___nl__2 = null;
//line 397
___nl__0 = null;
//line 397
___nl__1 = null;
//line 397
if(true) return null;
}

private static Imm NL_print_return_priv(Imm ___arg__0) {
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
//line 401
___nl__1 = new ImmString("");
//line 402
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("val"));
//line 402
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 404
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("emp"));
//line 404
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_3;}}
//line 404
___nl__2 = new ImmString("NOMATCHALERT");
//line 404
___nl__2 = new ImmArray(new Imm[] {___nl__2,___nl__0,});
//line 404
c_rt_lib_NL.NL_die();
//line 402
label_2:
//line 402
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("val"));
//line 403
___nl__4 = new ImmString("return ");
//line 403
___nl__5 = generator_cs_NL.NL_print_register_priv(___nl__3);

//line 403
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 403
___nl__5 = null;
//line 403
___nl__5 = new ImmString(";");
//line 403
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 403
___nl__5 = null;
//line 403
___nl__1 = ___nl__4;
//line 403
___nl__4 = null;
//line 403
___nl__3 = null;
//line 404
if (true) {goto label_1;}
//line 404
label_3:
//line 405
___nl__3 = new ImmString("return null;");
//line 405
___nl__1 = ___nl__3;
//line 405
___nl__3 = null;
//line 406
if (true) {goto label_1;}
//line 406
label_1:
//line 406
___nl__2 = null;
//line 407
___nl__2 = new ImmString("if(true) ");
//line 407
___nl__2 = new ImmString(___nl__2.toString() + ___nl__1.toString());
//line 407
___nl__0 = null;
//line 407
___nl__1 = null;
//line 407
if(true) return ___nl__2;
//line 407
___nl__2 = null;
//line 407
___nl__1 = null;
//line 407
___nl__0 = null;
//line 407
if(true) return null;
}

private static Imm NL_print_una_op_priv(Imm ___arg__0) {
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
//line 411
___nl__1 = new ImmString("");
//line 412
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 412
___nl__3 = new ImmString("!");
//line 412
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 412
___nl__3 = null;
//line 412
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 412
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 413
___nl__3 = new ImmString("c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(");
//line 413
___nl__5 = ((ImmHash)___nl__0).getHashValue()["src"];
//line 413
___nl__4 = generator_cs_NL.NL_print_register_priv(___nl__5);

//line 413
___nl__5 = null;
//line 413
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 413
___nl__4 = null;
//line 413
___nl__4 = new ImmString("))");
//line 413
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 413
___nl__4 = null;
//line 413
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString());
//line 413
___nl__3 = null;
//line 414
if (true) {goto label_1;}
//line 414
label_2:
//line 415
___nl__3 = new ImmString("new ImmDouble(");
//line 415
___nl__4 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 415
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 415
___nl__4 = null;
//line 415
___nl__4 = new ImmString("((ImmDouble)");
//line 415
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 415
___nl__4 = null;
//line 415
___nl__5 = ((ImmHash)___nl__0).getHashValue()["src"];
//line 415
___nl__4 = generator_cs_NL.NL_print_register_priv(___nl__5);

//line 415
___nl__5 = null;
//line 415
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 415
___nl__4 = null;
//line 415
___nl__4 = new ImmString(").getDoubleValue())");
//line 415
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 415
___nl__4 = null;
//line 415
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString());
//line 415
___nl__3 = null;
//line 416
if (true) {goto label_1;}
//line 416
label_1:
//line 416
___nl__2 = null;
//line 417
___nl__3 = ((ImmHash)___nl__0).getHashValue()["dest"];
//line 417
___nl__2 = generator_cs_NL.NL_print_register_setter_priv(___nl__3,___nl__1);

//line 417
___nl__3 = null;
//line 417
___nl__3 = new ImmString(";");
//line 417
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 417
___nl__3 = null;
//line 417
___nl__0 = null;
//line 417
___nl__1 = null;
//line 417
if(true) return ___nl__2;
//line 417
___nl__2 = null;
//line 417
___nl__1 = null;
//line 417
___nl__0 = null;
//line 417
if(true) return null;
}

}
}