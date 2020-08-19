using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace WebsiteDongHo
{
    public class donhang
    {
        public static DataTable Thongtin_donhang()
        {
            OleDbCommand cmd = new OleDbCommand("DonDatHang_select");
            cmd.CommandType = CommandType.StoredProcedure;
            return sqldatabase.GetData(cmd);
        }
        public static void DonDatHang_update(string ma)
        {
            OleDbCommand cmd = new OleDbCommand("DonDatHang_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ma", ma);
            sqldatabase.ExecuteNoneQuery(cmd);
        }
        public static DataTable DonDatHang_selectchuaxl()
        {
            OleDbCommand cmd = new OleDbCommand("DonHang_selectchuaxl");
            cmd.CommandType = CommandType.StoredProcedure;
            return sqldatabase.GetData(cmd);
        }
    }
}