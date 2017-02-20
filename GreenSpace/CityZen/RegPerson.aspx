<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegPerson.aspx.cs" Inherits="GreenSpace.CityZen.RegPerson" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="regForm col-lg-9" style="float:left">

            <div class="row">
                <div>توجه :کد ملی شما به منزله نام کاربری جهت ورود به سایت میباشد.</div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <div>* کد ملی</div>
                    <asp:TextBox runat="server" ID="TXTNationalCode" data-rel="tooltip" data-placement="left" title="فقط عدد و بدون خط تیره" placeholder="فقط عدد و بدون خط تیره"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RVNationalCode" runat="server"
                        ControlToValidate="txtNationalCode" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید"
                        ValidationExpression="^[+]?\d*$" SetFocusOnError="True"
                        ValidationGroup="RVTbl_Personal" ForeColor="Red"></asp:RegularExpressionValidator>
                    <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TXTNationalCode"
                        Display="Dynamic" ErrorMessage="کد ملی نامعتبر است" ClientValidationFunction="checkMelliCode"
                        SetFocusOnError="True" ValidateEmptyText="false" ValidationGroup="RFV" ForeColor="Red"
                        Width="128px"></asp:CustomValidator>
                    <asp:RequiredFieldValidator ID="RqNationalCode" runat="server" ControlToValidate="txtNationalCode" ErrorMessage="لطفا پر کنید" ValidationGroup="RVTbl_Personal" ForeColor="Red">  </asp:RequiredFieldValidator>
                </div>
                <div class="col-md-6">
                    <div>* نام</div>
                    <asp:TextBox runat="server" data-rel="tooltip" title="فقط حروف فارسی وارد کنید" ID="TXTFirstName"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RVFirstName" runat="server"
                        ControlToValidate="txtFirstName" Display="Dynamic" ErrorMessage="فقط حروف فارسی وارد کنید"
                        ValidationExpression="^([ اآبپتثجچحیخدذرزژسشطظعغفقکكگلمنوهيئضصي]\s?)*$" SetFocusOnError="True"
                        ValidationGroup="RVTbl_Personal" ForeColor="Red"></asp:RegularExpressionValidator>

                    <asp:RequiredFieldValidator ID="RqFirstName" runat="server"
                        ControlToValidate="txtFirstName" ErrorMessage="لطفا پر کنید"
                        ValidationGroup="RVTbl_Personal" ForeColor="Red">
                    </asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <div>نام خانوادگی</div>
                    <asp:TextBox runat="server" ID="TXTLastName" data-rel="tooltip" title="فقط حروف فارسی وارد کنید"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RVLastName" runat="server"
                        ControlToValidate="txtLastName" Display="Dynamic" ErrorMessage="فقط حروف فارسی وارد کنید"
                        ValidationExpression="^([ اآبپتثجچحیخدذرزژسشطظعغفقکكگلمنوهيئضصي]\s?)*$" SetFocusOnError="True"
                        ValidationGroup="RVTbl_Personal" ForeColor="Red"></asp:RegularExpressionValidator>

                    <asp:RequiredFieldValidator ID="RqLastName" runat="server"
                        ControlToValidate="txtLastName" ErrorMessage="لطفا پر کنید"
                        ValidationGroup="RVTbl_Personal" ForeColor="Red">
                    </asp:RequiredFieldValidator>
                </div>
                <div class="col-md-6">
                    <div>ایمیل</div>
                    <asp:TextBox runat="server" ID="TXTEmail" data-rel="tooltip" title="فقط حروف انگلیسی وارد کنید"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="validateEmail" ValidationGroup="RVTbl_Personal"
                        runat="server" ErrorMessage="ایمیل اشتباه است."
                        ControlToValidate="TXTEmail"
                        ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <div>* کلمه عبور</div>
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
                <div class="col-md-6">
                    <div>تکرار کلمه عبور</div>
                    <asp:TextBox runat="server" ID="txtrepass" TextMode="Password"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ForeColor="Red" ControlToValidate="txtrepass" ControlToCompare="txtpass" Operator="Equal" ErrorMessage="تکرار کلمه عبور یکسان نمیباشد" ValidationGroup="RVTbl_Personal"></asp:CompareValidator>
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <div>تلفن همراه</div>
                    <asp:TextBox runat="server" ID="TXTPersonalMobile" MaxLength="11" data-rel="tooltip" title="شماره موبایل را 11 رقمی و صحیح وارد نمایید"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ValidationGroup="RVTbl_Personal"
                        ControlToValidate="TXTPersonalMobile" Display="Dynamic"
                        ErrorMessage="شماره موبایل را 11 رقمی و صحیح وارد نمایید" ValidationExpression="^\d{11}$">    
                    </asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator123" runat="server"
                        ControlToValidate="TXTPersonalMobile" ErrorMessage="لطفا پر کنید"
                        ValidationGroup="RVTbl_Personal" ForeColor="Red">
                    </asp:RequiredFieldValidator>
                </div>
                <div class="col-md-6">
                    <div>آدرس</div>
                    <asp:TextBox TextMode="MultiLine" runat="server" ID="TXTPersonalAdress" data-rel="tooltip" title="آدرس محل سکونت"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <div>کدپستی</div>
                    <asp:TextBox runat="server" ID="TXTPostiCode" data-rel="tooltip" title="وارد کردن کدپستی برای متقاضیان تخفیف اجباری است"></asp:TextBox>
                </div>
                <div class="col-md-6">
                    <div>تلفن ثابت</div>
                    <asp:TextBox runat="server" ID="TXTPersonalTel" data-rel="tooltip" title="فقط عدد وارد نمایید"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RVJobName0" runat="server"
                        ControlToValidate="TXTPersonalTel" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید"
                        ValidationExpression="^[+]?\d*$" SetFocusOnError="True"
                        ValidationGroup="RVTbl_Personal" ForeColor="Red"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <div>شغل</div>
                    <asp:TextBox runat="server" ID="TXTJobName"></asp:TextBox>
                </div>
                
            </div>
            <div>
                  <asp:Button runat="server" Text="ثبت" ID="BtnInsert" SkinID="btnInsert" OnClick="BtnInsert_Click"
                ValidationGroup="RVTbl_Personal" />
                </div>
            <asp:Label ID="lblPersonalID" runat="server" Text="0" Visible="false"></asp:Label>
            <asp:Label ID="lblMSG" runat="server" Text=""></asp:Label>
            <div>
            </div>
        </div>
    </form>
</body>
</html>
