using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class generator_pm_NL {

public static Imm NL_SINGLETON_fun_args_t() {

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
//line 16
___nl__3 = ptd_NL.NL_none();

//line 16
___nl__4 = ptd_NL.NL_none();

//line 16
__function_map = new Dictionary<String, Imm>();
__function_map.Add("val",___nl__3);
__function_map.Add("ref",___nl__4);
___nl__2 = new ImmHash(__function_map);
//line 16
___nl__3 = null;
//line 16
___nl__4 = null;
//line 16
___nl__1 = ptd_NL.NL_var(___nl__2);

//line 16
___nl__2 = null;
//line 16
___nl__0 = ptd_NL.NL_arr(___nl__1);

//line 16
___nl__1 = null;
//line 16
if(true) return ___nl__0;
//line 16
___nl__0 = null;
//line 16
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_fun_args_t = null;
public static Imm NL_fun_args_t() {
	if (value__singleton__NL_SINGLETON_fun_args_t == null) {
		value__singleton__NL_SINGLETON_fun_args_t = NL_SINGLETON_fun_args_t();
	}
	return value__singleton__NL_SINGLETON_fun_args_t;
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
//line 19
___nl__2 = ptd_NL.NL_sim();

//line 19
___nl__3 = ptd_NL.NL_sim();

//line 19
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("generator_pm_NL"));
__function_map.Add("name",new ImmString("fun_args_t"));
___nl__4 = new ImmHash(__function_map);
//line 19
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__4);
//line 19
__function_map = new Dictionary<String, Imm>();
__function_map.Add("perl_file",___nl__2);
__function_map.Add("module_name",___nl__3);
__function_map.Add("fun_args",___nl__4);
___nl__1 = new ImmHash(__function_map);
//line 19
___nl__2 = null;
//line 19
___nl__3 = null;
//line 19
___nl__4 = null;
//line 19
___nl__0 = ptd_NL.NL_rec(___nl__1);

//line 19
___nl__1 = null;
//line 19
if(true) return ___nl__0;
//line 19
___nl__0 = null;
//line 19
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_state_t = null;
public static Imm NL_state_t() {
	if (value__singleton__NL_SINGLETON_state_t == null) {
		value__singleton__NL_SINGLETON_state_t = NL_SINGLETON_state_t();
	}
	return value__singleton__NL_SINGLETON_state_t;
}
private static Imm NL_print_priv(ImmRef ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 27
___nl__2 = new ImmString("perl_file");
//line 27
___nl__2 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__2);

//line 27
___nl__2 = new ImmString(___nl__2.toString() + ___nl__1.toString());
//line 27
___nl__3 = new ImmString("perl_file");
//line 27
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__3,___nl__2);
___nl__0 = ___ref______nl__0.getValue();

//line 27
___nl__3 = null;
//line 27
___nl__2 = null;
//line 27
___nl__1 = null;
//line 27
___arg__0.setValue(___nl__0);if(true) return null;
}

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
//line 31
___nl__2 = new ImmString("");
//line 31
___nl__3 = ((ImmHash)___nl__0).getHashValue()["module_name"];
//line 31
___nl__4 = new ImmArray(new Imm[0]);
//line 31
__function_map = new Dictionary<String, Imm>();
__function_map.Add("perl_file",___nl__2);
__function_map.Add("module_name",___nl__3);
__function_map.Add("fun_args",___nl__4);
___nl__1 = new ImmHash(__function_map);
//line 31
___nl__2 = null;
//line 31
___nl__3 = null;
//line 31
___nl__4 = null;
//line 36
___nl__2 = new ImmString("use c_rt_lib;");
//line 36
___nl__3 = string_NL.NL_lf();

//line 36
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 36
___nl__3 = null;
//line 36
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__2);
___nl__1 = ___ref______nl__1.getValue();

//line 36
___nl__2 = null;
//line 37
___nl__2 = ((ImmHash)___nl__0).getHashValue()["imports"];
//line 37
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_imports_priv(___nl__2,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 37
___nl__2 = null;
//line 38
___nl__2 = ((ImmHash)___nl__0).getHashValue()["functions"];
//line 38
___nl__4 = new ImmDouble(0);
//line 38
___nl__5 = new ImmDouble(1);
//line 38
___nl__6 = c_rt_lib_NL.NL_array_len(___nl__2);

//line 38
label_3:
//line 38
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) );
//line 38
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_1;}}
//line 38
___nl__3 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()];
//line 39
___nl__8 = new ImmString("sub ");
//line 39
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__8);
___nl__1 = ___ref______nl__1.getValue();

//line 39
___nl__8 = null;
//line 40
___nl__8 = ((ImmHash)___nl__3).getHashValue()["access"];
//line 40
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_function_access_priv(___nl__8,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 40
___nl__8 = null;
//line 41
___nl__8 = ((ImmHash)___nl__3).getHashValue()["name"];
//line 41
___nl__9 = new ImmString(";");
//line 41
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 41
___nl__9 = null;
//line 41
___nl__9 = string_NL.NL_lf();

//line 41
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 41
___nl__9 = null;
//line 41
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__8);
___nl__1 = ___ref______nl__1.getValue();

//line 41
___nl__8 = null;
//line 42
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString())));
//line 42
if (true) {goto label_3;}
//line 42
label_1:
//line 42
___nl__2 = null;
//line 42
___nl__3 = null;
//line 42
___nl__4 = null;
//line 42
___nl__5 = null;
//line 42
___nl__6 = null;
//line 42
___nl__7 = null;
//line 43
___nl__2 = string_NL.NL_lf();

//line 43
___nl__3 = new ImmString("return 1;");
//line 43
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 43
___nl__3 = null;
//line 43
___nl__3 = string_NL.NL_lf();

//line 43
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 43
___nl__3 = null;
//line 43
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__2);
___nl__1 = ___ref______nl__1.getValue();

//line 43
___nl__2 = null;
//line 44
___nl__2 = ((ImmHash)___nl__0).getHashValue()["functions"];
//line 44
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_functions_priv(___nl__2,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 44
___nl__2 = null;
//line 45
___nl__2 = ((ImmHash)___nl__1).getHashValue()["perl_file"];
//line 45
___nl__0 = null;
//line 45
___nl__1 = null;
//line 45
if(true) return ___nl__2;
//line 45
___nl__2 = null;
//line 45
___nl__1 = null;
//line 45
___nl__0 = null;
//line 45
if(true) return null;
}

private static Imm NL_print_imports_priv(Imm ___arg__0, ImmRef ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();
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
//line 49
___nl__3 = new ImmDouble(0);
//line 49
___nl__4 = new ImmDouble(1);
//line 49
___nl__5 = c_rt_lib_NL.NL_array_len(___nl__0);

//line 49
label_3:
//line 49
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))>=(Double.Parse(___nl__5.getValue().ToString())) );
//line 49
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_1;}}
//line 49
___nl__2 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__3).getDoubleValue()];
//line 50
___nl__7 = new ImmString("use ");
//line 50
___nl__7 = new ImmString(___nl__7.toString() + ___nl__2.toString());
//line 50
___nl__8 = new ImmString(";");
//line 50
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 50
___nl__8 = null;
//line 50
___nl__8 = string_NL.NL_lf();

//line 50
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 50
___nl__8 = null;
//line 50
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__7);
___nl__1 = ___ref______nl__1.getValue();

//line 50
___nl__7 = null;
//line 51
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString())));
//line 51
if (true) {goto label_3;}
//line 51
label_1:
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
___nl__0 = null;
//line 51
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_print_functions_priv(Imm ___arg__0, ImmRef ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();
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
//line 55
___nl__3 = new ImmDouble(0);
//line 55
___nl__4 = new ImmDouble(1);
//line 55
___nl__5 = c_rt_lib_NL.NL_array_len(___nl__0);

//line 55
label_3:
//line 55
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))>=(Double.Parse(___nl__5.getValue().ToString())) );
//line 55
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_1;}}
//line 55
___nl__2 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__3).getDoubleValue()];
//line 56
___nl__7 = generator_pm_NL.NL_is_singleton_use_function_priv(___nl__2);

//line 56
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7));
//line 56
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_5;}}
//line 57
___nl__8 = ((ImmHash)___nl__2).getHashValue()["name"];
//line 58
___nl__9 = ___nl__2;
//line 59
___nl__10 = new ImmString("__");
//line 59
___nl__10 = new ImmString(___nl__10.toString() + ___nl__8.toString());
//line 59
___nl__11 = ___nl__10;
//line 59
((ImmHash)___nl__9).set("name", ___nl__11);
//line 59
___nl__10 = null;
//line 59
___nl__11 = null;
//line 60
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_function_priv(___nl__9,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 61
___nl__11 = ((ImmHash)___nl__9).getHashValue()["access"];
//line 61
___nl__12 = ((ImmHash)___nl__1).getHashValue()["module_name"];
//line 61
___nl__10 = generator_pm_NL.NL_get_function_access_priv(___nl__11,___nl__12);

//line 61
___nl__12 = null;
//line 61
___nl__11 = null;
//line 61
___nl__11 = ((ImmHash)___nl__9).getHashValue()["name"];
//line 61
___nl__10 = new ImmString(___nl__10.toString() + ___nl__11.toString());
//line 61
___nl__11 = null;
//line 63
___nl__11 = string_NL.NL_lf();

//line 63
___nl__12 = new ImmString("my $_");
//line 63
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString());
//line 63
___nl__12 = null;
//line 63
___nl__11 = new ImmString(___nl__11.toString() + ___nl__8.toString());
//line 63
___nl__12 = new ImmString(";");
//line 63
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString());
//line 63
___nl__12 = null;
//line 63
___nl__12 = string_NL.NL_lf();

