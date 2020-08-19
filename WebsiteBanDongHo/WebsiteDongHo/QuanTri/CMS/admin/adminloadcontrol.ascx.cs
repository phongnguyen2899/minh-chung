using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebsiteDongHo.cms.admin
{
    public partial class adminloadcontrol : System.Web.UI.UserControl
    {
        private string modul = "";
        private string thaotac = "";   //do 
        private string id = "";         //    

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["modul"] != null)
                modul = Request.QueryString["modul"];

            if (Request.QueryString["thaotac"] != null)
                thaotac = Request.QueryString["thaotac"];

            if (Request.QueryString["id"] != null)
                id = Request.QueryString["id"];

            switch (modul)
            {
                case "SanPham":
                    pladminloadcontrol.Controls.Add(LoadControl("SanPham/sanphamloadcontrol.ascx"));
                    break;
                case "DonHang":
                    pladminloadcontrol.Controls.Add(LoadControl("DonHang/donhangloadcontrol.ascx"));
                    break;
                case "KhachHang":
                    pladminloadcontrol.Controls.Add(LoadControl("KhachHang/khachhangloadcontrol.ascx"));
                    break;
            }
            if (modul == "DonHang")
            {
                switch (thaotac)
                {
                    case "capnhatdon":
                        pladminloadcontrol.Controls.Clear();
                        donhangcapnhat();
                        Response.Redirect("/QuanTri/admin.aspx?modul=DonHang");
                        break;
                    case "xemchitiet":
                        pladminloadcontrol.Controls.Clear();
                        pladminloadcontrol.Controls.Add(LoadControl("DonHang/ChiTietDonHang.ascx"));
                        break;
                }
            }

            //pladminloadcontrol.Controls.Add(LoadControl("SanPham/sanphamloadcontrol.ascx"));
        }
        public void donhangcapnhat()
        {
            WebsiteDongHo.donhang.DonDatHang_update(id);
        }
    }
}