using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class generator_java_NL {

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
___nl__2 = generator_java_NL.NL_print_package_name_priv();

//line 17
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 17
___nl__2 = null;
//line 18
___nl__2 = generator_java_NL.NL_print_imports_priv(___nl__0);

//line 18
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 18
___nl__2 = null;
//line 19
___nl__3 = ((ImmHash)___nl__0).getHashValue()["module_name"];
//line 19
___nl__2 = generator_java_NL.NL_print_class_begin_priv(___nl__3);

//line 19
___nl__3 = null;
//line 19
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 19
___nl__2 = null;
//line 20
___nl__2 = ((ImmHash)___nl__0).getHashValue()["functions"];
//line 20
___nl__4 = new ImmDouble(0);
//line 20
___nl__5 = new ImmDouble(1);
//line 20
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__2);

//line 20
label_3:
//line 20
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) );
//line 20
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_1;}}
//line 20
___nl__3 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()];
//line 20
___nl__9 = ((ImmHash)___nl__0).getHashValue()["module_name"];
//line 20
___nl__8 = generator_java_NL.NL_print_function_or_singleton_priv(___nl__3,___nl__9);

//line 20
___nl__9 = null;
//line 20
___nl__1 = new ImmString(___nl__1.toString() + ___nl__8.toString());
//line 20
___nl__8 = null;
//line 20
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString())));
//line 20
if (true) {goto label_3;}
//line 20
label_1:
//line 20
___nl__2 = null;
//line 20
___nl__3 = null;
//line 20
___nl__4 = null;
//line 20
___nl__5 = null;
//line 20
___nl__6 = null;
//line 20
___nl__7 = null;
//line 21
___nl__2 = generator_java_NL.NL_print_class_end_priv();

//line 21
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 21
___nl__2 = null;
//line 22
___nl__0 = null;
//line 22
if(true) return ___nl__1;
//line 22
___nl__1 = null;
//line 22
___nl__0 = null;
//line 22
if(true) return null;
}

private static Imm NL_SINGLETON_print_package_name_priv() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 26
___nl__0 = new ImmString("package com.atinea.nianio;");
//line 26
___nl__1 = string_NL.NL_lf();

//line 26
___nl__0 = new ImmString(___nl__0.toString() + ___nl__1.toString());
//line 26
___nl__1 = null;
//line 26
___nl__1 = string_NL.NL_lf();

//line 26
___nl__0 = new ImmString(___nl__0.toString() + ___nl__1.toString());
//line 26
___nl__1 = null;
//line 26
if(true) return ___nl__0;
//line 26
___nl__0 = null;
//line 26
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_print_package_name_priv = null;
private static Imm NL_print_package_name_priv() {
	if (value__singleton__NL_SINGLETON_print_package_name_priv == null) {
		value__singleton__NL_SINGLETON_print_package_name_priv = NL_SINGLETON_print_package_name_priv();
	}
	return value__singleton__NL_SINGLETON_print_package_name_priv;
}
private static Imm NL_print_imports_priv(Imm ___arg__0) {
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
//line 30
___nl__1 = new ImmString("");
//line 31
___nl__2 = new ImmString("import java.util.Map;");
//line 31
___nl__3 = string_NL.NL_lf();

//line 31
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 31
___nl__3 = null;
//line 31
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 31
___nl__2 = null;
//line 32
___nl__2 = new ImmString("import java.util.HashMap;");
//line 32
___nl__3 = string_NL.NL_lf();

//line 32
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 32
___nl__3 = null;
//line 32
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 32
___nl__2 = null;
//line 33
___nl__2 = ((ImmHash)___nl__0).getHashValue()["imports"];
//line 33
___nl__4 = new ImmDouble(0);
//line 33
___nl__5 = new ImmDouble(1);
//line 33
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__2);

//line 33
label_3:
//line 33
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) );
//line 33
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_1;}}
//line 33
___nl__3 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()];
//line 34
___nl__8 = new ImmString("import com.atinea.nianio.");
//line 34
___nl__9 = generator_java_NL.NL_get_class_name_priv(___nl__3);

//line 34
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 34
___nl__9 = null;
//line 34
___nl__9 = new ImmString(";");
//line 34
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 34
___nl__9 = null;
//line 34
___nl__9 = string_NL.NL_lf();

//line 34
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 34
___nl__9 = null;
//line 34
___nl__1 = new ImmString(___nl__1.toString() + ___nl__8.toString());
//line 34
___nl__8 = null;
//line 35
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString())));
//line 35
if (true) {goto label_3;}
//line 35
label_1:
//line 35
___nl__2 = null;
//line 35
___nl__3 = null;
//line 35
___nl__4 = null;
//line 35
___nl__5 = null;
//line 35
___nl__6 = null;
//line 35
___nl__7 = null;
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

private static Imm NL_get_class_name_priv(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 40
___nl__1 = new ImmString("_NL");
//line 40
___nl__1 = new ImmString(___nl__0.toString() + ___nl__1.toString());
//line 40
___nl__0 = null;
//line 40
if(true) return ___nl__1;
//line 40
___nl__1 = null;
//line 40
___nl__0 = null;
//line 40
if(true) return null;
}

private static Imm NL_print_class_begin_priv(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 44
___nl__1 = new ImmString("public class ");
//line 44
___nl__2 = generator_java_NL.NL_get_class_name_priv(___nl__0);

//line 44
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 44
___nl__2 = null;
//line 44
___nl__2 = new ImmString(" {");
//line 44
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 44
___nl__2 = null;
//line 44
___nl__2 = string_NL.NL_lf();

//line 44
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 44
___nl__2 = null;
//line 44
___nl__0 = null;
//line 44
if(true) return ___nl__1;
//line 44
___nl__1 = null;
//line 44
___nl__0 = null;
//line 44
if(true) return null;
}

private static Imm NL_SINGLETON_print_class_end_priv() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 48
___nl__0 = string_NL.NL_lf();

//line 48
___nl__1 = new ImmString("}");
//line 48
___nl__0 = new ImmString(___nl__0.toString() + ___nl__1.toString());
//line 48
___nl__1 = null;
//line 48
if(true) return ___nl__0;
//line 48
___nl__0 = null;
//line 48
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
//line 52
___nl__1 = new ImmString("");
//line 53
___nl__2 = ((ImmHash)___nl__0).getHashValue()["access"];
//line 53
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("pub"));
//line 53
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 54
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("priv"));
//line 54
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 54
___nl__3 = new ImmString("NOMATCHALERT");
//line 54
___nl__3 = new ImmArray(new Imm[] {___nl__3,___nl__2,});
//line 54
c_rt_lib_NL.NL_die();
//line 53
label_2:
//line 54
if (true) {goto label_1;}
//line 54
label_3:
//line 55
___nl__4 = new ImmString("_priv");
//line 55
___nl__1 = ___nl__4;
//line 55
___nl__4 = null;
//line 56
if (true) {goto label_1;}
//line 56
label_1:
//line 56
___nl__2 = null;
//line 56
___nl__3 = null;
//line 57
___nl__2 = ((ImmHash)___nl__0).getHashValue()["name"];
//line 57
___nl__2 = new ImmString(___nl__2.toString() + ___nl__1.toString());
//line 57
___nl__3 = new ImmString("_nl");
//line 57
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 57
___nl__3 = null;
//line 57
___nl__0 = null;
//line 57
___nl__1 = null;
//line 57
if(true) return ___nl__2;
//line 57
___nl__2 = null;
//line 57
___nl__1 = null;
//line 57
___nl__0 = null;
//line 57
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
//line 61
___nl__1 = new ImmString("");
//line 62
___nl__2 = ((ImmHash)___nl__0).getHashValue()["access"];
//line 62
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("pub"));
//line 62
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 64
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("priv"));
//line 64
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 64
___nl__3 = new ImmString("NOMATCHALERT");
//line 64
___nl__3 = new ImmArray(new Imm[] {___nl__3,___nl__2,});
//line 64
c_rt_lib_NL.NL_die();
//line 62
label_2:
//line 63
___nl__4 = new ImmString("public");
//line 63
___nl__1 = ___nl__4;
//line 63
___nl__4 = null;
//line 64
if (true) {goto label_1;}
//line 64
label_3:
//line 65
___nl__4 = new ImmString("private");
//line 65
___nl__1 = ___nl__4;
//line 65
___nl__4 = null;
//line 66
if (true) {goto label_1;}
//line 66
label_1:
//line 66
___nl__2 = null;
//line 66
___nl__3 = null;
//line 67
___nl__2 = new ImmString(" static Imm ");
//line 67
___nl__2 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 67
___nl__3 = generator_java_NL.NL_get_function_name_priv(___nl__0);

//line 67
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 67
___nl__3 = null;
//line 67
___nl__0 = null;
//line 67
___nl__1 = null;
//line 67
if(true) return ___nl__2;
//line 67
___nl__2 = null;
//line 67
___nl__1 = null;
//line 67
___nl__0 = null;
//line 67
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
//line 71
___nl__2 = new ImmString("\\");
//line 71
___nl__3 = new ImmString("\\\\");
//line 71
___nl__1 = string_NL.NL_replace(___nl__0,___nl__2,___nl__3);

//line 71
___nl__3 = null;
//line 71
___nl__2 = null;
//line 71
___nl__0 = ___nl__1;
//line 71
___nl__1 = null;
//line 72
___nl__2 = new ImmString("\"");
//line 72
___nl__3 = new ImmString("\\\"");
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
___nl__3 = new ImmDouble(13);
//line 73
___nl__2 = string_NL.NL_chr(___nl__3);

//line 73
___nl__3 = null;
//line 73
___nl__3 = string_NL.NL_lf();

//line 73
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 73
___nl__3 = null;
//line 73
___nl__3 = new ImmString("\\r\\n");
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
___nl__2 = string_NL.NL_lf();

//line 74
___nl__3 = new ImmString("\\n");
//line 74
___nl__1 = string_NL.NL_replace(___nl__0,___nl__2,___nl__3);

//line 74
___nl__3 = null;
//line 74
___nl__2 = null;
//line 74
___nl__0 = null;
//line 74
if(true) return ___nl__1;
//line 74
___nl__1 = null;
//line 74
___nl__0 = null;
//line 74
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
//line 77
___nl__2 = ((ImmHash)___nl__0).getHashValue()["args_type"];
//line 77
___nl__1 = array_NL.NL_len(___nl__2);

//line 77
___nl__2 = null;
//line 77
___nl__2 = new ImmDouble(0);
//line 77
___nl__1 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__1.getValue().ToString()))>(Double.Parse(___nl__2.getValue().ToString())) );
//line 77
___nl__2 = null;
//line 77
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1));
//line 77
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_2;}}
//line 77
___nl__2 = c_rt_lib_NL.NL_get_false();
//line 77
___nl__0 = null;
//line 77
___nl__1 = null;
//line 77
if(true) return ___nl__2;
//line 77
___nl__2 = null;
//line 77
if (true) {goto label_2;}
//line 77
label_2:
//line 77
___nl__1 = null;
//line 78
___nl__1 = ((ImmHash)___nl__0).getHashValue()["annotation"];
//line 78
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("math"));
//line 78
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1));
//line 78
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_4;}}
//line 78
___nl__2 = c_rt_lib_NL.NL_get_true();
//line 78
___nl__0 = null;
//line 78
___nl__1 = null;
//line 78
if(true) return ___nl__2;
//line 78
___nl__2 = null;
//line 78
if (true) {goto label_4;}
//line 78
label_4:
//line 78
___nl__1 = null;
//line 79
___nl__1 = c_rt_lib_NL.NL_get_false();
//line 81
___nl__3 = ((ImmHash)___nl__0).getHashValue()["commands"];
//line 81
___nl__5 = new ImmDouble(0);
//line 81
___nl__6 = new ImmDouble(1);
//line 81
___nl__7 = c_rt_lib_NL.NL_array_len(___nl__3);

