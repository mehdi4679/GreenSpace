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
    public class AgreePercentProtestClass
    {
        public static SqlConnection cnn = new SqlConnection(CSharp.PublicFunction.cnstr());
        public static int insert(ClAgreePercentProtest c )

        {

            SqlCommand cmd = new SqlCommand("PRC_AgreePercentProtest_Insert", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

      
       cmd.Parameters.Add(new SqlParameter("AgreementPercentID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.AgreementPercentID);
cmd.Parameters.Add(new SqlParameter("ProtestStatusID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.ProtestStatusID);
cmd.Parameters.Add(new SqlParameter("ProtestDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.ProtestDate);
cmd.Parameters.Add(new SqlParameter("UserResponseID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.UserResponseID);
cmd.Parameters.Add(new SqlParameter("ProtestComment", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.ProtestComment);


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
        public static DataSet GetList(ClAgreePercentProtest c)
        {

            SqlCommand cmd = new SqlCommand("PRC_AgreePercentProtest_GetList", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
            cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

             cmd.Parameters.Add(new SqlParameter("AgreePercentProtestID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreePercentProtestID);
cmd.Parameters.Add(new SqlParameter("AgreementPercentID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreementPercentID);
cmd.Parameters.Add(new SqlParameter("ProtestStatusID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ProtestStatusID);
cmd.Parameters.Add(new SqlParameter("ProtestDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.ProtestDate);
cmd.Parameters.Add(new SqlParameter("UserResponseID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.UserResponseID);
cmd.Parameters.Add(new SqlParameter("ProtestComment", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.ProtestComment);
cmd.Parameters.Add(new SqlParameter("UserResponseID2", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.UserResponseID2);


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
        public static DataSet GetListNav(ClAgreePercentProtest c)
        {

            SqlCommand cmd = new SqlCommand("PRC_AgreePercentProtest_GetListNav", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
            cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

             cmd.Parameters.Add(new SqlParameter("AgreePercentProtestID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreePercentProtestID);
cmd.Parameters.Add(new SqlParameter("AgreementPercentID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreementPercentID);
cmd.Parameters.Add(new SqlParameter("ProtestStatusID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ProtestStatusID);
cmd.Parameters.Add(new SqlParameter("ProtestDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.ProtestDate);
cmd.Parameters.Add(new SqlParameter("UserResponseID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.UserResponseID);
cmd.Parameters.Add(new SqlParameter("ProtestComment", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.ProtestComment);
cmd.Parameters.Add(new SqlParameter("UserResponseID2", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.UserResponseID2);


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
        public static int Update(ClAgreePercentProtest c)
        {

            SqlCommand cmd = new SqlCommand("PRC_AgreePercentProtest_Update", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

	cmd.Parameters.Add(new SqlParameter("AgreePercentProtestID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreePercentProtestID);
cmd.Parameters.Add(new SqlParameter("AgreementPercentID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreementPercentID);
cmd.Parameters.Add(new SqlParameter("ProtestStatusID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ProtestStatusID);
cmd.Parameters.Add(new SqlParameter("ProtestDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.ProtestDate);
cmd.Parameters.Add(new SqlParameter("UserResponseID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.UserResponseID);
cmd.Parameters.Add(new SqlParameter("ProtestComment", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.ProtestComment);


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
        public static int Delete(string  AgreePercentProtestID)
        {

            SqlCommand cmd = new SqlCommand("PRC_AgreePercentProtest_Delete", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

   	cmd.Parameters.Add(new SqlParameter("AgreePercentProtestID", SqlDbType.Int)).Value =AgreePercentProtestID ;
 
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

