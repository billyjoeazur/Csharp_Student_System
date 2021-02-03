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
	public partial class PrintSENIOR : Form
	{
		public PrintSENIOR()
		{
			InitializeComponent();
		}
		STUDENT student = new STUDENT();
		MY_DB db = new MY_DB();
		
		//export data.text and image from printseniorhigh table
		private void buttonAddStudent_Click(object sender, EventArgs e)
		{
			//the file name = students_list.text
			//location = desktop
			string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Seniorhigh List.txt";

			using (var writer = new StreamWriter(path))
			{
				//check if file exist
				if (!File.Exists(path))
				{
					File.Create(path);
				}

				writer.Write("lrn" + "\t" +
							 "esc" + "\t" +
							 "fullname" + "\t" +
							 "gradegroup" + "\t" +
							 "sy" + "\t" +
							 "guardian" + "\t" +
							 "contact" + "\t" +
							 "address" + "\t" +
							 "picture" + "\t" +
							 "barcode");
				writer.WriteLine("");
				//rows
				for (int i = 0; i < dataGridView1.Rows.Count; i++)
				{
					//columns
					for (int j = 0; j < dataGridView1.Columns.Count; j++)
					{
						//if (j == 0)//add '-' to lrn
						//{
						//	string lrn = dataGridView1.Rows[i].Cells[0].Value.ToString();
						//	var builder = new StringBuilder();
						//	int count = 0;
						//	foreach (var c in lrn)
						//	{
						//		builder.Append(c);
						//		//if ((++count % 2) == 0)
						//		if (++count == 2)
						//		{
						//			builder.Append('-');
						//		}
						//	}
						//	lrn = builder.ToString();
						//	writer.Write(lrn + "\t");
						//}

						if(j == 8)//column picture
						{
							//save picture's name in text file
							SaveFileDialog svf = new SaveFileDialog();
							svf.FileName = dataGridView1.Rows[i].Cells[2].Value.ToString();
							writer.Write(svf.FileName + ("." + ImageFormat.Jpeg.ToString() + "\t"));

							//upload picture
							byte[] pic;
							pic = (byte[])dataGridView1.Rows[i].Cells[8].Value;
							MemoryStream picture = new MemoryStream(pic);
							pictureBoxStudentImage.Image = Image.FromStream(picture);
							Show();

							//download picture
							SaveFileDialog sve = new SaveFileDialog();
							//set the file name
							sve.FileName = dataGridView1.Rows[i].Cells[2].Value.ToString();
							if (pictureBoxStudentImage.Image == null)
							{
								MessageBox.Show("No Image In The PictureBox");
							}
							else if (sve.ShowDialog() == DialogResult.OK)
							{
								pictureBoxStudentImage.Image.Save(sve.FileName + ("." + ImageFormat.Jpeg.ToString()));
							}
						}
						else if (j == 9)//column barcode
						{
							//save picture's name in text file
							SaveFileDialog svf = new SaveFileDialog();
							svf.FileName = dataGridView1.Rows[i].Cells[0].Value.ToString();
							writer.Write(svf.FileName + ("." + ImageFormat.Png.ToString()));

							//upload picture
							byte[] pic;
							pic = (byte[])dataGridView1.Rows[i].Cells[9].Value;
							MemoryStream picture = new MemoryStream(pic);
							pictureBoxBarcode.Image = Image.FromStream(picture);
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
								pictureBoxBarcode.Image.Save(sve.FileName + ("." + ImageFormat.Png.ToString()));
							}
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
				picCol = (DataGridViewImageColumn)dataGridView1.Columns[8];
				picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
				dataGridView1.AllowUserToAddRows = false;
			}
		}

		//populate the datagridview
		private void PrintSENIOR_Load(object sender, EventArgs e)
		{
			dataGridView1.Visible = true;
			fillGrid(new MySqlCommand("SELECT * FROM `printseniorhigh`"));
		}

		//clear all data in the printelementary table
		private void buttonClearList_Click(object sender, EventArgs e)
		{
			db.openConnection();
			MySqlCommand command = new MySqlCommand("DELETE FROM printseniorhigh", db.getConnection);
			command.ExecuteNonQuery();

			if (MessageBox.Show("Are You Sure You Want To Clear The List", "Clear List", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				MySqlCommand commanded = new MySqlCommand("SELECT * FROM `printseniorhigh`", db.getConnection);
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
