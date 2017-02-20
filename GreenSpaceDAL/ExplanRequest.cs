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
    public class ExplanRequestClass
    {
        public static SqlConnection cnn = new SqlConnection(CSharp.PublicFunction.cnstr());
        public static int insert(ClExplanRequest c)
        {

            SqlCommand cmd = new SqlCommand("PRC_ExplanRequest_Insert", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
            cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


            cmd.Parameters.Add(new SqlParameter("ExplanID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ExplanID);
            cmd.Parameters.Add(new SqlParameter("FromDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.FromDate);
            cmd.Parameters.Add(new SqlParameter("ToDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.ToDate);
            cmd.Parameters.Add(new SqlParameter("IsOK", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.IsOK);
            cmd.Parameters.Add(new SqlParameter("ForUserID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ForUserID);
            cmd.Parameters.Add(new SqlParameter("RegDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.RegDate);
            cmd.Parameters.Add(new SqlParameter("ByUserID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ByUserID);
            cmd.Parameters.Add(new SqlParameter("SYSOKDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.SYSOKDate);
            cmd.Parameters.Add(new SqlParameter("ForAgreementID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ForAgreementID);


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
        public static DataSet GetList(ClExplanRequest c)
        {

            SqlCommand cmd = new SqlCommand("PRC_ExplanRequest_GetList", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
            cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

            cmd.Parameters.Add(new SqlParameter("ExplanRequestOpenID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ExplanRequestOpenID);
            cmd.Parameters.Add(new SqlParameter("FromDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.FromDate);
            cmd.Parameters.Add(new SqlParameter("ToDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.ToDate);
            cmd.Parameters.Add(new SqlParameter("IsOK", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.IsOK);
            cmd.Parameters.Add(new SqlParameter("ForUserID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ForUserID);
            cmd.Parameters.Add(new SqlParameter("RegDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.RegDate);
            cmd.Parameters.Add(new SqlParameter("ByUserID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ByUserID);
            cmd.Parameters.Add(new SqlParameter("SYSOKDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.SYSOKDate);
            cmd.Parameters.Add(new SqlParameter("ForAgreementID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ForAgreementID);


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
        public static int Update(ClExplanRequest c)
        {

            SqlCommand cmd = new SqlCommand("PRC_ExplanRequest_Update", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
            cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

            cmd.Parameters.Add(new SqlParameter("ExplanRequestOpenID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ExplanRequestOpenID);
            cmd.Parameters.Add(new SqlParameter("FromDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.FromDate);
            cmd.Parameters.Add(new SqlParameter("ToDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.ToDate);
            cmd.Parameters.Add(new SqlParameter("IsOK", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.IsOK);
            cmd.Parameters.Add(new SqlParameter("ForUserID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ForUserID);
            cmd.Parameters.Add(new SqlParameter("RegDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.RegDate);
            cmd.Parameters.Add(new SqlParameter("ByUserID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ByUserID);
            cmd.Parameters.Add(new SqlParameter("SYSOKDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.SYSOKDate);
            cmd.Parameters.Add(new SqlParameter("ForAgreementID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ForAgreementID);
            cmd.Parameters.Add(new SqlParameter("ExplanID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ExplanID);


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
        public static int Delete(string ExplanRequestOpenID)
        {

            SqlCommand cmd = new SqlCommand("PRC_ExplanRequest_Delete", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
            cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

            cmd.Parameters.Add(new SqlParameter("ExplanRequestOpenID", SqlDbType.Int)).Value = ExplanRequestOpenID;

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

