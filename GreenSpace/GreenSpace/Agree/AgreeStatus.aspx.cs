using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GreenSpace.Agree
{
    public partial class AgreeStatus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
               
                CtlAgreeStatus1.AgreementID = Convert.ToInt32(Request.QueryString["aid"]);
                CtlAgreeStatus1.BindDD();
                CtlAgreeStatus1.BindGrid();
                
            }
        }
    }
}