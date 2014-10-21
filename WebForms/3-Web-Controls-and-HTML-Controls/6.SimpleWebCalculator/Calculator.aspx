<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="_6.SimpleWebCalculator.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculator</title>
    <style>
        #displayCell {
            height: 20px;
            border: 1px solid black;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Table ID="Table1" runat="server" Height="98px" Width="131px">
            <asp:TableRow>
                <asp:TableCell ColumnSpan="4" ID="displayCell"><asp:label text="" ID="lblResult" runat="server" /></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell><asp:Button ID="btnOne" runat="server" Text="1" OnClick="btnOne_Click" /></asp:TableCell>
                <asp:TableCell><asp:Button ID="btnTwo" runat="server" Text="2" OnClick="btnTwo_Click" /></asp:TableCell>
                <asp:TableCell><asp:Button ID="btnThree" runat="server" Text="3" OnClick="btnThree_Click" /></asp:TableCell>
                <asp:TableCell><asp:Button ID="btnPlus" runat="server" Text="+" OnClick="btnPlus_Click" /></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell><asp:Button ID="btnFour" runat="server" Text="4" OnClick="btnFour_Click" /></asp:TableCell>
                <asp:TableCell><asp:Button ID="btnFive" runat="server" Text="5" OnClick="btnFive_Click" /></asp:TableCell>
                <asp:TableCell><asp:Button ID="btnSix" runat="server" Text="6" OnClick="btnSix_Click" /></asp:TableCell>
                <asp:TableCell><asp:Button ID="btnMinus" runat="server" Text="-" OnClick="btnMinus_Click" /></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell><asp:Button ID="btnSeven" runat="server" Text="7" OnClick="btnSeven_Click" /></asp:TableCell>
                <asp:TableCell><asp:Button ID="btnEight" runat="server" Text="8" OnClick="btnEight_Click" /></asp:TableCell>
                <asp:TableCell><asp:Button ID="btnNine" runat="server" Text="9" OnClick="btnNine_Click" /></asp:TableCell>
                <asp:TableCell><asp:Button ID="btnMultiplication" runat="server" Text="*" OnClick="btnMultiplication_Click" /></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell><asp:Button ID="btnClear" runat="server" Text="C" OnClick="btnClear_Click" /></asp:TableCell>
                <asp:TableCell><asp:Button ID="btnZero" runat="server" Text="0" OnClick="btnZero_Click" /></asp:TableCell>
                <asp:TableCell><asp:Button ID="btnDivision" runat="server" Text="/" OnClick="btnDivision_Click" /></asp:TableCell>
                <asp:TableCell><asp:Button ID="btnSqrt" runat="server" Text="√" OnClick="btnSqrt_Click" /></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell ColumnSpan="4"><asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" /></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
    </form>
</body>
</html>
