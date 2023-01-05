// listaConvidados = ['Jorge', 'Jamilton', 'José', 'Ana', 'Maria']


var listaConvidados = Array()

listaConvidados['a'] = 'Jorge'
listaConvidados[10] = 'jamilton'
listaConvidados['zebra'] = 'José'
listaConvidados[-1] = 'Ana'
listaConvidados[true] = 'Maria'



console.log(listaConvidados)

for( var x in listaConvidados){
	console.log('indice ' + x + ' Valor ' + listaConvidados[x])
}