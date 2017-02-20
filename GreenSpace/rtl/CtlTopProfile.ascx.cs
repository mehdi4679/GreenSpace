using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using TaxiDAL;
using TaxiCL;
namespace Taxi.rtl
{
    public partial class CtlTopProfile : System.Web.UI.UserControl
    {

        public string ImhPic {
            get { return imgmaster.Src.ToString(); }
            set { imgmaster.Src = value; }
        }

        public string setdata(int personalID) { 
        ClPersonal cl=new ClPersonal();
            cl.PersonalID=personalID;
            DataSet ds = PersonalClass.GetList(cl);
            DataRow dr = ds.Tables[0].Rows[0];
            lblactive.Text = dr["actName"].ToString();
            lblcodemelli.Text = dr["CodeMelli"].ToString();
            lblFulname.Text = dr["fullname"].ToString();
            lblgovahiname.Text = dr["GavahinameTypeIdName"].ToString();
            lblNameMasetr.Text = dr["fullname"].ToString();
            lblParvanehnumber.Text = dr["parvanehname"].ToString();
            parvanehMaxDatePR.Text = dr["parvanehMaxDatePR"].ToString();
            lblGavahinameEnghezaDate.Text = DateConvert.m2sh(dr["DateEngezaGavahiname"].ToString());
            lblgovahiname.Text += " " + dr["ShomareGavahiname"].ToString();
            lblactive.Text += " " + dr["MalekOrKomaki"].ToString();

            ImhPic="/uploads/"+ dr["pic"].ToString();
            lblmobile.Text = dr["Mobile"].ToString();
           
            if (Convert.ToDateTime(dr["parvanehMaxDate"].ToString()) < DateTime.Now)
                parvanehMaxDatePR.ForeColor = System.Drawing.Color.Red;
            else
                parvanehMaxDatePR.ForeColor = System.Drawing.Color.Green;

            if (Convert.ToDateTime(dr["DateEngezaGavahiname"].ToString()) < DateTime.Now)
                lblGavahinameEnghezaDate.ForeColor = System.Drawing.Color.Red;
            else
                lblGavahinameEnghezaDate.ForeColor = System.Drawing.Color.Green;
             
            return dr["actid"].ToString();

           

        }


         
         



    }
}