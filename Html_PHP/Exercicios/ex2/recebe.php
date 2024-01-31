<!DOCTYPE html>
<html>
<head>
	<title></title>
</head>
<body>

<?php

	$peso = $_GET['peso'];
	$altura = $_GET['altura'];

	$imc = $peso / ($altura * $altura);

	if ($imc <= 18.5) {
		echo "IMC: $imc <br>
			  Condição: Abaixo do peso";
	}
	else if ($imc <= 24.9 ) {
		echo "IMC: $imc <br>
			  Condição: Peso ideal";
	}
	else if ($imc <= 29.9 ) {
		echo "IMC: $imc <br>
			  Condição: Levemente acima do peso";
	}
	else if ($imc <= 34.9 ) {
		echo "IMC: $imc <br>
			  Condição: Obesidade grau I";
	}
	else if ($imc <= 39.9 ) {
		echo "IMC: $imc <br>
			  Condição: Obesidade grau II";
	}
	else {
		echo "IMC: $imc <br>
			  Condição: Obesidade grau III";
	}
?>

</body>
</html>