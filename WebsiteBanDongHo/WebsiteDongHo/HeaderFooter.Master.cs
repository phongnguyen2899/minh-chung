using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebsiteBanDongHo.Class;

namespace WebsiteBanDongHo
{
    public partial class HeaderFooter : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetNoStore();//khi bấm nút back thì giỏ hàng vẫn giữ nguyên
            /*if (Session["cart"]!=null)
            {
                List<CartItem> item = Session["cart"] as List<CartItem>;
                cart_item_count.InnerHtml =item.Count.ToString();
            }*/
            if(Request.Cookies["idCart"]!=null)
            {
                int tong = 0;
                DataTable t = DataProvider.Instance.ExecuteQuery("select * from CartDetail where idCart=" + Request.Cookies["idCart"].Value);
                foreach(DataRow row in t.Rows)
                {
                    tong += (int)row["soLuong"];
                }
                cart_item_count.InnerHtml =tong.ToString();
            }

            
        }


    }
}