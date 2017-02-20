using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GreenSpaceDAL;
using TaxiDAL;
using GreenSpaceBLL;
using GreenSpaceCL;
using System.Data;
using System.Web.UI.HtmlControls;
using System.Web.UI;


namespace GreenSpace.Controls
{
    public partial class CtlAgreementPercent : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

         //    DDExplainFilter.E_ExpalnChange += changeExpalin;
            DDExplainID.E_ExpalnChange +=new CtlDropExplan.call( BindGrid );
            RowColor();
        }

        private void changeExpalin(object sender, EventArgs e)
        {
            BindGrid();
        }
        public ClAgreementPercent Data
        {
            get
            {
                ClAgreementPercent cl = new ClAgreementPercent();
                cl.AgreementID = Convert.ToInt32(lblAgreement.Text);
                cl.AgreementPercentID = Convert.ToInt32(LblParamAgreementPercentID.Text);
                cl.ExplainID =Convert.ToInt32( DDExplainID.SelectedValue);
                cl.FineFactor = Convert.ToInt32(DDFineFactor.SelectedValue);
                cl.FineMeterOrRepeat = Convert.ToInt32(TXTFineMeterOrRepeat.Text=="" ? "0":  TXTFineMeterOrRepeat.Text);
                cl.SuperVisorID = Convert.ToInt32(DDSuperVisorID.SelectedValue); 
                cl.utilityPersent = Convert.ToDecimal(TXTutilityPersent.Text);
                cl.VisitDate = DateConvert.sh2m(TXTVisitDate.Text).ToString();
                cl.JarimeComment = txtJarimeComment.Text;
                 cl.unitNumberNazer = Convert.ToDecimal(txtunitNumberNazer.Text);
                 cl.commentdarsad = txtcommentdarsad.Text;

                return cl;
            }
            set
            {
                DataSet ds = AgreementPercentClass.GetList(value);
                DataRow dr = ds.Tables[0].Rows[0];
                TXTFineMeterOrRepeat.Text = dr["FineMeterOrRepeat"].ToString();
                TXTutilityPersent.Text = dr["utilityPersent"].ToString();
                TXTVisitDate.Text = DateConvert.m2sh(dr["VisitDate"].ToString());
                lblAgreement.Text = dr["AgreementID"].ToString();
                LblParamAgreementPercentID.Text = dr["AgreementPercentID"].ToString();
                DDSuperVisorID.SelectedValue = dr["SuperVisorID"].ToString();
                DDFineFactor.SelectedValue = dr["FineFactor"].ToString();
                DDSuperVisorID.SelectedValue = dr["SuperVisorID"].ToString();
                txtJarimeComment.Text = dr["JarimeComment"].ToString();
                DDExplainID.SelectedValue =Convert.ToInt32( dr["ExplainID"].ToString());
                txtunitNumberNazer.Text = dr["unitNumberNazer"].ToString();
                txtcommentdarsad.Text = dr["commentdarsad"].ToString();

                ds.Dispose();
            }
        }

        public void BindDD()
        {

            ClAgreement cl = new ClAgreement();
            DDAgreementID.DataSource = AgreementClass.GetList(cl);
            DDAgreementID.DataTextField = "AgreeName";
            DDAgreementID.DataValueField = "AgreementID";
            DDAgreementID.DataBind();

            DDSuperVisorID.DataSource = TaxiDAL.UsersClass.GetListNazer(null, null, null, null, null, null, "6", null, null, null, null);
            DDSuperVisorID.DataTextField = "FullNameUser";
            DDSuperVisorID.DataValueField = "UserID";
            DDSuperVisorID.DataBind();

            DDExplainID.Bind();
            CtlAgreePercentProtest1.BindDD();

            Bindtbljarime();

            DDExplainID.AutoPostBackExplan = true;
            
            
        }
        public void Bindtbljarime() {
            if (DDFineFactor.SelectedValue == "0")
                tbljarime.Visible = false;
            else
                tbljarime.Visible = true;

        }

        public bool VisibleInsertBtn
        {
            get { return btninsetlightmain.Visible; }
            set { btninsetlightmain.Visible = value; }
        }
        public bool ISNzareAli
        {
            get { return Convert.ToBoolean(lblNazerALi.Text); }
            set { lblNazerALi.Text = value.ToString();
            if (value)
                btninsetlightmain.Style.Add("display","none")   ;
                else
                btninsetlightmain.Style.Add("display", "inherit");
              }
        }
        
        public bool NotDefaultAgree
        {
            get { return ragree.Visible; }
            set { ragree.Visible = value; }
        }
        public void Setpeymankar()
        {
            GridView1.Columns[1].Visible = false;
            GridView1.Columns[2].Visible = false;
            BtnInsert.Visible = false;
            btnSerachLight.Visible = false;
          //  btninsetlightmain.visible = false;
            btninsetlightmain.Visible = false;
              CtlAgreePercentProtest1.SetPeymankar2();
        }
        public void SetNazer(string  nazerID ="0")
         {
             DDSuperVisorID.SelectedValue = nazerID.ToString();
             DDSuperVisorID.Enabled = false;
              CtlAgreePercentProtest1.vvdd = false;
          }


        public int AgreementID
        {
            get { return Convert.ToInt32(lblAgreement.Text); }
            set { lblAgreement.Text = value.ToString();
            DDExplainID.AgreementID = value;
            DDExplainID.OnlyActive = 1;
            }
        }

        public int AgreementPercentID
        {
            get { return Convert.ToInt32(LblParamAgreementPercentID.Text); }
            set { LblParamAgreementPercentID.Text = value.ToString(); }
        }
        private void RowColor()
        {
            GridViewRow gr=null;
            Label lbl=null;
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
              
    


            }
        }

        public void BindGrid()
        {
            ClAgreementPercent cl = new ClAgreementPercent();
           

            //if (NotDefaultAgree == false)
            //    cl.AgreementID = 0;
            //else
                cl.AgreementID = Convert.ToInt32(AgreementID);
           

            cl.ExplainID = DDExplainID.SelectedValue;


                
            DataSet ds = AgreementPercentClass.GetList(cl);
            DataView dv = new DataView(ds.Tables[0]);
            if (ViewState["AgreementPercentID"] == null)
            {
                ViewState["AgreementPercentID"] = "AgreementPercentID Desc";
            }
            dv.Sort = Securenamespace.SecureData.CheckSecurity(ViewState["AgreementPercentID"].ToString()).ToString();
            GridView1.DataSource = dv;
            GridView1.DataBind();

            //if(ds.Tables[0].Rows.Count>0)
            txtunitNumberNazer.Text = unitNumberDEfault(Convert.ToInt32(AgreementID),Convert.ToInt32(DDExplainID.SelectedValue)).ToString();
             LBLunitNumberNazer.Text = unitNumberDEfault(Convert.ToInt32(AgreementID), Convert.ToInt32(DDExplainID.SelectedValue)).ToString();

            
            RowColor();
            ds.Dispose();
        }
        private string  unitNumberDEfault(int agreeid, int explanid)
        {
            string o = "0";
            ClExplanSubject cl = new ClExplanSubject();
            cl.AgreeMentID = agreeid;
            cl.ExplainSubjectID = explanid;
            cl.SubjectID =Convert.ToInt32( DDExplainID.SubjectID=="" ?"0":DDExplainID.SubjectID);
            DataSet ds = ExplanSubjectClass.GetListUnitNumberAgreeExpal(cl);
            if (ds.Tables[0].Rows.Count > 0)
                o=  ds.Tables[0].Rows[0]["unitnumberkol"].ToString() ;
            else
                o= "0";

            if (ds.Tables[0].Rows.Count > 0)
            {
                
                if (ds.Tables[0].Rows[0]["RotinOrNot"].ToString() == "1")
                    lblRotinOrNott.Text= "1";
                  //  txtunitNumberNazer.Enabled = false;
                else
                    lblRotinOrNott.Text = "0";
                
                  //  txtunitNumberNazer.Enabled = true;
            }


            ds.Dispose();
            return o;
            

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
                LblMsg.Text = " error ";
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

        public void UpItem(object sender, EventArgs e)
        {
            String AgreementPercentID = ((HtmlAnchor)sender).HRef.ToString();
            LblParamAgreementPercentID.Text = AgreementPercentID;
            ClAgreementPercent cl = new ClAgreementPercent();
            cl.AgreementPercentID = Convert.ToInt32(AgreementPercentID);
            Data = cl;
            LightBox.Value = "1";

        }
        public bool visibleDelClo{
            get { return GridView1.Columns[1].Visible; }
            set { GridView1.Columns[1].Visible = value; }

    }
        public void ProtestItem(object sender, EventArgs e)
        {
           


            String AgreementPercentID = ((HtmlAnchor)sender).HRef.ToString();
            CtlAgreePercentProtest1.AgreementPercentID = Convert.ToInt32(AgreementPercentID);

           // CtlAgreePercentProtest1.BindDD();
            CtlAgreePercentProtest1.BindGrid();

            //LblParamAgreementPercentID.Text = AgreementPercentID;
            //ClAgreementPercent cl = new ClAgreementPercent();
            //cl.AgreementPercentID = Convert.ToInt32(AgreementPercentID);
            //Data = cl;
            LightBox2.Value = "1";

        }
        protected void BtnInsert_Click(Object sender, System.EventArgs e)
        {


            if (Convert.ToDecimal(TXTutilityPersent.Text) > 100 || Convert.ToDecimal(TXTutilityPersent.Text) < 0)
            {
                CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "درصد وارده باید از 100 کوچکتر باشد");
                return;
            }
            if (Convert.ToDecimal(txtunitNumberNazer.Text) > Convert.ToDecimal(LBLunitNumberNazer.Text) && lblRotinOrNott.Text == "1")
            {
                CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "متراژ نباید از " + LBLunitNumberNazer.Text.ToString() + "  بیشتر باشد. ");
                return;
            }


            ClAgreementPercent cl = new ClAgreementPercent();
            cl = Data;

            int t = 0;
            if (CSharp.PublicFunction.ModeInsert(LblParamAgreementPercentID.Text))
                t = AgreementPercentClass.insert(cl);
            else
                t = AgreementPercentClass.Update(cl);

            if (t == 0)
            {
                LblMsg.ForeColor = System.Drawing.Color.Red;
                LblMsg.Text = "خطا در ثبت";
            }
            else if (t == -1)
            {
                CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "سقف ثبت بازدید تکمیل شده است");
            }
            else if (t == -2)
            {
                CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "برای این شرح کار در این تاریخ درصد ثبت شده است");
            }
            else if (t == -3)
                CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "فقط ناظر مقیم و مدیر سیستم میتوانند درصد وارد نمایند");
            else if (t == -4)
                CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "تا 48 ساعت قبل شما مجاز به ورود درصد هستید");
            else if (t == -10)
                CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "بیشتر از 10 درصد نمیتوان ویرایش کرد");
            else if (t == -11 || t == -12|| t == -13|| t == -14|| t == -15|| t == -16)
                CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "بازه زمانی تغییر به اتمام رسیده است");
        
            else
            {
                LblMsg.ForeColor = System.Drawing.Color.Green;
                LblMsg.Text = "ثبت  انجام شد.";
                BindGrid();
            }
            LightBox.Value = "0";
            LblParamAgreementPercentID.Text = "0";
        }

        protected void BtnSerach_Click(object sender, EventArgs e)
        {
            DataSet ds = AgreementPercentClass.GetList(Data);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            LightBox.Value = "0";

        }

        protected void DDFineFactor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bindtbljarime();
        }

    }
}