using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace WebsiteDongHo
{
    public class tk
    {
        public static DataTable gettk()
        {
            OleDbCommand cmd = new OleDbCommand("TaiKhoan_admin");
            cmd.CommandType = CommandType.StoredProcedure;
            return sqldatabase.GetData(cmd);
        }
        public static void taikhoan_insert(string tk, string mk)
        {
            OleDbCommand cmd = new OleDbCommand("TaiKhoan_insert");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ten", tk);
            cmd.Parameters.AddWithValue("@pwd", mk);
            sqldatabase.ExecuteNoneQuery(cmd);
        }
        public static DataTable taikhoan_seach(string tk, string mk)
        {
            OleDbCommand cmd = new OleDbCommand("TaiKhoan_seach");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ten", tk);
            cmd.Parameters.AddWithValue("@mk", mk);
            return sqldatabase.GetData(cmd);
        }
    }
}