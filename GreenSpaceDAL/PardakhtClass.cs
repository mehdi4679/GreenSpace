using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenSpaceDAL
{
  public   class PardakhtClass
    {
        public static SqlConnection cnn = new SqlConnection(CSharp.PublicFunction.cnstr());
        public static int insert(String FishNum, String Desc, String MablaghFinal, String PardakhtStatusid, String CuttingTreeId, String LicensingId, String PardakhtDate)
        {

            SqlCommand cmd = new SqlCommand("PRC_Pardakht_Insert", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID(); cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress(); cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS(); cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion(); cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


            //SqlParameter prmtekrarsalane = new SqlParameter("PardakhtStatusid", SqlDbType.Int);
            //prmtekrarsalane.Value = tekrarsalane;
            //cmd.Parameters.Add(prmtekrarsalane);


            SqlParameter prmFishNum = new SqlParameter("FishNum", SqlDbType.Int);
            prmFishNum.Value = FishNum;
            cmd.Parameters.Add(prmFishNum);


            SqlParameter prmDesc = new SqlParameter("Desc", SqlDbType.NVarChar );
            prmDesc.Value = Desc;
            cmd.Parameters.Add(prmDesc);


            SqlParameter prmMablaghFinal = new SqlParameter("MablaghFinal", SqlDbType.Int);
            prmMablaghFinal.Value = MablaghFinal;
            cmd.Parameters.Add(prmMablaghFinal);

            SqlParameter prmPardakhtStatusid = new SqlParameter("PardakhtStatusid", SqlDbType.Int);
            prmPardakhtStatusid.Value = PardakhtStatusid;
            cmd.Parameters.Add(prmPardakhtStatusid);

            SqlParameter prmCuttingTreeId = new SqlParameter("CuttingTreeId", SqlDbType.Int);
            prmCuttingTreeId.Value = CuttingTreeId;
            cmd.Parameters.Add(prmCuttingTreeId);

            SqlParameter prmLicensingId = new SqlParameter("LicensingId", SqlDbType.Int);
            prmLicensingId.Value = LicensingId;
            cmd.Parameters.Add(prmLicensingId);


            SqlParameter prmPardakhtDate = new SqlParameter("PardakhtDate", SqlDbType.Date);
            prmPardakhtDate.Value = DateConvert.sh2m(PardakhtDate);
            cmd.Parameters.Add(prmPardakhtDate);

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
        public static DataSet GetList(String PardakhtId, String FishNum, String Desc, String MablaghFinal, String PardakhtStatusid, String CuttingTreeId, String LicensingId, String PardakhtDate)
        {

            SqlCommand cmd = new SqlCommand("PRC_Pardakht_GetList", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID(); cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress(); cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS(); cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion(); cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


            SqlParameter prmPardakhtId = new SqlParameter("PardakhtId", SqlDbType.Int);
            prmPardakhtId.Value = Securenamespace.SecureData.CheckSecurity(PardakhtId);
            cmd.Parameters.Add(prmPardakhtId);

            SqlParameter prmFishNum = new SqlParameter("FishNum", SqlDbType.Int);
            prmFishNum.Value = Securenamespace.SecureData.CheckSecurity(FishNum);
            cmd.Parameters.Add(prmFishNum);


            SqlParameter prmDesc = new SqlParameter("Desc", SqlDbType.NVarChar);
            prmDesc.Value = Securenamespace.SecureData.CheckSecurity(Desc);
            cmd.Parameters.Add(prmDesc);


            SqlParameter prmMablaghFinal = new SqlParameter("MablaghFinal", SqlDbType.Int);
            prmMablaghFinal.Value = Securenamespace.SecureData.CheckSecurity(MablaghFinal);
            cmd.Parameters.Add(prmMablaghFinal);

            SqlParameter prmPardakhtStatusid = new SqlParameter("PardakhtStatusid", SqlDbType.Int);
            prmPardakhtStatusid.Value = Securenamespace.SecureData.CheckSecurity(PardakhtStatusid);
            cmd.Parameters.Add(prmPardakhtStatusid);

            SqlParameter prmCuttingTreeId = new SqlParameter("CuttingTreeId", SqlDbType.Int);
            prmCuttingTreeId.Value = Securenamespace.SecureData.CheckSecurity(CuttingTreeId);
            cmd.Parameters.Add(prmCuttingTreeId);

            SqlParameter prmLicensingId = new SqlParameter("LicensingId", SqlDbType.Int);
            prmLicensingId.Value = Securenamespace.SecureData.CheckSecurity(LicensingId);
            cmd.Parameters.Add(prmLicensingId);

            SqlParameter prmPardakhtDate = new SqlParameter("PardakhtDate", SqlDbType.Date);
            if (PardakhtDate != null)
                prmPardakhtDate.Value = Securenamespace.SecureData.CheckSecurity(DateConvert.sh2m(PardakhtDate));
            else prmPardakhtDate.Value = null;
            cmd.Parameters.Add(prmPardakhtDate);




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
        public static int Update(String PardakhtId, String FishNum, String Desc, String MablaghFinal, String PardakhtStatusid, String CuttingTreeId, String LicensingId, String PardakhtDate)
        {

            SqlCommand cmd = new SqlCommand("PRC_Pardakht_Update", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID(); cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress(); cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS(); cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion(); cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


            SqlParameter prmPardakhtId = new SqlParameter("PardakhtId", SqlDbType.Int);
            prmPardakhtId.Value = PardakhtId;
            cmd.Parameters.Add(prmPardakhtId);

            SqlParameter prmFishNum = new SqlParameter("FishNum", SqlDbType.Int);
            prmFishNum.Value = FishNum;
            cmd.Parameters.Add(prmFishNum);


            SqlParameter prmDesc = new SqlParameter("Desc", SqlDbType.NVarChar);
            prmDesc.Value = Desc;
            cmd.Parameters.Add(prmDesc);


            SqlParameter prmMablaghFinal = new SqlParameter("MablaghFinal", SqlDbType.Int);
            prmMablaghFinal.Value = MablaghFinal;
            cmd.Parameters.Add(prmMablaghFinal);

            SqlParameter prmPardakhtStatusid = new SqlParameter("PardakhtStatusid", SqlDbType.Int);
            prmPardakhtStatusid.Value = PardakhtStatusid;
            cmd.Parameters.Add(prmPardakhtStatusid);

            SqlParameter prmCuttingTreeId = new SqlParameter("CuttingTreeId", SqlDbType.Int);
            prmCuttingTreeId.Value = CuttingTreeId;
            cmd.Parameters.Add(prmCuttingTreeId);

            SqlParameter prmLicensingId = new SqlParameter("LicensingId", SqlDbType.Int);
            prmLicensingId.Value = LicensingId;
            cmd.Parameters.Add(prmLicensingId);


            SqlParameter prmPardakhtDate = new SqlParameter("PardakhtDate", SqlDbType.Date);
            prmPardakhtDate.Value = DateConvert.sh2m(PardakhtDate);
            cmd.Parameters.Add(prmPardakhtDate);



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
        public static int Delete(int id)
        {

            SqlCommand cmd = new SqlCommand("PRC_Pardakht_Delete", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;


            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID(); cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress(); cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS(); cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion(); cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();
            SqlParameter prmid = new SqlParameter("id", SqlDbType.Int);
            prmid.Value = id;
            cmd.Parameters.Add(prmid);
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