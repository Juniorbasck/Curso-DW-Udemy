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
            //reciperação da data atual  / data corrente
            echo date('d/m/Y H:i');
            echo '<br />';
            echo date_default_timezone_get();

            //date_default_timezone_set('America/Sao_Paulo');
            */
            
            $data_inicial = '2018-04-24'; //padrão de data americano sempre
            $data_final = '2018-05-15s';


            //timestamp
            //01/01/1970

            $time_inicial = strtotime($data_inicial);
            $time_final = strtotime($data_final);

            echo $data_inicial . ' - ' . $time_inicial;
            echo '<br />'; 
            echo $data_final . ' - ' . $time_final;
            

            $diferenca = $time_final - $time_inicial;

            echo '<br />';

            echo 'a diferença é ' . $diferenca;

            $segundos_existem_dia = 24 * 60 * 60;

            echo '<br />';
            echo 'uma dia possui ' . $segundos_existem_dia . ' Segundos';

            $resultado = $diferenca / $segundos_existem_dia;

            echo '<br />';
            echo 'A diferença em dias é: ' . $resultado; 
        ?>


	</body>
</html>