<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/DashBordMaster.Master" AutoEventWireup="true" CodeBehind="USerPerMission.aspx.cs" Inherits="Taxi.Uservv.USerPerMission" %>
<%@ Register src="~/Controls/user/CtlUserPermission.ascx" tagname="CtlUserPermission" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="topMenuProfile" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="subMaster" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:CtlUserPermission ID="CtlUserPermission1" runat="server" />
</asp:Content>
