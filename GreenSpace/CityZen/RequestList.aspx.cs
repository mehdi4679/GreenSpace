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
    public partial class RequestList : System.Web.UI.Page
    {
        void BindGrid()
        {
            if (Session["PersonalID"] != null)
            {
                string pid = Session["PersonalID"].ToString();
                DataSet ds = CuttingTreeClass.GetList(null, null, null, null, null, null, null, null, null, pid, null, null,
                    null, null, null, null, null, null,null,null);
                gvRequestList.DataSource = ds;
                gvRequestList.DataBind();
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindGrid();
            }
        }
        public void DeleteItem(object sender, EventArgs e)
        {
            HtmlAnchor temp = (HtmlAnchor)sender;
            int id = Int32.Parse(temp.Attributes["GridID"].ToString());
            CuttingTreeClass.Delete(id);
            BindGrid();
            //tbl_Student_Lang.Delete(temp.Attributes["GridID"].ToString());
        }
    }
}