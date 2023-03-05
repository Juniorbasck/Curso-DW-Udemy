<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<meta name="viewport" content="width=device-width, initial-scale=1">
		<title>Hello word php</title>

	</head>
	<body>
    
        
        <?php

            $texto = 'Curso Completo de PHP';

            //string to lower

            echo $texto;
            echo '<br />';
            echo strtolower($texto);

            echo '<hr/>';
            //string to upper
            echo $texto . '<br />';
            echo strtoupper($texto);

            echo '<hr/>';
            //upper case first
            echo $texto . '<br />';
            echo ucfirst($texto);

            echo '<hr/>';
            //tamanho da string
            echo $texto . '<br />';
            echo strlen($texto);

            echo '<hr/>';
            //tamanho da string
            echo $texto . '<br />';
            echo str_replace('PHP', 'JavaScript', $texto);

            echo '<hr/>';
            //tamanho da string
            echo $texto . '<br />';
            echo substr($texto, 1, 4);

        ?>



	</body>
</html>