<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlDropExplan.ascx.cs" Inherits="GreenSpace.Controls.CtlDropExplan" %>

<table>
    <tr>
        <td>موضوع:</td>
        <td>
<asp:DropDownList runat="server" ID="ddSubject" AutoPostBack="True" OnSelectedIndexChanged="ddSubject_SelectedIndexChanged"></asp:DropDownList>
        </td>
        <td>
            شرح کار:
        </td>
        <td>
            <asp:DropDownList runat="server" ID="DDExplan" OnSelectedIndexChanged="DDExplan_SelectedIndexChanged"></asp:DropDownList>
        </td>
    </tr>
</table>
<asp:Label ID="lblOnlyActiveView" runat="server" Text="0" Visible="false" ></asp:Label>
<asp:Label ID="lblAgreementID" runat="server" Text="0" Visible="false"></asp:Label>

