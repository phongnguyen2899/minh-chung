<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ChiTietDonHang.ascx.cs" Inherits="WebsiteDongHo.cms.admin.DonHang.ChiTietDonHang" %>
<div class="head">
    Thông Tin Chi Tiết Đơn Đặt Hàng
</div>
<br />
<div class="bang-khach-hang">
    <table>
        <tr>
            <th>ID Đơn</th>
            <th>Tên Đồng Hồ</th>
            <th>Số Lượng</th>
            <th>Đơn Giá</th>
            <th>Thành Tiền</th>
        </tr>
        <tr>
            <asp:Literal ID="ltchitiet" runat="server"></asp:Literal>
        </tr>
    </table>
    <br />
    Tổng Tiền
    <label runat="server" id="tongtien"></label>
</div>