//line 63
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString());
//line 63
___nl__12 = null;
//line 63
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__11);
___nl__1 = ___ref______nl__1.getValue();

//line 63
___nl__11 = null;
//line 64
___nl__11 = new ImmString("sub ");
//line 64
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__11);
___nl__1 = ___ref______nl__1.getValue();

//line 64
___nl__11 = null;
//line 65
___nl__11 = ((ImmHash)___nl__9).getHashValue()["access"];
//line 65
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_function_access_priv(___nl__11,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 65
___nl__11 = null;
//line 66
___nl__11 = new ImmString("() {");
//line 66
___nl__11 = new ImmString(___nl__8.toString() + ___nl__11.toString());
//line 66
___nl__12 = string_NL.NL_lf();

//line 66
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString());
//line 66
___nl__12 = null;
//line 66
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__11);
___nl__1 = ___ref______nl__1.getValue();

//line 66
___nl__11 = null;
//line 67
___nl__11 = new ImmString("	$_");
//line 67
___nl__11 = new ImmString(___nl__11.toString() + ___nl__8.toString());
//line 67
___nl__12 = new ImmString(" = ");
//line 67
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString());
//line 67
___nl__12 = null;
//line 67
___nl__11 = new ImmString(___nl__11.toString() + ___nl__10.toString());
//line 67
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__11);
___nl__1 = ___ref______nl__1.getValue();

//line 67
___nl__11 = null;
//line 68
___nl__11 = new ImmString("() unless defined ");
//line 68
___nl__12 = new ImmString("$_");
//line 68
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString());
//line 68
___nl__12 = null;
//line 68
___nl__11 = new ImmString(___nl__11.toString() + ___nl__8.toString());
//line 68
___nl__12 = new ImmString(";");
//line 68
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString());
//line 68
___nl__12 = null;
//line 68
___nl__12 = string_NL.NL_lf();

//line 68
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString());
//line 68
___nl__12 = null;
//line 68
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__11);
___nl__1 = ___ref______nl__1.getValue();

//line 68
___nl__11 = null;
//line 69
___nl__11 = new ImmString("	return $_");
//line 69
___nl__11 = new ImmString(___nl__11.toString() + ___nl__8.toString());
//line 69
___nl__12 = new ImmString(";");
//line 69
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString());
//line 69
___nl__12 = null;
//line 69
___nl__12 = string_NL.NL_lf();

//line 69
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString());
//line 69
___nl__12 = null;
//line 69
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__11);
___nl__1 = ___ref______nl__1.getValue();

//line 69
___nl__11 = null;
//line 70
___nl__11 = new ImmString("}");
//line 70
___nl__12 = string_NL.NL_lf();

//line 70
___nl__11 = new ImmString(___nl__11.toString() + ___nl__12.toString());
//line 70
___nl__12 = null;
//line 70
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__11);
___nl__1 = ___ref______nl__1.getValue();

//line 70
___nl__11 = null;
//line 70
___nl__8 = null;
//line 70
___nl__9 = null;
//line 70
___nl__10 = null;
//line 71
if (true) {goto label_4;}
//line 71
label_5:
//line 72
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_function_priv(___nl__2,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 73
if (true) {goto label_4;}
//line 73
label_4:
//line 73
___nl__7 = null;
//line 74
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString())));
//line 74
if (true) {goto label_3;}
//line 74
label_1:
//line 74
___nl__2 = null;
//line 74
___nl__3 = null;
//line 74
___nl__4 = null;
//line 74
___nl__5 = null;
//line 74
___nl__6 = null;
//line 74
___nl__0 = null;
//line 74
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_print_function_priv(Imm ___arg__0, ImmRef ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();
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
//line 78
___nl__2 = ((ImmHash)___nl__0).getHashValue()["args_type"];
//line 78
___nl__3 = ___nl__2;
//line 78
((ImmHash)___nl__1).set("fun_args", ___nl__3);
//line 78
___nl__2 = null;
//line 78
___nl__3 = null;
//line 79
___nl__2 = string_NL.NL_lf();

//line 79
___nl__3 = new ImmString("sub ");
//line 79
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 79
___nl__3 = null;
//line 79
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__2);
___nl__1 = ___ref______nl__1.getValue();

//line 79
___nl__2 = null;
//line 80
___nl__2 = ((ImmHash)___nl__0).getHashValue()["access"];
//line 80
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_function_access_priv(___nl__2,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 80
___nl__2 = null;
//line 81
___nl__2 = ((ImmHash)___nl__0).getHashValue()["name"];
//line 81
___nl__3 = new ImmString("(");
//line 81
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 81
___nl__3 = null;
//line 81
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__2);
___nl__1 = ___ref______nl__1.getValue();

//line 81
___nl__2 = null;
//line 82
___nl__3 = ((ImmHash)___nl__0).getHashValue()["args_type"];
//line 82
___nl__2 = array_NL.NL_len(___nl__3);

//line 82
___nl__3 = null;
//line 82
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_args_dollar_priv(___nl__2,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 82
___nl__2 = null;
//line 83
___nl__2 = new ImmString(") {");
//line 83
___nl__3 = string_NL.NL_lf();

//line 83
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 83
___nl__3 = null;
//line 83
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__2);
___nl__1 = ___ref______nl__1.getValue();

//line 83
___nl__2 = null;
//line 84
___nl__2 = ((ImmHash)___nl__0).getHashValue()["reg_size"];
//line 84
___nl__3 = new ImmDouble(0);
//line 84
___nl__4 = new ImmDouble(1);
//line 84
label_3:
//line 84
___nl__5 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))>=(Double.Parse(___nl__2.getValue().ToString())) );
//line 84
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_1;}}
//line 85
___nl__6 = new ImmString("my $memory_");
//line 85
___nl__6 = new ImmString(___nl__6.toString() + ___nl__3.toString());
//line 85
___nl__7 = new ImmString(";");
//line 85
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 85
___nl__7 = null;
//line 85
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__6);
___nl__1 = ___ref______nl__1.getValue();

//line 85
___nl__6 = null;
//line 86
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString())));
//line 86
if (true) {goto label_3;}
//line 86
label_1:
//line 86
___nl__2 = null;
//line 86
___nl__3 = null;
//line 86
___nl__4 = null;
//line 86
___nl__5 = null;
//line 87
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_move_args_to_register_priv(___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 88
___nl__2 = string_NL.NL_lf();

//line 88
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__2);
___nl__1 = ___ref______nl__1.getValue();

//line 88
___nl__2 = null;
//line 89
___nl__2 = ((ImmHash)___nl__0).getHashValue()["commands"];
//line 89
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_commands_priv(___nl__2,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 89
___nl__2 = null;
//line 90
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_move_register_to_ref_args_priv(___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 91
___nl__2 = new ImmString("}");
//line 91
___nl__3 = string_NL.NL_lf();

//line 91
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 91
___nl__3 = null;
//line 91
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__2);
___nl__1 = ___ref______nl__1.getValue();

//line 91
___nl__2 = null;
//line 91
___nl__0 = null;
//line 91
___arg__1.setValue(___nl__1);if(true) return null;
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
//line 94
___nl__2 = ((ImmHash)___nl__0).getHashValue()["args_type"];
//line 94
___nl__1 = array_NL.NL_len(___nl__2);

//line 94
___nl__2 = null;
//line 94
___nl__2 = new ImmDouble(0);
//line 94
___nl__1 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__1.getValue().ToString()))>(Double.Parse(___nl__2.getValue().ToString())) );
//line 94
___nl__2 = null;
//line 94
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1));
//line 94
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_2;}}
//line 94
___nl__2 = c_rt_lib_NL.NL_get_false();
//line 94
___nl__0 = null;
//line 94
___nl__1 = null;
//line 94
if(true) return ___nl__2;
//line 94
___nl__2 = null;
//line 94
if (true) {goto label_2;}
//line 94
label_2:
//line 94
___nl__1 = null;
//line 95
___nl__1 = ((ImmHash)___nl__0).getHashValue()["annotation"];
//line 95
___nl__1 = c_rt_lib_NL.NL_ov_is(___nl__1, new ImmString("math"));
//line 95
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1));
//line 95
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_4;}}
//line 95
___nl__2 = c_rt_lib_NL.NL_get_true();
//line 95
___nl__0 = null;
//line 95
___nl__1 = null;
//line 95
if(true) return ___nl__2;
//line 95
___nl__2 = null;
//line 95
if (true) {goto label_4;}
//line 95
label_4:
//line 95
___nl__1 = null;
//line 96
___nl__1 = c_rt_lib_NL.NL_get_false();
//line 98
___nl__3 = ((ImmHash)___nl__0).getHashValue()["commands"];
//line 98
___nl__5 = new ImmDouble(0);
//line 98
___nl__6 = new ImmDouble(1);
//line 98
___nl__7 = c_rt_lib_NL.NL_array_len(___nl__3);

