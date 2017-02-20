using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenSpaceDAL
{
     public class MahsolDaramadClass
    {
        public static SqlConnection cnn=new SqlConnection(CSharp.PublicFunction.cnstr()) ;
        public static int insert( String Ageid, String Mizan, String Mony, String year, String TreeType)
        {

        SqlCommand cmd= new SqlCommand("PRC_MahsolDaramad_Insert", cnn); 
        cmd.CommandType =  System.Data.CommandType.StoredProcedure;
cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();cmd.Parameters.Add(new SqlParameter("URLLog" ,SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


SqlParameter prmAgeid = new SqlParameter("Ageid", SqlDbType.Int);
prmAgeid.Value = Ageid;
cmd.Parameters.Add(prmAgeid);


SqlParameter prmMizan = new SqlParameter("Mizan", SqlDbType.Float );
prmMizan.Value = Mizan;
cmd.Parameters.Add(prmMizan);


SqlParameter prmMony = new SqlParameter("Mony", SqlDbType.Float);
prmMony.Value = Mony;
cmd.Parameters.Add(prmMony);

SqlParameter prmyear = new SqlParameter("year", SqlDbType.Int);
prmyear.Value = year ;
cmd.Parameters.Add(prmyear);

SqlParameter prmTreeType = new SqlParameter("TreeType", SqlDbType.Int);
prmTreeType.Value = TreeType;
cmd.Parameters.Add(prmTreeType);

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
        public static DataSet GetList(String id, String Ageid, String Mizan, String Mony, String year, String TreeType)
        {

        SqlCommand cmd= new SqlCommand("PRC_MahsolDaramad_GetList", cnn); 
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();cmd.Parameters.Add(new SqlParameter("URLLog" ,SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


SqlParameter prmid = new SqlParameter("id", SqlDbType.Int);
prmid.Value = id;
cmd.Parameters.Add(prmid);


SqlParameter prmAgeid = new SqlParameter("Ageid", SqlDbType.Int);
prmAgeid.Value = Ageid;
cmd.Parameters.Add(prmAgeid);


SqlParameter prmMizan = new SqlParameter("Mizan", SqlDbType.Float);
prmMizan.Value = Mizan;
cmd.Parameters.Add(prmMizan);


SqlParameter prmMony = new SqlParameter("Mony", SqlDbType.Float);
prmMony.Value = Mony;
cmd.Parameters.Add(prmMony);

SqlParameter prmyear = new SqlParameter("year", SqlDbType.Int);
prmyear.Value = year;
cmd.Parameters.Add(prmyear);

SqlParameter prmTreeType = new SqlParameter("TreeType", SqlDbType.Int);
prmTreeType.Value = TreeType;
cmd.Parameters.Add(prmTreeType);

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
public static int Update(String id, String Ageid, String Mizan, String Mony, String year, String TreeType)
{

        SqlCommand cmd= new SqlCommand("PRC_MahsolDaramad_Update", cnn); 
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


SqlParameter prmid = new SqlParameter("id", SqlDbType.Int);
prmid.Value = id;
cmd.Parameters.Add(prmid);


SqlParameter prmAgeid = new SqlParameter("Ageid", SqlDbType.Int);
prmAgeid.Value = Ageid;
cmd.Parameters.Add(prmAgeid);


SqlParameter prmMizan = new SqlParameter("Mizan", SqlDbType.Float);
prmMizan.Value = Mizan;
cmd.Parameters.Add(prmMizan);


SqlParameter prmMony = new SqlParameter("Mony", SqlDbType.Float);
prmMony.Value = Mony;
cmd.Parameters.Add(prmMony);


SqlParameter prmyear = new SqlParameter("year", SqlDbType.Int);
prmyear.Value = year;
cmd.Parameters.Add(prmyear);


SqlParameter prmTreeType = new SqlParameter("TreeType", SqlDbType.Int);
prmTreeType.Value = TreeType;
cmd.Parameters.Add(prmTreeType);

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

        SqlCommand cmd= new SqlCommand("PRC_MahsolDaramad_Delete", cnn); 
        cmd.CommandType = System.Data.CommandType.StoredProcedure;


cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();cmd.Parameters.Add(new SqlParameter("URLLog" ,SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();
SqlParameter prmid =new SqlParameter("id",SqlDbType.Int );
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
