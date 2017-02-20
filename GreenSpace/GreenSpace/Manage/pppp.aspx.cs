using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace GreenSpace.Manage
{
    public partial class pppp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                 BindPeyman();

                Ctlpp.AgrrementID = 0;
                Ctlpp.ParkDistrict =Convert.ToInt32( ddPeyman.SelectedValue);
                Ctlpp.BindDD();
               
                Ctlpp.PeymanID = ddPeyman.SelectedValue.ToString();
                Ctlpp.BindGrid();
                Ctlpp.EnableDDPeyman = false;

            }
        }
        private void BindPeyman() { 
        GreenSpaceCL.ClPeyman cl=new GreenSpaceCL.ClPeyman();

        ddPeyman.DataSource = GreenSpaceDAL.PeymanClass.GetList(cl);
        ddPeyman.DataTextField = "PeymanName";
        ddPeyman.DataValueField = "PeymanID";
        ddPeyman.DataBind();

        }

        protected void ddPeyman_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ctlpp.PeymanID = ddPeyman.SelectedValue.ToString();
            Ctlpp.BindGrid();
            Ctlpp.ParkDistrict =Convert.ToInt32( ddPeyman.SelectedValue);

        }
    }
}