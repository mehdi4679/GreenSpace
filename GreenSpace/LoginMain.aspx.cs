using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data;
using System.Security.Principal;

namespace Taxi
{
    public partial class LoginMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["UserID"] != null && Session["UserID"] != "0" && Session["UserID"] != "" && !Page.IsPostBack && Session["role"].ToString() == "admin")
                    Response.Redirect("Dashboard.aspx");
                if (Session["UserID"] != null && Session["UserID"] != "0" && Session["UserID"] != "" && !Page.IsPostBack && Session["role"].ToString() == "bazras")
                    Response.Redirect("~/Bazras/AllPeyman.aspx");
            }
            catch { }

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //  Response.Redirect("Index.aspx");

            var hash = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPass.Value + "~!@", "MD5");
            DataSet ds = TaxiDAL.UsersClass.GetList(null, txtUserName.Value, hash, null, null, null, null, null, null, null, null, null);


            if (ds.Tables[0].Rows.Count != 0)
            {
                //
                //  DError.Visible = true; 
                DataRow dr = ds.Tables[0].Rows[0];
                Session["UserID"] = dr["userID"].ToString();
                Session["FullNameUser"] = dr["FullNameUser"].ToString();
                Session["Region"] = dr["Region"].ToString();
                String userid = dr["UserID"].ToString();
                Session["semat"] = dr["semat"].ToString();
                string role;

                if (dr["semat"].ToString() == "7" || dr["semat"].ToString() == "3")
                {
                    Session["role"] = "admin";
                    role = "admin";
                }
                else if (dr["semat"].ToString() == "8" || dr["semat"].ToString() == "9" || dr["semat"].ToString() == "10" || 
                    dr["semat"].ToString() == "14" || dr["semat"].ToString() == "15" ||  
                    dr["semat"].ToString() == "17" || dr["semat"].ToString() == "18")
                {
                    Session["role"] = "cityzenrol";
                    role = "cityzenrol";
                    Session["roleid"] = "1";
                }
                else if (dr["semat"].ToString() == "2" || dr["semat"].ToString() == "6" || dr["semat"].ToString() == "1" 
                    || dr["semat"].ToString() == "13" || dr["semat"].ToString() == "4"|| 
                     dr["semat"].ToString() == "16" || dr["semat"].ToString() == "19" 
                    )
                {
                    Session["sematID"] = dr["semat"].ToString();
                    Session["role"] = "bazras";
                    role = "bazras";
                }
                else
                {
                    CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "کاربر گرامی شما برای ورود به سیستم دسترسی ندارید");
                    return;

                }
                if (dr["semat"].ToString() == "8")// نقش مدیر فضای سبز
                {
                    Session["roleid"] = "1";
                }
                else if (dr["semat"].ToString() == "9" || dr["semat"].ToString() == "4") //نقش مسئول فضای سبز
                {
                    Session["roleid"] = "2";
                }
                else if (dr["semat"].ToString() == "10")// نقش کارشناس فضای سبز
                {
                    Session["roleid"] = "3";
                }
                Session["roleid"] = "3";


                HttpContext.Current.User = new GenericPrincipal(User.Identity, new string[] { role });
                FormsAuthentication.Initialize();
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, userid, DateTime.Now, DateTime.Now.AddMinutes(540), false, role, FormsAuthentication.FormsCookiePath);
                hash = FormsAuthentication.Encrypt(ticket);
                HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, hash);
                if (ticket.IsPersistent == true)
                    cookie.Expires = ticket.Expiration;

                Response.Cookies.Add(cookie);
                // Roles.AddUserToRole(userid, role);

                // Roles.AddUserToRole(dr["UserName"].ToString(),"admin");

                if (role == "admin")
                    Response.Redirect("Dashboard.aspx");
                else if (
                    dr["semat"].ToString() == "8" || dr["semat"].ToString() == "9" || dr["semat"].ToString() == "10" || 
                    dr["semat"].ToString() == "14" || dr["semat"].ToString() == "15" ||  
                    dr["semat"].ToString() == "17" || dr["semat"].ToString() == "18" )
                {

                    Response.Redirect("~/CityZen/Dashboard.aspx?Mode=" + Session["roleid"], false);
                }
                else
                    Response.Redirect("~/Bazras/AllPeyman.aspx");

            }
            else

            {
                lblUserPassError.Text = "نام کاربری یا کلمه عبور اشتباه میباشد";
                //CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "نام کاربری یا کلمه عبور اشتباه میباشد");
                return;
             }

        }

        protected void btnSendEmail_Click(object sender, EventArgs e)
        {

        }
    }
}