function mudarback(){

 	document.getElementById('valor').style.background = '#ffff00'
 	
 }

 function validarCor(){

    var valorCampo = document.getElementById('valor').value

    if(valorCampo.length < 3){
        document.getElementById('valor').style.background = "red"
    }else{

        document.getElementById('valor').style.background = 'green'
    }
 }