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
___nl__1 = new ImmString("").clone();
//line 17
___nl__2 = generator_java_NL.NL_print_package_name_priv().clone();

//line 17
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 17
___nl__2 = null;
//line 18
___nl__2 = generator_java_NL.NL_print_imports_priv(___nl__0).clone();

//line 18
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 18
___nl__2 = null;
//line 19
___nl__3 = ((ImmHash)___nl__0).getHashValue()["module_name"].clone();
//line 19
___nl__2 = generator_java_NL.NL_print_class_begin_priv(___nl__3).clone();

//line 19
___nl__3 = null;
//line 19
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 19
___nl__2 = null;
//line 20
___nl__2 = ((ImmHash)___nl__0).getHashValue()["functions"].clone();
//line 20
___nl__4 = new ImmDouble(0).clone();
//line 20
___nl__5 = new ImmDouble(1).clone();
//line 20
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__2).clone();

//line 20
label_3:
//line 20
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) ).clone();
//line 20
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_1;}}
//line 20
___nl__3 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()].clone();
//line 20
___nl__9 = ((ImmHash)___nl__0).getHashValue()["module_name"].clone();
//line 20
___nl__8 = generator_java_NL.NL_print_function_or_singleton_priv(___nl__3,___nl__9).clone();

//line 20
___nl__9 = null;
//line 20
___nl__1 = new ImmString(___nl__1.toString() + ___nl__8.toString()).clone();
//line 20
___nl__8 = null;
//line 20
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
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
___nl__2 = generator_java_NL.NL_print_class_end_priv().clone();

//line 21
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
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
___nl__0 = new ImmString("package com.atinea.nianio;").clone();
//line 26
___nl__1 = string_NL.NL_lf().clone();

//line 26
___nl__0 = new ImmString(___nl__0.toString() + ___nl__1.toString()).clone();
//line 26
___nl__1 = null;
//line 26
___nl__1 = string_NL.NL_lf().clone();

//line 26
___nl__0 = new ImmString(___nl__0.toString() + ___nl__1.toString()).clone();
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
___nl__1 = new ImmString("").clone();
//line 31
___nl__2 = new ImmString("import java.util.Map;").clone();
//line 31
___nl__3 = string_NL.NL_lf().clone();

//line 31
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 31
___nl__3 = null;
//line 31
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 31
___nl__2 = null;
//line 32
___nl__2 = new ImmString("import java.util.HashMap;").clone();
//line 32
___nl__3 = string_NL.NL_lf().clone();

//line 32
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 32
___nl__3 = null;
//line 32
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 32
___nl__2 = null;
//line 33
___nl__2 = ((ImmHash)___nl__0).getHashValue()["imports"].clone();
//line 33
___nl__4 = new ImmDouble(0).clone();
//line 33
___nl__5 = new ImmDouble(1).clone();
//line 33
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__2).clone();

//line 33
label_3:
//line 33
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) ).clone();
//line 33
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_1;}}
//line 33
___nl__3 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()].clone();
//line 34
___nl__8 = new ImmString("import com.atinea.nianio.").clone();
//line 34
___nl__9 = generator_java_NL.NL_get_class_name_priv(___nl__3).clone();

//line 34
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 34
___nl__9 = null;
//line 34
___nl__9 = new ImmString(";").clone();
//line 34
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 34
___nl__9 = null;
//line 34
___nl__9 = string_NL.NL_lf().clone();

//line 34
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 34
___nl__9 = null;
//line 34
___nl__1 = new ImmString(___nl__1.toString() + ___nl__8.toString()).clone();
//line 34
___nl__8 = null;
//line 35
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
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
___nl__1 = new ImmString("_NL").clone();
//line 40
___nl__1 = new ImmString(___nl__0.toString() + ___nl__1.toString()).clone();
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
___nl__1 = new ImmString("public class ").clone();
//line 44
___nl__2 = generator_java_NL.NL_get_class_name_priv(___nl__0).clone();

//line 44
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 44
___nl__2 = null;
//line 44
___nl__2 = new ImmString(" {").clone();
//line 44
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 44
___nl__2 = null;
//line 44
___nl__2 = string_NL.NL_lf().clone();

//line 44
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
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
___nl__0 = string_NL.NL_lf().clone();

//line 48
___nl__1 = new ImmString("}").clone();
//line 48
___nl__0 = new ImmString(___nl__0.toString() + ___nl__1.toString()).clone();
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
___nl__1 = new ImmString("").clone();
//line 53
___nl__2 = ((ImmHash)___nl__0).getHashValue()["access"].clone();
//line 53
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("pub")).clone();
//line 53
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 54
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("priv")).clone();
//line 54
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 54
___nl__3 = new ImmString("NOMATCHALERT").clone();
//line 54
___nl__3 = new ImmArray(new Imm[] {___nl__3,___nl__2,}).clone();
//line 54
c_rt_lib_NL.NL_die();
//line 53
label_2:
//line 54
if (true) {goto label_1;}
//line 54
label_3:
//line 55
___nl__4 = new ImmString("_priv").clone();
//line 55
___nl__1 = ___nl__4.clone();
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
___nl__2 = ((ImmHash)___nl__0).getHashValue()["name"].clone();
//line 57
___nl__2 = new ImmString(___nl__2.toString() + ___nl__1.toString()).clone();
//line 57
___nl__3 = new ImmString("_nl").clone();
//line 57
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
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
___nl__1 = new ImmString("").clone();
//line 62
___nl__2 = ((ImmHash)___nl__0).getHashValue()["access"].clone();
//line 62
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("pub")).clone();
//line 62
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 64
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("priv")).clone();
//line 64
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 64
___nl__3 = new ImmString("NOMATCHALERT").clone();
//line 64
___nl__3 = new ImmArray(new Imm[] {___nl__3,___nl__2,}).clone();
//line 64
c_rt_lib_NL.NL_die();
//line 62
label_2:
//line 63
___nl__4 = new ImmString("public").clone();
//line 63
___nl__1 = ___nl__4.clone();
//line 63
___nl__4 = null;
//line 64
if (true) {goto label_1;}
//line 64
label_3:
//line 65
___nl__4 = new ImmString("private").clone();
//line 65
___nl__1 = ___nl__4.clone();
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
___nl__2 = new ImmString(" static Imm ").clone();
//line 67
___nl__2 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 67
___nl__3 = generator_java_NL.NL_get_function_name_priv(___nl__0).clone();

//line 67
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
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
___nl__2 = new ImmString("\\").clone();
//line 71
___nl__3 = new ImmString("\\\\").clone();
//line 71
___nl__1 = string_NL.NL_replace(___nl__0,___nl__2,___nl__3).clone();

//line 71
___nl__3 = null;
//line 71
___nl__2 = null;
//line 71
___nl__0 = ___nl__1.clone();
//line 71
___nl__1 = null;
//line 72
___nl__2 = new ImmString("\"").clone();
//line 72
___nl__3 = new ImmString("\\\"").clone();
//line 72
___nl__1 = string_NL.NL_replace(___nl__0,___nl__2,___nl__3).clone();

//line 72
___nl__3 = null;
//line 72
___nl__2 = null;
//line 72
___nl__0 = ___nl__1.clone();
//line 72
___nl__1 = null;
//line 73
___nl__3 = new ImmDouble(13).clone();
//line 73
___nl__2 = string_NL.NL_chr(___nl__3).clone();

//line 73
___nl__3 = null;
//line 73
___nl__3 = string_NL.NL_lf().clone();

//line 73
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 73
___nl__3 = null;
//line 73
___nl__3 = new ImmString("\\r\\n").clone();
//line 73
___nl__1 = string_NL.NL_replace(___nl__0,___nl__2,___nl__3).clone();

//line 73
___nl__3 = null;
//line 73
___nl__2 = null;
//line 73
___nl__0 = ___nl__1.clone();
//line 73
___nl__1 = null;
//line 74
___nl__2 = string_NL.NL_lf().clone();

//line 74
___nl__3 = new ImmString("\\n").clone();
//line 74
___nl__1 = string_NL.NL_replace(___nl__0,___nl__2,___nl__3).clone();

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
___nl__2 = ((ImmHash)___nl__0).getHashValue()["args_type"].clone();
//line 77
___nl__1 = array_NL.NL_len(___nl__2).clone();

//line 77
___nl__2 = null;
//line 77
___nl__2 = new ImmDouble(0).clone();
//line 77
___nl__1 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__1.getValue().ToString()))>(Double.Parse(___nl__2.getValue().ToString())) ).clone();
//line 77
___nl__2 = null;
//line 77
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1)).clone();
//line 77
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_2;}}
//line 77
___nl__2 = c_rt_lib_NL.NL_get_false().clone();
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
___nl__1 = ((ImmHash)___nl__0).getHashValue()["annotation"].clone();
//line 78
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("math")).clone();
//line 78
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1)).clone();
//line 78
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_4;}}
//line 78
___nl__2 = c_rt_lib_NL.NL_get_true().clone();
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
___nl__1 = c_rt_lib_NL.NL_get_false().clone();
//line 81
___nl__3 = ((ImmHash)___nl__0).getHashValue()["commands"].clone();
//line 81
___nl__5 = new ImmDouble(0).clone();
//line 81
___nl__6 = new ImmDouble(1).clone();
//line 81
___nl__7 = c_rt_lib_NL.NL_array_len(___nl__3).clone();

