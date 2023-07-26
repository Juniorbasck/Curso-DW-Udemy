<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<meta name="viewport" content="width=device-width, initial-scale=1">
		<title>Hello word php</title>

	</head>
	<body>
    
        <?php

            $nome = 'junior'; 
            $cor = 'verde';
            $idade = 18;
            $hooby = 'jogar basquete';

            //operador . para concatenar

          echo 'opa ' .$nome . ', vi que sua cor favorita é ' . $cor . ', e que tem ' . $idade . ' anos e ' . $hooby;

          echo '<hr/>';
          //outro mo

          echo "ola  meu nome é $nome"
        ?>

	</body>
</html>