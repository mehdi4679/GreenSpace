using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Web;
namespace GreenSpace
{
    public class CustomReportServerConnection2  
    {
        public WindowsIdentity ImpersonationUser
        {
            get
            {
                // Use the default Windows user.  Credentials will be
                // provided by the NetworkCredentials property.
                return null;
            }
        }
        public ICredentials NetworkCredentials
        {
            get
            {
                // Read the user information from the web.config file.  
                // By reading the information on demand instead of 
                // storing it, the credentials will not be stored in 
                // session, reducing the vulnerable surface area to the
                // web.config file, which can be secured with an ACL.

                // User name
                string userName = ConfigurationManager.AppSettings["ReportUser"].ToString();

                if (string.IsNullOrEmpty(userName))
                    throw new Exception("USerName report is missing!!Maarefi");

                // Password
                string password = ConfigurationManager.AppSettings["reportPassword"].ToString();

                if (string.IsNullOrEmpty(password))
                    throw new Exception("PassWord Is Missing!!");

                // Domain
                string domain = ConfigurationManager.AppSettings["myDomain"].ToString();

                if (string.IsNullOrEmpty(domain))
                    throw new Exception("domain is missing!!");

                return new NetworkCredential(userName, password, domain);
            }
        }
        public bool GetFormsCredentials(out Cookie authCookie, out string userName, out string password, out string authority)
        {
            authCookie = null;
            userName = null;
            password = null;
            authority = null;
            // Not using form credentials
            return false;
        }
        public Uri ReportServerUrl
        {
            get
            {
                string url = ConfigurationManager.AppSettings["ReportServerUrl"].ToString();

                if (string.IsNullOrEmpty(url))
                    throw new Exception("URL is Missing!!!");

                return new Uri(url);
            }
        }
        public int Timeout
        {
            get
            {
                return int.Parse(ConfigurationManager.AppSettings["ReportServerTimeOut"].ToString());
                // return 60000; // 60 seconds
            }
        }
        public IEnumerable<Cookie> Cookies
        {
            get
            {
                // No custom cookies
                return null;
            }
        }
        public IEnumerable<string> Headers
        {
            get
            {
                // No custom headers
                return null;
            }
        }
    }

    public class Class1
    {
    }
    
}