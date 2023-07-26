<?php
    class Pessoa{
        
        public $nome = null;

        function __construct($nome){
            echo 'Objeto iniciado';
            $this->nome = $nome;
        }
        function __destruct(){
            echo 'Objeto removido';
        }
        function  __get($atributo){
            return $this->$atributo;
        }
        function Correr(){
            return $this->__get('nome') . ' está correndo';
        }
    }   

    $pessoa = new Pessoa('Junior');
    echo '<br />Nome: ' . $pessoa->__get('nome');
    echo '<br />' . $pessoa->Correr();

    echo '<br />';
    // unset($pessoa);
    
?>