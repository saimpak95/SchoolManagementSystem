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
    public partial class Sample2 : Sample
    {
        public Sample2()
        {
            InitializeComponent();
        }

        public virtual void AddBTN_Click(object sender, EventArgs e)
        {

        }

        public virtual void EditBTN_Click(object sender, EventArgs e)
        {

        }

        public virtual void SaveBTN_Click(object sender, EventArgs e)
        {

        }

        public virtual void DeleteBTN_Click(object sender, EventArgs e)
        {

        }

        public virtual void ViewBTN_Click(object sender, EventArgs e)
        {

        }

        public virtual void SearchTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }
    }
}