//line 81
label_7:
//line 81
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) );
//line 81
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_5;}}
//line 81
___nl__4 = (___nl__3 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()];
//line 82
___nl__9 = ((ImmHash)___nl__4).getHashValue()["cmd"];
//line 83
___nl__10 = ___nl__9;
//line 83
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__10, new ImmString("call"));
//line 83
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10));
//line 83
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_9;}}
//line 84
___nl__11 = ___nl__9;
//line 84
___nl__11 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("call"));
//line 85
___nl__12 = ((ImmHash)___nl__11).getHashValue()["fun_name"];
//line 85
___nl__13 = new ImmString("sigleton_do_not_use_without_approval");
//line 85
___nl__12 = c_rt_lib_NL.NL_native_to_nl(___nl__12.toString().Equals(___nl__13.toString()));
//line 85
___nl__13 = null;
//line 85
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12));
//line 85
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12));
//line 85
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_11;}}
//line 85
___nl__9 = null;
//line 85
___nl__10 = null;
//line 85
___nl__11 = null;
//line 85
___nl__12 = null;
//line 85
if (true) {goto label_6;}
//line 85
if (true) {goto label_11;}
//line 85
label_11:
//line 85
___nl__12 = null;
//line 86
___nl__12 = ((ImmHash)___nl__11).getHashValue()["mod"];
//line 86
___nl__13 = new ImmString("singleton");
//line 86
___nl__12 = c_rt_lib_NL.NL_native_to_nl(___nl__12.toString().Equals(___nl__13.toString()));
//line 86
___nl__13 = null;
//line 86
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12));
//line 86
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12));
//line 86
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_13;}}
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
if (true) {goto label_13;}
//line 86
label_13:
//line 86
___nl__12 = null;
//line 87
___nl__12 = c_rt_lib_NL.NL_get_true();
//line 87
___nl__1 = ___nl__12;
//line 87
___nl__12 = null;
//line 88
___nl__12 = ((ImmHash)___nl__11).getHashValue()["dest"];
//line 88
___nl__2 = ___nl__12;
//line 88
___nl__12 = null;
//line 88
___nl__11 = null;
//line 89
if (true) {goto label_8;}
//line 89
label_9:
//line 89
___nl__10 = ___nl__9;
//line 89
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__10, new ImmString("return"));
//line 89
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10));
//line 89
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_14;}}
//line 90
___nl__11 = ___nl__1;
//line 90
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11));
//line 90
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11));
//line 90
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_16;}}
//line 90
___nl__12 = c_rt_lib_NL.NL_get_false();
//line 90
___nl__0 = null;
//line 90
___nl__1 = null;
//line 90
___nl__2 = null;
//line 90
___nl__3 = null;
//line 90
___nl__4 = null;
//line 90
___nl__5 = null;
//line 90
___nl__6 = null;
//line 90
___nl__7 = null;
//line 90
___nl__8 = null;
//line 90
___nl__9 = null;
//line 90
___nl__10 = null;
//line 90
___nl__11 = null;
//line 90
if(true) return ___nl__12;
//line 90
___nl__12 = null;
//line 90
if (true) {goto label_16;}
//line 90
label_16:
//line 90
___nl__11 = null;
//line 91
___nl__11 = ___nl__9;
//line 91
___nl__11 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("return"));
//line 92
___nl__12 = ___nl__11;
//line 92
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__12, new ImmString("val"));
//line 92
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12));
//line 92
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12));
//line 92
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_18;}}
//line 92
___nl__13 = c_rt_lib_NL.NL_get_false();
//line 92
___nl__0 = null;
//line 92
___nl__1 = null;
//line 92
___nl__2 = null;
//line 92
___nl__3 = null;
//line 92
___nl__4 = null;
//line 92
___nl__5 = null;
//line 92
___nl__6 = null;
//line 92
___nl__7 = null;
//line 92
___nl__8 = null;
//line 92
___nl__9 = null;
//line 92
___nl__10 = null;
//line 92
___nl__11 = null;
//line 92
___nl__12 = null;
//line 92
if(true) return ___nl__13;
//line 92
___nl__13 = null;
//line 92
if (true) {goto label_18;}
//line 92
label_18:
//line 92
___nl__12 = null;
//line 93
___nl__12 = ___nl__11;
//line 93
___nl__12 = c_rt_lib_NL.NL_ov_as(___nl__12, new ImmString("val"));
//line 93
___nl__12 = c_rt_lib_NL.NL_native_to_nl(___nl__12.toString().Equals(___nl__2.toString()));
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
if(true) return ___nl__12;
//line 93
___nl__12 = null;
//line 93
___nl__11 = null;
//line 94
if (true) {goto label_8;}
//line 94
label_14:
//line 94
___nl__10 = ___nl__9;
//line 94
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__10, new ImmString("prt_lbl"));
//line 94
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10));
//line 94
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_19;}}
//line 95
if (true) {goto label_8;}
//line 95
label_19:
//line 95
___nl__10 = ___nl__9;
//line 95
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__10, new ImmString("clear"));
//line 95
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10));
//line 95
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_20;}}
//line 96
if (true) {goto label_8;}
//line 96
label_20:
//line 97
___nl__11 = ___nl__1;
//line 97
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11));
//line 97
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_22;}}
//line 97
___nl__12 = c_rt_lib_NL.NL_get_false();
//line 97
___nl__0 = null;
//line 97
___nl__1 = null;
//line 97
___nl__2 = null;
//line 97
___nl__3 = null;
//line 97
___nl__4 = null;
//line 97
___nl__5 = null;
//line 97
___nl__6 = null;
//line 97
___nl__7 = null;
//line 97
___nl__8 = null;
//line 97
___nl__9 = null;
//line 97
___nl__10 = null;
//line 97
___nl__11 = null;
//line 97
if(true) return ___nl__12;
//line 97
___nl__12 = null;
//line 97
if (true) {goto label_22;}
//line 97
label_22:
//line 97
___nl__11 = null;
//line 98
if (true) {goto label_8;}
//line 98
label_8:
//line 98
___nl__10 = null;
//line 98
___nl__9 = null;
//line 98
label_6:
//line 99
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString())));
//line 99
if (true) {goto label_7;}
//line 99
label_5:
//line 99
___nl__3 = null;
//line 99
___nl__4 = null;
//line 99
___nl__5 = null;
//line 99
___nl__6 = null;
//line 99
___nl__7 = null;
//line 99
___nl__8 = null;
//line 100
___nl__3 = c_rt_lib_NL.NL_get_false();
//line 100
___nl__0 = null;
//line 100
___nl__1 = null;
//line 100
___nl__2 = null;
//line 100
if(true) return ___nl__3;
//line 100
___nl__3 = null;
//line 100
___nl__1 = null;
//line 100
___nl__2 = null;
//line 100
___nl__0 = null;
//line 100
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
//line 105
___nl__2 = generator_java_NL.NL_is_singleton_use_function_priv(___nl__0);

//line 105
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 105
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 106
___nl__3 = ___nl__0;
//line 107
___nl__4 = new ImmString("SINGLETON_");
//line 107
___nl__5 = ((ImmHash)___nl__0).getHashValue()["name"];
//line 107
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 107
___nl__5 = null;
//line 107
___nl__5 = ___nl__4;
//line 107
((ImmHash)___nl__3).set("name", ___nl__5);
//line 107
___nl__4 = null;
//line 107
___nl__5 = null;
//line 108
___nl__4 = generator_java_NL.NL_get_function_name_priv(___nl__3);

//line 109
___nl__5 = new ImmString("value__singleton__");
//line 109
___nl__5 = new ImmString(___nl__5.toString() + ___nl__4.toString());
//line 111
___nl__6 = generator_java_NL.NL_print_function_priv(___nl__3,___nl__1);

//line 113
___nl__7 = new ImmString("private static Imm ");
//line 113
___nl__7 = new ImmString(___nl__7.toString() + ___nl__5.toString());
//line 113
___nl__8 = new ImmString(" = null;");
//line 113
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 113
___nl__8 = null;
//line 113
___nl__8 = string_NL.NL_lf();

//line 113
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 113
___nl__8 = null;
//line 113
___nl__8 = generator_java_NL.NL_get_function_declaration_priv(___nl__0);

//line 113
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 113
___nl__8 = null;
//line 113
___nl__8 = new ImmString("() throws Exception {\n	if (");
//line 113
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 113
___nl__8 = null;
//line 113
___nl__7 = new ImmString(___nl__7.toString() + ___nl__5.toString());
//line 113
___nl__8 = new ImmString(" == null) {\n		");
//line 113
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 113
___nl__8 = null;
//line 113
___nl__7 = new ImmString(___nl__7.toString() + ___nl__5.toString());
//line 113
___nl__8 = new ImmString(" = ");
//line 113
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 113
___nl__8 = null;
//line 113
___nl__7 = new ImmString(___nl__7.toString() + ___nl__4.toString());
//line 113
___nl__8 = new ImmString("();\n	}\n	return ");
//line 113
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 113
___nl__8 = null;
//line 113
___nl__7 = new ImmString(___nl__7.toString() + ___nl__5.toString());
//line 113
___nl__8 = new ImmString(";\n}");
//line 113
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 113
___nl__8 = null;
//line 113
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 113
___nl__7 = null;
//line 120
___nl__0 = null;
//line 120
___nl__1 = null;
//line 120
___nl__2 = null;
//line 120
___nl__3 = null;
//line 120
___nl__4 = null;
//line 120
___nl__5 = null;
//line 120
if(true) return ___nl__6;
//line 120
___nl__3 = null;
//line 120
___nl__4 = null;
//line 120
___nl__5 = null;
//line 120
___nl__6 = null;
//line 121
if (true) {goto label_1;}
//line 121
label_2:
//line 122
___nl__3 = generator_java_NL.NL_print_function_priv(___nl__0,___nl__1);

//line 122
___nl__0 = null;
//line 122
___nl__1 = null;
//line 122
___nl__2 = null;
//line 122
if(true) return ___nl__3;
//line 122
___nl__3 = null;
//line 123
if (true) {goto label_1;}
//line 123
label_1:
//line 123
___nl__2 = null;
//line 123
___nl__0 = null;
//line 123
___nl__1 = null;
//line 123
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
//line 127
___nl__2 = string_NL.NL_lf();

//line 127
___nl__3 = generator_java_NL.NL_get_function_declaration_priv(___nl__0);

//line 127
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 127
___nl__3 = null;
//line 127
___nl__3 = new ImmString("(");
//line 127
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 127
___nl__3 = null;
//line 128
___nl__4 = ((ImmHash)___nl__0).getHashValue()["args_type"];
//line 128
___nl__3 = array_NL.NL_len(___nl__4);

//line 128
___nl__4 = null;
//line 128
___nl__4 = new ImmDouble(0);
//line 128
___nl__5 = new ImmDouble(1);
//line 128
label_3:
//line 128
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__3.getValue().ToString())) );
//line 128
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_1;}}
//line 129
___nl__7 = new ImmDouble(0);
//line 129
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString())) ==((Double.Parse(___nl__7.getValue().ToString())))  );
//line 129
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 129
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 129
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_5;}}
//line 129
___nl__8 = new ImmString(", ");
//line 129
___nl__2 = new ImmString(___nl__2.toString() + ___nl__8.toString());
//line 129
___nl__8 = null;
//line 129
if (true) {goto label_5;}
//line 129
label_5:
//line 129
___nl__7 = null;
//line 130
___nl__7 = new ImmString("ImmRef ___arg__");
//line 130
___nl__7 = new ImmString(___nl__7.toString() + ___nl__4.toString());
//line 130
___nl__2 = new ImmString(___nl__2.toString() + ___nl__7.toString());
//line 130
___nl__7 = null;
//line 131
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString())));
//line 131
if (true) {goto label_3;}
//line 131
label_1:
//line 131
___nl__3 = null;
//line 131
___nl__4 = null;
//line 131
___nl__5 = null;
//line 131
___nl__6 = null;
//line 132
___nl__3 = new ImmString(") throws Exception {");
//line 132
___nl__4 = string_NL.NL_lf();

