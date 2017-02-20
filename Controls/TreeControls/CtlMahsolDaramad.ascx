<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlMahsolDaramad.ascx.cs" Inherits="GreenSpace.Controls.CtlMahsolDaramad" %>
    <style type="text/css">
        .auto-style1 {
            height: 32px;
        }
    </style>
    <div >
     <asp:Label ID="LblParamid"  Visible="false" runat="server" ></asp:Label> 
    <asp:Button runat="server" ID="btnInsertLight"  text="افزودن"  SkinID="btnInsert" OnClick="btnInsertLight_Click"  />
    <asp:Button runat="server"  ID="btnSerachLight"  Text="جستجو" SkinID="hbtn-search-r"/> 
    </div >
    <div >
          <asp:Label runat="server" ID="LblNumber"  Font-Bold="True"  ForeColor="Green"  ></asp:Label> 
    </div >
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
                        <a id="ADel" class="ADelete"  href='<%# DataBinder.Eval(Container,"DataItem.id")%>' title="حذف"  onclick="return confirm('اطلاعات مربوط  حذف خواهد شد !!  آیا مطمئن هستید ؟')"  onserverclick="DeleteItem" runat="server"  ></a>
                </ItemTemplate>
                </asp:TemplateField >
<asp:TemplateField HeaderText="ویرایش">
            <ItemTemplate>
                        <a id="AEdit" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.id")%>' title="ویرایش" onserverclick="UpItem" runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>
   <%--<asp:BoundField DataField="id"  HeaderText="id"   SortExpression="id" />--%>
   <asp:BoundField DataField="AgeTypeCatalog"  HeaderText="سن درخت"   SortExpression="AgeTypeCatalog" />
   <asp:BoundField DataField="Mizan"  HeaderText="میزان محصول"   SortExpression="Mizan" />
   <asp:BoundField DataField="Mony"  HeaderText="قیمت محصول"   SortExpression="Mony" />
    
   <asp:BoundField DataField="TreeTypeCatalog"  HeaderText="نوع درخت"   SortExpression="TreeTypeCatalog" />
   <asp:BoundField DataField="yearCatalog"  HeaderText="سال"   SortExpression="yearCatalog" />
             </Columns>
</asp:GridView>
        </div>

<div  id="lightboxdiv" class="LightBoxDiv" >
<div id="lightinsert" class="Lightbox" >
<table>
<tr runat="server" id="TrPrimery" ><td>&nbsp;</td><td><asp:textbox Visible="false"   runat="server" ID="TXTid" ></asp:textbox></td><td></td><td>
</td><td></td></tr>
<tr ><td>نوع درخت</td><td><asp:dropdownlist runat="server" ID="DDTreeType" ></asp:dropdownlist></td><td>&nbsp;</td><td>
    &nbsp;</td><td>&nbsp;</td></tr><tr><td>سن درخت</td><td><asp:dropdownlist runat="server" ID="DDAgeid" ></asp:dropdownlist></td><td></td><td>
</td><td></td></tr><tr><td class="auto-style1">میزان محصول</td><td class="auto-style1"><asp:textbox runat="server" ID="TXTMizan" ></asp:textbox></td><td class="auto-style1"></td><td class="auto-style1">
</td><td class="auto-style1"></td></tr><tr><td>قیمت محصول</td><td><asp:textbox runat="server" ID="TXTMony" ></asp:textbox></td><td></td><td>                 <asp:RegularExpressionValidator ID="RVMony" runat="server" 
                  ControlToValidate="txtMony" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید" 
                  ValidationExpression="^[+]?\d*$" SetFocusOnError="True" 
                  ValidationGroup="RVTbl_MahsolDaramad" ForeColor="Red"></asp:RegularExpressionValidator>
</td><td>                 <asp:RequiredFieldValidator ID="RqMony" runat="server" 
                  ControlToValidate="txtMony" ErrorMessage="لطفا پر کنبد" 
                  ValidationGroup="RVTbl_MahsolDaramad" ForeColor="Red">
                 </asp:RequiredFieldValidator></td></tr>
    <tr><td>سال</td><td><asp:dropdownlist runat="server" ID="DDyear" ></asp:dropdownlist></td><td>&nbsp;</td><td>                 &nbsp;</td><td>                 &nbsp;</td></tr>
</table>
              <div >
              <asp:Button runat="server" Text="افزودن"  ID="BtnInsert" SkinID="btnInsert" 
                      Visible="false"   ValidationGroup="RVTbl_MahsolDaramad" OnClick="BtnInsert_Click" />
             <asp:Button runat="server"  Text="ویرایش" ID="BtnUpdate" SkinID="btnOk" 
                      Visible="false" ValidationGroup="RVTbl_MahsolDaramad" OnClick="BtnUpdate_Click1"  />
             <asp:Button runat="server"  Text="جستجو" ID="BtnSerach" SkinID="hbtn-search-r"  Visible="false" />   
            </div>
        <div>
            <asp:Label runat="server" ID="LblMsg" ></asp:Label>
        </div>
        </div>
        </div>
 <input type="hidden"  id="LightBox" runat="server" /> 
<script type="text/javascript">
  
        if (document.getElementById('<%= LightBox.ClientID %>').value == "1") {
            setTimeout(f, 0);
        }
 
    function g() {
        scripthelper.CloseLightBox("lightinsert");
    }
    function f() {
        scripthelper.ShowLightBox("lightinsert", '<%= LightBox.ClientID %>', "lightboxdiv");
    }
    function back() {
        scripthelper.CloseLightBox("lightinsert", '<%= LightBox.ClientID %>', "lightboxdiv")
    }
   </script>

