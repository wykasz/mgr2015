using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class generator_cs_NL {

public static Imm NL_generate(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
Imm ___nl__9 = null;
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
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
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
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
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
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
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
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
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
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
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
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
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
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
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
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
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
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);
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
___nl__9 = new ImmString("ref Imm ___arg__").clone();
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
//line 144
___nl__8 = c_rt_lib_NL.NL_ov_is(___nl__7, new ImmString("ref")).clone();
//line 144
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_14;}}
//line 144
___nl__8 = new ImmString("NOMATCHALERT").clone();
//line 144
___nl__8 = new ImmArray(new Imm[] {___nl__8,___nl__7,}).clone();
//line 144
c_rt_lib_NL.NL_die();
//line 141
label_13:
//line 142
___nl__9 = new ImmString("Imm ___nl__").clone();
//line 142
___nl__9 = new ImmString(___nl__9.toString() + ___nl__4.toString()).clone();
//line 142
___nl__10 = new ImmString(" = null;").clone();
//line 142
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 142
___nl__10 = null;
//line 142
___nl__2 = new ImmString(___nl__2.toString() + ___nl__9.toString()).clone();
//line 142
___nl__9 = null;
//line 143
___nl__9 = new ImmString("c_rt_lib_NL.NL_copy(ref ___nl__").clone();
//line 143
___nl__9 = new ImmString(___nl__9.toString() + ___nl__4.toString()).clone();
//line 143
___nl__10 = new ImmString(", ___arg__").clone();
//line 143
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 143
___nl__10 = null;
//line 143
___nl__9 = new ImmString(___nl__9.toString() + ___nl__4.toString()).clone();
//line 143
___nl__10 = new ImmString(");").clone();
//line 143
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 143
___nl__10 = null;
//line 143
___nl__2 = new ImmString(___nl__2.toString() + ___nl__9.toString()).clone();
//line 143
___nl__9 = null;
//line 144
if (true) {goto label_12;}
//line 144
label_14:
//line 145
___nl__9 = new ImmString("Imm ___nl__").clone();
//line 145
___nl__9 = new ImmString(___nl__9.toString() + ___nl__4.toString()).clone();
//line 145
___nl__10 = new ImmString(" = ___arg__").clone();
//line 145
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 145
___nl__10 = null;
//line 145
___nl__9 = new ImmString(___nl__9.toString() + ___nl__4.toString()).clone();
//line 145
___nl__10 = new ImmString(";").clone();
//line 145
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 145
___nl__10 = null;
//line 145
___nl__2 = new ImmString(___nl__2.toString() + ___nl__9.toString()).clone();
//line 145
___nl__9 = null;
//line 146
if (true) {goto label_12;}
//line 146
label_12:
//line 146
___nl__7 = null;
//line 146
___nl__8 = null;
//line 147
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 147
if (true) {goto label_11;}
//line 147
label_9:
//line 147
___nl__3 = null;
//line 147
___nl__4 = null;
//line 147
___nl__5 = null;
//line 147
___nl__6 = null;
//line 148
___nl__3 = string_NL.NL_lf().clone();

//line 148
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 148
___nl__3 = null;
//line 149
___nl__4 = ((ImmHash)___nl__0).getHashValue()["args_type"].clone();
//line 149
___nl__3 = array_NL.NL_len(___nl__4).clone();

//line 149
___nl__4 = null;
//line 149
label_16:
//line 149
___nl__4 = ((ImmHash)___nl__0).getHashValue()["reg_size"].clone();
//line 149
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))<(Double.Parse(___nl__4.getValue().ToString())) ).clone();
//line 149
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 149
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_15;}}
//line 150
___nl__5 = new ImmString("Imm ___nl__").clone();
//line 150
___nl__5 = new ImmString(___nl__5.toString() + ___nl__3.toString()).clone();
//line 150
___nl__6 = new ImmString(" = null;").clone();
//line 150
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 150
___nl__6 = null;
//line 150
___nl__6 = string_NL.NL_lf().clone();

//line 150
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 150
___nl__6 = null;
//line 150
___nl__2 = new ImmString(___nl__2.toString() + ___nl__5.toString()).clone();
//line 150
___nl__5 = null;
//line 150
___nl__5 = new ImmDouble(1).clone();
//line 150
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 150
___nl__5 = null;
//line 151
if (true) {goto label_16;}
//line 151
label_15:
//line 151
___nl__3 = null;
//line 151
___nl__4 = null;
//line 155
___nl__3 = new ImmString("Dictionary<String, Imm> ").clone();
//line 155
___nl__4 = generator_cs_NL.NL_print_hash_name_priv().clone();

//line 155
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 155
___nl__4 = null;
//line 155
___nl__4 = new ImmString(";").clone();
//line 155
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 155
___nl__4 = null;
//line 155
___nl__4 = string_NL.NL_lf().clone();

//line 155
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 155
___nl__4 = null;
//line 155
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 155
___nl__3 = null;
//line 157
___nl__3 = new ImmString("").clone();
//line 158
___nl__5 = ((ImmHash)___nl__0).getHashValue()["args_type"].clone();
//line 158
___nl__4 = array_NL.NL_len(___nl__5).clone();

//line 158
___nl__5 = null;
//line 158
___nl__5 = new ImmDouble(0).clone();
//line 158
___nl__6 = new ImmDouble(1).clone();
//line 158
label_20:
//line 158
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__4.getValue().ToString())) ).clone();
//line 158
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_18;}}
//line 159
___nl__8 = ((ImmHash)___nl__0).getHashValue()["args_type"].clone();
//line 159
___nl__8 = (___nl__8 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()].clone();
//line 159
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("val")).clone();
//line 159
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_22;}}
//line 160
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__8, new ImmString("ref")).clone();
//line 160
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_23;}}
//line 160
___nl__9 = new ImmString("NOMATCHALERT").clone();
//line 160
___nl__9 = new ImmArray(new Imm[] {___nl__9,___nl__8,}).clone();
//line 160
c_rt_lib_NL.NL_die();
//line 159
label_22:
//line 160
if (true) {goto label_21;}
//line 160
label_23:
//line 161
___nl__10 = new ImmString("___arg__").clone();
//line 161
___nl__10 = new ImmString(___nl__10.toString() + ___nl__5.toString()).clone();
//line 161
___nl__11 = new ImmString(" = ___nl__").clone();
//line 161
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString()).clone();
//line 161
___nl__11 = null;
//line 161
___nl__10 = new ImmString(___nl__10.toString() + ___nl__5.toString()).clone();
//line 161
___nl__11 = new ImmString(";").clone();
//line 161
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString()).clone();
//line 161
___nl__11 = null;
//line 161
___nl__3 = new ImmString(___nl__3.toString() + ___nl__10.toString()).clone();
//line 161
___nl__10 = null;
//line 162
if (true) {goto label_21;}
//line 162
label_21:
//line 162
___nl__8 = null;
//line 162
___nl__9 = null;
//line 163
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString()))).clone();
//line 163
if (true) {goto label_20;}
//line 163
label_18:
//line 163
___nl__4 = null;
//line 163
___nl__5 = null;
//line 163
___nl__6 = null;
//line 163
___nl__7 = null;
//line 165
___nl__4 = ((ImmHash)___nl__0).getHashValue()["commands"].clone();
//line 165
___nl__6 = new ImmDouble(0).clone();
//line 165
___nl__7 = new ImmDouble(1).clone();
//line 165
___nl__8 = c_rt_lib_NL.NL_array_len(___nl__4).clone();

//line 165
label_26:
//line 165
___nl__9 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__6.getValue().ToString()))>=(Double.Parse(___nl__8.getValue().ToString())) ).clone();
//line 165
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_24;}}
//line 165
___nl__5 = (___nl__4 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()].clone();
//line 165
___nl__10 = generator_cs_NL.NL_print_command_priv(___nl__1,___nl__5,___nl__3).clone();

//line 165
___nl__2 = new ImmString(___nl__2.toString() + ___nl__10.toString()).clone();
//line 165
___nl__10 = null;
//line 165
___nl__6 = new ImmDouble((Double.Parse(___nl__6.getValue().ToString()))+(Double.Parse(___nl__7.getValue().ToString()))).clone();
//line 165
if (true) {goto label_26;}
//line 165
label_24:
//line 165
___nl__4 = null;
//line 165
___nl__5 = null;
//line 165
___nl__6 = null;
//line 165
___nl__7 = null;
//line 165
___nl__8 = null;
//line 165
___nl__9 = null;
//line 167
___nl__4 = new ImmString("}").clone();
//line 167
___nl__4 = new ImmString(___nl__2.toString() + ___nl__4.toString()).clone();
//line 167
___nl__5 = string_NL.NL_lf().clone();

//line 167
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 167
___nl__5 = null;
//line 167
___nl__0 = null;
//line 167
___nl__1 = null;
//line 167
___nl__2 = null;
//line 167
___nl__3 = null;
//line 167
if(true) return ___nl__4;
//line 167
___nl__4 = null;
//line 167
___nl__2 = null;
//line 167
___nl__3 = null;
//line 167
___nl__0 = null;
//line 167
___nl__1 = null;
//line 167
if(true) return null;
}

