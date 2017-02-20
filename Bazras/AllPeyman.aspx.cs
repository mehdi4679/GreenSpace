using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GreenSpaceDAL;
using GreenSpaceBLL;
using GreenSpaceCL;
using System.Data;
using TaxiCL;
using TaxiDAL;
using System.Web.UI.HtmlControls;

namespace GreenSpace.Bazras
{
    public partial class AllPeyman : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindGrid();
                //var liActive = (HtmlGenericControl)Master.FindControl("navbar22");
                //liActive.Visible = false;

            }
            if (CSharp.PublicFunction.GetUserID() == "")
                Response.Redirect("/Logout.aspx");
        }
        private void BindGrid()
        {
            ClAgreement cl = new ClAgreement();
            cl.UserID=Convert.ToInt32( CSharp.PublicFunction.GetUserID()) ;
            DataSet ds = AgreementClass.GetListUserPeyman(cl);
            DataView dv = new DataView(ds.Tables[0]);
            if (ViewState["AgreementID "] == null)
                ViewState["AgreementID"] = "AgreementID Desc";
            dv.Sort = ViewState["AgreementID"].ToString();
            GridView1.DataSource = dv;
            GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            BindGrid();
        }
        protected void GridView1_Sorting(object sender, System.Web.UI.WebControls.GridViewSortEventArgs e)
        {
            string StrSortDirection;
            if (ViewState["AgreementID" + "Direction"] == null)
            {
                ViewState.Add("AgreementID" + "Direction", "desc");
            }

            StrSortDirection = Securenamespace.SecureData.CheckSecurity(ViewState["AgreementID" + "Direction"].ToString());

            if (StrSortDirection == "desc")
                StrSortDirection = "asc";
            else
                StrSortDirection = "desc";

            ViewState["AgreementID" + "Direction"] = StrSortDirection;
            ViewState["AgreementID"] = e.SortExpression + " " + StrSortDirection;
            BindGrid();
        }

        public void UpItem(object sender, System.EventArgs e)
        {
            String AgreeID = ((HtmlAnchor)sender).HRef.ToString();
               string agreename=((HtmlAnchor)sender).Attributes["aname"].ToString();
            Session["AgreeID"] = AgreeID.ToString();
            Session["Agreename"] = agreename;

            Response.Redirect("~/Bazras/AgreePercent2.aspx?pname="+agreename);
        }

      
    }
}