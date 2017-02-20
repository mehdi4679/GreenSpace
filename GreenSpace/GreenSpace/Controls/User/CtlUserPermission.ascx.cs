using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TaxiCL;
using TaxiDAL;
using System.Data;
using System.Web.UI.HtmlControls;

namespace Taxi.Controls
{
    public partial class CtlUserPermission : System.Web.UI.UserControl
    {
        public ClUserPermission Data {
            get {
                ClUserPermission cl = new ClUserPermission();
                cl.CanDel = TXTCanDel.Checked;
                cl.CanInsert = TXTCanInsert.Checked;
                cl.CanUpdate = TXTCanUpdate.Checked;
                cl.CanView = TXTCanView.Checked;
                cl.UserID =Convert.ToInt32( DDUserID.SelectedValue);
                cl.PermissionID = Convert.ToInt32(DDPermissionID.SelectedValue);
                cl.UserPermissinID=Convert.ToInt32(LblParamUserPermissinID.Text);
                return cl;            
            }
            set {
                ClUserPermission cl = value;
                DataSet ds = UserPermissionClass.GetList(cl);
                DataRow dr=ds.Tables[0].Rows[0];
                TXTCanView.Checked =Convert.ToBoolean( dr["CanView"].ToString());
                TXTCanUpdate.Checked = Convert.ToBoolean(dr["CanUpdate"].ToString());
                TXTCanInsert.Checked = Convert.ToBoolean(dr["CanInsert"].ToString());
                TXTCanDel.Checked = Convert.ToBoolean(dr["CanDel"].ToString());
                DDUserID.SelectedValue = dr["UserID"].ToString();
                DDPermissionID.SelectedValue = dr["PermissionID"].ToString();
                LblParamUserPermissinID.Text = dr["UserPermissinID"].ToString();
            }
        }

