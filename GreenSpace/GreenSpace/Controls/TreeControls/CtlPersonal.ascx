<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlPersonal.ascx.cs" Inherits="GreenSpace.Controls.CtlPersonal" %>
       <asp:Label ID="lblCuttingTreeId" runat="server" Text="0"></asp:Label>
<asp:Label ID="lblLicensingTreeId" runat="server" Text="0"></asp:Label>
<div  id="lightboxdiv12asdn" class="LightBoxDiv11" >
<div id="lightinsert32asdnb" class="Lightbox11" >
<table>
<tr runat="server" id="TrPrimery" ><td></td><td><asp:textbox Visible="false"   runat="server" ID="TXTPersonalID" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>کد ملی</td><td><asp:textbox runat="server" ID="TXTNationalCode" ></asp:textbox></td><td>     
                         <asp:Button runat="server"  Text="جستجو" ID="BtnMell" SkinID="hbtn-search-r" OnClick="BtnMell_Click" />   
                  </td><td>                 <asp:RegularExpressionValidator ID="RVNationalCode" runat="server" 
                  ControlToValidate="txtNationalCode" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید" 
                  ValidationExpression="^[+]?\d*$" SetFocusOnError="True" 
                  ValidationGroup="RVTbl_Personal" ForeColor="Red"></asp:RegularExpressionValidator>
</td><td>                 <asp:RequiredFieldValidator ID="RqNationalCode" runat="server" 
                  ControlToValidate="txtNationalCode" ErrorMessage="لطفا پر کنبد" 
                  ValidationGroup="RVTbl_Personal" ForeColor="Red">
                 </asp:RequiredFieldValidator></td></tr><tr><td>نام</td><td><asp:textbox runat="server" ID="TXTFirstName" ></asp:textbox></td><td></td><td>                
</td><td>                 <asp:RequiredFieldValidator ID="RqFirstName" runat="server" 
                  ControlToValidate="txtFirstName" ErrorMessage="لطفا پر کنبد" 
                  ValidationGroup="RVTbl_Personal" ForeColor="Red">
                 </asp:RequiredFieldValidator></td></tr><tr><td>نام خانوادگی</td><td><asp:textbox runat="server" ID="TXTLastName" ></asp:textbox></td><td></td><td>                 
</td><td>                 <asp:RequiredFieldValidator ID="RqLastName" runat="server" 
                  ControlToValidate="txtLastName" ErrorMessage="لطفا پر کنبد" 
                  ValidationGroup="RVTbl_Personal" ForeColor="Red">
                 </asp:RequiredFieldValidator></td></tr><tr><td>آدرس</td><td><asp:textbox runat="server" ID="TXTPersonalAdress" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>کد پستی</td><td><asp:textbox runat="server" ID="TXTPostiCode" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>تلفن</td><td><asp:textbox runat="server" ID="TXTPersonalTel" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>موبایل</td><td><asp:textbox runat="server" ID="TXTPersonalMobile" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>&nbsp;</td><td><asp:textbox runat="server" ID="TXTJobName" Visible="False" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>&nbsp;</td><td><asp:textbox runat="server" ID="TXTEmail" Visible="False" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>&nbsp;</td><td><asp:textbox runat="server" ID="TXTPassWord" Visible="False" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>&nbsp;</td><td><asp:textbox runat="server" ID="TXTManage" Visible="False" ></asp:textbox></td><td></td><td>
</td><td></td></tr>
</table>
              <div >
              <asp:Button runat="server" Text="افزودن"  ID="BtnInsert" SkinID="btnInsert"   ValidationGroup="RVTbl_Personal" OnClick="BtnInsert_Click" />
             <asp:Button runat="server"  Text="ویرایش" ID="BtnUpdate" SkinID="btnOk" 
                      Visible="false" ValidationGroup="RVTbl_Personal" OnClick="BtnUpdate_Click1"  />     
                         <asp:Button runat="server"  Text="جستجو" ID="BtnSerach" SkinID="hbtn-search-r" OnClick="BtnSerach_Click" Visible="False" />   
                  <asp:Button runat="server"  Text="انصراف" ID="btnCancel" SkinID="hbtn-search-r" OnClick="btnCancel_Click" />
 <div id="dBtnSerach" runat="server" style="visibility:hidden">
 
            </div></div>
        <div>
            <asp:Label runat="server" ID="LblMsg" ></asp:Label>
        </div>
        </div>
        </div>
 <asp:GridView ID="GridView1"  runat="server" AutoGenerateColumns="False" AllowPaging="True"
               AllowSorting="True" >
<Columns>
            <asp:TemplateField HeaderText="ردیف">
            <ItemTemplate >
            <asp:Label runat="server"  ID="RowNum"   Text='<%# Convert.ToString(Convert.ToInt32(DataBinder.Eval(Container, "DataItemIndex"))+1) %> '></asp:Label>
            </ItemTemplate>
            </asp:TemplateField>
