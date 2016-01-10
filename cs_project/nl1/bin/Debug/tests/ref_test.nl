use nl;
use assert;
use array;
use hash;

def test1_f1(ref a){
	a = 5;
}

def test1(){
	var a = 1;
	var b = a;
	assert::assert('1.1', a, b, true);

	b = 2;
	assert::assert('1.2', a, b, false);
	
	var c = a;
	test1_f1(ref a);
	assert::assert('1.3', a, 5, true);
	assert::assert('1.4', b, 5, false);
	assert::assert('1.5', c, 5, false);
}

def test2(){
	var arr = [];
	array::push(ref arr, 1);
	assert::assert('2.1', array::len(arr), 1, true);
	assert::assert('2.2', arr[0], 1, true);
	
	var brr = [];
	rep var i (10){
		array::push(ref brr, i);
	}
	assert::assert('2.3', array::len(brr), 10, true);
	assert::assert('2.4', brr[0], 0, true);
	assert::assert('2.5', brr[9], 9, true);
}

def test3(){
	var arr = [];
	array::push(ref arr, 1);
	assert::assert('3.1', array::len(arr), 1, true);
	assert::assert('3.2', arr[0], 1, true);
	
	var brr = arr;
	assert::assert('3.3', arr, brr, true);
	
	array::push(ref brr, 2);
	assert::assert('3.4', array::len(brr), 2, true);
	assert::assert('3.5', brr[0], 1, true);
	assert::assert('3.6', brr[1], 2, true);
	assert::assert('3.7', arr, brr, false);
}

def test45_f1(ref a){
	a = 5;
}

def test4(){
	var arr = [];
	array::push(ref arr, 1);
	assert::assert('4.1', array::len(arr), 1, true);
	assert::assert('4.2', arr[0], 1, true);
	
	var brr = arr;
	assert::assert('4.3', arr, brr, true);

	test45_f1(ref arr[0]);
	assert::assert('4.4', arr[0], 5, true);
	assert::assert('4.5', arr, brr, false);
}

def test5(){
	var arr = [];
	array::push(ref arr, [1]);
	assert::assert('5.1', array::len(arr), 1, true);
	assert::assert('5.2', arr[0], [1], true);
	
	var brr = arr;
	assert::assert('5.3', arr, brr, true);

	test45_f1(ref arr[0][0]);
	assert::assert('5.4', arr[0][0], 5, true);
	assert::assert('5.5', arr, brr, false);
}

def ref_test::test(){
	assert::section('Ref test');
	test1();
	test2();
	test3();
	test4();
	test5();
}



