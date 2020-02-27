<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Site.Index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
	<title>Spor7</title>
	<link rel="icon" type="image/png" href="css/images/favicon.ico" />
	<meta http-equiv="Content-type" content="text/html; charset=utf-8" />
	<link rel="stylesheet" href="css/style.css" type="text/css" media="all" />
	<!--[if lte IE 6]><link rel="stylesheet" href="css/ie6.css" type="text/css" media="all" /><![endif]-->
	<script src="js/jquery-1.4.1.min.js" type="text/javascript"></script>
	<script src="js/jquery.jcarousel.pack.js" type="text/javascript"></script>
	<script src="js/jquery-func.js" type="text/javascript"></script>
	<style type="text/css">
		.auto-style3 {
			width: 139px;
		}

		.auto-style4 {
			width: 833px;
			height: 108px;
		}
	</style>
</head>
<body>
	<form runat="server">
		<!-- Shell -->
		<div class="shell">
			<!-- Header -->
			<div id="header">
				<h1 id="logo"></h1>
				<!-- Navigation -->
				<div id="navigation">
					<ul>
						<li><a class="active">Inicio</a></li>
					</ul>
				</div>
				<!-- End Navigation -->
			</div>
			<!-- End Header -->
			<!-- Main -->
			<div id="main">
				<div class="cl">&nbsp;</div>
				<!-- Content -->
				<!-- Content Slider -->
				<!-- End Content Slider -->
				<!-- Products -->
				<div class="products">
					<div class="cl">&nbsp;</div>
					<div>

						<table style="width: 100%;">
							<tr>
								<td>
									<center>
										<img alt="" class="auto-style4" src="_imagens/IntroSite_3.png" />
								</td>
								</center>
							</tr>
							<tr>
								<td>
									<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BD_Spor7ConnectionString %>" ProviderName="<%$ ConnectionStrings:BD_Spor7ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Produtos] ORDER BY [Nome]"></asp:SqlDataSource>
									<asp:DataList ID="DataList1" runat="server" DataKeyField="ID" DataSourceID="SqlDataSource1" Width="100%" Height="100%" RepeatColumns="4" RepeatDirection="Horizontal">
										<ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" />
										<ItemTemplate>
											<table style="width: 400" border="1">
												<tr>
													<td class="auto-style3" style="border-color: #008000">
														<center>
															<asp:Label ID="NomeLabel" runat="server" Text='<%# Eval("Nome") %>' />
														</center>
													</td>
												</tr>
												<tr>
													<td class="auto-style3" style="border-color: #008000">
														<center>
															<img alt="" src="_imagens\Imagens_Produtos\<%# Eval("Imagem") %>.png" height="128px" width="128px" />
														</center>
													</td>
												</tr>
												<tr>
													<td class="auto-style3" style="border-color: #008000">Preço:
												<asp:Label ID="PrecoLabel" runat="server" Text='<%# Eval("Preco") %>' />
														€
												<br />
														<br />
														<asp:Label ID="CategoriaLabel" runat="server" Text='<%# Eval("Categoria") %>' />
														<br />
													</td>
												</tr>
											</table>
											<br />
											&nbsp;<br />
										</ItemTemplate>
									</asp:DataList>
						

								</td>
							</tr>
						</table>

					</div>
					<div class="cl">&nbsp;</div>
				</div>
				<!-- End Products -->
				<!-- End Content -->
				<!-- Sidebar -->
				<!-- End Sidebar -->
				<div class="cl">&nbsp;</div>
			</div>
			<!-- End Main -->
			<!-- Side Full -->
			<div class="side-full">
				<!-- More Products -->
				<div class="more-products">
					<div class="more-nav">&nbsp; </div>
				</div>
				<!-- End More Products -->
			</div>
			<!-- End Side Full -->
			<!-- Footer -->
			<div id="footer">
				<p class="left">
					<a class="active">Loja</a>
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
						<span>]</span>
					</p>
				</center>
			</div>
			<!-- End Footer -->
		</div>
		<!-- End Shell -->
	</form>
</body>
</html>
