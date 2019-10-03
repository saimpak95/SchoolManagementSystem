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
    public partial class Dashboard :Sample
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void StaffBTN_Click(object sender, EventArgs e)
        {
            Staff obj = new Staff();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void RoleBTN_Click(object sender, EventArgs e)
        {
          
        }

        private void RoleBTN_Click_1(object sender, EventArgs e)
        {
            Roles obj = new Roles();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void BTNLevel_Click(object sender, EventArgs e)
        {
            LEVEL obj = new LEVEL();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void BTNSection_Click(object sender, EventArgs e)
        {
            SECTION obj = new SECTION();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void Classes_Click(object sender, EventArgs e)
        {
            // SCHOOLCLASSES obj = new SCHOOLCLASSES();
            SchoolCLASS obj = new SchoolCLASS();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTNHouse_Click(object sender, EventArgs e)
        {
            HOUSE obj = new HOUSE();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void BTNPeriod_Click(object sender, EventArgs e)
        {
            PERIOD obj = new PERIOD();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void BTNSubject_Click(object sender, EventArgs e)
        {
            SUBJECT obj = new SUBJECT();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void BTNShift_Click(object sender, EventArgs e)
        {
            SHIFT obj = new SHIFT();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);

        }
    }
}
