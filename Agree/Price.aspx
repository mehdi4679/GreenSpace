<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/AgreeMaster.master" AutoEventWireup="true" CodeBehind="Price.aspx.cs" Inherits="GreenSpace.Agree.Price" %>
<%@ Register src="~/Controls/CtlAgreeExplanPrice.ascx" tagname="CtlAgreeExplanPrice1" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PesonContentPlaceHolder" runat="server">
    <uc1:CtlAgreeExplanPrice1 runat="server" ID="CtlAgreeExplanPrice11" />
</asp:Content>
