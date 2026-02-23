using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using System.Text.RegularExpressions;

namespace ONT2000_Semester2_Project
{
    
    public partial class frmManageModules : Form
    {
        BLL bll = new BLL();
        public frmManageModules()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            var frmHome = new frmHome();
            frmHome.Show();
            this.Close();

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            var frmManageModType = new frmManageModType();
            frmManageModType.Show();
            this.Close();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvModuleRecords.DataSource = bll.GetModule();

            txtID.Clear();
            epError.Clear();
            txtModuleName.Clear();
            cmbDuration.Text = "Select module duration...";
            cmbModuleType.Text = "Select module type...";
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtModuleName.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            User user = new User();
            try
            {
                epError.Clear();
                bool i = false;
                if (string.IsNullOrEmpty(txtModuleName.Text) || (!Regex.IsMatch(txtModuleName.Text, @"[a-zA-Z]")))
                {
                    epError.SetError(txtModuleName, "Please enter module name");
                    i = true;
                }
                if(cmbDuration.Text == "")
                {
                    epError.SetError(cmbDuration, "Please select module duration");
                    i = true;
                }
                if (cmbModuleType.Text == "Select module type..." || cmbModuleType.Text == "")
                {
                    epError.SetError(cmbModuleType, "Please select module type");
                    i = true;
                }

                if (i != true && cmbModuleType.Text !=  "Select module type...")
                {
                    user.ModuleName = txtModuleName.Text;
                    user.ModuleDuration = cmbDuration.SelectedItem.ToString();
                    user.ModuleType = cmbModuleType.SelectedValue.ToString();
                    user.ModuleStatus = cmbStatus.SelectedItem.ToString();

                    int x = bll.InsertModule(user);

                    if (x > 0)
                    {
                        MessageBox.Show("Module has been successfully added!", "Module Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtID.Clear();
                        epError.Clear();
                        txtModuleName.Clear();
                        cmbDuration.Text = "Select module duration...";
                        cmbModuleType.Text = "Select module type...";
                    }
                }
            }
            catch
            {
                MessageBox.Show("ERROR!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            User user = new User();

            try
            {
                if (cmbModuleType.Text != "Select module type...")
                {
                    user.ModuleID = int.Parse(txtID.Text);
                    user.ModuleDuration = cmbDuration.SelectedItem.ToString();
                    user.ModuleType = cmbModuleType.SelectedValue.ToString();
                    user.ModuleStatus = cmbStatus.SelectedItem.ToString();

                    int x = bll.UpdateModule(user);
                    if (x > 0)
                    {
                        MessageBox.Show("Module type has been successfully updated!", "Module Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtID.Clear();
                        txtModuleName.Clear();
                        epError.Clear();
                        cmbDuration.Text = "Select module duration...";
                        cmbModuleType.Text = "Select module type...";

                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                        txtModuleName.Enabled = true;
                    }
                }
                else
                {
                    epError.SetError(cmbModuleType, "Please select module type");
                }


            }
            catch
            {
                MessageBox.Show("ERROR!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                epError.SetError(cmbModuleType, "Please select module type");
                epError.SetError(cmbDuration, "Please select module duration");
            }
        }

        private void frmManageModules_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            

            cmbModuleType.DataSource = bll.GetModuleType();

            cmbDuration.Text = "Select module duration...";
            cmbDuration.Items.Add("5 months");
            cmbDuration.Items.Add("11 months");

            cmbModuleType.ValueMember = "ModuleTypeID";
            cmbModuleType.DisplayMember = "ModuleTypeDescription";
            cmbModuleType.Text = "Select module type...";

            cmbStatus.Items.Add("Available");
            cmbStatus.Items.Add("Unavailable");
        }

        private void dgvModuleRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvModuleRecords.SelectedRows.Count > 0)
            {
                txtID.Text = dgvModuleRecords.SelectedRows[0].Cells["ModuleID"].Value.ToString();
                txtModuleName.Text = dgvModuleRecords.SelectedRows[0].Cells["ModuleName"].Value.ToString();
                cmbDuration.Text = dgvModuleRecords.SelectedRows[0].Cells["ModuleDuration"].Value.ToString();
                //cmbModuleType.Text = dgvModuleRecords.SelectedRows[0].Cells["ModuleTypeID"].Value.ToString();

                txtModuleName.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.ModuleID = int.Parse(txtID.Text);
            int x = bll.DeleteModule(user);
            if (x > 0)
            {
                MessageBox.Show("Module type has been successfully deleted!", "Module Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtID.Clear();
                txtModuleName.Clear();
                cmbDuration.Text = "Select module duration...";
                cmbModuleType.Text = "Select module type...";

                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                txtModuleName.Enabled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                epError.Clear();
                bool i = false;
                if (string.IsNullOrEmpty(txtSearchName.Text) || (!Regex.IsMatch(txtSearchName.Text, @"[a-zA-Z]")))
                {
                    epError.SetError(txtSearchName, "Please enter module name");
                    i = true;
                }
                if (i != true)
                {
                    dgvModuleRecords.DataSource = bll.GetModuleByName(txtSearchName.Text);
                   // dgvNoOfStud.DataSource = bll.GetNoOfStud();
                    epError.Clear();
                }
                
            }
            catch
            {
                MessageBox.Show("ERROR!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }
    }
}
