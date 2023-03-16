<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<meta name="viewport" content="width=device-width, initial-scale=1">
		<title>Hello word php</title>

	</head>
	<body>
    
        
        <?php
            
            $itens = array('sofá', 'mesa', 'cadeira', 'fogão', 'geladeira');

            echo '<pre>';
            print_r($itens);
            echo '<pre>';
            

            foreach($itens as $item){
                    
                echo $item . ' ';

                if($item == 'mesa'){
                    echo '(compre uma mesa e ganhe 25% de desconto na compra de 4)';
                }

                echo '<br>';
            }
        ?>



	</body>
</html>