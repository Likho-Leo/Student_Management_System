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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var frmLecturerSignIn = new frmSignInPage();
            frmLecturerSignIn.Show();
            this.Hide();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure you want to close the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }
    }
}
