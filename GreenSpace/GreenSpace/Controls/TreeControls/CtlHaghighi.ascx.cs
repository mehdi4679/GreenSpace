using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GreenSpaceDAL;
using System.Web.UI.HtmlControls;
namespace GreenSpace.Controls
{
    public partial class CtlHaghighi : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }
        public void BindGrid()
        {
            DataSet ds = HaghighiClass.GetList(null, null, null, null, null, null, null,null);
            if (ds != null)
            {
                DataView dv = new DataView(ds.Tables[0]);
                //if (Securenamespace.SecureData.CheckSecurity(ViewState["Haghighi"].ToString()) == null)
                //{
                //    ViewState["Haghighi"] = "HaghighiID Desc";
                //}
                //dv.Sort = Securenamespace.SecureData.CheckSecurity(ViewState["Haghighi"].ToString()).ToString();
                GridView1.DataSource = dv;
                GridView1.DataBind();
            }
        }
        public int CuttingTreeId
        {
            get { return Convert.ToInt32(lblCuttingTreeId.Text); }
            set { lblCuttingTreeId.Text = value.ToString(); }
        }
        public int LicensingTreeId
        {
            get { return Convert.ToInt32(lblLicensingTreeId.Text); }
            set { lblLicensingTreeId.Text = value.ToString(); }
        }
        protected void GridView1_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            BindGrid();
        }
        protected void GridView1_Sorting(object sender, System.Web.UI.WebControls.GridViewSortEventArgs e)
        {
            //string StrSortDirection = "desc";
            //if (ViewState["Haghighi" + "Direction"] == null)
            //{
            //    ViewState.Add("Haghighi" + "Direction", "desc");
            //}
            //else
            //{
            //    StrSortDirection = CSharp.PublicFunction.secure(ViewState["Haghighi" + "Direction"].ToString());
            //}
            //if (StrSortDirection == "desc")
            //{
            //    StrSortDirection = "asc";
            //}
            //else
            //{
            //    StrSortDirection = "desc";
            //    ViewState["Haghighi" + "Direction"] = StrSortDirection;
            //}
            //ViewState["Haghighi"] = e.SortExpression + " " + StrSortDirection;
            //BindGrid();
        }
        public void DeleteItem(object sender, System.EventArgs e)
        {
            String HaghighiID = ((HtmlAnchor)sender).HRef.ToString();
            int i = HaghighiClass.Delete(Convert.ToInt32(HaghighiID));
            if (i == 0)
            {
                LblMsg.Text = " error ";
                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), Guid.NewGuid().ToString(), "alert('خطا در حذف');", true);
            }
            else { BindGrid(); }
            //LightBox.Value = "0";
        }
        public void SabCuttingTreet(object sender, EventArgs e)
        {
            string HaghighiID = ((HtmlAnchor)sender).HRef.ToString();
            int i = HaghighiClass.UpdateCuttingTree(HaghighiID, CuttingTreeId.ToString(),LicensingTreeId.ToString());

            if (i == 0)
            {
                LblMsg.Text = " error ";
                //ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), Guid.NewGuid().ToString(), "alert('خطا در حذف');", true);
            }
            else if (i > 0)
            {
                LblMsg.Text = "ثبت  انجام شد.";
            }
            //else
            if (CuttingTreeId != 0)
            {
                Response.Redirect("CuttingTree.aspx");// CtlCut ctl = new CtlCut();
               
            }
            if (LicensingTreeId != 0)
            {
                Response.Redirect("LicensingTree.aspx");
            }

            //CtlCut ctl = new CtlCut();
            //ctl.
            

        }
        public void UpItem(object sender, EventArgs e)
        {
            String HaghighiID = ((HtmlAnchor)sender).HRef.ToString();

            DataSet ds = HaghighiClass.GetList(HaghighiID.ToString(), null, null, null, null, null, null, null);

            DataRow dr = ds.Tables[0].Rows[0];
          TXTHaghighiAdress.Text = dr["HaghighiAdress"].ToString(); ;
            TXTHaghighiID.Text = dr["HaghighiID"].ToString(); ;
            TXTHaghighiFamily.Text = dr["HaghighiFamily"].ToString(); ;
            TXTHaghighiName.Text = dr["HaghighiName"].ToString();
            TXTHaghighiTel.Text = dr["HaghighiTel"].ToString();
            TXTHaghighiyEmail.Text = dr["HaghighiyEmail"].ToString();
            TXTManageName.Text = dr["ManageName"].ToString();
            TXTRepresentativeMobile.Text = dr["RepresentativeMobile"].ToString();
            BtnInsert.Visible = false;
            BtnUpdate.Visible = true;
  
        }
        protected void btnInsertLight_Click(object sender, EventArgs e)
        {
            EmptyLight();
            //LightBox.Value = "1";
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
            //LightBox.Value = "1";
        }
        protected void BtnSerach_Click1(object sender, EventArgs e)
        {
            DataSet ds = HaghighiClass.GetList(null, TXTHaghighiName.Text,TXTManageName.Text,TXTHaghighiTel.Text,TXTHaghighiAdress.Text,TXTRepresentativeMobile.Text,TXTHaghighiyEmail.Text,TXTHaghighiFamily.Text );//, null, null, null, null, null,null );
            DataView dv = new DataView(ds.Tables[0]);
            //String StrSort = Securenamespace.SecureData.CheckSecurity(ViewState["Haghighi"].ToString());
            //if (StrSort != null)
            //{
            //    dv.Sort = StrSort;
            //}
            GridView1.DataSource = dv;
            GridView1.DataBind();
        }
        protected void BtnInsert_Click(Object sender, System.EventArgs e)
        {
            int t =HaghighiClass.insert(TXTHaghighiName.Text,TXTManageName.Text,TXTHaghighiTel.Text,TXTHaghighiAdress.Text,TXTRepresentativeMobile.Text,TXTHaghighiyEmail.Text,TXTHaghighiFamily.Text);
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
            int i = HaghighiClass.Update(TXTHaghighiID.Text ,TXTHaghighiName.Text, TXTManageName.Text, TXTHaghighiTel.Text, TXTHaghighiAdress.Text, TXTRepresentativeMobile.Text, TXTHaghighiyEmail.Text, TXTHaghighiFamily.Text);
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

        protected void BtnCancel_Click(object sender, EventArgs e)
        {
            BtnSerach.Visible = true;
            BtnInsert.Visible = true ;
            BtnUpdate.Visible = false;
            TXTHaghighiAdress.Text = "";
            TXTHaghighiFamily.Text = "";
            TXTHaghighiName.Text = "";
            TXTHaghighiTel.Text = "";
            TXTManageName.Text = "";
            
        }

    }
}