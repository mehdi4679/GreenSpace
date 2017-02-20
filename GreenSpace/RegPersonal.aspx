<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/MainMaster.Master" AutoEventWireup="true" CodeBehind="RegPersonal.aspx.cs" Inherits="GreenSpace.RegPersonal" %>

<%@ Register Src="~/Controls/TreeControls/CtlPersonOnly.ascx" TagPrefix="uc1" TagName="CtlPersonOnly" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <uc1:CtlPersonOnly runat="server" ID="CtlPerson1" />
</asp:Content>
