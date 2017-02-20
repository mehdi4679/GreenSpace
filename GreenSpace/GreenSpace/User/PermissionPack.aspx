<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/DashBordMaster.Master" AutoEventWireup="true" CodeBehind="PermissionPack.aspx.cs" Inherits="Taxi.Userff.PermissionPack" %>
<%@ Register src="~/Controls/user/CtlUserPPack.ascx" tagname="CtlUserPPack" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="topMenuProfile" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="subMaster" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:CtlUserPPack ID="CtlUserPPack1" runat="server" />
</asp:Content>
