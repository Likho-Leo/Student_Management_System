using BusinessLogicLayer;
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
using System.Text.RegularExpressions;

namespace ONT2000_Semester2_Project
{
    public partial class frmAssignToStud : Form
    {
        BLL bll = new BLL();
        public frmAssignToStud()
        {
            InitializeComponent();
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
        private void btnAdd_Click(object sender, EventArgs e)
        {

            User user = new User();

            try
            {
                if(cmbLectModID.Text != "Select Lecturer Module ID..." && cmbLectModID.Text != "" && cmbUserID.Text != "" && cmbUserID.Text != "Select User...")
                {
                    user.LectModID = cmbLectModID.SelectedValue.ToString();
                    user.StudID = cmbUserID.SelectedValue.ToString();
                    user.StudDate = dtpStudDate.Value.ToString();
                    user.StudStatus = cmbStatus.SelectedItem.ToString();

                    int x = bll.InsertStudentModule(user);
                    if (x > 0)
                    {

                        MessageBox.Show(" Module Has Been Successfuly Assigned to Student!", "Module Assigned to Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        cmbUserID.Text = "Select User...";
                        cmbLectModID.Text = "Select Lecturer Module ID...";
                        cmbStatus.Text = "Select status...";
                        epError.Clear();

                    }
                }
                else
                {
                    MessageBox.Show("ERROR!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    epError.SetError(cmbLectModID, "Please select lecturer module ID");
                    epError.SetError(cmbUserID, "Please select student");
                }
            }
            catch
            {
                MessageBox.Show("ERROR!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                epError.SetError(cmbStatus, "Please select status");
            } 
        }

        private void frmAssignToStud_Load(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtStudModID.Enabled = false;
            txtRole.Enabled = false;
            txtRole.Text = "Student.";

            cmbUserID.DataSource = bll.GetUserByRole(txtRole.Text);
            cmbUserID.ValueMember = "UserID";
            cmbUserID.DisplayMember = "Name";
            cmbUserID.Text = "Select User...";

            cmbLectModID.DataSource = bll.GetLectureModule();
            cmbLectModID.ValueMember = "LecturerModuleID";
            cmbLectModID.DisplayMember = "LecturerModuleID";
            cmbLectModID.Text = "Select Lecturer Module ID...";

            cmbStatus.Items.Add("Unavailble");
            cmbStatus.Items.Add("Available");
            cmbStatus.Items.Add("Pending");
            cmbStatus.Text = "Select status...";
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            User user = new User();
            try
            {
                user.StudModID = int.Parse(txtStudModID.Text);
                user.StudDate = dtpStudDate.Value.ToString();
                user.StudStatus = cmbStatus.SelectedItem.ToString();

                int x = bll.UpdateStudMod(user);
                if (x > 0)
                {
                    MessageBox.Show(" Module has been successfully update!", "Student Module Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cmbUserID.Text = "Select User...";
                    cmbLectModID.Text = "Select Lecturer Module ID...";
                    cmbStatus.Text = "Select status...";
                    epError.Clear();
                }
            }
            catch
            {
                MessageBox.Show("ERROR!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                epError.SetError(cmbStatus, "Please select status");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.StudModID = int.Parse(txtStudModID.Text);
            int x = bll.DeleteStudMod(user);
            if (x > 0)
            {
                MessageBox.Show("Student module has been successfully deleted!", "Student Module Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtStudModID.Clear();
                cmbUserID.Text = "Select User...";
                cmbLectModID.Text = "Select Lecturer Module ID...";
                cmbStatus.Text = "Select status...";
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvViewStudMods.DataSource = bll.GetStudMod();

            txtStudModID.Clear();
            epError.Clear();
            cmbUserID.Text = "Select User...";
            cmbLectModID.Text = "Select Lecturer Module ID...";
            cmbStatus.Text = "Select status...";

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            cmbLectModID.Enabled = true;
            cmbUserID.Enabled = true;
        }

        private void dgvViewStudMods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvViewStudMods.SelectedRows.Count > 0)
            {
                txtStudModID.Text = dgvViewStudMods.SelectedRows[0].Cells["StudentModuleID"].Value.ToString();
                //cmbLectModID.Text = dgvViewStudMods.SelectedRows[0].Cells["LecturerModuleID"].Value.ToString();
                //cmbUserID.Text = dgvViewStudMods.SelectedRows[0].Cells["UserID"].Value.ToString();
                dtpStudDate.Text = dgvViewStudMods.SelectedRows[0].Cells["Date"].Value.ToString();
                cmbStatus.Text = dgvViewStudMods.SelectedRows[0].Cells["StudModStatus"].Value.ToString();

                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                cmbLectModID.Enabled = false;
                cmbUserID.Enabled = false;
            }
        }
    }
}