private static Imm NL_print_command_priv(Imm ___arg__0, Imm ___arg__1, Imm ___arg__2) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);Imm ___nl__2 = null;c_rt_lib_NL.NL_copy(ref ___nl__2, ___arg__2);
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
Dictionary<String, Imm> __function_map;
//line 172
___nl__4 = ((ImmHash)___nl__1).getHashValue()["cmd"].clone();
//line 172
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("arr_decl")).clone();
//line 172
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_2;}}
//line 174
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("hash_decl")).clone();
//line 174
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_3;}}
//line 177
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("call")).clone();
//line 177
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_4;}}
//line 181
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("func")).clone();
//line 181
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_5;}}
//line 183
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("una_op")).clone();
//line 183
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_6;}}
//line 185
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("bin_op")).clone();
//line 185
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_7;}}
//line 187
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("ov_is")).clone();
//line 187
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_8;}}
//line 189
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("ov_as")).clone();
//line 189
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_9;}}
//line 191
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("return")).clone();
//line 191
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_10;}}
//line 194
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("die")).clone();
//line 194
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_11;}}
//line 196
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("move")).clone();
//line 196
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_12;}}
//line 198
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("load_const")).clone();
//line 198
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_13;}}
//line 200
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("get_frm_idx")).clone();
//line 200
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_14;}}
//line 204
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("set_at_idx")).clone();
//line 204
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_15;}}
//line 207
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("get_val")).clone();
//line 207
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_16;}}
//line 209
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("set_val")).clone();
//line 209
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_17;}}
//line 211
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("ov_mk")).clone();
//line 211
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_18;}}
//line 213
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("prt_lbl")).clone();
//line 213
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_19;}}
//line 215
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("if_goto")).clone();
//line 215
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_20;}}
//line 217
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("goto")).clone();
//line 217
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_21;}}
//line 219
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("clear")).clone();
//line 219
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_22;}}
//line 219
___nl__5 = new ImmString("NOMATCHALERT").clone();
//line 219
___nl__5 = new ImmArray(new Imm[] {___nl__5,___nl__4,}).clone();
//line 219
c_rt_lib_NL.NL_die();
//line 172
label_2:
//line 172
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("arr_decl")).clone();
//line 173
___nl__8 = ((ImmHash)___nl__6).getHashValue()["dest"].clone();
//line 173
___nl__10 = ((ImmHash)___nl__6).getHashValue()["src"].clone();
//line 173
___nl__9 = generator_cs_NL.NL_print_arr_priv(___nl__10).clone();

//line 173
___nl__10 = null;
//line 173
___nl__7 = generator_cs_NL.NL_print_register_setter_priv(___nl__8,___nl__9).clone();

//line 173
___nl__9 = null;
//line 173
___nl__8 = null;
//line 173
___nl__8 = new ImmString(";").clone();
//line 173
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 173
___nl__8 = null;
//line 173
___nl__3 = ___nl__7.clone();
//line 173
___nl__7 = null;
//line 173
___nl__6 = null;
//line 174
if (true) {goto label_1;}
//line 174
label_3:
//line 174
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("hash_decl")).clone();
//line 175
___nl__7 = generator_cs_NL.NL_print_hash_priv(___nl__6).clone();

//line 175
___nl__3 = ___nl__7.clone();
//line 175
___nl__7 = null;
//line 176
___nl__8 = ((ImmHash)___nl__6).getHashValue()["dest"].clone();
//line 176
___nl__9 = new ImmString("new ImmHash(").clone();
//line 176
___nl__10 = generator_cs_NL.NL_print_hash_name_priv().clone();

//line 176
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 176
___nl__10 = null;
//line 176
___nl__10 = new ImmString(")").clone();
//line 176
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 176
___nl__10 = null;
//line 176
___nl__7 = generator_cs_NL.NL_print_register_setter_priv(___nl__8,___nl__9).clone();

//line 176
___nl__9 = null;
//line 176
___nl__8 = null;
//line 176
___nl__8 = new ImmString(";").clone();
//line 176
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 176
___nl__8 = null;
//line 176
___nl__3 = new ImmString(___nl__3.toString() + ___nl__7.toString()).clone();
//line 176
___nl__7 = null;
//line 176
___nl__6 = null;
//line 177
if (true) {goto label_1;}
//line 177
label_4:
//line 177
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("call")).clone();
//line 178
___nl__8 = ((ImmHash)___nl__6).getHashValue()["args"].clone();
//line 178
___nl__7 = generator_cs_NL.NL_print_call_ref_prepare_priv(___nl__8).clone();

//line 178
___nl__8 = null;
//line 178
___nl__3 = ___nl__7.clone();
//line 178
___nl__7 = null;
//line 179
___nl__8 = ((ImmHash)___nl__6).getHashValue()["dest"].clone();
//line 179
___nl__10 = ((ImmHash)___nl__6).getHashValue()["mod"].clone();
//line 179
___nl__11 = ((ImmHash)___nl__6).getHashValue()["fun_name"].clone();
//line 179
___nl__12 = ((ImmHash)___nl__6).getHashValue()["args"].clone();
//line 179
___nl__9 = generator_cs_NL.NL_print_call_priv(___nl__0,___nl__10,___nl__11,___nl__12).clone();

//line 179
___nl__12 = null;
//line 179
___nl__11 = null;
//line 179
___nl__10 = null;
//line 179
___nl__7 = generator_cs_NL.NL_print_register_setter_priv(___nl__8,___nl__9).clone();

//line 179
___nl__9 = null;
//line 179
___nl__8 = null;
//line 179
___nl__8 = new ImmString(";").clone();
//line 179
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 179
___nl__8 = null;
//line 179
___nl__8 = string_NL.NL_lf().clone();

//line 179
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 179
___nl__8 = null;
//line 179
___nl__3 = new ImmString(___nl__3.toString() + ___nl__7.toString()).clone();
//line 179
___nl__7 = null;
//line 180
___nl__8 = ((ImmHash)___nl__6).getHashValue()["args"].clone();
//line 180
___nl__7 = generator_cs_NL.NL_print_call_ref_setter_priv(___nl__8).clone();

//line 180
___nl__8 = null;
//line 180
___nl__3 = new ImmString(___nl__3.toString() + ___nl__7.toString()).clone();
//line 180
___nl__7 = null;
//line 180
___nl__6 = null;
//line 181
if (true) {goto label_1;}
//line 181
label_5:
//line 181
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("func")).clone();
//line 182
___nl__8 = ((ImmHash)___nl__6).getHashValue()["dest"].clone();
//line 182
___nl__11 = ((ImmHash)___nl__6).getHashValue()["module"].clone();
//line 182
___nl__10 = generator_cs_NL.NL_get_class_name_priv(___nl__11).clone();

//line 182
___nl__11 = null;
//line 182
___nl__11 = ((ImmHash)___nl__6).getHashValue()["name"].clone();
//line 182
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",___nl__10);
__function_map.Add("name",___nl__11);
___nl__9 = new ImmHash(__function_map).clone();
//line 182
___nl__10 = null;
//line 182
___nl__11 = null;
//line 182
___nl__7 = generator_cs_NL.NL_print_const_hash_priv(___nl__8,___nl__9).clone();

//line 182
___nl__9 = null;
//line 182
___nl__8 = null;
//line 182
___nl__8 = new ImmString(";").clone();
//line 182
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 182
___nl__8 = null;
//line 182
___nl__3 = ___nl__7.clone();
//line 182
___nl__7 = null;
//line 182
___nl__6 = null;
//line 183
if (true) {goto label_1;}
//line 183
label_6:
//line 183
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("una_op")).clone();
//line 184
___nl__7 = generator_cs_NL.NL_print_una_op_priv(___nl__6).clone();

//line 184
___nl__3 = ___nl__7.clone();
//line 184
___nl__7 = null;
//line 184
___nl__6 = null;
//line 185
if (true) {goto label_1;}
//line 185
label_7:
//line 185
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("bin_op")).clone();
//line 186
___nl__7 = generator_cs_NL.NL_print_bin_op_priv(___nl__6).clone();

//line 186
___nl__3 = ___nl__7.clone();
//line 186
___nl__7 = null;
//line 186
___nl__6 = null;
//line 187
if (true) {goto label_1;}
//line 187
label_8:
//line 187
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("ov_is")).clone();
//line 188
___nl__8 = ((ImmHash)___nl__6).getHashValue()["dest"].clone();
//line 188
___nl__9 = new ImmString("c_rt_lib_NL.NL_ov_is(").clone();
//line 188
___nl__11 = ((ImmHash)___nl__6).getHashValue()["src"].clone();
//line 188
___nl__10 = generator_cs_NL.NL_print_register_priv(___nl__11).clone();

//line 188
___nl__11 = null;
//line 188
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 188
___nl__10 = null;
//line 188
___nl__10 = new ImmString(", new ImmString(\"").clone();
//line 188
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 188
___nl__10 = null;
//line 188
___nl__11 = ((ImmHash)___nl__6).getHashValue()["type"].clone();
//line 188
___nl__10 = generator_cs_NL.NL_escape_string_priv(___nl__11).clone();

//line 188
___nl__11 = null;
//line 188
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 188
___nl__10 = null;
//line 188
___nl__10 = new ImmString("\"))").clone();
//line 188
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 188
___nl__10 = null;
//line 188
___nl__7 = generator_cs_NL.NL_print_register_setter_priv(___nl__8,___nl__9).clone();

//line 188
___nl__9 = null;
//line 188
___nl__8 = null;
//line 188
___nl__8 = new ImmString(";").clone();
//line 188
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 188
___nl__8 = null;
//line 188
___nl__3 = ___nl__7.clone();
//line 188
___nl__7 = null;
//line 188
___nl__6 = null;
//line 189
if (true) {goto label_1;}
//line 189
label_9:
//line 189
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("ov_as")).clone();
//line 190
___nl__8 = ((ImmHash)___nl__6).getHashValue()["dest"].clone();
//line 190
___nl__9 = new ImmString("c_rt_lib_NL.NL_ov_as(").clone();
//line 190
___nl__11 = ((ImmHash)___nl__6).getHashValue()["src"].clone();
//line 190
___nl__10 = generator_cs_NL.NL_print_register_priv(___nl__11).clone();

//line 190
___nl__11 = null;
//line 190
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 190
___nl__10 = null;
//line 190
___nl__10 = new ImmString(", new ImmString(\"").clone();
//line 190
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 190
___nl__10 = null;
//line 190
___nl__11 = ((ImmHash)___nl__6).getHashValue()["type"].clone();
//line 190
___nl__10 = generator_cs_NL.NL_escape_string_priv(___nl__11).clone();

//line 190
___nl__11 = null;
//line 190
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 190
___nl__10 = null;
//line 190
___nl__10 = new ImmString("\"))").clone();
//line 190
___nl__9 = new ImmString(___nl__9.toString() + ___nl__10.toString()).clone();
//line 190
___nl__10 = null;
//line 190
___nl__7 = generator_cs_NL.NL_print_register_setter_priv(___nl__8,___nl__9).clone();

