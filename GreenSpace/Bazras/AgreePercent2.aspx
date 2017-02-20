<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Bazras.master" AutoEventWireup="true" CodeBehind="AgreePercent2.aspx.cs" Inherits="GreenSpace.Bazras.AgreePercent2" %>

<%@ Register Src="~/Controls/CtlAgreePercent22.ascx" TagPrefix="uc1" TagName="CtlAgreePercent22" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .txt{width:70px;
             height:30px
        }
    </style>

</asp:Content>
<asp:Content runat="server" ID="sdcsv" ContentPlaceHolderID="ContentPlaceHolder1">

    <uc1:CtlAgreePercent22 runat="server" id="CtlAgreePercent22" />

</asp:Content>
