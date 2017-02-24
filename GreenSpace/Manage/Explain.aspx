<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/DashBordMaster.Master" AutoEventWireup="true" CodeBehind="Explain.aspx.cs" Inherits="GreenSpace.Manage.Explain" %>
<%@ Register src="/Controls/CtlExplanSubject.ascx" tagname="CtlExplanSubject" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="topMenuProfile" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="subMaster" runat="server">
   
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr><td>موضوع کار:</td>
            <td> 
                <asp:DropDownList ID="ddsubject" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddsubject_SelectedIndexChanged1">
                </asp:DropDownList>
            </td>
            <asp:Button ID="Button1" runat="server" Text="درج تمام شرح کارهای این موضوع کار در تمام قرارادها" OnClick="Button1_Click" /> 
            <asp:Label runat="server" ID="LblMsg" ></asp:Label>
        </tr>
    </table>
     <uc1:CtlExplanSubject ID="CtlExplanSubject1" runat="server" />
      
</asp:Content>
