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
    public partial class SECTION :Sample2
    {
        public SECTION()
        {
            InitializeComponent();
        }
        int edit = 0;
        int SectionID;
        private void TXTSectionName_TextChanged(object sender, EventArgs e)
        {
            if (TXTSectionName.Text == "") { ErrorSection.Visible = true; } else { ErrorSection.Visible = false; }
        }

        private void ComboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboStatus.SelectedIndex == -1) { ErrorStatus.Visible = true; } else { ErrorStatus.Visible = false; }
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
                Insertion.SECTION(TXTSectionName.Text, ComboStatus.SelectedItem.ToString());
            }
            if (edit == 1) {
                Updation.SECTION(SectionID, TXTSectionName.Text, ComboStatus.SelectedItem.ToString());
            }
            Retrieval.SECTION(dataGridView1, GVSectionID, GVSectionName, GvSectionStatus);
        }

        public override void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (edit == 1)
                Deletion.SECTION(SectionID);
            Retrieval.SECTION(dataGridView1, GVSectionID, GVSectionName, GvSectionStatus);
        }

        public override void ViewBTN_Click(object sender, EventArgs e)
        {
            Retrieval.SECTION(dataGridView1, GVSectionID, GVSectionName, GvSectionStatus);
        }

        public override void SearchTXT_TextChanged(object sender, EventArgs e)
        {
            if(SearchTXT.Text!="")
                Retrieval.SECTION(dataGridView1, GVSectionID, GVSectionName, GvSectionStatus,SearchTXT.Text);
            else
                Retrieval.SECTION(dataGridView1, GVSectionID, GVSectionName, GvSectionStatus);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row= dataGridView1.Rows[e.RowIndex];
                SectionID =Convert.ToInt32(row.Cells["GVSectionID"].Value.ToString());
                TXTSectionName.Text = row.Cells["GVSectionName"].Value.ToString();
                ComboStatus.SelectedItem= row.Cells["GvSectionStatus"].Value.ToString();
                edit = 1;
                MainClass.Disable(panel6);
            }
        }
    }
}
