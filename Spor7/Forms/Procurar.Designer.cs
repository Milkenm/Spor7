namespace Spor7.Forms
{
	partial class Procurar
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Procurar));
			this.textBox_pesquisa = new System.Windows.Forms.TextBox();
			this.radioButton_encomendas = new System.Windows.Forms.RadioButton();
			this.radioButton_produtos = new System.Windows.Forms.RadioButton();
			this.radioButton_utilizadores = new System.Windows.Forms.RadioButton();
			this.radioButton_funcionarios = new System.Windows.Forms.RadioButton();
			this.listBox_procura = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// textBox_pesquisa
			// 
			this.textBox_pesquisa.Location = new System.Drawing.Point(12, 12);
			this.textBox_pesquisa.Name = "textBox_pesquisa";
			this.textBox_pesquisa.Size = new System.Drawing.Size(322, 20);
			this.textBox_pesquisa.TabIndex = 0;
			this.textBox_pesquisa.TextChanged += new System.EventHandler(this.textBox_procura_TextChanged);
			// 
			// radioButton_encomendas
			// 
			this.radioButton_encomendas.AutoSize = true;
			this.radioButton_encomendas.Checked = true;
			this.radioButton_encomendas.Location = new System.Drawing.Point(12, 38);
			this.radioButton_encomendas.Name = "radioButton_encomendas";
			this.radioButton_encomendas.Size = new System.Drawing.Size(87, 17);
			this.radioButton_encomendas.TabIndex = 1;
			this.radioButton_encomendas.TabStop = true;
			this.radioButton_encomendas.Text = "Encomendas";
			this.radioButton_encomendas.UseVisualStyleBackColor = true;
			this.radioButton_encomendas.CheckedChanged += new System.EventHandler(this.AtualizarPesquisa);
			// 
			// radioButton_produtos
			// 
			this.radioButton_produtos.AutoSize = true;
			this.radioButton_produtos.Location = new System.Drawing.Point(99, 38);
			this.radioButton_produtos.Name = "radioButton_produtos";
			this.radioButton_produtos.Size = new System.Drawing.Size(67, 17);
			this.radioButton_produtos.TabIndex = 2;
			this.radioButton_produtos.Text = "Produtos";
			this.radioButton_produtos.UseVisualStyleBackColor = true;
			this.radioButton_produtos.CheckedChanged += new System.EventHandler(this.AtualizarPesquisa);
			// 
			// radioButton_utilizadores
			// 
			this.radioButton_utilizadores.AutoSize = true;
			this.radioButton_utilizadores.Enabled = false;
			this.radioButton_utilizadores.Location = new System.Drawing.Point(166, 38);
			this.radioButton_utilizadores.Name = "radioButton_utilizadores";
			this.radioButton_utilizadores.Size = new System.Drawing.Size(79, 17);
			this.radioButton_utilizadores.TabIndex = 3;
			this.radioButton_utilizadores.Text = "Utilizadores";
			this.radioButton_utilizadores.UseVisualStyleBackColor = true;
			this.radioButton_utilizadores.CheckedChanged += new System.EventHandler(this.AtualizarPesquisa);
			// 
			// radioButton_funcionarios
			// 
			this.radioButton_funcionarios.AutoSize = true;
			this.radioButton_funcionarios.Location = new System.Drawing.Point(245, 38);
			this.radioButton_funcionarios.Name = "radioButton_funcionarios";
			this.radioButton_funcionarios.Size = new System.Drawing.Size(85, 17);
			this.radioButton_funcionarios.TabIndex = 5;
			this.radioButton_funcionarios.Text = "Funcionários";
			this.radioButton_funcionarios.UseVisualStyleBackColor = true;
			this.radioButton_funcionarios.CheckedChanged += new System.EventHandler(this.AtualizarPesquisa);
			// 
			// listBox_procura
			// 
			this.listBox_procura.FormattingEnabled = true;
			this.listBox_procura.Location = new System.Drawing.Point(12, 61);
			this.listBox_procura.Name = "listBox_procura";
			this.listBox_procura.Size = new System.Drawing.Size(322, 303);
			this.listBox_procura.TabIndex = 6;
			this.listBox_procura.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_procura_MouseDoubleClick);
			// 
			// Procurar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(346, 384);
			this.Controls.Add(this.listBox_procura);
			this.Controls.Add(this.radioButton_funcionarios);
			this.Controls.Add(this.radioButton_utilizadores);
			this.Controls.Add(this.radioButton_produtos);
			this.Controls.Add(this.radioButton_encomendas);
			this.Controls.Add(this.textBox_pesquisa);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Procurar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Procurar";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox_pesquisa;
		private System.Windows.Forms.RadioButton radioButton_encomendas;
		private System.Windows.Forms.RadioButton radioButton_produtos;
		private System.Windows.Forms.RadioButton radioButton_utilizadores;
		private System.Windows.Forms.RadioButton radioButton_funcionarios;
		private System.Windows.Forms.ListBox listBox_procura;
	}
}