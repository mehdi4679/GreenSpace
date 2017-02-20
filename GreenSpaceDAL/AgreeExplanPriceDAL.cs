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
    public class AgreeExplanPriceClass
    {
        public static SqlConnection cnn = new SqlConnection(CSharp.PublicFunction.cnstr());
        public static int insert(ClAgreeExplanPrice c )

        {

            SqlCommand cmd = new SqlCommand("PRC_AgreeExplanPrice_Insert", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

      
       cmd.Parameters.Add(new SqlParameter("ExplanID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.ExplanID);
cmd.Parameters.Add(new SqlParameter("PriceNightExplan", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.PriceNightExplan);
cmd.Parameters.Add(new SqlParameter("PriceDayExplan", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.PriceDayExplan);
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


        public static int Updatezarib(ClAgreeExplanPrice c)
        {

            SqlCommand cmd = new SqlCommand("PRC_AgreeExplanPrice_UpdateZarib", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
            cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


            cmd.Parameters.Add(new SqlParameter("ExplanID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ExplanID);
            cmd.Parameters.Add(new SqlParameter("PriceNightExplan", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PriceNightExplan);
            cmd.Parameters.Add(new SqlParameter("PriceDayExplan", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PriceDayExplan);
            cmd.Parameters.Add(new SqlParameter("AgreementID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreementID);
            cmd.Parameters.Add(new SqlParameter("ZaribPrice", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.ZaribPrice);


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
        public static DataSet GetList(ClAgreeExplanPrice c)
        {

            SqlCommand cmd = new SqlCommand("PRC_AgreeExplanPrice_GetList", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
            cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

             cmd.Parameters.Add(new SqlParameter("ExplanPriceID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ExplanPriceID);
cmd.Parameters.Add(new SqlParameter("ExplanID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ExplanID);
cmd.Parameters.Add(new SqlParameter("PriceNightExplan", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PriceNightExplan);
cmd.Parameters.Add(new SqlParameter("PriceDayExplan", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PriceDayExplan);
cmd.Parameters.Add(new SqlParameter("AgreementID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreementID);

cmd.Parameters.Add(new SqlParameter("SubjectID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SubjectID);

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
        public static int Update(ClAgreeExplanPrice c)
        {

            SqlCommand cmd = new SqlCommand("PRC_AgreeExplanPrice_Update", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

	cmd.Parameters.Add(new SqlParameter("ExplanPriceID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ExplanPriceID);
cmd.Parameters.Add(new SqlParameter("ExplanID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ExplanID);
cmd.Parameters.Add(new SqlParameter("PriceNightExplan", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PriceNightExplan);
cmd.Parameters.Add(new SqlParameter("PriceDayExplan", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PriceDayExplan);
cmd.Parameters.Add(new SqlParameter("AgreementID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreementID);
cmd.Parameters.Add(new SqlParameter("ActID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ActID);
cmd.Parameters.Add(new SqlParameter("FromDateActive", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.FromDateActive);
cmd.Parameters.Add(new SqlParameter("ToDateActive", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.ToDateActive);


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
        public static int UpdateAct(ClAgreeExplanPrice c)
        {

            SqlCommand cmd = new SqlCommand("PRC_AgreeExplanPrice_UpdateAct", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

	cmd.Parameters.Add(new SqlParameter("ExplanPriceID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ExplanPriceID);
 cmd.Parameters.Add(new SqlParameter("ActID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ActID);


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
        public static int Delete(string  ExplanPriceID)
        {

            SqlCommand cmd = new SqlCommand("PRC_AgreeExplanPrice_Delete", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

   	cmd.Parameters.Add(new SqlParameter("ExplanPriceID", SqlDbType.Int)).Value =ExplanPriceID ;
 
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

