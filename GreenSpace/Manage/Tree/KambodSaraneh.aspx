<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/DashBordMaster.Master" AutoEventWireup="true" CodeBehind="KambodSaraneh.aspx.cs" Inherits="GreenSpace.Manage.Tree.KambodSaraneh" %>
<%@ Register src="~/Controls/TreeControls/CtlKambodSaraneh.ascx" tagname="CtlKambodSaraneh" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="topMenuProfile" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="subMaster" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="contectMenuHo" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:CtlKambodSaraneh ID="CtlKambodSaraneh1" runat="server" />
</asp:Content>
