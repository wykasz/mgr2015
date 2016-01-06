using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class flow_graph_NL {

public static Imm NL_SINGLETON_block_t() {

Imm ___nl__0 = null;
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
//line 12
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("nlasm_NL"));
__function_map.Add("name",new ImmString("cmd_t"));
___nl__3 = new ImmHash(__function_map).clone();
//line 12
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3).clone();
//line 12
___nl__2 = ptd_NL.NL_arr(___nl__3).clone();

//line 12
___nl__3 = null;
//line 12
___nl__3 = ptd_NL.NL_sim().clone();

//line 12
___nl__4 = ptd_NL.NL_sim().clone();

//line 12
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("flow_graph_NL"));
__function_map.Add("name",new ImmString("reg_use_t"));
___nl__6 = new ImmHash(__function_map).clone();
//line 12
___nl__6 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__6).clone();
//line 12
___nl__5 = ptd_NL.NL_arr(___nl__6).clone();

//line 12
___nl__6 = null;
//line 12
___nl__9 = ptd_NL.NL_sim().clone();

//line 12
___nl__10 = ptd_NL.NL_none().clone();

//line 12
__function_map = new Dictionary<String, Imm>();
__function_map.Add("write",___nl__9);
__function_map.Add("clear",___nl__10);
___nl__8 = new ImmHash(__function_map).clone();
//line 12
___nl__9 = null;
//line 12
___nl__10 = null;
//line 12
___nl__7 = ptd_NL.NL_var(___nl__8).clone();

//line 12
___nl__8 = null;
//line 12
___nl__6 = ptd_NL.NL_hash(___nl__7).clone();

//line 12
___nl__7 = null;
//line 12
___nl__8 = ptd_NL.NL_sim().clone();

//line 12
___nl__7 = ptd_NL.NL_arr(___nl__8).clone();

//line 12
___nl__8 = null;
//line 12
___nl__9 = ptd_NL.NL_sim().clone();

//line 12
___nl__8 = ptd_NL.NL_arr(___nl__9).clone();

//line 12
___nl__9 = null;
//line 12
__function_map = new Dictionary<String, Imm>();
__function_map.Add("cmds",___nl__2);
__function_map.Add("from",___nl__3);
__function_map.Add("to",___nl__4);
__function_map.Add("reg_uses",___nl__5);
__function_map.Add("last_modif",___nl__6);
__function_map.Add("prev",___nl__7);
__function_map.Add("next",___nl__8);
___nl__1 = new ImmHash(__function_map).clone();
//line 12
___nl__2 = null;
//line 12
___nl__3 = null;
//line 12
___nl__4 = null;
//line 12
___nl__5 = null;
//line 12
___nl__6 = null;
//line 12
___nl__7 = null;
//line 12
___nl__8 = null;
//line 12
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 12
___nl__1 = null;
//line 12
if(true) return ___nl__0;
//line 12
___nl__0 = null;
//line 12
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_block_t = null;
public static Imm NL_block_t() {
	if (value__singleton__NL_SINGLETON_block_t == null) {
		value__singleton__NL_SINGLETON_block_t = NL_SINGLETON_block_t();
	}
	return value__singleton__NL_SINGLETON_block_t;
}
public static Imm NL_SINGLETON_reg_use_t() {

Imm ___nl__0 = null;
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
//line 28
___nl__2 = ptd_NL.NL_sim().clone();

//line 28
___nl__3 = ptd_NL.NL_sim().clone();

//line 28
___nl__6 = ptd_NL.NL_none().clone();

//line 28
___nl__7 = ptd_NL.NL_none().clone();

//line 28
___nl__8 = ptd_NL.NL_none().clone();

//line 28
__function_map = new Dictionary<String, Imm>();
__function_map.Add("write",___nl__6);
__function_map.Add("read",___nl__7);
__function_map.Add("clear",___nl__8);
___nl__5 = new ImmHash(__function_map).clone();
//line 28
___nl__6 = null;
//line 28
___nl__7 = null;
//line 28
___nl__8 = null;
//line 28
___nl__4 = ptd_NL.NL_var(___nl__5).clone();

//line 28
___nl__5 = null;
//line 28
__function_map = new Dictionary<String, Imm>();
__function_map.Add("reg",___nl__2);
__function_map.Add("cmd_nr",___nl__3);
__function_map.Add("type",___nl__4);
___nl__1 = new ImmHash(__function_map).clone();
//line 28
___nl__2 = null;
//line 28
___nl__3 = null;
//line 28
___nl__4 = null;
//line 28
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 28
___nl__1 = null;
//line 28
if(true) return ___nl__0;
//line 28
___nl__0 = null;
//line 28
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_reg_use_t = null;
public static Imm NL_reg_use_t() {
	if (value__singleton__NL_SINGLETON_reg_use_t == null) {
		value__singleton__NL_SINGLETON_reg_use_t = NL_SINGLETON_reg_use_t();
	}
	return value__singleton__NL_SINGLETON_reg_use_t;
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
//line 40
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("flow_graph_NL"));
__function_map.Add("name",new ImmString("block_t"));
___nl__3 = new ImmHash(__function_map).clone();
//line 40
___nl__3 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__3).clone();
//line 40
___nl__2 = ptd_NL.NL_hash(___nl__3).clone();

//line 40
___nl__3 = null;
//line 40
___nl__4 = ptd_NL.NL_sim().clone();

//line 40
___nl__3 = ptd_NL.NL_arr(___nl__4).clone();

//line 40
___nl__4 = null;
//line 40
__function_map = new Dictionary<String, Imm>();
__function_map.Add("map",___nl__2);
__function_map.Add("tab",___nl__3);
___nl__1 = new ImmHash(__function_map).clone();
//line 40
___nl__2 = null;
//line 40
___nl__3 = null;
//line 40
___nl__0 = ptd_NL.NL_rec(___nl__1).clone();

//line 40
___nl__1 = null;
//line 40
if(true) return ___nl__0;
//line 40
___nl__0 = null;
//line 40
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_state_t = null;
public static Imm NL_state_t() {
	if (value__singleton__NL_SINGLETON_state_t == null) {
		value__singleton__NL_SINGLETON_state_t = NL_SINGLETON_state_t();
	}
	return value__singleton__NL_SINGLETON_state_t;
}
public static Imm NL_SINGLETON_blocks_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 46
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("flow_graph_NL"));
__function_map.Add("name",new ImmString("block_t"));
___nl__1 = new ImmHash(__function_map).clone();
//line 46
___nl__1 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__1).clone();
//line 46
___nl__0 = ptd_NL.NL_arr(___nl__1).clone();

//line 46
___nl__1 = null;
//line 46
if(true) return ___nl__0;
//line 46
___nl__0 = null;
//line 46
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_blocks_t = null;
public static Imm NL_blocks_t() {
	if (value__singleton__NL_SINGLETON_blocks_t == null) {
		value__singleton__NL_SINGLETON_blocks_t = NL_SINGLETON_blocks_t();
	}
	return value__singleton__NL_SINGLETON_blocks_t;
}
public static Imm NL_make_blocks(Imm ___arg__0, Imm ___arg__1) {
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
//line 49
___nl__2 = flow_graph_NL.NL_mk_blocks_priv(___nl__0,___nl__1).clone();

//line 50
___nl__3 = new ImmString("map").clone();
//line 50
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__2,___nl__3).clone();

//line 50
___nl__4 = ((ImmHash)___nl__2).getHashValue()["tab"].clone();
//line 50
___nl__5 = new ImmDouble(0).clone();
//line 50
___nl__4 = (___nl__4 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()].clone();
//line 50
___nl__5 = null;
//line 50
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_set_prev_block_priv(___ref______nl__3,___nl__4);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 50
___nl__4 = null;
//line 50
___nl__4 = new ImmString("map").clone();
//line 50
___ref______nl__2 = new ImmRef(___nl__2);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__2,___nl__4,___nl__3);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 50
___nl__4 = null;
//line 50
___nl__3 = null;
//line 51
___ref______nl__2 = new ImmRef(___nl__2);
flow_graph_NL.NL_remove_unused_block_priv(___ref______nl__2);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 52
___nl__3 = flow_graph_NL.NL_block_name_to_nr_priv(___nl__2).clone();

//line 53
___nl__0 = null;
//line 53
___nl__1 = null;
//line 53
___nl__2 = null;
//line 53
if(true) return ___nl__3;
//line 53
___nl__2 = null;
//line 53
___nl__3 = null;
//line 53
___nl__0 = null;
//line 53
___nl__1 = null;
//line 53
if(true) return null;
}

