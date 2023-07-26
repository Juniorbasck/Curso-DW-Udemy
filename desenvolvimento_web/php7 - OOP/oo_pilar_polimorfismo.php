<?php   


    class Veiculo{
        public $placa = null;
        public $cor = null;

        function freiar(){
            echo 'Freiar';
        }

        function acelerar(){
            echo 'Acelarar';
        }

        function trocarMarcha(){
            echo 'Desengatar embreagem com o pé e engatar marcha com a mão';
        }
    }

    class Carro extends Veiculo{

        public $teto_solar = true;  
        
        function __construct($placa, $cor){
            $this->placa = $placa;
            $this->cor = $cor;
        }

        function abrirTetoSolar(){
            echo 'Abrir teto solar';
        }

        function alterarPosicaoVolante(){
            echo 'Alterar posição volante';
        }

    }

    class Moto extends Veiculo{
        public $contraPesoGuidao = true;

        function __construct($placa, $cor){
            $this->placa = $placa;
            $this->cor = $cor;
        }

        function empinar(){
            echo 'Empinar';
        }

        function trocarMarcha(){
            echo 'Desengatar embreagem com a mão e engatar a marcha com o pé';
        }
    
    }   

    $carro = new Carro('ABC1234', 'Branco');
    $moto = new Moto('DEF1234', 'Preto');

    $carro->trocarMarcha();
    echo '<br />';
    echo '<hr />';
    $moto->trocarMarcha();



?>