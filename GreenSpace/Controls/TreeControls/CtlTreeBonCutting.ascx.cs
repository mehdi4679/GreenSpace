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
    public partial class CtlTreeBonCutting : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDD();
            }

        }

        public void BindDD()
        {
            DDStreetTypeid.DataSource = TaxiDAL.CatalogClass.GetListTypeID("12");
            DDStreetTypeid.DataTextField = "CatalogName";
            DDStreetTypeid.DataValueField = "CatalogValue";
            DDStreetTypeid.DataBind();

            DDTreeTypeId.DataSource = TaxiDAL.CatalogClass.GetListTypeID("16");
            DDTreeTypeId.DataTextField = "CatalogName";
            DDTreeTypeId.DataValueField = "CatalogValue";
            DDTreeTypeId.DataBind();

            BindGrid();
        }

        public int CuttingTreeID
        {
            get { return Convert.ToInt32(LblCuttingTreeID.Text ); }
            set { LblCuttingTreeID.Text = value.ToString(); }
        }

        public int LicensingId
        {
            get { return Convert.ToInt32(LblLicensingId.Text); }
            set { LblLicensingId.Text = value.ToString(); }
        }
        public int TreeBonCuttingID
        {
            get { return Convert.ToInt32(LblTreeBonCuttingID.Text ); }
            set { LblTreeBonCuttingID.Text = value.ToString(); }
        }
        public int MantaghehID
        {
            get { return Convert.ToInt32(lblMantagheid.Text); }
            set { lblMantagheid.Text = value.ToString(); }
        }
        public void BindGrid()
        {
         
            DataSet ds;
            if (LicensingId == 0)
            {
               //  ds = GreenSpaceDAL.TreeBonCutting.GetList(null, null, null, null, CuttingTreeID.ToString(), null, null,null ,MantaghehID.ToString(),null,null ,null  );
                ds = GreenSpaceDAL.TreeBonCutting.GetList(null, null, null, null, CuttingTreeID.ToString(), null, null, null, lblMantagheid.Text, null, null, null);
     
                
                trJabejaei.Visible = false;
                trMandegari.Visible = false;
                trZaribBazdarnde.Visible = true ;
                trKhesaratPrecent.Visible = true ;
            }
            else
            {
                //ds = GreenSpaceDAL.TreeBonCutting.GetList(null, null, null, null, null, null, LicensingId.ToString(), null, MantaghehID.ToString(),null ,null,null  );
                ds = GreenSpaceDAL.TreeBonCutting.GetList(null, null, null, null, null, null, LicensingId.ToString(), null, lblMantagheid.Text, null, null, null);

                trJabejaei.Visible = true;
                trMandegari.Visible = true;
                trZaribBazdarnde.Visible = false;
                trKhesaratPrecent.Visible = false;    
   
            }
            if (ds != null)
            {
                DataView dv = new DataView(ds.Tables[0]);
                //if (Securenamespace.SecureData.CheckSecurity(ViewState["Sakhtikar"].ToString()) == null)
                //{
                //    ViewState["Sakhtikar"] = "id Desc";
                //}
                //dv.Sort = Securenamespace.SecureData.CheckSecurity(ViewState["Sakhtikar"].ToString()).ToString();
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
            //if (ViewState["Sakhtikar" + "Direction"] == null)
            //{
            //    ViewState.Add("Sakhtikar" + "Direction", "desc");
            //}
            //else
            //{
            //    StrSortDirection = CSharp.PublicFunction.secure(ViewState["Sakhtikar" + "Direction"].ToString());
            //}
            //if (StrSortDirection == "desc")
            //{
            //    StrSortDirection = "asc";
            //}
            //else
            //{
            //    StrSortDirection = "desc";
            //    ViewState["Sakhtikar" + "Direction"] = StrSortDirection;
            //}
            //ViewState["Sakhtikar"] = e.SortExpression + " " + StrSortDirection;
            //BindGrid();
        }
        public void DeleteItem(object sender, System.EventArgs e)
        {
            String id = ((HtmlAnchor)sender).HRef.ToString();
            int i = TreeBonCutting.Delete(Convert.ToInt32(id));
            if (i == 0)
            {
                LblMsg.Text = " error ";
                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), Guid.NewGuid().ToString(), "alert('خطا در حذف');", true);
            }
            else { BindGrid(); }
         //   LightBox.Value = "0";
        }
        public void UpItem(object sender, EventArgs e)
        {
            String id = ((HtmlAnchor)sender).HRef.ToString();
             DataSet ds =  GreenSpaceDAL.TreeBonCutting.GetList(id , null, null, null, null,null,null,null ,MantaghehID.ToString() ,null ,null ,null  );
             DataRow dr = ds.Tables[0].Rows[0];
          LblTreeBonCuttingID.Text = dr["TreeBonCuttingId"].ToString(); ;
             TXTBon.Text = dr["Bon"].ToString(); ;
             TXTCount.Text = dr["Count"].ToString();
             DDStreetTypeid.SelectedValue = dr["StreetTypeid"].ToString();
             DDTreeTypeId.SelectedValue = dr["TreeTypeId"].ToString();
             TXTZaribBazdarnde.Text = dr["ZaribBazdarnde"].ToString();

           // EmptyLight();
           //// LightBox.Value = "1";
             BtnInsert.Visible = false;
      
             BtnUpdate.Visible = true;
        }
        protected void btnInsertLight_Click1(object sender, EventArgs e)
        {
            EmptyLight();
          //  LightBox.Value = "1";
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
            DataSet ds = Sakhtikar.GetList(null, null, null, null, null);
            DataView dv = new DataView(ds.Tables[0]);
            String StrSort = Securenamespace.SecureData.CheckSecurity(ViewState["Sakhtikar"].ToString());
            if (StrSort != null)
            {
                dv.Sort = StrSort;
            }
            GridView1.DataSource = dv;
            GridView1.DataBind();
        }
        protected void BtnInsert_Click1(Object sender, System.EventArgs e)
        {
            
        }
        protected void EmptyLight()
        {
        }
        protected void BtnUpdate_Click1(object sender, EventArgs e)
        {

        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {


            int i = TreeBonCutting.Update(LblTreeBonCuttingID.Text, DDTreeTypeId.SelectedValue.ToString(), TXTCount.Text, DDStreetTypeid.SelectedValue.ToString(), CuttingTreeID.ToString(), TXTBon.Text, LblLicensingId.Text, TXTZaribBazdarnde.Text,TXTKhesaratPrecent.Text,TXTJabejaei.Text.Replace(",","").ToString(),TXTZaribMandegari.Text);
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

        protected void BtnInsert_Click(object sender, EventArgs e)
        {
            int t = TreeBonCutting.insert(DDTreeTypeId.SelectedValue.ToString(), TXTCount.Text, DDStreetTypeid.SelectedValue.ToString(), CuttingTreeID.ToString(), TXTBon.Text, LblLicensingId.Text, TXTZaribBazdarnde.Text, TXTKhesaratPrecent.Text, TXTJabejaei.Text.Replace(",", "").ToString(), TXTZaribMandegari.Text);
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

        protected void btncancel_Click(object sender, EventArgs e)
        {
         
            BtnInsert.Visible = true ;
            BtnUpdate.Visible = false;
            LblTreeBonCuttingID.Text = "";
            TXTCount.Text = "";
            TXTBon.Text = "";

        }



    }
}