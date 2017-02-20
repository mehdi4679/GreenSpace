using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using GreenSpaceCL;
using GreenSpaceDAL;
using GreenSpaceBLL;
using System.Web.UI.HtmlControls;
using System.Web.Security;
using System.Security.Principal;
using GreenSpaceBLL;
using CSharp;

namespace GreenSpace.CityZen
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnSave_Click(object sender, EventArgs e)
        {
            ClPersonal cl = new ClPersonal();
            cl.PassCurrent = FormsAuthentication.HashPasswordForStoringInConfigFile(txtpasscurrent.Text + "~!@", "MD5");
            cl.Pass = FormsAuthentication.HashPasswordForStoringInConfigFile(txtpass.Text + "~!@", "MD5");
            cl.PersonalID = Convert.ToInt32(Session["PersonalID"].ToString());
            int t = 0;            
            t = PersonalClass2.UpdatePass(cl);

            if (t == -1)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('کلمه عبور فعلی شما اشتباه می باشد')", true);
            }
            else if (t == 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('متاسفانه خطایی در سیستتم رخ داده است. لطفا مجددا تلاش نمایید.')", true);
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('عملیات با موفقیت انجام شد')", true);
                //Response.Redirect("~/CityZen/PersonalView.aspx");
            }

        }
    }
}