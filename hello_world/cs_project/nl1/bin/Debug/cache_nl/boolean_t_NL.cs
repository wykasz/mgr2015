using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class boolean_t_NL {

public static Imm NL_type() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Dictionary<String, Imm> __function_map;
//line 9
___nl__2 = ptd_NL.NL_none().clone();

//line 9
___nl__3 = ptd_NL.NL_none().clone();

//line 9
__function_map = new Dictionary<String, Imm>();
__function_map.Add("TRUE",___nl__2);
__function_map.Add("FALSE",___nl__3);
___nl__1 = new ImmHash(__function_map).clone();
//line 9
___nl__2 = null;
//line 9
___nl__3 = null;
//line 9
___nl__0 = ptd_NL.NL_var(___nl__1).clone();

//line 9
___nl__1 = null;
//line 9
if(true) return ___nl__0;
//line 9
___nl__0 = null;
//line 9
if(true) return null;
}

}
}