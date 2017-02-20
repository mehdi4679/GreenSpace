using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GreenSpace.Agree
{
    public partial class Price : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CtlAgreeExplanPrice11.AgreementID = Convert.ToInt32(Request.QueryString["aid"]);
                CtlAgreeExplanPrice11.BindDD();
                CtlAgreeExplanPrice11.BindGrid();
                CtlAgreeExplanPrice11.NotDefaultAgree = true;


            
            }
        }
    }
}