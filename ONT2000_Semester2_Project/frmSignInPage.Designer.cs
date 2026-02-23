namespace ONT2000_Semester2_Project
{
    partial class frmSignInPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpLecturerSignIn = new System.Windows.Forms.GroupBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.grpLecturerSignIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLecturerSignIn
            // 
            this.grpLecturerSignIn.Controls.Add(this.cmbRole);
            this.grpLecturerSignIn.Controls.Add(this.label1);
            this.grpLecturerSignIn.Controls.Add(this.btnBack);
            this.grpLecturerSignIn.Controls.Add(this.btnSignIn);
            this.grpLecturerSignIn.Controls.Add(this.txtPassword);
            this.grpLecturerSignIn.Controls.Add(this.lblPassword);
            this.grpLecturerSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLecturerSignIn.Location = new System.Drawing.Point(12, 12);
            this.grpLecturerSignIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpLecturerSignIn.Name = "grpLecturerSignIn";
            this.grpLecturerSignIn.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpLecturerSignIn.Size = new System.Drawing.Size(533, 288);
            this.grpLecturerSignIn.TabIndex = 1;
            this.grpLecturerSignIn.TabStop = false;
            this.grpLecturerSignIn.Text = "User Sign-in";
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(192, 58);
            this.cmbRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(296, 30);
            this.cmbRole.TabIndex = 7;
            this.cmbRole.SelectedIndexChanged += new System.EventHandler(this.cmbRole_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sign-in as:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(379, 235);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 37);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(192, 235);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(109, 37);
            this.btnSignIn.TabIndex = 4;
            this.btnSignIn.Text = "Sign-In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(192, 122);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(296, 28);
            this.txtPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(36, 127);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(142, 22);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Enter Password:";
            // 
            // frmSignInPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 310);
            this.Controls.Add(this.grpLecturerSignIn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSignInPage";
            this.Text = "frmSignInPage";
            this.Load += new System.EventHandler(this.frmLecturerSignIn_Load);
            this.grpLecturerSignIn.ResumeLayout(false);
            this.grpLecturerSignIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLecturerSignIn;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRole;
    }
}