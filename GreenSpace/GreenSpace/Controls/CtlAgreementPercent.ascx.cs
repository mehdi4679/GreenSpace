using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GreenSpaceDAL;
using TaxiDAL;
using GreenSpaceBLL;
using GreenSpaceCL;
using System.Data;
using System.Web.UI.HtmlControls;

namespace GreenSpace.Controls
{
    public partial class CtlAgreementPercent : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

         //    DDExplainFilter.E_ExpalnChange += changeExpalin;
            DDExplainID.E_ExpalnChange +=new CtlDropExplan.call( BindGrid );

        }

        private void changeExpalin(object sender, EventArgs e)
        {
            BindGrid();
        }
        public ClAgreementPercent Data
        {
            get
            {
                ClAgreementPercent cl = new ClAgreementPercent();
                cl.AgreementID = Convert.ToInt32(lblAgreement.Text);
                cl.AgreementPercentID = Convert.ToInt32(LblParamAgreementPercentID.Text);
                cl.ExplainID =Convert.ToInt32( DDExplainID.SelectedValue);
                cl.FineFactor = Convert.ToInt32(DDFineFactor.SelectedValue);
                cl.FineMeterOrRepeat = Convert.ToInt32(TXTFineMeterOrRepeat.Text=="" ? "0":  TXTFineMeterOrRepeat.Text);
                cl.SuperVisorID = Convert.ToInt32(DDSuperVisorID.SelectedValue); 
                cl.utilityPersent = Convert.ToInt32(TXTutilityPersent.Text);
                cl.VisitDate = DateConvert.sh2m(TXTVisitDate.Text).ToString();
                cl.JarimeComment = txtJarimeComment.Text;




                return cl;
            }
            set
            {
                DataSet ds = AgreementPercentClass.GetList(value);
                DataRow dr = ds.Tables[0].Rows[0];
                TXTFineMeterOrRepeat.Text = dr["FineMeterOrRepeat"].ToString();
                TXTutilityPersent.Text = dr["utilityPersent"].ToString();
                TXTVisitDate.Text = DateConvert.m2sh(dr["VisitDate"].ToString());
                lblAgreement.Text = dr["AgreementID"].ToString();
                LblParamAgreementPercentID.Text = dr["AgreementPercentID"].ToString();
                DDSuperVisorID.SelectedValue = dr["SuperVisorID"].ToString();
                DDFineFactor.SelectedValue = dr["FineFactor"].ToString();
                DDSuperVisorID.SelectedValue = dr["SuperVisorID"].ToString();
                txtJarimeComment.Text = dr["JarimeComment"].ToString();
                DDExplainID.SelectedValue =Convert.ToInt32( dr["ExplainID"].ToString());

                ds.Dispose();
            }
        }

        public void BindDD()
        {

            ClAgreement cl = new ClAgreement();
            DDAgreementID.DataSource = AgreementClass.GetList(cl);
            DDAgreementID.DataTextField = "AgreeName";
            DDAgreementID.DataValueField = "AgreementID";
            DDAgreementID.DataBind();

            DDSuperVisorID.DataSource = TaxiDAL.UsersClass.GetList(null, null, null, null, null, null, "6", null, null, null, null);
            DDSuperVisorID.DataTextField = "FullNameUser";
            DDSuperVisorID.DataValueField = "UserID";
            DDSuperVisorID.DataBind();

            DDExplainID.Bind();
            CtlAgreePercentProtest1.BindDD();

            Bindtbljarime();

            DDExplainID.AutoPostBackExplan = true;
            
            
        }
        public void Bindtbljarime() {
            if (DDFineFactor.SelectedValue == "0")
                tbljarime.Visible = false;
            else
                tbljarime.Visible = true;

        }
        public bool NotDefaultAgree
        {
            get { return ragree.Visible; }
            set { ragree.Visible = value; }
        }
        public int AgreementID
        {
            get { return Convert.ToInt32(lblAgreement.Text); }
            set { lblAgreement.Text = value.ToString();
            DDExplainID.AgreementID = value;
            DDExplainID.OnlyActive = 1;
            }
        }

        public int AgreementPercentID
        {
            get { return Convert.ToInt32(LblParamAgreementPercentID.Text); }
            set { LblParamAgreementPercentID.Text = value.ToString(); }
        }
        public void BindGrid()
        {
            ClAgreementPercent cl = new ClAgreementPercent();
           

            //if (NotDefaultAgree == false)
            //    cl.AgreementID = 0;
            //else
                cl.AgreementID = Convert.ToInt32(AgreementID);
           

            cl.ExplainID = DDExplainID.SelectedValue;


                
            DataSet ds = AgreementPercentClass.GetList(cl);
            DataView dv = new DataView(ds.Tables[0]);
            if (ViewState["AgreementPercentID"] == null)
            {
                ViewState["AgreementPercentID"] = "AgreementPercentID Desc";
            }
            dv.Sort = Securenamespace.SecureData.CheckSecurity(ViewState["AgreementPercentID"].ToString()).ToString();
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
            if (ViewState["AgreementPercentID" + "Direction"] == null)
            {
                ViewState.Add("AgreementPercentID" + "Direction", "desc");
            }

            StrSortDirection = Securenamespace.SecureData.CheckSecurity(ViewState["AgreementPercentID" + "Direction"].ToString());

            if (StrSortDirection == "desc")
                StrSortDirection = "asc";
            else
                StrSortDirection = "desc";

            ViewState["AgreementPercentID" + "Direction"] = StrSortDirection;
            ViewState["AgreementPercentID"] = e.SortExpression + " " + StrSortDirection;
            BindGrid();
        }
        public void DeleteItem(object sender, System.EventArgs e)
        {
            String AgreementFineID = ((HtmlAnchor)sender).HRef.ToString();
            int i = AgreementPercentClass.Delete(AgreementFineID);
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
            String AgreementPercentID = ((HtmlAnchor)sender).HRef.ToString();
            LblParamAgreementPercentID.Text = AgreementPercentID;
            ClAgreementPercent cl = new ClAgreementPercent();
            cl.AgreementPercentID = Convert.ToInt32(AgreementPercentID);
            Data = cl;
            LightBox.Value = "1";

        }
        public void ProtestItem(object sender, EventArgs e)
        {
           


            String AgreementPercentID = ((HtmlAnchor)sender).HRef.ToString();
            CtlAgreePercentProtest1.AgreementPercentID = Convert.ToInt32(AgreementPercentID);

           // CtlAgreePercentProtest1.BindDD();
            CtlAgreePercentProtest1.BindGrid();

            //LblParamAgreementPercentID.Text = AgreementPercentID;
            //ClAgreementPercent cl = new ClAgreementPercent();
            //cl.AgreementPercentID = Convert.ToInt32(AgreementPercentID);
            //Data = cl;
            LightBox2.Value = "1";

        }
        protected void BtnInsert_Click(Object sender, System.EventArgs e)
        {


            if (Convert.ToInt32(TXTutilityPersent.Text) > 100 || Convert.ToInt32(TXTutilityPersent.Text) < 0)
            {
                CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "");
                return;
            }




            ClAgreementPercent cl = new ClAgreementPercent();
            cl = Data;

            int t = 0;
            if (CSharp.PublicFunction.ModeInsert(LblParamAgreementPercentID.Text))
                t = AgreementPercentClass.insert(cl);
            else
                t = AgreementPercentClass.Update(cl);

            if (t == 0)
            {
                LblMsg.ForeColor = System.Drawing.Color.Red;
                LblMsg.Text = "خطا در ثبت";
            }
            else if (t == -1)
            {
                CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "سقف ثبت بازدید تکمیل شده است");
            }
                else if(t==-2)
            {
                CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "برای این شرح کار در این تاریخ درصد ثبت شده است");
            }
            else
            {
                LblMsg.ForeColor = System.Drawing.Color.Green;
                LblMsg.Text = "ثبت  انجام شد.";
                BindGrid();
            }
            LightBox.Value = "0";
            LblParamAgreementPercentID.Text = "0";
        }

        protected void BtnSerach_Click(object sender, EventArgs e)
        {
            DataSet ds = AgreementPercentClass.GetList(Data);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            LightBox.Value = "0";

        }

        protected void DDFineFactor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bindtbljarime();
        }

    }
}