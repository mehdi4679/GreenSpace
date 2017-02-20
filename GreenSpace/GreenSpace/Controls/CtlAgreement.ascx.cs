using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GreenSpaceCL;
using GreenSpaceDAL;
using System.Data;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using GreenSpaceBLL;

namespace GreenSpace.Controls
{
    public partial class CtlAgreement : System.Web.UI.UserControl
    {

        public ClAgreement  Data
        {
            get
            {
                ClAgreement cl = new ClAgreement();
                cl.EndDateAgreement = DateConvert.sh2m(TXTEndDateAgreement.Text).ToString();
                cl.PriceAgreementYear =Convert.ToInt64( TXTPriceAgreementYear.Text.Replace("ریال","").Replace(",",""));
                cl.StatrtDateAgreement = DateConvert.sh2m(TXTStatrtDateAgreement.Text).ToString();
                cl.MasterGreenSpaceID =Convert.ToInt32( DDMasterGreenSpaceID.SelectedValue );
                cl.MonitorinOfficeID = Convert.ToInt32(DDMonitorinOfficeID.SelectedValue);
             cl.PeymanID=   Convert.ToInt32(DDPeymanID.SelectedValue);
              cl.PeymanKarID=          Convert.ToInt32(DDPeymanKarID.SelectedValue);
                    cl.supervisor2ID=    Convert.ToInt32(DDsupervisor2ID.SelectedValue);
                  cl.supervisor3ID     = Convert.ToInt32(DDsupervisor3ID.SelectedValue);
                 cl.supervisorStaticID=       Convert.ToInt32(DDsupervisorStaticID.SelectedValue);
                 cl.Puls = Convert.ToInt32(txtPulse.Text);
                 cl.AgreementID = Convert.ToInt32(LblParamAgreementID.Text);
                return cl;
            }
            set
            {
                DataSet ds = AgreementClass.GetList(value);
                DataRow dr = ds.Tables[0].Rows[0];
                TXTEndDateAgreement.Text =DateConvert.m2sh( dr["EndDateAgreement"].ToString()).ToString();
                TXTPriceAgreementYear.Text = dr["PriceAgreementYear"].ToString();
                TXTStatrtDateAgreement.Text =DateConvert.m2sh( dr["StatrtDateAgreement"].ToString()).ToString();
                DDMasterGreenSpaceID.Text = dr["MasterGreenSpaceID"].ToString();
                DDMonitorinOfficeID.SelectedValue = dr["MonitorinOfficeID"].ToString();
                DDPeymanID.SelectedValue = dr["PeymanID"].ToString();
                DDPeymanKarID.SelectedValue = dr["PeymanKarID"].ToString();
                DDsupervisor2ID.SelectedValue = dr["supervisor2ID"].ToString();
                DDsupervisor3ID.SelectedValue = dr["supervisor3ID"].ToString();
                DDsupervisorStaticID.SelectedValue = dr["supervisorStaticID"].ToString();
                LblParamAgreementID.Text = dr["AgreementID"].ToString();
                txtPulse.Text = dr["Puls"].ToString();

                ds.Dispose();
            }
        }

        public void BindDD()
        {


            DDMasterGreenSpaceID.DataSource = TaxiDAL.UsersClass.GetList(null, null, null, null, null, null, "4", null, null, null, null);
            DDMasterGreenSpaceID.DataTextField = "FullNameUser";
            DDMasterGreenSpaceID.DataValueField = "UserID";
            DDMasterGreenSpaceID.DataBind();
            

            DDMonitorinOfficeID.DataSource = TaxiDAL.CatalogClass.GetListTypeID("5");
            DDMonitorinOfficeID.DataTextField = "CatalogName";
            DDMonitorinOfficeID.DataValueField = "CatalogValue";
            DDMonitorinOfficeID.DataBind();

            ClPeyman clpeyman = new ClPeyman();
            DDPeymanID.DataSource = PeymanClass.GetList(clpeyman);
            DDPeymanID.DataTextField = "PeymanName";
            DDPeymanID.DataValueField = "PeymanID";
            DDPeymanID.DataBind();

            DDPeymanKarID.DataSource = TaxiDAL.UsersClass.GetList(null, null, null, null, null, null, "1", null, null, null, null);
            DDPeymanKarID.DataTextField = "FullNameUser";
            DDPeymanKarID.DataValueField = "UserID";
            DDPeymanKarID.DataBind();

            DataSet ds=TaxiDAL.UsersClass.GetList(null, null, null, null, null, null, "2", null, null, null, null);
            DDsupervisor2ID.DataSource = ds;
            DDsupervisor2ID.DataValueField = "UserID";
            DDsupervisor2ID.DataTextField = "FullNameUser";
            DDsupervisor2ID.DataBind();

            DDsupervisor3ID.DataSource = ds;
            DDsupervisor3ID.DataTextField = "FullNameUser";
            DDsupervisor3ID.DataValueField = "UserID";
            DDsupervisor3ID.DataBind();

            DataSet ds22 = TaxiDAL.UsersClass.GetList(null, null, null, null, null, null, "6", null, null, null, null);

            DDsupervisorStaticID.DataSource = ds22;
            DDsupervisorStaticID.DataTextField = "FullNameUser";
            DDsupervisorStaticID.DataValueField = "UserID";
            DDsupervisorStaticID.DataBind();
        }

