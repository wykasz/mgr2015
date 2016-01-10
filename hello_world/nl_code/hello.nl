use nl;

def unpack(variant){
	match(variant)
	case :zero{
		return 0;
	}case :one{
		return 1;
	}case :strict_value(var value){
		return value;
	}
}

def example::main(){
	var result = 0;
	var variant = :one;
	
	match(variant)
	case :zero{
		result = 0;
	}case :one{
		rezult = 1;
	}
}




