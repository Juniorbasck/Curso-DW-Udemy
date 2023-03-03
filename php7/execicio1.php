<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<meta name="viewport" content="width=device-width, initial-scale=1">
		<title>Hello word php</title>

	</head>
	<body>
    
        
        <?php
           
           $idade = 40; 
           $peso = 70; 

           $pode_doar_sangue = false;

           if($idade >= 16 && $idade <= 69 && $peso > 50){
                $pode_doar_sangue = true;
           }

        ?>

        <h1>Verificar se pode doar sangue</h1>

        <hr>

        <h4>Pode doar? : <?= $pode_doar_sangue ? 'SIM' : 'NÃO' ?></h4>

	</body>
</html>