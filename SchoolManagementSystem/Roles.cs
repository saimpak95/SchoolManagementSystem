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
    public partial class Roles : Sample2
    {
        int RoleID = 0;
        int edit = 0;
        public Roles()
        {
            InitializeComponent();
        }

        private void RoleTXT_TextChanged(object sender, EventArgs e)
        {
            if (RoleTXT.Text == "") { RoleError.Visible = true; } else { RoleError.Visible = false; }
        }

        private void RoleStatusCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RoleStatusCombo.SelectedIndex == -1) { RoleStatusError.Visible = true; } else {  RoleStatusError.Visible = false; } 
        }
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
            if (edit == 0) { //FOR INSRTION

                Insertion.ROLES(RoleTXT.Text, RoleStatusCombo.SelectedItem.ToString());
            
            }
            if (edit == 1) { //FOR EDITION

                Updation.ROLE(RoleID, RoleTXT.Text, RoleStatusCombo.SelectedItem.ToString());
            
            }
            Retrieval.ROLE(dataGridView1, GVRoleID, GVRoleName, GvRoleStatus);
        }

        public override void DeleteBTN_Click(object sender, EventArgs e)
        {
            Deletion.ROLE(RoleID);
            Retrieval.ROLE(dataGridView1, GVRoleID, GVRoleName, GvRoleStatus);
        }

        public override void ViewBTN_Click(object sender, EventArgs e)
        {
            Retrieval.ROLE(dataGridView1, GVRoleID, GVRoleName, GvRoleStatus);
        }

        public override void SearchTXT_TextChanged(object sender, EventArgs e)
        {
            if (SearchTXT.Text != "")
            {
                Retrieval.ROLE(dataGridView1, GVRoleID, GVRoleName, GvRoleStatus, SearchTXT.Text);
            }
            else {
                Retrieval.ROLE(dataGridView1, GVRoleID, GVRoleName, GvRoleStatus);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                RoleID = Convert.ToInt32(row.Cells["GVRoleID"].Value.ToString());
                RoleTXT.Text = row.Cells["GVRoleName"].Value.ToString();
                RoleStatusCombo.SelectedItem= row.Cells["GvRoleStatus"].Value.ToString();
                MainClass.Disable(panel6);
                edit = 1;
            
            }

        }
    }
}
