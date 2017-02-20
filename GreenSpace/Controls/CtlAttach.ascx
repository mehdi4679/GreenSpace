<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlAttach.ascx.cs" Inherits="GreenSpace.Controls.CtlAttach" %>
 <style>
 .dpic{
 position:relative;
 float:right;
 padding:5px;
 text-align:center;
 
 }
   .picc{
  width:200px;
  height:200px;
  border-radius:10px;
  
  }
 .apic
 {
     position:absolute;
     top:0px;
     right:0px;
     }
 </style>

<table>
<tr><td><asp:DropDownList Visible="false"  runat="server" ID="ddtype" >
    <asp:ListItem Value="-111">قطع درخت</asp:ListItem>
    </asp:DropDownList></td><td>
     
            
   <input type="file" runat="server"   ID="FileUpload11" multiple="true"  accept="image/*" />

                                                                             </td></tr>
</table>
<asp:Label ID="listofuploadedfiles" runat="server"  ForeColor="Green"/>
<asp:Label runat="server" ID="lblPazireshID" Text="0" Visible="false"></asp:Label>

<asp:Label runat="server" ID="lblID" Visible="false" Text="0"></asp:Label>
<asp:Label runat="server" ID="lblForTable" Visible="false" Text="Tbl_Personal"></asp:Label>

<table><tr>
<td><asp:Button runat="server" ID="btnSave" Text="ذخیره" onclick="btnSave_Click" 
         /></td>
<td><asp:Label runat="server" ID="lblmsg"></asp:Label></td>
</tr>
 
</table>
    
<asp:Repeater runat="server" ID="Grid"   SkinID="" >
        
        
        <ItemTemplate>
                 <div id="dPicView" class="dpic" >
                        <a id="ADel" class="ADelete apic"  href='<%# DataBinder.Eval(Container,"DataItem.AttachID")%>' title="حذف"  onclick="return confirm('اطلاعات مربوط  حذف خواهد شد !!  آیا مطمئن هستید ؟')"  onserverclick="DeleteItem" runat="server"  ></a>
                 <img runat="server" class="picc" id="img" src='<%# "/upload/"+Eval("AttachID")+ System.IO.Path.GetExtension(Eval("AttachName").ToString()) %>' /><br />
<%--                 <asp:Label runat="server" ID="lbltype" Text='<%# Eval("TypeName") %>'></asp:Label><br />--%>
 
                                      <asp:Label runat="server" ID="lblAttachID" Visible="false" Text='<%# Eval("AttachID") %>'></asp:Label>
                </div>       
        </ItemTemplate>
        
        

        </asp:Repeater>

