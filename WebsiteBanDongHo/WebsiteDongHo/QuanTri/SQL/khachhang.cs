using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace WebsiteDongHo
{
    public class khachhang
    {
        public static DataTable Thongtin_khachhang()
        {
            OleDbCommand cmd = new OleDbCommand("KhachHang_select");
            cmd.CommandType = CommandType.StoredProcedure;
            return sqldatabase.GetData(cmd);
        }
    }
}