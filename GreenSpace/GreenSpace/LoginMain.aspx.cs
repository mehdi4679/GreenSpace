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
           
            if (Session["UserID"] != null && Session["UserID"] != "0" && Session["UserID"] != "" && !Page.IsPostBack)
                Response.Redirect("Dashboard.aspx");

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
           //  Response.Redirect("Index.aspx");
               
            var hash = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPass.Value + "~!@", "MD5");
            DataSet ds = TaxiDAL.UsersClass.GetList(null, txtUserName.Value, hash, null, null, null, null, null, null, null, null, null);

                  
            if (ds.Tables[0].Rows.Count != 0)
            {
                //
                DError.Visible = true; 
                DataRow dr = ds.Tables[0].Rows[0];
                Session["UserID"] = dr["userID"].ToString();
                
              String    userid    = dr["UserID"].ToString();
                string role="admin";
                if (dr["semat"].ToString() == "7" || dr["semat"].ToString() == "3")
                    Session["role"] = "admin";
                 else
                {
                    CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "کاربر گرامی شما برای ورود به سیستم دسترسی ندارید");
                    return;
                }

                Session["semat"]=dr["semat"].ToString();


                HttpContext.Current.User = new GenericPrincipal(User.Identity,new string[]{ role});
  FormsAuthentication.Initialize();
           FormsAuthenticationTicket   ticket    = new  FormsAuthenticationTicket(1, userid, DateTime.Now, DateTime.Now.AddMinutes(540), false, role, FormsAuthentication.FormsCookiePath);
            hash       = FormsAuthentication.Encrypt(ticket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, hash);
            if( ticket.IsPersistent == true)  
                cookie.Expires = ticket.Expiration;

            Response.Cookies.Add(cookie);
               // Roles.AddUserToRole(userid, role);

              // Roles.AddUserToRole(dr["UserName"].ToString(),"admin");
              
                Response.Redirect("Dashboard.aspx");


            }
            else
            {
                DError.Visible = true;
                //LblError.Text = "نام کاربری یا کلمه عبور اشتباه میباشد";
            }
   
        }

        protected void btnSendEmail_Click(object sender, EventArgs e)
        {

        }
    }
}