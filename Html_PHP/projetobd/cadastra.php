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

	//Recebendo valores do formulario

	if ($_SERVER['REQUEST_METHOD']==='POST') {
		$nome = $_POST['nome'];
		$sobrenome = $_POST['sobrenome'];
		$idade = $_POST['idade'];
		$sexo = $_POST['sexo'];

	//Inserir dados no banco
		$stmt = $pdo->prepare("INSERT INTO usuario(nome, sobrenome, idade, sexo) VALUES (:nome, :sobrenome, :idade, :sexo)");
		$stmt->bindParam(':nome', $nome);
		$stmt->bindParam(':sobrenome', $sobrenome);
		$stmt->bindParam(':idade', $idade);
		$stmt->bindParam(':sexo', $sexo);

		if ($stmt->execute()) {
			echo "Dados inseridos com sucesso!";
		}else{
			echo "Erro ao inserir dados no banco!";
		}
	}

?>

</body>
</html>