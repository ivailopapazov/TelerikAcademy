<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RandomNumberGenerator.aspx.cs" Inherits="_2.RandomNumberGeneratorWithWebControls.RandomNumberGenerator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="RandomGenerator" runat="server">
        <h1>Random Number Generator with Web server controls.</h1>
        <asp:Panel ID="content" runat="server">
            <div>
                <asp:Label Text="Min: " ID="lblMinNumber" runat="server" />
                <asp:TextBox runat="server" ID="tbMinNumber" />
            </div>
            <div>
                <asp:Label Text="Max: " ID="lblMaxNumber" runat="server" />
                <asp:TextBox runat="server" ID="tbMaxNumber" />
            </div>
            <asp:Button Text="Generate" runat="server" ID="btnGenerate" OnClick="btnGenerate_Click" />
            <div>
                <asp:Label Text="Result: " runat="server" />
                <asp:Label Text="" ID="lblResult" runat="server" />
            </div>
        </asp:Panel>
    </form>
</body>
</html>
