using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GreenSpace.Bazras
{
    public partial class AgreePercent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["AgreeID"] == null) {
                    Response.Redirect("~/Bazras/AgreePercent.aspx");
                    return;
                }
                CtlAgreementPercent111.NotDefaultAgree = true;
                CtlAgreementPercent111.AgreementID = Convert.ToInt32(Session["AgreeID"]);
                CtlAgreementPercent111.BindDD();
                CtlAgreementPercent111.BindGrid();
                CtlAgreementPercent111.NotDefaultAgree = true;
                if (Session["semat"].ToString() == "1")
                {
                    CtlAgreementPercent111.Setpeymankar();

                }
                else if (Session["semat"].ToString() == "6" || Session["semat"].ToString() == "4" || Session["semat"].ToString() == "2")
                    CtlAgreementPercent111.SetNazer(Session["UserID"].ToString());


                if (Session["sematID"].ToString() == "2")
                    CtlAgreementPercent111.ISNzareAli =Convert.ToBoolean( "True");
                else
                    CtlAgreementPercent111.ISNzareAli =Convert.ToBoolean(  "False");

                if (Session["sematID"].ToString() == "4")
                     CtlAgreementPercent111.VisibleInsertBtn = false;


                if (Session["sematID"].ToString() == "6")
                    CtlAgreementPercent111.visibleDelClo = false; 


            }

            CtlAgreementPercent111.Bindtbljarime();

        }
    }
}