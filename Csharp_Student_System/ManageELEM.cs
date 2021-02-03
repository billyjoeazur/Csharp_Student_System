using BarcodeLib;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Student_System
{
	public partial class ManageELEM : Form
	{
		Main mymain = new Main();
		public ManageELEM(string user)
		{
			InitializeComponent();
			if (user != "Admin")
			{
				buttonEdit.Hide();
				buttonRemove.Hide();
			}
			else
			{
				buttonEdit.Show();
				buttonRemove.Show();
			}
		}

		public ManageELEM()
		{
		}
		MY_DB db = new MY_DB();
		STUDENT student = new STUDENT();

		private void textBoxLRN_Enter(object sender, EventArgs e)
		{
			if (textBoxLRN.Text == "LRN")
			{
				textBoxLRN.Text = "";
				textBoxLRN.ForeColor = Color.White;
			}
			
		}
		private void textBoxLRN_Leave(object sender, EventArgs e)
		{
			if (textBoxLRN.Text == "")
			{
				textBoxLRN.Text = "LRN";
				textBoxLRN.ForeColor = Color.Red;
			}
			
		}

		private void TextboxFname_Enter(object sender, EventArgs e)
		{
			if (textBoxFname.Text == "First Name")
			{
				textBoxFname.Text = "";
				textBoxFname.ForeColor = Color.White;
			}
		}
		private void textBoxFname_Leave(object sender, EventArgs e)
		{
			if (textBoxFname.Text == "")
			{
				textBoxFname.Text = "First Name";
				textBoxFname.ForeColor = Color.Red;
			}
		}

		private void textBoxMname_Enter(object sender, EventArgs e)
		{
			if (textBoxMname.Text == "Middle Initial")
			{
				textBoxMname.Text = "";
				textBoxMname.ForeColor = Color.White;
			}
		}
		private void textBoxMname_Leave(object sender, EventArgs e)
		{
			if (textBoxMname.Text == "")
			{
				textBoxMname.Text = "Middle Initial";
				textBoxMname.ForeColor = Color.Red;
			}
		}

		private void textBoxLname_Enter(object sender, EventArgs e)
		{
			if (textBoxLname.Text == "Last Name")
			{
				textBoxLname.Text = "";
				textBoxLname.ForeColor = Color.White;
			}
		}
		private void textBoxLname_Leave(object sender, EventArgs e)
		{
			if (textBoxLname.Text == "")
			{
				textBoxLname.Text = "Last Name";
				textBoxLname.ForeColor = Color.Red;
			}
		}

		private void textBoxGuardian_Enter(object sender, EventArgs e)
		{
			if (textBoxGuardian.Text == "Guardian")
			{
				textBoxGuardian.Text = "";
				textBoxGuardian.ForeColor = Color.White;
			}
		}
		private void textBoxGuardian_Leave(object sender, EventArgs e)
		{
			if (textBoxGuardian.Text == "")
			{
				textBoxGuardian.Text = "Guardian";
				textBoxGuardian.ForeColor = Color.Red;
			}
		}

		private void textBoxContact_Enter(object sender, EventArgs e)
		{
			if (textBoxContact.Text == "Contact No.")
			{
				textBoxContact.Text = "";
				textBoxContact.ForeColor = Color.White;
			}
		}
		private void textBoxContact_Leave(object sender, EventArgs e)
		{
			if (textBoxContact.Text == "")
			{
				textBoxContact.Text = "Contact No.";
				textBoxContact.ForeColor = Color.Red;
			}
		}

		private void textBoxAddress_Enter(object sender, EventArgs e)
		{
			if (textBoxAddress.Text == "Address")
			{
				textBoxAddress.Text = "";
				textBoxAddress.ForeColor = Color.White;
			}
		}
		private void textBoxAddress_Leave(object sender, EventArgs e)
		{
			if (textBoxAddress.Text == "")
			{
				textBoxAddress.Text = "Address";
				textBoxAddress.ForeColor = Color.Red;
			}
		}

		//function to populate the datagridview
		public void fillGrid(MySqlCommand command)
		{
			if (dataGridView1.Rows.Count == 0)
			{
				//refresh the datagridview data
				dataGridView1.ReadOnly = true;
				DataGridViewImageColumn picCol = new DataGridViewImageColumn();
				dataGridView1.RowTemplate.Height = 80;
				dataGridView1.DataSource = student.getStudents(command);

				//column 11 is the image column index
				picCol = (DataGridViewImageColumn)dataGridView1.Columns[11];
				picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
				dataGridView1.AllowUserToAddRows = false;

				//show the total student depending on datagridview rows
				labelTotalStudents.Text = "Total Students: " + dataGridView1.Rows.Count;
			}
			else
			{
				//refresh the datagridview data
				dataGridView1.ReadOnly = true;
				DataGridViewImageColumn picCol = new DataGridViewImageColumn();
				dataGridView1.RowTemplate.Height = 80;
				dataGridView1.DataSource = student.getStudents(command);

				//column 11 is the image column index
				picCol = (DataGridViewImageColumn)dataGridView1.Columns[11];
				picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
				dataGridView1.AllowUserToAddRows = false;

				//show the total student depending on datagridview rows
				labelTotalStudents.Text = "Total Students: " + dataGridView1.Rows.Count;
			}
		}

		private void ManageELEM_Load(object sender, EventArgs e)
		{
			
			
			//populate the datagridview
			fillGrid(new MySqlCommand("SELECT `lrn`, `esc`, `fname`, `mname`, `lname`, `gender`, `grade`, `sy`, `guardian`, `contact`, `address`, `picture`, `inputdate`, `barcode` FROM `elementary`"));

			//add items in combobox school year
			comboBoxSY.Items.Add("2020-2021");
			comboBoxSY.Items.Add("2021-2022");
			comboBoxSY.Items.Add("2022-2023");
			comboBoxSY.Items.Add("2023-2024");
			comboBoxSY.Items.Add("2024-2025");
			comboBoxSY.Items.Add("2025-2026");
			comboBoxSY.Items.Add("2026-2027");
			comboBoxSY.Items.Add("2027-2028");
			comboBoxSY.Items.Add("2028-2029");
			comboBoxSY.Items.Add("2029-2030");

			//add items in combobox grade
			comboBoxGradee.Items.Add("Grade 1");
			comboBoxGradee.Items.Add("Grade 2");
			comboBoxGradee.Items.Add("Grade 3");
			comboBoxGradee.Items.Add("Grade 4");
			comboBoxGradee.Items.Add("Grade 5");
			comboBoxGradee.Items.Add("Grade 6");
		}

		private void buttonUpload_Click(object sender, EventArgs e)
		{
			//browse image from your computer
			OpenFileDialog opf = new OpenFileDialog();
			opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

			if (opf.ShowDialog() == DialogResult.OK)
			{
				pictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
			}
		}

		//function to verify textboxLRN
		bool verifLRN()
		{
			if (textBoxLRN.Text.Trim() == "" || textBoxLRN.Text == "LRN")
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		bool verif()
		{
			if ((textBoxLRN.Text.Trim() == "LRN") ||
				(textBoxFname.Text.Trim() == "First Name") ||
				(textBoxMname.Text.Trim() == "Middle Initial") ||
				(textBoxLname.Text.Trim() == "Last Name") ||

				(comboBoxGradee.Text == null) ||
				(comboBoxSY.Text == null) ||
				(textBoxGuardian.Text.Trim() == "Guardian") ||
				(textBoxAddress.Text.Trim() == "Address") ||
				(textBoxContact.Text.Trim() == "Contact No.") ||
				(pictureBoxStudentImage.Image == null) ||
				(pictureBoxBarcode.Image == null)
				)
			{
				return false;
			}

			else
			{
				return true;
			}
		}

		private void buttonAddStudent_Click(object sender, EventArgs e)
		{
			STUDENT student = new STUDENT();
			string lrn = textBoxLRN.Text;
			if (textBoxESC.Text == "ESC")
			{
				textBoxESC.Text = "";
			}
			string esc = textBoxESC.Text;
			string fname = textBoxFname.Text;
			string mname = textBoxMname.Text;
			string lname = textBoxLname.Text;
			string gender = "Male";
			if (radioButtonFemale.Checked)
			{
				gender = "Female";
			}
			string grade = comboBoxGradee.Text;
			string sy = comboBoxSY.Text;
			string guardian = textBoxGuardian.Text;
			string address = textBoxAddress.Text;
			string contact = textBoxContact.Text;

			MemoryStream pic = new MemoryStream();
			DateTime inputdate = DateTime.Now;
			MemoryStream bc = new MemoryStream();
			

			if (verifLRN())
			{
				MessageBox.Show("Enter LRN", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}

			else if (student.valElementary(lrn))
			{
				MessageBox.Show("Student LRN Already In Used", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			else if (verif())
			{
				pictureBoxStudentImage.Image.Save(pic, pictureBoxStudentImage.Image.RawFormat);
				pictureBoxBarcode.Image.Save(bc, pictureBoxBarcode.Image.RawFormat);

				if (student.insertElementary(lrn, esc, fname, mname, lname, gender, grade, sy, guardian, contact, address, pic, inputdate, bc))
				{
					MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
					fillGrid(new MySqlCommand("SELECT `lrn`, `esc`, `fname`, `mname`, `lname`, `gender`, `grade`, `sy`, `guardian`, `contact`, `address`, `picture`, `inputdate`, `barcode` FROM `elementary`"));
					ClearFields();
				}
				else
				{
					MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{
			try
			{
				//update the selected student
				string lrn = textBoxLRN.Text;
				if (textBoxESC.Text == "ESC")
				{
					textBoxESC.Text = "";
				}
				string esc = textBoxESC.Text;
				string fname = textBoxFname.Text;
				string mname = textBoxMname.Text;
				string lname = textBoxLname.Text;
				string gender = "Male";
				if (radioButtonFemale.Checked)
				{
					gender = "Female";
				}
				string grade = comboBoxGradee.Text;
				string sy = comboBoxSY.Text;
				string guardian = textBoxGuardian.Text;
				string contact = textBoxContact.Text;
				string address = textBoxAddress.Text;


				MemoryStream pic = new MemoryStream();

				if (verif())
				{
					pictureBoxStudentImage.Image.Save(pic, pictureBoxStudentImage.Image.RawFormat);

					if (student.updateELEM(lrn, esc, fname, mname, lname, gender, grade, sy, guardian, contact, address, pic))
					{
						MessageBox.Show("Student Information Updated", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
						fillGrid(new MySqlCommand("SELECT * FROM `elementary`"));
						ClearFields();
					}
					else
					{
						MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else
				{
					MessageBox.Show("Empty Fields", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			catch
			{
				MessageBox.Show("Please Enter a Valid LRN Number", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void buttonRemove_Click(object sender, EventArgs e)
		{
			try
			{
				//remove the selected student
				string lrn = textBoxLRN.Text;

				//show a confirmation before deleting the student
				if (MessageBox.Show("Are You Sure You Want To Delete This Student", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{

					if (student.deleteELEM(lrn))
					{
						MessageBox.Show("Student Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
						fillGrid(new MySqlCommand("SELECT * FROM `elementary`"));

						ClearFields();
					}
					else
					{
						MessageBox.Show("Student Not Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			catch
			{
				MessageBox.Show("Please Enter a Valid LRN Number", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void buttonReset_Click(object sender, EventArgs e)
		{
			ClearFields();
		}

		private void dataGridView1_Click(object sender, EventArgs e)
		{
			textBoxLRN.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			textBoxESC.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			textBoxFname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
			textBoxMname.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
			textBoxLname.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

			//gender
			if (dataGridView1.CurrentRow.Cells[5].Value.ToString() == "Female")
			{
				radioButtonFemale.Checked = true;
			}
			else
			{
				radioButtonMale.Checked = true;
			}

			comboBoxGradee.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
			comboBoxSY.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
			textBoxGuardian.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
			textBoxContact.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
			textBoxAddress.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
			
			//picture
			byte[] pic;
			pic = (byte[])dataGridView1.CurrentRow.Cells[11].Value;
			MemoryStream picture = new MemoryStream(pic);
			pictureBoxStudentImage.Image = Image.FromStream(picture);
			Show();
			byte[] bc;
			bc = (byte[])dataGridView1.CurrentRow.Cells[13].Value;
			MemoryStream barcodee = new MemoryStream(bc);
			pictureBoxBarcode.Image = Image.FromStream(barcodee);
			Show();

		}

		private void SearchBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			string query = "SELECT * FROM `elementary` WHERE CONCAT(`lrn`,`fname`,`mname`,`lname`,`address`) LIKE '%" + SearchBox.Text + "%'";
			MySqlCommand command = new MySqlCommand(query);
			fillGrid(command);
		}

		private void SearchBox_Enter(object sender, EventArgs e)
		{
			if (SearchBox.Text == "Search")
			{
				SearchBox.Text = "";
			}
		}
		

		//add to printelementary table
		private void buttonAddPrint_Click(object sender, EventArgs e)
		{
			string grade = comboBoxGradee.Text;
			string sy = comboBoxSY.Text;
			string guardian = textBoxGuardian.Text;
			string address = textBoxAddress.Text;
			string contact = textBoxContact.Text;
			MemoryStream pic = new MemoryStream();
			MemoryStream bc = new MemoryStream();
			if (textBoxESC.Text == "")
			{
				textBoxESC.Text = "-";
			}
			string esc = textBoxESC.Text;
			string fullN = textBoxFname.Text + " " + textBoxMname.Text + " " + textBoxLname.Text;
			string lrn = textBoxLRN.Text;
			if (student.valELEMPrint(lrn))
			{
				MessageBox.Show("Student is Already In PrintList", "Add To PrintList", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (verif())
			{
				pictureBoxStudentImage.Image.Save(pic, pictureBoxStudentImage.Image.RawFormat);
				pictureBoxBarcode.Image.Save(bc, pictureBoxBarcode.Image.RawFormat);

				if (student.insertPrintELEM(lrn, esc, fullN, grade, sy, guardian, contact, address, pic, bc))
				{
					MessageBox.Show("Student Added To PrintList", "Add To PrintList", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Error", "Add To PrintList", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Empty Fields", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void SearchBox_Leave(object sender, EventArgs e)
		{
			if (SearchBox.Text == "")
			{
				SearchBox.Text = "Search";
			}
		}

		private void awit()
		{

		}

		private void textBoxESC_Enter(object sender, EventArgs e)
		{
			if (textBoxESC.Text == "ESC")
			{
				textBoxESC.Text = "";
				textBoxESC.ForeColor = Color.White;
			}
		}

		private void textBoxESC_Leave(object sender, EventArgs e)
		{
			if (textBoxESC.Text == "")
			{
				textBoxESC.Text = "ESC";
				//textBoxLRN.ForeColor = Color.Red;
			}
		}
		SaveBarcode sb = new SaveBarcode();
		private void generateBtn_Click(object sender, EventArgs e)
		{
			Barcode barcode = new Barcode();
			Color fontcolor = Color.Black;
			Color backcolor = Color.White;
			Image img = barcode.Encode(TYPE.CODE39, textBoxLRN.Text, fontcolor, backcolor, (int)(pictureBoxBarcode.Width * 0.7), (int)(pictureBoxBarcode.Height * 0.8));
			//pictureBoxBarcode.Image = img;
			sb.pictureBox1.Image = img;
			sb.Show();
		}

		private void ClearFields()
		{
			textBoxLRN.Text = "LRN";
			textBoxESC.Text = "ESC";
			textBoxFname.Text = "First Name";
			textBoxMname.Text = "Middle Initial";
			textBoxLname.Text = "Last Name";
			radioButtonMale.Checked = true;
			comboBoxGradee.Text = "";
			comboBoxSY.Text = "";
			textBoxGuardian.Text = "Guardian";
			textBoxAddress.Text = "Address";
			textBoxContact.Text = "Contact No.";
			pictureBoxStudentImage.Image = pictureBoxSpam.Image;
			pictureBoxBarcode.Image = null;

			textBoxLRN.ForeColor = Color.White;
			textBoxESC.ForeColor = Color.White;
			textBoxFname.ForeColor = Color.White;
			textBoxMname.ForeColor = Color.White;
			textBoxLname.ForeColor = Color.White;
			textBoxGuardian.ForeColor = Color.White;
			textBoxAddress.ForeColor = Color.White;
			textBoxContact.ForeColor = Color.White;
		}

		private void panelHeader_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			//browse image from your computer
			OpenFileDialog opf = new OpenFileDialog();
			opf.Filter = "Select Image(*.jpg;*.png;*.gif;*jpeg)|*.jpg;*.png;*.gif;*.jpeg";

			if (opf.ShowDialog() == DialogResult.OK)
			{
				pictureBoxBarcode.Image = Image.FromFile(opf.FileName);
			}
		}
	}
}
