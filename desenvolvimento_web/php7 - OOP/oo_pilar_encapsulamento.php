<?php

    class Pai{
        
        private $nome = 'junior';
        protected $sobrenome = 'Inacio';
        public $humor = 'Feliz';

        // public function getNome(){
        //     return $this->nome;
        // }

        // public function setNome($value){

        //     if(strlen($value) >= 3){
        //         $this->nome = $value;
        //     }

        // }

        // public function getSobrenome(){
        //     return $this->sobrenome;
        // }

        // public function setSobrenome($value){

        //     if(strlen($value) >= 3){
        //         $this->sobrenome = $value;
        //     }

        // }

        // public function __get($attr){
        //     return $this->$attr;
        // }

        // public function __set($attr, $value)    {
        //     $this->$attr = $value;
        // }

        private function executarMania(){
            echo 'Assobiar';
        }
        
        protected function responder(){
            echo 'Oi';
        }

        public function executarAcao(){
            $x = rand(1, 10);

            if($x >=1 &&    $x <= 8){

                $this->responder();

            }else{

                $this->executarMania();
            }
        }
    }

    class Filho extends Pai{

        public function getAtributo($attr){
            return $this->$attr;
        }

        public function setAtributo($attr, $value){
            $this->$attr = $value;
        }
    }
    
    $filho = new Filho();
    echo '<pre>';
    print_r($filho);
    echo '<pre>';
    // $pai = new Pai();
    // echo $pai->executarAcao();


    //exibir os métodos do objeto
    print_r(get_class_methods($filho));

    echo $filho->__get('humor');

?>  