using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using GreenSpaceDAL;
using GreenSpaceCL;

namespace GreenSpace.Manage
{
    public partial class OneExplainArea : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindDD();
                BindGrid();
            }
        }
        private void BindDD()
        {
            ClAgreement cl = new ClAgreement();
            DataSet ds = AgreementClass.GetList(cl);
            ddPeyman.DataSource = ds;
            ddPeyman.DataTextField = "AggreeName";
            ddPeyman.DataValueField = "AgreementID";
            ddPeyman.DataBind();
            ddPeyman.Items.Insert(0, new ListItem("پیش فرض", "0"));

            BindPeyman2();
        }
        private void BindPeyman2()
        {
            ClPeyman cl = new ClPeyman();
            DataSet ds = PeymanClass.GetList(cl);
            ddPeyman2.DataSource = ds;
            ddPeyman2.DataTextField = "PeymanName";
            ddPeyman2.DataValueField = "PeymanID";
            ddPeyman2.DataBind();
            if (ddPeyman.SelectedValue != "0")
            {
                //ClPeymanPark cl2 = new ClPeymanPark();
                //cl2.AgreementID = Convert.ToInt32(ddPeyman.SelectedValue);
                //DataSet ds2 = PeymanParkClass.GetList(cl2);
                //ddPeyman2.SelectedValue = ds2.Tables[0].Rows[0]["PeymanID"].ToString();
                //ddPeyman2.Enabled = false;
                ClAgreement cl2 = new ClAgreement();
                cl2.AgreementID = Convert.ToInt32(ddPeyman.SelectedValue);
                DataSet ds2 = AgreementClass.GetList(cl2);
                ddPeyman2.SelectedValue = ds2.Tables[0].Rows[0]["PeymanID"].ToString();
                ddPeyman2.Enabled = false;

            }
            else
                ddPeyman2.Enabled = true;

        }

        private void BindGrid()
        {
            ClPeymanPark cl = new ClPeymanPark();
            cl.AgreementID = Convert.ToInt32(ddPeyman.SelectedValue);
            cl.PeymanID = Convert.ToInt32(ddPeyman2.SelectedValue);

            DataSet ds = PeymanParkClass.GetList(cl);
            Grid1.DataSource = ds;
            Grid1.DataBind();
            //        BindGridContetnt();
        }
        public void calallcolumn(TextBox clo, TextBox row)
        {
            decimal i1 = 0; decimal i2 = 0; decimal tempi = 0;
            i1 = Convert.ToDecimal(clo.Text == "" ? "0" : clo.Text);
            i2 = Convert.ToDecimal(row.Text == "" ? "0" : row.Text);
            tempi = i1 + i2;
            clo.Text = tempi.ToString();
            return;
        }


        //    protected void btnAdd_Click(object sender, EventArgs e)
        //    {
        //                    GridViewRow grow;
        //        for (int i = 0; i < Grid1.Rows.Count; i++)
        //        {
        //            grow = Grid1.Rows[i];
        //            Label txtChaman_Kol = grow.FindControl("txtChaman_Kol") as Label;
        //            TextBox txtChamanAbDasti = grow.FindControl("txtChamanAbDasti") as TextBox;
        //          int  ParkID = Convert.ToInt32(((grow.FindControl("lblPark") as Label).Text));
        //          SaveArea(ParkID, 15, 9017, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtChamanAbDasti.Text, txtChamanAbDasti);

        //    }
        //}
    }
}