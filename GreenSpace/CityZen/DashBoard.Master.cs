using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GreenSpace.CityZen
{
    public partial class DashBoard : System.Web.UI.MasterPage
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Page.Theme = "Theme3";
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void exit_ServerClick(object sender, EventArgs e)
        {
            System.Web.Security.FormsAuthentication.SignOut();
            Session.Clear();

            Response.Redirect("/Home.aspx");
        }      
    }
}