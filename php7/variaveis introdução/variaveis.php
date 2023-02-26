<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<meta name="viewport" content="width=device-width, initial-scale=1">
		<title>Hello word php</title>

	</head>
	<body>
    
  
        <?php

            //string 
            $nome = 'jorge sant ana';

            //int

            $idade = 28;

            //float
            $peso = 85.5;

            //boolean
            $fumante_sn = true;

        ?>

        <h1>Dicha de cadastro</h1>
        <br/>
        <P>nome: <?= $nome ?></P>
        <P>idade: <?= $idade ?></P>
        <P>peso: <?= $peso ?></P>
        <P>fumante: <?= $fumante_sn ?></P>

	</body>

</html>