private static Imm NL_block_name_to_nr_priv(Imm ___arg__0) {
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
Imm ___nl__14 = null;
Imm ___nl__15 = null;
Imm ___nl__16 = null;
Imm ___nl__17 = null;
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
ImmRef ___ref______nl__15 = null;
ImmRef ___ref______nl__16 = null;
ImmRef ___ref______nl__17 = null;
Dictionary<String, Imm> __function_map;
//line 56
__function_map = new Dictionary<String, Imm>();
___nl__1 = new ImmHash(__function_map).clone();
//line 57
___nl__2 = ((ImmHash)___nl__0).getHashValue()["tab"].clone();
//line 58
___nl__3 = array_NL.NL_len(___nl__2).clone();

//line 58
___nl__4 = new ImmDouble(0).clone();
//line 58
___nl__5 = new ImmDouble(1).clone();
//line 58
label_3:
//line 58
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__3.getValue().ToString())) ).clone();
//line 58
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_1;}}
//line 59
___nl__7 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__4).getDoubleValue()].clone();
//line 59
___ref______nl__1 = new ImmRef(___nl__1);
hash_NL.NL_set_value(___ref______nl__1,___nl__7,___nl__4);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 59
___nl__7 = null;
//line 60
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 60
if (true) {goto label_3;}
//line 60
label_1:
//line 60
___nl__3 = null;
//line 60
___nl__4 = null;
//line 60
___nl__5 = null;
//line 60
___nl__6 = null;
//line 61
___nl__3 = new ImmArray(new Imm[0]).clone();
//line 62
___nl__5 = new ImmDouble(0).clone();
//line 62
___nl__6 = new ImmDouble(1).clone();
//line 62
___nl__7 = c_rt_lib_NL.NL_array_len(___nl__2).clone();

//line 62
label_6:
//line 62
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) ).clone();
//line 62
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_4;}}
//line 62
___nl__4 = (___nl__2 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()].clone();
//line 63
___nl__10 = ((ImmHash)___nl__0).getHashValue()["map"].clone();
//line 63
___nl__9 = hash_NL.NL_get_value(___nl__10,___nl__4).clone();

//line 63
___nl__10 = null;
//line 64
___nl__10 = ((ImmHash)___nl__9).getHashValue()["next"].clone();
//line 65
___nl__11 = array_NL.NL_len(___nl__10).clone();

//line 65
___nl__12 = new ImmDouble(0).clone();
//line 65
___nl__13 = new ImmDouble(1).clone();
//line 65
label_9:
//line 65
___nl__14 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__12.getValue().ToString()))>=(Double.Parse(___nl__11.getValue().ToString())) ).clone();
//line 65
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_7;}}
//line 66
___nl__16 = (___nl__10 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__12).getDoubleValue()].clone();
//line 66
___nl__15 = hash_NL.NL_get_value(___nl__1,___nl__16).clone();

//line 66
___nl__16 = null;
//line 66
___nl__16 = ___nl__15.clone();
//line 66
(___nl__10 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__12).getDoubleValue()] = ___nl__16;
//line 66
___nl__15 = null;
//line 66
___nl__16 = null;
//line 67
___nl__12 = new ImmDouble((Double.Parse(___nl__12.getValue().ToString()))+(Double.Parse(___nl__13.getValue().ToString()))).clone();
//line 67
if (true) {goto label_9;}
//line 67
label_7:
//line 67
___nl__11 = null;
//line 67
___nl__12 = null;
//line 67
___nl__13 = null;
//line 67
___nl__14 = null;
//line 68
___nl__11 = ___nl__10.clone();
//line 68
((ImmHash)___nl__9).set("next", ___nl__11);
//line 68
___nl__11 = null;
//line 69
___nl__11 = ((ImmHash)___nl__9).getHashValue()["prev"].clone();
//line 70
___nl__12 = array_NL.NL_len(___nl__11).clone();

//line 70
___nl__13 = new ImmDouble(0).clone();
//line 70
___nl__14 = new ImmDouble(1).clone();
//line 70
label_12:
//line 70
___nl__15 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__13.getValue().ToString()))>=(Double.Parse(___nl__12.getValue().ToString())) ).clone();
//line 70
if (c_rt_lib_NL.NL_check_true_native(___nl__15)) {if (true) {goto label_10;}}
//line 71
___nl__17 = (___nl__11 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__13).getDoubleValue()].clone();
//line 71
___nl__16 = hash_NL.NL_get_value(___nl__1,___nl__17).clone();

//line 71
___nl__17 = null;
//line 71
___nl__17 = ___nl__16.clone();
//line 71
(___nl__11 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__13).getDoubleValue()] = ___nl__17;
//line 71
___nl__16 = null;
//line 71
___nl__17 = null;
//line 72
___nl__13 = new ImmDouble((Double.Parse(___nl__13.getValue().ToString()))+(Double.Parse(___nl__14.getValue().ToString()))).clone();
//line 72
if (true) {goto label_12;}
//line 72
label_10:
//line 72
___nl__12 = null;
//line 72
___nl__13 = null;
//line 72
___nl__14 = null;
//line 72
___nl__15 = null;
//line 73
___nl__12 = ___nl__11.clone();
//line 73
((ImmHash)___nl__9).set("prev", ___nl__12);
//line 73
___nl__12 = null;
//line 74
___ref______nl__3 = new ImmRef(___nl__3);
array_NL.NL_push(___ref______nl__3,___nl__9);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 74
___nl__9 = null;
//line 74
___nl__10 = null;
//line 74
___nl__11 = null;
//line 75
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString()))).clone();
//line 75
if (true) {goto label_6;}
//line 75
label_4:
//line 75
___nl__4 = null;
//line 75
___nl__5 = null;
//line 75
___nl__6 = null;
//line 75
___nl__7 = null;
//line 75
___nl__8 = null;
//line 76
___nl__0 = null;
//line 76
___nl__1 = null;
//line 76
___nl__2 = null;
//line 76
if(true) return ___nl__3;
//line 76
___nl__1 = null;
//line 76
___nl__2 = null;
//line 76
___nl__3 = null;
//line 76
___nl__0 = null;
//line 76
if(true) return null;
}

public static Imm NL_combine_blocks(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
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
//line 79
___nl__1 = new ImmArray(new Imm[0]).clone();
//line 80
___nl__3 = new ImmDouble(0).clone();
//line 80
___nl__4 = new ImmDouble(1).clone();
//line 80
___nl__5 = c_rt_lib_NL.NL_array_len(___nl__0).clone();

//line 80
label_3:
//line 80
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))>=(Double.Parse(___nl__5.getValue().ToString())) ).clone();
//line 80
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_1;}}
//line 80
___nl__2 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__3).getDoubleValue()].clone();
//line 81
___nl__7 = ((ImmHash)___nl__2).getHashValue()["cmds"].clone();
//line 81
___ref______nl__1 = new ImmRef(___nl__1);
array_NL.NL_append(___ref______nl__1,___nl__7);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 81
___nl__7 = null;
//line 82
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__4.getValue().ToString()))).clone();
//line 82
if (true) {goto label_3;}
//line 82
label_1:
//line 82
___nl__2 = null;
//line 82
___nl__3 = null;
//line 82
___nl__4 = null;
//line 82
___nl__5 = null;
//line 82
___nl__6 = null;
//line 83
___nl__3 = array_NL.NL_len(___nl__1).clone();

//line 83
___nl__4 = new ImmDouble(1).clone();
//line 83
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))-(Double.Parse(___nl__4.getValue().ToString()))).clone();
//line 83
___nl__4 = null;
//line 83
___nl__2 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__3).getDoubleValue()].clone();
//line 83
___nl__3 = null;
//line 83
___nl__2 = ((ImmHash)___nl__2).getHashValue()["cmd"].clone();
//line 83
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("return")).clone();
//line 83
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 83
___nl__2 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__2)).clone();
//line 83
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_5;}}
//line 84
___nl__4 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("emp")).clone();
//line 84
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("return"), ___nl__4).clone();
//line 84
___nl__5 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("none")).clone();
//line 84
___nl__6 = nlasm_NL.NL_empty_debug().clone();

