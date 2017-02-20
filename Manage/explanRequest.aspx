<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/DashBordMaster.Master" AutoEventWireup="true" CodeBehind="explanRequest.aspx.cs" Inherits="GreenSpace.Manage.explanRequest" %>
<%@ Register src="/Controls/CtlExplanRequest.ascx" tagname="CtlExplanRequest" tagprefix="uc1" %>
 

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="topMenuProfile" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="subMaster" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="contectMenuHo" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <uc1:CtlExplanRequest ID="CtlExplanRequest1" runat="server" />
    </asp:Content>
