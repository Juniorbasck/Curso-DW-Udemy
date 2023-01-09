

var altura = 0
var largura = 0

function ajustaTamanho(){

	altura = window.innerHeight 
	largura = window.innerWidth 

	console.log(largura, altura);
}

ajustaTamanho()

function posicaoRandomica(){

	var posicaoX = Math.floor(Math.random() * largura)
	var posicaoY = Math.floor(Math.random() * altura)

	console.log(posicaoX, posicaoY) 


	//criar o elementos html a imagem
	var mosquito = document.createElement('img')

	mosquito.scr = 'imagens/coracao_cheio.png'	

	mosquito.className = 'mosquito1'

	document.body.appendChild(mosquito)

}
