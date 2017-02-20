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
    public class AgreementClass
    {
        public static SqlConnection cnn = new SqlConnection(CSharp.PublicFunction.cnstr());
        public static int insert(ClAgreement c )

        {

            SqlCommand cmd = new SqlCommand("PRC_Agreement_Insert", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

      
       cmd.Parameters.Add(new SqlParameter("PeymanID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.PeymanID);
cmd.Parameters.Add(new SqlParameter("PeymanKarID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.PeymanKarID);
cmd.Parameters.Add(new SqlParameter("supervisorStaticID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.supervisorStaticID);
cmd.Parameters.Add(new SqlParameter("MasterGreenSpaceID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.MasterGreenSpaceID);
cmd.Parameters.Add(new SqlParameter("supervisor2ID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.supervisor2ID);
cmd.Parameters.Add(new SqlParameter("supervisor3ID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.supervisor3ID);
cmd.Parameters.Add(new SqlParameter("StatrtDateAgreement", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.StatrtDateAgreement);
cmd.Parameters.Add(new SqlParameter("EndDateAgreement", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.EndDateAgreement);
cmd.Parameters.Add(new SqlParameter("PriceAgreementYear", SqlDbType.BigInt)).Value = c.PriceAgreementYear;
cmd.Parameters.Add(new SqlParameter("MonitorinOfficeID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.MonitorinOfficeID);
cmd.Parameters.Add(new SqlParameter("Puls", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.Puls);


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
        public static DataSet GetList(ClAgreement c)
        {

            SqlCommand cmd = new SqlCommand("PRC_Agreement_GetList", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
            cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

             cmd.Parameters.Add(new SqlParameter("AgreementID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreementID);
cmd.Parameters.Add(new SqlParameter("PeymanID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PeymanID);
cmd.Parameters.Add(new SqlParameter("PeymanKarID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PeymanKarID);
cmd.Parameters.Add(new SqlParameter("supervisorStaticID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.supervisorStaticID);
cmd.Parameters.Add(new SqlParameter("MasterGreenSpaceID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.MasterGreenSpaceID);
cmd.Parameters.Add(new SqlParameter("supervisor2ID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.supervisor2ID);
cmd.Parameters.Add(new SqlParameter("supervisor3ID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.supervisor3ID);
cmd.Parameters.Add(new SqlParameter("StatrtDateAgreement", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.StatrtDateAgreement);
cmd.Parameters.Add(new SqlParameter("EndDateAgreement", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.EndDateAgreement);
cmd.Parameters.Add(new SqlParameter("PriceAgreementYear", SqlDbType.BigInt)).Value = c.PriceAgreementYear;
cmd.Parameters.Add(new SqlParameter("MonitorinOfficeID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.MonitorinOfficeID);


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
        public static DataSet GetListSubjectPrice(ClAgreement c)
        {

            SqlCommand cmd = new SqlCommand("Rep_Prc_SubjetPrice", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
            cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

             cmd.Parameters.Add(new SqlParameter("AgreementID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreementID);
cmd.Parameters.Add(new SqlParameter("PeymanID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PeymanID);
cmd.Parameters.Add(new SqlParameter("PeymanKarID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PeymanKarID);
cmd.Parameters.Add(new SqlParameter("supervisorStaticID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.supervisorStaticID);
cmd.Parameters.Add(new SqlParameter("MasterGreenSpaceID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.MasterGreenSpaceID);
cmd.Parameters.Add(new SqlParameter("supervisor2ID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.supervisor2ID);
cmd.Parameters.Add(new SqlParameter("supervisor3ID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.supervisor3ID);
cmd.Parameters.Add(new SqlParameter("StatrtDateAgreement", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.StatrtDateAgreement);
cmd.Parameters.Add(new SqlParameter("EndDateAgreement", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.EndDateAgreement);
cmd.Parameters.Add(new SqlParameter("PriceAgreementYear", SqlDbType.BigInt)).Value = c.PriceAgreementYear;
cmd.Parameters.Add(new SqlParameter("MonitorinOfficeID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.MonitorinOfficeID);


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
        public static DataSet GetListReport(ClAgreement c)
        {

            SqlCommand cmd = new SqlCommand("PRC_Agreement_GetListReport", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
            cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

            cmd.Parameters.Add(new SqlParameter("AgreementID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreementID);
            cmd.Parameters.Add(new SqlParameter("PeymanID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PeymanID);
            cmd.Parameters.Add(new SqlParameter("PeymanKarID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PeymanKarID);
            cmd.Parameters.Add(new SqlParameter("supervisorStaticID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.supervisorStaticID);
            cmd.Parameters.Add(new SqlParameter("MasterGreenSpaceID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.MasterGreenSpaceID);
            cmd.Parameters.Add(new SqlParameter("supervisor2ID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.supervisor2ID);
            cmd.Parameters.Add(new SqlParameter("supervisor3ID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.supervisor3ID);
            cmd.Parameters.Add(new SqlParameter("StatrtDateAgreement", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.StatrtDateAgreement);
            cmd.Parameters.Add(new SqlParameter("EndDateAgreement", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.EndDateAgreement);
            cmd.Parameters.Add(new SqlParameter("PriceAgreementYear", SqlDbType.BigInt)).Value = c.PriceAgreementYear;
            cmd.Parameters.Add(new SqlParameter("MonitorinOfficeID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.MonitorinOfficeID);
            cmd.Parameters.Add(new SqlParameter("FromDateReport", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.FromDateReport);
            cmd.Parameters.Add(new SqlParameter("ToDateReport", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.ToDateReport);
            cmd.Parameters.Add(new SqlParameter("Subjectid", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SubjectID);


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
        public static int Update(ClAgreement c)
        {

            SqlCommand cmd = new SqlCommand("PRC_Agreement_Update", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

	cmd.Parameters.Add(new SqlParameter("AgreementID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreementID);
cmd.Parameters.Add(new SqlParameter("PeymanID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PeymanID);
cmd.Parameters.Add(new SqlParameter("PeymanKarID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PeymanKarID);
cmd.Parameters.Add(new SqlParameter("supervisorStaticID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.supervisorStaticID);
cmd.Parameters.Add(new SqlParameter("MasterGreenSpaceID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.MasterGreenSpaceID);
cmd.Parameters.Add(new SqlParameter("supervisor2ID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.supervisor2ID);
cmd.Parameters.Add(new SqlParameter("supervisor3ID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.supervisor3ID);
cmd.Parameters.Add(new SqlParameter("StatrtDateAgreement", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.StatrtDateAgreement);
cmd.Parameters.Add(new SqlParameter("EndDateAgreement", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.EndDateAgreement);
cmd.Parameters.Add(new SqlParameter("PriceAgreementYear", SqlDbType.BigInt)).Value =  c.PriceAgreementYear ;
cmd.Parameters.Add(new SqlParameter("MonitorinOfficeID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.MonitorinOfficeID);
cmd.Parameters.Add(new SqlParameter("Puls", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.Puls);

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
        public static int Delete(string  AgreementID)
        {

            SqlCommand cmd = new SqlCommand("PRC_Agreement_Delete", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

   	cmd.Parameters.Add(new SqlParameter("AgreementID", SqlDbType.Int)).Value =AgreementID ;
 
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

