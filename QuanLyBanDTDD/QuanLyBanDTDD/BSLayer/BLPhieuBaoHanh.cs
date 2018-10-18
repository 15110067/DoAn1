using QuanLyBanDTDD.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanDTDD.BSLayer
{
    class BLPhieuBaoHanh
    {
        DBMain db = null;

        public BLPhieuBaoHanh()
        {
            db = new DBMain();
        }

        public DataSet Lay()
        {
            return db.ExecuteQueryDataSet("select * from BaoHanh", CommandType.Text);
        }

        public bool Them(string mapbh, string madt, string makh, string tgian, ref string err)
        {
            string sqlString = "Insert Into BaoHanh Values(" + "'" + mapbh + "','" + madt + "','" + makh + "',N'" + tgian + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool CapNhat(string mapbh, string madt, string makh, string tgian, ref string err)
        {
            string sqlString = "Update BaoHanh Set MaDT=N'" + madt + "',MaKH=N'" + makh + "',TGianBH=N'" + tgian + "' Where MaPBH='" + mapbh + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool Xoa(ref string err, string mapbh)
        {
            string sqlString = "Delete From BaoHanh Where MaPBH='" + mapbh + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet DemPBH()
        {
            return db.ExecuteQueryDataSet("select count(*) from BaoHanh", CommandType.Text);
        }
    }
}
