#region Usings
using System;
using System.IO;
using System.Windows.Forms;

using ScriptsLib.Databases;
using ScriptsLib.Tools;

using Spor7.Properties;
#endregion Usings



namespace Spor7.Forms
{
	public partial class Login : Form
	{
		#region Refs
		// # ================================================================================================ #
		AccessDatabase _Database = new AccessDatabase();
		Tools _Tools = new Tools();
		// # ================================================================================================ #
		Tools.DatabaseTools _DatabaseTools = new Tools.DatabaseTools();
		// # ================================================================================================ #
		Scripts7 _Scripts7 = new Scripts7();
		// # ================================================================================================ #
		#endregion Refs

		#region Load / Unload
		// # ================================================================================================ #
		public Login()
		{
			try
			{
				InitializeComponent();
			}
			catch (Exception _Exception)
			{
				_Scripts7.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		private void Login_Load(object sender, EventArgs e)
		{
			try
			{
				var _TemUtilizador = _Database.Select("Funcionarios", "MAX(ID)");
				if (_TemUtilizador.Count < 1 || String.IsNullOrEmpty(_TemUtilizador[0]))
				{
					_Database.InsertInto("Funcionarios", "Nome,Morada,Email,Contacto,NIB,Idade,Login,Password", $"'Admin','Admin','Admin','Admin','Admin','Admin','Admin','{_Tools.Hash("Admin")}'");
					if (Directory.Exists(Valores._CaminhoImagensFuncionarios))
					{
						Directory.Delete(Valores._CaminhoImagensFuncionarios);
					}
					else
					{
						Directory.CreateDirectory(Valores._CaminhoImagensFuncionarios);
					}
				}
			}
			catch (Exception _Exception)
			{
				_Scripts7.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		private void Login_FormClosed(object sender, FormClosedEventArgs e)
		{
			try
			{
				Environment.Exit(0);
			}
			catch (Exception _Exception)
			{
				_Scripts7.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		private void Login_Shown(object sender, EventArgs e)
		{
			try
			{
				var _Select = _Database.Select("Config", "Valor", "Config = 'Lembrar'");
				if (_Select.Count > 0)
				{
					textBox_utilizador.Text = _Select[0];
					checkBox_lembrar.Checked = true;
					textBox_password.Focus();
				}
			}
			catch (Exception _Exception)
			{
				_Scripts7.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		#endregion Load / Unload
















		#region Login
		// # ================================================================================================ #
		private void button_login_Click(object sender, EventArgs e)
		{
			try
			{
				button_login.Enabled = false;

				string _Utilizador = _DatabaseTools.FilterSql(textBox_utilizador.Text);
				string _Password = _Tools.Hash(_DatabaseTools.FilterSql(textBox_password.Text));

				if (_DatabaseTools.CheckLogin("Funcionarios", _Utilizador, _Password, "Login", "Password", Tools.DatabaseTools.DatabaseType.Access) == true)
				{
					if (checkBox_lembrar.Checked == true)
					{
						if (_Database.Select("Config", "Valor", "Config = 'Lembrar'").Count == 0)
						{
							_Database.InsertInto("Config", "Config,Valor", $"'Lembrar', '{_Utilizador}'");
						}
						else
						{
							if (_Database.Select("Config", "Valor", "Config = 'Lembrar'")[0] != textBox_utilizador.Text)
							{
								_Database.Update("Config", $"Valor = '{textBox_utilizador.Text}'", "Config = 'Lembrar'");
							}
						}
					}
					else
					{
						if (_Database.Select("Config", "Valor", "Config = 'Lembrar'").Count > 0)
						{
							_Database.Delete("Config", "Config = 'Lembrar'");
						}
					}



					Temp._IdFuncionario = _Database.Select("Funcionarios", "ID", $"Login = '{textBox_utilizador.Text}'")[0];
					Valores._Valores.LoadMain(Convert.ToInt32(Temp._IdFuncionario));
					Valores._Main.Show();
					this.Hide();
				}
				else
				{
					label_erroLogin.Visible = true;
					button_login.Enabled = true;
					textBox_password.Focus();
					textBox_password.SelectAll();
				}
			}
			catch (Exception _Exception)
			{
				_Scripts7.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		#endregion Login



		#region Password
		// # ================================================================================================ #
		private void textBox_password_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				if (label_erroLogin.Visible == true)
				{
					label_erroLogin.Visible = false;
				}

				if (e.KeyCode == Keys.Enter)
				{
					button_login.PerformClick();
				}
			}
			catch (Exception _Exception)
			{
				_Scripts7.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		private void button_mostrarPassword_Click(object sender, EventArgs e)
		{
			try
			{
				if (textBox_password.PasswordChar == '\0')
				{
					button_mostrarPassword.BackgroundImage = Resources.Password_Visivel;
					textBox_password.PasswordChar = '•';
				}
				else
				{
					button_mostrarPassword.BackgroundImage = Resources.Password_Ocultar;
					textBox_password.PasswordChar = '\0';
				}
			}
			catch (Exception _Exception)
			{
				_Scripts7.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		#endregion Password
	}
}
