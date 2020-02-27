#region Usings
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using ScriptsLib.Controls;
using ScriptsLib.Databases;
using ScriptsLib.Tools;
#endregion Usings



namespace Spor7.Forms
{
	public partial class Adicionar : Form
	{
		#region Vars
		// # ================================================================================================ #
		int _Dialog;
		// # ================================================================================================ #
		#endregion Vars

		#region Refs
		// # ================================================================================================ #
		AccessDatabase _Database = new AccessDatabase();
		Tools _Tools = new Tools();
		// # ================================================================================================ #
		Controls.TextBox _TextBox = new Controls.TextBox();
		Controls.ComboBox _ComboBox = new Controls.ComboBox();
		// # ================================================================================================ #
		Tools.DatabaseTools _DatabaseTools = new Tools.DatabaseTools();
		// # ================================================================================================ #
		Scripts7 _Scripts7 = new Scripts7();
		// # ================================================================================================ #
		#endregion Refs

		#region Functions
		void TrocarTab(int _Index)
		{
			try
			{
				if (_Index == 0)
				{
					Size = new Size(568, 379);
				}
				else if (_Index == 1)
				{
					Size = new Size(568, 232);
				}
			}
			catch (Exception _Exception)
			{
				_Scripts7.Exception(_Exception);
			}
		}
		#endregion Functions

