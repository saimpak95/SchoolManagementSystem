using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    class Updation
    {
        public static void ROLE(int id,string name, string status)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("SP_ROLES_UPDATE", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RoleID", id);
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

        public static void LEVELS(int id, string name)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("SP_LEVEL_UPDATE", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LevelID", id);
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

        public static void SECTION(int id, string name, string status)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("SP_SECTION_UPDATE", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SectionID", id);
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

        public static void CLASSES(int id, string name,string levels, string status)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("SP_CLASS_UPDATE", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClassID", id);
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


        public static void HOUSE(int id, string name, string status)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("SP_HOUSE_UPDATE", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@HouseID", id);
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

        public static void PERIOD(int id, string name, string status)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("SP_PERIOD_UPDATE", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PeriodID", id);
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

        public static void SUBJECT(int id, string name)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("SP_SUBJECT_UPDATE", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SubjectID", id);
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

    }
}
