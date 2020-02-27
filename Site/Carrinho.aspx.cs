using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using ScriptsLib.Databases;

namespace Site
{
	public partial class Carrinho : System.Web.UI.Page
	{
		public string _IdProduto;
		public string a = "b";

		protected void Page_Load(object sender, EventArgs e)
		{
			try
			{
				if (!Page.IsPostBack)
				{
					Page.DataBind();

					Session["ID"] = "abcdef";

					AccessDatabase._DatabasePath = @"C:\Milkenm\Projects\Visual Studio\Spor7\_Dados\BD_Spor7.mdb";

					literal_telefone.Text = new Scripts()._Database.Select("Config", "Valor", "Config = 'Telefone'")[0];
					literal_email.Text = new Scripts()._Database.Select("Config", "Valor", "Config = 'Email'")[0];
					if (!String.IsNullOrEmpty($"{Session["ID"]}"))
					{
						literal_utilizador.Text = $"{Session["ID"]}";

						List<string> _Carrinho = new Scripts()._Database.Select("Utilizadores", "Carrinho", $"Nome = '{Session["ID"]}'");
						if (_Carrinho != null)
						{
							string[] _Produtos = _Carrinho[0].Split(',');
							decimal _Preco = 0;
							literal_produtos.Text = _Produtos.Length.ToString();

							foreach (string _IdProduto in _Produtos)
							{
								decimal _PrecoProduto = Convert.ToDecimal(new Scripts()._Database.Select("Produtos", "Preco", $"ID = {_IdProduto}")[0]);
								_Preco = _Preco + _PrecoProduto;
							}

							literal_preco.Text = _Preco.ToString();
						}
						else
						{
							literal_produtos.Text = "0";
							literal_preco.Text = "0.00";
						}
					}
					else
					{
						literal_utilizador.Text = "Sem Utilizador";
						Response.Redirect("/login.aspx");
					}
				}
			}
			catch (Exception _Exception)
			{
				new Scripts().Exception(_Exception);
			}
		}

		public void CarregarImg(string _IdImagem)
		{
			pictureBox_produto.ImageUrl = $"~/_imagens/Imagens_Produtos/{_IdImagem}.png";
		}

		protected void Receber(string Valor)
		{
			MessageBox.Show(Valor);
		}

		protected void button_remover_Click(object sender, EventArgs e)
		{

		}
	}
}