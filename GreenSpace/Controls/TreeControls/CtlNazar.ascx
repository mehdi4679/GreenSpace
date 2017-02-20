<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlNazar.ascx.cs" Inherits="GreenSpace.Controls.CtlNazar" %>
     <asp:Label ID="LblLicensingId" runat="server" Text="0"></asp:Label>
     <asp:Label ID="LblParamid"  Visible="false" runat="server" ></asp:Label> 

<div  id="lightboxdivvvvvs1" class="LightBoxDiv11" >
<div id="lightinserttrfgd2" class="Lightbox11" >
<table>
<tr runat="server" id="TrPrimery" ><td></td><td><asp:textbox Visible="false"   runat="server" ID="TXTid" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>نظر</td><td><asp:dropdownlist runat="server" ID="DDNazarTypeId" ></asp:dropdownlist></td><td></td><td>
</td><td></td></tr><tr><td>توضیحات</td><td><asp:textbox runat="server" ID="TXTNazarComment" TextMode="MultiLine" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>سمت</td><td><asp:dropdownlist runat="server" ID="DDManage" ></asp:dropdownlist></td><td></td><td>
</td><td></td></tr>
</table>
              <div >
              <asp:Button runat="server" Text="افزودن"  ID="BtnInsert" SkinID="btnInsert" 
                     ValidationGroup="RVTbl_Nazar" OnClick="BtnInsert_Click" />
             <asp:Button runat="server"  Text="ویرایش" ID="BtnUpdate" SkinID="btnOk" 
                      Visible="false" ValidationGroup="RVTbl_Nazar" OnClick="BtnUpdate_Click1"  />
             <asp:Button runat="server"  Text="انصراف" ID="BtnCancel" SkinID="hbtn-search-r" OnClick="BtnCancel_Click" />   
            </div>
        <div>
            <asp:Label runat="server" ID="LblMsg" ></asp:Label>
        </div>
<div >

    <asp:Button runat="server" ID="btnInsertLight"  text="افزودن"  SkinID="btnInsert" OnClick="btnInsertLight_Click1" Visible="False"  />
    <asp:Button runat="server"  ID="btnSerachLight"  Text="جستجو" SkinID="hbtn-search-r" Visible="False"/> 

    </div >
    <div >
          <asp:Label runat="server" ID="LblNumber"  Font-Bold="True"  ForeColor="Green"  ></asp:Label> 
    </div >


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
                        <a id="ADel" class="ADelete"  href='<%# DataBinder.Eval(Container,"DataItem.id")%>' title="حذف"  onclick="return confirm('اطلاعات مربوط  حذف خواهد شد !!  آیا مطمئن هستید ؟')"  onserverclick="DeleteItem" runat="server"  ></a>
                </ItemTemplate>
                </asp:TemplateField >
<asp:TemplateField HeaderText="ویرایش">
            <ItemTemplate>
                        <a id="AEdit" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.id")%>' title="ویرایش" onserverclick="UpItem" runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>
   <asp:BoundField DataField="id"  HeaderText="ردیف"   SortExpression="id" />
   <asp:BoundField DataField="nazart"  HeaderText="نظر"   SortExpression="NazarTypeId" />
   <asp:BoundField DataField="NazarComment"  HeaderText="توضیحات"   SortExpression="NazarComment" />
   <asp:BoundField DataField="date1"  HeaderText="تاریخ"   SortExpression="NazarDate" />
   <asp:BoundField DataField="fullname"  HeaderText="کاربر"   SortExpression="UserId" />
   <asp:BoundField DataField="manage1"  HeaderText="سمت"   SortExpression="Manage" />
             </Columns>
</asp:GridView>


<%--<div  id="lightboxdiv" class="LightBoxDiv" >
<div id="lightinsert" class="Lightbox" >--%>
<%--        </div>
        </div>--%><%-- <input type="hidden"  id="LightBox" runat="server" /> 
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
   </script>--%>

