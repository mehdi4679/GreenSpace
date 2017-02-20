using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Collections;
using System.Data.SqlClient;
using GreenSpaceCL;
using TaxiCL;

namespace UserRoleSpace
{
    public class UserRoleClass
    {
        public static SqlConnection cnn = new SqlConnection(CSharp.PublicFunction.cnstr());
        public static int insert(ClUserRole c )

        {

            SqlCommand cmd = new SqlCommand("PRC_UserRole_Insert", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

      
       cmd.Parameters.Add(new SqlParameter("RoleID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.RoleID);
cmd.Parameters.Add(new SqlParameter("UserID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.UserID);
cmd.Parameters.Add(new SqlParameter("CreateDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.CreateDate);
cmd.Parameters.Add(new SqlParameter("CreateUser", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.CreateUser);


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
        public static DataSet GetList(ClUserRole c)
        {

            SqlCommand cmd = new SqlCommand("PRC_UserRole_GetList", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("PageIndex", SqlDbType.NVarChar)).Value = c.PageIndex;
            cmd.Parameters.Add(new SqlParameter("PageSize", SqlDbType.NVarChar)).Value = c.PageSize;
            cmd.Parameters.Add(new SqlParameter("Order", SqlDbType.NVarChar)).Value = c.OrderDirection;
            cmd.Parameters.Add(new SqlParameter("OrderBy", SqlDbType.NVarChar)).Value = c.OrderBy;
			cmd.Parameters.Add(new SqlParameter("PageIndex", SqlDbType.NVarChar)).Value = c.PageIndex;
            cmd.Parameters.Add(new SqlParameter("PageSize", SqlDbType.NVarChar)).Value = c.PageSize;
            cmd.Parameters.Add(new SqlParameter("Order", SqlDbType.NVarChar)).Value = c.OrderDirection;
            cmd.Parameters.Add(new SqlParameter("OrderBy", SqlDbType.NVarChar)).Value = c.OrderBy;

             cmd.Parameters.Add(new SqlParameter("UserRoleID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.UserRoleID);
cmd.Parameters.Add(new SqlParameter("RoleID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.RoleID);
cmd.Parameters.Add(new SqlParameter("UserID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.UserID);
cmd.Parameters.Add(new SqlParameter("CreateDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.CreateDate);
cmd.Parameters.Add(new SqlParameter("CreateUser", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.CreateUser);


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
        public static int Update(ClUserRole c)
        {

            SqlCommand cmd = new SqlCommand("PRC_UserRole_Update", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

	cmd.Parameters.Add(new SqlParameter("UserRoleID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.UserRoleID);
cmd.Parameters.Add(new SqlParameter("RoleID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.RoleID);
cmd.Parameters.Add(new SqlParameter("UserID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.UserID);
cmd.Parameters.Add(new SqlParameter("CreateDate", SqlDbType.SmallDateTime)).Value = Securenamespace.SecureData.CheckSecurity(c.CreateDate);
cmd.Parameters.Add(new SqlParameter("CreateUser", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.CreateUser);


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
        public static int Delete(string  UserRoleID)
        {

            SqlCommand cmd = new SqlCommand("PRC_UserRole_Delete", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

   	cmd.Parameters.Add(new SqlParameter("UserRoleID", SqlDbType.Int)).Value =UserRoleID ;
 
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

