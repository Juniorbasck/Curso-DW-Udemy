<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<meta name="viewport" content="width=device-width, initial-scale=1">
		<title>Hello word php</title>

	</head>
	<body>
    
        
        <?php
         
            $parametro = 2;

            switch ($parametro) {
                case 1:
                    echo 'entrou no case 1';
                    break;

                case 2:
                    echo 'entrou no case 2';
                    break;
                
                case 3:
                    echo 'entrou no case 3';
                     break;
                
                default:
                    echo 'entrou no default';
                    break;
            }
          
        ?>

	</body>
</html>