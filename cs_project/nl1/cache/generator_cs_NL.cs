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
//line 17
___nl__1 = new ImmString("").clone();
//line 18
___nl__2 = generator_cs_NL.NL_print_imports_priv(___nl__0).clone();

//line 18
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 18
___nl__2 = null;
//line 19
___nl__3 = ((ImmHash)___nl__0).getHashValue()["module_name"].clone();
//line 19
___nl__2 = generator_cs_NL.NL_print_class_begin_priv(___nl__3).clone();

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
___nl__8 = generator_cs_NL.NL_print_function_or_singleton_priv(___nl__3,___nl__9).clone();

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
___nl__2 = generator_cs_NL.NL_print_class_end_priv().clone();

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
//line 27
___nl__1 = new ImmString("").clone();
//line 28
___nl__2 = new ImmString("using System;").clone();
//line 28
___nl__3 = string_NL.NL_lf().clone();

//line 28
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 28
___nl__3 = null;
//line 28
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 28
___nl__2 = null;
//line 29
___nl__2 = new ImmString("using System.Collections.Generic;").clone();
//line 29
___nl__3 = string_NL.NL_lf().clone();

//line 29
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 29
___nl__3 = null;
//line 29
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 29
___nl__2 = null;
//line 30
___nl__2 = new ImmString("using nianio;").clone();
//line 30
___nl__3 = string_NL.NL_lf().clone();

//line 30
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 30
___nl__3 = null;
//line 30
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 30
___nl__2 = null;
//line 34
___nl__0 = null;
//line 34
if(true) return ___nl__1;
//line 34
___nl__1 = null;
//line 34
___nl__0 = null;
//line 34
if(true) return null;
}

private static Imm NL_get_class_name_priv(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 38
___nl__1 = new ImmString("_NL").clone();
//line 38
___nl__1 = new ImmString(___nl__0.toString() + ___nl__1.toString()).clone();
//line 38
___nl__0 = null;
//line 38
if(true) return ___nl__1;
//line 38
___nl__1 = null;
//line 38
___nl__0 = null;
//line 38
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
//line 42
___nl__1 = new ImmString("namespace nianio { ").clone();
//line 42
___nl__2 = string_NL.NL_lf().clone();

//line 42
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 42
___nl__2 = null;
//line 43
___nl__2 = new ImmString("public class ").clone();
//line 43
___nl__3 = generator_cs_NL.NL_get_class_name_priv(___nl__0).clone();

//line 43
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 43
___nl__3 = null;
//line 43
___nl__3 = new ImmString(" {").clone();
//line 43
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 43
___nl__3 = null;
//line 43
___nl__3 = string_NL.NL_lf().clone();

//line 43
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 43
___nl__3 = null;
//line 43
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 43
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
Imm ___nl__2 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 48
___nl__0 = string_NL.NL_lf().clone();

//line 48
___nl__1 = new ImmString("}").clone();
//line 48
___nl__0 = new ImmString(___nl__0.toString() + ___nl__1.toString()).clone();
//line 48
___nl__1 = null;
//line 49
___nl__1 = string_NL.NL_lf().clone();

//line 49
___nl__2 = new ImmString("}").clone();
//line 49
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 49
___nl__2 = null;
//line 49
___nl__0 = new ImmString(___nl__0.toString() + ___nl__1.toString()).clone();
//line 49
___nl__1 = null;
//line 50
if(true) return ___nl__0;
//line 50
___nl__0 = null;
//line 50
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
//line 54
___nl__1 = new ImmString("").clone();
//line 55
___nl__2 = ((ImmHash)___nl__0).getHashValue()["access"].clone();
//line 55
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("pub")).clone();
//line 55
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 56
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("priv")).clone();
//line 56
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 56
___nl__3 = new ImmString("NOMATCHALERT").clone();
//line 56
___nl__3 = new ImmArray(new Imm[] {___nl__3,___nl__2,}).clone();
//line 56
c_rt_lib_NL.NL_die();
//line 55
label_2:
//line 56
if (true) {goto label_1;}
//line 56
label_3:
//line 57
___nl__4 = new ImmString("_priv").clone();
//line 57
___nl__1 = ___nl__4.clone();
//line 57
___nl__4 = null;
//line 58
if (true) {goto label_1;}
//line 58
label_1:
//line 58
___nl__2 = null;
//line 58
___nl__3 = null;
//line 59
___nl__2 = new ImmString("NL_").clone();
//line 59
___nl__3 = ((ImmHash)___nl__0).getHashValue()["name"].clone();
//line 59
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 59
___nl__3 = null;
//line 59
___nl__2 = new ImmString(___nl__2.toString() + ___nl__1.toString()).clone();
//line 59
___nl__0 = null;
//line 59
___nl__1 = null;
//line 59
if(true) return ___nl__2;
//line 59
___nl__2 = null;
//line 59
___nl__1 = null;
//line 59
___nl__0 = null;
//line 59
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
//line 63
___nl__1 = new ImmString("").clone();
//line 64
___nl__2 = ((ImmHash)___nl__0).getHashValue()["access"].clone();
//line 64
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("pub")).clone();
//line 64
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 66
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("priv")).clone();
//line 66
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 66
___nl__3 = new ImmString("NOMATCHALERT").clone();
//line 66
___nl__3 = new ImmArray(new Imm[] {___nl__3,___nl__2,}).clone();
//line 66
c_rt_lib_NL.NL_die();
//line 64
label_2:
//line 65
___nl__4 = new ImmString("public").clone();
//line 65
___nl__1 = ___nl__4.clone();
//line 65
___nl__4 = null;
//line 66
if (true) {goto label_1;}
//line 66
label_3:
//line 67
___nl__4 = new ImmString("private").clone();
//line 67
___nl__1 = ___nl__4.clone();
//line 67
___nl__4 = null;
//line 68
if (true) {goto label_1;}
//line 68
label_1:
//line 68
___nl__2 = null;
//line 68
___nl__3 = null;
//line 69
___nl__2 = new ImmString(" static Imm ").clone();
//line 69
___nl__2 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 69
___nl__3 = generator_cs_NL.NL_get_function_name_priv(___nl__0).clone();

//line 69
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 69
___nl__3 = null;
//line 69
___nl__0 = null;
//line 69
___nl__1 = null;
//line 69
if(true) return ___nl__2;
//line 69
___nl__2 = null;
//line 69
___nl__1 = null;
//line 69
___nl__0 = null;
//line 69
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
//line 73
___nl__2 = new ImmString("\\").clone();
//line 73
___nl__3 = new ImmString("\\\\").clone();
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
___nl__2 = new ImmString("\"").clone();
//line 74
___nl__3 = new ImmString("\\\"").clone();
//line 74
___nl__1 = string_NL.NL_replace(___nl__0,___nl__2,___nl__3).clone();

//line 74
___nl__3 = null;
//line 74
___nl__2 = null;
//line 74
___nl__0 = ___nl__1.clone();
//line 74
___nl__1 = null;
//line 75
___nl__3 = new ImmDouble(13).clone();
//line 75
___nl__2 = string_NL.NL_chr(___nl__3).clone();

//line 75
___nl__3 = null;
//line 75
___nl__3 = string_NL.NL_lf().clone();

//line 75
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 75
___nl__3 = null;
//line 75
___nl__3 = new ImmString("\\r\\n").clone();
//line 75
___nl__1 = string_NL.NL_replace(___nl__0,___nl__2,___nl__3).clone();

//line 75
___nl__3 = null;
//line 75
___nl__2 = null;
//line 75
___nl__0 = ___nl__1.clone();
//line 75
___nl__1 = null;
//line 76
___nl__2 = string_NL.NL_lf().clone();

//line 76
___nl__3 = new ImmString("\\n").clone();
//line 76
___nl__1 = string_NL.NL_replace(___nl__0,___nl__2,___nl__3).clone();

//line 76
___nl__3 = null;
//line 76
___nl__2 = null;
//line 76
___nl__0 = null;
//line 76
if(true) return ___nl__1;
//line 76
___nl__1 = null;
//line 76
___nl__0 = null;
//line 76
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
//line 79
___nl__2 = ((ImmHash)___nl__0).getHashValue()["args_type"].clone();
//line 79
___nl__1 = array_NL.NL_len(___nl__2).clone();

//line 79
___nl__2 = null;
//line 79
___nl__2 = new ImmDouble(0).clone();
//line 79
___nl__1 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__1.getValue().ToString()))>(Double.Parse(___nl__2.getValue().ToString())) ).clone();
//line 79
___nl__2 = null;
//line 79
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1)).clone();
//line 79
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_2;}}
//line 79
___nl__2 = c_rt_lib_NL.NL_get_false().clone();
//line 79
___nl__0 = null;
//line 79
___nl__1 = null;
//line 79
if(true) return ___nl__2;
//line 79
___nl__2 = null;
//line 79
if (true) {goto label_2;}
//line 79
label_2:
//line 79
___nl__1 = null;
//line 80
___nl__1 = ((ImmHash)___nl__0).getHashValue()["annotation"].clone();
//line 80
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("math")).clone();
//line 80
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1)).clone();
//line 80
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_4;}}
//line 80
___nl__2 = c_rt_lib_NL.NL_get_true().clone();
//line 80
___nl__0 = null;
//line 80
___nl__1 = null;
//line 80
if(true) return ___nl__2;
//line 80
___nl__2 = null;
//line 80
if (true) {goto label_4;}
//line 80
label_4:
//line 80
___nl__1 = null;
//line 81
___nl__1 = c_rt_lib_NL.NL_get_false().clone();
//line 83
___nl__3 = ((ImmHash)___nl__0).getHashValue()["commands"].clone();
//line 83
___nl__5 = new ImmDouble(0).clone();
//line 83
___nl__6 = new ImmDouble(1).clone();
//line 83
___nl__7 = c_rt_lib_NL.NL_array_len(___nl__3).clone();

