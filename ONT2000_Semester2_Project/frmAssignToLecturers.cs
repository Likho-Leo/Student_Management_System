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

namespace ONT2000_Semester2_Project
{
    public partial class frmAssignToLecturers : Form
    {
        BLL bll = new BLL();
        public frmAssignToLecturers()
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

        private void frmAssignToLecturers_Load(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtLectureModuleID.Enabled = false;
            txtRole.Enabled = false;
            txtRole.Text = "Lecturer.";

            cmbLecturerID.DataSource = bll.GetUserByRole(txtRole.Text);
            cmbLecturerID.ValueMember = "UserID";
            cmbLecturerID.DisplayMember = "Name";
            cmbLecturerID.Text = "Select Lecturer...";

            cmbModID.DataSource = bll.GetModule();
            cmbModID.ValueMember = "ModuleID";
            cmbModID.DisplayMember = "ModuleName";
            cmbModID.Text = "Select Module...";

            cmbStatus.Items.Add("Unavailble");
            cmbStatus.Items.Add("Available");
            cmbStatus.Items.Add("Pending");
            cmbStatus.Text = "Select status...";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            User user = new User();
            try
            {
                if (cmbLecturerID.Text != "Select Lecturer..." && cmbModID.Text != "Select Module...")
                {
                    user.LectID = cmbLecturerID.SelectedValue.ToString();
                    user.ModID4Lect = cmbModID.SelectedValue.ToString();
                    user.LectDate = dtpDate.Value.ToString();
                    user.LectStatus = cmbStatus.SelectedItem.ToString();

                    int x = bll.InsertLectModule(user);
                    if (x > 0)
                    {
                        MessageBox.Show(" Lecture module has been successfuly added!", "Module Assigned to Lecturer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtLectureModuleID.Clear();
                        errorProvider1.Clear();
                        cmbLecturerID.Text = "Select Lecturer...";
                        cmbModID.Text = "Select Module...";
                        cmbStatus.Text = "Select status...";
                    }
                }
                else
                {
                    MessageBox.Show("ERROR!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider1.SetError(cmbLecturerID, "Please select lecturer.");
                    errorProvider1.SetError(cmbModID, "Please select module.");
                }
            }
            catch
            {
                MessageBox.Show("ERROR!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(cmbLecturerID, "Please select lecturer.");
                errorProvider1.SetError(cmbModID, "Please select module.");
                errorProvider1.SetError(cmbStatus, "Please select status");
            }
           
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvLectMods.DataSource = bll.GetLectureModule();

            errorProvider1.Clear();
            txtLectureModuleID.Clear();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            cmbLecturerID.Enabled = true;
            cmbLecturerID.Text = "Select Lecturer...";
            cmbModID.Text = "Select Module...";
            cmbStatus.Text = "Select status...";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.ModLectID = int.Parse(txtLectureModuleID.Text);
            int x = bll.DeleteLectMod(user);
            if (x > 0)
            {
                MessageBox.Show("Module has been successfully deleted!", "Lecturer Module Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtLectureModuleID.Clear();
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                cmbLecturerID.Enabled = true;
                cmbLecturerID.Text = "Select Lecturer...";
                cmbModID.Text = "Select Module...";
                cmbStatus.Text = "Select status...";
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }

        private void dgvLectMods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLectMods.SelectedRows.Count > 0)
            {
                txtLectureModuleID.Text = dgvLectMods.SelectedRows[0].Cells["LecturerModuleID"].Value.ToString();
                cmbLecturerID.Text = dgvLectMods.SelectedRows[0].Cells["ModuleID"].Value.ToString();
                dtpDate.Text = dgvLectMods.SelectedRows[0].Cells["Date"].Value.ToString();
                cmbStatus.Text = dgvLectMods.SelectedRows[0].Cells["ModLecturerStatus"].Value.ToString();

                errorProvider1.Clear();
                cmbLecturerID.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            User user = new User();
            try
            {
                if (cmbModID.Text != "Select Module...")
                {

                    user.ModLectID = int.Parse(txtLectureModuleID.Text);
                    user.ModID4Lect = cmbModID.SelectedValue.ToString();
                    user.LectDate = dtpDate.Value.ToString();
                    user.LectStatus = cmbStatus.SelectedItem.ToString();

                    int x = bll.UpdateLectMod(user);
                    if (x > 0)
                    {
                        MessageBox.Show(" Lecture module has been successfuly updated!", "Module Assigned to Lecturer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtLectureModuleID.Clear();
                        errorProvider1.Clear();
                        cmbLecturerID.Enabled = true;
                        cmbLecturerID.Text = "Select Lecturer...";
                        cmbModID.Text = "Select Module...";
                        cmbStatus.Text = "Select status...";
                        btnDelete.Enabled = false;
                        btnUpdate .Enabled = false;
                    } 
                }
                else
                {
                    MessageBox.Show("ERROR!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider1.SetError(cmbModID, "Please select module.");
                }
            }
            catch
            {
                MessageBox.Show("ERROR!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(cmbModID, "Please select module.");
                errorProvider1.SetError(cmbStatus, "Please select status");
            }
        }
        private void cmbModID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }  
    }
}
