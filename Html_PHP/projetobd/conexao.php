<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title></title>
</head>
<body>

	<?php

	//Conexão com o banco usando PDO
	
	$dsn = 'mysql:host=localhost;dbname=bdetec;charset=utf8';
	$user = 'root';
	$password = '';
	
	try{
		$pdo = new PDO($dsn, $user, $password);
	}catch (PDOException $e){
		echo 'Erro ma conexão com o banco de dados'.$e->getMessage();
		exit();
	}

	?>


</body>
</html>