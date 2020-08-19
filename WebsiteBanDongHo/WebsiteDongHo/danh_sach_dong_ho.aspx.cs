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
    public partial class danh_sach_dong_ho : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var kieuDang = Request.QueryString.Get("kieuDang");
            DataTable tb;
            try
            {
                    tb = DataProvider.Instance.ExecuteQuery("select * from DongHo where kieuDang=" + kieuDang + " order by id desc");
                    Session["kieuDang"] = kieuDang;
            }
            catch
            {
                if (Session["kieuDang"] == null)
                {
                    tb = DataProvider.Instance.ExecuteQuery("select * from DongHo where kieuDang=1 order by id desc");
                    Session["kieuDang"] = 1;
                }
                else
                    tb = DataProvider.Instance.ExecuteQuery("select * from DongHo where kieuDang=" + Session["kieuDang"] + " order by id desc");
            }
            if (int.Parse(Session["kieuDang"].ToString()) == 1)
                Title = "Đồng hồ nam";
            else if (int.Parse(Session["kieuDang"].ToString()) == 2)
                Title = "Đồng hồ nữ";
            else if (int.Parse(Session["kieuDang"].ToString()) == 3)
                Title = "Đồng hồ đôi";
            else
                Title = "Phụ kiện";
            string html = "";
            foreach (DataRow row in tb.Rows)  //lấy từng dòng dữ liệu của bảng DongHo rồi đưa vào chuỗi html
            {
                DongHo product = new DongHo(row);
                html += "<div class=\"product\">";
                html += "<a href = \"chi_tiet_san_pham.aspx?id=" + product.Id + "\" title=\""+product.Ten+"\">";
                //html += "<img src=\"Images/" + product.TenAnh + ".jpg\">"; //tên file ảnh sẽ đặt theo ID
                html += "<img src=QuanTri/pic/sanpham/" + product.TenAnh + ">";
                html += "<p>" + product.Ten + "</p>";

                html += "<h6>" + String.Format("{0:0,0 đ}",product.DonGia) + "</h6>"; //lấy giá trị float từ csdl hiện lên web sẽ bị lỗi nên phải convert về decimal
                html += "</a>";
                html += "</div>";
            }
            // wrapper.Controls.Add(new Literal() { Text = html });//đưa câu html trên vào trong thẻ div có id là wrapper
            wrapper.InnerHtml = html;

        }
    }
}