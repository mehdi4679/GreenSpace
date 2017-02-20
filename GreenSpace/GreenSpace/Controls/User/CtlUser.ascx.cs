using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.UI.HtmlControls;
using GreenSpaceCL;
using System.Web.Security;
using TaxiCL;

namespace GreenSpace.Controls
{
    public partial class CtlUser : System.Web.UI.UserControl
    {

        public void BindSemat() {
            ClCatalog c = new ClCatalog();
            c.CatalogTypeID = 1;
        DataSet ds=TaxiDAL.CatalogClass.GetList(c);
        DDsemat.DataSource = ds;
        DDsemat.DataTextField = "CatalogName";
        DDsemat.DataValueField = "CatalogValue";
        DDsemat.DataBind();

        }
        public void BindGrid(string UserID=null)
        {
            DataSet ds = TaxiDAL.UsersClass.GetList(UserID, null, null, null, null, null, null, null, null, null, null, null, null, null);
            DataView dv = new DataView(ds.Tables[0]);
            if ( ViewState["Users"]  == null)
            {
                ViewState["Users"] = "UserID Desc";
            }
            dv.Sort =  ViewState["Users"].ToString();
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
            string StrSortDirection ;
            if (ViewState["Users" + "Direction"] == null)
            {
                ViewState.Add("Users" + "Direction", "desc");
            }
           
                StrSortDirection = Securenamespace.SecureData.CheckSecurity(ViewState["Users" + "Direction"].ToString());
             

            if (StrSortDirection == "desc")
            {
                StrSortDirection = "asc";
            }
            else
            {
                StrSortDirection = "desc";
            }
            ViewState["Users" + "Direction"] = StrSortDirection;
            ViewState["Users"] = e.SortExpression + " " + StrSortDirection;
            BindGrid();
        }
        public void DeleteItem(object sender, System.EventArgs e)
        {
            String UserID = ((HtmlAnchor)sender).HRef.ToString();
            int i = TaxiDAL.UsersClass.Delete(Convert.ToInt32(UserID));
            if (i == 0)
            {
                LblMsg.Text = " error ";
                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), Guid.NewGuid().ToString(), "alert('خطا در حذف');", true);
            }
            else { BindGrid(); }
            lightbox.Value = "0";
        }
        public void BindForm(string ID) {
            DataSet ds = TaxiDAL.UsersClass.GetList(ID, null, null, null, null, null, null, null, null, null, null);
            DataRow dr = ds.Tables[0].Rows[0];
            TXTEmail.Text = dr["Email"].ToString();
            TXTFamlily.Text = dr["Famlily"].ToString();
            TXTMelliCode.Text = dr["MelliCode"].ToString();
            TXTmobile.Text = dr["mobile"].ToString();
            TXTName.Text = dr["Name"].ToString();
            TXTPass.Text = dr["Pass"].ToString();
            TXTPhone.Text = dr["Phone"].ToString();
            TXTUserID.Text = dr["UserID"].ToString();
            TXTUserName.Text = dr["UserName"].ToString();
        }
        public void UpItem(object sender, EventArgs e)
        {
            String UserID = ((HtmlAnchor)sender).HRef.ToString();
            BindForm(UserID);
            lightbox.Value = "1";
            BtnInsert.Visible = false;
            BtnUpdate.Visible = true;
            BtnSerach.Visible = false;
            lblUSerIDParam.Text = UserID;
            trPass.Visible = false;
            TrPassRe.Visible = false;
        }
        public void PassItem(object sender, EventArgs e){
            String UserID = ((HtmlAnchor)sender).HRef.ToString();
            string Username = ((HtmlAnchor)sender).Attributes["username"].ToString();
            TxtlightUserName.Text = Username;
            txtlightPass.Text = "";
            txtLightRePass.Text = "";
            lblName.Text = ((HtmlAnchor)sender).Attributes["fullname"].ToString();
            lightboxPass.Value = "1";
            lblUSerIDParam.Text = UserID;
        }
        protected void btnInsertLight_Click(object sender, EventArgs e)
        {
            EmptyLight();
            lightbox.Value = "1";
            BtnInsert.Visible = true;
            BtnSerach.Visible = false;
            BtnUpdate.Visible = false;
            trPass.Visible = true;
            TrPassRe.Visible = true;
        }
        protected void btnSerachLight_Click(object sender, EventArgs e)
        {
            EmptyLight();
            BtnSerach.Visible = true;
            BtnInsert.Visible = false;
            BtnUpdate.Visible = false;
            lightbox.Value = "1";
            TrPrimery.Visible = true;
        }

        protected void BtnSerach_Click1(object sender, EventArgs e)
        {
          
            DataSet ds = TaxiDAL.UsersClass.GetList(TXTUserID.Text, TXTUserName.Text, TXTPass.Text, TXTName.Text, TXTFamlily.Text, TXTmobile.Text, DDsemat.SelectedValue, TXTEmail.Text, TXTMelliCode.Text, TXTPhone.Text, "true");
            DataView dv = new DataView(ds.Tables[0]);
            String StrSort = Securenamespace.SecureData.CheckSecurity(ViewState["Users"].ToString());
            if (StrSort != null)
            {
                dv.Sort = StrSort;
            }
            GridView1.DataSource = dv;
            GridView1.DataBind();
        }
        protected bool  IsRepUserName (string USerName,string UserID) {
            DataSet ds= TaxiDAL.UsersClass.GetList(null, USerName, null, null, null, null, null, null, null, null, null);
            if (ds.Tables[0].Rows.Count == 0)
                return false;
            else
            {
                DataRow dr = ds.Tables[0].Rows[0];
                if (ds.Tables[0].Rows.Count > 1)
                    return true;
                else if (ds.Tables[0].Rows.Count == 1 && UserID != dr["UserID"].ToString())
                    return true;
                else
                    return false;
            }
         }
        protected int checkPass(string pass, string PassRe) {
            if (pass != PassRe)
                return -1;
            else
                if (pass.Length < 4)
                    return -2;
                else
                    return 0;
        }
        protected void EmptyLight()
        {
            TXTEmail.Text = "";
            TXTFamlily.Text = "";
            txtlightPass.Text = "";
            txtLightRePass.Text = "";
            TxtlightUserName.Text = "";
            TXTMelliCode.Text = "";
            TXTmobile.Text = "";
            TXTName.Text = "";
            TXTPass.Text = "";
            TXTPhone.Text = "";
            TXTUserName.Text = "";
            LblMsg.Text = "";
            TrPrimery.Visible = false;

        }
        protected void BtnUpdate_Click1(object sender, EventArgs e)
        {
            
            if ( IsRepUserName(TXTUserName.Text, lblUSerIDParam.Text)) { 
                 LblMsg.ForeColor = System.Drawing.Color.Red;
                LblMsg.Text = "نام کاربری تکراری است";
                return  ;
            }
            int i = TaxiDAL.UsersClass.Update(lblUSerIDParam.Text , TXTUserName.Text, null, TXTName.Text, TXTFamlily.Text, TXTmobile.Text, DDsemat.SelectedValue, TXTEmail.Text, TXTMelliCode.Text, TXTPhone.Text, "true");
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

        protected void BtnInsert_Click1(object sender, EventArgs e)
        {
            int passcheck=checkPass(TXTPass.Text,TXTPassre.Text);
            if ( passcheck== -1)
            {
                LblMsg.ForeColor = System.Drawing.Color.Red;
                LblMsg.Text = "پسوردها با هم هماهنگ نیستند";
                return;
            }
            else if (passcheck==-2)
            { 
            LblMsg.ForeColor = System.Drawing.Color.Red;
                LblMsg.Text = "پسورد نباید از چهار کارکتر کمتر باشد";
                return;
            }
            if(!IsRepUserName(TXTUserName.Text,"-1"))
            {
                var hash = FormsAuthentication.HashPasswordForStoringInConfigFile(TXTPass.Text + "~!@", "MD5");

            int t = TaxiDAL.UsersClass.insert(null, TXTUserName.Text,hash, TXTName.Text, TXTFamlily.Text, TXTmobile.Text, DDsemat.SelectedValue, TXTEmail.Text, TXTMelliCode.Text, TXTPhone.Text, "true");
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
            else{
                LblMsg.ForeColor = System.Drawing.Color.Red;
            LblMsg.Text="نام کاربری انتخابی تکراری است.";
            }
        }

        protected void btnPass_Click(object sender, EventArgs e)
        {
            int ipass = checkPass(txtlightPass.Text, txtLightRePass.Text);
            if (ipass == -1)
            {
                lblmsgPass.ForeColor = System.Drawing.Color.Red;
                lblmsgPass.Text = "پسوردها با هم هماهنگ نیستند";
                return;
            }
            else if (ipass == -2)
            {
                lblmsgPass.ForeColor = System.Drawing.Color.Red;
                lblmsgPass.Text = "پسورد نباید از چهار کارکتر کمتر باشد";
                return;
            }
            if (IsRepUserName(TxtlightUserName.Text, lblUSerIDParam.Text))
            {
                lblmsgPass.ForeColor = System.Drawing.Color.Red;
                lblmsgPass.Text = "نام کاربری تکراری است";
                return;
            }
            var hash = FormsAuthentication.HashPasswordForStoringInConfigFile(txtlightPass.Text + "~!@", "MD5");

            int i = TaxiDAL.UsersClass.Update(lblUSerIDParam.Text , TxtlightUserName.Text ,hash , null, null, null, null, null, null, null, null);
            if (i == 0)
            {
                lblmsgPass.ForeColor = System.Drawing.Color.Red;
                lblmsgPass.Text = "خطا";
            }
            else
            {
                lblmsgPass.ForeColor = System.Drawing.Color.Green;
                lblmsgPass.Text = "نام کاربری و کلمه عبور جدید اعمال شد";
                BindGrid();
            }
        }
    }
}