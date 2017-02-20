using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Taxi.rtl
{
    public partial class AdminPerson : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (lblPersonalID.Text != Request.QueryString["Pid"].ToString())
                {
                    lblPersonalID.Text = Request.QueryString["Pid"].ToString();
              string i=     CtlTopProfile1.setdata(Convert.ToInt32(lblPersonalID.Text));
              if (i != "2" && !Request.Url.AbsolutePath.ToLower().Contains("personactive"))
              {
                  TaxiBAL.Utility.ShowMsg(Page, TaxiBAL.ProPertyData.MsgType.warning, "آخرین وضعیت پرونده این فرد غیر فعال میباشد");
                  PesonContentPlaceHolder.Visible = false;

              }
                }
            }
            catch { }
            //String PesonID = "";
            //try { PesonID = Request.QueryString["Pid"].ToString(); }
            //catch { PesonID = ""; }

            //if (PesonID != Securenamespace.SecureData.CheckSecurity(PesonID) && PesonID != "")
            //    Response.Redirect("~/WarningInjection.aspx");

            //if ((PesonID == "0" || PesonID == null || PesonID == "") && (HttpContext.Current.Request.Url.AbsolutePath.ToLower() != "/personal/person.aspx"))
            //{
            //    ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), Guid.NewGuid().ToString(), "alert('خطا در دریافت کد پرسنلی فرد');", true);
            //    PesonContentPlaceHolder.Visible = false;
            //    return;
            //}
            //else
            //    PesonContentPlaceHolder.Visible = true;

        }
    }
}