//line 132
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 132
___nl__4 = null;
//line 132
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 132
___nl__3 = null;
//line 133
___nl__4 = ((ImmHash)___nl__0).getHashValue()["args_type"];
//line 133
___nl__3 = array_NL.NL_len(___nl__4);

//line 133
___nl__4 = null;
//line 133
___nl__4 = new ImmDouble(0);
//line 133
___nl__5 = new ImmDouble(1);
//line 133
label_8:
//line 133
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__3.getValue().ToString())) );
//line 133
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_6;}}
//line 134
___nl__7 = ((ImmHash)___nl__0).getHashValue()["args_type"];
//line 134
___nl__7 = (___nl__7 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()];
//line 134
___nl__8 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("val"));
//line 134
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_10;}}
//line 136
___nl__8 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("ref"));
//line 136
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_11;}}
//line 136
___nl__8 = new ImmString("NOMATCHALERT");
//line 136
___nl__8 = new ImmArray(new Imm[] {___nl__8,___nl__7,});
//line 136
c_rt_lib_NL.NL_die();
//line 134
label_10:
//line 135
___nl__9 = new ImmString("ImmRef ___nl__");
//line 135
___nl__9 = new ImmString(___nl__9.toString() + ___nl__4.toString());
//line 135
___nl__10 = new ImmString(" = new ImmRef(___arg__");
//line 135
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString());
//line 135
___nl__10 = null;
//line 135
___nl__9 = new ImmString(___nl__9.toString() + ___nl__4.toString());
//line 135
___nl__10 = generator_java_NL.NL_print_getter_priv();

//line 135
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString());
//line 135
___nl__10 = null;
//line 135
___nl__10 = new ImmString(");");
//line 135
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString());
//line 135
___nl__10 = null;
//line 135
___nl__2 = new ImmString(___nl__2.toString() + ___nl__9.toString());
//line 135
___nl__9 = null;
//line 136
if (true) {goto label_9;}
//line 136
label_11:
//line 137
___nl__9 = new ImmString("ImmRef ___nl__");
//line 137
___nl__9 = new ImmString(___nl__9.toString() + ___nl__4.toString());
//line 137
___nl__10 = new ImmString(" = ___arg__");
//line 137
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString());
//line 137
___nl__10 = null;
//line 137
___nl__9 = new ImmString(___nl__9.toString() + ___nl__4.toString());
//line 137
___nl__10 = new ImmString(";");
//line 137
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString());
//line 137
___nl__10 = null;
//line 137
___nl__2 = new ImmString(___nl__2.toString() + ___nl__9.toString());
//line 137
___nl__9 = null;
//line 138
if (true) {goto label_9;}
//line 138
label_9:
//line 138
___nl__7 = null;
//line 138
___nl__8 = null;
//line 139
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString())));
//line 139
if (true) {goto label_8;}
//line 139
label_6:
//line 139
___nl__3 = null;
//line 139
___nl__4 = null;
//line 139
___nl__5 = null;
//line 139
___nl__6 = null;
//line 140
___nl__3 = string_NL.NL_lf();

//line 140
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 140
___nl__3 = null;
//line 141
___nl__4 = ((ImmHash)___nl__0).getHashValue()["args_type"];
//line 141
___nl__3 = array_NL.NL_len(___nl__4);

//line 141
___nl__4 = null;
//line 141
label_13:
//line 141
___nl__4 = ((ImmHash)___nl__0).getHashValue()["reg_size"];
//line 141
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))<(Double.Parse(___nl__4.getValue().ToString())) );
//line 141
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 141
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_12;}}
//line 142
___nl__5 = new ImmString("ImmRef ___nl__");
//line 142
___nl__5 = new ImmString(___nl__5.toString() + ___nl__3.toString());
//line 142
___nl__6 = new ImmString(" = new ImmRef(null);");
//line 142
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 142
___nl__6 = null;
//line 142
___nl__6 = string_NL.NL_lf();

//line 142
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 142
___nl__6 = null;
//line 142
___nl__2 = new ImmString(___nl__2.toString() + ___nl__5.toString());
//line 142
___nl__5 = null;
//line 142
___nl__5 = new ImmDouble(1);
//line 142
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString())));
//line 142
___nl__5 = null;
//line 143
if (true) {goto label_13;}
//line 143
label_12:
//line 143
___nl__3 = null;
//line 143
___nl__4 = null;
//line 144
___nl__3 = new ImmString("Map<ImmString, Imm> ");
//line 144
___nl__4 = generator_java_NL.NL_print_hash_name_priv();

//line 144
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 144
___nl__4 = null;
//line 144
___nl__4 = new ImmString(";");
//line 144
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 144
___nl__4 = null;
//line 144
___nl__4 = string_NL.NL_lf();

//line 144
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 144
___nl__4 = null;
//line 144
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 144
___nl__3 = null;
//line 145
___nl__3 = new ImmString("String label = \"\"; while (true) { switch (label) { default: ");
//line 145
___nl__4 = string_NL.NL_lf();

//line 145
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 145
___nl__4 = null;
//line 145
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 145
___nl__3 = null;
//line 146
___nl__3 = ((ImmHash)___nl__0).getHashValue()["commands"];
//line 146
___nl__5 = new ImmDouble(0);
//line 146
___nl__6 = new ImmDouble(1);
//line 146
___nl__7 = c_rt_lib_NL.NL_array_len(___nl__3);

//line 146
label_17:
//line 146
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) );
//line 146
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_15;}}
//line 146
___nl__4 = (___nl__3 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()];
//line 146
___nl__9 = generator_java_NL.NL_print_command_priv(___nl__1,___nl__4);

//line 146
___nl__2 = new ImmString(___nl__2.toString() + ___nl__9.toString());
//line 146
___nl__9 = null;
//line 146
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString())));
//line 146
if (true) {goto label_17;}
//line 146
label_15:
//line 146
___nl__3 = null;
//line 146
___nl__4 = null;
//line 146
___nl__5 = null;
//line 146
___nl__6 = null;
//line 146
___nl__7 = null;
//line 146
___nl__8 = null;
//line 147
___nl__3 = new ImmString("}}}");
//line 147
___nl__3 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 147
___nl__4 = string_NL.NL_lf();

//line 147
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 147
___nl__4 = null;
//line 147
___nl__0 = null;
//line 147
___nl__1 = null;
//line 147
___nl__2 = null;
//line 147
if(true) return ___nl__3;
//line 147
___nl__3 = null;
//line 147
___nl__2 = null;
//line 147
___nl__0 = null;
//line 147
___nl__1 = null;
//line 147
if(true) return null;
}

private static Imm NL_print_command_priv(Imm ___arg__0, Imm ___arg__1) {
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
//line 152
___nl__3 = ((ImmHash)___nl__1).getHashValue()["cmd"];
//line 152
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("arr_decl"));
//line 152
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 154
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("hash_decl"));
//line 154
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_3;}}
//line 157
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("call"));
//line 157
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_4;}}
//line 159
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("func"));
//line 159
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_5;}}
//line 161
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("una_op"));
//line 161
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_6;}}
//line 163
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("bin_op"));
//line 163
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_7;}}
//line 165
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("ov_is"));
//line 165
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_8;}}
//line 167
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("ov_as"));
//line 167
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_9;}}
//line 169
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("return"));
//line 169
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_10;}}
//line 171
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("die"));
//line 171
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_11;}}
//line 173
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("move"));
//line 173
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_12;}}
//line 175
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("load_const"));
//line 175
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_13;}}
//line 177
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("get_frm_idx"));
//line 177
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_14;}}
//line 181
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("set_at_idx"));
//line 181
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_15;}}
//line 185
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("get_val"));
//line 185
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_16;}}
//line 187
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("set_val"));
//line 187
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_17;}}
//line 190
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("ov_mk"));
//line 190
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_18;}}
//line 192
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("prt_lbl"));
//line 192
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_19;}}
//line 194
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("if_goto"));
//line 194
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_20;}}
//line 196
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("goto"));
//line 196
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_21;}}
//line 198
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("clear"));
//line 198
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_22;}}
//line 198
___nl__4 = new ImmString("NOMATCHALERT");
//line 198
___nl__4 = new ImmArray(new Imm[] {___nl__4,___nl__3,});
//line 198
c_rt_lib_NL.NL_die();
//line 152
label_2:
//line 152
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("arr_decl"));
//line 153
___nl__7 = ((ImmHash)___nl__5).getHashValue()["dest"];
//line 153
___nl__9 = ((ImmHash)___nl__5).getHashValue()["src"];
//line 153
___nl__8 = generator_java_NL.NL_print_arr_priv(___nl__9);

//line 153
___nl__9 = null;
//line 153
___nl__6 = generator_java_NL.NL_print_register_setter_priv(___nl__7,___nl__8);

//line 153
___nl__8 = null;
//line 153
___nl__7 = null;
//line 153
___nl__7 = new ImmString(";");
//line 153
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 153
___nl__7 = null;
//line 153
___nl__2 = ___nl__6;
//line 153
___nl__6 = null;
//line 153
___nl__5 = null;
//line 154
if (true) {goto label_1;}
//line 154
label_3:
//line 154
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("hash_decl"));
//line 155
___nl__6 = generator_java_NL.NL_print_hash_priv(___nl__5);

//line 155
___nl__2 = ___nl__6;
//line 155
___nl__6 = null;
//line 156
___nl__7 = ((ImmHash)___nl__5).getHashValue()["dest"];
//line 156
___nl__8 = new ImmString("new ImmMap(");
//line 156
___nl__9 = generator_java_NL.NL_print_hash_name_priv();

//line 156
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 156
___nl__9 = null;
//line 156
___nl__9 = new ImmString(")");
//line 156
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 156
___nl__9 = null;
//line 156
___nl__6 = generator_java_NL.NL_print_register_setter_priv(___nl__7,___nl__8);

//line 156
___nl__8 = null;
//line 156
___nl__7 = null;
//line 156
___nl__7 = new ImmString(";");
//line 156
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 156
___nl__7 = null;
//line 156
___nl__2 = new ImmString(___nl__2.toString() + ___nl__6.toString());
//line 156
___nl__6 = null;
//line 156
___nl__5 = null;
//line 157
if (true) {goto label_1;}
//line 157
label_4:
//line 157
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("call"));
//line 158
___nl__7 = ((ImmHash)___nl__5).getHashValue()["dest"];
//line 158
___nl__9 = ((ImmHash)___nl__5).getHashValue()["mod"];
//line 158
___nl__10 = ((ImmHash)___nl__5).getHashValue()["fun_name"];
//line 158
___nl__11 = ((ImmHash)___nl__5).getHashValue()["args"];
//line 158
___nl__8 = generator_java_NL.NL_print_call_priv(___nl__0,___nl__9,___nl__10,___nl__11);

//line 158
___nl__11 = null;
//line 158
___nl__10 = null;
//line 158
___nl__9 = null;
//line 158
___nl__6 = generator_java_NL.NL_print_register_setter_priv(___nl__7,___nl__8);

//line 158
___nl__8 = null;
//line 158
___nl__7 = null;
//line 158
___nl__7 = new ImmString(";");
//line 158
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 158
___nl__7 = null;
//line 158
___nl__2 = ___nl__6;
//line 158
___nl__6 = null;
//line 158
___nl__5 = null;
//line 159
if (true) {goto label_1;}
//line 159
label_5:
//line 159
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("func"));
//line 160
___nl__7 = ((ImmHash)___nl__5).getHashValue()["dest"];
//line 160
___nl__10 = ((ImmHash)___nl__5).getHashValue()["module"];
//line 160
___nl__9 = generator_java_NL.NL_get_class_name_priv(___nl__10);

//line 160
___nl__10 = null;
//line 160
___nl__10 = ((ImmHash)___nl__5).getHashValue()["name"];
//line 160
___nl__11 = new ImmString("_nl");
//line 160
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString());
//line 160
___nl__11 = null;
//line 160
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",___nl__9);
__function_map.Add("name",___nl__10);
___nl__8 = new ImmHash(__function_map);
//line 160
___nl__9 = null;
//line 160
___nl__10 = null;
//line 160
___nl__6 = generator_java_NL.NL_print_const_hash_priv(___nl__7,___nl__8);