//line 83
label_7:
//line 83
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) ).clone();
//line 83
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_5;}}
//line 83
___nl__4 = (___nl__3 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()].clone();
//line 84
___nl__9 = ((ImmHash)___nl__4).getHashValue()["cmd"].clone();
//line 85
___nl__10 = ___nl__9.clone();
//line 85
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__10, new ImmString("call")).clone();
//line 85
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 85
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_9;}}
//line 86
___nl__11 = ___nl__9.clone();
//line 86
___nl__11 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("call")).clone();
//line 87
___nl__12 = ((ImmHash)___nl__11).getHashValue()["fun_name"].clone();
//line 87
___nl__13 = new ImmString("sigleton_do_not_use_without_approval").clone();
//line 87
___nl__12 = c_rt_lib_NL.NL_native_to_nl(___nl__12.toString().Equals(___nl__13.toString())).clone();
//line 87
___nl__13 = null;
//line 87
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 87
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 87
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_11;}}
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
if (true) {goto label_11;}
//line 87
label_11:
//line 87
___nl__12 = null;
//line 88
___nl__12 = ((ImmHash)___nl__11).getHashValue()["mod"].clone();
//line 88
___nl__13 = new ImmString("singleton").clone();
//line 88
___nl__12 = c_rt_lib_NL.NL_native_to_nl(___nl__12.toString().Equals(___nl__13.toString())).clone();
//line 88
___nl__13 = null;
//line 88
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 88
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 88
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_13;}}
//line 88
___nl__9 = null;
//line 88
___nl__10 = null;
//line 88
___nl__11 = null;
//line 88
___nl__12 = null;
//line 88
if (true) {goto label_6;}
//line 88
if (true) {goto label_13;}
//line 88
label_13:
//line 88
___nl__12 = null;
//line 89
___nl__12 = c_rt_lib_NL.NL_get_true().clone();
//line 89
___nl__1 = ___nl__12.clone();
//line 89
___nl__12 = null;
//line 90
___nl__12 = ((ImmHash)___nl__11).getHashValue()["dest"].clone();
//line 90
___nl__2 = ___nl__12.clone();
//line 90
___nl__12 = null;
//line 90
___nl__11 = null;
//line 91
if (true) {goto label_8;}
//line 91
label_9:
//line 91
___nl__10 = ___nl__9.clone();
//line 91
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__10, new ImmString("return")).clone();
//line 91
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 91
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_14;}}
//line 92
___nl__11 = ___nl__1.clone();
//line 92
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 92
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 92
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_16;}}
//line 92
___nl__12 = c_rt_lib_NL.NL_get_false().clone();
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
if(true) return ___nl__12;
//line 92
___nl__12 = null;
//line 92
if (true) {goto label_16;}
//line 92
label_16:
//line 92
___nl__11 = null;
//line 93
___nl__11 = ___nl__9.clone();
//line 93
___nl__11 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("return")).clone();
//line 94
___nl__12 = ___nl__11.clone();
//line 94
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__12, new ImmString("val")).clone();
//line 94
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 94
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 94
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_18;}}
//line 94
___nl__13 = c_rt_lib_NL.NL_get_false().clone();
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
___nl__12 = null;
//line 94
if(true) return ___nl__13;
//line 94
___nl__13 = null;
//line 94
if (true) {goto label_18;}
//line 94
label_18:
//line 94
___nl__12 = null;
//line 95
___nl__12 = ___nl__11.clone();
//line 95
___nl__12 = c_rt_lib_NL.NL_ov_as(___nl__12, new ImmString("val")).clone();
//line 95
___nl__12 = c_rt_lib_NL.NL_native_to_nl(___nl__12.toString().Equals(___nl__2.toString())).clone();
//line 95
___nl__0 = null;
//line 95
___nl__1 = null;
//line 95
___nl__2 = null;
//line 95
___nl__3 = null;
//line 95
___nl__4 = null;
//line 95
___nl__5 = null;
//line 95
___nl__6 = null;
//line 95
___nl__7 = null;
//line 95
___nl__8 = null;
//line 95
___nl__9 = null;
//line 95
___nl__10 = null;
//line 95
___nl__11 = null;
//line 95
if(true) return ___nl__12;
//line 95
___nl__12 = null;
//line 95
___nl__11 = null;
//line 96
if (true) {goto label_8;}
//line 96
label_14:
//line 96
___nl__10 = ___nl__9.clone();
//line 96
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__10, new ImmString("prt_lbl")).clone();
//line 96
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 96
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_19;}}
//line 97
if (true) {goto label_8;}
//line 97
label_19:
//line 97
___nl__10 = ___nl__9.clone();
//line 97
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__10, new ImmString("clear")).clone();
//line 97
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10)).clone();
//line 97
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_20;}}
//line 98
if (true) {goto label_8;}
//line 98
label_20:
//line 99
___nl__11 = ___nl__1.clone();
//line 99
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 99
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_22;}}
//line 99
___nl__12 = c_rt_lib_NL.NL_get_false().clone();
//line 99
___nl__0 = null;
//line 99
___nl__1 = null;
//line 99
___nl__2 = null;
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
//line 99
___nl__9 = null;
//line 99
___nl__10 = null;
//line 99
___nl__11 = null;
//line 99
if(true) return ___nl__12;
//line 99
___nl__12 = null;
//line 99
if (true) {goto label_22;}
//line 99
label_22:
//line 99
___nl__11 = null;
//line 100
if (true) {goto label_8;}
//line 100
label_8:
//line 100
___nl__10 = null;
//line 100
___nl__9 = null;
//line 100
label_6:
//line 101
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString()))).clone();
//line 101
if (true) {goto label_7;}
//line 101
label_5:
//line 101
___nl__3 = null;
//line 101
___nl__4 = null;
//line 101
___nl__5 = null;
//line 101
___nl__6 = null;
//line 101
___nl__7 = null;
//line 101
___nl__8 = null;
//line 102
___nl__3 = c_rt_lib_NL.NL_get_false().clone();
//line 102
___nl__0 = null;
//line 102
___nl__1 = null;
//line 102
___nl__2 = null;
//line 102
if(true) return ___nl__3;
//line 102
___nl__3 = null;
//line 102
___nl__1 = null;
//line 102
___nl__2 = null;
//line 102
___nl__0 = null;
//line 102
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
//line 107
___nl__2 = new ImmString("").clone();
//line 107
___nl__3 = new ImmString("#").clone();
//line 107
___nl__4 = dfile_NL.NL_ssave_net_format(___nl__0).clone();

//line 107
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 107
___nl__4 = null;
//line 107
___nl__4 = string_NL.NL_lf().clone();

//line 107
new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 107
___nl__3 = null;
//line 107
___nl__4 = null;
//line 108
___nl__3 = generator_cs_NL.NL_is_singleton_use_function_priv(___nl__0).clone();

//line 108
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 108
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 109
___nl__4 = ___nl__0.clone();
//line 110
___nl__5 = new ImmString("SINGLETON_").clone();
//line 110
___nl__6 = ((ImmHash)___nl__0).getHashValue()["name"].clone();
//line 110
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 110
___nl__6 = null;
//line 110
___nl__6 = ___nl__5.clone();
//line 110
((ImmHash)___nl__4).set("name", ___nl__6);
//line 110
___nl__5 = null;
//line 110
___nl__6 = null;
//line 111
___nl__5 = generator_cs_NL.NL_get_function_name_priv(___nl__4).clone();

//line 112
___nl__6 = new ImmString("value__singleton__").clone();
//line 112
___nl__6 = new ImmString(___nl__6.toString() + ___nl__5.toString()).clone();
//line 114
___nl__7 = generator_cs_NL.NL_print_function_priv(___nl__4,___nl__1).clone();

//line 114
___nl__2 = new ImmString(___nl__2.toString() + ___nl__7.toString()).clone();
//line 114
___nl__7 = null;
//line 116
___nl__7 = new ImmString("private static Imm ").clone();
//line 116
___nl__7 = new ImmString(___nl__7.toString() + ___nl__6.toString()).clone();
//line 116
___nl__8 = new ImmString(" = null;").clone();
//line 116
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 116
___nl__8 = null;
//line 116
___nl__8 = string_NL.NL_lf().clone();

//line 116
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 116
___nl__8 = null;
//line 116
___nl__8 = generator_cs_NL.NL_get_function_declaration_priv(___nl__0).clone();

//line 116
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 116
___nl__8 = null;
//line 116
___nl__8 = new ImmString("() {\n	if (").clone();
//line 116
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 116
___nl__8 = null;
//line 116
___nl__7 = new ImmString(___nl__7.toString() + ___nl__6.toString()).clone();
//line 116
___nl__8 = new ImmString(" == null) {\n		").clone();
//line 116
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 116
___nl__8 = null;
//line 116
___nl__7 = new ImmString(___nl__7.toString() + ___nl__6.toString()).clone();
//line 116
___nl__8 = new ImmString(" = ").clone();
//line 116
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 116
___nl__8 = null;
//line 116
___nl__7 = new ImmString(___nl__7.toString() + ___nl__5.toString()).clone();
//line 116
___nl__8 = new ImmString("();\n	}\n	return ").clone();
//line 116
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 116
___nl__8 = null;
//line 116
___nl__7 = new ImmString(___nl__7.toString() + ___nl__6.toString()).clone();
//line 116
___nl__8 = new ImmString(";\n}").clone();
//line 116
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 116
___nl__8 = null;
//line 116
___nl__2 = new ImmString(___nl__2.toString() + ___nl__7.toString()).clone();
//line 116
___nl__7 = null;
//line 123
___nl__0 = null;
//line 123
___nl__1 = null;
//line 123
___nl__3 = null;
//line 123
___nl__4 = null;
//line 123
___nl__5 = null;
//line 123
___nl__6 = null;
//line 123
if(true) return ___nl__2;
//line 123
___nl__4 = null;
//line 123
___nl__5 = null;
//line 123
___nl__6 = null;
//line 124
if (true) {goto label_1;}
//line 124
label_2:
//line 125
___nl__4 = generator_cs_NL.NL_print_function_priv(___nl__0,___nl__1).clone();

//line 125
___nl__0 = null;
//line 125
___nl__1 = null;
//line 125
___nl__2 = null;
//line 125
___nl__3 = null;
//line 125
if(true) return ___nl__4;
//line 125
___nl__4 = null;
//line 126
if (true) {goto label_1;}
//line 126
label_1:
//line 126
___nl__3 = null;
//line 126
___nl__2 = null;
//line 126
___nl__0 = null;
//line 126
___nl__1 = null;
//line 126
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
//line 130
___nl__2 = string_NL.NL_lf().clone();

//line 130
___nl__3 = generator_cs_NL.NL_get_function_declaration_priv(___nl__0).clone();

//line 130
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 130
___nl__3 = null;
//line 130
___nl__3 = new ImmString("(").clone();
//line 130
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 130
___nl__3 = null;
//line 131
___nl__4 = ((ImmHash)___nl__0).getHashValue()["args_type"].clone();
//line 131
___nl__3 = array_NL.NL_len(___nl__4).clone();

//line 131
___nl__4 = null;
//line 131
___nl__4 = new ImmDouble(0).clone();
//line 131
___nl__5 = new ImmDouble(1).clone();
//line 131
label_3:
//line 131
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__3.getValue().ToString())) ).clone();
//line 131
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_1;}}
//line 132
___nl__7 = new ImmDouble(0).clone();
//line 132
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString())) ==((Double.Parse(___nl__7.getValue().ToString())))  ).clone();
//line 132
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 132
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 132
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_5;}}
//line 132
___nl__8 = new ImmString(", ").clone();
//line 132
___nl__2 = new ImmString(___nl__2.toString() + ___nl__8.toString()).clone();
//line 132
___nl__8 = null;
//line 132
if (true) {goto label_5;}
//line 132
label_5:
//line 132
___nl__7 = null;
//line 133
___nl__7 = ((ImmHash)___nl__0).getHashValue()["args_type"].clone();
//line 133
___nl__7 = (___nl__7 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()].clone();
//line 133
___nl__8 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("val")).clone();
//line 133
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_7;}}
//line 135
___nl__8 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("ref")).clone();
//line 135
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_8;}}
//line 135
___nl__8 = new ImmString("NOMATCHALERT").clone();
//line 135
___nl__8 = new ImmArray(new Imm[] {___nl__8,___nl__7,}).clone();
//line 135
c_rt_lib_NL.NL_die();
//line 133
label_7:
//line 134
___nl__9 = new ImmString("Imm ___arg__").clone();
//line 134
___nl__9 = new ImmString(___nl__9.toString() + ___nl__4.toString()).clone();
//line 134
___nl__2 = new ImmString(___nl__2.toString() + ___nl__9.toString()).clone();
//line 134
___nl__9 = null;
//line 135
if (true) {goto label_6;}
//line 135
label_8:
//line 136
___nl__9 = new ImmString("ImmRef ___arg__").clone();
//line 136
___nl__9 = new ImmString(___nl__9.toString() + ___nl__4.toString()).clone();
//line 136
___nl__2 = new ImmString(___nl__2.toString() + ___nl__9.toString()).clone();
//line 136
___nl__9 = null;
//line 137
if (true) {goto label_6;}
//line 137
label_6:
//line 137
___nl__7 = null;
//line 137
___nl__8 = null;
//line 138
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 138
if (true) {goto label_3;}
//line 138
label_1:
//line 138
___nl__3 = null;
//line 138
___nl__4 = null;
//line 138
___nl__5 = null;
//line 138
___nl__6 = null;
//line 139
___nl__3 = new ImmString(") {").clone();
//line 139
___nl__4 = string_NL.NL_lf().clone();

//line 139
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 139
___nl__4 = null;
//line 139
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 139
___nl__3 = null;
//line 140
___nl__4 = ((ImmHash)___nl__0).getHashValue()["args_type"].clone();
//line 140
___nl__3 = array_NL.NL_len(___nl__4).clone();

//line 140
___nl__4 = null;
//line 140
___nl__4 = new ImmDouble(0).clone();
//line 140
___nl__5 = new ImmDouble(1).clone();
//line 140
label_11:
//line 140
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__3.getValue().ToString())) ).clone();
//line 140
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_9;}}
//line 141
___nl__7 = ((ImmHash)___nl__0).getHashValue()["args_type"].clone();
//line 141
___nl__7 = (___nl__7 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()].clone();
//line 141
___nl__8 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("val")).clone();
//line 141
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_13;}}
//line 143
___nl__8 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("ref")).clone();
//line 143
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_14;}}
//line 143
___nl__8 = new ImmString("NOMATCHALERT").clone();
//line 143
___nl__8 = new ImmArray(new Imm[] {___nl__8,___nl__7,}).clone();
//line 143
c_rt_lib_NL.NL_die();
//line 141
label_13:
//line 142
___nl__9 = new ImmString("Imm ___nl__").clone();
//line 142
___nl__9 = new ImmString(___nl__9.toString() + ___nl__4.toString()).clone();
//line 142
___nl__10 = new ImmString(" = ___arg__").clone();
//line 142
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 142
___nl__10 = null;
//line 142
___nl__9 = new ImmString(___nl__9.toString() + ___nl__4.toString()).clone();
//line 142
___nl__10 = new ImmString(".clone();").clone();
//line 142
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 142
___nl__10 = null;
//line 142
___nl__2 = new ImmString(___nl__2.toString() + ___nl__9.toString()).clone();
//line 142
___nl__9 = null;
//line 143
if (true) {goto label_12;}
//line 143
label_14:
//line 144
___nl__9 = new ImmString("Imm ___nl__").clone();
//line 144
___nl__9 = new ImmString(___nl__9.toString() + ___nl__4.toString()).clone();
//line 144
___nl__10 = new ImmString(" = ___arg__").clone();
//line 144
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 144
___nl__10 = null;
//line 144
___nl__9 = new ImmString(___nl__9.toString() + ___nl__4.toString()).clone();
//line 144
___nl__10 = new ImmString(".getValue().clone();").clone();
//line 144
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 144
___nl__10 = null;
//line 144
___nl__2 = new ImmString(___nl__2.toString() + ___nl__9.toString()).clone();
//line 144
___nl__9 = null;
//line 145
if (true) {goto label_12;}
//line 145
label_12:
//line 145
___nl__7 = null;
//line 145
___nl__8 = null;
//line 146
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 146
if (true) {goto label_11;}
//line 146
label_9:
//line 146
___nl__3 = null;
//line 146
___nl__4 = null;
//line 146
___nl__5 = null;
//line 146
___nl__6 = null;
//line 147
___nl__3 = string_NL.NL_lf().clone();

