using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using GreenSpaceCL;
using GreenSpaceDAL;
using GreenSpaceBLL;
using TaxiDAL;
using System.Data;

namespace GreenSpace.CityZen
{
    public partial class DashBoard1 : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Page.Theme = "Theme3";
        }
        void setPermission()
        {
            try
            {
                if (Session["roleid"].ToString() == "1" || Request.QueryString["Mode"].ToString() == "4") { }

                else if (Session["roleid"].ToString() != Request.QueryString["Mode"].ToString())
                {
                    //Response.Write(Request.QueryString["Mode"].ToString());
                    Response.Redirect("AccessDenied.aspx");
                }
            }
            catch
            {
                Response.Redirect("AccessDenied.aspx");
            }
        }
        void BindDDL()
        {

            ddlErja.DataSource = UserRoleSpace.UserRoleClass.Select("8,4,10,14,15,16,17,18", Session["Region"].ToString());
            ddlErja.DataTextField = "fullname";
            ddlErja.DataValueField = "val";
            ddlErja.DataBind();
        }
        void BindGrid()
        {
            try
            {
                string mode = null;
                if (Request.QueryString["Mode"].ToString() == "1") mode = "8";
                else if (Request.QueryString["Mode"].ToString() == "2") mode = "4";
                else if (Request.QueryString["Mode"].ToString() == "3") mode = "10";
                //DataSet ds = CuttingTreeClass.GetList(null, null, null, null, null, null, null, null, null, null, null, null,
                //    null, null, null, null, null, null, mode, null);
                DataSet ds = new DataSet();
                if (Request.QueryString["Mode"].ToString() == "4")
                {
                    //mode = null;
                    //ds = kartable.Select(null, Session["UserID"].ToString(), mode);
                    string s = Session["semat"].ToString();
                    string uid = Session["UserID"].ToString();
                    if (s == "8")
                    {
                        uid = null;
                    }
                    ds = kartable.SelectAll(uid);
                }
                else
                {

                    ds = kartable.Select(null, Session["UserID"].ToString(), mode);
                }
                gvTree.DataSource = ds;
                gvTree.DataBind();
            }
            catch (Exception e)
            {
                //Response.Redirect("~/Loginmain.aspx");
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                setPermission();
                BindDDL();
                BindGrid();
            }
        }
        protected void GV_ok(object sender, EventArgs e)
        {
            HtmlAnchor temp = (HtmlAnchor)sender;
            string kartableid = temp.Attributes["kartableid"].ToString();
            string cuttingID = temp.Attributes["cuttingID"].ToString();

            //tbl_Student_Lang.Update(Value, null, null, null, Kernel.PersonID(), 1, Kernel.UserID());
            try
            {
                CuttingTreeClass.Update(cuttingID, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, "1");
                kartable.update(kartableid, null, null, null, null, null, null, null, "1", null);
            }
            catch { }
            BindGrid();

        }
        protected void GV_cancel(object sender, EventArgs e)
        {
            //Button L = (Button)sender;
            //string Value = L.CommandArgument;
            HtmlAnchor temp = (HtmlAnchor)sender;
            string kartableid = temp.Attributes["kartableid"].ToString();
            string cuttingID = temp.Attributes["cuttingID"].ToString();

            try
            {
                CuttingTreeClass.Update(cuttingID, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, "0");
                kartable.update(kartableid, null, null, null, null, null, null, null, "0", null);

               // kartable.Insert(null, Session["roleid"].ToString(), DateTime.Now, Session["UserID"].ToString(), Session["roleid"].ToString(), Session["UserID"].ToString(), txtDesc.Text, "0", ID);
            }
            catch { }
            BindGrid();
        }

        protected void btnErja_Click(object sender, EventArgs e)
        {
            string v = ddlErja.SelectedValue;
            string userid = v.Split(',')[0];
            string roleid = v.Split(',')[1];
            string status = "";
            //if (roleid == "2") status = "9064";
            //else if (roleid == "3") status = "9065";
            //else if (roleid == "1") status = "9063";
            try
            {
                kartable.Insert(null, roleid, DateTime.Now, userid, Session["roleid"].ToString(), Session["UserID"].ToString(), txtDesc.Text, null, txtid.Text);
                CuttingTreeClass.Update(txtid.Text, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, txtDesc.Text, roleid, "3");
            }
            catch { }
            BindGrid();
        }

        protected void AErja_ServerClick(object sender, EventArgs e)
        {
            HtmlAnchor temp = (HtmlAnchor)sender;
            txtid.Text = temp.Attributes["GridID"].ToString();
        }
        protected void viewpic(object sender, EventArgs e)
        {
            HtmlAnchor temp = (HtmlAnchor)sender;
            string ID = temp.Attributes["GridID"].ToString();
            CtlAttach.ID = ID;
            CtlAttach.BindGrid();
           // ViewPicModal.CssClass = "modal fade in";
           // ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
            LightBox.Value = "1";
        }

        protected void viewMap(object sender, EventArgs e)
        {
            HtmlAnchor temp = (HtmlAnchor)sender;
            string ID = temp.Attributes["GridID"].ToString();
            Response.Redirect("/CityZen/MapRegTree.aspx?readonly=ok&id="+ID);
        }
        protected void History_ServerClick(object sender, EventArgs e)
        {

            HtmlAnchor temp = (HtmlAnchor)sender;
            string ID = temp.Attributes["GridID"].ToString();
            DataSet ds = kartable.SelectHistory(ID, Session["UserID"].ToString());
            //gvHistory.DataSource = ds;
            //gvHistory.DataBind();
           try
            {
                gvHistory1.DataSource = ds;
                gvHistory1.DataBind();
                 this.LiBo.Text = "b";
            }
            catch
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('ارسال اولیه از طرف شهروند')", true);
            }
           
        }


    }
}