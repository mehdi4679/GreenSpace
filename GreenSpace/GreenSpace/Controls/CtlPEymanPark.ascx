<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlPEymanPark.ascx.cs" Inherits="GreenSpace.Controls.CtlPEymanPark" %>
    <div >
     <asp:Label ID="LblParamPeymanParkID"  Visible="false" runat="server" Text="0"></asp:Label> 
     <asp:Label ID="lblAgrementID"  Visible="false" runat="server" Text="0"></asp:Label> 
<input type="button" value="افزودن" SkinID="btnInsert"  onclick="openlight();" />
   <%-- <asp:Button runat="server" ID="btnInsertLight"  text="افزودن"  SkinID="btnInsert"  />
    <asp:Button runat="server"  ID="btnSerachLight"  Text="جستجو" SkinID="hbtn-search-r"/> --%>
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
                        <a id="ADel" class="ADelete"  href='<%# DataBinder.Eval(Container,"DataItem.PeymanParkID")%>' title="حذف"  onclick="return confirm('اطلاعات مربوط  حذف خواهد شد !!  آیا مطمئن هستید ؟')"  onserverclick="DeleteItem" runat="server"  ></a>
                </ItemTemplate>
                </asp:TemplateField >
<asp:TemplateField HeaderText="ویرایش">
            <ItemTemplate>
                        <a id="AEdit" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.PeymanParkID")%>' title="ویرایش" onserverclick="UpItem" runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>
   <asp:BoundField DataField="PeymanParkID"  HeaderText="ش فرآیند"   SortExpression="PeymanParkID" />
   <asp:BoundField DataField="PeymanIDName"  HeaderText="نام پیمان"   SortExpression="PeymanIDName" />
   <asp:BoundField DataField="ParkIDName"  HeaderText="نام پارک"   SortExpression="ParkIDName" />
             </Columns>
</asp:GridView>
 
<div  id="lightboxdiv" class="LightBoxDiv" >
<div id="lightinsert" class="Lightbox" >
<table>
<tr runat="server" id="TrPrimery" ><td>PeymanParkID</td><td><asp:textbox Visible="false"   runat="server" ID="TXTPeymanParkID" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>نام پیمان</td><td><asp:dropdownlist runat="server" ID="DDPeymanID" ></asp:dropdownlist></td><td></td><td>
</td><td></td></tr><tr><td>نام پارک</td><td><asp:dropdownlist runat="server" ID="DDParkID" ></asp:dropdownlist></td><td></td><td>
</td><td></td></tr>
</table>
              <div >
              <asp:Button runat="server" Text="ثبت"  ID="BtnInsert" SkinID="btnInsert" 
                        ValidationGroup="RVTbl_PeymanPark" />
             
             <asp:Button  runat="server"  Text="جستجو" ID="BtnSerach" SkinID="hbtn-search-r"  Visible="false" />   
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
    function openlight() {
        document.getElementById('<%= LightBox.ClientID %>').value = "1";
        f();
    }
   </script>

