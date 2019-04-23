<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="Hearthstone._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hearthstone Heating and Cooling</title>
    <style type="text/css">
        #form1 {}
        .auto-style1 {
            font-weight: normal;
            color: #FF33CC;
            text-decoration: underline;
        }
    </style>
    </head>
<body style="text-align: center">

    <form id="form1" runat="server">
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Thermostat.png" style="float: left" />
        <h1><span class="auto-style1"><strong>Hearthstone Heating and Cooling</strong></span><br />
            123 Main Street<br />
            Chicago, IL 60606<br />
            312-999-9999</h1>
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Message.aspx">Next Page</asp:HyperLink>
    </form>

</body>
</html>
