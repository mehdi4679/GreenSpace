﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GreenSpaceDAL;
using GreenSpaceCL;
using System.Data;
using System.Web.UI.HtmlControls;

namespace GreenSpace.Controls
{
    public partial class CtlPEymanPark : System.Web.UI.UserControl
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
                DDParkID.SelectedValue = dr["ParkID"].ToString();
                DDPeymanID.SelectedValue = dr["PeymanID"].ToString();
                lblAgrementID.Text = dr["AgrementID"].ToString(); 

                ds.Dispose();
            }
        }

        public void BindDD()
        {

            ClPark cl = new ClPark();
             
            DDParkID.DataSource = ParkClass.GetList(cl);
            DDParkID.DataTextField = "ParkName";
            DDParkID.DataValueField = "ParkID";
            DDParkID.DataBind();

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


            DataSet ds = PeymanParkClass.GetList(cl);
            DataView dv = new DataView(ds.Tables[0]);
            if (ViewState["PeymanParkID"] == null)
            {
                ViewState["PeymanParkID"] = "PeymanParkID Desc";
            }
            dv.Sort = Securenamespace.SecureData.CheckSecurity(ViewState["PeymanParkID"].ToString()).ToString();
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

            if (t == 0)
            {
                LblMsg.ForeColor = System.Drawing.Color.Red;
                LblMsg.Text = "خطا در ثبت";
            }
            else if (t == -1)
                CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "برای این شرح کار تکرار ثبت شده است");
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