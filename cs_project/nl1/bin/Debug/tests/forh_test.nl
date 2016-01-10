use nl;
use assert;
use hash;
use array;

def forh_test::test() {
	assert::section('Forh test');

	var h = {a => 'xx', b => 'yy', c => 'zz'};
	var was = {};
	forh var key, var value (h) {
		hash::set_value(ref was, key . value, 1);
	}
	assert::assert_s('1', hash::has_key(was, 'axx'), true);
	assert::assert_s('2', hash::has_key(was, 'byy'), true);
	assert::assert_s('3', hash::has_key(was, 'czz'), true);
	assert::assert('4', hash::size(was), 3, true);
	var iter = 0;
	for(;;){
		break if(iter == 10);
		++iter;
	}
	assert::assert('5', iter, 10, true);
	var arr = [];
	exec2(ref arr);

	var hash = {arr=>arr, inne=>''};
	exec(ref hash->arr, i) rep var i (100);
	
	hash->arr[i] += i rep var i (100);
	
	var long = {};
	rep var i (100){
		hash::set_value(ref long, i, true);
	}
	rep var i (100){
		hash::delete(ref long, i);
	}
	assert::assert('6', hash::size(long), 0, true);
}

def exec(ref arr, i) {
	array::push(ref arr, i);
	arr[0] = i;
	if(false){
		return;
	}else{
		loop{
			return;
		}
	}
}

def exec2(ref arr) {
	array::push(ref arr, i) rep var i (100000);
}


