###
# (c) Atinea Sp. z o.o.
# Stamp: MBN 2014-10-16
###

use array;
use boolean_t;
use string_utils;
use nl;
use nlasm;
use ov;
use ptd;
use string;

def generator_cs::generate(nlasm : @nlasm::result_t) : ptd::sim() {
	var result = '';
	result .= print_imports(nlasm);
	result .= print_class_begin(nlasm->module_name);
	result .= print_function_or_singleton(function, nlasm->module_name) fora var function (nlasm->functions);
	result .= print_class_end();
	return result;
}


def print_imports(asm : @nlasm::result_t) {
	var result = '';
	result .= 'using System;' . string::lf();
	result .= 'using System.Collections.Generic;' . string::lf();
	result .= 'using nianio;' . string::lf();
	#fora var import (asm->imports) {
	#	result .= 'use nianio.'. get_class_name(import) .';' . string::lf();
	#}
	return result;
}

def get_class_name(module_name : ptd::sim()) {
	return module_name.'_NL';
}

def print_class_begin(module_name : ptd::sim()) {
	var result = 'namespace nianio { '.string::lf();
	result .= 'public class ' . get_class_name(module_name) . ' {'. string::lf();
	return result;
}

def print_class_end() {
	var result = string::lf().'}';
	result .= string::lf().'}';
	return result;
}

def get_function_name(function : @nlasm::function_t) {
	var suffix = '';
	match (function->access) case :pub {
	} case :priv {
		suffix = '_priv';
	}
	return 'NL_'.(function->name).suffix;
}

def get_function_declaration(function : @nlasm::function_t) {
	var result = '';
	match (function->access) case :pub {
		result = 'public';
	} case :priv {
		result = 'private';
	}
	return result . ' static Imm ' . get_function_name(function);
}

