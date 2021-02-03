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
		private void openChildForm(Form childForm)
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

		private void Main_Load(object sender, EventArgs e)
		{

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