//line 81
label_7:
//line 81
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) ).clone();
//line 81
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_5;}}
//line 81
___nl__4 = (___nl__3 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()].clone();
//line 82
___nl__9 = ((ImmHash)___nl__4).getHashValue()["cmd"].clone();
//line 83
___nl__10 = ___nl__9.clone();
//line 83
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__10, new ImmString("call")).clone();
//line 83
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 83
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_9;}}
//line 84
___nl__11 = ___nl__9.clone();
//line 84
___nl__11 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("call")).clone();
//line 85
___nl__12 = ((ImmHash)___nl__11).getHashValue()["fun_name"].clone();
//line 85
___nl__13 = new ImmString("sigleton_do_not_use_without_approval").clone();
//line 85
___nl__12 = c_rt_lib_NL.NL_native_to_nl(___nl__12.toString().Equals(___nl__13.toString())).clone();
//line 85
___nl__13 = null;
//line 85
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 85
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
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
___nl__12 = ((ImmHash)___nl__11).getHashValue()["mod"].clone();
//line 86
___nl__13 = new ImmString("singleton").clone();
//line 86
___nl__12 = c_rt_lib_NL.NL_native_to_nl(___nl__12.toString().Equals(___nl__13.toString())).clone();
//line 86
___nl__13 = null;
//line 86
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 86
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
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
___nl__12 = c_rt_lib_NL.NL_get_true().clone();
//line 87
___nl__1 = ___nl__12.clone();
//line 87
___nl__12 = null;
//line 88
___nl__12 = ((ImmHash)___nl__11).getHashValue()["dest"].clone();
//line 88
___nl__2 = ___nl__12.clone();
//line 88
___nl__12 = null;
//line 88
___nl__11 = null;
//line 89
if (true) {goto label_8;}
//line 89
label_9:
//line 89
___nl__10 = ___nl__9.clone();
//line 89
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__10, new ImmString("return")).clone();
//line 89
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 89
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_14;}}
//line 90
___nl__11 = ___nl__1.clone();
//line 90
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 90
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 90
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_16;}}
//line 90
___nl__12 = c_rt_lib_NL.NL_get_false().clone();
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
___nl__11 = ___nl__9.clone();
//line 91
___nl__11 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("return")).clone();
//line 92
___nl__12 = ___nl__11.clone();
//line 92
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__12, new ImmString("val")).clone();
//line 92
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 92
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 92
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_18;}}
//line 92
___nl__13 = c_rt_lib_NL.NL_get_false().clone();
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
___nl__12 = ___nl__11.clone();
//line 93
___nl__12 = c_rt_lib_NL.NL_ov_as(___nl__12, new ImmString("val")).clone();
//line 93
___nl__12 = c_rt_lib_NL.NL_native_to_nl(___nl__12.toString().Equals(___nl__2.toString())).clone();
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
___nl__10 = ___nl__9.clone();
//line 94
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__10, new ImmString("prt_lbl")).clone();
//line 94
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 94
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_19;}}
//line 95
if (true) {goto label_8;}
//line 95
label_19:
//line 95
___nl__10 = ___nl__9.clone();
//line 95
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__10, new ImmString("clear")).clone();
//line 95
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 95
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_20;}}
//line 96
if (true) {goto label_8;}
//line 96
label_20:
//line 97
___nl__11 = ___nl__1.clone();
//line 97
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 97
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_22;}}
//line 97
___nl__12 = c_rt_lib_NL.NL_get_false().clone();
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
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString()))).clone();
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
___nl__3 = c_rt_lib_NL.NL_get_false().clone();
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
___nl__2 = generator_java_NL.NL_is_singleton_use_function_priv(___nl__0).clone();

//line 105
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 105
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 106
___nl__3 = ___nl__0.clone();
//line 107
___nl__4 = new ImmString("SINGLETON_").clone();
//line 107
___nl__5 = ((ImmHash)___nl__0).getHashValue()["name"].clone();
//line 107
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 107
___nl__5 = null;
//line 107
___nl__5 = ___nl__4.clone();
//line 107
((ImmHash)___nl__3).set("name", ___nl__5);
//line 107
___nl__4 = null;
//line 107
___nl__5 = null;
//line 108
___nl__4 = generator_java_NL.NL_get_function_name_priv(___nl__3).clone();

//line 109
___nl__5 = new ImmString("value__singleton__").clone();
//line 109
___nl__5 = new ImmString(___nl__5.toString() + ___nl__4.toString()).clone();
//line 111
___nl__6 = generator_java_NL.NL_print_function_priv(___nl__3,___nl__1).clone();

//line 113
___nl__7 = new ImmString("private static Imm ").clone();
//line 113
___nl__7 = new ImmString(___nl__7.toString() + ___nl__5.toString()).clone();
//line 113
___nl__8 = new ImmString(" = null;").clone();
//line 113
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 113
___nl__8 = null;
//line 113
___nl__8 = string_NL.NL_lf().clone();

//line 113
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 113
___nl__8 = null;
//line 113
___nl__8 = generator_java_NL.NL_get_function_declaration_priv(___nl__0).clone();

//line 113
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 113
___nl__8 = null;
//line 113
___nl__8 = new ImmString("() throws Exception {\n	if (").clone();
//line 113
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 113
___nl__8 = null;
//line 113
___nl__7 = new ImmString(___nl__7.toString() + ___nl__5.toString()).clone();
//line 113
___nl__8 = new ImmString(" == null) {\n		").clone();
//line 113
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 113
___nl__8 = null;
//line 113
___nl__7 = new ImmString(___nl__7.toString() + ___nl__5.toString()).clone();
//line 113
___nl__8 = new ImmString(" = ").clone();
//line 113
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 113
___nl__8 = null;
//line 113
___nl__7 = new ImmString(___nl__7.toString() + ___nl__4.toString()).clone();
//line 113
___nl__8 = new ImmString("();\n	}\n	return ").clone();
//line 113
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 113
___nl__8 = null;
//line 113
___nl__7 = new ImmString(___nl__7.toString() + ___nl__5.toString()).clone();
//line 113
___nl__8 = new ImmString(";\n}").clone();
//line 113
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 113
___nl__8 = null;
//line 113
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
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
___nl__3 = generator_java_NL.NL_print_function_priv(___nl__0,___nl__1).clone();

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
___nl__2 = string_NL.NL_lf().clone();

//line 127
___nl__3 = generator_java_NL.NL_get_function_declaration_priv(___nl__0).clone();

//line 127
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 127
___nl__3 = null;
//line 127
___nl__3 = new ImmString("(").clone();
//line 127
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 127
___nl__3 = null;
//line 128
___nl__4 = ((ImmHash)___nl__0).getHashValue()["args_type"].clone();
//line 128
___nl__3 = array_NL.NL_len(___nl__4).clone();

//line 128
___nl__4 = null;
//line 128
___nl__4 = new ImmDouble(0).clone();
//line 128
___nl__5 = new ImmDouble(1).clone();
//line 128
label_3:
//line 128
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__3.getValue().ToString())) ).clone();
//line 128
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_1;}}
//line 129
___nl__7 = new ImmDouble(0).clone();
//line 129
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString())) ==((Double.Parse(___nl__7.getValue().ToString())))  ).clone();
//line 129
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 129
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 129
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_5;}}
//line 129
___nl__8 = new ImmString(", ").clone();
//line 129
___nl__2 = new ImmString(___nl__2.toString() + ___nl__8.toString()).clone();
//line 129
___nl__8 = null;
//line 129
if (true) {goto label_5;}
//line 129
label_5:
//line 129
___nl__7 = null;
//line 130
___nl__7 = new ImmString("ImmRef ___arg__").clone();
//line 130
___nl__7 = new ImmString(___nl__7.toString() + ___nl__4.toString()).clone();
//line 130
___nl__2 = new ImmString(___nl__2.toString() + ___nl__7.toString()).clone();
//line 130
___nl__7 = null;
//line 131
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
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
___nl__3 = new ImmString(") throws Exception {").clone();
//line 132
___nl__4 = string_NL.NL_lf().clone();

//line 132
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 132
___nl__4 = null;
//line 132
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 132
___nl__3 = null;
//line 133
___nl__4 = ((ImmHash)___nl__0).getHashValue()["args_type"].clone();
//line 133
___nl__3 = array_NL.NL_len(___nl__4).clone();

//line 133
___nl__4 = null;
//line 133
___nl__4 = new ImmDouble(0).clone();
//line 133
___nl__5 = new ImmDouble(1).clone();
//line 133
label_8:
//line 133
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__3.getValue().ToString())) ).clone();
//line 133
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_6;}}
//line 134
___nl__7 = ((ImmHash)___nl__0).getHashValue()["args_type"].clone();
//line 134
___nl__7 = (___nl__7 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()].clone();
//line 134
___nl__8 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("val")).clone();
//line 134
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_10;}}
//line 136
___nl__8 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("ref")).clone();
//line 136
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_11;}}
//line 136
___nl__8 = new ImmString("NOMATCHALERT").clone();
//line 136
___nl__8 = new ImmArray(new Imm[] {___nl__8,___nl__7,}).clone();
//line 136
c_rt_lib_NL.NL_die();
//line 134
label_10:
//line 135
___nl__9 = new ImmString("ImmRef ___nl__").clone();
//line 135
___nl__9 = new ImmString(___nl__9.toString() + ___nl__4.toString()).clone();
//line 135
___nl__10 = new ImmString(" = new ImmRef(___arg__").clone();
//line 135
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 135
___nl__10 = null;
//line 135
___nl__9 = new ImmString(___nl__9.toString() + ___nl__4.toString()).clone();
//line 135
___nl__10 = generator_java_NL.NL_print_getter_priv().clone();

//line 135
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 135
___nl__10 = null;
//line 135
___nl__10 = new ImmString(");").clone();
//line 135
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 135
___nl__10 = null;
//line 135
___nl__2 = new ImmString(___nl__2.toString() + ___nl__9.toString()).clone();
//line 135
___nl__9 = null;
//line 136
if (true) {goto label_9;}
//line 136
label_11:
//line 137
___nl__9 = new ImmString("ImmRef ___nl__").clone();
//line 137
___nl__9 = new ImmString(___nl__9.toString() + ___nl__4.toString()).clone();
//line 137
___nl__10 = new ImmString(" = ___arg__").clone();
//line 137
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 137
___nl__10 = null;
//line 137
___nl__9 = new ImmString(___nl__9.toString() + ___nl__4.toString()).clone();
//line 137
___nl__10 = new ImmString(";").clone();
//line 137
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 137
___nl__10 = null;
//line 137
___nl__2 = new ImmString(___nl__2.toString() + ___nl__9.toString()).clone();
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
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
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
___nl__3 = string_NL.NL_lf().clone();

//line 140
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 140
___nl__3 = null;
//line 141
___nl__4 = ((ImmHash)___nl__0).getHashValue()["args_type"].clone();
//line 141
___nl__3 = array_NL.NL_len(___nl__4).clone();