//line 160
___nl__8 = null;
//line 160
___nl__7 = null;
//line 160
___nl__7 = new ImmString(";");
//line 160
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 160
___nl__7 = null;
//line 160
___nl__2 = ___nl__6;
//line 160
___nl__6 = null;
//line 160
___nl__5 = null;
//line 161
if (true) {goto label_1;}
//line 161
label_6:
//line 161
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("una_op"));
//line 162
___nl__6 = generator_java_NL.NL_print_una_op_priv(___nl__5);

//line 162
___nl__2 = ___nl__6;
//line 162
___nl__6 = null;
//line 162
___nl__5 = null;
//line 163
if (true) {goto label_1;}
//line 163
label_7:
//line 163
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("bin_op"));
//line 164
___nl__6 = generator_java_NL.NL_print_bin_op_priv(___nl__5);

//line 164
___nl__2 = ___nl__6;
//line 164
___nl__6 = null;
//line 164
___nl__5 = null;
//line 165
if (true) {goto label_1;}
//line 165
label_8:
//line 165
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("ov_is"));
//line 166
___nl__7 = ((ImmHash)___nl__5).getHashValue()["dest"];
//line 166
___nl__8 = new ImmString("c_rt_lib_NL.ov_is_nl(");
//line 166
___nl__10 = ((ImmHash)___nl__5).getHashValue()["src"];
//line 166
___nl__9 = generator_java_NL.NL_print_register_priv(___nl__10);

//line 166
___nl__10 = null;
//line 166
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 166
___nl__9 = null;
//line 166
___nl__9 = new ImmString(", new ImmRef(new ImmString(\"");
//line 166
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 166
___nl__9 = null;
//line 166
___nl__10 = ((ImmHash)___nl__5).getHashValue()["type"];
//line 166
___nl__9 = generator_java_NL.NL_escape_string_priv(___nl__10);

//line 166
___nl__10 = null;
//line 166
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 166
___nl__9 = null;
//line 166
___nl__9 = new ImmString("\")))");
//line 166
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 166
___nl__9 = null;
//line 166
___nl__6 = generator_java_NL.NL_print_register_setter_priv(___nl__7,___nl__8);

//line 166
___nl__8 = null;
//line 166
___nl__7 = null;
//line 166
___nl__7 = new ImmString(";");
//line 166
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 166
___nl__7 = null;
//line 166
___nl__2 = ___nl__6;
//line 166
___nl__6 = null;
//line 166
___nl__5 = null;
//line 167
if (true) {goto label_1;}
//line 167
label_9:
//line 167
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("ov_as"));
//line 168
___nl__7 = ((ImmHash)___nl__5).getHashValue()["dest"];
//line 168
___nl__8 = new ImmString("c_rt_lib_NL.ov_as_nl(");
//line 168
___nl__10 = ((ImmHash)___nl__5).getHashValue()["src"];
//line 168
___nl__9 = generator_java_NL.NL_print_register_priv(___nl__10);

//line 168
___nl__10 = null;
//line 168
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 168
___nl__9 = null;
//line 168
___nl__9 = new ImmString(", new ImmRef(new ImmString(\"");
//line 168
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 168
___nl__9 = null;
//line 168
___nl__10 = ((ImmHash)___nl__5).getHashValue()["type"];
//line 168
___nl__9 = generator_java_NL.NL_escape_string_priv(___nl__10);

//line 168
___nl__10 = null;
//line 168
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 168
___nl__9 = null;
//line 168
___nl__9 = new ImmString("\")))");
//line 168
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 168
___nl__9 = null;
//line 168
___nl__6 = generator_java_NL.NL_print_register_setter_priv(___nl__7,___nl__8);

//line 168
___nl__8 = null;
//line 168
___nl__7 = null;
//line 168
___nl__7 = new ImmString(";");
//line 168
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 168
___nl__7 = null;
//line 168
___nl__2 = ___nl__6;
//line 168
___nl__6 = null;
//line 168
___nl__5 = null;
//line 169
if (true) {goto label_1;}
//line 169
label_10:
//line 169
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("return"));
//line 170
___nl__6 = generator_java_NL.NL_print_return_priv(___nl__5);

//line 170
___nl__2 = ___nl__6;
//line 170
___nl__6 = null;
//line 170
___nl__5 = null;
//line 171
if (true) {goto label_1;}
//line 171
label_11:
//line 171
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("die"));
//line 172
___nl__6 = new ImmString("c_rt_lib_NL.die_nl();");
//line 172
___nl__2 = ___nl__6;
//line 172
___nl__6 = null;
//line 172
___nl__5 = null;
//line 173
if (true) {goto label_1;}
//line 173
label_12:
//line 173
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("move"));
//line 174
___nl__7 = ((ImmHash)___nl__5).getHashValue()["dest"];
//line 174
___nl__9 = ((ImmHash)___nl__5).getHashValue()["src"];
//line 174
___nl__8 = generator_java_NL.NL_print_register_getter_priv(___nl__9);

//line 174
___nl__9 = null;
//line 174
___nl__6 = generator_java_NL.NL_print_register_setter_priv(___nl__7,___nl__8);

//line 174
___nl__8 = null;
//line 174
___nl__7 = null;
//line 174
___nl__7 = new ImmString(";");
//line 174
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 174
___nl__7 = null;
//line 174
___nl__2 = ___nl__6;
//line 174
___nl__6 = null;
//line 174
___nl__5 = null;
//line 175
if (true) {goto label_1;}
//line 175
label_13:
//line 175
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("load_const"));
//line 176
___nl__7 = ((ImmHash)___nl__5).getHashValue()["dest"];
//line 176
___nl__10 = ((ImmHash)___nl__5).getHashValue()["dest"];
//line 176
___nl__9 = generator_java_NL.NL_print_register_priv(___nl__10);

//line 176
___nl__10 = null;
//line 176
___nl__10 = ((ImmHash)___nl__5).getHashValue()["val"];
//line 176
___nl__8 = generator_java_NL.NL_print_const_value_priv(___nl__9,___nl__10);

//line 176
___nl__10 = null;
//line 176
___nl__9 = null;
//line 176
___nl__6 = generator_java_NL.NL_print_register_setter_priv(___nl__7,___nl__8);

//line 176
___nl__8 = null;
//line 176
___nl__7 = null;
//line 176
___nl__7 = new ImmString(";");
//line 176
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 176
___nl__7 = null;
//line 176
___nl__2 = ___nl__6;
//line 176
___nl__6 = null;
//line 176
___nl__5 = null;
//line 177
if (true) {goto label_1;}
//line 177
label_14:
//line 177
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("get_frm_idx"));
//line 178
___nl__6 = new ImmString("((ImmArray)");
//line 178
___nl__8 = ((ImmHash)___nl__5).getHashValue()["src"];
//line 178
___nl__7 = generator_java_NL.NL_print_register_getter_priv(___nl__8);

//line 178
___nl__8 = null;
//line 178
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 178
___nl__7 = null;
//line 178
___nl__7 = new ImmString(")");
//line 178
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 178
___nl__7 = null;
//line 178
___nl__7 = generator_java_NL.NL_print_getter_priv();

//line 178
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 178
___nl__7 = null;
//line 178
___nl__2 = ___nl__6;
//line 178
___nl__6 = null;
//line 179
___nl__6 = new ImmString("[((ImmDouble)(");
//line 179
___nl__8 = ((ImmHash)___nl__5).getHashValue()["idx"];
//line 179
___nl__7 = generator_java_NL.NL_print_register_getter_priv(___nl__8);

//line 179
___nl__8 = null;
//line 179
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 179
___nl__7 = null;
//line 179
___nl__7 = new ImmString("))");
//line 179
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 179
___nl__7 = null;
//line 179
___nl__7 = generator_java_NL.NL_print_getter_priv();

//line 179
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 179
___nl__7 = null;
//line 179
___nl__7 = generator_java_NL.NL_print_int_value_priv();

//line 179
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 179
___nl__7 = null;
//line 179
___nl__7 = new ImmString("]");
//line 179
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 179
___nl__7 = null;
//line 179
___nl__2 = new ImmString(___nl__2.toString() + ___nl__6.toString());
//line 179
___nl__6 = null;
//line 180
___nl__7 = ((ImmHash)___nl__5).getHashValue()["dest"];
//line 180
___nl__6 = generator_java_NL.NL_print_register_setter_priv(___nl__7,___nl__2);

//line 180
___nl__7 = null;
//line 180
___nl__7 = new ImmString(";");
//line 180
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 180
___nl__7 = null;
//line 180
___nl__2 = ___nl__6;
//line 180
___nl__6 = null;
//line 180
___nl__5 = null;
//line 181
if (true) {goto label_1;}
//line 181
label_15:
//line 181
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("set_at_idx"));
//line 182
___nl__7 = ((ImmHash)___nl__5).getHashValue()["src"];
//line 182
___nl__8 = new ImmString("c_rt_lib_NL.clone_nl(");
//line 182
___nl__10 = ((ImmHash)___nl__5).getHashValue()["src"];
//line 182
___nl__9 = generator_java_NL.NL_print_register_getter_priv(___nl__10);

//line 182
___nl__10 = null;
//line 182
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 182
___nl__9 = null;
//line 182
___nl__9 = new ImmString(")");
//line 182
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 182
___nl__9 = null;
//line 182
___nl__6 = generator_java_NL.NL_print_register_setter_priv(___nl__7,___nl__8);

//line 182
___nl__8 = null;
//line 182
___nl__7 = null;
//line 182
___nl__7 = new ImmString(";");
//line 182
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 182
___nl__7 = null;
//line 182
___nl__7 = string_NL.NL_lf();

//line 182
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 182
___nl__7 = null;
//line 182
___nl__2 = ___nl__6;
//line 182
___nl__6 = null;
//line 183
___nl__6 = new ImmString("((ImmArray)");
//line 183
___nl__8 = ((ImmHash)___nl__5).getHashValue()["src"];
//line 183
___nl__7 = generator_java_NL.NL_print_register_getter_priv(___nl__8);

//line 183
___nl__8 = null;
//line 183
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 183
___nl__7 = null;
//line 183
___nl__7 = new ImmString(")");
//line 183
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 183
___nl__7 = null;
//line 183
___nl__7 = generator_java_NL.NL_print_getter_priv();

//line 183
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 183
___nl__7 = null;
//line 183
___nl__7 = new ImmString("[");
//line 183
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 183
___nl__7 = null;
//line 183
___nl__2 = new ImmString(___nl__2.toString() + ___nl__6.toString());
//line 183
___nl__6 = null;
//line 184
___nl__6 = new ImmString("((ImmDouble)");
//line 184
___nl__8 = ((ImmHash)___nl__5).getHashValue()["idx"];
//line 184
___nl__7 = generator_java_NL.NL_print_register_getter_priv(___nl__8);

//line 184
___nl__8 = null;
//line 184
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 184
___nl__7 = null;
//line 184
___nl__7 = new ImmString(")");
//line 184
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 184
___nl__7 = null;
//line 184
___nl__7 = generator_java_NL.NL_print_getter_priv();

//line 184
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 184
___nl__7 = null;
//line 184
___nl__7 = generator_java_NL.NL_print_int_value_priv();

//line 184
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 184
___nl__7 = null;
//line 184
___nl__7 = new ImmString("] = ");
//line 184
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 184
___nl__7 = null;
//line 184
___nl__8 = ((ImmHash)___nl__5).getHashValue()["val"];
//line 184
___nl__7 = generator_java_NL.NL_print_register_getter_priv(___nl__8);

