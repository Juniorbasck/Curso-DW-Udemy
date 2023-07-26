<?php

    //modelo
    class Funcinario{

        //atributos
        public $nome = null;
        public $telefone = null;
        public $numFilhos = null;
        public $cargo = null;
        public $salario = null;

        //getters setters (overloading / sobrecarga)
        function __set($atributo, $valor){
            $this->$atributo = $valor;
        }

        function __get($atributo){
            return $this->$atributo;
        }



        // function setNome($nome){
        //     $this->nome = $nome;
        // }

        // function setNumFilhos($numFilhos){
        //     $this->numFilhos = $numFilhos;
        // }

        // function getNome(){
        //     return $this->nome;
        // }

        // function getNumFilhos(){
        //     return $this->numFilhos;
        // }

        //métodos
        function resumirCadFunc(){
            return $this->__get('nome') . " possui " . $this->__get('numFilhos') . " filhos(s)";
        }

        function modificarNumFilhos($numFilhos){
            //afetar um atributo do objeto
            $this->numFilhos = $numFilhos;
        }
    }

    $y = new Funcinario();
    $y->__set('nome', 'José');
    $y->__set('numFilhos', '2');
    echo $y->resumirCadFunc();
    // $y->__set('cargo', 'Desenvolvedor');
    // $y->__set('telefone', '11 99999-9999');
    // $y->__set('salario', '5.800,00');

    // echo 'O nome do funcionario é: ' . $y->__get('nome') ." possui " . $y->__get('numFilhos') . " filhos(s)";
    // echo '<br/>';
    // echo 'tem um cargo de ' . $y->__get('cargo') . ' e recebe um salário de ' . $y->__get('salario');
    // echo '<br/>';
    // echo 'Seu telefone é: ' . $y->__get('telefone');

    echo '<hr/>';

    echo '<br/>';
    $x = new Funcinario();
    $x->__set('nome', 'Maria');
    $x->__set('numFilhos', 0);
    echo $x->__get('nome') . " possui " . $x->__get('numFilhos') . " filhos(s)";
?>