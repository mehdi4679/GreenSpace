using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Net.Mail;
  
namespace CSharp
{

      
    public class PublicFunction
    {

       

        public static bool sendmail(string address, string subject, string body, string MyEmail, string MyPass)
        {
            bool result = true;
            System.Net.Mail.MailMessage mailMessage = new System.Net.Mail.MailMessage();
            //mailMessage.From = New System.Net.Mail.MailAddress("helli@hemail.ir")
            mailMessage.From = new System.Net.Mail.MailAddress("" + MyEmail + "@hemail.ir");
            mailMessage.To.Add(new System.Net.Mail.MailAddress(address));
            mailMessage.Priority = System.Net.Mail.MailPriority.High;
            mailMessage.IsBodyHtml = true;
            mailMessage.Subject = subject;
            mailMessage.Body = body;
            string smtpsetting = "hemail.ir";
            string smtpUsername = "" + MyEmail + "@hemail.ir";
            string smtpPassword = MyPass;
            System.Net.Mail.SmtpClient smtpClient = new System.Net.Mail.SmtpClient(smtpsetting);
            if (!string.IsNullOrEmpty(smtpUsername) & smtpPassword != "0")
            {
                smtpClient.Credentials = new System.Net.NetworkCredential(smtpUsername, smtpPassword);
            }
            try
            {
                smtpClient.Send(mailMessage);
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }

        public static void SendMail(string mailtext,string to){
            SmtpClient smtpClient = new SmtpClient("mail.MyWebsiteDomainName.com", 25);

            smtpClient.Credentials = new System.Net.NetworkCredential("info@MyWebsiteDomainName.com", "myIDPassword");
            smtpClient.UseDefaultCredentials = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = true;
            MailMessage mail = new MailMessage();

            //Setting From , To and CC
            mail.From = new MailAddress("info@MyWebsiteDomainName", "MyWeb Site");
            mail.To.Add(new MailAddress(to));
            mail.CC.Add(new MailAddress("MyEmailID@gmail.com"));

            smtpClient.Send(mail);
        }

        public static string  removeSpace(string s){
        return Regex.Replace(s.Trim(), @"\s+", "");
        }

        public static bool? STb(string s) {
            if(s=="-111")
                return null;
            if (s == "" || s == "0" || s==null    )
                return false;
            else
                return true;
        }

        public static string   EmpToNull(string  i){
            if (i == "")
                return null;
            else
                return i;
        }

        public static string  BTS(bool s) {
            if (s == true)
                return "1";
            else if (s == null)
                return null;
            else
                return "0";
        }

        public static bool  ModeInsert(string i){
            if (i == "0" || i == "" || i == null)
                return true;
            else
                return false;
        }
        
        public static string cnstr()
        {
            return ConfigurationManager.ConnectionStrings["GreenCnn"].ConnectionString;

            //; "Data Source=.;Initial Catalog=Taxi;Integrated Security=True";
        }

        public static bool sendmail(string address, string subject, string body)
        {
            bool result = true;
            System.Net.Mail.MailMessage mailMessage = new System.Net.Mail.MailMessage();
            mailMessage.From = new System.Net.Mail.MailAddress("makarem@makarem.ir");
            mailMessage.To.Add(new System.Net.Mail.MailAddress(address));
            mailMessage.Priority = System.Net.Mail.MailPriority.High;
            mailMessage.IsBodyHtml = true;
            mailMessage.Subject = subject;
            mailMessage.Body = body;
            string smtpsetting = "hemail.ir";
            string smtpUsername = "makarem@makarem.ir";
            string smtpPassword = "ali110";
            System.Net.Mail.SmtpClient smtpClient = new System.Net.Mail.SmtpClient(smtpsetting);
            if (!string.IsNullOrEmpty(smtpUsername) & smtpPassword != "0")
            {
                smtpClient.Credentials = new System.Net.NetworkCredential(smtpUsername, smtpPassword);
            }
            try
            {
                smtpClient.Send(mailMessage);
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }

        public static bool CheckMail(string email)
        {
            if (String.IsNullOrEmpty(email)) return false;
            var pos = email.IndexOf('@');
            if (pos == -1) return false;
            var pos2 = email.LastIndexOf('.');
            if (!(pos < pos2)) return false;
            return true;
        }
        public static bool CheckDigit(string str, int Minlenght = 0, int Maxlenght = 10)
        {
            if (str.Length < Minlenght) return false;
            if (Maxlenght < str.Length) return false;
            var key = 0;
            if (String.IsNullOrEmpty(str)) return false;
            for (int j = 0; j < str.Length; j++)
            {
                key = Convert.ToInt32(str[j]);
                if (!(48 <= key && key <= 57)) return false;
            }
            return true;
        }
        public static bool CheckScripts(string str, int Minlenght = 0, int Maxlenght = 10)
        {
            if (str.Length < Minlenght) return false;
            if (Maxlenght < str.Length) return false;
            int key = 0;
            for (int i = 0; i < str.Length; i++)
            {
                key = Convert.ToInt32(str[i]);
                if (!((97 <= key && key <= 125) || (1570 <= key) || (key == 32))) return false;
            }
            return true;
        }
        public static bool CheckUserAndPass(string str, int Minlenght = 6, int Maxlenght = 20)
        {
            if (str.Length < Minlenght) return false;
            if (Maxlenght < str.Length) return false;
            int key = 0;
            for (int i = 0; i < str.Length; i++)
            {
                key = Convert.ToInt32(str[i]);
                if (!((97 <= key && key <= 125) || (48 <= key && key <= 57) || (65 <= key && key <= 90))) return false;
            }
            return true;
        }
        public static bool CheckInjection(string str)
        {
            if (str.Contains("'"))
            {
                return false;
            }
            else if (str.ToLower().Contains("script"))
            {
                return false;
            }
            else if (str.ToLower().Contains("select"))
            {
                return false;
            }
            else if (str.ToLower().Contains("update"))
            {
                return false;
            }
            else if (str.ToLower().Contains("insert"))
            {
                return false;
            }
            else if (str.ToLower().Contains("into"))
            {
                return false;
            }
            else if (str.ToLower().Contains("delete"))
            {
                return false;
            }
            else if (str.ToLower().Contains("from"))
            {
                return false;
            }
            else if (str.ToLower().Contains("execute"))
            {
                return false;
            }
            else if (str.ToLower().Contains("print"))
            {
                return false;
            }
            else if (str.ToLower().Contains("union"))
            {
                return false;
            }
            else if (str.ToLower().Contains("join"))
            {
                return false;
            }
            return true;
        }
        public static string GetUserID() {
            if (HttpContext.Current.Session["UserID"] == null)
                return "0";
            else
                return HttpContext.Current.Session["UserID"].ToString();
        }
        public static string GetIPAddress()
        {
            var sIPAddress = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            if (String.IsNullOrEmpty(sIPAddress))
            {
                return System.Web.HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            }
            else
            {
                var ipArray = sIPAddress.Split(',');
                return ipArray[0];
            }
        }
        public static string GetBrowser()
        {
            var s = System.Web.HttpContext.Current.Request.Browser.Browser;
            return s;
        }
        public static string GetOS()
        {
            return System.Web.HttpContext.Current.Request.Browser.Platform;
        }
        public static string GetBrowserVersion()
        {
            var ret = System.Web.HttpContext.Current.Request.Browser.Version;
            return ret.ToString();
        }
        public static string GetURL() {
            return System.Web.HttpContext.Current.Request.Url.AbsolutePath ;
        }

        public static void ErrorLog(string ex) {
            SqlConnection cnn = new SqlConnection(cnstr());
            SqlCommand cmd = new SqlCommand("Prc_ErrorLOG",cnn);
            cmd.Parameters.Add(new SqlParameter("ex", SqlDbType.NVarChar)).Value = ex;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }



            public static int SendSMSs(string mobile,string msg){

                return 0;      
            
        }

            public static string secure(string p)
            {
                throw new NotImplementedException();
            }
    }
}
