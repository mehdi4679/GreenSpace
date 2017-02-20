<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/AgreeMaster.master" AutoEventWireup="true" CodeBehind="AgreeStatus.aspx.cs" Inherits="GreenSpace.Agree.AgreeStatus" %>
 
 

<%@ Register src="../Controls/CtlAgreeStatus.ascx" tagname="CtlAgreeStatus" tagprefix="uc1" %>
 


<asp:Content ID="Content1" ContentPlaceHolderID="PesonContentPlaceHolder" runat="server">
        

    <uc1:CtlAgreeStatus ID="CtlAgreeStatus1" runat="server" />
        

</asp:Content>