//line 98
label_7:
//line 98
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) );
//line 98
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_5;}}
//line 98
___nl__4 = (___nl__3 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()];
//line 99
___nl__9 = ((ImmHash)___nl__4).getHashValue()["cmd"];
//line 100
___nl__10 = ___nl__9;
//line 100
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__10, new ImmString("call"));
//line 100
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10));
//line 100
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_9;}}
//line 101
___nl__11 = ___nl__9;
//line 101
___nl__11 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("call"));
//line 102
___nl__12 = ((ImmHash)___nl__11).getHashValue()["fun_name"];
//line 102
___nl__13 = new ImmString("sigleton_do_not_use_without_approval");
//line 102
___nl__12 = c_rt_lib_NL.NL_native_to_nl(___nl__12.toString().Equals(___nl__13.toString()));
//line 102
___nl__13 = null;
//line 102
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12));
//line 102
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12));
//line 102
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_11;}}
//line 102
___nl__9 = null;
//line 102
___nl__10 = null;
//line 102
___nl__11 = null;
//line 102
___nl__12 = null;
//line 102
if (true) {goto label_6;}
//line 102
if (true) {goto label_11;}
//line 102
label_11:
//line 102
___nl__12 = null;
//line 103
___nl__12 = ((ImmHash)___nl__11).getHashValue()["mod"];
//line 103
___nl__13 = new ImmString("singleton");
//line 103
___nl__12 = c_rt_lib_NL.NL_native_to_nl(___nl__12.toString().Equals(___nl__13.toString()));
//line 103
___nl__13 = null;
//line 103
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12));
//line 103
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12));
//line 103
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_13;}}
//line 103
___nl__9 = null;
//line 103
___nl__10 = null;
//line 103
___nl__11 = null;
//line 103
___nl__12 = null;
//line 103
if (true) {goto label_6;}
//line 103
if (true) {goto label_13;}
//line 103
label_13:
//line 103
___nl__12 = null;
//line 104
___nl__12 = c_rt_lib_NL.NL_get_true();
//line 104
___nl__1 = ___nl__12;
//line 104
___nl__12 = null;
//line 105
___nl__12 = ((ImmHash)___nl__11).getHashValue()["dest"];
//line 105
___nl__2 = ___nl__12;
//line 105
___nl__12 = null;
//line 105
___nl__11 = null;
//line 106
if (true) {goto label_8;}
//line 106
label_9:
//line 106
___nl__10 = ___nl__9;
//line 106
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__10, new ImmString("return"));
//line 106
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10));
//line 106
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_14;}}
//line 107
___nl__11 = ___nl__1;
//line 107
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11));
//line 107
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11));
//line 107
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_16;}}
//line 107
___nl__12 = c_rt_lib_NL.NL_get_false();
//line 107
___nl__0 = null;
//line 107
___nl__1 = null;
//line 107
___nl__2 = null;
//line 107
___nl__3 = null;
//line 107
___nl__4 = null;
//line 107
___nl__5 = null;
//line 107
___nl__6 = null;
//line 107
___nl__7 = null;
//line 107
___nl__8 = null;
//line 107
___nl__9 = null;
//line 107
___nl__10 = null;
//line 107
___nl__11 = null;
//line 107
if(true) return ___nl__12;
//line 107
___nl__12 = null;
//line 107
if (true) {goto label_16;}
//line 107
label_16:
//line 107
___nl__11 = null;
//line 108
___nl__11 = ___nl__9;
//line 108
___nl__11 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("return"));
//line 109
___nl__12 = ___nl__11;
//line 109
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__12, new ImmString("val"));
//line 109
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12));
//line 109
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12));
//line 109
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_18;}}
//line 109
___nl__13 = c_rt_lib_NL.NL_get_false();
//line 109
___nl__0 = null;
//line 109
___nl__1 = null;
//line 109
___nl__2 = null;
//line 109
___nl__3 = null;
//line 109
___nl__4 = null;
//line 109
___nl__5 = null;
//line 109
___nl__6 = null;
//line 109
___nl__7 = null;
//line 109
___nl__8 = null;
//line 109
___nl__9 = null;
//line 109
___nl__10 = null;
//line 109
___nl__11 = null;
//line 109
___nl__12 = null;
//line 109
if(true) return ___nl__13;
//line 109
___nl__13 = null;
//line 109
if (true) {goto label_18;}
//line 109
label_18:
//line 109
___nl__12 = null;
//line 110
___nl__12 = ___nl__11;
//line 110
___nl__12 = c_rt_lib_NL.NL_ov_as(___nl__12, new ImmString("val"));
//line 110
___nl__12 = c_rt_lib_NL.NL_native_to_nl(___nl__12.toString().Equals(___nl__2.toString()));
//line 110
___nl__0 = null;
//line 110
___nl__1 = null;
//line 110
___nl__2 = null;
//line 110
___nl__3 = null;
//line 110
___nl__4 = null;
//line 110
___nl__5 = null;
//line 110
___nl__6 = null;
//line 110
___nl__7 = null;
//line 110
___nl__8 = null;
//line 110
___nl__9 = null;
//line 110
___nl__10 = null;
//line 110
___nl__11 = null;
//line 110
if(true) return ___nl__12;
//line 110
___nl__12 = null;
//line 110
___nl__11 = null;
//line 111
if (true) {goto label_8;}
//line 111
label_14:
//line 111
___nl__10 = ___nl__9;
//line 111
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__10, new ImmString("prt_lbl"));
//line 111
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10));
//line 111
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_19;}}
//line 112
if (true) {goto label_8;}
//line 112
label_19:
//line 112
___nl__10 = ___nl__9;
//line 112
___nl__10 = c_rt_lib_NL.NL_ov_is(___nl__10, new ImmString("clear"));
//line 112
___nl__10 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__10));
//line 112
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_20;}}
//line 113
if (true) {goto label_8;}
//line 113
label_20:
//line 114
___nl__11 = ___nl__1;
//line 114
___nl__11 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__11));
//line 114
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_22;}}
//line 114
___nl__12 = c_rt_lib_NL.NL_get_false();
//line 114
___nl__0 = null;
//line 114
___nl__1 = null;
//line 114
___nl__2 = null;
//line 114
___nl__3 = null;
//line 114
___nl__4 = null;
//line 114
___nl__5 = null;
//line 114
___nl__6 = null;
//line 114
___nl__7 = null;
//line 114
___nl__8 = null;
//line 114
___nl__9 = null;
//line 114
___nl__10 = null;
//line 114
___nl__11 = null;
//line 114
if(true) return ___nl__12;
//line 114
___nl__12 = null;
//line 114
if (true) {goto label_22;}
//line 114
label_22:
//line 114
___nl__11 = null;
//line 115
if (true) {goto label_8;}
//line 115
label_8:
//line 115
___nl__10 = null;
//line 115
___nl__9 = null;
//line 115
label_6:
//line 116
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString())));
//line 116
if (true) {goto label_7;}
//line 116
label_5:
//line 116
___nl__3 = null;
//line 116
___nl__4 = null;
//line 116
___nl__5 = null;
//line 116
___nl__6 = null;
//line 116
___nl__7 = null;
//line 116
___nl__8 = null;
//line 117
___nl__3 = c_rt_lib_NL.NL_get_false();
//line 117
___nl__0 = null;
//line 117
___nl__1 = null;
//line 117
___nl__2 = null;
//line 117
if(true) return ___nl__3;
//line 117
___nl__3 = null;
//line 117
___nl__1 = null;
//line 117
___nl__2 = null;
//line 117
___nl__0 = null;
//line 117
if(true) return null;
}

private static Imm NL_print_function_access_priv(Imm ___arg__0, ImmRef ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 122
___nl__3 = ((ImmHash)___nl__1).getHashValue()["module_name"];
//line 122
___nl__2 = generator_pm_NL.NL_get_function_access_priv(___nl__0,___nl__3);

//line 122
___nl__3 = null;
//line 122
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__2);
___nl__1 = ___ref______nl__1.getValue();

//line 122
___nl__2 = null;
//line 122
___nl__0 = null;
//line 122
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_get_function_access_priv(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 126
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("pub"));
//line 126
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 128
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__0, new ImmString("priv"));
//line 128
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_3;}}
//line 128
___nl__2 = new ImmString("NOMATCHALERT");
//line 128
___nl__2 = new ImmArray(new Imm[] {___nl__2,___nl__0,});
//line 128
c_rt_lib_NL.NL_die();
//line 126
label_2:
//line 127
___nl__3 = new ImmString("::");
//line 127
___nl__3 = new ImmString(___nl__1.toString() + ___nl__3.toString());
//line 127
___nl__0 = null;
//line 127
___nl__1 = null;
//line 127
___nl__2 = null;
//line 127
if(true) return ___nl__3;
//line 127
___nl__3 = null;
//line 128
if (true) {goto label_1;}
//line 128
label_3:
//line 129
___nl__3 = new ImmString("_priv::");
//line 129
___nl__3 = new ImmString(___nl__1.toString() + ___nl__3.toString());
//line 129
___nl__0 = null;
//line 129
___nl__1 = null;
//line 129
___nl__2 = null;
//line 129
if(true) return ___nl__3;
//line 129
___nl__3 = null;
//line 130
if (true) {goto label_1;}
//line 130
label_1:
//line 130
___nl__2 = null;
//line 130
___nl__0 = null;
//line 130
___nl__1 = null;
//line 130
if(true) return null;
}

private static Imm NL_print_args_dollar_priv(Imm ___arg__0, ImmRef ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();
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
//line 134
___nl__2 = new ImmDouble(0);
//line 134
___nl__3 = new ImmDouble(1);
//line 134
label_3:
//line 134
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__2.getValue().ToString()))>=(Double.Parse(___nl__0.getValue().ToString())) );
//line 134
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_1;}}
//line 135
___nl__5 = new ImmString("$");
//line 135
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__5);
___nl__1 = ___ref______nl__1.getValue();

