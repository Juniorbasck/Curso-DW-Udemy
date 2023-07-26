<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<meta name="viewport" content="width=device-width, initial-scale=1">
		<title>Hello word php</title>

	</head>
	<body>
    
        
        <?php
           

           //false (true/false) - tipo boolean
           //null e empty valores especiais

           $funcionario1 = null;
           $funcionario2 = '';


           //valores null
           /*
            if(is_null($funcionario1)){
                echo 'sim, é null';
            }else{
                echo 'Não, não é null';
            }
            */
            

            if(empty($funcionario1)){
                echo 'sim, é está vazia';
            }else{
                echo 'Não, não é vazia';
            }

            echo  '<br /> ';
            
            if(empty($funcionario2)){
                echo 'sim, é vazio';
            }else{
                echo 'Não, não é vazio';
            }

            
        ?>



	</body>
</html>