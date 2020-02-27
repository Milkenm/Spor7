<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagina.aspx.cs" Inherits="Site.Pagina" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="ID" DataSourceID="SqlDataSource2" GridLines="Vertical" Height="78px" Width="417px">
				<AlternatingRowStyle BackColor="Gainsboro" />
				<Columns>
					<asp:BoundField DataField="ID_Produto" HeaderText="ID_Produto" SortExpression="ID_Produto" />
					<asp:CommandField DeleteText="Remover" ShowDeleteButton="True" />
					<asp:BoundField DataField="ID" HeaderText="Nome" ReadOnly="True" SortExpression="ID" />
				</Columns>
				<FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
				<HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
				<PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
				<RowStyle BackColor="#EEEEEE" ForeColor="Black" />
				<SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
				<SortedAscendingCellStyle BackColor="#F1F1F1" />
				<SortedAscendingHeaderStyle BackColor="#0000A9" />
				<SortedDescendingCellStyle BackColor="#CAC9C9" />
				<SortedDescendingHeaderStyle BackColor="#000065" />
			</asp:GridView>
			<asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:BD_Spor7ConnectionString %>" ProviderName="<%$ ConnectionStrings:BD_Spor7ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Carrinho]"></asp:SqlDataSource>
			<asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:BD_Spor7ConnectionString %>" ProviderName="<%$ Text:BD_Spor7ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Produtos]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
