using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebsiteBanDongHo.Class;

namespace WebsiteDongHo
{
    public partial class timkiem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var text_seach = Request.Form["searchbox"].ToString();
            DataTable dt = new DataTable();
            dt = WebsiteBanDongHo.Class.DataProvider.Instance.ExecuteQuery("select * from DongHo where ten like N'%"+text_seach+"%'");
            string html = "";
            foreach (DataRow row in dt.Rows)  //lấy từng dòng dữ liệu của bảng DongHo rồi đưa vào chuỗi html
            {
                DongHo product = new DongHo(row);
                html += "<div class=\"product\">";
                html += "<a href = \"chi_tiet_san_pham.aspx?id=" + product.Id + "\" title=\"" + product.Ten + "\">";
                //html += "<img src=\"Images/" + product.TenAnh + ".jpg\">"; //tên file ảnh sẽ đặt theo ID
                html += "<img src=QuanTri/pic/sanpham/" + product.TenAnh + ">";
                html += "<p>" + product.Ten + "</p>";

                html += "<h6>" + String.Format("{0:0,0 đ}", product.DonGia) + "</h6>"; //lấy giá trị float từ csdl hiện lên web sẽ bị lỗi nên phải convert về decimal
                html += "</a>";
                html += "</div>";
            }
            // wrapper.Controls.Add(new Literal() { Text = html });//đưa câu html trên vào trong thẻ div có id là wrapper
            wrapper.InnerHtml = html;
        }
    }
}