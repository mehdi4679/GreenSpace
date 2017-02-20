<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlHaghighi.ascx.cs" Inherits="GreenSpace.Controls.CtlHaghighi" %>



<asp:Button runat="server" ID="btnSerachLight" Text="جستجو" SkinID="hbtn-search-r" OnClick="btnSerachLight_Click" Visible="False" />

<asp:Label ID="lblCuttingTreeId" runat="server" Text="0" Visible="false"></asp:Label>
<asp:Label ID="lblLicensingTreeId" runat="server" Text="0" Visible="false"></asp:Label>
<asp:TextBox Visible="false" runat="server" ID="TXTHaghighiID"></asp:TextBox>
<div id="lightboxdivqwer11" class="LightBoxDiv44">
    <div id="lightinsertrewq66" class="Lightbox44">
        <table>
           <%-- <tr runat="server" id="TrPrimery">
                <td></td>
                <td>
                    </td>
                <td></td>
                <td></td>
                <td></td>
            </tr>--%>
            <tr>
                <td>نام شرکت/سازمان</td>
                <td>
                    <asp:TextBox runat="server" ID="TXTHaghighiName"></asp:TextBox></td>
                <td></td>
                <td>
                    <asp:RegularExpressionValidator ID="RVHaghighiName" runat="server"
                        ControlToValidate="txtHaghighiName" Display="Dynamic" ErrorMessage="لطفا از حروف فارسی استفاده کنید"
                        ValidationExpression="^([ اآبپتثجچحیخدذرزژسشطظعغفقکكگلمنوهيئضصي]\s?)*$" SetFocusOnError="True"
                        ValidationGroup="RVTbl_Haghighi" ForeColor="Red"></asp:RegularExpressionValidator>
                </td>
                <td></td>
            </tr>
            <tr>
                <td>نام مدیر عامل</td>
                <td>
                    <asp:TextBox runat="server" ID="TXTManageName"></asp:TextBox></td>
                <td></td>
                <td></td>
                <td></td>
            <%--</tr>
            <tr>--%>
                <td>نام خانوادگی مدیر عامل</td>
                <td>
                    <asp:TextBox runat="server" ID="TXTHaghighiFamily"></asp:TextBox></td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
          <%--  </tr>
            <tr>--%>
               
            </tr>
            <tr>
               <td>تلفن ثابت</td>
                <td>
                    <asp:TextBox runat="server" ID="TXTHaghighiTel"></asp:TextBox></td>
                <td></td>
                <td></td>
                <td></td>
           <%-- </tr>
            <tr>--%>
                <td>موبایل</td>
                <td>
                    <asp:TextBox runat="server" ID="TXTRepresentativeMobile"></asp:TextBox></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                 <td>ایمیل</td>
                <td>
                    <asp:TextBox runat="server" ID="TXTHaghighiyEmail"></asp:TextBox></td>
                <td></td>
                <td></td>
                <td></td>
                  <td>آدرس</td>
                <td>
                    <asp:TextBox runat="server" ID="TXTHaghighiAdress"></asp:TextBox></td>
                <td></td>
                <td></td>
                <td></td>
               
            </tr>
        </table>
        <div>
            <asp:Button runat="server" Text="افزودن - ثبت" ID="BtnInsert" SkinID="btnInsert" ValidationGroup="RVTbl_Haghighi" OnClick="BtnInsert_Click" />
            <asp:Button runat="server" Text="ویرایش" ID="BtnUpdate" SkinID="btnOk"
                Visible="false" ValidationGroup="RVTbl_Haghighi" OnClick="BtnUpdate_Click1" />
            <asp:Button runat="server" Text="جستجو" ID="BtnSerach" SkinID="hbtn-search-r" OnClick="BtnSerach_Click1" visible="false"/>
            <asp:Button runat="server" Text="انصراف" ID="BtnCancel" SkinID="hbtn-search-r" OnClick="BtnCancel_Click" visible="false"/>
        </div>
        <div>
            <asp:Label runat="server" ID="LblMsg"></asp:Label>
        </div>
    </div>
