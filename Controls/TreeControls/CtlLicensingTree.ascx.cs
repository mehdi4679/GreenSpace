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
    public partial class CtlLicensingTree : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid(); BindDD();
            }

        }
        public int Personelid
        {
            get { return 0; }
            set {  }
        }
        public int Haghighiid
        {
            get { return 0; }
            set { }
        }
        public void BindDD()
        {

            DDLicesnceTypeid.DataSource = TaxiDAL.CatalogClass.GetListTypeID("21");
            DDLicesnceTypeid.DataTextField = "CatalogName";
            DDLicesnceTypeid.DataValueField = "CatalogValue";
            DDLicesnceTypeid.DataBind();

            DDMantagheId.DataSource = TaxiDAL.CatalogClass.GetListTypeID("2");
            DDMantagheId.DataTextField = "CatalogName";
            DDMantagheId.DataValueField = "CatalogValue";
            DDMantagheId.DataBind();
          


        }

        public void TreeBonCuttig(object sender, EventArgs e)
        {
            string sp = ((HtmlAnchor)sender).HRef.ToString();

            string[] sp1 = sp.Split('-');
            string LicensingId = sp1[0].ToString();
            string MantaghehId = sp1[1].ToString();

            CtlTreeBonCutting1.LicensingId = Convert.ToInt32(LicensingId);
            CtlTreeBonCutting1.MantaghehID = Convert.ToInt32(MantaghehId);


            //String LicensingId = ((HtmlAnchor)sender).HRef.ToString();
            //CtlTreeBonCutting1.LicensingId = Convert.ToInt32(LicensingId);

            // CtlAgreePercentProtest1.BindDD();
            CtlTreeBonCutting1.BindGrid();

            //LblParamAgreementPercentID.Text = AgreementPercentID;
            //ClAgreementPercent cl = new ClAgreementPercent();
            //cl.AgreementPercentID = Convert.ToInt32(AgreementPercentID);
            //Data = cl;
            LightBox2.Value = "1";
            //LightBox3.Value = "0";

            //LightBox.Value = "0";
        }

        public void Nazar(object sender, EventArgs e)
        {



            String NazarId = ((HtmlAnchor)sender).HRef.ToString();
          CtlNazar.LicensingId = Convert.ToInt32(NazarId);

            // CtlAgreePercentProtest1.BindDD();
          CtlNazar.BindGrid();
          CtlNazar.BindDD();

            //LblParamAgreementPercentID.Text = AgreementPercentID;
            //ClAgreementPercent cl = new ClAgreementPercent();
            //cl.AgreementPercentID = Convert.ToInt32(AgreementPercentID);
            //Data = cl;
            LightBox3.Value = "1";
            //LightBox2.Value = "0";
            //LightBox.Value = "0";

        }

        public void Pardakht(object sender, EventArgs e)
        {



            string LicensingId = ((HtmlAnchor)sender).HRef.ToString();





            CtlPardakht1.LicensingId = Convert.ToInt32(LicensingId);


            // CtlAgreePercentProtest1.BindDD();
            CtlPardakht1.BindGrid();

            //LblParamAgreementPercentID.Text = AgreementPercentID;
            //ClAgreementPercent cl = new ClAgreementPercent();
            //cl.AgreementPercentID = Convert.ToInt32(AgreementPercentID);
            //Data = cl;
            LightBox4.Value = "1";

        }
          public void PersonalSabt(object sender, EventArgs e)
        {
            string LicensingTreeId = ((HtmlAnchor)sender).HRef.ToString();
            CtlPersonal1.LicensingTreeId = Convert.ToInt32(LicensingTreeId);
            CtlPersonal1.BindGrid();
            LightBox5.Value = "1";
        }
          public void HoghoghiSabt(object sender, EventArgs e)
          {
              string LicensingTreeId = ((HtmlAnchor)sender).HRef.ToString();
              CtlHaghighi1.LicensingTreeId = Convert.ToInt32(LicensingTreeId);
              CtlHaghighi1.BindGrid();
              LightBox6.Value = "1";
          }
        public void BindGrid()
        {
            DataSet ds = LicensingTreeClass.GetList(null, Haghighiid.ToString(), Personelid.ToString(), null, null, null,null,null  );
            //DataView dv = new DataView(ds.Tables[0]);
            //if (Securenamespace.SecureData.CheckSecurity(ViewState["LicensingTree"].ToString()) == null)
            //{
            //    ViewState["LicensingTree"] = "Mojavezid Desc";
            //}
            //dv.Sort = Securenamespace.SecureData.CheckSecurity(ViewState["LicensingTree"].ToString()).ToString();
            if (ds != null)
            {
                GridView1.DataSource = ds.Tables[0];
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
            //if (ViewState["LicensingTree" + "Direction"] == null)
            //{
            //    ViewState.Add("LicensingTree" + "Direction", "desc");
            //}
            //else
            //{
            //    StrSortDirection = CSharp.PublicFunction.secure(ViewState["LicensingTree" + "Direction"].ToString());
            //}
            //if (StrSortDirection == "desc")
            //{
            //    StrSortDirection = "asc";
            //}
            //else
            //{
            //    StrSortDirection = "desc";
            //    ViewState["LicensingTree" + "Direction"] = StrSortDirection;
            //}
            //ViewState["LicensingTree"] = e.SortExpression + " " + StrSortDirection;
            //BindGrid();
        }
        public void DeleteItem(object sender, System.EventArgs e)
        {
            String Mojavezid = ((HtmlAnchor)sender).HRef.ToString();
            int i = LicensingTreeClass.Delete(Convert.ToInt32(Mojavezid));
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
            String Mojavezid = ((HtmlAnchor)sender).HRef.ToString();

            DataSet ds = LicensingTreeClass.GetList(Mojavezid, null, null, null, null, null, null, null);
            DataRow dr = ds.Tables[0].Rows[0];
          TXTMojavezid.Text = Mojavezid;
          TXTTitle.Text = dr["Title"].ToString();
          TXTDesc.Text = dr["Desc"].ToString();
          TXTMojavezDate.Text = dr["date1"].ToString();
          DDMantagheId.SelectedValue = dr["MantagheId"].ToString();
          DDLicesnceTypeid.SelectedValue = dr["LicesnceTypeid"].ToString();

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
            DataSet ds = LicensingTreeClass.GetList(null, null, null, null, null, null,null,null  );
            DataView dv = new DataView(ds.Tables[0]);
            String StrSort = Securenamespace.SecureData.CheckSecurity(ViewState["LicensingTree"].ToString());
            if (StrSort != null)
            {
                dv.Sort = StrSort;
            }
            GridView1.DataSource = dv;
            GridView1.DataBind();
        }
        protected void BtnInsert_Click(Object sender, System.EventArgs e)
        {
            int t = LicensingTreeClass.insert(lblHaghighiid.Text,lblPersonelID.Text,TXTMojavezDate.Text,DDLicesnceTypeid.SelectedValue.ToString(),TXTDesc.Text,TXTTitle.Text,DDMantagheId.SelectedValue.ToString()  );//,null, null, null, null, null, null, null);
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
            int i = LicensingTreeClass.Update(TXTMojavezid.Text ,lblHaghighiid.Text, lblPersonelID.Text, TXTMojavezDate.Text, DDLicesnceTypeid.SelectedValue.ToString(), TXTDesc.Text,TXTTitle.Text,DDMantagheId.SelectedValue.ToString() );
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