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
using MySql.Data.MySqlClient;

namespace Csharp_Student_System
{
    public partial class studentsListForm : Form
    {
        public studentsListForm()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();


        private void studentsListForm_Load(object sender, EventArgs e)
        {
            //populate the datagridview with the students data
            MySqlCommand command = new MySqlCommand("SELECT * FROM `college`");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);

            //column 11 is the image column index
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[11];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        //refresh button
        private void button1_Click(object sender, EventArgs e)
        {
            //refresh the datagridview data
            MySqlCommand command = new MySqlCommand("SELECT * FROM `college`");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);

            //column 11 is the image column index
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[11];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;


        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //display the selected student in a new form to edit or remove
            UpdateDeleteStudentForm updateDeleteStdF = new UpdateDeleteStudentForm();
            updateDeleteStdF.textBoxIDno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateDeleteStdF.textBoxFname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateDeleteStdF.textBoxMname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateDeleteStdF.textBoxLname.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            
            //gender
            if(dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Female")
            {
                updateDeleteStdF.radioButtonFemale.Checked = true;
            }

            updateDeleteStdF.comboBoxCourse.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            updateDeleteStdF.comboBoxYear.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            updateDeleteStdF.comboBoxSY.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            updateDeleteStdF.textBoxGuardian.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            updateDeleteStdF.textBoxAddress.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            updateDeleteStdF.textBoxContact.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();

            //picture
            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[11].Value;
            MemoryStream picture = new MemoryStream(pic);
            updateDeleteStdF.pictureBoxStudentImage.Image = Image.FromStream(picture);
            updateDeleteStdF.Show();

        }
    }
}
