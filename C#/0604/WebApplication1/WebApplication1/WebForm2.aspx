<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ASP.NET網頁程式設計 期末考-2<br />
            班級:進四資網2A&nbsp; 學號:E1064181047&nbsp; 姓名:陳建宇<br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="前台" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="後台" />
            <br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Height="73px" TextMode="MultiLine" Width="176px"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="總金額:"></asp:Label>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
