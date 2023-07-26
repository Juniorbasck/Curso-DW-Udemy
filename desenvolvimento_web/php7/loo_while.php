<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<meta name="viewport" content="width=device-width, initial-scale=1">
		<title>Hello word php</title>

	</head>
	<body>
    
        
        <?php

			$num = 1;
			//operadores comparação / lógicos
			echo '-- inicio loop -- <br />';
			while($num < 10){
				
				$num ++;

				if($num == 2 || $num == 6){
					continue;
				}

				echo $num . '<br />';

				/*
				if($num > 100){
					break;
				}
				*/
			}
			echo '-- fim do loop -- ';
		
			?>
	</body>

</html>