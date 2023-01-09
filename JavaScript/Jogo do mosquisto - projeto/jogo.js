

var altura = 0
var largura = 0

function ajustaTamanho(){

	altura = window.innerHeight 
	largura = window.innerWidth 

	console.log(largura, altura)
}	 

ajustaTamanho()

function posicaoMosquisto(){

	var posicaoX = Math.floor(Math.random() * largura)
	var posicaoY = Math.floor(Math.random() * altura)

	console.log(posicaoX, posicaoY);

	//criar o elemento HTML 
	var mosquito = document.createElement('img')
	mosquito.src = "imagens/mosca.png"
	mosquito.className = 'mosquisto1'
	

	document.body.appendChild(mosquito)

}
 