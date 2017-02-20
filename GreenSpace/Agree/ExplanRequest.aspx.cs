using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GreenSpace.Agree
{
    public partial class ExplanRequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                //CtlExplanRequest1.ForUserID = CSharp.PublicFunction.GetUserID();
                CtlExplanRequest1.BindDD();
                CtlExplanRequest1.ForAgreementID = Request.QueryString["Aid"].ToString();
                CtlExplanRequest1.BindGrid();
            }
        }
    }
}