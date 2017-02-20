using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Collections;
using System.Data.SqlClient;


namespace TaxiDAL
{
    public class UsersClass
    {
        // @URLLog as nvarchar(Max), 
        //@UserTypeIDLog   as int, 
        //@UserIDLog   as int,
        //@OSLog   as nvarchar(Max),
        //@OSVerLog	   as nvarchar(Max),
        //@IpLog   as nvarchar(Max),


        public static SqlConnection cnn = new SqlConnection(CSharp.PublicFunction.cnstr());
        public static int insert(String UserID, String UserName, String Pass, String Name, String Famlily, String mobile, String semat, String Email, String mellicode, String Tel, String ISActive,
        String URLLog = "", String UserLogID = "", String UserTypeID = "", String IpLog = "", String OSVerLog = "", String OSLog = "", String Region="" )
        {

            SqlCommand cmd = new SqlCommand("PRC_Users_Insert", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
            cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();



            SqlParameter prmUserName = new SqlParameter("UserName", SqlDbType.NVarChar);
            prmUserName.Value = Securenamespace.SecureData.CheckSecurity(UserName);
            cmd.Parameters.Add(prmUserName);


            SqlParameter prmPass = new SqlParameter("Pass", SqlDbType.NVarChar);
            prmPass.Value = Securenamespace.SecureData.CheckSecurity(Pass);
            cmd.Parameters.Add(prmPass);


            SqlParameter prmName = new SqlParameter("Name", SqlDbType.NVarChar);
            prmName.Value = Securenamespace.SecureData.CheckSecurity(Name);
            cmd.Parameters.Add(prmName);


            SqlParameter prmFamlily = new SqlParameter("Famlily", SqlDbType.NVarChar);
            prmFamlily.Value = Securenamespace.SecureData.CheckSecurity(Famlily);
            cmd.Parameters.Add(prmFamlily);


            SqlParameter prmmobile = new SqlParameter("mobile", SqlDbType.NVarChar);
            prmmobile.Value = Securenamespace.SecureData.CheckSecurity(mobile);
            cmd.Parameters.Add(prmmobile);


            SqlParameter prmsemat = new SqlParameter("semat", SqlDbType.NVarChar);
            prmsemat.Value = Securenamespace.SecureData.CheckSecurity(semat);
            cmd.Parameters.Add(prmsemat);

            SqlParameter prmEmail = new SqlParameter("Email", SqlDbType.NVarChar);
            prmEmail.Value = Securenamespace.SecureData.CheckSecurity(Email);
            cmd.Parameters.Add(prmEmail);


            SqlParameter prmMelliCode = new SqlParameter("MelliCode", SqlDbType.NVarChar);
            prmMelliCode.Value = Securenamespace.SecureData.CheckSecurity(mellicode);
            cmd.Parameters.Add(prmMelliCode);


            SqlParameter prmPhone = new SqlParameter("Phone", SqlDbType.NVarChar);
            prmPhone.Value = Securenamespace.SecureData.CheckSecurity(Tel);
            cmd.Parameters.Add(prmPhone);

            SqlParameter prmIsActive = new SqlParameter("IsActive", SqlDbType.NVarChar);
            prmIsActive.Value = Securenamespace.SecureData.CheckSecurity(ISActive);
            cmd.Parameters.Add(prmIsActive);

            SqlParameter prmResult = new SqlParameter("Result", SqlDbType.Int);
            prmResult.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmResult);

            SqlParameter prmRegion = new SqlParameter("Region", SqlDbType.NVarChar);
            prmRegion.Value = Securenamespace.SecureData.CheckSecurity(Region);
            cmd.Parameters.Add(prmRegion);
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
        public static DataSet GetList(String UserID, String UserName, String Pass, String Name, String Famlily, String mobile, String semat, String Email, String mellicode, String Tel, String ISActive,
        String URLLog = "", String UserLogID = "", String UserTypeID = "", String IpLog = "", String OSVerLog = "", String OSLog = "")
        {

            SqlCommand cmd = new SqlCommand("PRC_Users_GetList", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
            cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

            SqlParameter prmUserID = new SqlParameter("UserID", SqlDbType.NVarChar);
            prmUserID.Value = Securenamespace.SecureData.CheckSecurity(UserID);
            cmd.Parameters.Add(prmUserID);

            SqlParameter prmUserName = new SqlParameter("UserName", SqlDbType.NVarChar);
            prmUserName.Value = Securenamespace.SecureData.CheckSecurity(UserName);
            cmd.Parameters.Add(prmUserName);


            SqlParameter prmPass = new SqlParameter("Pass", SqlDbType.NVarChar);
            prmPass.Value = Securenamespace.SecureData.CheckSecurity(Pass);
            cmd.Parameters.Add(prmPass);


            SqlParameter prmName = new SqlParameter("Name", SqlDbType.NVarChar);
            prmName.Value = Securenamespace.SecureData.CheckSecurity(Name);
            cmd.Parameters.Add(prmName);


            SqlParameter prmFamlily = new SqlParameter("Famlily", SqlDbType.NVarChar);
            prmFamlily.Value = Securenamespace.SecureData.CheckSecurity(Famlily);
            cmd.Parameters.Add(prmFamlily);


            SqlParameter prmmobile = new SqlParameter("mobile", SqlDbType.NVarChar);
            prmmobile.Value = Securenamespace.SecureData.CheckSecurity(mobile);
            cmd.Parameters.Add(prmmobile);


            SqlParameter prmsemat = new SqlParameter("semat", SqlDbType.NVarChar);
            prmsemat.Value = Securenamespace.SecureData.CheckSecurity(semat);
            cmd.Parameters.Add(prmsemat);

            SqlParameter prmEmail = new SqlParameter("Email", SqlDbType.NVarChar);
            prmEmail.Value = Securenamespace.SecureData.CheckSecurity(Email);
            cmd.Parameters.Add(prmEmail);


            SqlParameter prmMelliCode = new SqlParameter("MelliCode", SqlDbType.NVarChar);
            prmMelliCode.Value = Securenamespace.SecureData.CheckSecurity(mellicode);
            cmd.Parameters.Add(prmMelliCode);


            SqlParameter prmPhone = new SqlParameter("Phone", SqlDbType.NVarChar);
            prmPhone.Value = Securenamespace.SecureData.CheckSecurity(Tel);
            cmd.Parameters.Add(prmPhone);

            SqlParameter prmIsActive = new SqlParameter("IsActive", SqlDbType.NVarChar);
            prmIsActive.Value = Securenamespace.SecureData.CheckSecurity(ISActive);
            cmd.Parameters.Add(prmIsActive);



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
                 if(cnn.State==  ConnectionState.Open)
                cnn.Close();
                //ds.Dispose();
            }

        }
      
        public static DataSet GetListNazer(String UserID, String UserName, String Pass, String Name, String Famlily, String mobile, String semat, String Email, String mellicode, String Tel, String ISActive,
        String URLLog = "", String UserLogID = "", String UserTypeID = "", String IpLog = "", String OSVerLog = "", String OSLog = "")
        {

            SqlCommand cmd = new SqlCommand("PRC_Users_GetListNazer", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
            cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

            SqlParameter prmUserID = new SqlParameter("UserID", SqlDbType.NVarChar);
            prmUserID.Value = Securenamespace.SecureData.CheckSecurity(UserID);
            cmd.Parameters.Add(prmUserID);

            SqlParameter prmUserName = new SqlParameter("UserName", SqlDbType.NVarChar);
            prmUserName.Value = Securenamespace.SecureData.CheckSecurity(UserName);
            cmd.Parameters.Add(prmUserName);


            SqlParameter prmPass = new SqlParameter("Pass", SqlDbType.NVarChar);
            prmPass.Value = Securenamespace.SecureData.CheckSecurity(Pass);
            cmd.Parameters.Add(prmPass);


            SqlParameter prmName = new SqlParameter("Name", SqlDbType.NVarChar);
            prmName.Value = Securenamespace.SecureData.CheckSecurity(Name);
            cmd.Parameters.Add(prmName);


            SqlParameter prmFamlily = new SqlParameter("Famlily", SqlDbType.NVarChar);
            prmFamlily.Value = Securenamespace.SecureData.CheckSecurity(Famlily);
            cmd.Parameters.Add(prmFamlily);


            SqlParameter prmmobile = new SqlParameter("mobile", SqlDbType.NVarChar);
            prmmobile.Value = Securenamespace.SecureData.CheckSecurity(mobile);
            cmd.Parameters.Add(prmmobile);


            SqlParameter prmsemat = new SqlParameter("semat", SqlDbType.NVarChar);
            prmsemat.Value = Securenamespace.SecureData.CheckSecurity(semat);
            cmd.Parameters.Add(prmsemat);

            SqlParameter prmEmail = new SqlParameter("Email", SqlDbType.NVarChar);
            prmEmail.Value = Securenamespace.SecureData.CheckSecurity(Email);
            cmd.Parameters.Add(prmEmail);


            SqlParameter prmMelliCode = new SqlParameter("MelliCode", SqlDbType.NVarChar);
            prmMelliCode.Value = Securenamespace.SecureData.CheckSecurity(mellicode);
            cmd.Parameters.Add(prmMelliCode);


            SqlParameter prmPhone = new SqlParameter("Phone", SqlDbType.NVarChar);
            prmPhone.Value = Securenamespace.SecureData.CheckSecurity(Tel);
            cmd.Parameters.Add(prmPhone);

            SqlParameter prmIsActive = new SqlParameter("IsActive", SqlDbType.NVarChar);
            prmIsActive.Value = Securenamespace.SecureData.CheckSecurity(ISActive);
            cmd.Parameters.Add(prmIsActive);



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
                //ds.Dispose();
            }

        }

        //---------------------------------------------------------------------------------------------------------
        public static int Update(String UserID, String UserName, String Pass, String Name, String Famlily, String mobile, String semat, String Email, String mellicode, String Tel, String ISActive,
        String URLLog = "", String UserLogID = "", String UserTypeID = "", String IpLog = "", String OSVerLog = "", String OSLog = "", String Region="")
        {



            SqlCommand cmd = new SqlCommand("PRC_Users_Update", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
            cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

            SqlParameter prmUserID = new SqlParameter("UserID", SqlDbType.NVarChar);
            prmUserID.Value = Securenamespace.SecureData.CheckSecurity(UserID);
            cmd.Parameters.Add(prmUserID);

            SqlParameter prmUserName = new SqlParameter("UserName", SqlDbType.NVarChar);
            prmUserName.Value = Securenamespace.SecureData.CheckSecurity(UserName);
            cmd.Parameters.Add(prmUserName);


            SqlParameter prmPass = new SqlParameter("Pass", SqlDbType.NVarChar);
            prmPass.Value = Securenamespace.SecureData.CheckSecurity(Pass);
            cmd.Parameters.Add(prmPass);


            SqlParameter prmName = new SqlParameter("Name", SqlDbType.NVarChar);
            prmName.Value = Securenamespace.SecureData.CheckSecurity(Name);
            cmd.Parameters.Add(prmName);


            SqlParameter prmFamlily = new SqlParameter("Famlily", SqlDbType.NVarChar);
            prmFamlily.Value = Securenamespace.SecureData.CheckSecurity(Famlily);
            cmd.Parameters.Add(prmFamlily);


            SqlParameter prmmobile = new SqlParameter("mobile", SqlDbType.NVarChar);
            prmmobile.Value = Securenamespace.SecureData.CheckSecurity(mobile);
            cmd.Parameters.Add(prmmobile);


            SqlParameter prmsemat = new SqlParameter("semat", SqlDbType.NVarChar);
            prmsemat.Value = Securenamespace.SecureData.CheckSecurity(semat);
            cmd.Parameters.Add(prmsemat);

            SqlParameter prmEmail = new SqlParameter("Email", SqlDbType.NVarChar);
            prmEmail.Value = Securenamespace.SecureData.CheckSecurity(Email);
            cmd.Parameters.Add(prmEmail);


            SqlParameter prmMelliCode = new SqlParameter("MelliCode", SqlDbType.NVarChar);
            prmMelliCode.Value = Securenamespace.SecureData.CheckSecurity(mellicode);
            cmd.Parameters.Add(prmMelliCode);


            SqlParameter prmPhone = new SqlParameter("Phone", SqlDbType.NVarChar);
            prmPhone.Value = Securenamespace.SecureData.CheckSecurity(Tel);
            cmd.Parameters.Add(prmPhone);

            SqlParameter prmIsActive = new SqlParameter("IsActive", SqlDbType.NVarChar);
            prmIsActive.Value = Securenamespace.SecureData.CheckSecurity(ISActive);
            cmd.Parameters.Add(prmIsActive);


            SqlParameter prmResult = new SqlParameter("Result", SqlDbType.Int);
            prmResult.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmResult);

            SqlParameter prmRegion = new SqlParameter("Region", SqlDbType.NVarChar);
            prmRegion.Value = Securenamespace.SecureData.CheckSecurity(Region);
            cmd.Parameters.Add(prmRegion);
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
        public static int Delete(int UserID,
        String URLLog = "", String UserLogID = "", String UserTypeID = "", String IpLog = "", String OSVerLog = "", String OSLog = "")
        {

            SqlCommand cmd = new SqlCommand("PRC_Users_Delete", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
            cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


            SqlParameter prmUserID = new SqlParameter("UserID", SqlDbType.Int);
            prmUserID.Value = Securenamespace.SecureData.CheckSecurity(UserID.ToString());
            cmd.Parameters.Add(prmUserID);
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
