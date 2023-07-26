/*var lista_frutas = Array()

lista_frutas[0] = 'Maça'
lista_frutas[1] = 'Uva'
lista_frutas[2] = 'Banana'
lista_frutas[3] = 'Morango'

console.log(lista_frutas.sort())*/


var lista_numeros = Array()

lista_numeros[0] = 12	
lista_numeros[1] = 40
lista_numeros[2] = 30
lista_numeros[3] = 20
lista_numeros[4] = 3
lista_numeros[5] = 15

console.log(lista_numeros.sort(ordenaNumeros))

function ordenaNumeros(a, b){
	return a - b
}