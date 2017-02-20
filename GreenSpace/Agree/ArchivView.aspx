<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/AgreeMaster.master" AutoEventWireup="true" CodeBehind="ArchivView.aspx.cs" Inherits="GreenSpace.Agree.ArchivView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PesonContentPlaceHolder" runat="server">
      
                <asp:Label runat="server" ID="lblAgrement" Text="0" Visible="false" ></asp:Label>
                <asp:Label runat="server" ID="LBLkHESARAT" Text="0"   ></asp:Label>
                <asp:Label runat="server" ID="LblParamArchivID" Text="0"   Visible="false" ></asp:Label>

   <asp:DropDownList runat="server" ID="ddSubject" AutoPostBack="true" OnSelectedIndexChanged="ddExpalnID_SelectedIndexChanged"></asp:DropDownList>
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
                        <a id="ADel" class="ADelete"  href='<%# DataBinder.Eval(Container,"DataItem.AcrchiveID")%>' title="حذف"  onclick="return confirm('اطلاعات مربوط  حذف خواهد شد !!  آیا مطمئن هستید ؟')"  onserverclick="DeleteItem" runat="server"  ></a>
                </ItemTemplate>
                </asp:TemplateField >
<asp:TemplateField HeaderText="ویرایش">
            <ItemTemplate>
                        <a id="AEdit" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.AcrchiveID")%>' title="ویرایش" onserverclick="UpItem" runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>
   <asp:BoundField DataField="AcrchiveID"  HeaderText="ش فرآیند"   SortExpression="AcrchiveID" />
   <asp:BoundField DataField="AgreeIDNAme"  HeaderText="قرارداد"   SortExpression="AgreeIDNAme" />
   <asp:BoundField DataField="SubjectIDNAme"  HeaderText="موضوع"   SortExpression="SubjectIDNAme" />
   <asp:BoundField DataField="SubjectExplainIDNAme"  HeaderText="شرح"   SortExpression="SubjectExplainIDNAme" />
   <asp:BoundField DataField="UnitNameIDNAme"  HeaderText="واحد"   SortExpression="UnitNameIDNAme" />
   <asp:BoundField DataField="PriceUnit"  HeaderText="قیمت"   SortExpression="PriceUnit" />
   <asp:BoundField DataField="UtilityPercent2"  HeaderText="درصد"   SortExpression="UtilityPercent2" />
   <asp:BoundField DataField="ActionPercent"  HeaderText="درصد اعمالی"   SortExpression="ActionPercent" />
   <asp:BoundField DataField="SumMeter"  HeaderText="متراژ"   SortExpression="SumMeter" />
   <asp:BoundField DataField="Pulus"  HeaderText="پلوس"   SortExpression="Pulus" />
   <asp:BoundField DataField="OperationSum"  HeaderText="جمع عملکرد"   SortExpression="OperationSum" />
   <asp:BoundField DataField="PaySum"  HeaderText="پرداختی"   SortExpression="PaySum" />
   <asp:BoundField DataField="FineZarib"  HeaderText="ضریب جریمه"   SortExpression="FineZarib" />
   <asp:BoundField DataField="FromDateNAme"  HeaderText="از تاریخ"   SortExpression="FromDateNAme" />
   <asp:BoundField DataField="ToDateNAme"  HeaderText="تا تاریخ"   SortExpression="ToDateNAme" />
             </Columns>
</asp:GridView>
         

<div  id="lightboxdiv" class="LightBoxDiv" >
<div id="lightinsert" class="Lightbox" >
<table>
<tr runat="server" id="TrPrimery" ><td>ش فرآیند</td><td><asp:textbox Visible="false"   runat="server" ID="TXTAcrchiveID" ></asp:textbox></td><td></td><td>
</td><td></td></tr>
   <%-- <tr><td>قرارداد</td><td><asp:textbox runat="server" ID="TXTAgreeID" ></asp:textbox></td><td></td><td>
</td><td></td></tr>
    <tr><td>موضوع</td><td><asp:textbox runat="server" ID="TXTSubjectID" ></asp:textbox></td><td></td><td>
</td><td></td></tr>
    <tr><td>شرح</td><td><asp:textbox runat="server" ID="TXTSubjectExplainID" ></asp:textbox></td><td></td><td>
</td><td></td></tr>--%>
    <tr><td>واحد</td><td><asp:textbox runat="server" ID="TXTUnitNameID" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>قیمت</td><td><asp:textbox runat="server" ID="TXTPriceUnit" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>درصد</td><td><asp:textbox runat="server" ID="TXTUtilityPercent" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>درصد اعمالی</td><td><asp:textbox runat="server" ID="TXTActionPercent" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>متراژ</td><td><asp:textbox runat="server" ID="TXTSumMeter" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>پلوس</td><td><asp:textbox runat="server" ID="TXTPulus" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>جمع عملکرد</td><td><asp:textbox runat="server" ID="TXTOperationSum" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>پرداختی</td><td><asp:textbox runat="server" ID="TXTPaySum" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>ضریب جریمه</td><td><asp:textbox runat="server" ID="TXTFineZarib" ></asp:textbox></td><td></td><td>
</td><td></td></tr>
<tr><td>تکرار</td><td><asp:textbox runat="server" ID="txtrepeattt" ></asp:textbox></td><td></td><td>
</td><td></td></tr>
 <%--   <tr><td>از تاریخ</td><td><asp:textbox runat="server" ID="TXTFromDate" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>تا تاریخ</td><td><asp:textbox runat="server" ID="TXTToDate" ></asp:textbox></td><td></td><td>
</td><td></td></tr>--%>
</table>
              <div >
              <asp:Button runat="server" Text="ثبت"  ID="BtnInsert" SkinID="btnInsert"  OnClick="BtnInsert_Click"
                         ValidationGroup="RVtbl_ArchiveAgree"  />
             <asp:Button runat="server"  Text="ویرایش" ID="BtnUpdate" SkinID="btnOk" 
                      Visible="false" ValidationGroup="RVtbl_ArchiveAgree"  />
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
    function openlight() {
        document.getElementById('<%= LightBox.ClientID %>').value = "1";
        f();
    }
   </script>


 </asp:Content>
