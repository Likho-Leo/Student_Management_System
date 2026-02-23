namespace ONT2000_Semester2_Project
{
    partial class frmAssignToStud
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.dgvViewStudMods = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.lblAssign = new System.Windows.Forms.Label();
            this.dtpStudDate = new System.Windows.Forms.DateTimePicker();
            this.txtStudModID = new System.Windows.Forms.TextBox();
            this.lblStudentModuleID = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbUserID = new System.Windows.Forms.ComboBox();
            this.cmbLectModID = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblLectModID = new System.Windows.Forms.Label();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStudMods)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMenu);
            this.groupBox2.Controls.Add(this.btnHome);
            this.groupBox2.Controls.Add(this.dgvViewStudMods);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 365);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(637, 278);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View Modules Assigned to Students";
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(397, 231);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(114, 35);
            this.btnMenu.TabIndex = 12;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(517, 231);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(114, 35);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // dgvViewStudMods
            // 
            this.dgvViewStudMods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewStudMods.Location = new System.Drawing.Point(7, 27);
            this.dgvViewStudMods.Name = "dgvViewStudMods";
            this.dgvViewStudMods.RowHeadersWidth = 51;
            this.dgvViewStudMods.RowTemplate.Height = 24;
            this.dgvViewStudMods.Size = new System.Drawing.Size(624, 198);
            this.dgvViewStudMods.TabIndex = 0;
            this.dgvViewStudMods.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewStudMods_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.txtRole);
            this.groupBox1.Controls.Add(this.lblAssign);
            this.groupBox1.Controls.Add(this.dtpStudDate);
            this.groupBox1.Controls.Add(this.txtStudModID);
            this.groupBox1.Controls.Add(this.lblStudentModuleID);
            this.groupBox1.Controls.Add(this.btnDisplay);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.cmbUserID);
            this.groupBox1.Controls.Add(this.cmbLectModID);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.lblUserID);
            this.groupBox1.Controls.Add(this.lblLectModID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 347);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assign Modules to Students";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(328, 301);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 40);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(277, 45);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(320, 27);
            this.txtRole.TabIndex = 15;
            // 
            // lblAssign
            // 
            this.lblAssign.AutoSize = true;
            this.lblAssign.Location = new System.Drawing.Point(8, 48);
            this.lblAssign.Name = "lblAssign";
            this.lblAssign.Size = new System.Drawing.Size(84, 20);
            this.lblAssign.TabIndex = 14;
            this.lblAssign.Text = "Assign to:";
            // 
            // dtpStudDate
            // 
            this.dtpStudDate.Location = new System.Drawing.Point(278, 213);
            this.dtpStudDate.Name = "dtpStudDate";
            this.dtpStudDate.Size = new System.Drawing.Size(319, 27);
            this.dtpStudDate.TabIndex = 13;
            // 
            // txtStudModID
            // 
            this.txtStudModID.Location = new System.Drawing.Point(277, 86);
            this.txtStudModID.Name = "txtStudModID";
            this.txtStudModID.Size = new System.Drawing.Size(320, 27);
            this.txtStudModID.TabIndex = 12;
            // 
            // lblStudentModuleID
            // 
            this.lblStudentModuleID.AutoSize = true;
            this.lblStudentModuleID.Location = new System.Drawing.Point(8, 89);
            this.lblStudentModuleID.Name = "lblStudentModuleID";
            this.lblStudentModuleID.Size = new System.Drawing.Size(152, 20);
            this.lblStudentModuleID.TabIndex = 11;
            this.lblStudentModuleID.Text = "Student Module ID:";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(534, 301);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(97, 40);
            this.btnDisplay.TabIndex = 10;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(225, 301);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 40);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(431, 301);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 40);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(278, 255);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(319, 28);
            this.cmbStatus.TabIndex = 6;
            // 
            // cmbUserID
            // 
            this.cmbUserID.FormattingEnabled = true;
            this.cmbUserID.Location = new System.Drawing.Point(278, 166);
            this.cmbUserID.Name = "cmbUserID";
            this.cmbUserID.Size = new System.Drawing.Size(319, 28);
            this.cmbUserID.TabIndex = 5;
            // 
            // cmbLectModID
            // 
            this.cmbLectModID.FormattingEnabled = true;
            this.cmbLectModID.Location = new System.Drawing.Point(278, 124);
            this.cmbLectModID.Name = "cmbLectModID";
            this.cmbLectModID.Size = new System.Drawing.Size(319, 28);
            this.cmbLectModID.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(8, 263);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(62, 20);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(8, 216);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(50, 20);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date:";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(8, 174);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(72, 20);
            this.lblUserID.TabIndex = 1;
            this.lblUserID.Text = "User ID:";
            // 
            // lblLectModID
            // 
            this.lblLectModID.AutoSize = true;
            this.lblLectModID.Location = new System.Drawing.Point(8, 132);
            this.lblLectModID.Name = "lblLectModID";
            this.lblLectModID.Size = new System.Drawing.Size(152, 20);
            this.lblLectModID.TabIndex = 0;
            this.lblLectModID.Text = "Lecture Module ID:";
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // frmAssignToStud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 655);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAssignToStud";
            this.Text = "frmAssignToStud";
            this.Load += new System.EventHandler(this.frmAssignToStud_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStudMods)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DataGridView dgvViewStudMods;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblLectModID;
        private System.Windows.Forms.Label lblStudentModuleID;
        private System.Windows.Forms.DateTimePicker dtpStudDate;
        private System.Windows.Forms.TextBox txtStudModID;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbUserID;
        private System.Windows.Forms.ComboBox cmbLectModID;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Label lblAssign;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ErrorProvider epError;
    }
}