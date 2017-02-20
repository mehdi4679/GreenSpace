using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GreenSpaceCL;
using GreenSpaceDAL;
using GreenSpaceBLL;
using System.Data;
using TaxiDAL;
using System.Web.UI.HtmlControls;

namespace GreenSpace.Controls
{
    public partial class CtlAgreementFine : System.Web.UI.UserControl
    {
        public ClAgreementFine Data
        {
            get
            {
                ClAgreementFine cl = new ClAgreementFine();
                cl.AgreementFineID = Convert.ToInt32(LblParamAgreementFineID.Text);
                cl.AgreementID = Convert.ToInt32(lblAgreement.Text);
                cl.FineID = Convert.ToInt32(DDFineID.SelectedValue);
                cl.FineComment = TXTFineComment.Text;
                cl.FineDate = DateConvert.sh2m(TXTFineDate.Text).ToString();
                cl.FinePrice = Convert.ToInt32(TXTFinePrice.Text);


                return cl;
            }
            set
            {
                DataSet ds = AgreementFineClass.GetList(value);
                DataRow dr = ds.Tables[0].Rows[0];
                 TXTFinePrice.Text = dr["FinePrice"].ToString();
                TXTFineDate.Text = DateConvert.m2sh(dr["FineDate"].ToString());
                TXTFineComment.Text = dr["FineComment"].ToString();
                LblParamAgreementFineID.Text =  dr["AgreementFineID"].ToString() ;
                lblAgreement.Text = dr["AgreementID"].ToString();
                DDFineID.Text = dr["FineID"].ToString();

                ds.Dispose();
            }
        }

        public void BindDD()
        {

            //DDFineID.DataSource = CatalogClass.GetListTypeID("6");
            //DDFineID.DataTextField = "CatalogName";
            //DDFineID.DataValueField = "CatalogValue";
            //DDFineID.DataBind();
            Clkhesarat cl=new Clkhesarat();
            DataSet ds=khesaratClass.GetList(cl);
           
            DDFineID.DataTextField="KhesaratDesc";
            DDFineID.DataValueField="KesaratID";
            DDFineID.DataSource=ds;
            DDFineID.DataBind();
            DataRow dr=ds.Tables[0].Rows[0];
            TXTFinePrice.Text = dr["KesaratPrice"].ToString();
            ds.Dispose();

        }

        private void SetPric(int khesaratID) {
            Clkhesarat cl = new Clkhesarat();
            cl.KesaratID = khesaratID;
            DataSet ds = khesaratClass.GetList(cl);
            DataRow dr = ds.Tables[0].Rows[0];
             
            TXTFinePrice.Text = dr["KesaratPrice"].ToString();
            ds.Dispose();
            
        }

        public bool NotDefaultAgree
        {
            get { return ragree.Visible; }
            set { ragree.Visible = value; }
        }
        public int AgreementID
        {
            get { return Convert.ToInt32(lblAgreement.Text); }
            set { lblAgreement.Text = value.ToString(); }
        }

        public int AgreementFineID
        {
            get { return Convert.ToInt32(LblParamAgreementFineID.Text); }
            set { LblParamAgreementFineID.Text = value.ToString(); }
        }
        public void BindGrid()
        {
            ClAgreementFine cl = new ClAgreementFine();
            if (NotDefaultAgree == false)
                cl.AgreementID = 0;
            else
                cl.AgreementID = Convert.ToInt32(AgreementID);


            DataSet ds = AgreementFineClass.GetList(cl);
            DataView dv = new DataView(ds.Tables[0]);
            if (ViewState["AgreementFineID"] == null)
            {
                ViewState["AgreementFineID"] = "AgreementFineID Desc";
            }
            dv.Sort = Securenamespace.SecureData.CheckSecurity(ViewState["AgreementFineID"].ToString()).ToString();
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
            if (ViewState[AgreementFineID + "Direction"] == null)
            {
                ViewState.Add("AgreementFineID" + "Direction", "desc");
            }

            StrSortDirection = Securenamespace.SecureData.CheckSecurity(ViewState["AgreementFineID" + "Direction"].ToString());

            if (StrSortDirection == "desc")
                StrSortDirection = "asc";
            else
                StrSortDirection = "desc";

            ViewState["AgreementFineID" + "Direction"] = StrSortDirection;
            ViewState["AgreementFineID"] = e.SortExpression + " " + StrSortDirection;
            BindGrid();
        }
        public void DeleteItem(object sender, System.EventArgs e)
        {
            String AgreementFineID = ((HtmlAnchor)sender).HRef.ToString();
            int i = AgreementFineClass.Delete(AgreementFineID);
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
            String AgreementFineID = ((HtmlAnchor)sender).HRef.ToString();
            LblParamAgreementFineID.Text = AgreementFineID;
            ClAgreementFine cl = new ClAgreementFine();
            cl.AgreementFineID = Convert.ToInt32(AgreementFineID);
            Data = cl;
            LightBox.Value = "1";

        }

        protected void BtnInsert_Click(Object sender, System.EventArgs e)
        {
            ClAgreementFine cl = new ClAgreementFine();
            cl = Data;

            int t = 0;
            if (CSharp.PublicFunction.ModeInsert(AgreementFineID.ToString()))
                t = AgreementFineClass.insert(cl);
            else
                t = AgreementFineClass.Update(cl);

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
            LightBox.Value = "0";
            LblParamAgreementFineID.Text = "0";
        }

        protected void BtnSerach_Click(object sender, EventArgs e)
        {
            DataSet ds = AgreementFineClass.GetList(Data);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            LightBox.Value = "0";

        }

        protected void DDFineID_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetPric(Convert.ToInt32(DDFineID.SelectedValue));
        }

    }
}