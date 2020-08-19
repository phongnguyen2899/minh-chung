<%@ Page Title="" Language="C#" MasterPageFile="~/HeaderFooter.Master" AutoEventWireup="true" CodeBehind="danh_sach_dong_ho.aspx.cs" Inherits="WebsiteBanDongHo.danh_sach_dong_ho" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="CSS/san_pham.css" rel="stylesheet" />
    <link href="CSS/danh_sach_dong_ho.css" rel="stylesheet" />
			<div class="filter">
					<p>Thương hiệu</p>
					<ul>
						<li><input type="checkbox" id="casio"><label for="casio">Đồng hồ Casio</label></li>
						<li><input type="checkbox" id="citizen"><label for="citizen">Đồng hồ Citizen</label></li>
						<li><input type="checkbox" id="epos swiss"><label for="epos swiss">Đồng hồ Epos Swiss</label></li>
						<li><input type="checkbox" id="aries gold"><label for="aries gold">Đồng hồ Aries Gold</label></li>
						<li><input type="checkbox" id="ST"><label for="ST">Đồng hồ Stuhrling Tourbillon</label></li>
						<li><input type="checkbox" id="Q&Q"><label for="Q&Q">Đồng hồ Q&Q</label></li>
					</ul>
					<p>Khoảng giá</p>
					<ul>
						<li><input type="checkbox" id="0-1mil"><label for="0-1mil">Dưới 1 triệu</label></li>
						<li><input type="checkbox" id="1-5mil"><label for="1-5mil">Từ 1 - 5 triệu</label></li>
						<li><input type="checkbox" id="5-10mil"><label for="5-10mil">Từ 5 - 10 triệu</label></li>
						<li><input type="checkbox" id="10-20mil"><label for="10-20mil">Từ 10 - 20 triệu</label></li>
						<li><input type="checkbox" id="20-50mil"><label for="20-50mil">Từ 20 - 50 triệu</label></li>
						<li><input type="checkbox" id="greater50mil"><label for="greater50mil">Trên 50 triệu</label></li>
					</ul>
					<p>Loại dây</p>
					<ul>
						<li><input type="checkbox" id="dayda"><label for="dayda">Dây da</label></li>
						<li><input type="checkbox" id="daymavang"><label for="daymavang">Mạ vàng</label></li>
						<li><input type="checkbox" id="daymadong"><label for="daymadong">Mạ đồng</label></li>
						<li><input type="checkbox" id="dayhopkimthep"><label for="dayhopkimthep">Hợp kim thép</label></li>
					</ul>
					<p>Loại vỏ</p>
					<ul>
						<li><input type="checkbox" id="vomavang"><label for="vomavang">Mạ vàng</label></li>
						<li><input type="checkbox" id="vomadong"><label for="vomadong">Mạ đồng</label></li>
						<li><input type="checkbox" id="vohopkimthep"><label for="vohopkimthep">Hợp kim thép</label></li>
						<li><input type="checkbox" id="vangnguyenkhoi"><label for="vangnguyenkhoi">Vàng nguyên khối</label></li>
						<li><input type="checkbox" id="vonhua"><label for="vonhua">Vỏ nhựa</label></li>
					</ul>
					<p>Năng lượng</p>
					<ul>
						<li><input type="checkbox" id="donghoco"><label for="donghoco">Đồng hồ cơ</label></li>
						<li><input type="checkbox" id="donghodientu"><label for="donghodientu">Đồng hồ điện tử</label></li>
					</ul>
			</div>
			<div class="product_wrapper" runat="server" id="wrapper">
			
			</div>
			<div style="clear:both; border:0px;"></div> <!--Vì 2 thẻ div trên dùng float nên để cho bố cục trang về ban đầu thì phải clear float đi-->

</asp:Content>
