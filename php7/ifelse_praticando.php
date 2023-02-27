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
            $valorCompra = 200;

            $valor_frete = 50; 

            $recebeu_desconto = false;

            if($usarioCartao == true && $valorCompra >= 100){
                $valor_frete = 0;
                $recebeu_desconto = true;
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