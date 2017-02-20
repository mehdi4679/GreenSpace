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
    public class ArchiveAgreeClass
    {
        public static SqlConnection cnn = new SqlConnection(CSharp.PublicFunction.cnstr());
        public static int insert(ClArchiveAgree c )

        {

            SqlCommand cmd = new SqlCommand("PRC_ArchiveAgree_Insert", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


        cmd.Parameters.Add(new SqlParameter("AgreeID", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreeID);
       cmd.Parameters.Add(new SqlParameter("SubjectID", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.SubjectID);
//cmd.Parameters.Add(new SqlParameter("SubjectExplainID", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.SubjectExplainID);
//cmd.Parameters.Add(new SqlParameter("UnitNameID", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.UnitNameID);
//cmd.Parameters.Add(new SqlParameter("PriceUnit", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.PriceUnit);
//cmd.Parameters.Add(new SqlParameter("UtilityPercent", SqlDbType.NVarChar)).Value = c.UtilityPercent ;
//cmd.Parameters.Add(new SqlParameter("ActionPercent", SqlDbType.NVarChar)).Value = c.ActionPercent ;
//cmd.Parameters.Add(new SqlParameter("SumMeter", SqlDbType.NVarChar)).Value = c.SumMeter;
//cmd.Parameters.Add(new SqlParameter("Pulus", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.Pulus);
//cmd.Parameters.Add(new SqlParameter("OperationSum", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.OperationSum);
//cmd.Parameters.Add(new SqlParameter("PaySum", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.PaySum);
cmd.Parameters.Add(new SqlParameter("FineZarib", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.FineZarib);
cmd.Parameters.Add(new SqlParameter("FromDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.FromDate);
cmd.Parameters.Add(new SqlParameter("ToDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.ToDate);
cmd.Parameters.Add(new SqlParameter("ArchiveTitleID", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.ArchiveTitleID);
 

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
        public static DataSet GetList(ClArchiveAgree c)
        {

            SqlCommand cmd = new SqlCommand("PRC_ArchiveAgree_GetList", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
    
            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

             cmd.Parameters.Add(new SqlParameter("AcrchiveID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AcrchiveID);
             cmd.Parameters.Add(new SqlParameter("AgreeID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreeID);

             cmd.Parameters.Add(new SqlParameter("SubjectID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SubjectID);
             cmd.Parameters.Add(new SqlParameter("SubjectExplainID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SubjectExplainID);
             cmd.Parameters.Add(new SqlParameter("UnitNameID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.UnitNameID);
             cmd.Parameters.Add(new SqlParameter("PriceUnit", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PriceUnit);
             cmd.Parameters.Add(new SqlParameter("UtilityPercent", SqlDbType.NVarChar)).Value = c.UtilityPercent;
             cmd.Parameters.Add(new SqlParameter("ActionPercent", SqlDbType.NVarChar)).Value = c.ActionPercent;
             cmd.Parameters.Add(new SqlParameter("SumMeter", SqlDbType.NVarChar)).Value = c.SumMeter;
             cmd.Parameters.Add(new SqlParameter("Pulus", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.Pulus);
             cmd.Parameters.Add(new SqlParameter("OperationSum", SqlDbType.BigInt)).Value = Securenamespace.SecureData.CheckSecurity(c.OperationSum);
             cmd.Parameters.Add(new SqlParameter("PaySum", SqlDbType.BigInt)).Value = Securenamespace.SecureData.CheckSecurity(c.PaySum);
             cmd.Parameters.Add(new SqlParameter("FineZarib", SqlDbType.BigInt)).Value = Securenamespace.SecureData.CheckSecurity(c.FineZarib);
             cmd.Parameters.Add(new SqlParameter("FromDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.FromDate);
             cmd.Parameters.Add(new SqlParameter("ToDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.ToDate);
             cmd.Parameters.Add(new SqlParameter("ArchiveTitleID", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.ArchiveTitleID);


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
        public static DataSet GetListReport(ClArchiveAgree c)
        {

            SqlCommand cmd = new SqlCommand("PRC_ArchiveAgreeTitle_GetListReport", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
    
            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

             cmd.Parameters.Add(new SqlParameter("AcrchiveID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AcrchiveID);
             cmd.Parameters.Add(new SqlParameter("AgreeID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreeID);

             //cmd.Parameters.Add(new SqlParameter("SubjectID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SubjectID);
             //cmd.Parameters.Add(new SqlParameter("SubjectExplainID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SubjectExplainID);
             //cmd.Parameters.Add(new SqlParameter("UnitNameID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.UnitNameID);
             //cmd.Parameters.Add(new SqlParameter("PriceUnit", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PriceUnit);
             //cmd.Parameters.Add(new SqlParameter("UtilityPercent", SqlDbType.NVarChar)).Value = c.UtilityPercent;
             //cmd.Parameters.Add(new SqlParameter("ActionPercent", SqlDbType.NVarChar)).Value = c.ActionPercent;
             //cmd.Parameters.Add(new SqlParameter("SumMeter", SqlDbType.NVarChar)).Value = c.SumMeter;
             //cmd.Parameters.Add(new SqlParameter("Pulus", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.Pulus);
             //cmd.Parameters.Add(new SqlParameter("OperationSum", SqlDbType.BigInt)).Value = Securenamespace.SecureData.CheckSecurity(c.OperationSum);
             //cmd.Parameters.Add(new SqlParameter("PaySum", SqlDbType.BigInt)).Value = Securenamespace.SecureData.CheckSecurity(c.PaySum);
             //cmd.Parameters.Add(new SqlParameter("FineZarib", SqlDbType.BigInt)).Value = Securenamespace.SecureData.CheckSecurity(c.FineZarib);
             //cmd.Parameters.Add(new SqlParameter("FromDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.FromDate);
             //cmd.Parameters.Add(new SqlParameter("ToDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.ToDate);


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
        public static int Update(ClArchiveAgree c)
        {

            SqlCommand cmd = new SqlCommand("PRC_ArchiveAgree_Update", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

	cmd.Parameters.Add(new SqlParameter("AcrchiveID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AcrchiveID);
    cmd.Parameters.Add(new SqlParameter("SubjectID", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.SubjectID);
    cmd.Parameters.Add(new SqlParameter("SubjectExplainID", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.SubjectExplainID);
    cmd.Parameters.Add(new SqlParameter("UnitNameID", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.UnitNameID);
    cmd.Parameters.Add(new SqlParameter("PriceUnit", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.PriceUnit);
    cmd.Parameters.Add(new SqlParameter("UtilityPercent", SqlDbType.NVarChar)).Value = c.UtilityPercent;
    cmd.Parameters.Add(new SqlParameter("ActionPercent", SqlDbType.NVarChar)).Value = c.ActionPercent;
    cmd.Parameters.Add(new SqlParameter("SumMeter", SqlDbType.NVarChar)).Value = c.SumMeter;
    cmd.Parameters.Add(new SqlParameter("Pulus", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.Pulus);
    cmd.Parameters.Add(new SqlParameter("OperationSum", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.OperationSum);
    cmd.Parameters.Add(new SqlParameter("PaySum", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.PaySum);
    cmd.Parameters.Add(new SqlParameter("FineZarib", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.FineZarib);
    cmd.Parameters.Add(new SqlParameter("FromDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.FromDate);
    cmd.Parameters.Add(new SqlParameter("ToDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.ToDate);
     cmd.Parameters.Add(new SqlParameter("repeattt", SqlDbType.NVarChar)).Value =  c.repeattt ;


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
        public static int Delete(string  AcrchiveID)
        {

            SqlCommand cmd = new SqlCommand("PRC_ArchiveAgree_Delete", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

   	cmd.Parameters.Add(new SqlParameter("AcrchiveID", SqlDbType.Int)).Value =AcrchiveID ;
 
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

