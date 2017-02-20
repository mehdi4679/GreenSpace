<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlAllSubjectExplan.ascx.cs" Inherits="GreenSpace.Controls.CtlAllSubjectExplan" %>
  <asp:Label ID="txtbindall" runat="server" Text="0" Visible="false" ></asp:Label>
  <asp:Label ID="lblSelectedValue" runat="server" Text="0" Visible="false" ></asp:Label>

  <table>
        <tr><td>موضوع:</td><td><asp:DropDownList runat="server" ID="ddSubject" AutoPostBack="True" OnSelectedIndexChanged="ddSubject_SelectedIndexChanged"  ></asp:DropDownList></td> 
         <td>شرح کار:</td><td><asp:DropDownList runat="server" ID="ddexplan" AutoPostBack="True" OnSelectedIndexChanged="ddexplan_SelectedIndexChanged"></asp:DropDownList></td></tr>
    </table>
