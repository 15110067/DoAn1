using QuanLyBanDTDD.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanDTDD.BSLayer
{
    class BLBackupAndRestore
    {
        DBMain db = null;

        public BLBackupAndRestore()
        {
            db = new DBMain();
        }

        public DataSet Backup()
        {
            return db.ExecuteQueryDataSet("BACKUP DATABASE [QLBanHangDD] TO DISK='C:\\backupQLBanHangDD.bak'", CommandType.Text);
        }

        public DataSet Restore()
        {
            return db.ExecuteQueryDataSet("Use master Restore Database [QLBanHangDD] from DISK='C:\\backupQLBanHangDD.bak'", CommandType.Text);
        }
    }
}
