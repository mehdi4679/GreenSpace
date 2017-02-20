<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlFromDateToDate.ascx.cs" Inherits="GreenSpace.Report.CtlFromDateToDate" %>
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