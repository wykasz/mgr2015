###
# (c) Atinea Sp. z o.o.
###


use tct;
use array;
use hash;
use ov;
use nast;
use ptd;


def ptd_parser::fun_def_to_ptd(ast : @nast::cmd_t) : ptd::var({ok => @tct::meta_type, err => ptd::sim()}) {
	var cmd = ast->cmd;
	cmd = cmd as :block;
	return :err('type function should have only a return command') unless array::len(cmd) == 1 && ov::is(cmd[0]->cmd, 'return');
	return ptd_parser::try_value_to_ptd(cmd[0]->cmd as :return);
}

def ptd_parser::try_value_to_ptd(ast : @nast::value_t) : ptd::var({ok => @tct::meta_type, err => ptd::sim()}) {
	if (ov::is(ast, 'unary_op')) {
		var op = ov::as(ast, 'unary_op');
		return :err('ptd function argument can be other ptd function or reference type start witch @: ' . op->op)
			unless
			op->op eq '@';
		var fun_str = ov::as(op->val, 'fun_label');
		return :ok(tct::tct_ref(fun_str->module . '::' . fun_str->name));
	}

	return :err('can parse only function: ' . ov::get_element(ast)) unless ov::is(ast, 'fun_val');
	var fun_val : @nast::fun_val_t = ast as :fun_val;
	return :err('can parse only ptd function: ' . fun_val->module . '::' . fun_val->name)
		unless
		fun_val->module eq 'ptd';
	var args_size : ptd::sim() = array::len(fun_val->args);
	var fun_name : ptd::sim() = fun_val->name;
	if (fun_name eq 'sim') {
		return :err('sim can''t have arguments: ' . args_size) unless args_size == 0;
		return :ok(tct::tct_sim());
	} elsif (fun_name eq 'ptd_im') {
		return :err('im can''t have arguments: ' . args_size) unless args_size == 0;
		return :ok(tct::tct_im());
	} elsif (fun_name eq 'void') {
		return :err('Void type can be used only as a return type of function');
	}
	return :err('''none'' type can be used only in ''var'' type') if fun_name eq 'none';
	return :err('expected one argument in ' . fun_name . ' function call') unless array::len(fun_val->args) == 1;
	var fun_arg : @nast::value_t = fun_val->args[0]->val;
	if (fun_name eq 'rec') {
		return :err('rec must have hash: ' . ov::get_element(fun_arg)) unless ov::is(fun_arg, 'hash_decl');
		try var ret = parse_hash(fun_arg);
		return :ok(tct::tct_rec(ret));
	} elsif (fun_name eq 'hash') {
		try var ret = ptd_parser::try_value_to_ptd(fun_arg);
		return :ok(tct::tct_hash(ret));
	} elsif (fun_name eq 'arr') {
		try var ret = ptd_parser::try_value_to_ptd(fun_arg);
		return :ok(tct::tct_arr(ret));
	} elsif (fun_name eq 'var') {
		return :err('var must have hash' . args_size) unless args_size == 1;
		return :err('var must have hash: ' . ov::get_element(fun_arg)) unless ov::is(fun_arg, 'hash_decl');
		var hash_decl = fun_arg as :hash_decl;
		var elems = {};
		fora var hash_elem (hash_decl) {
			if(ov::is(hash_elem->val, 'fun_val')){
				fun_val = hash_elem->val as :fun_val;
				if(fun_val->module eq 'ptd' && fun_val->name eq 'none'){
					hash::set_value(ref elems, ov::as(hash_elem->key, 'hash_key'), tct::tct_none());
					continue;
				}
			}
			try var ret = ptd_parser::try_value_to_ptd(hash_elem->val);
			hash::set_value(ref elems, ov::as(hash_elem->key, 'hash_key'), ret);
		}
		return :ok(tct::tct_var(elems));
	} else {
		return :err('it is not type function : ' . fun_name);
	}

}

def parse_hash(fun_arg : @nast::value_t) : ptd::var({ok => ptd::hash(@tct::meta_type), err => ptd::sim()}) {
	var hash_decl = fun_arg as :hash_decl;
	var elems = {};
	fora var hash_elem (hash_decl) {
		try var ret = ptd_parser::try_value_to_ptd(hash_elem->val);
		hash::set_value(ref elems, ov::as(hash_elem->key, 'hash_key'), ret);
	}
	return :ok(elems);
}

