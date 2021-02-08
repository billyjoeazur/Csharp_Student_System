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
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
			customizeDesign();

			
		}
		MY_DB db = new MY_DB();
		private void customizeDesign()
		{
			panelElementarySubmenu.Visible = false;
			panelJuniorSubmenu.Visible = false;
			panelSeniorSubmenu.Visible = false;
			panelCollegeSubmenu.Visible = false;
			panelMasteralSubmenu.Visible = false;
			panelEmployeeSubmenu.Visible = false;
		}
		private void hideSubmenu()
		{
			if (panelElementarySubmenu.Visible == true)
				panelElementarySubmenu.Visible = false;
			if (panelJuniorSubmenu.Visible == true)
				panelJuniorSubmenu.Visible = false;
			if (panelSeniorSubmenu.Visible == true)
				panelSeniorSubmenu.Visible = false;
			if (panelCollegeSubmenu.Visible == true)
				panelCollegeSubmenu.Visible = false;
			if (panelMasteralSubmenu.Visible == true)
				panelMasteralSubmenu.Visible = false;
			if (panelEmployeeSubmenu.Visible == true)
				panelEmployeeSubmenu.Visible = false;
		}
		private void showSubMenu(Panel subMenu)
		{
			if(subMenu.Visible == false)
			{
				hideSubmenu();
				subMenu.Visible = true;
			}
			else
			{
				subMenu.Visible = false;
			}
		}

		private void btnElementary_Click(object sender, EventArgs e)
		{
			showSubMenu(panelElementarySubmenu);
		}
		private void button2_Click(object sender, EventArgs e)
		{
			openChildForm(new ManageELEM(stat.Text));
			hideSubmenu();
		}
		private void button3_Click(object sender, EventArgs e)
		{
			openChildForm(new PrintELEM());
			hideSubmenu();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			showSubMenu(panelJuniorSubmenu);
		}
		private void button4_Click(object sender, EventArgs e)
		{
			openChildForm(new ManageJUNIOR(stat.Text));
			hideSubmenu();
		}
		private void button5_Click(object sender, EventArgs e)
		{
			openChildForm(new PrintJUNIOR());
			hideSubmenu();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			showSubMenu(panelSeniorSubmenu);
		}

		private void button8_Click(object sender, EventArgs e)
		{
			openChildForm(new ManageSENIOR(stat.Text));
			hideSubmenu();
		}
		private void button7_Click(object sender, EventArgs e)
		{
			openChildForm(new PrintSENIOR());
			hideSubmenu();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			showSubMenu(panelCollegeSubmenu);
		}
		private void button11_Click(object sender, EventArgs e)
		{
			openChildForm(new ManageCOLLEGE(stat.Text));
			hideSubmenu();
		}
		private void button10_Click(object sender, EventArgs e)
		{
			openChildForm(new PrintCOLLEGE());
			hideSubmenu();
		}

		private void btnMasteral_Click(object sender, EventArgs e)
		{
			showSubMenu(panelMasteralSubmenu);
		}
		private void button14_Click(object sender, EventArgs e)
		{
			openChildForm(new ManageMASTER(stat.Text));
			hideSubmenu();
		}
		private void button13_Click(object sender, EventArgs e)
		{
			openChildForm(new PrintMASTER());
			hideSubmenu();
		}

		private Form activeForm = null;
		public void openChildForm(Form childForm)
		{
			if (activeForm != null)
				activeForm.Close();
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			panelChildForm.Controls.Add(childForm);
			panelChildForm.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}

		private void button6_Click_1(object sender, EventArgs e)
		{
			openChildForm(new Dashboard());
		}

		private void buttonLogout_Click(object sender, EventArgs e)
		{
			this.Hide();
			this.hideSubmenu();
			Login mylogin = new Login();
			mylogin.Show();
		}


		MainCharts chart = new MainCharts();
		private void Main_Load(object sender, EventArgs e)
		{
			//total
			chart1.Titles.Add("Total Student");
			chart1.Series["S1"].IsValueShownAsLabel = true;
			chart1.Series["S1"].Points.AddXY("Elementary", chart.GetElementary());
			chart1.Series["S1"].Points.AddXY("Junior High", chart.GetJuniorHigh());
			chart1.Series["S1"].Points.AddXY("Senior High", chart.GetSeniorHigh());
			chart1.Series["S1"].Points.AddXY("College", chart.GetCollege());
			chart1.Series["S1"].Points.AddXY("Master", chart.GetMaster());
			//elementary
			chart2.Titles.Add("Elementary Student");
			chart2.Series["S2"].IsValueShownAsLabel = true;
			chart2.Series["S2"].Points.AddXY("Grade 1", chart.GetGrade1());
			chart2.Series["S2"].Points.AddXY("Grade 2", chart.GetGrade2());
			chart2.Series["S2"].Points.AddXY("Grade 3", chart.GetGrade3());
			chart2.Series["S2"].Points.AddXY("Grade 4", chart.GetGrade4());
			chart2.Series["S2"].Points.AddXY("Grade 5", chart.GetGrade5());
			chart2.Series["S2"].Points.AddXY("Grade 6", chart.GetGrade6());
			//junior high
			chart3.Titles.Add("Junior High Student");
			chart3.Series["S3"].IsValueShownAsLabel = true;
			chart3.Series["S3"].Points.AddXY("Grade 7", chart.GetGrade7());
			chart3.Series["S3"].Points.AddXY("Grade 8", chart.GetGrade8());
			chart3.Series["S3"].Points.AddXY("Grade 9", chart.GetGrade9());
			chart3.Series["S3"].Points.AddXY("Grade 10", chart.GetGrade10());
			//senior high
			chart4.Titles.Add("Senior High Student");
			chart4.Series["S4"].IsValueShownAsLabel = true;
			chart4.Series["S4"].Points.AddXY("Grade 11", chart.GetGrade11());
			chart4.Series["S4"].Points.AddXY("Grade 12", chart.GetGrade12());
			//college
			chart5.Titles.Add("College Student");
			chart5.Series["S5"].IsValueShownAsLabel = true;
			chart5.Series["S5"].Points.AddXY("First Year", chart.GetCollege1());
			chart5.Series["S5"].Points.AddXY("Second Year", chart.GetCollege2());
			chart5.Series["S5"].Points.AddXY("Third Year", chart.GetCollege3());
			chart5.Series["S5"].Points.AddXY("Fourth Year", chart.GetCollege4());
			//master
			chart6.Titles.Add("Master Student");
			chart6.Series["S6"].IsValueShownAsLabel = true;
			chart6.Series["S6"].Points.AddXY("Psychology", chart.GetPsychology());
			chart6.Series["S6"].Points.AddXY("Educational Management", chart.GetEducationalManagement());

		}

		private void btnEmployee_Click(object sender, EventArgs e)
		{
			showSubMenu(panelEmployeeSubmenu);
		}

		private void button9_Click_1(object sender, EventArgs e)
		{
			openChildForm(new ManageEMPLOYEE());
			hideSubmenu();
		}

		private void button6_Click_2(object sender, EventArgs e)
		{
			openChildForm(new PrintEMPLOYEE());
			hideSubmenu();
		}

		


	}
}
