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
    public class ExpalnParkClass
    {
        public static SqlConnection cnn = new SqlConnection(CSharp.PublicFunction.cnstr());
        public static int insert(ClExpalnPark c )

        {

            SqlCommand cmd = new SqlCommand("PRC_ExpalnPark_Insert", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

      
       cmd.Parameters.Add(new SqlParameter("ParkID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.ParkID);
cmd.Parameters.Add(new SqlParameter("ExplainID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.ExplainID);
cmd.Parameters.Add(new SqlParameter("UnitNumber", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.UnitNumber);
cmd.Parameters.Add(new SqlParameter("AgreementID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.AgreementID);


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
        public static DataSet GetList(ClExpalnPark c)
        {

            SqlCommand cmd = new SqlCommand("PRC_ExpalnPark_GetList", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
            cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

             cmd.Parameters.Add(new SqlParameter("ExpalnParkID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ExpalnParkID);
cmd.Parameters.Add(new SqlParameter("ParkID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ParkID);
cmd.Parameters.Add(new SqlParameter("ExplainID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ExplainID);
cmd.Parameters.Add(new SqlParameter("UnitNumber", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.UnitNumber);
cmd.Parameters.Add(new SqlParameter("AgreementID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreementID);


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
        public static int Update(ClExpalnPark c)
        {

            SqlCommand cmd = new SqlCommand("PRC_ExpalnPark_Update", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

	cmd.Parameters.Add(new SqlParameter("ExpalnParkID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ExpalnParkID);
cmd.Parameters.Add(new SqlParameter("ParkID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ParkID);
cmd.Parameters.Add(new SqlParameter("ExplainID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ExplainID);
cmd.Parameters.Add(new SqlParameter("UnitNumber", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.UnitNumber);
cmd.Parameters.Add(new SqlParameter("AgreementID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreementID);


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
        public static int Delete(string  ExpalnParkID)
        {

            SqlCommand cmd = new SqlCommand("PRC_ExpalnPark_Delete", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

   	cmd.Parameters.Add(new SqlParameter("ExpalnParkID", SqlDbType.Int)).Value =ExpalnParkID ;
 
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

