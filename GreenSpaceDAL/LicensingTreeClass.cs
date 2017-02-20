using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenSpaceDAL
{
    public class LicensingTreeClass
    {
        public static SqlConnection cnn=new SqlConnection(CSharp.PublicFunction.cnstr()) ;
        public static int insert(String HaghighiId, String PersonelId, String MojavezDate, String LicesnceTypeid, String Desc, String Title, String MantagheId)
        {

        SqlCommand cmd= new SqlCommand("PRC_LicensingTree_Insert", cnn); 
        cmd.CommandType =  System.Data.CommandType.StoredProcedure;
cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


SqlParameter prmTitle = new SqlParameter("Title", SqlDbType.NVarChar );
prmTitle.Value = Title;
cmd.Parameters.Add(prmTitle);


SqlParameter prmMantagheId = new SqlParameter("MantagheId", SqlDbType.Int);
prmMantagheId.Value = MantagheId;
cmd.Parameters.Add(prmMantagheId);


SqlParameter prmHaghighiId = new SqlParameter("HaghighiId", SqlDbType.Int);
prmHaghighiId.Value = HaghighiId;
cmd.Parameters.Add(prmHaghighiId);


    SqlParameter prmDesc = new SqlParameter("Desc", SqlDbType.NVarChar );
prmDesc.Value = Desc;
cmd.Parameters.Add(prmDesc);


SqlParameter prmPersonelId = new SqlParameter("PersonelId", SqlDbType.Int);
prmPersonelId.Value = PersonelId;
cmd.Parameters.Add(prmPersonelId);


SqlParameter prmMojavezDate = new SqlParameter("MojavezDate", SqlDbType.Date );
prmMojavezDate.Value = DateConvert.sh2m(MojavezDate); ; ;
cmd.Parameters.Add(prmMojavezDate);


//SqlParameter prmFinalNazar = new SqlParameter("FinalNazar", SqlDbType.Int);
//prmFinalNazar.Value = FinalNazar;
//cmd.Parameters.Add(prmFinalNazar);


SqlParameter prmLicesnceTypeid = new SqlParameter("LicesnceTypeid", SqlDbType.Int);
prmLicesnceTypeid.Value = LicesnceTypeid;
cmd.Parameters.Add(prmLicesnceTypeid);


SqlParameter prmResult =new SqlParameter("Result",SqlDbType.Int );
        prmResult.Direction = ParameterDirection.Output;
        cmd.Parameters.Add(prmResult);
        try{
       cnn.Open();
        cmd.ExecuteNonQuery();
        return Convert.ToInt32(prmResult.Value);}
        catch(Exception ex ){
            return 0;}
        finally{
            cnn.Close();
        }

   }
        public static DataSet GetReportList(String Mojavezid, String HaghighiId, String PersonelId, String MojavezDateFirst, String LicesnceTypeid, String Desc, String Title, String MantagheId, string MojavezDateEnd)
        {

            SqlCommand cmd = new SqlCommand("Rep_LicensingTree_GetList", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID(); cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress(); cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS(); cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion(); cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


            SqlParameter prmMojavezid = new SqlParameter("Mojavezid", SqlDbType.Int);
            prmMojavezid.Value = Mojavezid;
            cmd.Parameters.Add(prmMojavezid);

            SqlParameter prmMantagheId = new SqlParameter("MantagheId", SqlDbType.Int);
            prmMantagheId.Value = MantagheId;
            cmd.Parameters.Add(prmMantagheId);


            SqlParameter prmTitle = new SqlParameter("Title", SqlDbType.NVarChar);
            prmTitle.Value = Title;
            cmd.Parameters.Add(prmTitle);


            SqlParameter prmDesc = new SqlParameter("Desc", SqlDbType.NVarChar);
            prmDesc.Value = Desc;
            cmd.Parameters.Add(prmDesc);


            //SqlParameter prmCount = new SqlParameter("Count", SqlDbType.Int);
            //prmCount.Value = Count;
            //cmd.Parameters.Add(prmCount);


            SqlParameter prmHaghighiId = new SqlParameter("HaghighiId", SqlDbType.Int);
            prmHaghighiId.Value = HaghighiId;
            cmd.Parameters.Add(prmHaghighiId);


            SqlParameter prmPersonelId = new SqlParameter("PersonelId", SqlDbType.Int);
            prmPersonelId.Value = PersonelId;
            cmd.Parameters.Add(prmPersonelId);


            SqlParameter prmMojavezDateFirst = new SqlParameter("MojavezDateFirst", SqlDbType.Date);
            if (MojavezDateFirst != null)
                prmMojavezDateFirst.Value = (MojavezDateFirst);
            else prmMojavezDateFirst.Value = null;
            cmd.Parameters.Add(prmMojavezDateFirst);



            SqlParameter prmMojavezDateEnd = new SqlParameter("MojavezDateEnd", SqlDbType.Date);
            if (MojavezDateEnd != null)
                prmMojavezDateEnd.Value =(MojavezDateEnd);
            else prmMojavezDateEnd.Value = null;
            cmd.Parameters.Add(prmMojavezDateEnd);

            //SqlParameter prmFinalNazar = new SqlParameter("FinalNazar", SqlDbType.Int);
            //prmFinalNazar.Value = FinalNazar;
            //cmd.Parameters.Add(prmFinalNazar);


            SqlParameter prmLicesnceTypeid = new SqlParameter("LicesnceTypeid", SqlDbType.Int);
            prmLicesnceTypeid.Value = LicesnceTypeid;
            cmd.Parameters.Add(prmLicesnceTypeid);


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
        public static DataSet GetList(String Mojavezid, String HaghighiId, String PersonelId, String MojavezDate, String LicesnceTypeid, String Desc, String Title, String MantagheId)
        {

        SqlCommand cmd= new SqlCommand("PRC_LicensingTree_GetList", cnn); 
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


SqlParameter prmMojavezid = new SqlParameter("Mojavezid", SqlDbType.Int);
prmMojavezid.Value = Mojavezid;
cmd.Parameters.Add(prmMojavezid);

SqlParameter prmMantagheId = new SqlParameter("MantagheId", SqlDbType.Int);
prmMantagheId.Value = MantagheId;
cmd.Parameters.Add(prmMantagheId);


SqlParameter prmTitle = new SqlParameter("Title", SqlDbType.NVarChar);
prmTitle.Value = Title;
cmd.Parameters.Add(prmTitle);


    SqlParameter prmDesc = new SqlParameter("Desc", SqlDbType.NVarChar );
prmDesc.Value = Desc;
cmd.Parameters.Add(prmDesc);


//SqlParameter prmCount = new SqlParameter("Count", SqlDbType.Int);
//prmCount.Value = Count;
//cmd.Parameters.Add(prmCount);


SqlParameter prmHaghighiId = new SqlParameter("HaghighiId", SqlDbType.Int);
prmHaghighiId.Value = HaghighiId;
cmd.Parameters.Add(prmHaghighiId);


SqlParameter prmPersonelId = new SqlParameter("PersonelId", SqlDbType.Int);
prmPersonelId.Value = PersonelId;
cmd.Parameters.Add(prmPersonelId);


SqlParameter prmMojavezDate = new SqlParameter("MojavezDate", SqlDbType.Date );
if (MojavezDate!=null)
    prmMojavezDate.Value = DateConvert.sh2m(MojavezDate);
else prmMojavezDate.Value = null;
cmd.Parameters.Add(prmMojavezDate);


//SqlParameter prmFinalNazar = new SqlParameter("FinalNazar", SqlDbType.Int);
//prmFinalNazar.Value = FinalNazar;
//cmd.Parameters.Add(prmFinalNazar);


SqlParameter prmLicesnceTypeid = new SqlParameter("LicesnceTypeid", SqlDbType.Int);
prmLicesnceTypeid.Value = LicesnceTypeid;
cmd.Parameters.Add(prmLicesnceTypeid);


SqlParameter prmResult =new SqlParameter("Result",SqlDbType.Int );
        prmResult.Direction = ParameterDirection.Output;
        cmd.Parameters.Add(prmResult);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
        try{
                cnn.Open();
                da.Fill(ds);
                return ds;
           }
        catch(Exception ex ){
            return null;}
        finally{
            cnn.Close();
        }

   }

//---------------------------------------------------------------------------------------------------------
        public static int Update(String Mojavezid, String HaghighiId, String PersonelId, String MojavezDate, String LicesnceTypeid, String Desc, String Title, String MantagheId)
        {

        SqlCommand cmd= new SqlCommand("PRC_LicensingTree_Update", cnn); 
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


SqlParameter prmMojavezid = new SqlParameter("Mojavezid", SqlDbType.Int);
prmMojavezid.Value = Mojavezid;
cmd.Parameters.Add(prmMojavezid);


SqlParameter prmTitle = new SqlParameter("Title", SqlDbType.NVarChar);
prmTitle.Value = Title;
cmd.Parameters.Add(prmTitle);
    
    SqlParameter prmDesc = new SqlParameter("Desc", SqlDbType.NVarChar );
prmDesc.Value = Desc;
cmd.Parameters.Add(prmDesc);

SqlParameter prmMantagheId = new SqlParameter("MantagheId", SqlDbType.Int);
prmMantagheId.Value = MantagheId;
cmd.Parameters.Add(prmMantagheId);


//SqlParameter prmCount = new SqlParameter("Count", SqlDbType.Int);
//prmCount.Value = Count;
//cmd.Parameters.Add(prmCount);


SqlParameter prmHaghighiId = new SqlParameter("HaghighiId", SqlDbType.Int);
prmHaghighiId.Value = HaghighiId;
cmd.Parameters.Add(prmHaghighiId);


SqlParameter prmPersonelId = new SqlParameter("PersonelId", SqlDbType.Int);
prmPersonelId.Value = PersonelId;
cmd.Parameters.Add(prmPersonelId);


SqlParameter prmMojavezDate = new SqlParameter("MojavezDate", SqlDbType.Date );
prmMojavezDate.Value = DateConvert.sh2m(MojavezDate); ;
cmd.Parameters.Add(prmMojavezDate);


//SqlParameter prmFinalNazar = new SqlParameter("FinalNazar", SqlDbType.Int);
//prmFinalNazar.Value = FinalNazar;
//cmd.Parameters.Add(prmFinalNazar);


SqlParameter prmLicesnceTypeid = new SqlParameter("LicesnceTypeid", SqlDbType.Int);
prmLicesnceTypeid.Value = LicesnceTypeid;
cmd.Parameters.Add(prmLicesnceTypeid);


SqlParameter prmResult =new SqlParameter("Result",SqlDbType.Int );
        prmResult.Direction = ParameterDirection.Output;
        cmd.Parameters.Add(prmResult);
        try{
       cnn.Open();
        cmd.ExecuteNonQuery();
        return Convert.ToInt32(prmResult.Value);}
        catch(Exception ex ){
            return 0;}
        finally{
            cnn.Close();
        }

   }

//---------------------------------------------------------------------------------------------------------
public static int Delete(int Mojavezid){

        SqlCommand cmd= new SqlCommand("PRC_LicensingTree_Delete", cnn); 
        cmd.CommandType = System.Data.CommandType.StoredProcedure;


cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();cmd.Parameters.Add(new SqlParameter("URLLog" ,SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();
SqlParameter prmMojavezid =new SqlParameter("Mojavezid",SqlDbType.Int );
        prmMojavezid.Direction = ParameterDirection.Output;
        cmd.Parameters.Add(prmMojavezid);
SqlParameter prmResult =new SqlParameter("Result",SqlDbType.Int );
        prmResult.Direction = ParameterDirection.Output;
        cmd.Parameters.Add(prmResult);
        try{
        cnn.Open();
        cmd.ExecuteNonQuery();
        return Convert.ToInt32(prmResult.Value);}
        catch(Exception ex ){
            return 0;}
        finally{
            cnn.Close();
        }

   }
   }

//---------------------------------------------------------------------------------------------------------
}
