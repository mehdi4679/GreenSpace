using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GreenSpaceCL;
using GreenSpaceDAL;
using System.Data;

namespace GreenSpace.Agree
{
    public partial class AgreePark : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                CtlAgreepp11.AgrrementID = Convert.ToInt32(Request.QueryString["aid"]);
                 try
                 {
                     CtlAgreepp11.ParkDistrict = Convert.ToInt32(Request.QueryString["District"]);
                 }
                 catch
                 {
                     CtlAgreepp11.ParkDistrict = 1;
                 }

                 CtlAgreepp11.BindDD();
                // BindPeyman();

                CtlAgreepp11.PeymanID = GetPeymanAgreement(Convert.ToInt32(Request.QueryString["aid"])).ToString();
                CtlAgreepp11.EnableDDPeyman = false;
                CtlAgreepp11.BindGrid();
                DDPeymanID.Visible = false;
            }

        }

        private int GetPeymanAgreement(int agreeid) {
            ClAgreement cl = new ClAgreement();
            
            cl.AgreementID = agreeid;
            DataSet ds = AgreementClass.GetList(cl);
            DataRow dr = ds.Tables[0].Rows[0];
            return Convert.ToInt32(dr["PeymanID"].ToString());
        }
        private void BindPeyman()
        {
            GreenSpaceCL.ClPeyman cl = new GreenSpaceCL.ClPeyman();

            DDPeymanID.DataSource = GreenSpaceDAL.PeymanClass.GetList(cl);
            DDPeymanID.DataTextField = "PeymanName";
            DDPeymanID.DataValueField = "PeymanID";
            DDPeymanID.DataBind();

        }

        protected void DDPeymanID_SelectedIndexChanged(object sender, EventArgs e)
        {
            CtlAgreepp11.PeymanID = DDPeymanID.SelectedValue.ToString();
            CtlAgreepp11.BindGrid();

        }
    }
}