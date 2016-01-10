using System;
using System.Collections.Generic;
using nianio;
namespace nianio { 
public class unnecessary_commands_NL {

public static Imm NL_SINGLETON_state_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Dictionary<String, Imm> __function_map;
//line 12
__function_map = new Dictionary<String, Imm>();
__function_map.Add("module",new ImmString("unnecessary_commands_NL"));
__function_map.Add("name",new ImmString("block_state_t"));
___nl__1 = new ImmHash(__function_map).clone();
//line 12
___nl__1 = c_rt_lib_NL.NL_ov_mk_arg(new ImmString("ref"), ___nl__1).clone();
//line 12
___nl__0 = ptd_NL.NL_arr(___nl__1).clone();

//line 12
___nl__1 = null;
//line 12
if(true) return ___nl__0;
//line 12
___nl__0 = null;
//line 12
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_state_t = null;
public static Imm NL_state_t() {
	if (value__singleton__NL_SINGLETON_state_t == null) {
		value__singleton__NL_SINGLETON_state_t = NL_SINGLETON_state_t();
	}
	return value__singleton__NL_SINGLETON_state_t;
}
public static Imm NL_SINGLETON_block_state_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 15
___nl__2 = ptd_NL.NL_sim().clone();

//line 15
___nl__1 = ptd_NL.NL_hash(___nl__2).clone();

//line 15
___nl__2 = null;
//line 15
___nl__0 = ptd_NL.NL_arr(___nl__1).clone();

//line 15
___nl__1 = null;
//line 15
if(true) return ___nl__0;
//line 15
___nl__0 = null;
//line 15
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_block_state_t = null;
public static Imm NL_block_state_t() {
	if (value__singleton__NL_SINGLETON_block_state_t == null) {
		value__singleton__NL_SINGLETON_block_state_t = NL_SINGLETON_block_state_t();
	}
	return value__singleton__NL_SINGLETON_block_state_t;
}
public static Imm NL_SINGLETON_graph_t() {

Imm ___nl__0 = null;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 18
___nl__2 = ptd_NL.NL_sim().clone();

//line 18
___nl__1 = ptd_NL.NL_arr(___nl__2).clone();

//line 18
___nl__2 = null;
//line 18
___nl__0 = ptd_NL.NL_arr(___nl__1).clone();

//line 18
___nl__1 = null;
//line 18
if(true) return ___nl__0;
//line 18
___nl__0 = null;
//line 18
if(true) return null;
}
private static Imm value__singleton__NL_SINGLETON_graph_t = null;
public static Imm NL_graph_t() {
	if (value__singleton__NL_SINGLETON_graph_t == null) {
		value__singleton__NL_SINGLETON_graph_t = NL_SINGLETON_graph_t();
	}
	return value__singleton__NL_SINGLETON_graph_t;
}
public static Imm NL_delete_unnecessary_commands(ref Imm ___arg__0) {
Imm ___nl__0 = ___arg__0;
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Dictionary<String, Imm> __function_map;
//line 21
___nl__2 = ((ImmHash)___nl__0).getHashValue()["commands"].clone();
//line 21
___nl__3 = ((ImmHash)___nl__0).getHashValue()["args_type"].clone();
//line 21
___nl__1 = flow_graph_NL.NL_make_blocks(___nl__2,___nl__3).clone();

//line 21
___nl__3 = null;
//line 21
___nl__2 = null;
//line 22
___nl__2 = ((ImmHash)___nl__0).getHashValue()["reg_size"].clone();
//line 22
unnecessary_commands_NL.NL_delete_unnecessary_commands_in_blocks_priv(ref ___nl__1,___nl__2);

//line 22
___nl__2 = null;
//line 23
___nl__2 = flow_graph_NL.NL_combine_blocks(___nl__1).clone();

//line 23
___nl__3 = ___nl__2.clone();
//line 23
((ImmHash)___nl__0).set("commands", ___nl__3);
//line 23
___nl__2 = null;
//line 23
___nl__3 = null;
//line 25
___nl__3 = ((ImmHash)___nl__0).getHashValue()["commands"].clone();
//line 25
___nl__4 = ((ImmHash)___nl__0).getHashValue()["args_type"].clone();
//line 25
___nl__2 = flow_graph_NL.NL_make_blocks(___nl__3,___nl__4).clone();

//line 25
___nl__4 = null;
//line 25
___nl__3 = null;
//line 25
___nl__1 = ___nl__2.clone();
//line 25
___nl__2 = null;
//line 26
___nl__2 = ((ImmHash)___nl__0).getHashValue()["reg_size"].clone();
//line 26
___nl__4 = ((ImmHash)___nl__0).getHashValue()["args_type"].clone();
//line 26
___nl__3 = array_NL.NL_len(___nl__4).clone();

//line 26
___nl__4 = null;
//line 26
unnecessary_commands_NL.NL_delete_unnecessary_clears_in_blocks_priv(ref ___nl__1,___nl__2,___nl__3);

//line 26
___nl__3 = null;
//line 26
___nl__2 = null;
//line 27
___nl__2 = flow_graph_NL.NL_combine_blocks(___nl__1).clone();

//line 27
___nl__3 = ___nl__2.clone();
//line 27
((ImmHash)___nl__0).set("commands", ___nl__3);
//line 27
___nl__2 = null;
//line 27
___nl__3 = null;
//line 27
___nl__1 = null;
//line 27
___arg__0 = ___nl__0;if(true) return null;
}

private static Imm NL_build_empty_state_priv(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Dictionary<String, Imm> __function_map;
//line 31
___nl__1 = new ImmArray(new Imm[0]).clone();
//line 32
___nl__2 = new ImmDouble(0).clone();
//line 32
___nl__3 = new ImmDouble(1).clone();
//line 32
label_3:
//line 32
___nl__4 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__2.getValue().ToString()))>=(Double.Parse(___nl__0.getValue().ToString())) ).clone();
//line 32
if (c_rt_lib_NL.NL_check_true_native(___nl__4)) {if (true) {goto label_1;}}
//line 32
__function_map = new Dictionary<String, Imm>();
___nl__5 = new ImmHash(__function_map).clone();
//line 32
array_NL.NL_push(ref ___nl__1,___nl__5);

