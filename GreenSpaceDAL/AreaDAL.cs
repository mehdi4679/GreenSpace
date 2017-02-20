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
    public class AreaClass
    {
        public static SqlConnection cnn = new SqlConnection(CSharp.PublicFunction.cnstr());
        public static int insert(ClArea c )

        {

            SqlCommand cmd = new SqlCommand("PRC_Area_Insert", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

      
       cmd.Parameters.Add(new SqlParameter("ParkID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.ParkID);
cmd.Parameters.Add(new SqlParameter("SubjectExplainID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.SubjectExplainID);
cmd.Parameters.Add(new SqlParameter("UnitNumber", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.UnitNumber);
cmd.Parameters.Add(new SqlParameter("AgreementID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.AgreementID);
cmd.Parameters.Add(new SqlParameter("SubjectID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SubjectID );


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
         public static int insertAllPark(ClArea c )

        {

            SqlCommand cmd = new SqlCommand("PRC_Area_InsertAllPark", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

      
       cmd.Parameters.Add(new SqlParameter("ParkID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.ParkID);
cmd.Parameters.Add(new SqlParameter("SubjectExplainID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.SubjectExplainID);
cmd.Parameters.Add(new SqlParameter("UnitNumber", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.UnitNumber);
cmd.Parameters.Add(new SqlParameter("AgreementID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.AgreementID);
cmd.Parameters.Add(new SqlParameter("SubjectID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SubjectID );


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
       public static int Save(ClArea c )

        {

            SqlCommand cmd = new SqlCommand("PRC_Area_Save", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

      
       cmd.Parameters.Add(new SqlParameter("ParkID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.ParkID);
cmd.Parameters.Add(new SqlParameter("SubjectExplainID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.SubjectExplainID);
cmd.Parameters.Add(new SqlParameter("UnitNumber", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.UnitNumber);
cmd.Parameters.Add(new SqlParameter("AgreementID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.AgreementID);
cmd.Parameters.Add(new SqlParameter("SubjectID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SubjectID );


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
        public static int SaveErth(ClArea c )

        {

            SqlCommand cmd = new SqlCommand("PRC_Area_SaveErth", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

      
       cmd.Parameters.Add(new SqlParameter("ParkID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.ParkID);
cmd.Parameters.Add(new SqlParameter("SubjectExplainID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.SubjectExplainID);
cmd.Parameters.Add(new SqlParameter("UnitNumber", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.UnitNumber);
cmd.Parameters.Add(new SqlParameter("AgreementID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.AgreementID);
cmd.Parameters.Add(new SqlParameter("SubjectID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SubjectID );


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
        public static int SaveKhaki(ClArea c )

        {

            SqlCommand cmd = new SqlCommand("PRC_Area_SaveErthKhaki_Ghkhaki", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

      
       cmd.Parameters.Add(new SqlParameter("ParkID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.ParkID);
cmd.Parameters.Add(new SqlParameter("SubjectExplainID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.SubjectExplainID);
cmd.Parameters.Add(new SqlParameter("UnitNumber", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.UnitNumber);
cmd.Parameters.Add(new SqlParameter("AgreementID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.AgreementID);
cmd.Parameters.Add(new SqlParameter("SubjectID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SubjectID );


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

        public static int Save2(ClArea c)
        {

            SqlCommand cmd = new SqlCommand("PRC_Area_SaveUSeFromKOL", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
            cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


            cmd.Parameters.Add(new SqlParameter("ParkID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ParkID);
            //cmd.Parameters.Add(new SqlParameter("SubjectExplainID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SubjectExplainID);
            //cmd.Parameters.Add(new SqlParameter("UnitNumber", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.UnitNumber);
            //cmd.Parameters.Add(new SqlParameter("AgreementID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreementID);
            //cmd.Parameters.Add(new SqlParameter("SubjectID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SubjectID);


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
        public static DataSet GetListkhaki(ClArea c)
        {

            SqlCommand cmd = new SqlCommand("PRC_Area_GetListkhaki", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
            cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

            cmd.Parameters.Add(new SqlParameter("AreaID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AreaID);
            cmd.Parameters.Add(new SqlParameter("ParkID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ParkID);
            cmd.Parameters.Add(new SqlParameter("SubjectExplainID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SubjectExplainID);
            cmd.Parameters.Add(new SqlParameter("UnitNumber", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.UnitNumber);
            cmd.Parameters.Add(new SqlParameter("AgreementID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreementID);
            cmd.Parameters.Add(new SqlParameter("SubjectID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SubjectID);
            cmd.Parameters.Add(new SqlParameter("PeymanID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PeymanID);


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
        public static DataSet GetList(ClArea c)
        {

            SqlCommand cmd = new SqlCommand("PRC_Area_GetList", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
            cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

             cmd.Parameters.Add(new SqlParameter("AreaID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AreaID);
cmd.Parameters.Add(new SqlParameter("ParkID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ParkID);
cmd.Parameters.Add(new SqlParameter("SubjectExplainID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SubjectExplainID);
cmd.Parameters.Add(new SqlParameter("UnitNumber", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.UnitNumber);
cmd.Parameters.Add(new SqlParameter("AgreementID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreementID);
cmd.Parameters.Add(new SqlParameter("SubjectID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SubjectID);
cmd.Parameters.Add(new SqlParameter("PeymanID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PeymanID);


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
        public static DataSet GetListSubjectAgree(ClArea c)
        {

            SqlCommand cmd = new SqlCommand("PRC_SubjectAgree_GetList", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
            cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

             cmd.Parameters.Add(new SqlParameter("AreaID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AreaID);
cmd.Parameters.Add(new SqlParameter("ParkID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ParkID);
cmd.Parameters.Add(new SqlParameter("SubjectExplainID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SubjectExplainID);
cmd.Parameters.Add(new SqlParameter("UnitNumber", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.UnitNumber);
cmd.Parameters.Add(new SqlParameter("AgreementID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreementID);
cmd.Parameters.Add(new SqlParameter("SubjectID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SubjectID);
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
        public static int Update(ClArea c)
        {

            SqlCommand cmd = new SqlCommand("PRC_Area_Update", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

	cmd.Parameters.Add(new SqlParameter("AreaID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AreaID);
cmd.Parameters.Add(new SqlParameter("ParkID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ParkID);
cmd.Parameters.Add(new SqlParameter("SubjectExplainID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SubjectExplainID);
cmd.Parameters.Add(new SqlParameter("UnitNumber", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.UnitNumber);
cmd.Parameters.Add(new SqlParameter("AgreementID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.AgreementID);
cmd.Parameters.Add(new SqlParameter("SubjectID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SubjectID);


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
        public static int Delete(string  AreaID)
        {

            SqlCommand cmd = new SqlCommand("PRC_Area_Delete", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

   	cmd.Parameters.Add(new SqlParameter("AreaID", SqlDbType.Int)).Value =AreaID ;
 
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

