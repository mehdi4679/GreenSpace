using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenSpaceDAL
{
 public    class TreeBonCutting
 {
  public static SqlConnection cnn = new SqlConnection(CSharp.PublicFunction.cnstr());
  public static int insert(String TreeTypeId, String Count, String StreetTypeid, String CuttingTreeid, String Bon, String LicensingId, String ZaribBazdarnde, String KhesaratPrecent, String Jabejaei, String ZaribMandegari)
        {

            SqlCommand cmd = new SqlCommand("PRC_TreeBonCutting_Insert", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID(); cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress(); cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS(); cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion(); cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


            SqlParameter prmTreeTypeId = new SqlParameter("TreeTypeId", SqlDbType.Int);
            prmTreeTypeId.Value = TreeTypeId;
            cmd.Parameters.Add(prmTreeTypeId);

            //SqlParameter prmKhesaratPrecent = new SqlParameter("KhesaratPrecent", SqlDbType.Int);
            //prmKhesaratPrecent.Value = KhesaratPrecent;
            //cmd.Parameters.Add(prmKhesaratPrecent);

            cmd.Parameters.AddWithValue("KhesaratPrecent", KhesaratPrecent);

            cmd.Parameters.AddWithValue("Jabejaei", Jabejaei);
            //SqlParameter prmJabejaei = new SqlParameter("Jabejaei", SqlDbType.Int);
            //prmJabejaei.Value = Jabejaei;
            //cmd.Parameters.Add(prmJabejaei);

            //SqlParameter prmZaribMandegari = new SqlParameter("ZaribMandegari", SqlDbType.Int);
            //prmZaribMandegari.Value = ZaribMandegari;
            //cmd.Parameters.Add(prmZaribMandegari);

            cmd.Parameters.AddWithValue("ZaribMandegari", ZaribMandegari);


            SqlParameter prmCount = new SqlParameter("Count", SqlDbType.Int);
            prmCount.Value = Count;
            cmd.Parameters.Add(prmCount);


            SqlParameter prmStreetTypeid = new SqlParameter("StreetTypeid", SqlDbType.Int);
            prmStreetTypeid.Value = StreetTypeid;
            cmd.Parameters.Add(prmStreetTypeid);

            SqlParameter prmCuttingTreeid = new SqlParameter("CuttingTreeid", SqlDbType.Int);
            prmCuttingTreeid.Value = CuttingTreeid;
            cmd.Parameters.Add(prmCuttingTreeid);

            SqlParameter prmBon = new SqlParameter("Bon", SqlDbType.Int);
            prmBon.Value = Bon;
            cmd.Parameters.Add(prmBon);

            SqlParameter prmLicensingId = new SqlParameter("LicensingId", SqlDbType.Int);
            prmLicensingId.Value = LicensingId;
            cmd.Parameters.Add(prmLicensingId);

            //SqlParameter prmZaribBazdarnde = new SqlParameter("ZaribBazdarnde", SqlDbType.Int);
            //prmZaribBazdarnde.Value = ZaribBazdarnde;
            //cmd.Parameters.Add(prmZaribBazdarnde);

            cmd.Parameters.AddWithValue("ZaribBazdarnde", ZaribBazdarnde);

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
  public static DataSet GetList(String TreeBonCuttingId, String TreeTypeId, String Count, String StreetTypeid, String CuttingTreeid, String Bon, String LicensingId, String ZaribBazdarnde, String MantaghehId, String KhesaratPrecent, String Jabejaei, String ZaribMandegari)
        {

            SqlCommand cmd = new SqlCommand("PRC_TreeBonCutting_GetList", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID(); cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress(); cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS(); cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion(); cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


            SqlParameter prmTreeBonCuttingId = new SqlParameter("TreeBonCuttingId", SqlDbType.Int);
            prmTreeBonCuttingId.Value = TreeBonCuttingId;
            cmd.Parameters.Add(prmTreeBonCuttingId);


            cmd.Parameters.AddWithValue("Jabejaei", Jabejaei);
            //SqlParameter prmJabejaei = new SqlParameter("Jabejaei", SqlDbType.Int);
            //prmJabejaei.Value = Jabejaei;
            //cmd.Parameters.Add(prmJabejaei);

            //SqlParameter prmZaribMandegari = new SqlParameter("ZaribMandegari", SqlDbType.Int);
            //prmZaribMandegari.Value = ZaribMandegari;
            //cmd.Parameters.Add(prmZaribMandegari);

            cmd.Parameters.AddWithValue("ZaribMandegari", ZaribMandegari);


            //SqlParameter prmKhesaratPrecent = new SqlParameter("KhesaratPrecent", SqlDbType.Int);
            //prmKhesaratPrecent.Value = KhesaratPrecent;
            //cmd.Parameters.Add(prmKhesaratPrecent);


            cmd.Parameters.AddWithValue("KhesaratPrecent", KhesaratPrecent);


            SqlParameter prmLicensingId = new SqlParameter("LicensingId", SqlDbType.Int);
            prmLicensingId.Value = LicensingId;
            cmd.Parameters.Add(prmLicensingId);

            SqlParameter prmMantaghehId = new SqlParameter("MantaghehId", SqlDbType.Int);
            prmMantaghehId.Value = MantaghehId;
            cmd.Parameters.Add(prmMantaghehId);

            SqlParameter prmTreeTypeId = new SqlParameter("TreeTypeId", SqlDbType.Int);
            prmTreeTypeId.Value = TreeTypeId;
            cmd.Parameters.Add(prmTreeTypeId);


            SqlParameter prmCount = new SqlParameter("Count", SqlDbType.Int);
            prmCount.Value = Count;
            cmd.Parameters.Add(prmCount);


            SqlParameter prmStreetTypeid = new SqlParameter("StreetTypeid", SqlDbType.Int);
            prmStreetTypeid.Value = StreetTypeid;
            cmd.Parameters.Add(prmStreetTypeid);

            SqlParameter prmCuttingTreeid = new SqlParameter("CuttingTreeid", SqlDbType.Int);
            prmCuttingTreeid.Value = CuttingTreeid;
            cmd.Parameters.Add(prmCuttingTreeid);
            SqlParameter prmBon = new SqlParameter("Bon", SqlDbType.Int);
            prmBon.Value = Bon;
            cmd.Parameters.Add(prmBon);

            //SqlParameter prmZaribBazdarnde = new SqlParameter("ZaribBazdarnde", SqlDbType.Int);
            //prmZaribBazdarnde.Value = ZaribBazdarnde;
            //cmd.Parameters.Add(prmZaribBazdarnde);

            cmd.Parameters.AddWithValue("ZaribBazdarnde", ZaribBazdarnde);


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
  public static int Update(String TreeBonCuttingId, String TreeTypeId, String Count, String StreetTypeid, String CuttingTreeid, String Bon, String LicensingId, string ZaribBazdarnde, string KhesaratPrecent, string Jabejaei, string ZaribMandegari)
        {

            SqlCommand cmd = new SqlCommand("PRC_TreeBonCutting_Update", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID(); cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress(); cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS(); cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion(); cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


            //SqlParameter prmTreeBonCuttingId = new SqlParameter("TreeBonCuttingId", SqlDbType.Int);
            //prmTreeBonCuttingId.Value = TreeBonCuttingId;
            //cmd.Parameters.Add(prmTreeBonCuttingId);

            cmd.Parameters.AddWithValue("TreeBonCuttingId", TreeBonCuttingId);

            //SqlParameter prmZaribBazdarnde = new SqlParameter("ZaribBazdarnde", SqlDbType.Int);
            //prmZaribBazdarnde.Value = ZaribBazdarnde;
            //cmd.Parameters.Add(prmZaribBazdarnde);


            cmd.Parameters.AddWithValue("ZaribBazdarnde", ZaribBazdarnde);

            //SqlParameter prmJabejaei = new SqlParameter("Jabejaei", SqlDbType.Int);
            //prmJabejaei.Value = Jabejaei;
            //cmd.Parameters.Add(prmJabejaei);

            cmd.Parameters.AddWithValue("Jabejaei", Jabejaei);

            //SqlParameter prmZaribMandegari = new SqlParameter("ZaribMandegari", SqlDbType.Int);
            //prmZaribMandegari.Value = ZaribMandegari;
            //cmd.Parameters.Add(prmZaribMandegari);

            cmd.Parameters.AddWithValue("ZaribMandegari", ZaribMandegari);

            //SqlParameter prmKhesaratPrecent = new SqlParameter("KhesaratPrecent", SqlDbType.Int);
            //prmKhesaratPrecent.Value = KhesaratPrecent;
            //cmd.Parameters.Add(prmKhesaratPrecent);


            cmd.Parameters.AddWithValue("KhesaratPrecent", KhesaratPrecent);

            SqlParameter prmTreeTypeId = new SqlParameter("TreeTypeId", SqlDbType.Int);
            prmTreeTypeId.Value = TreeTypeId;
            cmd.Parameters.Add(prmTreeTypeId);


            SqlParameter prmCount = new SqlParameter("Count", SqlDbType.Int);
            prmCount.Value = Count;
            cmd.Parameters.Add(prmCount);


            SqlParameter prmStreetTypeid = new SqlParameter("StreetTypeid", SqlDbType.Int);
            prmStreetTypeid.Value = StreetTypeid;
            cmd.Parameters.Add(prmStreetTypeid);

            SqlParameter prmCuttingTreeid = new SqlParameter("CuttingTreeid", SqlDbType.Int);
            prmCuttingTreeid.Value = CuttingTreeid;
            cmd.Parameters.Add(prmCuttingTreeid);

            SqlParameter prmBon = new SqlParameter("Bon", SqlDbType.Int);
            prmBon.Value = Bon;
            cmd.Parameters.Add(prmBon);
            SqlParameter prmLicensingId = new SqlParameter("LicensingId", SqlDbType.Int);
            prmLicensingId.Value = LicensingId;
            cmd.Parameters.Add(prmLicensingId);
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

            SqlCommand cmd = new SqlCommand("PRC_TreeBonCutting_Delete", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;


            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID(); cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress(); cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS(); cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion(); cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();
            SqlParameter prmid = new SqlParameter("TreeBonCuttingId", SqlDbType.Int);
            //prmid.Direction = ParameterDirection.Output;
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
