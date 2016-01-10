use nl;
use assert;
use array;
use hash;
use c_fe_lib;

def test1_f1(s){
	var arr = [];
	rep var j (s){
		array::push(ref arr, j);
	}
}

def test1(){
	assert::section('Array push test');
	
	var p = 10;
	var m = 2;
	var s = 1;
	var it = 1000;
	var res = [];
	
	rep var i (p+1){
		
		var t1 = c_fe_lib::get_time();
		rep var j (it){
			test1_f1(s);
		}
		var t2 = c_fe_lib::get_time();
		
		array::push(ref res, {
			size => s,
			time => t2[0] - t1[0],
			tps => (t2[0] - t1[0]) / s,
			time_vs_base => 0,
			time_vs_base_vs_size => 0,
		});
		
		s *= m;
	}
	
	var time_base = res[0]->time;
	rep var i (p+1){
		var time = res[i]->time;
		var size = res[i]->size;
		
		res[i]->time_vs_base = time / time_base;
		res[i]->time_vs_base_vs_size = (time / time_base) / size;
	}
	
	assert::print('Array push result: ', res);
}

def test2(){
	assert::section('Array cp test');

	var it = 1000;
	var s1 = 1000*1;
	var s2 = 1000*10;
	
	var bv = 1;
	var bt = 0;
	assert::assert('2.1', bv, bt, false);
	
	var base_t1 = c_fe_lib::get_time();
	rep var j (it){
		bt = bv;
	}
	var base_t2 = c_fe_lib::get_time();
	var base_dt = base_t2[0] - base_t1[0];
	
	assert::assert('2.2', bv, bt, true);

	
	var arr = [];
	rep var j (s1){
		array::push(ref arr, j);
	}
	var brr = [];
	assert::assert('2.3', arr, brr, false);
	
	var test_t1 = c_fe_lib::get_time();

	rep var j (it){
		brr = arr;
	}
	var test_t2 = c_fe_lib::get_time();
	var test_dt = test_t2[0] - test_t1[0];
	assert::assert('2.4', arr, brr, true);
	
	arr = [];
	rep var j (s2){
		array::push(ref arr, j);
	}
	brr = [];
	assert::assert('2.5', arr, brr, false);
	
	var test2_t1 = c_fe_lib::get_time();

	rep var j (it){
		brr = arr;
	}
	var test2_t2 = c_fe_lib::get_time();
	var test2_dt = test2_t2[0] - test2_t1[0];
	assert::assert('2.6', arr, brr, true);
	
	assert::print('Base time', base_dt);
	assert::print('Test 1 time', test_dt);
	assert::print('Test 2 time', test2_dt);
}

def complexity_test::test(){
	assert::section('Complexity test');
	assert::print('time: ', c_fe_lib::get_time());
	test1();
	test2();
}