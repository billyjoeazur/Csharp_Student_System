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
	public partial class ManageMASTER : Form
	{
		public ManageMASTER(string user)
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

		private void textBoxIDno_Enter(object sender, EventArgs e)
		{
			if (textBoxIDno.Text == "ID No.")
			{
				textBoxIDno.Text = "";
				textBoxIDno.ForeColor = Color.Black;
			}
		}

		private void textBoxIDno_Leave(object sender, EventArgs e)
		{
			if (textBoxIDno.Text == "")
			{
				textBoxIDno.Text = "ID No.";
				textBoxIDno.ForeColor = Color.Red;
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
			//refresh the datagridview data
			dataGridView1.ReadOnly = true;
			DataGridViewImageColumn picCol = new DataGridViewImageColumn();
			dataGridView1.RowTemplate.Height = 80;
			dataGridView1.DataSource = student.getStudents(command);

			//column 11 is the image column index
			picCol = (DataGridViewImageColumn)dataGridView1.Columns[10];
			picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
			dataGridView1.AllowUserToAddRows = false;

			//show the total student depending on datagridview rows
			labelTotalStudents.Text = "Total Students: " + dataGridView1.Rows.Count;
		}

		private void ManageMASTER_Load(object sender, EventArgs e)
		{
			//populate the datagridview
			fillGrid(new MySqlCommand("SELECT * FROM `masteral`"));

			//add items in combobox course
			comboBoxCourse.Items.Add("Psychology ");
			comboBoxCourse.Items.Add("Educational Management");

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

		//function to verify textboxIDno
		bool verifIDno()
		{
			if (textBoxIDno.Text.Trim() == "" || textBoxIDno.Text == "ID No.")
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
			if ((textBoxIDno.Text.Trim() == "ID No.") ||
				(textBoxFname.Text.Trim() == "First Name") ||
				(textBoxMname.Text.Trim() == "Middle Initial") ||
				(textBoxLname.Text.Trim() == "Last Name") ||
				//(comboBoxCourse.Text.Trim() == "") ||
				//(comboBoxYear.Text.Trim() == "") ||
				//(comboBoxSY.Text.Trim() == "") ||
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

		private void buttonAddPrint_Click(object sender, EventArgs e)
		{
			string fname = textBoxFname.Text;
			string mname = textBoxMname.Text;
			string lname = textBoxLname.Text;
			string course = comboBoxCourse.Text;
			string sy = comboBoxSY.Text;
			string guardian = textBoxGuardian.Text;
			string address = textBoxAddress.Text;
			string contact = textBoxContact.Text;
			MemoryStream pic = new MemoryStream();
			MemoryStream bc = new MemoryStream();
			string id = textBoxIDno.Text;
			string mInitial = textBoxMname.Text;
			string fullN = textBoxFname.Text + " " + mInitial + " " + textBoxLname.Text;

			if (student.valMASTERPrint(id))
			{
				MessageBox.Show("Student is Already In PrintList", "Add To PrintList", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			else if(verif())
			{
				pictureBoxStudentImage.Image.Save(pic, pictureBoxStudentImage.Image.RawFormat);
				pictureBoxBarcode.Image.Save(bc, pictureBoxBarcode.Image.RawFormat);

				if (student.insertPrintMASTER(id, fullN, course, sy, guardian, contact, address, pic, bc))
				{
					MessageBox.Show("Student Added To PrintList", "Add To PrintList", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ClearFields();
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

		//update the selected student
		private void buttonEdit_Click(object sender, EventArgs e)
		{
			try
			{
				string id = textBoxIDno.Text;
				string fname = textBoxFname.Text;
				string mname = textBoxMname.Text;
				string lname = textBoxLname.Text;
				string gender = "Male";
				if (radioButtonFemale.Checked)
				{
					gender = "Female";
				}
				string course = comboBoxCourse.Text;
				string sy = comboBoxSY.Text;
				string guardian = textBoxGuardian.Text;
				string address = textBoxAddress.Text;
				string contact = textBoxContact.Text;

				MemoryStream pic = new MemoryStream();

				if (verif())
				{
					pictureBoxStudentImage.Image.Save(pic, pictureBoxStudentImage.Image.RawFormat);

					if (student.updateMasteral(id, fname, mname, lname, gender, course, sy, guardian, contact, address, pic))
					{
						MessageBox.Show("Student Information Updated", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
						fillGrid(new MySqlCommand("SELECT * FROM `masteral`"));
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
				MessageBox.Show("Please Enter a Valid Student ID", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//remove the selected student
		private void buttonRemove_Click(object sender, EventArgs e)
		{
			try
			{
				string id = textBoxIDno.Text;
				//show a confirmation before deleting the student
				if (MessageBox.Show("Are You Sure You Want To Delete This Student", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					if (student.deleteMasteral(id))
					{
						MessageBox.Show("Student Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
						fillGrid(new MySqlCommand("SELECT * FROM `masteral`"));
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
				MessageBox.Show("Please Enter a Valid Student ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//clear fields
		private void buttonReset_Click(object sender, EventArgs e)
		{
			ClearFields();
		}

		private void dataGridView1_Click(object sender, EventArgs e)
		{
			textBoxIDno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			textBoxFname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			textBoxMname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
			textBoxLname.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
			//gender
			if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Female")
			{
				radioButtonFemale.Checked = true;
			}
			else
			{
				radioButtonMale.Checked = true;
			}
			comboBoxCourse.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
			comboBoxSY.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
			textBoxGuardian.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
			textBoxContact.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
			textBoxAddress.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
			//picture
			byte[] pic;
			pic = (byte[])dataGridView1.CurrentRow.Cells[10].Value;
			MemoryStream picture = new MemoryStream(pic);
			pictureBoxStudentImage.Image = Image.FromStream(picture);
			Show();
			byte[] bc;
			bc = (byte[])dataGridView1.CurrentRow.Cells[12].Value;
			MemoryStream barcodee = new MemoryStream(bc);
			pictureBoxBarcode.Image = Image.FromStream(barcodee);
			Show();
		}

		private void SearchBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			string query = "SELECT * FROM `masteral` WHERE CONCAT(`idno`,`fname`,`mname`,`lname`,`address`) LIKE '%" + SearchBox.Text + "%'";
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

		private void buttonAddStudent_Click(object sender, EventArgs e)
		{
			STUDENT student = new STUDENT();
			string idno = textBoxIDno.Text;
			string fname = textBoxFname.Text;
			string mname = textBoxMname.Text;
			string lname = textBoxLname.Text;
			string gender = "Male";
			if (radioButtonFemale.Checked)
			{
				gender = "Female";
			}
			string course = comboBoxCourse.Text;
			string sy = comboBoxSY.Text;
			string guardian = textBoxGuardian.Text;
			string address = textBoxAddress.Text;
			string contact = textBoxContact.Text;

			MemoryStream pic = new MemoryStream();
			DateTime inputdate = DateTime.Now;
			MemoryStream bc = new MemoryStream();

			if (verifIDno())
			{
				MessageBox.Show("Enter ID Number", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if (student.valMasteral(idno))
			{
				MessageBox.Show("Student ID Already In Used", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (verif())
			{
				pictureBoxStudentImage.Image.Save(pic, pictureBoxStudentImage.Image.RawFormat);
				pictureBoxBarcode.Image.Save(bc, pictureBoxBarcode.Image.RawFormat);
				if (student.insertMasteral(idno, fname, mname, lname, gender, course, sy, guardian, contact, address, pic, inputdate, bc))
				{
					MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
					fillGrid(new MySqlCommand("SELECT * FROM `masteral`"));
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

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Hide();
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
			Image img = barcode.Encode(TYPE.CODE39, textBoxIDno.Text, fontcolor, backcolor, (int)(pictureBoxBarcode.Width * 0.8), (int)(pictureBoxBarcode.Height * 0.8));
			//pictureBoxBarcode.Image = img;
			sb.pictureBox1.Image = img;
			sb.Show();
		}

		private void ClearFields()
		{
			textBoxIDno.Text = "ID No.";
			textBoxFname.Text = "First Name";
			textBoxMname.Text = "Middle Initial";
			textBoxLname.Text = "Last Name";
			comboBoxCourse.Text = "";
			//comboBoxYear.Text = "";
			comboBoxSY.Text = "";
			textBoxGuardian.Text = "Guardian";
			textBoxAddress.Text = "Address";
			textBoxContact.Text = "Contact No.";
			pictureBoxStudentImage.Image = pictureBoxSpam.Image;
			pictureBoxBarcode.Image = null;

			

			textBoxIDno.ForeColor = Color.Black;
			textBoxFname.ForeColor = Color.Black;
			textBoxMname.ForeColor = Color.Black;
			textBoxLname.ForeColor = Color.Black;
			textBoxGuardian.ForeColor = Color.Black;
			textBoxAddress.ForeColor = Color.Black;
			textBoxContact.ForeColor = Color.Black;
		}
	}
}
