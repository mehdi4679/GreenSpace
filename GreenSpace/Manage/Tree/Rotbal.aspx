﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/DashBordMaster.Master" AutoEventWireup="true" CodeBehind="Rotbal.aspx.cs" Inherits="GreenSpace.Manage.Tree.Rotbal" %>

<%@ Register Src="~/Controls/TreeControls/CtlRotbal.ascx" TagPrefix="uc1" TagName="CtlRotbal" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="topMenuProfile" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="subMaster" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="contectMenuHo" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:CtlRotbal runat="server" id="CtlRotbal" />
</asp:Content>
