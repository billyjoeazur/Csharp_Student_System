namespace Csharp_Student_System
{
	partial class Dashboard
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
			this.panelHeader = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButtonUser = new System.Windows.Forms.RadioButton();
			this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
			this.textBoxUser = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.textBoxPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.panelGrayBG = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.buttonLogin = new System.Windows.Forms.Button();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxSection = new System.Windows.Forms.ComboBox();
			this.btnGradeAdd = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.comboBoxGrade = new System.Windows.Forms.ComboBox();
			this.btnGradeRemove = new System.Windows.Forms.Button();
			this.groupBoxSY = new System.Windows.Forms.GroupBox();
			this.comboBoxSY = new System.Windows.Forms.ComboBox();
			this.btnRemoveSY = new System.Windows.Forms.Button();
			this.btnAddSY = new System.Windows.Forms.Button();
			this.groupBoxStrand = new System.Windows.Forms.GroupBox();
			this.comboBoxStrand = new System.Windows.Forms.ComboBox();
			this.btnRemoveStrand = new System.Windows.Forms.Button();
			this.btnAddStrand = new System.Windows.Forms.Button();
			this.groupBoxCourse = new System.Windows.Forms.GroupBox();
			this.panelHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panelGrayBG.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBoxSY.SuspendLayout();
			this.groupBoxStrand.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelHeader
			// 
			this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
			this.panelHeader.Controls.Add(this.pictureBox1);
			this.panelHeader.Controls.Add(this.label1);
			this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelHeader.Location = new System.Drawing.Point(0, 0);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new System.Drawing.Size(814, 50);
			this.panelHeader.TabIndex = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox1.Image = global::Csharp_Student_System.Properties.Resources.back;
			this.pictureBox1.Location = new System.Drawing.Point(3, 10);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(37, 37);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(255, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(310, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "ADMINISTRATOR DASHBOARD";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.textBoxUser, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.textBoxPassword, 0, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(42, 138);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 165);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButtonUser);
			this.groupBox1.Controls.Add(this.radioButtonAdmin);
			this.groupBox1.Location = new System.Drawing.Point(3, 113);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(194, 49);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			// 
			// radioButtonUser
			// 
			this.radioButtonUser.AutoSize = true;
			this.radioButtonUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButtonUser.ForeColor = System.Drawing.Color.Black;
			this.radioButtonUser.Location = new System.Drawing.Point(132, 11);
			this.radioButtonUser.Name = "radioButtonUser";
			this.radioButtonUser.Size = new System.Drawing.Size(55, 20);
			this.radioButtonUser.TabIndex = 1;
			this.radioButtonUser.TabStop = true;
			this.radioButtonUser.Text = "User";
			this.radioButtonUser.UseVisualStyleBackColor = true;
			// 
			// radioButtonAdmin
			// 
			this.radioButtonAdmin.AutoSize = true;
			this.radioButtonAdmin.Checked = true;
			this.radioButtonAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButtonAdmin.ForeColor = System.Drawing.Color.Black;
			this.radioButtonAdmin.Location = new System.Drawing.Point(6, 11);
			this.radioButtonAdmin.Name = "radioButtonAdmin";
			this.radioButtonAdmin.Size = new System.Drawing.Size(64, 20);
			this.radioButtonAdmin.TabIndex = 0;
			this.radioButtonAdmin.TabStop = true;
			this.radioButtonAdmin.Text = "Admin";
			this.radioButtonAdmin.UseVisualStyleBackColor = true;
			// 
			// textBoxUser
			// 
			this.textBoxUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxUser.BorderColorFocused = System.Drawing.Color.Blue;
			this.textBoxUser.BorderColorIdle = System.Drawing.SystemColors.ButtonFace;
			this.textBoxUser.BorderColorMouseHover = System.Drawing.Color.Blue;
			this.textBoxUser.BorderThickness = 1;
			this.textBoxUser.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBoxUser.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.textBoxUser.ForeColor = System.Drawing.Color.Black;
			this.textBoxUser.isPassword = false;
			this.textBoxUser.Location = new System.Drawing.Point(4, 12);
			this.textBoxUser.Margin = new System.Windows.Forms.Padding(4);
			this.textBoxUser.MaximumSize = new System.Drawing.Size(200, 31);
			this.textBoxUser.Name = "textBoxUser";
			this.textBoxUser.Size = new System.Drawing.Size(192, 31);
			this.textBoxUser.TabIndex = 2;
			this.textBoxUser.Text = "Username";
			this.textBoxUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxUser.Enter += new System.EventHandler(this.textBoxUser_Enter);
			this.textBoxUser.Leave += new System.EventHandler(this.textBoxUser_Leave);
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxPassword.BorderColorFocused = System.Drawing.Color.Blue;
			this.textBoxPassword.BorderColorIdle = System.Drawing.SystemColors.ButtonFace;
			this.textBoxPassword.BorderColorMouseHover = System.Drawing.Color.Blue;
			this.textBoxPassword.BorderThickness = 1;
			this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBoxPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.textBoxPassword.ForeColor = System.Drawing.Color.Black;
			this.textBoxPassword.isPassword = false;
			this.textBoxPassword.Location = new System.Drawing.Point(4, 67);
			this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
			this.textBoxPassword.MaximumSize = new System.Drawing.Size(200, 31);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(192, 31);
			this.textBoxPassword.TabIndex = 3;
			this.textBoxPassword.Text = "Password";
			this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
			this.textBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPassword_KeyPress);
			this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
			// 
			// panelGrayBG
			// 
			this.panelGrayBG.BackColor = System.Drawing.Color.Silver;
			this.panelGrayBG.Controls.Add(this.dataGridView1);
			this.panelGrayBG.Controls.Add(this.tableLayoutPanel3);
			this.panelGrayBG.Controls.Add(this.tableLayoutPanel2);
			this.panelGrayBG.Controls.Add(this.tableLayoutPanel1);
			this.panelGrayBG.Location = new System.Drawing.Point(6, 56);
			this.panelGrayBG.Name = "panelGrayBG";
			this.panelGrayBG.Size = new System.Drawing.Size(280, 430);
			this.panelGrayBG.TabIndex = 3;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(6, 409);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(268, 150);
			this.dataGridView1.TabIndex = 4;
			this.dataGridView1.Visible = false;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Controls.Add(this.buttonLogin, 0, 0);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(42, 320);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 40);
			this.tableLayoutPanel3.TabIndex = 5;
			// 
			// buttonLogin
			// 
			this.buttonLogin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonLogin.Location = new System.Drawing.Point(3, 3);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(194, 34);
			this.buttonLogin.TabIndex = 4;
			this.buttonLogin.Text = "Sign-Up";
			this.buttonLogin.UseVisualStyleBackColor = true;
			this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(280, 63);
			this.tableLayoutPanel2.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(274, 63);
			this.label2.TabIndex = 0;
			this.label2.Text = "Create New Account";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// comboBoxSection
			// 
			this.comboBoxSection.FormattingEnabled = true;
			this.comboBoxSection.Location = new System.Drawing.Point(168, 21);
			this.comboBoxSection.Name = "comboBoxSection";
			this.comboBoxSection.Size = new System.Drawing.Size(156, 24);
			this.comboBoxSection.TabIndex = 4;
			// 
			// btnGradeAdd
			// 
			this.btnGradeAdd.Location = new System.Drawing.Point(168, 51);
			this.btnGradeAdd.Name = "btnGradeAdd";
			this.btnGradeAdd.Size = new System.Drawing.Size(71, 23);
			this.btnGradeAdd.TabIndex = 6;
			this.btnGradeAdd.Text = "Add";
			this.btnGradeAdd.UseVisualStyleBackColor = true;
			this.btnGradeAdd.Click += new System.EventHandler(this.btnGrade7Add_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.comboBoxGrade);
			this.groupBox2.Controls.Add(this.btnGradeRemove);
			this.groupBox2.Controls.Add(this.comboBoxSection);
			this.groupBox2.Controls.Add(this.btnGradeAdd);
			this.groupBox2.Location = new System.Drawing.Point(293, 56);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(333, 88);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Junior High Sections";
			// 
			// comboBoxGrade
			// 
			this.comboBoxGrade.FormattingEnabled = true;
			this.comboBoxGrade.Location = new System.Drawing.Point(6, 21);
			this.comboBoxGrade.Name = "comboBoxGrade";
			this.comboBoxGrade.Size = new System.Drawing.Size(156, 24);
			this.comboBoxGrade.TabIndex = 8;
			this.comboBoxGrade.Leave += new System.EventHandler(this.comboBoxGrade_Leave);
			// 
			// btnGradeRemove
			// 
			this.btnGradeRemove.Location = new System.Drawing.Point(253, 51);
			this.btnGradeRemove.Name = "btnGradeRemove";
			this.btnGradeRemove.Size = new System.Drawing.Size(71, 23);
			this.btnGradeRemove.TabIndex = 7;
			this.btnGradeRemove.Text = "Remove";
			this.btnGradeRemove.UseVisualStyleBackColor = true;
			this.btnGradeRemove.Click += new System.EventHandler(this.btnGrade7Remove_Click);
			// 
			// groupBoxSY
			// 
			this.groupBoxSY.Controls.Add(this.comboBoxSY);
			this.groupBoxSY.Controls.Add(this.btnRemoveSY);
			this.groupBoxSY.Controls.Add(this.btnAddSY);
			this.groupBoxSY.Location = new System.Drawing.Point(640, 56);
			this.groupBoxSY.Name = "groupBoxSY";
			this.groupBoxSY.Size = new System.Drawing.Size(168, 88);
			this.groupBoxSY.TabIndex = 8;
			this.groupBoxSY.TabStop = false;
			this.groupBoxSY.Text = "School Year";
			// 
			// comboBoxSY
			// 
			this.comboBoxSY.FormattingEnabled = true;
			this.comboBoxSY.Location = new System.Drawing.Point(6, 21);
			this.comboBoxSY.Name = "comboBoxSY";
			this.comboBoxSY.Size = new System.Drawing.Size(156, 24);
			this.comboBoxSY.TabIndex = 10;
			// 
			// btnRemoveSY
			// 
			this.btnRemoveSY.Location = new System.Drawing.Point(91, 52);
			this.btnRemoveSY.Name = "btnRemoveSY";
			this.btnRemoveSY.Size = new System.Drawing.Size(71, 23);
			this.btnRemoveSY.TabIndex = 9;
			this.btnRemoveSY.Text = "Remove";
			this.btnRemoveSY.UseVisualStyleBackColor = true;
			this.btnRemoveSY.Click += new System.EventHandler(this.btnRemoveSY_Click);
			// 
			// btnAddSY
			// 
			this.btnAddSY.Location = new System.Drawing.Point(6, 52);
			this.btnAddSY.Name = "btnAddSY";
			this.btnAddSY.Size = new System.Drawing.Size(71, 23);
			this.btnAddSY.TabIndex = 8;
			this.btnAddSY.Text = "Add";
			this.btnAddSY.UseVisualStyleBackColor = true;
			this.btnAddSY.Click += new System.EventHandler(this.btnAddSY_Click);
			// 
			// groupBoxStrand
			// 
			this.groupBoxStrand.Controls.Add(this.comboBoxStrand);
			this.groupBoxStrand.Controls.Add(this.btnRemoveStrand);
			this.groupBoxStrand.Controls.Add(this.btnAddStrand);
			this.groupBoxStrand.Location = new System.Drawing.Point(640, 150);
			this.groupBoxStrand.Name = "groupBoxStrand";
			this.groupBoxStrand.Size = new System.Drawing.Size(168, 87);
			this.groupBoxStrand.TabIndex = 9;
			this.groupBoxStrand.TabStop = false;
			this.groupBoxStrand.Text = "Senior High Strands";
			// 
			// comboBoxStrand
			// 
			this.comboBoxStrand.FormattingEnabled = true;
			this.comboBoxStrand.Location = new System.Drawing.Point(6, 21);
			this.comboBoxStrand.Name = "comboBoxStrand";
			this.comboBoxStrand.Size = new System.Drawing.Size(156, 24);
			this.comboBoxStrand.TabIndex = 13;
			// 
			// btnRemoveStrand
			// 
			this.btnRemoveStrand.Location = new System.Drawing.Point(91, 51);
			this.btnRemoveStrand.Name = "btnRemoveStrand";
			this.btnRemoveStrand.Size = new System.Drawing.Size(71, 23);
			this.btnRemoveStrand.TabIndex = 12;
			this.btnRemoveStrand.Text = "Remove";
			this.btnRemoveStrand.UseVisualStyleBackColor = true;
			this.btnRemoveStrand.Click += new System.EventHandler(this.btnRemoveStrand_Click);
			// 
			// btnAddStrand
			// 
			this.btnAddStrand.Location = new System.Drawing.Point(6, 51);
			this.btnAddStrand.Name = "btnAddStrand";
			this.btnAddStrand.Size = new System.Drawing.Size(71, 23);
			this.btnAddStrand.TabIndex = 11;
			this.btnAddStrand.Text = "Add";
			this.btnAddStrand.UseVisualStyleBackColor = true;
			this.btnAddStrand.Click += new System.EventHandler(this.btnAddStrand_Click);
			// 
			// groupBoxCourse
			// 
			this.groupBoxCourse.Location = new System.Drawing.Point(293, 150);
			this.groupBoxCourse.Name = "groupBoxCourse";
			this.groupBoxCourse.Size = new System.Drawing.Size(333, 100);
			this.groupBoxCourse.TabIndex = 10;
			this.groupBoxCourse.TabStop = false;
			this.groupBoxCourse.Text = "College Course";
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(814, 498);
			this.Controls.Add(this.groupBoxCourse);
			this.Controls.Add(this.groupBoxStrand);
			this.Controls.Add(this.groupBoxSY);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.panelGrayBG);
			this.Controls.Add(this.panelHeader);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Dashboard";
			this.Text = "Dashboard";
			this.Load += new System.EventHandler(this.Dashboard_Load);
			this.panelHeader.ResumeLayout(false);
			this.panelHeader.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panelGrayBG.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBoxSY.ResumeLayout(false);
			this.groupBoxStrand.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelHeader;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private Bunifu.Framework.UI.BunifuMetroTextbox textBoxUser;
		private Bunifu.Framework.UI.BunifuMetroTextbox textBoxPassword;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButtonUser;
		private System.Windows.Forms.RadioButton radioButtonAdmin;
		private System.Windows.Forms.Panel panelGrayBG;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ComboBox comboBoxSection;
		private System.Windows.Forms.Button btnGradeAdd;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnGradeRemove;
		private System.Windows.Forms.ComboBox comboBoxGrade;
		private System.Windows.Forms.GroupBox groupBoxSY;
		private System.Windows.Forms.ComboBox comboBoxSY;
		private System.Windows.Forms.Button btnRemoveSY;
		private System.Windows.Forms.Button btnAddSY;
		private System.Windows.Forms.GroupBox groupBoxStrand;
		private System.Windows.Forms.ComboBox comboBoxStrand;
		private System.Windows.Forms.Button btnRemoveStrand;
		private System.Windows.Forms.Button btnAddStrand;
		private System.Windows.Forms.GroupBox groupBoxCourse;
	}
}