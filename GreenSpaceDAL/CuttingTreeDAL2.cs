using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Collections;
using System.Data.SqlClient;
using GreenSpaceCL;

namespace CuttingTreeSpace
{
    public class CuttingTreeClass2
    {
        public static SqlConnection cnn = new SqlConnection(CSharp.PublicFunction.cnstr());
        public static int insert(ClCuttingTree c )

        {

            SqlCommand cmd = new SqlCommand("PRC_CuttingTree_Insert2", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = 1;// CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

      
       cmd.Parameters.Add(new SqlParameter("TreeTypeId", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.TreeTypeId);
cmd.Parameters.Add(new SqlParameter("Count", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.Count);
cmd.Parameters.Add(new SqlParameter("Bon", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.Bon);
cmd.Parameters.Add(new SqlParameter("date", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.date);
cmd.Parameters.Add(new SqlParameter("Address", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.Address);
cmd.Parameters.Add(new SqlParameter("x", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.x);
cmd.Parameters.Add(new SqlParameter("y", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.y);
cmd.Parameters.Add(new SqlParameter("image", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.image);
cmd.Parameters.Add(new SqlParameter("StreetTypeid", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.StreetTypeid);
cmd.Parameters.Add(new SqlParameter("PersonalId", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.PersonalId);
cmd.Parameters.Add(new SqlParameter("Peyman", SqlDbType.Bit)).Value =Securenamespace.SecureData.CheckSecurity(c.Peyman);
cmd.Parameters.Add(new SqlParameter("Peymanid", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.Peymanid);
cmd.Parameters.Add(new SqlParameter("MantagheId", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.MantagheId);
cmd.Parameters.Add(new SqlParameter("Mojavez", SqlDbType.Bit)).Value =Securenamespace.SecureData.CheckSecurity(c.Mojavez);
cmd.Parameters.Add(new SqlParameter("HaghighiId", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.HaghighiId);
cmd.Parameters.Add(new SqlParameter("LicesnceTypeid", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.LicesnceTypeid);
cmd.Parameters.Add(new SqlParameter("Title", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.Title);
cmd.Parameters.Add(new SqlParameter("dddeeesssccc", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.dddeeesssccc);
cmd.Parameters.Add(new SqlParameter("recRoleID", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.recRoleID);
cmd.Parameters.Add(new SqlParameter("status", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.status);
cmd.Parameters.Add(new SqlParameter("GeoTree", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.GeoTree);
cmd.Parameters.Add(new SqlParameter("Desc", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.Desc);
cmd.Parameters.Add(new SqlParameter("PointGeo", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.PointGeo);


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
        public static DataSet GetList(ClCuttingTree c)
        {

            SqlCommand cmd = new SqlCommand("PRC_CuttingTree_GetListMap", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = 1;// CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
            cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

             cmd.Parameters.Add(new SqlParameter("id", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.id);
cmd.Parameters.Add(new SqlParameter("TreeTypeId", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.TreeTypeId);
cmd.Parameters.Add(new SqlParameter("Count", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.Count);
cmd.Parameters.Add(new SqlParameter("Bon", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.Bon);
cmd.Parameters.Add(new SqlParameter("date", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.date);
cmd.Parameters.Add(new SqlParameter("Address", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.Address);
cmd.Parameters.Add(new SqlParameter("x", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.x);
cmd.Parameters.Add(new SqlParameter("y", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.y);
cmd.Parameters.Add(new SqlParameter("image", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.image);
cmd.Parameters.Add(new SqlParameter("StreetTypeid", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.StreetTypeid);
cmd.Parameters.Add(new SqlParameter("PersonalId", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PersonalId);
cmd.Parameters.Add(new SqlParameter("Peyman", SqlDbType.Bit)).Value = Securenamespace.SecureData.CheckSecurity(c.Peyman);
cmd.Parameters.Add(new SqlParameter("Peymanid", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.Peymanid);
cmd.Parameters.Add(new SqlParameter("MantagheId", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.MantagheId);
cmd.Parameters.Add(new SqlParameter("Mojavez", SqlDbType.Bit)).Value = Securenamespace.SecureData.CheckSecurity(c.Mojavez);
cmd.Parameters.Add(new SqlParameter("HaghighiId", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.HaghighiId);
cmd.Parameters.Add(new SqlParameter("LicesnceTypeid", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.LicesnceTypeid);
cmd.Parameters.Add(new SqlParameter("Title", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.Title);
cmd.Parameters.Add(new SqlParameter("dddeeesssccc", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.dddeeesssccc);
cmd.Parameters.Add(new SqlParameter("recRoleID", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.recRoleID);
cmd.Parameters.Add(new SqlParameter("status", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.status);
cmd.Parameters.Add(new SqlParameter("GeoTree", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.GeoTree);
cmd.Parameters.Add(new SqlParameter("Desc", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.Desc);
cmd.Parameters.Add(new SqlParameter("PointGeo", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.PointGeo);


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
        public static int Update(ClCuttingTree c)
        {

            SqlCommand cmd = new SqlCommand("PRC_CuttingTree_Update", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

	cmd.Parameters.Add(new SqlParameter("id", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.id);
cmd.Parameters.Add(new SqlParameter("TreeTypeId", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.TreeTypeId);
cmd.Parameters.Add(new SqlParameter("Count", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.Count);
cmd.Parameters.Add(new SqlParameter("Bon", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.Bon);
cmd.Parameters.Add(new SqlParameter("date", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.date);
cmd.Parameters.Add(new SqlParameter("Address", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.Address);
cmd.Parameters.Add(new SqlParameter("x", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.x);
cmd.Parameters.Add(new SqlParameter("y", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.y);
cmd.Parameters.Add(new SqlParameter("image", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.image);
cmd.Parameters.Add(new SqlParameter("StreetTypeid", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.StreetTypeid);
cmd.Parameters.Add(new SqlParameter("PersonalId", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PersonalId);
cmd.Parameters.Add(new SqlParameter("Peyman", SqlDbType.Bit)).Value = Securenamespace.SecureData.CheckSecurity(c.Peyman);
cmd.Parameters.Add(new SqlParameter("Peymanid", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.Peymanid);
cmd.Parameters.Add(new SqlParameter("MantagheId", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.MantagheId);
cmd.Parameters.Add(new SqlParameter("Mojavez", SqlDbType.Bit)).Value = Securenamespace.SecureData.CheckSecurity(c.Mojavez);
cmd.Parameters.Add(new SqlParameter("HaghighiId", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.HaghighiId);
cmd.Parameters.Add(new SqlParameter("LicesnceTypeid", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.LicesnceTypeid);
cmd.Parameters.Add(new SqlParameter("Title", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.Title);
cmd.Parameters.Add(new SqlParameter("dddeeesssccc", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.dddeeesssccc);
cmd.Parameters.Add(new SqlParameter("recRoleID", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.recRoleID);
cmd.Parameters.Add(new SqlParameter("status", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.status);
cmd.Parameters.Add(new SqlParameter("GeoTree", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.GeoTree);
cmd.Parameters.Add(new SqlParameter("Desc", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.Desc);
cmd.Parameters.Add(new SqlParameter("PointGeo", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.PointGeo);


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
        public static int Delete(string  id)
        {

            SqlCommand cmd = new SqlCommand("PRC_CuttingTree_Delete", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

   	cmd.Parameters.Add(new SqlParameter("id", SqlDbType.Int)).Value =id ;
 
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