//line 32
___nl__5 = null;
//line 32
___nl__2 = new ImmDouble((Double.Parse(___nl__2.getValue().ToString()))+(Double.Parse(___nl__3.getValue().ToString()))).clone();
//line 32
if (true) {goto label_3;}
//line 32
label_1:
//line 32
___nl__2 = null;
//line 32
___nl__3 = null;
//line 32
___nl__4 = null;
//line 33
___nl__0 = null;
//line 33
if(true) return ___nl__1;
//line 33
___nl__1 = null;
//line 33
___nl__0 = null;
//line 33
if(true) return null;
}

private static Imm NL_has_side_effects_priv(Imm ___arg__0) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);
Imm ___nl__1 = null;
Imm ___nl__2 = null;
Dictionary<String, Imm> __function_map;
//line 36
___nl__1 = ((ImmHash)___nl__0).getHashValue()["cmd"].clone();
//line 37
___nl__2 = ___nl__1.clone();
//line 37
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("call")).clone();
//line 37
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_5;}}
//line 37
___nl__2 = ___nl__1.clone();
//line 37
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("return")).clone();
//line 37
label_5:
//line 37
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_4;}}
//line 37
___nl__2 = ___nl__1.clone();
//line 37
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("die")).clone();
//line 37
label_4:
//line 37
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_3;}}
//line 37
___nl__2 = ___nl__1.clone();
//line 37
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("prt_lbl")).clone();
//line 37
label_3:
//line 37
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_2;}}
//line 37
___nl__2 = ___nl__1.clone();
//line 37
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("if_goto")).clone();
//line 37
label_2:
//line 37
if (c_rt_lib_NL.NL_check_true_native(___nl__2)) {if (true) {goto label_1;}}
//line 37
___nl__2 = ___nl__1.clone();
//line 37
___nl__2 = c_rt_lib_NL.NL_ov_is(___nl__2, new ImmString("goto")).clone();
//line 37
label_1:
//line 37
___nl__0 = null;
//line 37
___nl__1 = null;
//line 37
if(true) return ___nl__2;
//line 37
___nl__2 = null;
//line 37
___nl__1 = null;
//line 37
___nl__0 = null;
//line 37
if(true) return null;
}

private static Imm NL_build_blocks_states_priv(Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);
Imm ___nl__2 = null;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
Dictionary<String, Imm> __function_map;
//line 40
___nl__2 = new ImmArray(new Imm[0]).clone();
//line 41
___nl__3 = unnecessary_commands_NL.NL_build_empty_state_priv(___nl__1).clone();

//line 42
__function_map = new Dictionary<String, Imm>();
___nl__4 = new ImmHash(__function_map).clone();
//line 43
___nl__5 = array_NL.NL_len(___nl__0).clone();

//line 43
___nl__6 = new ImmDouble(0).clone();
//line 43
___nl__7 = new ImmDouble(1).clone();
//line 43
label_3:
//line 43
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__6.getValue().ToString()))>=(Double.Parse(___nl__5.getValue().ToString())) ).clone();
//line 43
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_1;}}
//line 44
array_NL.NL_push(ref ___nl__2,___nl__3);

//line 45
___nl__6 = new ImmDouble((Double.Parse(___nl__6.getValue().ToString()))+(Double.Parse(___nl__7.getValue().ToString()))).clone();
//line 45
if (true) {goto label_3;}
//line 45
label_1:
//line 45
___nl__5 = null;
//line 45
___nl__6 = null;
//line 45
___nl__7 = null;
//line 45
___nl__8 = null;
//line 46
___nl__5 = array_NL.NL_len(___nl__0).clone();

//line 46
___nl__6 = new ImmDouble(0).clone();
//line 46
___nl__5 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString())) ==((Double.Parse(___nl__6.getValue().ToString())))  ).clone();
//line 46
___nl__6 = null;
//line 46
___nl__5 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__5)).clone();
//line 46
if (c_rt_lib_NL.NL_check_true_native(___nl__5)) {if (true) {goto label_5;}}
//line 46
___nl__6 = new ImmArray(new Imm[0]).clone();
//line 46
c_rt_lib_NL.NL_die();
//line 46
if (true) {goto label_5;}
//line 46
label_5:
//line 46
___nl__5 = null;
//line 46
___nl__6 = null;
//line 47
___nl__5 = new ImmDouble(0).clone();
//line 47
unnecessary_commands_NL.NL_build_block_state_priv(ref ___nl__2,___nl__0,___nl__5,___nl__3,ref ___nl__4);

//line 47
___nl__5 = null;
//line 48
___nl__0 = null;
//line 48
___nl__1 = null;
//line 48
___nl__3 = null;
//line 48
___nl__4 = null;
//line 48
if(true) return ___nl__2;
//line 48
___nl__2 = null;
//line 48
___nl__3 = null;
//line 48
___nl__4 = null;
//line 48
___nl__0 = null;
//line 48
___nl__1 = null;
//line 48
if(true) return null;
}

private static Imm NL_delete_unnecessary_commands_in_blocks_priv(ref Imm ___arg__0, Imm ___arg__1) {
Imm ___nl__0 = ___arg__0;Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);
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
Dictionary<String, Imm> __function_map;
//line 51
___nl__2 = unnecessary_commands_NL.NL_build_blocks_states_priv(___nl__0,___nl__1).clone();

//line 52
___nl__3 = new ImmDouble(0).clone();
//line 53
___nl__5 = new ImmDouble(0).clone();
//line 53
___nl__6 = new ImmDouble(1).clone();
//line 53
___nl__7 = c_rt_lib_NL.NL_array_len(___nl__0).clone();

//line 53
label_3:
//line 53
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) ).clone();
//line 53
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_1;}}
//line 53
___nl__4 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()].clone();
//line 54
___nl__10 = ((ImmHash)___nl__4).getHashValue()["cmds"].clone();
//line 54
___nl__9 = array_NL.NL_len(___nl__10).clone();

//line 54
___nl__10 = null;
//line 54
___nl__3 = new ImmDouble((Double.Parse(___nl__3.getValue().ToString()))+(Double.Parse(___nl__9.getValue().ToString()))).clone();
//line 54
___nl__9 = null;
//line 55
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString()))).clone();
//line 55
if (true) {goto label_3;}
//line 55
label_1:
//line 55
___nl__4 = null;
//line 55
___nl__5 = null;
//line 55
___nl__6 = null;
//line 55
___nl__7 = null;
//line 55
___nl__8 = null;
//line 56
___nl__4 = unnecessary_commands_NL.NL_build_commands_graph_priv(___nl__2,___nl__0,___nl__3).clone();

