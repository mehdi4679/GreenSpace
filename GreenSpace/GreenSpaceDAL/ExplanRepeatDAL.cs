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
    public class ExplanRepeatClass
    {
        public static SqlConnection cnn = new SqlConnection(CSharp.PublicFunction.cnstr());
        public static int insert(ClExplanRepeat c )

        {

            SqlCommand cmd = new SqlCommand("PRC_AgreeExplanRepeat_Insert", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

      
       cmd.Parameters.Add(new SqlParameter("ExplanID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.ExplanID);
cmd.Parameters.Add(new SqlParameter("RpeatMonth1", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.RpeatMonth1);
cmd.Parameters.Add(new SqlParameter("RpeatMonth2", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.RpeatMonth2);
cmd.Parameters.Add(new SqlParameter("RpeatMonth3", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.RpeatMonth3);
cmd.Parameters.Add(new SqlParameter("RpeatMonth4", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.RpeatMonth4);
cmd.Parameters.Add(new SqlParameter("RpeatMonth5", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.RpeatMonth5);
cmd.Parameters.Add(new SqlParameter("RpeatMonth6", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.RpeatMonth6);
cmd.Parameters.Add(new SqlParameter("RpeatMonth7", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.RpeatMonth7);
cmd.Parameters.Add(new SqlParameter("RpeatMonth8", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.RpeatMonth8);
cmd.Parameters.Add(new SqlParameter("RpeatMonth9", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.RpeatMonth9);
cmd.Parameters.Add(new SqlParameter("RpeatMonth10", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.RpeatMonth10);
cmd.Parameters.Add(new SqlParameter("RpeatMonth11", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.RpeatMonth11);
cmd.Parameters.Add(new SqlParameter("RpeatMonth12", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.RpeatMonth12);
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

        //---------------------------------------------------------------------------------------------------------
        public static DataSet GetList(ClExplanRepeat c)
        {

            SqlCommand cmd = new SqlCommand("PRC_AgreeExplanRepeat_GetList", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
            cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

             cmd.Parameters.Add(new SqlParameter("ExplanRepeatID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ExplanRepeatID);
cmd.Parameters.Add(new SqlParameter("ExplanID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ExplanID);
cmd.Parameters.Add(new SqlParameter("RpeatMonth1", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.RpeatMonth1);
cmd.Parameters.Add(new SqlParameter("RpeatMonth2", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.RpeatMonth2);
cmd.Parameters.Add(new SqlParameter("RpeatMonth3", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.RpeatMonth3);
cmd.Parameters.Add(new SqlParameter("RpeatMonth4", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.RpeatMonth4);
cmd.Parameters.Add(new SqlParameter("RpeatMonth5", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.RpeatMonth5);
cmd.Parameters.Add(new SqlParameter("RpeatMonth6", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.RpeatMonth6);
cmd.Parameters.Add(new SqlParameter("RpeatMonth7", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.RpeatMonth7);
cmd.Parameters.Add(new SqlParameter("RpeatMonth8", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.RpeatMonth8);
cmd.Parameters.Add(new SqlParameter("RpeatMonth9", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.RpeatMonth9);
cmd.Parameters.Add(new SqlParameter("RpeatMonth10", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.RpeatMonth10);
cmd.Parameters.Add(new SqlParameter("RpeatMonth11", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.RpeatMonth11);
cmd.Parameters.Add(new SqlParameter("RpeatMonth12", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.RpeatMonth12);
cmd.Parameters.Add(new SqlParameter("AgreementID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreementID);


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
        public static int Update(ClExplanRepeat c)
        {

            SqlCommand cmd = new SqlCommand("PRC_ExplanRepeat_Update", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

	cmd.Parameters.Add(new SqlParameter("ExplanRepeatID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ExplanRepeatID);
cmd.Parameters.Add(new SqlParameter("ExplanID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ExplanID);
cmd.Parameters.Add(new SqlParameter("RpeatMonth1", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.RpeatMonth1);
cmd.Parameters.Add(new SqlParameter("RpeatMonth2", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.RpeatMonth2);
cmd.Parameters.Add(new SqlParameter("RpeatMonth3", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.RpeatMonth3);
cmd.Parameters.Add(new SqlParameter("RpeatMonth4", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.RpeatMonth4);
cmd.Parameters.Add(new SqlParameter("RpeatMonth5", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.RpeatMonth5);
cmd.Parameters.Add(new SqlParameter("RpeatMonth6", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.RpeatMonth6);
cmd.Parameters.Add(new SqlParameter("RpeatMonth7", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.RpeatMonth7);
cmd.Parameters.Add(new SqlParameter("RpeatMonth8", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.RpeatMonth8);
cmd.Parameters.Add(new SqlParameter("RpeatMonth9", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.RpeatMonth9);
cmd.Parameters.Add(new SqlParameter("RpeatMonth10", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.RpeatMonth10);
cmd.Parameters.Add(new SqlParameter("RpeatMonth11", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.RpeatMonth11);
cmd.Parameters.Add(new SqlParameter("RpeatMonth12", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.RpeatMonth12);
cmd.Parameters.Add(new SqlParameter("AgreementID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreementID);


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
        public static int Delete(string  ExplanRepeatID)
        {

            SqlCommand cmd = new SqlCommand("PRC_ExplanRepeat_Delete", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

   	cmd.Parameters.Add(new SqlParameter("ExplanRepeatID", SqlDbType.Int)).Value =ExplanRepeatID ;
 
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

