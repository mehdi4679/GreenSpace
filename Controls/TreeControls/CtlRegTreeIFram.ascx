<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlRegTreeIFram.ascx.cs" Inherits="GreenSpace.Controls.TreeControls.CtlRegTreeIFram" %>

                <div class="regTree col-md-8" style="height:200px;overflow:auto;width:400px">
        <div class="row">
            <div class="col-md-6">
                <div>نوع درخت<span style="color:red">*</span> </div>
                <asp:DropDownList ID="ddlTreeType"  runat="server" CssClass="ddlTreeType">
                    <asp:ListItem>1</asp:ListItem>

                </asp:DropDownList>
            </div>
            <div class="col-md-6">
                <div>
                    نوع مکان</div>
                <asp:DropDownList ID="ddlStreetType" runat="server" CssClass="ddlStreetType">
                    <asp:ListItem>1</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <div>نوع مجوز</div>
                <asp:DropDownList ID="ddlLicesnceType" runat="server" CssClass="ddlLicesnceType">
                    <asp:ListItem>1</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="col-md-6">
                <div>
                    <span style="color:red">*</span>
                    تعداد</div>
                <asp:TextBox ID="txtCount" runat="server" CssClass="txtCount"></asp:TextBox>
                 <asp:RegularExpressionValidator ID="RVtxtCount" runat="server"
                        ControlToValidate="txtCount" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید"
                        ValidationExpression="^[+]?\d*$" SetFocusOnError="True"
                        ValidationGroup="RegTree" ForeColor="Red"></asp:RegularExpressionValidator>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator123" runat="server"
                        ControlToValidate="txtCount" ErrorMessage="لطفا پر کنید"
                        ValidationGroup="RegTree" ForeColor="Red" style="display:none;"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <div>بن</div>
                <asp:TextBox ID="txtBon" runat="server" CssClass="txtBon"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RVtxtBon" runat="server"
                        ControlToValidate="txtBon" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید"
                        ValidationExpression="^[+]?\d*$" SetFocusOnError="True"
                        ValidationGroup="RegTree" ForeColor="Red"></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                        ControlToValidate="txtBon" ErrorMessage="لطفا پر کنید"
                        ValidationGroup="RegTree" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
            <div class="col-md-6">
                <div>تاریخ</div>
<%--                <uc1:CtlDatePick runat="server" ID="CtlDatePick" />--%>
                <asp:TextBox runat="server" ID="CtlDatePick" CssClass="CtlDatePick"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <asp:DropDownList runat="server" ID="ddRegion" CssClass="ddRegion">
                    <asp:ListItem>1</asp:ListItem>
                </asp:DropDownList>
            </div>
                <div style="display:none" class="col-md-6"><span style="color:red">*</span>
                <asp:CheckBox ID="chkMojavez" runat="server" TextAlign="Right" Text="مجوز" />
                </div>
        </div>
        <div class="row">           
            <div class="col-md-6">
                <div>  <span style="color:red">*</span>آدرس
                </div>
                <asp:TextBox ID="txtAddress" runat="server" CssClass="txtAddress" TextMode="MultiLine"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                        ControlToValidate="txtAddress" ErrorMessage="لطفا پر کنید"
                        ValidationGroup="RegTree" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
            

           <div class="col-md-6">
                <div><span style="color:red">*</span>
                    توضیحات</div>
                <asp:TextBox  runat="server" class="form-control pdp-el" id="txtcomment"   TextMode="MultiLine"/>
               <asp:RequiredFieldValidator ID="txtcomment13" runat="server"
                        ControlToValidate="txtcomment" ErrorMessage="لطفا پر کنید"
                        ValidationGroup="RegTree" ForeColor="Red"></asp:RequiredFieldValidator>
             </div>
        </div>

        <div class="row">
<%--            <input type="button" onclick="save()" value="ثبت اطلاعات"  />--%>
            <asp:Button runat="server" ID="btnInsert" Text="ثبت اطلاعات" OnClick="btnInsert_Click"   ValidationGroup="RegTree"/>
        </div>
        <div></div>
        <asp:Label ID="LblMsg" runat="server" Text=""></asp:Label>

        <input type="hidden" id="latlong" value="0" runat="server"/>
        <input type="hidden" id="txtid" value="0"  runat="server">
        <input type="hidden" id="txtPersonalID" value="0" runat="server" />
        <input type="hidden" id="txtHaghighiId" value="0" runat="server"  />

    </div>

