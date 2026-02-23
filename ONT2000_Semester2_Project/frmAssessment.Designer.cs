namespace ONT2000_Semester2_Project
{
    partial class frmAssessment
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtAssessmentID = new System.Windows.Forms.TextBox();
            this.lblAssessmentID = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbUserModID = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblAssessmentType = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblUserModID = new System.Windows.Forms.Label();
            this.grpViewAssessmnets = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.dgvAssessments = new System.Windows.Forms.DataGridView();
            this.epUserModuleID = new System.Windows.Forms.ErrorProvider(this.components);
            this.epAssessmentType = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.grpViewAssessmnets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssessments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUserModuleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAssessmentType)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbType);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.txtAssessmentID);
            this.groupBox1.Controls.Add(this.lblAssessmentID);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnDisplay);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.dtpDueDate);
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.cmbUserModID);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.lblAssessmentType);
            this.groupBox1.Controls.Add(this.lblDueDate);
            this.groupBox1.Controls.Add(this.lblUserModID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(870, 281);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assessments";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(499, 168);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(309, 28);
            this.cmbType.TabIndex = 14;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(555, 239);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 36);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtAssessmentID
            // 
            this.txtAssessmentID.Location = new System.Drawing.Point(499, 43);
            this.txtAssessmentID.Name = "txtAssessmentID";
            this.txtAssessmentID.Size = new System.Drawing.Size(309, 27);
            this.txtAssessmentID.TabIndex = 12;
            // 
            // lblAssessmentID
            // 
            this.lblAssessmentID.AutoSize = true;
            this.lblAssessmentID.Location = new System.Drawing.Point(13, 46);
            this.lblAssessmentID.Name = "lblAssessmentID";
            this.lblAssessmentID.Size = new System.Drawing.Size(129, 20);
            this.lblAssessmentID.TabIndex = 11;
            this.lblAssessmentID.Text = "Assessment ID:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(450, 239);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 36);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(765, 239);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(99, 36);
            this.btnDisplay.TabIndex = 9;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(660, 239);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 36);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(499, 128);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(309, 27);
            this.dtpDueDate.TabIndex = 7;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(499, 205);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(309, 28);
            this.cmbStatus.TabIndex = 6;
            // 
            // cmbUserModID
            // 
            this.cmbUserModID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserModID.FormattingEnabled = true;
            this.cmbUserModID.Location = new System.Drawing.Point(499, 85);
            this.cmbUserModID.Name = "cmbUserModID";
            this.cmbUserModID.Size = new System.Drawing.Size(309, 28);
            this.cmbUserModID.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(13, 213);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(160, 20);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Assessment Status:";
            // 
            // lblAssessmentType
            // 
            this.lblAssessmentType.AutoSize = true;
            this.lblAssessmentType.Location = new System.Drawing.Point(13, 171);
            this.lblAssessmentType.Name = "lblAssessmentType";
            this.lblAssessmentType.Size = new System.Drawing.Size(148, 20);
            this.lblAssessmentType.TabIndex = 2;
            this.lblAssessmentType.Text = "Assessment Type:";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(13, 128);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(86, 20);
            this.lblDueDate.TabIndex = 1;
            this.lblDueDate.Text = "Due Date:";
            // 
            // lblUserModID
            // 
            this.lblUserModID.AutoSize = true;
            this.lblUserModID.Location = new System.Drawing.Point(13, 90);
            this.lblUserModID.Name = "lblUserModID";
            this.lblUserModID.Size = new System.Drawing.Size(131, 20);
            this.lblUserModID.TabIndex = 0;
            this.lblUserModID.Text = "User Module ID:";
            // 
            // grpViewAssessmnets
            // 
            this.grpViewAssessmnets.Controls.Add(this.btnSearch);
            this.grpViewAssessmnets.Controls.Add(this.dtpEnd);
            this.grpViewAssessmnets.Controls.Add(this.label2);
            this.grpViewAssessmnets.Controls.Add(this.dtpStart);
            this.grpViewAssessmnets.Controls.Add(this.label1);
            this.grpViewAssessmnets.Controls.Add(this.button1);
            this.grpViewAssessmnets.Controls.Add(this.btnMenu);
            this.grpViewAssessmnets.Controls.Add(this.btnHome);
            this.grpViewAssessmnets.Controls.Add(this.dgvAssessments);
            this.grpViewAssessmnets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpViewAssessmnets.Location = new System.Drawing.Point(13, 299);
            this.grpViewAssessmnets.Name = "grpViewAssessmnets";
            this.grpViewAssessmnets.Size = new System.Drawing.Size(876, 364);
            this.grpViewAssessmnets.TabIndex = 11;
            this.grpViewAssessmnets.TabStop = false;
            this.grpViewAssessmnets.Text = "View Assessments";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(689, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(181, 36);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search between dates";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(442, 35);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(220, 27);
            this.dtpEnd.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "End Date:";
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(110, 37);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(220, 27);
            this.dtpStart.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Start Date:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "Open Assessment Reports";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(666, 322);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(99, 36);
            this.btnMenu.TabIndex = 12;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(771, 322);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(99, 36);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // dgvAssessments
            // 
            this.dgvAssessments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssessments.Location = new System.Drawing.Point(10, 78);
            this.dgvAssessments.Name = "dgvAssessments";
            this.dgvAssessments.RowHeadersWidth = 51;
            this.dgvAssessments.RowTemplate.Height = 24;
            this.dgvAssessments.Size = new System.Drawing.Size(860, 238);
            this.dgvAssessments.TabIndex = 0;
            this.dgvAssessments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssessments_CellClick);
            // 
            // epUserModuleID
            // 
            this.epUserModuleID.ContainerControl = this;
            // 
            // epAssessmentType
            // 
            this.epAssessmentType.ContainerControl = this;
            // 
            // frmAssessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(901, 675);
            this.Controls.Add(this.grpViewAssessmnets);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAssessment";
            this.Text = "frmAssessment";
            this.Load += new System.EventHandler(this.frmAssessment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpViewAssessmnets.ResumeLayout(false);
            this.grpViewAssessmnets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssessments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUserModuleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAssessmentType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbUserModID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblAssessmentType;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblUserModID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grpViewAssessmnets;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DataGridView dgvAssessments;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAssessmentID;
        private System.Windows.Forms.Label lblAssessmentID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ErrorProvider epUserModuleID;
        private System.Windows.Forms.ErrorProvider epAssessmentType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label1;
    }
}