//line 141
___nl__4 = null;
//line 141
label_13:
//line 141
___nl__4 = ((ImmHash)___nl__0).getHashValue()["reg_size"].clone();
//line 141
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))<(Double.Parse(___nl__4.getValue().ToString())) ).clone();
//line 141
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 141
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_12;}}
//line 142
___nl__5 = new ImmString("ImmRef ___nl__").clone();
//line 142
___nl__5 = new ImmString(___nl__5.toString() + ___nl__3.toString()).clone();
//line 142
___nl__6 = new ImmString(" = new ImmRef(null);").clone();
//line 142
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 142
___nl__6 = null;
//line 142
___nl__6 = string_NL.NL_lf().clone();

//line 142
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 142
___nl__6 = null;
//line 142
___nl__2 = new ImmString(___nl__2.toString() + ___nl__5.toString()).clone();
//line 142
___nl__5 = null;
//line 142
___nl__5 = new ImmDouble(1).clone();
//line 142
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
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
___nl__3 = new ImmString("Map<ImmString, Imm> ").clone();
//line 144
___nl__4 = generator_java_NL.NL_print_hash_name_priv().clone();

//line 144
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 144
___nl__4 = null;
//line 144
___nl__4 = new ImmString(";").clone();
//line 144
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 144
___nl__4 = null;
//line 144
___nl__4 = string_NL.NL_lf().clone();

//line 144
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 144
___nl__4 = null;
//line 144
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 144
___nl__3 = null;
//line 145
___nl__3 = new ImmString("String label = \"\"; while (true) { switch (label) { default: ").clone();
//line 145
___nl__4 = string_NL.NL_lf().clone();

//line 145
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 145
___nl__4 = null;
//line 145
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 145
___nl__3 = null;
//line 146
___nl__3 = ((ImmHash)___nl__0).getHashValue()["commands"].clone();
//line 146
___nl__5 = new ImmDouble(0).clone();
//line 146
___nl__6 = new ImmDouble(1).clone();
//line 146
___nl__7 = c_rt_lib_NL.NL_array_len(___nl__3).clone();

//line 146
label_17:
//line 146
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) ).clone();
//line 146
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_15;}}
//line 146
___nl__4 = (___nl__3 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()].clone();
//line 146
___nl__9 = generator_java_NL.NL_print_command_priv(___nl__1,___nl__4).clone();

//line 146
___nl__2 = new ImmString(___nl__2.toString() + ___nl__9.toString()).clone();
//line 146
___nl__9 = null;
//line 146
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString()))).clone();
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
___nl__3 = new ImmString("}}}").clone();
//line 147
___nl__3 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 147
___nl__4 = string_NL.NL_lf().clone();

//line 147
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
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
___nl__3 = ((ImmHash)___nl__1).getHashValue()["cmd"].clone();
//line 152
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("arr_decl")).clone();
//line 152
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 154
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("hash_decl")).clone();
//line 154
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_3;}}
//line 157
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("call")).clone();
//line 157
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_4;}}
//line 159
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("func")).clone();
//line 159
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_5;}}
//line 161
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("una_op")).clone();
//line 161
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_6;}}
//line 163
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("bin_op")).clone();
//line 163
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_7;}}
//line 165
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("ov_is")).clone();
//line 165
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_8;}}
//line 167
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("ov_as")).clone();
//line 167
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_9;}}
//line 169
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("return")).clone();
//line 169
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_10;}}
//line 171
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("die")).clone();
//line 171
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_11;}}
//line 173
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("move")).clone();
//line 173
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_12;}}
//line 175
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("load_const")).clone();
//line 175
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_13;}}
//line 177
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("get_frm_idx")).clone();
//line 177
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_14;}}
//line 181
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("set_at_idx")).clone();
//line 181
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_15;}}
//line 185
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("get_val")).clone();
//line 185
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_16;}}
//line 187
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("set_val")).clone();
//line 187
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_17;}}
//line 190
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("ov_mk")).clone();
//line 190
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_18;}}
//line 192
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("prt_lbl")).clone();
//line 192
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_19;}}
//line 194
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("if_goto")).clone();
//line 194
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_20;}}
//line 196
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("goto")).clone();
//line 196
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_21;}}
//line 198
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("clear")).clone();
//line 198
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_22;}}
//line 198
___nl__4 = new ImmString("NOMATCHALERT").clone();
//line 198
___nl__4 = new ImmArray(new Imm[] {___nl__4,___nl__3,}).clone();
//line 198
c_rt_lib_NL.NL_die();
//line 152
label_2:
//line 152
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("arr_decl")).clone();
//line 153
___nl__7 = ((ImmHash)___nl__5).getHashValue()["dest"].clone();
//line 153
___nl__9 = ((ImmHash)___nl__5).getHashValue()["src"].clone();
//line 153
___nl__8 = generator_java_NL.NL_print_arr_priv(___nl__9).clone();

//line 153
___nl__9 = null;
//line 153
___nl__6 = generator_java_NL.NL_print_register_setter_priv(___nl__7,___nl__8).clone();

//line 153
___nl__8 = null;
//line 153
___nl__7 = null;
//line 153
___nl__7 = new ImmString(";").clone();
//line 153
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 153
___nl__7 = null;
//line 153
___nl__2 = ___nl__6.clone();
//line 153
___nl__6 = null;
//line 153
___nl__5 = null;
//line 154
if (true) {goto label_1;}
//line 154
label_3:
//line 154
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("hash_decl")).clone();
//line 155
___nl__6 = generator_java_NL.NL_print_hash_priv(___nl__5).clone();

//line 155
___nl__2 = ___nl__6.clone();
//line 155
___nl__6 = null;
//line 156
___nl__7 = ((ImmHash)___nl__5).getHashValue()["dest"].clone();
//line 156
___nl__8 = new ImmString("new ImmMap(").clone();
//line 156
___nl__9 = generator_java_NL.NL_print_hash_name_priv().clone();

//line 156
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 156
___nl__9 = null;
//line 156
___nl__9 = new ImmString(")").clone();
//line 156
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 156
___nl__9 = null;
//line 156
___nl__6 = generator_java_NL.NL_print_register_setter_priv(___nl__7,___nl__8).clone();

//line 156
___nl__8 = null;
//line 156
___nl__7 = null;
//line 156
___nl__7 = new ImmString(";").clone();
//line 156
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 156
___nl__7 = null;
//line 156
___nl__2 = new ImmString(___nl__2.toString() + ___nl__6.toString()).clone();
//line 156
___nl__6 = null;
//line 156
___nl__5 = null;
//line 157
if (true) {goto label_1;}
//line 157
label_4:
//line 157
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("call")).clone();
//line 158
___nl__7 = ((ImmHash)___nl__5).getHashValue()["dest"].clone();
//line 158
___nl__9 = ((ImmHash)___nl__5).getHashValue()["mod"].clone();
//line 158
___nl__10 = ((ImmHash)___nl__5).getHashValue()["fun_name"].clone();
//line 158
___nl__11 = ((ImmHash)___nl__5).getHashValue()["args"].clone();
//line 158
___nl__8 = generator_java_NL.NL_print_call_priv(___nl__0,___nl__9,___nl__10,___nl__11).clone();

//line 158
___nl__11 = null;
//line 158
___nl__10 = null;
//line 158
___nl__9 = null;
//line 158
___nl__6 = generator_java_NL.NL_print_register_setter_priv(___nl__7,___nl__8).clone();

//line 158
___nl__8 = null;
//line 158
___nl__7 = null;
//line 158
___nl__7 = new ImmString(";").clone();
//line 158
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 158
___nl__7 = null;
//line 158
___nl__2 = ___nl__6.clone();
//line 158
___nl__6 = null;
//line 158
___nl__5 = null;
//line 159
if (true) {goto label_1;}
//line 159
label_5:
//line 159
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("func")).clone();
//line 160
___nl__7 = ((ImmHash)___nl__5).getHashValue()["dest"].clone();
//line 160
___nl__10 = ((ImmHash)___nl__5).getHashValue()["module"].clone();
//line 160
___nl__9 = generator_java_NL.NL_get_class_name_priv(___nl__10).clone();

//line 160
___nl__10 = null;
//line 160
___nl__10 = ((ImmHash)___nl__5).getHashValue()["name"].clone();
//line 160
___nl__11 = new ImmString("_nl").clone();
//line 160
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString()).clone();
//line 160
___nl__11 = null;
//line 160
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",___nl__9);
__function_map.Add("name",___nl__10);
___nl__8 = new ImmHash(__function_map).clone();
//line 160
___nl__9 = null;
//line 160
___nl__10 = null;
//line 160
___nl__6 = generator_java_NL.NL_print_const_hash_priv(___nl__7,___nl__8).clone();

//line 160
___nl__8 = null;
//line 160
___nl__7 = null;
//line 160
___nl__7 = new ImmString(";").clone();
//line 160
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 160
___nl__7 = null;
//line 160
___nl__2 = ___nl__6.clone();
//line 160
___nl__6 = null;
//line 160
___nl__5 = null;
//line 161
if (true) {goto label_1;}
//line 161
label_6:
//line 161
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("una_op")).clone();
//line 162
___nl__6 = generator_java_NL.NL_print_una_op_priv(___nl__5).clone();

//line 162
___nl__2 = ___nl__6.clone();
//line 162
___nl__6 = null;
//line 162
___nl__5 = null;
//line 163
if (true) {goto label_1;}
//line 163
label_7:
//line 163
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("bin_op")).clone();
//line 164
___nl__6 = generator_java_NL.NL_print_bin_op_priv(___nl__5).clone();

//line 164
___nl__2 = ___nl__6.clone();
//line 164
___nl__6 = null;
//line 164
___nl__5 = null;
//line 165
if (true) {goto label_1;}
//line 165
label_8:
//line 165
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("ov_is")).clone();
//line 166
___nl__7 = ((ImmHash)___nl__5).getHashValue()["dest"].clone();
//line 166
___nl__8 = new ImmString("c_rt_lib_NL.ov_is_nl(").clone();
//line 166
___nl__10 = ((ImmHash)___nl__5).getHashValue()["src"].clone();
//line 166
___nl__9 = generator_java_NL.NL_print_register_priv(___nl__10).clone();

