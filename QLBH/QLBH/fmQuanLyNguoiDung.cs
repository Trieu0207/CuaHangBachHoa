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
using System.Xml.Linq;

namespace QLBH
{
    public partial class fmQuanLyNguoiDung : Form
    {
        BUS_QLBH bus = new BUS_QLBH();
        public fmQuanLyNguoiDung()
        {
            InitializeComponent();
        }

        private void fmQuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dATABASEQLBHDataSet1.UserApp' table. You can move, or remove it, as needed.
            this.userAppTableAdapter.Fill(this.dATABASEQLBHDataSet1.UserApp);

        }
        private void reloadData()
        {
            // Lấy danh sách các đối tượng mới từ cơ sở dữ liệu
            DataTable objects = bus.getAllUser();

            // Gán danh sách đối tượng mới vào thuộc tính DataSource của DataGridView
            dataGridView1.DataSource = objects;

            // Load lại dữ liệu trong DataGridView từ danh sách đối tượng mới
            dataGridView1.Refresh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bool is_addUser = false;
            if (txtid.Text != "")
            {
                int employeeID = int.Parse(txtid.Text);
                if (bus.check_user(txtUsername.Text, employeeID) == false)
                {
                    int id = int.Parse(txtid.Text);

                    is_addUser = bus.addUser(id, txtUsername.Text, txtPassword.Text, role.Text);
                    if (is_addUser == false) MessageBox.Show("That bai");
                    else
                    {
                        reloadData();
                    }
                }
                else MessageBox.Show("Ten nguoi dung da ton tai");
            }
            else
            {
                MessageBox.Show("Them nguoi dung that bai");
            }
            
            
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
            DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
            txtid.Text = selectedRow.Cells["EmployeeID"].Value.ToString();
            txtUsername.Text = selectedRow.Cells["username"].Value.ToString();
            txtPassword.Text = selectedRow.Cells["password"].Value.ToString();
            role.Text = selectedRow.Cells["user_role"].Value.ToString();
            
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectedRowData(e.RowIndex);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (txtid.Text != "" || txtUsername.Text != "" || txtPassword.Text != "" || role.Text != "")
             {
                 if(txtUsername.Text != "" || txtPassword.Text != "")
                {
                    bool result = bus.delUser(txtUsername.Text, txtPassword.Text);
                    reloadData();
                    if (result == false) MessageBox.Show("loi, Khong the xoa user");
                } else MessageBox.Show("loi, Khong the xoa user");

            }
             else MessageBox.Show("khong the xoa");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (txtid.Text != "" && txtUsername.Text != "" && txtPassword.Text != "" && role.Text != "")
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
                string username = selectedRow.Cells["username"].Value.ToString();
                string passwrod = selectedRow.Cells["password"].Value.ToString();
                int id = int.Parse(txtid.Text);
                bool result = bus.updateUser(id, txtUsername.Text, txtPassword.Text, role.Text, username, passwrod);
                reloadData();
                if (result == false) MessageBox.Show("loi, Khong the sua user");

            }
            else MessageBox.Show("khong the sua");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
