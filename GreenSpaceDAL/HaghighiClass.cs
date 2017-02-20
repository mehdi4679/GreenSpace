using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenSpaceDAL
{
    public class HaghighiClass
    {
        public static SqlConnection cnn = new SqlConnection(CSharp.PublicFunction.cnstr());
        public static int insert(String HaghighiName, String ManageName, String HaghighiTel, String HaghighiAdress, String RepresentativeMobile, String HaghighiyEmail, String ManageFamily, String PersonalID)
        {

            SqlCommand cmd = new SqlCommand("PRC_Haghighi_Insert", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion(); cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


            SqlParameter prmHaghighiName = new SqlParameter("HaghighiName", SqlDbType.NVarChar);
            prmHaghighiName.Value = HaghighiName;
            cmd.Parameters.Add(prmHaghighiName);

            SqlParameter prmManageFamily = new SqlParameter("HaghighiFamily", SqlDbType.NVarChar);
            prmManageFamily.Value = ManageFamily;
            cmd.Parameters.Add(prmManageFamily);

            SqlParameter prmManageName = new SqlParameter("ManageName", SqlDbType.NVarChar);
            prmManageName.Value = ManageName;
            cmd.Parameters.Add(prmManageName);


            SqlParameter prmHaghighiTel = new SqlParameter("HaghighiTel", SqlDbType.NVarChar);
            prmHaghighiTel.Value = HaghighiTel;
            cmd.Parameters.Add(prmHaghighiTel);


            SqlParameter prmHaghighiAdress = new SqlParameter("HaghighiAdress", SqlDbType.NVarChar);
            prmHaghighiAdress.Value = HaghighiAdress;
            cmd.Parameters.Add(prmHaghighiAdress);


            SqlParameter prmRepresentativeMobile = new SqlParameter("RepresentativeMobile", SqlDbType.NVarChar);
            prmRepresentativeMobile.Value = RepresentativeMobile;
            cmd.Parameters.Add(prmRepresentativeMobile);


            SqlParameter prmHaghighiyEmail = new SqlParameter("HaghighiyEmail", SqlDbType.NVarChar);
            prmHaghighiyEmail.Value = HaghighiyEmail;
            cmd.Parameters.Add(prmHaghighiyEmail);

            SqlParameter prmPersonalID = new SqlParameter("PersonalID", SqlDbType.NVarChar);
            prmPersonalID.Value = PersonalID;
            cmd.Parameters.Add(prmPersonalID);


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
        public static DataSet GetList(String HaghighiID, String HaghighiName, String ManageName, String HaghighiTel, String HaghighiAdress, String RepresentativeMobile, String HaghighiyEmail, String ManageFamily)
        {

            SqlCommand cmd = new SqlCommand("PRC_Haghighi_GetList", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID(); cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress(); cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS(); cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion(); cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();



            SqlParameter prmManageFamily = new SqlParameter("HaghighiFamily", SqlDbType.NVarChar);
            prmManageFamily.Value = Securenamespace.SecureData.CheckSecurity(ManageFamily);
            cmd.Parameters.Add(prmManageFamily);


            SqlParameter prmHaghighiID = new SqlParameter("HaghighiID", SqlDbType.Int);
            prmHaghighiID.Value = Securenamespace.SecureData.CheckSecurity(HaghighiID);
            cmd.Parameters.Add(prmHaghighiID);


            SqlParameter prmHaghighiName = new SqlParameter("HaghighiName", SqlDbType.NVarChar);
            prmHaghighiName.Value = Securenamespace.SecureData.CheckSecurity(HaghighiName);
            cmd.Parameters.Add(prmHaghighiName);


            SqlParameter prmManageName = new SqlParameter("ManageName", SqlDbType.NVarChar);
            prmManageName.Value = Securenamespace.SecureData.CheckSecurity(ManageName);
            cmd.Parameters.Add(prmManageName);


            SqlParameter prmHaghighiTel = new SqlParameter("HaghighiTel", SqlDbType.NVarChar);
            prmHaghighiTel.Value = Securenamespace.SecureData.CheckSecurity(HaghighiTel);
            cmd.Parameters.Add(prmHaghighiTel);


            SqlParameter prmHaghighiAdress = new SqlParameter("HaghighiAdress", SqlDbType.NVarChar);
            prmHaghighiAdress.Value = Securenamespace.SecureData.CheckSecurity(HaghighiAdress);
            cmd.Parameters.Add(prmHaghighiAdress);


            SqlParameter prmRepresentativeMobile = new SqlParameter("RepresentativeMobile", SqlDbType.NVarChar);
            prmRepresentativeMobile.Value = Securenamespace.SecureData.CheckSecurity(RepresentativeMobile);
            cmd.Parameters.Add(prmRepresentativeMobile);


            SqlParameter prmHaghighiyEmail = new SqlParameter("HaghighiyEmail", SqlDbType.NVarChar);
            prmHaghighiyEmail.Value = Securenamespace.SecureData.CheckSecurity(HaghighiyEmail);
            cmd.Parameters.Add(prmHaghighiyEmail);


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
        public static int Update(String HaghighiID, String HaghighiName, String ManageName, String HaghighiTel, String HaghighiAdress, String RepresentativeMobile, String HaghighiyEmail, String ManageFamily)
        {

            SqlCommand cmd = new SqlCommand("PRC_Haghighi_Update", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID(); cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress(); cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS(); cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion(); cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


            SqlParameter prmHaghighiID = new SqlParameter("HaghighiID", SqlDbType.Int);
            prmHaghighiID.Value = HaghighiID;
            cmd.Parameters.Add(prmHaghighiID);


            SqlParameter prmManageFamily = new SqlParameter("HaghighiFamily", SqlDbType.NVarChar);
            prmManageFamily.Value = ManageFamily;
            cmd.Parameters.Add(prmManageFamily);

            SqlParameter prmHaghighiName = new SqlParameter("HaghighiName", SqlDbType.NVarChar);
            prmHaghighiName.Value = HaghighiName;
            cmd.Parameters.Add(prmHaghighiName);


            SqlParameter prmManageName = new SqlParameter("ManageName", SqlDbType.NVarChar);
            prmManageName.Value = ManageName;
            cmd.Parameters.Add(prmManageName);


            SqlParameter prmHaghighiTel = new SqlParameter("HaghighiTel", SqlDbType.NVarChar);
            prmHaghighiTel.Value = HaghighiTel;
            cmd.Parameters.Add(prmHaghighiTel);


            SqlParameter prmHaghighiAdress = new SqlParameter("HaghighiAdress", SqlDbType.NVarChar);
            prmHaghighiAdress.Value = HaghighiAdress;
            cmd.Parameters.Add(prmHaghighiAdress);


            SqlParameter prmRepresentativeMobile = new SqlParameter("RepresentativeMobile", SqlDbType.NVarChar);
            prmRepresentativeMobile.Value = RepresentativeMobile;
            cmd.Parameters.Add(prmRepresentativeMobile);


            SqlParameter prmHaghighiyEmail = new SqlParameter("HaghighiyEmail", SqlDbType.NVarChar);
            prmHaghighiyEmail.Value = HaghighiyEmail;
            cmd.Parameters.Add(prmHaghighiyEmail);


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
        public static int Delete(int HaghighiID)
        {

            SqlCommand cmd = new SqlCommand("PRC_Haghighi_Delete", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;


            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID(); cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress(); cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS(); cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion(); cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();
            SqlParameter prmHaghighiID = new SqlParameter("HaghighiID", SqlDbType.Int);
            prmHaghighiID.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmHaghighiID);
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

        public static int UpdateCuttingTree(String HaghighiID, String CuttingTreeId, String LicensingTreeId)
        {

            SqlCommand cmd = new SqlCommand("PRC_CuttingTreeHaghighi_Update", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID(); cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress(); cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS(); cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion(); cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


            SqlParameter prmHaghighiID = new SqlParameter("HaghighiID", SqlDbType.Int);
            prmHaghighiID.Value = HaghighiID;
            cmd.Parameters.Add(prmHaghighiID);


            SqlParameter prmCuttingTreeId = new SqlParameter("CuttingTreeId", SqlDbType.Int);
            prmCuttingTreeId.Value = CuttingTreeId;
            cmd.Parameters.Add(prmCuttingTreeId);


            SqlParameter prmLicensingTreeId = new SqlParameter("LicensingTreeId", SqlDbType.Int);
            prmLicensingTreeId.Value = LicensingTreeId;
            cmd.Parameters.Add(prmLicensingTreeId);


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
