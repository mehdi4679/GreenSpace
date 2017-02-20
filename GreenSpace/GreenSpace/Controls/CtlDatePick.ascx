<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlDatePick.ascx.cs" Inherits="Taxi.Controls.CtlDatePick" %>
<input type="text" id="txtDate" runat="server"  />

<script type="text/javascript" >
        
    $("#<%= txtDate.ClientID %>").persianDatepicker({
            theme: 'dark'
        });
       
//</script>
      
