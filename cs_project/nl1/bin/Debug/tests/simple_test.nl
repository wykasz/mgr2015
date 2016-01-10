use nl;
use assert;


def test1(){
	var a = 3;
	var b = a;
	assert::assert('1.1', a, b, true);
	a = 2;
	assert::assert('1.2', a, b, false);
}

def test2(){
	var a = 3;
	var b = [a];
	assert::assert('2.1', a, b[0], true);
	a = 2;
	assert::assert('2.2', a, b[0], false);
	b[0] = 2;
	assert::assert('2.3', a, b[0], true);
}

def test3(){
	var a = 3;
	var b = {a => a};
	assert::assert('3.1', a, b->a, true);
	a = 2;
	assert::assert('3.2', a, b->a, false);
	b->a = 2;
	assert::assert('3.3', a, b->a, true);
}

def test4(){
	var a = 3;
	var b = :ok(a);
	assert::assert('4.1', a, b as :ok, true);
	a = 2;
	assert::assert('4.2', a, b as :ok, false);
}

def simple_test::test(){
	assert::section('Simple test');
	
	test1();
	test2();
	test3();
	test4();
}