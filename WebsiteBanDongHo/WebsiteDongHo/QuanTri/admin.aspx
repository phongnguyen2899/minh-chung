<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="WebsiteDongHo.admin" %>

<%@ Register Src="~/QuanTri/CMS/admin/adminloadcontrol.ascx" TagPrefix="uc2" TagName="adminloadcontrol" %>




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="cms/admin/css/admin.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%--Header--%>
            <div id="header">
                <div class="container">
                    <div class="logo">
                        <a>
                            <img src="pic/Logo.jpg" /></a>
                        <div style="float: right; margin-right: 10px">
                            Xin Chào 
                            <label runat="server" id="tennguoidung"></label>
                            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
                            <br />
                            <br /> Online
                            <div id="online" runat="server" style="float:right"></div>
                        </div>
                    </div>
                    <div class="accountMenu">
                    </div>
                </div>
            </div>

            <%--MenuChinh--%>
            <div class="MenuChinh">
                <div class="container">
                    <ul>
                        <li><a href="admin.aspx?modul=SanPham">Sản phẩm</a></li>
                        <li><a href="admin.aspx?modul=KhachHang">Khách Hàng</a></li>
                        <li><a href="admin.aspx?modul=DonHang">Đơn Đặt Hàng</a></li>
                    </ul>
                </div>
            </div>

            <%--Nội dung trang--%>
            <div class="content">
                <uc2:adminloadcontrol runat="server" ID="adminloadcontrol1" />
            </div>

        </div>
    </form>
    
    
</body>
    
</html>
