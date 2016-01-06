using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class func_NL {

public static Imm NL_exec(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.clone();
Imm ___nl__2 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 9
___ref______nl__1 = new ImmRef(___nl__1);
___nl__2 = c_std_lib_NL.NL_exec(___nl__0,___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 9
___nl__0 = null;
//line 9
___nl__1 = null;
//line 9
if(true) return ___nl__2;
//line 9
___nl__2 = null;
//line 9
___nl__0 = null;
//line 9
___nl__1 = null;
//line 9
if(true) return null;
}

public static Imm NL_exec_ref(Imm ___arg__0, ImmRef ___arg__1) {
Imm ___nl__0 = ___arg__0.clone();Imm ___nl__1 = ___arg__1.getValue().clone();
Imm ___nl__2 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 13
___ref______nl__1 = new ImmRef(___nl__1);
___nl__2 = c_std_lib_NL.NL_exec(___nl__0,___ref______nl__1).clone();
___nl__1 = ___ref______nl__1.getValue().clone();

//line 13
___nl__0 = null;
//line 13
___arg__1.setValue(___nl__1);if(true) return ___nl__2;
//line 13
___nl__2 = null;
//line 13
___nl__0 = null;
//line 13
___arg__1.setValue(___nl__1);if(true) return null;
}

}
}