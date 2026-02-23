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
    public partial class frmUserRoles : Form
    {
        BLL bll = new BLL();
        public frmUserRoles()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            var frmManageUser = new frmManageUser();
            frmManageUser.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            var frmHome = new frmHome();
            frmHome.Show();
            this.Close();
        }

        private void frmUserRoles_Load(object sender, EventArgs e)
        {
            cmbUserRole.Items.Add("Administrator.");
            cmbUserRole.Items.Add("Lecturer.");
            cmbUserRole.Items.Add("Student.");
            cmbUserRole.Text = "Select user role...";
        }

        private void cmbUserRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvUserRoles.DataSource = bll.GetUserByRole(cmbUserRole.SelectedItem.ToString());
        }
    }
}
