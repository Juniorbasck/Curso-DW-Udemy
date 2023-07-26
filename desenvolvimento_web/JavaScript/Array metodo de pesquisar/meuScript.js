var lista_frutas = Array()

lista_frutas[0] = 'Banana'
lista_frutas[1] = 'Maça'
lista_frutas[2] = 'Morango'
lista_frutas[3] = 'Uva'

var auxilar = lista_frutas.indexOf('Banana')

if(auxilar === -1){
	console.log('elemento não existe')
}else{
	console.log('elemento existe e está na posição ' + auxilar)
}