//line 84
__function_map = new Dictionary<String, Imm>();
__function_map.Add("cmd",___nl__4);
__function_map.Add("annotation",___nl__5);
__function_map.Add("debug",___nl__6);
___nl__3 = new ImmHash(__function_map).clone();
//line 84
___nl__4 = null;
//line 84
___nl__5 = null;
//line 84
___nl__6 = null;
//line 84
___ref______nl__1 = new ImmRef(___nl__1);
array_NL.NL_push(___ref______nl__1,___nl__3);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 84
___nl__3 = null;
//line 85
if (true) {goto label_5;}
//line 85
label_5:
//line 85
___nl__2 = null;
//line 86
___nl__0 = null;
//line 86
if(true) return ___nl__1;
//line 86
___nl__1 = null;
//line 86
___nl__0 = null;
//line 86
if(true) return null;
}

private static Imm NL_remove_unused_block_priv(ImmRef ___arg__0) {
Imm ___nl__0 = ___arg__0.getValue().clone();
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
//line 90
___nl__1 = new ImmArray(new Imm[0]).clone();
//line 91
__function_map = new Dictionary<String, Imm>();
___nl__2 = new ImmHash(__function_map).clone();
//line 92
___nl__3 = c_rt_lib_NL.NL_get_true().clone();
//line 93
___nl__4 = ((ImmHash)___nl__0).getHashValue()["map"].clone();
//line 94
___nl__5 = ((ImmHash)___nl__0).getHashValue()["tab"].clone();
//line 94
___nl__7 = new ImmDouble(0).clone();
//line 94
___nl__8 = new ImmDouble(1).clone();
//line 94
___nl__9 = c_rt_lib_NL.NL_array_len(___nl__5).clone();

//line 94
label_3:
//line 94
___nl__10 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))>=(Double.Parse(___nl__9.getValue().ToString())) ).clone();
//line 94
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_1;}}
//line 94
___nl__6 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()].clone();
//line 95
___nl__11 = hash_NL.NL_get_value(___nl__4,___nl__6).clone();

//line 96
___nl__13 = ((ImmHash)___nl__11).getHashValue()["prev"].clone();
//line 96
___nl__12 = array_NL.NL_len(___nl__13).clone();

//line 96
___nl__13 = null;
//line 96
___nl__13 = new ImmDouble(0).clone();
//line 96
___nl__12 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__12.getValue().ToString())) ==((Double.Parse(___nl__13.getValue().ToString())))  ).clone();
//line 96
___nl__13 = null;
//line 96
___nl__12 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__12)).clone();
//line 96
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_5;}}
//line 97
___nl__13 = ___nl__3.clone();
//line 97
___nl__13 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__13)).clone();
//line 97
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_7;}}
//line 98
___nl__14 = c_rt_lib_NL.NL_get_false().clone();
//line 98
___nl__3 = ___nl__14.clone();
//line 98
___nl__14 = null;
//line 99
if (true) {goto label_6;}
//line 99
label_7:
//line 100
___nl__11 = null;
//line 100
___nl__12 = null;
//line 100
___nl__13 = null;
//line 100
if (true) {goto label_2;}
//line 101
if (true) {goto label_6;}
//line 101
label_6:
//line 101
___nl__13 = null;
//line 102
if (true) {goto label_5;}
//line 102
label_5:
//line 102
___nl__12 = null;
//line 103
___ref______nl__2 = new ImmRef(___nl__2);
hash_NL.NL_set_value(___ref______nl__2,___nl__6,___nl__11);
___nl__2 = ___ref______nl__2.getValue().clone();

//line 104
___ref______nl__1 = new ImmRef(___nl__1);
array_NL.NL_push(___ref______nl__1,___nl__6);
___nl__1 = ___ref______nl__1.getValue().clone();

//line 104
___nl__11 = null;
//line 104
label_2:
//line 105
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString()))).clone();
//line 105
if (true) {goto label_3;}
//line 105
label_1:
//line 105
___nl__5 = null;
//line 105
___nl__6 = null;
//line 105
___nl__7 = null;
//line 105
___nl__8 = null;
//line 105
___nl__9 = null;
//line 105
___nl__10 = null;
//line 106
___nl__5 = ___nl__2.clone();
//line 106
((ImmHash)___nl__0).set("map", ___nl__5);
//line 106
___nl__5 = null;
//line 107
___nl__5 = ___nl__1.clone();
//line 107
((ImmHash)___nl__0).set("tab", ___nl__5);
//line 107
___nl__5 = null;
//line 107
___nl__1 = null;
//line 107
___nl__2 = null;
//line 107
___nl__3 = null;
//line 107
___nl__4 = null;
//line 107
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_set_prev_block_priv(ImmRef ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.clone();
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
//line 110
___nl__2 = hash_NL.NL_get_value(___nl__0,___nl__1).clone();

//line 111
___nl__4 = ((ImmHash)___nl__2).getHashValue()["prev"].clone();
//line 111
___nl__3 = array_NL.NL_len(___nl__4).clone();

//line 111
___nl__4 = null;
//line 111
___nl__4 = new ImmDouble(1).clone();
//line 111
___nl__3 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__3.getValue().ToString()))<=(Double.Parse(___nl__4.getValue().ToString())) ).clone();
//line 111
___nl__4 = null;
//line 111
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 111
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 111
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 111
___nl__1 = null;
//line 111
___nl__2 = null;
//line 111
___nl__3 = null;
//line 111
___arg__0.setValue(___nl__0);if(true) return null;
//line 111
if (true) {goto label_2;}
//line 111
label_2:
//line 111
___nl__3 = null;
//line 112
___nl__3 = ((ImmHash)___nl__2).getHashValue()["next"].clone();
//line 112
___nl__5 = new ImmDouble(0).clone();
//line 112
___nl__6 = new ImmDouble(1).clone();
//line 112
___nl__7 = c_rt_lib_NL.NL_array_len(___nl__3).clone();

//line 112
label_5:
//line 112
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) ).clone();
//line 112
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_3;}}
//line 112
___nl__4 = (___nl__3 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()].clone();
//line 113
___nl__9 = hash_NL.NL_get_value(___nl__0,___nl__4).clone();

//line 114
___nl__10 = new ImmString("prev").clone();
//line 114
___nl__10 = c_rt_lib_NL.NL_get_ref_hash(___nl__9,___nl__10).clone();

//line 114
___ref______nl__10 = new ImmRef(___nl__10);
array_NL.NL_push(___ref______nl__10,___nl__1);
___nl__10 = ___ref______nl__10.getValue().clone();

//line 114
___nl__11 = new ImmString("prev").clone();
//line 114
___ref______nl__9 = new ImmRef(___nl__9);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__9,___nl__11,___nl__10);
___nl__9 = ___ref______nl__9.getValue().clone();

//line 114
___nl__11 = null;
//line 114
___nl__10 = null;
//line 115
___ref______nl__0 = new ImmRef(___nl__0);
hash_NL.NL_set_value(___ref______nl__0,___nl__4,___nl__9);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 116
___ref______nl__0 = new ImmRef(___nl__0);
flow_graph_NL.NL_set_prev_block_priv(___ref______nl__0,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 116
___nl__9 = null;
//line 117
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString()))).clone();
//line 117
if (true) {goto label_5;}
//line 117
label_3:
//line 117
___nl__3 = null;
//line 117
___nl__4 = null;
//line 117
___nl__5 = null;
//line 117
___nl__6 = null;
//line 117
___nl__7 = null;
//line 117
___nl__8 = null;
//line 117
___nl__2 = null;
//line 117
___nl__1 = null;
//line 117
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_mk_block_priv(Imm ___arg__0) {
Imm ___nl__0 = ___arg__0.clone();
Imm ___nl__1 = null;
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
//line 121
___nl__2 = new ImmArray(new Imm[0]).clone();
//line 121
___nl__3 = new ImmArray(new Imm[0]).clone();
//line 121
___nl__4 = new ImmDouble(1).clone();
//line 121
___nl__4 = new ImmDouble(-((ImmDouble)___nl__4).getDoubleValue()).clone();
//line 121
___nl__5 = new ImmArray(new Imm[0]).clone();
//line 121
__function_map = new Dictionary<String, Imm>();
___nl__6 = new ImmHash(__function_map).clone();
//line 121
___nl__7 = new ImmArray(new Imm[0]).clone();
//line 121
__function_map = new Dictionary<String, Imm>();
__function_map.Add("cmds",___nl__2);
__function_map.Add("prev",___nl__3);
__function_map.Add("from",___nl__0);
__function_map.Add("to",___nl__4);
__function_map.Add("reg_uses",___nl__5);
__function_map.Add("last_modif",___nl__6);
__function_map.Add("next",___nl__7);
___nl__1 = new ImmHash(__function_map).clone();
//line 121
___nl__2 = null;
//line 121
___nl__3 = null;
//line 121
___nl__4 = null;
//line 121
___nl__5 = null;
//line 121
___nl__6 = null;
//line 121
___nl__7 = null;
//line 121
___nl__0 = null;
//line 121
if(true) return ___nl__1;
//line 121
___nl__1 = null;
//line 121
___nl__0 = null;
//line 121
if(true) return null;
}

