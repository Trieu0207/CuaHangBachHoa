using BUS;
using DocumentFormat.OpenXml.Office2010.Excel;
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
    public partial class fmDSHoaDon : Form
    {
        public fmDSHoaDon()
        {
            InitializeComponent();
        }
        BUS_QLBH bus = new BUS_QLBH();
        DataTable billDetail = new DataTable();
        DataTable billTable = new DataTable();
        private void fmDSHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dATABASEQLBHDataSet10.Bill' table. You can move, or remove it, as needed.
            this.billTableAdapter2.Fill(this.dATABASEQLBHDataSet10.Bill);
            // TODO: This line of code loads data into the 'dATABASEQLBHDataSet9.Bill' table. You can move, or remove it, as needed.
            this.billTableAdapter1.Fill(this.dATABASEQLBHDataSet9.Bill);
            // TODO: This line of code loads data into the 'dATABASEQLBHDataSet8.Bill' table. You can move, or remove it, as needed.
            this.billTableAdapter.Fill(this.dATABASEQLBHDataSet8.Bill);
            cbDay.Text = DateTime.Now.ToString("dd");
            cbMonth.Text = DateTime.Now.ToString("MM");
            cbYear.Text = DateTime.Now.ToString("yyyy");
            string time = string.Format("{0}-{1}-{2}", cbYear.Text, cbMonth.Text, cbDay.Text);
            dgvHoaDon.DataSource = bus.getBillInDay(time);
            




        }
        private void reloadBill()
        {
            string timeString = string.Format("{0}-{1}-{2}", cbYear.Text, cbMonth.Text, cbDay.Text);
            DateTime time;
            if (DateTime.TryParse(timeString, out time))
            {
                dgvHoaDon.DataSource = bus.getBillInDay(timeString);
            }
        }
        private void bnChiTiet_Click(object sender, EventArgs e)
        {
            int id;
            DateTime time;
            if (int.TryParse(txtBillid.Text, out id))
            {
                id = Convert.ToInt32(txtBillid.Text);
                DataTable billDetail = bus.getBillDetailByBillid(id);
                dgvBillDetail.DataSource = billDetail;
                DTO_Bill bill = bus.get1Bill(id);
                if(bill != null)
                {
                    txtBillid2.Text = bill.BillID1.ToString();
                    txtTime.Text = bill.Time.ToString();
                    txtUserid.Text = bill.UserID1.ToString();
                    txtTotal.Text = bill.Totalprice.ToString("#,##0");
                }
                else MessageBox.Show("Hoá đơn không tồn tại");

            }
            else MessageBox.Show("Hoá đơn không tồn tại");
            
            
            
        }
        private void SelectedRowData(int rowIndex)
        {
            DataGridViewRow selectedRow = dgvHoaDon.Rows[rowIndex];
            txtBillid2.Text = selectedRow.Cells["BillID"].Value.ToString();
            txtTime.Text = selectedRow.Cells["Time"].Value.ToString();
            txtUserid.Text = selectedRow.Cells["UserID"].Value.ToString();
            txtTotal.Text = selectedRow.Cells["totalprice"].Value.ToString();
            DataTable billDetail = bus.getBillDetailByBillid(int.Parse(txtBillid2.Text));
            dgvBillDetail.DataSource = billDetail;
        }

        private void txtChiTiet_Leave(object sender, EventArgs e)
        {
            TextBox txtbox = (TextBox)sender;
            if (txtbox.Text == "")
            {
                txtbox.Text = "mã hóa đơn";
            }
        }

        private void txtChiTiet_Enter(object sender, EventArgs e)
        {
            TextBox txtbox = (TextBox)sender;
            if (txtbox.Text.Equals("mã hóa đơn"))
            {
                txtbox.Text = "";
            }
        }

       

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtChiTiet_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBillid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Loại bỏ ký tự đó
                e.Handled = true;
            }
        }
        private void txtKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Loại bỏ ký tự đó
                e.Handled = true;
            }
        }
        private void cb_Enter(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            cb.Text = "";
        }

        private void txtBillid_Click(object sender, EventArgs e)
        {
            TextBox txtbox = (TextBox)sender;
            if (txtbox.Text.Equals("mã hóa đơn"))
            {
                txtbox.Text = "";
            }
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            string timeString = string.Format("{0}-{1}-{2}", cbYear.Text, cbMonth.Text, cbDay.Text);
            DateTime time;
            if (DateTime.TryParse(timeString, out time))
            {
                dgvHoaDon.DataSource = bus.getBillInDay(timeString);
            }
            else MessageBox.Show("Ngày tháng không hợp lệ");
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRowData(e.RowIndex);
        }
        private void afterDelete()
        {
            string timeString = string.Format("{0}-{1}-{2}", cbYear.Text, cbMonth.Text, cbDay.Text);
            DateTime time;
            if (DateTime.TryParse(timeString, out time))
            {
                dgvHoaDon.DataSource = bus.getBillInDay(timeString);
            }

            dgvHoaDon.Refresh();
            int id;
            if (int.TryParse(txtBillid.Text, out id))
            {
                id = Convert.ToInt32(txtBillid.Text);
                DataTable billDetail = bus.getBillDetailByBillid(id);
                dgvBillDetail.DataSource = billDetail;
            }
            else
            {
                id = 0;
                DataTable billDetail = bus.getBillDetailByBillid(id);
                dgvBillDetail.DataSource = billDetail;
            }

            }
        private void txtDelBill_Click(object sender, EventArgs e)
        {
            if(txtBillid2 != null)
            {

                DialogResult result = MessageBox.Show("Bạn có chắc xóa hóa đơn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool deleteBillDetail = bus.delBillDetailByBillId(int.Parse(txtBillid2.Text));
                    bool deleteBill = bus.delBill(int.Parse(txtBillid2.Text));
                    if (deleteBill && deleteBillDetail)
                    {
                        MessageBox.Show("Xóa thành công");
                        afterDelete();
                    }
                    else MessageBox.Show("Xóa Thất Bại");
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