//line 190
___nl__9 = null;
//line 190
___nl__8 = null;
//line 190
___nl__8 = new ImmString(";").clone();
//line 190
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 190
___nl__8 = null;
//line 190
___nl__3 = ___nl__7.clone();
//line 190
___nl__7 = null;
//line 190
___nl__6 = null;
//line 191
if (true) {goto label_1;}
//line 191
label_10:
//line 191
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("return")).clone();
//line 192
___nl__3 = ___nl__2.clone();
//line 193
___nl__7 = generator_cs_NL.NL_print_return_priv(___nl__6).clone();

//line 193
___nl__3 = new ImmString(___nl__3.toString() + ___nl__7.toString()).clone();
//line 193
___nl__7 = null;
//line 193
___nl__6 = null;
//line 194
if (true) {goto label_1;}
//line 194
label_11:
//line 194
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("die")).clone();
//line 195
___nl__7 = new ImmString("c_rt_lib_NL.NL_die();").clone();
//line 195
___nl__3 = ___nl__7.clone();
//line 195
___nl__7 = null;
//line 195
___nl__6 = null;
//line 196
if (true) {goto label_1;}
//line 196
label_12:
//line 196
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("move")).clone();
//line 197
___nl__8 = ((ImmHash)___nl__6).getHashValue()["dest"].clone();
//line 197
___nl__10 = ((ImmHash)___nl__6).getHashValue()["src"].clone();
//line 197
___nl__9 = generator_cs_NL.NL_print_register_priv(___nl__10).clone();

//line 197
___nl__10 = null;
//line 197
___nl__7 = generator_cs_NL.NL_print_register_setter_priv(___nl__8,___nl__9).clone();

//line 197
___nl__9 = null;
//line 197
___nl__8 = null;
//line 197
___nl__8 = new ImmString(";").clone();
//line 197
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 197
___nl__8 = null;
//line 197
___nl__3 = ___nl__7.clone();
//line 197
___nl__7 = null;
//line 197
___nl__6 = null;
//line 198
if (true) {goto label_1;}
//line 198
label_13:
//line 198
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("load_const")).clone();
//line 199
___nl__8 = ((ImmHash)___nl__6).getHashValue()["dest"].clone();
//line 199
___nl__11 = ((ImmHash)___nl__6).getHashValue()["dest"].clone();
//line 199
___nl__10 = generator_cs_NL.NL_print_register_priv(___nl__11).clone();

//line 199
___nl__11 = null;
//line 199
___nl__11 = ((ImmHash)___nl__6).getHashValue()["val"].clone();
//line 199
___nl__9 = generator_cs_NL.NL_print_const_value_priv(___nl__10,___nl__11).clone();

//line 199
___nl__11 = null;
//line 199
___nl__10 = null;
//line 199
___nl__7 = generator_cs_NL.NL_print_register_setter_priv(___nl__8,___nl__9).clone();

//line 199
___nl__9 = null;
//line 199
___nl__8 = null;
//line 199
___nl__8 = new ImmString(";").clone();
//line 199
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 199
___nl__8 = null;
//line 199
___nl__3 = ___nl__7.clone();
//line 199
___nl__7 = null;
//line 199
___nl__6 = null;
//line 200
if (true) {goto label_1;}
//line 200
label_14:
//line 200
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("get_frm_idx")).clone();
//line 201
___nl__7 = new ImmString("(").clone();
//line 201
___nl__9 = ((ImmHash)___nl__6).getHashValue()["src"].clone();
//line 201
___nl__8 = generator_cs_NL.NL_print_register_priv(___nl__9).clone();

//line 201
___nl__9 = null;
//line 201
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 201
___nl__8 = null;
//line 201
___nl__8 = new ImmString(" as ImmArray).getArrayValue()").clone();
//line 201
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 201
___nl__8 = null;
//line 201
___nl__3 = ___nl__7.clone();
//line 201
___nl__7 = null;
//line 202
___nl__7 = new ImmString("[(int)((ImmDouble)").clone();
//line 202
___nl__9 = ((ImmHash)___nl__6).getHashValue()["idx"].clone();
//line 202
___nl__8 = generator_cs_NL.NL_print_register_priv(___nl__9).clone();

//line 202
___nl__9 = null;
//line 202
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 202
___nl__8 = null;
//line 202
___nl__8 = new ImmString(").getDoubleValue()]").clone();
//line 202
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 202
___nl__8 = null;
//line 202
___nl__3 = new ImmString(___nl__3.toString() + ___nl__7.toString()).clone();
//line 202
___nl__7 = null;
//line 203
___nl__8 = ((ImmHash)___nl__6).getHashValue()["dest"].clone();
//line 203
___nl__7 = generator_cs_NL.NL_print_register_setter_priv(___nl__8,___nl__3).clone();

//line 203
___nl__8 = null;
//line 203
___nl__8 = new ImmString(";").clone();
//line 203
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 203
___nl__8 = null;
//line 203
___nl__3 = ___nl__7.clone();
//line 203
___nl__7 = null;
//line 203
___nl__6 = null;
//line 204
if (true) {goto label_1;}
//line 204
label_15:
//line 204
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("set_at_idx")).clone();
//line 205
___nl__7 = new ImmString("(").clone();
//line 205
___nl__9 = ((ImmHash)___nl__6).getHashValue()["src"].clone();
//line 205
___nl__8 = generator_cs_NL.NL_print_register_priv(___nl__9).clone();

//line 205
___nl__9 = null;
//line 205
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 205
___nl__8 = null;
//line 205
___nl__8 = new ImmString(" as ImmArray).getArrayValue()").clone();
//line 205
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 205
___nl__8 = null;
//line 205
___nl__3 = ___nl__7.clone();
//line 205
___nl__7 = null;
//line 206
___nl__7 = new ImmString("[(int)((ImmDouble)").clone();
//line 206
___nl__9 = ((ImmHash)___nl__6).getHashValue()["idx"].clone();
//line 206
___nl__8 = generator_cs_NL.NL_print_register_priv(___nl__9).clone();

//line 206
___nl__9 = null;
//line 206
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 206
___nl__8 = null;
//line 206
___nl__8 = new ImmString(").getDoubleValue()] = ").clone();
//line 206
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 206
___nl__8 = null;
//line 206
___nl__9 = ((ImmHash)___nl__6).getHashValue()["val"].clone();
//line 206
___nl__8 = generator_cs_NL.NL_print_register_priv(___nl__9).clone();

//line 206
___nl__9 = null;
//line 206
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 206
___nl__8 = null;
//line 206
___nl__8 = new ImmString(";").clone();
//line 206
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 206
___nl__8 = null;
//line 206
___nl__3 = new ImmString(___nl__3.toString() + ___nl__7.toString()).clone();
//line 206
___nl__7 = null;
//line 206
___nl__6 = null;
//line 207
if (true) {goto label_1;}
//line 207
label_16:
//line 207
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("get_val")).clone();
//line 208
___nl__8 = ((ImmHash)___nl__6).getHashValue()["dest"].clone();
//line 208
___nl__9 = generator_cs_NL.NL_print_get_hash_value_priv(___nl__6).clone();

//line 208
___nl__7 = generator_cs_NL.NL_print_register_setter_priv(___nl__8,___nl__9).clone();

//line 208
___nl__9 = null;
//line 208
___nl__8 = null;
//line 208
___nl__8 = new ImmString(";").clone();
//line 208
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 208
___nl__8 = null;
//line 208
___nl__3 = ___nl__7.clone();
//line 208
___nl__7 = null;
//line 208
___nl__6 = null;
//line 209
if (true) {goto label_1;}
//line 209
label_17:
//line 209
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("set_val")).clone();
//line 210
___nl__7 = generator_cs_NL.NL_print_set_hash_value_priv(___nl__6).clone();

//line 210
___nl__8 = new ImmString(";").clone();
//line 210
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 210
___nl__8 = null;
//line 210
___nl__3 = ___nl__7.clone();
//line 210
___nl__7 = null;
//line 210
___nl__6 = null;
//line 211
if (true) {goto label_1;}
//line 211
label_18:
//line 211
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("ov_mk")).clone();
//line 212
___nl__7 = generator_cs_NL.NL_print_ov_mk_priv(___nl__6).clone();

//line 212
___nl__3 = ___nl__7.clone();
//line 212
___nl__7 = null;
//line 212
___nl__6 = null;
//line 213
if (true) {goto label_1;}
//line 213
label_19:
//line 213
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("prt_lbl")).clone();
//line 214
___nl__7 = new ImmString("").clone();
//line 214
___nl__7 = new ImmString(___nl__7.toString() + ___nl__6.toString()).clone();
//line 214
___nl__8 = new ImmString(":").clone();
//line 214
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 214
___nl__8 = null;
//line 214
___nl__3 = ___nl__7.clone();
//line 214
___nl__7 = null;
//line 214
___nl__6 = null;
//line 215
if (true) {goto label_1;}
//line 215
label_20:
//line 215
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("if_goto")).clone();
//line 216
___nl__7 = new ImmString("if (c_rt_lib_NL.NL_check_true_native(").clone();
//line 216
___nl__9 = ((ImmHash)___nl__6).getHashValue()["src"].clone();
//line 216
___nl__8 = generator_cs_NL.NL_print_register_priv(___nl__9).clone();

//line 216
___nl__9 = null;
//line 216
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 216
___nl__8 = null;
//line 216
___nl__8 = new ImmString(")) {").clone();
//line 216
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 216
___nl__8 = null;
//line 216
___nl__9 = ((ImmHash)___nl__6).getHashValue()["dest"].clone();
//line 216
___nl__8 = generator_cs_NL.NL_print_goto_priv(___nl__9).clone();

//line 216
___nl__9 = null;
//line 216
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 216
___nl__8 = null;
//line 216
___nl__8 = new ImmString("}").clone();
//line 216
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 216
___nl__8 = null;
//line 216
___nl__3 = ___nl__7.clone();
//line 216
___nl__7 = null;
//line 216
___nl__6 = null;
//line 217
if (true) {goto label_1;}
//line 217
label_21:
//line 217
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("goto")).clone();
//line 218
___nl__7 = generator_cs_NL.NL_print_goto_priv(___nl__6).clone();

