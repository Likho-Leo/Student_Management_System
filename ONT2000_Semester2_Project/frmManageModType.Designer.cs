namespace ONT2000_Semester2_Project
{
    partial class frmManageModType
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
            this.btnOpenManageMod = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.dgvModType = new System.Windows.Forms.DataGridView();
            this.grpManageRecords = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtModuleTypeID = new System.Windows.Forms.TextBox();
            this.lblModuleTypeID = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtModuleDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModType)).BeginInit();
            this.grpManageRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpenManageMod);
            this.groupBox1.Controls.Add(this.btnHome);
            this.groupBox1.Controls.Add(this.btnMenu);
            this.groupBox1.Controls.Add(this.dgvModType);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 413);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Module Types";
            // 
            // btnOpenManageMod
            // 
            this.btnOpenManageMod.Location = new System.Drawing.Point(1, 360);
            this.btnOpenManageMod.Name = "btnOpenManageMod";
            this.btnOpenManageMod.Size = new System.Drawing.Size(256, 43);
            this.btnOpenManageMod.TabIndex = 27;
            this.btnOpenManageMod.Text = "Manage Modules";
            this.btnOpenManageMod.UseVisualStyleBackColor = true;
            this.btnOpenManageMod.Click += new System.EventHandler(this.btnOpenManageMod_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(557, 360);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(140, 43);
            this.btnHome.TabIndex = 26;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(409, 360);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(142, 43);
            this.btnMenu.TabIndex = 25;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // dgvModType
            // 
            this.dgvModType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModType.Location = new System.Drawing.Point(5, 40);
            this.dgvModType.Name = "dgvModType";
            this.dgvModType.RowHeadersWidth = 51;
            this.dgvModType.RowTemplate.Height = 24;
            this.dgvModType.Size = new System.Drawing.Size(692, 314);
            this.dgvModType.TabIndex = 9;
            this.dgvModType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModType_CellClick);
            this.dgvModType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModType_CellContentClick);
            // 
            // grpManageRecords
            // 
            this.grpManageRecords.Controls.Add(this.btnUpdate);
            this.grpManageRecords.Controls.Add(this.txtModuleTypeID);
            this.grpManageRecords.Controls.Add(this.lblModuleTypeID);
            this.grpManageRecords.Controls.Add(this.btnDisplay);
            this.grpManageRecords.Controls.Add(this.btnDelete);
            this.grpManageRecords.Controls.Add(this.btnAdd);
            this.grpManageRecords.Controls.Add(this.txtModuleDescription);
            this.grpManageRecords.Controls.Add(this.lblDescription);
            this.grpManageRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpManageRecords.Location = new System.Drawing.Point(12, 12);
            this.grpManageRecords.Name = "grpManageRecords";
            this.grpManageRecords.Size = new System.Drawing.Size(711, 202);
            this.grpManageRecords.TabIndex = 9;
            this.grpManageRecords.TabStop = false;
            this.grpManageRecords.Text = "Manage Module Types";
            this.grpManageRecords.Enter += new System.EventHandler(this.grpManageRecords_Enter);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(348, 153);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 37);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtModuleTypeID
            // 
            this.txtModuleTypeID.Location = new System.Drawing.Point(231, 39);
            this.txtModuleTypeID.Name = "txtModuleTypeID";
            this.txtModuleTypeID.Size = new System.Drawing.Size(281, 27);
            this.txtModuleTypeID.TabIndex = 29;
            // 
            // lblModuleTypeID
            // 
            this.lblModuleTypeID.AutoSize = true;
            this.lblModuleTypeID.Location = new System.Drawing.Point(8, 46);
            this.lblModuleTypeID.Name = "lblModuleTypeID";
            this.lblModuleTypeID.Size = new System.Drawing.Size(131, 20);
            this.lblModuleTypeID.TabIndex = 28;
            this.lblModuleTypeID.Text = "Module Type ID:";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(590, 153);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(115, 37);
            this.btnDisplay.TabIndex = 27;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(469, 153);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 37);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(227, 153);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 37);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtModuleDescription
            // 
            this.txtModuleDescription.Location = new System.Drawing.Point(231, 94);
            this.txtModuleDescription.Name = "txtModuleDescription";
            this.txtModuleDescription.Size = new System.Drawing.Size(281, 27);
            this.txtModuleDescription.TabIndex = 7;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(8, 101);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(159, 20);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Module Description:";
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // frmManageModType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 637);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpManageRecords);
            this.Name = "frmManageModType";
            this.Text = "frmManageModType";
            this.Load += new System.EventHandler(this.frmManageModType_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModType)).EndInit();
            this.grpManageRecords.ResumeLayout(false);
            this.grpManageRecords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.DataGridView dgvModType;
        private System.Windows.Forms.GroupBox grpManageRecords;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtModuleDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnOpenManageMod;
        private System.Windows.Forms.TextBox txtModuleTypeID;
        private System.Windows.Forms.Label lblModuleTypeID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ErrorProvider epError;
    }
}