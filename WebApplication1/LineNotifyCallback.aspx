﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LineNotifyCallback.aspx.cs" Inherits="WebApplication1.LineNotifyCallback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="LineNotifyCallBackButton" OnClick="Button1_Click" />
    </div>
    <div>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" Text="SendMessage" OnClick="Button2_Click" />
    </div>
    </form>
</body>
</html>