        public int AgreementID
        {
            get { return Convert.ToInt32(LblParamAgreementID.Text); }
            set { LblParamAgreementID.Text = value.ToString(); }
        }
        public bool VisibleInsert
        {
            get { 
                return BtnInsert.Visible;
           
            }
            set { 
                BtnInsert.Visible = value;
            if(!value)
                btnInsertLight.Style.Add("display", "none");
            }
        }
        public bool VisibleDelete
        {
            get { return GridView1.Columns[1].Visible=false;; }
            set { GridView1.Columns[1].Visible = value; }
        }
        public bool VisibleEdit
        {
            get { return GridView1.Columns[2].Visible=false;; }
            set { GridView1.Columns[2].Visible = value; }
        }

        public void BindGrid()
        {
            ClAgreement cl = new ClAgreement();
            
            DataSet ds = AgreementClass.GetList(cl);
            DataView dv = new DataView(ds.Tables[0]);
            if (ViewState["AgreementID"] == null)
            {
                ViewState["AgreementID"] = "AgreementID Desc";
            }
            dv.Sort = Securenamespace.SecureData.CheckSecurity(ViewState["AgreementID"].ToString()).ToString();
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
        public void DeleteItem(object sender, System.EventArgs e)
        {
            String AgreementID = ((HtmlAnchor)sender).HRef.ToString();
            int i = AgreementClass.Delete(AgreementID);
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
            String AgreementID = ((HtmlAnchor)sender).HRef.ToString();
            LblParamAgreementID.Text = AgreementID;
            ClAgreement cl = new ClAgreement();
            cl.AgreementID = Convert.ToInt32(AgreementID);
            Data = cl;
            LightBox.Value = "1";

        }
         protected void BtnInsert_Click(Object sender, System.EventArgs e)
        {
            
             ClAgreement cl = new ClAgreement();
            cl = Data;

            int t = 0;
            if (CSharp.PublicFunction.ModeInsert(AgreementID.ToString()))
                t = AgreementClass.insert(cl);
            else
                t = AgreementClass.Update(cl);

            if (t == 0)
            {
                LblMsg.ForeColor = System.Drawing.Color.Red;
                CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "خطا در ثبت");
              //  LblMsg.Text = "";
            }
            else
            {
                LblMsg.ForeColor = System.Drawing.Color.Green;
                CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.General_Success, "ثبت  انجام شد");
                LblMsg.Text = "ثبت  انجام شد.";
                BindGrid();
            }
            LightBox.Value = "0";
            LblParamAgreementID.Text = "0";
        }

        protected void BtnSerach_Click(object sender, EventArgs e)
        {
            DataSet ds = AgreementClass.GetList(Data);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            LightBox.Value = "0";
         
        }

        protected void btnInsertLight_Click(object sender, EventArgs e)
        {
            LightBox.Value = "1";
            BtnInsert.Visible = true;
            BtnSerach.Visible = false;
            LblParamAgreementID.Text = "0";
        }

        protected void btnSerachLight_Click(object sender, EventArgs e)
        {
   LightBox.Value = "1";
            BtnInsert.Visible = false;
            BtnSerach.Visible = true;
            LblParamAgreementID.Text = "0";
        }

    }
}