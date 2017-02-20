<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/AgreeMaster.master" AutoEventWireup="true" CodeBehind="AgreePercent.aspx.cs" Inherits="GreenSpace.Agree.AgreePercent" %>

<%@ Register src="~/Controls/CtlAgreementPercent.ascx" tagname="CtlAgreementPercent1" tagprefix="uc1" %>
<%@ Register src="~/Controls/CtlDropExplan.ascx" tagname="CtlDropExplan1" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PesonContentPlaceHolder" runat="server">
  
  <%--  <table>
        <tr>
            <td>
<uc2:CtlDropExplan1 ID="DDExplainID" runat="server"  />
            </td>
        </tr>
    </table>  --%>

     <uc1:CtlAgreementPercent1 runat="server" ID="CtlAgreementPercent111" />
</asp:Content>
