<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/DashBordMaster.Master" AutoEventWireup="true" CodeBehind="AreaAll.aspx.cs" Inherits="GreenSpace.Manage.AreaAll" %>

<%@ Register Src="~/Controls/CtlAllSubjectExplan.ascx" TagPrefix="uc3" TagName="CtlAllSubjectExplan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="topMenuProfile" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="subMaster" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="contectMenuHo" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <table><tr><td>شرح کار</td><td> 
            <uc3:CtlAllSubjectExplan ID="TXTExplanID" runat="server" />
                                        </td><td>
    
    
    </td><td>
</td><td></td></tr></table>
        <table>
        <tr><td>قرارداد:</td><td><asp:DropDownList runat="server" ID="ddagree" AutoPostBack="True" OnSelectedIndexChanged="ddPeyman_SelectedIndexChanged"></asp:DropDownList></td></tr></table>
        <table><tr><td>پیمان:</td><td><asp:DropDownList runat="server" ID="ddPeyman" AutoPostBack="True" OnSelectedIndexChanged="ddPeyman_SelectedIndexChanged1"></asp:DropDownList></td></tr></table>
    <asp:CheckBox runat="server" ID="chCheckAllAreaPark" AutoPostBack="true" Text="نمایش متراژ کل هر پارک" OnCheckedChanged="chCheckAllAreaPark_CheckedChanged" /><br />
    <asp:Button runat="server" ID="btnShoww" Text="نمایش" OnClick="btnShoww_Click" />
    <asp:Button runat="server" ID="Button1" Text="درصد زنی اتوماتیک استفاده از کل" OnClick="Button1_Click" />

   <div>
       <div class="row">
           <div class="col-md-1">تعداد:</div>
           <div class="col-md-3">           <asp:Label runat="server" ID="lblsumkol" ></asp:Label>
</div>
       </div>
 <asp:GridView ID="Grid1"  runat="server" AutoGenerateColumns="False" AllowPaging="True" SkinID="grid1"
               AllowSorting="True" PageSize="150" >
<Columns>
            <asp:TemplateField HeaderText="ردیف">
            <ItemTemplate >
            <asp:Label runat="server"  ID="RowNum"   Text='<%# Convert.ToString(Convert.ToInt32(DataBinder.Eval(Container, "DataItemIndex"))+1) %> '></asp:Label>
            </ItemTemplate>
            </asp:TemplateField>
       <asp:BoundField DataField="ParkName"  HeaderText="نام پارک"   SortExpression="ParkName" />
       <asp:BoundField DataField="fff"  HeaderText="شرح کار"   SortExpression="fff" />
     <asp:TemplateField  Visible="false" >
        <ItemTemplate>   
 <asp:Label data-rel="tooltip"   runat="server" ID="LblUseFromKol" Text='<%#Eval("UseFromKol").ToString() %>' CssClass="txtgrid"></asp:Label> 
            </ItemTemplate>
         </asp:TemplateField>
     <asp:TemplateField HeaderText="نام پارک" Visible="false" >
        <ItemTemplate>   
 <asp:Label data-rel="tooltip"   runat="server" ID="lblPakID" Text='<%#Eval("ParkIDParkID").ToString() %>' CssClass="txtgrid"></asp:Label> 
            </ItemTemplate>
         </asp:TemplateField>

     <asp:TemplateField  HeaderText="شماره فرآیند">
        <ItemTemplate>   
 <asp:Label data-rel="tooltip"   runat="server" ID="LblAreaID" Text='<%#Eval("AreaID").ToString() %>' CssClass="txtgrid"></asp:Label> 
            </ItemTemplate>
         </asp:TemplateField>

    <asp:TemplateField HeaderText="مقدار">
        <ItemTemplate>
 <asp:TextBox data-rel="tooltip"   data-original-title='<%#Eval("ParkName").ToString()  %>' Text='<%#Eval("UnitNumber").ToString() %>' runat="server" ID="txtUniteNumber"  CssClass="txtgrid"></asp:TextBox> 
        </ItemTemplate>
</asp:TemplateField>

    <asp:TemplateField HeaderText="توضیحات">
        <ItemTemplate>
 <asp:TextBox data-rel="tooltip"  TextMode="MultiLine"     runat="server" ID="txtComment"  CssClass="txtgrid"></asp:TextBox> 
        </ItemTemplate>
</asp:TemplateField>




    </Columns>

       </asp:GridView>
   </div>
   
    <asp:Button runat="server" ID="btnSave" Text="ذخیره" OnClick="btnSave_Click" />


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