//line 57
__function_map = new Dictionary<String, Imm>();
___nl__5 = new ImmHash(__function_map).clone();
//line 58
___nl__7 = new ImmDouble(0).clone();
//line 58
___nl__8 = new ImmDouble(1).clone();
//line 58
___nl__9 = c_rt_lib_NL.NL_array_len(___nl__0).clone();

//line 58
label_6:
//line 58
___nl__10 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))>=(Double.Parse(___nl__9.getValue().ToString())) ).clone();
//line 58
if (c_rt_lib_NL.NL_check_true_native(___nl__10)) {if (true) {goto label_4;}}
//line 58
___nl__6 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()].clone();
//line 59
___nl__12 = ((ImmHash)___nl__6).getHashValue()["cmds"].clone();
//line 59
___nl__11 = array_NL.NL_len(___nl__12).clone();

//line 59
___nl__12 = null;
//line 59
___nl__12 = new ImmDouble(0).clone();
//line 59
___nl__13 = new ImmDouble(1).clone();
//line 59
label_9:
//line 59
___nl__14 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__12.getValue().ToString()))>=(Double.Parse(___nl__11.getValue().ToString())) ).clone();
//line 59
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_7;}}
//line 60
___nl__16 = ((ImmHash)___nl__6).getHashValue()["cmds"].clone();
//line 60
___nl__16 = (___nl__16 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__12).getDoubleValue()].clone();
//line 60
___nl__15 = unnecessary_commands_NL.NL_has_side_effects_priv(___nl__16).clone();

//line 60
___nl__16 = null;
//line 60
___nl__15 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__15)).clone();
//line 60
if (c_rt_lib_NL.NL_check_true_native(___nl__15)) {if (true) {goto label_11;}}
//line 61
___nl__16 = ((ImmHash)___nl__6).getHashValue()["from"].clone();
//line 61
___nl__16 = new ImmDouble((Double.Parse(___nl__16.getValue().ToString()))+(Double.Parse(___nl__12.getValue().ToString()))).clone();
//line 61
unnecessary_commands_NL.NL_visit_node_priv(___nl__4,___nl__16,ref ___nl__5);

//line 61
___nl__16 = null;
//line 62
if (true) {goto label_11;}
//line 62
label_11:
//line 62
___nl__15 = null;
//line 63
___nl__12 = new ImmDouble((Double.Parse(___nl__12.getValue().ToString()))+(Double.Parse(___nl__13.getValue().ToString()))).clone();
//line 63
if (true) {goto label_9;}
//line 63
label_7:
//line 63
___nl__11 = null;
//line 63
___nl__12 = null;
//line 63
___nl__13 = null;
//line 63
___nl__14 = null;
//line 64
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString()))).clone();
//line 64
if (true) {goto label_6;}
//line 64
label_4:
//line 64
___nl__6 = null;
//line 64
___nl__7 = null;
//line 64
___nl__8 = null;
//line 64
___nl__9 = null;
//line 64
___nl__10 = null;
//line 65
___nl__6 = array_NL.NL_len(___nl__0).clone();

//line 65
___nl__7 = new ImmDouble(0).clone();
//line 65
___nl__8 = new ImmDouble(1).clone();
//line 65
label_14:
//line 65
___nl__9 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) ).clone();
//line 65
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_12;}}
//line 66
___nl__10 = new ImmArray(new Imm[0]).clone();
//line 67
___nl__12 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()].clone();
//line 67
___nl__12 = ((ImmHash)___nl__12).getHashValue()["cmds"].clone();
//line 67
___nl__11 = array_NL.NL_len(___nl__12).clone();

//line 67
___nl__12 = null;
//line 67
___nl__12 = new ImmDouble(0).clone();
//line 67
___nl__13 = new ImmDouble(1).clone();
//line 67
label_17:
//line 67
___nl__14 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__12.getValue().ToString()))>=(Double.Parse(___nl__11.getValue().ToString())) ).clone();
//line 67
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_15;}}
//line 68
___nl__15 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()].clone();
//line 68
___nl__15 = ((ImmHash)___nl__15).getHashValue()["cmds"].clone();
//line 68
___nl__15 = (___nl__15 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__12).getDoubleValue()].clone();
//line 69
___nl__16 = c_rt_lib_NL.NL_get_false().clone();
//line 70
___nl__17 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()].clone();
//line 70
___nl__17 = ((ImmHash)___nl__17).getHashValue()["from"].clone();
//line 70
___nl__17 = new ImmDouble((Double.Parse(___nl__17.getValue().ToString()))+(Double.Parse(___nl__12.getValue().ToString()))).clone();
//line 71
___nl__18 = ((ImmHash)___nl__15).getHashValue()["cmd"].clone();
//line 71
___nl__18 = c_rt_lib_NL.NL_ov_is(___nl__18, new ImmString("clear")).clone();
//line 71
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 71
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 71
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_19;}}
//line 72
___nl__19 = hash_NL.NL_has_key(___nl__5,___nl__17).clone();

//line 72
___nl__19 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__19)).clone();
//line 72
___nl__19 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__19)).clone();
//line 72
if (c_rt_lib_NL.NL_check_true_native(___nl__19)) {if (true) {goto label_21;}}
//line 73
___nl__20 = c_rt_lib_NL.NL_get_true().clone();
//line 73
___nl__16 = ___nl__20.clone();
//line 73
___nl__20 = null;
//line 74
if (true) {goto label_21;}
//line 74
label_21:
//line 74
___nl__19 = null;
//line 75
if (true) {goto label_19;}
//line 75
label_19:
//line 75
___nl__18 = null;
//line 76
___nl__18 = ___nl__16.clone();
//line 76
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 76
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 76
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_23;}}
//line 77
array_NL.NL_push(ref ___nl__10,___nl__15);

//line 78
if (true) {goto label_23;}
//line 78
label_23:
//line 78
___nl__18 = null;
//line 78
___nl__15 = null;
//line 78
___nl__16 = null;
//line 78
___nl__17 = null;
//line 79
___nl__12 = new ImmDouble((Double.Parse(___nl__12.getValue().ToString()))+(Double.Parse(___nl__13.getValue().ToString()))).clone();
//line 79
if (true) {goto label_17;}
//line 79
label_15:
//line 79
___nl__11 = null;
//line 79
___nl__12 = null;
//line 79
___nl__13 = null;
//line 79
___nl__14 = null;
//line 80
___nl__11 = c_rt_lib_NL.NL_get_ref_arr(___nl__0,___nl__7).clone();