//line 147
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 147
___nl__3 = null;
//line 148
___nl__4 = ((ImmHash)___nl__0).getHashValue()["args_type"].clone();
//line 148
___nl__3 = array_NL.NL_len(___nl__4).clone();

//line 148
___nl__4 = null;
//line 148
label_16:
//line 148
___nl__4 = ((ImmHash)___nl__0).getHashValue()["reg_size"].clone();
//line 148
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))<(Double.Parse(___nl__4.getValue().ToString())) ).clone();
//line 148
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 148
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_15;}}
//line 149
___nl__5 = new ImmString("Imm ___nl__").clone();
//line 149
___nl__5 = new ImmString(___nl__5.toString() + ___nl__3.toString()).clone();
//line 149
___nl__6 = new ImmString(" = null;").clone();
//line 149
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 149
___nl__6 = null;
//line 149
___nl__6 = string_NL.NL_lf().clone();

//line 149
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 149
___nl__6 = null;
//line 149
___nl__2 = new ImmString(___nl__2.toString() + ___nl__5.toString()).clone();
//line 149
___nl__5 = null;
//line 149
___nl__5 = new ImmDouble(1).clone();
//line 149
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 149
___nl__5 = null;
//line 150
if (true) {goto label_16;}
//line 150
label_15:
//line 150
___nl__3 = null;
//line 150
___nl__4 = null;
//line 151
___nl__3 = new ImmDouble(0).clone();
//line 151
label_19:
//line 151
___nl__4 = ((ImmHash)___nl__0).getHashValue()["reg_size"].clone();
//line 151
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))<(Double.Parse(___nl__4.getValue().ToString())) ).clone();
//line 151
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 151
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_18;}}
//line 152
___nl__5 = new ImmString("ImmRef ___ref______nl__").clone();
//line 152
___nl__5 = new ImmString(___nl__5.toString() + ___nl__3.toString()).clone();
//line 152
___nl__6 = new ImmString(" = null;").clone();
//line 152
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 152
___nl__6 = null;
//line 152
___nl__6 = string_NL.NL_lf().clone();

//line 152
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 152
___nl__6 = null;
//line 152
___nl__2 = new ImmString(___nl__2.toString() + ___nl__5.toString()).clone();
//line 152
___nl__5 = null;
//line 152
___nl__5 = new ImmDouble(1).clone();
//line 152
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 152
___nl__5 = null;
//line 153
if (true) {goto label_19;}
//line 153
label_18:
//line 153
___nl__3 = null;
//line 153
___nl__4 = null;
//line 154
___nl__3 = new ImmString("Dictionary<String, Imm> ").clone();
//line 154
___nl__4 = generator_cs_NL.NL_print_hash_name_priv().clone();

//line 154
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 154
___nl__4 = null;
//line 154
___nl__4 = new ImmString(";").clone();
//line 154
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 154
___nl__4 = null;
//line 154
___nl__4 = string_NL.NL_lf().clone();

//line 154
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 154
___nl__4 = null;
//line 154
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 154
___nl__3 = null;
//line 156
___nl__3 = new ImmString("").clone();
//line 157
___nl__5 = ((ImmHash)___nl__0).getHashValue()["args_type"].clone();
//line 157
___nl__4 = array_NL.NL_len(___nl__5).clone();

//line 157
___nl__5 = null;
//line 157
___nl__5 = new ImmDouble(0).clone();
//line 157
___nl__6 = new ImmDouble(1).clone();
//line 157
label_23:
//line 157
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__4.getValue().ToString())) ).clone();
//line 157
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_21;}}
//line 158
___nl__8 = ((ImmHash)___nl__0).getHashValue()["args_type"].clone();
//line 158
___nl__8 = (___nl__8 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()].clone();
//line 158
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("val")).clone();
//line 158
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_25;}}
//line 159
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("ref")).clone();
//line 159
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_26;}}
//line 159
___nl__9 = new ImmString("NOMATCHALERT").clone();
//line 159
___nl__9 = new ImmArray(new Imm[] {___nl__9,___nl__8,}).clone();
//line 159
c_rt_lib_NL.NL_die();
//line 158
label_25:
//line 159
if (true) {goto label_24;}
//line 159
label_26:
//line 160
___nl__10 = new ImmString("___arg__").clone();
//line 160
___nl__10 = new ImmString(___nl__10.toString() + ___nl__5.toString()).clone();
//line 160
___nl__11 = new ImmString(".setValue(___nl__").clone();
//line 160
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString()).clone();
//line 160
___nl__11 = null;
//line 160
___nl__10 = new ImmString(___nl__10.toString() + ___nl__5.toString()).clone();
//line 160
___nl__11 = new ImmString(");").clone();
//line 160
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString()).clone();
//line 160
___nl__11 = null;
//line 160
___nl__3 = new ImmString(___nl__3.toString() + ___nl__10.toString()).clone();
//line 160
___nl__10 = null;
//line 161
if (true) {goto label_24;}
//line 161
label_24:
//line 161
___nl__8 = null;
//line 161
___nl__9 = null;
//line 162
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString()))).clone();
//line 162
if (true) {goto label_23;}
//line 162
label_21:
//line 162
___nl__4 = null;
//line 162
___nl__5 = null;
//line 162
___nl__6 = null;
//line 162
___nl__7 = null;
//line 164
___nl__4 = ((ImmHash)___nl__0).getHashValue()["commands"].clone();
//line 164
___nl__6 = new ImmDouble(0).clone();
//line 164
___nl__7 = new ImmDouble(1).clone();
//line 164
___nl__8 = c_rt_lib_NL.NL_array_len(___nl__4).clone();

//line 164
label_29:
//line 164
___nl__9 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__6.getValue().ToString()))>=(Double.Parse(___nl__8.getValue().ToString())) ).clone();
//line 164
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_27;}}
//line 164
___nl__5 = (___nl__4 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()].clone();
//line 164
___nl__10 = generator_cs_NL.NL_print_command_priv(___nl__1,___nl__5,___nl__3).clone();

//line 164
___nl__2 = new ImmString(___nl__2.toString() + ___nl__10.toString()).clone();
//line 164
___nl__10 = null;
//line 164
___nl__6 = new ImmDouble((Double.Parse(___nl__6.getValue().ToString()))+(Double.Parse(___nl__7.getValue().ToString()))).clone();
//line 164
if (true) {goto label_29;}
//line 164
label_27:
//line 164
___nl__4 = null;
//line 164
___nl__5 = null;
//line 164
___nl__6 = null;
//line 164
___nl__7 = null;
//line 164
___nl__8 = null;
//line 164
___nl__9 = null;
//line 166
___nl__4 = new ImmString("}").clone();
//line 166
___nl__4 = new ImmString(___nl__2.toString() + ___nl__4.toString()).clone();
//line 166
___nl__5 = string_NL.NL_lf().clone();

//line 166
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 166
___nl__5 = null;
//line 166
___nl__0 = null;
//line 166
___nl__1 = null;
//line 166
___nl__2 = null;
//line 166
___nl__3 = null;
//line 166
if(true) return ___nl__4;
//line 166
___nl__4 = null;
//line 166
___nl__2 = null;
//line 166
___nl__3 = null;
//line 166
___nl__0 = null;
//line 166
___nl__1 = null;
//line 166
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
//line 171
___nl__4 = ((ImmHash)___nl__1).getHashValue()["cmd"].clone();
//line 171
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("arr_decl")).clone();
//line 171
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_2;}}
//line 173
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("hash_decl")).clone();
//line 173
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_3;}}
//line 176
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("call")).clone();
//line 176
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_4;}}
//line 180
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("func")).clone();
//line 180
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_5;}}
//line 182
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("una_op")).clone();
//line 182
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_6;}}
//line 184
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("bin_op")).clone();
//line 184
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_7;}}
//line 186
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("ov_is")).clone();
//line 186
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_8;}}
//line 188
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("ov_as")).clone();
//line 188
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_9;}}
//line 190
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("return")).clone();
//line 190
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_10;}}
//line 193
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("die")).clone();
//line 193
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_11;}}
//line 195
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("move")).clone();
//line 195
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_12;}}
//line 197
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("load_const")).clone();
//line 197
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_13;}}
//line 199
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("get_frm_idx")).clone();
//line 199
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_14;}}
//line 203
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("set_at_idx")).clone();
//line 203
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_15;}}
//line 206
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("get_val")).clone();
//line 206
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_16;}}
//line 208
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("set_val")).clone();
//line 208
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_17;}}
//line 210
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("ov_mk")).clone();
//line 210
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_18;}}
//line 212
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("prt_lbl")).clone();
//line 212
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_19;}}
//line 214
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("if_goto")).clone();
//line 214
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_20;}}
//line 216
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("goto")).clone();
//line 216
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_21;}}
//line 218
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("clear")).clone();
//line 218
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_22;}}
//line 218
___nl__5 = new ImmString("NOMATCHALERT").clone();
//line 218
___nl__5 = new ImmArray(new Imm[] {___nl__5,___nl__4,}).clone();
//line 218
c_rt_lib_NL.NL_die();
//line 171
label_2:
//line 171
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("arr_decl")).clone();
//line 172
___nl__8 = ((ImmHash)___nl__6).getHashValue()["dest"].clone();
//line 172
___nl__10 = ((ImmHash)___nl__6).getHashValue()["src"].clone();
//line 172
___nl__9 = generator_cs_NL.NL_print_arr_priv(___nl__10).clone();

//line 172
___nl__10 = null;
//line 172
___nl__7 = generator_cs_NL.NL_print_register_setter_priv(___nl__8,___nl__9).clone();

//line 172
___nl__9 = null;
//line 172
___nl__8 = null;
//line 172
___nl__8 = new ImmString(";").clone();
//line 172
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 172
___nl__8 = null;
//line 172
___nl__3 = ___nl__7.clone();
//line 172
___nl__7 = null;
//line 172
___nl__6 = null;
//line 173
if (true) {goto label_1;}
//line 173
label_3:
//line 173
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("hash_decl")).clone();
//line 174
___nl__7 = generator_cs_NL.NL_print_hash_priv(___nl__6).clone();

//line 174
___nl__3 = ___nl__7.clone();
//line 174
___nl__7 = null;
//line 175
___nl__8 = ((ImmHash)___nl__6).getHashValue()["dest"].clone();
//line 175
___nl__9 = new ImmString("new ImmHash(").clone();
//line 175
___nl__10 = generator_cs_NL.NL_print_hash_name_priv().clone();

//line 175
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 175
___nl__10 = null;
//line 175
___nl__10 = new ImmString(")").clone();
//line 175
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 175
___nl__10 = null;
//line 175
___nl__7 = generator_cs_NL.NL_print_register_setter_priv(___nl__8,___nl__9).clone();

//line 175
___nl__9 = null;
//line 175
___nl__8 = null;
//line 175
___nl__8 = new ImmString(";").clone();
//line 175
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 175
___nl__8 = null;
//line 175
___nl__3 = new ImmString(___nl__3.toString() + ___nl__7.toString()).clone();
//line 175
___nl__7 = null;
//line 175
___nl__6 = null;
//line 176
if (true) {goto label_1;}
//line 176
label_4:
//line 176
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("call")).clone();
//line 177
___nl__8 = ((ImmHash)___nl__6).getHashValue()["args"].clone();
//line 177
___nl__7 = generator_cs_NL.NL_print_call_ref_prepare_priv(___nl__8).clone();

//line 177
___nl__8 = null;
//line 177
___nl__3 = ___nl__7.clone();
//line 177
___nl__7 = null;
//line 178
___nl__8 = ((ImmHash)___nl__6).getHashValue()["dest"].clone();
//line 178
___nl__10 = ((ImmHash)___nl__6).getHashValue()["mod"].clone();
//line 178
___nl__11 = ((ImmHash)___nl__6).getHashValue()["fun_name"].clone();
//line 178
___nl__12 = ((ImmHash)___nl__6).getHashValue()["args"].clone();
//line 178
___nl__9 = generator_cs_NL.NL_print_call_priv(___nl__0,___nl__10,___nl__11,___nl__12).clone();

