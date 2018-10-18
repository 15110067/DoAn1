﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using QuanLyBanDTDD.BSLayer;
using System.Data.SqlClient;

namespace QuanLyBanDTDD
{
    public partial class frmPhieuBaoHanh : MetroForm
    {
        DataTable dt = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu 

        bool Them;
        string err;
        BLPhieuBaoHanh bl = new BLPhieuBaoHanh();

        // Khai báo biến traloi
        DialogResult traloi;

        public frmPhieuBaoHanh()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            try
            {
                dt = new DataTable();
                dt.Clear();
                DataSet ds = bl.Lay();
                dt = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgv.DataSource = dt;
                // Thay đổi độ rộng cột
                dgv.AutoResizeColumns();
                //Xóa trống các đối tượng trong Panel
                this.txtMaPhieu.ResetText();
                this.txtmaDT.ResetText();
                this.txtTgian.ResetText();
                this.txtMaKh.ResetText();

                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnSua.Enabled = false;
                this.btnHuy.Enabled = false;

                // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
                this.btnCapNhat.Enabled = true;
                this.btnLuu.Enabled = true;
                this.btnXoa.Enabled = true;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung. Xem lại kết nối với SQL Server");
            }
        }

        private void frmPhieuBaoHanh_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;

            this.txtmaDT.Text = frmSanPham.madt;
            this.txtMaKh.Text = frmKhachHang.makh;
            this.txtTgian.ResetText();

            dt = new DataTable();
            dt.Clear();
            DataSet ds = bl.DemPBH();
            dt = ds.Tables[0];

            if(dt.Rows.Count > 0)
            {
                this.txtMaPhieu.Text = "PBH" + (Convert.ToInt32(dt.Rows[0][0].ToString()) + 1);
            }

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    // Thực hiện lệnh
                    bl.Them(this.txtMaPhieu.Text, this.txtmaDT.Text, this.txtMaKh.Text, this.txtTgian.Text, ref err);
                    // Load lại dữ liệu trên DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã thêm xong!");

                    this.Dispose();
                    FrmMain main = new FrmMain();
                    main.ShowDialog();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                // Thực hiện lệnh
                bl.CapNhat(this.txtMaPhieu.Text, this.txtmaDT.Text, this.txtMaKh.Text, this.txtTgian.Text, ref err);
                // Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
            // Đóng kết nối
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;

            this.dgv_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            // Không cho thao tác trên txtMaNV
            this.txtMaPhieu.Enabled = false;
            // Đưa con trỏ đến txtTen
            this.txtmaDT.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
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
            this.txtMaPhieu.ResetText();
            this.txtmaDT.ResetText();
            this.txtTgian.ResetText();

            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;

            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            dgv_CellClick(null, null);
        }

        private void frmPhieuBaoHanh_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtMaPhieu.Text = dgv.Rows[r].Cells[0].Value.ToString();
            this.txtmaDT.Text = dgv.Rows[r].Cells[1].Value.ToString();
            this.txtMaKh.Text = dgv.Rows[r].Cells[4].Value.ToString();
            this.txtTgian.Text = dgv.Rows[r].Cells[5].Value.ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
