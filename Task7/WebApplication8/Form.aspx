<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form.aspx.cs" Inherits="WebApplication8.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="bootstrap.css" type="text/css" />
    <title>There </title>
</head>
<body>
    <div class="container mt-4">
        <link rel="stylesheet" href="bootstrap.css" type="text/css" />
        <form runat="server">
            <div class="mb-4">
                <asp:Label ID="NameLable" runat="server" Text="Name"></asp:Label>
                <asp:TextBox ID="NameText" runat="server" CssClass="form-control" OnTextChanged="NameText_TextChanged"></asp:TextBox>
            </div>
            <div class="mb-4">
                <asp:Label ID="Label1" runat="server" Text="ID"></asp:Label>
                <asp:TextBox ID="IDTextBox" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-4">
                <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
                <asp:TextBox ID="EmailTextBox" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div>
                <div>
                    <div>
                        <asp:Label ID="Label3" runat="server" Text="Course"></asp:Label>
                    </div>
                    <asp:Label ID="Label4" runat="server" Text="C++"></asp:Label><asp:CheckBox ID="CheckBox1" runat="server" />
                    <asp:Label ID="Label5" runat="server" Text="C#"></asp:Label><asp:CheckBox ID="CheckBox2" runat="server" />
                    <asp:Label ID="Label6" runat="server" Text="C"></asp:Label><asp:CheckBox ID="CheckBox3" runat="server" />
                </div>
            </div>
            <div>
                <div class="mb-4">
                    <asp:Label ID="Label7" runat="server" Text="Gender"></asp:Label>
                    <asp:RadioButtonList ID="Gender" runat="server">
                        <asp:ListItem>Female</asp:ListItem>
                        <asp:ListItem>Male</asp:ListItem>
                    </asp:RadioButtonList>
                </div>
            </div>
            <div>
                <asp:Label ID="Label9" runat="server" Text="description:"></asp:Label>
                <textarea id="TextArea1" cols="20" rows="2" runat="server"></textarea>
            </div>
            <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" Text="submit" OnClick="Button1_Click" />
        </form>
        <div>
            <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label10" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label11" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label12" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label13" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label14" runat="server" Text=""></asp:Label>
        </div>

    </div>

</body>
</html>
