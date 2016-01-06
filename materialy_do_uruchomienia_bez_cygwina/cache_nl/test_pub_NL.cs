using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class test_pub_NL {

public static Imm NL_SINGLETON_test() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 8
___nl__0 = test_pub_NL.NL_funkcja();

//line 8
___nl__1 = new ImmDouble(1);
//line 8
___nl__1 = new ImmDouble(-((ImmDouble)___nl__1).getDoubleValue());
//line 8
nassert_NL.NL_a(___nl__0,___nl__1);

//line 8
___nl__1 = null;
//line 8
___nl__0 = null;
//line 9
___nl__1 = new ImmDouble(1);
//line 9
___nl__0 = test_pub_NL.NL_funkcja_priv(___nl__1);

//line 9
___nl__1 = null;
//line 9
___nl__1 = new ImmDouble(1);
//line 9
___nl__1 = new ImmDouble(-((ImmDouble)___nl__1).getDoubleValue());
//line 9
nassert_NL.NL_a(___nl__0,___nl__1);

//line 9
___nl__1 = null;
//line 9
___nl__0 = null;
//line 10
___nl__1 = new ImmDouble(0);
//line 10
___nl__0 = test_pub_NL.NL_funkcja_priv(___nl__1);

//line 10
___nl__1 = null;
//line 10
___nl__1 = new ImmDouble(0);
//line 10
nassert_NL.NL_a(___nl__0,___nl__1);

//line 10
___nl__1 = null;
//line 10
___nl__0 = null;
//line 10
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_test = null;
public static Imm NL_test() {
	if (value__singleton__NL_SINGLETON_test == null) {
		value__singleton__NL_SINGLETON_test = NL_SINGLETON_test();
	}
	return value__singleton__NL_SINGLETON_test;
}
public static Imm NL_SINGLETON_funkcja() {

Imm ___nl__0 = null;
ImmRef ___ref______nl__0 = null;
Dictionary<String, Imm> __function_map;
//line 14
___nl__0 = new ImmDouble(0);
//line 14
test_pub_NL.NL_funkcja_priv(___nl__0);

//line 14
___nl__0 = null;
//line 15
___nl__0 = new ImmDouble(1);
//line 15
___nl__0 = new ImmDouble(-((ImmDouble)___nl__0).getDoubleValue());
//line 15
if(true) return ___nl__0;
//line 15
___nl__0 = null;
//line 15
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_funkcja = null;
public static Imm NL_funkcja() {
	if (value__singleton__NL_SINGLETON_funkcja == null) {
		value__singleton__NL_SINGLETON_funkcja = NL_SINGLETON_funkcja();
	}
	return value__singleton__NL_SINGLETON_funkcja;
}
private static Imm NL_funkcja_priv(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
Imm ___nl__2 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 19
___nl__1 = new ImmDouble(1);
//line 19
___nl__1 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__0.getValue().ToString()))>=(Double.Parse(___nl__1.getValue().ToString())) );
//line 19
___nl__1 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__1));
//line 19
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_2;}}
//line 20
___nl__2 = test_pub_NL.NL_funkcja();

//line 20
___nl__0 = null;
//line 20
___nl__1 = null;
//line 20
if(true) return ___nl__2;
//line 20
___nl__2 = null;
//line 21
if (true) {goto label_2;}
//line 21
label_2:
//line 21
___nl__1 = null;
//line 22
___nl__1 = new ImmDouble(0);
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

}
}