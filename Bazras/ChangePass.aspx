<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Bazras.master" AutoEventWireup="true" CodeBehind="ChangePass.aspx.cs" Inherits="GreenSpace.Bazras.ChangePass" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="topMenuProfile" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="subMaster" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div id="lightPass" class="sxa">
        <table>
           <%-- <tr>
                <td colspan="2">
                    نام کاربری و کلمه عبور آقای:<asp:Label runat="server" ID="lblName"></asp:Label>
                </td>
            </tr>--%>
            <tr  >
                <td>
                    کلمه عبور فعلی:
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtCurrentPAss"></asp:TextBox>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    کلمه عبور
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtlightPass" TextMode="Password"></asp:TextBox>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtlightPass"
                            ErrorMessage="لطفا پر کنبد" ValidationGroup="RVTBl_Users2" ForeColor="Red">
                        </asp:RequiredFieldValidator>
                    </td>
                </td>
            </tr>
            <tr>
                <td>
                    تکرار کلمه عبور
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtLightRePass" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtLightRePass"
                        ErrorMessage="لطفا پر کنبد" ValidationGroup="RVTBl_Users2" ForeColor="Red">
                    </asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:CompareValidator ID="CompareValidator22" runat="server" ControlToValidate="txtLightRePass"
                        CssClass="ValidationError" ForeColor="Red" ControlToCompare="txtlightPass" ErrorMessage="پسورد هاد یکسان نمیباشد"
                        ToolTip="پسوردها باید یکسان باشد" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button runat="server" ID="btnPass" Text="ذخیره" ValidationGroup="RVTBl_Users2"
                        OnClick="btnPass_Click" />
                </td>
                <td>
                    <asp:Label runat="server" ID="lblmsgPass"></asp:Label>
                </td>
                ></tr>
        </table>
    </div>
</asp:Content>
