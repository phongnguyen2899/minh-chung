using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace WebsiteDongHo
{
    public class thuonghieu
    {
        public static DataTable Thongtin_thuonghieu()
        {
            OleDbCommand cmd = new OleDbCommand("ThuongHieu_select");
            cmd.CommandType = CommandType.StoredProcedure;
            return sqldatabase.GetData(cmd);
        }

        public static void ThuongHieu_insert(string ten)
        {
            OleDbCommand cmd = new OleDbCommand("ThuongHieu_insert");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ten", ten);
            sqldatabase.ExecuteNoneQuery(cmd);
        }

        public static void ThuongHieu_update(string ma, string ten)
        {
            OleDbCommand cmd = new OleDbCommand("ThuongHieu_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ma", ma);
            cmd.Parameters.AddWithValue("@ten", ten);
            sqldatabase.ExecuteNoneQuery(cmd);
        }

        public static void ThuongHieu_delete(string ma)
        {
            OleDbCommand cmd = new OleDbCommand("ThuongHieu_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ma", ma);
            sqldatabase.ExecuteNoneQuery(cmd);
        }

        public static DataTable ThuongHieu_selectbyID(string ma)
        {
            OleDbCommand cmd = new OleDbCommand("ThuongHieu_selectbyID");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ma", ma);
            return sqldatabase.GetData(cmd);
        }
    }
}