<!DOCTYPE html>
<html>
<head>
	<title>JOKENPO</title>
</head>
<body>

	<fieldset>
		<legend>JOKENPO</legend>
		<form action="recebe.php" method="GET">
			<table>
				<tr align-itens="space-between">
					<td>
						<input type="radio" name="opcao" value="pedra">Pedra
					</td>
					<td>
						<input type="radio" name="opcao" value="papel">Papel
					</td>
					<td>
						<input type="radio" name="opcao" value="tesoura">Tesoura
					</td>
				</tr>
				<tr>
					<td colspan="2" align="center">
						<input type="submit" value="Verificar"></input>
					</td>
				</tr>
			</table>
		</form>
	</fieldset>

</body>
</html>