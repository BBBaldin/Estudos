<!DOCTYPE html>
<html>
<head>
	<title>Calculadora IMC</title>
</head>
<body>

	<fieldset>
		<legend>
			Calcular IMC
		</legend>
		<form action="recebe.php" method="GET">
			<table>
				<tr>
					<td>
						Informe seu peso
					</td>
				</tr>
				<tr>
					<td>
						<input type="text" name="peso">
					</td>
				</tr>
				<tr>
					<td>
						Informe sua altura
					</td>
				</tr>
				<tr>
					<td>
						<input type="text" name="altura">
					</td>
				</tr>
				<tr>
					<td colspan="2" align="center">
						<br><input type="submit" value="CALCULAR">
					</td>
				</tr>
			</table>
		</form>
	</fieldset>

</body>
</html>