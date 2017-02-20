using GreenSpaceCL;
using GreenSpaceDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GreenSpace.Manage
{
    public partial class AreaAll : System.Web.UI.Page
    {

        protected void TXTExplanID_ButtonClick(object sender, EventArgs e)
{
    //handle the event 
    BindGrid();

}

        protected void Page_Load(object sender, EventArgs e)
        {
                TXTExplanID.ButtonClick += new EventHandler(TXTExplanID_ButtonClick);

            if(!Page.IsPostBack){
                TXTExplanID.BindDD();
                BindDD();
                BindGrid();

            }
 

        }
        private void BindDD()
        {
            ClAgreement cl = new ClAgreement();
            DataSet ds = AgreementClass.GetList(cl);
            ddagree.DataSource = ds;
            ddagree.DataTextField = "AggreeName";
            ddagree.DataValueField = "AgreementID";
            ddagree.DataBind();
            ddagree.Items.Insert(0, new ListItem("پیش فرض", "0"));

            BindPeyman2();
        }
        private void BindPeyman2()
        {
            ClPeyman cl = new ClPeyman();
            DataSet ds = PeymanClass.GetList(cl);
            ddPeyman.DataSource = ds;
            ddPeyman.DataTextField = "PeymanName";
            ddPeyman.DataValueField = "PeymanID";
            ddPeyman.DataBind();
            if (ddagree.SelectedValue != "0")
            {
                //ClPeymanPark cl2 = new ClPeymanPark();
                //cl2.AgreementID = Convert.ToInt32(ddPeyman.SelectedValue);
                //DataSet ds2 = PeymanParkClass.GetList(cl2);
                //ddPeyman2.SelectedValue = ds2.Tables[0].Rows[0]["PeymanID"].ToString();
                //ddPeyman2.Enabled = false;
                ClAgreement cl2 = new ClAgreement();
                cl2.AgreementID = Convert.ToInt32(ddagree.SelectedValue);
                DataSet ds2 = AgreementClass.GetList(cl2);
                if(ds2.Tables[0].Rows.Count>0)
                ddPeyman.SelectedValue = ds2.Tables[0].Rows[0]["PeymanID"].ToString();
                ddPeyman.Enabled = false;

            }
            else
                ddPeyman.Enabled = true;

        }

        private void BindGrid()
        {
            ClPeymanPark cl = new ClPeymanPark();
            cl.AgreementID = Convert.ToInt32(ddagree.SelectedValue=="" ? "0":ddagree.SelectedValue) ;
            cl.PeymanID = Convert.ToInt32(ddPeyman.SelectedValue);
            cl.ExplanSubject =Convert.ToInt32(TXTExplanID.SelectedValue);
             

            DataSet ds = PeymanParkClass.GetListpark(cl);
            Grid1.DataSource = ds;
            Grid1.DataBind();
            lblsumkol.Text = SumKol(ds).ToString();
         }
        private decimal  SumKol(DataSet ds){
            decimal  yield=0;
            for (int i=0;i<ds.Tables[0].Rows.Count;i++){
                yield += Convert.ToDecimal(ds.Tables[0].Rows[i]["UnitNumber"].ToString()==""?"0":ds.Tables[0].Rows[i]["UnitNumber"].ToString());
            }
            return yield;
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            GridViewRow grow;
            int ii = 0;
            for (int i = 0; i < Grid1.Rows.Count; i++)
            {
                grow = Grid1.Rows[i];
                TextBox txtunitNumber = grow.FindControl("txtUniteNumber") as TextBox;
                Label LblParkID = grow.FindControl("lblPakID") as Label;
                Label LblAreaID = grow.FindControl("LblAreaID") as Label;
                Label LblUseFromKol = grow.FindControl("LblUseFromKol") as Label;

                ii= SaveArea(Convert.ToInt32(LblParkID.Text), Convert.ToInt32(TXTExplanID.subjectID), Convert.ToInt32(TXTExplanID.SelectedValue), Convert.ToInt32(ddagree.SelectedValue),Convert.ToInt32(LblAreaID.Text==""?"0":LblAreaID.Text) , txtunitNumber.Text, txtunitNumber);
             //   SaveErth(Convert.ToInt32(LblParkID.Text),Convert.ToInt32(LblUseFromKol.Text==""?"0":LblUseFromKol.Text));

             }
            
          }

        public void SaveErth(int pid,int useFromKol)
        {
             
                ClArea cl = new ClArea();
                cl.ParkID = pid;
                cl.AgreementID =Convert.ToInt32( ddagree.SelectedValue);
                int rrrttrt = AreaClass.SaveErth(cl);
                if (rrrttrt == 0)
                    CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "خطا در ثبت عرصه از کل");

                BindGrid();
        }


        private int SaveArea(int ParkD, int SubjectID, int ExpanID, int AgreementID, int AreaID, string UnitNumber, TextBox t)
        {
            if (AreaID == null)
                AreaID = 0;
            if (UnitNumber == null)
                UnitNumber = "";

            if (UnitNumber != "")
            {
                int retval = 0;
                ClArea cl = new ClArea();
                cl.ParkID = ParkD;
                cl.SubjectID = SubjectID;
                cl.SubjectExplainID = ExpanID;
                cl.AgreementID = AgreementID;
                cl.AreaID = AreaID;
                cl.UnitNumber = UnitNumber.ToString();

                retval = AreaClass.Save(cl);


                if (retval <= 0)
                    t.BackColor = System.Drawing.Color.Purple;
                else
                    t.BackColor = System.Drawing.Color.LightGreen;



                return retval;
            }
            else
                return 1;
        }

        protected void ddPeyman_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindPeyman2();
            BindGrid();
        }

        protected void ddPeyman_SelectedIndexChanged1(object sender, EventArgs e)
        {
            BindGrid();
        }

        protected void btnShoww_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridViewRow grow;
            int ii = 0;
            for (int i = 0; i < Grid1.Rows.Count; i++)
            {
                grow = Grid1.Rows[i];
                TextBox txtunitNumber = grow.FindControl("txtUniteNumber") as TextBox;
                Label LblParkID = grow.FindControl("lblPakID") as Label;
                Label LblAreaID = grow.FindControl("LblAreaID") as Label;
                Label LblUseFromKol = grow.FindControl("LblUseFromKol") as Label;

                SaveErth(Convert.ToInt32(LblParkID.Text), Convert.ToInt32(LblUseFromKol.Text == "" ? "0" : LblUseFromKol.Text));

            }

            ClArea cl = new ClArea();
             cl.AgreementID = Convert.ToInt32(ddagree.SelectedValue);
            cl.PeymanID=Convert.ToInt32(ddPeyman.SelectedValue);
            int rrrttrt = AreaClass.SaveKhaki(cl);
                 if (rrrttrt == 0)
                    CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "خطا در ثبت خاکی و غیر خاکی");

         }


        private string getAreaPark(int parkid)
        {
            ClPark cl = new ClPark();
            cl.ParkID = parkid;
            DataSet ds = ParkClass.GetList(cl);
            return ds.Tables[0].Rows[0]["ParkArea"].ToString();

        }
        protected void chCheckAllAreaPark_CheckedChanged(object sender, EventArgs e)
        {
             GridViewRow grow;

            int ii = 0;
            for (int i = 0; i < Grid1.Rows.Count; i++)
            {
                grow = Grid1.Rows[i];
                TextBox txtunitNumber = grow.FindControl("txtUniteNumber") as TextBox;
                Label LblParkID = grow.FindControl("lblPakID") as Label;
                if (chCheckAllAreaPark.Checked)
                    txtunitNumber.Text = getAreaPark(Convert.ToInt32(LblParkID.Text));
                else
                    txtunitNumber.Text = "";
            }
            
        }





    }
}