using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class string_NL {

public static Imm NL_SINGLETON_lf() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 10
___nl__1 = new ImmDouble(10).clone();
//line 10
___nl__0 = string_NL.NL_chr(___nl__1).clone();

//line 10
___nl__1 = null;
//line 10
if(true) return ___nl__0;
//line 10
___nl__0 = null;
//line 10
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_lf = null;
public static Imm NL_lf() {
	if (value__singleton__NL_SINGLETON_lf == null) {
		value__singleton__NL_SINGLETON_lf = NL_SINGLETON_lf();
	}
	return value__singleton__NL_SINGLETON_lf;
}
public static Imm NL_SINGLETON_tab() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 14
___nl__1 = new ImmDouble(9).clone();
//line 14
___nl__0 = string_NL.NL_chr(___nl__1).clone();

//line 14
___nl__1 = null;
//line 14
if(true) return ___nl__0;
//line 14
___nl__0 = null;
//line 14
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_tab = null;
public static Imm NL_tab() {
	if (value__singleton__NL_SINGLETON_tab == null) {
		value__singleton__NL_SINGLETON_tab = NL_SINGLETON_tab();
	}
	return value__singleton__NL_SINGLETON_tab;
}
public static Imm NL_SINGLETON_r() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 18
___nl__1 = new ImmDouble(13).clone();
//line 18
___nl__0 = string_NL.NL_chr(___nl__1).clone();

//line 18
___nl__1 = null;
//line 18
if(true) return ___nl__0;
//line 18
___nl__0 = null;
//line 18
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_r = null;
public static Imm NL_r() {
	if (value__singleton__NL_SINGLETON_r == null) {
		value__singleton__NL_SINGLETON_r = NL_SINGLETON_r();
	}
	return value__singleton__NL_SINGLETON_r;
}
public static Imm NL_SINGLETON_f() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 22
___nl__1 = new ImmDouble(12).clone();
//line 22
___nl__0 = string_NL.NL_chr(___nl__1).clone();

//line 22
___nl__1 = null;
//line 22
if(true) return ___nl__0;
//line 22
___nl__0 = null;
//line 22
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_f = null;
public static Imm NL_f() {
	if (value__singleton__NL_SINGLETON_f == null) {
		value__singleton__NL_SINGLETON_f = NL_SINGLETON_f();
	}
	return value__singleton__NL_SINGLETON_f;
}
public static Imm NL_char_times(Imm ___arg__0, Imm ___arg__1) {
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
//line 26
___nl__2 = new ImmString("").clone();
//line 27
___nl__3 = new ImmDouble(0).clone();
//line 27
___nl__4 = new ImmDouble(1).clone();
//line 27
label_3:
//line 27
___nl__5 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))>=(Double.Parse(___nl__1.getValue().ToString())) ).clone();
//line 27
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_1;}}
//line 27
___nl__2 = new ImmString(___nl__2.toString() + ___nl__0.toString()).clone();
//line 27
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString()))).clone();
//line 27
if (true) {goto label_3;}
//line 27
label_1:
//line 27
___nl__3 = null;
//line 27
___nl__4 = null;
//line 27
___nl__5 = null;
//line 28
___nl__0 = null;
//line 28
___nl__1 = null;
//line 28
if(true) return ___nl__2;
//line 28
___nl__2 = null;
//line 28
___nl__0 = null;
//line 28
___nl__1 = null;
//line 28
if(true) return null;
}

public static Imm NL_length(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 32
___nl__1 = c_std_lib_NL.NL_string_length(___nl__0).clone();

//line 32
___nl__0 = null;
//line 32
if(true) return ___nl__1;
//line 32
___nl__1 = null;
//line 32
___nl__0 = null;
//line 32
if(true) return null;
}

public static Imm NL_get_char_code(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();
Imm ___nl__2 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 36
___nl__2 = c_std_lib_NL.NL_string_get_char_code(___nl__0,___nl__1).clone();

//line 36
___nl__0 = null;
//line 36
___nl__1 = null;
//line 36
if(true) return ___nl__2;
//line 36
___nl__2 = null;
//line 36
___nl__0 = null;
//line 36
___nl__1 = null;
//line 36
if(true) return null;
}

