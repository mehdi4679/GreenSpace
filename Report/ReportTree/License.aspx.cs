using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Reporting.WebForms;
using System.Data;
using GreenSpaceDAL;

namespace GreenSpace.Report.ReportTree
{
    public partial class License : System.Web.UI.Page
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

            DDLicesnceTypeid.DataSource = TaxiDAL.CatalogClass.GetListTypeID("21");
            DDLicesnceTypeid.DataTextField = "CatalogName";
            DDLicesnceTypeid.DataValueField = "CatalogValue";
            DDLicesnceTypeid.DataBind();

            DDMantagheId.DataSource = TaxiDAL.CatalogClass.GetListTypeID("2");
            DDMantagheId.DataTextField = "CatalogName";
            DDMantagheId.DataValueField = "CatalogValue";
            DDMantagheId.DataBind();



        }

        public  void btnprint_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnprint_Click1(object sender, EventArgs e)
        {
            DataSet ds = LicensingTreeClass.GetReportList(null, null, null, CtlFromDateToDate.FromDate, DDLicesnceTypeid.SelectedValue.ToString(), null, null, DDMantagheId.SelectedValue.ToString(), CtlFromDateToDate.ToDate);



            //ReportViewer1.ProcessingMode = ProcessingMode.Local;


            //ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Report/ReportTree/" + "Rp_License.rdlc");
            ////if (Request.QueryString["RName"].ToString() == "Rp_ExplainPrice")
            ////    ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Report/Rp_ExplainPrice.rdlc");

            ////Customers dsCustomers = GetData("select top 20 * from customers");
            ////ReportDataSource datasource = new ReportDataSource("Customers", dsCustomers.Tables[0]);
            //ReportViewer1.LocalReport.DataSources.Clear();


            ////  ddss.Tables[0].TableName = "DataSource1";
            //ReportDataSource dsrep = new ReportDataSource("DataSet554", ds.Tables[0]);
            //ReportViewer1.LocalReport.DataSources.Add(dsrep);

            Session["ReportData"] = ds;
            //Response.Redirect("~/Report/ReportTree/ReportViewTree.aspx?RName=ReportTree/Rp_License");


            MyIfarm.Visible = true;

            MyIfarm.Attributes.Add("src", "~/Report/ReportTree/ReportViewTree.aspx?RName=ReportTree/Rp_License");

        }
    }
}