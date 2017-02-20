<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/DashBordMaster.Master" AutoEventWireup="true" CodeBehind="AreaSakhteman.aspx.cs" Inherits="GreenSpace.Manage.AreaSakhteman" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <style>
        .txtgrid{width:60px}
         .rowbackground
        {
            background-color: white;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="topMenuProfile" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="subMaster" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="contectMenuHo" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr><td>قرارداد:</td><td><asp:DropDownList runat="server" ID="ddPeyman" AutoPostBack="True" OnSelectedIndexChanged="ddPeyman_SelectedIndexChanged"></asp:DropDownList></td></tr></table>
        <table><tr><td>پیمان:</td><td><asp:DropDownList runat="server" ID="ddPeyman2" AutoPostBack="True" OnSelectedIndexChanged="ddPeyman2_SelectedIndexChanged"></asp:DropDownList></td></tr></table>

    <div style="width:100%;overflow:auto;height:500px ">
    <asp:GridView runat="server" ID="Grid1"  
        AutoGenerateColumns="false" PageSize="3" CssClass="Grid" AlternatingRowStyle-BackColor="WhiteSmoke" 
          
HeaderStyle-CssClass="FixedHeader">
         <Columns> 
 
            
              <asp:TemplateField>
        
                  <HeaderTemplate>
                       
                          <tr class="gvHeader   " style="width:660px" >
                          <th>ردیف</th>
                          <th>پارک</th>
                              <th colspan="2">حضور نیروی بحران</th>
                              <th colspan="2">پارکبان</th>

                          <th colspan="12">ساختمان وتأسيسات (مساحت / مترمربع)										
										
</th>
                          <th colspan="20">                 مبلمان ( تعداد)																		
																		
										
										
</th>
                          </tr>
                          <tr class="gvHeader  ">
                              <th></th>
                              <th></th>

 
                                  <th colspan="2">بحران	
 </th>  
                                                            <th colspan="2">پارکبان	
 </th> 
                              <th colspan="4"></th>                        
                              <th colspan="2">پیاده رو	
 </th>
                              <th colspan="2">آبنما	
 </th>
                              <th colspan="1">گلخانه
 	 </th>

                              <th>خزانه
</th>
                              <th>اتاقك چاه آب

</th>
                              <th>چاله كود
</th>


<th></th>
<th></th>
<th colspan="2">آبخوری- ظرفشویی-روشویی	
</th>
<th></th>
<th></th>
 <th></th>
 <th colspan="2">روشنایی پایه کوتاه 	
</th>
<th colspan="2">روشنایی پایه بلند 	
</th>
<th colspan="2">پروژکتور 	
</th>
<th colspan="2">برج نوری 	
</th>
<th colspan="10"></th>
<th></th>
                          </tr>
                          <tr class="gvHeader   ">
                               
                              <th></th>
                              <th></th>
                              <th>
                                  روز
                                <asp:TextBox runat="server" ID="txtBohranRozSum" CssClass="txtgrid"></asp:TextBox>

                              </th>
                              <th>شب
                                   <asp:TextBox runat="server" ID="txtBohranShabSum" CssClass="txtgrid"></asp:TextBox>
                                          
                              </th>

                              <th>روز
                                   <asp:TextBox runat="server" ID="txtParkbanRozSum" CssClass="txtgrid"></asp:TextBox>


                              </th>
                              <th>شب
                                  <asp:TextBox runat="server" ID="txtParkbanShabSum" CssClass="txtgrid"></asp:TextBox>
                                  </th>

                                  <th style="width:0px"> </th>
                            <th> اداري
                                <asp:TextBox runat="server" ID="txtedarisum" CssClass="txtgrid"></asp:TextBox>
                            </th>
                              <th> دکه نگهباني
                                <asp:TextBox runat="server" ID="txtnegahbanisum" CssClass="txtgrid"></asp:TextBox>

</th>
                              <th>انبار
                                <asp:TextBox runat="server" ID="txtAnbarSum" CssClass="txtgrid"></asp:TextBox>


</th>

                                <th>غیر خاکی
                                <asp:TextBox runat="server" ID="txtghirkhakisum" CssClass="txtgrid"></asp:TextBox>

</th>
                              <th>خاکی
                                <asp:TextBox runat="server" ID="txtkhakisum" CssClass="txtgrid"></asp:TextBox>
</th>
                              <th>مترمربع
<asp:TextBox runat="server" ID="txtAbnammetrSum" CssClass="txtgrid"></asp:TextBox>

</th>
                              <th>تعداد
<asp:TextBox runat="server" ID="txtAbnammetrNum" CssClass="txtgrid"></asp:TextBox>

 </th>
                             
                                <th colspan="1">گلخانه
<asp:TextBox runat="server" ID="txtGolkhanehSum" CssClass="txtgrid"></asp:TextBox>

 	 </th>

                              <th>خزانه
<asp:TextBox runat="server" ID="txtKhazaneh" CssClass="txtgrid"></asp:TextBox>

</th>
                              <th>اتاقك چاه آب
                                  <br />
<asp:TextBox runat="server" ID="txtOtaghakChahSum" CssClass="txtgrid"></asp:TextBox>

</th>
                              <th>چاله كود
<asp:TextBox runat="server" ID="txtChaleKodSum" CssClass="txtgrid"></asp:TextBox>

</th>

<th> نيمكت
<asp:TextBox runat="server" ID="txtNimkatSum" CssClass="txtgrid"></asp:TextBox>

</th>
<th> سطل زباله
<asp:TextBox runat="server" ID="txtSatlZobaleSum" CssClass="txtgrid"></asp:TextBox>

 </th>
<th> دستگاه
<asp:TextBox runat="server" ID="txtAbkhriDastgahSum" CssClass="txtgrid"></asp:TextBox>

</th>
<th>شیر آب
<asp:TextBox runat="server" ID="txtAbkhriShirAbSum" CssClass="txtgrid"></asp:TextBox>

  </th>                           
<th> فلاور باكس
<asp:TextBox runat="server" ID="txtFlowerBoxSum" CssClass="txtgrid"></asp:TextBox>

</th>
<th> تندیس
مجسمه
    <br />
<asp:TextBox runat="server" ID="txtTandisSum" CssClass="txtgrid"></asp:TextBox>

 </th>                             
<th>جعبه برق
<asp:TextBox runat="server" ID="txtBarghSum" CssClass="txtgrid"></asp:TextBox>

 </th>
<th> پایه 
<asp:TextBox runat="server" ID="txtroshanKotahPeyeSum" CssClass="txtgrid"></asp:TextBox>

 </th>                          
<th>شعله
<asp:TextBox runat="server" ID="txtroshanKotahSholeSum" CssClass="txtgrid"></asp:TextBox>

 </th>
<th> پایه 
<asp:TextBox runat="server" ID="txtroshanBolandPeyeSum" CssClass="txtgrid"></asp:TextBox>

 </th>                          
<th> شعله
<asp:TextBox runat="server" ID="txtroshanBolandSholeSum" CssClass="txtgrid"></asp:TextBox>

</th>
<th>  پایه 
<asp:TextBox runat="server" ID="txtPrejectorPayesum" CssClass="txtgrid"></asp:TextBox>

</th>     
<th> شعله
<asp:TextBox runat="server" ID="txtPrejectorSholesum" CssClass="txtgrid"></asp:TextBox>

 </th>  
<th>  پایه 
<asp:TextBox runat="server" ID="txtBorjPayesum" CssClass="txtgrid"></asp:TextBox>

</th>     
<th> شعله
<asp:TextBox runat="server" ID="txtBorjSholesum" CssClass="txtgrid"></asp:TextBox>

 </th> 
<th>تابلو شارژر
<asp:TextBox runat="server" ID="txtmobileSum" CssClass="txtgrid"></asp:TextBox>

</th>
                              <th>چاه ارث
                               
<asp:TextBox runat="server" ID="txtzanjirSum" CssClass="txtgrid"></asp:TextBox>

</th>   
                              <th>
                                  تابلو و علائم پارکی
<asp:TextBox runat="server" ID="txtTabloSum" CssClass="txtgrid"></asp:TextBox>

</th>   
                              <th> زنجیر
<asp:TextBox runat="server" ID="txtZanjirSUM55" CssClass="txtgrid"></asp:TextBox>

</th> 
                              <th> پایه
<asp:TextBox runat="server" ID="txtmileSum" CssClass="txtgrid"></asp:TextBox>

</th>  
                              <th> نرده
<asp:TextBox runat="server" ID="txtuSum" CssClass="txtgrid"></asp:TextBox>

</th>  
                                 

                        </tr>                    

                  </HeaderTemplate>
                  <ItemTemplate>
           
               
                     <asp:Label runat="server"  ID="RowNum"   Text='<%# Convert.ToString(Convert.ToInt32(DataBinder.Eval(Container, "DataItemIndex"))+1) %> '></asp:Label> 
                    <td class=""> <asp:Label Width="150px" runat="server" ID="PName" Text='<%#Eval("ParkName") %>' ></asp:Label></td>
         
 
                      <td  ><asp:TextBox data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"حضور نیروی بحران روز" %>' runat="server" ID="txtbohranRoz" CssClass="txtgrid"></asp:TextBox></td>
                      <td  ><asp:TextBox data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"حضور نیروی بحران" %>' runat="server" ID="txtbohranSahb" CssClass="txtgrid"></asp:TextBox></td>
                      <td  ><asp:TextBox data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"پارکیان روز" %>' runat="server" ID="txtParkbanRoz" CssClass="txtgrid"></asp:TextBox></td>
                      <td  ><asp:TextBox data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"پارکیان" %>' runat="server" ID="txtParkbanshab" CssClass="txtgrid"></asp:TextBox></td>
                  <td  >
<%--                       <asp:TextBox runat="server" ID="txtChaman_Kol" CssClass="txtgrid"></asp:TextBox>--%>

                   </td>

                      <td  ><asp:TextBox data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"اداری" %>' runat="server" ID="txtEdari" CssClass="txtgrid"></asp:TextBox></td>
                    <td> <asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"نگهبانی" %>'  runat="server" ID="txtnegahbani"  CssClass="txtgrid" ></asp:TextBox></td>
                    <td> <asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"انبار" %>'  runat="server" ID="txtanbar"  CssClass="txtgrid"></asp:TextBox></td>

                   <td  ><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"پیاده_غیر خاکی" %>'  runat="server" ID="txt_Piadeh_GhirKhaki" CssClass="txtgrid"></asp:TextBox></td>
                     <td> <asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"پیاده_خاکی" %>'  runat="server" ID="txt_Piadeh_Khaki"  CssClass="txtgrid"></asp:TextBox></td>
                    <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"آینما_متر" %>'  runat="server" ID="txtAbnama_Metr"  CssClass="txtgrid"></asp:TextBox> </td>
                    <td><asp:TextBox data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"آبنما_تعداد" %>' runat="server" ID="txtAbnama_Num"  CssClass="txtgrid"/> </td>
              
                    <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"گلخانه" %>' runat="server" ID="txtgolkhaneh"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"خزانه" %>'  runat="server" ID="txt_Khazaneh"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"اتاقک چاه" %>'  runat="server" ID="txtOtaghak_Chah"  CssClass="txtgrid"/> </td>

                    <td><asp:TextBox data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"چاله کود" %>'  runat="server" ID="txtChalecode"  CssClass="txtgrid"/> </td>
            
                              <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"نیمکت" %>' runat="server" ID="txtNimkat"  CssClass="txtgrid"/> </td>
                     <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"سطل زباله" %>' runat="server" ID="txtSatle_Zobale"  CssClass="txtgrid"/> </td>
 
                      
                    <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"آبخوری_دستگاه" %>' runat="server" ID="txtAbkhori_Datgah"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"آبخوری-شیر" %>' runat="server" ID="txtAbkhri_Shir"  CssClass="txtgrid"/> </td>
 
                  

                    <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"فلاور باکس" %>' runat="server" ID="txt_FlowerBox"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"تندیس" %>' runat="server" ID="txtTandis"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"جعبه برق" %>' runat="server" ID="TxtBargh_Box"  CssClass="txtgrid"/> </td>

                    <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"روشنایی پایه کوتاه" %>' runat="server" ID="txtRoshanaei_Kotah_Paye"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"روشنایی پایه کوتاه شعله" %>'  runat="server" ID="txtRoshanaei_Kotah_Sholeh"  CssClass="txtgrid"/> </td>
                  
                      
 
                    <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"روشنایی پایه بلند-پایه" %>'  runat="server" ID="txtRoshanaei_Boland_Paye"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"روشنایی پایه بلند-شعله" %>'   runat="server" ID="txtRoshanaei_Boland_Shole"  CssClass="txtgrid"/> </td>

                    <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"پایه پرژکتور" %>'   runat="server" ID="txtProject_Paye"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"پایه شعله" %>'  runat="server" ID="txtProject_Shole"  CssClass="txtgrid"/> </td>
                 
                         <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"پایه برج نوری" %>'  runat="server" ID="txtBorj_Paye"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"برج شعله" %>'  runat="server" ID="txtBorj_Shole"  CssClass="txtgrid"/> </td>

                     <td><asp:TextBox data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"تابلو شارژر" %>'   runat="server" ID="txtSharjMobile"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"چاه ارث" %>'  runat="server" ID="txtzanjir"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"تابلو" %>'  runat="server" ID="txtTablo"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"زنجیر" %>'  runat="server" ID="txtzanjir55"  CssClass="txtgrid"/> </td>

                    <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"پایه" %>'  runat="server" ID="txtmileh"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"نرده" %>'  runat="server" ID="txtu"  CssClass="txtgrid"/> </td>

 

          
                   </ItemTemplate>
             </asp:TemplateField>
             
             <asp:TemplateField Visible="false" ><ItemTemplate ><asp:Label runat="server" ID="lblPark" Text='<%# Eval("ParkID").ToString() %>' ></asp:Label></ItemTemplate></asp:TemplateField>

        </Columns>
    </asp:GridView>
    </div>
    <asp:Button runat="server" ID="btnAdd" Text="ثبت"  OnClick="btnAdd_Click"/>
    <script language="javascript" type="text/javascript">
        $(document).ready(function () {
            //For navigating using left and right arrow of the keyboard
            $("input[type='text'], select").keydown(
function (event) {
    if ((event.keyCode == 37) || (event.keyCode == 9 && event.shiftKey == false)) {
        var inputs = $(this).parents("form").eq(0).find("input[type='text'], select");
        var idx = inputs.index(this);
        if (idx == inputs.length - 1) {
            inputs[0].select()
        } else {
            $(this).parents("table").eq(0).find("tr").not(':first').each(function () {

                $(this).attr("style", "BACKGROUND-COLOR: white; COLOR: #003399");
            });
            inputs[idx + 1].parentNode.parentNode.style.backgroundColor = "Aqua";
            inputs[idx + 1].focus();
        }
        return false;
    }

    if ((event.keyCode == 39) || (event.keyCode == 9 && event.shiftKey == true)) {
        var inputs = $(this).parents("form").eq(0).find("input[type='text'], select");
        var idx = inputs.index(this);
        if (idx > 0) {
            $(this).parents("table").eq(0).find("tr").not(':first').each(function () {

                $(this).attr("style", "BACKGROUND-COLOR: white; COLOR: #003399");
            });
            inputs[idx - 1].parentNode.parentNode.style.backgroundColor = "Aqua";

            inputs[idx - 1].focus();
        }
        return false;
    }
});

            //For navigating using up and down arrow of the keyboard
            $("input[type='text'], select").keydown(
function (event) {
    if ((event.keyCode == 40)) {
        if ($(this).parents("tr").next() != null) {
            var nextTr = $(this).parents("tr").next();
            var inputs = $(this).parents("tr").eq(0).find("input[type='text'], select");
            var idx = inputs.index(this);
            nextTrinputs = nextTr.find("input[type='text'], select");
            if (nextTrinputs[idx] != null) {
                $(this).parents("table").eq(0).find("tr").not(':first').each(function () {

                    $(this).attr("style", "BACKGROUND-COLOR: white; COLOR: #003399");
                });
                nextTrinputs[idx].parentNode.parentNode.style.backgroundColor = "Aqua";
                nextTrinputs[idx].focus();
            }
        }
        else {
            $(this).focus();
        }
    }

    if ((event.keyCode == 38)) {
        if ($(this).parents("tr").next() != null) {
            var nextTr = $(this).parents("tr").prev();
            var inputs = $(this).parents("tr").eq(0).find("input[type='text'], select");
            var idx = inputs.index(this);
            nextTrinputs = nextTr.find("input[type='text'], select");
            if (nextTrinputs[idx] != null) {
                $(this).parents("table").eq(0).find("tr").not(':first').each(function () {

                    $(this).attr("style", "BACKGROUND-COLOR: white; COLOR: #003399");
                });
                nextTrinputs[idx].parentNode.parentNode.style.backgroundColor = "Aqua";
                nextTrinputs[idx].focus();
            }
            return false;
        }
        else {
            $(this).focus();
        }
    }
});
        });
    </script>
</asp:Content>
