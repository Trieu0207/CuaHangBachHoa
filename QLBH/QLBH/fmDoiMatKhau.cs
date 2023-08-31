using BUS;
using DocumentFormat.OpenXml.Drawing;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class fmDoiMatKhau : Form
    {
        BUS_QLBH bus = new BUS_QLBH();
        public fmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void fmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void reset()
        {
            txtName.Text = "";
            txtOldpass.Text = "";
            txtNewpass.Text = "";
            txtRepass.Text = "";
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if(txtNewpass.Text.Equals(txtRepass.Text) == false)
            {
                MessageBox.Show("Mật khẩu mới và mật khẩu nhập lại không giống nhau");
            }
            else
            {
                if (txtName.Text != "" && txtOldpass.Text != "" && txtNewpass.Text != "" && txtRepass.Text != "")
                {
                    if (bus.check_user(txtName.Text, txtOldpass.Text) == true)
                    {
                        bool result = bus.changePass(txtName.Text, txtNewpass.Text);
                        if (result == true)
                        {
                            MessageBox.Show("Đổi mật khẩu thành công");
                            reset();

                        }
                        else MessageBox.Show("Đổi mật khẩu thất bại");
                    }
                    else MessageBox.Show("Tài khoản không tồn tại");
                }
                else MessageBox.Show("Đổi mật khẩu thất bại");
            }
        }

        private void txtRepass_TextChanged(object sender, EventArgs e)
        {
            if (txtNewpass.Text.Equals(txtRepass.Text) == false)
            {
                warning1.Visible = true;
                warning2.Visible = true;
            }
            else
            {
                warning1.Visible = false;
                warning2.Visible = false;
            }
            
        }

        private void bnHuyBo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cb1_CheckedChanged(object sender, EventArgs e)
        {
            if(cb1.Checked)
            {
                txtOldpass.PasswordChar = '\0';
            } 
            else txtOldpass.PasswordChar = '*';

        }

        private void cb2_CheckedChanged(object sender, EventArgs e)
        {
            if (cb2.Checked)
            {
                txtNewpass.PasswordChar = '\0';
            }
            else txtNewpass.PasswordChar = '*';
        }

        private void cb3_CheckedChanged(object sender, EventArgs e)
        {

            if (cb3.Checked)
            {
                txtRepass.PasswordChar = '\0';
            }
            else txtRepass.PasswordChar = '*';
        }
    }
}
