namespace Spor7.Forms
{
	partial class Perfil
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfil));
			this.pictureBox_utilizador = new System.Windows.Forms.PictureBox();
			this.textBox_nome = new System.Windows.Forms.TextBox();
			this.textBox_morada = new System.Windows.Forms.TextBox();
			this.textBox_email = new System.Windows.Forms.TextBox();
			this.textBox_contacto = new System.Windows.Forms.TextBox();
			this.textBox_nib = new System.Windows.Forms.TextBox();
			this.button_ok = new System.Windows.Forms.Button();
			this.label_nome = new System.Windows.Forms.Label();
			this.label_morada = new System.Windows.Forms.Label();
			this.label_email = new System.Windows.Forms.Label();
			this.label_contacto = new System.Windows.Forms.Label();
			this.label_nib = new System.Windows.Forms.Label();
			this.fileDialog = new System.Windows.Forms.OpenFileDialog();
			this.button_apagar = new System.Windows.Forms.Button();
			this.textBox_login = new System.Windows.Forms.TextBox();
			this.textBox_password = new System.Windows.Forms.TextBox();
			this.label_login = new System.Windows.Forms.Label();
			this.label_password = new System.Windows.Forms.Label();
			this.textBox_password2 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_utilizador)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox_utilizador
			// 
			this.pictureBox_utilizador.BackgroundImage = global::Spor7.Properties.Resources.SemUtilizador;
			this.pictureBox_utilizador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox_utilizador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox_utilizador.Location = new System.Drawing.Point(12, 12);
			this.pictureBox_utilizador.Name = "pictureBox_utilizador";
			this.pictureBox_utilizador.Size = new System.Drawing.Size(128, 128);
			this.pictureBox_utilizador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_utilizador.TabIndex = 0;
			this.pictureBox_utilizador.TabStop = false;
			this.pictureBox_utilizador.Click += new System.EventHandler(this.pictureBox_utilizador_Click);
			// 
			// textBox_nome
			// 
			this.textBox_nome.Location = new System.Drawing.Point(203, 14);
			this.textBox_nome.Name = "textBox_nome";
			this.textBox_nome.ReadOnly = true;
			this.textBox_nome.Size = new System.Drawing.Size(241, 20);
			this.textBox_nome.TabIndex = 1;
			// 
			// textBox_morada
			// 
			this.textBox_morada.Location = new System.Drawing.Point(203, 40);
			this.textBox_morada.Name = "textBox_morada";
			this.textBox_morada.Size = new System.Drawing.Size(241, 20);
			this.textBox_morada.TabIndex = 2;
			// 
			// textBox_email
			// 
			this.textBox_email.Location = new System.Drawing.Point(203, 66);
			this.textBox_email.Name = "textBox_email";
			this.textBox_email.Size = new System.Drawing.Size(241, 20);
			this.textBox_email.TabIndex = 3;
			// 
			// textBox_contacto
			// 
			this.textBox_contacto.Location = new System.Drawing.Point(203, 92);
			this.textBox_contacto.Name = "textBox_contacto";
			this.textBox_contacto.Size = new System.Drawing.Size(241, 20);
			this.textBox_contacto.TabIndex = 4;
			// 
			// textBox_nib
			// 
			this.textBox_nib.Location = new System.Drawing.Point(203, 118);
			this.textBox_nib.Name = "textBox_nib";
			this.textBox_nib.Size = new System.Drawing.Size(241, 20);
			this.textBox_nib.TabIndex = 5;
			// 
			// button_ok
			// 
			this.button_ok.Location = new System.Drawing.Point(295, 238);
			this.button_ok.Name = "button_ok";
			this.button_ok.Size = new System.Drawing.Size(75, 23);
			this.button_ok.TabIndex = 6;
			this.button_ok.Text = "OK";
			this.button_ok.UseVisualStyleBackColor = true;
			this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
			// 
			// label_nome
			// 
			this.label_nome.AutoSize = true;
			this.label_nome.Location = new System.Drawing.Point(162, 17);
			this.label_nome.Name = "label_nome";
			this.label_nome.Size = new System.Drawing.Size(35, 13);
			this.label_nome.TabIndex = 7;
			this.label_nome.Text = "Nome";
			// 
			// label_morada
			// 
			this.label_morada.AutoSize = true;
			this.label_morada.Location = new System.Drawing.Point(154, 43);
			this.label_morada.Name = "label_morada";
			this.label_morada.Size = new System.Drawing.Size(43, 13);
			this.label_morada.TabIndex = 8;
			this.label_morada.Text = "Morada";
			// 
			// label_email
			// 
			this.label_email.AutoSize = true;
			this.label_email.Location = new System.Drawing.Point(162, 69);
			this.label_email.Name = "label_email";
			this.label_email.Size = new System.Drawing.Size(35, 13);
			this.label_email.TabIndex = 9;
			this.label_email.Text = "E-mail";
			// 
			// label_contacto
			// 
			this.label_contacto.AutoSize = true;
			this.label_contacto.Location = new System.Drawing.Point(147, 95);
			this.label_contacto.Name = "label_contacto";
			this.label_contacto.Size = new System.Drawing.Size(50, 13);
			this.label_contacto.TabIndex = 10;
			this.label_contacto.Text = "Contacto";
			// 
			// label_nib
			// 
			this.label_nib.AutoSize = true;
			this.label_nib.Location = new System.Drawing.Point(172, 123);
			this.label_nib.Name = "label_nib";
			this.label_nib.Size = new System.Drawing.Size(25, 13);
			this.label_nib.TabIndex = 11;
			this.label_nib.Text = "NIB";
			// 
			// fileDialog
			// 
			this.fileDialog.FileName = "openFileDialog1";
			this.fileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.fileDialog_FileOk);
			// 
			// button_apagar
			// 
			this.button_apagar.Location = new System.Drawing.Point(376, 238);
			this.button_apagar.Name = "button_apagar";
			this.button_apagar.Size = new System.Drawing.Size(75, 23);
			this.button_apagar.TabIndex = 12;
			this.button_apagar.Text = "Apagar";
			this.button_apagar.UseVisualStyleBackColor = true;
			this.button_apagar.Click += new System.EventHandler(this.button_apagar_Click);
			// 
			// textBox_login
			// 
			this.textBox_login.Location = new System.Drawing.Point(12, 169);
			this.textBox_login.Name = "textBox_login";
			this.textBox_login.Size = new System.Drawing.Size(206, 20);
			this.textBox_login.TabIndex = 13;
			// 
			// textBox_password
			// 
			this.textBox_password.Location = new System.Drawing.Point(238, 169);
			this.textBox_password.Name = "textBox_password";
			this.textBox_password.PasswordChar = '•';
			this.textBox_password.Size = new System.Drawing.Size(206, 20);
			this.textBox_password.TabIndex = 14;
			// 
			// label_login
			// 
			this.label_login.AutoSize = true;
			this.label_login.Location = new System.Drawing.Point(12, 153);
			this.label_login.Name = "label_login";
			this.label_login.Size = new System.Drawing.Size(50, 13);
			this.label_login.TabIndex = 15;
			this.label_login.Text = "Utilizador";
			// 
			// label_password
			// 
			this.label_password.AutoSize = true;
			this.label_password.Location = new System.Drawing.Point(235, 153);
			this.label_password.Name = "label_password";
			this.label_password.Size = new System.Drawing.Size(53, 13);
			this.label_password.TabIndex = 16;
			this.label_password.Text = "Password";
			// 
			// textBox_password2
			// 
			this.textBox_password2.Location = new System.Drawing.Point(238, 195);
			this.textBox_password2.Name = "textBox_password2";
			this.textBox_password2.PasswordChar = '•';
			this.textBox_password2.Size = new System.Drawing.Size(206, 20);
			this.textBox_password2.TabIndex = 17;
			// 
			// Perfil
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Snow;
			this.ClientSize = new System.Drawing.Size(463, 273);
			this.Controls.Add(this.textBox_password2);
			this.Controls.Add(this.label_password);
			this.Controls.Add(this.label_login);
			this.Controls.Add(this.textBox_password);
			this.Controls.Add(this.textBox_login);
			this.Controls.Add(this.button_apagar);
			this.Controls.Add(this.label_nib);
			this.Controls.Add(this.label_contacto);
			this.Controls.Add(this.label_email);
			this.Controls.Add(this.label_morada);
			this.Controls.Add(this.label_nome);
			this.Controls.Add(this.button_ok);
			this.Controls.Add(this.textBox_nib);
			this.Controls.Add(this.textBox_contacto);
			this.Controls.Add(this.textBox_email);
			this.Controls.Add(this.textBox_morada);
			this.Controls.Add(this.textBox_nome);
			this.Controls.Add(this.pictureBox_utilizador);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Perfil";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.Perfil_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_utilizador)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox_utilizador;
		private System.Windows.Forms.TextBox textBox_nome;
		private System.Windows.Forms.TextBox textBox_morada;
		private System.Windows.Forms.TextBox textBox_email;
		private System.Windows.Forms.TextBox textBox_contacto;
		private System.Windows.Forms.TextBox textBox_nib;
		private System.Windows.Forms.Button button_ok;
		private System.Windows.Forms.Label label_nome;
		private System.Windows.Forms.Label label_morada;
		private System.Windows.Forms.Label label_email;
		private System.Windows.Forms.Label label_contacto;
		private System.Windows.Forms.Label label_nib;
		private System.Windows.Forms.OpenFileDialog fileDialog;
		private System.Windows.Forms.Button button_apagar;
		private System.Windows.Forms.TextBox textBox_login;
		private System.Windows.Forms.TextBox textBox_password;
		private System.Windows.Forms.Label label_login;
		private System.Windows.Forms.Label label_password;
		private System.Windows.Forms.TextBox textBox_password2;
	}
}