//line 166
___nl__10 = null;
//line 166
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 166
___nl__9 = null;
//line 166
___nl__9 = new ImmString(", new ImmRef(new ImmString(\"").clone();
//line 166
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 166
___nl__9 = null;
//line 166
___nl__10 = ((ImmHash)___nl__5).getHashValue()["type"].clone();
//line 166
___nl__9 = generator_java_NL.NL_escape_string_priv(___nl__10).clone();

//line 166
___nl__10 = null;
//line 166
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 166
___nl__9 = null;
//line 166
___nl__9 = new ImmString("\")))").clone();
//line 166
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 166
___nl__9 = null;
//line 166
___nl__6 = generator_java_NL.NL_print_register_setter_priv(___nl__7,___nl__8).clone();

//line 166
___nl__8 = null;
//line 166
___nl__7 = null;
//line 166
___nl__7 = new ImmString(";").clone();
//line 166
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 166
___nl__7 = null;
//line 166
___nl__2 = ___nl__6.clone();
//line 166
___nl__6 = null;
//line 166
___nl__5 = null;
//line 167
if (true) {goto label_1;}
//line 167
label_9:
//line 167
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("ov_as")).clone();
//line 168
___nl__7 = ((ImmHash)___nl__5).getHashValue()["dest"].clone();
//line 168
___nl__8 = new ImmString("c_rt_lib_NL.ov_as_nl(").clone();
//line 168
___nl__10 = ((ImmHash)___nl__5).getHashValue()["src"].clone();
//line 168
___nl__9 = generator_java_NL.NL_print_register_priv(___nl__10).clone();

//line 168
___nl__10 = null;
//line 168
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 168
___nl__9 = null;
//line 168
___nl__9 = new ImmString(", new ImmRef(new ImmString(\"").clone();
//line 168
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 168
___nl__9 = null;
//line 168
___nl__10 = ((ImmHash)___nl__5).getHashValue()["type"].clone();
//line 168
___nl__9 = generator_java_NL.NL_escape_string_priv(___nl__10).clone();

//line 168
___nl__10 = null;
//line 168
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 168
___nl__9 = null;
//line 168
___nl__9 = new ImmString("\")))").clone();
//line 168
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 168
___nl__9 = null;
//line 168
___nl__6 = generator_java_NL.NL_print_register_setter_priv(___nl__7,___nl__8).clone();

//line 168
___nl__8 = null;
//line 168
___nl__7 = null;
//line 168
___nl__7 = new ImmString(";").clone();
//line 168
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 168
___nl__7 = null;
//line 168
___nl__2 = ___nl__6.clone();
//line 168
___nl__6 = null;
//line 168
___nl__5 = null;
//line 169
if (true) {goto label_1;}
//line 169
label_10:
//line 169
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("return")).clone();
//line 170
___nl__6 = generator_java_NL.NL_print_return_priv(___nl__5).clone();

//line 170
___nl__2 = ___nl__6.clone();
//line 170
___nl__6 = null;
//line 170
___nl__5 = null;
//line 171
if (true) {goto label_1;}
//line 171
label_11:
//line 171
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("die")).clone();
//line 172
___nl__6 = new ImmString("c_rt_lib_NL.die_nl();").clone();
//line 172
___nl__2 = ___nl__6.clone();
//line 172
___nl__6 = null;
//line 172
___nl__5 = null;
//line 173
if (true) {goto label_1;}
//line 173
label_12:
//line 173
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("move")).clone();
//line 174
___nl__7 = ((ImmHash)___nl__5).getHashValue()["dest"].clone();
//line 174
___nl__9 = ((ImmHash)___nl__5).getHashValue()["src"].clone();
//line 174
___nl__8 = generator_java_NL.NL_print_register_getter_priv(___nl__9).clone();

//line 174
___nl__9 = null;
//line 174
___nl__6 = generator_java_NL.NL_print_register_setter_priv(___nl__7,___nl__8).clone();

//line 174
___nl__8 = null;
//line 174
___nl__7 = null;
//line 174
___nl__7 = new ImmString(";").clone();
//line 174
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 174
___nl__7 = null;
//line 174
___nl__2 = ___nl__6.clone();
//line 174
___nl__6 = null;
//line 174
___nl__5 = null;
//line 175
if (true) {goto label_1;}
//line 175
label_13:
//line 175
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("load_const")).clone();
//line 176
___nl__7 = ((ImmHash)___nl__5).getHashValue()["dest"].clone();
//line 176
___nl__10 = ((ImmHash)___nl__5).getHashValue()["dest"].clone();
//line 176
___nl__9 = generator_java_NL.NL_print_register_priv(___nl__10).clone();

//line 176
___nl__10 = null;
//line 176
___nl__10 = ((ImmHash)___nl__5).getHashValue()["val"].clone();
//line 176
___nl__8 = generator_java_NL.NL_print_const_value_priv(___nl__9,___nl__10).clone();

//line 176
___nl__10 = null;
//line 176
___nl__9 = null;
//line 176
___nl__6 = generator_java_NL.NL_print_register_setter_priv(___nl__7,___nl__8).clone();

//line 176
___nl__8 = null;
//line 176
___nl__7 = null;
//line 176
___nl__7 = new ImmString(";").clone();
//line 176
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 176
___nl__7 = null;
//line 176
___nl__2 = ___nl__6.clone();
//line 176
___nl__6 = null;
//line 176
___nl__5 = null;
//line 177
if (true) {goto label_1;}
//line 177
label_14:
//line 177
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("get_frm_idx")).clone();
//line 178
___nl__6 = new ImmString("((ImmArray)").clone();
//line 178
___nl__8 = ((ImmHash)___nl__5).getHashValue()["src"].clone();
//line 178
___nl__7 = generator_java_NL.NL_print_register_getter_priv(___nl__8).clone();

//line 178
___nl__8 = null;
//line 178
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 178
___nl__7 = null;
//line 178
___nl__7 = new ImmString(")").clone();
//line 178
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 178
___nl__7 = null;
//line 178
___nl__7 = generator_java_NL.NL_print_getter_priv().clone();

//line 178
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 178
___nl__7 = null;
//line 178
___nl__2 = ___nl__6.clone();
//line 178
___nl__6 = null;
//line 179
___nl__6 = new ImmString("[((ImmDouble)(").clone();
//line 179
___nl__8 = ((ImmHash)___nl__5).getHashValue()["idx"].clone();
//line 179
___nl__7 = generator_java_NL.NL_print_register_getter_priv(___nl__8).clone();

//line 179
___nl__8 = null;
//line 179
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 179
___nl__7 = null;
//line 179
___nl__7 = new ImmString("))").clone();
//line 179
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 179
___nl__7 = null;
//line 179
___nl__7 = generator_java_NL.NL_print_getter_priv().clone();

//line 179
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 179
___nl__7 = null;
//line 179
___nl__7 = generator_java_NL.NL_print_int_value_priv().clone();

//line 179
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 179
___nl__7 = null;
//line 179
___nl__7 = new ImmString("]").clone();
//line 179
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 179
___nl__7 = null;
//line 179
___nl__2 = new ImmString(___nl__2.toString() + ___nl__6.toString()).clone();
//line 179
___nl__6 = null;
//line 180
___nl__7 = ((ImmHash)___nl__5).getHashValue()["dest"].clone();
//line 180
___nl__6 = generator_java_NL.NL_print_register_setter_priv(___nl__7,___nl__2).clone();

//line 180
___nl__7 = null;
//line 180
___nl__7 = new ImmString(";").clone();
//line 180
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 180
___nl__7 = null;
//line 180
___nl__2 = ___nl__6.clone();
//line 180
___nl__6 = null;
//line 180
___nl__5 = null;
//line 181
if (true) {goto label_1;}
//line 181
label_15:
//line 181
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("set_at_idx")).clone();
//line 182
___nl__7 = ((ImmHash)___nl__5).getHashValue()["src"].clone();
//line 182
___nl__8 = new ImmString("c_rt_lib_NL.clone_nl(").clone();
//line 182
___nl__10 = ((ImmHash)___nl__5).getHashValue()["src"].clone();
//line 182
___nl__9 = generator_java_NL.NL_print_register_getter_priv(___nl__10).clone();

//line 182
___nl__10 = null;
//line 182
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 182
___nl__9 = null;
//line 182
___nl__9 = new ImmString(")").clone();
//line 182
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 182
___nl__9 = null;
//line 182
___nl__6 = generator_java_NL.NL_print_register_setter_priv(___nl__7,___nl__8).clone();

//line 182
___nl__8 = null;
//line 182
___nl__7 = null;
//line 182
___nl__7 = new ImmString(";").clone();
//line 182
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 182
___nl__7 = null;
//line 182
___nl__7 = string_NL.NL_lf().clone();

//line 182
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 182
___nl__7 = null;
//line 182
___nl__2 = ___nl__6.clone();
//line 182
___nl__6 = null;
//line 183
___nl__6 = new ImmString("((ImmArray)").clone();
//line 183
___nl__8 = ((ImmHash)___nl__5).getHashValue()["src"].clone();
//line 183
___nl__7 = generator_java_NL.NL_print_register_getter_priv(___nl__8).clone();

//line 183
___nl__8 = null;
//line 183
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 183
___nl__7 = null;
//line 183
___nl__7 = new ImmString(")").clone();
//line 183
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 183
___nl__7 = null;
//line 183
___nl__7 = generator_java_NL.NL_print_getter_priv().clone();

//line 183
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 183
___nl__7 = null;
//line 183
___nl__7 = new ImmString("[").clone();
//line 183
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 183
___nl__7 = null;
//line 183
___nl__2 = new ImmString(___nl__2.toString() + ___nl__6.toString()).clone();
//line 183
___nl__6 = null;
//line 184
___nl__6 = new ImmString("((ImmDouble)").clone();
//line 184
___nl__8 = ((ImmHash)___nl__5).getHashValue()["idx"].clone();
//line 184
___nl__7 = generator_java_NL.NL_print_register_getter_priv(___nl__8).clone();

//line 184
___nl__8 = null;
//line 184
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 184
___nl__7 = null;
//line 184
___nl__7 = new ImmString(")").clone();
//line 184
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 184
___nl__7 = null;
//line 184
___nl__7 = generator_java_NL.NL_print_getter_priv().clone();

