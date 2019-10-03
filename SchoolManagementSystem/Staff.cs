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
    public partial class Staff : Sample2
    {
        public Staff()
        {
            InitializeComponent();
        }
        int edit = 0;
        public override void AddBTN_Click(object sender, EventArgs e)
        {
            MainClass.Enable_Reset(panel6);
            pictureBox1.Enabled = false;
            edit = 0;
        }

        public override void EditBTN_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.Enable(panel6);
            pictureBox1.Enabled = false;
        }

        public override void SaveBTN_Click(object sender, EventArgs e)
        {
            if (NameTXT.Text == "") { ErrorName.Visible = true; } else { ErrorName.Visible = false; }
            if (UsernameTXT.Text == "") { ErrorUserName.Visible = true; } else { ErrorUserName.Visible = false; }
            if (PasswordTXT.Text == "") { ErrorPassword.Visible = true; } else { ErrorPassword.Visible = false; }
            if (ConPasswordTXT.Text == "") { ErrorConPassword.Visible = true; } else { ErrorConPassword.Visible = false; }
            if (PasswordTXT.Text != ConPasswordTXT.Text) { ErrorConPassword.Visible = true; } else { ErrorConPassword.Visible = false; }
            if (Phone1TXT.Text == "") { ErrorPhone.Visible = true; } else { ErrorPhone.Visible = false; }
            if (StaffRoleCombo.SelectedIndex == -1) { ErrorStaffRole.Visible = true; } else { ErrorStaffRole.Visible = false; }
            if (StaffStatusCombo.SelectedIndex == -1) { ErrorStaffStatus.Visible = true; } else { ErrorStaffStatus.Visible = false; }

            if (ErrorName.Visible || ErrorUserName.Visible || ErrorPassword.Visible || ErrorConPassword.Visible || ErrorPhone.Visible || ErrorStaffRole.Visible || ErrorStaffStatus.Visible)
            {
                MainClass.ShowMessage("FILEDS WITH * ARE MANDATORY", "STOP...", "Error");
            }
            else
            {
                if (edit == 0) //CODE FOR SAVE OPERATION
                {

                }
                else //CODE FOR UPDATE OPERATION
                {

                }
            }
        }

        public override void DeleteBTN_Click(object sender, EventArgs e)
        {

        }

        public override void ViewBTN_Click(object sender, EventArgs e)
        {

        }

        public override void SearchTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameTXT_TextChanged(object sender, EventArgs e)
        {
            if (NameTXT.Text == "") { ErrorName.Visible = true; } else { ErrorName.Visible = false; }
        }

        private void UsernameTXT_TextChanged(object sender, EventArgs e)
        {
            if (UsernameTXT.Text == "") { ErrorUserName.Visible = true; } else { ErrorUserName.Visible = false; }
        }

        private void PasswordTXT_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTXT.Text == "") { ErrorPassword.Visible = true; } else { ErrorPassword.Visible = false; }

        }

        private void ConPasswordTXT_TextChanged(object sender, EventArgs e)
        {
            if (ConPasswordTXT.Text == "") { ErrorConPassword.Visible = true; } else { ErrorConPassword.Visible = false; }

        }
        private void ConPasswordTXT_Validating(object sender, EventArgs e)
        {
            if (PasswordTXT.Text != ConPasswordTXT.Text) { ErrorConPassword.Visible = true; } else { ErrorConPassword.Visible = false; }

        }

        private void Phone1TXT_TextChanged(object sender, EventArgs e)
        {
            if (Phone1TXT.Text == "") { ErrorPhone.Visible = true; } else { ErrorPhone.Visible = false; }

        }

        private void StaffRoleCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StaffRoleCombo.SelectedIndex == -1) { ErrorStaffRole.Visible = true; } else { ErrorStaffRole.Visible = false; }

        }

        private void StaffStatusCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StaffStatusCombo.SelectedIndex == -1) { ErrorStaffStatus.Visible = true; } else { ErrorStaffStatus.Visible = false; }

        }

        private void BrowseBTN_Click(object sender, EventArgs e)
        {
           DialogResult dr= openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Image i = new Bitmap(openFileDialog1.FileName);
              
                pictureBox1.Image = i;
                StaffImage.Text = openFileDialog1.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
               
            }
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            MainClass.Disable_Reset(panel6);
           
        }
    }
}
