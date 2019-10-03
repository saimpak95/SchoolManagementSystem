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
    class Retrieval
    {
        public static void ROLE(DataGridView gv,DataGridViewColumn id,DataGridViewColumn name,DataGridViewColumn status ,string data=null)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                if (data == null)
                { cmd = new SqlCommand("SP_ROLES_VIEW", MainClass.con); }
                else
                {
                    cmd = new SqlCommand("SP_ROLES_VIEW_LIKE", MainClass.con);
                    cmd.Parameters.AddWithValue("@DataItem", data);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                id.DataPropertyName = dt.Columns["ID"].ToString();
                name.DataPropertyName = dt.Columns["NAME"].ToString();
                status.DataPropertyName = dt.Columns["STATUS"].ToString();
                gv.DataSource = dt ;
            }
            catch (Exception ex) {
            
                MainClass.ShowMessage(ex.ToString(), "ERROR", "Error");
            }
        }

        public static void LEVELS(DataGridView gv, DataGridViewColumn id, DataGridViewColumn name, string data = null)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                if (data == null)
                { cmd = new SqlCommand("SP_LEVEL_VIEW", MainClass.con); }
                else
                {
                    cmd = new SqlCommand("SP_LEVEL_VIEW_LIKE", MainClass.con);
                    cmd.Parameters.AddWithValue("@DataItem", data);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                id.DataPropertyName = dt.Columns["ID"].ToString();
                name.DataPropertyName = dt.Columns["LEVEL"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
         
                MainClass.ShowMessage(ex.ToString(), "ERROR", "Error");
            }
        }

        public static void SECTION(DataGridView gv, DataGridViewColumn id, DataGridViewColumn name, DataGridViewColumn status, string data = null)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                if (data == null)
                { cmd = new SqlCommand("SP_SECTION_VIEW", MainClass.con); }
                else
                {
                    cmd = new SqlCommand("SP_SECTION_VIEW_LIKE", MainClass.con);
                    cmd.Parameters.AddWithValue("@DataItem", data);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                id.DataPropertyName = dt.Columns["ID"].ToString();
                name.DataPropertyName = dt.Columns["NAME"].ToString();
                status.DataPropertyName = dt.Columns["STATUS"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
               
                MainClass.ShowMessage(ex.ToString(), "ERROR", "Error");
            }
        }

        public static void CLASSES(DataGridView gv, DataGridViewColumn id, DataGridViewColumn name, DataGridViewColumn levels, DataGridViewColumn status, string data = null)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                if (data == null)
                { cmd = new SqlCommand("SP_CLASS_VIEW", MainClass.con); }
                else
                {
                    cmd = new SqlCommand("SP_CLASS_VIEW_LIKE", MainClass.con);
                    cmd.Parameters.AddWithValue("@DataItem", data);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                id.DataPropertyName = dt.Columns["ID"].ToString();
                name.DataPropertyName = dt.Columns["NAME"].ToString();
                levels.DataPropertyName = dt.Columns["LEVEL"].ToString();
                status.DataPropertyName = dt.Columns["STATUS"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {

                MainClass.ShowMessage(ex.ToString(), "ERROR", "Error");
            }
        }

        public static void HOUSE(DataGridView gv, DataGridViewColumn id, DataGridViewColumn name, DataGridViewColumn status, string data = null)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                if (data == null)
                { cmd = new SqlCommand("SP_HOUSE_VIEW", MainClass.con); }
                else
                {
                    cmd = new SqlCommand("SP_HOUSE_VIEW_LIKE", MainClass.con);
                    cmd.Parameters.AddWithValue("@DataItem", data);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                id.DataPropertyName = dt.Columns["ID"].ToString();
                name.DataPropertyName = dt.Columns["NAME"].ToString();
                status.DataPropertyName = dt.Columns["STATUS"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {

                MainClass.ShowMessage(ex.ToString(), "ERROR", "Error");
            }
        }

        public static void PERIOD(DataGridView gv, DataGridViewColumn id, DataGridViewColumn name, DataGridViewColumn status, string data = null)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                if (data == null)
                { cmd = new SqlCommand("SP_PERIOD_VIEW", MainClass.con); }
                else
                {
                    cmd = new SqlCommand("SP_PERIOD_VIEW_LIKE", MainClass.con);
                    cmd.Parameters.AddWithValue("@DataItem", data);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                id.DataPropertyName = dt.Columns["ID"].ToString();
                name.DataPropertyName = dt.Columns["NAME"].ToString();
                status.DataPropertyName = dt.Columns["STATUS"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {

                MainClass.ShowMessage(ex.ToString(), "ERROR", "Error");
            }
        }

        public static void SUBJECT(DataGridView gv, DataGridViewColumn id, DataGridViewColumn name, string data = null)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                if (data == null)
                { cmd = new SqlCommand("SP_SUBJECT_VIEW", MainClass.con); }
                else
                {
                    cmd = new SqlCommand("SP_SUBJECT_VIEW_LIKE", MainClass.con);
                    cmd.Parameters.AddWithValue("@DataItem", data);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                id.DataPropertyName = dt.Columns["ID"].ToString();
                name.DataPropertyName = dt.Columns["SUBJECT"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {

                MainClass.ShowMessage(ex.ToString(), "ERROR", "Error");
            }
        }
    }
}
