<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<meta name="viewport" content="width=device-width, initial-scale=1">
		<title>Hello word php</title>

	</head>
	<body>
    
        
        <?php
            /*
            //sequencias (numericos)
            //$lista_frutas = array('Banana', 'Maça', 'Morango', 'Uva');
            $lista_frutas = ['Banana', 'Maça', 'Morango', 'Uva'];
            $lista_frutas[] = 'Abacaxi';


            
            echo '<pre>';
                var_dump($lista_frutas);
            echo '<pre>';
            echo '<hr />';
            echo '<pre>';
                 print_r($lista_frutas);
            echo '<pre>';
           

            echo $lista_frutas[4];
             */

            //associativos 

            $lista_frutas = array(
                'a' => 'Banana',
                'b' => 'Maça',
                'c' => 'Morango', 
                '2' => 'Uva');
            
            echo '<pre>';
            var_dump($lista_frutas);
            echo '<pre>';

            echo $lista_frutas['2'];
        ?>



	</body>
</html>