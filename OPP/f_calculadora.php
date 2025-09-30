<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Calculadora OPP</title>
</head>
<body>

    <form action="p_calculadora.php" method="post">
        <pre>
        <label for ="">Digite um numero</label>
        <input type = "text" name="numero1" id="">
        <label for = "" >Digite um numero</label>
        <input type = "text" name="numero2" id="">
        <select name="Formulario" id="" class="option">
            <option value="soma">soma</option>
            <option value="sub">sub</option>
            <option value="div">div</option>
            <option value="mult">mult</option>
        </select>
        <button type = "submit" > Enviar</button><button type = "reset" > Tentar novamente</button>
        
        
</form>

    
</body>
</html>