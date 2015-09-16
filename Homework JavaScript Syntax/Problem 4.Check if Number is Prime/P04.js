function isPrime(value){
	for(var i=2; i<= Math.sqrt(value); i++){
	if(value%i == 0){
	console.log(false);
	}			
	}
	console.log(true);
	
}

isPrime(7);
isPrime(254);
isPrime(587);
