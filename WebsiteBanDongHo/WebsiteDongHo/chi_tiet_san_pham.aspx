<%@ Page Title="" Language="C#" MasterPageFile="~/HeaderFooter.Master" AutoEventWireup="true" CodeBehind="chi_tiet_san_pham.aspx.cs" Inherits="WebsiteBanDongHo.chi_tiet_san_pham"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="CSS/chi_tiet_san_pham.css" rel="stylesheet" />
			<div class="image_detail">
				<div class="main_image_wrapper">
					<img src="Images/1.jpg" runat="server" id="mainIMG">
				</div>
				<!--ul class="sub_image">
					<li><a href="#"><img src="Images/1.jpg" alt="sub_image"></a></li>
					<li><a href="#"><img src="Images/2.jpg" alt="sub_image"></a></li>
					<li><a href="#"><img src="Images/3.jpg" alt="sub_image"></a></li>
					<li><a href="#"><img src="Images/4.jpg" alt="sub_image"></a></li>
				</!--ul-->
			</div>
			<div class="product_detail">
					<p style="text-align:center;" runat="server" id="product_name_asp">Đồng hồ ABCDEF</p>
					<hr style="margin-top:10px;"/>
					<p>Giá bán: <span class="price" runat="server" id="price_asp">69.000 đ</span></p>
					<p>Thông số kỹ thuật</p>
					<table class="detail" runat="server" id="table_detail">
						<tr>
							<td>Xuất xứ:</td>
							<td id="row_xuatXu" runat="server">Thụy Sĩ</td>
						</tr>
						<tr>
							<td>Thương hiệu:</td>
							<td id="row_thuongHieu" runat="server">Thụy Sĩ</td>
						</tr>
						<tr>
							<td>Kiểu dáng:</td>
							<td id="row_kieuDang" runat="server">Đồng hồ nam</td>
						</tr>
						<tr>
							<td>Năng lượng:</td>
							<td id="row_nangLuong" runat="server">Automatic (cơ tự động)</td>
						</tr>
						<tr>
							<td>Chống nước:</td>
							<td id="row_chongNuoc" runat="server">5 ATM</td>
						</tr>
						<tr>
							<td>Chất liệu mặt:</td>
							<td id="row_chatLieuMat" runat="server">Sapphire</td>
						</tr>
						<tr>
							<td>Đường kính mặt:</td>
							<td id="row_duongKinhMat" runat="server">43.5mm</td>
						</tr>
						<tr>
							<td>Chất liệu dây:</td>
							<td id="row_chatLieuDay" runat="server">Dây da</td>
						</tr>
					</table>
					<a class="add_to_cart_btn" title="Thêm vào giỏ hàng" id="addtocart" runat="server"><i class="fas fa-shopping-basket"></i>&emsp;THÊM VÀO GIỎ HÀNG</a>
					<a class="buy_now" title="Mua ngay" id="buynow" runat="server"><i class="fas fa-shopping-cart"></i>&emsp;MUA NGAY</a>
					<p style="text-align:center;">Hoặc đặt hàng trực tiếp <span class="phone_number">033-423-6169</span></p>
			</div>
			<div style="clear:both; border:0px;"></div> <!--Vì 2 thẻ div trên dùng float nên để cho bố cục trang về ban đầu thì phải clear float đi-->
</asp:Content>
