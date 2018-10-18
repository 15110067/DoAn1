using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyBanDTDD.DBLayer;

namespace QuanLyBanDTDD.BLLayer
{
    class BLBaoHanh
    {
        DBMain db = null;

        public BLBaoHanh()
        {
            db = new DBMain();
        }

        public DataSet LayPhieuBaoHanh()
        {
            return db.ExecuteQueryDataSet("select * from BaoHanh", CommandType.Text);
        }

        public bool ThemPhieuBaoHanh(string MaPBH, string MaDT, string MaKH, string TgianBH, ref string err)
        {
            return db.MyExecuteNonQuery("insert into BaoHanh values('" + MaPBH + "','" + MaDT + "','" + MaKH + "',N'" + TgianBH + "')", CommandType.Text, ref err);
        }

        public bool SuaPhieuBaoHanh(string MaPBH, string MaDT, string MaKH, string TgianBH, ref string err)
        {
            return db.MyExecuteNonQuery("update BaoHanh set MaDT='" + MaDT + "',MaKH='" + MaKH + "',TgianBH=N'" + TgianBH + "' where MaPBH='" + MaPBH + "'", CommandType.Text, ref err);
        }

        public bool XoaPhieuBaoHanh(string MaPBH, ref string err)
        {
            string sqlString = "delete from BaoHanh where MaPBH='" + MaPBH + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet SearchPhieuBaoHanh(string MaPBH)
        {
            return db.ExecuteQueryDataSet("select * from BaoHanh where MaPBH='" + MaPBH + "'", CommandType.Text);
        }
    }
}
