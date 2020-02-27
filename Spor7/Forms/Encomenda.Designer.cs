namespace Spor7.Forms
{
	partial class Encomenda
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Encomenda));
			this.textBox_nome = new System.Windows.Forms.TextBox();
			this.textBox_morada = new System.Windows.Forms.TextBox();
			this.listBox_procura = new System.Windows.Forms.ListBox();
			this.listBox_carrinho = new System.Windows.Forms.ListBox();
			this.textBox_pesquisa = new System.Windows.Forms.TextBox();
			this.groupBox_procura = new System.Windows.Forms.GroupBox();
			this.groupBox_carrinho = new System.Windows.Forms.GroupBox();
			this.label_nome = new System.Windows.Forms.Label();
			this.label_idade = new System.Windows.Forms.Label();
			this.numeric_idade = new System.Windows.Forms.NumericUpDown();
			this.label_morada = new System.Windows.Forms.Label();
			this.button_criar = new System.Windows.Forms.Button();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.numeric_preco = new System.Windows.Forms.NumericUpDown();
			this.label_preco = new System.Windows.Forms.Label();
			this.label_notas = new System.Windows.Forms.Label();
			this.textBox_notas = new System.Windows.Forms.TextBox();
			this.label_simboloEuro = new System.Windows.Forms.Label();
			this.button_apagar = new System.Windows.Forms.Button();
			this.button_porCarrinho = new System.Windows.Forms.Button();
			this.button_tirarCarrinho = new System.Windows.Forms.Button();
			this.checkBox_concluida = new System.Windows.Forms.CheckBox();
			this.groupBox_procura.SuspendLayout();
			this.groupBox_carrinho.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numeric_idade)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_preco)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox_nome
			// 
			this.textBox_nome.Location = new System.Drawing.Point(12, 25);
			this.textBox_nome.Name = "textBox_nome";
			this.textBox_nome.Size = new System.Drawing.Size(303, 20);
			this.textBox_nome.TabIndex = 0;
			// 
			// textBox_morada
			// 
			this.textBox_morada.Location = new System.Drawing.Point(453, 25);
			this.textBox_morada.Name = "textBox_morada";
			this.textBox_morada.Size = new System.Drawing.Size(431, 20);
			this.textBox_morada.TabIndex = 2;
			// 
			// listBox_procura
			// 
			this.listBox_procura.FormattingEnabled = true;
			this.listBox_procura.Location = new System.Drawing.Point(9, 45);
			this.listBox_procura.Name = "listBox_procura";
			this.listBox_procura.Size = new System.Drawing.Size(405, 251);
			this.listBox_procura.TabIndex = 3;
			// 
			// listBox_carrinho
			// 
			this.listBox_carrinho.FormattingEnabled = true;
			this.listBox_carrinho.Location = new System.Drawing.Point(6, 19);
			this.listBox_carrinho.Name = "listBox_carrinho";
			this.listBox_carrinho.Size = new System.Drawing.Size(388, 277);
			this.listBox_carrinho.TabIndex = 4;
			// 
			// textBox_pesquisa
			// 
			this.textBox_pesquisa.Location = new System.Drawing.Point(9, 19);
			this.textBox_pesquisa.Name = "textBox_pesquisa";
			this.textBox_pesquisa.Size = new System.Drawing.Size(405, 20);
			this.textBox_pesquisa.TabIndex = 5;
			this.textBox_pesquisa.TextChanged += new System.EventHandler(this.textBox_pesquisa_TextChanged);
			// 
			// groupBox_procura
			// 
			this.groupBox_procura.Controls.Add(this.listBox_procura);
			this.groupBox_procura.Controls.Add(this.textBox_pesquisa);
			this.groupBox_procura.Location = new System.Drawing.Point(12, 58);
			this.groupBox_procura.Name = "groupBox_procura";
			this.groupBox_procura.Size = new System.Drawing.Size(420, 307);
			this.groupBox_procura.TabIndex = 7;
			this.groupBox_procura.TabStop = false;
			this.groupBox_procura.Text = "Pesquisa";
			// 
			// groupBox_carrinho
			// 
			this.groupBox_carrinho.Controls.Add(this.listBox_carrinho);
			this.groupBox_carrinho.Location = new System.Drawing.Point(484, 58);
			this.groupBox_carrinho.Name = "groupBox_carrinho";
			this.groupBox_carrinho.Size = new System.Drawing.Size(400, 307);
			this.groupBox_carrinho.TabIndex = 8;
			this.groupBox_carrinho.TabStop = false;
			this.groupBox_carrinho.Text = "No Carrinho";
			// 
			// label_nome
			// 
			this.label_nome.AutoSize = true;
			this.label_nome.Location = new System.Drawing.Point(9, 9);
			this.label_nome.Name = "label_nome";
			this.label_nome.Size = new System.Drawing.Size(35, 13);
			this.label_nome.TabIndex = 9;
			this.label_nome.Text = "Nome";
			// 
			// label_idade
			// 
			this.label_idade.AutoSize = true;
			this.label_idade.Location = new System.Drawing.Point(318, 9);
			this.label_idade.Name = "label_idade";
			this.label_idade.Size = new System.Drawing.Size(34, 13);
			this.label_idade.TabIndex = 10;
			this.label_idade.Text = "Idade";
			// 
			// numeric_idade
			// 
			this.numeric_idade.Location = new System.Drawing.Point(321, 25);
			this.numeric_idade.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
			this.numeric_idade.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
			this.numeric_idade.Name = "numeric_idade";
			this.numeric_idade.Size = new System.Drawing.Size(78, 20);
			this.numeric_idade.TabIndex = 11;
			this.numeric_idade.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
			// 
			// label_morada
			// 
			this.label_morada.AutoSize = true;
			this.label_morada.Location = new System.Drawing.Point(450, 9);
			this.label_morada.Name = "label_morada";
			this.label_morada.Size = new System.Drawing.Size(43, 13);
			this.label_morada.TabIndex = 12;
			this.label_morada.Text = "Morada";
			// 
			// button_criar
			// 
			this.button_criar.Location = new System.Drawing.Point(780, 429);
			this.button_criar.Name = "button_criar";
			this.button_criar.Size = new System.Drawing.Size(104, 23);
			this.button_criar.TabIndex = 13;
			this.button_criar.Text = "Criar Encomenda";
			this.button_criar.UseVisualStyleBackColor = true;
			this.button_criar.Click += new System.EventHandler(this.button_criar_Click);
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// numeric_preco
			// 
			this.numeric_preco.DecimalPlaces = 2;
			this.numeric_preco.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.numeric_preco.Location = new System.Drawing.Point(780, 380);
			this.numeric_preco.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this.numeric_preco.Name = "numeric_preco";
			this.numeric_preco.ReadOnly = true;
			this.numeric_preco.Size = new System.Drawing.Size(98, 20);
			this.numeric_preco.TabIndex = 14;
			// 
			// label_preco
			// 
			this.label_preco.AutoSize = true;
			this.label_preco.Location = new System.Drawing.Point(777, 367);
			this.label_preco.Name = "label_preco";
			this.label_preco.Size = new System.Drawing.Size(31, 13);
			this.label_preco.TabIndex = 15;
			this.label_preco.Text = "Total";
			// 
			// label_notas
			// 
			this.label_notas.AutoSize = true;
			this.label_notas.Location = new System.Drawing.Point(12, 377);
			this.label_notas.Name = "label_notas";
			this.label_notas.Size = new System.Drawing.Size(38, 13);
			this.label_notas.TabIndex = 16;
			this.label_notas.Text = "Notas:";
			// 
			// textBox_notas
			// 
			this.textBox_notas.Location = new System.Drawing.Point(56, 374);
			this.textBox_notas.Multiline = true;
			this.textBox_notas.Name = "textBox_notas";
			this.textBox_notas.Size = new System.Drawing.Size(645, 82);
			this.textBox_notas.TabIndex = 17;
			// 
			// label_simboloEuro
			// 
			this.label_simboloEuro.AutoSize = true;
			this.label_simboloEuro.Location = new System.Drawing.Point(878, 384);
			this.label_simboloEuro.Name = "label_simboloEuro";
			this.label_simboloEuro.Size = new System.Drawing.Size(13, 13);
			this.label_simboloEuro.TabIndex = 18;
			this.label_simboloEuro.Text = "€";
			// 
			// button_apagar
			// 
			this.button_apagar.Location = new System.Drawing.Point(707, 429);
			this.button_apagar.Name = "button_apagar";
			this.button_apagar.Size = new System.Drawing.Size(67, 23);
			this.button_apagar.TabIndex = 19;
			this.button_apagar.Text = "Apagar";
			this.button_apagar.UseVisualStyleBackColor = true;
			this.button_apagar.Click += new System.EventHandler(this.button_apagar_Click);
			// 
			// button_porCarrinho
			// 
			this.button_porCarrinho.Location = new System.Drawing.Point(439, 153);
			this.button_porCarrinho.Name = "button_porCarrinho";
			this.button_porCarrinho.Size = new System.Drawing.Size(40, 23);
			this.button_porCarrinho.TabIndex = 20;
			this.button_porCarrinho.Text = ">";
			this.button_porCarrinho.UseVisualStyleBackColor = true;
			this.button_porCarrinho.Click += new System.EventHandler(this.button_porCarrinho_Click);
			// 
			// button_tirarCarrinho
			// 
			this.button_tirarCarrinho.Location = new System.Drawing.Point(438, 234);
			this.button_tirarCarrinho.Name = "button_tirarCarrinho";
			this.button_tirarCarrinho.Size = new System.Drawing.Size(40, 23);
			this.button_tirarCarrinho.TabIndex = 21;
			this.button_tirarCarrinho.Text = "<";
			this.button_tirarCarrinho.UseVisualStyleBackColor = true;
			this.button_tirarCarrinho.Click += new System.EventHandler(this.button_tirarCarrinho_Click);
			// 
			// checkBox_concluida
			// 
			this.checkBox_concluida.AutoSize = true;
			this.checkBox_concluida.Location = new System.Drawing.Point(780, 406);
			this.checkBox_concluida.Name = "checkBox_concluida";
			this.checkBox_concluida.Size = new System.Drawing.Size(75, 17);
			this.checkBox_concluida.TabIndex = 22;
			this.checkBox_concluida.Text = "Concluída";
			this.checkBox_concluida.UseVisualStyleBackColor = true;
			// 
			// Encomenda
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(895, 464);
			this.Controls.Add(this.checkBox_concluida);
			this.Controls.Add(this.button_tirarCarrinho);
			this.Controls.Add(this.button_porCarrinho);
			this.Controls.Add(this.button_apagar);
			this.Controls.Add(this.label_simboloEuro);
			this.Controls.Add(this.textBox_notas);
			this.Controls.Add(this.label_notas);
			this.Controls.Add(this.label_preco);
			this.Controls.Add(this.button_criar);
			this.Controls.Add(this.label_morada);
			this.Controls.Add(this.numeric_preco);
			this.Controls.Add(this.numeric_idade);
			this.Controls.Add(this.label_idade);
			this.Controls.Add(this.label_nome);
			this.Controls.Add(this.groupBox_carrinho);
			this.Controls.Add(this.groupBox_procura);
			this.Controls.Add(this.textBox_morada);
			this.Controls.Add(this.textBox_nome);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Encomenda";
			this.groupBox_procura.ResumeLayout(false);
			this.groupBox_procura.PerformLayout();
			this.groupBox_carrinho.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numeric_idade)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_preco)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox_nome;
		private System.Windows.Forms.TextBox textBox_morada;
		private System.Windows.Forms.ListBox listBox_procura;
		private System.Windows.Forms.ListBox listBox_carrinho;
		private System.Windows.Forms.TextBox textBox_pesquisa;
		private System.Windows.Forms.GroupBox groupBox_procura;
		private System.Windows.Forms.GroupBox groupBox_carrinho;
		private System.Windows.Forms.Label label_nome;
		private System.Windows.Forms.Label label_idade;
		private System.Windows.Forms.NumericUpDown numeric_idade;
		private System.Windows.Forms.Label label_morada;
		private System.Windows.Forms.Button button_criar;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.Label label_preco;
		private System.Windows.Forms.NumericUpDown numeric_preco;
		private System.Windows.Forms.TextBox textBox_notas;
		private System.Windows.Forms.Label label_notas;
		private System.Windows.Forms.Label label_simboloEuro;
		private System.Windows.Forms.Button button_apagar;
		private System.Windows.Forms.Button button_tirarCarrinho;
		private System.Windows.Forms.Button button_porCarrinho;
		private System.Windows.Forms.CheckBox checkBox_concluida;
	}
}