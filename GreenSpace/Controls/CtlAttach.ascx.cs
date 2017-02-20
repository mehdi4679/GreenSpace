using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using TaxiCL;
using TaxiDAL;
using System.Web.UI.HtmlControls;

namespace GreenSpace.Controls
{
    public partial class CtlAttach : System.Web.UI.UserControl
    {
        public void BindDB()
        {
            DataSet ds = CatalogClass.GetListTypeID("55");
            ddtype.DataSource = ds;
            ddtype.DataTextField = "CatalogName";
            ddtype.DataValueField = "CatalogValue";
            ddtype.DataBind();
            ddtype.Items.Insert(0, new ListItem("انتخاب نمایید", "-111"));

        }
        public string ID
        {
            get { return lblID.Text; }
            set { lblID.Text = value; }
        }
        private string CheckFile(HttpPostedFile a)
        {

            string[] acceptedFileTypes = new string[5];
            acceptedFileTypes[0] = ".jpg";
            //acceptedFileTypes[1] = ".png";
            //acceptedFileTypes[2] = ".gif";
            //acceptedFileTypes[3] = ".bmp";
            acceptedFileTypes[3] = ".tif";
            acceptedFileTypes[4] = ".jpeg";

            bool c = false;
            for (int i = 0; i <= 4; i++)
            {
                if (Path.GetExtension(a.FileName) == acceptedFileTypes[i])
                    c = true;
            }

            string alarm = "";
            if (a.ContentLength > 500 * 1024)
                alarm = "عکس " + a.FileName + "باید از 500 کیلو بایت کمتر باشد" + System.Environment.NewLine;
            else if (!c)
                alarm = "عکس " + a.FileName + "باید نوع معتبر  jpg داشته باشد" + System.Environment.NewLine;

            return alarm;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (ID == null || ID == "" || ID=="-111")
            {
                CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "ابتدا درخت را ثبت نمایید");
                return;
            }
            string tempPath = System.Configuration.ConfigurationManager.AppSettings["FolderPath"];
            string savepath = Server.MapPath(tempPath);

            HttpFileCollection hfc = Request.Files;

            //if (lblmsg.Text != "")
            //    return;

            try
            {
                string alarm = "";


                if (hfc.Count == 0)
                { lblmsg.Text = "حداقل یک فایل را انتخاب نمایید."; return; }
                //if (Convert.ToInt32(ddtype.SelectedValue) == -111)
                //{ lblmsg.Text = "نوع مدرک را مشخص نمایید"; return; }
                for (int tt = 0; tt < hfc.Count; tt++)
                {
                    HttpPostedFile uploadedFile = hfc[tt];
                    alarm = CheckFile(uploadedFile);
                    if (alarm != "")
                    { lblmsg.Text += alarm; return; }
                    else
                    {
                        listofuploadedfiles.Text += String.Format("{0}<br />", uploadedFile.FileName);
                        ClAttach cl = new ClAttach();
                        cl.AttachName = uploadedFile.FileName;
                        // cl.Mellicode = Path.GetFileNameWithoutExtension(uploadedFile.FileName);

                        cl.ForTable = ForTable;
                        cl.ForID = Convert.ToInt32(ID);
                        cl.ForCatalogType = 55;
                        cl.ForCatalogValue = Convert.ToInt32(ddtype.SelectedValue);
                        //cl.PazireshID = pazireshID;
                        int i = 0;
                        i = AttachClass.insert(cl);
                        if (i == 0)
                            lblmsg.Text += "در درج عکس " + uploadedFile.FileName + " خظا رخ داده است " + " <br />";
                        else
                            uploadedFile.SaveAs(System.IO.Path.Combine(savepath, i + Path.GetExtension(uploadedFile.FileName)));
                    }

                }
                //    BindGrid();
            }




            catch (Exception ex)
            {

                lblmsg.Text +=ex.ToString()+ "Error: در درج عکس  خطا رخ داده است ";

            }
            BindGrid();

        }

        public int pazireshID
        {
            get { return Convert.ToInt32(lblPazireshID.Text); }
            set { lblPazireshID.Text = value.ToString(); }
        }
         public void DeleteItem(object sender, EventArgs e)
        {
            String idd = ((HtmlAnchor)sender).HRef.ToString();
            int i = AttachClass.Delete(idd);
            if (i == 0)
                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), Guid.NewGuid().ToString(), "alert('خطا در حذف');", true);
            else
                BindGrid();

        }
        public string ForTable
        {
            get { return lblForTable.Text; }
            set { lblForTable.Text = value; }
        }


        public void BindGrid()
        {

            
            ClAttach cl = new ClAttach();
            cl.ForTable = lblForTable.Text;
            cl.ForID = Convert.ToInt32(ID);
 
            Grid.DataSource = AttachClass.GetList(cl);
            Grid.DataBind();
        }


        public string EnableOneSelectedVale
        {
            set { ddtype.SelectedValue = value; ddtype.Enabled = false; }
        }

        

    }
}