private static Imm NL_add_block_priv(ImmRef ___arg__0, ImmRef ___arg__1, Imm ___arg__2, Imm ___arg__3) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.getValue().clone();Imm ___nl__2 = ___arg__2.clone();Imm ___nl__3 = ___arg__3.clone();
Imm ___nl__4 = null;
Imm ___nl__5 = null;
ImmRef ___ref______nl__0 = null;
ImmRef ___ref______nl__1 = null;
ImmRef ___ref______nl__2 = null;
ImmRef ___ref______nl__3 = null;
ImmRef ___ref______nl__4 = null;
ImmRef ___ref______nl__5 = null;
Dictionary<String, Imm> __function_map;
//line 124
___nl__4 = ___nl__2.clone();
//line 124
((ImmHash)___nl__1).set("to", ___nl__4);
//line 124
___nl__4 = null;
//line 125
___nl__4 = new ImmString("map").clone();
//line 125
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__4).clone();

//line 125
___ref______nl__4 = new ImmRef(___nl__4);
hash_NL.NL_set_value(___ref______nl__4,___nl__3,___nl__1);
___nl__4 = ___ref______nl__4.getValue().clone();

//line 125
___nl__5 = new ImmString("map").clone();
//line 125
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 125
___nl__5 = null;
//line 125
___nl__4 = null;
//line 126
___nl__4 = new ImmString("tab").clone();
//line 126
___nl__4 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__4).clone();

//line 126
___ref______nl__4 = new ImmRef(___nl__4);
array_NL.NL_push(___ref______nl__4,___nl__3);
___nl__4 = ___ref______nl__4.getValue().clone();

//line 126
___nl__5 = new ImmString("tab").clone();
//line 126
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__5,___nl__4);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 126
___nl__5 = null;
//line 126
___nl__4 = null;
//line 127
___nl__5 = new ImmDouble(1).clone();
//line 127
___nl__5 = new ImmDouble((Double.Parse(___nl__2.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 127
___nl__4 = flow_graph_NL.NL_mk_block_priv(___nl__5).clone();

//line 127
___nl__5 = null;
//line 127
___nl__1 = ___nl__4.clone();
//line 127
___nl__4 = null;
//line 127
___nl__2 = null;
//line 127
___nl__3 = null;
//line 127
___arg__0.setValue(___nl__0);___arg__1.setValue(___nl__1);if(true) return null;
}

private static Imm NL_read_reg_priv(ImmRef ___arg__0, Imm ___arg__1, Imm ___arg__2) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();
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
//line 130
___nl__3 = new ImmString("").clone();
//line 130
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__1.toString().Equals(___nl__3.toString())).clone();
//line 130
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 130
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 130
___nl__1 = null;
//line 130
___nl__2 = null;
//line 130
___nl__3 = null;
//line 130
___arg__0.setValue(___nl__0);if(true) return null;
//line 130
if (true) {goto label_2;}
//line 130
label_2:
//line 130
___nl__3 = null;
//line 131
___nl__3 = new ImmString("reg_uses").clone();
//line 131
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__3).clone();

//line 131
___nl__5 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("read")).clone();
//line 131
__function_map = new Dictionary<String, Imm>();
__function_map.Add("reg",___nl__1);
__function_map.Add("cmd_nr",___nl__2);
__function_map.Add("type",___nl__5);
___nl__4 = new ImmHash(__function_map).clone();
//line 131
___nl__5 = null;
//line 131
___ref______nl__3 = new ImmRef(___nl__3);
array_NL.NL_push(___ref______nl__3,___nl__4);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 131
___nl__4 = null;
//line 131
___nl__4 = new ImmString("reg_uses").clone();
//line 131
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__4,___nl__3);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 131
___nl__4 = null;
//line 131
___nl__3 = null;
//line 131
___nl__1 = null;
//line 131
___nl__2 = null;
//line 131
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_write_reg_priv(ImmRef ___arg__0, Imm ___arg__1, Imm ___arg__2) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();
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
___nl__3 = new ImmString("").clone();
//line 134
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__1.toString().Equals(___nl__3.toString())).clone();
//line 134
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 134
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 134
___nl__1 = null;
//line 134
___nl__2 = null;
//line 134
___nl__3 = null;
//line 134
___arg__0.setValue(___nl__0);if(true) return null;
//line 134
if (true) {goto label_2;}
//line 134
label_2:
//line 134
___nl__3 = null;
//line 135
___nl__3 = new ImmString("reg_uses").clone();
//line 135
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__3).clone();

//line 135
___nl__5 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("write")).clone();
//line 135
__function_map = new Dictionary<String, Imm>();
__function_map.Add("reg",___nl__1);
__function_map.Add("cmd_nr",___nl__2);
__function_map.Add("type",___nl__5);
___nl__4 = new ImmHash(__function_map).clone();
//line 135
___nl__5 = null;
//line 135
___ref______nl__3 = new ImmRef(___nl__3);
array_NL.NL_push(___ref______nl__3,___nl__4);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 135
___nl__4 = null;
//line 135
___nl__4 = new ImmString("reg_uses").clone();
//line 135
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__4,___nl__3);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 135
___nl__4 = null;
//line 135
___nl__3 = null;
//line 136
___nl__3 = new ImmString("last_modif").clone();
//line 136
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__3).clone();

//line 136
___nl__4 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("write"), ___nl__2).clone();
//line 136
___ref______nl__3 = new ImmRef(___nl__3);
hash_NL.NL_set_value(___ref______nl__3,___nl__1,___nl__4);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 136
___nl__4 = null;
//line 136
___nl__4 = new ImmString("last_modif").clone();
//line 136
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__4,___nl__3);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 136
___nl__4 = null;
//line 136
___nl__3 = null;
//line 136
___nl__1 = null;
//line 136
___nl__2 = null;
//line 136
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_clear_reg_priv(ImmRef ___arg__0, Imm ___arg__1, Imm ___arg__2) {
Imm ___nl__0 = ___arg__0.getValue().clone();Imm ___nl__1 = ___arg__1.clone();Imm ___nl__2 = ___arg__2.clone();
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
//line 139
___nl__3 = new ImmString("").clone();
//line 139
___nl__3 = c_rt_lib_NL.NL_native_to_nl(___nl__1.toString().Equals(___nl__3.toString())).clone();
//line 139
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 139
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 139
___nl__1 = null;
//line 139
___nl__2 = null;
//line 139
___nl__3 = null;
//line 139
___arg__0.setValue(___nl__0);if(true) return null;
//line 139
if (true) {goto label_2;}
//line 139
label_2:
//line 139
___nl__3 = null;
//line 140
___nl__3 = new ImmString("reg_uses").clone();
//line 140
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__3).clone();

//line 140
___nl__5 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("clear")).clone();
//line 140
__function_map = new Dictionary<String, Imm>();
__function_map.Add("reg",___nl__1);
__function_map.Add("cmd_nr",___nl__2);
__function_map.Add("type",___nl__5);
___nl__4 = new ImmHash(__function_map).clone();
//line 140
___nl__5 = null;
//line 140
___ref______nl__3 = new ImmRef(___nl__3);
array_NL.NL_push(___ref______nl__3,___nl__4);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 140
___nl__4 = null;
//line 140
___nl__4 = new ImmString("reg_uses").clone();
//line 140
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__4,___nl__3);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 140
___nl__4 = null;
//line 140
___nl__3 = null;
//line 141
___nl__3 = new ImmString("last_modif").clone();
//line 141
___nl__3 = c_rt_lib_NL.NL_get_ref_hash(___nl__0,___nl__3).clone();

//line 141
___nl__4 = c_rt_lib_NL.NL_ov_mk_none(new ImmString("clear")).clone();
//line 141
___ref______nl__3 = new ImmRef(___nl__3);
hash_NL.NL_set_value(___ref______nl__3,___nl__1,___nl__4);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 141
___nl__4 = null;
//line 141
___nl__4 = new ImmString("last_modif").clone();
//line 141
___ref______nl__0 = new ImmRef(___nl__0);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__0,___nl__4,___nl__3);
___nl__0 = ___ref______nl__0.getValue().clone();

