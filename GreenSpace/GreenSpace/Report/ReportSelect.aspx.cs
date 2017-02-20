using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using GreenSpaceCL;
using GreenSpaceDAL;

namespace GreenSpace.Report
{
    public partial class ReportSelect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                dAgree.Visible = false;

                if (Request.QueryString["RName"].ToString() == "Rp_SubjectPrice"
                    || Request.QueryString["RName"].ToString() == "Rp_ExplainPrice2"
                    )
                {
                    ClAgreement cl = new ClAgreement();

                    ddAgree.DataSource = AgreementClass.GetList(cl);
                    ddAgree.DataTextField = "AggreeName";
                    ddAgree.DataValueField = "AgreementID";
                    ddAgree.DataBind();
                    ddAgree.Items.Insert(0, new ListItem("پیش فرض", "0"));
                    dAgree.Visible = true;

                }

            }
        }

        protected void btnprint_Click(object sender, EventArgs e)
        {
            DataSet ds=null;
            
            if (Request.QueryString["RName"].ToString() == "Rp_SubjectPrice"
                    || Request.QueryString["RName"].ToString() == "Rp_ExplainPrice2"
                    )
            {
                ClAgreement cl = new ClAgreement();
                cl.AgreementID =Convert.ToInt32( ddAgree.SelectedValue.ToString());
                cl.FromDateReport = CtlFromDateToDate.FromDate.ToString() ;
                cl.ToDateReport = CtlFromDateToDate.ToDate ;
           
            
                if (Request.QueryString["RName"].ToString() == "Rp_SubjectPrice")
                ds = AgreementClass.GetListSubjectPrice(cl);
                if (Request.QueryString["RName"].ToString() == "Rp_ExplainPrice2")
                ds = AgreementClass.GetListReport(cl);

           }
          


         Session["ReportData"] = ds;
            Response.Redirect("~/Report/reportview2.aspx?RName=" + Request.QueryString["RName"].ToString()+"&PName="+Request.QueryString["PName"].ToString());

        }
    }
}