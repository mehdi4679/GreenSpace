using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace GreenSpace.CityZen
{
    public class kartable
    {
        public static SqlConnection cnn = new SqlConnection(CSharp.PublicFunction.cnstr());
        public static int Insert(string LicenseID, string ReciverRolID, DateTime DateErjae, string UserErjae, string SendRolID, string sendUserID,
            string Descr, string status, string cuttingID)
        {
            int i = 0;
            try
            {

                SqlCommand cmd = new SqlCommand("PRC_Kartable_Insert", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
                cmd.Parameters.AddWithValue("@ReciverRolID", ReciverRolID);
                cmd.Parameters.AddWithValue("@DateErjae", DateErjae);
                cmd.Parameters.AddWithValue("@UserErjae", UserErjae);
                cmd.Parameters.AddWithValue("@SendRolID", SendRolID);
                cmd.Parameters.AddWithValue("@sendUserID", sendUserID);
                cmd.Parameters.AddWithValue("@Descr", Descr);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@cuttingID", cuttingID);
                cnn.Open();
                i = Convert.ToInt32(cmd.ExecuteScalar());
                cnn.Close();
            }
            catch (Exception ex) { }
            finally { cnn.Close(); }

            return i;
        }

        public static int update(string kartableid,string LicenseID, string ReciverRolID, string  DateErjae, string UserErjae, string SendRolID, string sendUserID,
            string Descr, string status, string cuttingID)
        {
            int i = 0;
            try
            {

                SqlCommand cmd = new SqlCommand("PRC_Kartable_update", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@kartableid", kartableid);
                cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
                cmd.Parameters.AddWithValue("@ReciverRolID", ReciverRolID);
                cmd.Parameters.AddWithValue("@DateErjae", DateErjae);
                cmd.Parameters.AddWithValue("@UserErjae", UserErjae);
                cmd.Parameters.AddWithValue("@SendRolID", SendRolID);
                cmd.Parameters.AddWithValue("@sendUserID", sendUserID);
                cmd.Parameters.AddWithValue("@Descr", Descr);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@cuttingID", cuttingID);
                cnn.Open();
                i = Convert.ToInt32(cmd.ExecuteScalar());
                cnn.Close();
            }
            catch (Exception ex) { }
            finally { cnn.Close(); }
            return i;
        }



        public static DataSet Select(string cuttingID, string UserID,string ReciverRolID)
        {
            
            SqlCommand cmd = new SqlCommand("PRC_Kartable_Select", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cuttingID", cuttingID);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            cmd.Parameters.AddWithValue("@ReciverRolID", ReciverRolID);
            
            DataSet ds = new DataSet();
            SqlDataAdapter AD = new SqlDataAdapter(cmd);
            cnn.Open();
            AD.Fill(ds);
            cnn.Close();
            return ds;

        }

        public static DataSet SelectAll(string UserID=null)
        {

            SqlCommand cmd = new SqlCommand("PRC_Kartable_SelectAll", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@cuttingID", cuttingID);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            //cmd.Parameters.AddWithValue("@ReciverRolID", ReciverRolID);

            DataSet ds = new DataSet();
            SqlDataAdapter AD = new SqlDataAdapter(cmd);
            cnn.Open();
            AD.Fill(ds);
            cnn.Close();
            return ds;

        }
        public static DataSet SelectHistory(string cuttingID,string UserErjae)
    {

        SqlCommand cmd = new SqlCommand("PRC_Kartable_SelectHistory", cnn);
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@cuttingID", cuttingID);
        cmd.Parameters.AddWithValue("@UserErjae", UserErjae);

            DataSet ds = new DataSet();
        SqlDataAdapter AD = new SqlDataAdapter(cmd);
        cnn.Open();
        AD.Fill(ds);
        cnn.Close();
        return ds;

    }
}
}