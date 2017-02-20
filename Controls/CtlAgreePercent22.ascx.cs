using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using GreenSpaceDAL;
using GreenSpaceCL;
using System.Web.UI.HtmlControls;

namespace GreenSpace.Controls
{
    public partial class CtlAgreePercent22 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                CtlAgreePercentProtest1.BindDD();
                //Attribute to show the Plus Minus Button.
                GridView1.HeaderRow.Cells[0].Attributes["data-class"] = "expand";

                //Attribute to hide column in Phone.
                GridView1.HeaderRow.Cells[2].Attributes["data-hide"] = "phone";
                GridView1.HeaderRow.Cells[3].Attributes["data-hide"] = "phone";
                GridView1.HeaderRow.Cells[4].Attributes["data-hide"] = "phone";
                GridView1.HeaderRow.Cells[5].Attributes["data-hide"] = "phone";
                GridView1.HeaderRow.Cells[6].Attributes["data-hide"] = "phone";
                GridView1.HeaderRow.Cells[7].Attributes["data-hide"] = "phone";
                GridView1.HeaderRow.Cells[8].Attributes["data-hide"] = "phone";
                GridView1.HeaderRow.Cells[9].Attributes["data-hide"] = "phone";
                GridView1.HeaderRow.Cells[10].Attributes["data-hide"] = "phone";
                GridView1.HeaderRow.Cells[11].Attributes["data-hide"] = "phone";

