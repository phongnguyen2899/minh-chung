using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebsiteDongHo
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            tennguoidung.InnerHtml = Session["username"].ToString();

            var x = Application["OnlineUsers"].ToString();
            online.InnerHtml = x;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["username"] = null;
            Response.Redirect("dangnhap.aspx");
        }
    }
}