//line 178
___nl__12 = null;
//line 178
___nl__11 = null;
//line 178
___nl__10 = null;
//line 178
___nl__7 = generator_cs_NL.NL_print_register_setter_priv(___nl__8,___nl__9).clone();

//line 178
___nl__9 = null;
//line 178
___nl__8 = null;
//line 178
___nl__8 = new ImmString(";").clone();
//line 178
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 178
___nl__8 = null;
//line 178
___nl__8 = string_NL.NL_lf().clone();

//line 178
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 178
___nl__8 = null;
//line 178
___nl__3 = new ImmString(___nl__3.toString() + ___nl__7.toString()).clone();
//line 178
___nl__7 = null;
//line 179
___nl__8 = ((ImmHash)___nl__6).getHashValue()["args"].clone();
//line 179
___nl__7 = generator_cs_NL.NL_print_call_ref_setter_priv(___nl__8).clone();

//line 179
___nl__8 = null;
//line 179
___nl__3 = new ImmString(___nl__3.toString() + ___nl__7.toString()).clone();
//line 179
___nl__7 = null;
//line 179
___nl__6 = null;
//line 180
if (true) {goto label_1;}
//line 180
label_5:
//line 180
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("func")).clone();
//line 181
___nl__8 = ((ImmHash)___nl__6).getHashValue()["dest"].clone();
//line 181
___nl__11 = ((ImmHash)___nl__6).getHashValue()["module"].clone();
//line 181
___nl__10 = generator_cs_NL.NL_get_class_name_priv(___nl__11).clone();

//line 181
___nl__11 = null;
//line 181
___nl__11 = ((ImmHash)___nl__6).getHashValue()["name"].clone();
//line 181
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",___nl__10);
__function_map.Add("name",___nl__11);
___nl__9 = new ImmHash(__function_map).clone();
//line 181
___nl__10 = null;
//line 181
___nl__11 = null;
//line 181
___nl__7 = generator_cs_NL.NL_print_const_hash_priv(___nl__8,___nl__9).clone();

//line 181
___nl__9 = null;
//line 181
___nl__8 = null;
//line 181
___nl__8 = new ImmString(";").clone();
//line 181
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 181
___nl__8 = null;
//line 181
___nl__3 = ___nl__7.clone();
//line 181
___nl__7 = null;
//line 181
___nl__6 = null;
//line 182
if (true) {goto label_1;}
//line 182
label_6:
//line 182
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("una_op")).clone();
//line 183
___nl__7 = generator_cs_NL.NL_print_una_op_priv(___nl__6).clone();

//line 183
___nl__3 = ___nl__7.clone();
//line 183
___nl__7 = null;
//line 183
___nl__6 = null;
//line 184
if (true) {goto label_1;}
//line 184
label_7:
//line 184
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("bin_op")).clone();
//line 185
___nl__7 = generator_cs_NL.NL_print_bin_op_priv(___nl__6).clone();

//line 185
___nl__3 = ___nl__7.clone();
//line 185
___nl__7 = null;
//line 185
___nl__6 = null;
//line 186
if (true) {goto label_1;}
//line 186
label_8:
//line 186
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("ov_is")).clone();
//line 187
___nl__8 = ((ImmHash)___nl__6).getHashValue()["dest"].clone();
//line 187
___nl__9 = new ImmString("c_rt_lib_NL.NL_ov_is(").clone();
//line 187
___nl__11 = ((ImmHash)___nl__6).getHashValue()["src"].clone();
//line 187
___nl__10 = generator_cs_NL.NL_print_register_priv(___nl__11).clone();

//line 187
___nl__11 = null;
//line 187
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 187
___nl__10 = null;
//line 187
___nl__10 = new ImmString(", new ImmString(\"").clone();
//line 187
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 187
___nl__10 = null;
//line 187
___nl__11 = ((ImmHash)___nl__6).getHashValue()["type"].clone();
//line 187
___nl__10 = generator_cs_NL.NL_escape_string_priv(___nl__11).clone();

//line 187
___nl__11 = null;
//line 187
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 187
___nl__10 = null;
//line 187
___nl__10 = new ImmString("\"))").clone();
//line 187
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 187
___nl__10 = null;
//line 187
___nl__7 = generator_cs_NL.NL_print_register_setter_priv(___nl__8,___nl__9).clone();

//line 187
___nl__9 = null;
//line 187
___nl__8 = null;
//line 187
___nl__8 = new ImmString(";").clone();
//line 187
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 187
___nl__8 = null;
//line 187
___nl__3 = ___nl__7.clone();
//line 187
___nl__7 = null;
//line 187
___nl__6 = null;
//line 188
if (true) {goto label_1;}
//line 188
label_9:
//line 188
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("ov_as")).clone();
//line 189
___nl__8 = ((ImmHash)___nl__6).getHashValue()["dest"].clone();
//line 189
___nl__9 = new ImmString("c_rt_lib_NL.NL_ov_as(").clone();
//line 189
___nl__11 = ((ImmHash)___nl__6).getHashValue()["src"].clone();
//line 189
___nl__10 = generator_cs_NL.NL_print_register_priv(___nl__11).clone();

//line 189
___nl__11 = null;
//line 189
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 189
___nl__10 = null;
//line 189
___nl__10 = new ImmString(", new ImmString(\"").clone();
//line 189
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 189
___nl__10 = null;
//line 189
___nl__11 = ((ImmHash)___nl__6).getHashValue()["type"].clone();
//line 189
___nl__10 = generator_cs_NL.NL_escape_string_priv(___nl__11).clone();

//line 189
___nl__11 = null;
//line 189
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 189
___nl__10 = null;
//line 189
___nl__10 = new ImmString("\"))").clone();
//line 189
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 189
___nl__10 = null;
//line 189
___nl__7 = generator_cs_NL.NL_print_register_setter_priv(___nl__8,___nl__9).clone();

//line 189
___nl__9 = null;
//line 189
___nl__8 = null;
//line 189
___nl__8 = new ImmString(";").clone();
//line 189
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 189
___nl__8 = null;
//line 189
___nl__3 = ___nl__7.clone();
//line 189
___nl__7 = null;
//line 189
___nl__6 = null;
//line 190
if (true) {goto label_1;}
//line 190
label_10:
//line 190
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("return")).clone();
//line 191
___nl__3 = ___nl__2.clone();
//line 192
___nl__7 = generator_cs_NL.NL_print_return_priv(___nl__6).clone();

//line 192
___nl__3 = new ImmString(___nl__3.toString() + ___nl__7.toString()).clone();
//line 192
___nl__7 = null;
//line 192
___nl__6 = null;
//line 193
if (true) {goto label_1;}
//line 193
label_11:
//line 193
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("die")).clone();
//line 194
___nl__7 = new ImmString("c_rt_lib_NL.NL_die();").clone();
//line 194
___nl__3 = ___nl__7.clone();
//line 194
___nl__7 = null;
//line 194
___nl__6 = null;
//line 195
if (true) {goto label_1;}
//line 195
label_12:
//line 195
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("move")).clone();
//line 196
___nl__8 = ((ImmHash)___nl__6).getHashValue()["dest"].clone();
//line 196
___nl__10 = ((ImmHash)___nl__6).getHashValue()["src"].clone();
//line 196
___nl__9 = generator_cs_NL.NL_print_register_priv(___nl__10).clone();

//line 196
___nl__10 = null;
//line 196
___nl__7 = generator_cs_NL.NL_print_register_setter_priv(___nl__8,___nl__9).clone();

//line 196
___nl__9 = null;
//line 196
___nl__8 = null;
//line 196
___nl__8 = new ImmString(";").clone();
//line 196
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 196
___nl__8 = null;
//line 196
___nl__3 = ___nl__7.clone();
//line 196
___nl__7 = null;
//line 196
___nl__6 = null;
//line 197
if (true) {goto label_1;}
//line 197
label_13:
//line 197
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("load_const")).clone();
//line 198
___nl__8 = ((ImmHash)___nl__6).getHashValue()["dest"].clone();
//line 198
___nl__11 = ((ImmHash)___nl__6).getHashValue()["dest"].clone();
//line 198
___nl__10 = generator_cs_NL.NL_print_register_priv(___nl__11).clone();

//line 198
___nl__11 = null;
//line 198
___nl__11 = ((ImmHash)___nl__6).getHashValue()["val"].clone();
//line 198
___nl__9 = generator_cs_NL.NL_print_const_value_priv(___nl__10,___nl__11).clone();

//line 198
___nl__11 = null;
//line 198
___nl__10 = null;
//line 198
___nl__7 = generator_cs_NL.NL_print_register_setter_priv(___nl__8,___nl__9).clone();

//line 198
___nl__9 = null;
//line 198
___nl__8 = null;
//line 198
___nl__8 = new ImmString(";").clone();
//line 198
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 198
___nl__8 = null;
//line 198
___nl__3 = ___nl__7.clone();
//line 198
___nl__7 = null;
//line 198
___nl__6 = null;
//line 199
if (true) {goto label_1;}
//line 199
label_14:
//line 199
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("get_frm_idx")).clone();
//line 200
___nl__7 = new ImmString("(").clone();
//line 200
___nl__9 = ((ImmHash)___nl__6).getHashValue()["src"].clone();
//line 200
___nl__8 = generator_cs_NL.NL_print_register_priv(___nl__9).clone();

//line 200
___nl__9 = null;
//line 200
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 200
___nl__8 = null;
//line 200
___nl__8 = new ImmString(" as ImmArray).getArrayValue()").clone();
//line 200
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 200
___nl__8 = null;
//line 200
___nl__3 = ___nl__7.clone();
//line 200
___nl__7 = null;
//line 201
___nl__7 = new ImmString("[(int)((ImmDouble)").clone();
//line 201
___nl__9 = ((ImmHash)___nl__6).getHashValue()["idx"].clone();
//line 201
___nl__8 = generator_cs_NL.NL_print_register_priv(___nl__9).clone();

//line 201
___nl__9 = null;
//line 201
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 201
___nl__8 = null;
//line 201
___nl__8 = new ImmString(").getDoubleValue()]").clone();
//line 201
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 201
___nl__8 = null;
//line 201
___nl__3 = new ImmString(___nl__3.toString() + ___nl__7.toString()).clone();
//line 201
___nl__7 = null;
//line 202
___nl__8 = ((ImmHash)___nl__6).getHashValue()["dest"].clone();
//line 202
___nl__7 = generator_cs_NL.NL_print_register_setter_priv(___nl__8,___nl__3).clone();

//line 202
___nl__8 = null;
//line 202
___nl__8 = new ImmString(";").clone();
//line 202
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 202
___nl__8 = null;
//line 202
___nl__3 = ___nl__7.clone();
//line 202
___nl__7 = null;
//line 202
___nl__6 = null;
//line 203
if (true) {goto label_1;}
//line 203
label_15:
//line 203
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("set_at_idx")).clone();
//line 204
___nl__7 = new ImmString("(").clone();
//line 204
___nl__9 = ((ImmHash)___nl__6).getHashValue()["src"].clone();
//line 204
___nl__8 = generator_cs_NL.NL_print_register_priv(___nl__9).clone();

//line 204
___nl__9 = null;
//line 204
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 204
___nl__8 = null;
//line 204
___nl__8 = new ImmString(" as ImmArray).getArrayValue()").clone();
//line 204
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 204
___nl__8 = null;
//line 204
___nl__3 = ___nl__7.clone();
//line 204
___nl__7 = null;
//line 205
___nl__7 = new ImmString("[(int)((ImmDouble)").clone();
//line 205
___nl__9 = ((ImmHash)___nl__6).getHashValue()["idx"].clone();
//line 205
___nl__8 = generator_cs_NL.NL_print_register_priv(___nl__9).clone();

//line 205
___nl__9 = null;
//line 205
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 205
___nl__8 = null;
//line 205
___nl__8 = new ImmString(").getDoubleValue()] = ").clone();
//line 205
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 205
___nl__8 = null;
//line 205
___nl__9 = ((ImmHash)___nl__6).getHashValue()["val"].clone();
//line 205
___nl__8 = generator_cs_NL.NL_print_register_priv(___nl__9).clone();

//line 205
___nl__9 = null;
//line 205
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 205
___nl__8 = null;
//line 205
___nl__8 = new ImmString(";").clone();
//line 205
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 205
___nl__8 = null;
//line 205
___nl__3 = new ImmString(___nl__3.toString() + ___nl__7.toString()).clone();
//line 205
___nl__7 = null;
//line 205
___nl__6 = null;
//line 206
if (true) {goto label_1;}
//line 206
label_16:
//line 206
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("get_val")).clone();
//line 207
___nl__8 = ((ImmHash)___nl__6).getHashValue()["dest"].clone();
//line 207
___nl__9 = generator_cs_NL.NL_print_get_hash_value_priv(___nl__6).clone();

//line 207
___nl__7 = generator_cs_NL.NL_print_register_setter_priv(___nl__8,___nl__9).clone();

