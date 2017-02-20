using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GreenSpace.CityZen
{
    public partial class attach : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CtlAttach.ID = id;
                 CtlAttach.BindDB();
                CtlAttach.BindGrid();

            }

        }
        public string id
        {
            get { return Request.QueryString["id"] ==null ? "-111":Request.QueryString["id"].ToString(); }
            set { Request.QueryString["id"] = value ; }
        }
    }
}