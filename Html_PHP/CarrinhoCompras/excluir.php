<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Untitled Document</title>
<link href="bootstrap/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
</head>
<?php
session_start();
//pegando o código
$codigo = $_GET['codigo'];
//excluindo a posição do vetor
unset($_SESSION['carrinho'][$codigo]);
//reorganizado o vetor
sort($_SESSION['carrinho']);
//session_destroy();
?>
<body>
<center>
<p><a href="Principal.php">Voltar para as compras</a> </p>
<p> <a href="carrinho.php">Voltar para o carrinho</a> </p>
</body>
</html>