using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenSpaceDAL
{
  public   class ArzeshBasariClass
    {
   public static SqlConnection cnn=new SqlConnection(CSharp.PublicFunction.cnstr()) ;
public static int insert(String StreetTypeId,String BasariRotbehId,String ArzeshBasari,String year){

        SqlCommand cmd= new SqlCommand("PRC_ArzeshBasari_Insert", cnn); 
        cmd.CommandType =  System.Data.CommandType.StoredProcedure;
cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();cmd.Parameters.Add(new SqlParameter("URLLog" ,SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


SqlParameter prmStreetTypeId = new SqlParameter("StreetTypeId", SqlDbType.Int);
prmStreetTypeId.Value = StreetTypeId;
cmd.Parameters.Add(prmStreetTypeId);


SqlParameter prmBasariRotbehId = new SqlParameter("BasariRotbehId", SqlDbType.Int);
prmBasariRotbehId.Value = BasariRotbehId;
cmd.Parameters.Add(prmBasariRotbehId);


SqlParameter prmArzeshBasari = new SqlParameter("ArzeshBasari", SqlDbType.Float);
prmArzeshBasari.Value = ArzeshBasari;
cmd.Parameters.Add(prmArzeshBasari);


SqlParameter prmyear = new SqlParameter("year", SqlDbType.Int);
prmyear.Value = year;
cmd.Parameters.Add(prmyear);


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
public static DataSet GetList(String id,String StreetTypeId,String BasariRotbehId,String ArzeshBasari,String year){

        SqlCommand cmd= new SqlCommand("PRC_ArzeshBasari_GetList", cnn); 
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


SqlParameter prmid = new SqlParameter("id", SqlDbType.Int);
prmid.Value = id;
cmd.Parameters.Add(prmid);


SqlParameter prmStreetTypeId = new SqlParameter("StreetTypeId", SqlDbType.Int);
prmStreetTypeId.Value = StreetTypeId;
cmd.Parameters.Add(prmStreetTypeId);


SqlParameter prmBasariRotbehId = new SqlParameter("BasariRotbehId", SqlDbType.Int);
prmBasariRotbehId.Value = BasariRotbehId;
cmd.Parameters.Add(prmBasariRotbehId);


SqlParameter prmArzeshBasari = new SqlParameter("ArzeshBasari", SqlDbType.Float);
prmArzeshBasari.Value = ArzeshBasari;
cmd.Parameters.Add(prmArzeshBasari);


SqlParameter prmyear = new SqlParameter("year", SqlDbType.Int);
prmyear.Value = year;
cmd.Parameters.Add(prmyear);


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
public static int Update(String id,String StreetTypeId,String BasariRotbehId,String ArzeshBasari,String year){

        SqlCommand cmd= new SqlCommand("PRC_ArzeshBasari_Update", cnn); 
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();cmd.Parameters.Add(new SqlParameter("URLLog" ,SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


SqlParameter prmid = new SqlParameter("id", SqlDbType.Int);
prmid.Value = id;
cmd.Parameters.Add(prmid);


SqlParameter prmStreetTypeId = new SqlParameter("StreetTypeId", SqlDbType.Int);
prmStreetTypeId.Value = StreetTypeId;
cmd.Parameters.Add(prmStreetTypeId);


SqlParameter prmBasariRotbehId = new SqlParameter("BasariRotbehId", SqlDbType.Int);
prmBasariRotbehId.Value = BasariRotbehId;
cmd.Parameters.Add(prmBasariRotbehId);


SqlParameter prmArzeshBasari = new SqlParameter("ArzeshBasari", SqlDbType.Float );
prmArzeshBasari.Value = ArzeshBasari;
cmd.Parameters.Add(prmArzeshBasari);


SqlParameter prmyear = new SqlParameter("year", SqlDbType.Int);
prmyear.Value = year;
cmd.Parameters.Add(prmyear);


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

        SqlCommand cmd= new SqlCommand("PRC_ArzeshBasari_Delete", cnn); 
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
