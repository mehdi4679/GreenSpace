<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/DashBordMaster.Master" AutoEventWireup="true" CodeBehind="Personels.aspx.cs" Inherits="GreenSpace.Manage.Tree.Personels" %>
<%@ Register src="~/Controls/TreeControls/CtlPersonal.ascx" tagname="CtlPersonal" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="topMenuProfile" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="subMaster" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="contectMenuHo" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:CtlPersonal ID="CtlPersonal1" runat="server" />
</asp:Content>
