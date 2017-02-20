using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GreenSpace.Manage
{
    public partial class DefaultPrice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CtlAgreeExplanPrice1.NotDefaultAgree = false;
                CtlAgreeExplanPrice1.BindDD();
                CtlAgreeExplanPrice1.BindGrid();

            }
        }
    }
}