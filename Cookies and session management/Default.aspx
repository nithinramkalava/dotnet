<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CookiesAndSession.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Cookies and Session Management</h1>
        <div>
            <label for="txtCookie">Enter a value for a cookie:</label>
            <asp:TextBox ID="txtCookie" runat="server" ></asp:TextBox>
            <asp:Button ID="btnSetCookie" runat="server" Text="Set Cookie" OnClick="SetCookie_Click" />
        </div>
        <div>
            <label for="txtSession">Enter a value for a session:</label>
            <asp:TextBox ID="txtSession" runat="server"></asp:TextBox>
            <asp:Button ID="btnSetSession" runat="server" Text="Set Session" OnClick="SetSession_Click" />
        </div>
        <hr />
        <div>
            <asp:Label ID="lblCookie" runat="server"></asp:Label>
        </div>
        <div>
            <asp:Label ID="lblSession" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
