<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Message.aspx.vb" Inherits="Hearthstone.Message" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hearthstone Heating and Cooling</title>
    <style type="text/css">
        .auto-style1 {
            color: #FF0000;
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            We can handle all of your heating and cooling needs. We have been in business for 25 years and are fully licensed and insured. Call us now for a <span class="auto-style1">free</span> estimate. For your peace of mind, we offer 24-hour emergency service.<br />
            <br />
            Karen and Jake Jones<br />
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Previous Page</asp:HyperLink>
        </div>
    </form>
</body>
</html>
