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
    public class AgreementPercentClass
    {
        public static SqlConnection cnn = new SqlConnection(CSharp.PublicFunction.cnstr());
        public static int insert(ClAgreementPercent c )

        {

            SqlCommand cmd = new SqlCommand("PRC_AgreementPercent_Insert", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

      
       cmd.Parameters.Add(new SqlParameter("AgreementID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.AgreementID);
cmd.Parameters.Add(new SqlParameter("ExplainID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.ExplainID);
cmd.Parameters.Add(new SqlParameter("utilityPersent", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.utilityPersent);
cmd.Parameters.Add(new SqlParameter("VisitDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.VisitDate);
cmd.Parameters.Add(new SqlParameter("SuperVisorID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.SuperVisorID);
cmd.Parameters.Add(new SqlParameter("FineMeterOrRepeat", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.FineMeterOrRepeat);
cmd.Parameters.Add(new SqlParameter("FineFactor", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.FineFactor);
cmd.Parameters.Add(new SqlParameter("JarimeComment", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.JarimeComment);


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
        public static DataSet GetList(ClAgreementPercent c)
        {

            SqlCommand cmd = new SqlCommand("PRC_AgreementPercent_GetList", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
            cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

             cmd.Parameters.Add(new SqlParameter("AgreementPercentID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreementPercentID);
cmd.Parameters.Add(new SqlParameter("AgreementID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreementID);
cmd.Parameters.Add(new SqlParameter("ExplainID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ExplainID);
cmd.Parameters.Add(new SqlParameter("utilityPersent", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.utilityPersent);
cmd.Parameters.Add(new SqlParameter("VisitDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.VisitDate);
cmd.Parameters.Add(new SqlParameter("SuperVisorID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SuperVisorID);
cmd.Parameters.Add(new SqlParameter("FineMeterOrRepeat", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.FineMeterOrRepeat);
cmd.Parameters.Add(new SqlParameter("FineFactor", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.FineFactor);
cmd.Parameters.Add(new SqlParameter("JarimeComment", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.JarimeComment);


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
        public static int Update(ClAgreementPercent c)
        {

            SqlCommand cmd = new SqlCommand("PRC_AgreementPercent_Update", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

	cmd.Parameters.Add(new SqlParameter("AgreementPercentID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreementPercentID);
cmd.Parameters.Add(new SqlParameter("AgreementID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreementID);
cmd.Parameters.Add(new SqlParameter("ExplainID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ExplainID);
cmd.Parameters.Add(new SqlParameter("utilityPersent", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.utilityPersent);
cmd.Parameters.Add(new SqlParameter("VisitDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.VisitDate);
cmd.Parameters.Add(new SqlParameter("SuperVisorID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SuperVisorID);
cmd.Parameters.Add(new SqlParameter("FineMeterOrRepeat", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.FineMeterOrRepeat);
cmd.Parameters.Add(new SqlParameter("FineFactor", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.FineFactor);
cmd.Parameters.Add(new SqlParameter("JarimeComment", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.JarimeComment);


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
        public static int Delete(string  AgreementPercentID)
        {

            SqlCommand cmd = new SqlCommand("PRC_AgreementPercent_Delete", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

   	cmd.Parameters.Add(new SqlParameter("AgreementPercentID", SqlDbType.Int)).Value =AgreementPercentID ;
 
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

