use assert_test;
use simple_test;
use forh_test;
use ref_test;
use complexity_test;

def test::test(){
	assert_test::test();
	simple_test::test();
	forh_test::test();
	ref_test::test();
	complexity_test::test();
}