using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanDTDD.DBLayer;
using System.Data;

namespace QuanLyBanDTDD.BLLayer
{
    class BLSuppliers
    {
        DBMain db = null;

        public BLSuppliers()
        {
            db = new DBMain();
        }

        public DataSet Lay(string MaNCC)
        {
            return db.ExecuteQueryDataSet("select * from NhaCungCap where MaNCC='" + MaNCC + "'", CommandType.Text);
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
    }
}
