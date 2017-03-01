using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using    GreenSpaceCL;
using GreenSpaceDAL;

namespace GreenSpace.Agree
{
    public partial class AgreePercent : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
                    DateTime sd = DateTime.Now ;
            DateTime ed;
            try
            {

                if (!Page.IsPostBack)
                {
                    CtlAgreementPercent111.NotDefaultAgree = true;
                    CtlAgreementPercent111.AgreementID = Convert.ToInt32(Request.QueryString["aid"]);
                    CtlAgreementPercent111.onlyActive = 0;

                    CtlAgreementPercent111.BindDD();
                    CtlAgreementPercent111.BindGrid();
                    CtlAgreementPercent111.NotDefaultAgree = true;


                }
                CtlAgreementPercent111.Bindtbljarime();


            }
            catch (Exception ex)
            {
                 ed = DateTime.Now ;
                 var lineNumber = new System.Diagnostics.StackTrace(ex, true).GetFrame(0).GetFileLineNumber();
                clError cl = new clError();
                cl.ErrorLog = ex.Message.ToString();
                cl.Page= HttpContext.Current.Request.Url.OriginalString;
                cl.timeLeft = (ed - sd).TotalSeconds.ToString() ;
                cl.IP= CSharp.PublicFunction.GetIPAddress();
                ErrorDAL.insert(cl);
             }
        }
    }
}