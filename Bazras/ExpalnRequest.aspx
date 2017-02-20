<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Bazras.master" AutoEventWireup="true" CodeBehind="ExpalnRequest.aspx.cs" Inherits="GreenSpace.Bazras.ExpalnRequest" %>
<%@ Register src="../Controls/CtlExplanRequest.ascx" tagname="CtlExplanRequest" tagprefix="uc1" %>
<asp:Content runat="server" ID="sdcsv" ContentPlaceHolderID="ContentPlaceHolder1">

    <uc1:CtlExplanRequest ID="CtlExplanRequest1" runat="server" />
</asp:Content>