                //Adds THEAD and TBODY to GridView.
                GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;

            }
            catch { }
        }

        public string datedefault
        {
            get { return txtDate.Value; }
            set { txtDate.Value = value; }
        }
        public bool visibleBtn{
            get { return btnSave.Visible; }
            set{btnSave.Visible=value;
                              }
                }

        public bool visibleDeleteGrid{
            get { return GridView1.Columns[1].Visible; }
            set
            {
                GridView1.Columns[1].Visible = value;
                              }
                }

        public bool EnableGrid
        {
            get { return GridView1.Enabled; }
            set {
                GridView1.Enabled = value;
            }
        }

        public string Agreeid
        {
            get { return lblAgreement.Text; }
            set { lblAgreement.Text = value; }
        }
        public void BindSubject()
        {
            DataSet ds = TaxiDAL.CatalogClass.GetListTypeID("3");
            ddsubject.DataTextField = "CatalogName";
            ddsubject.DataValueField = "CatalogValue";
            ddsubject.DataSource = ds;
            ddsubject.DataBind();
            ddsubject.Items.Insert(0, new ListItem("همه موارد", "0"));

        }

        protected void btnSerachLight_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
        public void BindGrid()
        {
            ClAgreementPercent cl = new ClAgreementPercent();
            cl.AgreementID = Convert.ToInt32(lblAgreement.Text);
            cl.VisitDate = DateConvert.sh2m(txtDate.Value).ToString();
            cl.SubjectID = Convert.ToInt32(ddsubject.SelectedValue);
            DataSet ds = AgreementPercentClass.GetList2(cl);
            DataView dv = new DataView(ds.Tables[0]);
            if (ViewState["AgreementPercentID"] == null)
            {
                ViewState["AgreementPercentID"] = "AgreementPercentID Desc";
            }
            dv.Sort = Securenamespace.SecureData.CheckSecurity(ViewState["AgreementPercentID"].ToString()).ToString();
            GridView1.DataSource = dv;
            GridView1.DataBind();
            RowColor();
            ds.Dispose();
        }
        private void RowColor()
        {
            GridViewRow gr = null;
            Label lbl = null;
            Label lblcolor = null;

            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                gr = GridView1.Rows[i];
                lbl = (Label)gr.FindControl("lblcolor");
                lblcolor = (Label)gr.FindControl("lblcolor2");


                if (lblcolor.Text == "yellow")
                    gr.BackColor = System.Drawing.Color.FromName("#80dfff");
                else if (lblcolor.Text == "red")
                    gr.BackColor = System.Drawing.Color.FromName("#ffb3cc");
                else if (lblcolor.Text == "green")
                    gr.BackColor = System.Drawing.Color.FromName("#b3ffb3");
                else if (lblcolor.Text == "balck")
                    gr.BackColor = System.Drawing.Color.FromName("#ffd9b3");
                else if (lblcolor.Text == "blue")
                    gr.BackColor = System.Drawing.Color.FromName("#b3b3ff");


                if (SematID == "1")
                    gr.Enabled = false;

            }
        }
        public string SematID
        {
            get { return lblsemat.Text; }
            set { lblsemat.Text = value;
            CtlAgreePercentProtest1.Semat = SematID;
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
            if (ViewState["AgreementPercentID" + "Direction"] == null)
            {
                ViewState.Add("AgreementPercentID" + "Direction", "desc");
            }

            StrSortDirection = Securenamespace.SecureData.CheckSecurity(ViewState["AgreementPercentID" + "Direction"].ToString());

            if (StrSortDirection == "desc")
                StrSortDirection = "asc";
            else
                StrSortDirection = "desc";

            ViewState["AgreementPercentID" + "Direction"] = StrSortDirection;
            ViewState["AgreementPercentID"] = e.SortExpression + " " + StrSortDirection;
            BindGrid();
        }
        public void DeleteItem(object sender, System.EventArgs e)
        {
            String AgreementFineID = ((HtmlAnchor)sender).HRef.ToString();
            int i = AgreementPercentClass.Delete(AgreementFineID);
            if (i == 0)
            {
                //LblMsg.Text = " error ";
                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), Guid.NewGuid().ToString(), "alert('خطا در حذف');", true);
            }
            else { BindGrid(); }
            LightBox.Value = "0";
        }
        public void historyItem(object sender, EventArgs e)
        {
            String AgreementPercentID = ((HtmlAnchor)sender).HRef.ToString();
            CtlPercentHistory1.AgreePercent = AgreementPercentID;
            CtlPercentHistory1.BindGrid();
            LightBox3.Value = "1";
        }

        public void ViewPercentItem(object sender, EventArgs e)
        {
            String AgreementID = ((HtmlAnchor)sender).Attributes["AgreementID"].ToString() == "" ? Agreeid.ToString() : ((HtmlAnchor)sender).Attributes["AgreementID"].ToString();
            String ExpanlID = ((HtmlAnchor)sender).Attributes["ExplainID"].ToString();
            ClAgreementPercent cl = new ClAgreementPercent();
            cl.AgreementID = Convert.ToInt32(AgreementID);
            cl.ExplainID = Convert.ToInt32(ExpanlID);
            DataSet ds = AgreementPercentClass.GetList(cl);
            GridAllPercent.DataSource  = ds;
            GridAllPercent.DataBind();
            LightBox4.Value = "1";

        }
        public void ProtestItem(object sender, EventArgs e)
        {



            String AgreementPercentID = ((HtmlAnchor)sender).HRef.ToString();
            if (AgreementPercentID == "")
            {
                LightBox.Value = "0";
                LightBox2.Value = "0";
                   LightBox4.Value = "0";
                   LightBox3.Value = "0";
                   return;

         }
            CtlAgreePercentProtest1.AgreementPercentID = Convert.ToInt32(AgreementPercentID==""?"-100":AgreementPercentID);

            // CtlAgreePercentProtest1.BindDD();
            CtlAgreePercentProtest1.BindGrid();

            //LblParamAgreementPercentID.Text = AgreementPercentID;
            //ClAgreementPercent cl = new ClAgreementPercent();
            //cl.AgreementPercentID = Convert.ToInt32(AgreementPercentID);
            //Data = cl;
            LightBox2.Value = "1";

        }
        public int SuperVisorID
        {
            get { return Convert.ToInt32(Label1.Text); }
            set { Label1.Text = value.ToString(); }
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDate.Value == "")
            {
                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), Guid.NewGuid().ToString(), "alert('تاریخ را اننخاب نمایید');", true);
                return;
            }
            
            GridViewRow gr = null;
             string tt = "";
            
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                gr = GridView1.Rows[i];
                Label txtAgreementPercentID = (Label)gr.FindControl("txtAgreementPercentID");
                //Label txtAgreementID = (Label)gr.FindControl("txtAgreementID");
                TextBox txtFineFactor = (TextBox)gr.FindControl("txtFineFactor");
                TextBox txtFineMeterOrRepeat = (TextBox)gr.FindControl("txtFineMeterOrRepeat");
                TextBox txtJarimeComment = (TextBox)gr.FindControl("txtJarimeComment");
                int txtSuperVisorID =  SuperVisorID  ;
                TextBox txtunitNumberNazer = (TextBox)gr.FindControl("txtunitNumberNazer");
                TextBox txtutilityPersent = (TextBox)gr.FindControl("txtutilityPersent");
                Label explansubjectid = (Label)gr.FindControl("lblExplainSubjectID");
                Label lblerror = (Label)gr.FindControl("lblerror");

                if (Convert.ToInt32(txtutilityPersent.Text == "" ? "0" : txtutilityPersent.Text) > 100)
                {
                    txtutilityPersent.BackColor = System.Drawing.Color.Red;
                    return;
                }
                ClAgreementPercent cl = new ClAgreementPercent();

               // TextBox txtVisitDate = (TextBox)gr.FindControl("txtVisitDate");
                cl.AgreementPercentID=Convert.ToInt32( txtAgreementPercentID.Text=="" ? "0":txtAgreementPercentID.Text);
                cl.FineFactor = Convert.ToInt32(txtFineFactor.Text=="" ? "0":txtFineFactor.Text);
                cl.FineMeterOrRepeat = Convert.ToInt32(txtFineMeterOrRepeat.Text=="" ? "0":txtFineMeterOrRepeat.Text);
                cl.JarimeComment = txtJarimeComment.Text;
                cl.SuperVisorID =  SuperVisorID==null?0: SuperVisorID;
                cl.unitNumberNazer = Convert.ToDecimal(txtunitNumberNazer.Text=="" ? "0":txtunitNumberNazer.Text);
                cl.utilityPersent = Convert.ToDecimal(txtutilityPersent.Text=="" ? "0.0":txtutilityPersent.Text);
                cl.VisitDate =DateConvert.sh2m(txtDate.Value).ToString();
                cl.AgreementID = Convert.ToInt32(lblAgreement.Text == "" ? "0" : lblAgreement.Text);
                cl.ExplainID = Convert.ToInt32(explansubjectid.Text == "" ? "0" : explansubjectid.Text);
                tt =erroralert( Save(cl));
                if (tt != "")
                {
                    gr.BackColor = System.Drawing.Color.Red;
                    lblerror.Text = "اعلان";
                    lblerror.Attributes["title"] = tt;
                    lblerror.Attributes["placeholder"] = tt;

                }
                else
                {
                    gr.BackColor = System.Drawing.Color.Green;
                    lblerror.Visible = false;
                }
            }
        }

        public string erroralert( int t){
            string a = "";
                    if (t == 0)
                 a = "خطا در ثبت";
             else if (t == -1)
            {
             a= "سقف ثبت بازدید تکمیل شده است" ;
            }
            else if (t == -2)
            {
                a="برای این شرح کار در این تاریخ درصد ثبت شده است" ;
            }
            else if (t == -3)
                a= "فقط ناظر مقیم و مدیر سیستم میتوانند درصد وارد نمایند"  ;
            else if (t == -4)
               a="تا 48 ساعت قبل شما مجاز به ورود درصد هستید" ;
            else if (t == -10)
               a="بیشتر از 10 درصد و بیشتر از یکبار نمیتوان ویرایش کرد" ;
            else if (t == -11 || t == -12 || t == -14 || t == -15 || t == -16   )
               a= "مهلت تغییر درصد زنی به اتمام رسیده است" ;
            else if (t == -13)
               a= "برای تاریخ های جلوتر از تاریخ فعلی نمیتوان درصد وارد کرد" ;
                    else if (t == -100)
                        a = "وارد کردن درصد الزامی است";

            return a;

    }

        private int Save(ClAgreementPercent cl )
        {
            int i = 0;
            if (cl.utilityPersent.ToString() == "0.0")
                return -100;

            if (cl.AgreementPercentID == null || cl.AgreementPercentID == 0)
             i=AgreementPercentClass.insert(cl);
            else
                i=AgreementPercentClass.Update(cl);
          
            return i;
        }

        protected void ddsubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();
        }


        }

 




     
}