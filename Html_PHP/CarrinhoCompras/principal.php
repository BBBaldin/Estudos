<html xmlns="http://www.w3.org/1999/xhtml">
<head>
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <title>Untitled Document</title>
</head>
<body>
<?php
//criar vetor para armazenar os dados
$produtos[0]['codigo'] = "0";
$produtos[0]['nome'] = "Pen Drive 16GB";
$produtos[0]['marca'] = "Sandisk";
$produtos[0]['valor'] = "35,50";
$produtos[0]['imagem'] = "pendrive.jpg";
$produtos[1]['codigo'] = "1";
$produtos[1]['nome'] = "Mouse sem fio";
$produtos[1]['marca'] = "Microsoft";
$produtos[1]['valor'] = "70,00";
$produtos[1]['imagem'] = "mouse.jpg";
$produtos[2]['codigo'] = "2";
$produtos[2]['nome'] = "Impressora";
$produtos[2]['marca'] = "HP";
$produtos[2]['valor'] = "350,00";
$produtos[2]['imagem'] = "impressora.jpg";
$produtos[3]['codigo'] = "3";
$produtos[3]['nome'] = "Teclado Gamer Fallen Pantera - Mecânico";
$produtos[3]['marca'] = "Fallen";
$produtos[3]['valor'] = "389,00";
$produtos[3]['imagem'] = "panteraT.jpg";
$produtos[4]['codigo'] = "4";
$produtos[4]['nome'] = "Mouse Gamer Pantera Pro - Wireless";
$produtos[4]['marca'] = "Fallen";
$produtos[4]['valor'] = "499,00";
$produtos[4]['imagem'] = "panteraM.jpg";
$produtos[5]['codigo'] = "5";
$produtos[5]['nome'] = "Uniforme Furia";
$produtos[5]['marca'] = "Furia e-esports";
$produtos[5]['valor'] = "259,00";
$produtos[5]['imagem'] = "uniforme.jpg";
$produtos[6]['codigo'] = "6";
$produtos[6]['nome'] = "Headset Gamer Fallen Morcego - Roxo";
$produtos[6]['marca'] = "Fallen";
$produtos[6]['valor'] = "399,00";
$produtos[6]['imagem'] = "morcego.jpg";
$produtos[7]['codigo'] = "7";
$produtos[7]['nome'] = "Mouse Gamer Fallen Lobo ";
$produtos[7]['marca'] = "Fallen";
$produtos[7]['valor'] = "399,00";
$produtos[7]['imagem'] = "lobo.jpg";
$produtos[8]['codigo'] = "8";
$produtos[8]['nome'] = "Mouse Bungee Fallen Tucano Preto";
$produtos[8]['marca'] = "Fallen";
$produtos[8]['valor'] = "79,00";
$produtos[8]['imagem'] = "tucano.jpg";
$produtos[9]['codigo'] = "9";
$produtos[9]['nome'] = "Uniforme Imperial e-esports";
$produtos[9]['marca'] = "Imperial e-esports";
$produtos[9]['valor'] = "200,00";
$produtos[9]['imagem'] = "imp.jpg";
$produtos[10]['codigo'] = "10";
$produtos[10]['nome'] = "Uniforme Mibr e-esports";
$produtos[10]['marca'] = "Mibr e-esports";
$produtos[10]['valor'] = "200,00";
$produtos[10]['imagem'] = "mibr.jpg";

//gravando na sessão
session_start();
$_SESSION['produtos'] = $produtos;//criar variavel produtos na sessão
?>
<center>
<h3>Venda de Produtos</h3>
<form id="form1" name="form1" method="get" action="">
  <table width="252" border="1" class="text-success">
    <tr>
    <?php
//exibir todos os produtos
for($i=0;$i<count($produtos);$i++)
{
    $codigo = $produtos[$i]['codigo'];
    $nome = $produtos[$i]['nome'];
    $valor = $produtos[$i]['valor'];
    $marca = $produtos[$i]['marca'];
    $imagem = $produtos[$i]['imagem'];
?>
      <td width="136" rowspan="4"><img src=<?php echo $imagem;?> width="134" height="145" />
      </td>
      <td width="106"><?php echo $nome;?></td>
    </tr>
    <tr>
      <td><?php echo $marca;?></td>
    </tr>
    <tr>
      <td>R$ <?php echo $valor;?></td>
    </tr>
    <tr>
      <td><?php echo"<a href='carrinho.php?codigo=$codigo'>Adicionar</a>";?></td>
      </tr>
  <?php
}
?>  
  </table>
  <p><a href="carrinho.php">Voltar para o carrinho</a></p>
</center>
</form>
</body>
</html>