//line 184
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 184
___nl__7 = null;
//line 184
___nl__7 = generator_java_NL.NL_print_int_value_priv().clone();

//line 184
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 184
___nl__7 = null;
//line 184
___nl__7 = new ImmString("] = ").clone();
//line 184
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 184
___nl__7 = null;
//line 184
___nl__8 = ((ImmHash)___nl__5).getHashValue()["val"].clone();
//line 184
___nl__7 = generator_java_NL.NL_print_register_getter_priv(___nl__8).clone();

//line 184
___nl__8 = null;
//line 184
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 184
___nl__7 = null;
//line 184
___nl__7 = new ImmString(";").clone();
//line 184
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 184
___nl__7 = null;
//line 184
___nl__2 = new ImmString(___nl__2.toString() + ___nl__6.toString()).clone();
//line 184
___nl__6 = null;
//line 184
___nl__5 = null;
//line 185
if (true) {goto label_1;}
//line 185
label_16:
//line 185
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("get_val")).clone();
//line 186
___nl__7 = ((ImmHash)___nl__5).getHashValue()["dest"].clone();
//line 186
___nl__8 = generator_java_NL.NL_print_get_hash_value_priv(___nl__5).clone();

//line 186
___nl__6 = generator_java_NL.NL_print_register_setter_priv(___nl__7,___nl__8).clone();

//line 186
___nl__8 = null;
//line 186
___nl__7 = null;
//line 186
___nl__7 = new ImmString(";").clone();
//line 186
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 186
___nl__7 = null;
//line 186
___nl__2 = ___nl__6.clone();
//line 186
___nl__6 = null;
//line 186
___nl__5 = null;
//line 187
if (true) {goto label_1;}
//line 187
label_17:
//line 187
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("set_val")).clone();
//line 188
___nl__7 = ((ImmHash)___nl__5).getHashValue()["src"].clone();
//line 188
___nl__8 = new ImmString("c_rt_lib_NL.clone_nl(").clone();
//line 188
___nl__10 = ((ImmHash)___nl__5).getHashValue()["src"].clone();
//line 188
___nl__9 = generator_java_NL.NL_print_register_getter_priv(___nl__10).clone();

//line 188
___nl__10 = null;
//line 188
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 188
___nl__9 = null;
//line 188
___nl__9 = new ImmString(")").clone();
//line 188
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 188
___nl__9 = null;
//line 188
___nl__6 = generator_java_NL.NL_print_register_setter_priv(___nl__7,___nl__8).clone();

//line 188
___nl__8 = null;
//line 188
___nl__7 = null;
//line 188
___nl__7 = new ImmString(";").clone();
//line 188
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 188
___nl__7 = null;
//line 188
___nl__7 = string_NL.NL_lf().clone();

//line 188
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 188
___nl__7 = null;
//line 188
___nl__2 = ___nl__6.clone();
//line 188
___nl__6 = null;
//line 189
___nl__6 = generator_java_NL.NL_print_set_hash_value_priv(___nl__5).clone();

//line 189
___nl__7 = new ImmString(";").clone();
//line 189
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 189
___nl__7 = null;
//line 189
___nl__2 = new ImmString(___nl__2.toString() + ___nl__6.toString()).clone();
//line 189
___nl__6 = null;
//line 189
___nl__5 = null;
//line 190
if (true) {goto label_1;}
//line 190
label_18:
//line 190
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("ov_mk")).clone();
//line 191
___nl__6 = generator_java_NL.NL_print_ov_mk_priv(___nl__5).clone();

//line 191
___nl__2 = ___nl__6.clone();
//line 191
___nl__6 = null;
//line 191
___nl__5 = null;
//line 192
if (true) {goto label_1;}
//line 192
label_19:
//line 192
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("prt_lbl")).clone();
//line 193
___nl__6 = new ImmString("case \"").clone();
//line 193
___nl__6 = new ImmString(___nl__6.toString() + ___nl__5.toString()).clone();
//line 193
___nl__7 = new ImmString("\":").clone();
//line 193
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 193
___nl__7 = null;
//line 193
___nl__2 = ___nl__6.clone();
//line 193
___nl__6 = null;
//line 193
___nl__5 = null;
//line 194
if (true) {goto label_1;}
//line 194
label_20:
//line 194
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("if_goto")).clone();
//line 195
___nl__6 = new ImmString("if (c_rt_lib_NL.check_true_native_nl(").clone();
//line 195
___nl__8 = ((ImmHash)___nl__5).getHashValue()["src"].clone();
//line 195
___nl__7 = generator_java_NL.NL_print_register_priv(___nl__8).clone();

//line 195
___nl__8 = null;
//line 195
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 195
___nl__7 = null;
//line 195
___nl__7 = new ImmString(")) {").clone();
//line 195
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 195
___nl__7 = null;
//line 195
___nl__8 = ((ImmHash)___nl__5).getHashValue()["dest"].clone();
//line 195
___nl__7 = generator_java_NL.NL_print_goto_priv(___nl__8).clone();

//line 195
___nl__8 = null;
//line 195
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 195
___nl__7 = null;
//line 195
___nl__7 = new ImmString("}").clone();
//line 195
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 195
___nl__7 = null;
//line 195
___nl__2 = ___nl__6.clone();
//line 195
___nl__6 = null;
//line 195
___nl__5 = null;
//line 196
if (true) {goto label_1;}
//line 196
label_21:
//line 196
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("goto")).clone();
//line 197
___nl__6 = generator_java_NL.NL_print_goto_priv(___nl__5).clone();

//line 197
___nl__2 = ___nl__6.clone();
//line 197
___nl__6 = null;
//line 197
___nl__5 = null;
//line 198
if (true) {goto label_1;}
//line 198
label_22:
//line 198
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("clear")).clone();
//line 199
___nl__7 = new ImmString("null").clone();
//line 199
___nl__6 = generator_java_NL.NL_print_register_setter_priv(___nl__5,___nl__7).clone();

//line 199
___nl__7 = null;
//line 199
___nl__7 = new ImmString(";").clone();
//line 199
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 199
___nl__7 = null;
//line 199
___nl__2 = ___nl__6.clone();
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
___nl__3 = new ImmString("//line ").clone();
//line 201
___nl__4 = ((ImmHash)___nl__1).getHashValue()["debug"].clone();
//line 201
___nl__4 = ((ImmHash)___nl__4).getHashValue()["nast_debug"].clone();
//line 201
___nl__4 = ((ImmHash)___nl__4).getHashValue()["begin"].clone();
//line 201
___nl__4 = ((ImmHash)___nl__4).getHashValue()["line"].clone();
//line 201
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 201
___nl__4 = null;
//line 201
___nl__4 = string_NL.NL_lf().clone();

//line 201
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 201
___nl__4 = null;
//line 201
___nl__3 = new ImmString(___nl__3.toString() + ___nl__2.toString()).clone();
//line 201
___nl__4 = string_NL.NL_lf().clone();

//line 201
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
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
___nl__1 = new ImmString("new ImmArray(new Imm[").clone();
//line 206
___nl__2 = array_NL.NL_len(___nl__0).clone();

//line 206
___nl__3 = new ImmDouble(0).clone();
//line 206
___nl__2 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__2.getValue().ToString())) ==((Double.Parse(___nl__3.getValue().ToString())))  ).clone();
//line 206
___nl__3 = null;
//line 206
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 206
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 207
___nl__3 = new ImmString("0]").clone();
//line 207
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 207
___nl__3 = null;
//line 208
if (true) {goto label_1;}
//line 208
label_2:
//line 209
___nl__3 = new ImmString("] {").clone();
//line 209
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 209
___nl__3 = null;
//line 210
___nl__4 = new ImmDouble(0).clone();
//line 210
___nl__5 = new ImmDouble(1).clone();
//line 210
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__0).clone();

//line 210
label_5:
//line 210
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) ).clone();
//line 210
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_3;}}
//line 210
___nl__3 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()].clone();
//line 210
___nl__8 = generator_java_NL.NL_print_register_getter_priv(___nl__3).clone();

//line 210
___nl__9 = new ImmString(",").clone();
//line 210
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 210
___nl__9 = null;
//line 210
___nl__1 = new ImmString(___nl__1.toString() + ___nl__8.toString()).clone();
//line 210
___nl__8 = null;
//line 210
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
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
___nl__3 = new ImmString("}").clone();
//line 211
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 211
___nl__3 = null;
//line 212
if (true) {goto label_1;}
//line 212
label_1:
//line 212
___nl__2 = null;
//line 213
___nl__2 = new ImmString(")").clone();
//line 213
___nl__2 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
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
___nl__1 = new ImmString("").clone();
//line 218
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 218
___nl__3 = new ImmString(">=").clone();
//line 218
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 218
___nl__3 = null;
//line 218
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_7;}}
//line 218
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 218
___nl__3 = new ImmString("<=").clone();
//line 218
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 218
___nl__3 = null;
//line 218
label_7:
//line 218
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_6;}}
//line 218
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 218
___nl__3 = new ImmString("<").clone();
//line 218
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 218
___nl__3 = null;
//line 218
label_6:
//line 218
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_5;}}
//line 218
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 218
___nl__3 = new ImmString(">").clone();
//line 218
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 218
___nl__3 = null;
//line 218
label_5:
//line 218
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_4;}}
//line 218
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 218
___nl__3 = new ImmString("==").clone();
//line 218
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 218
___nl__3 = null;
//line 218
label_4:
//line 218
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_3;}}
//line 218
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 218
___nl__3 = new ImmString("!=").clone();
//line 218
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 218
___nl__3 = null;
//line 218
label_3:
//line 218
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 218
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 220
___nl__3 = new ImmString("c_rt_lib_NL.native_to_nl_nl(").clone();
//line 220
___nl__4 = generator_java_NL.NL_print_imm_double_operation_priv(___nl__0).clone();

