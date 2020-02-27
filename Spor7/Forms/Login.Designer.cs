namespace Spor7.Forms
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.button_login = new System.Windows.Forms.Button();
			this.textBox_utilizador = new System.Windows.Forms.TextBox();
			this.pictureBox_logo = new System.Windows.Forms.PictureBox();
			this.label_utilizador = new System.Windows.Forms.Label();
			this.label_password = new System.Windows.Forms.Label();
			this.textBox_password = new System.Windows.Forms.TextBox();
			this.button_mostrarPassword = new System.Windows.Forms.Button();
			this.label_erroLogin = new System.Windows.Forms.Label();
			this.checkBox_lembrar = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
			this.SuspendLayout();
			// 
			// button_login
			// 
			this.button_login.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_login.Location = new System.Drawing.Point(11, 281);
			this.button_login.Name = "button_login";
			this.button_login.Size = new System.Drawing.Size(201, 44);
			this.button_login.TabIndex = 2;
			this.button_login.Text = "ENTRAR";
			this.button_login.UseVisualStyleBackColor = true;
			this.button_login.Click += new System.EventHandler(this.button_login_Click);
			// 
			// textBox_utilizador
			// 
			this.textBox_utilizador.Location = new System.Drawing.Point(13, 157);
			this.textBox_utilizador.Name = "textBox_utilizador";
			this.textBox_utilizador.Size = new System.Drawing.Size(199, 20);
			this.textBox_utilizador.TabIndex = 0;
			// 
			// pictureBox_logo
			// 
			this.pictureBox_logo.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.Image")));
			this.pictureBox_logo.Location = new System.Drawing.Point(13, 12);
			this.pictureBox_logo.Name = "pictureBox_logo";
			this.pictureBox_logo.Size = new System.Drawing.Size(199, 95);
			this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox_logo.TabIndex = 0;
			this.pictureBox_logo.TabStop = false;
			// 
			// label_utilizador
			// 
			this.label_utilizador.AutoSize = true;
			this.label_utilizador.BackColor = System.Drawing.Color.Transparent;
			this.label_utilizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_utilizador.ForeColor = System.Drawing.Color.Lime;
			this.label_utilizador.Location = new System.Drawing.Point(13, 141);
			this.label_utilizador.Name = "label_utilizador";
			this.label_utilizador.Size = new System.Drawing.Size(60, 13);
			this.label_utilizador.TabIndex = 0;
			this.label_utilizador.Text = "Utilizador";
			// 
			// label_password
			// 
			this.label_password.AutoSize = true;
			this.label_password.BackColor = System.Drawing.Color.Transparent;
			this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_password.ForeColor = System.Drawing.Color.Lime;
			this.label_password.Location = new System.Drawing.Point(13, 181);
			this.label_password.Name = "label_password";
			this.label_password.Size = new System.Drawing.Size(61, 13);
			this.label_password.TabIndex = 0;
			this.label_password.Text = "Password";
			// 
			// textBox_password
			// 
			this.textBox_password.Location = new System.Drawing.Point(13, 197);
			this.textBox_password.Name = "textBox_password";
			this.textBox_password.PasswordChar = '•';
			this.textBox_password.Size = new System.Drawing.Size(177, 20);
			this.textBox_password.TabIndex = 1;
			this.textBox_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_password_KeyDown);
			// 
			// button_mostrarPassword
			// 
			this.button_mostrarPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_mostrarPassword.BackgroundImage")));
			this.button_mostrarPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button_mostrarPassword.Location = new System.Drawing.Point(190, 196);
			this.button_mostrarPassword.Name = "button_mostrarPassword";
			this.button_mostrarPassword.Size = new System.Drawing.Size(22, 22);
			this.button_mostrarPassword.TabIndex = 0;
			this.button_mostrarPassword.TabStop = false;
			this.button_mostrarPassword.UseVisualStyleBackColor = true;
			this.button_mostrarPassword.Click += new System.EventHandler(this.button_mostrarPassword_Click);
			// 
			// label_erroLogin
			// 
			this.label_erroLogin.AutoSize = true;
			this.label_erroLogin.BackColor = System.Drawing.Color.Transparent;
			this.label_erroLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_erroLogin.ForeColor = System.Drawing.Color.Maroon;
			this.label_erroLogin.Location = new System.Drawing.Point(13, 224);
			this.label_erroLogin.Name = "label_erroLogin";
			this.label_erroLogin.Size = new System.Drawing.Size(200, 13);
			this.label_erroLogin.TabIndex = 0;
			this.label_erroLogin.Text = "Utilizador ou Password incorretos.";
			this.label_erroLogin.Visible = false;
			// 
			// checkBox_lembrar
			// 
			this.checkBox_lembrar.AutoSize = true;
			this.checkBox_lembrar.BackColor = System.Drawing.Color.Transparent;
			this.checkBox_lembrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.checkBox_lembrar.ForeColor = System.Drawing.Color.Aqua;
			this.checkBox_lembrar.Location = new System.Drawing.Point(11, 329);
			this.checkBox_lembrar.Name = "checkBox_lembrar";
			this.checkBox_lembrar.Size = new System.Drawing.Size(110, 17);
			this.checkBox_lembrar.TabIndex = 3;
			this.checkBox_lembrar.Text = "Lembrar Utilizador";
			this.checkBox_lembrar.UseVisualStyleBackColor = false;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Snow;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(224, 349);
			this.Controls.Add(this.checkBox_lembrar);
			this.Controls.Add(this.label_erroLogin);
			this.Controls.Add(this.button_mostrarPassword);
			this.Controls.Add(this.textBox_password);
			this.Controls.Add(this.label_password);
			this.Controls.Add(this.label_utilizador);
			this.Controls.Add(this.button_login);
			this.Controls.Add(this.textBox_utilizador);
			this.Controls.Add(this.pictureBox_logo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
			this.Load += new System.EventHandler(this.Login_Load);
			this.Shown += new System.EventHandler(this.Login_Shown);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button_login;
		private System.Windows.Forms.TextBox textBox_utilizador;
		private System.Windows.Forms.PictureBox pictureBox_logo;
		private System.Windows.Forms.Label label_utilizador;
		private System.Windows.Forms.Label label_password;
		private System.Windows.Forms.TextBox textBox_password;
		private System.Windows.Forms.Button button_mostrarPassword;
		private System.Windows.Forms.Label label_erroLogin;
		private System.Windows.Forms.CheckBox checkBox_lembrar;
	}
}

