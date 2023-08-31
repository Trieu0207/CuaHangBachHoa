using BUS;
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
    public partial class fmKhachHang : Form
    {
        BUS_QLBH bus = new BUS_QLBH();
        public fmKhachHang()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtMaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Loại bỏ ký tự đó
                e.Handled = true;
            }
        }
        private void reset()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtDiem.Text = "";
        }

        private void fmKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dATABASEQLBHDataSet13.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter1.Fill(this.dATABASEQLBHDataSet13.Customer);
            // TODO: This line of code loads data into the 'dATABASEQLBHDataSet12.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.dATABASEQLBHDataSet12.Customer);

        }
        private void SelectedRowData(int rowIndex)
        {
            DataGridViewRow selectedRow = dgvKhachHang.Rows[rowIndex];
            txtMaKH.Text = selectedRow.Cells["CustomerID"].Value.ToString();
            txtTenKH.Text = selectedRow.Cells["name"].Value.ToString();
            txtDiaChi.Text = selectedRow.Cells["addrees"].Value.ToString();
            txtDienThoai.Text = selectedRow.Cells["phone"].Value.ToString();
            txtDiem.Text = selectedRow.Cells["point"].Value.ToString();
          
        }
        private void reload()
        {
            // Lấy danh sách các đối tượng mới từ cơ sở dữ liệu
            DataTable objects = bus.getAllCustomer();

            // Gán danh sách đối tượng mới vào thuộc tính DataSource của DataGridView
            dgvKhachHang.DataSource = objects;

            // Load lại dữ liệu trong DataGridView từ danh sách đối tượng mới
            dgvKhachHang.Refresh();
        }
        private void bnHoanTac_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtTenKH.Text != "" && txtDienThoai.Text != "" && txtDiaChi.Text != "")
            {
                bool result = bus.addCustomer(txtTenKH.Text, txtDiaChi.Text, txtDienThoai.Text);
                if (result) { MessageBox.Show("Thêm thành công"); }
                else MessageBox.Show("Thêm khách hàng thất bại");
                reload();
                reset();
            }
        }

        private void bn_Sua_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text != "" && txtTenKH.Text != "" && txtDienThoai.Text != "" && txtDiaChi.Text != "" )
            {
                int check;
                if(int.TryParse(txtMaKH.Text, out check))
                {
                    bool result = bus.updateCustomer(int.Parse(txtMaKH.Text), txtTenKH.Text, txtDiaChi.Text, txtDienThoai.Text);
                    if (result) { MessageBox.Show("Thành công"); }
                    else MessageBox.Show("Thất bại");
                }
                else MessageBox.Show("Mã khách hàng không tồn tại");
                reload();
                reset();
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRowData(e.RowIndex);
        }

        private void bnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text != "")
            {
                int check;
                if (int.TryParse(txtMaKH.Text, out check))
                {
                    bool result = bus.delCustomer(int.Parse(txtMaKH.Text));
                    if (result) { MessageBox.Show("Thành công"); }
                    else MessageBox.Show("Thất bại");
                }
                else MessageBox.Show("Mã khách hàng không tồn tại");
                reload();
                reset();
            }
        }

        private void bnInDanhSachNV_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bus.exportCustomerToExcel(saveFileDialog.FileName);
            }
        }

        private void bn_Dong_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
