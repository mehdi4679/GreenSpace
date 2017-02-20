using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GreenSpaceCL;
using GreenSpaceDAL;
using GreenSpaceBLL;
using TaxiCL;
using TaxiDAL;
using System.Data;
using System.Web.UI.HtmlControls;

namespace GreenSpace.Agree
{
    public partial class Archive : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                lblAgrement.Text = Request.QueryString["aid"].ToString();
                BindGrid();
            }
        }
        public void DeleteItem(object sender, System.EventArgs e)
        {
            String AgreePercentProtestID = ((HtmlAnchor)sender).HRef.ToString();

            int i = ArchiveAgreeTitleClass.Delete(AgreePercentProtestID);
            if (i == 0)
            {
             
                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), Guid.NewGuid().ToString(), "alert('خطا در حذف');", true);
            }
            else { BindGrid(); }
        }
        public void PrintItem(object sender, System.EventArgs e)
        {
            String AgreePercentProtestID = ((HtmlAnchor)sender).HRef.ToString();
            Response.Redirect("");

         }
        public void PrintItem2(object sender, System.EventArgs e)
        {
            String AgreePercentProtestID = ((HtmlAnchor)sender).HRef.ToString();
            string agreeid = ((HtmlAnchor)sender).Attributes["aid"].ToString();

            Response.Redirect("~/Agree//ArchivView.aspx?District=0&Archid=" + AgreePercentProtestID + "&aid=" + agreeid + "&Panme=" + "نمایش جزییات");

         }

        public ClArchiveAgreeTitle Data
        {
            get
            {
                ClArchiveAgreeTitle cl = new ClArchiveAgreeTitle();
                cl.FromDate = DateConvert.sh2m(CtlFromDate.Text).ToString();
                cl.ToDate = DateConvert.sh2m(CtlToDate.Text).ToString();
                cl.Title = txtTitle.Text ;
                cl.AgreeID = Convert.ToInt32(lblAgrement.Text);
                return cl;
            }
            set
            {
                DataSet ds = ArchiveAgreeTitleClass.GetList(value);
                DataRow dr = ds.Tables[0].Rows[0];
                
            }
        }

        public int AgreeID
        {
            get { return Convert.ToInt32(lblAgrement.Text); }
            set { lblAgrement.Text = value.ToString(); }
        }
        private int InsertArchiv(int iii)
        {

            ClArchiveAgree cl = new ClArchiveAgree();
            cl.AgreeID = Convert.ToInt32(lblAgrement.Text);
            cl.FromDate = DateConvert.sh2m(CtlFromDate.Text).ToString();
            cl.ToDate = DateConvert.sh2m(CtlToDate.Text).ToString();
            cl.ArchiveTitleID = iii;
            int i = ArchiveAgreeClass.insert(cl);
            if(i==-100)
                CSharp.Utility.ShowMsg(Page,CSharp.ProPertyData.MsgType.warning,"خطا.در این بازه زمانی آرشیو صورت گرفته است");
            else if(i==0)
                CSharp.Utility.ShowMsg(Page,CSharp.ProPertyData.MsgType.warning,"داده ای برای آرشیو وجود ندارد.خطا در ثبت آرشیو");
 

            
            //ClExplanPrice cl = new ClExplanPrice();
            //cl.AgreementID = AgreeID;
            // DataSet ds = ExplanPriceClass.GetList(cl);
            //DataRow dr;
            //int result = 0;
            //for(int i=0;i<ds.Tables[0].Rows.Count-1;i++){
            //    dr=ds.Tables[0].Rows[i];
           //      InsertOneSubject(Convert.ToInt32(dr["SubjectID"].ToString()));
            //    result += 1;
            //}
            return i;
        }

        private int InsertOneSubject(int Subject   )
        {
             ClArchiveAgree cl = new ClArchiveAgree();
            cl.SubjectID = Subject;
            cl.AgreeID = Convert.ToInt32(lblAgrement.Text);
            cl.FromDate = DateConvert.sh2m(CtlFromDate.Text).ToString();
            cl.ToDate = DateConvert.sh2m(CtlToDate.Text).ToString();
            int i = ArchiveAgreeClass.insert(cl);
            return i;

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            ClArchiveAgreeTitle cl = new ClArchiveAgreeTitle();
            cl = Data;
            int i = 0;
            if (CSharp.PublicFunction.ModeInsert(lblArchiveAgreeTitle.Text))
            {
                i = ArchiveAgreeTitleClass.insert(cl);
                if (i > 0)
                InsertArchiv(i);
             }
            else
                i = ArchiveAgreeTitleClass.Update(cl);


            if (i > 0)
                BindGrid();
            else
                CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "خطا در ثبت");

        }
        protected void GridView1_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            BindGrid();
        }
        protected void GridView1_Sorting(object sender, System.Web.UI.WebControls.GridViewSortEventArgs e)
        {
            string StrSortDirection;
            if (ViewState["AreaID" + "Direction"] == null)
            {
                ViewState.Add("AreaID" + "Direction", "desc");
            }

            StrSortDirection = Securenamespace.SecureData.CheckSecurity(ViewState["AreaID" + "Direction"].ToString());

            if (StrSortDirection == "desc")
                StrSortDirection = "asc";
            else
                StrSortDirection = "desc";

            ViewState["AreaID" + "Direction"] = StrSortDirection;
            ViewState["AreaID"] = e.SortExpression + " " + StrSortDirection;
            BindGrid();
        }

        private void BindGrid()
        {
            ClArchiveAgreeTitle cl = new ClArchiveAgreeTitle();
            cl.AgreeID = Convert.ToInt32(lblAgrement.Text);
            
            DataSet ds = ArchiveAgreeTitleClass.GetList(cl);
            DataView dv = new DataView(ds.Tables[0]);
            if (ViewState["AreaID "] == null)

                ViewState["AreaID"] = "tbl_ArchiveAgreeTitle Desc";

            dv.Sort = Securenamespace.SecureData.CheckSecurity(ViewState["AreaID"].ToString()).ToString();
            GridView1.DataSource = dv;
            GridView1.DataBind();

        }

        protected void ddArchivID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddEplanID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}