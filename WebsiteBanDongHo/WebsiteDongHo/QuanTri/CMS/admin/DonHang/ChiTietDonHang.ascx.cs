using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebsiteDongHo.cms.admin.DonHang
{
    public partial class ChiTietDonHang : System.Web.UI.UserControl
    {
        string id = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
                id = Request.QueryString["id"];

            chitietdathang();
        }

        public void chitietdathang()
        {
            DataTable dt = new DataTable();
            dt = WebsiteDongHo.chitietdonhang.Thongtin_chitietdondat(id);
            DataTable dt1 = new DataTable();
            dt1 = WebsiteDongHo.chitietdonhang.Tongtien(id);
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                ltchitiet.Text += @"<tr>
            <td>" + dt.Rows[i]["idDH"] + @"</td>
            <td>" + dt.Rows[i]["ten"] + @"</td>
            <td>" + dt.Rows[i]["soLuong"] + @"</td>
            <td>" + dt.Rows[i]["donGia"] + @"</td>
            <td>" + dt.Rows[i]["thanhtien"] + @"</td>
        </tr>";
            }
            tongtien.InnerHtml = dt1.Rows[0]["TongTien"].ToString();

        }
    }
}