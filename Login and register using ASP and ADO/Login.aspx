<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LoginAndRegisterUsingASP_ADO.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label for="username">Username: </label>
            <asp:TextBox ID="username" runat="server"></asp:TextBox>
        </div>
        <div>
            <label for="password">Password: </label>
            <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="loginbtn" runat="server" Text="Login" OnClick="LoginButton_click" />
        </div>
    </form>
</body>
</html>
