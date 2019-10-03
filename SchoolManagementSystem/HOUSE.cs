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
    public partial class HOUSE : Sample2
    {
        public HOUSE()
        {
            InitializeComponent();
        }
        int edit = 0;
        int HouseID = 0;
        private void TXTHouseName_TextChanged(object sender, EventArgs e)
        {
            if (TXTHouseName.Text == "") { ErrorHouse.Visible = true; } else { ErrorHouse.Visible = false; }
        }

        private void ComboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboStatus.SelectedIndex == -1) { ErrorStatus.Visible = true; } else { ErrorStatus.Visible = false; }
        }

        public override void AddBTN_Click(object sender, EventArgs e)
        {
            edit = 0;
            MainClass.Enable_Reset(panel6);
           
        }

        public override void EditBTN_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.Enable(panel6);
        }

        public override void SaveBTN_Click(object sender, EventArgs e)
        {
            if(edit==0)
                Insertion.HOUSE(TXTHouseName.Text, ComboStatus.SelectedItem.ToString());
            if (edit == 1)
                Updation.HOUSE(HouseID, TXTHouseName.Text, ComboStatus.SelectedItem.ToString());
            MainClass.Disable_Reset(panel6);
            Retrieval.HOUSE(dataGridView1, GVHouseID, GVHouseName, GvHouseStatus);
        }

        public override void DeleteBTN_Click(object sender, EventArgs e)
        {
            Deletion.HOUSE(HouseID);
            MainClass.Disable_Reset(panel6);
            Retrieval.HOUSE(dataGridView1, GVHouseID, GVHouseName, GvHouseStatus);
        }

        public override void ViewBTN_Click(object sender, EventArgs e)
        {
            Retrieval.HOUSE(dataGridView1, GVHouseID, GVHouseName, GvHouseStatus);
        }

        public override void SearchTXT_TextChanged(object sender, EventArgs e)
        {
            if (SearchTXT.Text != "")
            {
                Retrieval.HOUSE(dataGridView1, GVHouseID, GVHouseName, GvHouseStatus, SearchTXT.Text);
            }
            else
            {
                Retrieval.HOUSE(dataGridView1, GVHouseID, GVHouseName, GvHouseStatus);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                HouseID=Convert.ToInt32(row.Cells["GVHouseID"].Value.ToString());
                TXTHouseName.Text = row.Cells["GVHouseName"].Value.ToString();
                ComboStatus.SelectedItem= row.Cells["GvHouseStatus"].Value.ToString();
                MainClass.Disable(panel6);
            }
        }
    }
}
