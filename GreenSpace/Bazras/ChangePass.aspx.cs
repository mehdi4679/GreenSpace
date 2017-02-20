using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Security;
using GreenSpaceBLL;

namespace GreenSpace.Bazras
{
    public partial class ChangePass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPass_Click(object sender, EventArgs e)
        {
            if (txtlightPass.Text.Length < 4)
            {
                CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "کلمه عبور جدید باید از 4 کاراکتر بیشتر باشد");
                return;
            }
           // var hash = FormsAuthentication.HashPasswordForStoringInConfigFile(txtCurrentPAss.Text + "~!@", "MD5");            
            DataSet ds = TaxiDAL.UsersClass.GetList(CSharp.PublicFunction.GetUserID().ToString(), null, null, null, null, null, null, null, null, null, null);
            if (ds.Tables[0].Rows.Count != 0)
            {
                if(txtlightPass.Text!=txtLightRePass.Text)
                {
                    CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "نام کاربری و کلمه عبور باید یکسان باشد");
                    return;
                }
                else
                {
                        var hashNew = FormsAuthentication.HashPasswordForStoringInConfigFile(txtlightPass.Text + "~!@", "MD5");
                        int i = TaxiDAL.UsersClass.Update(ds.Tables[0].Rows[0]["UserID"].ToString(), null, hashNew, null, null, null, null, null, null, null, null);
                        if (i == 0)
                            CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "خطا در بروز رسانی کلمه عبور");
                        else
                            CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.accept, "کلمه عبور با موفقیت بروز رسانی شد");
                }
            }
            else
                CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "کلمه عبور فعلی اشتباه است");
        }
    }
}