
namespace QLBH
{
    partial class fmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmDangNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbl_QuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.bnHuyBo = new System.Windows.Forms.Button();
            this.ptbsignup1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptbLogin2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbsignup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogin2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(201, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(179, 306);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(220, 29);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(179, 379);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(220, 29);
            this.txtPassword.TabIndex = 5;
            // 
            // lbl_QuenMatKhau
            // 
            this.lbl_QuenMatKhau.AutoSize = true;
            this.lbl_QuenMatKhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QuenMatKhau.ForeColor = System.Drawing.Color.Black;
            this.lbl_QuenMatKhau.LinkColor = System.Drawing.Color.Red;
            this.lbl_QuenMatKhau.Location = new System.Drawing.Point(207, 452);
            this.lbl_QuenMatKhau.Name = "lbl_QuenMatKhau";
            this.lbl_QuenMatKhau.Size = new System.Drawing.Size(124, 21);
            this.lbl_QuenMatKhau.TabIndex = 6;
            this.lbl_QuenMatKhau.TabStop = true;
            this.lbl_QuenMatKhau.Text = "Quên mật khẩu?";
            this.lbl_QuenMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_QuenMatKhau_LinkClicked);
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.AutoSize = true;
            this.btnDangnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDangnhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangnhap.ForeColor = System.Drawing.Color.Green;
            this.btnDangnhap.Location = new System.Drawing.Point(125, 509);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(129, 49);
            this.btnDangnhap.TabIndex = 8;
            this.btnDangnhap.Text = "Đăng Nhập";
            this.btnDangnhap.UseVisualStyleBackColor = false;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // bnHuyBo
            // 
            this.bnHuyBo.AutoSize = true;
            this.bnHuyBo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bnHuyBo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnHuyBo.ForeColor = System.Drawing.Color.Red;
            this.bnHuyBo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnHuyBo.Location = new System.Drawing.Point(271, 509);
            this.bnHuyBo.Name = "bnHuyBo";
            this.bnHuyBo.Size = new System.Drawing.Size(128, 50);
            this.bnHuyBo.TabIndex = 16;
            this.bnHuyBo.Text = "Hủy Bỏ";
            this.bnHuyBo.UseVisualStyleBackColor = false;
            this.bnHuyBo.Click += new System.EventHandler(this.bnHuyBo_Click);
            // 
            // ptbsignup1
            // 
            this.ptbsignup1.Image = global::QLBH.Properties.Resources.user_icons;
            this.ptbsignup1.InitialImage = null;
            this.ptbsignup1.Location = new System.Drawing.Point(194, 27);
            this.ptbsignup1.Name = "ptbsignup1";
            this.ptbsignup1.Size = new System.Drawing.Size(157, 180);
            this.ptbsignup1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbsignup1.TabIndex = 9;
            this.ptbsignup1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLBH.Properties.Resources.k22;
            this.pictureBox1.Location = new System.Drawing.Point(113, 369);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ptbLogin2
            // 
            this.ptbLogin2.Image = global::QLBH.Properties.Resources.user;
            this.ptbLogin2.Location = new System.Drawing.Point(113, 299);
            this.ptbLogin2.Name = "ptbLogin2";
            this.ptbLogin2.Size = new System.Drawing.Size(61, 48);
            this.ptbLogin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLogin2.TabIndex = 2;
            this.ptbLogin2.TabStop = false;
            // 
            // fmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(544, 616);
            this.Controls.Add(this.bnHuyBo);
            this.Controls.Add(this.ptbsignup1);
            this.Controls.Add(this.btnDangnhap);
            this.Controls.Add(this.lbl_QuenMatKhau);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.ptbLogin2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.fmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbsignup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogin2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbLogin2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lbl_QuenMatKhau;
        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.PictureBox ptbsignup1;
        private System.Windows.Forms.Button bnHuyBo;
    }
}