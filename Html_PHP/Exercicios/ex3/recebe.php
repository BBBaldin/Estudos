<!DOCTYPE html>
<html>
<head>
	<title></title>
</head>
<body>

	<?php

	$user = $_GET['opcao'];

	$sorteio =rand(0,3);
	switch ($sorteio) {
		case '1':
			$pc = 'pedra';
			break;
		case '2':
			$pc = 'papel';
			break;
		
		default:
			$pc = 'tesoura';
			break;
	}

	if ($user == "pedra" && $pc == "papel") {
		echo "Resultado <br>
		  Escolha do jogador: $user <br>
		  Escolha do computador: $pc <br>
		  Vitória para: Computador";
	}
	else if ($user == "papel" && $pc == "tesoura") {
		echo "Resultado <br>
		  Escolha do jogador: $user <br>
		  Escolha do computador: $pc <br>
		  Vitória para: Computador";
	}
	else if ($user == "tesoura" && $pc == "pedra") {
		echo "Resultado <br>
		  Escolha do jogador: $user <br>
		  Escolha do computador: $pc <br>
		  Vitória para: Computador";
	}
	else if ($user == "pedra" && $pc == "tesoura") {
		echo "Resultado <br>
		  Escolha do jogador: $user <br>
		  Escolha do computador: $pc <br>
		  Vitória para: jogador";
	}
	else if ($user == "papel" && $pc == "pedra") {
		echo "Resultado <br>
		  Escolha do jogador: $user <br>
		  Escolha do computador: $pc <br>
		  Vitória para: jogador";
	}
	else if ($user == "tesoura" && $pc == "papel") {
		echo "Resultado <br>
		  Escolha do jogador: $user <br>
		  Escolha do computador: $pc <br>
		  Vitória para: jogador";
	}
	else if ($user == "pedra" && $pc == "pedra") {
		echo "Resultado <br>
		  Escolha do jogador: $user <br>
		  Escolha do computador: $pc <br>
		  EMPATE";
	}
	else if ($user == "papel" && $pc == "papel") {
		echo "Resultado <br>
		  Escolha do jogador: $user <br>
		  Escolha do computador: $pc <br>
		  EMPATE";
	}
	else if ($user == "tesoura" && $pc == "tesoura") {
		echo "Resultado <br>
		  Escolha do jogador: $user <br>
		  Escolha do computador: $pc <br>
		  EMPATE";
	}

	
	?>

</body>
</html>