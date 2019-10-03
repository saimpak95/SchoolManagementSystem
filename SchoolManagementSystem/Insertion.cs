using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    class Insertion
    {
        public static void ROLES(string name, string status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_ROLES_INSERT", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RoleName", name);
                cmd.Parameters.AddWithValue("@RoleStatus", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMessage(ex.ToString(), "ERROR", "Error");
            }
        }

        public static void LEVELS(string name)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_LEVEL_INSERT", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LevelName", name);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMessage(ex.ToString(), "ERROR", "Error");
            }
        }

        public static void SECTION(string name, string status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_SECTION_INSERT", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SectionName", name);
                cmd.Parameters.AddWithValue("@SectionStatus", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMessage(ex.ToString(), "ERROR", "Error");
            }
        }

        public static void CLASSES(string name,string levels ,string status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_CLASS_INSERT", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClassName", name);
                cmd.Parameters.AddWithValue("@ClassLevel", levels);
                cmd.Parameters.AddWithValue("@ClassStatus", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMessage(ex.ToString(), "ERROR", "Error");
            }
        }

        public static void HOUSE(string name, string status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_HOUSE_INSERT", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@HouseName", name);
                cmd.Parameters.AddWithValue("@HouseStatus", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMessage(ex.ToString(), "ERROR", "Error");
            }
        }

        public static void PERIOD(string name, string status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_PERIOD_INSERT", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PeriodName", name);
                cmd.Parameters.AddWithValue("@PeriodStatus", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMessage(ex.ToString(), "ERROR", "Error");
            }
        }

        public static void SUBJECT(string name)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_SUBJECT_INSERT", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SubjectName", name);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMessage(ex.ToString(), "ERROR", "Error");
            }
        }

        public static void SHIFT(string name, string from,string to)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_SHIFT_INSERT", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ShiftName", name);
                cmd.Parameters.AddWithValue("@StartTime", from);
                cmd.Parameters.AddWithValue("@EndTime", to);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMessage(ex.ToString(), "ERROR", "Error");
            }
        }
    }
}
