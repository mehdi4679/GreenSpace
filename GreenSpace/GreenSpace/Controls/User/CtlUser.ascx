<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlUser.ascx.cs" Inherits="GreenSpace.Controls.CtlUser" %>
<div>
 
    <asp:Label ID="LblParamUserID" Visible="false" runat="server"></asp:Label>
    <asp:Button runat="server" ID="btnInsertLight"  Text="افزودن" 
        SkinID="btnInsert" onclick="btnInsertLight_Click"  />
    <asp:Button runat="server" ID="btnSerachLight" Text="جستجو" SkinID="hbtn-search-r"
        OnClick="btnSerachLight_Click" />
</div>
<div>
    <asp:Label runat="server" ID="LblNumber" Font-Bold="True" ForeColor="Green"></asp:Label>
</div>
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" OnSorting="GridView1_Sorting"
    AllowSorting="True">
    <Columns>
        <asp:TemplateField HeaderText="ردیف">
            <ItemTemplate>
                <asp:Label runat="server" ID="RowNum" Text='<%# Convert.ToString(Convert.ToInt32(DataBinder.Eval(Container, "DataItemIndex"))+1) %> '></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="حذف">
            <ItemTemplate>
                <a id="ADel" class="ADelete" href='<%# DataBinder.Eval(Container,"DataItem.UserID")%>'
                    title="حذف" onclick="return confirm('اطلاعات مربوط  حذف خواهد شد !!  آیا مطمئن هستید ؟')"
                    onserverclick="DeleteItem" runat="server"></a>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="ویرایش">
            <ItemTemplate>
                <a id="AEdit" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.UserID")%>'
                    title="ویرایش" onserverclick="UpItem" runat="server"></a>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="کلمه عبور">
            <ItemTemplate>
                <a id="Apass" class="AAccess" href='<%# DataBinder.Eval(Container,"DataItem.UserID")  %>'
                    username='<%# DataBinder.Eval(Container,"DataItem.USerName") %>' fullname='<%# DataBinder.Eval(Container,"DataItem.Name")+" "+DataBinder.Eval(Container,"DataItem.Famlily")  %>'
                    title="کلمه عبور" onserverclick="PassItem" runat="server"></a>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:BoundField DataField="UserID" HeaderText="فرآیند" SortExpression="UserID" />
        <asp:BoundField DataField="UserName" HeaderText="نام کاربری" SortExpression="UserName" />
        <asp:BoundField DataField="Name" HeaderText="نام" SortExpression="Name" />
        <asp:BoundField DataField="Famlily" HeaderText="نام خانوادگی" SortExpression="Famlily" />
        <asp:BoundField DataField="mobile" HeaderText="موبایل" SortExpression="mobile" />
        <asp:BoundField DataField="SemeatName2" HeaderText="سمت" SortExpression="SemeatName2" />
        <asp:BoundField DataField="Email" HeaderText="ایمیل" SortExpression="Email" />
        <asp:BoundField DataField="MelliCode" HeaderText="کد ملی" SortExpression="MelliCode" />
        <asp:BoundField DataField="Phone" HeaderText="تلفن" SortExpression="Phone" />
    </Columns>