//line 80
___nl__12 = ___nl__10.clone();
//line 80
((ImmHash)___nl__11).set("cmds", ___nl__12);
//line 80
c_rt_lib_NL.NL_set_ref_arr(ref ___nl__0,___nl__7,___nl__11);

//line 80
___nl__11 = null;
//line 80
___nl__12 = null;
//line 80
___nl__10 = null;
//line 81
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString()))).clone();
//line 81
if (true) {goto label_14;}
//line 81
label_12:
//line 81
___nl__6 = null;
//line 81
___nl__7 = null;
//line 81
___nl__8 = null;
//line 81
___nl__9 = null;
//line 81
___nl__2 = null;
//line 81
___nl__3 = null;
//line 81
___nl__4 = null;
//line 81
___nl__5 = null;
//line 81
___nl__1 = null;
//line 81
___arg__0 = ___nl__0;if(true) return null;
}

private static Imm NL_delete_unnecessary_clears_in_blocks_priv(ref Imm ___arg__0, Imm ___arg__1, Imm ___arg__2) {
Imm ___nl__0 = ___arg__0;Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);Imm ___nl__2 = null;c_rt_lib_NL.NL_copy(ref ___nl__2, ___arg__2);
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
Imm ___nl__22 = null;
Dictionary<String, Imm> __function_map;
//line 84
___nl__3 = unnecessary_commands_NL.NL_build_blocks_states_priv(___nl__0,___nl__1).clone();

//line 85
___nl__4 = new ImmDouble(0).clone();
//line 86
___nl__6 = new ImmDouble(0).clone();
//line 86
___nl__7 = new ImmDouble(1).clone();
//line 86
___nl__8 = c_rt_lib_NL.NL_array_len(___nl__0).clone();

//line 86
label_3:
//line 86
___nl__9 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__6.getValue().ToString()))>=(Double.Parse(___nl__8.getValue().ToString())) ).clone();
//line 86
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_1;}}
//line 86
___nl__5 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__6).getDoubleValue()].clone();
//line 87
___nl__11 = ((ImmHash)___nl__5).getHashValue()["cmds"].clone();
//line 87
___nl__10 = array_NL.NL_len(___nl__11).clone();

//line 87
___nl__11 = null;
//line 87
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__10.getValue().ToString()))).clone();
//line 87
___nl__10 = null;
//line 88
___nl__6 = new ImmDouble((Double.Parse(___nl__6.getValue().ToString()))+(Double.Parse(___nl__7.getValue().ToString()))).clone();
//line 88
if (true) {goto label_3;}
//line 88
label_1:
//line 88
___nl__5 = null;
//line 88
___nl__6 = null;
//line 88
___nl__7 = null;
//line 88
___nl__8 = null;
//line 88
___nl__9 = null;
//line 89
___nl__5 = unnecessary_commands_NL.NL_build_commands_graph_priv(___nl__3,___nl__0,___nl__4).clone();

//line 90
___nl__6 = array_NL.NL_len(___nl__0).clone();

//line 90
___nl__7 = new ImmDouble(0).clone();
//line 90
___nl__8 = new ImmDouble(1).clone();
//line 90
label_6:
//line 90
___nl__9 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) ).clone();
//line 90
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_4;}}
//line 91
___nl__10 = new ImmArray(new Imm[0]).clone();
//line 92
___nl__12 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()].clone();
//line 92
___nl__12 = ((ImmHash)___nl__12).getHashValue()["cmds"].clone();
//line 92
___nl__11 = array_NL.NL_len(___nl__12).clone();

//line 92
___nl__12 = null;
//line 92
___nl__12 = new ImmDouble(0).clone();
//line 92
___nl__13 = new ImmDouble(1).clone();
//line 92
label_9:
//line 92
___nl__14 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__12.getValue().ToString()))>=(Double.Parse(___nl__11.getValue().ToString())) ).clone();
//line 92
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_7;}}
//line 93
___nl__15 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()].clone();
//line 93
___nl__15 = ((ImmHash)___nl__15).getHashValue()["cmds"].clone();
//line 93
___nl__15 = (___nl__15 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__12).getDoubleValue()].clone();
//line 94
___nl__16 = c_rt_lib_NL.NL_get_false().clone();
//line 95
___nl__17 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()].clone();
//line 95
___nl__17 = ((ImmHash)___nl__17).getHashValue()["from"].clone();
//line 95
___nl__17 = new ImmDouble((Double.Parse(___nl__17.getValue().ToString()))+(Double.Parse(___nl__12.getValue().ToString()))).clone();
//line 96
___nl__18 = ((ImmHash)___nl__15).getHashValue()["cmd"].clone();
//line 96
___nl__18 = c_rt_lib_NL.NL_ov_is(___nl__18, new ImmString("clear")).clone();
//line 96
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 96
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_11;}}
//line 97
___nl__19 = ((ImmHash)___nl__15).getHashValue()["cmd"].clone();
//line 97
___nl__19 = c_rt_lib_NL.NL_ov_as(___nl__19, new ImmString("clear")).clone();
//line 98
___nl__22 = (___nl__5 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__17).getDoubleValue()].clone();
//line 98
___nl__20 = array_NL.NL_len(___nl__22).clone();

//line 98
___nl__22 = null;
//line 98
___nl__22 = new ImmDouble(0).clone();
//line 98
___nl__20 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__20.getValue().ToString())) ==((Double.Parse(___nl__22.getValue().ToString())))  ).clone();
//line 98
___nl__22 = null;
//line 98
___nl__21 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__20)).clone();
//line 98
if (c_rt_lib_NL.NL_check_true_native(___nl__21)) {if (true) {goto label_14;}}
//line 98
___nl__20 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__19.getValue().ToString()))>=(Double.Parse(___nl__2.getValue().ToString())) ).clone();
//line 98
label_14:
//line 98
___nl__21 = null;
//line 98
___nl__20 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__20)).clone();
//line 98
if (c_rt_lib_NL.NL_check_true_native(___nl__20)) {if (true) {goto label_13;}}
//line 99
___nl__21 = c_rt_lib_NL.NL_get_true().clone();
//line 99
___nl__16 = ___nl__21.clone();
//line 99
___nl__21 = null;
//line 100
if (true) {goto label_13;}
//line 100
label_13:
//line 100
___nl__20 = null;
//line 100
___nl__19 = null;
//line 101
if (true) {goto label_11;}
//line 101
label_11:
//line 101
___nl__18 = null;
//line 102
___nl__18 = ___nl__16.clone();
//line 102
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 102
___nl__18 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__18)).clone();
//line 102
if (c_rt_lib_NL.NL_check_true_native(___nl__18)) {if (true) {goto label_16;}}
//line 103
array_NL.NL_push(ref ___nl__10,___nl__15);

