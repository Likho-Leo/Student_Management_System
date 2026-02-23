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
    public partial class frmSignInPage : Form
    {
        BLL bll = new BLL();
        DataTable dt = new DataTable();
        public frmSignInPage()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var frmHome = new frmHome();
            frmHome.Show();
            this.Close();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.LogInPassword = txtPassword.Text;
           
            try
            {
                if (cmbRole.SelectedItem.ToString() == "Lecturer.")
                {
                    dt = bll.LectLogIn(txtPassword.Text);
                    if(user.LogInPassword == "lect123")
                    {
                        user.LogInPassword = txtPassword.Text;

                        var frmLectMenu = new frmLectMenu();
                        frmLectMenu.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Clear();

                        txtPassword.Focus();
                    }

                }
                else if (cmbRole.SelectedItem.ToString() == "Administrator.")
                {
                    dt = bll.AdminLogIn(txtPassword.Text);
                    if (user.LogInPassword == "admin123")
                    {
                        user.LogInPassword = txtPassword.Text;

                        var frmAdmin = new frmAdminMenu();
                        frmAdmin.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Clear();

                        txtPassword.Focus();
                    }
                }
                else if (cmbRole.SelectedItem.ToString() == "Student.")
                {
                    var frmStudentDetails = new frmStudentDetails();
                    frmStudentDetails.Show();
                    this.Close();
                }
                else 
                {
                    MessageBox.Show("Invalid user role!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Invalid user role!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLecturerSignIn_Load(object sender, EventArgs e)
        {
            cmbRole.Text = "Select user role";
            cmbRole.Items.Add("Student.");
            cmbRole.Items.Add("Administrator.");
            cmbRole.Items.Add("Lecturer.");
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRole.SelectedItem.ToString() == "Administrator." || cmbRole.SelectedItem.ToString() == "Lecturer.")
            {
                txtPassword.Enabled = true;
            }
            else
            {
                txtPassword.Enabled = false;
            }
        }
    }
}
