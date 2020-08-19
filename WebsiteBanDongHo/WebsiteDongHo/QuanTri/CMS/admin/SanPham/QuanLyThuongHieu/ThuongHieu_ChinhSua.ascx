<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ThuongHieu_ChinhSua.ascx.cs" Inherits="WebsiteDongHo.cms.admin.SanPham.QuanLyThuongHieu.ThuongHieu_ChinhSua" %>
<div>
    <div class="tentruong">ID</div>
    <div>
        <input  type="text" runat="server" id="idthuonghieucs"/>
    </div>

    <div class="tentruong">Tên Thương Hiệu</div>
    <div>
        <input type="text" runat="server" id="tenthuonghieucs"/>
    </div>

    <asp:Button ID="Button1" runat="server" Text="Chỉnh Sửa" OnClick="Button1_Click"/>
    <!--nếu có sự kiện thêm trả về false-->
</div>
