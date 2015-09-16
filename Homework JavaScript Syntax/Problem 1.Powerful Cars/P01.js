function convertKWtoHP(KW) {		//P(KW) = 0.745699872 · P(HP)
	var HP = KW/0.746;				//P(HP) = P(KW)/0.745699872
	return HP.toFixed(2);
									
} 
console.log(convertKWtoHP(75));
console.log(convertKWtoHP(150));
console.log(convertKWtoHP(1000));
