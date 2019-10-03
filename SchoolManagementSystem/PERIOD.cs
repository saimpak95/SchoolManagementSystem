using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class PERIOD : Sample2
    {
        public PERIOD()
        {
            InitializeComponent();
        }
        int edit = 0;
        int PeriodID;
        private void TXTPeriodName_TextChanged(object sender, EventArgs e)
        {
            if (TXTPeriodName.Text=="") { ErrorPeriod.Visible = true; } else { ErrorPeriod.Visible = false; }
        }

        private void ComboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboStatus.SelectedIndex == -1) { ErrorStatus.Visible = true; } else { ErrorStatus.Visible = false; }
        }

        public override void AddBTN_Click(object sender, EventArgs e)
        {
            MainClass.Enable_Reset(panel6);
        }

        public override void EditBTN_Click(object sender, EventArgs e)
        {
            MainClass.Enable(panel6);
        }

        public override void SaveBTN_Click(object sender, EventArgs e)
        {

            if (edit == 0)
            {
                Insertion.PERIOD(TXTPeriodName.Text,ComboStatus.SelectedItem.ToString());
            }
            if (edit == 1)
            {
                Updation.PERIOD(PeriodID, TXTPeriodName.Text, ComboStatus.SelectedItem.ToString());
            }
            Retrieval.PERIOD(dataGridView1, GVPeriodID, GVPeriodName,GvStatus);
            MainClass.Disable_Reset(panel6);
        }

        public override void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                Deletion.PERIOD(PeriodID);
            }
            Retrieval.PERIOD(dataGridView1, GVPeriodID, GVPeriodName, GvStatus);
            MainClass.Disable_Reset(panel6);
        }

        public override void ViewBTN_Click(object sender, EventArgs e)
        {
            Retrieval.PERIOD(dataGridView1, GVPeriodID, GVPeriodName, GvStatus);
        }

        public override void SearchTXT_TextChanged(object sender, EventArgs e)
        {
            if (SearchTXT.Text != "")
            {
                Retrieval.PERIOD(dataGridView1, GVPeriodID, GVPeriodName, GvStatus,SearchTXT.Text);
            }
            else
                Retrieval.PERIOD(dataGridView1, GVPeriodID, GVPeriodName, GvStatus);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                PeriodID = Convert.ToInt32(row.Cells["GVPeriodID"].Value.ToString());
                TXTPeriodName.Text = row.Cells["GVPeriodName"].Value.ToString();
                ComboStatus.SelectedItem = row.Cells["GvStatus"].Value.ToString();

                edit = 1;
                MainClass.Disable(panel6);
            }
        }
    }
}
