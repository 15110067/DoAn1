using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using QuanLyBanDTDD.BLLayer;

namespace QuanLyBanDTDD
{
    public partial class frmDoiMatKhau : MetroForm
    {
        DataTable dt = null;
        bool errC, errM;
        BLDangNhap bl = new BLDangNhap();

        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Clear();
            DataSet ds = bl.KiemTra(txtTenDangNhap.Text, txtMatKhauCu.Text);
            dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                errC = false;   //nếu mkc đúng
            }
            else
            {
                errC = true;//MKC sai
            }

            if (txtXacNhan.Text.Trim() == txtMatKhauMoi.Text.Trim())
            {
                errM = false;   //mkm trùng với xác nhận
            }
            else
            {
                errM = true; // không trùng mkm vs xác nhận
            }

            if (errC == false && errM == false) // nếu mkc và mkm khớp
            {
                DoiMK();
                MessageBox.Show("Thành công!!!");
            }
            else if(errC == true && errM == false) // nếu mkc sai và mkm khớp
            {
                lblSai.Visible = true;
                txtMatKhauCu.ResetText();
                txtTenDangNhap.ResetText();
            }
            else if(errC == false && errM == true) // nếu mkc đúng và mkm không khớp
            {
                lblSai2.Visible = true;
                txtMatKhauMoi.ResetText();
                txtXacNhan.ResetText();
            }
            else if (errC == true && errM == true)
            {
                lblSai.Visible = true;
                lblSai2.Visible = true;
                txtTenDangNhap.ResetText();
                txtMatKhauCu.ResetText();
                txtMatKhauMoi.ResetText();
                txtXacNhan.ResetText();
            }
        }

        private void DoiMK()
        {
            dt = new DataTable();
            dt.Clear();
            DataSet ds = bl.DoiMatKhau(txtTenDangNhap.Text, txtMatKhauMoi.Text);
        }
    }
}