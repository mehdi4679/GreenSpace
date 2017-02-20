using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using GreenSpaceDAL;
namespace GreenSpace.Controls
{
    public partial class CtlPardakht : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                BindGrid(); BindDD();
            }
        }

        public int CuttingTreeID
        {
            get { return Convert.ToInt32(LblCuttingTreeID.Text); }
            set { LblCuttingTreeID.Text = value.ToString(); }
        }

        public int LicensingId
        {
            get { return Convert.ToInt32(LblLicensingId.Text); }
            set { LblLicensingId.Text = value.ToString(); }
        }
        public void BindDD()
        {
      DDPardakhtStatusid.DataSource = TaxiDAL.CatalogClass.GetListTypeID("24");
      DDPardakhtStatusid.DataTextField = "CatalogName";
      DDPardakhtStatusid.DataValueField = "CatalogValue";
      DDPardakhtStatusid.DataBind();

            //     BindPeyman();
        }
        public void BindGrid()
        {
            DataSet ds = null;

            if (LicensingId.ToString() == "0")
            {
                ds = PardakhtClass.GetList(null, null, null, null, null, CuttingTreeID.ToString(), null, null);
            }
            else
            {
                 ds = PardakhtClass.GetList(null, null, null, null, null, null, LicensingId.ToString(), null);
            }
          //  DataSet ds = PardakhtClass.GetList(null, null, null,null, null,CuttingTreeID.ToString(),LicensingId.ToString(),null  );
            if (ds != null)
            {
                DataView dv = new DataView(ds.Tables[0]);
                //if (Securenamespace.SecureData.CheckSecurity(ViewState["Abbaha"].ToString()) == null)
                //{
                //    ViewState["Abbaha"] = "id Desc";
                //}
                //dv.Sort = Securenamespace.SecureData.CheckSecurity(ViewState["Abbaha"].ToString()).ToString();
                GridView1.DataSource = dv;
                GridView1.DataBind();
            }
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
            int i =PardakhtClass.Delete(Convert.ToInt32(id));
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
            String id = ((HtmlAnchor)sender).HRef.ToString();
            DataSet ds = PardakhtClass.GetList(id, null, null, null, null, null, null, null);
            DataRow dr = ds.Tables[0].Rows[0];
           TXTPardakhtId.Text = id;
           TXTMablaghFinal.Text = dr["MablaghFinal"].ToString();
           TXTFishNum.Text = dr["FishNum"].ToString();
          TXTPardakhtDate.Text = dr["date1"].ToString();
          DDPardakhtStatusid.SelectedValue = dr["PardakhtStatusid"].ToString();
          TXTDesc.Text = dr["Desc"].ToString();

            EmptyLight();
        
            BtnInsert.Visible = false;
        
            BtnUpdate.Visible = true;
        }
        protected void btnInsertLight_Click(object sender, EventArgs e)
        {
            EmptyLight();
            //LightBox.Value = "1";
            BtnInsert.Visible = true;
         //   BtnSerach.Visible = false;
            BtnUpdate.Visible = false;
        }
        protected void btnSerachLight_Click(object sender, EventArgs e)
        {
            EmptyLight();
           // BtnSerach.Visible = true;
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
            int t = PardakhtClass.insert(TXTFishNum.Text,TXTDesc.Text,TXTMablaghFinal.Text,DDPardakhtStatusid.SelectedValue.ToString(),CuttingTreeID.ToString(),LicensingId.ToString(),TXTPardakhtDate.Text);
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
            int i = PardakhtClass.Update(TXTPardakhtId.Text, TXTFishNum.Text, TXTDesc.Text, TXTMablaghFinal.Text, DDPardakhtStatusid.SelectedValue.ToString(), CuttingTreeID.ToString(), LicensingId.ToString(), TXTPardakhtDate.Text);
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

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            BtnInsert.Visible = true;
            BtnUpdate.Visible = false;
            TXTPardakhtDate.Text = "";
            TXTMablaghFinal.Text = "";
            TXTFishNum.Text = "";
            TXTDesc.Text = "";
        }

    }
}