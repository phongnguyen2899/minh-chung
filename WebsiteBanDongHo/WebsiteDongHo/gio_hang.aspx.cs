using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebsiteBanDongHo.Class;

namespace WebsiteBanDongHo
{
    public partial class gio_hang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetNoStore();
            Title = "Giỏ hàng";
            if (Request.Cookies["idCart"] != null)
            {
                //List<CartItem> cart = Session["cart"] as List<CartItem>;
                string idCart = Request.Cookies["idCart"].Value;
                //xóa sản phẩm trong giỏ hàng
                if (Request.QueryString.Get("id") != null && Request.QueryString.Get("action") == "delete") 
                {
                    /*foreach (CartItem item in cart)
                    {
                        if (item.IdDongHo == int.Parse(Request.QueryString.Get("id")))
                        {
                            cart.Remove(item);
                            Session["cart"] = cart;
                            Response.Redirect("gio_hang.aspx");
                        }
                    }*/
                    DataProvider.Instance.ExecuteNonQuery("exec deleteCartDetail @idCart , @idDongHo",new object[] { idCart,Request.QueryString.Get("id") });
                }
                DataTable t = DataProvider.Instance.ExecuteQuery("select * from CartDetail where idCart=" + idCart);
                if (t.Rows.Count == 0) //Nếu vừa xóa sản phẩm xong giỏ hàng rỗng
                {
                    string html = "<p style=\"font-size:16pt; margin:0;padding:60px; text-align:center;\">Giỏ hàng của bạn rỗng</p>";
                    html += "<a href=\"danh_sach_dong_ho.aspx?kieuDang=1\" class=\"buy_more\">MUA NGAY</a>";
                    cart_form.InnerHtml = html;
                }else //đọc giỏ hàng
                {
                    t = DataProvider.Instance.ExecuteQuery("exec procInfoCart @idCart="+idCart);
                    string html = "";
                    float tongTien = 0;
                    float soluong =0;
                    foreach (DataRow r in t.Rows)
                    {
                        html += "<div class=\"rows\">";
                        html += "	<img src=QuanTri/pic/sanpham/" + r["tenAnh"] + ">";
                        html += "	<a class=\"name\" href=\"chi_tiet_san_pham.aspx?id=" + r["idDongHo"] + "\">" + r["ten"] + "</a>";
                        html += "	<label class=\"price\">" + String.Format("{0:0,0 đ}", r["donGia"]) + "</label>";
						html += "   <input type=\"number\" min=\"1\" max=\"99\" value=\""+ r["soLuong"] + "\" id=\"quantity_"+ r["idDongHo"] + "\" name=\"quantity_"+ r["idDongHo"] + "\" runat=\"server\" class=\"quantity\"/>";
                        html += "	<label  class=\"totalPrice\">" + String.Format("{0:0,0 đ}", (int)r["soLuong"] * float.Parse(r["donGia"].ToString())) + "</label>";
                        html += "	<a href=\"gio_hang.aspx?id=" + r["idDongHo"] + "&action=delete\" class=\"remove\" onclick=\"return xacNhanXoa()\"><i class=\"fas fa-trash\"></i></a>";
                        html += "</div>";
                        tongTien += (int)r["soLuong"] * float.Parse(r["donGia"].ToString());
                        soluong += (int)r["soLuong"];
                        //soluong+=()
                    }
                    cartRowItem.Controls.Add(new Literal() { Text = html });
                    price_number.InnerHtml = String.Format("{0:0,0 đ}", tongTien);
                    soluong1.InnerHtml = soluong.ToString();
                }
                if (IsPostBack) //khi ng dùng bấm nút cập nhật giỏ hàng, thanh toán
                {
                    if (Request.QueryString.Get("update_cart") != null) //nếu bấm nút CẬP NHẬT GIỎ HÀNG
                    {
                        //cart = Session["cart"] as List<CartItem>;
                        foreach (DataRow row in t.Rows)
                        {
                            //item.SoLuong = int.Parse(Request.QueryString.Get("quantity_" + item.IdDongHo));
                            DataProvider.Instance.ExecuteNonQuery("exec updateCartDetail @idCart , @idDongHo , @soLuong",new object[] { idCart, row["idDongHo"], Request.QueryString.Get("quantity_" + row["idDongHo"]) });
                        }
                        Response.Redirect("gio_hang.aspx");
                    }
                    else //if(Request.QueryString.Get("payment")=="1") //Nếu bấm nút thanh toán
                    {
                        var hoten = Request.QueryString.Get("customer_name");
                        var sdt = Request.QueryString.Get("customer_phone");
                        var diaChi = Request.QueryString.Get("customer_address");
                        var email = Request.QueryString.Get("customer_email");
                        var ghiChu= Request.QueryString.Get("customer_note");
                        DataProvider.Instance.ExecuteNonQuery("exec insertKhachHang @hoten , @sdt , @email , @diaChi", new object[] { hoten, sdt, email, diaChi }); //thêm khách hàng
                        DataProvider.Instance.ExecuteNonQuery("exec insertDonDatHang @ghiChu , @kieuThanhToan ", new object[] { ghiChu, Request.QueryString.Get("payment") });

                        //string idCart = Request.Cookies["idCart"].Value;
                        t = DataProvider.Instance.ExecuteQuery("select * from CartDetail where idCart=" + idCart);
                        foreach(DataRow item in t.Rows)
                        {
                            DataProvider.Instance.ExecuteNonQuery("exec insertChiTietDonDat @idDH , @soLuong",new object[] {item["idDongHo"],item["soLuong"] });
                        }
                        //Session["cart"] = null; //Đặt hàng xong giải phóng session
                        Response.Cookies["idCart"].Expires = DateTime.Now.AddDays(-1);//Giải phóng cookie
                        DataProvider.Instance.ExecuteNonQuery("exec deleteCart @idCart", new object[] { idCart });//xóa giỏ hàng
                        Response.Redirect("gio_hang.aspx");
                    }
                }
            }
            else //nếu cookie giỏ hàng = null
            {
                string html= "<p style=\"font-size:18pt; margin:0;padding-top:60px;padding-bottom:40px; text-align:center;\">Giỏ hàng của bạn rỗng</p>";
                html += "<a href=\"danh_sach_dong_ho.aspx?kieuDang=1\" class=\"buy_more\">MUA NGAY</a>";
                cart_form.InnerHtml = html;
            }
        }
    }
}