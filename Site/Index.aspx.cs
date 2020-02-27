#region Usings
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ScriptsLib.Databases;
#endregion Usings



namespace Site
{
	public partial class Index : System.Web.UI.Page
	{


		protected void Page_Load(object sender, EventArgs e)
		{
			try
			{
				AccessDatabase._DatabasePath = @"C:\Milkenm\Projects\Visual Studio\Spor7\_Dados\BD_Spor7.mdb";

				literal_telefone.Text = new Scripts()._Database.Select("Config", "Valor", "Config = 'Telefone'")[0];
				literal_email.Text = new Scripts()._Database.Select("Config", "Valor", "Config = 'Email'")[0];
			}
			catch (Exception _Exception)
			{
				new Scripts().Exception(_Exception);
			}
		}
	}
}