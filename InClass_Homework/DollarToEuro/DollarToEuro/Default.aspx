<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="DollarToEuro._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dollars to Euros</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center">
            <h1 style="text-align: center">Dollars to Euros</h1>
        </div>
        <div style="text-align: center">
            <p style="text-align: center">
                Dollars:
                <asp:TextBox ID="txtInput" runat="server" Width="95px"></asp:TextBox>
            </p>
        </div>
        <div style="text-align: center">
            <p style="text-align: center">
                Euros: <asp:Label ID="lblEuros" runat="server"></asp:Label>
            </p>
        </div>
        <div style="text-align: center">
            <p style="text-align: center">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:ImageButton ID="imgBtnClickHere" runat="server" Height="137px" ImageUrl="~/ClickHere.png" Width="252px" />
            </p>
        </div>
        <div style="text-align: center">
            <p style="text-align: center">
                &nbsp;</p>
        </div>
    </form>
</body>
</html>
