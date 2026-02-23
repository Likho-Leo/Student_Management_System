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
using System.Xml.Linq;


namespace ONT2000_Semester2_Project
{
    public partial class frmStudentDetails : Form
    {
        BLL bll = new BLL();
        DataTable dt = new DataTable();
        public frmStudentDetails()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            var frmHome = new frmHome();
            frmHome.Show();
            this.Close();
        }

        private void frmStudentDetails_Load(object sender, EventArgs e)
        {
            grpAssessment.Enabled = false;
            
            cmbStatus.Items.Add("Completed");
            cmbStatus.Items.Add("Missed");
            cmbStatus.Items.Add("Rescheduled");
            cmbStatus.Text = "Select assessment status";

        }

        private void btnViewMods_Click(object sender, EventArgs e)
        {
            User user = new User();
            //user.UserLogInID = int.Parse(txtID.Text);
            //user.LogInPassword = txtPassword.Text;
            //dt = bll.StudentLogIn(int.Parse(txtID.Text), txtPassword.Text);


            try
            {
                dt = bll.StudentLogIn(int.Parse(txtID.Text),txtPassword.Text);

                if (dt.Rows.Count > 0)
                {
                    // user.IdLogIn = txtUsername.Text;
                    user.UserLogInID = int.Parse(txtID.Text);
                    user.LogInPassword = txtPassword.Text;

                    dgvModulesEnrolledIn.DataSource = bll.GetModsEnrolledIn(int.Parse(txtID.Text),txtPassword.Text);
                    dgvModulesEnrolledIn.Enabled = false;

                    epID.Clear();
                    epPassword.Clear();

                    grpDisplay.Text = "View Modules";
                    grpAssessment.Enabled = true;
                    txtAssessmentID.Enabled = false;
                    txtAssessmentType.Enabled = false;
                    dtpDueDate.Enabled = false;
                    cmbStatus.Enabled = false;
                    //btnDisplayAssessment.Enabled = false;
                    btnUpdateAssessment.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Invalid Login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtID.Clear();
                    txtPassword.Clear();
                }
                
            }
            catch
            {
                MessageBox.Show("ERROR!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Clear();
                txtPassword.Clear();

                if (string.IsNullOrEmpty(txtID.Text) || (!Regex.IsMatch(txtID.Text, @"^(\d{13})?$")))
                {
                    epID.SetError(txtID, "Please enter student ID");
                }
                if (string.IsNullOrEmpty(txtPassword.Text) || (!Regex.IsMatch(txtPassword.Text, @"[a-zA-Z]")))
                {
                    epID.SetError(txtPassword, "Please enter password");
                }

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dt = bll.GetAssessmetByStudentLecturerModuleID(int.Parse(txtUserModuleID.Text));
                if(dt.Rows.Count > 0)
                {
                    dgvModulesEnrolledIn.DataSource = bll.GetAssessmetByStudentLecturerModuleID(int.Parse(txtUserModuleID.Text));
                    dgvModulesEnrolledIn.Enabled = true;

                    grpDisplay.Text = "View Assessments";
                    dtpDueDate.Enabled = true;
                    cmbStatus.Enabled = true;
                    
                    epUserModuleID.Clear();
                }
                
            }
            catch
            {
                MessageBox.Show("ERROR!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (string.IsNullOrEmpty(txtUserModuleID.Text) || (!Regex.IsMatch(txtUserModuleID.Text, @"^(\d{13})?$")))
                {
                    epUserModuleID.SetError(txtUserModuleID, "Please enter user module ID");
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User user = new User();

            try
            {
                
                user.AssessmentID = int.Parse(txtAssessmentID.Text);
                user.AssessmentStatus = cmbStatus.SelectedItem.ToString();
                user.DueDate = dtpDueDate.Value.ToString();

                int i = bll.UpdateAssessmentStatus(user);
                if (i > 0)
                {
                    MessageBox.Show("Assessment has been successfully updated!", "User Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAssessmentID.Clear();
                    txtAssessmentType.Clear();
                    txtUserModuleID.Clear();
                    cmbStatus.Text = "Select assessment status";
                    epUserModuleID.Clear();
                }
            }
            catch
            {
                MessageBox.Show("ERROR!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dgvModulesEnrolledIn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvModulesEnrolledIn.SelectedRows.Count > 0)        //if row seleted text box will be filled
            {
               txtAssessmentID.Text = dgvModulesEnrolledIn.SelectedRows[0].Cells["AssessmentID"].Value.ToString();
               txtUserModuleID.Text =dgvModulesEnrolledIn.SelectedRows[0].Cells["StudentLecturerModuleID"].Value.ToString();
               dtpDueDate.Text = dgvModulesEnrolledIn.SelectedRows[0].Cells["DueDate"].Value.ToString();
               txtAssessmentType.Text = dgvModulesEnrolledIn.SelectedRows[0].Cells["AssessmentTypeID"].Value.ToString();
               cmbStatus.Text = dgvModulesEnrolledIn.SelectedRows[0].Cells["AssessmentStatus"].Value.ToString();

            }
            btnUpdateAssessment.Enabled = true;     //enable update button when row from dgv is selected
        }
    }
}