//line 220
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 220
___nl__4 = null;
//line 220
___nl__4 = new ImmString(" )").clone();
//line 220
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 220
___nl__4 = null;
//line 220
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 220
___nl__3 = null;
//line 221
if (true) {goto label_1;}
//line 221
label_2:
//line 221
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 221
___nl__3 = new ImmString("eq").clone();
//line 221
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 221
___nl__3 = null;
//line 221
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_9;}}
//line 221
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 221
___nl__3 = new ImmString("ne").clone();
//line 221
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 221
___nl__3 = null;
//line 221
label_9:
//line 221
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 221
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_8;}}
//line 222
___nl__3 = new ImmString("c_rt_lib_NL.native_to_nl_nl(").clone();
//line 222
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 222
___nl__3 = null;
//line 223
___nl__3 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 223
___nl__4 = new ImmString("ne").clone();
//line 223
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__4.toString())).clone();
//line 223
___nl__4 = null;
//line 223
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 223
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_11;}}
//line 224
___nl__4 = new ImmString("!").clone();
//line 224
___nl__1 = new ImmString(___nl__1.toString() + ___nl__4.toString()).clone();
//line 224
___nl__4 = null;
//line 225
if (true) {goto label_11;}
//line 225
label_11:
//line 225
___nl__3 = null;
//line 226
___nl__4 = ((ImmHash)___nl__0).getHashValue()["left"].clone();
//line 226
___nl__3 = generator_java_NL.NL_print_register_getter_priv(___nl__4).clone();

//line 226
___nl__4 = null;
//line 226
___nl__4 = new ImmString(".toString().equals(").clone();
//line 226
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 226
___nl__4 = null;
//line 226
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 226
___nl__3 = null;
//line 227
___nl__4 = ((ImmHash)___nl__0).getHashValue()["right"].clone();
//line 227
___nl__3 = generator_java_NL.NL_print_register_getter_priv(___nl__4).clone();

//line 227
___nl__4 = null;
//line 227
___nl__4 = new ImmString(".toString()))").clone();
//line 227
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 227
___nl__4 = null;
//line 227
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 227
___nl__3 = null;
//line 228
if (true) {goto label_1;}
//line 228
label_8:
//line 228
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 228
___nl__3 = new ImmString(".").clone();
//line 228
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 228
___nl__3 = null;
//line 228
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 228
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_12;}}
//line 229
___nl__3 = new ImmString("new ImmString(").clone();
//line 229
___nl__5 = ((ImmHash)___nl__0).getHashValue()["left"].clone();
//line 229
___nl__4 = generator_java_NL.NL_print_register_getter_priv(___nl__5).clone();

//line 229
___nl__5 = null;
//line 229
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 229
___nl__4 = null;
//line 229
___nl__4 = new ImmString(".toString() + ").clone();
//line 229
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 229
___nl__4 = null;
//line 229
___nl__5 = ((ImmHash)___nl__0).getHashValue()["right"].clone();
//line 229
___nl__4 = generator_java_NL.NL_print_register_getter_priv(___nl__5).clone();

//line 229
___nl__5 = null;
//line 229
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 229
___nl__4 = null;
//line 229
___nl__4 = new ImmString(".toString())").clone();
//line 229
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 229
___nl__4 = null;
//line 229
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 229
___nl__3 = null;
//line 230
if (true) {goto label_1;}
//line 230
label_12:
//line 231
___nl__3 = new ImmString("new ImmDouble(").clone();
//line 231
___nl__4 = generator_java_NL.NL_print_imm_double_operation_priv(___nl__0).clone();

//line 231
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 231
___nl__4 = null;
//line 231
___nl__4 = new ImmString(")").clone();
//line 231
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 231
___nl__4 = null;
//line 231
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 231
___nl__3 = null;
//line 232
if (true) {goto label_1;}
//line 232
label_1:
//line 232
___nl__2 = null;
//line 233
___nl__3 = ((ImmHash)___nl__0).getHashValue()["dest"].clone();
//line 233
___nl__2 = generator_java_NL.NL_print_register_setter_priv(___nl__3,___nl__1).clone();

//line 233
___nl__3 = null;
//line 233
___nl__3 = new ImmString(";").clone();
//line 233
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
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
___nl__2 = ((ImmHash)___nl__0).getHashValue()["left"].clone();
//line 237
___nl__1 = generator_java_NL.NL_print_register_as_number_priv(___nl__2).clone();

//line 237
___nl__2 = null;
//line 238
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 238
___nl__3 = new ImmString("==").clone();
//line 238
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 238
___nl__3 = null;
//line 238
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_3;}}
//line 238
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 238
___nl__3 = new ImmString("!=").clone();
//line 238
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 238
___nl__3 = null;
//line 238
label_3:
//line 238
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 238
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 239
___nl__3 = new ImmString(".compareTo(").clone();
//line 239
___nl__5 = ((ImmHash)___nl__0).getHashValue()["right"].clone();
//line 239
___nl__4 = generator_java_NL.NL_print_register_as_number_priv(___nl__5).clone();

//line 239
___nl__5 = null;
//line 239
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 239
___nl__4 = null;
//line 239
___nl__4 = new ImmString(") ").clone();
//line 239
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 239
___nl__4 = null;
//line 239
___nl__4 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 239
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 239
___nl__4 = null;
//line 239
___nl__4 = new ImmString(" 0").clone();
//line 239
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 239
___nl__4 = null;
//line 239
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 239
___nl__3 = null;
//line 240
if (true) {goto label_1;}
//line 240
label_2:
//line 241
___nl__3 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 241
___nl__5 = ((ImmHash)___nl__0).getHashValue()["right"].clone();
//line 241
___nl__4 = generator_java_NL.NL_print_register_as_number_priv(___nl__5).clone();

//line 241
___nl__5 = null;
//line 241
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 241
___nl__4 = null;
//line 241
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
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
___nl__1 = new ImmString("(Double.valueOf(String.valueOf(").clone();
//line 247
___nl__2 = generator_java_NL.NL_print_register_getter_priv(___nl__0).clone();

//line 247
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 247
___nl__2 = null;
//line 247
___nl__2 = generator_java_NL.NL_print_getter_priv().clone();

//line 247
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 247
___nl__2 = null;
//line 247
___nl__2 = new ImmString(")))").clone();
//line 247
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
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
___nl__0 = new ImmString(".intValue()").clone();
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
___nl__4 = new ImmString("").clone();
//line 255
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__1.toString().Equals(___nl__4.toString())).clone();
//line 255
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 255
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 255
___nl__5 = new ImmString("_priv").clone();
//line 255
___nl__5 = new ImmString(___nl__2.toString() + ___nl__5.toString()).clone();
//line 255
___nl__2 = ___nl__5.clone();
//line 255
___nl__5 = null;
//line 255
if (true) {goto label_2;}
//line 255
label_2:
//line 255
___nl__4 = null;
//line 256
___nl__4 = new ImmString("").clone();
//line 256
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__1.toString().Equals(___nl__4.toString())).clone();
//line 256
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 256
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_4;}}
//line 256
___nl__1 = ___nl__0.clone();
//line 256
if (true) {goto label_4;}
//line 256
label_4:
//line 256
___nl__4 = null;
//line 257
___nl__4 = generator_java_NL.NL_get_class_name_priv(___nl__1).clone();

//line 257
___nl__5 = new ImmString(".").clone();
//line 257
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 257
___nl__5 = null;
//line 257
___nl__5 = ___nl__2.clone();
//line 257
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 257
___nl__5 = null;
//line 257
___nl__5 = new ImmString("_nl(").clone();
//line 257
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 257
___nl__5 = null;
//line 258
___nl__5 = new ImmDouble(0).clone();
//line 259
___nl__7 = new ImmDouble(0).clone();
//line 259
___nl__8 = new ImmDouble(1).clone();
//line 259
___nl__9 = c_rt_lib_NL.NL_array_len(___nl__3).clone();

//line 259
label_7:
//line 259
___nl__10 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))>=(Double.Parse(___nl__9.getValue().ToString())) ).clone();
//line 259
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_5;}}
//line 259
___nl__6 = (___nl__3 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()].clone();
//line 260
___nl__11 = new ImmDouble(0).clone();
//line 260
___nl__11 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString())) ==((Double.Parse(___nl__11.getValue().ToString())))  ).clone();
//line 260
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 260
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 260
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_9;}}
//line 260
___nl__12 = new ImmString(",").clone();
//line 260
___nl__4 = new ImmString(___nl__4.toString() + ___nl__12.toString()).clone();
//line 260
___nl__12 = null;
//line 260
if (true) {goto label_9;}
//line 260
label_9:
//line 260
___nl__11 = null;
//line 261
___nl__11 = new ImmDouble(1).clone();
//line 261
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__11.getValue().ToString()))).clone();
//line 261
___nl__11 = null;
//line 262
___nl__11 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("ref")).clone();
//line 262
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_11;}}
//line 264
___nl__11 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("val")).clone();
//line 264
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_12;}}
//line 264
___nl__11 = new ImmString("NOMATCHALERT").clone();
//line 264
___nl__11 = new ImmArray(new Imm[] {___nl__11,___nl__6,}).clone();
//line 264
c_rt_lib_NL.NL_die();
//line 262
label_11:
//line 262
___nl__12 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("ref")).clone();
//line 263
___nl__13 = generator_java_NL.NL_print_register_priv(___nl__12).clone();

//line 263
___nl__4 = new ImmString(___nl__4.toString() + ___nl__13.toString()).clone();
//line 263
___nl__13 = null;
//line 263
___nl__12 = null;
//line 264
if (true) {goto label_10;}
//line 264
label_12:
//line 264
___nl__12 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("val")).clone();
//line 265
___nl__13 = generator_java_NL.NL_print_register_priv(___nl__12).clone();

//line 265
___nl__4 = new ImmString(___nl__4.toString() + ___nl__13.toString()).clone();
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
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString()))).clone();
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
___nl__6 = new ImmString(")").clone();
//line 268
___nl__6 = new ImmString(___nl__4.toString() + ___nl__6.toString()).clone();
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
___nl__2 = new ImmString("new Imm[] {").clone();
//line 273
___nl__4 = new ImmDouble(0).clone();
//line 273
___nl__5 = new ImmDouble(1).clone();
//line 273
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__1).clone();

//line 273
label_3:
//line 273
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) ).clone();
//line 273
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_1;}}
//line 273
___nl__3 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()].clone();
//line 273
___nl__8 = generator_java_NL.NL_print_const_value_priv(___nl__0,___nl__3).clone();

