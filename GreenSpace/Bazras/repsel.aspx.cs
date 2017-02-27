using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using GreenSpaceCL;
using GreenSpaceDAL;
using System.Web.UI.HtmlControls;

using TaxiDAL;
using TaxiCL;



namespace GreenSpace.Bazras
{
    public partial class repsel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!Page.IsPostBack)
            {
                dAgree.Visible = false;
                if (Request.QueryString["RName"] == null)
                    return;

                if (Request.QueryString["RName"].ToString() == "Rp_SubjectPrice"
                    || Request.QueryString["RName"].ToString() == "Rp_Percent"
                    || Request.QueryString["RName"].ToString() == "Rp_Area"
                    || Request.QueryString["RName"].ToString() == "Rp_Price2"
                     || Request.QueryString["RName"].ToString() == "Rp_Khesarat"
                     || Request.QueryString["RName"].ToString() == "rp_khesart3"
                     || Request.QueryString["RName"].ToString() == "Rp_Park"
                     || Request.QueryString["RName"].ToString() == "Rp_ExplainPrice2"

                    )
                {
                    ClAgreement cl = new ClAgreement();
                    ddAgree.DataSource = AgreementClass.GetList(cl);
                    ddAgree.DataTextField = "AggreeName";
                    ddAgree.DataValueField = "AgreementID";
                    ddAgree.DataBind();
                    ddAgree.Items.Insert(0, new ListItem("پیش فرض", "0"));
                    dAgree.Visible = true;
                }
                ctlArchiveDD.BindDD();


                if (Request.QueryString["RName"].ToString() == "SumPay" ||
                    Request.QueryString["RName"].ToString() == "SumPay2" ||
                    Request.QueryString["RName"].ToString() == "RptSumPayPage"
                    )
                {
                    dsubject1.Visible = true;
                    CtlAllSubjectExplan.BindAll = "1";
                    CtlAllSubjectExplan.BindDD();
                }
            }

        }



        private DataSet GenrateDS(int? AgreeID = null, string fromdate = null, string todate = null, string repname = "")
        {
            SqlConnection cnn = new SqlConnection(CSharp.PublicFunction.cnstr());

            SqlCommand cmd = new SqlCommand(repname, new SqlConnection(CSharp.PublicFunction.cnstr()));
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("AgreeID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(AgreeID);
            cmd.Parameters.Add(new SqlParameter("FromDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(fromdate);
            cmd.Parameters.Add(new SqlParameter("ToDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(todate);
            //SqlParameter prmResult = new SqlParameter("Result", SqlDbType.Int);
            //prmResult.Direction = ParameterDirection.Output;
            //cmd.Parameters.Add(prmResult);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                cnn.Open();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                cnn.Close();
            }

        }



        protected void btnprint21_Click(object sender, EventArgs e)
        {
            try
            {

                DataSet ds = null;
                if (Request.QueryString["RName"].ToString() == "Rp_ExplainPrice2" ||
                    Request.QueryString["RName"].ToString() == "Rp_SubjectPrice"
                     )
                {
                    ClArchiveAgree cl = new ClArchiveAgree();
                    cl.AgreeID = Convert.ToInt32(ddAgree.SelectedValue);
                    cl.AcrchiveID = ctlArchiveDD.SelectedValue;
                    if (Request.QueryString["RName"].ToString() == "Rp_ExplainPrice2")
                        ds = ArchiveAgreeClass.GetListReport(cl);
                    else if (Request.QueryString["RName"].ToString() == "Rp_SubjectPrice")
                        ds = AgreementClass.GetListSubjectPrice(cl);
                }
                else if (Request.QueryString["RName"].ToString() == "SumPay" ||
                    Request.QueryString["RName"].ToString() == "SumPay2" ||
                    Request.QueryString["RName"].ToString() == "RptSumPayPage")
                {
                    ClExplanSubject cl2 = new ClExplanSubject();
                    cl2.ExplainSubjectID = Convert.ToInt32(CtlAllSubjectExplan.SelectedValue);
                    cl2.SubjectID = Convert.ToInt32(CtlAllSubjectExplan.subjectID);
                    cl2.FromDate = CtlFromToDate.FromDate;
                    cl2.ToDate = CtlFromToDate.ToDate;
                    ds = ExplanSubjectClass.GetListSumPay(cl2, 0);
                }
                else if (Request.QueryString["RName"].ToString() == "Rp_Khesarat" || Request.QueryString["RName"].ToString() == "rp_khesart3")
                {
                    ClAgreementFine cl = new ClAgreementFine();
                    cl.AgreementID = Convert.ToInt32(ddAgree.SelectedValue);
                    cl.ArchivID = Convert.ToInt32(ctlArchiveDD.SelectedValue);
                    ds = AgreementFineClass.GetList_Rep(cl);
                }




                Session["ReportData"] = ds;
                MyIfarm1.Visible = true;

                MyIfarm1.Attributes.Add("src", "~/Report/reportview2.aspx?RName=" + Request.QueryString["RName"].ToString() + "&PName=" + Request.QueryString["PName"].ToString());

            }
            catch { }

        }



        protected void dd2Agree_SelectedIndexChanged(object sender, EventArgs e)
        {
            ctlArchiveDD.Agreement = Convert.ToInt32(ddAgree.SelectedValue.ToString());
            ctlArchiveDD.BindDD();
        }



    }
}