using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenSpaceDAL
{
    public class CuttingTreeClass
    {
        public static SqlConnection cnn = new SqlConnection(CSharp.PublicFunction.cnstr());
        public static int insert(String TreeTypeId, String Count, String Bon, String date, String Address, String x, String y, String StreetTypeid, String PersonalId, String Peyman, String Peymanid, String MantagheId, Boolean Mojavez, String HaghighiId, String LicesnceTypeid, String Title, String Desc,String recRoleID, String status)
        {

            SqlCommand cmd = new SqlCommand("PRC_CuttingTree_Insert", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
            cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


            SqlParameter prmTreeTypeId = new SqlParameter("TreeTypeId", SqlDbType.NVarChar);
            prmTreeTypeId.Value = TreeTypeId;
            cmd.Parameters.Add(prmTreeTypeId);

            SqlParameter prmTitle = new SqlParameter("Title", SqlDbType.NVarChar);
            prmTitle.Value = Title;
            cmd.Parameters.Add(prmTitle);

            SqlParameter prmDesc = new SqlParameter("Desc", SqlDbType.NVarChar);
            prmDesc.Value = Desc;
            cmd.Parameters.Add(prmDesc);


            SqlParameter prmCount = new SqlParameter("Count", SqlDbType.NVarChar);
            prmCount.Value = Count;
            cmd.Parameters.Add(prmCount);


            SqlParameter prmBon = new SqlParameter("Bon", SqlDbType.NVarChar);
            prmBon.Value = Bon;
            cmd.Parameters.Add(prmBon);


            SqlParameter prmdate = new SqlParameter("date", SqlDbType.Date);
            prmdate.Value = DateConvert.sh2m(date);
            //prmdate.Value = DateConvert.shamsitomiladi(date);
            cmd.Parameters.Add(prmdate);


            SqlParameter prmAddress = new SqlParameter("Address", SqlDbType.NVarChar);
            prmAddress.Value = Address;
            cmd.Parameters.Add(prmAddress);


            //SqlParameter prmx = new SqlParameter("x", SqlDbType.NVarChar);
            //prmx.Value = x;
            //cmd.Parameters.Add(prmx);


            //SqlParameter prmy = new SqlParameter("y", SqlDbType.NVarChar);
            //prmy.Value = y;
            //cmd.Parameters.Add(prmy);



            //SqlParameter prmimage = new SqlParameter("image", SqlDbType.image);
            //prmimage.Value = image;
            //cmd.Parameters.Add(prmimage);


            SqlParameter prmStreetTypeid = new SqlParameter("StreetTypeid", SqlDbType.NVarChar);
            prmStreetTypeid.Value = StreetTypeid;
            cmd.Parameters.Add(prmStreetTypeid);


            SqlParameter prmPersonalId = new SqlParameter("PersonalId", SqlDbType.NVarChar);
            prmPersonalId.Value = PersonalId;
            cmd.Parameters.Add(prmPersonalId);


            SqlParameter prmPeyman = new SqlParameter("Peyman", SqlDbType.Bit);
            prmPeyman.Value = Peyman;
            cmd.Parameters.Add(prmPeyman);


            SqlParameter prmPeymanid = new SqlParameter("Peymanid", SqlDbType.NVarChar);
            prmPeymanid.Value = Peymanid;
            cmd.Parameters.Add(prmPeymanid);


            SqlParameter prmMantagheId = new SqlParameter("MantagheId", SqlDbType.NVarChar);
            prmMantagheId.Value = MantagheId;
            cmd.Parameters.Add(prmMantagheId);


            SqlParameter prmMojavez = new SqlParameter("Mojavez", SqlDbType.Bit);
            prmMojavez.Value = Mojavez;
            cmd.Parameters.Add(prmMojavez);


            SqlParameter prmHaghighiId = new SqlParameter("HaghighiId", SqlDbType.NVarChar);
            prmHaghighiId.Value = HaghighiId;
            cmd.Parameters.Add(prmHaghighiId);


            SqlParameter prmLicesnceTypeid = new SqlParameter("LicesnceTypeid", SqlDbType.NVarChar);
            prmLicesnceTypeid.Value = LicesnceTypeid;
            cmd.Parameters.Add(prmLicesnceTypeid);

            SqlParameter prmrecRoleID = new SqlParameter("recRoleID", SqlDbType.NVarChar);
            prmrecRoleID.Value = recRoleID;
            cmd.Parameters.Add(prmrecRoleID);

            SqlParameter prmstatus = new SqlParameter("status", SqlDbType.NVarChar);
            prmstatus.Value = status;
            cmd.Parameters.Add(prmstatus);


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
        public static DataSet GetList(String id, String TreeTypeId, String Count, String Bon, String date, String Address, String x, String y, String StreetTypeid, String PersonalId, String Peyman, String Peymanid, String MantagheId, String Mojavez, String HaghighiId, String LicesnceTypeid, String Title, String Desc,String recRoleID,String status)
        {

            SqlCommand cmd = new SqlCommand("PRC_CuttingTree_GetList", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID(); cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress(); cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS(); cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion(); cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


            SqlParameter prmid = new SqlParameter("id", SqlDbType.Int);
            prmid.Value = id;
            cmd.Parameters.Add(prmid);


            SqlParameter prmTreeTypeId = new SqlParameter("TreeTypeId", SqlDbType.Int);
            prmTreeTypeId.Value = TreeTypeId;
            cmd.Parameters.Add(prmTreeTypeId);

            SqlParameter prmTitle = new SqlParameter("Title", SqlDbType.NVarChar);
            prmTitle.Value = Title;
            cmd.Parameters.Add(prmTitle);

            SqlParameter prmDesc = new SqlParameter("Desc", SqlDbType.NVarChar);
            prmDesc.Value = Desc;
            cmd.Parameters.Add(prmDesc);


            SqlParameter prmCount = new SqlParameter("Count", SqlDbType.Int);
            prmCount.Value = Count;
            cmd.Parameters.Add(prmCount);


            SqlParameter prmBon = new SqlParameter("Bon", SqlDbType.Int);
            prmBon.Value = Bon;
            cmd.Parameters.Add(prmBon);


            SqlParameter prmdate = new SqlParameter("date", SqlDbType.NVarChar);
            prmdate.Value = date;
            cmd.Parameters.Add(prmdate);


            SqlParameter prmAddress = new SqlParameter("Address", SqlDbType.NVarChar);
            prmAddress.Value = Address;
            cmd.Parameters.Add(prmAddress);


            //SqlParameter prmx = new SqlParameter("x", SqlDbType.NVarChar);
            //prmx.Value = x;
            //cmd.Parameters.Add(prmx);


            //SqlParameter prmy = new SqlParameter("y", SqlDbType.NVarChar);
            //prmy.Value = y;
            //cmd.Parameters.Add(prmy);


            //SqlParameter prmimage = new SqlParameter("image", SqlDbType.image);
            //prmimage.Value = image;
            //cmd.Parameters.Add(prmimage);


            SqlParameter prmStreetTypeid = new SqlParameter("StreetTypeid", SqlDbType.Int);
            prmStreetTypeid.Value = StreetTypeid;
            cmd.Parameters.Add(prmStreetTypeid);


            SqlParameter prmPersonalId = new SqlParameter("PersonalId", SqlDbType.Int);
            prmPersonalId.Value = PersonalId;
            cmd.Parameters.Add(prmPersonalId);


            SqlParameter prmPeyman = new SqlParameter("Peyman", SqlDbType.Int);
            prmPeyman.Value = Peyman;
            cmd.Parameters.Add(prmPeyman);


            SqlParameter prmPeymanid = new SqlParameter("Peymanid", SqlDbType.Int);
            prmPeymanid.Value = Peymanid;
            cmd.Parameters.Add(prmPeymanid);


            SqlParameter prmMantagheId = new SqlParameter("MantagheId", SqlDbType.Int);
            prmMantagheId.Value = MantagheId;
            cmd.Parameters.Add(prmMantagheId);


            SqlParameter prmMojavez = new SqlParameter("Mojavez", SqlDbType.Int);
            prmMojavez.Value = Mojavez;
            cmd.Parameters.Add(prmMojavez);


            SqlParameter prmHaghighiId = new SqlParameter("HaghighiId", SqlDbType.Int);
            prmHaghighiId.Value = HaghighiId;
            cmd.Parameters.Add(prmHaghighiId);


            SqlParameter prmLicesnceTypeid = new SqlParameter("LicesnceTypeid", SqlDbType.Int);
            prmLicesnceTypeid.Value = LicesnceTypeid;
            cmd.Parameters.Add(prmLicesnceTypeid);

            SqlParameter prmrecRoleID = new SqlParameter("recRoleID", SqlDbType.NVarChar);
            prmrecRoleID.Value = recRoleID;
            cmd.Parameters.Add(prmrecRoleID);

            SqlParameter prmstatus = new SqlParameter("status", SqlDbType.NVarChar);
            prmstatus.Value = status;
            cmd.Parameters.Add(prmstatus);

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


        public static DataSet RepGetList(String id, String dateFirst, String dateEnd, String MantagheId)
        {

            SqlCommand cmd = new SqlCommand("Rep_CuttingTree_GetList", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID(); cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress(); cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS(); cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion(); cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


            SqlParameter prmid = new SqlParameter("id", SqlDbType.Int);
            prmid.Value = id;
            cmd.Parameters.Add(prmid);




            SqlParameter prmdateEnd = new SqlParameter("DateEnd", SqlDbType.Date);
            prmdateEnd.Value = dateEnd;
            cmd.Parameters.Add(prmdateEnd);


            SqlParameter prmAddress = new SqlParameter("DateFirst", SqlDbType.Date);
            prmAddress.Value = dateFirst;
            cmd.Parameters.Add(prmAddress);





            SqlParameter prmMantagheId = new SqlParameter("MantagheId", SqlDbType.Int);
            prmMantagheId.Value = MantagheId;
            cmd.Parameters.Add(prmMantagheId);







            //SqlParameter prmResult = new SqlParameter("Result", SqlDbType.Int);
            //prmResult.Direction = ParameterDirection.Output;
            //cmd.Parameters.Add(prmResult);
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
        public static int Update(String id, String TreeTypeId, String Count, String Bon, String date, String Address, String x, String y, String image, String StreetTypeid, String PersonalId, String Peyman, String Peymanid, String MantagheId, String Mojavez, String HaghighiId, String LicesnceTypeid, String Title, String Desc, String recRoleID,String status)
        {

            SqlCommand cmd = new SqlCommand("PRC_CuttingTree_Update", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID(); cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress(); cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS(); cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion(); cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


            SqlParameter prmid = new SqlParameter("id", SqlDbType.Int);
            prmid.Value = id;
            cmd.Parameters.Add(prmid);


            SqlParameter prmTreeTypeId = new SqlParameter("TreeTypeId", SqlDbType.Int);
            prmTreeTypeId.Value = TreeTypeId;
            cmd.Parameters.Add(prmTreeTypeId);

            SqlParameter prmTitle = new SqlParameter("Title", SqlDbType.NVarChar);
            prmTitle.Value = Title;
            cmd.Parameters.Add(prmTitle);

            SqlParameter prmDesc = new SqlParameter("Desc", SqlDbType.NVarChar);
            prmDesc.Value = Desc;
            cmd.Parameters.Add(prmDesc);

            SqlParameter prmCount = new SqlParameter("Count", SqlDbType.Int);
            prmCount.Value = Count;
            cmd.Parameters.Add(prmCount);


            SqlParameter prmBon = new SqlParameter("Bon", SqlDbType.Int);
            prmBon.Value = Bon;
            cmd.Parameters.Add(prmBon);


            SqlParameter prmdate = new SqlParameter("date", SqlDbType.Date);
            prmdate.Value = date;
            cmd.Parameters.Add(prmdate);


            SqlParameter prmAddress = new SqlParameter("Address", SqlDbType.NVarChar);
            prmAddress.Value = Address;
            cmd.Parameters.Add(prmAddress);


            SqlParameter prmx = new SqlParameter("x", SqlDbType.NVarChar);
            prmx.Value = x;
            cmd.Parameters.Add(prmx);


            SqlParameter prmy = new SqlParameter("y", SqlDbType.NVarChar);
            prmy.Value = y;
            cmd.Parameters.Add(prmy);


            //SqlParameter prmimage = new SqlParameter("image", SqlDbType.image);
            //prmimage.Value = image;
            //cmd.Parameters.Add(prmimage);


            SqlParameter prmStreetTypeid = new SqlParameter("StreetTypeid", SqlDbType.Int);
            prmStreetTypeid.Value = StreetTypeid;
            cmd.Parameters.Add(prmStreetTypeid);


            SqlParameter prmPersonalId = new SqlParameter("PersonalId", SqlDbType.Int);
            prmPersonalId.Value = PersonalId;
            cmd.Parameters.Add(prmPersonalId);


            SqlParameter prmPeyman = new SqlParameter("Peyman", SqlDbType.Int);
            prmPeyman.Value = Peyman;
            cmd.Parameters.Add(prmPeyman);


            SqlParameter prmPeymanid = new SqlParameter("Peymanid", SqlDbType.Int);
            prmPeymanid.Value = Peymanid;
            cmd.Parameters.Add(prmPeymanid);


            SqlParameter prmMantagheId = new SqlParameter("MantagheId", SqlDbType.Int);
            prmMantagheId.Value = MantagheId;
            cmd.Parameters.Add(prmMantagheId);


            SqlParameter prmMojavez = new SqlParameter("Mojavez", SqlDbType.Int);
            prmMojavez.Value = Mojavez;
            cmd.Parameters.Add(prmMojavez);


            SqlParameter prmHaghighiId = new SqlParameter("HaghighiId", SqlDbType.Int);
            prmHaghighiId.Value = HaghighiId;
            cmd.Parameters.Add(prmHaghighiId);


            SqlParameter prmLicesnceTypeid = new SqlParameter("LicesnceTypeid", SqlDbType.Int);
            prmLicesnceTypeid.Value = LicesnceTypeid;
            cmd.Parameters.Add(prmLicesnceTypeid);


            SqlParameter prmrecRoleID = new SqlParameter("recRoleID", SqlDbType.NVarChar);
            prmrecRoleID.Value = recRoleID;
            cmd.Parameters.Add(prmrecRoleID);

            SqlParameter prmstatus = new SqlParameter("status", SqlDbType.NVarChar);
            prmstatus.Value = status;
            cmd.Parameters.Add(prmstatus);


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

            SqlCommand cmd = new SqlCommand("PRC_CuttingTree_Delete", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", id);
            //cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID(); cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress(); cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS(); cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion(); cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();
            //SqlParameter prmid = new SqlParameter("id", SqlDbType.Int);
            //prmid.Direction = ParameterDirection.Output;
            //cmd.Parameters.Add(prmid);
            //SqlParameter prmResult = new SqlParameter("Result", SqlDbType.Int);
            //prmResult.Direction = ParameterDirection.Output;
            //cmd.Parameters.Add(prmResult);
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                return 1;
                //return Convert.ToInt32(prmResult.Value);
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
