namespace Csharp_Student_System
{
	partial class PrintELEM
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
			this.buttonAddStudent = new System.Windows.Forms.Button();
			this.panelFooter = new System.Windows.Forms.TableLayoutPanel();
			this.buttonClearList = new System.Windows.Forms.Button();
			this.panelHeader = new System.Windows.Forms.Panel();
			this.pictureBoxBarcode = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBoxStudentImage = new System.Windows.Forms.PictureBox();
			this.panelBody = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panelFooter.SuspendLayout();
			this.panelHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudentImage)).BeginInit();
			this.panelBody.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonAddStudent
			// 
			this.buttonAddStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.buttonAddStudent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAddStudent.ForeColor = System.Drawing.Color.White;
			this.buttonAddStudent.Location = new System.Drawing.Point(207, 4);
			this.buttonAddStudent.Margin = new System.Windows.Forms.Padding(4);
			this.buttonAddStudent.Name = "buttonAddStudent";
			this.buttonAddStudent.Size = new System.Drawing.Size(603, 62);
			this.buttonAddStudent.TabIndex = 1;
			this.buttonAddStudent.Text = "EXPORT TO TEXT FILE";
			this.buttonAddStudent.UseVisualStyleBackColor = false;
			this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
			// 
			// panelFooter
			// 
			this.panelFooter.ColumnCount = 2;
			this.panelFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.panelFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
			this.panelFooter.Controls.Add(this.buttonAddStudent, 1, 0);
			this.panelFooter.Controls.Add(this.buttonClearList, 0, 0);
			this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelFooter.Location = new System.Drawing.Point(0, 428);
			this.panelFooter.Margin = new System.Windows.Forms.Padding(4);
			this.panelFooter.Name = "panelFooter";
			this.panelFooter.RowCount = 1;
			this.panelFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.panelFooter.Size = new System.Drawing.Size(814, 70);
			this.panelFooter.TabIndex = 1;
			// 
			// buttonClearList
			// 
			this.buttonClearList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.buttonClearList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonClearList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonClearList.ForeColor = System.Drawing.Color.White;
			this.buttonClearList.Location = new System.Drawing.Point(4, 4);
			this.buttonClearList.Margin = new System.Windows.Forms.Padding(4);
			this.buttonClearList.Name = "buttonClearList";
			this.buttonClearList.Size = new System.Drawing.Size(195, 62);
			this.buttonClearList.TabIndex = 2;
			this.buttonClearList.Text = "Clear List";
			this.buttonClearList.UseVisualStyleBackColor = false;
			this.buttonClearList.Click += new System.EventHandler(this.buttonClearList_Click);
			// 
			// panelHeader
			// 
			this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
			this.panelHeader.Controls.Add(this.pictureBoxBarcode);
			this.panelHeader.Controls.Add(this.label1);
			this.panelHeader.Controls.Add(this.pictureBox1);
			this.panelHeader.Controls.Add(this.pictureBoxStudentImage);
			this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelHeader.Location = new System.Drawing.Point(0, 0);
			this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new System.Drawing.Size(814, 50);
			this.panelHeader.TabIndex = 3;
			// 
			// pictureBoxBarcode
			// 
			this.pictureBoxBarcode.BackColor = System.Drawing.Color.DarkGray;
			this.pictureBoxBarcode.Location = new System.Drawing.Point(710, 13);
			this.pictureBoxBarcode.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBoxBarcode.Name = "pictureBoxBarcode";
			this.pictureBoxBarcode.Size = new System.Drawing.Size(31, 30);
			this.pictureBoxBarcode.TabIndex = 4;
			this.pictureBoxBarcode.TabStop = false;
			this.pictureBoxBarcode.Visible = false;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(283, 10);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(254, 24);
			this.label1.TabIndex = 3;
			this.label1.Text = "ELEMENTARY VARIABLE";
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
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// pictureBoxStudentImage
			// 
			this.pictureBoxStudentImage.BackColor = System.Drawing.Color.DarkGray;
			this.pictureBoxStudentImage.Location = new System.Drawing.Point(654, 13);
			this.pictureBoxStudentImage.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBoxStudentImage.Name = "pictureBoxStudentImage";
			this.pictureBoxStudentImage.Size = new System.Drawing.Size(31, 30);
			this.pictureBoxStudentImage.TabIndex = 1;
			this.pictureBoxStudentImage.TabStop = false;
			this.pictureBoxStudentImage.Visible = false;
			// 
			// panelBody
			// 
			this.panelBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
			this.panelBody.Controls.Add(this.dataGridView1);
			this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelBody.Location = new System.Drawing.Point(0, 50);
			this.panelBody.Name = "panelBody";
			this.panelBody.Size = new System.Drawing.Size(814, 378);
			this.panelBody.TabIndex = 4;
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(-40, 8);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView1.MaximumSize = new System.Drawing.Size(950, 600);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(939, 440);
			this.dataGridView1.TabIndex = 1;
			// 
			// PrintELEM
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.ClientSize = new System.Drawing.Size(814, 498);
			this.Controls.Add(this.panelBody);
			this.Controls.Add(this.panelHeader);
			this.Controls.Add(this.panelFooter);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "PrintELEM";
			this.Text = "PrintELEM";
			this.Load += new System.EventHandler(this.PrintELEM_Load);
			this.panelFooter.ResumeLayout(false);
			this.panelHeader.ResumeLayout(false);
			this.panelHeader.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudentImage)).EndInit();
			this.panelBody.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button buttonAddStudent;
		private System.Windows.Forms.PictureBox pictureBoxStudentImage;
		private System.Windows.Forms.TableLayoutPanel panelFooter;
		private System.Windows.Forms.Button buttonClearList;
		private System.Windows.Forms.Panel panelHeader;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panelBody;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.PictureBox pictureBoxBarcode;
	}
}