using QuanLyBanDTDD.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanDTDD.BSLayer
{
    class BLKhachHang
    {
        DBMain db = null;

        public BLKhachHang()
        {
            db = new DBMain();
        }

        public DataSet Lay()
        {
            return db.ExecuteQueryDataSet("select * from KhachHang", CommandType.Text);
        }

        public bool Them(string makh, string ten, string diachi, string sdt, ref string err)
        {
            string sqlString = "Insert Into KhachHang Values(" + "'" + makh + "',N'" + ten + "',N'" + diachi + "','" + sdt + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool CapNhat(string makh, string ten, string diachi, string sdt, ref string err)
        {
            string sqlString = "Update KhachHang Set TenKH=N'" + ten + "',DiaChi=N'" + diachi + "', SDT='" + sdt + "' Where MaKH='" + makh + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool Xoa(ref string err, string makh)
        {
            string sqlString = "Delete From KhachHang Where MaKH='" + makh + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet timKiemText(string tenkh, string sdt)
        {
            string sql = "SELECT * from KhachHang WHERE 1=1";
            if (tenkh != "")
                sql += " AND TenKH LIKE N'%" + tenkh + "%'";
            if (sdt != "")
                sql += " AND SDT LIKE N'%" + sdt + "%'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        public DataSet timKiembtn(string tenkh, string sdt)
        {
            string sql = "SELECT * from KhachHang WHERE 1=1";
            if (tenkh != "")
                sql += " AND TenKH =N'" + tenkh + "'";
            if (sdt != "")
                sql += " AND SDT ='" + sdt + "'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        public DataSet DemKH()
        {
            return db.ExecuteQueryDataSet("select count(*) from KhachHang", CommandType.Text);
        }
    }
}
