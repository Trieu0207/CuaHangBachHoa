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
    public partial class fmLoaiSP : Form
    {
        BUS_QLBH bus = new BUS_QLBH();
        public fmLoaiSP()
        {
            InitializeComponent();
        }

        private void fmLoaiSP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dATABASEQLBHDataSet6.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.dATABASEQLBHDataSet6.Category);

        }
        private void reloadData()
        {
            // Lấy danh sách các đối tượng mới từ cơ sở dữ liệu
            DataTable objects = bus.getAllCate();

            // Gán danh sách đối tượng mới vào thuộc tính DataSource của DataGridView
            dgvLoaiSP.DataSource = objects;

            // Load lại dữ liệu trong DataGridView từ danh sách đối tượng mới
            dgvLoaiSP.Refresh();
        }
        private void reset()
        {
            txtDes.Text = "";
            txtname.Text = "";
            txtid.Text = "";
        }

        private void bnThem_Click(object sender, EventArgs e)
        {
              
            if (txtname.Text != "" && txtDes.Text != "")
            {
                bool result = bus.addCate(txtname.Text, txtDes.Text);
                if(result == false)
                {
                    MessageBox.Show("Thêm loại sản phẩm không thành công");
                }
            }
            else MessageBox.Show("Thêm loại sản phẩm không thành công");
            reloadData();
            reset();
            
        }
        private void bnXoa_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {
                int id = int.Parse(txtid.Text);
                bool result = bus.delCate(id);
                if (result == false)
                {
                    MessageBox.Show("Xóa loại sản phẩm không thành công");
                }

            }
            else MessageBox.Show("Xóa loại sản phẩm không thành công");
            reloadData();
            reset();
        }
        private void bnSua_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "" && txtname.Text != "" && txtDes.Text != "")
            {
                int id =  int.Parse(txtid.Text);
                bool result = bus.updateCate(id, txtname.Text, txtDes.Text);
                if (result == false)
                {
                    MessageBox.Show("Sửa loại sản phẩm không thành công");
                }
            }
            else MessageBox.Show("Xóa loại sản phẩm không thành công");
            reloadData();
            reset();
        }
        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Loại bỏ ký tự đó
                e.Handled = true;
            }
        }
        private void SelectedRowData(int rowIndex)
        {
            DataGridViewRow selectedRow = dgvLoaiSP.Rows[rowIndex];
            txtid.Text = selectedRow.Cells["CategoryID"].Value.ToString();
            txtname.Text = selectedRow.Cells["categoryname"].Value.ToString();
            txtDes.Text = selectedRow.Cells["CategoryDescription"].Value.ToString();

        }
        private void dgvLoaiSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectedRowData(e.RowIndex);
            }

        }

        private void bnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }
    }
}
