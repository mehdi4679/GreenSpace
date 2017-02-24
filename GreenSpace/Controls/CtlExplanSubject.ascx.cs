using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GreenSpaceCL;
using GreenSpaceDAL;
using System.Web.UI.HtmlControls;
using System.Data;

namespace GreenSpace.Controls
{
    public partial class CtlExplanSubject : System.Web.UI.UserControl
    {
        public ClExplanSubject Data
        {
            get
            {
                ClExplanSubject cl = new ClExplanSubject();
                cl.DayPriceDefualt =Convert.ToInt32( TXTDayPriceDefualt.Text);
                cl.ExplainName = TXTExplainName.Text;
                cl.NightPriceDefualt =Convert.ToInt32( TXTNightPriceDefualt.Text);
                cl.RotinOrNot = Convert.ToInt32(DDRotinOrNot.SelectedValue);
                cl.SubjectID = Convert.ToInt32(DDSubjectID.Text);
                cl.UnitNameID = Convert.ToInt32(DDUnitNameID.SelectedValue);
                cl.ExplainSubjectID = Convert.ToInt32(LblParamExplainSubjectID.Text);
                return cl;
            }
            set
            {
                DataSet ds = ExplanSubjectClass.GetList(value);
                DataRow dr = ds.Tables[0].Rows[0];
                TXTDayPriceDefualt.Text =  dr["DayPriceDefualt"].ToString() ;
                TXTExplainName.Text = dr["ExplainName"].ToString();
                TXTNightPriceDefualt.Text = dr["NightPriceDefualt"].ToString() ;
                LblParamExplainSubjectID.Text = dr["ExplainSubjectID"].ToString();
                DDRotinOrNot.SelectedValue = dr["RotinOrNot"].ToString();
                DDSubjectID.SelectedValue = dr["SubjectID"].ToString();
                DDUnitNameID.SelectedValue = dr["UnitNameID"].ToString();

                ds.Dispose();
            }
        }

