﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportViewTree.aspx.cs" Inherits="GreenSpace.Report.ReportTree.ReportViewTree" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div align="center" style="padding:10px"  >
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="100%" Height="80%"   >
        </rsweb:ReportViewer>
    </div>
    </div>
    </form>
</body>
</html>
