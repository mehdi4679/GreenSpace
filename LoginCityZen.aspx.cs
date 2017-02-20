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

namespace GreenSpace
{
    public partial class LoginCityZen : System.Web.UI.Page
    {
        //public ClPersonal Data
        //{
        //    get
        //    {
        //        ClPersonal cl = new ClPersonal();
        //        cl.FirstName = TXTFirstName.Text;
        //        cl.LastName = TXTLastName.Text;
        //        cl.Email = TXTEmail.Text;
        //        cl.PersonalTel = TXTPersonalTel.Text;
        //        cl.PersonalMobile = TXTPersonalMobile.Text;
        //        cl.PostiCode = TXTPostiCode.Text;
        //        cl.NationalCode = TXTNationalCode.Text;
        //        cl.PersonalAdress = TXTPersonalAdress.Text;
        //        cl.JobName = TXTJobName.Text;
        //        cl.PersonalID = Convert.ToInt32(lblPersonalID.Text);
        //        return cl;
        //    }
        //    set
        //    {
        //        DataSet ds = PersonalClass2.GetList(value);
        //        DataRow dr = ds.Tables[0].Rows[0];
        //        TXTFirstName.Text = dr["FirstName"].ToString();
        //        TXTLastName.Text = dr["LastName"].ToString();
        //        TXTEmail.Text = dr["Email"].ToString();
        //        TXTNationalCode.Text = dr["NationalCode"].ToString();
        //        TXTPersonalMobile.Text = dr["PersonalMobile"].ToString();
        //        TXTPersonalTel.Text = dr["PersonalTel"].ToString();
        //        TXTPostiCode.Text = dr["PostiCode"].ToString();
        //        TXTPersonalAdress.Text = dr["PersonalAdress"].ToString();
        //        TXTJobName.Text = dr["JobName"].ToString();
        //        lblPersonalID.Text = dr["PersonalID"].ToString();
        //        ds.Dispose();
        //    }
        //}
        protected void Page_Load(object sender, EventArgs e)
        {            
            if (Session["PersonalID"] != null && Session["PersonalID"] != "0" && Session["PersonalID"] != "" && !Page.IsPostBack)
                Response.Redirect("/Public/PersonalView.aspx");

        }

        //protected void btnLogin_Click(object sender, EventArgs e)
        //{

        //    var hash = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPass.Value + "~!@", "MD5");
        //    ClPersonal cl = new ClPersonal();
        //    cl.NationalCode = Securenamespace.SecureData.CheckSecurity(txtUserName.Value);
        //    cl.Pass = Securenamespace.SecureData.CheckSecurity(hash);

        //    DataSet ds = PersonalClass2.GetList(cl);
        //    if (ds.Tables[0].Rows.Count != 0)
        //    {
        //        DataRow dr = ds.Tables[0].Rows[0];
        //        Session["PersonalID"] = dr["PersonalID"].ToString();

        //        String userid = dr["PersonalID"].ToString();
        //        string role = "public";
        //        if (dr["Manage"].ToString() == "1")
        //            role += ",Manage";

        //        HttpContext.Current.User = new GenericPrincipal(User.Identity, new string[] { role });
        //        FormsAuthentication.Initialize();
        //        FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, userid, DateTime.Now, DateTime.Now.AddMinutes(540), false, role, FormsAuthentication.FormsCookiePath);
        //        hash = FormsAuthentication.Encrypt(ticket);
        //        HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, hash);
        //        if (ticket.IsPersistent == true)
        //            cookie.Expires = ticket.Expiration;

        //        Response.Cookies.Add(cookie);
        //        if (dr["Manage"].ToString() == "1")
        //            Session["IsManage"] = "true";
        //        Response.Redirect("/Public/PersonalView.aspx");
        //        ds.Dispose();

        //    }
        //    else
        //    {
        //        Utility.ShowMsg(Page, ProPertyData.MsgType.warning, "نام کاربری یا کلمه عبور اشتباه میباشد");

        //    }

        //}

        //protected void BtnInsert_Click(object sender, EventArgs e)
        //{
        //    ClPersonal cl = new ClPersonal();
        //    cl = Data;
        //    int t = 0;
        //    var hash = FormsAuthentication.HashPasswordForStoringInConfigFile(txtpass1.Text + "~!@", "MD5");
        //    cl.Pass = hash;
        //    t = PersonalClass2.insert(cl);

        //    if (t > 0)
        //    {
        //        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('ثبت نام با موفقیت انجام شد')", true);
        //        //Response.Redirect("~/CityZen/PersonalView.aspx");
        //    }

        //}
        //protected void btnSendEmail_Click(object sender, EventArgs e)
        //{
        //    if (txtmobile.Value.ToString() == "")
        //        return;
        //    ClPersonal cl = new ClPersonal();

        //    cl.PersonalMobile = txtmobile.Value;
        //    DataSet ds = PersonalClass2.GetList(cl);

        //    if (ds.Tables[0].Rows.Count > 0)
        //    {
        //        DataRow dr = ds.Tables[0].Rows[0];
        //        string NewPass = Utility.RandomDigit(5);
        //        var hash = FormsAuthentication.HashPasswordForStoringInConfigFile(NewPass + "~!@", "MD5");
        //        cl.Pass = hash;
        //        int t = PersonalClass2.UpdatePass(cl);
        //        if (t == 0)
        //        {
        //            Utility.ShowMsg(Page, ProPertyData.MsgType.General_Success, "خطا در تغییر کلمه عبور!!");
        //            return;
        //        }
        //        string MsgMobile = "  گذر واژه شما به " + Environment.NewLine + NewPass + Environment.NewLine + "  تغییر پیدا کرد ";
        //        if (PublicFunction.SendSMSs(txtmobile.Value, MsgMobile) == 1)
        //        Utility.ShowMsg(Page, ProPertyData.MsgType.General_Success, "کلمه عبور شما ارسال شد لطفا دقایقی منتظر باشید.");
        //        else
        //         Utility.ShowMsg(Page, ProPertyData.MsgType.General_Success, "در ارسال پیامک مشکل ایجاد شده است.");



        //    }
        //    else {
        //        //Response.Redirect("/Public/RegPerson.aspx");
        //        Utility.ShowMsg(Page, ProPertyData.MsgType.warning, "شماره همراه در سیستم موجود نمیباشد لطفا ابتدا اقدام به ثبت نام نمایید");

        //    }

        //}
    }
}