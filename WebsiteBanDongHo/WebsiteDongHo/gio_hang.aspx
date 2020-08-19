<%@ Page Title="" Language="C#" MasterPageFile="~/HeaderFooter.Master" AutoEventWireup="true" CodeBehind="gio_hang.aspx.cs" Inherits="WebsiteBanDongHo.gio_hang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="CSS/gio_hang.css" rel="stylesheet" />
    <script src="Javascript/gio_hang.js"></script>
				<form method="get" runat="server" id="cart_form" onsubmit="return kiemTraForm()">
					<div class="cart_product" >
						<p class="title">THÔNG TIN GIỎ HÀNG</p>
						<div class="header_rows">
							<label style="width: 320px; text-align:center;">SẢN PHẨM</label>
							<label style="width: 90px;">GIÁ</label>
							<label style="width: 110px;">SỐ LƯỢNG</label>
							<label style="width: 90px;">THÀNH TIỀN</label>
						</div>
						<div class="cart_row" runat="server" id="cartRowItem">
						</div>
						<div class="updateCart_totalPrice">
							<button type="submit" value="3" id="update_cart" name="update_cart" onclick="kiemTraBtnSubmit(3)">CẬP NHẬT GIỎ HÀNG</button>
                            <p>Số lượng: <span id="soluong1" runat="server">0</span></p>
							<p>Tổng tiền: <span id="price_number" runat="server">0 đ</span></p>
						</div>
						<a href="danh_sach_dong_ho.aspx" class="buy_more">MUA THÊM</a>
					</div>
					<div class="bill_info">
						<p class="title">THÔNG TIN ĐẶT HÀNG</p>
						<table>
							<tr>
								<td></td>
								<td>
									Lưu ý: Mục <span class="red">(*)</span> là bắt buộc phải ghi
								</td>
							</tr>
							<tr>
								<td>Họ và tên <span class="red">(*)</span>:</td>
								<td><input type="text" id="customer_name" name="customer_name"></td>
							</tr>
							<tr>
								<td>Điện thoại <span class="red">(*)</span>:</td>
								<td><input type="text" id="customer_phone" name="customer_phone"></td>
							</tr>
							<tr>
								<td>Địa chỉ <span class="red">(*)</span>:</td>
								<td><input type="text" id="customer_address" name="customer_address"></td>
							</tr>
							<tr>
								<td>Email:</td>
								<td><input type="text" id="customer_email" name="customer_email"></td>
							</tr>
							<tr>
								<td>Ghi chú:</td>
								<td><textarea name="customer_note"></textarea></td>
							</tr>
						</table>
						<button class="CODpayment" name="payment" value="1" type="submit" onclick="kiemTraBtnSubmit(1)">THANH TOÁN KHI NHẬN HÀNG</button>
						<button class="ONLpayment" name="payment" value="2" type="submit" onclick="kiemTraBtnSubmit(2)">THANH TOÁN ONLINE</button>
					</div>
				</form>
				<div style="clear:both; border:0px;"></div>

    
</asp:Content>
