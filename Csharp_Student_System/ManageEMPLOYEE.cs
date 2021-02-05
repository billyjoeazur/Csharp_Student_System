using MySql.Data.MySqlClient;
using QRCoder;
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
	public partial class ManageEMPLOYEE : Form
	{
		public ManageEMPLOYEE()
		{
			InitializeComponent();
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

		private void textBoxDesignation_Enter(object sender, EventArgs e)
		{
			if (textBoxDesignation.Text == "Designation")
			{
				textBoxDesignation.Text = "";
				textBoxDesignation.ForeColor = Color.Black;
			}
		}

		private void textBoxDesignation_Leave(object sender, EventArgs e)
		{
			if (textBoxDesignation.Text == "")
			{
				textBoxDesignation.Text = "Designation";
				textBoxDesignation.ForeColor = Color.Red;
			}
		}

		private void textBoxContactPerson_Enter(object sender, EventArgs e)
		{
			if (textBoxContactPerson.Text == "Contact Person")
			{
				textBoxContactPerson.Text = "";
				textBoxContactPerson.ForeColor = Color.Black;
			}
		}

		private void textBoxContactPerson_Leave(object sender, EventArgs e)
		{
			if (textBoxContactPerson.Text == "")
			{
				textBoxContactPerson.Text = "Contact Person";
				textBoxContactPerson.ForeColor = Color.Red;
			}
		}

		private void textBoxContactNumber_Enter(object sender, EventArgs e)
		{
			if (textBoxContactNumber.Text == "Contact Number")
			{
				textBoxContactNumber.Text = "";
				textBoxContactNumber.ForeColor = Color.Black;
			}
		}

		private void textBoxContactNumber_Leave(object sender, EventArgs e)
		{
			if (textBoxContactNumber.Text == "")
			{
				textBoxContactNumber.Text = "Contact Number";
				textBoxContactNumber.ForeColor = Color.Red;
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

		private void textBoxTIN_Enter(object sender, EventArgs e)
		{
			if (textBoxTIN.Text == "TIN")
			{
				textBoxTIN.Text = "";
				textBoxTIN.ForeColor = Color.Black;
			}
		}

		private void textBoxTIN_Leave(object sender, EventArgs e)
		{
			if (textBoxTIN.Text == "")
			{
				textBoxTIN.Text = "TIN";
				textBoxTIN.ForeColor = Color.Red;
			}
		}

		private void textBoxSSS_Enter(object sender, EventArgs e)
		{
			if (textBoxSSS.Text == "SSS")
			{
				textBoxSSS.Text = "";
				textBoxSSS.ForeColor = Color.Black;
			}
		}

		private void textBoxSSS_Leave(object sender, EventArgs e)
		{
			if (textBoxSSS.Text == "")
			{
				textBoxSSS.Text = "SSS";
				textBoxSSS.ForeColor = Color.Red;
			}
		}

		private void textBoxPHIL_Enter(object sender, EventArgs e)
		{
			if (textBoxPHIL.Text == "PHIL")
			{
				textBoxPHIL.Text = "";
				textBoxPHIL.ForeColor = Color.Black;
			}
		}

		private void textBoxPHIL_Leave(object sender, EventArgs e)
		{
			if (textBoxPHIL.Text == "")
			{
				textBoxPHIL.Text = "PHIL";
				textBoxPHIL.ForeColor = Color.Red;
			}
		}

		private void SearchBox_Enter(object sender, EventArgs e)
		{
			if (SearchBox.Text == "Search")
			{
				SearchBox.Text = "";
				SearchBox.ForeColor = Color.Black;
			}
		}

		private void SearchBox_Leave(object sender, EventArgs e)
		{
			if (SearchBox.Text == "")
			{
				SearchBox.Text = "Search";
				//SearchBox.ForeColor = Color.Red;
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
			picCol = (DataGridViewImageColumn)dataGridView1.Columns[2];
			picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
			dataGridView1.AllowUserToAddRows = false;

			//show the total student depending on datagridview rows
			labelTotalStudents.Text = "Total Employee: " + dataGridView1.Rows.Count;
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
				(textBoxDesignation.Text.Trim() == "Designation") ||
				(textBoxContactPerson.Text.Trim() == "Contact Person") ||
				(textBoxContactNumber.Text.Trim() == "Contact Number") ||
				(textBoxAddress.Text.Trim() == "Address") ||
				(textBoxTIN.Text.Trim() == "TIN") ||
				(textBoxSSS.Text.Trim() == "SSS") ||
				(textBoxPHIL.Text.Trim() == "PHIL") ||
				(pictureBoxStudentImage.Image == null) ||
				(pictureBoxQRcode.Image == null))
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
			string idno = textBoxIDno.Text;
			string fname = textBoxFname.Text;
			string mname = textBoxMname.Text;
			string lname = textBoxLname.Text;
			string designation = textBoxDesignation.Text;
			string contactperson = textBoxContactPerson.Text;
			string contactnumber = textBoxContactNumber.Text;
			string address = textBoxAddress.Text;
			string tin = textBoxTIN.Text;
			string sss = textBoxSSS.Text;
			string phil = textBoxPHIL.Text;

			MemoryStream photo = new MemoryStream();
			DateTime bddate = bdate.Value;
			MemoryStream qr = new MemoryStream();

			if (verifIDno())
			{
				MessageBox.Show("Enter ID Number", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if (student.valEmployee(idno))
			{
				MessageBox.Show("Employee ID Already In Used", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (verif())
			{
				pictureBoxStudentImage.Image.Save(photo, pictureBoxStudentImage.Image.RawFormat);
				pictureBoxQRcode.Image.Save(qr, pictureBoxQRcode.Image.RawFormat);
				if (student.insertEmployee(idno, qr, photo, fname, mname, lname, designation, contactperson, contactnumber, address, bddate, tin, sss, phil))
				{
					MessageBox.Show("New Employee Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
					fillGrid(new MySqlCommand("SELECT * FROM `employee`"));
					ClearFields();
				}
				else
				{
					MessageBox.Show("Error", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Empty Fields", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void buttonReset_Click(object sender, EventArgs e)
		{
			ClearFields();
		}

		

		private void buttonEdit_Click(object sender, EventArgs e)
		{
			try
			{
				STUDENT student = new STUDENT();
				string idno = textBoxIDno.Text;
				string fname = textBoxFname.Text;
				string mname = textBoxMname.Text;
				string lname = textBoxLname.Text;
				string designation = textBoxDesignation.Text;
				string contactperson = textBoxContactPerson.Text;
				string contactnumber = textBoxContactNumber.Text;
				string address = textBoxAddress.Text;
				string tin = textBoxTIN.Text;
				string sss = textBoxSSS.Text;
				string phil = textBoxPHIL.Text;

				MemoryStream photo = new MemoryStream();
				DateTime bddate = bdate.Value;
				MemoryStream qr = new MemoryStream();

				if (verif())
				{
					pictureBoxStudentImage.Image.Save(photo, pictureBoxStudentImage.Image.RawFormat);
					pictureBoxQRcode.Image.Save(qr, pictureBoxQRcode.Image.RawFormat);
					if (student.updateEmployee(idno, qr, photo, fname, mname, lname, designation, contactperson, contactnumber, address, bddate, tin, sss, phil))
					{
						MessageBox.Show("Employee Information Updated", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
						fillGrid(new MySqlCommand("SELECT * FROM `employee`"));
						ClearFields();
					}
					else
					{
						MessageBox.Show("Error", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else
				{
					MessageBox.Show("Empty Fields", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			catch
			{
				MessageBox.Show("Please Enter a Valid Employee ID", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void buttonRemove_Click(object sender, EventArgs e)
		{
			try
			{
				string id = textBoxIDno.Text;
				//show a confirmation before deleting the student
				if (MessageBox.Show("Are You Sure You Want To Delete This Employee?", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					if (student.deleteEmployee(id))
					{
						MessageBox.Show("Employee Deleted", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
						fillGrid(new MySqlCommand("SELECT * FROM `employee`"));
						ClearFields();
					}
					else
					{
						MessageBox.Show("Employee Not Deleted", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			catch
			{
				MessageBox.Show("Please Enter a Valid Employee ID", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void SearchBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			string query = "SELECT * FROM `employee` WHERE CONCAT(`idnumber`,`firstname`,`middlename`,`lastname`,`address`) LIKE '%" + SearchBox.Text + "%'";
			MySqlCommand command = new MySqlCommand(query);
			fillGrid(command);
		}

		private void buttonAddPrint_Click(object sender, EventArgs e)
		{
			string id = textBoxIDno.Text;
			MemoryStream qr = new MemoryStream();
			MemoryStream photo = new MemoryStream();
			string fname = textBoxFname.Text;
			string mname = textBoxMname.Text;
			string lname = textBoxLname.Text;
			string designation = textBoxDesignation.Text;
			string contactperson = textBoxContactPerson.Text;
			string contactnumber = textBoxContactNumber.Text;
			string address = textBoxAddress.Text;
			DateTime bddate = bdate.Value;
			string tin = textBoxTIN.Text;
			string sss = textBoxSSS.Text;
			string phil = textBoxPHIL.Text;
			string fullN = fname + " " + mname + " " + lname;

			if (student.valEMPLOYEEPrint(id))
			{
				MessageBox.Show("Employee is Already In Variables", "Add To Variables", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			else if (verif())
			{
				pictureBoxStudentImage.Image.Save(photo, pictureBoxStudentImage.Image.RawFormat);
				pictureBoxQRcode.Image.Save(qr, pictureBoxQRcode.Image.RawFormat);

				if (student.insertPrintEMPLOYEE(id, qr, photo, fullN, designation, contactperson, contactnumber, address, bddate, tin, sss, phil))
				{
					MessageBox.Show("Employee Added To PrintList", "Add To Variables", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ClearFields();
				}
				else
				{
					MessageBox.Show("Error", "Add To Variables", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Empty Fields", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		//upload qrcode
		private void button1_Click(object sender, EventArgs e)
		{
			//browse image from your computer
			OpenFileDialog opf = new OpenFileDialog();
			opf.Filter = "Select Image(*.jpg;*.png;*.gif;*jpeg)|*.jpg;*.png;*.gif;*.jpeg";

			if (opf.ShowDialog() == DialogResult.OK)
			{
				pictureBoxQRcode.Image = Image.FromFile(opf.FileName);
			}
		}

		//back button
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		SaveQRcode sb = new SaveQRcode();
		private void generateBtn_Click(object sender, EventArgs e)
		{
			QRCodeGenerator qr = new QRCodeGenerator();
			QRCodeData data = qr.CreateQrCode(textBoxIDno.Text, QRCodeGenerator.ECCLevel.Q);
			QRCode code = new QRCode(data);
			sb.pictureBox1.Image = code.GetGraphic(5);
			
			sb.Show();
		}

		private void ManageEMPLOYEE_Load(object sender, EventArgs e)
		{
			fillGrid(new MySqlCommand("SELECT * FROM `employee`"));
		}

		private void dataGridView1_Click(object sender, EventArgs e)
		{
			textBoxIDno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

			//QRcode
			Show();
			byte[] bc;
			bc = (byte[])dataGridView1.CurrentRow.Cells[1].Value;
			MemoryStream barcodee = new MemoryStream(bc);
			pictureBoxQRcode.Image = Image.FromStream(barcodee);
			Show();

			//Photo
			byte[] pic;
			pic = (byte[])dataGridView1.CurrentRow.Cells[2].Value;
			MemoryStream picture = new MemoryStream(pic);
			pictureBoxStudentImage.Image = Image.FromStream(picture);

			textBoxFname.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
			textBoxMname.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
			textBoxLname.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
			textBoxDesignation.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
			textBoxContactPerson.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
			textBoxContactNumber.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
			textBoxAddress.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
			bdate.Value = (DateTime)dataGridView1.CurrentRow.Cells[10].Value;
			textBoxTIN.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
			textBoxSSS.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
			textBoxPHIL.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
		}

		private void ClearFields()
		{
			textBoxIDno.Text = "ID No.";
			textBoxFname.Text = "First Name";
			textBoxMname.Text = "Middle Initial";
			textBoxLname.Text = "Last Name";
			textBoxDesignation.Text = "Designation";
			textBoxContactPerson.Text = "Contact Person";
			textBoxContactNumber.Text = "Contact Number";
			textBoxAddress.Text = "Address";
			textBoxTIN.Text = "TIN";
			textBoxSSS.Text = "SSS";
			textBoxPHIL.Text = "PHIL";
			pictureBoxStudentImage.Image = pictureBoxSpam.Image;
			pictureBoxQRcode.Image = null;

			textBoxIDno.ForeColor = Color.Black;
			textBoxFname.ForeColor = Color.Black;
			textBoxMname.ForeColor = Color.Black;
			textBoxLname.ForeColor = Color.Black;
			textBoxDesignation.ForeColor = Color.Black;
			textBoxContactPerson.ForeColor = Color.Black;
			textBoxContactNumber.ForeColor = Color.Black;
			textBoxAddress.ForeColor = Color.Black;
			textBoxTIN.ForeColor = Color.Black;
			textBoxSSS.ForeColor = Color.Black;
			textBoxPHIL.ForeColor = Color.Black;

		}
	}
}
