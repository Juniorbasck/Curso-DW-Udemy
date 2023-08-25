<?php

    namespace A; // Criando um namespace
    class Cliente implements CadastroInterFace{
        public $nome = "Junior";

        public function __construct()
        {
            echo "<pre>";       
            print_r(get_class_methods($this));
            echo "</pre>";      
        }

        public function __get($attr){
       
            return $this->$attr;
        }

        public function salvar(){
            echo "Salvar";
        }
    }

    interface CadastroInterFace{
        public function salvar();
    }




?>