<asp:TemplateField HeaderText="حذف"> 
               <ItemTemplate>
                        <a id="ADel" class="ADelete"  href='<%# DataBinder.Eval(Container,"DataItem.PersonalID")%>' title="حذف"  onclick="return confirm('اطلاعات مربوط  حذف خواهد شد !!  آیا مطمئن هستید ؟')"  onserverclick="DeleteItem" runat="server"  ></a>
                </ItemTemplate>
                </asp:TemplateField >
<asp:TemplateField HeaderText="ویرایش">
            <ItemTemplate>
                        <a id="AEdit" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.PersonalID")%>' title="ویرایش" onserverclick="UpItem" runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>
<%--    <asp:TemplateField HeaderText="قطع درخت">
            <ItemTemplate>
                        <a id="AEdit2" class="" href='<%# "/Manage/Tree/CuttingTree.aspx?Personelid="+ Eval("PersonalID").ToString() %>' title="قطع درخت"   runat="server" ><span class="fa fa-arrow-left"></span></a>
            </ItemTemplate>
             </asp:TemplateField>

        <asp:TemplateField HeaderText="مجوز">
            <ItemTemplate>
                        <a id="AEdit3" class="" href='<%# "/Manage/Tree/LicensingTree.aspx?Personelid="+ Eval("PersonalID").ToString() %>' title="مجوز"   runat="server" ><span class="fa fa-arrow-left"></span></a>
            </ItemTemplate>
             </asp:TemplateField>--%>

   <asp:BoundField DataField="PersonalID"  HeaderText="کد فرد"   SortExpression="PersonalID" />
   <asp:BoundField DataField="NationalCode"  HeaderText="کد ملی"   SortExpression="NationalCode" />
   <asp:BoundField DataField="FirstName"  HeaderText="نام"   SortExpression="FirstName" />
   <asp:BoundField DataField="LastName"  HeaderText="نام خانوادگی"   SortExpression="LastName" />
   <asp:BoundField DataField="PersonalAdress"  HeaderText="آدرس"   SortExpression="PersonalAdress" />
   <asp:BoundField DataField="PostiCode"  HeaderText="کد پستی"   SortExpression="PostiCode" />
   <asp:BoundField DataField="PersonalTel"  HeaderText="تلفن"   SortExpression="PersonalTel" />
   <asp:BoundField DataField="PersonalMobile"  HeaderText="موبایل"   SortExpression="PersonalMobile" />
<%--   <asp:BoundField DataField="JobName"  HeaderText="JobName"   SortExpression="JobName" />
   <asp:BoundField DataField="Email"  HeaderText="Email"   SortExpression="Email" />
   <asp:BoundField DataField="PassWord"  HeaderText="PassWord"   SortExpression="PassWord" />
   <asp:BoundField DataField="Manage"  HeaderText="Manage"   SortExpression="Manage" />--%>
             </Columns>
</asp:GridView>
        


<%--    <asp:TemplateField HeaderText="قطع درخت">
            <ItemTemplate>
                        <a id="AEdit2" class="" href='<%# "/Manage/Tree/CuttingTree.aspx?Personelid="+ Eval("PersonalID").ToString() %>' title="قطع درخت"   runat="server" ><span class="fa fa-arrow-left"></span></a>
            </ItemTemplate>
             </asp:TemplateField>

        <asp:TemplateField HeaderText="مجوز">
            <ItemTemplate>
                        <a id="AEdit3" class="" href='<%# "/Manage/Tree/LicensingTree.aspx?Personelid="+ Eval("PersonalID").ToString() %>' title="مجوز"   runat="server" ><span class="fa fa-arrow-left"></span></a>
            </ItemTemplate>
             </asp:TemplateField>--%><%--   <asp:BoundField DataField="JobName"  HeaderText="JobName"   SortExpression="JobName" />
   <asp:BoundField DataField="Email"  HeaderText="Email"   SortExpression="Email" />
   <asp:BoundField DataField="PassWord"  HeaderText="PassWord"   SortExpression="PassWord" />
   <asp:BoundField DataField="Manage"  HeaderText="Manage"   SortExpression="Manage" />--%><%--    <asp:TemplateField HeaderText="قطع درخت">
            <ItemTemplate>
                        <a id="AEdit2" class="" href='<%# "/Manage/Tree/CuttingTree.aspx?Personelid="+ Eval("PersonalID").ToString() %>' title="قطع درخت"   runat="server" ><span class="fa fa-arrow-left"></span></a>
            </ItemTemplate>
             </asp:TemplateField>

        <asp:TemplateField HeaderText="مجوز">
            <ItemTemplate>
                        <a id="AEdit3" class="" href='<%# "/Manage/Tree/LicensingTree.aspx?Personelid="+ Eval("PersonalID").ToString() %>' title="مجوز"   runat="server" ><span class="fa fa-arrow-left"></span></a>
            </ItemTemplate>
             </asp:TemplateField>--%>

