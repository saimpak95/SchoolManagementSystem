namespace SchoolManagementSystem
{
    partial class Roles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RoleStatusCombo = new System.Windows.Forms.ComboBox();
            this.RoleTXT = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SnoGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GVRoleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GVRoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GvRoleStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleError = new System.Windows.Forms.Label();
            this.RoleStatusError = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.Size = new System.Drawing.Size(936, 51);
            // 
            // SearchTXT
            // 
            this.SearchTXT.Size = new System.Drawing.Size(149, 23);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(234, 685);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.RoleStatusError);
            this.panel6.Controls.Add(this.RoleTXT);
            this.panel6.Controls.Add(this.RoleStatusCombo);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.RoleError);
            this.panel6.Size = new System.Drawing.Size(234, 645);
            this.panel6.Controls.SetChildIndex(this.RoleError, 0);
            this.panel6.Controls.SetChildIndex(this.label1, 0);
            this.panel6.Controls.SetChildIndex(this.label2, 0);
            this.panel6.Controls.SetChildIndex(this.RoleStatusCombo, 0);
            this.panel6.Controls.SetChildIndex(this.RoleTXT, 0);
            this.panel6.Controls.SetChildIndex(this.RoleStatusError, 0);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(936, 685);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox2);
            this.panel5.Size = new System.Drawing.Size(936, 645);
            this.panel5.Controls.SetChildIndex(this.panel7, 0);
            this.panel5.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(936, 40);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ROLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "STATUS";
            // 
            // RoleStatusCombo
            // 
            this.RoleStatusCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoleStatusCombo.Enabled = false;
            this.RoleStatusCombo.FormattingEnabled = true;
            this.RoleStatusCombo.Items.AddRange(new object[] {
            "ACTIVE",
            "IN-ACTIVE"});
            this.RoleStatusCombo.Location = new System.Drawing.Point(12, 136);
            this.RoleStatusCombo.Name = "RoleStatusCombo";
            this.RoleStatusCombo.Size = new System.Drawing.Size(211, 23);
            this.RoleStatusCombo.TabIndex = 3;
            this.RoleStatusCombo.SelectedIndexChanged += new System.EventHandler(this.RoleStatusCombo_SelectedIndexChanged);
            // 
            // RoleTXT
            // 
            this.RoleTXT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.RoleTXT.Enabled = false;
            this.RoleTXT.Location = new System.Drawing.Point(12, 92);
            this.RoleTXT.Name = "RoleTXT";
            this.RoleTXT.Size = new System.Drawing.Size(211, 23);
            this.RoleTXT.TabIndex = 4;
            this.RoleTXT.TextChanged += new System.EventHandler(this.RoleTXT_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(936, 594);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DETAILS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SnoGv,
            this.GVRoleID,
            this.GVRoleName,
            this.GvRoleStatus});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(930, 572);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // SnoGv
            // 
            this.SnoGv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SnoGv.HeaderText = "SNO";
            this.SnoGv.Name = "SnoGv";
            this.SnoGv.ReadOnly = true;
            this.SnoGv.Width = 56;
            // 
            // GVRoleID
            // 
            this.GVRoleID.HeaderText = "ROLE ID";
            this.GVRoleID.Name = "GVRoleID";
            this.GVRoleID.ReadOnly = true;
            this.GVRoleID.Visible = false;
            // 
            // GVRoleName
            // 
            this.GVRoleName.HeaderText = "ROLE";
            this.GVRoleName.Name = "GVRoleName";
            this.GVRoleName.ReadOnly = true;
            // 
            // GvRoleStatus
            // 
            this.GvRoleStatus.HeaderText = "STATUS";
            this.GvRoleStatus.Name = "GvRoleStatus";
            this.GvRoleStatus.ReadOnly = true;
            // 
            // RoleError
            // 
            this.RoleError.AutoSize = true;
            this.RoleError.Location = new System.Drawing.Point(212, 75);
            this.RoleError.Name = "RoleError";
            this.RoleError.Size = new System.Drawing.Size(12, 15);
            this.RoleError.TabIndex = 5;
            this.RoleError.Text = "*";
            this.RoleError.Visible = false;
            // 
            // RoleStatusError
            // 
            this.RoleStatusError.AutoSize = true;
            this.RoleStatusError.Location = new System.Drawing.Point(211, 118);
            this.RoleStatusError.Name = "RoleStatusError";
            this.RoleStatusError.Size = new System.Drawing.Size(12, 15);
            this.RoleStatusError.TabIndex = 6;
            this.RoleStatusError.Text = "*";
            this.RoleStatusError.Visible = false;
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 685);
            this.Name = "Roles";
            this.Text = "Roles";
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox RoleTXT;
        private System.Windows.Forms.ComboBox RoleStatusCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label RoleStatusError;
        private System.Windows.Forms.Label RoleError;
        private System.Windows.Forms.DataGridViewTextBoxColumn SnoGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn GVRoleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GVRoleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GvRoleStatus;
    }
}