public static Imm NL_substr(Imm ___arg__0, Imm ___arg__1, Imm ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();
Imm ___nl__3 = null;
Imm ___nl__4 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 40
___nl__3 = c_std_lib_NL.NL_string_sub(___nl__0,___nl__1,___nl__2).clone();

//line 40
___nl__4 = new ImmString("").clone();
//line 40
___nl__3 = new ImmString(___nl__3.toString() + ___nl__4.toString()).clone();
//line 40
___nl__4 = null;
//line 40
___nl__0 = null;
//line 40
___nl__1 = null;
//line 40
___nl__2 = null;
//line 40
if(true) return ___nl__3;
//line 40
___nl__3 = null;
//line 40
___nl__0 = null;
//line 40
___nl__1 = null;
//line 40
___nl__2 = null;
//line 40
if(true) return null;
}

public static Imm NL_substr2(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 44
___nl__3 = string_NL.NL_length(___nl__0).clone();

//line 44
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))-(Double.Parse(___nl__1.getValue().ToString()))).clone();
//line 44
___nl__2 = c_std_lib_NL.NL_string_sub(___nl__0,___nl__1,___nl__3).clone();

//line 44
___nl__3 = null;
//line 44
___nl__3 = new ImmString("").clone();
//line 44
___nl__2 = new ImmString(___nl__2.toString() + ___nl__3.toString()).clone();
//line 44
___nl__3 = null;
//line 44
___nl__0 = null;
//line 44
___nl__1 = null;
//line 44
if(true) return ___nl__2;
//line 44
___nl__2 = null;
//line 44
___nl__0 = null;
//line 44
___nl__1 = null;
//line 44
if(true) return null;
}

public static Imm NL_index2(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 48
___nl__3 = new ImmDouble(0).clone();
//line 48
___nl__2 = c_std_lib_NL.NL_string_index(___nl__0,___nl__1,___nl__3).clone();

//line 48
___nl__3 = null;
//line 48
___nl__0 = null;
//line 48
___nl__1 = null;
//line 48
if(true) return ___nl__2;
//line 48
___nl__2 = null;
//line 48
___nl__0 = null;
//line 48
___nl__1 = null;
//line 48
if(true) return null;
}

public static Imm NL_index(Imm ___arg__0, Imm ___arg__1, Imm ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 52
___nl__3 = c_std_lib_NL.NL_string_index(___nl__0,___nl__1,___nl__2).clone();

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

public static Imm NL_replace(Imm ___arg__0, Imm ___arg__1, Imm ___arg__2) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 56
___nl__3 = c_std_lib_NL.NL_string_replace(___nl__0,___nl__1,___nl__2).clone();

//line 56
___nl__0 = null;
//line 56
___nl__1 = null;
//line 56
___nl__2 = null;
//line 56
if(true) return ___nl__3;
//line 56
___nl__3 = null;
//line 56
___nl__0 = null;
//line 56
___nl__1 = null;
//line 56
___nl__2 = null;
//line 56
if(true) return null;
}

public static Imm NL_ord(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 60
___nl__1 = c_std_lib_NL.NL_string_ord(___nl__0).clone();

//line 60
___nl__0 = null;
//line 60
if(true) return ___nl__1;
//line 60
___nl__1 = null;
//line 60
___nl__0 = null;
//line 60
if(true) return null;
}

public static Imm NL_is_digit(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 64
___nl__1 = string_NL.NL_ord(___nl__0).clone();

//line 65
___nl__2 = new ImmDouble(48).clone();
//line 65
___nl__2 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__1.getValue().ToString()))>=(Double.Parse(___nl__2.getValue().ToString())) ).clone();
//line 65
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 65
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_1;}}
//line 65
___nl__2 = new ImmDouble(57).clone();
//line 65
___nl__2 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__1.getValue().ToString()))<=(Double.Parse(___nl__2.getValue().ToString())) ).clone();
//line 65
label_1:
//line 65
___nl__3 = null;
//line 65
___nl__0 = null;
//line 65
___nl__1 = null;
//line 65
if(true) return ___nl__2;
//line 65
___nl__2 = null;
//line 65
___nl__1 = null;
//line 65
___nl__0 = null;
//line 65
if(true) return null;
}

