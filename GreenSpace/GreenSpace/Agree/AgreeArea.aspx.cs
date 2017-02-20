using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GreenSpace.Agree
{
    public partial class AgreeArea : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                CtlAgreeArea11.AgreementID = Convert.ToInt32(Request.QueryString["aid"]);
                
                CtlAgreeArea11.BindDD();
                CtlAgreeArea11.BindGrid();
           
            }
        }
    }
}