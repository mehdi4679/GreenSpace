using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using GreenSpaceCL;
using GreenSpaceDAL;
namespace GreenSpace.Controls
{
    public partial class CtlDropExplan : System.Web.UI.UserControl
    {
        public delegate void call();
        public event call  E_ExpalnChange;
        public bool AutoPostBackExplan 
        {
            get
            {
                return DDExplan.AutoPostBack;
            }
            set
            {
                DDExplan.AutoPostBack = value;
            }
        }

        public CtlDropExplan(){

           // ddSubject.SelectedIndexChanged += ChanegCall;

         
    }
        public int AgreementID
        {
            get { return Convert.ToInt32(lblAgreementID.Text); }
            set { lblAgreementID.Text = value.ToString(); }
        }
        public int OnlyActive
        {
            get { return Convert.ToInt32(lblOnlyActiveView.Text); }
            set { lblOnlyActiveView.Text = value.ToString(); }
        }

        
        private void BindSubject() {
            System.Data.DataSet ds;
           
            if (lblAgreementID.Text == "0")
                ds = TaxiDAL.CatalogClass.GetListTypeID("3");
            else
            {
                ClArea cl = new ClArea();
                cl.AgreementID = Convert.ToInt32(lblAgreementID.Text);
                cl.OnlyActive = Convert.ToInt32( lblOnlyActiveView.Text);
                ds = AreaClass.GetListSubjectAgree(cl);
            }
            ddSubject.DataSource = ds;
            ddSubject.DataTextField = "CatalogName";
            ddSubject.DataValueField = "CatalogValue";
            ddSubject.DataBind();
            
        }
        private void BindExplan() { 
            if(ddSubject.Items.Count==0   )
            {
                CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "شرح کاری برای ورود فعال نشده است");
                return;
            }
             
        ClExplanSubject cl=new ClExplanSubject();
        cl.SubjectID = Convert.ToInt32( ddSubject.SelectedValue);
        cl.AgreeMentID = Convert.ToInt32(lblAgreementID.Text);
        cl.OnlyActive = Convert.ToInt32(lblOnlyActiveView.Text);

        DDExplan.DataSource = ExplanSubjectClass.GetList(cl);
        DDExplan.DataTextField = "ExplainName";
        DDExplan.DataValueField = "ExplainSubjectID";
        DDExplan.DataBind();
                    }
        public void Bind() {
            BindSubject();
            
            BindExplan();
                    }

        protected void ddSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindExplan();

        }
        public int SelectedValue {
            get {
                if (DDExplan.SelectedValue.ToString() == "")
                    return 0;
                else
                return Convert.ToInt32(DDExplan.SelectedValue); }
            set {
                ClExplanSubject cl = new ClExplanSubject();
                cl.ExplainSubjectID = value;
                DataRow dr = ExplanSubjectClass.GetList(cl).Tables[0].Rows[0];
                ddSubject.SelectedValue = dr["SubjectID"].ToString();
                BindExplan();
                DDExplan.SelectedValue = value.ToString();
            }
        }
        public string SubjectID {
            get { return ddSubject.SelectedValue; }
            set { 
                ddSubject.SelectedValue = value;
             BindExplan();
            }

        }

        protected void DDExplan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(E_ExpalnChange !=null)
                try
                {
                    E_ExpalnChange();
                }
                catch { }
        }


    }
}