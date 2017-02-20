<%@ Page Title="" Language="C#" MasterPageFile="~/Report/RepMaster.master" AutoEventWireup="true" CodeBehind="CuttingTree.aspx.cs" Inherits="GreenSpace.Report.ReportTree.CuttingTree" %>
<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>


<%@ Register Src="~/Report/CtlFromDateToDate.ascx" TagPrefix="uc1" TagName="CtlFromDateToDate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="chead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PesonContentPlaceHolder" runat="server">

      <div>
      
            <table>
                <tr>
                     <td>منطقه:</td>
                    <td> <asp:DropDownList runat="server" ID="DDMantagheId"></asp:DropDownList></td>
                </tr>
            </table>
           
        <uc1:CtlFromDateToDate runat="server" ID="CtlFromDateToDate" />
  <%--      <asp:Button runat="server" ID="btnprint"  CssClass="DTTT_Print" Text="پرینت" OnClick="btnprint_Click" />--%>
<asp:Button runat="server" ID="btnprint"  CssClass="DTTT_Print" Text="پرینت" OnClick="btnprint_Click1"  />
        <%--<input type="button" name="btnprint"  Text="پرینت"  runat="server"   OnClick="btnprint_Click1" />--%>
        <br />
        

        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
 <%--       <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="80%" Height="480%"></rsweb:ReportViewer>--%>
<%--    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="80%" Height="80%"   ><rsweb:ReportViewer runat="server"></rsweb:ReportViewer>
        </rsweb:ReportViewer>--%>



    </div>
    
               <center>
  <div style="width:100%;text-align:center" >
               
<iframe  id="MyIfarm" runat="server" visible="false" width="100%" height="400px" >

</iframe>

 </div>

     </center>
</asp:Content>
