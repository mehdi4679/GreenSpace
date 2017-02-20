<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlAgeCalculation.ascx.cs" Inherits="GreenSpace.Controls.CtlAgeCalculation" %>
    <div >
     <asp:Label ID="LblParamid"  Visible="false" runat="server" ></asp:Label> 
    <asp:Button runat="server" ID="btnInsertLight"  text="افزودن"  SkinID="btnInsert" OnClick="btnInsertLight_Click"  />
    <asp:Button runat="server"  ID="btnSerachLight"  Text="جستجو" SkinID="hbtn-search-r" OnClick="btnSerachLight_Click"/> 
    </div >
    <div >
          <asp:Label runat="server" ID="LblNumber"  Font-Bold="True"  ForeColor="Green"  ></asp:Label> 
    </div >
 <asp:GridView ID="GridView1"  runat="server" AutoGenerateColumns="False" AllowPaging="True"
               AllowSorting="True" OnPageIndexChanging="GridView1_PageIndexChanging1" PageSize="5" >
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
   <asp:BoundField DataField="GroupAge"  HeaderText="میانگین سن گروه"   SortExpression="GroupAge" />
   <asp:BoundField DataField="BonSize"  HeaderText="اندازه بن"   SortExpression="BonSize" />
   <asp:BoundField DataField="AgeTypeCatalog"  HeaderText="سن درخت"   SortExpression="AgeTypeCatalog" />
   <asp:BoundField DataField="TreeTypeCatalog"  HeaderText="نوع درخت"   SortExpression="TreeTypeCatalog" />
      <asp:BoundField DataField="yearCatalog"  HeaderText="سال"   SortExpression="yearCatalog" />
          <asp:BoundField DataField="bonMAfzayesh"  HeaderText="میانگین افزایش بن"   SortExpression="bonMAfzayesh" />
             </Columns>
</asp:GridView>
        </div>

<div  id="lightboxdiv" class="LightBoxDiv" >
<div id="lightinsert" class="Lightbox" >
<table>
<tr runat="server" id="TrPrimery" ><td>&nbsp;</td><td><asp:textbox Visible="false"   runat="server" ID="TXTid" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>میانگین سن گروه</td><td><asp:textbox runat="server" ID="TXTGroupAge" ></asp:textbox></td><td></td><td>                 
</td><td></td></tr><tr><td>اندازه بن</td><td><asp:textbox runat="server" ID="TXTBonSize" ></asp:textbox></td><td></td><td>                 <asp:RegularExpressionValidator ID="RVBonSize" runat="server" 
                  ControlToValidate="txtBonSize" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید" 
                  ValidationExpression="^[+]?\d*$" SetFocusOnError="True" 
                  ValidationGroup="RVTbl_AgeCalculation" ForeColor="Red"></asp:RegularExpressionValidator>
</td><td>                 <asp:RequiredFieldValidator ID="RqBonSize" runat="server" 
                  ControlToValidate="txtBonSize" ErrorMessage="لطفا پر کنبد" 
                  ValidationGroup="RVTbl_AgeCalculation" ForeColor="Red">
                 </asp:RequiredFieldValidator></td></tr><tr><td>سن درخت</td><td><asp:dropdownlist runat="server" ID="DDAgeTypeId" ></asp:dropdownlist></td><td></td><td>
</td><td></td></tr><tr><td>نوع درخت</td><td><asp:dropdownlist runat="server" ID="DDTreeType" ></asp:dropdownlist></td><td></td><td>
</td><td></td></tr>
    <tr><td>سال</td><td><asp:dropdownlist runat="server" ID="DDyear" ></asp:dropdownlist></td><td>&nbsp;</td><td>
        &nbsp;</td><td>&nbsp;</td></tr>
</table>
              <div >
              <asp:Button runat="server" Text="افزودن"  ID="BtnInsert" SkinID="btnInsert" 
                      Visible="false"   ValidationGroup="RVTbl_AgeCalculation" OnClick="BtnInsert_Click" />
             <asp:Button runat="server"  Text="ویرایش" ID="BtnUpdate" SkinID="btnOk" 
                      Visible="false" ValidationGroup="RVTbl_AgeCalculation" OnClick="BtnUpdate_Click1"  />
             <asp:Button runat="server"  Text="جستجو" ID="BtnSerach" SkinID="hbtn-search-r"  Visible="false" OnClick="BtnSerach_Click1" />   
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

