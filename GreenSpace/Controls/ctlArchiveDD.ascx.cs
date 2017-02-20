using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GreenSpaceCL;
using GreenSpaceDAL;
using GreenSpaceBLL;
using System.Data;
using System.Data.SqlClient;

namespace GreenSpace.Controls
{
    public partial class ctlArchiveDD : System.Web.UI.UserControl
    {
        public int Agreement
        {
            get{ return Convert.ToInt32(lblAgreeID.Text);   }
            set { lblAgreeID.Text = value.ToString(); }
        }
 
        public void BindDD()
        {
            ClArchiveAgreeTitle cl = new ClArchiveAgreeTitle();
            cl.AgreeID = Agreement;
            ddarchive.DataSource = ArchiveAgreeTitleClass.GetList(cl);
             ddarchive.DataTextField = "AgreeName";
            ddarchive.DataValueField = "tbl_ArchiveAgreeTitle";
            ddarchive.DataBind();
        }
        public int SelectedValue
        {
            get { return Convert.ToInt32(ddarchive.SelectedValue.ToString()); }
            set { ddarchive.SelectedValue = value.ToString(); }
        }
    }
}