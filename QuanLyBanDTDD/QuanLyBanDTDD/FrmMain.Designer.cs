namespace QuanLyBanDTDD
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblKhongCo = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.HeThongDownTool = new System.Windows.Forms.ToolStripDropDownButton();
            this.DangNhapTool = new System.Windows.Forms.ToolStripMenuItem();
            this.DangXuatTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DoiMKTool = new System.Windows.Forms.ToolStripMenuItem();
            this.QLyTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SaoLuuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.KhoiPhucTool = new System.Windows.Forms.ToolStripMenuItem();
            this.QLyDownTool = new System.Windows.Forms.ToolStripDropDownButton();
            this.SanPhamTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.KhachHangTool = new System.Windows.Forms.ToolStripMenuItem();
            this.NhanVienTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.HoaDonTool = new System.Windows.Forms.ToolStripMenuItem();
            this.HoaDonNhapTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.themHDTool = new System.Windows.Forms.ToolStripMenuItem();
            this.themHDNTool = new System.Windows.Forms.ToolStripMenuItem();
            this.TKeDownTool = new System.Windows.Forms.ToolStripDropDownButton();
            this.DoanhThuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.DSKHTool = new System.Windows.Forms.ToolStripMenuItem();
            this.DSNVTool = new System.Windows.Forms.ToolStripMenuItem();
            this.ptbNen = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.lblTen);
            this.panel1.Controls.Add(this.lblKhongCo);
            this.panel1.Controls.Add(this.lblState);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 465);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 28);
            this.panel1.TabIndex = 1;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblTen.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTen.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.Color.Lime;
            this.lblTen.Location = new System.Drawing.Point(234, 4);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(34, 20);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Tên";
            this.lblTen.Visible = false;
            // 
            // lblKhongCo
            // 
            this.lblKhongCo.AutoSize = true;
            this.lblKhongCo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhongCo.ForeColor = System.Drawing.Color.Red;
            this.lblKhongCo.Location = new System.Drawing.Point(232, 4);
            this.lblKhongCo.Name = "lblKhongCo";
            this.lblKhongCo.Size = new System.Drawing.Size(75, 20);
            this.lblKhongCo.TabIndex = 1;
            this.lblKhongCo.Text = "Không có";
            this.lblKhongCo.Visible = false;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(5, 4);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(234, 20);
            this.lblState.TabIndex = 0;
            this.lblState.Text = "Người dùng đang đăng nhập là: ";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HeThongDownTool,
            this.QLyDownTool,
            this.TKeDownTool});
            this.toolStrip.Location = new System.Drawing.Point(20, 60);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(699, 28);
            this.toolStrip.TabIndex = 3;
            this.toolStrip.Text = "toolStrip1";
            // 
            // HeThongDownTool
            // 
            this.HeThongDownTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DangNhapTool,
            this.DangXuatTool,
            this.toolStripSeparator1,
            this.DoiMKTool,
            this.QLyTool,
            this.toolStripSeparator2,
            this.SaoLuuTool,
            this.KhoiPhucTool});
            this.HeThongDownTool.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeThongDownTool.Image = global::QuanLyBanDTDD.Properties.Resources.if_windows_317717;
            this.HeThongDownTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HeThongDownTool.Name = "HeThongDownTool";
            this.HeThongDownTool.Size = new System.Drawing.Size(103, 25);
            this.HeThongDownTool.Text = "Hệ thống";
            // 
            // DangNhapTool
            // 
            this.DangNhapTool.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DangNhapTool.Image = global::QuanLyBanDTDD.Properties.Resources.icons8_import_24;
            this.DangNhapTool.Name = "DangNhapTool";
            this.DangNhapTool.Size = new System.Drawing.Size(210, 24);
            this.DangNhapTool.Text = "Đăng nhập";
            this.DangNhapTool.Click += new System.EventHandler(this.DangNhapTool_Click);
            // 
            // DangXuatTool
            // 
            this.DangXuatTool.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DangXuatTool.Image = global::QuanLyBanDTDD.Properties.Resources.icons8_export_24;
            this.DangXuatTool.Name = "DangXuatTool";
            this.DangXuatTool.Size = new System.Drawing.Size(210, 24);
            this.DangXuatTool.Text = "Đăng xuất";
            this.DangXuatTool.Click += new System.EventHandler(this.DangXuatTool_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // DoiMKTool
            // 
            this.DoiMKTool.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoiMKTool.Image = global::QuanLyBanDTDD.Properties.Resources.icons8_password_reset_24;
            this.DoiMKTool.Name = "DoiMKTool";
            this.DoiMKTool.Size = new System.Drawing.Size(210, 24);
            this.DoiMKTool.Text = "Đổi mật khẩu";
            this.DoiMKTool.Click += new System.EventHandler(this.DoiMKTool_Click);
            // 
            // QLyTool
            // 
            this.QLyTool.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLyTool.Image = global::QuanLyBanDTDD.Properties.Resources.icons8_assistant_24;
            this.QLyTool.Name = "QLyTool";
            this.QLyTool.Size = new System.Drawing.Size(210, 24);
            this.QLyTool.Text = "Quản lý người dùng";
            this.QLyTool.Click += new System.EventHandler(this.QLyTool_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(207, 6);
            // 
            // SaoLuuTool
            // 
            this.SaoLuuTool.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaoLuuTool.Image = global::QuanLyBanDTDD.Properties.Resources.icons8_database_backup_24;
            this.SaoLuuTool.Name = "SaoLuuTool";
            this.SaoLuuTool.Size = new System.Drawing.Size(210, 24);
            this.SaoLuuTool.Text = "Sao lưu dữ liệu";
            this.SaoLuuTool.Click += new System.EventHandler(this.SaoLuuTool_Click);
            // 
            // KhoiPhucTool
            // 
            this.KhoiPhucTool.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KhoiPhucTool.Image = global::QuanLyBanDTDD.Properties.Resources.icons8_database_restore_filled_24;
            this.KhoiPhucTool.Name = "KhoiPhucTool";
            this.KhoiPhucTool.Size = new System.Drawing.Size(210, 24);
            this.KhoiPhucTool.Text = "Khôi phục dữ liệu";
            this.KhoiPhucTool.Click += new System.EventHandler(this.KhoiPhucTool_Click);
            // 
            // QLyDownTool
            // 
            this.QLyDownTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SanPhamTool,
            this.toolStripSeparator4,
            this.KhachHangTool,
            this.NhanVienTool,
            this.toolStripSeparator5,
            this.HoaDonTool,
            this.HoaDonNhapTool,
            this.toolStripSeparator3,
            this.themHDTool,
            this.themHDNTool});
            this.QLyDownTool.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLyDownTool.Image = global::QuanLyBanDTDD.Properties.Resources.icons8_manager_24;
            this.QLyDownTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.QLyDownTool.Name = "QLyDownTool";
            this.QLyDownTool.Size = new System.Drawing.Size(88, 25);
            this.QLyDownTool.Text = "Quản lý";
            // 
            // SanPhamTool
            // 
            this.SanPhamTool.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SanPhamTool.Image = global::QuanLyBanDTDD.Properties.Resources.icons8_iphone_24;
            this.SanPhamTool.Name = "SanPhamTool";
            this.SanPhamTool.Size = new System.Drawing.Size(211, 24);
            this.SanPhamTool.Text = "Sản phẩm";
            this.SanPhamTool.Click += new System.EventHandler(this.SanPhamTool_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(208, 6);
            // 
            // KhachHangTool
            // 
            this.KhachHangTool.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KhachHangTool.Image = global::QuanLyBanDTDD.Properties.Resources.icons8_customer_24__1_;
            this.KhachHangTool.Name = "KhachHangTool";
            this.KhachHangTool.Size = new System.Drawing.Size(211, 24);
            this.KhachHangTool.Text = "Khách hàng";
            this.KhachHangTool.Click += new System.EventHandler(this.KhachHangTool_Click);
            // 
            // NhanVienTool
            // 
            this.NhanVienTool.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhanVienTool.Image = global::QuanLyBanDTDD.Properties.Resources.icons8_staff_24;
            this.NhanVienTool.Name = "NhanVienTool";
            this.NhanVienTool.Size = new System.Drawing.Size(211, 24);
            this.NhanVienTool.Text = "Nhân Viên";
            this.NhanVienTool.Click += new System.EventHandler(this.NhanVienTool_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(208, 6);
            // 
            // HoaDonTool
            // 
            this.HoaDonTool.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoaDonTool.Image = global::QuanLyBanDTDD.Properties.Resources.icons8_check_24;
            this.HoaDonTool.Name = "HoaDonTool";
            this.HoaDonTool.Size = new System.Drawing.Size(211, 24);
            this.HoaDonTool.Text = "Hóa đơn bán";
            this.HoaDonTool.Click += new System.EventHandler(this.HoaDonTool_Click);
            // 
            // HoaDonNhapTool
            // 
            this.HoaDonNhapTool.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoaDonNhapTool.Image = global::QuanLyBanDTDD.Properties.Resources.icons8_bill_24;
            this.HoaDonNhapTool.Name = "HoaDonNhapTool";
            this.HoaDonNhapTool.Size = new System.Drawing.Size(211, 24);
            this.HoaDonNhapTool.Text = "Hóa đơn nhập";
            this.HoaDonNhapTool.Click += new System.EventHandler(this.HoaDonNhapTool_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(208, 6);
            // 
            // themHDTool
            // 
            this.themHDTool.Image = global::QuanLyBanDTDD.Properties.Resources.icons8_plus_24;
            this.themHDTool.Name = "themHDTool";
            this.themHDTool.Size = new System.Drawing.Size(211, 24);
            this.themHDTool.Text = "Thêm hóa đơn bán";
            this.themHDTool.Click += new System.EventHandler(this.themHDTool_Click);
            // 
            // themHDNTool
            // 
            this.themHDNTool.Image = global::QuanLyBanDTDD.Properties.Resources.icons8_plus_24;
            this.themHDNTool.Name = "themHDNTool";
            this.themHDNTool.Size = new System.Drawing.Size(211, 24);
            this.themHDNTool.Text = "Thêm hóa đơn nhập";
            this.themHDNTool.Click += new System.EventHandler(this.themHDNTool_Click);
            // 
            // TKeDownTool
            // 
            this.TKeDownTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DoanhThuTool,
            this.DSKHTool,
            this.DSNVTool});
            this.TKeDownTool.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TKeDownTool.Image = global::QuanLyBanDTDD.Properties.Resources.icons8_statistics_24;
            this.TKeDownTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TKeDownTool.Name = "TKeDownTool";
            this.TKeDownTool.Size = new System.Drawing.Size(103, 25);
            this.TKeDownTool.Text = "Thống kê";
            // 
            // DoanhThuTool
            // 
            this.DoanhThuTool.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoanhThuTool.Image = global::QuanLyBanDTDD.Properties.Resources.icons8_sales_performance_24;
            this.DoanhThuTool.Name = "DoanhThuTool";
            this.DoanhThuTool.Size = new System.Drawing.Size(226, 24);
            this.DoanhThuTool.Text = "Doanh thu";
            this.DoanhThuTool.Click += new System.EventHandler(this.DoanhThuTool_Click);
            // 
            // DSKHTool
            // 
            this.DSKHTool.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DSKHTool.Image = global::QuanLyBanDTDD.Properties.Resources.icons8_send_hot_list_30;
            this.DSKHTool.Name = "DSKHTool";
            this.DSKHTool.Size = new System.Drawing.Size(226, 24);
            this.DSKHTool.Text = "Danh sách khách hàng";
            this.DSKHTool.Click += new System.EventHandler(this.DSKHTool_Click);
            // 
            // DSNVTool
            // 
            this.DSNVTool.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DSNVTool.Image = global::QuanLyBanDTDD.Properties.Resources.icons8_send_hot_list_24;
            this.DSNVTool.Name = "DSNVTool";
            this.DSNVTool.Size = new System.Drawing.Size(226, 24);
            this.DSNVTool.Text = "Danh sách nhân viên";
            this.DSNVTool.Click += new System.EventHandler(this.DSNVTool_Click);
            // 
            // ptbNen
            // 
            this.ptbNen.Image = global::QuanLyBanDTDD.Properties.Resources.kuz_3014;
            this.ptbNen.Location = new System.Drawing.Point(66, 103);
            this.ptbNen.Name = "ptbNen";
            this.ptbNen.Size = new System.Drawing.Size(616, 347);
            this.ptbNen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbNen.TabIndex = 0;
            this.ptbNen.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 513);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ptbNen);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "QUẢN LÝ CỬA HÀNG BÁN ĐIỆN THOẠI DI ĐỘNG";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripDropDownButton HeThongDownTool;
        private System.Windows.Forms.ToolStripMenuItem DangNhapTool;
        private System.Windows.Forms.ToolStripMenuItem DangXuatTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem DoiMKTool;
        private System.Windows.Forms.ToolStripMenuItem QLyTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem SaoLuuTool;
        private System.Windows.Forms.ToolStripMenuItem KhoiPhucTool;
        private System.Windows.Forms.ToolStripDropDownButton QLyDownTool;
        private System.Windows.Forms.ToolStripMenuItem SanPhamTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem KhachHangTool;
        private System.Windows.Forms.ToolStripMenuItem NhanVienTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem HoaDonTool;
        private System.Windows.Forms.ToolStripMenuItem HoaDonNhapTool;
        private System.Windows.Forms.ToolStripDropDownButton TKeDownTool;
        private System.Windows.Forms.ToolStripMenuItem DoanhThuTool;
        private System.Windows.Forms.ToolStripMenuItem DSKHTool;
        private System.Windows.Forms.ToolStripMenuItem DSNVTool;
        private System.Windows.Forms.PictureBox ptbNen;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblKhongCo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem themHDTool;
        private System.Windows.Forms.ToolStripMenuItem themHDNTool;
    }
}