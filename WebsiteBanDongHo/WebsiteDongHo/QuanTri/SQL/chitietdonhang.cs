using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace WebsiteDongHo
{
    public class chitietdonhang
    {
        public static DataTable Thongtin_chitietdondat(string ma)
        {
            OleDbCommand cmd = new OleDbCommand("ChiTietDonDat_select");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ma", ma);
            return sqldatabase.GetData(cmd);
        }

        public static DataTable Tongtien(string ma)
        {
            OleDbCommand cmd = new OleDbCommand("TongTienHoaDon");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ma", ma);
            return sqldatabase.GetData(cmd);
        }
    }
}