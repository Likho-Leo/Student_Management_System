using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using BusinessLogicLayer;

namespace ONT2000_Semester2_Project
{
    public partial class frmStudentReport : Form
    {
        BLL bll = new BLL();
        public frmStudentReport()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            var frmLectMenu = new frmLectMenu();
            frmLectMenu.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            var frmHome = new frmHome();
            frmHome.Show();
            this.Close();
        }

        private void frmStudentReport_Load(object sender, EventArgs e)
        {
            txtRole.Text = "Student.";
            txtRole.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text != "")
                {
                    dgvStudentReport.DataSource = bll.GetStudent(int.Parse(txtID.Text), txtRole.Text);
                }
                else
                {
                    MessageBox.Show("Please enter student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Student ID must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