//line 135
___nl__5 = null;
//line 136
___nl__2 = new ImmDouble((Double.Parse(___nl__2.getValue().ToString()))+(Double.Parse(___nl__3.getValue().ToString())));
//line 136
if (true) {goto label_3;}
//line 136
label_1:
//line 136
___nl__2 = null;
//line 136
___nl__3 = null;
//line 136
___nl__4 = null;
//line 136
___nl__0 = null;
//line 136
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_move_args_to_register_priv(ImmRef ___arg__0) {
Imm ___nl__0 = ___arg__0.getValue().clone();
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
//line 140
___nl__2 = ((ImmHash)___nl__0).getHashValue()["fun_args"];
//line 140
___nl__1 = array_NL.NL_len(___nl__2);

//line 140
___nl__2 = null;
//line 140
___nl__2 = new ImmDouble(0);
//line 140
___nl__3 = new ImmDouble(1);
//line 140
label_3:
//line 140
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__2.getValue().ToString()))>=(Double.Parse(___nl__1.getValue().ToString())) );
//line 140
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_1;}}
//line 141
___nl__5 = new ImmString("$memory_");
//line 141
___nl__5 = new ImmString(___nl__5.toString() + ___nl__2.toString());
//line 141
___nl__6 = new ImmString(" = $_[");
//line 141
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 141
___nl__6 = null;
//line 141
___nl__5 = new ImmString(___nl__5.toString() + ___nl__2.toString());
//line 141
___nl__6 = new ImmString("];");
//line 141
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 141
___nl__6 = null;
//line 141
___ref______nl__0 = new ImmRef(___nl__0);
generator_pm_NL.NL_print_priv(___ref______nl__0,___nl__5);
___nl__0 = ___ref______nl__0.getValue();

//line 141
___nl__5 = null;
//line 142
___nl__5 = ((ImmHash)___nl__0).getHashValue()["fun_args"];
//line 142
___nl__5 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__2).getDoubleValue()];
//line 142
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("val"));
//line 142
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_5;}}
//line 143
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("ref"));
//line 143
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_6;}}
//line 143
___nl__6 = new ImmString("NOMATCHALERT");
//line 143
___nl__6 = new ImmArray(new Imm[] {___nl__6,___nl__5,});
//line 143
c_rt_lib_NL.NL_die();
//line 142
label_5:
//line 143
if (true) {goto label_4;}
//line 143
label_6:
//line 144
___nl__7 = new ImmString("Scalar::Util::weaken($_[");
//line 144
___nl__7 = new ImmString(___nl__7.toString() + ___nl__2.toString());
//line 144
___nl__8 = new ImmString("]) if ref($_[");
//line 144
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 144
___nl__8 = null;
//line 144
___nl__7 = new ImmString(___nl__7.toString() + ___nl__2.toString());
//line 144
___nl__8 = new ImmString("]);");
//line 144
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 144
___nl__8 = null;
//line 144
___ref______nl__0 = new ImmRef(___nl__0);
generator_pm_NL.NL_print_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 144
___nl__7 = null;
//line 145
if (true) {goto label_4;}
//line 145
label_4:
//line 145
___nl__5 = null;
//line 145
___nl__6 = null;
//line 146
___nl__2 = new ImmDouble((Double.Parse(___nl__2.getValue().ToString()))+(Double.Parse(___nl__3.getValue().ToString())));
//line 146
if (true) {goto label_3;}
//line 146
label_1:
//line 146
___nl__1 = null;
//line 146
___nl__2 = null;
//line 146
___nl__3 = null;
//line 146
___nl__4 = null;
//line 146
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_move_register_to_ref_args_priv(ImmRef ___arg__0) {
Imm ___nl__0 = ___arg__0.getValue().clone();
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
//line 149
___nl__2 = ((ImmHash)___nl__0).getHashValue()["fun_args"];
//line 149
___nl__1 = array_NL.NL_len(___nl__2);

//line 149
___nl__2 = null;
//line 149
___nl__2 = new ImmDouble(0);
//line 149
___nl__3 = new ImmDouble(1);
//line 149
label_3:
//line 149
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__2.getValue().ToString()))>=(Double.Parse(___nl__1.getValue().ToString())) );
//line 149
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_1;}}
//line 150
___nl__5 = ((ImmHash)___nl__0).getHashValue()["fun_args"];
//line 150
___nl__5 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__2).getDoubleValue()];
//line 150
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("val"));
//line 150
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_5;}}
//line 151
___nl__6 = c_rt_lib_NL.NL_ov_is(___nl__5, new ImmString("ref"));
//line 151
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_6;}}
//line 151
___nl__6 = new ImmString("NOMATCHALERT");
//line 151
___nl__6 = new ImmArray(new Imm[] {___nl__6,___nl__5,});
//line 151
c_rt_lib_NL.NL_die();
//line 150
label_5:
//line 151
if (true) {goto label_4;}
//line 151
label_6:
//line 152
___nl__7 = new ImmString("$_[");
//line 152
___nl__7 = new ImmString(___nl__7.toString() + ___nl__2.toString());
//line 152
___nl__8 = new ImmString("] = $memory_");
//line 152
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 152
___nl__8 = null;
//line 152
___nl__7 = new ImmString(___nl__7.toString() + ___nl__2.toString());
//line 152
___nl__8 = new ImmString(";");
//line 152
___nl__7 = new ImmString(___nl__7.toString() + ___nl__8.toString());
//line 152
___nl__8 = null;
//line 152
___ref______nl__0 = new ImmRef(___nl__0);
generator_pm_NL.NL_print_priv(___ref______nl__0,___nl__7);
___nl__0 = ___ref______nl__0.getValue();

//line 152
___nl__7 = null;
//line 153
if (true) {goto label_4;}
//line 153
label_4:
//line 153
___nl__5 = null;
//line 153
___nl__6 = null;
//line 154
___nl__2 = new ImmDouble((Double.Parse(___nl__2.getValue().ToString()))+(Double.Parse(___nl__3.getValue().ToString())));
//line 154
if (true) {goto label_3;}
//line 154
label_1:
//line 154
___nl__1 = null;
//line 154
___nl__2 = null;
//line 154
___nl__3 = null;
//line 154
___nl__4 = null;
//line 154
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_print_commands_priv(Imm ___arg__0, ImmRef ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();
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
//line 157
___nl__3 = new ImmDouble(0);
//line 157
___nl__4 = new ImmDouble(1);
//line 157
___nl__5 = c_rt_lib_NL.NL_array_len(___nl__0);

//line 157
label_3:
//line 157
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))>=(Double.Parse(___nl__5.getValue().ToString())) );
//line 157
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_1;}}
//line 157
___nl__2 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__3).getDoubleValue()];
//line 158
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_command_priv(___nl__2,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 159
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString())));
//line 159
if (true) {goto label_3;}
//line 159
label_1:
//line 159
___nl__2 = null;
//line 159
___nl__3 = null;
//line 159
___nl__4 = null;
//line 159
___nl__5 = null;
//line 159
___nl__6 = null;
//line 159
___nl__0 = null;
//line 159
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_print_command_priv(Imm ___arg__0, ImmRef ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();
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
//line 163
___nl__2 = new ImmString("#line ");
//line 163
___nl__3 = ((ImmHash)___nl__0).getHashValue()["debug"];
//line 163
___nl__3 = ((ImmHash)___nl__3).getHashValue()["nast_debug"];
//line 163
___nl__3 = ((ImmHash)___nl__3).getHashValue()["begin"];
//line 163
___nl__3 = ((ImmHash)___nl__3).getHashValue()["line"];
//line 163
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 163
___nl__3 = null;
//line 163
___nl__3 = string_NL.NL_lf();

//line 163
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 163
___nl__3 = null;
//line 163
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__2);
___nl__1 = ___ref______nl__1.getValue();

//line 163
___nl__2 = null;
//line 164
___nl__2 = ((ImmHash)___nl__0).getHashValue()["cmd"];
//line 164
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("arr_decl"));
//line 164
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 176
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("hash_decl"));
//line 176
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 186
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("call"));
//line 186
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_4;}}
//line 188
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("func"));
//line 188
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_5;}}
//line 194
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("una_op"));
//line 194
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_6;}}
//line 196
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("bin_op"));
//line 196
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_7;}}
//line 198
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("ov_is"));
//line 198
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_8;}}
//line 203
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("ov_as"));
//line 203
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_9;}}
//line 208
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("return"));
//line 208
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_10;}}
//line 217
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("die"));
//line 217
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_11;}}
//line 221
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("move"));
//line 221
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_12;}}
//line 225
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("load_const"));
//line 225
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_13;}}
//line 232
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("get_frm_idx"));
//line 232
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_14;}}
//line 238
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("set_at_idx"));
//line 238
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_15;}}
//line 240
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("get_val"));
//line 240
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_16;}}
//line 244
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("set_val"));
//line 244
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_17;}}
//line 246
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("ov_mk"));
//line 246
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_18;}}
//line 248
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("prt_lbl"));
//line 248
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_19;}}
//line 250
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("if_goto"));
//line 250
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_20;}}
//line 256
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("goto"));
//line 256
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_21;}}
//line 258
___nl__3 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("clear"));
//line 258
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_22;}}
//line 258
___nl__3 = new ImmString("NOMATCHALERT");
//line 258
___nl__3 = new ImmArray(new Imm[] {___nl__3,___nl__2,});
//line 258
c_rt_lib_NL.NL_die();
//line 164
label_2:
//line 164
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("arr_decl"));
//line 165
___nl__5 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 165
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_to_assign_priv(___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 165
___nl__5 = null;
//line 166
___nl__5 = new ImmString("[");
//line 166
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__5);
___nl__1 = ___ref______nl__1.getValue();

//line 166
___nl__5 = null;
//line 167
___nl__5 = new ImmDouble(0);
//line 168
___nl__6 = ((ImmHash)___nl__4).getHashValue()["src"];
//line 168
___nl__8 = new ImmDouble(0);
//line 168
___nl__9 = new ImmDouble(1);
//line 168
___nl__10 = c_rt_lib_NL.NL_array_len(___nl__6);

