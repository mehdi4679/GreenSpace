using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using GreenSpaceCL;
using GreenSpaceDAL;
using System.Data.SqlClient;
using System.Data;

namespace GreenSpace.WebService
{
    /// <summary>
    /// Summary description for AgreePercent
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AgreePercent : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string AgreePercent_Get(int AgreeID,string VisitDate) {

            try
            {
                ClAgreementPercent cl = new ClAgreementPercent();
                cl.AgreementID = AgreeID;
                cl.VisitDate = DateConvert.sh2m(VisitDate).ToString();
                DataSet ds = AgreementPercentClass.GetList(cl);
                return ds.GetXml();
            }
            catch {
                return null;
            }

        }

        [WebMethod]
        public string AgreePercent_Delete(string AgreePercentID) {
            try
            {
                return (AgreementPercentClass.Delete(AgreePercentID).ToString());
            }
            catch {
                return null;
            }
            
        }

        [WebMethod]
        public string AgreePercent_Save(string AgreementPercentID,string AgreementID,
            string ExplainID,string utilityPersent,string SuperVisorID,string VisitDate,
            string FineFactor,string JarimeComment,string FineMeterOrRepeat)
        {
            try
            {
                ClAgreementPercent cl = new ClAgreementPercent();
                cl.AgreementID = Convert.ToInt32(AgreementID);
                cl.AgreementPercentID = Convert.ToInt32(AgreementPercentID);
                cl.ExplainID = Convert.ToInt32(ExplainID);
                cl.FineFactor = Convert.ToInt32(FineFactor);
                cl.FineMeterOrRepeat = Convert.ToInt32(FineMeterOrRepeat);
                cl.JarimeComment = JarimeComment;
                cl.SuperVisorID = Convert.ToInt32(SuperVisorID);
                cl.utilityPersent = Convert.ToInt32(utilityPersent);
                cl.VisitDate = DateConvert.sh2m(VisitDate).ToString();
                int t = 0;
                if (AgreementPercentID == null || AgreementPercentID == "0" || AgreementPercentID == "")
                    t = AgreementPercentClass.insert(cl);
                else
                    t = AgreementPercentClass.Update(cl);

                return t.ToString();
            }
            catch {
                return "0";
            }

        }







    }
}
