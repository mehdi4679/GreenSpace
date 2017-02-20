﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GreenSpaceDAL;
using System.Web.UI.HtmlControls;
namespace GreenSpace.Controls.TreeControls
{
    public partial class CtlRotbal : System.Web.UI.UserControl
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
            DDYear.DataSource = TaxiDAL.CatalogClass.GetListTypeID("14");
            DDYear.DataTextField = "CatalogName";
            DDYear.DataValueField = "CatalogValue";
            DDYear.DataBind();
            DDRotbalType.DataSource = TaxiDAL.CatalogClass.GetListTypeID("27");
            DDRotbalType.DataTextField = "CatalogName";
            DDRotbalType.DataValueField = "CatalogValue";
            DDRotbalType.DataBind();

            //     BindPeyman();
        }
        public void BindGrid()
        {
            DataSet ds = RotbalClass.GetList(null, null, null, null);
            if(ds!=null ){
            DataView dv = new DataView(ds.Tables[0]);
            //if (Securenamespace.SecureData.CheckSecurity(ViewState["Abbaha"].ToString()) == null)
            //{
            //    ViewState["Abbaha"] = "id Desc";
            //}
            //dv.Sort = Securenamespace.SecureData.CheckSecurity(ViewState["Abbaha"].ToString()).ToString();
            GridView1.DataSource = dv;
            GridView1.DataBind();}
        }
        protected void GridView1_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            BindGrid();
        }
        protected void GridView1_Sorting(object sender, System.Web.UI.WebControls.GridViewSortEventArgs e)
        {
            //string StrSortDirection = "desc";
            //if (ViewState["Abbaha" + "Direction"] == null)
            //{
            //    ViewState.Add("Abbaha" + "Direction", "desc");
            //}
            //else
            //{
            //    StrSortDirection = CSharp.PublicFunction.secure(ViewState["Abbaha" + "Direction"].ToString());
            //}
            //if (StrSortDirection == "desc")
            //{
            //    StrSortDirection = "asc";
            //}
            //else
            //{
            //    StrSortDirection = "desc";
            //    ViewState["Abbaha" + "Direction"] = StrSortDirection;
            //}
            //ViewState["Abbaha"] = e.SortExpression + " " + StrSortDirection;
            //BindGrid();
        }
        public void DeleteItem(object sender, System.EventArgs e)
        {
            String id = ((HtmlAnchor)sender).HRef.ToString();
            int i = RotbalClass.Delete(Convert.ToInt32(id));
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
            DataSet ds = RotbalClass.GetList(id, null, null, null);
            DataRow dr = ds.Tables[0].Rows[0];
            TXTRotbalId.Text = id;

            TXTMoney.Text = dr["Money"].ToString();
            DDRotbalType.SelectedValue = dr["RotbalType"].ToString();
            DDYear.SelectedValue = dr["Year"].ToString();

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
            DataSet ds = AbBahaClass.GetList(null, null, null, null, null);
            DataView dv = new DataView(ds.Tables[0]);
            String StrSort = Securenamespace.SecureData.CheckSecurity(ViewState["Abbaha"].ToString());
            if (StrSort != null)
            {
                dv.Sort = StrSort;
            }
            GridView1.DataSource = dv;
            GridView1.DataBind();
        }
        protected void BtnInsert_Click(Object sender, System.EventArgs e)
        {
            int t = RotbalClass.insert(TXTMoney.Text, DDYear.SelectedValue.ToString(), DDRotbalType.SelectedValue.ToString());
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
            int i = RotbalClass.Update(TXTRotbalId.Text, TXTMoney.Text, DDYear.SelectedValue.ToString(), DDRotbalType.SelectedValue.ToString());
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