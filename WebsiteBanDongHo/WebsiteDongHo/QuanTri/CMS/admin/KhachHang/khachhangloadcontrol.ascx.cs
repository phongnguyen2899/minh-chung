using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebsiteDongHo.cms.admin.KhachHang
{
    public partial class khachhangloadcontrol : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            laythongtinkh();
        }

        public void laythongtinkh()
        {
            DataTable dt = new DataTable();
            dt = WebsiteDongHo.khachhang.Thongtin_khachhang();
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                ltkhachhang.Text += @"<tr>
            <td>" + dt.Rows[i]["id"] + @"</td>
            <td>" + dt.Rows[i]["hoTen"] + @"</td>
            <td>" + dt.Rows[i]["sdt"] + @"</td>
            <td>" + dt.Rows[i]["email"] + @"</td>
            <td>" + dt.Rows[i]["diaChi"] + @"</td>
               </tr>";
            }
        }
    }
}