using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GreenSpaceDAL;
using GreenSpaceCL;
using GreenSpaceBLL;
using System.Data;
using System.Web.UI.HtmlControls;

namespace GreenSpace.Controls
{
    public partial class CtlArea : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // CtlRegionPark.  nc1 = new CtlRegionPark.calll(BindGrid);
            
            //nc1.BeginInvoke(); 
            //GreenSpace.Controls.Fill =new CtlRegionPark.calll( BindGrid);

          //  DDParkID ctl = new DDParkID();
            DDParkID.pe += new CtlRegionPark.calll(BindGrid);

        }
    //    public CtlArea(){
    //        CtlRegionPark.calll nc1 = new CtlRegionPark.calll(BindGrid);
    //}
        public ClArea Data
        {
            get
            {
                ClArea cl = new ClArea();
                cl.AreaID = Convert.ToInt32(LblParamAreaID.Text);
                cl.ParkID = Convert.ToInt32(DDParkID.SelectedValue );
                cl.SubjectExplainID = Convert.ToInt32(DDSubjectExplainID.SelectedValue);
                cl.UnitNumber = TXTUnitNumber.Text.Replace(",","") ;
                cl.AgreementID = Convert.ToInt32(lblAgreementID.Text);
                cl.SubjectID = Convert.ToInt32(ddSubject.SelectedValue);


                return cl;
            }
            set
            {
                DataSet ds = AreaClass.GetList(value);
                DataRow dr = ds.Tables[0].Rows[0];
                TXTUnitNumber.Text = dr["UnitNumber"].ToString();
                DDParkID.SelectedValue  =Convert.ToInt32( dr["ParkID"].ToString());
                DDSubjectExplainID.Text = dr["SubjectExplainID"].ToString();
                lblAgreementID.Text = dr["AgreementID"].ToString();
                LblParamAreaID.Text = dr["AreaID"].ToString();
                ddSubject.SelectedValue = dr["SubjectID"].ToString();



                ds.Dispose();
            }
        }
        public void BindSubjectt()
        {

            ddSubject.DataSource = TaxiDAL.CatalogClass.GetListTypeID("3");
            ddSubject.DataTextField = "CatalogName";
            ddSubject.DataValueField = "CatalogValue";
            ddSubject.DataBind();
            ddSubject.Items.Insert(0, new ListItem("انتخاب نمایید", "0"));



        }
        private void BindPark() {
            //ClPark cl = new ClPark();
            //DataSet ds = ParkClass.GetList(cl);
            //DataView dv = new DataView(ds.Tables[0]);
            //if (ViewState["ParkID"] == null)
            //{
            //    ViewState["ParkID"] = "ParkID Desc";
            //}
            //dv.Sort = Securenamespace.SecureData.CheckSecurity(ViewState["ParkID"].ToString()).ToString();
            //DDParkID.DataSource = dv;
            //DDParkID.DataTextField = "ParkName";
            //DDParkID.DataValueField = "ParkID";
            //DDParkID.DataBind();
        }
        private void BindExplainSubject() {
            ClExplanSubject cl2 = new ClExplanSubject();
            cl2.SubjectID = Convert.ToInt32(ddSubject.SelectedValue);
            DDSubjectExplainID.DataSource = ExplanSubjectClass.GetList(cl2);
            DDSubjectExplainID.DataTextField = "ExplainName";
            DDSubjectExplainID.DataValueField = "ExplainSubjectID";
            DDSubjectExplainID.DataBind();
            DDSubjectExplainID.Items.Insert(0,new ListItem("   استفاده از کل  ", "-1"));
        }
        public void BindDD()
        {
            BindPeyman(DDPeymanSelect.SelectedValue.ToString());
            DDParkID.AutoPostBackPark = true;
            BindSubjectt();
            DDParkID.BindDD();
            DDParkID.SelectedRegion = 1;
            //BindPark();
            BindExplainSubject();
        }
        private void BindPeyman(string  i="0")
        {
             ClPeyman cl = new ClPeyman();

             if (Request.QueryString["aid"] != "")
             {
                 ClAgreement CL2 = new ClAgreement();
                 CL2.AgreementID = Convert.ToInt32(Request.QueryString["aid"]);
                 DataSet DSSS = AgreementClass.GetList(CL2);
                 DDPeymanSelect.DataSource = PeymanClass.GetList(cl);
                 DDPeymanSelect.DataTextField = "PeymanName";
                 DDPeymanSelect.DataValueField = "PeymanID";
                 DDPeymanSelect.DataBind();
             }
             else
             {
                 cl.PeymanID = 0;



                 DDPeymanSelect.DataSource = PeymanClass.GetList(cl);
                 DDPeymanSelect.DataTextField = "PeymanName";
                 DDPeymanSelect.DataValueField = "PeymanID";
                 DDPeymanSelect.DataBind();
             }

            DDPeymanSelect.Items.Insert(0, new ListItem("پیش فرض", "0"));

        }

        public int AreaID
        {
            get { return Convert.ToInt32(LblParamAreaID.Text); }
            set { LblParamAreaID.Text = value.ToString(); }
        }

        public int AgreementID
        {
            get { return Convert.ToInt32(lblAgreementID.Text); }
            set { lblAgreementID.Text = value.ToString();
            ClAgreement cl = new ClAgreement();
            cl.AgreementID = Convert.ToInt32(lblAgreementID.Text);
            DataSet ds = AgreementClass.GetList(cl);

            DDPeymanSelect.SelectedValue = ds.Tables[0].Rows[0]["PeymanID"].ToString();

            }
        }
        public string ViewAllpark
        {
            get { return  DDParkID.ViewAllPark; }
            set { DDParkID.ViewAllPark = value; }
        }

        public void BindGrid()
        {
            ClArea cl = new ClArea();
            cl.AgreementID = Convert.ToInt32(AgreementID);
            cl.SubjectID = Convert.ToInt32( ddSubject.SelectedValue);
             cl.ParkID =Convert.ToInt32(  DDParkID.SelectedValue.ToString());
 
            DataSet ds = AreaClass.GetList(cl);
            DataView dv = new DataView(ds.Tables[0]);
            if (ViewState["AreaID "] == null)

                ViewState["AreaID"] = "AreaID Desc";

            dv.Sort = Securenamespace.SecureData.CheckSecurity(ViewState["AreaID"].ToString()).ToString();
            GridView1.DataSource = dv;
            GridView1.DataBind();
            CalKol();
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
        public void DeleteItem(object sender, System.EventArgs e)
        {
            String AgreePercentProtestID = ((HtmlAnchor)sender).HRef.ToString();
            int i = AreaClass.Delete(AgreePercentProtestID);
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
            LblParamAreaID.Text = AreaID;
            ClArea cl = new ClArea();
            cl.AreaID = Convert.ToInt32(AreaID);
            Data = cl;
            LightBox.Value = "1";

        }

        protected void BtnInsert_Click(Object sender, System.EventArgs e)
        {
            ClArea cl = new ClArea();
            cl = Data;

            int t = 0;
            if(DDSubjectExplainID.SelectedValue.ToString()=="-1")
                t = AreaClass.insert(cl);
            else
            { 
            if (CSharp.PublicFunction.ModeInsert(LblParamAreaID.Text))
                t = AreaClass.insert(cl);
            else
                t = AreaClass.Update(cl);
            }

            if (t == 0)
            {
                CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "خطا در ثبت");
                //LblMsg.ForeColor = System.Drawing.Color.Red;
                //LblMsg.Text = "خطا در ثبت";
                BindGrid();
            }
            else if (t == -1000)
                 CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "متراژ وارده نباید از متراژ کل بیشتر شود");
            else if(t==-2000)
                CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "ابتدا متراژ کل ها را باید وارد نمایید");
             else if (t == -999)
            {
                CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "برای این پارک در این شرح کار مقدار وارد شده است");
            }
            else
            {
                LblMsg.ForeColor = System.Drawing.Color.Green;
                LblMsg.Text = "ثبت  انجام شد.";
                BindGrid();
            }
            LblParamAreaID.Text = "0";
            //LightBox.Value = "0";
        }

        protected void BtnSerach_Click(object sender, EventArgs e)
        {
            DataSet ds = AreaClass.GetList(Data);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            //   LightBox.Value = "0";

        }

        protected void ddSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();
            BindExplainSubject();
                 TXTUnitNumber.Text = "0";

        }

        protected void DDSubjectExplainID_SelectedIndexChanged(object sender, EventArgs e)
        {
                 CalKol();
         }

        private void CalKol()
        {
            if (DDSubjectExplainID.SelectedValue.ToString() != "-1")
                return;

            ClArea cl = new ClArea();
           
            cl.SubjectID = Convert.ToInt32(ddSubject.SelectedValue);
            cl.ParkID = Convert.ToInt32(DDParkID.SelectedValue);

            DataSet ds = AreaClass.GetList(cl);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                TXTUnitNumber.Text = dr["sumkol"].ToString();// +"00";

            }
            else
                TXTUnitNumber.Text = "0";

            ds.Dispose();
        }

        protected void DDPeymanSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();
        }
        public bool VisibleInsertAllPark
        {
            get { return BtnInsertAllPark.Visible; }
            set { BtnInsertAllPark.Visible = value; }
        }
        protected void BtnInsertAllPark_Click(object sender, EventArgs e)
        {
            ClArea cl = new ClArea();
            cl = Data;
            cl.SubjectID =Convert.ToInt32( ddSubject.SelectedValue);

            int i = 0;
            i = AreaClass.insertAllPark(cl);
            if (i <= 0)
                CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "ابتدا همه پارکها راانتخاب نمایید");
            else
            BindGrid();

        }
 
    }
}