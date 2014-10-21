<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HtmlEscaping.aspx.cs" Inherits="_3.HtmlEscaping.HtmlEscaping" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel runat="server">
            <div>
                <p>Input:</p>
                <asp:TextBox runat="server" ID="tbInput" />
                <asp:Button Text="Send" runat="server" ID="btnSend" OnClick="btnSend_Click" />
            </div>
            <div>
                <p>Output:</p>
                <asp:TextBox runat="server" ID="tbResult" />
                <asp:Label Text="" ID="lblResult" runat="server" />
            </div>
        </asp:Panel>
    </form>
</body>
</html>
