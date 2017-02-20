using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using GreenSpaceDAL;
using GreenSpaceCL;
using System.Data;
using System.Data.SqlClient;

namespace GreenSpace.WebService
{
    /// <summary>
    /// Summary description for AgreeProtest
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AgreeProtest : System.Web.Services.WebService
    {


        [WebMethod]
        public string AgreeProtest_Save(string AgreePercentProtestID, string AgreementPercentID,
            string ProtestComment, string ProtestDate, string UserResponseID
            )
        {
            try
            {
                ClAgreePercentProtest cl = new ClAgreePercentProtest();
                cl.AgreementPercentID = Convert.ToInt32(AgreementPercentID);
                cl.AgreePercentProtestID = Convert.ToInt32(AgreePercentProtestID);
                cl.ProtestComment = ProtestComment;
                cl.ProtestDate = DateConvert.sh2m(ProtestDate).ToString();
                cl.UserResponseID = Convert.ToInt32(UserResponseID);
                int y = 0;
                if (AgreePercentProtestID == null || AgreePercentProtestID == "" || AgreePercentProtestID == "0")
                    y = AgreePercentProtestClass.insert(cl);
                else
                    y = AgreePercentProtestClass.Update(cl);

                return y.ToString();
            }
            catch
            {
                return "0";
            }
        }

        [WebMethod]
        public string AgreeProtest_delete(string AgreePercentProtestID)
        {
            try
            {
                return AgreePercentProtestClass.Delete(AgreePercentProtestID).ToString();
            }
            catch
            {
                return "0";
            }
        }



    }
}
