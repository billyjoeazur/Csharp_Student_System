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
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}
		MY_DB db = new MY_DB();
		Main mymain = new Main();
		

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}
		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();
			DataTable dt = new DataTable();
			MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn AND `password` = @pass", db.getConnection);

			MySqlCommand sda = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @un", db.getConnection);
			sda.Parameters.Add("@un", MySqlDbType.VarChar).Value = textBoxUsername.Text;
			command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textBoxUsername.Text;
			command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;

			adapter.SelectCommand = command;
			adapter.Fill(table);

			adapter.SelectCommand = sda;
			adapter.Fill(dt);

			if (table.Rows.Count > 0)
			{
				//this.DialogResult = DialogResult.OK;
				mymain.stat.Text = dt.Rows[0][3].ToString();
				mymain.user.Text = dt.Rows[0][1].ToString();
				if(dt.Rows[0][3].ToString() != "Admin")
				{
					mymain.buttonNewAccount.Hide();
				}
				mymain.Show();

				this.Hide();
				return;

			}
			else
			{
				MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void textBoxUsername_Enter(object sender, EventArgs e)
		{
			if (textBoxUsername.Text == "Username")
			{
				textBoxUsername.Text = "";
				textBoxUsername.ForeColor = Color.Black;
			}
		}

		private void textBoxUsername_Leave(object sender, EventArgs e)
		{
			if (textBoxUsername.Text == "")
			{
				textBoxUsername.Text = "Username";
				textBoxUsername.ForeColor = Color.Silver;
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
				textBoxPassword.PasswordChar = '*';
			}
		}

		private void textBoxPassword_Leave(object sender, EventArgs e)
		{
			if (textBoxPassword.Text == "")
			{
				textBoxPassword.Text = "Password";
				textBoxPassword.ForeColor = Color.Silver;
				textBoxPassword.PasswordChar = '\0'; //disable the passwordchar
			}
			else
			{
				textBoxPassword.PasswordChar = '*';
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Main m = new Main();
			m.Show();
			this.Hide();
		}

		private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
		{
			textBoxPassword.PasswordChar = '*';
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void Login_Load(object sender, EventArgs e)
		{
			
		}

		void EnterAccept(Button btn)
		{
			
		}

		private void button3_Click(object sender, EventArgs e)
		{
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();
			DataTable dt = new DataTable();
			MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn AND `password` = @pass", db.getConnection);

			MySqlCommand sda = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @un", db.getConnection);
			sda.Parameters.Add("@un", MySqlDbType.VarChar).Value = textBoxUsername.Text;
			command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textBoxUsername.Text;
			command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;

			adapter.SelectCommand = command;
			adapter.Fill(table);

			adapter.SelectCommand = sda;
			adapter.Fill(dt);

			if (table.Rows.Count > 0)
			{
				//this.DialogResult = DialogResult.OK;
				mymain.stat.Text = dt.Rows[0][3].ToString();
				mymain.user.Text = dt.Rows[0][1].ToString();
				if (dt.Rows[0][3].ToString() != "Admin")
				{
					mymain.buttonNewAccount.Hide();
					mymain.btnEmployee.Hide();
				}
				mymain.Show();

				this.Hide();
				return;

			}
			else
			{
				MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
