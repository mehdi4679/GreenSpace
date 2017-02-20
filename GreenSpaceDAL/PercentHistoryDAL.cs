using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Collections;
using System.Data.SqlClient;
using GreenSpaceCL;

namespace GreenSpaceDAL
{
    public class PercentHistoryClass
    {
        public static SqlConnection cnn = new SqlConnection(CSharp.PublicFunction.cnstr());
        public static int insert(ClPercentHistory c )

        {

            SqlCommand cmd = new SqlCommand("PRC_PercentHistory_Insert", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


        cmd.Parameters.Add(new SqlParameter("PercentNumber", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.PercentNumber);
cmd.Parameters.Add(new SqlParameter("IP", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.IP);
cmd.Parameters.Add(new SqlParameter("OS", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.OS);
cmd.Parameters.Add(new SqlParameter("DateReg", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.DateReg);
cmd.Parameters.Add(new SqlParameter("UserID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.UserID);
cmd.Parameters.Add(new SqlParameter("UnitNumber", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.UnitNumber);
cmd.Parameters.Add(new SqlParameter("DescChange", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.DescChange);
cmd.Parameters.Add(new SqlParameter("AgreementPercentID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.AgreementPercentID);


           SqlParameter prmResult = new SqlParameter("Result", SqlDbType.Int);
            prmResult.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmResult);
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                return Convert.ToInt32(prmResult.Value);
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                cnn.Close();
            }

        }

        //---------------------------------------------------------------------------------------------------------
        public static DataSet GetList(ClPercentHistory c)
        {

            SqlCommand cmd = new SqlCommand("PRC_PercentHistory_GetList", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
            cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

 
             cmd.Parameters.Add(new SqlParameter("HistoryPercentID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.HistoryPercentID);
cmd.Parameters.Add(new SqlParameter("PercentNumber", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.PercentNumber);
cmd.Parameters.Add(new SqlParameter("IP", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.IP);
cmd.Parameters.Add(new SqlParameter("OS", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.OS);
cmd.Parameters.Add(new SqlParameter("DateReg", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.DateReg);
cmd.Parameters.Add(new SqlParameter("UserID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.UserID);
cmd.Parameters.Add(new SqlParameter("UnitNumber", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.UnitNumber);
cmd.Parameters.Add(new SqlParameter("DescChange", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.DescChange);
cmd.Parameters.Add(new SqlParameter("AgreementPercentID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreementPercentID);


           SqlParameter prmResult = new SqlParameter("Result", SqlDbType.Int);
            prmResult.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmResult);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                cnn.Open();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                cnn.Close();
            }

        }

        //---------------------------------------------------------------------------------------------------------
        public static int Update(ClPercentHistory c)
        {

            SqlCommand cmd = new SqlCommand("PRC_PercentHistory_Update", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

	cmd.Parameters.Add(new SqlParameter("HistoryPercentID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.HistoryPercentID);
cmd.Parameters.Add(new SqlParameter("PercentNumber", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.PercentNumber);
cmd.Parameters.Add(new SqlParameter("IP", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.IP);
cmd.Parameters.Add(new SqlParameter("OS", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.OS);
cmd.Parameters.Add(new SqlParameter("DateReg", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.DateReg);
cmd.Parameters.Add(new SqlParameter("UserID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.UserID);
cmd.Parameters.Add(new SqlParameter("UnitNumber", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.UnitNumber);
cmd.Parameters.Add(new SqlParameter("DescChange", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.DescChange);
cmd.Parameters.Add(new SqlParameter("AgreementPercentID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreementPercentID);


            SqlParameter prmResult = new SqlParameter("Result", SqlDbType.Int);
            prmResult.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmResult);
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                return Convert.ToInt32(prmResult.Value);
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                cnn.Close();
            }

        }

        //---------------------------------------------------------------------------------------------------------
        public static int Delete(string  HistoryPercentID)
        {

            SqlCommand cmd = new SqlCommand("PRC_PercentHistory_Delete", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

   	cmd.Parameters.Add(new SqlParameter("HistoryPercentID", SqlDbType.Int)).Value =HistoryPercentID ;
 
            SqlParameter prmResult = new SqlParameter("Result", SqlDbType.Int);
            prmResult.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmResult);
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                return Convert.ToInt32(prmResult.Value);
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                cnn.Close();
            }

        }
    }

    //---------------------------------------------------------------------------------------------------------
}

