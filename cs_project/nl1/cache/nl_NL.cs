using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class nl_NL {

public static Imm NL_is_array(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 9
___nl__1 = c_std_lib_NL.NL_is_array(___nl__0);

//line 9
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_2;}}
//line 9
___nl__1 = c_rt_lib_NL.NL_get_false();
//line 9
if (true) {goto label_1;}
//line 9
label_2:
//line 9
___nl__1 = c_rt_lib_NL.NL_get_true();
//line 9
label_1:
//line 9
___nl__0 = null;
//line 9
if(true) return ___nl__1;
//line 9
___nl__1 = null;
//line 9
___nl__0 = null;
//line 9
if(true) return null;
}

public static Imm NL_is_hash(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 13
___nl__1 = c_std_lib_NL.NL_is_hash(___nl__0);

//line 13
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_2;}}
//line 13
___nl__1 = c_rt_lib_NL.NL_get_false();
//line 13
if (true) {goto label_1;}
//line 13
label_2:
//line 13
___nl__1 = c_rt_lib_NL.NL_get_true();
//line 13
label_1:
//line 13
___nl__0 = null;
//line 13
if(true) return ___nl__1;
//line 13
___nl__1 = null;
//line 13
___nl__0 = null;
//line 13
if(true) return null;
}

public static Imm NL_is_sim(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 17
___nl__1 = c_std_lib_NL.NL_is_sim(___nl__0);

//line 17
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_2;}}
//line 17
___nl__1 = c_rt_lib_NL.NL_get_false();
//line 17
if (true) {goto label_1;}
//line 17
label_2:
//line 17
___nl__1 = c_rt_lib_NL.NL_get_true();
//line 17
label_1:
//line 17
___nl__0 = null;
//line 17
if(true) return ___nl__1;
//line 17
___nl__1 = null;
//line 17
___nl__0 = null;
//line 17
if(true) return null;
}

public static Imm NL_is_variant(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 21
___nl__1 = c_std_lib_NL.NL_is_variant(___nl__0);

//line 21
if (c_rt_lib_NL.NL_check_true_native(___nl__1)) {if (true) {goto label_2;}}
//line 21
___nl__1 = c_rt_lib_NL.NL_get_false();
//line 21
if (true) {goto label_1;}
//line 21
label_2:
//line 21
___nl__1 = c_rt_lib_NL.NL_get_true();
//line 21
label_1:
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

public static Imm NL_print(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
ImmRef ___ref______nl__0 = null;
Dictionary<String, Imm> __function_map;
//line 25
c_std_lib_NL.NL_print(___nl__0);

//line 25
___nl__0 = null;
//line 25
if(true) return null;
}

}
}