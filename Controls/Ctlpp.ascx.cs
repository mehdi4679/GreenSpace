using GreenSpaceCL;
using GreenSpaceDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace GreenSpace.Controls
{
    public partial class Ctlpp : System.Web.UI.UserControl
    {

        public ClPeymanPark Data
        {
            get
            {
                ClPeymanPark cl = new ClPeymanPark();
                cl.PeymanParkID = Convert.ToInt32(LblParamPeymanParkID.Text);
                cl.PeymanID = Convert.ToInt32(DDPeymanID.SelectedValue);
                cl.ParkID = Convert.ToInt32(DDParkID.SelectedValue);

                cl.AgreementID = Convert.ToInt32(lblAgrementID.Text);


                return cl;
            }
            set
            {
                DataSet ds = PeymanParkClass.GetList(value);
                DataRow dr = ds.Tables[0].Rows[0];
                LblParamPeymanParkID.Text = dr["PeymanParkID"].ToString();
                DDParkID.SelectedValue =Convert.ToInt32( dr["ParkID"].ToString());
                DDPeymanID.SelectedValue = dr["PeymanID"].ToString();
                lblAgrementID.Text = dr["AgreementID"].ToString();

                ds.Dispose();
            }
        }

        public string PeymanID {
            get { return DDPeymanID.SelectedValue.ToString(); }
            set{DDPeymanID.SelectedValue=value;}
        }
        public bool EnableDDPeyman {
            get { return DDPeymanID.Enabled; }
            set { DDPeymanID.Enabled = value; }
        }

        public int ParkDistrict
        {
            get { return Convert.ToInt32(lblParkDistrict.Text); }
            set { lblParkDistrict.Text = value.ToString(); }
        }
        public void BindDD()
        {

            ClPark cl = new ClPark();
            
            //DDParkID.DataSource = ParkClass.GetList(cl);
            //DDParkID.DataTextField = "ParkName";
            //DDParkID.DataValueField = "ParkID";
            //DDParkID.DataBind();
            DDParkID.BindDD();
            DDParkID.SelectedRegion = Convert.ToInt32(lblParkDistrict.Text);

            ClPeyman cl2 = new ClPeyman();

            DDPeymanID.DataSource = PeymanClass.GetList(cl2);
            DDPeymanID.DataTextField = "PeymanName";
            DDPeymanID.DataValueField = "PeymanID";
            DDPeymanID.DataBind();





        }
        public int AgrrementID
        {
            get { return Convert.ToInt32(lblAgrementID.Text); }
            set { lblAgrementID.Text = value.ToString(); }
        }
        public int PeymanParkID
        {
            get { return Convert.ToInt32(LblParamPeymanParkID.Text); }
            set { LblParamPeymanParkID.Text = value.ToString(); }
        }
        public void BindGrid()
        {
            ClPeymanPark cl = new ClPeymanPark();



            cl.AgreementID = AgrrementID;
            cl.PeymanID =Convert.ToInt32( DDPeymanID.SelectedValue);

            DataSet ds = PeymanParkClass.GetList(cl);
            DataView dv = new DataView(ds.Tables[0]);
            if (ViewState["PeymanParkID"] == null)
            {
                ViewState["PeymanParkID"] = "PeymanParkID Desc";
            }
            dv.Sort = Securenamespace.SecureData.CheckSecurity(ViewState["PeymanParkID"].ToString()).ToString();
            GridView1.DataSource = dv;
            GridView1.DataBind();
            lblMetrajKol.Text = SumParks(ds);
        }
        public string SumParks(DataSet ds)
        {
            decimal o=0;
            for (int i = 0; i <  ds.Tables[0].Rows.Count; i++)
            {
                o += Convert.ToDecimal( ds.Tables[0].Rows[i]["ParkArea"].ToString()==""?"0":ds.Tables[0].Rows[i]["ParkArea"].ToString());
            }
            return o.ToString();
        }
        protected void GridView1_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            BindGrid();
        }
        protected void GridView1_Sorting(object sender, System.Web.UI.WebControls.GridViewSortEventArgs e)
        {
            string StrSortDirection;
            if (ViewState["PeymanParkID" + "Direction"] == null)
            {
                ViewState.Add("PeymanParkID" + "Direction", "desc");
            }


            StrSortDirection = ViewState["PeymanParkID" + "Direction"].ToString();

            if (StrSortDirection == "desc")
                StrSortDirection = "asc";
            else
                StrSortDirection = "desc";

            ViewState["PeymanParkID" + "Direction"] = StrSortDirection;
            ViewState["PeymanParkID"] = e.SortExpression + " " + StrSortDirection;
            BindGrid();
        }
        public void DeleteItem(object sender, System.EventArgs e)
        {
            String PeymanParkID = ((HtmlAnchor)sender).HRef.ToString();
            int i = PeymanParkClass.Delete(PeymanParkID);
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
            String PeymanParkID = ((HtmlAnchor)sender).HRef.ToString();
            LblParamPeymanParkID.Text = PeymanParkID;
            ClPeymanPark cl = new ClPeymanPark();
            cl.PeymanParkID = Convert.ToInt32(PeymanParkID);
            Data = cl;
            LightBox.Value = "1";
       }

        protected void BtnInsert_Click(Object sender, System.EventArgs e)
        {
            ClPeymanPark cl = new ClPeymanPark();
            cl = Data;




            int t = 0;
            if (CSharp.PublicFunction.ModeInsert(PeymanParkID.ToString()))
                t = PeymanParkClass.insert(cl);
            else
                t = PeymanParkClass.Update(cl);

            if (t == -1)
                CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "برای این پارک پیمان ثبت شده است");

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

            LblParamPeymanParkID.Text = "0";
        }


        protected void btnInsertLight_Click(object sender, EventArgs e)
        {
            BtnInsert.Visible = true;
            BtnSerach.Visible = false;
            LightBox.Value = "1";
        }

        protected void btnSerachLight_Click(object sender, EventArgs e)
        {
            BtnInsert.Visible = false;
            BtnSerach.Visible = true;
        }
        protected void BtnSerach_Click(object sender, EventArgs e)
        {

            DataSet ds = PeymanParkClass.GetList(Data);
            DataView dv = new DataView(ds.Tables[0]);
            if (ViewState["ExplanRepeatID"] == null)
            {
                ViewState["ExplanRepeatID"] = "ExplanRepeatID Desc";
            }
            dv.Sort = Securenamespace.SecureData.CheckSecurity(ViewState["ExplanRepeatID"].ToString()).ToString();
            GridView1.DataSource = dv;
            GridView1.DataBind();
        }
    }
}