<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="LoginAndRegisterUsingASP_ADO.Register" %>

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
            <label for="email">Email: </label>
            <asp:TextBox ID="email" runat="server"></asp:TextBox>
        </div>
        <div>
            <label for="mobile">Mobile No: </label>
            <asp:TextBox ID="mobile" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="registerbtn" runat="server" Text="Register" OnClick="RegisterButton_click" />
        </div>
        <div>
            <asp:HyperLink ID="loginLink" runat="server" Text="Already have an account? Login here" NavigateUrl="Login.aspx" />
        </div>
    </form>
</body>
</html>
