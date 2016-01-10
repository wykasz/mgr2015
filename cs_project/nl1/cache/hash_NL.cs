using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class hash_NL {

public static Imm NL_get_value(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);
Imm ___nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 8
___nl__2 = c_std_lib_NL.NL_hash_get_value(___nl__0,___nl__1).clone();

//line 8
___nl__0 = null;
//line 8
___nl__1 = null;
//line 8
if(true) return ___nl__2;
//line 8
___nl__2 = null;
//line 8
___nl__0 = null;
//line 8
___nl__1 = null;
//line 8
if(true) return null;
}

public static Imm NL_has_key(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);
Imm ___nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 12
___nl__2 = c_std_lib_NL.NL_hash_has_key(___nl__0,___nl__1).clone();

//line 12
___nl__0 = null;
//line 12
___nl__1 = null;
//line 12
if(true) return ___nl__2;
//line 12
___nl__2 = null;
//line 12
___nl__0 = null;
//line 12
___nl__1 = null;
//line 12
if(true) return null;
}

public static Imm NL_set_value(ref Imm ___arg__0, Imm ___arg__1, Imm ___arg__2) {
Imm ___nl__0 = ___arg__0;Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);Imm ___nl__2 = null;c_rt_lib_NL.NL_copy(ref ___nl__2, ___arg__2);
Dictionary<String, Imm> __function_map;
//line 16
c_std_lib_NL.NL_hash_set_value(ref ___nl__0,___nl__1,___nl__2);

//line 16
___nl__1 = null;
//line 16
___nl__2 = null;
//line 16
___arg__0 = ___nl__0;if(true) return null;
}

public static Imm NL_delete(ref Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0;Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);
Dictionary<String, Imm> __function_map;
//line 20
c_std_lib_NL.NL_hash_delete(ref ___nl__0,___nl__1);

//line 20
___nl__1 = null;
//line 20
___arg__0 = ___nl__0;if(true) return null;
}

public static Imm NL_size(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 24
___nl__1 = c_std_lib_NL.NL_hash_size(___nl__0).clone();

//line 24
___nl__0 = null;
//line 24
if(true) return ___nl__1;
//line 24
___nl__1 = null;
//line 24
___nl__0 = null;
//line 24
if(true) return null;
}

public static Imm NL_keys(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 28
___nl__1 = new ImmArray(new Imm[0]).clone();
//line 29
___nl__4 = c_rt_lib_NL.NL_init_iter(___nl__0).clone();

//line 29
label_3:
//line 29
___nl__2 = c_rt_lib_NL.NL_is_end_hash(___nl__4).clone();

//line 29
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_1;}}
//line 29
___nl__2 = c_rt_lib_NL.NL_get_key_iter(___nl__4).clone();

//line 29
___nl__3 = c_rt_lib_NL.NL_hash_get_value(___nl__0,___nl__2).clone();

//line 30
c_std_lib_NL.NL_array_push(ref ___nl__1,___nl__2);

//line 31
___nl__4 = c_rt_lib_NL.NL_next_iter(___nl__4).clone();

//line 31
if (true) {goto label_3;}
//line 31
label_1:
//line 31
___nl__2 = null;
//line 31
___nl__3 = null;
//line 31
___nl__4 = null;
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

}
}