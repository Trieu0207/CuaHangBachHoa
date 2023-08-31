
namespace QLBH
{
    partial class fmSanPham
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.GroupBox grbSanPham;
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LBNHANVIEN = new System.Windows.Forms.Label();
            this.bn_Luu = new System.Windows.Forms.Button();
            this.bn_Dong = new System.Windows.Forms.Button();
            this.bnXoa = new System.Windows.Forms.Button();
            this.bn_Sua = new System.Windows.Forms.Button();
            this.bn_Them = new System.Windows.Forms.Button();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.dATABASEQLBHDataSet = new QLBH.DATABASEQLBHDataSet();
            this.dATABASEQLBHDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dATABASEQLBHDataSet7 = new QLBH.DATABASEQLBHDataSet7();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new QLBH.DATABASEQLBHDataSet7TableAdapters.ProductTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCate = new System.Windows.Forms.ComboBox();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            grbSanPham = new System.Windows.Forms.GroupBox();
            grbSanPham.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATABASEQLBHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATABASEQLBHDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATABASEQLBHDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grbSanPham
            // 
            grbSanPham.BackColor = System.Drawing.SystemColors.ActiveCaption;
            grbSanPham.Controls.Add(this.cbCate);
            grbSanPham.Controls.Add(this.txtSoLuong);
            grbSanPham.Controls.Add(this.label1);
            grbSanPham.Controls.Add(this.label2);
            grbSanPham.Controls.Add(this.txtGhiChu);
            grbSanPham.Controls.Add(this.label3);
            grbSanPham.Controls.Add(this.label7);
            grbSanPham.Controls.Add(this.label5);
            grbSanPham.Controls.Add(this.label6);
            grbSanPham.Controls.Add(this.txtTenSP);
            grbSanPham.Controls.Add(this.txtDonGiaBan);
            grbSanPham.Controls.Add(this.txtMaSP);
            grbSanPham.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            grbSanPham.ForeColor = System.Drawing.SystemColors.ControlText;
            grbSanPham.Location = new System.Drawing.Point(11, 50);
            grbSanPham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            grbSanPham.Name = "grbSanPham";
            grbSanPham.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            grbSanPham.Size = new System.Drawing.Size(1145, 189);
            grbSanPham.TabIndex = 5;
            grbSanPham.TabStop = false;
            grbSanPham.Text = "Thông tin Sản Phẩm";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(652, 24);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(259, 26);
            this.txtSoLuong.TabIndex = 21;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(92, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sản phẩm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(92, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sản phẩm";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(652, 78);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(281, 26);
            this.txtGhiChu.TabIndex = 19;
            this.txtGhiChu.TextChanged += new System.EventHandler(this.txtghichu_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(517, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(92, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Đơn giá bán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(517, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ghi chú";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.Location = new System.Drawing.Point(227, 81);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(259, 26);
            this.txtTenSP.TabIndex = 11;
            // 
            // txtDonGiaBan
            // 
            this.txtDonGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGiaBan.Location = new System.Drawing.Point(227, 136);
            this.txtDonGiaBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.Size = new System.Drawing.Size(259, 26);
            this.txtDonGiaBan.TabIndex = 7;
            this.txtDonGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGiaBan_KeyPress);
            // 
            // txtMaSP
            // 
            this.txtMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSP.Location = new System.Drawing.Point(227, 24);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(259, 26);
            this.txtMaSP.TabIndex = 8;
            this.txtMaSP.TextChanged += new System.EventHandler(this.txtMaSP_TextChanged);
            this.txtMaSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaSP_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.bn_Luu);
            this.panel2.Controls.Add(grbSanPham);
            this.panel2.Controls.Add(this.bn_Dong);
            this.panel2.Controls.Add(this.LBNHANVIEN);
            this.panel2.Controls.Add(this.bnXoa);
            this.panel2.Controls.Add(this.bn_Them);
            this.panel2.Controls.Add(this.bn_Sua);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1169, 326);
            this.panel2.TabIndex = 2;
            // 
            // LBNHANVIEN
            // 
            this.LBNHANVIEN.AutoSize = true;
            this.LBNHANVIEN.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBNHANVIEN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LBNHANVIEN.Location = new System.Drawing.Point(426, 8);
            this.LBNHANVIEN.Name = "LBNHANVIEN";
            this.LBNHANVIEN.Size = new System.Drawing.Size(272, 30);
            this.LBNHANVIEN.TabIndex = 0;
            this.LBNHANVIEN.Text = "DANH MỤC SẢN PHẨM";
            // 
            // bn_Luu
            // 
            this.bn_Luu.BackColor = System.Drawing.Color.White;
            this.bn_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_Luu.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_Luu.ForeColor = System.Drawing.Color.Blue;
            this.bn_Luu.Location = new System.Drawing.Point(632, 247);
            this.bn_Luu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bn_Luu.Name = "bn_Luu";
            this.bn_Luu.Size = new System.Drawing.Size(107, 66);
            this.bn_Luu.TabIndex = 35;
            this.bn_Luu.Text = "Lưu";
            this.bn_Luu.UseVisualStyleBackColor = false;
            this.bn_Luu.Click += new System.EventHandler(this.bn_Luu_Click);
            // 
            // bn_Dong
            // 
            this.bn_Dong.BackColor = System.Drawing.Color.White;
            this.bn_Dong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_Dong.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_Dong.ForeColor = System.Drawing.Color.Red;
            this.bn_Dong.Location = new System.Drawing.Point(745, 247);
            this.bn_Dong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bn_Dong.Name = "bn_Dong";
            this.bn_Dong.Size = new System.Drawing.Size(117, 66);
            this.bn_Dong.TabIndex = 34;
            this.bn_Dong.Text = "Đóng";
            this.bn_Dong.UseVisualStyleBackColor = false;
            this.bn_Dong.Click += new System.EventHandler(this.bn_Dong_Click);
            // 
            // bnXoa
            // 
            this.bnXoa.BackColor = System.Drawing.Color.White;
            this.bnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bnXoa.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnXoa.ForeColor = System.Drawing.Color.Red;
            this.bnXoa.Location = new System.Drawing.Point(519, 247);
            this.bnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bnXoa.Name = "bnXoa";
            this.bnXoa.Size = new System.Drawing.Size(107, 66);
            this.bnXoa.TabIndex = 31;
            this.bnXoa.Text = "Xóa";
            this.bnXoa.UseVisualStyleBackColor = false;
            this.bnXoa.Click += new System.EventHandler(this.bnXoa_Click);
            // 
            // bn_Sua
            // 
            this.bn_Sua.BackColor = System.Drawing.Color.White;
            this.bn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_Sua.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_Sua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bn_Sua.Location = new System.Drawing.Point(403, 247);
            this.bn_Sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bn_Sua.Name = "bn_Sua";
            this.bn_Sua.Size = new System.Drawing.Size(107, 66);
            this.bn_Sua.TabIndex = 30;
            this.bn_Sua.Text = "Sửa";
            this.bn_Sua.UseVisualStyleBackColor = false;
            this.bn_Sua.Click += new System.EventHandler(this.bn_Sua_Click);
            // 
            // bn_Them
            // 
            this.bn_Them.BackColor = System.Drawing.Color.White;
            this.bn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_Them.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_Them.ForeColor = System.Drawing.Color.Green;
            this.bn_Them.Location = new System.Drawing.Point(287, 247);
            this.bn_Them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bn_Them.Name = "bn_Them";
            this.bn_Them.Size = new System.Drawing.Size(107, 66);
            this.bn_Them.TabIndex = 29;
            this.bn_Them.Text = "Thêm";
            this.bn_Them.UseVisualStyleBackColor = false;
            this.bn_Them.Click += new System.EventHandler(this.bn_Them_Click);
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AutoGenerateColumns = false;
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.CategoryID,
            this.productname,
            this.price,
            this.quantity,
            this.note});
            this.dgvSanPham.DataSource = this.productBindingSource;
            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanPham.Location = new System.Drawing.Point(0, 326);
            this.dgvSanPham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.RowTemplate.Height = 24;
            this.dgvSanPham.Size = new System.Drawing.Size(1169, 303);
            this.dgvSanPham.TabIndex = 4;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // dATABASEQLBHDataSet
            // 
            this.dATABASEQLBHDataSet.DataSetName = "DATABASEQLBHDataSet";
            this.dATABASEQLBHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dATABASEQLBHDataSetBindingSource
            // 
            this.dATABASEQLBHDataSetBindingSource.DataSource = this.dATABASEQLBHDataSet;
            this.dATABASEQLBHDataSetBindingSource.Position = 0;
            // 
            // dATABASEQLBHDataSet7
            // 
            this.dATABASEQLBHDataSet7.DataSetName = "DATABASEQLBHDataSet7";
            this.dATABASEQLBHDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.dATABASEQLBHDataSet7;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(517, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Loại sản phẩm";
            // 
            // cbCate
            // 
            this.cbCate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCate.FormattingEnabled = true;
            this.cbCate.Location = new System.Drawing.Point(652, 138);
            this.cbCate.Name = "cbCate";
            this.cbCate.Size = new System.Drawing.Size(246, 29);
            this.cbCate.TabIndex = 22;
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            // 
            // CategoryID
            // 
            this.CategoryID.DataPropertyName = "CategoryID";
            this.CategoryID.HeaderText = "CategoryID";
            this.CategoryID.Name = "CategoryID";
            // 
            // productname
            // 
            this.productname.DataPropertyName = "productname";
            this.productname.HeaderText = "productname";
            this.productname.Name = "productname";
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "price";
            this.price.Name = "price";
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "quantity";
            this.quantity.Name = "quantity";
            // 
            // note
            // 
            this.note.DataPropertyName = "note";
            this.note.HeaderText = "note";
            this.note.Name = "note";
            // 
            // fmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 629);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sản Phẩm";
            this.Load += new System.EventHandler(this.fmSanPham_Load);
            grbSanPham.ResumeLayout(false);
            grbSanPham.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATABASEQLBHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATABASEQLBHDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATABASEQLBHDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtDonGiaBan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBNHANVIEN;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button bn_Luu;
        private System.Windows.Forms.Button bn_Dong;
        private System.Windows.Forms.Button bnXoa;
        private System.Windows.Forms.Button bn_Sua;
        private System.Windows.Forms.Button bn_Them;
        private System.Windows.Forms.BindingSource dATABASEQLBHDataSetBindingSource;
        private DATABASEQLBHDataSet dATABASEQLBHDataSet;
        private DATABASEQLBHDataSet7 dATABASEQLBHDataSet7;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DATABASEQLBHDataSet7TableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
    }
}