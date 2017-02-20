        using Microsoft.VisualBasic;
        using System;
        using System.Collections;
        using System.Data;
        using System.Diagnostics;
        using System.Collections;
        using System.Data.SqlClient;


   namespace GreenSpaceDAL
{
    public class PersonalClass
    {
        public static SqlConnection cnn=new SqlConnection(CSharp.PublicFunction.cnstr()) ;
        public static int insert(String PersonalID, String NationalCode, String FirstName, String LastName, String PersonalAdress, String PostiCode, String PersonalTel, String PersonalMobile, String JobName, String Email, String PassWord, String Manage)
{
        SqlCommand cmd= new SqlCommand("PRC_Personal_Insert", cnn); 
        cmd.CommandType =  System.Data.CommandType.StoredProcedure;
cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


//SqlParameter prmCuttingTreeId = new SqlParameter("CuttingTreeId", SqlDbType.Int);
//prmCuttingTreeId.Value = Securenamespace.SecureData.CheckSecurity(CuttingTreeId);
//cmd.Parameters.Add(prmCuttingTreeId);

//SqlParameter prmLicensingTreeid = new SqlParameter("LicensingTreeid", SqlDbType.Int);
//prmLicensingTreeid.Value = Securenamespace.SecureData.CheckSecurity(LicensingTreeid);
//cmd.Parameters.Add(prmLicensingTreeid);


SqlParameter prmNationalCode = new SqlParameter("NationalCode", SqlDbType.NVarChar);
prmNationalCode.Value = NationalCode;
cmd.Parameters.Add(prmNationalCode);


SqlParameter prmFirstName = new SqlParameter("FirstName", SqlDbType.NVarChar);
prmFirstName.Value = FirstName;
cmd.Parameters.Add(prmFirstName);


SqlParameter prmLastName = new SqlParameter("LastName", SqlDbType.NVarChar);
prmLastName.Value = LastName;
cmd.Parameters.Add(prmLastName);


SqlParameter prmPersonalAdress = new SqlParameter("PersonalAdress", SqlDbType.NVarChar);
prmPersonalAdress.Value = PersonalAdress;
cmd.Parameters.Add(prmPersonalAdress);


SqlParameter prmPostiCode = new SqlParameter("PostiCode", SqlDbType.NVarChar);
prmPostiCode.Value = PostiCode;
cmd.Parameters.Add(prmPostiCode);


SqlParameter prmPersonalTel = new SqlParameter("PersonalTel", SqlDbType.NVarChar);
prmPersonalTel.Value = PersonalTel;
cmd.Parameters.Add(prmPersonalTel);


SqlParameter prmPersonalMobile = new SqlParameter("PersonalMobile", SqlDbType.NVarChar);
prmPersonalMobile.Value = PersonalMobile;
cmd.Parameters.Add(prmPersonalMobile);


SqlParameter prmJobName = new SqlParameter("JobName", SqlDbType.NVarChar);
prmJobName.Value = JobName;
cmd.Parameters.Add(prmJobName);


SqlParameter prmEmail = new SqlParameter("Email", SqlDbType.NVarChar);
prmEmail.Value = Email;
cmd.Parameters.Add(prmEmail);


SqlParameter prmPassWord = new SqlParameter("PassWord", SqlDbType.NVarChar);
prmPassWord.Value = PassWord;
cmd.Parameters.Add(prmPassWord);


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
   
public static int UpdateCuttingTree(String HaghighiID, String CuttingTreeId, String LicensingTreeId)
{

    SqlCommand cmd = new SqlCommand("PRC_CuttingTreePersonel_Update", cnn);
    cmd.CommandType = System.Data.CommandType.StoredProcedure;
    cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID(); cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress(); cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS(); cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion(); cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


    SqlParameter prmHaghighiID = new SqlParameter("PersonelId", SqlDbType.Int);
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

//---------------------------------------------------------------------------------------------------------
        public static DataSet GetList(String PersonalID, String NationalCode, String FirstName, String LastName, String PersonalAdress, String PostiCode, String PersonalTel, String PersonalMobile, String JobName, String Email, String PassWord, String Manage,String CuttingTreeId,String LicensingTreeid  )
{

    SqlCommand cmd = new SqlCommand("PRC_Personal_GetList", cnn); 
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


//SqlParameter prmCuttingTreeId = new SqlParameter("CuttingTreeId", SqlDbType.Int);
//prmCuttingTreeId.Value = Securenamespace.SecureData.CheckSecurity(CuttingTreeId);
//cmd.Parameters.Add(prmCuttingTreeId);

//SqlParameter prmLicensingTreeid = new SqlParameter("LicensingTreeid", SqlDbType.Int);
//prmLicensingTreeid.Value = Securenamespace.SecureData.CheckSecurity(LicensingTreeid);
//cmd.Parameters.Add(prmLicensingTreeid);

SqlParameter prmPersonalID = new SqlParameter("PersonalID", SqlDbType.Int);
prmPersonalID.Value = Securenamespace.SecureData.CheckSecurity(PersonalID);
cmd.Parameters.Add(prmPersonalID);


SqlParameter prmNationalCode = new SqlParameter("NationalCode", SqlDbType.NVarChar);
prmNationalCode.Value = Securenamespace.SecureData.CheckSecurity(NationalCode);
cmd.Parameters.Add(prmNationalCode);


SqlParameter prmFirstName = new SqlParameter("FirstName", SqlDbType.NVarChar);
prmFirstName.Value = Securenamespace.SecureData.CheckSecurity(FirstName);
cmd.Parameters.Add(prmFirstName);


SqlParameter prmLastName = new SqlParameter("LastName", SqlDbType.NVarChar);
prmLastName.Value = Securenamespace.SecureData.CheckSecurity(LastName);
cmd.Parameters.Add(prmLastName);


SqlParameter prmPersonalAdress = new SqlParameter("PersonalAdress", SqlDbType.NVarChar);
prmPersonalAdress.Value =Securenamespace.SecureData.CheckSecurity(PersonalAdress);
cmd.Parameters.Add(prmPersonalAdress);


SqlParameter prmPostiCode = new SqlParameter("PostiCode", SqlDbType.NVarChar);
prmPostiCode.Value = Securenamespace.SecureData.CheckSecurity(PostiCode);
cmd.Parameters.Add(prmPostiCode);


SqlParameter prmPersonalTel = new SqlParameter("PersonalTel", SqlDbType.NVarChar);
prmPersonalTel.Value = Securenamespace.SecureData.CheckSecurity(PersonalTel);
cmd.Parameters.Add(prmPersonalTel);


SqlParameter prmPersonalMobile = new SqlParameter("PersonalMobile", SqlDbType.NVarChar);
prmPersonalMobile.Value = Securenamespace.SecureData.CheckSecurity(PersonalMobile);
cmd.Parameters.Add(prmPersonalMobile);


SqlParameter prmJobName = new SqlParameter("JobName", SqlDbType.NVarChar);
prmJobName.Value = Securenamespace.SecureData.CheckSecurity(JobName);
cmd.Parameters.Add(prmJobName);


SqlParameter prmEmail = new SqlParameter("Email", SqlDbType.NVarChar);
prmEmail.Value = Securenamespace.SecureData.CheckSecurity(Email);
cmd.Parameters.Add(prmEmail);


SqlParameter prmPassWord = new SqlParameter("PassWord", SqlDbType.NVarChar);
prmPassWord.Value = Securenamespace.SecureData.CheckSecurity(PassWord);
cmd.Parameters.Add(prmPassWord);


SqlParameter prmManage = new SqlParameter("Manage", SqlDbType.Int);
prmManage.Value = Securenamespace.SecureData.CheckSecurity(Manage);
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
       // -----------------------------------------------------------------------------------------------


public static DataSet GetListReport(String PersonalID, String NationalCode, String FirstName, String LastName, String PersonalAdress, String PostiCode, String PersonalTel, String PersonalMobile, String JobName, String Email, String PassWord, String Manage)
{

    SqlCommand cmd = new SqlCommand("PRC_Personal_GetListReport", cnn);
    cmd.CommandType = System.Data.CommandType.StoredProcedure;
    cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID(); cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress(); cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS(); cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion(); cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


    SqlParameter prmPersonalID = new SqlParameter("PersonalID", SqlDbType.Int);
    prmPersonalID.Value = PersonalID;
    cmd.Parameters.Add(prmPersonalID);


    SqlParameter prmNationalCode = new SqlParameter("NationalCode", SqlDbType.NVarChar);
    prmNationalCode.Value = NationalCode;
    cmd.Parameters.Add(prmNationalCode);


    SqlParameter prmFirstName = new SqlParameter("FirstName", SqlDbType.NVarChar);
    prmFirstName.Value = FirstName;
    cmd.Parameters.Add(prmFirstName);


    SqlParameter prmLastName = new SqlParameter("LastName", SqlDbType.NVarChar);
    prmLastName.Value = LastName;
    cmd.Parameters.Add(prmLastName);


    SqlParameter prmPersonalAdress = new SqlParameter("PersonalAdress", SqlDbType.NVarChar);
    prmPersonalAdress.Value = PersonalAdress;
    cmd.Parameters.Add(prmPersonalAdress);


    SqlParameter prmPostiCode = new SqlParameter("PostiCode", SqlDbType.NVarChar);
    prmPostiCode.Value = PostiCode;
    cmd.Parameters.Add(prmPostiCode);


    SqlParameter prmPersonalTel = new SqlParameter("PersonalTel", SqlDbType.NVarChar);
    prmPersonalTel.Value = PersonalTel;
    cmd.Parameters.Add(prmPersonalTel);


    SqlParameter prmPersonalMobile = new SqlParameter("PersonalMobile", SqlDbType.NVarChar);
    prmPersonalMobile.Value = PersonalMobile;
    cmd.Parameters.Add(prmPersonalMobile);


    SqlParameter prmJobName = new SqlParameter("JobName", SqlDbType.NVarChar);
    prmJobName.Value = JobName;
    cmd.Parameters.Add(prmJobName);


    SqlParameter prmEmail = new SqlParameter("Email", SqlDbType.NVarChar);
    prmEmail.Value = Email;
    cmd.Parameters.Add(prmEmail);


    SqlParameter prmPassWord = new SqlParameter("PassWord", SqlDbType.NVarChar);
    prmPassWord.Value = PassWord;
    cmd.Parameters.Add(prmPassWord);


    SqlParameter prmManage = new SqlParameter("Manage", SqlDbType.Int);
    prmManage.Value = Manage;
    cmd.Parameters.Add(prmManage);


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
public static int Update(String PersonalID,String NationalCode,String FirstName,String LastName,String PersonalAdress,String PostiCode,String PersonalTel,String PersonalMobile,String JobName,String Email,String PassWord,String Manage)
{
        SqlCommand cmd= new SqlCommand("PRC_Personal_Update", cnn); 
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();cmd.Parameters.Add(new SqlParameter("URLLog" ,SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


SqlParameter prmPersonalID = new SqlParameter("PersonalID", SqlDbType.Int);
prmPersonalID.Value = PersonalID;
cmd.Parameters.Add(prmPersonalID);


SqlParameter prmNationalCode = new SqlParameter("NationalCode", SqlDbType.NVarChar);
prmNationalCode.Value = NationalCode;
cmd.Parameters.Add(prmNationalCode);


SqlParameter prmFirstName = new SqlParameter("FirstName", SqlDbType.NVarChar);
prmFirstName.Value = FirstName;
cmd.Parameters.Add(prmFirstName);


SqlParameter prmLastName = new SqlParameter("LastName", SqlDbType.NVarChar);
prmLastName.Value = LastName;
cmd.Parameters.Add(prmLastName);


SqlParameter prmPersonalAdress = new SqlParameter("PersonalAdress", SqlDbType.NVarChar);
prmPersonalAdress.Value = PersonalAdress;
cmd.Parameters.Add(prmPersonalAdress);


SqlParameter prmPostiCode = new SqlParameter("PostiCode", SqlDbType.NVarChar);
prmPostiCode.Value = PostiCode;
cmd.Parameters.Add(prmPostiCode);


SqlParameter prmPersonalTel = new SqlParameter("PersonalTel", SqlDbType.NVarChar);
prmPersonalTel.Value = PersonalTel;
cmd.Parameters.Add(prmPersonalTel);


SqlParameter prmPersonalMobile = new SqlParameter("PersonalMobile", SqlDbType.NVarChar);
prmPersonalMobile.Value = PersonalMobile;
cmd.Parameters.Add(prmPersonalMobile);


SqlParameter prmJobName = new SqlParameter("JobName", SqlDbType.NVarChar);
prmJobName.Value = JobName;
cmd.Parameters.Add(prmJobName);


SqlParameter prmEmail = new SqlParameter("Email", SqlDbType.NVarChar);
prmEmail.Value = Email;
cmd.Parameters.Add(prmEmail);


SqlParameter prmPassWord = new SqlParameter("PassWord", SqlDbType.NVarChar);
prmPassWord.Value = PassWord;
cmd.Parameters.Add(prmPassWord);


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
public static int Delete(int PersonalID){

        SqlCommand cmd= new SqlCommand("PRC_Personal_Delete", cnn); 
        cmd.CommandType = System.Data.CommandType.StoredProcedure;


cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();cmd.Parameters.Add(new SqlParameter("URLLog" ,SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();
SqlParameter prmPersonalID =new SqlParameter("PersonalID",SqlDbType.Int );
        //prmPersonalID.Direction = ParameterDirection.Output;
prmPersonalID.Value = PersonalID;
        cmd.Parameters.Add(prmPersonalID);
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
