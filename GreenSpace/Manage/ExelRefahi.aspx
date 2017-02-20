<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/DashBordMaster.Master" AutoEventWireup="true" CodeBehind="ExelRefahi.aspx.cs" Inherits="GreenSpace.Manage.ExelRefahi" %>
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
    <asp:GridView runat="server" ID="Grid1"  AutoGenerateColumns="false" PageSize="3">
         <Columns> 
 
            
              <asp:TemplateField>
        
                  <HeaderTemplate>
                       
                          <tr class="gvHeader" >
                          <th>ردیف</th>
                          <th>پارک</th>
                          <th colspan="100">امكانات رفاهي																																						
																																						
</th>

                          </tr>
                          <tr class="gvHeader">
                              <th></th>
                              <th></th>
                              <th colspan="4">سرويس بهداشتي		
</th>
                              <th colspan="2">نمازخانه	
</th>
                              <th colspan="2">رستوران	
		</th>
                              <th colspan="2">غرفه تنقلات	
 </th>
                              <th colspan="2">كمپينگ	
 </th>
                              <th colspan="2">سكوي نشيمن	
 	 </th>
                              <th colspan="4">زمين بازي كودكان		
	
 	 </th>
                              <th colspan="8">وسايل بازي كودكان - وسایل ورزشی و تندرستی(دستگاه)								
	
 	 </th>
                          
                                   <th colspan="2"> زمین ورزشی	
				
	
	
 	 </th>                    
                                    <th colspan="3">نوع زمين ورزشي (مترمربع)				
	
 	 </th>                    
                                     <th colspan="1">کباب پز
	
 	 </th>                    
                                      <th colspan="2">آلاچيق	
	
 	 </th>                     
                                       <th colspan="1">تلفن عمومي
	
 	 </th>                       
                                        <th colspan="1">ضبط صوت
  	 </th>                     
                                          <th colspan="1">آبسرد کن
    	 </th>                    
                                            <th colspan="1">..بلندگو ومیکروفن...


                                                <th></th>
                                                <th></th>
    	 </th>     
                              </tr>               
                       <tr class="gvHeader">
                               
                              <th></th>
                              <th></th>
                                  <th>مجموعه
                                      <asp:TextBox runat="server" CssClass="txtgrid" ID="txtServiceMajmoehSum"></asp:TextBox>
</th>
                                  <th>باب
                                      <asp:TextBox runat="server" CssClass="txtgrid" ID="txtServiceBabSUM"></asp:TextBox>
</th>
                            <th>چشمه
                                      <asp:TextBox runat="server" CssClass="txtgrid" ID="txtServiceCheshmeSUM"></asp:TextBox>

</th>
                              <th>مترمربع
                                      <asp:TextBox runat="server" CssClass="txtgrid" ID="txtServiceMetrSUM"></asp:TextBox>

</th>
                             
                              <th>نوع
                                      <asp:TextBox runat="server" CssClass="txtgrid" ID="txtnamazTypeSum"></asp:TextBox>

</th>
                                <th>مترمربع
                                      <asp:TextBox runat="server" CssClass="txtgrid" ID="txtNamazMetrSUM"></asp:TextBox>

</th>



                              <th>تعداد
                                      <asp:TextBox runat="server" CssClass="txtgrid" ID="txtRestornNumSUM"></asp:TextBox>

</th>
                              <th>مترمربع
                                      <asp:TextBox runat="server" CssClass="txtgrid" ID="txtRestornMetrSUM"></asp:TextBox>

</th>
                             
                               <th>تعداد
                                      <asp:TextBox runat="server" CssClass="txtgrid" ID="txtGorfeNummUM"></asp:TextBox>

</th>
                              <th>مترمربع
                                      <asp:TextBox runat="server" CssClass="txtgrid" ID="txtghorfeMetrSUM"></asp:TextBox>

</th>
                               
                             
                                <th>تعداد
                                      <asp:TextBox runat="server" CssClass="txtgrid" ID="txtKampingNumSUM"></asp:TextBox>

</th>
                              <th>مترمربع
                                      <asp:TextBox runat="server" CssClass="txtgrid" ID="txtKampingMetrSUM"></asp:TextBox>

</th>
                               
                             
                                <th>تعداد
                                      <asp:TextBox runat="server" CssClass="txtgrid" ID="txtSakoNumSUM"></asp:TextBox>

</th>
                              <th>مترمربع
                                      <asp:TextBox runat="server" CssClass="txtgrid" ID="txtSakometrSUM"></asp:TextBox>

</th>
                             
                              
                               

                              <th>تعداد
                                      <asp:TextBox runat="server" CssClass="txtgrid" ID="txtZaminKodakNumSUM"></asp:TextBox>

