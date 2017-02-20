using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using GreenSpaceCL;
using GreenSpaceDAL;

namespace GreenSpace.Controls
{
    public partial class CtlPercentHistory : System.Web.UI.UserControl
    {
        public string  AgreePercent
        {
            get { return lblAgreementPercentID.Text; }
            set { lblAgreementPercentID.Text = value; }
        }
        public void BindGrid()
        {
            ClPercentHistory cl = new ClPercentHistory();
            cl.AgreementPercentID = Convert.ToInt32(lblAgreementPercentID.Text==""?"0":lblAgreementPercentID.Text);

            DataSet ds =  PercentHistoryClass.GetList(cl);
            DataView dv = new DataView(ds.Tables[0]);
            if ( ViewState["PercentHistory"]  == null)
            {
                ViewState["PercentHistory"] = "HistoryPercentID Desc";
            }
            dv.Sort = Securenamespace.SecureData.CheckSecurity(ViewState["PercentHistory"].ToString()).ToString();
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
            string StrSortDirection = "desc";
            if (ViewState["PercentHistory" + "Direction"] == null)
            {
                ViewState.Add("PercentHistory" + "Direction", "desc");
            }
            else
            {
                StrSortDirection = CSharp.PublicFunction.secure(ViewState["PercentHistory" + "Direction"].ToString());
            }
            if (StrSortDirection == "desc")
            {
                StrSortDirection = "asc";
            }
            else
            {
                StrSortDirection = "desc";
                ViewState["PercentHistory" + "Direction"] = StrSortDirection;
            }
            ViewState["PercentHistory"] = e.SortExpression + " " + StrSortDirection;
            BindGrid();
        }
        //public void DeleteItem(object sender, System.EventArgs e)
        //{
        //    String HistoryPercentID = ((HtmlAnchor)sender).HRef.ToString();
        //    int i =  PercentHistoryClass.Delete(Convert.ToInt32(HistoryPercentID));
        //    if (i == 0)
        //    {
        //        LblMsg.Text = " error ";
        //        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), Guid.NewGuid().ToString(), "alert('خطا در حذف');", true);
        //    }
        //    else { BindGrid(); }
        //    LightBox.Value = "0";
        //}
        //public void UpItem(object sender, EventArgs e)
        //{
        //    String HistoryPercentID = ((HtmlAnchor)sender).HRef.ToString();
        //}
    
    }
}