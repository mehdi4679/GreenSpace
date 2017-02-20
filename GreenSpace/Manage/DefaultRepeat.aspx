<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/DashBordMaster.Master" AutoEventWireup="true" CodeBehind="DefaultRepeat.aspx.cs" Inherits="GreenSpace.Manage.DefaultRepeat" %>
<%@ Register src="../Controls/CtlAgreeExplanRepeat1.ascx" tagname="CtlAgreeExplanRepeat1" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="topMenuProfile" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="subMaster" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table runat="server" id="tblSubject" visible="false">
        <tr><td>موضوع کار:</td>
            <td> 
                <asp:DropDownList ID="ddsubject" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddsubject_SelectedIndexChanged1">
                </asp:DropDownList>
            </td>
        </tr>
    </table>
    <uc1:CtlAgreeExplanRepeat1 ID="CtlAgreeExplanRepeat11" runat="server" />

</asp:Content>