//line 184
___nl__8 = null;
//line 184
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 184
___nl__7 = null;
//line 184
___nl__7 = new ImmString(";");
//line 184
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 184
___nl__7 = null;
//line 184
___nl__2 = new ImmString(___nl__2.toString() + ___nl__6.toString());
//line 184
___nl__6 = null;
//line 184
___nl__5 = null;
//line 185
if (true) {goto label_1;}
//line 185
label_16:
//line 185
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("get_val"));
//line 186
___nl__7 = ((ImmHash)___nl__5).getHashValue()["dest"];
//line 186
___nl__8 = generator_java_NL.NL_print_get_hash_value_priv(___nl__5);

//line 186
___nl__6 = generator_java_NL.NL_print_register_setter_priv(___nl__7,___nl__8);

//line 186
___nl__8 = null;
//line 186
___nl__7 = null;
//line 186
___nl__7 = new ImmString(";");
//line 186
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 186
___nl__7 = null;
//line 186
___nl__2 = ___nl__6;
//line 186
___nl__6 = null;
//line 186
___nl__5 = null;
//line 187
if (true) {goto label_1;}
//line 187
label_17:
//line 187
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("set_val"));
//line 188
___nl__7 = ((ImmHash)___nl__5).getHashValue()["src"];
//line 188
___nl__8 = new ImmString("c_rt_lib_NL.clone_nl(");
//line 188
___nl__10 = ((ImmHash)___nl__5).getHashValue()["src"];
//line 188
___nl__9 = generator_java_NL.NL_print_register_getter_priv(___nl__10);

//line 188
___nl__10 = null;
//line 188
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 188
___nl__9 = null;
//line 188
___nl__9 = new ImmString(")");
//line 188
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 188
___nl__9 = null;
//line 188
___nl__6 = generator_java_NL.NL_print_register_setter_priv(___nl__7,___nl__8);

//line 188
___nl__8 = null;
//line 188
___nl__7 = null;
//line 188
___nl__7 = new ImmString(";");
//line 188
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 188
___nl__7 = null;
//line 188
___nl__7 = string_NL.NL_lf();

//line 188
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 188
___nl__7 = null;
//line 188
___nl__2 = ___nl__6;
//line 188
___nl__6 = null;
//line 189
___nl__6 = generator_java_NL.NL_print_set_hash_value_priv(___nl__5);

//line 189
___nl__7 = new ImmString(";");
//line 189
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 189
___nl__7 = null;
//line 189
___nl__2 = new ImmString(___nl__2.toString() + ___nl__6.toString());
//line 189
___nl__6 = null;
//line 189
___nl__5 = null;
//line 190
if (true) {goto label_1;}
//line 190
label_18:
//line 190
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("ov_mk"));
//line 191
___nl__6 = generator_java_NL.NL_print_ov_mk_priv(___nl__5);

//line 191
___nl__2 = ___nl__6;
//line 191
___nl__6 = null;
//line 191
___nl__5 = null;
//line 192
if (true) {goto label_1;}
//line 192
label_19:
//line 192
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("prt_lbl"));
//line 193
___nl__6 = new ImmString("case \"");
//line 193
___nl__6 = new ImmString(___nl__6.toString() + ___nl__5.toString());
//line 193
___nl__7 = new ImmString("\":");
//line 193
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 193
___nl__7 = null;
//line 193
___nl__2 = ___nl__6;
//line 193
___nl__6 = null;
//line 193
___nl__5 = null;
//line 194
if (true) {goto label_1;}
//line 194
label_20:
//line 194
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("if_goto"));
//line 195
___nl__6 = new ImmString("if (c_rt_lib_NL.check_true_native_nl(");
//line 195
___nl__8 = ((ImmHash)___nl__5).getHashValue()["src"];
//line 195
___nl__7 = generator_java_NL.NL_print_register_priv(___nl__8);

//line 195
___nl__8 = null;
//line 195
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 195
___nl__7 = null;
//line 195
___nl__7 = new ImmString(")) {");
//line 195
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 195
___nl__7 = null;
//line 195
___nl__8 = ((ImmHash)___nl__5).getHashValue()["dest"];
//line 195
___nl__7 = generator_java_NL.NL_print_goto_priv(___nl__8);

//line 195
___nl__8 = null;
//line 195
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 195
___nl__7 = null;
//line 195
___nl__7 = new ImmString("}");
//line 195
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 195
___nl__7 = null;
//line 195
___nl__2 = ___nl__6;
//line 195
___nl__6 = null;
//line 195
___nl__5 = null;
//line 196
if (true) {goto label_1;}
//line 196
label_21:
//line 196
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("goto"));
//line 197
___nl__6 = generator_java_NL.NL_print_goto_priv(___nl__5);

//line 197
___nl__2 = ___nl__6;
//line 197
___nl__6 = null;
//line 197
___nl__5 = null;
//line 198
if (true) {goto label_1;}
//line 198
label_22:
//line 198
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("clear"));
//line 199
___nl__7 = new ImmString("null");
//line 199
___nl__6 = generator_java_NL.NL_print_register_setter_priv(___nl__5,___nl__7);

//line 199
___nl__7 = null;
//line 199
___nl__7 = new ImmString(";");
//line 199
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 199
___nl__7 = null;
//line 199
___nl__2 = ___nl__6;
//line 199
___nl__6 = null;
//line 199
___nl__5 = null;
//line 200
if (true) {goto label_1;}
//line 200
label_1:
//line 200
___nl__3 = null;
//line 200
___nl__4 = null;
//line 201
___nl__3 = new ImmString("//line ");
//line 201
___nl__4 = ((ImmHash)___nl__1).getHashValue()["debug"];
//line 201
___nl__4 = ((ImmHash)___nl__4).getHashValue()["nast_debug"];
//line 201
___nl__4 = ((ImmHash)___nl__4).getHashValue()["begin"];
//line 201
___nl__4 = ((ImmHash)___nl__4).getHashValue()["line"];
//line 201
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 201
___nl__4 = null;
//line 201
___nl__4 = string_NL.NL_lf();

//line 201
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 201
___nl__4 = null;
//line 201
___nl__3 = new ImmString(___nl__3.toString() + ___nl__2.toString());
//line 201
___nl__4 = string_NL.NL_lf();

//line 201
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 201
___nl__4 = null;
//line 201
___nl__0 = null;
//line 201
___nl__1 = null;
//line 201
___nl__2 = null;
//line 201
if(true) return ___nl__3;
//line 201
___nl__3 = null;
//line 201
___nl__2 = null;
//line 201
___nl__0 = null;
//line 201
___nl__1 = null;
//line 201
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
//line 205
___nl__1 = new ImmString("new ImmArray(new Imm[");
//line 206
___nl__2 = array_NL.NL_len(___nl__0);

//line 206
___nl__3 = new ImmDouble(0);
//line 206
___nl__2 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__2.getValue().ToString())) ==((Double.Parse(___nl__3.getValue().ToString())))  );
//line 206
___nl__3 = null;
//line 206
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 206
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 207
___nl__3 = new ImmString("0]");
//line 207
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString());
//line 207
___nl__3 = null;
//line 208
if (true) {goto label_1;}
//line 208
label_2:
//line 209
___nl__3 = new ImmString("] {");
//line 209
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString());
//line 209
___nl__3 = null;
//line 210
___nl__4 = new ImmDouble(0);
//line 210
___nl__5 = new ImmDouble(1);
//line 210
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__0);

//line 210
label_5:
//line 210
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) );
//line 210
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_3;}}
//line 210
___nl__3 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()];
//line 210
___nl__8 = generator_java_NL.NL_print_register_getter_priv(___nl__3);

//line 210
___nl__9 = new ImmString(",");
//line 210
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 210
___nl__9 = null;
//line 210
___nl__1 = new ImmString(___nl__1.toString() + ___nl__8.toString());
//line 210
___nl__8 = null;
//line 210
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString())));
//line 210
if (true) {goto label_5;}
//line 210
label_3:
//line 210
___nl__3 = null;
//line 210
___nl__4 = null;
//line 210
___nl__5 = null;
//line 210
___nl__6 = null;
//line 210
___nl__7 = null;
//line 211
___nl__3 = new ImmString("}");
//line 211
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString());
//line 211
___nl__3 = null;
//line 212
if (true) {goto label_1;}
//line 212
label_1:
//line 212
___nl__2 = null;
//line 213
___nl__2 = new ImmString(")");
//line 213
___nl__2 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 213
___nl__0 = null;
//line 213
___nl__1 = null;
//line 213
if(true) return ___nl__2;
//line 213
___nl__2 = null;
//line 213
___nl__1 = null;
//line 213
___nl__0 = null;
//line 213
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
//line 217
___nl__1 = new ImmString("");
//line 218
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 218
___nl__3 = new ImmString(">=");
//line 218
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 218
___nl__3 = null;
//line 218
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_7;}}
//line 218
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 218
___nl__3 = new ImmString("<=");
//line 218
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 218
___nl__3 = null;
//line 218
label_7:
//line 218
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_6;}}
//line 218
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 218
___nl__3 = new ImmString("<");
//line 218
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 218
___nl__3 = null;
//line 218
label_6:
//line 218
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_5;}}
//line 218
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 218
___nl__3 = new ImmString(">");
//line 218
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 218
___nl__3 = null;
//line 218
label_5:
//line 218
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_4;}}
//line 218
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 218
___nl__3 = new ImmString("==");
//line 218
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 218
___nl__3 = null;
//line 218
label_4:
//line 218
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_3;}}
//line 218
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 218
___nl__3 = new ImmString("!=");
//line 218
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 218
___nl__3 = null;
//line 218
label_3:
//line 218
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 218
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 220
___nl__3 = new ImmString("c_rt_lib_NL.native_to_nl_nl(");
//line 220
___nl__4 = generator_java_NL.NL_print_imm_double_operation_priv(___nl__0);

//line 220
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 220
___nl__4 = null;
//line 220
___nl__4 = new ImmString(" )");
//line 220
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 220
___nl__4 = null;
//line 220
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString());
//line 220
___nl__3 = null;
//line 221
if (true) {goto label_1;}
//line 221
label_2:
//line 221
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 221
___nl__3 = new ImmString("eq");
//line 221
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 221
___nl__3 = null;
//line 221
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_9;}}
//line 221
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 221
___nl__3 = new ImmString("ne");
//line 221
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 221
___nl__3 = null;
//line 221
label_9:
//line 221
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 221
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_8;}}
//line 222
___nl__3 = new ImmString("c_rt_lib_NL.native_to_nl_nl(");
//line 222
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString());
//line 222
___nl__3 = null;
//line 223
___nl__3 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 223
___nl__4 = new ImmString("ne");
//line 223
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__4.toString()));
//line 223
___nl__4 = null;
//line 223
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 223
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_11;}}
//line 224
___nl__4 = new ImmString("!");
//line 224
___nl__1 = new ImmString(___nl__1.toString() + ___nl__4.toString());
//line 224
___nl__4 = null;
//line 225
if (true) {goto label_11;}
//line 225
label_11:
//line 225
___nl__3 = null;
//line 226
___nl__4 = ((ImmHash)___nl__0).getHashValue()["left"];
//line 226
___nl__3 = generator_java_NL.NL_print_register_getter_priv(___nl__4);

//line 226
___nl__4 = null;
//line 226
___nl__4 = new ImmString(".toString().equals(");
//line 226
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 226
___nl__4 = null;
//line 226
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString());
//line 226
___nl__3 = null;
//line 227
___nl__4 = ((ImmHash)___nl__0).getHashValue()["right"];
//line 227
___nl__3 = generator_java_NL.NL_print_register_getter_priv(___nl__4);

//line 227
___nl__4 = null;
//line 227
___nl__4 = new ImmString(".toString()))");
//line 227
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 227
___nl__4 = null;
//line 227
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString());
//line 227
___nl__3 = null;
//line 228
if (true) {goto label_1;}
//line 228
label_8:
//line 228
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 228
___nl__3 = new ImmString(".");
//line 228
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 228
___nl__3 = null;
//line 228
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 228
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_12;}}
//line 229
___nl__3 = new ImmString("new ImmString(");
//line 229
___nl__5 = ((ImmHash)___nl__0).getHashValue()["left"];
//line 229
___nl__4 = generator_java_NL.NL_print_register_getter_priv(___nl__5);

