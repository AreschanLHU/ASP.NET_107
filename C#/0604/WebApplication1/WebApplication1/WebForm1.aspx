<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ASP.NET網頁程式設計 期末考-1<br />
            班級:進四資網2A&nbsp; 學號:E1064181047&nbsp; 姓名:陳建宇<br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="後台" OnClick="Button2_Click" />
            <br />
            <br />
            項目&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="Price" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            數量&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem Value="4"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="OK" />
            <asp:Label ID="Label1" runat="server" Text="0" Visible="False"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Height="73px" TextMode="MultiLine" Width="176px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="計算總金額" />
            <asp:Label ID="Label2" runat="server" Text="0" Visible="False"></asp:Label>
            <br />
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DB3ConnectionString3 %>" SelectCommand="SELECT * FROM [TTT]" OnSelecting="SqlDataSource1_Selecting"></asp:SqlDataSource>
    </form>
</body>
</html>
