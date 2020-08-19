<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="sanphamloadcontrol.ascx.cs" Inherits="WebsiteDongHo.cms.admin.SanPham.sanphamloadcontrol" %>
<div class="container-1">
        <div class="left">
            <div class="tit">Quản Lý</div>
            
                <ul class="qlsp">
                    
                    <li><a href="admin.aspx?modul=SanPham&modulphu=ThuongHieu" class="ql">Thương Hiệu</a></li>
                    <li><a href="admin.aspx?modul=SanPham&modulphu=DanhSachSanPham" class="ql">Sản Phẩm</a></li>
                </ul>
            
        </div>
        <br />

        <div class="right">
            <asp:PlaceHolder ID="plsanphamloadcontrol" runat="server"></asp:PlaceHolder>
        </div>
    </div>