//line 229
___nl__5 = null;
//line 229
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 229
___nl__4 = null;
//line 229
___nl__4 = new ImmString(".toString() + ");
//line 229
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 229
___nl__4 = null;
//line 229
___nl__5 = ((ImmHash)___nl__0).getHashValue()["right"];
//line 229
___nl__4 = generator_java_NL.NL_print_register_getter_priv(___nl__5);

//line 229
___nl__5 = null;
//line 229
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 229
___nl__4 = null;
//line 229
___nl__4 = new ImmString(".toString())");
//line 229
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 229
___nl__4 = null;
//line 229
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString());
//line 229
___nl__3 = null;
//line 230
if (true) {goto label_1;}
//line 230
label_12:
//line 231
___nl__3 = new ImmString("new ImmDouble(");
//line 231
___nl__4 = generator_java_NL.NL_print_imm_double_operation_priv(___nl__0);

//line 231
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 231
___nl__4 = null;
//line 231
___nl__4 = new ImmString(")");
//line 231
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 231
___nl__4 = null;
//line 231
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString());
//line 231
___nl__3 = null;
//line 232
if (true) {goto label_1;}
//line 232
label_1:
//line 232
___nl__2 = null;
//line 233
___nl__3 = ((ImmHash)___nl__0).getHashValue()["dest"];
//line 233
___nl__2 = generator_java_NL.NL_print_register_setter_priv(___nl__3,___nl__1);

//line 233
___nl__3 = null;
//line 233
___nl__3 = new ImmString(";");
//line 233
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 233
___nl__3 = null;
//line 233
___nl__0 = null;
//line 233
___nl__1 = null;
//line 233
if(true) return ___nl__2;
//line 233
___nl__2 = null;
//line 233
___nl__1 = null;
//line 233
___nl__0 = null;
//line 233
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
//line 237
___nl__2 = ((ImmHash)___nl__0).getHashValue()["left"];
//line 237
___nl__1 = generator_java_NL.NL_print_register_as_number_priv(___nl__2);

//line 237
___nl__2 = null;
//line 238
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 238
___nl__3 = new ImmString("==");
//line 238
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 238
___nl__3 = null;
//line 238
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_3;}}
//line 238
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 238
___nl__3 = new ImmString("!=");
//line 238
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 238
___nl__3 = null;
//line 238
label_3:
//line 238
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 238
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 239
___nl__3 = new ImmString(".compareTo(");
//line 239
___nl__5 = ((ImmHash)___nl__0).getHashValue()["right"];
//line 239
___nl__4 = generator_java_NL.NL_print_register_as_number_priv(___nl__5);

//line 239
___nl__5 = null;
//line 239
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 239
___nl__4 = null;
//line 239
___nl__4 = new ImmString(") ");
//line 239
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 239
___nl__4 = null;
//line 239
___nl__4 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 239
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 239
___nl__4 = null;
//line 239
___nl__4 = new ImmString(" 0");
//line 239
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 239
___nl__4 = null;
//line 239
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString());
//line 239
___nl__3 = null;
//line 240
if (true) {goto label_1;}
//line 240
label_2:
//line 241
___nl__3 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 241
___nl__5 = ((ImmHash)___nl__0).getHashValue()["right"];
//line 241
___nl__4 = generator_java_NL.NL_print_register_as_number_priv(___nl__5);

//line 241
___nl__5 = null;
//line 241
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 241
___nl__4 = null;
//line 241
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString());
//line 241
___nl__3 = null;
//line 242
if (true) {goto label_1;}
//line 242
label_1:
//line 242
___nl__2 = null;
//line 243
___nl__0 = null;
//line 243
if(true) return ___nl__1;
//line 243
___nl__1 = null;
//line 243
___nl__0 = null;
//line 243
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
//line 247
___nl__1 = new ImmString("(Double.valueOf(String.valueOf(");
//line 247
___nl__2 = generator_java_NL.NL_print_register_getter_priv(___nl__0);

//line 247
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 247
___nl__2 = null;
//line 247
___nl__2 = generator_java_NL.NL_print_getter_priv();

//line 247
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 247
___nl__2 = null;
//line 247
___nl__2 = new ImmString(")))");
//line 247
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 247
___nl__2 = null;
//line 247
___nl__0 = null;
//line 247
if(true) return ___nl__1;
//line 247
___nl__1 = null;
//line 247
___nl__0 = null;
//line 247
if(true) return null;
}

private static Imm NL_SINGLETON_print_int_value_priv() {

Imm ___nl__0 = null;
ImmRef ___ref______nl__0 = null;
Dictionary<String, Imm> __function_map;
//line 251
___nl__0 = new ImmString(".intValue()");
//line 251
if(true) return ___nl__0;
//line 251
___nl__0 = null;
//line 251
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_print_int_value_priv = null;
private static Imm NL_print_int_value_priv() {
	if (value__singleton__NL_SINGLETON_print_int_value_priv == null) {
		value__singleton__NL_SINGLETON_print_int_value_priv = NL_SINGLETON_print_int_value_priv();
	}
	return value__singleton__NL_SINGLETON_print_int_value_priv;
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
//line 255
___nl__4 = new ImmString("");
//line 255
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__1.toString().Equals(___nl__4.toString()));
//line 255
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 255
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 255
___nl__5 = new ImmString("_priv");
//line 255
___nl__5 = new ImmString(___nl__2.toString() + ___nl__5.toString());
//line 255
___nl__2 = ___nl__5;
//line 255
___nl__5 = null;
//line 255
if (true) {goto label_2;}
//line 255
label_2:
//line 255
___nl__4 = null;
//line 256
___nl__4 = new ImmString("");
//line 256
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__1.toString().Equals(___nl__4.toString()));
//line 256
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4));
//line 256
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_4;}}
//line 256
___nl__1 = ___nl__0;
//line 256
if (true) {goto label_4;}
//line 256
label_4:
//line 256
___nl__4 = null;
//line 257
___nl__4 = generator_java_NL.NL_get_class_name_priv(___nl__1);

//line 257
___nl__5 = new ImmString(".");
//line 257
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 257
___nl__5 = null;
//line 257
___nl__5 = ___nl__2;
//line 257
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 257
___nl__5 = null;
//line 257
___nl__5 = new ImmString("_nl(");
//line 257
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 257
___nl__5 = null;
//line 258
___nl__5 = new ImmDouble(0);
//line 259
___nl__7 = new ImmDouble(0);
//line 259
___nl__8 = new ImmDouble(1);
//line 259
___nl__9 = c_rt_lib_NL.NL_array_len(___nl__3);

//line 259
label_7:
//line 259
___nl__10 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))>=(Double.Parse(___nl__9.getValue().ToString())) );
//line 259
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_5;}}
//line 259
___nl__6 = (___nl__3 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 260
___nl__11 = new ImmDouble(0);
//line 260
___nl__11 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString())) ==((Double.Parse(___nl__11.getValue().ToString())))  );
//line 260
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11));
//line 260
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11));
//line 260
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_9;}}
//line 260
___nl__12 = new ImmString(",");
//line 260
___nl__4 = new ImmString(___nl__4.toString() + ___nl__12.toString());
//line 260
___nl__12 = null;
//line 260
if (true) {goto label_9;}
//line 260
label_9:
//line 260
___nl__11 = null;
//line 261
___nl__11 = new ImmDouble(1);
//line 261
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__11.getValue().ToString())));
//line 261
___nl__11 = null;
//line 262
___nl__11 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("ref"));
//line 262
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_11;}}
//line 264
___nl__11 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("val"));
//line 264
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_12;}}
//line 264
___nl__11 = new ImmString("NOMATCHALERT");
//line 264
___nl__11 = new ImmArray(new Imm[] {___nl__11,___nl__6,});
//line 264
c_rt_lib_NL.NL_die();
//line 262
label_11:
//line 262
___nl__12 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("ref"));
//line 263
___nl__13 = generator_java_NL.NL_print_register_priv(___nl__12);

//line 263
___nl__4 = new ImmString(___nl__4.toString() + ___nl__13.toString());
//line 263
___nl__13 = null;
//line 263
___nl__12 = null;
//line 264
if (true) {goto label_10;}
//line 264
label_12:
//line 264
___nl__12 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("val"));
//line 265
___nl__13 = generator_java_NL.NL_print_register_priv(___nl__12);

//line 265
___nl__4 = new ImmString(___nl__4.toString() + ___nl__13.toString());
//line 265
___nl__13 = null;
//line 265
___nl__12 = null;
//line 266
if (true) {goto label_10;}
//line 266
label_10:
//line 266
___nl__11 = null;
//line 267
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString())));
//line 267
if (true) {goto label_7;}
//line 267
label_5:
//line 267
___nl__6 = null;
//line 267
___nl__7 = null;
//line 267
___nl__8 = null;
//line 267
___nl__9 = null;
//line 267
___nl__10 = null;
//line 268
___nl__6 = new ImmString(")");
//line 268
___nl__6 = new ImmString(___nl__4.toString() + ___nl__6.toString());
//line 268
___nl__0 = null;
//line 268
___nl__1 = null;
//line 268
___nl__2 = null;
//line 268
___nl__3 = null;
//line 268
___nl__4 = null;
//line 268
___nl__5 = null;
//line 268
if(true) return ___nl__6;
//line 268
___nl__6 = null;
//line 268
___nl__4 = null;
//line 268
___nl__5 = null;
//line 268
___nl__0 = null;
//line 268
___nl__1 = null;
//line 268
___nl__2 = null;
//line 268
___nl__3 = null;
//line 268
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
//line 272
___nl__2 = new ImmString("new Imm[] {");
//line 273
___nl__4 = new ImmDouble(0);
//line 273
___nl__5 = new ImmDouble(1);
//line 273
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__1);

//line 273
label_3:
//line 273
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) );
//line 273
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_1;}}
//line 273
___nl__3 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()];
//line 273
___nl__8 = generator_java_NL.NL_print_const_value_priv(___nl__0,___nl__3);

//line 273
___nl__9 = new ImmString(",");
//line 273
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 273
___nl__9 = null;
//line 273
___nl__2 = new ImmString(___nl__2.toString() + ___nl__8.toString());
//line 273
___nl__8 = null;
//line 273
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString())));
//line 273
if (true) {goto label_3;}
//line 273
label_1:
//line 273
___nl__3 = null;
//line 273
___nl__4 = null;
//line 273
___nl__5 = null;
//line 273
___nl__6 = null;
//line 273
___nl__7 = null;
//line 274
___nl__3 = new ImmString("}");
//line 274
___nl__3 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 274
___nl__0 = null;
//line 274
___nl__1 = null;
//line 274
___nl__2 = null;
//line 274
if(true) return ___nl__3;
//line 274
___nl__3 = null;
//line 274
___nl__2 = null;
//line 274
___nl__0 = null;
//line 274
___nl__1 = null;
//line 274
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
//line 278
___nl__2 = generator_java_NL.NL_print_hash_name_priv();

//line 278
___nl__3 = new ImmString(" = new HashMap<ImmString, Imm>();");
//line 278
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 278
___nl__3 = null;
//line 278
___nl__3 = string_NL.NL_lf();

//line 278
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 278
___nl__3 = null;
//line 279
___nl__5 = c_rt_lib_NL.NL_init_iter(___nl__1);

//line 279
label_3:
//line 279
___nl__3 = c_rt_lib_NL.NL_is_end_hash(___nl__5);

//line 279
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_1;}}
//line 279
___nl__3 = c_rt_lib_NL.NL_get_key_iter(___nl__5);

//line 279
___nl__4 = c_rt_lib_NL.NL_hash_get_value(___nl__1,___nl__3);

//line 279
___nl__6 = generator_java_NL.NL_print_hash_name_priv();

//line 279
___nl__7 = new ImmString(".put(new ImmString(\"");
//line 279
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 279
___nl__7 = null;
//line 279
___nl__7 = generator_java_NL.NL_escape_string_priv(___nl__3);

