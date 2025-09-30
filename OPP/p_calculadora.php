<?php
require_once "Calculadora.php";

$form = $_POST['Formulario'];
$calc = new Calculadora();

if ($form == "soma"){
    $calc->soma($_POST['numero1'],$_POST['numero2']);
    $calc->mostrarResultado();
}else if ($form == "sub"){
    $calc->sub($_POST['numero1'],$_POST['numero2']);
    $calc->mostrarResultado();
}else if ($form == "mult"){
    $calc->mult($_POST['numero1'],$_POST['numero2']);
    $calc->mostrarResultado();
}else if ($form == "div"){
    $calc->div($_POST['numero1'],$_POST['numero2']);
    $calc->mostrarResultado();
}

?>
