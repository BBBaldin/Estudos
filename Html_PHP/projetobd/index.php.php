<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title></title>
</head>
<body>

<form action="cadastra.php" method="POST">
	<table>
		<tr>
			<td>
				Nome
			</td>
			<td>
				<input type="name" name="nome">
			</td>
		</tr>
		<tr>
			<td>
				Sobrenome
			</td>
			<td>
				<input type="name" name="sobrenome">
			</td>
		</tr>
		<tr>
			<td>
				Idade
			</td>
			<td>
				<input type="number" name="idade">
			</td>
		</tr>
		<tr>
			<td>
				Sexo
			</td>
			<td>
				<input type="radio" name="sexo" value="m">Masculino
				<input type="radio" name="sexo" value="f">Feminino
			</td>
		</tr>
		<tr>
			<td colspan="2">
				<input type="submit" value="Cadastrar">
			</td>
		</tr>
	</table>
</form>

</body>
</html>