//line 207
___nl__9 = null;
//line 207
___nl__8 = null;
//line 207
___nl__8 = new ImmString(";").clone();
//line 207
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 207
___nl__8 = null;
//line 207
___nl__3 = ___nl__7.clone();
//line 207
___nl__7 = null;
//line 207
___nl__6 = null;
//line 208
if (true) {goto label_1;}
//line 208
label_17:
//line 208
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("set_val")).clone();
//line 209
___nl__7 = generator_cs_NL.NL_print_set_hash_value_priv(___nl__6).clone();

//line 209
___nl__8 = new ImmString(";").clone();
//line 209
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 209
___nl__8 = null;
//line 209
___nl__3 = ___nl__7.clone();
//line 209
___nl__7 = null;
//line 209
___nl__6 = null;
//line 210
if (true) {goto label_1;}
//line 210
label_18:
//line 210
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("ov_mk")).clone();
//line 211
___nl__7 = generator_cs_NL.NL_print_ov_mk_priv(___nl__6).clone();

//line 211
___nl__3 = ___nl__7.clone();
//line 211
___nl__7 = null;
//line 211
___nl__6 = null;
//line 212
if (true) {goto label_1;}
//line 212
label_19:
//line 212
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("prt_lbl")).clone();
//line 213
___nl__7 = new ImmString("").clone();
//line 213
___nl__7 = new ImmString(___nl__7.toString() + ___nl__6.toString()).clone();
//line 213
___nl__8 = new ImmString(":").clone();
//line 213
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 213
___nl__8 = null;
//line 213
___nl__3 = ___nl__7.clone();
//line 213
___nl__7 = null;
//line 213
___nl__6 = null;
//line 214
if (true) {goto label_1;}
//line 214
label_20:
//line 214
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("if_goto")).clone();
//line 215
___nl__7 = new ImmString("if (c_rt_lib_NL.NL_check_true_native(").clone();
//line 215
___nl__9 = ((ImmHash)___nl__6).getHashValue()["src"].clone();
//line 215
___nl__8 = generator_cs_NL.NL_print_register_priv(___nl__9).clone();

//line 215
___nl__9 = null;
//line 215
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 215
___nl__8 = null;
//line 215
___nl__8 = new ImmString(")) {").clone();
//line 215
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 215
___nl__8 = null;
//line 215
___nl__9 = ((ImmHash)___nl__6).getHashValue()["dest"].clone();
//line 215
___nl__8 = generator_cs_NL.NL_print_goto_priv(___nl__9).clone();

//line 215
___nl__9 = null;
//line 215
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 215
___nl__8 = null;
//line 215
___nl__8 = new ImmString("}").clone();
//line 215
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 215
___nl__8 = null;
//line 215
___nl__3 = ___nl__7.clone();
//line 215
___nl__7 = null;
//line 215
___nl__6 = null;
//line 216
if (true) {goto label_1;}
//line 216
label_21:
//line 216
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("goto")).clone();
//line 217
___nl__7 = generator_cs_NL.NL_print_goto_priv(___nl__6).clone();

//line 217
___nl__3 = ___nl__7.clone();
//line 217
___nl__7 = null;
//line 217
___nl__6 = null;
//line 218
if (true) {goto label_1;}
//line 218
label_22:
//line 218
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("clear")).clone();
//line 219
___nl__8 = new ImmString("null").clone();
//line 219
___nl__7 = generator_cs_NL.NL_print_register_setter_priv(___nl__6,___nl__8).clone();

//line 219
___nl__8 = null;
//line 219
___nl__8 = new ImmString(";").clone();
//line 219
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 219
___nl__8 = null;
//line 219
___nl__3 = ___nl__7.clone();
//line 219
___nl__7 = null;
//line 219
___nl__6 = null;
//line 220
if (true) {goto label_1;}
//line 220
label_1:
//line 220
___nl__4 = null;
//line 220
___nl__5 = null;
//line 221
___nl__4 = new ImmString("//line ").clone();
//line 221
___nl__5 = ((ImmHash)___nl__1).getHashValue()["debug"].clone();
//line 221
___nl__5 = ((ImmHash)___nl__5).getHashValue()["nast_debug"].clone();
//line 221
___nl__5 = ((ImmHash)___nl__5).getHashValue()["begin"].clone();
//line 221
___nl__5 = ((ImmHash)___nl__5).getHashValue()["line"].clone();
//line 221
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 221
___nl__5 = null;
//line 221
___nl__5 = string_NL.NL_lf().clone();

//line 221
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 221
___nl__5 = null;
//line 221
___nl__4 = new ImmString(___nl__4.toString() + ___nl__3.toString()).clone();
//line 221
___nl__5 = string_NL.NL_lf().clone();

//line 221
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 221
___nl__5 = null;
//line 221
___nl__0 = null;
//line 221
___nl__1 = null;
//line 221
___nl__2 = null;
//line 221
___nl__3 = null;
//line 221
if(true) return ___nl__4;
//line 221
___nl__4 = null;
//line 221
___nl__3 = null;
//line 221
___nl__0 = null;
//line 221
___nl__1 = null;
//line 221
___nl__2 = null;
//line 221
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
//line 225
___nl__1 = new ImmString("new ImmArray(new Imm[").clone();
//line 226
___nl__2 = array_NL.NL_len(___nl__0).clone();

//line 226
___nl__3 = new ImmDouble(0).clone();
//line 226
___nl__2 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__2.getValue().ToString())) ==((Double.Parse(___nl__3.getValue().ToString())))  ).clone();
//line 226
___nl__3 = null;
//line 226
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 226
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 227
___nl__3 = new ImmString("0]").clone();
//line 227
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 227
___nl__3 = null;
//line 228
if (true) {goto label_1;}
//line 228
label_2:
//line 229
___nl__3 = new ImmString("] {").clone();
//line 229
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 229
___nl__3 = null;
//line 230
___nl__4 = new ImmDouble(0).clone();
//line 230
___nl__5 = new ImmDouble(1).clone();
//line 230
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__0).clone();

//line 230
label_5:
//line 230
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) ).clone();
//line 230
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_3;}}
//line 230
___nl__3 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()].clone();
//line 230
___nl__8 = generator_cs_NL.NL_print_register_priv(___nl__3).clone();

//line 230
___nl__9 = new ImmString(",").clone();
//line 230
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 230
___nl__9 = null;
//line 230
___nl__1 = new ImmString(___nl__1.toString() + ___nl__8.toString()).clone();
//line 230
___nl__8 = null;
//line 230
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 230
if (true) {goto label_5;}
//line 230
label_3:
//line 230
___nl__3 = null;
//line 230
___nl__4 = null;
//line 230
___nl__5 = null;
//line 230
___nl__6 = null;
//line 230
___nl__7 = null;
//line 231
___nl__3 = new ImmString("}").clone();
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
___nl__2 = new ImmString(")").clone();
//line 233
___nl__2 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
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
//line 237
___nl__1 = new ImmString("").clone();
//line 238
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 238
___nl__3 = new ImmString(">=").clone();
//line 238
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 238
___nl__3 = null;
//line 238
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_7;}}
//line 238
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 238
___nl__3 = new ImmString("<=").clone();
//line 238
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 238
___nl__3 = null;
//line 238
label_7:
//line 238
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_6;}}
//line 238
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 238
___nl__3 = new ImmString("<").clone();
//line 238
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 238
___nl__3 = null;
//line 238
label_6:
//line 238
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_5;}}
//line 238
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 238
___nl__3 = new ImmString(">").clone();
//line 238
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 238
___nl__3 = null;
//line 238
label_5:
//line 238
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_4;}}
//line 238
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 238
___nl__3 = new ImmString("==").clone();
//line 238
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 238
___nl__3 = null;
//line 238
label_4:
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
//line 240
___nl__3 = new ImmString("c_rt_lib_NL.NL_native_to_nl(").clone();
//line 240
___nl__4 = generator_cs_NL.NL_print_imm_double_operation_priv(___nl__0).clone();

//line 240
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 240
___nl__4 = null;
//line 240
___nl__4 = new ImmString(" )").clone();
//line 240
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 240
___nl__4 = null;
//line 240
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 240
___nl__3 = null;
//line 241
if (true) {goto label_1;}
//line 241
label_2:
//line 241
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 241
___nl__3 = new ImmString("eq").clone();
//line 241
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 241
___nl__3 = null;
//line 241
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_9;}}
//line 241
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 241
___nl__3 = new ImmString("ne").clone();
//line 241
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 241
___nl__3 = null;
//line 241
label_9:
//line 241
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 241
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_8;}}
//line 242
___nl__3 = new ImmString("c_rt_lib_NL.NL_native_to_nl(").clone();
//line 242
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 242
___nl__3 = null;
//line 243
___nl__3 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 243
___nl__4 = new ImmString("ne").clone();
//line 243
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__4.toString())).clone();
//line 243
___nl__4 = null;
//line 243
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 243
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_11;}}
//line 244
___nl__4 = new ImmString("!").clone();
//line 244
___nl__1 = new ImmString(___nl__1.toString() + ___nl__4.toString()).clone();
//line 244
___nl__4 = null;
//line 245
if (true) {goto label_11;}
//line 245
label_11:
//line 245
___nl__3 = null;
//line 246
___nl__4 = ((ImmHash)___nl__0).getHashValue()["left"].clone();
//line 246
___nl__3 = generator_cs_NL.NL_print_register_priv(___nl__4).clone();

//line 246
___nl__4 = null;
//line 246
___nl__4 = new ImmString(".toString().Equals(").clone();
//line 246
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 246
___nl__4 = null;
//line 246
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 246
___nl__3 = null;
//line 247
___nl__4 = ((ImmHash)___nl__0).getHashValue()["right"].clone();
//line 247
___nl__3 = generator_cs_NL.NL_print_register_priv(___nl__4).clone();

//line 247
___nl__4 = null;
//line 247
___nl__4 = new ImmString(".toString()))").clone();
//line 247
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 247
___nl__4 = null;
//line 247
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 247
___nl__3 = null;
//line 248
if (true) {goto label_1;}
//line 248
label_8:
//line 248
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 248
___nl__3 = new ImmString(".").clone();
//line 248
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 248
___nl__3 = null;
//line 248
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 248
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_12;}}
//line 249
___nl__3 = new ImmString("new ImmString(").clone();
//line 249
___nl__5 = ((ImmHash)___nl__0).getHashValue()["left"].clone();
//line 249
___nl__4 = generator_cs_NL.NL_print_register_priv(___nl__5).clone();

//line 249
___nl__5 = null;
//line 249
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 249
___nl__4 = null;
//line 249
___nl__4 = new ImmString(".toString() + ").clone();
//line 249
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 249
___nl__4 = null;
//line 249
___nl__5 = ((ImmHash)___nl__0).getHashValue()["right"].clone();
//line 249
___nl__4 = generator_cs_NL.NL_print_register_priv(___nl__5).clone();

//line 249
___nl__5 = null;
//line 249
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 249
___nl__4 = null;
//line 249
___nl__4 = new ImmString(".toString())").clone();
//line 249
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 249
___nl__4 = null;
//line 249
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 249
___nl__3 = null;
//line 250
if (true) {goto label_1;}
//line 250
label_12:
//line 251
___nl__3 = new ImmString("new ImmDouble(").clone();
//line 251
___nl__4 = generator_cs_NL.NL_print_imm_double_operation_priv(___nl__0).clone();

//line 251
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 251
___nl__4 = null;
//line 251
___nl__4 = new ImmString(")").clone();
//line 251
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 251
___nl__4 = null;
//line 251
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 251
___nl__3 = null;
//line 252
if (true) {goto label_1;}
//line 252
label_1:
//line 252
___nl__2 = null;
//line 253
___nl__3 = ((ImmHash)___nl__0).getHashValue()["dest"].clone();
//line 253
___nl__2 = generator_cs_NL.NL_print_register_setter_priv(___nl__3,___nl__1).clone();

//line 253
___nl__3 = null;
//line 253
___nl__3 = new ImmString(";").clone();
//line 253
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 253
___nl__3 = null;
//line 253
___nl__0 = null;
//line 253
___nl__1 = null;
//line 253
if(true) return ___nl__2;
//line 253
___nl__2 = null;
//line 253
___nl__1 = null;
//line 253
___nl__0 = null;
//line 253
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
//line 257
___nl__2 = ((ImmHash)___nl__0).getHashValue()["left"].clone();
//line 257
___nl__1 = generator_cs_NL.NL_print_register_as_number_priv(___nl__2).clone();

