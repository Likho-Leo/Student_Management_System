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
    public partial class frmManageUser : Form
    {
        BLL bll = new BLL();
        public frmManageUser()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)      //Add
        {
            User user = new User();
            epError.Clear();
            try
                
            {
                bool i = false;
                if (string.IsNullOrEmpty(txtEmail.Text) || (!Regex.IsMatch(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")))
                {
                    epError.SetError(txtEmail, "Please enter an email address(in the correct format)");
                    i = true;
                }
                if (string.IsNullOrEmpty(txtName.Text) || (!Regex.IsMatch(txtName.Text, @"[a-zA-Z]")))
                {
                    epError.SetError(txtName, "Please enter student name");
                    i = true;
                }
                if (string.IsNullOrEmpty(txtSurname.Text) || (!Regex.IsMatch(txtSurname.Text, @"[a-zA-Z]")))
                {
                    epError.SetError(txtSurname, "Please enter student surname");
                    i = true;
                }
                if (string.IsNullOrEmpty(txtPassword.Text) || (!Regex.IsMatch(txtPassword.Text, @"[a-zA-Z]")))
                {
                    epError.SetError(txtPassword, "Please enter student name");
                    i = true;
                }

                if (i != true)        //if text boxes are  not empty or have incorrect inputs
                {
                    user.Name = txtName.Text;
                    user.Surname = txtSurname.Text;
                    user.Title = cmbTitle.SelectedItem.ToString();
                    user.Email = txtEmail.Text;
                    user.Password = txtPassword.Text;
                    user.Role = cmbRole.SelectedItem.ToString();
                    user.UserStatus = cmbStatus.SelectedItem.ToString();

                    int x = bll.InsertUser(user);
                    //if (cmbRole.SelectedItem.ToString() == "Student.")
                    //{
                    //    int y = bll.InsertStudent(user);
                    //}
                    if (x > 0)
                    {
                        MessageBox.Show(" User has been successfuly added!", "User Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    txtName.Clear();
                    txtSurname.Clear();
                    txtEmail.Clear();
                    epError.Clear();
                    cmbRole.Text = "Select role...";
                    cmbStatus.Text = "Select status..";
                    txtPassword.Clear();
                    cmbTitle.Text = "Select title...";
                }
            }
               
            catch       //error handling
            {
                MessageBox.Show("Please ensure relavent items have been selected from the combo boxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            User user = new User();
            epError.Clear();
            try
            {
                bool i = false;
                if (string.IsNullOrEmpty(txtSurname.Text) || (!Regex.IsMatch(txtSurname.Text, @"[a-zA-Z]")))
                {
                    epError.SetError(txtSurname, "Please enter student surname");
                    i = true;
                }
                if (string.IsNullOrEmpty(txtEmail.Text) || (!Regex.IsMatch(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")))
                {
                    epError.SetError(txtEmail, "Please enter an email address(in the correct format)");
                    i = true;
                }
                if (string.IsNullOrEmpty(txtPassword.Text) || (!Regex.IsMatch(txtPassword.Text, @"[a-zA-Z]")))
                {
                    epError.SetError(txtPassword, "Please enter student name");
                    i = true;
                }

                if (i != true)
                {
                    user.UserID = int.Parse(txtUserID.Text);
                    user.Surname = txtSurname.Text;
                    user.Email = txtEmail.Text;
                    user.Password = txtPassword.Text;
                    user.Title = cmbTitle.SelectedItem.ToString();
                    user.Role = cmbRole.SelectedItem.ToString();
                    user.UserStatus = cmbStatus.SelectedItem.ToString();

                    int x = bll.UpdateUser(user);
                    if (x > 0)
                    {
                        MessageBox.Show("User has been successfully updated!", "User Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    txtName.Enabled = true;
                    cmbRole.Enabled = true;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;

                    txtUserID.Clear();
                    txtName.Clear();
                    txtSurname.Clear();
                    txtEmail.Clear();
                    epError.Clear();
                    cmbRole.Text = "Select role...";
                    cmbStatus.Text = "Select status..";
                    txtPassword.Clear();
                    cmbTitle.Text = "Select title...";
                }
            }
            catch
            {
                MessageBox.Show("Please ensure relavent items have been selected from the combo boxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.UserID = int.Parse(txtUserID.Text);

            int x = bll.DeleteUser(user);
            if (x > 0)
            {
                MessageBox.Show("User has been successfully deleted!", "User Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtName.Enabled = true;
                cmbRole.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

                txtUserID.Clear();
                txtName.Clear();
                txtSurname.Clear();
                txtEmail.Clear();
                epError.Clear();
                cmbRole.Text = "Select role...";
                cmbStatus.Text = "Select status..";
                txtPassword.Clear();
                cmbTitle.Text = "Select title...";
            }
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvUserRecords.DataSource = bll.GetUser();

            txtName.Enabled = true;
            cmbRole.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            txtUserID.Clear();
            txtName.Clear();
            txtSurname.Clear();
            txtEmail.Clear();
            txtSearch.Clear();
            epError.Clear();
            cmbRole.Text = "Select role...";
            cmbStatus.Text = "Select status..";
            txtPassword.Clear();
            cmbTitle.Text = "Select title...";
        }
        private void frmManageUser_Load(object sender, EventArgs e)
        {
            txtUserID.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            cmbRole.Items.Add("Administrator.");
            cmbRole.Items.Add("Lecturer.");
            cmbRole.Items.Add("Student.");
            cmbRole.Text = "Select role...";

            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("Inactive");
            cmbRole.Text = "Select status..";

            cmbTitle.Items.Add("Dr.");
            cmbTitle.Items.Add("Mr.");
            cmbTitle.Items.Add("Mrs.");
            cmbTitle.Items.Add("Miss.");
            cmbTitle.Items.Add("Prof.");
            cmbTitle.Text = "Select title...";

        }
        private void dgvUserRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //fills text boxes with data from the dgv when a record is clicked
            if (dgvUserRecords.SelectedRows.Count > 0)
            {
                txtUserID.Text = dgvUserRecords.SelectedRows[0].Cells["UserID"].Value.ToString();
                txtName.Text = dgvUserRecords.SelectedRows[0].Cells["Name"].Value.ToString();
                txtSurname.Text = dgvUserRecords.SelectedRows[0].Cells["Surname"].Value.ToString();
                txtEmail.Text = dgvUserRecords.SelectedRows[0].Cells["Email"].Value.ToString();
                txtPassword.Text = dgvUserRecords.SelectedRows[0].Cells["Password"].Value.ToString();
                cmbTitle.Text = dgvUserRecords.SelectedRows[0].Cells["Title"].Value.ToString();
                cmbRole.Text = dgvUserRecords.SelectedRows[0].Cells["Role"].Value.ToString();
                cmbStatus.Text = dgvUserRecords.SelectedRows[0].Cells["UserStatus"].Value.ToString();

                txtName.Enabled = false;
                cmbRole.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            epError.Clear();
            bool i = false;
            if (string.IsNullOrEmpty(txtSearch.Text) || (!Regex.IsMatch(txtSearch.Text, @"[a-zA-Z]")))
            {
                epError.SetError(txtSearch, "Please enter student name");
                i = true;
            }
            if (i != true)
            {
                dgvUserRecords.DataSource = bll.GetUserByName(txtSearch.Text);
                epError.Clear();
            }      
        }
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(txtEmail.Text) || (!Regex.IsMatch(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")))
            //{
            //    epError.SetError(txtEmail, "Please enter an email address");
            //}
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            var frmAdminMenu = new frmAdminMenu();
            frmAdminMenu.Show();
            this.Close();
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            var frmHome = new frmHome();
            frmHome.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var frmUserRoles = new frmUserRoles();
            frmUserRoles.Show();
            this.Close();
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRole.SelectedItem.ToString() == "Lecturer.")
            {
                txtPassword.Text = "lect123";
                txtPassword.Enabled = false;
            }
            else if (cmbRole.SelectedItem.ToString() == "Administrator.")
            {
                txtPassword.Text = "admin123";
                txtPassword.Enabled = false;
            }
            else
            {
                txtPassword.Enabled = true;
                txtPassword.Clear();
            }
        }
    }
}
