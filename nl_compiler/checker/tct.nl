###
# (c) Atinea Sp. z o.o.
###


use hash;
use ptd;
use ov;


def tct::tct_arr(arr_type : @tct::meta_type) : @tct::meta_type  {
	return :tct_arr(arr_type);
}

def tct::tct_rec(h : ptd::hash(@tct::meta_type)) : @tct::meta_type  {
	return :tct_rec(h);
}

def tct::tct_ref(name : ptd::sim()) : @tct::meta_type  {
	return :tct_ref(name);
}

def tct::tct_sim() : @tct::meta_type  {
	return :tct_sim;
}

def tct::tct_none() {
	return :tct_var_none;
}

def tct::tct_void() : @tct::meta_type {
	return :tct_void;
}

def tct::tct_empty() : @tct::meta_type {
	return :tct_empty;
}

def tct::tct_hash(h : @tct::meta_type) : @tct::meta_type  {
	return :tct_hash(h);
}

def tct::tct_im() : @tct::meta_type  {
	return :tct_im;
}

def tct::tct_bool() : @tct::meta_type {
	return tct::tct_var({FALSE => tct::tct_none(), TRUE => tct::tct_none()});
}

def tct::tct_var(h) : @tct::meta_type {
	var types = {};
	forh var item, var value (h) {
		var et;
		if (ov::is(value, 'tct_var_none')) {
			et = :no_param;
		} else {
			et = :with_param(ptd::ensure(@tct::meta_type, value));
		}

		hash::set_value(ref types, item, et);
	}
	return :tct_var(types);
}

def tct::meta_type() {
	return ptd::var({
			tct_rec => ptd::hash(@tct::meta_type),
			tct_hash => @tct::meta_type,
			tct_arr => @tct::meta_type,
			tct_var => ptd::hash(ptd::var({with_param => @tct::meta_type, no_param => ptd::none()})),
			tct_ref => ptd::sim(),
			tct_sim => ptd::none(),
			tct_empty => ptd::none(),
			tct_void => ptd::none(),
			tct_im => ptd::none()
		});
}

