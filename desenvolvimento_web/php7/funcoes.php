<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<meta name="viewport" content="width=device-width, initial-scale=1">
		<title>Hello word php</title>

	</head>
	<body>
    
        
        <?php
            
            //void (sem retorno)
            function exibirBoasVindas(){
                echo 'Bem vindo ao curso de PHP';
            }

            exibirBoasVindas();

            //return (com retorno)

            function calcularAreaTerreno($largura, $comprimento){
                
                $area  = $largura * $comprimento; 

                return $area;

            }

            echo '<br />';
            echo calcularAreaTerreno(5, 25);

            //you can also do...

            $resultado = calcularAreaTerreno(5, 25);

            
        ?>
        

	</body>
</html>