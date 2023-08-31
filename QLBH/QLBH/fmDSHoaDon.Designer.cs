
namespace QLBH
{
    partial class fmDSHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmDSHoaDon));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bnChiTiet = new System.Windows.Forms.Button();
            this.grbHoaDon = new System.Windows.Forms.GroupBox();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.BillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dATABASEQLBHDataSet10 = new QLBH.DATABASEQLBHDataSet10();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.btnDuyet = new System.Windows.Forms.Button();
            this.billBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dATABASEQLBHDataSet9 = new QLBH.DATABASEQLBHDataSet9();
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dATABASEQLBHDataSet8 = new QLBH.DATABASEQLBHDataSet8();
            this.txtBillid = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvBillDetail = new System.Windows.Forms.DataGridView();
            this.billTableAdapter = new QLBH.DATABASEQLBHDataSet8TableAdapters.BillTableAdapter();
            this.txtBillid2 = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtUserid = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.gbinfo = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.billTableAdapter1 = new QLBH.DATABASEQLBHDataSet9TableAdapters.BillTableAdapter();
            this.billTableAdapter2 = new QLBH.DATABASEQLBHDataSet10TableAdapters.BillTableAdapter();
            this.txtDelBill = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grbHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATABASEQLBHDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATABASEQLBHDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATABASEQLBHDataSet8)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetail)).BeginInit();
            this.gbinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(228, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH HÓA ĐƠN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bnChiTiet
            // 
            this.bnChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bnChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bnChiTiet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnChiTiet.ForeColor = System.Drawing.Color.Black;
            this.bnChiTiet.Location = new System.Drawing.Point(325, 25);
            this.bnChiTiet.Name = "bnChiTiet";
            this.bnChiTiet.Size = new System.Drawing.Size(124, 31);
            this.bnChiTiet.TabIndex = 60;
            this.bnChiTiet.Text = "Tìm kiếm";
            this.bnChiTiet.UseVisualStyleBackColor = false;
            this.bnChiTiet.Click += new System.EventHandler(this.bnChiTiet_Click);
            // 
            // grbHoaDon
            // 
            this.grbHoaDon.Controls.Add(this.cbYear);
            this.grbHoaDon.Controls.Add(this.dgvHoaDon);
            this.grbHoaDon.Controls.Add(this.cbMonth);
            this.grbHoaDon.Controls.Add(this.cbDay);
            this.grbHoaDon.Controls.Add(this.btnDuyet);
            this.grbHoaDon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbHoaDon.Location = new System.Drawing.Point(12, 224);
            this.grbHoaDon.Name = "grbHoaDon";
            this.grbHoaDon.Size = new System.Drawing.Size(683, 464);
            this.grbHoaDon.TabIndex = 61;
            this.grbHoaDon.TabStop = false;
            this.grbHoaDon.Text = "Hóa Đơn";
            // 
            // cbYear
            // 
            this.cbYear.Enabled = false;
            this.cbYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(197, 25);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(107, 29);
            this.cbYear.TabIndex = 68;
            this.cbYear.Enter += new System.EventHandler(this.cb_Enter);
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AutoGenerateColumns = false;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillID,
            this.Time,
            this.UserID,
            this.totalprice});
            this.dgvHoaDon.DataSource = this.billBindingSource2;
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 66);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(676, 392);
            this.dgvHoaDon.TabIndex = 1;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // BillID
            // 
            this.BillID.DataPropertyName = "BillID";
            this.BillID.HeaderText = "BillID";
            this.BillID.Name = "BillID";
            this.BillID.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "UserID";
            this.UserID.HeaderText = "UserID";
            this.UserID.Name = "UserID";
            // 
            // totalprice
            // 
            this.totalprice.DataPropertyName = "totalprice";
            this.totalprice.HeaderText = "totalprice";
            this.totalprice.Name = "totalprice";
            // 
            // billBindingSource2
            // 
            this.billBindingSource2.DataMember = "Bill";
            this.billBindingSource2.DataSource = this.dATABASEQLBHDataSet10;
            // 
            // dATABASEQLBHDataSet10
            // 
            this.dATABASEQLBHDataSet10.DataSetName = "DATABASEQLBHDataSet10";
            this.dATABASEQLBHDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbMonth
            // 
            this.cbMonth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbMonth.Location = new System.Drawing.Point(97, 25);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(94, 29);
            this.cbMonth.TabIndex = 68;
            this.cbMonth.Text = "tháng";
            this.cbMonth.Enter += new System.EventHandler(this.cb_Enter);
            this.cbMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPress);
            // 
            // cbDay
            // 
            this.cbDay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbDay.Location = new System.Drawing.Point(6, 25);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(85, 29);
            this.cbDay.TabIndex = 68;
            this.cbDay.Text = "Ngày";
            this.cbDay.Enter += new System.EventHandler(this.cb_Enter);
            this.cbDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPress);
            // 
            // btnDuyet
            // 
            this.btnDuyet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDuyet.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDuyet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuyet.ForeColor = System.Drawing.Color.Black;
            this.btnDuyet.Location = new System.Drawing.Point(310, 25);
            this.btnDuyet.Name = "btnDuyet";
            this.btnDuyet.Size = new System.Drawing.Size(124, 29);
            this.btnDuyet.TabIndex = 60;
            this.btnDuyet.Text = "Duyệt";
            this.btnDuyet.UseVisualStyleBackColor = false;
            this.btnDuyet.Click += new System.EventHandler(this.btnDuyet_Click);
            // 
            // billBindingSource1
            // 
            this.billBindingSource1.DataMember = "Bill";
            this.billBindingSource1.DataSource = this.dATABASEQLBHDataSet9;
            // 
            // dATABASEQLBHDataSet9
            // 
            this.dATABASEQLBHDataSet9.DataSetName = "DATABASEQLBHDataSet9";
            this.dATABASEQLBHDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billBindingSource
            // 
            this.billBindingSource.DataMember = "Bill";
            this.billBindingSource.DataSource = this.dATABASEQLBHDataSet8;
            // 
            // dATABASEQLBHDataSet8
            // 
            this.dATABASEQLBHDataSet8.DataSetName = "DATABASEQLBHDataSet8";
            this.dATABASEQLBHDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBillid
            // 
            this.txtBillid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillid.ForeColor = System.Drawing.Color.Black;
            this.txtBillid.Location = new System.Drawing.Point(6, 27);
            this.txtBillid.Name = "txtBillid";
            this.txtBillid.Size = new System.Drawing.Size(313, 29);
            this.txtBillid.TabIndex = 62;
            this.txtBillid.Text = "mã hóa đơn";
            this.txtBillid.Click += new System.EventHandler(this.txtBillid_Click);
            this.txtBillid.TextChanged += new System.EventHandler(this.txtChiTiet_TextChanged);
            this.txtBillid.Enter += new System.EventHandler(this.txtChiTiet_Enter);
            this.txtBillid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBillid_KeyPress);
            this.txtBillid.Leave += new System.EventHandler(this.txtChiTiet_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvBillDetail);
            this.groupBox2.Controls.Add(this.bnChiTiet);
            this.groupBox2.Controls.Add(this.txtBillid);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(701, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(572, 464);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // dgvBillDetail
            // 
            this.dgvBillDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBillDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvBillDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillDetail.Location = new System.Drawing.Point(0, 66);
            this.dgvBillDetail.Name = "dgvBillDetail";
            this.dgvBillDetail.RowHeadersWidth = 51;
            this.dgvBillDetail.RowTemplate.Height = 24;
            this.dgvBillDetail.Size = new System.Drawing.Size(566, 392);
            this.dgvBillDetail.TabIndex = 0;
            // 
            // billTableAdapter
            // 
            this.billTableAdapter.ClearBeforeFill = true;
            // 
            // txtBillid2
            // 
            this.txtBillid2.BackColor = System.Drawing.Color.White;
            this.txtBillid2.Enabled = false;
            this.txtBillid2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillid2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBillid2.Location = new System.Drawing.Point(169, 17);
            this.txtBillid2.Name = "txtBillid2";
            this.txtBillid2.ReadOnly = true;
            this.txtBillid2.Size = new System.Drawing.Size(223, 29);
            this.txtBillid2.TabIndex = 64;
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.White;
            this.txtTime.Enabled = false;
            this.txtTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTime.Location = new System.Drawing.Point(169, 63);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(223, 29);
            this.txtTime.TabIndex = 64;
            // 
            // txtUserid
            // 
            this.txtUserid.BackColor = System.Drawing.Color.White;
            this.txtUserid.Enabled = false;
            this.txtUserid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtUserid.Location = new System.Drawing.Point(599, 17);
            this.txtUserid.Name = "txtUserid";
            this.txtUserid.ReadOnly = true;
            this.txtUserid.Size = new System.Drawing.Size(223, 29);
            this.txtUserid.TabIndex = 64;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTotal.Location = new System.Drawing.Point(599, 63);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(223, 29);
            this.txtTotal.TabIndex = 64;
            // 
            // gbinfo
            // 
            this.gbinfo.Controls.Add(this.label5);
            this.gbinfo.Controls.Add(this.label3);
            this.gbinfo.Controls.Add(this.label4);
            this.gbinfo.Controls.Add(this.label2);
            this.gbinfo.Controls.Add(this.txtBillid2);
            this.gbinfo.Controls.Add(this.txtTotal);
            this.gbinfo.Controls.Add(this.txtTime);
            this.gbinfo.Controls.Add(this.txtUserid);
            this.gbinfo.Location = new System.Drawing.Point(18, 93);
            this.gbinfo.Name = "gbinfo";
            this.gbinfo.Size = new System.Drawing.Size(845, 122);
            this.gbinfo.TabIndex = 65;
            this.gbinfo.TabStop = false;
            this.gbinfo.Text = "Thông tin hóa đơn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(433, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 65;
            this.label5.Text = "Tổng giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 21);
            this.label3.TabIndex = 65;
            this.label3.Text = "Thời gian thanh toán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(433, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 21);
            this.label4.TabIndex = 65;
            this.label4.Text = "Nhân viên thanh toán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 65;
            this.label2.Text = "Mã hóa đơn";
            // 
            // billTableAdapter1
            // 
            this.billTableAdapter1.ClearBeforeFill = true;
            // 
            // billTableAdapter2
            // 
            this.billTableAdapter2.ClearBeforeFill = true;
            // 
            // txtDelBill
            // 
            this.txtDelBill.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelBill.Location = new System.Drawing.Point(884, 93);
            this.txtDelBill.Name = "txtDelBill";
            this.txtDelBill.Size = new System.Drawing.Size(181, 122);
            this.txtDelBill.TabIndex = 66;
            this.txtDelBill.Text = "Xóa hóa đơn";
            this.txtDelBill.UseVisualStyleBackColor = true;
            this.txtDelBill.Click += new System.EventHandler(this.txtDelBill_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1081, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 122);
            this.button2.TabIndex = 66;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fmDSHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 700);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtDelBill);
            this.Controls.Add(this.gbinfo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbHoaDon);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmDSHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Hóa Đơn";
            this.Load += new System.EventHandler(this.fmDSHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.grbHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATABASEQLBHDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATABASEQLBHDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATABASEQLBHDataSet8)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetail)).EndInit();
            this.gbinfo.ResumeLayout(false);
            this.gbinfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnChiTiet;
        private System.Windows.Forms.GroupBox grbHoaDon;
        private System.Windows.Forms.TextBox txtBillid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvBillDetail;
        private DATABASEQLBHDataSet8 dATABASEQLBHDataSet8;
        private System.Windows.Forms.BindingSource billBindingSource;
        private DATABASEQLBHDataSet8TableAdapters.BillTableAdapter billTableAdapter;
        private System.Windows.Forms.TextBox txtBillid2;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtUserid;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.GroupBox gbinfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private DATABASEQLBHDataSet9 dATABASEQLBHDataSet9;
        private System.Windows.Forms.BindingSource billBindingSource1;
        private DATABASEQLBHDataSet9TableAdapters.BillTableAdapter billTableAdapter1;
        private DATABASEQLBHDataSet10 dATABASEQLBHDataSet10;
        private System.Windows.Forms.BindingSource billBindingSource2;
        private DATABASEQLBHDataSet10TableAdapters.BillTableAdapter billTableAdapter2;
        private System.Windows.Forms.Button btnDuyet;
        private System.Windows.Forms.Button txtDelBill;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalprice;
    }
}