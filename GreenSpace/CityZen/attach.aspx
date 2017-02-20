<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="attach.aspx.cs" Inherits="GreenSpace.CityZen.attach" %>

<%@ Register Src="~/Controls/CtlAttach.ascx" TagPrefix="uc1" TagName="CtlAttach" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label runat="server" ID="lblid" Text="0"  Visible="false"></asp:Label>
        <uc1:CtlAttach runat="server" id="CtlAttach" />
    </div>
    </form>
</body>
</html>