//line 141
___nl__4 = null;
//line 141
___nl__3 = null;
//line 141
___nl__1 = null;
//line 141
___nl__2 = null;
//line 141
___arg__0.setValue(___nl__0);if(true) return null;
}

private static Imm NL_mk_blocks_priv(Imm ___arg__0, Imm ___arg__1) {
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
Imm ___nl__12 = null;
Imm ___nl__13 = null;
Imm ___nl__14 = null;
Imm ___nl__15 = null;
Imm ___nl__16 = null;
Imm ___nl__17 = null;
Imm ___nl__18 = null;
Imm ___nl__19 = null;
Imm ___nl__20 = null;
Imm ___nl__21 = null;
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
ImmRef ___ref______nl__15 = null;
ImmRef ___ref______nl__16 = null;
ImmRef ___ref______nl__17 = null;
ImmRef ___ref______nl__18 = null;
ImmRef ___ref______nl__19 = null;
ImmRef ___ref______nl__20 = null;
ImmRef ___ref______nl__21 = null;
Dictionary<String, Imm> __function_map;
//line 144
__function_map = new Dictionary<String, Imm>();
___nl__3 = new ImmHash(__function_map).clone();
//line 144
___nl__4 = new ImmArray(new Imm[0]).clone();
//line 144
__function_map = new Dictionary<String, Imm>();
__function_map.Add("map",___nl__3);
__function_map.Add("tab",___nl__4);
___nl__2 = new ImmHash(__function_map).clone();
//line 144
___nl__3 = null;
//line 144
___nl__4 = null;
//line 145
___nl__4 = new ImmDouble(0).clone();
//line 145
___nl__3 = flow_graph_NL.NL_mk_block_priv(___nl__4).clone();

//line 145
___nl__4 = null;
//line 146
___nl__4 = new ImmString("label_init").clone();
//line 147
___nl__5 = new ImmDouble(0).clone();
//line 148
___nl__7 = new ImmDouble(0).clone();
//line 148
___nl__8 = new ImmDouble(1).clone();
//line 148
___nl__9 = c_rt_lib_NL.NL_array_len(___nl__0).clone();

//line 148
label_3:
//line 148
___nl__10 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))>=(Double.Parse(___nl__9.getValue().ToString())) ).clone();
//line 148
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_1;}}
//line 148
___nl__6 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()].clone();
//line 149
___nl__11 = new ImmString("cmds").clone();
//line 149
___nl__11 = c_rt_lib_NL.NL_get_ref_hash(___nl__3,___nl__11).clone();

//line 149
___ref______nl__11 = new ImmRef(___nl__11);
array_NL.NL_push(___ref______nl__11,___nl__6);
___nl__11 = ___ref______nl__11.getValue().clone();

//line 149
___nl__12 = new ImmString("cmds").clone();
//line 149
___ref______nl__3 = new ImmRef(___nl__3);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__3,___nl__12,___nl__11);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 149
___nl__12 = null;
//line 149
___nl__11 = null;
//line 150
___nl__11 = ((ImmHash)___nl__6).getHashValue()["cmd"].clone();
//line 150
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("arr_decl")).clone();
//line 150
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_5;}}
//line 155
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("hash_decl")).clone();
//line 155
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_6;}}
//line 160
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("call")).clone();
//line 160
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_7;}}
//line 175
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("una_op")).clone();
//line 175
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_8;}}
//line 178
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("bin_op")).clone();
//line 178
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_9;}}
//line 182
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("ov_is")).clone();
//line 182
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_10;}}
//line 185
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("ov_as")).clone();
//line 185
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_11;}}
//line 188
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("func")).clone();
//line 188
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_12;}}
//line 190
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("move")).clone();
//line 190
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_13;}}
//line 193
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("load_const")).clone();
//line 193
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_14;}}
//line 195
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("get_frm_idx")).clone();
//line 195
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_15;}}
//line 199
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("set_at_idx")).clone();
//line 199
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_16;}}
//line 204
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("get_val")).clone();
//line 204
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_17;}}
//line 207
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("set_val")).clone();
//line 207
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_18;}}
//line 211
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("ov_mk")).clone();
//line 211
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_19;}}
//line 214
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("return")).clone();
//line 214
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_20;}}
//line 223
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("die")).clone();
//line 223
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_21;}}
//line 227
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("prt_lbl")).clone();
//line 227
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_22;}}
//line 235
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("if_goto")).clone();
//line 235
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_23;}}
//line 245
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("goto")).clone();
//line 245
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_24;}}
//line 249
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__11, new ImmString("clear")).clone();
//line 249
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_25;}}
//line 249
___nl__12 = new ImmString("NOMATCHALERT").clone();
//line 249
___nl__12 = new ImmArray(new Imm[] {___nl__12,___nl__11,}).clone();
//line 249
c_rt_lib_NL.NL_die();
//line 150
label_5:
//line 150
___nl__13 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("arr_decl")).clone();
//line 151
___nl__14 = ((ImmHash)___nl__13).getHashValue()["src"].clone();
//line 151
___nl__16 = new ImmDouble(0).clone();
//line 151
___nl__17 = new ImmDouble(1).clone();
//line 151
___nl__18 = c_rt_lib_NL.NL_array_len(___nl__14).clone();

