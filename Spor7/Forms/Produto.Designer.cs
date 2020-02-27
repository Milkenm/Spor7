namespace Spor7.Forms
{
	partial class Produto
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produto));
			this.pictureBox_produto = new System.Windows.Forms.PictureBox();
			this.numeric_quantidade = new System.Windows.Forms.NumericUpDown();
			this.label_quantidade = new System.Windows.Forms.Label();
			this.label_preco = new System.Windows.Forms.Label();
			this.numeric_preco = new System.Windows.Forms.NumericUpDown();
			this.textBox_produto = new System.Windows.Forms.TextBox();
			this.label_produto = new System.Windows.Forms.Label();
			this.label_referencia = new System.Windows.Forms.Label();
			this.textBox_referencia = new System.Windows.Forms.TextBox();
			this.button_ok = new System.Windows.Forms.Button();
			this.comboBox_categoria = new System.Windows.Forms.ComboBox();
			this.label_categoria = new System.Windows.Forms.Label();
			this.link_encomendas = new System.Windows.Forms.LinkLabel();
			this.fileDialog = new System.Windows.Forms.OpenFileDialog();
			this.button_apagar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_produto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_quantidade)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_preco)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox_produto
			// 
			this.pictureBox_produto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox_produto.Location = new System.Drawing.Point(12, 12);
			this.pictureBox_produto.Name = "pictureBox_produto";
			this.pictureBox_produto.Size = new System.Drawing.Size(128, 128);
			this.pictureBox_produto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_produto.TabIndex = 0;
			this.pictureBox_produto.TabStop = false;
			this.pictureBox_produto.Click += new System.EventHandler(this.pictureBox_produto_Click);
			// 
			// numeric_quantidade
			// 
			this.numeric_quantidade.Location = new System.Drawing.Point(215, 117);
			this.numeric_quantidade.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
			this.numeric_quantidade.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.numeric_quantidade.Name = "numeric_quantidade";
			this.numeric_quantidade.Size = new System.Drawing.Size(138, 20);
			this.numeric_quantidade.TabIndex = 3;
			this.numeric_quantidade.ThousandsSeparator = true;
			// 
			// label_quantidade
			// 
			this.label_quantidade.AutoSize = true;
			this.label_quantidade.Location = new System.Drawing.Point(147, 119);
			this.label_quantidade.Name = "label_quantidade";
			this.label_quantidade.Size = new System.Drawing.Size(62, 13);
			this.label_quantidade.TabIndex = 2;
			this.label_quantidade.Text = "Quantidade";
			// 
			// label_preco
			// 
			this.label_preco.AutoSize = true;
			this.label_preco.Location = new System.Drawing.Point(369, 119);
			this.label_preco.Name = "label_preco";
			this.label_preco.Size = new System.Drawing.Size(35, 13);
			this.label_preco.TabIndex = 3;
			this.label_preco.Text = "Preço";
			// 
			// numeric_preco
			// 
			this.numeric_preco.DecimalPlaces = 2;
			this.numeric_preco.Location = new System.Drawing.Point(410, 117);
			this.numeric_preco.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
			this.numeric_preco.Name = "numeric_preco";
			this.numeric_preco.Size = new System.Drawing.Size(138, 20);
			this.numeric_preco.TabIndex = 4;
			this.numeric_preco.ThousandsSeparator = true;
			// 
			// textBox_produto
			// 
			this.textBox_produto.Location = new System.Drawing.Point(215, 17);
			this.textBox_produto.Name = "textBox_produto";
			this.textBox_produto.Size = new System.Drawing.Size(333, 20);
			this.textBox_produto.TabIndex = 0;
			// 
			// label_produto
			// 
			this.label_produto.AutoSize = true;
			this.label_produto.Location = new System.Drawing.Point(174, 20);
			this.label_produto.Name = "label_produto";
			this.label_produto.Size = new System.Drawing.Size(35, 13);
			this.label_produto.TabIndex = 7;
			this.label_produto.Text = "Nome";
			// 
			// label_referencia
			// 
			this.label_referencia.AutoSize = true;
			this.label_referencia.Location = new System.Drawing.Point(150, 53);
			this.label_referencia.Name = "label_referencia";
			this.label_referencia.Size = new System.Drawing.Size(59, 13);
			this.label_referencia.TabIndex = 9;
			this.label_referencia.Text = "Referencia";
			// 
			// textBox_referencia
			// 
			this.textBox_referencia.Location = new System.Drawing.Point(215, 50);
			this.textBox_referencia.Name = "textBox_referencia";
			this.textBox_referencia.Size = new System.Drawing.Size(333, 20);
			this.textBox_referencia.TabIndex = 1;
			// 
			// button_ok
			// 
			this.button_ok.Location = new System.Drawing.Point(392, 155);
			this.button_ok.Name = "button_ok";
			this.button_ok.Size = new System.Drawing.Size(75, 23);
			this.button_ok.TabIndex = 5;
			this.button_ok.Text = "OK";
			this.button_ok.UseVisualStyleBackColor = true;
			this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
			// 
			// comboBox_categoria
			// 
			this.comboBox_categoria.FormattingEnabled = true;
			this.comboBox_categoria.Location = new System.Drawing.Point(215, 83);
			this.comboBox_categoria.Name = "comboBox_categoria";
			this.comboBox_categoria.Size = new System.Drawing.Size(333, 21);
			this.comboBox_categoria.TabIndex = 2;
			// 
			// label_categoria
			// 
			this.label_categoria.AutoSize = true;
			this.label_categoria.Location = new System.Drawing.Point(157, 86);
			this.label_categoria.Name = "label_categoria";
			this.label_categoria.Size = new System.Drawing.Size(52, 13);
			this.label_categoria.TabIndex = 12;
			this.label_categoria.Text = "Categoria";
			// 
			// link_encomendas
			// 
			this.link_encomendas.AutoSize = true;
			this.link_encomendas.Location = new System.Drawing.Point(12, 160);
			this.link_encomendas.Name = "link_encomendas";
			this.link_encomendas.Size = new System.Drawing.Size(151, 13);
			this.link_encomendas.TabIndex = 13;
			this.link_encomendas.TabStop = true;
			this.link_encomendas.Text = "Em <numero> encomenda<s>.";
			this.link_encomendas.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_encomendas_LinkClicked);
			// 
			// fileDialog
			// 
			this.fileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.fileDialog_FileOk);
			// 
			// button_apagar
			// 
			this.button_apagar.Location = new System.Drawing.Point(473, 155);
			this.button_apagar.Name = "button_apagar";
			this.button_apagar.Size = new System.Drawing.Size(75, 23);
			this.button_apagar.TabIndex = 14;
			this.button_apagar.Text = "Apagar";
			this.button_apagar.UseVisualStyleBackColor = true;
			this.button_apagar.Click += new System.EventHandler(this.button_apagar_Click);
			// 
			// Produto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(560, 186);
			this.Controls.Add(this.button_apagar);
			this.Controls.Add(this.link_encomendas);
			this.Controls.Add(this.label_categoria);
			this.Controls.Add(this.comboBox_categoria);
			this.Controls.Add(this.button_ok);
			this.Controls.Add(this.label_referencia);
			this.Controls.Add(this.textBox_referencia);
			this.Controls.Add(this.label_produto);
			this.Controls.Add(this.textBox_produto);
			this.Controls.Add(this.numeric_preco);
			this.Controls.Add(this.label_preco);
			this.Controls.Add(this.label_quantidade);
			this.Controls.Add(this.numeric_quantidade);
			this.Controls.Add(this.pictureBox_produto);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Produto";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Detalhes - <nome produto>";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_produto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_quantidade)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_preco)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox_produto;
		private System.Windows.Forms.NumericUpDown numeric_quantidade;
		private System.Windows.Forms.Label label_quantidade;
		private System.Windows.Forms.Label label_preco;
		private System.Windows.Forms.NumericUpDown numeric_preco;
		private System.Windows.Forms.TextBox textBox_produto;
		private System.Windows.Forms.Label label_produto;
		private System.Windows.Forms.Label label_referencia;
		private System.Windows.Forms.TextBox textBox_referencia;
		private System.Windows.Forms.Button button_ok;
		private System.Windows.Forms.ComboBox comboBox_categoria;
		private System.Windows.Forms.Label label_categoria;
		private System.Windows.Forms.LinkLabel link_encomendas;
		private System.Windows.Forms.OpenFileDialog fileDialog;
		private System.Windows.Forms.Button button_apagar;
	}
}