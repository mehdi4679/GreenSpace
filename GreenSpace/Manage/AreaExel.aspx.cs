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
    public partial class AreaExel : System.Web.UI.Page
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
                ClPeymanPark cl=new ClPeymanPark();
                cl.AgreementID =Convert.ToInt32( ddPeyman.SelectedValue);
                cl.PeymanID = Convert.ToInt32(ddPeyman2.SelectedValue);

                DataSet ds = PeymanParkClass.GetList(cl);
                Grid1.DataSource = ds;
                Grid1.DataBind();
                BindGridContetnt2();
            }

         private void BindGridContetnt2()
          {
              int ParkID = 0;
            ClArea cl=new ClArea();
            cl.PeymanID =Convert.ToInt32( ddPeyman2.SelectedValue);
            cl.AgreementID = Convert.ToInt32(ddPeyman.SelectedValue);

            GridViewRow grow ;
            for (int i = 0; i < Grid1.Rows.Count; i++)
            {
                grow = Grid1.Rows[i];
                ParkID=Convert.ToInt32( ((grow.FindControl("lblPark") as Label).Text));
                cl.ParkID = Convert.ToInt32(ParkID);

               DataSet ds = AreaClass.GetList(cl);


                Label txtChaman_Kol = grow.FindControl("txtChaman_Kol") as Label;
                TextBox txtChamanAbDasti = grow.FindControl("txtChamanAbDasti") as TextBox;
                TextBox txtChamanPSA = grow.FindControl("txtChamanPSA") as TextBox;
                TextBox txtChamanPGP = grow.FindControl("txtChamanPGP") as TextBox;

                Label txtParchinKol = grow.FindControl("LblParchin_Kol") as Label;
                TextBox txtParchinAbChah = grow.FindControl("txtParchinAbChah") as TextBox;
                TextBox txtParchinShilang = grow.FindControl("txtParchinShilang") as TextBox;
                TextBox txtParchinFeshar = grow.FindControl("txtParchinFeshar") as TextBox;

                Label txt_Poshesh_KOL = grow.FindControl("txt_Poshesh_KOL") as Label;
                TextBox txtPoshesh_SHILANG = grow.FindControl("txtPoshesh_SHILANG") as TextBox;
                TextBox txtPoshesh_Feshar = grow.FindControl("txtPoshesh_Feshar") as TextBox;

                Label txt_Fasli_KOL = grow.FindControl("txt_Fasli_KOL") as Label;
                TextBox txtFasli_SHILANG = grow.FindControl("txtFasli_SHILANG") as TextBox;
                TextBox txtFasli_Feshar = grow.FindControl("txtFasli_Feshar") as TextBox;

                Label txt_ROz_KOL = grow.FindControl("txt_ROz_KOL") as Label;
                TextBox txtROz_SHILANG = grow.FindControl("txtROz_SHILANG") as TextBox;
                TextBox txtROz_Feshar = grow.FindControl("txtROz_Feshar") as TextBox;

                TextBox txtROz = grow.FindControl("txtROz") as TextBox;
                TextBox txtROzDerakht = grow.FindControl("txtROzDerakht") as TextBox;

                Label txt_drakht_KOL = grow.FindControl("txt_drakht_KOL") as Label;
                TextBox txtdrakht_AbChah = grow.FindControl("txtdrakht_AbChah") as TextBox;
                TextBox txtdrakht_Tashtak = grow.FindControl("txtdrakht_Tashtak") as TextBox;
                TextBox txt_drakht_Shilang = grow.FindControl("txt_drakht_Shilang") as TextBox;
                TextBox txtdrakht_Feshar = grow.FindControl("txtdrakht_Feshar") as TextBox;
                TextBox txtdrakht_Tanker = grow.FindControl("txtdrakht_Tanker") as TextBox;
                TextBox txtHashieKhiaban = grow.FindControl("txtHashieKhiaban") as TextBox;
         


                for (int t = 0; t < ds.Tables[0].Rows.Count; t++)
                {

                    ////////چمن/متر مربع 				

                    if (ds.Tables[0].Rows[t]["ParkID"].ToString() == ParkID.ToString())
                    {
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "15" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9017")
                            txtChamanAbDasti.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "15" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9015")
                            txtChamanPSA.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "15" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9019")
                            txtChamanPGP.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        txtChaman_Kol.Text = (
                            Convert.ToDecimal(txtChamanAbDasti.Text == "" ? "0" : txtChamanAbDasti.Text) +
                            Convert.ToDecimal(txtChamanPSA.Text == "" ? "0" : txtChamanPSA.Text) +
                            Convert.ToDecimal(txtChamanPGP.Text == "" ? "0" : txtChamanPGP.Text)).ToString();


                        //////////////////پرچینی /متر مربع 				

                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "2" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9041")
                            txtParchinAbChah.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "2" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9043")
                            txtParchinShilang.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "2" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9323")
                            txtParchinFeshar.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        txtParchinKol.Text = (
                            Convert.ToDecimal(txtParchinAbChah.Text == "" ? "0" : txtParchinAbChah.Text) +
                            Convert.ToDecimal(txtParchinShilang.Text == "" ? "0" : txtParchinShilang.Text) +
                            Convert.ToDecimal(txtParchinFeshar.Text == "" ? "0" : txtParchinFeshar.Text)  
                      ).ToString();



                        /////////پوششی/مترمربع			
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "10" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9061")
                            txtPoshesh_SHILANG.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "10" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9013")
                            txtPoshesh_Feshar.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        txt_Poshesh_KOL.Text = (
                            Convert.ToDecimal(txtPoshesh_Feshar.Text == "" ? "0" : txtPoshesh_Feshar.Text)
                            + Convert.ToDecimal(txtPoshesh_SHILANG.Text == "" ? "0" : txtPoshesh_SHILANG.Text)).ToString();

                        /////////گل فصلی / متر مربع 			
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "12" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9077")
                            txtFasli_SHILANG.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "12" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9073")
                            txtFasli_Feshar.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        txt_Fasli_KOL.Text = (
                            Convert.ToDecimal(txtFasli_SHILANG.Text == "" ? "0" : txtFasli_SHILANG.Text) +
                            Convert.ToDecimal(txtFasli_Feshar.Text == "" ? "0" : txtFasli_Feshar.Text)).ToString();

                        /////////رز و درختچه زینتی / متر مربع 					
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "13" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9097")
                            txtROz_SHILANG.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "13" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9095")
                            txtROz_Feshar.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        txt_ROz_KOL.Text = (
                            Convert.ToDecimal(txtROz_SHILANG.Text == "" ? "0" : txtROz_SHILANG.Text)
                            + Convert.ToDecimal(txtROz_Feshar.Text == "" ? "0" : txtROz_Feshar.Text)).ToString();

                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "13" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9333")
                            txtROz.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "13" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9334")
                            txtROzDerakht.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();



                        /////////درخت معابر و جنگلی داخل محدوده / متر مربع 						
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "14" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9114")
                            txtdrakht_AbChah.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "14" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9118")
                            txtdrakht_Tashtak.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "14" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9120")
                            txt_drakht_Shilang.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "14" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9116")
                            txtdrakht_Feshar.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "14" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9122")
                            txtdrakht_Tanker.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "14" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9335")
                            txtHashieKhiaban.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();

                        txt_drakht_KOL.Text = (
                                  Convert.ToDecimal(txtdrakht_AbChah.Text == "" ? "0" : txtdrakht_AbChah.Text)
                                + Convert.ToDecimal(txtdrakht_Tashtak.Text == "" ? "0" : txtdrakht_Tashtak.Text)
                                + Convert.ToDecimal(txtdrakht_Feshar.Text == "" ? "0" : txtdrakht_Feshar.Text)
                                + Convert.ToDecimal(txt_drakht_Shilang.Text == "" ? "0" : txt_drakht_Shilang.Text)
                                + Convert.ToDecimal(txtdrakht_Tanker.Text == "" ? "0" : txtdrakht_Tanker.Text).ToString() 
                                + Convert.ToDecimal(txtHashieKhiaban.Text == "" ? "0" : txtHashieKhiaban.Text)).ToString();

                        /////////////////////////////////////////////////////////

                    }
                }

                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtHashieKhiabanSum"), txtHashieKhiaban);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtchamanDastiSum"), txtChamanAbDasti);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtchamanPSASum"), txtChamanPSA);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtchamanPGPSum"), txtChamanPGP);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtparchinAbChahSum"), txtParchinAbChah);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtParchinShilangSum"), txtParchinShilang);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtParchinFesharSum"), txtParchinFeshar);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtPosheshiShilangSum"), txtPoshesh_SHILANG);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtPosheshiFesharSum"), txtPoshesh_Feshar);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtGolfasliFesharSum"), txtFasli_Feshar);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtRozShilangSum"), txtROz_SHILANG);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtRozfesharSum"), txtROz_Feshar);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtderakhtchahSum"), txtdrakht_AbChah);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtderakhttashtakSum"), txtdrakht_Tashtak);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtderakhtshilangsum"), txt_drakht_Shilang);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtderakhtfesharSum"), txtdrakht_Feshar);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtderakhttankerSum"), txtdrakht_Tanker);


                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtGolfasliShilangSum"), txtFasli_SHILANG);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtRozSum"), txtROz);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtRozderakhtSum"), txtROzDerakht);

                ds.Dispose();
            }
            }

        private void BindGridContetnt()
          {
              int ParkID = 0;
            ClArea cl=new ClArea();
            cl.PeymanID =Convert.ToInt32( ddPeyman2.SelectedValue);
            cl.AgreementID = Convert.ToInt32(ddPeyman.SelectedValue);

            DataSet ds = AreaClass.GetList(cl);
            GridViewRow grow ;
            for (int i = 0; i < Grid1.Rows.Count; i++)
            {
                grow = Grid1.Rows[i];

                Label txtChaman_Kol = grow.FindControl("txtChaman_Kol") as Label;
                TextBox txtChamanAbDasti = grow.FindControl("txtChamanAbDasti") as TextBox;
                TextBox txtChamanPSA = grow.FindControl("txtChamanPSA") as TextBox;
                TextBox txtChamanPGP = grow.FindControl("txtChamanPGP") as TextBox;

                Label txtParchinKol = grow.FindControl("LblParchin_Kol") as Label;
                TextBox txtParchinAbChah = grow.FindControl("txtParchinAbChah") as TextBox;
                TextBox txtParchinShilang = grow.FindControl("txtParchinShilang") as TextBox;
                TextBox txtParchinFeshar = grow.FindControl("txtParchinFeshar") as TextBox;

                Label txt_Poshesh_KOL = grow.FindControl("txt_Poshesh_KOL") as Label;
                TextBox txtPoshesh_SHILANG = grow.FindControl("txtPoshesh_SHILANG") as TextBox;
                TextBox txtPoshesh_Feshar = grow.FindControl("txtPoshesh_Feshar") as TextBox;

                Label txt_Fasli_KOL = grow.FindControl("txt_Fasli_KOL") as Label;
                TextBox txtFasli_SHILANG = grow.FindControl("txtFasli_SHILANG") as TextBox;
                TextBox txtFasli_Feshar = grow.FindControl("txtFasli_Feshar") as TextBox;

                Label txt_ROz_KOL = grow.FindControl("txt_ROz_KOL") as Label;
                TextBox txtROz_SHILANG = grow.FindControl("txtROz_SHILANG") as TextBox;
                TextBox txtROz_Feshar = grow.FindControl("txtROz_Feshar") as TextBox;

                TextBox txtROz = grow.FindControl("txtROz") as TextBox;
                TextBox txtROzDerakht = grow.FindControl("txtROzDerakht") as TextBox;

                Label txt_drakht_KOL = grow.FindControl("txt_drakht_KOL") as Label;
                TextBox txtdrakht_AbChah = grow.FindControl("txtdrakht_AbChah") as TextBox;
                TextBox txtdrakht_Tashtak = grow.FindControl("txtdrakht_Tashtak") as TextBox;
                TextBox txt_drakht_Shilang = grow.FindControl("txt_drakht_Shilang") as TextBox;
                TextBox txtdrakht_Feshar = grow.FindControl("txtdrakht_Feshar") as TextBox;
                TextBox txtdrakht_Tanker = grow.FindControl("txtdrakht_Tanker") as TextBox;
          


                ParkID=Convert.ToInt32( ((grow.FindControl("lblPark") as Label).Text));
                for (int t = 0; t < ds.Tables[0].Rows.Count; t++)
                {

                    ////////چمن/متر مربع 				

                    if (ds.Tables[0].Rows[t]["ParkID"].ToString() == ParkID.ToString())
                    {
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "15" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9017")
                            txtChamanAbDasti.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "15" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9015")
                            txtChamanPSA.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "15" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9019")
                            txtChamanPGP.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        txtChaman_Kol.Text = (
                            Convert.ToDecimal(txtChamanAbDasti.Text == "" ? "0" : txtChamanAbDasti.Text) +
                            Convert.ToDecimal(txtChamanPSA.Text == "" ? "0" : txtChamanPSA.Text) +
                            Convert.ToDecimal(txtChamanPGP.Text == "" ? "0" : txtChamanPGP.Text)).ToString();


                        //////////////////پرچینی /متر مربع 				

                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "2" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9041")
                            txtParchinAbChah.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "2" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9043")
                            txtParchinShilang.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "2" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9323")
                            txtParchinFeshar.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        txtParchinKol.Text = (
                            Convert.ToDecimal(txtParchinAbChah.Text == "" ? "0" : txtParchinAbChah.Text) +
                            Convert.ToDecimal(txtParchinShilang.Text == "" ? "0" : txtParchinShilang.Text) +
                            Convert.ToDecimal(txtParchinFeshar.Text == "" ? "0" : txtParchinFeshar.Text)  
                      ).ToString();



                        /////////پوششی/مترمربع			
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "10" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9061")
                            txtPoshesh_SHILANG.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "10" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9013")
                            txtPoshesh_Feshar.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        txt_Poshesh_KOL.Text = (
                            Convert.ToDecimal(txtPoshesh_Feshar.Text == "" ? "0" : txtPoshesh_Feshar.Text)
                            + Convert.ToDecimal(txtPoshesh_SHILANG.Text == "" ? "0" : txtPoshesh_SHILANG.Text)).ToString();

                        /////////گل فصلی / متر مربع 			
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "12" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9077")
                            txtFasli_SHILANG.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "12" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9073")
                            txtFasli_Feshar.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        txt_Fasli_KOL.Text = (
                            Convert.ToDecimal(txtFasli_SHILANG.Text == "" ? "0" : txtFasli_SHILANG.Text) +
                            Convert.ToDecimal(txtFasli_Feshar.Text == "" ? "0" : txtFasli_Feshar.Text)).ToString();

                        /////////رز و درختچه زینتی / متر مربع 					
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "13" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9097")
                            txtROz_SHILANG.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "13" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9095")
                            txtROz_Feshar.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        txt_ROz_KOL.Text = (
                            Convert.ToDecimal(txtROz_SHILANG.Text == "" ? "0" : txtROz_SHILANG.Text)
                            + Convert.ToDecimal(txtROz_Feshar.Text == "" ? "0" : txtROz_Feshar.Text)).ToString();

                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "13" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9333")
                            txtROz.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "13" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9334")
                            txtROzDerakht.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();



                        /////////درخت معابر و جنگلی داخل محدوده / متر مربع 						
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "14" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9114")
                            txtdrakht_AbChah.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "14" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9118")
                            txtdrakht_Tashtak.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "14" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9120")
                            txt_drakht_Shilang.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "14" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9116")
                            txtdrakht_Feshar.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "14" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9122")
                            txtdrakht_Tanker.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        txt_drakht_KOL.Text = (
                                  Convert.ToDecimal(txtdrakht_AbChah.Text == "" ? "0" : txtdrakht_AbChah.Text)
                                + Convert.ToDecimal(txtdrakht_Tashtak.Text == "" ? "0" : txtdrakht_Tashtak.Text)
                                + Convert.ToDecimal(txtdrakht_Feshar.Text == "" ? "0" : txtdrakht_Feshar.Text)
                                + Convert.ToDecimal(txt_drakht_Shilang.Text == "" ? "0" : txt_drakht_Shilang.Text)
                                + Convert.ToDecimal(txtdrakht_Tanker.Text == "" ? "0" : txtdrakht_Tanker.Text)).ToString();

                        /////////////////////////////////////////////////////////

                    }
                }
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtchamanDastiSum"), txtChamanAbDasti);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtchamanPSASum"), txtChamanPSA);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtchamanPGPSum"), txtChamanPGP);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtparchinAbChahSum"), txtParchinAbChah);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtParchinShilangSum"), txtParchinShilang);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtParchinFesharSum"), txtParchinFeshar);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtPosheshiShilangSum"), txtPoshesh_SHILANG);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtPosheshiFesharSum"), txtPoshesh_Feshar);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtGolfasliFesharSum"), txtFasli_Feshar);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtRozShilangSum"), txtFasli_SHILANG);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtRozfesharSum"), txtROz_Feshar);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtderakhtchahSum"), txtdrakht_AbChah);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtderakhttashtakSum"), txtdrakht_Tashtak);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtderakhtshilangsum"), txt_drakht_Shilang);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtderakhtfesharSum"), txtdrakht_Feshar);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtderakhttankerSum"), txtdrakht_Tanker);
              

            }
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


        protected void ddPeyman_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindPeyman2();
            BindGrid();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            GridViewRow grow;
            for (int i = 0; i < Grid1.Rows.Count; i++)
            {
                grow = Grid1.Rows[i];
                Label txtChaman_Kol = grow.FindControl("txtChaman_Kol") as Label;
                TextBox txtChamanAbDasti = grow.FindControl("txtChamanAbDasti") as TextBox;
                TextBox txtChamanPSA = grow.FindControl("txtChamanPSA") as TextBox;
                TextBox txtChamanPGP = grow.FindControl("txtChamanPGP") as TextBox;

                Label txtParchinKol = grow.FindControl("LblParchin_Kol") as Label;
                TextBox txtParchinAbChah = grow.FindControl("txtParchinAbChah") as TextBox;
                TextBox txtParchinShilang = grow.FindControl("txtParchinShilang") as TextBox;
                TextBox txtParchinFeshar = grow.FindControl("txtParchinFeshar") as TextBox;

                Label txt_Poshesh_KOL = grow.FindControl("txt_Poshesh_KOL") as Label;
                TextBox txtPoshesh_SHILANG = grow.FindControl("txtPoshesh_SHILANG") as TextBox;
                TextBox txtPoshesh_Feshar = grow.FindControl("txtPoshesh_Feshar") as TextBox;

                Label txt_Fasli_KOL = grow.FindControl("txt_Fasli_KOL") as Label;
                TextBox txtFasli_SHILANG = grow.FindControl("txtFasli_SHILANG") as TextBox;
                TextBox txtFasli_Feshar = grow.FindControl("txtFasli_Feshar") as TextBox;

                Label txt_ROz_KOL = grow.FindControl("txt_ROz_KOL") as Label;
                TextBox txtROz_SHILANG = grow.FindControl("txtROz_SHILANG") as TextBox;
                TextBox txtROz_Feshar = grow.FindControl("txtROz_Feshar") as TextBox;

                TextBox txtROz= grow.FindControl("txtROz") as TextBox;
                TextBox txtROzderakht = grow.FindControl("txtROzDerakht") as TextBox;

                Label txt_drakht_KOL = grow.FindControl("txt_drakht_KOL") as Label;
                TextBox txtdrakht_AbChah = grow.FindControl("txtdrakht_AbChah") as TextBox;
                TextBox txtdrakht_Tashtak = grow.FindControl("txtdrakht_Tashtak") as TextBox;
                TextBox txt_drakht_Shilang = grow.FindControl("txt_drakht_Shilang") as TextBox;
                TextBox txtdrakht_Feshar = grow.FindControl("txtdrakht_Feshar") as TextBox;
                TextBox txtdrakht_Tanker = grow.FindControl("txtdrakht_Tanker") as TextBox;
                TextBox txtHashieKhiaban = grow.FindControl("txtHashieKhiaban") as TextBox;

              int  ParkID = Convert.ToInt32(((grow.FindControl("lblPark") as Label).Text));

           
                /////چمن/متر مربع 15				
//////////////////////////////////////////////////////////////////////////////////////////
              SaveArea(ParkID, 15, 9017, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtChamanAbDasti.Text, txtChamanAbDasti);
                SaveArea(ParkID, 15, 9018, Convert.ToInt32(ddPeyman.SelectedValue),0, txtChamanAbDasti.Text,txtChamanAbDasti);
                SaveArea(ParkID, 15, 9015, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtChamanPSA.Text, txtChamanPSA);
                SaveArea(ParkID, 15, 9016, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtChamanPSA.Text, txtChamanPSA);
                SaveArea(ParkID, 15, 9019, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtChamanPGP.Text, txtChamanPGP);
                SaveArea(ParkID, 15, 9020, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtChamanPGP.Text, txtChamanPGP);
//////////////////////////////////////////////////////////////////////////////////////////
                /////پرچینی /متر مربع 2				
                SaveArea(ParkID, 2, 9041, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtParchinAbChah.Text, txtParchinAbChah);
                SaveArea(ParkID, 2, 9042, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtParchinAbChah.Text, txtParchinAbChah);
                SaveArea(ParkID, 2, 9043, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtParchinShilang.Text, txtParchinShilang);
                SaveArea(ParkID, 2, 9044, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtParchinShilang.Text, txtParchinShilang);
                SaveArea(ParkID, 2, 9040, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtParchinFeshar.Text, txtParchinFeshar);
                SaveArea(ParkID, 2, 9323, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtParchinFeshar.Text, txtParchinFeshar);
//////////////////////////////////////////////////////////////////////////////////////////
                /////پوششی/مترمربع 2 			
                SaveArea(ParkID, 10, 9061, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtPoshesh_SHILANG.Text,txtPoshesh_SHILANG);
                SaveArea(ParkID, 10, 9062, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtPoshesh_SHILANG.Text,txtPoshesh_SHILANG);
                SaveArea(ParkID, 10, 9013, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtPoshesh_Feshar.Text,txtPoshesh_Feshar);
                SaveArea(ParkID, 10, 9014, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtPoshesh_Feshar.Text,txtPoshesh_Feshar);
//////////////////////////////////////////////////////////////////////////////////////////
                /////گل فصلی / متر مربع 12			
                 SaveArea(ParkID, 12, 9077, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtFasli_SHILANG.Text,txtFasli_SHILANG);
                 SaveArea(ParkID, 12, 9078, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtFasli_SHILANG.Text,txtFasli_SHILANG);
                SaveArea(ParkID, 12, 9073, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtFasli_Feshar.Text,txtFasli_Feshar);
                SaveArea(ParkID, 12, 9074, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtFasli_Feshar.Text,txtFasli_Feshar);
//////////////////////////////////////////////////////////////////////////////////////////
                /////رز و درختچه زینتی / متر مربع 13					
                 SaveArea(ParkID, 13, 9097, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtROz_SHILANG.Text,txtROz_SHILANG);
                 SaveArea(ParkID, 13, 9098, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtROz_SHILANG.Text,txtROz_SHILANG);
                SaveArea(ParkID, 13, 9095, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtROz_Feshar.Text,txtROz_Feshar);
                SaveArea(ParkID, 13, 9096, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtROz_Feshar.Text,txtROz_Feshar);

                SaveArea(ParkID, 13, 9333, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtROz.Text, txtROz);
                SaveArea(ParkID, 13, 9334, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtROzderakht.Text, txtROzderakht);

                //////////////////////////////////////////////////////////////////////////////////////////
                /////14درخت معابر و جنگلی داخل محدوده / متر مربع 						
                 SaveArea(ParkID, 14, 9114, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtdrakht_AbChah.Text,txtdrakht_AbChah);
                 SaveArea(ParkID, 14, 9115, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtdrakht_AbChah.Text,txtdrakht_AbChah);
                SaveArea(ParkID, 14, 9118, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtdrakht_Tashtak.Text,txtdrakht_Tashtak);
                SaveArea(ParkID, 14, 9119, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtdrakht_Tashtak.Text,txtdrakht_Tashtak);
                 SaveArea(ParkID, 14, 9120, Convert.ToInt32(ddPeyman.SelectedValue), 0, txt_drakht_Shilang.Text,txt_drakht_Shilang);
                 SaveArea(ParkID, 14, 9121, Convert.ToInt32(ddPeyman.SelectedValue), 0, txt_drakht_Shilang.Text,txt_drakht_Shilang);
                SaveArea(ParkID, 14, 9116, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtdrakht_Feshar.Text,txtdrakht_Feshar);
                SaveArea(ParkID, 14, 9117, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtdrakht_Feshar.Text,txtdrakht_Feshar);
                 SaveArea(ParkID, 14, 9122, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtdrakht_Tanker.Text,txtdrakht_Tanker);
                 SaveArea(ParkID, 14, 9335, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtHashieKhiaban.Text, txtHashieKhiaban);

//////////////////////////////////////////////////////////////////////////////////////////

                //if(ddPeyman.SelectedValue=="0")
                // SaveAreaUseFromKol(ParkID);
                 if (Convert.ToInt32(ddPeyman.SelectedValue) == 0)
                 {
                     ClArea cl = new ClArea();
                     cl.ParkID = ParkID;
                     cl.AgreementID = 0;
                     int rrrttrt = AreaClass.SaveErth(cl);
                     if (rrrttrt == 0)
                         CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "خطا در ثبت عرصه از کل");
                 }
            }

        }

        public void SaveAreaUseFromKol(int ParkD)
        {
            int retval = 0;
            ClArea cl = new ClArea();
            cl.ParkID = ParkD;
            //cl.SubjectID = SubjectID;
            //cl.SubjectExplainID = ExpanID;
            //cl.AgreementID = AgreementID;
            //cl.AreaID = AreaID;
            //cl.UnitNumber = UnitNumber.ToString();

            retval = AreaClass.Save2(cl);

        }

        private int SaveArea(int ParkD, int SubjectID, int ExpanID,int AgreementID,int AreaID ,string  UnitNumber,TextBox t)
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

        protected void ddPeyman2_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();
        }



    }
}