#region Usings
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ScriptsLib.Databases;
#endregion Usings



namespace Site
{
	public partial class Login : System.Web.UI.Page
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

		protected void button_login_Click(object sender, EventArgs e)
		{
			try
			{
				if (new Scripts()._DatabaseTools.CheckLogin("Utilizadores", textBox_utilizador.Text, new Scripts()._Tools.Hash(textBox_password.Text), "Login", "Password", ScriptsLib.Tools.Tools.DatabaseTools.DatabaseType.Access))
				{
					Session["ID"] = textBox_utilizador.Text;
					Response.Redirect("/index.aspx");
				}
				else
				{
					new Scripts()._AspNet.ShowPopup(this, "Utilizador ou Password incorretos.");
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
				Response.Redirect("registar.aspx");
			}
			catch (Exception _Exception)
			{
				new Scripts().Exception(_Exception);
			}
		}
	}
}