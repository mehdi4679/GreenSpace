using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GreenSpaceDAL;
using GreenSpaceBLL;
using GreenSpaceCL;
using TaxiDAL;
using System.Data;
using System.Web.UI.HtmlControls;

namespace GreenSpace.Controls
{
    public partial class CtlAgreePercentProtest : System.Web.UI.UserControl
    {
        public ClAgreePercentProtest Data
        {
            get
            {
                ClAgreePercentProtest cl = new ClAgreePercentProtest();
                cl.AgreePercentProtestID = Convert.ToInt32(LblAgreementPercentID.Text);
                cl.AgreementPercentID = Convert.ToInt32(LblAgreementPercentID.Text);
                cl.ProtestStatusID = Convert.ToInt32(DDProtestStatusID.SelectedValue);
                cl.ProtestDate = DateConvert.sh2m(TXTProtestDate.Text).ToString();
                cl.UserResponseID = Convert.ToInt32(DDUserResponseID.SelectedValue);
                cl.ProtestComment = TXTProtestComment.Text;
                return cl;
            }
            set
            {
                DataSet ds = AgreePercentProtestClass.GetList(value);
                DataRow dr = ds.Tables[0].Rows[0];
                TXTProtestComment.Text = dr["ProtestComment"].ToString();
                TXTProtestDate.Text = DateConvert.m2sh(dr["ProtestDate"].ToString());
                DDProtestStatusID.SelectedValue = dr["ProtestStatusID"].ToString();
                DDUserResponseID.SelectedValue = dr["UserResponseID"].ToString();
                LblAgreementPercentID.Text = dr["AgreementPercentID"].ToString();
                LblParamAgreePercentProtestID.Text = dr["AgreePercentProtestID"].ToString();



                ds.Dispose();
            }
        }

        public void BindDD()
        {

            DDProtestStatusID.DataSource = CatalogClass.GetListTypeID("7");
            DDProtestStatusID.DataTextField = "CatalogName";
            DDProtestStatusID.DataValueField = "CatalogValue";
            DDProtestStatusID.DataBind();


            
            DDUserResponseID.DataSource = TaxiDAL.UsersClass.GetList(null, null, null, null, null, null, "3", null, null, null, null);
            DDUserResponseID.DataTextField = "FullNameUser";
            DDUserResponseID.DataValueField = "UserID";
            DDUserResponseID.DataBind();
           

        }

        public int  AgreementPercentID
        {
            get { return Convert.ToInt32(LblAgreementPercentID.Text); }
            set { LblAgreementPercentID.Text = value.ToString(); }
        }

        public int  AgreePercentProtestID
        {
            get { return Convert.ToInt32(LblParamAgreePercentProtestID.Text); }
            set { LblParamAgreePercentProtestID.Text = value.ToString(); }
        }
        public void BindGrid()
        {
            ClAgreePercentProtest cl = new ClAgreePercentProtest();
            cl.AgreementPercentID = AgreementPercentID;


            DataSet ds = AgreePercentProtestClass.GetList(cl);
            DataView dv = new DataView(ds.Tables[0]);
            if (ViewState["AgreePercentProtestID "] == null)

                ViewState["AgreePercentProtestID"] = "AgreePercentProtestID Desc";
             
            dv.Sort = Securenamespace.SecureData.CheckSecurity(ViewState["AgreePercentProtestID"].ToString()).ToString();
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
            if (ViewState["AgreePercentProtestID" + "Direction"] == null)
            {
                ViewState.Add("AgreePercentProtestID" + "Direction", "desc");
            }

            StrSortDirection = Securenamespace.SecureData.CheckSecurity(ViewState["AgreePercentProtestID" + "Direction"].ToString());

            if (StrSortDirection == "desc")
                StrSortDirection = "asc";
            else
                StrSortDirection = "desc";

            ViewState["AgreePercentProtestID" + "Direction"] = StrSortDirection;
            ViewState["AgreePercentProtestID"] = e.SortExpression + " " + StrSortDirection;
            BindGrid();
        }
        public void DeleteItem(object sender, System.EventArgs e)
        {
            String AgreePercentProtestID = ((HtmlAnchor)sender).HRef.ToString();
            int i = AgreePercentProtestClass.Delete(AgreePercentProtestID);
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
        //    ClAgreePercentProtest cl = new ClAgreePercentProtest();
        //    cl.AgreementFineID = Convert.ToInt32(AgreementFineID);
        //    Data = cl;
        //    LightBox.Value = "1";

        //}

        protected void BtnInsert_Click(Object sender, System.EventArgs e)
        {
            ClAgreePercentProtest cl = new ClAgreePercentProtest();
            cl = Data;

            int t = 0;
            if (CSharp.PublicFunction.ModeInsert(AgreePercentProtestID.ToString()))
                t = AgreePercentProtestClass.insert(cl);
            else
                t = AgreePercentProtestClass.Update(cl);

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
            // LightBox.Value = "0";
             LblParamAgreePercentProtestID.Text = "0";
        }

        protected void BtnSerach_Click(object sender, EventArgs e)
        {
            DataSet ds = AgreePercentProtestClass.GetList(Data);
            GridView1.DataSource = ds;
            GridView1.DataBind();
         //   LightBox.Value = "0";

        }


        
    }
}