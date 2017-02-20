<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/WizardDashboard.Master" AutoEventWireup="true" CodeBehind="RequestList.aspx.cs" Inherits="GreenSpace.CityZen.RequestList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContentPlaceHolder" runat="server">
    <style>
        th {
            text-align: center !important;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">

    <asp:GridView ID="gvRequestList" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="FullName" HeaderText="ثبت کننده" />
            <%--<asp:BoundField DataField="Mojavez" HeaderText=" مجوز" />--%>
            <asp:BoundField DataField="Count" HeaderText="تعداد" />
            <asp:BoundField DataField="Bon" HeaderText="بن" />
            <asp:BoundField DataField="date1" HeaderText="تاریخ" />
            <asp:BoundField DataField="treetypeName" HeaderText="نوع درخت" />
         <%--     <asp:TemplateField HeaderText="مجوز">
            <ItemTemplate >
                <asp:CheckBox runat="server" ID="chkMojavez" Checked='<%#  (Boolean)Eval("Mojavez") %>' Enabled="false"></asp:CheckBox>
            </ItemTemplate>
            </asp:TemplateField>--%>
            <%--<asp:TemplateField HeaderText="حذف">
                <ItemTemplate>
                    <a id="ADel" class="ADelete" href="#" gridid='<%# Eval("id") %>' title="حذف" onclick="return confirm('اطلاعات مربوط  حذف خواهد شد !!  آیا مطمئن هستید ؟')" onserverclick="DeleteItem" runat="server"></a>
                </ItemTemplate>
            </asp:TemplateField>--%>
            <%--<asp:TemplateField HeaderText="ویرایش">
                <ItemTemplate>
                    <a id="AEdit" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.ExplanPriceID")%>' title="ویرایش" onserverclick="UpItem" runat="server"></a>
                </ItemTemplate>
            </asp:TemplateField>--%>
        </Columns>
    </asp:GridView>
    <div class="wizard-actions" style="float: left">
            <a href="/CityZen/MapRegTree.aspx" data-last="Finish" class="btn btn-success btn-next">مرحله قبلی													
            <i class="ace-icon fa fa-arrow-right icon-on-left"></i></a>
        </div>
</asp:Content>
