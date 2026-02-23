namespace ONT2000_Semester2_Project
{
    partial class frmUserRoles
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
            this.cmbUserRole = new System.Windows.Forms.ComboBox();
            this.lblSelectUserRole = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvUserRoles = new System.Windows.Forms.DataGridView();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbUserRole);
            this.groupBox1.Controls.Add(this.lblSelectUserRole);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Roles";
            // 
            // cmbUserRole
            // 
            this.cmbUserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserRole.FormattingEnabled = true;
            this.cmbUserRole.Location = new System.Drawing.Point(425, 48);
            this.cmbUserRole.Name = "cmbUserRole";
            this.cmbUserRole.Size = new System.Drawing.Size(202, 28);
            this.cmbUserRole.TabIndex = 1;
            this.cmbUserRole.SelectedIndexChanged += new System.EventHandler(this.cmbUserRoles_SelectedIndexChanged);
            // 
            // lblSelectUserRole
            // 
            this.lblSelectUserRole.AutoSize = true;
            this.lblSelectUserRole.Location = new System.Drawing.Point(254, 56);
            this.lblSelectUserRole.Name = "lblSelectUserRole";
            this.lblSelectUserRole.Size = new System.Drawing.Size(141, 20);
            this.lblSelectUserRole.TabIndex = 0;
            this.lblSelectUserRole.Text = "Select User Role:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvUserRoles);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(633, 329);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View User Roles";
            // 
            // dgvUserRoles
            // 
            this.dgvUserRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserRoles.Location = new System.Drawing.Point(7, 27);
            this.dgvUserRoles.Name = "dgvUserRoles";
            this.dgvUserRoles.RowHeadersWidth = 51;
            this.dgvUserRoles.RowTemplate.Height = 24;
            this.dgvUserRoles.Size = new System.Drawing.Size(620, 296);
            this.dgvUserRoles.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(507, 444);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(140, 43);
            this.btnHome.TabIndex = 26;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(359, 444);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(142, 43);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // frmUserRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 491);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmUserRoles";
            this.Text = "frmUserRoles";
            this.Load += new System.EventHandler(this.frmUserRoles_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRoles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbUserRole;
        private System.Windows.Forms.Label lblSelectUserRole;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvUserRoles;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnBack;
    }
}