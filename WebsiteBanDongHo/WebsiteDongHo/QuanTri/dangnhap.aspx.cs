using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebsiteDongHo
{
    public partial class dangnhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            string tk = Request.Form.Get("tk");
            string mk = Request.Form.Get("mk");

            if (IsPostBack)
            {
                kiemtra(tk, mk);
            }
        }


        public void kiemtra(string tk, string mk)
        {

            DataTable dt = new DataTable();
            dt = WebsiteDongHo.tk.taikhoan_seach(tk, mk);
            if (dt.Rows.Count > 0)// xem có tồn tại tk, mk ko.
            {
                Session["username"] = tk;
                Response.Redirect("/QuanTri/admin.aspx");
            }
            else
            {
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>\n");
                System.Web.HttpContext.Current.Response.Write("alert(\"" + "Đăng nhập thất bại" + "\")\n");
                System.Web.HttpContext.Current.Response.Write("</SCRIPT>");
            }
        }
        
    }
}