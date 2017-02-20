using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GreenSpaceCL;
using GreenSpaceDAL;
using GreenSpaceBLL;
using TaxiDAL;
using System.Data;

namespace GreenSpace.CityZen
{
    public partial class RegTree : System.Web.UI.Page
    {

        //public string GetSaraInfo()
        //{
        //    GetSaraInfo
        //    SaraWebService ws = new SaraWebService;
        //    ws.
        //}
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindDDL();
            }
        }
        void BindDDL()
        {
            ddlTreeType.DataSource= CatalogClass.GetListTypeID("16");
            ddlTreeType.DataTextField = "CatalogName";
            ddlTreeType.DataValueField = "CaID";
            ddlTreeType.DataBind();
            ddlStreetType.DataSource = CatalogClass.GetListTypeID("12");
            ddlStreetType.DataTextField = "CatalogName";
            ddlStreetType.DataValueField = "CaID";
            ddlStreetType.DataBind();
            ddlLicesnceType.DataSource = CatalogClass.GetListTypeID("21");
            ddlLicesnceType.DataTextField = "CatalogName";
            ddlLicesnceType.DataValueField = "CaID";
            ddlLicesnceType.DataBind();
            ddRegion.DataSource = CatalogClass.GetListTypeID("2");
            ddRegion.DataTextField = "CatalogName";
            ddRegion.DataValueField = "CaID";
            ddRegion.DataBind();
        }
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            if (Session["PersonalID"] != null)
            {
                string pid = Session["PersonalID"].ToString();
                string hid = "";
                if (Session["HaghighiID"] != null)
                {
                    hid= Session["HaghighiID"].ToString();
                }
                string date = CtlDatePick.Text;

                //int e =Int16.Parse(CtlDatePick.Text.Length - 1);
                //date = CtlDatePick.Text.Remove(10, CtlDatePick.Text.Length - 1);


                int t = CuttingTreeClass.insert(ddlTreeType.SelectedValue, txtCount.Text, txtBon.Text, date, txtAddress.Text,
                "", "", ddlStreetType.SelectedValue, pid, null, "", ddRegion.SelectedValue, chkMojavez.Checked, hid,
                ddlLicesnceType.SelectedValue, "", "","4","9063");

                

                if (t == 0)
                {
                    LblMsg.ForeColor = System.Drawing.Color.Red;
                    LblMsg.Text = "خطا در ثبت";
                }
                else
                {
                    LblMsg.ForeColor = System.Drawing.Color.Green;
                    LblMsg.Text = "ثبت  انجام شد.";
                    kartable.Insert(null, "4", DateTime.Now, "", null, pid, null, "9063", t.ToString());
                    Response.Redirect("RequestList.aspx");
                    
                    
                }
            }
        }
    }
}