def escape_string(string) : ptd::sim() {
	string = string::replace(string, '\', '\\');
	string = string::replace(string, '"', '\"');
	string = string::replace(string, string::chr(13).string::lf(), '\r\n');
	return string::replace(string, string::lf(), '\n');
}
def is_singleton_use_function(function : @nlasm::function_t) : @boolean_t::type {
	return false if(array::len(function->args_type) > 0);
	return true if function->annotation is :math;
	var was_singleton = false;
	var dest;
	fora var cmd (function->commands) {
		var command = cmd->cmd;
		if(command is :call){
			var call = command as :call;
			continue unless(call->fun_name eq 'sigleton_do_not_use_without_approval');
			continue unless(call->mod eq 'singleton');
			was_singleton = true;
			dest = call->dest;
		} elsif(command is :return){
			return false unless was_singleton;
			var ret = command as :return;
			return false unless(ret is :val);
			return ret as :val eq dest;
		} elsif(command is :prt_lbl) {
		} elsif(command is :clear) {
		} else {
			return false if(was_singleton);
		}
	}
	return false;
}


def print_function_or_singleton(function : @nlasm::function_t, module_name : ptd::sim()) : ptd::sim() {
	if(is_singleton_use_function(function)){
		var sin_fun = function;
		sin_fun->name = 'SINGLETON_' . function->name ;
		var sin_name = get_function_name(sin_fun);
		var var_name = 'value__singleton__' . sin_name;

		var ret = print_function(sin_fun, module_name);
		
		ret .= 'private static Imm '.var_name.' = null;' .string::lf().
		get_function_declaration(function) .'() {
		'	if ('.var_name.' == null) {
		'		'.var_name.' = '. sin_name .'();
		'	}
		'	return '.var_name.';
		'}';
		return ret;
	} else {
		return print_function(function, module_name);
	}
	
}
def print_function(function : @nlasm::function_t, module_name : ptd::sim()) : ptd::sim() {
	var result = string::lf().get_function_declaration(function).'(';
	rep var i (array::len(function->args_type)) {
		result .= ', ' unless i == 0;
		match (function->args_type[i]) case :val {
			result .= 'Imm ___arg__'.i;
		} case :ref {
			result .= 'ImmRef ___arg__'.i;
		}
	}
	result .= ') {'.string::lf();
	rep var i (array::len(function->args_type)) {
		match (function->args_type[i]) case :val {
			result .= 'Imm ___nl__'.i.' = ___arg__'.i.'.clone();';
		} case :ref {
			result .= 'Imm ___nl__'.i.' = ___arg__'.i.'.getValue().clone();';
		}
	}
	result .= string::lf();
	for (var i = array::len(function->args_type); i < function->reg_size; ++i) {
		result .= 'Imm ___nl__'.i.' = null;'.string::lf();
	}
	for (var i = 0; i < function->reg_size; ++i) {
		result .= 'ImmRef ___ref______nl__'.i.' = null;'.string::lf();
	}
	result .= 'Dictionary<String, Imm> '.print_hash_name().';'. string::lf();
	
	var return_commands = '';
	rep var i (array::len(function->args_type)) {
		match (function->args_type[i]) case :val {
		} case :ref {
			return_commands .= '___arg__'.i.'.setValue(___nl__'.i.');';
		}
	}
	
	result .= print_command(module_name, command, return_commands) fora var command (function->commands);
	
	return result.'}'.string::lf();
}

def print_command(module : ptd::sim(), command : @nlasm::cmd_t, return_commands) {
	var result;
	match (command->cmd) case :arr_decl(var arr_decl) {
		result = print_register_setter(arr_decl->dest, print_arr(arr_decl->src)).';';
	} case :hash_decl(var hash_decl) {
		result = print_hash(hash_decl);
		result .= print_register_setter(hash_decl->dest, 'new ImmHash('.print_hash_name().')').';';
	} case :call(var call) {
		result = print_call_ref_prepare(call->args);
		result .= print_register_setter(call->dest, print_call(module, call->mod, call->fun_name, call->args)).';'.string::lf();
		result .= print_call_ref_setter(call->args);
	} case :func(var func) {
		result = print_const_hash(func->dest, {module => get_class_name(func->module), name => func->name}).';';
	} case :una_op(var una_op) {
		result = print_una_op(una_op);
	} case :bin_op(var bin_op) {
		result = print_bin_op(bin_op);
	} case :ov_is(var ov_is) {
		result = print_register_setter(ov_is->dest, 'c_rt_lib_NL.NL_ov_is('.print_register(ov_is->src).', new ImmString("'.escape_string(ov_is->type).'"))').';';
	} case :ov_as(var ov_as) {
		result = print_register_setter(ov_as->dest, 'c_rt_lib_NL.NL_ov_as('.print_register(ov_as->src).', new ImmString("'.escape_string(ov_as->type).'"))').';';
	} case :return(var return_i) {
		result = return_commands;
		result .= print_return(return_i);
	} case :die(var die_i) {
		result = 'c_rt_lib_NL.NL_die();';
	} case :move(var move) {
		result = print_register_setter(move->dest, print_register(move->src)).';';
	} case :load_const(var const){
		result = print_register_setter(const->dest, print_const_value(print_register(const->dest), const->val)).';';
	} case :get_frm_idx(var get_frm_idx) {
		result = '('.print_register(get_frm_idx->src).' as ImmArray).getArrayValue()';
		result .= '[(int)((ImmDouble)'.print_register(get_frm_idx->idx).').getDoubleValue()]';
		result = print_register_setter(get_frm_idx->dest, result).';';
	} case :set_at_idx(var set_at_idx) {
		result = '('.print_register(set_at_idx->src).' as ImmArray).getArrayValue()';
		result .= '[(int)((ImmDouble)'.print_register(set_at_idx->idx).').getDoubleValue()] = '.print_register(set_at_idx->val).';';
	} case :get_val(var get_val) {
		result = print_register_setter(get_val->dest, print_get_hash_value(get_val)).';';
	} case :set_val(var set_val) {
		result = print_set_hash_value(set_val).';';
	} case :ov_mk(var ov_mk) {
		result = print_ov_mk(ov_mk);
	} case :prt_lbl(var prt_lbl) {
		result = ''.prt_lbl.':';
	} case :if_goto(var if_goto) {
		result = 'if (c_rt_lib_NL.NL_check_true_native('.print_register(if_goto->src).')) {'.print_goto(if_goto->dest).'}';
	} case :goto(var goto) {
		result = print_goto(goto);
	} case :clear(var reg) {
		result = print_register_setter(reg, 'null').';';
	}
	return '//line ' . command->debug->nast_debug->begin->line . string::lf() . result.string::lf();
}

def print_arr(arr) : ptd::sim() {
	var result = 'new ImmArray(new Imm[';
	if (array::len(arr) == 0) {
		result .= '0]';
	} else {
		result .= '] {';
		result .= print_register(reg).',' fora var reg (arr);
		result .= '}';
	}
	return result . ')';
}

def print_bin_op(bin_op) : ptd::sim() {
	var result = '';
	if (bin_op->op eq '>=' || bin_op->op eq '<=' || bin_op->op eq '<' || bin_op->op eq '>' || bin_op->op eq '=='
		|| bin_op->op eq '!=') {
		result .= 'c_rt_lib_NL.NL_native_to_nl(' . print_imm_double_operation(bin_op) .' )';
	} elsif (bin_op->op eq 'eq' || bin_op->op eq 'ne') {
		result .= 'c_rt_lib_NL.NL_native_to_nl(';
		if (bin_op->op eq 'ne') {
			result .= '!';
		}
		result .= print_register(bin_op->left).'.toString().Equals(';
		result .= print_register(bin_op->right).'.toString()))';
	} elsif (bin_op->op eq '.') {
		result .= 'new ImmString('.print_register(bin_op->left).'.toString() + '.print_register(bin_op->right).'.toString())';
	} else {
		result .= 'new ImmDouble('.print_imm_double_operation(bin_op).')';
	}
	return print_register_setter(bin_op->dest, result).';';
}

def print_imm_double_operation(bin_op) : ptd::sim() {
	var result = print_register_as_number(bin_op->left);
	if (bin_op->op eq '==' || bin_op->op eq '!=') {
		result .= ' '. bin_op->op . '('. print_register_as_number(bin_op->right).') ';
	} else {
		result .= bin_op->op .print_register_as_number(bin_op->right);
	}
	return result;
}

def print_register_as_number(value) : ptd::sim() {
	return '(Double.Parse('.print_register(value). print_getter().'.ToString()))';
}

def print_call(module : ptd::sim(), cmodule : ptd::sim(), cname : ptd::sim(), cargs) : ptd::sim() {
	cname = cname.'_priv' if cmodule eq '';
	cmodule = module if cmodule eq '';
	var result = get_class_name(cmodule) . '.NL_' .(cname).'(';
	var i = 0;
	fora var arg (cargs) {
		result .= ',' unless i == 0;
		++i;
		match (arg) case :ref(var reg) {
			result .= '___ref___'.print_register(reg);
		} case :val(var reg) {
			result .= print_register(reg);
		}
	}
	return result.')';
}

def print_call_ref_prepare(cargs) : ptd::sim() {
	var result = '';
	fora var arg (cargs) {
		match (arg) case :ref(var reg) {
			result .= '___ref___'.print_register(reg).' = new ImmRef('.print_register(reg).');'.string::lf();
		} case :val(var reg) {
		}
	}
	return result;
}

def print_call_ref_setter(cargs) : ptd::sim() {
	var result = '';
	fora var arg (cargs) {
		match (arg) case :ref(var reg) {
			var val = '___ref___'.print_register(reg).'.getValue()';
			result .= print_register_setter(reg, val).';'.string::lf();
		} case :val(var reg) {
		}
	}
	return result;
}

def print_const_arr(reg, arr) : ptd::sim() {
	var result = 'new Imm[] {';
	result .= print_const_value(reg, val) . ',' fora var val (arr);
	return result.'}';
}

def print_const_hash(reg, hash) : ptd::sim() {
	var result = print_hash_name() . ' = new Dictionary<String, Imm>();' . string::lf();
	result .= print_hash_name().'.Add("'.escape_string(key).'",'.print_const_value(reg, val).');' . string::lf() forh var key, var val (hash);
	return result.print_register_setter(reg, 'new ImmHash('.print_hash_name().')');
}

def print_const_ov(reg, variant) : ptd::sim() {
	var result = '';
	if (ov::has_value(variant)) {
		result = 'new OV("' . escape_string(ov::get_element(variant)) . '", ' . print_const_value(reg, ov::get_value(variant)) . ')';
	} else {
		result = 'new OV("' . escape_string(ov::get_element(variant)) . '", null)';
	}
	return result;
}

def print_const_value(reg, value) {
	if (nl::is_sim(value) && (string_utils::is_integer(ptd::ensure(ptd::sim(), value)) || 
		string_utils::is_float(ptd::ensure(ptd::sim(), value)))) {
		return 'new ImmDouble('. value . ')';
	} elsif (nl::is_sim(value)) {
		return 'new ImmString("'.escape_string(value).'")';
	} elsif (nl::is_array(value)) {	
		return print_const_arr(reg, value);
	} elsif (nl::is_hash(value)) {
		return print_const_hash(reg, value);
	} elsif (nl::is_variant(value)) {
		return print_const_ov(reg, value);
	} else {
		die;
	}
}

def print_goto(goto : ptd::sim()) : ptd::sim() {
	return 'if (true) {goto '.goto.';}';
}

def print_hash(hash) : ptd::sim() {
	var result = print_hash_name() . ' = new Dictionary<String, Imm>();' . string::lf();
	result .= print_hash_name().'.Add("'.escape_string(map->key).'",'.print_register(map->val).');' . string::lf() fora var map (hash->src);
	return result;
}

def print_hash_name() : ptd::sim() {
	return '__function_map';
}

def print_get_hash_value(get_val) {
	return '((ImmHash)'.print_register(get_val->src).').getHashValue()["'.escape_string(get_val->key).'"]';
}

def print_set_hash_value(set_val) {
	var result = '((ImmHash)'.print_register(set_val->src).').set("'.escape_string(set_val->key).'", ';
	result .= print_register(set_val->val) . ')';
	return result;
}

def print_ov_mk(ov_mk) : ptd::sim() {
	var result = '';
	if (ov_mk->src is :emp && (ov_mk->name eq 'TRUE')) {
		result = 'c_rt_lib_NL.NL_get_true()';
	} elsif (ov_mk->src is :emp && (ov_mk->name eq 'FALSE')) {
		result = 'c_rt_lib_NL.NL_get_false()';
	} else {
		match (ov_mk->src) case :arg(var arg) {
			result = 'c_rt_lib_NL.NL_ov_mk_arg(new ImmString("'.escape_string(ov_mk->name).'"), '.print_register(arg).')';
		} case :emp {
			result = 'c_rt_lib_NL.NL_ov_mk_none(new ImmString("'.escape_string(ov_mk->name).'"))';
		}
	}
	return print_register_setter(ov_mk->dest, result).';';
}

def print_register(register) : ptd::sim() {
	return '___nl__'.register;
}

def print_getter() : ptd::sim() {
	return '.getValue()';
}

def print_register_setter(register, value) : ptd::sim() {
	return value.'' if register eq '';
	return print_register(register).' = ' . value;
}

def print_return(return_i) : ptd::sim() {
	var result = '';
	match (return_i) case :val(var val) {
		result = 'return '.print_register(val).';';
	} case :emp {
		result = 'return null;';
	}
	return 'if(true) '.result;
}

def print_una_op(una_op) : ptd::sim() {
	var result = '';
	if (una_op->op eq '!') {
		result .= 'c_rt_lib_NL.NL_native_to_nl(!c_rt_lib_NL.NL_check_true_native('.print_register(una_op->src).'))';
	} else {
		result .= 'new ImmDouble('.una_op->op.'((ImmDouble)'.print_register(una_op->src).').getDoubleValue())';
	}
	return  print_register_setter(una_op->dest, result).';';
}

