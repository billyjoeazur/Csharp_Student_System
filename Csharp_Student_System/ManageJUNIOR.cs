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
	public partial class ManageJUNIOR : Form
	{
		public ManageJUNIOR(string user)
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
		STUDENT student = new STUDENT();

		private void textBoxLRN_Enter(object sender, EventArgs e)
		{
			if (textBoxLRN.Text == "LRN")
			{
				textBoxLRN.Text = "";
				textBoxLRN.ForeColor = Color.Black;
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

		private void textBoxESC_Enter(object sender, EventArgs e)
		{
			if (textBoxESC.Text == "ESC")
			{
				textBoxESC.Text = "";
				textBoxESC.ForeColor = Color.Black;
			}
		}

		private void textBoxESC_Leave(object sender, EventArgs e)
		{
			if (textBoxESC.Text == "")
			{
				textBoxESC.Text = "ESC";
				//textBoxESC.ForeColor = Color.Red;
			}
		}

		private void textBoxFname_Enter(object sender, EventArgs e)
		{
			if (textBoxFname.Text == "First Name")
			{
				textBoxFname.Text = "";
				textBoxFname.ForeColor = Color.Black;
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
				textBoxMname.ForeColor = Color.Black;
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
				textBoxLname.ForeColor = Color.Black;
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
				textBoxGuardian.ForeColor = Color.Black;
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
				textBoxContact.ForeColor = Color.Black;
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
				textBoxAddress.ForeColor = Color.Black;
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
				picCol = (DataGridViewImageColumn)dataGridView1.Columns[12];
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
				picCol = (DataGridViewImageColumn)dataGridView1.Columns[12];
				picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
				dataGridView1.AllowUserToAddRows = false;

				//show the total student depending on datagridview rows
				labelTotalStudents.Text = "Total Students: " + dataGridView1.Rows.Count;
			}
		}

		private void ManageJUNIOR_Load(object sender, EventArgs e)
		{
			//populate the datagridview
			fillGrid(new MySqlCommand("SELECT * FROM `juniorhigh`"));

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
			comboBoxGrade.Items.Add("Grade 7");
			comboBoxGrade.Items.Add("Grade 8");
			comboBoxGrade.Items.Add("Grade 9");
			comboBoxGrade.Items.Add("Grade 10");
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
				(textBoxLname.Text.Trim() == "Last") ||

				(comboBoxGrade.Text == null) ||
				(comboBoxSY.Text == null) ||
				(textBoxGuardian.Text.Trim() == "Guardian") ||
				(textBoxAddress.Text.Trim() == "Address") ||
				(textBoxContact.Text.Trim() == "Contact No.") ||
				(pictureBoxStudentImage.Image == null) ||
				(pictureBoxBarcode.Image == null))
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
			if(textBoxESC.Text == "ESC")
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
			string grade = comboBoxGrade.Text;
			string group = comboBoxGroup.Text;
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

			else if (student.valJuniorHigh(lrn))
			{
				MessageBox.Show("Student ID Already In Used", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			else if (verif())
			{
				pictureBoxStudentImage.Image.Save(pic, pictureBoxStudentImage.Image.RawFormat);
				pictureBoxBarcode.Image.Save(bc, pictureBoxBarcode.Image.RawFormat);

				if (student.insertJuniorHigh(lrn, esc, fname, mname, lname, gender, grade, group, sy, guardian, contact, address, pic, inputdate, bc))
				{
					MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
					fillGrid(new MySqlCommand("SELECT * FROM `juniorhigh`"));
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

		//update the selected student
		private void buttonEdit_Click(object sender, EventArgs e)
		{
			try
			{
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
				string grade = comboBoxGrade.Text;
				string group = comboBoxGroup.Text;
				string sy = comboBoxSY.Text;
				string guardian = textBoxGuardian.Text;
				string contact = textBoxContact.Text;
				string address = textBoxAddress.Text;

				MemoryStream pic = new MemoryStream();

				if (verif())
				{
					pictureBoxStudentImage.Image.Save(pic, pictureBoxStudentImage.Image.RawFormat);

					if (student.updateJHS(lrn, esc, fname, mname, lname, gender, grade, group, sy, guardian, contact, address, pic))
					{
						MessageBox.Show("Student Information Updated", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
						fillGrid(new MySqlCommand("SELECT * FROM `juniorhigh`"));
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

					if (student.deleteJHS(lrn))
					{
						MessageBox.Show("Student Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
						fillGrid(new MySqlCommand("SELECT * FROM `juniorhigh`"));
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

		//clear fields
		private void buttonReset_Click(object sender, EventArgs e)
		{
			ClearFields();
		}

		//click datagridview to show value in textboxes
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
			comboBoxGrade.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
			comboBoxGroup.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
			comboBoxSY.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
			textBoxGuardian.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
			textBoxContact.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
			textBoxAddress.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
			//picture
			byte[] pic;
			pic = (byte[])dataGridView1.CurrentRow.Cells[12].Value;
			MemoryStream picture = new MemoryStream(pic);
			pictureBoxStudentImage.Image = Image.FromStream(picture);
			Show();
			byte[] bc;
			bc = (byte[])dataGridView1.CurrentRow.Cells[14].Value;
			MemoryStream barcodee = new MemoryStream(bc);
			pictureBoxBarcode.Image = Image.FromStream(barcodee);
			Show();
		}

		private void SearchBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			string query = "SELECT * FROM `juniorhigh` WHERE CONCAT(`lrn`,`fname`,`mname`,`lname`,`address`) LIKE '%" + SearchBox.Text + "%'";
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

		private void SearchBox_Leave(object sender, EventArgs e)
		{
			if (SearchBox.Text == "")
			{
				SearchBox.Text = "Search";
			}
		}

		private void buttonAddPrint_Click(object sender, EventArgs e)
		{
			string sy = comboBoxSY.Text;
			string guardian = textBoxGuardian.Text;
			string address = textBoxAddress.Text;
			string contact = textBoxContact.Text;
			MemoryStream pic = new MemoryStream();
			MemoryStream bc = new MemoryStream();
			string lrn = textBoxLRN.Text;
			if (textBoxESC.Text == "")
			{
				textBoxESC.Text = "-";
			}
			string esc = textBoxESC.Text;
			string fullN = textBoxFname.Text + " " + textBoxMname.Text + " " + textBoxLname.Text;
			string gradegroup = comboBoxGrade.Text + " " + comboBoxGroup.Text;

			if (student.valJHSPrint(lrn))
			{
				MessageBox.Show("Student is Already In PrintList", "Add To PrintList", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if(verif())
			{
				pictureBoxStudentImage.Image.Save(pic, pictureBoxStudentImage.Image.RawFormat);
				pictureBoxBarcode.Image.Save(bc, pictureBoxBarcode.Image.RawFormat);

				if (student.insertPrintJHS(lrn, esc, fullN, gradegroup, sy, guardian, contact, address, pic, bc))
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

		private void comboBoxGrade_Leave(object sender, EventArgs e)
		{
			//add items in combobox group
			if (comboBoxGrade.Text == "Grade 7")
			{
				comboBoxGroup.Items.Clear();
				comboBoxGroup.Items.Add("Aguinaldo");
				comboBoxGroup.Items.Add("Bonifacio");
			}
			else if (comboBoxGrade.Text == "Grade 8")
			{
				comboBoxGroup.Items.Clear();
				comboBoxGroup.Items.Add("Osmena");
				comboBoxGroup.Items.Add("Roxas");
			}
			else if (comboBoxGrade.Text == "Grade 9")
			{
				comboBoxGroup.Items.Clear();
				comboBoxGroup.Items.Add("Magsaysay");
				comboBoxGroup.Items.Add("Garcia");
			}
			else if (comboBoxGrade.Text == "Grade 10")
			{
				comboBoxGroup.Items.Clear();
				comboBoxGroup.Items.Add("Marcos");
				comboBoxGroup.Items.Add("Aquino");
			}
		}

		//upload barcode
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

		SaveBarcode sb = new SaveBarcode();
		private void generateBtn_Click(object sender, EventArgs e)
		{
			Barcode barcode = new Barcode();
			Color fontcolor = Color.Black;
			Color backcolor = Color.Black;
			Image img = barcode.Encode(TYPE.CODE39, textBoxLRN.Text, fontcolor, backcolor, (int)(pictureBoxBarcode.Width * .7), (int)(pictureBoxBarcode.Height * .8));
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
			comboBoxGrade.Text = "";
			comboBoxGroup.Text = "";
			comboBoxSY.Text = "";
			textBoxGuardian.Text = "Guardian";
			textBoxAddress.Text = "Address";
			textBoxContact.Text = "Contact No.";
			pictureBoxStudentImage.Image = pictureBoxSpam.Image;
			pictureBoxBarcode.Image = null;

			textBoxLRN.ForeColor = Color.Black;
			textBoxESC.ForeColor = Color.Black;
			textBoxFname.ForeColor = Color.Black;
			textBoxMname.ForeColor = Color.Black;
			textBoxLname.ForeColor = Color.Black;
			textBoxGuardian.ForeColor = Color.Black;
			textBoxAddress.ForeColor = Color.Black;
			textBoxContact.ForeColor = Color.Black;
		}
	}
}
