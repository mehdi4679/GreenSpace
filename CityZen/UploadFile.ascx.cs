using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace GreenSpace.CityZen
{
    public partial class UploadFile : System.Web.UI.UserControl
    {
        public string FilePath { get; set; }
        public string FileType { get; set; }
        public int FileSize { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string Upload()
        {
            Label1.Text = "";
            string filename = "";

            string pathh = Server.MapPath("~").ToString();
            if (FilePath == "")
            {
                FilePath = @"Upload\";
            }

            pathh = Server.MapPath("~\\").ToString() + FilePath + filename;

            if (string.IsNullOrEmpty(FileType))
                FileType = "/";
            if (FileUpload1.PostedFile.ContentLength > FileSize & FileSize != 0 & FileUpload1.HasFile)
            {
                Label1.Text = string.Format("حجم فایل بیش از حد مجار میباشد ");
                filename = "-1";
            }

            else if ((!System.IO.Path.GetExtension(FileUpload1.FileName).ToLower().Contains(FileType)) & (FileType != "/") & (FileUpload1.HasFile))
            {
                Label1.Text = string.Format("نوع فایل باید {0} باشد", FileType);
                filename = "-1";
            }
            else if (FileUpload1.HasFile)
            {
                filename = Rename(FileUpload1.FileName.ToString());
                FileUpload1.SaveAs(Server.MapPath("~\\").ToString() + FilePath + filename);
            }
            return filename;
        }
        string Rename(string filename)
        {
            //Rename & Exist
            string filetype = "";
            string[] TestArray = filename.Split('.');
            foreach (string word in TestArray)
            {
                filetype = word;
            }
            Random random = new Random();

            Start:
            string HashedFilename = FormsAuthentication.HashPasswordForStoringInConfigFile(filename + random.Next(10, 100000).ToString(), "MD5");

            if (File.Exists(Server.MapPath(FilePath).ToString() + HashedFilename + "." + filetype))
            {
                goto Start;
            }
            return HashedFilename + "." + filetype;
        }
        public bool hasFile()
        {
            if (FileUpload1.HasFile)
                return true;
            else
                return false;
        }
    }
}