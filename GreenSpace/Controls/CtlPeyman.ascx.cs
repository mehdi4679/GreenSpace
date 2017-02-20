using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using GreenSpaceCL;
using GreenSpaceDAL;
using System.Web.UI.HtmlControls;
    
namespace GreenSpace.Controls
{
    public partial class CtlPeyman : System.Web.UI.UserControl
    {
        public ClPeyman Data
        {
            get
            {
                ClPeyman cl = new ClPeyman();
                cl.PeymanName = TXTPeymanName.Text;
                cl.PeymanNumber = DDPeymanNumber.SelectedValue.ToString();
                cl.PeymanID = Convert.ToInt32(LblParamPeymanID.Text);
               
                return cl;
            }
            set
            {
                DataSet ds = PeymanClass.GetList(value);
                DataRow dr = ds.Tables[0].Rows[0];
                TXTPeymanName.Text = dr["PeymanName"].ToString();
                DDPeymanNumber.Text = dr["PeymanNumber"].ToString();
                LblParamPeymanID.Text = dr["PeymanID"].ToString();
                
                ds.Dispose();
            }
        }

        public void BindDD()
        {
            DDPeymanNumber.DataSource = TaxiDAL.CatalogClass.GetListTypeID("2");
            DDPeymanNumber.DataTextField = "CatalogName";
            DDPeymanNumber.DataValueField = "CatalogValue";
            DDPeymanNumber.DataBind();

        }

        public int ParkID
        {
            get { return Convert.ToInt32(LblParamPeymanID.Text); }
            set { LblParamPeymanID.Text = value.ToString(); }
        }
        public void BindGrid()
        {
            ClPeyman cl = new ClPeyman();

            DataSet ds = PeymanClass.GetList(cl);
            DataView dv = new DataView(ds.Tables[0]);
            if (ViewState["PeymanID"] == null)
            {
                ViewState["PeymanID"] = "PeymanID Desc";
            }
            dv.Sort = Securenamespace.SecureData.CheckSecurity(ViewState["PeymanID"].ToString()).ToString();
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
            if (ViewState["PeymanID" + "Direction"] == null)
            {
                ViewState.Add("PeymanID" + "Direction", "desc");
            }

            StrSortDirection = Securenamespace.SecureData.CheckSecurity(ViewState["PeymanID" + "Direction"].ToString());

            if (StrSortDirection == "desc")
                StrSortDirection = "asc";
            else
                StrSortDirection = "desc";

            ViewState["PeymanID" + "Direction"] = StrSortDirection;
            ViewState["PeymanID"] = e.SortExpression + " " + StrSortDirection;
            BindGrid();
        }
        public void DeleteItem(object sender, System.EventArgs e)
        {
            String peymanid = ((HtmlAnchor)sender).HRef.ToString();
            int i = PeymanClass.Delete(peymanid);
            if (i == 0)
            {
                LblMsg.Text = "  error ";
                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), Guid.NewGuid().ToString(), "alert('خطا در حذف');", true);
            }
            else { BindGrid(); }
            LightBox.Value = "0";
        }
        public void UpItem(object sender, EventArgs e)
        {
            String PeymanID = ((HtmlAnchor)sender).HRef.ToString();
            LblParamPeymanID.Text = PeymanID;
            ClPeyman cl = new ClPeyman();
            cl.PeymanID = Convert.ToInt32(PeymanID);
            Data = cl;
            LightBox.Value = "1";
            BtnInsert.Visible = true;
        }

        protected void BtnInsert_Click(Object sender, System.EventArgs e)
        {
            ClPeyman cl = new ClPeyman();
            cl = Data;

            int t = 0;
            if (CSharp.PublicFunction.ModeInsert(ParkID.ToString()))
                t = PeymanClass.insert(cl);
            else
                t = PeymanClass.Update(cl);

            if (t == 0)
              CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.General_Success,"خطا در ثبت");
            else
            {
                CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.General_Success, "ثبت  انجام شد.");
                BindGrid();
            }
            LightBox.Value = "0";
            LblParamPeymanID.Text = "0";
        }

        protected void BtnSerach_Click(object sender, EventArgs e)
        {
            DataSet ds = PeymanClass.GetList(Data);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            LightBox.Value = "0";

        }

        protected void btnInsertLight_Click(object sender, EventArgs e)
        {
            TXTPeymanName.Text = "";
            BtnSerach.Visible = false;
            BtnInsert.Visible = true;
            LblParamPeymanID.Text = "0";
        }

        protected void btnSerachLight_Click(object sender, EventArgs e)
        {
  TXTPeymanName.Text = "";
            BtnSerach.Visible = true;
            BtnInsert.Visible = false;
            LblParamPeymanID.Text = "0";
            LightBox.Value = "1";
        }

    }
}