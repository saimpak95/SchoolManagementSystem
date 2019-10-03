namespace SchoolManagementSystem
{
    partial class PERIOD
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
            this.ErrorStatus = new System.Windows.Forms.Label();
            this.ErrorPeriod = new System.Windows.Forms.Label();
            this.ComboStatus = new System.Windows.Forms.ComboBox();
            this.TXTPeriodName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SnoGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GVPeriodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GVPeriodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GvStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel7.Size = new System.Drawing.Size(933, 51);
            // 
            // SearchTXT
            // 
            this.SearchTXT.Size = new System.Drawing.Size(146, 23);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(234, 597);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.ErrorStatus);
            this.panel6.Controls.Add(this.ErrorPeriod);
            this.panel6.Controls.Add(this.ComboStatus);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.TXTPeriodName);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Size = new System.Drawing.Size(234, 557);
            this.panel6.Controls.SetChildIndex(this.label1, 0);
            this.panel6.Controls.SetChildIndex(this.TXTPeriodName, 0);
            this.panel6.Controls.SetChildIndex(this.label2, 0);
            this.panel6.Controls.SetChildIndex(this.ComboStatus, 0);
            this.panel6.Controls.SetChildIndex(this.ErrorPeriod, 0);
            this.panel6.Controls.SetChildIndex(this.ErrorStatus, 0);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(933, 597);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox2);
            this.panel5.Size = new System.Drawing.Size(933, 557);
            this.panel5.Controls.SetChildIndex(this.panel7, 0);
            this.panel5.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(933, 40);
            // 
            // ErrorStatus
            // 
            this.ErrorStatus.AutoSize = true;
            this.ErrorStatus.Location = new System.Drawing.Point(211, 125);
            this.ErrorStatus.Name = "ErrorStatus";
            this.ErrorStatus.Size = new System.Drawing.Size(12, 15);
            this.ErrorStatus.TabIndex = 22;
            this.ErrorStatus.Text = "*";
            this.ErrorStatus.Visible = false;
            // 
            // ErrorPeriod
            // 
            this.ErrorPeriod.AutoSize = true;
            this.ErrorPeriod.Location = new System.Drawing.Point(211, 81);
            this.ErrorPeriod.Name = "ErrorPeriod";
            this.ErrorPeriod.Size = new System.Drawing.Size(12, 15);
            this.ErrorPeriod.TabIndex = 21;
            this.ErrorPeriod.Text = "*";
            this.ErrorPeriod.Visible = false;
            // 
            // ComboStatus
            // 
            this.ComboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboStatus.Enabled = false;
            this.ComboStatus.FormattingEnabled = true;
            this.ComboStatus.Items.AddRange(new object[] {
            "ACTIVE",
            "IN-ACTIVE"});
            this.ComboStatus.Location = new System.Drawing.Point(12, 143);
            this.ComboStatus.Name = "ComboStatus";
            this.ComboStatus.Size = new System.Drawing.Size(211, 23);
            this.ComboStatus.TabIndex = 19;
            this.ComboStatus.SelectedIndexChanged += new System.EventHandler(this.ComboStatus_SelectedIndexChanged);
            // 
            // TXTPeriodName
            // 
            this.TXTPeriodName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTPeriodName.Enabled = false;
            this.TXTPeriodName.Location = new System.Drawing.Point(12, 99);
            this.TXTPeriodName.Name = "TXTPeriodName";
            this.TXTPeriodName.Size = new System.Drawing.Size(211, 23);
            this.TXTPeriodName.TabIndex = 20;
            this.TXTPeriodName.TextChanged += new System.EventHandler(this.TXTPeriodName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "PERIOD NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "STATUS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(933, 506);
            this.groupBox2.TabIndex = 2;
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
            this.GVPeriodID,
            this.GVPeriodName,
            this.GvStatus});
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
            this.dataGridView1.Size = new System.Drawing.Size(927, 484);
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
            // GVPeriodID
            // 
            this.GVPeriodID.HeaderText = "PERIOD ID";
            this.GVPeriodID.Name = "GVPeriodID";
            this.GVPeriodID.ReadOnly = true;
            this.GVPeriodID.Visible = false;
            // 
            // GVPeriodName
            // 
            this.GVPeriodName.HeaderText = "PERIOD NAME";
            this.GVPeriodName.Name = "GVPeriodName";
            this.GVPeriodName.ReadOnly = true;
            // 
            // GvStatus
            // 
            this.GvStatus.HeaderText = "STATUS";
            this.GvStatus.Name = "GvStatus";
            this.GvStatus.ReadOnly = true;
            // 
            // PERIOD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 597);
            this.Name = "PERIOD";
            this.Text = "PERIOD";
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

        private System.Windows.Forms.Label ErrorStatus;
        private System.Windows.Forms.Label ErrorPeriod;
        private System.Windows.Forms.ComboBox ComboStatus;
        private System.Windows.Forms.TextBox TXTPeriodName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SnoGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn GVPeriodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GVPeriodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GvStatus;
    }
}