<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="donhangloadcontrol.ascx.cs" Inherits="WebsiteDongHo.cms.admin.DonHang.donhangloadcontrol" %>
<div class="head">
    Danh sách Đơn Đặt Hàng
</div>
<div class="nutthemmoi">
    <a href="admin.aspx?modul=DonHang&danhsach=chuaxuly" >Chưa Xử Lý</a>
</div>
    <table class="bang-khach-hang">
        <tr>
            <th>ID Hóa Đơn</th>
            <th>Ngày Lập</th>
            <th>Id Khách Hàng</th>
            <th>Ghi Chú</th>
            <th>Kiểu Thanh Toán</th>
            <th>Thao Tác</th>
        </tr>

        <tr>
            <asp:Literal ID="ltdonhang" runat="server"></asp:Literal>
        </tr>
    </table>
<script>
    var listtt = document.getElementsByClassName('tinhtrang');
    var list = document.getElementsByClassName('xuly');
    for (var i = 0; i < listtt.length; i++)
    {
        if (listtt[i].innerHTML == 'Đã Xử Lý') {
            // listtt[i].style.background = "red";
            list[i].style.background = "#FA8072";


        }
    }

</script>
