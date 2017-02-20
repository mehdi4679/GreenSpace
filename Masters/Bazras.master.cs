using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using GreenSpaceDAL;
using GreenSpaceCL;
using System.Data;


namespace GreenSpace.Masters
{
    public partial class Bazras : System.Web.UI.MasterPage
    {
          protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //if (Session["sherkat"] != "true")
                //LiPaziresh.Visible = false;
                //System.Uri r = Request.UrlReferrer;
                lblPersonalName.Text = Session["FullNameUser"].ToString();


                BindProtest();
                if (Session["AgreeID"] != null) {
                            if (Session["sematID"].ToString() == "2" && Apriceee != null && !Request.Url.AbsolutePath.ToLower().Contains("allpeyman"))
                    Apriceee.Visible = true;
                    //LiItem.Visible = true;
                    //Lidarsad.Visible = true;
                  //  LiEnterPercent.Visible = true;
                }

                if (Session["AgreeID"] != null)
                    if (Session["sematID"].ToString() == "6" && LiItem != null && !Request.Url.AbsolutePath.ToLower().Contains("allpeyman"))//only nazer moghim
                    LiItem.Visible = true;
                
                if (Session["AgreeID"] != null)
                    if ((Session["sematID"].ToString() == "6" || Session["sematID"].ToString() == "2") && LiKhesarat != null && !Request.Url.AbsolutePath.ToLower().Contains("allpeyman"))//nazer ali and moghim
                    { LiKhesarat.Visible = true; }

                if (Session["AgreeID"] != null)
                {
                    LiItem.Visible = true;
                    Lidarsad.Visible = true;
                 //   LiEnterPercent.Visible = true;
                    LiKhesarat.Visible = true;

                }
                if(Request.Url.AbsolutePath.ToLower().Contains("allpeyman"))
                {
                    Lidarsad.Visible = false;
                    LiItem.Visible = false;
                }
                    
             }
            try
            {
              //  if (System.Web.HttpContext.Current.Request.Url.AbsolutePath.ToLower().Contains("agreepercent"))
                    lblpageName.Text = Request.QueryString["pname"].ToString() + " :" + Session["Agreename"].ToString();
               // else
                 //   lblpageName.Text = "";
            }
            catch { }
        }

        

        protected void aexit_ServerClick(object sender, EventArgs e)
        {
            System.Web.Security.FormsAuthentication.SignOut();
            Session.Clear();

            Response.Redirect("/Loginmain.aspx");
        }
        protected void exit_ServerClick(object sender, EventArgs e)
        {
            System.Web.Security.FormsAuthentication.SignOut();
            Session.Clear();

            Response.Redirect("/LoginMain.aspx");
        }

        private void BindProtest()
        {
            ClAgreePercentProtest cl=new ClAgreePercentProtest();
            cl.UserResponseID=Convert.ToInt32(Session["UserID"].ToString());
           // cl.PeymnaKArID=Convert.ToInt32(Session["UserID"].ToString());
            DataSet ds = AgreePercentProtestClass.GetListNav(cl);
            lblAllProtest.Text = ds.Tables[0].Rows.Count.ToString();
            lblAllProtest2.Text = ds.Tables[0].Rows.Count.ToString();

            dl1.DataSource = ds;
            dl1.DataBind();
            ds.Dispose();
           
        }



    }
}