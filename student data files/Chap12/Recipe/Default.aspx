<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Measurement Converter</title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <h1 class="auto-style1">Measurement Converter</h1>
        <p class="auto-style1">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Spoon.png" />
        </p>
        <br />
        <span class="auto-style2">Teaspoons:&nbsp;&nbsp; </span>
        <asp:TextBox ID="txtOriginalTeaSpoons" runat="server" CssClass="auto-style2" Font-Size="Large" Width="45px"></asp:TextBox>
&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtOriginalTeaSpoons" ErrorMessage="Required Entry" ForeColor="Red"></asp:RequiredFieldValidator>
        <br class="auto-style2" />
        <span class="auto-style2">Multiply By:&nbsp; </span>
        <asp:TextBox ID="txtMultiplyBy" runat="server" CssClass="auto-style2" Font-Size="Large" Width="45px"></asp:TextBox>
&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtMultiplyBy" ErrorMessage="Required Entry" ForeColor="Red"></asp:RequiredFieldValidator>
        <br class="auto-style2" />
        <br class="auto-style2" />
        <span class="auto-style2">Number of tablespoons:&nbsp; </span>
        <asp:Label ID="lblTablespoons" runat="server" CssClass="auto-style2" Font-Size="Large"></asp:Label>
        <br class="auto-style2" />
        <br class="auto-style2" />
        <span class="auto-style2">Number of Teaspoons:&nbsp;&nbsp;&nbsp; </span>
        <asp:Label ID="lblTeaspoons" runat="server" CssClass="auto-style2" Font-Size="Large"></asp:Label>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSubmit" runat="server" style="font-size: medium" Text="Submit" />
        <br />
    
    </div>
    </form>
</body>
</html>
