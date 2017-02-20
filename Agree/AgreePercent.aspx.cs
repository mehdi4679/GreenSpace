using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GreenSpace.Agree
{
    public partial class AgreePercent : System.Web.UI.Page
    {
         
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
  CtlAgreementPercent111.NotDefaultAgree = true;
                CtlAgreementPercent111.AgreementID = Convert.ToInt32(Request.QueryString["aid"]);
                CtlAgreementPercent111.BindDD();
                CtlAgreementPercent111.BindGrid();
                CtlAgreementPercent111.NotDefaultAgree = true;
            }
            CtlAgreementPercent111.Bindtbljarime();

        }
    }
}