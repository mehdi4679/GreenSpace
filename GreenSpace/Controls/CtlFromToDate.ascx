<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlFromToDate.ascx.cs" Inherits="GreenSpace.Controls.CtlFromToDate" %>
<%@ Register Src="~/Controls/CtlDatePick.ascx" TagPrefix="uc1" TagName="CtlDatePick" %>


 
<div>
    <table>
        <tr><td>
            از تاریخ:
            </td>
            <td>
                <uc1:CtlDatePick ID="txtFormDate" runat="server" />
                 
              
            </td>
            <td>
                تا تاریخ:
            </td>
            <td>
                <uc1:CtlDatePick ID="txttoDate" runat="server" />
            </td>

        </tr>
    </table>
</div>