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

		private void Dashboard_Load(object sender, EventArgs e)
		{
			fillGrid(new MySqlCommand("SELECT * FROM `users`"));
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
	}
}
