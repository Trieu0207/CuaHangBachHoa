using BUS;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QLBH
{
    public partial class fmDanhSachQLNhanVien : Form
    {
        BUS_QLBH bus = new BUS_QLBH();
        public fmDanhSachQLNhanVien()
        {
            InitializeComponent();
        }

        private void fmDanhSachQLNhanVien_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'dATABASEQLBHDataSet5.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter3.Fill(this.dATABASEQLBHDataSet5.Employees);
            // TODO: This line of code loads data into the 'dATABASEQLBHDataSet4.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter2.Fill(this.dATABASEQLBHDataSet4.Employees);
            // TODO: This line of code loads data into the 'dATABASEQLBHDataSet3.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter1.Fill(this.dATABASEQLBHDataSet3.Employees);
            // TODO: This line of code loads data into the 'dATABASEQLBHDataSet2.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.dATABASEQLBHDataSet2.Employees);

        }
        private void reloadData()
        {
            // Lấy danh sách các đối tượng mới từ cơ sở dữ liệu
            DataTable objects = bus.getAllEmployee();

            // Gán danh sách đối tượng mới vào thuộc tính DataSource của DataGridView
            dgv1.DataSource = objects;

            // Load lại dữ liệu trong DataGridView từ danh sách đối tượng mới
            dgv1.Refresh();
        }
        private void reset()
        {
            txtfirstname.Text = "";
            txtEmail.Text = "";
            txtlastname.Text = "";
            cbgioitinh.Text = "";
            txtDiaChi.Text = "";
            txtMaNhanVien.Text = "";
            txtSDT.Text = "";
        }

        private void bnThem_Click(object sender, EventArgs e)
        {
            string day = dtbNgaySinh.Value.ToString("yyyy/MM/dd");
            if (txtfirstname.Text != "" && txtlastname.Text != "" &&
                txtDiaChi.Text != "" && txtSDT.Text != "" &&
                txtEmail.Text != "" && cbgioitinh.Text != "" && day != null)
            {
                bool result = bus.addEmplyee(txtfirstname.Text, txtlastname.Text, cbgioitinh.Text, txtSDT.Text, txtEmail.Text, day, txtDiaChi.Text);
                if(result == false)
                {
                    MessageBox.Show("khong the them nguoi lam");
                }
                reloadData();
                reset();
            }
        }

        private void bnXoa_Click(object sender, EventArgs e)
        {
            bool result = false;
            if(txtMaNhanVien.Text != "")
            {
                int id = int.Parse(txtMaNhanVien.Text);
                result = bus.delEmployee(id);
            }
            if (result == false) MessageBox.Show("Xoa khong thanh cong");
            reloadData();
            reset();
        }

        private void bnInDanhSachNV_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bus.saveEmployeeToExcel(saveFileDialog.FileName);
            }

        }
        

        private void bnSua_Click(object sender, EventArgs e)
        {
            int rowIndex = dgv1.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dgv1.Rows[rowIndex];
            string temp = selectedRow.Cells["EmployeeID"].Value.ToString();
            int id = int.Parse(temp);
            string day = dtbNgaySinh.Value.ToString("yyyy/MM/dd");
            if (txtfirstname.Text != "" && txtlastname.Text != "" &&
               txtDiaChi.Text != "" && txtSDT.Text != "" &&
               txtEmail.Text != "" && cbgioitinh.Text != "" && day != null)
            {
                bool result = bus.updateEmployee(id, txtfirstname.Text, txtlastname.Text,
                    cbgioitinh.Text, txtSDT.Text, txtEmail.Text, day, txtDiaChi.Text);
                if (result == false)
                {
                    MessageBox.Show("khong the sua nguoi lam");
                }
                reloadData();
                reset();
            }
        }

        private void txtMaNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Loại bỏ ký tự đó
                e.Handled = true;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Loại bỏ ký tự đó
                e.Handled = true;
            }
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectedRowData(e.RowIndex);
            }

        }
        private void SelectedRowData(int rowIndex)
        {
            DataGridViewRow selectedRow = dgv1.Rows[rowIndex];
            txtMaNhanVien.Text = selectedRow.Cells["EmployeeID"].Value.ToString();
            txtfirstname.Text = selectedRow.Cells["firstname"].Value.ToString();
            txtlastname.Text = selectedRow.Cells["lastname"].Value.ToString();
            txtSDT.Text = selectedRow.Cells["phone"].Value.ToString();
            txtEmail.Text = selectedRow.Cells["email"].Value.ToString();
            txtDiaChi.Text = selectedRow.Cells["DiaChi"].Value.ToString();
            string gioitinh = selectedRow.Cells["gioitinh"].Value.ToString();
            dtbNgaySinh.Text = selectedRow.Cells["ngaysinh"].Value.ToString();
            cbgioitinh.Text = selectedRow.Cells["Gioitinh"].Value.ToString();


        }

      

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