//line 104
if (true) {goto label_16;}
//line 104
label_16:
//line 104
___nl__18 = null;
//line 104
___nl__15 = null;
//line 104
___nl__16 = null;
//line 104
___nl__17 = null;
//line 105
___nl__12 = new ImmDouble((Double.Parse(___nl__12.getValue().ToString()))+(Double.Parse(___nl__13.getValue().ToString()))).clone();
//line 105
if (true) {goto label_9;}
//line 105
label_7:
//line 105
___nl__11 = null;
//line 105
___nl__12 = null;
//line 105
___nl__13 = null;
//line 105
___nl__14 = null;
//line 106
___nl__11 = c_rt_lib_NL.NL_get_ref_arr(___nl__0,___nl__7).clone();

//line 106
___nl__12 = ___nl__10.clone();
//line 106
((ImmHash)___nl__11).set("cmds", ___nl__12);
//line 106
c_rt_lib_NL.NL_set_ref_arr(ref ___nl__0,___nl__7,___nl__11);

//line 106
___nl__11 = null;
//line 106
___nl__12 = null;
//line 106
___nl__10 = null;
//line 107
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString()))).clone();
//line 107
if (true) {goto label_6;}
//line 107
label_4:
//line 107
___nl__6 = null;
//line 107
___nl__7 = null;
//line 107
___nl__8 = null;
//line 107
___nl__9 = null;
//line 107
___nl__3 = null;
//line 107
___nl__4 = null;
//line 107
___nl__5 = null;
//line 107
___nl__1 = null;
//line 107
___nl__2 = null;
//line 107
___arg__0 = ___nl__0;if(true) return null;
}

private static Imm NL_build_commands_graph_priv(Imm ___arg__0, Imm ___arg__1, Imm ___arg__2) {
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
Imm ___nl__13 = null;
Imm ___nl__14 = null;
Imm ___nl__15 = null;
Imm ___nl__16 = null;
Imm ___nl__17 = null;
Imm ___nl__18 = null;
Imm ___nl__19 = null;
Imm ___nl__20 = null;
Imm ___nl__21 = null;
Imm ___nl__22 = null;
Imm ___nl__23 = null;
Dictionary<String, Imm> __function_map;
//line 111
___nl__3 = new ImmArray(new Imm[0]).clone();
//line 112
___nl__4 = new ImmDouble(0).clone();
//line 112
___nl__5 = new ImmDouble(1).clone();
//line 112
label_3:
//line 112
___nl__6 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__4.getValue().ToString()))>=(Double.Parse(___nl__2.getValue().ToString())) ).clone();
//line 112
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_1;}}
//line 112
___nl__7 = new ImmArray(new Imm[0]).clone();
//line 112
array_NL.NL_push(ref ___nl__3,___nl__7);

//line 112
___nl__7 = null;
//line 112
___nl__4 = new ImmDouble((Double.Parse(___nl__4.getValue().ToString()))+(Double.Parse(___nl__5.getValue().ToString()))).clone();
//line 112
if (true) {goto label_3;}
//line 112
label_1:
//line 112
___nl__4 = null;
//line 112
___nl__5 = null;
//line 112
___nl__6 = null;
//line 113
___nl__4 = array_NL.NL_len(___nl__1).clone();

//line 113
___nl__5 = new ImmDouble(0).clone();
//line 113
___nl__6 = new ImmDouble(1).clone();
//line 113
label_6:
//line 113
___nl__7 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__4.getValue().ToString())) ).clone();
//line 113
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_4;}}
//line 114
___nl__8 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()].clone();
//line 115
___nl__9 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()].clone();
//line 116
___nl__10 = ((ImmHash)___nl__8).getHashValue()["reg_uses"].clone();
//line 116
___nl__12 = new ImmDouble(0).clone();
//line 116
___nl__13 = new ImmDouble(1).clone();
//line 116
___nl__14 = c_rt_lib_NL.NL_array_len(___nl__10).clone();

//line 116
label_9:
//line 116
___nl__15 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__12.getValue().ToString()))>=(Double.Parse(___nl__14.getValue().ToString())) ).clone();
//line 116
if (c_rt_lib_NL.NL_check_true_native(___nl__15)) {if (true) {goto label_7;}}
//line 116
___nl__11 = (___nl__10 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__12).getDoubleValue()].clone();
//line 117
___nl__16 = ((ImmHash)___nl__11).getHashValue()["type"].clone();
//line 117
___nl__17 = c_rt_lib_NL.NL_ov_is(___nl__16, new ImmString("write")).clone();
//line 117
if (c_rt_lib_NL.NL_check_true_native(___nl__17)) {if (true) {goto label_11;}}
//line 120
___nl__17 = c_rt_lib_NL.NL_ov_is(___nl__16, new ImmString("read")).clone();
//line 120
if (c_rt_lib_NL.NL_check_true_native(___nl__17)) {if (true) {goto label_12;}}
//line 124
___nl__17 = c_rt_lib_NL.NL_ov_is(___nl__16, new ImmString("clear")).clone();
//line 124
if (c_rt_lib_NL.NL_check_true_native(___nl__17)) {if (true) {goto label_13;}}
//line 124
___nl__17 = new ImmString("NOMATCHALERT").clone();
//line 124
___nl__17 = new ImmArray(new Imm[] {___nl__17,___nl__16,}).clone();
//line 124
c_rt_lib_NL.NL_die();
//line 117
label_11:
//line 118
__function_map = new Dictionary<String, Imm>();
___nl__18 = new ImmHash(__function_map).clone();
//line 118
___nl__20 = ((ImmHash)___nl__11).getHashValue()["reg"].clone();
//line 118
___nl__19 = ___nl__18.clone();
//line 118
(___nl__9 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__20).getDoubleValue()] = ___nl__19;
//line 118
___nl__18 = null;
//line 118
___nl__19 = null;
//line 118
___nl__20 = null;
//line 119
___nl__19 = ((ImmHash)___nl__11).getHashValue()["reg"].clone();
//line 119
___nl__18 = c_rt_lib_NL.NL_get_ref_arr(___nl__9,___nl__19).clone();

