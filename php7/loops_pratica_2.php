<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<meta name="viewport" content="width=device-width, initial-scale=1">
		<title>Hello word php</title>

	</head>
	<body>
    
        
        <?php

            $funcion = array(
                    array('nome' => 'João', 'salario' => 2500),                        
                    array('nome' => 'Maria', 'salario' => 3000),  
                    array('nome' => 'Julia', 'salario' => 2200),  
                 );

            echo '<pre>';
            print_r($funcion);
            echo '<pre>';
            
          
            foreach($funcion as $idx => $funcion){

                foreach($funcion as $idx2 => $valor){

                    echo $idx2 . ' - ' . $valor . '<br>';
                    
                }   

                echo '<hr/>';
            }
            
        ?>



	</body>
</html>