using GreenSpaceCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GreenSpaceDAL;
using System.Data;

namespace GreenSpace.Controls
{
    public partial class CtlAllSubjectExplan : System.Web.UI.UserControl
    {
        public event EventHandler ButtonClick;
        protected void Button1_Click(object sender, EventArgs e)
        {
            //bubble the event up to the parent
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }
        public   string SelectedValue
        {
            get { return ddexplan.SelectedValue.ToString(); }
            set {
                ddSubject.SelectedValue = GetSubjectID(Convert.ToInt32(value));
                BindExpaln();
                ddexplan.SelectedValue = value.ToString();
                }
        }

       
        private string GetSubjectID(int explanid)
        {
            ClExplanSubject cl=new ClExplanSubject();
            cl.ExplainSubjectID=explanid;
            
            DataSet ds = ExplanSubjectClass.GetList(cl);
            if (ds.Tables[0].Rows.Count > 0)
                return ds.Tables[0].Rows[0]["SubjectID"].ToString();
            else
                return "0";
        }
        public string  BindAll {
            get{return txtbindall.Text;}
            set{txtbindall.Text=value;}
        }

        public string  subjectID
        {
            get { return ddSubject.SelectedValue.ToString(); }
            set { ddSubject.SelectedValue = value.ToString(); }
        }
     

        public void BindDD()
        {
 
            ddSubject.DataSource = TaxiDAL.CatalogClass.GetListTypeID("3");
             ddSubject.DataTextField = "CatalogName";
            ddSubject.DataValueField = "CatalogValue";
            ddSubject.DataBind();
            if (txtbindall.Text == "1")
            {
                ddSubject.Items.Insert(0, new ListItem("همه موارد", "0"));
            }

            BindExpaln();
 

        }

        private void BindExpaln()
        {
            ClExplanSubject cl  = new ClExplanSubject();
             cl.SubjectID=Convert.ToInt32(ddSubject.SelectedValue);
            ddexplan.DataSource = ExplanSubjectClass.GetList(cl);
            ddexplan.DataTextField = "ExplainName";
            ddexplan.DataValueField="ExplainSubjectID";
            ddexplan.DataBind();
            if (BindAll == "1")
            {
                ddexplan.Items.Insert(0, new ListItem("همه موارد", "0"));

            }
        }
        protected void ddSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindExpaln();
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }

        protected void ddexplan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }
        


    }
}