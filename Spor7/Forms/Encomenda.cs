using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScriptsLib.Controls;
using ScriptsLib.Databases;
using ScriptsLib.Tools;

namespace Spor7.Forms
{
	public partial class Encomenda : Form
	{
		#region Refs
		// # ================================================================================================ #
		AccessDatabase _Database = new AccessDatabase();
		Scripts7 _Scripts7 = new Scripts7();
		Tools _Tools = new Tools();
		Controls.MessageBox _MessageBox = new Controls.MessageBox();
		// # ================================================================================================ #
		#endregion Refs

		#region Vars
		static int? _IdEncomenda { get; set; }

		static string _Nome { get; set; }
		static int _Idade { get; set; }
		static string _Morada { get; set; }
		static List<string> _Carrinho { get; set; }
		static decimal _Preco { get; set; }
		static string _Notas { get; set; }
		#endregion Vars

		#region Load
		// # ================================================================================================ #
		public Encomenda(int? _IdEncomenda)
		{
			try
			{
				InitializeComponent();

				textBox_pesquisa.Text = " ";
				textBox_pesquisa.Text = "";

				Encomenda._IdEncomenda = null;
				if (_IdEncomenda != null)
				{
					Encomenda._IdEncomenda = _IdEncomenda;
					button_criar.Text = "Atualizar";

					textBox_nome.Text = _Database.Select("Encomendas_Telefone", "Nome", $"ID = {_IdEncomenda}")[0];
					numeric_idade.Value = Convert.ToInt32(_Database.Select("Encomendas_Telefone", "Idade", $"ID = {_IdEncomenda}")[0]);
					textBox_morada.Text = _Database.Select("Encomendas_Telefone", "Morada", $"ID = {_IdEncomenda}")[0];
					
					if (_Database.Select("Encomendas_Telefone", "Concluida", $"ID = {_IdEncomenda}")[0] == "True")
					{
						checkBox_concluida.Checked = true;
					}

					try
					{
						List<string> _UpdateCarrinho = new List<string>();
						foreach (string _IdProduto in _Database.Select("Encomendas_Telefone", "Produtos", $"ID = {_IdEncomenda}")[0].Split(','))
						{
							string _Produto = _Database.Select("Produtos", "Nome", $"ID = {_IdProduto}")[0];

							_UpdateCarrinho.Add(_Produto);
							listBox_carrinho.Items.Add(_Produto);
						}
						_Carrinho = _UpdateCarrinho;
					}
					catch
					{
						MessageBox.Show("Houve um erro ao selecionar todos os produtos (talvez já não exista?).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						this.Close();
					}

					numeric_preco.Value = Convert.ToDecimal(_Database.Select("Encomendas_Telefone", "Preco", $"ID = {_IdEncomenda}")[0]);

					try
					{
						textBox_notas.Text = _Database.Select("Encomendas_Telefone", "Notas", $"ID = {_IdEncomenda}")[0];
					}
					catch
					{
						_Notas = "";
					}
				}
				else
				{
					button_apagar.Visible = false;
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
		private void button_criar_Click(object sender, EventArgs e)
		{
			try
			{
				if (button_criar.Text == "Criar Encomenda")
				{
					#region Erro
					bool _Erro = false;

					if (String.IsNullOrEmpty(textBox_nome.Text))
					{
						_Erro = true;
						errorProvider.SetError(textBox_nome, "Insira o nome do comprador.");
					}
					if (String.IsNullOrEmpty(textBox_morada.Text))
					{
						_Erro = true;
						errorProvider.SetError(textBox_morada, "Insira a morada de entrega.");
					}
					if (listBox_carrinho.Items.Count < 1)
					{
						_Erro = true;
						errorProvider.SetError(listBox_carrinho, "O carrinho não tem produtos.");
					}
					#endregion Erro


					if (_Erro == false)
					{
						#region Sacar ID dos Produtos do Carrinho
						string _IdProdutos = null;
						foreach (string _Produto in listBox_carrinho.Items)
						{
							string _IdProduto = _Database.Select("Produtos", "ID", $"Nome = '{_Produto}'")[0];

							if (_IdProdutos == null)
							{
								_IdProdutos = _IdProduto;
							}
							else
							{
								_IdProdutos = $"{_IdProdutos},{_IdProduto}";
							}

							_Database.Update("Produtos", $"Quantidade = {Convert.ToInt32(_Database.Select("Produtos", "Quantidade", $"ID = {_IdProduto}")[0]) - 1}", $"ID = {_IdProduto}");
						}
						#endregion Sacar ID dos Produtos do Carrinho

						_Database.InsertInto("Encomendas_Telefone", "Funcionario,Produtos,Nome,Idade,Morada,Data,Preco,Notas,Concluida", $"'{Temp._IdFuncionario}','{_IdProdutos}','{textBox_nome.Text}','{numeric_idade.Value}','{textBox_morada.Text}','{_Tools.GetDate()}','{numeric_preco.Value}','{textBox_notas.Text}','{checkBox_concluida.Checked.ToString()}'");
						MessageBox.Show("Encomenda criada.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
						
						Valores._Main.ListarProdutos();
						Valores._Main.ListarEncomendas();
						this.Close();
					}
				}
				else if (button_criar.Text == "Atualizar")
				{
					#region Erro
					bool _Erro = false;

					if (String.IsNullOrEmpty(textBox_nome.Text))
					{
						_Erro = true;
						errorProvider.SetError(textBox_nome, "Insira o nome do comprador.");
					}
					if (String.IsNullOrEmpty(textBox_morada.Text))
					{
						_Erro = true;
						errorProvider.SetError(textBox_morada, "Insira a morada de entrega.");
					}
					if (listBox_carrinho.Items.Count < 1)
					{
						_Erro = true;
						errorProvider.SetError(listBox_carrinho, "O carrinho não tem produtos.");
					}
					#endregion Erro


					if (_Erro == false)
					{
						string _StringProdutos = null;
						foreach (string _Produto in listBox_carrinho.Items)
						{
							int _IdProduto = Convert.ToInt32(_Database.Select("Produtos", "ID", $"Nome = '{_Produto}'")[0]);

							int _Quantidade = Convert.ToInt32(_Database.Select("Produtos", "Quantidade", $"ID = {_IdProduto}")[0]) + 1;
							_Database.Update("Produtos", $"Quantidade = {_Quantidade}", $"ID = {_IdProduto}");


							if (String.IsNullOrEmpty(_StringProdutos))
							{
								_StringProdutos = _IdProduto.ToString();
							}
							else
							{
								_StringProdutos = $"{_StringProdutos},{_IdProduto}";
							}
						}
						
						List<string> _ProdutosListCarrinhos = new List<string>();
						foreach (string _Produto in listBox_carrinho.Items)
						{
							_ProdutosListCarrinhos.Add(_Produto);
						}
						
						if (textBox_nome.Text != _Nome || numeric_idade.Value != _Idade || textBox_morada.Text != _Morada || _Carrinho != _ProdutosListCarrinhos || textBox_notas.Text != _Notas || numeric_preco.Value != _Preco)
						{
							_Database.Update("Encomendas_Telefone", $"Nome = '{textBox_nome.Text}', Idade = '{numeric_idade.Value}', Morada = '{textBox_morada.Text}', Produtos = '{_StringProdutos}', Preco = '{numeric_preco.Value}', Notas = '{textBox_notas.Text}', Concluida = '{checkBox_concluida.Checked.ToString()}'", $"ID = {_IdEncomenda}");
							MessageBox.Show("Encomenda atualizada.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}

						Valores._Main.ListarProdutos();
						Valores._Main.ListarEncomendas();
						this.Close();
					}
				}
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
				if (_MessageBox.ShowConfirmationDialog("Apagar Encomenda", "Deseja mesmo apagar a encomenda selecionada?", MessageBoxIcon.Information) == true)
				{
					string[] _IdProdutos = _Database.Select("Encomendas_Telefone", "Produtos", $"ID = {_IdEncomenda}")[0].Split(',');
					foreach (string _IdProduto in _IdProdutos)
					{
						_Database.Update("Produtos", $"Quantidade = {Convert.ToInt32(_Database.Select("Produtos", "Quantidade", $"ID = {_IdProduto}")[0]) + 1}", $"ID = {_IdProduto}");
						Thread.Sleep(250);
					}

					_Database.Delete("Encomendas_Telefone", $"ID = {_IdEncomenda}");
					MessageBox.Show("Encomenda apagada.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();
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
		#endregion Botões

		#region Pesquisa
		// # ================================================================================================ #
		private void textBox_pesquisa_TextChanged(object sender, EventArgs e)
		{
			try
			{
				listBox_procura.Items.Clear();
				listBox_procura.Enabled = true;

				if (String.IsNullOrEmpty(textBox_pesquisa.Text) || String.IsNullOrWhiteSpace(textBox_pesquisa.Text))
				{
					foreach (string _Produto in _Database.Select("Produtos", "Nome"))
					{
						listBox_procura.Items.Add(_Produto);
					}
					return;
				}
				else
				{
					listBox_procura.Items.Clear();
				}

				List<string> _Procura = _Database.Select("Produtos", "Nome", $"ID like '%{textBox_pesquisa.Text}%' or Nome like '%{textBox_pesquisa.Text}%' or Preco like '%{textBox_pesquisa.Text}%' or Referencia like '%{textBox_pesquisa.Text}%' or Categoria like '%{textBox_pesquisa.Text}%' or Imagem like '%{textBox_pesquisa.Text}%' or Quantidade like '%{textBox_pesquisa.Text}%'");
				bool _Existe = false;

				if (_Procura != null)
				{
					foreach (string _Produto in _Procura)
					{
						listBox_procura.Items.Add(_Produto);
						_Existe = true;
					}
				}

				if (_Existe == false)
				{
					listBox_procura.Enabled = false;
					listBox_procura.Items.Add("Nenhum produto encontrado.");
				}
			}
			catch (Exception _Exception)
			{
				_Scripts7.Exception(_Exception);
			}
		}
		// # ================================================================================================ #
		#endregion Pesquisa

		#region Adicionar Produto
		// # ================================================================================================ #
		private void button_porCarrinho_Click(object sender, EventArgs e)
		{
			if (listBox_procura.SelectedItem != null && !String.IsNullOrEmpty(listBox_procura.Text))
			{
				listBox_carrinho.Items.Add(listBox_procura.SelectedItem);

				decimal _Preco = Convert.ToDecimal(_Database.Select("Produtos", "Preco", $"Nome = '{listBox_procura.Text}'")[0]);
				numeric_preco.Value = numeric_preco.Value + _Preco;
			}
		}
		// # ================================================================================================ #
		#endregion Adicionar Produto

		#region Remover Produto
		// # ================================================================================================ #
		private void button_tirarCarrinho_Click(object sender, EventArgs e)
		{
			if (listBox_carrinho.SelectedItem != null && !String.IsNullOrEmpty(listBox_carrinho.Text))
			{
				decimal _Preco = Convert.ToDecimal(_Database.Select("Produtos", "Preco", $"Nome = '{listBox_carrinho.Text}'")[0]);
				numeric_preco.Value = numeric_preco.Value - _Preco;

				listBox_carrinho.Items.Remove(listBox_carrinho.SelectedItem);
			}
		}
		// # ================================================================================================ #
		#endregion Remover Produto
	}
}
