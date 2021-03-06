﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using GreenSpaceCL;
using GreenSpaceDAL;

namespace GreenSpace
{
    public class Global : System.Web.HttpApplication
    {



        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        
        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            if (HttpContext.Current.User != null)
                if (HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    FormsIdentity id = ((FormsIdentity)(HttpContext.Current.User.Identity));
                    FormsAuthenticationTicket ticket = id.Ticket;
                    String userData = ticket.UserData;
                    String[] roles = userData.Split(',');
                    HttpContext.Current.User = new GenericPrincipal(id, roles);
                }
        }


        protected void Application_Error(object sender, EventArgs e)
        {
            HttpException lastErrorWrapper = Server.GetLastError() as HttpException;

            Exception lastError = lastErrorWrapper;
            if (lastErrorWrapper.InnerException != null)
                lastError = lastErrorWrapper.InnerException;

            string lastErrorTypeName = lastError.GetType().ToString();
            string lastErrorMessage = lastError.Message;
            string lastErrorStackTrace = lastError.StackTrace;
            string page = HttpContext.Current.Request.Url.OriginalString;

            clError cl = new clError();
            cl.ErrorLog = lastErrorMessage+":Type:"+lastErrorTypeName+":ST:"+ lastErrorStackTrace;
            cl.Page = page;
            cl.IP = CSharp.PublicFunction.GetIPAddress();
             //string sql = "    insert into Tbl_ErrorLog(ErrorLog,createDate)values(N'" + "pagr:" + page + Securenamespace.SecureData.CheckSecurity(lastErrorMessage.ToString() + "IP" + CSharp.PublicFunction.GetIPAddress().ToString()) + "',getdate())";
            //System.Data.SqlClient.SqlConnection cnn = new System.Data.SqlClient.SqlConnection(CSharp.PublicFunction.cnstr());
            //System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sql, cnn);
            //cmd.CommandType = System.Data.CommandType.Text;

            try
            {
            int i = ErrorDAL.insert(cl);
                //cnn.Open();
                //cmd.ExecuteNonQuery();
            }
            catch { }
            finally {  }
            ////   Response.Redirect("~/ErrorPage.aspx");

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }

	
	
}