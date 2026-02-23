namespace ONT2000_Semester2_Project
{
    partial class frmAssignToLecturers
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
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblModID = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbLecturerID = new System.Windows.Forms.ComboBox();
            this.cmbModID = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLectureModuleID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.dgvLectMods = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLectMods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(6, 125);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(99, 20);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "Lecturer ID:";
            // 
            // lblModID
            // 
            this.lblModID.AutoSize = true;
            this.lblModID.Location = new System.Drawing.Point(6, 167);
            this.lblModID.Name = "lblModID";
            this.lblModID.Size = new System.Drawing.Size(90, 20);
            this.lblModID.TabIndex = 1;
            this.lblModID.Text = "Module ID:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(6, 209);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(50, 20);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(6, 256);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(62, 20);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status:";
            // 
            // cmbLecturerID
            // 
            this.cmbLecturerID.FormattingEnabled = true;
            this.cmbLecturerID.Location = new System.Drawing.Point(240, 122);
            this.cmbLecturerID.Name = "cmbLecturerID";
            this.cmbLecturerID.Size = new System.Drawing.Size(340, 28);
            this.cmbLecturerID.TabIndex = 4;
            // 
            // cmbModID
            // 
            this.cmbModID.FormattingEnabled = true;
            this.cmbModID.Location = new System.Drawing.Point(240, 164);
            this.cmbModID.Name = "cmbModID";
            this.cmbModID.Size = new System.Drawing.Size(340, 28);
            this.cmbModID.TabIndex = 5;
            this.cmbModID.SelectedIndexChanged += new System.EventHandler(this.cmbModID_SelectedIndexChanged);
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(240, 253);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(340, 28);
            this.cmbStatus.TabIndex = 6;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(240, 204);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(340, 27);
            this.dtpDate.TabIndex = 7;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(524, 302);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(105, 33);
            this.btnDisplay.TabIndex = 8;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(191, 302);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 33);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(413, 302);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 33);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRole);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.txtLectureModuleID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnDisplay);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.cmbModID);
            this.groupBox1.Controls.Add(this.cmbLecturerID);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.lblModID);
            this.groupBox1.Controls.Add(this.lblUserID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assign Modules to Lecturers";
            // 
            // txtLectureModuleID
            // 
            this.txtLectureModuleID.Location = new System.Drawing.Point(240, 74);
            this.txtLectureModuleID.Name = "txtLectureModuleID";
            this.txtLectureModuleID.Size = new System.Drawing.Size(340, 27);
            this.txtLectureModuleID.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Lecturer Module ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMenu);
            this.groupBox2.Controls.Add(this.btnHome);
            this.groupBox2.Controls.Add(this.dgvLectMods);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 385);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(637, 271);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View Modules Assigned to Lecturers";
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(397, 235);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(114, 31);
            this.btnMenu.TabIndex = 12;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(517, 235);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(114, 31);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // dgvLectMods
            // 
            this.dgvLectMods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLectMods.Location = new System.Drawing.Point(7, 27);
            this.dgvLectMods.Name = "dgvLectMods";
            this.dgvLectMods.RowHeadersWidth = 51;
            this.dgvLectMods.RowTemplate.Height = 24;
            this.dgvLectMods.Size = new System.Drawing.Size(624, 186);
            this.dgvLectMods.TabIndex = 0;
            this.dgvLectMods.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLectMods_CellClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(302, 302);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 33);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(240, 36);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(340, 27);
            this.txtRole.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Assign to:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAssignToLecturers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 668);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAssignToLecturers";
            this.Text = "frmAssignToLecturers";
            this.Load += new System.EventHandler(this.frmAssignToLecturers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLectMods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblModID;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbLecturerID;
        private System.Windows.Forms.ComboBox cmbModID;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvLectMods;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TextBox txtLectureModuleID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}