using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class ASSIGNMENT : SchoolManagementSystem.Sample2
    {
        public ASSIGNMENT()
        {
            InitializeComponent();
        }
        int edit = 0;
        int ID;
        public override void AddBTN_Click(object sender, EventArgs e)
        {
            edit = 0;
            MainClass.Enable_Reset(panel6);
        }

        public override void EditBTN_Click(object sender, EventArgs e)
        {
            MainClass.Enable(panel6);
        }

        public override void SaveBTN_Click(object sender, EventArgs e)
        {
            if (edit == 0)
            { //FOR INSRTION

                Insertion.SHIFT(TXTShiftName.Text, TXTShiftFrom.Text, TXTShiftTo.Text);

            }
            if (edit == 1)
            { //FOR EDITION

                Updation.SHIFT(ID,TXTShiftName.Text, TXTShiftFrom.Text, TXTShiftTo.Text);

            }
            Retrieval.SHIFT(dataGridView1, GVShiftID, GVShiftName, GVFrom, GvTo);
            MainClass.Disable_Reset(panel6);
        }

        public override void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                Deletion.SHIFT(ID);
                Retrieval.SHIFT(dataGridView1, GVShiftID, GVShiftName, GVFrom, GvTo);
            }
        }

        public override void ViewBTN_Click(object sender, EventArgs e)
        {
            Retrieval.SHIFT(dataGridView1, GVShiftID, GVShiftName, GVFrom, GvTo);
        }

        public override void SearchTXT_TextChanged(object sender, EventArgs e)
        {
            if (SearchTXT.Text != "")
            {
                Retrieval.SHIFT(dataGridView1, GVShiftID, GVShiftName, GVFrom,GvTo, SearchTXT.Text);
            }
            else
            {
                Retrieval.SHIFT(dataGridView1, GVShiftID, GVShiftName, GVFrom, GvTo);
            }
        }

        private void TXTShiftName_TextChanged(object sender, EventArgs e)
        {
            if (TXTShiftName.Text == "") { ErrorShiftName.Visible = true; } else { ErrorShiftName.Visible = false; }
        }

        private void TXTShiftFrom_ValueChanged(object sender, EventArgs e)
        {
            if (TXTShiftFrom.Text == "") { ErrorShiftFrom.Visible = true; } else { ErrorShiftFrom.Visible = false; }
        }

        private void TXTShiftTo_ValueChanged(object sender, EventArgs e)
        {
            if (TXTShiftTo.Text == "") { ErrorShiftTo.Visible = true; } else { ErrorShiftTo.Visible = false; }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                ID = Convert.ToInt32(row.Cells["GVShiftID"].Value.ToString());
                TXTShiftName.Text = row.Cells["GVShiftName"].Value.ToString();
                TXTShiftFrom.Text=row.Cells["GVFrom"].Value.ToString();
                TXTShiftTo.Text = row.Cells["GvTo"].Value.ToString();
                MainClass.Disable(panel6);
                edit = 1;

            }
        }
    }
}
