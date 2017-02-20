<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/AgreeMaster.master" AutoEventWireup="true" CodeBehind="AgreePark.aspx.cs" Inherits="GreenSpace.Agree.AgreePark" %>
<%@ Register src="~/Controls/Ctlpp.ascx" tagname="CtlAgreepp1" tagprefix="uc1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="PesonContentPlaceHolder" runat="server">
    <asp:DropDownList runat="server" ID="DDPeymanID" AutoPostBack="true" OnSelectedIndexChanged="DDPeymanID_SelectedIndexChanged"></asp:DropDownList>
     <uc1:CtlAgreepp1 runat="server" ID="CtlAgreepp11" />
</asp:Content>
