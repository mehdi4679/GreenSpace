<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/DashBordMaster.Master" AutoEventWireup="true" CodeBehind="OneExplainArea.aspx.cs" Inherits="GreenSpace.Manage.OneExplainArea" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
    <table><tr><td>شرح کار:</td><td><asp:DropDownList runat="server" ID="ddExpalin"></asp:DropDownList></td></tr></table>

    
           <div style="width:100%;overflow:auto ">
    <asp:GridView runat="server" ID="Grid1"  AutoGenerateColumns="false" PageSize="3">
         <Columns> 
              <asp:TemplateField>
                  <ItemTemplate>
                                       <asp:Label runat="server"  ID="RowNum"    Text='<%# Convert.ToString(Convert.ToInt32(DataBinder.Eval(Container, "DataItemIndex"))+1) %> '></asp:Label> 
 </ItemTemplate>
                  <ItemTemplate><asp:Label  Width="150px" runat="server" ID="PName" Text='<%#Eval("ParkName") %>' ></asp:Label></ItemTemplate>
                  <ItemTemplate><asp:TextBox data-rel="tooltip" data-original-title='<%#Eval("ParkName").ToString() %>' runat="server" ID="txtChamanAbDasti" CssClass="txtgrid" /></ItemTemplate>
                  </asp:TemplateField>
             </Columns>
        </asp:GridView>
                 
    </div>
        <asp:Button runat="server" ID="btnAdd" Text="ثبت"  OnClick="btnAdd_Click"/>

</asp:Content>
