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
    public class ArchiveAgreeTitleClass
    {
        public static SqlConnection cnn = new SqlConnection(CSharp.PublicFunction.cnstr());
        public static int insert(ClArchiveAgreeTitle c)
        {

            SqlCommand cmd = new SqlCommand("PRC_ArchiveAgreeTitle_Insert", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
            cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


            cmd.Parameters.Add(new SqlParameter("FromDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.FromDate);
            cmd.Parameters.Add(new SqlParameter("ToDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.ToDate);
            cmd.Parameters.Add(new SqlParameter("Title", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.Title);
            cmd.Parameters.Add(new SqlParameter("IsDelete", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.IsDelete);
            cmd.Parameters.Add(new SqlParameter("AgreeID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreeID);
            cmd.Parameters.Add(new SqlParameter("SoratJalase", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SoratJalase);
            cmd.Parameters.Add(new SqlParameter("SoratJalase_Manfi", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SoratJalase_Manfi);


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
        public static DataSet GetList(ClArchiveAgreeTitle c)
        {

            SqlCommand cmd = new SqlCommand("PRC_ArchiveAgreeTitle_GetList", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
            cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

            cmd.Parameters.Add(new SqlParameter("tbl_ArchiveAgreeTitle", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.tbl_ArchiveAgreeTitle);
            cmd.Parameters.Add(new SqlParameter("FromDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.FromDate);
            cmd.Parameters.Add(new SqlParameter("ToDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.ToDate);
            cmd.Parameters.Add(new SqlParameter("Title", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.Title);
            cmd.Parameters.Add(new SqlParameter("IsDelete", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.IsDelete);
            cmd.Parameters.Add(new SqlParameter("AgreeID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreeID);


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
        public static int Update(ClArchiveAgreeTitle c)
        {

            SqlCommand cmd = new SqlCommand("PRC_ArchiveAgreeTitle_Update", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
            cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

            cmd.Parameters.Add(new SqlParameter("tbl_ArchiveAgreeTitle", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.tbl_ArchiveAgreeTitle);
            cmd.Parameters.Add(new SqlParameter("FromDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.FromDate);
            cmd.Parameters.Add(new SqlParameter("ToDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.ToDate);
            cmd.Parameters.Add(new SqlParameter("Title", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.Title);
            cmd.Parameters.Add(new SqlParameter("IsDelete", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.IsDelete);
            cmd.Parameters.Add(new SqlParameter("AgreeID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreeID);


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
        public static int Delete(string tbl_ArchiveAgreeTitle)
        {

            SqlCommand cmd = new SqlCommand("PRC_ArchiveAgreeTitle_Delete", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
            cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

            cmd.Parameters.Add(new SqlParameter("tbl_ArchiveAgreeTitle", SqlDbType.Int)).Value = tbl_ArchiveAgreeTitle;

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