</asp:GridView>
<asp:Label runat="server" ID="lblUSerIDParam" Visible="false"></asp:Label>
<div id="lightboxdiv" class="LightBoxDiv">
    <div id="lightinsert" class="Lightbox">
        <table>
            <tr runat="server" id="TrPrimery">
                <td>
                    فرآیند
                </td>
                <td>
                    <asp:TextBox runat="server" ID="TXTUserID"></asp:TextBox>
                </td>
                <td>
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    نام کاربری
                </td>
                <td>
                    <asp:TextBox runat="server" ID="TXTUserName"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TXTUserName"
                        ErrorMessage="لطفا پر کنبد" ValidationGroup="RVTBl_Users" ForeColor="Red">
                    </asp:RequiredFieldValidator>
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr runat="server" id="trPass">
                <td>
                    کلمه عبور
                </td>
                <td>
                    <asp:TextBox runat="server" ID="TXTPass" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TXTPass"
                        ErrorMessage="لطفا پر کنبد" ValidationGroup="RVTBl_Users" ForeColor="Red">
                    </asp:RequiredFieldValidator>
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr runat="server" id="TrPassRe">
                <td>
                    تکرار کلمه عبور
                </td>
                <td>
                    <asp:TextBox runat="server" ID="TXTPassre" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="TXTPassre"
                        CssClass="ValidationError" ForeColor="Red" ControlToCompare="TXTPass" ErrorMessage="پسورد هاد یکسان نمیباشد"
                        ToolTip="پسوردها باید یکسان باشد" />
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    نام
                </td>
                <td>
                    <asp:TextBox runat="server" ID="TXTName"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RqName" runat="server" ControlToValidate="txtName"
                        ErrorMessage="لطفا پر کنبد" ValidationGroup="RVTBl_Users" ForeColor="Red">
                    </asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="RVName" runat="server" ControlToValidate="txtName"
                        Display="Dynamic" ErrorMessage="فقط حروف فارسی وارد کنید" ValidationExpression="^([ اآبپتثجچحیخدذرزژسشطظعغفقکكگلمنوهيئضصي]\s?)*$"
                        SetFocusOnError="True" ValidationGroup="RVTBl_Users" ForeColor="Red"></asp:RegularExpressionValidator>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    نام خانوادگی
                </td>
                <td>
                    <asp:TextBox runat="server" ID="TXTFamlily"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RqFamlily" runat="server" ControlToValidate="txtFamlily"
                        ErrorMessage="لطفا پر کنبد" ValidationGroup="RVTBl_Users" ForeColor="Red">
                    </asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="RVFamlily" runat="server" ControlToValidate="txtFamlily"
                        Display="Dynamic" ErrorMessage="فقط حروف فارسی وارد کنید" ValidationExpression="^([ اآبپتثجچحیخدذرزژسشطظعغفقکكگلمنوهيئضصي]\s?)*$"
                        SetFocusOnError="True" ValidationGroup="RVTBl_Users" ForeColor="Red"></asp:RegularExpressionValidator>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    موبایل
                </td>
                <td>
                    <asp:TextBox runat="server" ID="TXTmobile"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="Rqmobile" runat="server" ControlToValidate="txtmobile"
                        ErrorMessage="لطفا پر کنبد" ValidationGroup="RVTBl_Users" ForeColor="Red">
                    </asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="RVmobile" runat="server" ControlToValidate="txtmobile"
                        Display="Dynamic" ErrorMessage="فقط عدد وارد کنید" ValidationExpression="^[+]?\d*$"
                        SetFocusOnError="True" ValidationGroup="RVTBl_Users" ForeColor="Red"></asp:RegularExpressionValidator>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    سمت
                </td>
                <td>
                    <asp:DropDownList runat="server" ID="DDsemat">
                    </asp:DropDownList>
                </td>
                <td>
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    ایمیل
                </td>
                <td>
                    <asp:TextBox runat="server" ID="TXTEmail"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RqEmail" runat="server" ControlToValidate="txtEmail"
                        ErrorMessage="لطفا پر کنبد" ValidationGroup="RVTBl_Users" ForeColor="Red">
                    </asp:RequiredFieldValidator>
                </td>
                <td>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    کد ملی
                </td>
                <td>
                    <asp:TextBox runat="server" ID="TXTMelliCode"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RqMelliCode" runat="server" ControlToValidate="txtMelliCode"
                        ErrorMessage="لطفا پر کنبد" ValidationGroup="RVTBl_Users" ForeColor="Red">
                    </asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="RVMelliCode" runat="server" ControlToValidate="txtMelliCode"
                        Display="Dynamic" ErrorMessage="فقط عدد وارد کنید" ValidationExpression="^[+]?\d*$"
                        SetFocusOnError="True" ValidationGroup="RVTBl_Users" ForeColor="Red"></asp:RegularExpressionValidator>
                    <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtMelliCode"
                        Display="Dynamic" ErrorMessage="کد ملی نامعتبر است" ClientValidationFunction="checkMelliCode"
                        SetFocusOnError="True" ValidateEmptyText="false" ValidationGroup="RFV" ForeColor="Red"
                        Width="128px"></asp:CustomValidator>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    تلفن
                </td>
                <td>
                    <asp:TextBox runat="server" ID="TXTPhone"></asp:TextBox>
                </td>
                <td>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="RVPhone" runat="server" ControlToValidate="txtPhone"
                        Display="Dynamic" ErrorMessage="فقط عدد وارد کنید" ValidationExpression="^[+]?\d*$"
                        SetFocusOnError="True" ValidationGroup="RVTBl_Users" ForeColor="Red"></asp:RegularExpressionValidator>
                </td>
                <td>
                </td>
            </tr>
        </table>
        <div>
            <asp:Button runat="server" Text="افزودن" ID="BtnInsert" SkinID="btnInsert" ValidationGroup="RVTBl_Users"
                OnClick="BtnInsert_Click1" CssClass="actbtn"/>
            <asp:Button runat="server" Text="ویرایش" ID="BtnUpdate" SkinID="btnOk" ValidationGroup="RVTBl_Users"
                OnClick="BtnUpdate_Click1" CssClass="actbtn" />
            <asp:Button runat="server" Text="جستجو" ID="BtnSerach" SkinID="hbtn-search-r"  
                Visible="false" OnClick="BtnSerach_Click1" CssClass="actbtn" />
        </div>
        <div>
            <asp:Label runat="server" ID="LblMsg"></asp:Label>
        </div>
    </div>
    <div id="lightPass" class="Lightbox">
        <table>
            <tr>
                <td colspan="2">
                    نام کاربری و کلمه عبور آقای:<asp:Label runat="server" ID="lblName"></asp:Label>
                </td>
            </tr>
            <tr  >
                <td>
                    نام کاربری:
                </td>
                <td>
                    <asp:TextBox runat="server" ID="TxtlightUserName"></asp:TextBox>
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
</div>
<input type="hidden" id="lightbox" runat="server" />
<input type="hidden" id="lightboxPass" runat="server" />
<script type="text/javascript">

    if (document.getElementById('<%= lightbox.ClientID %>').value == "1") {
        setTimeout(f, 0);
    }
    if (document.getElementById('<%= lightboxPass.ClientID %>').value == "1") {
        setTimeout(f2, 0);
    }
    function g() {
        scripthelper.CloseLightBox("lightinsert");
    }
    function g2() {
        scripthelper.CloseLightBox("lightPass");
    }
    function f() {
        scripthelper.ShowLightBox("lightinsert", '<%= lightbox.ClientID %>', "lightboxdiv");
    }
    function f2() {
        scripthelper.ShowLightBox("lightPass", '<%= lightboxPass.ClientID %>', "lightboxdiv");
    }
    function back() {
        scripthelper.CloseLightBox("lightPass", '<%= lightbox.ClientID %>', "lightboxdiv")
    }
    function back2() {
        scripthelper.CloseLightBox("lightPass", '<%= lightboxPass.ClientID %>', "lightboxdiv")
    }
 
