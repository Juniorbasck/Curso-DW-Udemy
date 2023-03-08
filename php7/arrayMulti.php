<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<meta name="viewport" content="width=device-width, initial-scale=1">
		<title>Hello word php</title>

	</head>
	<body>
    
        
        <?php
          
             $listas_coisas = [];

             $listas_coisas['Frutas'] = array(1 =>'banana', 2 => 'Maça', 3 => 'Morango', 4 => 'Uva');
             $listas_coisas['Pessoas'] = [1 =>'João', 2 =>  'José', 3 => 'Maria'];

             echo '<pre>';
             print_r($listas_coisas); 
             echo '</pre>';
        
             echo '<hr />';

             echo $listas_coisas['Frutas'][3];


        ?>  



	</body>
</html>