//line 218
___nl__3 = ___nl__7.clone();
//line 218
___nl__7 = null;
//line 218
___nl__6 = null;
//line 219
if (true) {goto label_1;}
//line 219
label_22:
//line 219
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("clear")).clone();
//line 220
___nl__8 = new ImmString("null").clone();
//line 220
___nl__7 = generator_cs_NL.NL_print_register_setter_priv(___nl__6,___nl__8).clone();

//line 220
___nl__8 = null;
//line 220
___nl__8 = new ImmString(";").clone();
//line 220
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString()).clone();
//line 220
___nl__8 = null;
//line 220
___nl__3 = ___nl__7.clone();
//line 220
___nl__7 = null;
//line 220
___nl__6 = null;
//line 221
if (true) {goto label_1;}
//line 221
label_1:
//line 221
___nl__4 = null;
//line 221
___nl__5 = null;
//line 222
___nl__4 = new ImmString("//line ").clone();
//line 222
___nl__5 = ((ImmHash)___nl__1).getHashValue()["debug"].clone();
//line 222
___nl__5 = ((ImmHash)___nl__5).getHashValue()["nast_debug"].clone();
//line 222
___nl__5 = ((ImmHash)___nl__5).getHashValue()["begin"].clone();
//line 222
___nl__5 = ((ImmHash)___nl__5).getHashValue()["line"].clone();
//line 222
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 222
___nl__5 = null;
//line 222
___nl__5 = string_NL.NL_lf().clone();

//line 222
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 222
___nl__5 = null;
//line 222
___nl__4 = new ImmString(___nl__4.toString() + ___nl__3.toString()).clone();
//line 222
___nl__5 = string_NL.NL_lf().clone();

//line 222
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 222
___nl__5 = null;
//line 222
___nl__0 = null;
//line 222
___nl__1 = null;
//line 222
___nl__2 = null;
//line 222
___nl__3 = null;
//line 222
if(true) return ___nl__4;
//line 222
___nl__4 = null;
//line 222
___nl__3 = null;
//line 222
___nl__0 = null;
//line 222
___nl__1 = null;
//line 222
___nl__2 = null;
//line 222
if(true) return null;
}

private static Imm NL_print_arr_priv(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
Imm ___nl__9 = null;
Dictionary<String, Imm> __function_map;
//line 226
___nl__1 = new ImmString("new ImmArray(new Imm[").clone();
//line 227
___nl__2 = array_NL.NL_len(___nl__0).clone();

//line 227
___nl__3 = new ImmDouble(0).clone();
//line 227
___nl__2 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__2.getValue().ToString())) ==((Double.Parse(___nl__3.getValue().ToString())))  ).clone();
//line 227
___nl__3 = null;
//line 227
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 227
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 228
___nl__3 = new ImmString("0]").clone();
//line 228
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 228
___nl__3 = null;
//line 229
if (true) {goto label_1;}
//line 229
label_2:
//line 230
___nl__3 = new ImmString("] {").clone();
//line 230
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 230
___nl__3 = null;
//line 231
___nl__4 = new ImmDouble(0).clone();
//line 231
___nl__5 = new ImmDouble(1).clone();
//line 231
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__0).clone();

//line 231
label_5:
//line 231
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) ).clone();
//line 231
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_3;}}
//line 231
___nl__3 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()].clone();
//line 231
___nl__8 = generator_cs_NL.NL_print_register_priv(___nl__3).clone();

//line 231
___nl__9 = new ImmString(",").clone();
//line 231
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 231
___nl__9 = null;
//line 231
___nl__1 = new ImmString(___nl__1.toString() + ___nl__8.toString()).clone();
//line 231
___nl__8 = null;
//line 231
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 231
if (true) {goto label_5;}
//line 231
label_3:
//line 231
___nl__3 = null;
//line 231
___nl__4 = null;
//line 231
___nl__5 = null;
//line 231
___nl__6 = null;
//line 231
___nl__7 = null;
//line 232
___nl__3 = new ImmString("}").clone();
//line 232
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 232
___nl__3 = null;
//line 233
if (true) {goto label_1;}
//line 233
label_1:
//line 233
___nl__2 = null;
//line 234
___nl__2 = new ImmString(")").clone();
//line 234
___nl__2 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 234
___nl__0 = null;
//line 234
___nl__1 = null;
//line 234
if(true) return ___nl__2;
//line 234
___nl__2 = null;
//line 234
___nl__1 = null;
//line 234
___nl__0 = null;
//line 234
if(true) return null;
}

private static Imm NL_print_bin_op_priv(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Dictionary<String, Imm> __function_map;
//line 238
___nl__1 = new ImmString("").clone();
//line 239
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 239
___nl__3 = new ImmString(">=").clone();
//line 239
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 239
___nl__3 = null;
//line 239
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_7;}}
//line 239
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 239
___nl__3 = new ImmString("<=").clone();
//line 239
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 239
___nl__3 = null;
//line 239
label_7:
//line 239
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_6;}}
//line 239
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 239
___nl__3 = new ImmString("<").clone();
//line 239
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 239
___nl__3 = null;
//line 239
label_6:
//line 239
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_5;}}
//line 239
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 239
___nl__3 = new ImmString(">").clone();
//line 239
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 239
___nl__3 = null;
//line 239
label_5:
//line 239
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_4;}}
//line 239
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 239
___nl__3 = new ImmString("==").clone();
//line 239
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 239
___nl__3 = null;
//line 239
label_4:
//line 239
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_3;}}
//line 239
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 239
___nl__3 = new ImmString("!=").clone();
//line 239
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 239
___nl__3 = null;
//line 239
label_3:
//line 239
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 239
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 241
___nl__3 = new ImmString("c_rt_lib_NL.NL_native_to_nl(").clone();
//line 241
___nl__4 = generator_cs_NL.NL_print_imm_double_operation_priv(___nl__0).clone();

//line 241
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 241
___nl__4 = null;
//line 241
___nl__4 = new ImmString(" )").clone();
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
label_2:
//line 242
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 242
___nl__3 = new ImmString("eq").clone();
//line 242
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 242
___nl__3 = null;
//line 242
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_9;}}
//line 242
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 242
___nl__3 = new ImmString("ne").clone();
//line 242
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 242
___nl__3 = null;
//line 242
label_9:
//line 242
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 242
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_8;}}
//line 243
___nl__3 = new ImmString("c_rt_lib_NL.NL_native_to_nl(").clone();
//line 243
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 243
___nl__3 = null;
//line 244
___nl__3 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 244
___nl__4 = new ImmString("ne").clone();
//line 244
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__3.toString().Equals(___nl__4.toString())).clone();
//line 244
___nl__4 = null;
//line 244
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 244
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_11;}}
//line 245
___nl__4 = new ImmString("!").clone();
//line 245
___nl__1 = new ImmString(___nl__1.toString() + ___nl__4.toString()).clone();
//line 245
___nl__4 = null;
//line 246
if (true) {goto label_11;}
//line 246
label_11:
//line 246
___nl__3 = null;
//line 247
___nl__4 = ((ImmHash)___nl__0).getHashValue()["left"].clone();
//line 247
___nl__3 = generator_cs_NL.NL_print_register_priv(___nl__4).clone();

//line 247
___nl__4 = null;
//line 247
___nl__4 = new ImmString(".toString().Equals(").clone();
//line 247
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 247
___nl__4 = null;
//line 247
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 247
___nl__3 = null;
//line 248
___nl__4 = ((ImmHash)___nl__0).getHashValue()["right"].clone();
//line 248
___nl__3 = generator_cs_NL.NL_print_register_priv(___nl__4).clone();

//line 248
___nl__4 = null;
//line 248
___nl__4 = new ImmString(".toString()))").clone();
//line 248
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 248
___nl__4 = null;
//line 248
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 248
___nl__3 = null;
//line 249
if (true) {goto label_1;}
//line 249
label_8:
//line 249
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 249
___nl__3 = new ImmString(".").clone();
//line 249
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 249
___nl__3 = null;
//line 249
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 249
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_12;}}
//line 250
___nl__3 = new ImmString("new ImmString(").clone();
//line 250
___nl__5 = ((ImmHash)___nl__0).getHashValue()["left"].clone();
//line 250
___nl__4 = generator_cs_NL.NL_print_register_priv(___nl__5).clone();

//line 250
___nl__5 = null;
//line 250
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 250
___nl__4 = null;
//line 250
___nl__4 = new ImmString(".toString() + ").clone();
//line 250
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 250
___nl__4 = null;
//line 250
___nl__5 = ((ImmHash)___nl__0).getHashValue()["right"].clone();
//line 250
___nl__4 = generator_cs_NL.NL_print_register_priv(___nl__5).clone();

//line 250
___nl__5 = null;
//line 250
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 250
___nl__4 = null;
//line 250
___nl__4 = new ImmString(".toString())").clone();
//line 250
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 250
___nl__4 = null;
//line 250
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 250
___nl__3 = null;
//line 251
if (true) {goto label_1;}
//line 251
label_12:
//line 252
___nl__3 = new ImmString("new ImmDouble(").clone();
//line 252
___nl__4 = generator_cs_NL.NL_print_imm_double_operation_priv(___nl__0).clone();

//line 252
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 252
___nl__4 = null;
//line 252
___nl__4 = new ImmString(")").clone();
//line 252
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 252
___nl__4 = null;
//line 252
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 252
___nl__3 = null;
//line 253
if (true) {goto label_1;}
//line 253
label_1:
//line 253
___nl__2 = null;
//line 254
___nl__3 = ((ImmHash)___nl__0).getHashValue()["dest"].clone();
//line 254
___nl__2 = generator_cs_NL.NL_print_register_setter_priv(___nl__3,___nl__1).clone();

//line 254
___nl__3 = null;
//line 254
___nl__3 = new ImmString(";").clone();
//line 254
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 254
___nl__3 = null;
//line 254
___nl__0 = null;
//line 254
___nl__1 = null;
//line 254
if(true) return ___nl__2;
//line 254
___nl__2 = null;
//line 254
___nl__1 = null;
//line 254
___nl__0 = null;
//line 254
if(true) return null;
}

