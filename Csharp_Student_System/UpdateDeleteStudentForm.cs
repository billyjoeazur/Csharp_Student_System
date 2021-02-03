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
    public partial class UpdateDeleteStudentForm : Form
    {
        public UpdateDeleteStudentForm()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();

        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            //browse image from your computer
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }

        //function to verify data
        bool verif()
        {
            if (//(textBoxIDno.Text.Trim() == "") ||
                (textBoxFname.Text.Trim() == "") ||
                (textBoxMname.Text.Trim() == "") ||
                (textBoxLname.Text.Trim() == "") ||
                (comboBoxCourse.Text.Trim() == "") ||
                (comboBoxYear.Text.Trim() == "") ||
                (comboBoxSY.Text.Trim() == "") ||
                (textBoxGuardian.Text.Trim() == "") ||
                (textBoxAddress.Text.Trim() == "") ||
                (textBoxContact.Text.Trim() == "") ||
                (pictureBoxStudentImage.Image == null))
            {
                return false;

            }
            else
            {
                return true;
            }
        }


        private void buttonEditStudent_Click(object sender, EventArgs e)
        {
            try
            {
                //update the selected student
                //add new student

                //int idno = Convert.ToInt32(textBoxIDno.Text);
                //STUDENT student = new STUDENT();
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
                string year = comboBoxYear.Text;
                string sy = comboBoxSY.Text;
                string guardian = textBoxGuardian.Text;
                string address = textBoxAddress.Text;
                string contact = textBoxContact.Text;
                

                MemoryStream pic = new MemoryStream();

                if (verif())
                {
                    pictureBoxStudentImage.Image.Save(pic, pictureBoxStudentImage.Image.RawFormat);

                    if (student.updateStudent(id, fname, mname, lname, gender, course, year, sy, guardian, address, contact, pic))
                    {
                        MessageBox.Show("Student Information Updated", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                //remove the selected student
                string id = textBoxIDno.Text;

                //show a confirmation before deleting the student
                if (MessageBox.Show("Are You Sure You Want To Delete This Student", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (student.deleteStudent(id))
                    {
                        MessageBox.Show("Student Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //clear fields
                        textBoxIDno.Text = "";
                        textBoxFname.Text = "";
                        textBoxMname.Text = "";
                        textBoxLname.Text = "";

                        comboBoxCourse.Text = "";
                        comboBoxYear.Text = "";
                        comboBoxSY.Text = "";
                        textBoxGuardian.Text = "";
                        textBoxAddress.Text = "";
                        textBoxContact.Text = "";
                        pictureBoxStudentImage.Image = null;
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

        
        private void buttonFind_Click(object sender, EventArgs e)
        {
            try
            {
                //search student by id
                string idno = textBoxIDno.Text;

                MySqlCommand command = new MySqlCommand("SELECT `idno`, `fname`, `mname`, `lname`, `gender`, `course`, `year`, `sy`, `guardian`, `address`, `contact`, `picture` FROM `college` WHERE `idno`=" + idno);
                DataTable table = student.getStudents(command);

                if (table.Rows.Count > 0)
                {
                    textBoxFname.Text = table.Rows[0]["fname"].ToString();
                    textBoxMname.Text = table.Rows[0]["mname"].ToString();
                    textBoxLname.Text = table.Rows[0]["lname"].ToString();

                    comboBoxCourse.Text = table.Rows[0]["course"].ToString();
                    comboBoxYear.Text = table.Rows[0]["year"].ToString();
                    comboBoxSY.Text = table.Rows[0]["sy"].ToString();
                    textBoxGuardian.Text = table.Rows[0]["guardian"].ToString();
                    textBoxAddress.Text = table.Rows[0]["address"].ToString();
                    textBoxContact.Text = table.Rows[0]["contact"].ToString();

                    //gender
                    if (table.Rows[0]["contact"].ToString() == "Female")
                    {
                        radioButtonFemale.Checked = true;
                    }
                    else
                    {
                        radioButtonMale.Checked = true;
                    }

                    //picture
                    byte[] pic = (byte[])table.Rows[0]["picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    pictureBoxStudentImage.Image = Image.FromStream(picture);
                }
            }catch
            {
                MessageBox.Show("Enter a Valid Student ID", "Invalid ID",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void buttonUploadImage_Click_1(object sender, EventArgs e)
        {
            //browse image from your computer
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void UpdateDeleteStudentForm_Load(object sender, EventArgs e)
        {
            //add items in combobox course
            comboBoxCourse.Items.Add("B.E.ED");
            comboBoxCourse.Items.Add("B.SEC.ED");
            comboBoxCourse.Items.Add("J.S.C");


            //add items in combobox year level
            comboBoxYear.Items.Add("I");
            comboBoxYear.Items.Add("II");
            comboBoxYear.Items.Add("III");
            comboBoxYear.Items.Add("IV");


            //add items in combobox school year
            comboBoxSY.Items.Add("2020-2021");
            comboBoxSY.Items.Add("2021-2022");
            comboBoxSY.Items.Add("2022-2023");
            comboBoxSY.Items.Add("2023-2024");
            comboBoxSY.Items.Add("2024-2025");
        }
    }
}
