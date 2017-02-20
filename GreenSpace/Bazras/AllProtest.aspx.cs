using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GreenSpace.Bazras
{
    public partial class AllProtest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                CtlAgreePercentProtest.BindDD();
                if (Request.QueryString["apid"] != null)
                    CtlAgreePercentProtest.AgreementPercentID = Convert.ToInt32(Request.QueryString["apid"].ToString());
                else
                    CtlAgreePercentProtest.AgreementPercentID = 0;

                CtlAgreePercentProtest.UserResponseID2 = Convert.ToInt32(Session["UserID"].ToString());


                CtlAgreePercentProtest.BindGrid();

            }
        }





    }
}