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
    public partial class FrmDSKH : MetroFramework.Forms.MetroForm
    {
        public FrmDSKH()
        {
            InitializeComponent();
        }

        private void FrmDSKH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.KhachHang' table. You can move, or remove it, as needed.
            this.KhachHangTableAdapter.Fill(this.DataSet1.KhachHang);

            this.reportViewer1.RefreshReport();
        }
    }
}
