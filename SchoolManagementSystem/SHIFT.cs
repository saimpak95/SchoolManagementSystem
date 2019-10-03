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
    public partial class SHIFT : Sample2
    {
        public SHIFT()
        {
            InitializeComponent();
        }


        int edit = 0;
        int ID = 0;
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
                Insertion.SHIFT(TXTShiftName.Text, TXTShiftFrom.Text, TXTShiftTo.Text);
            }
            if (edit == 1)
            {
                Updation.SHIFT(ID, TXTShiftName.Text, TXTShiftFrom.Text, TXTShiftTo.Text);

            }
            Retrieval.SHIFT(dataGridView1, GVShiftID, GVShiftName, GVShiftFrom, GvShiftTo);
            MainClass.Disable_Reset(panel6);
        }

        public override void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {

                Deletion.SHIFT(ID);

            }
            Retrieval.SHIFT(dataGridView1, GVShiftID, GVShiftName, GVShiftFrom, GvShiftTo);
            MainClass.Disable_Reset(panel6);
        }

        public override void ViewBTN_Click(object sender, EventArgs e)
        {
            Retrieval.SHIFT(dataGridView1, GVShiftID, GVShiftName, GVShiftFrom, GvShiftTo);
        }

        public override void SearchTXT_TextChanged(object sender, EventArgs e)
        {
            if (SearchTXT.Text != "")
            {
                Retrieval.SHIFT(dataGridView1, GVShiftID, GVShiftName, GVShiftFrom, GvShiftTo,SearchTXT.Text);
            }
            else
                Retrieval.SHIFT(dataGridView1, GVShiftID, GVShiftName, GVShiftFrom, GvShiftTo);
        }

 
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

          
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                ID = Convert.ToInt32(row.Cells["GVShiftID"].Value.ToString());
                TXTShiftName.Text = row.Cells["GVShiftName"].Value.ToString();
                TXTShiftFrom.Text = row.Cells["GVShiftFrom"].Value.ToString();
                TXTShiftTo.Text = row.Cells["GvShiftTo"].Value.ToString();
                MainClass.Disable(panel6);
                edit = 1;
            }
        }
    }
}