</div>

<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AllowPaging="True" Visible="false"
    AllowSorting="True">
    <Columns>
        <asp:TemplateField HeaderText="ردیف">
            <ItemTemplate>
                <asp:Label runat="server" ID="RowNum" Text='<%# Convert.ToString(Convert.ToInt32(DataBinder.Eval(Container, "DataItemIndex"))+1) %> '></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="حذف">
            <ItemTemplate>
                <a id="ADel" class="ADelete" href='<%# DataBinder.Eval(Container,"DataItem.HaghighiID")%>' title="حذف" onclick="return confirm('اطلاعات مربوط  حذف خواهد شد !!  آیا مطمئن هستید ؟')" onserverclick="DeleteItem" runat="server"></a>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="ویرایش">
            <ItemTemplate>
                <a id="AEdit" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.HaghighiID")%>' title="ویرایش" onserverclick="UpItem" runat="server"></a>
            </ItemTemplate>
        </asp:TemplateField>

        <%--        <asp:TemplateField HeaderText="قطع درخت">
            <ItemTemplate>
                        <a id="AEdit2" class="" href='<%# "/Manage/Tree/CuttingTree.aspx?HaghighiID="+ Eval("HaghighiID").ToString() %>' title="قطع درخت"   runat="server" ><span class="fa fa-arrow-left"></span></a>
            </ItemTemplate>
             </asp:TemplateField>

        <asp:TemplateField HeaderText="مجوز">
            <ItemTemplate>
                        <a id="AEdit3" class="" href='<%# "/Manage/Tree/LicensingTree.aspx?HaghighiID="+ Eval("HaghighiID").ToString() %>' title="مجوز"   runat="server" ><span class="fa fa-arrow-left"></span></a>
            </ItemTemplate>
             </asp:TemplateField>--%>
        <asp:TemplateField HeaderText="ثبت">
            <ItemTemplate>
                <a id="AEdit3" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.HaghighiID")%>' title="ویرایش" onserverclick="SabCuttingTreet" runat="server"><span class="fa fa-arrow-left"></span></a>
            </ItemTemplate>
        </asp:TemplateField>
        <%--   <asp:BoundField DataField="HaghighiID"  HeaderText="HaghighiID"   SortExpression="HaghighiID" />--%>
        <asp:BoundField DataField="HaghighiName" HeaderText="نام" SortExpression="HaghighiName" />
        <asp:BoundField DataField="ManageName" HeaderText="نام مدیر عامل" SortExpression="ManageName" />
        <asp:BoundField DataField="HaghighiFamily" HeaderText="نام خانوادگی مدیر عامل" SortExpression="ManageName" />
        <asp:BoundField DataField="HaghighiTel" HeaderText="تلفن" SortExpression="HaghighiTel" />
        <asp:BoundField DataField="HaghighiAdress" HeaderText="آدرس" SortExpression="HaghighiAdress" />
        <asp:BoundField DataField="RepresentativeMobile" HeaderText="موبایل" SortExpression="RepresentativeMobile" />
        <%--<asp:BoundField DataField="HaghighiyEmail"  HeaderText="HaghighiyEmail"   SortExpression="HaghighiyEmail" />--%>
    </Columns>
</asp:GridView>



<%--        <asp:TemplateField HeaderText="قطع درخت">
            <ItemTemplate>
                        <a id="AEdit2" class="" href='<%# "/Manage/Tree/CuttingTree.aspx?HaghighiID="+ Eval("HaghighiID").ToString() %>' title="قطع درخت"   runat="server" ><span class="fa fa-arrow-left"></span></a>
            </ItemTemplate>
             </asp:TemplateField>

        <asp:TemplateField HeaderText="مجوز">
            <ItemTemplate>
                        <a id="AEdit3" class="" href='<%# "/Manage/Tree/LicensingTree.aspx?HaghighiID="+ Eval("HaghighiID").ToString() %>' title="مجوز"   runat="server" ><span class="fa fa-arrow-left"></span></a>
            </ItemTemplate>
             </asp:TemplateField>--%>

