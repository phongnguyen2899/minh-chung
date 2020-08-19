<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ThuongHieu_HienThi.ascx.cs" Inherits="WebsiteDongHo.cms.admin.SanPham.QuanLyThuongHieu.ThuongHieu_HienThi" %>
<div class="head">Danh Sách Thương Hiệu</div>
<div class="nutthemmoi">
<a href="admin.aspx?modul=SanPham&modulphu=ThuongHieu&thaotac=ThemMoi">Thêm Mới</a>
</div>
<div>
    
    

</div>
    <table class="bang-khach-hang">
        <tr>
            <th>Mã Thương hiệu</th>
            <th>Tên Thương Hiệu</th>
            <th>Thao Tác</th>
        </tr>
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
    </table>
