using GreenSpaceDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GreenSpace.Report.ReportTree
{
    public partial class CuttingTree : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDD();
            }
             
        }
        public void BindDD()
        {

      

            DDMantagheId.DataSource = TaxiDAL.CatalogClass.GetListTypeID("2");
            DDMantagheId.DataTextField = "CatalogName";
            DDMantagheId.DataValueField = "CatalogValue";
            DDMantagheId.DataBind();



        }

        protected void btnprint_Click1(object sender, EventArgs e)
        {
             DataSet ds =CuttingTreeClass.RepGetList(null,CtlFromDateToDate.FromDate,CtlFromDateToDate.ToDate,DDMantagheId.SelectedValue.ToString());// LicensingTreeClass.GetReportList(null, null, null, CtlFromDateToDate.FromDate, DDLicesnceTypeid.SelectedValue.ToString(), null, null, DDMantagheId.SelectedValue.ToString(), CtlFromDateToDate.ToDate);



         

            Session["ReportData"] = ds;
            //Response.Redirect("~/Report/ReportTree/ReportViewTree.aspx?RName=ReportTree/Rp_Cutting");

            MyIfarm.Visible = true;

            MyIfarm.Attributes.Add("src", "~/Report/ReportTree/ReportViewTree.aspx?RName=ReportTree/Rp_Cutting");

        
        }
        
    }
}