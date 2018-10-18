using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanDTDD
{
    public partial class FrmDSNV : MetroFramework.Forms.MetroForm
    {
        public FrmDSNV()
        {
            InitializeComponent();
        }

        private void FrmDSNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.NhanVien' table. You can move, or remove it, as needed.
            this.NhanVienTableAdapter.Fill(this.DataSet1.NhanVien);

            this.reportViewer1.RefreshReport();
        }
    }
}