private static Imm NL_print_imm_double_operation_priv(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Dictionary<String, Imm> __function_map;
//line 258
___nl__2 = ((ImmHash)___nl__0).getHashValue()["left"].clone();
//line 258
___nl__1 = generator_cs_NL.NL_print_register_as_number_priv(___nl__2).clone();

//line 258
___nl__2 = null;
//line 259
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 259
___nl__3 = new ImmString("==").clone();
//line 259
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 259
___nl__3 = null;
//line 259
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_3;}}
//line 259
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 259
___nl__3 = new ImmString("!=").clone();
//line 259
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 259
___nl__3 = null;
//line 259
label_3:
//line 259
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 259
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 260
___nl__3 = new ImmString(" ").clone();
//line 260
___nl__4 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 260
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 260
___nl__4 = null;
//line 260
___nl__4 = new ImmString("(").clone();
//line 260
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 260
___nl__4 = null;
//line 260
___nl__5 = ((ImmHash)___nl__0).getHashValue()["right"].clone();
//line 260
___nl__4 = generator_cs_NL.NL_print_register_as_number_priv(___nl__5).clone();

//line 260
___nl__5 = null;
//line 260
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 260
___nl__4 = null;
//line 260
___nl__4 = new ImmString(") ").clone();
//line 260
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 260
___nl__4 = null;
//line 260
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 260
___nl__3 = null;
//line 261
if (true) {goto label_1;}
//line 261
label_2:
//line 262
___nl__3 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 262
___nl__5 = ((ImmHash)___nl__0).getHashValue()["right"].clone();
//line 262
___nl__4 = generator_cs_NL.NL_print_register_as_number_priv(___nl__5).clone();

//line 262
___nl__5 = null;
//line 262
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 262
___nl__4 = null;
//line 262
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 262
___nl__3 = null;
//line 263
if (true) {goto label_1;}
//line 263
label_1:
//line 263
___nl__2 = null;
//line 264
___nl__0 = null;
//line 264
if(true) return ___nl__1;
//line 264
___nl__1 = null;
//line 264
___nl__0 = null;
//line 264
if(true) return null;
}

private static Imm NL_print_register_as_number_priv(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 268
___nl__1 = new ImmString("(Double.Parse(").clone();
//line 268
___nl__2 = generator_cs_NL.NL_print_register_priv(___nl__0).clone();

//line 268
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 268
___nl__2 = null;
//line 268
___nl__2 = generator_cs_NL.NL_print_getter_priv().clone();

//line 268
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 268
___nl__2 = null;
//line 268
___nl__2 = new ImmString(".ToString()))").clone();
//line 268
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
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

private static Imm NL_print_call_priv(Imm ___arg__0, Imm ___arg__1, Imm ___arg__2, Imm ___arg__3) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);Imm ___nl__2 = null;c_rt_lib_NL.NL_copy(ref ___nl__2, ___arg__2);Imm ___nl__3 = null;c_rt_lib_NL.NL_copy(ref ___nl__3, ___arg__3);
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
Dictionary<String, Imm> __function_map;
//line 272
___nl__4 = new ImmString("").clone();
//line 272
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__1.toString().Equals(___nl__4.toString())).clone();
//line 272
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 272
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_2;}}
//line 272
___nl__5 = new ImmString("_priv").clone();
//line 272
___nl__5 = new ImmString(___nl__2.toString() + ___nl__5.toString()).clone();
//line 272
___nl__2 = ___nl__5.clone();
//line 272
___nl__5 = null;
//line 272
if (true) {goto label_2;}
//line 272
label_2:
//line 272
___nl__4 = null;
//line 273
___nl__4 = new ImmString("").clone();
//line 273
___nl__4 = c_rt_lib_NL.NL_native_to_nl(___nl__1.toString().Equals(___nl__4.toString())).clone();
//line 273
___nl__4 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__4)).clone();
//line 273
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_4;}}
//line 273
___nl__1 = ___nl__0.clone();
//line 273
if (true) {goto label_4;}
//line 273
label_4:
//line 273
___nl__4 = null;
//line 274
___nl__4 = generator_cs_NL.NL_get_class_name_priv(___nl__1).clone();

//line 274
___nl__5 = new ImmString(".NL_").clone();
//line 274
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 274
___nl__5 = null;
//line 274
___nl__5 = ___nl__2.clone();
//line 274
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 274
___nl__5 = null;
//line 274
___nl__5 = new ImmString("(").clone();
//line 274
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 274
___nl__5 = null;
//line 275
___nl__5 = new ImmDouble(0).clone();
//line 276
___nl__7 = new ImmDouble(0).clone();
//line 276
___nl__8 = new ImmDouble(1).clone();
//line 276
___nl__9 = c_rt_lib_NL.NL_array_len(___nl__3).clone();

//line 276
label_7:
//line 276
___nl__10 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))>=(Double.Parse(___nl__9.getValue().ToString())) ).clone();
//line 276
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_5;}}
//line 276
___nl__6 = (___nl__3 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()].clone();
//line 277
___nl__11 = new ImmDouble(0).clone();
//line 277
___nl__11 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString())) ==((Double.Parse(___nl__11.getValue().ToString())))  ).clone();
//line 277
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 277
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11)).clone();
//line 277
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_9;}}
//line 277
___nl__12 = new ImmString(",").clone();
//line 277
___nl__4 = new ImmString(___nl__4.toString() + ___nl__12.toString()).clone();
//line 277
___nl__12 = null;
//line 277
if (true) {goto label_9;}
//line 277
label_9:
//line 277
___nl__11 = null;
//line 278
___nl__11 = new ImmDouble(1).clone();
//line 278
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__11.getValue().ToString()))).clone();
//line 278
___nl__11 = null;
//line 279
___nl__11 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("ref")).clone();
//line 279
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_11;}}
//line 281
___nl__11 = c_rt_lib_NL.NL_ov_is(___nl__6, new ImmString("val")).clone();
//line 281
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_12;}}
//line 281
___nl__11 = new ImmString("NOMATCHALERT").clone();
//line 281
___nl__11 = new ImmArray(new Imm[] {___nl__11,___nl__6,}).clone();
//line 281
c_rt_lib_NL.NL_die();
//line 279
label_11:
//line 279
___nl__12 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("ref")).clone();
//line 280
___nl__13 = new ImmString("ref ").clone();
//line 280
___nl__14 = generator_cs_NL.NL_print_register_priv(___nl__12).clone();

//line 280
___nl__13 = new ImmString(___nl__13.toString() + ___nl__14.toString()).clone();
//line 280
___nl__14 = null;
//line 280
___nl__4 = new ImmString(___nl__4.toString() + ___nl__13.toString()).clone();
//line 280
___nl__13 = null;
//line 280
___nl__12 = null;
//line 281
if (true) {goto label_10;}
//line 281
label_12:
//line 281
___nl__12 = c_rt_lib_NL.NL_ov_as(___nl__6, new ImmString("val")).clone();
//line 282
___nl__13 = generator_cs_NL.NL_print_register_priv(___nl__12).clone();

//line 282
___nl__4 = new ImmString(___nl__4.toString() + ___nl__13.toString()).clone();
//line 282
___nl__13 = null;
//line 282
___nl__12 = null;
//line 283
if (true) {goto label_10;}
//line 283
label_10:
//line 283
___nl__11 = null;
//line 284
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString()))).clone();
//line 284
if (true) {goto label_7;}
//line 284
label_5:
//line 284
___nl__6 = null;
//line 284
___nl__7 = null;
//line 284
___nl__8 = null;
//line 284
___nl__9 = null;
//line 284
___nl__10 = null;
//line 285
___nl__6 = new ImmString(")").clone();
//line 285
___nl__6 = new ImmString(___nl__4.toString() + ___nl__6.toString()).clone();
//line 285
___nl__0 = null;
//line 285
___nl__1 = null;
//line 285
___nl__2 = null;
//line 285
___nl__3 = null;
//line 285
___nl__4 = null;
//line 285
___nl__5 = null;
//line 285
if(true) return ___nl__6;
//line 285
___nl__6 = null;
//line 285
___nl__4 = null;
//line 285
___nl__5 = null;
//line 285
___nl__0 = null;
//line 285
___nl__1 = null;
//line 285
___nl__2 = null;
//line 285
___nl__3 = null;
//line 285
if(true) return null;
}

private static Imm NL_print_call_ref_prepare_priv(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
Dictionary<String, Imm> __function_map;
//line 289
___nl__1 = new ImmString("").clone();
//line 290
___nl__3 = new ImmDouble(0).clone();
//line 290
___nl__4 = new ImmDouble(1).clone();
//line 290
___nl__5 = c_rt_lib_NL.NL_array_len(___nl__0).clone();

//line 290
label_3:
//line 290
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))>=(Double.Parse(___nl__5.getValue().ToString())) ).clone();
//line 290
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_1;}}
//line 290
___nl__2 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__3).getDoubleValue()].clone();
//line 291
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("ref")).clone();
//line 291
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_5;}}
//line 293
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("val")).clone();
//line 293
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_6;}}
//line 293
___nl__7 = new ImmString("NOMATCHALERT").clone();
//line 293
___nl__7 = new ImmArray(new Imm[] {___nl__7,___nl__2,}).clone();
//line 293
c_rt_lib_NL.NL_die();
//line 291
label_5:
//line 291
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("ref")).clone();
//line 291
___nl__8 = null;
//line 293
if (true) {goto label_4;}
//line 293
label_6:
//line 293
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("val")).clone();
//line 293
___nl__8 = null;
//line 294
if (true) {goto label_4;}
//line 294
label_4:
//line 294
___nl__7 = null;
//line 295
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString()))).clone();
//line 295
if (true) {goto label_3;}
//line 295
label_1:
//line 295
___nl__2 = null;
//line 295
___nl__3 = null;
//line 295
___nl__4 = null;
//line 295
___nl__5 = null;
//line 295
___nl__6 = null;
//line 296
___nl__0 = null;
//line 296
if(true) return ___nl__1;
//line 296
___nl__1 = null;
//line 296
___nl__0 = null;
//line 296
if(true) return null;
}

