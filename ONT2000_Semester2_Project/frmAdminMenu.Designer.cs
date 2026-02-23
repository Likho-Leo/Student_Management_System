namespace ONT2000_Semester2_Project
{
    partial class frmAdminMenu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAssignToStudents = new System.Windows.Forms.Button();
            this.btnAssignToLecturers = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnManageModules = new System.Windows.Forms.Button();
            this.btnManageUser = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAssignToStudents);
            this.groupBox1.Controls.Add(this.btnAssignToLecturers);
            this.groupBox1.Controls.Add(this.btnHome);
            this.groupBox1.Controls.Add(this.btnManageModules);
            this.groupBox1.Controls.Add(this.btnManageUser);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 420);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrator Menu";
            // 
            // btnAssignToStudents
            // 
            this.btnAssignToStudents.Location = new System.Drawing.Point(18, 271);
            this.btnAssignToStudents.Name = "btnAssignToStudents";
            this.btnAssignToStudents.Size = new System.Drawing.Size(314, 54);
            this.btnAssignToStudents.TabIndex = 6;
            this.btnAssignToStudents.Text = "Assign Modules to Students";
            this.btnAssignToStudents.UseVisualStyleBackColor = true;
            this.btnAssignToStudents.Click += new System.EventHandler(this.btnAssignToStudents_Click);
            // 
            // btnAssignToLecturers
            // 
            this.btnAssignToLecturers.Location = new System.Drawing.Point(18, 186);
            this.btnAssignToLecturers.Name = "btnAssignToLecturers";
            this.btnAssignToLecturers.Size = new System.Drawing.Size(314, 54);
            this.btnAssignToLecturers.TabIndex = 5;
            this.btnAssignToLecturers.Text = "Assign Modules to Lecturers";
            this.btnAssignToLecturers.UseVisualStyleBackColor = true;
            this.btnAssignToLecturers.Click += new System.EventHandler(this.btnAssignToLecturers_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(18, 347);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(314, 54);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnManageModules
            // 
            this.btnManageModules.Location = new System.Drawing.Point(18, 106);
            this.btnManageModules.Name = "btnManageModules";
            this.btnManageModules.Size = new System.Drawing.Size(314, 54);
            this.btnManageModules.TabIndex = 3;
            this.btnManageModules.Text = "Manage Module Records";
            this.btnManageModules.UseVisualStyleBackColor = true;
            this.btnManageModules.Click += new System.EventHandler(this.btnManageModules_Click);
            // 
            // btnManageUser
            // 
            this.btnManageUser.Location = new System.Drawing.Point(18, 26);
            this.btnManageUser.Name = "btnManageUser";
            this.btnManageUser.Size = new System.Drawing.Size(314, 54);
            this.btnManageUser.TabIndex = 2;
            this.btnManageUser.Text = "Manage User Records";
            this.btnManageUser.UseVisualStyleBackColor = true;
            this.btnManageUser.Click += new System.EventHandler(this.btnManageUser_Click);
            // 
            // frmAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 444);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAdminMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmAdminMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnManageModules;
        private System.Windows.Forms.Button btnManageUser;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnAssignToStudents;
        private System.Windows.Forms.Button btnAssignToLecturers;
    }
}