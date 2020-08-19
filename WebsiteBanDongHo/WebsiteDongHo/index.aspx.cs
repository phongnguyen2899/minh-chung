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
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Title = "Trang chủ";
            int index = 0;
            DataTable tb=DataProvider.Instance.ExecuteQuery("select top 20 * from DongHo where kieuDang!=4 and kieuDang!=3 order by id desc"); //lấy random 15 đồng hồ
            string html = "";
            foreach (DataRow row in tb.Rows)  //lấy từng dòng dữ liệu của bảng DongHo rồi đưa vào chuỗi html
            {
                DongHo product = new DongHo(row);
                html += "<div class=\"product\">";
                html += "<a href = \"chi_tiet_san_pham.aspx?id=" + product.Id + "\" title=\"" + product.Ten + "\">";
                // html += "<img src=\"Images/" + product.TenAnh + ".jpg\">"; //tên file ảnh sẽ đặt theo ID

                html += "<img src=QuanTri/pic/sanpham/" + product.TenAnh + ">";
                html += "<p>" + product.Ten + "</p>";
                html += "<h6>" + String.Format("{0:0,0 đ}", product.DonGia) + "</h6>"; //lấy giá trị float từ csdl hiện lên web sẽ bị lỗi nên phải convert về decimal
                html += "</a>";
                html += "</div>";
                index++;
                if (index == 5)
                {
                    new_product_list.InnerHtml = html;
                }
            }
            hot_product_list.InnerHtml = html;
        }
    }
}