//line 257
___nl__2 = null;
//line 258
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 258
___nl__3 = new ImmString("==").clone();
//line 258
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 258
___nl__3 = null;
//line 258
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_3;}}
//line 258
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 258
___nl__3 = new ImmString("!=").clone();
//line 258
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 258
___nl__3 = null;
//line 258
label_3:
//line 258
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 258
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 259
___nl__3 = new ImmString(" ").clone();
//line 259
___nl__4 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 259
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 259
___nl__4 = null;
//line 259
___nl__4 = new ImmString("(").clone();
//line 259
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 259
___nl__4 = null;
//line 259
___nl__5 = ((ImmHash)___nl__0).getHashValue()["right"].clone();
//line 259
___nl__4 = generator_cs_NL.NL_print_register_as_number_priv(___nl__5).clone();

//line 259
___nl__5 = null;
//line 259
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 259
___nl__4 = null;
//line 259
___nl__4 = new ImmString(") ").clone();
//line 259
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 259
___nl__4 = null;
//line 259
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 259
___nl__3 = null;
//line 260
if (true) {goto label_1;}
//line 260
label_2:
//line 261
___nl__3 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 261
___nl__5 = ((ImmHash)___nl__0).getHashValue()["right"].clone();
//line 261
___nl__4 = generator_cs_NL.NL_print_register_as_number_priv(___nl__5).clone();

//line 261
___nl__5 = null;
//line 261
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 261
___nl__4 = null;
//line 261
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 261
___nl__3 = null;
//line 262
if (true) {goto label_1;}
//line 262
label_1:
//line 262
___nl__2 = null;
//line 263
___nl__0 = null;
//line 263
if(true) return ___nl__1;
//line 263
___nl__1 = null;
//line 263
___nl__0 = null;
//line 263
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
//line 267
___nl__1 = new ImmString("(Double.Parse(").clone();
//line 267
___nl__2 = generator_cs_NL.NL_print_register_priv(___nl__0).clone();

//line 267
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 267
___nl__2 = null;
//line 267
___nl__2 = generator_cs_NL.NL_print_getter_priv().clone();

//line 267
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 267
___nl__2 = null;
//line 267
___nl__2 = new ImmString(".ToString()))").clone();
//line 267
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 267
___nl__2 = null;
//line 267
___nl__0 = null;
//line 267
if(true) return ___nl__1;
//line 267
___nl__1 = null;
//line 267
___nl__0 = null;
//line 267
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
//line 271
___nl__4 = new ImmString("").clone();
//line 271
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__1.toString().Equals(___nl__4.toString())).clone();
//line 271
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 271
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 271
___nl__5 = new ImmString("_priv").clone();
//line 271
___nl__5 = new ImmString(___nl__2.toString() + ___nl__5.toString()).clone();
//line 271
___nl__2 = ___nl__5.clone();
//line 271
___nl__5 = null;
//line 271
if (true) {goto label_2;}
//line 271
label_2:
//line 271
___nl__4 = null;
//line 272
___nl__4 = new ImmString("").clone();
//line 272
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__1.toString().Equals(___nl__4.toString())).clone();
//line 272
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 272
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_4;}}
//line 272
___nl__1 = ___nl__0.clone();
//line 272
if (true) {goto label_4;}
//line 272
label_4:
//line 272
___nl__4 = null;
//line 273
___nl__4 = generator_cs_NL.NL_get_class_name_priv(___nl__1).clone();

//line 273
___nl__5 = new ImmString(".NL_").clone();
//line 273
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 273
___nl__5 = null;
//line 273
___nl__5 = ___nl__2.clone();
//line 273
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 273
___nl__5 = null;
//line 273
___nl__5 = new ImmString("(").clone();
//line 273
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 273
___nl__5 = null;
//line 274
___nl__5 = new ImmDouble(0).clone();
//line 275
___nl__7 = new ImmDouble(0).clone();
//line 275
___nl__8 = new ImmDouble(1).clone();
//line 275
___nl__9 = c_rt_lib_NL.NL_array_len(___nl__3).clone();

//line 275
label_7:
//line 275
___nl__10 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))>=(Double.Parse(___nl__9.getValue().ToString())) ).clone();
//line 275
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_5;}}
//line 275
___nl__6 = (___nl__3 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()].clone();
//line 276
___nl__11 = new ImmDouble(0).clone();
//line 276
___nl__11 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString())) ==((Double.Parse(___nl__11.getValue().ToString())))  ).clone();
//line 276
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 276
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 276
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_9;}}
//line 276
___nl__12 = new ImmString(",").clone();
//line 276
___nl__4 = new ImmString(___nl__4.toString() + ___nl__12.toString()).clone();
//line 276
___nl__12 = null;
//line 276
if (true) {goto label_9;}
//line 276
label_9:
//line 276
___nl__11 = null;
//line 277
___nl__11 = new ImmDouble(1).clone();
//line 277
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__11.getValue().ToString()))).clone();
//line 277
___nl__11 = null;
//line 278
___nl__11 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("ref")).clone();
//line 278
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_11;}}
//line 280
___nl__11 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("val")).clone();
//line 280
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_12;}}
//line 280
___nl__11 = new ImmString("NOMATCHALERT").clone();
//line 280
___nl__11 = new ImmArray(new Imm[] {___nl__11,___nl__6,}).clone();
//line 280
c_rt_lib_NL.NL_die();
//line 278
label_11:
//line 278
___nl__12 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("ref")).clone();
//line 279
___nl__13 = new ImmString("___ref___").clone();
//line 279
___nl__14 = generator_cs_NL.NL_print_register_priv(___nl__12).clone();

//line 279
___nl__13 = new ImmString(___nl__13.toString() + ___nl__14.toString()).clone();
//line 279
___nl__14 = null;
//line 279
___nl__4 = new ImmString(___nl__4.toString() + ___nl__13.toString()).clone();
//line 279
___nl__13 = null;
//line 279
___nl__12 = null;
//line 280
if (true) {goto label_10;}
//line 280
label_12:
//line 280
___nl__12 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("val")).clone();
//line 281
___nl__13 = generator_cs_NL.NL_print_register_priv(___nl__12).clone();

//line 281
___nl__4 = new ImmString(___nl__4.toString() + ___nl__13.toString()).clone();
//line 281
___nl__13 = null;
//line 281
___nl__12 = null;
//line 282
if (true) {goto label_10;}
//line 282
label_10:
//line 282
___nl__11 = null;
//line 283
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString()))).clone();
//line 283
if (true) {goto label_7;}
//line 283
label_5:
//line 283
___nl__6 = null;
//line 283
___nl__7 = null;
//line 283
___nl__8 = null;
//line 283
___nl__9 = null;
//line 283
___nl__10 = null;
//line 284
___nl__6 = new ImmString(")").clone();
//line 284
___nl__6 = new ImmString(___nl__4.toString() + ___nl__6.toString()).clone();
//line 284
___nl__0 = null;
//line 284
___nl__1 = null;
//line 284
___nl__2 = null;
//line 284
___nl__3 = null;
//line 284
___nl__4 = null;
//line 284
___nl__5 = null;
//line 284
if(true) return ___nl__6;
//line 284
___nl__6 = null;
//line 284
___nl__4 = null;
//line 284
___nl__5 = null;
//line 284
___nl__0 = null;
//line 284
___nl__1 = null;
//line 284
___nl__2 = null;
//line 284
___nl__3 = null;
//line 284
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
//line 288
___nl__1 = new ImmString("").clone();
//line 289
___nl__3 = new ImmDouble(0).clone();
//line 289
___nl__4 = new ImmDouble(1).clone();
//line 289
___nl__5 = c_rt_lib_NL.NL_array_len(___nl__0).clone();

//line 289
label_3:
//line 289
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))>=(Double.Parse(___nl__5.getValue().ToString())) ).clone();
//line 289
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_1;}}
//line 289
___nl__2 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__3).getDoubleValue()].clone();
//line 290
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("ref")).clone();
//line 290
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_5;}}
//line 292
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("val")).clone();
//line 292
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_6;}}
//line 292
___nl__7 = new ImmString("NOMATCHALERT").clone();
//line 292
___nl__7 = new ImmArray(new Imm[] {___nl__7,___nl__2,}).clone();
//line 292
c_rt_lib_NL.NL_die();
//line 290
label_5:
//line 290
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("ref")).clone();
//line 291
___nl__9 = new ImmString("___ref___").clone();
//line 291
___nl__10 = generator_cs_NL.NL_print_register_priv(___nl__8).clone();

//line 291
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 291
___nl__10 = null;
//line 291
___nl__10 = new ImmString(" = new ImmRef(").clone();
//line 291
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 291
___nl__10 = null;
//line 291
___nl__10 = generator_cs_NL.NL_print_register_priv(___nl__8).clone();

//line 291
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 291
___nl__10 = null;
//line 291
___nl__10 = new ImmString(");").clone();
//line 291
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 291
___nl__10 = null;
//line 291
___nl__10 = string_NL.NL_lf().clone();

//line 291
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 291
___nl__10 = null;
//line 291
___nl__1 = new ImmString(___nl__1.toString() + ___nl__9.toString()).clone();
//line 291
___nl__9 = null;
//line 291
___nl__8 = null;
//line 292
if (true) {goto label_4;}
//line 292
label_6:
//line 292
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("val")).clone();
//line 292
___nl__8 = null;
//line 293
if (true) {goto label_4;}
//line 293
label_4:
//line 293
___nl__7 = null;
//line 294
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString()))).clone();
//line 294
if (true) {goto label_3;}
//line 294
label_1:
//line 294
___nl__2 = null;
//line 294
___nl__3 = null;
//line 294
___nl__4 = null;
//line 294
___nl__5 = null;
//line 294
___nl__6 = null;
//line 295
___nl__0 = null;
//line 295
if(true) return ___nl__1;
//line 295
___nl__1 = null;
//line 295
___nl__0 = null;
//line 295
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
//line 299
___nl__1 = new ImmString("").clone();
//line 300
___nl__3 = new ImmDouble(0).clone();
//line 300
___nl__4 = new ImmDouble(1).clone();
//line 300
___nl__5 = c_rt_lib_NL.NL_array_len(___nl__0).clone();

//line 300
label_3:
//line 300
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))>=(Double.Parse(___nl__5.getValue().ToString())) ).clone();
//line 300
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_1;}}
//line 300
___nl__2 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__3).getDoubleValue()].clone();
//line 301
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("ref")).clone();
//line 301
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_5;}}
//line 304
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("val")).clone();
//line 304
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_6;}}
//line 304
___nl__7 = new ImmString("NOMATCHALERT").clone();
//line 304
___nl__7 = new ImmArray(new Imm[] {___nl__7,___nl__2,}).clone();
//line 304
c_rt_lib_NL.NL_die();
//line 301
label_5:
//line 301
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("ref")).clone();
//line 302
___nl__9 = new ImmString("___ref___").clone();
//line 302
___nl__10 = generator_cs_NL.NL_print_register_priv(___nl__8).clone();

//line 302
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 302
___nl__10 = null;
//line 302
___nl__10 = new ImmString(".getValue()").clone();
//line 302
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 302
___nl__10 = null;
//line 303
___nl__10 = generator_cs_NL.NL_print_register_setter_priv(___nl__8,___nl__9).clone();

//line 303
___nl__11 = new ImmString(";").clone();
//line 303
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString()).clone();
//line 303
___nl__11 = null;
//line 303
___nl__11 = string_NL.NL_lf().clone();

//line 303
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString()).clone();
//line 303
___nl__11 = null;
//line 303
___nl__1 = new ImmString(___nl__1.toString() + ___nl__10.toString()).clone();
//line 303
___nl__10 = null;
//line 303
___nl__9 = null;
//line 303
___nl__8 = null;
//line 304
if (true) {goto label_4;}
//line 304
label_6:
//line 304
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("val")).clone();
//line 304
___nl__8 = null;
//line 305
if (true) {goto label_4;}
//line 305
label_4:
//line 305
___nl__7 = null;
//line 306
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString()))).clone();
//line 306
if (true) {goto label_3;}
//line 306
label_1:
//line 306
___nl__2 = null;
//line 306
___nl__3 = null;
//line 306
___nl__4 = null;
//line 306
___nl__5 = null;
//line 306
___nl__6 = null;
//line 307
___nl__0 = null;
//line 307
if(true) return ___nl__1;
//line 307
___nl__1 = null;
//line 307
___nl__0 = null;
//line 307
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
//line 311
___nl__2 = new ImmString("new Imm[] {").clone();
//line 312
___nl__4 = new ImmDouble(0).clone();
//line 312
___nl__5 = new ImmDouble(1).clone();
//line 312
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__1).clone();

//line 312
label_3:
//line 312
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) ).clone();
//line 312
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_1;}}
//line 312
___nl__3 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()].clone();
//line 312
___nl__8 = generator_cs_NL.NL_print_const_value_priv(___nl__0,___nl__3).clone();

