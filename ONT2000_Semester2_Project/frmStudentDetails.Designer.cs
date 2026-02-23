namespace ONT2000_Semester2_Project
{
    partial class frmStudentDetails
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
            this.components = new System.ComponentModel.Container();
            this.btnHome = new System.Windows.Forms.Button();
            this.grpDisplay = new System.Windows.Forms.GroupBox();
            this.dgvModulesEnrolledIn = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUserID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.epID = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpAssessment = new System.Windows.Forms.GroupBox();
            this.btnUpdateAssessment = new System.Windows.Forms.Button();
            this.btnDisplayAssessment = new System.Windows.Forms.Button();
            this.txtAssessmentType = new System.Windows.Forms.TextBox();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblAssessmentType = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserModuleID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAssessmentID = new System.Windows.Forms.TextBox();
            this.epUserModuleID = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModulesEnrolledIn)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPassword)).BeginInit();
            this.grpAssessment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epUserModuleID)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(862, 620);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(154, 42);
            this.btnHome.TabIndex = 8;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // grpDisplay
            // 
            this.grpDisplay.Controls.Add(this.dgvModulesEnrolledIn);
            this.grpDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDisplay.Location = new System.Drawing.Point(11, 348);
            this.grpDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDisplay.Name = "grpDisplay";
            this.grpDisplay.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDisplay.Size = new System.Drawing.Size(1003, 268);
            this.grpDisplay.TabIndex = 7;
            this.grpDisplay.TabStop = false;
            this.grpDisplay.Text = "Veiw Modules";
            // 
            // dgvModulesEnrolledIn
            // 
            this.dgvModulesEnrolledIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModulesEnrolledIn.Location = new System.Drawing.Point(7, 27);
            this.dgvModulesEnrolledIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvModulesEnrolledIn.Name = "dgvModulesEnrolledIn";
            this.dgvModulesEnrolledIn.RowHeadersWidth = 51;
            this.dgvModulesEnrolledIn.RowTemplate.Height = 24;
            this.dgvModulesEnrolledIn.Size = new System.Drawing.Size(991, 236);
            this.dgvModulesEnrolledIn.TabIndex = 0;
            this.dgvModulesEnrolledIn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModulesEnrolledIn_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.lblUserID);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(401, 332);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(177, 101);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(187, 27);
            this.txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(177, 154);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(162, 44);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnViewMods_Click);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(5, 55);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(93, 20);
            this.lblUserID.TabIndex = 1;
            this.lblUserID.Text = "Student ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(177, 52);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(187, 27);
            this.txtID.TabIndex = 0;
            // 
            // epID
            // 
            this.epID.ContainerControl = this;
            // 
            // epPassword
            // 
            this.epPassword.ContainerControl = this;
            // 
            // grpAssessment
            // 
            this.grpAssessment.Controls.Add(this.btnUpdateAssessment);
            this.grpAssessment.Controls.Add(this.btnDisplayAssessment);
            this.grpAssessment.Controls.Add(this.txtAssessmentType);
            this.grpAssessment.Controls.Add(this.dtpDueDate);
            this.grpAssessment.Controls.Add(this.cmbStatus);
            this.grpAssessment.Controls.Add(this.lblStatus);
            this.grpAssessment.Controls.Add(this.lblAssessmentType);
            this.grpAssessment.Controls.Add(this.label4);
            this.grpAssessment.Controls.Add(this.label2);
            this.grpAssessment.Controls.Add(this.txtUserModuleID);
            this.grpAssessment.Controls.Add(this.label3);
            this.grpAssessment.Controls.Add(this.txtAssessmentID);
            this.grpAssessment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAssessment.Location = new System.Drawing.Point(419, 13);
            this.grpAssessment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAssessment.Name = "grpAssessment";
            this.grpAssessment.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAssessment.Size = new System.Drawing.Size(589, 331);
            this.grpAssessment.TabIndex = 7;
            this.grpAssessment.TabStop = false;
            this.grpAssessment.Text = "Assessment";
            // 
            // btnUpdateAssessment
            // 
            this.btnUpdateAssessment.Location = new System.Drawing.Point(185, 283);
            this.btnUpdateAssessment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateAssessment.Name = "btnUpdateAssessment";
            this.btnUpdateAssessment.Size = new System.Drawing.Size(200, 44);
            this.btnUpdateAssessment.TabIndex = 13;
            this.btnUpdateAssessment.Text = "Update Assessment";
            this.btnUpdateAssessment.UseVisualStyleBackColor = true;
            this.btnUpdateAssessment.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDisplayAssessment
            // 
            this.btnDisplayAssessment.Location = new System.Drawing.Point(391, 283);
            this.btnDisplayAssessment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDisplayAssessment.Name = "btnDisplayAssessment";
            this.btnDisplayAssessment.Size = new System.Drawing.Size(192, 44);
            this.btnDisplayAssessment.TabIndex = 5;
            this.btnDisplayAssessment.Text = "Display Assessment";
            this.btnDisplayAssessment.UseVisualStyleBackColor = true;
            this.btnDisplayAssessment.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAssessmentType
            // 
            this.txtAssessmentType.Location = new System.Drawing.Point(177, 184);
            this.txtAssessmentType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAssessmentType.Name = "txtAssessmentType";
            this.txtAssessmentType.Size = new System.Drawing.Size(187, 27);
            this.txtAssessmentType.TabIndex = 12;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Location = new System.Drawing.Point(177, 150);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(318, 27);
            this.dtpDueDate.TabIndex = 11;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(177, 226);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(187, 28);
            this.cmbStatus.TabIndex = 10;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(5, 229);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(160, 20);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Assessment Status:";
            // 
            // lblAssessmentType
            // 
            this.lblAssessmentType.AutoSize = true;
            this.lblAssessmentType.Location = new System.Drawing.Point(5, 187);
            this.lblAssessmentType.Name = "lblAssessmentType";
            this.lblAssessmentType.Size = new System.Drawing.Size(148, 20);
            this.lblAssessmentType.TabIndex = 7;
            this.lblAssessmentType.Text = "Assessment Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Due Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "User Module ID:";
            // 
            // txtUserModuleID
            // 
            this.txtUserModuleID.Location = new System.Drawing.Point(177, 101);
            this.txtUserModuleID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserModuleID.Name = "txtUserModuleID";
            this.txtUserModuleID.Size = new System.Drawing.Size(187, 27);
            this.txtUserModuleID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Assessment ID:";
            // 
            // txtAssessmentID
            // 
            this.txtAssessmentID.Location = new System.Drawing.Point(177, 52);
            this.txtAssessmentID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAssessmentID.Name = "txtAssessmentID";
            this.txtAssessmentID.Size = new System.Drawing.Size(187, 27);
            this.txtAssessmentID.TabIndex = 0;
            // 
            // epUserModuleID
            // 
            this.epUserModuleID.ContainerControl = this;
            // 
            // frmStudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 673);
            this.Controls.Add(this.grpAssessment);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.grpDisplay);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmStudentDetails";
            this.Text = "frmStudentDetails";
            this.Load += new System.EventHandler(this.frmStudentDetails_Load);
            this.grpDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModulesEnrolledIn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPassword)).EndInit();
            this.grpAssessment.ResumeLayout(false);
            this.grpAssessment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epUserModuleID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.GroupBox grpDisplay;
        private System.Windows.Forms.DataGridView dgvModulesEnrolledIn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ErrorProvider epID;
        private System.Windows.Forms.ErrorProvider epPassword;
        private System.Windows.Forms.GroupBox grpAssessment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserModuleID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAssessmentID;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblAssessmentType;
        private System.Windows.Forms.TextBox txtAssessmentType;
        private System.Windows.Forms.Button btnUpdateAssessment;
        private System.Windows.Forms.Button btnDisplayAssessment;
        private System.Windows.Forms.ErrorProvider epUserModuleID;
    }
}