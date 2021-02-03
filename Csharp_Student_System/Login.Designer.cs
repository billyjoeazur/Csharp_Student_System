namespace Csharp_Student_System
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBoxUsername = new System.Windows.Forms.TextBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.buttonLogin = new Bunifu.Framework.UI.BunifuThinButton2();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button2 = new System.Windows.Forms.Button();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.button3 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel1.Controls.Add(this.textBoxUsername);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Location = new System.Drawing.Point(179, 219);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(214, 37);
			this.panel1.TabIndex = 2;
			// 
			// textBoxUsername
			// 
			this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxUsername.ForeColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBoxUsername.Location = new System.Drawing.Point(51, 3);
			this.textBoxUsername.Multiline = true;
			this.textBoxUsername.Name = "textBoxUsername";
			this.textBoxUsername.Size = new System.Drawing.Size(160, 31);
			this.textBoxUsername.TabIndex = 2;
			this.textBoxUsername.Text = "Username";
			this.textBoxUsername.Enter += new System.EventHandler(this.textBoxUsername_Enter);
			this.textBoxUsername.Leave += new System.EventHandler(this.textBoxUsername_Leave);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox2.Image = global::Csharp_Student_System.Properties.Resources.username;
			this.pictureBox2.Location = new System.Drawing.Point(0, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(45, 37);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel2.Controls.Add(this.textBoxPassword);
			this.panel2.Controls.Add(this.pictureBox3);
			this.panel2.Location = new System.Drawing.Point(179, 262);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(214, 37);
			this.panel2.TabIndex = 3;
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPassword.ForeColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBoxPassword.Location = new System.Drawing.Point(51, 3);
			this.textBoxPassword.Multiline = true;
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(160, 31);
			this.textBoxPassword.TabIndex = 2;
			this.textBoxPassword.Text = "Password";
			this.textBoxPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
			this.textBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPassword_KeyPress);
			this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox3.Image = global::Csharp_Student_System.Properties.Resources.password;
			this.pictureBox3.Location = new System.Drawing.Point(0, 0);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(45, 37);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 1;
			this.pictureBox3.TabStop = false;
			// 
			// button1
			// 
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Image = global::Csharp_Student_System.Properties.Resources.close2;
			this.button1.Location = new System.Drawing.Point(523, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(37, 39);
			this.button1.TabIndex = 5;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// buttonLogin
			// 
			this.buttonLogin.ActiveBorderThickness = 1;
			this.buttonLogin.ActiveCornerRadius = 20;
			this.buttonLogin.ActiveFillColor = System.Drawing.Color.SeaGreen;
			this.buttonLogin.ActiveForecolor = System.Drawing.Color.White;
			this.buttonLogin.ActiveLineColor = System.Drawing.Color.SeaGreen;
			this.buttonLogin.BackColor = System.Drawing.SystemColors.Control;
			this.buttonLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLogin.BackgroundImage")));
			this.buttonLogin.ButtonText = "Login";
			this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.buttonLogin.IdleBorderThickness = 1;
			this.buttonLogin.IdleCornerRadius = 20;
			this.buttonLogin.IdleFillColor = System.Drawing.Color.Black;
			this.buttonLogin.IdleForecolor = System.Drawing.Color.Honeydew;
			this.buttonLogin.IdleLineColor = System.Drawing.Color.MidnightBlue;
			this.buttonLogin.Location = new System.Drawing.Point(179, 45);
			this.buttonLogin.Margin = new System.Windows.Forms.Padding(5);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(214, 41);
			this.buttonLogin.TabIndex = 4;
			this.buttonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.buttonLogin.Visible = false;
			this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Csharp_Student_System.Properties.Resources.loginBG2;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(572, 521);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(248, 116);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 6;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Visible = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 50;
			this.bunifuElipse1.TargetControl = this;
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(179, 305);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(214, 41);
			this.button3.TabIndex = 7;
			this.button3.Text = "Login";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Login
			// 
			this.AcceptButton = this.button3;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(572, 521);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.buttonLogin);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Login_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBoxUsername;
		private Bunifu.Framework.UI.BunifuThinButton2 buttonLogin;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private System.Windows.Forms.Button button3;
	}
}