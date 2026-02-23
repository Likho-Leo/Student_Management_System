using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ONT2000_Semester2_Project
{
    public partial class frmAdminMenu : Form
    {
        public frmAdminMenu()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var frmHome = new frmHome();
            frmHome.Show();
            this.Close();
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            var frmManageUser = new frmManageUser();
            frmManageUser.Show();
            this.Close();
        }

        private void btnManageModules_Click(object sender, EventArgs e)
        {
            var frmManageModType = new frmManageModType();
            frmManageModType.Show();
            this.Close();
        }

        private void btnAssignToLecturers_Click(object sender, EventArgs e)
        {
            var frmAssignToLecturers = new frmAssignToLecturers();
            frmAssignToLecturers.Show();
            this.Close();
        }

        private void btnAssignToStudents_Click(object sender, EventArgs e)
        {
            var frmAssignToStud = new frmAssignToStud();
            frmAssignToStud.Show();
            this.Close();
        }

        private void frmAdminMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
