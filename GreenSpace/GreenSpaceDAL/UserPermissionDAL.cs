using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Collections;
using System.Data.SqlClient;
using GreenSpaceCL;
using TaxiCL;
 

namespace TaxiDAL
{
    public class UserPermissionClass
    {

        public static SqlConnection cnn = new SqlConnection(CSharp.PublicFunction.cnstr());



      




        public static int insert(ClUserPermission c )

        {

            SqlCommand cmd = new SqlCommand("PRC_UserPermission_Insert", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

      
       cmd.Parameters.Add(new SqlParameter("UserID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.UserID);
cmd.Parameters.Add(new SqlParameter("PermissionID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.PermissionID);
cmd.Parameters.Add(new SqlParameter("CanView", SqlDbType.Bit)).Value =Securenamespace.SecureData.CheckSecurity(c.CanView);
cmd.Parameters.Add(new SqlParameter("CanUpdate", SqlDbType.Bit)).Value =Securenamespace.SecureData.CheckSecurity(c.CanUpdate);
cmd.Parameters.Add(new SqlParameter("CanDel", SqlDbType.Bit)).Value =Securenamespace.SecureData.CheckSecurity(c.CanDel);
cmd.Parameters.Add(new SqlParameter("CanInsert", SqlDbType.Bit)).Value =Securenamespace.SecureData.CheckSecurity(c.CanInsert);


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
        public static int insertWithPP(string  userid,string packid)
        {

            SqlCommand cmd = new SqlCommand("PRC_UserPermission_InsertWhitpp", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
            cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


            cmd.Parameters.Add(new SqlParameter("UserID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(userid);
            cmd.Parameters.Add(new SqlParameter("PackID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(packid);


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

        public static DataSet GetList(ClUserPermission c)
        {

            SqlCommand cmd = new SqlCommand("PRC_UserPermission_GetList", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("PageIndex", SqlDbType.NVarChar)).Value = c.PageIndex;
            cmd.Parameters.Add(new SqlParameter("PageSize", SqlDbType.NVarChar)).Value = c.PageSize;
            cmd.Parameters.Add(new SqlParameter("Order", SqlDbType.NVarChar)).Value = c.OrderDirection;
            cmd.Parameters.Add(new SqlParameter("OrderBy", SqlDbType.NVarChar)).Value = c.OrderBy;
	 

             cmd.Parameters.Add(new SqlParameter("UserPermissinID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.UserPermissinID);
cmd.Parameters.Add(new SqlParameter("UserID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.UserID);
cmd.Parameters.Add(new SqlParameter("PermissionID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PermissionID);
cmd.Parameters.Add(new SqlParameter("CanView", SqlDbType.Bit)).Value = Securenamespace.SecureData.CheckSecurity(c.CanView);
cmd.Parameters.Add(new SqlParameter("CanUpdate", SqlDbType.Bit)).Value = Securenamespace.SecureData.CheckSecurity(c.CanUpdate);
cmd.Parameters.Add(new SqlParameter("CanDel", SqlDbType.Bit)).Value = Securenamespace.SecureData.CheckSecurity(c.CanDel);
cmd.Parameters.Add(new SqlParameter("CanInsert", SqlDbType.Bit)).Value = Securenamespace.SecureData.CheckSecurity(c.CanInsert);
cmd.Parameters.Add(new SqlParameter("PageName", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.PageName);


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
        public static DataSet GetUserNotPermission(ClUserPermission c)
        {

            SqlCommand cmd = new SqlCommand("PRC_UserPermission_NotGetList", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("PageIndex", SqlDbType.NVarChar)).Value = c.PageIndex;
            cmd.Parameters.Add(new SqlParameter("PageSize", SqlDbType.NVarChar)).Value = c.PageSize;
            cmd.Parameters.Add(new SqlParameter("Order", SqlDbType.NVarChar)).Value = c.OrderDirection;
            cmd.Parameters.Add(new SqlParameter("OrderBy", SqlDbType.NVarChar)).Value = c.OrderBy;
           
            cmd.Parameters.Add(new SqlParameter("UserPermissinID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.UserPermissinID);
            cmd.Parameters.Add(new SqlParameter("UserID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.UserID);
            cmd.Parameters.Add(new SqlParameter("PermissionID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PermissionID);
            cmd.Parameters.Add(new SqlParameter("CanView", SqlDbType.Bit)).Value = Securenamespace.SecureData.CheckSecurity(c.CanView);
            cmd.Parameters.Add(new SqlParameter("CanUpdate", SqlDbType.Bit)).Value = Securenamespace.SecureData.CheckSecurity(c.CanUpdate);
            cmd.Parameters.Add(new SqlParameter("CanDel", SqlDbType.Bit)).Value = Securenamespace.SecureData.CheckSecurity(c.CanDel);
            cmd.Parameters.Add(new SqlParameter("CanInsert", SqlDbType.Bit)).Value = Securenamespace.SecureData.CheckSecurity(c.CanInsert);


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
        public static int Update(ClUserPermission c)
        {

            SqlCommand cmd = new SqlCommand("PRC_UserPermission_Update", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

	cmd.Parameters.Add(new SqlParameter("UserPermissinID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.UserPermissinID);
cmd.Parameters.Add(new SqlParameter("UserID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.UserID);
cmd.Parameters.Add(new SqlParameter("PermissionID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PermissionID);
cmd.Parameters.Add(new SqlParameter("CanView", SqlDbType.Bit)).Value = Securenamespace.SecureData.CheckSecurity(c.CanView);
cmd.Parameters.Add(new SqlParameter("CanUpdate", SqlDbType.Bit)).Value = Securenamespace.SecureData.CheckSecurity(c.CanUpdate);
cmd.Parameters.Add(new SqlParameter("CanDel", SqlDbType.Bit)).Value = Securenamespace.SecureData.CheckSecurity(c.CanDel);
cmd.Parameters.Add(new SqlParameter("CanInsert", SqlDbType.Bit)).Value = Securenamespace.SecureData.CheckSecurity(c.CanInsert);


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
        public static int Delete(string  UserPermissinID)
        {

            SqlCommand cmd = new SqlCommand("PRC_UserPermission_Delete", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

   	cmd.Parameters.Add(new SqlParameter("UserPermissinID", SqlDbType.Int)).Value =UserPermissinID ;
 
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

