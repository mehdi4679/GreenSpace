<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlKhesarat.ascx.cs" Inherits="GreenSpace.Controls.CtlKhesarat" %>
    <%@ Register src="CtlPrice.ascx" tagname="CtlPrice" tagprefix="uc1" %>
    <div >
     <asp:Label ID="LblParamKesaratID"  Visible="false" runat="server" Text="0"></asp:Label> 
    <asp:Button runat="server" ID="btnInsertLight"  text="افزودن"  SkinID="btnInsert" OnClick="btnInsertLight_Click"  />
    <asp:Button runat="server"  ID="btnSerachLight"  Text="جستجو" Visible="false" SkinID="hbtn-search-r"/> 
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
                        <a id="ADel" class="ADelete"  href='<%# DataBinder.Eval(Container,"DataItem.KesaratID")%>' title="حذف"  onclick="return confirm('اطلاعات مربوط  حذف خواهد شد !!  آیا مطمئن هستید ؟')"  onserverclick="DeleteItem" runat="server"  ></a>
                </ItemTemplate>
                </asp:TemplateField >
<asp:TemplateField HeaderText="ویرایش">
            <ItemTemplate>
                        <a id="AEdit" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.KesaratID")%>' title="ویرایش" onserverclick="UpItem" runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>
   <asp:BoundField DataField="KesaratID"  HeaderText=" فرآیند"   SortExpression="KesaratID" />
   <asp:BoundField DataField="KhesaratDesc"  HeaderText="عنوان خسارت"   SortExpression="KhesaratDesc" />

   <asp:BoundField DataField="KesaratPrice"  HeaderText="قیمت"   SortExpression="KesaratPrice" />
             </Columns>
</asp:GridView>
       

<div  id="lightboxdiv" class="LightBoxDiv" >
<div id="lightinsert" class="Lightbox" >
<table>
<tr runat="server" id="TrPrimery" visible="false"><td>َش فرآیند</td><td><asp:textbox Visible="false"   runat="server" ID="TXTKesaratID" ></asp:textbox></td><td></td><td>
</td><td></td></tr>
    <tr><td>عنوان خسارت</td><td><asp:textbox runat="server" ID="TXTKhesaratDesc" ></asp:textbox>                 <asp:RequiredFieldValidator ID="RqKhesaratDesc" runat="server" 
                  ControlToValidate="txtKhesaratDesc" ErrorMessage="لطفا پر کنبد" 
                  ValidationGroup="RVTbl_khesarat" ForeColor="Red">
                 </asp:RequiredFieldValidator></td><td></td><td>
</td><td>                 &nbsp;</td></tr>
    <tr><td>قیمت</td><td>
    <uc1:CtlPrice ID="TXTKesaratPrice" runat="server" />
     </td><td></td><td>
</td><td>                 <%--<asp:RequiredFieldValidator ID="RqKesaratPrice" runat="server" 
                  ControlToValidate="txtKesaratPrice" ErrorMessage="لطفا پر کنبد" 
                  ValidationGroup="RVTbl_khesarat" ForeColor="Red">
                 </asp:RequiredFieldValidator>--%></td></tr>
    
</table>
              <div >
              <asp:Button runat="server" Text="افزودن"  ID="BtnInsert" SkinID="btnInsert" OnClick="BtnInsert_Click"
                         ValidationGroup="RVTbl_khesarat" />
              
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

