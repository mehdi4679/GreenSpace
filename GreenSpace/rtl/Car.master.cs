using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Taxi.rtl
{
    public partial class Car : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            String CarID = "";
            try {  CarID = Request.QueryString["CarID"].ToString(); }
            catch { CarID = ""; }
            ChekQueryString(CarID);
            if ((CarID == "0" || CarID == null || CarID == "") )
            {
            ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), Guid.NewGuid().ToString(), "alert('خطا در دریافت شماره خودرو');", true);
            CarContent.Visible = false;
            return;
            }
            else
            CarContent.Visible = true;
           


            if (!Page.IsPostBack)
            {
                if (lblcarid.Text != CarID.ToString())
                    if (Ctlcartop1.setdata(CarID) == "3" && !Request.Url.AbsolutePath.ToLower().Contains("caract"))
                    {
                        TaxiBAL.Utility.ShowMsg(Page, TaxiBAL.ProPertyData.MsgType.warning, "خودرو راکد است و کلیه عملیات روی خودرو غیر فعال میباشد");
                        CarContent.Visible = false;
                    }
                    else
                        CarContent.Visible = true;
            }
            lblcarid.Text = CarID;
        }
        private void ChekQueryString(string  CarID) {

            
                  if (CarID != Securenamespace.SecureData.CheckSecurity(CarID) && CarID != "" )
                Response.Redirect("~/WarningInjection.aspx");

             
        }

    }
}