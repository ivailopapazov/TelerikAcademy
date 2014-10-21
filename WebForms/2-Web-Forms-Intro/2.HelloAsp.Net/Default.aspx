<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_2.HelloAsp.Net._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="hello-container">
        <h2>Hello from ASP.Net aspx file!</h2>
        <asp:Label ID="lblHello" runat="server" Font-Size="X-Large"></asp:Label>
        <br />
        <asp:Label ID="lblPath" runat="server" Font-Size="X-Large"></asp:Label>
    </div>
</asp:Content>