//line 168
label_25:
//line 168
___nl__11 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__8.getValue().ToString()))>=(Double.Parse(___nl__10.getValue().ToString())) );
//line 168
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_23;}}
//line 168
___nl__7 = (___nl__6 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__8).getDoubleValue()];
//line 169
___nl__12 = new ImmDouble(0);
//line 169
___nl__12 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>(Double.Parse(___nl__12.getValue().ToString())) );
//line 169
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12));
//line 169
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_27;}}
//line 170
___nl__13 = new ImmString(",");
//line 170
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__13);
___nl__1 = ___ref______nl__1.getValue();

//line 170
___nl__13 = null;
//line 171
if (true) {goto label_27;}
//line 171
label_27:
//line 171
___nl__12 = null;
//line 172
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_priv(___nl__7,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 173
___nl__12 = new ImmDouble(1);
//line 173
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__12.getValue().ToString())));
//line 173
___nl__12 = null;
//line 174
___nl__8 = new ImmDouble((Double.Parse(___nl__8.getValue().ToString()))+(Double.Parse(___nl__9.getValue().ToString())));
//line 174
if (true) {goto label_25;}
//line 174
label_23:
//line 174
___nl__6 = null;
//line 174
___nl__7 = null;
//line 174
___nl__8 = null;
//line 174
___nl__9 = null;
//line 174
___nl__10 = null;
//line 174
___nl__11 = null;
//line 175
___nl__6 = new ImmString("];");
//line 175
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__6);
___nl__1 = ___ref______nl__1.getValue();

//line 175
___nl__6 = null;
//line 175
___nl__5 = null;
//line 175
___nl__4 = null;
//line 176
if (true) {goto label_1;}
//line 176
label_3:
//line 176
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("hash_decl"));
//line 177
___nl__5 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 177
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_to_assign_priv(___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 177
___nl__5 = null;
//line 178
___nl__5 = new ImmString("{");
//line 178
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__5);
___nl__1 = ___ref______nl__1.getValue();

//line 178
___nl__5 = null;
//line 179
___nl__5 = ((ImmHash)___nl__4).getHashValue()["src"];
//line 179
___nl__7 = new ImmDouble(0);
//line 179
___nl__8 = new ImmDouble(1);
//line 179
___nl__9 = c_rt_lib_NL.NL_array_len(___nl__5);

//line 179
label_30:
//line 179
___nl__10 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))>=(Double.Parse(___nl__9.getValue().ToString())) );
//line 179
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_28;}}
//line 179
___nl__6 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()];
//line 180
___nl__11 = ((ImmHash)___nl__6).getHashValue()["key"];
//line 180
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__11);
___nl__1 = ___ref______nl__1.getValue();

//line 180
___nl__11 = null;
//line 181
___nl__11 = new ImmString(" => ");
//line 181
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__11);
___nl__1 = ___ref______nl__1.getValue();

//line 181
___nl__11 = null;
//line 182
___nl__11 = ((ImmHash)___nl__6).getHashValue()["val"];
//line 182
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_priv(___nl__11,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 182
___nl__11 = null;
//line 183
___nl__11 = new ImmString(",");
//line 183
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__11);
___nl__1 = ___ref______nl__1.getValue();

//line 183
___nl__11 = null;
//line 184
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString())));
//line 184
if (true) {goto label_30;}
//line 184
label_28:
//line 184
___nl__5 = null;
//line 184
___nl__6 = null;
//line 184
___nl__7 = null;
//line 184
___nl__8 = null;
//line 184
___nl__9 = null;
//line 184
___nl__10 = null;
//line 185
___nl__5 = new ImmString("};");
//line 185
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__5);
___nl__1 = ___ref______nl__1.getValue();

//line 185
___nl__5 = null;
//line 185
___nl__4 = null;
//line 186
if (true) {goto label_1;}
//line 186
label_4:
//line 186
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("call"));
//line 187
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_call_priv(___nl__4,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 187
___nl__4 = null;
//line 188
if (true) {goto label_1;}
//line 188
label_5:
//line 188
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("func"));
//line 189
___nl__5 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 189
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_to_assign_priv(___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 189
___nl__5 = null;
//line 190
___nl__7 = ((ImmHash)___nl__4).getHashValue()["module"];
//line 190
___nl__8 = ((ImmHash)___nl__4).getHashValue()["name"];
//line 190
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",___nl__7);
__function_map.Add("name",___nl__8);
___nl__6 = new ImmHash(__function_map);
//line 190
___nl__7 = null;
//line 190
___nl__8 = null;
//line 190
___nl__5 = dfile_NL.NL_ssave(___nl__6);

//line 190
___nl__6 = null;
//line 190
___nl__6 = new ImmString(";");
//line 190
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 190
___nl__6 = null;
//line 190
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__5);
___nl__1 = ___ref______nl__1.getValue();

//line 190
___nl__5 = null;
//line 190
___nl__4 = null;
//line 194
if (true) {goto label_1;}
//line 194
label_6:
//line 194
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("una_op"));
//line 195
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_una_op_priv(___nl__4,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 195
___nl__4 = null;
//line 196
if (true) {goto label_1;}
//line 196
label_7:
//line 196
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("bin_op"));
//line 197
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_bin_op_priv(___nl__4,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 197
___nl__4 = null;
//line 198
if (true) {goto label_1;}
//line 198
label_8:
//line 198
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("ov_is"));
//line 199
___nl__5 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 199
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_to_assign_priv(___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 199
___nl__5 = null;
//line 200
___nl__5 = new ImmString("c_rt_lib::ov_is(");
//line 200
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__5);
___nl__1 = ___ref______nl__1.getValue();

//line 200
___nl__5 = null;
//line 201
___nl__5 = ((ImmHash)___nl__4).getHashValue()["src"];
//line 201
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_priv(___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 201
___nl__5 = null;
//line 202
___nl__5 = new ImmString(", '");
//line 202
___nl__6 = ((ImmHash)___nl__4).getHashValue()["type"];
//line 202
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 202
___nl__6 = null;
//line 202
___nl__6 = new ImmString("');");
//line 202
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 202
___nl__6 = null;
//line 202
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__5);
___nl__1 = ___ref______nl__1.getValue();

//line 202
___nl__5 = null;
//line 202
___nl__4 = null;
//line 203
if (true) {goto label_1;}
//line 203
label_9:
//line 203
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("ov_as"));
//line 204
___nl__5 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 204
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_to_assign_priv(___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 204
___nl__5 = null;
//line 205
___nl__5 = new ImmString("c_rt_lib::ov_as(");
//line 205
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__5);
___nl__1 = ___ref______nl__1.getValue();

//line 205
___nl__5 = null;
//line 206
___nl__5 = ((ImmHash)___nl__4).getHashValue()["src"];
//line 206
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_priv(___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 206
___nl__5 = null;
//line 207
___nl__5 = new ImmString(", '");
//line 207
___nl__6 = ((ImmHash)___nl__4).getHashValue()["type"];
//line 207
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 207
___nl__6 = null;
//line 207
___nl__6 = new ImmString("');");
//line 207
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 207
___nl__6 = null;
//line 207
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__5);
___nl__1 = ___ref______nl__1.getValue();

//line 207
___nl__5 = null;
//line 207
___nl__4 = null;
//line 208
if (true) {goto label_1;}
//line 208
label_10:
//line 208
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("return"));
//line 209
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_move_register_to_ref_args_priv(___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 210
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("val"));
//line 210
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_32;}}
//line 214
___nl__5 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("emp"));
//line 214
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_33;}}
//line 214
___nl__5 = new ImmString("NOMATCHALERT");
//line 214
___nl__5 = new ImmArray(new Imm[] {___nl__5,___nl__4,});
//line 214
c_rt_lib_NL.NL_die();
//line 210
label_32:
//line 210
___nl__6 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("val"));
//line 211
___nl__7 = new ImmString("return ");
//line 211
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__7);
___nl__1 = ___ref______nl__1.getValue();

//line 211
___nl__7 = null;
//line 212
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_priv(___nl__6,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 213
___nl__7 = new ImmString(";");
//line 213
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__7);
___nl__1 = ___ref______nl__1.getValue();

//line 213
___nl__7 = null;
//line 213
___nl__6 = null;
//line 214
if (true) {goto label_31;}
//line 214
label_33:
//line 215
___nl__6 = new ImmString("return;");
//line 215
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__6);
___nl__1 = ___ref______nl__1.getValue();

//line 215
___nl__6 = null;
//line 216
if (true) {goto label_31;}
//line 216
label_31:
//line 216
___nl__5 = null;
//line 216
___nl__4 = null;
//line 217
if (true) {goto label_1;}
//line 217
label_11:
//line 217
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("die"));
//line 218
___nl__5 = new ImmString("die(dfile::ssave(");
//line 218
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__5);
___nl__1 = ___ref______nl__1.getValue();

//line 218
___nl__5 = null;
//line 219
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_priv(___nl__4,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 220
___nl__5 = new ImmString("));");
//line 220
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__5);
___nl__1 = ___ref______nl__1.getValue();

