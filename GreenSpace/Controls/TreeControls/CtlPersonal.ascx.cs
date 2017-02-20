using GreenSpaceDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace GreenSpace.Controls
{
    public partial class CtlPersonal : System.Web.UI.UserControl
    {
        public int Personid { get; set; }
        public void BindGrid()
        {
            string hg = LicensingTreeId.ToString();
            DataView dv = null;
            //if (CuttingTreeId == 0  )
            //{

            //    DataSet ds = PersonalClass.GetList(null, null, null, null, null, null, null, null, null, null, null, null,null ,null );
            //    if (ds!=null)
            //     dv = new DataView(ds.Tables[0]);
            //}
             if (CuttingTreeId != 0)
            {

                DataSet ds = PersonalClass.GetList( null, null, null, null, null, null, null, null,null, null, null,null,null,null );
                if (ds != null)
                 dv = new DataView(ds.Tables[0]);
            }
            else if (LicensingTreeId  != 0)
            {

                DataSet ds = PersonalClass.GetList(  null, null, null, null, null, null, null, null, null,null,null, null,null,null);
                if (ds != null)
                    dv = new DataView(ds.Tables[0]);
            }
            //if (Securenamespace.SecureData.CheckSecurity(ViewState["Personal"].ToString()) == null)
            //{
            //    ViewState["Personal"] = "PersonalID Desc";
            //}
            //dv.Sort = Securenamespace.SecureData.CheckSecurity(ViewState["Personal"].ToString()).ToString();
            GridView1.DataSource = dv;
            GridView1.DataBind();
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
            string StrSortDirection = "desc";
            if (ViewState["Personal" + "Direction"] == null)
            {
                ViewState.Add("Personal" + "Direction", "desc");
            }
            else
            {
                StrSortDirection = Securenamespace.SecureData.CheckSecurity(ViewState["Personal" + "Direction"].ToString());
            }
            if (StrSortDirection == "desc")
            {
                StrSortDirection = "asc";
            }
            else
            {
                StrSortDirection = "desc";
                ViewState["Personal" + "Direction"] = StrSortDirection;
            }
            ViewState["Personal"] = e.SortExpression + " " + StrSortDirection;
            BindGrid();
        }
        public void DeleteItem(object sender, System.EventArgs e)
        {
            String PersonalID = ((HtmlAnchor)sender).HRef.ToString();
            int i = PersonalClass.Delete(Convert.ToInt32(PersonalID));
            if (i == 0)
            {
                LblMsg.Text = " error ";
                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), Guid.NewGuid().ToString(), "alert('خطا در حذف');", true);
            }
            else { BindGrid(); }
            //LightBox.Value = "0";
        }
        public void UpItem(object sender, EventArgs e)
        {
            String PersonalID = ((HtmlAnchor)sender).HRef.ToString();
            DataSet ds = PersonalClass.GetList(PersonalID, null, null, null, null, null, null, null, null, null, null, null,null,null );
            DataRow dr = ds.Tables[0].Rows[0];
            TXTPersonalID.Text = PersonalID;
            TXTFirstName.Text = dr["FirstName"].ToString();
            TXTLastName.Text = dr["LastName"].ToString();
            TXTNationalCode.Text = dr["NationalCode"].ToString();
            TXTPostiCode.Text = dr["PostiCode"].ToString();
            EmptyLight();
            //LightBox.Value = "1";
            BtnInsert.Visible = false;
            BtnSerach.Visible = false;
            BtnUpdate.Visible = true ;
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
            //LightBox.Value = "1";
            BtnSerach.Visible = true;
            BtnInsert.Visible = false;
            BtnUpdate.Visible = false;
        }
        protected void BtnSerach_Click1(object sender, EventArgs e)
        {
          
        }
        public void SabCuttingTreet(object sender, EventArgs e)
        {
            string HaghighiID = ((HtmlAnchor)sender).HRef.ToString();
            int i =PersonalClass.UpdateCuttingTree(HaghighiID, CuttingTreeId.ToString(), LicensingTreeId.ToString());

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
        protected void BtnInsert_Click(Object sender, System.EventArgs e)
        {
            int t = PersonalClass.insert(TXTPersonalID.Text, TXTNationalCode.Text, TXTFirstName.Text, TXTLastName.Text, TXTPersonalAdress.Text, TXTPostiCode.Text, TXTPersonalTel.Text, TXTPersonalMobile.Text, null, null, null, null);
            if (t == 0)
            {
                LblMsg.ForeColor = System.Drawing.Color.Red;
                LblMsg.Text = "خطا در ثبت";
            }
            else if(t==-1)
            {

                LblMsg.ForeColor = System.Drawing.Color.Red;
                LblMsg.Text = "قبلا این کد ملی ثبت شده است.";
            
            }

            else if (t == -2)
            {
                LblMsg.ForeColor = System.Drawing.Color.Red;
                LblMsg.Text = "قبلا  ثبت شده است.";
              
            }
            else
            {
                LblMsg.ForeColor = System.Drawing.Color.Green;
                LblMsg.Text = "ثبت گردید.";
              
            }
            BindGrid();
        }
        protected void EmptyLight()
        {
        }
        protected void BtnUpdate_Click1(object sender, EventArgs e)
        {
            int i = PersonalClass.Update(TXTPersonalID.Text, TXTNationalCode.Text, TXTFirstName.Text, TXTLastName.Text, TXTPersonalAdress.Text, TXTPostiCode.Text, TXTPersonalTel.Text, TXTPersonalMobile.Text, null, null, null, null);
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

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }



        protected void BtnSerach_Click(object sender, EventArgs e)
        {
            DataSet ds = PersonalClass.GetList(null, TXTNationalCode.Text, TXTFirstName.Text, TXTLastName.Text, TXTPersonalAdress.Text, TXTPostiCode.Text, TXTPersonalTel.Text, TXTPersonalMobile.Text, null, null, null, null,null,null );
            DataView dv = new DataView(ds.Tables[0]);
            //String StrSort = Securenamespace.SecureData.CheckSecurity(ViewState["Personal"].ToString());
            //if (StrSort != null)
            //{
            //    dv.Sort = StrSort;
            //}

            DataRow dr = ds.Tables[0].Rows[0];
            //TXTPersonalID.Text = PersonalID;
            TXTFirstName.Text = dr["FirstName"].ToString();
            TXTLastName.Text = dr["LastName"].ToString();
            TXTNationalCode.Text = dr["NationalCode"].ToString();
            TXTPostiCode.Text = dr["PostiCode"].ToString();

            GridView1.DataSource = dv;
            GridView1.DataBind();

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            BtnUpdate.Visible = false;
            BtnInsert.Visible = true;
            TXTFirstName.Text = "";
            TXTFirstName.Text = "";
            TXTLastName.Text = "";
            TXTNationalCode.Text = "";
            TXTPostiCode.Text =  "";
         
        }

        protected void BtnMell_Click(object sender, EventArgs e)
        {
            //String PersonalID = ((HtmlAnchor)sender).HRef.ToString();
            DataSet ds = PersonalClass.GetList(null, TXTNationalCode.Text , null, null, null, null, null, null, null, null, null, null, null, null);
            DataRow dr = ds.Tables[0].Rows[0];
            //TXTPersonalID.Text = PersonalID;
            TXTFirstName.Text = dr["FirstName"].ToString();
            TXTLastName.Text = dr["LastName"].ToString();
            TXTNationalCode.Text = dr["NationalCode"].ToString();
            TXTPostiCode.Text = dr["PostiCode"].ToString();
        }

    }
}