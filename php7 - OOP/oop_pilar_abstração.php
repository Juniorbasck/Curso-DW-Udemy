<?php

    //modelo 
    class Funcinario{

        //atributos
        public $nome = 'José'; 
        public $telefone = '11 9999-999';
        public $numFilhos = 2; 


        //métodos
        function resumirCadFunc(){
            return "$this->nome possui $this->numFilhos filhos(s)";
        }

        function modificarNumFilhos($numFilhos){
            //afetar um atributo do objeto
            $this->numFilhos = $numFilhos;
        }
    }

    $y = new Funcinario(); 
    echo $y->resumirCadFunc();
    echo "<br />";
    $y->modificarNumFilhos(8);
    echo $y->resumirCadFunc();
    echo "<hr />";

    $x = new Funcinario();
    echo $x->resumirCadFunc();
?>  