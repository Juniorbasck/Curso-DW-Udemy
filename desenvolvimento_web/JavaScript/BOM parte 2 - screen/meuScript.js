var largura = window.screen.availWidth
var altura = window.screen.availHeight

//document.write('Altura do navegador é: ' + altura + ' e a altura' + largura)

if(largura < 500){
	document.write('mobile')
}else{
	document.write('web')
}