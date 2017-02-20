using GreenSpaceCL;
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
    public partial class CtlAgreeExplanRepeat1 : System.Web.UI.UserControl
    {

        public ClAgreeExplanRepeat Data
        {
            get
            {
                ClAgreeExplanRepeat cl = new ClAgreeExplanRepeat();
                cl.ExplanRepeatID = Convert.ToInt32(LblParamExplanRepeatID.Text);
                cl.ExplanID = DDExplanID.SelectedValue;
                cl.RpeatMonth1 =  TXTRpeatMonth1.Text ;
                cl.RpeatMonth2 = TXTRpeatMonth2.Text;
                cl.RpeatMonth3 =  TXTRpeatMonth3.Text;
                cl.RpeatMonth4 =  TXTRpeatMonth4.Text;
                cl.RpeatMonth5 = TXTRpeatMonth5.Text;
                cl.RpeatMonth6 =  TXTRpeatMonth6.Text;
                cl.RpeatMonth7 = TXTRpeatMonth7.Text;
                cl.RpeatMonth8 =  TXTRpeatMonth8.Text;
                cl.RpeatMonth9 =  TXTRpeatMonth9.Text;
                cl.RpeatMonth10 =  TXTRpeatMonth10.Text ;
                cl.RpeatMonth11 =  TXTRpeatMonth11.Text ;
                cl.RpeatMonth12 =  TXTRpeatMonth12.Text ;
                cl.AgreementID = Convert.ToInt32(DDAgreementID.SelectedValue);
                cl.YearLyOrMonthly = Convert.ToInt32(DDYearLyOrMonthly.SelectedValue);
                cl.RepeateYear= TXTRepeateYear.Text ;

                return cl;
            }
            set
            {
                DataSet ds = AgreeExplanRepeatClass.GetList(value);
                DataRow dr = ds.Tables[0].Rows[0];
                LblParamExplanRepeatID.Text = dr["ExplanRepeatID"].ToString();
                TXTRepeateYear.Text = dr["RepeateYear"].ToString();
                TXTRpeatMonth1.Text = dr["RpeatMonth1"].ToString();
                TXTRpeatMonth10.Text = dr["RpeatMonth10"].ToString();
                TXTRpeatMonth11.Text = dr["RpeatMonth11"].ToString();
                TXTRpeatMonth12.Text = dr["RpeatMonth12"].ToString();
                TXTRpeatMonth2.Text = dr["RpeatMonth2"].ToString();
                TXTRpeatMonth3.Text = dr["RpeatMonth3"].ToString();
                TXTRpeatMonth4.Text = dr["RpeatMonth4"].ToString();
                TXTRpeatMonth5.Text = dr["RpeatMonth5"].ToString();
                TXTRpeatMonth6.Text = dr["RpeatMonth6"].ToString();
                TXTRpeatMonth7.Text = dr["RpeatMonth7"].ToString();
                TXTRpeatMonth8.Text = dr["RpeatMonth8"].ToString();
                TXTRpeatMonth9.Text = dr["RpeatMonth9"].ToString();
                LblAgreementID.Text = dr["AgreementID"].ToString();
                DDExplanID.SelectedValue = Convert.ToInt32(dr["ExplanID"].ToString());
                DDYearLyOrMonthly.SelectedValue = dr["YearLyOrMonthly"].ToString();
                LblParamExplanRepeatID.Text = dr["ExplanRepeatID"].ToString();
                ds.Dispose();
            }
        }

        public void BindDD()
        {
   ddSubjectFilter.DataSource = TaxiDAL.CatalogClass.GetListTypeID("3");
   ddSubjectFilter.DataTextField = "CatalogName";
            ddSubjectFilter.DataValueField = "CatalogValue";
            ddSubjectFilter.DataBind();

            ClAgreement cl = new ClAgreement();
            DDAgreementID.DataSource = AgreementClass.GetList(cl);
            DDAgreementID.DataTextField = "AgreeName";
            DDAgreementID.DataValueField = "AgreementID";
            DDAgreementID.DataBind();

            if (NotDefaultAgree)
            {
                DDAgreementID.Items.Insert(0, new ListItem("پیش فرض", "0"));
            }

            DDExplanID.Bind();

            YearMonthShow();

         
        }
   public int AgrrementID
        {
            get { return Convert.ToInt32(LblAgreementID.Text); }
            set { 
                LblAgreementID.Text = value.ToString();
                DDExplanID.AgreementID = value;
            }
        }
   public string  SubjectID
   {
       get { return DDExplanID.SubjectID; }
       set { DDExplanID.SubjectID = value; }
   }
        public int ExplanRepeatID
        {
            get { return Convert.ToInt32(LblParamExplanRepeatID.Text); }
            set { LblParamExplanRepeatID.Text = value.ToString(); }
        }
        public void BindGrid()
        {
            ClAgreeExplanRepeat cl = new ClAgreeExplanRepeat();

            cl.SubjectID =Convert.ToInt32( ddSubjectFilter.SelectedValue );

            if (NotDefaultAgree == false)
                cl.AgreementID = 0;
            else
                cl.AgreementID = Convert.ToInt32(LblAgreementID.Text);
cl.AgreementID = AgrrementID;


            DataSet ds = AgreeExplanRepeatClass.GetList(cl);
            DataView dv = new DataView(ds.Tables[0]);
            if (ViewState["ExplanRepeatID"] == null)
            {
                ViewState["ExplanRepeatID"] = "ExplanRepeatID Desc";
            }
            dv.Sort = Securenamespace.SecureData.CheckSecurity(ViewState["ExplanRepeatID"].ToString()).ToString();
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
            string StrSortDirection;
            if (ViewState["ExplanRepeatID" + "Direction"] == null)
            {
                ViewState.Add("ExplanRepeatID" + "Direction", "desc");
            }
           

            StrSortDirection =  ViewState["PersonalLearning" + "Direction"].ToString();

            if (StrSortDirection == "desc")
                StrSortDirection = "asc";
            else
                StrSortDirection = "desc";

            ViewState["ExplanRepeatID" + "Direction"] = StrSortDirection;
            ViewState["ExplanRepeatID"] = e.SortExpression + " " + StrSortDirection;
            BindGrid();
        }
        public void DeleteItem(object sender, System.EventArgs e)
        {
            String ExplanRepeatID = ((HtmlAnchor)sender).HRef.ToString();
            int i = AgreeExplanRepeatClass.Delete(ExplanRepeatID);
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
            String ExplanRepeatID = ((HtmlAnchor)sender).HRef.ToString();
            LblParamExplanRepeatID.Text = ExplanRepeatID;
            ClAgreeExplanRepeat cl = new ClAgreeExplanRepeat();
            cl.ExplanRepeatID = Convert.ToInt32(ExplanRepeatID);
            Data = cl;
            LightBox.Value = "1";
            YearMonthShow();
        }

        protected void BtnInsert_Click(Object sender, System.EventArgs e)
        {
            ClAgreeExplanRepeat cl = new ClAgreeExplanRepeat();
            cl = Data;
            if (NotDefaultAgree == false)
                cl.AgreementID = null;
            else
                cl.AgreementID = Convert.ToInt32(LblAgreementID.Text);

            if (NotDefaultAgree == false)
                cl.AgreementID = null;

            int t = 0;
            if (CSharp.PublicFunction.ModeInsert(ExplanRepeatID.ToString()))
                t = AgreeExplanRepeatClass.insert(cl);
            else
                t = AgreeExplanRepeatClass.Update(cl);

            if (t == 0)
            {
                LblMsg.ForeColor = System.Drawing.Color.Red;
                LblMsg.Text = "خطا در ثبت";
            }
            else if (t == -1)
                CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "برای این شرح کار تکرار ثبت شده است");
            else
            {
                LblMsg.ForeColor = System.Drawing.Color.Green;
                LblMsg.Text = "ثبت  انجام شد.";
                BindGrid();
            }
           
            LblParamExplanRepeatID.Text = "0";
        }


        protected void DDYearLyOrMonthly_SelectedIndexChanged(object sender, EventArgs e)
        {
            YearMonthShow();
        }
        private void YearMonthShow() {
            if (DDYearLyOrMonthly.SelectedValue == "1")
            {
                tbrepeat.Visible = true;
                tbmonth.Visible = false;
            }
            else {
                tbrepeat.Visible = false;
                tbmonth.Visible = true;
            }

        }

        protected void btnInsertLight_Click(object sender, EventArgs e)
        {
            BtnInsert.Visible = true;
            BtnSerach.Visible = false;
            LightBox.Value = "1";
        }

        protected void btnSerachLight_Click(object sender, EventArgs e)
        {
            BtnInsert.Visible = false;
            BtnSerach.Visible = true;
        }
        public bool NotDefaultAgree
        {
            get { return ragree.Visible; }
            set { ragree.Visible = value;
            if (value == false)
            {
                DDAgreementID.Items.Insert(0, new ListItem("پیش فرض قرارداد", "0"));
                DDAgreementID.DataBind();
              //  DDAgreementID.SelectedValue = "0";

            }

            }
        }
        protected void BtnSerach_Click(object sender, EventArgs e)
        {
                       
                         DataSet ds = AgreeExplanRepeatClass.GetList(Data);
                         DataView dv = new DataView(ds.Tables[0]);
                         if (ViewState["ExplanRepeatID"] == null)
                         {
                             ViewState["ExplanRepeatID"] = "ExplanRepeatID Desc";
                         }
                         dv.Sort = Securenamespace.SecureData.CheckSecurity(ViewState["ExplanRepeatID"].ToString()).ToString();
                         GridView1.DataSource = dv;
                         GridView1.DataBind();
        }

        protected void ddSubjectFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}