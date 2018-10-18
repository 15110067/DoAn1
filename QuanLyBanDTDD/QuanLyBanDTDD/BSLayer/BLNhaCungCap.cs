using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanDTDD.DBLayer;
using System.Data;

namespace QuanLyBanDTDD.BLLayer
{
    class BLNhaCungCap
    {
        DBMain db = null;

        public BLNhaCungCap()
        {
            db = new DBMain();
        }

        public DataSet Lay()
        {
            return db.ExecuteQueryDataSet("select * from NhaCungCap", CommandType.Text);
        }

        public bool Them(string mancc, string ten, string diachi, string sdt, ref string err)
        {
            string sqlString = "Insert Into NhaCungCap Values(" + "'" + mancc + "',N'" + ten + "',N'" + diachi + "'" + sdt + "',N'" + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool CapNhat(string mancc, string ten, string diachi, string sdt, ref string err)
        {
            string sqlString = "Update NhaCungCap Set TenNCC=N'" + ten + "',DiaChi=N'" + diachi + "SDT=N'" + sdt + "' Where MaNCC='" + mancc + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool Xoa(ref string err, string mancc)
        {
            string sqlString = "Delete From NhaCungCap Where MaNCC='" + mancc + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet timKiemText(string tenncc, string sdt)
        {
            string sql = "SELECT * from NhaCungCap WHERE 1=1";
            if (tenncc != "")
                sql += " AND TenNCC LIKE N'%" + tenncc + "%'";
            if (sdt != "")
                sql += " AND SDT LIKE N'%" + sdt + "%'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        public DataSet timKiembtn(string tenncc, string sdt)
        {
            string sql = "SELECT * from NhaCungCap WHERE 1=1";
            if (tenncc != "")
                sql += " AND TenNCC =N'" + tenncc + "'";
            if (sdt != "")
                sql += " AND SDT ='" + sdt + "'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        public DataSet DemNCC()
        {
            return db.ExecuteQueryDataSet("select count(*) from NhaCungCap", CommandType.Text);
        }
    }
}
