namespace ONT2000_Semester2_Project
{
    partial class frmManageModules
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.txtModuleName = new System.Windows.Forms.TextBox();
            this.grpManageRecords = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.cmbDuration = new System.Windows.Forms.ComboBox();
            this.cmbModuleType = new System.Windows.Forms.ComboBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvModuleRecords = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpManageRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModuleRecords)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 82);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(117, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Module Name:";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(6, 130);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(156, 20);
            this.lblDuration.TabIndex = 1;
            this.lblDuration.Text = "Duration of Module:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(7, 173);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(109, 20);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Module Type:";
            // 
            // txtModuleName
            // 
            this.txtModuleName.Location = new System.Drawing.Point(230, 79);
            this.txtModuleName.Name = "txtModuleName";
            this.txtModuleName.Size = new System.Drawing.Size(315, 27);
            this.txtModuleName.TabIndex = 4;
            // 
            // grpManageRecords
            // 
            this.grpManageRecords.Controls.Add(this.cmbStatus);
            this.grpManageRecords.Controls.Add(this.label3);
            this.grpManageRecords.Controls.Add(this.btnUpdate);
            this.grpManageRecords.Controls.Add(this.txtID);
            this.grpManageRecords.Controls.Add(this.lblID);
            this.grpManageRecords.Controls.Add(this.cmbDuration);
            this.grpManageRecords.Controls.Add(this.cmbModuleType);
            this.grpManageRecords.Controls.Add(this.btnDisplay);
            this.grpManageRecords.Controls.Add(this.btnDelete);
            this.grpManageRecords.Controls.Add(this.btnAdd);
            this.grpManageRecords.Controls.Add(this.txtModuleName);
            this.grpManageRecords.Controls.Add(this.lblType);
            this.grpManageRecords.Controls.Add(this.lblDuration);
            this.grpManageRecords.Controls.Add(this.lblName);
            this.grpManageRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpManageRecords.Location = new System.Drawing.Point(13, 13);
            this.grpManageRecords.Name = "grpManageRecords";
            this.grpManageRecords.Size = new System.Drawing.Size(693, 302);
            this.grpManageRecords.TabIndex = 0;
            this.grpManageRecords.TabStop = false;
            this.grpManageRecords.Text = "Manage Module Records";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(299, 253);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 43);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(230, 38);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(315, 27);
            this.txtID.TabIndex = 31;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(7, 41);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(90, 20);
            this.lblID.TabIndex = 30;
            this.lblID.Text = "Module ID:";
            // 
            // cmbDuration
            // 
            this.cmbDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDuration.FormattingEnabled = true;
            this.cmbDuration.Location = new System.Drawing.Point(230, 122);
            this.cmbDuration.Name = "cmbDuration";
            this.cmbDuration.Size = new System.Drawing.Size(315, 28);
            this.cmbDuration.TabIndex = 29;
            // 
            // cmbModuleType
            // 
            this.cmbModuleType.FormattingEnabled = true;
            this.cmbModuleType.Location = new System.Drawing.Point(230, 165);
            this.cmbModuleType.Name = "cmbModuleType";
            this.cmbModuleType.Size = new System.Drawing.Size(315, 28);
            this.cmbModuleType.TabIndex = 28;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(557, 253);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(123, 43);
            this.btnDisplay.TabIndex = 27;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(428, 253);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 43);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(170, 253);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 43);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvModuleRecords
            // 
            this.dgvModuleRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModuleRecords.Location = new System.Drawing.Point(5, 94);
            this.dgvModuleRecords.Name = "dgvModuleRecords";
            this.dgvModuleRecords.RowHeadersWidth = 51;
            this.dgvModuleRecords.RowTemplate.Height = 24;
            this.dgvModuleRecords.Size = new System.Drawing.Size(676, 260);
            this.dgvModuleRecords.TabIndex = 9;
            this.dgvModuleRecords.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModuleRecords_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnHome);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.txtSearchName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvModuleRecords);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 409);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Module Records";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(532, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(149, 36);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(541, 360);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(140, 43);
            this.btnHome.TabIndex = 26;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(393, 360);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(142, 43);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(153, 53);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(188, 27);
            this.txtSearchName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Search Module:";
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(230, 209);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(315, 28);
            this.cmbStatus.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Module status";
            // 
            // frmManageModules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 742);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpManageRecords);
            this.Name = "frmManageModules";
            this.Text = "frmManageModules";
            this.Load += new System.EventHandler(this.frmManageModules_Load);
            this.grpManageRecords.ResumeLayout(false);
            this.grpManageRecords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModuleRecords)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtModuleName;
        private System.Windows.Forms.GroupBox grpManageRecords;
        private System.Windows.Forms.DataGridView dgvModuleRecords;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbModuleType;
        private System.Windows.Forms.ComboBox cmbDuration;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label3;
    }
}