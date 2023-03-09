<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<meta name="viewport" content="width=device-width, initial-scale=1">
		<title>Hello word php</title>

	</head>
	<body>
    
        
        <?php
           
            /*
           //verificar se a veriavel passada é um array
            $array = 'String';
            $retorno = is_array($array);

            if($retorno){
                echo 'é array';

            }else{
                echo 'Não é array';
            }
            */
            
            /*
            $array = [1 => 'a', 7 => 'b', 18 => 'c'];

            echo '<pre>';
                print_r($array);
            echo '</pre>';

            $chaves_array = array_keys($array);
            echo '<pre>';
                print_r($chaves_array);
            echo '</pre>';
            */
            
            /*
            //ordena o array de strings
            $array = ['mouse', 'cabo hdmi', 'gabinete', 'fonte atx', 'notebook', 'teclodo'];
            echo '<pre>';
            print_r($array);
            echo '</pre>';

            echo sort($array);
            echo '<pre>';
            print_r($array);
            echo '</pre>';
            */

            /*
            //o asort  faz a mesma coisa que o sort só que ele preserva o indice do array
            $array = ['mouse', 'cabo hdmi', 'gabinete', 'fonte atx', 'notebook', 'teclodo'];
            echo '<pre>';
            print_r($array);
            echo '</pre>';

            echo asort($array);
            echo '<pre>';
             print_r($array);
            echo '</pre>';
            */
            
            /*
            //conta o numero de elementos dentro do aray
            $array = ['mouse', 'cabo hdmi', 'gabinete', 'fonte atx', 'notebook', 'teclodo'];
            echo '<pre>';
               print_r($array);
               echo count($array);
            echo '</pre>';
            */

            /*
            //junta arrays 
            $array1 = ['oxs','windows'];
            $array2 = array('linux');
            $array3 = ['solaris'];


            $novo_array = array_merge($array1, $array2, $array3);

            echo '<pre>';
               print_r($novo_array);
            echo '</pre>';
            */
            
            /*
            //separa um string com base em uma paremetro e ela vira um array
            $string = '26/04/2018';
            $array_retorno = explode('/', $string);
            echo '<pre>';
               print_r($array_retorno);
            echo '</pre>';
            */

            $array = ['a', 'b', 'x', 'y'];

            $retorno = implode(',', $array);
            echo $retorno;

        ?>



	</body>
</html>