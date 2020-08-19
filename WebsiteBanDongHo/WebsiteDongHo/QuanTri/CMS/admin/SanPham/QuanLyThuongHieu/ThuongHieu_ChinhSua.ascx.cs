using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebsiteDongHo.cms.admin.SanPham.QuanLyThuongHieu
{
    public partial class ThuongHieu_ChinhSua : System.Web.UI.UserControl
    {
        string id = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
                id = Request.QueryString["id"];
            load();
        }


        private void load()
        {
            DataTable dt = new DataTable();
            dt = WebsiteDongHo.thuonghieu.ThuongHieu_selectbyID(id);
            tenthuonghieucs.Value = dt.Rows[0]["tenThuongHieu"].ToString();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            WebsiteDongHo.thuonghieu.ThuongHieu_update(id, tenthuonghieucs.Value);
            Response.Redirect("/admin.aspx?modul=SanPham&modulphu=ThuongHieu");
        }
    }
}