//line 273
___nl__9 = new ImmString(",").clone();
//line 273
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 273
___nl__9 = null;
//line 273
___nl__2 = new ImmString(___nl__2.toString() + ___nl__8.toString()).clone();
//line 273
___nl__8 = null;
//line 273
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
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
___nl__3 = new ImmString("}").clone();
//line 274
___nl__3 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
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
___nl__2 = generator_java_NL.NL_print_hash_name_priv().clone();

//line 278
___nl__3 = new ImmString(" = new HashMap<ImmString, Imm>();").clone();
//line 278
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 278
___nl__3 = null;
//line 278
___nl__3 = string_NL.NL_lf().clone();

//line 278
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 278
___nl__3 = null;
//line 279
___nl__5 = c_rt_lib_NL.NL_init_iter(___nl__1).clone();

//line 279
label_3:
//line 279
___nl__3 = c_rt_lib_NL.NL_is_end_hash(___nl__5).clone();

//line 279
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_1;}}
//line 279
___nl__3 = c_rt_lib_NL.NL_get_key_iter(___nl__5).clone();

//line 279
___nl__4 = c_rt_lib_NL.NL_hash_get_value(___nl__1,___nl__3).clone();

//line 279
___nl__6 = generator_java_NL.NL_print_hash_name_priv().clone();

//line 279
___nl__7 = new ImmString(".put(new ImmString(\"").clone();
//line 279
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 279
___nl__7 = null;
//line 279
___nl__7 = generator_java_NL.NL_escape_string_priv(___nl__3).clone();

//line 279
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 279
___nl__7 = null;
//line 279
___nl__7 = new ImmString("\"),").clone();
//line 279
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 279
___nl__7 = null;
//line 279
___nl__7 = generator_java_NL.NL_print_const_value_priv(___nl__0,___nl__4).clone();

//line 279
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 279
___nl__7 = null;
//line 279
___nl__7 = new ImmString(");").clone();
//line 279
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 279
___nl__7 = null;
//line 279
___nl__7 = string_NL.NL_lf().clone();

//line 279
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 279
___nl__7 = null;
//line 279
___nl__2 = new ImmString(___nl__2.toString() + ___nl__6.toString()).clone();
//line 279
___nl__6 = null;
//line 279
___nl__5 = c_rt_lib_NL.NL_next_iter(___nl__5).clone();

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
___nl__4 = new ImmString("new ImmMap(").clone();
//line 280
___nl__5 = generator_java_NL.NL_print_hash_name_priv().clone();

//line 280
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 280
___nl__5 = null;
//line 280
___nl__5 = new ImmString(")").clone();
//line 280
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 280
___nl__5 = null;
//line 280
___nl__3 = generator_java_NL.NL_print_register_setter_priv(___nl__0,___nl__4).clone();

//line 280
___nl__4 = null;
//line 280
___nl__3 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
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
___nl__2 = new ImmString("").clone();
//line 285
___nl__3 = ov_NL.NL_has_value(___nl__1).clone();

//line 285
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 285
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 286
___nl__4 = new ImmString("new OV(\"").clone();
//line 286
___nl__6 = ov_NL.NL_get_element(___nl__1).clone();

//line 286
___nl__5 = generator_java_NL.NL_escape_string_priv(___nl__6).clone();

//line 286
___nl__6 = null;
//line 286
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 286
___nl__5 = null;
//line 286
___nl__5 = new ImmString("\", ").clone();
//line 286
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 286
___nl__5 = null;
//line 286
___nl__6 = ov_NL.NL_get_value(___nl__1).clone();

//line 286
___nl__5 = generator_java_NL.NL_print_const_value_priv(___nl__0,___nl__6).clone();

//line 286
___nl__6 = null;
//line 286
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 286
___nl__5 = null;
//line 286
___nl__5 = new ImmString(")").clone();
//line 286
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 286
___nl__5 = null;
//line 286
___nl__2 = ___nl__4.clone();
//line 286
___nl__4 = null;
//line 287
if (true) {goto label_1;}
//line 287
label_2:
//line 288
___nl__4 = new ImmString("new OV(\"").clone();
//line 288
___nl__6 = ov_NL.NL_get_element(___nl__1).clone();

//line 288
___nl__5 = generator_java_NL.NL_escape_string_priv(___nl__6).clone();

//line 288
___nl__6 = null;
//line 288
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 288
___nl__5 = null;
//line 288
___nl__5 = new ImmString("\", null)").clone();
//line 288
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 288
___nl__5 = null;
//line 288
___nl__2 = ___nl__4.clone();
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
___nl__2 = nl_NL.NL_is_sim(___nl__1).clone();

//line 294
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 294
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_4;}}
//line 294
___nl__5 = ptd_NL.NL_sim().clone();

//line 294
___nl__4 = ptd_NL.NL_ensure(___nl__5,___nl__1).clone();

//line 294
___nl__5 = null;
//line 294
___nl__2 = string_utils_NL.NL_is_integer(___nl__4).clone();

//line 294
___nl__4 = null;
//line 294
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_4;}}
//line 294
___nl__5 = ptd_NL.NL_sim().clone();

//line 294
___nl__4 = ptd_NL.NL_ensure(___nl__5,___nl__1).clone();

//line 294
___nl__5 = null;
//line 294
___nl__2 = string_utils_NL.NL_is_float(___nl__4).clone();

//line 294
___nl__4 = null;
//line 294
label_4:
//line 294
___nl__3 = null;
//line 294
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 294
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 296
___nl__3 = new ImmString("new ImmDouble(").clone();
//line 296
___nl__3 = new ImmString(___nl__3.toString() + ___nl__1.toString()).clone();
//line 296
___nl__4 = new ImmString(")").clone();
//line 296
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
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
___nl__2 = nl_NL.NL_is_sim(___nl__1).clone();

//line 297
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 297
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_5;}}
//line 298
___nl__3 = new ImmString("new ImmString(\"").clone();
//line 298
___nl__4 = generator_java_NL.NL_escape_string_priv(___nl__1).clone();

//line 298
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 298
___nl__4 = null;
//line 298
___nl__4 = new ImmString("\")").clone();
//line 298
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
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
___nl__2 = nl_NL.NL_is_array(___nl__1).clone();

//line 299
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 299
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_6;}}
//line 300
___nl__3 = generator_java_NL.NL_print_const_arr_priv(___nl__0,___nl__1).clone();

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
___nl__2 = nl_NL.NL_is_hash(___nl__1).clone();

//line 301
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 301
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_7;}}
//line 302
___nl__3 = generator_java_NL.NL_print_const_hash_priv(___nl__0,___nl__1).clone();

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
___nl__2 = nl_NL.NL_is_variant(___nl__1).clone();

//line 303
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 303
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_8;}}
//line 304
___nl__3 = generator_java_NL.NL_print_const_ov_priv(___nl__0,___nl__1).clone();

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
___nl__3 = new ImmArray(new Imm[0]).clone();
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
___nl__1 = new ImmString("if (true) {label = \"").clone();
//line 311
___nl__1 = new ImmString(___nl__1.toString() + ___nl__0.toString()).clone();
//line 311
___nl__2 = new ImmString("\"; continue; }").clone();
//line 311
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
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
___nl__1 = generator_java_NL.NL_print_hash_name_priv().clone();

//line 315
___nl__2 = new ImmString(" = new HashMap<ImmString, Imm>();").clone();
//line 315
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 315
___nl__2 = null;
//line 315
___nl__2 = string_NL.NL_lf().clone();

//line 315
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 315
___nl__2 = null;
//line 316
___nl__2 = ((ImmHash)___nl__0).getHashValue()["src"].clone();
//line 316
___nl__4 = new ImmDouble(0).clone();
//line 316
___nl__5 = new ImmDouble(1).clone();
//line 316
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__2).clone();

//line 316
label_3:
//line 316
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) ).clone();
//line 316
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_1;}}
//line 316
___nl__3 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()].clone();
//line 316
___nl__8 = generator_java_NL.NL_print_hash_name_priv().clone();

//line 316
___nl__9 = new ImmString(".put(new ImmString(\"").clone();
//line 316
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 316
___nl__9 = null;
//line 316
___nl__10 = ((ImmHash)___nl__3).getHashValue()["key"].clone();
//line 316
___nl__9 = generator_java_NL.NL_escape_string_priv(___nl__10).clone();

//line 316
___nl__10 = null;
//line 316
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 316
___nl__9 = null;
//line 316
___nl__9 = new ImmString("\"),").clone();
//line 316
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 316
___nl__9 = null;
//line 316
___nl__10 = ((ImmHash)___nl__3).getHashValue()["val"].clone();
//line 316
___nl__9 = generator_java_NL.NL_print_register_getter_priv(___nl__10).clone();

//line 316
___nl__10 = null;
//line 316
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 316
___nl__9 = null;
//line 316
___nl__9 = new ImmString(");").clone();
//line 316
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 316
___nl__9 = null;
//line 316
___nl__9 = string_NL.NL_lf().clone();

//line 316
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 316
___nl__9 = null;
//line 316
___nl__1 = new ImmString(___nl__1.toString() + ___nl__8.toString()).clone();
//line 316
___nl__8 = null;
//line 316
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
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
___nl__0 = new ImmString("__function_map").clone();
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
___nl__1 = new ImmString("((ImmMap)").clone();
//line 325
___nl__3 = ((ImmHash)___nl__0).getHashValue()["src"].clone();
//line 325
___nl__2 = generator_java_NL.NL_print_register_getter_priv(___nl__3).clone();

//line 325
___nl__3 = null;
//line 325
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 325
___nl__2 = null;
//line 325
___nl__2 = new ImmString(")").clone();
//line 325
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 325
___nl__2 = null;
//line 325
___nl__2 = generator_java_NL.NL_print_getter_priv().clone();

//line 325
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 325
___nl__2 = null;
//line 325
___nl__2 = new ImmString(".get(new ImmString(\"").clone();
//line 325
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 325
___nl__2 = null;
//line 325
___nl__3 = ((ImmHash)___nl__0).getHashValue()["key"].clone();
//line 325
___nl__2 = generator_java_NL.NL_escape_string_priv(___nl__3).clone();

