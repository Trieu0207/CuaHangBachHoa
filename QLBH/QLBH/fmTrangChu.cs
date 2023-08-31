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

namespace QLBH
{
    public partial class fmTrangChu : Form
    {
        BUS_QLBH bus = new BUS_QLBH(); 
        public fmTrangChu()
        {
            InitializeComponent();
        }

      

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            fmQuanLyNguoiDung fmQLND = new fmQuanLyNguoiDung();
            //fmQLND.MdiParent = this;
            fmQLND.Show();
        }
 

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            fmChucVuNV fmCV = new fmChucVuNV();
            fmCV.Show();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            fmLoaiSP fmLSP = new fmLoaiSP();
            fmLSP.Show();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            fmNhaCungCap fmNCC = new fmNhaCungCap();
            fmNCC.Show();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmBanHang fmBH = new fmBanHang();
            fmBH.Show();

        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            fmDoiMatKhau fmDMK = new fmDoiMatKhau();
            fmDMK.Show();
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmDanhSachQLNhanVien fmDSNV = new fmDanhSachQLNhanVien();
            fmDSNV.Show();
        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            fmBangChamCong fmBCC = new fmBangChamCong();
            fmBCC.Show();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            fmSanPham fmSP = new fmSanPham();
            fmSP.Show();
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            fmDSHoaDon fmDSHD = new fmDSHoaDon();
            fmDSHD.Show();
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            fmTimKiemHD fmTkHD = new fmTimKiemHD();
            fmTkHD.Show();

        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            fmKhachHang fmKH = new fmKhachHang();
            fmKH.Show();

        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            fmThongKeDoanhThu fmTKDT = new fmThongKeDoanhThu();
            fmTKDT.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            fmBanHang fmBH = new fmBanHang();
            fmBH.Show();
        }

        private void picBanHag_Click(object sender, EventArgs e)
        {
            fmBanHang fmBH = new fmBanHang();
            fmBH.Show();
        }

        private void picSanPham1_Click(object sender, EventArgs e)
        {
            fmSanPham fmSP = new fmSanPham();
            fmSP.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            fmSanPham fmSP = new fmSanPham();
            fmSP.Show();
        }

        private void picNhanVien1_Click(object sender, EventArgs e)
        {
            fmDanhSachQLNhanVien fmDSNV = new fmDanhSachQLNhanVien();
            fmDSNV.Show();

        }

        private void label7_Click(object sender, EventArgs e)
        {
            fmDanhSachQLNhanVien fmDSNV = new fmDanhSachQLNhanVien();
            fmDSNV.Show();

        }

        private void picKhachHang1_Click(object sender, EventArgs e)
        {
            fmKhachHang fmKH = new fmKhachHang();
            fmKH.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            fmKhachHang fmKH = new fmKhachHang();
            fmKH.Show();
        }

        private void fmTrangChu_Load(object sender, EventArgs e)
        {
            
            if(BUS_QLBH.currentUser != null)
            {
                txtUser.Text = BUS_QLBH.currentUser.Username;
                txtRole.Text = BUS_QLBH.currentUser.User_role;
                if (BUS_QLBH.currentUser.User_role == "Admin")
                {
                    toolStripMenuItem3.Visible = true;
                    toolStripMenuItem10.Visible = true;
                    menuItem_ThongKe.Visible = true;
                    picNhanVien1.Visible = true;
                    label7.Visible = true;
                    toolStripMenuItem12.Visible = true;
                    toolStripMenuItem14.Visible = true;
                    toolStripMenuItem13.Visible = true;
                    danhSáchNhânViênToolStripMenuItem.Visible = true;
                }
                else if (BUS_QLBH.currentUser.User_role == "User")
                {
                    toolStripMenuItem3.Visible = false;
                    toolStripMenuItem10.Visible = false;
                    menuItem_ThongKe.Visible = false;
                    picNhanVien1.Visible = false;
                    label7.Visible = false;
                    toolStripMenuItem12.Visible = false;
                    toolStripMenuItem14.Visible = false;
                    toolStripMenuItem13.Visible = false;
                    danhSáchNhânViênToolStripMenuItem.Visible = false;
                }
            }
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            BUS_QLBH.currentUser = null;
            this.Hide();
            fmDangNhap fmDN = new fmDangNhap();
            fmDN.ShowDialog();
        }

        private void thốngKêHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmHangHoa fmHangHoa = new fmHangHoa();
            fmHangHoa.ShowDialog();
        }
    }
}
