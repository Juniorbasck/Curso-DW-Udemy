var video = Array()

video[1] = Array()
video['Nome'] = 'Fullmetal Alchemist'
video['Categoria'] = 'Anime'

function getVideo(video){
	//Lógica 
	//http //requições http

	try{
		//Lógica 
		//http //requições http
		console.log(video[0]['nome'])
	}catch(e){
		console.log(e)
		console.log('agora iremos tratar o erro')
		throw new Error('Houve um erro mas não se preucupe, estamos trabalhando nisso agora!!')

	} finally{
		console.log('sempre passa por aqui (try / catch) ')
	}



	console.log('A aplicação não morreu')
}

function trataErro(e){
	//Lógica para regitrar o erro no servidor 
	console.log(e)
}


getVideo(video)