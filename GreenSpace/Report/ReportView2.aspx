﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportView2.aspx.cs" Inherits="GreenSpace.Report.ReportView2"   EnableTheming="false"  Theme="Theme2" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>


<%--<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>--%>
<%--<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>--%>
<%--<%@ Register Assembly="Microsoft.Reporting.RdlBuildProvider, Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>--%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
      
    <rsweb:reportviewer ID="ReportViewer1" runat="server"
          CssClass="tB"
         Font-Names="Tahoma"   
    Font-Size="8pt" 
    WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" 
              Width="100%" Height="80%" 
        ></rsweb:reportviewer>
    </div>
    <p>
              </p>
    </form>
    </body>
</html>
