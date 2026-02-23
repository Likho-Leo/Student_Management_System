namespace ONT2000_Semester2_Project
{
    partial class frmStudentReport
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
            this.btnHome = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.grpStudentReport = new System.Windows.Forms.GroupBox();
            this.dgvStudentReport = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.grpStudentReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentReport)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(505, 510);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(140, 43);
            this.btnHome.TabIndex = 34;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(357, 510);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(142, 43);
            this.btnMenu.TabIndex = 33;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // grpStudentReport
            // 
            this.grpStudentReport.Controls.Add(this.dgvStudentReport);
            this.grpStudentReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStudentReport.Location = new System.Drawing.Point(12, 170);
            this.grpStudentReport.Name = "grpStudentReport";
            this.grpStudentReport.Size = new System.Drawing.Size(639, 334);
            this.grpStudentReport.TabIndex = 32;
            this.grpStudentReport.TabStop = false;
            this.grpStudentReport.Text = "Student Report";
            // 
            // dgvStudentReport
            // 
            this.dgvStudentReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentReport.Location = new System.Drawing.Point(7, 27);
            this.dgvStudentReport.Name = "dgvStudentReport";
            this.dgvStudentReport.RowHeadersWidth = 51;
            this.dgvStudentReport.RowTemplate.Height = 24;
            this.dgvStudentReport.Size = new System.Drawing.Size(620, 296);
            this.dgvStudentReport.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRole);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.lblSearch);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 152);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student";
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(168, 43);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(206, 27);
            this.txtRole.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Role:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(487, 78);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(140, 43);
            this.btnSearch.TabIndex = 35;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(168, 94);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(206, 27);
            this.txtID.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(17, 101);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(93, 20);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Student ID:";
            // 
            // frmStudentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 555);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.grpStudentReport);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmStudentReport";
            this.Text = "frmStudentReport";
            this.Load += new System.EventHandler(this.frmStudentReport_Load);
            this.grpStudentReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentReport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.GroupBox grpStudentReport;
        private System.Windows.Forms.DataGridView dgvStudentReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRole;
    }
}