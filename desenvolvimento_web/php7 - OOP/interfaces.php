<?php 

    interface  EquipamentoEletronicoInterface {

        public function ligar();
        public function desligar(); 
    }

    class geladeira implements EquipamentoEletronicoInterface{

        public function abrirPorta(){
            echo 'Abrir a porta';
        }
         public function ligar(){
            echo 'Ligar';
         }

        public function desligar(){
            echo 'Desligar';
        }
    }
    
    class TV implements EquipamentoEletronicoInterface{

        public function trocarCanal(){
            echo 'Trocar canal';
        }

        public function ligar(){
            echo 'Ligar';
         }

         public function desligar(){
            echo 'Desligar';
         }
    }

    $x = new geladeira();
    $y = new TV();

    //--------------------------------------------------------------------------------

    interface MamiferoInterface{

        public function respirar();
    }

    interface TerrestreInterface{

        public function andar();
    }

    interface AquaticoInterface{

        public function nadar();
    }

    class Humano implements MamiferoInterface, TerrestreInterface{

        public function andar(){
            echo 'Andar';
        }

        public function respirar(){
            echo 'Respirar';
        }

        public function conversar(){
            echo 'Conversar';
        }
    }

    class Baleia implements MamiferoInterface, AquaticoInterface{

        public function nadar(){
            echo 'Nadar';
        }

        public function respirar(){
            echo 'Respirar';
        }

        public function esguichar(){
            echo 'Esguichar';
        }
    }

    //--------------------------------------------------------------------------------


    interface AnimalInterface{

        public function comer();
    }

    interface AveInterface extends AnimalInterface{

        public function voar();
    }

    class Papagaio implements AveInterface{

        public function voar(){
            echo 'Voar';
        }

        public function comer(){
            echo 'Comer';
        }
    }
?>