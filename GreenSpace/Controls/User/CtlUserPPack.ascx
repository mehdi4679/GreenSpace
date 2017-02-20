<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlUserPPack.ascx.cs" Inherits="Taxi.Controls.CtlUserPPack" %>
<div runat="server" visible="false"  id="dddd" style="visibility:hidden">
     <asp:Label ID="LblParamUserPermissinID"  Visible="false" runat="server" Text="0" ></asp:Label> 
    <input style="visibility:hidden"  ID="btnInsertLight"  value="افزودن"    type="button" onclick="OpenLight()"    />
    <asp:Button runat="server"  ID="btnSerachLight" Visible="false"   Text="جستجو" SkinID="hbtn-search-r" OnClick="btnSerachLight_Click"   /> 
    </div >
 <div  id="lightboxdiv"   >
<div id="lightinsert" class=" " >
<table>
 <tr><td>نقش</td><td><asp:dropdownlist runat="server" ID="DDPackID" AutoPostBack="True" OnSelectedIndexChanged="DDUserID_SelectedIndexChanged" ></asp:dropdownlist></td><td></td><td>
</td><td></td></tr><tr><td>دسترسی</td><td><asp:dropdownlist runat="server" ID="DDPermissionID" ></asp:dropdownlist></td><td></td><td>
</td><td></td></tr><tr><td colspan="10"><table><tr><td >مشاهده</td><td><asp:checkbox runat="server" ID="TXTCanView" ></asp:checkbox>
</td><td>ویرایش</td><td><asp:checkbox runat="server" ID="TXTCanUpdate" ></asp:checkbox></td><td>
</td><td>حذف</td><td><asp:checkbox runat="server" ID="TXTCanDel" ></asp:checkbox></td><td>
</td><td>افزودن</td><td><asp:checkbox runat="server" ID="TXTCanInsert" ></asp:checkbox></td><td>
</td></tr></table></td> </tr>
</table>
              <div >
              <asp:Button runat="server" Text="ثبت"  ID="BtnInsert" SkinID="btnInsert" OnClick="BtnInsert_Click"
                         ValidationGroup="RVTbl_UserPermission" />
              
             <asp:Button runat="server"  Text="جستجو" ID="BtnSerach" SkinID="hbtn-search-r"  Visible="false" />   
            </div>
        <div>
            <asp:Label runat="server" ID="LblMsg" ></asp:Label>
        </div>
        </div>
        </div>

    <div >
          <asp:Label runat="server" ID="LblNumber"  Font-Bold="True"  ForeColor="Green"  ></asp:Label> 
    </div >
 <asp:GridView ID="GridView1"  runat="server" AutoGenerateColumns="False" AllowPaging="True" OnSorting="GridView1_Sorting" OnPageIndexChanging="GridView1_PageIndexChanging"
               AllowSorting="True" >
<Columns>
            <asp:TemplateField HeaderText="ردیف">
            <ItemTemplate >
            <asp:Label runat="server"  ID="RowNum"   Text='<%# Convert.ToString(Convert.ToInt32(DataBinder.Eval(Container, "DataItemIndex"))+1) %> '></asp:Label>
            </ItemTemplate>
            </asp:TemplateField>
<asp:TemplateField HeaderText="حذف"> 
               <ItemTemplate>
                        <a id="ADel" class="ADelete"  href='<%# DataBinder.Eval(Container,"DataItem.PermissionPAckID")%>' title="حذف"  onclick="return confirm('اطلاعات مربوط  حذف خواهد شد !!  آیا مطمئن هستید ؟')"  onserverclick="DeleteItem" runat="server"  ></a>
                </ItemTemplate>
                </asp:TemplateField >
 
   <asp:BoundField DataField="PermissionPAckID"  HeaderText="ش فرآیند"   SortExpression="PermissionPAckID" />
   <asp:BoundField DataField="PackIDName"  HeaderText="نام نقش"   SortExpression="PackIDName" />
   <asp:BoundField DataField="PermissianName"  HeaderText="دسترسی"   SortExpression="PermissianName" />
  
   <asp:TemplateField Visible="false" ><ItemTemplate><asp:Label runat="server" ID="LblUpID" Text='<%#Eval("PermissionPAckID") %>'></asp:Label></ItemTemplate></asp:TemplateField> 
    <asp:TemplateField HeaderText="مشاهده"   SortExpression="CanView"><ItemTemplate><asp:CheckBox runat="server" ID="chview" Checked='<%#Eval("CanView") %>' /></ItemTemplate></asp:TemplateField>
     <asp:TemplateField HeaderText="ویرایش"   SortExpression="CanUpdate"><ItemTemplate><asp:CheckBox runat="server" ID="chUpdate" Checked='<%# Eval("CanUpdate")  %>' /></ItemTemplate></asp:TemplateField>
    <asp:TemplateField HeaderText="حذف"   SortExpression="CanDel"><ItemTemplate><asp:CheckBox runat="server" ID="chDel" Checked='<%#  Eval("CanDel")  %>' /></ItemTemplate></asp:TemplateField>
    <asp:TemplateField HeaderText="افزودن"   SortExpression="CanInsert"><ItemTemplate><asp:CheckBox runat="server" ID="chInsert" Checked='<%# Eval("CanInsert")  %>' /></ItemTemplate></asp:TemplateField> 
 
             </Columns>
</asp:GridView>
     
<asp:Button Text="ویرایش کـــلی"  runat="server" ID="BtnUpdate" OnClick="BtnUpdate_Click" />

<%--<div  id="lightboxdiv" class="LightBoxDiv" >
<div id="lightinsert" class="Lightbox" >
<table>
 <tr><td>کاربر</td><td><asp:dropdownlist runat="server" ID="DDUserID" ></asp:dropdownlist></td><td></td><td>
</td><td></td></tr><tr><td>دسترسی</td><td><asp:dropdownlist runat="server" ID="DDPermissionID" ></asp:dropdownlist></td><td></td><td>
</td><td></td></tr><tr><td>مشاهده</td><td><asp:checkbox runat="server" ID="TXTCanView" ></asp:checkbox>
</td><td>ویرایش</td><td><asp:checkbox runat="server" ID="TXTCanUpdate" ></asp:checkbox></td><td>
</td><td>حذف</td><td><asp:checkbox runat="server" ID="TXTCanDel" ></asp:checkbox></td><td>
</td><td>افزودن</td><td><asp:checkbox runat="server" ID="TXTCanInsert" ></asp:checkbox></td><td>
</td></tr>
</table>
              <div >
              <asp:Button runat="server" Text="ثبت"  ID="BtnInsert" SkinID="btnInsert" OnClick="BtnInsert_Click"
                         ValidationGroup="RVTbl_UserPermission" />
              
             <asp:Button runat="server"  Text="جستجو" ID="BtnSerach" SkinID="hbtn-search-r"  Visible="false" />   
            </div>
        <div>
            <asp:Label runat="server" ID="LblMsg" ></asp:Label>
        </div>
        </div>
        </div>--%>
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
    function OpenLight() {
        f();
        document.getElementById('<%= LightBox.ClientID %>').value = "1";
    }
   </script>