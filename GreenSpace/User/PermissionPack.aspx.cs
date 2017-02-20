using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Taxi.Userff
{
    public partial class PermissionPack : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CtlUserPPack1.BindDD();
                CtlUserPPack1.BindGrid();

            }
        }
    }
}