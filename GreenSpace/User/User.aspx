<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/DashBordMaster.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="Taxi.User" %>
<%@ Register src="~/Controls/user/CtlUser.ascx" tagname="CtlUser" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
    <uc1:CtlUser ID="CtlUser1" runat="server" />
</asp:Content>
