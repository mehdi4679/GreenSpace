<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/DashBordMaster.Master" AutoEventWireup="true" CodeBehind="DefaultPrice.aspx.cs" Inherits="GreenSpace.Manage.DefaultPrice" %>
<%@ Register src="~/Controls/CtlAgreeExplanPrice.ascx" tagname="CtlAgreeExplanPrice" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="topMenuProfile" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="subMaster" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:CtlAgreeExplanPrice ID="CtlAgreeExplanPrice1" runat="server" />
</asp:Content>