</th>
                              <th>متر مربع کفپوش
                                      <asp:TextBox runat="server" CssClass="txtgrid" ID="txtZaminKodakKafposh"></asp:TextBox>

</th>
                              <th>مترمربع  بدون کفپوش غیر خاکی
                                      <asp:TextBox runat="server" CssClass="txtgrid" ID="txtZaminKodakMetrGhirkhakiSUM"></asp:TextBox>

 </th>
                              <th>  مترمربع خاکی
                                      <asp:TextBox runat="server" CssClass="txtgrid" ID="txtZaminKodakMetrKhakiSUM"></asp:TextBox>

 </th>
                              <th>سرسره
                                      <asp:TextBox runat="server" CssClass="txtgrid" ID="txtSorsoreSUM"></asp:TextBox>

 </th>
                              <th>تاب
                                      <asp:TextBox runat="server" CssClass="txtgrid" ID="txttabSUM"></asp:TextBox>

</th>
                              <th>الاکلنگ
                                      <asp:TextBox runat="server" CssClass="txtgrid" ID="txtAlakolangSUM"></asp:TextBox>

</th>

                              <th>میز تنیس
                                      <asp:TextBox runat="server" CssClass="txtgrid" ID="txtTenisSUM"></asp:TextBox>

</th>
                                                         <th>فوتبالدستی
                                      <asp:TextBox runat="server" CssClass="txtgrid" ID="txtAsbSUM"></asp:TextBox>

</th>
                              <th>تندرستی
                                      <asp:TextBox runat="server" CssClass="txtgrid" ID="txtTandorostiSUM"></asp:TextBox>

</th>
                              

                              <th>جمع

</th>
<th>كمپلكس
                                      <asp:TextBox runat="server" CssClass="txtgrid" ID="txtKomplexSUM"></asp:TextBox>

</th>
                              <th>غیر خاکی مترمربع
                                      <asp:TextBox runat="server" CssClass="txtgrid" ID="txtzaminvarzeshiGhirkhkiSUM"></asp:TextBox>

</th>
                               <th>مترمربع خاکی
                                      <asp:TextBox runat="server" CssClass="txtgrid" ID="txtzaminvarzeshikhkiSUM"></asp:TextBox>

</th>
                               <th>اسکیت
                                      <asp:TextBox runat="server" CssClass="txtgrid" ID="txtEskitSUM"></asp:TextBox>

</th>
                               <th>فوتبال
                                      <asp:TextBox runat="server" CssClass="txtgrid" ID="txyFotballSUM"></asp:TextBox>

</th>
                               <th>واليبال
                                      <asp:TextBox runat="server" CssClass="txtgrid" ID="txtVollybalSUM"></asp:TextBox>

</th>
                               <th>تعداد
                                      <asp:TextBox runat="server" CssClass="txtgrid" ID="txtkabNumSUM"></asp:TextBox>

</th>
                               <th>تعداد
                                      <asp:TextBox runat="server" CssClass="txtgrid" ID="txtAlachighNumSUM"></asp:TextBox>


                               </th>
                               <th>مترمربع
                                      <asp:TextBox runat="server" CssClass="txtgrid" ID="txtAlachighMetrSUM"></asp:TextBox>

</th>
                               <th>تعداد
                                      <asp:TextBox runat="server" CssClass="txtgrid" ID="txtTelSUM"></asp:TextBox>

</th>
                               <th>تعداد
                                      <asp:TextBox runat="server" CssClass="txtgrid" ID="txtZabtSUM"></asp:TextBox>

</th>
                                     
                               <th> <asp:TextBox runat="server" CssClass="txtgrid" ID="txtAbSardSum"></asp:TextBox> 

                               </th>
                                  <th>     <asp:TextBox runat="server" CssClass="txtgrid" ID="txtMicSUM"></asp:TextBox>
                                </th>
                           <th>معبر غیر خاکی
<%--                                      <asp:TextBox runat="server" CssClass="txtgrid" ID="txtMabarGhirkhkiSum"></asp:TextBox>--%>

                           </th>
                           <th>معبر   خاکی
