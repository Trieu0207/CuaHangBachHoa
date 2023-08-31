using BUS;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLBH
{
    public partial class fmDangNhap : Form
    {
        BUS_QLBH bus = new BUS_QLBH();
        public fmDangNhap()
        {
            InitializeComponent();
        }

        private void ptbLogin1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_QuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fmQuenMatKhau fmQMK = new fmQuenMatKhau();
            fmQMK.Show();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            DTO_UserApp user = bus.get1User(txtUsername.Text, txtPassword.Text);
            if (user != null)
            {
                BUS_QLBH.currentUser = user;
                this.Hide();
                fmTrangChu fmTrangChu = new fmTrangChu();
                fmTrangChu.ShowDialog();
                this.Close();
            }
            else MessageBox.Show("Tài khoảng hoặc mật khẩu của bạn không chính xác");
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void fmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void bnHuyBo_Click(object sender, EventArgs e)
        {

        }
    }
}
