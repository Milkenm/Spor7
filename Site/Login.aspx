<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Site.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

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
		.auto-style1 {
			width: 21%;
		}

		.auto-style2 {
			left: 0px;
			top: 0px;
		}
	</style>
</head>
<body>
	<form id="form1" runat="server">
		<!-- Shell -->
		<div class="shell">
			<!-- Header -->
			<div id="header" class="auto-style2">
				<h1 id="logo"></h1>
				<!-- Cart -->
				<div id="cart">

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
					<%
						if (Session["Utilizador"] == null)
						{
					%>
					<table class="auto-style1">
						<tr>
							<td>
								<asp:Label ID="label_utilizador" runat="server" Text="Utilizador:"></asp:Label>
								<asp:TextBox ID="textBox_utilizador" runat="server" Width="164px"></asp:TextBox>
							</td>
						</tr>
						<tr>
							<td>
								<asp:Label ID="label_password" runat="server" Text="Password:"></asp:Label>
								<asp:TextBox ID="textBox_password" runat="server" Width="164px"></asp:TextBox>
							</td>
						</tr>
						<tr>
							<td align="right">
								<asp:Button ID="button_registar" runat="server" Text="Registar" OnClick="button_registar_Click" />
							</td>
							<td>
								<asp:Button ID="button_login" runat="server" Text="Login" OnClick="button_login_Click" UseSubmitBehavior="False" />
							</td>
						</tr>
					</table>
					<%
						}
						else
						{
					%>
					&nbsp;<%
						}
					%></center>
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
						<a>Telefone: <asp:Literal ID="literal_telefone" runat="server"></asp:Literal></a>
						<span>|</span>
						<a>E-mail: <asp:Literal ID="literal_email" runat="server"></asp:Literal></a>
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
