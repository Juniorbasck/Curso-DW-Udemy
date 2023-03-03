<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<meta name="viewport" content="width=device-width, initial-scale=1">
		<title>Hello word php</title>

	</head>
	<body>
    
        
        <?php

            //gettype() => retorna o tipo da variável 

            $valor = '22.12'; 
            //$valor2 = (float) $valor;
            //$valor2 = (string) $valor;
            //$valor2 = (int) $valor; *interger* 


            $valor2 =  (int) $valor;


            echo $valor. ' ' .  gettype($valor);
            echo '<br />';
            echo $valor2. ' ' .  gettype($valor2);    

                
        ?>



	</body>
</html>