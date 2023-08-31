
namespace QLBH
{
    partial class fmQuenMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmQuenMatKhau));
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.bnLayLaiMatKhau = new System.Windows.Forms.Button();
            this.ptbsignup1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbsignup1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKetQua
            // 
            this.txtKetQua.BackColor = System.Drawing.Color.LightCoral;
            this.txtKetQua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKetQua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetQua.ForeColor = System.Drawing.Color.Black;
            this.txtKetQua.Location = new System.Drawing.Point(214, 302);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(263, 34);
            this.txtKetQua.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(130, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "Kết Quả";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(214, 242);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(263, 34);
            this.txtEmail.TabIndex = 16;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.Black;
            this.lb1.Location = new System.Drawing.Point(130, 249);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(59, 28);
            this.lb1.TabIndex = 15;
            this.lb1.Text = "Email";
            // 
            // bnLayLaiMatKhau
            // 
            this.bnLayLaiMatKhau.AutoSize = true;
            this.bnLayLaiMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bnLayLaiMatKhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnLayLaiMatKhau.ForeColor = System.Drawing.Color.Green;
            this.bnLayLaiMatKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnLayLaiMatKhau.Location = new System.Drawing.Point(229, 372);
            this.bnLayLaiMatKhau.Name = "bnLayLaiMatKhau";
            this.bnLayLaiMatKhau.Size = new System.Drawing.Size(185, 50);
            this.bnLayLaiMatKhau.TabIndex = 20;
            this.bnLayLaiMatKhau.Text = "Lấy Lại Mật Khẩu";
            this.bnLayLaiMatKhau.UseVisualStyleBackColor = false;
            // 
            // ptbsignup1
            // 
            this.ptbsignup1.Image = global::QLBH.Properties.Resources.user_icons;
            this.ptbsignup1.InitialImage = null;
            this.ptbsignup1.Location = new System.Drawing.Point(214, 23);
            this.ptbsignup1.Name = "ptbsignup1";
            this.ptbsignup1.Size = new System.Drawing.Size(179, 169);
            this.ptbsignup1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbsignup1.TabIndex = 21;
            this.ptbsignup1.TabStop = false;
            // 
            // fmQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 484);
            this.Controls.Add(this.ptbsignup1);
            this.Controls.Add(this.bnLayLaiMatKhau);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lb1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmQuenMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quên Mật Khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.ptbsignup1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button bnLayLaiMatKhau;
        private System.Windows.Forms.PictureBox ptbsignup1;
    }
}