<?php

    //modelo 
    class Funcinario{

        //atributos
        public $nome = null; 
        public $telefone = null;
        public $numFilhos = null; 

        //getters setters (overloading / sobrecarga)
        function setNome($nome){
            $this->nome = $nome;
        }

        function setNumFilhos($numFilhos){
            $this->numFilhos = $numFilhos;
        }

        function getNome(){
            return $this->nome;
        }

        function getNumFilhos(){
            return $this->numFilhos;
        }

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
    $y->setNome('José');
    $y->setNumFilhos(2);
    //echo $y->resumirCadFunc();
    echo $y->getNome() ." possui " . $y->getNumFilhos() . " filhos(s)";

    echo '<br/>';
    $x = new Funcinario();
    $x->setNome('Maria');
    $x->setNumFilhos(0);
    echo $x->getNome() ." possui " . $x->getNumFilhos() . " filhos(s)";
?>  