var objetos = Array(); 

objetos[0] = 'Cadeira'
objetos[1] = 'Impressora'
objetos[2] = 'Garfo'



function adicionarDados(){
 
 	var aux = document.getElementById('nome').value

 	//var valor = objetos.indexOf(aux);

 	if(aux != ''){
 	
 		if(objetos.indexOf(aux) !== -1){

 			alert("Objeto já add")

 		}else{

 			objetos.push(aux)
 			console.log(objetos)

 			document.getElementById('nome').value = '';
 		}

 	}else{

 	alert("Insira algo parça");

 	}
}


function ordenarDados(){

	console.log(objetos.sort())
}



