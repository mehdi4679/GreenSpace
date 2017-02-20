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
    public class AgreeStatusClass
    {
        public static SqlConnection cnn = new SqlConnection(CSharp.PublicFunction.cnstr());
        public static int insert(ClAgreeStatus c )

        {

            SqlCommand cmd = new SqlCommand("PRC_AgreeStatus_Insert", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

      
       cmd.Parameters.Add(new SqlParameter("AgreementID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.AgreementID);
cmd.Parameters.Add(new SqlParameter("StatusID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.StatusID);
cmd.Parameters.Add(new SqlParameter("StatusDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.StatusDate);
cmd.Parameters.Add(new SqlParameter("RegUser", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.RegUser);
cmd.Parameters.Add(new SqlParameter("RegDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.RegDate);
cmd.Parameters.Add(new SqlParameter("AgreeStatusComment", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.AgreeStatusComment);


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
        public static DataSet GetList(ClAgreeStatus c)
        {

            SqlCommand cmd = new SqlCommand("PRC_AgreeStatus_GetList", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
            cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

             cmd.Parameters.Add(new SqlParameter("AgreeStatus", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreeStatus);
cmd.Parameters.Add(new SqlParameter("AgreementID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreementID);
cmd.Parameters.Add(new SqlParameter("StatusID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.StatusID);
cmd.Parameters.Add(new SqlParameter("StatusDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.StatusDate);
cmd.Parameters.Add(new SqlParameter("RegUser", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.RegUser);
cmd.Parameters.Add(new SqlParameter("RegDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.RegDate);
cmd.Parameters.Add(new SqlParameter("AgreeStatusComment", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreeStatusComment);


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
        public static int Update(ClAgreeStatus c)
        {

            SqlCommand cmd = new SqlCommand("PRC_AgreeStatus_Update", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

	cmd.Parameters.Add(new SqlParameter("AgreeStatus", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreeStatus);
cmd.Parameters.Add(new SqlParameter("AgreementID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreementID);
cmd.Parameters.Add(new SqlParameter("StatusID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.StatusID);
cmd.Parameters.Add(new SqlParameter("StatusDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.StatusDate);
cmd.Parameters.Add(new SqlParameter("RegUser", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.RegUser);
cmd.Parameters.Add(new SqlParameter("RegDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.RegDate);
cmd.Parameters.Add(new SqlParameter("AgreeStatusComment", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreeStatusComment);


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
        public static int Delete(string  AgreeStatus)
        {

            SqlCommand cmd = new SqlCommand("PRC_AgreeStatus_Delete", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

   	cmd.Parameters.Add(new SqlParameter("AgreeStatus", SqlDbType.Int)).Value =AgreeStatus ;
 
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

