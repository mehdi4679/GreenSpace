using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GreenSpaceCL;
using GreenSpaceDAL;
using System.Data;

namespace GreenSpace.Masters
{
    public partial class AgreeMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                ClAgreement cl = new ClAgreement();


                cl.AgreementID =Convert.ToInt32(Request.QueryString["aid"].ToString()    ) ;
                DataSet ds = AgreementClass.GetList(cl);
                DataRow dr = ds.Tables[0].Rows[0];

                lblactive.Text = dr["StatusName"].ToString();
                lblFulname.Text = dr["AgreementID"].ToString() + " " + dr["FullName"].ToString();
                lblPeymanIDName.Text = dr["PeymanName"].ToString();
                lblStatrtDateAgreement.Text = DateConvert.m2sh(dr["StatrtDateAgreement"].ToString()).ToString();
                lblsupervisorStaticIDName.Text = dr["SuperVisorName"].ToString();
                //LBlPayePrice.Text = dr[""].ToString();
                //LBlMablagh.Text = dr[""].ToString();
                LBLPeymankarName.Text = dr["PeymanKarIDName"].ToString();

                if (dr["StatusID"].ToString() == "1")
                    lblactive.ForeColor = System.Drawing.Color.Green ;
                else
                    lblactive.ForeColor = System.Drawing.Color.Red ;



            }
        }
    }
}