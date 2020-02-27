namespace Spor7.Forms
{
	partial class Main
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.panel_perfil = new System.Windows.Forms.Panel();
			this.label_data = new System.Windows.Forms.Label();
			this.button_perfil = new System.Windows.Forms.Button();
			this.button_sair = new System.Windows.Forms.Button();
			this.textBox_utilizador = new System.Windows.Forms.TextBox();
			this.pictureBox_utilizador = new System.Windows.Forms.PictureBox();
			this.timer_data = new System.Windows.Forms.Timer(this.components);
			this.button_adicionarUtilizador = new System.Windows.Forms.Button();
			this.groupBox_acoes = new System.Windows.Forms.GroupBox();
			this.button_criarEncomenda = new System.Windows.Forms.Button();
			this.button_procurar = new System.Windows.Forms.Button();
			this.button_adicionarProduto = new System.Windows.Forms.Button();
			this.tab_produtos = new System.Windows.Forms.TabPage();
			this.flowLayoutPanel_produtos = new System.Windows.Forms.FlowLayoutPanel();
			this.tab_encomendas = new System.Windows.Forms.TabPage();
			this.flowLayoutPanel_encomendas = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.tabs = new System.Windows.Forms.TabControl();
			this.tab_funcionarios = new System.Windows.Forms.TabPage();
			this.flowLayoutPanel_funcionarios = new System.Windows.Forms.FlowLayoutPanel();
			this.button3 = new System.Windows.Forms.Button();
			this.panel_perfil.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_utilizador)).BeginInit();
			this.groupBox_acoes.SuspendLayout();
			this.tab_produtos.SuspendLayout();
			this.tab_encomendas.SuspendLayout();
			this.flowLayoutPanel_encomendas.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tabs.SuspendLayout();
			this.tab_funcionarios.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel_perfil
			// 
			this.panel_perfil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel_perfil.Controls.Add(this.label_data);
			this.panel_perfil.Controls.Add(this.button_perfil);
			this.panel_perfil.Controls.Add(this.button_sair);
			this.panel_perfil.Controls.Add(this.textBox_utilizador);
			this.panel_perfil.Controls.Add(this.pictureBox_utilizador);
			this.panel_perfil.Location = new System.Drawing.Point(558, 0);
			this.panel_perfil.Name = "panel_perfil";
			this.panel_perfil.Size = new System.Drawing.Size(258, 73);
			this.panel_perfil.TabIndex = 0;
			// 
			// label_data
			// 
			this.label_data.AutoSize = true;
			this.label_data.Font = new System.Drawing.Font("Verdana", 8.25F);
			this.label_data.Location = new System.Drawing.Point(3, 51);
			this.label_data.Name = "label_data";
			this.label_data.Size = new System.Drawing.Size(50, 13);
			this.label_data.TabIndex = 1;
			this.label_data.Text = "<data>";
			// 
			// button_perfil
			// 
			this.button_perfil.Location = new System.Drawing.Point(2, 24);
			this.button_perfil.Name = "button_perfil";
			this.button_perfil.Size = new System.Drawing.Size(93, 23);
			this.button_perfil.TabIndex = 1;
			this.button_perfil.Text = "Perfil";
			this.button_perfil.UseVisualStyleBackColor = true;
			this.button_perfil.Click += new System.EventHandler(this.button_perfil_Click);
			// 
			// button_sair
			// 
			this.button_sair.Location = new System.Drawing.Point(94, 24);
			this.button_sair.Name = "button_sair";
			this.button_sair.Size = new System.Drawing.Size(92, 23);
			this.button_sair.TabIndex = 2;
			this.button_sair.Text = "Sair";
			this.button_sair.UseVisualStyleBackColor = true;
			this.button_sair.Click += new System.EventHandler(this.button_sair_Click);
			// 
			// textBox_utilizador
			// 
			this.textBox_utilizador.Location = new System.Drawing.Point(3, 3);
			this.textBox_utilizador.Name = "textBox_utilizador";
			this.textBox_utilizador.ReadOnly = true;
			this.textBox_utilizador.Size = new System.Drawing.Size(182, 20);
			this.textBox_utilizador.TabIndex = 2;
			// 
			// pictureBox_utilizador
			// 
			this.pictureBox_utilizador.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox_utilizador.BackgroundImage = global::Spor7.Properties.Resources.SemUtilizador;
			this.pictureBox_utilizador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox_utilizador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox_utilizador.Location = new System.Drawing.Point(187, 3);
			this.pictureBox_utilizador.Name = "pictureBox_utilizador";
			this.pictureBox_utilizador.Size = new System.Drawing.Size(64, 64);
			this.pictureBox_utilizador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_utilizador.TabIndex = 1;
			this.pictureBox_utilizador.TabStop = false;
			// 
			// timer_data
			// 
			this.timer_data.Enabled = true;
			this.timer_data.Interval = 1;
			this.timer_data.Tick += new System.EventHandler(this.timer_data_Tick);
			// 
			// button_adicionarUtilizador
			// 
			this.button_adicionarUtilizador.Location = new System.Drawing.Point(36, 77);
			this.button_adicionarUtilizador.Name = "button_adicionarUtilizador";
			this.button_adicionarUtilizador.Size = new System.Drawing.Size(187, 23);
			this.button_adicionarUtilizador.TabIndex = 2;
			this.button_adicionarUtilizador.Text = "Adicionar Funcionário";
			this.button_adicionarUtilizador.UseVisualStyleBackColor = true;
			this.button_adicionarUtilizador.Click += new System.EventHandler(this.button_adicionarUtilizador_Click);
			// 
			// groupBox_acoes
			// 
			this.groupBox_acoes.BackColor = System.Drawing.Color.Snow;
			this.groupBox_acoes.Controls.Add(this.button_criarEncomenda);
			this.groupBox_acoes.Controls.Add(this.button_procurar);
			this.groupBox_acoes.Controls.Add(this.button_adicionarProduto);
			this.groupBox_acoes.Controls.Add(this.button_adicionarUtilizador);
			this.groupBox_acoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox_acoes.Location = new System.Drawing.Point(558, 79);
			this.groupBox_acoes.Name = "groupBox_acoes";
			this.groupBox_acoes.Size = new System.Drawing.Size(258, 370);
			this.groupBox_acoes.TabIndex = 3;
			this.groupBox_acoes.TabStop = false;
			this.groupBox_acoes.Text = "Ações";
			// 
			// button_criarEncomenda
			// 
			this.button_criarEncomenda.Location = new System.Drawing.Point(36, 19);
			this.button_criarEncomenda.Name = "button_criarEncomenda";
			this.button_criarEncomenda.Size = new System.Drawing.Size(187, 23);
			this.button_criarEncomenda.TabIndex = 5;
			this.button_criarEncomenda.Text = "Criar Encomenda";
			this.button_criarEncomenda.UseVisualStyleBackColor = true;
			this.button_criarEncomenda.Click += new System.EventHandler(this.button_criarEncomenda_Click);
			// 
			// button_procurar
			// 
			this.button_procurar.Location = new System.Drawing.Point(36, 106);
			this.button_procurar.Name = "button_procurar";
			this.button_procurar.Size = new System.Drawing.Size(187, 23);
			this.button_procurar.TabIndex = 4;
			this.button_procurar.Text = "Procurar";
			this.button_procurar.UseVisualStyleBackColor = true;
			this.button_procurar.Click += new System.EventHandler(this.button_procurar_Click);
			// 
			// button_adicionarProduto
			// 
			this.button_adicionarProduto.Location = new System.Drawing.Point(36, 48);
			this.button_adicionarProduto.Name = "button_adicionarProduto";
			this.button_adicionarProduto.Size = new System.Drawing.Size(187, 23);
			this.button_adicionarProduto.TabIndex = 3;
			this.button_adicionarProduto.Text = "Adicionar Produto";
			this.button_adicionarProduto.UseVisualStyleBackColor = true;
			this.button_adicionarProduto.Click += new System.EventHandler(this.button_adicionarProduto_Click);
			// 
			// tab_produtos
			// 
			this.tab_produtos.Controls.Add(this.flowLayoutPanel_produtos);
			this.tab_produtos.Location = new System.Drawing.Point(4, 22);
			this.tab_produtos.Name = "tab_produtos";
			this.tab_produtos.Padding = new System.Windows.Forms.Padding(3);
			this.tab_produtos.Size = new System.Drawing.Size(549, 423);
			this.tab_produtos.TabIndex = 1;
			this.tab_produtos.Text = "Produtos";
			this.tab_produtos.UseVisualStyleBackColor = true;
			// 
			// flowLayoutPanel_produtos
			// 
			this.flowLayoutPanel_produtos.AutoScroll = true;
			this.flowLayoutPanel_produtos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.flowLayoutPanel_produtos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel_produtos.Location = new System.Drawing.Point(3, 3);
			this.flowLayoutPanel_produtos.Name = "flowLayoutPanel_produtos";
			this.flowLayoutPanel_produtos.Size = new System.Drawing.Size(543, 417);
			this.flowLayoutPanel_produtos.TabIndex = 3;
			// 
			// tab_encomendas
			// 
			this.tab_encomendas.Controls.Add(this.flowLayoutPanel_encomendas);
			this.tab_encomendas.Location = new System.Drawing.Point(4, 22);
			this.tab_encomendas.Name = "tab_encomendas";
			this.tab_encomendas.Padding = new System.Windows.Forms.Padding(3);
			this.tab_encomendas.Size = new System.Drawing.Size(549, 423);
			this.tab_encomendas.TabIndex = 0;
			this.tab_encomendas.Text = "Encomendas";
			this.tab_encomendas.UseVisualStyleBackColor = true;
			// 
			// flowLayoutPanel_encomendas
			// 
			this.flowLayoutPanel_encomendas.AutoScroll = true;
			this.flowLayoutPanel_encomendas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.flowLayoutPanel_encomendas.Controls.Add(this.panel1);
			this.flowLayoutPanel_encomendas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel_encomendas.Location = new System.Drawing.Point(3, 3);
			this.flowLayoutPanel_encomendas.Name = "flowLayoutPanel_encomendas";
			this.flowLayoutPanel_encomendas.Size = new System.Drawing.Size(543, 417);
			this.flowLayoutPanel_encomendas.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.listBox1);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(515, 91);
			this.panel1.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(0, 42);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Morada";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(0, 3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Nome";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(3, 58);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(221, 20);
			this.textBox2.TabIndex = 5;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(3, 19);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(221, 20);
			this.textBox1.TabIndex = 4;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(449, 15);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(61, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Remover";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(449, 63);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(61, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Ver";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(227, 1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Produtos";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(230, 17);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(213, 69);
			this.listBox1.TabIndex = 0;
			// 
			// tabs
			// 
			this.tabs.Controls.Add(this.tab_encomendas);
			this.tabs.Controls.Add(this.tab_produtos);
			this.tabs.Controls.Add(this.tab_funcionarios);
			this.tabs.HotTrack = true;
			this.tabs.Location = new System.Drawing.Point(0, 0);
			this.tabs.Name = "tabs";
			this.tabs.SelectedIndex = 0;
			this.tabs.Size = new System.Drawing.Size(557, 449);
			this.tabs.TabIndex = 4;
			// 
			// tab_funcionarios
			// 
			this.tab_funcionarios.Controls.Add(this.flowLayoutPanel_funcionarios);
			this.tab_funcionarios.Location = new System.Drawing.Point(4, 22);
			this.tab_funcionarios.Name = "tab_funcionarios";
			this.tab_funcionarios.Padding = new System.Windows.Forms.Padding(3);
			this.tab_funcionarios.Size = new System.Drawing.Size(549, 423);
			this.tab_funcionarios.TabIndex = 3;
			this.tab_funcionarios.Text = "Funcionários";
			this.tab_funcionarios.UseVisualStyleBackColor = true;
			// 
			// flowLayoutPanel_funcionarios
			// 
			this.flowLayoutPanel_funcionarios.AutoScroll = true;
			this.flowLayoutPanel_funcionarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.flowLayoutPanel_funcionarios.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel_funcionarios.Location = new System.Drawing.Point(3, 3);
			this.flowLayoutPanel_funcionarios.Name = "flowLayoutPanel_funcionarios";
			this.flowLayoutPanel_funcionarios.Size = new System.Drawing.Size(543, 417);
			this.flowLayoutPanel_funcionarios.TabIndex = 4;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(449, 39);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(61, 23);
			this.button3.TabIndex = 8;
			this.button3.Text = "Concluir";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Snow;
			this.ClientSize = new System.Drawing.Size(817, 449);
			this.Controls.Add(this.tabs);
			this.Controls.Add(this.groupBox_acoes);
			this.Controls.Add(this.panel_perfil);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
			this.Load += new System.EventHandler(this.Main_Load);
			this.panel_perfil.ResumeLayout(false);
			this.panel_perfil.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_utilizador)).EndInit();
			this.groupBox_acoes.ResumeLayout(false);
			this.tab_produtos.ResumeLayout(false);
			this.tab_encomendas.ResumeLayout(false);
			this.flowLayoutPanel_encomendas.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tabs.ResumeLayout(false);
			this.tab_funcionarios.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		internal System.Windows.Forms.Panel panel_perfil;
		internal System.Windows.Forms.Button button_perfil;
		internal System.Windows.Forms.Button button_sair;
		internal System.Windows.Forms.TextBox textBox_utilizador;
		internal System.Windows.Forms.Label label_data;
		internal System.Windows.Forms.Timer timer_data;
		internal System.Windows.Forms.Button button_adicionarUtilizador;
		internal System.Windows.Forms.GroupBox groupBox_acoes;
		internal System.Windows.Forms.Button button_adicionarProduto;
		internal System.Windows.Forms.TabPage tab_produtos;
		internal System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_produtos;
		internal System.Windows.Forms.TabPage tab_encomendas;
		internal System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_encomendas;
		internal System.Windows.Forms.TabControl tabs;
		internal System.Windows.Forms.TabPage tab_funcionarios;
		internal System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_funcionarios;
		internal System.Windows.Forms.PictureBox pictureBox_utilizador;
		private System.Windows.Forms.Button button_procurar;
		private System.Windows.Forms.Button button_criarEncomenda;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button3;
	}
}