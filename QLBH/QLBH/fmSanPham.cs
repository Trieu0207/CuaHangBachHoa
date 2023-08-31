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
    public partial class fmSanPham : Form
    {
        BUS_QLBH bus = new BUS_QLBH();
        public fmSanPham()
        {
            InitializeComponent();
        }
       
        private void txtghichu_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bn_Them_Click(object sender, EventArgs e)
        {
            int cate = bus.getIdByNameCate(cbCate.Text);
            float price = float.Parse(txtDonGiaBan.Text);
            int quantity = int.Parse(txtSoLuong.Text);
            if (txtTenSP.Text != "" && txtSoLuong.Text != "" && txtDonGiaBan.Text != "" && cate != 0)
            {
                bool result = bus.addProduct(txtTenSP.Text, cate, price, quantity, txtGhiChu.Text);
                if (result == false) MessageBox.Show("khong the them san pham");
            }
            else MessageBox.Show("khong the them san pham");
            reloadData();
            reset();
        }

        private void bn_Sua_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtMaSP.Text);
            int cate = bus.getIdByNameCate(cbCate.Text);
            float price = float.Parse(txtDonGiaBan.Text);
            int quantity = int.Parse(txtSoLuong.Text);
            bool result = bus.updateProduct(id, txtTenSP.Text, cate, price, quantity, txtGhiChu.Text);
            if (result == false) MessageBox.Show("Khong the sua san pham");
            reloadData();
            reset();

        }

        private void bnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtMaSP.Text);
            bool result = bus.delProduct(id);
            if (result == false) MessageBox.Show("Không thể xóa sản phẩm");
            else reset();
            reloadData();
            reset();
        }

    

        private void bn_Luu_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bus.exportProductToExcel(saveFileDialog.FileName);
            }
        }

        private void bn_Dong_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fmSanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dATABASEQLBHDataSet7.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.dATABASEQLBHDataSet7.Product);
            cbCate.DropDownStyle = ComboBoxStyle.DropDownList;

            List<string> list = bus.getNameCate();
            foreach (string s in list)
            {
                cbCate.Items.Add(s);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Loại bỏ ký tự đó
                e.Handled = true;
            }
        }

        private void txtMaSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Loại bỏ ký tự đó
                e.Handled = true;
            }
        }
        private void txtDonGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Loại bỏ ký tự đó
                e.Handled = true;
            }
        }
        private void reloadData()
        {
            // Lấy danh sách các đối tượng mới từ cơ sở dữ liệu
            DataTable objects = bus.getAllProduct();

            // Gán danh sách đối tượng mới vào thuộc tính DataSource của DataGridView
            dgvSanPham.DataSource = objects;

            // Load lại dữ liệu trong DataGridView từ danh sách đối tượng mới
            dgvSanPham.Refresh();
        }
        private void SelectedRowData(int rowIndex)
        {
            DataGridViewRow selectedRow = dgvSanPham.Rows[rowIndex];
            txtMaSP.Text = selectedRow.Cells["ProductID"].Value.ToString();
            txtTenSP.Text = selectedRow.Cells["productname"].Value.ToString();
            txtDonGiaBan.Text = selectedRow.Cells["price"].Value.ToString();
            txtSoLuong.Text = selectedRow.Cells["quantity"].Value.ToString();
            txtGhiChu.Text = selectedRow.Cells["note"].Value.ToString();
            string temp = selectedRow.Cells["CategoryID"].Value.ToString();
            int id = 0;
            if(temp != "")
                id = int.Parse(temp);
            temp = bus.getNameByIdCate(id);
            cbCate.Text = temp;
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRowData(e.RowIndex);
        }
        private void reset()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtDonGiaBan.Text = "";
            txtSoLuong.Text = "";
            txtGhiChu.Text = "";
            cbCate.Text = "";
        }
    }
}
