using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using GreenSpaceCL;
using GreenSpaceDAL;
using System.Data;

namespace GreenSpace.Controls
{
    public partial class CtlAgreeExplanPrice : System.Web.UI.UserControl
    {

        public ClAgreeExplanPrice Data
        {
            get
            {
                ClAgreeExplanPrice cl = new ClAgreeExplanPrice();
                cl.PriceDayExplan =Convert.ToInt32( TXTPriceDayExplan.Text);
                cl.PriceNightExplan =Convert.ToInt32( TXTPriceNightExplan.Text);
                cl.ExplanID = Convert.ToInt32(DDExplanID.SelectedValue);
                cl.AgreementID=Convert.ToInt32(lblagreementID.Text);
                 cl.ExplanPriceID=Convert.ToInt32(LblParamExplanPriceID.Text);

                return cl;
            }
            set
            {
                DataSet ds = AgreeExplanPriceClass.GetList(value);
                DataRow dr = ds.Tables[0].Rows[0];
               // TXTExplanPriceID.Text = dr["ParkName"].ToString();
                TXTPriceDayExplan.Text = dr["PriceDayExplan"].ToString();
                TXTPriceNightExplan.Text = dr["PriceNightExplan"].ToString();
                LblParamExplanPriceID.Text = dr["ExplanPriceID"].ToString();
                DDExplanID.SelectedValue =Convert.ToInt32( dr["ExplanID"].ToString());
                DDAgreementID.SelectedValue = dr["AgreementID"].ToString();
                lblagreementID.Text= dr["AgreementID"].ToString();

                ds.Dispose();
            }
        }

        public void BindDD()
        {

            DDExplanID.Bind();
           ClAgreement cl=new ClAgreement();
           
            DDAgreementID.DataSource = AgreementClass.GetList(cl);
            DDAgreementID.DataTextField = "AgreeName";
            DDAgreementID.DataValueField = "AgreementID";
            DDAgreementID.DataBind();
            if (NotDefaultAgree) {
                DDAgreementID.Items.Insert(0, new ListItem("پیش فرض","0"));
            }
            BindSubject();

        }
        private void BindSubject()
        {

            ddsubject.DataSource = TaxiDAL.CatalogClass.GetListTypeID("3");
            ddsubject.DataTextField = "CatalogName";
            ddsubject.DataValueField = "CatalogValue";
            ddsubject.DataBind();
        }
        public bool VisibleInsertEditDelete
        {
            get { return dbtninsert.Visible; }
            set { BtnInsert.Visible = value;
            GridView1.Columns[1].Visible = value;
            GridView1.Columns[2].Visible = value;
            trrr.Visible = value;
             }
        }
        

        public bool NotDefaultAgree {
            get { return ragree.Visible; }
            set{ragree.Visible=value;}
        }
  public int AgreementID
        {
            get { return Convert.ToInt32(lblagreementID.Text); }
            set { 
                lblagreementID.Text = value.ToString();
                DDExplanID.AgreementID = value;
            }
        }
        
        public int ExplanPriceID
        {
            get { return Convert.ToInt32(LblParamExplanPriceID.Text); }
            set { LblParamExplanPriceID.Text = value.ToString(); }
        }
        public void BindGrid()
        {
            ClAgreeExplanPrice cl = new ClAgreeExplanPrice();
            if (NotDefaultAgree == false)
                cl.AgreementID = 0;
            else
                cl.AgreementID = Convert.ToInt32(AgreementID);

            cl.SubjectID =Convert.ToInt32( ddsubject.SelectedValue);


            DataSet ds = AgreeExplanPriceClass.GetList(cl);
            DataView dv = new DataView(ds.Tables[0]);
            if (ViewState["ExplanPriceID"] == null)
            {
                ViewState["ExplanPriceID"] = "ExplanPriceID Desc";
            }
            dv.Sort = Securenamespace.SecureData.CheckSecurity(ViewState["ExplanPriceID"].ToString()).ToString();
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
            if (ViewState[ExplanPriceID + "Direction"] == null)
            {
                ViewState.Add("ExplanPriceID" + "Direction", "desc");
            }

            StrSortDirection = Securenamespace.SecureData.CheckSecurity(ViewState["ExplanPriceID" + "Direction"].ToString());

            if (StrSortDirection == "desc")
                StrSortDirection = "asc";
            else
                StrSortDirection = "desc";

            ViewState["ExplanPriceID" + "Direction"] = StrSortDirection;
            ViewState["ExplanPriceID"] = e.SortExpression + " " + StrSortDirection;
            BindGrid();
        }
        public void DeleteItem(object sender, System.EventArgs e)
        {
            String ExplanPriceID = ((HtmlAnchor)sender).HRef.ToString();
            int i = AgreeExplanPriceClass.Delete(ExplanPriceID);
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
            String ExplanPriceID = ((HtmlAnchor)sender).HRef.ToString();
            LblParamExplanPriceID.Text = ExplanPriceID;
            ClAgreeExplanPrice cl = new ClAgreeExplanPrice();
            cl.ExplanPriceID = Convert.ToInt32(ExplanPriceID);
            Data = cl;
            LightBox.Value = "1";

        }
        public void ActItem(object sender,EventArgs e)
        {
            String  ID = ((HtmlAnchor)sender).HRef.ToString() ;
            String ExplanPriceID = ID.Split('$')[0].ToString();
            String ActID = ID.Split('$')[1].ToString();

            if (ActID == "0")
                ActID = "1";
            else
                ActID = "0";

            if (ActID == "1")
                LightBox1.Value = "1";
            else
                LightBox1.Value = "0";


            ClAgreeExplanPrice cl = new ClAgreeExplanPrice();
            cl.ExplanPriceID = Convert.ToInt32(ExplanPriceID);
            cl.ActID =Convert.ToInt32( ActID);
            LblParamExplanPriceID.Text = ExplanPriceID;



            int t = AgreeExplanPriceClass.Update(cl);
            if (t == 0)
                CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "خطا در فعال کردن");
            else
                BindGrid();

        }
        protected void BtnInsert_Click(Object sender, System.EventArgs e)
        {
            ClAgreeExplanPrice cl = new ClAgreeExplanPrice();
            cl = Data;

            int t = 0;
            if (CSharp.PublicFunction.ModeInsert(ExplanPriceID.ToString()))
                t = AgreeExplanPriceClass.insert(cl);
            else
                t = AgreeExplanPriceClass.Update(cl);

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

            
            LblParamExplanPriceID.Text = "0";
        }

        protected void BtnSerach_Click(object sender, EventArgs e)
        {
            DataSet ds =AgreeExplanPriceClass.GetList(Data);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            LightBox.Value = "0";

        }

        protected void btnzarib_Click(object sender, EventArgs e)
        {
            ClAgreeExplanPrice cl=new ClAgreeExplanPrice();
            cl.AgreementID=AgreementID;
            cl.ZaribPrice= txtzaribprice.Text ;
            AgreeExplanPriceClass.Updatezarib(cl);
            BindGrid();

        }

        protected void ddsubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

       

        protected void btnSaveDates_Click1(object sender, EventArgs e)
        {
            ClAgreeExplanPrice cl = new ClAgreeExplanPrice();
            cl.ExplanPriceID = Convert.ToInt32(ExplanPriceID);
            cl.FromDateActive = DateConvert.sh2m(txtFromDateActive.Text).ToString();
            cl.ToDateActive = DateConvert.sh2m(txtToDateActive.Text).ToString();

            if (AgreeExplanPriceClass.Update(cl) == 0)
                CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "خطا در ثبت");
            else
                BindGrid();


            
        }

        





    }
}