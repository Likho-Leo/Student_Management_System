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
using System.Text.RegularExpressions;

namespace ONT2000_Semester2_Project
{
    public partial class frmAssessmentType : Form
    {
        BLL bll = new BLL();
        public frmAssessmentType()
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            User user = new User();
            try
            {
                epDescription.Clear();
                bool i = false;
                if (string.IsNullOrEmpty(txtAssementTypeDescription.Text) || (!Regex.IsMatch(txtAssementTypeDescription.Text, @"[a-zA-Z]")))
                {
                    epDescription.SetError(txtAssementTypeDescription, "Please enter module description");
                    i = true;
                }
                if (i == false)
                {
                    user.AssessmentTypeDescription = txtAssementTypeDescription.Text;

                    int x = bll.InsertAssessmentType(user);
                    if (x > 0)
                    {
                        MessageBox.Show("Assessment type successfully added!", "Assessment Type Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtAssementTypeDescription.Clear();
                        txtAssessmentTypeID.Clear();
                        epDescription.Clear();
                    }
                }
            }
            catch
            {
                MessageBox.Show("ERROR!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
          
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvViewAssessmentType.DataSource = bll.GetAssessmentType();

            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            txtAssementTypeDescription.Clear();
            txtAssessmentTypeID.Clear();
            epDescription.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.AssessmentTypeID = int.Parse(txtAssessmentTypeID.Text);
            user.AssessmentTypeDescription = txtAssementTypeDescription.Text;

            int x = bll.DeleteAssessmentType(user);
            if (x > 0)
            {
                MessageBox.Show("Assessment type successfully deleted!", "Assessment Type Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtAssementTypeDescription.Clear();
                txtAssessmentTypeID.Clear();
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }

        private void dgvViewAssessmentType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvViewAssessmentType.SelectedRows.Count > 0)
            {
                txtAssessmentTypeID.Text = dgvViewAssessmentType.SelectedRows[0].Cells["AssessmentTypeID"].Value.ToString();
                txtAssementTypeDescription.Text = dgvViewAssessmentType.SelectedRows[0].Cells["AssessmentTypeDescription"].Value.ToString();
            }
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void frmAssessmentType_Load(object sender, EventArgs e)
        {
            txtAssessmentTypeID.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void tbnUpdate_Click(object sender, EventArgs e)
        {
            User user = new User();
            try
            {
                epDescription.Clear();
                bool i = false;
                if (string.IsNullOrEmpty(txtAssementTypeDescription.Text) || (!Regex.IsMatch(txtAssementTypeDescription.Text, @"[a-zA-Z]")))
                {
                    epDescription.SetError(txtAssementTypeDescription, "Please enter module description");
                    i = true;
                }
                if (i == false)
                {
                    user.AssessmentTypeID = int.Parse(txtAssessmentTypeID.Text);
                    user.AssessmentTypeDescription = txtAssementTypeDescription.Text;

                    int x = bll.UpdateAssessmentType(user);

                    if (x > 0)
                    {
                        MessageBox.Show("Assessment type has been successfully updated!", "Assessment Type Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtAssementTypeDescription.Clear();
                        txtAssessmentTypeID.Clear();
                        epDescription.Clear();
                        btnDelete.Enabled = false;
                        btnUpdate.Enabled = false;
                    }
                }
                
            }
            catch
            {
                MessageBox.Show("ERROR!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}
