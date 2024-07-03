<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication8.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Clac</title>
    <link rel="stylesheet" href="bootstrap.css" type="text/css" />

</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-4">
            <div>
                <asp:Label ID="ResultBox" runat="server" Text=""></asp:Label>
            </div>
            <div>
                <asp:Label ID="newLabel1" runat="server" Text="Number 1"></asp:Label><asp:TextBox ID="Number1" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="newLabel2" runat="server" Text="Number 2"></asp:Label><asp:TextBox ID="Number2" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <asp:Button ID="AddButton" runat="server" CssClass="btn btn-primary" Text="+" Height="50px" Width="200px" OnClick="AddButton_Click" />
            <asp:Button ID="SubtractButton" runat="server" CssClass="btn btn-warning" Text="-" Height="50px" Width="200px" OnClick="SubtractButton_Click" />
            <asp:Button ID="MultiplyButton" runat="server" CssClass="btn btn-info" Text="*" Height="50px" Width="200px" OnClick="MultiplyButton_Click" />

        </div>
    </form>
</body>
</html>
