<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/DashBordMaster.Master" AutoEventWireup="true" CodeBehind="pppp.aspx.cs" Inherits="GreenSpace.Manage.pppp" %>
<%@ Register src="~/Controls/Ctlpp.ascx" tagname="CtlPark" tagprefix="uc1" %>
<%@ Register src="~/Controls/CtlPEymanPark.ascx" tagname="CtlPp" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="topMenuProfile" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="subMaster" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr><td>انتخاب پیمان:</td>

            <td>
                <asp:DropDownList runat="server" ID="ddPeyman" AutoPostBack="True" OnSelectedIndexChanged="ddPeyman_SelectedIndexChanged"></asp:DropDownList>
            </td>
        </tr>

    </table>
    
     <uc1:CtlPark ID="Ctlpp" runat="server" />

</asp:Content>
