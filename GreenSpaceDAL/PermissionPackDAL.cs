using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Collections;
using System.Data.SqlClient;
using TaxiCL;

namespace TaxiDAL
{
    public class PermissionPackClass
    {
        public static SqlConnection cnn = new SqlConnection(CSharp.PublicFunction.cnstr());
        public static int insert(ClPermissionPack c )

        {

            SqlCommand cmd = new SqlCommand("PRC_PermissionPack_Insert", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

      
       cmd.Parameters.Add(new SqlParameter("PermissionID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.PermissionID);
cmd.Parameters.Add(new SqlParameter("PackID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.PackID);
cmd.Parameters.Add(new SqlParameter("Canview", SqlDbType.Bit)).Value =Securenamespace.SecureData.CheckSecurity(c.Canview);
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

        public static DataSet GetList(ClPermissionPack c)
        {

            SqlCommand cmd = new SqlCommand("PRC_PermissionPack_GetList", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("PageIndex", SqlDbType.NVarChar)).Value = c.PageIndex;
            cmd.Parameters.Add(new SqlParameter("PageSize", SqlDbType.NVarChar)).Value = c.PageSize;
            cmd.Parameters.Add(new SqlParameter("Order", SqlDbType.NVarChar)).Value = c.OrderDirection;
            cmd.Parameters.Add(new SqlParameter("OrderBy", SqlDbType.NVarChar)).Value = c.OrderBy;
			 
             cmd.Parameters.Add(new SqlParameter("PermissionPAckID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PermissionPAckID);
cmd.Parameters.Add(new SqlParameter("PermissionID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PermissionID);
cmd.Parameters.Add(new SqlParameter("PackID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PackID);
cmd.Parameters.Add(new SqlParameter("Canview", SqlDbType.Bit)).Value = Securenamespace.SecureData.CheckSecurity(c.Canview);
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
        public static DataSet GetPAckNotPermisson(ClPermissionPack c)
        {

            SqlCommand cmd = new SqlCommand("PRC_PermissionPack_Not_GetList", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("PageIndex", SqlDbType.NVarChar)).Value = c.PageIndex;
            cmd.Parameters.Add(new SqlParameter("PageSize", SqlDbType.NVarChar)).Value = c.PageSize;
            cmd.Parameters.Add(new SqlParameter("Order", SqlDbType.NVarChar)).Value = c.OrderDirection;
            cmd.Parameters.Add(new SqlParameter("OrderBy", SqlDbType.NVarChar)).Value = c.OrderBy;
        
            cmd.Parameters.Add(new SqlParameter("PermissionPAckID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PermissionPAckID);
            cmd.Parameters.Add(new SqlParameter("PermissionID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PermissionID);
            cmd.Parameters.Add(new SqlParameter("PackID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PackID);
            cmd.Parameters.Add(new SqlParameter("Canview", SqlDbType.Bit)).Value = Securenamespace.SecureData.CheckSecurity(c.Canview);
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
        public static int Update(ClPermissionPack c)
        {

            SqlCommand cmd = new SqlCommand("PRC_PermissionPack_Update", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

	cmd.Parameters.Add(new SqlParameter("PermissionPAckID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PermissionPAckID);
cmd.Parameters.Add(new SqlParameter("PermissionID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PermissionID);
cmd.Parameters.Add(new SqlParameter("PackID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PackID);
cmd.Parameters.Add(new SqlParameter("Canview", SqlDbType.Bit)).Value = Securenamespace.SecureData.CheckSecurity(c.Canview);
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
        public static int Delete(string  PermissionPAckID)
        {

            SqlCommand cmd = new SqlCommand("PRC_PermissionPack_Delete", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

   	cmd.Parameters.Add(new SqlParameter("PermissionPAckID", SqlDbType.Int)).Value =PermissionPAckID ;
 
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

