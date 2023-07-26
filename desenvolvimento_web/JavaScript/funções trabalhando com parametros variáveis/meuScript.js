function soma(){

	var resultado = 0 
	for(var i in arguments){

		resultado += arguments[i];

	}

	return resultado;

	console.log(arguments)
}

console.log(soma(7, 5, 2.2, 0.8))