//line 151
label_28:
//line 151
___nl__19 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__16.getValue().ToString()))>=(Double.Parse(___nl__18.getValue().ToString())) ).clone();
//line 151
if (c_rt_lib_NL.NL_check_true_native(___nl__19)) {if (true) {goto label_26;}}
//line 151
___nl__15 = (___nl__14 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__16).getDoubleValue()].clone();
//line 152
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_read_reg_priv(___ref______nl__3,___nl__15,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 153
___nl__16 = new ImmDouble((Double.Parse(___nl__16.getValue().ToString()))+(Double.Parse(___nl__17.getValue().ToString()))).clone();
//line 153
if (true) {goto label_28;}
//line 153
label_26:
//line 153
___nl__14 = null;
//line 153
___nl__15 = null;
//line 153
___nl__16 = null;
//line 153
___nl__17 = null;
//line 153
___nl__18 = null;
//line 153
___nl__19 = null;
//line 154
___nl__14 = ((ImmHash)___nl__13).getHashValue()["dest"].clone();
//line 154
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_write_reg_priv(___ref______nl__3,___nl__14,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 154
___nl__14 = null;
//line 154
___nl__13 = null;
//line 155
if (true) {goto label_4;}
//line 155
label_6:
//line 155
___nl__13 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("hash_decl")).clone();
//line 156
___nl__14 = ((ImmHash)___nl__13).getHashValue()["src"].clone();
//line 156
___nl__16 = new ImmDouble(0).clone();
//line 156
___nl__17 = new ImmDouble(1).clone();
//line 156
___nl__18 = c_rt_lib_NL.NL_array_len(___nl__14).clone();

//line 156
label_31:
//line 156
___nl__19 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__16.getValue().ToString()))>=(Double.Parse(___nl__18.getValue().ToString())) ).clone();
//line 156
if (c_rt_lib_NL.NL_check_true_native(___nl__19)) {if (true) {goto label_29;}}
//line 156
___nl__15 = (___nl__14 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__16).getDoubleValue()].clone();
//line 157
___nl__20 = ((ImmHash)___nl__15).getHashValue()["val"].clone();
//line 157
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_read_reg_priv(___ref______nl__3,___nl__20,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 157
___nl__20 = null;
//line 158
___nl__16 = new ImmDouble((Double.Parse(___nl__16.getValue().ToString()))+(Double.Parse(___nl__17.getValue().ToString()))).clone();
//line 158
if (true) {goto label_31;}
//line 158
label_29:
//line 158
___nl__14 = null;
//line 158
___nl__15 = null;
//line 158
___nl__16 = null;
//line 158
___nl__17 = null;
//line 158
___nl__18 = null;
//line 158
___nl__19 = null;
//line 159
___nl__14 = ((ImmHash)___nl__13).getHashValue()["dest"].clone();
//line 159
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_write_reg_priv(___ref______nl__3,___nl__14,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 159
___nl__14 = null;
//line 159
___nl__13 = null;
//line 160
if (true) {goto label_4;}
//line 160
label_7:
//line 160
___nl__13 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("call")).clone();
//line 161
___nl__14 = ((ImmHash)___nl__13).getHashValue()["args"].clone();
//line 161
___nl__16 = new ImmDouble(0).clone();
//line 161
___nl__17 = new ImmDouble(1).clone();
//line 161
___nl__18 = c_rt_lib_NL.NL_array_len(___nl__14).clone();

//line 161
label_34:
//line 161
___nl__19 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__16.getValue().ToString()))>=(Double.Parse(___nl__18.getValue().ToString())) ).clone();
//line 161
if (c_rt_lib_NL.NL_check_true_native(___nl__19)) {if (true) {goto label_32;}}
//line 161
___nl__15 = (___nl__14 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__16).getDoubleValue()].clone();
//line 162
___nl__20 = c_rt_lib_NL.NL_ov_is(___nl__15, new ImmString("val")).clone();
//line 162
if (c_rt_lib_NL.NL_check_true_native(___nl__20)) {if (true) {goto label_36;}}
//line 164
___nl__20 = c_rt_lib_NL.NL_ov_is(___nl__15, new ImmString("ref")).clone();
//line 164
if (c_rt_lib_NL.NL_check_true_native(___nl__20)) {if (true) {goto label_37;}}
//line 164
___nl__20 = new ImmString("NOMATCHALERT").clone();
//line 164
___nl__20 = new ImmArray(new Imm[] {___nl__20,___nl__15,}).clone();
//line 164
c_rt_lib_NL.NL_die();
//line 162
label_36:
//line 162
___nl__21 = c_rt_lib_NL.NL_ov_as(___nl__15, new ImmString("val")).clone();
//line 163
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_read_reg_priv(___ref______nl__3,___nl__21,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 163
___nl__21 = null;
//line 164
if (true) {goto label_35;}
//line 164
label_37:
//line 164
___nl__21 = c_rt_lib_NL.NL_ov_as(___nl__15, new ImmString("ref")).clone();
//line 165
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_read_reg_priv(___ref______nl__3,___nl__21,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 165
___nl__21 = null;
//line 166
if (true) {goto label_35;}
//line 166
label_35:
//line 166
___nl__20 = null;
//line 167
___nl__16 = new ImmDouble((Double.Parse(___nl__16.getValue().ToString()))+(Double.Parse(___nl__17.getValue().ToString()))).clone();
//line 167
if (true) {goto label_34;}
//line 167
label_32:
//line 167
___nl__14 = null;
//line 167
___nl__15 = null;
//line 167
___nl__16 = null;
//line 167
___nl__17 = null;
//line 167
___nl__18 = null;
//line 167
___nl__19 = null;
//line 168
___nl__14 = ((ImmHash)___nl__13).getHashValue()["args"].clone();
//line 168
___nl__16 = new ImmDouble(0).clone();
//line 168
___nl__17 = new ImmDouble(1).clone();
//line 168
___nl__18 = c_rt_lib_NL.NL_array_len(___nl__14).clone();

//line 168
label_40:
//line 168
___nl__19 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__16.getValue().ToString()))>=(Double.Parse(___nl__18.getValue().ToString())) ).clone();
//line 168
if (c_rt_lib_NL.NL_check_true_native(___nl__19)) {if (true) {goto label_38;}}
//line 168
___nl__15 = (___nl__14 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__16).getDoubleValue()].clone();
//line 169
___nl__20 = c_rt_lib_NL.NL_ov_is(___nl__15, new ImmString("val")).clone();
//line 169
if (c_rt_lib_NL.NL_check_true_native(___nl__20)) {if (true) {goto label_42;}}
//line 170
___nl__20 = c_rt_lib_NL.NL_ov_is(___nl__15, new ImmString("ref")).clone();
//line 170
if (c_rt_lib_NL.NL_check_true_native(___nl__20)) {if (true) {goto label_43;}}
//line 170
___nl__20 = new ImmString("NOMATCHALERT").clone();
//line 170
___nl__20 = new ImmArray(new Imm[] {___nl__20,___nl__15,}).clone();
//line 170
c_rt_lib_NL.NL_die();
//line 169
label_42:
//line 169
___nl__21 = c_rt_lib_NL.NL_ov_as(___nl__15, new ImmString("val")).clone();
//line 169
___nl__21 = null;
//line 170
if (true) {goto label_41;}
//line 170
label_43:
//line 170
___nl__21 = c_rt_lib_NL.NL_ov_as(___nl__15, new ImmString("ref")).clone();
//line 171
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_write_reg_priv(___ref______nl__3,___nl__21,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 171
___nl__21 = null;
//line 172
if (true) {goto label_41;}
//line 172
label_41:
//line 172
___nl__20 = null;
//line 173
___nl__16 = new ImmDouble((Double.Parse(___nl__16.getValue().ToString()))+(Double.Parse(___nl__17.getValue().ToString()))).clone();
//line 173
if (true) {goto label_40;}
//line 173
label_38:
//line 173
___nl__14 = null;
//line 173
___nl__15 = null;
//line 173
___nl__16 = null;
//line 173
___nl__17 = null;
//line 173
___nl__18 = null;
//line 173
___nl__19 = null;
//line 174
___nl__14 = ((ImmHash)___nl__13).getHashValue()["dest"].clone();
//line 174
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_write_reg_priv(___ref______nl__3,___nl__14,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 174
___nl__14 = null;
//line 174
___nl__13 = null;
//line 175
if (true) {goto label_4;}
//line 175
label_8:
//line 175
___nl__13 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("una_op")).clone();
//line 176
___nl__14 = ((ImmHash)___nl__13).getHashValue()["src"].clone();
//line 176
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_read_reg_priv(___ref______nl__3,___nl__14,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 176
___nl__14 = null;
//line 177
___nl__14 = ((ImmHash)___nl__13).getHashValue()["dest"].clone();
//line 177
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_write_reg_priv(___ref______nl__3,___nl__14,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 177
___nl__14 = null;
//line 177
___nl__13 = null;
//line 178
if (true) {goto label_4;}
//line 178
label_9:
//line 178
___nl__13 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("bin_op")).clone();
//line 179
___nl__14 = ((ImmHash)___nl__13).getHashValue()["left"].clone();
//line 179
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_read_reg_priv(___ref______nl__3,___nl__14,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 179
___nl__14 = null;
//line 180
___nl__14 = ((ImmHash)___nl__13).getHashValue()["right"].clone();
//line 180
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_read_reg_priv(___ref______nl__3,___nl__14,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 180
___nl__14 = null;
//line 181
___nl__14 = ((ImmHash)___nl__13).getHashValue()["dest"].clone();
//line 181
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_write_reg_priv(___ref______nl__3,___nl__14,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 181
___nl__14 = null;
//line 181
___nl__13 = null;
//line 182
if (true) {goto label_4;}
//line 182
label_10:
//line 182
___nl__13 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("ov_is")).clone();
//line 183
___nl__14 = ((ImmHash)___nl__13).getHashValue()["src"].clone();
//line 183
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_read_reg_priv(___ref______nl__3,___nl__14,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 183
___nl__14 = null;
//line 184
___nl__14 = ((ImmHash)___nl__13).getHashValue()["dest"].clone();
//line 184
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_write_reg_priv(___ref______nl__3,___nl__14,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 184
___nl__14 = null;
//line 184
___nl__13 = null;
//line 185
if (true) {goto label_4;}
//line 185
label_11:
//line 185
___nl__13 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("ov_as")).clone();
//line 186
___nl__14 = ((ImmHash)___nl__13).getHashValue()["src"].clone();
//line 186
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_read_reg_priv(___ref______nl__3,___nl__14,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 186
___nl__14 = null;
//line 187
___nl__14 = ((ImmHash)___nl__13).getHashValue()["dest"].clone();
//line 187
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_write_reg_priv(___ref______nl__3,___nl__14,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 187
___nl__14 = null;
//line 187
___nl__13 = null;
//line 188
if (true) {goto label_4;}
//line 188
label_12:
//line 188
___nl__13 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("func")).clone();
//line 189
___nl__14 = ((ImmHash)___nl__13).getHashValue()["dest"].clone();
//line 189
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_write_reg_priv(___ref______nl__3,___nl__14,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 189
___nl__14 = null;
//line 189
___nl__13 = null;
//line 190
if (true) {goto label_4;}
//line 190
label_13:
//line 190
___nl__13 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("move")).clone();
//line 191
___nl__14 = ((ImmHash)___nl__13).getHashValue()["src"].clone();
//line 191
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_read_reg_priv(___ref______nl__3,___nl__14,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 191
___nl__14 = null;
//line 192
___nl__14 = ((ImmHash)___nl__13).getHashValue()["dest"].clone();
//line 192
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_write_reg_priv(___ref______nl__3,___nl__14,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 192
___nl__14 = null;
//line 192
___nl__13 = null;
//line 193
if (true) {goto label_4;}
//line 193
label_14:
//line 193
___nl__13 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("load_const")).clone();
//line 194
___nl__14 = ((ImmHash)___nl__13).getHashValue()["dest"].clone();
//line 194
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_write_reg_priv(___ref______nl__3,___nl__14,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 194
___nl__14 = null;
//line 194
___nl__13 = null;
//line 195
if (true) {goto label_4;}
//line 195
label_15:
//line 195
___nl__13 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("get_frm_idx")).clone();
//line 196
___nl__14 = ((ImmHash)___nl__13).getHashValue()["src"].clone();
//line 196
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_read_reg_priv(___ref______nl__3,___nl__14,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 196
___nl__14 = null;
//line 197
___nl__14 = ((ImmHash)___nl__13).getHashValue()["idx"].clone();
//line 197
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_read_reg_priv(___ref______nl__3,___nl__14,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 197
___nl__14 = null;
//line 198
___nl__14 = ((ImmHash)___nl__13).getHashValue()["dest"].clone();
//line 198
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_write_reg_priv(___ref______nl__3,___nl__14,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 198
___nl__14 = null;
//line 198
___nl__13 = null;
//line 199
if (true) {goto label_4;}
//line 199
label_16:
//line 199
___nl__13 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("set_at_idx")).clone();
//line 200
___nl__14 = ((ImmHash)___nl__13).getHashValue()["src"].clone();
//line 200
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_read_reg_priv(___ref______nl__3,___nl__14,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 200
___nl__14 = null;
//line 201
___nl__14 = ((ImmHash)___nl__13).getHashValue()["idx"].clone();
//line 201
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_read_reg_priv(___ref______nl__3,___nl__14,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 201
___nl__14 = null;
//line 202
___nl__14 = ((ImmHash)___nl__13).getHashValue()["val"].clone();
//line 202
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_read_reg_priv(___ref______nl__3,___nl__14,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 202
___nl__14 = null;
//line 203
___nl__14 = ((ImmHash)___nl__13).getHashValue()["src"].clone();
//line 203
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_write_reg_priv(___ref______nl__3,___nl__14,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 203
___nl__14 = null;
//line 203
___nl__13 = null;
//line 204
if (true) {goto label_4;}
//line 204
label_17:
//line 204
___nl__13 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("get_val")).clone();
//line 205
___nl__14 = ((ImmHash)___nl__13).getHashValue()["src"].clone();
//line 205
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_read_reg_priv(___ref______nl__3,___nl__14,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 205
___nl__14 = null;
//line 206
___nl__14 = ((ImmHash)___nl__13).getHashValue()["dest"].clone();
//line 206
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_write_reg_priv(___ref______nl__3,___nl__14,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 206
___nl__14 = null;
//line 206
___nl__13 = null;
//line 207
if (true) {goto label_4;}
//line 207
label_18:
//line 207
___nl__13 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("set_val")).clone();
//line 208
___nl__14 = ((ImmHash)___nl__13).getHashValue()["src"].clone();
//line 208
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_read_reg_priv(___ref______nl__3,___nl__14,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 208
___nl__14 = null;
//line 209
___nl__14 = ((ImmHash)___nl__13).getHashValue()["val"].clone();
//line 209
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_read_reg_priv(___ref______nl__3,___nl__14,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 209
___nl__14 = null;
//line 210
___nl__14 = ((ImmHash)___nl__13).getHashValue()["src"].clone();
//line 210
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_write_reg_priv(___ref______nl__3,___nl__14,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 210
___nl__14 = null;
//line 210
___nl__13 = null;
//line 211
if (true) {goto label_4;}
//line 211
label_19:
//line 211
___nl__13 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("ov_mk")).clone();
//line 212
___nl__14 = ((ImmHash)___nl__13).getHashValue()["src"].clone();
//line 212
___nl__14 = c_rt_lib_NL.NL_ov_is(___nl__14, new ImmString("arg")).clone();
//line 212
___nl__14 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__14)).clone();
//line 212
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_45;}}
//line 212
___nl__15 = ((ImmHash)___nl__13).getHashValue()["src"].clone();
//line 212
___nl__15 = c_rt_lib_NL.NL_ov_as(___nl__15, new ImmString("arg")).clone();
//line 212
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_read_reg_priv(___ref______nl__3,___nl__15,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 212
___nl__15 = null;
//line 212
if (true) {goto label_45;}
//line 212
label_45:
//line 212
___nl__14 = null;
//line 213
___nl__14 = ((ImmHash)___nl__13).getHashValue()["dest"].clone();
//line 213
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_write_reg_priv(___ref______nl__3,___nl__14,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 213
___nl__14 = null;
//line 213
___nl__13 = null;
//line 214
if (true) {goto label_4;}
//line 214
label_20:
//line 214
___nl__13 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("return")).clone();
//line 215
___nl__14 = ___nl__13.clone();
//line 215
___nl__14 = c_rt_lib_NL.NL_ov_is(___nl__14, new ImmString("val")).clone();
//line 215
___nl__14 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__14)).clone();
//line 215
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_47;}}
//line 215
___nl__15 = ___nl__13.clone();
//line 215
___nl__15 = c_rt_lib_NL.NL_ov_as(___nl__15, new ImmString("val")).clone();
//line 215
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_read_reg_priv(___ref______nl__3,___nl__15,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 215
___nl__15 = null;
//line 215
if (true) {goto label_47;}
//line 215
label_47:
//line 215
___nl__14 = null;
//line 216
___nl__14 = array_NL.NL_len(___nl__1).clone();

//line 216
___nl__15 = new ImmDouble(0).clone();
//line 216
___nl__16 = new ImmDouble(1).clone();
//line 216
label_50:
//line 216
___nl__17 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__15.getValue().ToString()))>=(Double.Parse(___nl__14.getValue().ToString())) ).clone();
//line 216
if (c_rt_lib_NL.NL_check_true_native(___nl__17)) {if (true) {goto label_48;}}
//line 217
___nl__18 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__15).getDoubleValue()].clone();
//line 217
___nl__18 = c_rt_lib_NL.NL_ov_is(___nl__18, new ImmString("ref")).clone();
//line 217
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 217
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_52;}}
//line 218
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_read_reg_priv(___ref______nl__3,___nl__15,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 219
if (true) {goto label_52;}
//line 219
label_52:
//line 219
___nl__18 = null;
//line 220
___nl__15 = new ImmDouble((Double.Parse(___nl__15.getValue().ToString()))+(Double.Parse(___nl__16.getValue().ToString()))).clone();
//line 220
if (true) {goto label_50;}
//line 220
label_48:
//line 220
___nl__14 = null;
//line 220
___nl__15 = null;
//line 220
___nl__16 = null;
//line 220
___nl__17 = null;
//line 221
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_add_block_priv(___ref______nl__2,___ref______nl__3,___nl__5,___nl__4);
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 222
___nl__14 = new ImmString("_R").clone();
//line 222
___nl__4 = new ImmString(___nl__4.toString() + ___nl__14.toString()).clone();
//line 222
___nl__14 = null;
//line 222
___nl__13 = null;
//line 223
if (true) {goto label_4;}
//line 223
label_21:
//line 223
___nl__13 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("die")).clone();
//line 224
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_read_reg_priv(___ref______nl__3,___nl__13,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 225
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_add_block_priv(___ref______nl__2,___ref______nl__3,___nl__5,___nl__4);
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 226
___nl__14 = new ImmString("_D").clone();
//line 226
___nl__4 = new ImmString(___nl__4.toString() + ___nl__14.toString()).clone();
//line 226
___nl__14 = null;
//line 226
___nl__13 = null;
//line 227
if (true) {goto label_4;}
//line 227
label_22:
//line 227
___nl__13 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("prt_lbl")).clone();
//line 228
___nl__14 = c_rt_lib_NL.NL_native_to_nl(!___nl__13.toString().Equals(___nl__4.toString())).clone();
//line 228
___nl__14 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__14)).clone();
//line 228
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_54;}}
//line 229
___nl__15 = new ImmString("next").clone();
//line 229
___nl__15 = c_rt_lib_NL.NL_get_ref_hash(___nl__3,___nl__15).clone();