public static Imm NL_is_letter(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 69
___nl__1 = string_NL.NL_ord(___nl__0).clone();

//line 70
___nl__2 = new ImmDouble(97).clone();
//line 70
___nl__2 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__1.getValue().ToString()))>=(Double.Parse(___nl__2.getValue().ToString())) ).clone();
//line 70
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 70
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 70
___nl__2 = new ImmDouble(122).clone();
//line 70
___nl__2 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__1.getValue().ToString()))<=(Double.Parse(___nl__2.getValue().ToString())) ).clone();
//line 70
label_2:
//line 70
___nl__3 = null;
//line 70
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_1;}}
//line 70
___nl__2 = new ImmDouble(65).clone();
//line 70
___nl__2 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__1.getValue().ToString()))>=(Double.Parse(___nl__2.getValue().ToString())) ).clone();
//line 70
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 70
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_3;}}
//line 70
___nl__2 = new ImmDouble(90).clone();
//line 70
___nl__2 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__1.getValue().ToString()))<=(Double.Parse(___nl__2.getValue().ToString())) ).clone();
//line 70
label_3:
//line 70
___nl__3 = null;
//line 70
label_1:
//line 70
___nl__0 = null;
//line 70
___nl__1 = null;
//line 70
if(true) return ___nl__2;
//line 70
___nl__2 = null;
//line 70
___nl__1 = null;
//line 70
___nl__0 = null;
//line 70
if(true) return null;
}

public static Imm NL_chr(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 74
___nl__1 = c_std_lib_NL.NL_string_chr(___nl__0).clone();

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

public static Imm NL_lt(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 78
___nl__2 = string_NL.NL_compare(___nl__0,___nl__1).clone();

//line 78
___nl__3 = new ImmDouble(0).clone();
//line 78
___nl__2 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__2.getValue().ToString()))<(Double.Parse(___nl__3.getValue().ToString())) ).clone();
//line 78
___nl__3 = null;
//line 78
___nl__0 = null;
//line 78
___nl__1 = null;
//line 78
if(true) return ___nl__2;
//line 78
___nl__2 = null;
//line 78
___nl__0 = null;
//line 78
___nl__1 = null;
//line 78
if(true) return null;
}

public static Imm NL_gt(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 82
___nl__2 = string_NL.NL_compare(___nl__0,___nl__1).clone();

//line 82
___nl__3 = new ImmDouble(0).clone();
//line 82
___nl__2 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__2.getValue().ToString()))>(Double.Parse(___nl__3.getValue().ToString())) ).clone();
//line 82
___nl__3 = null;
//line 82
___nl__0 = null;
//line 82
___nl__1 = null;
//line 82
if(true) return ___nl__2;
//line 82
___nl__2 = null;
//line 82
___nl__0 = null;
//line 82
___nl__1 = null;
//line 82
if(true) return null;
}

public static Imm NL_compare(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();
Imm ___nl__2 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 86
___nl__2 = c_std_lib_NL.NL_string_compare(___nl__0,___nl__1).clone();

//line 86
___nl__0 = null;
//line 86
___nl__1 = null;
//line 86
if(true) return ___nl__2;
//line 86
___nl__2 = null;
//line 86
___nl__0 = null;
//line 86
___nl__1 = null;
//line 86
if(true) return null;
}

public static Imm NL_le(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 90
___nl__2 = string_NL.NL_compare(___nl__0,___nl__1).clone();

//line 90
___nl__3 = new ImmDouble(0).clone();
//line 90
___nl__2 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__2.getValue().ToString()))<=(Double.Parse(___nl__3.getValue().ToString())) ).clone();
//line 90
___nl__3 = null;
//line 90
___nl__0 = null;
//line 90
___nl__1 = null;
//line 90
if(true) return ___nl__2;
//line 90
___nl__2 = null;
//line 90
___nl__0 = null;
//line 90
___nl__1 = null;
//line 90
if(true) return null;
}

public static Imm NL_ge(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();
Imm ___nl__2 = null;
Imm ___nl__3 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 94
___nl__2 = string_NL.NL_compare(___nl__0,___nl__1).clone();

//line 94
___nl__3 = new ImmDouble(0).clone();
//line 94
___nl__2 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__2.getValue().ToString()))>=(Double.Parse(___nl__3.getValue().ToString())) ).clone();
//line 94
___nl__3 = null;
//line 94
___nl__0 = null;
//line 94
___nl__1 = null;
//line 94
if(true) return ___nl__2;
//line 94
___nl__2 = null;
//line 94
___nl__0 = null;
//line 94
___nl__1 = null;
//line 94
if(true) return null;
}

}
}