private static Imm NL_print_call_ref_setter_priv(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
Dictionary<String, Imm> __function_map;
//line 300
___nl__1 = new ImmString("").clone();
//line 301
___nl__3 = new ImmDouble(0).clone();
//line 301
___nl__4 = new ImmDouble(1).clone();
//line 301
___nl__5 = c_rt_lib_NL.NL_array_len(___nl__0).clone();

//line 301
label_3:
//line 301
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))>=(Double.Parse(___nl__5.getValue().ToString())) ).clone();
//line 301
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_1;}}
//line 301
___nl__2 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__3).getDoubleValue()].clone();
//line 302
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("ref")).clone();
//line 302
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_5;}}
//line 305
___nl__7 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("val")).clone();
//line 305
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_6;}}
//line 305
___nl__7 = new ImmString("NOMATCHALERT").clone();
//line 305
___nl__7 = new ImmArray(new Imm[] {___nl__7,___nl__2,}).clone();
//line 305
c_rt_lib_NL.NL_die();
//line 302
label_5:
//line 302
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("ref")).clone();
//line 302
___nl__8 = null;
//line 305
if (true) {goto label_4;}
//line 305
label_6:
//line 305
___nl__8 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("val")).clone();
//line 305
___nl__8 = null;
//line 306
if (true) {goto label_4;}
//line 306
label_4:
//line 306
___nl__7 = null;
//line 307
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString()))).clone();
//line 307
if (true) {goto label_3;}
//line 307
label_1:
//line 307
___nl__2 = null;
//line 307
___nl__3 = null;
//line 307
___nl__4 = null;
//line 307
___nl__5 = null;
//line 307
___nl__6 = null;
//line 308
___nl__0 = null;
//line 308
if(true) return ___nl__1;
//line 308
___nl__1 = null;
//line 308
___nl__0 = null;
//line 308
if(true) return null;
}

private static Imm NL_print_const_arr_priv(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
Imm ___nl__9 = null;
Dictionary<String, Imm> __function_map;
//line 312
___nl__2 = new ImmString("new Imm[] {").clone();
//line 313
___nl__4 = new ImmDouble(0).clone();
//line 313
___nl__5 = new ImmDouble(1).clone();
//line 313
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__1).clone();

//line 313
label_3:
//line 313
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) ).clone();
//line 313
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_1;}}
//line 313
___nl__3 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()].clone();
//line 313
___nl__8 = generator_cs_NL.NL_print_const_value_priv(___nl__0,___nl__3).clone();

//line 313
___nl__9 = new ImmString(",").clone();
//line 313
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 313
___nl__9 = null;
//line 313
___nl__2 = new ImmString(___nl__2.toString() + ___nl__8.toString()).clone();
//line 313
___nl__8 = null;
//line 313
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 313
if (true) {goto label_3;}
//line 313
label_1:
//line 313
___nl__3 = null;
//line 313
___nl__4 = null;
//line 313
___nl__5 = null;
//line 313
___nl__6 = null;
//line 313
___nl__7 = null;
//line 314
___nl__3 = new ImmString("}").clone();
//line 314
___nl__3 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 314
___nl__0 = null;
//line 314
___nl__1 = null;
//line 314
___nl__2 = null;
//line 314
if(true) return ___nl__3;
//line 314
___nl__3 = null;
//line 314
___nl__2 = null;
//line 314
___nl__0 = null;
//line 314
___nl__1 = null;
//line 314
if(true) return null;
}

private static Imm NL_print_const_hash_priv(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Dictionary<String, Imm> __function_map;
//line 318
___nl__2 = generator_cs_NL.NL_print_hash_name_priv().clone();

//line 318
___nl__3 = new ImmString(" = new Dictionary<String, Imm>();").clone();
//line 318
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 318
___nl__3 = null;
//line 318
___nl__3 = string_NL.NL_lf().clone();

//line 318
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 318
___nl__3 = null;
//line 319
___nl__5 = c_rt_lib_NL.NL_init_iter(___nl__1).clone();

//line 319
label_3:
//line 319
___nl__3 = c_rt_lib_NL.NL_is_end_hash(___nl__5).clone();

//line 319
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_1;}}
//line 319
___nl__3 = c_rt_lib_NL.NL_get_key_iter(___nl__5).clone();

//line 319
___nl__4 = c_rt_lib_NL.NL_hash_get_value(___nl__1,___nl__3).clone();

//line 319
___nl__6 = generator_cs_NL.NL_print_hash_name_priv().clone();

//line 319
___nl__7 = new ImmString(".Add(\"").clone();
//line 319
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 319
___nl__7 = null;
//line 319
___nl__7 = generator_cs_NL.NL_escape_string_priv(___nl__3).clone();

//line 319
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 319
___nl__7 = null;
//line 319
___nl__7 = new ImmString("\",").clone();
//line 319
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 319
___nl__7 = null;
//line 319
___nl__7 = generator_cs_NL.NL_print_const_value_priv(___nl__0,___nl__4).clone();

//line 319
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 319
___nl__7 = null;
//line 319
___nl__7 = new ImmString(");").clone();
//line 319
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 319
___nl__7 = null;
//line 319
___nl__7 = string_NL.NL_lf().clone();

//line 319
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 319
___nl__7 = null;
//line 319
___nl__2 = new ImmString(___nl__2.toString() + ___nl__6.toString()).clone();
//line 319
___nl__6 = null;
//line 319
___nl__5 = c_rt_lib_NL.NL_next_iter(___nl__5).clone();

//line 319
if (true) {goto label_3;}
//line 319
label_1:
//line 319
___nl__3 = null;
//line 319
___nl__4 = null;
//line 319
___nl__5 = null;
//line 320
___nl__4 = new ImmString("new ImmHash(").clone();
//line 320
___nl__5 = generator_cs_NL.NL_print_hash_name_priv().clone();

//line 320
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 320
___nl__5 = null;
//line 320
___nl__5 = new ImmString(")").clone();
//line 320
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 320
___nl__5 = null;
//line 320
___nl__3 = generator_cs_NL.NL_print_register_setter_priv(___nl__0,___nl__4).clone();

//line 320
___nl__4 = null;
//line 320
___nl__3 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 320
___nl__0 = null;
//line 320
___nl__1 = null;
//line 320
___nl__2 = null;
//line 320
if(true) return ___nl__3;
//line 320
___nl__3 = null;
//line 320
___nl__2 = null;
//line 320
___nl__0 = null;
//line 320
___nl__1 = null;
//line 320
if(true) return null;
}

private static Imm NL_print_const_ov_priv(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Dictionary<String, Imm> __function_map;
//line 324
___nl__2 = new ImmString("").clone();
//line 325
___nl__3 = ov_NL.NL_has_value(___nl__1).clone();

//line 325
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 325
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 326
___nl__4 = new ImmString("new OV(\"").clone();
//line 326
___nl__6 = ov_NL.NL_get_element(___nl__1).clone();

//line 326
___nl__5 = generator_cs_NL.NL_escape_string_priv(___nl__6).clone();

//line 326
___nl__6 = null;
//line 326
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 326
___nl__5 = null;
//line 326
___nl__5 = new ImmString("\", ").clone();
//line 326
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 326
___nl__5 = null;
//line 326
___nl__6 = ov_NL.NL_get_value(___nl__1).clone();

//line 326
___nl__5 = generator_cs_NL.NL_print_const_value_priv(___nl__0,___nl__6).clone();

//line 326
___nl__6 = null;
//line 326
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 326
___nl__5 = null;
//line 326
___nl__5 = new ImmString(")").clone();
//line 326
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 326
___nl__5 = null;
//line 326
___nl__2 = ___nl__4.clone();
//line 326
___nl__4 = null;
//line 327
if (true) {goto label_1;}
//line 327
label_2:
//line 328
___nl__4 = new ImmString("new OV(\"").clone();
//line 328
___nl__6 = ov_NL.NL_get_element(___nl__1).clone();

//line 328
___nl__5 = generator_cs_NL.NL_escape_string_priv(___nl__6).clone();

//line 328
___nl__6 = null;
//line 328
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 328
___nl__5 = null;
//line 328
___nl__5 = new ImmString("\", null)").clone();
//line 328
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 328
___nl__5 = null;
//line 328
___nl__2 = ___nl__4.clone();
//line 328
___nl__4 = null;
//line 329
if (true) {goto label_1;}
//line 329
label_1:
//line 329
___nl__3 = null;
//line 330
___nl__0 = null;
//line 330
___nl__1 = null;
//line 330
if(true) return ___nl__2;
//line 330
___nl__2 = null;
//line 330
___nl__0 = null;
//line 330
___nl__1 = null;
//line 330
if(true) return null;
}

private static Imm NL_print_const_value_priv(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Dictionary<String, Imm> __function_map;
//line 334
___nl__2 = nl_NL.NL_is_sim(___nl__1).clone();

//line 334
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 334
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_4;}}
//line 334
___nl__5 = ptd_NL.NL_sim().clone();

//line 334
___nl__4 = ptd_NL.NL_ensure(___nl__5,___nl__1).clone();

//line 334
___nl__5 = null;
//line 334
___nl__2 = string_utils_NL.NL_is_integer(___nl__4).clone();

//line 334
___nl__4 = null;
//line 334
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_4;}}
//line 334
___nl__5 = ptd_NL.NL_sim().clone();

//line 334
___nl__4 = ptd_NL.NL_ensure(___nl__5,___nl__1).clone();

//line 334
___nl__5 = null;
//line 334
___nl__2 = string_utils_NL.NL_is_float(___nl__4).clone();

//line 334
___nl__4 = null;
//line 334
label_4:
//line 334
___nl__3 = null;
//line 334
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 334
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 336
___nl__3 = new ImmString("new ImmDouble(").clone();
//line 336
___nl__3 = new ImmString(___nl__3.toString() + ___nl__1.toString()).clone();
//line 336
___nl__4 = new ImmString(")").clone();
//line 336
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 336
___nl__4 = null;
//line 336
___nl__0 = null;
//line 336
___nl__1 = null;
//line 336
___nl__2 = null;
//line 336
if(true) return ___nl__3;
//line 336
___nl__3 = null;
//line 337
if (true) {goto label_1;}
//line 337
label_2:
//line 337
___nl__2 = nl_NL.NL_is_sim(___nl__1).clone();

