<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccessDenied.aspx.cs" Inherits="GreenSpace.CityZen.AccessDenied" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>سامانه فضای سبز</title>
    <style>
        .lblMsg{
            color:red;
            font-size:36px;           
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin:5em;text-align:center">
        <asp:Label ID="lblMsg" runat="server" Text="شما مجوز دسترسی به این صفحه را ندارید" CssClass="lblMsg"></asp:Label>
    </div>
    </form>
</body>
</html>
