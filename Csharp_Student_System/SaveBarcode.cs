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
	public partial class SaveBarcode : Form
	{
		public SaveBarcode()
		{
			InitializeComponent();
		}
		Main ew = new Main();
		
		private void button1_Click(object sender, EventArgs e)
		{
			//ManageELEM helementary = new ManageELEM(ew.stat.Text);
			//Image img = pictureBox1.Image;
			//helementary.pictureBoxBarcode.Image = img;
			//this.Hide();
		}

		private void SaveBarcode_Load(object sender, EventArgs e)
		{
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			ManageELEM helementary = new ManageELEM(ew.stat.Text);
			//string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + helementary.textBoxLRN.Text + ".jpg";
			//using (var writer = new StreamWriter(path))
			{
				//download picture
				SaveFileDialog sve = new SaveFileDialog();
				//set the file name
				sve.FileName = helementary.textBoxLRN.Text;
				if (pictureBox1.Image == null)
				{
					MessageBox.Show("No Image In The PictureBox");
				}
				else if (sve.ShowDialog() == DialogResult.OK)
				{
					pictureBox1.Image.Save(sve.FileName + (".jpg"));
				}
			}
			this.Hide();
			
		}
	}
}
