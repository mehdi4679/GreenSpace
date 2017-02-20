using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GreenSpace.Agree
{
    public partial class Repeat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                
                  CtlAgreeExplanRepeat11.AgrrementID = Convert.ToInt32(Request.QueryString["aid"].ToString());
                  CtlAgreeExplanRepeat11.NotDefaultAgree = true;
              CtlAgreeExplanRepeat11.BindDD();
                CtlAgreeExplanRepeat11.BindGrid();
               





            }
        }
    }
}