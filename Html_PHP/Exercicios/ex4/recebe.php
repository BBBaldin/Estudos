<!DOCTYPE html>
<html>
<head>
	<title></title>
</head>
<body>

	<?php

	$user = $_GET['opcao'];

	$sorteio =rand(0,2);
	switch ($sorteio) {
		case '1':
			$pc = 'cara';
			break;
		default:
			$pc = 'coroa';
			break;
	}

	
	if ($user == "cara" && $pc == "cara") {
		echo "$pc";
		echo "<br>Você ganhou!!!";
	}
	else if ($user == "cara" && $pc == "coroa") {
		echo "$pc";
		echo "<br>Você errou!!!";
	}
	else if ($user == "coroa" && $pc == "coroa") {
		echo "$pc";
		echo "<br>Você ganhou!!!";
	}
	else if ($user == "coroa" && $pc == "cara") {
		echo "$pc";
		echo "<br>Você errou!!! ";
	}


	?>

</body>
</html>