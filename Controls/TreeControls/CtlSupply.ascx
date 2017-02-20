<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlSupply.ascx.cs" Inherits="GreenSpace.Controls.CtlSupply" %>

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
                        <a id="ADel" class="ADelete"  href='<%# DataBinder.Eval(Container,"DataItem.SupplyId")%>' title="حذف"  onclick="return confirm('اطلاعات مربوط  حذف خواهد شد !!  آیا مطمئن هستید ؟')"  onserverclick="DeleteItem" runat="server"  ></a>
                </ItemTemplate>
                </asp:TemplateField >
<asp:TemplateField HeaderText="ویرایش">
            <ItemTemplate>
                        <a id="AEdit" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.SupplyId")%>' title="ویرایش" onserverclick="UpItem" runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>
   <asp:BoundField DataField="SupplyId"  HeaderText="id"   SortExpression="SupplyId" />
   <asp:BoundField DataField="Title"  HeaderText="عنوان"   SortExpression="Title" />
   <asp:BoundField DataField="Money"  HeaderText="مبلغ"   SortExpression="Money" />
   <asp:BoundField DataField="CatalogName"  HeaderText="سال"   SortExpression="Year" />
   <asp:BoundField DataField="SupplyType1"  HeaderText="نوع"   SortExpression="SupplyType" />

             </Columns>
</asp:GridView>
        </div>

<div  id="lightboxdiv" class="LightBoxDiv" >
<div id="lightinsert" class="Lightbox" >
<table>
<tr runat="server" id="TrPrimery" ><td>شماره</td><td><asp:textbox Visible="false"   runat="server" ID="TXTSupplyId" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>عنوان</td><td><asp:textbox runat="server" ID="TXTTitle" ></asp:textbox></td><td></td><td>               
</td><td>                 <asp:RequiredFieldValidator ID="Rqtekrarsalane" runat="server" 
                  ControlToValidate="TXTTitle" ErrorMessage="لطفا پر کنبد" 
                  ValidationGroup="RVTbl_Abbaha" ForeColor="Red">
                 </asp:RequiredFieldValidator></td></tr><tr><td>مبلغ</td><td><asp:textbox runat="server" ID="TXTMoney" ></asp:textbox></td><td></td><td>                 <asp:RegularExpressionValidator ID="RVmony" runat="server" 
                  ControlToValidate="TXTMoney" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید" 
                  ValidationExpression="^[+]?\d*$" SetFocusOnError="True" 
                  ValidationGroup="RVTbl_Abbaha" ForeColor="Red"></asp:RegularExpressionValidator>
</td><td>                 <asp:RequiredFieldValidator ID="Rqmony" runat="server" 
                  ControlToValidate="TXTMoney" ErrorMessage="لطفا پر کنبد" 
                  ValidationGroup="RVTbl_Abbaha" ForeColor="Red">
                 </asp:RequiredFieldValidator></td></tr><tr><td>سال</td><td><asp:dropdownlist runat="server" ID="DDYear" ></asp:dropdownlist></td><td></td><td>
</td><td></td></tr>
    <tr><td>نوع&nbsp; </td><td><asp:dropdownlist runat="server" ID="DDSupplyType" >
        <asp:ListItem Value="-1">انتخاب کنید</asp:ListItem>
        <asp:ListItem Value="0">خرید نهاده</asp:ListItem>
        <asp:ListItem Value="1">کاشت نهاده</asp:ListItem>
        </asp:dropdownlist></td><td>&nbsp;</td><td>
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

