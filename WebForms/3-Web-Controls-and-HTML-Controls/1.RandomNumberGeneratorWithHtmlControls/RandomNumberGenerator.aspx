<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RandomNumberGenerator.aspx.cs" Inherits="_1.RandomNumberGeneratorWithHtmlControls.RandomNumberGenerator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="RandomGenerator" runat="server">
        <h1>Random Number Generator with HTML server controls.</h1>
        <div>
            <label for="minNumber" runat="server">Min: </label>
            <input type="text" name="minNum" id="minNumber" runat="server" />
        </div>
        <div>
            <label for="maxNumber" runat="server">Max: </label>
            <input type="text" name="maxNumber" id="maxNumber" runat="server" />
        </div>
        <button id="btnGenerate" runat="server" onserverclick="btnGenerate_ServerClick">Generate</button>
        <br />
        <label id="lblResult" runat="server"></label>
    </form>
</body>
</html>