//line 337
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 337
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_5;}}
//line 338
___nl__3 = new ImmString("new ImmString(\"").clone();
//line 338
___nl__4 = generator_cs_NL.NL_escape_string_priv(___nl__1).clone();

//line 338
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 338
___nl__4 = null;
//line 338
___nl__4 = new ImmString("\")").clone();
//line 338
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 338
___nl__4 = null;
//line 338
___nl__0 = null;
//line 338
___nl__1 = null;
//line 338
___nl__2 = null;
//line 338
if(true) return ___nl__3;
//line 338
___nl__3 = null;
//line 339
if (true) {goto label_1;}
//line 339
label_5:
//line 339
___nl__2 = nl_NL.NL_is_array(___nl__1).clone();

//line 339
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 339
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_6;}}
//line 340
___nl__3 = generator_cs_NL.NL_print_const_arr_priv(___nl__0,___nl__1).clone();

//line 340
___nl__0 = null;
//line 340
___nl__1 = null;
//line 340
___nl__2 = null;
//line 340
if(true) return ___nl__3;
//line 340
___nl__3 = null;
//line 341
if (true) {goto label_1;}
//line 341
label_6:
//line 341
___nl__2 = nl_NL.NL_is_hash(___nl__1).clone();

//line 341
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 341
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_7;}}
//line 342
___nl__3 = generator_cs_NL.NL_print_const_hash_priv(___nl__0,___nl__1).clone();

//line 342
___nl__0 = null;
//line 342
___nl__1 = null;
//line 342
___nl__2 = null;
//line 342
if(true) return ___nl__3;
//line 342
___nl__3 = null;
//line 343
if (true) {goto label_1;}
//line 343
label_7:
//line 343
___nl__2 = nl_NL.NL_is_variant(___nl__1).clone();

//line 343
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 343
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_8;}}
//line 344
___nl__3 = generator_cs_NL.NL_print_const_ov_priv(___nl__0,___nl__1).clone();

//line 344
___nl__0 = null;
//line 344
___nl__1 = null;
//line 344
___nl__2 = null;
//line 344
if(true) return ___nl__3;
//line 344
___nl__3 = null;
//line 345
if (true) {goto label_1;}
//line 345
label_8:
//line 346
___nl__3 = new ImmArray(new Imm[0]).clone();
//line 346
c_rt_lib_NL.NL_die();
//line 346
___nl__3 = null;
//line 347
if (true) {goto label_1;}
//line 347
label_1:
//line 347
___nl__2 = null;
//line 347
___nl__0 = null;
//line 347
___nl__1 = null;
//line 347
if(true) return null;
}

private static Imm NL_print_goto_priv(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 351
___nl__1 = new ImmString("if (true) {goto ").clone();
//line 351
___nl__1 = new ImmString(___nl__1.toString() + ___nl__0.toString()).clone();
//line 351
___nl__2 = new ImmString(";}").clone();
//line 351
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 351
___nl__2 = null;
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

private static Imm NL_print_hash_priv(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
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
Dictionary<String, Imm> __function_map;
//line 355
___nl__1 = generator_cs_NL.NL_print_hash_name_priv().clone();

//line 355
___nl__2 = new ImmString(" = new Dictionary<String, Imm>();").clone();
//line 355
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 355
___nl__2 = null;
//line 355
___nl__2 = string_NL.NL_lf().clone();

//line 355
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 355
___nl__2 = null;
//line 356
___nl__2 = ((ImmHash)___nl__0).getHashValue()["src"].clone();
//line 356
___nl__4 = new ImmDouble(0).clone();
//line 356
___nl__5 = new ImmDouble(1).clone();
//line 356
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__2).clone();

//line 356
label_3:
//line 356
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) ).clone();
//line 356
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_1;}}
//line 356
___nl__3 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()].clone();
//line 356
___nl__8 = generator_cs_NL.NL_print_hash_name_priv().clone();

//line 356
___nl__9 = new ImmString(".Add(\"").clone();
//line 356
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 356
___nl__9 = null;
//line 356
___nl__10 = ((ImmHash)___nl__3).getHashValue()["key"].clone();
//line 356
___nl__9 = generator_cs_NL.NL_escape_string_priv(___nl__10).clone();

//line 356
___nl__10 = null;
//line 356
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 356
___nl__9 = null;
//line 356
___nl__9 = new ImmString("\",").clone();
//line 356
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 356
___nl__9 = null;
//line 356
___nl__10 = ((ImmHash)___nl__3).getHashValue()["val"].clone();
//line 356
___nl__9 = generator_cs_NL.NL_print_register_priv(___nl__10).clone();

//line 356
___nl__10 = null;
//line 356
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 356
___nl__9 = null;
//line 356
___nl__9 = new ImmString(");").clone();
//line 356
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 356
___nl__9 = null;
//line 356
___nl__9 = string_NL.NL_lf().clone();

//line 356
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString()).clone();
//line 356
___nl__9 = null;
//line 356
___nl__1 = new ImmString(___nl__1.toString() + ___nl__8.toString()).clone();
//line 356
___nl__8 = null;
//line 356
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 356
if (true) {goto label_3;}
//line 356
label_1:
//line 356
___nl__2 = null;
//line 356
___nl__3 = null;
//line 356
___nl__4 = null;
//line 356
___nl__5 = null;
//line 356
___nl__6 = null;
//line 356
___nl__7 = null;
//line 357
___nl__0 = null;
//line 357
if(true) return ___nl__1;
//line 357
___nl__1 = null;
//line 357
___nl__0 = null;
//line 357
if(true) return null;
}

private static Imm NL_SINGLETON_print_hash_name_priv() {

Imm ___nl__0 = null;
Dictionary<String, Imm> __function_map;
//line 361
___nl__0 = new ImmString("__function_map").clone();
//line 361
if(true) return ___nl__0;
//line 361
___nl__0 = null;
//line 361
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
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 365
___nl__1 = new ImmString("((ImmHash)").clone();
//line 365
___nl__3 = ((ImmHash)___nl__0).getHashValue()["src"].clone();
//line 365
___nl__2 = generator_cs_NL.NL_print_register_priv(___nl__3).clone();

//line 365
___nl__3 = null;
//line 365
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 365
___nl__2 = null;
//line 365
___nl__2 = new ImmString(").getHashValue()[\"").clone();
//line 365
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 365
___nl__2 = null;
//line 365
___nl__3 = ((ImmHash)___nl__0).getHashValue()["key"].clone();
//line 365
___nl__2 = generator_cs_NL.NL_escape_string_priv(___nl__3).clone();

//line 365
___nl__3 = null;
//line 365
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 365
___nl__2 = null;
//line 365
___nl__2 = new ImmString("\"]").clone();
//line 365
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 365
___nl__2 = null;
//line 365
___nl__0 = null;
//line 365
if(true) return ___nl__1;
//line 365
___nl__1 = null;
//line 365
___nl__0 = null;
//line 365
if(true) return null;
}

private static Imm NL_print_set_hash_value_priv(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 369
___nl__1 = new ImmString("((ImmHash)").clone();
//line 369
___nl__3 = ((ImmHash)___nl__0).getHashValue()["src"].clone();
//line 369
___nl__2 = generator_cs_NL.NL_print_register_priv(___nl__3).clone();

//line 369
___nl__3 = null;
//line 369
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 369
___nl__2 = null;
//line 369
___nl__2 = new ImmString(").set(\"").clone();
//line 369
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 369
___nl__2 = null;
//line 369
___nl__3 = ((ImmHash)___nl__0).getHashValue()["key"].clone();
//line 369
___nl__2 = generator_cs_NL.NL_escape_string_priv(___nl__3).clone();

//line 369
___nl__3 = null;
//line 369
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 369
___nl__2 = null;
//line 369
___nl__2 = new ImmString("\", ").clone();
//line 369
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 369
___nl__2 = null;
//line 370
___nl__3 = ((ImmHash)___nl__0).getHashValue()["val"].clone();
//line 370
___nl__2 = generator_cs_NL.NL_print_register_priv(___nl__3).clone();

//line 370
___nl__3 = null;
//line 370
___nl__3 = new ImmString(")").clone();
//line 370
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 370
___nl__3 = null;
//line 370
___nl__1 = new ImmString(___nl__1.toString() + ___nl__2.toString()).clone();
//line 370
___nl__2 = null;
//line 371
___nl__0 = null;
//line 371
if(true) return ___nl__1;
//line 371
___nl__1 = null;
//line 371
___nl__0 = null;
//line 371
if(true) return null;
}

private static Imm NL_print_ov_mk_priv(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
Dictionary<String, Imm> __function_map;
//line 375
___nl__1 = new ImmString("").clone();
//line 376
___nl__2 = ((ImmHash)___nl__0).getHashValue()["src"].clone();
//line 376
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("emp")).clone();
//line 376
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 376
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 376
___nl__2 = ((ImmHash)___nl__0).getHashValue()["name"].clone();
//line 376
___nl__4 = new ImmString("TRUE").clone();
//line 376
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__4.toString())).clone();
//line 376
___nl__4 = null;
//line 376
label_3:
//line 376
___nl__3 = null;
//line 376
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 376
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 377
___nl__3 = new ImmString("c_rt_lib_NL.NL_get_true()").clone();
//line 377
___nl__1 = ___nl__3.clone();
//line 377
___nl__3 = null;
//line 378
if (true) {goto label_1;}
//line 378
label_2:
//line 378
___nl__2 = ((ImmHash)___nl__0).getHashValue()["src"].clone();
//line 378
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("emp")).clone();
//line 378
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 378
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_5;}}
//line 378
___nl__2 = ((ImmHash)___nl__0).getHashValue()["name"].clone();
//line 378
___nl__4 = new ImmString("FALSE").clone();
//line 378
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__4.toString())).clone();
//line 378
___nl__4 = null;
//line 378
label_5:
//line 378
___nl__3 = null;
//line 378
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 378
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_4;}}
//line 379
___nl__3 = new ImmString("c_rt_lib_NL.NL_get_false()").clone();
//line 379
___nl__1 = ___nl__3.clone();
//line 379
___nl__3 = null;
//line 380
if (true) {goto label_1;}
//line 380
label_4:
//line 381
___nl__3 = ((ImmHash)___nl__0).getHashValue()["src"].clone();
//line 381
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("arg")).clone();
//line 381
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_7;}}
//line 383
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("emp")).clone();
//line 383
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_8;}}
//line 383
___nl__4 = new ImmString("NOMATCHALERT").clone();
//line 383
___nl__4 = new ImmArray(new Imm[] {___nl__4,___nl__3,}).clone();
//line 383
c_rt_lib_NL.NL_die();
//line 381
label_7:
//line 381
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("arg")).clone();
//line 382
___nl__6 = new ImmString("c_rt_lib_NL.NL_ov_mk_arg(new ImmString(\"").clone();
//line 382
___nl__8 = ((ImmHash)___nl__0).getHashValue()["name"].clone();
//line 382
___nl__7 = generator_cs_NL.NL_escape_string_priv(___nl__8).clone();

