using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GreenSpaceDAL;
using GreenSpaceCL;
using System.Data.SqlClient;
using System.Data;
using TaxiDAL;

namespace GreenSpace.Controls.TreeControls
{
    public partial class CtlRegTreeIFram : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindDDL();
                txtPersonalID.Value = "1";
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

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            ClCuttingTree cl = new ClCuttingTree();
            cl.Address = txtAddress.Text;
            cl.Bon =Convert.ToInt32( txtBon.Text);
            cl.Count = Convert.ToInt32( txtCount.Text);
            cl.date = CtlDatePick.Text;
            cl.dddeeesssccc = txtcomment.Text;
            cl.Desc = txtcomment.Text;
            cl.GeoTree = latlong.Value;
            cl.HaghighiId =Convert.ToInt32( txtHaghighiId.Value);
            cl.id = Convert.ToInt32( txtid.Value);
            cl.LicesnceTypeid = 0;
            cl.MantagheId = Convert.ToInt32( ddRegion.SelectedValue);
            cl.StreetTypeid = Convert.ToInt32( ddlStreetType.SelectedValue);
            cl.TreeTypeId=Convert.ToInt32( ddlTreeType.SelectedValue);
            int i = 0;

            if (cl.id == 0)
               i= CuttingTreeSpace.CuttingTreeClass2.insert(cl);
            else
                i=CuttingTreeSpace.CuttingTreeClass2.Update(cl);

            if (i == 0)
                CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "خطا در ثبت");


        }



    }
}