using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using TaxiDAL;
using TaxiCL;

namespace Taxi.rtl
{
    public partial class TaxiMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblpageName.Text =Securenamespace.SecureData.CheckSecurity( Request.QueryString["pname"]);
             //
            if (!Page.IsPostBack)
            {
                if (Session["semat"]  == "3" && !Request.Url.AbsolutePath.ToLower().Contains("agreement.aspx") &&
                    (Request.Url.AbsolutePath.ToLower().Contains("manage") || Request.Url.AbsolutePath.ToLower().Contains("user") || Request.Url.AbsolutePath.ToLower().Contains("dashboard.aspx")))
                    Response.Redirect("~/manage/Agreement.aspx");

            }

        }
    }
}