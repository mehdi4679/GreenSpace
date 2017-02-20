using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Taxi.rtl
{
    public partial class MorakhasiPublic : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var sideMenu = (HtmlGenericControl)Master.FindControl("idebar_nav");
                sideMenu.Visible = false;
            }
        }
    }
}