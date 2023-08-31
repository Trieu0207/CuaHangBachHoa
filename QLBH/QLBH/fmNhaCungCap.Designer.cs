
namespace QLBH
{
    partial class fmNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmNhaCungCap));
            this.grb_CongCu = new System.Windows.Forms.GroupBox();
            this.bnThoat = new System.Windows.Forms.Button();
            this.bnThem = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnThemSanPham = new System.Windows.Forms.Button();
            this.grbNhaCungCap = new System.Windows.Forms.GroupBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dATABASEQLBHDataSet11 = new QLBH.DATABASEQLBHDataSet11();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new QLBH.DATABASEQLBHDataSet11TableAdapters.ProductTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grb_CongCu.SuspendLayout();
            this.grbNhaCungCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dATABASEQLBHDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_CongCu
            // 
            this.grb_CongCu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grb_CongCu.Controls.Add(this.bnThoat);
            this.grb_CongCu.Controls.Add(this.bnThem);
            this.grb_CongCu.Controls.Add(this.btnUndo);
            this.grb_CongCu.Controls.Add(this.btnThemSanPham);
            this.grb_CongCu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_CongCu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grb_CongCu.Location = new System.Drawing.Point(30, 152);
            this.grb_CongCu.Name = "grb_CongCu";
            this.grb_CongCu.Size = new System.Drawing.Size(171, 469);
            this.grb_CongCu.TabIndex = 3;
            this.grb_CongCu.TabStop = false;
            this.grb_CongCu.Text = "Công Cụ:";
            // 
            // bnThoat
            // 
            this.bnThoat.BackColor = System.Drawing.Color.Transparent;
            this.bnThoat.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bnThoat.Location = new System.Drawing.Point(22, 338);
            this.bnThoat.Name = "bnThoat";
            this.bnThoat.Size = new System.Drawing.Size(123, 50);
            this.bnThoat.TabIndex = 55;
            this.bnThoat.Text = "Thoát";
            this.bnThoat.UseVisualStyleBackColor = false;
            this.bnThoat.Click += new System.EventHandler(this.bnThoat_Click);
            // 
            // bnThem
            // 
            this.bnThem.BackColor = System.Drawing.Color.Transparent;
            this.bnThem.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnThem.ForeColor = System.Drawing.Color.Green;
            this.bnThem.Location = new System.Drawing.Point(22, 87);
            this.bnThem.Name = "bnThem";
            this.bnThem.Size = new System.Drawing.Size(123, 50);
            this.bnThem.TabIndex = 52;
            this.bnThem.Text = "Nhập hàng";
            this.bnThem.UseVisualStyleBackColor = false;
            this.bnThem.Click += new System.EventHandler(this.bnThem_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.Transparent;
            this.btnUndo.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUndo.Location = new System.Drawing.Point(22, 172);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(123, 50);
            this.btnUndo.TabIndex = 53;
            this.btnUndo.Text = "Hoàn tác";
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnThemSanPham
            // 
            this.btnThemSanPham.BackColor = System.Drawing.Color.Transparent;
            this.btnThemSanPham.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSanPham.ForeColor = System.Drawing.Color.Navy;
            this.btnThemSanPham.Location = new System.Drawing.Point(22, 257);
            this.btnThemSanPham.Name = "btnThemSanPham";
            this.btnThemSanPham.Size = new System.Drawing.Size(123, 50);
            this.btnThemSanPham.TabIndex = 54;
            this.btnThemSanPham.Text = "Thêm sản phẩm";
            this.btnThemSanPham.UseVisualStyleBackColor = false;
            this.btnThemSanPham.Click += new System.EventHandler(this.btnThemSanPham_Click);
            // 
            // grbNhaCungCap
            // 
            this.grbNhaCungCap.Controls.Add(this.dgvProduct);
            this.grbNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNhaCungCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grbNhaCungCap.Location = new System.Drawing.Point(217, 282);
            this.grbNhaCungCap.Name = "grbNhaCungCap";
            this.grbNhaCungCap.Size = new System.Drawing.Size(839, 352);
            this.grbNhaCungCap.TabIndex = 23;
            this.grbNhaCungCap.TabStop = false;
            this.grbNhaCungCap.Text = "Nhà cung cấp";
            // 
            // dgvProduct
            // 
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(6, 25);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.Size = new System.Drawing.Size(827, 314);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1026, 58);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(301, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhà cung cấp";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dATABASEQLBHDataSet11
            // 
            this.dATABASEQLBHDataSet11.DataSetName = "DATABASEQLBHDataSet11";
            this.dATABASEQLBHDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.dATABASEQLBHDataSet11;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.txtMaSP);
            this.groupBox2.Controls.Add(this.lb2);
            this.groupBox2.Controls.Add(this.lb1);
            this.groupBox2.Location = new System.Drawing.Point(217, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 109);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sản phẩm";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(138, 66);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(357, 29);
            this.txtName.TabIndex = 1;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSP.Location = new System.Drawing.Point(138, 29);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(357, 29);
            this.txtMaSP.TabIndex = 1;
            this.txtMaSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaSP_KeyPress);
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(17, 69);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(105, 21);
            this.lb2.TabIndex = 0;
            this.lb2.Text = "Tên sản phẩm";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(18, 29);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(104, 21);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Mã sản phẩm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNhap);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtquantity);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(734, 157);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 109);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "nhập hàng";
            // 
            // txtNhap
            // 
            this.txtNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhap.Location = new System.Drawing.Point(125, 66);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(163, 29);
            this.txtNhap.TabIndex = 1;
            this.txtNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhap_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số lượng nhập";
            // 
            // txtquantity
            // 
            this.txtquantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantity.Location = new System.Drawing.Point(125, 29);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.ReadOnly = true;
            this.txtquantity.Size = new System.Drawing.Size(163, 29);
            this.txtquantity.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số lượng";
            // 
            // fmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1068, 655);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbNhaCungCap);
            this.Controls.Add(this.grb_CongCu);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmNhaCungCap";
            this.Text = "Nhà cung cấp";
            this.Load += new System.EventHandler(this.fmNhaCungCap_Load);
            this.grb_CongCu.ResumeLayout(false);
            this.grbNhaCungCap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dATABASEQLBHDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_CongCu;
        private System.Windows.Forms.Button bnThoat;
        private System.Windows.Forms.Button bnThem;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnThemSanPham;
        private System.Windows.Forms.GroupBox grbNhaCungCap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private DATABASEQLBHDataSet11 dATABASEQLBHDataSet11;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DATABASEQLBHDataSet11TableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Label label3;
    }
}