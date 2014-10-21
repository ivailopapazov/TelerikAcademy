<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="_4.StudentRegistration.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="register" runat="server">
        <label for="tbFirstname">First Name: </label>
        <asp:TextBox runat="server" ID="tbFirstname" />
        <br />
        <label for="tbLastname">Last Name: </label>
        <asp:TextBox runat="server" ID="tbLastname" />
        <br />
        <label for="tbFacultyNumber">Faculty Number: </label>
        <asp:TextBox runat="server" ID="tbFacultyNumber" />
        <br />
        <label for="ddlUniversities">Univeristy: </label>
        <asp:DropDownList runat="server" ID="ddlUniversities">
            <asp:ListItem Text="Sofia University" />
            <asp:ListItem Text="Technical University" />
            <asp:ListItem Text="New Bulgarian University" />
        </asp:DropDownList>
        <br />
        <label for="lbSpecialty">Specialty: </label>
        <asp:ListBox SelectionMode="Multiple" runat="server" ID="lbSpecialty">
            <asp:ListItem Text="Computer Science" />
            <asp:ListItem Text="Telecomunications" />
            <asp:ListItem Text="Mathematics" />
        </asp:ListBox>
        <br />
        <asp:Button Text="Submit" runat="server" ID="btnSumbit" OnClick="btnSumbit_Click" />
        <br />
        <asp:PlaceHolder runat="server" ID="phDetails" />
    </form>
</body>
</html>
