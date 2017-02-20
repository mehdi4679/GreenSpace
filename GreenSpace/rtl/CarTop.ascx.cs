using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using TaxiCL;
using TaxiDAL;

namespace Taxi.rtl
{
    public partial class CarTop : System.Web.UI.UserControl
    {

        public string setdata(string carid)
        { 
                ClKhodro cl=new ClKhodro();
            cl.KhodroID=Convert.ToInt32(carid);
            DataSet ds = KhodroSpace.KhodroClass.GetList(cl);
            DataRow dr = ds.Tables[0].Rows[0];
            
             
                
               
             
            lblcode.Text = dr["Code"].ToString();
            lblmotor.Text = dr["ShomareMotor"].ToString();
            lblPelek.Text = dr["ShomarePelak"].ToString();
            lblshasi.Text = dr["ShomareShasi"].ToString();
            return dr["finalAct"].ToString();
            ds.Dispose();

        }
    }
}