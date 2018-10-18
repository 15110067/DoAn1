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
using System.Data.SqlClient;
using System.IO;

namespace QuanLyBanDTDD
{
    public partial class frmSanPham : MetroForm
    {
        DataTable dt = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu 

        public static bool Them;
        string err;
        BLDienThoai bl = new BLDienThoai();

        // Khai báo biến traloi
        DialogResult traloi;
        public static byte[] bytes;

        MemoryStream ms;
        public static string madt, tendt, mota;
        public static int soluong;
        public frmSanPham()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            try
            {
                btnBrowse.Visible = false;
                btnBan.Visible = true;
                dt = new DataTable();
                dt.Clear();
                DataSet ds = bl.LayDienThoai();
                dt = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgv.DataSource = dt;
                // Thay đổi độ rộng cột
                dgv.AutoResizeColumns();

                this.txtMaDT.Text = dgv.Rows[0].Cells[0].Value.ToString();
                this.txtTenDT.Text = dgv.Rows[0].Cells[1].Value.ToString();
                bytes = (byte[])dgv.Rows[0].Cells[2].Value;
                if (bytes != null)
                {
                    MemoryStream ms = new MemoryStream(bytes);
                    ptcDT.Image = Image.FromStream(ms);
                }
                this.txtGiaBan.Text = dgv.Rows[0].Cells[3].Value.ToString();
                this.txtDonViTinh.Text = dgv.Rows[0].Cells[4].Value.ToString();
                this.txtSoLuongCon.Text = dgv.Rows[0].Cells[5].Value.ToString();
                this.txtMoTa.Text = dgv.Rows[0].Cells[6].Value.ToString();

                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;

                // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung. Xem lại kết nối với SQL Server");
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            btnBrowse.Visible = true;
            btnBan.Visible = false;
            this.dgv_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            // Không cho thao tác trên các nút Xóa / Thoát
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            // Không cho thao tác trên txtMaNV
            this.txtMaDT.Enabled = false;
            // Đưa con trỏ đến txtTen
            this.txtTenDT.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            btnBrowse.Visible = false;
            btnBan.Visible = true;

            if (Them)
            {
                try
                {
                    // Thực hiện lệnh
                    bl.Them(this.txtMaDT.Text, this.txtTenDT.Text, bytes, Convert.ToInt32(this.txtGiaBan.Text),
                    this.txtDonViTinh.Text, Convert.ToInt32(this.txtSoLuongCon.Text), this.txtMoTa.Text);
                    // Load lại dữ liệu trên DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã thêm xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                // Thực hiện lệnh
                bl.SuaDienThoai(this.txtMaDT.Text, this.txtTenDT.Text, bytes, Convert.ToInt32(this.txtGiaBan.Text),
                    this.txtDonViTinh.Text, Convert.ToInt32(this.txtSoLuongCon.Text), this.txtMoTa.Text);
                // Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
            // Đóng kết nối
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtMaDT.Text = dgv.Rows[r].Cells[0].Value.ToString();
            this.txtTenDT.Text = dgv.Rows[r].Cells[1].Value.ToString();
            bytes = (byte[])dgv.Rows[r].Cells[2].Value;
            if (bytes != null)
            {
                MemoryStream ms = new MemoryStream(bytes);
                ptcDT.Image = Image.FromStream(ms);
            }
            this.txtGiaBan.Text = dgv.Rows[r].Cells[3].Value.ToString();
            this.txtDonViTinh.Text = dgv.Rows[r].Cells[4].Value.ToString();
            this.txtSoLuongCon.Text = dgv.Rows[r].Cells[5].Value.ToString();
            this.txtMoTa.Text = dgv.Rows[r].Cells[6].Value.ToString();

            soluong = Convert.ToInt32(this.txtSoLuongCon.Text);
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            btnBrowse.Visible = false;
            btnBan.Visible = false;
            LoadData();
            metroTab.SelectedTab = tabDanhSach;

            if (FrmMain.timkiem == true)
            {
                metroTab.SelectedTab = tabTimKiem;
            }
            else
            {
                metroTab.SelectedTab = tabDanhSach;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            btnBrowse.Visible = false;
            btnBan.Visible = true;
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnBrowse.Visible = false;
            btnBan.Visible = true;
            try
            {
                // Lấy thứ tự record hiện hành
                int r = dgv.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string str = dgv.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh SQL
                // Hiện thông báo xác nhận việc xóa mẫu tin

                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?
                if (traloi == DialogResult.Yes)
                {
                    bl.Xoa(ref err, str);
                    // Cập nhật lại DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnBan.Visible = false;
            btnBrowse.Visible = false;
            this.txtMaDT.ResetText();
            this.txtTenDT.ResetText();
            this.txtGiaBan.ResetText();
            this.txtSoLuongCon.ResetText();
            this.txtDonViTinh.ResetText();
            this.txtMoTa.ResetText();

            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;

            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            dgv_CellClick(null, null);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog odlgOpenFile = new OpenFileDialog();
            odlgOpenFile.InitialDirectory = "C:\\";
            odlgOpenFile.Title = "Open File";
            odlgOpenFile.Filter = "Image files (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (odlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                ptcDT.Image = Image.FromFile(odlgOpenFile.FileName);
                ms = new MemoryStream();
                ptcDT.Image.Save(ms, ptcDT.Image.RawFormat);
                bytes = ms.GetBuffer();
                ms.Close();
            }
        }

        private void frmSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            traloi = MessageBox.Show("Thoát chương trình và quay về màn hình chính ?", "THOÁT CHƯƠNG TRÌNH",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (traloi == DialogResult.Yes)
            {
                FrmMain frmmain = new FrmMain();
                this.Dispose();
                frmmain.ShowDialog();
            }
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            FrmMain.themHDB = true;
            madt = txtMaDT.Text;
            tendt = txtTenDT.Text;
            mota = txtMoTa.Text;
            soluong = Convert.ToInt32(txtSoLuongCon.Text);

            this.Dispose();
            frmKhachHang frmKH = new frmKhachHang();
            frmKH.ShowDialog();
        }
    }
}
