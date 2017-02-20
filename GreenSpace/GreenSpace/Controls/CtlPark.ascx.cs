using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using GreenSpaceCL;
using GreenSpaceDAL ;
using System.Web.UI.HtmlControls;
    
namespace GreenSpace.Controls
{
    public partial class CtlPark : System.Web.UI.UserControl
    {

        //private void BindPeyman() {
        //    ClPeyman cl = new ClPeyman();
        //    ddpeyman.DataSource = PeymanClass.GetList(cl);
        //    ddpeyman.DataTextField = "PeymanName";
        //    ddpeyman.DataValueField = "PeymanID";
        //    ddpeyman.DataBind();
        //}
         public ClPark Data {
            get {
                ClPark cl = new ClPark();
                 cl.ParkAdress=TXTParkAdress.Text;
                cl.ParkArea= TXTParkArea.Text;
                cl.ParkDistrict=Convert.ToInt32(DDParkDistrict.SelectedValue);
                cl.ParkName=TXTParkName.Text;
                cl.ParkID=Convert.ToInt32( LblParamParkID.Text);
                return cl;           
            }
            set {
                DataSet ds = ParkClass.GetList(value);
                DataRow dr = ds.Tables[0].Rows[0];
                TXTParkName.Text = dr["ParkName"].ToString();
                TXTParkArea.Text=dr["ParkArea"].ToString();
                TXTParkAdress.Text=dr["ParkAdress"].ToString();
                LblParamParkID.Text=  dr["ParkID"].ToString();
                DDParkDistrict.SelectedValue=dr["ParkDistrict"].ToString();
 
                ds.Dispose();
            }
        }

        public void BindDD() {
            DDParkDistrict.DataSource =TaxiDAL.CatalogClass.GetListTypeID("2");
            DDParkDistrict.DataTextField = "CatalogName";
            DDParkDistrict.DataValueField = "CatalogValue";
            DDParkDistrict.DataBind();

       //     BindPeyman();
        }

        public int ParkID{
        get{return Convert.ToInt32(LblParamParkID.Text);}
            set{LblParamParkID.Text=value.ToString();}
        }
        public void BindGrid()
        {
            ClPark cl = new ClPark();
          
            DataSet ds = ParkClass.GetList(cl);
            DataView dv = new DataView(ds.Tables[0]);
            if  (ViewState["ParkID"]  == null)
            {
                ViewState["ParkID"] = "ParkID Desc";
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
            string StrSortDirection  ;
            if (ViewState["ParkID" + "Direction"] == null)
            {
                ViewState.Add("ParkID" + "Direction", "desc");
            }
            
                StrSortDirection =Securenamespace.SecureData.CheckSecurity(ViewState["PersonalLearning" + "Direction"].ToString());
             
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
            String ParkID = ((HtmlAnchor)sender).HRef.ToString();
            int i = ParkClass.Delete(ParkID);
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
            String ParkID = ((HtmlAnchor)sender).HRef.ToString();
            LblParamParkID.Text = ParkID;
            ClPark cl=new ClPark();
            cl.ParkID=Convert.ToInt32( ParkID);
            Data = cl;
            LightBox.Value = "1";
            
        }
    
      protected void BtnInsert_Click(Object sender, System.EventArgs e)
        {
            ClPark cl = new ClPark();
            cl = Data;

            int t = 0;
            if(CSharp.PublicFunction.ModeInsert(ParkID.ToString()))
              t=  ParkClass.insert(cl);
            else
             t=   ParkClass.Update(cl);

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
            LblParamParkID.Text = "0";
        }

      protected void BtnSerach_Click(object sender, EventArgs e)
      {
          DataSet ds =ParkClass.GetList( Data);
          GridView1.DataSource = ds;
          GridView1.DataBind();
          LightBox.Value = "0";

      }

      
    
    
    }
    }
 