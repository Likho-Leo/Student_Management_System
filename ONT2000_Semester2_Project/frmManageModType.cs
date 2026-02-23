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
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace ONT2000_Semester2_Project
{
    public partial class frmManageModType : Form
    {
        BLL bll = new BLL();
        public frmManageModType()
        {
            InitializeComponent();
        }

        private void grpManageRecords_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            User user = new User();
            try
            {
                epError.Clear();
                bool i = false;
                if (string.IsNullOrEmpty(txtModuleDescription.Text) || (!Regex.IsMatch(txtModuleDescription.Text, @"[a-zA-Z]")))
                {
                    epError.SetError(txtModuleDescription, "Please enter module description");
                    i = true;
                }
                if (i != true)
                {
                    user.ModuleTypeDescription = txtModuleDescription.Text;

                    int x = bll.InsertModuleType(user);
                    if (x > 0)
                    {
                        MessageBox.Show(" Module type has been successfuly added!", "Module Type Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtModuleTypeID.Clear();
                        txtModuleDescription.Clear();
                        epError.Clear();
                    }
                }
            }
            catch
            {
                MessageBox.Show(" ERROR!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            User user = new User();
            try
            {
                epError.Clear();
                bool i = false;
                if (string.IsNullOrEmpty(txtModuleDescription.Text) || (!Regex.IsMatch(txtModuleDescription.Text, @"[a-zA-Z]")))
                {
                    epError.SetError(txtModuleDescription, "Please enter module description");
                    i = true;
                }
                if (i != true)
                {
                    user.ModuleTypeID = int.Parse(txtModuleTypeID.Text);
                    user.ModuleTypeDescription = txtModuleDescription.Text;

                    int x = bll.UpdateModType(user);
                    if (x > 0)
                    {
                        MessageBox.Show(" Module type has been successfuly updated!", "Module Type updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                MessageBox.Show(" ERROR!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvModType.DataSource = bll.GetModuleType();

            txtModuleTypeID.Clear();
            txtModuleDescription.Clear();
            epError.Clear();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.ModuleTypeID = int.Parse(txtModuleTypeID.Text);
            int x = bll.DeleteModuleType(user);
            if(x>0)
            {
                MessageBox.Show("Module type has been successfully deleted!", "Module Type Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtModuleTypeID.Clear();
                txtModuleDescription.Clear();
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }

        }
        private void dgvModType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dgvModType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvModType.SelectedRows.Count > 0)
            {
                txtModuleTypeID.Text = dgvModType.SelectedRows[0].Cells["ModuleTypeID"].Value.ToString();
                txtModuleDescription.Text = dgvModType.SelectedRows[0].Cells["ModuleTypeDescription"].Value.ToString();

                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void frmManageModType_Load(object sender, EventArgs e)
        {
            txtModuleTypeID.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            var frmAdminMenu = new frmAdminMenu();
            frmAdminMenu.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            var frmHome = new frmHome();
            frmHome.Show();
            this.Close();
        }
        private void btnOpenManageMod_Click(object sender, EventArgs e)
        {
            var frmManageModules = new frmManageModules();
            frmManageModules.Show();
            this.Close();
        }

      
    }
}
