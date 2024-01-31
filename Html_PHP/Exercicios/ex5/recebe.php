<!DOCTYPE html>
<html>
<head>
	<title></title>
</head>
<body>

<?php
	$placa = $_GET['placa'];
	
	if ($placa >= 1 && $placa <= 2) {
		echo "Mês Limite para pagar o licenciamento: Julho<br>
			  Dia do rodízio SP: Segunda-feira<br>";
		if ($placa == 1) {
			echo"Calendário IPVA: Cota Única ou 1°parcela: 26/jan 2°parcela: 25/fev 3°parcela: 29/mar<br>";
		}
		else{
			echo"Calendário IPVA: Cota Única ou 1°parcela: 25/jan 2°parcela: 24/fev 3°parcela: 28/mar<br>";
		}
	}
	else if ($placa >= 3 && $placa <= 4) {
		echo "Mês Limite para pagar o licenciamento: Agosto<br>
			  Dia do rodízio SP: Terça-feira<br>";
		if ($placa == 3) {
			echo"Calendário IPVA: Cota Única ou 1°parcela: 24/jan 2°parcela: 23/fev 3°parcela: 25/mar<br>";
		}
		else{
			echo"Calendário IPVA: Cota Única ou 1°parcela: 27/jan 2°parcela: 03/mar 3°parcela: 04/abr<br>";	  
	}}
	else if ($placa >= 5 && $placa <= 6) {
		echo "Mês Limite para pagar o licenciamento: Setembro<br>
			  Dia do rodízio SP: Quarta-feira<br>";
		if ($placa == 5) {
			echo"Calendário IPVA: Cota Única ou 1°parcela: 28/jan 2°parcela: 04/mar 3°parcela: 05/abr<br>";
		}
		else{
			echo"Calendário IPVA: Cota Única ou 1°parcela: 31/jan 2°parcela: 07/mar 3°parcela: 06/abr<br>";	
	}}
	else if ($placa >= 7 && $placa <= 8) {
		echo "Mês Limite para pagar o licenciamento: Outubro<br>
			  Dia do rodízio SP: Quinta-feira<br>";
		if ($placa == 7) {
			echo"Calendário IPVA: Cota Única ou 1°parcela: 01/fev 2°parcela: 08/mar 3°parcela: 07/abr<br>";
		}
		else{
			echo"Calendário IPVA: Cota Única ou 1°parcela: 02/fev 2°parcela: 09/mar 3°parcela: 08/abr<br>";	
	}}
	else if ($placa <= 9 && $placa >= 0) {
		echo "Dia do rodízio SP: Sexta-feira<br>";
	if ($placa == 9) {
		echo"Calendário IPVA: Cota Única ou 1°parcela: 03/fev 2°parcela: 10/mar 3°parcela: 11/abr<br>
			Mês Limite para pagar o licenciamento: Novembro";
	}
	else{
			echo "Calendário IPVA: Cota Única ou 1°parcela: 03/fev 2°parcela: 10/mar 3°parcela: 11/abr<br>
				Mês Limite para pagar o licenciamento: Dezembro";	
	}}
?>

</body>
</html>