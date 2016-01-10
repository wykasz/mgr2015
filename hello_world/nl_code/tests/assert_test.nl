use nl;
use assert;

def assert_test::test(){
	assert::section('Assert test');
	assert::assert('1', 1, 1, true);
	assert::assert('2', 1, 2, false);
	assert::assert('2', -1, 1, false);
	assert::assert('2', true, true, true);
	assert::assert('2', true, false, false);
	assert::assert('2', [], [], true);
	assert::assert('2', [1,2,3], [1,2,3], true);
	assert::assert('2', [1,2,3], [3,2,1], false);
	assert::assert('2', {}, {}, true);
	assert::assert('2', {a=>'b'}, {a=>'b'}, true);
	assert::assert('2', {a=>'b'}, {}, false);
	assert::assert('2', :a, :a, true);
	assert::assert('2', :a, :b, false);
	assert::assert('2', {}, [], false);
}