//line 220
___nl__5 = null;
//line 220
___nl__4 = null;
//line 221
if (true) {goto label_1;}
//line 221
label_12:
//line 221
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("move"));
//line 222
___nl__5 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 222
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_to_assign_priv(___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 222
___nl__5 = null;
//line 223
___nl__5 = ((ImmHash)___nl__4).getHashValue()["src"];
//line 223
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_priv(___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 223
___nl__5 = null;
//line 224
___nl__5 = new ImmString(";");
//line 224
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__5);
___nl__1 = ___ref______nl__1.getValue();

//line 224
___nl__5 = null;
//line 224
___nl__4 = null;
//line 225
if (true) {goto label_1;}
//line 225
label_13:
//line 225
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("load_const"));
//line 226
___nl__5 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 226
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_to_assign_priv(___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 226
___nl__5 = null;
//line 227
___nl__8 = ((ImmHash)___nl__4).getHashValue()["val"];
//line 227
___nl__5 = nl_NL.NL_is_sim(___nl__8);

//line 227
___nl__8 = null;
//line 227
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 227
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_37;}}
//line 227
___nl__8 = ((ImmHash)___nl__4).getHashValue()["val"];
//line 227
___nl__9 = new ImmString("");
//line 227
___nl__8 = new ImmString(___nl__8.toString() + ___nl__9.toString());
//line 227
___nl__9 = null;
//line 227
___nl__5 = string_utils_NL.NL_is_integer(___nl__8);

//line 227
___nl__8 = null;
//line 227
label_37:
//line 227
___nl__7 = null;
//line 227
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 227
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_36;}}
//line 227
___nl__5 = new ImmDouble(0);
//line 227
___nl__7 = ((ImmHash)___nl__4).getHashValue()["val"];
//line 227
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__7.getValue().ToString())));
//line 227
___nl__7 = null;
//line 227
___nl__7 = ((ImmHash)___nl__4).getHashValue()["val"];
//line 227
___nl__5 = c_rt_lib_NL.NL_native_to_nl(___nl__5.toString().Equals(___nl__7.toString()));
//line 227
___nl__7 = null;
//line 227
label_36:
//line 227
___nl__6 = null;
//line 227
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5));
//line 227
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_35;}}
//line 228
___nl__6 = ((ImmHash)___nl__4).getHashValue()["val"];
//line 228
___nl__7 = new ImmString(";");
//line 228
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 228
___nl__7 = null;
//line 228
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__6);
___nl__1 = ___ref______nl__1.getValue();

//line 228
___nl__6 = null;
//line 229
if (true) {goto label_34;}
//line 229
label_35:
//line 230
___nl__7 = ((ImmHash)___nl__4).getHashValue()["val"];
//line 230
___nl__6 = dfile_NL.NL_ssave(___nl__7);

//line 230
___nl__7 = null;
//line 230
___nl__7 = new ImmString(";");
//line 230
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 230
___nl__7 = null;
//line 230
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__6);
___nl__1 = ___ref______nl__1.getValue();

//line 230
___nl__6 = null;
//line 231
if (true) {goto label_34;}
//line 231
label_34:
//line 231
___nl__5 = null;
//line 231
___nl__4 = null;
//line 232
if (true) {goto label_1;}
//line 232
label_14:
//line 232
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("get_frm_idx"));
//line 233
___nl__5 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 233
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_to_assign_priv(___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 233
___nl__5 = null;
//line 234
___nl__5 = ((ImmHash)___nl__4).getHashValue()["src"];
//line 234
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_priv(___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 234
___nl__5 = null;
//line 235
___nl__5 = new ImmString("->[");
//line 235
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__5);
___nl__1 = ___ref______nl__1.getValue();

//line 235
___nl__5 = null;
//line 236
___nl__5 = ((ImmHash)___nl__4).getHashValue()["idx"];
//line 236
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_priv(___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 236
___nl__5 = null;
//line 237
___nl__5 = new ImmString("];");
//line 237
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__5);
___nl__1 = ___ref______nl__1.getValue();

//line 237
___nl__5 = null;
//line 237
___nl__4 = null;
//line 238
if (true) {goto label_1;}
//line 238
label_15:
//line 238
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("set_at_idx"));
//line 239
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_set_at_idx_priv(___nl__4,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 239
___nl__4 = null;
//line 240
if (true) {goto label_1;}
//line 240
label_16:
//line 240
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("get_val"));
//line 241
___nl__5 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 241
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_to_assign_priv(___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 241
___nl__5 = null;
//line 242
___nl__5 = ((ImmHash)___nl__4).getHashValue()["src"];
//line 242
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_priv(___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 242
___nl__5 = null;
//line 243
___nl__5 = new ImmString("->{'");
//line 243
___nl__6 = ((ImmHash)___nl__4).getHashValue()["key"];
//line 243
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 243
___nl__6 = null;
//line 243
___nl__6 = new ImmString("'};");
//line 243
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 243
___nl__6 = null;
//line 243
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__5);
___nl__1 = ___ref______nl__1.getValue();

//line 243
___nl__5 = null;
//line 243
___nl__4 = null;
//line 244
if (true) {goto label_1;}
//line 244
label_17:
//line 244
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("set_val"));
//line 245
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_set_val_priv(___nl__4,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 245
___nl__4 = null;
//line 246
if (true) {goto label_1;}
//line 246
label_18:
//line 246
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("ov_mk"));
//line 247
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_ov_mk_priv(___nl__4,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 247
___nl__4 = null;
//line 248
if (true) {goto label_1;}
//line 248
label_19:
//line 248
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("prt_lbl"));
//line 249
___nl__5 = new ImmString(":");
//line 249
___nl__5 = new ImmString(___nl__4.toString() + ___nl__5.toString());
//line 249
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__5);
___nl__1 = ___ref______nl__1.getValue();

//line 249
___nl__5 = null;
//line 249
___nl__4 = null;
//line 250
if (true) {goto label_1;}
//line 250
label_20:
//line 250
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("if_goto"));
//line 251
___nl__5 = new ImmString("if (c_rt_lib::check_true(");
//line 251
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__5);
___nl__1 = ___ref______nl__1.getValue();

//line 251
___nl__5 = null;
//line 252
___nl__5 = ((ImmHash)___nl__4).getHashValue()["src"];
//line 252
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_priv(___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 252
___nl__5 = null;
//line 253
___nl__5 = new ImmString(")) {");
//line 253
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__5);
___nl__1 = ___ref______nl__1.getValue();

//line 253
___nl__5 = null;
//line 254
___nl__5 = new ImmString("goto ");
//line 254
___nl__6 = ((ImmHash)___nl__4).getHashValue()["dest"];
//line 254
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 254
___nl__6 = null;
//line 254
___nl__6 = new ImmString(";");
//line 254
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 254
___nl__6 = null;
//line 254
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__5);
___nl__1 = ___ref______nl__1.getValue();

//line 254
___nl__5 = null;
//line 255
___nl__5 = new ImmString("}");
//line 255
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__5);
___nl__1 = ___ref______nl__1.getValue();

//line 255
___nl__5 = null;
//line 255
___nl__4 = null;
//line 256
if (true) {goto label_1;}
//line 256
label_21:
//line 256
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("goto"));
//line 257
___nl__5 = new ImmString("goto ");
//line 257
___nl__5 = new ImmString(___nl__5.toString() + ___nl__4.toString());
//line 257
___nl__6 = new ImmString(";");
//line 257
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 257
___nl__6 = null;
//line 257
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__5);
___nl__1 = ___ref______nl__1.getValue();

//line 257
___nl__5 = null;
//line 257
___nl__4 = null;
//line 258
if (true) {goto label_1;}
//line 258
label_22:
//line 258
___nl__4 = c_rt_lib_NL.NL_ov_as(___nl__2, new ImmString("clear"));
//line 259
___nl__5 = new ImmString("undef(");
//line 259
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__5);
___nl__1 = ___ref______nl__1.getValue();

//line 259
___nl__5 = null;
//line 260
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_priv(___nl__4,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 261
___nl__5 = new ImmString(");");
//line 261
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__5);
___nl__1 = ___ref______nl__1.getValue();

//line 261
___nl__5 = null;
//line 261
___nl__4 = null;
//line 262
if (true) {goto label_1;}
//line 262
label_1:
//line 262
___nl__2 = null;
//line 262
___nl__3 = null;
//line 263
___nl__2 = string_NL.NL_lf();

//line 263
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__2);
___nl__1 = ___ref______nl__1.getValue();

//line 263
___nl__2 = null;
//line 263
___nl__0 = null;
//line 263
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_print_call_priv(Imm ___arg__0, ImmRef ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();
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
//line 267
___nl__2 = ((ImmHash)___nl__0).getHashValue()["dest"];
//line 267
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_to_assign_priv(___nl__2,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 267
___nl__2 = null;
//line 268
___nl__2 = ((ImmHash)___nl__0).getHashValue()["mod"];
//line 268
___nl__3 = new ImmString("");
//line 268
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!___nl__2.toString().Equals(___nl__3.toString()));
//line 268
___nl__3 = null;
//line 268
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 268
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 269
___nl__3 = ((ImmHash)___nl__0).getHashValue()["mod"];
//line 269
___nl__4 = new ImmString("::");
//line 269
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 269
___nl__4 = null;
//line 269
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__3);
___nl__1 = ___ref______nl__1.getValue();

//line 269
___nl__3 = null;
//line 270
if (true) {goto label_1;}
//line 270
label_2:
//line 271
___nl__3 = ((ImmHash)___nl__1).getHashValue()["module_name"];
//line 271
___nl__4 = new ImmString("_priv::");
//line 271
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 271
___nl__4 = null;
//line 271
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__3);
___nl__1 = ___ref______nl__1.getValue();

//line 271
___nl__3 = null;
//line 272
if (true) {goto label_1;}
//line 272
label_1:
//line 272
___nl__2 = null;
//line 273
___nl__2 = ((ImmHash)___nl__0).getHashValue()["fun_name"];
//line 273
___nl__3 = new ImmString("(");
//line 273
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 273
___nl__3 = null;
//line 273
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__2);
___nl__1 = ___ref______nl__1.getValue();

