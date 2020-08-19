using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebsiteDongHo.cms.admin.SanPham.QuanLySanPham
{
    public partial class SanPham_HienThi : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                laydulieu();
            }
        }
        public void laydulieu()
        {
            DataTable dt = new DataTable();
            dt = WebsiteDongHo.sanpham.thongtin_sanpham();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Literal1.Text += @"<tr>
            <td>" + dt.Rows[i]["id"] + @"</td>
            <td>" + dt.Rows[i]["ten"] + @"</td>
            <td><img src='/QuanTri/pic/sanpham/" + dt.Rows[i]["tenanh"] + @"' class='imgsp'/></td>
            <td>" + dt.Rows[i]["donGia"] + @"</td>
            <td>" + dt.Rows[i]["xuatXu"] + @"</td>
            <td>" + dt.Rows[i]["idthuongHieu"] + @"</td>
            <td>" + dt.Rows[i]["kieuDang"] + @"</td>
            <td class='congcu'>
                <a href='admin.aspx?modul=SanPham&modulphu=DanhSachSanPham&thaotac=chinhsua&id=" + dt.Rows[i]["id"] + @"' class='them'></a>
                <a href='admin.aspx?modul=SanPham&modulphu=DanhSachSanPham&thaotac=xoasanpham&id=" + dt.Rows[i]["id"] + @"' class=them1></a>
            </td>

        </tr>";
            }
        }
    }
}