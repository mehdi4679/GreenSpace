<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Bazras.master" AutoEventWireup="true" CodeBehind="AllProtest.aspx.cs" Inherits="GreenSpace.Bazras.AllProtest" %>

<%@ Register Src="~/Controls/CtlAgreePercentProtest.ascx" TagPrefix="uc1" TagName="CtlAgreePercentProtest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:CtlAgreePercentProtest runat="server" ID="CtlAgreePercentProtest" />
</asp:Content> 
