<!DOCTYPE html>
<html>
<head>
	<title>Conversões</title>

	<style type="text/css">

	select{
		width: 200px;
	}

	</style>
</head>
<body>

	<fieldset>
		<legend>
			Taxa de câmbio
		</legend>
		<form action="recebe.php" method="GET">
			<table>
				<tr>
					<td>
						Informe o valor a ser convertido
					</td>
				</tr>
				<tr>
					<td>
						<input type="text" name="valor">
					</td>
				</tr>
				<tr align-itens="space-between">
					<td>
						Converter de:
					</td>
					<td>
						Converter para:
					</td>
				</tr>
				<tr align-itens="space-between">
					<td>
						<select name="de">
							<option>&nbsp;</option>
							<option value="real">Real</option>
							<option value="dolar">Dólar</option>
							<option value="euro">Euro</option>
						</select>
					</td>
					<td>
						<select name="para">
							<option>&nbsp;</option>
							<option value="real">Real</option>
							<option value="dolar">Dólar</option>
							<option value="euro">Euro</option>
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