//line 312
___nl__9 = new ImmString(",").clone();
//line 312
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 312
___nl__9 = null;
//line 312
___nl__2 = new ImmString(___nl__2.toString() + ___nl__8.toString()).clone();
//line 312
___nl__8 = null;
//line 312
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 312
if (true) {goto label_3;}
//line 312
label_1:
//line 312
___nl__3 = null;
//line 312
___nl__4 = null;
//line 312
___nl__5 = null;
//line 312
___nl__6 = null;
//line 312
___nl__7 = null;
//line 313
___nl__3 = new ImmString("}").clone();
//line 313
___nl__3 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 313
___nl__0 = null;
//line 313
___nl__1 = null;
//line 313
___nl__2 = null;
//line 313
if(true) return ___nl__3;
//line 313
___nl__3 = null;
//line 313
___nl__2 = null;
//line 313
___nl__0 = null;
//line 313
___nl__1 = null;
//line 313
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
//line 317
___nl__2 = generator_cs_NL.NL_print_hash_name_priv().clone();

//line 317
___nl__3 = new ImmString(" = new Dictionary<String, Imm>();").clone();
//line 317
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 317
___nl__3 = null;
//line 317
___nl__3 = string_NL.NL_lf().clone();

//line 317
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 317
___nl__3 = null;
//line 318
___nl__5 = c_rt_lib_NL.NL_init_iter(___nl__1).clone();

//line 318
label_3:
//line 318
___nl__3 = c_rt_lib_NL.NL_is_end_hash(___nl__5).clone();

//line 318
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_1;}}
//line 318
___nl__3 = c_rt_lib_NL.NL_get_key_iter(___nl__5).clone();

//line 318
___nl__4 = c_rt_lib_NL.NL_hash_get_value(___nl__1,___nl__3).clone();

//line 318
___nl__6 = generator_cs_NL.NL_print_hash_name_priv().clone();

//line 318
___nl__7 = new ImmString(".Add(\"").clone();
//line 318
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 318
___nl__7 = null;
//line 318
___nl__7 = generator_cs_NL.NL_escape_string_priv(___nl__3).clone();

//line 318
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 318
___nl__7 = null;
//line 318
___nl__7 = new ImmString("\",").clone();
//line 318
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 318
___nl__7 = null;
//line 318
___nl__7 = generator_cs_NL.NL_print_const_value_priv(___nl__0,___nl__4).clone();

//line 318
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 318
___nl__7 = null;
//line 318
___nl__7 = new ImmString(");").clone();
//line 318
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 318
___nl__7 = null;
//line 318
___nl__7 = string_NL.NL_lf().clone();

//line 318
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 318
___nl__7 = null;
//line 318
___nl__2 = new ImmString(___nl__2.toString() + ___nl__6.toString()).clone();
//line 318
___nl__6 = null;
//line 318
___nl__5 = c_rt_lib_NL.NL_next_iter(___nl__5).clone();

//line 318
if (true) {goto label_3;}
//line 318
label_1:
//line 318
___nl__3 = null;
//line 318
___nl__4 = null;
//line 318
___nl__5 = null;
//line 319
___nl__4 = new ImmString("new ImmHash(").clone();
//line 319
___nl__5 = generator_cs_NL.NL_print_hash_name_priv().clone();

//line 319
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 319
___nl__5 = null;
//line 319
___nl__5 = new ImmString(")").clone();
//line 319
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 319
___nl__5 = null;
//line 319
___nl__3 = generator_cs_NL.NL_print_register_setter_priv(___nl__0,___nl__4).clone();

//line 319
___nl__4 = null;
//line 319
___nl__3 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 319
___nl__0 = null;
//line 319
___nl__1 = null;
//line 319
___nl__2 = null;
//line 319
if(true) return ___nl__3;
//line 319
___nl__3 = null;
//line 319
___nl__2 = null;
//line 319
___nl__0 = null;
//line 319
___nl__1 = null;
//line 319
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
//line 323
___nl__2 = new ImmString("").clone();
//line 324
___nl__3 = ov_NL.NL_has_value(___nl__1).clone();

//line 324
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 324
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 325
___nl__4 = new ImmString("new OV(\"").clone();
//line 325
___nl__6 = ov_NL.NL_get_element(___nl__1).clone();

//line 325
___nl__5 = generator_cs_NL.NL_escape_string_priv(___nl__6).clone();

//line 325
___nl__6 = null;
//line 325
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 325
___nl__5 = null;
//line 325
___nl__5 = new ImmString("\", ").clone();
//line 325
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 325
___nl__5 = null;
//line 325
___nl__6 = ov_NL.NL_get_value(___nl__1).clone();

//line 325
___nl__5 = generator_cs_NL.NL_print_const_value_priv(___nl__0,___nl__6).clone();

//line 325
___nl__6 = null;
//line 325
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 325
___nl__5 = null;
//line 325
___nl__5 = new ImmString(")").clone();
//line 325
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 325
___nl__5 = null;
//line 325
___nl__2 = ___nl__4.clone();
//line 325
___nl__4 = null;
//line 326
if (true) {goto label_1;}
//line 326
label_2:
//line 327
___nl__4 = new ImmString("new OV(\"").clone();
//line 327
___nl__6 = ov_NL.NL_get_element(___nl__1).clone();

//line 327
___nl__5 = generator_cs_NL.NL_escape_string_priv(___nl__6).clone();

//line 327
___nl__6 = null;
//line 327
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 327
___nl__5 = null;
//line 327
___nl__5 = new ImmString("\", null)").clone();
//line 327
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 327
___nl__5 = null;
//line 327
___nl__2 = ___nl__4.clone();
//line 327
___nl__4 = null;
//line 328
if (true) {goto label_1;}
//line 328
label_1:
//line 328
___nl__3 = null;
//line 329
___nl__0 = null;
//line 329
___nl__1 = null;
//line 329
if(true) return ___nl__2;
//line 329
___nl__2 = null;
//line 329
___nl__0 = null;
//line 329
___nl__1 = null;
//line 329
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
//line 333
___nl__2 = nl_NL.NL_is_sim(___nl__1).clone();

//line 333
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 333
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_4;}}
//line 333
___nl__5 = ptd_NL.NL_sim().clone();

//line 333
___nl__4 = ptd_NL.NL_ensure(___nl__5,___nl__1).clone();

//line 333
___nl__5 = null;
//line 333
___nl__2 = string_utils_NL.NL_is_integer(___nl__4).clone();

//line 333
___nl__4 = null;
//line 333
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_4;}}
//line 333
___nl__5 = ptd_NL.NL_sim().clone();

//line 333
___nl__4 = ptd_NL.NL_ensure(___nl__5,___nl__1).clone();

//line 333
___nl__5 = null;
//line 333
___nl__2 = string_utils_NL.NL_is_float(___nl__4).clone();

//line 333
___nl__4 = null;
//line 333
label_4:
//line 333
___nl__3 = null;
//line 333
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 333
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 335
___nl__3 = new ImmString("new ImmDouble(").clone();
//line 335
___nl__3 = new ImmString(___nl__3.toString() + ___nl__1.toString()).clone();
//line 335
___nl__4 = new ImmString(")").clone();
//line 335
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
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
label_2:
//line 336
___nl__2 = nl_NL.NL_is_sim(___nl__1).clone();

//line 336
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 336
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_5;}}
//line 337
___nl__3 = new ImmString("new ImmString(\"").clone();
//line 337
___nl__4 = generator_cs_NL.NL_escape_string_priv(___nl__1).clone();

//line 337
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 337
___nl__4 = null;
//line 337
___nl__4 = new ImmString("\")").clone();
//line 337
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 337
___nl__4 = null;
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
label_5:
//line 338
___nl__2 = nl_NL.NL_is_array(___nl__1).clone();

//line 338
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 338
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_6;}}
//line 339
___nl__3 = generator_cs_NL.NL_print_const_arr_priv(___nl__0,___nl__1).clone();

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
label_6:
//line 340
___nl__2 = nl_NL.NL_is_hash(___nl__1).clone();

//line 340
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 340
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_7;}}
//line 341
___nl__3 = generator_cs_NL.NL_print_const_hash_priv(___nl__0,___nl__1).clone();

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
label_7:
//line 342
___nl__2 = nl_NL.NL_is_variant(___nl__1).clone();

//line 342
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 342
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_8;}}
//line 343
___nl__3 = generator_cs_NL.NL_print_const_ov_priv(___nl__0,___nl__1).clone();

//line 343
___nl__0 = null;
//line 343
___nl__1 = null;
//line 343
___nl__2 = null;
//line 343
if(true) return ___nl__3;
//line 343
___nl__3 = null;
//line 344
if (true) {goto label_1;}
//line 344
label_8:
//line 345
___nl__3 = new ImmArray(new Imm[0]).clone();
//line 345
c_rt_lib_NL.NL_die();
//line 345
___nl__3 = null;
//line 346
if (true) {goto label_1;}
//line 346
label_1:
//line 346
___nl__2 = null;
//line 346
___nl__0 = null;
//line 346
___nl__1 = null;
//line 346
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
//line 350
___nl__1 = new ImmString("if (true) {goto ").clone();
//line 350
___nl__1 = new ImmString(___nl__1.toString() + ___nl__0.toString()).clone();
//line 350
___nl__2 = new ImmString(";}").clone();
//line 350
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 350
___nl__2 = null;
//line 350
___nl__0 = null;
//line 350
if(true) return ___nl__1;
//line 350
___nl__1 = null;
//line 350
___nl__0 = null;
//line 350
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
//line 354
___nl__1 = generator_cs_NL.NL_print_hash_name_priv().clone();

//line 354
___nl__2 = new ImmString(" = new Dictionary<String, Imm>();").clone();
//line 354
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 354
___nl__2 = null;
//line 354
___nl__2 = string_NL.NL_lf().clone();

//line 354
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 354
___nl__2 = null;
//line 355
___nl__2 = ((ImmHash)___nl__0).getHashValue()["src"].clone();
//line 355
___nl__4 = new ImmDouble(0).clone();
//line 355
___nl__5 = new ImmDouble(1).clone();
//line 355
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__2).clone();

//line 355
label_3:
//line 355
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) ).clone();
//line 355
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_1;}}
//line 355
___nl__3 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()].clone();
//line 355
___nl__8 = generator_cs_NL.NL_print_hash_name_priv().clone();

//line 355
___nl__9 = new ImmString(".Add(\"").clone();
//line 355
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 355
___nl__9 = null;
//line 355
___nl__10 = ((ImmHash)___nl__3).getHashValue()["key"].clone();
//line 355
___nl__9 = generator_cs_NL.NL_escape_string_priv(___nl__10).clone();

//line 355
___nl__10 = null;
//line 355
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 355
___nl__9 = null;
//line 355
___nl__9 = new ImmString("\",").clone();
//line 355
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 355
___nl__9 = null;
//line 355
___nl__10 = ((ImmHash)___nl__3).getHashValue()["val"].clone();
//line 355
___nl__9 = generator_cs_NL.NL_print_register_priv(___nl__10).clone();

//line 355
___nl__10 = null;
//line 355
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 355
___nl__9 = null;
//line 355
___nl__9 = new ImmString(");").clone();
//line 355
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 355
___nl__9 = null;
//line 355
___nl__9 = string_NL.NL_lf().clone();

//line 355
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 355
___nl__9 = null;
//line 355
___nl__1 = new ImmString(___nl__1.toString() + ___nl__8.toString()).clone();
//line 355
___nl__8 = null;
//line 355
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 355
if (true) {goto label_3;}
//line 355
label_1:
//line 355
___nl__2 = null;
//line 355
___nl__3 = null;
//line 355
___nl__4 = null;
//line 355
___nl__5 = null;
//line 355
___nl__6 = null;
//line 355
___nl__7 = null;
//line 356
___nl__0 = null;
//line 356
if(true) return ___nl__1;
//line 356
___nl__1 = null;
//line 356
___nl__0 = null;
//line 356
if(true) return null;
}

