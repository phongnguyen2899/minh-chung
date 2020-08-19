<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dangnhap.aspx.cs" Inherits="WebsiteDongHo.dangnhap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="cms/admin/css/dangnhap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" method="post" class="form">
        <input type="text" name="tk" placeholder="Username"/>
        <input type="password" name="mk" placeholder="Password" />
        <br />
        <input type="submit" value="Đăng Nhập" class="button" />
        <a href="dangky.aspx" class="dangky">Đăng Ký</a>
    </form>
</body>
</html>
