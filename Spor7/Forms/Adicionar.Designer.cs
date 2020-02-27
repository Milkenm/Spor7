namespace Spor7.Forms
{
	partial class Adicionar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adicionar));
			this.tabs = new System.Windows.Forms.TabControl();
			this.tabs_adicionarFuncionario = new System.Windows.Forms.TabPage();
			this.groupBox_loginFuncionario = new System.Windows.Forms.GroupBox();
			this.textBox_passwordConfirmar = new System.Windows.Forms.TextBox();
			this.label_password = new System.Windows.Forms.Label();
			this.textBox_password = new System.Windows.Forms.TextBox();
			this.label_login = new System.Windows.Forms.Label();
			this.textBox_login = new System.Windows.Forms.TextBox();
			this.groupBox_informacoesFuncionario = new System.Windows.Forms.GroupBox();
			this.label_permissoes = new System.Windows.Forms.Label();
			this.comboBox_permissoes = new System.Windows.Forms.ComboBox();
			this.numeric_idade = new System.Windows.Forms.NumericUpDown();
			this.label_idade = new System.Windows.Forms.Label();
			this.label_nib = new System.Windows.Forms.Label();
			this.label_contacto = new System.Windows.Forms.Label();
			this.label_email = new System.Windows.Forms.Label();
			this.label_morada = new System.Windows.Forms.Label();
			this.label_nome = new System.Windows.Forms.Label();
			this.textBox_contacto = new System.Windows.Forms.TextBox();
			this.textBox_nib = new System.Windows.Forms.TextBox();
			this.textBox_email = new System.Windows.Forms.TextBox();
			this.textBox_morada = new System.Windows.Forms.TextBox();
			this.textBox_nome = new System.Windows.Forms.TextBox();
			this.button_adicionarFuncionario = new System.Windows.Forms.Button();
			this.pictureBox_funcionario = new System.Windows.Forms.PictureBox();
			this.tabs_adicionarProduto = new System.Windows.Forms.TabPage();
			this.groupBox_informacoesProduto = new System.Windows.Forms.GroupBox();
			this.textBox_referencia = new System.Windows.Forms.TextBox();
			this.numeric_quantidade = new System.Windows.Forms.NumericUpDown();
			this.numeric_preco = new System.Windows.Forms.NumericUpDown();
			this.label_quantidade = new System.Windows.Forms.Label();
			this.label_categoria = new System.Windows.Forms.Label();
			this.comboBox_categoria = new System.Windows.Forms.ComboBox();
			this.label_preco = new System.Windows.Forms.Label();
			this.label_referencia = new System.Windows.Forms.Label();
			this.label_produto = new System.Windows.Forms.Label();
			this.textBox_produto = new System.Windows.Forms.TextBox();
			this.button_adicionarProduto = new System.Windows.Forms.Button();
			this.pictureBox_produto = new System.Windows.Forms.PictureBox();
			this.fileDialog = new System.Windows.Forms.OpenFileDialog();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.tabs.SuspendLayout();
			this.tabs_adicionarFuncionario.SuspendLayout();
			this.groupBox_loginFuncionario.SuspendLayout();
			this.groupBox_informacoesFuncionario.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numeric_idade)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_funcionario)).BeginInit();
			this.tabs_adicionarProduto.SuspendLayout();
			this.groupBox_informacoesProduto.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numeric_quantidade)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_preco)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_produto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// tabs
			// 
			this.tabs.Controls.Add(this.tabs_adicionarFuncionario);
			this.tabs.Controls.Add(this.tabs_adicionarProduto);
			this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabs.Location = new System.Drawing.Point(0, 0);
			this.tabs.Name = "tabs";
			this.tabs.SelectedIndex = 0;
			this.tabs.Size = new System.Drawing.Size(552, 340);
			this.tabs.TabIndex = 0;
			this.tabs.TabStop = false;
			this.tabs.SelectedIndexChanged += new System.EventHandler(this.tab_adicionar_SelectedIndexChanged);
			// 
			// tabs_adicionarFuncionario
			// 
			this.tabs_adicionarFuncionario.BackColor = System.Drawing.Color.Snow;
			this.tabs_adicionarFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tabs_adicionarFuncionario.Controls.Add(this.groupBox_loginFuncionario);
			this.tabs_adicionarFuncionario.Controls.Add(this.groupBox_informacoesFuncionario);
			this.tabs_adicionarFuncionario.Controls.Add(this.button_adicionarFuncionario);
			this.tabs_adicionarFuncionario.Controls.Add(this.pictureBox_funcionario);
			this.tabs_adicionarFuncionario.Location = new System.Drawing.Point(4, 22);
			this.tabs_adicionarFuncionario.Name = "tabs_adicionarFuncionario";
			this.tabs_adicionarFuncionario.Padding = new System.Windows.Forms.Padding(3);
			this.tabs_adicionarFuncionario.Size = new System.Drawing.Size(544, 314);
			this.tabs_adicionarFuncionario.TabIndex = 0;
			this.tabs_adicionarFuncionario.Text = "Adicionar Funcionário";
			// 
			// groupBox_loginFuncionario
			// 
			this.groupBox_loginFuncionario.Controls.Add(this.textBox_passwordConfirmar);
			this.groupBox_loginFuncionario.Controls.Add(this.label_password);
			this.groupBox_loginFuncionario.Controls.Add(this.textBox_password);
			this.groupBox_loginFuncionario.Controls.Add(this.label_login);
			this.groupBox_loginFuncionario.Controls.Add(this.textBox_login);
			this.groupBox_loginFuncionario.Location = new System.Drawing.Point(6, 148);
			this.groupBox_loginFuncionario.Name = "groupBox_loginFuncionario";
			this.groupBox_loginFuncionario.Size = new System.Drawing.Size(136, 141);
			this.groupBox_loginFuncionario.TabIndex = 23;
			this.groupBox_loginFuncionario.TabStop = false;
			this.groupBox_loginFuncionario.Text = "Login";
			// 
			// textBox_passwordConfirmar
			// 
			this.textBox_passwordConfirmar.Location = new System.Drawing.Point(14, 99);
			this.textBox_passwordConfirmar.Name = "textBox_passwordConfirmar";
			this.textBox_passwordConfirmar.PasswordChar = '•';
			this.textBox_passwordConfirmar.Size = new System.Drawing.Size(112, 20);
			this.textBox_passwordConfirmar.TabIndex = 9;
			// 
			// label_password
			// 
			this.label_password.AutoSize = true;
			this.label_password.Location = new System.Drawing.Point(11, 62);
			this.label_password.Name = "label_password";
			this.label_password.Size = new System.Drawing.Size(53, 13);
			this.label_password.TabIndex = 25;
			this.label_password.Text = "Password";
			// 
			// textBox_password
			// 
			this.textBox_password.Location = new System.Drawing.Point(14, 78);
			this.textBox_password.Name = "textBox_password";
			this.textBox_password.PasswordChar = '•';
			this.textBox_password.Size = new System.Drawing.Size(112, 20);
			this.textBox_password.TabIndex = 8;
			// 
			// label_login
			// 
			this.label_login.AutoSize = true;
			this.label_login.Location = new System.Drawing.Point(11, 21);
			this.label_login.Name = "label_login";
			this.label_login.Size = new System.Drawing.Size(50, 13);
			this.label_login.TabIndex = 23;
			this.label_login.Text = "Utilizador";
			// 
			// textBox_login
			// 
			this.textBox_login.Location = new System.Drawing.Point(14, 37);
			this.textBox_login.Name = "textBox_login";
			this.textBox_login.Size = new System.Drawing.Size(112, 20);
			this.textBox_login.TabIndex = 7;
			// 
			// groupBox_informacoesFuncionario
			// 
			this.groupBox_informacoesFuncionario.BackColor = System.Drawing.Color.Snow;
			this.groupBox_informacoesFuncionario.Controls.Add(this.label_permissoes);
			this.groupBox_informacoesFuncionario.Controls.Add(this.comboBox_permissoes);
			this.groupBox_informacoesFuncionario.Controls.Add(this.numeric_idade);
			this.groupBox_informacoesFuncionario.Controls.Add(this.label_idade);
			this.groupBox_informacoesFuncionario.Controls.Add(this.label_nib);
			this.groupBox_informacoesFuncionario.Controls.Add(this.label_contacto);
			this.groupBox_informacoesFuncionario.Controls.Add(this.label_email);
			this.groupBox_informacoesFuncionario.Controls.Add(this.label_morada);
			this.groupBox_informacoesFuncionario.Controls.Add(this.label_nome);
			this.groupBox_informacoesFuncionario.Controls.Add(this.textBox_contacto);
			this.groupBox_informacoesFuncionario.Controls.Add(this.textBox_nib);
			this.groupBox_informacoesFuncionario.Controls.Add(this.textBox_email);
			this.groupBox_informacoesFuncionario.Controls.Add(this.textBox_morada);
			this.groupBox_informacoesFuncionario.Controls.Add(this.textBox_nome);
			this.groupBox_informacoesFuncionario.Location = new System.Drawing.Point(148, 2);
			this.groupBox_informacoesFuncionario.Name = "groupBox_informacoesFuncionario";
			this.groupBox_informacoesFuncionario.Size = new System.Drawing.Size(393, 287);
			this.groupBox_informacoesFuncionario.TabIndex = 22;
			this.groupBox_informacoesFuncionario.TabStop = false;
			this.groupBox_informacoesFuncionario.Text = "Informações";
			// 
			// label_permissoes
			// 
			this.label_permissoes.AutoSize = true;
			this.label_permissoes.Location = new System.Drawing.Point(185, 222);
			this.label_permissoes.Name = "label_permissoes";
			this.label_permissoes.Size = new System.Drawing.Size(60, 13);
			this.label_permissoes.TabIndex = 29;
			this.label_permissoes.Text = "Permissões";
			// 
			// comboBox_permissoes
			// 
			this.comboBox_permissoes.FormattingEnabled = true;
			this.comboBox_permissoes.Items.AddRange(new object[] {
            "Administrador",
            "Funcionário",
            "Estagiário"});
			this.comboBox_permissoes.Location = new System.Drawing.Point(188, 237);
			this.comboBox_permissoes.Name = "comboBox_permissoes";
			this.comboBox_permissoes.Size = new System.Drawing.Size(171, 21);
			this.comboBox_permissoes.TabIndex = 28;
			// 
			// numeric_idade
			// 
			this.numeric_idade.Location = new System.Drawing.Point(13, 238);
			this.numeric_idade.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
			this.numeric_idade.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
			this.numeric_idade.Name = "numeric_idade";
			this.numeric_idade.Size = new System.Drawing.Size(120, 20);
			this.numeric_idade.TabIndex = 6;
			this.numeric_idade.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
			// 
			// label_idade
			// 
			this.label_idade.AutoSize = true;
			this.label_idade.Location = new System.Drawing.Point(10, 222);
			this.label_idade.Name = "label_idade";
			this.label_idade.Size = new System.Drawing.Size(34, 13);
			this.label_idade.TabIndex = 27;
			this.label_idade.Text = "Idade";
			// 
			// label_nib
			// 
			this.label_nib.AutoSize = true;
			this.label_nib.Location = new System.Drawing.Point(9, 181);
			this.label_nib.Name = "label_nib";
			this.label_nib.Size = new System.Drawing.Size(168, 13);
			this.label_nib.TabIndex = 26;
			this.label_nib.Text = "Número de Identificação Bancária";
			// 
			// label_contacto
			// 
			this.label_contacto.AutoSize = true;
			this.label_contacto.Location = new System.Drawing.Point(9, 140);
			this.label_contacto.Name = "label_contacto";
			this.label_contacto.Size = new System.Drawing.Size(50, 13);
			this.label_contacto.TabIndex = 25;
			this.label_contacto.Text = "Contacto";
			// 
			// label_email
			// 
			this.label_email.AutoSize = true;
			this.label_email.Location = new System.Drawing.Point(9, 99);
			this.label_email.Name = "label_email";
			this.label_email.Size = new System.Drawing.Size(35, 13);
			this.label_email.TabIndex = 24;
			this.label_email.Text = "E-mail";
			// 
			// label_morada
			// 
			this.label_morada.AutoSize = true;
			this.label_morada.Location = new System.Drawing.Point(9, 58);
			this.label_morada.Name = "label_morada";
			this.label_morada.Size = new System.Drawing.Size(43, 13);
			this.label_morada.TabIndex = 23;
			this.label_morada.Text = "Morada";
			// 
			// label_nome
			// 
			this.label_nome.AutoSize = true;
			this.label_nome.Location = new System.Drawing.Point(9, 17);
			this.label_nome.Name = "label_nome";
			this.label_nome.Size = new System.Drawing.Size(35, 13);
			this.label_nome.TabIndex = 22;
			this.label_nome.Text = "Nome";
			// 
			// textBox_contacto
			// 
			this.textBox_contacto.Location = new System.Drawing.Point(12, 156);
			this.textBox_contacto.Name = "textBox_contacto";
			this.textBox_contacto.Size = new System.Drawing.Size(347, 20);
			this.textBox_contacto.TabIndex = 4;
			// 
			// textBox_nib
			// 
			this.textBox_nib.Location = new System.Drawing.Point(12, 197);
			this.textBox_nib.Name = "textBox_nib";
			this.textBox_nib.Size = new System.Drawing.Size(347, 20);
			this.textBox_nib.TabIndex = 5;
			// 
			// textBox_email
			// 
			this.textBox_email.Location = new System.Drawing.Point(12, 115);
			this.textBox_email.Name = "textBox_email";
			this.textBox_email.Size = new System.Drawing.Size(347, 20);
			this.textBox_email.TabIndex = 3;
			// 
			// textBox_morada
			// 
			this.textBox_morada.Location = new System.Drawing.Point(12, 74);
			this.textBox_morada.Name = "textBox_morada";
			this.textBox_morada.Size = new System.Drawing.Size(347, 20);
			this.textBox_morada.TabIndex = 2;
			// 
			// textBox_nome
			// 
			this.textBox_nome.Location = new System.Drawing.Point(12, 33);
			this.textBox_nome.MaxLength = 16;
			this.textBox_nome.Name = "textBox_nome";
			this.textBox_nome.Size = new System.Drawing.Size(347, 20);
			this.textBox_nome.TabIndex = 1;
			// 
			// button_adicionarFuncionario
			// 
			this.button_adicionarFuncionario.Location = new System.Drawing.Point(467, 289);
			this.button_adicionarFuncionario.Name = "button_adicionarFuncionario";
			this.button_adicionarFuncionario.Size = new System.Drawing.Size(75, 23);
			this.button_adicionarFuncionario.TabIndex = 10;
			this.button_adicionarFuncionario.Text = "Adicionar";
			this.button_adicionarFuncionario.UseVisualStyleBackColor = true;
			this.button_adicionarFuncionario.Click += new System.EventHandler(this.button_adicionarUtilizador_Click);
			// 
			// pictureBox_funcionario
			// 
			this.pictureBox_funcionario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_funcionario.BackgroundImage")));
			this.pictureBox_funcionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox_funcionario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox_funcionario.InitialImage = null;
			this.pictureBox_funcionario.Location = new System.Drawing.Point(8, 8);
			this.pictureBox_funcionario.Name = "pictureBox_funcionario";
			this.pictureBox_funcionario.Size = new System.Drawing.Size(134, 134);
			this.pictureBox_funcionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_funcionario.TabIndex = 0;
			this.pictureBox_funcionario.TabStop = false;
			this.pictureBox_funcionario.Click += new System.EventHandler(this.pictureBox_utilizador_Click);
			// 
			// tabs_adicionarProduto
			// 
			this.tabs_adicionarProduto.BackColor = System.Drawing.Color.Snow;
			this.tabs_adicionarProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tabs_adicionarProduto.Controls.Add(this.groupBox_informacoesProduto);
			this.tabs_adicionarProduto.Controls.Add(this.button_adicionarProduto);
			this.tabs_adicionarProduto.Controls.Add(this.pictureBox_produto);
			this.tabs_adicionarProduto.Location = new System.Drawing.Point(4, 22);
			this.tabs_adicionarProduto.Name = "tabs_adicionarProduto";
			this.tabs_adicionarProduto.Padding = new System.Windows.Forms.Padding(3);
			this.tabs_adicionarProduto.Size = new System.Drawing.Size(544, 314);
			this.tabs_adicionarProduto.TabIndex = 1;
			this.tabs_adicionarProduto.Text = "Adicionar Produto";
			// 
			// groupBox_informacoesProduto
			// 
			this.groupBox_informacoesProduto.Controls.Add(this.textBox_referencia);
			this.groupBox_informacoesProduto.Controls.Add(this.numeric_quantidade);
			this.groupBox_informacoesProduto.Controls.Add(this.numeric_preco);
			this.groupBox_informacoesProduto.Controls.Add(this.label_quantidade);
			this.groupBox_informacoesProduto.Controls.Add(this.label_categoria);
			this.groupBox_informacoesProduto.Controls.Add(this.comboBox_categoria);
			this.groupBox_informacoesProduto.Controls.Add(this.label_preco);
			this.groupBox_informacoesProduto.Controls.Add(this.label_referencia);
			this.groupBox_informacoesProduto.Controls.Add(this.label_produto);
			this.groupBox_informacoesProduto.Controls.Add(this.textBox_produto);
			this.groupBox_informacoesProduto.Location = new System.Drawing.Point(148, 2);
			this.groupBox_informacoesProduto.Name = "groupBox_informacoesProduto";
			this.groupBox_informacoesProduto.Size = new System.Drawing.Size(393, 141);
			this.groupBox_informacoesProduto.TabIndex = 26;
			this.groupBox_informacoesProduto.TabStop = false;
			this.groupBox_informacoesProduto.Text = "Informações";
			// 
			// textBox_referencia
			// 
			this.textBox_referencia.Location = new System.Drawing.Point(12, 115);
			this.textBox_referencia.Name = "textBox_referencia";
			this.textBox_referencia.Size = new System.Drawing.Size(158, 20);
			this.textBox_referencia.TabIndex = 27;
			// 
			// numeric_quantidade
			// 
			this.numeric_quantidade.Location = new System.Drawing.Point(12, 74);
			this.numeric_quantidade.Name = "numeric_quantidade";
			this.numeric_quantidade.Size = new System.Drawing.Size(158, 20);
			this.numeric_quantidade.TabIndex = 37;
			this.numeric_quantidade.ThousandsSeparator = true;
			// 
			// numeric_preco
			// 
			this.numeric_preco.DecimalPlaces = 2;
			this.numeric_preco.Location = new System.Drawing.Point(201, 74);
			this.numeric_preco.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
			this.numeric_preco.Name = "numeric_preco";
			this.numeric_preco.Size = new System.Drawing.Size(158, 20);
			this.numeric_preco.TabIndex = 36;
			this.numeric_preco.ThousandsSeparator = true;
			// 
			// label_quantidade
			// 
			this.label_quantidade.AutoSize = true;
			this.label_quantidade.Location = new System.Drawing.Point(9, 58);
			this.label_quantidade.Name = "label_quantidade";
			this.label_quantidade.Size = new System.Drawing.Size(62, 13);
			this.label_quantidade.TabIndex = 35;
			this.label_quantidade.Text = "Quantidade";
			// 
			// label_categoria
			// 
			this.label_categoria.AutoSize = true;
			this.label_categoria.Location = new System.Drawing.Point(198, 99);
			this.label_categoria.Name = "label_categoria";
			this.label_categoria.Size = new System.Drawing.Size(52, 13);
			this.label_categoria.TabIndex = 33;
			this.label_categoria.Text = "Categoria";
			// 
			// comboBox_categoria
			// 
			this.comboBox_categoria.FormattingEnabled = true;
			this.comboBox_categoria.Location = new System.Drawing.Point(201, 115);
			this.comboBox_categoria.Name = "comboBox_categoria";
			this.comboBox_categoria.Size = new System.Drawing.Size(160, 21);
			this.comboBox_categoria.TabIndex = 5;
			// 
			// label_preco
			// 
			this.label_preco.AutoSize = true;
			this.label_preco.Location = new System.Drawing.Point(198, 58);
			this.label_preco.Name = "label_preco";
			this.label_preco.Size = new System.Drawing.Size(35, 13);
			this.label_preco.TabIndex = 30;
			this.label_preco.Text = "Preço";
			// 
			// label_referencia
			// 
			this.label_referencia.AutoSize = true;
			this.label_referencia.Location = new System.Drawing.Point(9, 99);
			this.label_referencia.Name = "label_referencia";
			this.label_referencia.Size = new System.Drawing.Size(59, 13);
			this.label_referencia.TabIndex = 27;
			this.label_referencia.Text = "Referência";
			// 
			// label_produto
			// 
			this.label_produto.AutoSize = true;
			this.label_produto.Location = new System.Drawing.Point(9, 17);
			this.label_produto.Name = "label_produto";
			this.label_produto.Size = new System.Drawing.Size(35, 13);
			this.label_produto.TabIndex = 22;
			this.label_produto.Text = "Nome";
			// 
			// textBox_produto
			// 
			this.textBox_produto.Location = new System.Drawing.Point(12, 33);
			this.textBox_produto.Name = "textBox_produto";
			this.textBox_produto.Size = new System.Drawing.Size(347, 20);
			this.textBox_produto.TabIndex = 1;
			// 
			// button_adicionarProduto
			// 
			this.button_adicionarProduto.Location = new System.Drawing.Point(467, 142);
			this.button_adicionarProduto.Name = "button_adicionarProduto";
			this.button_adicionarProduto.Size = new System.Drawing.Size(75, 23);
			this.button_adicionarProduto.TabIndex = 6;
			this.button_adicionarProduto.Text = "Adicionar";
			this.button_adicionarProduto.UseVisualStyleBackColor = true;
			this.button_adicionarProduto.Click += new System.EventHandler(this.button_adicionarProduto_Click);
			// 
			// pictureBox_produto
			// 
			this.pictureBox_produto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_produto.BackgroundImage")));
			this.pictureBox_produto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox_produto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox_produto.Location = new System.Drawing.Point(8, 8);
			this.pictureBox_produto.Name = "pictureBox_produto";
			this.pictureBox_produto.Size = new System.Drawing.Size(134, 134);
			this.pictureBox_produto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_produto.TabIndex = 24;
			this.pictureBox_produto.TabStop = false;
			this.pictureBox_produto.Click += new System.EventHandler(this.pictureBox_produto_Click);
			// 
			// fileDialog
			// 
			this.fileDialog.Filter = "PNG|*.png";
			this.fileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.fileDialog_FileOk);
			// 
			// errorProvider
			// 
			this.errorProvider.BlinkRate = 0;
			this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.errorProvider.ContainerControl = this;
			// 
			// Adicionar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(552, 340);
			this.Controls.Add(this.tabs);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Adicionar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.Adicionar_Load);
			this.tabs.ResumeLayout(false);
			this.tabs_adicionarFuncionario.ResumeLayout(false);
			this.groupBox_loginFuncionario.ResumeLayout(false);
			this.groupBox_loginFuncionario.PerformLayout();
			this.groupBox_informacoesFuncionario.ResumeLayout(false);
			this.groupBox_informacoesFuncionario.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numeric_idade)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_funcionario)).EndInit();
			this.tabs_adicionarProduto.ResumeLayout(false);
			this.groupBox_informacoesProduto.ResumeLayout(false);
			this.groupBox_informacoesProduto.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numeric_quantidade)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_preco)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_produto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TabPage tabs_adicionarFuncionario;
		private System.Windows.Forms.TabPage tabs_adicionarProduto;
		private System.Windows.Forms.GroupBox groupBox_loginFuncionario;
		private System.Windows.Forms.TextBox textBox_passwordConfirmar;
		private System.Windows.Forms.Label label_password;
		private System.Windows.Forms.TextBox textBox_password;
		private System.Windows.Forms.Label label_login;
		private System.Windows.Forms.TextBox textBox_login;
		private System.Windows.Forms.GroupBox groupBox_informacoesFuncionario;
		private System.Windows.Forms.NumericUpDown numeric_idade;
		private System.Windows.Forms.Label label_idade;
		private System.Windows.Forms.Label label_nib;
		private System.Windows.Forms.Label label_contacto;
		private System.Windows.Forms.Label label_email;
		private System.Windows.Forms.Label label_morada;
		private System.Windows.Forms.Label label_nome;
		private System.Windows.Forms.TextBox textBox_contacto;
		private System.Windows.Forms.TextBox textBox_nib;
		private System.Windows.Forms.TextBox textBox_email;
		private System.Windows.Forms.TextBox textBox_morada;
		private System.Windows.Forms.TextBox textBox_nome;
		private System.Windows.Forms.Button button_adicionarFuncionario;
		private System.Windows.Forms.PictureBox pictureBox_funcionario;
		private System.Windows.Forms.GroupBox groupBox_informacoesProduto;
		private System.Windows.Forms.Label label_preco;
		private System.Windows.Forms.Label label_referencia;
		private System.Windows.Forms.Label label_produto;
		private System.Windows.Forms.TextBox textBox_produto;
		private System.Windows.Forms.Button button_adicionarProduto;
		private System.Windows.Forms.PictureBox pictureBox_produto;
		private System.Windows.Forms.OpenFileDialog fileDialog;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.Label label_categoria;
		private System.Windows.Forms.ComboBox comboBox_categoria;
		private System.Windows.Forms.Label label_quantidade;
		private System.Windows.Forms.TabControl tabs;
		private System.Windows.Forms.NumericUpDown numeric_quantidade;
		private System.Windows.Forms.NumericUpDown numeric_preco;
		private System.Windows.Forms.TextBox textBox_referencia;
		private System.Windows.Forms.Label label_permissoes;
		private System.Windows.Forms.ComboBox comboBox_permissoes;
	}
}