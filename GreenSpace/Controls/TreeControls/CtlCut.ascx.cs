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
    public partial class CtlCut : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDD(); BindGrid();

            }
        }
        public int Personelid
        {
            get { return 0; }
            set {  }
        }
        public int Haghighiid
        {
            get { return 0 ;}
            set {  }
        }
        //public int Haghighiid { get; set; }
        public void BindDD()
        {
           string hh= Personelid.ToString(); 
            //DDStreetTypeid.DataSource = TaxiDAL.CatalogClass.GetListTypeID("12");
            //DDStreetTypeid.DataTextField = "CatalogName";
            //DDStreetTypeid.DataValueField = "CatalogValue";
            //DDStreetTypeid.DataBind();

            //DDTreeTypeId.DataSource = TaxiDAL.CatalogClass.GetListTypeID("16");
            //DDTreeTypeId.DataTextField = "CatalogName";
            //DDTreeTypeId.DataValueField = "CatalogValue";
            //DDTreeTypeId.DataBind();

            DDMantagheId.DataSource = TaxiDAL.CatalogClass.GetListTypeID("2");
            DDMantagheId.DataTextField = "CatalogName";
            DDMantagheId.DataValueField = "CatalogValue";
            DDMantagheId.DataBind();
            //     BindPeyman();
            //BindGrid();


       DDPeymanid.DataSource = PeymanClass.GetList2(null, null, null);
       DDPeymanid.DataTextField = "PeymanName";
       DDPeymanid.DataValueField = "PeymanID";
       DDPeymanid.DataBind();

     DDLicesnceTypeid.DataSource=  LicensingTreeClass.GetList(null, null, null, null, null, null, null,null );
     DDLicesnceTypeid.DataTextField = "Title";
     DDLicesnceTypeid.DataValueField = "Mojavezid";
     DDLicesnceTypeid.DataBind();

        }
        //public string Personelid
        //{
        //    get { }
        //    set{}
        //}
        //public string  Haghighiid
        //{
        //    get { }
        //    set { }
        //}
         
        public void BindGrid()
        {

            DataSet ds = CuttingTreeClass.GetList(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null,null,null,null,null );
         if(ds!=null)
            {
            DataView dv = new DataView(ds.Tables[0]);
            //if (Securenamespace.SecureData.CheckSecurity(ViewState["CuttingTree"].ToString()) == null)
            //{
            //    ViewState["CuttingTree"] = "id Desc";
            //}
            //dv.Sort = Securenamespace.SecureData.CheckSecurity(ViewState["CuttingTree"].ToString()).ToString();
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
            //if (ViewState["CuttingTree" + "Direction"] == null)
            //{
            //    ViewState.Add("CuttingTree" + "Direction", "desc");
            //}
            //else
            //{
            //    StrSortDirection = CSharp.PublicFunction.secure(ViewState["CuttingTree" + "Direction"].ToString());
            //}
            //if (StrSortDirection == "desc")
            //{
            //    StrSortDirection = "asc";
            //}
            //else
            //{
            //    StrSortDirection = "desc";
            //    ViewState["CuttingTree" + "Direction"] = StrSortDirection;
            //}
            //ViewState["CuttingTree"] = e.SortExpression + " " + StrSortDirection;
            //BindGrid();
        }
        public void DeleteItem(object sender, System.EventArgs e)
        {
            String id = ((HtmlAnchor)sender).HRef.ToString();
            int i = CuttingTreeClass.Delete(Convert.ToInt32(id));
            if (i == 0)
            {
                LblMsg.Text = " error ";
                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), Guid.NewGuid().ToString(), "alert('خطا در حذف');", true);
            }
            else { BindGrid(); }
            LightBox.Value = "0";
        }

        public void TreeBonCuttig(object sender, EventArgs e)
        {



            string sp  = ((HtmlAnchor)sender).HRef.ToString();

            string[] sp1 = sp.Split('-');
        string  CuttingTreeID =  sp1[0].ToString();
        string MantaghehId = sp1[1].ToString();

            CtlTreeBonCutting1.CuttingTreeID = Convert.ToInt32(CuttingTreeID);
            CtlTreeBonCutting1.MantaghehID = Convert.ToInt32(MantaghehId==""?"0":"1");

            // CtlAgreePercentProtest1.BindDD();
            CtlTreeBonCutting1.BindGrid();

            //LblParamAgreementPercentID.Text = AgreementPercentID;
            //ClAgreementPercent cl = new ClAgreementPercent();
            //cl.AgreementPercentID = Convert.ToInt32(AgreementPercentID);
            //Data = cl;
            LightBox2.Value = "1";

        }

        public void Pardakht(object sender, EventArgs e)
        {



            string CuttingTreeID = ((HtmlAnchor)sender).HRef.ToString();





            CtlPardakht1.CuttingTreeID = Convert.ToInt32(CuttingTreeID);
        

            // CtlAgreePercentProtest1.BindDD();
            CtlPardakht1.BindGrid();

            //LblParamAgreementPercentID.Text = AgreementPercentID;
            //ClAgreementPercent cl = new ClAgreementPercent();
            //cl.AgreementPercentID = Convert.ToInt32(AgreementPercentID);
            //Data = cl;
            LightBox3.Value = "1";

        }
        public void PersonalSabt(object sender, EventArgs e)
        {
            string CuttingTreeId = ((HtmlAnchor)sender).HRef.ToString();
            CtlPersonal1.CuttingTreeId = Convert.ToInt32(CuttingTreeId);
            CtlPersonal1.BindGrid();
            LightBox4.Value = "1";
        }
        public void HoghoghiSabt(object sender, EventArgs e)
        {
            string CuttingTreeId = ((HtmlAnchor)sender).HRef.ToString();
            CtlHaghighi1.CuttingTreeId = Convert.ToInt32(CuttingTreeId);
            CtlHaghighi1.BindGrid();
            LightBox5.Value = "1";
        }
        public void UpItem(object sender, EventArgs e)
        {
            String id = ((HtmlAnchor)sender).HRef.ToString();
            DataSet ds = CuttingTreeClass.GetList(id, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null,null,null);
          
            DataRow dr = ds.Tables[0].Rows[0];
            
            TXTid.Text = dr["id"].ToString();  
            TXTTitle.Text = dr["Title"].ToString();  
            TXTAddress.Text = dr["Address"].ToString();
            TXTDesc.Text = dr["Desc"].ToString();
            DDMantagheId.SelectedValue = dr["MantagheId"].ToString()=="" ? "0" :dr["MantagheId"].ToString()  ;
            string kk = dr["Peyman"].ToString();
            if (dr["Peyman"].ToString() != null && dr["Peyman"].ToString() == "True")
            {
                chkPeyman.Checked = true;
                DDPeymanid.SelectedValue = dr["Peymanid"].ToString();
                DDPeymanid.Visible = true;
                lblpeyman.Visible = true;
            }


            if (dr["Mojavez"].ToString() != null && dr["Mojavez"].ToString() == "True")
            {
              chkMojavez.Checked = true;
             DDLicesnceTypeid.SelectedValue = dr["LicesnceTypeid"].ToString();
             DDLicesnceTypeid.Visible = true;
               lblMojavez.Visible = true;
            }

            TXTdate.Text = dr["date1"].ToString();
            // EmptyLight();
           LightBox.Value = "1";
            BtnInsert.Visible = false;

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
            DataSet ds = CuttingTreeClass.GetList(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null,null,null, null, null);
            DataView dv = new DataView(ds.Tables[0]);
            String StrSort = Securenamespace.SecureData.CheckSecurity(ViewState["CuttingTree"].ToString());
            if (StrSort != null)
            {
                dv.Sort = StrSort;
            }
            GridView1.DataSource = dv;
            GridView1.DataBind();
        }
        protected void BtnInsert_Click(Object sender, System.EventArgs e)
        {
            string PeymanId = null;
            if (DDPeymanid.SelectedValue.ToString() != "") PeymanId = DDPeymanid.SelectedValue.ToString();
            string LicesnceTypeid = null;
            if (DDLicesnceTypeid.SelectedValue.ToString() != "") LicesnceTypeid = DDLicesnceTypeid.SelectedValue.ToString();



            int t = CuttingTreeClass.insert(null, null, null, TXTdate.Text, TXTAddress.Text, null, null, null, null, chkPeyman.Checked.ToString(), PeymanId, DDMantagheId.SelectedValue.ToString(), chkMojavez.Checked, Haghighiid.ToString(), LicesnceTypeid, TXTTitle.Text, TXTDesc.Text, null, null);
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
            int i = CuttingTreeClass.Update(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, TXTTitle.Text, TXTDesc.Text, null, null);
            if (i == 0)
            {
                LblMsg.ForeColor = System.Drawing.Color.Red;
                LblMsg.Text = "خطا";
            }
        }
        protected void chkPeyman_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPeyman.Checked == true)
            {
                DDPeymanid.Visible = true;
                lblpeyman.Visible = true;
            }
            else
            {
                DDPeymanid.Visible = false ;
                lblpeyman.Visible = false;
            }
        }

        protected void chkMojavez_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMojavez.Checked == true)
            {
                DDLicesnceTypeid.Visible = true;
                lblMojavez.Visible = true;
            }
            else
            {
                DDLicesnceTypeid.Visible = false;
                lblMojavez.Visible = false;
            }

        }

        //protected void BtnUpdate_Click(object sender, EventArgs e)
        //{
        //    int i = CuttingTreeClass.Update(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, TXTTitle.Text, TXTDesc.Text);
        //    if (i == 0)
        //    {
        //        LblMsg.ForeColor = System.Drawing.Color.Red;
        //        LblMsg.Text = "خطا";
        //    }
        //    else
        //    {
        //        LblMsg.ForeColor = System.Drawing.Color.Green;
        //        LblMsg.Text = "ویرایش انجام شد";
        //        BindGrid();
        //    }
        //}

    }
}