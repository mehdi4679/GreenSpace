using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GreenSpace.Bazras
{
    public partial class ExpalnRequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                if (Session["AgreeID"] != null && (Session["sematID"].ToString() == "6" || Session["sematID"].ToString()=="2"))//only nazer moghim
                    CtlExplanRequest1.Visible = true;
                else
                {
                    CtlExplanRequest1.Visible = false;
                    CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "شما دسترسی برای مشاهده این صفحه را ندارید");
                    return;
                }

                CtlExplanRequest1.SamtType = "bazras";
                CtlExplanRequest1.sematid = Session["sematID"].ToString();
                CtlExplanRequest1.BindDD();
                CtlExplanRequest1.ForUserID = CSharp.PublicFunction.GetUserID();
                CtlExplanRequest1.ForAgreementID = Session["AgreeID"].ToString() ;
                CtlExplanRequest1.BindGrid();
                CtlExplanRequest1.VisibleDropTaeeid = true;
            }
        }
    }
}