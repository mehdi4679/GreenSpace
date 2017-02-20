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
cmd.Parameters.Add(new SqlParameter("Puls", SqlDbType.Decimal)).Value = c.Puls ;
cmd.Parameters.Add(new SqlParameter("IsTamdid", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.IsTamdid);
cmd.Parameters.Add(new SqlParameter("AgreeTamdid", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreeTamdid);
cmd.Parameters.Add(new SqlParameter("AgreeSerial", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreeSerial);
cmd.Parameters.Add(new SqlParameter("EtabarAgreement", SqlDbType.BigInt)).Value = c.EtabarAgreement;
cmd.Parameters.Add(new SqlParameter("AgreeName", SqlDbType.NVarChar)).Value = c.AgreeName;


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
        public static DataSet GetListUserPeyman(ClAgreement c)
        {

            SqlCommand cmd = new SqlCommand("PRC_AllPeymanPerson", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
            cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

            cmd.Parameters.Add(new SqlParameter("UserID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.UserID);
 

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

        public static DataSet GetListCalPrice(ClAgreement c)
        {

            SqlCommand cmd = new SqlCommand("PRC_Agreement_GetListPriceExel", cnn);
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
        public static DataSet GetListSubjectPrice(ClArchiveAgree c)
        {

            SqlCommand cmd = new SqlCommand("PRC_Subject_ArchiveAgreeTitle_GetListReport", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("AcrchiveID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AcrchiveID);
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
        public static DataSet GetListReport2(ClAgreement c)
        {

            SqlCommand cmd = new SqlCommand("PRC_Agreement_GetListReport3", cnn);
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
cmd.Parameters.Add(new SqlParameter("Puls", SqlDbType.Decimal)).Value = c.Puls ;
cmd.Parameters.Add(new SqlParameter("IsTamdid", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.IsTamdid);
cmd.Parameters.Add(new SqlParameter("AgreeTamdid", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreeTamdid);
cmd.Parameters.Add(new SqlParameter("AgreeSerial", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreeSerial);
cmd.Parameters.Add(new SqlParameter("EtabarAgreement", SqlDbType.BigInt)).Value =  c.EtabarAgreement ;
cmd.Parameters.Add(new SqlParameter("AgreeName", SqlDbType.NVarChar)).Value = c.AgreeName;

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