//line 382
___nl__8 = null;
//line 382
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 382
___nl__7 = null;
//line 382
___nl__7 = new ImmString("\"), ").clone();
//line 382
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 382
___nl__7 = null;
//line 382
___nl__7 = generator_cs_NL.NL_print_register_priv(___nl__5).clone();

//line 382
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 382
___nl__7 = null;
//line 382
___nl__7 = new ImmString(")").clone();
//line 382
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString()).clone();
//line 382
___nl__7 = null;
//line 382
___nl__1 = ___nl__6.clone();
//line 382
___nl__6 = null;
//line 382
___nl__5 = null;
//line 383
if (true) {goto label_6;}
//line 383
label_8:
//line 384
___nl__5 = new ImmString("c_rt_lib_NL.NL_ov_mk_none(new ImmString(\"").clone();
//line 384
___nl__7 = ((ImmHash)___nl__0).getHashValue()["name"].clone();
//line 384
___nl__6 = generator_cs_NL.NL_escape_string_priv(___nl__7).clone();

//line 384
___nl__7 = null;
//line 384
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 384
___nl__6 = null;
//line 384
___nl__6 = new ImmString("\"))").clone();
//line 384
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString()).clone();
//line 384
___nl__6 = null;
//line 384
___nl__1 = ___nl__5.clone();
//line 384
___nl__5 = null;
//line 385
if (true) {goto label_6;}
//line 385
label_6:
//line 385
___nl__3 = null;
//line 385
___nl__4 = null;
//line 386
if (true) {goto label_1;}
//line 386
label_1:
//line 386
___nl__2 = null;
//line 387
___nl__3 = ((ImmHash)___nl__0).getHashValue()["dest"].clone();
//line 387
___nl__2 = generator_cs_NL.NL_print_register_setter_priv(___nl__3,___nl__1).clone();

//line 387
___nl__3 = null;
//line 387
___nl__3 = new ImmString(";").clone();
//line 387
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 387
___nl__3 = null;
//line 387
___nl__0 = null;
//line 387
___nl__1 = null;
//line 387
if(true) return ___nl__2;
//line 387
___nl__2 = null;
//line 387
___nl__1 = null;
//line 387
___nl__0 = null;
//line 387
if(true) return null;
}

private static Imm NL_print_register_priv(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 391
___nl__1 = new ImmString("___nl__").clone();
//line 391
___nl__1 = new ImmString(___nl__1.toString() + ___nl__0.toString()).clone();
//line 391
___nl__0 = null;
//line 391
if(true) return ___nl__1;
//line 391
___nl__1 = null;
//line 391
___nl__0 = null;
//line 391
if(true) return null;
}

private static Imm NL_SINGLETON_print_getter_priv() {

Imm ___nl__0 = null;
Dictionary<String, Imm> __function_map;
//line 395
___nl__0 = new ImmString(".getValue()").clone();
//line 395
if(true) return ___nl__0;
//line 395
___nl__0 = null;
//line 395
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
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 399
___nl__2 = new ImmString("").clone();
//line 399
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__2.toString())).clone();
//line 399
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 399
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 399
___nl__3 = new ImmString("").clone();
//line 399
___nl__3 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
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
if (true) {goto label_2;}
//line 399
label_2:
//line 399
___nl__2 = null;
//line 400
___nl__2 = new ImmString("null").clone();
//line 400
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__1.toString().Equals(___nl__2.toString())).clone();
//line 400
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 400
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_4;}}
//line 400
___nl__3 = generator_cs_NL.NL_print_register_priv(___nl__0).clone();

//line 400
___nl__4 = new ImmString(" = ").clone();
//line 400
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 400
___nl__4 = null;
//line 400
___nl__3 = new ImmString(___nl__3.toString() + ___nl__1.toString()).clone();
//line 400
___nl__0 = null;
//line 400
___nl__1 = null;
//line 400
___nl__2 = null;
//line 400
if(true) return ___nl__3;
//line 400
___nl__3 = null;
//line 400
if (true) {goto label_4;}
//line 400
label_4:
//line 400
___nl__2 = null;
//line 401
___nl__2 = generator_cs_NL.NL_print_register_priv(___nl__0).clone();

//line 401
___nl__3 = new ImmString(" = ").clone();
//line 401
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 401
___nl__3 = null;
//line 401
___nl__2 = new ImmString(___nl__2.toString() + ___nl__1.toString()).clone();
//line 401
___nl__3 = new ImmString(".clone()").clone();
//line 401
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 401
___nl__3 = null;
//line 401
___nl__0 = null;
//line 401
___nl__1 = null;
//line 401
if(true) return ___nl__2;
//line 401
___nl__2 = null;
//line 401
___nl__0 = null;
//line 401
___nl__1 = null;
//line 401
if(true) return null;
}

private static Imm NL_print_return_priv(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Dictionary<String, Imm> __function_map;
//line 405
___nl__1 = new ImmString("").clone();
//line 406
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("val")).clone();
//line 406
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 408
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("emp")).clone();
//line 408
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_3;}}
//line 408
___nl__2 = new ImmString("NOMATCHALERT").clone();
//line 408
___nl__2 = new ImmArray(new Imm[] {___nl__2,___nl__0,}).clone();
//line 408
c_rt_lib_NL.NL_die();
//line 406
label_2:
//line 406
___nl__3 = c_rt_lib_NL.NL_ov_as(___nl__0, new ImmString("val")).clone();
//line 407
___nl__4 = new ImmString("return ").clone();
//line 407
___nl__5 = generator_cs_NL.NL_print_register_priv(___nl__3).clone();

//line 407
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 407
___nl__5 = null;
//line 407
___nl__5 = new ImmString(";").clone();
//line 407
___nl__4 = new ImmString(___nl__4.toString() + ___nl__5.toString()).clone();
//line 407
___nl__5 = null;
//line 407
___nl__1 = ___nl__4.clone();
//line 407
___nl__4 = null;
//line 407
___nl__3 = null;
//line 408
if (true) {goto label_1;}
//line 408
label_3:
//line 409
___nl__3 = new ImmString("return null;").clone();
//line 409
___nl__1 = ___nl__3.clone();
//line 409
___nl__3 = null;
//line 410
if (true) {goto label_1;}
//line 410
label_1:
//line 410
___nl__2 = null;
//line 411
___nl__2 = new ImmString("if(true) ").clone();
//line 411
___nl__2 = new ImmString(___nl__2.toString() + ___nl__1.toString()).clone();
//line 411
___nl__0 = null;
//line 411
___nl__1 = null;
//line 411
if(true) return ___nl__2;
//line 411
___nl__2 = null;
//line 411
___nl__1 = null;
//line 411
___nl__0 = null;
//line 411
if(true) return null;
}

private static Imm NL_print_una_op_priv(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Dictionary<String, Imm> __function_map;
//line 415
___nl__1 = new ImmString("").clone();
//line 416
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 416
___nl__3 = new ImmString("!").clone();
//line 416
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString())).clone();
//line 416
___nl__3 = null;
//line 416
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 416
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 417
___nl__3 = new ImmString("c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(").clone();
//line 417
___nl__5 = ((ImmHash)___nl__0).getHashValue()["src"].clone();
//line 417
___nl__4 = generator_cs_NL.NL_print_register_priv(___nl__5).clone();

//line 417
___nl__5 = null;
//line 417
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 417
___nl__4 = null;
//line 417
___nl__4 = new ImmString("))").clone();
//line 417
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 417
___nl__4 = null;
//line 417
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 417
___nl__3 = null;
//line 418
if (true) {goto label_1;}
//line 418
label_2:
//line 419
___nl__3 = new ImmString("new ImmDouble(").clone();
//line 419
___nl__4 = ((ImmHash)___nl__0).getHashValue()["op"].clone();
//line 419
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 419
___nl__4 = null;
//line 419
___nl__4 = new ImmString("((ImmDouble)").clone();
//line 419
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 419
___nl__4 = null;
//line 419
___nl__5 = ((ImmHash)___nl__0).getHashValue()["src"].clone();
//line 419
___nl__4 = generator_cs_NL.NL_print_register_priv(___nl__5).clone();

//line 419
___nl__5 = null;
//line 419
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 419
___nl__4 = null;
//line 419
___nl__4 = new ImmString(").getDoubleValue())").clone();
//line 419
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 419
___nl__4 = null;
//line 419
___nl__1 = new ImmString(___nl__1.toString() + ___nl__3.toString()).clone();
//line 419
___nl__3 = null;
//line 420
if (true) {goto label_1;}
//line 420
label_1:
//line 420
___nl__2 = null;
//line 421
___nl__3 = ((ImmHash)___nl__0).getHashValue()["dest"].clone();
//line 421
___nl__2 = generator_cs_NL.NL_print_register_setter_priv(___nl__3,___nl__1).clone();

//line 421
___nl__3 = null;
//line 421
___nl__3 = new ImmString(";").clone();
//line 421
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 421
___nl__3 = null;
//line 421
___nl__0 = null;
//line 421
___nl__1 = null;
//line 421
if(true) return ___nl__2;
//line 421
___nl__2 = null;
//line 421
___nl__1 = null;
//line 421
___nl__0 = null;
//line 421
if(true) return null;
}

}
}