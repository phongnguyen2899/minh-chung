using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebsiteDongHo
{
    public partial class dangky : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string tk = Request.Form.Get("tk");
            string mk = Request.Form.Get("mk");
            if (IsPostBack)
            {
                WebsiteDongHo.tk.taikhoan_insert(tk, mk);
                Response.Redirect("/QuanTri/dangnhap.aspx");

            }
        }
    }
}