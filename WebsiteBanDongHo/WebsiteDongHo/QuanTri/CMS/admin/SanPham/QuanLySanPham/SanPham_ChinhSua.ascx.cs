using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebsiteDongHo.cms.admin.SanPham.QuanLySanPham
{
    public partial class SanPham_ChinhSua : System.Web.UI.UserControl
    {
        string id = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
                id = Request.QueryString["id"];

            laydanhmucchacs();
            hienthithongtin();
        }

        public void laydanhmucchacs()
        {
            DataTable dt = new DataTable();
            dt = WebsiteDongHo.thuonghieu.Thongtin_thuonghieu();
            DropDownList1cs.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DropDownList1cs.Items.Add(new ListItem(dt.Rows[i]["tenThuongHieu"].ToString()));
            }
        }
        public void hienthithongtin()
        {
            DataTable dt1 = new DataTable();
            dt1 = WebsiteDongHo.sanpham.Dongho_select_byid(id);
            tencs.Value = dt1.Rows[0]["ten"].ToString();

            dongiacs.Value = dt1.Rows[0]["dongia"].ToString();
            xuatxucs.Value = dt1.Rows[0]["xuatXu"].ToString();

            kieudangcs.Value = dt1.Rows[0]["kieuDang"].ToString();
            nangluongcs.Value = dt1.Rows[0]["nangLuong"].ToString();
            chongnuoccs.Value = dt1.Rows[0]["chongNuoc"].ToString();
            chatlieumatcs.Value = dt1.Rows[0]["chatLieuMat"].ToString();
            chatlieudaycs.Value = dt1.Rows[0]["chatLieuDay"].ToString();
            duongkinhmatcs.Value = dt1.Rows[0]["duongKinhMat"].ToString();
            //duo.Value = dt.Rows[0]["dongia"].ToString();

            DropDownList1cs.SelectedValue = dt1.Rows[0]["tenThuongHieu"].ToString();
        }

        protected void Button1cs_Click(object sender, EventArgs e)
        {
            WebsiteDongHo.sanpham.DongHo_update(id, tencs.Value, FileUpload1cs.FileName, dongiacs.Value, xuatxucs.Value, DropDownList1cs.SelectedValue, kieudangcs.Value, nangluongcs.Value, chongnuoccs.Value, chatlieumatcs.Value, duongkinhmatcs.Value, chatlieudaycs.Value);
            Response.Redirect("/admin.aspx?modul=SanPham&modulphu=DanhSachSanPham");
        }
    }
}