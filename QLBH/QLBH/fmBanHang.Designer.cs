
namespace QLBH
{
    partial class fmBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmBanHang));
            this.grbHoaDon = new System.Windows.Forms.GroupBox();
            this.btnXoaHet = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.dtNgayBan = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbKhachHang = new System.Windows.Forms.GroupBox();
            this.txtInfo = new System.Windows.Forms.Button();
            this.txtThemKH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.grb_CongCu = new System.Windows.Forms.GroupBox();
            this.bnThoat = new System.Windows.Forms.Button();
            this.bnThanhToan = new System.Windows.Forms.Button();
            this.grbSanPham = new System.Windows.Forms.GroupBox();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTienKhach = new System.Windows.Forms.TextBox();
            this.txtTienThua = new System.Windows.Forms.TextBox();
            this.txtTienThanhToan = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.grbHoaDon.SuspendLayout();
            this.grbKhachHang.SuspendLayout();
            this.grb_CongCu.SuspendLayout();
            this.grbSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // grbHoaDon
            // 
            this.grbHoaDon.Controls.Add(this.btnXoaHet);
            this.grbHoaDon.Controls.Add(this.btnXoa);
            this.grbHoaDon.Controls.Add(this.btnXacNhan);
            this.grbHoaDon.Controls.Add(this.dtNgayBan);
            this.grbHoaDon.Controls.Add(this.label3);
            this.grbHoaDon.Controls.Add(this.txtTenSP);
            this.grbHoaDon.Controls.Add(this.txtquantity);
            this.grbHoaDon.Controls.Add(this.txtMaSP);
            this.grbHoaDon.Controls.Add(this.label4);
            this.grbHoaDon.Controls.Add(this.label2);
            this.grbHoaDon.Controls.Add(this.label6);
            this.grbHoaDon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbHoaDon.Location = new System.Drawing.Point(58, 10);
            this.grbHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.grbHoaDon.Name = "grbHoaDon";
            this.grbHoaDon.Padding = new System.Windows.Forms.Padding(2);
            this.grbHoaDon.Size = new System.Drawing.Size(494, 156);
            this.grbHoaDon.TabIndex = 0;
            this.grbHoaDon.TabStop = false;
            this.grbHoaDon.Text = "Hóa Đơn";
            this.grbHoaDon.Enter += new System.EventHandler(this.grbHoaDon_Enter);
            // 
            // btnXoaHet
            // 
            this.btnXoaHet.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnXoaHet.Location = new System.Drawing.Point(359, 27);
            this.btnXoaHet.Name = "btnXoaHet";
            this.btnXoaHet.Size = new System.Drawing.Size(130, 32);
            this.btnXoaHet.TabIndex = 46;
            this.btnXoaHet.Text = "Xóa hết";
            this.btnXoaHet.UseVisualStyleBackColor = true;
            this.btnXoaHet.Click += new System.EventHandler(this.btnXoaHet_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Location = new System.Drawing.Point(359, 73);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(130, 32);
            this.btnXoa.TabIndex = 46;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.Green;
            this.btnXacNhan.Location = new System.Drawing.Point(359, 115);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(130, 32);
            this.btnXacNhan.TabIndex = 46;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // dtNgayBan
            // 
            this.dtNgayBan.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayBan.Location = new System.Drawing.Point(114, 86);
            this.dtNgayBan.Margin = new System.Windows.Forms.Padding(2);
            this.dtNgayBan.Name = "dtNgayBan";
            this.dtNgayBan.Size = new System.Drawing.Size(224, 27);
            this.dtNgayBan.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Tên Sản Phẩm";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.Location = new System.Drawing.Point(114, 119);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.ReadOnly = true;
            this.txtTenSP.Size = new System.Drawing.Size(224, 27);
            this.txtTenSP.TabIndex = 43;
            // 
            // txtquantity
            // 
            this.txtquantity.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantity.Location = new System.Drawing.Point(114, 55);
            this.txtquantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(224, 27);
            this.txtquantity.TabIndex = 42;
            this.txtquantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtquantity_KeyPress);
            // 
            // txtMaSP
            // 
            this.txtMaSP.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSP.Location = new System.Drawing.Point(114, 22);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(224, 27);
            this.txtMaSP.TabIndex = 42;
            this.txtMaSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtquantity_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(14, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Số lượng";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Ngày bán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(14, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Mã sản phẩm";
            // 
            // grbKhachHang
            // 
            this.grbKhachHang.Controls.Add(this.txtInfo);
            this.grbKhachHang.Controls.Add(this.txtThemKH);
            this.grbKhachHang.Controls.Add(this.label1);
            this.grbKhachHang.Controls.Add(this.txtSoDienThoai);
            this.grbKhachHang.Controls.Add(this.txtDiaChi);
            this.grbKhachHang.Controls.Add(this.label10);
            this.grbKhachHang.Controls.Add(this.label9);
            this.grbKhachHang.Controls.Add(this.label8);
            this.grbKhachHang.Controls.Add(this.label7);
            this.grbKhachHang.Controls.Add(this.txtMaKH);
            this.grbKhachHang.Controls.Add(this.txtTenKH);
            this.grbKhachHang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbKhachHang.ForeColor = System.Drawing.Color.Black;
            this.grbKhachHang.Location = new System.Drawing.Point(556, 11);
            this.grbKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.grbKhachHang.Name = "grbKhachHang";
            this.grbKhachHang.Padding = new System.Windows.Forms.Padding(2);
            this.grbKhachHang.Size = new System.Drawing.Size(505, 156);
            this.grbKhachHang.TabIndex = 47;
            this.grbKhachHang.TabStop = false;
            this.grbKhachHang.Text = "Khách Hàng";
            // 
            // txtInfo
            // 
            this.txtInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.Location = new System.Drawing.Point(355, 15);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(144, 53);
            this.txtInfo.TabIndex = 52;
            this.txtInfo.Text = "Xem Thông Tin";
            this.txtInfo.UseVisualStyleBackColor = true;
            this.txtInfo.Click += new System.EventHandler(this.txtInfo_Click);
            // 
            // txtThemKH
            // 
            this.txtThemKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThemKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtThemKH.Location = new System.Drawing.Point(355, 74);
            this.txtThemKH.Name = "txtThemKH";
            this.txtThemKH.Size = new System.Drawing.Size(144, 69);
            this.txtThemKH.TabIndex = 52;
            this.txtThemKH.Text = "Thêm Khách hàng";
            this.txtThemKH.UseVisualStyleBackColor = true;
            this.txtThemKH.Click += new System.EventHandler(this.txtThemKH_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Địa Chỉ";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.Location = new System.Drawing.Point(118, 120);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(232, 26);
            this.txtSoDienThoai.TabIndex = 50;
            this.txtSoDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaKH_KeyPress_1);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(118, 89);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(232, 26);
            this.txtDiaChi.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(4, 123);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 46;
            this.label10.Text = "Điện thoại";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(-47, 85);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 19);
            this.label9.TabIndex = 45;
            this.label9.Text = "Địa chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(4, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 20);
            this.label8.TabIndex = 44;
            this.label8.Text = "Mã khách hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(4, 57);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 43;
            this.label7.Text = "Tên khách hàng";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(117, 20);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(232, 26);
            this.txtMaKH.TabIndex = 42;
            this.txtMaKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaKH_KeyPress_1);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(117, 53);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(232, 26);
            this.txtTenKH.TabIndex = 42;
            // 
            // grb_CongCu
            // 
            this.grb_CongCu.BackColor = System.Drawing.Color.LightGray;
            this.grb_CongCu.Controls.Add(this.bnThoat);
            this.grb_CongCu.Controls.Add(this.bnThanhToan);
            this.grb_CongCu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_CongCu.ForeColor = System.Drawing.Color.Black;
            this.grb_CongCu.Location = new System.Drawing.Point(17, 180);
            this.grb_CongCu.Margin = new System.Windows.Forms.Padding(2);
            this.grb_CongCu.Name = "grb_CongCu";
            this.grb_CongCu.Padding = new System.Windows.Forms.Padding(2);
            this.grb_CongCu.Size = new System.Drawing.Size(150, 241);
            this.grb_CongCu.TabIndex = 48;
            this.grb_CongCu.TabStop = false;
            this.grb_CongCu.Text = "Công Cụ:";
            // 
            // bnThoat
            // 
            this.bnThoat.BackColor = System.Drawing.Color.Transparent;
            this.bnThoat.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnThoat.ForeColor = System.Drawing.Color.Red;
            this.bnThoat.Location = new System.Drawing.Point(26, 156);
            this.bnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.bnThoat.Name = "bnThoat";
            this.bnThoat.Size = new System.Drawing.Size(92, 74);
            this.bnThoat.TabIndex = 53;
            this.bnThoat.Text = "Thoát";
            this.bnThoat.UseVisualStyleBackColor = false;
            this.bnThoat.Click += new System.EventHandler(this.bnThoat_Click);
            // 
            // bnThanhToan
            // 
            this.bnThanhToan.BackColor = System.Drawing.Color.Transparent;
            this.bnThanhToan.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bnThanhToan.Location = new System.Drawing.Point(26, 44);
            this.bnThanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.bnThanhToan.Name = "bnThanhToan";
            this.bnThanhToan.Size = new System.Drawing.Size(92, 108);
            this.bnThanhToan.TabIndex = 49;
            this.bnThanhToan.Text = "Thanh Toán";
            this.bnThanhToan.UseVisualStyleBackColor = false;
            this.bnThanhToan.Click += new System.EventHandler(this.bnThanhToan_Click);
            // 
            // grbSanPham
            // 
            this.grbSanPham.Controls.Add(this.dgvSanPham);
            this.grbSanPham.Controls.Add(this.label12);
            this.grbSanPham.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSanPham.Location = new System.Drawing.Point(172, 171);
            this.grbSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.grbSanPham.Name = "grbSanPham";
            this.grbSanPham.Padding = new System.Windows.Forms.Padding(2);
            this.grbSanPham.Size = new System.Drawing.Size(889, 250);
            this.grbSanPham.TabIndex = 52;
            this.grbSanPham.TabStop = false;
            this.grbSanPham.Text = "Sản Phẩm";
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Location = new System.Drawing.Point(4, 19);
            this.dgvSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.RowTemplate.Height = 24;
            this.dgvSanPham.Size = new System.Drawing.Size(872, 220);
            this.dgvSanPham.TabIndex = 46;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label12.Location = new System.Drawing.Point(-47, 85);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 19);
            this.label12.TabIndex = 45;
            this.label12.Text = "Địa chỉ";
            // 
            // txtTienKhach
            // 
            this.txtTienKhach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienKhach.Location = new System.Drawing.Point(472, 476);
            this.txtTienKhach.Margin = new System.Windows.Forms.Padding(2);
            this.txtTienKhach.Name = "txtTienKhach";
            this.txtTienKhach.Size = new System.Drawing.Size(212, 29);
            this.txtTienKhach.TabIndex = 67;
            this.txtTienKhach.Text = "0";
            this.txtTienKhach.TextChanged += new System.EventHandler(this.txtTienKhach_TextChanged);
            this.txtTienKhach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTienKhach_KeyPress);
            // 
            // txtTienThua
            // 
            this.txtTienThua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienThua.Location = new System.Drawing.Point(696, 476);
            this.txtTienThua.Margin = new System.Windows.Forms.Padding(2);
            this.txtTienThua.Name = "txtTienThua";
            this.txtTienThua.ReadOnly = true;
            this.txtTienThua.Size = new System.Drawing.Size(204, 29);
            this.txtTienThua.TabIndex = 66;
            this.txtTienThua.Text = "0";
            // 
            // txtTienThanhToan
            // 
            this.txtTienThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienThanhToan.Location = new System.Drawing.Point(246, 476);
            this.txtTienThanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.txtTienThanhToan.Name = "txtTienThanhToan";
            this.txtTienThanhToan.ReadOnly = true;
            this.txtTienThanhToan.Size = new System.Drawing.Size(214, 29);
            this.txtTienThanhToan.TabIndex = 65;
            this.txtTienThanhToan.Text = "0";
            this.txtTienThanhToan.TextChanged += new System.EventHandler(this.txtTienThanhToan_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(763, 455);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 19);
            this.label13.TabIndex = 64;
            this.label13.Text = "Tiền Thừa";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(531, 455);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 19);
            this.label14.TabIndex = 63;
            this.label14.Text = "Tiền Khách Đưa";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(296, 455);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(144, 19);
            this.label15.TabIndex = 62;
            this.label15.Text = "Tổng Tiền Thanh Toán";
            // 
            // fmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 541);
            this.Controls.Add(this.txtTienKhach);
            this.Controls.Add(this.txtTienThua);
            this.Controls.Add(this.txtTienThanhToan);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.grbSanPham);
            this.Controls.Add(this.grb_CongCu);
            this.Controls.Add(this.grbKhachHang);
            this.Controls.Add(this.grbHoaDon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fmBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán Hàng";
            this.Load += new System.EventHandler(this.fmBanHang_Load);
            this.grbHoaDon.ResumeLayout(false);
            this.grbHoaDon.PerformLayout();
            this.grbKhachHang.ResumeLayout(false);
            this.grbKhachHang.PerformLayout();
            this.grb_CongCu.ResumeLayout(false);
            this.grbSanPham.ResumeLayout(false);
            this.grbSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbHoaDon;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker dtNgayBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grbKhachHang;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.GroupBox grb_CongCu;
        private System.Windows.Forms.Button bnThoat;
        private System.Windows.Forms.Button bnThanhToan;
        private System.Windows.Forms.GroupBox grbSanPham;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTienKhach;
        private System.Windows.Forms.TextBox txtTienThua;
        private System.Windows.Forms.TextBox txtTienThanhToan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnXoaHet;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button txtInfo;
        private System.Windows.Forms.Button txtThemKH;
        private System.Windows.Forms.TextBox txtMaKH;
    }
}