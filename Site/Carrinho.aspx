<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Carrinho.aspx.cs" Inherits="Site.Carrinho" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">
	public static string a = "b";
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
	<title>Spor7 - Conta</title>
	<link rel="icon" type="image/png" href="css/images/favicon.ico" />
	<meta http-equiv="Content-type" content="text/html; charset=utf-8" />
	<link rel="stylesheet" href="css/style.css" type="text/css" media="all" />
	<!--[if lte IE 6]><link rel="stylesheet" href="css/ie6.css" type="text/css" media="all" /><![endif]-->
	<script src="js/jquery-1.4.1.min.js" type="text/javascript"></script>
	<script src="js/jquery.jcarousel.pack.js" type="text/javascript"></script>
	<script src="js/jquery-func.js" type="text/javascript"></script>
	<style type="text/css">
		.auto-style2 {
			left: 0px;
			top: 0px;
		}

		.auto-style3 {
			width: 100%;
			height: 220px;
		}

		.auto-style4 {
			width: 301px;
			height: 60px;
		}

		.auto-style5 {
			height: 26px;
		}

		.auto-style6 {
			height: 24px;
		}

		.auto-style7 {
			width: 68%;
		}

		.auto-style8 {
			width: 586px;
			height: 60px;
		}

		.auto-style9 {
			height: 60px;
		}
	</style>
</head>
<body>
	<form id="form2" runat="server">
		<!-- Shell -->
		<div class="shell">
			<!-- Header -->
			<div id="header" class="auto-style2">
				<h1 id="logo"></h1>
				<!-- Cart -->
				<div id="cart">
					<a href="#" class="cart-link">Carrinho</a>
					<div class="cl">&nbsp;</div>
					<span>Produtos: 
					<asp:Literal ID="literal_produtos" runat="server"></asp:Literal>
						Preço: 
					<asp:Literal ID="literal_preco" runat="server"></asp:Literal>
						€</span>
				</div>
				<!-- End Cart -->
				<!-- Navigation -->
				<div id="navigation">
					<ul>
						<li><a href="index.aspx">Loja</a></li>
						<li><a class="active">Conta</a></li>
					</ul>
				</div>
				<!-- End Navigation -->
			</div>
			<!-- End Header -->
			<!-- Main -->
			<div id="main">
				<center>
					<table class="auto-style3">
						<%
							List<string> _Carrinho = new Site.Scripts()._Database.Select("Utilizadores", "Carrinho", $"Nome = '{Session["ID"]}'");
							if (_Carrinho != null)
							{
								string[] _Produtos = _Carrinho[0].Split(',');

								foreach (string _Produto in _Produtos)
								{
									if (!String.IsNullOrEmpty(_Produto) && !String.IsNullOrWhiteSpace(_Produto))
									{

										string _Nome = new Site.Scripts()._Database.Select("Produtos", "Nome", $"ID = {_Produto}")[0];
										string _Preco = new Site.Scripts()._Database.Select("Produtos", "Preco", $"ID = {_Produto}")[0];
										string _IdImagem = new Site.Scripts()._Database.Select("Produtos", "Imagem", $"ID = {_Produto}")[0];
						%>
						<tr>
							<td class="auto-style4" style="border-style: solid;">
								<center>
									<asp:Image ID="pictureBox_produto" runat="server" Width="100" Height="100" />
									<%
										CarregarImg(_IdImagem);
									%>
								</center>
							</td>
							<td class="auto-style8" style="border-style: solid">
								<table class="auto-style7">
									<tr>
										<td colspan="3" class="auto-style6">
											<a><%: _Nome %></a>
										</td>
									</tr>
									<tr>
										<td class="auto-style5" colspan="3">
											<a><%: _Preco + "€" %></a>
										</td>
									</tr>
								</table>
							</td>
							<td class="auto-style9" style="border-style: solid">
								<asp:Button ID="button_remover" runat="server" Text="Remover" Width="100" CommandName="<%$ a %>" />
							</td>
						</tr>
						<%
									}
								}
							}
						%>
					</table>
					
				</center>
			</div>
			<!-- End Main -->
			<!-- Footer -->
			<div id="footer">
				<p class="left">
					<a href="index.aspx">Loja</a>
					<span>|</span>
					<a class="active">Conta</a>
				</p>
				<p class="right">&copy; 2019 Spor7</p>
				<center>
					<p>
						<span>[</span>
						<a>Telefone:
							<asp:Literal ID="literal_telefone" runat="server"></asp:Literal></a>
						<span>|</span>
						<a>E-mail:
							<asp:Literal ID="literal_email" runat="server"></asp:Literal></a>
						<span>|||</span>
						<a>Utilizador:
							<asp:Literal ID="literal_utilizador" runat="server"></asp:Literal></a>
						<span>]</span>
					</p>
				</center>
			</div>
			<!-- End Footer -->
			<!-- End Shell -->
		</div>
	</form>
</body>
</html>
