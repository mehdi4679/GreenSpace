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
    public partial class CtlKhesarat : System.Web.UI.UserControl
    {
        public Clkhesarat Data
        {
            get
            {
                Clkhesarat cl = new Clkhesarat();
                cl.KhesaratDesc = TXTKhesaratDesc.Text;
                cl.KesaratPrice = Convert.ToInt32(TXTKesaratPrice.Text);
                cl.KesaratID = Convert.ToInt32(LblParamKesaratID.Text);
              
                return cl;
            }
            set
            {
                DataSet ds = khesaratClass.GetList(value);
                DataRow dr = ds.Tables[0].Rows[0];
                TXTKesaratPrice.Text = dr["KesaratPrice"].ToString();
                TXTKhesaratDesc.Text = dr["KhesaratDesc"].ToString();
                LblParamKesaratID.Text = dr["KesaratID"].ToString();
               

                ds.Dispose();
            }
        }

        public void BindDD()
        {
            //DDParkDistrict.DataSource = TaxiDAL.CatalogClass.GetListTypeID("2");
            //DDParkDistrict.DataTextField = "CatalogName";
            //DDParkDistrict.DataValueField = "CatalogValue";
            //DDParkDistrict.DataBind();

            //     BindPeyman();
        }

        public int khesaratID
        {
            get { return Convert.ToInt32(LblParamKesaratID.Text); }
            set { LblParamKesaratID.Text = value.ToString(); }
        }
        public void BindGrid()
        {
            Clkhesarat cl = new Clkhesarat();

            DataSet ds = khesaratClass.GetList(cl);
            DataView dv = new DataView(ds.Tables[0]);
            if (ViewState["ParkID"] == null)
            {
                ViewState["ParkID"] = "KesaratID Desc";
            }
            dv.Sort = Securenamespace.SecureData.CheckSecurity(ViewState["ParkID"].ToString()).ToString();
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
            if (ViewState["ParkID" + "Direction"] == null)
            {
                ViewState.Add("ParkID" + "Direction", "desc");
            }

            StrSortDirection = Securenamespace.SecureData.CheckSecurity(ViewState["PersonalLearning" + "Direction"].ToString());

            if (StrSortDirection == "desc")
                StrSortDirection = "asc";
            else
                StrSortDirection = "desc";

            ViewState["ParkID" + "Direction"] = StrSortDirection;
            ViewState["ParkID"] = e.SortExpression + " " + StrSortDirection;
            BindGrid();
        }
        public void DeleteItem(object sender, System.EventArgs e)
        {
            String KesaratID = ((HtmlAnchor)sender).HRef.ToString();
            int i = khesaratClass.Delete(KesaratID);
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
            String KesaratID = ((HtmlAnchor)sender).HRef.ToString();
            LblParamKesaratID.Text = KesaratID;
            Clkhesarat cl = new Clkhesarat();
            cl.KesaratID = Convert.ToInt32(KesaratID);
            Data = cl;
            LightBox.Value = "1";

        }

        protected void BtnInsert_Click(Object sender, System.EventArgs e)
        {
            Clkhesarat cl = new Clkhesarat();
            cl = Data;

            int t = 0;
            if (CSharp.PublicFunction.ModeInsert(khesaratID.ToString()))
                t = khesaratClass.insert(cl);
            else
                t = khesaratClass.Update(cl);

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
            LblParamKesaratID.Text = "0";
        }

        protected void BtnSerach_Click(object sender, EventArgs e)
        {
            DataSet ds = khesaratClass.GetList(Data);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            LightBox.Value = "0";

        }

        protected void btnInsertLight_Click(object sender, EventArgs e)
        {
            LightBox.Value = "1";
            LblParamKesaratID.Text = "0";
            TXTKhesaratDesc.Text = "";
            TXTKesaratPrice.Text = "";
        }
    }
}