//line 229
___ref______nl__15 = new ImmRef(___nl__15);
array_NL.NL_push(___ref______nl__15,___nl__13);
___nl__15 = ___ref______nl__15.getValue().clone();

//line 229
___nl__16 = new ImmString("next").clone();
//line 229
___ref______nl__3 = new ImmRef(___nl__3);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__3,___nl__16,___nl__15);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 229
___nl__16 = null;
//line 229
___nl__15 = null;
//line 230
___nl__15 = new ImmString("cmds").clone();
//line 230
___nl__15 = c_rt_lib_NL.NL_get_ref_hash(___nl__3,___nl__15).clone();

//line 230
___ref______nl__15 = new ImmRef(___nl__15);
array_NL.NL_pop(___ref______nl__15);
___nl__15 = ___ref______nl__15.getValue().clone();

//line 230
___nl__16 = new ImmString("cmds").clone();
//line 230
___ref______nl__3 = new ImmRef(___nl__3);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__3,___nl__16,___nl__15);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 230
___nl__16 = null;
//line 230
___nl__15 = null;
//line 231
___nl__15 = new ImmDouble(1).clone();
//line 231
___nl__15 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))-(Double.Parse(___nl__15.getValue().ToString()))).clone();
//line 231
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_add_block_priv(___ref______nl__2,___ref______nl__3,___nl__15,___nl__4);
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 231
___nl__15 = null;
//line 232
___nl__15 = new ImmString("cmds").clone();
//line 232
___nl__15 = c_rt_lib_NL.NL_get_ref_hash(___nl__3,___nl__15).clone();