		#region Load
		// # ================================================================================================ #
		public Adicionar(int? _Index)
		{
			try
			{
				InitializeComponent();

				if (_Index != null)
				{
					tabs.SelectedIndex = Convert.ToInt32(_Index);
					TrocarTab(Convert.ToInt32(_Index));
				}
			}
			catch (Exception _Exception)
			{
				_Scripts7.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		private void Adicionar_Load(object sender, EventArgs e)
		{
			try
			{
				#region Controls
				_ComboBox.Resize(comboBox_categoria, 20);

				_TextBox.OnlyNumbers(textBox_contacto);
				_TextBox.OnlyNumbers(textBox_nib);
				_TextBox.OnlyNumbers(textBox_referencia);
				#endregion Controls



				#region Carregar Base de Dados
				List<string> _Categorias = _DatabaseTools.SelectUnique("Produtos", "Categoria", Tools.DatabaseTools.DatabaseType.Access);
				if (_Categorias.Count > 0)
				{
					foreach (string _Categoria in _Categorias)
					{
						comboBox_categoria.Items.Add(_Categoria);
					}
				}
				#endregion Carregar Base de Dados
			}
			catch (Exception _Exception)
			{
				_Scripts7.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		#endregion Load














		#region Tabs
		// # ================================================================================================ #
		private void tab_adicionar_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				TrocarTab(tabs.SelectedIndex);
			}
			catch (Exception _Exception)
			{
				_Scripts7.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		#endregion Tabs



		#region PictureBox
		// # ================================================================================================ #
		private void pictureBox_utilizador_Click(object sender, EventArgs e)
		{
			try
			{
				fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
				_Dialog = 0;
				fileDialog.ShowDialog();
			}
			catch (Exception _Exception)
			{
				_Scripts7.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		private void pictureBox_produto_Click(object sender, EventArgs e)
		{
			try
			{
				fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
				_Dialog = 1;
				fileDialog.ShowDialog();
			}
			catch (Exception _Exception)
			{
				_Scripts7.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		private void fileDialog_FileOk(object sender, CancelEventArgs e)
		{
			try
			{
				if (!String.IsNullOrEmpty(fileDialog.FileName))
				{
					if (_Dialog == 0)
					{
						pictureBox_funcionario.BackgroundImage = null;
						pictureBox_funcionario.Image = Image.FromFile(fileDialog.FileName);
					}
					else if (_Dialog == 1)
					{
						pictureBox_produto.BackgroundImage = null;
						pictureBox_produto.Image = Image.FromFile(fileDialog.FileName);
					}
				}
			}
			catch (Exception _Exception)
			{
				_Scripts7.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		#endregion PictureBox



		#region Botão 'Adicionar Utilizador'
		// # ================================================================================================ #
		private void button_adicionarUtilizador_Click(object sender, EventArgs e)
		{
			try
			{
				#region Erro
				bool _Erro = false;
				errorProvider.Clear();

				if (String.IsNullOrEmpty(textBox_nome.Text))
				{
					errorProvider.SetError(textBox_nome, "O nome não pode estar vazio.");
					_Erro = true;
				}
				if (String.IsNullOrEmpty(textBox_morada.Text))
				{
					errorProvider.SetError(textBox_morada, "A morada não pode estar vazia.");
					_Erro = true;
				}
				if (String.IsNullOrEmpty(textBox_email.Text))
				{
					errorProvider.SetError(textBox_email, "O e-mail não pode estar vazio.");
					_Erro = true;
				}
				if (String.IsNullOrEmpty(textBox_contacto.Text))
				{
					errorProvider.SetError(textBox_contacto, "O contacto não pode estar vazio.");
					_Erro = true;
				}
				if (String.IsNullOrEmpty(textBox_nib.Text))
				{
					errorProvider.SetError(textBox_nib, "O NIB não pode estar vazio.");
					_Erro = true;
				}
				if (String.IsNullOrEmpty(textBox_login.Text))
				{
					errorProvider.SetError(textBox_login, "O nome de login não pode estar vazio.");
					_Erro = true;
				}
				if (textBox_password.Text.Length < 8)
				{
					errorProvider.SetError(textBox_password, "A password tem de ter um minimo de 8 caracteres.");
					_Erro = true;
				}
				if (textBox_password.Text != textBox_passwordConfirmar.Text)
				{
					errorProvider.SetError(textBox_passwordConfirmar, "As passwords não correspondem.");
					_Erro = true;
				}
				if (pictureBox_funcionario.Image == null)
				{
					errorProvider.SetError(pictureBox_funcionario, "O utilizador tem de ter uma imagem.");
					_Erro = true;
				}
				if (comboBox_permissoes.Text == null)
				{
					errorProvider.SetError(comboBox_permissoes, "O utilizador precisa de permissões.");
				}
				#endregion Erro



				if (_Erro == false)
				{
					int _IdImagem = 0;
					List<string> _Imagens = _Database.Select("Funcionarios", "MAX(Imagem)");
					if (_Imagens.Count > 0)
					{
						if (!String.IsNullOrEmpty(_Imagens[0]))
						{
							_IdImagem = Convert.ToInt32(_Imagens[0]) + 1;
						}
					}

					string _Permissoes = null;
					
					if (comboBox_permissoes.Text == "Administrador")
					{
						_Permissoes = "administrador";
					}
					else if (comboBox_permissoes.Text == "Funcionário")
					{
						_Permissoes = "funcionario";
					}
					else if (comboBox_permissoes.Text == "Estagiário")
					{
						_Permissoes = "estagiario";
					}

					_Database.InsertInto("Funcionarios", "Nome,Morada,Email,Contacto,NIB,Idade,Login,Password,Imagem,Permissoes", $"'{textBox_nome.Text}','{textBox_morada.Text}','{textBox_email.Text}','{textBox_contacto.Text}','{textBox_nib.Text}','{numeric_idade.Text}','{textBox_login.Text}','{_Tools.Hash(textBox_password.Text)}','{_IdImagem}','{_Permissoes}'");
					pictureBox_funcionario.Image.Save(Valores._CaminhoImagensFuncionarios + $"{_IdImagem}.png");

					MessageBox.Show("Utilizador adicionado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Valores._Main.ListarFuncionarios();
					this.Close();
				}
			}
			catch (Exception _Exception)
			{
				_Scripts7.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		#endregion Botão 'Adicionar Utilizador'



		#region Botão 'Adicionar Produto'
		// # ================================================================================================ #
		private void button_adicionarProduto_Click(object sender, EventArgs e)
		{
			try
			{
				#region Erros
				errorProvider.Clear();
				bool _Erro = false;

				if (String.IsNullOrEmpty(textBox_produto.Text))
				{
					errorProvider.SetError(textBox_produto, "O produto tem de ter nome.");
					_Erro = true;
				}
				if (numeric_preco.Value <= 0)
				{
					errorProvider.SetError(numeric_preco, "O produto tem de ter um preço.");
					_Erro = true;
				}
				if (String.IsNullOrEmpty(textBox_referencia.Text))
				{
					errorProvider.SetError(textBox_referencia, "O produto tem de ter uma referencia.");
					_Erro = true;
				}
				if (String.IsNullOrEmpty(comboBox_categoria.Text))
				{
					errorProvider.SetError(comboBox_categoria, "O produto tem de ter uma categoria.");
					_Erro = true;
				}
				if (pictureBox_produto.Image == null)
				{
					errorProvider.SetError(pictureBox_produto, "O produto tem de ter uma imagem.");
					_Erro = true;
				}
				#endregion Erros



				if (_Erro == false)
				{
					int _IdImagem = 0;
					List<string> _Imagens = _Database.Select("Produtos", "MAX(Imagem)");
					if (_Imagens.Count > 0)
					{
						if (!String.IsNullOrEmpty(_Imagens[0]))
						{
							_IdImagem = Convert.ToInt32(_Imagens[0]) + 1;
						}
					}
					_Database.InsertInto("Produtos", "Nome,Preco,Quantidade,Referencia,Categoria,Imagem", $"'{textBox_produto.Text}','{numeric_preco.Value}','{numeric_quantidade.Value}','{textBox_referencia.Text}','{comboBox_categoria.Text}','{_IdImagem}'");
					pictureBox_produto.Image.Save(Valores._CaminhoImagensProdutos + $"{_IdImagem}.png");
					
					MessageBox.Show("Produto adicionado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Valores._Main.ListarProdutos();
					this.Close();
				}
			}
			catch (Exception _Exception)
			{
				_Scripts7.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		#endregion Botão 'Adicionar Produto'
	}
}
