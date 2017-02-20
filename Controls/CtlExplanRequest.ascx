<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlExplanRequest.ascx.cs" Inherits="GreenSpace.Controls.CtlExplanRequest" %>
    <%@ Register src="CtlDropExplan.ascx" tagname="CtlDropExplan" tagprefix="uc1" %>
    <%@ Register src="CtlDatePick.ascx" tagname="CtlDatePick" tagprefix="uc2" %>
    <%@ Register src="CtlAllSubjectExplan.ascx" tagname="CtlAllSubjectExplan" tagprefix="uc3" %>
    <div >
     <asp:Label ID="LblParamExplanRequestOpenID"    runat="server" Text="0" ></asp:Label> 
    <input type="button" value="افزودن" class="btnInsert" runat="server" ID="btnInsertLight"  text="افزودن"  SkinID="btnInsert"   onclick="setlight();"  />
    <asp:Button runat="server"  ID="btnSerachLight"  Text="جستجو" SkinID="hbtn-search-r" Visible="false"/> 
    </div >
    <div >
          <asp:Label runat="server" ID="LblNumber"  Font-Bold="True"  ForeColor="Green"  ></asp:Label> 
    </div >
 <asp:GridView ID="GridView1"  runat="server" AutoGenerateColumns="False" AllowPaging="True"
               AllowSorting="True" OnPageIndexChanging="GridView1_PageIndexChanging" >
<Columns>
            <asp:TemplateField HeaderText="ردیف">
            <ItemTemplate >
            <asp:Label runat="server"  ID="RowNum"   Text='<%# Convert.ToString(Convert.ToInt32(DataBinder.Eval(Container, "DataItemIndex"))+1) %> '></asp:Label>
            </ItemTemplate>
            </asp:TemplateField>
<asp:TemplateField HeaderText="حذف"> 
               <ItemTemplate>
                        <a id="ADel" class="ADelete"  href='<%# DataBinder.Eval(Container,"DataItem.ExplanRequestOpenID")%>' title="حذف"  onclick="return confirm('اطلاعات مربوط  حذف خواهد شد !!  آیا مطمئن هستید ؟')"  onserverclick="DeleteItem" runat="server"  ></a>
                </ItemTemplate>
                </asp:TemplateField >
<asp:TemplateField HeaderText="ویرایش">
            <ItemTemplate>
                        <a id="AEdit" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.ExplanRequestOpenID")%>' title="ویرایش" onserverclick="UpItem" runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>
   <asp:BoundField DataField="ExplanRequestOpenID"  HeaderText="ش فرآیند"   SortExpression="ExplanRequestOpenID" />
   <asp:BoundField DataField="subjectname"  HeaderText="موضوع کار"   SortExpression="subjectname" />

   <asp:BoundField DataField="ExplainName"  HeaderText="شرح کار"   SortExpression="ExplainName" />
   <asp:BoundField DataField="FromDatefa"  HeaderText="از تاریخ"   SortExpression="FromDate" />
   <asp:BoundField DataField="ToDatefa"  HeaderText="تا تاریخ"   SortExpression="ToDate" />
   <asp:BoundField DataField="IsOKName"  HeaderText="مورد قبول؟"   SortExpression="IsOKName" />
   <asp:BoundField DataField="tfusername"  HeaderText="درخواست کننده "   SortExpression="tfusername" />
   <asp:BoundField DataField="RegDatefa"  HeaderText="تاریخ درخواست"   SortExpression="RegDate" />
   <asp:BoundField DataField="tadminusername"  HeaderText="پاسخ دهنده"   SortExpression="tadminusername" />
   <asp:BoundField DataField="SYSOKDatefa"  HeaderText="تاریخ پاسخ"   SortExpression="SYSOKDate" />
   <asp:BoundField DataField="agreename"  HeaderText="برای قرارداد"   SortExpression="agreename" />
             </Columns>
</asp:GridView>
       

<div  id="lightboxdiv" class="LightBoxDiv" >
<div id="lightinsert" class="Lightbox" style="width:auto">
<table>
<tr runat="server" id="TrPrimery" visible="false" ><td>ش فرآیند</td><td><asp:textbox Visible="false"   runat="server" ID="TXTExplanRequestOpenID" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>شرح کار</td><td> 
            <uc3:CtlAllSubjectExplan ID="TXTExplanID" runat="server" />

                                       </td><td>
    
    
    </td><td>
</td><td></td></tr><tr><td>از تاریخ</td><td> 
    <uc2:CtlDatePick ID="TXTFromDate" runat="server" />
    </td><td></td><td>
</td><td></td></tr><tr><td>تا تاریخ</td><td>
   
     <uc2:CtlDatePick ID="TXTToDate" runat="server" />
                                        </td><td></td><td>
</td><td></td></tr><tr runat="server" id="trok" visible="false" ><td>مورد قبول؟</td><td><asp:DropDownList runat="server" ID="TXTIsOK" >
    <asp:ListItem Value="-1">در حال بررسی</asp:ListItem>
    <asp:ListItem Value="1">قبول</asp:ListItem>
    <asp:ListItem Value="0">رد</asp:ListItem>
    </asp:DropDownList></td><td></td><td>
</td><td></td></tr>
    <Table><tr><td><div id="iiii" runat="server" visible="false"> <tr><td>درخواست کننده </td><td><asp:textbox Text="0" runat="server" ID="TXTForUserID" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>تاریخ درخواست</td><td><asp:textbox runat="server" ID="TXTRegDate" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>پاسخ دهنده</td><td><asp:textbox runat="server" ID="TXTByUserID" Text="0"></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>تاریخ پاسخ</td><td><asp:textbox runat="server" ID="TXTSYSOKDate" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>برای قرارداد</td><td><asp:textbox runat="server" ID="TXTForAgreementID"  Text="0"></asp:textbox></td><td></td><td>
</td><td></td></tr>
</div></td></tr></Table></tr>
</table>
              <div >
              <asp:Button runat="server" Text="افزودن"  ID="BtnInsert" SkinID="btnInsert" 
                          ValidationGroup="RVTbl_ExplanRequest" OnClick="BtnInsert_Click1" />
                  <asp:Label ID="lblsamttype" runat="server" Text="bazras" Visible="false" ></asp:Label>
                  <asp:Label ID="lblsematid" runat="server" Text="bazras" Visible="false" ></asp:Label>

             <asp:Button runat="server"  Text="ویرایش" ID="BtnUpdate" SkinID="btnOk" 
                      Visible="false" ValidationGroup="RVTbl_ExplanRequest"   />
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
    function setlight() {
        document.getElementById('<%= LightBox.ClientID %>').value = 1;
            document.getElementById('<%= LblParamExplanRequestOpenID.ClientID %>').value = 0;
            f();

        }
   </script>

