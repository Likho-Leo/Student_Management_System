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
    public partial class frmAssessment : Form
    {
        BLL bll = new BLL();
        public frmAssessment()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            var frmHome = new frmHome();
            frmHome.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frmAssessmentReports = new frmAssessmentReports();
            frmAssessmentReports.Show();
            this.Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            var frmLectMenu = new frmLectMenu();
            frmLectMenu.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.AssessmentID = int.Parse(txtAssessmentID.Text);

            int x = bll.DeleteAssessment(user);
            if (x > 0)
            {
                MessageBox.Show("Assessment has been successefully deleted!", "Assessment Deleted", MessageBoxButtons.OK,MessageBoxIcon.Information);

                txtAssessmentID.Clear();
                cmbUserModID.Text = "Select user ID";
                cmbType.Text = "Select assessment type";

                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvAssessments.DataSource = bll.GetAssessment();

            txtAssessmentID.Clear();
            cmbStatus.Text = "Incomplete";
            cmbUserModID.Text = "Select user ID";
            cmbType.Text = "Select assessment type";

            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            User user = new User();
            try
            {
                if(cmbUserModID.Text != "Select user ID" && cmbUserModID.Text != "" && cmbType.Text != "Select assessment type" && cmbType.Text != "Select assessment type")
                {
                    user.StudLectMod = cmbUserModID.SelectedValue.ToString();
                    user.DueDate = dtpDueDate.Value.ToString();
                    user.TypeID = cmbType.SelectedValue.ToString();
                    user.AssessmentStatus = cmbStatus.Text;

                    int x = bll.InsertAssessment(user);
                    if (x > 0)
                    {
                        MessageBox.Show("Assessment successfully created!", "Assessment Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtAssessmentID.Clear();
                        cmbUserModID.Text = "Select user ID";
                        cmbType.Text = "Select assessment type";

                        btnDelete.Enabled = false;
                        btnUpdate.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("ERROR!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch
            {
                MessageBox.Show("Error!\nplease enter correct Assessment type and user module id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
           
        }
        private void frmAssessment_Load(object sender, EventArgs e)
        {
            txtAssessmentID.Enabled = false;
            cmbStatus.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

            cmbUserModID.DataSource = bll.GetStudMod();
            cmbUserModID.ValueMember = "StudentModuleID";
            cmbUserModID.DisplayMember = "StudentModuleID";
            cmbUserModID.Text = "Select user ID";

            cmbType.DataSource = bll.GetAssessmentType();
            cmbType.ValueMember = "AssessmentTypeID";
            cmbType.DisplayMember = "AssessmentTypeDescription";
            cmbType.Text = "Select assessment type";

            cmbStatus.Text = "Not yet due";
        }

        private void dgvAssessments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAssessments.SelectedRows.Count > 0)
            {
               txtAssessmentID.Text = dgvAssessments.SelectedRows[0].Cells["AssessmentID"].Value.ToString();
               cmbUserModID.Text =dgvAssessments.SelectedRows[0].Cells["StudentLecturerModuleID"].Value.ToString();
               dtpDueDate.Text = dgvAssessments.SelectedRows[0].Cells["DueDate"].Value.ToString();
               cmbType.Text = dgvAssessments.SelectedRows[0].Cells["AssessmentTypeID"].Value.ToString();
               cmbStatus.Text = dgvAssessments.SelectedRows[0].Cells["AssessmentStatus"].Value.ToString();
               btnDelete.Enabled = true;
               btnUpdate.Enabled = true;

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            User user = new User();
            try
            {
                user.DueDate = dtpDueDate.Value.ToString();
                user.TypeID = cmbType.SelectedValue.ToString();
                user.AssessmentID = int.Parse(txtAssessmentID.Text);

                if (cmbType.Text != "Select assessment type")
                {
                    int x = bll.UpdateAssessment(user);

                    if (x > 0)
                    {
                        MessageBox.Show("Assessment successfully updated!", "Assessment Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btnDelete.Enabled = false;
                        btnUpdate.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Please select assessment type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
                MessageBox.Show("ERROR!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvAssessments.DataSource = bll.SearchBetweenDate(cmbUserModID.SelectedValue.ToString(), dtpStart.Text,dtpEnd.Text);
        }
    }
}
