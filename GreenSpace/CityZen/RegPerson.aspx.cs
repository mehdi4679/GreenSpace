using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using GreenSpaceCL;
using GreenSpaceDAL;
using GreenSpaceBLL;
using System.Web.UI.HtmlControls;
using System.Web.Security;
using System.Security.Principal;
using GreenSpaceBLL;
using CSharp;

namespace GreenSpace.CityZen
{
    public partial class RegPerson : System.Web.UI.Page
    {
        public ClPersonal Data
        {
            get
            {
                ClPersonal cl = new ClPersonal();
                cl.FirstName = TXTFirstName.Text;
                cl.LastName = TXTLastName.Text;
                cl.Email = TXTEmail.Text;
                cl.PersonalTel = TXTPersonalTel.Text;
                cl.PersonalMobile = TXTPersonalMobile.Text;
                cl.PostiCode = TXTPostiCode.Text;
                cl.NationalCode = TXTNationalCode.Text;
                cl.PersonalAdress = TXTPersonalAdress.Text;
                cl.JobName = TXTJobName.Text;
                //cl.PersonalID = Convert.ToInt32(lblPersonalID.Text);
                return cl;
            }
            set
            {
                DataSet ds = PersonalClass2.GetList(value);
                DataRow dr = ds.Tables[0].Rows[0];
                TXTFirstName.Text = dr["FirstName"].ToString();
                TXTLastName.Text = dr["LastName"].ToString();
                TXTEmail.Text = dr["Email"].ToString();
                TXTNationalCode.Text = dr["NationalCode"].ToString();
                TXTPersonalMobile.Text = dr["PersonalMobile"].ToString();
                TXTPersonalTel.Text = dr["PersonalTel"].ToString();
                TXTPostiCode.Text = dr["PostiCode"].ToString();
                TXTPersonalAdress.Text = dr["PersonalAdress"].ToString();
                TXTJobName.Text = dr["JobName"].ToString();
                lblPersonalID.Text = dr["PersonalID"].ToString();
                ds.Dispose();
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnInsert_Click(object sender, EventArgs e)
        {
            ClPersonal cl = new ClPersonal();
            cl = Data;
            int t = 0;
            var hash = FormsAuthentication.HashPasswordForStoringInConfigFile(txtpass.Text + "~!@", "MD5");
            cl.Pass = hash;
            t = PersonalClass2.insert(cl);

            if (t > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('ثبت نام با موفقیت انجام شد')", true);
                //Response.Redirect("~/CityZen/PersonalView.aspx");
            }
            
        }

    }
}