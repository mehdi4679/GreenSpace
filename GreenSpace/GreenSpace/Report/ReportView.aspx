<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Report/RepMaster.master" CodeBehind="ReportView.aspx.cs" Inherits="GreenSpace.Report.ReportView" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<%--<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>--%>


<asp:Content runat="server" ContentPlaceHolderID="PesonContentPlaceHolder" ID="cont11">
    <style type="text/css"> 
 .tdB
        {
            background-color: #FFCCCC;
            padding-right: 10px;
            padding-left:10px;
              
        }
         .tB
        {
      direction:rtl ;
              
        }
    </style>
    <div align="center" style="padding:10px"  >
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    <rsweb:ReportViewer ID="ReportViewer1" runat="server"  
        CssClass="tB"
         Font-Names="Tahoma"   
    Font-Size="8pt" 
    WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" 
              Width="90%" Height="80%" 
          >
        
        </rsweb:ReportViewer>
    </div>
</asp:Content>
 
<%--<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center" style="padding:10px"  >
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="80%" Height="80%"   >
        </rsweb:ReportViewer>
    </div>
        
        
    </form>
</body>
</html>--%>
