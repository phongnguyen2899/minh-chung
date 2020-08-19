using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebsiteDongHo.cms.admin.DonHang
{
    public partial class donhangloadcontrol : System.Web.UI.UserControl
    {
        string danhsach = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["danhsach"] != null)
                danhsach = Request.QueryString["danhsach"];

            switch (danhsach)
            {
                case "chuaxuly":
                    hienthidonhang_chuaxl();
                    break;

                default:
                    hienthidonhang();
                    break;
            }

        }


        public void hienthidonhang()
        {
            string tt = "";
            DataTable dt = new DataTable();
            dt = WebsiteDongHo.donhang.Thongtin_donhang();
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                string trangthai = dt.Rows[i]["tinhTrang"].ToString();
                if (Int32.Parse(trangthai) == 1)
                {
                    tt = "Đã Xử Lý";
                }
                else
                {
                    tt = "Xử Lý";
                }
                ltdonhang.Text += @"<tr>
            <td>" + dt.Rows[i]["id"] + @"</td>
            <td>" + dt.Rows[i]["ngayLap"] + @"</td>
            <td>" + dt.Rows[i]["hoTen"] + @"</td>
            <td>" + dt.Rows[i]["ghiChu"] + @"</td>
            <td>" + dt.Rows[i]["kieuThanhToan"] + @"</td>
            
            <td class='xuly'  onload='loadcolor()'>
                <a href='admin.aspx?modul=DonHang&thaotac=capnhatdon&id=" + dt.Rows[i]["id"] + @"' class='tinhtrang'>" + tt + @"</a>
                <a href='admin.aspx?modul=DonHang&thaotac=xemchitiet&id=" + dt.Rows[i]["id"] + @"' class='chitiet'>Chi Tiết</a>
            </td>
        </tr>";
            }
        }


        public void hienthidonhang_chuaxl()
        {
            string tt = "";
            DataTable dt = new DataTable();
            dt = WebsiteDongHo.donhang.DonDatHang_selectchuaxl();
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                string trangthai = dt.Rows[i]["tinhTrang"].ToString();
                if (Int32.Parse(trangthai) == 1)
                {
                    tt = "Đã Xử Lý";
                }
                else
                {
                    tt = "Xử Lý";
                }
                ltdonhang.Text += @"<tr>
            <td>" + dt.Rows[i]["id"] + @"</td>
            <td>" + dt.Rows[i]["ngayLap"] + @"</td>
            <td>" + dt.Rows[i]["hoTen"] + @"</td>
            <td>" + dt.Rows[i]["ghiChu"] + @"</td>
            <td>" + dt.Rows[i]["kieuThanhToan"] + @"</td>
            
            <td class='xuly'  onload='loadcolor()'>
                <a href='admin.aspx?modul=DonHang&thaotac=capnhatdon&id=" + dt.Rows[i]["id"] + @"' class='tinhtrang'>" + tt + @"</a>
                <a href='admin.aspx?modul=DonHang&thaotac=xemchitiet&id=" + dt.Rows[i]["id"] + @"' class='tinhtrang'>Chi Tiết</a>
            </td>
        </tr>";
            }
        }
    }
}