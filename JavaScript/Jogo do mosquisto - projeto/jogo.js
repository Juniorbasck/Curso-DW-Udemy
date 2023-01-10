

var altura = 0
var largura = 0
var vidas = 1


function ajustaTamanho(){

	altura = window.innerHeight 
	largura = window.innerWidth 

	console.log(largura, altura)
}	 

ajustaTamanho()

function posicaoMosquisto(){

	//remover o mosquisto anterior (caso exista)
	if(document.getElementById('mosquito')){
		document.getElementById('mosquito').remove()

		//console.log('elemento selecionado foi: v' + vidas)
		if(vidas > 3){

			alert("interromper o jogo (game over)")
		}else{
		document.getElementById('v' + vidas).src = 'imagens/coracao_vazio.png'

			vidas++
		}
	}

	var posicaoX = Math.floor(Math.random() * largura) - 90
	var posicaoY = Math.floor(Math.random() * altura) - 90 

	posicaoX = posicaoX < 0 ? 0 : posicaoX
	posicaoY = posicaoY < 0 ? 0 : posicaoY

	console.log(posicaoX, posicaoY);

	//criar o elemento HTML 
	var mosquito = document.createElement('img')
	mosquito.src = "imagens/mosca.png"
	mosquito.className = tamanhoAleatorio() + ' ' + ladoAleatorio()
	mosquito.style.left = posicaoX + 'px'
	mosquito.style.top = posicaoY + 'px'
	mosquito.style.position = 'absolute'
	mosquito.id = 'mosquito' 
	mosquito.onclick = function(){
		this.remove()

	}

	document.body.appendChild(mosquito)

	console.log(tamanhoAleatorio())

	console.log(ladoAleatorio())
}
 

function tamanhoAleatorio(){
	var classe = Math.floor(Math.random() * 3)
	
	switch(classe){

		case 0:  
			return 'mosquisto1'
		case 1: 
			return 'mosquisto2'
		case 2: 
			return 'mosquisto3'
	}
}

function ladoAleatorio(){
	 var classe = Math.floor(Math.random() * 2)
	
	switch(classe){
		case 0:  
			return 'ladoA'
		case 1: 
			return 'ladoB'
	}
}
