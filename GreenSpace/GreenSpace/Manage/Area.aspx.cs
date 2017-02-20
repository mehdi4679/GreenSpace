using GreenSpace.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GreenSpace.Manage
{
    public partial class Area : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
       CtlRegionPark.calll nc1 = new CtlRegionPark.calll(CtlArea1.BindGrid);
            if (!Page.IsPostBack) {
                CtlArea1.BindDD();
                CtlArea1.BindGrid();

            }
     
        }
    }
}