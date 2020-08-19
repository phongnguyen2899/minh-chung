using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebsiteDongHo.cms.admin.SanPham.QuanLySanPham
{
    public partial class SanPham_ThemMoi : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // ko đc dùng ispostback;
            laydanhmuccha();


        }

        public void laydanhmuccha()
        {
            DataTable dt = new DataTable();
            dt = WebsiteDongHo.thuonghieu.Thongtin_thuonghieu();
            DropDownList1.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DropDownList1.Items.Add(new ListItem(dt.Rows[i]["tenThuongHieu"].ToString()));
            }
        }




        protected void Button1_Click(object sender, EventArgs e)
        {
            string ten = Request.Form.Get("ten");


            if (FileUpload1.FileName.EndsWith(".jpeg") || FileUpload1.FileName.EndsWith(".jpg") ||
                         FileUpload1.FileName.EndsWith(".png") || FileUpload1.FileName.EndsWith(".gif"))
            {
                FileUpload1.SaveAs(Server.MapPath("pic/sanpham/") + FileUpload1.FileName);
            }
            string dongia = Request.Form.Get("dongia");
            string xuatxu = bochon.Value;
            string kieudang = Request.Form.Get("kieudang");
            string nangluong = Request.Form.Get("nangluong");
            string chongnuoc = Request.Form.Get("chongnuoc");
            string chatlieumat = Request.Form.Get("chatlieumat");
            string chatlieuday = Request.Form.Get("chatlieuday");
            //string thuonghieu = Request.Form.Get("slthuonghieu");
            string tenthuonghieu = DropDownList1.SelectedValue;
            string duongkinhmat = Request.Form.Get("duongkinhmat");
            // Response.Write(tenthuonghieu);


            WebsiteDongHo.sanpham.DongHo_Inser(ten, FileUpload1.FileName, dongia, xuatxu, tenthuonghieu, kieudang, nangluong, chongnuoc, chatlieumat, duongkinhmat, chatlieuday);

        }
    }
}