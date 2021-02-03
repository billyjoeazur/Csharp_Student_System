using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Student_System
{
	public partial class PrintEMPLOYEE : Form
	{
		public PrintEMPLOYEE()
		{
			InitializeComponent();
		}
		STUDENT student = new STUDENT();
		MY_DB db = new MY_DB();

		private void buttonAddStudent_Click(object sender, EventArgs e)
		{
			//the file name = students_list.text
			//location = desktop
			string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Employee List.txt";

			using (var writer = new StreamWriter(path))
			{
				//check if file exist
				if (!File.Exists(path))
				{
					File.Create(path);
				}

				writer.Write("idnumber" + "\t" +
							 "qrcode" + "\t" +
							 "photo" + "\t" +
							 "fullname" + "\t" +
							 "designation" + "\t" +
							 "contactperson" + "\t" +
							 "contactnumber" + "\t" +
							 "address" + "\t" +
							 "birthdate" + "\t" +
							 "tin" + "\t" +
							 "sss" + "\t" +
							 "phil");
				writer.WriteLine("");
				//rows
				for (int i = 0; i < dataGridView1.Rows.Count; i++)
				{
					//columns
					for (int j = 0; j < dataGridView1.Columns.Count; j++)
					{
						if (j == 1)//column qrcode
						{
							//save picture's name in text file
							SaveFileDialog svf = new SaveFileDialog();
							svf.FileName = dataGridView1.Rows[i].Cells[0].Value.ToString();
							writer.Write(svf.FileName + ("." + ImageFormat.Png + "\t"));

							//upload picture
							byte[] qr;
							qr = (byte[])dataGridView1.Rows[i].Cells[1].Value;
							MemoryStream qrcode = new MemoryStream(qr);
							pictureBoxBarcode.Image = Image.FromStream(qrcode);
							Show();

							//download picture
							SaveFileDialog sve = new SaveFileDialog();
							//set the file name
							sve.FileName = dataGridView1.Rows[i].Cells[0].Value.ToString();
							if (pictureBoxBarcode.Image == null)
							{
								MessageBox.Show("No Image In The PictureBox");
							}
							else if (sve.ShowDialog() == DialogResult.OK)
							{
								pictureBoxBarcode.Image.Save(sve.FileName + ("." + ImageFormat.Png));
							}
						}

						else if(j == 2)//column photo
						{
							//save picture's name in text file
							SaveFileDialog svf = new SaveFileDialog();
							svf.FileName = dataGridView1.Rows[i].Cells[3].Value.ToString();
							writer.Write(svf.FileName + ("." + ImageFormat.Jpeg + "\t"));

							//upload picture
							byte[] pic;
							pic = (byte[])dataGridView1.Rows[i].Cells[2].Value;
							MemoryStream picture = new MemoryStream(pic);
							pictureBoxStudentImage.Image = Image.FromStream(picture);
							Show();

							//download picture
							SaveFileDialog sve = new SaveFileDialog();
							//set the file name
							sve.FileName = dataGridView1.Rows[i].Cells[3].Value.ToString();
							if (pictureBoxStudentImage.Image == null)
							{
								MessageBox.Show("No Image In The PictureBox");
							}
							else if (sve.ShowDialog() == DialogResult.OK)
							{
								pictureBoxStudentImage.Image.Save(sve.FileName + ("." + ImageFormat.Jpeg));
							}
						}

						else if (j == 8)
						{
							string day = dataGridView1.Rows[i].Cells[8].Value.ToString().Substring(0, 2);
							string month = dataGridView1.Rows[i].Cells[8].Value.ToString().Substring(3, 2);
							if(month == "01") { month = "January"; }else if(month == "02") { month = "February"; } else
								if(month == "03") { month = "March"; }else if(month == "04") { month = "April"; } else
								if(month == "05") { month = "May"; }else if(month == "06") { month = "June"; } else
								if(month == "07") { month = "July"; }else if(month == "08") { month = "August"; } else
								if(month == "09") { month = "Septerber"; }else if(month == "10") { month = "October"; } else
								if(month == "11") { month = "November"; }else if(month == "12") { month = "December"; }

							string year = dataGridView1.Rows[i].Cells[8].Value.ToString().Substring(6, 4);
							writer.Write(month + " " + day + ", " + year + "\t");
						}

						else
						{
							writer.Write(dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t");
						}
					}
					//create new line
					writer.WriteLine("");
				}
				writer.Close();
				MessageBox.Show("Data Exported");
			}
		}

		//funtion to populate datagridview
		public void fillGrid(MySqlCommand command)
		{
			if (dataGridView1.Rows.Count == 0)
			{
				//refresh the datagridview data
				dataGridView1.ReadOnly = true;
				DataGridViewImageColumn picCol = new DataGridViewImageColumn();
				dataGridView1.RowTemplate.Height = 80;
				dataGridView1.DataSource = student.getStudents(command);

				//column 8 is the image column index
				picCol = (DataGridViewImageColumn)dataGridView1.Columns[2];
				picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
				dataGridView1.AllowUserToAddRows = false;
			}
		}

		private void PrintEMPLOYEE_Load(object sender, EventArgs e)
		{
			dataGridView1.Visible = true;
			fillGrid(new MySqlCommand("SELECT * FROM `printemployee`"));
		}

		private void buttonClearList_Click(object sender, EventArgs e)
		{
			db.openConnection();
			MySqlCommand command = new MySqlCommand("DELETE FROM printemployee", db.getConnection);
			command.ExecuteNonQuery();

			if (MessageBox.Show("Are You Sure You Want To Clear The List", "Clear List", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				MySqlCommand commanded = new MySqlCommand("SELECT * FROM `printemployee`", db.getConnection);
				commanded.ExecuteNonQuery();
				dataGridView1.DataSource = student.getStudents(commanded);
			}
			db.closeConnection();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
