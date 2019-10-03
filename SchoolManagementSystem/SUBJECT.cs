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
    public partial class SUBJECT : Sample2
    {
        public SUBJECT()
        {
            InitializeComponent();
        }
        int edit = 0;
        int SubjectID;
        private void TXTSubjectName_TextChanged(object sender, EventArgs e)
        {
            if (TXTSubjectName.Text == "") { ErrorSubject.Visible = true; } else { ErrorSubject.Visible = false; }
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
                Insertion.SUBJECT(TXTSubjectName.Text);
            }
            if (edit == 1)
            {
                Updation.SUBJECT(SubjectID, TXTSubjectName.Text);
            }
            Retrieval.SUBJECT(dataGridView1, GVSubjectID, GVSubjectName);
            MainClass.Disable_Reset(panel6);
        }

        public override void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                Deletion.SUBJECT(SubjectID);
            }
            Retrieval.SUBJECT(dataGridView1, GVSubjectID, GVSubjectName);
            MainClass.Disable_Reset(panel6);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                SubjectID = Convert.ToInt32(row.Cells["GVSubjectID"].Value.ToString());
                TXTSubjectName.Text = row.Cells["GVSubjectName"].Value.ToString();
                MainClass.Disable(panel6);
                edit = 1;
            }
        }
    

    public override void ViewBTN_Click(object sender, EventArgs e)
        {
        Retrieval.SUBJECT(dataGridView1, GVSubjectID, GVSubjectName);
    }

        public override void SearchTXT_TextChanged(object sender, EventArgs e)
        {
        if (SearchTXT.Text != "")
        {
            Retrieval.SUBJECT(dataGridView1, GVSubjectID, GVSubjectName, SearchTXT.Text);
        }
        else
            Retrieval.SUBJECT(dataGridView1, GVSubjectID, GVSubjectName);
    }

    }
}