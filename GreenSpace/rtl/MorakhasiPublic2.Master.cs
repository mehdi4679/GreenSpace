using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Taxi.rtl
{
    public partial class MorakhasiPublic2 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["sherkat"] != "true")
                    LiPaziresh.Visible = false;
            }
        }


        protected void aexit_ServerClick(object sender, EventArgs e)
        {
            System.Web.Security.FormsAuthentication.SignOut();
            Session.Clear();

            Response.Redirect("/Loginvacation.aspx");
        }
    }
}