using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GreenSpaceCL;
using GreenSpaceDAL;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.HtmlControls;

namespace GreenSpace.Controls
{
    public partial class CtlExplanRequest : System.Web.UI.UserControl
    {
        public ClExplanRequest Data
        {
            get
            {
                ClExplanRequest cl = new ClExplanRequest();
                cl.FromDate =DateConvert.sh2m( TXTFromDate.Text).ToString();
                cl.ToDate = DateConvert.sh2m(TXTToDate.Text).ToString();
                 cl.ExplanID =Convert.ToInt32(  TXTExplanID.SelectedValue.ToString());
                cl.ForAgreementID =Convert.ToInt32( TXTForAgreementID.Text);
                cl.IsOK = Convert.ToInt32(TXTIsOK.SelectedValue);
                cl.ForUserID = Convert.ToInt32(TXTForUserID.Text);
                cl.ByUserID = Convert.ToInt32(TXTByUserID.Text);
                cl.ForAgreementID = Convert.ToInt32(TXTForAgreementID.Text);
                cl.ExplanRequestOpenID = Convert.ToInt32(LblParamExplanRequestOpenID.Text);
                return cl;
            }
            set
            {
                DataSet ds = ExplanRequestClass.GetList(value);
                DataRow dr=ds.Tables[0].Rows[0];
                TXTForAgreementID.Text = dr["ForAgreementID"].ToString();
               // TXTByUserID.Text = dr["ByUserID"].ToString();
                TXTForUserID.Text = dr["ForUserID"].ToString();
                TXTIsOK.SelectedValue = dr["IsOK"].ToString();
                TXTExplanID.SelectedValue =  dr["ExplanID"].ToString() ;
                TXTFromDate.Text =DateConvert.m2sh( dr["FromDate"].ToString());
                TXTToDate.Text   =DateConvert.m2sh(dr["ToDate"].ToString() );
                LblParamExplanRequestOpenID.Text = dr["ExplanRequestOpenID"].ToString();
            }
        }
        public string ByUserID
        {
            get { return TXTByUserID.Text; }
            set { TXTByUserID.Text = value; }
            
            
        }

        public string ForUserID
        {
            get { return TXTForUserID.Text; }
            set { TXTForUserID.Text = value;
       

            }
        }
        public bool VisibleDropTaeeid
        {
            get { return TXTIsOK.Visible; }
            set { TXTIsOK.Visible = value; 
            trok.Visible =value; 
            }
        }
        public string sematid
        {
            get { return lblsematid.Text; }
            set { lblsematid.Text = value;
            
            }
        }
        public string SamtType
        {
            get { return lblsamttype.Text; }
            set { lblsamttype.Text = value;

            if (SamtType == "bazras")
            {
                TXTIsOK.Visible = false;
                trok.Visible = false;
            }
            else
            {
                TXTIsOK.Visible = true;
                trok.Visible = true;
            }
            }
        }
        public string ForAgreementID
        {
            get { return TXTForAgreementID.Text; }
            set { TXTForAgreementID.Text = value; }
        }
        public string  ExplanRequestOpenID
        {
            get { return LblParamExplanRequestOpenID.Text; }
            set { LblParamExplanRequestOpenID.Text = value; }
        }
        public void BindDD()
        {
            TXTExplanID.BindDD();
            if (sematid != "2")
            {
                TXTIsOK.Items.Remove(TXTIsOK.Items.FindByValue("1"));
                TXTIsOK.Items.Remove(TXTIsOK.Items.FindByValue("0"));
                GridView1.Columns[2].Visible = false;
                GridView1.Columns[1].Visible = false;
            }

        }

        public void BindGrid()
        {
            ClExplanRequest cl = new ClExplanRequest();
            cl.ForAgreementID =   Convert.ToInt32(TXTForAgreementID.Text) ;
        //    cl.ForUserID = Convert.ToInt32(TXTForUserID.Text);
        //    cl.ByUserID = Convert.ToInt32(TXTByUserID.Text);
            

            DataSet ds = ExplanRequestClass.GetList(cl);
            DataView dv = new DataView(ds.Tables[0]);
            if ( ViewState["ExplanRequest"]  == null)
            {
                ViewState["ExplanRequest"] = "explanrequestopenid Desc";
            }
            dv.Sort =  ViewState["ExplanRequest"].ToString() ;
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
            string StrSortDirection = "desc";
            if (ViewState["ExplanRequest" + "Direction"] == null)
            {
                ViewState.Add("ExplanRequest" + "Direction", "desc");
            }
            else
            {
                StrSortDirection = ViewState["ExplanRequest" + "Direction"].ToString() ;
            }
            if (StrSortDirection == "desc")
            {
                StrSortDirection = "asc";
            }
            else
            {
                StrSortDirection = "desc";
                ViewState["ExplanRequest" + "Direction"] = StrSortDirection;
            }
            ViewState["ExplanRequest"] = e.SortExpression + " " + StrSortDirection;
            BindGrid();
        }
        public void DeleteItem(object sender, System.EventArgs e)
        {
            String ExplanRequestOpenID = ((HtmlAnchor)sender).HRef.ToString();
            int i =   ExplanRequestClass.Delete( ExplanRequestOpenID.ToString());
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
            String ExplanRequestOpenID = ((HtmlAnchor)sender).HRef.ToString();
            LblParamExplanRequestOpenID.Text = ExplanRequestOpenID;
            ClExplanRequest cl = new ClExplanRequest();
            cl.ExplanRequestOpenID = Convert.ToInt32(ExplanRequestOpenID);
            Data = cl;
            LightBox.Value = "1";
            BtnInsert.Visible = true;
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
          
        protected void EmptyLight()
        {
        }

        protected void BtnInsert_Click1(object sender, EventArgs e)
        {
            ClExplanRequest cl = new ClExplanRequest();
            cl = Data;

            int t = 0;
            if (CSharp.PublicFunction.ModeInsert(ExplanRequestOpenID.ToString()))
                t = ExplanRequestClass.insert(cl);
            else
                t = ExplanRequestClass.Update(cl);

            if (t == 0)
                CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.General_Success, "خطا در ثبت");
            else
            {
                BindGrid();
            }
        }
 
    }
}