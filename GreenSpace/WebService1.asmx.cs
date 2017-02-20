using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;
using GreenSpaceCL;
using GreenSpaceDAL;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using GreenSpaceCL;

namespace GreenSpace
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
     [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public string GetMapReport(ClCuttingTree oobbjj)
        {
            //string text = File.ReadAllText(@"D:\B\file.txt", Encoding.UTF8);
            //return text;
            ClCuttingTree cl2 = new ClCuttingTree();
            if(oobbjj.PersonalId!=0)
            cl2.PersonalId = oobbjj.PersonalId;  // Convert.ToInt32(Session["PersonalID"].ToString()==null  ? "1":"0");
            if(oobbjj.id!=0)
            cl2.id = oobbjj.id;
           // cl2.PersonalId = 1;// Convert.ToInt32(objj.PersonalId);
            DataSet ds = CuttingTreeSpace.CuttingTreeClass2.GetList(cl2);
            List<ClCuttingTree> messages = new List<GreenSpaceCL.ClCuttingTree>();
            DataRow dr;
            if (ds == null)
                return "";

            if(ds.Tables[0].Rows.Count>0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ClCuttingTree cl = new ClCuttingTree();
                    cl.PersonalId = 1;
                    dr = ds.Tables[0].Rows[i];
                    cl.Bon=Convert.ToInt32(dr["Bon"].ToString()=="" ?"0":dr["Bon"].ToString());
                    cl.Address = dr["Address"].ToString();
                    cl.Count = Convert.ToInt32(dr["Count"].ToString() == "" ? "0" : dr["Count"].ToString());
                    cl.dddeeesssccc = dr["Desc"].ToString();
                    cl.Desc = dr["Desc"].ToString();
                    cl.GeoTree = dr["GeoTree"].ToString();
                    cl.LicesnceTypeid = Convert.ToInt32(dr["LicesnceTypeid"].ToString() == "" ? "0" : dr["LicesnceTypeid"].ToString());
                    cl.MantagheId = Convert.ToInt32(dr["MantagheId"].ToString() == "" ? "0" : dr["MantagheId"].ToString());
                    cl.Mojavez = Convert.ToInt32(dr["Mojavez"].ToString() == "True" ? "1" :"0");
                    cl.StreetTypeid = Convert.ToInt32(dr["StreetTypeid"].ToString() == "" ? "0" : dr["StreetTypeid"].ToString());
                    cl.Title=dr["Title"].ToString();
                    cl.TreeTypeId = Convert.ToInt32(dr["TreeTypeId"].ToString() == "" ? "0" : dr["TreeTypeId"].ToString());
                    cl.PointGeo = dr["PointGeo"].ToString();
                    cl.P=dr["P"].ToString();
                    cl.lat = dr["lat"].ToString();
                    cl.longg = dr["Long"].ToString();
                    cl.id = Convert.ToInt32(dr["id"].ToString());


                    messages.Add(cl);

                }
            }
         string ff=    GetPointGeoJasonBySubGroupColor(messages);
         return ff;


        }
        [WebMethod]
        public string deleteTree(ClCuttingTree oobbjj)
        {
           string ff=    CuttingTreeClass.Delete(Convert.ToInt32(oobbjj.PersonalId)).ToString();
         return ff;
 
        }


        public string GetPointGeoJasonBySubGroupColor(List<ClCuttingTree> messages)
        {
            ClCuttingTree msg = new ClCuttingTree();
            //List<ClTreeBonCuttingDB> groups = msg.PersonalID;
            string jason = "{" +
                           "\"type\": \"FeatureCollection\"," +
                           "\"crs\": { \"type\": \"name\", \"properties\": { \"name\": \"urn:ogc:def:crs:EPSG::32639\" } }," +
                           "\"features\": [";
            string p = "";
            foreach (ClCuttingTree db in messages)
            {
                if (!string.IsNullOrEmpty(db.PointGeo ))
                {
                    p = "["+db.lat+","+db.longg+"]";
                   // p = db.SHAPE.ToString().Remove(0, 6).Replace('(', '[').Replace(' ', ',').Replace(')', ']');
                    // messages cc = messages.Find(t => t.SubgroupId == db.SubGroupId);
                    string color = "#000000";
                    //if (db != null)
                    //    color = db.Icon;
                    jason +=
                        "{ \"type\": \"Feature\", \"properties\": { \"id\": \" " + db.id + "\" ,"+
                       "\"comment\": \" " + db.Desc + "\" ," +
                       "\"Address\": \" " + db.Address + "\" ," +
                       "\"DatePick\": \" " + db.date + "\" ," +
                       "\"Bon\": \" " + db.Bon + "\" ," +
                       "\"Count\": \" " + db.Count + "\" ," +
                       "\"Region\": \" " + db.MantagheId + "\" ," +
                       "\"LicesnceType\": \" " + db.LicesnceTypeid + "\" ," +
                       "\"StreetType\": \" " + db.StreetTypeid + "\" ," +
                         " \"Color\":\"" + color + "\" }, \"geometry\": { \"type\": \"Point\", \"coordinates\": " + p + " } },";
                }

            }
            jason = jason.Remove(jason.Length - 1, 1);
            jason += "]}";
            return jason;
        }
       

        [WebMethod]
        public string  savepoint(ClCuttingTree objectt)
        {
            
            ClCuttingTree cl = new ClCuttingTree();
            cl = objectt;
            int i = 0;
            ///cl.PersonalId = 1;
            if (objectt.id == 0 || objectt.id== null)
               i= CuttingTreeSpace.CuttingTreeClass2.insert(cl);
            else
                i=CuttingTreeSpace.CuttingTreeClass2.Update(cl);

            return i.ToString();
            //objectt.Bon = 0;
            //objectt.Count = 1;
            //string constr = ConfigurationManager.ConnectionStrings["GreenCnn"].ConnectionString;
            //using (SqlConnection con = new SqlConnection(constr))
            //{
            //    //using (SqlCommand cmd = new SqlCommand("INSERT INTO Tbl_CuttingTree(bon,Count,PointGeo) VALUES(@Bon, @Count,@PointGeo)"))

            //    using (SqlCommand cmd = new SqlCommand("PRC_CuttingTree_Insert"))
            //    {
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.Parameters.AddWithValue("@Bon", objectt.Bon);
            //        cmd.Parameters.AddWithValue("@Count", objectt.Count);
            //        cmd.Parameters.AddWithValue("@PointGeo", objectt.PointGeo);

            //        cmd.Connection = con;
            //        con.Open();
            //        cmd.ExecuteNonQuery();
            //        con.Close();
            //    }
            //}


        }





    }
}
