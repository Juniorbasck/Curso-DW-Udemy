<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<meta name="viewport" content="width=device-width, initial-scale=1">
		<title>Hello word php</title>

	</head>
	<body>
    


        
        <?php
           
           //in_array() - true ou false para existem do que está sendo procurado
           //array_search() -> retorna o indice do valor pesquisado, caso ele exista

           $listas_frutas = ['Banana','Maça', 'Morango', 'Uva'];
        /*
           
           /*
           //$existe = in_array('Maça', $listas_frutas);

           //true -> texto = 1
           //false -> texto = vazio

           $existe = array_search('Uva', $listas_frutas);
            //null


        
           if($existe != null){

            echo 'Sim, o valor pesquisa existe no array';

           }else{

            echo 'Não, o valor pesquisa não existe no array';

           }
         */
        
        $listas_coisas = [
            'Frutas' => $listas_frutas,
            'Pessoas' => ['João', 'maria'], 
        ];

        echo '<pre>';
        print_r($listas_coisas);
        echo '</pre>';
        

        in_array('Uva', $listas_coisas['Frutas']);

        ?>          



	</body>
</html>