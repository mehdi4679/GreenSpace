using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GreenSpaceDAL;
using GreenSpaceCL;
using TaxiDAL;
using System.Data;
 
namespace GreenSpace.Controls
{
    
    public partial class CtlRegionPark : System.Web.UI.UserControl
    {
        public  delegate  void    calll( );
        public event calll pe;
        //public calll Fill ;
        //public int ss;
        
        private void BindRegion()
        {
            ddRegion.DataSource = CatalogClass.GetListTypeID("2");
            ddRegion.DataTextField = "CatalogName";
            ddRegion.DataValueField = "CatalogValue";
            ddRegion.DataBind();
        }
        public bool AutoPostBackPark
        {
            get
            {
                return ddPArk.AutoPostBack;
            }
            set
            {
                ddPArk.AutoPostBack = value;
            }
        }
          

    
     
        public void BindDD()
        {
            BindRegion();
            BindPArk();
        }
        private  void BindPArk()
        {
            ClPark cl=new ClPark();
            cl.ParkDistrict=Convert.ToInt32(ddRegion.SelectedValue);
            ddPArk.DataSource = ParkClass.GetList(cl);
         
            ddPArk.DataTextField = "ParkName";
            ddPArk.DataValueField = "ParkID";
            ddPArk.DataBind();
            if (pe != null)
            {
                pe();
            }
        }
        public int SelectedValue
        {
            get
            {
                return Convert.ToInt32(ddPArk.SelectedValue.ToString() == "" ? "0" : ddPArk.SelectedValue.ToString());
            }
            set
            {
                ClPark cl = new ClPark();
                cl.ParkID = value;
                System.Data.DataSet ds= new System.Data.DataSet();
                ds = ParkClass.GetList(cl);
                DataRow dr = ds.Tables[0].Rows[0];
                ddRegion.SelectedValue = dr["ParkDistrict"].ToString();
                BindPArk();
                ddPArk.SelectedValue = value.ToString();

            }
        }

        public int SelectedRegion
        {
            get {return Convert.ToInt32( ddRegion.SelectedValue); }
            set
            {
                ddRegion.SelectedValue = value.ToString();
                BindPArk();
            }
        }

        protected void ddRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindPArk();
        }

        protected void ddPArk_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CtlRegionPark.calll nc1 = new CtlRegionPark.calll();
           // CtlRegionPark.calll.
         //   pe( );
            if (pe != null)
            {
                pe();
            }
           // calll();
          
        }
    }
}