using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Student_System
{
	public partial class Dashboard : Form
	{
		public Dashboard()
		{
			InitializeComponent();
		}
		MY_DB db = new MY_DB();
		DashboardClass dashboard = new DashboardClass();
		STUDENT student = new STUDENT();

		private void textBoxUser_Enter(object sender, EventArgs e)
		{
			if (textBoxUser.Text == "Username")
			{
				textBoxUser.Text = "";
				textBoxUser.ForeColor = Color.Black;
			}
		}

		private void textBoxUser_Leave(object sender, EventArgs e)
		{
			if (textBoxUser.Text == "")
			{
				textBoxUser.Text = "Username";
				textBoxUser.ForeColor = Color.Red;
			}
		}

		private void textBoxPassword_Enter(object sender, EventArgs e)
		{
			if (textBoxPassword.Text == "Password")
			{
				textBoxPassword.Text = "";
				textBoxPassword.ForeColor = Color.Black;
			}
			else
			{
				textBoxPassword.isPassword = true;
			}
		}

		private void textBoxPassword_Leave(object sender, EventArgs e)
		{
			if (textBoxPassword.Text == "")
			{
				textBoxPassword.Text = "Password";
				textBoxPassword.ForeColor = Color.Red;
				textBoxPassword.isPassword = false; //disable the passwordchar
			}
			else
			{
				textBoxPassword.isPassword = true;
			}
		}

		private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
		{
			textBoxPassword.isPassword = true;
		}

		public void fillGrid(MySqlCommand command)
		{
			if (dataGridView1.Rows.Count == 0)
			{
				//refresh the datagridview data
				dataGridView1.ReadOnly = true;
				DataGridViewImageColumn picCol = new DataGridViewImageColumn();
				dataGridView1.RowTemplate.Height = 80;
				dataGridView1.DataSource = student.getStudents(command);
				////column 11 is the image column index
				//picCol = (DataGridViewImageColumn)dataGridView1.Columns[10];
				//picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
				//dataGridView1.AllowUserToAddRows = false;
			}
			else
			{
				//refresh the datagridview data
				dataGridView1.ReadOnly = true;
				DataGridViewImageColumn picCol = new DataGridViewImageColumn();
				dataGridView1.RowTemplate.Height = 80;
				dataGridView1.DataSource = student.getStudents(command);
				//column 11 is the image column index
				//picCol = (DataGridViewImageColumn)dataGridView1.Columns[10];
				//picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
				//dataGridView1.AllowUserToAddRows = false;
			}
		}

		private void LoadComboSection(string selectQuery)
		{
			try
			{
				db.openConnection();
				MySqlCommand command = new MySqlCommand(selectQuery, db.getConnection);
				MySqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					comboBoxSection.Items.Add(reader.GetString("val"));
				}
				db.closeConnection();
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void LoadComboSY()
		{
			try
			{
				string selectQuery = "SELECT * FROM `schoolyear`";
				db.openConnection();
				MySqlCommand command = new MySqlCommand(selectQuery, db.getConnection);
				MySqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{

					comboBoxSY.Items.Add(reader.GetString("val"));
				}
				db.closeConnection();
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void LoadComboStrand()
		{
			try
			{
				string selectQuery = "SELECT * FROM `seniorhighstrand`";
				db.openConnection();
				MySqlCommand command = new MySqlCommand(selectQuery, db.getConnection);
				MySqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{

					comboBoxStrand.Items.Add(reader.GetString("val"));
				}
				db.closeConnection();
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void Dashboard_Load(object sender, EventArgs e)
		{
			fillGrid(new MySqlCommand("SELECT * FROM `users`"));
			comboBoxGrade.Items.Add("Grade 7");
			comboBoxGrade.Items.Add("Grade 8");
			comboBoxGrade.Items.Add("Grade 9");
			comboBoxGrade.Items.Add("Grade 10");
			LoadComboSY();
			LoadComboStrand();
		}

		bool empt()
		{
			if ((textBoxUser.Text.Trim() == "Username") || (textBoxPassword.Text.Trim() == "Password"))
			{

				return false;
			}
			else
			{
				return true;
			}
		}

		//function to verify textboxLRN
		bool verifUsername()
		{
			if (textBoxUser.Text.Trim() == "Username")
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		bool userV()
		{
			if (textBoxUser.Text != "Username")
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public void userValidate()
		{
			string userlevel = "Admin";
			if (radioButtonUser.Checked)
			{
				userlevel = "User";
			}
			string username = textBoxUser.Text;
			string password = textBoxPassword.Text;

			int i = 0;
			while (i <= dataGridView1.Rows.Count)
			{
				if (empt() == false)
				{
					MessageBox.Show("Empty Fields", "Add Account", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					i = dataGridView1.Rows.Count + 1;
				}
				else if (dataGridView1.Rows[i].Cells[1].Value == null)
				{
					i = dataGridView1.Rows.Count + 1;
					if (empt() == true && i > dataGridView1.Rows.Count)
					{
						if (student.insertUser(username, password, userlevel))
						{
							MessageBox.Show("New Account Added", "Add Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
							i = dataGridView1.Rows.Count + 1;
							textBoxUser.Text = "Username";
							textBoxPassword.Text = "Password";
							textBoxPassword.isPassword = false;
						}
						else
						{
							MessageBox.Show("Error", "Add Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
							i = dataGridView1.Rows.Count + 1;
						}
					}
				}

				else if (dataGridView1.Rows[i].Cells[1].Value.ToString() == textBoxUser.Text)
				{
					MessageBox.Show("Account Already In Used", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
					i = dataGridView1.Rows.Count + 1;
				}
				else
				{
					i++;
				}
			}
		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			if (verifUsername())
			{
				MessageBox.Show("Enter Username", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}

			else if (verifUsername() == false)
			{
				userValidate();
			}
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		void ReloadCombo()
		{
			comboBoxSection.Items.Clear();
			comboBoxSection.Text = "";

			comboBoxSY.Items.Clear();
			comboBoxSY.Text = "";
			LoadComboSY();

			comboBoxStrand.Items.Clear();
			comboBoxStrand.Text = "";
			LoadComboStrand();

			if (comboBoxGrade.Text == "Grade 7")
			{
				LoadComboSection("SELECT * FROM `grade7group`");
			}
			else if (comboBoxGrade.Text == "Grade 8")
			{
				LoadComboSection("SELECT * FROM `grade8group`");
			}
			else if (comboBoxGrade.Text == "Grade 9")
			{
				LoadComboSection("SELECT * FROM `grade9group`");
			}
			else if (comboBoxGrade.Text == "Grade 10")
			{
				LoadComboSection("SELECT * FROM `grade10group`");
			}

		}

		private void btnGrade7Remove_Click(object sender, EventArgs e)
		{
			
			try
			{
				string value = comboBoxSection.Text;
				string grade = comboBoxGrade.Text;

				if (value == "")
				{
					MessageBox.Show("Select Section To Delete", "Delete Section", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

				//show a confirmation before deleting the student
				else if(MessageBox.Show("Are You Sure You Want To Delete This Section", "Delete Section", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					if(value != null)
					{
						dashboard.deleteGradegroup(value, grade);
						MessageBox.Show("Section Deleted", "Delete Section", MessageBoxButtons.OK, MessageBoxIcon.Information);
						ReloadCombo();

					}
					else
					{
						MessageBox.Show("Section Not Deleted", "Delete Section", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			catch
			{
				MessageBox.Show("Please Enter Existing Section", "Delete Section", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		

		private void btnGrade7Add_Click(object sender, EventArgs e)
		{
			string value = comboBoxSection.Text;
			string grade = comboBoxGrade.Text;
			if(value == "")
			{
				MessageBox.Show("Enter Section To Be Added", "Add Section", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if(value != null)
			{
				dashboard.insertGradegroup(value, grade);
				MessageBox.Show("New Section Added", "Add Section", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ReloadCombo();
			}
		}

		private void comboBoxGrade_Leave(object sender, EventArgs e)
		{
			ReloadCombo();
			
		}

		private void btnAddSY_Click(object sender, EventArgs e)
		{
			string value = comboBoxSY.Text;
			if (value == "")
			{
				MessageBox.Show("Enter School Year To Be Added", "Add School Year", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (value != null)
			{
				dashboard.AddSY(value);
				MessageBox.Show("New School Year Added", "Add School Year", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ReloadCombo();
			}
		}

		private void btnRemoveSY_Click(object sender, EventArgs e)
		{
			try
			{
				string value = comboBoxSY.Text;

				if (value == "")
				{
					MessageBox.Show("Select School Year To Delete", "Delete School Year", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

				//show a confirmation before deleting the student
				else if (MessageBox.Show("Are You Sure You Want To Delete This School Year", "Delete School Year", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					if (value != null)
					{
						dashboard.DeleteSY(value);
						MessageBox.Show("School Year Deleted", "Delete School Year", MessageBoxButtons.OK, MessageBoxIcon.Information);
						ReloadCombo();

					}
					else
					{
						MessageBox.Show("School Year Not Deleted", "Delete School Year", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			catch
			{
				MessageBox.Show("Please Enter Existing School Year", "Delete School Year", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnAddStrand_Click(object sender, EventArgs e)
		{
			string value = comboBoxStrand.Text;
			if (value == "")
			{
				MessageBox.Show("Enter Strand To Be Added", "Add Strand", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (value != null)
			{
				dashboard.AddStrand(value);
				MessageBox.Show("New Strand Added", "Add Strand", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ReloadCombo();
			}
		}

		private void btnRemoveStrand_Click(object sender, EventArgs e)
		{
			try
			{
				string value = comboBoxStrand.Text;

				if (value == "")
				{
					MessageBox.Show("Select Strand To Delete", "Delete Strand", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

				//show a confirmation before deleting the student
				else if (MessageBox.Show("Are You Sure You Want To Delete This Strand", "Delete Strand", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					if (value != null)
					{
						dashboard.DeleteStrand(value);
						MessageBox.Show("Strand Deleted", "Delete Strand", MessageBoxButtons.OK, MessageBoxIcon.Information);
						ReloadCombo();

					}
					else
					{
						MessageBox.Show("Strand Not Deleted", "Delete Strand", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			catch
			{
				MessageBox.Show("Please Enter Existing Strand", "Delete Strand", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
