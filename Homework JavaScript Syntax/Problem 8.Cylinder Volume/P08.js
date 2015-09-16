function calcCylinderVol(value) {//volume = Math.PI*r*r*height
	return(arguments[0]*arguments[0]*arguments[1]*Math.PI).toFixed(3);
}
console.log(calcCylinderVol(2,4));
console.log(calcCylinderVol(5,8));
console.log(calcCylinderVol(12,3));