#region Usings
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

using ScriptsLib.Controls;
using ScriptsLib.Databases;
using ScriptsLib.Tools;
#endregion Usings



namespace Spor7.Forms
{
	public partial class Main : Form
	{
		#region Refs
		// # ================================================================================================ #
		Tools _Tools = new Tools();
		AccessDatabase _Database = new AccessDatabase();
		// # ================================================================================================ #
		Controls.Form _Form = new Controls.Form();
		Controls.MessageBox _MessageBox = new Controls.MessageBox();
		// # ================================================================================================ #
		Scripts7 _Scripts7 = new Scripts7();
		// # ================================================================================================ #
		#endregion Refs

		#region Vars
		public static int _Id { get; set; }
		#endregion Vars

		#region Listar
		#region Listar Encomendas
		// # ================================================================================================ #
		public void ListarEncomendas()
		{
			try
			{
				flowLayoutPanel_encomendas.Controls.Clear();

				List<string> _Encomendas = _Database.Select("Encomendas_Telefone", "ID", "Concluida <> 'True'");
				foreach (string _IdEncomenda in _Encomendas)
				{
					#region Panel
					Panel _Panel = new Panel();
					_Panel.Size = new Size(515, 91);
					_Panel.BorderStyle = BorderStyle.FixedSingle;
					#endregion Panel

					#region Botão Ver
					Button _ButtonVer = new Button();
					_ButtonVer.Size = new Size(61, 23);
					_ButtonVer.Text = "Ver";
					_ButtonVer.Click += new EventHandler((_Sender, _Event) => _ButtonVerEncomendaClick(_Sender, _Event, Convert.ToInt32(_IdEncomenda)));
					#endregion Botão Ver

					#region Botão Remover
					Button _ButtonRemover = new Button();
					_ButtonRemover.Size = new Size(61, 23);
					_ButtonRemover.Text = "Remover";
					_ButtonRemover.Click += new EventHandler((_Sender, _Event) => _ButtonApagarEncomendaClick(_Sender, _Event, Convert.ToInt32(_IdEncomenda)));
					#endregion Botão Remover

					#region Botão Concluir
					Button _ButtonConcluir = new Button();
					_ButtonConcluir.Size = new Size(61, 23);
					_ButtonConcluir.Text = "Concluir";
					_ButtonConcluir.Click += new EventHandler((_Sender, _Event) => _ButtonConcluirEncomendaClick(_Sender, _Event, Convert.ToInt32(_IdEncomenda)));
					#endregion Botão Concluir


					#region Label Nome
					Label _LabelNome = new Label();
					_LabelNome.Size = new Size(35, 13);
					_LabelNome.Text = "Nome";
					#endregion Label Nome

					#region TextBox Nome
					TextBox _TextBoxNome = new TextBox();
					_TextBoxNome.Text = _Database.Select("Encomendas_Telefone", "Nome", $"ID = {_IdEncomenda}")[0];
					_TextBoxNome.ReadOnly = true;
					_TextBoxNome.Size = new Size(221, 20);
					#endregion TextBox Nome

					#region Label Morada
					Label _LabelMorada = new Label();
					_LabelMorada.Size = new Size(43, 13);
					_LabelMorada.Text = "Morada";
					#endregion Label Morada

					#region TextBox Morada
					TextBox _TextBoxMorada = new TextBox();
					_TextBoxMorada.Text = _Database.Select("Encomendas_Telefone", "Morada", $"ID = {_IdEncomenda}")[0];
					_TextBoxMorada.ReadOnly = true;
					_TextBoxMorada.Size = new Size(221, 20);
					#endregion TextBox Morada


					#region Label Produtos
					Label _LabelProdutos = new Label();
					_LabelProdutos.Size = new Size(49, 13);
					_LabelProdutos.Text = "Produtos";
					#endregion Label Produtos

					#region ListBox Produtos
					ListBox _ListBoxProdutos = new ListBox();
					_ListBoxProdutos.Size = new Size(213, 69);
					
					foreach (string _IdProduto in _Database.Select("Encomendas_Telefone", "Produtos", $"ID = {_IdEncomenda}")[0].Split(','))
					{
						_ListBoxProdutos.Items.Add(_Database.Select("Produtos", "Nome", $"ID = {_IdProduto}")[0]);
					}
					#endregion ListBox Produtos





					_Panel.Controls.Add(_LabelNome);
					_LabelNome.Location = new Point(0, 3);

					_Panel.Controls.Add(_TextBoxNome);
					_TextBoxNome.Location = new Point(3, 19);

					_Panel.Controls.Add(_LabelMorada);
					_LabelMorada.Location = new Point(0, 42);

					_Panel.Controls.Add(_TextBoxMorada);
					_TextBoxMorada.Location = new Point(3,58);

					_Panel.Controls.Add(_ButtonVer);
					_ButtonVer.Location = new Point(449, 63);

					_Panel.Controls.Add(_ButtonConcluir);
					_ButtonConcluir.Location = new Point(449, 39);

					_Panel.Controls.Add(_ButtonRemover);
					_ButtonRemover.Location = new Point(449, 15);

					_Panel.Controls.Add(_LabelProdutos);
					_LabelProdutos.Location = new Point(227, 1);

					_Panel.Controls.Add(_ListBoxProdutos);
					_ListBoxProdutos.Location = new Point(230, 17);

					flowLayoutPanel_encomendas.Controls.Add(_Panel);
				}
			}
			catch (Exception _Exception)
			{
				_Scripts7.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		private void _ButtonConcluirEncomendaClick(object sender, EventArgs e, int _IdEncomenda)
		{
			try
			{
				if (_MessageBox.ShowConfirmationDialog("Informação", "Deseja mesmo concluir a encomenda?", MessageBoxIcon.Information))
				{
					_Database.Update("Encomendas_Telefone", $"Nome = '{_Database.Select("Encomendas_Telefone", "Nome", $"ID = { _IdEncomenda}")[0]} [{_IdEncomenda}]', Concluida = 'True'", $"ID = {_IdEncomenda}");
					MessageBox.Show("A encomenda está concluída!");
					ListarEncomendas();
				}
			}
			catch (Exception _Exception)
			{
				_Scripts7.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		private void _ButtonVerEncomendaClick(object _Sender, EventArgs _Event, int _IdEncomenda)
		{
			try
			{
				if (!_Form.IsOpen("Encomenda"))
				{
					new Encomenda(_IdEncomenda).Show();
				}
				else
				{
					MessageBox.Show("Já existe um formulário de edição de encomendas aberto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			catch (Exception _Exception)
			{
				_Scripts7.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		private void _ButtonApagarEncomendaClick(object sender, EventArgs _Event, int _IdEncomenda)
		{
			try
			{
				if (_MessageBox.ShowConfirmationDialog("Apagar Encomenda", "Deseja mesmo apagar a encomenda?", MessageBoxIcon.Information) == true)
				{
					string[] _IdProdutos = _Database.Select("Encomendas_Telefone", "Produtos", $"ID = {_IdEncomenda}")[0].Split(',');
					foreach (string _IdProduto in _IdProdutos)
					{
						_Database.Update("Produtos", $"Quantidade = {Convert.ToInt32(_Database.Select("Produtos", "Quantidade", $"ID = {_IdProduto}")[0]) + 1}", $"ID = {_IdProduto}");
						Thread.Sleep(250);
					}

					_Database.Delete("Encomendas_Telefone", $"ID = {_IdEncomenda}");
					MessageBox.Show("Encomenda apagada.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

				Valores._Main.ListarProdutos();
				Valores._Main.ListarEncomendas();
			}
			catch (Exception _Exception)
			{
				_Scripts7.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		#endregion Listar Encomendas

		#region Listar Produtos
		// # ================================================================================================ #
		public void ListarProdutos()
		{
			try
			{
				flowLayoutPanel_produtos.Controls.Clear();

				List<string> _Produtos = _Database.Select("Produtos", "ID");
				if (_Produtos.Count > 0)
				{
					if (!String.IsNullOrEmpty(_Produtos[0]))
					{
						foreach (string _IdProduto in _Produtos)
						{
							int _Id = Convert.ToInt32(_IdProduto);



							#region Panel
							Panel _Panel = new Panel();
							_Panel.Size = new Size(98, 124);
							_Panel.BorderStyle = BorderStyle.FixedSingle;

							int _Stock = Convert.ToInt32(_Database.Select("Produtos", "Quantidade", $"ID = {_IdProduto}")[0]);
							if (_Stock < 1)
							{
								_Panel.BackColor = Color.Black;
							}
							else if (_Stock < 15)
							{
								_Panel.BackColor = Color.Red;
							}
							else if (_Stock < 20)
							{
								_Panel.BackColor = Color.Yellow;
							}
							else if (_Stock >= 100)
							{
								_Panel.BackColor = Color.White;
							}
							else
							{
								_Panel.BackColor = Color.Green;
							}
							#endregion Panel

							#region PictureBox
							PictureBox _PictureBox = new PictureBox();
							_PictureBox.Size = new Size(90, 90);
							_PictureBox.BorderStyle = BorderStyle.Fixed3D;
							_PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

							int _IdImagem = 0;
							List<string> _Imagens = _Database.Select("Produtos", "Imagem", $"ID = {_Id}");
							if (_Imagens != null)
							{
								if (!String.IsNullOrEmpty(_Imagens[0]))
								{
									_IdImagem = Convert.ToInt32(_Imagens[0]);
								}
							}

							_PictureBox.Image = Image.FromFile(Valores._CaminhoImagensProdutos + $"{_IdImagem}.png");
							#endregion PictureBox

							#region Button
							Button _Button = new Button();
							_Button.AutoEllipsis = true;
							_Button.Size = new Size(91, 23);
							_Button.Text = _Database.Select("Produtos", "Nome", $"ID = {_Id}")[0];
							_Button.Click += new EventHandler((_Sender, _Event) => _ButtonProdutoClick(_Sender, _Event, _Id));
							_Button.BackColor = SystemColors.Control;
							#endregion Button



							_Panel.Controls.Add(_PictureBox);
							_Panel.Controls.Add(_Button);
							_PictureBox.Location = new Point(3, 4);
							_Button.Location = new Point(2, 96);
							flowLayoutPanel_produtos.Controls.Add(_Panel);
						}
					}
				}
			}
			catch (Exception _Exception)
			{
				_Scripts7.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		private void _ButtonProdutoClick(object _Sender, EventArgs _Event, int _Id)
		{
			try
			{
				new Produto(_Id).Show();
			}
			catch (Exception _Exception)
			{
				_Scripts7.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		#endregion Listar Produtos

		//#region Listar Utilizador
		//// # ================================================================================================ #
		//public void ListarUtilizadores()
		//{
		//	try
		//	{
		//		// flowLayoutPanel_utilizadores.Controls.Clear();

		//		List<string> _Utilizadores = _Database.Select("Utilizadores", "ID");
		//		if (_Utilizadores.Count > 0)
		//		{
		//			if (!String.IsNullOrEmpty(_Utilizadores[0]))
		//			{
		//				foreach (string _IdUtilizador in _Utilizadores)
		//				{
		//					int _Id = Convert.ToInt32(_IdUtilizador);

		//					#region Panel
		//					Panel _Panel = new Panel();
		//					_Panel.Size = new Size(510, 149);
		//					_Panel.BorderStyle = BorderStyle.FixedSingle;
		//					#endregion Panel

		//					#region Labels
		//					Label _LabelId = new Label();
		//					_LabelId.Text = "ID:";

		//					Label _LabelNome = new Label();
		//					_LabelNome.Text = "Nome:";

		//					Label _LabelMorada = new Label();
		//					_LabelMorada.Text = "Morada:";

		//					Label _LabelEmail = new Label();
		//					_LabelEmail.Text = "E-mail:";

		//					Label _LabelLogin = new Label();
		//					_LabelLogin.Text = "Login:";

		//					Label _LabelCarrinho = new Label();
		//					_LabelCarrinho.Text = "Carrinho:";
		//					#endregion Labels

		//					#region TextBoxes
		//					TextBox _TextBoxID = new TextBox();
		//					_TextBoxID.Text = _Id.ToString();
		//					_TextBoxID.Size = new Size(386, 20);
		//					_TextBoxID.ReadOnly = true;
		//					#endregion TextBoxes

		//					#region Button
		//					Button _Button = new Button();
		//					_Button.AutoEllipsis = true;
		//					_Button.Size = new Size(91, 23);
		//					_Button.Text = "Editar";
		//					_Button.Click += new EventHandler((_Sender, _Event) => _ButtonUtilizadorClick(_Sender, _Event, _Id));
		//					#endregion Button




		//					_Panel.Controls.Add(_Button);
		//					_Button.Location = new Point(2, 96);

		//					_Panel.Controls.Add(_LabelId);
		//					_LabelId.Location = new Point(4, 7);
		//					_Panel.Controls.Add(_LabelNome);
		//					_LabelNome.Location = new Point(4, 31);
		//					_Panel.Controls.Add(_LabelMorada);
		//					_LabelMorada.Location = new Point(4, 55);
		//					_Panel.Controls.Add(_LabelEmail);
		//					_LabelEmail.Location = new Point(4, 79);
		//					_Panel.Controls.Add(_LabelLogin);
		//					_LabelLogin.Location = new Point(4, 103);
		//					_Panel.Controls.Add(_LabelCarrinho);
		//					_LabelCarrinho.Location = new Point(4, 127);

		//					_Panel.Controls.Add(_TextBoxID);
		//					_TextBoxID.Location = new Point(56, 3);

		//					// flowLayoutPanel_utilizadores.Controls.Add(_Panel);
		//				}
		//			}
		//		}
		//	}
		//	catch (Exception _Exception)
		//	{
		//		_Scripts7.Exception(_Exception);
		//	}
		//}
		//// # ================================================================================================ #
		//private void _ButtonUtilizadorClick(object sender, EventArgs @event, int id)
		//{

		//}
		//// # ================================================================================================ #
		//#endregion Listar Utilizador

		#region Listar Funcionarios
		// # ================================================================================================ #
		public void ListarFuncionarios()
		{
			try
			{
				flowLayoutPanel_funcionarios.Controls.Clear();

				List<string> _Funcionarios = _Database.Select("Funcionarios", "ID");
				if (_Funcionarios.Count > 0)
				{
					if (!String.IsNullOrEmpty(_Funcionarios[0]))
					{
						foreach (string _IdFuncionario in _Funcionarios)
						{
							int _Id = Convert.ToInt32(_IdFuncionario);





							#region Panel
							Panel _Panel = new Panel();
							_Panel.Size = new Size(98, 124);
							_Panel.BorderStyle = BorderStyle.FixedSingle;
							#endregion Panel

							#region PictureBox
							PictureBox _PictureBox = new PictureBox();
							_PictureBox.Size = new Size(90, 90);
							_PictureBox.BorderStyle = BorderStyle.Fixed3D;
							_PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

							int _IdImagem = 0;
							List<string> _Imagens = _Database.Select("Funcionarios", "Imagem", $"ID = {_Id}");
							if (_Imagens != null)
							{
								if (!String.IsNullOrEmpty(_Imagens[0]))
								{
									_IdImagem = Convert.ToInt32(_Imagens[0]);
								}
							}

							_PictureBox.Image = Image.FromFile(Valores._CaminhoImagensFuncionarios + $"{_IdImagem}.png");
							#endregion PictureBox

							#region Button
							Button _Button = new Button();
							_Button.AutoEllipsis = true;
							_Button.Size = new Size(91, 23);
							_Button.Text = _Database.Select("Funcionarios", "Nome", $"ID = {_Id}")[0];
							_Button.Click += new EventHandler((_Sender, _Event) => _ButtonFuncionarioClick(_Sender, _Event, _Id));
							if (_Id == Main._Id)
							{
								_Button.Enabled = false;
							}
							#endregion Button



							_Panel.Controls.Add(_PictureBox);
							_Panel.Controls.Add(_Button);
							_PictureBox.Location = new Point(3, 4);
							_Button.Location = new Point(2, 96);
							flowLayoutPanel_funcionarios.Controls.Add(_Panel);
						}
					}
				}
			}
			catch (Exception _Exception)
			{
				_Scripts7.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		private void _ButtonFuncionarioClick(object _Sender, EventArgs _Event, int _Id)
		{
			if (!_Form.IsOpen("Perfil"))
			{
				if (_Id != Main._Id)
				{
					new Perfil(_Id).Show();
				}
			}
			else
			{
				_Form.BringToFront("Perfil");
			}
		}
		// # ================================================================================================ #
		#endregion Listar Funcionarios
		#endregion Listar

		#region Load / Unload
		// # ================================================================================================ #
		public Main(int? _IdUtilizador)
		{
			try
			{
				InitializeComponent();

				#region Carregar Utilizador
				if (_IdUtilizador != null)
				{
					_Id = Convert.ToInt32(_IdUtilizador);
					textBox_utilizador.Text = _Database.Select("Funcionarios", "Nome", $"ID = {_Id}")[0];

					int _IdImagem = Convert.ToInt32(_Database.Select("Funcionarios", "Imagem", $"ID = {_Id}")[0]);
					if (File.Exists(Valores._CaminhoImagensFuncionarios + $"{_IdImagem}.png"))
					{
						pictureBox_utilizador.Image = Image.FromFile(Valores._CaminhoImagensFuncionarios + $"{_IdImagem}.png");
					}

					string _Permissoes = _Database.Select("Funcionarios", "Permissoes", $"ID = {_Id}")[0];

					if (_Permissoes != "administrador")
					{
						tabs.TabPages.Remove(tab_funcionarios);
					}
				}
				#endregion Carregar Utilizador
			}
			catch (Exception _Exception)
			{
				_Scripts7.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		private void Main_Load(object sender, EventArgs e)
		{
			ListarEncomendas();
			ListarProdutos();
			//ListarUtilizadores();
			ListarFuncionarios();
		}
		// # ================================================================================================ #
		private void Main_FormClosed(object sender, FormClosedEventArgs e)
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
		#endregion Load / Unload













		#region Perfil
		// # ================================================================================================ #
		private void button_perfil_Click(object sender, EventArgs e)
		{
			try
			{
				if (!_Form.IsOpen("Perfil"))
				{
					new Perfil(_Id).Show();
				}
				else
				{
					_Form.BringToFront("Perfil");
				}
			}
			catch (Exception _Exception)
			{
				_Scripts7.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		private void timer_data_Tick(object sender, EventArgs e)
		{
			try
			{
				label_data.Text = _Tools.GetDate();
			}
			catch (Exception _Exception)
			{
				_Scripts7.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		private void button_sair_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (Form _Form in _Form.GetOpenForms())
				{
					if (_Form.Name != "Main")
					{
						_Form.Hide();
					}
				}

				new Login().Show();
				this.Hide();
			}
			catch (Exception _Exception)
			{
				_Scripts7.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		#endregion Perfil



		#region Ações
		// # ================================================================================================ #
		private void button_adicionarUtilizador_Click(object sender, EventArgs e)
		{
			try
			{
				new Adicionar(0).Show();
			}
			catch (Exception _Exception)
			{
				_Scripts7.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		private void button_adicionarProduto_Click(object sender, EventArgs e)
		{
			try
			{
				new Adicionar(1).Show();
			}
			catch (Exception _Exception)
			{
				_Scripts7.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		private void button_procurar_Click(object sender, EventArgs e)
		{
			try
			{
				new Procurar().Show();
			}
			catch (Exception _Exception)
			{
				_Scripts7.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		private void button_criarEncomenda_Click(object sender, EventArgs e)
		{
			try
			{
				new Encomenda(null).Show();
			}
			catch (Exception _Exception)
			{
				_Scripts7.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		#endregion Ações
	}
}