<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<meta name="viewport" content="width=device-width, initial-scale=1">
		<title>Hello word php</title>

	</head>
	<body>
        <?php

            define('BD_URL', 'endereco_bd_dev');
            define('BD_USUARIO', 'usuario_dev');
            define('SENHA', 'senha_dev');
        

            echo BD_URL . '<br />';
            echo BD_USUARIO . '<br />';
            echo SENHA . '<br />';
            
        ?>
	</body>

</html>