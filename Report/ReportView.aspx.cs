using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.Reporting.WebForms;
 

namespace GreenSpace.Report
{
    public partial class ReportView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ReportViewer1.ProcessingMode = ProcessingMode.Local;


                ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Report/" + Request.QueryString["RName"].ToString() + ".rdlc");
                //if (Request.QueryString["RName"].ToString() == "Rp_ExplainPrice")
                //    ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Report/Rp_ExplainPrice.rdlc");

                //Customers dsCustomers = GetData("select top 20 * from customers");
                //ReportDataSource datasource = new ReportDataSource("Customers", dsCustomers.Tables[0]);
                ReportViewer1.LocalReport.DataSources.Clear();

                DataSet ddss = (DataSet)Session["ReportData"];
              //  ddss.Tables[0].TableName = "DataSource1";
                    ReportDataSource ds = new ReportDataSource("DataSet1", ddss.Tables[0]);
                ReportViewer1.LocalReport.DataSources.Add(ds);
            }

        }
    }
}