//line 273
___nl__2 = null;
//line 275
___nl__2 = new ImmDouble(0);
//line 276
___nl__3 = ((ImmHash)___nl__0).getHashValue()["args"];
//line 276
___nl__5 = new ImmDouble(0);
//line 276
___nl__6 = new ImmDouble(1);
//line 276
___nl__7 = c_rt_lib_NL.NL_array_len(___nl__3);

//line 276
label_5:
//line 276
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) );
//line 276
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_3;}}
//line 276
___nl__4 = (___nl__3 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()];
//line 277
___nl__9 = new ImmDouble(0);
//line 277
___nl__9 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__2.getValue().ToString()))>(Double.Parse(___nl__9.getValue().ToString())) );
//line 277
___nl__9 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__9));
//line 277
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_7;}}
//line 278
___nl__10 = new ImmString(", ");
//line 278
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__10);
___nl__1 = ___ref______nl__1.getValue();

//line 278
___nl__10 = null;
//line 279
if (true) {goto label_7;}
//line 279
label_7:
//line 279
___nl__9 = null;
//line 280
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("val"));
//line 280
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_9;}}
//line 282
___nl__9 = c_rt_lib_NL.NL_ov_is(___nl__4, new ImmString("ref"));
//line 282
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_10;}}
//line 282
___nl__9 = new ImmString("NOMATCHALERT");
//line 282
___nl__9 = new ImmArray(new Imm[] {___nl__9,___nl__4,});
//line 282
c_rt_lib_NL.NL_die();
//line 280
label_9:
//line 280
___nl__10 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("val"));
//line 281
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_priv(___nl__10,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 281
___nl__10 = null;
//line 282
if (true) {goto label_8;}
//line 282
label_10:
//line 282
___nl__10 = c_rt_lib_NL.NL_ov_as(___nl__4, new ImmString("ref"));
//line 283
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_priv(___nl__10,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 283
___nl__10 = null;
//line 284
if (true) {goto label_8;}
//line 284
label_8:
//line 284
___nl__9 = null;
//line 285
___nl__9 = new ImmDouble(1);
//line 285
___nl__2 = new ImmDouble((Double.Parse(___nl__2.getValue().ToString()))+(Double.Parse(___nl__9.getValue().ToString())));
//line 285
___nl__9 = null;
//line 286
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString())));
//line 286
if (true) {goto label_5;}
//line 286
label_3:
//line 286
___nl__3 = null;
//line 286
___nl__4 = null;
//line 286
___nl__5 = null;
//line 286
___nl__6 = null;
//line 286
___nl__7 = null;
//line 286
___nl__8 = null;
//line 287
___nl__3 = new ImmString(");");
//line 287
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__3);
___nl__1 = ___ref______nl__1.getValue();

//line 287
___nl__3 = null;
//line 287
___nl__2 = null;
//line 287
___nl__0 = null;
//line 287
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_print_una_op_priv(Imm ___arg__0, ImmRef ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 291
___nl__2 = ((ImmHash)___nl__0).getHashValue()["dest"];
//line 291
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_to_assign_priv(___nl__2,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 291
___nl__2 = null;
//line 292
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 292
___nl__3 = new ImmString("!");
//line 292
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 292
___nl__3 = null;
//line 292
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 292
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 292
___nl__3 = new ImmString("c_rt_lib::to_nl(");
//line 292
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__3);
___nl__1 = ___ref______nl__1.getValue();

//line 292
___nl__3 = null;
//line 292
if (true) {goto label_2;}
//line 292
label_2:
//line 292
___nl__2 = null;
//line 293
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 293
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__2);
___nl__1 = ___ref______nl__1.getValue();

//line 293
___nl__2 = null;
//line 294
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 294
___nl__3 = new ImmString("!");
//line 294
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 294
___nl__3 = null;
//line 294
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 294
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_4;}}
//line 294
___nl__3 = new ImmString("c_rt_lib::check_true(");
//line 294
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__3);
___nl__1 = ___ref______nl__1.getValue();

//line 294
___nl__3 = null;
//line 294
if (true) {goto label_4;}
//line 294
label_4:
//line 294
___nl__2 = null;
//line 295
___nl__2 = ((ImmHash)___nl__0).getHashValue()["src"];
//line 295
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_priv(___nl__2,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 295
___nl__2 = null;
//line 296
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 296
___nl__3 = new ImmString("!");
//line 296
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 296
___nl__3 = null;
//line 296
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 296
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_6;}}
//line 296
___nl__3 = new ImmString("))");
//line 296
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__3);
___nl__1 = ___ref______nl__1.getValue();

//line 296
___nl__3 = null;
//line 296
if (true) {goto label_6;}
//line 296
label_6:
//line 296
___nl__2 = null;
//line 297
___nl__2 = new ImmString(";");
//line 297
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__2);
___nl__1 = ___ref______nl__1.getValue();

//line 297
___nl__2 = null;
//line 297
___nl__0 = null;
//line 297
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_print_bin_op_priv(Imm ___arg__0, ImmRef ___arg__1) {
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
//line 301
___nl__2 = ((ImmHash)___nl__0).getHashValue()["dest"];
//line 301
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_to_assign_priv(___nl__2,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 301
___nl__2 = null;
//line 302
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 302
___nl__3 = new ImmString(">=");
//line 302
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 302
___nl__3 = null;
//line 302
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_9;}}
//line 302
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 302
___nl__3 = new ImmString("<=");
//line 302
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 302
___nl__3 = null;
//line 302
label_9:
//line 302
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_8;}}
//line 302
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 302
___nl__3 = new ImmString("<");
//line 302
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 302
___nl__3 = null;
//line 302
label_8:
//line 302
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_7;}}
//line 302
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 302
___nl__3 = new ImmString(">");
//line 302
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 302
___nl__3 = null;
//line 302
label_7:
//line 302
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_6;}}
//line 302
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 302
___nl__3 = new ImmString("==");
//line 302
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 302
___nl__3 = null;
//line 302
label_6:
//line 302
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_5;}}
//line 302
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 302
___nl__3 = new ImmString("eq");
//line 302
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 302
___nl__3 = null;
//line 302
label_5:
//line 302
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_4;}}
//line 302
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 302
___nl__3 = new ImmString("!=");
//line 302
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 302
___nl__3 = null;
//line 302
label_4:
//line 302
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_3;}}
//line 302
___nl__2 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 302
___nl__3 = new ImmString("ne");
//line 302
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__3.toString()));
//line 302
___nl__3 = null;
//line 302
label_3:
//line 302
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 302
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 310
___nl__3 = new ImmString("c_rt_lib::to_nl(");
//line 310
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__3);
___nl__1 = ___ref______nl__1.getValue();

//line 310
___nl__3 = null;
//line 311
___nl__3 = ((ImmHash)___nl__0).getHashValue()["left"];
//line 311
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_priv(___nl__3,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 311
___nl__3 = null;
//line 312
___nl__3 = new ImmString(" ");
//line 312
___nl__4 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 312
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 312
___nl__4 = null;
//line 312
___nl__4 = new ImmString(" ");
//line 312
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 312
___nl__4 = null;
//line 312
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__3);
___nl__1 = ___ref______nl__1.getValue();

//line 312
___nl__3 = null;
//line 313
___nl__3 = ((ImmHash)___nl__0).getHashValue()["right"];
//line 313
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_priv(___nl__3,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 313
___nl__3 = null;
//line 314
___nl__3 = new ImmString(");");
//line 314
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__3);
___nl__1 = ___ref______nl__1.getValue();

//line 314
___nl__3 = null;
//line 315
if (true) {goto label_1;}
//line 315
label_2:
//line 316
___nl__3 = ((ImmHash)___nl__0).getHashValue()["left"];
//line 316
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_priv(___nl__3,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 316
___nl__3 = null;
//line 317
___nl__3 = new ImmString(" ");
//line 317
___nl__4 = ((ImmHash)___nl__0).getHashValue()["op"];
//line 317
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 317
___nl__4 = null;
//line 317
___nl__4 = new ImmString(" ");
//line 317
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString());
//line 317
___nl__4 = null;
//line 317
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__3);
___nl__1 = ___ref______nl__1.getValue();

//line 317
___nl__3 = null;
//line 318
___nl__3 = ((ImmHash)___nl__0).getHashValue()["right"];
//line 318
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_priv(___nl__3,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 318
___nl__3 = null;
//line 319
___nl__3 = new ImmString(";");
//line 319
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__3);
___nl__1 = ___ref______nl__1.getValue();

//line 319
___nl__3 = null;
//line 320
if (true) {goto label_1;}
//line 320
label_1:
//line 320
___nl__2 = null;
//line 320
___nl__0 = null;
//line 320
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_print_set_at_idx_priv(Imm ___arg__0, ImmRef ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();
Imm ___nl__2 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 324
___nl__2 = new ImmString(" if (c_rt_lib::get_arrcount(");
//line 324
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__2);
___nl__1 = ___ref______nl__1.getValue();

//line 324
___nl__2 = null;
//line 325
___nl__2 = ((ImmHash)___nl__0).getHashValue()["src"];
//line 325
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_priv(___nl__2,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 325
___nl__2 = null;
//line 326
___nl__2 = new ImmString(") > 1) {");
//line 326
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__2);
___nl__1 = ___ref______nl__1.getValue();

//line 326
___nl__2 = null;
//line 327
___nl__2 = ((ImmHash)___nl__0).getHashValue()["src"];
//line 327
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_to_assign_priv(___nl__2,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 327
___nl__2 = null;
//line 328
___nl__2 = new ImmString("[@{");
//line 328
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__2);
___nl__1 = ___ref______nl__1.getValue();

