using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScriptsLib.Controls;
using ScriptsLib.Databases;

namespace Spor7.Forms
{
	public partial class Procurar : Form
	{
		#region Refs
		// # ================================================================================================ #
		Scripts7 _Scripts7 = new Scripts7();
		AccessDatabase _Database = new AccessDatabase();
		Controls.Form _Form = new Controls.Form();
		// # ================================================================================================ #
		#endregion Refs

		#region Enums
		// # ================================================================================================ #
		public enum TipoDeProcura
		{
			Encomenda,
			Produto,
			Utilizador,
			Funcionario,
		}
		// # ================================================================================================ #
		#endregion Enums
			
		#region Load
		public Procurar(string _Procura = null, TipoDeProcura? _TipoDeProcura = null)
		{
			try
			{
				InitializeComponent();
				
				if (_Database.Select("Funcionarios", "Permissoes", $"ID = { Temp._IdFuncionario}")[0] != "administrador")
				{
					radioButton_funcionarios.Visible = false;
				}

				if (_Procura != null && _TipoDeProcura != null)
				{
					if (_TipoDeProcura == TipoDeProcura.Encomenda)
					{
						radioButton_encomendas.Checked = true;
					}
					else if (_TipoDeProcura == TipoDeProcura.Produto)
					{
						radioButton_produtos.Checked = true;
					}
					else if (_TipoDeProcura == TipoDeProcura.Utilizador)
					{
						radioButton_utilizadores.Checked = true;
					}
					else if (_TipoDeProcura == TipoDeProcura.Funcionario)
					{
						radioButton_funcionarios.Checked = true;
					}
					
					textBox_pesquisa.Text = _Procura;
				}
			}
			catch (Exception _Exception)
			{
				_Scripts7.Exception(_Exception);
			}
		}
		#endregion Load









		#region Procura
		private void textBox_procura_TextChanged(object sender, EventArgs e)
		{
			listBox_procura.Items.Clear();
			listBox_procura.Enabled = false;

			if (String.IsNullOrEmpty(textBox_pesquisa.Text) || String.IsNullOrWhiteSpace(textBox_pesquisa.Text))
			{
				return;
			}

			if (radioButton_encomendas.Checked == true)
			{
				List<string> _Procura = _Database.Select("Encomendas_Telefone", "Nome", $"ID like '%{textBox_pesquisa.Text}%' or Funcionario like '%{textBox_pesquisa.Text}%' or Produtos like '%{textBox_pesquisa.Text}%' or Nome like '%{textBox_pesquisa.Text}%' or Idade like '%{textBox_pesquisa.Text}%' or Morada like '%{textBox_pesquisa.Text}%' or Data like '%{textBox_pesquisa.Text}%' or Notas like '%{textBox_pesquisa.Text}%'");
				bool _Existe = false;

				if (_Procura != null)
				{
					foreach (string _Encomenda in _Procura)
					{
						listBox_procura.Items.Add(_Encomenda);
						_Existe = true;
					}
				}

				if (_Existe == true)
				{
					listBox_procura.Enabled = true;
				}
				else
				{
					listBox_procura.Items.Add("Nenhuma encomenda encontrada.");
				}
			}
			else if (radioButton_produtos.Checked == true)
			{
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

				if (_Existe == true)
				{
					listBox_procura.Enabled = true;
				}
				else
				{
					listBox_procura.Items.Add("Nenhum produto encontrado.");
				}
			}
			else if (radioButton_utilizadores.Checked == true)
			{
				List<string> _Procura = _Database.Select("Utilizadores", "Nome", $"ID like '%{textBox_pesquisa.Text}%' or Nome like '%{textBox_pesquisa.Text}%' or Morada like '%{textBox_pesquisa.Text}%' or Email like '%{textBox_pesquisa.Text}%' or Login like '%{textBox_pesquisa.Text}%'");
				bool _Existe = false;

				if (_Procura != null)
				{
					foreach (string _Utilizador in _Procura)
					{
						listBox_procura.Items.Add(_Utilizador);
						_Existe = true;
					}
				}

				if (_Existe == true)
				{
					listBox_procura.Enabled = true;
				}
				else
				{
					listBox_procura.Items.Add("Nenhum utilizador encontrado.");
				}
			}
			else if (radioButton_funcionarios.Checked == true)
			{
				List<string> _Procura = _Database.Select("Funcionarios", "Nome", $"ID like '%{textBox_pesquisa.Text}%' or Nome like '%{textBox_pesquisa.Text}%' or Morada like '%{textBox_pesquisa.Text}%' or Email like '%{textBox_pesquisa.Text}%' or Contacto like '%{textBox_pesquisa.Text}%' or NIB like '%{textBox_pesquisa.Text}%' or Idade like '%{textBox_pesquisa.Text}%' or Login like '%{textBox_pesquisa.Text}%'");
				bool _Existe = false;

				if (_Procura != null)
				{
					foreach (string _Funcionario in _Procura)
					{
						listBox_procura.Items.Add(_Funcionario);
						_Existe = true;
					}
				}

				if (_Existe == true)
				{
					listBox_procura.Enabled = true;
				}
				else
				{
					listBox_procura.Items.Add("Nenhum funcionario encontrado.");
				}
			}
		}
		#endregion Procura

		#region Info Item
		private void listBox_procura_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			int _Index = listBox_procura.IndexFromPoint(e.Location);
			if (_Index != ListBox.NoMatches)
			{
				if (radioButton_encomendas.Checked == true)
				{
					new Encomenda(Convert.ToInt32(_Database.Select("Encomendas_Telefone", "ID", $"Nome = '{listBox_procura.Text}'")[0])).Show();
				}
				else if (radioButton_produtos.Checked == true)
				{
					new Produto(Convert.ToInt32(_Database.Select("Produtos", "ID", $"Nome = '{listBox_procura.Text}'")[0])).Show();
				}
				else if (radioButton_funcionarios.Checked == true)
				{
					string _IdFuncionario = _Database.Select("Funcionarios", "ID", $"Nome = '{listBox_procura.Text}'")[0];

					if (!_Form.IsOpen("Perfil"))
					{
						new Perfil(Convert.ToInt32(_IdFuncionario)).Show();
					}
					else
					{
						MessageBox.Show("Já existe um perfil aberto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
				}
			}
		}
		#endregion Info Item

		#region Atualizar Pesquisa
		private void AtualizarPesquisa(object sender, EventArgs e)
		{
			string _Text = textBox_pesquisa.Text;
			textBox_pesquisa.Text = "";
			textBox_pesquisa.Text = _Text;
		}
		#endregion Atualizar Pesquisa
	}
}
