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
    public class ParkClass
    {
        public static SqlConnection cnn = new SqlConnection(CSharp.PublicFunction.cnstr());
        public static int insert(ClPark c )

        {

            SqlCommand cmd = new SqlCommand("PRC_Park_Insert", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

      
       cmd.Parameters.Add(new SqlParameter("ParkName", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.ParkName);
cmd.Parameters.Add(new SqlParameter("ParkAdress", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.ParkAdress);
cmd.Parameters.Add(new SqlParameter("ParkArea", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.ParkArea);
cmd.Parameters.Add(new SqlParameter("ParkDistrict", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.ParkDistrict);


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
        public static DataSet GetList(ClPark c)
        {

            SqlCommand cmd = new SqlCommand("PRC_Park_GetList", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
            cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

             cmd.Parameters.Add(new SqlParameter("ParkID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ParkID==0? null:c.ParkID);
cmd.Parameters.Add(new SqlParameter("ParkName", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.ParkName);
cmd.Parameters.Add(new SqlParameter("ParkAdress", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.ParkAdress);
cmd.Parameters.Add(new SqlParameter("ParkArea", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.ParkArea);
cmd.Parameters.Add(new SqlParameter("ParkDistrict", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ParkDistrict);


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
        public static int Update(ClPark c)
        {

            SqlCommand cmd = new SqlCommand("PRC_Park_Update", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

	cmd.Parameters.Add(new SqlParameter("ParkID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ParkID);
cmd.Parameters.Add(new SqlParameter("ParkName", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.ParkName);
cmd.Parameters.Add(new SqlParameter("ParkAdress", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.ParkAdress);
cmd.Parameters.Add(new SqlParameter("ParkArea", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.ParkArea);
cmd.Parameters.Add(new SqlParameter("ParkDistrict", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ParkDistrict);


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
        public static int Delete(string  ParkID)
        {

            SqlCommand cmd = new SqlCommand("PRC_Park_Delete", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

   	cmd.Parameters.Add(new SqlParameter("ParkID", SqlDbType.Int)).Value =ParkID ;
 
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

