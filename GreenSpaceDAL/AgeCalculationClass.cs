using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenSpaceDAL
{
    public class AgeCalculationClass
    {
        public static SqlConnection cnn=new SqlConnection(CSharp.PublicFunction.cnstr()) ;
public static int insert(String GroupAge,String BonSize,String AgeTypeId,String TreeType,String year){

        SqlCommand cmd= new SqlCommand("PRC_AgeCalculation_Insert", cnn); 
        cmd.CommandType =  System.Data.CommandType.StoredProcedure;
cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


SqlParameter prmGroupAge = new SqlParameter("GroupAge", SqlDbType.Float);
prmGroupAge.Value = GroupAge;
cmd.Parameters.Add(prmGroupAge);


SqlParameter prmBonSize = new SqlParameter("BonSize", SqlDbType.Float);
prmBonSize.Value = BonSize;
cmd.Parameters.Add(prmBonSize);


SqlParameter prmAgeTypeId = new SqlParameter("AgeTypeId", SqlDbType.Int);
prmAgeTypeId.Value = AgeTypeId;
cmd.Parameters.Add(prmAgeTypeId);


SqlParameter prmTreeType = new SqlParameter("TreeType", SqlDbType.Int);
prmTreeType.Value = TreeType;
cmd.Parameters.Add(prmTreeType);
    SqlParameter prmyear = new SqlParameter("year", SqlDbType.Int);
prmyear.Value = year ;
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
public static DataSet GetList(String id,String GroupAge,String BonSize,String AgeTypeId,String TreeType,String year){

        SqlCommand cmd= new SqlCommand("PRC_AgeCalculation_GetList", cnn); 
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


SqlParameter prmid = new SqlParameter("id", SqlDbType.Int);
prmid.Value = Securenamespace.SecureData.CheckSecurity(id);
cmd.Parameters.Add(prmid);


SqlParameter prmGroupAge = new SqlParameter("GroupAge", SqlDbType.Float);
prmGroupAge.Value = Securenamespace.SecureData.CheckSecurity(GroupAge);
cmd.Parameters.Add(prmGroupAge);


SqlParameter prmBonSize = new SqlParameter("BonSize", SqlDbType.Float);
prmBonSize.Value = Securenamespace.SecureData.CheckSecurity(BonSize);
cmd.Parameters.Add(prmBonSize);


SqlParameter prmAgeTypeId = new SqlParameter("AgeTypeId", SqlDbType.Int);
prmAgeTypeId.Value =Securenamespace.SecureData.CheckSecurity(AgeTypeId);
cmd.Parameters.Add(prmAgeTypeId);


SqlParameter prmTreeType = new SqlParameter("TreeType", SqlDbType.Int);
prmTreeType.Value = Securenamespace.SecureData.CheckSecurity(TreeType);
cmd.Parameters.Add(prmTreeType);

SqlParameter prmyear = new SqlParameter("year", SqlDbType.Int);
prmyear.Value = Securenamespace.SecureData.CheckSecurity(year) ;
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
public static int Update(String id,String GroupAge,String BonSize,String AgeTypeId,String TreeType,String year){

        SqlCommand cmd= new SqlCommand("PRC_AgeCalculation_Update", cnn); 
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


SqlParameter prmid = new SqlParameter("id", SqlDbType.Int);
prmid.Value = id;
cmd.Parameters.Add(prmid);


SqlParameter prmGroupAge = new SqlParameter("GroupAge", SqlDbType.Float);
prmGroupAge.Value = GroupAge;
cmd.Parameters.Add(prmGroupAge);


SqlParameter prmBonSize = new SqlParameter("BonSize", SqlDbType.Float);
prmBonSize.Value = BonSize;
cmd.Parameters.Add(prmBonSize);

SqlParameter prmAgeTypeId = new SqlParameter("AgeTypeId", SqlDbType.Int);
prmAgeTypeId.Value = AgeTypeId;
cmd.Parameters.Add(prmAgeTypeId);


SqlParameter prmTreeType = new SqlParameter("TreeType", SqlDbType.Int);
prmTreeType.Value = TreeType;
cmd.Parameters.Add(prmTreeType);

    SqlParameter prmyear= new SqlParameter("year", SqlDbType.Int);
prmyear.Value = year ;
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

        SqlCommand cmd= new SqlCommand("PRC_AgeCalculation_Delete", cnn); 
        cmd.CommandType = System.Data.CommandType.StoredProcedure;


cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();
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


