#region Usings
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ScriptsLib.AspNet;
using ScriptsLib.Databases;
#endregion Usings



namespace Site
{
	public partial class Registar : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			try
			{
				AccessDatabase._DatabasePath = @"C:\Milkenm\Projects\Visual Studio\Spor7\_Dados\BD_Spor7.mdb";

				literal_telefone.Text = new Scripts()._Database.Select("Config", "Valor", "Config = 'Telefone'")[0];
				literal_email.Text = new Scripts()._Database.Select("Config", "Valor", "Config = 'Email'")[0];
				if (!String.IsNullOrEmpty($"{Session["ID"]}"))
				{
					Response.Redirect("/index.aspx");
				}
			}
			catch (Exception _Exception)
			{
				new Scripts().Exception(_Exception);
			}
		}

		protected void button_registar_Click(object sender, EventArgs e)
		{
			try
			{
				if (String.IsNullOrEmpty(textBox_nome.Text) || String.IsNullOrEmpty(textBox_morada.Text) || String.IsNullOrEmpty(textBox_email.Text) || String.IsNullOrEmpty(textBox_utilizador.Text) || String.IsNullOrEmpty(textBox_password.Text))
				{
					new Scripts()._AspNet.ShowPopup(this, "Todos os campos têm de ser preenchidos.");
				}
				else
				{
					List<string> _CheckUtilizador = new Scripts()._Database.Select("Utilizadores", "ID", $"Login = '{textBox_nome.Text}'");
					bool _Existe = false;

					if (_CheckUtilizador != null)
					{
						foreach (string _Check in _CheckUtilizador)
						{
							_Existe = true;
							break;
						}
					}


					if (!_Existe)
					{
						new Scripts()._Database.InsertInto("Utilizadores", "Nome,Morada,Email,Login,Password", $"'{textBox_nome.Text}','{textBox_morada.Text}','{textBox_email.Text}','{textBox_utilizador.Text}','{new Scripts()._Tools.Hash(textBox_password.Text)}'");
						new Scripts()._AspNet.ShowPopup(this, "Registo efetuado com sucesso!");

						Session["ID"] = textBox_nome.Text;
						Response.Redirect("index.aspx");
					}
					else
					{
						new Scripts()._AspNet.ShowPopup(this, $"O nome de utilizador '{textBox_utilizador.Text}' já existe. Tente outro.");
						textBox_utilizador.Focus();
					}
				}
			}
			catch (Exception _Exception)
			{
				new Scripts().Exception(_Exception);
			}
		}
	}
}