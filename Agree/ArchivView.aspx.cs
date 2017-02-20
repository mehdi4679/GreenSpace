using GreenSpaceCL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GreenSpaceDAL;
using GreenSpaceBLL;
using System.Web.UI.HtmlControls;

namespace GreenSpace.Agree
{
    public partial class ArchivView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                AgreementID = Convert.ToInt32(Request.QueryString["aid"].ToString());
                ArchivID = Convert.ToInt32(Request.QueryString["Archid"].ToString());
                BindDD();
             }
        }
        private void BindDD()
        {
            ddSubject.DataSource = TaxiDAL.CatalogClass.GetListTypeID("3");
            ddSubject.DataTextField = "CatalogName";
            ddSubject.DataValueField = "CatalogValue";
            ddSubject.DataBind();
            ddSubject.Items.Insert(0, new ListItem("انتخاب نمایید", "0"));

        }
        public void BindGrid()
        {
            ClArchiveAgree cl = new ClArchiveAgree();
             cl.AgreeID = Convert.ToInt32(lblAgrement.Text);
            cl.SubjectID = Convert.ToInt32(ddSubject.SelectedValue);
            cl.ArchiveTitleID= Convert.ToInt32(ArchivID);

            DataSet ds = ArchiveAgreeClass.GetList(cl);
            DataView dv = new DataView(ds.Tables[0]);
            if (ViewState["AgreementID"] == null)
            {
                ViewState["AgreementID"] = "AgreeID Desc";
            }
            if (ViewState["AgreementID"] == null)
                return;
            dv.Sort =  ViewState["AgreementID"].ToString();
            GridView1.DataSource = dv;
            GridView1.DataBind();
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
               // LBLkHESARAT.Text = dr["finekhesarat"].ToString();


            }
        }
        protected void GridView1_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            BindGrid();
        }
        protected void GridView1_Sorting(object sender, System.Web.UI.WebControls.GridViewSortEventArgs e)
        {
            string StrSortDirection;
            if (ViewState["AgreementID" + "Direction"] == null)
            {
                ViewState.Add("AgreementID" + "Direction", "desc");
            }

            StrSortDirection = Securenamespace.SecureData.CheckSecurity(ViewState["AgreementID" + "Direction"].ToString());

            if (StrSortDirection == "desc")
                StrSortDirection = "asc";
            else
                StrSortDirection = "desc";

            ViewState["AgreementID" + "Direction"] = StrSortDirection;
            ViewState["AgreementID"] = e.SortExpression + " " + StrSortDirection;
            BindGrid();
        }
        public int AgreementID
        {
            get { return Convert.ToInt32(lblAgrement.Text); }
            set { lblAgrement.Text = value.ToString(); }
        }
        public int ArchivID
        {
            get { return Convert.ToInt32(LblParamArchivID.Text); }
            set { LblParamArchivID.Text = value.ToString(); }
        }

        protected void ddExpalnID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();
        }
        public void DeleteItem(object sender, System.EventArgs e)
        {
            String AgreePercentProtestID = ((HtmlAnchor)sender).HRef.ToString();
            int i = ArchiveAgreeClass.Delete(AgreePercentProtestID);
            if (i == 0)
            {
                LblMsg.Text = " error ";
                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), Guid.NewGuid().ToString(), "alert('خطا در حذف');", true);
            }
            else { BindGrid(); }
        }
        public void UpItem(object sender, EventArgs e)
        {
            String AreaID = ((HtmlAnchor)sender).HRef.ToString();
            LblParamArchivID.Text = AreaID;
            ClArchiveAgree cl = new ClArchiveAgree();
            cl.AcrchiveID = Convert.ToInt32(AreaID);
            Data = cl;
            LightBox.Value = "1";

        }
        public ClArchiveAgree Data
        {
            get
            {
                ClArchiveAgree cl = new ClArchiveAgree();
                // cl.AgreeID = Convert.ToInt32(TXTAgreeID.Text);
               // cl.AcrchiveID = Convert.ToInt32(TXTAgreeID.Text);
                cl.ActionPercent =  TXTActionPercent.Text ;
                cl.FineZarib =  TXTFineZarib.Text.ToString() ;
                //cl.FromDate = TXTFromDate.Text ;
                cl.OperationSum =   TXTOperationSum.Text  ;
                cl.PaySum =   TXTPaySum.Text  ;
                cl.PriceUnit = TXTPriceUnit.Text ;
                cl.Pulus = TXTPulus.Text ;
              //   cl.SubjectExplainID = Convert.ToInt32(ddSubject.Text);
                // cl.SubjectID =Convert.ToInt32( ddSubject.Text);
                cl.SumMeter = TXTSumMeter.Text ;
                cl.UnitNameID =Convert.ToInt32( TXTUnitNameID.Text);
                cl.UtilityPercent =  TXTUtilityPercent.Text ;
                cl.AcrchiveID = ArchivID;
                cl.repeattt =Convert.ToString( txtrepeattt.Text==""?"0":txtrepeattt.Text);
                return cl;
            }
            set
            {
                DataSet ds = ArchiveAgreeClass.GetList(value);
                DataRow dr = ds.Tables[0].Rows[0];
                TXTAcrchiveID.Text = dr["AcrchiveID"].ToString();
                TXTActionPercent.Text = dr["ActionPercent"].ToString();
               // TXTAgreeID.Text = dr["AgreeID"].ToString();
                TXTFineZarib.Text = dr["FineZarib"].ToString();
               // TXTFromDate.Text = dr["FromDate"].ToString();
                TXTOperationSum.Text = dr["OperationSum"].ToString();
                TXTPaySum.Text = dr["PaySum"].ToString();
                TXTPriceUnit.Text = dr["PriceUnit"].ToString();
                TXTPulus.Text = dr["Pulus"].ToString();
               // TXTSubjectExplainID.Text = dr["SubjectExplainID"].ToString();
              //  TXTSubjectID.Text = dr["SubjectID"].ToString();
                TXTSumMeter.Text = dr["SumMeter"].ToString();
              //  TXTToDate.Text = dr["ToDate"].ToString();
                TXTUnitNameID.Text = dr["UnitNameID"].ToString();
                TXTUtilityPercent.Text = dr["UtilityPercent"].ToString();
                txtrepeattt.Text = dr["repeattt"].ToString();
                
            }
        }

        protected void BtnInsert_Click(object sender, EventArgs e)
        {
            ClArchiveAgree cl=new ClArchiveAgree();
                cl=Data;
                int i=ArchiveAgreeClass.Update(cl);
                if (i == 0)
                    CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "خطا در ثبت");
                else
                    BindGrid();
         
        }





    }
}