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
    public partial class frmLectMenu : Form
    {
        public frmLectMenu()
        {
            InitializeComponent();
        }

        private void btnManageAssessments_Click(object sender, EventArgs e)
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

        private void btnStudReports_Click(object sender, EventArgs e)
        {
            var frmStudentReport = new frmStudentReport();
            frmStudentReport.Show();
            this.Close();
        }

        private void btnCreateAssessment_Click(object sender, EventArgs e)
        {
            var frmAssessmentType = new frmAssessmentType();
            frmAssessmentType.Show();
            this.Close();
        }

        private void frmLectMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