//line 119
___nl__20 = ((ImmHash)___nl__11).getHashValue()["cmd_nr"].clone();
//line 119
___nl__21 = new ImmString("").clone();
//line 119
hash_NL.NL_set_value(ref ___nl__18,___nl__20,___nl__21);

//line 119
___nl__21 = null;
//line 119
___nl__20 = null;
//line 119
c_rt_lib_NL.NL_set_ref_arr(ref ___nl__9,___nl__19,___nl__18);

//line 119
___nl__18 = null;
//line 119
___nl__19 = null;
//line 120
if (true) {goto label_10;}
//line 120
label_12:
//line 121
___nl__19 = ((ImmHash)___nl__11).getHashValue()["reg"].clone();
//line 121
___nl__18 = (___nl__9 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__19).getDoubleValue()].clone();
//line 121
___nl__19 = null;
//line 121
___nl__21 = c_rt_lib_NL.NL_init_iter(___nl__18).clone();

//line 121
label_16:
//line 121
___nl__19 = c_rt_lib_NL.NL_is_end_hash(___nl__21).clone();

//line 121
if (c_rt_lib_NL.NL_check_true_native(___nl__19)) {if (true) {goto label_14;}}
//line 121
___nl__19 = c_rt_lib_NL.NL_get_key_iter(___nl__21).clone();

//line 121
___nl__20 = c_rt_lib_NL.NL_hash_get_value(___nl__18,___nl__19).clone();

//line 122
___nl__23 = ((ImmHash)___nl__11).getHashValue()["cmd_nr"].clone();
//line 122
___nl__22 = c_rt_lib_NL.NL_get_ref_arr(___nl__3,___nl__23).clone();

//line 122
array_NL.NL_push(ref ___nl__22,___nl__19);

//line 122
c_rt_lib_NL.NL_set_ref_arr(ref ___nl__3,___nl__23,___nl__22);

//line 122
___nl__22 = null;
//line 122
___nl__23 = null;
//line 123
___nl__21 = c_rt_lib_NL.NL_next_iter(___nl__21).clone();

//line 123
if (true) {goto label_16;}
//line 123
label_14:
//line 123
___nl__18 = null;
//line 123
___nl__19 = null;
//line 123
___nl__20 = null;
//line 123
___nl__21 = null;
//line 124
if (true) {goto label_10;}
//line 124
label_13:
//line 125
___nl__19 = ((ImmHash)___nl__11).getHashValue()["reg"].clone();
//line 125
___nl__18 = (___nl__9 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__19).getDoubleValue()].clone();
//line 125
___nl__19 = null;
//line 125
___nl__21 = c_rt_lib_NL.NL_init_iter(___nl__18).clone();

//line 125
label_19:
//line 125
___nl__19 = c_rt_lib_NL.NL_is_end_hash(___nl__21).clone();

//line 125
if (c_rt_lib_NL.NL_check_true_native(___nl__19)) {if (true) {goto label_17;}}
//line 125
___nl__19 = c_rt_lib_NL.NL_get_key_iter(___nl__21).clone();

//line 125
___nl__20 = c_rt_lib_NL.NL_hash_get_value(___nl__18,___nl__19).clone();

//line 126
___nl__23 = ((ImmHash)___nl__11).getHashValue()["cmd_nr"].clone();
//line 126
___nl__22 = c_rt_lib_NL.NL_get_ref_arr(___nl__3,___nl__23).clone();

//line 126
array_NL.NL_push(ref ___nl__22,___nl__19);

//line 126
c_rt_lib_NL.NL_set_ref_arr(ref ___nl__3,___nl__23,___nl__22);

//line 126
___nl__22 = null;
//line 126
___nl__23 = null;
//line 127
___nl__21 = c_rt_lib_NL.NL_next_iter(___nl__21).clone();

//line 127
if (true) {goto label_19;}
//line 127
label_17:
//line 127
___nl__18 = null;
//line 127
___nl__19 = null;
//line 127
___nl__20 = null;
//line 127
___nl__21 = null;
//line 128
__function_map = new Dictionary<String, Imm>();
___nl__18 = new ImmHash(__function_map).clone();
//line 128
___nl__20 = ((ImmHash)___nl__11).getHashValue()["reg"].clone();
//line 128
___nl__19 = ___nl__18.clone();
//line 128
(___nl__9 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__20).getDoubleValue()] = ___nl__19;
//line 128
___nl__18 = null;
//line 128
___nl__19 = null;
//line 128
___nl__20 = null;
//line 129
if (true) {goto label_10;}
//line 129
label_10:
//line 129
___nl__16 = null;
//line 129
___nl__17 = null;
//line 130
___nl__12 = new ImmDouble((Double.Parse(___nl__12.getValue().ToString()))+(Double.Parse(___nl__13.getValue().ToString()))).clone();
//line 130
if (true) {goto label_9;}
//line 130
label_7:
//line 130
___nl__10 = null;
//line 130
___nl__11 = null;
//line 130
___nl__12 = null;
//line 130
___nl__13 = null;
//line 130
___nl__14 = null;
//line 130
___nl__15 = null;
//line 130
___nl__8 = null;
//line 130
___nl__9 = null;
//line 131
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString()))).clone();
//line 131
if (true) {goto label_6;}
//line 131
label_4:
//line 131
___nl__4 = null;
//line 131
___nl__5 = null;
//line 131
___nl__6 = null;
//line 131
___nl__7 = null;
//line 132
___nl__0 = null;
//line 132
___nl__1 = null;
//line 132
___nl__2 = null;
//line 132
if(true) return ___nl__3;
//line 132
___nl__3 = null;
//line 132
___nl__0 = null;
//line 132
___nl__1 = null;
//line 132
___nl__2 = null;
//line 132
if(true) return null;
}

private static Imm NL_visit_node_priv(Imm ___arg__0, Imm ___arg__1, ref Imm ___arg__2) {
Imm ___nl__0 = null;c_rt_lib_NL.NL_copy(ref ___nl__0, ___arg__0);Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);Imm ___nl__2 = ___arg__2;
Imm ___nl__3 = null;
Imm ___nl__4 = null;
Imm ___nl__5 = null;
Imm ___nl__6 = null;
Imm ___nl__7 = null;
Imm ___nl__8 = null;
Dictionary<String, Imm> __function_map;
//line 135
___nl__3 = hash_NL.NL_has_key(___nl__2,___nl__1).clone();

