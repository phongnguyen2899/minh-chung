<%@ Page Title="" Language="C#" MasterPageFile="~/HeaderFooter.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebsiteBanDongHo.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="CSS/index.css" rel="stylesheet" />
    <link href="CSS/san_pham.css" rel="stylesheet" />
		<img class="bannerImage" src="Images/banner1.jpg">
			<p>THƯƠNG HIỆU NỔI TIẾNG</p>
			<div class="brand">
					<a href="#"><img src="Images/Casio.jpg" alt="Thương hiệu" class="brandlogo"></a>
					<a href="#"><img src="Images/DWellington.jpg" alt="Thương hiệu" class="brandlogo"></a>
					<a href="#"><img src="Images/Longines.jpg" alt="Thương hiệu" class="brandlogo"></a>
					<a href="#"><img src="Images/Orient.jpg" alt="Thương hiệu" class="brandlogo"></a>
					<a href="#"><img src="Images/MichealKors.jpg" alt="Thương hiệu" class="brandlogo"></a>
					<a href="#"><img src="Images/Citizen.jpg" alt="Thương hiệu" class="brandlogo"></a>
					<a href="#"><img src="Images/Gshock.jpg" alt="Thương hiệu" class="brandlogo"></a>
					<a href="#"><img src="Images/CalvinKlein.jpg" alt="Thương hiệu" class="brandlogo"></a>
					<a href="#"><img src="Images/Seiko.jpg" alt="Thương hiệu" class="brandlogo"></a>
					<a href="#"><img src="Images/Cadino.jpg" alt="Thương hiệu" class="brandlogo"></a>
					<a href="#"><img src="Images/Doxa.jpg" alt="Thương hiệu" class="brandlogo"></a>
					<a href="#"><img src="Images/Rotary.jpg" alt="Thương hiệu" class="brandlogo"></a>
					<a href="#"><img src="Images/Tissot.jpg" alt="Thương hiệu" class="brandlogo"></a>
					<a href="#"><img src="Images/OP.jpg" alt="Thương hiệu" class="brandlogo"></a>
					<a href="#"><img src="Images/Skagen.jpg" alt="Thương hiệu" class="brandlogo"></a>
			</div>
			<p>SẢN PHẨM MỚI RA</p>
			<div class="productlist" runat="server" id="new_product_list">
						<div class="product">
							<a href="#">
								<img src="Images/2.jpg">
								<p>Đồng hồ Jacques Lemans JL-42-6D</p>
								<h6>5.776.000 đ</h6>
							</a>
						</div>
						<div class="product">
							<a href="#">
								<img src="Images/1.jpg">
								<p>Đồng hồ Aries Gold AG-U7010 Z-BU</p>
								<h6>1.480.000 đ</h6>
							</a>
						</div>
						<div class="product">
							<a href="#">
								<img src="Images/3.jpg">
								<p>Đồng hồ Philippe Auguste PA5004B</p>
								<h6>8.805.000 đ</h6>
							</a>
						</div>
						<div class="product">
							<a href="#">
								<img src="Images/4.jpg">
								<p>Đồng hồ Stuhrling Original Tourbillon 213T.333X2</p>
								<h6>204.000.000 đ</h6>
							</a>
						</div>
						<div class="product">
							<a href="#">
								<img src="Images/5.jpg">
								<p>Đồng hồ Aries Gold AG-G9005G RG-S</p>
								<h6>9.218.000 đ</h6>
							</a>
						</div>
			</div>
			<p>SẢN PHẨM NỔI BẬT</p>
			<div class="productlist" runat="server" id="hot_product_list">
						<div class="product">
							<a href="#">
								<img src="Images/6.jpg">
								<p>Đồng hồ Aries Gold AG-G7016 S-BU</p>
								<h6>5.000.000 đ</h6>
							</a>
						</div>
						<div class="product">
							<a href="#">
								<img src="Images/7.jpg">
								<p>Đồng hồ Jacques Lemans JL-42-6B</p>
								<h6>4.616.000 đ</h6>
							</a>
						</div>
						<div class="product">
							<a href="#">
								<img src="Images/8.jpg">
								<p>Đồng hồ Epos Swiss E-3435.313.22.18.25</p>
								<h6>46.000.000 đ</h6>
							</a>
						</div>
						<div class="product">
							<a href="#">
								<img src="Images/5.jpg">
								<p>Đồng hồ Epos Swiss E-3390.156.22.25.32</p>
								<h6>45.120.000 đ</h6>
							</a>
						</div>
						<div class="product">
							<a href="#">
								<img src="Images/10.jpg">
								<p>Đồng hồ Diamond D DM6305B5</p>
								<h6>3.080.000 đ</h6>
							</a>
						</div>
			</div>
</asp:Content>
