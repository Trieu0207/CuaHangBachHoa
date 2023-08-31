using BUS;
using DocumentFormat.OpenXml.Office2010.Excel;
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
    public partial class fmNhaCungCap : Form
    {
        List<int[]> list = new List<int[]>();
        BUS_QLBH bus = new BUS_QLBH();
        public fmNhaCungCap()
        {
            InitializeComponent();
        }

        private void fmNhaCungCap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dATABASEQLBHDataSet11.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.dATABASEQLBHDataSet11.Product);
            dgvProduct.DataSource = bus.getProductQuantity();
           

        }
        private void SelectedRowData(int rowIndex)
        {
            DataGridViewRow selectedRow = dgvProduct.Rows[rowIndex];
            txtMaSP.Text = selectedRow.Cells["ProductID"].Value.ToString();
            txtName.Text = selectedRow.Cells["productname"].Value.ToString();
            txtquantity.Text = selectedRow.Cells["quantity"].Value.ToString();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string columnNames = "";

            // Lặp qua các cột của DataGridView
            foreach (DataGridViewColumn column in dgvProduct.Columns)
            {
                // Thêm tên của cột vào chuỗi columnNames, phân cách bởi dấu phẩy
                columnNames += column.Name + ",";
            }
            MessageBox.Show(columnNames);
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectedRowData(e.RowIndex);
            }
        }

        private void txtNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Loại bỏ ký tự đó
                e.Handled = true;
            }
        }
        private void reload()
        {
            // Lấy danh sách các đối tượng mới từ cơ sở dữ liệu
            DataTable objects = bus.getProductQuantity();

            // Gán danh sách đối tượng mới vào thuộc tính DataSource của DataGridView
            dgvProduct.DataSource = objects;

            // Load lại dữ liệu trong DataGridView từ danh sách đối tượng mới
            dgvProduct.Refresh();
        }
        private void reset()
        {
            txtMaSP.Text = "";
            txtName.Text = "";
            txtNhap.Text = "";
            txtquantity.Text = "";
        }

        private void bnThem_Click(object sender, EventArgs e)
        {
            int id;
            int quantiity;
            if (int.TryParse(txtMaSP.Text, out id) && int.TryParse(txtNhap.Text, out quantiity))
            {

                string warning = string.Format("Tên sản phẩm: {0}\n" +
                                                 "Số lượng tồn: {1}\n" +
                                               "Số lượng nhập: {2}", txtName.Text, txtquantity.Text, txtNhap.Text);
                DialogResult result = MessageBox.Show(warning, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool kq = false;
                    
                    if (int.TryParse(txtMaSP.Text, out id) && int.TryParse(txtNhap.Text, out quantiity))
                        kq = bus.addquantity(int.Parse(txtMaSP.Text), int.Parse(txtNhap.Text));
                    if (!kq)
                    {


                        MessageBox.Show("thêm không thành công");
                    }
                    else
                    {
                        list.Add(new int[] { int.Parse(txtMaSP.Text), int.Parse(txtNhap.Text) });
                        reload();
                        reset();
                    }
                }
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (list.Count == 0)
            {
                MessageBox.Show("Bạn chưa thực hiện thao tác nào");
            }

            else
            {
                bool result = false;
                DialogResult kq = MessageBox.Show("Bạn có chắc muốn hoàn tác", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                {
                    int id;

                    if (int.TryParse(txtMaSP.Text, out id))
                    {
                        int proid = int.Parse(txtMaSP.Text);

                        for (int i = list.Count - 1; i >= 0; i--)
                        {
                            int[] item = list[i];

                            item = list[i];
                            if (item[0] == proid)
                            {
                                result = bus.minusQuantity(proid, item[1]);
                                list.RemoveAt(i);
                                break;
                            }

                        }
                    }
                    else
                    {
                        for (int i = list.Count - 1; i >= 0; i--)
                        {
                            int[] item = list[i];
                            result = bus.minusQuantity(item[0], item[1]);
                            list.RemoveAt(i);
                            break;
                        }

                    }


                }
                reload();
                reset();
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

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            fmSanPham sp = new fmSanPham();
            sp.ShowDialog();
            this.Hide();
        }

        private void bnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
