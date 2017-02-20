using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenSpaceDAL
{
    public class KambodSaranehClass
    {
        public static SqlConnection cnn=new SqlConnection(CSharp.PublicFunction.cnstr()) ;
public static int insert(String Mantaghehid,String FirstSaraneh,String StandardSaaneh,String year){

        SqlCommand cmd= new SqlCommand("PRC_KambodSaraneh_Insert", cnn); 
        cmd.CommandType =  System.Data.CommandType.StoredProcedure;
cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


SqlParameter prmMantaghehid = new SqlParameter("Mantaghehid", SqlDbType.Int);
prmMantaghehid.Value = Mantaghehid;
cmd.Parameters.Add(prmMantaghehid);


SqlParameter prmFirstSaraneh = new SqlParameter("FirstSaraneh", SqlDbType.Float );
prmFirstSaraneh.Value = FirstSaraneh;
cmd.Parameters.Add(prmFirstSaraneh);


SqlParameter prmStandardSaaneh = new SqlParameter("StandardSaaneh", SqlDbType.Float);
prmStandardSaaneh.Value = StandardSaaneh;
cmd.Parameters.Add(prmStandardSaaneh);

SqlParameter prmyear= new SqlParameter("year", SqlDbType.Int);
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
public static DataSet GetList(String id,String Mantaghehid,String FirstSaraneh,String StandardSaaneh,String year){

        SqlCommand cmd= new SqlCommand("PRC_KambodSaraneh_GetList", cnn); 
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();cmd.Parameters.Add(new SqlParameter("URLLog" ,SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


SqlParameter prmid = new SqlParameter("id", SqlDbType.Int);
prmid.Value = id;
cmd.Parameters.Add(prmid);


SqlParameter prmMantaghehid = new SqlParameter("Mantaghehid", SqlDbType.Int);
prmMantaghehid.Value = Mantaghehid;
cmd.Parameters.Add(prmMantaghehid);


SqlParameter prmFirstSaraneh = new SqlParameter("FirstSaraneh", SqlDbType.Float);
prmFirstSaraneh.Value = FirstSaraneh;
cmd.Parameters.Add(prmFirstSaraneh);


SqlParameter prmStandardSaaneh = new SqlParameter("StandardSaaneh", SqlDbType.Float);
prmStandardSaaneh.Value = StandardSaaneh;
cmd.Parameters.Add(prmStandardSaaneh);
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
public static int Update(String id,String Mantaghehid,String FirstSaraneh,String StandardSaaneh,String year){

        SqlCommand cmd= new SqlCommand("PRC_KambodSaraneh_Update", cnn); 
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();cmd.Parameters.Add(new SqlParameter("URLLog" ,SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


SqlParameter prmid = new SqlParameter("id", SqlDbType.Int);
prmid.Value = id;
cmd.Parameters.Add(prmid);


SqlParameter prmMantaghehid = new SqlParameter("Mantaghehid", SqlDbType.Int);
prmMantaghehid.Value = Mantaghehid;
cmd.Parameters.Add(prmMantaghehid);


SqlParameter prmFirstSaraneh = new SqlParameter("FirstSaraneh", SqlDbType.Float);
prmFirstSaraneh.Value = FirstSaraneh;
cmd.Parameters.Add(prmFirstSaraneh);


SqlParameter prmStandardSaaneh = new SqlParameter("StandardSaaneh", SqlDbType.Float);
prmStandardSaaneh.Value = StandardSaaneh;
cmd.Parameters.Add(prmStandardSaaneh);

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

        SqlCommand cmd= new SqlCommand("PRC_KambodSaraneh_Delete", cnn); 
        cmd.CommandType = System.Data.CommandType.StoredProcedure;


cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();
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
