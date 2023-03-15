<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<meta name="viewport" content="width=device-width, initial-scale=1">
		<title>Hello word php</title>

	</head>
	<body>
    
        
        <?php
            $registros = array(
                array('Titulo' => 'Titulo noticias 1', 'conteudo' => 'Conteudo notícia 1'),
                array('Titulo' => 'Titulo noticias 2', 'conteudo' => 'Conteudo notícia 2'),
                array('Titulo' => 'Titulo noticias 3', 'conteudo' => 'Conteudo notícia 3'),
                array('Titulo' => 'Titulo noticias 4', 'conteudo' => 'Conteudo notícia 4')
            );
            echo '<pre>';
            print_r($registros);
            echo '<pre>';
            echo '<br>';
            echo '<br>';
         

            //$idx = 0;
            echo 'O array possui: ' . count($registros) . ' Registros';
            echo '<br>';

            /*
            while($idx < count($registros)){

                   echo '<h3>' . $registros[$idx]['Titulo'] . '<h3/>';
                   echo '<p>' . $registros[$idx]['conteudo'] . '<p/>';
                   echo '<hr/>';

                $idx++;
            }
           

            
            do{
                
                   echo '<h3>' . $registros[$idx]['Titulo'] . '<h3/>';
                   echo '<p>' . $registros[$idx]['conteudo'] . '<p/>';
                   echo '<hr/>';

                $idx++;
            
            }while($idx < count($registros));
             */

             for($idx = 0; $idx < count($registros); $idx++){
                   echo '<div class="card" style="width: 18rem;">
                            <img class="card-img-top" src="..." alt="Card image cap">
                            <div class="card-body">
                            <h5 class="card-title">Card title</h5>
                            <p class="card-text">Some quick example text to build on the card title and make up the bulk of the cards content.</p>
                            <a href="#" class="btn btn-primary">Go somewhere</a>
                        </div>
                        </div>';
                 
             }
        ?>



	</body>
</html>