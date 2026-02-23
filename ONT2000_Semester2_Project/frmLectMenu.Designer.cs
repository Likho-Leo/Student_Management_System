namespace ONT2000_Semester2_Project
{
    partial class frmLectMenu
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
            this.btnCreateAssessment = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnStudReports = new System.Windows.Forms.Button();
            this.btnManageAssessments = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreateAssessment);
            this.groupBox1.Controls.Add(this.btnHome);
            this.groupBox1.Controls.Add(this.btnStudReports);
            this.groupBox1.Controls.Add(this.btnManageAssessments);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 407);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lecturer Menu";
            // 
            // btnCreateAssessment
            // 
            this.btnCreateAssessment.Location = new System.Drawing.Point(51, 82);
            this.btnCreateAssessment.Name = "btnCreateAssessment";
            this.btnCreateAssessment.Size = new System.Drawing.Size(293, 50);
            this.btnCreateAssessment.TabIndex = 3;
            this.btnCreateAssessment.Text = "Create Assessment";
            this.btnCreateAssessment.UseVisualStyleBackColor = true;
            this.btnCreateAssessment.Click += new System.EventHandler(this.btnCreateAssessment_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(51, 314);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(293, 50);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnStudReports
            // 
            this.btnStudReports.Location = new System.Drawing.Point(51, 234);
            this.btnStudReports.Name = "btnStudReports";
            this.btnStudReports.Size = new System.Drawing.Size(293, 50);
            this.btnStudReports.TabIndex = 1;
            this.btnStudReports.Text = "View Student Reports";
            this.btnStudReports.UseVisualStyleBackColor = true;
            this.btnStudReports.Click += new System.EventHandler(this.btnStudReports_Click);
            // 
            // btnManageAssessments
            // 
            this.btnManageAssessments.Location = new System.Drawing.Point(51, 158);
            this.btnManageAssessments.Name = "btnManageAssessments";
            this.btnManageAssessments.Size = new System.Drawing.Size(293, 50);
            this.btnManageAssessments.TabIndex = 0;
            this.btnManageAssessments.Text = "Manage Assessments";
            this.btnManageAssessments.UseVisualStyleBackColor = true;
            this.btnManageAssessments.Click += new System.EventHandler(this.btnManageAssessments_Click);
            // 
            // frmLectMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLectMenu";
            this.Text = "frmLectMenu";
            this.Load += new System.EventHandler(this.frmLectMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnStudReports;
        private System.Windows.Forms.Button btnManageAssessments;
        private System.Windows.Forms.Button btnCreateAssessment;
    }
}