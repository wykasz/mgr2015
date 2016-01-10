use nl;
use assert;

def assert_test::test(){
	assert::section('Assert test');
	assert::assert('1', 1, 1, true);
	assert::assert('2', 1, 2, false);
	assert::assert('3', -1, 1, false);
	assert::assert('4', true, true, true);
	assert::assert('5', true, false, false);
	assert::assert('6', [], [], true);
	assert::assert('7', [1,2,3], [1,2,3], true);
	assert::assert('8', [1,2,3], [3,2,1], false);
	assert::assert('9', {}, {}, true);
	assert::assert('10', {a=>'b'}, {a=>'b'}, true);
	assert::assert('11', {a=>'b'}, {}, false);
	assert::assert('12', :a, :a, true);
	assert::assert('13', :a, :b, false);
	assert::assert('13', {}, [], false);
}
