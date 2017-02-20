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
    public partial class AreaSakhteman : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindDD();
                BindGrid();
            }
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
        private void BindGrid()
        {
            ClPeymanPark cl = new ClPeymanPark();
            cl.AgreementID = Convert.ToInt32(ddPeyman.SelectedValue);
            cl.PeymanID = Convert.ToInt32(ddPeyman2.SelectedValue);
            DataSet ds = PeymanParkClass.GetList(cl);
            Grid1.DataSource = ds;
            Grid1.DataBind();
            BindGridContetnt2();
             


        }
        private void BindGridContetnt2()
        {
            int ParkID = 0;
            ClArea cl = new ClArea();
            cl.PeymanID = Convert.ToInt32(ddPeyman2.SelectedValue);
            cl.AgreementID = Convert.ToInt32(ddPeyman.SelectedValue);
            
            GridViewRow grow;
            for (int i = 0; i < Grid1.Rows.Count; i++)
            {
                grow = Grid1.Rows[i];

                ParkID = Convert.ToInt32(((grow.FindControl("lblPark") as Label).Text));

                cl.ParkID = ParkID;
                DataSet ds = AreaClass.GetList(cl);

                TextBox txtbohranRoz = grow.FindControl("txtbohranRoz") as TextBox;
                TextBox txtbohranSahb = grow.FindControl("txtbohranSahb") as TextBox;
                TextBox txtParkbanRoz = grow.FindControl("txtParkbanRoz") as TextBox;
                TextBox txtParkbanshab = grow.FindControl("txtParkbanshab") as TextBox;

                TextBox txtEdari = grow.FindControl("txtEdari") as TextBox;
                TextBox txtnegahbani = grow.FindControl("txtnegahbani") as TextBox;
                TextBox txtanbar = grow.FindControl("txtanbar") as TextBox;
                TextBox txt_Piadeh_GhirKhaki = grow.FindControl("txt_Piadeh_GhirKhaki") as TextBox;

                TextBox txt_Piadeh_Khaki = grow.FindControl("txt_Piadeh_Khaki") as TextBox;
                TextBox txtAbnama_Metr = grow.FindControl("txtAbnama_Metr") as TextBox;
                TextBox txtAbnama_Num = grow.FindControl("txtAbnama_Num") as TextBox;
                TextBox txtgolkhaneh = grow.FindControl("txtgolkhaneh") as TextBox;

                TextBox txt_Khazaneh = grow.FindControl("txt_Khazaneh") as TextBox;
                TextBox txtOtaghak_Chah = grow.FindControl("txtOtaghak_Chah") as TextBox;
                TextBox txtChalecode = grow.FindControl("txtChalecode") as TextBox;

                TextBox txtNimkat = grow.FindControl("txtNimkat") as TextBox;
                TextBox txtSatle_Zobale = grow.FindControl("txtSatle_Zobale") as TextBox;
                TextBox txtFasli_Feshar = grow.FindControl("txtFasli_Feshar") as TextBox;

                TextBox txtAbkhori_Datgah = grow.FindControl("txtAbkhori_Datgah") as TextBox;
                TextBox txtAbkhri_Shir = grow.FindControl("txtAbkhri_Shir") as TextBox;
                TextBox txt_FlowerBox = grow.FindControl("txt_FlowerBox") as TextBox;

                TextBox txtTandis = grow.FindControl("txtTandis") as TextBox;
                TextBox TxtBargh_Box = grow.FindControl("TxtBargh_Box") as TextBox;
                TextBox txtRoshanaei_Kotah_Paye = grow.FindControl("txtRoshanaei_Kotah_Paye") as TextBox;
                TextBox txtRoshanaei_Kotah_Sholeh = grow.FindControl("txtRoshanaei_Kotah_Sholeh") as TextBox;
                TextBox txtRoshanaei_Boland_Paye = grow.FindControl("txtRoshanaei_Boland_Paye") as TextBox;
                TextBox txtRoshanaei_Boland_Shole = grow.FindControl("txtRoshanaei_Boland_Shole") as TextBox;

                TextBox txtProject_Paye = grow.FindControl("txtProject_Paye") as TextBox;
                TextBox txtProject_Shole = grow.FindControl("txtProject_Shole") as TextBox;
                TextBox txtTablo = grow.FindControl("txtTablo") as TextBox;
                TextBox txtSharjMobile = grow.FindControl("txtSharjMobile") as TextBox;

                TextBox txtBorj_Paye = grow.FindControl("txtBorj_Paye") as TextBox;
                TextBox txtBorj_Shole = grow.FindControl("txtBorj_Shole") as TextBox;
                TextBox txtu = grow.FindControl("txtu") as TextBox;
                TextBox txtzanjir = grow.FindControl("txtzanjir") as TextBox;
                TextBox txtmileh = grow.FindControl("txtmileh") as TextBox;
                TextBox txtzanjir55 = grow.FindControl("txtzanjir55") as TextBox;
                TextBox txtZanjirSUM55 = grow.FindControl("txtZanjirSUM55") as TextBox;


                for (int t = 0; t < ds.Tables[0].Rows.Count; t++)
                {

                    ////////19سرويس بهداشتي		

                    if (ds.Tables[0].Rows[t]["ParkID"].ToString() == ParkID.ToString())
                    {

                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "57" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9338")
                            txtbohranRoz.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "57" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9339")
                            txtbohranSahb.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();

                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "58" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9340")
                            txtParkbanRoz.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "58" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9341")
                            txtParkbanshab.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        
                        
                        
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "48" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9288")
                            txtEdari.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "48" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9289")
                            txtnegahbani.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "48" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9290")
                            txtanbar.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();

                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "48" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9291")
                            txt_Piadeh_GhirKhaki.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "48" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9292")
                            txt_Piadeh_Khaki.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();

                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "48" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9293")
                            txtAbnama_Num.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "48" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9294")
                            txtAbnama_Metr.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();

                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "48" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9295")
                            txtgolkhaneh.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "48" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9296")
                            txt_Khazaneh.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "48" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9297")
                            txtOtaghak_Chah.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "48" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9298")
                            txtChalecode.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();

                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "27" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9196")
                            txtNimkat.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();

                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "24" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9191")
                            txtSatle_Zobale.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();



                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "18" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9175")
                            txtAbkhori_Datgah.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "18" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9299")
                            txtAbkhri_Shir.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();

                        //if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "18" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9299")
                        //    txtf.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "29" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9203")
                            txtTandis.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "17" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9315")
                            TxtBargh_Box.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();

                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "16" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9172")
                            txtRoshanaei_Kotah_Paye.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "16" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9173")
                            txtRoshanaei_Kotah_Sholeh.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();

                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "49" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9301")
                            txtRoshanaei_Boland_Paye.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "49" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9300")
                            txtRoshanaei_Boland_Shole.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();


                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "49" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9302")
                            txtProject_Paye.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "49" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9303")
                            txtProject_Shole.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "49" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9304")
                            txtTablo.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "49" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9305")
                            txtSharjMobile.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();


                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "49" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9306")
                            txtBorj_Paye.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "49" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9307")
                            txtBorj_Shole.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                  
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "49" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9308")
                            txtzanjir.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "49" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9309")
                            txtmileh.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "49" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9310")
                            txtu.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();

                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "49" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9311")
                            txt_FlowerBox.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();

                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "49" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9459")
                            txtzanjir55.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();



                    }
                 }

            //GridView GV1 = "Grid1";
                
                //TextBox txtedarisum = ;// (TextBox)Grid1.FindControl("txtedarisum");
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtBohranRozSum"), txtbohranRoz);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtBohranShabSum"), txtbohranSahb);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtParkbanRozSum"), txtParkbanRoz);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtParkbanShabSum"), txtParkbanshab);



                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtmobileSum"), txtSharjMobile);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtuSum"), txtu);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtmileSum"), txtmileh);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtzanjirSum"), txtzanjir);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtTabloSum"), txtTablo);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtBorjPayesum"), txtBorj_Paye);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtBorjSholesum"), txtBorj_Shole);

                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtPrejectorSholesum"), txtBorj_Shole);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtPrejectorPayesum"), txtProject_Paye);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtPrejectorSholesum"), txtProject_Shole);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtroshanBolandPeyeSum"), txtRoshanaei_Boland_Paye);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtroshanBolandSholeSum"), txtRoshanaei_Boland_Shole);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtroshanKotahPeyeSum"), txtRoshanaei_Kotah_Paye);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtBarghSum"), TxtBargh_Box);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtTandisSum"), txtTandis);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtFlowerBoxSum"), txt_FlowerBox);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtAbkhriShirAbSum"), txtAbkhri_Shir);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtAbkhriDastgahSum"), txtAbkhori_Datgah);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtSatlZobaleSum"), txtSatle_Zobale);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtNimkatSum"), txtNimkat);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtChaleKodSum"), txtChalecode);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtOtaghakChahSum"), txtOtaghak_Chah);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtKhazaneh"), txt_Khazaneh);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtGolkhanehSum"), txtgolkhaneh);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtAbnammetrNum"),txtAbnama_Num );
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtAbnammetrSum"), txtAbnama_Metr);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtkhakisum"), txt_Piadeh_Khaki);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtghirkhakisum"), txt_Piadeh_GhirKhaki);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtAnbarSum"), txtanbar);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtnegahbanisum"), txtnegahbani);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtedarisum"), txtEdari);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtZanjirSUM55"), txtzanjir55);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtroshanKotahSholeSum"), txtRoshanaei_Kotah_Sholeh);

            }


        }

        private void BindGridContetnt()
        {
            int ParkID = 0;
            ClArea cl = new ClArea();
            cl.PeymanID = Convert.ToInt32(ddPeyman2.SelectedValue);
            cl.AgreementID = Convert.ToInt32(ddPeyman.SelectedValue);
            
            DataSet ds = AreaClass.GetList(cl);
            GridViewRow grow;
            for (int i = 0; i < Grid1.Rows.Count; i++)
            {
                grow = Grid1.Rows[i];

                TextBox txtEdari = grow.FindControl("txtEdari") as TextBox;
                TextBox txtnegahbani = grow.FindControl("txtnegahbani") as TextBox;
                TextBox txtanbar = grow.FindControl("txtanbar") as TextBox;
                TextBox txt_Piadeh_GhirKhaki = grow.FindControl("txt_Piadeh_GhirKhaki") as TextBox;

                TextBox txt_Piadeh_Khaki = grow.FindControl("txt_Piadeh_Khaki") as TextBox;
                TextBox txtAbnama_Metr = grow.FindControl("txtAbnama_Metr") as TextBox;
                TextBox txtAbnama_Num = grow.FindControl("txtAbnama_Num") as TextBox;
                TextBox txtgolkhaneh = grow.FindControl("txtgolkhaneh") as TextBox;

                TextBox txt_Khazaneh = grow.FindControl("txt_Khazaneh") as TextBox;
                TextBox txtOtaghak_Chah = grow.FindControl("txtOtaghak_Chah") as TextBox;
                TextBox txtChalecode = grow.FindControl("txtChalecode") as TextBox;

                TextBox txtNimkat = grow.FindControl("txtNimkat") as TextBox;
                TextBox txtSatle_Zobale = grow.FindControl("txtSatle_Zobale") as TextBox;
                TextBox txtFasli_Feshar = grow.FindControl("txtFasli_Feshar") as TextBox;

                TextBox txtAbkhori_Datgah = grow.FindControl("txtAbkhori_Datgah") as TextBox;
                TextBox txtAbkhri_Shir = grow.FindControl("txtAbkhri_Shir") as TextBox;
                TextBox txt_FlowerBox = grow.FindControl("txt_FlowerBox") as TextBox;

                TextBox txtTandis = grow.FindControl("txtTandis") as TextBox;
                TextBox TxtBargh_Box = grow.FindControl("TxtBargh_Box") as TextBox;
                TextBox txtRoshanaei_Kotah_Paye = grow.FindControl("txtRoshanaei_Kotah_Paye") as TextBox;
                TextBox txtRoshanaei_Kotah_Sholeh = grow.FindControl("txtRoshanaei_Kotah_Sholeh") as TextBox;
                TextBox txtRoshanaei_Boland_Paye = grow.FindControl("txtRoshanaei_Boland_Paye") as TextBox;
                TextBox txtRoshanaei_Boland_Shole = grow.FindControl("txtRoshanaei_Boland_Shole") as TextBox;

                TextBox txtProject_Paye = grow.FindControl("txtProject_Paye") as TextBox;
                TextBox txtProject_Shole = grow.FindControl("txtProject_Shole") as TextBox;
                TextBox txtTablo = grow.FindControl("txtTablo") as TextBox;
                TextBox txtSharjMobile = grow.FindControl("txtSharjMobile") as TextBox;

                TextBox txtBorj_Paye = grow.FindControl("txtBorj_Paye") as TextBox;
                TextBox txtBorj_Shole = grow.FindControl("txtBorj_Shole") as TextBox;
                TextBox txtu = grow.FindControl("txtu") as TextBox;
                TextBox txtzanjir = grow.FindControl("txtzanjir") as TextBox;
                TextBox txtmileh = grow.FindControl("txtmileh") as TextBox;


                ParkID = Convert.ToInt32(((grow.FindControl("lblPark") as Label).Text));
                for (int t = 0; t < ds.Tables[0].Rows.Count; t++)
                {

                    ////////19سرويس بهداشتي		

                    if (ds.Tables[0].Rows[t]["ParkID"].ToString() == ParkID.ToString())
                    {
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "48" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9288")
                            txtEdari.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "48" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9289")
                            txtnegahbani.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "48" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9290")
                            txtanbar.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();

                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "48" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9291")
                            txt_Piadeh_GhirKhaki.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "48" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9292")
                            txt_Piadeh_Khaki.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();

                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "48" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9293")
                            txtAbnama_Num.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "48" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9294")
                            txtAbnama_Metr.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();

                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "48" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9295")
                            txtgolkhaneh.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "48" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9296")
                            txt_Khazaneh.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "48" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9297")
                            txtOtaghak_Chah.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "48" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9298")
                            txtChalecode.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();

                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "27" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9196")
                            txtNimkat.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();

                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "24" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9191")
                            txtSatle_Zobale.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();



                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "18" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9175")
                            txtAbkhori_Datgah.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "18" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9299")
                            txtAbkhri_Shir.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();

                        //if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "18" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9299")
                        //    txtf.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "29" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9203")
                            txtTandis.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "17" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9315")
                            TxtBargh_Box.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();

                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "16" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9172")
                            txtRoshanaei_Kotah_Paye.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "16" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9173")
                            txtRoshanaei_Kotah_Sholeh.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();

                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "49" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9301")
                            txtRoshanaei_Boland_Paye.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "49" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9300")
                            txtRoshanaei_Boland_Shole.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();


                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "49" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9302")
                            txtProject_Paye.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "49" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9303")
                            txtProject_Shole.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "49" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9304")
                            txtTablo.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "49" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9305")
                            txtSharjMobile.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();


                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "49" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9306")
                            txtBorj_Paye.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "49" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9307")
                            txtBorj_Shole.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                  
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "49" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9308")
                            txtzanjir.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "49" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9309")
                            txtmileh.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "49" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9310")
                            txtu.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();

                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "49" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9311")
                            txt_FlowerBox.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();


                    }
                 }

            //GridView GV1 = "Grid1";
                
                //TextBox txtedarisum = ;// (TextBox)Grid1.FindControl("txtedarisum");
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtmobileSum"), txtSharjMobile);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtuSum"), txtu);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtmileSum"), txtmileh);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtzanjirSum"), txtzanjir);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtTabloSum"), txtTablo);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtBorjPayesum"), txtBorj_Paye);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtBorjSholesum"), txtBorj_Shole);

                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtPrejectorSholesum"), txtBorj_Shole);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtPrejectorPayesum"), txtProject_Paye);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtPrejectorSholesum"), txtProject_Shole);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtroshanBolandPeyeSum"), txtRoshanaei_Boland_Paye);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtroshanBolandSholeSum"), txtRoshanaei_Boland_Shole);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtroshanKotahPeyeSum"), txtRoshanaei_Kotah_Paye);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtBarghSum"), TxtBargh_Box);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtTandisSum"), txtTandis);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtFlowerBoxSum"), txt_FlowerBox);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtAbkhriShirAbSum"), txtAbkhri_Shir);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtAbkhriDastgahSum"), txtAbkhori_Datgah);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtSatlZobaleSum"), txtSatle_Zobale);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtNimkatSum"), txtNimkat);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtChaleKodSum"), txtChalecode);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtOtaghakChahSum"), txtOtaghak_Chah);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtKhazaneh"), txt_Khazaneh);
                 calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtGolkhanehSum"), txtgolkhaneh);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtAbnammetrNum"),txtAbnama_Num );
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtAbnammetrSum"), txtAbnama_Metr);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtkhakisum"), txt_Piadeh_Khaki);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtghirkhakisum"), txt_Piadeh_GhirKhaki);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtAnbarSum"), txtanbar);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtnegahbanisum"), txtnegahbani);
                 calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtedarisum"), txtEdari);
                 calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtroshanKotahSholeSum"), txtRoshanaei_Kotah_Sholeh);

            }


        }
        public void calallcolumn(TextBox clo,TextBox row)
        {
                decimal i1 = 0; decimal i2 = 0; decimal tempi = 0;
                i1 = Convert.ToDecimal(clo.Text == "" ? "0" : clo.Text);
                i2=Convert.ToDecimal(row.Text == "" ? "0" : row.Text);
                tempi = i1 + i2;
                clo.Text  =  tempi.ToString() ;
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


                TextBox txtbohranRoz = grow.FindControl("txtbohranRoz") as TextBox;
                TextBox txtbohranSahb = grow.FindControl("txtbohranSahb") as TextBox;
                TextBox txtParkbanRoz = grow.FindControl("txtParkbanRoz") as TextBox;
                TextBox txtParkbanshab = grow.FindControl("txtParkbanshab") as TextBox;


                TextBox txtEdari = grow.FindControl("txtEdari") as TextBox;
                TextBox txtnegahbani = grow.FindControl("txtnegahbani") as TextBox;
                TextBox txtanbar = grow.FindControl("txtanbar") as TextBox;
                TextBox txt_Piadeh_GhirKhaki = grow.FindControl("txt_Piadeh_GhirKhaki") as TextBox;

                TextBox txt_Piadeh_Khaki = grow.FindControl("txt_Piadeh_Khaki") as TextBox;
                TextBox txtAbnama_Metr = grow.FindControl("txtAbnama_Metr") as TextBox;
                TextBox txtAbnama_Num = grow.FindControl("txtAbnama_Num") as TextBox;
                TextBox txtgolkhaneh = grow.FindControl("txtgolkhaneh") as TextBox;

                TextBox txt_Khazaneh = grow.FindControl("txt_Khazaneh") as TextBox;
                TextBox txtOtaghak_Chah = grow.FindControl("txtOtaghak_Chah") as TextBox;
                TextBox txtChalecode = grow.FindControl("txtChalecode") as TextBox;

                TextBox txtNimkat = grow.FindControl("txtNimkat") as TextBox;
                TextBox txtSatle_Zobale = grow.FindControl("txtSatle_Zobale") as TextBox;
                TextBox txtFasli_Feshar = grow.FindControl("txtFasli_Feshar") as TextBox;

                TextBox txtAbkhori_Datgah = grow.FindControl("txtAbkhori_Datgah") as TextBox;
                TextBox txtAbkhri_Shir = grow.FindControl("txtAbkhri_Shir") as TextBox;
                TextBox txt_FlowerBox = grow.FindControl("txt_FlowerBox") as TextBox;

                TextBox txtTandis = grow.FindControl("txtTandis") as TextBox;
                TextBox TxtBargh_Box = grow.FindControl("TxtBargh_Box") as TextBox;
                TextBox txtRoshanaei_Kotah_Paye = grow.FindControl("txtRoshanaei_Kotah_Paye") as TextBox;
                TextBox txtRoshanaei_Kotah_Sholeh = grow.FindControl("txtRoshanaei_Kotah_Sholeh") as TextBox;
                TextBox txtRoshanaei_Boland_Paye = grow.FindControl("txtRoshanaei_Boland_Paye") as TextBox;
                TextBox txtRoshanaei_Boland_Shole = grow.FindControl("txtRoshanaei_Boland_Shole") as TextBox;

                TextBox txtProject_Paye = grow.FindControl("txtProject_Paye") as TextBox;
                TextBox txtProject_Shole = grow.FindControl("txtProject_Shole") as TextBox;
                TextBox txtTablo = grow.FindControl("txtTablo") as TextBox;
                TextBox txtSharjMobile = grow.FindControl("txtSharjMobile") as TextBox;

                TextBox txtBorj_Paye = grow.FindControl("txtBorj_Paye") as TextBox;
                TextBox txtBorj_Shole = grow.FindControl("txtBorj_Shole") as TextBox;
                TextBox txtu = grow.FindControl("txtu") as TextBox;
                TextBox txtzanjir = grow.FindControl("txtzanjir") as TextBox;
                TextBox txtmileh = grow.FindControl("txtmileh") as TextBox;
                TextBox txtzanjir55 = grow.FindControl("txtzanjir55") as TextBox;

                
                int ParkID = Convert.ToInt32(((grow.FindControl("lblPark") as Label).Text));


                /////48ساختمان وتأسيسات (مساحت / مترمربع)										
                //////////////////////////////////////////////////////////////////////////////////////////
                SaveArea(ParkID, 57, 9338, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtbohranRoz.Text, txtbohranRoz);
                SaveArea(ParkID, 57, 9339, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtbohranSahb.Text, txtbohranSahb);
                SaveArea(ParkID, 58, 9340, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtParkbanRoz.Text, txtParkbanRoz);
                SaveArea(ParkID, 58, 9341, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtParkbanshab.Text, txtParkbanshab);

                SaveArea(ParkID, 48, 9288, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtEdari.Text, txtEdari);
                SaveArea(ParkID, 48, 9289, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtnegahbani.Text, txtnegahbani);
                SaveArea(ParkID, 48, 9290, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtanbar.Text, txtanbar);
                SaveArea(ParkID, 48, 9291, Convert.ToInt32(ddPeyman.SelectedValue), 0, txt_Piadeh_GhirKhaki.Text, txt_Piadeh_GhirKhaki);
                SaveArea(ParkID, 48, 9292, Convert.ToInt32(ddPeyman.SelectedValue), 0, txt_Piadeh_Khaki.Text, txt_Piadeh_Khaki);
                SaveArea(ParkID, 48, 9293, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtAbnama_Num.Text, txtAbnama_Num);
                SaveArea(ParkID, 48, 9294, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtAbnama_Metr.Text, txtAbnama_Metr);
                SaveArea(ParkID, 48, 9295, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtgolkhaneh.Text, txtgolkhaneh);
                SaveArea(ParkID, 48, 9296, Convert.ToInt32(ddPeyman.SelectedValue), 0, txt_Khazaneh.Text, txt_Khazaneh);
                SaveArea(ParkID, 48, 9297, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtOtaghak_Chah.Text, txtOtaghak_Chah);
                SaveArea(ParkID, 48, 9298, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtChalecode.Text, txtChalecode);

                //////////////////////////////////////////////////////////////////////////////////////////////
                SaveArea(ParkID, 27, 9196, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtNimkat.Text, txtNimkat);
                SaveArea(ParkID, 27, 9197, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtNimkat.Text, txtNimkat);


                SaveArea(ParkID, 24, 9191, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtSatle_Zobale.Text, txtSatle_Zobale);
                SaveArea(ParkID, 24, 9190, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtSatle_Zobale.Text, txtSatle_Zobale);

 
                SaveArea(ParkID, 18, 9175, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtAbkhori_Datgah.Text, txtAbkhori_Datgah);
                SaveArea(ParkID, 18, 9299, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtAbkhri_Shir.Text, txtAbkhri_Shir);
               
                SaveArea(ParkID, 29, 9203, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtTandis.Text, txtTandis);
                SaveArea(ParkID, 29, 9202, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtTandis.Text, txtTandis);


                SaveArea(ParkID, 17, 9315, Convert.ToInt32(ddPeyman.SelectedValue), 0, TxtBargh_Box.Text, TxtBargh_Box);

                SaveArea(ParkID, 16, 9172, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtRoshanaei_Kotah_Paye.Text, txtRoshanaei_Kotah_Paye);
                SaveArea(ParkID, 16, 9173, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtRoshanaei_Kotah_Sholeh.Text, txtRoshanaei_Kotah_Sholeh);

                SaveArea(ParkID, 49, 9301, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtRoshanaei_Boland_Paye.Text, txtRoshanaei_Boland_Paye);
                SaveArea(ParkID, 49, 9300, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtRoshanaei_Boland_Shole.Text, txtRoshanaei_Boland_Shole);
                SaveArea(ParkID, 49, 9302, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtProject_Paye.Text, txtProject_Paye);
                SaveArea(ParkID, 49, 9303, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtProject_Shole.Text, txtProject_Shole);
                SaveArea(ParkID, 49, 9304, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtTablo.Text, txtTablo);
                SaveArea(ParkID, 49, 9305, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtSharjMobile.Text, txtSharjMobile);


                SaveArea(ParkID, 49, 9306, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtBorj_Paye.Text, txtBorj_Paye);
                SaveArea(ParkID, 49, 9307, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtBorj_Shole.Text, txtBorj_Shole);
                SaveArea(ParkID, 49, 9308, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtzanjir.Text, txtzanjir);
                SaveArea(ParkID, 49, 9309, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtmileh.Text, txtmileh);
                SaveArea(ParkID, 49, 9310, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtu.Text, txtu);

                SaveArea(ParkID, 49, 9311, Convert.ToInt32(ddPeyman.SelectedValue), 0, txt_FlowerBox.Text, txt_FlowerBox);

                SaveArea(ParkID, 49, 9459, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtzanjir55.Text, txtzanjir55);


                Decimal iiii = mabarghirkhaki(ParkID, 22, 0, Convert.ToInt32(ddPeyman.SelectedValue), 0, "0", txt_FlowerBox);
                SaveArea(ParkID, 22, 9182, Convert.ToInt32(ddPeyman.SelectedValue), 0, iiii.ToString(), txt_FlowerBox);
                SaveArea(ParkID, 22, 9181, Convert.ToInt32(ddPeyman.SelectedValue), 0, iiii.ToString(), txt_FlowerBox);

                Decimal iiii2 = mabarkhaki(ParkID, 51, 0, Convert.ToInt32(ddPeyman.SelectedValue), 0, "0");
                SaveArea(ParkID, 51, 9326, Convert.ToInt32(ddPeyman.SelectedValue), 0, iiii2.ToString(), txt_FlowerBox);
 


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


         

        private Decimal mabarkhaki(int ParkD, int SubjectID, int ExpanID, int AgreementID, int AreaID, string UnitNumber)
        {
            Decimal i = GetMnumberArea(ParkD, 48, 9292, AgreementID, AreaID) +
                  GetMnumberArea(ParkD, 46, 9283, AgreementID, AreaID) +
                  GetMnumberArea(ParkD, 43, 9271, AgreementID, AreaID);
                return i;
        }

        private Decimal mabarghirkhaki(int ParkD, int SubjectID, int ExpanID, int AgreementID, int AreaID, string UnitNumber, TextBox t)
        {
            Decimal i = GetMnumberArea(ParkD, SubjectID, 9291, AgreementID, AreaID) +
                  GetMnumberArea(ParkD, SubjectID, 9261, AgreementID, AreaID) +
                  GetMnumberArea(ParkD, SubjectID, 9263, AgreementID, AreaID) +
                  GetMnumberArea(ParkD, SubjectID, 9282, AgreementID, AreaID) +
                  GetMnumberArea(ParkD, SubjectID, 9270, AgreementID, AreaID) +
                  GetMnumberArea(ParkD, SubjectID, 9198, AgreementID, AreaID);
                return i;
        }
        private Decimal GetMnumberArea(int ParkD, int SubjectID, int ExpanID, int AgreementID, int AreaID)
        {
            ClArea cl = new ClArea();
            cl.SubjectExplainID = ExpanID;
            cl.ParkID = ParkD;
            cl.AgreementID = AgreementID;
             
            DataSet ds = AreaClass.GetList(cl);
            string p1 = "";
            if (ds.Tables[0].Rows.Count > 0)
                p1 = ds.Tables[0].Rows[0]["UnitNumber"].ToString();
            else
                p1 = "0";

            return Convert.ToDecimal(p1==""?"0":p1);
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


     //           if (ExpanID == 9275 || ExpanID == 9276 || ExpanID == 9289 || ExpanID == 9291 || ExpanID == 9192 ||
     //ExpanID == 9299 || ExpanID == 9187 || ExpanID == 9293)
                 //   Save222(ParkD, SubjectID, ExpanID, AgreementID, AreaID, UnitNumber, t);

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