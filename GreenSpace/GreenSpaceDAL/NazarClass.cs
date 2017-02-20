using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenSpaceDAL
{
    public class NazarClass
    {
        public static SqlConnection cnn=new SqlConnection(CSharp.PublicFunction.cnstr()) ;
        public static int insert(String NazarTypeId, String NazarComment, String NazarDate, String UserId, String Manage, String LicensingId)
        {

        SqlCommand cmd= new SqlCommand("PRC_Nazar_Insert", cnn); 
        cmd.CommandType =  System.Data.CommandType.StoredProcedure;
cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();cmd.Parameters.Add(new SqlParameter("URLLog" ,SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


SqlParameter prmNazarTypeId = new SqlParameter("NazarTypeId", SqlDbType.Int);
prmNazarTypeId.Value = NazarTypeId;
cmd.Parameters.Add(prmNazarTypeId);


SqlParameter prmLicensingId = new SqlParameter("LicensingId", SqlDbType.Int);
prmLicensingId.Value = LicensingId;
cmd.Parameters.Add(prmLicensingId);

SqlParameter prmNazarComment = new SqlParameter("NazarComment", SqlDbType.NVarChar);
prmNazarComment.Value = NazarComment;
cmd.Parameters.Add(prmNazarComment);


SqlParameter prmNazarDate = new SqlParameter("NazarDate", SqlDbType.Date );
prmNazarDate.Value = NazarDate;
cmd.Parameters.Add(prmNazarDate);


SqlParameter prmUserId = new SqlParameter("UserId", SqlDbType.Int);
prmUserId.Value = UserId;
cmd.Parameters.Add(prmUserId);


SqlParameter prmManage = new SqlParameter("Manage", SqlDbType.Int);
prmManage.Value = Manage;
cmd.Parameters.Add(prmManage);


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
        public static DataSet GetList(String id, String NazarTypeId, String NazarComment, String NazarDate, String UserId, String Manage, String LicensingId)
        {

        SqlCommand cmd= new SqlCommand("PRC_Nazar_GetList", cnn); 
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


SqlParameter prmid = new SqlParameter("id", SqlDbType.Int);
prmid.Value = id;
cmd.Parameters.Add(prmid);


SqlParameter prmNazarTypeId = new SqlParameter("NazarTypeId", SqlDbType.Int);
prmNazarTypeId.Value = NazarTypeId;
cmd.Parameters.Add(prmNazarTypeId);

SqlParameter prmLicensingId = new SqlParameter("LicensingId", SqlDbType.Int);
prmLicensingId.Value = LicensingId;
cmd.Parameters.Add(prmLicensingId);

SqlParameter prmNazarComment = new SqlParameter("NazarComment", SqlDbType.NVarChar);
prmNazarComment.Value = NazarComment;
cmd.Parameters.Add(prmNazarComment);


SqlParameter prmNazarDate = new SqlParameter("NazarDate", SqlDbType.Date );
prmNazarDate.Value = NazarDate;
cmd.Parameters.Add(prmNazarDate);


SqlParameter prmUserId = new SqlParameter("UserId", SqlDbType.Int);
prmUserId.Value = UserId;
cmd.Parameters.Add(prmUserId);


SqlParameter prmManage = new SqlParameter("Manage", SqlDbType.Int);
prmManage.Value = Manage;
cmd.Parameters.Add(prmManage);


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
        public static int Update(String id, String NazarTypeId, String NazarComment, String NazarDate, String UserId, String Manage, String LicensingId)
        {

        SqlCommand cmd= new SqlCommand("PRC_Nazar_Update", cnn); 
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();cmd.Parameters.Add(new SqlParameter("URLLog" ,SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


SqlParameter prmid = new SqlParameter("id", SqlDbType.Int);
prmid.Value = id;
cmd.Parameters.Add(prmid);


SqlParameter prmNazarTypeId = new SqlParameter("NazarTypeId", SqlDbType.Int);
prmNazarTypeId.Value = NazarTypeId;
cmd.Parameters.Add(prmNazarTypeId);


SqlParameter prmLicensingId = new SqlParameter("LicensingId", SqlDbType.Int);
prmLicensingId.Value = LicensingId;
cmd.Parameters.Add(prmLicensingId);

SqlParameter prmNazarComment = new SqlParameter("NazarComment", SqlDbType.NVarChar);
prmNazarComment.Value = NazarComment;
cmd.Parameters.Add(prmNazarComment);


SqlParameter prmNazarDate = new SqlParameter("NazarDate", SqlDbType.Date );
prmNazarDate.Value = NazarDate;
cmd.Parameters.Add(prmNazarDate);


SqlParameter prmUserId = new SqlParameter("UserId", SqlDbType.Int);
prmUserId.Value = UserId;
cmd.Parameters.Add(prmUserId);


SqlParameter prmManage = new SqlParameter("Manage", SqlDbType.Int);
prmManage.Value = Manage;
cmd.Parameters.Add(prmManage);


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
public static int Delete(int id){

        SqlCommand cmd= new SqlCommand("PRC_Nazar_Delete", cnn); 
        cmd.CommandType = System.Data.CommandType.StoredProcedure;


cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();cmd.Parameters.Add(new SqlParameter("URLLog" ,SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();
SqlParameter prmid =new SqlParameter("id",SqlDbType.Int );
        //prmid.Direction = ParameterDirection.Output;
prmid.Value = id;
cmd.Parameters.Add(prmid);
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