//line 325
___nl__3 = null;
//line 325
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 325
___nl__2 = null;
//line 325
___nl__2 = new ImmString("\"))").clone();
//line 325
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
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
___nl__1 = new ImmString("((ImmMap)").clone();
//line 329
___nl__3 = ((ImmHash)___nl__0).getHashValue()["src"].clone();
//line 329
___nl__2 = generator_java_NL.NL_print_register_getter_priv(___nl__3).clone();

//line 329
___nl__3 = null;
//line 329
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 329
___nl__2 = null;
//line 329
___nl__2 = new ImmString(")").clone();
//line 329
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 329
___nl__2 = null;
//line 329
___nl__2 = generator_java_NL.NL_print_getter_priv().clone();

//line 329
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 329
___nl__2 = null;
//line 329
___nl__2 = new ImmString(".put(new ImmString(\"").clone();
//line 329
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 329
___nl__2 = null;
//line 329
___nl__3 = ((ImmHash)___nl__0).getHashValue()["key"].clone();
//line 329
___nl__2 = generator_java_NL.NL_escape_string_priv(___nl__3).clone();

//line 329
___nl__3 = null;
//line 329
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 329
___nl__2 = null;
//line 329
___nl__2 = new ImmString("\"), ").clone();
//line 329
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 329
___nl__2 = null;
//line 330
___nl__3 = ((ImmHash)___nl__0).getHashValue()["val"].clone();
//line 330
___nl__2 = generator_java_NL.NL_print_register_getter_priv(___nl__3).clone();

//line 330
___nl__3 = null;
//line 330
___nl__3 = new ImmString(")").clone();
//line 330
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 330
___nl__3 = null;
//line 330
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
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
___nl__1 = new ImmString("").clone();
//line 336
___nl__2 = ((ImmHash)___nl__0).getHashValue()["src"].clone();
//line 336
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("emp")).clone();
//line 336
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 336
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 336
___nl__2 = ((ImmHash)___nl__0).getHashValue()["name"].clone();
//line 336
___nl__4 = new ImmString("TRUE").clone();
//line 336
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__4.toString())).clone();
//line 336
___nl__4 = null;
//line 336
label_3:
//line 336
___nl__3 = null;
//line 336
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 336
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 337
___nl__3 = new ImmString("c_rt_lib_NL.get_true_nl()").clone();
//line 337
___nl__1 = ___nl__3.clone();
//line 337
___nl__3 = null;
//line 338
if (true) {goto label_1;}
//line 338
label_2:
//line 338
___nl__2 = ((ImmHash)___nl__0).getHashValue()["src"].clone();
//line 338
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("emp")).clone();
//line 338
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 338
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_5;}}
//line 338
___nl__2 = ((ImmHash)___nl__0).getHashValue()["name"].clone();
//line 338
___nl__4 = new ImmString("FALSE").clone();
//line 338
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__4.toString())).clone();
//line 338
___nl__4 = null;
//line 338
label_5:
//line 338
___nl__3 = null;
//line 338
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 338
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_4;}}
//line 339
___nl__3 = new ImmString("c_rt_lib_NL.get_false_nl()").clone();
//line 339
___nl__1 = ___nl__3.clone();
//line 339
___nl__3 = null;
//line 340
if (true) {goto label_1;}
//line 340
label_4:
//line 341
___nl__3 = ((ImmHash)___nl__0).getHashValue()["src"].clone();
//line 341
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("arg")).clone();
//line 341
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_7;}}
//line 343
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("emp")).clone();
//line 343
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_8;}}
//line 343
___nl__4 = new ImmString("NOMATCHALERT").clone();
//line 343
___nl__4 = new ImmArray(new Imm[] {___nl__4,___nl__3,}).clone();
//line 343
c_rt_lib_NL.NL_die();
//line 341
label_7:
//line 341
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("arg")).clone();
//line 342
___nl__6 = new ImmString("c_rt_lib_NL.ov_mk_arg_nl(new ImmString(\"").clone();
//line 342
___nl__8 = ((ImmHash)___nl__0).getHashValue()["name"].clone();
//line 342
___nl__7 = generator_java_NL.NL_escape_string_priv(___nl__8).clone();

//line 342
___nl__8 = null;
//line 342
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 342
___nl__7 = null;
//line 342
___nl__7 = new ImmString("\"), ").clone();
//line 342
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 342
___nl__7 = null;
//line 342
___nl__7 = generator_java_NL.NL_print_register_priv(___nl__5).clone();

//line 342
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 342
___nl__7 = null;
//line 342
___nl__7 = new ImmString(")").clone();
//line 342
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 342
___nl__7 = null;
//line 342
___nl__1 = ___nl__6.clone();
//line 342
___nl__6 = null;
//line 342
___nl__5 = null;
//line 343
if (true) {goto label_6;}
//line 343
label_8:
//line 344
___nl__5 = new ImmString("c_rt_lib_NL.ov_mk_none_nl(new ImmString(\"").clone();
//line 344
___nl__7 = ((ImmHash)___nl__0).getHashValue()["name"].clone();
//line 344
___nl__6 = generator_java_NL.NL_escape_string_priv(___nl__7).clone();

//line 344
___nl__7 = null;
//line 344
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 344
___nl__6 = null;
//line 344
___nl__6 = new ImmString("\"))").clone();
//line 344
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 344
___nl__6 = null;
//line 344
___nl__1 = ___nl__5.clone();
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
___nl__3 = ((ImmHash)___nl__0).getHashValue()["dest"].clone();
//line 347
___nl__2 = generator_java_NL.NL_print_register_setter_priv(___nl__3,___nl__1).clone();

//line 347
___nl__3 = null;
//line 347
___nl__3 = new ImmString(";").clone();
//line 347
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
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
___nl__1 = new ImmString("___nl__").clone();
//line 351
___nl__1 = new ImmString(___nl__1.toString() + ___nl__0.toString()).clone();
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
___nl__1 = generator_java_NL.NL_print_register_priv(___nl__0).clone();

//line 355
___nl__2 = generator_java_NL.NL_print_getter_priv().clone();

//line 355
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
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
___nl__0 = new ImmString(".getValue()").clone();
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
___nl__2 = new ImmString("").clone();
//line 363
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__2.toString())).clone();
//line 363
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 363
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 363
___nl__3 = new ImmString("").clone();
//line 363
___nl__3 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
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
___nl__2 = generator_java_NL.NL_print_register_priv(___nl__0).clone();

//line 364
___nl__3 = new ImmString(".setValue(").clone();
//line 364
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 364
___nl__3 = null;
//line 364
___nl__2 = new ImmString(___nl__2.toString() + ___nl__1.toString()).clone();
//line 364
___nl__3 = new ImmString(")").clone();
//line 364
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
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
___nl__1 = new ImmString("").clone();
//line 369
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("val")).clone();
//line 369
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 371
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("emp")).clone();
//line 371
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_3;}}
//line 371
___nl__2 = new ImmString("NOMATCHALERT").clone();
//line 371
___nl__2 = new ImmArray(new Imm[] {___nl__2,___nl__0,}).clone();
//line 371
c_rt_lib_NL.NL_die();
//line 369
label_2:
//line 369
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("val")).clone();
//line 370
___nl__4 = new ImmString("return ").clone();
//line 370
___nl__5 = generator_java_NL.NL_print_register_getter_priv(___nl__3).clone();

//line 370
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 370
___nl__5 = null;
//line 370
___nl__5 = new ImmString(";").clone();
//line 370
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 370
___nl__5 = null;
//line 370
___nl__1 = ___nl__4.clone();
//line 370
___nl__4 = null;
//line 370
___nl__3 = null;
//line 371
if (true) {goto label_1;}
//line 371
label_3:
//line 372
___nl__3 = new ImmString("return null;").clone();
//line 372
___nl__1 = ___nl__3.clone();
//line 372
___nl__3 = null;
//line 373
if (true) {goto label_1;}
//line 373
label_1:
//line 373
___nl__2 = null;
//line 374
___nl__2 = new ImmString("if(true) ").clone();
//line 374
___nl__2 = new ImmString(___nl__2.toString() + ___nl__1.toString()).clone();
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
___nl__1 = new ImmString("").clone();
//line 379
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 379
___nl__3 = new ImmString("!").clone();
//line 379
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 379
___nl__3 = null;
//line 379
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 379
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 380
___nl__3 = new ImmString("c_rt_lib_NL.native_to_nl_nl(!c_rt_lib_NL.check_true_native_nl(").clone();
//line 380
___nl__5 = ((ImmHash)___nl__0).getHashValue()["src"].clone();
//line 380
___nl__4 = generator_java_NL.NL_print_register_priv(___nl__5).clone();

//line 380
___nl__5 = null;
//line 380
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 380
___nl__4 = null;
//line 380
___nl__4 = new ImmString("))").clone();
//line 380
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 380
___nl__4 = null;
//line 380
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 380
___nl__3 = null;
//line 381
if (true) {goto label_1;}
//line 381
label_2:
//line 382
___nl__3 = new ImmString("new ImmDouble(").clone();
//line 382
___nl__4 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 382
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 382
___nl__4 = null;
//line 382
___nl__4 = new ImmString("((ImmDouble)").clone();
//line 382
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 382
___nl__4 = null;
//line 382
___nl__5 = ((ImmHash)___nl__0).getHashValue()["src"].clone();
//line 382
___nl__4 = generator_java_NL.NL_print_register_getter_priv(___nl__5).clone();

//line 382
___nl__5 = null;
//line 382
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 382
___nl__4 = null;
//line 382
___nl__4 = new ImmString(")").clone();
//line 382
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 382
___nl__4 = null;
//line 382
___nl__4 = generator_java_NL.NL_print_getter_priv().clone();

//line 382
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 382
___nl__4 = null;
//line 382
___nl__4 = new ImmString(")").clone();
//line 382
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 382
___nl__4 = null;
//line 382
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 382
___nl__3 = null;
//line 383
if (true) {goto label_1;}
//line 383
label_1:
//line 383
___nl__2 = null;
//line 384
___nl__3 = ((ImmHash)___nl__0).getHashValue()["dest"].clone();
//line 384
___nl__2 = generator_java_NL.NL_print_register_setter_priv(___nl__3,___nl__1).clone();

//line 384
___nl__3 = null;
//line 384
___nl__3 = new ImmString(";").clone();
//line 384
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
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