//line 279
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 279
___nl__7 = null;
//line 279
___nl__7 = new ImmString("\"),");
//line 279
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 279
___nl__7 = null;
//line 279
___nl__7 = generator_java_NL.NL_print_const_value_priv(___nl__0,___nl__4);

//line 279
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 279
___nl__7 = null;
//line 279
___nl__7 = new ImmString(");");
//line 279
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 279
___nl__7 = null;
//line 279
___nl__7 = string_NL.NL_lf();

//line 279
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 279
___nl__7 = null;
//line 279
___nl__2 = new ImmString(___nl__2.toString() + ___nl__6.toString());
//line 279
___nl__6 = null;
//line 279
___nl__5 = c_rt_lib_NL.NL_next_iter(___nl__5);

//line 279
if (true) {goto label_3;}
//line 279
label_1:
//line 279
___nl__3 = null;
//line 279
___nl__4 = null;
//line 279
___nl__5 = null;
//line 280
___nl__4 = new ImmString("new ImmMap(");
//line 280
___nl__5 = generator_java_NL.NL_print_hash_name_priv();

//line 280
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 280
___nl__5 = null;
//line 280
___nl__5 = new ImmString(")");
//line 280
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 280
___nl__5 = null;
//line 280
___nl__3 = generator_java_NL.NL_print_register_setter_priv(___nl__0,___nl__4);

//line 280
___nl__4 = null;
//line 280
___nl__3 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 280
___nl__0 = null;
//line 280
___nl__1 = null;
//line 280
___nl__2 = null;
//line 280
if(true) return ___nl__3;
//line 280
___nl__3 = null;
//line 280
___nl__2 = null;
//line 280
___nl__0 = null;
//line 280
___nl__1 = null;
//line 280
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
//line 284
___nl__2 = new ImmString("");
//line 285
___nl__3 = ov_NL.NL_has_value(___nl__1);

//line 285
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3));
//line 285
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 286
___nl__4 = new ImmString("new OV(\"");
//line 286
___nl__6 = ov_NL.NL_get_element(___nl__1);

//line 286
___nl__5 = generator_java_NL.NL_escape_string_priv(___nl__6);

//line 286
___nl__6 = null;
//line 286
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 286
___nl__5 = null;
//line 286
___nl__5 = new ImmString("\", ");
//line 286
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 286
___nl__5 = null;
//line 286
___nl__6 = ov_NL.NL_get_value(___nl__1);

//line 286
___nl__5 = generator_java_NL.NL_print_const_value_priv(___nl__0,___nl__6);

//line 286
___nl__6 = null;
//line 286
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 286
___nl__5 = null;
//line 286
___nl__5 = new ImmString(")");
//line 286
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 286
___nl__5 = null;
//line 286
___nl__2 = ___nl__4;
//line 286
___nl__4 = null;
//line 287
if (true) {goto label_1;}
//line 287
label_2:
//line 288
___nl__4 = new ImmString("new OV(\"");
//line 288
___nl__6 = ov_NL.NL_get_element(___nl__1);

//line 288
___nl__5 = generator_java_NL.NL_escape_string_priv(___nl__6);

//line 288
___nl__6 = null;
//line 288
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 288
___nl__5 = null;
//line 288
___nl__5 = new ImmString("\", null)");
//line 288
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 288
___nl__5 = null;
//line 288
___nl__2 = ___nl__4;
//line 288
___nl__4 = null;
//line 289
if (true) {goto label_1;}
//line 289
label_1:
//line 289
___nl__3 = null;
//line 290
___nl__0 = null;
//line 290
___nl__1 = null;
//line 290
if(true) return ___nl__2;
//line 290
___nl__2 = null;
//line 290
___nl__0 = null;
//line 290
___nl__1 = null;
//line 290
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
//line 294
___nl__2 = nl_NL.NL_is_sim(___nl__1);

//line 294
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 294
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_4;}}
//line 294
___nl__5 = ptd_NL.NL_sim();

//line 294
___nl__4 = ptd_NL.NL_ensure(___nl__5,___nl__1);

//line 294
___nl__5 = null;
//line 294
___nl__2 = string_utils_NL.NL_is_integer(___nl__4);

//line 294
___nl__4 = null;
//line 294
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_4;}}
//line 294
___nl__5 = ptd_NL.NL_sim();

//line 294
___nl__4 = ptd_NL.NL_ensure(___nl__5,___nl__1);

//line 294
___nl__5 = null;
//line 294
___nl__2 = string_utils_NL.NL_is_float(___nl__4);

//line 294
___nl__4 = null;
//line 294
label_4:
//line 294
___nl__3 = null;
//line 294
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 294
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 296
___nl__3 = new ImmString("new ImmDouble(");
//line 296
___nl__3 = new ImmString(___nl__3.toString() + ___nl__1.toString());
//line 296
___nl__4 = new ImmString(")");
//line 296
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 296
___nl__4 = null;
//line 296
___nl__0 = null;
//line 296
___nl__1 = null;
//line 296
___nl__2 = null;
//line 296
if(true) return ___nl__3;
//line 296
___nl__3 = null;
//line 297
if (true) {goto label_1;}
//line 297
label_2:
//line 297
___nl__2 = nl_NL.NL_is_sim(___nl__1);

//line 297
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 297
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_5;}}
//line 298
___nl__3 = new ImmString("new ImmString(\"");
//line 298
___nl__4 = generator_java_NL.NL_escape_string_priv(___nl__1);

//line 298
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 298
___nl__4 = null;
//line 298
___nl__4 = new ImmString("\")");
//line 298
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 298
___nl__4 = null;
//line 298
___nl__0 = null;
//line 298
___nl__1 = null;
//line 298
___nl__2 = null;
//line 298
if(true) return ___nl__3;
//line 298
___nl__3 = null;
//line 299
if (true) {goto label_1;}
//line 299
label_5:
//line 299
___nl__2 = nl_NL.NL_is_array(___nl__1);

//line 299
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 299
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_6;}}
//line 300
___nl__3 = generator_java_NL.NL_print_const_arr_priv(___nl__0,___nl__1);

//line 300
___nl__0 = null;
//line 300
___nl__1 = null;
//line 300
___nl__2 = null;
//line 300
if(true) return ___nl__3;
//line 300
___nl__3 = null;
//line 301
if (true) {goto label_1;}
//line 301
label_6:
//line 301
___nl__2 = nl_NL.NL_is_hash(___nl__1);

//line 301
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 301
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_7;}}
//line 302
___nl__3 = generator_java_NL.NL_print_const_hash_priv(___nl__0,___nl__1);

//line 302
___nl__0 = null;
//line 302
___nl__1 = null;
//line 302
___nl__2 = null;
//line 302
if(true) return ___nl__3;
//line 302
___nl__3 = null;
//line 303
if (true) {goto label_1;}
//line 303
label_7:
//line 303
___nl__2 = nl_NL.NL_is_variant(___nl__1);

//line 303
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 303
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_8;}}
//line 304
___nl__3 = generator_java_NL.NL_print_const_ov_priv(___nl__0,___nl__1);

//line 304
___nl__0 = null;
//line 304
___nl__1 = null;
//line 304
___nl__2 = null;
//line 304
if(true) return ___nl__3;
//line 304
___nl__3 = null;
//line 305
if (true) {goto label_1;}
//line 305
label_8:
//line 306
___nl__3 = new ImmArray(new Imm[0]);
//line 306
c_rt_lib_NL.NL_die();
//line 306
___nl__3 = null;
//line 307
if (true) {goto label_1;}
//line 307
label_1:
//line 307
___nl__2 = null;
//line 307
___nl__0 = null;
//line 307
___nl__1 = null;
//line 307
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
//line 311
___nl__1 = new ImmString("if (true) {label = \"");
//line 311
___nl__1 = new ImmString(___nl__1.toString() + ___nl__0.toString());
//line 311
___nl__2 = new ImmString("\"; continue; }");
//line 311
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 311
___nl__2 = null;
//line 311
___nl__0 = null;
//line 311
if(true) return ___nl__1;
//line 311
___nl__1 = null;
//line 311
___nl__0 = null;
//line 311
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
//line 315
___nl__1 = generator_java_NL.NL_print_hash_name_priv();

//line 315
___nl__2 = new ImmString(" = new HashMap<ImmString, Imm>();");
//line 315
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 315
___nl__2 = null;
//line 315
___nl__2 = string_NL.NL_lf();

//line 315
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 315
___nl__2 = null;
//line 316
___nl__2 = ((ImmHash)___nl__0).getHashValue()["src"];
//line 316
___nl__4 = new ImmDouble(0);
//line 316
___nl__5 = new ImmDouble(1);
//line 316
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__2);

//line 316
label_3:
//line 316
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) );
//line 316
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_1;}}
//line 316
___nl__3 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()];
//line 316
___nl__8 = generator_java_NL.NL_print_hash_name_priv();

//line 316
___nl__9 = new ImmString(".put(new ImmString(\"");
//line 316
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 316
___nl__9 = null;
//line 316
___nl__10 = ((ImmHash)___nl__3).getHashValue()["key"];
//line 316
___nl__9 = generator_java_NL.NL_escape_string_priv(___nl__10);

//line 316
___nl__10 = null;
//line 316
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 316
___nl__9 = null;
//line 316
___nl__9 = new ImmString("\"),");
//line 316
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 316
___nl__9 = null;
//line 316
___nl__10 = ((ImmHash)___nl__3).getHashValue()["val"];
//line 316
___nl__9 = generator_java_NL.NL_print_register_getter_priv(___nl__10);

//line 316
___nl__10 = null;
//line 316
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 316
___nl__9 = null;
//line 316
___nl__9 = new ImmString(");");
//line 316
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 316
___nl__9 = null;
//line 316
___nl__9 = string_NL.NL_lf();

//line 316
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 316
___nl__9 = null;
//line 316
___nl__1 = new ImmString(___nl__1.toString() + ___nl__8.toString());
//line 316
___nl__8 = null;
//line 316
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString())));
//line 316
if (true) {goto label_3;}
//line 316
label_1:
//line 316
___nl__2 = null;
//line 316
___nl__3 = null;
//line 316
___nl__4 = null;
//line 316
___nl__5 = null;
//line 316
___nl__6 = null;
//line 316
___nl__7 = null;
//line 317
___nl__0 = null;
//line 317
if(true) return ___nl__1;
//line 317
___nl__1 = null;
//line 317
___nl__0 = null;
//line 317
if(true) return null;
}