        public void BindGrid()
        {
            ClUserPermission cl=new ClUserPermission();
            cl.UserID =Convert.ToInt32( DDUserID.SelectedValue );
            DataSet  ds = UserPermissionClass.GetList(cl);
            DataView dv = new DataView(ds.Tables[0]);
            if (ViewState["UserPermission"] == null)
            {
                ViewState["UserPermission"] = "UserPermissinID Desc";
            }
            dv.Sort = Securenamespace.SecureData.CheckSecurity(ViewState["UserPermission"].ToString()).ToString();
            GridView1.DataSource = dv;
            GridView1.DataBind();
            if (GridView1.Rows.Count > 0)
                BtnUpdate.Visible = true;
            else
                BtnUpdate.Visible = false;
        }
        protected void GridView1_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            BindGrid();
        }
        protected void GridView1_Sorting(object sender, System.Web.UI.WebControls.GridViewSortEventArgs e)
        {
            string StrSortDirection = "desc";
            if (ViewState["UserPermission" + "Direction"] == null)
            {
                ViewState.Add("UserPermission" + "Direction", "desc");
            }
            else
            {
                StrSortDirection =ViewState["UserPermission" + "Direction"].ToString();
            }
            if (StrSortDirection == "desc")
            {
                StrSortDirection = "asc";
            }
            else
            {
                StrSortDirection = "desc";
               
            }
            ViewState["UserPermission" + "Direction"] = StrSortDirection;
            ViewState["UserPermission"] = e.SortExpression + " " + StrSortDirection;
            BindGrid();
        }
        public void DeleteItem(object sender, System.EventArgs e)
        {
            String UserPermissinID = ((HtmlAnchor)sender).HRef.ToString();
            int i = UserPermissionClass.Delete(UserPermissinID);
            if (i == 0)
            {
                LblMsg.Text = " error ";
                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), Guid.NewGuid().ToString(), "alert('خطا در حذف');", true);
            }
            else { BindGrid(); BindPermission(); }
            LightBox.Value = "0";
        }
        public void UpItem(object sender, EventArgs e)
        {
            String UserPermissinID = ((HtmlAnchor)sender).HRef.ToString();
            ClUserPermission cl = new ClUserPermission();
            cl.UserPermissinID = Convert.ToInt32(UserPermissinID);
            Data = cl;
            LightBox.Value = "1";
        }
        protected void btnInsertLight_Click(object sender, EventArgs e)
        {
            EmptyLight();
            LightBox.Value = "1";
            BtnInsert.Visible = true;
            BtnSerach.Visible = false;
           
        }
        protected void btnSerachLight_Click(object sender, EventArgs e)
        {
            EmptyLight();
            BtnSerach.Visible = true;
            BtnInsert.Visible = false;
          
        }
        protected void BtnSerach_Click1(object sender, EventArgs e)
        {
            
            //DataSet ds = UserPermissionClass.GetList(null, null, null, null, null, null, null);
            //DataView dv = new DataView(ds.Tables[0]);
            //String StrSort = Securenamespace.SecureData.CheckSecurity(ViewState["UserPermission"].ToString());
            //if (StrSort != null)
            //{
            //    dv.Sort = StrSort;
            //}
            //GridView1.DataSource = dv;
            //GridView1.DataBind();
        }
        protected void BtnInsert_Click(Object sender, System.EventArgs e)
        {
            ClUserPermission cl = Data;
            int t = 0;
            if (CSharp.PublicFunction.ModeInsert(cl.UserPermissinID.ToString()))

                t = UserPermissionClass.insert(cl);
            else
                t = UserPermissionClass.Update(cl);

            if (t == 0)
            {
                LblMsg.ForeColor = System.Drawing.Color.Red;
                LblMsg.Text = "خطا در ثبت";
            }
            else
            {
                LblMsg.ForeColor = System.Drawing.Color.Green;
                LblMsg.Text = "ثبت  انجام شد.";
                BindPermission();
                BindGrid();
            }
        }
        protected void EmptyLight()
        {
        }

        private void  BindUser(){
         DataSet ds=UsersClass.GetList(null, null, null, null, null, null, null, null, null, null, null);
         DDUserID.DataSource = ds;
            DDUserID.DataTextField = "FullNameUser";
            DDUserID.DataValueField = "UserID";
            DDUserID.DataBind();
         }
        private void BindPermission() {
            ClUserPermission cl = new ClUserPermission();
            cl.UserID =Convert.ToInt32( DDUserID.SelectedValue);
            DDPermissionID.DataSource = UserPermissionClass.GetUserNotPermission(cl);
            DDPermissionID.DataTextField = "PermissianName";
            DDPermissionID.DataValueField = "PermissionID";
            DDPermissionID.DataBind();
        }
        public void BindDD(){
            BindUser();
            BindPermission();
            BindPP();
        }
        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            string sql = "";
            int tt=0;
            ClUserPermission cl=new ClUserPermission();
            for (int i = 0; i < GridView1.Rows.Count - 1; i++) {
                GridViewRow gr = GridView1.Rows[i];
                Label lblup = (Label)gr.FindControl("LblUpID");
                CheckBox chview = (CheckBox)gr.FindControl("chview");
                CheckBox chInsert = (CheckBox)gr.FindControl("chInsert");
                CheckBox chUpdate = (CheckBox)gr.FindControl("chUpdate");
                CheckBox chDel = (CheckBox)gr.FindControl("chDel");
                cl.UserPermissinID=Convert.ToInt32(lblup.Text);
                cl.CanView=chview.Checked;
                cl.CanUpdate=chUpdate.Checked;
                cl.CanInsert=chInsert.Checked;
                cl.CanDel=chDel.Checked;
              tt+=  UserPermissionClass.Update(cl);
              //  sql += "update Tbl_UserPermission set CanDel=" + CSharp.PublicFunction.BTS(chDel.Checked) + ",CanInsert=" + CSharp.PublicFunction.BTS(chInsert.Checked) + ",CanUpdate=" + CSharp.PublicFunction.BTS(chUpdate.Checked) + ",CanView=" + CSharp.PublicFunction.BTS(chUpdate.Checked) + " where UserPermissinID=" + lblup.Text + "";

            }

            if(tt!=0)
                BindGrid();
            else
                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), Guid.NewGuid().ToString(), "alert('خطا در ویرایش');", true);

         
        }

        protected void GridView1_PageIndexChanging1(object sender, GridViewPageEventArgs e)
        {

        }

        protected void DDUserID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();
            BindPermission();
        }

        private void BindPP() {
            DataSet ds = CatalogClass.GetListTypeID("56");
            dl1.DataSource = ds;
            dl1.DataBind();
        }
        protected void btnpp_Click(object sender, EventArgs e)
        {
            string PackID = ((Button)sender).Attributes["catalogvalue"].ToString();
            UserPermissionClass.insertWithPP(DDUserID.SelectedValue, PackID);
            BindGrid();
            BindPermission();
        }
    
    }
}