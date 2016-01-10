using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class test_fun_NL {

public static Imm NL_change(ref Imm ___arg__0, Imm ___arg__1, ref Imm ___arg__2) {
Imm ___nl__0 = ___arg__0;Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);Imm ___nl__2 = ___arg__2;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 10
___nl__3 = new ImmDouble(10).clone();
//line 10
___nl__0 = new ImmDouble((Double.Parse(___nl__0.getValue().ToString()))+(Double.Parse(___nl__3.getValue().ToString()))).clone();
//line 10
___nl__3 = null;
//line 11
___nl__3 = new ImmDouble(20).clone();
//line 11
___nl__1 = new ImmDouble((Double.Parse(___nl__1.getValue().ToString()))+(Double.Parse(___nl__3.getValue().ToString()))).clone();
//line 11
___nl__3 = null;
//line 12
___nl__3 = new ImmDouble(20).clone();
//line 12
___nl__2 = ___nl__3.clone();
//line 12
___nl__3 = null;
//line 13
___nl__3 = new ImmDouble(10).clone();
//line 13
___nl__3 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__0.getValue().ToString()))<(Double.Parse(___nl__3.getValue().ToString())) ).clone();
//line 13
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 13
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 13
___nl__4 = ___nl__0.clone();
//line 13
___nl__1 = null;
//line 13
___nl__3 = null;
//line 13
___arg__0 = ___nl__0;___arg__2 = ___nl__2;if(true) return ___nl__4;
//line 13
___nl__4 = null;
//line 13
if (true) {goto label_2;}
//line 13
label_2:
//line 13
___nl__3 = null;
//line 14
___nl__3 = ___nl__2.clone();
//line 14
___nl__1 = null;
//line 14
___arg__0 = ___nl__0;___arg__2 = ___nl__2;if(true) return ___nl__3;
//line 14
___nl__3 = null;
//line 14
___nl__1 = null;
//line 14
___arg__0 = ___nl__0;___arg__2 = ___nl__2;if(true) return null;
}

public static Imm NL_test() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 18
___nl__1 = new ImmDouble(1).clone();
//line 18
___nl__2 = new ImmDouble(3).clone();
//line 18
___nl__3 = new ImmDouble(4).clone();
//line 18
___nl__3 = new ImmDouble(-((ImmDouble)___nl__3).getDoubleValue()).clone();
//line 18
___nl__0 = new ImmArray(new Imm[] {___nl__1,___nl__2,___nl__3,}).clone();
//line 18
___nl__1 = null;
//line 18
___nl__2 = null;
//line 18
___nl__3 = null;
//line 19
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("test_fun_NL"));
__function_map.Add("name",new ImmString("change"));
___nl__1 = new ImmHash(__function_map).clone();
//line 19
___nl__1 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__1).clone();
//line 19
func_NL.NL_exec(___nl__1,___nl__0);

//line 19
___nl__1 = null;
//line 20
___nl__2 = new ImmDouble(0).clone();
//line 20
___nl__1 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__2).getDoubleValue()].clone();
//line 20
___nl__2 = null;
//line 20
___nl__2 = new ImmDouble(1).clone();
//line 20
nassert_NL.NL_a(___nl__1,___nl__2);

//line 20
___nl__2 = null;
//line 20
___nl__1 = null;
//line 21
___nl__2 = new ImmDouble(1).clone();
//line 21
___nl__1 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__2).getDoubleValue()].clone();
//line 21
___nl__2 = null;
//line 21
___nl__2 = new ImmDouble(3).clone();
//line 21
nassert_NL.NL_a(___nl__1,___nl__2);

//line 21
___nl__2 = null;
//line 21
___nl__1 = null;
//line 22
___nl__2 = new ImmDouble(2).clone();
//line 22
___nl__1 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__2).getDoubleValue()].clone();
//line 22
___nl__2 = null;
//line 22
___nl__2 = new ImmDouble(4).clone();
//line 22
___nl__2 = new ImmDouble(-((ImmDouble)___nl__2).getDoubleValue()).clone();
//line 22
nassert_NL.NL_a(___nl__1,___nl__2);

//line 22
___nl__2 = null;
//line 22
___nl__1 = null;
//line 23
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("test_fun_NL"));
__function_map.Add("name",new ImmString("change"));
___nl__1 = new ImmHash(__function_map).clone();
//line 23
___nl__1 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__1).clone();
//line 23
func_NL.NL_exec_ref(___nl__1,ref ___nl__0);

//line 23
___nl__1 = null;
//line 24
___nl__2 = new ImmDouble(0).clone();
//line 24
___nl__1 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__2).getDoubleValue()].clone();
//line 24
___nl__2 = null;
//line 24
___nl__2 = new ImmDouble(11).clone();
//line 24
nassert_NL.NL_a(___nl__1,___nl__2);

//line 24
___nl__2 = null;
//line 24
___nl__1 = null;
//line 25
___nl__2 = new ImmDouble(1).clone();
//line 25
___nl__1 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__2).getDoubleValue()].clone();
//line 25
___nl__2 = null;
//line 25
___nl__2 = new ImmDouble(3).clone();
//line 25
nassert_NL.NL_a(___nl__1,___nl__2);

//line 25
___nl__2 = null;
//line 25
___nl__1 = null;
//line 26
___nl__2 = new ImmDouble(2).clone();
//line 26
___nl__1 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__2).getDoubleValue()].clone();
//line 26
___nl__2 = null;
//line 26
___nl__2 = new ImmDouble(20).clone();
//line 26
nassert_NL.NL_a(___nl__1,___nl__2);

//line 26
___nl__2 = null;
//line 26
___nl__1 = null;
//line 26
___nl__0 = null;
//line 26
if(true) return null;
}

}
}