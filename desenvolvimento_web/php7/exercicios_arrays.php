<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<meta name="viewport" content="width=device-width, initial-scale=1">
		<title>Hello word php</title>

	</head>
	<body>
    
        
        <?php

            $numeros = array();

            while(count($numeros) <= 5){

                $num = rand(1, 60); 
                  if(!in_array($num, $numeros)){

                    $numeros[] = $num;
                    
                  }
            }

            print_r($numeros);
            
        ?>



	</body>
</html>