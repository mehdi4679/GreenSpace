<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlTreeBonCutting.ascx.cs" Inherits="GreenSpace.Controls.CtlTreeBonCutting" %>

    <%@ Register src="~/Controls/CtlDatePick.ascx" tagname="CtlDatePick" tagprefix="uc1" %>
 <div >
     <asp:Label ID="LblTreeBonCuttingID"  Visible="False" runat="server" Text="0" ></asp:Label> 
     <asp:Label ID="LblCuttingTreeID"  Visible="False" runat="server" Text="0"  ></asp:Label> 
          <asp:Label ID="LblLicensingId"  Visible="False" runat="server" Text="0"  ></asp:Label> 
     
   <%-- <asp:Button runat="server" ID="btnInsertLight"  text="افزودن"  SkinID="btnInsert"  />
    <asp:Button runat="server"  ID="btnSerachLight"  Text="جستجو" Visible="false" SkinID="hbtn-search-r"/> --%>
     <asp:Label ID="lblMantagheid" runat="server" Text="0"></asp:Label>
    </div >
<div  id="lightboxdivvvvvs" class="LightBoxDiv11" >
<div id="lightinserttrfgd" class="Lightbox11" >
<table>
<tr runat="server" id="TrPrimery"  ><td>نوع درخت</td><td><asp:dropdownlist runat="server" ID="DDTreeTypeId" ></asp:dropdownlist></td><td></td><td>
</td><td></td></tr>
<tr  ><td>نوع خیابان</td><td><asp:dropdownlist runat="server" ID="DDStreetTypeid" ></asp:dropdownlist></td><td>&nbsp;</td><td>
    &nbsp;</td><td>&nbsp;</td></tr><tr><td>بن درخت</td><td><asp:textbox   runat="server" ID="TXTBon" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>تعداد</td><td> 
  
    <asp:textbox  runat="server" ID="TXTCount" ></asp:textbox> 
  
    </td><td></td><td>
</td><td></td></tr>
    <tr runat="server" id="trZaribBazdarnde"><td>ضریب اثر بازدارندگی</td><td> 
  
    <asp:textbox  runat="server" ID="TXTZaribBazdarnde" ></asp:textbox> 
  
    </td><td>&nbsp;</td><td>
        &nbsp;</td><td>&nbsp;</td></tr>
    <tr runat="server" id="trKhesaratPrecent"><td>درصد خسارت</td><td> 
  
    <asp:textbox  runat="server" ID="TXTKhesaratPrecent" ></asp:textbox> 
  
    </td><td>&nbsp;</td><td>
        &nbsp;</td><td>&nbsp;</td></tr>
    <tr runat="server" id="trJabejaei"><td>هزینه عملیات جابه جایی</td><td> 
  
    <asp:textbox  runat="server" ID="TXTJabejaei" ></asp:textbox> 
  
    </td><td>&nbsp;</td><td>
        &nbsp;</td><td>&nbsp;</td></tr>
    <tr  runat="server" id="trMandegari"><td>ضریب عدم ماندگاری</td><td> 
  
    <asp:textbox  runat="server" ID="TXTZaribMandegari" ></asp:textbox> 
  
    </td><td>&nbsp;</td><td>
        &nbsp;</td><td>&nbsp;</td></tr>
</table>
              <div >
              <asp:Button runat="server" Text="ثبت"  ID="BtnInsert" SkinID="btnInsert" 
                        OnClick="BtnInsert_Click"  ValidationGroup="RVTbl_AgreePercentProtest" />
                          <asp:Button runat="server"  Text="ویرایش" ID="BtnUpdate" SkinID="btnOk" 
                      Visible="false" ValidationGroup="RVTbl_Sakhtikar" OnClick="BtnUpdate_Click"  />
                    <asp:Button runat="server"  Text="انصراف" ID="btncancel" SkinID="btnOk" OnClick="btncancel_Click" 
                         />
             
             <asp:Button  runat="server"  Text="جستجو" ID="BtnSerach" SkinID="hbtn-search-r"  Visible="false" />   
            </div>
        <div>
            <asp:Label runat="server" ID="LblMsg" ></asp:Label>
        </div>
        </div>
        </div>
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
                        <a id="ADel" class="ADelete"  href='<%# DataBinder.Eval(Container,"DataItem.TreeBonCuttingId")%>' title="حذف"  onclick="return confirm('اطلاعات مربوط  حذف خواهد شد !!  آیا مطمئن هستید ؟')"  onserverclick="DeleteItem" runat="server"  ></a>
                </ItemTemplate>
                </asp:TemplateField >

    <asp:TemplateField HeaderText="ویرایش">
            <ItemTemplate>
                        <a id="AEdit" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.TreeBonCuttingId")%>' title="ویرایش" onserverclick="UpItem" runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>
<%--<asp:TemplateField HeaderText="ویرایش">
            <ItemTemplate>
                        <a id="AEdit" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.TreeBonCuttingId")%>' title="ویرایش" onserverclick="UpItem" runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>--%>
   <asp:BoundField DataField="TreeTYpe"  HeaderText="نوع درخت"   SortExpression="AgreePercentProtestID" />
   <asp:BoundField DataField="Bon"  HeaderText="بن"   SortExpression="ProtestStatusIDName" />
   <asp:BoundField DataField="CatalogName"  HeaderText="نوع خیابان"   SortExpression="ProtestDatePR" />
       <asp:BoundField DataField="Count"  HeaderText="تعداد"   SortExpression="ProtestDatePR" />
           <asp:BoundField DataField="ZaribBazdarnde"  HeaderText="بازدارندگی"   SortExpression="ProtestDatePR" />
           <asp:BoundField DataField="Khesarat"  HeaderText="خسارت"   SortExpression="ProtestDatePR" >

            <ItemStyle Font-Bold="True" Font-Size="Medium" />
            </asp:BoundField>

           <asp:BoundField DataField="KhesaratPrecent"  HeaderText="درصد"   SortExpression="ProtestDatePR" />
      <asp:BoundField DataField="Jabejaei"  HeaderText="جابه جایی"    />
      <asp:BoundField DataField="ZaribMandegari"  HeaderText="عدم ماندگاری"   />
         
             </Columns>
</asp:GridView>
        


<%--<asp:TemplateField HeaderText="ویرایش">
            <ItemTemplate>
                        <a id="AEdit" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.TreeBonCuttingId")%>' title="ویرایش" onserverclick="UpItem" runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>--%><%--<asp:TemplateField HeaderText="ویرایش">
            <ItemTemplate>
                        <a id="AEdit" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.TreeBonCuttingId")%>' title="ویرایش" onserverclick="UpItem" runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>--%>

