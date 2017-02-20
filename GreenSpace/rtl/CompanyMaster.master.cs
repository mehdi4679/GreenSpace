using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using TaxiCL;
using TaxiDAL;
namespace Taxi.rtl
{
    public partial class CompanyMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.QueryString["cname"] == null)
                {
                    ClCompany cl = new ClCompany();
                    cl.companyID =Convert.ToInt32( Request.QueryString["cid"]);
                    DataSet ds = CompanyClass.GetList(cl);
                    DataRow dr = ds.Tables[0].Rows[0];
                    lblCompanyName.Text = dr[""].ToString();
                }
                   lblCompanyName.Text = Request.QueryString["cname"].ToString();

            }
            catch { }
        }
    }
}