private static Imm NL_SINGLETON_print_hash_name_priv() {

Imm ___nl__0 = null;
ImmRef ___ref______nl__0 = null;
Dictionary<String, Imm> __function_map;
//line 360
___nl__0 = new ImmString("__function_map").clone();
//line 360
if(true) return ___nl__0;
//line 360
___nl__0 = null;
//line 360
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
//line 364
___nl__1 = new ImmString("((ImmHash)").clone();
//line 364
___nl__3 = ((ImmHash)___nl__0).getHashValue()["src"].clone();
//line 364
___nl__2 = generator_cs_NL.NL_print_register_priv(___nl__3).clone();

//line 364
___nl__3 = null;
//line 364
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 364
___nl__2 = null;
//line 364
___nl__2 = new ImmString(").getHashValue()[\"").clone();
//line 364
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 364
___nl__2 = null;
//line 364
___nl__3 = ((ImmHash)___nl__0).getHashValue()["key"].clone();
//line 364
___nl__2 = generator_cs_NL.NL_escape_string_priv(___nl__3).clone();

//line 364
___nl__3 = null;
//line 364
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 364
___nl__2 = null;
//line 364
___nl__2 = new ImmString("\"]").clone();
//line 364
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 364
___nl__2 = null;
//line 364
___nl__0 = null;
//line 364
if(true) return ___nl__1;
//line 364
___nl__1 = null;
//line 364
___nl__0 = null;
//line 364
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
//line 368
___nl__1 = new ImmString("((ImmHash)").clone();
//line 368
___nl__3 = ((ImmHash)___nl__0).getHashValue()["src"].clone();
//line 368
___nl__2 = generator_cs_NL.NL_print_register_priv(___nl__3).clone();

//line 368
___nl__3 = null;
//line 368
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 368
___nl__2 = null;
//line 368
___nl__2 = new ImmString(").set(\"").clone();
//line 368
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 368
___nl__2 = null;
//line 368
___nl__3 = ((ImmHash)___nl__0).getHashValue()["key"].clone();
//line 368
___nl__2 = generator_cs_NL.NL_escape_string_priv(___nl__3).clone();

//line 368
___nl__3 = null;
//line 368
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 368
___nl__2 = null;
//line 368
___nl__2 = new ImmString("\", ").clone();
//line 368
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 368
___nl__2 = null;
//line 369
___nl__3 = ((ImmHash)___nl__0).getHashValue()["val"].clone();
//line 369
___nl__2 = generator_cs_NL.NL_print_register_priv(___nl__3).clone();

//line 369
___nl__3 = null;
//line 369
___nl__3 = new ImmString(")").clone();
//line 369
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 369
___nl__3 = null;
//line 369
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 369
___nl__2 = null;
//line 370
___nl__0 = null;
//line 370
if(true) return ___nl__1;
//line 370
___nl__1 = null;
//line 370
___nl__0 = null;
//line 370
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
//line 374
___nl__1 = new ImmString("").clone();
//line 375
___nl__2 = ((ImmHash)___nl__0).getHashValue()["src"].clone();
//line 375
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("emp")).clone();
//line 375
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 375
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 375
___nl__2 = ((ImmHash)___nl__0).getHashValue()["name"].clone();
//line 375
___nl__4 = new ImmString("TRUE").clone();
//line 375
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__4.toString())).clone();
//line 375
___nl__4 = null;
//line 375
label_3:
//line 375
___nl__3 = null;
//line 375
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 375
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 376
___nl__3 = new ImmString("c_rt_lib_NL.NL_get_true()").clone();
//line 376
___nl__1 = ___nl__3.clone();
//line 376
___nl__3 = null;
//line 377
if (true) {goto label_1;}
//line 377
label_2:
//line 377
___nl__2 = ((ImmHash)___nl__0).getHashValue()["src"].clone();
//line 377
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("emp")).clone();
//line 377
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 377
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_5;}}
//line 377
___nl__2 = ((ImmHash)___nl__0).getHashValue()["name"].clone();
//line 377
___nl__4 = new ImmString("FALSE").clone();
//line 377
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__4.toString())).clone();
//line 377
___nl__4 = null;
//line 377
label_5:
//line 377
___nl__3 = null;
//line 377
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 377
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_4;}}
//line 378
___nl__3 = new ImmString("c_rt_lib_NL.NL_get_false()").clone();
//line 378
___nl__1 = ___nl__3.clone();
//line 378
___nl__3 = null;
//line 379
if (true) {goto label_1;}
//line 379
label_4:
//line 380
___nl__3 = ((ImmHash)___nl__0).getHashValue()["src"].clone();
//line 380
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("arg")).clone();
//line 380
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_7;}}
//line 382
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("emp")).clone();
//line 382
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_8;}}
//line 382
___nl__4 = new ImmString("NOMATCHALERT").clone();
//line 382
___nl__4 = new ImmArray(new Imm[] {___nl__4,___nl__3,}).clone();
//line 382
c_rt_lib_NL.NL_die();
//line 380
label_7:
//line 380
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("arg")).clone();
//line 381
___nl__6 = new ImmString("c_rt_lib_NL.NL_ov_mk_arg(new ImmString(\"").clone();
//line 381
___nl__8 = ((ImmHash)___nl__0).getHashValue()["name"].clone();
//line 381
___nl__7 = generator_cs_NL.NL_escape_string_priv(___nl__8).clone();

//line 381
___nl__8 = null;
//line 381
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 381
___nl__7 = null;
//line 381
___nl__7 = new ImmString("\"), ").clone();
//line 381
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 381
___nl__7 = null;
//line 381
___nl__7 = generator_cs_NL.NL_print_register_priv(___nl__5).clone();

//line 381
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 381
___nl__7 = null;
//line 381
___nl__7 = new ImmString(")").clone();
//line 381
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 381
___nl__7 = null;
//line 381
___nl__1 = ___nl__6.clone();
//line 381
___nl__6 = null;
//line 381
___nl__5 = null;
//line 382
if (true) {goto label_6;}
//line 382
label_8:
//line 383
___nl__5 = new ImmString("c_rt_lib_NL.NL_ov_mk_none(new ImmString(\"").clone();
//line 383
___nl__7 = ((ImmHash)___nl__0).getHashValue()["name"].clone();
//line 383
___nl__6 = generator_cs_NL.NL_escape_string_priv(___nl__7).clone();

//line 383
___nl__7 = null;
//line 383
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 383
___nl__6 = null;
//line 383
___nl__6 = new ImmString("\"))").clone();
//line 383
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 383
___nl__6 = null;
//line 383
___nl__1 = ___nl__5.clone();
//line 383
___nl__5 = null;
//line 384
if (true) {goto label_6;}
//line 384
label_6:
//line 384
___nl__3 = null;
//line 384
___nl__4 = null;
//line 385
if (true) {goto label_1;}
//line 385
label_1:
//line 385
___nl__2 = null;
//line 386
___nl__3 = ((ImmHash)___nl__0).getHashValue()["dest"].clone();
//line 386
___nl__2 = generator_cs_NL.NL_print_register_setter_priv(___nl__3,___nl__1).clone();

//line 386
___nl__3 = null;
//line 386
___nl__3 = new ImmString(";").clone();
//line 386
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 386
___nl__3 = null;
//line 386
___nl__0 = null;
//line 386
___nl__1 = null;
//line 386
if(true) return ___nl__2;
//line 386
___nl__2 = null;
//line 386
___nl__1 = null;
//line 386
___nl__0 = null;
//line 386
if(true) return null;
}

private static Imm NL_print_register_priv(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 390
___nl__1 = new ImmString("___nl__").clone();
//line 390
___nl__1 = new ImmString(___nl__1.toString() + ___nl__0.toString()).clone();
//line 390
___nl__0 = null;
//line 390
if(true) return ___nl__1;
//line 390
___nl__1 = null;
//line 390
___nl__0 = null;
//line 390
if(true) return null;
}

private static Imm NL_SINGLETON_print_getter_priv() {

Imm ___nl__0 = null;
ImmRef ___ref______nl__0 = null;
Dictionary<String, Imm> __function_map;
//line 394
___nl__0 = new ImmString(".getValue()").clone();
//line 394
if(true) return ___nl__0;
//line 394
___nl__0 = null;
//line 394
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
Imm ___nl__4 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 398
___nl__2 = new ImmString("").clone();
//line 398
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__2.toString())).clone();
//line 398
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 398
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 398
___nl__3 = new ImmString("").clone();
//line 398
___nl__3 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 398
___nl__0 = null;
//line 398
___nl__1 = null;
//line 398
___nl__2 = null;
//line 398
if(true) return ___nl__3;
//line 398
___nl__3 = null;
//line 398
if (true) {goto label_2;}
//line 398
label_2:
//line 398
___nl__2 = null;
//line 399
___nl__2 = new ImmString("null").clone();
//line 399
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__1.toString().Equals(___nl__2.toString())).clone();
//line 399
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 399
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_4;}}
//line 399
___nl__3 = generator_cs_NL.NL_print_register_priv(___nl__0).clone();

//line 399
___nl__4 = new ImmString(" = ").clone();
//line 399
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 399
___nl__4 = null;
//line 399
___nl__3 = new ImmString(___nl__3.toString() + ___nl__1.toString()).clone();
//line 399
___nl__0 = null;
//line 399
___nl__1 = null;
//line 399
___nl__2 = null;
//line 399
if(true) return ___nl__3;
//line 399
___nl__3 = null;
//line 399
if (true) {goto label_4;}
//line 399
label_4:
//line 399
___nl__2 = null;
//line 400
___nl__2 = generator_cs_NL.NL_print_register_priv(___nl__0).clone();

//line 400
___nl__3 = new ImmString(" = ").clone();
//line 400
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 400
___nl__3 = null;
//line 400
___nl__2 = new ImmString(___nl__2.toString() + ___nl__1.toString()).clone();
//line 400
___nl__3 = new ImmString(".clone()").clone();
//line 400
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 400
___nl__3 = null;
//line 400
___nl__0 = null;
//line 400
___nl__1 = null;
//line 400
if(true) return ___nl__2;
//line 400
___nl__2 = null;
//line 400
___nl__0 = null;
//line 400
___nl__1 = null;
//line 400
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
//line 404
___nl__1 = new ImmString("").clone();
//line 405
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("val")).clone();
//line 405
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 407
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("emp")).clone();
//line 407
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_3;}}
//line 407
___nl__2 = new ImmString("NOMATCHALERT").clone();
//line 407
___nl__2 = new ImmArray(new Imm[] {___nl__2,___nl__0,}).clone();
//line 407
c_rt_lib_NL.NL_die();
//line 405
label_2:
//line 405
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("val")).clone();
//line 406
___nl__4 = new ImmString("return ").clone();
//line 406
___nl__5 = generator_cs_NL.NL_print_register_priv(___nl__3).clone();

//line 406
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 406
___nl__5 = null;
//line 406
___nl__5 = new ImmString(";").clone();
//line 406
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 406
___nl__5 = null;
//line 406
___nl__1 = ___nl__4.clone();
//line 406
___nl__4 = null;
//line 406
___nl__3 = null;
//line 407
if (true) {goto label_1;}
//line 407
label_3:
//line 408
___nl__3 = new ImmString("return null;").clone();
//line 408
___nl__1 = ___nl__3.clone();
//line 408
___nl__3 = null;
//line 409
if (true) {goto label_1;}
//line 409
label_1:
//line 409
___nl__2 = null;
//line 410
___nl__2 = new ImmString("if(true) ").clone();
//line 410
___nl__2 = new ImmString(___nl__2.toString() + ___nl__1.toString()).clone();
//line 410
___nl__0 = null;
//line 410
___nl__1 = null;
//line 410
if(true) return ___nl__2;
//line 410
___nl__2 = null;
//line 410
___nl__1 = null;
//line 410
___nl__0 = null;
//line 410
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
//line 414
___nl__1 = new ImmString("").clone();
//line 415
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 415
___nl__3 = new ImmString("!").clone();
//line 415
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 415
___nl__3 = null;
//line 415
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 415
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 416
___nl__3 = new ImmString("c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(").clone();
//line 416
___nl__5 = ((ImmHash)___nl__0).getHashValue()["src"].clone();
//line 416
___nl__4 = generator_cs_NL.NL_print_register_priv(___nl__5).clone();

//line 416
___nl__5 = null;
//line 416
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 416
___nl__4 = null;
//line 416
___nl__4 = new ImmString("))").clone();
//line 416
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 416
___nl__4 = null;
//line 416
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 416
___nl__3 = null;
//line 417
if (true) {goto label_1;}
//line 417
label_2:
//line 418
___nl__3 = new ImmString("new ImmDouble(").clone();
//line 418
___nl__4 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 418
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 418
___nl__4 = null;
//line 418
___nl__4 = new ImmString("((ImmDouble)").clone();
//line 418
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 418
___nl__4 = null;
//line 418
___nl__5 = ((ImmHash)___nl__0).getHashValue()["src"].clone();
//line 418
___nl__4 = generator_cs_NL.NL_print_register_priv(___nl__5).clone();

//line 418
___nl__5 = null;
//line 418
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 418
___nl__4 = null;
//line 418
___nl__4 = new ImmString(").getDoubleValue())").clone();
//line 418
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 418
___nl__4 = null;
//line 418
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 418
___nl__3 = null;
//line 419
if (true) {goto label_1;}
//line 419
label_1:
//line 419
___nl__2 = null;
//line 420
___nl__3 = ((ImmHash)___nl__0).getHashValue()["dest"].clone();
//line 420
___nl__2 = generator_cs_NL.NL_print_register_setter_priv(___nl__3,___nl__1).clone();

//line 420
___nl__3 = null;
//line 420
___nl__3 = new ImmString(";").clone();
//line 420
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 420
___nl__3 = null;
//line 420
___nl__0 = null;
//line 420
___nl__1 = null;
//line 420
if(true) return ___nl__2;
//line 420
___nl__2 = null;
//line 420
___nl__1 = null;
//line 420
___nl__0 = null;
//line 420
if(true) return null;
}

}
}