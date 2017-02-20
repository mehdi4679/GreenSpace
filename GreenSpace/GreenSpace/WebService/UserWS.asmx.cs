using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Services;
using GreenSpaceCL;
using GreenSpaceDAL;

namespace GreenSpace.WebService
{
    /// <summary>
    /// Summary description for UserWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UserWS : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string UserVerify(string UserName, string Password)
        {

            var hash = FormsAuthentication.HashPasswordForStoringInConfigFile(Password + "~!@", "MD5");
                 try
            {     
                     DataSet ds = TaxiDAL.UsersClass.GetList(null, UserName, hash, null, null, null, null, null, null, null, null, null);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    DataRow dr = ds.Tables[0].Rows[0];
                    return dr["userID"].ToString();
                }
                else
                    return "0";

            }
            catch
            {
                return "-1";
            }

        }


        [WebMethod]
        public string UserPeyman(string UserName, string Password) {
        
                        var hash = FormsAuthentication.HashPasswordForStoringInConfigFile(Password + "~!@", "MD5");
                        try
                        {
                            DataSet ds = TaxiDAL.UsersClass.GetList(null, UserName, hash, null, null, null, null, null, null, null, null, null);
                            DataRow dr = ds.Tables[0].Rows[0];

                            ClAgreement cl = new ClAgreement();
                            if (dr["semat"].ToString() == "1")//user is peymankar
                                cl.PeymanKarID = Convert.ToInt32(dr["userid"]);
                            else
                                cl.supervisor2ID = Convert.ToInt32(dr["userid"]);


                            DataSet dspeyman = AgreementClass.GetList(cl);
                            return dspeyman.GetXml();




                        }
                        catch {
                            return null;
                        }

        }

         









    }
}
