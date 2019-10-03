using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    class MainClass
    {
        public static SqlConnection con =new SqlConnection("Data Source=.;Initial Catalog=sms;Integrated Security=True");
        public static void ShowWindow(Form OpenWindow,Form CloseWindow,Form MDI )
        {
            CloseWindow.Close();
            OpenWindow.WindowState = FormWindowState.Maximized;
            OpenWindow.MdiParent = MDI;
            OpenWindow.Show();
        }


        public static  DialogResult ShowMessage(string msg, string head,string type)
        {
            if (type == "Success")
            {
                return MessageBox.Show(msg, head, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return MessageBox.Show(msg, head, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public static void Disable_Reset(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if(c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = false;
                    t.Text = "";
                }
                if(c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;
                    cb.SelectedIndex = -1;
                }
                if(c is CheckBox)
                {
                    CheckBox chb = (CheckBox)c;
                    chb.Enabled = false;
                    chb.Checked = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)c;
                    dt.Enabled = false;
                    dt.Value = DateTime.Now;
                }
                if(c is Button)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
        }

        public static void Disable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = false;
                    
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;
                   
                }
                if (c is CheckBox)
                {
                    CheckBox chb = (CheckBox)c;
                    chb.Enabled = false;
                   
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)c;
                    dt.Enabled = false;
                   
                }
                if (c is Button)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
        }

        public static void Enable_Reset(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = true;
                    t.Text = "";
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                    cb.SelectedIndex = -1;
                }
                if (c is CheckBox)
                {
                    CheckBox chb = (CheckBox)c;
                    chb.Enabled = true;
                    chb.Checked = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)c;
                    dt.Enabled = true;
                    dt.Value = DateTime.Now;
                }
                if (c is Button)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                }
            }
        }

        public static void Enable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = true;
                  
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                   
                }
                if (c is CheckBox)
                {
                    CheckBox chb = (CheckBox)c;
                    chb.Enabled = true;
                   
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)c;
                    dt.Enabled = true;
                   
                }
                if (c is Button)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                }
            }
        }

        public static void Enable_Reset(GroupBox gp)
        {
            foreach (Control c in gp.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = true;
                    t.Text = "";
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                    cb.SelectedIndex = -1;
                }
                if (c is CheckBox)
                {
                    CheckBox chb = (CheckBox)c;
                    chb.Enabled = true;
                    chb.Checked = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)c;
                    dt.Enabled = true;
                    dt.Value = DateTime.Now;
                }
                if (c is Button)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                }
            }
        }

        public static void GetCombo(ComboBox cb,string TableName,string ColumnName)
        {
            try { 
            SqlCommand cmd = new SqlCommand("select "+ColumnName+" from "+TableName+"",con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cb.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    cb.Items.Add(dr["" + ColumnName + ""].ToString());
                } 
            }
            catch
            {

            }
        }
    }
}
