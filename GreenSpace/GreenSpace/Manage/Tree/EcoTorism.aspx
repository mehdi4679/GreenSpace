<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/DashBordMaster.Master" AutoEventWireup="true" CodeBehind="EcoTorism.aspx.cs" Inherits="GreenSpace.Manage.Tree.EcoTorism" %>
<%@ Register src="~/Controls/TreeControls/CtlEcotorism.ascx" tagname="CtlEcotorism" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="topMenuProfile" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="subMaster" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="contectMenuHo" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:CtlEcotorism ID="CtlEcotorism1" runat="server" />
</asp:Content>
