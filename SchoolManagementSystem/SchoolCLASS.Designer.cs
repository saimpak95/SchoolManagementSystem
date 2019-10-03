namespace SchoolManagementSystem
{
    partial class SchoolCLASS
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
            this.TXTClassName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboLevel = new System.Windows.Forms.ComboBox();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ErrorClassName = new System.Windows.Forms.Label();
            this.ErrorLevel = new System.Windows.Forms.Label();
            this.ErrorStatus = new System.Windows.Forms.Label();
            this.SnoGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GVClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GVClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GVClassLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GvClassStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel7.Size = new System.Drawing.Size(893, 51);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(234, 595);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.ErrorStatus);
            this.panel6.Controls.Add(this.ErrorLevel);
            this.panel6.Controls.Add(this.ErrorClassName);
            this.panel6.Controls.Add(this.comboStatus);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.comboLevel);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.TXTClassName);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Size = new System.Drawing.Size(234, 555);
            this.panel6.Controls.SetChildIndex(this.label1, 0);
            this.panel6.Controls.SetChildIndex(this.TXTClassName, 0);
            this.panel6.Controls.SetChildIndex(this.label2, 0);
            this.panel6.Controls.SetChildIndex(this.comboLevel, 0);
            this.panel6.Controls.SetChildIndex(this.label3, 0);
            this.panel6.Controls.SetChildIndex(this.comboStatus, 0);
            this.panel6.Controls.SetChildIndex(this.ErrorClassName, 0);
            this.panel6.Controls.SetChildIndex(this.ErrorLevel, 0);
            this.panel6.Controls.SetChildIndex(this.ErrorStatus, 0);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(893, 595);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox2);
            this.panel5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel5.Size = new System.Drawing.Size(893, 555);
            this.panel5.Controls.SetChildIndex(this.panel7, 0);
            this.panel5.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(893, 40);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "CLASS NAME";
            // 
            // TXTClassName
            // 
            this.TXTClassName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTClassName.Enabled = false;
            this.TXTClassName.Location = new System.Drawing.Point(5, 94);
            this.TXTClassName.Name = "TXTClassName";
            this.TXTClassName.Size = new System.Drawing.Size(223, 23);
            this.TXTClassName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "LEVEL";
            // 
            // comboLevel
            // 
            this.comboLevel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.comboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLevel.Enabled = false;
            this.comboLevel.FormattingEnabled = true;
            this.comboLevel.Location = new System.Drawing.Point(6, 139);
            this.comboLevel.Name = "comboLevel";
            this.comboLevel.Size = new System.Drawing.Size(222, 23);
            this.comboLevel.TabIndex = 4;
            this.comboLevel.Click += new System.EventHandler(this.comboLevel_Click);
            // 
            // comboStatus
            // 
            this.comboStatus.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.comboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStatus.Enabled = false;
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "ACTIVE",
            "IN-ACTIVE"});
            this.comboStatus.Location = new System.Drawing.Point(6, 183);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(222, 23);
            this.comboStatus.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "STATUS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(893, 504);
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
            this.GVClassID,
            this.GVClassName,
            this.GVClassLevel,
            this.GvClassStatus});
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
            this.dataGridView1.Size = new System.Drawing.Size(887, 482);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ErrorClassName
            // 
            this.ErrorClassName.AutoSize = true;
            this.ErrorClassName.Location = new System.Drawing.Point(216, 76);
            this.ErrorClassName.Name = "ErrorClassName";
            this.ErrorClassName.Size = new System.Drawing.Size(12, 15);
            this.ErrorClassName.TabIndex = 7;
            this.ErrorClassName.Text = "*";
            this.ErrorClassName.Visible = false;
            // 
            // ErrorLevel
            // 
            this.ErrorLevel.AutoSize = true;
            this.ErrorLevel.Location = new System.Drawing.Point(216, 121);
            this.ErrorLevel.Name = "ErrorLevel";
            this.ErrorLevel.Size = new System.Drawing.Size(12, 15);
            this.ErrorLevel.TabIndex = 8;
            this.ErrorLevel.Text = "*";
            this.ErrorLevel.Visible = false;
            // 
            // ErrorStatus
            // 
            this.ErrorStatus.AutoSize = true;
            this.ErrorStatus.Location = new System.Drawing.Point(216, 165);
            this.ErrorStatus.Name = "ErrorStatus";
            this.ErrorStatus.Size = new System.Drawing.Size(12, 15);
            this.ErrorStatus.TabIndex = 9;
            this.ErrorStatus.Text = "*";
            this.ErrorStatus.Visible = false;
            // 
            // SnoGv
            // 
            this.SnoGv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SnoGv.HeaderText = "SNO";
            this.SnoGv.Name = "SnoGv";
            this.SnoGv.ReadOnly = true;
            this.SnoGv.Width = 56;
            // 
            // GVClassID
            // 
            this.GVClassID.HeaderText = "ID";
            this.GVClassID.Name = "GVClassID";
            this.GVClassID.ReadOnly = true;
            this.GVClassID.Visible = false;
            // 
            // GVClassName
            // 
            this.GVClassName.HeaderText = "CLASS";
            this.GVClassName.Name = "GVClassName";
            this.GVClassName.ReadOnly = true;
            // 
            // GVClassLevel
            // 
            this.GVClassLevel.HeaderText = "LEVEL";
            this.GVClassLevel.Name = "GVClassLevel";
            this.GVClassLevel.ReadOnly = true;
            // 
            // GvClassStatus
            // 
            this.GvClassStatus.HeaderText = "STATUS";
            this.GvClassStatus.Name = "GvClassStatus";
            this.GvClassStatus.ReadOnly = true;
            // 
            // SchoolCLASS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 595);
            this.Name = "SchoolCLASS";
            this.Text = "SchoolCLASS";
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTClassName;
        private System.Windows.Forms.Label ErrorStatus;
        private System.Windows.Forms.Label ErrorLevel;
        private System.Windows.Forms.Label ErrorClassName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SnoGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn GVClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GVClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GVClassLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn GvClassStatus;
    }
}