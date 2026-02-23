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
    public partial class frmAssessmentReports : Form
    {

        BLL bll = new BLL();
        public frmAssessmentReports()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var frmAssessment = new frmAssessment();
            frmAssessment.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            var frmHome = new frmHome();
            frmHome.Show();
            this.Close();
        }

        private void frmAssessmentReports_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Add("Incomplete");
            cmbStatus.Items.Add("Completed");
            cmbStatus.Items.Add("Rescheduled"); 
            cmbStatus.Items.Add("Missed");
            cmbStatus.Items.Add("Not yet due");
            //cmbStatus.Text = "Select assessment status";
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvAssessmentReport.DataSource = bll.GetAssessmentByStatus(cmbStatus.SelectedItem.ToString());
        }
    }
}
