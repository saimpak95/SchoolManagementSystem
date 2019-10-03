using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    class Deletion
    {
        public static void ROLE(int ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_ROLES_DELETE", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RoleID", ID);
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

        public static void LEVELS(int ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_LEVEL_DELETE", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LevelID", ID);
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

        public static void SECTION(int ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_SECTION_DELETE", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SectionID", ID);
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

        public static void CLASSES(int ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_CLASS_DELETE", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClassID", ID);
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

        public static void HOUSE(int ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_HOUSE_DELETE", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@HouseID", ID);
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

        public static void PERIOD(int ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_PERIOD_DELETE", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PeriodID", ID);
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

        public static void SUBJECT(int ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_SUBJECT_DELETE", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SubjectID", ID);
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


        public static void SHIFT(int ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_SHIFT_DELETE", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ShiftID", ID);
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
