<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ASP.NET網頁程式設計 期末報告&lt;前台-2&gt;<br />
            班級：進四資網2A&nbsp; 學號：E1064181106&nbsp; 姓名：黃宇聖<br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="前台" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="後台" />
            <br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Height="73px" TextMode="MultiLine" Width="176px"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="總金額:"></asp:Label>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
