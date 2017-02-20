using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TaxiDAL;
using TaxiCL;
using GreenSpaceCL;
using GreenSpaceDAL;
using GreenSpaceBLL;
using System.Data;
using System.Web.UI.HtmlControls;

namespace GreenSpace.Controls
{
    public partial class CtlAgreeStatus : System.Web.UI.UserControl
    {
        public ClAgreeStatus Data
        {
            get
            {
                ClAgreeStatus cl = new ClAgreeStatus();
                cl.AgreeStatus = Convert.ToInt32(LblParamAgreeStatus.Text);
                cl.AgreementID = Convert.ToInt32(lblAgreement.Text);
                cl.StatusID = Convert.ToInt32(DDStatusID.SelectedValue);
                cl.StatusDate = DateConvert.sh2m(TXTStatusDate.Text).ToString();
                cl.RegUser =  Convert.ToInt32(CSharp.PublicFunction.GetUserID());
                cl.RegDate = DateTime.Now.ToString();
                cl.AgreeStatusComment = TXTAgreeStatusComment.Text;

                return cl;
            }
            set
            {
                DataSet ds = AgreeStatusClass.GetList(value);
                DataRow dr = ds.Tables[0].Rows[0];
                TXTAgreeStatus.Text = dr["AgreeStatus"].ToString();
                TXTAgreeStatusComment.Text =  dr["AgreeStatusComment"].ToString() ;
                TXTStatusDate.Text =DateConvert.m2sh( dr["StatusDate"].ToString());
                DDStatusID.SelectedValue = dr["StatusID"].ToString();
                LblParamAgreeStatus.Text = dr["AgreeStatus"].ToString();



                ds.Dispose();
            }
        }

        public void BindDD()
        {

            DDStatusID.DataSource = CatalogClass.GetListTypeID("5");
            DDStatusID.DataTextField = "CatalogName";
            DDStatusID.DataValueField = "CatalogValue";
            DDStatusID.DataBind();



 

        }

        public int  AgreeStatus
        {
            get { return Convert.ToInt32(LblParamAgreeStatus.Text); }
            set { LblParamAgreeStatus.Text = value.ToString(); }
        }

        public int AgreementID
        {
            get { return Convert.ToInt32(lblAgreement.Text); }
            set { lblAgreement.Text = value.ToString(); }
        }
        public void BindGrid()
        {
            ClAgreeStatus cl = new ClAgreeStatus();
            cl.AgreementID = AgreementID;


            DataSet ds = AgreeStatusClass.GetList(cl);
            DataView dv = new DataView(ds.Tables[0]);
            if (ViewState["AgreeStatus "] == null)

                ViewState["AgreeStatus"] = "AgreeStatus Desc";

            dv.Sort = Securenamespace.SecureData.CheckSecurity(ViewState["AgreeStatus"].ToString()).ToString();
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
            if (ViewState["AgreeStatus" + "Direction"] == null)
            {
                ViewState.Add("AgreeStatus" + "Direction", "desc");
            }

            StrSortDirection = Securenamespace.SecureData.CheckSecurity(ViewState["AgreeStatus" + "Direction"].ToString());

            if (StrSortDirection == "desc")
                StrSortDirection = "asc";
            else
                StrSortDirection = "desc";

            ViewState["AgreeStatus" + "Direction"] = StrSortDirection;
            ViewState["AgreeStatus"] = e.SortExpression + " " + StrSortDirection;
            BindGrid();
        }
        public void DeleteItem(object sender, System.EventArgs e)
        {
            String AgreePercentProtestID = ((HtmlAnchor)sender).HRef.ToString();
            int i = AgreeStatusClass.Delete(AgreePercentProtestID);
            if (i == 0)
            {
                LblMsg.Text = " error ";
                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), Guid.NewGuid().ToString(), "alert('خطا در حذف');", true);
            }
            else { BindGrid(); }
            //LightBox.Value = "0";
        }
        //public void UpItem(object sender, EventArgs e)
        //{
        //    String AgreementFineID = ((HtmlAnchor)sender).HRef.ToString();
        //    LblParamAgreementFineID.Text = AgreementFineID;
        //    ClAgreeStatus cl = new ClAgreeStatus();
        //    cl.AgreementFineID = Convert.ToInt32(AgreementFineID);
        //    Data = cl;
        //    LightBox.Value = "1";

        //}

        protected void BtnInsert_Click(Object sender, System.EventArgs e)
        {
            ClAgreeStatus cl = new ClAgreeStatus();
            cl = Data;

            int t = 0;
            if (CSharp.PublicFunction.ModeInsert(LblParamAgreeStatus.Text))
                t = AgreeStatusClass.insert(cl);
            else
                t = AgreeStatusClass.Update(cl);

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
            //LightBox.Value = "0";
            LblParamAgreeStatus.Text = "0";
        }

        protected void BtnSerach_Click(object sender, EventArgs e)
        {
            DataSet ds = AgreeStatusClass.GetList(Data);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            //   LightBox.Value = "0";

        }


 
    }
}