        public void BindDD()
        {


            DDSubjectID.DataSource = TaxiDAL.CatalogClass.GetListTypeID("3");
            DDSubjectID.DataTextField = "CatalogName";
            DDSubjectID.DataValueField = "CatalogValue";
            DDSubjectID.DataBind();
            DDUnitNameID.DataSource = TaxiDAL.CatalogClass.GetListTypeID("4");
            DDUnitNameID.DataTextField = "CatalogName";
            DDUnitNameID.DataValueField = "CatalogValue";
            DDUnitNameID.DataBind();

            

        }
        public int SubJectID
        {
            get { return Convert.ToInt32(DDSubjectID.SelectedValue); }
            set { DDSubjectID.SelectedValue = value.ToString(); }
        }
        public bool EnableSubject {
            get {return DDSubjectID.Enabled; }
            set { DDSubjectID.Enabled = value; }
        }
        public int ExplainSubjectID
        {
            get { return Convert.ToInt32(LblParamExplainSubjectID.Text); }
            set { LblParamExplainSubjectID.Text = value.ToString(); }
        }
        public void BindGrid()
        {
            ClExplanSubject cl = new ClExplanSubject();
            cl.SubjectID = Convert.ToInt32(DDSubjectID.SelectedValue);
            DataSet ds = ExplanSubjectClass.GetList(cl);
            DataView dv = new DataView(ds.Tables[0]);
            if (ViewState["ExplainSubjectID"] == null)
            {
                ViewState["ExplainSubjectID"] = "ExplainSubjectID Desc";
            }
            dv.Sort = Securenamespace.SecureData.CheckSecurity(ViewState["ExplainSubjectID"].ToString()).ToString();
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
            if (ViewState["ExplainSubjectID" + "Direction"] == null)
            {
                ViewState.Add("ExplainSubjectID" + "Direction", "desc");
            }

            StrSortDirection = Securenamespace.SecureData.CheckSecurity(ViewState["ExplainSubjectID" + "Direction"].ToString());

            if (StrSortDirection == "desc")
                StrSortDirection = "asc";
            else
                StrSortDirection = "desc";

            ViewState["ExplainSubjectID" + "Direction"] = StrSortDirection;
            ViewState["ExplainSubjectID"] = e.SortExpression + " " + StrSortDirection;
            BindGrid();
        }
        public void DeleteItem(object sender, System.EventArgs e)
        {
            String ParkID = ((HtmlAnchor)sender).HRef.ToString();
            int i = ExplanSubjectClass.Delete(ParkID);
            if (i == 0)
            {
                LblMsg.Text = " error ";
                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), Guid.NewGuid().ToString(), "alert('خطا در حذف');", true);
            }
            else { BindGrid(); }
            LightBox.Value = "0";
        }
        public void HavePlusItem(object sender, System.EventArgs e)
        {
            String ExplanID = ((HtmlAnchor)sender).HRef.ToString() ;
            String HavePlusItem = ((HtmlAnchor)sender).Attributes["VisibleItem"].ToString();
            if (HavePlusItem == "0")
                HavePlusItem = "1";
            else
                HavePlusItem = "0";
             ClExplanSubject cl = new ClExplanSubject();
             cl.ExplainSubjectID = Convert.ToInt32(ExplanID);
            cl.HavePlus = Convert.ToInt32(HavePlusItem);

            if (ExplanSubjectClass.Update(cl) == 0)
                CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "خطا در ثیت");
            else
                BindGrid();
         }

        public void VisibleItem(object sender, System.EventArgs e)
        {
            String ExplanID = ((HtmlAnchor)sender).HRef.ToString() ;
            String VisibleItem = ((HtmlAnchor)sender).Attributes["VisibleItem"].ToString();
            if (VisibleItem == "0")
                VisibleItem = "1";
            else
                VisibleItem = "0";
             ClExplanSubject cl = new ClExplanSubject();
             cl.ExplainSubjectID = Convert.ToInt32(ExplanID);
            cl.Visible = Convert.ToInt32(VisibleItem);

            if (ExplanSubjectClass.Update(cl) == 0)
                CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "خطا در ثیت");
            else
                BindGrid();
         }


        public void UpItem(object sender, EventArgs e)
        {
            String ExplainSubjectID = ((HtmlAnchor)sender).HRef.ToString();
             ClExplanSubject cl = new ClExplanSubject();
             cl.ExplainSubjectID = Convert.ToInt32(ExplainSubjectID);
            Data = cl;
            LightBox.Value = "1";

        }
        public void ErthItem(object sender, EventArgs e)
        {
            String ExplainSubjectID = ((HtmlAnchor)sender).HRef.ToString();
            String ErthAzKol = ((HtmlAnchor)sender).Attributes["ErthAzKol"].ToString();
            if (ErthAzKol == "0")
                ErthAzKol = "1";
            else
                ErthAzKol = "0";

             ClExplanSubject cl = new ClExplanSubject();
             cl.ExplainSubjectID = Convert.ToInt32(ExplainSubjectID);
             cl.ErthAzKol = Convert.ToInt32(ErthAzKol);

             if (ExplanSubjectClass.Update(cl) == 0)
                 CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "خطا در ثیت");
             else
                 BindGrid();
                        

        }
        public void UseFromKolItem(object sender, EventArgs e)
        {
            String ExplainSubjectID = ((HtmlAnchor)sender).HRef.ToString();
            String UseFromKol = ((HtmlAnchor)sender).Attributes["UseFromKol"].ToString();
            if (UseFromKol == "0")
                UseFromKol = "1";
            else
                UseFromKol = "0";

             ClExplanSubject cl = new ClExplanSubject();
             cl.ExplainSubjectID = Convert.ToInt32(ExplainSubjectID);
             cl.UseFromKol = Convert.ToInt32(UseFromKol);

             if (ExplanSubjectClass.Update(cl) == 0)
                 CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "خطا در ثیت");
             else
                 BindGrid();
                        

        }
     protected void BtnInsert_Click(Object sender, System.EventArgs e)
        {
            ClExplanSubject cl = new ClExplanSubject();
            cl = Data;

            int t = 0;
            if (CSharp.PublicFunction.ModeInsert(ExplainSubjectID.ToString()))
                t = ExplanSubjectClass.insert(cl);
            else
                t = ExplanSubjectClass.Update(cl);

            if (t == 0)
            {
                LblMsg.ForeColor = System.Drawing.Color.Red;
                LblMsg.Text = "خطا در ثبت";
            }
            else if (t == -1)
            {
                CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "خطا در ثبت مجدد شرح کار!!!");
            }
            else
            {
                LblMsg.ForeColor = System.Drawing.Color.Green;
                LblMsg.Text = "ثبت  انجام شد.";
                BindGrid();
            }
            LightBox.Value = "0";
            LblParamExplainSubjectID.Text = "0";
        }

        protected void BtnSerach_Click(object sender, EventArgs e)
        {
            DataSet ds = ExplanSubjectClass.GetList(Data);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            LightBox.Value = "0";

        }

    }
}