namespace ONT2000_Semester2_Project
{
    partial class frmAssessmentType
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtAssessmentTypeID = new System.Windows.Forms.TextBox();
            this.lblAssessmentTypeID = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAssementTypeDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvViewAssessmentType = new System.Windows.Forms.DataGridView();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.epDescription = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAssessmentType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDescription)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.txtAssessmentTypeID);
            this.groupBox1.Controls.Add(this.lblAssessmentTypeID);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnDisplay);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtAssementTypeDescription);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assessment Type";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(248, 141);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 31);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.tbnUpdate_Click);
            // 
            // txtAssessmentTypeID
            // 
            this.txtAssessmentTypeID.Location = new System.Drawing.Point(258, 51);
            this.txtAssessmentTypeID.Name = "txtAssessmentTypeID";
            this.txtAssessmentTypeID.Size = new System.Drawing.Size(271, 27);
            this.txtAssessmentTypeID.TabIndex = 5;
            // 
            // lblAssessmentTypeID
            // 
            this.lblAssessmentTypeID.AutoSize = true;
            this.lblAssessmentTypeID.Location = new System.Drawing.Point(13, 54);
            this.lblAssessmentTypeID.Name = "lblAssessmentTypeID";
            this.lblAssessmentTypeID.Size = new System.Drawing.Size(170, 20);
            this.lblAssessmentTypeID.TabIndex = 4;
            this.lblAssessmentTypeID.Text = "Assessment Type ID:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(359, 141);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 31);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(470, 141);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(105, 31);
            this.btnDisplay.TabIndex = 3;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(137, 141);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 31);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAssementTypeDescription
            // 
            this.txtAssementTypeDescription.Location = new System.Drawing.Point(258, 93);
            this.txtAssementTypeDescription.Name = "txtAssementTypeDescription";
            this.txtAssementTypeDescription.Size = new System.Drawing.Size(271, 27);
            this.txtAssementTypeDescription.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(13, 96);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(198, 20);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Assessment Description:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvViewAssessmentType);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(581, 248);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View Assessment Type";
            // 
            // dgvViewAssessmentType
            // 
            this.dgvViewAssessmentType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewAssessmentType.Location = new System.Drawing.Point(6, 27);
            this.dgvViewAssessmentType.Name = "dgvViewAssessmentType";
            this.dgvViewAssessmentType.RowHeadersWidth = 51;
            this.dgvViewAssessmentType.RowTemplate.Height = 24;
            this.dgvViewAssessmentType.Size = new System.Drawing.Size(569, 203);
            this.dgvViewAssessmentType.TabIndex = 0;
            this.dgvViewAssessmentType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewAssessmentType_CellClick);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(482, 450);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(105, 31);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(371, 450);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(105, 31);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // epDescription
            // 
            this.epDescription.ContainerControl = this;
            // 
            // frmAssessmentType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 493);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAssessmentType";
            this.Text = "frmAssessmentType";
            this.Load += new System.EventHandler(this.frmAssessmentType_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAssessmentType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDescription)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAssementTypeDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvViewAssessmentType;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.TextBox txtAssessmentTypeID;
        private System.Windows.Forms.Label lblAssessmentTypeID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ErrorProvider epDescription;
    }
}