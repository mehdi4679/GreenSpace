using GreenSpaceCL;
using GreenSpaceDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GreenSpace.Agree
{
    public partial class ReportMonth : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                AgreementID = Convert.ToInt32(Request.QueryString["aid"].ToString());
                BindDD();
              //  BindGrid();
            }
        }
        private void BindDD() {
            ddSubject.DataSource = TaxiDAL.CatalogClass.GetListTypeID("3");
            ddSubject.DataTextField = "CatalogName";
            ddSubject.DataValueField = "CatalogValue";
            ddSubject.DataBind();
            ddSubject.Items.Insert(0, new ListItem("انتخاب نمایید", "0"));

        }
        public int AgreementID
        {
            get { return Convert.ToInt32(lblAgrement.Text); }
            set { lblAgrement.Text = value.ToString(); }
        }
        public void BindGrid()
        {
            ClAgreement cl = new ClAgreement();
            cl.FromDateReport = DateConvert.sh2m(CtlFromDate.Text).ToString();
            cl.ToDateReport = DateConvert.sh2m(CtlToDate.Text).ToString();
            cl.AgreementID =Convert.ToInt32( lblAgrement.Text);
            cl.SubjectID=Convert.ToInt32( ddSubject.SelectedValue);

            DataSet ds = AgreementClass.GetListReport(cl);
            DataView dv = new DataView(ds.Tables[0]);
            if (ViewState["AgreementID"] == null)
            {
                ViewState["AgreementID"] = "AgreementID Desc";
            }
            dv.Sort = Securenamespace.SecureData.CheckSecurity(ViewState["AgreementID"].ToString()).ToString();
            GridView1.DataSource = dv;
            GridView1.DataBind();
            if(ds.Tables[0].Rows.Count>0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                LBLkHESARAT.Text = dr["finekhesarat"].ToString();


            }
        }
        protected void GridView1_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            BindGrid();
        }
        protected void GridView1_Sorting(object sender, System.Web.UI.WebControls.GridViewSortEventArgs e)
        {
            string StrSortDirection;
            if (ViewState["AgreementID" + "Direction"] == null)
            {
                ViewState.Add("AgreementID" + "Direction", "desc");
            }

            StrSortDirection = Securenamespace.SecureData.CheckSecurity(ViewState["AgreementID" + "Direction"].ToString());

            if (StrSortDirection == "desc")
                StrSortDirection = "asc";
            else
                StrSortDirection = "desc";

            ViewState["AgreementID" + "Direction"] = StrSortDirection;
            ViewState["AgreementID"] = e.SortExpression + " " + StrSortDirection;
            BindGrid();
        }

        protected void ddSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

    }
}