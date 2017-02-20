using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GreenSpaceDAL;
using System.Data;
using System.Web.UI.HtmlControls;
namespace GreenSpace.Controls
{
    public partial class CtlArzeshBasari : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid(); BindDD();
            }
        }
        public void BindDD()
        {
            DDStreetTypeId.DataSource = TaxiDAL.CatalogClass.GetListTypeID("12");
            DDStreetTypeId.DataTextField = "CatalogName";
            DDStreetTypeId.DataValueField = "CatalogValue";
            DDStreetTypeId.DataBind();

            DDBasariRotbehId.DataSource = TaxiDAL.CatalogClass.GetListTypeID("17");
            DDBasariRotbehId.DataTextField = "CatalogName";
            DDBasariRotbehId.DataValueField = "CatalogValue";
            DDBasariRotbehId.DataBind();

            DDyear.DataSource = TaxiDAL.CatalogClass.GetListTypeID("14");
            DDyear.DataTextField = "CatalogName";
            DDyear.DataValueField = "CatalogValue";
            DDyear.DataBind();
            //     BindPeyman();
        }
        public void BindGrid()
        {
            DataSet ds =ArzeshBasariClass.GetList(null, null, null, null, null);
            DataView dv = new DataView(ds.Tables[0]);
            //if (Securenamespace.SecureData.CheckSecurity(ViewState["ArzeshBasari"].ToString()) == null)
            //{
            //    ViewState["ArzeshBasari"] = "id Desc";
            //}
            //dv.Sort = Securenamespace.SecureData.CheckSecurity(ViewState["ArzeshBasari"].ToString()).ToString();
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
            //string StrSortDirection = "desc";
            //if (ViewState["ArzeshBasari" + "Direction"] == null)
            //{
            //    ViewState.Add("ArzeshBasari" + "Direction", "desc");
            //}
            //else
            //{
            //    StrSortDirection = CSharp.PublicFunction.secure(ViewState["ArzeshBasari" + "Direction"].ToString());
            //}
            //if (StrSortDirection == "desc")
            //{
            //    StrSortDirection = "asc";
            //}
            //else
            //{
            //    StrSortDirection = "desc";
            //    ViewState["ArzeshBasari" + "Direction"] = StrSortDirection;
            //}
            //ViewState["ArzeshBasari"] = e.SortExpression + " " + StrSortDirection;
            //BindGrid();
        }
        public void DeleteItem(object sender, System.EventArgs e)
        {
            String id = ((HtmlAnchor)sender).HRef.ToString();
            int i = ArzeshBasariClass.Delete(Convert.ToInt32(id));
            if (i == 0)
            {
                LblMsg.Text = " error ";
                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), Guid.NewGuid().ToString(), "alert('خطا در حذف');", true);
            }
            else { BindGrid(); }
            LightBox.Value = "0";
        }
        public void UpItem(object sender, EventArgs e)
        {
          
            String id = ((HtmlAnchor)sender).HRef.ToString();
            DataSet ds = ArzeshBasariClass.GetList(id, null, null, null, null);
            DataRow dr = ds.Tables[0].Rows[0];
            TXTid.Text = id;
            TXTArzeshBasari.Text = dr["ArzeshBasari"].ToString();
            
            DDyear.SelectedValue = dr["year"].ToString();
            DDBasariRotbehId.SelectedValue = dr["BasariRotbehId"].ToString();
            DDStreetTypeId.SelectedValue = dr["StreetTypeId"].ToString();

            EmptyLight();
            LightBox.Value = "1";
            BtnInsert.Visible = false;
            BtnSerach.Visible = false;
            BtnUpdate.Visible = true;
        }
        protected void btnInsertLight_Click(object sender, EventArgs e)
        {
            EmptyLight();
            LightBox.Value = "1";
            BtnInsert.Visible = true;
            BtnSerach.Visible = false;
            BtnUpdate.Visible = false;
        }
        protected void btnSerachLight_Click(object sender, EventArgs e)
        {
            EmptyLight();
            BtnSerach.Visible = true;
            BtnInsert.Visible = false;
            BtnUpdate.Visible = false;
        }
        protected void BtnSerach_Click1(object sender, EventArgs e)
        {
            DataSet ds = ArzeshBasariClass.GetList(null, null, null, null, null);
            DataView dv = new DataView(ds.Tables[0]);
            String StrSort = Securenamespace.SecureData.CheckSecurity(ViewState["ArzeshBasari"].ToString());
            if (StrSort != null)
            {
                dv.Sort = StrSort;
            }
            GridView1.DataSource = dv;
            GridView1.DataBind();
        }
        protected void BtnInsert_Click(Object sender, System.EventArgs e)
        {
            int t =ArzeshBasariClass.insert(DDStreetTypeId.SelectedValue.ToString(),DDBasariRotbehId.SelectedValue.ToString(),TXTArzeshBasari.Text,DDyear.SelectedValue.ToString());
            if (t == 0)
            {
                LblMsg.ForeColor = System.Drawing.Color.Red;
                LblMsg.Text = "خطا در ثبت";
            }
            else
            {
                LblMsg.ForeColor = System.Drawing.Color.Green;
                LblMsg.Text = "ثبت  انجام شد.";
                BindGrid();
            }
        }
        protected void EmptyLight()
        {
        }
        protected void BtnUpdate_Click1(object sender, EventArgs e)
        {
            int i = ArzeshBasariClass.Update(TXTid.Text ,DDStreetTypeId.SelectedValue.ToString(), DDBasariRotbehId.SelectedValue.ToString(), TXTArzeshBasari.Text, DDyear.SelectedValue.ToString());
            if (i == 0)
            {
                LblMsg.ForeColor = System.Drawing.Color.Red;
                LblMsg.Text = "خطا";
            }
            else
            {
                LblMsg.ForeColor = System.Drawing.Color.Green;
                LblMsg.Text = "ویرایش انجام شد";
                BindGrid();
            }
        }

    }
}