private static Imm NL_SINGLETON_print_hash_name_priv() {

Imm ___nl__0 = null;
ImmRef ___ref______nl__0 = null;
Dictionary<String, Imm> __function_map;
//line 321
___nl__0 = new ImmString("__function_map");
//line 321
if(true) return ___nl__0;
//line 321
___nl__0 = null;
//line 321
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
//line 325
___nl__1 = new ImmString("((ImmMap)");
//line 325
___nl__3 = ((ImmHash)___nl__0).getHashValue()["src"];
//line 325
___nl__2 = generator_java_NL.NL_print_register_getter_priv(___nl__3);

//line 325
___nl__3 = null;
//line 325
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 325
___nl__2 = null;
//line 325
___nl__2 = new ImmString(")");
//line 325
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 325
___nl__2 = null;
//line 325
___nl__2 = generator_java_NL.NL_print_getter_priv();

//line 325
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 325
___nl__2 = null;
//line 325
___nl__2 = new ImmString(".get(new ImmString(\"");
//line 325
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 325
___nl__2 = null;
//line 325
___nl__3 = ((ImmHash)___nl__0).getHashValue()["key"];
//line 325
___nl__2 = generator_java_NL.NL_escape_string_priv(___nl__3);

//line 325
___nl__3 = null;
//line 325
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 325
___nl__2 = null;
//line 325
___nl__2 = new ImmString("\"))");
//line 325
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 325
___nl__2 = null;
//line 325
___nl__0 = null;
//line 325
if(true) return ___nl__1;
//line 325
___nl__1 = null;
//line 325
___nl__0 = null;
//line 325
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
//line 329
___nl__1 = new ImmString("((ImmMap)");
//line 329
___nl__3 = ((ImmHash)___nl__0).getHashValue()["src"];
//line 329
___nl__2 = generator_java_NL.NL_print_register_getter_priv(___nl__3);

//line 329
___nl__3 = null;
//line 329
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 329
___nl__2 = null;
//line 329
___nl__2 = new ImmString(")");
//line 329
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 329
___nl__2 = null;
//line 329
___nl__2 = generator_java_NL.NL_print_getter_priv();

//line 329
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 329
___nl__2 = null;
//line 329
___nl__2 = new ImmString(".put(new ImmString(\"");
//line 329
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 329
___nl__2 = null;
//line 329
___nl__3 = ((ImmHash)___nl__0).getHashValue()["key"];
//line 329
___nl__2 = generator_java_NL.NL_escape_string_priv(___nl__3);

//line 329
___nl__3 = null;
//line 329
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 329
___nl__2 = null;
//line 329
___nl__2 = new ImmString("\"), ");
//line 329
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 329
___nl__2 = null;
//line 330
___nl__3 = ((ImmHash)___nl__0).getHashValue()["val"];
//line 330
___nl__2 = generator_java_NL.NL_print_register_getter_priv(___nl__3);

//line 330
___nl__3 = null;
//line 330
___nl__3 = new ImmString(")");
//line 330
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 330
___nl__3 = null;
//line 330
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 330
___nl__2 = null;
//line 331
___nl__0 = null;
//line 331
if(true) return ___nl__1;
//line 331
___nl__1 = null;
//line 331
___nl__0 = null;
//line 331
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
//line 335
___nl__1 = new ImmString("");
//line 336
___nl__2 = ((ImmHash)___nl__0).getHashValue()["src"];
//line 336
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("emp"));
//line 336
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 336
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 336
___nl__2 = ((ImmHash)___nl__0).getHashValue()["name"];
//line 336
___nl__4 = new ImmString("TRUE");
//line 336
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__4.toString()));
//line 336
___nl__4 = null;
//line 336
label_3:
//line 336
___nl__3 = null;
//line 336
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 336
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 337
___nl__3 = new ImmString("c_rt_lib_NL.get_true_nl()");
//line 337
___nl__1 = ___nl__3;
//line 337
___nl__3 = null;
//line 338
if (true) {goto label_1;}
//line 338
label_2:
//line 338
___nl__2 = ((ImmHash)___nl__0).getHashValue()["src"];
//line 338
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("emp"));
//line 338
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 338
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_5;}}
//line 338
___nl__2 = ((ImmHash)___nl__0).getHashValue()["name"];
//line 338
___nl__4 = new ImmString("FALSE");
//line 338
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__4.toString()));
//line 338
___nl__4 = null;
//line 338
label_5:
//line 338
___nl__3 = null;
//line 338
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 338
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_4;}}
//line 339
___nl__3 = new ImmString("c_rt_lib_NL.get_false_nl()");
//line 339
___nl__1 = ___nl__3;
//line 339
___nl__3 = null;
//line 340
if (true) {goto label_1;}
//line 340
label_4:
//line 341
___nl__3 = ((ImmHash)___nl__0).getHashValue()["src"];
//line 341
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("arg"));
//line 341
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_7;}}
//line 343
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("emp"));
//line 343
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_8;}}
//line 343
___nl__4 = new ImmString("NOMATCHALERT");
//line 343
___nl__4 = new ImmArray(new Imm[] {___nl__4,___nl__3,});
//line 343
c_rt_lib_NL.NL_die();
//line 341
label_7:
//line 341
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("arg"));
//line 342
___nl__6 = new ImmString("c_rt_lib_NL.ov_mk_arg_nl(new ImmString(\"");
//line 342
___nl__8 = ((ImmHash)___nl__0).getHashValue()["name"];
//line 342
___nl__7 = generator_java_NL.NL_escape_string_priv(___nl__8);

//line 342
___nl__8 = null;
//line 342
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 342
___nl__7 = null;
//line 342
___nl__7 = new ImmString("\"), ");
//line 342
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 342
___nl__7 = null;
//line 342
___nl__7 = generator_java_NL.NL_print_register_priv(___nl__5);

//line 342
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 342
___nl__7 = null;
//line 342
___nl__7 = new ImmString(")");
//line 342
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 342
___nl__7 = null;
//line 342
___nl__1 = ___nl__6;
//line 342
___nl__6 = null;
//line 342
___nl__5 = null;
//line 343
if (true) {goto label_6;}
//line 343
label_8:
//line 344
___nl__5 = new ImmString("c_rt_lib_NL.ov_mk_none_nl(new ImmString(\"");
//line 344
___nl__7 = ((ImmHash)___nl__0).getHashValue()["name"];
//line 344
___nl__6 = generator_java_NL.NL_escape_string_priv(___nl__7);

//line 344
___nl__7 = null;
//line 344
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 344
___nl__6 = null;
//line 344
___nl__6 = new ImmString("\"))");
//line 344
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 344
___nl__6 = null;
//line 344
___nl__1 = ___nl__5;
//line 344
___nl__5 = null;
//line 345
if (true) {goto label_6;}
//line 345
label_6:
//line 345
___nl__3 = null;
//line 345
___nl__4 = null;
//line 346
if (true) {goto label_1;}
//line 346
label_1:
//line 346
___nl__2 = null;
//line 347
___nl__3 = ((ImmHash)___nl__0).getHashValue()["dest"];
//line 347
___nl__2 = generator_java_NL.NL_print_register_setter_priv(___nl__3,___nl__1);

//line 347
___nl__3 = null;
//line 347
___nl__3 = new ImmString(";");
//line 347
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 347
___nl__3 = null;
//line 347
___nl__0 = null;
//line 347
___nl__1 = null;
//line 347
if(true) return ___nl__2;
//line 347
___nl__2 = null;
//line 347
___nl__1 = null;
//line 347
___nl__0 = null;
//line 347
if(true) return null;
}

private static Imm NL_print_register_priv(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 351
___nl__1 = new ImmString("___nl__");
//line 351
___nl__1 = new ImmString(___nl__1.toString() + ___nl__0.toString());
//line 351
___nl__0 = null;
//line 351
if(true) return ___nl__1;
//line 351
___nl__1 = null;
//line 351
___nl__0 = null;
//line 351
if(true) return null;
}

private static Imm NL_print_register_getter_priv(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 355
___nl__1 = generator_java_NL.NL_print_register_priv(___nl__0);

//line 355
___nl__2 = generator_java_NL.NL_print_getter_priv();

//line 355
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString());
//line 355
___nl__2 = null;
//line 355
___nl__0 = null;
//line 355
if(true) return ___nl__1;
//line 355
___nl__1 = null;
//line 355
___nl__0 = null;
//line 355
if(true) return null;
}

private static Imm NL_SINGLETON_print_getter_priv() {

Imm ___nl__0 = null;
ImmRef ___ref______nl__0 = null;
Dictionary<String, Imm> __function_map;
//line 359
___nl__0 = new ImmString(".getValue()");
//line 359
if(true) return ___nl__0;
//line 359
___nl__0 = null;
//line 359
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
//line 363
___nl__2 = new ImmString("");
//line 363
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__2.toString()));
//line 363
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 363
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 363
___nl__3 = new ImmString("");
//line 363
___nl__3 = new ImmString(___nl__1.toString() + ___nl__3.toString());
//line 363
___nl__0 = null;
//line 363
___nl__1 = null;
//line 363
___nl__2 = null;
//line 363
if(true) return ___nl__3;
//line 363
___nl__3 = null;
//line 363
if (true) {goto label_2;}
//line 363
label_2:
//line 363
___nl__2 = null;
//line 364
___nl__2 = generator_java_NL.NL_print_register_priv(___nl__0);

//line 364
___nl__3 = new ImmString(".setValue(");
//line 364
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 364
___nl__3 = null;
//line 364
___nl__2 = new ImmString(___nl__2.toString() + ___nl__1.toString());
//line 364
___nl__3 = new ImmString(")");
//line 364
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 364
___nl__3 = null;
//line 364
___nl__0 = null;
//line 364
___nl__1 = null;
//line 364
if(true) return ___nl__2;
//line 364
___nl__2 = null;
//line 364
___nl__0 = null;
//line 364
___nl__1 = null;
//line 364
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
//line 368
___nl__1 = new ImmString("");
//line 369
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("val"));
//line 369
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 371
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("emp"));
//line 371
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_3;}}
//line 371
___nl__2 = new ImmString("NOMATCHALERT");
//line 371
___nl__2 = new ImmArray(new Imm[] {___nl__2,___nl__0,});
//line 371
c_rt_lib_NL.NL_die();
//line 369
label_2:
//line 369
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("val"));
//line 370
___nl__4 = new ImmString("return ");
//line 370
___nl__5 = generator_java_NL.NL_print_register_getter_priv(___nl__3);

//line 370
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 370
___nl__5 = null;
//line 370
___nl__5 = new ImmString(";");
//line 370
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 370
___nl__5 = null;
//line 370
___nl__1 = ___nl__4;
//line 370
___nl__4 = null;
//line 370
___nl__3 = null;
//line 371
if (true) {goto label_1;}
//line 371
label_3:
//line 372
___nl__3 = new ImmString("return null;");
//line 372
___nl__1 = ___nl__3;
//line 372
___nl__3 = null;
//line 373
if (true) {goto label_1;}
//line 373
label_1:
//line 373
___nl__2 = null;
//line 374
___nl__2 = new ImmString("if(true) ");
//line 374
___nl__2 = new ImmString(___nl__2.toString() + ___nl__1.toString());
//line 374
___nl__0 = null;
//line 374
___nl__1 = null;
//line 374
if(true) return ___nl__2;
//line 374
___nl__2 = null;
//line 374
___nl__1 = null;
//line 374
___nl__0 = null;
//line 374
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
//line 378
___nl__1 = new ImmString("");
//line 379
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 379
___nl__3 = new ImmString("!");
//line 379
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 379
___nl__3 = null;
//line 379
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 379
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 380
___nl__3 = new ImmString("c_rt_lib_NL.native_to_nl_nl(!c_rt_lib_NL.check_true_native_nl(");
//line 380
___nl__5 = ((ImmHash)___nl__0).getHashValue()["src"];
//line 380
___nl__4 = generator_java_NL.NL_print_register_priv(___nl__5);

//line 380
___nl__5 = null;
//line 380
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 380
___nl__4 = null;
//line 380
___nl__4 = new ImmString("))");
//line 380
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 380
___nl__4 = null;
//line 380
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString());
//line 380
___nl__3 = null;
//line 381
if (true) {goto label_1;}
//line 381
label_2:
//line 382
___nl__3 = new ImmString("new ImmDouble(");
//line 382
___nl__4 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 382
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 382
___nl__4 = null;
//line 382
___nl__4 = new ImmString("((ImmDouble)");
//line 382
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 382
___nl__4 = null;
//line 382
___nl__5 = ((ImmHash)___nl__0).getHashValue()["src"];
//line 382
___nl__4 = generator_java_NL.NL_print_register_getter_priv(___nl__5);

//line 382
___nl__5 = null;
//line 382
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 382
___nl__4 = null;
//line 382
___nl__4 = new ImmString(")");
//line 382
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 382
___nl__4 = null;
//line 382
___nl__4 = generator_java_NL.NL_print_getter_priv();

//line 382
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 382
___nl__4 = null;
//line 382
___nl__4 = new ImmString(")");
//line 382
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 382
___nl__4 = null;
//line 382
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString());
//line 382
___nl__3 = null;
//line 383
if (true) {goto label_1;}
//line 383
label_1:
//line 383
___nl__2 = null;
//line 384
___nl__3 = ((ImmHash)___nl__0).getHashValue()["dest"];
//line 384
___nl__2 = generator_java_NL.NL_print_register_setter_priv(___nl__3,___nl__1);

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

}
}