using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebsiteBanDongHo.Class;

namespace WebsiteBanDongHo
{
    public partial class chi_tiet_san_pham : System.Web.UI.Page
    {
		protected void Page_Load(object sender, EventArgs e)
		{
			var id = Request.QueryString.Get("id");
			DataTable tb;
			try //nếu url có giá trị id là số nguyên
			{
				string query = "select * from DongHo,ThuongHieu where DongHo.idthuongHieu=ThuongHieu.id and DongHo.id=" + id;
				tb = DataProvider.Instance.ExecuteQuery(query);
				Session["id"] = id;
			}
			catch //nếu url ko có id là số nguyên
			{
				string query="";
				if (Session["id"] == null)
					Response.Redirect("danh_sach_dong_ho.aspx?kieuDang=1");
				else
					query = "select * from DongHo,ThuongHieu where DongHo.idthuongHieu=ThuongHieu.id and DongHo.id=" + Session["id"];
				tb = DataProvider.Instance.ExecuteQuery(query);
			}
			DongHo product = new DongHo(tb.Rows[0]); //đưa dữ liệu lên màn hình
			mainIMG.Src = "QuanTri/pic/sanpham/" + product.TenAnh + "";
            Title = product.Ten;
			product_name_asp.InnerHtml = product.Ten.ToUpper();
			price_asp.InnerHtml = String.Format("{0:0,0 đ}", product.DonGia);
			row_chatLieuDay.InnerHtml = product.ChatLieuDay;
			row_nangLuong.InnerHtml = product.NangLuong;
			row_chatLieuMat.InnerHtml = product.ChatLieuMat;
			row_chongNuoc.InnerHtml = product.ChongNuoc;
			row_thuongHieu.InnerHtml = tb.Rows[0]["tenthuongHieu"].ToString();
			row_xuatXu.InnerHtml = product.XuatXu;
			row_duongKinhMat.InnerHtml = product.DuongKinhMat;
			addtocart.HRef = "chi_tiet_san_pham.aspx?id=" + product.Id + "&action=add";
			buynow.HRef = "chi_tiet_san_pham.aspx?id=" + product.Id + "&action=add&redirect=true";
			switch (product.KieuDang)
			{
				case 1: row_kieuDang.InnerHtml = "Đồng hồ nam"; break;
				case 2: row_kieuDang.InnerHtml = "Đồng hồ nữ"; break;
				case 3: row_kieuDang.InnerHtml = "Đồng hồ đôi"; break;
				default: row_kieuDang.InnerHtml=""; break;
			}
			if (Session["id"] != null && Request.QueryString.Get("action") == "add") //nếu có thêm giá trị add trên url
			{
				/*List<CartItem> cart = new List<CartItem>();
				if (Session["cart"] == null) //Tạo giỏ hàng mới nếu ko có giỏ hàng
				{
					Session["cart"] = cart;
				}
				else
				{
					cart = Session["cart"] as List<CartItem>;
				}
				CartItem f = new CartItem();
				Boolean isExist = false;
				foreach (CartItem item in cart) //Kiểm tra xem đã tồn tại sản phẩm đó chưa
				{
					if (item.IdDongHo == product.Id)
					{
						item.SoLuong++;
						isExist = true;
						break;
					}
				}
				if (!isExist)
				{
					f.IdDongHo = product.Id;
					f.Ten = product.Ten;
					f.TenAnh = product.TenAnh;
					f.DonGia = product.DonGia;
					f.SoLuong = 1;
					cart.Add(f);
				}
				Session["cart"] = cart; //Lưu lại giỏ hàng
				if(Request.QueryString.Get("redirect") == "true")
				{
					Response.Redirect("gio_hang.aspx");
				}else
					Response.Redirect("chi_tiet_san_pham.aspx?id=" + product.Id);*/

				//ktra sản phẩm mới thêm có tồn tại trong cart ko
				int idCart;
				if (Request.Cookies["idCart"] == null) //Nếu chưa tạo giỏ hàng (id giỏ hàng chưa lưu vào cookie)
				{
					Random r = new Random();
					idCart = r.Next(0, 10000);//tạo một id bất kỳ cho cart
					while (true) //ktra xem id vừa tạo có trùng trong cart ko
					{
						DataTable table = DataProvider.Instance.ExecuteQuery("select * from Cart where id=" + idCart);
						if (table.Rows.Count > 0)
							idCart = r.Next(0, 10000);
						else
							break;
					}
					//Lưu id cart vào cookie
					Response.Cookies["idCart"].Value = idCart.ToString();
					Response.Cookies["idCart"].Expires = DateTime.Now.AddDays(2);//lưu cookie trong 2 ngày
					DataProvider.Instance.ExecuteNonQuery("exec insertCart @id  ", new object[] { idCart });
				}
				else
				{
					idCart = int.Parse(Request.Cookies["idCart"].Value);
				}
				int j = DataProvider.Instance.ExecuteNonQuery("exec insertCartDetail @idCart , @idDongHo , @soLuong  ", new object[] { idCart, product.Id,1 });
				//DataTable t = DataProvider.Instance.ExecuteQuery("select * from CartDetail where idDongHo=" + product.Id + " and id=" + idCart);
				if (Request.QueryString.Get("redirect") == "true")
					Response.Redirect("gio_hang.aspx");
				else
					Response.Redirect("chi_tiet_san_pham.aspx?id=" + product.Id);
			}
		}
	}
}