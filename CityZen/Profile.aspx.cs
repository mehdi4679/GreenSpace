using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GreenSpaceCL;
using GreenSpaceDAL;
using GreenSpaceBLL;
using TaxiDAL;
using System.Data;

namespace GreenSpace.CityZen
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Page.Theme = "Theme3";
        }

        void BindData()
        {
            TaxiCL.ClAttach cl = new TaxiCL.ClAttach();
            cl.ForID = Int32.Parse(Session["UserID"].ToString());
            DataSet ds1 = TaxiDAL.AttachClass.GetList(cl);
            if (ds1.Tables[0].Rows.Count != 0)
            {
                string filename = "~/Upload/" + ds1.Tables[0].Rows[0]["AttachName"].ToString();
                avatar2.Src = filename;
            }



            DataSet ds = TaxiDAL.UsersClass.GetList(Session["UserID"].ToString(), null, null, null, null,
                    null, null, null, null, null, null, null);
            Fullname.Text = ds.Tables[0].Rows[0]["FullNameUser"].ToString();
            Semat.Text = ds.Tables[0].Rows[0]["SemeatName2"].ToString();
            codemeli.Text = ds.Tables[0].Rows[0]["MelliCode"].ToString();
            Email.Text = ds.Tables[0].Rows[0]["Email"].ToString();
            Mobile.Text = ds.Tables[0].Rows[0]["Mobile"].ToString();
            Username.Text = ds.Tables[0].Rows[0]["Username"].ToString();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindData();

            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            UploadFile1.FilePath = @"Upload/";
            string filename=null;
            if (UploadFile1.hasFile())
            {
                filename = UploadFile1.Upload();
            }
            TaxiCL.ClAttach cl = new TaxiCL.ClAttach();
            cl.AttachName = filename;
            cl.ForCatalogType = 1;
            cl.ForCatalogValue = 1;
            cl.ForID = Int32.Parse(Session["UserID"].ToString());
            TaxiDAL.AttachClass.insert(cl);
            TaxiDAL.UsersClass.Update(Session["UserID"].ToString(), null, null, null, null, Mobile.Text, null, Email.Text, codemeli.Text, null, null,
                null, null, null, null, null, null);
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('عملیات با موفقیت انجام شد')", true);

            BindData();
        }
    }
}