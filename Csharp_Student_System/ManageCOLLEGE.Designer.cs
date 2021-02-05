namespace Csharp_Student_System
{
	partial class ManageCOLLEGE
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCOLLEGE));
			this.panelHeader = new System.Windows.Forms.Panel();
			this.pictureBoxSpam = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBoxBarcode = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tableLayoutPanelWithSearchBar = new System.Windows.Forms.TableLayoutPanel();
			this.SearchBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.buttonAddPrint = new System.Windows.Forms.Button();
			this.labelTotalStudents = new System.Windows.Forms.Label();
			this.panelFooter = new System.Windows.Forms.Panel();
			this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayout4Cells = new System.Windows.Forms.TableLayoutPanel();
			this.buttonRemove = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonReset = new System.Windows.Forms.Button();
			this.buttonAddStudent = new System.Windows.Forms.Button();
			this.tableLayout2Cells = new System.Windows.Forms.TableLayoutPanel();
			this.buttonUpload = new Bunifu.Framework.UI.BunifuFlatButton();
			this.pictureBoxStudentImage = new System.Windows.Forms.PictureBox();
			this.tableLayout1Cell = new System.Windows.Forms.TableLayoutPanel();
			this.textBoxContact = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.textBoxAddress = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.tableLayout6Cells = new System.Windows.Forms.TableLayoutPanel();
			this.textBoxFname = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.textBoxGuardian = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.textBoxMname = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.textBoxLname = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButtonFemale = new System.Windows.Forms.RadioButton();
			this.radioButtonMale = new System.Windows.Forms.RadioButton();
			this.comboBoxCourse = new System.Windows.Forms.ComboBox();
			this.comboBoxYear = new System.Windows.Forms.ComboBox();
			this.comboBoxSY = new System.Windows.Forms.ComboBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.generateBtn = new System.Windows.Forms.Button();
			this.textBoxIDno = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.tableLayoutPanelWithDatagGridView = new System.Windows.Forms.TableLayoutPanel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panelHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpam)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tableLayoutPanelWithSearchBar.SuspendLayout();
			this.panelFooter.SuspendLayout();
			this.tableLayoutMain.SuspendLayout();
			this.tableLayout4Cells.SuspendLayout();
			this.tableLayout2Cells.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudentImage)).BeginInit();
			this.tableLayout1Cell.SuspendLayout();
			this.tableLayout6Cells.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanelWithDatagGridView.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panelHeader
			// 
			this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
			this.panelHeader.Controls.Add(this.pictureBoxSpam);
			this.panelHeader.Controls.Add(this.button1);
			this.panelHeader.Controls.Add(this.pictureBoxBarcode);
			this.panelHeader.Controls.Add(this.pictureBox1);
			this.panelHeader.Controls.Add(this.label1);
			this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelHeader.Location = new System.Drawing.Point(0, 0);
			this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new System.Drawing.Size(814, 50);
			this.panelHeader.TabIndex = 2;
			// 
			// pictureBoxSpam
			// 
			this.pictureBoxSpam.Image = global::Csharp_Student_System.Properties.Resources.username;
			this.pictureBoxSpam.Location = new System.Drawing.Point(76, 12);
			this.pictureBoxSpam.Name = "pictureBoxSpam";
			this.pictureBoxSpam.Size = new System.Drawing.Size(34, 34);
			this.pictureBoxSpam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxSpam.TabIndex = 9;
			this.pictureBoxSpam.TabStop = false;
			this.pictureBoxSpam.Visible = false;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(687, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(123, 24);
			this.button1.TabIndex = 8;
			this.button1.Text = "Upload Barcode";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pictureBoxBarcode
			// 
			this.pictureBoxBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxBarcode.Location = new System.Drawing.Point(452, 3);
			this.pictureBoxBarcode.Name = "pictureBoxBarcode";
			this.pictureBoxBarcode.Size = new System.Drawing.Size(296, 95);
			this.pictureBoxBarcode.TabIndex = 7;
			this.pictureBoxBarcode.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox1.Image = global::Csharp_Student_System.Properties.Resources.back;
			this.pictureBox1.Location = new System.Drawing.Point(3, 10);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
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
			this.label1.Location = new System.Drawing.Point(308, 10);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(200, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "MANAGE COLLEGE";
			// 
			// tableLayoutPanelWithSearchBar
			// 
			this.tableLayoutPanelWithSearchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
			this.tableLayoutPanelWithSearchBar.ColumnCount = 3;
			this.tableLayoutPanelWithSearchBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanelWithSearchBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanelWithSearchBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanelWithSearchBar.Controls.Add(this.SearchBox, 0, 0);
			this.tableLayoutPanelWithSearchBar.Controls.Add(this.buttonAddPrint, 2, 0);
			this.tableLayoutPanelWithSearchBar.Controls.Add(this.labelTotalStudents, 1, 0);
			this.tableLayoutPanelWithSearchBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanelWithSearchBar.Location = new System.Drawing.Point(0, 50);
			this.tableLayoutPanelWithSearchBar.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanelWithSearchBar.Name = "tableLayoutPanelWithSearchBar";
			this.tableLayoutPanelWithSearchBar.RowCount = 1;
			this.tableLayoutPanelWithSearchBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelWithSearchBar.Size = new System.Drawing.Size(814, 45);
			this.tableLayoutPanelWithSearchBar.TabIndex = 4;
			// 
			// SearchBox
			// 
			this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.SearchBox.BorderColorFocused = System.Drawing.Color.Blue;
			this.SearchBox.BorderColorIdle = System.Drawing.SystemColors.ButtonFace;
			this.SearchBox.BorderColorMouseHover = System.Drawing.Color.Blue;
			this.SearchBox.BorderThickness = 1;
			this.SearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.SearchBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.SearchBox.ForeColor = System.Drawing.Color.Transparent;
			this.SearchBox.isPassword = false;
			this.SearchBox.Location = new System.Drawing.Point(5, 9);
			this.SearchBox.Margin = new System.Windows.Forms.Padding(5);
			this.SearchBox.MaximumSize = new System.Drawing.Size(200, 31);
			this.SearchBox.Name = "SearchBox";
			this.SearchBox.Size = new System.Drawing.Size(200, 31);
			this.SearchBox.TabIndex = 2;
			this.SearchBox.Text = "Search";
			this.SearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.SearchBox.Enter += new System.EventHandler(this.SearchBox_Enter);
			this.SearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchBox_KeyPress);
			this.SearchBox.Leave += new System.EventHandler(this.SearchBox_Leave);
			// 
			// buttonAddPrint
			// 
			this.buttonAddPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAddPrint.BackColor = System.Drawing.Color.Olive;
			this.buttonAddPrint.FlatAppearance.BorderSize = 0;
			this.buttonAddPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAddPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAddPrint.ForeColor = System.Drawing.Color.White;
			this.buttonAddPrint.Location = new System.Drawing.Point(610, 10);
			this.buttonAddPrint.Margin = new System.Windows.Forms.Padding(4);
			this.buttonAddPrint.MaximumSize = new System.Drawing.Size(200, 31);
			this.buttonAddPrint.Name = "buttonAddPrint";
			this.buttonAddPrint.Size = new System.Drawing.Size(200, 31);
			this.buttonAddPrint.TabIndex = 4;
			this.buttonAddPrint.Text = "Add To Variable";
			this.buttonAddPrint.UseVisualStyleBackColor = false;
			this.buttonAddPrint.Click += new System.EventHandler(this.buttonAddPrint_Click);
			// 
			// labelTotalStudents
			// 
			this.labelTotalStudents.AutoSize = true;
			this.labelTotalStudents.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelTotalStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTotalStudents.ForeColor = System.Drawing.Color.White;
			this.labelTotalStudents.Location = new System.Drawing.Point(275, 0);
			this.labelTotalStudents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelTotalStudents.Name = "labelTotalStudents";
			this.labelTotalStudents.Size = new System.Drawing.Size(263, 45);
			this.labelTotalStudents.TabIndex = 3;
			this.labelTotalStudents.Text = "Total";
			this.labelTotalStudents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelFooter
			// 
			this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.panelFooter.Controls.Add(this.tableLayoutMain);
			this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelFooter.Location = new System.Drawing.Point(0, 359);
			this.panelFooter.Margin = new System.Windows.Forms.Padding(4);
			this.panelFooter.Name = "panelFooter";
			this.panelFooter.Size = new System.Drawing.Size(814, 139);
			this.panelFooter.TabIndex = 5;
			// 
			// tableLayoutMain
			// 
			this.tableLayoutMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutMain.BackColor = System.Drawing.Color.WhiteSmoke;
			this.tableLayoutMain.ColumnCount = 4;
			this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.01F));
			this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66333F));
			this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66333F));
			this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66333F));
			this.tableLayoutMain.Controls.Add(this.tableLayout4Cells, 3, 0);
			this.tableLayoutMain.Controls.Add(this.tableLayout2Cells, 2, 0);
			this.tableLayoutMain.Controls.Add(this.tableLayout1Cell, 1, 0);
			this.tableLayoutMain.Controls.Add(this.tableLayout6Cells, 0, 0);
			this.tableLayoutMain.Location = new System.Drawing.Point(4, 4);
			this.tableLayoutMain.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutMain.Name = "tableLayoutMain";
			this.tableLayoutMain.RowCount = 1;
			this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutMain.Size = new System.Drawing.Size(806, 132);
			this.tableLayoutMain.TabIndex = 0;
			// 
			// tableLayout4Cells
			// 
			this.tableLayout4Cells.ColumnCount = 1;
			this.tableLayout4Cells.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayout4Cells.Controls.Add(this.buttonRemove, 0, 3);
			this.tableLayout4Cells.Controls.Add(this.buttonEdit, 0, 2);
			this.tableLayout4Cells.Controls.Add(this.buttonReset, 0, 1);
			this.tableLayout4Cells.Controls.Add(this.buttonAddStudent, 0, 0);
			this.tableLayout4Cells.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayout4Cells.Location = new System.Drawing.Point(675, 4);
			this.tableLayout4Cells.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayout4Cells.Name = "tableLayout4Cells";
			this.tableLayout4Cells.RowCount = 4;
			this.tableLayout4Cells.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayout4Cells.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayout4Cells.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayout4Cells.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayout4Cells.Size = new System.Drawing.Size(127, 124);
			this.tableLayout4Cells.TabIndex = 0;
			// 
			// buttonRemove
			// 
			this.buttonRemove.BackColor = System.Drawing.Color.Red;
			this.buttonRemove.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonRemove.FlatAppearance.BorderSize = 0;
			this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonRemove.ForeColor = System.Drawing.Color.White;
			this.buttonRemove.Location = new System.Drawing.Point(4, 97);
			this.buttonRemove.Margin = new System.Windows.Forms.Padding(4);
			this.buttonRemove.Name = "buttonRemove";
			this.buttonRemove.Size = new System.Drawing.Size(119, 23);
			this.buttonRemove.TabIndex = 4;
			this.buttonRemove.Text = "Delete";
			this.buttonRemove.UseVisualStyleBackColor = false;
			this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
			// 
			// buttonEdit
			// 
			this.buttonEdit.BackColor = System.Drawing.Color.Maroon;
			this.buttonEdit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonEdit.FlatAppearance.BorderSize = 0;
			this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonEdit.ForeColor = System.Drawing.Color.White;
			this.buttonEdit.Location = new System.Drawing.Point(4, 66);
			this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(119, 23);
			this.buttonEdit.TabIndex = 4;
			this.buttonEdit.Text = "Edit";
			this.buttonEdit.UseVisualStyleBackColor = false;
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			// 
			// buttonReset
			// 
			this.buttonReset.BackColor = System.Drawing.Color.SeaGreen;
			this.buttonReset.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonReset.FlatAppearance.BorderSize = 0;
			this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonReset.ForeColor = System.Drawing.Color.White;
			this.buttonReset.Location = new System.Drawing.Point(4, 35);
			this.buttonReset.Margin = new System.Windows.Forms.Padding(4);
			this.buttonReset.Name = "buttonReset";
			this.buttonReset.Size = new System.Drawing.Size(119, 23);
			this.buttonReset.TabIndex = 4;
			this.buttonReset.Text = "Clear Fields";
			this.buttonReset.UseVisualStyleBackColor = false;
			this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
			// 
			// buttonAddStudent
			// 
			this.buttonAddStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(131)))), ((int)(((byte)(215)))));
			this.buttonAddStudent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonAddStudent.FlatAppearance.BorderSize = 0;
			this.buttonAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAddStudent.ForeColor = System.Drawing.Color.White;
			this.buttonAddStudent.Location = new System.Drawing.Point(4, 4);
			this.buttonAddStudent.Margin = new System.Windows.Forms.Padding(4);
			this.buttonAddStudent.Name = "buttonAddStudent";
			this.buttonAddStudent.Size = new System.Drawing.Size(119, 23);
			this.buttonAddStudent.TabIndex = 1;
			this.buttonAddStudent.Text = "Add";
			this.buttonAddStudent.UseVisualStyleBackColor = false;
			this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
			// 
			// tableLayout2Cells
			// 
			this.tableLayout2Cells.ColumnCount = 1;
			this.tableLayout2Cells.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayout2Cells.Controls.Add(this.buttonUpload, 0, 1);
			this.tableLayout2Cells.Controls.Add(this.pictureBoxStudentImage, 0, 0);
			this.tableLayout2Cells.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayout2Cells.Location = new System.Drawing.Point(541, 4);
			this.tableLayout2Cells.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayout2Cells.Name = "tableLayout2Cells";
			this.tableLayout2Cells.RowCount = 2;
			this.tableLayout2Cells.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
			this.tableLayout2Cells.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayout2Cells.Size = new System.Drawing.Size(126, 124);
			this.tableLayout2Cells.TabIndex = 1;
			// 
			// buttonUpload
			// 
			this.buttonUpload.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.buttonUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(131)))), ((int)(((byte)(215)))));
			this.buttonUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonUpload.BorderRadius = 0;
			this.buttonUpload.ButtonText = "Upload";
			this.buttonUpload.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonUpload.DisabledColor = System.Drawing.Color.Gray;
			this.buttonUpload.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonUpload.Iconcolor = System.Drawing.Color.Transparent;
			this.buttonUpload.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonUpload.Iconimage")));
			this.buttonUpload.Iconimage_right = null;
			this.buttonUpload.Iconimage_right_Selected = null;
			this.buttonUpload.Iconimage_Selected = null;
			this.buttonUpload.IconMarginLeft = 0;
			this.buttonUpload.IconMarginRight = 0;
			this.buttonUpload.IconRightVisible = true;
			this.buttonUpload.IconRightZoom = 0D;
			this.buttonUpload.IconVisible = true;
			this.buttonUpload.IconZoom = 90D;
			this.buttonUpload.IsTab = false;
			this.buttonUpload.Location = new System.Drawing.Point(5, 98);
			this.buttonUpload.Margin = new System.Windows.Forms.Padding(5);
			this.buttonUpload.Name = "buttonUpload";
			this.buttonUpload.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.buttonUpload.OnHovercolor = System.Drawing.Color.Blue;
			this.buttonUpload.OnHoverTextColor = System.Drawing.Color.White;
			this.buttonUpload.selected = false;
			this.buttonUpload.Size = new System.Drawing.Size(116, 21);
			this.buttonUpload.TabIndex = 75;
			this.buttonUpload.Text = "Upload";
			this.buttonUpload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonUpload.Textcolor = System.Drawing.Color.White;
			this.buttonUpload.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
			// 
			// pictureBoxStudentImage
			// 
			this.pictureBoxStudentImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBoxStudentImage.Image = global::Csharp_Student_System.Properties.Resources.username;
			this.pictureBoxStudentImage.Location = new System.Drawing.Point(4, 4);
			this.pictureBoxStudentImage.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBoxStudentImage.Name = "pictureBoxStudentImage";
			this.pictureBoxStudentImage.Size = new System.Drawing.Size(118, 85);
			this.pictureBoxStudentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxStudentImage.TabIndex = 74;
			this.pictureBoxStudentImage.TabStop = false;
			// 
			// tableLayout1Cell
			// 
			this.tableLayout1Cell.ColumnCount = 1;
			this.tableLayout1Cell.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayout1Cell.Controls.Add(this.textBoxContact, 0, 0);
			this.tableLayout1Cell.Controls.Add(this.textBoxAddress, 0, 1);
			this.tableLayout1Cell.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayout1Cell.Location = new System.Drawing.Point(407, 4);
			this.tableLayout1Cell.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayout1Cell.Name = "tableLayout1Cell";
			this.tableLayout1Cell.RowCount = 2;
			this.tableLayout1Cell.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33555F));
			this.tableLayout1Cell.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66445F));
			this.tableLayout1Cell.Size = new System.Drawing.Size(126, 124);
			this.tableLayout1Cell.TabIndex = 2;
			// 
			// textBoxContact
			// 
			this.textBoxContact.BackColor = System.Drawing.Color.LightGray;
			this.textBoxContact.BorderColorFocused = System.Drawing.Color.Blue;
			this.textBoxContact.BorderColorIdle = System.Drawing.SystemColors.ButtonFace;
			this.textBoxContact.BorderColorMouseHover = System.Drawing.Color.Blue;
			this.textBoxContact.BorderThickness = 1;
			this.textBoxContact.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBoxContact.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxContact.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.textBoxContact.ForeColor = System.Drawing.Color.Black;
			this.textBoxContact.isPassword = false;
			this.textBoxContact.Location = new System.Drawing.Point(5, 5);
			this.textBoxContact.Margin = new System.Windows.Forms.Padding(5);
			this.textBoxContact.MaximumSize = new System.Drawing.Size(267, 38);
			this.textBoxContact.Name = "textBoxContact";
			this.textBoxContact.Size = new System.Drawing.Size(116, 31);
			this.textBoxContact.TabIndex = 72;
			this.textBoxContact.Text = "Contact No.";
			this.textBoxContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxContact.Enter += new System.EventHandler(this.textBoxContact_Enter);
			this.textBoxContact.Leave += new System.EventHandler(this.textBoxContact_Leave);
			// 
			// textBoxAddress
			// 
			this.textBoxAddress.BackColor = System.Drawing.Color.LightGray;
			this.textBoxAddress.BorderColorFocused = System.Drawing.Color.Blue;
			this.textBoxAddress.BorderColorIdle = System.Drawing.SystemColors.ButtonFace;
			this.textBoxAddress.BorderColorMouseHover = System.Drawing.Color.Blue;
			this.textBoxAddress.BorderThickness = 1;
			this.textBoxAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBoxAddress.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.textBoxAddress.ForeColor = System.Drawing.Color.Black;
			this.textBoxAddress.isPassword = false;
			this.textBoxAddress.Location = new System.Drawing.Point(5, 46);
			this.textBoxAddress.Margin = new System.Windows.Forms.Padding(5);
			this.textBoxAddress.MaximumSize = new System.Drawing.Size(267, 142);
			this.textBoxAddress.Name = "textBoxAddress";
			this.textBoxAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.textBoxAddress.Size = new System.Drawing.Size(116, 73);
			this.textBoxAddress.TabIndex = 73;
			this.textBoxAddress.Text = "Address";
			this.textBoxAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxAddress.Enter += new System.EventHandler(this.textBoxAddress_Enter);
			this.textBoxAddress.Leave += new System.EventHandler(this.textBoxAddress_Leave);
			// 
			// tableLayout6Cells
			// 
			this.tableLayout6Cells.ColumnCount = 3;
			this.tableLayout6Cells.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayout6Cells.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayout6Cells.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayout6Cells.Controls.Add(this.textBoxFname, 0, 1);
			this.tableLayout6Cells.Controls.Add(this.textBoxGuardian, 2, 2);
			this.tableLayout6Cells.Controls.Add(this.textBoxMname, 0, 2);
			this.tableLayout6Cells.Controls.Add(this.textBoxLname, 1, 0);
			this.tableLayout6Cells.Controls.Add(this.groupBox1, 1, 1);
			this.tableLayout6Cells.Controls.Add(this.comboBoxCourse, 1, 2);
			this.tableLayout6Cells.Controls.Add(this.comboBoxYear, 2, 0);
			this.tableLayout6Cells.Controls.Add(this.comboBoxSY, 2, 1);
			this.tableLayout6Cells.Controls.Add(this.tableLayoutPanel1, 0, 0);
			this.tableLayout6Cells.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayout6Cells.Location = new System.Drawing.Point(4, 4);
			this.tableLayout6Cells.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayout6Cells.Name = "tableLayout6Cells";
			this.tableLayout6Cells.RowCount = 3;
			this.tableLayout6Cells.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayout6Cells.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayout6Cells.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayout6Cells.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayout6Cells.Size = new System.Drawing.Size(395, 124);
			this.tableLayout6Cells.TabIndex = 3;
			// 
			// textBoxFname
			// 
			this.textBoxFname.BackColor = System.Drawing.Color.LightGray;
			this.textBoxFname.BorderColorFocused = System.Drawing.Color.Blue;
			this.textBoxFname.BorderColorIdle = System.Drawing.SystemColors.ButtonFace;
			this.textBoxFname.BorderColorMouseHover = System.Drawing.Color.Blue;
			this.textBoxFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxFname.BorderThickness = 1;
			this.textBoxFname.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBoxFname.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxFname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.textBoxFname.ForeColor = System.Drawing.Color.Black;
			this.textBoxFname.isPassword = false;
			this.textBoxFname.Location = new System.Drawing.Point(5, 46);
			this.textBoxFname.Margin = new System.Windows.Forms.Padding(5);
			this.textBoxFname.MaximumSize = new System.Drawing.Size(267, 38);
			this.textBoxFname.Name = "textBoxFname";
			this.textBoxFname.Size = new System.Drawing.Size(121, 31);
			this.textBoxFname.TabIndex = 2;
			this.textBoxFname.Text = "First Name";
			this.textBoxFname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxFname.Enter += new System.EventHandler(this.textBoxFname_Enter);
			this.textBoxFname.Leave += new System.EventHandler(this.textBoxFname_Leave);
			// 
			// textBoxGuardian
			// 
			this.textBoxGuardian.BackColor = System.Drawing.Color.LightGray;
			this.textBoxGuardian.BorderColorFocused = System.Drawing.Color.Blue;
			this.textBoxGuardian.BorderColorIdle = System.Drawing.SystemColors.ButtonFace;
			this.textBoxGuardian.BorderColorMouseHover = System.Drawing.Color.Blue;
			this.textBoxGuardian.BorderThickness = 1;
			this.textBoxGuardian.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBoxGuardian.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxGuardian.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.textBoxGuardian.ForeColor = System.Drawing.Color.Black;
			this.textBoxGuardian.isPassword = false;
			this.textBoxGuardian.Location = new System.Drawing.Point(267, 87);
			this.textBoxGuardian.Margin = new System.Windows.Forms.Padding(5);
			this.textBoxGuardian.MaximumSize = new System.Drawing.Size(267, 38);
			this.textBoxGuardian.Name = "textBoxGuardian";
			this.textBoxGuardian.Size = new System.Drawing.Size(123, 32);
			this.textBoxGuardian.TabIndex = 71;
			this.textBoxGuardian.Text = "Guardian";
			this.textBoxGuardian.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxGuardian.Enter += new System.EventHandler(this.textBoxGuardian_Enter);
			this.textBoxGuardian.Leave += new System.EventHandler(this.textBoxGuardian_Leave);
			// 
			// textBoxMname
			// 
			this.textBoxMname.BackColor = System.Drawing.Color.LightGray;
			this.textBoxMname.BorderColorFocused = System.Drawing.Color.Blue;
			this.textBoxMname.BorderColorIdle = System.Drawing.SystemColors.ButtonFace;
			this.textBoxMname.BorderColorMouseHover = System.Drawing.Color.Blue;
			this.textBoxMname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxMname.BorderThickness = 1;
			this.textBoxMname.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBoxMname.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxMname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.textBoxMname.ForeColor = System.Drawing.Color.Black;
			this.textBoxMname.isPassword = false;
			this.textBoxMname.Location = new System.Drawing.Point(5, 87);
			this.textBoxMname.Margin = new System.Windows.Forms.Padding(5);
			this.textBoxMname.MaximumSize = new System.Drawing.Size(267, 38);
			this.textBoxMname.Name = "textBoxMname";
			this.textBoxMname.Size = new System.Drawing.Size(121, 32);
			this.textBoxMname.TabIndex = 3;
			this.textBoxMname.Text = "Middle Initial";
			this.textBoxMname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxMname.Enter += new System.EventHandler(this.textBoxMname_Enter);
			this.textBoxMname.Leave += new System.EventHandler(this.textBoxMname_Leave);
			// 
			// textBoxLname
			// 
			this.textBoxLname.BackColor = System.Drawing.Color.LightGray;
			this.textBoxLname.BorderColorFocused = System.Drawing.Color.Blue;
			this.textBoxLname.BorderColorIdle = System.Drawing.SystemColors.ButtonFace;
			this.textBoxLname.BorderColorMouseHover = System.Drawing.Color.Blue;
			this.textBoxLname.BorderThickness = 1;
			this.textBoxLname.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBoxLname.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxLname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.textBoxLname.ForeColor = System.Drawing.Color.Black;
			this.textBoxLname.isPassword = false;
			this.textBoxLname.Location = new System.Drawing.Point(136, 5);
			this.textBoxLname.Margin = new System.Windows.Forms.Padding(5);
			this.textBoxLname.MaximumSize = new System.Drawing.Size(267, 38);
			this.textBoxLname.Name = "textBoxLname";
			this.textBoxLname.Size = new System.Drawing.Size(121, 31);
			this.textBoxLname.TabIndex = 4;
			this.textBoxLname.Text = "Last Name";
			this.textBoxLname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxLname.Enter += new System.EventHandler(this.textBoxLname_Enter);
			this.textBoxLname.Leave += new System.EventHandler(this.textBoxLname_Leave);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButtonFemale);
			this.groupBox1.Controls.Add(this.radioButtonMale);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(135, 45);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.MaximumSize = new System.Drawing.Size(264, 48);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(123, 33);
			this.groupBox1.TabIndex = 67;
			this.groupBox1.TabStop = false;
			// 
			// radioButtonFemale
			// 
			this.radioButtonFemale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButtonFemale.AutoSize = true;
			this.radioButtonFemale.BackColor = System.Drawing.Color.LightGray;
			this.radioButtonFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButtonFemale.ForeColor = System.Drawing.Color.Black;
			this.radioButtonFemale.Location = new System.Drawing.Point(49, 8);
			this.radioButtonFemale.Margin = new System.Windows.Forms.Padding(4);
			this.radioButtonFemale.Name = "radioButtonFemale";
			this.radioButtonFemale.Size = new System.Drawing.Size(72, 20);
			this.radioButtonFemale.TabIndex = 1;
			this.radioButtonFemale.TabStop = true;
			this.radioButtonFemale.Text = "Female";
			this.radioButtonFemale.UseVisualStyleBackColor = false;
			// 
			// radioButtonMale
			// 
			this.radioButtonMale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.radioButtonMale.AutoSize = true;
			this.radioButtonMale.BackColor = System.Drawing.Color.LightGray;
			this.radioButtonMale.Checked = true;
			this.radioButtonMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButtonMale.ForeColor = System.Drawing.Color.Black;
			this.radioButtonMale.Location = new System.Drawing.Point(1, 8);
			this.radioButtonMale.Margin = new System.Windows.Forms.Padding(4);
			this.radioButtonMale.Name = "radioButtonMale";
			this.radioButtonMale.Size = new System.Drawing.Size(56, 20);
			this.radioButtonMale.TabIndex = 0;
			this.radioButtonMale.TabStop = true;
			this.radioButtonMale.Text = "Male";
			this.radioButtonMale.UseVisualStyleBackColor = false;
			// 
			// comboBoxCourse
			// 
			this.comboBoxCourse.BackColor = System.Drawing.Color.LightGray;
			this.comboBoxCourse.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBoxCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxCourse.ForeColor = System.Drawing.Color.Black;
			this.comboBoxCourse.FormattingEnabled = true;
			this.comboBoxCourse.Location = new System.Drawing.Point(135, 86);
			this.comboBoxCourse.Margin = new System.Windows.Forms.Padding(4);
			this.comboBoxCourse.MaximumSize = new System.Drawing.Size(265, 0);
			this.comboBoxCourse.Name = "comboBoxCourse";
			this.comboBoxCourse.Size = new System.Drawing.Size(123, 26);
			this.comboBoxCourse.TabIndex = 72;
			this.comboBoxCourse.Leave += new System.EventHandler(this.comboBoxCourse_Leave);
			// 
			// comboBoxYear
			// 
			this.comboBoxYear.BackColor = System.Drawing.Color.LightGray;
			this.comboBoxYear.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBoxYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxYear.ForeColor = System.Drawing.Color.Black;
			this.comboBoxYear.FormattingEnabled = true;
			this.comboBoxYear.Location = new System.Drawing.Point(266, 4);
			this.comboBoxYear.Margin = new System.Windows.Forms.Padding(4);
			this.comboBoxYear.MaximumSize = new System.Drawing.Size(265, 0);
			this.comboBoxYear.Name = "comboBoxYear";
			this.comboBoxYear.Size = new System.Drawing.Size(125, 26);
			this.comboBoxYear.TabIndex = 73;
			// 
			// comboBoxSY
			// 
			this.comboBoxSY.BackColor = System.Drawing.Color.LightGray;
			this.comboBoxSY.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBoxSY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxSY.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxSY.ForeColor = System.Drawing.Color.Black;
			this.comboBoxSY.FormattingEnabled = true;
			this.comboBoxSY.Location = new System.Drawing.Point(266, 45);
			this.comboBoxSY.Margin = new System.Windows.Forms.Padding(4);
			this.comboBoxSY.MaximumSize = new System.Drawing.Size(265, 0);
			this.comboBoxSY.Name = "comboBoxSY";
			this.comboBoxSY.Size = new System.Drawing.Size(125, 26);
			this.comboBoxSY.TabIndex = 74;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.generateBtn, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.textBoxIDno, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(125, 35);
			this.tableLayoutPanel1.TabIndex = 75;
			// 
			// generateBtn
			// 
			this.generateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(131)))), ((int)(((byte)(215)))));
			this.generateBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.generateBtn.FlatAppearance.BorderSize = 0;
			this.generateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.generateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.generateBtn.ForeColor = System.Drawing.Color.White;
			this.generateBtn.Location = new System.Drawing.Point(65, 3);
			this.generateBtn.Name = "generateBtn";
			this.generateBtn.Size = new System.Drawing.Size(57, 29);
			this.generateBtn.TabIndex = 5;
			this.generateBtn.Text = "Generate Barcode";
			this.generateBtn.UseVisualStyleBackColor = false;
			this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
			// 
			// textBoxIDno
			// 
			this.textBoxIDno.BackColor = System.Drawing.Color.LightGray;
			this.textBoxIDno.BorderColorFocused = System.Drawing.Color.Blue;
			this.textBoxIDno.BorderColorIdle = System.Drawing.SystemColors.ActiveCaptionText;
			this.textBoxIDno.BorderColorMouseHover = System.Drawing.Color.Blue;
			this.textBoxIDno.BorderThickness = 1;
			this.textBoxIDno.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBoxIDno.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxIDno.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.textBoxIDno.ForeColor = System.Drawing.Color.Black;
			this.textBoxIDno.isPassword = false;
			this.textBoxIDno.Location = new System.Drawing.Point(5, 5);
			this.textBoxIDno.Margin = new System.Windows.Forms.Padding(5);
			this.textBoxIDno.MaximumSize = new System.Drawing.Size(267, 38);
			this.textBoxIDno.Name = "textBoxIDno";
			this.textBoxIDno.Size = new System.Drawing.Size(52, 25);
			this.textBoxIDno.TabIndex = 1;
			this.textBoxIDno.Text = "ID No.";
			this.textBoxIDno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxIDno.Enter += new System.EventHandler(this.textBoxIDno_Enter);
			this.textBoxIDno.Leave += new System.EventHandler(this.textBoxIDno_Leave);
			// 
			// tableLayoutPanelWithDatagGridView
			// 
			this.tableLayoutPanelWithDatagGridView.ColumnCount = 1;
			this.tableLayoutPanelWithDatagGridView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelWithDatagGridView.Controls.Add(this.dataGridView1, 0, 0);
			this.tableLayoutPanelWithDatagGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelWithDatagGridView.Location = new System.Drawing.Point(0, 95);
			this.tableLayoutPanelWithDatagGridView.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanelWithDatagGridView.Name = "tableLayoutPanelWithDatagGridView";
			this.tableLayoutPanelWithDatagGridView.RowCount = 1;
			this.tableLayoutPanelWithDatagGridView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelWithDatagGridView.Size = new System.Drawing.Size(814, 264);
			this.tableLayoutPanelWithDatagGridView.TabIndex = 6;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(4, 4);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(806, 256);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
			// 
			// ManageCOLLEGE
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(814, 498);
			this.Controls.Add(this.tableLayoutPanelWithDatagGridView);
			this.Controls.Add(this.panelFooter);
			this.Controls.Add(this.tableLayoutPanelWithSearchBar);
			this.Controls.Add(this.panelHeader);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "ManageCOLLEGE";
			this.Text = "ManageCOLLEGE";
			this.Load += new System.EventHandler(this.ManageCOLLEGE_Load);
			this.panelHeader.ResumeLayout(false);
			this.panelHeader.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpam)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tableLayoutPanelWithSearchBar.ResumeLayout(false);
			this.tableLayoutPanelWithSearchBar.PerformLayout();
			this.panelFooter.ResumeLayout(false);
			this.tableLayoutMain.ResumeLayout(false);
			this.tableLayout4Cells.ResumeLayout(false);
			this.tableLayout2Cells.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudentImage)).EndInit();
			this.tableLayout1Cell.ResumeLayout(false);
			this.tableLayout6Cells.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanelWithDatagGridView.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelHeader;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelWithSearchBar;
		private Bunifu.Framework.UI.BunifuMetroTextbox SearchBox;
		private System.Windows.Forms.Button buttonAddPrint;
		private System.Windows.Forms.Label labelTotalStudents;
		private System.Windows.Forms.Panel panelFooter;
		private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
		private System.Windows.Forms.TableLayoutPanel tableLayout4Cells;
		private System.Windows.Forms.Button buttonRemove;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Button buttonReset;
		private System.Windows.Forms.Button buttonAddStudent;
		private System.Windows.Forms.TableLayoutPanel tableLayout2Cells;
		private Bunifu.Framework.UI.BunifuFlatButton buttonUpload;
		private System.Windows.Forms.PictureBox pictureBoxStudentImage;
		private System.Windows.Forms.TableLayoutPanel tableLayout1Cell;
		private Bunifu.Framework.UI.BunifuMetroTextbox textBoxAddress;
		private Bunifu.Framework.UI.BunifuMetroTextbox textBoxContact;
		private Bunifu.Framework.UI.BunifuMetroTextbox textBoxGuardian;
		private System.Windows.Forms.TableLayoutPanel tableLayout6Cells;
		private System.Windows.Forms.ComboBox comboBoxYear;
		private System.Windows.Forms.ComboBox comboBoxCourse;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButtonFemale;
		private System.Windows.Forms.RadioButton radioButtonMale;
		private Bunifu.Framework.UI.BunifuMetroTextbox textBoxLname;
		private Bunifu.Framework.UI.BunifuMetroTextbox textBoxMname;
		private Bunifu.Framework.UI.BunifuMetroTextbox textBoxFname;
		private Bunifu.Framework.UI.BunifuMetroTextbox textBoxIDno;
		private System.Windows.Forms.ComboBox comboBoxSY;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelWithDatagGridView;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button1;
		public System.Windows.Forms.PictureBox pictureBoxBarcode;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button generateBtn;
		private System.Windows.Forms.PictureBox pictureBoxSpam;
	}
}