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
    public partial class ExelRefahi : System.Web.UI.Page
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
            cl.AgreementID= Convert.ToInt32(ddPeyman.SelectedValue);
            cl.PeymanID =Convert.ToInt32(ddPeyman2.SelectedValue);
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

                TextBox txtService_BAB = grow.FindControl("txtService_BAB") as TextBox;
                TextBox txtservice_Cheshme = grow.FindControl("txtservice_Cheshme") as TextBox;
                TextBox txtService_Metr = grow.FindControl("txtService_Metr") as TextBox;
                TextBox txtServiceMajmoeh = grow.FindControl("txtService_majmoeh") as TextBox;


                TextBox txtNamazMetr = grow.FindControl("txtNamazMetr") as TextBox;
                TextBox txtNamazType = grow.FindControl("txtNamazType") as TextBox;

                TextBox txtRestoranNumber = grow.FindControl("txtRestoranNumber") as TextBox;
                TextBox txtRestoranMetr = grow.FindControl("txtRestoranMetr") as TextBox;

                TextBox txtghorfeNumber = grow.FindControl("txtghorfeNumber") as TextBox;
                TextBox txtGhorfeMetr = grow.FindControl("txtGhorfeMetr") as TextBox;


                TextBox txtKampinNumber = grow.FindControl("txtKampinNumber") as TextBox;
                TextBox txtKampinMetr = grow.FindControl("txtKampinMetr") as TextBox;


                TextBox txtSakoNumber = grow.FindControl("txtSakoNumber") as TextBox;
                TextBox txtSakoMetr = grow.FindControl("txtSakoMetr") as TextBox;
 
                TextBox txtZaminKodak_Num22 = grow.FindControl("txtZaminKodak_Num22") as TextBox;
                TextBox txtZaminKodak_metr22 = grow.FindControl("txtZaminKodak_metr22") as TextBox;
                TextBox txtZaminKodak_Khaki22 = grow.FindControl("txtZaminKodak_Khaki22") as TextBox;



                TextBox txtbaziAlakolang = grow.FindControl("txtbaziAlakolang") as TextBox;
                TextBox txtbaziSorsore = grow.FindControl("txtbaziSorsore") as TextBox;
                TextBox txtbazitab = grow.FindControl("txtbazitab") as TextBox;
                TextBox txtbaziasb = grow.FindControl("txtbaziasb") as TextBox;
                TextBox tatbazitandorosti = grow.FindControl("tatbazitandorosti") as TextBox;
                TextBox txtbazicomlex = grow.FindControl("txtbazicomlex") as TextBox;
                TextBox txtbaziMizTenis = grow.FindControl("txtbaziMizTenis") as TextBox;
                TextBox txtbazi_SUm = grow.FindControl("txtbazi_SUm") as TextBox;

                TextBox txtZaminVareshi_ghirKhaki = grow.FindControl("txtZaminVareshi_ghirKhaki") as TextBox;
                TextBox txtZaminVarzeshi_Khaki = grow.FindControl("txtZaminVarzeshi_Khaki") as TextBox;
                TextBox txtZaminKodak_Kafposh = grow.FindControl("txtZaminKodak_Kafposh") as TextBox;

                TextBox txtZaminType_Eskit = grow.FindControl("txtZaminType_Eskit") as TextBox;
                TextBox txtZaminType_Footbal = grow.FindControl("txtZaminType_Footbal") as TextBox;
                TextBox txtZaminType_Volyybal = grow.FindControl("txtZaminType_Volyybal") as TextBox;

                TextBox txtKababPaz = grow.FindControl("txtKababPaz") as TextBox;


                TextBox txtAlachigh_Num = grow.FindControl("txtAlachigh_Num") as TextBox;
                TextBox txtAlachigh_Meter = grow.FindControl("txtAlachigh_Meter") as TextBox;

                TextBox txtTel = grow.FindControl("txtTel") as TextBox;
                TextBox txtzabt = grow.FindControl("txtzabt") as TextBox;
                TextBox txtabsardkon = grow.FindControl("txtabsardkon") as TextBox;
                TextBox txtmicrophon = grow.FindControl("txtmicrophon") as TextBox;

                Label txtKhakiMabar = grow.FindControl("txtmicrophon") as Label;
                Label txtGhirKhakiMabar = grow.FindControl("txtGhirKhakiMabar") as Label; 


                for (int t = 0; t < ds.Tables[0].Rows.Count; t++)
                {

                    ////////19سرويس بهداشتي		


                    if (ds.Tables[0].Rows[t]["ParkID"].ToString() == ParkID.ToString())
                    {
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "19" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9253")
                            txtService_BAB.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "19" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9176")
                            txtservice_Cheshme.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "19" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9280")
                            txtService_Metr.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "19" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9336")
                            txtServiceMajmoeh.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();



                        //////////////////25نمازخانه	
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "50" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9317")
                            txtNamazMetr.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "25" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9255")
                            txtNamazType.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        //////////////////39رستوران	

                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "39" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9256")
                            txtRestoranNumber.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "39" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9257")
                            txtRestoranMetr.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();

                        //////////////////40غرفه تنقلات	

                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "40" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9258")
                            txtghorfeNumber.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "40" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9259")
                            txtGhorfeMetr.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        //////////////////41كمپينگ	

                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "41" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9260")
                            txtKampinNumber.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "41" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9261")
                            txtKampinMetr.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        //////////////////42سكوي نشيمن	
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "42" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9262")
                            txtSakoNumber.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "42" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9263")
                            txtSakoMetr.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        //////////////////46زمين بازي كودكان 		
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "46" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9281")
                            txtZaminKodak_Num22.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "46" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9282")
                            txtZaminKodak_metr22.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "46" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9283")
                            txtZaminKodak_Khaki22.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "46" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9337")
                            txtZaminKodak_Kafposh.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();

                        //////////////////26وسايل بازي كودكان - وسایل ورزشی و تندرستی(دستگاه)								
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "26" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9264")
                            txtbaziAlakolang.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "26" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9265")
                            txtbaziSorsore.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "26" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9266")
                            txtbazitab.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "26" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9267")
                            txtbaziasb.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "26" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9268")
                            tatbazitandorosti.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "26" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9269")
                            txtbazicomlex.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "26" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9284")
                            txtbaziMizTenis.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();

                        if (ds.Tables[0].Rows[t]["ParkID"].ToString() == ParkID.ToString()

                          && !(txtbaziAlakolang.Text == "" &&
                                txtbaziSorsore.Text == "" &&
                                txtbazitab.Text == "" &&
                                tatbazitandorosti.Text == "" &&
                                txtbaziasb.Text == "" &&
                                    txtbazicomlex.Text == "" &&
                                    txtbaziMizTenis.Text == ""
                                )
                            )
                            txtbazi_SUm.Text = (
                              Convert.ToDecimal(txtbaziAlakolang.Text == "" ? "0" : txtbaziAlakolang.Text) +
                              Convert.ToDecimal(txtbaziSorsore.Text == "" ? "0" : txtbaziSorsore.Text) +
                              Convert.ToDecimal(txtbazitab.Text == "" ? "0" : txtbazitab.Text) +
                              Convert.ToDecimal(txtbaziasb.Text == "" ? "0" : txtbaziasb.Text) +
                              Convert.ToDecimal(tatbazitandorosti.Text == "" ? "0" : tatbazitandorosti.Text) +
                              Convert.ToDecimal(txtbazicomlex.Text == "" ? "0" : txtbazicomlex.Text) +
                              Convert.ToDecimal(txtbaziMizTenis.Text == "" ? "0" : txtbaziMizTenis.Text)
                               ).ToString();


                        /////////43زمین ورزشی	

                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "43" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9270")
                            txtZaminVareshi_ghirKhaki.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "43" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9271")
                            txtZaminVarzeshi_Khaki.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();

                        /////////44نوع زمين ورزشي (مترمربع)				
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "44" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9272")
                            txtZaminType_Eskit.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "44" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9273")
                            txtZaminType_Footbal.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "44" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9274")
                            txtZaminType_Volyybal.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();

                        /////////28کباب پز
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "28" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9201")
                            txtKababPaz.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();

                        /////////آلاچيق34	
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "34" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9275")
                            txtAlachigh_Num.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "34" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9199")
                            txtAlachigh_Meter.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        ////////45تلفن عمومي
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "45" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9277")
                            txtTel.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();

                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "47" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9285")
                            txtzabt.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "47" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9286")
                            txtabsardkon.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "47" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9287")
                            txtmicrophon.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();

                        txtGhirKhakiMabar.Text = (
                                Convert.ToDecimal(txtKampinMetr.Text == "" ? "0" : txtKampinMetr.Text) +
                                Convert.ToDecimal(txtZaminKodak_metr22.Text == "" ? "0" : txtZaminKodak_metr22.Text) +
                                Convert.ToDecimal(txtZaminVareshi_ghirKhaki.Text == "" ? "0" : txtZaminVareshi_ghirKhaki.Text) +
                                Convert.ToDecimal(txtAlachigh_Meter.Text == "" ? "0" : txtAlachigh_Meter.Text)
                             ).ToString();




                        //txtKhakiMabar.Text = (
                        //        Convert.ToDecimal(txtNamazMetr.Text == "" ? "0" : txtNamazMetr.Text) +
                        //        Convert.ToDecimal(txtZaminKodak_Khaki22.Text == "" ? "0" : txtZaminKodak_Khaki22.Text)
                        //    ).ToString();




                       

                    }
                }

                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtServiceMajmoehSum"), txtServiceMajmoeh);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtServiceBabSUM"), txtService_BAB);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtServiceCheshmeSUM"), txtservice_Cheshme);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtServiceMetrSUM"), txtService_Metr);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtNamazMetrSUM"), txtNamazMetr);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtnamazTypeSum"), txtNamazType);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtRestornNumSUM"), txtRestoranNumber);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtRestornMetrSUM"), txtRestoranMetr);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtGorfeNummUM"), txtghorfeNumber);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtghorfeMetrSUM"), txtGhorfeMetr);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtKampingNumSUM"), txtKampinNumber);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtKampingMetrSUM"), txtKampinMetr);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtSakoNumSUM"), txtSakoNumber);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtSakometrSUM"), txtSakoMetr);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtZaminKodakNumSUM"), txtZaminKodak_Num22);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtZaminKodakMetrGhirkhakiSUM"), txtZaminKodak_metr22);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtZaminKodakMetrKhakiSUM"), txtZaminKodak_Khaki22);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtAlakolangSUM"), txtbaziAlakolang);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtSorsoreSUM"), txtbaziSorsore);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txttabSUM"), txtbazitab);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtAsbSUM"), txtbaziasb);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtTandorostiSUM"), tatbazitandorosti);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtKomplexSUM"), txtbazicomlex);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtTenisSUM"), txtbaziMizTenis);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtzaminvarzeshiGhirkhkiSUM"), txtZaminVareshi_ghirKhaki);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtzaminvarzeshikhkiSUM"), txtZaminVarzeshi_Khaki);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtEskitSUM"), txtZaminType_Eskit);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txyFotballSUM"), txtZaminType_Footbal);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtVollybalSUM"), txtZaminType_Volyybal);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtkabNumSUM"), txtKababPaz);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtAlachighNumSUM"), txtAlachigh_Num);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtAlachighMetrSUM"), txtAlachigh_Meter);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtTelSUM"), txtTel);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtZabtSUM"), txtzabt);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtAbSardSum"), txtabsardkon);
                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtMicSUM"), txtmicrophon);

                calallcolumn((TextBox)Grid1.HeaderRow.FindControl("txtZaminKodakKafposh"), txtZaminKodak_Kafposh);
         
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

                TextBox txtService_BAB = grow.FindControl("txtService_BAB") as TextBox;
                TextBox txtservice_Cheshme = grow.FindControl("txtservice_Cheshme") as TextBox;
                TextBox txtService_Metr = grow.FindControl("txtService_Metr") as TextBox;
                TextBox txtService_majmoeh = grow.FindControl("txtService_majmoeh") as TextBox;


                TextBox txtNamazMetr = grow.FindControl("txtNamazMetr") as TextBox;
                TextBox txtNamazType = grow.FindControl("txtNamazType") as TextBox;

                TextBox txtRestoranNumber = grow.FindControl("txtRestoranNumber") as TextBox;
                TextBox txtRestoranMetr = grow.FindControl("txtRestoranMetr") as TextBox;

                TextBox txtghorfeNumber = grow.FindControl("txtghorfeNumber") as TextBox;
                TextBox txtGhorfeMetr = grow.FindControl("txtGhorfeMetr") as TextBox;


                TextBox txtKampinNumber = grow.FindControl("txtKampinNumber") as TextBox;
                TextBox txtKampinMetr = grow.FindControl("txtKampinMetr") as TextBox;


                TextBox txtSakoNumber = grow.FindControl("txtSakoNumber") as TextBox;
                TextBox txtSakoMetr = grow.FindControl("txtSakoMetr") as TextBox;
 
                TextBox txtZaminKodak_Num22 = grow.FindControl("txtZaminKodak_Num22") as TextBox;
                TextBox txtZaminKodak_metr22 = grow.FindControl("txtZaminKodak_metr22") as TextBox;
                TextBox txtZaminKodak_Khaki22 = grow.FindControl("txtZaminKodak_Khaki22") as TextBox;
                TextBox txtZaminKodak_Kafposh = grow.FindControl("txtZaminKodak_Kafposh") as TextBox;



                TextBox txtbaziAlakolang = grow.FindControl("txtbaziAlakolang") as TextBox;
                TextBox txtbaziSorsore = grow.FindControl("txtbaziSorsore") as TextBox;
                TextBox txtbazitab = grow.FindControl("txtbazitab") as TextBox;
                TextBox txtbaziasb = grow.FindControl("txtbaziasb") as TextBox;
                TextBox tatbazitandorosti = grow.FindControl("tatbazitandorosti") as TextBox;
                TextBox txtbazicomlex = grow.FindControl("txtbazicomlex") as TextBox;
                TextBox txtbaziMizTenis = grow.FindControl("txtbaziMizTenis") as TextBox;
                TextBox txtbazi_SUm = grow.FindControl("txtbazi_SUm") as TextBox;

                TextBox txtZaminVareshi_ghirKhaki = grow.FindControl("txtZaminVareshi_ghirKhaki") as TextBox;
                TextBox txtZaminVarzeshi_Khaki = grow.FindControl("txtZaminVarzeshi_Khaki") as TextBox;

                TextBox txtZaminType_Eskit = grow.FindControl("txtZaminType_Eskit") as TextBox;
                TextBox txtZaminType_Footbal = grow.FindControl("txtZaminType_Footbal") as TextBox;
                TextBox txtZaminType_Volyybal = grow.FindControl("txtZaminType_Volyybal") as TextBox;

                TextBox txtKababPaz = grow.FindControl("txtKababPaz") as TextBox;


                TextBox txtAlachigh_Num = grow.FindControl("txtAlachigh_Num") as TextBox;
                TextBox txtAlachigh_Meter = grow.FindControl("txtAlachigh_Meter") as TextBox;

                TextBox txtTel = grow.FindControl("txtTel") as TextBox;
                TextBox txtzabt = grow.FindControl("txtzabt") as TextBox;
                TextBox txtabsardkon = grow.FindControl("txtabsardkon") as TextBox;
                TextBox txtmicrophon = grow.FindControl("txtmicrophon") as TextBox;

                Label txtKhakiMabar = grow.FindControl("txtmicrophon") as Label;
                Label txtGhirKhakiMabar = grow.FindControl("txtGhirKhakiMabar") as Label; 


                ParkID = Convert.ToInt32(((grow.FindControl("lblPark") as Label).Text));
                for (int t = 0; t < ds.Tables[0].Rows.Count; t++)
                {

                    ////////19سرويس بهداشتي		


                    if (ds.Tables[0].Rows[t]["ParkID"].ToString() == ParkID.ToString())
                    {
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "19" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9253")
                            txtService_BAB.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "19" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9176")
                            txtservice_Cheshme.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "19" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9280")
                            txtService_Metr.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "19" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9336")
                            txtService_majmoeh.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();



                        //////////////////25نمازخانه	
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "50" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9317")
                            txtNamazMetr.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "25" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9255")
                            txtNamazType.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        //////////////////39رستوران	

                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "39" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9256")
                            txtRestoranNumber.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "39" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9257")
                            txtRestoranMetr.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();

                        //////////////////40غرفه تنقلات	

                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "40" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9258")
                            txtghorfeNumber.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "40" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9259")
                            txtGhorfeMetr.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        //////////////////41كمپينگ	

                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "41" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9260")
                            txtKampinNumber.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "41" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9261")
                            txtKampinMetr.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        //////////////////42سكوي نشيمن	
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "42" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9262")
                            txtSakoNumber.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "42" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9263")
                            txtSakoMetr.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        //////////////////46زمين بازي كودكان 		
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "46" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9281")
                            txtZaminKodak_Num22.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "46" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9282")
                            txtZaminKodak_metr22.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "46" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9283")
                            txtZaminKodak_Khaki22.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "46" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9337")
                            txtZaminKodak_Kafposh.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();

                        //////////////////26وسايل بازي كودكان - وسایل ورزشی و تندرستی(دستگاه)								
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "26" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9264")
                            txtbaziAlakolang.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "26" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9265")
                            txtbaziSorsore.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "26" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9266")
                            txtbazitab.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "26" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9267")
                            txtbaziasb.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "26" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9268")
                            tatbazitandorosti.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "26" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9269")
                            txtbazicomlex.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "26" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9284")
                            txtbaziMizTenis.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();

                        if (ds.Tables[0].Rows[t]["ParkID"].ToString() == ParkID.ToString()

                          && !(txtbaziAlakolang.Text == "" &&
                                txtbaziSorsore.Text == "" &&
                                txtbazitab.Text == "" &&
                                tatbazitandorosti.Text == "" &&
                                txtbaziasb.Text == "" &&
                                    txtbazicomlex.Text == "" &&
                                    txtbaziMizTenis.Text == ""
                                )
                            )
                            txtbazi_SUm.Text = (
                              Convert.ToDecimal(txtbaziAlakolang.Text == "" ? "0" : txtbaziAlakolang.Text) +
                              Convert.ToDecimal(txtbaziSorsore.Text == "" ? "0" : txtbaziSorsore.Text) +
                              Convert.ToDecimal(txtbazitab.Text == "" ? "0" : txtbazitab.Text) +
                              Convert.ToDecimal(txtbaziasb.Text == "" ? "0" : txtbaziasb.Text) +
                              Convert.ToDecimal(tatbazitandorosti.Text == "" ? "0" : tatbazitandorosti.Text) +
                              Convert.ToDecimal(txtbazicomlex.Text == "" ? "0" : txtbazicomlex.Text) +
                              Convert.ToDecimal(txtbaziMizTenis.Text == "" ? "0" : txtbaziMizTenis.Text)
                               ).ToString();


                        /////////43زمین ورزشی	

                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "43" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9270")
                            txtZaminVareshi_ghirKhaki.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "43" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9271")
                            txtZaminVarzeshi_Khaki.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();

                        /////////44نوع زمين ورزشي (مترمربع)				
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "44" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9272")
                            txtZaminType_Eskit.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "44" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9273")
                            txtZaminType_Footbal.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "44" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9274")
                            txtZaminType_Volyybal.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();

                        /////////28کباب پز
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "28" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9201")
                            txtKababPaz.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();

                        /////////آلاچيق34	
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "34" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9275")
                            txtAlachigh_Num.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "34" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9199")
                            txtAlachigh_Meter.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        ////////45تلفن عمومي
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "45" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9277")
                            txtTel.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();

                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "47" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9285")
                            txtzabt.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "47" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9286")
                            txtabsardkon.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();
                        if (ds.Tables[0].Rows[t]["SubjectID"].ToString() == "47" && ds.Tables[0].Rows[t]["SubjectExplainID"].ToString() == "9287")
                            txtmicrophon.Text = ds.Tables[0].Rows[t]["UnitNumber"].ToString();

                        txtGhirKhakiMabar.Text = (
                                Convert.ToDecimal(txtKampinMetr.Text == "" ? "0" : txtKampinMetr.Text) +
                                Convert.ToDecimal(txtZaminKodak_metr22.Text == "" ? "0" : txtZaminKodak_metr22.Text) +
                                Convert.ToDecimal(txtZaminVareshi_ghirKhaki.Text == "" ? "0" : txtZaminVareshi_ghirKhaki.Text) +
                                Convert.ToDecimal(txtAlachigh_Meter.Text == "" ? "0" : txtAlachigh_Meter.Text)
                             ).ToString();

                        //txtKhakiMabar.Text = (
                        //        Convert.ToDecimal(txtNamazMetr.Text == "" ? "0" : txtNamazMetr.Text) +
                        //        Convert.ToDecimal(txtZaminKodak_Khaki22.Text == "" ? "0" : txtZaminKodak_Khaki22.Text)
                        //    ).ToString();

                    }
                }
            }
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

                TextBox txtService_BAB = grow.FindControl("txtService_BAB") as TextBox;
                TextBox txtservice_Cheshme = grow.FindControl("txtservice_Cheshme") as TextBox;
                TextBox txtService_Metr = grow.FindControl("txtService_Metr") as TextBox;
                TextBox txtService_majmoeh = grow.FindControl("txtService_majmoeh") as TextBox;


                TextBox txtNamazMetr = grow.FindControl("txtNamazMetr") as TextBox;
                TextBox txtNamazType = grow.FindControl("txtNamazType") as TextBox;

                TextBox txtRestoranNumber = grow.FindControl("txtRestoranNumber") as TextBox;
                TextBox txtRestoranMetr = grow.FindControl("txtRestoranMetr") as TextBox;

                TextBox txtghorfeNumber = grow.FindControl("txtghorfeNumber") as TextBox;
                TextBox txtGhorfeMetr = grow.FindControl("txtGhorfeMetr") as TextBox;


                TextBox txtKampinNumber = grow.FindControl("txtKampinNumber") as TextBox;
                TextBox txtKampinMetr = grow.FindControl("txtKampinMetr") as TextBox;


                TextBox txtSakoNumber = grow.FindControl("txtSakoNumber") as TextBox;
                TextBox txtSakoMetr = grow.FindControl("txtSakoMetr") as TextBox;

                TextBox txtZaminKodak_Num22 = grow.FindControl("txtZaminKodak_Num22") as TextBox;
                TextBox txtZaminKodak_metr22 = grow.FindControl("txtZaminKodak_metr22") as TextBox;
                TextBox txtZaminKodak_Khaki22 = grow.FindControl("txtZaminKodak_Khaki22") as TextBox;
                TextBox txtZaminKodak_Kafposh = grow.FindControl("txtZaminKodak_Kafposh") as TextBox;



                TextBox txtbaziAlakolang = grow.FindControl("txtbaziAlakolang") as TextBox;
                TextBox txtbaziSorsore = grow.FindControl("txtbaziSorsore") as TextBox;
                TextBox txtbazitab = grow.FindControl("txtbazitab") as TextBox;
                TextBox txtbaziasb = grow.FindControl("txtbaziasb") as TextBox;
                TextBox tatbazitandorosti = grow.FindControl("tatbazitandorosti") as TextBox;
                TextBox txtbazicomlex = grow.FindControl("txtbazicomlex") as TextBox;
                TextBox txtbaziMizTenis = grow.FindControl("txtbaziMizTenis") as TextBox;
                TextBox txtbazi_SUm = grow.FindControl("txtbazi_SUm") as TextBox;

                TextBox txtZaminVareshi_ghirKhaki = grow.FindControl("txtZaminVareshi_ghirKhaki") as TextBox;
                TextBox txtZaminVarzeshi_Khaki = grow.FindControl("txtZaminVarzeshi_Khaki") as TextBox;

                TextBox txtZaminType_Eskit = grow.FindControl("txtZaminType_Eskit") as TextBox;
                TextBox txtZaminType_Footbal = grow.FindControl("txtZaminType_Footbal") as TextBox;
                TextBox txtZaminType_Volyybal = grow.FindControl("txtZaminType_Volyybal") as TextBox;

                TextBox txtKababPaz = grow.FindControl("txtKababPaz") as TextBox;


                TextBox txtAlachigh_Num = grow.FindControl("txtAlachigh_Num") as TextBox;
                TextBox txtAlachigh_Meter = grow.FindControl("txtAlachigh_Meter") as TextBox;

                TextBox txtTel = grow.FindControl("txtTel") as TextBox;
                TextBox txtzabt = grow.FindControl("txtzabt") as TextBox;
                TextBox txtabsardkon = grow.FindControl("txtabsardkon") as TextBox;
                TextBox txtmicrophon = grow.FindControl("txtmicrophon") as TextBox;
                int ParkID = Convert.ToInt32(((grow.FindControl("lblPark") as Label).Text));


                 //////////////////////////////////////////////////////////////////////////////////////////
                SaveArea(ParkID, 19, 9253, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtService_BAB.Text, txtService_BAB);
                SaveArea(ParkID, 19, 9176, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtservice_Cheshme.Text, txtservice_Cheshme);
                SaveArea(ParkID, 19, 9280, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtService_Metr.Text, txtService_Metr);
                SaveArea(ParkID, 19, 9336, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtService_majmoeh.Text, txtService_majmoeh);

                //////////////////////////////////////////////////////////////////////////////////////////
                SaveArea(ParkID, 50, 9317, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtNamazMetr.Text, txtNamazMetr);
                SaveArea(ParkID, 25, 9255, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtNamazType.Text, txtNamazType);
                //////////////////////////////////////////////////////////////////////////////////////////
                SaveArea(ParkID, 39, 9256, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtRestoranNumber.Text, txtRestoranNumber);
                SaveArea(ParkID, 39, 9257, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtRestoranMetr.Text, txtRestoranMetr);
                //////////////////////////////////////////////////////////////////////////////////////////
                SaveArea(ParkID, 40, 9258, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtghorfeNumber.Text, txtghorfeNumber);
                SaveArea(ParkID, 40, 9259, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtGhorfeMetr.Text, txtGhorfeMetr);
                //////////////////////////////////////////////////////////////////////////////////////////

                SaveArea(ParkID, 41, 9261, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtKampinMetr.Text, txtKampinMetr);
                SaveArea(ParkID, 41, 9260, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtKampinNumber.Text, txtKampinNumber);
                //////////////////////////////////////////////////////////////////////////////////////////
                   SaveArea(ParkID, 42, 9262, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtSakoNumber.Text, txtSakoNumber);
                   SaveArea(ParkID, 42, 9263, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtSakoMetr.Text, txtSakoMetr);
                //////////////////////////////////////////////////////////////////////////////////////////
                 SaveArea(ParkID, 46, 9283, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtZaminKodak_Khaki22.Text, txtZaminKodak_Khaki22);
                SaveArea(ParkID, 46, 9282, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtZaminKodak_metr22.Text, txtZaminKodak_metr22);
                SaveArea(ParkID, 46, 9281, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtZaminKodak_Num22.Text, txtZaminKodak_Num22);
                SaveArea(ParkID, 46, 9337, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtZaminKodak_Kafposh.Text, txtZaminKodak_Kafposh);

                //////////////////////////////////////////////////////////////////////////////////////////

                SaveArea(ParkID, 26, 9264, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtbaziAlakolang.Text, txtbaziAlakolang);
                SaveArea(ParkID, 26, 9265, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtbaziSorsore.Text, txtbaziSorsore);
                SaveArea(ParkID, 26, 9266, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtbazitab.Text, txtbazitab);
                SaveArea(ParkID, 26, 9267, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtbaziasb.Text, txtbaziasb);
                SaveArea(ParkID, 26, 9268, Convert.ToInt32(ddPeyman.SelectedValue), 0, tatbazitandorosti.Text, tatbazitandorosti);
                SaveArea(ParkID, 26, 9269, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtbazicomlex.Text, txtbazicomlex);
                SaveArea(ParkID, 26, 9284, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtbaziMizTenis.Text, txtbaziMizTenis);


                /////////////////////////43زمین ورزشی	
                /////////////////////////////////////////////////////////////////
                SaveArea(ParkID, 43, 9270, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtZaminVareshi_ghirKhaki.Text, txtZaminVareshi_ghirKhaki);
                 SaveArea(ParkID, 43, 9271, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtZaminVarzeshi_Khaki.Text, txtZaminVarzeshi_Khaki);
               
                SaveArea(ParkID, 44, 9272, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtZaminType_Eskit.Text, txtZaminType_Eskit);
                 SaveArea(ParkID, 44, 9273, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtZaminType_Footbal.Text, txtZaminType_Footbal);
                SaveArea(ParkID, 44, 9274, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtZaminType_Volyybal.Text, txtZaminType_Volyybal);

                SaveArea(ParkID, 28, 9201, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtKababPaz.Text, txtKababPaz);
                SaveArea(ParkID, 28, 9200, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtKababPaz.Text, txtKababPaz);
            
                SaveArea(ParkID, 34, 9199, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtAlachigh_Meter.Text, txtAlachigh_Meter);
                SaveArea(ParkID, 34, 9275, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtAlachigh_Num.Text, txtAlachigh_Num);
               
                SaveArea(ParkID, 45, 9277, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtTel.Text, txtTel);

                SaveArea(ParkID, 47, 9285, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtzabt.Text, txtzabt);
                SaveArea(ParkID, 47, 9286, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtabsardkon.Text, txtabsardkon);
                SaveArea(ParkID, 47, 9287, Convert.ToInt32(ddPeyman.SelectedValue), 0, txtmicrophon.Text, txtmicrophon);



                if (Convert.ToInt32(ddPeyman.SelectedValue) == 0)
                {
                    ClArea cl = new ClArea();
                    cl.ParkID = ParkID;
                    cl.AgreementID = 0;
                    int rrrttrt = AreaClass.SaveErth(cl);
                    if (rrrttrt == 0)
                        CSharp.Utility.ShowMsg(Page, CSharp.ProPertyData.MsgType.warning, "خطا در ثبت عرصه از کل");
                }

                //////////////////////////////Expetion////////////////////////////////////////////////////////////
                
             }

        }

        private int SaveArea(int ParkD, int SubjectID, int ExpanID, int AgreementID, int AreaID, string UnitNumber, TextBox t)
        {
            if (AreaID == null)
                AreaID = 0;
            if (UnitNumber == null)
                UnitNumber = "";
            if (UnitNumber == "")
                return 11;

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


                //if (ExpanID == 9275 || ExpanID == 9199 || ExpanID == 9289 || ExpanID == 9291 || ExpanID == 9192 ||
                //     ExpanID == 9299 || ExpanID == 9294 || ExpanID == 9293)
                    //Save222(ParkD, SubjectID, ExpanID, AgreementID, AreaID, UnitNumber, t);

 
                return retval;
            }
            else
                return 1;
        }


        //private void Save222(int ParkD, int SubjectID, int ExpanID, int AgreementID, int AreaID, string UnitNumber, TextBox t)
        //{
        //    if (UnitNumber != "" && UnitNumber != null)
        //    {
        //        if (SubjectID == 34 && ExpanID == 9275)
        //            SaveArea(ParkD, 34, 9199, AgreementID, AreaID, UnitNumber, t);
        //        if (SubjectID == 34 && ExpanID == 9199)
        //            SaveArea(ParkD, 34, 9198, AgreementID, AreaID, UnitNumber, t);
        //        //if (SubjectID == 48 && ExpanID == 9289)
        //        //    SaveArea(ParkD, 20, 9177, AgreementID, AreaID, UnitNumber, t);
        //        if (SubjectID == 48 && ExpanID == 9291)
        //            SaveArea(ParkD, 47, 9039, AgreementID, AreaID, UnitNumber, t);
        //        //if (SubjectID == 48 && ExpanID == 9291)
        //        //    SaveArea(ParkD, 22, 9181, AgreementID, AreaID, UnitNumber, t);
        //        if (SubjectID == 48 && ExpanID == 9291)
        //            SaveArea(ParkD, 51, 9326, AgreementID, AreaID, UnitNumber, t);
        //        if (SubjectID == 48 && ExpanID == 9293)
        //            SaveArea(ParkD, 23, 9189, AgreementID, AreaID, UnitNumber, t);
        //        if (SubjectID == 48 && ExpanID == 9294)
        //            SaveArea(ParkD, 23, 9186, AgreementID, AreaID, UnitNumber, t);
        //        if (SubjectID == 48 && ExpanID == 9294)
        //            SaveArea(ParkD, 23, 9187, AgreementID, AreaID, UnitNumber, t);
        //        if (SubjectID == 48 && ExpanID == 9294)
        //            SaveArea(ParkD, 23, 9188, AgreementID, AreaID, UnitNumber, t);
        //        if (SubjectID == 18 && ExpanID == 9299)
        //            SaveArea(ParkD, 18, 9175, AgreementID, AreaID, UnitNumber, t);
        //    }
        //}
        protected void ddPeyman2_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

    }
}