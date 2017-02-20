<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/DashBordMaster.Master" AutoEventWireup="true" CodeBehind="AbBaha.aspx.cs" Inherits="GreenSpace.Manage.Tree.AbBaha" %>
<%@ Register src= "~/Controls/TreeControls/CtlAbBaha.ascx" tagname="CtlAbBaha" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="topMenuProfile" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="subMaster" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="contectMenuHo" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:CtlAbBaha ID="CtlAbBaha1" runat="server" />
</asp:Content>
