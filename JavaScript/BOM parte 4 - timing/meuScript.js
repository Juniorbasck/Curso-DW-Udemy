//setTimeout(function() {document.write('teste')}, 2000)

var i = 5

setInterval(function(){
	document.write(i)
	i = i - 1

	if(i === 0){
		window.location.reload()
	}
	}, 1000)