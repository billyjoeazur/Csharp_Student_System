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
    public partial class StaticsForm : Form
    {
        public StaticsForm()
        {
            InitializeComponent();
        }

        //color variable
        Color panTotalColor;
        Color panMaleColor;
        Color panFemaleColor;
        

        private void StaticsForm_Load(object sender, EventArgs e)
        {
            panTotalColor = panelTotal.BackColor;
            panMaleColor = panelMale.BackColor;
            panFemaleColor = panelFemale.BackColor;
        }

        private void StaticsForm_MouseEnter(object sender, EventArgs e)
        {

        }
        private void StaticsForm_MouseLeave(object sender, EventArgs e)
        {

        }



        //panel total
        private void labelTotal_MouseEnter(object sender, EventArgs e)
        {
            panelTotal.BackColor = Color.White;
            labelTotal.ForeColor = panTotalColor;
        }

        private void labelTotal_MouseLeave(object sender, EventArgs e)
        {
            panelTotal.BackColor = panTotalColor;
            labelTotal.ForeColor = Color.White;
        }
        //panel Male
        private void labelMale_MouseEnter(object sender, EventArgs e)
        {
            panelMale.BackColor = Color.White;
            labelMale.ForeColor = panMaleColor;
        }

        private void labelMale_MouseLeave(object sender, EventArgs e)
        {
            panelMale.BackColor = panMaleColor;
            labelMale.ForeColor = Color.White;
        }

        //private void labelFemale_MouseEnter(object sender, EventArgs e)
        //{
        //    panelFemale.BackColor = Color.White;
        //    labelFemale.ForeColor = panFemaleColor;
        //}

        //private void labelFemale_MouseLeave(object sender, EventArgs e)
        //{
        //    panelFemale.BackColor = panFemaleColor;
        //    labelMale.ForeColor = Color.White;
        //}



        //panel Female
        private void labelFemale_MouseEnter_1(object sender, EventArgs e)
        {
            panelFemale.BackColor = Color.White;
            labelFemale.ForeColor = panFemaleColor;
        }

        private void labelFemale_MouseLeave_1(object sender, EventArgs e)
        {
            panelFemale.BackColor = panFemaleColor;
            labelMale.ForeColor = Color.White;
        }
    }
}
