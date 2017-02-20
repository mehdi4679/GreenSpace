using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GreenSpace.Manage
{
    public partial class DefaultRepeat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CtlAgreeExplanRepeat11.NotDefaultAgree = false;
                CtlAgreeExplanRepeat11.AgrrementID = 0;
                CtlAgreeExplanRepeat11.BindDD();
                BindSubject();
                CtlAgreeExplanRepeat11.SubjectID = ddsubject.SelectedValue;
                CtlAgreeExplanRepeat11.BindGrid();
                

                CtlAgreeExplanRepeat11.NotDefaultAgree = false;

            }

        }
        private void BindSubject()
        {

            ddsubject.DataSource = TaxiDAL.CatalogClass.GetListTypeID("3");
            ddsubject.DataTextField = "CatalogName";
            ddsubject.DataValueField = "CatalogValue";
            ddsubject.DataBind();
        }
        protected void ddsubject_SelectedIndexChanged1(object sender, EventArgs e)
        {
            CtlAgreeExplanRepeat11.SubjectID =  ddsubject.SelectedValue  ;
            CtlAgreeExplanRepeat11.BindGrid();
        }
    }
}