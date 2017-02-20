<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/WizardDashboard.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="GreenSpace.CityZen.ChangePassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <div class="row">
        <div class="col-md-6">
            <div>* کلمه عبور فعلی</div>
            <asp:TextBox runat="server" ID="txtpasscurrent" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                ControlToValidate="txtpasscurrent" ErrorMessage="لطفا پر کنید"
                ValidationGroup="RVTbl_Personal" ForeColor="Red">
            </asp:RequiredFieldValidator>
        </div>
        </div>
    <div class="row">
        <div class="col-md-3">
            <div>* کلمه عبور جدید</div>
            <asp:TextBox runat="server" ID="txtpass" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RqLastName02" runat="server"
                ControlToValidate="txtpass" ErrorMessage="لطفا پر کنید"
                ValidationGroup="RVTbl_Personal" ForeColor="Red">
            </asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ValidationGroup="RVTbl_Personal"
                ErrorMessage="کلمه عبور بایستی بین 4 تا 10 کاراکتر و اعداد و حروف انگلیسی باشد"
                ControlToValidate="txtpass"
                ValidationExpression="^[a-zA-Z0-9'@&#.\s]{4,10}$" />
        </div>
        <div class="col-md-3">
            <div>تکرار کلمه عبور جدید</div>
            <asp:TextBox runat="server" ID="txtrepass" TextMode="Password"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ForeColor="Red" ControlToValidate="txtrepass" ControlToCompare="txtpass" Operator="Equal" ErrorMessage="تکرار کلمه عبور یکسان نمیباشد" ValidationGroup="RVTbl_Personal"></asp:CompareValidator>
        </div>
    </div>
                <div>
                  <asp:Button runat="server" Text="ذخیره" ID="BtnSave" SkinID="btnInsert" OnClick="BtnSave_Click"
                ValidationGroup="RVTbl_Personal" />
                </div>
</asp:Content>
