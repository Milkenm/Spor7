#region Usings
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

using ScriptsLib.Controls;
using ScriptsLib.Databases;
using ScriptsLib.Tools;
#endregion Usings



namespace Spor7.Forms
{
	public partial class Perfil : Form
	{
		#region Refs
		// # ================================================================================================ #
		Tools _Tools = new Tools();
		AccessDatabase _Database = new AccessDatabase();
		// # ================================================================================================ #
		Controls.TextBox _TextBox = new Controls.TextBox();
		Controls.MessageBox _MessageBox = new Controls.MessageBox();
		// # ================================================================================================ #
		#endregion Refs

		#region Vars
		private static int _Id { get; set; }
		private static string _Nome { get; set; }
		private static string _Morada { get; set; }
		private static string _Email { get; set; }
		private static string _Contacto { get; set; }
		private static string _Nib { get; set; }
		private static string _Login { get; set; }
		private static string _Password { get; set; }
		private static Image _Imagem { get; set; }
		private static int _IdImagem { get; set; }
		#endregion Vars

		#region Load
		// # ================================================================================================ #
		public Perfil(int? _IdUtilizador)
		{
			try
			{
				InitializeComponent();

				if (_IdUtilizador != null)
				{
					_Id = Convert.ToInt32(_IdUtilizador);

					_Nome = _Database.Select("Funcionarios", "Nome", $"ID = {_Id}")[0];
					_Morada = _Database.Select("Funcionarios", "Morada", $"ID = {_Id}")[0];
					_Email = _Database.Select("Funcionarios", "Email", $"ID = {_Id}")[0];
					_Contacto = _Database.Select("Funcionarios", "Contacto", $"ID = {_Id}")[0];
					_Nib = _Database.Select("Funcionarios", "NIB", $"ID = {_Id}")[0];
					_IdImagem = Convert.ToInt32(_Database.Select("Funcionarios", "Imagem", $"ID = {_Id}")[0]);
					_Login = _Database.Select("Funcionarios", "Login", $"ID = {_Id}")[0];
					_Password = _Database.Select("Funcionarios", "Password", $"ID = {_Id}")[0];

					textBox_nome.Text = _Nome;
					textBox_morada.Text = _Morada;
					textBox_email.Text = _Email;
					textBox_contacto.Text = _Contacto;
					textBox_nib.Text = _Nib;
					textBox_login.Text = _Login;

					if (File.Exists(Valores._CaminhoImagensFuncionarios + $"{_IdImagem}.png"))
					{
						_Imagem = Image.FromFile(Valores._CaminhoImagensFuncionarios + $"{_IdImagem}.png");
						pictureBox_utilizador.Image = _Imagem;
					}
				}
			}
			catch (Exception _Exception)
			{
				_Tools.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		private void Perfil_Load(object sender, EventArgs e)
		{
			try
			{
				_TextBox.OnlyNumbers(textBox_contacto);
				_TextBox.OnlyNumbers(textBox_nib);
			}
			catch (Exception _Exception)
			{
				_Tools.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		#endregion Load











		#region PictureBox
		// # ================================================================================================ #
		private void pictureBox_utilizador_Click(object sender, EventArgs e)
		{
			try
			{
				fileDialog.ShowDialog();
			}
			catch (Exception _Exception)
			{
				_Tools.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		private void fileDialog_FileOk(object sender, CancelEventArgs e)
		{
			try
			{
				if (!String.IsNullOrEmpty(fileDialog.FileName))
				{
					pictureBox_utilizador.Image = Image.FromFile(fileDialog.FileName);
				}
			}
			catch (Exception _Exception)
			{
				_Tools.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		#endregion PictureBox



		#region Botão
		// # ================================================================================================ #
		private void button_ok_Click(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(textBox_password.Text))
			{
				if (textBox_password.Text != textBox_password2.Text)
				{
					MessageBox.Show("As passwords não correspondem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
			}
			if (textBox_nome.Text != _Nome || textBox_morada.Text != _Morada || textBox_email.Text != _Email || textBox_contacto.Text != _Contacto || textBox_nib.Text != _Nib || pictureBox_utilizador.Image != _Imagem || textBox_login.Text != _Login || (!String.IsNullOrEmpty(textBox_password.Text) && textBox_password.Text == textBox_password2.Text))
			{
				if (pictureBox_utilizador.Image != _Imagem)
				{
					_IdImagem = Convert.ToInt32(_Database.Select("Funcionarios", "MAX(Imagem)", $"ID = {_Id}")[0]) + 1;

					pictureBox_utilizador.Image.Save(Valores._CaminhoImagensFuncionarios + $"{_IdImagem}.png");

					if (_Id == Main._Id)
					{
						Valores._Main.pictureBox_utilizador.Image = pictureBox_utilizador.Image;
					}
				}

				
				if (!String.IsNullOrEmpty(textBox_password.Text) && textBox_password.Text == textBox_password2.Text)
				{
					_Database.Update("Funcionarios", $"Nome = '{textBox_nome.Text}', Morada = '{textBox_morada.Text}', Email = '{textBox_email.Text}', Contacto = '{textBox_contacto.Text}', NIB = '{textBox_nib.Text}', Imagem = '{_IdImagem}', Login = '{textBox_login.Text}', Password = '{_Tools.Hash(textBox_password.Text)}'", $"ID = {_Id}");
				}
				else
				{
					_Database.Update("Funcionarios", $"Nome = '{textBox_nome.Text}', Morada = '{textBox_morada.Text}', Email = '{textBox_email.Text}', Contacto = '{textBox_contacto.Text}', NIB = '{textBox_nib.Text}', Imagem = '{_IdImagem}', Login = '{textBox_login.Text}'", $"ID = {_Id}");
				}

				MessageBox.Show("Perfil atualizado.");
				Valores._Main.ListarFuncionarios();
			}

			this.Close();
		}
		// # ================================================================================================ #
		#endregion Botão

		private void button_apagar_Click(object sender, EventArgs e)
		{
			if (_MessageBox.ShowConfirmationDialog("Apagar Utilizador?", $"Deseja mesmo apagar o utilizador '{_Nome}' (ID: {_Id})?", MessageBoxIcon.Question) == true)
			{
				_Database.Delete("Funcionarios", $"ID = {_Id}");
				MessageBox.Show("Utilizador apagado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
				if (_Id == Main._Id)
				{
					Valores._Main.Hide();
					new Login().Show();
				}
				else
				{
					Valores._Main.ListarFuncionarios();
				}
			}
		}
	}
}
