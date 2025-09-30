<?php 
    CLASS Calculadora {
        public $numero1;
        public $numero2;
        public $resultado;

        public function mostrarResultado(){
            echo "<br>Resultado:.$this->resultado<br>";
            return $this->resultado;
        }
        public function soma($n1,$n2){
            $this->resultado = $n1+$n2;
        }
        public function sub($n1,$n2){
            $this->resultado = $n1-$n2;
        }
        public function mult($n1,$n2){
            $this->resultado = $n1*$n2;
        }
        public function div($n1,$n2){
            $this->resultado = $n1/$n2;
        }
    }
    ?>