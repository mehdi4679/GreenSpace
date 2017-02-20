<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportSelect.aspx.cs" MasterPageFile="~/Report/RepMaster.master" Inherits="GreenSpace.Report.ReportSelect" %>

<%@ Register Src="~/Report/CtlFromDateToDate.ascx" TagPrefix="uc1" TagName="CtlFromDateToDate" %>
<%@ Register Src="~/Controls/ctlArchiveDD.ascx" TagPrefix="uc1" TagName="ctlArchiveDD" %>
<%@ Register Src="~/Controls/CtlAllSubjectExplan.ascx" TagPrefix="uc1" TagName="CtlAllSubjectExplan" %>
<%@ Register Src="~/Controls/CtlFromToDate.ascx" TagPrefix="uc1" TagName="CtlFromToDate" %>






<asp:Content runat="server" ContentPlaceHolderID="PesonContentPlaceHolder" ID="cont1">
    <div>
        <div runat="server" id="dAgree" visible="false" >
            <table>
                <tr>
                    <td>قراردادها:</td>
                    <td> <asp:DropDownList runat="server" ID="ddAgree" AutoPostBack="True" OnSelectedIndexChanged="ddAgree_SelectedIndexChanged"></asp:DropDownList></td>
                   
                </tr>
                
                <tr>
<td></td>
                </tr> 
            </table>
<uc1:ctlArchiveDD runat="server" id="ctlArchiveDD" /><br />
            </div>


>

        <div id="dsubject" runat="server" visible="false">

         <uc1:CtlFromToDate runat="server" id="CtlFromToDate" /><br />
             <uc1:CtlAllSubjectExplan runat="server" ID="CtlAllSubjectExplan" />
        </div>

         <br />
        <asp:Button runat="server" SkinID="btnPrn" ID="btnprint2" OnClick="btnprint2_Click" CssClass="DTTT_Print" Text="پرینت" />
  



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
