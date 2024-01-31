<!DOCTYPE html>
<html>
<head>
	<title></title>
</head>
<body>

<?php

	$valor = $_GET['valor'];
	$de = $_GET['de'];
	$para = $_GET['para'];

if ($de == 'real' && $para == 'dolar') {
	$convertido = $valor / 4.95;
	echo "Valor convertido: US$";
	echo number_format($convertido, 2,',','');
}
if ($de == 'real' && $para == 'euro') {
	$convertido = $valor / 5.34;
	echo "Valor convertido: €$";
	echo number_format($convertido, 2,',','');
}
if ($de == 'dolar' && $para == 'real') {
	$convertido = $valor * 4.95;
	echo "Valor convertido: RS$";
	echo number_format($convertido, 2,',','');
}
if ($de == 'dolar' && $para == 'euro') {
	$convertido = $valor / 1.08;
	echo "Valor convertido: €$";
	echo number_format($convertido, 2,',','');
}
if ($de == 'euro' && $para == 'real') {
	$convertido = $valor * 5.34;
	echo "Valor convertido: RS$";
	echo number_format($convertido, 2,',','');
}
if ($de == 'euro' && $para == 'dolar') {
	$convertido = $valor * 1.08;
	echo "Valor convertido: US$";
	echo number_format($convertido, 2,',','');
}
if ($de == 'real' && $para == 'real') {
	echo "<script>alert('Não foi possível converter, Câmbios selecionados são IGUAIS');</script>";
	echo "Valor convertido: RS$ $valor";
}
if ($de == 'dolar' && $para == 'dolar') {
	echo "<script>alert('Não foi possível converter, Câmbios selecionados são IGUAIS');</script>";
	echo "Valor convertido: US$ $valor";
}
if ($de == 'euro' && $para == 'euro') {
	echo "<script>alert('Não foi possível converter, Câmbios selecionados são IGUAIS');</script>";
	echo "Valor convertido: €$ $valor";
}
?>

</body>
</html>
