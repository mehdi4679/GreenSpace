<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlRotbal.ascx.cs" Inherits="GreenSpace.Controls.TreeControls.CtlRotbal" %>

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
                        <a id="ADel" class="ADelete"  href='<%# DataBinder.Eval(Container,"DataItem.RotbalId")%>' title="حذف"  onclick="return confirm('اطلاعات مربوط  حذف خواهد شد !!  آیا مطمئن هستید ؟')"  onserverclick="DeleteItem" runat="server"  ></a>
                </ItemTemplate>
                </asp:TemplateField >
<asp:TemplateField HeaderText="ویرایش">
            <ItemTemplate>
                        <a id="AEdit" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.RotbalId")%>' title="ویرایش" onserverclick="UpItem" runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>
   <asp:BoundField DataField="RotbalId"  HeaderText="id"   SortExpression="RotbalId" />
   <asp:BoundField DataField="RotbalType1"  HeaderText="نوع"   SortExpression="RotbalType1" />
   <asp:BoundField DataField="Mablagh"  HeaderText="مبلغ"   SortExpression="Mablagh" />
   <asp:BoundField DataField="CatalogName"  HeaderText="سال"   SortExpression="Year" />


             </Columns>
</asp:GridView>
        </div>

<div  id="lightboxdiv" class="LightBoxDiv" >
<div id="lightinsert" class="Lightbox" >
<table>
<tr runat="server" id="TrPrimery" ><td>شماره</td><td><asp:textbox Visible="false"   runat="server" ID="TXTRotbalId" ></asp:textbox></td><td>&nbsp;</td><td>
    &nbsp;</td><td>&nbsp;</td></tr>
<tr runat="server" id="Tr1" ><td>نوع&nbsp; </td><td><asp:dropdownlist runat="server" ID="DDRotbalType" >
        <asp:ListItem Value="-1">انتخاب کنید</asp:ListItem>
        <asp:ListItem Value="0">خرید نهاده</asp:ListItem>
        <asp:ListItem Value="1">کاشت نهاده</asp:ListItem>
        </asp:dropdownlist></td><td></td><td>
</td><td></td></tr><tr><td>مبلغ</td><td><asp:textbox runat="server" ID="TXTMoney" ></asp:textbox></td><td></td><td>                 <asp:RegularExpressionValidator ID="RVmony" runat="server" 
                  ControlToValidate="TXTMoney" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید" 
                  ValidationExpression="^[+]?\d*$" SetFocusOnError="True" 
                  ValidationGroup="RVTbl_Abbaha" ForeColor="Red"></asp:RegularExpressionValidator>
</td><td>                 <asp:RequiredFieldValidator ID="Rqmony" runat="server" 
                  ControlToValidate="TXTMoney" ErrorMessage="لطفا پر کنبد" 
                  ValidationGroup="RVTbl_Abbaha" ForeColor="Red">
                 </asp:RequiredFieldValidator></td></tr><tr><td>سال</td><td><asp:dropdownlist runat="server" ID="DDYear" ></asp:dropdownlist></td><td></td><td>
</td><td></td></tr>
    <tr><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>
        &nbsp;</td><td>&nbsp;</td></tr>
</table>
              <div >
              <asp:Button runat="server" Text="افزودن"  ID="BtnInsert" SkinID="btnInsert" 
                      Visible="false"   ValidationGroup="RVTbl_Abbaha" OnClick="BtnInsert_Click" />
             <asp:Button runat="server"  Text="ویرایش" ID="BtnUpdate" SkinID="btnOk" 
                      Visible="false" ValidationGroup="RVTbl_Abbaha" OnClick="BtnUpdate_Click1"  />
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

