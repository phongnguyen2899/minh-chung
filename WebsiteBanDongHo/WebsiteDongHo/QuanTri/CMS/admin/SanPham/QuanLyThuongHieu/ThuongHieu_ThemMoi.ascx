<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ThuongHieu_ThemMoi.ascx.cs" Inherits="WebsiteDongHo.cms.admin.SanPham.QuanLyThuongHieu.ThuongHieu_ThemMoi" %>
<div class="head">Thêm mới thương hiệu</div>
<br />
<div class="them-thuong-hieu">
        <div style="display:inline-block">Tên Thương Hiệu</div>
        
        <input type="text" runat="server" id="tenthuonghieu" style="display:inline-block"/>
     <br />
     <br />
    <asp:Button ID="Button1" runat="server" Text="Thêm Mới" OnClick="Button1_Click" OnClientClick="if (them()) { return false; }" />
    <!--nếu có sự kiện thêm trả về false-->
    <br />
</div>
<script>
    function them() {
        var fc = document.getElementById("adminloadcontrol1_ctl00_ctl01_tenthuonghieu");
        if (fc.value == "") {
            alert("Bạn cần điền đầy đủ thông tin");
            fc.focus
            return true;
        }
    }
</script>