
namespace QLBH
{
    partial class fmQuanLyNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmQuanLyNguoiDung));
            this.lbTieude = new System.Windows.Forms.Label();
            this.grb_CongCu = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.picXoa = new System.Windows.Forms.PictureBox();
            this.picSua = new System.Windows.Forms.PictureBox();
            this.picThem = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.grbThongTinDN = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userAppBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dATABASEQLBHDataSet1 = new QLBH.DATABASEQLBHDataSet1();
            this.dgvThongTinDN_QLND = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.userAppTableAdapter = new QLBH.DATABASEQLBHDataSet1TableAdapters.UserAppTableAdapter();
            this.role = new System.Windows.Forms.ComboBox();
            this.grb_CongCu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThem)).BeginInit();
            this.grbThongTinDN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAppBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATABASEQLBHDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinDN_QLND)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTieude
            // 
            this.lbTieude.AutoSize = true;
            this.lbTieude.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieude.ForeColor = System.Drawing.Color.Blue;
            this.lbTieude.Location = new System.Drawing.Point(261, 77);
            this.lbTieude.Name = "lbTieude";
            this.lbTieude.Size = new System.Drawing.Size(255, 32);
            this.lbTieude.TabIndex = 0;
            this.lbTieude.Text = "Quản Lý Người Dùng";
            this.lbTieude.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grb_CongCu
            // 
            this.grb_CongCu.BackColor = System.Drawing.Color.PaleTurquoise;
            this.grb_CongCu.Controls.Add(this.button1);
            this.grb_CongCu.Controls.Add(this.btnXoa);
            this.grb_CongCu.Controls.Add(this.btnSua);
            this.grb_CongCu.Controls.Add(this.btnThem);
            this.grb_CongCu.Controls.Add(this.picXoa);
            this.grb_CongCu.Controls.Add(this.picSua);
            this.grb_CongCu.Controls.Add(this.picThem);
            this.grb_CongCu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_CongCu.ForeColor = System.Drawing.Color.Black;
            this.grb_CongCu.Location = new System.Drawing.Point(21, 32);
            this.grb_CongCu.Name = "grb_CongCu";
            this.grb_CongCu.Size = new System.Drawing.Size(186, 601);
            this.grb_CongCu.TabIndex = 1;
            this.grb_CongCu.TabStop = false;
            this.grb_CongCu.Text = "Công Cụ:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(19, 508);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 58);
            this.button1.TabIndex = 16;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(46, 405);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 36);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(46, 267);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(86, 40);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(46, 128);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 40);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // picXoa
            // 
            this.picXoa.Image = global::QLBH.Properties.Resources.images__1_;
            this.picXoa.Location = new System.Drawing.Point(46, 329);
            this.picXoa.Name = "picXoa";
            this.picXoa.Size = new System.Drawing.Size(86, 70);
            this.picXoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picXoa.TabIndex = 4;
            this.picXoa.TabStop = false;
            // 
            // picSua
            // 
            this.picSua.Image = global::QLBH.Properties.Resources.sua;
            this.picSua.Location = new System.Drawing.Point(46, 191);
            this.picSua.Name = "picSua";
            this.picSua.Size = new System.Drawing.Size(86, 70);
            this.picSua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSua.TabIndex = 3;
            this.picSua.TabStop = false;
            // 
            // picThem
            // 
            this.picThem.Image = global::QLBH.Properties.Resources.Sign_Add_icon_1;
            this.picThem.Location = new System.Drawing.Point(46, 41);
            this.picThem.Name = "picThem";
            this.picThem.Size = new System.Drawing.Size(86, 81);
            this.picThem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picThem.TabIndex = 2;
            this.picThem.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Nhân Viên ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(959, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật Khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(527, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quyền Hạn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(724, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên Đăng Nhập";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(310, 205);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(141, 29);
            this.txtid.TabIndex = 6;
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(945, 205);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(141, 29);
            this.txtPassword.TabIndex = 7;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(728, 205);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(141, 29);
            this.txtUsername.TabIndex = 9;
            // 
            // grbThongTinDN
            // 
            this.grbThongTinDN.Controls.Add(this.dataGridView1);
            this.grbThongTinDN.Controls.Add(this.dgvThongTinDN_QLND);
            this.grbThongTinDN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinDN.Location = new System.Drawing.Point(230, 245);
            this.grbThongTinDN.Name = "grbThongTinDN";
            this.grbThongTinDN.Size = new System.Drawing.Size(893, 388);
            this.grbThongTinDN.TabIndex = 10;
            this.grbThongTinDN.TabStop = false;
            this.grbThongTinDN.Text = "Thông Tin Đăng Nhập";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.EmployeeID,
            this.username,
            this.password,
            this.user_role});
            this.dataGridView1.DataSource = this.userAppBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(887, 349);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "EmployeeID";
            this.EmployeeID.HeaderText = "EmployeeID";
            this.EmployeeID.Name = "EmployeeID";
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "username";
            this.username.Name = "username";
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "password";
            this.password.Name = "password";
            // 
            // user_role
            // 
            this.user_role.DataPropertyName = "user_role";
            this.user_role.HeaderText = "user_role";
            this.user_role.Name = "user_role";
            // 
            // userAppBindingSource
            // 
            this.userAppBindingSource.DataMember = "UserApp";
            this.userAppBindingSource.DataSource = this.dATABASEQLBHDataSet1;
            // 
            // dATABASEQLBHDataSet1
            // 
            this.dATABASEQLBHDataSet1.DataSetName = "DATABASEQLBHDataSet1";
            this.dATABASEQLBHDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvThongTinDN_QLND
            // 
            this.dgvThongTinDN_QLND.BackgroundColor = System.Drawing.Color.White;
            this.dgvThongTinDN_QLND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinDN_QLND.Location = new System.Drawing.Point(0, 39);
            this.dgvThongTinDN_QLND.Name = "dgvThongTinDN_QLND";
            this.dgvThongTinDN_QLND.RowHeadersWidth = 51;
            this.dgvThongTinDN_QLND.RowTemplate.Height = 24;
            this.dgvThongTinDN_QLND.Size = new System.Drawing.Size(887, 349);
            this.dgvThongTinDN_QLND.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTieude);
            this.groupBox1.Location = new System.Drawing.Point(202, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 118);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // userAppTableAdapter
            // 
            this.userAppTableAdapter.ClearBeforeFill = true;
            // 
            // role
            // 
            this.role.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role.FormattingEnabled = true;
            this.role.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.role.Location = new System.Drawing.Point(531, 205);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(150, 29);
            this.role.TabIndex = 12;
            this.role.Text = "User";
            // 
            // fmQuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1156, 658);
            this.Controls.Add(this.role);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbThongTinDN);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grb_CongCu);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmQuanLyNguoiDung";
            this.Text = "Quản Lý Người Dùng";
            this.Load += new System.EventHandler(this.fmQuanLyNguoiDung_Load);
            this.grb_CongCu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThem)).EndInit();
            this.grbThongTinDN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAppBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATABASEQLBHDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinDN_QLND)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTieude;
        private System.Windows.Forms.GroupBox grb_CongCu;
        private System.Windows.Forms.PictureBox picXoa;
        private System.Windows.Forms.PictureBox picSua;
        private System.Windows.Forms.PictureBox picThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.GroupBox grbThongTinDN;
        private System.Windows.Forms.DataGridView dgvThongTinDN_QLND;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DATABASEQLBHDataSet1 dATABASEQLBHDataSet1;
        private System.Windows.Forms.BindingSource userAppBindingSource;
        private DATABASEQLBHDataSet1TableAdapters.UserAppTableAdapter userAppTableAdapter;
        private System.Windows.Forms.ComboBox role;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_role;
    }
}