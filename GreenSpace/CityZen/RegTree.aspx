<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/WizardDashboard.Master" AutoEventWireup="true" CodeBehind="RegTree.aspx.cs" Inherits="GreenSpace.CityZen.RegTree" %>

<%@ Register Src="~/Controls/CtlDatePick.ascx" TagPrefix="uc1" TagName="CtlDatePick" %>


<asp:Content ID="Content1" ContentPlaceHolderID="HeadContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">

    <div class="regTree col-md-8">
        <div class="row">
            <div class="col-md-6">
                <div>نوع درخت</div>
                <asp:DropDownList ID="ddlTreeType" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>
            <div class="col-md-6">
                <div>نوع مکان</div>
                <asp:DropDownList ID="ddlStreetType" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <div>نوع درخواست</div>
                <asp:DropDownList ID="ddlLicesnceType" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>
            <div class="col-md-6">
                <div>تعداد</div>
                <asp:TextBox ID="txtCount" runat="server" CssClass="form-control"></asp:TextBox>
                 <asp:RegularExpressionValidator ID="RVtxtCount" runat="server"
                        ControlToValidate="txtCount" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید"
                        ValidationExpression="^[+]?\d*$" SetFocusOnError="True"
                        ValidationGroup="RegTree" ForeColor="Red"></asp:RegularExpressionValidator>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator123" runat="server"
                        ControlToValidate="txtCount" ErrorMessage="لطفا پر کنید"
                        ValidationGroup="RegTree" ForeColor="Red" style="display:none;"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <div>بن</div>
                <asp:TextBox ID="txtBon" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RVtxtBon" runat="server"
                        ControlToValidate="txtBon" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید"
                        ValidationExpression="^[+]?\d*$" SetFocusOnError="True"
                        ValidationGroup="RegTree" ForeColor="Red"></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                        ControlToValidate="txtBon" ErrorMessage="لطفا پر کنید"
                        ValidationGroup="RegTree" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
            <div class="col-md-6">
                <div>تاریخ</div>
                <uc1:CtlDatePick runat="server" ID="CtlDatePick" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <div>منظقه</div>
                <asp:DropDownList runat="server" ID="ddRegion" CssClass="form-control"></asp:DropDownList>
            </div>
        </div>
        <div class="row">           
            <div class="col-md-6">
                <div>آدرس</div>
                <asp:TextBox ID="txtAddress" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                </div>
                <div class="col-md-2">                
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                        ControlToValidate="txtAddress" ErrorMessage="لطفا پر کنید"
                        ValidationGroup="RegTree" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
             <div class="col-md-4" style="display:none">
                <asp:CheckBox ID="chkMojavez" runat="server" TextAlign="Right" Text="مجوز" />
            </div>
           
        </div>

        <div class="row">
            <asp:Button runat="server" ID="btnInsert" Text="ثبت اطلاعات" OnClick="btnInsert_Click" ValidationGroup="RegTree"/>
        </div>
        <div></div>
        <asp:Label ID="LblMsg" runat="server" Text=""></asp:Label>
    </div>
     <div class="row col-md-12">
       
<%--    </div>
    <div class="row col-md-12">--%>
        <div class="wizard-actions" style="float: left">
            <a href="RequestList.aspx" data-last="Finish" class="btn btn-success btn-next">مرحله بعدی													
            <i class="ace-icon fa fa-arrow-left icon-on-left"></i></a>
        </div>
          <div class="wizard-actions" style="float: left">
            <a href="PersonalView.aspx" data-last="Finish" class="btn btn-success btn-next">مرحله قبلی													
            <i class="ace-icon fa fa-arrow-right icon-on-left"></i></a>
        </div>
    </div>
</asp:Content>
