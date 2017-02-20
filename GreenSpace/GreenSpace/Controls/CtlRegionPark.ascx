<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlRegionPark.ascx.cs" Inherits="GreenSpace.Controls.CtlRegionPark" %>
<table>
    <tr>
        <td>منطقه:</td>
        <td><asp:DropDownList runat="server" ID="ddRegion" AutoPostBack="true" OnSelectedIndexChanged="ddRegion_SelectedIndexChanged" ></asp:DropDownList></td>
        <td>پارک:</td>
        <td><asp:DropDownList runat="server" ID="ddPArk" OnSelectedIndexChanged="ddPArk_SelectedIndexChanged"></asp:DropDownList>         </td>
    </tr>
</table>