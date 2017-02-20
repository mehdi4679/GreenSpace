<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/DashBordMaster.Master" AutoEventWireup="true" CodeBehind="AreaExel.aspx.cs" Inherits="GreenSpace.Manage.AreaExel" %>
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
   
     <div style="width:100%;overflow:auto ">
    <asp:GridView runat="server" ID="Grid1"  AutoGenerateColumns="false" PageSize="3">
         <Columns> 
 
            
              <asp:TemplateField>
        
                  <HeaderTemplate>
                       
                          <tr class="gvHeader" >
                          <th>ردیف</th>
                          <th>پارک</th>
                          <th colspan="50">فضای سبز</th>

                          </tr>
                          <tr class="gvHeader">
                              <th></th>
                              <th></th>
                              <th colspan="4">چمن/متر مربع</th>
                              <th colspan="4">پرچینی /متر مربع</th>
                              <th colspan="3">پوششی/مترمربع		</th>
                               <th colspan="3">گل فصلی / متر مربع </th>.
                      
                                      <th colspan="3">رز و درختچه زینتی </th>

                              <th colspan="3">رز و درختچه زینتی / متر مربع </th>
                              <th colspan="10">درخت معابر و جنگلی داخل محدوده / متر مربع 	 </th>
                          </tr>
                          <tr class="gvHeader">
                               
                              <th></th>
                              <th></th>

                                  <th>کل</th>
                            <th>ابیاری دستی
                                <asp:TextBox CssClass="txtgrid" runat="server" ID="txtchamanDastiSum"></asp:TextBox>
                            </th>
                              <th>PSA
                                <asp:TextBox CssClass="txtgrid" runat="server" ID="txtchamanPSASum"></asp:TextBox>
                              </th>
                              <th>PGP
                                <asp:TextBox CssClass="txtgrid" runat="server" ID="txtchamanPGPSum"></asp:TextBox>
                              </th>

                                <th>کل</th>
                              <th>آب چاه
                                <asp:TextBox CssClass="txtgrid" runat="server" ID="txtparchinAbChahSum"></asp:TextBox>

                              </th>
                              <th>شلنگی
                                <asp:TextBox CssClass="txtgrid" runat="server" ID="txtParchinShilangSum"></asp:TextBox>

                              </th>
                              <th>تحت فشار
                                <asp:TextBox CssClass="txtgrid" runat="server" ID="txtParchinFesharSum"></asp:TextBox>

                              </th>
                             
                               <th>کل</th>
                              <th>شلنگی
                                <asp:TextBox CssClass="txtgrid" runat="server" ID="txtPosheshiShilangSum"></asp:TextBox>

                              </th>
                              <th>تحت فشار 
                                <asp:TextBox CssClass="txtgrid" runat="server" ID="txtPosheshiFesharSum"></asp:TextBox>

                              </th>
                             
                                <th>کل</th>
                              <th>شلنگی
                                <asp:TextBox CssClass="txtgrid" runat="server" ID="txtGolfasliShilangSum"></asp:TextBox>

                              </th>
                              <th>تحت فشار 
                                <asp:TextBox CssClass="txtgrid" runat="server" ID="txtGolfasliFesharSum"></asp:TextBox>


                              </th>


                                   <th> </th>
                              <th>رز
                                <asp:TextBox  CssClass="txtgrid" runat="server" ID="txtRozSum"></asp:TextBox>

                              </th>
                              <th>درختچه 
                                <asp:TextBox CssClass="txtgrid" runat="server" ID="txtRozderakhtSum"></asp:TextBox>

                              </th>                                  
                              
                                                    
                                <th>کل</th>
                              <th>شلنگی
                                <asp:TextBox  CssClass="txtgrid" runat="server" ID="txtRozShilangSum"></asp:TextBox>

                              </th>
                              <th>تحت فشار 
                                <asp:TextBox CssClass="txtgrid" runat="server" ID="txtRozfesharSum"></asp:TextBox>

                              </th>
                              
                               

                              <th>کل</th>
                              <th>  حاشیه خیابان تانکری متر مربع
                                <asp:TextBox CssClass="txtgrid" runat="server" ID="txtHashieKhiabanSum"></asp:TextBox>


                              </th>

                              <th>آب چاه  بالاتر از نمره 6
                                <asp:TextBox CssClass="txtgrid" runat="server" ID="txtderakhtchahSum"></asp:TextBox>


                              </th>
                              <th>تشتکی  با شیلنگ و شیر برداشت (اصله) 
                                <asp:TextBox CssClass="txtgrid" runat="server" ID="txtderakhttashtakSum"></asp:TextBox>


                              </th>
                              <th>شلنگی کمتر از نمره 6
                                <asp:TextBox CssClass="txtgrid" runat="server" ID="txtderakhtshilangsum"></asp:TextBox>

                              </th>
                              <th>تحت فشار 
                                <asp:TextBox CssClass="txtgrid" runat="server" ID="txtderakhtfesharSum"></asp:TextBox>

                              </th>
                              <th>تشتکی-تانکری (اصله)
                                <asp:TextBox CssClass="txtgrid" runat="server" ID="txtderakhttankerSum"></asp:TextBox>

                              </th>



                          </tr>
                     

                  </HeaderTemplate>
                  <ItemTemplate>
           
               
                     <asp:Label runat="server"  ID="RowNum"    Text='<%# Convert.ToString(Convert.ToInt32(DataBinder.Eval(Container, "DataItemIndex"))+1) %> '></asp:Label> 
                    <td> <asp:Label  Width="150px" runat="server" ID="PName" Text='<%#Eval("ParkName") %>' ></asp:Label></td>
         
                   <td  ><asp:Label   runat="server" ID="txtChaman_Kol" CssClass="txtgrid"></asp:Label></td>
                      <td  ><asp:TextBox data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"چمن_آبیاری دستی" %>' runat="server" ID="txtChamanAbDasti" CssClass="txtgrid"></asp:TextBox></td>
                    <td> <asp:TextBox data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"چمن_PSA" %>' runat="server" ID="txtChamanPSA"  CssClass="txtgrid" ></asp:TextBox></td>
                    <td> <asp:TextBox data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"چمن_PGP" %>' runat="server" ID="txtChamanPGP"  CssClass="txtgrid"></asp:TextBox></td>

                   <td  ><asp:Label  runat="server" ID="LblParchin_Kol" CssClass="txtgrid"></asp:Label></td>
                     <td> <asp:TextBox data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"پرچین_آب چاه" %>' runat="server" ID="txtParchinAbChah"  CssClass="txtgrid"></asp:TextBox></td>
                    <td><asp:TextBox data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"پرچین_شیلنگ" %>' runat="server" ID="txtParchinShilang"  CssClass="txtgrid"></asp:TextBox> </td>
                    <td><asp:TextBox data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"پرچین_فشار" %>' runat="server" ID="txtParchinFeshar"  CssClass="txtgrid"/> </td>
              
                    <td><asp:Label  runat="server" ID="txt_Poshesh_KOL"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"پوششی_شیلنگ" %>' runat="server" ID="txtPoshesh_SHILANG"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"پوششی_فشار" %>' runat="server" ID="txtPoshesh_Feshar"  CssClass="txtgrid"/> </td>

                    <td><asp:Label   runat="server" ID="txt_Fasli_KOL"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"فصلی_شیلنگ" %>' runat="server" ID="txtFasli_SHILANG"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"فصلی_فشار" %>' runat="server" ID="txtFasli_Feshar"  CssClass="txtgrid"/> </td>
         

                      <td></td>
                    <td><asp:TextBox data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"رز" %>' runat="server" ID="txtROz"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"رز_درخچه" %>' runat="server" ID="txtROzDerakht"  CssClass="txtgrid"/> </td>


                    <td><asp:Label runat="server" ID="txt_ROz_KOL"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"رز_شیلنگ" %>' runat="server" ID="txtROz_SHILANG"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"رز_فشار" %>' runat="server" ID="txtROz_Feshar"  CssClass="txtgrid"/> </td>

                    <td><asp:Label runat="server" ID="txt_drakht_KOL"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"درخت حاشیه خیابان تانکری متر مربع" %>' runat="server" ID="txtHashieKhiaban"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"درخت آب چاه" %>' runat="server" ID="txtdrakht_AbChah"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"درخت تشتک" %>' runat="server" ID="txtdrakht_Tashtak"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"درخت شیلنگ" %>' runat="server" ID="txt_drakht_Shilang"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"درخت فشار" %>' runat="server" ID="txtdrakht_Feshar"  CssClass="txtgrid"/> </td>
                    <td><asp:TextBox data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString()+":"+"درخت تانکر" %>' runat="server" ID="txtdrakht_Tanker"  CssClass="txtgrid"/> </td>

          
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