//line 135
___nl__3 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__3)).clone();
//line 135
if (c_rt_lib_NL.NL_check_true_native(___nl__3)) {if (true) {goto label_2;}}
//line 135
___nl__0 = null;
//line 135
___nl__1 = null;
//line 135
___nl__3 = null;
//line 135
___arg__2 = ___nl__2;if(true) return null;
//line 135
if (true) {goto label_2;}
//line 135
label_2:
//line 135
___nl__3 = null;
//line 136
___nl__3 = new ImmString("").clone();
//line 136
hash_NL.NL_set_value(ref ___nl__2,___nl__1,___nl__3);

//line 136
___nl__3 = null;
//line 137
___nl__3 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__1).getDoubleValue()].clone();
//line 137
___nl__5 = new ImmDouble(0).clone();
//line 137
___nl__6 = new ImmDouble(1).clone();
//line 137
___nl__7 = c_rt_lib_NL.NL_array_len(___nl__3).clone();

//line 137
label_5:
//line 137
___nl__8 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__5.getValue().ToString()))>=(Double.Parse(___nl__7.getValue().ToString())) ).clone();
//line 137
if (c_rt_lib_NL.NL_check_true_native(___nl__8)) {if (true) {goto label_3;}}
//line 137
___nl__4 = (___nl__3 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__5).getDoubleValue()].clone();
//line 138
unnecessary_commands_NL.NL_visit_node_priv(___nl__0,___nl__4,ref ___nl__2);

//line 139
___nl__5 = new ImmDouble((Double.Parse(___nl__5.getValue().ToString()))+(Double.Parse(___nl__6.getValue().ToString()))).clone();
//line 139
if (true) {goto label_5;}
//line 139
label_3:
//line 139
___nl__3 = null;
//line 139
___nl__4 = null;
//line 139
___nl__5 = null;
//line 139
___nl__6 = null;
//line 139
___nl__7 = null;
//line 139
___nl__8 = null;
//line 139
___nl__0 = null;
//line 139
___nl__1 = null;
//line 139
___arg__2 = ___nl__2;if(true) return null;
}

private static Imm NL_build_block_state_priv(ref Imm ___arg__0, Imm ___arg__1, Imm ___arg__2, Imm ___arg__3, ref Imm ___arg__4) {
Imm ___nl__0 = ___arg__0;Imm ___nl__1 = null;c_rt_lib_NL.NL_copy(ref ___nl__1, ___arg__1);Imm ___nl__2 = null;c_rt_lib_NL.NL_copy(ref ___nl__2, ___arg__2);Imm ___nl__3 = null;c_rt_lib_NL.NL_copy(ref ___nl__3, ___arg__3);Imm ___nl__4 = ___arg__4;
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
Dictionary<String, Imm> __function_map;
//line 143
___nl__5 = c_rt_lib_NL.NL_get_false().clone();
//line 144
___nl__6 = hash_NL.NL_has_key(___nl__4,___nl__2).clone();

//line 144
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 144
___nl__6 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__6)).clone();
//line 144
if (c_rt_lib_NL.NL_check_true_native(___nl__6)) {if (true) {goto label_2;}}
//line 145
___nl__7 = new ImmString("").clone();
//line 145
hash_NL.NL_set_value(ref ___nl__4,___nl__2,___nl__7);

//line 145
___nl__7 = null;
//line 146
___nl__7 = c_rt_lib_NL.NL_get_true().clone();
//line 146
___nl__5 = ___nl__7.clone();
//line 146
___nl__7 = null;
//line 147
if (true) {goto label_2;}
//line 147
label_2:
//line 147
___nl__6 = null;
//line 148
___nl__6 = array_NL.NL_len(___nl__3).clone();

//line 149
___nl__7 = new ImmDouble(0).clone();
//line 149
___nl__8 = new ImmDouble(1).clone();
//line 149
label_5:
//line 149
___nl__9 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__7.getValue().ToString()))>=(Double.Parse(___nl__6.getValue().ToString())) ).clone();
//line 149
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_3;}}
//line 150
___nl__10 = (___nl__3 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()].clone();
//line 150
___nl__13 = c_rt_lib_NL.NL_init_iter(___nl__10).clone();

//line 150
label_8:
//line 150
___nl__11 = c_rt_lib_NL.NL_is_end_hash(___nl__13).clone();

//line 150
if (c_rt_lib_NL.NL_check_true_native(___nl__11)) {if (true) {goto label_6;}}
//line 150
___nl__11 = c_rt_lib_NL.NL_get_key_iter(___nl__13).clone();

//line 150
___nl__12 = c_rt_lib_NL.NL_hash_get_value(___nl__10,___nl__11).clone();

//line 151
___nl__15 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__2).getDoubleValue()].clone();
//line 151
___nl__15 = (___nl__15 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__7).getDoubleValue()].clone();
//line 151
___nl__14 = hash_NL.NL_has_key(___nl__15,___nl__11).clone();

//line 151
___nl__15 = null;
//line 151
___nl__14 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__14)).clone();
//line 151
___nl__14 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__14)).clone();
//line 151
if (c_rt_lib_NL.NL_check_true_native(___nl__14)) {if (true) {goto label_10;}}
//line 152
___nl__15 = c_rt_lib_NL.NL_get_ref_arr(___nl__0,___nl__2).clone();

//line 152
___nl__16 = c_rt_lib_NL.NL_get_ref_arr(___nl__15,___nl__7).clone();

//line 152
___nl__17 = new ImmString("").clone();
//line 152
hash_NL.NL_set_value(ref ___nl__16,___nl__11,___nl__17);

//line 152
___nl__17 = null;
//line 152
c_rt_lib_NL.NL_set_ref_arr(ref ___nl__15,___nl__7,___nl__16);

//line 152
c_rt_lib_NL.NL_set_ref_arr(ref ___nl__0,___nl__2,___nl__15);

//line 152
___nl__15 = null;
//line 152
___nl__16 = null;
//line 153
___nl__15 = c_rt_lib_NL.NL_get_true().clone();
//line 153
___nl__5 = ___nl__15.clone();
//line 153
___nl__15 = null;
//line 154
if (true) {goto label_10;}
//line 154
label_10:
//line 154
___nl__14 = null;
//line 155
___nl__13 = c_rt_lib_NL.NL_next_iter(___nl__13).clone();

