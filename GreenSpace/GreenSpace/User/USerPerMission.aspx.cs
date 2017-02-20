using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Taxi.Uservv
{
    public partial class USerPerMission : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                CtlUserPermission1.BindDD();
                CtlUserPermission1.BindGrid();

            }

        }
    }
}