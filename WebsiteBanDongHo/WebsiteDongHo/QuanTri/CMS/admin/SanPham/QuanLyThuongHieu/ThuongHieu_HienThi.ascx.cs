using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebsiteDongHo.cms.admin.SanPham.QuanLyThuongHieu
{
    public partial class ThuongHieu_HienThi : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            laydulieu();
        }
        public void laydulieu()
        {
            DataTable dt = new DataTable();
            dt = WebsiteDongHo.thuonghieu.Thongtin_thuonghieu();
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                Literal1.Text += @"<tr>
            <td>" + dt.Rows[i]["id"] + @"</td>
            <td>" + dt.Rows[i]["tenThuongHieu"] + @"</td>
            
            <td class='congcu'>
                <a href='admin.aspx?modul=SanPham&modulphu=ThuongHieu&thaotac=chinhsua&id=" + dt.Rows[i]["id"] + @"' class='them'></a>
                <a href='admin.aspx?modul=SanPham&modulphu=ThuongHieu&thaotac=xoathuonghieu&id=" + dt.Rows[i]["id"] + @"' class='them1'></a>
            </td>
            </tr>";
            }
        }

      
    }
}