<%--                                      <asp:TextBox runat="server" CssClass="txtgrid" ID="txtMabakhakiSum"></asp:TextBox>--%>

                           </th>
                          </tr>
                     

                  </HeaderTemplate>
                  <ItemTemplate>
           
               
                     <asp:Label runat="server"  ID="RowNum"   Text='<%# Convert.ToString(Convert.ToInt32(DataBinder.Eval(Container, "DataItemIndex"))+1) %> '></asp:Label> 
                    <td> <asp:Label   runat="server" ID="PName" Text='<%#Eval("ParkName") %>'  CssClass="txtgrid"></asp:Label></td>
                   <td  ><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"سرویس_مجموعه" %>' runat="server" ID="txtService_majmoeh" CssClass="txtgrid"></asp:TextBox></td>
                   <td  ><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"سرویس_باب" %>' runat="server" ID="txtService_BAB" CssClass="txtgrid"></asp:TextBox></td>
                   <td  ><asp:TextBox   data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"سرویس_چشمه" %>' runat="server" ID="txtservice_Cheshme" CssClass="txtgrid"></asp:TextBox></td>
                   <td> <asp:TextBox   data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"سرویس_متر مربع" %>' runat="server" ID="txtService_Metr"  CssClass="txtgrid" ></asp:TextBox></td>
                   
                  <td> <asp:TextBox   data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"نمازخانه_نوع" %>' runat="server" ID="txtNamazType"  CssClass="txtgrid"></asp:TextBox></td>
                   <td  ><asp:TextBox   data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"نمازخانه_متر مربع" %>' runat="server" ID="txtNamazMetr" CssClass="txtgrid"></asp:TextBox></td>

                   <td><asp:TextBox   data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"رستوران_تعداد" %>' runat="server" ID="txtRestoranNumber"  CssClass="txtgrid"></asp:TextBox> </td>
                    <td><asp:TextBox   data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"رستوران_متر" %>' runat="server" ID="txtRestoranMetr"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox   data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"غرفه_تعداد" %>' runat="server" ID="txtghorfeNumber"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox   data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"غرفه_متر" %>' runat="server" ID="txtGhorfeMetr"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox   data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"کمپینگ_نعداد" %>' runat="server" ID="txtKampinNumber"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox   data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"کمپینک_متر" %>' runat="server" ID="txtKampinMetr"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"سکو_تعداد" %>' runat="server" ID="txtSakoNumber"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"سکو_متر" %>' runat="server" ID="txtSakoMetr"  CssClass="txtgrid"/> </td>

                    <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"زمین کودک_تعداد" %>' runat="server" ID="txtZaminKodak_Num22"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"زمین کودک_کفپوش" %>' runat="server" ID="txtZaminKodak_Kafposh"  CssClass="txtgrid"/> </td>

                    <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"کودک_بدون کفپوش غیر خاکی" %>' runat="server" ID="txtZaminKodak_metr22"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"کودک_خاکی" %>' runat="server" ID="txtZaminKodak_Khaki22"  CssClass="txtgrid"/> </td>
                 
                    
                    <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"سرسره" %>' runat="server" ID="txtbaziSorsore"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"تاب" %>' runat="server" ID="txtbazitab"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"الاکلنگ" %>' runat="server" ID="txtbaziAlakolang"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"تنیس" %>' runat="server" ID="txtbaziMizTenis"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"فوتبالدستی" %>' runat="server" ID="txtbaziasb"  CssClass="txtgrid"/> </td>

                    <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"تندرستی" %>' runat="server" ID="tatbazitandorosti"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"" %>' runat="server" ID="txtbazi_SUm"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"کمپلکس" %>' runat="server" ID="txtbazicomlex"  CssClass="txtgrid"/> </td>


                    <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"ورزشی_غیرخاکی" %>' runat="server" ID="txtZaminVareshi_ghirKhaki"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"ورزشی_خاکی" %>' runat="server" ID="txtZaminVarzeshi_Khaki"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"اسکیت" %>' runat="server" ID="txtZaminType_Eskit"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"فوتبال" %>' runat="server" ID="txtZaminType_Footbal"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"والیبال" %>' runat="server" ID="txtZaminType_Volyybal"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"کباب پز" %>' runat="server" ID="txtKababPaz"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"آلاچیق_تعداد" %>' runat="server" ID="txtAlachigh_Num"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox   data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"آلاچیق_متر" %>' runat="server" ID="txtAlachigh_Meter"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"تلفن" %>' runat="server" ID="txtTel"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"ضبط" %>' runat="server" ID="txtzabt"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"آبسردکن" %>' runat="server" ID="txtabsardkon"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"میکروفن" %>' runat="server" ID="txtmicrophon"  CssClass="txtgrid"/> </td>
                    <td><asp:Label  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"خاکی_معبر" %>' runat="server" ID="txtKhakiMabar"  CssClass="txtgrid"/> </td>
                    <td><asp:Label  data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"غیر خاکی" %>' runat="server" ID="txtGhirKhakiMabar"  CssClass="txtgrid"/> </td>

                   </ItemTemplate>
             </asp:TemplateField>
             
             <asp:TemplateField Visible="false" ><ItemTemplate ><asp:Label runat="server" ID="lblPark" Text='<%# Eval("ParkID").ToString() %>' ></asp:Label></ItemTemplate></asp:TemplateField>

        </Columns>
    </asp:GridView>
    </div>
    <asp:Button runat="server" ID="btnAdd" Text="ثبت"  OnClick="btnAdd_Click" />
<%--OnClick="btnAdd_Click"--%>
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
