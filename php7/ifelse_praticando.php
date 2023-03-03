<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<meta name="viewport" content="width=device-width, initial-scale=1">
		<title>Hello word php</title>

	</head>
	<body>
    
        
        <?php
           
            $usarioCartao = true;
            $valorCompra = 250;

            $valor_frete = 50; 

            $recebeu_desconto = true;

            if($usarioCartao == true && $valorCompra >= 400){
                $valor_frete = 0;
              
            } else if($usarioCartao == true && $valorCompra >= 300){
                $valor_frete = 10;
                
            } else if($usarioCartao == true && $valorCompra >= 100){
                $valor_frete = 25;
               
            }else{
                $recebeu_desconto = false;
            }
        ?>

            <h1>Detalhemento do pedido</h1>

            <p>Possui cartão da loja
                <?php
                    if($usarioCartao == true){
                        echo 'SIM';
                    }else{
                        echo 'NÃO';
                    }
                ?>
            </p>
            
            
            <h1>Recebeu Desconto do frete?</h1>

            <p>Possui cartão da loja
                <?php
                    if($recebeu_desconto == true){
                        echo 'SIM';
                    }else{
                        echo 'NÃO';
                    }
                ?>
            </p>

            <hr>

            <p>Valor do frete: <?= $valor_frete ?></p>
	</body>     
</html>