//line 155
if (true) {goto label_8;}
//line 155
label_6:
//line 155
___nl__10 = null;
//line 155
___nl__11 = null;
//line 155
___nl__12 = null;
//line 155
___nl__13 = null;
//line 156
___nl__7 = new ImmDouble((Double.Parse(___nl__7.getValue().ToString()))+(Double.Parse(___nl__8.getValue().ToString()))).clone();
//line 156
if (true) {goto label_5;}
//line 156
label_3:
//line 156
___nl__7 = null;
//line 156
___nl__8 = null;
//line 156
___nl__9 = null;
//line 157
___nl__7 = ___nl__5.clone();
//line 157
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 157
___nl__7 = c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native(___nl__7)).clone();
//line 157
if (c_rt_lib_NL.NL_check_true_native(___nl__7)) {if (true) {goto label_12;}}
//line 157
___nl__1 = null;
//line 157
___nl__2 = null;
//line 157
___nl__3 = null;
//line 157
___nl__5 = null;
//line 157
___nl__6 = null;
//line 157
___nl__7 = null;
//line 157
___arg__0 = ___nl__0;___arg__4 = ___nl__4;if(true) return null;
//line 157
if (true) {goto label_12;}
//line 157
label_12:
//line 157
___nl__7 = null;
//line 158
___nl__7 = (___nl__0 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__2).getDoubleValue()].clone();
//line 159
___nl__8 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__2).getDoubleValue()].clone();
//line 159
___nl__8 = ((ImmHash)___nl__8).getHashValue()["last_modif"].clone();
//line 159
___nl__11 = c_rt_lib_NL.NL_init_iter(___nl__8).clone();

//line 159
label_15:
//line 159
___nl__9 = c_rt_lib_NL.NL_is_end_hash(___nl__11).clone();

//line 159
if (c_rt_lib_NL.NL_check_true_native(___nl__9)) {if (true) {goto label_13;}}
//line 159
___nl__9 = c_rt_lib_NL.NL_get_key_iter(___nl__11).clone();

//line 159
___nl__10 = c_rt_lib_NL.NL_hash_get_value(___nl__8,___nl__9).clone();

//line 160
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__10, new ImmString("write")).clone();
//line 160
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_17;}}
//line 163
___nl__12 = c_rt_lib_NL.NL_ov_is(___nl__10, new ImmString("clear")).clone();
//line 163
if (c_rt_lib_NL.NL_check_true_native(___nl__12)) {if (true) {goto label_18;}}
//line 163
___nl__12 = new ImmString("NOMATCHALERT").clone();
//line 163
___nl__12 = new ImmArray(new Imm[] {___nl__12,___nl__10,}).clone();
//line 163
c_rt_lib_NL.NL_die();
//line 160
label_17:
//line 160
___nl__13 = c_rt_lib_NL.NL_ov_as(___nl__10, new ImmString("write")).clone();
//line 161
__function_map = new Dictionary<String, Imm>();
___nl__14 = new ImmHash(__function_map).clone();
//line 161
___nl__15 = ___nl__14.clone();
//line 161
(___nl__7 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()] = ___nl__15;
//line 161
___nl__14 = null;
//line 161
___nl__15 = null;
//line 162
___nl__14 = c_rt_lib_NL.NL_get_ref_arr(___nl__7,___nl__9).clone();

//line 162
___nl__15 = new ImmString("").clone();
//line 162
hash_NL.NL_set_value(ref ___nl__14,___nl__13,___nl__15);

//line 162
___nl__15 = null;
//line 162
c_rt_lib_NL.NL_set_ref_arr(ref ___nl__7,___nl__9,___nl__14);

//line 162
___nl__14 = null;
//line 162
___nl__13 = null;
//line 163
if (true) {goto label_16;}
//line 163
label_18:
//line 164
__function_map = new Dictionary<String, Imm>();
___nl__13 = new ImmHash(__function_map).clone();
//line 164
___nl__14 = ___nl__13.clone();
//line 164
(___nl__7 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__9).getDoubleValue()] = ___nl__14;
//line 164
___nl__13 = null;
//line 164
___nl__14 = null;
//line 165
if (true) {goto label_16;}
//line 165
label_16:
//line 165
___nl__12 = null;
//line 166
___nl__11 = c_rt_lib_NL.NL_next_iter(___nl__11).clone();

//line 166
if (true) {goto label_15;}
//line 166
label_13:
//line 166
___nl__8 = null;
//line 166
___nl__9 = null;
//line 166
___nl__10 = null;
//line 166
___nl__11 = null;
//line 167
___nl__8 = (___nl__1 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__2).getDoubleValue()].clone();
//line 167
___nl__8 = ((ImmHash)___nl__8).getHashValue()["next"].clone();
//line 167
___nl__10 = new ImmDouble(0).clone();
//line 167
___nl__11 = new ImmDouble(1).clone();
//line 167
___nl__12 = c_rt_lib_NL.NL_array_len(___nl__8).clone();

//line 167
label_21:
//line 167
___nl__13 = c_rt_lib_NL.NL_native_to_nl((Double.Parse(___nl__10.getValue().ToString()))>=(Double.Parse(___nl__12.getValue().ToString())) ).clone();
//line 167
if (c_rt_lib_NL.NL_check_true_native(___nl__13)) {if (true) {goto label_19;}}
//line 167
___nl__9 = (___nl__8 as ImmArray).getArrayValue()[(int)((ImmDouble)___nl__10).getDoubleValue()].clone();
//line 168
unnecessary_commands_NL.NL_build_block_state_priv(ref ___nl__0,___nl__1,___nl__9,___nl__7,ref ___nl__4);

//line 169
___nl__10 = new ImmDouble((Double.Parse(___nl__10.getValue().ToString()))+(Double.Parse(___nl__11.getValue().ToString()))).clone();
//line 169
if (true) {goto label_21;}
//line 169
label_19:
//line 169
___nl__8 = null;
//line 169
___nl__9 = null;
//line 169
___nl__10 = null;
//line 169
___nl__11 = null;
//line 169
___nl__12 = null;
//line 169
___nl__13 = null;
//line 169
___nl__5 = null;
//line 169
___nl__6 = null;
//line 169
___nl__7 = null;
//line 169
___nl__1 = null;
//line 169
___nl__2 = null;
//line 169
___nl__3 = null;
//line 169
___arg__0 = ___nl__0;___arg__4 = ___nl__4;if(true) return null;
}

}
}