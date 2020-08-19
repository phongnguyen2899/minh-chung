<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="khachhangloadcontrol.ascx.cs" Inherits="WebsiteDongHo.cms.admin.KhachHang.khachhangloadcontrol" %>
<div class="head">
    Danh sách khách hàng
</div>
<div>
    
</div>

    <table class="bang-khach-hang">
        <tr>
            <th>ID</th>
            <th>Họ Tên</th>
            <th>SDT</th>
            <th>Email</th>
            <th>Địa Chỉ</th>
        </tr>
        <tr>
        </tr>
        <asp:Literal ID="ltkhachhang" runat="server"></asp:Literal>
    </table>
<script>
    var chuoi = document.getElementById('txt_timkiem');
    var tableinfor = document.getElementsByClassName('bang-khach-hang')[0];

    loc(chuoi.value);
    function loc(filterstring)
    {
        var rows = document.querySelectorAll("tr");
        for(var i=0;i<rows.length;i++)
        {
            var item = rows[i].querySelector("td")[1];
            if(item.textContent.indexOf(filterstring)==-1)
            {
                rows[i].style.display = "none";
            } else {
                rows[i].style.display = "";
            }
            
        }

    }
</script>