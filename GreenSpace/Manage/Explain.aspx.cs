using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GreenSpaceCL;
using GreenSpaceDAL;
using System.Data;
using System.Web.UI.HtmlControls;


namespace GreenSpace.Manage
{
    public partial class Explain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {


                CtlExplanSubject1.BindDD();
                BindSubject();
                CtlExplanSubject1.SubJectID = Convert.ToInt32(ddsubject.SelectedValue);

                CtlExplanSubject1.BindGrid();
                CtlExplanSubject1.EnableSubject = false;

            }
        }

        private void BindSubject()
        {

            ddsubject.DataSource = TaxiDAL.CatalogClass.GetListTypeID("3");
            ddsubject.DataTextField = "CatalogName";
            ddsubject.DataValueField = "CatalogValue";
            ddsubject.DataBind();
        }



        protected void ddsubject_SelectedIndexChanged1(object sender, EventArgs e)
        {
            CtlExplanSubject1.SubJectID = Convert.ToInt32(ddsubject.SelectedValue);
            CtlExplanSubject1.BindGrid();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ClAgreeExplanPrice cl = new ClAgreeExplanPrice();
            //cl.PriceDayExplan = Convert.ToInt32(TXTPriceDayExplan.Text);
            //cl.PriceNightExplan = Convert.ToInt32(TXTPriceNightExplan.Text == "" ? "0" : TXTPriceNightExplan.Text);
            //cl.ExplanID = Convert.ToInt32(DDExplanID.SelectedValue);
            cl.SubjectID = Convert.ToInt32(ddsubject.SelectedValue);
        //    cl.AgreementID = Convert.ToInt32(lblagreementID.Text);
          //  cl.ExplanPriceID = Convert.ToInt32(LblParamExplanPriceID.Text);

            //  cl = Data;

            int ttt = 0;
            //if (CSharp.PublicFunction.ModeInsert(ExplanPriceID.ToString()))
                ttt = AgreeExplanPriceClass.insert_all(cl);

            if (ttt == 0)
            {
                LblMsg.ForeColor = System.Drawing.Color.Red;
                LblMsg.Text = "خطا در ثبت";
            }
            else
            {
                LblMsg.ForeColor = System.Drawing.Color.Green;
                LblMsg.Text = "ثبت  انجام شد.";
                //BindGrid();
            }
        //    LightBox.Value = "0";


            //LblParamExplanPriceID.Text = "0";

        }
    }
}