<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Bazras.master" AutoEventWireup="true" CodeBehind="khesarat.aspx.cs" Inherits="GreenSpace.Bazras.khesarat" %>

<%@ Register Src="~/Controls/CtlAgreementFine.ascx" TagPrefix="uc1" TagName="CtlAgreementFine" %>
<asp:Content runat="server" ID="sdcsv" ContentPlaceHolderID="ContentPlaceHolder1">
    <uc1:CtlAgreementFine runat="server" ID="CtlAgreementFine" />
</asp:Content>
