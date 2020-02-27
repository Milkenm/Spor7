#region Usings
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using ScriptsLib.Controls;
using ScriptsLib.Databases;
using ScriptsLib.Tools;
#endregion Usings



namespace Spor7.Forms
{
	public partial class Produto : Form
	{
		#region Refs
		// # ================================================================================================ #
		AccessDatabase _Database = new AccessDatabase();
		Tools _Tools = new Tools();
		// # ================================================================================================ #
		Controls.Form _Form = new Controls.Form();
		// # ================================================================================================ #
		Scripts7 _Scripts7 = new Scripts7();
		// # ================================================================================================ #
		Controls.MessageBox _MessageBox = new Controls.MessageBox();
		// # ================================================================================================ #
		#endregion Refs

		#region Vars
		static int _IdProduto { get; set; }

		static string _Produto { get; set; }
		static int _Referencia { get; set; }
		static string _Categoria { get; set; }
		static int _Quantidade { get; set; }
		static decimal _Preco { get; set; }
		static Image _Imagem { get; set; }
		static int _NumeroDeEncomendas { get; set; }
		#endregion Vars

		#region Load
		// # ================================================================================================ #
		public Produto(int? _IdProduto)
		{
			try
			{
				InitializeComponent();

				_NumeroDeEncomendas = 0;

				if (_IdProduto != null)
				{
					Produto._IdProduto = Convert.ToInt32(_IdProduto);

					List<string> _Imagem = _Database.Select("Produtos", "Imagem", $"ID = {_IdProduto}");
					if (_Imagem.Count > 0)
					{
						if (!String.IsNullOrEmpty(_Imagem[0]))
						{
							if (File.Exists(Valores._CaminhoImagensProdutos + _Imagem[0] + ".png"))
							{
								Produto._Imagem = Image.FromFile(Valores._CaminhoImagensProdutos + _Imagem[0] + ".png");
								pictureBox_produto.Image = Produto._Imagem;
							}
						}
					}
					


					_Produto = _Database.Select("Produtos", "Nome", $"ID = {_IdProduto}")[0];
					textBox_produto.Text = _Produto;

					_Referencia = Convert.ToInt32(_Database.Select("Produtos", "Referencia", $"ID = {_IdProduto}")[0]);
					textBox_referencia.Text = _Referencia.ToString();

					_Categoria = _Database.Select("Produtos", "Categoria", $"ID = {_IdProduto}")[0];
					comboBox_categoria.Text = _Categoria;

					_Quantidade = Convert.ToInt32(_Scripts7.ValorZero(_Database.Select("Produtos", "Quantidade", $"ID = {_IdProduto}")));
					numeric_quantidade.Value = _Quantidade;

					_Preco = Convert.ToDecimal(_Database.Select("Produtos", "Preco", $"ID = {_IdProduto}")[0]);
					numeric_preco.Value = _Preco;

					List<string> _Encomendas = _Database.Select("Encomendas_Telefone", "Produtos");
					foreach (string _Produtos in _Encomendas)
					{
						foreach (string _Produto in _Produtos.Split(','))
						{
							if (Convert.ToInt32(_Produto) == _IdProduto)
							{
								_NumeroDeEncomendas++;
								break;
							}
						}
					}



					#region Regex
					Regex _Regex = new Regex("<nome produto>");
					this.Text = _Regex.Replace(this.Text, _Produto);
					this.Text = $"{this.Text} (ID: {_IdProduto})";

					_Regex = new Regex("<numero>");
					link_encomendas.Text = _Regex.Replace(link_encomendas.Text, _NumeroDeEncomendas.ToString());
					_Regex = new Regex("<s>");
					if (_NumeroDeEncomendas == 1)
					{
						link_encomendas.Text = _Regex.Replace(link_encomendas.Text, "");
					}
					else
					{
						link_encomendas.Text = _Regex.Replace(link_encomendas.Text, "s");
					}
					#endregion Regex
				}
			}
			catch (Exception _Exception)
			{
				_Scripts7.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		#endregion Load










		#region Botões
		// # ================================================================================================ #
		private void button_ok_Click(object sender, EventArgs e)
		{
			try
			{
				if (textBox_produto.Text != _Produto || Convert.ToInt32(textBox_referencia.Text) != _Referencia || comboBox_categoria.Text != _Categoria || numeric_quantidade.Value != _Quantidade || numeric_preco.Value != _Preco || pictureBox_produto.Image != _Imagem)
				{
					_Database.Update("Produtos", $"Nome = '{textBox_produto.Text}', Referencia = '{textBox_referencia.Text}', Categoria = '{comboBox_categoria.Text}', Quantidade = '{numeric_quantidade.Value}', Preco = '{numeric_preco.Value}'", $"ID = {_IdProduto}");

					if (pictureBox_produto.Image != _Imagem)
					{
						string _IdImagem = _Scripts7.ValorZero(_Database.Select("Produtos", "MAX(Imagem)")).ToString() + 1;
						pictureBox_produto.Image.Save(Valores._CaminhoImagensProdutos + _IdImagem + ".png");

						_Database.Update("Produtos", $"Imagem = '{_IdImagem}'", $"ID = {_IdProduto}");
					}

					MessageBox.Show("Produto atualizado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Valores._Main.ListarProdutos();
				}
				this.Close();
			}
			catch (Exception _Exception)
			{
				_Scripts7.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		private void button_apagar_Click(object sender, EventArgs e)
		{
			try
			{
				if (_MessageBox.ShowConfirmationDialog("Apagar Produto?", $"Deseja mesmo apagar o produto '{_Produto} (ID: {_IdProduto})'?"))
				{
					_Database.Delete("Produtos", $"ID = {_IdProduto}");
					MessageBox.Show("Produto apagado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
		#endregion Botões

		#region Imagem
		// # ================================================================================================ #
		private void pictureBox_produto_Click(object sender, EventArgs e)
		{
			try
			{
				fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
				fileDialog.ShowDialog();
			}
			catch (Exception _Exception)
			{
				_Scripts7.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		private void fileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			try
			{
				if (!String.IsNullOrEmpty(fileDialog.FileName))
				{
					pictureBox_produto.Image = Image.FromFile(fileDialog.FileName);
				}
			}
			catch (Exception _Exception)
			{
				_Scripts7.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		#endregion Imagem

		#region Link Encomendas   
		private void link_encomendas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (_NumeroDeEncomendas > 0)
			{
				new Procurar(_IdProduto.ToString(), Procurar.TipoDeProcura.Produto).Show();
			}
		}
		#endregion Link Encomendas
	}
}