//line 328
___nl__2 = null;
//line 329
___nl__2 = ((ImmHash)___nl__0).getHashValue()["src"];
//line 329
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_priv(___nl__2,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 329
___nl__2 = null;
//line 330
___nl__2 = new ImmString("}];}");
//line 330
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__2);
___nl__1 = ___ref______nl__1.getValue();

//line 330
___nl__2 = null;
//line 332
___nl__2 = ((ImmHash)___nl__0).getHashValue()["src"];
//line 332
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_priv(___nl__2,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 332
___nl__2 = null;
//line 333
___nl__2 = new ImmString("->[");
//line 333
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__2);
___nl__1 = ___ref______nl__1.getValue();

//line 333
___nl__2 = null;
//line 334
___nl__2 = ((ImmHash)___nl__0).getHashValue()["idx"];
//line 334
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_priv(___nl__2,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 334
___nl__2 = null;
//line 335
___nl__2 = new ImmString("] = ");
//line 335
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__2);
___nl__1 = ___ref______nl__1.getValue();

//line 335
___nl__2 = null;
//line 336
___nl__2 = ((ImmHash)___nl__0).getHashValue()["val"];
//line 336
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_priv(___nl__2,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 336
___nl__2 = null;
//line 337
___nl__2 = new ImmString(";");
//line 337
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__2);
___nl__1 = ___ref______nl__1.getValue();

//line 337
___nl__2 = null;
//line 337
___nl__0 = null;
//line 337
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_print_set_val_priv(Imm ___arg__0, ImmRef ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 341
___nl__2 = new ImmString(" if (c_rt_lib::get_hashcount(");
//line 341
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__2);
___nl__1 = ___ref______nl__1.getValue();

//line 341
___nl__2 = null;
//line 342
___nl__2 = ((ImmHash)___nl__0).getHashValue()["src"];
//line 342
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_priv(___nl__2,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 342
___nl__2 = null;
//line 343
___nl__2 = new ImmString(") > 1) {");
//line 343
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__2);
___nl__1 = ___ref______nl__1.getValue();

//line 343
___nl__2 = null;
//line 344
___nl__2 = ((ImmHash)___nl__0).getHashValue()["src"];
//line 344
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_to_assign_priv(___nl__2,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 344
___nl__2 = null;
//line 345
___nl__2 = new ImmString("{%{");
//line 345
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__2);
___nl__1 = ___ref______nl__1.getValue();

//line 345
___nl__2 = null;
//line 346
___nl__2 = ((ImmHash)___nl__0).getHashValue()["src"];
//line 346
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_priv(___nl__2,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 346
___nl__2 = null;
//line 347
___nl__2 = new ImmString("}};}");
//line 347
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__2);
___nl__1 = ___ref______nl__1.getValue();

//line 347
___nl__2 = null;
//line 348
___nl__2 = ((ImmHash)___nl__0).getHashValue()["src"];
//line 348
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_priv(___nl__2,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 348
___nl__2 = null;
//line 349
___nl__2 = new ImmString("->{'");
//line 349
___nl__3 = ((ImmHash)___nl__0).getHashValue()["key"];
//line 349
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 349
___nl__3 = null;
//line 349
___nl__3 = new ImmString("'} = ");
//line 349
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 349
___nl__3 = null;
//line 349
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__2);
___nl__1 = ___ref______nl__1.getValue();

//line 349
___nl__2 = null;
//line 350
___nl__2 = ((ImmHash)___nl__0).getHashValue()["val"];
//line 350
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_priv(___nl__2,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 350
___nl__2 = null;
//line 351
___nl__2 = new ImmString(";");
//line 351
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__2);
___nl__1 = ___ref______nl__1.getValue();

//line 351
___nl__2 = null;
//line 351
___nl__0 = null;
//line 351
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_print_ov_mk_priv(Imm ___arg__0, ImmRef ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();
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
//line 355
___nl__2 = ((ImmHash)___nl__0).getHashValue()["dest"];
//line 355
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_to_assign_priv(___nl__2,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 355
___nl__2 = null;
//line 356
___nl__2 = ((ImmHash)___nl__0).getHashValue()["src"];
//line 356
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("emp"));
//line 356
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 356
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 356
___nl__2 = ((ImmHash)___nl__0).getHashValue()["name"];
//line 356
___nl__4 = new ImmString("TRUE");
//line 356
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__4.toString()));
//line 356
___nl__4 = null;
//line 356
label_3:
//line 356
___nl__3 = null;
//line 356
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 356
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 357
___nl__3 = new ImmString("c_rt_lib::to_nl(1);");
//line 357
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__3);
___nl__1 = ___ref______nl__1.getValue();

//line 357
___nl__3 = null;
//line 358
if (true) {goto label_1;}
//line 358
label_2:
//line 358
___nl__2 = ((ImmHash)___nl__0).getHashValue()["src"];
//line 358
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("emp"));
//line 358
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 358
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_5;}}
//line 358
___nl__2 = ((ImmHash)___nl__0).getHashValue()["name"];
//line 358
___nl__4 = new ImmString("FALSE");
//line 358
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__2.toString().Equals(___nl__4.toString()));
//line 358
___nl__4 = null;
//line 358
label_5:
//line 358
___nl__3 = null;
//line 358
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 358
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_4;}}
//line 359
___nl__3 = new ImmString("c_rt_lib::to_nl(0);");
//line 359
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__3);
___nl__1 = ___ref______nl__1.getValue();

//line 359
___nl__3 = null;
//line 360
if (true) {goto label_1;}
//line 360
label_4:
//line 361
___nl__3 = ((ImmHash)___nl__0).getHashValue()["src"];
//line 361
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("arg"));
//line 361
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_7;}}
//line 365
___nl__4 = c_rt_lib_NL.NL_ov_is(___nl__3, new ImmString("emp"));
//line 365
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_8;}}
//line 365
___nl__4 = new ImmString("NOMATCHALERT");
//line 365
___nl__4 = new ImmArray(new Imm[] {___nl__4,___nl__3,});
//line 365
c_rt_lib_NL.NL_die();
//line 361
label_7:
//line 361
___nl__5 = c_rt_lib_NL.NL_ov_as(___nl__3, new ImmString("arg"));
//line 362
___nl__6 = new ImmString("c_rt_lib::ov_mk_arg('");
//line 362
___nl__7 = ((ImmHash)___nl__0).getHashValue()["name"];
//line 362
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 362
___nl__7 = null;
//line 362
___nl__7 = new ImmString("', ");
//line 362
___nl__6 = new ImmString(___nl__6.toString() + ___nl__7.toString());
//line 362
___nl__7 = null;
//line 362
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__6);
___nl__1 = ___ref______nl__1.getValue();

//line 362
___nl__6 = null;
//line 363
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_priv(___nl__5,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 364
___nl__6 = new ImmString(");");
//line 364
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__6);
___nl__1 = ___ref______nl__1.getValue();

//line 364
___nl__6 = null;
//line 364
___nl__5 = null;
//line 365
if (true) {goto label_6;}
//line 365
label_8:
//line 366
___nl__5 = new ImmString("c_rt_lib::ov_mk_none('");
//line 366
___nl__6 = ((ImmHash)___nl__0).getHashValue()["name"];
//line 366
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 366
___nl__6 = null;
//line 366
___nl__6 = new ImmString("');");
//line 366
___nl__5 = new ImmString(___nl__5.toString() + ___nl__6.toString());
//line 366
___nl__6 = null;
//line 366
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__5);
___nl__1 = ___ref______nl__1.getValue();

//line 366
___nl__5 = null;
//line 367
if (true) {goto label_6;}
//line 367
label_6:
//line 367
___nl__3 = null;
//line 367
___nl__4 = null;
//line 368
if (true) {goto label_1;}
//line 368
label_1:
//line 368
___nl__2 = null;
//line 368
___nl__0 = null;
//line 368
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_print_register_priv(Imm ___arg__0, ImmRef ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 372
___nl__2 = new ImmString("");
//line 372
___nl__2 = c_rt_lib_NL.NL_native_to_nl(___nl__0.toString().Equals(___nl__2.toString()));
//line 372
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 372
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 372
___nl__0 = null;
//line 372
___nl__2 = null;
//line 372
___arg__1.setValue(___nl__1);if(true) return null;
//line 372
if (true) {goto label_2;}
//line 372
label_2:
//line 372
___nl__2 = null;
//line 373
___nl__2 = new ImmString("$memory_");
//line 373
___nl__2 = new ImmString(___nl__2.toString() + ___nl__0.toString());
//line 373
___nl__3 = new ImmString("");
//line 373
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString());
//line 373
___nl__3 = null;
//line 373
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__2);
___nl__1 = ___ref______nl__1.getValue();

//line 373
___nl__2 = null;
//line 373
___nl__0 = null;
//line 373
___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_print_register_to_assign_priv(Imm ___arg__0, ImmRef ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 377
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_register_priv(___nl__0,___ref______nl__1);
___nl__1 = ___ref______nl__1.getValue();

//line 378
___nl__2 = new ImmString("");
//line 378
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!___nl__0.toString().Equals(___nl__2.toString()));
//line 378
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2));
//line 378
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 378
___nl__3 = new ImmString(" = ");
//line 378
___ref______nl__1 = new ImmRef(___nl__1);
generator_pm_NL.NL_print_priv(___ref______nl__1,___nl__3);
___nl__1 = ___ref______nl__1.getValue();

//line 378
___nl__3 = null;
//line 378
if (true) {goto label_2;}
//line 378
label_2:
//line 378
___nl__2 = null;
//line 378
___nl__0 = null;
//line 378
___arg__1.setValue(___nl__1);if(true) return null;
}

}
}