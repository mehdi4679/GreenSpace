<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/DashBordMaster.Master" AutoEventWireup="true" CodeBehind="MahsolDaramad.aspx.cs" Inherits="GreenSpace.Manage.Tree.MahsolDaramad" %>
<%@ Register src="~/Controls/TreeControls/CtlMahsolDaramad.ascx" tagname="CtlMahsolDaramad" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="topMenuProfile" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="subMaster" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="contectMenuHo" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:CtlMahsolDaramad ID="CtlMahsolDaramad1" runat="server" />
</asp:Content>
