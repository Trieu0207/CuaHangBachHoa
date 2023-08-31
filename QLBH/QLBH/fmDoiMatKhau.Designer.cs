
namespace QLBH
{
    partial class fmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmDoiMatKhau));
            this.lb1 = new System.Windows.Forms.Label();
            this.txtOldpass = new System.Windows.Forms.TextBox();
            this.txtNewpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRepass = new System.Windows.Forms.TextBox();
            this.txtxacnhanmk = new System.Windows.Forms.Label();
            this.btnDongY = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bnHuyBo = new System.Windows.Forms.Button();
            this.ptbsignup1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.warning2 = new System.Windows.Forms.Label();
            this.warning1 = new System.Windows.Forms.Label();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbsignup1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.Black;
            this.lb1.Location = new System.Drawing.Point(93, 360);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(99, 21);
            this.lb1.TabIndex = 3;
            this.lb1.Text = "Mật Khẩu Cũ";
            // 
            // txtOldpass
            // 
            this.txtOldpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOldpass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldpass.ForeColor = System.Drawing.Color.Black;
            this.txtOldpass.Location = new System.Drawing.Point(283, 354);
            this.txtOldpass.Name = "txtOldpass";
            this.txtOldpass.PasswordChar = '*';
            this.txtOldpass.Size = new System.Drawing.Size(250, 29);
            this.txtOldpass.TabIndex = 4;
            // 
            // txtNewpass
            // 
            this.txtNewpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewpass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewpass.ForeColor = System.Drawing.Color.Black;
            this.txtNewpass.Location = new System.Drawing.Point(283, 414);
            this.txtNewpass.Name = "txtNewpass";
            this.txtNewpass.PasswordChar = '*';
            this.txtNewpass.Size = new System.Drawing.Size(250, 29);
            this.txtNewpass.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(93, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mật Khẩu Mới";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtRepass
            // 
            this.txtRepass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRepass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepass.ForeColor = System.Drawing.Color.Black;
            this.txtRepass.Location = new System.Drawing.Point(283, 473);
            this.txtRepass.Name = "txtRepass";
            this.txtRepass.PasswordChar = '*';
            this.txtRepass.Size = new System.Drawing.Size(250, 29);
            this.txtRepass.TabIndex = 8;
            this.txtRepass.TextChanged += new System.EventHandler(this.txtRepass_TextChanged);
            // 
            // txtxacnhanmk
            // 
            this.txtxacnhanmk.AutoSize = true;
            this.txtxacnhanmk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtxacnhanmk.ForeColor = System.Drawing.Color.Black;
            this.txtxacnhanmk.Location = new System.Drawing.Point(93, 479);
            this.txtxacnhanmk.Name = "txtxacnhanmk";
            this.txtxacnhanmk.Size = new System.Drawing.Size(146, 21);
            this.txtxacnhanmk.TabIndex = 7;
            this.txtxacnhanmk.Text = "Xác Nhận Mật Khẩu";
            // 
            // btnDongY
            // 
            this.btnDongY.AutoSize = true;
            this.btnDongY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDongY.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongY.ForeColor = System.Drawing.Color.Green;
            this.btnDongY.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDongY.Location = new System.Drawing.Point(164, 561);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(121, 50);
            this.btnDongY.TabIndex = 13;
            this.btnDongY.Text = "Đồng Ý";
            this.btnDongY.UseVisualStyleBackColor = false;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(220, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "Đổi Mật Khẩu";
            // 
            // bnHuyBo
            // 
            this.bnHuyBo.AutoSize = true;
            this.bnHuyBo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bnHuyBo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnHuyBo.ForeColor = System.Drawing.Color.Red;
            this.bnHuyBo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnHuyBo.Location = new System.Drawing.Point(320, 561);
            this.bnHuyBo.Name = "bnHuyBo";
            this.bnHuyBo.Size = new System.Drawing.Size(119, 50);
            this.bnHuyBo.TabIndex = 15;
            this.bnHuyBo.Text = "Hủy Bỏ";
            this.bnHuyBo.UseVisualStyleBackColor = false;
            this.bnHuyBo.Click += new System.EventHandler(this.bnHuyBo_Click);
            // 
            // ptbsignup1
            // 
            this.ptbsignup1.Image = global::QLBH.Properties.Resources.user_icons;
            this.ptbsignup1.InitialImage = null;
            this.ptbsignup1.Location = new System.Drawing.Point(227, 23);
            this.ptbsignup1.Name = "ptbsignup1";
            this.ptbsignup1.Size = new System.Drawing.Size(157, 180);
            this.ptbsignup1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbsignup1.TabIndex = 2;
            this.ptbsignup1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(93, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên đăng nhập";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(283, 302);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 29);
            this.txtName.TabIndex = 4;
            // 
            // warning2
            // 
            this.warning2.AutoSize = true;
            this.warning2.ForeColor = System.Drawing.Color.Red;
            this.warning2.Location = new System.Drawing.Point(282, 457);
            this.warning2.Name = "warning2";
            this.warning2.Size = new System.Drawing.Size(157, 13);
            this.warning2.TabIndex = 16;
            this.warning2.Text = "Mật khẩu không giống nhau";
            this.warning2.Visible = false;
            // 
            // warning1
            // 
            this.warning1.AutoSize = true;
            this.warning1.ForeColor = System.Drawing.Color.Red;
            this.warning1.Location = new System.Drawing.Point(282, 398);
            this.warning1.Name = "warning1";
            this.warning1.Size = new System.Drawing.Size(157, 13);
            this.warning1.TabIndex = 16;
            this.warning1.Text = "Mật khẩu không giống nhau";
            this.warning1.Visible = false;
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(539, 360);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(47, 17);
            this.cb1.TabIndex = 18;
            this.cb1.Text = "Xem";
            this.cb1.UseVisualStyleBackColor = true;
            this.cb1.CheckedChanged += new System.EventHandler(this.cb1_CheckedChanged);
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Location = new System.Drawing.Point(539, 424);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(47, 17);
            this.cb2.TabIndex = 18;
            this.cb2.Text = "Xem";
            this.cb2.UseVisualStyleBackColor = true;
            this.cb2.CheckedChanged += new System.EventHandler(this.cb2_CheckedChanged);
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Location = new System.Drawing.Point(539, 479);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(47, 17);
            this.cb3.TabIndex = 18;
            this.cb3.Text = "Xem";
            this.cb3.UseVisualStyleBackColor = true;
            this.cb3.CheckedChanged += new System.EventHandler(this.cb3_CheckedChanged);
            // 
            // fmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(641, 623);
            this.Controls.Add(this.cb3);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.warning1);
            this.Controls.Add(this.warning2);
            this.Controls.Add(this.bnHuyBo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.txtRepass);
            this.Controls.Add(this.txtxacnhanmk);
            this.Controls.Add(this.txtNewpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOldpass);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.ptbsignup1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Mật Khẩu";
            this.Load += new System.EventHandler(this.fmDoiMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbsignup1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbsignup1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox txtOldpass;
        private System.Windows.Forms.TextBox txtNewpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRepass;
        private System.Windows.Forms.Label txtxacnhanmk;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bnHuyBo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.Label warning2;
        public System.Windows.Forms.Label warning1;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.CheckBox cb3;
    }
}