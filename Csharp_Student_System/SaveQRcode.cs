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
	public partial class SaveQRcode : Form
	{
		public SaveQRcode()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ManageEMPLOYEE helementary = new ManageEMPLOYEE();
			//string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + helementary.textBoxLRN.Text + ".jpg";
			//using (var writer = new StreamWriter(path))
			{
				//download picture
				SaveFileDialog sve = new SaveFileDialog();
				//set the file name
				sve.FileName = helementary.textBoxIDno.Text;
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
