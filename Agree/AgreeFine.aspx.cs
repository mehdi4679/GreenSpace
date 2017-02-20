using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GreenSpace.Agree
{
    public partial class AgreeFine : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                CtlAgreementFine11.NotDefaultAgree = true;
                CtlAgreementFine11.AgreementID = Convert.ToInt32(Request.QueryString["aid"]);
                CtlAgreementFine11.BindDD();
                CtlAgreementFine11.BindGrid();
                CtlAgreementFine11.NotDefaultAgree = true;
            }
        }
    }
}