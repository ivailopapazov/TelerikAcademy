<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Hello.aspx.cs" Inherits="_1.SimpleAspxPage.Hello" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
        <asp:Button ID="btnPrintName" runat="server" Text="Greet!" OnClick="btnPrintName_Click" />
        <asp:Label ID="lblName" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
