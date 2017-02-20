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
    public class ExplanSubjectClass
    {
        public static SqlConnection cnn = new SqlConnection(CSharp.PublicFunction.cnstr());
        public static int insert(ClExplanSubject c )

        {

            SqlCommand cmd = new SqlCommand("PRC_ExplanSubject_Insert", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

      
       cmd.Parameters.Add(new SqlParameter("SubjectID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.SubjectID);
cmd.Parameters.Add(new SqlParameter("ExplainName", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.ExplainName);
cmd.Parameters.Add(new SqlParameter("DayPriceDefualt", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.DayPriceDefualt);
cmd.Parameters.Add(new SqlParameter("NightPriceDefualt", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.NightPriceDefualt);
cmd.Parameters.Add(new SqlParameter("UnitNameID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.UnitNameID);
cmd.Parameters.Add(new SqlParameter("RotinOrNot", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.RotinOrNot);


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
        public static DataSet GetList(ClExplanSubject c)
        {

            SqlCommand cmd = new SqlCommand("PRC_ExplanSubject_GetList", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
            cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();
            
            cmd.Parameters.Add(new SqlParameter("ExplainSubjectID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ExplainSubjectID);
cmd.Parameters.Add(new SqlParameter("SubjectID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SubjectID);
cmd.Parameters.Add(new SqlParameter("ExplainName", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.ExplainName);
cmd.Parameters.Add(new SqlParameter("DayPriceDefualt", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.DayPriceDefualt);
cmd.Parameters.Add(new SqlParameter("NightPriceDefualt", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.NightPriceDefualt);
cmd.Parameters.Add(new SqlParameter("UnitNameID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.UnitNameID);
cmd.Parameters.Add(new SqlParameter("RotinOrNot", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.RotinOrNot);
cmd.Parameters.Add(new SqlParameter("AgreeMentID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreeMentID);
cmd.Parameters.Add(new SqlParameter("OnlyActive", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.OnlyActive);


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
        public static int Update(ClExplanSubject c)
        {

            SqlCommand cmd = new SqlCommand("PRC_ExplanSubject_Update", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

	cmd.Parameters.Add(new SqlParameter("ExplainSubjectID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ExplainSubjectID);
cmd.Parameters.Add(new SqlParameter("SubjectID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SubjectID);
cmd.Parameters.Add(new SqlParameter("ExplainName", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.ExplainName);
cmd.Parameters.Add(new SqlParameter("DayPriceDefualt", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.DayPriceDefualt);
cmd.Parameters.Add(new SqlParameter("NightPriceDefualt", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.NightPriceDefualt);
cmd.Parameters.Add(new SqlParameter("UnitNameID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.UnitNameID);
cmd.Parameters.Add(new SqlParameter("RotinOrNot", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.RotinOrNot);
cmd.Parameters.Add(new SqlParameter("ErthAzKol", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ErthAzKol);


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
        public static int Delete(string  ExplainSubjectID)
        {

            SqlCommand cmd = new SqlCommand("PRC_ExplanSubject_Delete", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

   	cmd.Parameters.Add(new SqlParameter("ExplainSubjectID", SqlDbType.Int)).Value =ExplainSubjectID ;
 
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

