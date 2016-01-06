<%@ Page Language="C#" AutoEventWireup="true" CodeFile="a.aspx.cs" Inherits="a" %>



<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server" enableviewstate="false">
    <asp:Literal runat="server" ID="ltlTags" EnableViewState="false" />
</head>
<body>
    <form id="form1" runat="server">

        User list:
        <asp:TextBox ID="txtOnlineUsers" runat="server"></asp:TextBox>
        <br />
        Name On witness statement
        <asp:TextBox ID="txtReportName" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Lookup" OnClick="btnSubmit_Click" />
        <br />
        
            User: 
            <asp:TextBox ID="txtResult" runat="server" EnableViewState="false"></asp:TextBox>
    </form>
</body>
</html>