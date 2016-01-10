use nl;
use dfile;
use string;

def assert::section(label){
	nl::print(string::lf() . string::lf() . 'Section: ' . label . string::lf());
}

def assert::assert(label, left, right, bool){
	var a = dfile::ssave(left);
	var b = dfile::ssave(right);
	var c = a eq b;
	if((c && bool) || !(c || bool)){
		nl::print(label. ' OK ' . string::lf());
	}else{
		nl::print(label. ' ERR ' . string::lf());
	}
}

def assert::assert_s(label, val, bool){
	if((val && bool) || !(val || bool)){
		nl::print(label. ' OK ' . string::lf());
	}else{
		nl::print(label. ' ERR ' . string::lf());
	}
}

def assert::print(label, val){
	nl::print(label. dfile::ssave(val) . string::lf());
}