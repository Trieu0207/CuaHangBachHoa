
namespace QLBH
{
    partial class fmLoaiSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmLoaiSP));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grb_CongCu = new System.Windows.Forms.GroupBox();
            this.bnThoat = new System.Windows.Forms.Button();
            this.bnThem = new System.Windows.Forms.Button();
            this.bnSua = new System.Windows.Forms.Button();
            this.bnXoa = new System.Windows.Forms.Button();
            this.gvLoaiSanPham = new System.Windows.Forms.GroupBox();
            this.dgvLoaiSP = new System.Windows.Forms.DataGridView();
            this.dATABASEQLBHDataSet6 = new QLBH.DATABASEQLBHDataSet6();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new QLBH.DATABASEQLBHDataSet6TableAdapters.CategoryTableAdapter();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.grb_CongCu.SuspendLayout();
            this.gvLoaiSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATABASEQLBHDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.gbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 76);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(263, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông Tin Loại Sản Phẩm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grb_CongCu
            // 
            this.grb_CongCu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grb_CongCu.Controls.Add(this.bnThoat);
            this.grb_CongCu.Controls.Add(this.bnThem);
            this.grb_CongCu.Controls.Add(this.bnSua);
            this.grb_CongCu.Controls.Add(this.bnXoa);
            this.grb_CongCu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_CongCu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grb_CongCu.Location = new System.Drawing.Point(23, 175);
            this.grb_CongCu.Name = "grb_CongCu";
            this.grb_CongCu.Size = new System.Drawing.Size(171, 441);
            this.grb_CongCu.TabIndex = 2;
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
            this.bnThem.Text = "Thêm";
            this.bnThem.UseVisualStyleBackColor = false;
            this.bnThem.Click += new System.EventHandler(this.bnThem_Click);
            // 
            // bnSua
            // 
            this.bnSua.BackColor = System.Drawing.Color.Transparent;
            this.bnSua.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bnSua.Location = new System.Drawing.Point(22, 172);
            this.bnSua.Name = "bnSua";
            this.bnSua.Size = new System.Drawing.Size(123, 50);
            this.bnSua.TabIndex = 53;
            this.bnSua.Text = "Sửa";
            this.bnSua.UseVisualStyleBackColor = false;
            this.bnSua.Click += new System.EventHandler(this.bnSua_Click);
            // 
            // bnXoa
            // 
            this.bnXoa.BackColor = System.Drawing.Color.Transparent;
            this.bnXoa.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnXoa.ForeColor = System.Drawing.Color.Red;
            this.bnXoa.Location = new System.Drawing.Point(22, 257);
            this.bnXoa.Name = "bnXoa";
            this.bnXoa.Size = new System.Drawing.Size(123, 50);
            this.bnXoa.TabIndex = 54;
            this.bnXoa.Text = "Xóa";
            this.bnXoa.UseVisualStyleBackColor = false;
            this.bnXoa.Click += new System.EventHandler(this.bnXoa_Click);
            // 
            // gvLoaiSanPham
            // 
            this.gvLoaiSanPham.Controls.Add(this.dgvLoaiSP);
            this.gvLoaiSanPham.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvLoaiSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gvLoaiSanPham.Location = new System.Drawing.Point(210, 291);
            this.gvLoaiSanPham.Name = "gvLoaiSanPham";
            this.gvLoaiSanPham.Size = new System.Drawing.Size(663, 342);
            this.gvLoaiSanPham.TabIndex = 22;
            this.gvLoaiSanPham.TabStop = false;
            this.gvLoaiSanPham.Text = "Loại Sản Phẩm";
            // 
            // dgvLoaiSP
            // 
            this.dgvLoaiSP.AutoGenerateColumns = false;
            this.dgvLoaiSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiSP.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoaiSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryID,
            this.categoryname,
            this.CategoryDescription});
            this.dgvLoaiSP.DataSource = this.categoryBindingSource;
            this.dgvLoaiSP.Location = new System.Drawing.Point(18, 29);
            this.dgvLoaiSP.Name = "dgvLoaiSP";
            this.dgvLoaiSP.ReadOnly = true;
            this.dgvLoaiSP.RowHeadersWidth = 51;
            this.dgvLoaiSP.RowTemplate.Height = 24;
            this.dgvLoaiSP.Size = new System.Drawing.Size(639, 408);
            this.dgvLoaiSP.TabIndex = 2;
            this.dgvLoaiSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiSP_CellClick);
            // 
            // dATABASEQLBHDataSet6
            // 
            this.dATABASEQLBHDataSet6.DataSetName = "DATABASEQLBHDataSet6";
            this.dATABASEQLBHDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.dATABASEQLBHDataSet6;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // gbInfo
            // 
            this.gbInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbInfo.Controls.Add(this.txtDes);
            this.gbInfo.Controls.Add(this.txtid);
            this.gbInfo.Controls.Add(this.txtname);
            this.gbInfo.Controls.Add(this.label4);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Location = new System.Drawing.Point(200, 133);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(667, 152);
            this.gbInfo.TabIndex = 23;
            this.gbInfo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên loại sản phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mô tả:";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(185, 59);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(345, 33);
            this.txtname.TabIndex = 1;
            // 
            // txtDes
            // 
            this.txtDes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDes.Location = new System.Drawing.Point(185, 99);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(345, 33);
            this.txtDes.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã loại sản phẩm";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(185, 20);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(345, 33);
            this.txtid.TabIndex = 1;
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid_KeyPress);
            // 
            // CategoryID
            // 
            this.CategoryID.DataPropertyName = "CategoryID";
            this.CategoryID.HeaderText = "CategoryID";
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.ReadOnly = true;
            // 
            // categoryname
            // 
            this.categoryname.DataPropertyName = "categoryname";
            this.categoryname.HeaderText = "categoryname";
            this.categoryname.Name = "categoryname";
            this.categoryname.ReadOnly = true;
            // 
            // CategoryDescription
            // 
            this.CategoryDescription.DataPropertyName = "CategoryDescription";
            this.CategoryDescription.HeaderText = "CategoryDescription";
            this.CategoryDescription.Name = "CategoryDescription";
            this.CategoryDescription.ReadOnly = true;
            // 
            // fmLoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(922, 645);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.gvLoaiSanPham);
            this.Controls.Add(this.grb_CongCu);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmLoaiSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại sản phẩm";
            this.Load += new System.EventHandler(this.fmLoaiSP_Load);
            this.groupBox1.ResumeLayout(false);
            this.grb_CongCu.ResumeLayout(false);
            this.gvLoaiSanPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATABASEQLBHDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grb_CongCu;
        private System.Windows.Forms.GroupBox gvLoaiSanPham;
        private System.Windows.Forms.DataGridView dgvLoaiSP;
        private System.Windows.Forms.Button bnThoat;
        private System.Windows.Forms.Button bnThem;
        private System.Windows.Forms.Button bnSua;
        private System.Windows.Forms.Button bnXoa;
        private DATABASEQLBHDataSet6 dATABASEQLBHDataSet6;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private DATABASEQLBHDataSet6TableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryname;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryDescription;
    }
}