//line 232
___ref______nl__15 = new ImmRef(___nl__15);
array_NL.NL_push(___ref______nl__15,___nl__6);
___nl__15 = ___ref______nl__15.getValue().clone();

//line 232
___nl__16 = new ImmString("cmds").clone();
//line 232
___ref______nl__3 = new ImmRef(___nl__3);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__3,___nl__16,___nl__15);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 232
___nl__16 = null;
//line 232
___nl__15 = null;
//line 233
___nl__4 = ___nl__13.clone();
//line 234
if (true) {goto label_54;}
//line 234
label_54:
//line 234
___nl__14 = null;
//line 234
___nl__13 = null;
//line 235
if (true) {goto label_4;}
//line 235
label_23:
//line 235
___nl__13 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("if_goto")).clone();
//line 236
___nl__14 = ((ImmHash)___nl__13).getHashValue()["src"].clone();
//line 236
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_read_reg_priv(___ref______nl__3,___nl__14,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 236
___nl__14 = null;
//line 237
___nl__14 = new ImmString("next").clone();
//line 237
___nl__14 = c_rt_lib_NL.NL_get_ref_hash(___nl__3,___nl__14).clone();

//line 237
___nl__15 = ((ImmHash)___nl__13).getHashValue()["dest"].clone();
//line 237
___ref______nl__14 = new ImmRef(___nl__14);
array_NL.NL_push(___ref______nl__14,___nl__15);
___nl__14 = ___ref______nl__14.getValue().clone();

//line 237
___nl__15 = null;
//line 237
___nl__15 = new ImmString("next").clone();
//line 237
___ref______nl__3 = new ImmRef(___nl__3);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__3,___nl__15,___nl__14);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 237
___nl__15 = null;
//line 237
___nl__14 = null;
//line 238
___nl__14 = new ImmString("_I").clone();
//line 238
___nl__14 = new ImmString(___nl__4.toString() + ___nl__14.toString()).clone();
//line 239
___nl__16 = new ImmDouble(1).clone();
//line 239
___nl__16 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__16.getValue().ToString()))).clone();
//line 239
___nl__15 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__16).getDoubleValue()].clone();
//line 239
___nl__16 = null;
//line 239
___nl__15 = ((ImmHash)___nl__15).getHashValue()["cmd"].clone();
//line 239
___nl__15 = c_rt_lib_NL.NL_ov_is(___nl__15, new ImmString("prt_lbl")).clone();
//line 239
___nl__15 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__15)).clone();
//line 239
if (c_rt_lib_NL.NL_check_true_native(___nl__15)) {if (true) {goto label_56;}}
//line 240
___nl__17 = new ImmDouble(1).clone();
//line 240
___nl__17 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__17.getValue().ToString()))).clone();
//line 240
___nl__16 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__17).getDoubleValue()].clone();
//line 240
___nl__17 = null;
//line 240
___nl__16 = ((ImmHash)___nl__16).getHashValue()["cmd"].clone();
//line 240
___nl__16 = c_rt_lib_NL.NL_ov_as(___nl__16, new ImmString("prt_lbl")).clone();
//line 240
___nl__14 = ___nl__16.clone();
//line 240
___nl__16 = null;
//line 241
if (true) {goto label_56;}
//line 241
label_56:
//line 241
___nl__15 = null;
//line 242
___nl__15 = new ImmString("next").clone();
//line 242
___nl__15 = c_rt_lib_NL.NL_get_ref_hash(___nl__3,___nl__15).clone();

//line 242
___ref______nl__15 = new ImmRef(___nl__15);
array_NL.NL_push(___ref______nl__15,___nl__14);
___nl__15 = ___ref______nl__15.getValue().clone();

//line 242
___nl__16 = new ImmString("next").clone();
//line 242
___ref______nl__3 = new ImmRef(___nl__3);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__3,___nl__16,___nl__15);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 242
___nl__16 = null;
//line 242
___nl__15 = null;
//line 243
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_add_block_priv(___ref______nl__2,___ref______nl__3,___nl__5,___nl__4);
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 244
___nl__4 = ___nl__14.clone();
//line 244
___nl__14 = null;
//line 244
___nl__13 = null;
//line 245
if (true) {goto label_4;}
//line 245
label_24:
//line 245
___nl__13 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("goto")).clone();
//line 246
___nl__14 = new ImmString("next").clone();
//line 246
___nl__14 = c_rt_lib_NL.NL_get_ref_hash(___nl__3,___nl__14).clone();

//line 246
___ref______nl__14 = new ImmRef(___nl__14);
array_NL.NL_push(___ref______nl__14,___nl__13);
___nl__14 = ___ref______nl__14.getValue().clone();

//line 246
___nl__15 = new ImmString("next").clone();
//line 246
___ref______nl__3 = new ImmRef(___nl__3);
c_rt_lib_NL.NL_set_ref_hash(___ref______nl__3,___nl__15,___nl__14);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 246
___nl__15 = null;
//line 246
___nl__14 = null;
//line 247
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_add_block_priv(___ref______nl__2,___ref______nl__3,___nl__5,___nl__4);
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 248
___nl__14 = new ImmString("_G").clone();
//line 248
___nl__4 = new ImmString(___nl__4.toString() + ___nl__14.toString()).clone();
//line 248
___nl__14 = null;
//line 248
___nl__13 = null;
//line 249
if (true) {goto label_4;}
//line 249
label_25:
//line 249
___nl__13 = c_rt_lib_NL.NL_ov_as(___nl__11, new ImmString("clear")).clone();
//line 250
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_clear_reg_priv(___ref______nl__3,___nl__13,___nl__5);
___nl__3 = ___ref______nl__3.getValue().clone();

//line 250
___nl__13 = null;
//line 251
if (true) {goto label_4;}
//line 251
label_4:
//line 251
___nl__11 = null;
//line 251
___nl__12 = null;
//line 252
___nl__11 = new ImmDouble(1).clone();
//line 252
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__11.getValue().ToString()))).clone();
//line 252
___nl__11 = null;
//line 253
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString()))).clone();
//line 253
if (true) {goto label_3;}
//line 253
label_1:
//line 253
___nl__6 = null;
//line 253
___nl__7 = null;
//line 253
___nl__8 = null;
//line 253
___nl__9 = null;
//line 253
___nl__10 = null;
//line 254
___nl__6 = new ImmDouble(1).clone();
//line 254
___nl__6 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))-(Double.Parse(___nl__6.getValue().ToString()))).clone();
//line 254
___ref______nl__2 = new ImmRef(___nl__2);
___ref______nl__3 = new ImmRef(___nl__3);
flow_graph_NL.NL_add_block_priv(___ref______nl__2,___ref______nl__3,___nl__6,___nl__4);
___nl__2 = ___ref______nl__2.getValue().clone();
___nl__3 = ___ref______nl__3.getValue().clone();

//line 254
___nl__6 = null;
//line 255
___nl__0 = null;
//line 255
___nl__1 = null;
//line 255
___nl__3 = null;
//line 255
___nl__4 = null;
//line 255
___nl__5 = null;
//line 255
if(true) return ___nl__2;
//line 255
___nl__2 = null;
//line 255
___nl__3 = null;
//line 255
___nl__4 = null;
//line 255
___nl__5 = null;
//line 255
___nl__0 = null;
//line 255
___nl__1 = null;
//line 255
if(true) return null;
}

}
}