using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TaxiDAL;

namespace GreenSpace.CityZen
{
    public partial class MapRegTree : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                 BindDDL();
                try
                {
                    if (HttpContext.Current.Request.Url.AbsolutePath == "/CityZen/MapRegTree.aspx")
                        txtPersonalID.Value = Session["PersonalID"].ToString();
                        else if(Request.QueryString["PersonalID"]!=null)
                        txtPersonalID.Value = Request.QueryString["PersonalID"].ToString();
                     else
                        txtPersonalID.Value = "0";
                }
                catch { }
                try
                {
                    if (Request.QueryString["id"] != null)
                        cuttingid = Request.QueryString["id"].ToString();
                    else
                        cuttingid = "0";
                 }
                catch { }
                try
                {
                    if (Request.QueryString["readonly"] != null)
                    {
                        dreg.Visible = false;
                    }
                }
                catch { }
            }
        }
        void BindDDL()
        {
            ddlTreeType.DataSource = CatalogClass.GetListTypeID("16");
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

       public  string cuttingid
        {
            get { return txtcuttingidd.Value.ToString(); }
            set { txtcuttingidd.Value = value.ToString(); }
         }


    }
}