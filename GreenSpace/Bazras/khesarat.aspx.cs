using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GreenSpace.Bazras
{
    public partial class khesarat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CtlAgreementFine.NotDefaultAgree = true;
                CtlAgreementFine.AgreementID = Convert.ToInt32(Session["AgreeID"].ToString());
                CtlAgreementFine.BindDD();
                CtlAgreementFine.BindGrid();
                CtlAgreementFine.NotDefaultAgree = true;
                if (Session["sematID"].ToString() == "1")
                    CtlAgreementFine.VisibleInsert = false;
                CtlAgreementFine.VisibleDelete = false;
                CtlAgreementFine.VisibleEdit = false;

            }
        }
    }
}