</script>
<script type="text/javascript">
    function checkMelliCode(val, args) {
        var meli_code;
        meli_code = args.Value;
        if (meli_code.length == 10) {
            if ((meli_code == '0000000000') || (meli_code == '1111111111') || (meli_code == '2222222222') || (meli_code == '3333333333') || (meli_code == '4444444444') || (meli_code == '5555555555') || (meli_code == '6666666666') || (meli_code == '7777777777') || (meli_code == '8888888888') || meli_code == ('9999999999')) {
                alert("کد ملي صحيح نمي باشد");
                args.IsValid = false;
                return false;
            }
            c = parseInt(meli_code.charAt(9));
            n = (parseInt(meli_code.charAt(0)) * 10) + (parseInt(meli_code.charAt(1)) * 9) + (parseInt(meli_code.charAt(2)) * 8) + (parseInt(meli_code.charAt(3)) * 7) + (parseInt(meli_code.charAt(4)) * 6) + (parseInt(meli_code.charAt(5)) * 5) + (parseInt(meli_code.charAt(6)) * 4) + (parseInt(meli_code.charAt(7)) * 3) + (parseInt(meli_code.charAt(8)) * 2);
            r = n - parseInt(n / 11) * 11;
            if ((r == 0 && r == c) || (r == 1 && c == 1) || (r > 1 && c == 11 - r)) {
                args.IsValid = true;
            }
            else {
                alert("کد ملي صحيح نمي باشد");
                args.IsValid = false;
            }
        }
        else {
            alert("کد ملي صحيح نمي باشد");
            args.IsValid = false;
            return false;
        }
    }
</script>
