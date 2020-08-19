using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebsiteDongHo.cms.admin.SanPham
{
    public partial class sanphamloadcontrol : System.Web.UI.UserControl
    {
        string modulphu = "";
        string thaotac = "";
        string id = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["modulphu"] != null)
                modulphu = Request.QueryString["modulphu"];

            if (Request.QueryString["thaotac"] != null)
                thaotac = Request.QueryString["thaotac"];
            //Response.Write(thaotac);

            switch (modulphu)
            {
                case "DanhMuc":
                    break;
                case "DanhSachSanPham":
                    plsanphamloadcontrol.Controls.Add(LoadControl("QuanLySanPham/SanPham_HienThi.ascx"));
                    break;
                case "ThuongHieu":
                    plsanphamloadcontrol.Controls.Add(LoadControl("QuanLyThuongHieu/ThuongHieu_HienThi.ascx"));
                    break;
                default:
                    plsanphamloadcontrol.Controls.Add(LoadControl("QuanLyThuongHieu/ThuongHieu_HienThi.ascx"));
                    break;
            }


            if (modulphu == "DanhSachSanPham")
            {
                switch (thaotac)
                {
                    case "ThemMoi":
                        plsanphamloadcontrol.Controls.Clear();
                        plsanphamloadcontrol.Controls.Add(LoadControl("QuanLySanPham/SanPham_ThemMoi.ascx"));
                        break;
                    case "xoasanpham":

                        plsanphamloadcontrol.Controls.Clear();
                        plsanphamloadcontrol.Controls.Add(LoadControl("QuanLySanPham/SanPham_HienThi.ascx"));
                        xoasanpham();
                        break;
                    case "chinhsua":
                        plsanphamloadcontrol.Controls.Clear();
                        plsanphamloadcontrol.Controls.Add(LoadControl("QuanLySanPham/SanPham_ChinhSua.ascx"));
                        break;

                }
            }
            else if (modulphu == "ThuongHieu")
            {
                switch (thaotac)
                {
                    case "ThemMoi":
                        plsanphamloadcontrol.Controls.Clear();
                        plsanphamloadcontrol.Controls.Add(LoadControl("QuanLyThuongHieu/ThuongHieu_ThemMoi.ascx"));
                        break;
                    case "xoathuonghieu":
                        plsanphamloadcontrol.Controls.Clear();
                        plsanphamloadcontrol.Controls.Add(LoadControl("QuanLyThuongHieu/ThuongHieu_HienThi.ascx"));
                        xoathuonghieu();
                        break;
                    case "chinhsua":
                        plsanphamloadcontrol.Controls.Clear();
                        plsanphamloadcontrol.Controls.Add(LoadControl("QuanLyThuongHieu/ThuongHieu_ChinhSua.ascx"));
                        break;

                }
            }
        }

        public void xoasanpham()
        {
            if (Request.QueryString["id"] != null)
                id = Request.QueryString["id"];
            WebsiteDongHo.sanpham.DongHo_delete(id);
        }

        public void xoathuonghieu()
        {
            if (Request.QueryString["id"] != null)
                id = Request.QueryString["id"];
            WebsiteDongHo.thuonghieu.ThuongHieu_delete(id);
            
        }
    }
}