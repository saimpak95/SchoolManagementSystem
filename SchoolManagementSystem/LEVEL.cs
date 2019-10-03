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
    public partial class LEVEL : Sample2
    {
        public LEVEL()
        {
            InitializeComponent();
        }
        int edit = 0;
        int LevelID;
        private void TXTLevelName_TextChanged(object sender, EventArgs e)
        {
            if (TXTLevelName.Text == "") { ErrorLevelName.Visible = true; } else { ErrorLevelName.Visible = false; }
        }


        public override void AddBTN_Click(object sender, EventArgs e)
        {
            MainClass.Enable_Reset(panel6);
            edit = 0;
        }

        public override void EditBTN_Click(object sender, EventArgs e)
        {
            MainClass.Enable(panel6);
        }

        public override void SaveBTN_Click(object sender, EventArgs e)
        {

            if (edit == 0)
            {
                Insertion.LEVELS(TXTLevelName.Text);
            }
            if (edit == 1)
            {
                Updation.LEVELS(LevelID, TXTLevelName.Text);
            }
            Retrieval.LEVELS(dataGridView1, GVLevelID, GVLevelName);
            MainClass.Disable_Reset(panel6);
        }

        public override void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (edit == 1) {
                Deletion.LEVELS(LevelID);
            }
            Retrieval.LEVELS(dataGridView1, GVLevelID, GVLevelName);
            MainClass.Disable_Reset(panel6);
        }

        public override void ViewBTN_Click(object sender, EventArgs e)
        {
            Retrieval.LEVELS(dataGridView1, GVLevelID, GVLevelName);
        }

        public override void SearchTXT_TextChanged(object sender, EventArgs e)
        {
            if (SearchTXT.Text != "")
            {
                Retrieval.LEVELS(dataGridView1, GVLevelID, GVLevelName,SearchTXT.Text);
            }
            else
                Retrieval.LEVELS(dataGridView1, GVLevelID, GVLevelName);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                LevelID = Convert.ToInt32(row.Cells["GVLevelID"].Value.ToString());
                TXTLevelName.Text = row.Cells["GVLevelName"].Value.ToString();
                MainClass.Disable(panel6);
                edit = 1;
            }
        }
    }
}