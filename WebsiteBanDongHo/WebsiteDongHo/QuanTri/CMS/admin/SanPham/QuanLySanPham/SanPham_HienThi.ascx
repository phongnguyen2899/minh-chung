<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SanPham_HienThi.ascx.cs" Inherits="WebsiteDongHo.cms.admin.SanPham.QuanLySanPham.SanPham_HienThi" %>

<div class="head">
    Danh sách sản phẩm 
</div>
<div class="ds-sp">
    <div class="nutthemmoi">
    <a href="admin.aspx?modul=SanPham&modulphu=DanhSachSanPham&thaotac=ThemMoi" class="nutthemmoi">Thêm Mới</a>
    </div>

    <div class="bang-san-pham">
    
        <table>
            <tr>
                <th>ID</th>
                <th>Tên</th>
                <th>Ảnh</th>
                <th>Đơn giá</th>
                <th>Xuất xứ</th>
                <th>Thương Hiệu</th>
                <th>Kiểu dáng</th>
                <th>Thao tác</th>
            </tr>

            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        </table>
    </div>
</div>