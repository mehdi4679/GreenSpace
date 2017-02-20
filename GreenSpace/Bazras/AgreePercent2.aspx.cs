using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GreenSpace.Bazras
{
    public partial class AgreePercent2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    if (Session["semat"].ToString() == "1")
                    {
                         CtlAgreePercent22.visibleBtn = false;
                        CtlAgreePercent22.SematID = "1";
                        CtlAgreePercent22.EnableGrid = false;
                        CtlAgreePercent22.visibleDeleteGrid = false;
                    }
                    CtlAgreePercent22.datedefault = DateConvert.m2sh(DateTime.Now.ToString()).ToString();
                    CtlAgreePercent22.Agreeid = Session["AgreeID"].ToString();
                    CtlAgreePercent22.SuperVisorID = Convert.ToInt32(Session["UserID"].ToString());
                    CtlAgreePercent22.BindSubject();
                    CtlAgreePercent22.BindGrid();
                    CtlAgreePercent22.visibleDeleteGrid = false;

                }
            }
            catch
            {

            }


        }
    }
}