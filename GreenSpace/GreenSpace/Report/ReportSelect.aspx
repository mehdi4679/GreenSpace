<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportSelect.aspx.cs" MasterPageFile="~/Report/RepMaster.master" Inherits="GreenSpace.Report.ReportSelect" %>

<%@ Register Src="~/Report/CtlFromDateToDate.ascx" TagPrefix="uc1" TagName="CtlFromDateToDate" %>



<asp:Content runat="server" ContentPlaceHolderID="PesonContentPlaceHolder" ID="cont1">
    <div>
        <div runat="server" id="dAgree" visible="false" >
            <table>
                <tr>
                    <td>قراردادها:</td>
                    <td> <asp:DropDownList runat="server" ID="ddAgree"></asp:DropDownList></td>
                </tr>
            </table>
            </div>
        <uc1:CtlFromDateToDate runat="server" id="CtlFromDateToDate" />
        <asp:Button runat="server" ID="btnprint" OnClick="btnprint_Click" CssClass="DTTT_Print" Text="پرینت" />
  


    </div>
     <center>
  <div style="width:100%;text-align:center" >
               
<iframe  id="MyIfarm" runat="server" visible="false" width="100%" height="400px" >

</iframe>

 </div>

     </center>
</asp:Content>
 
<%--<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:CtlFromDateToDate runat="server" id="CtlFromDateToDate" />
        <asp:Button runat="server" ID="btnprint" OnClick="btnprint_Click" CssClass="DTTT_Print" Text="پرینت" />

    </div>
    </form>
</body>
</html>--%>
