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
    public partial class SchoolCLASS : Sample2
    {
        public SchoolCLASS()
        {
            InitializeComponent();
        }
        int edit = 0;
        int ClassID = 0;
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
            if (edit == 0) {
                Insertion.CLASSES(TXTClassName.Text, comboLevel.SelectedItem.ToString(), comboStatus.SelectedItem.ToString());
            }
            if (edit == 1)
            {
                Updation.CLASSES(ClassID, TXTClassName.Text, comboLevel.SelectedItem.ToString(), comboStatus.SelectedItem.ToString());

            }
            Retrieval.CLASSES(dataGridView1, GVClassID, GVClassName, GVClassLevel, GvClassStatus);
        }

        public override void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {

                Deletion.CLASSES(ClassID);

            }
            Retrieval.CLASSES(dataGridView1, GVClassID, GVClassName, GVClassLevel, GvClassStatus);
            MainClass.Disable_Reset(panel6);
        }

        public override void ViewBTN_Click(object sender, EventArgs e)
        {
            Retrieval.CLASSES(dataGridView1, GVClassID, GVClassName, GVClassLevel, GvClassStatus);
        }

        public override void SearchTXT_TextChanged(object sender, EventArgs e)
        {
            if (SearchTXT.Text != "")
            {
                Retrieval.CLASSES(dataGridView1, GVClassID, GVClassName, GVClassLevel, GvClassStatus,SearchTXT.Text);
            }
            else
                Retrieval.CLASSES(dataGridView1, GVClassID, GVClassName, GVClassLevel, GvClassStatus);
        }

        private void comboLevel_Click(object sender, EventArgs e)
        {
            MainClass.GetCombo(comboLevel, "SchoolLevel", "LevelName");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                comboLevel.Items.Clear();
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
               ClassID = Convert.ToInt32(row.Cells["GVClassID"].Value.ToString());
                TXTClassName.Text = row.Cells["GVClassName"].Value.ToString();
                comboLevel.Items.Add(row.Cells["GVClassLevel"].Value.ToString());
                comboStatus.SelectedItem = row.Cells["GvClassStatus"].Value.ToString();
                MainClass.Disable(panel6);
                edit = 1;
            }
        }
    }
}
