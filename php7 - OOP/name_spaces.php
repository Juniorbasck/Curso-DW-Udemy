<?php 

    namespace A; // Criando um namespace
    class Cliente implements CadastroInterFace{
        public $nome = "Jorge";

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

    namespace B ; // Criando um namespace
    class Cliente implements CadastroInterFace{
        public $nome = "Jorge";

        public function __construct()
        {
            echo "<pre>";       
            print_r(get_class_methods($this));
            echo "</pre>";      
        }

        public function __get($attr){
       
            return $this->$attr;
        }

        public function remover(){
            echo "Remover";
        }
    }

    interface CadastroInterFace{
        public function remover();
    }

    $c = new \B\Cliente();
    print_r($c);
    echo $c->__get('nome'); 

?>