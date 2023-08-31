using BUS;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Wordprocessing;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace QLBH
{
    public partial class fmBanHang : Form
    {
        private BUS_QLBH bus = new BUS_QLBH();
        private int stt = 0;
        private DataTable producttable = new DataTable();
        public fmBanHang()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void grbHoaDon_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void fmBanHang_Load(object sender, EventArgs e)
        {
            // Tạo DataTable
           

            // Thêm các cột vào DataTable
            producttable.Columns.Add("STT", typeof(string));
            producttable.Columns.Add("Sản phẩm", typeof(string));
            producttable.Columns.Add("Số lượng", typeof(int));
            producttable.Columns.Add("Giá", typeof(decimal));
            dgvSanPham.DataSource = producttable;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(txtMaSP.Text != "" && txtquantity.Text != "")
            {
                //int id = int.Parse(txtMaSP.Text);
                //int quantity = int.Parse(txtquantity.Text);
                //List<string> pro = bus.getTest(id);
                //string result = null;
                //foreach(string s in pro)
                //{
                //    result += s + " ";
                //}
                //MessageBox.Show(result);
                stt++;
                int id = int.Parse(txtMaSP.Text);
                int quantity = int.Parse(txtquantity.Text);
                DTO_Product pro = bus.get1Product(id);
                if (pro != null)
                {
                    float price = pro.Price * quantity;
                    producttable.Rows.Add(stt, pro.Productname, quantity, price);
                    dgvSanPham.DataSource = producttable;
                }
                else MessageBox.Show("khong ton tai san pham");
                total();
                reset();
                reloadData();
            }
        }
        private void reloadData()
        {
            // Lấy danh sách các đối tượng mới từ cơ sở dữ liệu

            // Gán danh sách đối tượng mới vào thuộc tính DataSource của DataGridView
            dgvSanPham.DataSource = producttable;

            // Load lại dữ liệu trong DataGridView từ danh sách đối tượng mới
            dgvSanPham.Refresh();
        }
        private void SelectedRowData(int rowIndex)
        {
            
            DataGridViewRow selectedRow = dgvSanPham.Rows[rowIndex];
            string name = selectedRow.Cells["Sản phẩm"].Value.ToString();
            txtquantity.Text = selectedRow.Cells["Số lượng"].Value.ToString();
            txtTenSP.Text = name;
            int id = bus.getIdProductByName(name);
            txtMaSP.Text = id.ToString();
        }
        private void total()
        {
            float result = 0;
            foreach (DataRow row in producttable.Rows)
            {
                float price = 0;
                if (float.TryParse(row["Giá"].ToString(), out price))
                {
                    result += price;
                }
            }
            txtTienThanhToan.Text = result.ToString("#,##0");
        }

        private void txtTienThanhToan_TextChanged(object sender, EventArgs e)
        {
            float tien = float.Parse(txtTienThanhToan.Text);
            float total = float.Parse(txtTienThanhToan.Text);
            float result = tien - total;
            if (result >= 0)
            {
                txtTienThua.Text = result.ToString();
            }
            else if (result < 0)
            {
                txtTienThua.Text = "Chua đủ tiền";
            }
        }

        private void txtquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Loại bỏ ký tự đó
                e.Handled = true;
            }
        }
        private void reset()
        {
            txtMaSP.Text = "";
            txtquantity.Text = "";
            txtTenSP.Text = "";
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDiaChi.Text = "";
            txtSoDienThoai.Text = "";
        }
        private void resetTien()
        {
            txtTienThanhToan.Text = "0";
            txtTienKhach.Text = "0";
            txtTienThua.Text = "0";
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectedRowData(e.RowIndex);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvSanPham.CurrentRow != null)
            {
                string STT = dgvSanPham.CurrentRow.Cells[0].Value.ToString();
                string value = txtTenSP.Text;
                string query = string.Format("[STT] = '{0}'", STT);
                DataRow[] rowsToDelete = producttable.Select(query);
                if (rowsToDelete.Length > 0)
                {
                    foreach (DataRow row in rowsToDelete)
                    {
                        producttable.Rows.Remove(row);
                    }
                }
                else MessageBox.Show("Không tìm thấy sản phẩm");
            }
            else MessageBox.Show("Không tìm thấy sản phẩm");

            reloadData();
            total();
            reset();
        }

        private void btnXoaHet_Click(object sender, EventArgs e)
        {
            producttable.Clear();
            reloadData();
            total();
            reset();
        }

        private void txtTienKhach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Loại bỏ ký tự đó
                e.Handled = true;
            }
          
        }

        private void txtTienKhach_TextChanged(object sender, EventArgs e)
        {
            float tien;
            if (float.TryParse(txtTienKhach.Text, out tien))
            {
                float total = float.Parse(txtTienThanhToan.Text);
                float result = tien - total;
                if (result >= 0)
                {
                    txtTienThua.Text = result.ToString("#,##0");
                }
                else if (result < 0)
                {
                    txtTienThua.Text = "Chua đủ tiền";
                }
            }
            else
            {
                txtTienThua.Text = "";
            }
        }
        private int getQuantity(int sothutu)
        {
            List<int> idList = new List<int>();
            foreach (DataRow row in producttable.Rows)
            {
                int id = Convert.ToInt32(row["STT"]);
                idList.Add(id);
            }
            int quantity = 0;
            string query = string.Format("STT = {0}", idList[sothutu].ToString());
            DataRow[] rows = producttable.Select(query);
            if (rows.Length > 0)
            {
                quantity = (int)rows[0]["số lượng"]; // lấy giá trị của cột column_name trong hàng đầu tiên
            }
            return quantity;
        }
        private string submit()
        {
            float total = float.Parse(txtTienThanhToan.Text);
            float tienKhack = float.Parse(txtTienKhach.Text);
            float tienThua = float.Parse(txtTienThua.Text);
            string result = String.Format("Tổng thanh toán: {0} \nTiền nhận được: {1}\nTiền thừa: {2}",
                                        total.ToString("#,##0"), tienKhack.ToString("#,##0"), tienThua.ToString("#,##0"));
            return result;
        }

        private void bnThanhToan_Click(object sender, EventArgs e)
        {
            List<DTO_Product> listProduct = new List<DTO_Product>();
            foreach (DataRow row in producttable.Rows)
            {
                string name = row.Field<string>("Sản phẩm");
                int id = bus.getIdProductByName(name);
                listProduct.Add(bus.get1Product(id));
            }

            DTO_UserApp user = bus.get1User("Admin1", "789");
            if (producttable != null)
            {
                int sothutu = 0;
                DateTime time = DateTime.Now;
                string stringtime = time.ToString("yyyy-MM-dd HH:mm:ss");
                bool result = false;
                bool temp = false;
                bool isQuantity = false;
                DTO_Customer customer = null;
                if (txtMaKH.Text != "")
                {
                    customer = bus.get1Customer(int.Parse(txtMaKH.Text));
                    if (customer != null)
                    {
                        float diem = float.Parse(txtTienThanhToan.Text) / 1000;
                        int point = customer.Point;
                        point += (int)diem;
                        bus.addPoint(customer.CustomerID1, point);
                    }   
                    else MessageBox.Show("Người dùng không tồn tại");
                }
                
                string testquantity = null;
                for(int i = 0; i < listProduct.Count; i++)
                {
                    int proid = listProduct[i].ProductID1;
                    isQuantity = bus.minusQuantity(proid, getQuantity(i));
                    testquantity += string.Format("{0} : {1} \n", proid, getQuantity(i));
                }
                if (isQuantity) temp = bus.addBill(time, user.UserID1, float.Parse(txtTienThanhToan.Text));
                else MessageBox.Show("hết hàng, số lượng vượt quá số lượng hàng còn");
                if (temp == true && isQuantity)
                {
                    DTO_Bill bill = bus.getBillByTime(time);
                  

                    foreach (DTO_Product product in listProduct)
                    {
                        result = bus.addBillDetail(bill.BillID1, product.ProductID1, product.Productname, getQuantity(sothutu), product.Price);
                        
                        sothutu++;
                    }
                    if (customer != null && bill != null)
                    {
                        bool test = bus.addCus_bill(customer.CustomerID1, bill.BillID1);
                        if(test == false)
                        {
                            MessageBox.Show("Khong The tich diem");
                        }
                    }
                }
                else MessageBox.Show("That Bai");
                if (result == true)
                {
                    string tien = submit();
                    MessageBox.Show(tien);
                    reset();
                    producttable.Clear();
                    reloadData();
                    resetTien();
                }
                else MessageBox.Show("That Bai"); 
                stt = 0;

            }



        }

      

        private void txtMaKH_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void bnThoat_Click(object sender, EventArgs e)
        {
            //List<int> idList = new List<int>();
            //foreach (DataRow row in producttable.Rows)
            //{
            //    int id = Convert.ToInt32(row["STT"]);
            //    idList.Add(id);
            //}
            //string test = null;
            //foreach(int id in idList)
            //{
            //    test += id.ToString() + " ";
            //}
            //MessageBox.Show(idList[0].ToString());
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtThemKH_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text != "" && txtDiaChi.Text != "" && txtSoDienThoai.Text != "")
            {
                bool result = bus.addCustomer(txtTenKH.Text, txtDiaChi.Text, txtSoDienThoai.Text);
                if (result) { MessageBox.Show("Thành công"); }
                else MessageBox.Show("Thất Bại");
            }
            else MessageBox.Show("Thiếu thông tin");
        }

        private void txtInfo_Click(object sender, EventArgs e)
        {
            if(txtMaKH.Text != "")
            {
                DTO_Customer customer = bus.get1Customer(int.Parse(txtMaKH.Text));
                if (customer != null)
                {
                    string result = string.Format("Tên người dùng: {0}\n" +
                                                "Địa chỉ: {1}\n" +
                                                "Số điện thoại: {2}\n" +
                                                "Điểm tích lũy: {3}\n ",
                                                customer.Name, customer.Addrees, customer.Phone, customer.Point);
                    MessageBox.Show(result, "Thông tin");
                }
                else MessageBox.Show("Không tồn tại thông tin khách hàng");
            }
        }

        private void txtMaKH_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Loại bỏ ký tự đó
                e.Handled = true;
            }
        }

       
    }
}
