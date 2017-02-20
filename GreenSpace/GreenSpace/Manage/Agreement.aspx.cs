using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GreenSpace.Manage
{
    public partial class Agreement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!Page.IsPostBack) {
                CtlAgreement1.BindDD();
                CtlAgreement1.BindGrid();
                if (Session["semat"].ToString()== "3")
                {
                    CtlAgreement1.VisibleDelete = false;
                    CtlAgreement1.VisibleInsert = false;
                    CtlAgreement1.VisibleEdit = false;
                }
            }

        }
    }
}