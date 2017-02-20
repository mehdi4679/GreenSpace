using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace GreenSpace
{
    public partial class RegPersonal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            var dwizard = (HtmlGenericControl)Master.FindControl("dwiz");
            dwizard.Visible = false;

            var navigationHeader = (HtmlGenericControl)Master.FindControl("navigationHeader");
            navigationHeader.Visible = false;

            CtlPerson1.RedirectPage = "/public/PersonalView.aspx";
            CtlPerson1.UpdateMode = false;

         
        }
    }
}