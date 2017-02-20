using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GreenSpace.Manage
{
    public partial class Explain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {


                CtlExplanSubject1.BindDD();
               BindSubject();
                CtlExplanSubject1.SubJectID = Convert.ToInt32(ddsubject.SelectedValue);
 
                CtlExplanSubject1.BindGrid();
                CtlExplanSubject1.EnableSubject = false;
                
            }
        }

        private void BindSubject() {

            ddsubject.DataSource = TaxiDAL.CatalogClass.GetListTypeID("3");
            ddsubject.DataTextField = "CatalogName";
            ddsubject.DataValueField = "CatalogValue";
            ddsubject.DataBind();
        }

      

        protected void ddsubject_SelectedIndexChanged1(object sender, EventArgs e)
        {
            CtlExplanSubject1.SubJectID =Convert.ToInt32( ddsubject.SelectedValue );
            CtlExplanSubject1.BindGrid();
        }
 




    }
}